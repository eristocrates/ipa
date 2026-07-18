module DoxAletheia.Rdf_Vocabulary
open System

open DoxAletheia
open ParserCombinator.Data
open ParserCombinator.ResourceIdentifier
open StringExtensions
open XParsecExtensions
open XParsecExtensions.Code_Parsers
open ArrayErgonomics
open GrammarErgonomics
open Interval_Range
open IntervalErgonomics
open Rfc_Types
open Code_Point_Rule
open Code_Line_Rule
open XParsec
open FSharp.HashCollections

type Rdf_Triple =
    { curSubject: Rdf_Subject
      curPredicate: Rdf_Predicate
      curObject: Rdf_Object }
    member this.as_object = this |> TripleTerm |> TripleTermObject

and Rdf_Quad =
    { triple: Rdf_Triple
      curGraph: Rdf_Subject option }

and Rdf_Subject =
    | IRIREFSubject of IRIREF
    | BlankNodeSubject of Blank_Node
    member this.maybe_predicate =
        match this with
        | IRIREFSubject iriref -> Some iriref.as_subject
        | BlankNodeSubject blank_node -> None

    member this.as_object =

        match this with
        | IRIREFSubject iriref -> iriref.as_object
        | BlankNodeSubject blank_node -> blank_node.as_object

    member this.as_raw_string =
        match this with
        | IRIREFSubject iriref -> iriref.as_raw_string
        | BlankNodeSubject blank_node -> blank_node.as_raw_string

    member this.as_rendered_string =
        match this with
        | IRIREFSubject iriref -> iriref.as_rendered_string
        | BlankNodeSubject blank_node -> blank_node.as_raw_string

and Rdf_Predicate =
    | IRIREFPredicate of IRIREF
    member this.as_subject =
        match this with
        | IRIREFPredicate iriref -> iriref.as_subject

    member this.as_object =
        match this with
        | IRIREFPredicate iriref -> iriref.as_object

    member this.as_rendered_string =
        match this with
        | IRIREFPredicate iriref -> iriref.as_rendered_string
    member this.as_raw_string =
        match this with
        | IRIREFPredicate iriref -> iriref.as_raw_string


and Rdf_Object =
    | IRIREFObject of IRIREF
    | BlankNodeObject of Blank_Node
    | LiteralObject of Rdf_Literal
    | TripleTermObject of Triple_Term
    member this.maybe_subject =
        match this with
        | IRIREFObject iriref -> Some iriref.as_subject
        | BlankNodeObject blank_node -> Some blank_node.as_subject
        | LiteralObject rdf_literal -> None
        // TODO figure out howto incorporate reified triple subjects
        | TripleTermObject triple_term -> None

    member this.maybe_predicate =
        match this with
        | IRIREFObject iriref -> Some iriref.as_predicate
        | BlankNodeObject blank_node -> None
        | LiteralObject rdf_literal -> None
        | TripleTermObject triple_term -> None

    member this.as_raw_string =
        match this with
        | IRIREFObject iriref -> iriref.as_raw_string
        | BlankNodeObject blank_node -> blank_node.as_raw_string
        | LiteralObject rdf_literal -> rdf_literal.lexical_form
        | TripleTermObject triple_term -> sprintf "%s %s %s" triple_term.ttSubject.as_raw_string triple_term.ttPredicate.as_raw_string triple_term.ttObject.as_raw_string
and PredicateObjectList =
    {

      verb: Rdf_Predicate
      objectLists: ObjectList array

     }

    static member inline from_terms (predicate: Rdf_Predicate) (objects: Rdf_Object array) =
        {

          verb = predicate
          objectLists =
            objects
            |> Array.map (fun rdf_object ->
                { rdf_object = rdf_object
                  annotations = [||]

                })

        }

and ObjectList =
    { rdf_object: Rdf_Object
      annotations: Annotation array }

and Annotation =
    | AnnotationReifier of Rdf_Subject
    | AnnotationBlock of PredicateObjectList

and Triple_Term =
    | TripleTerm of Rdf_Triple
    member this.as_object = TripleTermObject this

    member this.ttSubject:Rdf_Subject =
        match this with
        | TripleTerm triple -> triple.curSubject

    member this.ttPredicate:Rdf_Predicate =
        match this with
        | TripleTerm triple -> triple.curPredicate

    member this.ttObject:Rdf_Object =
        match this with
        | TripleTerm triple -> triple.curObject




and IRIREF =
    | NamespacedName of Namespaced_IRI
    | SkolemIRIREF of Skolem_IRI
    | IRIREF of IRI
    | RelativeReference of Relative_Reference
    member this.as_subject = IRIREFSubject this
    member this.as_predicate = IRIREFPredicate this
    member this.as_object = IRIREFObject this

    static member parser: Parser<IRIREF, Code_Point, unit, ReadableMemory<Code_Point>> =
        parser {
            return!
                choice [

                         IRI.parser |>> IRIREF
                         Relative_Reference.parser |>> RelativeReference

                          ]


        }

    static member metasyntax =
        """
            IRI-reference  = IRI / irelative-ref
            URI-reference = URI / relative-ref

        """

    static member parse(input_string: string) =
        match IRIREF.parser input_string.as_parser_input with
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line IRIREF.metasyntax}"


    member this.as_raw_string =
        match this with
        | IRIREF iri -> iri.as_raw_string
        | SkolemIRIREF iri -> iri.as_raw_string
        | NamespacedName namespaced_iri -> namespaced_iri.as_raw_string
        | RelativeReference relative_ref -> relative_ref.as_raw_string

    member this.as_rendered_string = "<" + this.as_raw_string + ">"



and Blank_Node =
    | BlankNodeIdentifier of identifier: string
    | BlankNodePropertyList of identifier: string * predicateObjectList: PredicateObjectList

    member this.as_subject = BlankNodeSubject this
    member this.as_object = BlankNodeObject this

    member this.as_raw_string =
        match this with
        | BlankNodeIdentifier identifier -> identifier
        | BlankNodePropertyList (identifier, predicateObjectList) -> identifier

    member this.as_rendered_string = "_:" + this.as_raw_string


and Rdf_Literal =
    | SimpleLiteral of lexical_form: string
    | LongLiteral of lexical_form: string
    | DatatypedLiteral of lexical_form: string * datatype: IRIREF
    | LanguageString of lexical_form: string * language: Language_Tag
    | RegionString of lexical_form: string * language: Language_Tag * region: Region_Subtag
    | DirectedLanguageString of lexical_form: string * language: Language_Tag * base_direction: Initial_Text_Direction
    | DirectedRegionString of
        lexical_form: string *
        language: Language_Tag *
        region: Region_Subtag *
        base_direction: Initial_Text_Direction

    member this.lexical_form =
        match this with
        | SimpleLiteral lexical_form -> lexical_form
        | LongLiteral lexical_form -> lexical_form
        | DatatypedLiteral (lexical_form, datatype) -> lexical_form
        | LanguageString (lexical_form, language) -> lexical_form
        | RegionString (lexical_form, language, region) -> lexical_form
        | DirectedLanguageString (lexical_form, language, base_direction) -> lexical_form
        | DirectedRegionString (lexical_form, language, region, base_direction) -> lexical_form

    member this.datatype =
        match this with
        | SimpleLiteral lexical_form -> IRIREF.parse "http://www.w3.org/2001/XMLSchema#string"
        | LongLiteral lexical_form -> IRIREF.parse "http://www.w3.org/2001/XMLSchema#string"
        | DatatypedLiteral (lexical_form, datatype) -> datatype
        | LanguageString (lexical_form, language) ->
            IRIREF.parse "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"
        | RegionString (lexical_form, language, region) ->
            IRIREF.parse "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"
        | DirectedLanguageString (lexical_form, language, base_direction) ->
            IRIREF.parse "http://www.w3.org/1999/02/22-rdf-syntax-ns#dirLangString"
        | DirectedRegionString (lexical_form, language, region, base_direction) ->
            IRIREF.parse "http://www.w3.org/1999/02/22-rdf-syntax-ns#dirLangString"

    member this.language_tag =
        match this with
        | SimpleLiteral lexical_form -> None
        | LongLiteral lexical_form -> None
        | DatatypedLiteral (lexical_form, datatype) -> None
        | LanguageString (lexical_form, language) -> Some language
        | RegionString (lexical_form, language, region) -> Some language
        | DirectedLanguageString (lexical_form, language, base_direction) -> Some language
        | DirectedRegionString (lexical_form, language, region, base_direction) -> Some language

    member this.region_tag(literal: Rdf_Literal) =
        match this with
        | SimpleLiteral lexical_form -> None
        | LongLiteral lexical_form -> None
        | DatatypedLiteral (lexical_form, datatype) -> None
        | LanguageString (lexical_form, language) -> None
        | RegionString (lexical_form, language, region) -> Some region
        | DirectedLanguageString (lexical_form, language, base_direction) -> None
        | DirectedRegionString (lexical_form, language, region, base_direction) -> Some region

    member this.base_direction(literal: Rdf_Literal) =
        match this with
        | SimpleLiteral lexical_form -> None
        | LongLiteral lexical_form -> None
        | DatatypedLiteral (lexical_form, datatype) -> None
        | LanguageString (lexical_form, language) -> None
        | RegionString (lexical_form, language, region) -> None
        | DirectedLanguageString (lexical_form, language, base_direction) -> Some base_direction
        | DirectedRegionString (lexical_form, language, region, base_direction) -> Some base_direction

    member this.as_object = LiteralObject this

and Initial_Text_Direction =
    | Ltr
    | Rtl
    member this.lexical_form =

        match this with
        | Ltr -> "ltr"
        | Rtl -> "rtl"

and Skolem_IRI =
    | SkolemIRI of IRIREF * Guid
    member this.well_known_iriref =
        match this with
        | SkolemIRI (well_known_stem, uuid) -> well_known_stem

    member this.uuid =
        match this with
        | SkolemIRI (well_known_stem, uuid) -> uuid


    member this.as_subject = this |> SkolemIRIREF |> IRIREFSubject
    member this.as_predicate = this |> SkolemIRIREF |> IRIREFPredicate
    member this.as_object = this |> SkolemIRIREF |> IRIREFObject

    member this.as_raw_string =
        match this with
        | SkolemIRI (well_known_stem, uuid) ->
            well_known_stem.as_rendered_string
            + uuid.ToString("N")

    member this.as_rendered_string = "<" + this.as_raw_string + ">"

and Namespaced_IRI =
    private
    | NamespacedIRI of IRIREF * Local_Name
    member this.namespace_iriref =
        match this with
        | NamespacedIRI (namespace_name, local_name) -> namespace_name

    member this.local_name =
        match this with
        | NamespacedIRI (namespace_name, local_name) -> local_name

    member this.as_raw_string =
        match this with
        | NamespacedIRI (namespace_name, local_name) ->
            namespace_name.as_raw_string
            + local_name.as_raw_string

    member this.as_rendered_string = "<" + this.as_raw_string + ">"

    member this.as_prefixed_name (delimiter: string) (prefix_map: Map<string, string>) =
        try
            let namespace_name = this.namespace_iriref.as_raw_string
            let prefix_label = prefix_map[namespace_name]
            sprintf "%s%s%s" prefix_label delimiter this.local_name.as_raw_string
        with
        | err -> failwithf "%s failed with error %s" this.as_raw_string err.Message

    member this.as_curie(prefix_map: Map<string, string>) = this.as_prefixed_name ":" prefix_map

    static member metasyntax =
        """
    
            IRIREF            ::=  '<' ([^#x00-#x20<>"{}|^`\] | UCHAR)* '>' /* #x00=NULL #01-#x1F=control codes #x20=space */
            PN_LOCAL          ::= ( PN_CHARS_U | ':' | [0-9] | PLX ) ( ( PN_CHARS | '.' | ':' | PLX )*  ( PN_CHARS | ':' | PLX ) ) ?

        """

    static member parse (namespace_name_input: string) (local_name_input: string) =
        let namespace_name =
            match IRIREF.parser namespace_name_input.as_parser_input with
            | Ok success -> success
            | Error failure ->
                failwith $"{failure} : {code_line_message namespace_name_input.as_code_line IRIREF.metasyntax}"

        let local_name =
            match Local_Name.parser local_name_input.as_parser_input with
            | Ok success -> success
            | Error failure ->
                failwith $"{failure} : {code_line_message local_name_input.as_code_line PN_LOCAL.metasyntax}"

        NamespacedIRI(namespace_name, local_name)





    member this.as_subject = this |> NamespacedName |> IRIREFSubject
    member this.as_predicate = this |> NamespacedName |> IRIREFPredicate
    member this.as_object = this |> NamespacedName |> IRIREFObject


and Local_Name =

    private
    | LocalName of PN_LOCAL
    | LocalPath of Path_Rootless
    static member parser: Parser<Local_Name, Code_Point, unit, ReadableMemory<Code_Point>> =
        parser {
            return!
                choice [ PN_LOCAL.parser |>> LocalName
                         Path_Rootless.parser |>> LocalPath ]

        }

    static member metasyntax =
        """
                                      PN_LOCAL          ::= ( PN_CHARS_U | ':' | [0-9] | PLX ) ( ( PN_CHARS | '.' | ':' | PLX )*  ( PN_CHARS | ':' | PLX ) ) ?
                                      ipath-rootless = isegment-nz *( "/" isegment )
                                      """

    static member parse(input_string: string) =
        match Local_Name.parser input_string.as_parser_input with
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line Local_Name.metasyntax}"

    member this.substrings =
        match this with
        | LocalName pn_local -> [| pn_local.as_raw_string |]
        | LocalPath path_rootless ->
            path_rootless.segments
            |> Array.map Segment.raw_string



    member this.as_raw_string =

        match this with
        | LocalName pn_local -> pn_local.as_raw_string
        | LocalPath path_rootless -> path_rootless.as_raw_string


and PN_LOCAL =
    private
    | PN_LOCAL of string
    static member parser: Parser<PN_LOCAL, Code_Point, unit, ReadableMemory<Code_Point>> =
        parser {

            let! head =
                choice [

                         pn_chars_u.code_point_parser
                         parse_char ':'
                         any_point_from_interval Unicodepoint.Partition.Ascii_Digits

                          ]

            let! maybe_tail =
                opt (

                    many (
                        choice [ pn_chars.code_point_parser
                                 parse_char '.'
                                 parse_char ':' ]
                    )
                )

            return
                match maybe_tail with
                | ValueNone ->
                    [| head |]
                    |> String_Pool.from_code_line
                    |> PN_LOCAL
                | ValueSome immutable_code_line ->
                    immutable_code_line
                    |> Code_Line.from_immutable_code_line
                    |> Array.insertAt 0 head
                    |> String_Pool.from_code_line
                    |> PN_LOCAL

        }

    static member metasyntax =
        """
                                  PN_LOCAL          ::= ( PN_CHARS_U | ':' | [0-9] | PLX ) ( ( PN_CHARS | '.' | ':' | PLX )*  ( PN_CHARS | ':' | PLX ) ) ?
                                  """

    static member parse(input_string: string) =
        match PN_LOCAL.parser input_string.as_parser_input with
        | Ok (PN_LOCAL false_positive) when false_positive[false_positive.ToCharArray().last_index] = '.' ->
            failwith
                $"false positive for {input_string}, cannot end with full stop ``.`` : {code_line_message input_string.as_code_line PN_LOCAL.metasyntax}"
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line PN_LOCAL.metasyntax}"

    member this.as_raw_string =
        match this with
        | PN_LOCAL raw_string -> raw_string





and Vertex =
    | SubjectVertex of Rdf_Subject
    | ObjectVertex of Rdf_Object
    static member subject_string
        (rdf_subject: Rdf_Subject)
        (prefix_delimiter: string)
        (prefix_map: Map<string, string>)
        =
        match rdf_subject with
        | IRIREFSubject (NamespacedName namespaced_iri) -> namespaced_iri.as_prefixed_name prefix_delimiter prefix_map
        | IRIREFSubject iriref -> iriref.as_rendered_string
        | BlankNodeSubject blank_node -> blank_node.as_raw_string

    static member object_String (rdf_object: Rdf_Object) (prefix_delimiter: string) (prefix_map: Map<string, string>) =

        match rdf_object with
        | IRIREFObject (NamespacedName namespaced_iri) -> namespaced_iri.as_prefixed_name prefix_delimiter prefix_map
        | IRIREFObject iriref -> iriref.as_rendered_string
        | BlankNodeObject blank_node -> blank_node.as_raw_string
        | LiteralObject rdf_literal ->
            match rdf_literal with
            | SimpleLiteral lexical_form -> sprintf "%s" lexical_form
            | LongLiteral lexical_form -> sprintf "%s" lexical_form
            | DatatypedLiteral (lexical_form, (NamespacedName datatype_iri)) ->
                sprintf "%s^^%s" lexical_form (datatype_iri.as_prefixed_name prefix_delimiter prefix_map)
            | DatatypedLiteral (lexical_form, datatype) -> sprintf "%s^^%s" lexical_form datatype.as_rendered_string
            | LanguageString (lexical_form, language) -> sprintf "%s@%s" lexical_form (language.ToString())
            | RegionString (lexical_form, language, region) ->
                sprintf "%s@%s-%s" lexical_form (language.ToString()) (region.ToString())
            | DirectedLanguageString (lexical_form, language, base_direction) ->
                sprintf "%s@%s--%s" lexical_form (language.ToString()) base_direction.lexical_form
            | DirectedRegionString (lexical_form, language, region, base_direction) ->
                sprintf
                    "%s@%s-%s--%s"
                    lexical_form
                    (language.ToString())
                    (region.ToString())
                    base_direction.lexical_form

        | TripleTermObject triple_term ->
            sprintf
                "%s %s %s"
                (Vertex.subject_string triple_term.ttSubject prefix_delimiter prefix_map)
                (Edge.predicate_string triple_term.ttPredicate prefix_delimiter prefix_map)
                (Vertex.object_String triple_term.ttObject prefix_delimiter prefix_map)

    member this.as_rendered_string (prefix_delimiter: string) (prefix_map: Map<string, string>) =
        match this with
        | SubjectVertex rdf_subject -> Vertex.subject_string rdf_subject prefix_delimiter prefix_map
        | ObjectVertex rdf_object -> Vertex.object_String rdf_object prefix_delimiter prefix_map



and Edge =
    | PredicateEdge of Rdf_Predicate
    | TripleEdge of Rdf_Triple
    static member predicate_string
        (rdf_predicate: Rdf_Predicate)
        (prefix_delimiter: string)
        (prefix_map: Map<string, string>)
        =
        match rdf_predicate with
        | IRIREFPredicate (NamespacedName namespaced_iri) -> namespaced_iri.as_prefixed_name prefix_delimiter prefix_map
        | IRIREFPredicate iriref -> iriref.as_rendered_string

    member this.as_rendered_string (prefix_delimiter: string) (prefix_map: Map<string, string>) =
        match this with
        | PredicateEdge rdf_predicate -> Edge.predicate_string rdf_predicate prefix_delimiter prefix_map
        | TripleEdge rdf_triple -> Edge.predicate_string rdf_triple.curPredicate prefix_delimiter prefix_map







module Rdf_Triple =

    let inline from_terms
        (rdf_subject: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject))
        (rdf_predicate: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate))
        (rdf_object: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object))
        =
        { curSubject = rdf_subject.as_subject
          curPredicate = rdf_predicate.as_predicate
          curObject = rdf_object.as_object }


// TODO next consider
// open FSharp.HashCollections
// Hashset instead

module Triples =
    let from_terms
        (rdf_subjects: Rdf_Subject array)
        (rdf_predicates: Rdf_Predicate array)
        (rdf_objects: Rdf_Object array)
        =
        rdf_objects
        |> Array.Parallel.collect (fun rdf_object ->

            rdf_predicates
            |> Array.Parallel.collect (fun rdf_predicate ->

                rdf_subjects
                |> Array.Parallel.map (fun rdf_subject ->

                    {

                      curSubject = rdf_subject
                      curPredicate = rdf_predicate
                      curObject = rdf_object

                    }

                )))
        |> HashSet.ofSeq

    let from_subjects_predicateObjectLists
        (rdf_subjects: Rdf_Subject array)
        (predicateObjectLists: PredicateObjectList array)
        =
        rdf_subjects
        |> Array.Parallel.collect (fun rdf_subject ->
            predicateObjectLists
            |> Array.Parallel.collect (fun predicateObjectList ->
                predicateObjectList.objectLists
                |> Array.Parallel.map (fun objectList ->
                    // TODO deal with annotations


                    { curSubject = rdf_subject
                      curPredicate = predicateObjectList.verb
                      curObject = objectList.rdf_object }

                )



            )



        )
        |> HashSet.ofSeq

module Quad =

    let inline from_terms
        (subject: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject))
        (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate))
        (object: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object))
        (graph_name: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject))
        =
        {

          triple = Rdf_Triple.from_terms subject predicate object
          curGraph = Some graph_name.as_subject

        }

    let curSubject (quad: Rdf_Quad) = quad.triple.curSubject
    let curPredicate (quad: Rdf_Quad) = quad.triple.curPredicate
    let curObject (quad: Rdf_Quad) = quad.triple.curObject















type Mime_Type =
    { registry: string
      name: string }

    member this.data_namespace_name = sprintf "data:%s;charset=UTF-8;" this.name

    member this.data_prefix local_name =
        Namespaced_IRI.parse this.data_namespace_name local_name
        |> NamespacedName


    member this.iana_iri =
        Namespaced_IRI.parse (sprintf "https://www.iana.org/assignments/media-types/%s/" this.registry) this.name
        |> NamespacedName

    member this.resource_iri =
        Namespaced_IRI.parse (sprintf "http://www.w3.org/ns/iana/media-types/%s/%s#" this.registry this.name) "Resource"
        |> NamespacedName

    member this.spar_iri =
        Namespaced_IRI.parse (sprintf "https://w3id.org/spar/mediatype/%s/%s#" this.registry this.name) "Resource"
        |> NamespacedName




type Iana_Status =
    | HistoricalStatus
    | PermanentStatus
    | ProvisionalStatus

type Iana_Scheme =
    { name: string
      description: string
      cri: int
      status: Iana_Status }
