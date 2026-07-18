namespace http.eulersharp.sourceforge.net._2003._03swap.bioSKOSSchemes.hash

open DoxAletheia.Rdf_Vocabulary

module bioskos =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#"

    /// <summary>
    /// Taxonomy in UniProt (universal protein resource) of a consortium comprising the European Bioinformatics Institute (EBI), the Swiss Institute of Bioinformatics (SIB), and the Protein Information Resource (PIR). Formerly known as 'New EBI Web Taxonomy (NEWT)'.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#uniProtTaxonomy"></see></summary>
    let uniProtTaxonomy =
        Namespaced_IRI.parse _namespace_name "uniProtTaxonomy" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#uniProtTaxonomyDT"></see>
    /// </summary>
    let uniProtTaxonomyDT =
        Namespaced_IRI.parse _namespace_name "uniProtTaxonomyDT" |> NamespacedName
