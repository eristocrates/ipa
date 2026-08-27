#time on
fsi.ShowDeclarationValues <- false
fsi.PrintLength <- 10


open System
open System.Globalization
open System.Text
open System.IO
open System.Linq
open System.Xml
open System.Collections

open System.IO.Compression
#r "nuget: FSharp.ViewEngine"

#r "nuget: Fabulous.AST"
open Fabulous.AST
open Fantomas.Core.SyntaxOak

open type Fabulous.AST.Ast
#r "nuget: FsHttp"
open FsHttp

#r "nuget: FSharp.Data.Adaptive"
open FSharp.Data
open FSharp.Data.Adaptive.Transaction
#r "nuget: FSharp.Data"
open FSharp.Data
#r "nuget: FSharp.HashCollections"
open FSharp.HashCollections

#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq
#r "nuget: dotNetRdf"
#r "nuget: Unquote"
open Swensen.Unquote.Assertions

#r "nuget: FSharp.Json"
open FSharp.Json

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF.Query.Datasets
open VDS.RDF.Storage
open VDS.RDF.Query.Builder
open VDS.RDF.Query
open VDS.RDF.Query.Patterns
open VDS.RDF.Query.Inference



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"

open PowershellErgonomics

#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\DotNetRDFSharp\\obj\Release\net10.0\DotNetRDFSharp.dll"
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Ergonomic_Extensions\obj\Release\net10.0\Ergonomic_Extensions.dll"
open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID
open NamespaceRegistry
open PrettierNaming
open PrettierNaming.FSharp_Keywords
open JsonErgonomics
open IOExtensions
open ArrayErgonomics
open RdfExtensions
open StringExtensions
open System.Net.Http
open VDS.RDF.Nodes
open DotNetRDFSharp
open RDF_Shorthand
open RDF_Query
open Graph_Data
open XmlErgonomics


#r "nuget: FSharp.Json"
open FSharp.Json
open VDS.RDF.Ontology
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\DotNetRDFSharp\RDF_Distribution\Single.fs"
open RDF_Distribution.Single
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\DotNetRDFSharp\RDF_Distribution\Multi.fs"
open RDF_Distribution.Multi
#load  @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\DotNetRDFSharp\Manual_Prefixes.fs"
open Manual_Prefixes




fsi.AddPrinter<Iri>(fun iri -> iri.curie)
fsi.AddPrinter<RDF_Literal>(fun literal -> literal.curie)
fsi.AddPrinter<Blank_Node>(fun blank_node -> blank_node.nt)



let well_known_base = $"https://eristocrates.dev/.well-known/genid/"








let log_lines = new ResizeArray<string>()

module fibo =
    let distribution_probe =
        http { GET "https://github.com/edmcouncil/fibo/releases/latest" }
        |> Request.send

    let download_distribution (distribution: string) =
        http {

            GET distribution

        }
        |> Request.send

    let extraction_directory = Folder.Vocabulary ./ @"https\spec.edmcouncil.org"

    let latest_source =
        distribution_probe.originalHttpResponseMessage.RequestMessage.RequestUri.OriginalString
        + ".zip"

    printfn "latest fibo source: %s" latest_source



    let file_name =
        (iri_to_relative_path latest_source)
            .Replace("\\bare", "")
            .Split("\\")
        |> Array.last

    let version =
        let master_ = "master_"
        let zip = ".zip"
        file_name[master_.Length .. file_name.Length - zip.Length - 1]

    printfn "latest fibo version: %s" version

    let content_directory =
        extraction_directory
        ./ $@"fibo\ontology\master\{version}"

    if not content_directory.as_directory.Exists then
        Directory.CreateDirectory(content_directory.path)
        |> ignore

    let fibo_zip = content_directory ./ @"prod.ttl.zip"

    if not fibo_zip.as_file.Exists then
        let distribution =
            $"https://spec.edmcouncil.org/fibo/ontology/master/{version}/prod.ttl.zip"

        printfn "downloading fibo version %s" version
        let response = download_distribution distribution

        if response.originalHttpResponseMessage.IsSuccessStatusCode then
            Response.saveFile fibo_zip.as_file.FullName response

            if not Folder.fibo.as_directory.Exists then
                Directory.CreateDirectory(Folder.fibo.path)
                |> ignore

            ZipFile.ExtractToDirectory(fibo_zip.as_file.FullName, Folder.fibo.as_directory.FullName)

        printfn "fibo version %s download complete" version
    else
        printfn "fibo version %s already downloaded" version

    let vocabulary_files = content_directory.descendant_files "*.ttl"


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
                [||])
        |> Array.distinct

    let metadata =
        printfn "processing fibo metadata"

        vocabulary_files
        |> Array.Parallel.choose (fun ttl_path ->
            let file_stem = Path.GetFileNameWithoutExtension ttl_path

            let type_binding =
                match file_stem with
                | prefix when FSharp_Keywords.reserved_keywords.Contains(prefix) -> $"{prefix}_"
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
                Some
                    { namespace_prefix = prefix_label
                      namespace_name = namespace_name }
            | None -> None)

    test <@ vocabulary_files.Length = metadata.Length @>
    printfn "fibo metadata complete"




// TODO add yago
// https://yago-knowledge.org/data/











let manual_namespace_names =
    manual_distributions
    |> Array.map (fun (namespace_name, _) -> namespace_name)

let prefixcc_namespace_names =

    Document.prefixcc.json.JsonValue.AsRecord
    |> Array.Parallel.map (fun (key, value) -> value.AsString())

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
            [||])





let prefixcc_namespace_pair =

    Document.prefixcc.json.JsonValue.AsRecord
    |> Array.Parallel.map (fun (key, value) -> value.AsString(), key)

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
            [||])


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
    Array.concat [| manual_namespace_names
                    prefixcc_namespace_names
                    lov_namespace_names
                    filesystem_namespace_names |]
    |> Array.filter (fun namespace_name -> not (String.IsNullOrWhiteSpace namespace_name))
    |> Array.map normalize_namespace_name
    |> Array.distinct
    |> Array.sortBy (fun namespace_name -> namespace_name.Length)
    |> Array.rev

let namespace_pairs =
    Array.concat [| prefixcc_namespace_pair
                    lov_namespace_pair
                    filesystem_namespace_pair |]
    |> Array.filter (fun (namespace_name, prefix_label) -> not (String.IsNullOrWhiteSpace prefix_label))
    |> Array.map (fun (namespace_name, prefix_label) ->
        normalize_namespace_name namespace_name, normalize_prefix_label prefix_label)
    |> Array.distinct
    |> Array.sort















let prefixes_grouped_by_namespace =
    namespace_pairs
    |> Array.groupBy (fun (namespace_name, prefix_label) -> namespace_name)
    |> Array.map (fun (namespace_name, pairs) ->
        namespace_name,
        pairs
        |> Array.map (fun (_, prefix_label) -> prefix_label)
        |> Array.sortBy (fun prefix_label -> prefix_label.Length))

let namespaces_grouped_by_prefix =
    namespace_pairs
    |> Array.groupBy (fun (namespace_name, prefix_label) -> prefix_label)
    |> Array.map (fun (prefix_label, pairs) ->
        prefix_label,
        pairs
        |> Array.map (fun (namespace_name, _) -> namespace_name)
        |> Array.sort)










type Unresolved_Namespace =
    | No_Prefix_Candidates of namespace_name: string
    | All_Prefix_Candidates_Claimed of namespace_name: string * prefix_candidates: string array
    member this.namespace_name =
        match this with
        | No_Prefix_Candidates name -> name
        | All_Prefix_Candidates_Claimed (name, _) -> name

type Namespace_Prefix_Resolution =
    { resolved: (string * string) array
      unresolved: Unresolved_Namespace array }

let resolve_namespace_prefixes
    (namespace_names: string array)
    (namespace_pairs: (string * string) array)
    (manual_overrides: Map<string, string>)
    : Namespace_Prefix_Resolution =

    let order_prefixes prefixes =
        prefixes
        |> Array.distinct
        |> Array.sortWith (fun (left: string) (right: string) ->
            let by_length = compare right.Length left.Length

            if by_length <> 0 then
                by_length
            else
                StringComparer.Ordinal.Compare(left, right))

    let prefixes_by_namespace =
        namespace_pairs
        |> Array.groupBy fst
        |> Array.map (fun (namespace_name, pairs) -> namespace_name, pairs |> Array.map snd |> order_prefixes)
        |> Map.ofArray

    let all_namespaces =
        Array.concat [| namespace_names
                        namespace_pairs |> Array.map fst
                        manual_overrides |> Map.toArray |> Array.map fst |]
        |> Array.distinct
        |> Array.sort

    let conflicting_manual_overrides =
        manual_overrides
        |> Map.toArray
        |> Array.groupBy snd
        |> Array.filter (fun (_, assignments) -> assignments.Length > 1)

    if conflicting_manual_overrides.Length > 0 then
        let conflicts =
            conflicting_manual_overrides
            |> Array.map (fun (prefix_label, assignments) ->
                let namespaces = assignments |> Array.map fst |> String.concat ", "

                sprintf "%s → %s" prefix_label namespaces)
            |> String.concat Environment.NewLine

        failwithf "Manual overrides assign the same prefix to multiple namespaces:%s%s" Environment.NewLine conflicts

    let used_prefixes = Generic.HashSet<string>(StringComparer.Ordinal)

    let resolved = ResizeArray<string * string>()

    let unresolved = ResizeArray<Unresolved_Namespace>()

    // Manual overrides are authoritative and reserve their prefixes first.
    for KeyValue (namespace_name, prefix_label) in manual_overrides do
        if String.IsNullOrWhiteSpace prefix_label then
            invalidArg (nameof manual_overrides) (sprintf "The manual prefix for %s is empty." namespace_name)

        used_prefixes.Add prefix_label |> ignore

        resolved.Add(namespace_name, prefix_label)

    let automatically_resolved_namespaces =
        all_namespaces
        |> Array.filter (fun namespace_name -> not (manual_overrides.ContainsKey namespace_name))
        |> Array.sortBy (fun namespace_name ->
            let candidate_count =
                prefixes_by_namespace
                |> Map.tryFind namespace_name
                |> Option.map Array.length
                |> Option.defaultValue 0

            // Resolve namespaces with fewer alternatives first.
            candidate_count, namespace_name)

    for namespace_name in automatically_resolved_namespaces do
        let candidates =
            prefixes_by_namespace
            |> Map.tryFind namespace_name
            |> Option.defaultValue [||]

        match candidates with
        | [||] -> unresolved.Add(No_Prefix_Candidates namespace_name)

        | _ ->
            match candidates
                  |> Array.tryFind (fun prefix_label -> not (used_prefixes.Contains prefix_label))
                with
            | Some prefix_label ->
                used_prefixes.Add prefix_label |> ignore

                resolved.Add(namespace_name, prefix_label)

            | None -> unresolved.Add(All_Prefix_Candidates_Claimed(namespace_name, candidates))

    { resolved = resolved |> Seq.sortBy fst |> Seq.toArray

      unresolved = unresolved |> Seq.toArray }


let resolution =
    resolve_namespace_prefixes namespace_names namespace_pairs manual_prefix_overrides


let unresolved_namespaces = resolution.unresolved

let all_prefixes_taken =
    unresolved_namespaces
    |> Array.filter (fun unresolved -> unresolved.IsAll_Prefix_Candidates_Claimed)
    |> Array.map (fun unresolved -> unresolved.namespace_name)
    |> Array.map (fun namespace_name -> new Uri(namespace_name))
    |> Array.map (fun namespace_uri ->
        match namespace_uri.OriginalString, namespace_uri.Segments |> Array.last with
        | namespace_name, "" ->
            sprintf
                "\"%s\", \"%s\""
                namespace_name
                (namespace_uri
                    .Segments[ namespace_uri.Segments.Length - 1 ]
                    .Replace("/", ""))
        | namespace_name, prefix_label -> sprintf "\"%s\", \"%s\"" namespace_name (prefix_label.Replace("/", ""))

    )





let no_prefixes_found =
    unresolved_namespaces
    |> Array.filter (fun unresolved -> unresolved.IsNo_Prefix_Candidates)
    |> Array.map (fun unresolved -> unresolved.namespace_name)
    |> Array.map (fun namespace_name -> new Uri(namespace_name))
    |> Array.map (fun namespace_uri ->
        match namespace_uri.OriginalString, namespace_uri.Segments |> Array.last with
        | namespace_name, "" ->
            sprintf
                "\"%s\", \"%s\""
                namespace_name
                (namespace_uri
                    .Segments[ namespace_uri.Segments.Length - 1 ]
                    .Replace("/", ""))
        | namespace_name, prefix_label -> sprintf "\"%s\", \"%s\"" namespace_name (prefix_label.Replace("/", ""))

    )



let unresolved_namespace_names =
    resolution.unresolved
    |> Array.map (fun unresolved -> unresolved.namespace_name)









let namespace_map = resolution.resolved |> Map.ofArray









(*

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




*)



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
(*

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


*)

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

















let rdf_type = Prefixed_Name(rdf,"type") |> PrefixedName
let voaf_vocabulary = Prefixed_Name(voaf,"Vocabulary") |> PrefixedName
let vocabulary_variable = !? "vocabulary"
let vocabulary_pattern = !> vocabulary_variable --- rdf_type --> voaf_vocabulary

let vocabularies = 
    sparql.select [vocabulary_variable] {
        where vocabulary_pattern
        from lov.dump.n3.graph
    } 


let preferredNamespaceUri_variable = !? "preferredNamespaceUri"

let vannpreferredNamespaceUri = Prefixed_Name(vann,"preferredNamespaceUri") |> PrefixedName

let preferredNamespaceUri_pattern = !> vocabulary_variable --- vannpreferredNamespaceUri --> preferredNamespaceUri_variable

let preferredNamespaceUris = 

    sparql.select [vocabulary_variable ; preferredNamespaceUri_variable] 
            {
            where preferredNamespaceUri_pattern
            from lov.dump.n3.graph
            }

let preferredNamespace_by_vocabulary =  
    Array.zip  (preferredNamespaceUris.variable_column preferredNamespaceUri_variable) (preferredNamespaceUris.variable_column vocabulary_variable )
    |> Array.map (fun (LiteralRDFTerm namespace_name, IriRDFTerm vocabulary) -> vocabulary.lexical_form, namespace_name.lexical_form)
    |> Map.ofArray
let vocabulary_by_namespace_name =  
    Array.zip  (preferredNamespaceUris.variable_column preferredNamespaceUri_variable) (preferredNamespaceUris.variable_column vocabulary_variable )
    |> Array.map (fun (LiteralRDFTerm namespace_name, IriRDFTerm vocabulary) -> namespace_name.lexical_form, vocabulary.lexical_form)
    |> Map.ofArray


let vannpreferredNamespacePrefix = Prefixed_Name(vann,"preferredNamespacePrefix") |> PrefixedName

let preferredNamespacePrefix_variable = !? "preferredNamespacePrefix"


let preferredNamespacePrefix_pattern = !> vocabulary_variable --- vannpreferredNamespacePrefix --> preferredNamespacePrefix_variable

let preferredNamespacePrefixes = 

    sparql.select [vocabulary_variable ; preferredNamespacePrefix_variable] 
            {
            where preferredNamespacePrefix_pattern
            from lov.dump.n3.graph
            }

preferredNamespacePrefixes.Results 
let preferred_prefix_by_vocabulary =  
    Array.zip  (preferredNamespacePrefixes.variable_column preferredNamespacePrefix_variable) (preferredNamespacePrefixes.variable_column vocabulary_variable )
    |> Array.map (fun (LiteralRDFTerm namespace_prefix, IriRDFTerm vocabulary) -> vocabulary.lexical_form, namespace_prefix.lexical_form)
    |> Map.ofArray

let preferred_prefix_by_namespace_name = 
    vocabularies.variable_column vocabulary_variable
    |> Array.map (fun (IriRDFTerm vocabulary) -> preferredNamespace_by_vocabulary[vocabulary.lexical_form],preferred_prefix_by_vocabulary[vocabulary.lexical_form])
    |> Map.ofArray


let is_terminal_delimited (iri_string: string) =
    iri_string.EndsWith('#')
    || iri_string.EndsWith('/')

let is_not_terminal_delimited (iri_string: string) =
    not (iri_string |> is_terminal_delimited)




let terminated_graph_namespace =
    lov.dump.nq.graph_names
    |> Array.Parallel.filter (fun graph_name -> is_terminal_delimited graph_name)
    |> Array.Parallel.map (fun graph_name -> graph_name, graph_name)

let nonterminated_graph_namespace =
    lov.dump.nq.graph_names
    |> Array.Parallel.filter (fun graph_name -> is_not_terminal_delimited graph_name)
    |> Array.map (fun graph_name -> graph_name, preferredNamespace_by_vocabulary[graph_name])





(*

let bare_graph_namespace_names =
    bare_graph_names
    |> Array.map (fun graph_name ->
        graph_name,
        namespace_names
        |> Array.Parallel.choose (fun namespace_name ->
            if namespace_name.StartsWith(graph_name) then
                Some(namespace_name)
            else
                None))

let bare_graph_namespace =
    bare_graph_namespace_names
    |> Array.Parallel.filter (fun (graph_name, namespace_names) -> namespace_names.Length > 1)
    |> Array.Parallel.map (fun (graph_name, namespace_names) ->
        graph_name,
        namespace_names
        |> Array.sortBy (fun namespace_name -> namespace_name.Length)
        |> Array.head)

        
let graph_names_missing_namespace_names =
    bare_graph_namespace_names
    |> Array.filter (fun (graph_name, namespace_names) -> namespace_names.Length < 1)
    |> Array.map (fun (graph_name, namespace_names) -> graph_name, graph_name)
*)


let map_prefixes (prefix_label: string) (namespace_name: string) (graph: IGraph) =

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
                    nonterminated_graph_namespace

                     |]
    |> Array.Parallel.choose (fun (graph_name, namespace_name) ->

        try
            let namespace_directory =
                Folder.Vocabulary ./ iri_to_relative_path namespace_name


            let prefix_label = namespace_map[namespace_name]
            let ttl_file = namespace_directory ./ $"{prefix_label}.ttl"


            if not (ttl_file.as_file.Exists) then
                let graph = new ThreadSafeGraph()

                lov.dump.nq.dataset.LoadGraph(graph, graph_name)
                graph |> map_prefixes prefix_label namespace_name
                Console.WriteLine $"Saving {namespace_name} as {prefix_label}.ttl"

                Directory.CreateDirectory(ttl_file.parent_directory.FullName)
                |> ignore

                Turtle.write ttl_file.path graph

            Some
                { namespace_prefix = prefix_label
                  namespace_name = namespace_name

                }

        with
        | err ->
            log_lines.Add(
                sprintf "lov graph_name %s  namespace_name %s errored with %s" graph_name namespace_name err.Message
            )

            None)









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

            let namespace_directory =
                Folder.Vocabulary
                ./ iri_to_relative_path namespace_name

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
                    | "http://www.w3.org/2001/XMLSchema#" ->
                        rdf_loader.LoadGraph(graph, distribution_uri, TurtleParser())
                    | "http://id.loc.gov/ontologies/bflc/"
                    | "http://id.loc.gov/ontologies/bibframe/"
                    | "http://www.w3.org/2002/12/cal/icaltzd#"
                    | "http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#"
                    | "http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#"
                    | "http://www.loc.gov/premis/rdf/v3/"
                    | "http://www.essepuntato.it/2008/12/earmark#"
                    | "https://raw.githubusercontent.com/tetherless-world/explanation-ontology/master/Ontologies/v2/explanation-ontology.owl"
                    | "http://aims.fao.org/aos/agrontology#" ->
                        rdf_loader.LoadGraph(graph, distribution_uri, RdfXmlParser())
                    | _ when namespace_name.StartsWith("http://tracker.api.gnome.org/ontology/v3/") ->
                        rdf_loader.LoadGraph(graph, distribution_uri, TurtleParser())
                    | _ when namespace_name.StartsWith("http://eulersharp.sourceforge.net/2003/03swap/") ->
                        rdf_loader.LoadGraph(graph, distribution_uri, TurtleParser())
                    | _ when namespace_name.StartsWith("http://www.semanticdesktop.org/ontologies") ->
                        let dataset = new ThreadSafeTripleStore()
                        rdf_loader.LoadDataset(dataset, distribution_uri, TriGParser())

                        for dataset_graph in dataset.Graphs do
                            graph.Merge(dataset_graph, false)
                    | _ -> rdf_loader.LoadGraph(graph, distribution_uri)

                    Console.WriteLine $"Saving {namespace_name} as {prefix_label}.ttl"
                    graph |> map_prefixes prefix_label namespace_name

                    Directory.CreateDirectory(ttl_file.parent_directory.FullName)
                    |> ignore

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

                            Directory.CreateDirectory(ttl_file.parent_directory.FullName)
                            |> ignore

                            Turtle.write ttl_file.path graph
                        with
                        | err ->
                            log_lines.Add $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                    | _ -> log_lines.Add $"No http response for {namespace_name} distribution {namespace_distribution}"

            Some
                { namespace_prefix = prefix_label
                  namespace_name = namespace_name }

        with
        | err ->
            log_lines.Add(
                sprintf
                    "manual  namespace_name %s distribution %s errored with %s"
                    namespace_name
                    namespace_distribution
                    err.Message
            )

            None)

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

                    let namespace_directory =
                        Folder.Vocabulary
                        ./ iri_to_relative_path namespace_name

                    let file_stem =
                        let file_name =
                            let distribution_uri = new Uri(namespace_distribution)
                            let distribution_stem = distribution_uri.Segments |> Array.last

                            match namespace_map[namespace_name] with
                            | _ when namespace_name = "http://www.w3.org/2001/XMLSchema#" -> "xsd"
                            | prefix_label when namespace_name <> namespace_distribution ->
                                $"{prefix_label}-{distribution_stem}"
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

                                Directory.CreateDirectory(ttl_file.parent_directory.FullName)
                                |> ignore

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

                                        Directory.CreateDirectory(ttl_file.parent_directory.FullName)
                                        |> ignore

                                        Turtle.write ttl_file.path graph

                                    with
                                    | err ->
                                        log_lines.Add
                                            $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                                | _ ->
                                    log_lines.Add
                                        $"No http response for {namespace_name} distribution {namespace_distribution}"

                    ttl_file.path)


            Some
                { namespace_prefix = namespace_map[namespace_name]
                  namespace_name = namespace_name

                }

        with
        | err ->
            log_lines.Add(
                sprintf
                    "multipart namespace_name %s distributions %A errored with %s"
                    namespace_name
                    namespace_distributions
                    err.Message
            )

            None

    )










type Prefix_Registry = { prefix_ids: Prefix_ID array }

let prefix_registry =
    { prefix_ids =
        Array.concat [| fibo.metadata
                        lov_metadata
                        manual_content
                        resolution.resolved
                        |> Array.map (fun (namespace_name, prefix_label) ->
                            { namespace_prefix = prefix_label
                              namespace_name = namespace_name }) |]
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









let prefix_map =
    prefix_registry.prefix_ids
    |> Array.Parallel.map (fun prefix_id -> prefix_id.namespace_name, prefix_id)
    |> Map.ofArray
*)

File.WriteAllText(
    Document.PrefixRegistry.literal_path,
    Json.serialize prefix_registry
)


































































    


let dcatdistribution = Prefixed_Name(prefix_map["http://www.w3.org/ns/dcat#"],"distribution") |> PrefixedName
    

let dcatkeyword = Prefixed_Name(prefix_map["http://www.w3.org/ns/dcat#"],"keyword") |> PrefixedName
    


let rdfslabel = Prefixed_Name(rdfs,"label") |> PrefixedName
    

let rdfscomment = Prefixed_Name(rdfs,"comment") |> PrefixedName
    






let lov_graph = new ThreadSafeGraph()
FileLoader.Load(lov_graph, Document.lov.n3.path)



(*

let vocabulary_graph = 
    sparql.discover [ vocabulary_variable ] {
        where (!> vocabulary_variable --- rdf_type --> voaf_vocabulary)
        from lov_graph
    } |> RDF_Graph.from_vds_graph
let triples_by_vocabulary = 
    vocabulary_graph.triples 
    |> Seq.toArray
    |> Array.groupBy (fun triple -> triple.curSubject)
let random_vocabulary = triples_by_vocabulary |> Array.randomChoice
*)

let should_overwrite = true
let error_lines = new ResizeArray<string>()
let in_memory_dataset = new InMemoryDataset(new DiskDemandTripleStore(), true, false)
let fibo_substring = @"https\spec.edmcouncil.org\fibo"

let default_graph  =
    Folder.Vocabulary.descendant_files "*.ttl"
    // |> Array.Parallel.filter (fun file_path -> not (file_path.Contains(fibo_substring) ))
    |> Array.Parallel.iter (fun ttl_file_path -> 
        let ttl_file = PathInfo.from_string ttl_file_path
        let vocabulary_name = Iri_Reference(ttl_file.path) |> IRIREF
        in_memory_dataset.HasGraph(vocabulary_name.vds_node) |> ignore
        )
    let graph = new ThreadSafeGraph()
    graph.Assert(in_memory_dataset.Triples) |> ignore
    graph
// let reasoner = RdfsReasoner()
// reasoner.Apply(default_graph)


let iris = 
    default_graph.AllNodes
    |> PSeq.choose (fun vds_node -> 
        if vds_node.NodeType = NodeType.Uri then 
            Some (vds_node :?> UriNode |> Iri.from_vds_node)
        else 
            None
        
        )
    |> PSeq.distinctBy (fun iri -> iri.nt)
    |> PSeq.sortBy (fun iri -> iri.lexical_form)
    |> Seq.toArray
    |> Array.rev
    
iris.Length
let prefix_id'iri = 
    iris
    |> Array.Parallel.choose (fun iri -> 
            let maybe_prefix_id = 
                prefix_registry.prefix_ids 
                |> Array.sortBy (fun prefix_id -> prefix_id.namespace_name)
                |> Array.rev
                |> Array.tryFind (fun prefix_id -> iri.lexical_form.StartsWith(prefix_id.namespace_name))
            match maybe_prefix_id with 
            | None -> None
            | Some prefix_id -> Some(prefix_id,iri)
    )
    |> Array.groupBy (fun (prefix_id,iri) -> prefix_id)
    |> Array.map (fun (prefix_id,group) -> prefix_id,group |> Array.map (fun (_,iri) -> iri))



let iri'prefix_id = 
    iris
    |> Array.Parallel.choose (fun iri -> 
    
            let maybe_prefix_id = 
                prefix_registry.prefix_ids 
                |> Array.sortBy (fun prefix_id -> prefix_id.namespace_name)
                |> Array.rev
                |> Array.tryFind (fun prefix_id -> iri.lexical_form.StartsWith(prefix_id.namespace_name))
            match maybe_prefix_id with 
            | None -> None
            | Some prefix_id -> 
                let describe_graph = 
                    sparql.describe [iri] {
                    from default_graph
                    } |> RDF_Graph.from_vds_graph
                
                let describe_triples = 
                    describe_graph.triples
                    |> Seq.toArray

                Some(iri,prefix_id,describe_triples)
    
    )

    // |> Array.groupBy (fun (iri,prefix_id) -> prefix_id.namespace_name)

// TODO add lexical form to subject predicate object!!


type Vocabulary_Term = 
    {
        iri:Iri
        rdf_types: Iri array
        rdfs_comments: RDF_Literal array
        rdfs_labels: RDF_Literal array
    }
type Vocabulary = 
    {
        prefix_id:Prefix_ID
        vocabulary_terms: Vocabulary_Term array
    }

let rdf_vocabularies = 
    iri'prefix_id
    |> Array.Parallel.groupBy (fun (iri,prefix_id,describe_triples) -> prefix_id)
    |> Array.Parallel.map (fun (prefix_id, grouped) -> 
        let vocabulary_terms = 
            grouped |> Array.Parallel.map (fun (iri,prefix_id,describe_triples) -> 
            let rdf_types = 
                describe_triples |> Array.choose (fun triple -> 
                    match triple.curPredicate with 
                    | IriPredicate rdf_type when rdf_type.lexical_form = "http://www.w3.org/1999/02/22-rdf-syntax-ns#type" -> 
                        Some(triple.curObject)
                    | _ -> None
                    )
                    |> Array.choose (fun rdf_type_object -> 
                        match rdf_type_object with 
                        | IriObject rdf_type -> Some rdf_type
                        | _ -> None
                        )
                    |> Array.distinctBy (fun iri -> iri.nt)
                    |> Array.filter (fun iri -> iri.curie <> "owl:Restriction")
            let rdfs_comments = 
                describe_triples |> Array.choose (fun triple -> 
                    match triple.curPredicate with 
                    | IriPredicate rdfs_comment when rdfs_comment.lexical_form = "http://www.w3.org/2000/01/rdf-schema#comment" -> 
                        Some(triple.curObject)
                    | _ -> None
                )
                |> Array.choose (fun rdfs_comment_object -> 
                        match rdfs_comment_object with 
                        | LiteralObject rdfs_comment -> Some rdfs_comment
                        | _ -> None
                        )
                |> Array.distinctBy (fun literal -> literal.nt)
            let rdfs_labels = 
                describe_triples |> Array.choose (fun triple -> 
                    match triple.curPredicate with 
                    | IriPredicate rdfs_label when rdfs_label.lexical_form = "http://www.w3.org/2000/01/rdf-schema#label" -> 
                        Some(triple.curObject)
                    | _ -> None
                )
                |> Array.choose (fun rdfs_label_object -> 
                        match rdfs_label_object with 
                        | LiteralObject rdfs_label -> Some rdfs_label
                        | _ -> None
                        )

                |> Array.distinctBy (fun literal -> literal.nt)

                
            {
                iri = iri
                rdf_types = rdf_types
                rdfs_comments = rdfs_comments
                rdfs_labels = rdfs_labels
            }
                )
        {
            prefix_id = prefix_id
            vocabulary_terms = vocabulary_terms
        }

                
                
                )






let foaf_Person = 
    rdf_vocabularies
    |> Array.choose (fun vocabulary ->  
        vocabulary.vocabulary_terms |> Array.tryFind (fun vocabulary_term -> vocabulary_term.iri.lexical_form = "http://xmlns.com/foaf/0.1/Person" ))
        |> Array.exactlyOne




foaf_Person.rdf_types
    |> Array.iter (fun rdf_type -> printfn "%s" rdf_type.curie)









module IriDocs = 
    open Xml_Documentation_Comments
    let xmldoc (vocabulary_term:Vocabulary_Term)=
        try
            [|
                summary {
                    if vocabulary_term.iri.curie <> vocabulary_term.iri.lexical_form then 
                        para { vocabulary_term.iri.curie }
                    "\n"
                    }

                remarks {
                    for rdf_type in vocabulary_term.rdf_types do 
                        para { rdf_type.curie }
                    "\n"
                    for comment in vocabulary_term.rdfs_comments do
                        para { comment.nt }
                    "\n"
                    if vocabulary_term.rdfs_labels.Length > 0 then
                        "labels"
                        for label in vocabulary_term.rdfs_labels do
                            para { label.nt }
                    "\n"
                    }
                seealso { 
                        FSharp.ViewEngine.Html._href vocabulary_term.iri.lexical_form 
                        vocabulary_term.iri.lexical_form
                        }

            |]
            |> Array.collect (fun htmlelement -> 
                htmlelement
                        |> Render.toXElement
                        |> fun xelement -> xelement.ToString()
                        |> fun xelement_string -> xelement_string.Split("\n")

            
                )
        with
        | err -> 
            error_lines.Add(sprintf "xmldoc for vocabulary_term %A failed with %s" vocabulary_term err.Message)
            [||]




rdf_vocabularies
|> Array.Parallel.filter (fun rdf_vocabulary -> rdf_vocabulary.prefix_id.namespace_name <> "http://www.w3.org/")
|> Array.Parallel.map (fun rdf_vocabulary -> 
            let fs_file = Folder.Generated ./ $"{rdf_vocabulary.prefix_id.namespace_prefix}.fs"
            if should_overwrite || fs_file.does_NOT_exist then 

                let fs_text =
                    Oak() {
                    Namespace(rdfsharp_namespace rdf_vocabulary.prefix_id.namespace_name) {
                        Open("DoxAletheia")
                        Open("DotNetRDFSharp")
                        OpenType("Prefix_ID")
                        Module(rdf_vocabulary.prefix_id.namespace_prefix.normalize_identifier){
                            Value("_namespace_iri",$"Namespace_Iri {rdf_vocabulary.prefix_id.namespace_prefix.normalize_identifier} |> NamespaceIRI")
                            let mutable iri_index = 0

                            for vocabulary_term in rdf_vocabulary.vocabulary_terms do
                                iri_index <- iri_index + 1
                                printfn "%s\t\t%d of %d"   rdf_vocabulary.prefix_id.namespace_name iri_index rdf_vocabulary.vocabulary_terms.Length 

                                let local_name = vocabulary_term.iri.lexical_form[rdf_vocabulary.prefix_id.namespace_name.Length..]
                                let identifier = 
                                    let temp_identifier =
                                        match rdf_vocabulary.prefix_id.namespace_name with 
                                        | namespace_name when namespace_name.StartsWith("http://purl.obolibrary.org/obo") && vocabulary_term.rdfs_labels.Length > 0 && vocabulary_term.rdfs_labels[0].lexical_form <> local_name  -> sprintf "%s'%s" vocabulary_term.rdfs_labels[0].lexical_form local_name
                                        | _ when String.IsNullOrEmpty local_name -> "_prefix_iri"
                                        | _ -> local_name
                                    if temp_identifier = rdf_vocabulary.prefix_id.namespace_prefix then 
                                        temp_identifier + "_"
                                    else 
                                        temp_identifier


                                Value(identifier.normalize_identifier, $"Prefixed_Name({rdf_vocabulary.prefix_id.namespace_prefix.normalize_identifier}, \"{local_name}\") |> PrefixedName")
                                |> _.xmlDocs( IriDocs.xmldoc vocabulary_term)


                        }

                        }
                    }
                    |> Gen.mkOak
                    |> Gen.run
            
                fs_file.save_file_text fs_text

)


File.WriteAllLines(Path.Combine(__SOURCE_DIRECTORY__, "error_lines.txt"), error_lines)



























(*




let subject_variable = !? "subject"

let rdf_class_varible = !? "rdf_class"
let rdf_class_pattern =  !> subject_variable --- rdf_type --> rdf_class_varible


let comment_varible = !? "comment"
let comment_pattern =  !> subject_variable --- rdfscomment --> comment_varible

let label_variable = !? "label"
let label_pattern =  !> subject_variable --- rdfslabel --> label_variable




let graph_files = 
    Folder.Vocabulary.descendant_files "*.ttl"
    |> Array.filter (fun file_path -> not (file_path.Contains(fibo_substring) ))
let ttl_files = 
    Folder.Vocabulary.descendant_files "*.ttl"
    |> Array.Parallel.filter (fun file_path -> not (file_path.Contains(fibo_substring) ))
    |> Array.Parallel.map (fun ttl_file_path -> PathInfo.from_string ttl_file_path)
let ttl_file'prefix_id = 
    ttl_files
    |> Array.choose (fun ttl_file -> 
            let namespace_name = 
                match ttl_file.parent_directory.FullName[Folder.Vocabulary.path.Length+1..] |> relative_path_to_iri with 
                // | namespace_name when namespace_name.StartsWith("http://purl.org/NET") -> namespace_name.ToLowerInvariant()
                | namespace_name -> namespace_name
            match prefix_map.TryFind namespace_name with 
            | Some prefix_id -> Some(ttl_file,prefix_id)
            | None -> 
                error_lines.Add(sprintf "couldn't find prefix id for %s" namespace_name)
                None

    )




let ttl_file'prefix_id'vocabulary_name = 
    ttl_file'prefix_id
    |> Array.choose (fun  (ttl_file,prefix_id) -> 
            let vocabulary_name = Iri_Reference(ttl_file.path) |> IRIREF
            match in_memory_dataset.HasGraph(vocabulary_name.vds_node) with 
            | true -> Some(ttl_file, prefix_id,vocabulary_name)
            | false -> 
                error_lines.Add(sprintf "couldn't load graph for %s" prefix_id.namespace_name)
                None

    )
let ttl_file'prefix_id'vocabulary_name'vocabulary_vds_graph'vocabulary_iris = 
    ttl_file'prefix_id'vocabulary_name
    |> Array.choose (fun (ttl_file, prefix_id,vocabulary_name) -> 
    let vocabulary_vds_graph = in_memory_dataset[vocabulary_name.vds_node]
    let iris =
        vocabulary_vds_graph.AllNodes
        |> PSeq.filter (fun node -> node.NodeType = NodeType.Uri)
        |> PSeq.map (fun node -> node.ToString())
        |> PSeq.filter (fun iri_string -> iri_string.StartsWith(prefix_id.namespace_name))
        |> PSeq.map (fun iri_string -> 
            Prefixed_Name(prefix_id,iri_string[prefix_id.namespace_name.Length..])  |> PrefixedName
        )
        |> PSeq.toArray

    printfn "found %d iris in namespace_name %s" iris.Length prefix_id.namespace_name
    if iris.Length > 0 then 
        Some (ttl_file, prefix_id,vocabulary_name,vocabulary_vds_graph,iris)
        else
            None

    )

let ttl_file'prefix_id'vocabulary_name'vocabulary_vds_graph'vocabulary_iris'vocabulary_classes'vocabulary_comments'vocabulary_labels = 
    ttl_file'prefix_id'vocabulary_name'vocabulary_vds_graph'vocabulary_iris
    |> Array.map (fun (ttl_file, prefix_id,vocabulary_name,vocabulary_vds_graph,iris) -> 
    
    
    let rdf_class_graph =
        sparql.construct rdf_class_pattern {
            where rdf_class_pattern
            from vocabulary_vds_graph
        } |> RDF_Graph.from_vds_graph
    let vocabulary_classes = 
        rdf_class_graph.triples
        |> Array.ofSeq
        |> Array.choose (fun triple -> 
            if triple.curSubject.IsIriSubject && triple.curObject.IsIriObject then
                let (IriSubject iri) = triple.curSubject
                let (IriObject rdf_class) = triple.curObject
                Some(iri.lexical_form,rdf_class)
            else
                None
        )
        |> Array.filter (fun (iri,rdf_class) -> iri.StartsWith(prefix_id.namespace_name))
    let comment_graph =
                sparql.construct comment_pattern {
                    where comment_pattern
                    from vocabulary_vds_graph
                } |> RDF_Graph.from_vds_graph

    let vocabulary_comments = 
            comment_graph.triples
            |> Array.ofSeq
            |> Array.choose (fun triple -> 
                if triple.curSubject.IsIriSubject && triple.curObject.IsLiteralObject then
                    let (IriSubject iri) = triple.curSubject
                    let (LiteralObject literal) = triple.curObject
                    Some(iri.lexical_form,literal.lexical_form)
                else
                    None
            )
            |> Array.filter (fun (iri,literal) -> iri.StartsWith(prefix_id.namespace_name))




    let label_graph =
        sparql.construct label_pattern {
            where label_pattern
            from vocabulary_vds_graph
        } |> RDF_Graph.from_vds_graph
    let vocabulary_labels = 
        label_graph.triples
        |> Array.ofSeq
        |> Array.choose (fun triple -> 
            if triple.curSubject.IsIriSubject && triple.curObject.IsLiteralObject then
                let (IriSubject iri) = triple.curSubject
                let (LiteralObject literal) = triple.curObject
                Some(iri.lexical_form,literal.lexical_form)
            else
                None
        )
        |> Array.filter (fun (iri,literal) -> iri.StartsWith(prefix_id.namespace_name))
    (ttl_file, prefix_id,vocabulary_name,vocabulary_vds_graph,iris,vocabulary_classes,vocabulary_comments,vocabulary_labels)
    
    )



let foaf_Person_metadata =  
    ttl_file'prefix_id'vocabulary_name'vocabulary_vds_graph'vocabulary_iris'vocabulary_classes'vocabulary_comments'vocabulary_labels
    |> Array.Parallel.choose (fun (ttl_file, prefix_id,vocabulary_name,vocabulary_vds_graph,iris,vocabulary_classes,vocabulary_comments,vocabulary_labels) -> 
        let iri = iris  |> Array.tryFind(fun iri -> iri.lexical_form = "http://xmlns.com/foaf/0.1/Person")
        let maybe_vocabulary_class = vocabulary_classes  |> Array.tryFind(fun (form, iri) -> form = "http://xmlns.com/foaf/0.1/Person")
        match maybe_vocabulary_class with 
        | Some(_,vocabulary_class) ->

            Some (
                sparql.describe [vocabulary_class] {
                from default_graph
                } 
            
            )
        | None -> None
    )
let vds_metadata_graph = foaf_Person_metadata[0]
let vds_triples = 
    vds_metadata_graph.GetTriplesWithSubject(new Uri("http://www.w3.org/2000/01/rdf-schema#Class"))
    |> Seq.toArray
let metadata_graph = 
    vds_metadata_graph
    |> RDF_Graph.from_vds_graph
let metadata_triples = 
    metadata_graph.triples
    |> Seq.toArray
    //|> Array.iter (fun triple -> printfn "%s %s %s . " triple.curSubject.curie triple.curPredicate.curie triple.curObject.curie)


(*

    |> Array.mapi (fun file_index file_path -> 
        let graph_file =  PathInfo.from_string file_path

        let namespace_name = 
            match graph_file.parent_directory.FullName[Folder.Vocabulary.path.Length+1..] |> relative_path_to_iri with 
            // | namespace_name when namespace_name.StartsWith("http://purl.org/NET") -> namespace_name.ToLowerInvariant()
            | namespace_name -> namespace_name
        printfn "file_path %s has namespace_name %s" file_path namespace_name
        match prefix_map.TryFind namespace_name with 
        | None -> error_lines.Add(sprintf "couldn't find prefix id for %s" namespace_name)
        | Some prefix_id ->
            let graph_name = Iri_Reference(graph_file.path) |> IRIREF
            match in_memory_dataset.HasGraph(graph_name.vds_node) with 
            | false -> error_lines.Add(sprintf "couldn't load graph for %s" namespace_name)
            | true ->

                let test_graph = in_memory_dataset[graph_name.vds_node]


                let iris =
                    test_graph.AllNodes
                    |> PSeq.filter (fun node -> node.NodeType = NodeType.Uri)
                    |> PSeq.map (fun node -> node.ToString())
                    |> PSeq.filter (fun iri_string -> iri_string.StartsWith(prefix_id.namespace_name))
                    |> PSeq.map (fun iri_string -> 
                        Prefixed_Name(prefix_id,iri_string[prefix_id.namespace_name.Length..])  |> PrefixedName
                    )
                    |> PSeq.toArray

                printfn "found %d iris in namespace_name %s" iris.Length namespace_name


                let subject_variable = !? "subject"

                let rdf_class_varible = !? "rdf_class"
                let rdf_class_pattern =  !> subject_variable --- rdf_type --> rdf_class_varible
                let rdf_class_graph =
                    sparql.construct rdf_class_pattern {
                        where rdf_class_pattern
                        from test_graph
                    } |> RDF_Graph.from_vds_graph

                rdf_class_graph.triples
                |> Array.ofSeq
                |> Array.choose (fun triple -> 
                    if triple.curSubject.IsIriSubject && triple.curObject.IsIriObject then
                        let (IriSubject iri) = triple.curSubject
                        let (IriObject rdf_class) = triple.curObject
                        Some(iri.lexical_form,rdf_class)
                    else
                        None
                )
                |> Array.filter (fun (iri,rdf_class) -> iri.StartsWith(prefix_id.namespace_name))
    )

*)





























    

graph_files
|> Array.iteri (fun file_index file_path -> 
    printfn "found file_path %s" file_path
    let graph_file =  PathInfo.from_string file_path

    let namespace_name = 
        match graph_file.parent_directory.FullName[Folder.Vocabulary.path.Length+1..] |> relative_path_to_iri with 
        // | namespace_name when namespace_name.StartsWith("http://purl.org/NET") -> namespace_name.ToLowerInvariant()
        | namespace_name -> namespace_name
    printfn "file_path %s has namespace_name %s" file_path namespace_name
    match prefix_map.TryFind namespace_name with 
    | None -> error_lines.Add(sprintf "couldn't find prefix id for %s" namespace_name)
    | Some prefix_id ->
        let graph_name = Iri_Reference(graph_file.path) |> IRIREF
        match in_memory_dataset.HasGraph(graph_name.vds_node) with 
        | false -> error_lines.Add(sprintf "couldn't load graph for %s" namespace_name)
        | true ->

            let test_graph = in_memory_dataset[graph_name.vds_node]


            let iris =
                test_graph.AllNodes
                |> PSeq.filter (fun node -> node.NodeType = NodeType.Uri)
                |> PSeq.map (fun node -> node.ToString())
                |> PSeq.filter (fun iri_string -> iri_string.StartsWith(prefix_id.namespace_name))
                |> PSeq.map (fun iri_string -> 
                    Prefixed_Name(prefix_id,iri_string[prefix_id.namespace_name.Length..])  |> PrefixedName
                )
                |> PSeq.toArray

            printfn "found %d iris in namespace_name %s" iris.Length namespace_name


            let subject_variable = !? "subject"

            let rdf_class_varible = !? "rdf_class"
            let rdf_class_pattern =  !> subject_variable --- rdf_type --> rdf_class_varible
            let rdf_class_graph =
                sparql.construct rdf_class_pattern {
                    where rdf_class_pattern
                    from test_graph
                } |> RDF_Graph.from_vds_graph

            let rdf_classes = 
                rdf_class_graph.triples
                |> Array.ofSeq
                |> Array.choose (fun triple -> 
                    if triple.curSubject.IsIriSubject && triple.curObject.IsIriObject then
                        let (IriSubject iri) = triple.curSubject
                        let (IriObject rdf_class) = triple.curObject
                        Some(iri.lexical_form,rdf_class)
                    else
                        None
                )
                |> Array.filter (fun (iri,rdf_class) -> iri.StartsWith(prefix_id.namespace_name))


            let comment_varible = !? "comment"
            let comment_pattern =  !> subject_variable --- rdfscomment --> comment_varible
            let comment_graph =
                sparql.construct comment_pattern {
                    where comment_pattern
                    from test_graph
                } |> RDF_Graph.from_vds_graph

            let comments = 
                comment_graph.triples
                |> Array.ofSeq
                |> Array.choose (fun triple -> 
                    if triple.curSubject.IsIriSubject && triple.curObject.IsLiteralObject then
                        let (IriSubject iri) = triple.curSubject
                        let (LiteralObject literal) = triple.curObject
                        Some(iri.lexical_form,literal.lexical_form)
                    else
                        None
                )
                |> Array.filter (fun (iri,literal) -> iri.StartsWith(prefix_id.namespace_name))




            let label_variable = !? "label"
            let label_pattern =  !> subject_variable --- rdfslabel --> label_variable
            let label_graph =
                sparql.construct label_pattern {
                    where label_pattern
                    from test_graph
                } |> RDF_Graph.from_vds_graph
            let labels = 
                label_graph.triples
                |> Array.ofSeq
                |> Array.choose (fun triple -> 
                    if triple.curSubject.IsIriSubject && triple.curObject.IsLiteralObject then
                        let (IriSubject iri) = triple.curSubject
                        let (LiteralObject literal) = triple.curObject
                        Some(iri.lexical_form,literal.lexical_form)
                    else
                        None
                )
                |> Array.filter (fun (iri,literal) -> iri.StartsWith(prefix_id.namespace_name))

            //try 
            let fs_file = Folder.Generated ./ $"{prefix_id.namespace_prefix}.fs"
            if should_overwrite || fs_file.does_NOT_exist then 

                let fs_text =
                    Oak() {
                    Namespace(rdfsharp_namespace prefix_id.namespace_name) {
                        Open("DoxAletheia")
                        Open("DotNetRDFSharp")
                        OpenType("Prefix_ID")
                        Module(prefix_id.namespace_prefix.normalize_identifier){
                            Value("_namespace_iri",$"Namespace_Iri {prefix_id.namespace_prefix.normalize_identifier} |> NamespaceIRI")
                            let mutable iri_index = 0

                            for iri in iris do
                                iri_index <- iri_index + 1
                                printfn "file# %d of %d %s\t\t#%d of %d"  file_index graph_files.Length prefix_id.namespace_name iri_index iris.Length 
                                let iri_classes = 
                                    rdf_classes
                                    |> Array.choose (fun (iri_subject,rdf_class) -> 
                                        if iri_subject = iri.lexical_form then 
                                            Some rdf_class
                                        else
                                            None
                                            )
                                let iri_comments = 
                                    comments
                                    |> Array.choose (fun (iri_subject,comment) -> 
                                        if iri_subject = iri.lexical_form then 
                                            Some comment
                                        else
                                            None
                                            )
                                let iri_labels = 
                                    labels
                                    |> Array.choose (fun (iri_subject,label) -> 
                                        if iri_subject = iri.lexical_form then 
                                            Some label
                                        else
                                            None
                                            )
                                    |> Array.sortBy (fun label -> label.Length)
                                    |> Array.rev

                                let local_name = iri.lexical_form[prefix_id.namespace_name.Length..]
                                let identifier = 
                                    let temp_identifier =
                                        match prefix_id.namespace_name with 
                                        | namespace_name when namespace_name.StartsWith("http://purl.obolibrary.org/obo") && iri_labels.Length > 0 -> iri_labels[0]
                                        | _ when String.IsNullOrEmpty local_name -> "_prefix_iri"
                                        | _ -> local_name
                                    if temp_identifier = prefix_id.namespace_prefix then 
                                        temp_identifier + "_"
                                    else 
                                        temp_identifier


                                Value(identifier.normalize_identifier, $"Prefixed_Name({prefix_id.namespace_prefix.normalize_identifier}, \"{local_name}\") |> PrefixedName")
                                |> _.xmlDocs( IriDocs.xmldoc iri_classes iri_comments iri_labels iri )


                        }

                        }
                    }
                    |> Gen.mkOak
                    |> Gen.run
            
                fs_file.save_file_text fs_text

            // with
            // | err -> error_lines.Add(sprintf "%s fs_text errored with %s" prefix_id.namespace_name  err.Message)
        )

File.WriteAllLines(Path.Combine(__SOURCE_DIRECTORY__, "error_lines.txt"), error_lines)


*)
