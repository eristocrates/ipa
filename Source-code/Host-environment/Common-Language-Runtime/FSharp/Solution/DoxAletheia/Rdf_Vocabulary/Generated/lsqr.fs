namespace http.lsq.aksw.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lsqr =
    let _namespace_iri = Namespace_Iri lsqr |> NamespaceIRI
    /// <summary>
    ///   <para>lsqr:vocab</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://lsq.aksw.org/vocab">http://lsq.aksw.org/vocab</seealso>
    let vocab = Prefixed_Name(lsqr, "vocab") |> PrefixedName
