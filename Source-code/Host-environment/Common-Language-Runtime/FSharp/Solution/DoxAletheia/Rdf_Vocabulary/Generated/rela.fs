namespace http.sweet.jpl.nasa.gov._2._3.rela.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rela =
    let _namespace_iri = Namespace_Iri rela |> NamespaceIRI
    /// <summary>
    ///   <para>rela:hasState</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/rela.owl#hasState">http://sweet.jpl.nasa.gov/2.3/rela.owl#hasState</seealso>
    let hasState = Prefixed_Name(rela, "hasState") |> PrefixedName
