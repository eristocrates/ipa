module DoxAletheia.Rdf_Shorthand

open Rdf_Document
open Rdf_Vocabulary
open System
open System.Globalization
open System.Xml







// lexical adders

let (^@) lexical_form language_tag =
    LanguageString(lexical_form, language_tag)

let (^@@) lexical_form (language_tag, region_subtag) =
    RegionString(lexical_form, language_tag, region_subtag)

let (^^) lexical_form datatype =
    DatatypedLiteral(lexical_form, datatype)
// TODO consider something for long string literals


// unary starters
let inline (!>) (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject)) : Draft_Document =
    Draft_Document.from_subject subject_term.as_subject

let inline (!|)
    (subject_terms: ^SubjectType list when ^SubjectType: (member as_subject: Rdf_Subject))
    : Draft_Document =
    subject_terms
    |> List.map (fun subject_term -> subject_term.as_subject)
    |> Draft_Document.from_subjects

let inline (!/)
    (predicate_term: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate))
    : Draft_Document =
    Draft_Document.from_predicate predicate_term.as_predicate

let inline (!<) (object_term: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object)) : Draft_Document =
    Draft_Document.from_object object_term.as_object

let inline (!<=) value_object =
    Rdf_Literal.autotyped value_object
    |> Rdf_Object.LiteralObject
    |> Draft_Document.from_object


// subject adders
let inline (-!>)
    (draft: Draft_Document)
    (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject))
    =
    draft.add_subject subject_term.as_subject

let inline (-!|)
    (draft: Draft_Document)
    (subject_terms: ^SubjectType list when ^SubjectType: (member as_subject: Rdf_Subject))
    =
    subject_terms
    |> List.map (fun subject_term -> subject_term.as_subject)
    |> List.toArray
    |> draft.add_subjects


// predicate adders
let inline (---)
    (draft: Draft_Document)
    (predicate_term: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate))
    =
    draft.add_predicate predicate_term.as_predicate

let inline (--|)
    (draft: Draft_Document)
    (predicate_terms: ^PredicateType list when ^PredicateType: (member as_predicate: Rdf_Predicate))
    =
    predicate_terms
    |> List.toArray
    |> Array.Parallel.map (fun predicate_term -> predicate_term.as_predicate)
    |> draft.add_predicates

// predicateObjectList adders
let inline (-~|) (draft: Draft_Document) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists
    |> List.toArray
    |> draft.add_predicateObjectLists

let inline (-~|>) (draft: Draft_Document) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists
    |> List.toArray
    |> draft.add_predicateObjectLists
    |> Draft_Document.materialize_triples


let inline (->-)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate))
    (object: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object))
    =
    PredicateObjectList.from_terms predicate.as_predicate [| object.as_object |]

let inline (->|)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate))
    (object_terms: ^ObjectType list when ^ObjectType: (member as_object: Rdf_Object))
    =
    let objects =
        object_terms
        |> List.toArray
        |> Array.Parallel.map (fun object_term -> object_term.as_object)

    PredicateObjectList.from_terms predicate.as_predicate objects

let inline (->=) (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate)) value_object =
    PredicateObjectList.from_terms
        predicate.as_predicate
        [| Rdf_Literal.autotyped value_object
           |> Rdf_Object.LiteralObject |]

let inline (->=|) (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate)) value_objects =
    let objects =
        value_objects
        |> List.map (fun value_object ->
            Rdf_Literal.autotyped value_object
            |> Rdf_Object.LiteralObject)
        |> List.toArray

    PredicateObjectList.from_terms predicate.as_predicate objects


let inline (-->) (draft: Draft_Document) (object_term: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object)) =
    draft.add_object object_term.as_object
    |> Draft_Document.materialize_triples

let inline (-<-)
    (draft: Draft_Document)
    (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject))
    =
    draft.add_subject subject_term.as_subject
    |> Draft_Document.materialize_triples

let inline (-<-/)
    (draft: Draft_Document)
    (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject))
    =
    let materialized_draft =
        draft.add_subject subject_term.as_subject
        |> Draft_Document.materialize_triples

    { materialized_draft with

        subjects = [| subject_term.as_subject |]

     }

let inline (-->/) (draft: Draft_Document) (object_term: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object)) =
    let materialized_draft =
        draft.add_object object_term.as_object
        |> Draft_Document.materialize_triples

    { materialized_draft with

        subjects =
            match object_term.as_object.maybe_subject with
            | Some subject -> [| subject |]
            | None -> [||]

     }

let inline (-->=) (draft: Draft_Document) literal =
    draft.add_literal literal
    |> Draft_Document.materialize_triples

let inline (-->^) (draft: Draft_Document) (lexical_form: string) (datatype: IRIREF) =
    draft.add_literal (lexical_form ^^ datatype)
    |> Draft_Document.materialize_triples

let inline (-->@) (draft: Draft_Document) (lexical_form: string) (language_tag: Language_Tag) =
    lexical_form ^@ language_tag
    |> draft.add_literal
    |> Draft_Document.materialize_triples

let inline (-->@@)
    (draft: Draft_Document)
    (lexical_form: string)
    (language_tag: Language_Tag)
    (region_subtag: Region_Subtag)
    =
    lexical_form ^@@ (language_tag, region_subtag)
    |> draft.add_literal
    |> Draft_Document.materialize_triples


let inline (-->=|) (draft: Draft_Document) literals =
    draft.add_literals literals
    |> Draft_Document.materialize_triples

let inline (-->^|) (draft: Draft_Document) (lexical_forms: string list) (datatype: IRIREF) =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form ^^ datatype)
    |> draft.add_literals
    |> Draft_Document.materialize_triples

let inline (-->@|) (draft: Draft_Document) (lexical_forms: string list) (language_tag: Language_Tag) =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form ^@ language_tag)
    |> draft.add_literals
    |> Draft_Document.materialize_triples

let inline (-->@@|)
    (draft: Draft_Document)
    (lexical_forms: string list)
    (language_tag: Language_Tag)
    (region_subtag: Region_Subtag)
    =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form ^@@ (language_tag, region_subtag))
    |> draft.add_literals
    |> Draft_Document.materialize_triples




/// predicate object+
let inline (-->|)
    (draft: Draft_Document)
    (object_terms: ^ObjectType list when ^ObjectType: (member as_object: Rdf_Object))
    =
    object_terms
    |> List.toArray
    |> Array.Parallel.map (fun object_term -> object_term.as_object)
    |> draft.add_objects
    |> Draft_Document.materialize_triples
