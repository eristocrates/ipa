module DoxAletheia.RDF_Shorthand

open System
open System.IO
open System.Xml
open System.Globalization
open System.Collections


open VDS.RDF
open VDS.RDF.Nodes
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Patterns
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF.Query.Datasets
open VDS.RDF.Storage
open VDS.RDF.Query
open VDS.RDF.Parsing.Tokens


open FSharp.Data
open FSharp.Data.Adaptive.Transaction
open FSharp.HashCollections
open FSharp.Collections.ParallelSeq


open Swensen.Unquote.Assertions


open DoxAletheia

open type Prefix_ID
open DotNetRDFSharp
open NamespaceRegistry
open PrettierNaming





































// variable instantiation
let (!?) (identifier: string) = RDF_Variable identifier




// lexical adders

let (.*@) (lexical_form: string) (language_subtag: Language_Subtag) =
    RDF_Literal.language lexical_form language_subtag

let (.*@@) (lexical_form: string) (language_region: Language_Subtag * Region_Subtag) =
    let language_subtag, region_subtag = language_region
    RDF_Literal.region lexical_form language_subtag region_subtag



let (.*^) (lexical_form: string) (datatype_iri: Iri) =
    RDF_Literal.datatyped lexical_form datatype_iri
// TODO consider something for long string literals


// unary starters
let inline (!>) (subject_term: ^SubjectType when ^SubjectType: (member as_subject: RDF_Subject)) : Formula =
    Formula.from_subject subject_term.as_subject

let inline (!|) (subject_terms: ^SubjectType list when ^SubjectType: (member as_subject: RDF_Subject)) : Formula =
    subject_terms
    |> List.map (fun subject_term -> subject_term.as_subject)
    |> Formula.from_subjects

let inline (!-) (predicate_term: ^PredicateType when ^PredicateType: (member as_predicate: RDF_Predicate)) : Formula =
    Formula.from_predicate predicate_term.as_predicate

let inline (!<) (object_term: ^ObjectType when ^ObjectType: (member as_object: RDF_Object)) : Formula =
    Formula.from_object object_term.as_object

let inline (!<=) value_object =
    RDF_Literal.autotyped value_object
    |> RDF_Object.LiteralObject
    |> Formula.from_object


// subject adders
let inline (-!>) (draft: Formula) (subject_term: ^SubjectType when ^SubjectType: (member as_subject: RDF_Subject)) =
    draft.add_subject subject_term.as_subject

let inline (-!|)
    (draft: Formula)
    (subject_terms: ^SubjectType list when ^SubjectType: (member as_subject: RDF_Subject))
    =
    subject_terms
    |> List.map (fun subject_term -> subject_term.as_subject)
    |> List.toArray
    |> draft.add_subjects


// predicate adders
let inline (---)
    (draft: Formula)
    (predicate_term: ^PredicateType when ^PredicateType: (member as_predicate: RDF_Predicate))
    =
    draft.add_predicate predicate_term.as_predicate

let inline (--|)
    (draft: Formula)
    (predicate_terms: ^PredicateType list when ^PredicateType: (member as_predicate: RDF_Predicate))
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
    |> Formula.materialize_formula


let inline (->-)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: RDF_Predicate))
    (object: ^ObjectType when ^ObjectType: (member as_object: RDF_Object))
    =
    PredicateObjectList.from_terms predicate.as_predicate [| object.as_object |]

let inline (->|)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: RDF_Predicate))
    (object_terms: ^ObjectType list when ^ObjectType: (member as_object: RDF_Object))
    =
    let objects =
        object_terms
        |> List.toArray
        |> Array.Parallel.map (fun object_term -> object_term.as_object)

    PredicateObjectList.from_terms predicate.as_predicate objects

let inline (->=) (predicate: ^PredicateType when ^PredicateType: (member as_predicate: RDF_Predicate)) value_object =
    PredicateObjectList.from_terms
        predicate.as_predicate
        [| RDF_Literal.autotyped value_object
           |> RDF_Object.LiteralObject |]


let inline (->=|) (predicate: ^PredicateType when ^PredicateType: (member as_predicate: RDF_Predicate)) value_objects =
    let objects =
        value_objects
        |> List.map (fun value_object ->
            RDF_Literal.autotyped value_object
            |> RDF_Object.LiteralObject)
        |> List.toArray

    PredicateObjectList.from_terms predicate.as_predicate objects

    // object adders

let inline (-->) (draft: Formula) (object_term: ^ObjectType when ^ObjectType: (member as_object: RDF_Object)) =
    draft.add_object object_term.as_object
    |> Formula.materialize_formula

let inline (-<-) (draft: Formula) (subject_term: ^SubjectType when ^SubjectType: (member as_subject: RDF_Subject)) =
    draft.add_subject subject_term.as_subject
    |> Formula.materialize_formula

let inline (-<-/) (draft: Formula) (subject_term: ^SubjectType when ^SubjectType: (member as_subject: RDF_Subject)) =
    let materialized_draft =
        draft.add_subject subject_term.as_subject
        |> Formula.materialize_formula

    { materialized_draft with

        subjects = [| subject_term.as_subject |]

     }

let inline (-->/) (draft: Formula) (object_term: ^ObjectType when ^ObjectType: (member as_object: RDF_Object)) =
    let materialized_draft =
        draft.add_object object_term.as_object
        |> Formula.materialize_formula

    { materialized_draft with

        subjects =
            match object_term.as_object.maybe_subject with
            | Some subject -> [| subject |]
            | None -> [||]

     }

let inline (-->=) (draft: Formula) literal =
    draft.add_literal literal
    |> Formula.materialize_formula

let inline (-->^) (draft: Formula) (lexical_form: string) (datatype_iri: Iri) =
    draft.add_literal (lexical_form .*^ datatype_iri)
    |> Formula.materialize_formula

let inline (-->@) (draft: Formula) (lexical_form: string) (language_subtag: Language_Subtag) =
    lexical_form .*@ language_subtag
    |> draft.add_literal
    |> Formula.materialize_formula

let inline (-->@@)
    (draft: Formula)
    (lexical_form: string)
    (language_subtag: Language_Subtag)
    (region_subtag: Region_Subtag)
    =
    lexical_form .*@@ (language_subtag, region_subtag)
    |> draft.add_literal
    |> Formula.materialize_formula


let inline (-->=|) (draft: Formula) literals =
    draft.add_literals literals
    |> Formula.materialize_formula

let inline (-->^|) (draft: Formula) (lexical_forms: string list) (datatype_iri: Iri) =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form .*^ datatype_iri)
    |> draft.add_literals
    |> Formula.materialize_formula

let inline (-->@|) (draft: Formula) (lexical_forms: string list) (language_subtag: Language_Subtag) =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form .*@ language_subtag)
    |> draft.add_literals
    |> Formula.materialize_formula

let inline (-->@@|)
    (draft: Formula)
    (lexical_forms: string list)
    (language_subtag: Language_Subtag)
    (region_subtag: Region_Subtag)
    =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form .*@@ (language_subtag, region_subtag))
    |> draft.add_literals
    |> Formula.materialize_formula




/// predicate object+
let inline (-->|) (draft: Formula) (object_terms: ^ObjectType list when ^ObjectType: (member as_object: RDF_Object)) =
    object_terms
    |> List.toArray
    |> Array.Parallel.map (fun object_term -> object_term.as_object)
    |> draft.add_objects
    |> Formula.materialize_formula

/// formulas

let inline (-*|) (draft: Formula) (formula_list: Formula list) =
    formula_list
    |> draft.add_formulas
    |> Formula.materialize_formula
