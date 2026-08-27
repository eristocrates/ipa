namespace http.purl.org.NET.biol.zoology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module zoology =
    let _namespace_iri = Namespace_Iri zoology |> NamespaceIRI
    /// <summary>
    ///   <para>zoology:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/NET/biol/zoology#">http://purl.org/NET/biol/zoology#</seealso>
    let _prefix_iri = Prefixed_Name(zoology, "") |> PrefixedName
