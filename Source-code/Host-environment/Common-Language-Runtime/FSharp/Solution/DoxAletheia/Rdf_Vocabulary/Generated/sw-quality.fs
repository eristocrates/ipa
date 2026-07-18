namespace https.w3id.org.squap.SoftwareQuality.slash

open DoxAletheia.Rdf_Vocabulary

module sw_quality =
    let _namespace_name = "https://w3id.org/squap/SoftwareQuality/"

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Analysability"></see>
    /// </summary>
    let Analysability =
        Namespaced_IRI.parse _namespace_name "Analysability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FunctionalCorrectness"></see>
    /// </summary>
    let FunctionalCorrectness =
        Namespaced_IRI.parse _namespace_name "FunctionalCorrectness" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FunctionalCompleteness"></see>
    /// </summary>
    let FunctionalCompleteness =
        Namespaced_IRI.parse _namespace_name "FunctionalCompleteness" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Modifiability"></see>
    /// </summary>
    let Modifiability =
        Namespaced_IRI.parse _namespace_name "Modifiability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Replaceability"></see>
    /// </summary>
    let Replaceability =
        Namespaced_IRI.parse _namespace_name "Replaceability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FunctionalAppropriateness"></see>
    /// </summary>
    let FunctionalAppropriateness =
        Namespaced_IRI.parse _namespace_name "FunctionalAppropriateness" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Operability"></see>
    /// </summary>
    let Operability =
        Namespaced_IRI.parse _namespace_name "Operability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Maturity"></see>
    /// </summary>
    let Maturity = Namespaced_IRI.parse _namespace_name "Maturity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Reusability"></see>
    /// </summary>
    let Reusability =
        Namespaced_IRI.parse _namespace_name "Reusability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Adaptability"></see>
    /// </summary>
    let Adaptability =
        Namespaced_IRI.parse _namespace_name "Adaptability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Learnability"></see>
    /// </summary>
    let Learnability =
        Namespaced_IRI.parse _namespace_name "Learnability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Testability"></see>
    /// </summary>
    let Testability =
        Namespaced_IRI.parse _namespace_name "Testability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Accountability"></see>
    /// </summary>
    let Accountability =
        Namespaced_IRI.parse _namespace_name "Accountability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Integrity"></see>
    /// </summary>
    let Integrity = Namespaced_IRI.parse _namespace_name "Integrity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Installability"></see>
    /// </summary>
    let Installability =
        Namespaced_IRI.parse _namespace_name "Installability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Modularity"></see>
    /// </summary>
    let Modularity = Namespaced_IRI.parse _namespace_name "Modularity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Non-repudiation"></see>
    /// </summary>
    let ``Non-repudiation`` =
        Namespaced_IRI.parse _namespace_name "Non-repudiation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/TimeBehaviour"></see>
    /// </summary>
    let TimeBehaviour =
        Namespaced_IRI.parse _namespace_name "TimeBehaviour" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Interoperability"></see>
    /// </summary>
    let Interoperability =
        Namespaced_IRI.parse _namespace_name "Interoperability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Co-existence"></see>
    /// </summary>
    let ``Co-existence`` =
        Namespaced_IRI.parse _namespace_name "Co-existence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/ResourceUtilization"></see>
    /// </summary>
    let ResourceUtilization =
        Namespaced_IRI.parse _namespace_name "ResourceUtilization" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FaultTolerance"></see>
    /// </summary>
    let FaultTolerance =
        Namespaced_IRI.parse _namespace_name "FaultTolerance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/AccessibilityInUse"></see>
    /// </summary>
    let AccessibilityInUse =
        Namespaced_IRI.parse _namespace_name "AccessibilityInUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FlexibilityInUse"></see>
    /// </summary>
    let FlexibilityInUse =
        Namespaced_IRI.parse _namespace_name "FlexibilityInUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Security"></see>
    /// </summary>
    let Security = Namespaced_IRI.parse _namespace_name "Security" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Accuracy"></see>
    /// </summary>
    let Accuracy = Namespaced_IRI.parse _namespace_name "Accuracy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FunctionalSuitability"></see>
    /// </summary>
    let FunctionalSuitability =
        Namespaced_IRI.parse _namespace_name "FunctionalSuitability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Transferability"></see>
    /// </summary>
    let Transferability =
        Namespaced_IRI.parse _namespace_name "Transferability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Compatibility"></see>
    /// </summary>
    let Compatibility =
        Namespaced_IRI.parse _namespace_name "Compatibility" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Appropriateness"></see>
    /// </summary>
    let Appropriateness =
        Namespaced_IRI.parse _namespace_name "Appropriateness" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/AppropriatenessRecognisability"></see>
    /// </summary>
    let AppropriatenessRecognisability =
        Namespaced_IRI.parse _namespace_name "AppropriatenessRecognisability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Attractiveness"></see>
    /// </summary>
    let Attractiveness =
        Namespaced_IRI.parse _namespace_name "Attractiveness" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Authenticity"></see>
    /// </summary>
    let Authenticity =
        Namespaced_IRI.parse _namespace_name "Authenticity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Availability"></see>
    /// </summary>
    let Availability =
        Namespaced_IRI.parse _namespace_name "Availability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Reliability"></see>
    /// </summary>
    let Reliability =
        Namespaced_IRI.parse _namespace_name "Reliability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Changeability"></see>
    /// </summary>
    let Changeability =
        Namespaced_IRI.parse _namespace_name "Changeability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Comfort"></see>
    /// </summary>
    let Comfort = Namespaced_IRI.parse _namespace_name "Comfort" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/SatisfactionInUse"></see>
    /// </summary>
    let SatisfactionInUse =
        Namespaced_IRI.parse _namespace_name "SatisfactionInUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/CommercialDamageInUse"></see>
    /// </summary>
    let CommercialDamageInUse =
        Namespaced_IRI.parse _namespace_name "CommercialDamageInUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Safety"></see>
    /// </summary>
    let Safety = Namespaced_IRI.parse _namespace_name "Safety" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/SoftwareProductQuality"></see>
    /// </summary>
    let SoftwareProductQuality =
        Namespaced_IRI.parse _namespace_name "SoftwareProductQuality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/CompatibilityCompliance"></see>
    /// </summary>
    let CompatibilityCompliance =
        Namespaced_IRI.parse _namespace_name "CompatibilityCompliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Confidentiality"></see>
    /// </summary>
    let Confidentiality =
        Namespaced_IRI.parse _namespace_name "Confidentiality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/ContextConformityInUse"></see>
    /// </summary>
    let ContextConformityInUse =
        Namespaced_IRI.parse _namespace_name "ContextConformityInUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/ContextExtendibilityInUse"></see>
    /// </summary>
    let ContextExtendibilityInUse =
        Namespaced_IRI.parse _namespace_name "ContextExtendibilityInUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/EaseOfUse"></see>
    /// </summary>
    let EaseOfUse = Namespaced_IRI.parse _namespace_name "EaseOfUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/EffectivenessInUse"></see>
    /// </summary>
    let EffectivenessInUse =
        Namespaced_IRI.parse _namespace_name "EffectivenessInUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/UsabilityInUse"></see>
    /// </summary>
    let UsabilityInUse =
        Namespaced_IRI.parse _namespace_name "UsabilityInUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/EfficiencyInUse"></see>
    /// </summary>
    let EfficiencyInUse =
        Namespaced_IRI.parse _namespace_name "EfficiencyInUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/EnvironmentalHarmInUse"></see>
    /// </summary>
    let EnvironmentalHarmInUse =
        Namespaced_IRI.parse _namespace_name "EnvironmentalHarmInUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/QualityInUse"></see>
    /// </summary>
    let QualityInUse =
        Namespaced_IRI.parse _namespace_name "QualityInUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FlexibilityInUseCompliance"></see>
    /// </summary>
    let FlexibilityInUseCompliance =
        Namespaced_IRI.parse _namespace_name "FlexibilityInUseCompliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Helpfulness"></see>
    /// </summary>
    let Helpfulness =
        Namespaced_IRI.parse _namespace_name "Helpfulness" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Likability"></see>
    /// </summary>
    let Likability = Namespaced_IRI.parse _namespace_name "Likability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Maintainability"></see>
    /// </summary>
    let Maintainability =
        Namespaced_IRI.parse _namespace_name "Maintainability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/MaintainabilityCompliance"></see>
    /// </summary>
    let MaintainabilityCompliance =
        Namespaced_IRI.parse _namespace_name "MaintainabilityCompliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/ModificationStability"></see>
    /// </summary>
    let ModificationStability =
        Namespaced_IRI.parse _namespace_name "ModificationStability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/OperabilityCompliance"></see>
    /// </summary>
    let OperabilityCompliance =
        Namespaced_IRI.parse _namespace_name "OperabilityCompliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/OperatorHealthAndSafety"></see>
    /// </summary>
    let OperatorHealthAndSafety =
        Namespaced_IRI.parse _namespace_name "OperatorHealthAndSafety" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/PerformanceEfficiency"></see>
    /// </summary>
    let PerformanceEfficiency =
        Namespaced_IRI.parse _namespace_name "PerformanceEfficiency" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/PerformanceEfficiencyCompliance"></see>
    /// </summary>
    let PerformanceEfficiencyCompliance =
        Namespaced_IRI.parse _namespace_name "PerformanceEfficiencyCompliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Pleasure"></see>
    /// </summary>
    let Pleasure = Namespaced_IRI.parse _namespace_name "Pleasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Portability"></see>
    /// </summary>
    let Portability =
        Namespaced_IRI.parse _namespace_name "Portability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/PublicHealthAndSafety"></see>
    /// </summary>
    let PublicHealthAndSafety =
        Namespaced_IRI.parse _namespace_name "PublicHealthAndSafety" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Recoverability"></see>
    /// </summary>
    let Recoverability =
        Namespaced_IRI.parse _namespace_name "Recoverability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/ReliabilityCompliance"></see>
    /// </summary>
    let ReliabilityCompliance =
        Namespaced_IRI.parse _namespace_name "ReliabilityCompliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/SafetyCompliance"></see>
    /// </summary>
    let SafetyCompliance =
        Namespaced_IRI.parse _namespace_name "SafetyCompliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/SecurityCompliance"></see>
    /// </summary>
    let SecurityCompliance =
        Namespaced_IRI.parse _namespace_name "SecurityCompliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/TechnicalAccessibility"></see>
    /// </summary>
    let TechnicalAccessibility =
        Namespaced_IRI.parse _namespace_name "TechnicalAccessibility" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/TransferabilityCompliance"></see>
    /// </summary>
    let TransferabilityCompliance =
        Namespaced_IRI.parse _namespace_name "TransferabilityCompliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Trust"></see>
    /// </summary>
    let Trust = Namespaced_IRI.parse _namespace_name "Trust" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/UsabilityInUseCompliance"></see>
    /// </summary>
    let UsabilityInUseCompliance =
        Namespaced_IRI.parse _namespace_name "UsabilityInUseCompliance" |> NamespacedName
