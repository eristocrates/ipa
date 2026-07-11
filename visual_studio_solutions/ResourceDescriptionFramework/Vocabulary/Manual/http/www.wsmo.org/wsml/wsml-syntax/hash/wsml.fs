module Wsml.Namespace

module wsml =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://www.wsmo.org/wsml/wsml-syntax#"
            None
            (Some "wsml")
            None


    /// Used as predicate to indicate the WSML variant applied.
    let variant = { _prefixID with _localName = "variant" }
    /// Used to define a WSML goal.
    let goal = { _prefixID with _localName = "goal" }

    /// Used to define a WSML ontology.
    let ontology = { _prefixID with _localName = "ontology" }
    /// Used to define a WSML ooMediator
    let ooMediator = { _prefixID with _localName = "ooMediator" }

    /// Used to type a WSML concept and to bind it to an ontology.
    let hasConcept = { _prefixID with _localName = "hasConcept" }
    /// Used to define a WSML ggMediator
    let ggMediator = { _prefixID with _localName = "ggMediator" }

    /// Used to define a WSML attribute
    let attribute = { _prefixID with _localName = "attribute" }
    /// Used to define a WSML wgMediator
    let wgMediator = { _prefixID with _localName = "wgMediator" }

    /// Used as predicate to define constraining attributes and parameters.
    let ofType = { _prefixID with _localName = "ofType" }
    /// Used to define a WSML wwMediator
    let wwMediator = { _prefixID with _localName = "wwMediator" }

    /// Used as predicate to bind an attribute to a concept.
    let hasAttribute = { _prefixID with _localName = "hasAttribute" }
    /// Used to define a WSML webService
    let webService = { _prefixID with _localName = "webService" }

    /// Used to indicate the transitivity of an attribute.
    let transitiveAttribute = { _prefixID with _localName = "transitiveAttribute" }
    /// Used as predicate to bind an interface to a Web service.
    let useInterface = { _prefixID with _localName = "useInterface" }

    /// Used to indicate the symmetry of an attribute.
    let symmetricAttribute = { _prefixID with _localName = "symmetricAttribute" }
    /// Used as predicate to bind a capability to a Web service or goal.
    let useCapability = { _prefixID with _localName = "useCapability" }

    /// Used to indicate the reflexivity of an attribute.
    let reflexiveAttribute = { _prefixID with _localName = "reflexiveAttribute" }
    /// Used as predicate to bind a shared variable to a capability.
    let sharedVariables = { _prefixID with _localName = "sharedVariables" }

    /// Used to indicate the inverse relationship of two attributes.
    let inverseOf = { _prefixID with _localName = "inverseOf" }
    /// Used to type a precondition and to bind it to a capability.
    let precondition = { _prefixID with _localName = "precondition" }

    /// Used as predicate to defined the minimal cardinality of an attribute.
    let minCardinality = { _prefixID with _localName = "minCardinality" }
    /// Used to type an assumption and to bind it to a capability.
    let assumption = { _prefixID with _localName = "assumption" }

    /// Used as predicate to defined the maximal cardinality of an attribute.
    let maxCardinality = { _prefixID with _localName = "maxCardinality" }
    /// Used to type a postcondition and to bind it to a capability.
    let postcondition = { _prefixID with _localName = "postcondition" }

    /// Used to type an instance and to bind it to a concept.
    let hasInstance = { _prefixID with _localName = "hasInstance" }
    /// Used to type an effect and to bind it to a capability.
    let effect = { _prefixID with _localName = "effect" }

    /// Used to type a relation and to bind it to an ontology.
    let hasRelation = { _prefixID with _localName = "hasRelation" }
    /// Used to type a choreography and to bind it to an interface.
    let choreography = { _prefixID with _localName = "choreography" }

    /// Used to define the arity of a WSML relation.
    let arity = { _prefixID with _localName = "arity" }
    /// Used to type an orchestration and to bind it to an interface.
    let orchestration = { _prefixID with _localName = "orchestration" }

    /// Used to type parameters of WSML relations.
    let param = { _prefixID with _localName = "param" }
    /// Used to type non-functional properties.
    let nfp = { _prefixID with _localName = "nfp" }

    /// Used as predicate to define sub-relations.
    let subRelationOf = { _prefixID with _localName = "subRelationOf" }
    /// Used to define the import of an external ontology.
    let importsOntology = { _prefixID with _localName = "importsOntology" }

    /// Used to type a relation instance and to bind it to an ontology.
    let hasRelationInstance = { _prefixID with _localName = "hasRelationInstance" }
    /// Used to define the use of a mediator.
    let usesMediator = { _prefixID with _localName = "usesMediator" }

    /// Used to type an axiom and to bind it to an ontology.
    let hasAxiom = { _prefixID with _localName = "hasAxiom" }
