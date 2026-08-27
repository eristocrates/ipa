namespace http.purl.org.ontomedia.ext.common.being.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module omb =
    let _namespace_iri = Namespace_Iri omb |> NamespaceIRI
    /// <summary>
    ///   <para>omb:Character</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontomedia/ext/common/being#Character">http://purl.org/ontomedia/ext/common/being#Character</seealso>
    let Character = Prefixed_Name(omb, "Character") |> PrefixedName
