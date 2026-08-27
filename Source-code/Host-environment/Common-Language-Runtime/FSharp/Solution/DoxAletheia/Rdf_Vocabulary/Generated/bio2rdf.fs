namespace http.bio2rdf.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bio2rdf =
    let _namespace_iri = Namespace_Iri bio2rdf |> NamespaceIRI

    /// <summary>
    ///   <para>bio2rdf:uniprot_resource:Taxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://bio2rdf.org/uniprot_resource:Taxon">http://bio2rdf.org/uniprot_resource:Taxon</seealso>
    let ``uniprot_resource:Taxon`` =
        Prefixed_Name(bio2rdf, "uniprot_resource:Taxon") |> PrefixedName
