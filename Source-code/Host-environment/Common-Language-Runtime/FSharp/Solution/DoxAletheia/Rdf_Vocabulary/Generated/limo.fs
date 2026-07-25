namespace http.purl.org.limo_ontology.limo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module limo =
    let _namespace_iri = Namespace_Iri limo |> NamespaceIRI
    /// <summary>
    ///   <para>limo:limo.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/limo-ontology/limo/limo.html">http://purl.org/limo-ontology/limo/limo.html</seealso>
    let ``limo.html`` = Prefixed_Name(limo, "limo.html") |> PrefixedName
    /// <summary>
    ///   <para>limo:limo#Model</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/limo-ontology/limo/limo#Model">http://purl.org/limo-ontology/limo/limo#Model</seealso>
    let ``limo#Model`` = Prefixed_Name(limo, "limo#Model") |> PrefixedName
    /// <summary>
    ///   <para>limo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/limo-ontology/limo/">http://purl.org/limo-ontology/limo/</seealso>
    let _prefix_iri = Prefixed_Name(limo, "") |> PrefixedName
