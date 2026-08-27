namespace http.www.w3.org._2005.xpath_functions.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fn =
    let _namespace_iri = Namespace_Iri fn |> NamespaceIRI
    /// <summary>
    ///   <para>fn:string-length</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2005/xpath-functions#string-length">http://www.w3.org/2005/xpath-functions#string-length</seealso>
    let string_length = Prefixed_Name(fn, "string-length") |> PrefixedName
