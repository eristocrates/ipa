#time on

fsi.PrintLength <- 1
fsi.PrintSize <- 3000
fsi.ShowDeclarationValues <- true

#load @".paket/load/main.group.fsx"
open System
open OpenQA.Selenium
open OpenQA.Selenium.Edge
open OpenQA.Selenium.Remote
open canopy
open canopy.classic
open BrowserApi.Css.Authoring
open System.Collections.Concurrent
open OpenQA.Selenium

open PuppeteerSharp
open PuppeteerSharp.Cdp

let options = EdgeOptions()

// Attach to our existing Edge instance.
options.DebuggerAddress <- "127.0.0.1:9222"

// Connect to the EdgeDriver service already running through the shim.
let edge = new RemoteWebDriver(Uri("http://127.0.0.1:9515"), options)
printfn "Title: %s" edge.Title
printfn "URL: %s" edge.Url
printfn "Tabs: %d" edge.WindowHandles.Count

// Use the existing RemoteWebDriver session.
browser <- edge

type RemoteWebDriver with
    member this.bringToFront() =
        this.SwitchTo().Window(edge.CurrentWindowHandle)
    member this.tabs =
        let currentWindowHandle = edge.CurrentWindowHandle
        let titleUrls =
            this.WindowHandles
            |> Seq.toArray
            |> Array.map (fun handle ->
                this.SwitchTo().Window(handle) |> ignore
                printfn "\n%s\n\t| %s\n" this.Title this.Url
                this.Title, this.Url)
        this.SwitchTo().Window(currentWindowHandle) |> ignore
        titleUrls

edge.tabs.Length
edge.CurrentWindowHandle
edge.Title
edge.bringToFront ()
let border (selector: Selector) = highlight <| selector.Css
border El.A
edge.bringToFront ()
click "Overview"

let puppeteer = Puppeteer.ConnectAsync(ConnectOptions(BrowserURL = "http://127.0.0.1:9222")).GetAwaiter().GetResult() :?> CdpBrowser
