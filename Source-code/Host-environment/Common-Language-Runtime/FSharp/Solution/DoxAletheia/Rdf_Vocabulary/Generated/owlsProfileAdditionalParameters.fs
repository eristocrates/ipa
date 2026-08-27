namespace http.www.daml.org.services.owl_s._1._2.ProfileAdditionalParameters.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owlsProfileAdditionalParameters =
    let _namespace_iri = Namespace_Iri owlsProfileAdditionalParameters |> NamespaceIRI

    /// <summary>
    ///   <para>owlsProfileAdditionalParameters:AverageResponseTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#AverageResponseTime">http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#AverageResponseTime</seealso>
    let AverageResponseTime =
        Prefixed_Name(owlsProfileAdditionalParameters, "AverageResponseTime") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfileAdditionalParameters:Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#Duration">http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#Duration</seealso>
    let Duration =
        Prefixed_Name(owlsProfileAdditionalParameters, "Duration") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfileAdditionalParameters:GeographicRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#GeographicRadius">http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#GeographicRadius</seealso>
    let GeographicRadius =
        Prefixed_Name(owlsProfileAdditionalParameters, "GeographicRadius") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfileAdditionalParameters:MaxResponseTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#MaxResponseTime">http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#MaxResponseTime</seealso>
    let MaxResponseTime =
        Prefixed_Name(owlsProfileAdditionalParameters, "MaxResponseTime") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfileAdditionalParameters:NAICS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///       Hook to the NAICS taxonomy
    ///     "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#NAICS">http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#NAICS</seealso>
    let NAICS = Prefixed_Name(owlsProfileAdditionalParameters, "NAICS") |> PrefixedName

    /// <summary>
    ///   <para>owlsProfileAdditionalParameters:UNSPSC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///       Hook to the UNSPSC taxonomy
    ///       "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#UNSPSC">http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#UNSPSC</seealso>
    let UNSPSC =
        Prefixed_Name(owlsProfileAdditionalParameters, "UNSPSC") |> PrefixedName
