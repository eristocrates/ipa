namespace MyNamespace

open System
// open type VDS.RDF.ComparisonHelper
// Put any utilities here
[<AutoOpen>]
module internal Utilities =

    let x = 1

// Put any runtime constructs here
type DataSource(filename: string) =
    member this.FileName = filename


// Put the TypeProviderAssemblyAttribute in the runtime DLL, pointing to the design-time DLL
[<assembly: CompilerServices.TypeProviderAssembly("MyProvider.DesignTime.dll")>]
do ()





[<CustomComparison; CustomEquality>]
type Rdf_Triple =
    { curSubject: Rdf_Subject
      curPredicate: Rdf_Predicate
      curObject: Rdf_Object }
    member this.rdf_string =
        sprintf "%s %s %s" this.curSubject.rdf_string this.curPredicate.rdf_string this.curObject.rdf_string


    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and Rdf_Quad =
    { triple: Rdf_Triple
      curGraph: Rdf_Subject option }

and [<RequireQualifiedAccess; CustomComparison; CustomEquality>] Rdf_Subject =
    | FromIri of Iri
    | FromBlankNode of Blank_Node
    member this.rdf_string =
        match this with
        | FromIri iri -> iri.rdf_string
        | FromBlankNode blank_node -> blank_node.rdf_string

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and [<RequireQualifiedAccess; CustomComparison; CustomEquality>] Rdf_Predicate =
    | FromIri of Iri


    member this.rdf_string =
        match this with
        | FromIri iri -> iri.rdf_string

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and [<RequireQualifiedAccess; CustomComparison; CustomEquality>] Rdf_Object =
    | FromIri of Iri
    | FromBlankNode of Blank_Node
    | FromLiteral of Rdf_Literal
    | FromTripleTerm of Triple_Term

    member this.rdf_string =
        match this with
        | FromIri iri -> iri.rdf_string
        | FromBlankNode blank_node -> blank_node.rdf_string
        | FromLiteral literal -> literal.lexical_form
        | FromTripleTerm triple_term -> triple_term.rdf_string

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and PredicateObjectList =

    {

      verb: Rdf_Predicate
      objectLists: ObjectList array

     }
    // TODO update this when handling annotations
    member this.rdf_string =
        let rdf_strings =
            this.objectLists
            |> Array.map (fun objectList -> objectList.rdf_object.rdf_string)

        rdf_strings
        |> Array.append [| this.verb.rdf_string |]
        |> String.concat " "

and ObjectList =
    { rdf_object: Rdf_Object
      annotations: Annotation array }

and Annotation =
    | Reifier of Rdf_Subject
    | AnnotationBlock of PredicateObjectList

and [<CustomComparison; CustomEquality>] Triple_Term =
    | TripleTerm of Rdf_Triple


    member this.rdf_string =
        match this with
        | TripleTerm triple ->
            sprintf "%s %s %s" triple.curSubject.rdf_string triple.curPredicate.rdf_string triple.curObject.rdf_string

    member this.as_object = Rdf_Object.FromTripleTerm this

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()



and [<RequireQualifiedAccess; CustomComparison; CustomEquality>] Iri =
    | FromNamespacedIri of Namespaced_Iri
    | FromAtomicIri of Atomic_Iri
    | FromSkolemIri of Skolem_Iri


    member this.rdf_string =
        match this with
        | FromNamespacedIri namespaced_iri -> namespaced_iri.rdf_string
        | FromAtomicIri atomic_iri -> atomic_iri.rdf_string
        | FromSkolemIri skolem_iri -> skolem_iri.rdf_string

    member this.as_subject = Rdf_Subject.FromIri this
    member this.as_predicate = Rdf_Predicate.FromIri this
    member this.as_object = Rdf_Object.FromIri this


    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()


and [<CustomComparison; CustomEquality>] Namespaced_Iri =
    | NamespacedIri of string * string


    member this.rdf_string =
        match this with
        | NamespacedIri (namespace_name, local_name) -> namespace_name + local_name

    member this.as_subject = Iri.FromNamespacedIri this |> Rdf_Subject.FromIri

    member this.as_predicate =
        Iri.FromNamespacedIri this
        |> Rdf_Predicate.FromIri

    member this.as_object = Iri.FromNamespacedIri this |> Rdf_Object.FromIri

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and [<CustomComparison; CustomEquality>] Atomic_Iri =
    | AtomicIri of string

    member this.rdf_string =
        match this with
        | AtomicIri rdf_string -> rdf_string


    member this.as_subject = Iri.FromAtomicIri this |> Rdf_Subject.FromIri
    member this.as_predicate = Iri.FromAtomicIri this |> Rdf_Predicate.FromIri
    member this.as_object = Iri.FromAtomicIri this |> Rdf_Object.FromIri

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()


and [<CustomComparison; CustomEquality>] Skolem_Iri =
    | SkolemIri of string * Guid

    member this.rdf_string =
        match this with
        | SkolemIri (well_known_base, uuid) -> well_known_base + (uuid.ToString("N"))

    member this.as_subject = Iri.FromSkolemIri this |> Rdf_Subject.FromIri
    member this.as_predicate = Iri.FromSkolemIri this |> Rdf_Predicate.FromIri
    member this.as_object = Iri.FromSkolemIri this |> Rdf_Object.FromIri

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and [<CustomComparison; CustomEquality>] Blank_Node =
    | BlankNode of identifier: string
    | BlankNodePropertyList of identifier: string * predicateObjectList: PredicateObjectList
    member this.rdf_string =
        match this with
        | BlankNode identifier -> identifier
        | BlankNodePropertyList (identifier, predicateObjectList) ->
            sprintf "%s %s" identifier predicateObjectList.rdf_string


    member this.as_subject = Rdf_Subject.FromBlankNode this
    member this.as_object = Rdf_Object.FromBlankNode this

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and [<CustomComparison; CustomEquality>] Rdf_Literal =
    | SimpleLiteral of lexical_form: string
    | LongLiteral of lexical_form: string
    | DatatypedLiteral of lexical_form: string * datatype: Iri
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

    member this.as_object = Rdf_Object.FromLiteral this

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and [<StructuralComparison; StructuralEquality>] Initial_Text_Direction =
    | Ltr
    | Rtl


/// https://www.w3.org/TR/rdf12-concepts/#section-terms
and [<RequireQualifiedAccess; StructuralComparison; StructuralEquality>] private Rdf_Term =

    {

      lexical_form: string
      datatype: Term option
      language: string option
      region: string option
      base_direction: Initial_Text_Direction option
      rdf_subject: Term option
      rdf_predicate: Term option
      rdf_object: Term option

     }

and [<StructuralComparison; StructuralEquality>] Term =
    private
    | RdfTriple of Rdf_Term
    | RdfIri of Rdf_Term
    | RdfBlankNode of Rdf_Term
    | RdfLiteral of Rdf_Term

    static member from_skolem_iri(skolem_iri: Skolem_Iri) =



        RdfIri
            {

              lexical_form = skolem_iri.rdf_string
              rdf_subject = None
              rdf_predicate = None
              rdf_object = None
              datatype = None
              language = None
              region = None
              base_direction = None

            }

    static member from_blank_node(blank_node: Blank_Node) =

        RdfBlankNode
            {

              lexical_form = blank_node.rdf_string
              rdf_subject = None
              rdf_predicate = None
              rdf_object = None
              datatype = None
              language = None
              region = None
              base_direction = None

            }

    static member from_atomic_iri(atomic_iri: Atomic_Iri) =

        RdfIri
            {

              lexical_form = atomic_iri.rdf_string
              rdf_subject = None
              rdf_predicate = None
              rdf_object = None
              datatype = None
              language = None
              region = None
              base_direction = None

            }

    static member from_namespaced_iri(namespaced_iri: Namespaced_Iri) =

        RdfIri
            {

              lexical_form = namespaced_iri.rdf_string
              rdf_subject = None
              rdf_predicate = None
              rdf_object = None
              datatype = None
              language = None
              region = None
              base_direction = None

            }

    static member from_iri(iri: Iri) =
        match iri with
        | Iri.FromNamespacedIri namespaced_iri -> Term.from_namespaced_iri namespaced_iri
        | Iri.FromAtomicIri atomic_iri -> Term.from_atomic_iri atomic_iri
        | Iri.FromSkolemIri skolem_iri -> Term.from_skolem_iri skolem_iri

    static member from_literal(literal: Rdf_Literal) =
        match literal with
        | SimpleLiteral lexical_form ->
            RdfLiteral
                {

                  lexical_form = lexical_form
                  rdf_subject = None
                  rdf_predicate = None
                  rdf_object = None
                  datatype =
                    Some(
                        AtomicIri "http://www.w3.org/2001/XMLSchema#string"
                        |> Term.from_atomic_iri
                    )
                  language = None
                  region = None
                  base_direction = None

                }

        | LongLiteral lexical_form ->

            RdfLiteral
                {

                  lexical_form = lexical_form
                  rdf_subject = None
                  rdf_predicate = None
                  rdf_object = None
                  datatype =
                    Some(
                        AtomicIri "http://www.w3.org/2001/XMLSchema#string"
                        |> Term.from_atomic_iri
                    )
                  language = None
                  region = None
                  base_direction = None

                }
        | DatatypedLiteral (lexical_form, datatype) ->
            RdfLiteral
                {

                  lexical_form = lexical_form
                  rdf_subject = None
                  rdf_predicate = None
                  rdf_object = None
                  datatype = Some(Term.from_iri datatype)
                  language = None
                  region = None
                  base_direction = None

                }
        | LanguageString (lexical_form, language) ->
            RdfLiteral
                {

                  lexical_form = lexical_form
                  rdf_subject = None
                  rdf_predicate = None
                  rdf_object = None
                  datatype =
                    Some(
                        AtomicIri "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"
                        |> Term.from_atomic_iri
                    )
                  language = Some(language.ToString().ToLowerInvariant())
                  region = None
                  base_direction = None

                }
        | RegionString (lexical_form, language, region) ->

            RdfLiteral
                {

                  lexical_form = lexical_form
                  rdf_subject = None
                  rdf_predicate = None
                  rdf_object = None
                  datatype =
                    Some(
                        AtomicIri "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"
                        |> Term.from_atomic_iri
                    )
                  language = Some(language.ToString().ToLowerInvariant())
                  region = Some(region.ToString().ToLowerInvariant())
                  base_direction = None

                }
        | DirectedLanguageString (lexical_form, language, base_direction) ->
            RdfLiteral
                {

                  lexical_form = lexical_form
                  rdf_subject = None
                  rdf_predicate = None
                  rdf_object = None
                  datatype =
                    Some(
                        AtomicIri "http://www.w3.org/1999/02/22-rdf-syntax-ns#dirLangString"
                        |> Term.from_atomic_iri
                    )
                  language = Some(language.ToString().ToLowerInvariant())
                  region = None
                  base_direction = Some(base_direction)

                }
        | DirectedRegionString (lexical_form, language, region, base_direction) ->

            RdfLiteral
                {

                  lexical_form = lexical_form
                  rdf_subject = None
                  rdf_predicate = None
                  rdf_object = None
                  datatype =
                    Some(
                        AtomicIri "http://www.w3.org/1999/02/22-rdf-syntax-ns#dirLangString"
                        |> Term.from_atomic_iri
                    )
                  language = Some(language.ToString().ToLowerInvariant())
                  region = Some(region.ToString().ToLowerInvariant())
                  base_direction = Some(base_direction)

                }

    static member from_subject(rdf_subject: Rdf_Subject) =
        match rdf_subject with
        | Rdf_Subject.FromIri iri -> Term.from_iri iri
        | Rdf_Subject.FromBlankNode blank_node -> Term.from_blank_node blank_node

    static member from_predicate(rdf_predicate: Rdf_Predicate) =
        match rdf_predicate with
        | Rdf_Predicate.FromIri iri -> Term.from_iri iri

    static member from_object(rdf_object: Rdf_Object) =
        match rdf_object with
        | Rdf_Object.FromIri iri -> Term.from_iri iri
        | Rdf_Object.FromBlankNode blank_node -> Term.from_blank_node blank_node
        | Rdf_Object.FromLiteral literal -> Term.from_literal literal
        | Rdf_Object.FromTripleTerm triple_term -> Term.from_triple_term triple_term

    static member from_triple(triple: Rdf_Triple) =
        RdfTriple
            {

              lexical_form = triple.rdf_string
              rdf_subject = Some(Term.from_subject triple.curSubject)
              rdf_predicate = Some(Term.from_predicate triple.curPredicate)
              rdf_object = Some(Term.from_object triple.curObject)
              datatype = None
              language = None
              region = None
              base_direction = None

            }

    static member from_triple_term(TripleTerm triple) = Term.from_triple triple



and [<RequireQualifiedAccess; StructuralComparison; StructuralEquality>] Vertex =
    | FromSubject of Rdf_Subject
    | FromObject of Rdf_Object

and [<RequireQualifiedAccess; StructuralComparison; StructuralEquality>] Edge =
    | FromTriple of Rdf_Triple
    | FromPredicate of Rdf_Predicate



/// https://dotnetrdf.org/docs/stable/user_guide/equality_and_comparison.html
/// https://www.w3.org/TR/rdf12-concepts/#dfn-rdf-string
/// https://www.rfc-editor.org/info/rfc3987/#section-5
and CustomComparer =
    static member type_name(value: obj) =
        if isNull value then
            "null"
        else
            value.GetType().Name

    static member this_before_that = -1
    static member this_or_that = 0
    static member this_after_that = 1

    static member obj_to_term(unknown_object: obj) =
        match unknown_object with
        | :? Term as rdf_term -> rdf_term
        | :? Rdf_Triple as triple -> Term.from_triple triple
        | :? Triple_Term as triple_term -> Term.from_triple_term triple_term
        | :? Rdf_Subject as subject_term -> Term.from_subject subject_term
        | :? Rdf_Predicate as predicate_term -> Term.from_predicate predicate_term
        | :? Rdf_Object as object_term -> Term.from_object object_term
        | :? Iri as iri -> Term.from_iri iri
        | :? Namespaced_Iri as namespaced_iri -> Term.from_namespaced_iri namespaced_iri
        | :? Atomic_Iri as atomic_iri -> Term.from_atomic_iri atomic_iri
        | :? Skolem_Iri as skolem_iri -> Term.from_skolem_iri skolem_iri
        | :? Blank_Node as blank_node -> Term.from_blank_node blank_node
        | :? Rdf_Literal as literal -> Term.from_literal literal
        | _ ->
            invalidArg
                "obj_term"
                (sprintf
                    "Cannot convert (%O : %s)  to %s."
                    unknown_object
                    (CustomComparer.type_name unknown_object)
                    typeof<Term>.Name)

    static member left_to_right_comparison (left: obj) (right: obj) =
        match left, right with
        | null, null -> CustomComparer.this_or_that
        | null, _ -> CustomComparer.this_before_that
        | _, null -> CustomComparer.this_after_that
        | this, that -> compare (CustomComparer.obj_to_term this) (CustomComparer.obj_to_term that)

    static member left_to_right_equality (left: obj) (right: obj) =
        match left, right with
        | null, null -> true
        | null, _
        | _, null -> false
        | this, that -> (CustomComparer.obj_to_term this) = (CustomComparer.obj_to_term that)














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
        |> Set.ofArray

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
        |> Set.ofArray

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


module Rdf_Subject =



    let to_predicate (rdf_subject: Rdf_Subject) =
        match rdf_subject with
        | Rdf_Subject.FromIri iri -> [| Rdf_Predicate.FromIri iri |]
        | Rdf_Subject.FromBlankNode blank_node -> [||]

    let to_object (rdf_subject: Rdf_Subject) =
        match rdf_subject with
        | Rdf_Subject.FromIri iri -> [| Rdf_Object.FromIri iri |]
        | Rdf_Subject.FromBlankNode blank_node -> [| Rdf_Object.FromBlankNode blank_node |]


module Rdf_Predicate =
    let to_subject (rdf_predicate: Rdf_Predicate) =
        match rdf_predicate with
        | Rdf_Predicate.FromIri iri -> [| Rdf_Subject.FromIri iri |]

    let to_object (rdf_predicate: Rdf_Predicate) =
        match rdf_predicate with
        | Rdf_Predicate.FromIri iri -> [| Rdf_Object.FromIri iri |]

module Rdf_Object =

    let to_subject (rdf_object: Rdf_Object) =
        match rdf_object with
        | Rdf_Object.FromIri iri -> [| Rdf_Subject.FromIri iri |]
        | Rdf_Object.FromBlankNode blank_node -> [| Rdf_Subject.FromBlankNode blank_node |]
        | Rdf_Object.FromLiteral literal -> [||]
        | Rdf_Object.FromTripleTerm triple_term -> [||]

    let to_predicate (rdf_object: Rdf_Object) =
        match rdf_object with
        | Rdf_Object.FromIri iri -> [| Rdf_Predicate.FromIri iri |]
        | Rdf_Object.FromBlankNode blank_node -> [||]
        | Rdf_Object.FromLiteral literal -> [||]
        | Rdf_Object.FromTripleTerm triple_term -> [||]

module PredicateObjectList =

    let inline from_terms (predicate: Rdf_Predicate) (objects: Rdf_Object array) =
        {

          verb = predicate
          objectLists =
            objects
            |> Array.map (fun rdf_object ->
                { rdf_object = rdf_object
                  annotations = [||]

                })

        }

module Triple_Term =

    let ttSubject (triple_term: Triple_Term) =
        match triple_term with
        | TripleTerm triple -> triple.curSubject

    let ttPredicate (triple_term: Triple_Term) =
        match triple_term with
        | TripleTerm triple -> triple.curPredicate

    let ttObject (triple_term: Triple_Term) =
        match triple_term with
        | TripleTerm triple -> triple.curObject

module Namespaced_Iri =

    let namespace_name (namespaced_iri: Namespaced_Iri) =
        match namespaced_iri with
        | NamespacedIri (namespace_name, local_name) -> namespace_name

    let local_name (namespaced_iri: Namespaced_Iri) =
        match namespaced_iri with
        | NamespacedIri (namespace_name, local_name) -> local_name

module Rdf_Literal =

    let lexical_form (literal: Rdf_Literal) =
        match literal with
        | SimpleLiteral lexical_form -> lexical_form
        | LongLiteral lexical_form -> lexical_form
        | DatatypedLiteral (lexical_form, datatype) -> lexical_form
        | LanguageString (lexical_form, language) -> lexical_form
        | RegionString (lexical_form, language, region) -> lexical_form
        | DirectedLanguageString (lexical_form, language, base_direction) -> lexical_form
        | DirectedRegionString (lexical_form, language, region, base_direction) -> lexical_form

    let datatype (literal: Rdf_Literal) =
        match literal with
        | SimpleLiteral lexical_form -> Iri.FromAtomicIri(AtomicIri "http://www.w3.org/2001/XMLSchema#string")
        | LongLiteral lexical_form -> Iri.FromAtomicIri(AtomicIri "http://www.w3.org/2001/XMLSchema#string")
        | DatatypedLiteral (lexical_form, datatype) -> datatype
        | LanguageString (lexical_form, language) ->
            Iri.FromAtomicIri(AtomicIri "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString")
        | RegionString (lexical_form, language, region) ->
            Iri.FromAtomicIri(AtomicIri "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString")
        | DirectedLanguageString (lexical_form, language, base_direction) ->
            Iri.FromAtomicIri(AtomicIri "http://www.w3.org/1999/02/22-rdf-syntax-ns#dirLangString")
        | DirectedRegionString (lexical_form, language, region, base_direction) ->
            Iri.FromAtomicIri(AtomicIri "http://www.w3.org/1999/02/22-rdf-syntax-ns#dirLangString")

    let language_tag (literal: Rdf_Literal) =
        match literal with
        | SimpleLiteral lexical_form -> None
        | LongLiteral lexical_form -> None
        | DatatypedLiteral (lexical_form, datatype) -> None
        | LanguageString (lexical_form, language) -> Some language
        | RegionString (lexical_form, language, region) -> Some language
        | DirectedLanguageString (lexical_form, language, base_direction) -> Some language
        | DirectedRegionString (lexical_form, language, region, base_direction) -> Some language

    let region_tag (literal: Rdf_Literal) =
        match literal with
        | SimpleLiteral lexical_form -> None
        | LongLiteral lexical_form -> None
        | DatatypedLiteral (lexical_form, datatype) -> None
        | LanguageString (lexical_form, language) -> None
        | RegionString (lexical_form, language, region) -> Some region
        | DirectedLanguageString (lexical_form, language, base_direction) -> None
        | DirectedRegionString (lexical_form, language, region, base_direction) -> Some region

    let base_direction (literal: Rdf_Literal) =
        match literal with
        | SimpleLiteral lexical_form -> None
        | LongLiteral lexical_form -> None
        | DatatypedLiteral (lexical_form, datatype) -> None
        | LanguageString (lexical_form, language) -> None
        | RegionString (lexical_form, language, region) -> None
        | DirectedLanguageString (lexical_form, language, base_direction) -> Some base_direction
        | DirectedRegionString (lexical_form, language, region, base_direction) -> Some base_direction

//

module Initial_Text_Direction =
    let lexical_form (initial_text_direction: Initial_Text_Direction) =
        match initial_text_direction with
        | Ltr -> "ltr"
        | Rtl -> "rtl"










type Mime_Type =
    { registry: string
      name: string }

    member this.data_namespace_name = sprintf "data:%s;charset=UTF-8;" this.name

    member this.data_prefix local_name =
        NamespacedIri(this.data_namespace_name, local_name)
        |> Iri.FromNamespacedIri

    member this.iana_iri =
        NamespacedIri(sprintf "https://www.iana.org/assignments/media-types/%s/" this.registry, this.name)
        |> Iri.FromNamespacedIri

    member this.resource_iri =
        NamespacedIri(sprintf "http://www.w3.org/ns/iana/media-types/%s/%s#" this.registry this.name, "Resource")
        |> Iri.FromNamespacedIri

    member this.spar_iri =
        NamespacedIri(sprintf "https://w3id.org/spar/mediatype/%s/%s#" this.registry this.name, "Resource")
        |> Iri.FromNamespacedIri


type Iana_Status =
    | HistoricalStatus
    | PermanentStatus
    | ProvisionalStatus

type Iana_Scheme =
    { name: string
      description: string
      cri: int
      status: Iana_Status }
