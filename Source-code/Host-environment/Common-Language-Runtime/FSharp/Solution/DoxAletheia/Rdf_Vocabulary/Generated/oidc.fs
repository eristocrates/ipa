namespace http.www.w3.org.ns.solid.oidc.hash

open DoxAletheia.Rdf_Vocabulary

module oidc =
    let _namespace_name = "http://www.w3.org/ns/solid/oidc#"

    /// <summary>
    /// TODO
    /// <see href="http://www.w3.org/ns/solid/oidc#application_type"></see></summary>
    let application_type =
        Namespaced_IRI.parse _namespace_name "application_type" |> NamespacedName

    /// <summary>
    /// A name for this client that can be presented to an End-User
    /// <see href="http://www.w3.org/ns/solid/oidc#client_name"></see></summary>
    let client_name =
        Namespaced_IRI.parse _namespace_name "client_name" |> NamespacedName

    /// <summary>
    /// A URI for this client's home page
    /// <see href="http://www.w3.org/ns/solid/oidc#client_uri"></see></summary>
    let client_uri = Namespaced_IRI.parse _namespace_name "client_uri" |> NamespacedName
    /// <summary>
    /// A collection of URIs where individuals or entities responsible for this client can be contacted.
    /// <see href="http://www.w3.org/ns/solid/oidc#contacts"></see></summary>
    let contacts = Namespaced_IRI.parse _namespace_name "contacts" |> NamespacedName

    /// <summary>
    /// TODO
    /// <see href="http://www.w3.org/ns/solid/oidc#default_max_age"></see></summary>
    let default_max_age =
        Namespaced_IRI.parse _namespace_name "default_max_age" |> NamespacedName

    /// <summary>
    /// A collection of OAuth 2.0 Grant Types that the client will restrict itself to using.
    /// <see href="http://www.w3.org/ns/solid/oidc#grant_types"></see></summary>
    let grant_types =
        Namespaced_IRI.parse _namespace_name "grant_types" |> NamespacedName

    /// <summary>
    /// A URI for this client's logo
    /// <see href="http://www.w3.org/ns/solid/oidc#logo_uri"></see></summary>
    let logo_uri = Namespaced_IRI.parse _namespace_name "logo_uri" |> NamespacedName
    /// <summary>
    /// A URI for this client's policy document
    /// <see href="http://www.w3.org/ns/solid/oidc#policy_uri"></see></summary>
    let policy_uri = Namespaced_IRI.parse _namespace_name "policy_uri" |> NamespacedName

    /// <summary>
    /// A collection of registered URIs used by the client for redirection
    /// <see href="http://www.w3.org/ns/solid/oidc#redirect_uris"></see></summary>
    let redirect_uris =
        Namespaced_IRI.parse _namespace_name "redirect_uris" |> NamespacedName

    /// <summary>
    /// TODO
    /// <see href="http://www.w3.org/ns/solid/oidc#require_auth_time"></see></summary>
    let require_auth_time =
        Namespaced_IRI.parse _namespace_name "require_auth_time" |> NamespacedName

    /// <summary>
    /// A collection of OAuth 2.0 Response Types that the client will restrict itself to using.
    /// <see href="http://www.w3.org/ns/solid/oidc#response_types"></see></summary>
    let response_types =
        Namespaced_IRI.parse _namespace_name "response_types" |> NamespacedName

    /// <summary>
    /// An OAuth2 scope for the requested access token.
    /// <see href="http://www.w3.org/ns/solid/oidc#scope"></see></summary>
    let scope = Namespaced_IRI.parse _namespace_name "scope" |> NamespacedName

    /// <summary>
    /// The requested client authentication method for the Token Endpoint
    /// <see href="http://www.w3.org/ns/solid/oidc#token_endpoint_auth_method"></see></summary>
    let token_endpoint_auth_method =
        Namespaced_IRI.parse _namespace_name "token_endpoint_auth_method" |> NamespacedName

    /// <summary>
    /// A URI for this client's terms of service document
    /// <see href="http://www.w3.org/ns/solid/oidc#tos_uri"></see></summary>
    let tos_uri = Namespaced_IRI.parse _namespace_name "tos_uri" |> NamespacedName
