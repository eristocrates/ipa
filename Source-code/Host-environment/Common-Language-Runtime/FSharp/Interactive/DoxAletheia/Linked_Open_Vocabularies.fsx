fsi.ShowDeclarationValues <- false

open System
open System.IO
open System.Net.Http
open System.IO.Compression
open System.Text.RegularExpressions

#r "nuget: FsHttp"

open FsHttp

#r "nuget: dotNetRdf"

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF.Query.Datasets
open VDS.RDF.Storage

#r "nuget: FSharp.Data"
open FSharp.Data

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\JavascriptObjectNotationExtensions.fsx"

open JavascriptObjectNotationExtensions

open FSharp.Json

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\IriPathing.fsx"
open IriPathing

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"

open PowershellErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\HttpErgonomics.fsx"
open HttpErgonomics


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\FileSystemErgonomics.fsx"
open FileSystemErgonomics





















[<Literal>]
let DoxAletheiaRootDirectory =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia"


let VocabularyDirectory =
    ensure_path (Path.Combine(DoxAletheiaRootDirectory, "Vocabulary"))


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




let file_name_from_uri (uri: Uri) =
    match uri.OriginalString with
    | "http://www.lexinfo.net/ontology/3.0/lexinfo" -> "lexinfo.rdf"
    | "http://www.w3.org/ns/lemon/lexicog" -> "lexicog.rdf"
    | "http://aims.fao.org/aos/agrontology" -> "agrontology.rdf"
    | "http://eulersharp.sourceforge.net/2003/03swap/agent" -> "agent.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes" -> "bioSKOSSchemes.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/care" -> "care.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/coding" -> "coding.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/computer" -> "computer.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/countries" -> "countries.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/decisionSupport" -> "decisionSupport.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure" -> "digitalProcedure.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/document" -> "document.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/environment" -> "environment.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/event" -> "event.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/foster" -> "foster.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality" -> "genomeAbnormality.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/human" -> "human.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/humanBody" -> "humanBody.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/languages" -> "languages.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/organism" -> "organism.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/organization" -> "organization.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/physicalResource" -> "physicalResource.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/quantities" -> "quantities.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/space" -> "space.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/sparql" -> "sparql.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis" -> "sparqlAnalysis.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate" -> "sparqlAnalysisTemplate.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/substanceForms" -> "substanceForms.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/time" -> "time.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/units" -> "units.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/weekScheme" -> "weekScheme.ttl"
    | "http://eulersharp.sourceforge.net/2003/03swap/workflow" -> "workflow.ttl"
    | "http://qudt.org/3.1.10/schema/datatype" -> "datatype.ttl"
    | "http://qudt.org/3.1.10/schema/qudt" -> "qudt.ttl"
    | "http://qudt.org/3.1.10/schema/shacl/overlay/qudt" -> "qudt.ttl"
    | "http://qudt.org/3.1.10/schema/shacl/qudt" -> "qudt.ttl"
    | "http://qudt.org/3.1.10/vocab/constant" -> "constant.ttl"
    | "http://qudt.org/3.1.10/vocab/dimensionvector" -> "dimensionvector.ttl"
    | "http://qudt.org/3.1.10/vocab/quantitykind" -> "quantitykind.ttl"
    | "http://qudt.org/3.1.10/vocab/soqk" -> "soqk.ttl"
    | "http://www.w3.org/2000/10/swap/crypto" -> "crypto.rdf"
    | "http://www.w3.org/2000/10/swap/grammar/bnf" -> "bnf.rdf"
    | "http://www.w3.org/2000/10/swap/list" -> "list.rdf"
    | "http://www.w3.org/2000/10/swap/log" -> "log.rdf"
    | "http://www.w3.org/2000/10/swap/math" -> "math.rdf"
    | "http://www.w3.org/2000/10/swap/os" -> "os.rdf"
    | "http://www.w3.org/2000/10/swap/pim/contact" -> "contact.rdf"
    | "http://www.w3.org/2000/10/swap/pim/doc" -> "doc.rdf"
    | "http://www.w3.org/2000/10/swap/pim/email" -> "email.rdf"
    | "http://www.w3.org/2000/10/swap/pim/ical" -> "ical.rdf"
    | "http://www.w3.org/2000/10/swap/pim/qif" -> "qif.rdf"
    | "http://www.w3.org/2000/10/swap/pim/travelFig" -> "travelFig.rdf"
    | "http://www.w3.org/2000/10/swap/pim/travelTerms" -> "travelTerms.rdf"
    | "http://www.w3.org/2000/10/swap/pim/usps" -> "usps.rdf"
    | "http://www.w3.org/2000/10/swap/reason" -> "reason.rdf"
    | "http://www.w3.org/2000/10/swap/set" -> "set.rdf"
    | "http://www.w3.org/2000/10/swap/string" -> "string.rdf"
    | "http://www.w3.org/2004/06/rei#" -> "rei.rdf"
    | "http://www.w3.org/ns/shacl-shacl#" -> "shacl.ttl"
    | "http://www.w3.org/ns/solid/acp#" -> "acp.ttl"
    | "http://www.w3.org/ns/solid/interop#" -> "interop.ttl"
    | "http://www.w3.org/ns/solid/notifications#" -> "notifications.ttl"
    | "http://www.w3.org/ns/solid/oidc#" -> "oidc.ttl"
    | "http://www.w3.org/ns/solid/terms#" -> "terms.ttl"
    | "http://www.w3.org/ns/spec#" -> "spec.ttl"
    | "https://globalwordnet.github.io/schemas/wn#" -> "wn.rdf"
    | _ ->
        uri.Segments
        |> Array.rev
        |> Array.tryFind (fun segment -> segment <> "/")
        |> Option.map Uri.UnescapeDataString
        |> Option.defaultValue $"download.unknown"


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
        printfn "HTTP failed for %s: %s" distribution err.Message
        None

let namespace_directory_path (vocabulary_namespace: Uri) =
    ensure_path (Path.Combine(VocabularyDirectory, iriToRelativePath vocabulary_namespace.OriginalString))

let distribution_file_path (vocabulary_namespace: Uri) (distribution: Uri) =

    let directory_path = ensure_path (namespace_directory_path vocabulary_namespace)

    let file_name = file_name_from_uri distribution
    Path.Combine(directory_path, file_name)

let download_vocabulary_distribution (vocabulary_namespace: string) (distribution: string) =
    let file_path =
        distribution_file_path (new Uri(vocabulary_namespace)) (new Uri(distribution))

    if File.Exists(file_path) then
        ()
    else
        match distribution_http_response (distribution) with
        | Some http_response when http_response.IsSuccessStatusCode ->

            let file_text =
                http_response.Content.ReadAsStringAsync()
                |> Async.AwaitTask
                |> Async.RunSynchronously



            File.WriteAllText(file_path, file_text)


        | _ -> Console.WriteLine $"unable to download {vocabulary_namespace} distribution {distribution}"














let decompress_gzip_file (source_path: string) (destination_path: string) =
    use source_stream = File.OpenRead(source_path)

    use gzip_stream = new GZipStream(source_stream, CompressionMode.Decompress)

    use destination_stream = File.Create(destination_path)

    gzip_stream.CopyTo(destination_stream)

let private is_high_surrogate_code_unit value = value >= 0xD800 && value <= 0xDBFF

let private is_low_surrogate_code_unit value = value >= 0xDC00 && value <= 0xDFFF

let private surrogate_pair_to_code_point high low =
    0x10000
    + ((high - 0xD800) <<< 10)
    + (low - 0xDC00)

let normalize_escaped_surrogate_pairs (text: string) =
    Regex.Replace(
        text,
        @"\\u([dD][89aAbB][0-9a-fA-F]{2})\\u([dD][c-fC-F][0-9a-fA-F]{2})",
        MatchEvaluator (fun m ->
            let high = Convert.ToInt32(m.Groups.[1].Value, 16)
            let low = Convert.ToInt32(m.Groups.[2].Value, 16)

            if is_high_surrogate_code_unit high
               && is_low_surrogate_code_unit low then
                let code_point = surrogate_pair_to_code_point high low
                sprintf "\\U%08X" code_point
            else
                m.Value)
    )

let normalize_nquads_file (source_path: string) (destination_path: string) =
    use reader = new StreamReader(source_path)

    use writer = new StreamWriter(destination_path, false, System.Text.Encoding.UTF8)

    while not reader.EndOfStream do
        let line = reader.ReadLine()
        let normalized_line = normalize_escaped_surrogate_pairs line
        writer.WriteLine(normalized_line)


let find_first_bad_nquad_line (path: string) =
    let parser = NQuadsParser()

    use reader = new StreamReader(path)

    let mutable line_number = 0
    let mutable result: (int * string * string) option = None

    while result.IsNone && not reader.EndOfStream do
        line_number <- line_number + 1

        let line = reader.ReadLine()

        if not (String.IsNullOrWhiteSpace line) then
            try
                let store = new TripleStore()
                use line_reader = new StringReader(line)
                parser.Load(store, line_reader)
            with
            | err -> result <- Some(line_number, err.Message, line)

    result

let write_valid_nquads_only (source_path: string) (destination_path: string) =
    let parser = NQuadsParser()

    use reader = new StreamReader(source_path)
    use writer = new StreamWriter(destination_path, false, System.Text.Encoding.UTF8)

    use error_writer =
        new StreamWriter(destination_path + ".errors.txt", false, System.Text.Encoding.UTF8)

    let mutable line_number = 0
    let mutable kept = 0
    let mutable rejected = 0

    while not reader.EndOfStream do
        line_number <- line_number + 1
        let line = reader.ReadLine()

        if not (String.IsNullOrWhiteSpace line) then
            try
                let store = new TripleStore()
                use line_reader = new StringReader(line)
                parser.Load(store, line_reader)

                writer.WriteLine(line)
                kept <- kept + 1
            with
            | err ->
                rejected <- rejected + 1
                error_writer.WriteLine($"LINE {line_number}")
                error_writer.WriteLine(err.Message)
                error_writer.WriteLine(line)
                error_writer.WriteLine()

    printfn "Kept %i lines; rejected %i lines." kept rejected











module api =
    let v2Base = "https://lov.linkeddata.es/dataset/lov/api/v2"

    module vocabulary =

        [<Literal>]
        let list_path =
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.vocabulary.json"

        let get_list () =
            download_remote_to_local $"{v2Base}/vocabulary/list" list_path
(*
      let search () =
           $"{v2Base}/vocabulary/search"

      let autocomplete () =
           $"{v2Base}/vocabulary/autocomplete"

      let info () =
           $"{v2Base}/vocabulary/info"
      let json = JsonProvider<list_path>.Load list_path


    module term =
        let search () =
             $"{v2Base}/term/search"

        let autocomplete () =
             $"{v2Base}/term/autocomplete"

        let suggest () =
             $"{v2Base}/term/suggest"




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



module dump =

    [<Literal>]
    let n3gz_path =
        @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.n3.gz"


    let n3gz () =
        http {
            GET $"https://lov.linkeddata.es/lov.n3.gz"

        }
        |> Request.send
        |> Response.saveFile n3gz_path


    [<Literal>]
    let nqgz_path =
        @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.nq.gz"

    let nqgz () =
        http {
            GET $"https://lov.linkeddata.es/lov.nq.gz"

        }
        |> Request.send
        |> Response.saveFile nqgz_path




let nq_path = dump.nqgz_path.Replace(".gz", "")
let n3_path = dump.n3gz_path.Replace(".gz", "")


type Lov_Meta = { last_meta: DateTimeOffset }

module Lov_Meta =
    [<Literal>]
    let meta_file_path =
        @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov_meta.json"

    let refresh () =
        dump.n3gz ()
        // decompress_gzip_file dump.n3gz_path n3_path
        dump.nqgz ()
        decompress_gzip_file dump.nqgz_path nq_path
        let last_meta = { last_meta = DateTimeOffset.Now }
        let meta_file_content = Json.serialize last_meta
        File.WriteAllText(meta_file_path, meta_file_content)


    let json = JsonProvider<meta_file_path>.Load meta_file_path

    if json.LastMeta.Date < DateTime.Now.Date then
        refresh ()

// Lov_Meta.refresh ()
let graph = new ThreadSafeGraph()
FileLoader.Load(graph, dump.n3gz_path)





let voaf_vocabulary =
    graph.CreateUriNode(UriFactory.Create("http://purl.org/vocommons/voaf#Vocabulary"))

let rdf_type =
    graph.CreateUriNode(UriFactory.Create("http://www.w3.org/1999/02/22-rdf-syntax-ns#type"))

let vann_preferredNamespacePrefix =
    graph.CreateUriNode(UriFactory.Create("http://purl.org/vocab/vann/preferredNamespacePrefix"))

let vann_preferredNamespaceUri =
    graph.CreateUriNode(UriFactory.Create("http://purl.org/vocab/vann/preferredNamespaceUri"))

let dcat_distribution =
    graph.CreateUriNode(UriFactory.Create("http://www.w3.org/ns/dcat#distribution"))

let dcat_keyword =
    graph.CreateUriNode(UriFactory.Create("http://www.w3.org/ns/dcat#keyword"))


let rdfs_label =
    graph.CreateUriNode(UriFactory.Create("http://www.w3.org/2000/01/rdf-schema#label"))

let rdfs_comment =
    graph.CreateUriNode(UriFactory.Create("http://www.w3.org/2000/01/rdf-schema#comment"))

(*

let keyword_set =
    graph.GetTriplesWithPredicate(dcat_keyword)
    |> Seq.toArray
    |> Array.Parallel.map (fun keyword_triple ->
        let keyword = keyword_triple.Object :?> LiteralNode
        keyword.Value)
    |> Set.ofArray

keyword_set |> Set.iter (fun keyword -> printfn "%s" keyword)

*)

module Lov_Keyword =
    let API = graph.CreateLiteralNode("API")
    let Academy = graph.CreateLiteralNode("Academy")
    let Biology = graph.CreateLiteralNode("Biology")
    let CSV = graph.CreateLiteralNode("CSV")
    let Catalogs = graph.CreateLiteralNode("Catalogs")
    let Contracts = graph.CreateLiteralNode("Contracts")
    let Environment = graph.CreateLiteralNode("Environment")
    let Events = graph.CreateLiteralNode("Events")
    let FRBR = graph.CreateLiteralNode("FRBR")
    let Food = graph.CreateLiteralNode("Food")
    let Games = graph.CreateLiteralNode("Games")
    let General_and_Upper = graph.CreateLiteralNode("General & Upper")
    let Geography = graph.CreateLiteralNode("Geography")
    let Geometry = graph.CreateLiteralNode("Geometry")
    let Government = graph.CreateLiteralNode("Government")
    let Health = graph.CreateLiteralNode("Health")
    let Image = graph.CreateLiteralNode("Image")
    let Industry = graph.CreateLiteralNode("Industry")
    let IoT = graph.CreateLiteralNode("IoT")
    let Metadata = graph.CreateLiteralNode("Metadata")
    let Methods = graph.CreateLiteralNode("Methods")
    let Multimedia = graph.CreateLiteralNode("Multimedia")
    let Music = graph.CreateLiteralNode("Music")
    let PLM = graph.CreateLiteralNode("PLM")
    let PROTON = graph.CreateLiteralNode("PROTON")
    let People = graph.CreateLiteralNode("People")
    let Press = graph.CreateLiteralNode("Press")
    let Quality = graph.CreateLiteralNode("Quality")
    let RDF = graph.CreateLiteralNode("RDF")
    let Rec = graph.CreateLiteralNode("Rec")
    let SPAR = graph.CreateLiteralNode("SPAR")
    let SSDesk = graph.CreateLiteralNode("SSDesk")
    let Security = graph.CreateLiteralNode("Security")
    let Services = graph.CreateLiteralNode("Services")
    let Society = graph.CreateLiteralNode("Society")
    let Support = graph.CreateLiteralNode("Support")
    let Tag = graph.CreateLiteralNode("Tag")
    let Time = graph.CreateLiteralNode("Time")
    let Transport = graph.CreateLiteralNode("Transport")
    let Travel = graph.CreateLiteralNode("Travel")
    let Vocabularies = graph.CreateLiteralNode("Vocabularies")
    let W3CRec = graph.CreateLiteralNode("W3CRec")
    let eBusiness = graph.CreateLiteralNode("eBusiness")

    let _search (keyword: ILiteralNode) =
        graph.GetTriplesWithPredicateObject(dcat_keyword, keyword)
        |> Seq.toArray
        |> Array.Parallel.map (fun keyword_triple -> keyword_triple.Subject :?> UriNode)





let vocabulary'preferredNamespaceUri =

    graph.GetTriplesWithPredicateObject(rdf_type, voaf_vocabulary)
    |> Seq.toArray
    |> Array.Parallel.map (fun vocabulary_triple -> vocabulary_triple.Subject :?> UriNode)

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
        |> Array.Parallel.filter (fun distribution_triple -> distribution_triple.Object.NodeType = NodeType.Uri)
        |> Array.Parallel.map (fun distribution_triple ->

            let distribution = distribution_triple.Object :?> UriNode
            (vocabulary, preferred_namespace, preferred_prefix, distribution)

        )

    )

type Lov_Vocabulary =
    {

      vocabulary_iri: UriNode
      preferred_namespace_iri: LiteralNode
      preferred_prefix: LiteralNode
      distribution_iri: UriNode

     }
    member this.module_string =
        sprintf
            """
module %s =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "%s" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }
          """
            this.preferred_prefix.Value
            this.preferred_namespace_iri.Value

module Lov_Vocabulary =
    let from_manual_addition (vocabulary'preferred_namespace'preferred_prefix'distribution: string * string * string * string) =
        let (vocabulary, preferred_namespace, preferred_prefix, distribution) =
            vocabulary'preferred_namespace'preferred_prefix'distribution

        {


          vocabulary_iri = graph.CreateUriNode(UriFactory.Create(vocabulary)) :?> UriNode
          preferred_namespace_iri = graph.CreateLiteralNode(preferred_namespace) :?> LiteralNode
          preferred_prefix = graph.CreateLiteralNode(preferred_prefix) :?> LiteralNode
          distribution_iri = graph.CreateUriNode(UriFactory.Create(distribution)) :?> UriNode

        }

let dataset_vocabularies =
    vocabulary'preferredNamespaceUri'preferredNamespacePrefixes'distribution
    |> Array.Parallel.map (fun (vocabulary, preferred_namespace, preferred_prefix, distribution) ->

        {

          vocabulary_iri = vocabulary
          preferred_namespace_iri = preferred_namespace
          preferred_prefix = preferred_prefix
          distribution_iri = distribution

        }

    )



let label_override_set: Set<string> =
    set [


          "http://purl.obolibrary.org/obo/BFO_"
          "http://purl.obolibrary.org/obo/FOODON_"
          "http://purl.obolibrary.org/obo/IAO_"
          "http://purl.obolibrary.org/obo/NCIT_"
          "http://purl.obolibrary.org/obo/OBI_"
          "http://purl.obolibrary.org/obo/OMRSE_"
          "http://purl.obolibrary.org/obo/PATO_"
          "https://www.commoncoreontologies.org/mro/"
          "http://purl.obolibrary.org/obo/RO_"
          "http://semanticscience.org/resource/SIO_"
          "http://www.ebi.ac.uk/swo/SWO_"
          "https://www.commoncoreontologies.org/"


           ]

open System
open System.Collections.Generic
open System.Text

module FSharpIdentifier =

    let private reservedWords =
        HashSet<string>(
            [
              // F# keywords
              "abstract"
              "and"
              "as"
              "assert"
              "base"
              "begin"
              "class"
              "default"
              "delegate"
              "do"
              "done"
              "downcast"
              "downto"
              "elif"
              "else"
              "end"
              "exception"
              "extern"
              "false"
              "finally"
              "fixed"
              "for"
              "fun"
              "function"
              "global"
              "if"
              "in"
              "inherit"
              "inline"
              "interface"
              "internal"
              "lazy"
              "let"
              "let!"
              "match"
              "match!"
              "member"
              "module"
              "mutable"
              "namespace"
              "new"
              "null"
              "of"
              "open"
              "or"
              "override"
              "private"
              "public"
              "rec"
              "return"
              "return!"
              "static"
              "struct"
              "then"
              "to"
              "true"
              "try"
              "type"
              "upcast"
              "use"
              "use!"
              "val"
              "void"
              "when"
              "while"
              "with"
              "yield"
              "yield!"

              // OCaml-compatibility reserved tokens
              "asr"
              "land"
              "lor"
              "lsl"
              "lsr"
              "lxor"
              "mod"
              "sig"

              // Reserved for future expansion
              "break"
              "checked"
              "component"
              "const"
              "constraint"
              "continue"
              "event"
              "external"
              "include"
              "mixin"
              "parallel"
              "process"
              "protected"
              "pure"
              "sealed"
              "tailcall"
              "trait"
              "virtual" ],
            StringComparer.Ordinal
        )

    let private isIdentifierStartCharacter (character: char) =
        character = '_' || Char.IsLetter character

    let private isIdentifierPartCharacter (character: char) =
        character = '_'
        || character = '\''
        || Char.IsLetterOrDigit character

    let private appendUnderscoreIfNeeded (builder: StringBuilder) =
        if builder.Length = 0
           || builder[builder.Length - 1] <> '_' then
            builder.Append '_' |> ignore

    let normalizeToPlainIdentifier (rawName: string) =
        let rawName =
            if String.IsNullOrWhiteSpace rawName then
                "value"
            else
                rawName.Trim()

        let builder = StringBuilder(rawName.Length)

        for character in rawName do
            if isIdentifierPartCharacter character then
                builder.Append character |> ignore
            elif Char.IsWhiteSpace character
                 || Char.IsPunctuation character
                 || Char.IsSymbol character then
                appendUnderscoreIfNeeded builder
            else
                appendUnderscoreIfNeeded builder

        let normalized = builder.ToString().Trim('_')

        let normalized =
            if String.IsNullOrWhiteSpace normalized then
                "value"
            else
                normalized

        let normalized =
            if isIdentifierStartCharacter normalized[0] then
                normalized
            else
                "_" + normalized

        if normalized = "_" then
            "value"
        else
            normalized

    let quoteIfReservedWord (identifier: string) =
        if reservedWords.Contains identifier then
            $"``{identifier}``"
        else
            identifier

    let toLetBindingIdentifier (rawName: string) =
        rawName
        |> normalizeToPlainIdentifier
        |> quoteIfReservedWord


type Lov_Term =
    {

      vocabulary: Lov_Vocabulary
      term_iri: UriNode
      term_label: LiteralNode option
      term_comment: LiteralNode option

     }
    member this.local_name =

        let local_name_index = this.vocabulary.preferred_namespace_iri.Value.Length
        this.term_iri.Uri.OriginalString[local_name_index..]

    member this.fsx_binding =
        let rawIdentifier =
            if label_override_set.Contains(this.vocabulary.vocabulary_iri.Uri.OriginalString) then
                match this.term_label with
                | Some label -> label.Value
                | None -> this.local_name
            else
                this.local_name

        FSharpIdentifier.toLetBindingIdentifier rawIdentifier

    member this.fsx_comment =
        match this.term_comment with
        | Some comment ->
            comment.Value.Split('\n')
            |> Array.map (fun comment_line -> $"/// {comment_line}")
            |> String.concat "\n"

        | _ -> ""

    member this.let_string =
        sprintf
            """
    %s
    let %s = _vocab "%s" """
            this.fsx_comment
            this.fsx_binding
            this.local_name

type Vocabulary_Lexicon =
    { vocabulary: Lov_Vocabulary
      terms: Lov_Term array }

    member this.let_bindings =
        this.terms
        |> Array.distinctBy (fun term -> term.local_name)
        |> Array.sortBy (fun term -> term.local_name)
        |> Array.map (fun term -> term.let_string)
        |> String.concat "\n"

    member this.module_binding = $"{this.vocabulary.module_string}\n{this.let_bindings}"


let normalized_nq_path = Path.ChangeExtension(nq_path, ".normalized.nq")

normalize_nquads_file nq_path normalized_nq_path

(*

match find_first_bad_nquad_line normalized_nq_path with
| Some (line_number, message, line) ->
    printfn "Bad line: %i" line_number
    printfn "Error: %s" message
    printfn "Content: %s" line
| None -> printfn "No bad N-Quads lines found."

*)
let cleaned_nq_path = Path.ChangeExtension(normalized_nq_path, ".cleaned.nq")


write_valid_nquads_only normalized_nq_path cleaned_nq_path


let dataset = new DatasetFileManager(cleaned_nq_path, false)


// dataset.ListGraphNames()
// let om_vocabulary = Lov_Vocabulary.from_manual_addition

module Vocabulary_Lexicon =
    let process_vocabulary_graph (vocabulary: Lov_Vocabulary) (graph: ThreadSafeGraph) =


        let vocabulary_terms =
            graph.AllNodes
            |> Seq.toArray
            |> Array.Parallel.filter (fun node -> node.NodeType = NodeType.Uri)
            |> Array.Parallel.map (fun node -> node :?> UriNode)
            |> Array.Parallel.filter (fun iri -> iri.Uri.OriginalString.StartsWith(vocabulary.preferred_namespace_iri.Value))


        let vocabulary_term'label =
            vocabulary_terms
            |> Array.Parallel.collect (fun vocabulary_term ->
                let label_triples =
                    graph.GetTriplesWithSubjectPredicate(vocabulary_term, rdfs_label)
                    |> Seq.toArray

                match label_triples.Length with
                | 0 -> [| (vocabulary_term, None) |]
                | _ ->
                    label_triples
                    |> Array.Parallel.filter (fun label_triple -> label_triple.Object.NodeType = NodeType.Literal)
                    |> Array.Parallel.map (fun label_triple ->
                        let label = label_triple.Object :?> LiteralNode
                        (vocabulary_term, Some(label))

                    )

            )

        let vocabulary_term'label'comment =
            vocabulary_term'label
            |> Array.Parallel.collect (fun (vocabulary_term, label) ->
                let comment_triples =
                    graph.GetTriplesWithSubjectPredicate(vocabulary_term, rdfs_comment)
                    |> Seq.toArray

                match comment_triples.Length with
                | 0 -> [| (vocabulary_term, label, None) |]
                | _ ->
                    // TODO investigate any non literal comments
                    comment_triples
                    |> Array.Parallel.filter (fun comment_triple -> comment_triple.Object.NodeType = NodeType.Literal)
                    |> Array.Parallel.filter (fun comment_triple ->
                        let comment = comment_triple.Object :?> LiteralNode

                        comment.Language.StartsWith("en")
                        || comment.Language.StartsWith(""))
                    |> Array.Parallel.map (fun comment_triple ->
                        let comment = comment_triple.Object :?> LiteralNode
                        (vocabulary_term, label, Some(comment))

                    )

            )



        let terms =
            vocabulary_term'label'comment
            |> Array.Parallel.map (fun (vocabulary_term, label, comment) ->

                {

                  vocabulary = vocabulary
                  term_iri = vocabulary_term
                  term_label = label
                  term_comment = comment

                }

            )

        { vocabulary = vocabulary
          terms = terms }

    let from_manual_vocabulary (vocabulary: Lov_Vocabulary) =
        let file_path =
            distribution_file_path (new Uri(vocabulary.preferred_namespace_iri.Value)) vocabulary.distribution_iri.Uri

        download_vocabulary_distribution vocabulary.preferred_namespace_iri.Value vocabulary.distribution_iri.Uri.OriginalString


        let graph = new ThreadSafeGraph()

        try
            FileLoader.Load(graph, file_path)
            process_vocabulary_graph vocabulary graph
        with
        | err -> failwithf "%O failed with error: %s" vocabulary err.Message

    let from_lov_vocabulary (vocabulary: Lov_Vocabulary) =

        let graph = new ThreadSafeGraph()
        dataset.LoadGraph(graph, vocabulary.vocabulary_iri.Uri)
        process_vocabulary_graph vocabulary graph

let dataset_lexicons =
    dataset_vocabularies
    |> Array.Parallel.map Vocabulary_Lexicon.from_lov_vocabulary


let skos_vocabulary'preferredNamespaceUri =
    graph.GetTriplesWithPredicateObject(rdf_type, voaf_vocabulary)
    |> Seq.toArray
    |> Array.Parallel.map (fun vocabulary_triple -> vocabulary_triple.Subject :?> UriNode)

    |> Array.Parallel.collect (fun vocabulary ->
        graph.GetTriplesWithSubjectPredicate(vocabulary, vann_preferredNamespaceUri)
        |> Seq.toArray
        |> Array.Parallel.map (fun preferred_uri_triple -> preferred_uri_triple.Object :?> LiteralNode)
        |> Array.Parallel.filter (fun preferred_namespace -> preferred_namespace.Value = "http://www.w3.org/2004/02/skos/core#")
        |> Array.Parallel.map (fun preferred_namespace -> (vocabulary, preferred_namespace)

        )

    )




// vocabulary
// namespace
// prefix
// distribution

let manual_vocabulary_tuples =
    [|

       ("http://www.w3.org/ns/csvw", "http://www.w3.org/ns/csvw#", "csvw", "https://www.w3.org/ns/csvw.ttl")
       ("https://open-metadata.org/ontology", "https://open-metadata.org/ontology/", "om", "https://raw.githubusercontent.com/open-metadata/OpenMetadataStandards/refs/heads/main/rdf/ontology/openmetadata.ttl")
       ("https://schema.org", "https://schema.org/", "schemorg", "https://schema.org/version/latest/schemaorg-all-https.ttl")
       ("https://termlex.oeg.fi.upm.es/termlex", "https://termlex.oeg.fi.upm.es/termlex#", "termlex", "https://termlex.oeg.fi.upm.es/static/termlex.rdf")

       ("http://www.lexinfo.net/ontology/3.0/lexinfo", "http://www.lexinfo.net/ontology/3.0/lexinfo#", "lexinfo", "http://www.lexinfo.net/ontology/3.0/lexinfo")
       ("http://www.w3.org/ns/lemon/frac", "http://www.w3.org/ns/lemon/frac#", "frac", "https://raw.githubusercontent.com/ontolex/frequency-attestation-corpus-information/refs/heads/master/owl/frac.ttl")
       ("http://www.w3.org/ns/lemon/lexicog", "http://www.w3.org/ns/lemon/lexicog#", "lexicog", "http://www.w3.org/ns/lemon/lexicog")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_meta", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/owl/meta.owl.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_annotations_model", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/annotations.model.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_annotations", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/annotations.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_datasets_model", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/datasets.model.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_datasets", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/datasets.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_extensions_model", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/extensions.model.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_extensions", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/extensions.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_mappings_model", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/mappings.model.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_mappings", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/mappings.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_meta_model", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/meta.model.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/meta.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_types_model", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/types.model.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_types", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/types.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_units_model", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/units.model.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_units", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/units.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_validation_model", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/validation.model.ttl")
       ("https://w3id.org/linkml/", "https://w3id.org/linkml/", "linkml_validation", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/validation.ttl")


       (*
       ("http://aims.fao.org/aos/agrontology",
        "http://aims.fao.org/aos/agrontology#",
        "agrontology",
        "http://aims.fao.org/aos/agrontology")
       ("http://data.europa.eu/m8g/",
        "http://data.europa.eu/m8g/",
        "semic_criterion_evidence",
        "https://github.com/SEMICeu/CCCEV/raw/refs/heads/master/releases/2.1.0/voc/cccev.ttl")
       ("http://data.europa.eu/m8g/",
        "http://data.europa.eu/m8g/",
        "semic_business",
        "https://github.com/SEMICeu/Core-Business-Vocabulary/raw/refs/heads/master/releases/2.2.0/voc/core-business-ap.ttl")
       ("http://data.europa.eu/m8g/",
        "http://data.europa.eu/m8g/",
        "semic_location",
        "https://github.com/SEMICeu/Core-Location-Vocabulary/raw/refs/heads/master/releases/2.1.0/voc/core-location.ttl")
       ("http://data.europa.eu/m8g/",
        "http://data.europa.eu/m8g/",
        "semic_person",
        "https://github.com/SEMICeu/Core-Person-Vocabulary/raw/refs/heads/master/releases/2.1.1/voc/core-person-ap.ttl")
       ("http://data.europa.eu/m8g/",
        "http://data.europa.eu/m8g/",
        "semic_public_event",
        "https://github.com/SEMICeu/Core-Public-Event-Vocabulary/raw/refs/heads/master/releases/1.1.0/voc/core-public-event.ttl")
       ("http://data.europa.eu/m8g/",
        "http://data.europa.eu/m8g/",
        "semic_public_organization",
        "https://github.com/SEMICeu/CPOV/raw/refs/heads/master/releases/2.1.1/voc/core-public-organisation-ap.ttl")
       ("http://datashapes.org/dash", "http://datashapes.org/dash#", "dash", "https://datashapes.org/dash.ttl")
       (*

       ("http://eulersharp.sourceforge.net/2003/03swap/agent",
        "http://eulersharp.sourceforge.net/2003/03swap/agent#",
        "swap_agent",
        "http://eulersharp.sourceforge.net/2003/03swap/agent")
       ("http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes",
        "http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#",
        "swap_bioSKOSSchemes",
        "http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes")
       ("http://eulersharp.sourceforge.net/2003/03swap/care",
        "http://eulersharp.sourceforge.net/2003/03swap/care#",
        "swap_care",
        "http://eulersharp.sourceforge.net/2003/03swap/care")
       ("http://eulersharp.sourceforge.net/2003/03swap/coding",
        "http://eulersharp.sourceforge.net/2003/03swap/coding#",
        "swap_coding",
        "http://eulersharp.sourceforge.net/2003/03swap/coding")
       ("http://eulersharp.sourceforge.net/2003/03swap/computer",
        "http://eulersharp.sourceforge.net/2003/03swap/computer#",
        "swap_computer",
        "http://eulersharp.sourceforge.net/2003/03swap/computer")
       ("http://eulersharp.sourceforge.net/2003/03swap/countries",
        "http://eulersharp.sourceforge.net/2003/03swap/countries#",
        "swap_countries",
        "http://eulersharp.sourceforge.net/2003/03swap/countries")
       ("http://eulersharp.sourceforge.net/2003/03swap/decisionSupport",
        "http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#",
        "swap_decisionSupport",
        "http://eulersharp.sourceforge.net/2003/03swap/decisionSupport")
       ("http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure",
        "http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#",
        "swap_digitalProcedure",
        "http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure")
       ("http://eulersharp.sourceforge.net/2003/03swap/document",
        "http://eulersharp.sourceforge.net/2003/03swap/document#",
        "swap_document",
        "http://eulersharp.sourceforge.net/2003/03swap/document")
       ("http://eulersharp.sourceforge.net/2003/03swap/environment",
        "http://eulersharp.sourceforge.net/2003/03swap/environment#",
        "swap_environment",
        "http://eulersharp.sourceforge.net/2003/03swap/environment")
       ("http://eulersharp.sourceforge.net/2003/03swap/event",
        "http://eulersharp.sourceforge.net/2003/03swap/event#",
        "swap_event",
        "http://eulersharp.sourceforge.net/2003/03swap/event")
       ("http://eulersharp.sourceforge.net/2003/03swap/foster",
        "http://eulersharp.sourceforge.net/2003/03swap/foster#",
        "swap_foster",
        "http://eulersharp.sourceforge.net/2003/03swap/foster")
       ("http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality",
        "http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#",
        "swap_genomeAbnormality",
        "http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality")
       ("http://eulersharp.sourceforge.net/2003/03swap/human",
        "http://eulersharp.sourceforge.net/2003/03swap/human#",
        "swap_human",
        "http://eulersharp.sourceforge.net/2003/03swap/human")
       ("http://eulersharp.sourceforge.net/2003/03swap/humanBody",
        "http://eulersharp.sourceforge.net/2003/03swap/humanBody#",
        "swap_humanBody",
        "http://eulersharp.sourceforge.net/2003/03swap/humanBody")
       ("http://eulersharp.sourceforge.net/2003/03swap/languages",
        "http://eulersharp.sourceforge.net/2003/03swap/languages#",
        "swap_languages",
        "http://eulersharp.sourceforge.net/2003/03swap/languages")
       ("http://eulersharp.sourceforge.net/2003/03swap/organism",
        "http://eulersharp.sourceforge.net/2003/03swap/organism#",
        "swap_organism",
        "http://eulersharp.sourceforge.net/2003/03swap/organism")
       ("http://eulersharp.sourceforge.net/2003/03swap/organization",
        "http://eulersharp.sourceforge.net/2003/03swap/organization#",
        "swap_organization",
        "http://eulersharp.sourceforge.net/2003/03swap/organization")
       ("http://eulersharp.sourceforge.net/2003/03swap/physicalResource",
        "http://eulersharp.sourceforge.net/2003/03swap/physicalResource#",
        "swap_physicalResource",
        "http://eulersharp.sourceforge.net/2003/03swap/physicalResource")
       ("http://eulersharp.sourceforge.net/2003/03swap/quantities",
        "http://eulersharp.sourceforge.net/2003/03swap/quantities#",
        "swap_quantities",
        "http://eulersharp.sourceforge.net/2003/03swap/quantities")
       ("http://eulersharp.sourceforge.net/2003/03swap/space",
        "http://eulersharp.sourceforge.net/2003/03swap/space#",
        "swap_space",
        "http://eulersharp.sourceforge.net/2003/03swap/space")
       ("http://eulersharp.sourceforge.net/2003/03swap/sparql",
        "http://eulersharp.sourceforge.net/2003/03swap/sparql#",
        "swap_sparql",
        "http://eulersharp.sourceforge.net/2003/03swap/sparql")
       ("http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis",
        "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#",
        "swap_sparqlAnalysis",
        "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis")
       ("http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate",
        "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#",
        "swap_sparqlAnalysisTemplate",
        "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate")
       ("http://eulersharp.sourceforge.net/2003/03swap/substanceForms",
        "http://eulersharp.sourceforge.net/2003/03swap/substanceForms#",
        "swap_substanceForms",
        "http://eulersharp.sourceforge.net/2003/03swap/substanceForms")
       ("http://eulersharp.sourceforge.net/2003/03swap/time",
        "http://eulersharp.sourceforge.net/2003/03swap/time#",
        "swap_time",
        "http://eulersharp.sourceforge.net/2003/03swap/time")
       ("http://eulersharp.sourceforge.net/2003/03swap/units",
        "http://eulersharp.sourceforge.net/2003/03swap/units#",
        "swap_units",
        "http://eulersharp.sourceforge.net/2003/03swap/units")
       ("http://eulersharp.sourceforge.net/2003/03swap/weekScheme",
        "http://eulersharp.sourceforge.net/2003/03swap/weekScheme#",
        "swap_weekScheme",
        "http://eulersharp.sourceforge.net/2003/03swap/weekScheme")
       ("http://eulersharp.sourceforge.net/2003/03swap/workflow",
        "http://eulersharp.sourceforge.net/2003/03swap/workflow#",
        "swap_workflow",
        "http://eulersharp.sourceforge.net/2003/03swap/workflow")

       *)
       ("http://example.org/dctap",
        "http://example.org/dctap#",
        "dcmi_dctap",
        "https://github.com/dcmi/dctap/raw/refs/heads/main/dctap.ttl")
       ("http://id.loc.gov/ontologies/bflc/",
        "http://id.loc.gov/ontologies/bflc/",
        "loc_bibframe_lc",
        "https://id.loc.gov/ontologies/bflc.rdf")
       ("http://id.loc.gov/ontologies/bibframe/",
        "http://id.loc.gov/ontologies/bibframe/",
        "loc_bibframe",
        "https://id.loc.gov/ontologies/bibframe.rdf")
       ("http://ns.ottr.xyz/0.4/",
        "http://ns.ottr.xyz/0.4/",
        "ottr_bOTTR",
        "https://spec.ottr.xyz/bOTTR/0.1.2/core-vocabulary.owl.ttl")
       ("http://ns.ottr.xyz/0.4/",
        "http://ns.ottr.xyz/0.4/",
        "ottr_rOTTR_puntypes",
        "https://spec.ottr.xyz/rOTTR/0.2.0/puntypes.owl.ttl")
       ("http://ns.ottr.xyz/0.4/",
        "http://ns.ottr.xyz/0.4/",
        "ottr_rOTTR_types",
        "https://spec.ottr.xyz/rOTTR/0.2.0/types.owl.ttl")
       ("http://ns.ottr.xyz/0.4/",
        "http://ns.ottr.xyz/0.4/",
        "ottr_rOTTR_shacl",
        "https://spec.ottr.xyz/rOTTR/0.2.0/types.shacl.ttl")
       ("http://ns.ottr.xyz/0.4/",
        "http://ns.ottr.xyz/0.4/",
        "ottr_wOTTR_shacl",
        "https://spec.ottr.xyz/wOTTR/0.4.5/core-grammar.shacl.ttl")
       ("http://ns.ottr.xyz/0.4/",
        "http://ns.ottr.xyz/0.4/",
        "ottr_wOTTR",
        "https://spec.ottr.xyz/wOTTR/0.4.5/core-vocabulary.owl.ttl")
       ("http://open-services.net/ns/am",
        "http://open-services.net/ns/am#",
        "oasis_oslc_am",
        "https://docs.oasis-open-projects.org/oslc-op/am/v3.0/os/architecture-management-vocab.ttl")
       ("http://open-services.net/ns/auto",
        "http://open-services.net/ns/auto#",
        "oasis_oslc_auto",
        "https://docs.oasis-open-projects.org/oslc-op/auto/v2.1/psd01/automation-vocab.ttl")
       ("http://open-services.net/ns/cm",
        "http://open-services.net/ns/cm#",
        "oasis_oslc_cm",
        "https://docs.oasis-open-projects.org/oslc-op/cm/v3.0/errata01/os/change-mgt-vocab.ttl")
       ("http://open-services.net/ns/config",
        "http://open-services.net/ns/config#",
        "oasis_oslc_config",
        "https://docs.oasis-open-projects.org/oslc-op/config/v1.1/psd01/config-vocab.ttl")
       ("http://open-services.net/ns/core",
        "http://open-services.net/ns/core#",
        "oasis_oslc",
        "https://docs.oasis-open-projects.org/oslc-op/core/v3.0/os/core-vocab.ttl")
       ("http://open-services.net/ns/core/trs",
        "http://open-services.net/ns/core/trs#",
        "oasis_oslc_trs",
        "https://docs.oasis-open-projects.org/oslc-op/trs/v3.0/os/trs-vocab.ttl")
       ("http://open-services.net/ns/core/trspatch",
        "http://open-services.net/ns/core/trspatch#",
        "oasis_oslc_trs_patch",
        "https://docs.oasis-open-projects.org/oslc-op/trs/v3.0/os/trs-vocab.ttl")
       ("http://open-services.net/ns/qm",
        "http://open-services.net/ns/qm#",
        "oasis_oslc_qm",
        "https://docs.oasis-open-projects.org/oslc-op/qm/v2.1/os/quality-management-vocab.ttl")
       ("http://open-services.net/ns/rm",
        "http://open-services.net/ns/rm#",
        "oasis_oslc_rm",
        "https://docs.oasis-open-projects.org/oslc-op/rm/v2.1/os/requirements-management-vocab.ttl")
       ("http://open-services.net/ns/sysmlv2",
        "http://open-services.net/ns/sysmlv2#",
        "oasis_oslc_sysml",
        "https://docs.oasis-open-projects.org/oslc-op/sysml/v2.0/psd01/sysml-vocab.ttl")
       ("http://openprovenance.org/model/opmo",
        "http://openprovenance.org/model/opmo#",
        "opmo",
        "https://openprovenance.org/opm/model/opmo-20101012.owl")
       ("http://purl.obolibrary.org/obo/BFO_",
        "http://purl.obolibrary.org/obo/BFO_",
        "obo_bfo",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-imports/bfo-core.ttl")
       ("http://purl.obolibrary.org/obo/NCIT_",
        "http://purl.obolibrary.org/obo/NCIT_",
        "obo_ncit",
        "http://purl.obolibrary.org/obo/ncit.owl")
       ("http://purl.org/cerif/frapo/", "http://purl.org/cerif/frapo/", "spar_frapo", "http://purl.org/spar/frapo.ttl")
       ("http://purl.org/dc/dcam/", "http://purl.org/dc/dcam/", "dcmi_dcam", "http://purl.org/dc/dcam/")
       ("http://purl.org/dc/dcmitype/", "http://purl.org/dc/dcmitype/", "dcmi_dctype", "http://purl.org/dc/dcmitype/")
       ("http://purl.org/dc/elements/1.1/",
        "http://purl.org/dc/elements/1.1/",
        "dcmi_dc",
        "http://purl.org/dc/elements/1.1/")
       ("http://purl.org/dc/terms/", "http://purl.org/dc/terms/", "dcmi_dcterms", "http://purl.org/dc/terms/")
       ("http://purl.org/dcx/lrmi-terms/",
        "http://purl.org/dcx/lrmi-terms/",
        "dcmi_lrmi",
        "http://dublincore.org/specifications/lrmi/lrmi_terms/2022-06-14/lrmi-terms.ttl")
       ("http://purl.org/dcx/lrmi-vocabs/alignmentType/",
        "http://purl.org/dcx/lrmi-vocabs/alignmentType/",
        "dcmi_lrmi_alignment",
        "http://dublincore.org/vocabs/alignmentType.ttl")
       ("http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/",
        "http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/",
        "dcmi_lrmi_audRole",
        "http://dublincore.org/vocabs/educationalAudienceRole.ttl")
       ("http://purl.org/dcx/lrmi-vocabs/educationalUse/",
        "http://purl.org/dcx/lrmi-vocabs/educationalUse/",
        "dcmi_lrmi_edUse",
        "http://dublincore.org/vocabs/educationalUse.ttl")
       ("http://purl.org/dcx/lrmi-vocabs/interactivityType/",
        "http://purl.org/dcx/lrmi-vocabs/interactivityType/",
        "dcmi_lrmi_interact",
        "http://dublincore.org/vocabs/interactivityType.ttl")
       ("http://purl.org/dcx/lrmi-vocabs/learningResourceType/",
        "http://purl.org/dcx/lrmi-vocabs/learningResourceType/",
        "dcmi_lrmi_resourceType",
        "https://www.dublincore.org/vocabs/learningResourceType.ttl")
       ("http://purl.org/goodrelations/v1",
        "http://purl.org/goodrelations/v1#",
        "gr",
        "http://purl.org/goodrelations/v1.owl")
       ("http://purl.org/iso25964/skos-thes",
        "http://purl.org/iso25964/skos-thes#",
        "skos_thes",
        "https://www.dublincore.org/specifications/skos-thes/ns/skos-thes.ttl")
       ("http://purl.org/linked-data/cube",
        "http://purl.org/linked-data/cube#",
        "qube",
        "http://purl.org/linked-data/cube#")
       ("http://purl.org/net/p-plan", "http://purl.org/net/p-plan#", "pplan", "http://purl.org/net/p-plan#")
       ("http://purl.org/ontology/bibo/",
        "http://purl.org/ontology/bibo/",
        "dcmi_bibo",
        "http://purl.org/ontology/bibo/")
       ("http://purl.org/ontology/olo/core",
        "http://purl.org/ontology/olo/core#",
        "olo",
        "https://github.com/smiy/orderedlistonto/raw/refs/heads/master/rdf/orderedlistontology.n3")
       ("http://purl.org/spar/bido/", "http://purl.org/spar/bido/", "spar_bido", "http://purl.org/spar/bido.ttl")
       ("http://purl.org/spar/biro/", "http://purl.org/spar/biro/", "spar_biro", "http://purl.org/spar/biro.ttl")
       ("http://purl.org/spar/c4o/", "http://purl.org/spar/c4o/", "spar_c4o", "http://purl.org/spar/c4o.ttl")
       ("http://purl.org/spar/cito/", "http://purl.org/spar/cito/", "spar_cito", "http://purl.org/spar/cito.ttl")
       ("http://purl.org/spar/datacite/",
        "http://purl.org/spar/datacite/",
        "spar_datacite",
        "http://purl.org/spar/datacite.ttl")
       ("http://purl.org/spar/deo/", "http://purl.org/spar/deo/", "spar_deo", "http://purl.org/spar/deo.ttl")
       ("http://purl.org/spar/doco/", "http://purl.org/spar/doco/", "spar_doco", "http://purl.org/spar/doco.ttl")
       ("http://purl.org/spar/fabio/", "http://purl.org/spar/fabio/", "spar_fabio", "http://purl.org/spar/fabio.ttl")
       ("http://purl.org/spar/fivestars/",
        "http://purl.org/spar/fivestars/",
        "spar_fivestars",
        "http://purl.org/spar/fivestars.ttl")
       ("http://purl.org/spar/fr/",
        "http://purl.org/spar/fr/",
        "fr",
        "https://sparontologies.github.io/fr/current/fr.ttl")
       ("http://purl.org/spar/frbr/",
        "http://purl.org/spar/frbr/",
        "frbr",
        "https://sparontologies.github.io/frbr/current/frbr.ttl")
       ("http://purl.org/spar/mito/",
        "http://purl.org/spar/mito/",
        "mito",
        "https://sparontologies.github.io/mito/current/mito.ttl")
       ("http://purl.org/spar/pro/",
        "http://purl.org/spar/pro/",
        "pro",
        "https://sparontologies.github.io/pro/current/pro.ttl")
       ("http://purl.org/spar/pso/",
        "http://purl.org/spar/pso/",
        "pso",
        "https://sparontologies.github.io/pso/current/pso.ttl")
       ("http://purl.org/spar/pwo/",
        "http://purl.org/spar/pwo/",
        "pwo",
        "https://sparontologies.github.io/pwo/current/pwo.ttl")
       ("http://purl.org/spar/scoro/",
        "http://purl.org/spar/scoro/",
        "scoro",
        "https://sparontologies.github.io/scoro/current/scoro.ttl")
       ("http://purl.org/swan/2.0/",
        "http://purl.org/swan/2.0/",
        "swan",
        "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/swan.owl")
       ("http://purl.org/swan/2.0/collections/",
        "http://purl.org/swan/2.0/collections/",
        "swan_collections",
        "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/collections.owl")
       ("http://purl.org/swan/2.0/discourse-elements/",
        "http://purl.org/swan/2.0/discourse-elements/",
        "swan_discourse_elements",
        "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/discourse-elements.owl")
       ("http://purl.org/swan/2.0/discourse-relationships/",
        "http://purl.org/swan/2.0/discourse-relationships/",
        "swan_discourse_relationships",
        "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/discourse-relationships.owl")
       ("http://purl.org/swan/2.0/experiment",
        "http://purl.org/swan/2.0/experiment",
        "swan_experiments",
        "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/experiments.owl")
       ("http://purl.org/vocab/cpsv",
        "http://purl.org/vocab/cpsv#",
        "semic_public_service",
        "https://github.com/SEMICeu/CPSV-AP/raw/refs/heads/master/releases/3.2.0/rdf/cpsv-ap.ttl")
       ("http://purl.org/vocab/vann/", "http://purl.org/vocab/vann/", "vann", "http://purl.org/vocab/vann/")
       ("http://purl.org/vocommons/voaf", "http://purl.org/vocommons/voaf#", "voaf", "http://purl.org/vocommons/voaf#")
       ("http://qudt.org/schema/qudt/",
        "http://qudt.org/schema/qudt/",
        "qudt-datatype",
        "http://qudt.org/3.1.10/schema/datatype")
       ("http://qudt.org/schema/qudt/", "http://qudt.org/schema/qudt/", "qudt", "http://qudt.org/3.1.10/schema/qudt")
       ("http://qudt.org/schema/qudt/",
        "http://qudt.org/schema/qudt/",
        "qudt-shacl-overlay",
        "http://qudt.org/3.1.10/schema/shacl/overlay/qudt")
       ("http://qudt.org/schema/qudt/",
        "http://qudt.org/schema/qudt/",
        "qudt-shacl",
        "http://qudt.org/3.1.10/schema/shacl/qudt")
       ("http://qudt.org/vocab/constant/",
        "http://qudt.org/vocab/constant/",
        "qudt-constant",
        "http://qudt.org/3.1.10/vocab/constant")
       ("http://qudt.org/vocab/dimensionvector",
        "http://qudt.org/vocab/dimensionvector",
        "qudt-dimensionvector",
        "http://qudt.org/3.1.10/vocab/dimensionvector")
       ("http://qudt.org/vocab/quantitykind",
        "http://qudt.org/vocab/quantitykind",
        "qudt-quantitykind",
        "http://qudt.org/3.1.10/vocab/quantitykind")
       ("http://qudt.org/vocab/soqk",
        "http://qudt.org/vocab/soqk",
        "qudt-system-quantitykind",
        "http://qudt.org/3.1.10/vocab/soqk")
       ("http://schema.org/", "http://schema.org/", "schema_shacl", "https://datashapes.org/schema.ttl")
       ("http://semanticscience.org/resource/SIO_",
        "http://semanticscience.org/resource/SIO_",
        "obo_sio",
        "http://semanticscience.org/ontology/sio.owl")
       ("http://usefulinc.com/ns/doap",
        "http://usefulinc.com/ns/doap#",
        "doap",
        "https://lov.linkeddata.es/dataset/lov/vocabs/doap/versions/2012-01-04.n3")
       ("http://w3id.org/nfdi4ing/metadata4ing",
        "http://w3id.org/nfdi4ing/metadata4ing#",
        "m4i",
        "http://w3id.org/nfdi4ing/metadata4ing#")
       ("http://w3id.org/rml/", "http://w3id.org/rml/", "rml", "http://w3id.org/rml/")
       ("http://www.cidoc-crm.org/cidoc-crm/",
        "http://www.cidoc-crm.org/cidoc-crm/",
        "cidocrm",
        "https://cidoc-crm.org/rdfs/7.1.1/CIDOC_CRM_v7.1.1.rdf")
       ("http://www.daml.org/services/owl-s/1.2/ActorDefault.owl",
        "http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#",
        "owl_s_ActorDefault",
        "http://www.daml.org/services/owl-s/1.2/ActorDefault.owl")
       ("http://www.daml.org/services/owl-s/1.2/generic/Expression.owl",
        "http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#",
        "owl_s_Expression",
        "http://www.daml.org/services/owl-s/1.2/generic/Expression.owl")
       ("http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl",
        "http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#",
        "owl_s_ObjectList",
        "http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl")
       ("http://www.daml.org/services/owl-s/1.2/Grounding.owl",
        "http://www.daml.org/services/owl-s/1.2/Grounding.owl#",
        "owl_s_Grounding",
        "http://www.daml.org/services/owl-s/1.2/Grounding.owl")
       ("http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl",
        "http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl",
        "owl_s_GroundingDeprecatedElements",
        "http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl")
       ("http://www.daml.org/services/owl-s/1.2/Process.owl",
        "http://www.daml.org/services/owl-s/1.2/Process.owl",
        "owl_s_ProcessDeprecatedElements",
        "http://www.daml.org/services/owl-s/1.2/ProcessDeprecatedElements.owl")
       ("http://www.daml.org/services/owl-s/1.2/Process.owl",
        "http://www.daml.org/services/owl-s/1.2/Process.owl#",
        "owl_s_Process",
        "http://www.daml.org/services/owl-s/1.2/Process.owl")
       ("http://www.daml.org/services/owl-s/1.2/Profile.owl",
        "http://www.daml.org/services/owl-s/1.2/Profile.owl#",
        "owl_s_Profile",
        "http://www.daml.org/services/owl-s/1.2/Profile.owl")
       ("http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl",
        "http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#",
        "owl_s_Profile_AdditionalParameters",
        "http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl")
       ("http://www.daml.org/services/owl-s/1.2/Resource.owl",
        "http://www.daml.org/services/owl-s/1.2/Resource.owl#",
        "owl_s_Resource",
        "http://www.daml.org/services/owl-s/1.2/Resource.owl")
       ("http://www.daml.org/services/owl-s/1.2/Service.owl",
        "http://www.daml.org/services/owl-s/1.2/Service.owl#",
        "owl_s_Service",
        "https://www.daml.org/services/owl-s/1.2/Service.owl")
       ("http://www.ebi.ac.uk/swo/SWO_",
        "http://www.ebi.ac.uk/swo/SWO_",
        "obo_swo",
        "http://purl.obolibrary.org/obo/swo.owl")
       ("http://www.essepuntato.it/2008/12/earmark",
        "http://www.essepuntato.it/2008/12/earmark#",
        "dwellonit_earmark_ghost",
        "https://sourceforge.net/p/dwellonit/code/HEAD/tree/EARMARK/Current%20Version/earmark_ghost-1_2.owl?format=raw")
       ("http://www.essepuntato.it/2008/12/earmark",
        "http://www.essepuntato.it/2008/12/earmark#",
        "dwellonit_earmark_shell",
        "https://sourceforge.net/p/dwellonit/code/HEAD/tree/EARMARK/Current%20Version/earmark_shell-2_0.owl?format=raw")
       ("http://www.essepuntato.it/2008/12/pattern",
        "http://www.essepuntato.it/2008/12/pattern#",
        "dwellonit_pattern",
        "https://sourceforge.net/p/dwellonit/code/HEAD/tree/StructuralPattern/pattern.owl?format=raw")
       ("http://www.essepuntato.it/2011/02/argumentmodel/",
        "http://www.essepuntato.it/2011/02/argumentmodel/",
        "dwellonit_arg",
        "https://sourceforge.net/p/dwellonit/code/HEAD/tree/ArgumentModel/argumentmodel.owl?format=raw")
       ("http://www.essepuntato.it/2012/04/tvc/",
        "http://www.essepuntato.it/2012/04/tvc/",
        "dwellonit_tvc",
        "https://sourceforge.net/p/dwellonit/code/HEAD/tree/TimeIndexedValueInContext/tvc.owl?format=raw")
       ("http://www.essepuntato.it/2013/10/vagueness/",
        "http://www.essepuntato.it/2013/10/vagueness/",
        "dwellonit_vag",
        "https://sourceforge.net/p/dwellonit/code/HEAD/tree/VaguenessOntology/model.owl?format=raw")
       ("http://www.lexinfo.net/ontology/3.0/lexinfo",
        "http://www.lexinfo.net/ontology/3.0/lexinfo#",
        "ontolex_lexinfo",
        "http://www.lexinfo.net/ontology/3.0/lexinfo#")
       ("http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl",
        "http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#",
        "dolce_lite",
        "https://github.com/iddi/sofia/raw/refs/heads/master/eu.sofia.adk.common/ontologies/foundational/DOLCE-Lite.owl")
       ("http://www.loa-cnr.it/ontologies/ExtendedDnS.owl",
        "http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#",
        "dns",
        "https://github.com/iddi/sofia/raw/refs/heads/master/eu.sofia.adk.common/ontologies/foundational/ExtendedDnS.owl")
       ("http://www.loc.gov/premis/rdf/v3/",
        "http://www.loc.gov/premis/rdf/v3/",
        "loc_premis",
        "https://id.loc.gov/ontologies/premis-3-0-0.rdf")
       ("http://www.ontology-of-units-of-measure.org/resource/om-2/",
        "http://www.ontology-of-units-of-measure.org/resource/om-2/",
        "om2-ucum",
        "https://github.com/HajoRijgersberg/OM/raw/refs/heads/master/om-2-ucum.ttl")
       ("http://www.ontology-of-units-of-measure.org/resource/om-2/",
        "http://www.ontology-of-units-of-measure.org/resource/om-2/",
        "om2",
        "https://github.com/HajoRijgersberg/OM/raw/refs/heads/master/om-2.0.rdf")
       ("http://www.opengis.net/ont/geosparql",
        "http://www.opengis.net/ont/geosparql#",
        "opengis_geosparql",
        "http://www.opengis.net/ont/geosparql#")
       ("http://www.opengis.net/ont/sf",
        "http://www.opengis.net/ont/sf#",
        "opengis_sf",
        "http://www.opengis.net/ont/sf#")
       ("http://www.opmw.org/ontology/",
        "http://www.opmw.org/ontology/",
        "opmw",
        "https://www.opmw.org/model/OPMW/opmw3.1.owl")
       (*

       ("http://www.semanticdesktop.org/ontologies/2007/01/19/nie",
        "http://www.semanticdesktop.org/ontologies/2007/01/19/nie#",
        "nepomuk_nie_v1",
        "http://www.semanticdesktop.org/ontologies/2007/01/19/nie/nie.trig")
       ("http://www.semanticdesktop.org/ontologies/2007/03/22/nco",
        "http://www.semanticdesktop.org/ontologies/2007/03/22/nco#",
        "nepomuk_nco_v1",
        "http://www.semanticdesktop.org/ontologies/2007/03/22/nco/nco.trig")
       ("http://www.semanticdesktop.org/ontologies/2007/03/22/nfo",
        "http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#",
        "nepomuk_nfo_v1",
        "http://www.semanticdesktop.org/ontologies/2007/03/22/nfo/nfo.trig")
       ("http://www.semanticdesktop.org/ontologies/2007/03/22/nmo",
        "http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#",
        "nepomuk_nmo_v1",
        "http://www.semanticdesktop.org/ontologies/2007/03/22/nmo/nmo.trig")
       ("http://www.semanticdesktop.org/ontologies/2007/04/02/ncal",
        "http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#",
        "nepomuk_ncal_v1",
        "http://www.semanticdesktop.org/ontologies/2007/04/02/ncal/ncal.trig")
       ("http://www.semanticdesktop.org/ontologies/2007/05/10/nexif",
        "http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#",
        "nepomuk_nexif_v1",
        "http://www.semanticdesktop.org/ontologies/2007/05/10/nexif/nexif.trig")
       ("http://www.semanticdesktop.org/ontologies/2007/05/10/nid3",
        "http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#",
        "nepomuk_nid3_v1",
        "http://www.semanticdesktop.org/ontologies/2007/05/10/nid3/nid3.trig")
       ("http://www.semanticdesktop.org/ontologies/2007/08/15/nao",
        "http://www.semanticdesktop.org/ontologies/2007/08/15/nao#",
        "nepomuk_nao_v1",
        "http://www.semanticdesktop.org/ontologies/2007/08/15/nao/nao.trig")
       ("http://www.semanticdesktop.org/ontologies/2007/08/15/nrl",
        "http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#",
        "nepomuk_nrl_v1",
        "http://www.semanticdesktop.org/ontologies/2007/08/15/nrl/nrl.trig")
       ("http://www.semanticdesktop.org/ontologies/2007/11/01/pimo",
        "http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#",
        "nepomuk_pimo_v1",
        "http://www.semanticdesktop.org/ontologies/2007/11/01/pimo/pimo.trig")
       ("http://www.semanticdesktop.org/ontologies/2008/05/20/tmo",
        "http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#",
        "nepomuk_tmo_v1",
        "http://www.semanticdesktop.org/ontologies/2008/05/20/tmo/v1.1/tmo.trig")

        *)
       ("http://www.w3.org/2000/10/swap/crypto",
        "http://www.w3.org/2000/10/swap/crypto#",
        "swap_crypto",
        "http://www.w3.org/2000/10/swap/crypto")
       ("http://www.w3.org/2000/10/swap/grammar/bnf",
        "http://www.w3.org/2000/10/swap/grammar/bnf#",
        "swap_grammar_bnf",
        "http://www.w3.org/2000/10/swap/grammar/bnf")
       ("http://www.w3.org/2000/10/swap/list",
        "http://www.w3.org/2000/10/swap/list#",
        "swap_list",
        "http://www.w3.org/2000/10/swap/list")
       ("http://www.w3.org/2000/10/swap/log",
        "http://www.w3.org/2000/10/swap/log#",
        "swap_log",
        "http://www.w3.org/2000/10/swap/log")
       ("http://www.w3.org/2000/10/swap/math",
        "http://www.w3.org/2000/10/swap/math#",
        "swap_math",
        "http://www.w3.org/2000/10/swap/math")
       ("http://www.w3.org/2000/10/swap/os",
        "http://www.w3.org/2000/10/swap/os#",
        "swap_os",
        "http://www.w3.org/2000/10/swap/os")
       ("http://www.w3.org/2000/10/swap/pim/contact",
        "http://www.w3.org/2000/10/swap/pim/contact#",
        "swap_pim_contact",
        "http://www.w3.org/2000/10/swap/pim/contact")
       ("http://www.w3.org/2000/10/swap/pim/doc",
        "http://www.w3.org/2000/10/swap/pim/doc#",
        "swap_pim_doc",
        "http://www.w3.org/2000/10/swap/pim/doc")
       ("http://www.w3.org/2000/10/swap/pim/email",
        "http://www.w3.org/2000/10/swap/pim/email#",
        "swap_pim_email",
        "http://www.w3.org/2000/10/swap/pim/email")
       ("http://www.w3.org/2000/10/swap/pim/ical",
        "http://www.w3.org/2000/10/swap/pim/ical#",
        "swap_pim_ical",
        "http://www.w3.org/2000/10/swap/pim/ical")
       ("http://www.w3.org/2000/10/swap/pim/qif",
        "http://www.w3.org/2000/10/swap/pim/qif#",
        "swap_pim_qif",
        "http://www.w3.org/2000/10/swap/pim/qif")
       ("http://www.w3.org/2000/10/swap/pim/travelFig",
        "http://www.w3.org/2000/10/swap/pim/travelFig#",
        "swap_pim_travelFig",
        "http://www.w3.org/2000/10/swap/pim/travelFig")
       ("http://www.w3.org/2000/10/swap/pim/travelTerms",
        "http://www.w3.org/2000/10/swap/pim/travelTerms#",
        "swap_pim_travelTerms",
        "http://www.w3.org/2000/10/swap/pim/travelTerms")
       ("http://www.w3.org/2000/10/swap/pim/usps",
        "http://www.w3.org/2000/10/swap/pim/usps#",
        "swap_pim_usps",
        "http://www.w3.org/2000/10/swap/pim/usps")
       ("http://www.w3.org/2000/10/swap/reason",
        "http://www.w3.org/2000/10/swap/reason#",
        "swap_reason",
        "http://www.w3.org/2000/10/swap/reason")
       ("http://www.w3.org/2000/10/swap/set",
        "http://www.w3.org/2000/10/swap/set#",
        "swap_set",
        "http://www.w3.org/2000/10/swap/set")
       ("http://www.w3.org/2000/10/swap/string",
        "http://www.w3.org/2000/10/swap/string#",
        "swap_string",
        "http://www.w3.org/2000/10/swap/string")
       ("http://www.w3.org/2002/07/owl", "http://www.w3.org/2002/07/owl#", "owl", "http://www.w3.org/2002/07/owl#")
       ("http://www.w3.org/2002/12/cal/ical",
        "http://www.w3.org/2002/12/cal/ical#",
        "ical",
        "http://www.w3.org/2002/12/cal/ical#")
       ("http://www.w3.org/2004/02/skos/core",
        "http://www.w3.org/2004/02/skos/core#",
        "skos",
        "http://www.w3.org/2004/02/skos/core#")
       ("http://www.w3.org/2004/06/rei", "http://www.w3.org/2004/06/rei#", "rei", "http://www.w3.org/2004/06/rei#")
       ("http://www.w3.org/2006/03/wn/wn20/instances/synset-",
        "http://www.w3.org/2006/03/wn/wn20/instances/synset-",
        "wordnet_wn20_synset",
        "https://www.w3.org/2006/03/wn/wn20/instances/index.rdf")
       ("http://www.w3.org/2006/03/wn/wn20/instances/word-",
        "http://www.w3.org/2006/03/wn/wn20/instances/word-",
        "wordnet_wn20_word",
        "https://www.w3.org/2006/03/wn/wn20/instances/index.rdf")
       ("http://www.w3.org/2006/03/wn/wn20/instances/wordsense-",
        "http://www.w3.org/2006/03/wn/wn20/instances/wordsense-",
        "wordnet_wn20_wordsense",
        "https://www.w3.org/2006/03/wn/wn20/instances/index.rdf")
       ("http://www.w3.org/2006/time", "http://www.w3.org/2006/time#", "time", "http://www.w3.org/2006/time#")
       ("http://www.w3.org/2006/timezone",
        "http://www.w3.org/2006/timezone#",
        "tzont",
        "http://www.w3.org/2006/timezone#")
       ("http://www.w3.org/2006/vcard/ns",
        "http://www.w3.org/2006/vcard/ns#",
        "vcard",
        "http://www.w3.org/2006/vcard/ns#")
       ("http://www.w3.org/ns/adms", "http://www.w3.org/ns/adms#", "adms", "http://www.w3.org/ns/adms#")
       ("http://www.w3.org/ns/csvw", "http://www.w3.org/ns/csvw#", "csvw", "http://www.w3.org/ns/csvw#")
       ("http://www.w3.org/ns/dcat", "http://www.w3.org/ns/dcat#", "dcat", "http://www.w3.org/ns/dcat#")
       ("http://www.w3.org/ns/dqv", "http://www.w3.org/ns/dqv#", "dqv", "https://www.w3.org/ns/dqv.ttl")
       ("http://www.w3.org/ns/hydra/core",
        "http://www.w3.org/ns/hydra/core#",
        "hydra",
        "http://www.w3.org/ns/hydra/core#")
       ("http://www.w3.org/ns/locn", "http://www.w3.org/ns/locn#", "locn", "http://www.w3.org/ns/locn#")
       ("http://www.w3.org/ns/oa", "http://www.w3.org/ns/oa#", "oa", "http://www.w3.org/ns/oa#")
       ("http://www.w3.org/ns/org", "http://www.w3.org/ns/org#", "org", "http://www.w3.org/ns/org#")
       ("http://www.w3.org/ns/pim/space", "http://www.w3.org/ns/pim/space#", "space", "http://www.w3.org/ns/pim/space#")
       ("http://www.w3.org/ns/prov", "http://www.w3.org/ns/prov#", "prov", "http://www.w3.org/ns/prov#")
       ("http://www.w3.org/ns/r2rml", "http://www.w3.org/ns/r2rml#", "r2rml", "http://www.w3.org/ns/r2rml#")
       ("http://www.w3.org/ns/rdfa", "http://www.w3.org/ns/rdfa#", "rdfa", "http://www.w3.org/ns/rdfa#")
       ("http://www.w3.org/ns/shacl", "http://www.w3.org/ns/shacl#", "shacl", "http://www.w3.org/ns/shacl#")
       ("http://www.w3.org/ns/shacl-shacl",
        "http://www.w3.org/ns/shacl-shacl#",
        "shaclshacl",
        "http://www.w3.org/ns/shacl-shacl#")
       ("http://www.w3.org/ns/shex", "http://www.w3.org/ns/shex#", "shex", "https://www.w3.org/ns/shex.ttl")
       ("http://www.w3.org/ns/solid/acp", "http://www.w3.org/ns/solid/acp#", "acp", "http://www.w3.org/ns/solid/acp#")
       ("http://www.w3.org/ns/solid/interop",
        "http://www.w3.org/ns/solid/interop#",
        "interop",
        "http://www.w3.org/ns/solid/interop#")
       ("http://www.w3.org/ns/solid/notifications",
        "http://www.w3.org/ns/solid/notifications#",
        "notify",
        "http://www.w3.org/ns/solid/notifications#")
       ("http://www.w3.org/ns/solid/oidc",
        "http://www.w3.org/ns/solid/oidc#",
        "oidc",
        "http://www.w3.org/ns/solid/oidc#")
       ("http://www.w3.org/ns/solid/terms",
        "http://www.w3.org/ns/solid/terms#",
        "solid",
        "http://www.w3.org/ns/solid/terms#")
       ("http://www.w3.org/ns/sosa/", "http://www.w3.org/ns/sosa/", "sosa", "http://www.w3.org/ns/sosa/")
       ("http://www.w3.org/ns/spec", "http://www.w3.org/ns/spec#", "spec", "http://www.w3.org/ns/spec#")
       ("http://www.w3.org/ns/ssn/", "http://www.w3.org/ns/ssn/", "ssn", "http://www.w3.org/ns/ssn/")
       ("http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1",
        "http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#",
        "d2rq",
        "http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1")
       ("http://xmlns.com/foaf/0.1/",
        "http://xmlns.com/foaf/0.1/",
        "foaf",
        "https://lov.linkeddata.es/dataset/lov/vocabs/foaf/versions/2014-01-14.n3")
       ("https://www.commoncoreontologies.org/",
        "https://www.commoncoreontologies.org/",
        "cco_Geospatial",
        "https://raw.githubusercontent.com/CommonCoreOntology/CommonCoreOntologies/refs/heads/develop/src/cco-modules/GeospatialOntology.ttl")
       ("https://globalwordnet.github.io/schemas/wn",
        "https://globalwordnet.github.io/schemas/wn#",
        "wordnet_wn",
        "https://globalwordnet.github.io/schemas/wn#")
       ("https://ns.dublincore.org/openwemi/",
        "https://ns.dublincore.org/openwemi/",
        "dcmi_openwemi",
        "https://dcmi.github.io/openwemi/ns/openWEMI.ttl")
       ("https://purl.org/heals/eo",
        "https://purl.org/heals/eo#",
        "eo",
        "https://raw.githubusercontent.com/tetherless-world/explanation-ontology/master/Ontologies/v2/explanation-ontology.owl")
       ("https://saref.etsi.org/core/",
        "https://saref.etsi.org/core/",
        "saref",
        "https://saref.etsi.org/core/v4.1.1/saref.ttl")
       ("https://schema.org/",
        "https://schema.org/",
        "schema",
        "https://schema.org/version/latest/schemaorg-all-https.ttl")
       ("https://spdx.org/rdf/3.1/terms/",
        "https://spdx.org/rdf/3.1/terms/",
        "spdx3",
        "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl")
       ("https://w3id.org/okn/o/sd",
        "https://w3id.org/okn/o/sd#",
        "sd",
        "https://knowledgecaptureanddiscovery.github.io/SoftwareDescriptionOntology/release/1.9.0/ontology.ttl")
       ("https://w3id.org/pko",
        "https://w3id.org/pko#",
        "pko",
        "https://perks-project.github.io/pk-ontology/pko/latest/pko.ttl")
       ("https://w3id.org/semapv/vocab/",
        "https://w3id.org/semapv/vocab/",
        "semapv",
        "https://github.com/mapping-commons/semantic-mapping-vocabulary/raw/refs/heads/main/semapv.owl")
       ("https://www.commoncoreontologies.org/",
        "https://www.commoncoreontologies.org/",
        "cco_Agent",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/AgentOntology.ttl")
       ("https://www.commoncoreontologies.org/",
        "https://www.commoncoreontologies.org/",
        "cco_Artifact",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/ArtifactOntology.ttl")
       ("https://www.commoncoreontologies.org/",
        "https://www.commoncoreontologies.org/",
        "cco_CurrencyUnit",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/CurrencyUnitOntology.ttl")
       ("https://www.commoncoreontologies.org/",
        "https://www.commoncoreontologies.org/",
        "cco_Event",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/EventOntology.ttl")
       ("https://www.commoncoreontologies.org/",
        "https://www.commoncoreontologies.org/",
        "cco_ExtendedRelation",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/ExtendedRelationOntology.ttl")
       ("https://www.commoncoreontologies.org/",
        "https://www.commoncoreontologies.org/",
        "cco_Facility",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/FacilityOntology.ttl")
       ("https://www.commoncoreontologies.org/",
        "https://www.commoncoreontologies.org/",
        "cco_InformationEntity",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/InformationEntityOntology.ttl")
       ("https://www.commoncoreontologies.org/",
        "https://www.commoncoreontologies.org/",
        "cco_Quality",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/QualityOntology.ttl")
       ("https://www.commoncoreontologies.org/",
        "https://www.commoncoreontologies.org/",
        "cco_Time",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/TimeOntology.ttl")
       ("https://www.commoncoreontologies.org/",
        "https://www.commoncoreontologies.org/",
        "cco_UnitsOfMeasure",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/UnitsOfMeasureOntology.ttl")
       ("https://www.commoncoreontologies.org/mro/",
        "https://www.commoncoreontologies.org/mro/",
        "cco_mro",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-extensions/ModalRelationOntology.ttl")
       ("https://www.ica.org/standards/RiC/ontology",
        "https://www.ica.org/standards/RiC/ontology#",
        "rico",
        "https://www.ica.org/standards/RiC/RiC-O_1-1.rdf")

*)
       |]

let manual_vocabularies =
    manual_vocabulary_tuples
    |> Array.map (fun tuple ->
        try
            Lov_Vocabulary.from_manual_addition tuple
        with
        | err -> failwithf "%O failed with error message %s" tuple err.Message)



// let vocabulary = manual_vocabularies[0]
// let file_path = distribution_file_path (new Uri(vocabulary.preferred_namespace_iri.Value)) vocabulary.distribution_iri.Uri
// distribution_http_response vocabulary.distribution_iri.Uri.OriginalString

let manual_lexicons =
    manual_vocabularies
    |> Array.map Vocabulary_Lexicon.from_manual_vocabulary


// namespace_directory_path (new Uri "http://www.w3.org/2000/10/swap/grammar/bnf#")

let all_lexicons =
    Array.concat [| dataset_lexicons
                    manual_lexicons |]

let singular_lexicons =
    all_lexicons
    |> Array.Parallel.groupBy (fun lexicon -> lexicon.vocabulary.preferred_namespace_iri.Value)
    |> Array.Parallel.filter (fun (namespace_name, lexicon_group) -> lexicon_group.Length = 1)
    |> Array.Parallel.map (fun (namespace_name, lexicon_group) -> lexicon_group[0])

let modular_lexicons =
    all_lexicons
    |> Array.Parallel.groupBy (fun lexicon -> lexicon.vocabulary.preferred_namespace_iri.Value)
    |> Array.Parallel.filter (fun (namespace_name, lexicon_group) -> lexicon_group.Length > 1)
    |> Array.Parallel.collect (fun (namespace_name, lexicon_group) ->
        lexicon_group
        |> Array.Parallel.choose (fun lexicon ->
            let last_segment =
                lexicon.vocabulary.distribution_iri.Uri.Segments
                |> Array.last

            let file_name = Path.GetFileNameWithoutExtension(last_segment)

            try
                let distribution_date = DateTime.Parse(file_name)
                None
            with
            | _ -> Some(lexicon)


        )

    )

let versioned_lexicons =
    all_lexicons
    |> Array.Parallel.groupBy (fun lexicon -> lexicon.vocabulary.preferred_namespace_iri.Value)
    |> Array.Parallel.filter (fun (namespace_name, lexicon_group) -> lexicon_group.Length > 1)
    |> Array.Parallel.collect (fun (namespace_name, lexicon_group) ->
        lexicon_group
        |> Array.Parallel.choose (fun lexicon ->
            let last_segment =
                lexicon.vocabulary.distribution_iri.Uri.Segments
                |> Array.last

            let file_name = Path.GetFileNameWithoutExtension(last_segment)

            try
                let distribution_date = DateTime.Parse(file_name)
                Some(lexicon)
            with
            | _ -> None


        )
        |> Array.Parallel.sortBy (fun lexicon ->
            let last_segment =
                lexicon.vocabulary.distribution_iri.Uri.Segments
                |> Array.last

            let file_name = Path.GetFileNameWithoutExtension(last_segment)
            DateTime.Parse(file_name)

        )

    )


all_lexicons.Length
singular_lexicons.Length
modular_lexicons.Length
versioned_lexicons.Length


module Lexicon_Search =
    let namespace_starts_with (target: string) (lexicons: Vocabulary_Lexicon array) =
        lexicons
        |> Array.choose (fun lexicon ->
            if lexicon.vocabulary.preferred_namespace_iri.Value.StartsWith target then
                Some(lexicon)
            else
                None)

    let namespace_exact (target: string) (lexicons: Vocabulary_Lexicon array) =
        lexicons
        |> Array.choose (fun lexicon ->
            if lexicon.vocabulary.preferred_namespace_iri.Value = target then
                Some(lexicon)
            else
                None)

    let is_versioned (target_namespace: string) =
        versioned_lexicons
        |> Array.exists (fun lexicon -> lexicon.vocabulary.preferred_namespace_iri.Value = target_namespace)









































































let retrieved_lexicons =
    all_lexicons
    |> Lexicon_Search.namespace_starts_with "https://open-metadata.org/ontology/"
    |> Array.sortBy (fun lexicon -> lexicon.vocabulary.distribution_iri.Uri.OriginalString)


retrieved_lexicons.Length


retrieved_lexicons
|> Array.iter (fun retrieved_lexicon -> printfn "%s" retrieved_lexicon.vocabulary.distribution_iri.Uri.OriginalString)



retrieved_lexicons
|> Array.map (fun retrieved_lexicon -> retrieved_lexicon.module_binding

)
|> Array.distinct
|> String.concat "\n"
|> clip




let retrieved_lexicon = retrieved_lexicons |> Array.last
retrieved_lexicon.module_binding |> clip

// TODO handle prefixes somehow
// all_lexicons |> Array.countBy (fun lexicon -> lexicon.vocabulary.preferred_prefix.Value)

// download_vocabulary_distribution target_namespace target_distribution


// Lov_Keyword._search Lov_Keyword.Government
