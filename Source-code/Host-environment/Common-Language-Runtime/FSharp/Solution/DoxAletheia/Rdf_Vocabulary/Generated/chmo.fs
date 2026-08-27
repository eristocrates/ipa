namespace http.purl.obolibrary.org.obo.CHMO_.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module chmo =
    let _namespace_iri = Namespace_Iri chmo |> NamespaceIRI
    /// <summary>
    ///   <para>cdao:CHMO_0000087</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fluorescence microscopy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CHMO_0000087">http://purl.obolibrary.org/obo/CHMO_0000087</seealso>
    let fluorescence_microscopy = Prefixed_Name(chmo, "0000087") |> PrefixedName

    /// <summary>
    ///   <para>cdao:CHMO_0000089</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"confocal fluorescence microscopy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CHMO_0000089">http://purl.obolibrary.org/obo/CHMO_0000089</seealso>
    let confocal_fluorescence_microscopy =
        Prefixed_Name(chmo, "0000089") |> PrefixedName

    /// <summary>
    ///   <para>cdao:CHMO_0000102</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"light microscopy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CHMO_0000102">http://purl.obolibrary.org/obo/CHMO_0000102</seealso>
    let light_microscopy = Prefixed_Name(chmo, "0000102") |> PrefixedName

    /// <summary>
    ///   <para>cdao:CHMO_0000701</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"liquid chromatography-tandem mass spectrometry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CHMO_0000701">http://purl.obolibrary.org/obo/CHMO_0000701</seealso>
    let liquid_chromatography_tandem_mass_spectrometry =
        Prefixed_Name(chmo, "0000701") |> PrefixedName
