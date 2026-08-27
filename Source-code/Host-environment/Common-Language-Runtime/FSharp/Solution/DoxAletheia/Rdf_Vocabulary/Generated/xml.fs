namespace http.www.w3.org.XML._1998._namespace.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module xml =
    let _namespace_iri = Namespace_Iri xml |> NamespaceIRI
    /// <summary>
    ///   <para>xml:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/XML/1998/namespace">http://www.w3.org/XML/1998/namespace</seealso>
    let _prefix_iri = Prefixed_Name(xml, "") |> PrefixedName
