#r "nuget: FSharp.Data"
#r "nuget: Microsoft.Playwright"
#r "nuget: FsHttp"

open System
open System.IO
open FSharp.Data
open System
open System.Net
open FSharp.Data


open FsHttp


open Microsoft.Playwright

let ensurePlaywrightBrowsersInstalled () =
    // Officially supported: invoke Playwright CLI via API.
    // Docs: Microsoft.Playwright.Program.Main(new[] {"install"})
    let exitCode = Microsoft.Playwright.Program.Main [| "install" |]

    if exitCode <> 0 then
        failwith $"Playwright browser install failed (exit {exitCode})."

ensurePlaywrightBrowsersInstalled ()

let run () =
    task {
        ensurePlaywrightBrowsersInstalled ()

        use! pw = Playwright.CreateAsync()
        let! browser = pw.Chromium.LaunchAsync(BrowserTypeLaunchOptions(Headless = true))

        let! page = browser.NewPageAsync()
        let! _ = page.GotoAsync("https://www.novelupdates.com/novelslisting/")
        let! title = page.TitleAsync()
        printfn "Title: %s" title

        let! html = page.ContentAsync()
        printfn "HTML length: %d" html.Length

        do! browser.CloseAsync()
    }

run().GetAwaiter().GetResult()
let uri = "https://www.novelupdates.com/novelslisting/"

let response =
    http {
        GET uri
        UserAgent "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:147.0) Gecko/20100101 Firefox/147.0"
        Accept "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
        AcceptLanguage "en-US,en;q=0.9"
        print_withResponseBodyExpanded
    }
    |> Request.send

let cookieContainer = CookieContainer()

let fetch (url: string) =
    Http.Request(
        url,
        silentHttpErrors = true,
        cookieContainer = cookieContainer,
        headers =
            [ "User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:147.0) Gecko/20100101 Firefox/147.0"
              "Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
              "Accept-Language", "en-US,en;q=0.9"
              "Referer", url
              "Upgrade-Insecure-Requests", "1" ]
    )


let test = fetch uri
test.Body

let html = test.Load "https://en.wikipedia.org/wiki/Metric_prefix"
// type provider = HtmlProvider<uri>

module novelupdates =
    module add =
        module release =
            // Novel Updates Links
            [<Literal>]
            let uri = "https://www.novelupdates.com/add-release/"

        module series =

            [<Literal>]
            let series = "https://www.novelupdates.com/add-series/"

    module novelslisting =
        [<Literal>]
        let uri = "https://www.novelupdates.com/novelslisting/"

    // type provider = HtmlProvider<uri>
    // let html = HtmlDocument.Load(uri)

    module groupslist =
        [<Literal>]
        let uri = "https://www.novelupdates.com/groupslist"
        // type provider = HtmlProvider<uri>
        let html = HtmlDocument.Load(uri)

        module paginated =

            let html (pageIndex: int) =
                HtmlDocument.Load($"{uri}?pg={pageIndex}")


module group =
    //Groups Links
    module Citrus_aurora =
        [<Literal>]
        let all_novels = "https://citrusaurora.com/all-novels/"

        module when_the_guide_stopped_playing_a_villainess_the_obsession_began =
            [<Literal>]
            let uri =
                "https://citrusaurora.com/series/when-the-guide-stopped-playing-a-villainess-the-obsession-began/"

            type provider = HtmlProvider<uri>
            let html = provider.Load(uri)
