namespace https.w3id.org.inrupt._namespace.vocab.authn_provider.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module authn_provider =
    let _namespace_iri = Namespace_Iri authn_provider |> NamespaceIRI
    /// <summary>
    ///   <para>authn_provider:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/inrupt/namespace/vocab/authn_provider/">https://w3id.org/inrupt/namespace/vocab/authn_provider/</seealso>
    let _prefix_iri = Prefixed_Name(authn_provider, "") |> PrefixedName
    /// <summary>
    ///   <para>authn_provider:1.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/inrupt/namespace/vocab/authn_provider/1.0.0">https://w3id.org/inrupt/namespace/vocab/authn_provider/1.0.0</seealso>
    let ``_1.0.0`` = Prefixed_Name(authn_provider, "1.0.0") |> PrefixedName

    /// <summary>
    ///   <para>authn_provider:AuthenticationProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An authentication provider.</para>
    /// labels<para>Authentication Provider</para></remarks>
    /// <seealso href="https://w3id.org/inrupt/namespace/vocab/authn_provider/AuthenticationProvider">https://w3id.org/inrupt/namespace/vocab/authn_provider/AuthenticationProvider</seealso>
    let AuthenticationProvider =
        Prefixed_Name(authn_provider, "AuthenticationProvider") |> PrefixedName

    /// <summary>
    ///   <para>authn_provider:hasAuthenticationProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Refers to an authentication provider.</para>
    /// labels<para>Authentication Provider</para></remarks>
    /// <seealso href="https://w3id.org/inrupt/namespace/vocab/authn_provider/hasAuthenticationProvider">https://w3id.org/inrupt/namespace/vocab/authn_provider/hasAuthenticationProvider</seealso>
    let hasAuthenticationProvider =
        Prefixed_Name(authn_provider, "hasAuthenticationProvider") |> PrefixedName

    /// <summary>
    ///   <para>authn_provider:hasMfaEnabled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Has multi-factor authentication (MFA) been enabled?</para>
    /// labels<para>MFA enabled</para></remarks>
    /// <seealso href="https://w3id.org/inrupt/namespace/vocab/authn_provider/hasMfaEnabled">https://w3id.org/inrupt/namespace/vocab/authn_provider/hasMfaEnabled</seealso>
    let hasMfaEnabled = Prefixed_Name(authn_provider, "hasMfaEnabled") |> PrefixedName
    /// <summary>
    ///   <para>authn_provider:hasMfaEnforced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Has multi-factor authentication (MFA) been enforced?</para>
    /// labels<para>MFA enforced</para></remarks>
    /// <seealso href="https://w3id.org/inrupt/namespace/vocab/authn_provider/hasMfaEnforced">https://w3id.org/inrupt/namespace/vocab/authn_provider/hasMfaEnforced</seealso>
    let hasMfaEnforced = Prefixed_Name(authn_provider, "hasMfaEnforced") |> PrefixedName
