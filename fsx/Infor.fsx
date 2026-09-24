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
                | test -> "test_operations"
                | prod -> "operations"
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

module HansenDataDistribution =
    [<Literal>]
    let xmlFilePath =
        @"D:/Surface/Company/Infor/Download_Center/Product/Operations_and_Regulations/Release/Infor_Public_Sector_2025_04_01/IPS_2025_04_01/Deployment Files/MetaData/MetaData.xml"

    let xmlFile = new FileInfo(xmlFilePath)
    type Provider = XmlProvider<UseOriginalNames=true, Sample=xmlFilePath>

module InforProd =
    module Xml =
        let hansenMetadata = HansenDataDistribution.Provider.Load(HansenDataDistribution.xmlFilePath).hansenMetadata

        let productFamilies = hansenMetadata.productFamilies

        let productFamilieByName =
            productFamilies
            |> Array.map (fun productFamily -> productFamily.name, productFamily)
            |> Map.ofArray

        let domainColumns = hansenMetadata.domainColumns

        let domainColumnByName =
            domainColumns
            |> Array.map (fun domainColumn -> domainColumn.name, domainColumn)
            |> Map.ofArray

        let domainColumnByDatabaseName =
            domainColumns
            |> Array.map (fun domainColumn -> domainColumn.databaseName, domainColumn)
            |> Map.ofArray

        let tables = productFamilies |> Array.collect (fun productFamily -> productFamily.tables)

        let tableByName = tables |> Array.map (fun table -> table.name, table) |> Map.ofArray

        let tableByDatabaseName = tables |> Array.map (fun table -> table.databaseName, table) |> Map.ofArray

        let columns = tables |> Array.collect (fun table -> table.columns)

        let columnByName = columns |> Array.map (fun column -> column.name, column) |> Map.ofArray

        let columnByDatabaseName = columns |> Array.map (fun column -> column.databaseName, column) |> Map.ofArray

module Sql =
    type Provider =
        SqlDataProvider<
            IndividualsAmount=1000,
            UseOptionTypes=Common.NullableColumnType.OPTION,
            CaseSensitivityChange=Common.CaseSensitivityChange.ORIGINAL,
            SsdtPath=InforSecrets.Prod.dapac,
            ConnectionString=InforSecrets.Prod.connectionString
         >

    let serverData = Provider.GetDataContext()
    let serverMetadata = Provider.GetReadOnlyDataContext()
    let dataContext = (box serverData) :?> Common.ISqlDataContext

module TSql =
    let DataTierApplication = {
        applicationName = "Infor IPA"
        applicationDescription = "Infor Interoperable Programmatic Automation"
        connectionString = InforSecrets.Prod.connectionString
        dacpacFilePath = InforSecrets.Prod.dapac
        databaseName = InforSecrets.Prod.host
    }
    let Model = DataTierApplication.LoadModel()

let lc_select_all_employeesTable =
    SqlTable(
        "dbo",
        "lc_select_all_employees",
        query {
            for entity in Sql.serverData.Dbo.LcSelectAllemployees do
                select entity
        }
        |> Seq.toArray
        |> Array.map (fun entity -> entity :> Common.SqlEntity)
    )

// LcSelectAllemployeesView.asAstModule.clip

let lc_select_all_employeeEntities = lc_select_all_employeesTable.sqlEntities
// lc_select_all_employeesTable.asAstModule.clip

type BannerEmployee = {
    BENIFITE: decimal option
    DEPARTMENT: string
    DIVISION: string
    EFFECTIVE: DateTime option
    EMAIL: string option
    FIRSTNAME: string
    HIRED: DateTime
    ID: string
    LASTNAME: string
    MIDDLENAME: string option
    ORG: string
    ORGCODE: string
    POSITION: string
    RATE: decimal option
    SUPERVISOR: string option
    SUPERVISORID: string option
}

let bannerEmployees =
    lc_select_all_employeeEntities
    |> Array.map (fun sqlEntity -> {
        BENIFITE =
            sqlEntity.valueObjectByColumn["BENIFITE"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["BENIFITE"].schema lc_select_all_employeesTable.columnsByName["BENIFITE"].isOption
            |> SqlType.asDecimalOption
        DEPARTMENT =
            sqlEntity.valueObjectByColumn["DEPARTMENT"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["DEPARTMENT"].schema lc_select_all_employeesTable.columnsByName["DEPARTMENT"].isOption
            |> SqlType.asString
        DIVISION =
            sqlEntity.valueObjectByColumn["DIVISION"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["DIVISION"].schema lc_select_all_employeesTable.columnsByName["DIVISION"].isOption
            |> SqlType.asString
        EFFECTIVE =
            sqlEntity.valueObjectByColumn["EFFECTIVE"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["EFFECTIVE"].schema lc_select_all_employeesTable.columnsByName["EFFECTIVE"].isOption
            |> SqlType.asDateTimeOption
        EMAIL =
            sqlEntity.valueObjectByColumn["EMAIL"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["EMAIL"].schema lc_select_all_employeesTable.columnsByName["EMAIL"].isOption
            |> SqlType.asStringOption
        FIRSTNAME =
            sqlEntity.valueObjectByColumn["FIRSTNAME"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["FIRSTNAME"].schema lc_select_all_employeesTable.columnsByName["FIRSTNAME"].isOption
            |> SqlType.asString
        HIRED =
            sqlEntity.valueObjectByColumn["HIRED"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["HIRED"].schema lc_select_all_employeesTable.columnsByName["HIRED"].isOption
            |> SqlType.asDateTime
        ID =
            sqlEntity.valueObjectByColumn["ID"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["ID"].schema lc_select_all_employeesTable.columnsByName["ID"].isOption
            |> SqlType.asString
        LASTNAME =
            sqlEntity.valueObjectByColumn["LASTNAME"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["LASTNAME"].schema lc_select_all_employeesTable.columnsByName["LASTNAME"].isOption
            |> SqlType.asString
        MIDDLENAME =
            sqlEntity.valueObjectByColumn["MIDDLENAME"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["MIDDLENAME"].schema lc_select_all_employeesTable.columnsByName["MIDDLENAME"].isOption
            |> SqlType.asStringOption
        ORG =
            sqlEntity.valueObjectByColumn["ORG"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["ORG"].schema lc_select_all_employeesTable.columnsByName["ORG"].isOption
            |> SqlType.asString
        ORGCODE =
            sqlEntity.valueObjectByColumn["ORGCODE"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["ORGCODE"].schema lc_select_all_employeesTable.columnsByName["ORGCODE"].isOption
            |> SqlType.asString
        POSITION =
            sqlEntity.valueObjectByColumn["POSITION"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["POSITION"].schema lc_select_all_employeesTable.columnsByName["POSITION"].isOption
            |> SqlType.asString
        RATE =
            sqlEntity.valueObjectByColumn["RATE"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["RATE"].schema lc_select_all_employeesTable.columnsByName["RATE"].isOption
            |> SqlType.asDecimalOption
        SUPERVISOR =
            sqlEntity.valueObjectByColumn["SUPERVISOR"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["SUPERVISOR"].schema lc_select_all_employeesTable.columnsByName["SUPERVISOR"].isOption
            |> SqlType.asStringOption
        SUPERVISORID =
            sqlEntity.valueObjectByColumn["SUPERVISORID"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["SUPERVISORID"].schema lc_select_all_employeesTable.columnsByName["SUPERVISORID"].isOption
            |> SqlType.asStringOption
    })

let EmployeeTable =
    SqlTable(
        "Resources",
        "Employee",
        query {
            for entity in Sql.serverData.Resources.Employee do
                select entity
        }
        |> Seq.toArray
        |> Array.map (fun entity -> entity :> Common.SqlEntity)
    )

let employeeEntities = EmployeeTable.sqlEntities
// EmployeeTable.asAstModule.clip

type InforEmployee = {
    ADDBY: string option
    ADDDTTM: DateTime
    BNFTRATE: decimal option
    BUDGETKEY: int
    CALENDARACCOUNT: int option
    COMMENTS: string option
    COMMENTS_SEARCH: string option
    CONTACTKEY: int
    CREWLDR: string option
    DEPT: string option
    EMERGINFO: string option
    EMERGNAME1: string option
    EMERGNAME2: string option
    EMERGNAME3: string option
    EMERGPHN1: string option
    EMERGPHN2: string option
    EMERGPHN3: string option
    EMERGREL1: string option
    EMERGREL2: string option
    EMERGREL3: string option
    EMPID: string option
    EXPDATE: DateTime option
    GPSENDINGPOINTX: float option
    GPSENDINGPOINTY: float option
    GPSSTARTINGPOINTX: float option
    GPSSTARTINGPOINTY: float option
    HIREDATE: DateTime option
    INSPFLAG: string option
    MODBY: string option
    MODDTTM: DateTime option
    ORGANIZATION: string option
    PINAUTHCODE: string option
    RATE: decimal option
    SECT: string option
    SUPR: string option
    SUPRFLAG: string option
    UNIT: string option
}

let inforEmployees =
    employeeEntities
    |> Array.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse EmployeeTable.columnsByName["ADDBY"].schema EmployeeTable.columnsByName["ADDBY"].isOption
            |> SqlType.asStringOption
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse EmployeeTable.columnsByName["ADDDTTM"].schema EmployeeTable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTime
        BNFTRATE =
            sqlEntity.valueObjectByColumn["BNFTRATE"]
            |> SqlType.Parse EmployeeTable.columnsByName["BNFTRATE"].schema EmployeeTable.columnsByName["BNFTRATE"].isOption
            |> SqlType.asDecimalOption
        BUDGETKEY =
            sqlEntity.valueObjectByColumn["BUDGETKEY"]
            |> SqlType.Parse EmployeeTable.columnsByName["BUDGETKEY"].schema EmployeeTable.columnsByName["BUDGETKEY"].isOption
            |> SqlType.asInt32
        CALENDARACCOUNT =
            sqlEntity.valueObjectByColumn["CALENDARACCOUNT"]
            |> SqlType.Parse EmployeeTable.columnsByName["CALENDARACCOUNT"].schema EmployeeTable.columnsByName["CALENDARACCOUNT"].isOption
            |> SqlType.asInt32Option
        COMMENTS =
            sqlEntity.valueObjectByColumn["COMMENTS"]
            |> SqlType.Parse EmployeeTable.columnsByName["COMMENTS"].schema EmployeeTable.columnsByName["COMMENTS"].isOption
            |> SqlType.asStringOption
        COMMENTS_SEARCH =
            sqlEntity.valueObjectByColumn["COMMENTS_SEARCH"]
            |> SqlType.Parse EmployeeTable.columnsByName["COMMENTS_SEARCH"].schema EmployeeTable.columnsByName["COMMENTS_SEARCH"].isOption
            |> SqlType.asStringOption
        CONTACTKEY =
            sqlEntity.valueObjectByColumn["CONTACTKEY"]
            |> SqlType.Parse EmployeeTable.columnsByName["CONTACTKEY"].schema EmployeeTable.columnsByName["CONTACTKEY"].isOption
            |> SqlType.asInt32
        CREWLDR =
            sqlEntity.valueObjectByColumn["CREWLDR"]
            |> SqlType.Parse EmployeeTable.columnsByName["CREWLDR"].schema EmployeeTable.columnsByName["CREWLDR"].isOption
            |> SqlType.asStringOption
        DEPT =
            sqlEntity.valueObjectByColumn["DEPT"]
            |> SqlType.Parse EmployeeTable.columnsByName["DEPT"].schema EmployeeTable.columnsByName["DEPT"].isOption
            |> SqlType.asStringOption
        EMERGINFO =
            sqlEntity.valueObjectByColumn["EMERGINFO"]
            |> SqlType.Parse EmployeeTable.columnsByName["EMERGINFO"].schema EmployeeTable.columnsByName["EMERGINFO"].isOption
            |> SqlType.asStringOption
        EMERGNAME1 =
            sqlEntity.valueObjectByColumn["EMERGNAME1"]
            |> SqlType.Parse EmployeeTable.columnsByName["EMERGNAME1"].schema EmployeeTable.columnsByName["EMERGNAME1"].isOption
            |> SqlType.asStringOption
        EMERGNAME2 =
            sqlEntity.valueObjectByColumn["EMERGNAME2"]
            |> SqlType.Parse EmployeeTable.columnsByName["EMERGNAME2"].schema EmployeeTable.columnsByName["EMERGNAME2"].isOption
            |> SqlType.asStringOption
        EMERGNAME3 =
            sqlEntity.valueObjectByColumn["EMERGNAME3"]
            |> SqlType.Parse EmployeeTable.columnsByName["EMERGNAME3"].schema EmployeeTable.columnsByName["EMERGNAME3"].isOption
            |> SqlType.asStringOption
        EMERGPHN1 =
            sqlEntity.valueObjectByColumn["EMERGPHN1"]
            |> SqlType.Parse EmployeeTable.columnsByName["EMERGPHN1"].schema EmployeeTable.columnsByName["EMERGPHN1"].isOption
            |> SqlType.asStringOption
        EMERGPHN2 =
            sqlEntity.valueObjectByColumn["EMERGPHN2"]
            |> SqlType.Parse EmployeeTable.columnsByName["EMERGPHN2"].schema EmployeeTable.columnsByName["EMERGPHN2"].isOption
            |> SqlType.asStringOption
        EMERGPHN3 =
            sqlEntity.valueObjectByColumn["EMERGPHN3"]
            |> SqlType.Parse EmployeeTable.columnsByName["EMERGPHN3"].schema EmployeeTable.columnsByName["EMERGPHN3"].isOption
            |> SqlType.asStringOption
        EMERGREL1 =
            sqlEntity.valueObjectByColumn["EMERGREL1"]
            |> SqlType.Parse EmployeeTable.columnsByName["EMERGREL1"].schema EmployeeTable.columnsByName["EMERGREL1"].isOption
            |> SqlType.asStringOption
        EMERGREL2 =
            sqlEntity.valueObjectByColumn["EMERGREL2"]
            |> SqlType.Parse EmployeeTable.columnsByName["EMERGREL2"].schema EmployeeTable.columnsByName["EMERGREL2"].isOption
            |> SqlType.asStringOption
        EMERGREL3 =
            sqlEntity.valueObjectByColumn["EMERGREL3"]
            |> SqlType.Parse EmployeeTable.columnsByName["EMERGREL3"].schema EmployeeTable.columnsByName["EMERGREL3"].isOption
            |> SqlType.asStringOption
        EMPID =
            sqlEntity.valueObjectByColumn["EMPID"]
            |> SqlType.Parse EmployeeTable.columnsByName["EMPID"].schema EmployeeTable.columnsByName["EMPID"].isOption
            |> SqlType.asStringOption
        EXPDATE =
            sqlEntity.valueObjectByColumn["EXPDATE"]
            |> SqlType.Parse EmployeeTable.columnsByName["EXPDATE"].schema EmployeeTable.columnsByName["EXPDATE"].isOption
            |> SqlType.asDateTimeOption
        GPSENDINGPOINTX =
            sqlEntity.valueObjectByColumn["GPSENDINGPOINTX"]
            |> SqlType.Parse EmployeeTable.columnsByName["GPSENDINGPOINTX"].schema EmployeeTable.columnsByName["GPSENDINGPOINTX"].isOption
            |> SqlType.asDoubleOption
        GPSENDINGPOINTY =
            sqlEntity.valueObjectByColumn["GPSENDINGPOINTY"]
            |> SqlType.Parse EmployeeTable.columnsByName["GPSENDINGPOINTY"].schema EmployeeTable.columnsByName["GPSENDINGPOINTY"].isOption
            |> SqlType.asDoubleOption
        GPSSTARTINGPOINTX =
            sqlEntity.valueObjectByColumn["GPSSTARTINGPOINTX"]
            |> SqlType.Parse EmployeeTable.columnsByName["GPSSTARTINGPOINTX"].schema EmployeeTable.columnsByName["GPSSTARTINGPOINTX"].isOption
            |> SqlType.asDoubleOption
        GPSSTARTINGPOINTY =
            sqlEntity.valueObjectByColumn["GPSSTARTINGPOINTY"]
            |> SqlType.Parse EmployeeTable.columnsByName["GPSSTARTINGPOINTY"].schema EmployeeTable.columnsByName["GPSSTARTINGPOINTY"].isOption
            |> SqlType.asDoubleOption
        HIREDATE =
            sqlEntity.valueObjectByColumn["HIREDATE"]
            |> SqlType.Parse EmployeeTable.columnsByName["HIREDATE"].schema EmployeeTable.columnsByName["HIREDATE"].isOption
            |> SqlType.asDateTimeOption
        INSPFLAG =
            sqlEntity.valueObjectByColumn["INSPFLAG"]
            |> SqlType.Parse EmployeeTable.columnsByName["INSPFLAG"].schema EmployeeTable.columnsByName["INSPFLAG"].isOption
            |> SqlType.asStringOption
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse EmployeeTable.columnsByName["MODBY"].schema EmployeeTable.columnsByName["MODBY"].isOption
            |> SqlType.asStringOption
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse EmployeeTable.columnsByName["MODDTTM"].schema EmployeeTable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
        ORGANIZATION =
            sqlEntity.valueObjectByColumn["ORGANIZATION"]
            |> SqlType.Parse EmployeeTable.columnsByName["ORGANIZATION"].schema EmployeeTable.columnsByName["ORGANIZATION"].isOption
            |> SqlType.asStringOption
        PINAUTHCODE =
            sqlEntity.valueObjectByColumn["PINAUTHCODE"]
            |> SqlType.Parse EmployeeTable.columnsByName["PINAUTHCODE"].schema EmployeeTable.columnsByName["PINAUTHCODE"].isOption
            |> SqlType.asStringOption
        RATE =
            sqlEntity.valueObjectByColumn["RATE"]
            |> SqlType.Parse EmployeeTable.columnsByName["RATE"].schema EmployeeTable.columnsByName["RATE"].isOption
            |> SqlType.asDecimalOption
        SECT =
            sqlEntity.valueObjectByColumn["SECT"]
            |> SqlType.Parse EmployeeTable.columnsByName["SECT"].schema EmployeeTable.columnsByName["SECT"].isOption
            |> SqlType.asStringOption
        SUPR =
            sqlEntity.valueObjectByColumn["SUPR"]
            |> SqlType.Parse EmployeeTable.columnsByName["SUPR"].schema EmployeeTable.columnsByName["SUPR"].isOption
            |> SqlType.asStringOption
        SUPRFLAG =
            sqlEntity.valueObjectByColumn["SUPRFLAG"]
            |> SqlType.Parse EmployeeTable.columnsByName["SUPRFLAG"].schema EmployeeTable.columnsByName["SUPRFLAG"].isOption
            |> SqlType.asStringOption
        UNIT =
            sqlEntity.valueObjectByColumn["UNIT"]
            |> SqlType.Parse EmployeeTable.columnsByName["UNIT"].schema EmployeeTable.columnsByName["UNIT"].isOption
            |> SqlType.asStringOption
    })

let ContactTable =
    SqlTable(
        "Resources",
        "Contact",
        query {
            for entity in Sql.serverData.Resources.Contact do
                select entity
        }
        |> Seq.toArray
        |> Array.map (fun entity -> entity :> Common.SqlEntity)
    )

let contactEntities = ContactTable.sqlEntities
// ContactTable.asAstModule.clip

type InforContact = {
    ADDBY: string option
    ADDDTTM: DateTime
    ADDR1: string option
    ADDR2: string option
    CARRT: string option
    CASSBARCODE: int option
    CASSVALIDATIONDESC: string option
    CASSVALIDATIONDT: DateTime option
    CASSVALIDATIONSTATUS: string option
    CASSVER: int option
    CITY: string option
    CNTCTKEY: int
    COMMENTS: string option
    COMMENTS_SEARCH: string option
    CONAME: string option
    CONTACTTYPE: string option
    CONTENTASATTACHMENT: string option
    CORRDELIVERY: int option
    COUNTRY: string option
    DAYPHN: string option
    DPC: string option
    EMAIL: string option
    EVEPHN: string option
    EXPDATE: DateTime option
    FAX: string option
    FORGN: string option
    IDKEY: int
    INTERNETID1: string option
    INTERNETID2: string option
    INTERNETID3: string option
    INTERNETID4: string option
    INTERNETTYPE1: string option
    INTERNETTYPE2: string option
    INTERNETTYPE3: string option
    INTERNETTYPE4: string option
    ISSERVICEPROVIDER: string option
    LOT: string option
    MOBILE: string option
    MODBY: string option
    MODDTTM: DateTime option
    PGR: string option
    PGRPIN: string option
    POSITION: string option
    PROFESSION: string option
    REFERENCEVALUE1: string option
    REFERENCEVALUE2: string option
    REFNO: string option
    SALARY: float option
    SEASADDR1: string option
    SEASADDR2: string option
    SEASCARRT: string option
    SEASCASSBARCODE: int option
    SEASCASSVALIDATIONDESC: string option
    SEASCASSVALIDATIONDT: DateTime option
    SEASCASSVALIDATIONSTATUS: string option
    SEASCASSVER: int option
    SEASCITY: string option
    SEASCNTRY: string option
    SEASDAYPHN: string option
    SEASDPC: string option
    SEASEVEPHN: string option
    SEASFAX: string option
    SEASFORGN: string option
    SEASFROMDT: DateTime option
    SEASLOT: string option
    SEASSTATE: string option
    SEASTODT: DateTime option
    SEASZIP: string option
    STATE: string option
    WEBUSERKEY: int
    ZIP: string option
}

let employeeContactKeys = inforEmployees |> Array.map (fun employee -> employee.CONTACTKEY) |> Set.ofArray

let employeeContacts =
    contactEntities
    |> Array.filter (fun sqlEntity ->
        employeeContactKeys.Contains(
            sqlEntity.valueObjectByColumn["CNTCTKEY"]
            |> SqlType.Parse ContactTable.columnsByName["CNTCTKEY"].schema ContactTable.columnsByName["CNTCTKEY"].isOption
            |> SqlType.asInt32
        ))
    |> Array.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse ContactTable.columnsByName["ADDBY"].schema ContactTable.columnsByName["ADDBY"].isOption
            |> SqlType.asStringOption
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse ContactTable.columnsByName["ADDDTTM"].schema ContactTable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTime
        ADDR1 =
            sqlEntity.valueObjectByColumn["ADDR1"]
            |> SqlType.Parse ContactTable.columnsByName["ADDR1"].schema ContactTable.columnsByName["ADDR1"].isOption
            |> SqlType.asStringOption
        ADDR2 =
            sqlEntity.valueObjectByColumn["ADDR2"]
            |> SqlType.Parse ContactTable.columnsByName["ADDR2"].schema ContactTable.columnsByName["ADDR2"].isOption
            |> SqlType.asStringOption
        CARRT =
            sqlEntity.valueObjectByColumn["CARRT"]
            |> SqlType.Parse ContactTable.columnsByName["CARRT"].schema ContactTable.columnsByName["CARRT"].isOption
            |> SqlType.asStringOption
        CASSBARCODE =
            sqlEntity.valueObjectByColumn["CASSBARCODE"]
            |> SqlType.Parse ContactTable.columnsByName["CASSBARCODE"].schema ContactTable.columnsByName["CASSBARCODE"].isOption
            |> SqlType.asInt32Option
        CASSVALIDATIONDESC =
            sqlEntity.valueObjectByColumn["CASSVALIDATIONDESC"]
            |> SqlType.Parse ContactTable.columnsByName["CASSVALIDATIONDESC"].schema ContactTable.columnsByName["CASSVALIDATIONDESC"].isOption
            |> SqlType.asStringOption
        CASSVALIDATIONDT =
            sqlEntity.valueObjectByColumn["CASSVALIDATIONDT"]
            |> SqlType.Parse ContactTable.columnsByName["CASSVALIDATIONDT"].schema ContactTable.columnsByName["CASSVALIDATIONDT"].isOption
            |> SqlType.asDateTimeOption
        CASSVALIDATIONSTATUS =
            sqlEntity.valueObjectByColumn["CASSVALIDATIONSTATUS"]
            |> SqlType.Parse ContactTable.columnsByName["CASSVALIDATIONSTATUS"].schema ContactTable.columnsByName["CASSVALIDATIONSTATUS"].isOption
            |> SqlType.asStringOption
        CASSVER =
            sqlEntity.valueObjectByColumn["CASSVER"]
            |> SqlType.Parse ContactTable.columnsByName["CASSVER"].schema ContactTable.columnsByName["CASSVER"].isOption
            |> SqlType.asInt32Option
        CITY =
            sqlEntity.valueObjectByColumn["CITY"]
            |> SqlType.Parse ContactTable.columnsByName["CITY"].schema ContactTable.columnsByName["CITY"].isOption
            |> SqlType.asStringOption
        CNTCTKEY =
            sqlEntity.valueObjectByColumn["CNTCTKEY"]
            |> SqlType.Parse ContactTable.columnsByName["CNTCTKEY"].schema ContactTable.columnsByName["CNTCTKEY"].isOption
            |> SqlType.asInt32
        COMMENTS =
            sqlEntity.valueObjectByColumn["COMMENTS"]
            |> SqlType.Parse ContactTable.columnsByName["COMMENTS"].schema ContactTable.columnsByName["COMMENTS"].isOption
            |> SqlType.asStringOption
        COMMENTS_SEARCH =
            sqlEntity.valueObjectByColumn["COMMENTS_SEARCH"]
            |> SqlType.Parse ContactTable.columnsByName["COMMENTS_SEARCH"].schema ContactTable.columnsByName["COMMENTS_SEARCH"].isOption
            |> SqlType.asStringOption
        CONAME =
            sqlEntity.valueObjectByColumn["CONAME"]
            |> SqlType.Parse ContactTable.columnsByName["CONAME"].schema ContactTable.columnsByName["CONAME"].isOption
            |> SqlType.asStringOption
        CONTACTTYPE =
            sqlEntity.valueObjectByColumn["CONTACTTYPE"]
            |> SqlType.Parse ContactTable.columnsByName["CONTACTTYPE"].schema ContactTable.columnsByName["CONTACTTYPE"].isOption
            |> SqlType.asStringOption
        CONTENTASATTACHMENT =
            sqlEntity.valueObjectByColumn["CONTENTASATTACHMENT"]
            |> SqlType.Parse ContactTable.columnsByName["CONTENTASATTACHMENT"].schema ContactTable.columnsByName["CONTENTASATTACHMENT"].isOption
            |> SqlType.asStringOption
        CORRDELIVERY =
            sqlEntity.valueObjectByColumn["CORRDELIVERY"]
            |> SqlType.Parse ContactTable.columnsByName["CORRDELIVERY"].schema ContactTable.columnsByName["CORRDELIVERY"].isOption
            |> SqlType.asInt32Option
        COUNTRY =
            sqlEntity.valueObjectByColumn["COUNTRY"]
            |> SqlType.Parse ContactTable.columnsByName["COUNTRY"].schema ContactTable.columnsByName["COUNTRY"].isOption
            |> SqlType.asStringOption
        DAYPHN =
            sqlEntity.valueObjectByColumn["DAYPHN"]
            |> SqlType.Parse ContactTable.columnsByName["DAYPHN"].schema ContactTable.columnsByName["DAYPHN"].isOption
            |> SqlType.asStringOption
        DPC =
            sqlEntity.valueObjectByColumn["DPC"]
            |> SqlType.Parse ContactTable.columnsByName["DPC"].schema ContactTable.columnsByName["DPC"].isOption
            |> SqlType.asStringOption
        EMAIL =
            sqlEntity.valueObjectByColumn["EMAIL"]
            |> SqlType.Parse ContactTable.columnsByName["EMAIL"].schema ContactTable.columnsByName["EMAIL"].isOption
            |> SqlType.asStringOption
        EVEPHN =
            sqlEntity.valueObjectByColumn["EVEPHN"]
            |> SqlType.Parse ContactTable.columnsByName["EVEPHN"].schema ContactTable.columnsByName["EVEPHN"].isOption
            |> SqlType.asStringOption
        EXPDATE =
            sqlEntity.valueObjectByColumn["EXPDATE"]
            |> SqlType.Parse ContactTable.columnsByName["EXPDATE"].schema ContactTable.columnsByName["EXPDATE"].isOption
            |> SqlType.asDateTimeOption
        FAX =
            sqlEntity.valueObjectByColumn["FAX"]
            |> SqlType.Parse ContactTable.columnsByName["FAX"].schema ContactTable.columnsByName["FAX"].isOption
            |> SqlType.asStringOption
        FORGN =
            sqlEntity.valueObjectByColumn["FORGN"]
            |> SqlType.Parse ContactTable.columnsByName["FORGN"].schema ContactTable.columnsByName["FORGN"].isOption
            |> SqlType.asStringOption
        IDKEY =
            sqlEntity.valueObjectByColumn["IDKEY"]
            |> SqlType.Parse ContactTable.columnsByName["IDKEY"].schema ContactTable.columnsByName["IDKEY"].isOption
            |> SqlType.asInt32
        INTERNETID1 =
            sqlEntity.valueObjectByColumn["INTERNETID1"]
            |> SqlType.Parse ContactTable.columnsByName["INTERNETID1"].schema ContactTable.columnsByName["INTERNETID1"].isOption
            |> SqlType.asStringOption
        INTERNETID2 =
            sqlEntity.valueObjectByColumn["INTERNETID2"]
            |> SqlType.Parse ContactTable.columnsByName["INTERNETID2"].schema ContactTable.columnsByName["INTERNETID2"].isOption
            |> SqlType.asStringOption
        INTERNETID3 =
            sqlEntity.valueObjectByColumn["INTERNETID3"]
            |> SqlType.Parse ContactTable.columnsByName["INTERNETID3"].schema ContactTable.columnsByName["INTERNETID3"].isOption
            |> SqlType.asStringOption
        INTERNETID4 =
            sqlEntity.valueObjectByColumn["INTERNETID4"]
            |> SqlType.Parse ContactTable.columnsByName["INTERNETID4"].schema ContactTable.columnsByName["INTERNETID4"].isOption
            |> SqlType.asStringOption
        INTERNETTYPE1 =
            sqlEntity.valueObjectByColumn["INTERNETTYPE1"]
            |> SqlType.Parse ContactTable.columnsByName["INTERNETTYPE1"].schema ContactTable.columnsByName["INTERNETTYPE1"].isOption
            |> SqlType.asStringOption
        INTERNETTYPE2 =
            sqlEntity.valueObjectByColumn["INTERNETTYPE2"]
            |> SqlType.Parse ContactTable.columnsByName["INTERNETTYPE2"].schema ContactTable.columnsByName["INTERNETTYPE2"].isOption
            |> SqlType.asStringOption
        INTERNETTYPE3 =
            sqlEntity.valueObjectByColumn["INTERNETTYPE3"]
            |> SqlType.Parse ContactTable.columnsByName["INTERNETTYPE3"].schema ContactTable.columnsByName["INTERNETTYPE3"].isOption
            |> SqlType.asStringOption
        INTERNETTYPE4 =
            sqlEntity.valueObjectByColumn["INTERNETTYPE4"]
            |> SqlType.Parse ContactTable.columnsByName["INTERNETTYPE4"].schema ContactTable.columnsByName["INTERNETTYPE4"].isOption
            |> SqlType.asStringOption
        ISSERVICEPROVIDER =
            sqlEntity.valueObjectByColumn["ISSERVICEPROVIDER"]
            |> SqlType.Parse ContactTable.columnsByName["ISSERVICEPROVIDER"].schema ContactTable.columnsByName["ISSERVICEPROVIDER"].isOption
            |> SqlType.asStringOption
        LOT =
            sqlEntity.valueObjectByColumn["LOT"]
            |> SqlType.Parse ContactTable.columnsByName["LOT"].schema ContactTable.columnsByName["LOT"].isOption
            |> SqlType.asStringOption
        MOBILE =
            sqlEntity.valueObjectByColumn["MOBILE"]
            |> SqlType.Parse ContactTable.columnsByName["MOBILE"].schema ContactTable.columnsByName["MOBILE"].isOption
            |> SqlType.asStringOption
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse ContactTable.columnsByName["MODBY"].schema ContactTable.columnsByName["MODBY"].isOption
            |> SqlType.asStringOption
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse ContactTable.columnsByName["MODDTTM"].schema ContactTable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
        PGR =
            sqlEntity.valueObjectByColumn["PGR"]
            |> SqlType.Parse ContactTable.columnsByName["PGR"].schema ContactTable.columnsByName["PGR"].isOption
            |> SqlType.asStringOption
        PGRPIN =
            sqlEntity.valueObjectByColumn["PGRPIN"]
            |> SqlType.Parse ContactTable.columnsByName["PGRPIN"].schema ContactTable.columnsByName["PGRPIN"].isOption
            |> SqlType.asStringOption
        POSITION =
            sqlEntity.valueObjectByColumn["POSITION"]
            |> SqlType.Parse ContactTable.columnsByName["POSITION"].schema ContactTable.columnsByName["POSITION"].isOption
            |> SqlType.asStringOption
        PROFESSION =
            sqlEntity.valueObjectByColumn["PROFESSION"]
            |> SqlType.Parse ContactTable.columnsByName["PROFESSION"].schema ContactTable.columnsByName["PROFESSION"].isOption
            |> SqlType.asStringOption
        REFERENCEVALUE1 =
            sqlEntity.valueObjectByColumn["REFERENCEVALUE1"]
            |> SqlType.Parse ContactTable.columnsByName["REFERENCEVALUE1"].schema ContactTable.columnsByName["REFERENCEVALUE1"].isOption
            |> SqlType.asStringOption
        REFERENCEVALUE2 =
            sqlEntity.valueObjectByColumn["REFERENCEVALUE2"]
            |> SqlType.Parse ContactTable.columnsByName["REFERENCEVALUE2"].schema ContactTable.columnsByName["REFERENCEVALUE2"].isOption
            |> SqlType.asStringOption
        REFNO =
            sqlEntity.valueObjectByColumn["REFNO"]
            |> SqlType.Parse ContactTable.columnsByName["REFNO"].schema ContactTable.columnsByName["REFNO"].isOption
            |> SqlType.asStringOption
        SALARY =
            sqlEntity.valueObjectByColumn["SALARY"]
            |> SqlType.Parse ContactTable.columnsByName["SALARY"].schema ContactTable.columnsByName["SALARY"].isOption
            |> SqlType.asDoubleOption
        SEASADDR1 =
            sqlEntity.valueObjectByColumn["SEASADDR1"]
            |> SqlType.Parse ContactTable.columnsByName["SEASADDR1"].schema ContactTable.columnsByName["SEASADDR1"].isOption
            |> SqlType.asStringOption
        SEASADDR2 =
            sqlEntity.valueObjectByColumn["SEASADDR2"]
            |> SqlType.Parse ContactTable.columnsByName["SEASADDR2"].schema ContactTable.columnsByName["SEASADDR2"].isOption
            |> SqlType.asStringOption
        SEASCARRT =
            sqlEntity.valueObjectByColumn["SEASCARRT"]
            |> SqlType.Parse ContactTable.columnsByName["SEASCARRT"].schema ContactTable.columnsByName["SEASCARRT"].isOption
            |> SqlType.asStringOption
        SEASCASSBARCODE =
            sqlEntity.valueObjectByColumn["SEASCASSBARCODE"]
            |> SqlType.Parse ContactTable.columnsByName["SEASCASSBARCODE"].schema ContactTable.columnsByName["SEASCASSBARCODE"].isOption
            |> SqlType.asInt32Option
        SEASCASSVALIDATIONDESC =
            sqlEntity.valueObjectByColumn["SEASCASSVALIDATIONDESC"]
            |> SqlType.Parse ContactTable.columnsByName["SEASCASSVALIDATIONDESC"].schema ContactTable.columnsByName["SEASCASSVALIDATIONDESC"].isOption
            |> SqlType.asStringOption
        SEASCASSVALIDATIONDT =
            sqlEntity.valueObjectByColumn["SEASCASSVALIDATIONDT"]
            |> SqlType.Parse ContactTable.columnsByName["SEASCASSVALIDATIONDT"].schema ContactTable.columnsByName["SEASCASSVALIDATIONDT"].isOption
            |> SqlType.asDateTimeOption
        SEASCASSVALIDATIONSTATUS =
            sqlEntity.valueObjectByColumn["SEASCASSVALIDATIONSTATUS"]
            |> SqlType.Parse ContactTable.columnsByName["SEASCASSVALIDATIONSTATUS"].schema ContactTable.columnsByName["SEASCASSVALIDATIONSTATUS"].isOption
            |> SqlType.asStringOption
        SEASCASSVER =
            sqlEntity.valueObjectByColumn["SEASCASSVER"]
            |> SqlType.Parse ContactTable.columnsByName["SEASCASSVER"].schema ContactTable.columnsByName["SEASCASSVER"].isOption
            |> SqlType.asInt32Option
        SEASCITY =
            sqlEntity.valueObjectByColumn["SEASCITY"]
            |> SqlType.Parse ContactTable.columnsByName["SEASCITY"].schema ContactTable.columnsByName["SEASCITY"].isOption
            |> SqlType.asStringOption
        SEASCNTRY =
            sqlEntity.valueObjectByColumn["SEASCNTRY"]
            |> SqlType.Parse ContactTable.columnsByName["SEASCNTRY"].schema ContactTable.columnsByName["SEASCNTRY"].isOption
            |> SqlType.asStringOption
        SEASDAYPHN =
            sqlEntity.valueObjectByColumn["SEASDAYPHN"]
            |> SqlType.Parse ContactTable.columnsByName["SEASDAYPHN"].schema ContactTable.columnsByName["SEASDAYPHN"].isOption
            |> SqlType.asStringOption
        SEASDPC =
            sqlEntity.valueObjectByColumn["SEASDPC"]
            |> SqlType.Parse ContactTable.columnsByName["SEASDPC"].schema ContactTable.columnsByName["SEASDPC"].isOption
            |> SqlType.asStringOption
        SEASEVEPHN =
            sqlEntity.valueObjectByColumn["SEASEVEPHN"]
            |> SqlType.Parse ContactTable.columnsByName["SEASEVEPHN"].schema ContactTable.columnsByName["SEASEVEPHN"].isOption
            |> SqlType.asStringOption
        SEASFAX =
            sqlEntity.valueObjectByColumn["SEASFAX"]
            |> SqlType.Parse ContactTable.columnsByName["SEASFAX"].schema ContactTable.columnsByName["SEASFAX"].isOption
            |> SqlType.asStringOption
        SEASFORGN =
            sqlEntity.valueObjectByColumn["SEASFORGN"]
            |> SqlType.Parse ContactTable.columnsByName["SEASFORGN"].schema ContactTable.columnsByName["SEASFORGN"].isOption
            |> SqlType.asStringOption
        SEASFROMDT =
            sqlEntity.valueObjectByColumn["SEASFROMDT"]
            |> SqlType.Parse ContactTable.columnsByName["SEASFROMDT"].schema ContactTable.columnsByName["SEASFROMDT"].isOption
            |> SqlType.asDateTimeOption
        SEASLOT =
            sqlEntity.valueObjectByColumn["SEASLOT"]
            |> SqlType.Parse ContactTable.columnsByName["SEASLOT"].schema ContactTable.columnsByName["SEASLOT"].isOption
            |> SqlType.asStringOption
        SEASSTATE =
            sqlEntity.valueObjectByColumn["SEASSTATE"]
            |> SqlType.Parse ContactTable.columnsByName["SEASSTATE"].schema ContactTable.columnsByName["SEASSTATE"].isOption
            |> SqlType.asStringOption
        SEASTODT =
            sqlEntity.valueObjectByColumn["SEASTODT"]
            |> SqlType.Parse ContactTable.columnsByName["SEASTODT"].schema ContactTable.columnsByName["SEASTODT"].isOption
            |> SqlType.asDateTimeOption
        SEASZIP =
            sqlEntity.valueObjectByColumn["SEASZIP"]
            |> SqlType.Parse ContactTable.columnsByName["SEASZIP"].schema ContactTable.columnsByName["SEASZIP"].isOption
            |> SqlType.asStringOption
        STATE =
            sqlEntity.valueObjectByColumn["STATE"]
            |> SqlType.Parse ContactTable.columnsByName["STATE"].schema ContactTable.columnsByName["STATE"].isOption
            |> SqlType.asStringOption
        WEBUSERKEY =
            sqlEntity.valueObjectByColumn["WEBUSERKEY"]
            |> SqlType.Parse ContactTable.columnsByName["WEBUSERKEY"].schema ContactTable.columnsByName["WEBUSERKEY"].isOption
            |> SqlType.asInt32
        ZIP =
            sqlEntity.valueObjectByColumn["ZIP"]
            |> SqlType.Parse ContactTable.columnsByName["ZIP"].schema ContactTable.columnsByName["ZIP"].isOption
            |> SqlType.asStringOption
    })

type InforEmployee with
    member this._contact =
        employeeContacts
        |> Array.find (fun contact -> contact.CNTCTKEY = this.CONTACTKEY)
type InforContact with
    member this._tryInforEmployee =
        inforEmployees
        |> Array.find (fun inforEmployee -> inforEmployee.CONTACTKEY = this.CNTCTKEY)

let employeeContactIds = employeeContacts |> Array.map (fun contact -> contact.CNTCTKEY) |> Set.ofArray
let ContactIdTable =
    SqlTable(
        "Resources",
        "ContactId",
        query {
            for entity in Sql.serverData.Resources.Cntctid do
                select entity
        }
        |> Seq.toArray
        |> Array.map (fun entity -> entity :> Common.SqlEntity)
    )
let contactIdEntities = ContactIdTable.sqlEntities
// ContactIdTable.asAstModule.clip

type InforContactId = {
    ADDBY: string option
    ADDDTTM: DateTime option
    COMMENTS: string option
    COMMENTS_SEARCH: string option
    CONFIDENTFLAG: string
    CONTRACTORID: string option
    CONTRACTORRATE: decimal option
    CONTRACTORTYPE: string option
    CUSTOMERNO: string option
    DEATHDATE: DateTime option
    DOB: DateTime option
    DRIVERLICENSENO: string option
    DRIVERLICENSESTATE: string option
    EXPDATE: DateTime option
    EXTID: string option
    FEDTAXID: string option
    FULLNAME: string option
    HINT: string option
    IDKEY: int
    IDLAST4: string option
    IDNO: string option
    IDTYPE: string option
    ISCONTRACTOR: string
    ISORG: string
    LANGUAGE: string option
    MAIDENNAME: string option
    MODBY: string option
    MODDTTM: DateTime option
    NAMEFIRST: string option
    NAMELAST: string option
    NAMEMID: string option
    PASSWORD: string option
    PIN: int option
    PRIMARYDUPLICATE: int
    REQUESTEDNAME: string option
    SECURITYANSWER: string option
    STTAXID: string option
    SUFFIX: string option
    TITLE: string option
}

let contactIds =
    contactIdEntities
    |> Array.Parallel.filter (fun sqlEntity ->
        employeeContactIds.Contains(
            sqlEntity.valueObjectByColumn["IDKEY"]
            |> SqlType.Parse ContactIdTable.columnsByName["IDKEY"].schema ContactIdTable.columnsByName["IDKEY"].isOption
            |> SqlType.asInt32
        ))

    |> Array.Parallel.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse ContactIdTable.columnsByName["ADDBY"].schema ContactIdTable.columnsByName["ADDBY"].isOption
            |> SqlType.asStringOption
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse ContactIdTable.columnsByName["ADDDTTM"].schema ContactIdTable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTimeOption
        COMMENTS =
            sqlEntity.valueObjectByColumn["COMMENTS"]
            |> SqlType.Parse ContactIdTable.columnsByName["COMMENTS"].schema ContactIdTable.columnsByName["COMMENTS"].isOption
            |> SqlType.asStringOption
        COMMENTS_SEARCH =
            sqlEntity.valueObjectByColumn["COMMENTS_SEARCH"]
            |> SqlType.Parse ContactIdTable.columnsByName["COMMENTS_SEARCH"].schema ContactIdTable.columnsByName["COMMENTS_SEARCH"].isOption
            |> SqlType.asStringOption
        CONFIDENTFLAG =
            sqlEntity.valueObjectByColumn["CONFIDENTFLAG"]
            |> SqlType.Parse ContactIdTable.columnsByName["CONFIDENTFLAG"].schema ContactIdTable.columnsByName["CONFIDENTFLAG"].isOption
            |> SqlType.asString
        CONTRACTORID =
            sqlEntity.valueObjectByColumn["CONTRACTORID"]
            |> SqlType.Parse ContactIdTable.columnsByName["CONTRACTORID"].schema ContactIdTable.columnsByName["CONTRACTORID"].isOption
            |> SqlType.asStringOption
        CONTRACTORRATE =
            sqlEntity.valueObjectByColumn["CONTRACTORRATE"]
            |> SqlType.Parse ContactIdTable.columnsByName["CONTRACTORRATE"].schema ContactIdTable.columnsByName["CONTRACTORRATE"].isOption
            |> SqlType.asDecimalOption
        CONTRACTORTYPE =
            sqlEntity.valueObjectByColumn["CONTRACTORTYPE"]
            |> SqlType.Parse ContactIdTable.columnsByName["CONTRACTORTYPE"].schema ContactIdTable.columnsByName["CONTRACTORTYPE"].isOption
            |> SqlType.asStringOption
        CUSTOMERNO =
            sqlEntity.valueObjectByColumn["CUSTOMERNO"]
            |> SqlType.Parse ContactIdTable.columnsByName["CUSTOMERNO"].schema ContactIdTable.columnsByName["CUSTOMERNO"].isOption
            |> SqlType.asStringOption
        DEATHDATE =
            sqlEntity.valueObjectByColumn["DEATHDATE"]
            |> SqlType.Parse ContactIdTable.columnsByName["DEATHDATE"].schema ContactIdTable.columnsByName["DEATHDATE"].isOption
            |> SqlType.asDateTimeOption
        DOB =
            sqlEntity.valueObjectByColumn["DOB"]
            |> SqlType.Parse ContactIdTable.columnsByName["DOB"].schema ContactIdTable.columnsByName["DOB"].isOption
            |> SqlType.asDateTimeOption
        DRIVERLICENSENO =
            sqlEntity.valueObjectByColumn["DRIVERLICENSENO"]
            |> SqlType.Parse ContactIdTable.columnsByName["DRIVERLICENSENO"].schema ContactIdTable.columnsByName["DRIVERLICENSENO"].isOption
            |> SqlType.asStringOption
        DRIVERLICENSESTATE =
            sqlEntity.valueObjectByColumn["DRIVERLICENSESTATE"]
            |> SqlType.Parse ContactIdTable.columnsByName["DRIVERLICENSESTATE"].schema ContactIdTable.columnsByName["DRIVERLICENSESTATE"].isOption
            |> SqlType.asStringOption
        EXPDATE =
            sqlEntity.valueObjectByColumn["EXPDATE"]
            |> SqlType.Parse ContactIdTable.columnsByName["EXPDATE"].schema ContactIdTable.columnsByName["EXPDATE"].isOption
            |> SqlType.asDateTimeOption
        EXTID =
            sqlEntity.valueObjectByColumn["EXTID"]
            |> SqlType.Parse ContactIdTable.columnsByName["EXTID"].schema ContactIdTable.columnsByName["EXTID"].isOption
            |> SqlType.asStringOption
        FEDTAXID =
            sqlEntity.valueObjectByColumn["FEDTAXID"]
            |> SqlType.Parse ContactIdTable.columnsByName["FEDTAXID"].schema ContactIdTable.columnsByName["FEDTAXID"].isOption
            |> SqlType.asStringOption
        FULLNAME =
            sqlEntity.valueObjectByColumn["FULLNAME"]
            |> SqlType.Parse ContactIdTable.columnsByName["FULLNAME"].schema ContactIdTable.columnsByName["FULLNAME"].isOption
            |> SqlType.asStringOption
        HINT =
            sqlEntity.valueObjectByColumn["HINT"]
            |> SqlType.Parse ContactIdTable.columnsByName["HINT"].schema ContactIdTable.columnsByName["HINT"].isOption
            |> SqlType.asStringOption
        IDKEY =
            sqlEntity.valueObjectByColumn["IDKEY"]
            |> SqlType.Parse ContactIdTable.columnsByName["IDKEY"].schema ContactIdTable.columnsByName["IDKEY"].isOption
            |> SqlType.asInt32
        IDLAST4 =
            sqlEntity.valueObjectByColumn["IDLAST4"]
            |> SqlType.Parse ContactIdTable.columnsByName["IDLAST4"].schema ContactIdTable.columnsByName["IDLAST4"].isOption
            |> SqlType.asStringOption
        IDNO =
            sqlEntity.valueObjectByColumn["IDNO"]
            |> SqlType.Parse ContactIdTable.columnsByName["IDNO"].schema ContactIdTable.columnsByName["IDNO"].isOption
            |> SqlType.asStringOption
        IDTYPE =
            sqlEntity.valueObjectByColumn["IDTYPE"]
            |> SqlType.Parse ContactIdTable.columnsByName["IDTYPE"].schema ContactIdTable.columnsByName["IDTYPE"].isOption
            |> SqlType.asStringOption
        ISCONTRACTOR =
            sqlEntity.valueObjectByColumn["ISCONTRACTOR"]
            |> SqlType.Parse ContactIdTable.columnsByName["ISCONTRACTOR"].schema ContactIdTable.columnsByName["ISCONTRACTOR"].isOption
            |> SqlType.asString
        ISORG =
            sqlEntity.valueObjectByColumn["ISORG"]
            |> SqlType.Parse ContactIdTable.columnsByName["ISORG"].schema ContactIdTable.columnsByName["ISORG"].isOption
            |> SqlType.asString
        LANGUAGE =
            sqlEntity.valueObjectByColumn["LANGUAGE"]
            |> SqlType.Parse ContactIdTable.columnsByName["LANGUAGE"].schema ContactIdTable.columnsByName["LANGUAGE"].isOption
            |> SqlType.asStringOption
        MAIDENNAME =
            sqlEntity.valueObjectByColumn["MAIDENNAME"]
            |> SqlType.Parse ContactIdTable.columnsByName["MAIDENNAME"].schema ContactIdTable.columnsByName["MAIDENNAME"].isOption
            |> SqlType.asStringOption
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse ContactIdTable.columnsByName["MODBY"].schema ContactIdTable.columnsByName["MODBY"].isOption
            |> SqlType.asStringOption
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse ContactIdTable.columnsByName["MODDTTM"].schema ContactIdTable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
        NAMEFIRST =
            sqlEntity.valueObjectByColumn["NAMEFIRST"]
            |> SqlType.Parse ContactIdTable.columnsByName["NAMEFIRST"].schema ContactIdTable.columnsByName["NAMEFIRST"].isOption
            |> SqlType.asStringOption
        NAMELAST =
            sqlEntity.valueObjectByColumn["NAMELAST"]
            |> SqlType.Parse ContactIdTable.columnsByName["NAMELAST"].schema ContactIdTable.columnsByName["NAMELAST"].isOption
            |> SqlType.asStringOption
        NAMEMID =
            sqlEntity.valueObjectByColumn["NAMEMID"]
            |> SqlType.Parse ContactIdTable.columnsByName["NAMEMID"].schema ContactIdTable.columnsByName["NAMEMID"].isOption
            |> SqlType.asStringOption
        PASSWORD =
            sqlEntity.valueObjectByColumn["PASSWORD"]
            |> SqlType.Parse ContactIdTable.columnsByName["PASSWORD"].schema ContactIdTable.columnsByName["PASSWORD"].isOption
            |> SqlType.asStringOption
        PIN =
            sqlEntity.valueObjectByColumn["PIN"]
            |> SqlType.Parse ContactIdTable.columnsByName["PIN"].schema ContactIdTable.columnsByName["PIN"].isOption
            |> SqlType.asInt32Option
        PRIMARYDUPLICATE =
            sqlEntity.valueObjectByColumn["PRIMARYDUPLICATE"]
            |> SqlType.Parse ContactIdTable.columnsByName["PRIMARYDUPLICATE"].schema ContactIdTable.columnsByName["PRIMARYDUPLICATE"].isOption
            |> SqlType.asInt32
        REQUESTEDNAME =
            sqlEntity.valueObjectByColumn["REQUESTEDNAME"]
            |> SqlType.Parse ContactIdTable.columnsByName["REQUESTEDNAME"].schema ContactIdTable.columnsByName["REQUESTEDNAME"].isOption
            |> SqlType.asStringOption
        SECURITYANSWER =
            sqlEntity.valueObjectByColumn["SECURITYANSWER"]
            |> SqlType.Parse ContactIdTable.columnsByName["SECURITYANSWER"].schema ContactIdTable.columnsByName["SECURITYANSWER"].isOption
            |> SqlType.asStringOption
        STTAXID =
            sqlEntity.valueObjectByColumn["STTAXID"]
            |> SqlType.Parse ContactIdTable.columnsByName["STTAXID"].schema ContactIdTable.columnsByName["STTAXID"].isOption
            |> SqlType.asStringOption
        SUFFIX =
            sqlEntity.valueObjectByColumn["SUFFIX"]
            |> SqlType.Parse ContactIdTable.columnsByName["SUFFIX"].schema ContactIdTable.columnsByName["SUFFIX"].isOption
            |> SqlType.asStringOption
        TITLE =
            sqlEntity.valueObjectByColumn["TITLE"]
            |> SqlType.Parse ContactIdTable.columnsByName["TITLE"].schema ContactIdTable.columnsByName["TITLE"].isOption
            |> SqlType.asStringOption
    })

type InforContact with
    member this._tryContactId = contactIds |> Array.tryFind (fun contactId -> contactId.IDKEY = this.IDKEY)

type InforEmployee with
    member this._tryBannerEmployee =
        bannerEmployees
        |> Array.tryFind (fun bannerEmployee -> this.EMPID.IsSome && this.EMPID.Value = bannerEmployee.ID)
// TODO add Neogov
// TODO add microsoft graph
// TODO add microsoft 365
// TODO add microsoft sharepoint
// TODO add active directory
// TODO add project dox
// TODO add solar winds
// TODO add governmentJobs
// TODO triplify

type Employee = {
    bannerEmployee: BannerEmployee
    inforEmployee: InforEmployee option
    inforContact: InforContact option
    inforContactId: InforContactId option
}

type BannerEmployee with
    member this._tryInforEmployee =
        inforEmployees
        |> Array.tryFind (fun inforEmployee -> inforEmployee.EMPID.IsSome && inforEmployee.EMPID.Value = this.ID)
    member this._tryInforContact =
        employeeContacts
        |> Array.tryFind (fun inforContact ->
            inforContact.EMAIL.IsSome
            && this.EMAIL.IsSome
            && inforContact.EMAIL.Value = this.EMAIL.Value)
    member this._tryInforContactId =
        contactIds
        |> Array.tryFind (fun inforContactId ->
            match inforContactId.NAMEFIRST, inforContactId.NAMELAST with
            | Some firstName, Some lastName when
                firstName.ToLowerInvariant().Trim() = this.FIRSTNAME.ToLowerInvariant().Trim()
                && lastName.ToLowerInvariant().Trim() = this.LASTNAME.ToLowerInvariant().Trim()
                ->
                true
            | _, _ -> false)

    member this._InforDepartmentFolder =
        match this.DEPARTMENT with
        | "Department of Public Works" -> "Public Works"
        | "Office of Information and Technology" -> "Management Information Services"
        | "Administration"
        | "Board of County Commissioners"
        | "Constitutional"
        | "County Attorney's Office"
        | "Department of Development Support & Environmental Management"
        | "Grants Administration"
        | "Judicial"
        | "Non-Operating"
        | "Office of Financial Stewardship"
        | "Office of Human Services & Community Partnerships"
        | "Office of Intervention & Detention Alternatives"
        | "Office of Library Services"
        | "Office of Public Safety"
        | "Office of Resource Stewardship"
        | "Office of Tourist Development"
        | _ -> "Unknown"

    member this._InforSectionFolder =
        match this.DIVISION, this.ORG with
        | "Engineering Services", "Pw Engineering Services" -> "PW - Engineering"
        | "Fleet Management", "Fleet Maintenance" -> "PW - Fleet"
        | "Operations", "Mosquito Control" -> "PW - Mosquito Control"
        | "Operations", "Pw Stormwater Maintenaince" -> "PW - OPS Maintenance"
        | "Operations", "Right-Of-Way Management" -> "PW - OPS ROW"
        | "Operations", "Transportation Maintenance" -> "PW - OPS Traffic"
        | "PW Support Services", "Pw Support Services"
        | _ -> "Unknown"
    member this._InforDepartmentAbbreviation =
        match this.DEPARTMENT with
        | "Department of Public Works" -> "PW"
        | "Office of Information and Technology" -> "MIS"
        | "Administration"
        | "Board of County Commissioners"
        | "Constitutional"
        | "County Attorney's Office"
        | "Department of Development Support & Environmental Management"
        | "Grants Administration"
        | "Judicial"
        | "Non-Operating"
        | "Office of Financial Stewardship"
        | "Office of Human Services & Community Partnerships"
        | "Office of Intervention & Detention Alternatives"
        | "Office of Library Services"
        | "Office of Public Safety"
        | "Office of Resource Stewardship"
        | "Office of Tourist Development"
        | _ -> "Unknown"
let employees =
    bannerEmployees
    |> Array.map (fun bannerEmployee ->
        let maybeInforEmployee = bannerEmployee._tryInforEmployee
        let maybeInforContact =
            bannerEmployee._tryInforEmployee
            |> Option.map (fun inforEmployee -> inforEmployee._contact)
        let maybeInforContactId =
            if maybeInforContact.IsSome then
                maybeInforContact.Value._tryContactId
            else
                bannerEmployee._tryInforContactId

        {
            bannerEmployee = bannerEmployee
            inforEmployee = maybeInforEmployee
            inforContact = maybeInforContact
            inforContactId = maybeInforContactId
        })

module Employee =
    let tryFindFirstLastName (firstName: string) (lastName: string) =
        employees
        |> Array.tryFind (fun employee ->
            employee.bannerEmployee.FIRSTNAME = firstName
            && employee.bannerEmployee.LASTNAME = lastName)
    let tryFindEmail (email: string) =
        employees
        |> Array.tryFind (fun employee ->
            match employee.bannerEmployee.EMAIL with
            | Some bannerEmail when bannerEmail = email -> true
            | _ -> false)
    let filterDivision (division: string) =
        employees
        |> Array.filter (fun employee -> employee.bannerEmployee.DIVISION = division)
    let randomChoice = employees |> Array.randomChoice

[<RequireQualifiedAccess>]
type InforCreateEmployeeDepartment =
    | EmergancyManagementService
    | FacilitiesServices
    | LeonCountyAdministrators
    | ManagementInformationService
    | NonHansen
    | ParksandRecreation
    | PublicServices
    | PublicWorks
    | UnknownDepartment of string

    member this.asString =
        match this with
        | EmergancyManagementService -> "Emergancy Management Service"
        | FacilitiesServices -> "Facilities Services"
        | LeonCountyAdministrators -> "Leon County Administrators"
        | ManagementInformationService -> "Management Information Service"
        | NonHansen -> "Non Hansen"
        | ParksandRecreation -> "Parks and Recreation"
        | PublicServices -> "Public Services"
        | PublicWorks -> "Public Works"
        | UnknownDepartment department -> department

    member this.abbreviation =
        match this with
        | EmergancyManagementService -> "EMS"
        | FacilitiesServices -> "FAC"
        | LeonCountyAdministrators -> "LCADMIN"
        | ManagementInformationService -> "MIS"
        | NonHansen -> "NH"
        | ParksandRecreation -> "PRK"
        | PublicServices -> "PS"
        | PublicWorks -> "PW"
        | UnknownDepartment department -> department

type BannerDepartment =
    | DepartmentofPublicWorks
    | OfficeofInformationandTechnology
    | Administration
    | BoardofCountyCommissioners
    | Constitutional
    | CountyAttorneysOffice
    | DepartmentofDevelopmentSupportAndEnvironmentalManagement
    | GrantsAdministration
    | Judicial
    | Non_Operating
    | OfficeofFinancialStewardship
    | OfficeofHumanServicesAndCommunityPartnerships
    | OfficeofInterventionAndDetentionAlternatives
    | OfficeofLibraryServices
    | OfficeofPublicSafety
    | OfficeofResourceStewardship
    | OfficeofTouristDevelopment
    | UnknownDepartment of string

    member this.asString =
        match this with
        | DepartmentofPublicWorks -> "Department of Public Works"
        | OfficeofInformationandTechnology -> "Office of Information and Technology"
        | Administration -> "Administration"
        | BoardofCountyCommissioners -> "Board of County Commissioners"
        | Constitutional -> "Constitutional"
        | CountyAttorneysOffice -> "County Attorney's Office"
        | DepartmentofDevelopmentSupportAndEnvironmentalManagement -> "Department of Development Support & Environmental Management"
        | GrantsAdministration -> "Grants Administration"
        | Judicial -> "Judicial"
        | Non_Operating -> "Non-Operating"
        | OfficeofFinancialStewardship -> "Office of Financial Stewardship"
        | OfficeofHumanServicesAndCommunityPartnerships -> "Office of Human Services & Community Partnerships"
        | OfficeofInterventionAndDetentionAlternatives -> "Office of Intervention & Detention Alternatives"
        | OfficeofLibraryServices -> "Office of Library Services"
        | OfficeofPublicSafety -> "Office of Public Safety"
        | OfficeofResourceStewardship -> "Office of Resource Stewardship"
        | OfficeofTouristDevelopment -> "Office of Tourist Development"
        | UnknownDepartment department -> department
    member this.fromBannerEmployee(bannerEmployee: BannerEmployee) =
        match bannerEmployee.DEPARTMENT with
        | "Department of Public Works" -> DepartmentofPublicWorks
        | "Office of Information and Technology" -> OfficeofInformationandTechnology
        | "Administration" -> Administration
        | "Board of County Commissioners" -> BoardofCountyCommissioners
        | "Constitutional" -> Constitutional
        | "County Attorney's Office" -> CountyAttorneysOffice
        | "Department of Development Support & Environmental Management" -> DepartmentofDevelopmentSupportAndEnvironmentalManagement
        | "Grants Administration" -> GrantsAdministration
        | "Judicial" -> Judicial
        | "Non-Operating" -> Non_Operating
        | "Office of Financial Stewardship" -> OfficeofFinancialStewardship
        | "Office of Human Services & Community Partnerships" -> OfficeofHumanServicesAndCommunityPartnerships
        | "Office of Intervention & Detention Alternatives" -> OfficeofInterventionAndDetentionAlternatives
        | "Office of Library Services" -> OfficeofLibraryServices
        | "Office of Public Safety" -> OfficeofPublicSafety
        | "Office of Resource Stewardship" -> OfficeofResourceStewardship
        | "Office of Tourist Development" -> OfficeofTouristDevelopment
        | department -> UnknownDepartment department
    member this.asInforCreateEmployeeDepartment =
        // TODO fully map this out for the less common employee types
        match this with
        | DepartmentofPublicWorks -> InforCreateEmployeeDepartment.PublicWorks
        | OfficeofInformationandTechnology -> InforCreateEmployeeDepartment.ManagementInformationService
        | Administration
        | BoardofCountyCommissioners
        | Constitutional
        | CountyAttorneysOffice
        | DepartmentofDevelopmentSupportAndEnvironmentalManagement
        | GrantsAdministration
        | Judicial
        | Non_Operating
        | OfficeofFinancialStewardship
        | OfficeofHumanServicesAndCommunityPartnerships
        | OfficeofInterventionAndDetentionAlternatives
        | OfficeofLibraryServices
        | OfficeofPublicSafety
        | OfficeofResourceStewardship
        | OfficeofTouristDevelopment -> InforCreateEmployeeDepartment.UnknownDepartment this.asString
        | UnknownDepartment department -> InforCreateEmployeeDepartment.UnknownDepartment department

type InforDepartment = {
    departmentName: string
    departmentAbbreviation: string
}

and InforSection = {
    sectionName: string
    sectionAbbreviation: string
    sectionDepartment: InforDepartment
}

module Dept =
    module EMS =
        let Emergancy_Management_Service = {
            departmentName = "Emergancy Management Service"
            departmentAbbreviation = "EMS"
        }

    module FAC =
        let Facilities_Services = {
            departmentName = "Facilities Services"
            departmentAbbreviation = "FAC"
        }

    module LCADMIN =
        let Leon_County_Administrators = {
            departmentName = "Leon County Administrators"
            departmentAbbreviation = "LCADMIN"
        }

    module MIS =
        let Management_Information_Service = {
            departmentName = "Management Information Service"
            departmentAbbreviation = "MIS"
        }

        let Applications = {
            sectionName = "Applications"
            sectionAbbreviation = "APPS"
            sectionDepartment = Management_Information_Service
        }

        let GIS = {
            sectionName = "GIS"
            sectionAbbreviation = "GIS"
            sectionDepartment = Management_Information_Service
        }

        let Network_Services = {
            sectionName = "Network Services"
            sectionAbbreviation = "NTS"
            sectionDepartment = Management_Information_Service
        }

        let Technical_Services_Center = {
            sectionName = "Technical Services Center"
            sectionAbbreviation = "TSC"
            sectionDepartment = Management_Information_Service
        }

    module NH =
        let Non_Hansen = {
            departmentName = "Non Hansen"
            departmentAbbreviation = "NH"
        }

    module PRK =
        let Parks_and_Recreation = {
            departmentName = "Parks and Recreation"
            departmentAbbreviation = "PRK"
        }

    module PS =
        let Public_Services = {
            departmentName = "Public Services"
            departmentAbbreviation = "PS"
        }

    module PW =
        let Public_Works = {
            departmentName = "Public Works"
            departmentAbbreviation = "PW"
        }

        let Construction = {
            sectionName = "Construction"
            sectionAbbreviation = "PCST"
            sectionDepartment = Public_Works
        }

        let Engineering = {
            sectionName = "Engineering"
            sectionAbbreviation = "PENG"
            sectionDepartment = Public_Works
        }

        let Fleet = {
            sectionName = "Fleet"
            sectionAbbreviation = "PFLT"
            sectionDepartment = Public_Works
        }

        let Mosquito_Control = {
            sectionName = "Mosquito Control"
            sectionAbbreviation = "PMOS"
            sectionDepartment = Public_Works
        }

        let Operations_Admin = {
            sectionName = "Operations Admin"
            sectionAbbreviation = "POAD"
            sectionDepartment = Public_Works
        }

        let OPS_Maintenance = {
            sectionName = "OPS Maintenance"
            sectionAbbreviation = "POMT"
            sectionDepartment = Public_Works
        }

        let OPS_ROW = {
            sectionName = "OPS ROW"
            sectionAbbreviation = "PORW"
            sectionDepartment = Public_Works
        }

        let OPS_Traffic = {
            sectionName = "OPS Traffic"
            sectionAbbreviation = "POTF"
            sectionDepartment = Public_Works
        }

        let OPS_Transportation = {
            sectionName = "OPS Transportation"
            sectionAbbreviation = "POTR"
            sectionDepartment = Public_Works
        }

        let Right_of_Way = {
            sectionName = "Right of Way"
            sectionAbbreviation = "ROW"
            sectionDepartment = Public_Works
        }

        let Stormwater_Maintenance = {
            sectionName = "Stormwater Maintenance"
            sectionAbbreviation = "PWSM"
            sectionDepartment = Public_Works
        }

        let Stormwater_Management = {
            sectionName = "Stormwater Management"
            sectionAbbreviation = "STWM"
            sectionDepartment = Public_Works
        }

        let Survey_And_ROW = {
            sectionName = "Survey & ROW"
            sectionAbbreviation = "PSRV"
            sectionDepartment = Public_Works
        }

        let Administration = {
            sectionName = "Administration"
            sectionAbbreviation = "PADM"
            sectionDepartment = Public_Works
        }

type InforCreateEmployeeInformation = {
    Department: InforDepartment
    EmployeeID: string
    LastName: string
    FirstName: string
    MI: string option
    SupervisorID: string option
    HireDate: DateTime
}

type Employee with
    member this.codegenInforCreateEmployeeInformation() =
        Ast.Oak() {
            Ast.AnonymousModule() {
                let MI =
                    match this.bannerEmployee.MIDDLENAME with
                    | Some middleName -> Ast.Constant $"Some(\"{middleName}\")"
                    | None -> Ast.Constant "None"
                let SupervisorID =
                    match this.bannerEmployee.SUPERVISORID with
                    | Some id -> Ast.Constant $"Some(\"{id}\")"
                    | None -> Ast.Constant "None"
                [|
                    Ast.RecordFieldExpr(
                        "Department",
                        $"Dept.{this.bannerEmployee._InforDepartmentAbbreviation}.{(PrettierNaming.VariableBinder this.bannerEmployee._InforDepartmentFolder).binding}"
                    )
                    Ast.RecordFieldExpr("EmployeeID", Ast.String this.bannerEmployee.ID)
                    Ast.RecordFieldExpr("LastName", Ast.String this.bannerEmployee.LASTNAME)
                    Ast.RecordFieldExpr("FirstName", Ast.String this.bannerEmployee.FIRSTNAME)
                    Ast.RecordFieldExpr("MI", MI)
                    Ast.RecordFieldExpr("SupervisorID", SupervisorID)
                    Ast.RecordFieldExpr("HireDate", Ast.Constant($"DateTime.Parse \"{this.bannerEmployee.HIRED}\""))
                |]
                |> Ast.RecordExprValue(this.bannerEmployee.EMAIL.Value |> String.untilCharacter '@')

            }
        }

        |> Gen.mkOak
        |> Gen.run
let targetEmployee = Employee.tryFindEmail "MillsKe@leoncountyfl.gov" |> Option.get

(*
targetEmployee.codegenInforCreateEmployeeInformation().clip
let targetCreateEmployeeInformation = MillsKe
let formCodeInput =
    El.Input * Attr.Id.Equals("__formcodeinput__")
    |> tab.QuerySelectorAllFrames
    |> Array.exactlyOne
let formCode = "REM"
formCodeInput.handle.AsLocator().FillAsync(formCode).await

El.Li * Attr.Class.Equals("contextMenuItem") * Attr.Role.Equals("option")
|> tab.QuerySelectorAllFrames
|> Array.find (fun menuOption -> menuOption.realmElement.textContent.EndsWith($"({formCode})"))
|> MouseButton.Left.Click

let departmentFolder =
    El.A
    * Attr.Id.Equals($"Dept.{targetCreateEmployeeInformation.Department.departmentAbbreviation}")
    |> tab.QuerySelectorAllFrames
    |> Array.exactlyOne
departmentFolder.handle |> MouseButton.Right.Click
El.A * Attr.Href.Equals("#Create Employee")
|> tab.QuerySelectorAllFrames
|> Array.exactlyOne
|> MouseButton.Left.Click

employees
|> Array.choose (fun employee ->
    match employee.inforEmployee with 
    | Some inforEmployee -> 
        match employee.bannerEmployee.DEPARTMENT, inforEmployee.SECT with 
        | "Department of Public Works", Some sectionAbbreviation -> Some(employee.bannerEmployee.ORG, sectionAbbreviation)
        | _, _ -> None
    | _ -> None
    )
|> Array.groupBy (fun (org, sect) -> sect)
|> Array.map (fun (org, pairs) -> org, pairs |> Array.map fst |> Array.distinct)
|> sprintf "%A"
|> String.Clipboard.clip

employees
|> Array.choose (fun employee ->
    match employee.inforEmployee with 
    | Some inforEmployee -> 
        match employee.bannerEmployee.DEPARTMENT, inforEmployee.SECT with 
        | "Department of Public Works", Some sectionAbbreviation -> Some(employee.bannerEmployee.ORG, sectionAbbreviation)
        | _, _ -> None
    | _ -> None
    )
|> Array.groupBy (fun (org, sect) -> org)
|> Array.map (fun (org, pairs) -> org, pairs |> Array.map snd |> Array.distinct)
|> sprintf "%A"
|> String.Clipboard.clip

sprintf "%A" targetEmployee |> String.Clipboard.clip
sprintf "%A" <| Option.get(Employee.tryFindEmail "HayesL@leoncountyfl.gov")  |> String.Clipboard.clip
// TODO find another authoritative source of employee data to reconcile departments and sections 
[|("PENG", [|"Pw Engineering Services"; "Pw Support Services"|]);
("POMT",
[|"Pw Stormwater Maintenaince"; "Transportation Maintenance";
"Right-Of-Way Management"; "Fleet Maintenance"|]);
("POTR",
[|"Transportation Maintenance"; "Fleet Maintenance";
"Pw Stormwater Maintenaince"; "Right-Of-Way Management"|]);
("POTF", [|"Transportation Maintenance"; "Pw Engineering Services"|]);
("PADM", [|"Pw Engineering Services"; "Pw Support Services"|]);
("PWSM", [|"Pw Stormwater Maintenaince"; "Right-Of-Way Management"|]);
("PORW",
[|"Mosquito Control"; "Right-Of-Way Management"; "Transportation Maintenance";
"Pw Stormwater Maintenaince"; "Pw Engineering Services"|]);
("PMOS",
[|"Mosquito Control"; "Pw Stormwater Maintenaince"; "Pw Engineering Services"|]);
("PSRV", [|"Pw Engineering Services"|]);
("POAD",
[|"Mosquito Control"; "Pw Support Services"; "Right-Of-Way Management";
"Pw Stormwater Maintenaince"; "Transportation Maintenance"|]);
("PFLT", [|"Fleet Maintenance"|]); ("PCST", [|"Pw Engineering Services"|]);
("STWM", [|"Pw Stormwater Maintenaince"|]);
("PPCC", [|"Transportation Maintenance"|]);
("ROW", [|"Pw Stormwater Maintenaince"; "Right-Of-Way Management"|])|]

[|("Pw Engineering Services",
[|"PENG"; "PADM"; "PSRV"; "PCST"; "POTF"; "PORW"; "PMOS"|]);
("Pw Stormwater Maintenaince",
[|"POMT"; "PWSM"; "POTR"; "PORW"; "STWM"; "PMOS"; "ROW"; "POAD"|]);
("Transportation Maintenance",
[|"POTR"; "POMT"; "POTF"; "PORW"; "PPCC"; "POAD"|]);
("Fleet Maintenance", [|"POTR"; "PFLT"; "POMT"|]);
("Mosquito Control", [|"PORW"; "PMOS"; "POAD"|]);
("Right-Of-Way Management", [|"PORW"; "POTR"; "POMT"; "POAD"; "PWSM"; "ROW"|]);
("Pw Support Services", [|"PENG"; "PADM"; "POAD"|])|]
*)
(*
employees
|> Array.map (fun employee -> employee.bannerEmployee.DEPARTMENT)
|> Array.distinct
|> Array.sort
|> String.concat "\n"
|> String.Clipboard.SetText

// TODO investigate department mismatches like jon, christian, kinte
employees
|> Array.map (fun employee -> employee.bannerEmployee.DEPARTMENT)
|> Array.distinct
|> Array.sort
|> String.concat "\n"
|> String.Clipboard.SetText
employees
|> Array.filter (fun employee -> employee.bannerEmployee.DEPARTMENT = "Department of Public Works")
|> Array.map (fun employee -> $"{employee.bannerEmployee.DIVISION} - {employee.bannerEmployee.ORG}")
|> Array.distinct
|> Array.sort
|> String.concat "\n"
|> String.Clipboard.SetText
*)
