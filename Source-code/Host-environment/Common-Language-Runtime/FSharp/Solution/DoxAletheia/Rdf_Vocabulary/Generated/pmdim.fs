namespace http.sweet.jpl.nasa.gov._2._3.propSpaceMultidimensional.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pmdim =
    let _namespace_iri = Namespace_Iri pmdim |> NamespaceIRI
    /// <summary>
    ///   <para>pmdim:Area</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/propSpaceMultidimensional.owl#Area">http://sweet.jpl.nasa.gov/2.3/propSpaceMultidimensional.owl#Area</seealso>
    let Area = Prefixed_Name(pmdim, "Area") |> PrefixedName
    /// <summary>
    ///   <para>pmdim:Volume</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/propSpaceMultidimensional.owl#Volume">http://sweet.jpl.nasa.gov/2.3/propSpaceMultidimensional.owl#Volume</seealso>
    let Volume = Prefixed_Name(pmdim, "Volume") |> PrefixedName
