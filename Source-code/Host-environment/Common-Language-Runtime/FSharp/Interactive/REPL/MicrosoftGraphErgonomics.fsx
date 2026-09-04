#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "TaskErgonomics.dll"
open TaskErgonomics
#r "HtmlErgonomics.dll"
open HtmlErgonomics
#r "BrowserErgonomics.dll"
open BrowserErgonomics
#r "PageErgonomics.dll"
open PageErgonomics
#r "StringSemantics.dll"
open StringSemantics

open System.Linq
open CaseConverter
open FSharp.Data
open Dubzer.WhatwgUrl
open System.Net.Http
open PuppeteerSharp.Cdp
open BrowserApi.Css.Authoring
open PuppeteerSharp.Contrib.Extensions
open Microsoft.Graph
open System.Net.Http.Headers
open System.Reflection
open Fabulous.AST
open PhoneNumbers
open PosInformatique.Foundations.EmailAddresses

module FSharpLiteral = FSharp.Literals.Literal

module Microsoft = 
    module Graph = 
        let OpenAPI = DomUrl "https://github.com/microsoftgraph/msgraph-metadata/raw/refs/heads/master/openapi/beta/openapi.yaml"
        let csdl = DomUrl "https://github.com/microsoftgraph/msgraph-metadata/raw/refs/heads/master/schemas/beta-Prod.csdl"
        let betaMetadata = DomUrl "https://graph.microsoft.com/beta/$metadata"
        let v1metadata = DomUrl "https://graph.microsoft.com/v1.0/$metadata"
        let httpClient = new HttpClient()

        let explorer =  DomUrl "https://developer.microsoft.com/en-us/graph/graph-explorer"
        let getAccessToken(tab:CdpPage) = 
    
            tab.ClickAsync(El.Button * Attr.Value.Equals("access-token") |> _.Css).await
            let accessTokenElement = tab.QuerySelectorAsync(El.Div * Attr.Id.Equals("access-token") |> _.Css).await.asCdp
            accessTokenElement.InnerTextAsync().await
        let userProperties = 
            [|


                "additionalData"
                "adhocCalls"
                "ageGroup"
                "agreementAcceptances"
                "appRoleAssignments"
                "assignedLicenses"
                "assignedPlans"
                "authentication"
                "authorizationInfo"
                "backingStore"
                "birthday"
                "businessPhones"
                "calendar"
                "calendarGroups"
                "chats"
                "city"
                "cloudClipboard"
                "cloudPCs"
                "companyName"
                "consentProvidedForMinor"
                "contactFolders"
                "contacts"
                "country"
                "createdDateTime"
                "createdObjects"
                "creationType"
                "customSecurityAttributes"
                "dataSecurityAndGovernance"
                "deletedDateTime"
                "deviceManagementTroubleshootingEvents"
                "directReports"
                "displayName"
                "drive"
                "drives"
                "employeeExperience"
                "employeeHireDate"
                "employeeId"
                "employeeLeaveDateTime"
                "employeeOrgData"
                "employeeType"
                "events"
                "extensions"
                "externalUserState"
                "externalUserStateChangeDateTime"
                "givenName"
                "hireDate"
                "id"
                "identities"
                "identityParentId"
                "imAddresses"
                "inferenceClassification"
                "insights"
                "interests"
                "isManagementRestricted"
                "isResourceAccount"
                "jobTitle"
                "joinedTeams"
                "lastPasswordChangeDateTime"
                "legalAgeGroupClassification"
                "mail"
                "mailFolders"
                "mailNickname"
                "mailboxSettings"
                "managedAppRegistrations"
                "managedDevices"
                "manager"
                "memberOf"
                "messages"
                "mobilePhone"
                "mySite"
                "oauth2PermissionGrants"
                "odataType"
                "officeLocation"
                "onPremisesDistinguishedName"
                "onPremisesImmutableId"
                "onPremisesLastSyncDateTime"
                "onPremisesProvisioningErrors"
                "onPremisesSamAccountName"
                "onPremisesSecurityIdentifier"
                "onPremisesSyncBehavior"
                "onPremisesSyncEnabled"
                "onPremisesUserPrincipalName"
                "onenote"
                "onlineMeetings"
                "otherMails"
                "outlook"
                "ownedDevices"
                "ownedObjects"
                "passwordPolicies"
                "people"
                "permissionGrants"
                "photo"
                "photos"
                "planner"
                "postalCode"
                "preferredDataLocation"
                "preferredLanguage"
                "preferredName"
                "presence"
                "provisionedPlans"
                "proxyAddresses"
                "registeredDevices"
                "responsibilities"
                "securityIdentifier"
                "serviceProvisioningErrors"
                "settings"
                "showInAddressList"
                "signInSessionsValidFromDateTime"
                "skills"
                "solutions"
                "sponsorOf"
                "sponsors"
                "state"
                "streetAddress"
                "surname"
                "teamwork"
                "todo"
                "userPrincipalName"
                "userType"


            |]

let chrome = CdpBrowser.Connect()

let microsoftGraphTab = chrome.NewPageAsync().await.asCdp
microsoftGraphTab.GoToAsync(Microsoft.Graph.explorer.Href).await
Microsoft.Graph.httpClient.DefaultRequestHeaders.Authorization <- AuthenticationHeaderValue("Bearer", Microsoft.Graph.getAccessToken(microsoftGraphTab))
let microsoftGraphClient = new GraphServiceClient(Microsoft.Graph.httpClient,  baseUrl = "https://graph.microsoft.com/beta")


// Microsoft.Graph.v1metadata.HeadlessDownloadFileExtension(".xml")
// Microsoft.Graph.betaMetadata.HeadlessDownloadFileExtension(".xml")
// Microsoft.Graph.OpenAPI.HeadlessDownloadFile()
// Microsoft.Graph.csdl.HeadlessDownloadFile()
// Microsoft.Graph.csdl.asFile.FullName |> clip
[<Literal>]
let csdlFilePath = @"D:\Iri\https\github.com\microsoftgraph\msgraph-metadata\raw\refs\heads\master\schemas\beta-Prod.csdl"
type CsdlProvider  = XmlProvider<UseOriginalNames = true, PreferDateOnly = true,
            Sample = csdlFilePath >
let beta_Prod_csdl = CsdlProvider.Load csdlFilePath
let user_csdl =
    beta_Prod_csdl.DataServices.Schemas
    |> Array.pick (fun schema -> 
        match schema.Namespace with 
        | "microsoft.graph" -> 
                    schema.EntityTypes |> Array.tryFind (fun entityType -> entityType.Name = "user" )

        | _ -> None
    )
let csdlUserPropertySet = user_csdl.Properties |> Array.map (fun property -> property.Name) |> Set.ofArray
let clrUserPropertySet = typeof<Microsoft.Graph.Models.User>.GetProperties() |> Array.map (fun property -> property.Name.ToCamelCase()) |> Set.ofArray
csdlUserPropertySet.Count()
clrUserPropertySet.Count()
let workingProperties = 
    clrUserPropertySet
    |> Set.toArray
    |> Array.Parallel.choose (fun property -> 
        try 
            let  myUserAccount = microsoftGraphClient.Me.GetAsync(fun request -> request.QueryParameters.Select <- [| property |] ).await
            Some property
        with 
        | _ -> None

    
    )
let  myUserAccount = microsoftGraphClient.Me.GetAsync(fun request -> request.QueryParameters.Select <- Microsoft.Graph.userProperties ).await




type Microsoft.Graph.Models.User with 
    member this.properties: array<PropertyInfo * obj> = 
        typeof<Microsoft.Graph.Models.User>.GetProperties()
        |> Array.choose (fun property -> 
            match property.GetValue this with 
            | null -> None 
            | value -> Some (property, value)
            )
    member this.propertyNames = this.properties |> Array.map (fun (property, value) -> property.Name)
    member this.propertyTypeNames = this.properties |> Array.map (fun (property, value) -> FSharpLiteral.stringifyTypeDynamic property.PropertyType, property.PropertyType.FullName) |> Array.distinct |> Array.sort

    member this.AstAdditionalDataFields =
            this.AdditionalData
            |> Seq.toArray
            |> Array.map (fun keyValue -> 
                match keyValue.Key, FSharpLiteral.stringifyTypeDynamic (keyValue.Value.GetType()) with 
                | "@odata.context", fieldTypeName  -> Ast.Field("OdataContext", "DomUrl")
                | fieldName, fieldTypeName -> Ast.Field(fieldName, fieldTypeName)
                )
        
    member this.AstFields =

        this.properties
        |> Array.filter (fun (property,value) -> property.Name <> "AdditionalData")
        |> Array.map (fun (property,value) -> 
            match property.Name, FSharpLiteral.stringifyTypeDynamic property.PropertyType with 
            | "BusinessPhones", fieldTypeName   -> Ast.Field("BusinessPhones", "PhoneNumber array" )
            | "Id", fieldTypeName   -> Ast.Field("Id", "Guid" )
            | "ImAddresses", fieldTypeName   -> Ast.Field("ImAddresses", "EmailAddress" )
            | "Mail", fieldTypeName   -> Ast.Field("Mail", "EmailAddress" )
            | "ProxyAddresses", fieldTypeName   -> Ast.Field("ProxyAddresses", "EmailAddress array" )
            | fieldName, fieldTypeName when property.PropertyType.IsInterface && fieldName <> "AdditionalData"  -> Ast.Field(fieldName, FSharpLiteral.stringifyTypeDynamic(value.GetType()))
            | fieldName, fieldTypeName when fieldTypeName.StartsWith("Nullable") -> Ast.Field(fieldName, fieldTypeName.Replace("Nullable","Option"))
            | fieldName, fieldTypeName when fieldTypeName.StartsWith("IDictionary") -> Ast.Field(fieldName, fieldTypeName.Replace("IDictionary","Map"))
            | fieldName, fieldTypeName when fieldTypeName.StartsWith("ResizeArray") -> Ast.Field(fieldName, fieldTypeName.Replace("ResizeArray","array"))
            | fieldName, fieldTypeName -> Ast.Field(fieldName, fieldTypeName)
            )
    member this.AstRecord (recordName:string) = 
        Ast.Record(recordName){
            for field in this.AstFields -> field
            for field in this.AstAdditionalDataFields -> field
            
        }
    member this.AstAnonymousModule = 
        Ast.AnonymousModule(){
            this.AstRecord "EntraUser"

        }
    member this.AstOak = 

        Ast.Oak(){
            this.AstAnonymousModule
        }
        |> Gen.mkOak
        |> Gen.run




myUserAccount.AstOak |> clip



let additionalData = myUserAccount.AdditionalData |> Seq.toArray

additionalData[0].Value.GetType().Name
additionalData[0].Key

myUserAccount.BackingStore.GetType().Name


myUserAccount.BusinessPhones |> Seq.map PhoneNumber.Parse 
myUserAccount.ImAddresses |> Seq.map EmailAddress.Parse

myUserAccount.propertyTypeNames


