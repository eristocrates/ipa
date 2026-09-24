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
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "Ast.fsx"
open SharedKernel
open StringModule
open Internet
open TopLevelDomain
open IanaScheme
open ResourceIdentification
open ResourceDescription
open Iana
#I @"D:\https\com\github\eristocrates\ipa\fsx\Sites"

#load @".paket/load/main.group.fsx"
open PuppeteerSharp
open PuppeteerSharp.Cdp
open FolkerKinzel.MimeTypes

open System
open System.IO
open PuppeteerSharp
open PuppeteerSharp.Cdp

type CdpResponseDownloadConfiguration = {
    shouldDownload: CdpHttpResponse -> bool
    download: CdpHttpResponse -> bool
}

type private NetworkMonitorMessage = FinishedRequest of CdpHttpRequest

let saveTextResponseToLocalReference (response: CdpHttpResponse) =
    match response.Text() with
    | Some text ->
        printfn "%s\t----->\t%s\n\n" response.iriref.remoteReference response.iriref.localReference
        Directory.CreateDirectory(Path.GetDirectoryName response.iriref.localReference)
        |> ignore
        File.WriteAllText(response.iriref.localReference, text)
        true
    | None -> false

let isJsonOrXmlResponse (response: CdpHttpResponse) =
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

type CdpNetworkMonitor private (browser: CdpBrowser, downloadConfiguration: CdpResponseDownloadConfiguration) =

    let finishedRequestCollection = ResizeArray<CdpHttpRequest>()

    let downloadedResponseCollection = ResizeArray<CdpHttpResponse>()

    let failedDownloadCollection = ResizeArray<CdpHttpResponse * exn>()

    let monitoredPageCollection = ResizeArray<CdpPage>()

    let mailbox =
        MailboxProcessor.Start(fun inbox ->

            let rec loop () =
                async {
                    let! message = inbox.Receive()

                    match message with
                    | FinishedRequest request ->

                        lock finishedRequestCollection (fun () -> finishedRequestCollection.Add request)

                        let response = request.Response.asCdp
                        if downloadConfiguration.shouldDownload response then
                            try
                                let downloaded = downloadConfiguration.download response

                                if downloaded then
                                    lock downloadedResponseCollection (fun () -> downloadedResponseCollection.Add response)

                            with exception' ->
                                lock failedDownloadCollection (fun () -> failedDownloadCollection.Add(response, exception'))

                    return! loop ()
                }

            loop ())

    let _monitorPage (page: CdpPage) =

        let targetId = (page.Target :?> CdpTarget).TargetId

        let shouldMonitor =
            lock monitoredPageCollection (fun () ->

                let alreadyMonitored =
                    monitoredPageCollection
                    |> Seq.exists (fun existing -> (existing.Target :?> CdpTarget).TargetId = targetId)

                if alreadyMonitored then
                    false
                else
                    monitoredPageCollection.Add page
                    true)

        if shouldMonitor then
            page.RequestFinished.Add(fun args ->
                match args.Request with
                | :? CdpHttpRequest as request -> mailbox.Post(FinishedRequest request)

                | _ -> ())

    let _monitorTarget (target: CdpTarget) =

        match target.Type with
        | TargetType.Page
        | TargetType.BackgroundPage
        | TargetType.Webview ->

            task {
                let! page = target.PageAsync()

                match page with
                | :? CdpPage as page -> _monitorPage page

                | _ -> ()
            }
            |> ignore

        | _ -> ()

    do
        // This subscription is established immediately.
        // Any page-like target created from this point onward
        // will be picked up automatically.
        browser.TargetCreated.Add(fun args ->
            match args.Target with
            | :? CdpTarget as target -> _monitorTarget target

            | _ -> ())

    member _.finishedRequests = lock finishedRequestCollection (fun () -> finishedRequestCollection.ToArray())

    member _.finishedResponses =
        lock finishedRequestCollection (fun () ->
            finishedRequestCollection
            |> Seq.choose (fun request ->
                match request.Response with
                | :? CdpHttpResponse as response -> Some response

                | _ -> None)
            |> Seq.toArray)

    member _.downloadedResponses = lock downloadedResponseCollection (fun () -> downloadedResponseCollection.ToArray())

    member _.failedDownloads = lock failedDownloadCollection (fun () -> failedDownloadCollection.ToArray())

    member _.monitoredPages = lock monitoredPageCollection (fun () -> monitoredPageCollection.ToArray())

    member this.responsesByMimeType(mimeType: MimeType) =
        this.finishedResponses
        |> Array.filter (fun response ->
            match response.mimeType with
            | Some contentType ->
                contentType.MediaType = mimeType.MediaType
                && contentType.SubType = mimeType.SubType

            | None -> false)

    member private _.MonitorInitialPages(pages: IPage array) =
        pages
        |> Array.iter (fun page ->
            match page with
            | :? CdpPage as page -> _monitorPage page

            | _ -> ())

    static member Create(browser: CdpBrowser, downloadConfiguration: CdpResponseDownloadConfiguration) =
        task {
            // Constructing the monitor installs TargetCreated first.
            //
            // We then enumerate existing pages. This ordering means that
            // pages created while PagesAsync is running are still seen
            // through TargetCreated; monitorPage prevents double subscription.
            let monitor = CdpNetworkMonitor(browser, downloadConfiguration)
            (*
            let! pages = browser.PagesAsync(true)
            monitor.MonitorInitialPages pages
            *)
            return monitor
        }

    static member Create(browser: CdpBrowser) =
        CdpNetworkMonitor.Create(
            browser,
            {
                shouldDownload = fun _ -> false
                download = fun _ -> false
            }
        )
    member this.monitorPage(page: CdpPage) = _monitorPage page
    member this.monitorTarget(target: CdpTarget) = _monitorTarget target
