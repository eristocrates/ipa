namespace https.spdx.org.rdf._3._1.terms.Service.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ns8 =
    let _namespace_iri = Namespace_Iri ns8 |> NamespaceIRI

    /// <summary>
    ///   <para>spdx:Service/AuthenticationProtocolType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Protocols which support authentication."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType">https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType</seealso>
    let AuthenticationProtocolType =
        Prefixed_Name(ns8, "AuthenticationProtocolType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/AuthenticationProtocolType/crl</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Service/AuthenticationProtocolType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Certificate Revocation List, or CRL, is a list of revoked certificates that is downloaded from the Certificate Authority (CA)."</para>
    /// labels<para>"crl"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/crl">https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/crl</seealso>
    let ``AuthenticationProtocolType/crl`` =
        Prefixed_Name(ns8, "AuthenticationProtocolType/crl") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/AuthenticationProtocolType/ocsp</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Service/AuthenticationProtocolType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Online Certificate Status Protocol, or OCSP, is a common scheme used to maintain the security of a server and other network resources."</para>
    /// labels<para>"ocsp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/ocsp">https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/ocsp</seealso>
    let ``AuthenticationProtocolType/ocsp`` =
        Prefixed_Name(ns8, "AuthenticationProtocolType/ocsp") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/AuthenticationProtocolType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Service/AuthenticationProtocolType</para>
    ///   <para>"An authentication protocol not covered by one of the other AuthenticationProtocolTypes."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/other">https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/other</seealso>
    let ``AuthenticationProtocolType/other`` =
        Prefixed_Name(ns8, "AuthenticationProtocolType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/AuthenticationProtocolType/tls</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Service/AuthenticationProtocolType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Transport Layer Security, or TLS, is a widely adopted security protocol designed to facilitate privacy and data security for communications over the Internet."</para>
    /// labels<para>"tls"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/tls">https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/tls</seealso>
    let ``AuthenticationProtocolType/tls`` =
        Prefixed_Name(ns8, "AuthenticationProtocolType/tls") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/SoftwareService</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Software provided as a service over a network."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/SoftwareService">https://spdx.org/rdf/3.1/terms/Service/SoftwareService</seealso>
    let SoftwareService = Prefixed_Name(ns8, "SoftwareService") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Service/provider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The provider of a SoftwareService."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/provider">https://spdx.org/rdf/3.1/terms/Service/provider</seealso>
    let provider = Prefixed_Name(ns8, "provider") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/serverAuthenticationProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Authentication protocol used by a server."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/serverAuthenticationProtocol">https://spdx.org/rdf/3.1/terms/Service/serverAuthenticationProtocol</seealso>
    let serverAuthenticationProtocol =
        Prefixed_Name(ns8, "serverAuthenticationProtocol") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/serviceHostingCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies a country code where a software service is hosted."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/serviceHostingCountry">https://spdx.org/rdf/3.1/terms/Service/serviceHostingCountry</seealso>
    let serviceHostingCountry =
        Prefixed_Name(ns8, "serviceHostingCountry") |> PrefixedName
