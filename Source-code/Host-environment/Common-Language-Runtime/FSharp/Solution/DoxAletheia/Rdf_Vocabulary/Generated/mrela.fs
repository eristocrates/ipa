namespace http.sweet.jpl.nasa.gov._2._3.relaMath.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mrela =
    let _namespace_iri = Namespace_Iri mrela |> NamespaceIRI
    /// <summary>
    ///   <para>mrela:hasOperand</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/relaMath.owl#hasOperand">http://sweet.jpl.nasa.gov/2.3/relaMath.owl#hasOperand</seealso>
    let hasOperand = Prefixed_Name(mrela, "hasOperand") |> PrefixedName
    /// <summary>
    ///   <para>mrela:hasScalingNumber</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/relaMath.owl#hasScalingNumber">http://sweet.jpl.nasa.gov/2.3/relaMath.owl#hasScalingNumber</seealso>
    let hasScalingNumber = Prefixed_Name(mrela, "hasScalingNumber") |> PrefixedName
    /// <summary>
    ///   <para>mrela:toThePower</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/relaMath.owl#toThePower">http://sweet.jpl.nasa.gov/2.3/relaMath.owl#toThePower</seealso>
    let toThePower = Prefixed_Name(mrela, "toThePower") |> PrefixedName
