#time on
fsi.PrintLength <- 1
fsi.ShowDeclarationValues <- false
#r "nuget: Newtonsoft.Json, 13.0.0.0"

#I @"D:\https\com\github\eristocrates\ipa\dll"
#I @"D:\https\com\github\eristocrates\ipa\fs\DoxAletheia\src\DoxAletheia.Runtime\bin\Release\net10.0"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx\.paket\load"
#load "Me.fsx"
open Me
#load "Clipboard.fsx"
open Clipboard
//#load @".paket/load/main.group.fsx"
#r "DoxAletheia.Runtime.dll"
open DoxAletheia
open DoxAletheia.Runtime
// open type Functional

// open Ada.Url
open AngleSharp.Attributes
open AngleSharp.Dom
open AngleSharp.Html.Parser
open BrowserApi.Common
open BrowserApi.Css.Authoring
open canopy
open Dubzer.WhatwgUrl
open DynamicObj
open Fabulous.AST.Json
// open Fli
open Blake3
open Flurl
open FolkerKinzel.MimeTypes
open FSharp.Data
open FSharp.Data.JsonExtensions
open FSharp.Data.JsonPath
open FSharp.Data.JsonSchema
open FSharp.Data.JsonSchema.Core
open FSharp.Data.JsonSchema.OpenApi
open FSharp.Json
// open FSharpPlus
open FsHttp
// open FsPublicSuffix
open HCollections
// open Iana
// open IriTools
// open Json.More
// open Json.Path
// open Json.Pointer
// open JsonStructure
open Meziantou.Framework
open MimeDetective
// open Nager.PublicSuffix
// open Nager.PublicSuffix.Models
// open Nager.PublicSuffix.RuleParsers
// open Nager.PublicSuffix.RuleProviders
// open Newtonsoft.Json
// open Newtonsoft.Json.Linq
// open NJsonSchema
open NLanguageTag
// open NuGet
// open NuGet.CatalogReader
// open NuGet.Common
// open NuGet.Protocol
// open NuGet.Protocol.Core.Types
// open NuGet.Protocol.Resources
open OpenQA.Selenium
open OpenQA.Selenium.Edge
open OpenQA.Selenium.Remote

open ProviderImplementation.ProvidedTypes
open PuppeteerSharp
open PuppeteerSharp.Cdp
open PuppeteerSharp.Cdp.Messaging
// open RDFSharp.Model
open ShapeSifter
open ShapeSifter.Patterns
open System
open System.Collections
open System.Collections.Concurrent
// open System.ComponentModel.DataAnnotations
// open System.Diagnostics
// open System.Globalization
open System.IO
open System.IO.Compression
open System.Linq
// open System.Net
// open System.Numerics
open System.Reflection
// open System.Security.Cryptography
// open System.Text
open System.Text.Json
// open System.Text.Json.Schema
// open System.Text.Json.Serialization
// open System.Text.RegularExpressions
open System.Threading
open System.Threading.Tasks
// open System.Xml
// open System.Xml.Schema
// open System.Xml.Linq
open System.Xml.XPath
open Tavis.UriTemplates
open TypeEquality
open TypeShape
open TypeShape.Core
// open VDS.Common.Tries
open VDS.RDF
open WebSharper.Core
open Dramaturge
open Dramaturge.Browsers
open Dramaturge.Network
open AW.Identifiers

open SolarWinds.Api

open Microsoft.FSharp.Linq.RuntimeHelpers
open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns
open Microsoft.FSharp.Reflection
open Microsoft.VisualBasic.FileIO
open System.Numerics
open PuppeteerSharp.Input

type JsonNode = Nodes.JsonNode
type JsonNodeObject = Nodes.JsonObject
type JsonNodeArray = Nodes.JsonArray
type JsonNodeValue = Nodes.JsonValue
module FSharpLiteral = FSharp.Literals.Literal

type RDFSharp.Model.RDFGraph with
    member this.ToTurtle(turtlePath: string) =
        this.ToFileAsync(RDFSharp.Model.RDFModelEnums.RDFFormats.Turtle, turtlePath)
        |> Async.AwaitTask
        |> Async.RunSynchronously
type RdfVocabulary with
    static member ofRDFNamespace(rdfNamespace: RDFSharp.Model.RDFNamespace) =
        RdfVocabulary.PREFIX(rdfNamespace.NamespacePrefix, rdfNamespace.NamespaceUri.OriginalString)
    static member personal(namespacePrefix: string) =
        RDFSharp.Model.RDFNamespaceRegister.ensurePrefix (namespacePrefix, $"https://eristocrates.dev/ontology/{namespacePrefix}/")
        |> RdfVocabulary.ofRDFNamespace
    static member ensurePrefix((namespacePrefix: string), (namespaceName: string)) =
        RDFSharp.Model.RDFNamespaceRegister.ensurePrefix (namespacePrefix, namespaceName)
        |> RdfVocabulary.ofRDFNamespace
type UriSchemes = Iana.RegistryProvider.``Uniform Resource Identifier (URI) Schemes``.``Uniform Resource Identifier (URI) Schemes``
type PublicSuffixes = PublicSuffixList.PublicSuffixProvider
type Mime = Iana.InternetMediaTypeProvider

module commonplace =
    let _namespace = RdfVocabulary.personal "commonplace"
    let RequestResponse = _namespace.curie "RequestResponse" |> ClassIri |> ClassExpression
    let requestResponse = _namespace.curie "requestResponse" |> ObjectPropertyIri
    let Blake3Hash = _namespace.curie "Blake3Hash" |> ClassIri |> ClassExpression
    let blake3Hash = _namespace.curie "blake3Hash" |> DataPropertyIri
type Attr with
    static member Class = AttrSelector "Class"
type String with
    member this.asBlake3 = Blake3.Hasher.Hash(this.asUtf8)
type Hash with
    member this.asBytes = this.AsSpan().ToArray()
    member this.hashString = this.ToString()
module CdpEndpoint =
    module json =
        [<Literal>]
        let version = "http://127.0.0.1:9222/json/version"
// RemoteWebDriver.download "156.0.4314.56"
type CdpVersionProvider = JsonProvider<UseOriginalNames=true, OmitNullFields=true, RootName="version", Sample=CdpEndpoint.json.version>
let cdpVersion () =
    http { GET CdpEndpoint.json.version }
    |> Request.send
    |> Response.toText
    |> CdpVersionProvider.Parse




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

    new(page: CdpPage) = CdpRealm(page.MainFrame :?> CdpFrame)
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

type BrowserApi.Dom.HtmlCollection with
    member this.asElements =
        Array.init (int this.Length) (fun index ->
            this[uint32 index].Handle
            |> BrowserApiReflection.fromHandle<BrowserApi.Dom.Element>)

type BrowserApi.Dom.Element with
    member this.textContent = this.TextContent.Trim()
    member this.outerHTML = this.OuterHtmlNodes |> List.exactlyOne
    member this.querySelectorAll(selector: Selector) =
        this.QuerySelectorAll selector.Css
        |> fun nodeList ->
            Array.init (int nodeList.Length) (fun index ->
                nodeList[uint32 index].Handle
                |> BrowserApiReflection.fromHandle<BrowserApi.Dom.Element>)
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

type JavascriptBuilder() =

    let propertyName (propertyInfo: PropertyInfo) =
        propertyInfo.GetCustomAttributes(typeof<DomNameAttribute>, true)
        |> Seq.tryPick (function
            | :? DomNameAttribute as attribute -> Some attribute.OfficialName
            | _ -> None)
        |> Option.defaultValue propertyInfo.Name

    let rec expression (variables: Map<Var, JavaScript.Syntax.Id>) (quotation: Expr) : JavaScript.Syntax.Expression =

        match quotation with

        // fun element -> ...
        | Lambda(variable, body) ->

            let identifier = JavaScript.Syntax.Id.New variable.Name

            let variables = variables.Add(variable, identifier)

            let body = expression variables body

            JavaScript.Syntax.Lambda(None, [ identifier ], [ JavaScript.Syntax.Return(Some body) ], true)

        // element
        | Var variable ->

            match variables.TryFind variable with
            | Some identifier -> JavaScript.Syntax.Var identifier

            | None -> failwith $"Unknown variable: {variable.Name}"

        // element.OuterHtml
        | PropertyGet(Some target, propertyInfo, []) ->

            let target = expression variables target

            let name = propertyName propertyInfo

            JavaScript.Syntax.Binary(target, JavaScript.Syntax.BinaryOperator.``.``, JavaScript.Syntax.Constant(JavaScript.Syntax.Literal.String name))

        // "hello"
        | Value(:? string as value, _) ->

            JavaScript.Syntax.Constant(JavaScript.Syntax.Literal.String value)

        // true / false
        | Value(:? bool as value, _) ->
            JavaScript.Syntax.Constant(
                if value then
                    JavaScript.Syntax.Literal.True
                else
                    JavaScript.Syntax.Literal.False
            )

        // null
        | Value(null, _) ->

            JavaScript.Syntax.Constant(JavaScript.Syntax.Literal.Null)

        | unsupported -> failwith $"""Unsupported F# quotation: {unsupported}"""

    let compileQuotation (quotation: Expr) =

        let quotation =
            match quotation with

            // javascript { return expression }
            //
            // The quoted computation expression contains the
            // generated call to JavascriptBuilder.Return.
            | Call(_, methodInfo, [ value ]) when methodInfo.Name = "Return" -> value

            | expression -> expression

        quotation
        |> expression Map.empty
        |> JavaScript.Writer.ExpressionToString JavaScript.Preferences.Readable
    member _.Return(value: 'T) : 'T = value

    member _.Quote(expression: Expr<'T>) = expression

    member _.Run(expression: Expr<'T>) = {
        javascriptString = compileQuotation expression
    }

let javascript = JavascriptBuilder()

let javascriptLiteral = javascript { return fun (element: IElement) -> element.OuterHtml }

type SeleniumKey =
    | Add
    | Alt
    | ArrowDown
    | ArrowLeft
    | ArrowRight
    | ArrowUp
    | Backspace
    | Cancel
    | Clear
    | Command
    | Control
    | Decimal
    | Delete
    | Divide
    | Down
    | End
    | Enter
    | Equal
    | Escape
    | F1
    | F10
    | F11
    | F12
    | F2
    | F3
    | F4
    | F5
    | F6
    | F7
    | F8
    | F9
    | Help
    | Home
    | Insert
    | Left
    | LeftAlt
    | LeftControl
    | LeftShift
    | Meta
    | Multiply
    | Null
    | NumberPad0
    | NumberPad1
    | NumberPad2
    | NumberPad3
    | NumberPad4
    | NumberPad5
    | NumberPad6
    | NumberPad7
    | NumberPad8
    | NumberPad9
    | PageDown
    | PageUp
    | Pause
    | Return
    | Right
    | Semicolon
    | Separator
    | Shift
    | Space
    | Subtract
    | Tab
    | Up
    | ZenkakuHankaku

    member this.asString =
        match this with

        | Add -> OpenQA.Selenium.Keys.Add
        | Alt -> OpenQA.Selenium.Keys.Alt
        | ArrowDown -> OpenQA.Selenium.Keys.ArrowDown
        | ArrowLeft -> OpenQA.Selenium.Keys.ArrowLeft
        | ArrowRight -> OpenQA.Selenium.Keys.ArrowRight
        | ArrowUp -> OpenQA.Selenium.Keys.ArrowUp
        | Backspace -> OpenQA.Selenium.Keys.Backspace
        | Cancel -> OpenQA.Selenium.Keys.Cancel
        | Clear -> OpenQA.Selenium.Keys.Clear
        | Command -> OpenQA.Selenium.Keys.Command
        | Control -> OpenQA.Selenium.Keys.Control
        | Decimal -> OpenQA.Selenium.Keys.Decimal
        | Delete -> OpenQA.Selenium.Keys.Delete
        | Divide -> OpenQA.Selenium.Keys.Divide
        | Down -> OpenQA.Selenium.Keys.Down
        | End -> OpenQA.Selenium.Keys.End
        | Enter -> OpenQA.Selenium.Keys.Enter
        | Equal -> OpenQA.Selenium.Keys.Equal
        | Escape -> OpenQA.Selenium.Keys.Escape
        | F1 -> OpenQA.Selenium.Keys.F1
        | F10 -> OpenQA.Selenium.Keys.F10
        | F11 -> OpenQA.Selenium.Keys.F11
        | F12 -> OpenQA.Selenium.Keys.F12
        | F2 -> OpenQA.Selenium.Keys.F2
        | F3 -> OpenQA.Selenium.Keys.F3
        | F4 -> OpenQA.Selenium.Keys.F4
        | F5 -> OpenQA.Selenium.Keys.F5
        | F6 -> OpenQA.Selenium.Keys.F6
        | F7 -> OpenQA.Selenium.Keys.F7
        | F8 -> OpenQA.Selenium.Keys.F8
        | F9 -> OpenQA.Selenium.Keys.F9
        | Help -> OpenQA.Selenium.Keys.Help
        | Home -> OpenQA.Selenium.Keys.Home
        | Insert -> OpenQA.Selenium.Keys.Insert
        | Left -> OpenQA.Selenium.Keys.Left
        | LeftAlt -> OpenQA.Selenium.Keys.LeftAlt
        | LeftControl -> OpenQA.Selenium.Keys.LeftControl
        | LeftShift -> OpenQA.Selenium.Keys.LeftShift
        | Meta -> OpenQA.Selenium.Keys.Meta
        | Multiply -> OpenQA.Selenium.Keys.Multiply
        | Null -> OpenQA.Selenium.Keys.Null
        | NumberPad0 -> OpenQA.Selenium.Keys.NumberPad0
        | NumberPad1 -> OpenQA.Selenium.Keys.NumberPad1
        | NumberPad2 -> OpenQA.Selenium.Keys.NumberPad2
        | NumberPad3 -> OpenQA.Selenium.Keys.NumberPad3
        | NumberPad4 -> OpenQA.Selenium.Keys.NumberPad4
        | NumberPad5 -> OpenQA.Selenium.Keys.NumberPad5
        | NumberPad6 -> OpenQA.Selenium.Keys.NumberPad6
        | NumberPad7 -> OpenQA.Selenium.Keys.NumberPad7
        | NumberPad8 -> OpenQA.Selenium.Keys.NumberPad8
        | NumberPad9 -> OpenQA.Selenium.Keys.NumberPad9
        | PageDown -> OpenQA.Selenium.Keys.PageDown
        | PageUp -> OpenQA.Selenium.Keys.PageUp
        | Pause -> OpenQA.Selenium.Keys.Pause
        | Return -> OpenQA.Selenium.Keys.Return
        | Right -> OpenQA.Selenium.Keys.Right
        | Semicolon -> OpenQA.Selenium.Keys.Semicolon
        | Separator -> OpenQA.Selenium.Keys.Separator
        | Shift -> OpenQA.Selenium.Keys.Shift
        | Space -> OpenQA.Selenium.Keys.Space
        | Subtract -> OpenQA.Selenium.Keys.Subtract
        | Tab -> OpenQA.Selenium.Keys.Tab
        | Up -> OpenQA.Selenium.Keys.Up
        | ZenkakuHankaku -> OpenQA.Selenium.Keys.ZenkakuHankaku
    member this.press = canopy.classic.press this.asString

type WebDriverWindow = {
    index: int
    handle: string
    title: string
    url: string
}

type RemoteWebDriver with
    static member download(version: string) =
        let directory = Directory.CreateDirectory @$"D:\Program_Files\Microsoft\Edge\Version{version}"
        let filePath = Path.Combine(directory.FullName, "edgedriver_win64.zip")

        http { GET $"https://msedgedriver.microsoft.com/{version}/edgedriver_win64.zip" }
        |> Request.send
        |> Response.saveFile filePath
        ZipFile.ExtractToDirectory(filePath, directory.FullName)
    member this.windows =
        let originalHandle = this.CurrentWindowHandle

        try
            this.WindowHandles
            |> Seq.mapi (fun index handle ->
                this.SwitchTo().Window(handle) |> ignore

                {
                    index = index + 1
                    handle = handle
                    title = this.Title
                    url = this.Url
                })
            |> Seq.toArray
        finally
            this.SwitchTo().Window(originalHandle) |> ignore

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

type CdpBrowser with

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

    member this.pages =

        this.pageTargets
        |> Array.choose (fun target ->
            try
                Some <| target.AsPageAsync().await.asCdp
            with _ ->
                None)

module HttpHeader =
    let Irn (requestId: string) (fieldName: string) = {
        namespaceIdentifier = "chromedevtools"
        namespaceSpecificString = $"http:header:{fieldName}:{requestId}"
    }

type CdpHttpRequest with
    member this.irl = irlref this.Url

    member this.iri = Irl this.irl
    member this.originIri = irlref this.irl.origin
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

type Universal.Common.DataUriBuilder with
    member this.SetMediaType(mediaType: Iana.InternetMediaType) =
        this.SetMediaType(Universal.Common.MediaType.FromExtension mediaType.dotExtension)
type Iana.InternetMediaType with
    member this.asDataUri(data: Byte array) =
        Universal.Common.DataUriBuilder().SetMediaType(this).SetData(data).DataUri
    static member fromHeaders(headerDictionary: Generic.Dictionary<string, string>) =
        try
            MimeType.TryParse(headerDictionary["content-type"])
            |> fun (wasParsed, mimeType) ->
                match wasParsed with
                | true -> Some(Iana.InternetMediaType.ofMimeType mimeType)
                | false -> None
        with _ ->
            None

type CdpHttpResponse with
    member this.irl = irlref this.Url
    member this.iri = Irl this.irl
    member this.originIri = irlref this.irl.origin

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

    // member this.mime = Iana.InternetMediaType.fromHeaders this.Headers
    // member this.mediaType = Iana.InternetMediaTType.fromHeaders this.Headers

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

// TODO try dynamic operator on AttrSelector for arbitrary attributes
type CdpRequest = {
    httpRequest: CdpHttpRequest
    httpResponse: CdpHttpResponse
    iri: Irl
    text: string
} with

    member this.Id = this.httpRequest.CdpRequestId

    member this.originGraphName = VDS.RDF.UriNode.ofIri this.httpResponse.originIri

    member this.asSubject = this.iri.asSubject
    member this.asPredicate = this.iri.asPredicate
    member this.asObject = this.iri.asObject

    member this.irn = {
        namespaceIdentifier = "chromedevtools"
        namespaceSpecificString = this.Id
    }
    member this.headers = Array.concat [| this.httpRequest.headers; this.httpResponse.headers |]
    member this.headerIrns = List.concat [| this.httpRequest.headerIrns; this.httpResponse.headerIrns |]
type CdpPageTarget with
    member this.irl = irlref this.Url

type CdpPage with
    member this.GoToAsync(irl: Irl) = this.GoToAsync(irl.remoteReference)
    member this.irl = irlref this.Url
    member this.frames = this.Frames |> Array.map (fun frame -> frame.asCdp)
    member this.Locator(selector: Selector) = this.Locator(selector.Css)
    member this.QuerySelectorAllAsync(selector: Selector) = this.QuerySelectorAllAsync selector.Css
    member this.QuerySelectorAllHandleAsync(selector: Selector) =
        this.QuerySelectorAllHandleAsync selector.Css
    member this.QuerySelectorAsync(selector: Selector) = this.QuerySelectorAsync selector.Css
    member this.Realm = CdpRealm this.MainFrame.asCdp

type CdpElementHandle with
    member this.RealmElement(realm: CdpRealm) =
        realm.document.QuerySelector this.RemoteObject.Description
    member this.RealmElements(realm: CdpRealm) =
        (realm.document.QuerySelectorAll this.RemoteObject.Description).asElements
type MouseButton with
    member this.Click(handle: CdpElementHandle) =
        let options = new ClickOptions()
        options.Button <- this
        handle.ClickAsync(options).await

type CdpElementHandle with
    member this.locator = this.AsLocator()

type CdpPage with
    member this.tryFindFrameId(frameId: string) =
        this.frames |> Array.tryFind (fun frame -> frame.Id = frameId)
    member this.tryFindFrameName(frameName: string) =
        this.frames |> Array.tryFind (fun frame -> frame.Name = frameName)
    member this.findFrameId(frameId: string) =
        this.tryFindFrameId frameId |> Option.get
    member this.findFrameName(frameName: string) =
        this.tryFindFrameName frameName |> Option.get
type CdpFrame with
    member this.frames = this.ChildFrames |> Seq.map (fun frame -> frame.asCdp) |> Seq.toArray

    member this.tryFindFrameId(frameId: string) =
        this.frames |> Array.tryFind (fun frame -> frame.Id = frameId)
    member this.tryFindFrameName(frameName: string) =
        this.frames |> Array.tryFind (fun frame -> frame.Name = frameName)
    member this.findFrameId(frameId: string) =
        this.tryFindFrameId frameId |> Option.get
    member this.findFrameName(frameName: string) =
        this.tryFindFrameName frameName |> Option.get
    member this.Realm = CdpRealm this

type EdgeFrame = {
    dramaturge: Frame
    puppeteer: CdpFrame
    irl: Irl
    title: string
}

type EdgePage = {
    dramaturge: Page
    puppeteer: CdpPage
    irl: Irl
    window: WebDriverWindow
} with

    member this.frames =
        Array.zip (this.dramaturge.Frames |> Seq.toArray) (this.puppeteer.frames)
        |> Array.map (fun (bidiFrame, cdpFrame) -> {
            dramaturge = bidiFrame
            puppeteer = cdpFrame
            irl = irlref bidiFrame.Url
            title = cdpFrame.GetTitleAsync().Result
        })
    static member BringToFront(page: EdgePage) =
        page.dramaturge.BringToFrontAsync() |> awaitUnit
    member this.front = EdgePage.BringToFront this

type Browser with
    member this.pages = this.Pages |> Seq.toArray
type EdgeBrowser = {
    canopy: RemoteWebDriver
    puppeteer: CdpBrowser
    dramaturge: BrowserGroup
} with

    member this.urls =
        Array.concat [|
            this.canopy.windows |> Array.map (fun window -> window.url)
            this.dramaturge.DefaultBrowser.pages |> Array.map (fun page -> page.Url)
            this.puppeteer.pages |> Array.map (fun page -> page.Url)
        |]
        |> Array.distinct
        |> Array.sort
    member this.InventoryPages() =
        let windows = this.canopy.windows
        let bidiPages = this.dramaturge.DefaultBrowser.pages
        let cdpPages = this.puppeteer.pages
        this.urls
        |> Array.Parallel.choose (fun url ->
            let maybeWindow = windows |> Array.tryFind (fun window -> window.url = url)
            let maybeBidiPage = bidiPages |> Array.tryFind (fun page -> page.Url = url)
            let maybeCdpPage = cdpPages |> Array.tryFind (fun page -> page.Url = url)
            match maybeWindow, maybeBidiPage, maybeCdpPage with
            | Some window, Some bidiPage, Some cdpPage ->

                Some {
                    dramaturge = bidiPage
                    puppeteer = cdpPage
                    irl = irlref url
                    window = window
                }
            | _, _, _ -> None)

    member this.canopyPage(pages: EdgePage array) =
        pages
        |> Array.find (fun page -> page.window.handle = this.canopy.CurrentWindowHandle)
    static member op_Implicit(edge: EdgeBrowser) = edge.canopy
    static member op_Implicit(edge: EdgeBrowser) : IWebDriver = edge.canopy :> IWebDriver
    static member op_Implicit(edge: EdgeBrowser) = edge.puppeteer
    static member exeFile = FileInfo $"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"
    static member driverFile = FileInfo $"D:\Program_Files\Microsoft\Edge\Version156.0.4314.42\msedgedriver.exe"
    static member dataDirectory = DirectoryInfo $"D:\Program_Files\Microsoft\Edge\data_dir"
    static member startBrowserCommand = $"& '{EdgeBrowser.exeFile.FullName}' --remote-debugging-port=9222 --user-data-dir={EdgeBrowser.dataDirectory.FullName}"
    static member startDriverCommand = $"& '{EdgeBrowser.driverFile.FullName}' --port=9515"
    static member Connect() =
        let remoteWebDriver =
            let edgeOptions = EdgeOptions()
            edgeOptions.DebuggerAddress <- "127.0.0.1:9222"
            new RemoteWebDriver(Uri("http://127.0.0.1:9515"), edgeOptions)
        let cdpBrowser =

            let options = ConnectOptions()

            options.BrowserURL <- "http://127.0.0.1:9222"
            options.DefaultViewport <- null

            Puppeteer.ConnectAsync(options).Result :?> CdpBrowser
        let browserGroup =
            let browserLauncher = BrowserLauncher.Configure(BrowserKind.Edge).ConnectToExisting(Uri <| cdpVersion().webSocketDebuggerUrl)
            BrowserGroup.LaunchAsync(browserLauncher).Result
        let edge = {
            canopy = remoteWebDriver
            puppeteer = cdpBrowser
            dramaturge = browserGroup
        }
        canopy.classic.browser <- edge.canopy
        edge
    member this.tryFindPage(subString: String) =
        fun (pages: EdgePage array) ->
            pages
            |> Array.tryFind (fun page ->
                match subString.ToLowerInvariant(), page.irl.remoteReference.ToLowerInvariant(), page.window.title.ToLowerInvariant() with
                | substring, url, title when
                    (url.Contains substring || title.Contains substring)
                    && page.window.handle <> this.canopy.CurrentWindowHandle
                    ->
                    true
                | _, _, _ -> false)
    member this.page(page: EdgePage) =
        canopy.classic.switchToTab page.window.index
    member this.page(irl: Irl) =
        fun (pages: EdgePage array) -> pages |> this.page irl.remoteReference
    member this.page(site: Site) =
        fun (pages: EdgePage array) -> pages |> this.page site.remoteReference
    member this.page(domain: Domain) =
        fun (pages: EdgePage array) -> pages |> this.page (UriSchemes.http.host domain)
    member this.page(subString: string) =
        fun (pages: EdgePage array) ->
            match pages |> this.tryFindPage subString with
            | Some page -> this.page page
            | None -> ()
    member this.closePage(page: EdgePage) =
        canopy.classic.closeTab page.window.index
    member this.closePage(irl: Irl) =
        fun (pages: EdgePage array) -> pages |> this.closePage irl.remoteReference
    member this.closePage(site: Site) =
        fun (pages: EdgePage array) -> pages |> this.closePage site.remoteReference
    member this.closePage(domain: Domain) =
        fun (pages: EdgePage array) -> pages |> this.closePage (UriSchemes.http.host domain)
    member this.closePage(subString: string) =
        fun (pages: EdgePage array) ->
            match pages |> this.tryFindPage subString with
            | Some page -> this.closePage page
            | None -> ()
    member this.driverIrl = canopy.classic.currentUrl () |> Url.Parse |> Irl.ofUrl
    member this.driverTitle = canopy.classic.title ()
    member this.reload() = canopy.classic.reload ()
    member this.navigate(navigation: canopy.parallell.functions.Navigate) = canopy.classic.navigate navigation
    member this.back = this.navigate canopy.parallell.functions.Navigate.Back
    member this.forward = this.navigate canopy.parallell.functions.Navigate.Forward
    member this.irl(irl: Irl) = canopy.classic.url irl.remoteReference
    member this.irl(site: Site) = canopy.classic.url site.remoteReference
    member this.irl(domain: Domain) = this.irl (UriSchemes.https.host domain)
    member this.write(text: string) =
        fun (selector: Selector) -> canopy.classic.(<<) selector.Css text
    member this.read(selector: Selector) = canopy.classic.read selector.Css
    member this.drag(fromSelector: Selector) =
        fun (ontoSelector: Selector) -> canopy.classic.drag fromSelector.Css ontoSelector.Css this
    member this.click(text: string) = canopy.classic.click text
    member this.click(selector: Selector) = canopy.classic.click selector.Css
    member this.click(element: IWebElement) = canopy.classic.click element
    member this.rightClick(text: string) = canopy.classic.rightClick text
    member this.rightClick(selector: Selector) = canopy.classic.rightClick selector.Css
    member this.rightClick(element: IWebElement) = canopy.classic.rightClick element
    member this.doubleClick(text: string) = canopy.classic.doubleClick text
    member this.doubleClick(selector: Selector) = canopy.classic.doubleClick selector.Css
    member this.doubleClick(element: IWebElement) = canopy.classic.doubleClick element
    member this.ctrlClick(text: string) = canopy.classic.ctrlClick text
    member this.ctrlClick(selector: Selector) = canopy.classic.ctrlClick selector.Css
    member this.ctrlClick(element: IWebElement) = canopy.classic.ctrlClick element
    member this.shiftClick(text: string) = canopy.classic.shiftClick text
    member this.shiftClick(selector: Selector) = canopy.classic.shiftClick selector.Css
    member this.shiftClick(element: IWebElement) = canopy.classic.shiftClick element
    member this.screenshot(file: FileInfo) =
        canopy.classic.screenshot file.DirectoryName file.Name
    member this.check(text: string) = canopy.classic.check text
    member this.check(selector: Selector) = canopy.classic.check selector.Css
    member this.check(element: IWebElement) = canopy.classic.check element
    member this.uncheck(text: string) = canopy.classic.uncheck text
    member this.uncheck(selector: Selector) = canopy.classic.uncheck selector.Css
    member this.uncheck(element: IWebElement) = canopy.classic.uncheck element
    member this.hover(text: string) = canopy.classic.hover text
    member this.hover(selector: Selector) = canopy.classic.hover selector.Css
    member this.element(text: string) = canopy.classic.element text
    member this.element(selector: Selector) = canopy.classic.element selector.Css
    member this.elementWithText (text: string) (selector: Selector) =
        canopy.classic.elementWithText selector.Css text
    member this.someElement(text: string) = canopy.classic.someElement text
    member this.someElement(selector: Selector) = canopy.classic.someElement selector.Css
    member this.someElementWithin(text: string) = canopy.classic.someElementWithin text
    member this.someElementWithin(selector: Selector) =
        canopy.classic.someElementWithin selector.Css
    member this.parent(webElement: IWebElement) = canopy.classic.parent webElement
    member this.someParent(webElement: IWebElement) = canopy.classic.someParent webElement
    member this.elements(text: string) = canopy.classic.elements text
    member this.elements(selector: Selector) = canopy.classic.elements selector.Css
    member this.elementsWithin(text: string) = canopy.classic.elementsWithin text
    member this.elementsWithin(selector: Selector) =
        canopy.classic.elementsWithin selector.Css
    member this.elementsWithText (text: string) (selector: Selector) =
        canopy.classic.elementsWithText selector.Css text
    member this.nth(ordinal: int) =
        fun (selector: Selector) -> canopy.classic.nth ordinal selector.Css
    member this.first(text: string) = canopy.classic.first text
    member this.first(selector: Selector) = canopy.classic.first selector.Css
    member this.last(text: string) = canopy.classic.last text
    member this.last(selector: Selector) = canopy.classic.last selector.Css
    member this.elementText(selector: Selector) =
        canopy.classic.fastTextFromCSS selector.Css
    member this.resize(x: int) =
        fun (y: int) -> canopy.classic.resize (x, y)
    member this.rotate() = canopy.classic.rotate ()
    member this.js(literal: JavascriptLiteral) =
        (this.canopy :> IJavaScriptExecutor).ExecuteScript(literal.javascriptString)
    member this.sleep(seconds: int) = canopy.classic.sleep seconds
    member this.highlight(selector: Selector) = canopy.classic.highlight selector.Css
    member this.waitFor(predicate: unit -> bool) = canopy.classic.waitFor predicate
    member this.waitFor(explanation: string) =
        fun (predicate: unit -> bool) -> canopy.classic.waitFor2 explanation predicate
    member this.waitFor(selector: Selector) =
        canopy.classic.waitForElement selector.Css
    member this.clear(selector: Selector) = canopy.classic.clear selector.Css
    member this.press(key: SeleniumKey) = canopy.classic.press key.asString
    member this.alert = canopy.classic.alert ()
    member this.acceptAlert = canopy.classic.acceptAlert ()
    member this.dismissAlert = canopy.classic.dismissAlert ()
    member this.pin(direction: types.direction) = canopy.classic.pin direction
    member this.positionBrowser(leftPercentage: int) =
        fun (topPercentage: int) ->
            fun (widthPercentage: int) -> fun (heightPercentage: int) -> canopy.classic.positionBrowser leftPercentage topPercentage widthPercentage heightPercentage
    member this.css(selector: Selector) = canopy.classic.css selector.Css
    member this.xpath(xpath: XPathExpression) = canopy.classic.xpath xpath.Expression
    member this.jquery jquerySelector = canopy.classic.jquery jquerySelector
    member this.label(label: string) = canopy.classic.label label
    member this.text(text: string) = canopy.classic.text text
    member this.value = canopy.classic.value

type String with
    member this.com = PublicSuffixes.com.tld.domain this
    member this.org = PublicSuffixes.org.tld.domain this
    member this.gov = PublicSuffixes.gov.tld.domain this
    member this.net = PublicSuffixes.net.tld.domain this

type FSharp.Data.HtmlDocument with
    static member ofWebDriver(webDriver: RemoteWebDriver) = HtmlDocument.Parse webDriver.PageSource
type AngleSharp.Html.Dom.IHtmlDocument with
    static member ofWebDriver(webDriver: RemoteWebDriver) =
        HtmlParser().ParseDocument(File.ReadAllText(webDriver.PageSource))

type EdgeBrowser with
    member this.FSharpHtmlDocument = FSharp.Data.HtmlDocument.ofWebDriver this.canopy
    member this.AngleSharpHtmlDocument = AngleSharp.Html.Dom.IHtmlDocument.ofWebDriver this.canopy
    member this.https(domain: Domain) =
        UriSchemes.https.site domain |> this.irl
    member this.http(domain: Domain) = UriSchemes.http.site domain |> this.irl
    member this.www(label: string) =
        fun (suffix: PublicSuffix) ->
            {
                topLevelDomain = suffix
                secondLevelDomain = label
                subdomainLabels = [ "www" ]
            }
            |> UriSchemes.https.site
            |> this.irl
    member this.www(domain: Domain) =
        {
            domain with
                subdomainLabels = [ "www" ]
        }
        |> UriSchemes.https.site
        |> this.irl
    member this.google(searchQuery: string) =
        let queryString = FSharpRecord.Parse {| q = searchQuery; udm = 14 |}
        UriSchemes.https.host "www" "google".com / "search" =? queryString |> this.irl
    member this.googleImages(searchQuery: string) =
        let queryString =
            FSharpRecord.Parse {|
                q = searchQuery
                udm = 14
                tbm = "isch"
            |}
        UriSchemes.https.host "www" "google".com / "search" =? queryString |> this.irl
    member this.googleNews(searchQuery: string) =
        let queryString =
            FSharpRecord.Parse {|
                q = searchQuery
                udm = 14
                tbm = "nws"
            |}
        UriSchemes.https.host "www" "google".com / "search" =? queryString |> this.irl

type NetworkRequest with
    member this.Iri =
        match this.Url with
        | dataUrl when dataUrl.StartsWith "data:" -> Universal.Common.DataUri dataUrl |> DataIri
        | url -> irlref url |> Irl
    member this.tryIrl =
        match this.Iri with
        | Irl irl -> Some irl
        | _ -> None

module NetworkTraffic =

    type Message =
        | Capture of NetworkRequest array
        | Snapshot of AsyncReplyChannel<NetworkRequest array>

    type Mailbox() =

        let mailbox =
            MailboxProcessor.Start(fun inbox ->

                let rec loop (captured: NetworkRequest list) =
                    async {
                        let! message = inbox.Receive()

                        match message with
                        | Capture requests ->

                            let updated = requests |> Array.fold (fun state request -> request :: state) captured

                            return! loop updated

                        | Snapshot reply ->

                            reply.Reply(captured |> List.rev |> List.toArray)

                            return! loop captured
                    }

                loop [])

        member _.Capture(requests: NetworkRequest array) = mailbox.Post(Capture requests)

        member _.Requests = mailbox.PostAndReply Snapshot

        member this.byOrigin =
            this.Requests
            |> Array.choose (fun request ->
                try
                    match request.tryIrl with
                    | Some irl -> Some(irlref irl.origin, request)
                    | _ -> None
                with _ ->
                    None)
            |> Array.sortBy (fun (origin, request) -> origin.remoteReference, request.Url)
        member this.RequestOrigins =
            this.byOrigin
            |> Array.map fst
            |> Array.distinct
            |> Array.sortBy (fun origin -> origin.remoteReference)
    let rec collect (monitor: NetworkTrafficMonitor) (store: Mailbox) (cancellationToken: CancellationToken) =

        async {
            while not cancellationToken.IsCancellationRequested do

                let! captured = monitor.GetCapturedTrafficAsync(TimeSpan.FromSeconds(1.0)) |> Async.AwaitTask

                if captured.Count > 0 then
                    captured |> Seq.toArray |> store.Capture
        }

let networkMailbox = NetworkTraffic.Mailbox()
let cancellation = new CancellationTokenSource()

let edge = EdgeBrowser.Connect()

let networkTrafficMonitor =
    let options = new NetworkTrafficMonitorOptions()
    options.MaxBodySize <- 200000000UL
    new NetworkTrafficMonitor(edge.dramaturge.Driver, options)
networkTrafficMonitor.StartMonitoringAsync() |> awaitUnit
let networkTrafficCollector = NetworkTraffic.collect networkTrafficMonitor networkMailbox cancellation.Token
Async.Start(networkTrafficCollector, cancellation.Token)
// TODO look into opensearch https://github.com/dewitt/opensearch/blob/master/opensearch-1-1-draft-6.md#opensearch-description-document
let pages = edge.InventoryPages()
let browser = edge.dramaturge.DefaultBrowser
module com =
    let tld = PublicSuffixes.com.tld
    module samanage =
        let secondLevelDomain = "samanage"
        let domain = tld.domain secondLevelDomain
        module leoncountyfl =
            let subdomain = "leoncountyfl"
            let https = UriSchemes.https.host subdomain domain

edge.irl com.samanage.leoncountyfl.https
com.samanage.leoncountyfl.https / "incidents" |> edge.irl

pages |> edge.page com.samanage.leoncountyfl.https

let requestResponses =
    networkMailbox.byOrigin
    |> Array.filter (fun (origin, request) -> origin.remoteReference = com.samanage.leoncountyfl.https.remoteReference)
    |> Array.map snd
    |> Array.choose (fun request ->
        match request.tryIrl with
        | Some irl when request.ResponseMimeType = Mime.application.json.mime.contentType -> Some(request, irl)
        | _ -> None)

requestResponses.Length
let request, responseIrl = requestResponses[10]
type String with
    static member percentDecoded(stringValue: string) =
        if stringValue.Contains("%") then
            System.Uri.UnescapeDataString stringValue |> String.percentDecoded
        else
            stringValue
type Irl with
    member this.queryString =
        match this.searchQuery with
        | Some searchQuery -> String.percentDecoded searchQuery
        | None -> String.Empty
let queryString = System.Web.HttpUtility.ParseQueryString responseIrl.searchQuery.Value

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

// TODO make strongly typed query string and fragment string
type QueryString = QueryString of Microsoft.AspNetCore.Http.QueryString
type FragmentString = FragmentString of Microsoft.AspNetCore.Http.FragmentString
let responseIndividuals =
    requestResponses
    |> Array.map (fun (request, response) ->
        let responseFile =
            let textDirectory = Path.Combine(response.stemPath, "text") |> Directory.CreateDirectory
            match response.tryInternetMediaType, response.searchQuery with
            | Some internetMediaType, Some searchQuery ->
                File.WriteAllText(Path.Combine(textDirectory.FullName, $"{response.queryString.asBlake3.hashString}.blake3.txt"), response.queryString)
                Path.Combine(response.stemPath, internetMediaType.mime.MediaType, $"{response.queryString.asBlake3.hashString}.{internetMediaType.extension}")
                |> FileInfo
            | Some internetMediaType, None ->
                Path.Combine(response.stemPath, internetMediaType.mime.MediaType, $"{internetMediaType.mime.SubType}.{internetMediaType.extension}")
                |> FileInfo
            | None, Some searchQuery ->
                File.WriteAllText(Path.Combine(response.stemPath, $"{response.queryString.asBlake3.hashString}.blake3.txt"), response.queryString)
                Path.Combine(response.stemPath, "unknown-media-type", $"{response.queryString.asBlake3.hashString}")
                |> FileInfo
            | None, None ->
                Path.Combine(response.stemPath, "unknown-media-type", $"unknown-sub-type")
                |> FileInfo

        Directory.CreateDirectory responseFile.DirectoryName |> ignore
        File.WriteAllText(responseFile.FullName, request.ResponseBody)
        NamedIndividualIri response |> Individual)
    |> Array.toList

let originOntology = OntologyBuilder com.samanage.leoncountyfl.https.Iri { yield commonplace.RequestResponse |> Functional.ClassAssertion responseIndividuals }
// TODO assert query strings to hashes
let OWLOntology = OWLSharp.Ontology.OWLOntology.ofOntology originOntology
let rdfGraph = OWLOntology.ToRDFGraphAsync().Result
// RDFSharp.Model.RDFGraph.ofNTriples ntriples
let turtlePath = Path.Combine(com.samanage.leoncountyfl.https.localReference, "origin.ttl")
Directory.CreateDirectory com.samanage.leoncountyfl.https.localReference
|> ignore
com.samanage.leoncountyfl.https.localReference.clip

rdfGraph.ToTurtle turtlePath

Path.GetDirectoryName irl.localReference
Path.GetFileName irl.localReference
Path.GetFileNameWithoutExtension irl.localReference
Path.GetExtension irl.localReference
let (Some mime) = irl.tryInternetMediaType
let documentDirectory = Directory.Create irl.stemPath
request.ResponseBody

origins
|> Array.map (fun origin -> irlref origin)
|> Array.sortBy (fun originIrl -> originIrl.secondLevelDomain)
|> Array.map (fun originIrl -> originIrl.remoteReference)
|> String.Clipboard.clip
// TODO look into reverse domain name to path trie of path tokens
let failedIrls =
    networkMailbox.Requests
    |> Array.choose (fun request ->
        try
            request.Iri |> ignore
            None
        with _ ->
            Some request.Url)
failedIrls.Length
failedIrls
Universal.Common.DataUri
    "data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 20 20' aria-hidden='true'%3E%3Cpath fill='%23444' d='M12.278 13.604a6.875 6.875 0 1 1 1.326-1.326l3.621 3.622a.937.937 0 0 1-1.325 1.325zm.847-5.479a5 5 0 1 0-10 0 5 5 0 0 0 10 0'%3E%3C/path%3E%3C/svg%3E"
// |> String.Clipboard.clip
iriref failedIrls[0]
let dataUri = Universal.Common.DataUri failedIrls[0]

dataUri.InternetMediaType.extension

let request = networkMailbox.Requests[0]

networkMailbox.Requests.Length

let har = networkMailbox.Requests |> HarGenerator.Generate

File.WriteAllText("edge-session.har", har)
