#I @"D:\https\com\github\eristocrates\ipa\dll\"
#r @"ResourceDescription.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx\"
open ResourceDescription
#load @".paket/load/main.group.fsx"
open System

module owl =
    let _namespace = NamedReference "http://www.w3.org/2002/07/owl#" |> NamespaceName
    let _rdfType = NamedReference "http://www.w3.org/1999/02/22-rdf-syntax-ns#type"

    let _owlNamedIndividual =
        NamedReference "http://www.w3.org/2002/07/owl#NamedIndividual"

    module DatatypeProperty =
        let Class = _namespace.prefixedName "DatatypeProperty"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract equivalentProperty: Formula
            abstract propertyDisjointWith: Formula

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

    module DeprecatedProperty =
        let Class = _namespace.prefixedName "DeprecatedProperty"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract equivalentProperty: Formula
            abstract propertyDisjointWith: Formula

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

    module AnnotationProperty =
        let Class = _namespace.prefixedName "AnnotationProperty"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract equivalentProperty: Formula
            abstract propertyDisjointWith: Formula

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

    let imports = _namespace.prefixedName "imports"

    module Ontology =
        let Class = _namespace.prefixedName "Ontology"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract annotatedProperty: Formula
            abstract annotatedSource: Formula
            abstract annotatedTarget: Formula
            abstract backwardCompatibleWith: Formula
            abstract deprecated: Formula
            abstract imports: Formula
            abstract incompatibleWith: Formula
            abstract members: Formula
            abstract priorVersion: Formula
            abstract versionIRI: Formula
            abstract versionInfo: Formula

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.backwardCompatibleWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "backwardCompatibleWith").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.imports =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "imports").asPredicate)

            member this.incompatibleWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "incompatibleWith").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.priorVersion =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "priorVersion").asPredicate)

            member this.versionIRI =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionIRI").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.backwardCompatibleWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft ->
                        draft.addRdfPredicate (_namespace.prefixedName "backwardCompatibleWith").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.imports =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "imports").asPredicate)

                member this.incompatibleWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "incompatibleWith").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.priorVersion =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "priorVersion").asPredicate)

                member this.versionIRI =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionIRI").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.backwardCompatibleWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "backwardCompatibleWith").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.imports =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "imports").asPredicate)

            member this.incompatibleWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "incompatibleWith").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.priorVersion =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "priorVersion").asPredicate)

            member this.versionIRI =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionIRI").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.backwardCompatibleWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft ->
                        draft.addRdfPredicate (_namespace.prefixedName "backwardCompatibleWith").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.imports =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "imports").asPredicate)

                member this.incompatibleWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "incompatibleWith").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.priorVersion =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "priorVersion").asPredicate)

                member this.versionIRI =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionIRI").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

    module OntologyProperty =
        let Class = _namespace.prefixedName "OntologyProperty"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract equivalentProperty: Formula
            abstract propertyDisjointWith: Formula

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

    module ObjectProperty =
        let Class = _namespace.prefixedName "ObjectProperty"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract equivalentProperty: Formula
            abstract inverseOf: Formula
            abstract propertyChainAxiom: Formula
            abstract propertyDisjointWith: Formula

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

    let intersectionOf = _namespace.prefixedName "intersectionOf"
    let annotatedSource = _namespace.prefixedName "annotatedSource"
    let backwardCompatibleWith = _namespace.prefixedName "backwardCompatibleWith"
    let annotatedTarget = _namespace.prefixedName "annotatedTarget"
    let onProperty = _namespace.prefixedName "onProperty"

    module Restriction =
        let Class = _namespace.prefixedName "Restriction"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract allValuesFrom: Formula
            abstract cardinality: Formula
            abstract complementOf: Formula
            abstract disjointUnionOf: Formula
            abstract disjointWith: Formula
            abstract equivalentClass: Formula
            abstract hasKey: Formula
            abstract hasSelf: Formula
            abstract hasValue: Formula
            abstract intersectionOf: Formula
            abstract maxCardinality: Formula
            abstract maxQualifiedCardinality: Formula
            abstract minCardinality: Formula
            abstract minQualifiedCardinality: Formula
            abstract onClass: Formula
            abstract onDataRange: Formula
            abstract onProperties: Formula
            abstract onProperty: Formula
            abstract oneOf: Formula
            abstract qualifiedCardinality: Formula
            abstract someValuesFrom: Formula
            abstract unionOf: Formula

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

            member this.allValuesFrom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "allValuesFrom").asPredicate)

            member this.cardinality =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "cardinality").asPredicate)

            member this.complementOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "complementOf").asPredicate)

            member this.disjointUnionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointUnionOf").asPredicate)

            member this.disjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointWith").asPredicate)

            member this.equivalentClass =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentClass").asPredicate)

            member this.hasKey =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasKey").asPredicate)

            member this.hasSelf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasSelf").asPredicate)

            member this.hasValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasValue").asPredicate)

            member this.intersectionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "intersectionOf").asPredicate)

            member this.maxCardinality =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maxCardinality").asPredicate)

            member this.maxQualifiedCardinality =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maxQualifiedCardinality").asPredicate)

            member this.minCardinality =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "minCardinality").asPredicate)

            member this.minQualifiedCardinality =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "minQualifiedCardinality").asPredicate)

            member this.onClass =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onClass").asPredicate)

            member this.onDataRange =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onDataRange").asPredicate)

            member this.onProperties =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onProperties").asPredicate)

            member this.onProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onProperty").asPredicate)

            member this.oneOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "oneOf").asPredicate)

            member this.qualifiedCardinality =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "qualifiedCardinality").asPredicate)

            member this.someValuesFrom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "someValuesFrom").asPredicate)

            member this.unionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "unionOf").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.allValuesFrom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "allValuesFrom").asPredicate)

                member this.cardinality =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "cardinality").asPredicate)

                member this.complementOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "complementOf").asPredicate)

                member this.disjointUnionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointUnionOf").asPredicate)

                member this.disjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointWith").asPredicate)

                member this.equivalentClass =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentClass").asPredicate)

                member this.hasKey =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasKey").asPredicate)

                member this.hasSelf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasSelf").asPredicate)

                member this.hasValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasValue").asPredicate)

                member this.intersectionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "intersectionOf").asPredicate)

                member this.maxCardinality =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maxCardinality").asPredicate)

                member this.maxQualifiedCardinality =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft ->
                        draft.addRdfPredicate (_namespace.prefixedName "maxQualifiedCardinality").asPredicate)

                member this.minCardinality =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "minCardinality").asPredicate)

                member this.minQualifiedCardinality =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft ->
                        draft.addRdfPredicate (_namespace.prefixedName "minQualifiedCardinality").asPredicate)

                member this.onClass =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onClass").asPredicate)

                member this.onDataRange =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onDataRange").asPredicate)

                member this.onProperties =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onProperties").asPredicate)

                member this.onProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onProperty").asPredicate)

                member this.oneOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "oneOf").asPredicate)

                member this.qualifiedCardinality =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "qualifiedCardinality").asPredicate)

                member this.someValuesFrom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "someValuesFrom").asPredicate)

                member this.unionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "unionOf").asPredicate)

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

            member this.allValuesFrom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "allValuesFrom").asPredicate)

            member this.cardinality =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "cardinality").asPredicate)

            member this.complementOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "complementOf").asPredicate)

            member this.disjointUnionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointUnionOf").asPredicate)

            member this.disjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointWith").asPredicate)

            member this.equivalentClass =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentClass").asPredicate)

            member this.hasKey =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasKey").asPredicate)

            member this.hasSelf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasSelf").asPredicate)

            member this.hasValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasValue").asPredicate)

            member this.intersectionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "intersectionOf").asPredicate)

            member this.maxCardinality =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maxCardinality").asPredicate)

            member this.maxQualifiedCardinality =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maxQualifiedCardinality").asPredicate)

            member this.minCardinality =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "minCardinality").asPredicate)

            member this.minQualifiedCardinality =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "minQualifiedCardinality").asPredicate)

            member this.onClass =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onClass").asPredicate)

            member this.onDataRange =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onDataRange").asPredicate)

            member this.onProperties =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onProperties").asPredicate)

            member this.onProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onProperty").asPredicate)

            member this.oneOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "oneOf").asPredicate)

            member this.qualifiedCardinality =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "qualifiedCardinality").asPredicate)

            member this.someValuesFrom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "someValuesFrom").asPredicate)

            member this.unionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "unionOf").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.allValuesFrom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "allValuesFrom").asPredicate)

                member this.cardinality =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "cardinality").asPredicate)

                member this.complementOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "complementOf").asPredicate)

                member this.disjointUnionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointUnionOf").asPredicate)

                member this.disjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointWith").asPredicate)

                member this.equivalentClass =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentClass").asPredicate)

                member this.hasKey =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasKey").asPredicate)

                member this.hasSelf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasSelf").asPredicate)

                member this.hasValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasValue").asPredicate)

                member this.intersectionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "intersectionOf").asPredicate)

                member this.maxCardinality =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maxCardinality").asPredicate)

                member this.maxQualifiedCardinality =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft ->
                        draft.addRdfPredicate (_namespace.prefixedName "maxQualifiedCardinality").asPredicate)

                member this.minCardinality =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "minCardinality").asPredicate)

                member this.minQualifiedCardinality =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft ->
                        draft.addRdfPredicate (_namespace.prefixedName "minQualifiedCardinality").asPredicate)

                member this.onClass =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onClass").asPredicate)

                member this.onDataRange =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onDataRange").asPredicate)

                member this.onProperties =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onProperties").asPredicate)

                member this.onProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onProperty").asPredicate)

                member this.oneOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "oneOf").asPredicate)

                member this.qualifiedCardinality =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "qualifiedCardinality").asPredicate)

                member this.someValuesFrom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "someValuesFrom").asPredicate)

                member this.unionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "unionOf").asPredicate)

    let differentFrom = _namespace.prefixedName "differentFrom"

    module Thing =
        let Class = _namespace.prefixedName "Thing"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract bottomDataProperty: Formula
            abstract bottomObjectProperty: Formula
            abstract differentFrom: Formula
            abstract sameAs: Formula
            abstract topDataProperty: Formula
            abstract topObjectProperty: Formula

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

            member this.bottomDataProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomDataProperty").asPredicate)

            member this.bottomObjectProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomObjectProperty").asPredicate)

            member this.differentFrom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "differentFrom").asPredicate)

            member this.sameAs =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sameAs").asPredicate)

            member this.topDataProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topDataProperty").asPredicate)

            member this.topObjectProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topObjectProperty").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.bottomDataProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomDataProperty").asPredicate)

                member this.bottomObjectProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomObjectProperty").asPredicate)

                member this.differentFrom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "differentFrom").asPredicate)

                member this.sameAs =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sameAs").asPredicate)

                member this.topDataProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topDataProperty").asPredicate)

                member this.topObjectProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topObjectProperty").asPredicate)

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

            member this.bottomDataProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomDataProperty").asPredicate)

            member this.bottomObjectProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomObjectProperty").asPredicate)

            member this.differentFrom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "differentFrom").asPredicate)

            member this.sameAs =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sameAs").asPredicate)

            member this.topDataProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topDataProperty").asPredicate)

            member this.topObjectProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topObjectProperty").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.bottomDataProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomDataProperty").asPredicate)

                member this.bottomObjectProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomObjectProperty").asPredicate)

                member this.differentFrom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "differentFrom").asPredicate)

                member this.sameAs =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sameAs").asPredicate)

                member this.topDataProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topDataProperty").asPredicate)

                member this.topObjectProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topObjectProperty").asPredicate)

    let disjointWith = _namespace.prefixedName "disjointWith"

    module Class =
        let Class = _namespace.prefixedName "Class"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract complementOf: Formula
            abstract disjointUnionOf: Formula
            abstract disjointWith: Formula
            abstract equivalentClass: Formula
            abstract hasKey: Formula
            abstract intersectionOf: Formula
            abstract oneOf: Formula
            abstract unionOf: Formula

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

            member this.complementOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "complementOf").asPredicate)

            member this.disjointUnionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointUnionOf").asPredicate)

            member this.disjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointWith").asPredicate)

            member this.equivalentClass =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentClass").asPredicate)

            member this.hasKey =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasKey").asPredicate)

            member this.intersectionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "intersectionOf").asPredicate)

            member this.oneOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "oneOf").asPredicate)

            member this.unionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "unionOf").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.complementOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "complementOf").asPredicate)

                member this.disjointUnionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointUnionOf").asPredicate)

                member this.disjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointWith").asPredicate)

                member this.equivalentClass =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentClass").asPredicate)

                member this.hasKey =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasKey").asPredicate)

                member this.intersectionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "intersectionOf").asPredicate)

                member this.oneOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "oneOf").asPredicate)

                member this.unionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "unionOf").asPredicate)

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

            member this.complementOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "complementOf").asPredicate)

            member this.disjointUnionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointUnionOf").asPredicate)

            member this.disjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointWith").asPredicate)

            member this.equivalentClass =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentClass").asPredicate)

            member this.hasKey =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasKey").asPredicate)

            member this.intersectionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "intersectionOf").asPredicate)

            member this.oneOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "oneOf").asPredicate)

            member this.unionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "unionOf").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.complementOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "complementOf").asPredicate)

                member this.disjointUnionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointUnionOf").asPredicate)

                member this.disjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "disjointWith").asPredicate)

                member this.equivalentClass =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentClass").asPredicate)

                member this.hasKey =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hasKey").asPredicate)

                member this.intersectionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "intersectionOf").asPredicate)

                member this.oneOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "oneOf").asPredicate)

                member this.unionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "unionOf").asPredicate)

    module AllDisjointProperties =
        let Class = _namespace.prefixedName "AllDisjointProperties"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract annotatedProperty: Formula
            abstract annotatedSource: Formula
            abstract annotatedTarget: Formula
            abstract deprecated: Formula
            abstract members: Formula
            abstract versionInfo: Formula

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

    let onProperties = _namespace.prefixedName "onProperties"

    module DeprecatedClass =
        let Class = _namespace.prefixedName "DeprecatedClass"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract equivalentClass: Formula
            abstract intersectionOf: Formula
            abstract oneOf: Formula
            abstract unionOf: Formula

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

            member this.equivalentClass =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentClass").asPredicate)

            member this.intersectionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "intersectionOf").asPredicate)

            member this.oneOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "oneOf").asPredicate)

            member this.unionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "unionOf").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentClass =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentClass").asPredicate)

                member this.intersectionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "intersectionOf").asPredicate)

                member this.oneOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "oneOf").asPredicate)

                member this.unionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "unionOf").asPredicate)

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

            member this.equivalentClass =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentClass").asPredicate)

            member this.intersectionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "intersectionOf").asPredicate)

            member this.oneOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "oneOf").asPredicate)

            member this.unionOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "unionOf").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentClass =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentClass").asPredicate)

                member this.intersectionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "intersectionOf").asPredicate)

                member this.oneOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "oneOf").asPredicate)

                member this.unionOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "unionOf").asPredicate)

    module FunctionalProperty =
        let Class = _namespace.prefixedName "FunctionalProperty"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract equivalentProperty: Formula
            abstract propertyDisjointWith: Formula

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

    let propertyChainAxiom = _namespace.prefixedName "propertyChainAxiom"

    module SymmetricProperty =
        let Class = _namespace.prefixedName "SymmetricProperty"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract equivalentProperty: Formula
            abstract inverseOf: Formula
            abstract propertyChainAxiom: Formula
            abstract propertyDisjointWith: Formula

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

    module NamedIndividual =
        let Class = _namespace.prefixedName "NamedIndividual"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract bottomDataProperty: Formula
            abstract bottomObjectProperty: Formula
            abstract differentFrom: Formula
            abstract sameAs: Formula
            abstract topDataProperty: Formula
            abstract topObjectProperty: Formula

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

            member this.bottomDataProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomDataProperty").asPredicate)

            member this.bottomObjectProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomObjectProperty").asPredicate)

            member this.differentFrom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "differentFrom").asPredicate)

            member this.sameAs =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sameAs").asPredicate)

            member this.topDataProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topDataProperty").asPredicate)

            member this.topObjectProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topObjectProperty").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.bottomDataProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomDataProperty").asPredicate)

                member this.bottomObjectProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomObjectProperty").asPredicate)

                member this.differentFrom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "differentFrom").asPredicate)

                member this.sameAs =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sameAs").asPredicate)

                member this.topDataProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topDataProperty").asPredicate)

                member this.topObjectProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topObjectProperty").asPredicate)

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

            member this.bottomDataProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomDataProperty").asPredicate)

            member this.bottomObjectProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomObjectProperty").asPredicate)

            member this.differentFrom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "differentFrom").asPredicate)

            member this.sameAs =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sameAs").asPredicate)

            member this.topDataProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topDataProperty").asPredicate)

            member this.topObjectProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topObjectProperty").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.bottomDataProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomDataProperty").asPredicate)

                member this.bottomObjectProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomObjectProperty").asPredicate)

                member this.differentFrom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "differentFrom").asPredicate)

                member this.sameAs =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sameAs").asPredicate)

                member this.topDataProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topDataProperty").asPredicate)

                member this.topObjectProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topObjectProperty").asPredicate)

    let maxCardinality = _namespace.prefixedName "maxCardinality"
    let inverseOf = _namespace.prefixedName "inverseOf"
    let sameAs = _namespace.prefixedName "sameAs"
    let allValuesFrom = _namespace.prefixedName "allValuesFrom"
    let complementOf = _namespace.prefixedName "complementOf"
    let propertyDisjointWith = _namespace.prefixedName "propertyDisjointWith"

    module DataRange =
        let Class = _namespace.prefixedName "DataRange"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract datatypeComplementOf: Formula
            abstract onDatatype: Formula
            abstract withRestrictions: Formula

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

            member this.datatypeComplementOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "datatypeComplementOf").asPredicate)

            member this.onDatatype =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onDatatype").asPredicate)

            member this.withRestrictions =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "withRestrictions").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.datatypeComplementOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "datatypeComplementOf").asPredicate)

                member this.onDatatype =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onDatatype").asPredicate)

                member this.withRestrictions =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "withRestrictions").asPredicate)

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

            member this.datatypeComplementOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "datatypeComplementOf").asPredicate)

            member this.onDatatype =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onDatatype").asPredicate)

            member this.withRestrictions =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "withRestrictions").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.datatypeComplementOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "datatypeComplementOf").asPredicate)

                member this.onDatatype =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "onDatatype").asPredicate)

                member this.withRestrictions =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "withRestrictions").asPredicate)

    module Nothing =
        let Class = _namespace.prefixedName "Nothing"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract bottomDataProperty: Formula
            abstract bottomObjectProperty: Formula
            abstract differentFrom: Formula
            abstract sameAs: Formula
            abstract topDataProperty: Formula
            abstract topObjectProperty: Formula

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

            member this.bottomDataProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomDataProperty").asPredicate)

            member this.bottomObjectProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomObjectProperty").asPredicate)

            member this.differentFrom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "differentFrom").asPredicate)

            member this.sameAs =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sameAs").asPredicate)

            member this.topDataProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topDataProperty").asPredicate)

            member this.topObjectProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topObjectProperty").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.bottomDataProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomDataProperty").asPredicate)

                member this.bottomObjectProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomObjectProperty").asPredicate)

                member this.differentFrom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "differentFrom").asPredicate)

                member this.sameAs =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sameAs").asPredicate)

                member this.topDataProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topDataProperty").asPredicate)

                member this.topObjectProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topObjectProperty").asPredicate)

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

            member this.bottomDataProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomDataProperty").asPredicate)

            member this.bottomObjectProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomObjectProperty").asPredicate)

            member this.differentFrom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "differentFrom").asPredicate)

            member this.sameAs =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sameAs").asPredicate)

            member this.topDataProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topDataProperty").asPredicate)

            member this.topObjectProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topObjectProperty").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.bottomDataProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomDataProperty").asPredicate)

                member this.bottomObjectProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bottomObjectProperty").asPredicate)

                member this.differentFrom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "differentFrom").asPredicate)

                member this.sameAs =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sameAs").asPredicate)

                member this.topDataProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topDataProperty").asPredicate)

                member this.topObjectProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topObjectProperty").asPredicate)

    module InverseFunctionalProperty =
        let Class = _namespace.prefixedName "InverseFunctionalProperty"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract equivalentProperty: Formula
            abstract inverseOf: Formula
            abstract propertyChainAxiom: Formula
            abstract propertyDisjointWith: Formula

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

    let minQualifiedCardinality = _namespace.prefixedName "minQualifiedCardinality"
    let bottomDataProperty = _namespace.prefixedName "bottomDataProperty"
    let oneOf = _namespace.prefixedName "oneOf"

    module NegativePropertyAssertion =
        let Class = _namespace.prefixedName "NegativePropertyAssertion"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract annotatedProperty: Formula
            abstract annotatedSource: Formula
            abstract annotatedTarget: Formula
            abstract assertionProperty: Formula
            abstract deprecated: Formula
            abstract members: Formula
            abstract sourceIndividual: Formula
            abstract targetIndividual: Formula
            abstract targetValue: Formula
            abstract versionInfo: Formula

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.assertionProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "assertionProperty").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.sourceIndividual =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sourceIndividual").asPredicate)

            member this.targetIndividual =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "targetIndividual").asPredicate)

            member this.targetValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "targetValue").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.assertionProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "assertionProperty").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.sourceIndividual =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sourceIndividual").asPredicate)

                member this.targetIndividual =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "targetIndividual").asPredicate)

                member this.targetValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "targetValue").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.assertionProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "assertionProperty").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.sourceIndividual =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sourceIndividual").asPredicate)

            member this.targetIndividual =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "targetIndividual").asPredicate)

            member this.targetValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "targetValue").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.assertionProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "assertionProperty").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.sourceIndividual =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sourceIndividual").asPredicate)

                member this.targetIndividual =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "targetIndividual").asPredicate)

                member this.targetValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "targetValue").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

    module AllDifferent =
        let Class = _namespace.prefixedName "AllDifferent"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract annotatedProperty: Formula
            abstract annotatedSource: Formula
            abstract annotatedTarget: Formula
            abstract deprecated: Formula
            abstract distinctMembers: Formula
            abstract members: Formula
            abstract versionInfo: Formula

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.distinctMembers =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "distinctMembers").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.distinctMembers =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "distinctMembers").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.distinctMembers =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "distinctMembers").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.distinctMembers =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "distinctMembers").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

    module IrreflexiveProperty =
        let Class = _namespace.prefixedName "IrreflexiveProperty"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract equivalentProperty: Formula
            abstract inverseOf: Formula
            abstract propertyChainAxiom: Formula
            abstract propertyDisjointWith: Formula

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

    let targetValue = _namespace.prefixedName "targetValue"
    let qualifiedCardinality = _namespace.prefixedName "qualifiedCardinality"
    let datatypeComplementOf = _namespace.prefixedName "datatypeComplementOf"
    let hasKey = _namespace.prefixedName "hasKey"

    module AsymmetricProperty =
        let Class = _namespace.prefixedName "AsymmetricProperty"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract equivalentProperty: Formula
            abstract inverseOf: Formula
            abstract propertyChainAxiom: Formula
            abstract propertyDisjointWith: Formula

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

    module Annotation =
        let Class = _namespace.prefixedName "Annotation"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract annotatedProperty: Formula
            abstract annotatedSource: Formula
            abstract annotatedTarget: Formula
            abstract deprecated: Formula
            abstract members: Formula
            abstract versionInfo: Formula

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

    module Axiom =
        let Class = _namespace.prefixedName "Axiom"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract annotatedProperty: Formula
            abstract annotatedSource: Formula
            abstract annotatedTarget: Formula
            abstract deprecated: Formula
            abstract members: Formula
            abstract versionInfo: Formula

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

    let disjointUnionOf = _namespace.prefixedName "disjointUnionOf"
    let incompatibleWith = _namespace.prefixedName "incompatibleWith"
    let someValuesFrom = _namespace.prefixedName "someValuesFrom"

    module ReflexiveProperty =
        let Class = _namespace.prefixedName "ReflexiveProperty"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract equivalentProperty: Formula
            abstract inverseOf: Formula
            abstract propertyChainAxiom: Formula
            abstract propertyDisjointWith: Formula

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

    module AllDisjointClasses =
        let Class = _namespace.prefixedName "AllDisjointClasses"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract annotatedProperty: Formula
            abstract annotatedSource: Formula
            abstract annotatedTarget: Formula
            abstract deprecated: Formula
            abstract members: Formula
            abstract versionInfo: Formula

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

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

            member this.annotatedProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

            member this.annotatedSource =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

            member this.annotatedTarget =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

            member this.deprecated =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

            member this.members =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

            member this.versionInfo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.annotatedProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedProperty").asPredicate)

                member this.annotatedSource =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedSource").asPredicate)

                member this.annotatedTarget =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "annotatedTarget").asPredicate)

                member this.deprecated =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "deprecated").asPredicate)

                member this.members =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "members").asPredicate)

                member this.versionInfo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "versionInfo").asPredicate)

    let cardinality = _namespace.prefixedName "cardinality"
    let minCardinality = _namespace.prefixedName "minCardinality"
    let priorVersion = _namespace.prefixedName "priorVersion"
    let members = _namespace.prefixedName "members"
    let hasValue = _namespace.prefixedName "hasValue"
    let versionInfo = _namespace.prefixedName "versionInfo"
    let versionIRI = _namespace.prefixedName "versionIRI"

    module TransitiveProperty =
        let Class = _namespace.prefixedName "TransitiveProperty"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract equivalentProperty: Formula
            abstract inverseOf: Formula
            abstract propertyChainAxiom: Formula
            abstract propertyDisjointWith: Formula

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

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

            member this.equivalentProperty =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

            member this.inverseOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

            member this.propertyChainAxiom =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

            member this.propertyDisjointWith =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.equivalentProperty =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "equivalentProperty").asPredicate)

                member this.inverseOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "inverseOf").asPredicate)

                member this.propertyChainAxiom =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyChainAxiom").asPredicate)

                member this.propertyDisjointWith =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "propertyDisjointWith").asPredicate)

    let onClass = _namespace.prefixedName "onClass"
    let onDataRange = _namespace.prefixedName "onDataRange"
    let equivalentClass = _namespace.prefixedName "equivalentClass"
    let topObjectProperty = _namespace.prefixedName "topObjectProperty"
    let topDataProperty = _namespace.prefixedName "topDataProperty"
    let withRestrictions = _namespace.prefixedName "withRestrictions"
    let annotatedProperty = _namespace.prefixedName "annotatedProperty"
    let sourceIndividual = _namespace.prefixedName "sourceIndividual"
    let equivalentProperty = _namespace.prefixedName "equivalentProperty"
    let bottomObjectProperty = _namespace.prefixedName "bottomObjectProperty"
    let unionOf = _namespace.prefixedName "unionOf"
    let deprecated = _namespace.prefixedName "deprecated"
    let maxQualifiedCardinality = _namespace.prefixedName "maxQualifiedCardinality"
    let distinctMembers = _namespace.prefixedName "distinctMembers"
    let onDatatype = _namespace.prefixedName "onDatatype"
    let assertionProperty = _namespace.prefixedName "assertionProperty"
    let targetIndividual = _namespace.prefixedName "targetIndividual"
    let hasSelf = _namespace.prefixedName "hasSelf"
