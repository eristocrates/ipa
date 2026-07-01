namespace MyNamespace

open System

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

type LangTag = Language_Subtag

[<StructuralComparison; StructuralEquality>]
type Triple =
    { curSubject: Subject_Term
      curPredicate: Predicate_Term
      curObject: Object_Term }

    member this.subject_string = this.curSubject.rdf_string
    member this.subject_nrepresentation = this.curSubject.nrepresentation

    member this.named_subject =
        match this.curSubject with
        | Subject_Term.FromNamedResource named_resource -> Some named_resource
        | Subject_Term.FromAnonymousResource _ -> None

    member this.anonymous_subject =
        match this.curSubject with
        | Subject_Term.FromNamedResource _ -> None
        | Subject_Term.FromAnonymousResource anonymous_resource -> Some anonymous_resource

    member this.predicate =
        match this.curPredicate with
        | Predicate_Term.FromNamedResource named_resource -> named_resource

    member this.predicate_string =
        match this.curPredicate with
        | Predicate_Term.FromNamedResource named_resource -> named_resource.rdf_string

    member this.predicate_nrepresentation =
        match this.curPredicate with
        | Predicate_Term.FromNamedResource named_resource -> named_resource.nrepresentation

    member this.object_nrepresentation = this.curObject.nrepresentation

    member this.named_object =
        match this.curObject with
        | Object_Term.FromNamedResource named_resource -> Some named_resource
        | Object_Term.FromAnonymousResource _ -> None
        | Object_Term.FromLiteral _ -> None
        | Object_Term.FromTripleTerm _ -> None

    member this.anonymous_object =
        match this.curObject with
        | Object_Term.FromNamedResource _ -> None
        | Object_Term.FromAnonymousResource anonymous_resource -> Some anonymous_resource
        | Object_Term.FromLiteral _ -> None
        | Object_Term.FromTripleTerm _ -> None

    member this.literal_object =
        match this.curObject with
        | Object_Term.FromNamedResource _ -> None
        | Object_Term.FromAnonymousResource _ -> None
        | Object_Term.FromLiteral literal -> Some literal
        | Object_Term.FromTripleTerm _ -> None

    member this.triple_object =
        match this.curObject with
        | Object_Term.FromNamedResource _ -> None
        | Object_Term.FromAnonymousResource _ -> None
        | Object_Term.FromLiteral _ -> None
        | Object_Term.FromTripleTerm triple_term -> Some triple_term

    member this.nrepresentation =
        sprintf "%s %s %s ." this.subject_nrepresentation this.predicate_nrepresentation this.object_nrepresentation

and [<RequireQualifiedAccess; StructuralComparison; StructuralEquality>] Subject_Term =
    | FromNamedResource of Named_Resource
    | FromAnonymousResource of Anonymous_Resource
    member this.rdf_string =
        match this with
        | FromNamedResource named_resource -> named_resource.rdf_string
        | FromAnonymousResource anonymous_Resource -> anonymous_Resource.rdf_string

    member this.nrepresentation =
        match this with
        | FromNamedResource named_resource -> named_resource.nrepresentation
        | FromAnonymousResource anonymous_Resource -> anonymous_Resource.nrepresentation

and [<RequireQualifiedAccess; StructuralComparison; StructuralEquality>] Predicate_Term =
    | FromNamedResource of Named_Resource
    member this.nrepresentation =
        match this with
        | FromNamedResource named_resource -> named_resource.nrepresentation

and [<RequireQualifiedAccess; StructuralComparison; StructuralEquality>] Object_Term =
    | FromNamedResource of Named_Resource
    | FromAnonymousResource of Anonymous_Resource
    | FromLiteral of Literal
    | FromTripleTerm of Triple_Term
    member this.nrepresentation =
        match this with
        | FromNamedResource named_resource -> named_resource.nrepresentation
        | FromAnonymousResource anonymous_resource -> anonymous_resource.nrepresentation
        | FromLiteral literal -> literal.nrepresentation
        | FromTripleTerm triple_term -> triple_term.nrepresentation

and [<StructuralComparison; StructuralEquality>] Triple_Term =
    | TripleTerm of subject: Subject_Term * predicate: Predicate_Term * object: Object_Term
    member this.nrepresentation =
        match this with

        | TripleTerm (subject, predicate, object) ->
            sprintf "<<(%s %s %s )>>" subject.nrepresentation predicate.nrepresentation object.nrepresentation


and [<CustomComparison; CustomEquality>] Named_Resource =
    | AtomicIri of iri: string
    | NamespacedIri of namespace_name: string * local_name: string

    member this.rdf_string: string =
        match this with
        | AtomicIri iri -> iri

        | NamespacedIri (namespace_name, local_name) -> namespace_name + local_name

    member this.nrepresentation = sprintf "<%s>" this.rdf_string

    member this.as_subject = Subject_Term.FromNamedResource this

    member this.as_predicate = Predicate_Term.FromNamedResource this

    member this.as_object = Object_Term.FromNamedResource this

    interface IComparable with
        member this.CompareTo other =
            match other with
            | :? Named_Resource as other -> StringComparer.Ordinal.Compare(this.rdf_string, other.rdf_string)

            | _ -> invalidArg "other" "Cannot compare Named_Resource with another type."

    override this.Equals other =
        match other with
        | :? Named_Resource as other -> StringComparer.Ordinal.Equals(this.rdf_string, other.rdf_string)

        | _ -> false

    override this.GetHashCode() =
        StringComparer.Ordinal.GetHashCode(this.rdf_string)

and [<StructuralComparison; StructuralEquality>] Anonymous_Resource =
    | BlankNode of label: string
    | SkolemIri of well_known_base: string * identifier: Guid

    member this.rdf_string =
        match this with
        | BlankNode label -> label
        | SkolemIri (well_known_base, identifier) -> well_known_base + identifier.ToString("N")

    member this.nrepresentation =

        match this with
        | BlankNode label -> sprintf "_:%s" label
        | SkolemIri (well_known_base, identifier) ->
            sprintf "<%s>" well_known_base
            + identifier.ToString("N")

    member this.as_subject = Subject_Term.FromAnonymousResource this

    member this.as_object = Object_Term.FromAnonymousResource this

and [<StructuralComparison; StructuralEquality>] Literal =
    | SimpleLiteral of lexical_form: string
    | DatatypedLiteral of lexical_form: string * datatype: Named_Resource
    | LanguageString of lexical_form: string * language: Language_Subtag
    | RegionString of lexical_form: string * language: Language_Subtag * region: Region_Subtag
    | DirectedLanguageString of
        lexical_form: string *
        language: Language_Subtag *
        base_direction: Language_Base_Direction
    | DirectedRegionString of
        lexical_form: string *
        language: Language_Subtag *
        region: Region_Subtag *
        base_direction: Language_Base_Direction
    member this.nrepresentation =
        match this with
        | SimpleLiteral lexical_form -> sprintf "\"%s\"^^<http://www.w3.org/2001/XMLSchema#string>" lexical_form
        | DatatypedLiteral (lexical_form, datatype) -> sprintf "\"%s\"^^%s" lexical_form datatype.nrepresentation
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

    member this.as_object = Object_Term.FromLiteral this

and [<StructuralComparison; StructuralEquality>] Language_Base_Direction =
    | Ltr
    | Rtl

type Rdf_Graph =
    | RdfGraph of Set<Triple>
    member this.nrepresentation =
        let (RdfGraph triples) = this

        triples
        |> Seq.map (fun triple -> triple.nrepresentation)
        |> String.concat "\""

type Named_Graph =
    { name: Named_Resource option
      graph: Rdf_Graph }

type Rdf_Dataset =
    {

      default_graph: Rdf_Graph
      named_graphs: Named_Graph seq

     }

type Quad =
    { triple: Triple
      curGraph: Subject_Term option }

    member this.named_subject = this.triple.named_subject

    member this.anonymous_subject = this.triple.anonymous_subject

    member this.predicate = this.triple.predicate

    member this.named_object = this.triple.named_object

    member this.anonymous_object = this.triple.anonymous_object

    member this.literal_object = this.triple.literal_object

    member this.triple_object = this.triple.triple_object

    member this.named_graph =
        match this.curGraph with
        | Some graph_name ->
            match graph_name with
            | Subject_Term.FromNamedResource named_resource -> Some named_resource
            | Subject_Term.FromAnonymousResource _ -> None
        | None -> None

    member this.anonymous_graph =
        match this.curGraph with
        | Some graph_name ->
            match graph_name with
            | Subject_Term.FromNamedResource _ -> None
            | Subject_Term.FromAnonymousResource anonymous_resource -> Some anonymous_resource
        | None -> None
