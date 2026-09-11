#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
open System
open FSharp.Data
open FolkerKinzel.MimeTypes
open Dubzer.WhatwgUrl
open FsHttp


module https =
    module org =
        module iana =
            module www =
                module assignments =
                    module media_types =
                        type MediaTypesXmlProvider = XmlProvider<UseOriginalNames=true, Sample="https://www.iana.org/assignments/media-types/media-types.xml">
                        let xml = MediaTypesXmlProvider.Load("https://www.iana.org/assignments/media-types/media-types.xml")


type IanaNote = IanaNote of int
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


https.org.iana.www.assignments.media_types.xml.category
https.org.iana.www.assignments.media_types.xml.expert
https.org.iana.www.assignments.media_types.xml.id
https.org.iana.www.assignments.media_types.xml.notes
https.org.iana.www.assignments.media_types.xml.people.persons[0]

https.org.iana.www.assignments.media_types.xml.registration_rule.xref.``type``
https.org.iana.www.assignments.media_types.xml.registration_rule.xref.data
https.org.iana.www.assignments.media_types.xml.title
https.org.iana.www.assignments.media_types.xml.updated

let ianaXrefs =
    let xrefs =
        https.org.iana.www.assignments.media_types.xml.xrefs
        |> Array.map (fun xref -> {
            xrefType = xref.``type``
            xrefData = xref.data
        })
    let footnoteXrefs =
        https.org.iana.www.assignments.media_types.xml.registries
        |> Array.collect (fun registry ->
            registry.footnotes
            |> Array.collect (fun footnote ->
                footnote.xrefs
                |> Array.map (fun xref -> {
                    xrefType = xref.``type``
                    xrefData = xref.data
                })))
    let recordXrefs =
        https.org.iana.www.assignments.media_types.xml.registries
        |> Array.collect (fun registry ->
            registry.records
            |> Array.collect (fun record ->
                record.xrefs
                |> Array.choose (fun xref ->
                    match xref.data.String with
                    | Some data ->
                        Some {
                            xrefType = xref.``type``
                            xrefData = data
                        }
                    | None -> None)))
    Array.concat [| xrefs; footnoteXrefs; recordXrefs |]
    |> Array.distinct
    |> Array.sortBy (fun xref -> xref.xrefType, xref.xrefData)

ianaXrefs |> Array.map (fun xref -> xref.xrefType) |> Array.distinct


let draftXrefs = ianaXrefs |> Array.filter (fun xref -> xref.xrefType = "draft")




type IanaDocProvider =
    JsonProvider<
        UseOriginalNames=true,
        OmitNullFields=true,
        RootName="doc",
        Sample= @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\sampleIanaDraft.json"
     >


type IanaDraft = {
    draftName: string
    draftRevision: int
} with

    static member fromString(draftString: string) =
        let segments = draftString.Replace("RFC-", "draft-").Split('-')
        {
            draftName = segments[.. segments.Length - 2] |> String.concat "-"
            draftRevision = segments |> Array.last |> int
        }
    member this.rfcName = sprintf "%s-%d" (this.draftName.Replace("draft-", "RFC-")) this.draftRevision

    member this.docUrl = DomUrl $"https://datatracker.ietf.org/doc/{this.draftName}/doc.json"
    member this.GetDocJson() =
        http { GET this.docUrl.Href }
        |> Request.send
        |> Response.toText
        |> IanaDocProvider.Parse




let ianaDrafts =
    draftXrefs
    |> Array.map (fun xref ->
        let segments = xref.xrefData.Replace("RFC-", "draft-").Split('-')
        {
            draftName = segments[.. segments.Length - 2] |> String.concat "-"
            draftRevision = segments |> Array.last |> int
        })
let ianaDraftsByRfcName =
    ianaDrafts
    |> Array.map (fun ianaDraft -> ianaDraft.rfcName, ianaDraft)
    |> Map.ofArray

let testIndex = 2
draftXrefs[testIndex]
ianaDrafts[testIndex]
let docJson = ianaDrafts[testIndex].GetDocJson()

let noteXref = ianaXrefs |> Array.filter (fun xref -> xref.xrefType = "note")
let personXref = ianaXrefs |> Array.filter (fun xref -> xref.xrefType = "person")
let rfcXref = ianaXrefs |> Array.filter (fun xref -> xref.xrefType = "rfc")
// TODO add rfc json links
// https://www.rfc-editor.org/rfc/rfc3261.json
// C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\sampleRfc.json
type RfcEditiorProvider =
    JsonProvider<
        UseOriginalNames=true,
        OmitNullFields=true,
        RootName="rfc",
        Sample= @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\sampleRfc.json"
     >
type IanaRfc = {
    rfcDocId: string
} with

    member this.editorUrl = DomUrl $"https://www.rfc-editor.org/rfc/{this.rfcDocId}.json"
    member this.GetRfcJson() =
        http { GET this.editorUrl.Href }
        |> Request.send
        |> Response.toText
        |> RfcEditiorProvider.Parse

let rfc_errataXref = ianaXrefs |> Array.filter (fun xref -> xref.xrefType = "rfc-errata")
let uriXref = ianaXrefs |> Array.filter (fun xref -> xref.xrefType = "uri")


https.org.iana.www.assignments.media_types.xml.registries
|> Array.map (fun registry -> registry.title)



type IanaMediaType = {
    registry: string
    name: string
    xrefs: IanaXRef array
    file: string
// tokens: string array
// type_iri: string
// resource_iri: string
} with

    member this.templateUrl = DomUrl $"https://www.iana.org/assignments/media-types/{this.file}"
    member this.rfcs =
        this.xrefs
        |> Array.choose (fun xref ->
            match xref.xrefType with
            | "rfc" -> Some { rfcDocId = xref.xrefData }
            | _ -> None)
    member this.ianaDrafts =
        this.xrefs
        |> Array.choose (fun xref ->
            match xref.xrefType with
            | "draft" -> Some ianaDraftsByRfcName[xref.xrefData]
            | _ -> None)
    member this.notes =
        this.xrefs
        |> Array.choose (fun xref ->
            match xref.xrefType with
            | "note" -> Some(int xref.xrefData)
            | _ -> None)
    member this.people =
        this.xrefs
        |> Array.choose (fun xref ->
            match xref.xrefType with
            | "person" -> Some ianaPersonByName[xref.xrefData]
            | _ -> None)
    member this.rfcErrata =
        this.xrefs
        |> Array.choose (fun xref ->
            match xref.xrefType with
            | "rfc-errata" -> Some xref.xrefData
            | _ -> None)
    member this.urls =
        this.xrefs
        |> Array.choose (fun xref ->
            match xref.xrefType with
            | "uri" -> Some(DomUrl xref.xrefData)
            | _ -> None)

let ianaMediaTypes =
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
            {
                registry = registry.title
                name = record.name.Value.Value
                xrefs = xrefs
                file = record.file.Value
            }))



//
let rfcJson = ianaMediaTypes[0].rfcs[0].GetRfcJson()
rfcJson.draft
