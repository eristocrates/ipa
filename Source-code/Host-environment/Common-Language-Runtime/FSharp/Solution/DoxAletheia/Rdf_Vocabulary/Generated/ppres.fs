namespace http.sweet.jpl.nasa.gov._2._3.propPressure.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ppres =
    let _namespace_iri = Namespace_Iri ppres |> NamespaceIRI
    /// <summary>
    ///   <para>ppres:Pressure</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/propPressure.owl#Pressure">http://sweet.jpl.nasa.gov/2.3/propPressure.owl#Pressure</seealso>
    let Pressure = Prefixed_Name(ppres, "Pressure") |> PrefixedName
