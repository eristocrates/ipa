namespace http.www.ifomis.org.bfo._1._1.span.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module span =
    let _namespace_iri = Namespace_Iri span |> NamespaceIRI
    /// <summary>
    ///   <para>span:ProcessualEntity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.ifomis.org/bfo/1.1/span#ProcessualEntity">http://www.ifomis.org/bfo/1.1/span#ProcessualEntity</seealso>
    let ProcessualEntity = Prefixed_Name(span, "ProcessualEntity") |> PrefixedName
