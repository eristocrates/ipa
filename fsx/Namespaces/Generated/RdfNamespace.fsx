#I @"D:\https\com\github\eristocrates\ipa\dll\"
#r @"ResourceDescription.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx\"
open ResourceDescription
#load @".paket/load/main.group.fsx"
open System

module rdf =
    let _namespace =
        NamedReference "http://www.w3.org/1999/02/22-rdf-syntax-ns#" |> NamespaceName

    let _rdfType = NamedReference "http://www.w3.org/1999/02/22-rdf-syntax-ns#type"

    let _owlNamedIndividual =
        NamedReference "http://www.w3.org/2002/07/owl#NamedIndividual"

    let rest = _namespace.prefixedName "rest"

    module List =
        let Class = _namespace.prefixedName "List"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract first: Formula
            abstract rest: Formula
            abstract type_: Formula
            abstract value: Formula

        type Instance(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            member this.first =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "first").asPredicate)

            member this.rest =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "rest").asPredicate)

            member this.type_ =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

            member this.value =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.first =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "first").asPredicate)

                member this.rest =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "rest").asPredicate)

                member this.type_ =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

                member this.value =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            member this.first =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "first").asPredicate)

            member this.rest =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "rest").asPredicate)

            member this.type_ =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

            member this.value =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.first =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "first").asPredicate)

                member this.rest =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "rest").asPredicate)

                member this.type_ =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

                member this.value =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

    let type_ = _namespace.prefixedName "type"

    module Property =
        let Class = _namespace.prefixedName "Property"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract type_: Formula
            abstract value: Formula

        type Instance(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            member this.type_ =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

            member this.value =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.type_ =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

                member this.value =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            member this.type_ =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

            member this.value =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.type_ =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

                member this.value =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

    let JSON = _namespace.prefixedName "JSON"
    let HTML = _namespace.prefixedName "HTML"
    let PlainLiteral = _namespace.prefixedName "PlainLiteral"
    let value = _namespace.prefixedName "value"
    let predicate = _namespace.prefixedName "predicate"

    module Statement =
        let Class = _namespace.prefixedName "Statement"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract object: Formula
            abstract predicate: Formula
            abstract subject: Formula
            abstract type_: Formula
            abstract value: Formula

        type Instance(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            member this.object =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "object").asPredicate)

            member this.predicate =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "predicate").asPredicate)

            member this.subject =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "subject").asPredicate)

            member this.type_ =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

            member this.value =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.object =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "object").asPredicate)

                member this.predicate =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "predicate").asPredicate)

                member this.subject =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "subject").asPredicate)

                member this.type_ =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

                member this.value =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            member this.object =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "object").asPredicate)

            member this.predicate =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "predicate").asPredicate)

            member this.subject =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "subject").asPredicate)

            member this.type_ =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

            member this.value =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.object =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "object").asPredicate)

                member this.predicate =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "predicate").asPredicate)

                member this.subject =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "subject").asPredicate)

                member this.type_ =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

                member this.value =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

    let langString = _namespace.prefixedName "langString"

    module Alt =
        let Class = _namespace.prefixedName "Alt"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject

        type Instance(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

    module CompoundLiteral =
        let Class = _namespace.prefixedName "CompoundLiteral"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract direction: Formula
            abstract language: Formula
            abstract type_: Formula
            abstract value: Formula

        type Instance(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            member this.direction =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "direction").asPredicate)

            member this.language =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "language").asPredicate)

            member this.type_ =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

            member this.value =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.direction =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "direction").asPredicate)

                member this.language =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "language").asPredicate)

                member this.type_ =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

                member this.value =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            member this.direction =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "direction").asPredicate)

            member this.language =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "language").asPredicate)

            member this.type_ =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

            member this.value =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.direction =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "direction").asPredicate)

                member this.language =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "language").asPredicate)

                member this.type_ =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "type").asPredicate)

                member this.value =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "value").asPredicate)

    let subject = _namespace.prefixedName "subject"

    module Bag =
        let Class = _namespace.prefixedName "Bag"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject

        type Instance(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

    let XMLLiteral = _namespace.prefixedName "XMLLiteral"
    let object = _namespace.prefixedName "object"
    let direction = _namespace.prefixedName "direction"
    let nil = _namespace.prefixedName "nil"
    let language = _namespace.prefixedName "language"
    let first = _namespace.prefixedName "first"

    module Seq =
        let Class = _namespace.prefixedName "Seq"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject

        type Instance(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula
            member this.asSubject = iri.asSubject
            member this.asPredicate = iri.asPredicate
            member this.asObject = iri.asObject

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject
