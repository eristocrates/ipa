open System
open System.IO

#r "nuget: FSharp.UMX"
open FSharp.UMX


#r "nuget: dotNetRdf"
open VDS.RDF





let default_graph = new ThreadSafeGraph()
let __SOURCE_FILE_PATH__ = Path.Combine(__SOURCE_DIRECTORY__, __SOURCE_FILE__)

let BASE (uri_string: string) =
    let baseURI = UriFactory.Create(uri_string)
    default_graph.BaseUri <- baseURI
    baseURI

let baseURI = BASE __SOURCE_FILE_PATH__

[<Measure>]
type resolved_iri

[<Measure>]
type relative_iri

[<Measure>]
type prefix

[<Measure>]
type local_name

[<Measure>]
type blank_node_identifier

let factory_uri (uri_string: string<resolved_iri>) = UriFactory.Create(UMX.untag uri_string)

let resolve_relative_iri (base_iri_string: string) (relative_iri_string: string<relative_iri>) : string<resolved_iri> =
    % $"{base_iri_string}{UMX.untag relative_iri_string}"




// [4] 	prefixID 	::= 	'@prefix' PNAME_NS IRIREF '.'
type PrefixID = PrefixID of (string -> string -> (string -> IUriNode))

type BaseDirective = (string -> Uri)
// [5] 	versionSpecifier 	::= 	STRING_LITERAL_QUOTE
type VersionSpecifier = VersionSpecifier of string
// [4] 	versionDirective 	::= 	'VERSION' versionSpecifier
type VersionDirective = VERSION of VersionSpecifier
type Directive =
    | FromPrefixID of PrefixID
    | FromBaseDirective of BaseDirective
    | FromVersionDirective of VersionDirective
// [2] 	statement 	::= 	directive | triple
type Statement =
    | FromDirective of Directive
    | FromTriple of Triple
// [1] 	ntriplesDoc 	::= 	statement? (EOL statement)* EOL?
type RDF_Document = NTriplesDoc of Statement array
// [3] 	directive 	::= 	versionDirective
// [3] 	directive 	::= 	prefixID | base | version | sparqlPrefix | sparqlBase | sparqlVersion

type PrefixedName =
    {

      prefix: string
      local_name: string

     }
    member this.iri_string: string<resolved_iri> =
        % $"{namespaces.Item this.prefix}{this.local_name}"
// [25] 	iri 	::= 	IRIREF | PrefixedName

[<RequireQualifiedAccess>]
type RDF_Iri =
    | FromResolvedIri of string<resolved_iri>
    | FromRelativeIri of string<relative_iri>
    | FromPrefixedName of PrefixedName
//     [6] 	triple 	::= 	subject predicate object '.'
type RDF_Blank_Node = 
  {
    blank_node_identifier: string<blank_node_identifier>
  }
type RDF_Triple =

    { curSubject: RDF_Subject
      curPredicate: RDF_Predicate
      curObject: RDF_Object }
// [7] 	subject 	::= 	IRIREF | BLANK_NODE_LABEL
// [15] 	subject 	::= 	iri | BlankNode | collection


and [<RequireQualifiedAccess>] RDF_Subject =
    | FromRDFIri of RDF_Iri
    | FromBlankNode of RDF_Blank_Node

// [8] 	predicate 	::= 	IRIREF

and [<RequireQualifiedAccess>] RDF_Predicate =
    | FromRDFIri of RDF_Iri
    member this.iri_string =
        match this with
        | FromRDFIri rdf_iri -> rdf_iri.iri_string

// [9] 	object 	::= 	IRIREF | BLANK_NODE_LABEL | literal | tripleTerm
// [17] 	object 	::= 	iri | BlankNode | collection | blankNodePropertyList | literal | tripleTerm | reifiedTriple
and RDF_Object =
    | FromRDFIri of RDF_Iri
    | FromBlankNode of RDF_Blank_Node
    | FromRdfLiteral of RDF_Literal
    | FromTripleTerm of RDF_Triple_Term
// [11] 	triples 	::= 	(subject predicateObjectList) | (blankNodePropertyList predicateObjectList?) | (reifiedTriple predicateObjectList?)
type RDF_Triples =

    { curSubject: RDF_Subject
      predicateObjectList: PredicateObjectList }
// [12] 	predicateObjectList 	::= 	verb objectList (';' (verb objectList)?)*
type PredicateObjectList =
    { verb: RDF_Verb
      object_list: ObjectList }
// [19] 	blankNodePropertyList 	::= 	'[' predicateObjectList ']'
type BlankNodePropertyList = BlankNodePropertyList of PredicateObjectList
// [13] 	objectList 	::= 	object annotation (',' object annotation)*
type ObjectList =
    { curObject: RDF_Object
      annotation: RDF_Annotation option }
// [20] 	collection 	::= 	'(' object* ')'
type RDF_Collection = RDF_Collection of RDF_Object array
// [35] 	annotation 	::= 	(reifier | annotationBlock)*
// [36] 	annotationBlock 	::= 	'{|' predicateObjectList '|}'
type RDF_Annotation =
    | FromReifier of RDF_Reifier
    | FromAnnotationBlock of PredicateObjectList
// [28] 	reifier 	::= 	'~' (iri | BlankNode)?
type RDF_Reifier =
    | FromRDFIri of RDF_Iri
    | FromRDFBlankNode of RDF_Blank_Node
// [14] 	verb 	::= 	predicate | 'a'
[<RequireQualifiedAccess>]
type RDF_Verb =
    | FromRDFPredicate of RDF_Predicate
    member this.iri_string =
        match this with
        | FromRDFPredicate rdf_predicate -> rdf_predicate.iri_string

// todo actually parse this
type IRIREF =
    | Resolved_Iri of string<resolved_iri>
    | Relative_Iri of string<relative_iri>


type Relative_Iri =
    | Relative_Iri of string
    member this.iri_string =
        match this with
        | Relative_Iri iri_string -> iri_string

type RDF_Blank_Node =
    {

      identifier: Blank_Node_Identifier

     }
// https://www.w3.org/TR/rdf12-n-triples/#BNodes
type Blank_Node_Identifier = Blank_Node_Identifier of string

// [10] 	literal 	::= 	STRING_LITERAL_QUOTE (('^^' IRIREF) | LANG_DIR)?
type RDF_Literal =
    | FromSimpleRDFLiteral of Simple_RDF_Literal
    | FromDatatypedRDFLiteral of Datatyped_RDF_Literal
    | FromLanguageTaggedRDFLiteral of Language_Tagged_RDF_Literal
    | FromNumericLiteral of Numeric_RDF_Literal

type Simple_RDF_Literal =
    | Simple_RDF_Literal of string
    | FromNumericRDFLiteral of Numeric_RDF_Literal
    | FromBooleanRDFLiteral of Boolean_RDF_Literal
// [23] 	BooleanLiteral 	::= 	'true' | 'false'
type Boolean_RDF_Literal = Boolean_RDF_Literal of bool

// [21] 	NumericLiteral 	::= 	INTEGER | DECIMAL | DOUBLE
type Numeric_RDF_Literal =
    | FromINTEGER of int
    | FromDECIMAL of decimal
    | FromDOUBLE of double

type Datatyped_RDF_Literal =
    {

      lexical_form: RDF_String
      datatype_iri: Datatype_Iri

     }

type Language_Tagged_RDF_Literal =
    | FromLanguageTaggedString of Language_Tagged_RDF_String
    | FromDirectionalLanguageTaggedString of Directional_Language_Tagged_RDF_String

type Language_Tagged_RDF_String =
    {

      lexical_form: RDF_String
      datatype_iri: Datatype_Iri
      language_tag: BCP47_Tag


     }

type Directional_Language_Tagged_RDF_String =
    {

      lexical_form: RDF_String
      datatype_iri: Datatype_Iri
      language_tag: BCP47_Tag option
      base_direction: Base_Direction


     }

[<RequireQualifiedAccess>]
type Base_Direction =
    | ltr
    | rtl
// TODO add parsing type subtyping
// https://www.rfc-editor.org/rfc/rfc5646#section-2.1
type BCP47_Tag = BCP47_Tag of string

    // TODO figure out if i can actually untag
    member this.iri_string =
        match this with
        | FromResolvedIri resolved_iri_string -> resolved_iri_string
        | FromRelativeIri relative_iri_string -> resolve_relative_iri baseURI.OriginalString relative_iri_string
        | FromPrefixedName prefixed_name -> prefixed_name.iri_string



type Datatype_Iri = Datatype_Iri of string

type Resolved_Iri =
    | Resolved_Iri of string
    member this.iri_string =
        match this with
        | Resolved_Iri iri_string -> iri_string

type RDF_String = RDF_String of Unicode_Scalar_Value array
type Unicode_Scalar_Value = Unicode_Scalar_Value of int
// [11] 	tripleTerm 	::= 	'<<(' subject predicate object ')>>'
type RDF_Triple_Term =
    {

      ttSubject: RDF_Subject
      ttPredicate: RDF_Predicate
      ttObject: RDF_Object

     }
// [29] 	reifiedTriple 	::= 	'<<' rtSubject verb rtObject reifier? '>>'
type RDF_Reified_Triple =
    {

      rtSubject: RTSubject
      verb: RDF_Verb
      rtObject: RTObject
      reifier: RDF_Reifier option

     }
// [30] 	rtSubject 	::= 	iri | BlankNode | reifiedTriple
type RTSubject =
    | FromRDF_Iri of RDF_Iri
    | FromRDFBlankNode of RDF_Blank_Node
    | FromRDFReifiedTriple of RDF_Reified_Triple
// [31] 	rtObject 	::= 	iri | BlankNode | literal | tripleTerm | reifiedTriple
type RTObject =

    | FromRDFIri of RDF_Iri
    | FromBlankNode of RDF_Blank_Node
    | FromRdfLiteral of RDF_Literal
    | FromTripleTerm of RDF_Triple_Term
    | FromRDFReifiedTriple of RDF_Reified_Triple

let bnodeLabels: Map<string, RDF_Blank_Node> = Map.empty


let prefixed_name (prefix: string) (local_name: string) =
    {

      prefix = prefix
      local_name = local_name

    }



let PREFIX (prefix: string) (uri_string: string) =
    let resolved_uri_string: string<resolved_iri> = %uri_string
    default_graph.NamespaceMap.AddNamespace(prefix, factory_uri resolved_uri_string)
    prefixed_name prefix

namespaces
|> Map.toArray
|> Array.iter (fun (prefix, uri) -> default_graph.NamespaceMap.AddNamespace(prefix, UriFactory.Create(uri)))

type ucd =
    static member prefixID = PREFIX "ucd" "http://www.unicode.org/ns/2003/ucd/1.0/"

    static member na = ucd.prefixID "na"

type rdf =
    static member prefixID = PREFIX "rdf" (namespaces.Item "rdf")

let a =
    rdf.prefixID "type"
    |> RDF_Iri.FromPrefixedName
    |> RDF_Predicate.FromRDFIri
// |> RDF_Verb.FromRDFPredicate

let a_test = rdf.prefixID "type"
default_graph.NamespaceMap.GetNamespaceUri a_test.prefix
namespaces.Item a_test.prefix
a_test.iri_string

type colon =
    static member prefixID = PREFIX "" (namespaces.Item "")
    static member this_ = colon.prefixID "this"
    static member example = colon.prefixID "example"

colon.this_
a
colon.example

type bob =
    static member prefixID = PREFIX "bob" "http://example.org/bob#"
    static member me = bob.prefixID "me"

type alice =
    static member prefixID = PREFIX "alice" "http://example.org/alice#"
    static member me = alice.prefixID "me"

type foaf =
    static member prefixID = PREFIX "foaf" "http://xmlns.com/foaf/0.1/"
    static member person = foaf.prefixID "person"
    static member topic_interest = foaf.prefixID "topic_interest"

type schema =
    static member prefixID = PREFIX "schema" "http://schema.org/"
    static member birthDate = schema.prefixID "birthDate"

type xsd =
    static member prefixID = PREFIX "xsd" "http://www.w3.org/2001/XMLSchema#"
    static member date = xsd.prefixID "date"

type dcterms =
    static member prefixID = PREFIX "dcterms" "http://purl.org/dc/terms/title"
    static member title = xsd.prefixID "title"
    static member creator = xsd.prefixID "creator"
    static member subject = xsd.prefixID "subject"

module dbpedia =
    type resource =
        static member prefixID = PREFIX "dbr" "http://dbpedia.org/resource/"
        static member Leonardo_da_Vinci = xsd.prefixID "Leonardo_da_Vinci"

module http =
    module data =
        module europeana =
            module eu =
                let item (relative_path: string) =
                    $"http://data.europeana.eu/item/{relative_path}"

        module www =
            module wikidata =
                module org =
                    module entitiy =
                        [<RequireQualifiedAccessAttribute>]
                        type ID_Prefix =
                            | Q
                            | P
                            | L

                        let entity_id (id_prefix: ID_Prefix) (number: int) =
                            $"http://www.wikidata.org/entity/{id_prefix.ToString()}{string number}"


module UriNode =
    let FromPrefixedName (prefixed_name: PrefixedName) =
        default_graph.CreateUriNode($"{prefixed_name.prefix}:{prefixed_name.local_name}")

    let inline FromRDFTerm<'RDF_Term when 'RDF_Term: (member iri_string: string<resolved_iri>)> (rdf_term: 'RDF_Term) =
        default_graph.CreateUriNode(factory_uri rdf_term.iri_string)


let test: string<resolved_iri> = % "http://www.wikidata.org/entity/Q12418"

let dotnetRdf_Triple =
    Triple(colon.this_ |> UriNode.FromRDFTerm, a |> UriNode.FromRDFTerm, colon.example |> UriNode.FromRDFTerm)


(*

type Triple
Description

Class for representing RDF Triples in memory.

Implemented Interfaces
IComparable<Triple>
Constructors
new: subj: INode * pred: INode * obj: INode -> Triple
new: subj: INode * pred: INode * obj: INode * g: IGraph -> Triple
new: subj: INode * pred: INode * obj: INode * context: ITripleContext -> Triple
Functions
property Context:  ITripleContext
property IsGroundTriple:  bool
property Nodes:  seq<INode>
property Object:  INode
property Predicate:  INode
property Subject:  INode
member Context:  ITripleContext
member IsGroundTriple:  bool
member Nodes:  seq<INode>
member Object:  INode
member Predicate:  INode
member Subject:  INode
member HasObject: n: INode -> bool
member HasPredicate: n: INode -> bool
member HasSubject: n: INode -> bool
member Involves: n: INode -> bool
member Involves: uri: Uri -> bool
member Context: value: ITripleContext -> unit
member ToString: compress: bool -> string
member ToString: formatter: ITripleFormatter -> string
abstract member ToString:  string
abstract member CompareTo: other: Triple -> int
abstract member Equals: obj: obj -> bool
abstract member GetHashCode:  int
*)


let rdf_triple =
    {

      curSubject =
          RDF_Subject.FromRDFIri
          <| RDF_Iri.FromPrefixedName colon.this_
      curPredicate = a
      curObject =
        RDF_Object.FromRDFIri
        <| RDF_Iri.FromPrefixedName colon.example


    }

type RDF_Graph = RDF_Graph of Set<RDF_Triple>
// TODO figure out how to go from RDF_Triple to dotNetRdf Triple
