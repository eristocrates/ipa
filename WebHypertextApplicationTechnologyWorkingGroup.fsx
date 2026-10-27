// TODO use dynamic operator for namespacenames for adhoc local names

#time on

fsi.PrintLength <- 10
fsi.PrintSize <- 100

// fsi.ShowDeclarationValues <- true
#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "SharedKernel.dll"
#r "StringModule.dll"
#r "Internet.dll"
#r "TopLevelDomain.dll"
//#r "ResourceIdentification.dll"
// #r "ResourceDescription.dll"
// #r "Iana.dll"
// #r "IanaScheme.dll"
// #r "IanaMime.dll"
#r "NetworkMonitor.dll"
#r "Turtle.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "Ast.fsx"
#load "Me.fsx"

open SharedKernel
open StringModule
open Internet
// open ResourceIdentification
open Me
// open ResourceDescription
open Turtle
// open Iana
open NetworkMonitor
// #I @"D:\https\com\github\eristocrates\ipa\fsx\Sites"

#load @".paket/load/main.group.fsx"

open PuppeteerSharp
open PuppeteerSharp.Cdp
open FolkerKinzel.MimeTypes
open System.Web
open IriTools

open System
open System.Collections
open System.Text
open System.IO
open System.Linq
open PuppeteerSharp
open PuppeteerSharp.Cdp
open Tavis.UriTemplates
open BrowserApi.Css.Authoring
open BrowserApi.Css
open BrowserApi
open Meziantou.Framework
open System.Threading
open VDS.RDF
open FSharp.Data
open VDS.RDF.Parsing
open Universal.Common
open RDFSharp.Model
open AW.Identifiers
open LSL.DataUri
open VDS.RDF.Ontology
open OWLSharp
open OWLSharp.Validator
open OWLSharp.Reasoner
open OWLSharp.Profiler
open OWLSharp.Ontology
open OWLSharp.Extensions
open System.Globalization
open System.Xml
open Dubzer.WhatwgUrl
open System.Net
// https://html.spec.whatwg.org/dev/browsers.html
type Origin =
    | OpaqueOrigin
    | TupleOrigin of TupleOrigin

and TupleOrigin =
    { scheme: string
      host: Host
      port: int option
      domain: Host option }

/// https://url.spec.whatwg.org/#host-representation
and Host =
    | DomainHost of Domain
    | IPAddressHost of InternetProtocolAddress
    | OpaqueHost of string
    | EmptyHost

and InternetProtocolAddress =
    | IPv4Address of UInt32
    | IPv6Address of UInt128

and Domain =
    { realmIdentifier: string }

    member this.domainLabels = this.realmIdentifier.Split('.')
