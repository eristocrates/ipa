module DoxAletheia.Vocabulary
open System
open System.Globalization
open System.Text
open System.IO
open System.Linq
open System.Xml
open System.Collections

open System.IO.Compression

open Fabulous.AST
open Fantomas.Core.SyntaxOak

open type Fabulous.AST.Ast
open FsHttp

open FSharp.Data
open FSharp.Data.Adaptive.Transaction
open FSharp.Data
open FSharp.HashCollections

open FSharp.Collections.ParallelSeq
open Swensen.Unquote.Assertions

open FSharp.Json

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF.Query.Datasets
open VDS.RDF.Storage
open VDS.RDF.Query.Builder
open VDS.RDF.Query
open VDS.RDF.Query.Patterns





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

let should_overwrite = true
let error_lines = new ResizeArray<string>()
let in_memory_dataset = new InMemoryDataset(new DiskDemandTripleStore(), true, false)
let fibo_substring = @"https\spec.edmcouncil.org\fibo"


let rdf_type = Prefixed_Name(rdf,"type") |> PrefixedName
let voaf_vocabulary = Prefixed_Name(voaf,"Vocabulary") |> PrefixedName
    

let vann_preferredNamespacePrefix = Prefixed_Name(vann,"preferredNamespacePrefix") |> PrefixedName

let vann_preferredNamespaceUri = Prefixed_Name(vann,"preferredNamespaceUri") |> PrefixedName

let dcat_distribution = Prefixed_Name(prefix_map["http://www.w3.org/ns/dcat#"],"distribution") |> PrefixedName
    

let dcat_keyword = Prefixed_Name(prefix_map["http://www.w3.org/ns/dcat#"],"keyword") |> PrefixedName
    


let rdfs_label = Prefixed_Name(rdfs,"label") |> PrefixedName
    

let rdfs_comment = Prefixed_Name(rdfs,"comment") |> PrefixedName
    





module IriDocs = 
    open Xml_Documentation_Comments
    let xmldoc (rdf_classes:Iri array)(comments:string array)(labels:string array)(iri:Iri) =
        try
            [|
                summary {
                    if iri.curie <> iri.lexical_form then 
                        para { iri.curie }
                    "\n"
                    }

                remarks {
                    for rdf_class in rdf_classes do 
                        para { rdf_class.curie }
                    "\n"
                    for comment in comments do
                        para { comment }
                    "\n"
                    if labels.Length > 0 then
                        "labels"
                        for label in labels do
                            para { label }
                    "\n"
                    }
                seealso { 
                        FSharp.ViewEngine.Html._href iri.lexical_form 
                        iri.lexical_form
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
            error_lines.Add(sprintf "xmldoc for iri %s comments %A labels %A failed with %s" iri.lexical_form comments labels err.Message)
            [||]

    

let graph_files = 
    Folder.Vocabulary.descendant_files "*.ttl"
    |> Array.filter (fun file_path -> not (file_path.Contains(fibo_substring) ))
graph_files
|> Array.iteri (fun file_index file_path -> 
    printfn "found file_path %s" file_path
    let graph_file =  PathInfo.from_string file_path

    let namespace_name = 
        match graph_file.parent_directory.FullName[Folder.Vocabulary.path.Length+1..] |> relative_path_to_iri with 
        | namespace_name when namespace_name.StartsWith("http://purl.org/NET") -> namespace_name.ToLowerInvariant()
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
            let comment_pattern =  !> subject_variable --- rdfs_comment --> comment_varible
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
            let label_pattern =  !> subject_variable --- rdfs_label --> label_variable
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
                                    |> Array.choose (fun (iri_subject,comment) -> 
                                        if iri_subject = iri.lexical_form then 
                                            Some comment
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


