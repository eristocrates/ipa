namespace http.open_multinet.info.ontology.omn_federation.hash

open DoxAletheia

module omnfed =
    let _namespace_name = "http://open-multinet.info/ontology/omn-federation#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-federation#Federation"></see>
    /// </summary>
    let Federation = _prefix "Federation"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-federation#FederationMember"></see>
    /// </summary>
    let FederationMember = _prefix "FederationMember"
    /// <summary>
    /// an infrastructure such as a testbed or cloud facility
    /// Example: FUESCO Playground
    /// <see href="http://open-multinet.info/ontology/omn-federation#Infrastructure"></see></summary>
    let Infrastructure = _prefix "Infrastructure"
    /// <summary>
    /// an organization (e.g. a federation member) administers its own infrastructure
    /// <see href="http://open-multinet.info/ontology/omn-federation#administers"></see></summary>
    let administers = _prefix "administers"
    /// <summary>
    /// an infrastructure can be administered by an organization (e.g. a federation member)
    /// <see href="http://open-multinet.info/ontology/omn-federation#isAdministeredBy"></see></summary>
    let isAdministeredBy = _prefix "isAdministeredBy"
    /// <summary>
    /// a federation can have an organization as a member
    /// <see href="http://open-multinet.info/ontology/omn-federation#hasFederationMember"></see></summary>
    let hasFederationMember = _prefix "hasFederationMember"
    /// <summary>
    /// an organization can be part of a federation
    /// <see href="http://open-multinet.info/ontology/omn-federation#partOfFederation"></see></summary>
    let partOfFederation = _prefix "partOfFederation"
