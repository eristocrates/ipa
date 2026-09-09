#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
# time on
fsi.ShowDeclarationValues <- true




#r "Metaprogramming.dll"

open Metaprogramming
#r "PathErgonomics.dll"

open PathErgonomics
#r "BrowserErgonomics.dll"
open BrowserErgonomics
#r "PageErgonomics.dll"
open PageErgonomics
#r "HtmlErgonomics.dll"
open HtmlErgonomics
#r "TaskErgonomics.dll"
open TaskErgonomics
#r "SparqlErgonomics.dll"
open SparqlErgonomics

#r "RdfAsm.dll"

open RdfAsm

#r "RdfIO.dll"

open RdfIO

#r "RdfDsl.dll"

open RdfDsl

#r "UrlErgonomics.dll"

open UrlErgonomics

open FSharp.Data
open FSharp.Configuration
open Dubzer.WhatwgUrl
open PuppeteerSharp
open PuppeteerSharp.Cdp
open FsHttp
open System.IO.Compression
open System.IO
open VDS.RDF.Query.Datasets
open VDS.RDF
open VDS.RDF.Parsing
open System
open System.Linq
open FolkerKinzel.MimeTypes
open IriTools
open System.Threading
open Humanizer

open BrowserApi.Css.Authoring




module gov =
    module leoncountyfl =
        module leonintra =
            let baseUrl = DomUrl "https://leonintra.leoncountyfl.gov/"

            let PayrollCalendar =
                baseUrl.AppendPath "Departments/Human-Resources/PAYROLL-CALENDARS"

            let FormsDocuments = baseUrl.AppendPath "Forms-Documents"

        module bannerprodssb =

            let baseUrl =
                DomUrl "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService"

            let hrDashboard = baseUrl.AppendPath "ssb/hrDashboard"
            let payStubSummaryList = hrDashboard.AppendFragmentPath "payStubSummary/list"

            let payStubSummary (payYear: int) =
                payStubSummaryList.ConcatFragment(string payYear)




let chrome = CdpBrowser.Connect()

let bannerTab = chrome.NewPageAsync().await.asCdp
watchPageNetworkTraffic bannerTab
let testResponse = bannerTab.GoToAsync(gov.leoncountyfl.bannerprodssb.hrDashboard.Href).await.asCdp

testResponse

let bannerRequests = 
    finishedRequests
    |> Seq.filter (fun request -> request.Response.DomUrl.Host = gov.leoncountyfl.bannerprodssb.hrDashboard.Host )
    |> Seq.toArray

bannerRequests[0].Response.Headers["content-type"] |> MimeType.Parse
let continueButton = bannerTab.Locator(El.Button * Attr.Type.Equals("submit") |> _.Css)
continueButton.ClickAsync().await







gov.leoncountyfl.bannerprodssb.payStubSummary 2025

let employeeTest =
    DomUrl "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/menu"
