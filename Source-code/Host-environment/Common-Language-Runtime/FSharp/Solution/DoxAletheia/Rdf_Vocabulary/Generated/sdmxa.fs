namespace http.purl.org.linked_data.sdmx._2009.attribute.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sdmxa =
    let _namespace_iri = Namespace_Iri sdmxa |> NamespaceIRI
    /// <summary>
    ///   <para>sdmxa:unitMeasure</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/attribute#unitMeasure">http://purl.org/linked-data/sdmx/2009/attribute#unitMeasure</seealso>
    let unitMeasure = Prefixed_Name(sdmxa, "unitMeasure") |> PrefixedName
