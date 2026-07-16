open System
open System.IO
open System.IO.Compression


#r "nuget: dotNetRdf"

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.JsonLd



#r "nuget: FsHttp"

open FsHttp

#r "nuget: FSharp.Data"
open FSharp.Data

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\HttpErgonomics.fsx"
open HttpErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\JavascriptObjectNotationExtensions.fsx"

open JavascriptObjectNotationExtensions

open FSharp.Json






type Registry_Meta = { last_meta: DateTimeOffset }

module zazuko =
    [<Literal>]
    let file_path =
        @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\zazuko.prefixes.json"


    let prefixes () =
        http {
            GET $"https://prefix.zazuko.com/api/v1/prefixes"

        }
        |> Request.send
        |> Response.saveFile file_path

    let json = JsonProvider<file_path>.Load file_path


module prefixcc =
    [<Literal>]
    let filePath =
        @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\prefix.cc.json"

    let get_all () =
        http {
            GET $"http://prefix.cc/popular/all.file.json"

        }
        |> Request.send
        |> Response.saveFile filePath


    let json = JsonProvider<filePath>.Load filePath









let acceptedMediaTypes =
    [ $"{MediaType.application.trig};q=1"
      $"{MediaType.application.nquads};q=0.95"
      $"{MediaType.text.turtle};q=0.9"
      $"{MediaType.application.ntriples};q=0.85"
      $"{MediaType.application.rdfxml};q=0.8"
      $"{MediaType.application.ldjson};q=0.75"
      $"{MediaType.application.json};q=0.7"
      $"{MediaType.application.xml};q=0.6"
      $"{MediaType.text.xml};q=0.55"
      $"{MediaType.text.html};q=0.4"
      $"{MediaType.text.plain};q=0.2"
      $"{MediaType.any};q=0.1" ]


let unsuccessful_http_namespace_names = new ResizeArray<string>()



type RdfSyntax =
    | Turtle
    | NTriples
    | RdfXml
    | TriG
    | NQuads
    | JsonLd

module RdfSyntax =

    let extension syntax =
        match syntax with
        | Turtle -> "ttl"
        | NTriples -> "nt"
        | RdfXml -> "rdf"
        | TriG -> "trig"
        | NQuads -> "nq"
        | JsonLd -> "jsonld"







    let private graph_parsers: (RdfSyntax * (unit -> IRdfReader)) list =
        [ Turtle, (fun () -> TurtleParser() :> IRdfReader)
          NTriples, (fun () -> NTriplesParser() :> IRdfReader)
          RdfXml, (fun () -> RdfXmlParser() :> IRdfReader) ]

    let private store_parsers: (RdfSyntax * (unit -> IStoreReader)) list =
        [ TriG, (fun () -> TriGParser() :> IStoreReader)
          NQuads, (fun () -> NQuadsParser() :> IStoreReader)
          JsonLd, (fun () -> JsonLdParser() :> IStoreReader) ]

    let private normalize_content_type (content_type: string) =
        content_type.Split(';').[0]
            .Trim()
            .ToLowerInvariant()

    let syntax_from_content_type (content_type: string option) =
        match content_type |> Option.map normalize_content_type with
        | Some value when value = MediaType.text.turtle -> Some Turtle
        | Some value when value = MediaType.application.ntriples -> Some NTriples
        | Some value when value = MediaType.application.rdfxml -> Some RdfXml
        | Some value when value = MediaType.application.trig -> Some TriG
        | Some value when value = MediaType.application.nquads -> Some NQuads
        | Some value when value = MediaType.application.ldjson -> Some JsonLd
        | _ -> None

    let private preferred_order content_type =
        let all =
            [ RdfXml
              Turtle
              NTriples
              TriG
              NQuads
              JsonLd ]

        match syntax_from_content_type content_type with
        | Some preferred -> preferred :: (all |> List.filter ((<>) preferred))
        | None -> all


    let private try_graph_parse syntax content =
        graph_parsers
        |> List.tryFind (fun (candidate, _) -> candidate = syntax)
        |> Option.bind (fun (_, parser_factory) ->
            try
                let graph = new Graph()
                use reader = new StringReader(content)
                parser_factory().Load(graph, reader)

                if graph.Triples.Count > 0 then
                    Some syntax
                else
                    None
            with
            | _ -> None)

    let private try_store_parse syntax content =
        store_parsers
        |> List.tryFind (fun (candidate, _) -> candidate = syntax)
        |> Option.bind (fun (_, parser_factory) ->
            try
                let store = new TripleStore()
                use reader = new StringReader(content)
                parser_factory().Load(store, reader)

                let triple_count =
                    store.Graphs
                    |> Seq.sumBy (fun graph -> graph.Triples.Count)

                if triple_count > 0 then
                    Some syntax
                else
                    None
            with
            | _ -> None)


    let try_parse content_type content =
        preferred_order content_type
        |> List.tryPick (fun syntax ->
            try_graph_parse syntax content
            |> Option.orElseWith (fun () -> try_store_parse syntax content))




type DownloadedVocabularyKind =
    | Rdf of RdfSyntax
    | Html
    | Json
    | Xml
    | PlainText
    | Unknown



module DownloadedVocabularyKind =

    let extension kind =
        match kind with
        | Rdf syntax -> RdfSyntax.extension syntax
        | Html -> "html"
        | Json -> "json"
        | Xml -> "xml"
        | PlainText -> "txt"
        | Unknown -> "unknown"

    let looks_like_html (content: string) =
        let trimmed = content.TrimStart().ToLowerInvariant()

        trimmed.StartsWith("<!doctype html")
        || trimmed.StartsWith("<html")
        || trimmed.Contains("<head")
        || trimmed.Contains("<body")

    let classify content_type content =
        (*
    if looks_like_html content then
        Html
    else
*)
        match RdfSyntax.try_parse content_type content with
        | Some syntax -> Rdf syntax
        | None -> Unknown



type Downloaded_Rdf_Vocabulary =
    { content: string
      content_type: string option
      kind: DownloadedVocabularyKind }





(*



let rec try_with_retry attempts (delay_ms: int) operation =
    try
        operation ()
    with
    | err when attempts > 0 ->
        printfn "Retrying after error: %s" err.Message
        Thread.Sleep(delay_ms)
        try_with_retry (attempts - 1) (delay_ms * 2) operation


let distribution_http_response (distribution: string) : HttpResponseMessage option =
    try
        let http_response =
            try_with_retry 3 500 (fun () ->
                http {
                    GET distribution
                    UserAgent userAgent
                    Accept(acceptedMediaTypes |> String.concat ", ")
                }
                |> Request.send
                |> Response.asOriginalHttpResponseMessage)

        Some http_response

    with
    | err ->
        printfn "HTTP failed for %s: %s" distribution err.Message
        None

let download_distribution (distribution: string) : Downloaded_Rdf_Vocabulary option =
    match distribution_http_response (distribution) with
    | Some http_response when http_response.IsSuccessStatusCode ->

        let content =
            http_response.Content.ReadAsStringAsync()
            |> Async.AwaitTask
            |> Async.RunSynchronously

        let content_type =
            http_response.Content.Headers.ContentType
            |> Option.ofObj
            |> Option.map string

        let kind = DownloadedVocabularyKind.classify content_type content

        if kind.IsUnknown then
            None
        else
            Some
                { content = content
                  content_type = content_type
                  kind = kind }

    | _ -> None






let parallel_iter_bounded degree_of_parallelism action items =
    use semaphore = new SemaphoreSlim(degree_of_parallelism)

    items
    |> Array.map (fun item ->
        async {
            do! semaphore.WaitAsync() |> Async.AwaitTask

            try
                action item
            finally
                semaphore.Release() |> ignore
        })
    |> Async.Parallel
    |> Async.RunSynchronously
    |> ignore

let file_name_from_uri (uri: Uri) fallback_extension =
    uri.Segments
    |> Array.rev
    |> Array.tryFind (fun segment -> segment <> "/")
    |> Option.map Uri.UnescapeDataString
    |> Option.defaultValue $"download.{fallback_extension}"


let save_lov_namespace (lov_namespace: string) =
    let directory_path =
        Path.Combine(VocabularyDirectory, iriToRelativePath lov_namespace)

    if
        Directory.Exists(directory_path)
        && Directory.EnumerateFiles(directory_path)
           |> Seq.isEmpty
           |> not
    then
        printfn "Already saved %20s" lov_namespace
    else
        try
            let distribution = vocabulary_to_distribution[lov_namespace]

            Thread.Sleep(1500)

            match download_distribution distribution with
            | Some downloaded_distribution ->
                let distribution_uri = Uri(distribution)

                let file_name =
                    distribution_uri.Segments
                    |> Array.rev
                    |> Array.tryFind (fun segment -> segment <> "/")
                    |> Option.map Uri.UnescapeDataString
                    |> Option.defaultValue (
                        $"download.{DownloadedVocabularyKind.extension downloaded_distribution.kind}"
                    )

                let file_path = Ensure.path (Path.Combine(directory_path, file_name))

                File.WriteAllText(file_path, downloaded_distribution.content)

                printfn "Saved %-20s from %s" lov_namespace distribution

            | None ->
                printfn "Cannot save %20s" lov_namespace
                unsuccessful_http_namespace_names.Add lov_namespace

        with
        | err ->
            printfn "Cannot save %20s %s" lov_namespace err.Message
            unsuccessful_http_namespace_names.Add lov_namespace









(*

|> parallel_iter_bounded 4 (fun lov_namespace ->
    let directory_path =
        Path.Combine(VocabularyDirectory, (iriToRelativePath lov_namespace))

    if Path.Exists(directory_path) then
        printfn "Already saved %20s" lov_namespace
    else
        try
            let distribution = vocabulary_to_distribution[lov_namespace]
            let downloaded_distribution_option = download_distribution distribution

            match downloaded_distribution_option with
            | Some downloaded_distribution ->
                let distribution_uri = Uri(distribution)

                let file_name =
                    file_name_from_uri
                        distribution_uri
                        (DownloadedVocabularyKind.extension downloaded_distribution.kind)

                let file_path = Ensure.path (Path.Combine(directory_path, file_name))

                File.WriteAllText(file_path, downloaded_distribution.content)

            | None ->
                printfn "Cannot save %20s" lov_namespace
                unsuccessful_http_namespace_names.Add lov_namespace

        with
        | err ->
            printfn "Cannot save %20s %s" lov_namespace err.Message
            unsuccessful_http_namespace_names.Add lov_namespace)

*)

let random_lov_namespace = lov_namespaces |> Array.randomChoice

let random_http_response =

    http {
        GET vocabulary_to_distribution[random_lov_namespace]
        UserAgent userAgent
        Accept(acceptedMediaTypes |> String.concat ", ")
    // Accept "*/*"

    }
    |> Request.send
    |> Response.asOriginalHttpResponseMessage

(*

unsuccessful_http_namespace_names
|> Seq.map (fun unsuccessful -> sprintf "\"%s\"" unsuccessful)
|> String.concat "\n"
|> clip

*)



































type Rdf_Vocabulary_Kind =
    | ExogenousVocabulary
    | EndogenousVocabulary
    | DerivedVocabulary

type Rdf_Vocabulary =
    {

      namespace_name: string
      namespace_kind: Rdf_Vocabulary_Kind
      preferred_prefix: string
      distribution: string option

     }



    member this.get_downloaded_vocabulary() : Downloaded_Rdf_Vocabulary option =
        match this.http_response () with
        | Some http_response when http_response.IsSuccessStatusCode ->

            let content =
                http_response.Content.ReadAsStringAsync()
                |> Async.AwaitTask
                |> Async.RunSynchronously

            let content_type =
                http_response.Content.Headers.ContentType
                |> Option.ofObj
                |> Option.map string

            let kind = DownloadedVocabularyKind.classify content_type content

            if kind.IsUnknown then
                None
            else
                Some
                    { content = content
                      content_type = content_type
                      kind = kind }

        | _ -> None

    member this.file_name_for(kind: DownloadedVocabularyKind) : string =
        $"{this.prefix}.{DownloadedVocabularyKind.extension kind}"

    member this.file_path_for(kind: DownloadedVocabularyKind) =
        Path.Combine(this.directory_path, this.file_name_for kind)

    member this.save_downloaded_vocabulary(downloaded_vocabulary: Downloaded_Rdf_Vocabulary) =
        let file_path = Ensure.path (this.file_path_for downloaded_vocabulary.kind)


        File.WriteAllText(file_path, downloaded_vocabulary.content)

        printfn "Saved %-20s as %s" this.namespace_name (DownloadedVocabularyKind.extension downloaded_vocabulary.kind)

    member this.save_content() =
        if Path.Exists(this.directory_path) then
            printfn "Already saved %20s" this.namespace_name
        else
            match this.get_downloaded_vocabulary () with
            | Some downloaded_vocabulary -> this.save_downloaded_vocabulary downloaded_vocabulary
            | None ->
                printfn "Cannot save %20s" this.namespace_name
                unsuccessful_http_namespace_names.Add this.namespace_name


    member this.download_iri =
        match this.namespace_name with
        | "http://xmlns.com/foaf/0.1/" -> "https://xmlns.com/foaf/spec/index.rdf"
        | _ -> this.namespace_name

    member this.http_response() : HttpResponseMessage option =
        try
            let http_response =
                http {
                    GET this.download_iri
                    UserAgent userAgent
                    Accept(acceptedMediaTypes |> String.concat ", ")
                // Accept "*/*"

                }
                |> Request.send
                |> Response.asOriginalHttpResponseMessage

            Some(http_response)
        with
        | err ->
            printfn "%s" err.Message
            None



    member this.prefix =
        match namespace_to_personal_prefix.TryFind(this.namespace_name) with
        | Some prefix -> prefix
        | None -> this.preferred_prefix



    member this.get_content() : string option =

        match this.http_response () with
        | Some http_response when http_response.IsSuccessStatusCode ->
            let content =
                http_response.Content.ReadAsStringAsync()
                |> Async.AwaitTask
                |> Async.RunSynchronously

            Some(content)
        | _ -> None

    member this.directory_path =
        Path.Combine(VocabularyDirectory, (iriToRelativePath this.namespace_name))


(*

module Rdf_Vocabulary =
    module Endogenous =
        let from_prefix_reference (mappings: (string * string) array) =
            mappings
            |> Array.map (fun (namespace_name, personal_prefix) ->
                {

                  namespace_name = namespace_name
                  namespace_kind = EndogenousVocabulary
                  personal_prefix = Some(personal_prefix)
                  lov_prefix = None
                  prefixcc_prefix = None

                }

            )

    module Exogenous =
        let from_prefix_reference (mappings: (string * string) array) =
            mappings
            |> Array.map (fun (namespace_name, personal_prefix) ->
                {

                  namespace_name = namespace_name
                  namespace_kind = ExogenousVocabulary
                  personal_prefix = Some(personal_prefix)
                  lov_prefix = None
                  prefixcc_prefix = None

                }

            )

        let from_reference (mappings: string array) =
            mappings
            |> Array.map (fun namespace_name ->
                {

                  namespace_name = namespace_name
                  namespace_kind = ExogenousVocabulary
                  personal_prefix = None
                  lov_prefix = None
                  prefixcc_prefix = None

                }

            )

    module Derived =
        let from_prefix_reference (mappings: (string * string) array) =
            mappings
            |> Array.map (fun (namespace_name, personal_prefix) ->
                {

                  namespace_name = namespace_name
                  namespace_kind = DerivedVocabulary
                  personal_prefix = Some(personal_prefix)
                  lov_prefix = None
                  prefixcc_prefix = None

                }

            )

    let to_prefix_map (namespaces: Rdf_Vocabulary array) =
        namespaces
        |> Array.map (fun rdf_namespace ->


            (rdf_namespace.prefix, rdf_namespace.namespace_name)


        )
        |> Map.ofArray



*)



















































(*



let lov_namespaces =
    Registry.lov.vocabulary.json
    |> Array.filter (fun vocabulary ->
        Registry.lov_set
        |> Set.exists (fun element -> element = vocabulary.Nsp))
    |> Array.map (fun vocabulary ->
        {

          namespace_name = vocabulary.Nsp
          namespace_kind = ExogenousVocabulary
          personal_prefix = None
          lov_prefix = Some(vocabulary.Prefix)
          prefixcc_prefix = None

        }

    )

let prefixcc_namespaces =
    Array.zip Registry.prefixcc.json.JsonValue.PropertyKeys Registry.prefixcc.json.JsonValue.PropertyValues
    |> Array.map (fun (json_key, json_value) -> (json_key, json_value.AsString()))
    |> Array.filter (fun (prefix, namespace_name) ->
        Registry.prefixcc_set
        |> Set.exists (fun element -> element = namespace_name))
    |> Array.map (fun (prefix, namespace_name) ->
        {

          namespace_name = namespace_name
          namespace_kind = ExogenousVocabulary
          personal_prefix = None
          lov_prefix = None
          prefixcc_prefix = Some(prefix)

        }

    )




let registry_vocabularies =
    Array.concat [| lov_namespaces
                    prefixcc_namespaces |]

    |> Array.filter (fun vocabulary ->
        not (
            Array.Exists(
                Registry_Priors.unsuccessful_namespace_names,
                (fun unsuccessful_http_namespace_name -> unsuccessful_http_namespace_name = vocabulary.namespace_name)
            )
        ))
    |> Array.filter (fun vocabulary -> not (Path.Exists(vocabulary.directory_path)))




*)




































let vocabulary_files =
    Directory.GetFiles(VocabularyDirectory, "", SearchOption.AllDirectories)


let namespaces_from_files =
    vocabulary_files
    // |> Array.randomSample 10
    |> Array.Parallel.collect (fun rdf_file ->


        let file_graph = new ThreadSafeGraph()
        FileLoader.Load(file_graph, rdf_file)

        file_graph.NamespaceMap.Prefixes
        |> Seq.map (fun prefix ->
            let namespace_uri = file_graph.NamespaceMap.GetNamespaceUri prefix

            (namespace_uri.OriginalString, prefix)

        )
        |> Seq.toArray

    )
    (*

    |> Array.Parallel.filter (fun (namespace_name, prefix) ->

        not (
            Array.exists
                (fun registry_namespace -> registry_namespace = namespace_name)
                lov_namespaces

        )


    )
        *)

    |> Array.distinct
    |> Array.Parallel.filter (fun (namespace_name, prefix) ->
        not (
            Registry_Priors.unsuccessful_namespace_names
            |> Array.exists (fun unsuccessful_namespace -> namespace_name = unsuccessful_namespace)
        ))
    |> Array.Parallel.filter (fun (namespace_name, prefix) ->
        not (
            Registry_Priors.namespace_prefixes_from_files
            |> Array.exists (fun (prior_namespace_name, prior_prefix) -> namespace_name = prior_namespace_name)
        ))



namespaces_from_files.Length
(*

namespaces_from_files
|> Array.map (fun (namespace_name, prefix) -> sprintf "\"%s\", \"%s\"" namespace_name prefix)
|> String.concat "\n"
|> clip


*)





(*



let vocabularies_from_files =
    Registry_Priors.namespace_prefixes_from_files
    |> Array.map (fun (namespace_name, prefix) ->

        {

          namespace_name = namespace_name
          namespace_kind = ExogenousVocabulary
          personal_prefix = None
          lov_prefix = None
          prefixcc_prefix = Some(prefix)

        }

    )


*)















(*






vocabularies_from_files
|> Array.Parallel.iter (fun vocabulary -> vocabulary.save_content ())

unsuccessful_http_namespace_names.Count

unsuccessful_http_namespace_names
|> Seq.map (fun unsuccessful_name -> sprintf "\"%s\"" unsuccessful_name)
|> String.concat "\n"
|> clip

*)
// TODO add unsuccessful namespaces to array manually
// TODO move onto extraction of terms in the namespace
// localname, label, see also, defined by, comments
// try to get away with printfn/try to avoid fabulous and/or scriban if possible




































































(*

personal_vocabularies
|> Array.filter (fun personal_vocabulary ->
    registry_vocabularies
    |> Array.exists (fun registry_vocabulary ->

        registry_vocabulary.namespace_name = personal_vocabulary.namespace_name

    ))
|> Array.iter (fun vocabulary -> printfn "%s" vocabulary.namespace_name)


*)
(*


let duplicate_prefixes =
    registry_vocabularies
    |> Array.countBy (fun vocabulary -> vocabulary.prefix)
    |> Array.filter (fun (prefix, count) -> count > 1)
    |> Array.map (fun (prefix, _) -> prefix)



duplicate_prefixes.Length
let random_duplicate_prefix = duplicate_prefixes |> Array.randomChoice


let vocabularies_with_duplicate_prefixes =
    registry_vocabularies
    |> Array.choose (fun vocabulary ->
        if duplicate_prefixes
           |> Array.exists (fun element -> element = vocabulary.prefix) then
            Some(vocabulary)
        else
            None

    )


let namespace_names_with_duplicate_prefixes =
    vocabularies_with_duplicate_prefixes
    |> Array.map (fun vocabulary -> (vocabulary.prefix, vocabulary.namespace_name))
    |> Array.sortBy (fun (prefix, namespace_name) -> prefix)
    |> Array.map (fun (prefix, namespace_name) -> sprintf "\"%s\", \"%s\"" prefix namespace_name)


File.WriteAllLines(
    Path.Combine(__SOURCE_DIRECTORY__, "namespace_names_with_duplicate_prefixes.txt"),
    namespace_names_with_duplicate_prefixes
)









let vocabularies_without_duplicate_prefixes =
    registry_vocabularies
    |> Array.choose (fun vocabulary ->
        if duplicate_prefixes
           |> Array.exists (fun element -> element <> vocabulary.prefix) then
            Some(vocabulary)
        else
            None

    )












vocabularies_without_duplicate_prefixes.Length





vocabularies_without_duplicate_prefixes
//|> Array.randomSample 10
|> Array.Parallel.iter (fun vocabulary -> vocabulary.save_content ())

unsuccessful_http_namespace_names.Count


*)



(*

File.WriteAllLines(
    Path.Combine(__SOURCE_DIRECTORY__, "unsuccessful_http_namespace_names.txt"),
    unsuccessful_http_namespace_names
)

*)


(*

let random_registry_vocabulary =
    registry_vocabularies
    |> Array.Parallel.filter (fun vocabulary -> not (Path.Exists(vocabulary.directory_path)))
    |> Array.randomChoice




let random_response_option = random_registry_vocabulary.http_response ()
let random_response = Option.get random_response_option

random_response.Content.ReadAsStringAsync()
|> Async.AwaitTask
|> Async.RunSynchronously



random_registry_vocabulary.get_downloaded_vocabulary ()


// TODO deal with content types to hopefully avoid html content and others

random_registry_vocabulary.save_content ()

*)












































*)
