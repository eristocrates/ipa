namespace http.www.w3.org.ns.solid.oidc.hash

open DoxAletheia

module oidc =
    let _namespace_name = "http://www.w3.org/ns/solid/oidc#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// TODO
    /// <see href="http://www.w3.org/ns/solid/oidc#application_type"></see></summary>
    let application_type = _prefix "application_type"
    /// <summary>
    /// A name for this client that can be presented to an End-User
    /// <see href="http://www.w3.org/ns/solid/oidc#client_name"></see></summary>
    let client_name = _prefix "client_name"
    /// <summary>
    /// A URI for this client's home page
    /// <see href="http://www.w3.org/ns/solid/oidc#client_uri"></see></summary>
    let client_uri = _prefix "client_uri"
    /// <summary>
    /// A collection of URIs where individuals or entities responsible for this client can be contacted.
    /// <see href="http://www.w3.org/ns/solid/oidc#contacts"></see></summary>
    let contacts = _prefix "contacts"
    /// <summary>
    /// TODO
    /// <see href="http://www.w3.org/ns/solid/oidc#default_max_age"></see></summary>
    let default_max_age = _prefix "default_max_age"
    /// <summary>
    /// A collection of OAuth 2.0 Grant Types that the client will restrict itself to using.
    /// <see href="http://www.w3.org/ns/solid/oidc#grant_types"></see></summary>
    let grant_types = _prefix "grant_types"
    /// <summary>
    /// A URI for this client's logo
    /// <see href="http://www.w3.org/ns/solid/oidc#logo_uri"></see></summary>
    let logo_uri = _prefix "logo_uri"
    /// <summary>
    /// A URI for this client's policy document
    /// <see href="http://www.w3.org/ns/solid/oidc#policy_uri"></see></summary>
    let policy_uri = _prefix "policy_uri"
    /// <summary>
    /// A collection of registered URIs used by the client for redirection
    /// <see href="http://www.w3.org/ns/solid/oidc#redirect_uris"></see></summary>
    let redirect_uris = _prefix "redirect_uris"
    /// <summary>
    /// TODO
    /// <see href="http://www.w3.org/ns/solid/oidc#require_auth_time"></see></summary>
    let require_auth_time = _prefix "require_auth_time"
    /// <summary>
    /// A collection of OAuth 2.0 Response Types that the client will restrict itself to using.
    /// <see href="http://www.w3.org/ns/solid/oidc#response_types"></see></summary>
    let response_types = _prefix "response_types"
    /// <summary>
    /// An OAuth2 scope for the requested access token.
    /// <see href="http://www.w3.org/ns/solid/oidc#scope"></see></summary>
    let scope = _prefix "scope"
    /// <summary>
    /// The requested client authentication method for the Token Endpoint
    /// <see href="http://www.w3.org/ns/solid/oidc#token_endpoint_auth_method"></see></summary>
    let token_endpoint_auth_method = _prefix "token_endpoint_auth_method"
    /// <summary>
    /// A URI for this client's terms of service document
    /// <see href="http://www.w3.org/ns/solid/oidc#tos_uri"></see></summary>
    let tos_uri = _prefix "tos_uri"
