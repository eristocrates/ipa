namespace http.sweet.jpl.nasa.gov._2._3.propMass.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pmass =
    let _namespace_iri = Namespace_Iri pmass |> NamespaceIRI
    /// <summary>
    ///   <para>pmass:Mass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/propMass.owl#Mass">http://sweet.jpl.nasa.gov/2.3/propMass.owl#Mass</seealso>
    let Mass = Prefixed_Name(pmass, "Mass") |> PrefixedName
