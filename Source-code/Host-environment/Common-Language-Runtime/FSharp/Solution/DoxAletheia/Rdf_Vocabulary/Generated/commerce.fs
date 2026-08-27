namespace http.purl.org.commerce.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module commerce =
    let _namespace_iri = Namespace_Iri commerce |> NamespaceIRI
    /// <summary>
    ///   <para>commerce:costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A link to a
    ///             method of paying for a full version of the media recording."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/commerce#costs">http://purl.org/commerce#costs</seealso>
    let costs = Prefixed_Name(commerce, "costs") |> PrefixedName
    /// <summary>
    ///   <para>commerce:payment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A link to a
    ///             method of paying for a full version of the media recording."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/commerce#payment">http://purl.org/commerce#payment</seealso>
    let payment = Prefixed_Name(commerce, "payment") |> PrefixedName
