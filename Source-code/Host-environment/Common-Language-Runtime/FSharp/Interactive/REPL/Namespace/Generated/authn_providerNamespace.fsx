#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module authn_provider =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/inrupt/namespace/vocab/authn_provider/" "authn_provider"

    let _namespaceIri = _prefixId.prefix ""
    let ``_1.0.0`` = _prefixId.prefix "1.0.0"
    /// <summary>
    ///   <para>dcterms:issued : 2023-06-14^^xsd:date</para>
    ///   <para>rdfs:label : Authentication Provider</para>
    ///   <para>rdfs:comment : An authentication provider.</para>
    ///   <a href="https://w3id.org/inrupt/namespace/vocab/authn_provider/AuthenticationProvider">authn_provider:AuthenticationProvider</a>
    /// </summary>
    let AuthenticationProvider = _prefixId.prefix "AuthenticationProvider"
    /// <summary>
    ///   <para>dcterms:issued : 2023-06-14^^xsd:date</para>
    ///   <para>rdfs:label : Authentication Provider</para>
    ///   <para>rdfs:comment : Refers to an authentication provider.</para>
    ///   <a href="https://w3id.org/inrupt/namespace/vocab/authn_provider/hasAuthenticationProvider">authn_provider:hasAuthenticationProvider</a>
    /// </summary>
    let hasAuthenticationProvider = _prefixId.prefix "hasAuthenticationProvider"
    /// <summary>
    ///   <para>dcterms:issued : 2023-06-14^^xsd:date</para>
    ///   <para>rdfs:label : MFA enabled</para>
    ///   <para>rdfs:comment : Has multi-factor authentication (MFA) been enabled?</para>
    ///   <a href="https://w3id.org/inrupt/namespace/vocab/authn_provider/hasMfaEnabled">authn_provider:hasMfaEnabled</a>
    /// </summary>
    let hasMfaEnabled = _prefixId.prefix "hasMfaEnabled"
    /// <summary>
    ///   <para>dcterms:issued : 2023-06-14^^xsd:date</para>
    ///   <para>rdfs:label : MFA enforced</para>
    ///   <para>rdfs:comment : Has multi-factor authentication (MFA) been enforced?</para>
    ///   <a href="https://w3id.org/inrupt/namespace/vocab/authn_provider/hasMfaEnforced">authn_provider:hasMfaEnforced</a>
    /// </summary>
    let hasMfaEnforced = _prefixId.prefix "hasMfaEnforced"
