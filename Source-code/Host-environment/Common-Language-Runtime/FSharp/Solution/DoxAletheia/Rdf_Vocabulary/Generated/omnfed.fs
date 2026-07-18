namespace http.open_multinet.info.ontology.omn_federation.hash

open DoxAletheia.Rdf_Vocabulary

module omnfed =
    let _namespace_name = "http://open-multinet.info/ontology/omn-federation#"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-federation#Federation"></see>
    /// </summary>
    let Federation = Namespaced_IRI.parse _namespace_name "Federation" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-federation#FederationMember"></see>
    /// </summary>
    let FederationMember =
        Namespaced_IRI.parse _namespace_name "FederationMember" |> NamespacedName

    /// <summary>
    /// an infrastructure such as a testbed or cloud facility
    /// Example: FUESCO Playground
    /// <see href="http://open-multinet.info/ontology/omn-federation#Infrastructure"></see></summary>
    let Infrastructure =
        Namespaced_IRI.parse _namespace_name "Infrastructure" |> NamespacedName

    /// <summary>
    /// an organization (e.g. a federation member) administers its own infrastructure
    /// <see href="http://open-multinet.info/ontology/omn-federation#administers"></see></summary>
    let administers =
        Namespaced_IRI.parse _namespace_name "administers" |> NamespacedName

    /// <summary>
    /// an infrastructure can be administered by an organization (e.g. a federation member)
    /// <see href="http://open-multinet.info/ontology/omn-federation#isAdministeredBy"></see></summary>
    let isAdministeredBy =
        Namespaced_IRI.parse _namespace_name "isAdministeredBy" |> NamespacedName

    /// <summary>
    /// a federation can have an organization as a member
    /// <see href="http://open-multinet.info/ontology/omn-federation#hasFederationMember"></see></summary>
    let hasFederationMember =
        Namespaced_IRI.parse _namespace_name "hasFederationMember" |> NamespacedName

    /// <summary>
    /// an organization can be part of a federation
    /// <see href="http://open-multinet.info/ontology/omn-federation#partOfFederation"></see></summary>
    let partOfFederation =
        Namespaced_IRI.parse _namespace_name "partOfFederation" |> NamespacedName
