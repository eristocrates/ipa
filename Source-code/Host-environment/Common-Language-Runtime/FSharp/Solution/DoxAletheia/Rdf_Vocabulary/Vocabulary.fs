module DoxAletheia.Vocabulary

open System
open System.Net
open System.Globalization
open System.Text
open System.IO
open System.Linq
open System.Xml
open System.Collections

open System.IO.Compression


open StringExtensions

open ArrayErgonomics
open GrammarErgonomics
open Interval_Range
open IntervalErgonomics


open Yog.Model
open Yog.Builder
open Yog.IO
open Yog.Pathfinding.Dijkstra
open Yog.Render
open Yog.Render.Dot
open Yog.Render.Mermaid




open QuikGraph
open QuikGraph.Serialization
open QuikGraph.Graphviz
open QuikGraph.Data
open QuikGraph.MSAGL
open QuikGraph.Petri



open Rubjerg.Graphviz



open FSharp.HashCollections



open VDS.RDF.Query



open FSharp.Data
open FSharp.Data.Adaptive.Transaction
open FSharp.Collections.ParallelSeq

open FSharp.Json
open VDS.RDF
open VDS.RDF.Nodes
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Patterns

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF.Query.Datasets
open VDS.RDF.Storage
open VDS.RDF.Query.Builder
open VDS.RDF.Query
open VDS.RDF.Query.Patterns
open VDS.RDF.Parsing.Tokens

open FSharp.Data
open type Prefix_ID






open System
open System.IO
open System.IO.Compression

open DoxAletheia
open Manual_Prefixes
open IOExtensions
open RdfExtensions
open Rdf_Distribution.Single
open Rdf_Distribution.Multi
open JsonErgonomics

open PrettierNaming
open PrettierNaming.FSharp_Keywords
open Swensen.Unquote.Assertions

open FsHttp

open VDS.RDF
open VDS.RDF.Parsing

let well_known_base =  $"https://eristocrates.dev/.well-known/genid/"








let log_lines = new ResizeArray<string>()
module fibo =
    let distribution_probe = 
        http {
            GET "https://github.com/edmcouncil/fibo/releases/latest"
        }
        |> Request.send
    let download_distribution (distribution:string) =
        http {

            GET distribution

        }
        |> Request.send

    let extraction_directory = Folder.Vocabulary ./ @"https\spec.edmcouncil.org"

    let latest_source = distribution_probe.originalHttpResponseMessage.RequestMessage.RequestUri.OriginalString + ".zip"
    printfn "latest fibo source: %s" latest_source

        

    let file_name = 
        (iri_to_relative_path latest_source).Replace("\\bare", "").Split("\\")
        |> Array.last
    let version = 
        let master_ = "master_" 
        let zip = ".zip" 
        file_name[master_.Length..file_name.Length-zip.Length-1]
    printfn "latest fibo version: %s" version

    let content_directory = extraction_directory ./ $@"fibo\ontology\master\{version}"
    if not content_directory.as_directory.Exists then 
        Directory.CreateDirectory(content_directory.path) |> ignore

    let fibo_zip = content_directory ./ @"prod.ttl.zip"

    if not fibo_zip.as_file.Exists then 
        let distribution = $"https://spec.edmcouncil.org/fibo/ontology/master/{version}/prod.ttl.zip"
        printfn "downloading fibo version %s" version
        let response = download_distribution distribution

        if response.originalHttpResponseMessage.IsSuccessStatusCode then
            Response.saveFile fibo_zip.as_file.FullName response
            if not Folder.fibo.as_directory.Exists then
                Directory.CreateDirectory(Folder.fibo.path) |> ignore
            ZipFile.ExtractToDirectory(fibo_zip.as_file.FullName, Folder.fibo.as_directory.FullName)
        printfn "fibo version %s download complete" version
    else 
        printfn "fibo version %s already downloaded" version

    let vocabulary_files =
        content_directory.descendant_files "*.ttl"
    

    let namespaces_from_files =
        vocabulary_files
        // |> Array.randomSample 10
        |> Array.Parallel.collect (fun rdf_file ->

            try

                let file_graph = new ThreadSafeGraph()
                FileLoader.Load(file_graph, rdf_file)

                file_graph.NamespaceMap.Prefixes
                |> Seq.map (fun prefix ->
                    let namespace_uri = file_graph.NamespaceMap.GetNamespaceUri prefix

                    (namespace_uri.OriginalString, prefix)

                )
                |> Seq.toArray

            with 
            | err -> 
                log_lines.Add(sprintf "%s %s   errored with %s" (nameof rdf_file) rdf_file err.Message) 
                [||]
        )
        |> Array.distinct

    let metadata =
        printfn "processing fibo metadata"
        vocabulary_files
        |> Array.Parallel.choose (fun ttl_path ->
            let file_stem = Path.GetFileNameWithoutExtension ttl_path

            let type_binding =
                match file_stem with
                | prefix when reserved_keywords.Contains(prefix) -> $"{prefix}_"
                | _ -> file_stem.Replace('-', '_').Replace('.', '_')

            let from_index = Folder.https.path.Length + 1

            let to_index =
                ttl_path.ToCharArray()
                |> Array.reversible_index -4

            let subpath =
                ttl_path[from_index..to_index]
                    .Replace("\\", "/")
                    .Replace($"/master/{version}", "")

            let reconstructed_namespace = $"https://{subpath}/"

            let maybe_namespace_prefix =
                namespaces_from_files
                |> Array.Parallel.tryFind (fun (namespace_name, prefix_label) ->
                    namespace_name = reconstructed_namespace

                )

            match maybe_namespace_prefix with
            | Some (namespace_name, prefix_label) -> 
                    Some {
                            namespace_prefix = prefix_label
                            namespace_name = namespace_name
                        }
            | None -> None)

    test <@ vocabulary_files.Length = metadata.Length @>
    printfn "fibo metadata complete"









    




    


let manual_namespace_names = 
                    manual_distributions
                            |> Array.map (fun (namespace_name,_) -> namespace_name)
let prefixcc_namespace_names = 

                Document.prefixcc.json.JsonValue.AsRecord
                |> Array.Parallel.map (fun (key,value) -> value.AsString())

let lov_namespace_names =
    Document.lov.json
    |> Array.Parallel.map (fun vocabulary -> vocabulary.Nsp)

let filesystem_namespace_names = 
    Folder.Vocabulary.descendant_files "*.ttl"
    |> Array.Parallel.filter (fun file_path -> not (file_path.Contains(@"https\spec.edmcouncil.org\fibo")))
    |> Array.Parallel.collect (fun file_path ->
        try


            let file_graph = new ThreadSafeGraph()
            FileLoader.Load(file_graph, file_path)

            file_graph.NamespaceMap.Prefixes
            |> Seq.map (fun prefix ->
                let namespace_uri = file_graph.NamespaceMap.GetNamespaceUri prefix

                namespace_uri.OriginalString

            )
            |> Seq.toArray
        with 
        | err -> 
            log_lines.Add(sprintf "filepath %s   errored with %s" file_path err.Message) 
            [||]
    )





let prefixcc_namespace_pair = 

                Document.prefixcc.json.JsonValue.AsRecord
                |> Array.Parallel.map (fun (key,value) -> value.AsString(), key)

let lov_namespace_pair =
    Document.lov.json
    |> Array.Parallel.map (fun vocabulary -> vocabulary.Nsp, vocabulary.Prefix)

let filesystem_namespace_pair = 
    Folder.Vocabulary.descendant_files "*.ttl"
    |> Array.Parallel.filter (fun file_path -> not (file_path.Contains(@"https\spec.edmcouncil.org\fibo")))
    |> Array.Parallel.collect (fun file_path ->

        try

            let file_graph = new ThreadSafeGraph()
            FileLoader.Load(file_graph, file_path)

            file_graph.NamespaceMap.Prefixes
            |> Seq.map (fun prefix ->
                let namespace_uri = file_graph.NamespaceMap.GetNamespaceUri prefix

                namespace_uri.OriginalString, prefix

            )
            |> Seq.toArray

        with 
        | err -> 
            log_lines.Add(sprintf "filepath %s   errored with %s" file_path err.Message) 
            [||]
    )


let normalize_namespace_name (namespace_name: string) =
    let normalized = namespace_name.circumtrimmed

    if String.IsNullOrWhiteSpace normalized then
        invalidArg (nameof namespace_name) "A namespace IRI cannot be empty."

    normalized

let normalize_prefix_label (prefix_label: string) =
    let normalized = prefix_label.circumtrimmed

    if String.IsNullOrWhiteSpace normalized then
        invalidArg (nameof prefix_label) "A prefix label cannot be empty."

    normalized

let namespace_names = 
    Array.concat [|
        manual_namespace_names
        prefixcc_namespace_names
        lov_namespace_names
        filesystem_namespace_names
    |]
    |> Array.filter (fun namespace_name -> not (String.IsNullOrWhiteSpace namespace_name))
    |> Array.map normalize_namespace_name
    |> Array.distinct
    |> Array.sortBy (fun namespace_name -> namespace_name.Length)
    |> Array.rev

let namespace_pairs = 
    Array.concat [|
        prefixcc_namespace_pair
        lov_namespace_pair
        filesystem_namespace_pair
    |]
    |> Array.filter (fun (namespace_name, prefix_label ) -> not (String.IsNullOrWhiteSpace prefix_label))
    |> Array.map (fun (namespace_name, prefix_label ) -> normalize_namespace_name namespace_name,normalize_prefix_label prefix_label)
    |> Array.distinct
    |> Array.sort















let prefixes_grouped_by_namespace =
    namespace_pairs
    |> Array.groupBy(fun (namespace_name, prefix_label) -> namespace_name)
    |> Array.map (fun (namespace_name,pairs) -> namespace_name, pairs |> Array.map (fun (_,prefix_label) -> prefix_label) |> Array.sortBy(fun prefix_label -> prefix_label.Length))
let namespaces_grouped_by_prefix =
    namespace_pairs
    |> Array.groupBy(fun (namespace_name, prefix_label) -> prefix_label)
    |> Array.map (fun (prefix_label,pairs) -> prefix_label, pairs |> Array.map (fun (namespace_name,_) -> namespace_name) |> Array.sort)










type Unresolved_Namespace =
    | No_Prefix_Candidates of namespace_name: string
    | All_Prefix_Candidates_Claimed of
        namespace_name: string *
        prefix_candidates: string array
    member this.namespace_name = 
        match this with 
        | No_Prefix_Candidates name -> name
        | All_Prefix_Candidates_Claimed (name,_) -> name

type Namespace_Prefix_Resolution =
    {
        resolved: (string * string) array
        unresolved: Unresolved_Namespace array
    }

let resolve_namespace_prefixes
    (namespace_names: string array)
    (namespace_pairs: (string * string) array)
    (manual_overrides: Map<string, string>)
    : Namespace_Prefix_Resolution
    =

    let order_prefixes prefixes =
        prefixes
        |> Array.distinct
        |> Array.sortWith (fun (left:string) (right:string) ->
            let by_length =
                compare right.Length left.Length

            if by_length <> 0 then
                by_length
            else
                StringComparer.Ordinal.Compare(left, right)
        )

    let prefixes_by_namespace =
        namespace_pairs
        |> Array.groupBy fst
        |> Array.map (fun (namespace_name, pairs) ->
            namespace_name,
            pairs
            |> Array.map snd
            |> order_prefixes
        )
        |> Map.ofArray

    let all_namespaces =
        Array.concat [|
            namespace_names
            namespace_pairs |> Array.map fst
            manual_overrides |> Map.toArray |> Array.map fst
        |]
        |> Array.distinct
        |> Array.sort

    let conflicting_manual_overrides =
        manual_overrides
        |> Map.toArray
        |> Array.groupBy snd
        |> Array.filter (fun (_, assignments) ->
            assignments.Length > 1
        )

    if conflicting_manual_overrides.Length > 0 then
        let conflicts =
            conflicting_manual_overrides
            |> Array.map (fun (prefix_label, assignments) ->
                let namespaces =
                    assignments
                    |> Array.map fst
                    |> String.concat ", "

                sprintf "%s → %s" prefix_label namespaces
            )
            |> String.concat Environment.NewLine

        failwithf
            "Manual overrides assign the same prefix to multiple namespaces:%s%s"
            Environment.NewLine
            conflicts

    let used_prefixes = Generic.HashSet<string>(StringComparer.Ordinal)

    let resolved =
        ResizeArray<string * string>()

    let unresolved =
        ResizeArray<Unresolved_Namespace>()

    // Manual overrides are authoritative and reserve their prefixes first.
    for KeyValue(namespace_name, prefix_label) in manual_overrides do
        if String.IsNullOrWhiteSpace prefix_label then
            invalidArg
                (nameof manual_overrides)
                (sprintf
                    "The manual prefix for %s is empty."
                    namespace_name)

        used_prefixes.Add prefix_label
        |> ignore

        resolved.Add(namespace_name, prefix_label)

    let automatically_resolved_namespaces =
        all_namespaces
        |> Array.filter (fun namespace_name ->
            not (manual_overrides.ContainsKey namespace_name)
        )
        |> Array.sortBy (fun namespace_name ->
            let candidate_count =
                prefixes_by_namespace
                |> Map.tryFind namespace_name
                |> Option.map Array.length
                |> Option.defaultValue 0

            // Resolve namespaces with fewer alternatives first.
            candidate_count,
            namespace_name
        )

    for namespace_name in automatically_resolved_namespaces do
        let candidates =
            prefixes_by_namespace
            |> Map.tryFind namespace_name
            |> Option.defaultValue [||]

        match candidates with
        | [||] ->
            unresolved.Add(
                No_Prefix_Candidates namespace_name
            )

        | _ ->
            match
                candidates
                |> Array.tryFind (fun prefix_label ->
                    not (used_prefixes.Contains prefix_label)
                )
            with
            | Some prefix_label ->
                used_prefixes.Add prefix_label
                |> ignore

                resolved.Add(namespace_name, prefix_label)

            | None ->
                unresolved.Add(
                    All_Prefix_Candidates_Claimed(
                        namespace_name,
                        candidates
                    )
                )

    {
        resolved =
            resolved
            |> Seq.sortBy fst
            |> Seq.toArray

        unresolved =
            unresolved
            |> Seq.toArray
    }


let resolution =
    resolve_namespace_prefixes
        namespace_names
        namespace_pairs
        manual_prefix_overrides


let unresolved_namespaces =
    resolution.unresolved

let all_prefixes_taken =
    unresolved_namespaces
    |> Array.filter (fun unresolved -> unresolved.IsAll_Prefix_Candidates_Claimed )
    |> Array.map (fun unresolved -> unresolved.namespace_name)
    |> Array.map  (fun namespace_name -> new Uri(namespace_name))
    |> Array.map (fun namespace_uri -> 
        match namespace_uri.OriginalString, namespace_uri.Segments |> Array.last  with 
        | namespace_name, "" -> sprintf "\"%s\", \"%s\"" namespace_name (namespace_uri.Segments[namespace_uri.Segments.Length - 1].Replace("/",""))
        | namespace_name, prefix_label -> sprintf "\"%s\", \"%s\"" namespace_name (prefix_label.Replace("/",""))
    
        )
    
    



let no_prefixes_found =
    unresolved_namespaces
    |> Array.filter (fun unresolved -> unresolved.IsNo_Prefix_Candidates )
    |> Array.map (fun unresolved -> unresolved.namespace_name)
    |> Array.map  (fun namespace_name -> new Uri(namespace_name))
    |> Array.map (fun namespace_uri -> 
        match namespace_uri.OriginalString, namespace_uri.Segments |> Array.last  with 
        | namespace_name, "" -> sprintf "\"%s\", \"%s\"" namespace_name (namespace_uri.Segments[namespace_uri.Segments.Length - 1].Replace("/",""))
        | namespace_name, prefix_label -> sprintf "\"%s\", \"%s\"" namespace_name (prefix_label.Replace("/",""))
    
        )



let unresolved_namespace_names = 
    resolution.unresolved
    |> Array.map (fun unresolved -> unresolved.namespace_name)









let namespace_map =
    resolution.resolved
    |> Map.ofArray








    

let default_graph = new ThreadSafeGraph()

let voaf_vocabulary =
    default_graph.CreateUriNode(UriFactory.Create("http://purl.org/vocommons/voaf#Vocabulary"))

let rdf_type =
    default_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/1999/02/22-rdf-syntax-ns#type"))

let vann_preferredNamespacePrefix =
    default_graph.CreateUriNode(UriFactory.Create("http://purl.org/vocab/vann/preferredNamespacePrefix"))

let vann_preferredNamespaceUri =
    default_graph.CreateUriNode(UriFactory.Create("http://purl.org/vocab/vann/preferredNamespaceUri"))

let dcat_distribution =
    default_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/ns/dcat#distribution"))

let dcat_keyword =
    default_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/ns/dcat#keyword"))


let rdfs_label =
    default_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/2000/01/rdf-schema#label"))

let rdfs_comment =
    default_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/2000/01/rdf-schema#comment"))




    


module lov =
    type Meta = { last_meta: DateTimeOffset }

    let v2Base = "https://lov.linkeddata.es/dataset/lov/api/v2"

    let excluded_graph_names =
        set [

              "http://lov_server:3333/dataset/lov"

               ]

    module vocabulary =

        [<Literal>]
        let list_path =
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.vocabulary.json"

        let get_list () =
            download_remote_to_local $"{v2Base}/vocabulary/list" list_path

    module dump =
        module n3 =

            [<Literal>]
            let gz_path =
                @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.n3.gz"

            let file_path = gz_path.Replace(".gz", "")

            let gz () =
                http {
                    GET $"https://lov.linkeddata.es/lov.n3.gz"

                }
                |> Request.send

            [<Literal>]
            let meta_file_path =
                @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.n3.meta.json"

            let refresh () =
                try
                    let response = gz ()
                    printfn "downloading lov.n3.gz"

                    if response.originalHttpResponseMessage.IsSuccessStatusCode then
                        Response.saveFile gz_path response
                        decompress_gzip_file gz_path file_path
                        let last_meta = { last_meta = DateTimeOffset.Now }
                        let meta_file_content = Json.serialize last_meta
                        File.WriteAllText(meta_file_path, meta_file_content)
                        printfn "lov.n3.gz download complete"
                with 
                | err -> log_lines.Add(sprintf "lov_refresh errored with %s" err.Message)

            let json = JsonProvider<meta_file_path>.Load meta_file_path

            if json.LastMeta.Date < DateTime.Now.Date then
                printfn "updating lov.n3.gz from %A to current" json.LastMeta.Date
                refresh ()

            let graph = new ThreadSafeGraph()
            FileLoader.Load(graph, file_path)

            let vocabularies =

                graph.GetTriplesWithPredicateObject(rdf_type, voaf_vocabulary)
                |> Seq.toArray
                |> Array.Parallel.map (fun vocabulary_triple -> vocabulary_triple.Subject :?> UriNode)


            let vocabulary'preferredNamespaceUri =

                vocabularies
                |> Array.Parallel.collect (fun vocabulary ->
                    graph.GetTriplesWithSubjectPredicate(vocabulary, vann_preferredNamespaceUri)
                    |> Seq.toArray
                    |> Array.Parallel.map (fun preferred_uri_triple ->
                        let preferred_namespace = preferred_uri_triple.Object :?> LiteralNode
                        (vocabulary, preferred_namespace)

                    )

                )

            let vocabulary'preferredNamespaceUri'preferredNamespacePrefixes =
                vocabulary'preferredNamespaceUri
                |> Array.Parallel.collect (fun (vocabulary, preferred_namespace) ->
                    graph.GetTriplesWithSubjectPredicate(vocabulary, vann_preferredNamespacePrefix)
                    |> Seq.toArray
                    |> Array.Parallel.map (fun preferred_prefix_triple ->

                        let preferred_prefix = preferred_prefix_triple.Object :?> LiteralNode
                        (vocabulary, preferred_namespace, preferred_prefix)

                    )

                )


            let vocabulary'preferredNamespaceUri'preferredNamespacePrefixes'distribution =
                vocabulary'preferredNamespaceUri'preferredNamespacePrefixes

                |> Array.Parallel.collect (fun (vocabulary, preferred_namespace, preferred_prefix) ->
                    graph.GetTriplesWithSubjectPredicate(vocabulary, dcat_distribution)
                    |> Seq.toArray
                    |> Array.Parallel.filter (fun distribution_triple ->
                        distribution_triple.Object.NodeType = NodeType.Uri)
                    |> Array.Parallel.map (fun distribution_triple ->

                        let distribution = distribution_triple.Object :?> UriNode
                        (vocabulary, preferred_namespace, preferred_prefix, distribution)

                    )

                )



        module nq =

            [<Literal>]
            let gz_path =
                @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.nq.gz"

            let file_path = gz_path.Replace(".gz", "")
            let normalized_path = Path.ChangeExtension(file_path, ".normalized.nq")
            let cleaned_path = Path.ChangeExtension(normalized_path, ".cleaned.nq")

            let gz () =
                http {
                    GET $"https://lov.linkeddata.es/lov.nq.gz"

                }
                |> Request.send


            [<Literal>]
            let meta_file_path =
                @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.nq.meta.json"

            let refresh () =
                try
            
                    let response = gz ()
                    printfn "downloading lov.nq.gz"

                    if response.originalHttpResponseMessage.IsSuccessStatusCode then
                        Response.saveFile gz_path response
                        decompress_gzip_file gz_path file_path
                        normalize_nquads_file file_path normalized_path
                        write_valid_nquads_only normalized_path cleaned_path
                        let last_meta = { last_meta = DateTimeOffset.Now }
                        let meta_file_content = Json.serialize last_meta
                        File.WriteAllText(meta_file_path, meta_file_content)
                        printfn "lov.nq.gz download complete"

                with 
                | err -> log_lines.Add(sprintf "lov_refresh errored with %s" err.Message)
            let json = JsonProvider<meta_file_path>.Load meta_file_path

            if json.LastMeta.Date < DateTime.Now.Date then
                printfn "updating lov.nq.gz from %A to current" json.LastMeta.Date
                refresh ()

            let dataset = new DatasetFileManager(cleaned_path, false)

            let graph_names =
                dataset.ListGraphNames()
                |> Seq.toArray
                |> Array.Parallel.choose (fun graph_name ->

                    if excluded_graph_names.Contains(graph_name) then
                        None
                    else
                        Some graph_name


                )








    module Lov_Keyword =
        let API = dump.n3.graph.CreateLiteralNode("API")
        let Academy = dump.n3.graph.CreateLiteralNode("Academy")
        let Biology = dump.n3.graph.CreateLiteralNode("Biology")
        let CSV = dump.n3.graph.CreateLiteralNode("CSV")
        let Catalogs = dump.n3.graph.CreateLiteralNode("Catalogs")
        let Contracts = dump.n3.graph.CreateLiteralNode("Contracts")
        let Environment = dump.n3.graph.CreateLiteralNode("Environment")
        let Events = dump.n3.graph.CreateLiteralNode("Events")
        let FRBR = dump.n3.graph.CreateLiteralNode("FRBR")
        let Food = dump.n3.graph.CreateLiteralNode("Food")
        let Games = dump.n3.graph.CreateLiteralNode("Games")
        let General_and_Upper = dump.n3.graph.CreateLiteralNode("General & Upper")
        let Geography = dump.n3.graph.CreateLiteralNode("Geography")
        let Geometry = dump.n3.graph.CreateLiteralNode("Geometry")
        let Government = dump.n3.graph.CreateLiteralNode("Government")
        let Health = dump.n3.graph.CreateLiteralNode("Health")
        let Image = dump.n3.graph.CreateLiteralNode("Image")
        let Industry = dump.n3.graph.CreateLiteralNode("Industry")
        let IoT = dump.n3.graph.CreateLiteralNode("IoT")
        let Metadata = dump.n3.graph.CreateLiteralNode("Metadata")
        let Methods = dump.n3.graph.CreateLiteralNode("Methods")
        let Multimedia = dump.n3.graph.CreateLiteralNode("Multimedia")
        let Music = dump.n3.graph.CreateLiteralNode("Music")
        let PLM = dump.n3.graph.CreateLiteralNode("PLM")
        let PROTON = dump.n3.graph.CreateLiteralNode("PROTON")
        let People = dump.n3.graph.CreateLiteralNode("People")
        let Press = dump.n3.graph.CreateLiteralNode("Press")
        let Quality = dump.n3.graph.CreateLiteralNode("Quality")
        let RDF = dump.n3.graph.CreateLiteralNode("RDF")
        let Rec = dump.n3.graph.CreateLiteralNode("Rec")
        let SPAR = dump.n3.graph.CreateLiteralNode("SPAR")
        let SSDesk = dump.n3.graph.CreateLiteralNode("SSDesk")
        let Security = dump.n3.graph.CreateLiteralNode("Security")
        let Services = dump.n3.graph.CreateLiteralNode("Services")
        let Society = dump.n3.graph.CreateLiteralNode("Society")
        let Support = dump.n3.graph.CreateLiteralNode("Support")
        let Tag = dump.n3.graph.CreateLiteralNode("Tag")
        let Time = dump.n3.graph.CreateLiteralNode("Time")
        let Transport = dump.n3.graph.CreateLiteralNode("Transport")
        let Travel = dump.n3.graph.CreateLiteralNode("Travel")
        let Vocabularies = dump.n3.graph.CreateLiteralNode("Vocabularies")
        let W3CRec = dump.n3.graph.CreateLiteralNode("W3CRec")
        let eBusiness = dump.n3.graph.CreateLiteralNode("eBusiness")

        let _search (keyword: ILiteralNode) =
            dump.n3.graph.GetTriplesWithPredicateObject(dcat_keyword, keyword)
            |> Seq.toArray
            |> Array.Parallel.map (fun keyword_triple -> keyword_triple.Subject :?> UriNode)










let is_terminal_delimited (iri_string: string) =
    iri_string.EndsWith('#')
    || iri_string.EndsWith('/')

let is_not_terminal_delimited (iri_string: string) =
    not (iri_string |> is_terminal_delimited)


let absolute_graph_names =
    lov.dump.nq.graph_names
    |> Array.Parallel.filter (fun graph_name -> graph_name |> is_not_terminal_delimited)


namespace_names |> Array.tryFind(fun name  -> name.StartsWith "http://contsem.unizar.es/def/sector-publico/pproc")

lov.dump.nq.graph_names
|> Array.Parallel.filter (fun graph_name -> graph_name |> is_terminal_delimited)
let terminated_graph_namespace = 
    lov.dump.nq.graph_names
    |> Array.Parallel.filter(fun graph_name -> is_terminal_delimited graph_name)
    |> Array.Parallel.map (fun graph_name -> graph_name,graph_name )

let bare_graph_names = 
    lov.dump.nq.graph_names
    |> Array.Parallel.filter(fun graph_name -> is_not_terminal_delimited graph_name)

let bare_graph_namespace_names =
    bare_graph_names
    |> Array.map(fun graph_name  -> 
        graph_name, namespace_names 
        |> Array.Parallel.choose(fun namespace_name  -> 
            if namespace_name.StartsWith(graph_name) then 
                Some (namespace_name)
            else
                None
    )
    )
let bare_graph_namespace = 
    bare_graph_namespace_names
    |> Array.Parallel.filter (fun (graph_name, namespace_names) -> namespace_names.Length > 1)
    |> Array.Parallel.map  (fun (graph_name, namespace_names) -> graph_name, namespace_names |> Array.sortBy (fun namespace_name -> namespace_name.Length) |> Array.head)


let graph_names_missing_namespace_names = 
    bare_graph_namespace_names
    |> Array.filter (fun (graph_name, namespace_names) -> namespace_names.Length < 1)
    |> Array.map (fun (graph_name, namespace_names) -> graph_name)



let map_prefixes (prefix_label:string)(namespace_name:string)(graph: IGraph) =
            
            let uri_nodes =
                graph.AllNodes
                |> Seq.toArray
                |> Array.Parallel.choose (fun inode ->
                    if inode.NodeType = NodeType.Uri then
                        Some(inode :?> UriNode)
                    else
                        None

                )

            let term_is_namespaced =
                uri_nodes
                |> Array.Parallel.exists (fun uri_node ->

                    uri_node.Uri.OriginalString.StartsWith(namespace_name)

                )

            if term_is_namespaced then
                graph.NamespaceMap.AddNamespace(prefix_label, new Uri(namespace_name))




let lov_metadata =
        Array.concat [|
            terminated_graph_namespace
            bare_graph_namespace

        |]
        |> Array.Parallel.choose (fun (graph_name, namespace_name) -> 

        try
            let namespace_directory = Folder.Vocabulary ./ iri_to_relative_path namespace_name


            let prefix_label = namespace_map[namespace_name]
            let ttl_file = namespace_directory ./ $"{prefix_label}.ttl"


            if not (ttl_file.as_file.Exists) then
                let graph = new ThreadSafeGraph()

                lov.dump.nq.dataset.LoadGraph(graph, graph_name)
                graph |> map_prefixes prefix_label namespace_name
                Console.WriteLine $"Saving {namespace_name} as {prefix_label}.ttl"
                Directory.CreateDirectory(ttl_file.parent_directory.FullName) |> ignore
                Turtle.write ttl_file.path graph

            Some {
                namespace_prefix = prefix_label
                namespace_name = namespace_name

            }

        with
        | err ->
            log_lines.Add(sprintf "lov graph_name %s  namespace_name %s errored with %s" graph_name namespace_name err.Message) 
            None
        )









let acceptedMediaTypes =
    [|

       $"{MediaType.application.trig};q=1"
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
       $"{MediaType.text.plain};charset=utf-8;q=0.2"
       $"{MediaType.any};q=0.1"

       |]




let http_client = new HttpClient()

acceptedMediaTypes
|> Array.iter (fun media_type ->

    http_client.DefaultRequestHeaders.Accept.ParseAdd(media_type))



let rdf_loader = new Loader(http_client)
rdf_loader.FollowRedirects <- true













let distribution_http_response (distribution: string) : HttpResponseMessage option =
    try
        let http_response =
            http {
                GET(distribution.Replace("https", "http"))
                UserAgent userAgent
                Accept(acceptedMediaTypes |> String.concat ", ")
            }
            |> Request.send
            |> Response.asOriginalHttpResponseMessage

        Some http_response

    with
    | err ->
        log_lines.Add $"HTTP failed for {distribution}: {err.Message}"
        None

// TODO obo 
let manual_content =
    manual_distributions
    |> Array.Parallel.choose (fun (namespace_name, namespace_distribution) ->
        try

            let namespace_uri = new Uri(namespace_name)
            let distribution_uri = new Uri(namespace_distribution)

            let namespace_directory = Folder.Vocabulary ./ iri_to_relative_path namespace_name
            let prefix_label = namespace_map[namespace_name]



            let ttl_file = namespace_directory ./ $"{prefix_label}.ttl"



            if not (ttl_file.as_file.Exists) then
                let graph = new ThreadSafeGraph()

                try
                    match namespace_name with
                    | "http://www.essepuntato.it/2011/02/argumentmodel/"
                    | "http://example.org/dctap#"
                    | "http://www.opengis.net/ont/geosparql#"
                    | "https://www.commoncoreontologies.org/"
                    | "https://w3id.org/linkml/"
                    | "http://data.europa.eu/m8g/"
                    | "http://www.w3.org/2001/XMLSchema#" -> rdf_loader.LoadGraph(graph, distribution_uri, TurtleParser())
                    | "http://id.loc.gov/ontologies/bflc/"
                    | "http://id.loc.gov/ontologies/bibframe/"
                    | "http://www.w3.org/2002/12/cal/icaltzd#"
                    | "http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#"
                    | "http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#"
                    | "http://www.loc.gov/premis/rdf/v3/"
                    | "http://www.essepuntato.it/2008/12/earmark#"
                    | "https://raw.githubusercontent.com/tetherless-world/explanation-ontology/master/Ontologies/v2/explanation-ontology.owl"
                    | "http://aims.fao.org/aos/agrontology#" -> rdf_loader.LoadGraph(graph, distribution_uri, RdfXmlParser())
                    | _ when namespace_name.StartsWith("http://tracker.api.gnome.org/ontology/v3/") -> rdf_loader.LoadGraph(graph, distribution_uri, TurtleParser())
                    | _ when namespace_name.StartsWith("http://eulersharp.sourceforge.net/2003/03swap/") -> rdf_loader.LoadGraph(graph, distribution_uri, TurtleParser())
                    | _ when namespace_name.StartsWith("http://www.semanticdesktop.org/ontologies") ->
                        let dataset = new ThreadSafeTripleStore()
                        rdf_loader.LoadDataset(dataset, distribution_uri, TriGParser())
                        for dataset_graph in dataset.Graphs do
                            graph.Merge(dataset_graph, false)
                    | _ -> rdf_loader.LoadGraph(graph, distribution_uri)

                    Console.WriteLine $"Saving {namespace_name} as {prefix_label}.ttl"
                    graph |> map_prefixes prefix_label namespace_name
                    Directory.CreateDirectory(ttl_file.parent_directory.FullName) |> ignore
                    Turtle.write ttl_file.path graph
                with
                | err ->
                    // errored_namespaces.Add $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                    match distribution_http_response namespace_distribution with

                    | Some http_response when http_response.IsSuccessStatusCode ->

                        let file_text =
                            http_response.Content.ReadAsStringAsync()
                            |> Async.AwaitTask
                            |> Async.RunSynchronously
                        try
                            StringParser.Parse(graph, file_text)
                            Console.WriteLine $"Saving {namespace_name} as {prefix_label}.ttl"
                            graph |> map_prefixes prefix_label namespace_name
                            Directory.CreateDirectory(ttl_file.parent_directory.FullName) |> ignore
                            Turtle.write ttl_file.path graph
                        with
                        | err -> log_lines.Add $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                    | _ -> log_lines.Add $"No http response for {namespace_name} distribution {namespace_distribution}"

            Some {
                    namespace_prefix = prefix_label
                    namespace_name = namespace_name
                }

        with
        | err ->
            log_lines.Add(sprintf "manual  namespace_name %s distribution %s errored with %s" namespace_name namespace_distribution err.Message) 
            None
    )

let file_stem_from_name_distribution namespace_name namespace_distribution =

    let distribution_uri = new Uri(namespace_distribution)
    let distribution_stem = distribution_uri.Segments |> Array.last

    match namespace_map[namespace_name] with
    | _ when namespace_name = "http://www.w3.org/2001/XMLSchema#" -> "xsd"
    | prefix_label when namespace_name <> namespace_distribution -> $"{prefix_label}-{distribution_stem}"
    | prefix_label -> prefix_label


let multipart_content =
    multipart_distributions
    |> Array.Parallel.choose (fun (namespace_name, namespace_distributions) ->
        try

            let ttl_paths =
                namespace_distributions
                |> Array.Parallel.map (fun namespace_distribution ->
                    let namespace_uri = new Uri(namespace_name)
                    let distribution_uri = new Uri(namespace_distribution)

                    let namespace_directory = Folder.Vocabulary ./ iri_to_relative_path namespace_name
                    let file_stem =
                        let file_name = 
                                let distribution_uri = new Uri(namespace_distribution)
                                let distribution_stem = distribution_uri.Segments |> Array.last

                                match namespace_map[namespace_name] with
                                | _ when namespace_name = "http://www.w3.org/2001/XMLSchema#" -> "xsd"
                                | prefix_label when namespace_name <> namespace_distribution -> $"{prefix_label}-{distribution_stem}"
                                | prefix_label -> prefix_label

                        file_name.Replace(".ttl", "")
                    let prefix_label = namespace_map[namespace_name]
                    let ttl_file = namespace_directory ./ $"{file_stem}.ttl"




                    if not (ttl_file.as_file.Exists) then
                        let graph = new ThreadSafeGraph()

                        match namespace_name with
                        | _ ->
                            try
                                rdf_loader.LoadGraph(graph, distribution_uri)
                                Console.WriteLine $"Saving {namespace_name} as {file_stem}.ttl"
                                graph |> map_prefixes prefix_label namespace_name
                                Directory.CreateDirectory(ttl_file.parent_directory.FullName) |> ignore
                                Turtle.write ttl_file.path graph
                            with
                            | err ->
                                // errored_namespaces.Add $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                                match distribution_http_response namespace_distribution with

                                | Some http_response when http_response.IsSuccessStatusCode ->

                                    let file_text =
                                        http_response.Content.ReadAsStringAsync()
                                        |> Async.AwaitTask
                                        |> Async.RunSynchronously
                                    try
                                        StringParser.Parse(graph, file_text)
                                        Console.WriteLine $"Saving {namespace_name} as {prefix_label}.ttl"
                                        graph |> map_prefixes prefix_label namespace_name
                                        Directory.CreateDirectory(ttl_file.parent_directory.FullName) |> ignore
                                        Turtle.write ttl_file.path graph

                                    with
                                    | err -> log_lines.Add $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                                | _ -> log_lines.Add $"No http response for {namespace_name} distribution {namespace_distribution}"
                    ttl_file.path
                )


            Some {
                namespace_prefix = namespace_map[namespace_name]
                namespace_name = namespace_name

            }

        with
        | err ->
            log_lines.Add(sprintf "multipart namespace_name %s distributions %A errored with %s" namespace_name namespace_distributions err.Message) 
            None

    )










type Prefix_Registry = 
    {
        prefix_ids : Prefix_ID array
    }

let prefix_registry = 
    {
        prefix_ids = 
            Array.concat [|
                        fibo.metadata
                        lov_metadata
                        manual_content
                        resolution.resolved |> Array.map (fun (namespace_name, prefix_label) -> 
                                                                                    {
                                                                                        namespace_prefix = prefix_label
                                                                                        namespace_name = namespace_name
                                                                                    }
                        )
                    |]
                    |> Array.distinct

    }


(*

prefix_registry.prefix_ids 
|> Array.Parallel.map (fun prefix_id -> 
sprintf """    static member %s = {namespace_prefix = "%s" ; namespace_name = "%s"}""" prefix_id.namespace_prefix.normalize_identifier prefix_id.namespace_prefix prefix_id.namespace_name
)
|> Array.sort
|> String.concat "\n"
|> clip

*)







let prefix_map= 
    prefix_registry.prefix_ids
    |> Array.Parallel.map (fun prefix_id -> prefix_id.namespace_name,prefix_id)
    |> Map.ofArray


File.WriteAllText(@"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Registry\PrefixRegistry.json", Json.serialize prefix_registry)




