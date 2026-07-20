namespace http.eulersharp.sourceforge.net._2003._03swap.bioSKOSSchemes.hash

open DoxAletheia

module bioskos =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Taxonomy in UniProt (universal protein resource) of a consortium comprising the European Bioinformatics Institute (EBI), the Swiss Institute of Bioinformatics (SIB), and the Protein Information Resource (PIR). Formerly known as 'New EBI Web Taxonomy (NEWT)'.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#uniProtTaxonomy"></see></summary>
    let uniProtTaxonomy = _prefix "uniProtTaxonomy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#uniProtTaxonomyDT"></see>
    /// </summary>
    let uniProtTaxonomyDT = _prefix "uniProtTaxonomyDT"
