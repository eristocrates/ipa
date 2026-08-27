namespace http.purl.obolibrary.org.obo.OMIABIS_.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module omiabis =
    let _namespace_iri = Namespace_Iri omiabis |> NamespaceIRI
    /// <summary>
    ///   <para>cdao:OMIABIS_0000050</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed tissue specimen"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/OMIABIS_0000050">http://purl.obolibrary.org/obo/OMIABIS_0000050</seealso>
    let fixed_tissue_specimen = Prefixed_Name(omiabis, "0000050") |> PrefixedName
    /// <summary>
    ///   <para>cdao:OMIABIS_0000052</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed tissue slide specimen"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/OMIABIS_0000052">http://purl.obolibrary.org/obo/OMIABIS_0000052</seealso>
    let fixed_tissue_slide_specimen = Prefixed_Name(omiabis, "0000052") |> PrefixedName
