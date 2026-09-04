#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "UrlErgonomics.dll"

open UrlErgonomics
#r "TaskErgonomics.dll"

open TaskErgonomics
#r "BrowserErgonomics.dll"

open BrowserErgonomics
#r "StringSemantics.dll"

open StringSemantics


open System
open FSharp.Data
open SolarWinds.Api.ServiceDesk.Models
open System.Text.Json
open Refit
open SolarWinds.Api.ServiceDesk.Helpers
open Dubzer.WhatwgUrl
open PuppeteerSharp
open PuppeteerSharp.Cdp
open System.Net.Http
open SolarWinds.Api.ServiceDesk.Interfaces
open System.Threading
open Meziantou.Framework



let jsonOptions =
    JsonSerializerOptions(PropertyNameCaseInsensitive = true, PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower)

let refitSettings = RefitSettings(SystemTextJsonContentSerializer(jsonOptions))

refitSettings.UrlParameterFormatter <- ServiceDeskUrlParameterFormatter()

let ServiceUrl =
    DomUrl "https://leoncountyfl.samanage.com"

    |> DomUrl.AddQueryParameter "layout" "long"
    |> DomUrl.AddQueryParameter "is_portal_mode" false

let home =
    ServiceUrl.AppendPath "incidents?report_id=9641268&assigned_to%5B%5D=10744815&data=state&sort_by=state&sort_order=DESC&state_is_not%5B%5D=758500&state_is_not%5B%5D=758501&state_is_not%5B%5D=758502&state_is_not%5B%5D=793540&state_is_not%5B%5D=800657"


let SolarWindsCookie () =
    task {
        let options = new CreatePageOptions()
        options.Background <- true
        let browser = CdpBrowser.Connect()
        let! backTab = browser.NewPageAsync(options)
        let! response = backTab.GoToAsync(ServiceUrl.asString)
        let request = response.Request

        let cookie =
            match request.Headers.TryGetValue "cookie" with
            | true, value -> value
            | _ -> failwith "The browser request has no cookie header."

        do! backTab.CloseAsync()
        return cookie
    }

let httpClient =
    let client = new HttpClient(BaseAddress = Uri ServiceUrl.Origin)

    client.DefaultRequestHeaders.TryAddWithoutValidation("Cookie", SolarWindsCookie().await)
    |> ignore

    client

module RestService =
    open SolarWinds.Api.ServiceDesk.Interfaces

    let Attachments = RestService.For<IAttachments>(httpClient, refitSettings)
    let Audits = RestService.For<IAudits>(httpClient, refitSettings)
    let CatalogItems = RestService.For<ICatalogItems>(httpClient, refitSettings)
    let Categories = RestService.For<ICategories>(httpClient, refitSettings)
    let ChangeCatalogs = RestService.For<IChangeCatalogs>(httpClient, refitSettings)
    let ChangeRequests = RestService.For<IChangeRequests>(httpClient, refitSettings)
    let Changes = RestService.For<IChanges>(httpClient, refitSettings)
    let Comments = RestService.For<IComments>(httpClient, refitSettings)

    let ConfigurationItems =
        RestService.For<IConfigurationItems>(httpClient, refitSettings)

    let Contracts = RestService.For<IContracts>(httpClient, refitSettings)
    let CustomFields = RestService.For<ICustomFields>(httpClient, refitSettings)
    let CustomForms = RestService.For<ICustomForms>(httpClient, refitSettings)
    let Dashboards = RestService.For<IDashboards>(httpClient, refitSettings)
    let Departments = RestService.For<IDepartments>(httpClient, refitSettings)
    let Groups = RestService.For<IGroups>(httpClient, refitSettings)
    let Hardwares = RestService.For<IHardwares>(httpClient, refitSettings)
    let Incidents = RestService.For<IIncidents>(httpClient, refitSettings)
    let IncidentTypes = RestService.For<IIncidentTypes>(httpClient, refitSettings)
    let Memberships = RestService.For<IMemberships>(httpClient, refitSettings)
    let MobileDevices = RestService.For<IMobileDevices>(httpClient, refitSettings)
    let Notifications = RestService.For<INotifications>(httpClient, refitSettings)
    let OtherAssets = RestService.For<IOtherAssets>(httpClient, refitSettings)
    let Printers = RestService.For<IPrinters>(httpClient, refitSettings)
    let Problems = RestService.For<IProblems>(httpClient, refitSettings)
    let PurchaseOrders = RestService.For<IPurchaseOrders>(httpClient, refitSettings)

    let PurchaseOrdersApi =
        RestService.For<IPurchaseOrdersApi>(httpClient, refitSettings)

    let Purchases = RestService.For<IPurchases>(httpClient, refitSettings)
    let Releases = RestService.For<IReleases>(httpClient, refitSettings)

    let ResponseTemplates =
        RestService.For<IResponseTemplates>(httpClient, refitSettings)

    let Risks = RestService.For<IRisks>(httpClient, refitSettings)
    let Roles = RestService.For<IRoles>(httpClient, refitSettings)
    let ServiceRequests = RestService.For<IServiceRequests>(httpClient, refitSettings)
    let SetupItsmStates = RestService.For<ISetupItsmStates>(httpClient, refitSettings)
    let Sites = RestService.For<ISites>(httpClient, refitSettings)
    let Softwares = RestService.For<ISoftwares>(httpClient, refitSettings)
    let Solutions = RestService.For<ISolutions>(httpClient, refitSettings)
    let Tasks = RestService.For<ITasks>(httpClient, refitSettings)
    let Tickets = RestService.For<ITickets>(httpClient, refitSettings)
    let TimeTracks = RestService.For<ITimeTracks>(httpClient, refitSettings)
    let UiCustomViews = RestService.For<IUiCustomViews>(httpClient, refitSettings)
    let UiInfrastructure = RestService.For<IUiInfrastructure>(httpClient, refitSettings)
    let UiJsonHtmlLists = RestService.For<IUiJsonHtmlLists>(httpClient, refitSettings)
    let Users = RestService.For<IUsers>(httpClient, refitSettings)
    let Vendors = RestService.For<IVendors>(httpClient, refitSettings)
    let Widgets = RestService.For<IWidgets>(httpClient, refitSettings)

    let WorkflowApprovers =
        RestService.For<IWorkflowApprovers>(httpClient, refitSettings)








type IIncidents with

    member this.Get(request: GetIncidentsRequest) =

        request.Layout <- ResponseLayout.Long

        task {

            return! this.GetAsync(request, CancellationToken.None)

        }

        |> await

        |> Seq.toArray

    member this.GetId(id: int) =

        task {

            return! this.GetAsync(id, ResponseLayout.Long, CancellationToken.None)

        }

        |> await












let incidents =
    let request = GetIncidentsRequest()

    request.CreatedFrom <- DateTime.Today
    request.ReportId <- 9641268
    RestService.Incidents.Get request





(*
incidentsCustomView
|> Array.map (fun  column ->
    let columnName = column.name.JsonValue.AsString()
    let identifier =
        match Int32.TryParse (columnName) with
        |true, _ -> column.label + columnName
        | false, _  -> columnName
    let parameterValue =
        match column.``type`` with
            | "attachment_input" -> "parameterValue"
            | "Checkbox" -> "parameterValue"
            | "Date_and_Time" -> "parameterValue"
            | "date" -> "parameterValue"
            | "Date" -> "parameterValue"
            | "Dropdown" -> "parameterValue"
            | "multi_picklist" -> "parameterValue"
            | "Number" -> "parameterValue"
            | "select" -> "parameterValue"
            | "select2" -> "parameterValue"
            | "Text_Area" -> "parameterValue"
            | "text" -> "parameterValue"
            | "Text" -> "(parameterValue : string) "
            | "user" -> "parameterValue"
            | "User" -> "parameterValue"
            | _ -> "parameterValue"
    $"let {identifier.normalizedFSharpIdentifier} {parameterValue}  (resourceReference:ResourceReference) = resourceReference |> ResourceReference.AddQueryParameter \"{columnName}\" parameterValue"

    )
|> Array.distinct
|> Array.sort
|> String.concat "\n" |> clip

*)
module Users =
    let resourceReference = ServiceUrl.AppendPath "users.jsonhtml"

    [<Literal>]
    let jsonHtmlPath =
        @"D:\Iri\https\leoncountyfl.samanage.com\users.jsonhtml\bare\users.jsonhtml"

    type Provider = JsonProvider<UseOriginalNames=true, PreferDateOnly=true, OmitNullFields=true, RootName="jsonhtml", Sample=jsonHtmlPath>

    let jsonhtml = Provider.Load jsonHtmlPath

Users.jsonhtml.count







(*
[|
    "Attachments"
    "Audits"
    "CatalogItems"
    "Categories"
    "ChangeCatalogs"
    "ChangeRequests"
    "Changes"
    "Comments"
    "ConfigurationItems"
    "Contracts"
    "CustomFields"
    "CustomForms"
    "Dashboards"
    "Departments"
    "Groups"
    "Hardwares"
    "Incidents"
    "IncidentTypes"
    "Memberships"
    "MobileDevices"
    "Notifications"
    "OtherAssets"
    "Printers"
    "Problems"
    "PurchaseOrders"
    "PurchaseOrdersApi"
    "Purchases"
    "Releases"
    "ResponseTemplates"
    "Risks"
    "Roles"
    "ServiceRequests"
    "SetupItsmStates"
    "Sites"
    "Softwares"
    "Solutions"
    "Tasks"
    "Tickets"
    "TimeTracks"
    "UiCustomViews"
    "UiInfrastructure"
    "UiJsonHtmlLists"
    "Users"
    "Vendors"
    "Widgets"
    "WorkflowApprovers"
|]
|> Array.map (fun SolarWindsInterface ->
$"""
module {SolarWindsInterface} =
    let restService = RestService.For<I{SolarWindsInterface}> (httpClient, refitSettings)
"""

)
|> String.concat "\n"
|> clip

*)





module SolarWindsFilter =
    let assigned_to parameterValue (resourceReference: DomUrl) =
        resourceReference
        |> DomUrl.AddQueryParameter "2327702" parameterValue




// https://leoncountyfl.samanage.com/incidents?report_id=9641268
// &applied=true
// &title%5B%5D=test
// &sort_by=state
// &sort_order=DESC
// &data=state
// &columns=requester%2Ctitle%2Cstate%2Csub_type%2Ctype%2Csite%2Cdepartment%2Cassigned_to%2Cpriority%2Ccreated_at%2Ccreated_by%2Ctag_list%2Cnumber%2Cslm%2Cpreview




[<Literal>]
let incidentsFilterFilePath =
    @"D:\Iri\https\leoncountyfl.samanage.com\filters.json\context\incidents\is_portal_mode\False\layout\long\bare\filters.json"

type IncidentsFilterProvider = JsonProvider<UseOriginalNames=true, PreferDateOnly=true, OmitNullFields=true, RootName="filters", Sample=incidentsFilterFilePath>



[<Literal>]
let incidentsMetadataFilePath =
    @"D:\Iri\https\leoncountyfl.samanage.com\custom_views\incidents\metadata.json\assigned_to[]\10744815\data\state\is_portal_mode\false\report_id\9641268\sort_by\state\sort_order\DESC\state_is_not[]\758500\758501\758502\793540\800657\bare\metadata.json"

type IncidentsMetadataProvider = JsonProvider<UseOriginalNames=true, PreferDateOnly=true, OmitNullFields=true, RootName="metadata", Sample=incidentsMetadataFilePath>


[<Literal>]
let incidentsCustomViewFilePath =
    @"D:\Iri\https\leoncountyfl.samanage.com\custom_views\incidents.json\is_portal_mode\false\report_id\9641268\bare\incidents.json"

type IncidentsCustomViewProvider = JsonProvider<UseOriginalNames=true, PreferDateOnly=true, OmitNullFields=true, RootName="column", Sample=incidentsCustomViewFilePath>




let incidentsMetadata = IncidentsMetadataProvider.Load incidentsMetadataFilePath

let incidentsCustomView =
    IncidentsCustomViewProvider.Load incidentsCustomViewFilePath

let incidentsFilters = IncidentsFilterProvider.Load(incidentsFilterFilePath)

let titleFilter (title: string) (resource: DomUrl) =
    resource |> DomUrl.AddQueryParameter "title" title

let viewIncidents (resource: DomUrl) =
    resource
    |> DomUrl.AddQueryParameter "report_id" 9641268
    |> DomUrl.AddQueryParameter "applied" true





let filterTypes =
    incidentsCustomView
    |> Array.map (fun column -> column.``type``)
    |> Array.distinct
    |> Array.sort


ServiceUrl.AppendPath "incidents.json"
|> DomUrl.AddQueryParameter "applied" true
|> DomUrl.AddQueryParameter "data" "state"
|> SolarWindsFilter.assigned_to 10744815

let testFilter =
    DomUrl "https://leoncountyfl.samanage.com/incidents?assigned_to_is_not%5B%5D=10744815&created_by%5B%5D=10899501&report_id=9702975&state_is_not%5B%5D=758500&state_is_not%5B%5D=758501&state_is_not%5B%5D=758502&state_is_not%5B%5D=793540&state_is_not%5B%5D=800657"

testFilter.QueryStringParameters

let metadataTest =
    DomUrl
        "https://leoncountyfl.samanage.com/custom_views/incidents/metadata.json?assigned_to%5B%5D=10744815&data=state&report_id=9641268&sort_by=state&sort_order=DESC&state_is_not%5B%5D=758500&state_is_not%5B%5D=758501&state_is_not%5B%5D=758502&state_is_not%5B%5D=793540&state_is_not%5B%5D=800657&is_portal_mode=false"

metadataTest.AbsolutePathName

let incidentFilters =
    ServiceUrl.AppendPath "filters.json"
    |> DomUrl.AddQueryParameter "context" "incidents"

incidentFilters.asFile.FullName |> clip
// // D:\Iri\https\leoncountyfl.samanage.com\filters.json\context\incidents\is_portal_mode\False\layout\long\bare\filters.json

// incidentFilters.DownloadFileText()
// incidentFilters.asFile.DirectoryName |> clip






(*

incidentsFilters
|> Array.map (fun filter ->
    filter.optionsUrl
    |> Option.map (fun optionsUrl ->
        ServiceUrl.Origin + optionsUrl
        |> DomUrl

        |> _.HeadedDownloadText()
        )
)

*)
let testTitleFilter =
    DomUrl
        "https://leoncountyfl.samanage.com/incidents?report_id=9641268&applied=true&columns=requester%2Ctitle%2Cstate%2Csub_type%2Ctype%2Csite%2Cdepartment%2Cassigned_to%2Cpriority%2Ccreated_at%2Ccreated_by%2Ctag_list%2Cnumber%2Cslm%2Cpreview&data=state&sort_by=state&sort_order=DESC&title%5B%5D=test"

testTitleFilter.QueryStringParameters

let testOption =
    ServiceUrl.Origin
    + incidentsFilters[1].optionsUrl.Value
    |> DomUrl

testOption
QueryStringUtilities.ParseQuery incidentsFilters[1].optionsUrl.Value

let queryDelimiterIndex =
    incidentsFilters[1]
        .optionsUrl.Value.IndexOf ('?')

// https://leoncountyfl.samanage.com/incidents/filter_values.json?filter=number_of_reassignments
