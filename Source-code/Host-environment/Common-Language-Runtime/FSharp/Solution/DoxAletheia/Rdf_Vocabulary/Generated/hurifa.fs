namespace http.www.agfa.com.w3c._2009.humanRiskFactors.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hurifa =
    let _namespace_iri = Namespace_Iri hurifa |> NamespaceIRI
    /// <summary>
    ///   <para>hurifa:RiskFactor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.agfa.com/w3c/2009/humanRiskFactors#RiskFactor">http://www.agfa.com/w3c/2009/humanRiskFactors#RiskFactor</seealso>
    let RiskFactor = Prefixed_Name(hurifa, "RiskFactor") |> PrefixedName
