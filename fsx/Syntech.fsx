#time on

fsi.PrintLength <- 10
fsi.PrintSize <- 100

// fsi.ShowDeclarationValues <- false
#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "SharedKernel.dll"
#r "StringModule.dll"
#r "Internet.dll"
#r "TopLevelDomain.dll"
#r "IanaScheme.dll"
#r "ResourceIdentification.dll"
#r "ResourceDescription.dll"
#r "Iana.dll"
#r "IanaScheme.dll"
#r "IanaMime.dll"
#r "NetworkMonitor.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "Ast.fsx"
open SharedKernel
open StringModule
open Internet
open ResourceIdentification
open ResourceDescription
open Iana
open NetworkMonitor
#I @"D:\https\com\github\eristocrates\ipa\fsx\Sites"
open System
open System.IO
open System.Xml.Linq
open FSharp.Data
open Fabulous.AST
open Fantomas.Core
open PosInformatique.Foundations.EmailAddresses
open PhoneNumbers
open GoogleApi.Entities.Common

module com =
    let topLevelDomain = TopLevelDomain.com
    module myfuelmaster =
        let host = topLevelDomain .+ "myfuelmaster"
        let site = IanaScheme.https ..// host
        module contact_support =
            let page = site / "contact-support"

module MaintenancePlan =

    [<Literal>]
    let sample =
        """<select data-is-required="true" class="validation-strict" data-field-id="field9" name="field9" data-placement="right" data-toggle="tooltip" tooltip="" data-trigger="hover" data-html="true" data-original-title="" data-gtm-form-interact-field-id="0" style="border: 1px solid rgb(198, 6, 18); border-radius: 2px; --darkreader-inline-border-top: var(--darkreader-border-c60612, #bc0611); --darkreader-inline-border-right: var(--darkreader-border-c60612, #bc0611); --darkreader-inline-border-bottom: var(--darkreader-border-c60612, #bc0611); --darkreader-inline-border-left: var(--darkreader-border-c60612, #bc0611);" data-darkreader-inline-border-top="" data-darkreader-inline-border-right="" data-darkreader-inline-border-bottom="" data-darkreader-inline-border-left=""><option value="" class=" ">Select An Option</option><option value="Distributor" class=" ">Distributor</option><option value="DoD" class=" ">DoD</option><option value="Maintenance" class=" ">Maintenance</option><option value="Warranty" class=" ">Warranty</option><option value="Unsure" class=" ">Unsure</option></select>"""
    type Provider = XmlProvider<UseOriginalNames=true, Sample=sample>
    let select = Provider.Parse sample
    let options =
        select.options
        |> Array.choose (fun option -> Option.tryNullOrWhiteSpace option.value)

    let codegenAstUnion () =
        Ast.Oak() {
            Ast.AnonymousModule() {
                Ast.Union("MaintenancePlan") {
                    for option in options do
                        Ast.UnionCase option
                }
            }
        }
        |> Gen.mkOak
        |> Gen.run

module IssueType =

    [<Literal>]
    let sample =
        """<select data-is-required="true" class="validation-strict" data-field-id="field5" name="field5" data-placement="right" data-toggle="tooltip" tooltip="" data-trigger="hover" data-html="true" data-original-title=""><option value="" class=" ">Select An Option</option><option value="Cannot Download" class=" ">Cannot Download</option><option value="Instructional Question" class=" ">Instructional Question</option><option value="Part Order" class=" ">Part Order</option><option value="Site is Down and Cannot Fuel" class=" ">Site is Down and Cannot Fuel</option><option value="Software" class=" ">Software</option></select>"""
    type Provider = XmlProvider<UseOriginalNames=true, Sample=sample>
    let select = Provider.Parse sample
    let options =
        select.options
        |> Array.choose (fun option -> Option.tryNullOrWhiteSpace option.value)

    let codegenAstUnion () =
        Ast.Oak() {
            Ast.AnonymousModule() {
                Ast.Union("IssueType") {
                    for option in options do
                        Ast.UnionCase option
                }
            }
        }
        |> Gen.mkOak
        |> Gen.run

// MaintenancePlan.codegenAstUnion().clip
// IssueType.codegenAstUnion().clip

(*

let selectedElements = El.Span * Attr.Class.Equals("main-label")  |> tab.Realm.document.QuerySelectorAll
let labelElements = tab.Realm.document.QuerySelectorAll El.Label

let labels =
    labelElements |> Array.choose (fun label ->  
        Attr.Class.Equals("main-label") |> label.QuerySelector |> Option.ofObj |> Option.map (fun element -> element.TextContent)
    )

labels
|> String.concat "\n"
|> String.Clipboard.SetText

selectedElements |> Array.map (fun element -> element.TextContent)

*)

type MaintenancePlan =
    | Distributor
    | DoD
    | Maintenance
    | Warranty
    | Unsure

type IssueType =
    | ``Cannot Download``
    | ``Instructional Question``
    | ``Part Order``
    | ``Site is Down and Cannot Fuel``
    | Software

type ContactSupportForm = {
    Name: string
    CompanyName: string
    Email: EmailAddress
    Phone: PhoneNumber
    MaintenancePlan: MaintenancePlan
    IssueType: IssueType option
    Address: Address
    Description: string
}

let formTemplate = {
    Name = "Brandon Collier"
    CompanyName = "Leon County BOCC"
    Email = EmailAddress.Parse "collierb@leoncountyfl.gov"
    Phone = PhoneNumber.Parse "8506061562"
    MaintenancePlan = Maintenance
    IssueType = None
    Address = Address "301 S Monroe St. Tallahassee, FL 32301"
    Description = ""
}
let form = {
    formTemplate with
        IssueType = Some ``Cannot Download``
        Description = "No info in the status logger when we try to execute a manual download after adding vehicles"
}
