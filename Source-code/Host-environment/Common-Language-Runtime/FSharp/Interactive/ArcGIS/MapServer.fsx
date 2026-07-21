#time on
fsi.PrintLength <- 30

open System
open System.IO
open System.Reflection
open System.Reflection.Emit
open System.Diagnostics
open Microsoft.FSharp.Reflection
open System.Collections.Generic



#r "nuget: XParsec"
#r "nuget: NeatIntervals"
#r "nuget: FRange"
#r "nuget: UUIDNext"
#r "nuget: CommunityToolkit.HighPerformance"
#r "nuget: FSharp.Data"
#r "nuget: FSharp.Data.Adaptive"
#r "nuget: FSharp.HashCollections"
#r "nuget: dotNetRdf"
#r "nuget: Yog.FSharp"
#r "nuget: QuikGraph"
#r "nuget: QuikGraph.Serialization"
#r "nuget: QuikGraph.Graphviz"
#r "nuget: QuikGraph.Data"
#r "nuget: QuikGraph.MSAGL"
#r "nuget: QuikGraph.Petri"
#r "nuget: FSharp.Json"
#r "nuget: FSharp.ViewEngine"
#r "nuget: Fss-lib.Core"
#r "nuget: Fabulous.AST"
#r "nuget: HtmlToOpenXml.dll"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Unicodepoint\obj\Release\net10.0"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Interval_Range\obj\Release\net10.0"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Ergonomic_Extensions\obj\Release\net10.0"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\ParserCombinator\obj\Release\net10.0"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Rdf_Registry\obj\Release\net10.0"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Rdf_Vocabulary\obj\Release\net10.0"
#r "Unicodepoint.dll"
#r "Interval_Range.dll"
#r "Ergonomic_Extensions.dll"
#r "ParserCombinator.dll"
#r "Rdf_Registry.dll"
#r "Rdf_Vocabulary.dll"
open DoxAletheia
open StringExtensions
open HtmlErgonomics
open Rdf_Shorthand
open Rdf_Document

open http.www.w3.org._1999._02._22_rdf_syntax_ns.hash
open http.www.w3.org._2000._01.rdf_schema.hash
open http.www.w3.org._2002._07.owl.hash
open http.www.w3.org._2001.XMLSchema.hash
open http.xmlns.com.foaf._0._1.slash



#r "nuget: Esri.ArcGISRuntime, 300.0.0"

open Esri.ArcGISRuntime
open Esri.ArcGISRuntime.Data
open Esri.ArcGISRuntime.Portal
open Esri.ArcGISRuntime.Mapping

#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq

open FSharp.Data
open FSharp.Data.Adaptive

open VDS.RDF.Data.DataTables
open VDS.RDF.Parsing.Tokens



open Fabulous.AST
open Fantomas.Core.SyntaxOak

open type Fabulous.AST.Ast


open type Html_Tag

open FSharp.ViewEngine
open Fss.Types
#r "nuget: CaseConverter"
open CaseConverter

// RDFa Core Initial Context
// https://www.w3.org/2011/rdfa-context/rdfa-1.1

// "Activity Vocabulary"                               , "Activity Vocabulary"                                                  , "W3C Recommendation"
open https.www.w3.org.ns.activitystreams.hash
// "Metadata for Tabular Data"                         , "Metadata Vocabulary for Tabular Data"                                 , "W3C Recommendation"
open http.www.w3.org.ns.csvw.hash
// "Data Catalog Vocabulary"                           , "Data Catalog Vocabulary (DCAT)"                                       , "W3C Recommendation"
open http.www.w3.org.ns.dcat.hash
// "Data Quality Vocabulary"                           , "Data               on the Web Best Practices: Data Quality Vocabulary", "W3C WG Note"
open http.www.w3.org.ns.dqv.hash
// GRDDL                                               , "Gleaning Resource Descriptions from Dialects of Languages (GRDDL)"    , "W3C Recommendation"
open http.www.w3.org._2003.g.data_view.hash
// "JSON-LD"                                           , "JSON-LD 1.1, A JSON-based Serialization for Linked Data"              , "W3C Recommendation"
open http.www.w3.org.ns.json_ld.hash
// "Linked Data Platform Vocabulary"                   , "Linked Data Platform 1.0"                                             , "W3C Recommendation"
open http.www.w3.org.ns.ldp.hash
// "Ontology for Media Resources"                      , "Ontology for Media Resources 1.0"                                     , "W3C Recommendation"
open http.www.w3.org.ns.ma_ont.hash
// "Web Annotation Vocabulary"                         , "Web Annotation Vocabulary"                                            , "W3C Recommendation"
open http.www.w3.org.ns.oa.hash
// "ODRL Vocabulary & Expression 2.2"                  , "ODRL Vocabulary & Expression 2.2"                                     , "W3C Recommendation"
open http.www.w3.org.ns.odrl._2.slash
// Organizations                                       , "The Organization Ontology"                                            , "W3C Recommendation"
open http.www.w3.org.ns.org.hash
// OWL                                                 , "OWL Overview"                                                         , "W3C Recommendation"
open http.www.w3.org._2002._07.owl.hash
// "Provenance Vocabulary"                             , "Provenance Ontology"                                                  , "W3C Recommendation"
open http.www.w3.org.ns.prov.hash
// "Data Cubes"                                        , "The RDF Data Cube Vocabulary"                                         , "W3C Recommendation"
open http.purl.org.linked_data.cube.hash
// RDF                                                 , "RDF Semantics"                                                        , "W3C Recommendation"
open http.www.w3.org._1999._02._22_rdf_syntax_ns.hash
// "RDFa Vocabulary"                                   , "RDFa Core 1.1"                                                        , "W3C Recommendation"
open http.www.w3.org.ns.rdfa.hash
// "RDF Schema"                                        , "RDF Semantics"                                                        , "W3C Recommendation"
open http.www.w3.org._2000._01.rdf_schema.hash
// R2RML                                               , "R2RML: RDB to RDF Mapping Language"                                   , "W3C Recommendation"
open http.www.w3.org.ns.r2rml.hash
// "SPARQL 1.1 Service Description"                    , "SPARQL 1.1 Service Description"                                       , "W3C Recommendation"
open http.www.w3.org.ns.sparql_service_description.hash
// "SKOS Core"                                         , "SKOS Simple Knowledge Organization System Reference"                  , "W3C Recommendation
open http.www.w3.org._2004._02.skos.core.hash
// "SKOS eXtension for Labels"                         , "SKOS Simple Knowledge Organization System Reference"                  , "W3C Recommendation"
open http.www.w3.org._2008._05.skos_xl.hash
// "Semantic Sensor Network Ontology"                  , "Semantic Sensor Network Ontology"                                     , "W3C Recommendation"
open http.www.w3.org.ns.ssn.slash
// "Sensor, Observation, Sample, and Actuator Ontology", "Semantic Sensor Network Ontology"                                     , "W3C Recommendation"
open http.www.w3.org.ns.sosa.slash
// "Time Ontology"                                     , "Time Ontology in OWL"                                                 , "W3C Recommendation"
open http.www.w3.org._2006.time.hash
// VoID                                                , "Describing Linked Datasets with the VoID Vocabulary"                  , "W3C Interest Group Note"
open http.rdfs.org.ns._void.hash
// POWDER                                              , "Protocol for Web Description Resources (POWDER): Formal Semantics"    , "W3C Recommendation"
open http.www.w3.org._2007._05.powder.hash
// "POWDER-S"                                          , "Protocol for Web Description Resources (POWDER): Formal Semantics"    , "W3C Recommendation"
open http.www.w3.org._2007._05.powder_s.hash
// "RDFa Default Prefix"                               , "RDFa Core 1.1"                                                        , "W3C Recommendation"
open http.www.w3.org._1999.xhtml.vocab.hash
// "XML Reserved Prefix"                               , "Namespaces in XML 1.0"                                                , "W3C Recommendation"
open http.www.w3.org.XML._1998.namespace_.hash
// "XML Schema Datatypes"                              , "XML Schema Part 2: Datatypes Second Edition"                          , "W3C Recommendation"
open http.www.w3.org._2001.XMLSchema.hash
// ccREL                                          , "ccREL: The Creative Commons Rights Expression Language"
open http.creativecommons.org.ns.hash 
// "Common Tag Ontology"                          , "Common Tag Specification"
open http.commontag.org.ns.hash 
// "Dublin Core Metadata Terms"                   , "DCMI Metadata Terms"
open http.purl.org.dc.terms.slash 
// "Dublin Core Metadata Terms"                   , "DCMI Metadata Terms"
open http.purl.org.dc.terms.slash 
// "Dublin Core Metadata Element Set, Version 1.1", "Dublin Core Metadata Element Set, Version 1.1"
open http.purl.org.dc.elements._1._1.slash 
// FOAF                                           , "FOAF Vocabulary Specification"
open http.xmlns.com.foaf._0._1.slash 
// "GoodRelations Ontology"                       , "GoodRelations Language Reference"
open http.purl.org.goodrelations.v1.hash 
// "iCalendar terms in RDF"                       , "iCalendar terms in RDF"
open http.www.w3.org._2002._12.cal.ical.hash 
// "Facebook's Open Graph protocol"               , "Open Graph Protocol"
open http.ogp.me.ns.hash 
// "RDF Review Vocabulary"                        , "RDF Review Vocabulary"
open http.purl.org.stuff.rev.hash 
// "SIOC Core Ontology"                           , "SIOC Core Ontology Specification"
open http.rdfs.org.sioc.ns.hash 
// "vCard in RDF"                                 , "Representing vCard Objects in RDF"
open http.www.w3.org._2006.vcard.ns.hash 
// "The Schema.org vocabulary"                    , "Full Schema.org documentation"
open https.schema.org.slash 


let global_prefix_map =     
    JsonProvider<prefix_file_path>.Load(prefix_file_path).Mappings
    |> Array.map (fun Mapping -> Mapping.NamespaceName, Mapping.PrefixLabel)
    |> Map.ofArray









ArcGISRuntimeEnvironment.Initialize()
let test_name = "test_graph"
let test_directory = Path.Combine(__SOURCE_DIRECTORY__, test_name)




let a = rdf.type_

module dbug =
    let _namespace_name = "https://eristocrates.dev/ontology/dbug/"

    let _prefix (local_name:string) =
        Namespaced_IRI.parse _namespace_name local_name.low_lined
        |> NamespacedName

    let this_ = _prefix "this"
    let example = _prefix "example"

    let Alice = _prefix "Alice"
    let Bob = _prefix "Bob"



module Esri = 

      module ArcGISRuntime = 

        let _namespace_name = "https://developers.arcgis.com/net/api-reference/api/net/Esri.ArcGISRuntime/"
        let _prefix (local_name:string) =
            Namespaced_IRI.parse _namespace_name local_name.low_lined
            |> NamespacedName
        let service_info = _prefix "service_info"
        let sublayer = _prefix "sublayer"





module interraster = 
    module Catalog = 
        let pjson = JsonProvider<"https://interraster.leoncountyfl.gov/interraster/rest/services?f=pjson">.Load "https://interraster.leoncountyfl.gov/interraster/rest/services?f=pjson"

        module MapServices = 
            let _namespace_name = $"https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/"

            let _prefix (local_name:string) =
                Namespaced_IRI.parse _namespace_name local_name.low_lined
                |> NamespacedName
            module LCPW_OverlayStormwaterInfrastructure_D_WM =
                let pjson = JsonProvider<"https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer?f=pjson">.Load "https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer?f=pjson"
                let MapServer =
                        ArcGISMapImageLayer(Uri( "https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer" ))
        
        
open interraster.Catalog.MapServices.LCPW_OverlayStormwaterInfrastructure_D_WM
open VDS.RDF
open VDS.RDF.Query.Datasets
open VDS.RDF.Query
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Patterns
MapServer.LoadTablesAndLayersAsync()
    |> Async.AwaitTask
    |> Async.RunSynchronously

            
type System.Type with 
    member this.GroupedProperties = 
        this.GetProperties()
        |> Array.groupBy (fun Property -> Property.PropertyType)
        |> Array.sortBy (fun (PropertyType, Properties ) -> PropertyType.FullName)
        |> Array.collect (fun (PropertyType, Properties ) ->
            Properties |> Array.map (fun Property -> sprintf "%s : %s" Property.Name PropertyType.FullName) |> Array.insertAt 0 "\n"
            )
    member this.PropertyTypeFullNames = 
        this.GetProperties()
        |> Array.map (fun Property -> Property.PropertyType.FullName )
        |> Array.distinct
        |> Array.sort
    member this.SystemPropertyTypes = 
        this.PropertyTypeFullNames
        |> Array.filter (fun PropertyTypeFullName -> PropertyTypeFullName.StartsWith("System") && not (PropertyTypeFullName.StartsWith("System.Collections")) )
    member this.CollectionPropertyTypes = 
        this.PropertyTypeFullNames
        |> Array.filter (fun PropertyTypeFullName -> PropertyTypeFullName.Contains("List") )


let inline predicates (value:'Type) =  

        value.GetType().GetProperties()
        |> Array.filter (fun Property -> Property.GetValue(value) <> null)
        |> Array.map (fun Property -> 
            let predicate_local_name = Converters.ToSnakeCase Property.Name
            Esri.ArcGISRuntime._prefix predicate_local_name 
        )
        |> Array.toList
        

let inline predicateObjectList (value:'Type) =  

        value.GetType().GetProperties()
        |> Array.filter (fun Property -> Property.GetValue(value) <> null)
        |> Array.choose (fun Property -> 
            let predicate_local_name = Converters.ToSnakeCase Property.Name
            let key_predicate = Esri.ArcGISRuntime._prefix predicate_local_name
            let obj_value = Property.GetValue(value)
            match obj_value with 
            |  :? System.String as value when predicate_local_name = "id" -> Some (key_predicate ->- value .*^ xsd.ID)
            |  :? System.String as value when not (String.IsNullOrWhiteSpace(value)) -> Some (key_predicate ->- Literal.autotyped value)
            | :? Boolean as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? (Byte array) as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? Byte as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? DateOnly as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? DateTime as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? DateTimeOffset as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? Decimal as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? Double as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? Int16 as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? Int32 as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? Int64 as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? SByte as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? Single as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? TimeOnly as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? TimeSpan as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? UInt16 as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? UInt32 as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? UInt64 as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? Uri as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? Guid as value -> Some(key_predicate ->- Literal.autotyped value)
            | :? LoadStatus as value -> Some(key_predicate ->- SimpleLiteral(value.ToString()))
            | _ -> None

        )
        |> Array.toList

let inline GroupedProperties (value:'Type) = 
        value.GetType().GetProperties()
        |> Array.filter (fun Property -> Property.GetValue(value) <> null && not (Property.PropertyType.IsValueType))
        |> Array.groupBy (fun Property -> Property.PropertyType)
        |> Array.sortBy (fun (PropertyType, Properties ) -> PropertyType.FullName)
        |> Array.collect (fun (PropertyType, Properties ) ->
            Properties |> Array.map (fun Property -> sprintf "%s : %s" Property.Name PropertyType.FullName) |> Array.insertAt 0 "\n"
            )
let inline GroupedValues (value:'Type) = 
        value.GetType().GetProperties()
        |> Array.filter (fun Property -> Property.GetValue(value) <> null && Property.PropertyType.IsValueType)
        |> Array.groupBy (fun Property -> Property.PropertyType)
        |> Array.sortBy (fun (PropertyType, Properties ) -> PropertyType.FullName)
        |> Array.collect (fun (PropertyType, Properties ) ->
            Properties |> Array.map (fun Property -> sprintf "%s : %s" Property.Name PropertyType.FullName) |> Array.insertAt 0 "\n"
            )



type ArcGISMapImageLayer with 
    member this._namespace_name = $"https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/{this.Name.low_lined}/"
    member  this._prefix (local_name:string) =
            Namespaced_IRI.parse this._namespace_name local_name.low_lined
            |> NamespacedName
    member this.named_individual = this._prefix "MapServer"
    member this.owl_class = Esri.ArcGISRuntime._prefix (this.GetType().FullName)

    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
        
type ArcGISServices.ArcGISMapServiceInfo with 
    member this.owl_class = Esri.ArcGISRuntime._prefix (this.GetType().FullName)
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
        
type ArcGISServices.ArcGISMapServiceSublayerInfo with 
    member this.owl_class = Esri.ArcGISRuntime._prefix (this.GetType().FullName)
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
        

type Geometry.Envelope with 
    member this.owl_class = Esri.ArcGISRuntime._prefix typeof<Geometry.Envelope>.FullName
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this

type ArcGISMapImageSublayer with 
    member this._namespace_name = $"https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/{this.Name.low_lined}/"
    member  this._prefix (local_name:string) =
            Namespaced_IRI.parse this._namespace_name local_name.low_lined
            |> NamespacedName
    member this.named_individual = MapServer._prefix this.Name
    member this.owl_class = Esri.ArcGISRuntime._prefix (this.GetType().FullName)
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
// TODO consider making this codegen into clipboard, or maybe even a code quotation
// TODO try getting layers and sparql querying!





let Layers = 
    MapServer.Sublayers
    |> PSeq.collect (fun Sublayer -> Sublayer.Sublayers )
    |> PSeq.append MapServer.Sublayers
    |> PSeq.toArray
    |> Array.Parallel.map (fun Sublayer -> 
          match Sublayer with
            | :? ArcGISMapImageSublayer as layer -> layer
            | layer ->
                failwithf
                    "Expected ArcGISMapImageSublayer, but received %s."
                    (layer.GetType().FullName)
    )

let layer_individuals = 
    Layers 
    |> Array.map (fun Layer -> Layer.named_individual)
    |> Array.toList

MapServer.ServiceInfo.GroupedValues
Layers[1].MapServiceSublayerInfo

Layers[1].MapServiceSublayerInfo.GroupedProperties
|> String.concat "\n"
|> Console.WriteLine

MapServer.ImageFormat

typeof<Esri.ArcGISRuntime.ArcGISServices.ArcGISMapServiceInfo>
typeof<ArcGISMapImageSublayer>

let formula =
    !< owl.NamedIndividual --- a -!> MapServer.named_individual
    -~| MapServer.predicateObjectList
    -~| MapServer.ServiceInfo.predicateObjectList
    -~| [Esri.ArcGISRuntime.sublayer ->| layer_individuals]
    --- a
    -->/ MapServer.owl_class
    --- a
    --> owl.Class
    -*| [for Layer in Layers -> !> Layer.named_individual -~|> Layer.predicateObjectList]
    
    
    // -!| MapServer.ServiceInfo.predicates --- rdfs.subPropertyOf --> Esri.ArcGISRuntime.service_info



formula |> write_draft  test_directory test_name global_prefix_map


let igraph = Formula.to_igraph formula
let dataset = new InMemoryDataset(igraph)
let sparql = new LeviathanQueryProcessor(dataset)

let construct = QueryBuilder.Construct()



let s = !? "s"
let p = !? "p"
let o = !? "o"

let pattern_builder = new TriplePatternBuilder(igraph.NamespaceMap)
let spo = !> s --- a --> o

type SparqlResultSet with 
    member this.variable_results (rdf_variable:Rdf_Variable) = 
        this.Results
        |> Seq.map (fun result -> result.Item rdf_variable.as_raw_string |> Rdf_Term.from_inode)
        |> Seq.toArray
let SELECT_ALL () : ISelectBuilder =
    QueryBuilder.SelectAll()
let SELECT
    (variables: Rdf_Variable seq)
    : ISelectBuilder
    =
    let variable_names =
        variables
        |> Seq.map (fun variable ->
            variable.as_raw_string
        )
        |> Seq.toArray

    QueryBuilder.Select(variable_names)

let CONSTRUCT (formula:Formula) = 

    QueryBuilder.Construct(
        Action<IDescribeGraphPatternBuilder>(
            fun construct_template ->
                construct_template.Where(pattern_builder |> formula.as_graph_pattern)
                |> ignore
        )
    )
let ASK () : IQueryBuilder =
    QueryBuilder.Ask()

    
let DISCOVER
    (variables: Rdf_Variable seq)
    : IDescribeBuilder
    =
    variables
    |> Seq.map (fun variable ->
        variable.as_rendered_string
    )
    |> Seq.toArray
    |> QueryBuilder.Describe

    
let DESCRIBE
    (iris: IRIREF seq)
    : SparqlQuery
    =
    iris
    |> Seq.map (fun iri -> iri.as_uri)
    |> Seq.toArray
    |> QueryBuilder.Describe
    |> fun builder -> builder.BuildQuery()


let repair_describe_variables
    (query: SparqlQuery)
    : SparqlQuery
    =
    if query.QueryType = SparqlQueryType.Describe then

        let query_variables =
            query.Variables
            :?> ICollection<SparqlVariable>

        query.DescribeVariables
        |> Seq.filter (fun token ->
            token.TokenType = Token.VARIABLE
        )
        |> Seq.iter (fun token ->

            let variable_name =
                token.Value.Substring(1)

            let already_registered =
                query_variables
                |> Seq.exists (fun variable ->
                    variable.Name = variable_name
                )

            if not already_registered then
                query_variables.Add(
                    SparqlVariable(variable_name, true)
                )
        )

    query
let WHERE
    (formula: Formula)
    (query_builder: IQueryBuilder)
    : SparqlQuery
    =
    query_builder
        .Where(pattern_builder |> formula.as_graph_pattern)
        .BuildQuery()
    |> repair_describe_variables    
let select_query = 
        sparql.ProcessQuery( 
            SELECT_ALL()
            |> WHERE (!> s --- a --> o)
        ) :?> SparqlResultSet


select_query.variable_results s
|> Array.map (fun term -> term.as_rendered_string ":" global_prefix_map)


 // |> Turtle.write_igraph test_directory "results"

sparql.ProcessQuery( 
    CONSTRUCT (!> s --- dbug.this_ --> dbug.example)
    |> WHERE (!> s --- Esri.ArcGISRuntime._prefix "id" --> "7" .*^ xsd.long)
) :?> IGraph |> Turtle.write_igraph test_directory "results"
let ask_query = 
    (sparql.ProcessQuery( 
        ASK()
        |> WHERE (!> s --- a --> o)
    ) :?> SparqlResultSet).Result



sparql.ProcessQuery( 
    DISCOVER [s]
    |> WHERE (!> s --- Esri.ArcGISRuntime._prefix "id" --> "7" .*^ xsd.long)
) :?> IGraph |> Turtle.write_igraph test_directory "results"

sparql.ProcessQuery( 
    DESCRIBE [MapServer._prefix "Inlet"]
    // |> WHERE (!> s --- p --> o)
) :?> IGraph |> Turtle.write_igraph test_directory "results"


let query =
    DISCOVER [ s ]
    |> WHERE (
        !> s
        --- Esri.ArcGISRuntime._prefix "id"
        --> "7" .*^ xsd.long
    )

query.DescribeVariables
|> Seq.iter (fun token ->
    printfn "Describe token: %A" token.Value
)

query.Variables
|> Seq.iter (fun variable ->
    printfn "Query variable: %s, result: %b"
        variable.Name
        variable.IsResultVariable
)















module MapServer = 
    let fs (map_server:ArcGISMapImageLayer) = 
        Oak() {
          Namespace("interraster"){
            Open("System")
            Open("System.IO")
            Module(map_server.Name) {
              Value("test", Ast.String("test"))

            }
          }
        }
        |> Gen.mkOak
        |> Gen.run    






(*

let Layers = 
    map_server.Sublayers
    |> PSeq.collect (fun Sublayer -> Sublayer.Sublayers )
    |> PSeq.append map_server.Sublayers
    |> PSeq.toArray
    |> Array.Parallel.map (fun Sublayer -> 
          match Sublayer with
            | :? ArcGISMapImageSublayer as layer -> layer
            | layer ->
                failwithf
                    "Expected ArcGISMapImageSublayer, but received %s."
                    (layer.GetType().FullName)
    
    )

let test_layer = Layers |> Array.randomChoice


test_layer
test_layer.MapServiceSublayerInfo
test_layer.Table


let all_features_query = QueryParameters()
all_features_query.WhereClause <- "1 = 1"
all_features_query.ReturnGeometry <- true

let feature_result =
    test_table.QueryFeaturesAsync(
        all_features_query,
        QueryFeatureFields.LoadAll
    )
    |> Async.AwaitTask
    |> Async.RunSynchronously

let features =
    feature_result
    |> Seq.toArray
    
    *)
