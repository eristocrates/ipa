namespace http.open_multinet.info.ontology.omn_federation.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module omnfed =
    let _namespace_iri = Namespace_Iri omnfed |> NamespaceIRI
    /// <summary>
    ///   <para>omnfed:Federation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Federation</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-federation#Federation">http://open-multinet.info/ontology/omn-federation#Federation</seealso>
    let Federation = Prefixed_Name(omnfed, "Federation") |> PrefixedName
    /// <summary>
    ///   <para>omnfed:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-federation#">http://open-multinet.info/ontology/omn-federation#</seealso>
    let _prefix_iri = Prefixed_Name(omnfed, "") |> PrefixedName
    /// <summary>
    ///   <para>omnfed:FederationMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>member of a federation</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-federation#FederationMember">http://open-multinet.info/ontology/omn-federation#FederationMember</seealso>
    let FederationMember = Prefixed_Name(omnfed, "FederationMember") |> PrefixedName
    /// <summary>
    ///   <para>omnfed:Infrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>an infrastructure such as a testbed or cloud facility</para>
    ///   <para>Example: FUESCO Playground</para>
    /// labels<para>Infrastructure</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-federation#Infrastructure">http://open-multinet.info/ontology/omn-federation#Infrastructure</seealso>
    let Infrastructure = Prefixed_Name(omnfed, "Infrastructure") |> PrefixedName

    /// <summary>
    ///   <para>omnfed:hasFederationMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a federation can have an organization as a member</para>
    /// labels<para>has federation member</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-federation#hasFederationMember">http://open-multinet.info/ontology/omn-federation#hasFederationMember</seealso>
    let hasFederationMember =
        Prefixed_Name(omnfed, "hasFederationMember") |> PrefixedName

    /// <summary>
    ///   <para>omnfed:administers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>an organization (e.g. a federation member) administers its own infrastructure</para>
    /// labels<para>administers</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-federation#administers">http://open-multinet.info/ontology/omn-federation#administers</seealso>
    let administers = Prefixed_Name(omnfed, "administers") |> PrefixedName
    /// <summary>
    ///   <para>omnfed:isAdministeredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>an infrastructure can be administered by an organization (e.g. a federation member)</para>
    /// labels<para>is administered by</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-federation#isAdministeredBy">http://open-multinet.info/ontology/omn-federation#isAdministeredBy</seealso>
    let isAdministeredBy = Prefixed_Name(omnfed, "isAdministeredBy") |> PrefixedName
    /// <summary>
    ///   <para>omnfed:partOfFederation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>an organization can be part of a federation</para>
    /// labels<para>is part of federation</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-federation#partOfFederation">http://open-multinet.info/ontology/omn-federation#partOfFederation</seealso>
    let partOfFederation = Prefixed_Name(omnfed, "partOfFederation") |> PrefixedName
