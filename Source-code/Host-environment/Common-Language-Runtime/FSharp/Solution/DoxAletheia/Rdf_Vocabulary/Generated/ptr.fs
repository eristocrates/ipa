namespace http.www.w3.org._2009.pointers.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ptr =
    let _namespace_iri = Namespace_Iri ptr |> NamespaceIRI
    /// <summary>
    ///   <para>ptr:Pointer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2009/pointers#Pointer">http://www.w3.org/2009/pointers#Pointer</seealso>
    let Pointer = Prefixed_Name(ptr, "Pointer") |> PrefixedName
