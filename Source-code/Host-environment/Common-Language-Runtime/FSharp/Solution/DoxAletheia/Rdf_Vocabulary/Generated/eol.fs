namespace http.purl.org.biodiversity.eol.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eol =
    let _namespace_iri = Namespace_Iri eol |> NamespaceIRI
    /// <summary>
    ///   <para>eol:Taxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biodiversity/eol/Taxon">http://purl.org/biodiversity/eol/Taxon</seealso>
    let Taxon = Prefixed_Name(eol, "Taxon") |> PrefixedName
    /// <summary>
    ///   <para>eol:authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biodiversity/eol/authority">http://purl.org/biodiversity/eol/authority</seealso>
    let authority = Prefixed_Name(eol, "authority") |> PrefixedName
    /// <summary>
    ///   <para>eol:scientificName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biodiversity/eol/scientificName">http://purl.org/biodiversity/eol/scientificName</seealso>
    let scientificName = Prefixed_Name(eol, "scientificName") |> PrefixedName
