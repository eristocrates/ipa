module DoxAletheia.Namespace_Prefixes


open System
open System.IO
open System.Net.Http
open System.IO.Compression
open System.Text.RegularExpressions



open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF.Query.Datasets
open VDS.RDF.Storage
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Writing

open FsHttp
open FSharp.Data
open FSharp.Json
open Swensen.Unquote.Assertions


open Fabulous.AST
open Fantomas.Core.SyntaxOak
open type Fabulous.AST.Ast


open Rdf_Distribution.Single
open Rdf_Distribution.Multi

open IOExtensions
open ArrayErgonomics

open RdfExtensions
open Manual_Prefixes
open PrettierNaming
open PrettierNaming.FSharp_Keywords
open XmlErgonomics



let should_overwrite = false

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


let DoxAletheia_directory =
    Directory.CreateDirectory(
        @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia"
    )



let Vocabulary_directory = DoxAletheia_directory.CreateChildDirectory "Vocabulary"
let https_directory = Vocabulary_directory.CreateChildDirectory "https"


let manual_namespace_names_with_multiple_distributions =
    manual_distributions
    |> Array.Parallel.groupBy (fun (namespace_name, namespace_distribution) -> namespace_name)
    |> Array.Parallel.filter (fun (namespace_name, distributions) -> distributions.Length > 1)

test <@ manual_namespace_names_with_multiple_distributions.Length = 0 @>









module fibo =
    // TODO deal with quarter and release later
    [<RequireQualifiedAccess>]
    type Release_Kind =
        | prod
        | dev

    let directory =
        Vocabulary_directory.CreateChildDirectory @"https\spec.edmcouncil.org"

    let download_link =
        "https://spec.edmcouncil.org/fibo/ontology/master/2026Q1/prod.ttl.zip"

    let path_segments =
        (iri_to_relative_path download_link)
            .Replace("\\bare", "")
            .Split("\\")

    let file_name = path_segments |> Array.last

    let relative_directory_path =
        $"{path_segments[0]}//"
        + (path_segments
           |> Array.string_slice 1 -1
           |> String.concat "\\")

    let zip_directory =
        Vocabulary_directory.CreateChildDirectory relative_directory_path




    let zip_file = zip_directory.CreateChildFile file_name

    let zip () =
        http {

            GET download_link

        }
        |> Request.send

    let refresh () =
        let response = zip ()

        if response.originalHttpResponseMessage.IsSuccessStatusCode then
            Response.saveFile zip_file.FullName response
            ZipFile.ExtractToDirectory(zip_file.FullName, directory.FullName)

    let vocabulary_files =
        Directory.GetFiles(directory.FullName, "*.ttl", SearchOption.AllDirectories)

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
        |> Array.distinct

    let content =
        vocabulary_files
        |> Array.Parallel.choose (fun ttl_path ->
            let file_stem = Path.GetFileNameWithoutExtension ttl_path

            let type_binding =
                match file_stem with
                | prefix when reserved_keywords.Contains(prefix) -> $"{prefix}_"
                | _ -> file_stem.Replace('-', '_').Replace('.', '_')

            let from_index = https_directory.FullName.Length + 1

            let to_index =
                ttl_path.ToCharArray()
                |> Array.reversible_index -4

            let subpath =
                ttl_path[from_index..to_index]
                    .Replace("\\", "/")
                    .Replace("/master/2026Q1", "")

            let reconstructed_namespace = $"https://{subpath}/"

            let maybe_namespace_prefix =
                namespaces_from_files
                |> Array.Parallel.tryFind (fun (namespace_name, prefix_label) ->
                    namespace_name = reconstructed_namespace

                )

            match maybe_namespace_prefix with
            | Some (namespace_name, prefix_label) -> Some(namespace_name, ttl_path)
            | None -> None)

    test <@ vocabulary_files.Length = content.Length @>


(*


fibo.vocabulary_files
|> String.concat "\n"
|> clip


fibo.namespaces_from_files
|> Array.map (fun (namespace_name,prefix_label) -> $"\"{namespace_name}\",\"{prefix_label}\"")
|> String.concat "\n"
|> clip

*)
// fibo.refresh()
// namespace_name, ttl_path



module prefixcc =
    [<Literal>]
    let filePath =
        @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\prefix.cc.json"

    let json = JsonProvider<filePath>.Load filePath


module lov =
    type Meta = { last_meta: DateTimeOffset }

    let v2Base = "https://lov.linkeddata.es/dataset/lov/api/v2"

    let excluded_graph_names =
        set [

              "http://lov_server:3333/dataset/lov"

               ]

    module vocabulary =
        [<Literal>]
        let filePath =
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.vocabulary.json"

        let json = JsonProvider<filePath>.Load filePath

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
                let response = gz ()

                if response.originalHttpResponseMessage.IsSuccessStatusCode then
                    Response.saveFile gz_path response
                    decompress_gzip_file gz_path file_path
                    let last_meta = { last_meta = DateTimeOffset.Now }
                    let meta_file_content = Json.serialize last_meta
                    File.WriteAllText(meta_file_path, meta_file_content)

            let json = JsonProvider<meta_file_path>.Load meta_file_path

            if json.LastMeta.Date < DateTime.Now.Date then
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
                let response = gz ()

                if response.originalHttpResponseMessage.IsSuccessStatusCode then
                    Response.saveFile gz_path response
                    decompress_gzip_file gz_path file_path
                    normalize_nquads_file file_path normalized_path
                    write_valid_nquads_only normalized_path cleaned_path
                    let last_meta = { last_meta = DateTimeOffset.Now }
                    let meta_file_content = Json.serialize last_meta
                    File.WriteAllText(meta_file_path, meta_file_content)

            let json = JsonProvider<meta_file_path>.Load meta_file_path

            if json.LastMeta.Date < DateTime.Now.Date then
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



let namespace_directory_path_from_namespace_name namespace_name = Vocabulary_directory.CreateChildDirectory(iri_to_relative_path namespace_name)
    




let is_terminal_delimited (iri_string: string) =
    iri_string.EndsWith('#')
    || iri_string.EndsWith('/')

let is_not_terminal_delimited (iri_string: string) =
    not (iri_string |> is_terminal_delimited)


let absolute_graph_names =
    lov.dump.nq.graph_names
    |> Array.Parallel.filter (fun graph_name -> graph_name |> is_not_terminal_delimited)









let graph_namespace_name_prefixes =
    let graph_names =
        lov.dump.nq.graph_names
        |> Array.Parallel.filter (fun graph_name -> graph_name |> is_terminal_delimited)
        |> Array.Parallel.map (fun graph_name -> graph_name, graph_name)

    let preferred_namespaces =
        absolute_graph_names
        |> Array.Parallel.map (fun graph_name ->

            graph_name,
            lov.dump.n3.vocabulary'preferredNamespaceUri
            |> Array.pick (fun (vocabulary, preferred_namespace) ->

                if vocabulary.Uri.OriginalString = graph_name then
                    Some preferred_namespace.Value
                else
                    None)

        )

    Array.concat [|

                    graph_names
                    preferred_namespaces

                     |]
    |> Array.Parallel.map (fun (graph_name, namespace_name) ->

        lov.dump.n3.vocabulary'preferredNamespaceUri'preferredNamespacePrefixes
        |> Array.pick (fun (vocabulary, preferred_namespace, preferred_prefix) ->

            if vocabulary.Uri.OriginalString = graph_name then
                Some(graph_name, preferred_namespace.Value, preferred_prefix.Value)
            else
                None


        )


    )



let lov_prefixes =
    lov.vocabulary.json
    |> Array.Parallel.map (fun vocabulary -> vocabulary.Nsp, vocabulary.Prefix)

let prefixcc_prefixes =
    prefixcc.json.JsonValue.Properties()
    |> Array.Parallel.map (fun (jsonKey, jsonValue) -> jsonValue.AsString(), jsonKey)

let all_prefixes() =
    Array.concat [|

                    lov_prefixes
                    prefixcc_prefixes

                     |]
    |> Array.distinct
    |> Array.sortBy (fun (namespace_name, preferred_prefix) -> namespace_name)

let all_prefix_groupings =
    all_prefixes()
    |> Array.Parallel.groupBy (fun (namespace_name, preferred_prefix) -> namespace_name)




let singular_prefix_namespaces =
    all_prefix_groupings
    |> Array.Parallel.filter (fun (namespace_name, prefix_groupings) -> prefix_groupings.Length = 1)


let multiple_prefix_namespaces =
    all_prefix_groupings
    |> Array.Parallel.filter (fun (namespace_name, prefix_groupings) -> prefix_groupings.Length > 1)
    |> Array.Parallel.map (fun (namespace_name, prefix_groupings) ->
        let prefixes =
            prefix_groupings
            |> Array.Parallel.map (fun (namespace_name, preferred_prefix) -> preferred_prefix)
            |> Array.Parallel.sortBy (fun prefix -> prefix.Length)
            |> Array.distinct
            |> Array.rev

        namespace_name, prefixes

    )
    |> Array.Parallel.sortBy (fun (namespace_name, prefixes) -> prefixes.Length)
    |> Array.rev





let singular_match_content =
    singular_prefix_namespaces
    |> Array.sortBy (fun (namespace_name, preferred_prefix) -> namespace_name)
    |> Array.collect (fun (namespace_name, prefix_groupings) ->
        prefix_groupings
        |> Array.map (fun (namespace_name, preferred_prefix) ->
            let prefix_match =
                match namespace_name with
                | "http://www.loc.gov/premis/rdf/v1#" -> "premisv1"
                | "http://www.lexinfo.net/ontology/2.0/lexinfo#" -> "lexinfov2"
                | "http://spdx.org/rdf/terms#" -> "spdxv1"
                | "http://purl.org/swan/1.2/discourse-elements/" -> "swandev1_2"
                | "http://ns.ottr.xyz/templates#" -> "ottr_tpl"
                | "http://www.ontologyrepository.com/CommonCoreOntologies/" -> "comcore"
                | "http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#" -> "obs"
                | "http://opendata.caceres.es/def/ontomunicipio#" -> "ontomun"

                | _ when namespace_name.Contains('.') -> preferred_prefix.Replace('.', '_')
                | _ -> preferred_prefix
            Some (namespace_name,prefix_match)

        )

    )

let targeted_match target_prefix namespace_name preferred_prefix =
    if preferred_prefix = target_prefix then
        Some(namespace_name,preferred_prefix)
    else
        None

let multiple_match_content =
    multiple_prefix_namespaces
    |> Array.sortBy (fun (namespace_name, preferred_prefix) -> namespace_name)
    |> Array.collect (fun (namespace_name, prefixes) ->
        prefixes
        |> Array.mapi (fun index preferred_prefix ->
            match namespace_name with
            | "http://www.w3.org/ns/dcat#" -> targeted_match "dcat" namespace_name preferred_prefix
            | "http://www.w3.org/2001/XMLSchema#" -> targeted_match "xsd" namespace_name preferred_prefix
            | "http://www.w3.org/2011/http#" -> targeted_match "http" namespace_name preferred_prefix
            | "http://www.w3.org/XML/1998/namespace/" -> targeted_match "xml" namespace_name preferred_prefix
            | "http://www.w3.org/ns/pim/space#" -> targeted_match "pim" namespace_name preferred_prefix
            | "http://www.w3.org/ns/prov#" -> targeted_match "prov" namespace_name preferred_prefix
            | _ ->
                if index = 0 then
                    Some(namespace_name,preferred_prefix)
                else
                    None

        )

    )

let manual_namespace_names =
    Array.concat [|

                    manual_distributions
                    |> Array.map (fun (namespace_name, _) -> namespace_name)
                    multipart_distributions
                    |> Array.map (fun (namespace_name, _) -> namespace_name) |]

(*


let unmatched_namespaces =
    manual_namespace_names
    |> Array.Parallel.choose (fun namespace_name ->

        let namespace_exists =
            global_prefix_declarations
            |> Array.exists (fun (global_namespace, global_prefix) -> namespace_name = global_namespace)
        if namespace_exists then
            None
        else
            Some namespace_name

    )
    *)
type Prefix_Map = 
    {
        namespace_name:string
        prefix_label:string
    }
type Namespace_Prefixes  =
    {
        mappings: Prefix_Map array
    }
let match_content =
    { mappings = 
        Array.concat [|
                    singular_match_content
                    multiple_match_content
                    manual_match_content

     
                     |]
                |> Array.choose (fun maybe_match -> maybe_match)
                |> Array.map (fun (namespace_name, prefix_label) -> { namespace_name = namespace_name ; prefix_label = prefix_label })
    }

let file_path = Path.Combine(__SOURCE_DIRECTORY__,"namespace_prefixes.json")
File.WriteAllText(file_path , Json.serialize match_content)
