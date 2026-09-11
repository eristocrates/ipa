(*

& "C:\Program Files\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9222 --user-data-dir=C:\temp\chrome-automation


& "C:\Program Files\Mozilla Firefox\firefox.exe" --remote-debugging-port 9223
*)

// TODO add gnd to known ontologies https:-nb.info/standards/elementset/gnd2012-06-30

#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "TaskErgonomics.dll"

open TaskErgonomics
#r "PageErgonomics.dll"

open PageErgonomics
#r "UrlErgonomics.dll"

open UrlErgonomics

open System
open PuppeteerSharp
open PuppeteerSharp.Cdp
open Dubzer.WhatwgUrl
open System.IO
open System.Net
open WebDriverBiDi
open WebDriverBiDi.Session
open WebDriverBiDi.BrowsingContext
open FolkerKinzel.MimeTypes



/// https://source.chromium.org/chromium/chromium/src/+/main:content/browser/devtools/devtools_agent_host_impl.cc?ss=chromium&q=f:devtools%20-f:out%20%22::kTypeTab%5B%5D%22
[<RequireQualifiedAccess>]
type kType =
    | tab
    | page
    | iframe
    | worker
    | shared_worker
    | service_worker
    | worklet
    | browser
    | webview
    | other
    | auction_worklet
    | assistive_technology
    | browser_ui

    member this.asString = this.ToString()
    member this.asTargetType =
        match this with
        | kType.tab -> TargetType.Tab
        | kType.page -> TargetType.Page
        | kType.iframe -> TargetType.IFrame
        | kType.worker -> TargetType.Worker
        | kType.shared_worker -> TargetType.SharedWorker
        | kType.service_worker -> TargetType.ServiceWorker
        | kType.worklet -> TargetType.Other
        | kType.browser -> TargetType.Browser
        | kType.webview -> TargetType.Webview
        | kType.other -> TargetType.Other
        | kType.auction_worklet -> TargetType.Other
        | kType.assistive_technology -> TargetType.Other
        | kType.browser_ui -> TargetType.Other

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


type IBrowser with
    member this.asCdp = this :?> CdpBrowser

type IBrowserContext with
    member this.asCdp = this :?> CdpBrowserContext

type IRequest with
    member this.asCdp = this :?> CdpHttpRequest

type IResponse with
    member this.asCdp = this :?> CdpHttpResponse


type CdpFrame with
    member this.DomUrl = DomUrl this.Url




type CdpHttpRequest with
    member this.DomUrl = DomUrl this.Url

    member this.headers = this.Headers |> Seq.map (fun kvp -> kvp.Key, kvp.Value) |> Seq.toArray

    member this.header(targetHeader: string) =
        this.headers
        |> Array.tryPick (fun (headerKey, headerValue) -> if headerKey = targetHeader then Some headerValue else None)

    member this.PostText = if this.HasPostData then Some this.PostData else None



type CdpHttpResponse with
    member this.DomUrl = DomUrl this.Url

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


let backgroundOption = new CreatePageOptions()
backgroundOption.Background <- true



let finishedRequests = new ResizeArray<CdpHttpRequest>()
let failedRequests = new ResizeArray<CdpHttpRequest>()



let writeRequestResponse (response: CdpHttpResponse) (extensionOverride: string option) =
    match extensionOverride, response.TextAsync().await with
    | Some extension, text when not (String.IsNullOrWhiteSpace(text)) ->
        let file = Path.ChangeExtension(response.DomUrl.asFile.FullName, extension) |> FileInfo
        Directory.CreateDirectory file.DirectoryName |> ignore
        printfn "%s:\t\t %s ----> %s" response.DomUrl.Host response.DomUrl.AbsolutePathName file.Name
        File.WriteAllText(file.FullName, text)
    | None, text when not (String.IsNullOrWhiteSpace(text)) ->
        Directory.CreateDirectory response.DomUrl.asFile.DirectoryName |> ignore
        printfn "%s:\t\t %s ----> %s" response.DomUrl.Host response.DomUrl.AbsolutePathName response.DomUrl.asFile.Name
        File.WriteAllText(response.DomUrl.asFile.FullName, text)
    | _, _ -> ()

let neogovPathStems =
    set [
        "employees"
        "customWindowProperties"
        "orgChartView"
        "directManager"
        "user-profile"
    ]

let bannerXmlStems = set [ "menu" ]

let bannerJsonStems =
    set [
        "fetchUsageTracking"
        "getAccordionSectionData"
        "getSettingsVisibilityInd"
        "getPayStubSummary"
        "getPayStubSummaryList"
    ]
/// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/MIME_types/Common_types


let networkMailbox =
    MailboxProcessor<CdpHttpRequest>.Start(fun inbox ->
        let rec loop () =
            async {
                let! request = inbox.Receive()
                match request.Response.Status with
                | HttpStatusCode.OK ->
                    finishedRequests.Add request
                    let mimeMediaType =
                        MimeType.TryParse(request.Response.Headers["content-type"])
                        |> fun (wasParsed, mimeType) ->
                            match wasParsed with
                            | true -> mimeType.MediaType
                            | false -> String.Empty
                    let mimeSubType =
                        MimeType.TryParse(request.Response.Headers["content-type"])
                        |> fun (wasParsed, mimeType) ->
                            match wasParsed with
                            | true -> mimeType.SubType
                            | false -> String.Empty
                    match request.Response.DomUrl.Host, request.Response.DomUrl.pathStem, request.Response.DomUrl.extension, mimeMediaType, mimeSubType with
                    | host, pathstem, extension, mediaType, subType -> ()
                    (*
                        | "leoncountyfl.samanage.com", _, ".json", _ -> writeRequestResponse request.Response None
                        | "leoncountyfl.samanage.com", _, ".jsonhtml", _ -> writeRequestResponse request.Response None
                        | "leoncountyfl.samanage.com", _, ".xml", _ -> writeRequestResponse request.Response None
                        | "unifiedweb-api.neogov.com", pathStem, _, _ when neogovPathStems.Contains(pathStem) -> Some ".json" |> writeRequestResponse request.Response
                        | "content.centene.com", _, ".json", _ -> writeRequestResponse request.Response None
                        | "my.centene.com", _, ".json", _ -> writeRequestResponse request.Response None
                        | "app.securiti.ai", "location", _, _ ->
                            Some ".json"
                            |> writeRequestResponse request.Response
                        | "smetrics.sunshinehealth.com", "interact", _, _ ->
                            Some ".json"
                            |> writeRequestResponse request.Response
                        | "external-api.search.my.centene.com", "query", _, _ ->
                            Some ".json"
                            |> writeRequestResponse request.Response
                        | "siteintercept.qualtrics.com", _, ".php", _ ->
                            Some ".json"
                            |> writeRequestResponse request.Response
                        | "bannerprodssb.leoncountyfl.gov:8449", pathStem, _, _ when bannerXmlStems.Contains(pathStem) ->
                            Some ".xml"
                            |> writeRequestResponse request.Response
                        | "bannerprodssb.leoncountyfl.gov:8449", pathStem, _, _ when bannerJsonStems.Contains(pathStem) ->
                            Some ".json"
                            |> writeRequestResponse request.Response
                        | "bannerprodssb.leoncountyfl.gov:8449", _, "", "json" ->
                            Some ".json"
                            |> writeRequestResponse request.Response
                        | "bannerprodssb.leoncountyfl.gov:8449", _, "", "xml" ->
                            Some ".xml"
                            |> writeRequestResponse request.Response
                        | "bannerprodssb.leoncountyfl.gov:8449", _, extension, "json" when not (String.IsNullOrEmpty extension) -> writeRequestResponse request.Response None
                        | "bannerprodssb.leoncountyfl.gov:8449", _, extension, "xml" when not (String.IsNullOrEmpty extension) -> writeRequestResponse request.Response None
                        *)
                    | host, pathstem, extension, mediaType, subType -> ()
                | _ -> failedRequests.Add request
                return! loop ()
            }
        loop ())

let watchPageNetworkTraffic (page: CdpPage) =
    page.RequestFinished.Add(fun eventArguments -> networkMailbox.Post eventArguments.Request.asCdp)




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


    member this.tabs =
        let pages = this.pageTargets |> Array.map (fun target -> target.AsPageAsync().await.asCdp)

        pages |> Array.iter watchPageNetworkTraffic
        pages


module CdpBrowser =
    let Connect () =

        let options = ConnectOptions()

        options.BrowserURL <- "http://127.0.0.1:9222"
        options.DefaultViewport <- null

        let ibrowser = task { return! Puppeteer.ConnectAsync(options) } |> await

        ibrowser :?> CdpBrowser

    let DownloadText (url: DomUrl) (browser: CdpBrowser) =
        let backTab = browser.NewPageAsync(backgroundOption).await.asCdp
        let response = backTab.GoToAsync(url.Href).await

        url.WriteFileText(response.TextAsync().await)

        backTab.CloseAsync() |> ignore

    let DownloadTextExtension (url: DomUrl) (extension: string) (browser: CdpBrowser) =
        let backTab = browser.NewPageAsync(backgroundOption).await.asCdp
        let response = backTab.GoToAsync(url.Href).await

        url |> DomUrl.WriteFileExtensionText (response.TextAsync().await) extension

        backTab.CloseAsync() |> ignore
