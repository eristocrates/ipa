// TODO use dynamic operator for namespacenames for adhoc local names

#time on

fsi.PrintLength <- 10
fsi.PrintSize <- 100

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
#r "IanaScheme.dll"
#r "IanaMime.dll"
#r "NetworkMonitor.dll"
#r "Turtle.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "Ast.fsx"
open SharedKernel
open StringModule
open Internet
open ResourceIdentification
open ResourceDescription
open Turtle
open Iana
open NetworkMonitor
#I @"D:\https\com\github\eristocrates\ipa\fsx\Sites"

#load @".paket/load/main.group.fsx"
open PuppeteerSharp
open PuppeteerSharp.Cdp
open FolkerKinzel.MimeTypes
open System.Web
open IriTools

open System
open System.Text
open System.IO
open System.Linq
open PuppeteerSharp
open PuppeteerSharp.Cdp
open Tavis.UriTemplates
open BrowserApi.Css.Authoring
open BrowserApi.Css
open BrowserApi
open Meziantou.Framework
open System.Threading
open VDS.RDF
open FSharp.Data
open VDS.RDF.Parsing
open Universal.Common
open RDFSharp.Model
open AW.Identifiers
open LSL.DataUri

module gov =

    let topLevelDomain = TopLevelDomain.gov
    module leoncountyfl =
        let host = topLevelDomain .+ "leoncountyfl"
        let site = IanaScheme.https ..// host
        module bannerprodssb =
            let host = site .+ "bannerprodssb" |> _.host
            let site = IanaScheme.https ..// host + 8449

            module hrDashboard =
                let space = site / "EmployeeSelfService/ssb/hrDashboard" * "#/{page}"
                let page (page) =
                    space.pathTemplate.AddParameter("page", page).Resolve()
                    |> HttpUtility.UrlDecode
                    |> IriReference
                let iriref = page "hrDashboard"
                module payStubSummary =
                    let iriref = page "payStubSummary"
                    let space = space * "#/payStubSummary/list/{year}"
                    let year (year: int) =
                        space.pathTemplate.AddParameter("year", year).Resolve()
                        |> HttpUtility.UrlDecode
                        |> IriReference

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
        |> Array.tryFind (fun tab -> tab.iriref.Origin = gov.leoncountyfl.bannerprodssb.site.iriref.Origin)
    match maybeTab with
    | Some tab -> tab
    | None -> chrome.tabs |> Array.last

tab.BringToFrontAsync().await
// tab.GoToAsync(gov.leoncountyfl.bannerprodssb.hrDashboard.iriref).await
// tab.GoToAsync(gov.leoncountyfl.bannerprodssb.hrDashboard.payStubSummary.iriref).await

let cdpRequestByOrigin =

    responses
    |> Seq.choose (fun response ->
        match response.Text() with
        | Some text ->
            Some {
                httpRequest = (response :> IResponse).Request.asCdp
                httpResponse = response
                iri = NamedReference response.iriref
                text = text
            }
        | None -> None)
    |> Seq.toArray
    |> Array.groupBy (fun content -> content.httpResponse.originIri.lexicalForm)
    |> Array.sortBy (fun (origin, _) -> origin)

(*

cdpRequestByOrigin
|> Array.mapi (fun index origin -> $"{nameof (cdpRequestByOrigin)}[{index}] = {fst origin}")
|> String.concat "\n"
|> String.Clipboard.SetText

*)

let origin, cdpRequests =
    cdpRequestByOrigin
    |> Array.find (fun (origin, _) -> origin = "https://bannerprodssb.leoncountyfl.gov:8449/")

#load @"Namespaces\Manual\chromedevtoolsNamespace.fsx"
open ChromedevtoolsNamespace
let httpNamespace = NamedReference "http://www.w3.org/2011/http#" |> NamespaceName
// httpNamespace.codegenAstModule()
#load @"Namespaces\Generated\httpNamespace.fsx"
open HttpNamespace
RDFNamespace("http", "http://www.w3.org/2011/http#")
|> RDFNamespaceRegister.AddNamespace
let rdfNamespace = NamedReference "http://www.w3.org/1999/02/22-rdf-syntax-ns#" |> NamespaceName
// rdfNamespace.codegenAstModule()
#load @"Namespaces\Generated\rdfNamespace.fsx"
open RdfNamespace
let a = rdf.type_

let owlNamespace = NamedReference "	http://www.w3.org/2002/07/owl#" |> NamespaceName
// owlNamespace.codegenAstModule()
#load @"Namespaces\Generated\owlNamespace.fsx"
open OwlNamespace

let httpMethodNamespace = NamedReference "http://www.w3.org/2011/http-methods#" |> NamespaceName
// httpMethodNamespace.codegenAstModule()
#load @"Namespaces\Generated\httpmNamespace.fsx"
open HttpmNamespace
RDFNamespace("httpm", "http://www.w3.org/2011/http-methods#")
|> RDFNamespaceRegister.AddNamespace
let httpHeadersNamespace = NamedReference "http://www.w3.org/2011/http-headers#" |> NamespaceName
// httpHeadersNamespace.codegenAstModule()
#load @"Namespaces\Generated\httphNamespace.fsx"
open HttpmNamespace
RDFNamespace("httph", "http://www.w3.org/2011/http-headers#")
|> RDFNamespaceRegister.AddNamespace
let httpscNamespace = NamedReference "http://www.w3.org/2011/http-statusCodes#" |> NamespaceName
RDFNamespace("httpsc", "http://www.w3.org/2011/http-statusCodes#")
|> RDFNamespaceRegister.AddNamespace
// httpscNamespace.codegenAstModule()
#load @"Namespaces\Generated\httpscNamespace.fsx"
open HttpscNamespace
let cntNamespace = NamedReference "http://www.w3.org/2011/content#" |> NamespaceName
// cntNamespace.codegenAstModule()
#load @"Namespaces\Generated\cntNamespace.fsx"
open CntNamespace
RDFNamespace("cnt", "http://www.w3.org/2011/content#")
|> RDFNamespaceRegister.AddNamespace

let dctNamespace = NamedReference "http://purl.org/dc/terms/" |> NamespaceName
// dctNamespace.codegenAstModule()
#load @"Namespaces\Generated\dctermsNamespace.fsx"
open DctermsNamespace

(*
let networkRequest = chromedevtools._prefixedName content.request.Id 
let httpRequest = chromedevtools._prefixedName $"{content.request.Id}Request" |> http.Request.Instance
let httpRequestHeaders = 
    content.request.headers |> Array.map (fun (fieldName, fieldValue ) ->  
        let requestHeader = chromedevtools._prefixedName $"{content.request.Id}RequestHeader{fieldName}" |> http.RequestHeader.Instance
        requestHeader, [|
            requestHeader.fieldName -->= fieldName
            requestHeader.fieldValue -->= fieldValue
        |]
    )
let httpResponse = chromedevtools._prefixedName $"{content.request.Id}Response" |> http.Response.Instance
let httpResponseHeaders = 

    content.response.headers |> Array.map (fun (fieldName, fieldValue ) ->  
        let responseHeader = chromedevtools._prefixedName $"{content.request.Id}ResponseHeader{fieldName}" |> http.ResponseHeader.Instance
        responseHeader, [|
            responseHeader.fieldName -->= fieldName
            responseHeader.fieldValue -->= fieldValue
        |]
    )
let mime = content.response.mimeType.Value
let textLiteral = DatatypedString(content.response.Text().Value |> SimpleString,  rdf.JSON)
let contentData = DataUri(textLiteral.lexicalForm.asUtf8, mime.contentType).iri |> cnt.ContentAsText.Instance

scratchGraph.NamespaceMap.AddNamespace("cdp", cdp._namespaceIri.uri)
scratchGraph.NamespaceMap.AddNamespace("http", http._namespace.uri)
scratchGraph.NamespaceMap.AddNamespace("httpm", httpm._namespace.uri)
scratchGraph.NamespaceMap.AddNamespace("httpsc", httpsc._namespace.uri)
scratchGraph.NamespaceMap.AddNamespace("owl", owl._namespace.uri)
scratchGraph.NamespaceMap.AddNamespace("dcterms", dcterms._namespace.uri)
*)

RDFNamespaceRegister.AddNamespace(RDFNamespace("cdp", "urn:chromedevtoolsprotocol:"))
// RDFNamespaceRegister.RemoveByPrefix ("cdp")

// let scratchGraph = new ThreadSafeGraph()
// TODO add HttpStatusCode to autootyped
// cdpRequest.originGraph

let originGraphs =
    cdpRequests
    |> Array.map (fun cdpRequest ->
        cdpRequest.originGraph.Clear()
        let httpRequest = cdpRequest.httpRequest.irn.iri |> http.Request.Instance
        let httpResponse = cdpRequest.httpResponse.irn.iri |> http.Response.Instance
        let headerFormula =
            cdpRequest.headers
            |> Array.collect (fun (fieldName, fieldValue) ->
                let requestHeader = HttpHeader.Irn cdpRequest.Id fieldName |> http.MessageHeader.Instance
                [|
                    requestHeader.fieldName -->= fieldName
                    requestHeader.fieldValue -->= fieldValue
                |])
            |> Array.toList
        let bodyFormula =
            match cdpRequest.httpResponse.tryBodyDataUri, cdpRequest.httpResponse.tryTextDataUri with
            | Some bodyDataUri, Some textDataUri ->
                let base64Content = cdpRequest.httpResponse.bodyIrn.iri |> cnt.ContentAsBase64.Instance
                let textContent = textDataUri.iri |> cnt.ContentAsText.Instance
                let textLiteral =
                    let textString = textDataUri.utf8Data
                    match cdpRequest.httpResponse.mimeType with
                    | Some mime when mime.SubType.Contains "json" -> DatatypedString(SimpleString textString, rdf.JSON) |> DatatypedLiteral
                    | Some mime when mime.SubType.Contains "xml" -> DatatypedString(SimpleString textString, rdf.XMLLiteral) |> DatatypedLiteral
                    | None -> SimpleString textString |> SimpleLiteral
                [
                    !>base64Content --- dcterms.hasFormat --> textContent
                    httpResponse.body --> base64Content -*/ base64Content.characterEncoding
                    -->= "UTF-8"
                    -*/ base64Content.bytes
                    -->= bodyDataUri.Data
                    -*/ textContent.characterEncoding
                    -->= "UTF-8"
                    -*/ textContent.chars
                    --> textLiteral

                ]
            | _, _ -> []

        !>cdpRequest
        -~|> [
            a ->- chromedevtools.Network.Request
            chromedevtools.Network.RequestId ->= cdpRequest.Id
            dcterms.hasPart ->- cdpRequest.httpRequest.irn
        ]
        -!| [ cdpRequest.irn; cdpRequest.httpRequest.irn; cdpRequest.httpResponse.irn ]
        --- dcterms.date
        -->= DateOnly.Now
        -*/ httpRequest.methodName
        -->= cdpRequest.httpRequest.Method.Method
        -*/ httpRequest.requestURI
        -->= cdpRequest.httpRequest.iriref.uri
        -*/ httpRequest.mthd
        --> httpm._namespace.prefixedName cdpRequest.httpRequest.Method.Method
        -*/ httpRequest.headers
        -->| cdpRequest.httpRequest.headerIris
        -*/ httpRequest.resp
        --> httpResponse
        -*/ httpResponse.statusCodeValue
        -->= int cdpRequest.httpResponse.Status
        -*/ httpResponse.sc
        --> httpsc._namespace.prefixedName (string cdpRequest.httpResponse.Status)
        -*/ httpResponse.headers
        -->| cdpRequest.httpResponse.headerIris
        -*| bodyFormula
        -*| headerFormula
        |> cdpRequest.originGraph.Assert
        cdpRequest.originGraph)
    |> Array.distinctBy (fun graph -> graph.Name.ToString())
originGraphs
|> Array.iter (fun originGraph ->
    let ttlPath = Path.Combine(DriveInfo.preferredDrive.Name, gov.leoncountyfl.bannerprodssb.site.localReference, IanaMime.text.turtle.asRelativeFilePath.WeakString)
    Path.GetDirectoryName ttlPath |> Directory.CreateDirectory |> ignore
    originGraph.SaveToTurtle ttlPath
    printfn $"saved {originGraph.Name.ToString()} to {ttlPath}")

module dbug =
    let _namespaceIri =
        personalUriTemplate
            .AddParameters(
                {|
                    namespacePrefix = "dbug"
                    localName = String.Empty
                |}
            )
            .asIri
    RDFNamespaceRegister.AddNamespace(RDFNamespace("dbug", _namespaceIri.lexicalForm))

    let _prefixedName (localName: string) =
        personalUriTemplate
            .AddParameters(
                {|
                    namespacePrefix = "dbug"
                    localName = localName
                |}
            )
            .asIri

    let Alice = _prefixedName "Alice"
    let Bob = _prefixedName "Bob"
    let test = _prefixedName "test"
    let example = _prefixedName "example"

let s = !?"s"
let p = !?"p"
let o = !?"o"
let text = !?"text"
let gggSparqDataset = SparqlLocalDataset.fromDataset ggg.dataset

let selectSet =

    sparql.select [ s; text ] {
        where (
            !>s
            --- dcterms.hasPart /> http.resp /> http.body /> dcterms.hasFormat /> cnt.chars
            --> text
        )
        from gov.leoncountyfl.bannerprodssb.site.iri
    }
    |> gggSparqDataset.query

let (RdfIri request) = (selectSet.columnByVariables s)[0]
let (RdfLiteral jsonLiteral) = (selectSet.columnByVariables text)[0]
let applicationJson = MimeType.Parse "application/json"
//  "D:\https\gov\leoncountyfl\bannerprodssb\EmployeeSelfService\ssb\payStubSummary\getPayStubSummaryList\application\json.json"

let samplePath = Path.Combine(request.iriref.localReference, applicationJson.asRelativeFilePath.WeakString)
Path.GetDirectoryName samplePath |> Directory.CreateDirectory |> ignore

File.WriteAllText(samplePath, jsonLiteral.lexicalForm)

// constructGraph.SaveToTurtle @"D:\https\com\github\eristocrates\ipa\scratch\scratch.ttl"

// gov.leoncountyfl.bannerprodssb.site.localReference.clip
// content.response.headers |> Array.map (fun (fieldName, fieldValue) )

// https://bannerprodssb.leoncountyfl.gov:8449/

// https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/hrDashboard#/payStubSummary/list/

// Substring(namespaceIri.Length)

tab.GoToAsync(gov.leoncountyfl.bannerprodssb.hrDashboard.payStubSummary.year 2024).await.asCdp
tab.GoToAsync(gov.leoncountyfl.bannerprodssb.hrDashboard.payStubSummary.year 2025).await.asCdp
tab.GoToAsync(gov.leoncountyfl.bannerprodssb.hrDashboard.payStubSummary.year 2026).await.asCdp

let realm = CdpRealm tab.MainFrame.asCdp

let payStubDetailPattern =
    UrlPattern.Create(
        "EmployeeSelfService/ssb/hrDashboard#/payStubDetail/{:year}/{:payId}/{:payNumber}/{:paySequence}/{:yyyyMMdd}",
        gov.leoncountyfl.bannerprodssb.site.remoteReference
    )
payStubDetailPattern.IsMatch "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/hrDashboard#/payStubDetail/2024/BW/26/0/20241219"
let payStubDetail = payStubDetailPattern.Match "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/hrDashboard#/payStubDetail/2024/BW/26/0/20241219"
payStubDetail.Hash.Groups["year"]
payStubDetail.Hash.Groups["index"]
payStubDetail.Hash.Groups["yyyyMMdd"]
let payDateElements =
    realm.document.QuerySelectorAll(El.A)
    |> Array.filter (fun anchor ->
        if anchor.HasAttribute "href" then
            (anchor.GetAttribute "href").StartsWith "#/payStubDetail"
        else
            false)

payDateElements
// |> Array.take 3
|> Array.iter (fun element ->
    element.TryAttribute "href"
    |> Option.iter (fun href ->
        let backTab = chrome.NewPageBackgroundAsync().await.asCdp
        backTab.GoToAsync($"https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/hrDashboard{href}")
        |> ignore
        Thread.Sleep 5000
        backTab.CloseAsync() |> ignore))

let anchorHandles =
    tab.QuerySelectorAllAsync("a.link.ng-binding.ng-scope").await
    |> Array.map (fun handle -> handle.asCdp)

let payDateHandles =
    anchorHandles
    |> Array.filter (fun handle ->
        match handle.RealmElement(realm).TryAttribute "href" with
        | Some href when href.StartsWith "#/payStubDetail" -> true
        | _ -> false)

payDateHandles[0].ClickAsync().await
payDateHandles
|> Array.take 3
|> Array.iter (fun handle ->
    Thread.Sleep 750
    handle.ClickAsync().await
    Thread.Sleep 750
    tab.GoBackAsync().await |> ignore)

let testIriref =
    IriReference
        "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/payStubDetail/getPayStubDetail?payDate=20240523&payId=BW&payNumber=11&paySequence=0&payYear=2024"
let queryStringParameterCollection = QueryStringUtilities.ParseQuery testIriref.uri.Query
queryStringParameterCollection.asRelativeDirectoryPath
//    ----->  D:\https\gov\leoncountyfl\bannerprodssb\\EmployeeSelfService\ssb\payStubDetail\getPayStubDetail
'?'.tryHtmlEntity
