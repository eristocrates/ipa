#I @"D:\https\com\github\eristocrates\ipa\dll\"
#r @"ResourceDescription.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx\"
open ResourceDescription
#load @".paket/load/main.group.fsx"
open System

module dcterms =
    let _namespace = NamedReference "http://purl.org/dc/terms/" |> NamespaceName
    let _rdfType = NamedReference "http://www.w3.org/1999/02/22-rdf-syntax-ns#type"

    let _owlNamedIndividual =
        NamedReference "http://www.w3.org/2002/07/owl#NamedIndividual"

    let medium = _namespace.prefixedName "medium"

    module PhysicalMedium =
        let Class = _namespace.prefixedName "PhysicalMedium"

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

    module PhysicalResource =
        let Class = _namespace.prefixedName "PhysicalResource"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract medium: Formula

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

            member this.medium =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "medium").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.medium =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "medium").asPredicate)

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

            member this.medium =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "medium").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.medium =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "medium").asPredicate)

    let issued = _namespace.prefixedName "issued"
    let hasVersion = _namespace.prefixedName "hasVersion"
    let format = _namespace.prefixedName "format"
    let modified = _namespace.prefixedName "modified"
    let description = _namespace.prefixedName "description"

    module MediaTypeOrExtent =
        let Class = _namespace.prefixedName "MediaTypeOrExtent"

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

    module RightsStatement =
        let Class = _namespace.prefixedName "RightsStatement"

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

    module Jurisdiction =
        let Class = _namespace.prefixedName "Jurisdiction"

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

    module LocationPeriodOrJurisdiction =
        let Class = _namespace.prefixedName "LocationPeriodOrJurisdiction"

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

    let subject = _namespace.prefixedName "subject"
    let alternative = _namespace.prefixedName "alternative"
    let title = _namespace.prefixedName "title"
    let tableOfContents = _namespace.prefixedName "tableOfContents"
    let date = _namespace.prefixedName "date"
    let UDC = _namespace.prefixedName "UDC"

    module BibliographicResource =
        let Class = _namespace.prefixedName "BibliographicResource"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract bibliographicCitation: Formula

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

            member this.bibliographicCitation =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bibliographicCitation").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.bibliographicCitation =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft ->
                        draft.addRdfPredicate (_namespace.prefixedName "bibliographicCitation").asPredicate)

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

            member this.bibliographicCitation =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bibliographicCitation").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.bibliographicCitation =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft ->
                        draft.addRdfPredicate (_namespace.prefixedName "bibliographicCitation").asPredicate)

    let license = _namespace.prefixedName "license"

    module LicenseDocument =
        let Class = _namespace.prefixedName "LicenseDocument"

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

    let rights = _namespace.prefixedName "rights"
    let source = _namespace.prefixedName "source"
    let relation = _namespace.prefixedName "relation"
    let isReferencedBy = _namespace.prefixedName "isReferencedBy"
    let hasFormat = _namespace.prefixedName "hasFormat"
    let MESH = _namespace.prefixedName "MESH"
    let replaces = _namespace.prefixedName "replaces"
    let mediator = _namespace.prefixedName "mediator"

    module AgentClass =
        let Class = _namespace.prefixedName "AgentClass"

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

    let audience = _namespace.prefixedName "audience"
    let extent = _namespace.prefixedName "extent"

    module SizeOrDuration =
        let Class = _namespace.prefixedName "SizeOrDuration"

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

    let rightsHolder = _namespace.prefixedName "rightsHolder"

    module Agent =
        let Class = _namespace.prefixedName "Agent"

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

    let accrualPolicy = _namespace.prefixedName "accrualPolicy"

    module Policy =
        let Class = _namespace.prefixedName "Policy"

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

    let created = _namespace.prefixedName "created"
    let references = _namespace.prefixedName "references"
    let creator = _namespace.prefixedName "creator"
    let contributor = _namespace.prefixedName "contributor"
    let accessRights = _namespace.prefixedName "accessRights"
    let RFC5646 = _namespace.prefixedName "RFC5646"

    module Frequency =
        let Class = _namespace.prefixedName "Frequency"

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

    let dateCopyrighted = _namespace.prefixedName "dateCopyrighted"
    let LCSH = _namespace.prefixedName "LCSH"
    let abstract_ = _namespace.prefixedName "abstract"
    let Point = _namespace.prefixedName "Point"
    let publisher = _namespace.prefixedName "publisher"
    let RFC4646 = _namespace.prefixedName "RFC4646"
    let ISO639_3 = _namespace.prefixedName "ISO639-3"
    let conformsTo = _namespace.prefixedName "conformsTo"

    module Standard =
        let Class = _namespace.prefixedName "Standard"

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

    let accrualPeriodicity = _namespace.prefixedName "accrualPeriodicity"
    let isReplacedBy = _namespace.prefixedName "isReplacedBy"
    let IMT = _namespace.prefixedName "IMT"
    let identifier = _namespace.prefixedName "identifier"
    let hasPart = _namespace.prefixedName "hasPart"
    let accrualMethod = _namespace.prefixedName "accrualMethod"

    module MethodOfAccrual =
        let Class = _namespace.prefixedName "MethodOfAccrual"

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

    let type_ = _namespace.prefixedName "type"
    let ISO3166 = _namespace.prefixedName "ISO3166"
    let dateAccepted = _namespace.prefixedName "dateAccepted"
    let coverage = _namespace.prefixedName "coverage"

    module MediaType =
        let Class = _namespace.prefixedName "MediaType"

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

    let W3CDTF = _namespace.prefixedName "W3CDTF"
    let ISO639_2 = _namespace.prefixedName "ISO639-2"
    let educationLevel = _namespace.prefixedName "educationLevel"
    let isRequiredBy = _namespace.prefixedName "isRequiredBy"
    let available = _namespace.prefixedName "available"
    let isPartOf = _namespace.prefixedName "isPartOf"
    let isVersionOf = _namespace.prefixedName "isVersionOf"
    let URI = _namespace.prefixedName "URI"
    let DDC = _namespace.prefixedName "DDC"

    module MethodOfInstruction =
        let Class = _namespace.prefixedName "MethodOfInstruction"

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

    let instructionalMethod = _namespace.prefixedName "instructionalMethod"

    module ProvenanceStatement =
        let Class = _namespace.prefixedName "ProvenanceStatement"

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

    let isFormatOf = _namespace.prefixedName "isFormatOf"
    let spatial = _namespace.prefixedName "spatial"

    module Location =
        let Class = _namespace.prefixedName "Location"

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

    let RFC1766 = _namespace.prefixedName "RFC1766"
    let temporal = _namespace.prefixedName "temporal"

    module PeriodOfTime =
        let Class = _namespace.prefixedName "PeriodOfTime"

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

    let DCMIType = _namespace.prefixedName "DCMIType"
    let RFC3066 = _namespace.prefixedName "RFC3066"
    let TGN = _namespace.prefixedName "TGN"
    let bibliographicCitation = _namespace.prefixedName "bibliographicCitation"
    let Period = _namespace.prefixedName "Period"
    let provenance = _namespace.prefixedName "provenance"
    let LCC = _namespace.prefixedName "LCC"
    let language = _namespace.prefixedName "language"

    module LinguisticSystem =
        let Class = _namespace.prefixedName "LinguisticSystem"

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

    let dateSubmitted = _namespace.prefixedName "dateSubmitted"
    let valid = _namespace.prefixedName "valid"
    let requires = _namespace.prefixedName "requires"
    let NLM = _namespace.prefixedName "NLM"
    let Box = _namespace.prefixedName "Box"

    module FileFormat =
        let Class = _namespace.prefixedName "FileFormat"

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
