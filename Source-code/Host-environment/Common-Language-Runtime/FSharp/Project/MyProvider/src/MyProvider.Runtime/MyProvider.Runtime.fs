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
type Triple =
    { curSubject: Subject_Term
      curPredicate: Predicate_Term
      curObject: Object_Term }
    static member inline from_terms
        (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Subject_Term))
        (predicate_term: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
        (object_term: ^ObjectType when ^ObjectType: (member as_object: Object_Term))
        =
        { curSubject = subject_term.as_subject
          curPredicate = predicate_term.as_predicate
          curObject = object_term.as_object }

    member this.rdf_string =
        sprintf "%s %s %s" this.curSubject.rdf_string this.curPredicate.rdf_string this.curObject.rdf_string

    member this.nt =
        sprintf "%s %s %s ." this.curSubject.nt this.curPredicate.nt this.curObject.nt

    member this.ddot =
        sprintf "%s..%s..%s" this.curSubject.nt this.curPredicate.nt this.curObject.nt

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and [<RequireQualifiedAccess; CustomComparison; CustomEquality>] Subject_Term =
    | FromIri of Iri
    | FromBlankNode of Blank_Node
    member this.rdf_string =
        match this with
        | FromIri iri -> iri.rdf_string
        | FromBlankNode blank_node -> blank_node.rdf_string

    member this.nt =
        match this with
        | FromIri iri -> iri.nt
        | FromBlankNode blank_node -> blank_node.nt

    member this.ddot =
        match this with
        | FromIri iri -> iri.ddot
        | FromBlankNode blank_node -> blank_node.ddot


    member this.to_predicate =
        match this with
        | FromIri iri -> [| Predicate_Term.FromIri iri |]
        | FromBlankNode blank_node -> [||]

    member this.to_object =
        match this with
        | FromIri iri -> [| Object_Term.FromIri iri |]
        | FromBlankNode blank_node -> [| Object_Term.FromBlankNode blank_node |]

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and [<RequireQualifiedAccess; CustomComparison; CustomEquality>] Predicate_Term =
    | FromIri of Iri
    member this.rdf_string =
        match this with
        | FromIri iri -> iri.rdf_string

    member this.nt =
        match this with
        | FromIri iri -> iri.nt

    member this.ddot =
        match this with
        | FromIri iri -> iri.ddot

    member this.to_subject =
        match this with
        | FromIri iri -> [| Subject_Term.FromIri iri |]

    member this.to_object =
        match this with
        | FromIri iri -> [| Object_Term.FromIri iri |]

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and [<RequireQualifiedAccess; CustomComparison; CustomEquality>] Object_Term =
    | FromIri of Iri
    | FromBlankNode of Blank_Node
    | FromLiteral of Literal
    | FromTripleTerm of Triple_Term
    member this.rdf_string =
        match this with
        | FromIri iri -> iri.rdf_string
        | FromBlankNode blank_node -> blank_node.rdf_string
        | FromLiteral literal -> literal.lexical_form
        | FromTripleTerm triple_term -> triple_term.rdf_string

    member this.nt =
        match this with
        | FromIri iri -> iri.nt
        | FromBlankNode blank_node -> blank_node.nt
        | FromLiteral literal -> literal.nt
        | FromTripleTerm triple_term -> triple_term.nt

    member this.ddot =
        match this with
        | FromIri iri -> iri.ddot
        | FromBlankNode blank_node -> blank_node.ddot
        | FromLiteral literal -> literal.ddot
        | FromTripleTerm triple_term -> triple_term.ddot

    member this.to_subject =
        match this with
        | FromIri iri -> [| Subject_Term.FromIri iri |]
        | FromBlankNode blank_node -> [| Subject_Term.FromBlankNode blank_node |]
        | FromLiteral literal -> [||]
        | FromTripleTerm triple_term -> [||]

    member this.to_predicate =
        match this with
        | FromIri iri -> [| Predicate_Term.FromIri iri |]
        | FromBlankNode blank_node -> [||]
        | FromLiteral literal -> [||]
        | FromTripleTerm triple_term -> [||]

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and [<CustomComparison; CustomEquality>] Triple_Term =
    | TripleTerm of Triple
    member this.ttSubject =
        match this with
        | TripleTerm triple -> triple.curSubject

    member this.ttPredicate =
        match this with
        | TripleTerm triple -> triple.curPredicate

    member this.ttObject =
        match this with
        | TripleTerm triple -> triple.curObject

    member this.rdf_string =
        match this with
        | TripleTerm triple ->
            sprintf "%s %s %s" triple.curSubject.rdf_string triple.curPredicate.rdf_string triple.curObject.rdf_string

    member this.nt =
        match this with
        | TripleTerm triple -> sprintf "<<(%s %s %s)>>" triple.curSubject.nt triple.curPredicate.nt triple.curObject.nt

    member this.ddot =
        match this with
        | TripleTerm triple -> sprintf ",,%s..%s..%s" triple.curSubject.nt triple.curPredicate.nt triple.curObject.nt

    member this.as_object = Object_Term.FromTripleTerm this

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

    member this.as_iriref =
        match this with
        | FromNamespacedIri namespaced_iri -> namespaced_iri.as_iriref
        | FromAtomicIri atomic_iri -> atomic_iri.as_iriref
        | FromSkolemIri skolem_iri -> skolem_iri.as_iriref

    member this.nt = this.as_iriref
    member this.ddot = this.rdf_string
    member this.as_subject = Subject_Term.FromIri this
    member this.as_predicate = Predicate_Term.FromIri this
    member this.as_object = Object_Term.FromIri this

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and [<CustomComparison; CustomEquality>] Namespaced_Iri =
    | NamespacedIri of string * string

    member this.namespace_name =
        match this with
        | NamespacedIri (namespace_name, local_name) -> namespace_name

    member this.local_name =
        match this with
        | NamespacedIri (namespace_name, local_name) -> local_name

    member this.rdf_string =
        match this with
        | NamespacedIri (namespace_name, local_name) -> namespace_name + local_name

    member this.as_iriref = sprintf "<%s>" this.rdf_string
    member this.nt = this.as_iriref
    member this.ddot = this.rdf_string
    member this.as_iri = Iri.FromNamespacedIri this
    member this.as_subject = Subject_Term.FromIri this.as_iri
    member this.as_predicate = Predicate_Term.FromIri this.as_iri
    member this.as_object = Object_Term.FromIri this.as_iri

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

    member this.as_iriref = sprintf "<%s>" this.rdf_string

    member this.nt = this.as_iriref
    member this.ddot = this.rdf_string

    member this.as_iri = Iri.FromAtomicIri this
    member this.as_subject = Subject_Term.FromIri this.as_iri
    member this.as_predicate = Predicate_Term.FromIri this.as_iri
    member this.as_object = Object_Term.FromIri this.as_iri

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

    member this.well_known_base =
        match this with
        | SkolemIri (well_known_base, uuid) -> well_known_base

    member this.uuid =
        match this with
        | SkolemIri (well_known_base, uuid) -> uuid

    member this.as_iriref = sprintf "<%s>" this.rdf_string

    member this.nt = this.as_iriref
    member this.ddot = this.rdf_string

    member this.as_iri = Iri.FromSkolemIri this
    member this.as_subject = Subject_Term.FromIri this.as_iri
    member this.as_predicate = Predicate_Term.FromIri this.as_iri
    member this.as_object = Object_Term.FromIri this.as_iri

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and [<CustomComparison; CustomEquality>] Blank_Node =
    | BlankNode of identifier: string

    member this.rdf_string =
        match this with
        | BlankNode identifier -> identifier

    member this.nt = sprintf "_:%s" this.rdf_string
    member this.ddot = this.rdf_string
    // TODO consider member this.as_skolem_iri

    member this.as_subject = Subject_Term.FromBlankNode this
    member this.as_object = Object_Term.FromBlankNode this

    interface IComparable with
        member this.CompareTo that =
            CustomComparer.left_to_right_comparison this that

    override this.Equals that =
        CustomComparer.left_to_right_equality this that

    override this.GetHashCode() =
        (CustomComparer.obj_to_term this).GetHashCode()

and [<CustomComparison; CustomEquality>] Literal =
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

    member this.datatype =
        match this with
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

    member this.language_tag =
        match this with
        | SimpleLiteral lexical_form -> None
        | LongLiteral lexical_form -> None
        | DatatypedLiteral (lexical_form, datatype) -> None
        | LanguageString (lexical_form, language) -> Some language
        | RegionString (lexical_form, language, region) -> Some language
        | DirectedLanguageString (lexical_form, language, base_direction) -> Some language
        | DirectedRegionString (lexical_form, language, region, base_direction) -> Some language

    member this.region_tag =
        match this with
        | SimpleLiteral lexical_form -> None
        | LongLiteral lexical_form -> None
        | DatatypedLiteral (lexical_form, datatype) -> None
        | LanguageString (lexical_form, language) -> None
        | RegionString (lexical_form, language, region) -> Some region
        | DirectedLanguageString (lexical_form, language, base_direction) -> None
        | DirectedRegionString (lexical_form, language, region, base_direction) -> Some region

    member this.base_direction =
        match this with
        | SimpleLiteral lexical_form -> None
        | LongLiteral lexical_form -> None
        | DatatypedLiteral (lexical_form, datatype) -> None
        | LanguageString (lexical_form, language) -> None
        | RegionString (lexical_form, language, region) -> None
        | DirectedLanguageString (lexical_form, language, base_direction) -> Some base_direction
        | DirectedRegionString (lexical_form, language, region, base_direction) -> Some base_direction

    member this.nt =
        match this with
        | SimpleLiteral lexical_form -> sprintf "\"%s\"" lexical_form
        | LongLiteral lexical_form -> sprintf "\"\"\"%s\"\"\"" lexical_form
        | DatatypedLiteral (lexical_form, datatype) -> sprintf "\"%s\"^^%s" lexical_form datatype.nt
        | LanguageString (lexical_form, language) -> sprintf "\"%s\"@%s" lexical_form (language.ToString())
        | RegionString (lexical_form, language, region) ->
            sprintf "\"%s\"@%s-%s" lexical_form (language.ToString()) (region.ToString())
        | DirectedLanguageString (lexical_form, language, base_direction) ->
            sprintf "\"%s\"@%s--%s" lexical_form (language.ToString()) (base_direction.ToString())
        | DirectedRegionString (lexical_form, language, region, base_direction) ->
            sprintf
                "\"%s\"@%s-%s--%s"
                lexical_form
                (language.ToString())
                (region.ToString())
                (base_direction.ToString())

    member this.ddot =
        match this with
        | SimpleLiteral lexical_form -> sprintf "\"%s\"" lexical_form
        | LongLiteral lexical_form -> sprintf "\"\"\"%s\"\"\"" lexical_form
        | DatatypedLiteral (lexical_form, datatype) -> sprintf "\"%s\",,^^%s" lexical_form datatype.nt
        | LanguageString (lexical_form, language) -> sprintf "\"%s\",,%s" lexical_form (language.ToString())
        | RegionString (lexical_form, language, region) ->
            sprintf "\"%s\",,@%s-%s" lexical_form (language.ToString()) (region.ToString())
        | DirectedLanguageString (lexical_form, language, base_direction) ->
            sprintf "\"%s\",,@%s--%s" lexical_form (language.ToString()) (base_direction.ToString())
        | DirectedRegionString (lexical_form, language, region, base_direction) ->
            sprintf
                "\"%s\",,@%s-%s--%s"
                lexical_form
                (language.ToString())
                (region.ToString())
                (base_direction.ToString())

    member this.as_object = Object_Term.FromLiteral this

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
    member this.lexical_form = this.ToString()

/// https://www.w3.org/TR/rdf12-concepts/#section-terms
and [<RequireQualifiedAccess; StructuralComparison; StructuralEquality>] private Rdf_Term =

    {

      lexical_form: string
      datatype: Term option
      language: string option
      region: string option
      base_direction: Initial_Text_Direction option
      subject_term: Term option
      predicate_term: Term option
      object_term: Term option

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
              subject_term = None
              predicate_term = None
              object_term = None
              datatype = None
              language = None
              region = None
              base_direction = None

            }

    static member from_blank_node(blank_node: Blank_Node) =

        RdfBlankNode
            {

              lexical_form = blank_node.rdf_string
              subject_term = None
              predicate_term = None
              object_term = None
              datatype = None
              language = None
              region = None
              base_direction = None

            }

    static member from_atomic_iri(atomic_iri: Atomic_Iri) =

        RdfIri
            {

              lexical_form = atomic_iri.rdf_string
              subject_term = None
              predicate_term = None
              object_term = None
              datatype = None
              language = None
              region = None
              base_direction = None

            }

    static member from_namespaced_iri(namespaced_iri: Namespaced_Iri) =

        RdfIri
            {

              lexical_form = namespaced_iri.rdf_string
              subject_term = None
              predicate_term = None
              object_term = None
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

    static member from_literal(literal: Literal) =
        match literal with
        | SimpleLiteral lexical_form ->
            RdfLiteral
                {

                  lexical_form = lexical_form
                  subject_term = None
                  predicate_term = None
                  object_term = None
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
                  subject_term = None
                  predicate_term = None
                  object_term = None
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
                  subject_term = None
                  predicate_term = None
                  object_term = None
                  datatype = Some(Term.from_iri datatype)
                  language = None
                  region = None
                  base_direction = None

                }
        | LanguageString (lexical_form, language) ->
            RdfLiteral
                {

                  lexical_form = lexical_form
                  subject_term = None
                  predicate_term = None
                  object_term = None
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
                  subject_term = None
                  predicate_term = None
                  object_term = None
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
                  subject_term = None
                  predicate_term = None
                  object_term = None
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
                  subject_term = None
                  predicate_term = None
                  object_term = None
                  datatype =
                    Some(
                        AtomicIri "http://www.w3.org/1999/02/22-rdf-syntax-ns#dirLangString"
                        |> Term.from_atomic_iri
                    )
                  language = Some(language.ToString().ToLowerInvariant())
                  region = Some(region.ToString().ToLowerInvariant())
                  base_direction = Some(base_direction)

                }

    static member from_subject(subject_term: Subject_Term) =
        match subject_term with
        | Subject_Term.FromIri iri -> Term.from_iri iri
        | Subject_Term.FromBlankNode blank_node -> Term.from_blank_node blank_node

    static member from_predicate(predicate_term: Predicate_Term) =
        match predicate_term with
        | Predicate_Term.FromIri iri -> Term.from_iri iri

    static member from_object(object_term: Object_Term) =
        match object_term with
        | Object_Term.FromIri iri -> Term.from_iri iri
        | Object_Term.FromBlankNode blank_node -> Term.from_blank_node blank_node
        | Object_Term.FromLiteral literal -> Term.from_literal literal
        | Object_Term.FromTripleTerm triple_term -> Term.from_triple_term triple_term

    static member from_triple(triple: Triple) =
        RdfTriple
            {

              lexical_form = triple.rdf_string
              subject_term = Some(Term.from_subject triple.curSubject)
              predicate_term = Some(Term.from_predicate triple.curPredicate)
              object_term = Some(Term.from_object triple.curObject)
              datatype = None
              language = None
              region = None
              base_direction = None

            }

    static member from_triple_term(TripleTerm triple) = Term.from_triple triple

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
        | :? Triple as triple -> Term.from_triple triple
        | :? Triple_Term as triple_term -> Term.from_triple_term triple_term
        | :? Subject_Term as subject_term -> Term.from_subject subject_term
        | :? Predicate_Term as predicate_term -> Term.from_predicate predicate_term
        | :? Object_Term as object_term -> Term.from_object object_term
        | :? Iri as iri -> Term.from_iri iri
        | :? Namespaced_Iri as namespaced_iri -> Term.from_namespaced_iri namespaced_iri
        | :? Atomic_Iri as atomic_iri -> Term.from_atomic_iri atomic_iri
        | :? Skolem_Iri as skolem_iri -> Term.from_skolem_iri skolem_iri
        | :? Blank_Node as blank_node -> Term.from_blank_node blank_node
        | :? Literal as literal -> Term.from_literal literal
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
