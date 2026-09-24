#time on

fsi.PrintLength <- 10
fsi.PrintSize <- 100

// fsi.ShowDeclarationValues <- false
#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "SharedKernel.dll"
#r "StringModule.dll"
#r "ResourceIdentification.dll"
#r "ResourceDescription.dll"
#r "Iana.dll"
#r @"IanaScheme.dll"
#r @"IanaMime.dll"

#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "PrettierNaming.fsx"
#load "Ast.fsx"

open SharedKernel
open StringModule
open Iana
open ResourceIdentification
open ResourceDescription
#I @"D:\https\com\github\eristocrates\ipa\fsx\Sites"

#load @".paket/load/main.group.fsx"

open System
open System.Web
open System.Linq
open System.Collections
open FSharp.Data
open TextCopy
open Nager.PublicSuffix
open Nager.PublicSuffix.Models
open Nager.PublicSuffix.RuleProviders
open System.Text
open System.Net
open System.IO
open Fabulous.AST
open Fantomas.Core
open System.Globalization
open ModelingEvolution.Ipv4
open System.Net.Sockets
open Dubzer.WhatwgUrl
open VDS.Common.Tries
open Meziantou.Framework
open Microsoft.AspNetCore.Http
open ktsu.Semantics.Paths
//open Universal.Common
open FolkerKinzel.MimeTypes
open Tavis.UriTemplates
open Humanizer
open CaseConverter
open PuppeteerSharp
open PuppeteerSharp.Cdp
open BrowserApi
open BrowserApi.Common
open System.Collections.Concurrent
open PuppeteerSharp.Cdp.Messaging
open System.Numerics
open System.Threading.Tasks
open WebDriverBiDi
open WebDriverBiDi.Session
open WebDriverBiDi.BrowsingContext
open BrowserApi.Css.Authoring
open IriTools
open VDS.RDF
open LSL.DataUri

type BiDiDriver with
    static member Connect() =
        let driver = BiDiDriver(TimeSpan.FromSeconds 30.)
        task { return! driver.StartAsync("ws://127.0.0.1:9223/session") } |> await
        driver.Session.NewSessionAsync(NewCommandParameters()) |> await |> ignore
        driver

    member this.BrowsingContextTree =
        task {
            let! tree = this.BrowsingContext.GetTreeAsync(GetTreeCommandParameters())
            return tree.ContextTree |> Seq.toArray
        }
        |> await

type BrowsingContextInfo with
    member this.iriref = IriReference this.Url

type IBrowser with
    member this.asCdp = this :?> CdpBrowser

type IBrowserContext with
    member this.asCdp = this :?> CdpBrowserContext

type IRequest with
    member this.asCdp = this :?> CdpHttpRequest

type IResponse with
    member this.asCdp = this :?> CdpHttpResponse

type IPage with
    member this.asCdp = this :?> CdpPage

type IFrame with
    member this.asCdp = this :?> CdpFrame

type Target with
    member this.asCdp = this :?> CdpTarget
type ITarget with
    member this.asCdp = this :?> CdpTarget

type IElementHandle with
    member this.asCdp = this :?> CdpElementHandle

module BrowserApiReflection =
    open BrowserApi.Common
    open System.Reflection

    let private handleSetter = typeof<JsObject>.GetProperty("Handle", BindingFlags.Instance ||| BindingFlags.Public).GetSetMethod(true)

    let fromHandle<'T when 'T :> JsObject> (handle: JsHandle) : 'T =

        let instance = Activator.CreateInstance(typeof<'T>) :?> 'T

        handleSetter.Invoke(instance, [| box handle |]) |> ignore

        instance

// ---------------------------------------------------------------------------
// CDP handle normalization
//
// PuppeteerSharp's EvaluateFunctionHandleAsync signature returns IJSHandle,
// even when operating through CdpFrame. We immediately narrow that boundary
// back to the concrete CDP hierarchy.
// ---------------------------------------------------------------------------

let private asCdpHandle (handle: IJSHandle) : JSHandle =
    match handle with
    | :? CdpElementHandle as handle -> handle :> JSHandle

    | :? CdpJSHandle as handle -> handle :> JSHandle

    | handle -> invalidOp $"Expected a CDP JavaScript handle, but received {handle.GetType().FullName}."

let private remoteObject (handle: JSHandle) =
    match handle with
    | :? CdpElementHandle as handle -> handle.RemoteObject

    | :? CdpJSHandle as handle -> handle.RemoteObject

    | handle -> invalidOp $"Expected a CDP JavaScript handle, but received {handle.GetType().FullName}."

// ---------------------------------------------------------------------------
// BrowserApi return conversion
//
// BrowserApi's JsObject layer asks the backend for a raw value and then does
// its own JsObject / enum / primitive conversion.
//
// Therefore:
//     JS primitive -> .NET primitive
//     JS object    -> JsHandle
// ---------------------------------------------------------------------------

let private coerce<'T> (value: obj) : 'T =
    if isNull value then
        Unchecked.defaultof<'T>
    elif typeof<'T>.IsInstanceOfType value then
        unbox<'T> value
    elif value :? IConvertible && typeof<IConvertible>.IsAssignableFrom typeof<'T> then
        Convert.ChangeType(value, typeof<'T>) |> unbox<'T>
    else
        unbox<'T> value

// ---------------------------------------------------------------------------
// BrowserApi <-> Puppeteer CDP backend
// ---------------------------------------------------------------------------

type CdpRealm(frame: CdpFrame) as this =
    do JsObject.Backend <- this :> IBrowserBackend

    let handles = ConcurrentDictionary<JsHandle, JSHandle>()

    // IMPORTANT:
    //
    // The BrowserApi handle contains the REAL Puppeteer handle.
    //
    // The dictionary exists solely because JsHandle.Value is internal,
    // preventing an external IBrowserBackend from reading it back.
    let wrap (puppeteerHandle: JSHandle) =
        let browserHandle = JsHandle(box puppeteerHandle)

        handles[browserHandle] <- puppeteerHandle

        browserHandle

    let unwrap (browserHandle: JsHandle) =
        match handles.TryGetValue browserHandle with
        | true, puppeteerHandle -> puppeteerHandle

        | false, _ -> invalidOp "Unknown BrowserApi JsHandle."

    let convertArgument (value: obj) =
        match value with
        | null -> null

        | :? JsHandle as browserHandle -> box (unwrap browserHandle)

        // This case is intentional.
        //
        // BrowserApi itself sometimes accesses JsHandle.Value internally.
        // Because Value contains our actual JSHandle, it can arrive here
        // directly and Puppeteer already knows how to pass it to JavaScript.
        | :? JSHandle -> value

        | value -> value

    let numberValue (handle: JSHandle) (remote: RemoteObject) =
        task {
            match remote.UnserializableValue with
            | "NaN" -> return Double.NaN

            | "Infinity" -> return Double.PositiveInfinity

            | "-Infinity" -> return Double.NegativeInfinity

            | "-0" -> return -0.0

            | _ -> return! handle.JsonValueAsync<double>()
        }

    let convertResultAsync (result: IJSHandle) =
        task {
            let handle = asCdpHandle result

            let remote = remoteObject handle

            match remote.Type, remote.Subtype with

            | _, RemoteObjectSubtype.Null ->
                do! handle.DisposeAsync().AsTask()
                return null

            | RemoteObjectType.Undefined, _ ->
                do! handle.DisposeAsync().AsTask()
                return null

            | RemoteObjectType.String, _ ->
                let! value = handle.JsonValueAsync<string>()

                do! handle.DisposeAsync().AsTask()

                return box value

            | RemoteObjectType.Boolean, _ ->
                let! value = handle.JsonValueAsync<bool>()

                do! handle.DisposeAsync().AsTask()

                return box value

            | RemoteObjectType.Number, _ ->
                let! value = numberValue handle remote

                do! handle.DisposeAsync().AsTask()

                return box value

            | RemoteObjectType.Bigint, _ ->
                let lexicalForm = remote.UnserializableValue.TrimEnd('n')

                let value = BigInteger.Parse lexicalForm

                do! handle.DisposeAsync().AsTask()

                return box value

            | RemoteObjectType.Symbol, _ ->
                do! handle.DisposeAsync().AsTask()

                return raise (NotSupportedException("JavaScript Symbol values are not yet supported by the CDP BrowserApi backend."))

            | _ ->
                // Objects and functions remain live remote objects.
                return box (wrap handle)
        }

    let convertResult result = convertResultAsync result |> _.await

    new(page: CdpPage) = CdpRealm(page.MainFrame.asCdp)
    member this.Frame = frame

    member this.Wrap(handle: JSHandle) = wrap handle
    member this.document =

        let handle = (this :> IBrowserBackend).GetGlobal("document")

        BrowserApiReflection.fromHandle<BrowserApi.Dom.Document> handle

    member this.window =

        let handle = (this :> IBrowserBackend).GetGlobal("window")

        BrowserApiReflection.fromHandle<BrowserApi.Dom.Window> handle

    interface IBrowserBackend with

        member this.GetProperty<'T>(target, propertyName) =

            let targetHandle = unwrap target

            let result =
                targetHandle
                    .EvaluateFunctionHandleAsync(
                        """
                        (target, propertyName) =>
                            target[propertyName]
                        """,
                        [| box propertyName |]
                    )
                    .await

            result |> convertResult |> coerce<'T>

        member this.SetProperty(target, propertyName, value) =

            let targetHandle = unwrap target

            targetHandle
                .EvaluateFunctionAsync(
                    """
                    (target, propertyName, value) => {
                        target[propertyName] = value;
                    }
                    """,
                    [| box propertyName; convertArgument value |]
                )
                .await
            |> ignore

        member this.Invoke<'T>(target, methodName, arguments) =

            let targetHandle = unwrap target

            let arguments = Array.append [| box methodName |] (arguments |> Array.map convertArgument)

            let result =
                targetHandle
                    .EvaluateFunctionHandleAsync(
                        """
                        (target, methodName, ...arguments) =>
                            target[methodName](...arguments)
                        """,
                        arguments
                    )
                    .await

            result |> convertResult |> coerce<'T>

        member this.InvokeVoid(target, methodName, arguments) =

            let targetHandle = unwrap target

            let arguments = Array.append [| box methodName |] (arguments |> Array.map convertArgument)

            targetHandle
                .EvaluateFunctionAsync(
                    """
                    (target, methodName, ...arguments) => {
                        target[methodName](...arguments);
                    }
                    """,
                    arguments
                )
                .await
            |> ignore

        member this.InvokeAsync<'T>(target, methodName, arguments) =

            task {
                let targetHandle = unwrap target

                let arguments = Array.append [| box methodName |] (arguments |> Array.map convertArgument)

                let! result =
                    targetHandle.EvaluateFunctionHandleAsync(
                        """
                        (target, methodName, ...arguments) =>
                            target[methodName](...arguments)
                        """,
                        arguments
                    )

                let! converted = convertResultAsync result

                return coerce<'T> converted
            }

        member this.InvokeVoidAsync(target, methodName, arguments) =

            task {
                let targetHandle = unwrap target

                let arguments = Array.append [| box methodName |] (arguments |> Array.map convertArgument)

                let! _ =
                    targetHandle.EvaluateFunctionAsync(
                        """
                        (target, methodName, ...arguments) => {
                            target[methodName](...arguments);
                        }
                        """,
                        arguments
                    )
                return ()
            }
            :> Task

        member this.GetGlobal(name) =

            frame
                .EvaluateFunctionHandleAsync(
                    """
                    name => globalThis[name]
                    """,
                    [| box name |]
                )
                .await
            |> asCdpHandle
            |> wrap

        member this.Construct(jsClassName, arguments) =

            let arguments = Array.append [| box jsClassName |] (arguments |> Array.map convertArgument)

            frame
                .EvaluateFunctionHandleAsync(
                    """
                    (className, ...arguments) => {
                        const constructor =
                            className
                                .split(".")
                                .reduce(
                                    (current, part) => current[part],
                                    globalThis
                                );

                        return Reflect.construct(
                            constructor,
                            arguments
                        );
                    }
                    """,
                    arguments
                )
                .await
            |> asCdpHandle
            |> wrap

        member this.DisposeHandle(browserHandle) =

            match handles.TryRemove browserHandle with
            | true, puppeteerHandle -> puppeteerHandle.DisposeAsync()

            | false, _ -> ValueTask.CompletedTask

        member this.AddEventListener(_, _, _) =
            raise (NotSupportedException("BrowserApi events have not yet been implemented by CdpBrowserApiBackend."))

        member this.RemoveEventListener(_, _, _) =
            raise (NotSupportedException("BrowserApi events have not yet been implemented by CdpBrowserApiBackend."))

        member this.DisposeAsync() =

            let dispose =
                task {
                    for KeyValue(_, handle) in handles do
                        do! handle.DisposeAsync().AsTask()

                    handles.Clear()
                }

            ValueTask(dispose :> Task)

module HttpHeader =
    let Irn (requestId: string) (fieldName: string) = {
        namespaceIdentifier = "chromedevtools"
        namespaceSpecificString = $"http:header:{fieldName}:{requestId}"
    }
type CdpHttpRequest with
    member this.iriref = IriReference this.Url

    member this.iri = NamedReference this.iriref
    member this.originIri = NamedReference this.iriref.Origin
    member this.headers = this.Headers |> Seq.map (fun kvp -> kvp.Key, kvp.Value) |> Seq.toArray

    member this.header(targetHeader: string) =
        this.headers
        |> Array.tryPick (fun (headerKey, headerValue) -> if headerKey = targetHeader then Some headerValue else None)

    member this.PostText = if this.HasPostData then Some this.PostData else None
    member this.CdpRequestId = this.Id
    member this.irn = {
        namespaceIdentifier = "chromedevtools"
        namespaceSpecificString = $"http:request:{this.Id}"
    }

    member this.headerIrns =
        this.headers
        |> Array.map (fun (fieldName, fieldValue) -> HttpHeader.Irn this.Id fieldName)
        |> Array.toList

type MimeType with
    static member fromHeaders(headerDictionary: Generic.Dictionary<string, string>) =
        try
            MimeType.TryParse(headerDictionary["content-type"])
            |> fun (wasParsed, mimeType) ->
                match wasParsed with
                | true -> Some mimeType
                | false -> None
        with _ ->
            None

type CdpHttpResponse with
    member this.iriref = IriReference this.Url
    member this.iri = NamedReference this.iriref
    member this.originIri = NamedReference this.iriref.Origin

    member this.headers = this.Headers |> Seq.map (fun kvp -> kvp.Key, kvp.Value) |> Seq.toArray

    member this.Text() =
        try
            task { return! this.TextAsync() } |> await |> Some
        with err ->
            let headers =
                this.headers
                |> Array.map (fun (key, value) -> $"{key}:{value}")
                |> String.concat "\n"
            printfn "request %s %s threw %s" this.Url headers err.Message
            None

    member this.mimeType = MimeType.fromHeaders this.Headers
    member this.mediaType = MimeType.fromHeaders this.Headers

    member this.WriteAllText() =
        match this.Text() |> Option.tryNullOrWhiteSpace with
        | Some text ->
            Path.GetDirectoryName this.iriref.localReference
            |> Directory.CreateDirectory
            |> ignore
            printfn "%s ----> %s" this.iriref.remoteReference this.iriref.localReference

            File.WriteAllText(this.iriref.localReference, text)
        | None -> ()
    member this.WriteAllText(extensionOverride: FileExtension) =
        match this.Text() |> Option.tryNullOrWhiteSpace with
        | Some text ->
            let localFilePath =
                match this.iriref.tryDotExtension with
                | Some dotExtension -> Path.ChangeExtension(this.iriref.localReference, extensionOverride.WeakString)
                | None -> this.iriref.localReference + extensionOverride.WeakString
            Path.GetDirectoryName localFilePath |> Directory.CreateDirectory |> ignore
            printfn "%s ----> %s" this.iriref.remoteReference localFilePath

            File.WriteAllText(localFilePath, text)
        | None -> ()
    member this.WriteAllText(pathOverride: AbsoluteFilePath) =
        match this.Text() |> Option.tryNullOrWhiteSpace with
        | Some text ->
            let localFilePath = pathOverride
            Directory.CreateDirectory pathOverride.DirectoryPath.WeakString |> ignore
            printfn "%s ----> %s" this.iriref.remoteReference localFilePath.WeakString

            File.WriteAllText(localFilePath.WeakString, text)

        | None -> ()

    member this.CdpRequestId = (this :> IResponse).Request.Id
    member this.irn = {
        namespaceIdentifier = "chromedevtools"
        namespaceSpecificString = $"http:response:{this.CdpRequestId}"
    }
    member this.headerIrns =
        this.headers
        |> Array.map (fun (fieldName, fieldValue) -> HttpHeader.Irn this.CdpRequestId fieldName)
        |> Array.toList
    member this.tryBody =
        match this.BufferAsync().AsTask().Result with
        | [||] -> None
        | bytes -> Some bytes
    member this.bodyIrn = {
        namespaceIdentifier = "chromedevtools"
        namespaceSpecificString = $"http:body:{this.CdpRequestId}"
    }
    member this.tryBodyDataUri =
        match this.tryBody, this.mimeType with
        | Some body, Some mime -> DataUri(body, mime.contentType) |> Some
        | Some body, None -> DataUri(body, IanaMime.application.octet.stream.contentType) |> Some
        | _, _ -> None
    member this.tryTextDataUri =
        match this.Text(), this.mimeType with
        | Some text, Some mime -> DataUri(text.asUtf8, mime.contentType) |> Some
        | Some text, None -> DataUri(text.asUtf8, IanaMime.application.octet.stream.contentType) |> Some
        | _, _ -> None

// TODO try dynamic operator on AttrSelector for arbitrary attributes
type CdpRequest = {
    httpRequest: CdpHttpRequest
    httpResponse: CdpHttpResponse
    iri: NamedReference
    text: string
} with

    member this.Id = this.httpRequest.CdpRequestId

    member this.originGraph =
        if not (ggg.dataset.HasGraph this.httpResponse.originIri.irefnode) then
            ggg.dataset.AddGraph(new ThreadSafeGraph(this.httpResponse.originIri.irefnode))
            |> ignore
        ggg.dataset[this.httpResponse.originIri.irefnode] :?> ThreadSafeGraph

    member this.asSubject = this.iri.asSubject
    member this.asPredicate = this.iri.asPredicate
    member this.asObject = this.iri.asObject

    member this.irn = {
        namespaceIdentifier = "chromedevtools"
        namespaceSpecificString = this.Id
    }
    member this.headers = Array.concat [| this.httpRequest.headers; this.httpResponse.headers |]
    member this.headerIrns = List.concat [| this.httpRequest.headerIrns; this.httpResponse.headerIrns |]

type CdpBrowser with
    static member Connect() =

        let options = ConnectOptions()

        options.BrowserURL <- "http://127.0.0.1:9222"
        options.DefaultViewport <- null

        let ibrowser = task { return! Puppeteer.ConnectAsync(options) } |> await

        ibrowser :?> CdpBrowser
    member this.NewPageBackgroundAsync() =
        let options = new CreatePageOptions()
        options.Background <- true
        this.NewPageAsync(options)

    member this.targets = this.Targets() |> Array.map (fun itarget -> itarget :?> CdpTarget)

    member this.otherDevToolsTargets =
        this.targets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Other, "CdpDevToolsTarget" -> Some(target :?> CdpDevToolsTarget)
            | _ -> None)

    member this.otherTargets =
        this.targets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Other, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.pageOtherTargets =
        this.targets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Page, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.pageTargets =
        this.targets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Page, "CdpPageTarget" -> Some(target :?> CdpPageTarget)
            | _ -> None)

    member this.workerTargets =
        this.targets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.ServiceWorker, "CdpWorkerTarget" -> Some(target :?> CdpWorkerTarget)
            | _ -> None)

    member this.browserOtherTargets =
        this.targets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Browser, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.workerOtherTargets =
        this.targets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Worker, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.iframeOtherTargets =
        this.targets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.IFrame, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.maybePageTarget(pageTargetFinder: CdpPageTarget -> bool) =
        this.pageTargets |> Array.tryFind pageTargetFinder

    member this.tabs =
        let pages = this.pageTargets |> Array.map (fun target -> target.AsPageAsync().await.asCdp)

        pages

type CdpPageTarget with
    member this.iriref = IriReference this.Url

type BrowserApi.Dom.NodeList with
    member this.asElements =
        Array.init (int this.Length) (fun index ->
            this[uint32 index].Handle
            |> BrowserApiReflection.fromHandle<BrowserApi.Dom.Element>)

type BrowserApi.Dom.Document with

    member this.QuerySelector(selector: Selector) = this.QuerySelector(selector.Css)

    member this.QuerySelectorAll(selector: Selector) =
        let nodes = this.QuerySelectorAll(selector.Css)
        nodes.asElements

type BrowserApi.Dom.Element with
    member this.TryAttribute(attribute: string) =
        if this.HasAttribute attribute then
            Some(this.GetAttribute attribute)
        else
            None
    member this.QuerySelector(selector: Selector) = this.QuerySelector selector.Css
    member this.children =
        if this.Children.Length > 0u then
            [|
                for index = 0u to this.Children.Length - 1u do
                    this.Children[index]
            |]
        else
            [||]
    member this.innerHtml = string this.InnerHtml
    member this.OuterHtmlNodes = HtmlNode.Parse(string this.OuterHtml)
type HtmlNode with
    member this.innerText = this.InnerText()
    member this.elements = this.Elements()
    member this.asString = this.ToString()
    member this.tag = this.Name()
type Attr with
    static member Class = AttrSelector "Class"
type CdpFrame with
    member this.GoToAsync(iriref: IriReference) = this.GoToAsync(iriref.remoteReference)
    member this.iriref = IriReference this.Url
    member this.Locator(selector: Selector) = this.Locator(selector.Css)

    member this.QuerySelectorAllAsync(selector: Selector) = this.QuerySelectorAllAsync selector.Css
    member this.QuerySelectorAllHandleAsync(selector: Selector) =
        this.QuerySelectorAllHandleAsync selector.Css
    member this.QuerySelectorAsync(selector: Selector) = this.QuerySelectorAsync selector.Css

type CdpPage with
    member this.GoToAsync(iriref: IriReference) = this.GoToAsync(iriref.remoteReference)
    member this.iriref = IriReference this.Url
    member this.frames = this.Frames |> Array.map (fun frame -> frame.asCdp)
    member this.Locator(selector: Selector) = this.Locator(selector.Css)
    member this.QuerySelectorAllAsync(selector: Selector) = this.QuerySelectorAllAsync selector.Css
    member this.QuerySelectorAllHandleAsync(selector: Selector) =
        this.QuerySelectorAllHandleAsync selector.Css
    member this.QuerySelectorAsync(selector: Selector) = this.QuerySelectorAsync selector.Css
    member this.Realm = CdpRealm this.MainFrame.asCdp
(*
    member this.ScrollToBottom() =
        task { return! this.EvaluateFunctionAsync("() => window.scrollTo(0, document.documentElement.scrollHeight)") }
        |> await

    member this.ScrollDown(pixels: int) =
        task { return! this.EvaluateFunctionAsync("(pixels) => window.scrollBy(0, pixels)", pixels) }
        |> await

    member this.ScrollUp(pixels: int) =
        task { return! this.EvaluateFunctionAsync("(pixels) => window.scrollBy(0, -pixels)", pixels) }
        |> await

    member this.SetTabName(name: string) =
        task { return! this.EvaluateFunctionAsync<string>("name => document.title = name", name) }
*)

type CdpElementHandle with
    member this.RealmElement(realm: CdpRealm) =
        realm.document.QuerySelector this.RemoteObject.Description
    member this.RealmElements(realm: CdpRealm) =
        (realm.document.QuerySelectorAll this.RemoteObject.Description).asElements

type IriReference with

    member this.downloadResponseHtml(tab: CdpPage) =

        let response = tab.GoToAsync(this.remoteReference).await.asCdp
        let responseText = response.TextAsync().await
        if responseText.Contains("Oops! Page not found. Please contact the Administrator.") then
            ()
        else
            let responsePath = AbsolutePath.Create(this.localReference.Split([| '?'; '='; '-'; '\\' |]) |> String.concat "\\")

            let responseFilePath = responsePath.As<AbsoluteFilePath>().WithSuffix ".html"
            Directory.CreateDirectory responseFilePath.AbsoluteDirectoryPath.WeakString
            |> ignore
            File.WriteAllText(responseFilePath.WeakString, responseText)

type Universal.Common.DataUriBuilder with
    member this.SetMediaType(mimeType: MimeType) =
        this.SetMediaType(Universal.Common.MediaType.FromExtension mimeType.dotExtension)
type MimeType with
    member this.asDataUri(data: Byte array) =
        Universal.Common.DataUriBuilder().SetMediaType(this).SetData(data).DataUri
