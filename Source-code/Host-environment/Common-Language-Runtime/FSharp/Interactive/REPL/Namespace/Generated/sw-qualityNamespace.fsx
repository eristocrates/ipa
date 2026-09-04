#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``sw-quality`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/squap/SoftwareQuality/" "sw-quality"

    /// <summary>
    ///   <para>rdfs:label : Accessibility in use^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/AccessibilityInUse">sw-quality:AccessibilityInUse</a>
    /// </summary>
    let AccessibilityInUse = _prefixId.prefix "AccessibilityInUse"
    /// <summary>
    ///   <para>rdfs:label : Accountability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Accountability">sw-quality:Accountability</a>
    /// </summary>
    let Accountability = _prefixId.prefix "Accountability"
    /// <summary>
    ///   <para>rdfs:label : Accuracy^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Accuracy">sw-quality:Accuracy</a>
    /// </summary>
    let Accuracy = _prefixId.prefix "Accuracy"
    /// <summary>
    ///   <para>rdfs:label : Adaptability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Adaptability">sw-quality:Adaptability</a>
    /// </summary>
    let Adaptability = _prefixId.prefix "Adaptability"
    /// <summary>
    ///   <para>rdfs:label : Analysability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Analysability">sw-quality:Analysability</a>
    /// </summary>
    let Analysability = _prefixId.prefix "Analysability"
    /// <summary>
    ///   <para>rdfs:label : Appropriateness^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Appropriateness">sw-quality:Appropriateness</a>
    /// </summary>
    let Appropriateness = _prefixId.prefix "Appropriateness"

    /// <summary>
    ///   <para>rdfs:label : Appropriateness recognisability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/AppropriatenessRecognisability">sw-quality:AppropriatenessRecognisability</a>
    /// </summary>
    let AppropriatenessRecognisability =
        _prefixId.prefix "AppropriatenessRecognisability"

    /// <summary>
    ///   <para>rdfs:label : Attractiveness^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Attractiveness">sw-quality:Attractiveness</a>
    /// </summary>
    let Attractiveness = _prefixId.prefix "Attractiveness"
    /// <summary>
    ///   <para>rdfs:label : Authenticity^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Authenticity">sw-quality:Authenticity</a>
    /// </summary>
    let Authenticity = _prefixId.prefix "Authenticity"
    /// <summary>
    ///   <para>rdfs:label : Availability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Availability">sw-quality:Availability</a>
    /// </summary>
    let Availability = _prefixId.prefix "Availability"
    /// <summary>
    ///   <para>rdfs:label : Changeability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Changeability">sw-quality:Changeability</a>
    /// </summary>
    let Changeability = _prefixId.prefix "Changeability"
    /// <summary>
    ///   <para>rdfs:label : Co-existence^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Co-existence">sw-quality:Co-existence</a>
    /// </summary>
    let Co_existence = _prefixId.prefix "Co-existence"
    /// <summary>
    ///   <para>rdfs:label : Comfort^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Comfort">sw-quality:Comfort</a>
    /// </summary>
    let Comfort = _prefixId.prefix "Comfort"
    /// <summary>
    ///   <para>rdfs:label : Commercial damage in use^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/CommercialDamageInUse">sw-quality:CommercialDamageInUse</a>
    /// </summary>
    let CommercialDamageInUse = _prefixId.prefix "CommercialDamageInUse"
    /// <summary>
    ///   <para>rdfs:label : Compatibility^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Compatibility">sw-quality:Compatibility</a>
    /// </summary>
    let Compatibility = _prefixId.prefix "Compatibility"
    /// <summary>
    ///   <para>rdfs:label : Compatibility compliance^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/CompatibilityCompliance">sw-quality:CompatibilityCompliance</a>
    /// </summary>
    let CompatibilityCompliance = _prefixId.prefix "CompatibilityCompliance"
    /// <summary>
    ///   <para>rdfs:label : Confidentiality^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Confidentiality">sw-quality:Confidentiality</a>
    /// </summary>
    let Confidentiality = _prefixId.prefix "Confidentiality"
    /// <summary>
    ///   <para>rdfs:label : Context conformity in use^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/ContextConformityInUse">sw-quality:ContextConformityInUse</a>
    /// </summary>
    let ContextConformityInUse = _prefixId.prefix "ContextConformityInUse"
    /// <summary>
    ///   <para>rdfs:label : Context extendibility in use^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/ContextExtendibilityInUse">sw-quality:ContextExtendibilityInUse</a>
    /// </summary>
    let ContextExtendibilityInUse = _prefixId.prefix "ContextExtendibilityInUse"
    /// <summary>
    ///   <para>rdfs:label : Ease of use^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/EaseOfUse">sw-quality:EaseOfUse</a>
    /// </summary>
    let EaseOfUse = _prefixId.prefix "EaseOfUse"
    /// <summary>
    ///   <para>rdfs:label : Effectiveness in use^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/EffectivenessInUse">sw-quality:EffectivenessInUse</a>
    /// </summary>
    let EffectivenessInUse = _prefixId.prefix "EffectivenessInUse"
    /// <summary>
    ///   <para>rdfs:label : Efficiency in use^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/EfficiencyInUse">sw-quality:EfficiencyInUse</a>
    /// </summary>
    let EfficiencyInUse = _prefixId.prefix "EfficiencyInUse"
    /// <summary>
    ///   <para>rdfs:label : Environmental harm in use^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/EnvironmentalHarmInUse">sw-quality:EnvironmentalHarmInUse</a>
    /// </summary>
    let EnvironmentalHarmInUse = _prefixId.prefix "EnvironmentalHarmInUse"
    /// <summary>
    ///   <para>rdfs:label : Fault tolerance^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/FaultTolerance">sw-quality:FaultTolerance</a>
    /// </summary>
    let FaultTolerance = _prefixId.prefix "FaultTolerance"
    /// <summary>
    ///   <para>rdfs:label : Flexibility in use^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/FlexibilityInUse">sw-quality:FlexibilityInUse</a>
    /// </summary>
    let FlexibilityInUse = _prefixId.prefix "FlexibilityInUse"
    /// <summary>
    ///   <para>rdfs:label : Flexibility in use compliance^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/FlexibilityInUseCompliance">sw-quality:FlexibilityInUseCompliance</a>
    /// </summary>
    let FlexibilityInUseCompliance = _prefixId.prefix "FlexibilityInUseCompliance"
    /// <summary>
    ///   <para>rdfs:label : Functional appropriateness^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/FunctionalAppropriateness">sw-quality:FunctionalAppropriateness</a>
    /// </summary>
    let FunctionalAppropriateness = _prefixId.prefix "FunctionalAppropriateness"
    /// <summary>
    ///   <para>rdfs:label : Functional completeness^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/FunctionalCompleteness">sw-quality:FunctionalCompleteness</a>
    /// </summary>
    let FunctionalCompleteness = _prefixId.prefix "FunctionalCompleteness"
    /// <summary>
    ///   <para>rdfs:label : Functional correctness^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/FunctionalCorrectness">sw-quality:FunctionalCorrectness</a>
    /// </summary>
    let FunctionalCorrectness = _prefixId.prefix "FunctionalCorrectness"
    /// <summary>
    ///   <para>rdfs:label : Functional suitability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/FunctionalSuitability">sw-quality:FunctionalSuitability</a>
    /// </summary>
    let FunctionalSuitability = _prefixId.prefix "FunctionalSuitability"
    /// <summary>
    ///   <para>rdfs:label : Helpfulness^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Helpfulness">sw-quality:Helpfulness</a>
    /// </summary>
    let Helpfulness = _prefixId.prefix "Helpfulness"
    /// <summary>
    ///   <para>rdfs:label : Installability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Installability">sw-quality:Installability</a>
    /// </summary>
    let Installability = _prefixId.prefix "Installability"
    /// <summary>
    ///   <para>rdfs:label : Integrity^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Integrity">sw-quality:Integrity</a>
    /// </summary>
    let Integrity = _prefixId.prefix "Integrity"
    /// <summary>
    ///   <para>rdfs:label : Interoperability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Interoperability">sw-quality:Interoperability</a>
    /// </summary>
    let Interoperability = _prefixId.prefix "Interoperability"
    /// <summary>
    ///   <para>rdfs:label : Learnability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Learnability">sw-quality:Learnability</a>
    /// </summary>
    let Learnability = _prefixId.prefix "Learnability"
    /// <summary>
    ///   <para>rdfs:label : Likability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Likability">sw-quality:Likability</a>
    /// </summary>
    let Likability = _prefixId.prefix "Likability"
    /// <summary>
    ///   <para>rdfs:label : Maintainability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Maintainability">sw-quality:Maintainability</a>
    /// </summary>
    let Maintainability = _prefixId.prefix "Maintainability"
    /// <summary>
    ///   <para>rdfs:label : Maintainability compliance^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/MaintainabilityCompliance">sw-quality:MaintainabilityCompliance</a>
    /// </summary>
    let MaintainabilityCompliance = _prefixId.prefix "MaintainabilityCompliance"
    /// <summary>
    ///   <para>rdfs:label : Maturity^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Maturity">sw-quality:Maturity</a>
    /// </summary>
    let Maturity = _prefixId.prefix "Maturity"
    /// <summary>
    ///   <para>rdfs:label : Modifiability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Modifiability">sw-quality:Modifiability</a>
    /// </summary>
    let Modifiability = _prefixId.prefix "Modifiability"
    /// <summary>
    ///   <para>rdfs:label : Modification stability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/ModificationStability">sw-quality:ModificationStability</a>
    /// </summary>
    let ModificationStability = _prefixId.prefix "ModificationStability"
    /// <summary>
    ///   <para>rdfs:label : Modularity^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Modularity">sw-quality:Modularity</a>
    /// </summary>
    let Modularity = _prefixId.prefix "Modularity"
    /// <summary>
    ///   <para>rdfs:label : Non-repudiation^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Non-repudiation">sw-quality:Non-repudiation</a>
    /// </summary>
    let Non_repudiation = _prefixId.prefix "Non-repudiation"
    /// <summary>
    ///   <para>rdfs:label : Operability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Operability">sw-quality:Operability</a>
    /// </summary>
    let Operability = _prefixId.prefix "Operability"
    /// <summary>
    ///   <para>rdfs:label : Operability compliance^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/OperabilityCompliance">sw-quality:OperabilityCompliance</a>
    /// </summary>
    let OperabilityCompliance = _prefixId.prefix "OperabilityCompliance"
    /// <summary>
    ///   <para>rdfs:label : Operator health and safety^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/OperatorHealthAndSafety">sw-quality:OperatorHealthAndSafety</a>
    /// </summary>
    let OperatorHealthAndSafety = _prefixId.prefix "OperatorHealthAndSafety"
    /// <summary>
    ///   <para>rdfs:label : Performance efficiency^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/PerformanceEfficiency">sw-quality:PerformanceEfficiency</a>
    /// </summary>
    let PerformanceEfficiency = _prefixId.prefix "PerformanceEfficiency"

    /// <summary>
    ///   <para>rdfs:label : Performance efficiency compliance^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/PerformanceEfficiencyCompliance">sw-quality:PerformanceEfficiencyCompliance</a>
    /// </summary>
    let PerformanceEfficiencyCompliance =
        _prefixId.prefix "PerformanceEfficiencyCompliance"

    /// <summary>
    ///   <para>rdfs:label : Pleasure^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Pleasure">sw-quality:Pleasure</a>
    /// </summary>
    let Pleasure = _prefixId.prefix "Pleasure"
    /// <summary>
    ///   <para>rdfs:label : Portability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Portability">sw-quality:Portability</a>
    /// </summary>
    let Portability = _prefixId.prefix "Portability"
    /// <summary>
    ///   <para>rdfs:label : Public health and safety^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/PublicHealthAndSafety">sw-quality:PublicHealthAndSafety</a>
    /// </summary>
    let PublicHealthAndSafety = _prefixId.prefix "PublicHealthAndSafety"
    /// <summary>
    ///   <para>rdfs:label : Quality in use^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/QualityInUse">sw-quality:QualityInUse</a>
    /// </summary>
    let QualityInUse = _prefixId.prefix "QualityInUse"
    /// <summary>
    ///   <para>rdfs:label : Recoverability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Recoverability">sw-quality:Recoverability</a>
    /// </summary>
    let Recoverability = _prefixId.prefix "Recoverability"
    /// <summary>
    ///   <para>rdfs:label : Reliability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Reliability">sw-quality:Reliability</a>
    /// </summary>
    let Reliability = _prefixId.prefix "Reliability"
    /// <summary>
    ///   <para>rdfs:label : Reliability compliance^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/ReliabilityCompliance">sw-quality:ReliabilityCompliance</a>
    /// </summary>
    let ReliabilityCompliance = _prefixId.prefix "ReliabilityCompliance"
    /// <summary>
    ///   <para>rdfs:label : Replaceability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Replaceability">sw-quality:Replaceability</a>
    /// </summary>
    let Replaceability = _prefixId.prefix "Replaceability"
    /// <summary>
    ///   <para>rdfs:label : Resource utilization^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/ResourceUtilization">sw-quality:ResourceUtilization</a>
    /// </summary>
    let ResourceUtilization = _prefixId.prefix "ResourceUtilization"
    /// <summary>
    ///   <para>rdfs:label : Reusability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Reusability">sw-quality:Reusability</a>
    /// </summary>
    let Reusability = _prefixId.prefix "Reusability"
    /// <summary>
    ///   <para>rdfs:label : Safety^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Safety">sw-quality:Safety</a>
    /// </summary>
    let Safety = _prefixId.prefix "Safety"
    /// <summary>
    ///   <para>rdfs:label : Safety compliance^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/SafetyCompliance">sw-quality:SafetyCompliance</a>
    /// </summary>
    let SafetyCompliance = _prefixId.prefix "SafetyCompliance"
    /// <summary>
    ///   <para>rdfs:label : Satisfaction in use^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/SatisfactionInUse">sw-quality:SatisfactionInUse</a>
    /// </summary>
    let SatisfactionInUse = _prefixId.prefix "SatisfactionInUse"
    /// <summary>
    ///   <para>rdfs:label : Security^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Security">sw-quality:Security</a>
    /// </summary>
    let Security = _prefixId.prefix "Security"
    /// <summary>
    ///   <para>rdfs:label : Security compliance^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/SecurityCompliance">sw-quality:SecurityCompliance</a>
    /// </summary>
    let SecurityCompliance = _prefixId.prefix "SecurityCompliance"
    /// <summary>
    ///   <para>rdfs:label : Software product quality^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/SoftwareProductQuality">sw-quality:SoftwareProductQuality</a>
    /// </summary>
    let SoftwareProductQuality = _prefixId.prefix "SoftwareProductQuality"
    /// <summary>
    ///   <para>rdfs:label : Technical accessibility^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/TechnicalAccessibility">sw-quality:TechnicalAccessibility</a>
    /// </summary>
    let TechnicalAccessibility = _prefixId.prefix "TechnicalAccessibility"
    /// <summary>
    ///   <para>rdfs:label : Testability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Testability">sw-quality:Testability</a>
    /// </summary>
    let Testability = _prefixId.prefix "Testability"
    /// <summary>
    ///   <para>rdfs:label : Time behaviour^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/TimeBehaviour">sw-quality:TimeBehaviour</a>
    /// </summary>
    let TimeBehaviour = _prefixId.prefix "TimeBehaviour"
    /// <summary>
    ///   <para>rdfs:label : Transferability^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Transferability">sw-quality:Transferability</a>
    /// </summary>
    let Transferability = _prefixId.prefix "Transferability"
    /// <summary>
    ///   <para>rdfs:label : Transferability compliance^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/TransferabilityCompliance">sw-quality:TransferabilityCompliance</a>
    /// </summary>
    let TransferabilityCompliance = _prefixId.prefix "TransferabilityCompliance"
    /// <summary>
    ///   <para>rdfs:label : Trust^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/Trust">sw-quality:Trust</a>
    /// </summary>
    let Trust = _prefixId.prefix "Trust"
    /// <summary>
    ///   <para>rdfs:label : Usability in use^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/UsabilityInUse">sw-quality:UsabilityInUse</a>
    /// </summary>
    let UsabilityInUse = _prefixId.prefix "UsabilityInUse"
    /// <summary>
    ///   <para>rdfs:label : Usability in use compliance^^xsd:string</para>
    ///   <a href="https://w3id.org/squap/SoftwareQuality/UsabilityInUseCompliance">sw-quality:UsabilityInUseCompliance</a>
    /// </summary>
    let UsabilityInUseCompliance = _prefixId.prefix "UsabilityInUseCompliance"
