namespace http.schemas.talis.com._2005.dir.schema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dir =
    let _namespace_iri = Namespace_Iri dir |> NamespaceIRI
    /// <summary>
    ///   <para>dir:etag</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schemas.talis.com/2005/dir/schema#etag">http://schemas.talis.com/2005/dir/schema#etag</seealso>
    let etag = Prefixed_Name(dir, "etag") |> PrefixedName
