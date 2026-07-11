open System
open System.Text
open System.IO

#r "nuget: Scriban"

#r "nuget: FsHttp"

open FsHttp

#r "nuget: FSharp.Data"
open FSharp.Data




#r "nuget: Iride"

open Iride
open VDS.RDF



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\IriPathing.fsx"
open IriPathing

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\StringExtensions.fsx"
open StringExtensions
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PathErgonomics.fsx"
open PathErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\processExecution.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\resourceIdentification.fsx"

open ResourceIdentification
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\WorldWideWeb.fsx"
open WorldWideWeb





let namespaceIriStrings =
    [|

       "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
       "http://www.w3.org/2000/01/rdf-schema#"
       "http://www.w3.org/2002/07/owl#"
       "http://xmlns.com/foaf/0.1/"

       |]

let downloadUrl_from_namespaceIriString (namespaceIriString: string) =
    match namespaceIriString with
    | "http://xmlns.com/foaf/0.1/" -> new Uri("https://xmlns.com/foaf/spec/index.rdf")
    | _ -> new Uri(namespaceIriString)

[<Literal>]
let userAgent =
    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3739.0 Safari/537.36 Edg/75.0.115.0"

[<Literal>]
let DoxAletheiaRootDirectory =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia"

let VocabularyDirectory =
    Ensure.path (Path.Combine(DoxAletheiaRootDirectory, "Vocabulary"))


let namespaceFilePaths = ResizeArray<string>()

type UnknownContentTypeRecord =
    {

      namespaceUriString: string
      contentType: string

     }



let uriStringWithNoSuccessCode = ResizeArray<string>()
let namespaceIris_without_contentType = ResizeArray<NamespaceIri>()
let uriStringWithUnknownContentTypes = ResizeArray<UnknownContentTypeRecord>()



let extension_from_contentType (contentType: string) (namespaceIriString: string) =
    match contentType with
    | _ when contentType.Contains(MediaType.text.turtle) -> "ttl"
    | _ when contentType.Contains(MediaType.application.ntriples) -> "nt"
    | _ when contentType.Contains(MediaType.application.rdfxml) -> "rdf"
    | _ when contentType.Contains(MediaType.application.trig) -> "trig"
    | _ when contentType.Contains(MediaType.application.nquads) -> "nq"
    | _ when contentType.Contains(MediaType.application.ldjson) -> "jsonld"
    | _ ->
        uriStringWithUnknownContentTypes.Add
            {

              namespaceUriString = namespaceIriString
              contentType = contentType

            }

        "unknown"



let acceptedMediaTypes =
    [

      MediaType.text.turtle
      MediaType.application.ntriples
      MediaType.application.rdfxml
      MediaType.application.trig
      MediaType.application.nquads
      MediaType.application.ldjson
      MediaType.text.plain
      "0.8"
      "*/*"
      "0.1"

      ]

let fileContent_from_downloadUri (downloadUri: Uri) =
    http {
        GET downloadUri.AbsoluteUri
        UserAgent userAgent
        Accept(acceptedMediaTypes |> String.concat ", ")

    }
    |> Request.send
    |> Response.toText











module prefixcc =
    [<Literal>]
    let filePath =
        @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\prefix.cc.json"

    let json = JsonProvider<filePath>.Load filePath


module lov =


    module vocabulary =
        [<Literal>]
        let filePath =
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.vocabulary.json"

        let json = JsonProvider<filePath>.Load filePath

    module api =
        let v2Base = "https://lov.linkeddata.es/dataset/lov/api/v2"

        module vocabulary =

            let list () =
                http {
                    GET $"{v2Base}/vocabulary/list"

                }
                |> Request.send
                |> Response.saveFile vocabulary.filePath
(*
        module term =
            let search () =
                 $"{v2Base}/term/search"

            let autocomplete () =
                 $"{v2Base}/term/autocomplete"

            let suggest () =
                 $"{v2Base}/term/suggest"



            let search () =
                 $"{v2Base}/vocabulary/search"

            let autocomplete () =
                 $"{v2Base}/vocabulary/autocomplete"

            let info () =
                 $"{v2Base}/vocabulary/info"

        module agent =
            let list () =
                 $"{v2Base}/agent/list"

            let search () =
                 $"{v2Base}/agent/search"

            let autocomplete () =
                 $"{v2Base}/agent/autocomplete"

            let info () =
                 $"{v2Base}/agent/info"

        *)


//lov.api.vocabulary.list ()



































































let namespaceDirectoryPath_from_iriString (namespaceIriString: string) =
    Path.Combine(VocabularyDirectory, (iriToRelativePath namespaceIriString))

let namespaceDirectoryPaths =
    namespaceIriStrings
    |> Array.Parallel.map (fun namespaceIriString ->

        namespaceDirectoryPath_from_iriString namespaceIriString

    )

let extantVocabularyDirectories =
    namespaceDirectoryPaths
    |> Array.Parallel.choose (fun namespaceDirectoryPath ->

        if Directory.Exists namespaceDirectoryPath then
            Some(namespaceDirectoryPath)
        else
            None

    )

let extantRdfGraphs =
    Directory.GetFiles(VocabularyDirectory, "*", SearchOption.AllDirectories)


let missing_namespaceDirectoryPaths =
    let namespaceDirectoryPathSet = namespaceDirectoryPaths |> Set.ofArray
    let extantVocabularyDirectorieSet = extantVocabularyDirectories |> Set.ofArray

    Set.difference namespaceDirectoryPathSet extantVocabularyDirectorieSet




let namespaceIriStrings_to_download =
    namespaceIriStrings
    |> Array.Parallel.filter (fun namespaceIriString ->

        let namespaceDirectoryPath =
            Path.Combine(VocabularyDirectory, (iriToRelativePath namespaceIriString))

        missing_namespaceDirectoryPaths.Contains namespaceDirectoryPath

    )


let label_from_namespaceIriString (namespaceIriString: string) =

    let label_from_prefixcc =
        prefixcc.json.JsonValue.Properties()
        |> Array.Parallel.tryPick (fun (jsonKey, jsonValue) ->

            if (jsonValue.AsString() = namespaceIriString) then
                Some(jsonKey)
            else
                None)

    match label_from_prefixcc with
    | _ when label_from_prefixcc.IsNone ->
        let label_from_lov =
            lov.vocabulary.json
            |> Array.Parallel.tryPick (fun vocabulary ->

                if vocabulary.Nsp = namespaceIriString then
                    Some(vocabulary.Prefix)
                else
                    None

            )

        label_from_lov

    | _ -> label_from_prefixcc

let NamespaceIri_from_iriString (iriString: string) (namespaceLabel: string) =
    let iri = Iri_from_iriString iriString

    { new NamespaceIri with
        member this.iriString = iri.iriString
        member this.scheme = iri.scheme
        member this.host = iri.host
        member this.port = iri.port
        member this.path = iri.path
        member this.pathSegments = iri.pathSegments
        member this.leaf = iri.leaf
        member this.leafSegments = iri.leafSegments
        member this.query = iri.query
        member this.fragment = iri.fragment
        member this.namespaceLabel = namespaceLabel
        member this.downloadUri = downloadUrl_from_namespaceIriString iriString
        member this.directoryPath = namespaceDirectoryPath_from_iriString iriString }

let namespaceIriStrings_missing_label =
    namespaceIriStrings_to_download
    |> Array.Parallel.filter (fun namespaceIriString ->

        let label = label_from_namespaceIriString namespaceIriString
        label.IsNone

    )

label_from_namespaceIriString namespaceIriStrings_to_download[0]

let namespaceIriStrings_with_label =
    namespaceIriStrings_to_download
    |> Array.Parallel.choose (fun namespaceIriString ->

        let label = label_from_namespaceIriString namespaceIriString

        if label.IsSome then
            Some(namespaceIriString)
        else
            None

    )

let namespaceIris =
    namespaceIriStrings_with_label
    |> Array.Parallel.map (fun namespaceIriString ->

        let label = label_from_namespaceIriString namespaceIriString

        NamespaceIri_from_iriString namespaceIriString label.Value

    )

let testNamespaceIri = namespaceIris[0]
testNamespaceIri.namespaceLabel





let httpResponses =
    namespaceIris
    |> Array.Parallel.map (fun namespaceIri ->

        http {

            GET namespaceIri.downloadUri.AbsoluteUri

        }
        |> Request.send
        |> Response.asOriginalHttpResponseMessage


    )

let unsuccessfulHttpResponses =
    httpResponses
    |> Array.Parallel.filter (fun httpResponse ->

        not httpResponse.IsSuccessStatusCode

    )

let successfulHttpResponses =
    httpResponses
    |> Array.Parallel.filter (fun httpResponse ->

        httpResponse.IsSuccessStatusCode

    )

let saveFileContent_from_httpResponses =
    successfulHttpResponses
    |> Array.Parallel.iter (fun httpResponse ->

        let namespaceIri =
            namespaceIris
            |> Array.find (fun namespaceIri -> namespaceIri.downloadUri = httpResponse.RequestMessage.RequestUri)


        let contentType =
            httpResponse.Content.Headers
            |> Seq.pick (fun header ->

                if header.Key = "Content-Type" then
                    Some(header.Value |> Seq.item 0)
                else
                    namespaceIris_without_contentType.Add namespaceIri
                    None

            )


        let extension = extension_from_contentType contentType namespaceIri.iriString
        let fileName = $"{namespaceIri.namespaceLabel}.{extension}"

        let namespaceFileContent =
            httpResponse.Content.ReadAsStringAsync()
            |> Async.AwaitTask
            |> Async.RunSynchronously

        let namespaceFilePath =
            Ensure.path (Path.Combine(namespaceIri.directoryPath, fileName))


        namespaceFilePaths.Add namespaceFilePath

        File.WriteAllText(namespaceFilePath, namespaceFileContent)

    )
