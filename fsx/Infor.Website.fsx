// TODO use dynamic operator for namespacenames for adhoc local names

#time on
fsi.PrintLength <- 10
fsi.PrintSize <- 300
// fsi.ShowDeclarationValues <- false
#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "SharedKernel.dll"
#r "StringModule.dll"
#r "Internet.dll"
#r "TopLevelDomain.dll"
#r "IanaScheme.dll"
#r "ResourceIdentification.dll"
#r "ResourceDescription.dll"
#r "Iana.dll"
#r "IanaMime.dll"
#r "NetworkMonitor.dll"
#r "Turtle.dll"
#r @"DataTierApplication.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "Ast.fsx"
open SharedKernel
open StringModule
open DataTierApplication
open Internet
open ResourceIdentification
open ResourceDescription
open Turtle
open Iana
open NetworkMonitor

#load @"C:\Secret\InforSecrets.fsx"
#load @"C:\Secret\EsriSecrets.fsx"
#load @"C:\Secret\ProjectDoxSecrets.fsx"
#load @".paket/load/main.group.fsx"

module FSharpLiteral = FSharp.Literals.Literal

// #r "nuget: Microsoft.SqlServer.DacFx"
open AW.Identifiers
open BrowserApi.Dom
open BrowserApi.Css
open BrowserApi.Css.Authoring
open CaseConverter
open Fabulous.AST
open Fantomas.Core
open FolkerKinzel.MimeTypes
open FsExcel
open FSharp.Collections.ParallelSeq
open FSharp.Data
open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql
open FSharp.Text.RegexExtensions
open FSharp.Text.RegexProvider
open Humanizer
open IriTools
open ktsu.Semantics.Paths
open LSL.DataUri
open Meziantou.Framework
open Microsoft.SqlServer.Dac
open Microsoft.SqlServer.Dac.Model
open PuppeteerSharp
open BrowserApi
open PuppeteerSharp.Cdp
open RDFSharp.Model
open System
open System.IO
open System.Linq
open System.Text
open System.Text.RegularExpressions
open System.Threading
open System.Threading.Tasks
open System.Web
open Tavis.UriTemplates
open TextCopy
open Universal.Common
open VDS.RDF
open VDS.RDF.Parsing
open FSharp.Text.RegexProvider
open FSharp.Text.RegexExtensions
open PuppeteerSharp.Input

type CdpFramedElement = {
    frame: CdpFrame
    handle: CdpElementHandle
} with

    member this.realmElement = CdpRealm this.frame |> this.handle.RealmElement
    member this.realmElements = CdpRealm this.frame |> this.handle.RealmElements

// TODO move to relevant modules
type BrowserApi.Dom.NodeList with
    member this.asElements =
        Array.init (int this.Length) (fun index ->
            this[uint32 index].Handle
            |> BrowserApiReflection.fromHandle<BrowserApi.Dom.Element>)
module String =
    let substringAfter (subString: string) (superString: string) = superString[subString.Length ..]
type Clipboard with
    member this.clip(text: string) = this.SetText text
    member this.clip(lines: string array) =
        lines |> String.concat "\n" |> this.SetText
type MouseButton with
    member this.Click(handle: CdpElementHandle) =
        let options = new ClickOptions()
        options.Button <- this
        handle.ClickAsync(options).await
    member this.Click(framedElement: CdpFramedElement) = this.Click framedElement.handle
type CdpElementHandle with
    member this.locator = this.AsLocator()

type CdpPage with
    member this.QuerySelectorAllFrames(selector: Selector) =
        this.frames
        |> Array.collect (fun frame ->
            frame.QuerySelectorAllAsync(selector).await
            |> Array.map (fun ielementhandle -> {
                frame = frame
                handle = ielementhandle :?> CdpElementHandle
            }))
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

    member this.QuerySelectorAllFrames(selector: Selector) =
        this.frames
        |> Array.collect (fun frame ->
            frame.QuerySelectorAllAsync(selector).await
            |> Array.map (fun ielementhandle -> {
                frame = frame
                handle = ielementhandle :?> CdpElementHandle
            }))
    member this.tryFindFrameId(frameId: string) =
        this.frames |> Array.tryFind (fun frame -> frame.Id = frameId)
    member this.tryFindFrameName(frameName: string) =
        this.frames |> Array.tryFind (fun frame -> frame.Name = frameName)
    member this.findFrameId(frameId: string) =
        this.tryFindFrameId frameId |> Option.get
    member this.findFrameName(frameName: string) =
        this.tryFindFrameName frameName |> Option.get
    member this.Realm = CdpRealm this

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

module gov =
    let topLevelDomain = TopLevelDomain.gov
    module leoncountyfl =
        let host = topLevelDomain .+ "leoncountyfl"
        let site = IanaScheme.https ..// host
        [<RequireQualifiedAccess>]
        type Environment =
            | test
            | prod

            member this.asString = this.ToString()
            member this.host = "infor" + this.asString
            member this.database =
                match this with
                | Environment.test -> "test_operations"
                | Environment.prod -> "operations"
        let environment = Environment.test
        module inforenvironment =
            let host = site .+ environment.host |> _.host
            let site = IanaScheme.https ..// host
            let page = site / environment.database

module InforFrame =
    let menuAndView = "menuAndView"
    let _Task_Tab_Content1 = "_Task_Tab_Content1"
    let hansenView = "hansenView"
    let _Task_Tab_Content0 = "_Task_Tab_Content0"
    let viewTab = "viewTab"
    let cblock = "cblock"
    let downloadFrame = "downloadFrame"
    let deviceFrame = "deviceFrame"
    let printFrame = "printFrame"

let responses = new ResizeArray<CdpHttpResponse>()

let downloadConfiguration = {
    shouldDownload =
        fun (response: CdpHttpResponse) ->
            match response.mimeType, response.iriref.tryDotExtension with
            | _, Some ".json"
            | _, Some ".jsonhtml"
            | _, Some ".xml" -> true

            | Some mimeType, _ ->
                match mimeType.MediaType, mimeType.SubType with
                | "application", "json"
                | "application", "xml" -> true
                | _, _ -> false
            | _, _ -> false

    download =
        fun (response: CdpHttpResponse) ->
            match response.Text() with
            | Some text ->
                let maybeMime =
                    response.mimeType
                    |> Option.map (fun mime -> mime.contentType + mime.dotExtension)
                printf "\u001b[2K\r%s\t %s\t %s\t" response.iriref.Origin response.iriref.PathQueryFragment (defaultArg maybeMime String.Empty)
                responses.Add response
                true
            (*
                response.iriref.NamespaceOrigin

                Directory.CreateDirectory(Path.GetDirectoryName response.iriref.localReference)
                |> ignore
                File.WriteAllText(response.iriref.localReference, text)
                true
                *)
            | None -> false
}

let chrome = CdpBrowser.Connect()

let networkMonitor = CdpNetworkMonitor.Create(chrome, downloadConfiguration).Result

let tab =
    let maybeTab =
        chrome.tabs
        |> Array.tryFind (fun tab -> tab.iriref.Origin = gov.leoncountyfl.inforenvironment.site.iriref.Origin)
    match maybeTab with
    | Some tab -> tab
    | None -> chrome.tabs |> Array.last

networkMonitor.monitorPage tab
tab.BringToFrontAsync().await
(*

let menuAndView = tab.frames |> Array.find (fun frame -> frame.Name = "menuAndView")
let hansenView = menuAndView.frames |> Array.find (fun frame -> frame.Name = "hansenView")
let _Task_Tab_Content1 = hansenView.frames |> Array.find (fun frame -> frame.Name = "_Task_Tab_Content1")
let viewTab =
    _Task_Tab_Content1.frames
    |> Array.find (fun frame -> frame.Name = "viewTab")
    |> _.Realm

type DepartmentLinkId = Regex<"^Dept.(?<DepartmentAbbreviation>\w+$)">
type SectionLinkId = Regex<"^Sect.(?<DepartmentAbbreviation>\w+).(?<SectionAbbreviation>\w+$)">
type SectionLinkName = Regex<"(?<DepartmentAbbreviation>[A-Z]+)\s?-\s?(?<SectionName>.+)$">

let departmentSectionLinks =
    viewTab.document.Links.asElements
    |> Array.filter (fun link -> link.Id.StartsWith("Dept"))
    |> Array.map (fun departmentLink ->
        let departmentName = departmentLink.textContent
        let departmentId = DepartmentLinkId().TypedMatch departmentLink.Id
        departmentName,
        departmentId,
        departmentLink.ParentElement.Children.asElements
        |> Array.collect (fun element ->
            element.querySelectorAll El.A
            |> Array.filter (fun elements -> elements.textContent.StartsWith(departmentId.DepartmentAbbreviation.Value))
            |> Array.map (fun sectionLink -> SectionLinkName().TypedMatch sectionLink.textContent, SectionLinkId().TypedMatch sectionLink.Id)))

let codegenDepartmentSections () =
    let departmentName = "departmentName"
    let departmentAbbreviation = "departmentAbbreviation"
    let departmentSections = "departmentSections"
    let sectionName = "sectionName"
    let sectionAbbreviation = "sectionAbbreviation"
    let sectionDepartment = "sectionDepartment"

    Ast.Oak() {
        Ast.AnonymousModule() {
            Ast.Record("InforDepartment") {
                Ast.Field(departmentName, "string")
                Ast.Field(departmentAbbreviation, "string")
            }
            Ast.Record("InforSection") {
                Ast.Field(sectionName, "string")
                Ast.Field(sectionAbbreviation, "string")
                Ast.Field(sectionDepartment, "InforDepartment")
            }
            |> _.toRecursive()

            Ast.Module("Dept") {
                for deptName, deptId, deptSections in departmentSectionLinks do
                    let deptBinder = PrettierNaming.VariableBinder deptName
                    Ast.Module(deptId.DepartmentAbbreviation.Value) {
                        [|
                            Ast.RecordFieldExpr(departmentName, Ast.String deptName)
                            Ast.RecordFieldExpr(departmentAbbreviation, Ast.String deptId.DepartmentAbbreviation.Value)
                        |]
                        |> Ast.RecordExprValue deptName

                        for sectName, sectId in deptSections do
                            [|
                                Ast.RecordFieldExpr(sectionName, Ast.String sectName.SectionName.Value)
                                Ast.RecordFieldExpr(sectionAbbreviation, Ast.String sectId.SectionAbbreviation.Value)
                                Ast.RecordFieldExpr(sectionDepartment, Ast.Constant deptBinder.binding)
                            |]
                            |> Ast.RecordExprValue sectName.SectionName.Value

                    }
            }

        }
    }
    |> Gen.mkOak
    |> Gen.run
// codegenDepartmentSections().clip

let sectionItems =
    departmentLink.ParentElement.Children.asElements
    |> Array.choose (fun liChild ->
        liChild.Children.asElements
        |> Array.tryFind (fun aChild -> aChild.Id.StartsWith("Sect")))
sectionItems.Length
departmentLink.Id[5..]
type Qaid = Regex<pattern= @"(?<ElementDepth>[^_]+)_(?<DisplayName>[^_]+)__(?<ContentKind>\w+$)">
departmentLink.TryAttribute "qaid"
|> Option.map (fun qaid -> Qaid().TypedMatch qaid)
|> Option.get

departmentLinks
|> Array.map (fun link -> $"""{link.Id[5..]} ;{link.OuterHtmlNodes[0].elements[1].innerText}""")
|> String.Clipboard.clip

*)
