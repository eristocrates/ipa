namespace https.w3id.org.inrupt._namespace.vocab.authn_provider.slash

open DoxAletheia.Rdf_Vocabulary

module authn_provider =
    let _namespace_name = "https://w3id.org/inrupt/namespace/vocab/authn_provider/"
    /// <summary>
    ///   <see href="https://w3id.org/inrupt/namespace/vocab/authn_provider/1.0.0"></see>
    /// </summary>
    let ``_1.0.0`` = Namespaced_IRI.parse _namespace_name "1.0.0" |> NamespacedName

    /// <summary>
    /// An authentication provider.
    /// <see href="https://w3id.org/inrupt/namespace/vocab/authn_provider/AuthenticationProvider"></see></summary>
    let AuthenticationProvider =
        Namespaced_IRI.parse _namespace_name "AuthenticationProvider" |> NamespacedName

    /// <summary>
    /// Refers to an authentication provider.
    /// <see href="https://w3id.org/inrupt/namespace/vocab/authn_provider/hasAuthenticationProvider"></see></summary>
    let hasAuthenticationProvider =
        Namespaced_IRI.parse _namespace_name "hasAuthenticationProvider" |> NamespacedName

    /// <summary>
    /// Has multi-factor authentication (MFA) been enabled?
    /// <see href="https://w3id.org/inrupt/namespace/vocab/authn_provider/hasMfaEnabled"></see></summary>
    let hasMfaEnabled =
        Namespaced_IRI.parse _namespace_name "hasMfaEnabled" |> NamespacedName

    /// <summary>
    /// Has multi-factor authentication (MFA) been enforced?
    /// <see href="https://w3id.org/inrupt/namespace/vocab/authn_provider/hasMfaEnforced"></see></summary>
    let hasMfaEnforced =
        Namespaced_IRI.parse _namespace_name "hasMfaEnforced" |> NamespacedName
