open System
open Microsoft.Playwright

let ensurePlaywrightBrowsersInstalled () =
    // Officially supported: invoke Playwright CLI via API.
    // Docs: Microsoft.Playwright.Program.Main(new[] {"install"})
    let exitCode = Microsoft.Playwright.Program.Main [| "install" |]
    if exitCode <> 0 then
        failwith $"Playwright browser install failed (exit {exitCode})."

let run () =
    task {
        ensurePlaywrightBrowsersInstalled ()

        use! pw = Playwright.CreateAsync()
        let! browser =
            pw.Chromium.LaunchAsync(
                BrowserTypeLaunchOptions(
                    Headless = true
                )
            )

        let! page = browser.NewPageAsync()
        let! _ = page.GotoAsync("https://www.novelupdates.com/novelslisting/")
        let! title = page.TitleAsync()
        printfn "Title: %s" title

        let! html = page.ContentAsync()
        printfn "HTML length: %d" html.Length

        do! browser.CloseAsync()
    }

run().GetAwaiter().GetResult()
