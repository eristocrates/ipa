namespace https.w3id.org.squap.SoftwareQuality.slash

open DoxAletheia

module sw_quality =
    let _namespace_name = "https://w3id.org/squap/SoftwareQuality/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Analysability"></see>
    /// </summary>
    let Analysability = _prefix "Analysability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FunctionalCorrectness"></see>
    /// </summary>
    let FunctionalCorrectness = _prefix "FunctionalCorrectness"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FunctionalCompleteness"></see>
    /// </summary>
    let FunctionalCompleteness = _prefix "FunctionalCompleteness"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Modifiability"></see>
    /// </summary>
    let Modifiability = _prefix "Modifiability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Replaceability"></see>
    /// </summary>
    let Replaceability = _prefix "Replaceability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FunctionalAppropriateness"></see>
    /// </summary>
    let FunctionalAppropriateness = _prefix "FunctionalAppropriateness"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Operability"></see>
    /// </summary>
    let Operability = _prefix "Operability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Maturity"></see>
    /// </summary>
    let Maturity = _prefix "Maturity"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Reusability"></see>
    /// </summary>
    let Reusability = _prefix "Reusability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Adaptability"></see>
    /// </summary>
    let Adaptability = _prefix "Adaptability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Learnability"></see>
    /// </summary>
    let Learnability = _prefix "Learnability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Testability"></see>
    /// </summary>
    let Testability = _prefix "Testability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Accountability"></see>
    /// </summary>
    let Accountability = _prefix "Accountability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Integrity"></see>
    /// </summary>
    let Integrity = _prefix "Integrity"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Installability"></see>
    /// </summary>
    let Installability = _prefix "Installability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Modularity"></see>
    /// </summary>
    let Modularity = _prefix "Modularity"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Non-repudiation"></see>
    /// </summary>
    let ``Non-repudiation`` = _prefix "Non-repudiation"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/TimeBehaviour"></see>
    /// </summary>
    let TimeBehaviour = _prefix "TimeBehaviour"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Interoperability"></see>
    /// </summary>
    let Interoperability = _prefix "Interoperability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Co-existence"></see>
    /// </summary>
    let ``Co-existence`` = _prefix "Co-existence"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/ResourceUtilization"></see>
    /// </summary>
    let ResourceUtilization = _prefix "ResourceUtilization"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FaultTolerance"></see>
    /// </summary>
    let FaultTolerance = _prefix "FaultTolerance"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/AccessibilityInUse"></see>
    /// </summary>
    let AccessibilityInUse = _prefix "AccessibilityInUse"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FlexibilityInUse"></see>
    /// </summary>
    let FlexibilityInUse = _prefix "FlexibilityInUse"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Security"></see>
    /// </summary>
    let Security = _prefix "Security"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Accuracy"></see>
    /// </summary>
    let Accuracy = _prefix "Accuracy"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FunctionalSuitability"></see>
    /// </summary>
    let FunctionalSuitability = _prefix "FunctionalSuitability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Transferability"></see>
    /// </summary>
    let Transferability = _prefix "Transferability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Compatibility"></see>
    /// </summary>
    let Compatibility = _prefix "Compatibility"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Appropriateness"></see>
    /// </summary>
    let Appropriateness = _prefix "Appropriateness"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/AppropriatenessRecognisability"></see>
    /// </summary>
    let AppropriatenessRecognisability = _prefix "AppropriatenessRecognisability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Attractiveness"></see>
    /// </summary>
    let Attractiveness = _prefix "Attractiveness"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Authenticity"></see>
    /// </summary>
    let Authenticity = _prefix "Authenticity"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Availability"></see>
    /// </summary>
    let Availability = _prefix "Availability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Reliability"></see>
    /// </summary>
    let Reliability = _prefix "Reliability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Changeability"></see>
    /// </summary>
    let Changeability = _prefix "Changeability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Comfort"></see>
    /// </summary>
    let Comfort = _prefix "Comfort"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/SatisfactionInUse"></see>
    /// </summary>
    let SatisfactionInUse = _prefix "SatisfactionInUse"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/CommercialDamageInUse"></see>
    /// </summary>
    let CommercialDamageInUse = _prefix "CommercialDamageInUse"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Safety"></see>
    /// </summary>
    let Safety = _prefix "Safety"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/SoftwareProductQuality"></see>
    /// </summary>
    let SoftwareProductQuality = _prefix "SoftwareProductQuality"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/CompatibilityCompliance"></see>
    /// </summary>
    let CompatibilityCompliance = _prefix "CompatibilityCompliance"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Confidentiality"></see>
    /// </summary>
    let Confidentiality = _prefix "Confidentiality"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/ContextConformityInUse"></see>
    /// </summary>
    let ContextConformityInUse = _prefix "ContextConformityInUse"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/ContextExtendibilityInUse"></see>
    /// </summary>
    let ContextExtendibilityInUse = _prefix "ContextExtendibilityInUse"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/EaseOfUse"></see>
    /// </summary>
    let EaseOfUse = _prefix "EaseOfUse"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/EffectivenessInUse"></see>
    /// </summary>
    let EffectivenessInUse = _prefix "EffectivenessInUse"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/UsabilityInUse"></see>
    /// </summary>
    let UsabilityInUse = _prefix "UsabilityInUse"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/EfficiencyInUse"></see>
    /// </summary>
    let EfficiencyInUse = _prefix "EfficiencyInUse"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/EnvironmentalHarmInUse"></see>
    /// </summary>
    let EnvironmentalHarmInUse = _prefix "EnvironmentalHarmInUse"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/QualityInUse"></see>
    /// </summary>
    let QualityInUse = _prefix "QualityInUse"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/FlexibilityInUseCompliance"></see>
    /// </summary>
    let FlexibilityInUseCompliance = _prefix "FlexibilityInUseCompliance"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Helpfulness"></see>
    /// </summary>
    let Helpfulness = _prefix "Helpfulness"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Likability"></see>
    /// </summary>
    let Likability = _prefix "Likability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Maintainability"></see>
    /// </summary>
    let Maintainability = _prefix "Maintainability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/MaintainabilityCompliance"></see>
    /// </summary>
    let MaintainabilityCompliance = _prefix "MaintainabilityCompliance"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/ModificationStability"></see>
    /// </summary>
    let ModificationStability = _prefix "ModificationStability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/OperabilityCompliance"></see>
    /// </summary>
    let OperabilityCompliance = _prefix "OperabilityCompliance"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/OperatorHealthAndSafety"></see>
    /// </summary>
    let OperatorHealthAndSafety = _prefix "OperatorHealthAndSafety"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/PerformanceEfficiency"></see>
    /// </summary>
    let PerformanceEfficiency = _prefix "PerformanceEfficiency"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/PerformanceEfficiencyCompliance"></see>
    /// </summary>
    let PerformanceEfficiencyCompliance = _prefix "PerformanceEfficiencyCompliance"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Pleasure"></see>
    /// </summary>
    let Pleasure = _prefix "Pleasure"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Portability"></see>
    /// </summary>
    let Portability = _prefix "Portability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/PublicHealthAndSafety"></see>
    /// </summary>
    let PublicHealthAndSafety = _prefix "PublicHealthAndSafety"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Recoverability"></see>
    /// </summary>
    let Recoverability = _prefix "Recoverability"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/ReliabilityCompliance"></see>
    /// </summary>
    let ReliabilityCompliance = _prefix "ReliabilityCompliance"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/SafetyCompliance"></see>
    /// </summary>
    let SafetyCompliance = _prefix "SafetyCompliance"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/SecurityCompliance"></see>
    /// </summary>
    let SecurityCompliance = _prefix "SecurityCompliance"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/TechnicalAccessibility"></see>
    /// </summary>
    let TechnicalAccessibility = _prefix "TechnicalAccessibility"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/TransferabilityCompliance"></see>
    /// </summary>
    let TransferabilityCompliance = _prefix "TransferabilityCompliance"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/Trust"></see>
    /// </summary>
    let Trust = _prefix "Trust"
    /// <summary>
    ///   <see href="https://w3id.org/squap/SoftwareQuality/UsabilityInUseCompliance"></see>
    /// </summary>
    let UsabilityInUseCompliance = _prefix "UsabilityInUseCompliance"
