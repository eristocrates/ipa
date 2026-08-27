namespace http.sweet.jpl.nasa.gov._2._3.propSpeed.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pspeed =
    let _namespace_iri = Namespace_Iri pspeed |> NamespaceIRI
    /// <summary>
    ///   <para>pspeed:Speed</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/propSpeed.owl#Speed">http://sweet.jpl.nasa.gov/2.3/propSpeed.owl#Speed</seealso>
    let Speed = Prefixed_Name(pspeed, "Speed") |> PrefixedName
    /// <summary>
    ///   <para>pspeed:Velocity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/propSpeed.owl#Velocity">http://sweet.jpl.nasa.gov/2.3/propSpeed.owl#Velocity</seealso>
    let Velocity = Prefixed_Name(pspeed, "Velocity") |> PrefixedName
