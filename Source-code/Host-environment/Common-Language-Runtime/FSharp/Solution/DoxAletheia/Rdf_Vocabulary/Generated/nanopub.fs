namespace http.www.nanopub.org.nschema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nanopub =
    let _namespace_iri = Namespace_Iri nanopub |> NamespaceIRI
    /// <summary>
    ///   <para>nanopub:PublicationInfo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.nanopub.org/nschema#PublicationInfo">http://www.nanopub.org/nschema#PublicationInfo</seealso>
    let PublicationInfo = Prefixed_Name(nanopub, "PublicationInfo") |> PrefixedName
    /// <summary>
    ///   <para>nanopub:hasProvenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.nanopub.org/nschema#hasProvenance">http://www.nanopub.org/nschema#hasProvenance</seealso>
    let hasProvenance = Prefixed_Name(nanopub, "hasProvenance") |> PrefixedName
    /// <summary>
    ///   <para>nanopub:Nanopublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.nanopub.org/nschema#Nanopublication">http://www.nanopub.org/nschema#Nanopublication</seealso>
    let Nanopublication = Prefixed_Name(nanopub, "Nanopublication") |> PrefixedName
    /// <summary>
    ///   <para>nanopub:Provenance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.nanopub.org/nschema#Provenance">http://www.nanopub.org/nschema#Provenance</seealso>
    let Provenance = Prefixed_Name(nanopub, "Provenance") |> PrefixedName

    /// <summary>
    ///   <para>nanopub:hasPublicationInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.nanopub.org/nschema#hasPublicationInfo">http://www.nanopub.org/nschema#hasPublicationInfo</seealso>
    let hasPublicationInfo =
        Prefixed_Name(nanopub, "hasPublicationInfo") |> PrefixedName

    /// <summary>
    ///   <para>nanopub:hasAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.nanopub.org/nschema#hasAssertion">http://www.nanopub.org/nschema#hasAssertion</seealso>
    let hasAssertion = Prefixed_Name(nanopub, "hasAssertion") |> PrefixedName
    /// <summary>
    ///   <para>nanopub:Assertion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.nanopub.org/nschema#Assertion">http://www.nanopub.org/nschema#Assertion</seealso>
    let Assertion = Prefixed_Name(nanopub, "Assertion") |> PrefixedName
