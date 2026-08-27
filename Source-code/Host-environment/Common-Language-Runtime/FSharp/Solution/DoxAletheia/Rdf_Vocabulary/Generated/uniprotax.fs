namespace http.purl.uniprot.org.taxonomy.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module uniprotax =
    let _namespace_iri = Namespace_Iri uniprotax |> NamespaceIRI
    /// <summary>
    ///   <para>uniprotax:9606</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.uniprot.org/taxonomy/9606">http://purl.uniprot.org/taxonomy/9606</seealso>
    let _9606 = Prefixed_Name(uniprotax, "9606") |> PrefixedName
