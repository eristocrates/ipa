namespace http.eulersharp.sourceforge.net._2003._03swap.bioSKOSSchemes.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bioskos =
    let _namespace_iri = Namespace_Iri bioskos |> NamespaceIRI
    /// <summary>
    ///   <para>bioskos:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#">http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#</seealso>
    let _prefix_iri = Prefixed_Name(bioskos, "") |> PrefixedName
    /// <summary>
    ///   <para>bioskos:uniProtTaxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>"Taxonomy in UniProt (universal protein resource) of a consortium comprising the European Bioinformatics Institute (EBI), the Swiss Institute of Bioinformatics (SIB), and the Protein Information Resource (PIR). Formerly known as 'New EBI Web Taxonomy (NEWT)'."</para>
    /// labels<para>"UniProt taxonomy"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#uniProtTaxonomy">http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#uniProtTaxonomy</seealso>
    let uniProtTaxonomy = Prefixed_Name(bioskos, "uniProtTaxonomy") |> PrefixedName
    /// <summary>
    ///   <para>bioskos:uniProtTaxonomyDT</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"UniProt taxonomy datatype"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#uniProtTaxonomyDT">http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#uniProtTaxonomyDT</seealso>
    let uniProtTaxonomyDT = Prefixed_Name(bioskos, "uniProtTaxonomyDT") |> PrefixedName
