namespace http.sweet.jpl.nasa.gov._2._3.statePhysical.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module state =
    let _namespace_iri = Namespace_Iri state |> NamespaceIRI
    /// <summary>
    ///   <para>state:Solid</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/statePhysical.owl#Solid">http://sweet.jpl.nasa.gov/2.3/statePhysical.owl#Solid</seealso>
    let Solid = Prefixed_Name(state, "Solid") |> PrefixedName
