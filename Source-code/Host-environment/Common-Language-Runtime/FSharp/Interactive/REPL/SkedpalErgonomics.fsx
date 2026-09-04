#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"


#r "BrowserErgonomics.dll"
open BrowserErgonomics
#r "PageErgonomics.dll"
open PageErgonomics
#r "TaskErgonomics.dll"
open TaskErgonomics
#r "HtmlErgonomics.dll"
open HtmlErgonomics
#r "CssErgonomics.dll"
open CssErgonomics
open BrowserApi.Css.Authoring
open PuppeteerSharp.Contrib.Extensions

let chrome = CdpBrowser.Connect()

let skedpalTab = chrome.tabs |> Array.find (fun tab -> tab.DomUrl.Host = "app.skedpal.com")



let menuElement = skedpalTab.QuerySelectorAllWithContentAsync(El.I.Css, "menu").await |> Array.map (fun element -> element.asCdp)
skedpalTab.ClickAsync(El.Button * Attr.Tabindex.Equals("0") |> _.Css).await


