#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
# time on
fsi.ShowDeclarationValues <- false

open Dubzer.WhatwgUrl

open System

open Going.Plaid
open Going.Plaid.Link
open Going.Plaid.Sandbox
open Going.Plaid.Entity
open Going.Plaid.Institutions
open Going.Plaid.Item
open Going.Plaid.Accounts



#r "BrowserErgonomics.dll"
open BrowserErgonomics
#r "PageErgonomics.dll"
open PageErgonomics
#r "TaskErgonomics.dll"
open TaskErgonomics

#load @"C:\Secret\PlaidSecrets.fsx"
open PlaidSecrets
open PuppeteerSharp.Cdp


type PlaidLinkToken = 
    {
        Expiration: DateTimeOffset
        HostedLinkUrl: DomUrl
        LinkToken: string
        UserId: string option

        CreatedAt: DateTimeOffset option
        LinkSessions: LinkTokenGetSessionsResponse array

        AccountFilters: AccountFiltersResponse option
        ClientName: string option
        CountryCodes: CountryCode array
        InitialProducts: Products array
        RoutingNumber: string option
        Language: string option
        RedirectUri: Uri option
        Webhook: string option
    }
    member this.latestSession =
        this.LinkSessions
        |> Array.choose (fun linkSession ->
            Option.ofNullable linkSession.FinishedAt
            |> Option.map (fun finishedAt ->
                finishedAt, linkSession
            )
        )
        |> Array.maxBy fst
        |> snd
    member this.lastItemAdded = 
        this.latestSession.Results.ItemAddResults |> Seq.last


module Plaid = 
    let country_subdivision_codes = DomUrl "https://plaid.com/documents/country_subdivision_codes.json"
    let myAddress = 
                    let address = new LinkTokenCreateRequestUserAddressObject()
                    address.City <- myCity
                    address.Country <- myCountry
                    address.PostalCode <- myPostalCode
                    address.Region <- myRegion
                    address.Street <- myStreet
                    address
    let myName = 
                    let name = new LinkTokenCreateRequestUserNameObject()
                    name.FamilyName <- myLastName
                    name.GivenName <- myFirstName
                    name
    let myClientName = "Finance IPA"
    let myAuthUser =
        let user = LinkTokenCreateRequestUser()
        user.ClientUserId <- myClientUserId
        user

type LinkTokenCreateResponse with 
    member this.DomUrl = DomUrl this.HostedLinkUrl

    member this.openInBrowser(browser:CdpBrowser) = 
                let tab = browser.NewPageAsync().await.asCdp
                tab.GoToAsync(this.DomUrl.Href).await.asCdp |> ignore
                tab
type  PlaidEnvironment = 
    private
    | PlaidSandboxEnvironment of PlaidClient
    | PlaidProductionEnvironment of PlaidClient
    static member SandboxEnvironment()   = 
        PlaidClient(
        Environment.Sandbox,
        secret = Sandbox.plaidSecret,
        clientId = plaidClientId
        )
        |> PlaidSandboxEnvironment

    static member ProductionEnvironment() =
        PlaidClient(
            Environment.Production,
            secret = Production.plaidSecret,
            clientId = plaidClientId
        )
        |> PlaidProductionEnvironment
    member this.client = 
        match this with 
        | PlaidSandboxEnvironment plaidClient -> plaidClient
        | PlaidProductionEnvironment plaidClient -> plaidClient


    member this.HostedLink() = 
                    let request = LinkTokenCreateRequest()

                    request.ClientName <- Plaid.myClientName
                    request.Language <- Language.English
                    request.CountryCodes <- [| CountryCode.Us |]
                    request.Products <- [| Products.Auth |]
                    request.User <- Plaid.myAuthUser
                    request.HostedLink <- LinkTokenCreateHostedLink()
                    this.client.LinkTokenCreateAsync(request).await


    member this.CreateLinkToken
        (linkTokenCreateResponse: LinkTokenCreateResponse) =

        let getRequest =
            LinkTokenGetRequest()

        getRequest.LinkToken <-
            linkTokenCreateResponse.LinkToken

        let response =
            this.client
                .LinkTokenGetAsync(getRequest)
                .await

        let metadata =
            response.Metadata

        {
            Expiration =
                linkTokenCreateResponse.Expiration

            HostedLinkUrl =
                DomUrl linkTokenCreateResponse.HostedLinkUrl

            LinkToken =
                linkTokenCreateResponse.LinkToken

            UserId =
                Option.ofObj linkTokenCreateResponse.UserId

            CreatedAt =
                Option.ofNullable response.CreatedAt

            LinkSessions =
                response.LinkSessions
                |> Option.ofObj
                |> Option.map Seq.toArray
                |> Option.defaultValue [||]

            AccountFilters =
                Option.ofObj metadata.AccountFilters

            ClientName =
                Option.ofObj metadata.ClientName

            CountryCodes =
                metadata.CountryCodes
                |> Seq.toArray

            InitialProducts =
                metadata.InitialProducts
                |> Seq.toArray

            RoutingNumber =
                metadata.InstitutionData
                |> Option.ofObj
                |> Option.bind (
                    fun institutionData ->
                        Option.ofObj institutionData.RoutingNumber
                )

            Language =
                Option.ofObj metadata.Language

            RedirectUri =
                metadata.RedirectUri
                |> Option.ofObj
                |> Option.map Uri

            Webhook =
                Option.ofObj metadata.Webhook
        }

    member this.InstitutionSearch(institutionQuery:string) = 
    
        let request = InstitutionsSearchRequest()

        request.Query <- institutionQuery
        request.CountryCodes <- [| CountryCode.Us |]

        this.client.InstitutionsSearchAsync(request).await.Institutions |> Seq.toArray
    member this.InstitutionById(institutionId:string) = 
    
        let request = InstitutionsGetByIdRequest()

        request.InstitutionId <- institutionId
        request.CountryCodes <- [| CountryCode.Us |]

        this.client.InstitutionsGetByIdAsync(request).await.Institution
    member this.exactlyOneInstitutionSearch (institutionQuery:string) = 
        this.InstitutionSearch institutionQuery |> Array.exactlyOne
    
    member this.CreateLinkSessionItem(linkSessionItem:LinkSessionItemAddResult) = 
        let request = ItemPublicTokenExchangeRequest()

        request.PublicToken <- linkSessionItem.PublicToken

        let response = this.client.ItemPublicTokenExchangeAsync(request).await
        {
            itemId = response.ItemId
            accessToken = response.AccessToken
            institution = this.InstitutionById linkSessionItem.Institution.InstitutionId
            environment = this
        }
and PlaidItem =
    {
        itemId: string
        accessToken: string
        institution: Institution
        environment: PlaidEnvironment
    }
    member this.accounts =
        let request = AccountsBalanceGetRequest()

        request.AccessToken <- this.accessToken

        let response =
            this.environment.client.AccountsBalanceGetAsync(request).await

        response.Accounts
        |> Seq.toArray


    member this.accountsBySupertype (accountSupertype:AccountType) = 
        this.accounts |> Array.filter (fun account -> account.Type = accountSupertype)
    member this.accountsById  = 
        this.accounts |> Array.map (fun account -> account.AccountId, account) |> Map.ofArray
    member this.accountsBySubtype (accountSubtype:AccountSubtype) = 
        this.accounts |> Array.choose (fun account -> 
            match account.Subtype with 
            | subtype when not subtype.HasValue -> None 
            | subtype when accountSubtype = subtype.Value  -> Some account
            | _ -> None
            
            )
    member this.accountsBySupertypeSubtype (accountSupertype:AccountType, accountSubtype:AccountSubtype) = 
            this.accounts |> Array.choose (fun account -> 
            match account.Type, account.Subtype with 
            | supertype, subtype when not subtype.HasValue -> None 
            | supertype, subtype when supertype = accountSupertype && accountSubtype = subtype.Value  -> Some account
            | _, _ -> None
            
            )
    member this.depositoryCheckingAccounts = 
        this.accountsBySupertypeSubtype(AccountType.Depository,AccountSubtype.Checking)










type PlaidCurrencyCode = 
    | IsoCurrencyCode of string
    | UnofficialCurrencyCode of string
    member this.code = 
        match this with 
        | IsoCurrencyCode code -> code
        | UnofficialCurrencyCode code -> code

type Account with 
    member this.currentBalance = Option.ofNullable this.Balances.Current
    member this.availableBalance = Option.ofNullable this.Balances.Available
    member this.currencyCode =  
        match Option.ofObj this.Balances.IsoCurrencyCode, Option.ofObj this.Balances.UnofficialCurrencyCode with 
        | Some code, None -> Some(IsoCurrencyCode code)
        | None, Some code -> Some(UnofficialCurrencyCode code)
        | _ ,  _ -> None
    member this.lastUpdatedDateTime = Option.ofNullable this.Balances.LastUpdatedDatetime
    member this.limit = Option.ofNullable this.Balances.Limit


let chrome = CdpBrowser.Connect()

let plaidEnvironment = PlaidEnvironment.ProductionEnvironment()

(*

let HostedLink = plaidEnvironment.HostedLink()

let HostedLinkTab = HostedLink.openInBrowser chrome
let plaid_link_iframe_1 =  HostedLinkTab.frames |> Array.last


let inputPhoneNumber() = 
    let input = plaid_link_iframe_1.QuerySelectorAllAsync(Attr.Aria.Label.Equals("Phone number")  |> _.Css).await |> Array.exactlyOne |> _.asCdp
    input.TypeAsync("4155550011").await 
let clickAriaLabel(ariaLabel:string) =
    let labeledElement = plaid_link_iframe_1.QuerySelectorAllAsync(Attr.Aria.Label.Equals(ariaLabel)  |> _.Css).await |> Array.exactlyOne |> _.asCdp
    labeledElement.ClickAsync().await
let inputCode() = 
    let input = plaid_link_iframe_1.QuerySelectorAllAsync(El.Input * Attr.Type.Equals("number")  |> _.Css).await |> Array.exactlyOne |> _.asCdp
    input.TypeAsync("123456").await 
// TODO move into html ergonomics
type Attr with 
    static member Alt = new AttrSelector("alt")

let clickBankAccount(bank:string) = 
    let image = plaid_link_iframe_1.QuerySelectorAllAsync(El.Img * Attr.Alt.Equals(bank)  |> _.Css).await |> Array.exactlyOne |> _.asCdp
    image.ClickAsync().await

let clickShareData() = 
    let button = plaid_link_iframe_1.QuerySelectorAllAsync(El.Button * Attr.Id.Equals("aut-button")  |> _.Css).await |> Array.exactlyOne |> _.asCdp
    button.ClickAsync().await




inputPhoneNumber()
clickAriaLabel "Continue"
inputCode()
clickBankAccount "Tartan Bank"
clickAriaLabel "Confirm"
clickShareData()


let LinkToken = plaidEnvironment.CreateLinkToken HostedLink
let PlaidItem =  plaidEnvironment.CreateLinkSessionItem LinkToken.lastItemAdded
*)

let WellsFargoPlaidItem =  
    {
        itemId = WellsFargo.itemId
        accessToken = WellsFargo.accessToken
        institution = plaidEnvironment.InstitutionById WellsFargo.institutionId
        environment = plaidEnvironment
    }
    
let wellsFargoEveryDayCheckingAccount = WellsFargoPlaidItem.accountsById[WellsFargo.checkingAccountId]


let CrewFinancePlaidItem =  
    {
        itemId = CrewFinance.itemId
        accessToken = CrewFinance.accessToken
        institution = plaidEnvironment.InstitutionById CrewFinance.institutionId
        environment = plaidEnvironment
    }
    

let crewCheckingAccount = CrewFinancePlaidItem.accountsById[CrewFinance.checkingAccountId]

let USAAPlaidItem = 
    {
        itemId = USAA.itemId
        accessToken = USAA.accessToken
        institution = plaidEnvironment.InstitutionById USAA.institutionId
        environment = plaidEnvironment
    }

let usaaCheckingAccount = USAAPlaidItem.accountsById[USAA.checkingAccountId]
let usaaSavingsAccount = USAAPlaidItem.accountsById[USAA.savingsAccountId]
