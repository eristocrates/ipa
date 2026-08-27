namespace http.www.ontologydesignpatterns.org.cp.owl.timeindexedsituation.owl.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tis =
    let _namespace_iri = Namespace_Iri tis |> NamespaceIRI
    /// <summary>
    ///   <para>tis:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"A generic pattern usable for all situations that require a temporal indexing."^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl">http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl</seealso>
    let _prefix_iri = Prefixed_Name(tis, "") |> PrefixedName
