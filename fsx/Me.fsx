// TODO use dynamic operator for namespacenames for adhoc local names

#time on

fsi.PrintLength <- 10
fsi.PrintSize <- 100

// fsi.ShowDeclarationValues <- false
#I @"D:\https\com\github\eristocrates\ipa\dll"
// #r "SharedKernel.dll"
// #r "StringModule.dll"
// #r "Internet.dll"
// #r "TopLevelDomain.dll"
// #r "IanaScheme.dll"
// #r "ResourceIdentification.dll"
// // #r "ResourceDescription.dll"
// #r "Iana.dll"
// #r "IanaScheme.dll"
// #r "IanaMime.dll"
// #r "NetworkMonitor.dll"
// #r "Turtle.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
// #load "Ast.fsx"
// open SharedKernel
// open StringModule
// open Internet
// open ResourceIdentification
// // open ResourceDescription
// open Turtle
// open Iana
// open NetworkMonitor
// // #I @"D:\https\com\github\eristocrates\ipa\fsx\Sites"

#load @".paket/load/main.group.fsx"
open System
// open PuppeteerSharp
// open PuppeteerSharp.Cdp
// open FolkerKinzel.MimeTypes
// open System.Web
// open IriTools
//
// open System.Collections
// open System.Text
// open System.IO
// open System.Linq
// open PuppeteerSharp
// open PuppeteerSharp.Cdp
// open Tavis.UriTemplates
// open BrowserApi.Css.Authoring
// open BrowserApi.Css
// open BrowserApi
// open Meziantou.Framework
// open System.Threading
// open VDS.RDF
// open FSharp.Data
// open VDS.RDF.Parsing
// open Universal.Common
// open RDFSharp.Model
// open AW.Identifiers
// open LSL.DataUri
// open VDS.RDF.Ontology
// open OWLSharp
// open OWLSharp.Validator
// open OWLSharp.Reasoner
// open OWLSharp.Profiler
// open OWLSharp.Ontology
// open OWLSharp.Extensions
// open System.Globalization
// open System.Xml
// open Dubzer.WhatwgUrl

type Birthday =
    | Birthday of DateOnly

    member this.asDateOnly =
        match this with
        | Birthday date -> date

    member this.ageAtDate(date: DateOnly) =
        let birthDate = this.asDateOnly
        let age = date.Year - birthDate.Year

        if (date.Month, date.Day) < (birthDate.Month, birthDate.Day) then
            age - 1
        else
            age

    member this.currentAge = DateOnly.FromDateTime(DateTime.Now) |> this.ageAtDate
let myBirthday = new DateOnly(1991, 7, 5) |> Birthday
let myFirstName = "Brandon"
let myLastName = "Collier"
let myUsername = "eristocrates"
let syrisBirthday = new DateOnly(1993, 5, 28) |> Birthday
let syrisFirstName = "Tierra"
let syrisLastName = "Fisher"
let syrisUsername = "syrislove"
