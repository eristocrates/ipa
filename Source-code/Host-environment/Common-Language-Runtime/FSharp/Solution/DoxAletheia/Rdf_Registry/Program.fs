module DoxAletheia.Rdf_Registry


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
open Namespace_Prefixes
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

let all_prefixes =
    Array.concat [|

                    lov_prefixes
                    prefixcc_prefixes

                     |]
    |> Array.distinct
    |> Array.sortBy (fun (namespace_name, preferred_prefix) -> namespace_name)

let all_prefix_groupings =
    all_prefixes
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
            $"""    "{namespace_name}", "{prefix_match}" """

        )

    )

let targeted_match target_prefix namespace_name preferred_prefix =
    if preferred_prefix = target_prefix then
        $"""    "{namespace_name}", "{preferred_prefix}" """
    else
        $"""    // "{namespace_name}", "{preferred_prefix}" """

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
                    $"""    "{namespace_name}", "{preferred_prefix}" """
                else
                    $"""    // "{namespace_name}", "{preferred_prefix}" """

        )

    )

let manual_namespace_names =
    Array.concat [|

                    manual_distributions
                    |> Array.map (fun (namespace_name, _) -> namespace_name)
                    multipart_distributions
                    |> Array.map (fun (namespace_name, _) -> namespace_name) |]


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



let match_content =
    Array.concat [| [| "let global_prefix_declarations = [|" |]
                    singular_match_content
                    multiple_match_content
                    manual_match_content
                    [| "|]" |]

                     |]

File.WriteAllLines(@"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Namespace_Prefixes.fsx", match_content)




test <@ unmatched_namespaces.Length = 0 @>


// TODO handle the ~90 duplicate prefixes
// maybe lazy _ suffix?
let duplicate_prefixes =
    global_prefix_declarations
    |> Array.Parallel.groupBy (fun (namespace_name, prefix_label) -> prefix_label)
    |> Array.Parallel.filter (fun (prefix_label, namespace_groupings) -> namespace_groupings.Length > 1
    // test <@ namespace_groupings.Length = 1 @>
    (*
        namespace_groupings
        |> Array.Parallel.choose (fun namespace_grouping ->
        if namespace_groupings.Length > 1 then
            Some namespace_grouping
        else None
        )

        *)


    )
    |> Array.sortBy (fun (prefix_label, namespace_groupings) -> prefix_label)

// test <@ duplicate_prefixes.Length = 0 @>




let singular_namespace_prefixes =
    all_prefixes
    |> Array.Parallel.groupBy (fun (namespace_name, preferred_prefix) -> preferred_prefix)
    |> Array.Parallel.filter (fun (preferred_prefix, namespace_groupings) -> namespace_groupings.Length = 1)


let multiple_namespace_prefixes =
    all_prefixes
    |> Array.Parallel.groupBy (fun (namespace_name, preferred_prefix) -> preferred_prefix)
    |> Array.Parallel.filter (fun (preferred_prefix, namespace_groupings) -> namespace_groupings.Length > 1)
    |> Array.Parallel.map (fun (preferred_prefix, namespace_groupings) ->
        let namespaces =
            namespace_groupings
            |> Array.Parallel.map (fun (namespace_name, preferred_prefix) -> namespace_name)
            |> Array.Parallel.sort
            |> Array.distinct

        preferred_prefix, namespaces

    )
    |> Array.Parallel.sortBy (fun (preferred_prefix, namespaces) -> namespaces.Length)
    |> Array.rev

let map_prefixes (graph: IGraph) =
    global_prefix_declarations
    |> Array.Parallel.iter (fun (namespace_name, prefix_label) ->

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
            graph.NamespaceMap.AddNamespace(prefix_label, new Uri(namespace_name)))



let lov_content =
    graph_namespace_name_prefixes
    |> Array.Parallel.map (fun (graph_name, namespace_name, preferred_prefix) ->

        let namespace_directory_path =
            namespace_directory_path_from_namespace_name namespace_name

        let prefix_declaration =
            global_prefix_declarations
            |> Array.pick (fun (vocabulary, prefix) ->

                if vocabulary = namespace_name then
                    Some prefix
                else
                    None

            )

        let file_stem =
            match namespace_name with
            | "http://www.w3.org/2001/sw/hcls/ns/transmed/" -> prefix_declaration
            | _ -> preferred_prefix
        let ttl_path = namespace_directory_path.CreateChildFile $"{file_stem}.ttl"


        match File.Exists(ttl_path.FullName), should_overwrite with
        | false, _
        | true, true

         ->
            let graph = new ThreadSafeGraph()

            lov.dump.nq.dataset.LoadGraph(graph, graph_name)
            map_prefixes graph
            Console.WriteLine $"Saving {namespace_name} as {file_stem}.ttl"
            Turtle.write ttl_path.FullName graph
        | _, _ -> ()

        let type_binding =
            match file_stem with
            | prefix when reserved_keywords.Contains(prefix) -> $"{prefix}_"
            | _ -> file_stem.Replace('-', '_').Replace('.', '_')

        namespace_name, ttl_path.FullName

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













let file_stem_from_name_distribution namespace_name namespace_distribution =

    let distribution_uri = new Uri(namespace_distribution)
    let distribution_stem = distribution_uri.Segments |> Array.last

    match label_from_namespaceIriString namespace_name with
    | _ when namespace_name = "http://www.w3.org/2001/XMLSchema#" -> "xsd"
    | Some prefix_label when namespace_name <> namespace_distribution -> $"{prefix_label}-{distribution_stem}"
    | Some prefix_label -> prefix_label
    | None -> distribution_stem


let errored_namespaces = new ResizeArray<string>()


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
        errored_namespaces.Add $"HTTP failed for {distribution}: {err.Message}"
        None

let manual_content =
    manual_distributions
    |> Array.Parallel.map (fun (namespace_name, namespace_distribution) ->
        let namespace_uri = new Uri(namespace_name)
        let distribution_uri = new Uri(namespace_distribution)

        let namespace_directory_path =
            namespace_directory_path_from_namespace_name namespace_name

        let prefix_declaration =
            try
                global_prefix_declarations
                |> Array.pick (fun (vocabulary, prefix) ->

                    if vocabulary = namespace_name then
                        Some prefix
                    else
                        None

                )
            with
            | err -> failwith $"{namespace_name} {namespace_distribution} failed with error {err.Message}"

        let file_stem =
            match namespace_name with
            | "http://www.w3.org/2001/XMLSchema#" -> "xsd"
            | "http://www.w3.org/ns/dcat#" -> "dcat"
            | _ -> prefix_declaration


        let ttl_path = namespace_directory_path.CreateChildFile $"{file_stem}.ttl"



        match File.Exists(ttl_path.FullName), should_overwrite with
        | false, _
        | true, true

         ->
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

                Console.WriteLine $"Saving {namespace_name} as {file_stem}.ttl"
                map_prefixes graph
                Turtle.write ttl_path.FullName graph
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
                        Console.WriteLine $"Saving {namespace_name} as {file_stem}.ttl"
                        map_prefixes graph
                        Turtle.write ttl_path.FullName graph
                    with
                    | err -> errored_namespaces.Add $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                | _ -> errored_namespaces.Add $"No http response for {namespace_name} distribution {namespace_distribution}"
        | _, _ -> ()

        let type_binding =
            match file_stem with
            | prefix when reserved_keywords.Contains(prefix) -> $"{prefix}_"
            | _ -> file_stem.Replace('-', '_').Replace('.', '_')

        namespace_name, ttl_path.FullName

    )


let multipart_content =

    multipart_distributions
    |> Array.Parallel.map (fun (namespace_name, namespace_distributions) ->
        let ttl_paths =
            namespace_distributions
            |> Array.Parallel.map (fun namespace_distribution ->
                let namespace_uri = new Uri(namespace_name)
                let distribution_uri = new Uri(namespace_distribution)

                let namespace_directory_path =
                    namespace_directory_path_from_namespace_name namespace_name


                let file_stem =
                    let file_name =
                        file_stem_from_name_distribution namespace_name namespace_distribution
                    file_name.Replace(".ttl", "")

                let ttl_path = namespace_directory_path.CreateChildFile $"{file_stem}.ttl"



                match File.Exists(ttl_path.FullName), should_overwrite with
                | false, _
                | true, true

                 ->
                    let graph = new ThreadSafeGraph()

                    match namespace_name with
                    | _ ->
                        try
                            rdf_loader.LoadGraph(graph, distribution_uri)
                            Console.WriteLine $"Saving {namespace_name} as {file_stem}.ttl"
                            map_prefixes graph
                            Turtle.write ttl_path.FullName graph
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
                                    Console.WriteLine $"Saving {namespace_name} as {file_stem}.ttl"
                                    map_prefixes graph
                                    Turtle.write ttl_path.FullName graph

                                with
                                | err -> errored_namespaces.Add $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                            | _ -> errored_namespaces.Add $"No http response for {namespace_name} distribution {namespace_distribution}"
                    ttl_path.FullName
                | _, _ -> "")
            |> Array.filter (fun ttl_path -> ttl_path <> "")
            |> String.concat ";"

        let prefix_declaration =
            global_prefix_declarations
            |> Array.pick (fun (vocabulary, prefix) ->

                if vocabulary = namespace_name then
                    Some prefix
                else
                    None

            )
        let type_binding =
            match prefix_declaration with
            | prefix when reserved_keywords.Contains(prefix) -> $"{prefix}_"
            | _ ->
                prefix_declaration
                    .Replace('-', '_')
                    .Replace('.', '_')

        namespace_name, ttl_paths

    )









let rdfsharp_namespace (iri:string) = 
    let uri = Uri(iri)
    let terminal = 
        match iri[iri.Length - 1] with 
        | '#' -> "hash"
        | '/' -> "slash"
        | _ -> "bare"
    let segments = 
        Array.concat [|
            [|uri.Scheme|]
            (uri.Host.Split("."))
            (uri.Segments
            |> Array.collect (fun segment -> segment.Split(".")))
            [|terminal|]

        |]
    segments
            |> Array.map (fun segment -> segment.Replace("/","").Replace("-","_").Replace("~","_"))
            |> Array.filter (fun segment -> segment <> "")
            |> Array.map (fun segment -> 
                let lead = 
                    match segment with 
                    | _ when Char.IsAsciiDigit segment[0] -> "_"
                    |_ when FSharp_Keywords.keyword_names.Contains segment -> "_"
                    | _ -> ""
                lead + segment
            )
            |> String.concat "."


let generated_directory = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Rdf_Vocabulary\Generated"
let project_directory = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Rdf_Vocabulary\"

module IriDocs = 
    open Xml_Documentation_Comments
    let xmldoc (comments:string array)(iri:string) =
        let comment = comments |> String.concat "\n"
        summary {
            // printfn "\n%s\n" comment
            sprintf "\n%s\n" comment
            see { 
                FSharp.ViewEngine.Html._href iri
                }
        
        }
        |> Render.toXElement
        |> fun xelement -> xelement.ToString()
        |> fun xelement_string -> xelement_string.Split("\n")



        
// TODO keep parity with real namespace

let my_namespace = "DoxAletheia"

let global_prefix_map = global_prefix_declarations |> Map.ofArray
let generate_vocabulary (rdf_namespace_name: string) (rdf_sources: string) =
    let prefix_label = global_prefix_map[rdf_namespace_name]
    
    let term_label_comments =
        let isEnglishOrUnspecified (literal: LiteralNode) =
            String.IsNullOrWhiteSpace literal.Language
            || literal.Language.StartsWith("en", StringComparison.OrdinalIgnoreCase)

        let literalValuesForPredicate predicateFilter (graph: ThreadSafeGraph) subject predicate =
            graph.GetTriplesWithSubjectPredicate(subject, predicate)
            |> Seq.choose (fun triple ->
                match triple.Object with
                | :? LiteralNode as literal when predicateFilter literal ->
                    Some literal.Value
                | _ ->
                    None
            )
            |> Seq.distinct
            |> Seq.toArray

        rdf_sources.Split([| ';' |], StringSplitOptions.RemoveEmptyEntries)
        |> Array.map _.Trim()
        |> Array.filter (String.IsNullOrWhiteSpace >> not)
        |> Array.Parallel.filter (fun rdf_source -> File.Exists(rdf_source))
        |> Array.Parallel.collect (fun rdf_source ->

            let graph = new ThreadSafeGraph()
            FileLoader.Load(graph, rdf_source)

            let rdfs_label =
                graph.CreateUriNode(UriFactory.Create("http://www.w3.org/2000/01/rdf-schema#label"))

            let rdfs_comment =
                let comment = 
                    match rdf_namespace_name with 
                    | "https://w3id.org/linkml/" -> "https://w3id.org/linkml/comments"
                    | _ -> "http://www.w3.org/2000/01/rdf-schema#comment"
                graph.CreateUriNode(UriFactory.Create(comment))

            let vocabulary_terms =
                graph.AllNodes
                |> Seq.choose (fun node ->
                    match node with
                    | :? UriNode as iri -> Some iri
                    | _ -> None
                )
                |> Seq.filter (fun iri ->
                    iri.Uri.OriginalString.StartsWith(rdf_namespace_name)
                    && iri.Uri.OriginalString <> rdf_namespace_name
                )
                |> Seq.distinctBy (fun iri -> iri.Uri.OriginalString)
                |> Seq.toArray

            vocabulary_terms
            |> Array.Parallel.map (fun vocabulary_term ->
                let labels =
                    literalValuesForPredicate
                        (fun (_: LiteralNode) -> true)
                        graph
                        vocabulary_term
                        rdfs_label

                let comments =
                    literalValuesForPredicate
                        isEnglishOrUnspecified
                        graph
                        vocabulary_term
                        rdfs_comment

                vocabulary_term.Uri.OriginalString, labels, comments
            )
        )
        |> Array.groupBy (fun (iri_string, _, _) -> iri_string)
        |> Array.map (fun (iri_string, rows) ->
            let labels =
                rows
                |> Array.collect (fun (_, labels, _) -> labels)
                |> Array.distinct

            let comments =
                rows
                |> Array.collect (fun (_, _, comments) -> comments)
                |> Array.distinct

            iri_string, labels, comments
        )
    let fs_text =
        try
            Oak() {
                Namespace(rdfsharp_namespace rdf_namespace_name) {
                    Open($"{my_namespace}")
                    Module(prefix_label.Replace("-","_").normalize_identifier){
                        Value("_namespace_name",String(rdf_namespace_name))
                        Function("_prefix", ParameterPat("local_name"), "Namespaced_IRI.parse _namespace_name local_name |> NamespacedName")

                        for iri_string, labels, comments in term_label_comments do
                            let local_part = iri_string[rdf_namespace_name.Length..]

                            let property_name =
                                match rdf_namespace_name, labels with
                                | "", labels when labels.Length > 0 -> labels.[0]
                                | _ -> local_part
                            Value(property_name.normalize_identifier, $"_prefix \"{local_part}\"")
                            |> _.xmlDocs(IriDocs.xmldoc comments iri_string)


                    }

                }
            }
            |> Gen.mkOak
            |> Gen.run
        with 
        | err -> failwithf "namespace name %s\n\trdf sources %s\n failed with error %s" rdf_namespace_name rdf_sources err.Message
    let relative_path = iri_to_relative_path rdf_namespace_name
    let fs_file = 
        match prefix_label with 
        | "xsd" -> Path.Combine(project_directory, $"{prefix_label}.fs")
        | _ -> Path.Combine(generated_directory, $"{prefix_label}.fs")

    File.WriteAllText(fs_file,fs_text)
    sprintf "<Compile Include=\"%s.fs\" />" prefix_label
    

let item_group = 
    Array.concat [|

                    lov_content
                    manual_content
                    multipart_content
                    fibo.content

                     |]
                     |> Array.filter (fun (rdf_namespace_name, rdf_sources) -> not (errored_namespaces.Contains(rdf_namespace_name)))
                     |> Array.map (fun (rdf_namespace_name, rdf_sources) -> 

                        try 
                             generate_vocabulary rdf_namespace_name  rdf_sources
                        with 
                        | err -> 
                            errored_namespaces.Add(sprintf "namespace %s sources %s errored with %s" rdf_namespace_name rdf_sources err.Message)
                            String.Empty

                     )
                    |> Array.filter (fun item -> item <> "")


File.WriteAllLines(Path.Combine(__SOURCE_DIRECTORY__, "ErroredNamespaces.txt"), errored_namespaces)


// TODO investigate linkml output
// TODO consider a prefix refresh of all ttl files
// TODO investigate windows xsd files like event xsd in C:\Program Files (x86)\Windows Kits\10\Include
// TODO find a way to parse omg spec catalog for all files
// https://www.omg.org/spec/
