namespace http.www.w3.org.ns.solid.oidc.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oidc =
    let _namespace_iri = Namespace_Iri oidc |> NamespaceIRI
    /// <summary>
    ///   <para>oidc:default_max_age</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TODO</para>
    /// labels<para>default max age</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#default_max_age">http://www.w3.org/ns/solid/oidc#default_max_age</seealso>
    let default_max_age = Prefixed_Name(oidc, "default_max_age") |> PrefixedName
    /// <summary>
    ///   <para>oidc:client_uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A URI for this client's home page</para>
    /// labels<para>client URI</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#client_uri">http://www.w3.org/ns/solid/oidc#client_uri</seealso>
    let client_uri = Prefixed_Name(oidc, "client_uri") |> PrefixedName
    /// <summary>
    ///   <para>oidc:grant_types</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A collection of OAuth 2.0 Grant Types that the client will restrict itself to using.</para>
    /// labels<para>grant types</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#grant_types">http://www.w3.org/ns/solid/oidc#grant_types</seealso>
    let grant_types = Prefixed_Name(oidc, "grant_types") |> PrefixedName
    /// <summary>
    ///   <para>oidc:application_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TODO</para>
    /// labels<para>application type</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#application_type">http://www.w3.org/ns/solid/oidc#application_type</seealso>
    let application_type = Prefixed_Name(oidc, "application_type") |> PrefixedName
    /// <summary>
    ///   <para>oidc:contacts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A collection of URIs where individuals or entities responsible for this client can be contacted.</para>
    /// labels<para>contacts</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#contacts">http://www.w3.org/ns/solid/oidc#contacts</seealso>
    let contacts = Prefixed_Name(oidc, "contacts") |> PrefixedName
    /// <summary>
    ///   <para>oidc:logo_uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A URI for this client's logo</para>
    /// labels<para>logo URI</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#logo_uri">http://www.w3.org/ns/solid/oidc#logo_uri</seealso>
    let logo_uri = Prefixed_Name(oidc, "logo_uri") |> PrefixedName
    /// <summary>
    ///   <para>oidc:policy_uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A URI for this client's policy document</para>
    /// labels<para>policy URI</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#policy_uri">http://www.w3.org/ns/solid/oidc#policy_uri</seealso>
    let policy_uri = Prefixed_Name(oidc, "policy_uri") |> PrefixedName
    /// <summary>
    ///   <para>oidc:require_auth_time</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TODO</para>
    /// labels<para>require auth time</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#require_auth_time">http://www.w3.org/ns/solid/oidc#require_auth_time</seealso>
    let require_auth_time = Prefixed_Name(oidc, "require_auth_time") |> PrefixedName
    /// <summary>
    ///   <para>oidc:response_types</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A collection of OAuth 2.0 Response Types that the client will restrict itself to using.</para>
    /// labels<para>response types</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#response_types">http://www.w3.org/ns/solid/oidc#response_types</seealso>
    let response_types = Prefixed_Name(oidc, "response_types") |> PrefixedName

    /// <summary>
    ///   <para>oidc:token_endpoint_auth_method</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The requested client authentication method for the Token Endpoint</para>
    /// labels<para>token endpoint auth method</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#token_endpoint_auth_method">http://www.w3.org/ns/solid/oidc#token_endpoint_auth_method</seealso>
    let token_endpoint_auth_method =
        Prefixed_Name(oidc, "token_endpoint_auth_method") |> PrefixedName

    /// <summary>
    ///   <para>oidc:redirect_uris</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A collection of registered URIs used by the client for redirection</para>
    /// labels<para>redirect URIs</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#redirect_uris">http://www.w3.org/ns/solid/oidc#redirect_uris</seealso>
    let redirect_uris = Prefixed_Name(oidc, "redirect_uris") |> PrefixedName
    /// <summary>
    ///   <para>oidc:scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An OAuth2 scope for the requested access token.</para>
    /// labels<para>scope</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#scope">http://www.w3.org/ns/solid/oidc#scope</seealso>
    let scope = Prefixed_Name(oidc, "scope") |> PrefixedName
    /// <summary>
    ///   <para>oidc:tos_uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A URI for this client's terms of service document</para>
    /// labels<para>ToS URI</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#tos_uri">http://www.w3.org/ns/solid/oidc#tos_uri</seealso>
    let tos_uri = Prefixed_Name(oidc, "tos_uri") |> PrefixedName
    /// <summary>
    ///   <para>oidc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The OpenID Connect vocabulary used by the Solid-OIDC authentication specification.</para>
    /// labels<para>Solid OIDC</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#">http://www.w3.org/ns/solid/oidc#</seealso>
    let _prefix_iri = Prefixed_Name(oidc, "") |> PrefixedName
    /// <summary>
    ///   <para>oidc:client_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A name for this client that can be presented to an End-User</para>
    /// labels<para>client name</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/oidc#client_name">http://www.w3.org/ns/solid/oidc#client_name</seealso>
    let client_name = Prefixed_Name(oidc, "client_name") |> PrefixedName
