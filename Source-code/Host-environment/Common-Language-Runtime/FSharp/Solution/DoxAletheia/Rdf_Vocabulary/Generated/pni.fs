namespace http.data.press.net.ontology.identifier.slash

open DoxAletheia.Rdf_Vocabulary

module pni =
    let _namespace_name = "http://data.press.net/ontology/identifier/"
    /// <summary>
    /// The Authority for an Identifier, for example the domain or namespace within which an ID is contained
    /// <see href="http://data.press.net/ontology/identifier/Authority"></see></summary>
    let Authority = Namespaced_IRI.parse _namespace_name "Authority" |> NamespacedName

    /// <summary>
    /// An instance that is Identifiable can have an Identifier associated with it.
    /// <see href="http://data.press.net/ontology/identifier/Identifiable"></see></summary>
    let Identifiable =
        Namespaced_IRI.parse _namespace_name "Identifiable" |> NamespacedName

    /// <summary>
    /// An ID for a given resource. For example a literal ID from a legacy system
    /// <see href="http://data.press.net/ontology/identifier/Identifier"></see></summary>
    let Identifier = Namespaced_IRI.parse _namespace_name "Identifier" |> NamespacedName
    /// <summary>
    /// Property defining the containing authority of an Identifier
    /// <see href="http://data.press.net/ontology/identifier/authority"></see></summary>
    let authority = Namespaced_IRI.parse _namespace_name "authority" |> NamespacedName

    /// <summary>
    /// Associates an Identifier to an Identifiable thing
    /// <see href="http://data.press.net/ontology/identifier/hasIdentifier"></see></summary>
    let hasIdentifier =
        Namespaced_IRI.parse _namespace_name "hasIdentifier" |> NamespacedName

    /// <summary>
    /// Property indicating the literal value of the Identifier
    /// <see href="http://data.press.net/ontology/identifier/value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
