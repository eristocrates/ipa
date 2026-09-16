#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

open System
open System.IO
open System.Xml.Linq
open System.Collections
#load @".paket/load/main.group.fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#r "Ipa.dll"
open Ipa

#r "FSLang.dll"
#r "Ast.dll"

open FSharp.Data

open Fabulous.AST
open Fantomas.Core
open FsHttp
open PuppeteerSharp
open PuppeteerSharp.Cdp

open Dubzer.WhatwgUrl
open FolkerKinzel.MimeTypes
open ktsu.Semantics.Paths

[<RequireQualifiedAccess>]
type Status =
    | Permanent
    | Provisional
    | Historical
    | UnknownStatus of string

type IanaScheme = {
    lexicalForm: string
    description: string option
    status: Status
    criSchemeNumber: int
    wellKnownUriSupport: string option
}

module uri =
    module schemes =
        // https://www.iana.org/assignments/uri-schemes/uri-schemes.xml
        // [<Literal>]
        // let filePath = @"https/org/iana/www/assignments/uri-schemes/uri-schemes.xml"

        let xml = XmlProvider<"https://www.iana.org/assignments/uri-schemes/uri-schemes.xml">.Load "https://www.iana.org/assignments/uri-schemes/uri-schemes.xml"

module https =
    module org =
        module iana =
            module www =
                module assignments =
                    module uri_schemes =
                        type UriSchemesXmlProvider = XmlProvider<UseOriginalNames=true, Sample="https://www.iana.org/assignments/uri-schemes/uri-schemes.xml">
                        let xml = UriSchemesXmlProvider.Load "https://www.iana.org/assignments/uri-schemes/uri-schemes.xml"
                    module media_types =
                        type MediaTypesXmlProvider = XmlProvider<UseOriginalNames=true, Sample="https://www.iana.org/assignments/media-types/media-types.xml">
                        let xml = MediaTypesXmlProvider.Load("https://www.iana.org/assignments/media-types/media-types.xml")

open https.org.iana.www.assignments
let schemeRegistry =
    uri_schemes.xml.registries
    |> Array.find (fun registry -> registry.title = "Uniform Resource Identifier (URI) Schemes")

let schemes =
    schemeRegistry.records
    |> Array.distinctBy (fun scheme -> scheme.value.Value.XElement.Value)
    |> Array.Parallel.filter (fun scheme -> not (scheme.value.Value.XElement.Value.Contains("OBSOLETE")))

let schemeLexicalFormRecords =
    schemes
    |> Array.Parallel.map (fun scheme ->

        let namespaceUriStringMeta = scheme.XElement.Name.NamespaceName
        let lexicalFormMeta = scheme.value.Value.XElement.Value

        let descriptionMeta =
            if scheme.description.Value.Value.Value = lexicalFormMeta then
                "None"
            else
                $"Some(\"\"\"{scheme.description.Value.Value.Value.TrimStart().TrimEnd()}\"\"\")"

        let statusMeta =
            match scheme.status.Value with
            | "Permanent" -> Status.Permanent
            | "Provisional" -> Status.Provisional
            | "Historical" -> Status.Historical
            | unknown -> Status.UnknownStatus unknown

        let criSchemeNumberMeta = scheme.cri.Value

        // TODO fix wellKnownUriSupport
        let wellKnownUriSupportMeta =
            match scheme.``well-known`` with
            | _ when scheme.``well-known``.IsSome ->
                match scheme.``well-known``.Value.Value with
                | _ when scheme.``well-known``.Value.Value.IsSome ->
                    match scheme.``well-known``.Value.Value.Value with
                    | "-" -> "None"
                    | "" -> "None"
                    | _ -> $"""Some("{scheme.``well-known``.Value.Value.Value}")"""
                | _ -> "None"
            | _ -> "None"

        lexicalFormMeta,
        [|
            Ast.RecordFieldExpr("lexicalForm", Ast.String lexicalFormMeta)
            Ast.RecordFieldExpr("description", string descriptionMeta)
            Ast.RecordFieldExpr("status", Ast.ConstantExpr $"Iana.Status.{statusMeta}")
            Ast.RecordFieldExpr("criSchemeNumber", Ast.Int criSchemeNumberMeta)
            Ast.RecordFieldExpr("wellKnownUriSupport", string wellKnownUriSupportMeta)
        |]
        |> Ast.RecordExprValue lexicalFormMeta



    )


let schemeBindings =
    schemeLexicalFormRecords
    |> Array.map (fun (schemeLexicalForm, _) ->
        let schemeBinder = FSLang.VariableBinder schemeLexicalForm
        schemeBinder.binding)

let codegenSchemes () =
    Ast.Oak() {
        Ast.AnonymousModule() {
            Ast.Open("System")
            Ast.HashDirective("load", Ast.VerbatimString(@".paket/load/main.group.fsx"))
            Ast.HashDirective("I", Ast.VerbatimString(@"D:\https\com\github\eristocrates\ipa\fsx\"))
            Ast.HashDirective("r", Ast.VerbatimString("Iana.dll"))
            Ast.Open("Iana")
            for _, schemeRecord in schemeLexicalFormRecords do
                schemeRecord
            schemeBindings
            |> Ast.ArrayExprValue "all" (fun schemeBinding -> Ast.ConstantExpr schemeBinding)
        }
    }
    |> Gen.mkOak
    |> Gen.run
    |> fun text -> File.WriteAllText(@"D:\https\com\github\eristocrates\ipa\fsx\IanaScheme.fsx", text)







type IanaNote = IanaNote of int
type IanaRfc = IanaRfc of string
type IanaRfcErrata = IanaRfcErrata of String
type IanaUrl = IanaUrl of DomUrl

type IanaPerson = {
    id: string
    name: string
    org: string option
    updated: DateTime option
    urls: DomUrl array
}

type IanaXRef = { xrefType: string; xrefData: string }



let ianaPeople =
    https.org.iana.www.assignments.media_types.xml.people.persons
    |> Array.map (fun person ->
        let name =
            match person.name with
            | Some name -> name
            | None -> person.id

        {
            id = person.id
            name = name
            org = person.org
            updated = person.updated
            urls =
                person.uris
                |> Array.choose (fun maybeUri -> maybeUri)
                |> Array.map (fun uri -> DomUrl uri)
        })

let ianaPersonByName = ianaPeople |> Array.map (fun person -> person.name, person) |> Map.ofArray

type IanaDocProvider = JsonProvider<UseOriginalNames=true, OmitNullFields=true, RootName="doc", Sample= @"D:\https\org\ietf\datatracker\sample\doc.json">
type IanaDraft = {
    draftName: string
    draftRevision: int
} with

    member this.docUrl = DomUrl $"https://datatracker.ietf.org/doc/{this.draftName}/doc.json"
    member this.GetDocJson() =
        http { GET this.docUrl.Href }
        |> Request.send
        |> Response.toText
        |> IanaDocProvider.Parse



type IanaMediaType = {
    registry: string
    name: string
    xrefs: IanaXRef array
    file: string
    extension: string
    mime: MimeType
// tokens: string array
// type_iri: string
// resource_iri: string
} with

    member this.fileExtension = FileExtension.Create this.extension

    member this.rfcXrefs = this.xrefs |> Array.filter (fun xref -> xref.xrefType = "rfc")
    member this.personXrefs = this.xrefs |> Array.filter (fun xref -> xref.xrefType = "person")
    member this.uriXrefs = this.xrefs |> Array.filter (fun xref -> xref.xrefType = "uri")
    member this.draftXrefs = this.xrefs |> Array.filter (fun xref -> xref.xrefType = "draft")
    member this.rfcErrataXrefs = this.xrefs |> Array.filter (fun xref -> xref.xrefType = "rfc-errata")
    member this.noteXrefs = this.xrefs |> Array.filter (fun xref -> xref.xrefType = "note")
    member this.ianaDrafts =
        this.draftXrefs
        |> Array.map (fun xref ->
            let segments = xref.xrefData.Replace("RFC-", "draft-").Split('-')
            {
                draftName = segments[.. segments.Length - 2] |> String.concat "-"
                draftRevision = segments |> Array.last |> int
            })
    member this.ianaPeople =
        this.personXrefs
        |> Array.map (fun personXref -> ianaPersonByName[personXref.xrefData])
let IanaMediaTypes =
    https.org.iana.www.assignments.media_types.xml.registries
    // |> Array.take 1
    |> Array.collect (fun registry ->
        registry.records
        // |> Array.randomSample 1
        |> Array.map (fun record ->
            let xrefs =
                record.xrefs
                |> Array.choose (fun xref ->
                    match xref.data.String with
                    | Some data ->
                        Some {
                            xrefType = xref.``type``
                            xrefData = data
                        }
                    | None -> None)
            // record,
            let mimeType = MimeType.Parse record.file.Value
            {
                registry = registry.title
                name = record.name.Value.Value
                xrefs = xrefs
                file = record.file.Value
                extension = mimeType.GetFileTypeExtension(true)
                mime = mimeType

            }))

let IanaMediaTypesGroupedByDotExtension =
    IanaMediaTypes
    |> Array.groupBy (fun IanaMediaType -> IanaMediaType.extension)
    |> Array.sortBy (fun (dotExtension, mediaTypes) -> mediaTypes.Length)
    |> Array.rev
let IanaMediaTypesByDotExtension = IanaMediaTypesGroupedByDotExtension |> Map.ofArray
