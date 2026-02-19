#if INTERACTIVE

#endif

open System
open Microsoft.Playwright


let private runAsync () =
    task {
        use! playwright = Playwright.CreateAsync()

        let! browser = playwright.Chromium.LaunchAsync(BrowserTypeLaunchOptions(Headless = true))

        let! page = browser.NewPageAsync()

        let! _ = page.GotoAsync("https://example.com")

        let opts = PageScreenshotOptions()
        opts.Path <- "artifacts/adhoc/example.png"
        opts.FullPage <- true

        let! _ = page.ScreenshotAsync(opts)

        do! browser.CloseAsync()
    }

runAsync().GetAwaiter().GetResult()
