#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

open System
open System.IO
open System.Text
open System.Threading
open System.Threading.Tasks

#load @".paket/load/main.group.fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#r "Ipa.dll"
open Ipa
#r "Iana.dll"
open Iana
#r "IanaScheme.dll"
#r "ResolvedResource.dll"
#r "NQuads.dll"



open FSharp.Data
open PuppeteerSharp.Cdp
open Microsoft.AspNetCore.Http
open FsHttp
open Humanizer



[<RequireQualifiedAccess>]
type LovTermType =
    | ``class``
    | property
    | datatype
    | instance

type LovApiTermSearchParameters = {
    /// Full text query.
    q: string
    /// Maximum number of results to return per page (default: 10).
    page_size: int option
    /// Result page to display starting from 1 (default: 1).
    page: int option
    /// Filter query results based on their type. Possible values: [class, propery, datatype, instance]. Multiple values allowed (use coma without space to seperate them).
    types: LovTermType array
    /// Filter query results based on the vocabulary it belongs to (e.g. "foaf"). Expecting only one value.
    vocab: string
    /// Number of elements to display in the vocabulary facet (default: 10).
    vocab_limit: int option
    /// Filter query results based on their tag (e.g. "event"). Multiple values allowed, use coma as a separator (e.g. "event,time").
    tags: string array
    /// Number of elements to display in the tag facet (default: 10).
    tag_limit: int option
}

(*

[<Literal>]
let termSearchFilePath = @"D:\Iri\https\lov.linkeddata.es\dataset\api\v2\term\search&quest;q=sample.json"

type TermSearchProvider = JsonProvider<UseOriginalNames=true, PreferDateOnly=true, OmitNullFields=true, RootName="result", Sample=termSearchFilePath>

[<Literal>]
let vocabSearchFilePath = @"D:\Iri\https\lov.linkeddata.es\dataset\api\v2\vocabulary\search&quest;q=http%3A%2F%2Fwww.w3.json"

type VocabSearchProvider = JsonProvider<UseOriginalNames=true, PreferDateOnly=true, OmitNullFields=true, RootName="result", Sample=vocabSearchFilePath>
*)

module https =
    module es =
        module linkeddata =
            module lov =
                let site = IanaScheme.https ..// "lov.linkeddata.es"

                module n3 =
                    let resource = site ./ "lov.n3"
                    let gz = site ./ "lov.n3.gz"
                module nq =
                    let resource = site ./ "lov.nq"
                    let gz = site ./ "lov.nq.gz"




let chrome = CdpBrowser.Connect()

let termSearch (term: string) = {
    absoluteRoot = https.es.linkeddata.lov.site
    pathSegments = [| "term"; "search" |]
    fragmentString = None
    queryString = Some(QueryString $"?q={term}")
}
let vocabularySearch (term: string) = {
    absoluteRoot = https.es.linkeddata.lov.site
    pathSegments = [| "vocabulary"; "search" |]
    fragmentString = None
    queryString = Some(QueryString $"?q={term}")
}


let n3gzFile = https.es.linkeddata.lov.n3.gz.asFileInfo
let nqgzFile = https.es.linkeddata.lov.nq.gz.asFileInfo

if
    not n3gzFile.Exists
    || n3gzFile.CreationTime - DateTime.Now >= TimeSpan.FromDays(1)
then
    http { GET https.es.linkeddata.lov.n3.gz.remoteReference }
    |> Request.send
    |> Response.saveFile https.es.linkeddata.lov.n3.gz.localReference
    NQuads.decompressNqGzipFile nqgzFile |> ignore
if
    not nqgzFile.Exists
    || nqgzFile.CreationTime - DateTime.Now >= TimeSpan.FromDays(1)
then
    http { GET https.es.linkeddata.lov.nq.gz.remoteReference }
    |> Request.send
    |> Response.saveFile https.es.linkeddata.lov.nq.gz.localReference
    decompressGz n3gzFile |> ignore
