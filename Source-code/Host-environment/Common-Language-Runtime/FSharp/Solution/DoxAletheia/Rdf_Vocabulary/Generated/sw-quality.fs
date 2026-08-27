namespace https.w3id.org.squap.SoftwareQuality.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sw_quality =
    let _namespace_iri = Namespace_Iri sw_quality |> NamespaceIRI

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/AccessibilityInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Accessibility in use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/AccessibilityInUse">https://w3id.org/squap/SoftwareQuality/AccessibilityInUse</seealso>
    let AccessibilityInUse =
        Prefixed_Name(sw_quality, "AccessibilityInUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Accountability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Accountability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Accountability">https://w3id.org/squap/SoftwareQuality/Accountability</seealso>
    let Accountability = Prefixed_Name(sw_quality, "Accountability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Accuracy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Accuracy">https://w3id.org/squap/SoftwareQuality/Accuracy</seealso>
    let Accuracy = Prefixed_Name(sw_quality, "Accuracy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Adaptability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Adaptability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Adaptability">https://w3id.org/squap/SoftwareQuality/Adaptability</seealso>
    let Adaptability = Prefixed_Name(sw_quality, "Adaptability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Analysability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Analysability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Analysability">https://w3id.org/squap/SoftwareQuality/Analysability</seealso>
    let Analysability = Prefixed_Name(sw_quality, "Analysability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Appropriateness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Appropriateness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Appropriateness">https://w3id.org/squap/SoftwareQuality/Appropriateness</seealso>
    let Appropriateness = Prefixed_Name(sw_quality, "Appropriateness") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/AppropriatenessRecognisability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Appropriateness recognisability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/AppropriatenessRecognisability">https://w3id.org/squap/SoftwareQuality/AppropriatenessRecognisability</seealso>
    let AppropriatenessRecognisability =
        Prefixed_Name(sw_quality, "AppropriatenessRecognisability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Attractiveness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Attractiveness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Attractiveness">https://w3id.org/squap/SoftwareQuality/Attractiveness</seealso>
    let Attractiveness = Prefixed_Name(sw_quality, "Attractiveness") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Authenticity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Authenticity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Authenticity">https://w3id.org/squap/SoftwareQuality/Authenticity</seealso>
    let Authenticity = Prefixed_Name(sw_quality, "Authenticity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Availability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Availability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Availability">https://w3id.org/squap/SoftwareQuality/Availability</seealso>
    let Availability = Prefixed_Name(sw_quality, "Availability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Changeability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Changeability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Changeability">https://w3id.org/squap/SoftwareQuality/Changeability</seealso>
    let Changeability = Prefixed_Name(sw_quality, "Changeability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Co-existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Co-existence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Co-existence">https://w3id.org/squap/SoftwareQuality/Co-existence</seealso>
    let Co_existence = Prefixed_Name(sw_quality, "Co-existence") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Comfort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Comfort"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Comfort">https://w3id.org/squap/SoftwareQuality/Comfort</seealso>
    let Comfort = Prefixed_Name(sw_quality, "Comfort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/CommercialDamageInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Commercial damage in use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/CommercialDamageInUse">https://w3id.org/squap/SoftwareQuality/CommercialDamageInUse</seealso>
    let CommercialDamageInUse =
        Prefixed_Name(sw_quality, "CommercialDamageInUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Compatibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Compatibility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Compatibility">https://w3id.org/squap/SoftwareQuality/Compatibility</seealso>
    let Compatibility = Prefixed_Name(sw_quality, "Compatibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/CompatibilityCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Compatibility compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/CompatibilityCompliance">https://w3id.org/squap/SoftwareQuality/CompatibilityCompliance</seealso>
    let CompatibilityCompliance =
        Prefixed_Name(sw_quality, "CompatibilityCompliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Confidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Confidentiality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Confidentiality">https://w3id.org/squap/SoftwareQuality/Confidentiality</seealso>
    let Confidentiality = Prefixed_Name(sw_quality, "Confidentiality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/ContextConformityInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Context conformity in use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/ContextConformityInUse">https://w3id.org/squap/SoftwareQuality/ContextConformityInUse</seealso>
    let ContextConformityInUse =
        Prefixed_Name(sw_quality, "ContextConformityInUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/ContextExtendibilityInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Context extendibility in use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/ContextExtendibilityInUse">https://w3id.org/squap/SoftwareQuality/ContextExtendibilityInUse</seealso>
    let ContextExtendibilityInUse =
        Prefixed_Name(sw_quality, "ContextExtendibilityInUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/EaseOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ease of use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/EaseOfUse">https://w3id.org/squap/SoftwareQuality/EaseOfUse</seealso>
    let EaseOfUse = Prefixed_Name(sw_quality, "EaseOfUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/EffectivenessInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Effectiveness in use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/EffectivenessInUse">https://w3id.org/squap/SoftwareQuality/EffectivenessInUse</seealso>
    let EffectivenessInUse =
        Prefixed_Name(sw_quality, "EffectivenessInUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/EfficiencyInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Efficiency in use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/EfficiencyInUse">https://w3id.org/squap/SoftwareQuality/EfficiencyInUse</seealso>
    let EfficiencyInUse = Prefixed_Name(sw_quality, "EfficiencyInUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/EnvironmentalHarmInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Environmental harm in use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/EnvironmentalHarmInUse">https://w3id.org/squap/SoftwareQuality/EnvironmentalHarmInUse</seealso>
    let EnvironmentalHarmInUse =
        Prefixed_Name(sw_quality, "EnvironmentalHarmInUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/FaultTolerance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Fault tolerance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FaultTolerance">https://w3id.org/squap/SoftwareQuality/FaultTolerance</seealso>
    let FaultTolerance = Prefixed_Name(sw_quality, "FaultTolerance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/FlexibilityInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Flexibility in use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FlexibilityInUse">https://w3id.org/squap/SoftwareQuality/FlexibilityInUse</seealso>
    let FlexibilityInUse = Prefixed_Name(sw_quality, "FlexibilityInUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/FlexibilityInUseCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Flexibility in use compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FlexibilityInUseCompliance">https://w3id.org/squap/SoftwareQuality/FlexibilityInUseCompliance</seealso>
    let FlexibilityInUseCompliance =
        Prefixed_Name(sw_quality, "FlexibilityInUseCompliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/FunctionalAppropriateness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Functional appropriateness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FunctionalAppropriateness">https://w3id.org/squap/SoftwareQuality/FunctionalAppropriateness</seealso>
    let FunctionalAppropriateness =
        Prefixed_Name(sw_quality, "FunctionalAppropriateness") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/FunctionalCompleteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Functional completeness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FunctionalCompleteness">https://w3id.org/squap/SoftwareQuality/FunctionalCompleteness</seealso>
    let FunctionalCompleteness =
        Prefixed_Name(sw_quality, "FunctionalCompleteness") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/FunctionalCorrectness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Functional correctness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FunctionalCorrectness">https://w3id.org/squap/SoftwareQuality/FunctionalCorrectness</seealso>
    let FunctionalCorrectness =
        Prefixed_Name(sw_quality, "FunctionalCorrectness") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/FunctionalSuitability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Functional suitability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FunctionalSuitability">https://w3id.org/squap/SoftwareQuality/FunctionalSuitability</seealso>
    let FunctionalSuitability =
        Prefixed_Name(sw_quality, "FunctionalSuitability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Helpfulness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Helpfulness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Helpfulness">https://w3id.org/squap/SoftwareQuality/Helpfulness</seealso>
    let Helpfulness = Prefixed_Name(sw_quality, "Helpfulness") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Installability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Installability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Installability">https://w3id.org/squap/SoftwareQuality/Installability</seealso>
    let Installability = Prefixed_Name(sw_quality, "Installability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Integrity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Integrity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Integrity">https://w3id.org/squap/SoftwareQuality/Integrity</seealso>
    let Integrity = Prefixed_Name(sw_quality, "Integrity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Interoperability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Interoperability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Interoperability">https://w3id.org/squap/SoftwareQuality/Interoperability</seealso>
    let Interoperability = Prefixed_Name(sw_quality, "Interoperability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Learnability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Learnability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Learnability">https://w3id.org/squap/SoftwareQuality/Learnability</seealso>
    let Learnability = Prefixed_Name(sw_quality, "Learnability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Likability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Likability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Likability">https://w3id.org/squap/SoftwareQuality/Likability</seealso>
    let Likability = Prefixed_Name(sw_quality, "Likability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Maintainability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Maintainability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Maintainability">https://w3id.org/squap/SoftwareQuality/Maintainability</seealso>
    let Maintainability = Prefixed_Name(sw_quality, "Maintainability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/MaintainabilityCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Maintainability compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/MaintainabilityCompliance">https://w3id.org/squap/SoftwareQuality/MaintainabilityCompliance</seealso>
    let MaintainabilityCompliance =
        Prefixed_Name(sw_quality, "MaintainabilityCompliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Maturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Maturity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Maturity">https://w3id.org/squap/SoftwareQuality/Maturity</seealso>
    let Maturity = Prefixed_Name(sw_quality, "Maturity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Modifiability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Modifiability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Modifiability">https://w3id.org/squap/SoftwareQuality/Modifiability</seealso>
    let Modifiability = Prefixed_Name(sw_quality, "Modifiability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/ModificationStability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Modification stability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/ModificationStability">https://w3id.org/squap/SoftwareQuality/ModificationStability</seealso>
    let ModificationStability =
        Prefixed_Name(sw_quality, "ModificationStability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Modularity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Modularity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Modularity">https://w3id.org/squap/SoftwareQuality/Modularity</seealso>
    let Modularity = Prefixed_Name(sw_quality, "Modularity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Non-repudiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Non-repudiation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Non-repudiation">https://w3id.org/squap/SoftwareQuality/Non-repudiation</seealso>
    let Non_repudiation = Prefixed_Name(sw_quality, "Non-repudiation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Operability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Operability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Operability">https://w3id.org/squap/SoftwareQuality/Operability</seealso>
    let Operability = Prefixed_Name(sw_quality, "Operability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/OperabilityCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Operability compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/OperabilityCompliance">https://w3id.org/squap/SoftwareQuality/OperabilityCompliance</seealso>
    let OperabilityCompliance =
        Prefixed_Name(sw_quality, "OperabilityCompliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/OperatorHealthAndSafety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Operator health and safety"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/OperatorHealthAndSafety">https://w3id.org/squap/SoftwareQuality/OperatorHealthAndSafety</seealso>
    let OperatorHealthAndSafety =
        Prefixed_Name(sw_quality, "OperatorHealthAndSafety") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/PerformanceEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Performance efficiency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/PerformanceEfficiency">https://w3id.org/squap/SoftwareQuality/PerformanceEfficiency</seealso>
    let PerformanceEfficiency =
        Prefixed_Name(sw_quality, "PerformanceEfficiency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/PerformanceEfficiencyCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Performance efficiency compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/PerformanceEfficiencyCompliance">https://w3id.org/squap/SoftwareQuality/PerformanceEfficiencyCompliance</seealso>
    let PerformanceEfficiencyCompliance =
        Prefixed_Name(sw_quality, "PerformanceEfficiencyCompliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Pleasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Pleasure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Pleasure">https://w3id.org/squap/SoftwareQuality/Pleasure</seealso>
    let Pleasure = Prefixed_Name(sw_quality, "Pleasure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Portability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Portability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Portability">https://w3id.org/squap/SoftwareQuality/Portability</seealso>
    let Portability = Prefixed_Name(sw_quality, "Portability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/PublicHealthAndSafety</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Public health and safety"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/PublicHealthAndSafety">https://w3id.org/squap/SoftwareQuality/PublicHealthAndSafety</seealso>
    let PublicHealthAndSafety =
        Prefixed_Name(sw_quality, "PublicHealthAndSafety") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/QualityInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Quality in use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/QualityInUse">https://w3id.org/squap/SoftwareQuality/QualityInUse</seealso>
    let QualityInUse = Prefixed_Name(sw_quality, "QualityInUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Recoverability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Recoverability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Recoverability">https://w3id.org/squap/SoftwareQuality/Recoverability</seealso>
    let Recoverability = Prefixed_Name(sw_quality, "Recoverability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Reliability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Reliability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Reliability">https://w3id.org/squap/SoftwareQuality/Reliability</seealso>
    let Reliability = Prefixed_Name(sw_quality, "Reliability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/ReliabilityCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reliability compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/ReliabilityCompliance">https://w3id.org/squap/SoftwareQuality/ReliabilityCompliance</seealso>
    let ReliabilityCompliance =
        Prefixed_Name(sw_quality, "ReliabilityCompliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Replaceability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Replaceability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Replaceability">https://w3id.org/squap/SoftwareQuality/Replaceability</seealso>
    let Replaceability = Prefixed_Name(sw_quality, "Replaceability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/ResourceUtilization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Resource utilization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/ResourceUtilization">https://w3id.org/squap/SoftwareQuality/ResourceUtilization</seealso>
    let ResourceUtilization =
        Prefixed_Name(sw_quality, "ResourceUtilization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Reusability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reusability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Reusability">https://w3id.org/squap/SoftwareQuality/Reusability</seealso>
    let Reusability = Prefixed_Name(sw_quality, "Reusability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Safety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Safety"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Safety">https://w3id.org/squap/SoftwareQuality/Safety</seealso>
    let Safety = Prefixed_Name(sw_quality, "Safety") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/SafetyCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Safety compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/SafetyCompliance">https://w3id.org/squap/SoftwareQuality/SafetyCompliance</seealso>
    let SafetyCompliance = Prefixed_Name(sw_quality, "SafetyCompliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/SatisfactionInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Satisfaction in use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/SatisfactionInUse">https://w3id.org/squap/SoftwareQuality/SatisfactionInUse</seealso>
    let SatisfactionInUse =
        Prefixed_Name(sw_quality, "SatisfactionInUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Security</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Security">https://w3id.org/squap/SoftwareQuality/Security</seealso>
    let Security = Prefixed_Name(sw_quality, "Security") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/SecurityCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Security compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/SecurityCompliance">https://w3id.org/squap/SoftwareQuality/SecurityCompliance</seealso>
    let SecurityCompliance =
        Prefixed_Name(sw_quality, "SecurityCompliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/SoftwareProductQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Software product quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/SoftwareProductQuality">https://w3id.org/squap/SoftwareQuality/SoftwareProductQuality</seealso>
    let SoftwareProductQuality =
        Prefixed_Name(sw_quality, "SoftwareProductQuality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/TechnicalAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Technical accessibility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/TechnicalAccessibility">https://w3id.org/squap/SoftwareQuality/TechnicalAccessibility</seealso>
    let TechnicalAccessibility =
        Prefixed_Name(sw_quality, "TechnicalAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Testability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Testability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Testability">https://w3id.org/squap/SoftwareQuality/Testability</seealso>
    let Testability = Prefixed_Name(sw_quality, "Testability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/TimeBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Time behaviour"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/TimeBehaviour">https://w3id.org/squap/SoftwareQuality/TimeBehaviour</seealso>
    let TimeBehaviour = Prefixed_Name(sw_quality, "TimeBehaviour") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Transferability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Transferability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Transferability">https://w3id.org/squap/SoftwareQuality/Transferability</seealso>
    let Transferability = Prefixed_Name(sw_quality, "Transferability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/TransferabilityCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>"Transferability compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/TransferabilityCompliance">https://w3id.org/squap/SoftwareQuality/TransferabilityCompliance</seealso>
    let TransferabilityCompliance =
        Prefixed_Name(sw_quality, "TransferabilityCompliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/Trust</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Trust"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Trust">https://w3id.org/squap/SoftwareQuality/Trust</seealso>
    let Trust = Prefixed_Name(sw_quality, "Trust") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/UsabilityInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Usability in use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/UsabilityInUse">https://w3id.org/squap/SoftwareQuality/UsabilityInUse</seealso>
    let UsabilityInUse = Prefixed_Name(sw_quality, "UsabilityInUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality/UsabilityInUseCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Usability in use compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/UsabilityInUseCompliance">https://w3id.org/squap/SoftwareQuality/UsabilityInUseCompliance</seealso>
    let UsabilityInUseCompliance =
        Prefixed_Name(sw_quality, "UsabilityInUseCompliance") |> PrefixedName
