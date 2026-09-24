#I @"D:\https\com\github\eristocrates\ipa\dll\"
#r @"ResourceDescription.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx\"
open ResourceDescription
#load @".paket/load/main.group.fsx"
open System

module foaf =
    let _namespace = NamedReference "http://xmlns.com/foaf/0.1/" |> NamespaceName
    let _rdfType = NamedReference "http://www.w3.org/1999/02/22-rdf-syntax-ns#type"

    let _owlNamedIndividual =
        NamedReference "http://www.w3.org/2002/07/owl#NamedIndividual"

    module Agent =
        let Class = _namespace.prefixedName "Agent"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract account: Formula
            abstract age: Formula
            abstract aimChatID: Formula
            abstract birthday: Formula
            abstract gender: Formula
            abstract holdsAccount: Formula
            abstract icqChatID: Formula
            abstract interest: Formula
            abstract jabberID: Formula
            abstract made: Formula
            abstract mbox: Formula
            abstract mbox_sha1sum: Formula
            abstract msnChatID: Formula
            abstract openid: Formula
            abstract skypeID: Formula
            abstract status: Formula
            abstract tipjar: Formula
            abstract topic_interest: Formula
            abstract weblog: Formula
            abstract yahooChatID: Formula

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula

            member this.account =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "account").asPredicate)

            member this.age =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "age").asPredicate)

            member this.aimChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "aimChatID").asPredicate)

            member this.birthday =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "birthday").asPredicate)

            member this.gender =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "gender").asPredicate)

            member this.holdsAccount =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "holdsAccount").asPredicate)

            member this.icqChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "icqChatID").asPredicate)

            member this.interest =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "interest").asPredicate)

            member this.jabberID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "jabberID").asPredicate)

            member this.made =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "made").asPredicate)

            member this.mbox =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox").asPredicate)

            member this.mbox_sha1sum =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox_sha1sum").asPredicate)

            member this.msnChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "msnChatID").asPredicate)

            member this.openid =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "openid").asPredicate)

            member this.skypeID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "skypeID").asPredicate)

            member this.status =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "status").asPredicate)

            member this.tipjar =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "tipjar").asPredicate)

            member this.topic_interest =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic_interest").asPredicate)

            member this.weblog =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "weblog").asPredicate)

            member this.yahooChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "yahooChatID").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula

                member this.account =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "account").asPredicate)

                member this.age =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "age").asPredicate)

                member this.aimChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "aimChatID").asPredicate)

                member this.birthday =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "birthday").asPredicate)

                member this.gender =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "gender").asPredicate)

                member this.holdsAccount =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "holdsAccount").asPredicate)

                member this.icqChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "icqChatID").asPredicate)

                member this.interest =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "interest").asPredicate)

                member this.jabberID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "jabberID").asPredicate)

                member this.made =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "made").asPredicate)

                member this.mbox =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox").asPredicate)

                member this.mbox_sha1sum =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox_sha1sum").asPredicate)

                member this.msnChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "msnChatID").asPredicate)

                member this.openid =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "openid").asPredicate)

                member this.skypeID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "skypeID").asPredicate)

                member this.status =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "status").asPredicate)

                member this.tipjar =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "tipjar").asPredicate)

                member this.topic_interest =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic_interest").asPredicate)

                member this.weblog =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "weblog").asPredicate)

                member this.yahooChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "yahooChatID").asPredicate)

    module Document =
        let Class = _namespace.prefixedName "Document"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract primaryTopic: Formula
            abstract sha1: Formula
            abstract topic: Formula

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula

            member this.primaryTopic =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "primaryTopic").asPredicate)

            member this.sha1 =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sha1").asPredicate)

            member this.topic =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula

                member this.primaryTopic =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "primaryTopic").asPredicate)

                member this.sha1 =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sha1").asPredicate)

                member this.topic =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic").asPredicate)

    module Organization =
        let Class = _namespace.prefixedName "Organization"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract account: Formula
            abstract age: Formula
            abstract aimChatID: Formula
            abstract birthday: Formula
            abstract gender: Formula
            abstract holdsAccount: Formula
            abstract icqChatID: Formula
            abstract interest: Formula
            abstract jabberID: Formula
            abstract made: Formula
            abstract mbox: Formula
            abstract mbox_sha1sum: Formula
            abstract msnChatID: Formula
            abstract openid: Formula
            abstract skypeID: Formula
            abstract status: Formula
            abstract tipjar: Formula
            abstract topic_interest: Formula
            abstract weblog: Formula
            abstract yahooChatID: Formula

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula

            member this.account =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "account").asPredicate)

            member this.age =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "age").asPredicate)

            member this.aimChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "aimChatID").asPredicate)

            member this.birthday =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "birthday").asPredicate)

            member this.gender =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "gender").asPredicate)

            member this.holdsAccount =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "holdsAccount").asPredicate)

            member this.icqChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "icqChatID").asPredicate)

            member this.interest =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "interest").asPredicate)

            member this.jabberID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "jabberID").asPredicate)

            member this.made =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "made").asPredicate)

            member this.mbox =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox").asPredicate)

            member this.mbox_sha1sum =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox_sha1sum").asPredicate)

            member this.msnChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "msnChatID").asPredicate)

            member this.openid =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "openid").asPredicate)

            member this.skypeID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "skypeID").asPredicate)

            member this.status =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "status").asPredicate)

            member this.tipjar =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "tipjar").asPredicate)

            member this.topic_interest =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic_interest").asPredicate)

            member this.weblog =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "weblog").asPredicate)

            member this.yahooChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "yahooChatID").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula

                member this.account =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "account").asPredicate)

                member this.age =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "age").asPredicate)

                member this.aimChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "aimChatID").asPredicate)

                member this.birthday =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "birthday").asPredicate)

                member this.gender =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "gender").asPredicate)

                member this.holdsAccount =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "holdsAccount").asPredicate)

                member this.icqChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "icqChatID").asPredicate)

                member this.interest =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "interest").asPredicate)

                member this.jabberID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "jabberID").asPredicate)

                member this.made =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "made").asPredicate)

                member this.mbox =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox").asPredicate)

                member this.mbox_sha1sum =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox_sha1sum").asPredicate)

                member this.msnChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "msnChatID").asPredicate)

                member this.openid =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "openid").asPredicate)

                member this.skypeID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "skypeID").asPredicate)

                member this.status =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "status").asPredicate)

                member this.tipjar =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "tipjar").asPredicate)

                member this.topic_interest =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic_interest").asPredicate)

                member this.weblog =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "weblog").asPredicate)

                member this.yahooChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "yahooChatID").asPredicate)

    module Project =
        let Class = _namespace.prefixedName "Project"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula

            interface Interface with
                member this.iri = iri
                member this.formula = _formula

    module Person =
        let Class = _namespace.prefixedName "Person"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract account: Formula
            abstract age: Formula
            abstract aimChatID: Formula
            abstract based_near: Formula
            abstract birthday: Formula
            abstract currentProject: Formula
            abstract familyName: Formula
            abstract family_name: Formula
            abstract firstName: Formula
            abstract geekcode: Formula
            abstract gender: Formula
            abstract holdsAccount: Formula
            abstract icqChatID: Formula
            abstract img: Formula
            abstract interest: Formula
            abstract jabberID: Formula
            abstract knows: Formula
            abstract lastName: Formula
            abstract made: Formula
            abstract mbox: Formula
            abstract mbox_sha1sum: Formula
            abstract msnChatID: Formula
            abstract myersBriggs: Formula
            abstract openid: Formula
            abstract pastProject: Formula
            abstract plan: Formula
            abstract publications: Formula
            abstract schoolHomepage: Formula
            abstract skypeID: Formula
            abstract status: Formula
            abstract surname: Formula
            abstract tipjar: Formula
            abstract topic_interest: Formula
            abstract weblog: Formula
            abstract workInfoHomepage: Formula
            abstract workplaceHomepage: Formula
            abstract yahooChatID: Formula

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula

            member this.account =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "account").asPredicate)

            member this.age =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "age").asPredicate)

            member this.aimChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "aimChatID").asPredicate)

            member this.based_near =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "based_near").asPredicate)

            member this.birthday =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "birthday").asPredicate)

            member this.currentProject =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "currentProject").asPredicate)

            member this.familyName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "familyName").asPredicate)

            member this.family_name =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "family_name").asPredicate)

            member this.firstName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "firstName").asPredicate)

            member this.geekcode =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "geekcode").asPredicate)

            member this.gender =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "gender").asPredicate)

            member this.holdsAccount =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "holdsAccount").asPredicate)

            member this.icqChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "icqChatID").asPredicate)

            member this.img =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "img").asPredicate)

            member this.interest =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "interest").asPredicate)

            member this.jabberID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "jabberID").asPredicate)

            member this.knows =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "knows").asPredicate)

            member this.lastName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "lastName").asPredicate)

            member this.made =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "made").asPredicate)

            member this.mbox =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox").asPredicate)

            member this.mbox_sha1sum =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox_sha1sum").asPredicate)

            member this.msnChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "msnChatID").asPredicate)

            member this.myersBriggs =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "myersBriggs").asPredicate)

            member this.openid =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "openid").asPredicate)

            member this.pastProject =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "pastProject").asPredicate)

            member this.plan =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "plan").asPredicate)

            member this.publications =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "publications").asPredicate)

            member this.schoolHomepage =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "schoolHomepage").asPredicate)

            member this.skypeID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "skypeID").asPredicate)

            member this.status =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "status").asPredicate)

            member this.surname =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "surname").asPredicate)

            member this.tipjar =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "tipjar").asPredicate)

            member this.topic_interest =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic_interest").asPredicate)

            member this.weblog =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "weblog").asPredicate)

            member this.workInfoHomepage =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "workInfoHomepage").asPredicate)

            member this.workplaceHomepage =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "workplaceHomepage").asPredicate)

            member this.yahooChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "yahooChatID").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula

                member this.account =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "account").asPredicate)

                member this.age =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "age").asPredicate)

                member this.aimChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "aimChatID").asPredicate)

                member this.based_near =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "based_near").asPredicate)

                member this.birthday =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "birthday").asPredicate)

                member this.currentProject =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "currentProject").asPredicate)

                member this.familyName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "familyName").asPredicate)

                member this.family_name =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "family_name").asPredicate)

                member this.firstName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "firstName").asPredicate)

                member this.geekcode =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "geekcode").asPredicate)

                member this.gender =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "gender").asPredicate)

                member this.holdsAccount =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "holdsAccount").asPredicate)

                member this.icqChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "icqChatID").asPredicate)

                member this.img =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "img").asPredicate)

                member this.interest =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "interest").asPredicate)

                member this.jabberID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "jabberID").asPredicate)

                member this.knows =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "knows").asPredicate)

                member this.lastName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "lastName").asPredicate)

                member this.made =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "made").asPredicate)

                member this.mbox =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox").asPredicate)

                member this.mbox_sha1sum =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox_sha1sum").asPredicate)

                member this.msnChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "msnChatID").asPredicate)

                member this.myersBriggs =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "myersBriggs").asPredicate)

                member this.openid =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "openid").asPredicate)

                member this.pastProject =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "pastProject").asPredicate)

                member this.plan =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "plan").asPredicate)

                member this.publications =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "publications").asPredicate)

                member this.schoolHomepage =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "schoolHomepage").asPredicate)

                member this.skypeID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "skypeID").asPredicate)

                member this.status =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "status").asPredicate)

                member this.surname =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "surname").asPredicate)

                member this.tipjar =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "tipjar").asPredicate)

                member this.topic_interest =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic_interest").asPredicate)

                member this.weblog =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "weblog").asPredicate)

                member this.workInfoHomepage =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "workInfoHomepage").asPredicate)

                member this.workplaceHomepage =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "workplaceHomepage").asPredicate)

                member this.yahooChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "yahooChatID").asPredicate)

    module Group =
        let Class = _namespace.prefixedName "Group"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract account: Formula
            abstract age: Formula
            abstract aimChatID: Formula
            abstract birthday: Formula
            abstract gender: Formula
            abstract holdsAccount: Formula
            abstract icqChatID: Formula
            abstract interest: Formula
            abstract jabberID: Formula
            abstract made: Formula
            abstract mbox: Formula
            abstract mbox_sha1sum: Formula
            abstract member_: Formula
            abstract msnChatID: Formula
            abstract openid: Formula
            abstract skypeID: Formula
            abstract status: Formula
            abstract tipjar: Formula
            abstract topic_interest: Formula
            abstract weblog: Formula
            abstract yahooChatID: Formula

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula

            member this.account =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "account").asPredicate)

            member this.age =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "age").asPredicate)

            member this.aimChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "aimChatID").asPredicate)

            member this.birthday =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "birthday").asPredicate)

            member this.gender =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "gender").asPredicate)

            member this.holdsAccount =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "holdsAccount").asPredicate)

            member this.icqChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "icqChatID").asPredicate)

            member this.interest =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "interest").asPredicate)

            member this.jabberID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "jabberID").asPredicate)

            member this.made =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "made").asPredicate)

            member this.mbox =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox").asPredicate)

            member this.mbox_sha1sum =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox_sha1sum").asPredicate)

            member this.member_ =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "member").asPredicate)

            member this.msnChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "msnChatID").asPredicate)

            member this.openid =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "openid").asPredicate)

            member this.skypeID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "skypeID").asPredicate)

            member this.status =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "status").asPredicate)

            member this.tipjar =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "tipjar").asPredicate)

            member this.topic_interest =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic_interest").asPredicate)

            member this.weblog =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "weblog").asPredicate)

            member this.yahooChatID =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "yahooChatID").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula

                member this.account =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "account").asPredicate)

                member this.age =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "age").asPredicate)

                member this.aimChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "aimChatID").asPredicate)

                member this.birthday =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "birthday").asPredicate)

                member this.gender =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "gender").asPredicate)

                member this.holdsAccount =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "holdsAccount").asPredicate)

                member this.icqChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "icqChatID").asPredicate)

                member this.interest =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "interest").asPredicate)

                member this.jabberID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "jabberID").asPredicate)

                member this.made =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "made").asPredicate)

                member this.mbox =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox").asPredicate)

                member this.mbox_sha1sum =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "mbox_sha1sum").asPredicate)

                member this.member_ =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "member").asPredicate)

                member this.msnChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "msnChatID").asPredicate)

                member this.openid =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "openid").asPredicate)

                member this.skypeID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "skypeID").asPredicate)

                member this.status =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "status").asPredicate)

                member this.tipjar =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "tipjar").asPredicate)

                member this.topic_interest =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic_interest").asPredicate)

                member this.weblog =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "weblog").asPredicate)

                member this.yahooChatID =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "yahooChatID").asPredicate)

    module Image =
        let Class = _namespace.prefixedName "Image"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract depicts: Formula
            abstract primaryTopic: Formula
            abstract sha1: Formula
            abstract thumbnail: Formula
            abstract topic: Formula

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula

            member this.depicts =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "depicts").asPredicate)

            member this.primaryTopic =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "primaryTopic").asPredicate)

            member this.sha1 =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sha1").asPredicate)

            member this.thumbnail =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "thumbnail").asPredicate)

            member this.topic =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula

                member this.depicts =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "depicts").asPredicate)

                member this.primaryTopic =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "primaryTopic").asPredicate)

                member this.sha1 =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sha1").asPredicate)

                member this.thumbnail =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "thumbnail").asPredicate)

                member this.topic =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic").asPredicate)

    module LabelProperty =
        let Class = _namespace.prefixedName "LabelProperty"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula

            interface Interface with
                member this.iri = iri
                member this.formula = _formula

    module OnlineAccount =
        let Class = _namespace.prefixedName "OnlineAccount"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract accountName: Formula
            abstract accountServiceHomepage: Formula
            abstract depiction: Formula
            abstract fundedBy: Formula
            abstract homepage: Formula
            abstract isPrimaryTopicOf: Formula
            abstract logo: Formula
            abstract maker: Formula
            abstract name: Formula
            abstract page: Formula
            abstract theme: Formula

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula

            member this.accountName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "accountName").asPredicate)

            member this.accountServiceHomepage =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "accountServiceHomepage").asPredicate)

            member this.depiction =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "depiction").asPredicate)

            member this.fundedBy =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fundedBy").asPredicate)

            member this.homepage =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "homepage").asPredicate)

            member this.isPrimaryTopicOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "isPrimaryTopicOf").asPredicate)

            member this.logo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "logo").asPredicate)

            member this.maker =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maker").asPredicate)

            member this.name =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "name").asPredicate)

            member this.page =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "page").asPredicate)

            member this.theme =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "theme").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula

                member this.accountName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "accountName").asPredicate)

                member this.accountServiceHomepage =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft ->
                        draft.addRdfPredicate (_namespace.prefixedName "accountServiceHomepage").asPredicate)

                member this.depiction =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "depiction").asPredicate)

                member this.fundedBy =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fundedBy").asPredicate)

                member this.homepage =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "homepage").asPredicate)

                member this.isPrimaryTopicOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "isPrimaryTopicOf").asPredicate)

                member this.logo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "logo").asPredicate)

                member this.maker =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maker").asPredicate)

                member this.name =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "name").asPredicate)

                member this.page =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "page").asPredicate)

                member this.theme =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "theme").asPredicate)

    module OnlineChatAccount =
        let Class = _namespace.prefixedName "OnlineChatAccount"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract accountName: Formula
            abstract accountServiceHomepage: Formula
            abstract depiction: Formula
            abstract fundedBy: Formula
            abstract homepage: Formula
            abstract isPrimaryTopicOf: Formula
            abstract logo: Formula
            abstract maker: Formula
            abstract name: Formula
            abstract page: Formula
            abstract theme: Formula

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula

            member this.accountName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "accountName").asPredicate)

            member this.accountServiceHomepage =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "accountServiceHomepage").asPredicate)

            member this.depiction =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "depiction").asPredicate)

            member this.fundedBy =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fundedBy").asPredicate)

            member this.homepage =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "homepage").asPredicate)

            member this.isPrimaryTopicOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "isPrimaryTopicOf").asPredicate)

            member this.logo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "logo").asPredicate)

            member this.maker =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maker").asPredicate)

            member this.name =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "name").asPredicate)

            member this.page =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "page").asPredicate)

            member this.theme =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "theme").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula

                member this.accountName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "accountName").asPredicate)

                member this.accountServiceHomepage =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft ->
                        draft.addRdfPredicate (_namespace.prefixedName "accountServiceHomepage").asPredicate)

                member this.depiction =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "depiction").asPredicate)

                member this.fundedBy =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fundedBy").asPredicate)

                member this.homepage =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "homepage").asPredicate)

                member this.isPrimaryTopicOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "isPrimaryTopicOf").asPredicate)

                member this.logo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "logo").asPredicate)

                member this.maker =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maker").asPredicate)

                member this.name =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "name").asPredicate)

                member this.page =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "page").asPredicate)

                member this.theme =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "theme").asPredicate)

    module OnlineEcommerceAccount =
        let Class = _namespace.prefixedName "OnlineEcommerceAccount"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract accountName: Formula
            abstract accountServiceHomepage: Formula
            abstract depiction: Formula
            abstract fundedBy: Formula
            abstract homepage: Formula
            abstract isPrimaryTopicOf: Formula
            abstract logo: Formula
            abstract maker: Formula
            abstract name: Formula
            abstract page: Formula
            abstract theme: Formula

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula

            member this.accountName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "accountName").asPredicate)

            member this.accountServiceHomepage =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "accountServiceHomepage").asPredicate)

            member this.depiction =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "depiction").asPredicate)

            member this.fundedBy =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fundedBy").asPredicate)

            member this.homepage =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "homepage").asPredicate)

            member this.isPrimaryTopicOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "isPrimaryTopicOf").asPredicate)

            member this.logo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "logo").asPredicate)

            member this.maker =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maker").asPredicate)

            member this.name =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "name").asPredicate)

            member this.page =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "page").asPredicate)

            member this.theme =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "theme").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula

                member this.accountName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "accountName").asPredicate)

                member this.accountServiceHomepage =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft ->
                        draft.addRdfPredicate (_namespace.prefixedName "accountServiceHomepage").asPredicate)

                member this.depiction =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "depiction").asPredicate)

                member this.fundedBy =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fundedBy").asPredicate)

                member this.homepage =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "homepage").asPredicate)

                member this.isPrimaryTopicOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "isPrimaryTopicOf").asPredicate)

                member this.logo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "logo").asPredicate)

                member this.maker =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maker").asPredicate)

                member this.name =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "name").asPredicate)

                member this.page =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "page").asPredicate)

                member this.theme =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "theme").asPredicate)

    module OnlineGamingAccount =
        let Class = _namespace.prefixedName "OnlineGamingAccount"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract accountName: Formula
            abstract accountServiceHomepage: Formula
            abstract depiction: Formula
            abstract fundedBy: Formula
            abstract homepage: Formula
            abstract isPrimaryTopicOf: Formula
            abstract logo: Formula
            abstract maker: Formula
            abstract name: Formula
            abstract page: Formula
            abstract theme: Formula

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula

            member this.accountName =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "accountName").asPredicate)

            member this.accountServiceHomepage =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "accountServiceHomepage").asPredicate)

            member this.depiction =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "depiction").asPredicate)

            member this.fundedBy =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fundedBy").asPredicate)

            member this.homepage =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "homepage").asPredicate)

            member this.isPrimaryTopicOf =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "isPrimaryTopicOf").asPredicate)

            member this.logo =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "logo").asPredicate)

            member this.maker =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maker").asPredicate)

            member this.name =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "name").asPredicate)

            member this.page =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "page").asPredicate)

            member this.theme =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "theme").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula

                member this.accountName =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "accountName").asPredicate)

                member this.accountServiceHomepage =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft ->
                        draft.addRdfPredicate (_namespace.prefixedName "accountServiceHomepage").asPredicate)

                member this.depiction =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "depiction").asPredicate)

                member this.fundedBy =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "fundedBy").asPredicate)

                member this.homepage =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "homepage").asPredicate)

                member this.isPrimaryTopicOf =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "isPrimaryTopicOf").asPredicate)

                member this.logo =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "logo").asPredicate)

                member this.maker =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "maker").asPredicate)

                member this.name =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "name").asPredicate)

                member this.page =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "page").asPredicate)

                member this.theme =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "theme").asPredicate)

    module PersonalProfileDocument =
        let Class = _namespace.prefixedName "PersonalProfileDocument"

        type Interface =
            abstract iri: NamedReference
            abstract formula: Formula
            abstract primaryTopic: Formula
            abstract sha1: Formula
            abstract topic: Formula

        type NamedIndividual(iri: NamedReference) =
            let _formula =
                Formula.fromRdfSubject iri.asSubject
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject _owlNamedIndividual.asObject)
                |> Formula.materializeFormula
                |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate _rdfType.asPredicate)
                |> (fun draft -> draft.addRdfObject Class.asObject)
                |> Formula.materializeFormula

            member this.iri = iri
            member this.formula = _formula

            member this.primaryTopic =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "primaryTopic").asPredicate)

            member this.sha1 =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sha1").asPredicate)

            member this.topic =
                _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic").asPredicate)

            interface Interface with
                member this.iri = iri
                member this.formula = _formula

                member this.primaryTopic =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "primaryTopic").asPredicate)

                member this.sha1 =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "sha1").asPredicate)

                member this.topic =
                    _formula |> (fun draft -> draft.addRdfSubject iri.asSubject)
                    |> (fun draft -> draft.addRdfPredicate (_namespace.prefixedName "topic").asPredicate)

    let account = _namespace.prefixedName "account"
    let accountName = _namespace.prefixedName "accountName"
    let accountServiceHomepage = _namespace.prefixedName "accountServiceHomepage"
    let age = _namespace.prefixedName "age"
    let aimChatID = _namespace.prefixedName "aimChatID"
    let nick = _namespace.prefixedName "nick"
    let based_near = _namespace.prefixedName "based_near"
    let birthday = _namespace.prefixedName "birthday"
    let currentProject = _namespace.prefixedName "currentProject"
    let depiction = _namespace.prefixedName "depiction"
    let depicts = _namespace.prefixedName "depicts"
    let dnaChecksum = _namespace.prefixedName "dnaChecksum"
    let familyName = _namespace.prefixedName "familyName"
    let family_name = _namespace.prefixedName "family_name"
    let firstName = _namespace.prefixedName "firstName"
    let focus = _namespace.prefixedName "focus"
    let fundedBy = _namespace.prefixedName "fundedBy"
    let geekcode = _namespace.prefixedName "geekcode"
    let gender = _namespace.prefixedName "gender"
    let givenName = _namespace.prefixedName "givenName"
    let givenname = _namespace.prefixedName "givenname"
    let holdsAccount = _namespace.prefixedName "holdsAccount"
    let homepage = _namespace.prefixedName "homepage"
    let page = _namespace.prefixedName "page"
    let isPrimaryTopicOf = _namespace.prefixedName "isPrimaryTopicOf"
    let topic = _namespace.prefixedName "topic"
    let primaryTopic = _namespace.prefixedName "primaryTopic"
    let icqChatID = _namespace.prefixedName "icqChatID"
    let img = _namespace.prefixedName "img"
    let interest = _namespace.prefixedName "interest"
    let jabberID = _namespace.prefixedName "jabberID"
    let knows = _namespace.prefixedName "knows"
    let lastName = _namespace.prefixedName "lastName"
    let logo = _namespace.prefixedName "logo"
    let made = _namespace.prefixedName "made"
    let maker = _namespace.prefixedName "maker"
    let mbox = _namespace.prefixedName "mbox"
    let mbox_sha1sum = _namespace.prefixedName "mbox_sha1sum"
    let member_ = _namespace.prefixedName "member"
    let membershipClass = _namespace.prefixedName "membershipClass"
    let msnChatID = _namespace.prefixedName "msnChatID"
    let myersBriggs = _namespace.prefixedName "myersBriggs"
    let name = _namespace.prefixedName "name"
    let openid = _namespace.prefixedName "openid"
    let pastProject = _namespace.prefixedName "pastProject"
    let phone = _namespace.prefixedName "phone"
    let plan = _namespace.prefixedName "plan"
    let publications = _namespace.prefixedName "publications"
    let schoolHomepage = _namespace.prefixedName "schoolHomepage"
    let sha1 = _namespace.prefixedName "sha1"
    let skypeID = _namespace.prefixedName "skypeID"
    let status = _namespace.prefixedName "status"
    let surname = _namespace.prefixedName "surname"
    let theme = _namespace.prefixedName "theme"
    let thumbnail = _namespace.prefixedName "thumbnail"
    let tipjar = _namespace.prefixedName "tipjar"
    let title = _namespace.prefixedName "title"
    let topic_interest = _namespace.prefixedName "topic_interest"
    let weblog = _namespace.prefixedName "weblog"
    let workInfoHomepage = _namespace.prefixedName "workInfoHomepage"
    let workplaceHomepage = _namespace.prefixedName "workplaceHomepage"
    let yahooChatID = _namespace.prefixedName "yahooChatID"
