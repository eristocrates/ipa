namespace http.sarif.info.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sarif =
    let _namespace_iri = Namespace_Iri sarif |> NamespaceIRI
    /// <summary>
    ///   <para>sarif:Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://sarif.info/Result">http://sarif.info/Result</seealso>
    let Result = Prefixed_Name(sarif, "Result") |> PrefixedName
