#I @"D:\https\com\github\eristocrates\ipa\dll\"
#r @"ResourceDescription.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx\"
open ResourceDescription
#load @".paket/load/main.group.fsx"
open System

module cnt =
    let _namespace = NamedReference "http://www.w3.org/2011/content#" |> NamespaceName
    let _rdfType = NamedReference "http://www.w3.org/1999/02/22-rdf-syntax-ns#type"

    let _owlNamedIndividual =
        NamedReference "http://www.w3.org/2002/07/owl#NamedIndividual"

    let internalSubset = _namespace.prefixedName "internalSubset"

    module DoctypeDecl =
        let Class = _namespace.prefixedName "DoctypeDecl"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract doctypeName: Formula
            abstract internalSubset: Formula
            abstract publicId: Formula
            abstract systemId: Formula

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

            member this.doctypeName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "doctypeName").asPredicate)

            member this.internalSubset =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "internalSubset").asPredicate)

            member this.publicId =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "publicId").asPredicate)

            member this.systemId =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "systemId").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.doctypeName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "doctypeName").asPredicate)

                member this.internalSubset =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "internalSubset").asPredicate)

                member this.publicId =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "publicId").asPredicate)

                member this.systemId =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "systemId").asPredicate)

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

            member this.doctypeName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "doctypeName").asPredicate)

            member this.internalSubset =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "internalSubset").asPredicate)

            member this.publicId =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "publicId").asPredicate)

            member this.systemId =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "systemId").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.doctypeName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "doctypeName").asPredicate)

                member this.internalSubset =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "internalSubset").asPredicate)

                member this.publicId =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "publicId").asPredicate)

                member this.systemId =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "systemId").asPredicate)

    let bytes = _namespace.prefixedName "bytes"

    module ContentAsBase64 =
        let Class = _namespace.prefixedName "ContentAsBase64"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract bytes: Formula
            abstract characterEncoding: Formula

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

            member this.bytes =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bytes").asPredicate)

            member this.characterEncoding =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.bytes =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bytes").asPredicate)

                member this.characterEncoding =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

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

            member this.bytes =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bytes").asPredicate)

            member this.characterEncoding =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.bytes =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "bytes").asPredicate)

                member this.characterEncoding =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

    module Content =
        let Class = _namespace.prefixedName "Content"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract characterEncoding: Formula

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

            member this.characterEncoding =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.characterEncoding =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

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

            member this.characterEncoding =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.characterEncoding =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

    let dtDecl = _namespace.prefixedName "dtDecl"

    module ContentAsXML =
        let Class = _namespace.prefixedName "ContentAsXML"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract characterEncoding: Formula
            abstract declaredEncoding: Formula
            abstract dtDecl: Formula
            abstract leadingMisc: Formula
            abstract rest: Formula
            abstract standalone: Formula
            abstract version: Formula

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

            member this.characterEncoding =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

            member this.declaredEncoding =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "declaredEncoding").asPredicate)

            member this.dtDecl =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "dtDecl").asPredicate)

            member this.leadingMisc =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "leadingMisc").asPredicate)

            member this.rest =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "rest").asPredicate)

            member this.standalone =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "standalone").asPredicate)

            member this.version =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "version").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.characterEncoding =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

                member this.declaredEncoding =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "declaredEncoding").asPredicate)

                member this.dtDecl =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "dtDecl").asPredicate)

                member this.leadingMisc =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "leadingMisc").asPredicate)

                member this.rest =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "rest").asPredicate)

                member this.standalone =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "standalone").asPredicate)

                member this.version =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "version").asPredicate)

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

            member this.characterEncoding =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

            member this.declaredEncoding =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "declaredEncoding").asPredicate)

            member this.dtDecl =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "dtDecl").asPredicate)

            member this.leadingMisc =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "leadingMisc").asPredicate)

            member this.rest =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "rest").asPredicate)

            member this.standalone =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "standalone").asPredicate)

            member this.version =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "version").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.characterEncoding =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

                member this.declaredEncoding =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "declaredEncoding").asPredicate)

                member this.dtDecl =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "dtDecl").asPredicate)

                member this.leadingMisc =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "leadingMisc").asPredicate)

                member this.rest =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "rest").asPredicate)

                member this.standalone =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "standalone").asPredicate)

                member this.version =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "version").asPredicate)

    let leadingMisc = _namespace.prefixedName "leadingMisc"
    let version = _namespace.prefixedName "version"
    let systemId = _namespace.prefixedName "systemId"

    module ContentAsText =
        let Class = _namespace.prefixedName "ContentAsText"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract characterEncoding: Formula
            abstract chars: Formula

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

            member this.characterEncoding =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

            member this.chars =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "chars").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.characterEncoding =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

                member this.chars =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "chars").asPredicate)

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

            member this.characterEncoding =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

            member this.chars =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "chars").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.characterEncoding =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "characterEncoding").asPredicate)

                member this.chars =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "chars").asPredicate)

    let chars = _namespace.prefixedName "chars"
    let doctypeName = _namespace.prefixedName "doctypeName"
    let rest = _namespace.prefixedName "rest"
    let standalone = _namespace.prefixedName "standalone"
    let declaredEncoding = _namespace.prefixedName "declaredEncoding"
    let characterEncoding = _namespace.prefixedName "characterEncoding"
    let publicId = _namespace.prefixedName "publicId"
