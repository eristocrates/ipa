#I @"D:\https\com\github\eristocrates\ipa\dll\"
#r @"ResourceDescription.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx\"
open ResourceDescription
#load @".paket/load/main.group.fsx"
open System

module http =
    let _namespace = NamedReference "http://www.w3.org/2011/http#" |> NamespaceName
    let _rdfType = NamedReference "http://www.w3.org/1999/02/22-rdf-syntax-ns#type"

    let _owlNamedIndividual =
        NamedReference "http://www.w3.org/2002/07/owl#NamedIndividual"

    let mthd = _namespace.prefixedName "mthd"

    module Method =
        let Class = _namespace.prefixedName "Method"

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

    module Request =
        let Class = _namespace.prefixedName "Request"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract body: Formula
            abstract headers: Formula
            abstract httpVersion: Formula
            abstract methodName: Formula
            abstract mthd: Formula
            abstract requestURI: Formula
            abstract resp: Formula

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

            member this.body =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "body").asPredicate)

            member this.headers =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headers").asPredicate)

            member this.httpVersion =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "httpVersion").asPredicate)

            member this.methodName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "methodName").asPredicate)

            member this.mthd =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mthd").asPredicate)

            member this.requestURI =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "requestURI").asPredicate)

            member this.resp =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "resp").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.body =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "body").asPredicate)

                member this.headers =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headers").asPredicate)

                member this.httpVersion =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "httpVersion").asPredicate)

                member this.methodName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "methodName").asPredicate)

                member this.mthd =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mthd").asPredicate)

                member this.requestURI =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "requestURI").asPredicate)

                member this.resp =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "resp").asPredicate)

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

            member this.body =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "body").asPredicate)

            member this.headers =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headers").asPredicate)

            member this.httpVersion =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "httpVersion").asPredicate)

            member this.methodName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "methodName").asPredicate)

            member this.mthd =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mthd").asPredicate)

            member this.requestURI =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "requestURI").asPredicate)

            member this.resp =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "resp").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.body =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "body").asPredicate)

                member this.headers =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headers").asPredicate)

                member this.httpVersion =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "httpVersion").asPredicate)

                member this.methodName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "methodName").asPredicate)

                member this.mthd =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mthd").asPredicate)

                member this.requestURI =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "requestURI").asPredicate)

                member this.resp =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "resp").asPredicate)

    module RequestHeader =
        let Class = _namespace.prefixedName "RequestHeader"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract fieldName: Formula
            abstract fieldValue: Formula
            abstract hdrName: Formula
            abstract headerElements: Formula

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

            member this.fieldName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

            member this.fieldValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

            member this.hdrName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

            member this.headerElements =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.fieldName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

                member this.fieldValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

                member this.hdrName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

                member this.headerElements =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

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

            member this.fieldName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

            member this.fieldValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

            member this.hdrName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

            member this.headerElements =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.fieldName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

                member this.fieldValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

                member this.hdrName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

                member this.headerElements =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

    module MessageHeader =
        let Class = _namespace.prefixedName "MessageHeader"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract fieldName: Formula
            abstract fieldValue: Formula
            abstract hdrName: Formula
            abstract headerElements: Formula

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

            member this.fieldName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

            member this.fieldValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

            member this.hdrName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

            member this.headerElements =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.fieldName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

                member this.fieldValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

                member this.hdrName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

                member this.headerElements =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

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

            member this.fieldName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

            member this.fieldValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

            member this.hdrName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

            member this.headerElements =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.fieldName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

                member this.fieldValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

                member this.hdrName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

                member this.headerElements =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

    let sc = _namespace.prefixedName "sc"

    module StatusCode =
        let Class = _namespace.prefixedName "StatusCode"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract statusCodeNumber: Formula

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

            member this.statusCodeNumber =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "statusCodeNumber").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.statusCodeNumber =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "statusCodeNumber").asPredicate)

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

            member this.statusCodeNumber =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "statusCodeNumber").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.statusCodeNumber =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "statusCodeNumber").asPredicate)

    module Response =
        let Class = _namespace.prefixedName "Response"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract body: Formula
            abstract headers: Formula
            abstract httpVersion: Formula
            abstract reasonPhrase: Formula
            abstract sc: Formula
            abstract statusCodeValue: Formula

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

            member this.body =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "body").asPredicate)

            member this.headers =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headers").asPredicate)

            member this.httpVersion =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "httpVersion").asPredicate)

            member this.reasonPhrase =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "reasonPhrase").asPredicate)

            member this.sc =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sc").asPredicate)

            member this.statusCodeValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "statusCodeValue").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.body =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "body").asPredicate)

                member this.headers =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headers").asPredicate)

                member this.httpVersion =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "httpVersion").asPredicate)

                member this.reasonPhrase =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "reasonPhrase").asPredicate)

                member this.sc =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sc").asPredicate)

                member this.statusCodeValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "statusCodeValue").asPredicate)

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

            member this.body =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "body").asPredicate)

            member this.headers =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headers").asPredicate)

            member this.httpVersion =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "httpVersion").asPredicate)

            member this.reasonPhrase =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "reasonPhrase").asPredicate)

            member this.sc =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sc").asPredicate)

            member this.statusCodeValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "statusCodeValue").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.body =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "body").asPredicate)

                member this.headers =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headers").asPredicate)

                member this.httpVersion =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "httpVersion").asPredicate)

                member this.reasonPhrase =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "reasonPhrase").asPredicate)

                member this.sc =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sc").asPredicate)

                member this.statusCodeValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "statusCodeValue").asPredicate)

    let reasonPhrase = _namespace.prefixedName "reasonPhrase"

    module HeaderElement =
        let Class = _namespace.prefixedName "HeaderElement"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract elementName: Formula
            abstract elementValue: Formula
            abstract params_: Formula

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

            member this.elementName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "elementName").asPredicate)

            member this.elementValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "elementValue").asPredicate)

            member this.params_ =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "params").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.elementName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "elementName").asPredicate)

                member this.elementValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "elementValue").asPredicate)

                member this.params_ =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "params").asPredicate)

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

            member this.elementName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "elementName").asPredicate)

            member this.elementValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "elementValue").asPredicate)

            member this.params_ =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "params").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.elementName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "elementName").asPredicate)

                member this.elementValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "elementValue").asPredicate)

                member this.params_ =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "params").asPredicate)

    let resp = _namespace.prefixedName "resp"
    let authority = _namespace.prefixedName "authority"
    let requestURI = _namespace.prefixedName "requestURI"
    let elementName = _namespace.prefixedName "elementName"

    module EntityHeader =
        let Class = _namespace.prefixedName "EntityHeader"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract fieldName: Formula
            abstract fieldValue: Formula
            abstract hdrName: Formula
            abstract headerElements: Formula

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

            member this.fieldName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

            member this.fieldValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

            member this.hdrName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

            member this.headerElements =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.fieldName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

                member this.fieldValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

                member this.hdrName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

                member this.headerElements =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

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

            member this.fieldName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

            member this.fieldValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

            member this.hdrName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

            member this.headerElements =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.fieldName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

                member this.fieldValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

                member this.hdrName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

                member this.headerElements =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

    let elementValue = _namespace.prefixedName "elementValue"

    module Connection =
        let Class = _namespace.prefixedName "Connection"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract connectionAuthority: Formula
            abstract requests: Formula

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

            member this.connectionAuthority =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "connectionAuthority").asPredicate)

            member this.requests =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "requests").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.connectionAuthority =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "connectionAuthority").asPredicate)

                member this.requests =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "requests").asPredicate)

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

            member this.connectionAuthority =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "connectionAuthority").asPredicate)

            member this.requests =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "requests").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.connectionAuthority =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "connectionAuthority").asPredicate)

                member this.requests =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "requests").asPredicate)

    module Message =
        let Class = _namespace.prefixedName "Message"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract body: Formula
            abstract headers: Formula
            abstract httpVersion: Formula

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

            member this.body =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "body").asPredicate)

            member this.headers =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headers").asPredicate)

            member this.httpVersion =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "httpVersion").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.body =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "body").asPredicate)

                member this.headers =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headers").asPredicate)

                member this.httpVersion =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "httpVersion").asPredicate)

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

            member this.body =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "body").asPredicate)

            member this.headers =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headers").asPredicate)

            member this.httpVersion =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "httpVersion").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.body =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "body").asPredicate)

                member this.headers =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headers").asPredicate)

                member this.httpVersion =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "httpVersion").asPredicate)

    let headerElements = _namespace.prefixedName "headerElements"
    let params_ = _namespace.prefixedName "params"
    let paramValue = _namespace.prefixedName "paramValue"

    module Parameter =
        let Class = _namespace.prefixedName "Parameter"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract paramName: Formula
            abstract paramValue: Formula

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

            member this.paramName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "paramName").asPredicate)

            member this.paramValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "paramValue").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.paramName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "paramName").asPredicate)

                member this.paramValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "paramValue").asPredicate)

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

            member this.paramName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "paramName").asPredicate)

            member this.paramValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "paramValue").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.paramName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "paramName").asPredicate)

                member this.paramValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "paramValue").asPredicate)

    let requests = _namespace.prefixedName "requests"
    let body = _namespace.prefixedName "body"
    let fieldValue = _namespace.prefixedName "fieldValue"
    let httpVersion = _namespace.prefixedName "httpVersion"
    let absolutePath = _namespace.prefixedName "absolutePath"
    let hdrName = _namespace.prefixedName "hdrName"

    module HeaderName =
        let Class = _namespace.prefixedName "HeaderName"

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

    let fieldName = _namespace.prefixedName "fieldName"
    let absoluteURI = _namespace.prefixedName "absoluteURI"

    module ResponseHeader =
        let Class = _namespace.prefixedName "ResponseHeader"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract fieldName: Formula
            abstract fieldValue: Formula
            abstract hdrName: Formula
            abstract headerElements: Formula

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

            member this.fieldName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

            member this.fieldValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

            member this.hdrName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

            member this.headerElements =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.fieldName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

                member this.fieldValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

                member this.hdrName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

                member this.headerElements =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

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

            member this.fieldName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

            member this.fieldValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

            member this.hdrName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

            member this.headerElements =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.fieldName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

                member this.fieldValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

                member this.hdrName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

                member this.headerElements =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

    let methodName = _namespace.prefixedName "methodName"
    let headers = _namespace.prefixedName "headers"
    let statusCodeValue = _namespace.prefixedName "statusCodeValue"
    let paramName = _namespace.prefixedName "paramName"

    module GeneralHeader =
        let Class = _namespace.prefixedName "GeneralHeader"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract asSubject: RdfSubject
            abstract asPredicate: RdfPredicate
            abstract asObject: RdfObject
            abstract fieldName: Formula
            abstract fieldValue: Formula
            abstract hdrName: Formula
            abstract headerElements: Formula

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

            member this.fieldName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

            member this.fieldValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

            member this.hdrName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

            member this.headerElements =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.fieldName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

                member this.fieldValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

                member this.hdrName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

                member this.headerElements =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

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

            member this.fieldName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

            member this.fieldValue =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

            member this.hdrName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

            member this.headerElements =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula
                member this.asSubject = iri.asSubject
                member this.asPredicate = iri.asPredicate
                member this.asObject = iri.asObject

                member this.fieldName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldName").asPredicate)

                member this.fieldValue =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fieldValue").asPredicate)

                member this.hdrName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "hdrName").asPredicate)

                member this.headerElements =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "headerElements").asPredicate)

    let statusCodeNumber = _namespace.prefixedName "statusCodeNumber"
    let connectionAuthority = _namespace.prefixedName "connectionAuthority"
