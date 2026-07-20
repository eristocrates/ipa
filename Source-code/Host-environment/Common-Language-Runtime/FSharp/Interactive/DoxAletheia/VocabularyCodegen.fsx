# time on

open System
open System.IO



open System
open System.Text
open System.Security


#r "nuget: FSharp.Compiler.Service, 43.10.102"
open FSharp.Compiler.CodeAnalysis
open FSharp.Compiler.Diagnostics
open FSharp.Compiler.Text
open FSharp.Compiler.Diagnostics
open FSharp.Compiler.Interactive.Shell

#r "nuget: dotNetRdf"
#r "nuget: Iride"

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF.Query.Datasets
open VDS.RDF.Storage
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Writing

open Iride

#r "nuget:  Fabulous.AST"
open Fabulous.AST
open Fantomas.Core.SyntaxOak
open type Fabulous.AST.Ast

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\FileSystemErgonomics.fsx"
open FileSystemErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\PrettierNaming.fsx"

open PrettierNaming
open PrettierNaming.FSharp_Keywords

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\IriPathing.fsx"
open IriPathing

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XmlErgonomics.fsx"
open XmlErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Namespace_Prefixes.fsx"
open Namespace_Prefixes



[<Literal>]
let DoxAletheiaRootDirectory =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia"


let VocabularyDirectory =
    ensure_path (Path.Combine(DoxAletheiaRootDirectory, "Vocabulary"))




let rdfsharp_namespace (iri:string) = 
    let uri = Uri(iri)
    let terminal = 
        match iri[iri.Length - 1] with 
        | '#' -> "hash"
        | '/' -> "slash"
        | _ -> "bare"
        

    sprintf "%s.%s.%s.%s"
        uri.Scheme
        uri.Host
        (uri.Segments
        |> Array.map (fun segment -> segment.Replace("/","").Replace("-","_"))
        |> Array.filter (fun segment -> segment <> "")
        |> Array.map (fun segment -> 
            if Char.IsAsciiDigit segment[0] then 
                "_" + segment
                else segment
        )
        |> String.concat ".")
        terminal
let project_directory = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Rdf_Vocabulary\"
let namespace_directory_path_from_namespace_name namespace_name =
    ensure_path (Path.Combine(project_directory, iriToRelativePath namespace_name))
    

module IriDocs = 
    open Xml_Documentation_Comments
    let xmldoc (comments:string array)(iri:string) =
        let comment = comments |> String.concat "\n"
        summary {
            sprintf "\n%s\n" comment 
            see { 
                FSharp.ViewEngine.Html._href iri
                "\n"
                }
        
        }
        |> Render.toXElement
        |> fun xelement -> xelement.ToString()
        |> fun xelement_string -> xelement_string.Split("\n")
// TODO keep parity with real namespace

let my_namespace = "DoxAletheia"

let generate_vocabulary (rdf_namespace_name: string) (rdf_sources: string)(label_override:bool) =
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
        Oak() {
            Namespace(rdfsharp_namespace rdf_namespace_name) {
                Open($"{my_namespace}.Rdf_Vocabulary")
                Module(prefix_label){
                    Value("_namespace_name",String(rdf_namespace_name))

                    for iri_string, labels, comments in term_label_comments do
                        let local_part = iri_string[rdf_namespace_name.Length..]

                        let property_name =
                            match rdf_namespace_name, labels with
                            | "", labels when labels.Length > 0 -> labels.[0]
                            | _ -> local_part
                        Value(property_name, $"Namespaced_IRI.parse _namespace_name \"{local_part}\"")
                        |> _.xmlDocs(IriDocs.xmldoc comments iri_string)


                }

            }
        }
        |> Gen.mkOak
        |> Gen.run
    let fs_directory = namespace_directory_path_from_namespace_name rdf_namespace_name
    let fs_file = Path.Combine(fs_directory, $"{prefix_label}.fs")

    File.WriteAllText(fs_file,fs_text)
    


generate_vocabulary "http://www.w3.org/1999/02/22-rdf-syntax-ns#" @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\1999\02\22-rdf-syntax-ns\hash\rdf.ttl" false

