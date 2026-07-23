module DoxAletheia.Rdf_Shorthand

open Rdf_Document

open System
open System.Globalization
open System.Xml


// variable instantiation
let (!?) (identifier: string) = Rdf_Variable.question identifier
let (!%) (identifier: string) = Rdf_Variable.dollar identifier




// lexical adders

let (.*@) lexical_form language_tag =
    LanguageString(lexical_form, language_tag)

let (.*@@) lexical_form (language_tag, region_subtag) =
    RegionString(lexical_form, language_tag, region_subtag)

let (.*^) lexical_form datatype =
    DatatypedLiteral(lexical_form, datatype)
// TODO consider something for long string literals


// unary starters
let inline (!>) (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject)) : Formula =
    Formula.from_subject subject_term.as_subject

let inline (!|) (subject_terms: ^SubjectType list when ^SubjectType: (member as_subject: Rdf_Subject)) : Formula =
    subject_terms
    |> List.map (fun subject_term -> subject_term.as_subject)
    |> Formula.from_subjects

let inline (!-) (predicate_term: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate)) : Formula =
    Formula.from_predicate predicate_term.as_predicate

let inline (!<) (object_term: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object)) : Formula =
    Formula.from_object object_term.as_object

let inline (!<=) value_object =
    Literal.autotyped value_object
    |> Rdf_Object.LiteralObject
    |> Formula.from_object


// subject adders
let inline (-!>) (draft: Formula) (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject)) =
    draft.add_subject subject_term.as_subject

let inline (-!|)
    (draft: Formula)
    (subject_terms: ^SubjectType list when ^SubjectType: (member as_subject: Rdf_Subject))
    =
    subject_terms
    |> List.map (fun subject_term -> subject_term.as_subject)
    |> List.toArray
    |> draft.add_subjects


// predicate adders
let inline (---)
    (draft: Formula)
    (predicate_term: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate))
    =
    draft.add_predicate predicate_term.as_predicate

let inline (--|)
    (draft: Formula)
    (predicate_terms: ^PredicateType list when ^PredicateType: (member as_predicate: Rdf_Predicate))
    =
    predicate_terms
    |> List.toArray
    |> Array.Parallel.map (fun predicate_term -> predicate_term.as_predicate)
    |> draft.add_predicates

// predicateObjectList adders
let inline (-~|) (draft: Formula) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists
    |> List.toArray
    |> draft.add_predicateObjectLists

let inline (-~|>) (draft: Formula) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists
    |> List.toArray
    |> draft.add_predicateObjectLists
    |> Formula.materialize_triples


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
        [| Literal.autotyped value_object
           |> Rdf_Object.LiteralObject |]


let inline (->=|) (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate)) value_objects =
    let objects =
        value_objects
        |> List.map (fun value_object ->
            Literal.autotyped value_object
            |> Rdf_Object.LiteralObject)
        |> List.toArray

    PredicateObjectList.from_terms predicate.as_predicate objects


let inline (-->) (draft: Formula) (object_term: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object)) =
    draft.add_object object_term.as_object
    |> Formula.materialize_triples

let inline (-<-) (draft: Formula) (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject)) =
    draft.add_subject subject_term.as_subject
    |> Formula.materialize_triples

let inline (-<-/) (draft: Formula) (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject)) =
    let materialized_draft =
        draft.add_subject subject_term.as_subject
        |> Formula.materialize_triples

    { materialized_draft with

        subjects = [| subject_term.as_subject |]

     }

let inline (-->/) (draft: Formula) (object_term: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object)) =
    let materialized_draft =
        draft.add_object object_term.as_object
        |> Formula.materialize_triples

    { materialized_draft with

        subjects =
            match object_term.as_object.maybe_subject with
            | Some subject -> [| subject |]
            | None -> [||]

     }

let inline (-->=) (draft: Formula) literal =
    draft.add_literal literal
    |> Formula.materialize_triples

let inline (-->^) (draft: Formula) (lexical_form: string) (datatype: IRIREF) =
    draft.add_literal (lexical_form .*^ datatype)
    |> Formula.materialize_triples

let inline (-->@) (draft: Formula) (lexical_form: string) (language_tag: Language_Tag) =
    lexical_form .*@ language_tag
    |> draft.add_literal
    |> Formula.materialize_triples

let inline (-->@@) (draft: Formula) (lexical_form: string) (language_tag: Language_Tag) (region_subtag: Region_Subtag) =
    lexical_form .*@@ (language_tag, region_subtag)
    |> draft.add_literal
    |> Formula.materialize_triples


let inline (-->=|) (draft: Formula) literals =
    draft.add_literals literals
    |> Formula.materialize_triples

let inline (-->^|) (draft: Formula) (lexical_forms: string list) (datatype: IRIREF) =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form .*^ datatype)
    |> draft.add_literals
    |> Formula.materialize_triples

let inline (-->@|) (draft: Formula) (lexical_forms: string list) (language_tag: Language_Tag) =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form .*@ language_tag)
    |> draft.add_literals
    |> Formula.materialize_triples

let inline (-->@@|)
    (draft: Formula)
    (lexical_forms: string list)
    (language_tag: Language_Tag)
    (region_subtag: Region_Subtag)
    =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form .*@@ (language_tag, region_subtag))
    |> draft.add_literals
    |> Formula.materialize_triples




/// predicate object+
let inline (-->|) (draft: Formula) (object_terms: ^ObjectType list when ^ObjectType: (member as_object: Rdf_Object)) =
    object_terms
    |> List.toArray
    |> Array.Parallel.map (fun object_term -> object_term.as_object)
    |> draft.add_objects
    |> Formula.materialize_triples

/// formulas

let inline (-*|) (draft: Formula) (formula_list: Formula list) =
    formula_list
    |> draft.add_formulas
    |> Formula.materialize_triples
