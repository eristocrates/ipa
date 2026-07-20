namespace https.w3id.org.inrupt._namespace.vocab.authn_provider.slash

open DoxAletheia

module authn_provider =
    let _namespace_name = "https://w3id.org/inrupt/namespace/vocab/authn_provider/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/inrupt/namespace/vocab/authn_provider/1.0.0"></see>
    /// </summary>
    let ``_1.0.0`` = _prefix "1.0.0"
    /// <summary>
    /// An authentication provider.
    /// <see href="https://w3id.org/inrupt/namespace/vocab/authn_provider/AuthenticationProvider"></see></summary>
    let AuthenticationProvider = _prefix "AuthenticationProvider"
    /// <summary>
    /// Refers to an authentication provider.
    /// <see href="https://w3id.org/inrupt/namespace/vocab/authn_provider/hasAuthenticationProvider"></see></summary>
    let hasAuthenticationProvider = _prefix "hasAuthenticationProvider"
    /// <summary>
    /// Has multi-factor authentication (MFA) been enabled?
    /// <see href="https://w3id.org/inrupt/namespace/vocab/authn_provider/hasMfaEnabled"></see></summary>
    let hasMfaEnabled = _prefix "hasMfaEnabled"
    /// <summary>
    /// Has multi-factor authentication (MFA) been enforced?
    /// <see href="https://w3id.org/inrupt/namespace/vocab/authn_provider/hasMfaEnforced"></see></summary>
    let hasMfaEnforced = _prefix "hasMfaEnforced"
