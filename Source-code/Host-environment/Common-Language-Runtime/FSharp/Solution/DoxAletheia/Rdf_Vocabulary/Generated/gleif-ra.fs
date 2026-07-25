namespace https.www.gleif.org.ontology.RegistrationAuthority.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gleif_ra =
    let _namespace_iri = Namespace_Iri gleif_ra |> NamespaceIRI
    /// <summary>
    ///   <para>gleif-ra:BusinessRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>business registry</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/RegistrationAuthority/BusinessRegistry">https://www.gleif.org/ontology/RegistrationAuthority/BusinessRegistry</seealso>
    let BusinessRegistry = Prefixed_Name(gleif_ra, "BusinessRegistry") |> PrefixedName
    /// <summary>
    ///   <para>gleif-ra:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///
    /// labels<para>GLEIF Registration Authority Ontology</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/RegistrationAuthority/">https://www.gleif.org/ontology/RegistrationAuthority/</seealso>
    let _prefix_iri = Prefixed_Name(gleif_ra, "") |> PrefixedName
    /// <summary>
    ///   <para>gleif-ra:RAregistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-base:Registry</para>
    ///
    /// labels<para>RA registry</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/RegistrationAuthority/RAregistry">https://www.gleif.org/ontology/RegistrationAuthority/RAregistry</seealso>
    let RAregistry = Prefixed_Name(gleif_ra, "RAregistry") |> PrefixedName

    /// <summary>
    ///   <para>gleif-ra:RegistrationAuthorityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>registration authority code</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/RegistrationAuthority/RegistrationAuthorityCode">https://www.gleif.org/ontology/RegistrationAuthority/RegistrationAuthorityCode</seealso>
    let RegistrationAuthorityCode =
        Prefixed_Name(gleif_ra, "RegistrationAuthorityCode") |> PrefixedName
