namespace http.vocab.getty.edu.ulan.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ulan =
    let _namespace_iri = Namespace_Iri ulan |> NamespaceIRI
    /// <summary>
    ///   <para>ulan:</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Union List of Artist Names concept scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Union List of Artist Names"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ulan/">http://vocab.getty.edu/ulan/</seealso>
    let _prefix_iri = Prefixed_Name(ulan, "") |> PrefixedName
