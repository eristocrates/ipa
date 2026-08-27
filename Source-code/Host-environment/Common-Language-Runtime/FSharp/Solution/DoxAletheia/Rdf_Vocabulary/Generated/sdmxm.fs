namespace http.purl.org.linked_data.sdmx._2009.measure.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sdmxm =
    let _namespace_iri = Namespace_Iri sdmxm |> NamespaceIRI
    /// <summary>
    ///   <para>sdmxm:obsValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/measure#obsValue">http://purl.org/linked-data/sdmx/2009/measure#obsValue</seealso>
    let obsValue = Prefixed_Name(sdmxm, "obsValue") |> PrefixedName
