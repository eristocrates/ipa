namespace http.vocab.getty.edu.tgn.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tgn =
    let _namespace_iri = Namespace_Iri tgn |> NamespaceIRI
    /// <summary>
    ///   <para>tgn:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>"The Thesaurus of Geographic Names concept scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thesaurus of Geographic Names"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.getty.edu/tgn/">http://vocab.getty.edu/tgn/</seealso>
    let _prefix_iri = Prefixed_Name(tgn, "") |> PrefixedName
