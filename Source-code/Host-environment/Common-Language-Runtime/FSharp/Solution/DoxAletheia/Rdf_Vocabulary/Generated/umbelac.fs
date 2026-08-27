namespace http.umbel.org.umbel.ac.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module umbelac =
    let _namespace_iri = Namespace_Iri umbelac |> NamespaceIRI

    /// <summary>
    ///   <para>umbelac:LiquidTangibleThing</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://umbel.org/umbel/ac/LiquidTangibleThing">http://umbel.org/umbel/ac/LiquidTangibleThing</seealso>
    let LiquidTangibleThing =
        Prefixed_Name(umbelac, "LiquidTangibleThing") |> PrefixedName
