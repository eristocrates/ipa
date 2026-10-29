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
open BrowserApi.Css.Authoring
open canopy
// open Dubzer.WhatwgUrl
open DynamicObj
open Fabulous.AST.Json
// open Fli
open Flurl
// open FolkerKinzel.MimeTypes
open FSharp.Data
open FSharp.Data.JsonExtensions
open FSharp.Data.JsonPath
open FSharp.Data.JsonSchema
open FSharp.Data.JsonSchema.Core
open FSharp.Data.JsonSchema.OpenApi
open FSharp.Json
// open FSharpPlus
// open FsHttp
// open FsPublicSuffix
open HCollections
// open Iana
// open IriTools
// open Json.More
// open Json.Path
// open Json.Pointer
// open JsonStructure
// open Meziantou.Framework
// open MimeDetective
// open Nager.PublicSuffix
// open Nager.PublicSuffix.Models
// open Nager.PublicSuffix.RuleParsers
// open Nager.PublicSuffix.RuleProviders
// open Newtonsoft.Json
// open Newtonsoft.Json.Linq
// open NJsonSchema
// open NLanguageTag
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
// open RDFSharp.Model
open ShapeSifter
open ShapeSifter.Patterns
open System
open System.Collections
// open System.Collections.Concurrent
// open System.ComponentModel.DataAnnotations
// open System.Diagnostics
// open System.Globalization
open System.IO
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
// open System.Threading
// open System.Threading.Tasks
// open System.Xml
// open System.Xml.Schema
// open System.Xml.Linq
open System.Xml.XPath
// open Tavis.UriTemplates
open TypeEquality
open TypeShape
open TypeShape.Core
// open VDS.Common.Tries
open VDS.RDF
open WebSharper.Core 
#r "nuget: Esri.ArcGISRuntime, 300.0.0"
open Esri.ArcGISRuntime

open Microsoft.FSharp.Linq.RuntimeHelpers
open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns
open Microsoft.FSharp.Reflection
open Microsoft.VisualBasic.FileIO

type JsonNode = Nodes.JsonNode
type JsonNodeObject = Nodes.JsonObject
type JsonNodeArray = Nodes.JsonArray
type JsonNodeValue = Nodes.JsonValue
module FSharpLiteral = FSharp.Literals.Literal

fsi.AddPrinter<ImmutableDynamicObj>(
    fun dynamicObject ->
        System.Environment.NewLine
        + ImmutableDynamicObj.format dynamicObject
)

type UriSchemes = Iana.RegistryProvider.``Uniform Resource Identifier (URI) Schemes``.``Uniform Resource Identifier (URI) Schemes``
type PublicSuffixes = PublicSuffixList.PublicSuffixProvider
type Mime = Iana.InternetMediaTypeProvider

type foaf = VocabularyProvider<"foaf", "http://xmlns.com/foaf/0.1/", @"D:\http\com\xmlns\foaf\0.1&sol;\text\turtle.ttl">

let memberAccessor = 
    {
        new PocoAccessor<bool> with

            member _.Access<'SourceType>
                (projectedPoco : ProjectedPoco<'SourceType>)
                =

                let source : 'SourceType =
                    projectedPoco.source

                projectedPoco.members
                |> Array.iter (fun memberShape ->
                            memberShape.Accept {
                                new IReadOnlyMemberVisitor<'SourceType, bool> with

                                    member _.Visit<'MemberType>
                                        (memberShape : ReadOnlyMember<'SourceType, 'MemberType>)
                                        =

                                        let memberValue : 'MemberType =
                                            memberShape.Get source

                                        printfn
                                            "%s : %s = %A"
                                            memberShape.Label
                                            typeof<'MemberType>.FullName
                                            memberValue

                                        true
                            } |> ignore

                )

                true
    }

// projectedGraph.tryAccessor memberAccessor

ArcGISRuntimeEnvironment.Initialize()
let StormwaterInfrastructure = Mapping.ArcGISMapImageLayer(new Uri "https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer")
StormwaterInfrastructure.LoadTablesAndLayersAsync() |> Async.AwaitTask |> Async.RunSynchronously
let value = StormwaterInfrastructure
let quote = CodeQuotation.lift value

let projection = quote.projected
projection.tryAccessor memberAccessor

(*
let inline (?)
    (valueObject : ImmutableDynamicObj option)
    (key : string)
    : 'ValueType option
    =

    match valueObject.Value.TryGetValue key with
    | Some value when not (isNull value) ->
        Some(unbox<'ValueType> value)

    | _ -> None
// valueObject.tryDynamicObject.Value |> ImmutableDynamicObj.format |> String.Clipboard.clip
let name :obj option = valueObject.tryDynamicObject?ServiceInfo
name.Value.GetType()
*)

type JavascriptBuilder() =

    let propertyName (propertyInfo: PropertyInfo) =
        propertyInfo.GetCustomAttributes(typeof<DomNameAttribute>, true)
        |> Seq.tryPick (function
            | :? DomNameAttribute as attribute ->
                Some attribute.OfficialName
            | _ ->
                None
        )
        |> Option.defaultValue propertyInfo.Name

    let rec  expression
        (variables: Map<Var, JavaScript.Syntax.Id>)
        (quotation: Expr)
        : JavaScript.Syntax.Expression =

        match quotation with

        // fun element -> ...
        | Lambda(variable, body) ->

            let identifier =
                JavaScript.Syntax.Id.New variable.Name

            let variables =
                variables.Add(variable, identifier)

            let body =
                expression variables body

            JavaScript.Syntax.Lambda(
                None,
                [ identifier ],
                [
                    JavaScript.Syntax.Return(
                        Some body
                    )
                ],
                true
            )

        // element
        | Var variable ->

            match variables.TryFind variable with
            | Some identifier ->
                JavaScript.Syntax.Var identifier

            | None ->
                failwith $"Unknown variable: {variable.Name}"

        // element.OuterHtml
        | PropertyGet(Some target, propertyInfo, []) ->

            let target =
                expression variables target

            let name =
                propertyName propertyInfo

            JavaScript.Syntax.Binary(
                target,
                JavaScript.Syntax.BinaryOperator.``.``,
                JavaScript.Syntax.Constant(
                    JavaScript.Syntax.Literal.String name
                )
            )

        // "hello"
        | Value(:? string as value, _) ->

            JavaScript.Syntax.Constant(
                JavaScript.Syntax.Literal.String value
            )

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

            JavaScript.Syntax.Constant(
                JavaScript.Syntax.Literal.Null
            )

        | unsupported ->
            failwith
                $"""Unsupported F# quotation: {unsupported}"""

    let  compileQuotation (quotation: Expr) =

        let quotation =
            match quotation with

            // javascript { return expression }
            //
            // The quoted computation expression contains the
            // generated call to JavascriptBuilder.Return.
            | Call(_, methodInfo, [ value ])
                when methodInfo.Name = "Return" ->
                    value

            | expression ->
                expression

        quotation
        |> expression Map.empty
        |> JavaScript.Writer.ExpressionToString
            JavaScript.Preferences.Readable
    member _.Return(value: 'T) : 'T =
        value

    member _.Quote(expression: Expr<'T>) =
        expression

    member _.Run(expression: Expr<'T>)  =
        {
            javascriptString = compileQuotation expression
        }

let javascript = JavascriptBuilder()

let javascriptLiteral = 
    javascript {
        return fun (element: IElement) ->
            element.OuterHtml
    }

let CommandPrompt = Fli.Domain.Shells.CMD
let WindowsPowershell = Fli.Domain.Shells.PS
let PowershellCore = Fli.Domain.Shells.PWSH
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
    static member op_Implicit (key:SeleniumKey) = 
        match key with 
        
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
        member this.press = canopy.classic.press this

type EdgeBrowser = 
    {
        driver:RemoteWebDriver
        devtool:CdpBrowser
    }
    static member op_Implicit(edge:EdgeBrowser) = edge.driver
    static member op_Implicit(edge:EdgeBrowser) : IWebDriver = edge.driver :> IWebDriver
    static member op_Implicit(edge:EdgeBrowser) = edge.devtool
    static member exeFile = FileInfo $"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe" 
    static member driverFile = FileInfo $"D:\Program_Files\Microsoft\Edge\Version156.0.4314.42\msedgedriver.exe"
    static member dataDirectory = DirectoryInfo $"D:\Program_Files\Microsoft\Edge\data_dir"
    static member startBrowserCommand = $"& '{EdgeBrowser.exeFile.FullName}' --remote-debugging-port=9222 --user-data-dir={EdgeBrowser.dataDirectory.FullName}"
    static member startDriverCommand = $"& '{EdgeBrowser.driverFile.FullName}' --port=9515"

    static member Connect() =
            let driver = 
                        let edgeOptions = EdgeOptions()
                        edgeOptions.DebuggerAddress <- "127.0.0.1:9222"
                        new RemoteWebDriver(Uri("http://127.0.0.1:9515"), edgeOptions)

            let edge = 
                {
                            driver = driver.SwitchTo().Window(driver.CurrentWindowHandle) :?> RemoteWebDriver
                            devtool = Puppeteer.ConnectAsync(ConnectOptions(BrowserURL = "http://127.0.0.1:9222")).GetAwaiter().GetResult() :?> CdpBrowser
                }
            canopy.classic.browser <- edge.driver
            edge

    member this.driverTab() =  this.driver.SwitchTo().Window(this.driver.CurrentWindowHandle) |> ignore
    member this.driverTab (tabIndex:int) = 
        if tabIndex < 0 then  
            canopy.classic.closeTab (abs tabIndex)
        else
            canopy.classic.switchToTab tabIndex
    member this.driverIrl = canopy.classic.currentUrl () |> Url.Parse |> Irl.ofUrl
    member this.driverTitle = canopy.classic.title ()
    member this.reload() =  
        this.driverTab()
        canopy.classic.reload()
    member this.navigate(navigation:canopy.parallell.functions.Navigate) = 
        this.driverTab()
        canopy.classic.navigate navigation
    member this.back = this.navigate canopy.parallell.functions.Navigate.Back
    member this.forward = this.navigate canopy.parallell.functions.Navigate.Forward
    member this.irl (irl:Irl) = 
        this.driverTab()
        canopy.classic.url irl
    
    member this.write (text:string) = 
        fun (selector:Selector) -> canopy.classic.(<<) selector.Css  text
    member this.read (selector:Selector) = canopy.classic.read selector.Css
    member this.drag (fromSelector:Selector) =
        fun (ontoSelector:Selector) -> canopy.classic.drag fromSelector.Css ontoSelector.Css this
    member this.click (text:string) = canopy.classic.click text
    member this.click (selector:Selector) = canopy.classic.click selector.Css
    member this.click (element:IWebElement) = canopy.classic.click element
    member this.rightClick (text:string) = canopy.classic.rightClick text
    member this.rightClick (selector:Selector) = canopy.classic.rightClick selector.Css
    member this.rightClick (element:IWebElement) = canopy.classic.rightClick element
    member this.doubleClick (text:string) = canopy.classic.doubleClick text
    member this.doubleClick (selector:Selector) = canopy.classic.doubleClick selector.Css
    member this.doubleClick (element:IWebElement) = canopy.classic.doubleClick element
    member this.ctrlClick (text:string) = canopy.classic.ctrlClick text
    member this.ctrlClick (selector:Selector) = canopy.classic.ctrlClick selector.Css
    member this.ctrlClick (element:IWebElement) = canopy.classic.ctrlClick element
    member this.shiftClick (text:string) = canopy.classic.shiftClick text
    member this.shiftClick (selector:Selector) = canopy.classic.shiftClick selector.Css
    member this.shiftClick (element:IWebElement) = canopy.classic.shiftClick element
    member this.screenshot (file:FileInfo) = canopy.classic.screenshot file.DirectoryName file.Name
    member this.check (text:string) = canopy.classic.check text
    member this.check (selector:Selector) = canopy.classic.check selector.Css
    member this.check (element:IWebElement) = canopy.classic.check element
    member this.uncheck (text:string) = canopy.classic.uncheck text
    member this.uncheck (selector:Selector) = canopy.classic.uncheck selector.Css
    member this.uncheck (element:IWebElement) = canopy.classic.uncheck element
    member this.hover (text:string) = canopy.classic.hover text
    member this.hover (selector:Selector) = canopy.classic.hover selector.Css
    member this.element (text:string) = canopy.classic.element text
    member this.element (selector:Selector) = canopy.classic.element selector.Css
    member this.elementWithText (text:string) (selector:Selector) = canopy.classic.elementWithText selector.Css text
    member this.someElement (text:string) = canopy.classic.someElement text
    member this.someElement (selector:Selector) = canopy.classic.someElement selector.Css
    member this.someElementWithin (text:string) = canopy.classic.someElementWithin text
    member this.someElementWithin (selector:Selector) = canopy.classic.someElementWithin selector.Css
    member this.parent (webElement:IWebElement) = canopy.classic.parent webElement
    member this.someParent (webElement:IWebElement) = canopy.classic.someParent webElement
    member this.elements (text:string) = canopy.classic.elements text
    member this.elements (selector:Selector) = canopy.classic.elements selector.Css
    member this.elementsWithin (text:string) = canopy.classic.elementsWithin text
    member this.elementsWithin (selector:Selector) = canopy.classic.elementsWithin selector.Css
    member this.elementsWithText (text:string) (selector:Selector) = canopy.classic.elementsWithText selector.Css text
    member this.nth (ordinal:int) = 
        fun (selector:Selector) -> canopy.classic.nth ordinal selector.Css
    member this.first (text:string) = canopy.classic.first text
    member this.first (selector:Selector) = canopy.classic.first selector.Css
    member this.last (text:string) = canopy.classic.last text
    member this.last (selector:Selector) = canopy.classic.last selector.Css
    member this.elementText (selector:Selector) = canopy.classic.fastTextFromCSS selector.Css
    member this.resize(x:int) = 
        fun (y:int) -> canopy.classic.resize(x, y)
    member this.rotate() = canopy.classic.rotate()
    member this.js (literal:JavascriptLiteral) = (this.driver :> IJavaScriptExecutor).ExecuteScript(literal.javascriptString ) 
    member this.sleep (seconds:int)= canopy.classic.sleep seconds
    member this.highlight (selector:Selector) = canopy.classic.highlight selector.Css
    member this.waitFor (predicate : unit -> bool) = canopy.classic.waitFor predicate
    member this.waitFor (explanation:string) =
        fun (predicate : unit -> bool) -> canopy.classic.waitFor2 explanation predicate
    member this.waitFor (selector:Selector) = canopy.classic.waitForElement selector.Css
    member this.clear (selector:Selector) = canopy.classic.clear selector.Css
    member this.press (key:SeleniumKey) = canopy.classic.press key 
    member this.alert = canopy.classic.alert()
    member this.acceptAlert = canopy.classic.acceptAlert()
    member this.dismissAlert = canopy.classic.dismissAlert()
    member this.pin (direction:types.direction) = canopy.classic.pin direction
    member this.positionBrowser (leftPercentage:int) = 
        fun (topPercentage:int) ->
            fun (widthPercentage:int) ->
                fun (heightPercentage:int) -> canopy.classic.positionBrowser leftPercentage topPercentage widthPercentage heightPercentage
    member this.css (selector:Selector) = canopy.classic.css selector.Css
    member this.xpath(xpath:XPathExpression) = canopy.classic.xpath xpath.Expression
    member this.jquery jquerySelector = canopy.classic.jquery jquerySelector
    member this.label (label:string) = canopy.classic.label label
    member this.text (text:string) = canopy.classic.text text
    member this.value = canopy.classic.value 

type String with
    member this.com = PublicSuffixes.com.tld.domain this
    member this.org = PublicSuffixes.org.tld.domain this
    member this.gov = PublicSuffixes.gov.tld.domain this
    member this.net = PublicSuffixes.net.tld.domain this

type FSharp.Data.HtmlDocument with 
    static member ofWebDriver (webDriver:RemoteWebDriver) = HtmlDocument.Parse webDriver.PageSource
type AngleSharp.Html.Dom.IHtmlDocument with 
    static member ofWebDriver (webDriver:RemoteWebDriver) = HtmlParser().ParseDocument(File.ReadAllText(webDriver.PageSource))

type EdgeBrowser with 
    member this.FSharpHtmlDocument = FSharp.Data.HtmlDocument.ofWebDriver this.driver
    member this.AngleSharpHtmlDocument = AngleSharp.Html.Dom.IHtmlDocument.ofWebDriver this.driver
    member this.https (domain:Domain) = UriSchemes.https.site domain |> this.irl
    member this.http (domain:Domain) = UriSchemes.http.site domain |> this.irl
    member this.www (label:string) =
        fun (suffix:PublicSuffix) -> 
            {
                topLevelDomain = suffix
                secondLevelDomain = label
                subdomainLabels = [ "www" ] 
            }
            |> UriSchemes.https.site
            |> this.irl
    member this.www (domain:Domain) =
            { domain with 
                subdomainLabels = [ "www" ] 
            }
            |> UriSchemes.https.site
            |> this.irl
    member this.google (searchQuery:string) = 
        let queryString = FSharpRecord.Parse {|
            q = searchQuery 
            udm = 14
            |} 
        UriSchemes.https.host "www" "google".com / "search"  =? queryString |> this.irl
    member this.googleImages (searchQuery:string) = 
        let queryString = 
            FSharpRecord.Parse {| 
                q = searchQuery 
                udm = 14 
                tbm = "isch"
                |} 
        UriSchemes.https.host "www" "google".com / "search"  =? queryString |> this.irl
    member this.googleNews (searchQuery:string) = 
        let queryString = 
            FSharpRecord.Parse {| 
                q = searchQuery 
                udm = 14 
                tbm = "nws"
                |} 
        UriSchemes.https.host "www" "google".com / "search"  =? queryString |> this.irl

let edge = EdgeBrowser.Connect()

(*

edge.google "test search"

edge.driverTab()
let google (searchQuery:string) = UriSchemes.https.host "www" "google".com / "search"  =? [ "q", searchQuery ]
edge.https "google".com
edge.www "youtube".com

edge.https <| "interraster" .+ "leoncountyfl".gov
*)

// valueObject.tryDynamicObject
(*
let testRecord = FSharpRecord.Parse {|
    MapServer = StormwaterInfrastructure
    name = "Alice"
    active = true
    scores = [1; 2; 3]
    address =
        {|
            city = "Atlanta"
            zip = 30301
        |}
|}
let testJsonString = testRecord.jsonString
testJsonString.clip

Mime.application.json.mime.registryIri
let mimeDefinitions = 
    let definitions = new Definitions.ExhaustiveBuilder()
    definitions.UsageType <- Definitions.Licensing.UsageType.PersonalNonCommercial
    definitions.Build()
    |> Seq.toArray

type InternetMediaType with 
    member this.contentDefinitions = mimeDefinitions |> Array.filter (fun definition -> definition.File.MimeType.ToLowerInvariant() = this.contentType )

let mimeInspector = 
        let inspector = new ContentInspectorBuilder()
        inspector.Definitions <- mimeDefinitions
        inspector.Build()

let http = UriSchemes.http
let https = UriSchemes.https

let path =
    @"D:\https\com\github\eristocrates\ipa\fs\DoxAletheia\src\DoxAletheia.Runtime\bin\Release\net10.0\Newtonsoft.Json.dll"

https.host "youtube".com
"www" .+ "youtube".com

//(child :?> JProperty).Name
let schemaSite = https.site "schema".org 
let schemaVocabulary = RdfVocabulary.PREFIX("schemas", schemaSite.identity + "/") 
// schemaVocabulary.localTurtleReference.clip
let jsonldVocabulary = RdfVocabulary.PREFIX("jsonld", "http://www.w3.org/ns/json-ld#")
// jsonldVocabulary.localTurtleReference.clip

let uriSchemes =
    Iana.``Uniform Resource Identifier (URI) Schemes``

type rdf = VocabularyProvider<"rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#", @"D:\http\org\w3\www\1999\02\22-rdf-syntax-ns&num;\text\turtle.ttl">
type xsd = VocabularyProvider<"xsd", "http://www.w3.org/2001/XMLSchema#", @"D:\http\org\w3\www\2001\XMLSchema&num;\text\turtle.ttl">
type rdfs = VocabularyProvider<"rdfs", "http://www.w3.org/2000/01/rdf-schema#", @"D:\http\org\w3\www\2000\01\rdf-schema&num;\text\turtle.ttl">
type rdfa = VocabularyProvider<"rdfa", "http://www.w3.org/ns/rdfa#", @"D:\http\org\w3\www\ns\rdfa&num;\text\turtle.ttl">
type owl = VocabularyProvider<"owl", "http://www.w3.org/2002/07/owl#", @"D:\http\org\w3\www\2002\07\owl&num;\text\turtle.ttl">
type void_ = VocabularyProvider<"void", "http://rdfs.org/ns/void#", @"D:\http\org\rdfs\ns\void&num;\text\turtle.ttl">
type skos = VocabularyProvider<"skos", "http://www.w3.org/2004/02/skos/core#", @"D:\http\org\w3\www\2004\02\skos\core&num;\text\turtle.ttl">
type foaf = VocabularyProvider<"foaf", "http://xmlns.com/foaf/0.1/", @"D:\http\com\xmlns\foaf\0.1&sol;\text\turtle.ttl">
type schemas = VocabularyProvider<"schemas", "https://schema.org/", @"D:\https\org\schema&sol;\text\turtle.ttl">
type skosxl = VocabularyProvider<"skosxl", "http://www.w3.org/2008/05/skos-xl#", @"D:\http\org\w3\www\2008\05\skos-xl&num;\text\turtle.ttl">
type dc = VocabularyProvider<"dc", "http://purl.org/dc/elements/1.1/", @"D:\http\org\purl\dc\elements\1.1&sol;\text\turtle.ttl">
type dcat = VocabularyProvider<"dcat", "http://www.w3.org/ns/dcat#", @"D:\http\org\w3\www\ns\dcat&num;\text\turtle.ttl">
type dcterms = VocabularyProvider<"dcterms", "http://purl.org/dc/terms/", @"D:\http\org\purl\dc\terms&sol;\text\turtle.ttl">
type time = VocabularyProvider<"time", "http://www.w3.org/2006/time#", @"D:\http\org\w3\www\2006\time&num;\text\turtle.ttl">
type org = VocabularyProvider<"org", "http://www.w3.org/ns/org#", @"D:\http\org\w3\www\ns\org&num;\text\turtle.ttl">
type jsonld = VocabularyProvider<"jsonld", "http://www.w3.org/ns/json-ld#", @"D:\http\org\w3\www\ns\json-ld&num;\text\turtle.ttl">

module governmentjobs =
    let ApplicationsSystemsAnalystI = Iri.ref  "https://www.governmentjobs.com/careers/leoncountyfl/classspecs/1183950" |> foaf.NamedIndividual_.Document

module myfuelmaster =
    let https = Iri.ref "https://myfuelmaster.com/" |> foaf.NamedIndividual_.Document
    let desktop_support_technician = Iri.ref "https://myfuelmaster.com/job/desktop-support-technician-8" |>foaf.NamedIndividual_.Document

type RdfVocabulary with 
    static member ofRDFNamespace (rdfNamespace:RDFNamespace) = RdfVocabulary.PREFIX(rdfNamespace.NamespacePrefix, rdfNamespace.NamespaceUri.OriginalString)
    static member personal (namespacePrefix:string) = 
        RDFNamespaceRegister.ensurePrefix(namespacePrefix, $"https://eristocrates.dev/ontology/{namespacePrefix}/")
        |> RdfVocabulary.ofRDFNamespace
    static member ensurePrefix((namespacePrefix:string), (namespaceName:string)) = RDFNamespaceRegister.ensurePrefix(namespacePrefix, namespaceName) |> RdfVocabulary.ofRDFNamespace

module wellsfargo =
    let _namespace = RdfVocabulary.personal "wellsfargo"
    let everydayChecking = _namespace.curie "everydayChecking"
    let platinumCard = _namespace.curie "platinumCard"
    let installmentLoans = _namespace.curie "installmentLoans"
    let wellsFargoRewards = _namespace.curie "wellsFargoRewards"

    module checking =
        let everyday = Iri.ref "https://www.wellsfargo.com/checking/everyday"
module usaa =
    let _namespace = RdfVocabulary.personal "usaa"
    let checking = _namespace.curie "checking"
    let platinumVisa = _namespace.curie "platinumVisa"
    let usaaSavings = _namespace.curie "usaaSavings"

    module banking =

        let checking = Iri.ref "https://www.usaa.com/banking/checking"
        let savings = Iri.ref "https://www.usaa.com/banking/savings"
module crew =
    let checkingAccountDisclosure = Iri.ref "https://www.trycrew.com/pdfjs/web/viewer?file=%2Fdocs%2Fdeposit-agreement.pdf#h.g82ej3s9bgif"

module gov =
    module leoncountyfl =
        module cms =
            let OfficeofInformationTechnology = Iri.ref "https://cms.leoncountyfl.gov/Government/Departments/Information-and-Technology/Office-of-Information-Technology" |> foaf.NamedIndividual_.Document
module leinfo =
    let _namespace = RdfVocabulary.ensurePrefix ("lei", "http://lei.info/" )
    let _l1 = RdfVocabulary.ensurePrefix ("leiL1", "http://lei.info/voc/l1/" )
    let WellsFargoNationalBank = _namespace.curie "KB1H1DSPRFMYMCUFXT09"
    let USAAFederalSavingsBank = _namespace.curie "C5654JQHZUHN0772B561"
    let BangorSavingsBank = _namespace.curie "549300JEBULFT3BSU682"
module dbug =
    let _namespace = RdfVocabulary.personal "dbug"
    let testIndividual = _namespace.curie "testIndividual" |> NamedIndividualIri |> Individual
    let Bob = _namespace.curie "Bob" |> foaf.NamedIndividual_.Person
    let Alice = _namespace.curie "Alice" |> foaf.NamedIndividual_.Person

module commonplace =
    let _namespace = RdfVocabulary.personal "commonplace"
    let _ontology = OntologyBuilder _namespace.namespaceIri
    let eristocrates = _namespace.curie "eristocrates" |> foaf.NamedIndividual_.Person
    let syrislove = _namespace.curie "syrislove" |> foaf.NamedIndividual_.Person
    let WellsFargoEverydayChecking = _namespace.curie "WellsFargoEverydayChecking"
    let WellsFargoEverydayCheckingAccount = _namespace.curie "WellsFargoEverydayCheckingAccount"
    let WellsFargoEverydayCheckingAccountCurrentBalance = _namespace.curie "WellsFargoEverydayCheckingAccountCurrentBalance"
    let WellsFargoEverydayCheckingAccountAvailableBalance = _namespace.curie "WellsFargoEverydayCheckingAccountAvailableBalance"
    let USAAClassicChecking = _namespace.curie "USAAClassicChecking"
    let USAAClassicCheckingAccount = _namespace.curie "USAAClassicCheckingAccount"
    let USAAClassicCheckingAccountCurrentBalance = _namespace.curie "USAAClassicCheckingAccountCurrentBalance"
    let USAAClassicCheckingAccountAvailableBalance = _namespace.curie "USAAClassicCheckingAccountAvailableBalance"
    let USAAClassicSavings = _namespace.curie "USAAClassicSavings"
    let USAAClassicSavingsAccount = _namespace.curie "USAAClassicSavingsAccount"
    let USAAClassicSavingsAccountCurrentBalance = _namespace.curie "USAAClassicSavingsAccountCurrentBalance"
    let USAAClassicSavingsAccountAvailableBalance = _namespace.curie "USAAClassicSavingsAccountAvailableBalance"
    let CrewFinanceChecking = _namespace.curie "CrewFinanceChecking"
    let CrewFinanceCheckingAccount = _namespace.curie "CrewFinanceCheckingAccount"
    let CrewFinanceCheckingAccountCurrentBalance = _namespace.curie "CrewFinanceCheckingAccountCurrentBalance"
    let CrewFinanceCheckingAccountAvailableBalance = _namespace.curie "CrewFinanceCheckingAccountAvailableBalance"
    let hasCurrentBalance = _namespace.curie "hasCurrentBalance"
    let hasAvailableBalance = _namespace.curie "hasAvailableBalance"
    let CurrentBalance = _namespace.curie "CurrentBalance"
    let AvailableBalance = _namespace.curie "AvailableBalance"

let a = rdf.``type``

let inline (-//)
    (curSubject: ^Subject when ^Subject: (member asSubject: NormativeSubject))
    (predicateObjects: PredicateObject list)
    =
    predicateObjects
    |> List.map (fun predicateObject -> curSubject.asSubject --/ predicateObject)

let (.@) (lexicalForm: string) (languageTag: LanguageTag) =
    { lexicalForm = lexicalForm
      languageTag = languageTag
      baseDirection = None }

let (@@) (lexicalForm: string) (languageTag: LanguageTag, baseDirection: InitialTextDirection) =
    { lexicalForm = lexicalForm
      languageTag = languageTag
      baseDirection = Some baseDirection }

let foafDocumentTriples =
    [ governmentjobs.ApplicationsSystemsAnalystI.Iri
      gov.leoncountyfl.cms.OfficeofInformationTechnology.Iri
      myfuelmaster.desktop_support_technician.Iri
      myfuelmaster.https.Iri ]
    -+/ a /-> foaf.Document

let foafDocumentAssertions =
    foaf.Document.Class
    |> ClassAssertion
        [ governmentjobs.ApplicationsSystemsAnalystI.Individual
          gov.leoncountyfl.cms.OfficeofInformationTechnology.Individual
          myfuelmaster.desktop_support_technician.Individual
          myfuelmaster.https.Individual ]

let foafPersonTriples =
    [ commonplace.eristocrates.Iri; commonplace.syrislove.Iri ]
    -+/ a /-> foaf.Person

let foafPersonAssertions =
    foaf.Person.Class
    |> ClassAssertion [ commonplace.eristocrates.Individual; commonplace.syrislove.Individual ]

let eristocratesTriples =
    commonplace.eristocrates.Iri
    -// [ foaf.firstName /-> myFirstName
          foaf.familyName /-> myLastName
          foaf.lastName /-> myLastName
          foaf.surname /-> myLastName
          foaf.age /-> myBirthday.currentAge
          foaf.nick /-> myUsername
          foaf.knows /-> commonplace.syrislove
          // foaf.workInfoHomepage/-> governmentjobs.ApplicationsSystemsAnalystI
          // foaf.workplaceHomepage/-> gov.leoncountyfl.cms.OfficeofInformationTechnology
          ]

let eristocratesAssertions =
    List.concat
        [ commonplace.eristocrates.Facts
              [ foaf.firstName.Fact myFirstName
                foaf.familyName.Fact myLastName
                foaf.lastName.Fact myLastName
                foaf.surname.Fact myLastName
                foaf.age.Fact myBirthday.currentAge
                foaf.nick.Fact myUsername ]
          commonplace.eristocrates.Facts
              [ foaf.knows.Fact commonplace.syrislove
                // foaf.workInfoHomepage.Fact  governmentjobs.ApplicationsSystemsAnalystI
                // foaf.workplaceHomepage.Fact  gov.leoncountyfl.cms.OfficeofInformationTechnology
                ] ]

let syrisTriples =
    commonplace.syrislove.Iri
    -// [

          foaf.firstName /-> syrisFirstName
          foaf.familyName /-> syrisLastName
          foaf.lastName /-> syrisLastName
          foaf.surname /-> syrisLastName
          foaf.age /-> syrisBirthday.currentAge
          foaf.nick /-> syrisUsername
          foaf.knows /-> commonplace.eristocrates
          // foaf.workInfoHomepage/->myfuelmaster.desktop_support_technician
          // foaf.workplaceHomepage/->myfuelmaster.https
          ]

let syrisAssertions =

    List.concat
        [ commonplace.syrislove.Facts
              [ foaf.firstName.Fact syrisFirstName
                foaf.familyName.Fact syrisLastName
                foaf.lastName.Fact syrisLastName
                foaf.surname.Fact syrisLastName
                foaf.age.Fact syrisBirthday.currentAge
                foaf.nick.Fact syrisUsername ]
          commonplace.syrislove.Facts
              [ foaf.knows.Fact commonplace.eristocrates
                // foaf.workInfoHomepage.Fact  myfuelmaster.desktop_support_technician
                // foaf.workplaceHomepage.Fact  myfuelmaster.https
                ] ]

let ontology =
    OntologyBuilder commonplace._namespace.namespaceIri {

        // yield foafDocumentTriples
        yield foafPersonTriples
        yield eristocratesTriples
        yield syrisTriples
        // yield foafDocumentAssertions
        yield foafPersonAssertions
        yield eristocratesAssertions
        yield syrisAssertions
    }

let ntriples = NTriples.ntriplesDoc ontology

let rdfGraph = RDFGraph.ofNTriples ntriples

type RDFGraph with
    member this.ToTurtle(turtlePath: string) =
        this.ToFileAsync(RDFModelEnums.RDFFormats.Turtle, turtlePath)
        |> Async.AwaitTask
        |> Async.RunSynchronously

rdfGraph.ToTurtle "D:\https\com\github\eristocrates\ipa\scratch\scratch.ttl"

File.WriteAllText(
    "D:\https\com\github\eristocrates\ipa\scratch\scratch.owl",
    LitXml.ElementBuilder.writeToString (Owl.Xml.Ontology ontology)
)

let OWLOntology = OWLSharp.Ontology.OWLOntology.ofOntology ontology
OWLOntology.AssertionAxioms |> Seq.head :?> OWLSharp.Ontology.OWLClassAssertion |> _.IndividualExpression

// Attach to our existing Edge instance.

*)

