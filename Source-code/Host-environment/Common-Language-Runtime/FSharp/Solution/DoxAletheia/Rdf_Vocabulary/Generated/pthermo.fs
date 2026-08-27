namespace http.sweet.jpl.nasa.gov._2._3.propTemperature.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pthermo =
    let _namespace_iri = Namespace_Iri pthermo |> NamespaceIRI
    /// <summary>
    ///   <para>pthermo:Temperature</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/propTemperature.owl#Temperature">http://sweet.jpl.nasa.gov/2.3/propTemperature.owl#Temperature</seealso>
    let Temperature = Prefixed_Name(pthermo, "Temperature") |> PrefixedName
