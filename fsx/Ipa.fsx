// Look into Hydra/ Nancy
// https://github.com/NancyFx/Nancy/wiki/Introduction#the-super-duper-happy-path
#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

open System
open System.IO
open System.Collections.Concurrent
open System.Numerics
open System.Reflection
open System.Text
open System.Text.RegularExpressions
open System.Threading.Tasks
open System.Collections
#load @".paket/load/main.group.fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#r "Iana.dll"
open Iana
#r "IanaScheme.dll"


open Humanizer
open CaseConverter
open AngleSharp.Html

open Nager.PublicSuffix
open Nager.PublicSuffix.RuleProviders
open Microsoft.AspNetCore.Http
open ModelingEvolution.Ipv4
open ktsu.Semantics.Paths
open TextCopy
open System.Net
open Dubzer.WhatwgUrl
open IriTools
open Meziantou.Framework
open ktsu.Semantics.Strings.Identifiers
open FolkerKinzel.MimeTypes
open PuppeteerSharp.Cdp
open WebDriverBiDi
open WebDriverBiDi.BrowsingContext
open WebDriverBiDi.Session
open PuppeteerSharp
open PuppeteerSharp.Cdp.Messaging
open VDS.RDF
open System.Xml.Linq
open RDFSharp.Model
open VDS.RDF.Query.Datasets
open VDS.RDF.Parsing
open System.IO.Compression
open System.Xml
open System.Globalization
open PhoneNumbers
open NLanguageTag
open FSharp.Data.Adaptive.Transaction
open FSharp.HashCollections
open VDS.RDF.Query
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Patterns
open FSharp.Collections.ParallelSeq
open VDS.RDF.Query.Inference
open VDS.RDF.Ontology
open BrowserApi.Common
open BrowserApi.Css.Authoring

let clipboard = new Clipboard()

let HttpRuleProvider = new SimpleHttpRuleProvider()
do HttpRuleProvider.BuildAsync().GetAwaiter().GetResult() |> ignore
let RegistrableDomainParser = new DomainParser(HttpRuleProvider)

let finishedRequests = new ResizeArray<CdpHttpRequest>()
let failedRequests = new ResizeArray<CdpHttpRequest>()

let backgroundOption = new CreatePageOptions()
backgroundOption.Background <- true



let utf8Encoding = UTF8Encoding(encoderShouldEmitUTF8Identifier = false, throwOnInvalidBytes = true)


let escapedSurrogatePair = Regex(@"\\u([dD][89aAbB][0-9a-fA-F]{2})\\u([dD][c-fC-F][0-9a-fA-F]{2})", RegexOptions.Compiled ||| RegexOptions.CultureInvariant)


let decompressGz (sourceFile: FileInfo) =
    let targetFile = sourceFile.FullName[.. sourceFile.FullName.Length - 4] |> FileInfo
    // Open the compressed file stream
    use sourceStream = new FileStream(sourceFile.FullName, FileMode.Open, FileAccess.Read)

    // Create the decompression stream
    use decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress)

    // Create the destination file stream
    use targetStream = new FileStream(targetFile.FullName, FileMode.Create, FileAccess.Write)

    // Copy the decompressed data to the target file
    decompressionStream.CopyTo(targetStream)
    targetFile

type Option<'Type> with
    static member ofNullOrWhiteSpace(value: 'Type) =
        if String.IsNullOrWhiteSpace(string value) then
            None
        else
            Some value
    static member tryNullOrWhiteSpace(maybeValue: 'Type option) =
        match maybeValue with
        | Some value when String.IsNullOrWhiteSpace(string value) -> None
        | None -> None
        | Some value -> Some value



type Task<'OutputType> with
    member this.await = this.GetAwaiter().GetResult()

type Task with
    member this.await = this.GetAwaiter().GetResult()

let await (operation: Task<'OutputType>) : 'OutputType = operation.GetAwaiter().GetResult()

let awaitUnit (task: Task) = task.GetAwaiter().GetResult()




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






module BrowserApiReflection =

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
    member _.Frame = frame


    member _.Wrap(handle: JSHandle) = wrap handle
    member this.document =

        let handle = (this :> IBrowserBackend).GetGlobal("document")

        BrowserApiReflection.fromHandle<BrowserApi.Dom.Document> handle


    member this.window =

        let handle = (this :> IBrowserBackend).GetGlobal("window")

        BrowserApiReflection.fromHandle<BrowserApi.Dom.Window> handle

    interface IBrowserBackend with

        member _.GetProperty<'T>(target, propertyName) =

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


        member _.SetProperty(target, propertyName, value) =

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


        member _.Invoke<'T>(target, methodName, arguments) =

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


        member _.InvokeVoid(target, methodName, arguments) =

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


        member _.InvokeAsync<'T>(target, methodName, arguments) =

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


        member _.InvokeVoidAsync(target, methodName, arguments) =

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


        member _.GetGlobal(name) =

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


        member _.Construct(jsClassName, arguments) =

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


        member _.DisposeHandle(browserHandle) =

            match handles.TryRemove browserHandle with
            | true, puppeteerHandle -> puppeteerHandle.DisposeAsync()

            | false, _ -> ValueTask.CompletedTask


        member _.AddEventListener(_, _, _) =
            raise (NotSupportedException("BrowserApi events have not yet been implemented by CdpBrowserApiBackend."))


        member _.RemoveEventListener(_, _, _) =
            raise (NotSupportedException("BrowserApi events have not yet been implemented by CdpBrowserApiBackend."))


        member _.DisposeAsync() =

            let dispose =
                task {
                    for KeyValue(_, handle) in handles do
                        do! handle.DisposeAsync().AsTask()

                    handles.Clear()
                }

            ValueTask(dispose :> Task)







type TargetMessage =
    | Add of CdpTarget
    | Remove of CdpTarget

type CdpTargetMonitor(browser: CdpBrowser) =

    let currentTargetCollection = ResizeArray<CdpTarget>()
    let historicalTargetCollection = ResizeArray<CdpTarget>()

    let mailbox =
        MailboxProcessor.Start(fun inbox ->

            let rec loop () =
                async {
                    let! message = inbox.Receive()

                    match message with
                    | Add target ->
                        if
                            currentTargetCollection
                            |> Seq.exists (fun existing -> existing.TargetId = target.TargetId)
                            |> not
                        then
                            currentTargetCollection.Add target
                        if
                            historicalTargetCollection
                            |> Seq.exists (fun existing -> existing.TargetId = target.TargetId)
                            |> not
                        then
                            historicalTargetCollection.Add target

                    | Remove target ->
                        currentTargetCollection.RemoveAll(fun existing -> existing.TargetId = target.TargetId)
                        |> ignore

                    return! loop ()
                }

            loop ())

    do
        browser.TargetCreated.Add(fun args ->
            match args.Target with
            | :? CdpTarget as target -> mailbox.Post(Add target)
            | _ -> ())

        browser.TargetDestroyed.Add(fun args ->
            match args.Target with
            | :? CdpTarget as target -> mailbox.Post(Remove target)
            | _ -> ())

        browser.Targets()
        |> Array.choose (function
            | :? CdpTarget as target -> Some target
            | _ -> None)
        |> Array.iter (Add >> mailbox.Post)

    member _.currentTargets = currentTargetCollection |> Seq.toArray
    member _.historicalTargets = historicalTargetCollection |> Seq.toArray

    member this.currentOtherDevToolsTargets =
        this.currentTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Other, "CdpDevToolsTarget" -> Some(target :?> CdpDevToolsTarget)
            | _ -> None)

    member this.currentOtherTargets =
        this.currentTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Other, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.currentPageOtherTargets =
        this.currentTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Page, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.currentPageTargets =
        this.currentTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Page, "CdpPageTarget" -> Some(target :?> CdpPageTarget)
            | _ -> None)

    member this.currentWorkerTargets =
        this.currentTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.ServiceWorker, "CdpWorkerTarget" -> Some(target :?> CdpWorkerTarget)
            | _ -> None)

    member this.currentBrowserOtherTargets =
        this.currentTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Browser, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.currentWorkerOtherTargets =
        this.currentTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Worker, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.currentIframeOtherTargets =
        this.currentTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.IFrame, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.historicalOtherDevToolsTargets =
        this.historicalTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Other, "CdpDevToolsTarget" -> Some(target :?> CdpDevToolsTarget)
            | _ -> None)

    member this.historicalOtherTargets =
        this.historicalTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Other, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.historicalPageOtherTargets =
        this.historicalTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Page, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.historicalPageTargets =
        this.historicalTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Page, "CdpPageTarget" -> Some(target :?> CdpPageTarget)
            | _ -> None)

    member this.historicalWorkerTargets =
        this.historicalTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.ServiceWorker, "CdpWorkerTarget" -> Some(target :?> CdpWorkerTarget)
            | _ -> None)

    member this.historicalBrowserOtherTargets =
        this.historicalTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Browser, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.historicalWorkerOtherTargets =
        this.historicalTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.Worker, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)

    member this.historicalIframeOtherTargets =
        this.historicalTargets
        |> Array.choose (fun target ->
            match target.Type, target.GetType().Name with
            | TargetType.IFrame, "CdpOtherTarget" -> Some(target :?> CdpOtherTarget)
            | _ -> None)
























































































type TextualSyntax = {

    syntaxName: string
    fileExtension: string

} with

    member this.mimeType = MimeString.FromFileName this.fileExtension
    member this.filePath parentDirectory stem =
        Directory.CreateDirectory(parentDirectory) |> ignore

        Path.Combine(parentDirectory, stem + this.fileExtension)


type ResourceIdentifier =
    | GloballyUniqueIdentifier of Guid
    | UniversallyUniqueIdentifier of Uuid
    | UniversallyUniqueLexicographicallySortableIdentifier of Ulid
    | InternationalStandardBookNumber of Isbn

type ResolvedResource = {
    absoluteRoot: AbsoluteRoot
    pathSegments: string array
    fragmentString: FragmentString option
    queryString: QueryString option
}


and AbsoluteRoot =
    | DriveRoot of DriveInfo
    | SiteRoot of WhatwgSite

and WhatwgSite = {
    scheme: IanaScheme
    host: HostName
    port: int option
}
and HostName =
    | Ipv4Host of Ipv4Address
    | DomainHost of RegistrableDomain
and RegistrableDomain = {
    domainName: Nager.PublicSuffix.DomainInfo
}




















type GraphemeCluster = { glyph: string; runes: Rune array }


module String =
    open System.Globalization
    module subString =
        let fromLast (delimeter: string) (superString: string) =
            match superString.LastIndexOf(delimeter) with
            | -1 -> None
            | index -> Some(superString.Substring(index + 1))

        let fromCircumfix (prefix: string) (superstring: string) (suffix: string) =
            match superstring.IndexOf(prefix) + 1, superstring.LastIndexOf(suffix) - 1 with
            | -1, -1 -> None
            | fromPrefix, toSuffix -> Some(superstring[fromPrefix..toSuffix])

        let firstBefore (delimiter: string) (superstring: string) =
            match superstring.IndexOf delimiter with
            | -1 -> None
            | delimiterIndex ->
                let to_delimiter = delimiterIndex - 1
                let substring = superstring.[..to_delimiter]
                Some(substring)

    let untilCharacter (delimiterCharacter: char) (superstring: string) =
        superstring.ToCharArray()
        |> Array.takeWhile (fun character -> character <> delimiterCharacter)
        |> System.String

    let trimmed (text: string) = text.TrimStart().TrimEnd()

    let rev (text: string) =
        text.ToCharArray() |> Array.rev |> String

    /// just a crumb of humor to lighten the day
    let gnirts (text: string) = rev text


    let prepostfix (prefix: string) (text: string) (postfix: string) = prefix + text + postfix
    let circumfix (affix: string) (text: string) = prepostfix affix text affix
    let prefix (affix: string) (text: string) = prepostfix affix text String.Empty
    let postfix (affix: string) (text: string) = prepostfix String.Empty text affix
    let clip (text: string) = clipboard.SetText text
    let runes (text: string) = text.EnumerateRunes() |> Seq.toArray
    let textElements (text: string) =
        let enumerator = StringInfo.GetTextElementEnumerator(text)

        seq {

            while enumerator.MoveNext() do
                let element = enumerator.GetTextElement()
                yield element
        }
        |> Seq.toArray
    let graphemeClusters (text: string) =
        textElements text
        |> Array.map (fun textElement -> {
            glyph = textElement
            runes = runes textElement
        })
    let tryGraphemeCluster (text: string) =
        match graphemeClusters text with
        | [| graphemeCluster |] -> Some graphemeCluster
        | _ -> None

    let normalizeEscapedSurrogatePairs (text: string) =
        if text.IndexOf(@"\uD", StringComparison.OrdinalIgnoreCase) < 0 then
            text
        else
            escapedSurrogatePair.Replace(
                text,
                MatchEvaluator(fun matched ->
                    let high = Convert.ToInt32(matched.Groups.[1].Value, 16) |> char

                    let low = Convert.ToInt32(matched.Groups.[2].Value, 16) |> char

                    Char.ConvertToUtf32(high, low) |> sprintf "\\U%08X")
            )

type String with
    member this.trimmed = String.trimmed this
    member this.rev = String.rev this
    /// just a crumb of humor to lighten the day
    member this.gnirts = this.rev
    member this.prefix(affix: string) = String.prefix affix this
    member this.postfix(affix: string) = String.postfix affix this
    member this.circumfix(affix: string) = String.prepostfix affix this affix
    member this.prepostfix(prefix: string, postfix: string) = String.prepostfix prefix this postfix
    member this.clip = String.clip this
    member this.runes = String.runes this
    member this.graphemeClusters = String.graphemeClusters this
    member this.tryGraphemeCluster = String.tryGraphemeCluster this
    member this.normalizeEscapedSurrogatePairs = String.normalizeEscapedSurrogatePairs this


module Rune =
    let codePoint (rune: Rune) = rune.Value
    let hexName (rune: Rune) = sprintf "%04X" rune.Value
    let UHexName (rune: Rune) = hexName rune |> String.prefix "U+"
    let UnicodeCategory (rune: Rune) =
        CharUnicodeInfo.GetUnicodeCategory rune.Value

type Rune with
    member this.UnicodeCategory = Rune.UnicodeCategory this
    member this.codePoint = Rune.codePoint this
    member this.hexName = Rune.hexName this
    member this.UHexName = Rune.UHexName this


type Guid with
    member this.asString = this.ToString("N")
    member this.asHyphenatedString = this.ToString("D")
    member this.asHyphenatedBracedString = this.ToString("B")
    member this.asHyphenatedParenthesizedString = this.ToString("P")
    member this.asHexString = this.ToString("X")

type PhoneNumber with
    static member Parse(numberString: string) =
        PhoneNumberUtil.GetInstance().Parse(numberString, "US")

module GraphemeCluster =
    let tryHtmlName (graphemeCluster: GraphemeCluster) =
        match HtmlEntityProvider.ReverseResolver.GetName(graphemeCluster.glyph) with
        | null -> None
        | name -> Some(name.TrimEnd ';')

    let tryHtmlEntity (graphemeCluster: GraphemeCluster) =
        tryHtmlName graphemeCluster
        |> Option.map (fun name -> name.prepostfix ("&", ";"))
    let hexName (graphemeCluster: GraphemeCluster) =
        graphemeCluster.runes
        |> Array.map (fun rune -> rune.hexName)
        |> String.concat " "
    let UHexName (graphemeCluster: GraphemeCluster) =
        graphemeCluster.runes
        |> Array.map (fun rune -> rune.UHexName)
        |> String.concat " "
type GraphemeCluster with
    member this.tryHtmlName = GraphemeCluster.tryHtmlName this
    member this.tryHtmlEntity = GraphemeCluster.tryHtmlEntity this
    member this.hexName = GraphemeCluster.hexName this
    member this.UHexName = GraphemeCluster.UHexName this

module Char =
    let graphemeCluster (character: char) =
        string character |> String.tryGraphemeCluster |> Option.get
    let tryHtmlName (character: char) =
        graphemeCluster character |> GraphemeCluster.tryHtmlName
    let tryHtmlEntity (character: char) =
        graphemeCluster character |> GraphemeCluster.tryHtmlEntity
    let hexName (character: char) =
        graphemeCluster character |> GraphemeCluster.hexName
    let UHexName (character: char) =
        graphemeCluster character |> GraphemeCluster.UHexName
    let decimalEntity (character: char) = sprintf "&#%i;" (int character)
    let hexadecimalEntity (character: char) = sprintf "&#%i;" (int character)
type Char with
    member this.graphemeCluster = Char.graphemeCluster this
    member this.tryHtmlName = Char.tryHtmlName this

    member this.tryHtmlEntity = Char.tryHtmlEntity this
    member this.hexName = Char.hexName this
    member this.UHexName = Char.UHexName this












type DriveInfo with
    static member C = DriveInfo.GetDrives() |> Array.find (fun drive -> drive.Name[0] = 'C')
    static member D = DriveInfo.GetDrives() |> Array.find (fun drive -> drive.Name[0] = 'D')
    static member byChar =
        DriveInfo.GetDrives()
        |> Array.map (fun drive -> drive.Name[0], drive)
        |> Map.ofArray


let (../) (drive: DriveInfo) (path: string) =
    let relativePath = RelativePath.Create path
    {
        absoluteRoot = DriveRoot drive
        pathSegments = relativePath.WeakString.Split("\\")
        fragmentString = None
        queryString = None

    }






let personalDrive =
    match DriveInfo.GetDrives() |> Array.tryFind (fun drive -> drive.Name[0] = 'D') with
    | Some dDrive -> dDrive
    | None -> DriveInfo.C
let personalSiteReference = "https://eristocrates.dev"




type IanaScheme with
    static member byName =
        IanaScheme.all
        |> Array.map (fun scheme -> scheme.lexicalForm, scheme)
        |> Map.ofArray





type Ipv4Address with
    member this.remoteReference = this.ToString()
    member this.asIpAddress = IPAddress.Parse this.remoteReference
    member this.outerLeft = int this.A
    member this.innerLeft = int this.B
    member this.innerRight = int this.C
    member this.outerRight = int this.D
    member this.localReference = this.remoteReference.Replace(".", "/")





type RelativeDirectoryPath with
    static member EnsureCreate(rawPath: string) =
        let invalidChars = Path.GetInvalidFileNameChars() |> Set.ofArray
        rawPath.Split([| '/'; '\\' |], StringSplitOptions.TrimEntries)
        |> Array.choose (fun segment -> Option.ofNullOrWhiteSpace segment)
        |> Array.map (fun segment ->
            segment
            |> String.collect (fun character ->
                if invalidChars.Contains character then
                    match character.tryHtmlEntity with
                    | Some htmlEntity -> htmlEntity
                    | None -> String.prepostfix "&#x" character.hexName ";"
                else
                    string character))



type RegistrableDomain with
    static member Parse(originalString: string) = {
        domainName = RegistrableDomainParser.Parse originalString
    }
    member this.topLevelDomain = this.domainName.TopLevelDomainRule
    member this.remoteReference = this.domainName.FullyQualifiedDomainName
    member this.secondLevelDomain = this.domainName.Domain
    member this.subdomain = Option.ofNullOrWhiteSpace this.domainName.Subdomain
    member this.dnsDomain = this.domainName.RegistrableDomain
    member this.localReference =
        match this.subdomain with
        | Some subdomain -> Path.Combine(this.topLevelDomain.Name, this.secondLevelDomain, subdomain)
        | None -> Path.Combine(this.topLevelDomain.Name, this.secondLevelDomain)

    member this.asRelativeDirectoryPath = RelativeDirectoryPath.EnsureCreate this.localReference
    member this.asRelativeFilePath = RelativeFilePath.Create this.localReference
    member this.ipAddresses =
        try
            Dns.GetHostAddresses this.dnsDomain
        with _ -> [||]
    member this.ipv4Addresses = this.ipAddresses |> Array.map Ipv4Address.FromIPAddress


let (..//) (scheme: IanaScheme) (domainString: string) =
    {
        scheme = scheme
        host = RegistrableDomain.Parse domainString |> DomainHost
        port = None
    }
    |> SiteRoot

type ResolvedResource with
    member this.extension =
        this.pathSegments
        |> Array.last
        |> Path.GetExtension
        |> Option.ofNullOrWhiteSpace
    member this.fileExtension = this.extension |> Option.map FileExtension.Create
    static member fromUri(uri: Uri) = {
        absoluteRoot = IanaScheme.byName[uri.Scheme] ..// uri.DnsSafeHost
        pathSegments = uri.Segments[1..] |> Array.map (fun segment -> segment.TrimEnd('/'))
        fragmentString =
            Option.ofNullOrWhiteSpace uri.Fragment
            |> Option.map (fun fragmentString -> FragmentString fragmentString)
        queryString =
            Option.ofNullOrWhiteSpace uri.Query
            |> Option.map (fun queryString -> QueryString queryString)
    }
    member this.localRelativePath = this.pathSegments |> String.concat "\\" |> RelativePath.Create
    member this.remotePathString = "/" + (this.pathSegments |> String.concat "/") |> PathString

type HostName with
    member this.remoteReference =
        match this with
        | Ipv4Host ipv4 -> ipv4.remoteReference
        | DomainHost domain -> domain.remoteReference
    member this.localReference =
        match this with
        | Ipv4Host ipv4 -> ipv4.localReference
        | DomainHost domain -> domain.localReference
type WhatwgSite with
    static member op_Addition((site: WhatwgSite), (port: int)) = { site with port = Some port }
    member this.localReference = Path.Combine(personalDrive.Name, this.scheme.lexicalForm, this.host.localReference)
    member this.remoteReference =
        match this.port with
        | Some port -> $"{this.scheme.lexicalForm}://{this.host.remoteReference}:{port}"
        | None -> $"{this.scheme.lexicalForm}://{this.host.remoteReference}"
    member this.asLocalUri = Uri this.localReference
    member this.asRemoteUri = Uri this.remoteReference
    member this.asLocalUrl = DomUrl this.localReference
    member this.asRemoteUrl = DomUrl this.remoteReference
    member this.asLocalIriReference = IriReference this.localReference
    member this.asRemoteIriReference = IriReference this.remoteReference

    member this.asRelativeDirectoryPath = RelativeDirectoryPath.EnsureCreate this.localReference
    member this.asRelativeFilePath = RelativeFilePath.Create this.localReference
type DriveInfo with
    member this.localReference = string this.Name[0]
    member this.remoteReference = $"{personalSiteReference}/{this.Name}"
    member this.asLocalUri = Uri this.Name
    member this.asLocalUrl = DomUrl this.Name
    member this.asLocalIriReference = IriReference this.Name
    member this.asRemoteUri = Uri this.remoteReference
    member this.asRemoteUrl = DomUrl this.remoteReference
    member this.asRemoteIriReference = IriReference this.remoteReference
    member this.asRelativeDirectoryPath = RelativeDirectoryPath.EnsureCreate this.localReference
    member this.asRelativeFilePath = RelativeFilePath.Create this.localReference



type FileInfo with
    member this.stem = Path.GetFileNameWithoutExtension this.Name
    member this.stemPath = Path.Combine(this.DirectoryName, this.stem)

type DirectoryInfo with
    member this.CopyTo(targetDirectory: DirectoryInfo) =
        // Create target directory if it doesn't exist
        if not (targetDirectory.Exists) then
            Directory.CreateDirectory targetDirectory.FullName |> ignore


        // 1. Copy all files in the current directory
        for file in this.GetFiles() do
            let targetFilePath = Path.Combine(targetDirectory.FullName, file.Name)
            file.CopyTo(targetFilePath, true) |> ignore

        // 2. Recursively copy all subfolders
        for subdirectory in this.GetDirectories() do

            let targetSubdirectory = targetDirectory.CreateSubdirectory subdirectory.Name
            subdirectory.CopyTo targetSubdirectory

type AbsoluteRoot with
    static member op_Addition((root: AbsoluteRoot), (port: int)) =
        match root with
        | DriveRoot driveInfo -> root
        | SiteRoot whatwgSite -> { whatwgSite with port = Some port } |> SiteRoot

    static member (./)((root: AbsoluteRoot), (relativeString: string)) = {
        absoluteRoot = root
        pathSegments =
            relativeString.Split([| '/'; '\\' |], StringSplitOptions.TrimEntries)
            |> Array.filter (fun segment -> not (String.IsNullOrWhiteSpace segment))
        fragmentString = None
        queryString = None
    }

    member this.localReference =
        match this with
        | DriveRoot driveInfo -> driveInfo.Name
        | SiteRoot whatwgSite -> whatwgSite.localReference
    member this.remoteReference =
        match this with
        | DriveRoot driveInfo -> driveInfo.remoteReference
        | SiteRoot whatwgSite -> whatwgSite.remoteReference
    member this.asLocalUri = Uri this.localReference
    member this.asLocalUrl = DomUrl this.localReference
    member this.asLocalIriReference = IriReference this.localReference
    member this.asRemoteUri = Uri this.remoteReference
    member this.asRemoteUrl = DomUrl this.remoteReference
    member this.asRemoteIriReference = IriReference this.remoteReference

    member this.asRelativeDirectoryPath = RelativeDirectoryPath.EnsureCreate this.localReference
    member this.asRelativeFilePath = RelativeFilePath.Create this.localReference
    member this.asAbsoluteDirectoryPath = AbsoluteDirectoryPath.Create this.localReference
    member this.asAbsoluteFilePath = AbsoluteFilePath.Create this.localReference
    member this.host =
        match this with
        | DriveRoot driveInfo -> String.Empty
        | SiteRoot whatwgSite -> whatwgSite.host.remoteReference

type RelativePath with
    member this.asRelativeUri = Uri(this.WeakString, UriKind.Relative)
    member this.asResolvedUri(baseUri: Uri) = Uri(baseUri, this.WeakString)
    member this.asResolvedUrl(baseUrl: DomUrl) = DomUrl(this.WeakString, baseUrl)
    member this.asRelativeIriReferenceReference = IriReference this.WeakString

    member this.asResolvedIriReference(baseIriReference: IriReference) =
        IriReference $"{baseIriReference.uri.OriginalString}/{this.WeakString}"

    member this.asRelativeDirectoryPath = RelativeDirectoryPath.EnsureCreate this.WeakString
    member this.asRelativeFilePath = RelativeFilePath.Create this.WeakString
    member this.asPathString = PathString $"/{this.WeakString}"
    member this.asDirectoryName = DirectoryName.Create this.WeakString
    member this.asFileName = FileName.Create this.WeakString


type ResolvedResource with


    member this.localReference = Path.Combine(this.absoluteRoot.localReference, this.pathSegments |> String.concat "\\")
    member this.remoteReference =
        let absoluteUriString =
            this.absoluteRoot.remoteReference
            + "/"
            + (this.pathSegments |> String.concat "/")
        match this.fragmentString, this.queryString with
        | Some fragment, None -> absoluteUriString + fragment.Value
        | None, Some query -> absoluteUriString + query.Value
        | Some fragment, Some query -> absoluteUriString + fragment.Value + query.Value
        | _ -> absoluteUriString


    member this.asLocalUri = Uri this.localReference
    member this.asRemoteUri = Uri this.remoteReference
    member this.asLocalUrl = DomUrl this.localReference
    member this.asRemoteUrl = DomUrl this.remoteReference
    member this.asLocalIriReference = IriReference this.localReference
    member this.asRemoteIriReference = IriReference this.remoteReference

    member this.asRelativeDirectoryPath = RelativeDirectoryPath.EnsureCreate this.localReference
    member this.asRelativeFilePath = RelativeFilePath.Create this.localReference
    member this.asAbsoluteDirectoryPath = AbsoluteDirectoryPath.Create this.localReference
    member this.asAbsoluteFilePath = AbsoluteFilePath.Create this.localReference
    member this.asDirectoryPath = AbsoluteDirectoryPath.Create this.localReference
    member this.asFilePath = AbsoluteFilePath.Create this.localReference
    member this.asFileInfo = FileInfo this.localReference
    member this.asDirectoryInfo = DirectoryInfo this.localReference
    member this.asFullPath = FullPath.FromPath this.localReference
    member this.host = this.absoluteRoot
    member this.pathStem =
        if this.pathSegments.Length > 0 then
            this.pathSegments |> Array.last
        else
            String.Empty

type FullPath with
    static member CurrentFile() =
        Path.Combine(FullPath.CurrentDirectory().RawValue, __SOURCE_FILE__)
        |> FileInfo
        |> FullPath.FromFileSystemInfo



type MimeType with
    static member FromFileName(fileName: FileName) =
        MimeType.FromFileName fileName.WeakString

type IanaMediaType with
    member this.asRelativeFilePath = this.file + this.extension |> RelativeFilePath.Create
fsi.AddPrinter<RelativeDirectoryPath>(fun path -> path.WeakString)
fsi.AddPrinter<RelativeFilePath>(fun path -> path.WeakString)
fsi.AddPrinter<RelativePath>(fun path -> path.WeakString)
fsi.AddPrinter<AbsoluteDirectoryPath>(fun path -> path.WeakString)
fsi.AddPrinter<AbsoluteFilePath>(fun path -> path.WeakString)
fsi.AddPrinter<AbsolutePath>(fun path -> path.WeakString)



















module https =

    module dev =
        let eristocrates = IanaScheme.https ..// "eristocrates.dev"
    module gov =
        module leoncountyfl =
            module bannerprodssb =
                let site = IanaScheme.https ..// "bannerprodssb.leoncountyfl.gov" + 8449
                module EmployeeSelfService =
                    let resource = site ./ "EmployeeSelfService"






type QueryString with
    member this.parameterCollection = QueryStringUtilities.ParseQuery this.Value
// member this.AppendFileName (fileName:FileName) = let mimeType = MimeType.FromFileName fileName
















type QueryParameter =
    | ParameterKeyValue of string * string
    | ParameterKeyValues of string * string array

    member this.parameterKey =
        match this with
        | ParameterKeyValue(parameterKey, parameterValue) -> parameterKey
        | ParameterKeyValues(parameterKey, parameterValues) -> parameterKey

    member this.parameterValue =
        match this with
        | ParameterKeyValue(parameterKey, parameterValue) -> parameterValue
        | ParameterKeyValues(parameterKey, parameterValues) -> parameterValues[0]

    member this.parameterValues =
        match this with
        | ParameterKeyValue(parameterKey, parameterValue) -> [| parameterValue |]
        | ParameterKeyValues(parameterKey, parameterValues) -> parameterValues


type QueryStringParameterCollection with
    member this.parameters =
        this
        |> Seq.map (fun keyValue ->
            match keyValue.Key, keyValue.Value |> Seq.toArray with
            | parameterKey, [| parameterValue |] -> ParameterKeyValue(parameterKey, parameterValue)
            | parameterKey, parameterValues -> ParameterKeyValues(parameterKey, parameterValues))
        |> Seq.toArray

    member this.asRelativeDirectoryPath =
        this.parameters
        |> Array.map (fun parameter ->
            Array.concat [| [| parameter.parameterKey |]; parameter.parameterValues |]
            |> String.concat "\\")
        |> String.concat "\\"
        |> RelativeDirectoryPath.EnsureCreate






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
    member this.ResourceName = DomUrl this.Url



type CdpHttpRequest with
    member this.remoteResource = Uri this.Url |> ResolvedResource.fromUri

    member this.headers = this.Headers |> Seq.map (fun kvp -> kvp.Key, kvp.Value) |> Seq.toArray

    member this.header(targetHeader: string) =
        this.headers
        |> Array.tryPick (fun (headerKey, headerValue) -> if headerKey = targetHeader then Some headerValue else None)

    member this.PostText = if this.HasPostData then Some this.PostData else None



type CdpHttpResponse with
    member this.resource = Uri this.Url |> ResolvedResource.fromUri

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


    member this.WriteAllText() =
        match this.Text() |> Option.tryNullOrWhiteSpace with
        | Some text ->
            Directory.CreateDirectory this.resource.asFileInfo.DirectoryName |> ignore
            match this.resource.absoluteRoot with
            | SiteRoot root ->
                printfn
                    "%s:\t\t %s ----> %s"
                    root.host.remoteReference
                    this.resource.remoteReference[root.host.remoteReference.Length - 1 ..]
                    this.resource.localReference[root.host.remoteReference.Length - 1 ..]
            | DriveRoot root -> printfn "%s:\t\t %s ----> %s" root.Name this.resource.remotePathString.Value this.resource.localRelativePath.WeakString
            File.WriteAllText(this.resource.asFileInfo.FullName, text)
        | None -> ()
    member this.WriteAllText(extensionOverride: FileExtension) =
        match this.Text() |> Option.tryNullOrWhiteSpace with
        | Some text ->
            let localFilePath = this.resource.asAbsoluteFilePath.ChangeExtension extensionOverride
            Directory.CreateDirectory localFilePath.DirectoryPath.WeakString |> ignore
            match this.resource.absoluteRoot with
            | SiteRoot root ->
                printfn
                    "%s:\t\t %s ----> %s"
                    root.host.remoteReference
                    this.resource.remoteReference[root.host.remoteReference.Length - 1 ..]
                    this.resource.localReference[root.host.remoteReference.Length - 1 ..]
            | DriveRoot root -> printfn "%s:\t\t %s ----> %s" root.Name this.resource.remotePathString.Value this.resource.localRelativePath.WeakString
            File.WriteAllText(localFilePath.WeakString, text)
        | None -> ()
    member this.WriteAllText(pathOverride: AbsoluteFilePath) =
        match this.Text() |> Option.tryNullOrWhiteSpace with
        | Some text ->
            let localFilePath = pathOverride
            Directory.CreateDirectory pathOverride.DirectoryPath.WeakString |> ignore
            match this.resource.absoluteRoot with
            | SiteRoot root ->
                printfn
                    "%s:\t\t %s ----> %s"
                    root.host.remoteReference
                    this.resource.remoteReference[root.host.remoteReference.Length - 1 ..]
                    this.resource.localReference[root.host.remoteReference.Length - 1 ..]
            | DriveRoot root -> printfn "%s:\t\t %s ----> %s" root.Name this.resource.remotePathString.Value this.resource.localRelativePath.WeakString
            File.WriteAllText(localFilePath.WeakString, text)

        | None -> ()


type CdpBrowser with
    static member Connect() =

        let options = ConnectOptions()

        options.BrowserURL <- "http://127.0.0.1:9222"
        options.DefaultViewport <- null

        let ibrowser = task { return! Puppeteer.ConnectAsync(options) } |> await

        ibrowser :?> CdpBrowser
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




type CdpPageTarget with
    member this.DomUrl = DomUrl this.Url

type CdpFrame with
    member this.remoteResource = Uri this.Url |> ResolvedResource.fromUri
    member this.Locator(selector: Selector) = this.Locator(selector.Css)

    member this.QuerySelectorAllAsync(selector: Selector) = this.QuerySelectorAllAsync selector.Css
    member this.QuerySelectorAllHandleAsync(selector: Selector) =
        this.QuerySelectorAllHandleAsync selector.Css
    member this.QuerySelectorAsync(selector: Selector) = this.QuerySelectorAsync selector.Css
type CdpPage with
    member this.DomUrl = DomUrl this.Url
    member this.frames = this.Frames |> Array.map (fun frame -> frame.asCdp)
    member this.Locator(selector: Selector) = this.Locator(selector.Css)
    member this.QuerySelectorAllAsync(selector: Selector) = this.QuerySelectorAllAsync selector.Css
    member this.QuerySelectorAllHandleAsync(selector: Selector) =
        this.QuerySelectorAllHandleAsync selector.Css
    member this.QuerySelectorAsync(selector: Selector) = this.QuerySelectorAsync selector.Css
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


[<RequireQualifiedAccess>]
type HTTPMethod =
    | DELETE
    | GET
    | PATCH
    | POST
    | PUT
    | UnknownMethod of string

    static member fromString(rawMethod: string) =
        match rawMethod with
        | "DELETE" -> DELETE
        | "GET" -> GET
        | "PATCH" -> PATCH
        | "POST" -> POST
        | "PUT" -> PUT
        | unknown -> UnknownMethod rawMethod
    member this.asString = this.ToString()


type ResolvedResource with

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


/// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/MIME_types/Common_types
let commonContentTypes =
    set [
        "audio/aac"
        "application/x-abiword"
        "image/apng"
        "application/x-freearc"
        "image/avif"
        "video/x-msvideo"
        "application/vnd.amazon.ebook"
        "application/octet-stream"
        "image/bmp"
        "application/x-bzip"
        "application/x-bzip2"
        "application/x-cdf"
        "application/x-csh"
        "text/css"
        "text/csv"
        "application/msword"
        "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
        "application/vnd.ms-fontobject"
        "application/epub+zip"
        "application/gzip"
        "application/x-gzip"
        "image/gif"
        "text/html"
        "image/vnd.microsoft.icon"
        "text/calendar"
        "application/java-archive"
        "image/jpeg"
        "text/javascript"
        "application/json"
        "application/ld+json"
        "text/markdown"
        "audio/midi"
        "audio/x-midi"
        "text/javascript"
        "audio/mp4"
        "audio/mpeg"
        "video/mp4"
        "video/mpeg"
        "application/vnd.apple.installer+xml"
        "application/vnd.oasis.opendocument.presentation"
        "application/vnd.oasis.opendocument.spreadsheet"
        "application/vnd.oasis.opendocument.text"
        "audio/ogg"
        "video/ogg"
        "application/ogg"
        "audio/ogg"
        "font/otf"
        "image/png"
        "application/pdf"
        "application/x-httpd-php"
        "application/vnd.ms-powerpoint"
        "application/vnd.openxmlformats-officedocument.presentationml.presentation"
        "application/vnd.rar"
        "application/rtf"
        "application/x-sh"
        "image/svg+xml"
        "application/x-tar"
        "image/tiff"
        "video/mp2t"
        "font/ttf"
        "text/plain"
        "application/vnd.visio"
        "audio/wav"
        "audio/webm"
        "video/webm"
        "application/manifest+json"
        "image/webp"
        "font/woff"
        "font/woff2"
        "application/xhtml+xml"
        "application/vnd.ms-excel"
        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
        "application/xml"
        "application/atom+xml"
        "text/xml"
        "application/vnd.mozilla.xul+xml"
        "application/zip"
        "application/x-zip-compressed"
        "video/3gpp"
        "audio/3gpp"
        "video/3gpp2"
        "audio/3gpp2"
        "application/x-7z-compressed"
    ]
let commonMediaTypes =
    IanaMediaTypes
    |> Array.filter (fun ianaMediaType -> commonContentTypes.Contains(ianaMediaType.file))

let commonExtensions =
    commonMediaTypes
    |> Array.map (fun ianaMediaType -> ianaMediaType.extension)
    |> Array.distinct
    |> Set.ofArray
let rdfExtensions =
    set [

        // Extension   | Format / use                   | Status                                |
        // ----------- | ------------------------------ | ------------------------------------- |
        ".ttl" // | Turtle                         | W3C RDF serialization                 |
        ".nt" // | N-Triples                      | W3C RDF serialization                 |
        ".trig" // | TriG                           | W3C RDF dataset serialization         |
        ".nq" // | N-Quads                        | W3C RDF dataset serialization         |
        ".rdf" // | RDF/XML                        | W3C RDF serialization                 |
        ".jsonld" // | JSON-LD                        | W3C RDF/Linked Data serialization     |
        ".n3" // | Notation3                      | W3C-community RDF superset            |
        ".rj" // | RDF/JSON                       | historical W3C RDF serialization      |
        ".trix" // | TriX                           | RDF dataset XML format                |
        ".hdt" // | HDT                            | compact binary RDF format             |
        ".jelly" // | Jelly-RDF                      | binary/streaming RDF serialization    |
        ".brf" // | Binary RDF                     | RDF4J/Sesame binary RDF               |
        ".rt" // | RDF Thrift                     | binary RDF                            |
        ".trdf" // | RDF Thrift                     | binary RDF                            |
        ".rpb" // | RDF Protobuf                   | binary RDF                            |
        ".pbrdf" // | RDF Protobuf                   | binary RDF                            |
        ".ndjsonld" // | newline-delimited JSON-LD      | RDF4J/ecosystem format                |
        ".rdfp" // | RDF Patch                      | RDF dataset changes                   |
        ".trp" // | binary RDF Patch               | Jena convention                       |
        ".owl" // | OWL ontology, commonly RDF/XML | widespread convention                 |
        ".rdfs" // | RDF Schema document            | convention, not a distinct RDF syntax |
        ".rq" // | SPARQL query                   | W3C                                   |
        ".ru" // | SPARQL Update request          | W3C                                   |
        ".srx" // | SPARQL Results XML             | W3C                                   |
        ".srj" // | SPARQL Results JSON            | W3C                                   |
        ".srt" // | SPARQL Results Thrift          | RDF Thrift ecosystem                  |
        ".csv" // | SPARQL SELECT results in CSV   | W3C use of generic CSV                |
        ".tsv" // | SPARQL SELECT results in TSV   | W3C use of generic TSV                |
        ".ttls" // | Turtle-star                    | historical/pre-RDF-1.2 convention     |
        ".trigs" // | TriG-star                      | historical/pre-RDF-1.2 convention     |

    ]

let rdfMediaTypes =
    [|
        // Core RDF serializations
        "application/rdf+xml"
        "text/turtle"
        "application/n-triples"
        "application/n-quads"
        "application/trig"
        "application/ld+json"

        // Other RDF serializations
        "text/n3"
        "text/rdf+n3"
        "application/n3"
        "application/rdf+json"
        "application/trix"
        "application/trix+xml"
        "application/vnd.hdt"
        "application/x-binary-rdf"
        "application/x-ld+ndjson"
        "application/rdf+thrift"
        "application/rdf+protobuf"

        // RDF Patch
        "application/rdf-patch"
        "application/rdf-patch+thrift"

        // SPARQL
        "application/sparql-query"
        "application/sparql-update"

        // SPARQL result formats
        "application/sparql-results+xml"
        "application/sparql-results+json"
        "application/sparql-results+thrift"
        "application/sparql-results+protobuf"
    |]
    |> Array.collect (fun contentType ->
        IanaMediaTypes
        |> Array.filter (fun ianaMediaType -> ianaMediaType.file = contentType))



let targetExtensions = set [ ".jsonhtml" ] + commonExtensions + rdfExtensions
let targetMediaTypes = Array.concat [| commonMediaTypes; rdfMediaTypes |]

type IanaMediaType with
    member this.isCommonMediaType = commonMediaTypes |> Array.exists (fun commonMediaType -> this = commonMediaType)
    member this.isTargetMediaType = targetMediaTypes |> Array.exists (fun targetMediaType -> this = targetMediaType)

let networkMailbox =
    MailboxProcessor<CdpHttpRequest>.Start(fun inbox ->
        let rec loop () =
            async {
                let! request = inbox.Receive()
                match request.Response.Status with
                | HttpStatusCode.OK ->
                    finishedRequests.Add request
                    let maybeIanaMediaType =
                        MimeType.TryParse(request.Response.Headers["content-type"])
                        |> fun (wasParsed, mimeType) ->
                            match wasParsed with
                            | true ->
                                IanaMediaTypes
                                |> Array.find (fun ianaMediaType -> ianaMediaType.mime = mimeType)
                                |> Some
                            | false -> None
                    match request.Response.resource.host, request.Response.resource.pathStem, request.Response.resource.extension, maybeIanaMediaType with
                    | host, pathstem, None, Some mediaType when mediaType.isTargetMediaType -> request.Response.WriteAllText(mediaType.fileExtension)
                    | host, pathstem, Some extension, _ when targetExtensions.Contains extension -> request.Response.WriteAllText()
                    | host, pathstem, maybeExtension, maybeMediaType -> ()

                | _ -> failedRequests.Add request
                return! loop ()
            }
        loop ())

let watchPageNetworkTraffic (page: CdpPage) =
    page.RequestFinished.Add(fun eventArguments -> networkMailbox.Post eventArguments.Request.asCdp)



type CdpBrowser with
    member this.tabs =
        let pages = this.pageTargets |> Array.map (fun target -> target.AsPageAsync().await.asCdp)

        pages |> Array.iter watchPageNetworkTraffic
        pages

type IanaMediaType with
    static member fromHeaders(headerDictionary: Generic.Dictionary<string, string>) =
        let contentType = MimeType.Parse headerDictionary["content-type"]
        IanaMediaTypes
        |> Array.pick (fun ianaMediaType ->
            if
                ianaMediaType.mime.MediaType = contentType.MediaType
                && ianaMediaType.mime.SubType = contentType.SubType
            then
                Some(
                    {
                        ianaMediaType with
                            mime = contentType
                    }
                )
            else
                None)
type CdpHttpResponse with
    member this.mediaType = IanaMediaType.fromHeaders this.Headers




































(*







// TODO work on separating fragment and query strings into resolved resource



https.gov.leoncountyfl.bannerprodssb.EmployeeSelfService.resource.asAbsoluteDirectoryPath
https.gov.leoncountyfl.bannerprodssb.EmployeeSelfService.resource.localReference
https.gov.leoncountyfl.bannerprodssb.EmployeeSelfService.resource.remoteReference



let myIpv4 = Ipv4Address.Parse "170.85.130.82"

let uriTest = Uri "https://www.cambiaresearch.com"

let cambiaresearch = IanaScheme.https ..//  "www.cambiaresearch.com"
cambiaresearch

let relativeResourceTest = RelativePath.Create "articles/730004/the-dotnet-uri-class-and-the-cambia.uriextensions-nuget-package#sec-4EIL2NFFDJUQ2XHLG2FPTXKIT"


relativeResourceTest.asRelativeDirectoryPath
relativeResourceTest.asRelativeDirectoryPath.Parent
relativeResourceTest.asRelativeDirectoryPath.Parent.Parent


let xn__6qq79v = IanaScheme.http ..//  "你好.cn"
let googleSite = IanaScheme.http ..//  "www.google.com"



let testUri =
    Uri
        "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/payStubDetail/getPayStubDetail.json?payDate=20251231&payId=BW&payNumber=27&paySequence=0&payYear=2025#testFragment"

let pathString = PathString.FromUriComponent testUri
let queryString = QueryString.FromUriComponent testUri
queryString





let baseTest = RegistrableDomain.Parse "https://google.com"










let absoluteResource = AbsoluteResource.fromRawString "https://bannerprodssb.leoncountyfl.gov:8449"
let relativeResource =
    RelativeResource.fromString "/EmployeeSelfService/ssb/payStubDetail/getPayStubDetail.json?payDate=20251231&payId=BW&payNumber=27&paySequence=0&payYear=2025#testFragment"

absoluteResource.scheme
absoluteResource.topLevelDomain
absoluteResource.secondLevelDomain
absoluteResource.subdomain
absoluteResource.port
absoluteResource.absoluteUri
absoluteResource.absolutePath
absoluteResource.localPath
FileInfo absoluteResource.localPath


absoluteResource
absoluteResource.hierarchicalRelativeFilePath.As<RelativeDirectoryPath>()
absoluteResource.asUrl.Pathname


QueryStringUtilities.ParseQuery absoluteResource.asUri.Query

absoluteResource.asUrl
absoluteResource.asUri

let testResourceIdentifier = DomUrl "https://www.iana.org/assignments/media-types" |> AbsoluteResourceLocator
testResourceIdentifier.AppendPathSegment "media-types.xml"
testResourceIdentifier.tokens
testResourceIdentifier.asUri.AbsolutePath
testResourceIdentifier.asUri.LocalPath

let testUri = Uri(@"/api/v1/users", UriKind.Relative) |> AbsoluteResourceIdentifier


module org =
    module iana =
        module www =
            module assignments =
                let media_types = DomUrl "https://www.iana.org/assignments/media-types" |> AbsoluteResourceLocator
*)
