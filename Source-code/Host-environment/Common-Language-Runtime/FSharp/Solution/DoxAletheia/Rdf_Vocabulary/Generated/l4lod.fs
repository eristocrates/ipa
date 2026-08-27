namespace http.ns.inria.fr.l4lod.v2.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module l4lod =
    let _namespace_iri = Namespace_Iri l4lod |> NamespaceIRI
    /// <summary>
    ///   <para>l4lod:l4lod_v2.rdf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/l4lod/v2/l4lod_v2.rdf">http://ns.inria.fr/l4lod/v2/l4lod_v2.rdf</seealso>
    let ``l4lod_v2.rdf`` = Prefixed_Name(l4lod, "l4lod_v2.rdf") |> PrefixedName
