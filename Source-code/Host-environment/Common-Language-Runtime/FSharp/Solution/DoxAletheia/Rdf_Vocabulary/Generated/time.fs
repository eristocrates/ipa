namespace http.sweet.jpl.nasa.gov._2._3.propTime.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module time =
    let _namespace_iri = Namespace_Iri time |> NamespaceIRI
    /// <summary>
    ///   <para>time:Time</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/propTime.owl#Time">http://sweet.jpl.nasa.gov/2.3/propTime.owl#Time</seealso>
    let Time = Prefixed_Name(time, "Time") |> PrefixedName
