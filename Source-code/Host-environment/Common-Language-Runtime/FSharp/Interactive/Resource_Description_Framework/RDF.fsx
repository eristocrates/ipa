#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Resource_Description_Framework\RDFa_Initial_Context.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Resource_Description_Framework\Ad_Hoc.fsx"
#r "nuget: FSharp.UMX"

open FSharp.UMX

let namespaces =

    Array.concat [|

                    RDFa_Initial_Context.namespaces
                    Ad_Hoc.namespaces

                     |]
    |> Map.ofArray

module BCP47 =
    [<Measure>]
    type langtag
// TODO replace units
// https://www.w3.org/TR/rdf12-concepts/#rdf-documents
module Concepts_and_Data_Model =

    [<Measure>]
    type prefix

    [<Measure>]
    type blank_node_identifier


    type Literal_Value = unit
    type Lexical_Space = unit
    type Value_Space = unit

    type Datatype =
        {

          lexical_space: Lexical_Space
          value_space: Value_Space

         }

    type IRI_Owner = unit
    type Proposition = Proposition of bool



    type Resource =
        | FromLiteralValue of Literal_Value
        | FromProperty of Property
        | FromProposition of Proposition


    and Property = unit


    type Entity = Resource


    type IRI =
        {

          denotes: Resource
          owner: IRI_Owner

         }

    type Resolved_IRI = Resolved_IRI of IRI
    type Relative_IRI = Relative_IRI of IRI

    type Prefix =
        | Preferred_Namespace_Prefix of string<prefix>
        | Personal_Namespace_Prefix of string<prefix>

    type Vocabulary =
        {

          namespace_iri: IRI
          namespace_prefixes: Prefix array
          dereferent: IRI

         }

    type Skolem_IRI = unit

    type Blank_Node =

        {

          identifier: string<blank_node_identifier>
          well_known_genid: Skolem_IRI option

         }

    [<Measure>]
    type Unicode_Scalar_Value

    type string = int<Unicode_Scalar_Value> array

    type Simple_Literal =
        {

          lexical_form: string
          datatype: Datatype
          literal_value: Literal_Value

         }

    type Language_Tag = string<BCP47.langtag>

    type Language_Tagged_String =
        {

          lexical_form: string
          datatype: Datatype
          language_tag: Language_Tag

         }

    [<RequireQualifiedAccess>]
    type Base_Direction =
        | ltr
        | rtl

    type Directional_Language_Tagged_String =
        {

          lexical_form: string
          datatype: Datatype
          language_tag: Language_Tag
          base_direction: Base_Direction

         }

    type Literal =
        | FromSimpleLiteral of Simple_Literal
        | FromLanguageTaggedString of Language_Tagged_String
        | FromDirectionalLanguageTaggedString of Directional_Language_Tagged_String


    [<RequireQualifiedAccess>]
    type Subject =
        | FromIRI of IRI
        | FromBlankNode of Blank_Node

    [<RequireQualifiedAccess>]
    type Predicate = FromIRI of IRI

    [<RequireQualifiedAccess>]
    type Object =
        | FromIRI of IRI
        | FromBlankNode of Blank_Node
        | FromLiteral of Literal
        | FromTriple of Triple

    and Triple =
        { subject: Subject
          predicate: Predicate
          object: Object
          denotes: Proposition }

    type Asserted_Triple = Asserted_Triple of Triple

    type Symmetric_Triple =
        { subject: Object
          predicate: Predicate
          object: Object
          denotes: Proposition }

    type Generalized_Triple =
        { subject: Object
          predicate: Object
          object: Object
          denotes: Proposition }

    type Triple_Term = Triple_Term of Triple

    type Basic_Term =
        | FromIRI of IRI
        | FromLiteral of Literal
        | FromBlankNode of Blank_Node

    type Term =
        | FromBasicTerm of Basic_Term
        | FromTripleTerm of Triple_Term


    type Triple_Reification =
        { reifier: Subject
          reified: Triple_Term }

    type Triple_Annotation =
        { reifier: Subject
          annotated: Asserted_Triple }

    type Reifying_Triple =
        | FromTripleReification of Triple_Reification
        | FromTripleAnnotation of Triple_Annotation

    type Statement =

        {

          triple: Triple
          property: Property

         }


    type Graph =
        {

          triple_set: Set<Triple>

         }

    type Symmetric_Graph =
        {

          triple_set: Set<Symmetric_Triple>

         }

    type Entailment_Regieme =
        {

          graph_entailment: Graph -> Graph -> bool
          graph_equivalence: Graph -> Graph -> bool
          graph_inconsistency: Graph -> bool

         }



    type Default_Graph = Default_Graph of Graph

    type Graph_Name =
        | FromIRI of IRI
        | FromBlankNode of Blank_Node

    type Named_Graph =
        {

          name: Graph_Name
          graph: Graph

         }

    type source =
        {

          iri: IRI option
          snapshot: unit -> Graph

         }

    type Node =
        | FromIRI of IRI
        | FromLiteral of Literal
        | FromBlankNodes of Blank_Node
        | FromTripleTerm of Triple_Term


    type Dataset =
        { default_graph: Default_Graph
          named_graphs: Set<Named_Graph> }

    type Data =
        | FromGraph of Graph
        | FromDataset of Dataset

    type Conformance =
        | Full
        | Basic

    [<RequireQualifiedAccess>]
    type Version =
        | _1_1
        | _1_2_basic
        | _1_2


    type Syntax =
        | RDFXML
        | N3
        | NTriples
        | NQuads
        | Turtle
        | RDFa
        | JSONLD


    type Document =
        {

          data: Data
          syntax: Syntax

         }

    type Lexical_Space_To_Value_Space =
        {

          mapping: Lexical_Space -> Value_Space

         }
