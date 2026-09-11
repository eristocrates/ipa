#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#time on
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


#r "CalendarErgonomics.dll"
open CalendarErgonomics


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

open BrowserApi
open BrowserApi.Css
open BrowserApi.Css.Authoring
open System.Globalization

// TODO move to html ergonomics
type Attr with
    static member Class = AttrSelector "class"

let (.>) (left: Selector) (right: Selector) : Selector = Selector.op_GreaterThan (left, right)

let (.>>) (left: Selector) (right: Selector) : Selector = Selector.op_RightShift (left, right)

let (.|) (left: Selector) (right: Selector) : Selector = Selector.op_BitwiseOr (left, right)
let (.=) (left: Selector) (right: string) = left.Equals(right)



module gov =
    module leoncountyfl =
        module leonintra =
            let baseUrl = DomUrl "https://leonintra.leoncountyfl.gov/"

            let PayrollCalendar = baseUrl.AppendPath "Departments/Human-Resources/PAYROLL-CALENDARS"

            let FormsDocuments = baseUrl.AppendPath "Forms-Documents"

        module bannerprodssb =

            let baseUrl = DomUrl "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService"

            let hrDashboard = baseUrl.AppendPath "ssb/hrDashboard"
            let payStubSummaryList = hrDashboard.AppendFragmentPath "payStubSummary/list/"

            let payStubSummary (payYear: int) =
                payStubSummaryList.ConcatFragment($"{payYear}")

            let payStubDetails =
                Stipendium.Yearcast
                |> Array.map (fun stipendium ->
                    let payYear = stipendium.stipendiumStartInclusive.Year
                    let payId = "BW"
                    let payNumber = ((stipendium.index + 8) % 26) + 1
                    let paySequence = 0
                    let payDate =
                        match stipendium.stipendiumStartInclusive.ToString("yyyMMdd") with
                        | "20240704" -> "20240703"
                        | dateString -> dateString

                    hrDashboard.AppendFragmentPath $"payStubDetail/{payYear}/{payId}/{payNumber}/{paySequence}/{payDate}")



let chrome = CdpBrowser.Connect()

let bannerTab = chrome.NewPageAsync().await.asCdp
watchPageNetworkTraffic bannerTab

let continueButton = bannerTab.Locator(El.Button * Attr.Type.Equals("submit") |> _.Css)
(*
continueButton.ClickAsync().await
*)



bannerTab.GoToAsync(gov.leoncountyfl.bannerprodssb.hrDashboard.Href).await.asCdp




bannerTab.GoToAsync(gov.leoncountyfl.bannerprodssb.payStubSummaryList.Href).await
Stipendium.Yearcast[26].gregorianOrdinal
Stipendium.Yearcast[26].stipipendarium.gregorianOrdinal

gov.leoncountyfl.bannerprodssb.payStubDetails[0]

gov.leoncountyfl.bannerprodssb.payStubDetails
|> Array.iter (fun payStubDetail ->
    bannerTab.GoToAsync(payStubDetail.Href).await |> ignore
    Thread.Sleep 1000)

// https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/hrDashboard#/payStubDetail/2024/BW/14/0/20240703
// https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/hrDashboard#/payStubDetail/2024/BW/14/0/20240704

bannerTab.GoToAsync(gov.leoncountyfl.bannerprodssb.payStubDetails[0].Href).await

let testRequest =
    finishedRequests
    |> Seq.find (fun request ->
        request.Response.DomUrl.Href = "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/payStubDetail/getPayStubDetail?payDate=20240425&payId=BW&payNumber=9&paySequence=0&payYear=2024")

let lastRequest =
    finishedRequests
    |> Seq.filter (fun request -> request.DomUrl.Href.StartsWith("https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb"))
    |> Seq.last
lastRequest

let PayYearDropdownToggle = bannerTab.Locator(El.Button * Attr.Role.Equals("option") |> _.Css)
let payStubYears =
    bannerTab.QuerySelectorAllAsync(El.A * Attr.Role.Equals("option") * Attr.Class.Equals("ng-binding") |> _.Css).await
    |> Array.map (fun element -> element.asCdp)
payStubYears
|> Array.map (fun payStubYear ->

    PayYearDropdownToggle.ClickAsync().await
    Thread.Sleep 500
    payStubYear.ClickAsync().await
    Thread.Sleep 500

)

PayYearDropdownToggle.ClickAsync().await
payStubYears[0].ClickAsync().await


PayYearDropdownToggle.ClickAsync().await
payStubYears[1].ClickAsync().await


PayYearDropdownToggle.ClickAsync().await
payStubYears[2].ClickAsync().await


let payDates =
    bannerTab.QuerySelectorAllAsync(El.A * Attr.Class.Equals("list-group-item ng-scope") |> _.Css).await
    |> Array.map (fun element -> element.asCdp)

payDates[0].outerHTML
bannerTab.GoToAsync(gov.leoncountyfl.bannerprodssb.payStubSummary 2024 |> _.Href).await
bannerTab.GoToAsync(gov.leoncountyfl.bannerprodssb.payStubSummary 2025 |> _.Href).await
bannerTab.GoToAsync(gov.leoncountyfl.bannerprodssb.payStubSummary 2026 |> _.Href).await

let employeeTest = DomUrl "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/menu"
