namespace http.data.press.net.ontology.identifier.slash

open DoxAletheia

module pni =
    let _namespace_name = "http://data.press.net/ontology/identifier/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The Authority for an Identifier, for example the domain or namespace within which an ID is contained
    /// <see href="http://data.press.net/ontology/identifier/Authority"></see></summary>
    let Authority = _prefix "Authority"
    /// <summary>
    /// An instance that is Identifiable can have an Identifier associated with it.
    /// <see href="http://data.press.net/ontology/identifier/Identifiable"></see></summary>
    let Identifiable = _prefix "Identifiable"
    /// <summary>
    /// An ID for a given resource. For example a literal ID from a legacy system
    /// <see href="http://data.press.net/ontology/identifier/Identifier"></see></summary>
    let Identifier = _prefix "Identifier"
    /// <summary>
    /// Property defining the containing authority of an Identifier
    /// <see href="http://data.press.net/ontology/identifier/authority"></see></summary>
    let authority = _prefix "authority"
    /// <summary>
    /// Associates an Identifier to an Identifiable thing
    /// <see href="http://data.press.net/ontology/identifier/hasIdentifier"></see></summary>
    let hasIdentifier = _prefix "hasIdentifier"
    /// <summary>
    /// Property indicating the literal value of the Identifier
    /// <see href="http://data.press.net/ontology/identifier/value"></see></summary>
    let value = _prefix "value"
