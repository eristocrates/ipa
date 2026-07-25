namespace https.w3id.org.mdo.full.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mdofull =
    let _namespace_iri = Namespace_Iri mdofull |> NamespaceIRI
    /// <summary>
    ///   <para>mdofull:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This is the Materials Design Ontology.</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mdo/full/">https://w3id.org/mdo/full/</seealso>
    let _prefix_iri = Prefixed_Name(mdofull, "") |> PrefixedName
    /// <summary>
    ///   <para>mdofull:1.0/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/mdo/full/1.0/">https://w3id.org/mdo/full/1.0/</seealso>
    let ``_1.0/`` = Prefixed_Name(mdofull, "1.0/") |> PrefixedName
