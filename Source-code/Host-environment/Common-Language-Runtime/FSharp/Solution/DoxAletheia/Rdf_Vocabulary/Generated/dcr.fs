namespace http.www.isocat.org.ns.dcr.rdf.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcr =
    let _namespace_iri = Namespace_Iri dcr |> NamespaceIRI
    /// <summary>
    ///   <para>dcr:datcat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.isocat.org/ns/dcr.rdf#datcat">http://www.isocat.org/ns/dcr.rdf#datcat</seealso>
    let datcat = Prefixed_Name(dcr, "datcat") |> PrefixedName
