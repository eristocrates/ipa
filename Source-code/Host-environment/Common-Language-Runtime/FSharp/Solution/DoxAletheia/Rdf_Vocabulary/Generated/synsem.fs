namespace http.www.w3.org.ns.lemon.synsem.hash

open DoxAletheia.Rdf_Vocabulary

module synsem =
    let _namespace_name = "http://www.w3.org/ns/lemon/synsem#"
    /// <summary>
    /// An 'ontology mapping' (OntoMap for short) specifies how a syntactic frame and its syntactic arguments map to a set of concepts and properties in the ontology that together specify the meaning of the syntactic frame.
    /// <see href="http://www.w3.org/ns/lemon/synsem#OntoMap"></see></summary>
    let OntoMap = Namespaced_IRI.parse _namespace_name "OntoMap" |> NamespacedName

    /// <summary>
    /// A 'syntactic argument' represents a slot that needs to be filled for a certain syntactic frame to be complete. Syntactic arguments typically realize a certain grammatical function (e.g. subject, direct object, indirect object, prepositional object, etc.).
    /// <see href="http://www.w3.org/ns/lemon/synsem#SyntacticArgument"></see></summary>
    let SyntacticArgument =
        Namespaced_IRI.parse _namespace_name "SyntacticArgument" |> NamespacedName

    /// <summary>
    /// A 'syntactic frame' represents the syntactic behavior of an open class word in terms of the (syntactic) arguments it requires. It essentially describes the so called subcategorization structure of the word in question, in particular the syntactic arguments it requires.
    /// <see href="http://www.w3.org/ns/lemon/synsem#SyntacticFrame"></see></summary>
    let SyntacticFrame =
        Namespaced_IRI.parse _namespace_name "SyntacticFrame" |> NamespacedName

    /// <summary>
    /// The 'condition' property defines an evaluable constraint that derives from using a certain lexical entry to express a given ontological predicate.
    /// <see href="http://www.w3.org/ns/lemon/synsem#condition"></see></summary>
    let condition = Namespaced_IRI.parse _namespace_name "condition" |> NamespacedName
    /// <summary>
    /// The 'is a' property represents the single argument of a class or unary  predicate.
    /// <see href="http://www.w3.org/ns/lemon/synsem#isA"></see></summary>
    let isA = Namespaced_IRI.parse _namespace_name "isA" |> NamespacedName

    /// <summary>
    /// The 'ontoCorrespondence' property binds an argument of a predicate defined in the ontology to a syntactic argument that realizes this predicate argument syntactically.
    /// <see href="http://www.w3.org/ns/lemon/synsem#ontoCorrespondence"></see></summary>
    let ontoCorrespondence =
        Namespaced_IRI.parse _namespace_name "ontoCorrespondence" |> NamespacedName

    /// <summary>
    /// The 'marker' property indicates the marker of a syntactic argument; this can be a case marker or some other lexical entry such as a preposition or particle.
    /// <see href="http://www.w3.org/ns/lemon/synsem#marker"></see></summary>
    let marker = Namespaced_IRI.parse _namespace_name "marker" |> NamespacedName
    /// <summary>
    /// The 'objOfProp' represents the 2nd argument or object of a binary predicate (property) in the ontology.
    /// <see href="http://www.w3.org/ns/lemon/synsem#objOfProp"></see></summary>
    let objOfProp = Namespaced_IRI.parse _namespace_name "objOfProp" |> NamespacedName

    /// <summary>
    /// The 'ontoMapping'  property relates an ontology mapping to its corresponding lexical sense.
    /// <see href="http://www.w3.org/ns/lemon/synsem#ontoMapping"></see></summary>
    let ontoMapping =
        Namespaced_IRI.parse _namespace_name "ontoMapping" |> NamespacedName

    /// <summary>
    /// The 'optional' property indicates whether a syntactic argument is optional, that is, it can be syntactically omitted.
    /// <see href="http://www.w3.org/ns/lemon/synsem#optional"></see></summary>
    let optional = Namespaced_IRI.parse _namespace_name "optional" |> NamespacedName

    /// <summary>
    /// 'Property domain' provides a pragmatic restriction on the domain of the property referred to by this sense.
    /// <see href="http://www.w3.org/ns/lemon/synsem#propertyDomain"></see></summary>
    let propertyDomain =
        Namespaced_IRI.parse _namespace_name "propertyDomain" |> NamespacedName

    /// <summary>
    /// 'Property domain' provides a pragmatic restriction on the range of the property referred to by this sense.
    /// <see href="http://www.w3.org/ns/lemon/synsem#propertyRange"></see></summary>
    let propertyRange =
        Namespaced_IRI.parse _namespace_name "propertyRange" |> NamespacedName

    /// <summary>
    /// The 'subjOfProp' property represents the 1st argument or subject of a binary predicate (property) in the ontology.
    /// <see href="http://www.w3.org/ns/lemon/synsem#subjOfProp"></see></summary>
    let subjOfProp = Namespaced_IRI.parse _namespace_name "subjOfProp" |> NamespacedName
    /// <summary>
    /// The 'submap' property relates a (complex) ontological mapping to a set of bindings that together bind the arguments of the involved predicates to a set of syntactic arguments that realize them syntactically.
    /// <see href="http://www.w3.org/ns/lemon/synsem#submap"></see></summary>
    let submap = Namespaced_IRI.parse _namespace_name "submap" |> NamespacedName
    /// <summary>
    /// The object property synArg relates a syntactic frame to one of its syntactic arguments.
    /// <see href="http://www.w3.org/ns/lemon/synsem#synArg"></see></summary>
    let synArg = Namespaced_IRI.parse _namespace_name "synArg" |> NamespacedName

    /// <summary>
    /// The 'syntactic behavior' property relates a lexical entry to one of its syntactic behaviors as captured by a syntactic frame.
    /// <see href="http://www.w3.org/ns/lemon/synsem#synBehavior"></see></summary>
    let synBehavior =
        Namespaced_IRI.parse _namespace_name "synBehavior" |> NamespacedName
