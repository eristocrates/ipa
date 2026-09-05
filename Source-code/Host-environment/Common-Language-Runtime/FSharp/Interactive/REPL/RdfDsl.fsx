#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "RdfAsm.dll"

open RdfAsm




// variable instantiation
let (!?) (identifier: string) = RdfVariable.fromIdentifier identifier




// lexical adders

let (.*@) (lexicalForm: string) (languageTag: NLanguageTag.LanguageTag) =
    RdfLiteral.languageTagged lexicalForm languageTag


let (.*^) (lexicalForm: string) (datatypeIri: Iri) =
    RdfLiteral.datatyped lexicalForm datatypeIri
// TODO consider something for long string literals


// unary starters
let inline (!>) (subjectTerm: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject)) : Formula =
    Formula.fromRdfSubject subjectTerm.asSubject

let inline (!|) (subjectTerms: ^SubjectType list when ^SubjectType: (member asSubject: RdfSubject)) : Formula =
    subjectTerms
    |> List.map (fun subjectTerm -> subjectTerm.asSubject)
    |> Formula.fromRdfSubjects

let inline (!-) (predicateTerm: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate)) : Formula =
    Formula.fromRdfPredicate predicateTerm.asPredicate

let inline (!<) (objectTerm: ^ObjectType when ^ObjectType: (member asObject: RdfObject)) : Formula =
    Formula.fromRdfObject objectTerm.asObject

let inline (!<=) valueObject =
    RdfLiteral.autotyped valueObject
    |> RdfObject.LiteralObject
    |> Formula.fromRdfObject


// subject adders
let inline (-!>) (draft: Formula) (subjectTerm: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject)) =
    draft.addRdfSubject subjectTerm.asSubject

let inline (-!|) (draft: Formula) (subjectTerms: ^SubjectType list when ^SubjectType: (member asSubject: RdfSubject)) =
    subjectTerms
    |> List.map (fun subjectTerm -> subjectTerm.asSubject)
    |> List.toArray
    |> draft.addRdfSubjects


// predicate adders
let inline (---) (draft: Formula) (predicateTerm: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate)) =
    draft.addRdfPredicate predicateTerm.asPredicate

let inline (--|) (draft: Formula) (predicateTerms: ^PredicateType list when ^PredicateType: (member asPredicate: RdfPredicate)) =
    predicateTerms
    |> List.toArray
    |> Array.Parallel.map (fun predicateTerm -> predicateTerm.asPredicate)
    |> draft.addRdfPredicates

// predicateObjectList adders
let inline (-~|) (draft: Formula) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists
    |> List.toArray
    |> draft.addPredicateObjectLists

let inline (-~|>) (draft: Formula) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists
    |> List.toArray
    |> draft.addPredicateObjectLists
    |> Formula.materializeFormula


let inline (->-) (predicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate)) (object: ^ObjectType when ^ObjectType: (member asObject: RdfObject)) =
    PredicateObjectList.fromTerms predicate.asPredicate [| object.asObject |]

let inline (->|) (predicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate)) (objectTerms: ^ObjectType list when ^ObjectType: (member asObject: RdfObject)) =
    let objects =
        objectTerms
        |> List.toArray
        |> Array.Parallel.map (fun objectTerm -> objectTerm.asObject)

    PredicateObjectList.fromTerms predicate.asPredicate objects

let inline (->=) (predicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate)) valueObject =
    PredicateObjectList.fromTerms
        predicate.asPredicate
        [| RdfLiteral.autotyped valueObject
           |> RdfObject.LiteralObject |]


let inline (->=|) (predicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate)) valueObjects =
    let objects =
        valueObjects
        |> List.map (fun valueObject ->
            RdfLiteral.autotyped valueObject
            |> RdfObject.LiteralObject)
        |> List.toArray

    PredicateObjectList.fromTerms predicate.asPredicate objects


let inline (-->) (draft: Formula) (objectTerm: ^ObjectType when ^ObjectType: (member asObject: RdfObject)) =
    draft.addRdfObject objectTerm.asObject
    |> Formula.materializeFormula

let inline (-<-) (draft: Formula) (subjectTerm: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject)) =
    draft.addRdfSubject subjectTerm.asSubject
    |> Formula.materializeFormula

let inline (-<-/) (draft: Formula) (subjectTerm: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject)) =
    let materializedDraft =
        draft.addRdfSubject subjectTerm.asSubject
        |> Formula.materializeFormula

    { materializedDraft with

        subjects = [| subjectTerm.asSubject |]

     }

let inline (-->/) (draft: Formula) (objectTerm: ^ObjectType when ^ObjectType: (member asObject: RdfObject)) =
    let materializedDraft =
        draft.addRdfObject objectTerm.asObject
        |> Formula.materializeFormula

    { materializedDraft with

        subjects =
            match objectTerm.asObject.maybeSubject with
            | Some subject -> [| subject |]
            | None -> [||]

     }

let inline (-->=) (draft: Formula) literal =
    draft.addRdfLiteral literal
    |> Formula.materializeFormula

let inline (-->^) (draft: Formula) (lexicalForm: string) (datatype: Iri) =
    draft.addRdfLiteral (lexicalForm .*^ datatype)
    |> Formula.materializeFormula

let inline (-->@) (draft: Formula) (lexicalForm: string) (languageTag: NLanguageTag.LanguageTag) =
    lexicalForm .*@ languageTag
    |> draft.addRdfLiteral
    |> Formula.materializeFormula



let inline (-->=|) (draft: Formula) literals =
    draft.addRdfLiterals literals
    |> Formula.materializeFormula

let inline (-->^|) (draft: Formula) (lexicalForms: string list) (datatype: Iri) =
    lexicalForms
    |> List.map (fun lexicalForm -> lexicalForm .*^ datatype)
    |> draft.addRdfLiterals
    |> Formula.materializeFormula

let inline (-->@|) (draft: Formula) (lexicalForms: string list) (languageTag: NLanguageTag.LanguageTag) =
    lexicalForms
    |> List.map (fun lexicalForm -> lexicalForm .*@ languageTag)
    |> draft.addRdfLiterals
    |> Formula.materializeFormula





/// predicate object+
let inline (-->|) (draft: Formula) (objectTerms: ^ObjectType list when ^ObjectType: (member asObject: RdfObject)) =
    objectTerms
    |> List.toArray
    |> Array.Parallel.map (fun objectTerm -> objectTerm.asObject)
    |> draft.addRdfObjects
    |> Formula.materializeFormula

/// formulas

let inline (-*|) (draft: Formula) (formulaList: Formula list) =
    formulaList
    |> draft.addFormulas
    |> Formula.materializeFormula
