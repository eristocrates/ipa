namespace http.sweet.jpl.nasa.gov._2._3.reprMathOperation.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mathop =
    let _namespace_iri = Namespace_Iri mathop |> NamespaceIRI
    /// <summary>
    ///   <para>mathop:Ratio</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/reprMathOperation.owl#Ratio">http://sweet.jpl.nasa.gov/2.3/reprMathOperation.owl#Ratio</seealso>
    let Ratio = Prefixed_Name(mathop, "Ratio") |> PrefixedName
