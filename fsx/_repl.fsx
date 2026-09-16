open System
open System.IO
open System.Linq
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

#r "RdfAsm.dll"
open RdfAsm
#r "RdfIO.dll"
open RdfIO
#r "ManualDistributions.dll"
open ManualDistributions
#r "Turtle.dll"
#r "ResolvedResource.dll"
#r "Lov.dll"
open Lov
#r "NamespaceErgonomics.dll"
open NamespaceErgonomics



open PuppeteerSharp.Cdp
open BrowserApi.Css.Authoring
open FolkerKinzel.MimeTypes
open System.Collections
open VDS.RDF
open VDS.RDF.Parsing
open System.Net.Http
open RDFSharp.Model
open VDS.RDF.Query.Datasets




#I @"D:\https\com\github\eristocrates\ipa\fsx\Namespaces\Generated"
#load "RdfNamespace.fsx"
open RdfNamespace




let chrome = CdpBrowser.Connect()
chrome.TargetCreated
let replTab = chrome.NewPageAsync().await.asCdp
watchPageNetworkTraffic replTab
replTab.GoToAsync("https://dh.obdurodon.org/xproc-tutorial.xhtml").await

// https://xproc.org/specifications.html

finishedRequests.Count()
finishedRequests
|> Seq.filter (fun request -> request.Response.resource.host.remoteReference = "claims.akko.app")

let finishedRequest = finishedRequests |> Seq.head
finishedRequest.Response.mediaType














//
