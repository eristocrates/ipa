open System
open System.IO
open System.Text
open System.Text.RegularExpressions
open System.Threading.Tasks

#load @".paket/load/main.group.fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#r "Ipa.dll"
open Ipa
#r "Iana.dll"
open Iana
#r "IanaScheme.dll"
open PuppeteerSharp.Cdp
open BrowserApi.Css.Authoring

let chrome = CdpBrowser.Connect()
let inforTab = chrome.NewPageAsync().await.asCdp


type InforEnvironment =
    | InforProd
    | InforTest

    member this.asString = this.ToString()
    member this.databasePath =
        match this with
        | InforProd -> "operations"
        | InforTest -> "test_operations"
    member this.subdomain = this.asString.ToLowerInvariant()

type InforSite = {
    siteRoot: AbsoluteRoot
    myInforPage: ResolvedResource
} with

    static member fromEnvironment(inforEnvironment: InforEnvironment) =
        let site = IanaScheme.https ..// $"{inforEnvironment.asString}.leoncountyfl.gov"
        {
            siteRoot = site
            myInforPage = site ./ inforEnvironment.databasePath
        }
type InforEnvironment with
    member this.site = InforSite.fromEnvironment this

InforProd.site.myInforPage

type CdpPage with
    member this.Locator(selector: Selector) = this.Locator(selector.Css)
type CdpFrame with
    member this.Locator(selector: Selector) = this.Locator(selector.Css)
let formCodeInput = inforTab.Locator(El.Input * Attr.Id.Equals("__formcodeinput__"))
formCodeInput.FillAsync("REM").await





//
