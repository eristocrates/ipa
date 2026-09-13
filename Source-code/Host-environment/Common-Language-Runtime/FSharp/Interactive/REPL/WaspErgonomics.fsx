(*

& "C:\Program Files\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9222 --user-data-dir=C:\temp\chrome-automation


& "C:\Program Files\Mozilla Firefox\firefox.exe" --remote-debugging-port 9223
*)

// TODO add gnd to known ontologies https:-nb.info/standards/elementset/gnd2012-06-30

#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\fsx"
#r "TaskErgonomics.dll"
open TaskErgonomics
#r "PageErgonomics.dll"

open PageErgonomics
#r "IanaSchemes.dll"
open IanaSchemes
#r "UrlErgonomics.dll"

open UrlErgonomics

#r "BrowserErgonomics.dll"
open BrowserErgonomics

#r "ResourceErgonomics.dll"
open ResourceErgonomics

#r "RdfAsm.dll"
open RdfAsm

open System.Configuration
open System.Collections.Specialized
open System
open System.Reflection
open PuppeteerSharp
open PuppeteerSharp.Cdp
open Dubzer.WhatwgUrl
open System.IO
open System.Net
open WebDriverBiDi
open WebDriverBiDi.Session
open WebDriverBiDi.BrowsingContext
open FolkerKinzel.MimeTypes
open BrowserApi.Css.Authoring
open FSharp.Data
open FsHttp
open System.Threading
open Newtonsoft.Json
open ktsu.Semantics.Paths
open Meziantou.Framework
open Microsoft.AspNetCore.Http
module FSharpLiteral = FSharp.Literals.Literal

#r "nuget: AssetCloudPublicAPI, 3.0.12.30977"
open Wasp.Cloud.Asset.API

open TextCopy

let clipboard = new Clipboard()
let clip (text:string) = clipboard.SetText text

#load @"C:\Secret\WaspSecrets.fsx"

type WaspApi<'Request, 'Response> = 
    {
        parameters:'Request
    }

let myEmployeeNumber = 1083


            
let chrome = CdpBrowser.Connect()

let waspTab = chrome.NewPageAsync().await.asCdp



type WaspPublicApiClient(PublicApiToken:string,PublicApiBaseAddress:string ) = 

    let appSettings =
        ConfigurationManager.AppSettings

    let readOnlyField =
        typeof<NameObjectCollectionBase>
            .GetField("_readOnly",
                Reflection.BindingFlags.Instance
                ||| Reflection.BindingFlags.NonPublic)

    do readOnlyField.SetValue(appSettings, false)

    do appSettings["PublicApiToken"] <- PublicApiToken
    do appSettings["PublicApiBaseAddress"] <- PublicApiBaseAddress

    let AddressPublicApiClient = new ApiAddressPublicApiClient(PublicApiBaseAddress)
    let AssetPurchaseOrderPublicApiClient = new ApiAssetPurchaseOrderPublicApiClient(PublicApiBaseAddress)
    let AssetsPublicApiClient = new ApiAssetsPublicApiClient(PublicApiBaseAddress)
    let AssetTypesPublicApiClient = new ApiAssetTypesPublicApiClient(PublicApiBaseAddress)
    let AttachmentsPublicApiClient = new ApiAttachmentsPublicApiClient(PublicApiBaseAddress)
    let ContractsPublicApiClient = new ApiContractsPublicApiClient(PublicApiBaseAddress)
    let CustomerPublicApiClient = new ApiCustomerPublicApiClient(PublicApiBaseAddress)
    let DepartmentsPublicApiClient = new ApiDepartmentsPublicApiClient(PublicApiBaseAddress)
    let EmployeePublicApiClient = new ApiEmployeePublicApiClient(PublicApiBaseAddress)
    let FundingPublicApiClient = new ApiFundingPublicApiClient(PublicApiBaseAddress)
    let ItemOrderPublicApiClient = new ApiItemOrderPublicApiClient(PublicApiBaseAddress)
    let LocationsPublicApiClient = new ApiLocationsPublicApiClient(PublicApiBaseAddress)
    let ManufacturersPublicApiClient = new ApiManufacturersPublicApiClient(PublicApiBaseAddress)
    let PhonePublicApiClient = new ApiPhonePublicApiClient(PublicApiBaseAddress)
    let SitesPublicApiClient = new ApiSitesPublicApiClient(PublicApiBaseAddress)
    let SystemInfoPublicApiClient = new ApiSystemInfoPublicApiClient(PublicApiBaseAddress)
    let TransactionsPublicApiClient = new ApiTransactionsPublicApiClient(PublicApiBaseAddress)
    let VendorPublicApiClient = new ApiVendorPublicApiClient(PublicApiBaseAddress)
    member this.ApiAddress = AddressPublicApiClient
    member this.ApiAssetPurchaseOrder = AssetPurchaseOrderPublicApiClient
    member this.ApiAssets = AssetsPublicApiClient
    member this.ApiAssetTypes = AssetTypesPublicApiClient
    member this.ApiAttachments = AttachmentsPublicApiClient
    member this.ApiContracts = ContractsPublicApiClient
    member this.ApiCustomer = CustomerPublicApiClient
    member this.ApiDepartments = DepartmentsPublicApiClient
    member this.ApiEmployee = EmployeePublicApiClient
    member this.ApiFunding = FundingPublicApiClient
    member this.ApiItemOrder = ItemOrderPublicApiClient
    member this.ApiLocations = LocationsPublicApiClient
    member this.ApiManufacturers = ManufacturersPublicApiClient
    member this.ApiPhone = PhonePublicApiClient
    member this.ApiSites = SitesPublicApiClient
    member this.ApiSystemInfo = SystemInfoPublicApiClient
    member this.ApiTransactions = TransactionsPublicApiClient
    member this.ApiVendor = VendorPublicApiClient

[<RequireQualifiedAccess>]
type HTTPMethod = 
    | DELETE
    | GET
    | PATCH
    | POST
    | PUT
    static member fromString (rawMethod:string) = 
        match rawMethod with 
        | "DELETE" -> DELETE
        | "GET" -> GET
        | "PATCH" -> PATCH
        | "POST" -> POST
        | "PUT" -> PUT
    member this.asString = this.ToString()
type WaspApiCall = 
    {
        publicApiClient:string
        httpMethod:HTTPMethod
        apiEndpoint:PathString
        methodName:string
        description:string
    }
    member this.apiId = sprintf "%s-%s" this.httpMethod.asString (this.apiEndpoint.Value[1..].Replace(" ","-").Replace("/","-").Replace("{","").Replace("}",""))

    // 

type WaspSite = 
    {
        siteRoot:AbsoluteRoot
    }
    member this.localDirectory = Directory.CreateDirectory this.siteRoot.localReference
    member this.GetPublicApiClient (PublicApiToken:string) = WaspPublicApiClient(PublicApiToken, this.siteRoot.remoteReference)
    member this.resource (resourcePath:string) = this.siteRoot ./ resourcePath
    member this.Login = this.resource "Account/Login"
    member this.FixedAssets = this.resource "FixedAssets/index"
    member this.ApiList = this.resource "Help/Api"
    member this.Details (apiCall:WaspApiCall) = this.resource $"Help/Details?apiId={apiCall.apiId}"
    member this.ResourceModel (modelName:string) = this.resource $"Help/ResourceModel?modelName={modelName}"






module https = 
    open https
    module com = 
        module waspassetcloud = 
            let help = 
                { siteRoot = https "help.waspassetcloud.com" }
            let myfuelmaster = { siteRoot = https "myfuelmaster.waspassetcloud.com" }




type ResolvedResource with 
    member this.downloadResponseHtml(tab:CdpPage) =

        let response =  tab.GoToAsync(this.remoteReference).await.asCdp
        let responseText = response.TextAsync().await
        if responseText.Contains("Oops! Page not found. Please contact the Administrator.") then 
            ()
        else
            let responsePath  =
                AbsolutePath.Create(this.localReference.Split( 
                [|
                    '?'
                    '='
                    '-'
                    '\\'
                 |]) 
                 |> String.concat "\\"
                )

            let responseFilePath = responsePath.As<AbsoluteFilePath>().WithSuffix ".html"
            Directory.CreateDirectory responseFilePath.AbsoluteDirectoryPath.WeakString |> ignore
            File.WriteAllText(responseFilePath.WeakString, responseText )




// https.com.waspassetcloud.help.ApiList.downloadHtml waspTab

module WaspSite = 
            module Help = 
                module API = 
                        [<Literal>]
                        let sampleHtmlFilePath = @"C:\https\com\waspassetcloud\help\Help\Api.html"
                        type Provider = HtmlProvider<PreferOptionals = true, Sample = sampleHtmlFilePath>
                        let htmlTables = Provider.Load(sampleHtmlFilePath).Tables
                        (*
                    let Details (api:string) = myfuelmaster ./ sprintf "Help/Details?apiId=%s" (api.Replace(" ","-").Replace("/","-"))
                module public_api = 
                    module employees = 
                        let checkout_status (EmployeeNumber:int) = myfuelmaster ./ $"public-api/employees/checkout-status/{EmployeeNumber}"
                        let myCheckoutStatus = checkout_status myEmployeeNumber

            *)



type ApiEmployeePublicApiClient with 
    static member ApiCalls = 
        let htmlTable = WaspSite.Help.API.htmlTables.ApiEmployeePublicApiClient
        htmlTable.Rows
        |> Array.map (fun row ->  
        
        let httpMethod, apiEndpoint = 
            match row.API.Split(" ",StringSplitOptions.TrimEntries) with 
            | [| method ; endpoint|] -> method, PathString $"/{endpoint}"

        {
            publicApiClient = htmlTable.Name
            httpMethod = HTTPMethod.fromString httpMethod
            apiEndpoint = apiEndpoint
            methodName = row.``Method Name``
            description = row.Description
        } 
        )





type ApiAssetPurchaseOrderPublicApiClient with 
    static member ApiCalls = 
        let htmlTable = WaspSite.Help.API.htmlTables.ApiAssetPurchaseOrderPublicApiClient
        htmlTable.Rows
        |> Array.map (fun row ->  
        
        let httpMethod, apiEndpoint = 
            match row.API.Split(" ",StringSplitOptions.TrimEntries) with 
            | [| method ; endpoint|] -> method, PathString $"/{endpoint}"

        {
            publicApiClient = htmlTable.Name
            httpMethod = HTTPMethod.fromString httpMethod
            apiEndpoint = apiEndpoint
            methodName = row.``Method Name``
            description = row.Description
        } 
        )




type ApiAssetsPublicApiClient with 
    static member ApiCalls = 
        let htmlTable = WaspSite.Help.API.htmlTables.ApiAssetsPublicApiClient
        htmlTable.Rows
        |> Array.map (fun row ->  
        
        let httpMethod, apiEndpoint = 
            match row.API.Split(" ",StringSplitOptions.TrimEntries) with 
            | [| method ; endpoint|] -> method, PathString $"/{endpoint}"

        {
            publicApiClient = htmlTable.Name
            httpMethod = HTTPMethod.fromString httpMethod
            apiEndpoint = apiEndpoint
            methodName = row.``Method Name``
            description = row.Description
        } 
        )


type ApiAssetTypesPublicApiClient with 
    static member ApiCalls = 
        let htmlTable = WaspSite.Help.API.htmlTables.ApiAssetTypesPublicApiClient
        htmlTable.Rows
        |> Array.map (fun row ->  
        
        let httpMethod, apiEndpoint = 
            match row.API.Split(" ",StringSplitOptions.TrimEntries) with 
            | [| method ; endpoint|] -> method, PathString $"/{endpoint}"

        {
            publicApiClient = htmlTable.Name
            httpMethod = HTTPMethod.fromString httpMethod
            apiEndpoint = apiEndpoint
            methodName = row.``Method Name``
            description = row.Description
        } 
        )



type ApiDepartmentsPublicApiClient with 
    static member ApiCalls = 
        let htmlTable = WaspSite.Help.API.htmlTables.ApiDepartmentsPublicApiClient
        htmlTable.Rows
        |> Array.map (fun row ->  
        
        let httpMethod, apiEndpoint = 
            match row.API.Split(" ",StringSplitOptions.TrimEntries) with 
            | [| method ; endpoint|] -> method, PathString $"/{endpoint}"

        {
            publicApiClient = htmlTable.Name
            httpMethod = HTTPMethod.fromString httpMethod
            apiEndpoint = apiEndpoint
            methodName = row.``Method Name``
            description = row.Description
        } 
        )



type ApiItemOrderPublicApiClient with 
    static member ApiCalls = 
        let htmlTable = WaspSite.Help.API.htmlTables.ApiItemOrderPublicApiClient
        htmlTable.Rows
        |> Array.map (fun row ->  
        
        let httpMethod, apiEndpoint = 
            match row.API.Split(" ",StringSplitOptions.TrimEntries) with 
            | [| method ; endpoint|] -> method, PathString $"/{endpoint}"

        {
            publicApiClient = htmlTable.Name
            httpMethod = HTTPMethod.fromString httpMethod
            apiEndpoint = apiEndpoint
            methodName = row.``Method Name``
            description = row.Description
        } 
        )


type WaspPublicApiClient with 
    member this.ApiCalls = 
        Array.concat [|
            ApiEmployeePublicApiClient.ApiCalls
            ApiAssetPurchaseOrderPublicApiClient.ApiCalls
            ApiAssetsPublicApiClient.ApiCalls
            ApiAssetTypesPublicApiClient.ApiCalls
            ApiDepartmentsPublicApiClient.ApiCalls
            ApiItemOrderPublicApiClient.ApiCalls
        |]
    member this.ApiCallMap = this.ApiCalls |> Array.map (fun apiCall -> apiCall.methodName, apiCall) |> Map.ofArray





(*


ApiEmployeePublicApiClient.ApiCalls
|> Array.iter (fun apiCall -> 
    Thread.Sleep 1000
    (https.com.waspassetcloud.help.Details apiCall).downloadResponseHtml waspTab)

ApiAssetPurchaseOrderPublicApiClient.ApiCalls
|> Array.iter (fun apiCall -> 
    Thread.Sleep 1000
    (https.com.waspassetcloud.help.Details apiCall).downloadResponseHtml waspTab)

ApiAssetsPublicApiClient.ApiCalls
|> Array.iter (fun apiCall -> 
    Thread.Sleep 1000
    (https.com.waspassetcloud.help.Details apiCall).downloadResponseHtml waspTab)

    
ApiAssetTypesPublicApiClient.ApiCalls
|> Array.iter (fun apiCall -> 
    Thread.Sleep 1000
    (https.com.waspassetcloud.help.Details apiCall).downloadResponseHtml waspTab)

ApiDepartmentsPublicApiClient.ApiCalls
|> Array.iter (fun apiCall -> 
    Thread.Sleep 1000
    (https.com.waspassetcloud.help.Details apiCall).downloadResponseHtml waspTab)
ApiItemOrderPublicApiClient.ApiCalls
|> Array.iter (fun apiCall -> 
    Thread.Sleep 1000
    (https.com.waspassetcloud.help.Details apiCall).downloadResponseHtml waspTab)








AssetReceiveInfoLineItemModel().GetType().Assembly.DefinedTypes
|> Seq.filter (fun definedType -> not (definedType.Name.EndsWith("PublicApiClient")))
|> Seq.iter (fun definedType ->  
    Thread.Sleep 1000
    (https.com.waspassetcloud.help.ResourceModel definedType.Name).downloadResponseHtml waspTab)
    







waspTab.GoToAsync(https.com.waspassetcloud.myfuelmaster.Login.remoteReference).await
waspTab.GoToAsync(https.com.waspassetcloud.myfuelmaster.FixedAssets.remoteReference).await

let ExportButton = waspTab.Locator(El.Button * Attr.Id.Equals("dropDownFileTypeMenu1") |> _.Css)
let ExcelOptionListItem = waspTab.Locator(El.Li * Attr.Id.Equals("dropDownExcelOption") |> _.Css)

let latestFile = FileInfo @"C:\Repositories\eristocrates\ipa\fsx\Latest.xlsx"

let ExportXLSX() = 
    let mutable waitCounter = 0

    let rec downloadedFile (clickTime:DateTime)(testTime:DateTime) = 
        let xlsxFile = sprintf  @"C:\Users\tfisher\Downloads\Assets %s.xlsx" (testTime.ToString("M_dd_yyyy h_mm_ss tt")) |> FileInfo
        if (not (xlsxFile.Exists) && waitCounter < 15) then
            printfn "%d waiting for %s" waitCounter xlsxFile.FullName
            Thread.Sleep 1000
            waitCounter <- waitCounter + 1
            let remainder = waitCounter % 3
            downloadedFile clickTime (clickTime.AddSeconds remainder)
        else xlsxFile


    ExportButton.ClickAsync().await
    ExcelOptionListItem.ClickAsync().await
    let clickTime = DateTime.Now

    let xlsxFile = downloadedFile clickTime clickTime
    if xlsxFile.Exists then
        File.Move(xlsxFile.FullName, latestFile.FullName,  true)
        printfn "%s found, moved to %s"  xlsxFile.FullName latestFile.FullName
    else 
        printfn "%s not found" xlsxFile.FullName


ExportXLSX()

*)


ApiEmployeePublicApiClient.ApiCalls |> Array.map (fun apiCall -> $"{apiCall.httpMethod} {apiCall.apiEndpoint}") |> String.concat "\n"

ApiAssetsPublicApiClient.ApiCalls

let waspClient = https.com.waspassetcloud.myfuelmaster.GetPublicApiClient WaspSecrets.PublicApiToken

waspClient.ApiCalls |> Array.filter (fun apiCall -> apiCall.apiEndpoint.Value.Contains("Asset"))

type ApiAssetsPublicApiClient with 
    member this.AssetInfoSearchAsync(searchPattern:string) = 
        let searchParameters = AssetContainsSearchParameters()
        searchParameters.SearchPattern <- searchPattern
        Json.Deserialize searchPattern
        this.AssetInfoSearchAsync(searchParameters)
    member this. AssetInfoSearchAsync() = this.AssetInfoSearchAsync(String.Empty)



type KeyValuePair<'Key,'Value> = 
    {
        Key:'Key
        Value:'Value
    }

type HTTPHeader = KeyValuePair<string,string>
type HTTPQuery = KeyValuePair<string,string>


type WaspPublicApiBody = 
        // | AdvancedSearchBody of AdvancedSearchParameters
        | PurchaseOrderStatusBody of PurchaseOrderStatusParameters
        | AssetContainsBody of AssetContainsSearchParameters
        | AssetTypeContainsBody of AssetTypeContainsSearchParameters
        | DepartmentContainsBody of DepartmentContainsSearchParameters
        | EmployeeContainsBody of EmployeeContainsSearchParameters
        | SiteContainsBody of SiteContainsSearchParameters



type HTTPConnector = 
    {
        URI:Uri
        Method: HTTPMethod
        Headers: HTTPHeader array
        Queries: HTTPQuery array
        // Body: WaspPublicApiBody
        Cookie:string option
    }
    static member baseUri = Uri("https://myfuelmaster.waspassetcloud.com/", UriKind.Absolute)
    (*
    
    member this.setBody(searchPattern:string) = 
        let searchParameters = AssetContainsSearchParameters()
        searchParameters.SearchPattern <- searchPattern
        {
            this with Body = Some (Json.Deserialize searchPattern)
        }
    member this.setBody() = this.setBody String.Empty
        *)

    member this.clipURI() = clip this.URI.OriginalString
    member this.clipMethod() = clip this.Method.asString
    member this.clipHeaderAuthorizationKey = clip this.Headers[0].Key 
    member this.clipHeaderBearerValue = clip this.Headers[0].Value
type WaspApiCall with 
    member this.asHTTPConnector = 

        {
            URI = Uri(https.com.waspassetcloud.myfuelmaster.siteRoot.asRemoteUri, this.apiEndpoint.Value)
            Method = this.httpMethod
            Headers = [| {Key = "Authorization" ; Value = $"Bearer {WaspSecrets.PublicApiToken}" }|]
            Queries = [||]
            // Body = None
            Cookie = None
        }

type HTTPConnector with 
        static member fromWaspApiCall(waspApiCall:WaspApiCall) = waspApiCall.asHTTPConnector

type WaspPublicApiClient with
    member this.HTTPConnectorByMethodName (methodName:string)=  this.ApiCallMap[methodName].asHTTPConnector


let PublicApiClients = 
    typeof<ApiAssetsPublicApiClient>.Assembly.DefinedTypes
    |> Seq.toArray
    |> Array.filter (fun definedType -> definedType.Name.EndsWith("PublicApiClient"))


let PublicApiAsyncMethods = 
    PublicApiClients
    |> Array.collect (fun PublicApiClient -> 
        PublicApiClient.DeclaredMethods
        |> Seq.toArray
        |> Array.filter (fun declaredMethod -> declaredMethod.Name.EndsWith("Async"))
    )
type WaspApiCall with 
    member this.methodInfo = 
        typeof<ApiAssetsPublicApiClient>.Assembly.DefinedTypes
        |> Seq.choose (fun definedType -> 
            if definedType.Name.EndsWith("PublicApiClient") then
                definedType.DeclaredMethods |> Seq.tryFind (fun declaredMethod -> declaredMethod.Name = this.methodName)
            else
                None
            )


let PublicApiAsyncMethodParameters = 
    PublicApiAsyncMethods
    |> Array.collect (fun asyncMethod ->  
        asyncMethod.GetParameters()
        |> Array.map (fun parameter -> parameter.Name, FSharpLiteral.stringifyTypeDynamic parameter.ParameterType)
    )
    |> Array.distinct

let parameterTypes = 

    typeof<ApiAssetsPublicApiClient>.Assembly.DefinedTypes
    |> Seq.toArray
    |> Array.filter (fun definedType -> definedType.Name.EndsWith("PublicApiClient"))
    |> Array.collect (fun PublicApiClient -> 
        PublicApiClient.DeclaredMethods
        |> Seq.toArray
        |> Array.filter (fun declaredMethod -> declaredMethod.Name.EndsWith("Async"))
        |> Array.map (fun declaredMethod -> PublicApiClient, declaredMethod)
    )
    |> Array.collect (fun (PublicApiClient, declaredMethod) ->  
        declaredMethod.GetParameters()
        |> Array.map (fun parameter -> PublicApiClient.Name, declaredMethod.Name, parameter.Name, FSharpLiteral.stringifyTypeDynamic parameter.ParameterType)
    )
    |> Array.distinct
    |> Array.filter (fun (clientName, methodName, parameterName, parameterTypeName) ->  
        match clientName, methodName, parameterName, parameterTypeName  with 
        | _, _, "cancellationToken", _ -> false
        | _, _, "response", _ -> false
        | _, _, "headers", _ -> false
        | _, _, _, _ -> true
        
        )
    |> Array.sort 




let waspResult =  waspClient.ApiAssets.AssetInfoSearchAsync().await

waspResult.Data[1]


let searchParameters = AssetContainsSearchParameters()
searchParameters.SearchPattern <- "test"
let searchPattern = Json.Serialize<AssetContainsSearchParameters> searchParameters
let apiCall = waspClient.ApiCallMap[nameof(waspClient.ApiAssets.AssetInfoSearchAsync)]
apiCall.methodInfo
let httpConnector = waspClient.ApiCallMap[nameof(waspClient.ApiAssets.AssetInfoSearchAsync)].asHTTPConnector

httpConnector.clipURI
httpConnector.clipURI
httpConnector.clipMethod
httpConnector.clipHeaderAuthorizationKey
httpConnector.clipHeaderBearerValue


(*

let workflowDefinitionResource = IanaScheme.https ..// RegistrableDomain.Parse "schema.management.azure.com" ./ "providers/Microsoft.Logic/schemas/2016-06-01/workflowdefinition.json"
http
    {
        GET workflowDefinitionResource.remoteReference
    }
    |> Request.send
    |> Response.saveFile workflowDefinitionResource.localReference

[<Literal>]
let sampleWorkflowDefinitionFilePath = @"C:\https\com\azure\schema.management\providers\Microsoft.Logic\schemas\2016-06-01\workflowdefinition.json"

// 1. Infer types directly from the Azure Logic Apps / Power Automate schema
type LogicAppTemplateSchema = JsonProvider< UseOriginalNames = true, OmitNullFields = true, RootName = "workflowDefinition",
                        Sample = sampleWorkflowDefinitionFilePath>
let workflowDefinition = LogicAppTemplateSchema.Load sampleWorkflowDefinitionFilePath
// 2. Load your exported Flow JSON definition
let flowJson = """
{
    "$schema": "https://schema.management.azure.com/providers/Microsoft.Logic/schemas/2016-06-01/workflowdefinition.json#",
    "contentVersion": "1.0.0.0",
    "actions": {
        "Send_an_email": {
            "type": "ApiConnection",
            "inputs": {
                "host": { "connection": { "name": "@parameters('$connections')['shared_office365']['connectionId']" } },
                "method": "post",
                "body": { "To": "test@example.com", "Subject": "Hello from F#" }
            }
        }
    },
    "triggers": {}
}
"""

let myFlow = WorkflowSchema.Parse(flowJson)

// F# gives you auto-complete and typed safety on the JSON structure
printfn "Content Version: %s" myFlow.ContentVersion

// Safely map or filter actions
myFlow.Actions.JsonValue.RecordProperties 
|> Array.iter (fun (actionName, data) -> printfn "Found Action: %s" actionName)


*)
