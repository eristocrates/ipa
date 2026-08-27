namespace http.sweet.jpl.nasa.gov._2._3.propSpaceDistance.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pdist =
    let _namespace_iri = Namespace_Iri pdist |> NamespaceIRI
    /// <summary>
    ///   <para>pdist:Length</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/propSpaceDistance.owl#Length">http://sweet.jpl.nasa.gov/2.3/propSpaceDistance.owl#Length</seealso>
    let Length = Prefixed_Name(pdist, "Length") |> PrefixedName
