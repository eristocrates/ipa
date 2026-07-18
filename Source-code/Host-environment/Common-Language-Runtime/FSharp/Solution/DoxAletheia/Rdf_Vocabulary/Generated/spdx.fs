namespace https.spdx.org.rdf._3._1.terms.slash

open DoxAletheia.Rdf_Vocabulary

module spdx =
    let _namespace_name = "https://spdx.org/rdf/3.1/terms/"

    /// <summary>
    /// Provides information about the creation of the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/CreationInfo"></see></summary>
    let ``Core/CreationInfo`` =
        Namespaced_IRI.parse _namespace_name "Core/CreationInfo" |> NamespacedName

    /// <summary>
    /// Identifies when the Element was originally created.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/created"></see></summary>
    let ``Core/created`` =
        Namespaced_IRI.parse _namespace_name "Core/created" |> NamespacedName

    /// <summary>
    /// Identifies who or what created the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/createdBy"></see></summary>
    let ``Core/createdBy`` =
        Namespaced_IRI.parse _namespace_name "Core/createdBy" |> NamespacedName

    /// <summary>
    /// An Organization representing the SPDX Project.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpdxOrganization"></see></summary>
    let ``Core/SpdxOrganization`` =
        Namespaced_IRI.parse _namespace_name "Core/SpdxOrganization" |> NamespacedName

    /// <summary>
    /// Provides a reference number that can be used to understand how to parse and
    /// interpret an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/specVersion"></see></summary>
    let ``Core/specVersion`` =
        Namespaced_IRI.parse _namespace_name "Core/specVersion" |> NamespacedName

    /// <summary>
    /// A Package that contains AI software or an AI model.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/AIPackage"></see></summary>
    let ``AI/AIPackage`` =
        Namespaced_IRI.parse _namespace_name "AI/AIPackage" |> NamespacedName

    /// <summary>
    /// Refers to any unit of content that can be associated with a distribution of
    /// software.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/Package"></see></summary>
    let ``Software/Package`` =
        Namespaced_IRI.parse _namespace_name "Software/Package" |> NamespacedName

    /// <summary>
    /// Safety risk level.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType"></see></summary>
    let ``AI/SafetyRiskAssessmentType`` =
        Namespaced_IRI.parse _namespace_name "AI/SafetyRiskAssessmentType" |> NamespacedName

    /// <summary>
    /// The highest level of risk posed by an AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/serious"></see></summary>
    let ``AI/SafetyRiskAssessmentType/serious`` =
        Namespaced_IRI.parse _namespace_name "AI/SafetyRiskAssessmentType/serious" |> NamespacedName

    /// <summary>
    /// The second-highest level of risk posed by an AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/high"></see></summary>
    let ``AI/SafetyRiskAssessmentType/high`` =
        Namespaced_IRI.parse _namespace_name "AI/SafetyRiskAssessmentType/high" |> NamespacedName

    /// <summary>
    /// The third-highest level of risk posed by an AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/medium"></see></summary>
    let ``AI/SafetyRiskAssessmentType/medium`` =
        Namespaced_IRI.parse _namespace_name "AI/SafetyRiskAssessmentType/medium" |> NamespacedName

    /// <summary>
    /// Low/no risk is posed by an AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/low"></see></summary>
    let ``AI/SafetyRiskAssessmentType/low`` =
        Namespaced_IRI.parse _namespace_name "AI/SafetyRiskAssessmentType/low" |> NamespacedName

    /// <summary>
    /// Results of general safety risk assessment of the AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/safetyRiskAssessment"></see></summary>
    let ``AI/safetyRiskAssessment`` =
        Namespaced_IRI.parse _namespace_name "AI/safetyRiskAssessment" |> NamespacedName

    /// <summary>
    /// Preprocessing steps applied to the training data before the model training.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/modelDataPreprocessing"></see></summary>
    let ``AI/modelDataPreprocessing`` =
        Namespaced_IRI.parse _namespace_name "AI/modelDataPreprocessing" |> NamespacedName

    /// <summary>
    /// Type of the model used in the AI software.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/typeOfModel"></see></summary>
    let ``AI/typeOfModel`` =
        Namespaced_IRI.parse _namespace_name "AI/typeOfModel" |> NamespacedName

    /// <summary>
    /// Information about the AI software, not including the model description.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/informationAboutApplication"></see></summary>
    let ``AI/informationAboutApplication`` =
        Namespaced_IRI.parse _namespace_name "AI/informationAboutApplication" |> NamespacedName

    /// <summary>
    /// Information about different steps of the training process.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/informationAboutTraining"></see></summary>
    let ``AI/informationAboutTraining`` =
        Namespaced_IRI.parse _namespace_name "AI/informationAboutTraining" |> NamespacedName

    /// <summary>
    /// Limitation of the AI software.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/limitation"></see></summary>
    let ``AI/limitation`` =
        Namespaced_IRI.parse _namespace_name "AI/limitation" |> NamespacedName

    /// <summary>
    /// Categories of presence or absence.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PresenceType"></see></summary>
    let ``Core/PresenceType`` =
        Namespaced_IRI.parse _namespace_name "Core/PresenceType" |> NamespacedName

    /// <summary>
    /// Indicates presence of the field.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PresenceType/yes"></see></summary>
    let ``Core/PresenceType/yes`` =
        Namespaced_IRI.parse _namespace_name "Core/PresenceType/yes" |> NamespacedName

    /// <summary>
    /// Indicates absence of the field.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PresenceType/no"></see></summary>
    let ``Core/PresenceType/no`` =
        Namespaced_IRI.parse _namespace_name "Core/PresenceType/no" |> NamespacedName

    /// <summary>
    /// Makes no assertion about the field.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PresenceType/noAssertion"></see></summary>
    let ``Core/PresenceType/noAssertion`` =
        Namespaced_IRI.parse _namespace_name "Core/PresenceType/noAssertion" |> NamespacedName

    /// <summary>
    /// Records if sensitive personal information is used during model training or
    /// could be used during the inference.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/useSensitivePersonalInformation"></see></summary>
    let ``AI/useSensitivePersonalInformation`` =
        Namespaced_IRI.parse _namespace_name "AI/useSensitivePersonalInformation" |> NamespacedName

    /// <summary>
    /// A key with an associated value.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/DictionaryEntry"></see></summary>
    let ``Core/DictionaryEntry`` =
        Namespaced_IRI.parse _namespace_name "Core/DictionaryEntry" |> NamespacedName

    /// <summary>
    /// Threshold that was used for computation of a metric described in
    /// the metric field.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/metricDecisionThreshold"></see></summary>
    let ``AI/metricDecisionThreshold`` =
        Namespaced_IRI.parse _namespace_name "AI/metricDecisionThreshold" |> NamespacedName

    /// <summary>
    /// Defines the level of automation a system possesses.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel"></see></summary>
    let ``Core/IsoAutomationLevel`` =
        Namespaced_IRI.parse _namespace_name "Core/IsoAutomationLevel" |> NamespacedName

    /// <summary>
    /// Level 6 - Autonomous. The system is capable of modifying its intended domain of use or its goals without external intervention, control or oversight.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/autonomous"></see></summary>
    let ``Core/IsoAutomationLevel/autonomous`` =
        Namespaced_IRI.parse _namespace_name "Core/IsoAutomationLevel/autonomous" |> NamespacedName

    /// <summary>
    /// Level 5 - Full automation. The system is capable of performing its entire mission without external intervention.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/fullAutomation"></see></summary>
    let ``Core/IsoAutomationLevel/fullAutomation`` =
        Namespaced_IRI.parse _namespace_name "Core/IsoAutomationLevel/fullAutomation" |> NamespacedName

    /// <summary>
    /// Level 4 - High automation. The system performs parts of its mission without external intervention.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/highAutomation"></see></summary>
    let ``Core/IsoAutomationLevel/highAutomation`` =
        Namespaced_IRI.parse _namespace_name "Core/IsoAutomationLevel/highAutomation" |> NamespacedName

    /// <summary>
    /// Level 3 - Conditional automation. The system can propose strategies and then automatically execute the approved plan, with an external agent being ready to take over when necessary.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/conditionalAutomation"></see></summary>
    let ``Core/IsoAutomationLevel/conditionalAutomation`` =
        Namespaced_IRI.parse _namespace_name "Core/IsoAutomationLevel/conditionalAutomation" |> NamespacedName

    /// <summary>
    /// Level 2 - Partial automation or task automation. Some sub-functions of the system are fully automated while the system remain under control of an external agent. The system can perform actions for an approved task without requiring the agent's continuous direct control.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/partialAutomation"></see></summary>
    let ``Core/IsoAutomationLevel/partialAutomation`` =
        Namespaced_IRI.parse _namespace_name "Core/IsoAutomationLevel/partialAutomation" |> NamespacedName

    /// <summary>
    /// Level 1 - Assistive automation. The system assists an operator.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/assistiveAutomation"></see></summary>
    let ``Core/IsoAutomationLevel/assistiveAutomation`` =
        Namespaced_IRI.parse _namespace_name "Core/IsoAutomationLevel/assistiveAutomation" |> NamespacedName

    /// <summary>
    /// Level 0 - Not automated. No automation. The operator fully controls the system.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/notAutomated"></see></summary>
    let ``Core/IsoAutomationLevel/notAutomated`` =
        Namespaced_IRI.parse _namespace_name "Core/IsoAutomationLevel/notAutomated" |> NamespacedName

    /// <summary>
    /// ISO level of automation.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/isoAutomationLevel"></see></summary>
    let ``Core/isoAutomationLevel`` =
        Namespaced_IRI.parse _namespace_name "Core/isoAutomationLevel" |> NamespacedName

    /// <summary>
    /// Metric used to evaluate the AI model.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/metric"></see></summary>
    let ``AI/metric`` =
        Namespaced_IRI.parse _namespace_name "AI/metric" |> NamespacedName

    /// <summary>
    /// **DEPRECATED in SPDX 3.1.**
    /// Use [/Core/isoAutomationLevel](../../Core/Properties/isoAutomationLevel.md)
    /// instead.
    ///
    /// Indicates whether the system can perform a decision or action without human
    /// involvement or guidance.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/autonomyType"></see></summary>
    let ``AI/autonomyType`` =
        Namespaced_IRI.parse _namespace_name "AI/autonomyType" |> NamespacedName

    /// <summary>
    /// Hyperparameter used to build the AI model contained in the AI package.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/hyperparameter"></see></summary>
    let ``AI/hyperparameter`` =
        Namespaced_IRI.parse _namespace_name "AI/hyperparameter" |> NamespacedName

    /// <summary>
    /// A class for describing the energy consumption incurred by an AI model in
    /// different stages of its lifecycle.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/EnergyConsumption"></see></summary>
    let ``AI/EnergyConsumption`` =
        Namespaced_IRI.parse _namespace_name "AI/EnergyConsumption" |> NamespacedName

    /// <summary>
    /// Energy consumption incurred by an AI model.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/energyConsumption"></see></summary>
    let ``AI/energyConsumption`` =
        Namespaced_IRI.parse _namespace_name "AI/energyConsumption" |> NamespacedName

    /// <summary>
    /// Standard that an artifact is being complied with.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/standardCompliance"></see></summary>
    let ``AI/standardCompliance`` =
        Namespaced_IRI.parse _namespace_name "AI/standardCompliance" |> NamespacedName

    /// <summary>
    /// Methods that can be used to explain the results from the AI model.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/modelExplainability"></see></summary>
    let ``AI/modelExplainability`` =
        Namespaced_IRI.parse _namespace_name "AI/modelExplainability" |> NamespacedName

    /// <summary>
    /// Domain in which the AI package can be used.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/domain"></see></summary>
    let ``AI/domain`` =
        Namespaced_IRI.parse _namespace_name "AI/domain" |> NamespacedName

    /// <summary>
    /// The class that helps note down the quantity of energy consumption and the unit
    /// used for measurement.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/EnergyConsumptionDescription"></see></summary>
    let ``AI/EnergyConsumptionDescription`` =
        Namespaced_IRI.parse _namespace_name "AI/EnergyConsumptionDescription" |> NamespacedName

    /// <summary>
    /// Energy consumed when finetuning the AI model that is
    /// being used in the AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/finetuningEnergyConsumption"></see></summary>
    let ``AI/finetuningEnergyConsumption`` =
        Namespaced_IRI.parse _namespace_name "AI/finetuningEnergyConsumption" |> NamespacedName

    /// <summary>
    /// Energy consumed when training the AI model that is
    /// being used in the AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/trainingEnergyConsumption"></see></summary>
    let ``AI/trainingEnergyConsumption`` =
        Namespaced_IRI.parse _namespace_name "AI/trainingEnergyConsumption" |> NamespacedName

    /// <summary>
    /// Energy consumed during inference time by an AI model
    /// that is being used in the AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/inferenceEnergyConsumption"></see></summary>
    let ``AI/inferenceEnergyConsumption`` =
        Namespaced_IRI.parse _namespace_name "AI/inferenceEnergyConsumption" |> NamespacedName

    /// <summary>
    /// Unit of energy consumption.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType"></see></summary>
    let ``AI/EnergyUnitType`` =
        Namespaced_IRI.parse _namespace_name "AI/EnergyUnitType" |> NamespacedName

    /// <summary>
    /// Kilowatt-hour.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/kilowattHour"></see></summary>
    let ``AI/EnergyUnitType/kilowattHour`` =
        Namespaced_IRI.parse _namespace_name "AI/EnergyUnitType/kilowattHour" |> NamespacedName

    /// <summary>
    /// Megajoule.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/megajoule"></see></summary>
    let ``AI/EnergyUnitType/megajoule`` =
        Namespaced_IRI.parse _namespace_name "AI/EnergyUnitType/megajoule" |> NamespacedName

    /// <summary>
    /// Any other units of energy measurement.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/other"></see></summary>
    let ``AI/EnergyUnitType/other`` =
        Namespaced_IRI.parse _namespace_name "AI/EnergyUnitType/other" |> NamespacedName

    /// <summary>
    /// Unit in which energy is measured.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/energyUnit"></see></summary>
    let ``AI/energyUnit`` =
        Namespaced_IRI.parse _namespace_name "AI/energyUnit" |> NamespacedName

    /// <summary>
    /// Energy quantity.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/energyQuantity"></see></summary>
    let ``AI/energyQuantity`` =
        Namespaced_IRI.parse _namespace_name "AI/energyQuantity" |> NamespacedName

    /// <summary>
    /// Class that describes a build instance of software/artifacts.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/Build"></see></summary>
    let ``Build/Build`` =
        Namespaced_IRI.parse _namespace_name "Build/Build" |> NamespacedName

    /// <summary>
    /// Base domain class from which all other SPDX 3 domain classes derive.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Element"></see></summary>
    let ``Core/Element`` =
        Namespaced_IRI.parse _namespace_name "Core/Element" |> NamespacedName

    /// <summary>
    /// Property describing a parameter used in an instance of a build.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/parameter"></see></summary>
    let ``Build/parameter`` =
        Namespaced_IRI.parse _namespace_name "Build/parameter" |> NamespacedName

    /// <summary>
    /// Property describing the session in which a build is invoked.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/environment"></see></summary>
    let ``Build/environment`` =
        Namespaced_IRI.parse _namespace_name "Build/environment" |> NamespacedName

    /// <summary>
    /// Property describes the invocation entrypoint of a build.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/configSourceEntrypoint"></see></summary>
    let ``Build/configSourceEntrypoint`` =
        Namespaced_IRI.parse _namespace_name "Build/configSourceEntrypoint" |> NamespacedName

    /// <summary>
    /// A buildId is a locally unique identifier used by a builder to identify a unique
    /// instance of a build produced by it.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/buildId"></see></summary>
    let ``Build/buildId`` =
        Namespaced_IRI.parse _namespace_name "Build/buildId" |> NamespacedName

    /// <summary>
    /// A buildType is a hint that is used to indicate the toolchain, platform, or
    /// infrastructure that the build was invoked on.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/buildType"></see></summary>
    let ``Build/buildType`` =
        Namespaced_IRI.parse _namespace_name "Build/buildType" |> NamespacedName

    /// <summary>
    /// Property that describes the URI of the build configuration source file.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/configSourceUri"></see></summary>
    let ``Build/configSourceUri`` =
        Namespaced_IRI.parse _namespace_name "Build/configSourceUri" |> NamespacedName

    /// <summary>
    /// Property describing the start time of a build.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/buildStartTime"></see></summary>
    let ``Build/buildStartTime`` =
        Namespaced_IRI.parse _namespace_name "Build/buildStartTime" |> NamespacedName

    /// <summary>
    /// A mathematically calculated representation of a grouping of data.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Hash"></see></summary>
    let ``Core/Hash`` =
        Namespaced_IRI.parse _namespace_name "Core/Hash" |> NamespacedName

    /// <summary>
    /// Property that describes the digest of the build configuration file used to
    /// invoke a build.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/configSourceDigest"></see></summary>
    let ``Build/configSourceDigest`` =
        Namespaced_IRI.parse _namespace_name "Build/configSourceDigest" |> NamespacedName

    /// <summary>
    /// Property that describes the time at which a build stops.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/buildEndTime"></see></summary>
    let ``Build/buildEndTime`` =
        Namespaced_IRI.parse _namespace_name "Build/buildEndTime" |> NamespacedName

    /// <summary>
    /// Class that describes an action that has occurred.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Action"></see></summary>
    let ``Core/Action`` =
        Namespaced_IRI.parse _namespace_name "Core/Action" |> NamespacedName

    /// <summary>
    /// A distinct article or unit within the domain.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Artifact"></see></summary>
    let ``Core/Artifact`` =
        Namespaced_IRI.parse _namespace_name "Core/Artifact" |> NamespacedName

    /// <summary>
    /// Property describing the start time of an action.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/actionStartTime"></see></summary>
    let ``Core/actionStartTime`` =
        Namespaced_IRI.parse _namespace_name "Core/actionStartTime" |> NamespacedName

    /// <summary>
    /// Additional relevance information.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/additionalInformation"></see></summary>
    let ``Core/additionalInformation`` =
        Namespaced_IRI.parse _namespace_name "Core/additionalInformation" |> NamespacedName

    /// <summary>
    /// Property that describes the time at which an action stops.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/actionEndTime"></see></summary>
    let ``Core/actionEndTime`` =
        Namespaced_IRI.parse _namespace_name "Core/actionEndTime" |> NamespacedName

    /// <summary>
    /// Location is used to define the location, address or coordinates of a place.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Location"></see></summary>
    let ``Core/Location`` =
        Namespaced_IRI.parse _namespace_name "Core/Location" |> NamespacedName

    /// <summary>
    /// Location of a specific action.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/actionLocation"></see></summary>
    let ``Core/actionLocation`` =
        Namespaced_IRI.parse _namespace_name "Core/actionLocation" |> NamespacedName

    /// <summary>
    /// Agent represents anything with the potential to act on a system.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Agent"></see></summary>
    let ``Core/Agent`` =
        Namespaced_IRI.parse _namespace_name "Core/Agent" |> NamespacedName

    /// <summary>
    /// An assertion made in relation to one or more elements.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Annotation"></see></summary>
    let ``Core/Annotation`` =
        Namespaced_IRI.parse _namespace_name "Core/Annotation" |> NamespacedName

    /// <summary>
    /// Commentary on an assertion that an annotator has made.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/statement"></see></summary>
    let ``Core/statement`` =
        Namespaced_IRI.parse _namespace_name "Core/statement" |> NamespacedName

    /// <summary>
    /// Provides information about the content type of an Element or a property.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/contentType"></see></summary>
    let ``Core/contentType`` =
        Namespaced_IRI.parse _namespace_name "Core/contentType" |> NamespacedName

    /// <summary>
    /// Specifies the type of an annotation.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/AnnotationType"></see></summary>
    let ``Core/AnnotationType`` =
        Namespaced_IRI.parse _namespace_name "Core/AnnotationType" |> NamespacedName

    /// <summary>
    /// Used to store extra information about an Element which is not part of a review (e.g. extra information provided during the creation of the Element).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/AnnotationType/other"></see></summary>
    let ``Core/AnnotationType/other`` =
        Namespaced_IRI.parse _namespace_name "Core/AnnotationType/other" |> NamespacedName

    /// <summary>
    /// Used when someone reviews the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/AnnotationType/review"></see></summary>
    let ``Core/AnnotationType/review`` =
        Namespaced_IRI.parse _namespace_name "Core/AnnotationType/review" |> NamespacedName

    /// <summary>
    /// Describes the type of annotation.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/annotationType"></see></summary>
    let ``Core/annotationType`` =
        Namespaced_IRI.parse _namespace_name "Core/annotationType" |> NamespacedName

    /// <summary>
    /// An Element an annotator has made an assertion about.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/subject"></see></summary>
    let ``Core/subject`` =
        Namespaced_IRI.parse _namespace_name "Core/subject" |> NamespacedName

    /// <summary>
    /// Specifies the time an artifact was built.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/builtTime"></see></summary>
    let ``Core/builtTime`` =
        Namespaced_IRI.parse _namespace_name "Core/builtTime" |> NamespacedName

    /// <summary>
    /// Identifies who or what supplied the artifact or VulnAssessmentRelationship
    /// referenced by the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/suppliedBy"></see></summary>
    let ``Core/suppliedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/suppliedBy" |> NamespacedName

    /// <summary>
    /// Specifies until when the artifact can be used before its usage needs to be
    /// reassessed.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/validUntilTime"></see></summary>
    let ``Core/validUntilTime`` =
        Namespaced_IRI.parse _namespace_name "Core/validUntilTime" |> NamespacedName

    /// <summary>
    /// The intendedUse property is designed to capture a summary of how or for what item or artifact is meant to be used for.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/intendedUse"></see></summary>
    let ``Core/intendedUse`` =
        Namespaced_IRI.parse _namespace_name "Core/intendedUse" |> NamespacedName

    /// <summary>
    /// Identifies from where or whom the Element originally came.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/originatedBy"></see></summary>
    let ``Core/originatedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/originatedBy" |> NamespacedName

    /// <summary>
    /// The name of a relevant standard that may apply to an artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/standardName"></see></summary>
    let ``Core/standardName`` =
        Namespaced_IRI.parse _namespace_name "Core/standardName" |> NamespacedName

    /// <summary>
    /// Specifies the time an artifact was released.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/releaseTime"></see></summary>
    let ``Core/releaseTime`` =
        Namespaced_IRI.parse _namespace_name "Core/releaseTime" |> NamespacedName

    /// <summary>
    /// Type of support that is associated with an artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType"></see></summary>
    let ``Core/SupportType`` =
        Namespaced_IRI.parse _namespace_name "Core/SupportType" |> NamespacedName

    /// <summary>
    /// The artifact is in active development and is not considered ready for formal support from the supplier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/development"></see></summary>
    let ``Core/SupportType/development`` =
        Namespaced_IRI.parse _namespace_name "Core/SupportType/development" |> NamespacedName

    /// <summary>
    /// The artifact has been released, and is supported from the supplier. There is a validUntilDate that can provide additional information about the duration of support.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/support"></see></summary>
    let ``Core/SupportType/support`` =
        Namespaced_IRI.parse _namespace_name "Core/SupportType/support" |> NamespacedName

    /// <summary>
    /// In addition to being supported by the supplier, the software is known to have been deployed and is in use. For a software as a service provider, this implies the software is now available as a service.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/deployed"></see></summary>
    let ``Core/SupportType/deployed`` =
        Namespaced_IRI.parse _namespace_name "Core/SupportType/deployed" |> NamespacedName

    /// <summary>
    /// The artifact has been released, and there is limited support available from the supplier. There is a validUntilDate that can provide additional information about the duration of support.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/limitedSupport"></see></summary>
    let ``Core/SupportType/limitedSupport`` =
        Namespaced_IRI.parse _namespace_name "Core/SupportType/limitedSupport" |> NamespacedName

    /// <summary>
    /// There is a defined end of support for the artifact from the supplier. This may also be referred to as end of life. There is a validUntilDate that can be used to signal when support ends for the artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/endOfSupport"></see></summary>
    let ``Core/SupportType/endOfSupport`` =
        Namespaced_IRI.parse _namespace_name "Core/SupportType/endOfSupport" |> NamespacedName

    /// <summary>
    /// There is no support for the artifact from the supplier, consumer assumes any support obligations.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/noSupport"></see></summary>
    let ``Core/SupportType/noSupport`` =
        Namespaced_IRI.parse _namespace_name "Core/SupportType/noSupport" |> NamespacedName

    /// <summary>
    /// No assertion about the type of support is made. This is considered the default if no other support type is used.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/noAssertion"></see></summary>
    let ``Core/SupportType/noAssertion`` =
        Namespaced_IRI.parse _namespace_name "Core/SupportType/noAssertion" |> NamespacedName

    /// <summary>
    /// Specifies the level of support associated with an artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/supportLevel"></see></summary>
    let ``Core/supportLevel`` =
        Namespaced_IRI.parse _namespace_name "Core/supportLevel" |> NamespacedName

    /// <summary>
    /// A container for a grouping of SPDX 3 content characterizing details
    /// (provenance, composition, licensing, etc.) about a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Bom"></see></summary>
    let ``Core/Bom`` = Namespaced_IRI.parse _namespace_name "Core/Bom" |> NamespacedName

    /// <summary>
    /// A collection of Elements that have a shared context.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Bundle"></see></summary>
    let ``Core/Bundle`` =
        Namespaced_IRI.parse _namespace_name "Core/Bundle" |> NamespacedName

    /// <summary>
    /// A collection of Elements, not necessarily with unifying context.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ElementCollection"></see></summary>
    let ``Core/ElementCollection`` =
        Namespaced_IRI.parse _namespace_name "Core/ElementCollection" |> NamespacedName

    /// <summary>
    /// Gives information about the circumstances or unifying properties
    /// that Elements of the bundle have been assembled under.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/context"></see></summary>
    let ``Core/context`` =
        Namespaced_IRI.parse _namespace_name "Core/context" |> NamespacedName

    /// <summary>
    /// A contact point from an Artifact to an Agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationship"></see></summary>
    let ``Core/ContactPointRelationship`` =
        Namespaced_IRI.parse _namespace_name "Core/ContactPointRelationship" |> NamespacedName

    /// <summary>
    /// Describes a relationship between one or more elements.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Relationship"></see></summary>
    let ``Core/Relationship`` =
        Namespaced_IRI.parse _namespace_name "Core/Relationship" |> NamespacedName

    /// <summary>
    /// Information about the type of contact point for `ContactPointRelationship`s.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType"></see></summary>
    let ``Core/ContactPointRelationshipType`` =
        Namespaced_IRI.parse _namespace_name "Core/ContactPointRelationshipType" |> NamespacedName

    /// <summary>
    /// A contact point for compliance (i.e. export control, licensing).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/compliance"></see></summary>
    let ``Core/ContactPointRelationshipType/compliance`` =
        Namespaced_IRI.parse _namespace_name "Core/ContactPointRelationshipType/compliance" |> NamespacedName

    /// <summary>
    /// A generic contact point to be used when the contact type does not match any of the other options.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/other"></see></summary>
    let ``Core/ContactPointRelationshipType/other`` =
        Namespaced_IRI.parse _namespace_name "Core/ContactPointRelationshipType/other" |> NamespacedName

    /// <summary>
    /// A contact for reporting security vulnerabilities.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/securityVulnerability"></see></summary>
    let ``Core/ContactPointRelationshipType/securityVulnerability`` =
        Namespaced_IRI.parse _namespace_name "Core/ContactPointRelationshipType/securityVulnerability" |> NamespacedName

    /// <summary>
    /// A contact point for support.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/support"></see></summary>
    let ``Core/ContactPointRelationshipType/support`` =
        Namespaced_IRI.parse _namespace_name "Core/ContactPointRelationshipType/support" |> NamespacedName

    /// <summary>
    /// Identifies the nature of the contactPointRelationship.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/contactType"></see></summary>
    let ``Core/contactType`` =
        Namespaced_IRI.parse _namespace_name "Core/contactType" |> NamespacedName

    /// <summary>
    /// Provide consumers with comments by the creator of the Element about the
    /// Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/comment"></see></summary>
    let ``Core/comment`` =
        Namespaced_IRI.parse _namespace_name "Core/comment" |> NamespacedName

    /// <summary>
    /// An element of hardware and/or software utilized to carry out a particular function.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Tool"></see></summary>
    let ``Core/Tool`` =
        Namespaced_IRI.parse _namespace_name "Core/Tool" |> NamespacedName

    /// <summary>
    /// Identifies the tooling that was used during the creation of the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/createdUsing"></see></summary>
    let ``Core/createdUsing`` =
        Namespaced_IRI.parse _namespace_name "Core/createdUsing" |> NamespacedName

    /// <summary>
    /// Class that describes a process.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/DefinedProcess"></see></summary>
    let ``Core/DefinedProcess`` =
        Namespaced_IRI.parse _namespace_name "Core/DefinedProcess" |> NamespacedName

    /// <summary>
    /// Defines the version of a specific process.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/processVersion"></see></summary>
    let ``Core/processVersion`` =
        Namespaced_IRI.parse _namespace_name "Core/processVersion" |> NamespacedName

    /// <summary>
    /// The ProcessReadinessType is defined by the enumeration.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType"></see></summary>
    let ``Core/ProcessReadinessType`` =
        Namespaced_IRI.parse _namespace_name "Core/ProcessReadinessType" |> NamespacedName

    /// <summary>
    /// in production
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/draft"></see></summary>
    let ``Core/ProcessReadinessType/draft`` =
        Namespaced_IRI.parse _namespace_name "Core/ProcessReadinessType/draft" |> NamespacedName

    /// <summary>
    /// in use
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/active"></see></summary>
    let ``Core/ProcessReadinessType/active`` =
        Namespaced_IRI.parse _namespace_name "Core/ProcessReadinessType/active" |> NamespacedName

    /// <summary>
    /// superseded or not valid at present
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/obsolete"></see></summary>
    let ``Core/ProcessReadinessType/obsolete`` =
        Namespaced_IRI.parse _namespace_name "Core/ProcessReadinessType/obsolete" |> NamespacedName

    /// <summary>
    /// other
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/other"></see></summary>
    let ``Core/ProcessReadinessType/other`` =
        Namespaced_IRI.parse _namespace_name "Core/ProcessReadinessType/other" |> NamespacedName

    /// <summary>
    /// processReadiness describes the readiness of a process.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/processReadiness"></see></summary>
    let ``Core/processReadiness`` =
        Namespaced_IRI.parse _namespace_name "Core/processReadiness" |> NamespacedName

    /// <summary>
    /// The reason a process exists.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/processRationale"></see></summary>
    let ``Core/processRationale`` =
        Namespaced_IRI.parse _namespace_name "Core/processRationale" |> NamespacedName

    /// <summary>
    /// The DefinedType class associates a specific type with its defined source.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/DefinedType"></see></summary>
    let ``Core/DefinedType`` =
        Namespaced_IRI.parse _namespace_name "Core/DefinedType" |> NamespacedName

    /// <summary>
    /// A specification is a detailed description of the design, requirements,
    /// or features of a product, process, or system.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Specification"></see></summary>
    let ``Core/Specification`` =
        Namespaced_IRI.parse _namespace_name "Core/Specification" |> NamespacedName

    /// <summary>
    /// It is the authoritative or credible entity, document, or body of knowledge that provides the meaning of a type, ensuring accuracy, context, and standardization.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/definitionSource"></see></summary>
    let ``Core/definitionSource`` =
        Namespaced_IRI.parse _namespace_name "Core/definitionSource" |> NamespacedName

    /// <summary>
    /// typeFromSource is a value used to define an item within the definitionSource.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/typeFromSource"></see></summary>
    let ``Core/typeFromSource`` =
        Namespaced_IRI.parse _namespace_name "Core/typeFromSource" |> NamespacedName

    /// <summary>
    /// A key used in a generic key-value pair.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/key"></see></summary>
    let ``Core/key`` = Namespaced_IRI.parse _namespace_name "Core/key" |> NamespacedName

    /// <summary>
    /// A value used in a generic key-value pair.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/value"></see></summary>
    let ``Core/value`` =
        Namespaced_IRI.parse _namespace_name "Core/value" |> NamespacedName

    /// <summary>
    /// A reference to a resource outside the scope of SPDX 3 content related to an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRef"></see></summary>
    let ``Core/ExternalRef`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRef" |> NamespacedName

    /// <summary>
    /// Points to a resource outside the scope of the SPDX 3 content
    /// that provides additional characteristics of an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/externalRef"></see></summary>
    let ``Core/externalRef`` =
        Namespaced_IRI.parse _namespace_name "Core/externalRef" |> NamespacedName

    /// <summary>
    /// Provides information about the creation of the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/creationInfo"></see></summary>
    let ``Core/creationInfo`` =
        Namespaced_IRI.parse _namespace_name "Core/creationInfo" |> NamespacedName

    /// <summary>
    /// Provides an independently reproducible mechanism that permits verification of a specific Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IntegrityMethod"></see></summary>
    let ``Core/IntegrityMethod`` =
        Namespaced_IRI.parse _namespace_name "Core/IntegrityMethod" |> NamespacedName

    /// <summary>
    /// Provides an IntegrityMethod with which the integrity of an Element can be
    /// asserted.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/verifiedUsing"></see></summary>
    let ``Core/verifiedUsing`` =
        Namespaced_IRI.parse _namespace_name "Core/verifiedUsing" |> NamespacedName

    /// <summary>
    /// A short description of an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/summary"></see></summary>
    let ``Core/summary`` =
        Namespaced_IRI.parse _namespace_name "Core/summary" |> NamespacedName

    /// <summary>
    /// Identifies the name of an Element as designated by the creator.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/name"></see></summary>
    let ``Core/name`` =
        Namespaced_IRI.parse _namespace_name "Core/name" |> NamespacedName

    /// <summary>
    /// A reference to a resource identifier defined outside the scope of SPDX 3 content that uniquely identifies an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifier"></see></summary>
    let ``Core/ExternalIdentifier`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifier" |> NamespacedName

    /// <summary>
    /// Provides a reference to a resource outside the scope of SPDX 3 content
    /// that uniquely identifies an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/externalIdentifier"></see></summary>
    let ``Core/externalIdentifier`` =
        Namespaced_IRI.parse _namespace_name "Core/externalIdentifier" |> NamespacedName

    /// <summary>
    /// Provides a detailed description of the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/description"></see></summary>
    let ``Core/description`` =
        Namespaced_IRI.parse _namespace_name "Core/description" |> NamespacedName

    /// <summary>
    /// RequirementVerification class defines the base properties of a verification.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/RequirementVerification"></see></summary>
    let ``FunctionalSafety/RequirementVerification`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/RequirementVerification" |> NamespacedName

    /// <summary>
    /// EvidenceRelationship defines the association between pieces of evidence and EvaluationResult.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceRelationship"></see></summary>
    let ``FunctionalSafety/EvidenceRelationship`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/EvidenceRelationship" |> NamespacedName

    /// <summary>
    /// EvaluationResult is the result of an evaluation.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResult"></see></summary>
    let ``FunctionalSafety/EvaluationResult`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/EvaluationResult" |> NamespacedName

    /// <summary>
    /// Provides an SSVC assessment for a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/SsvcVulnAssessmentRelationship"></see></summary>
    let ``Security/SsvcVulnAssessmentRelationship`` =
        Namespaced_IRI.parse _namespace_name "Security/SsvcVulnAssessmentRelationship" |> NamespacedName

    /// <summary>
    /// Provides a CVSS version 2.0 assessment for a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssV2VulnAssessmentRelationship"></see></summary>
    let ``Security/CvssV2VulnAssessmentRelationship`` =
        Namespaced_IRI.parse _namespace_name "Security/CvssV2VulnAssessmentRelationship" |> NamespacedName

    /// <summary>
    /// Provides an exploit assessment of a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogVulnAssessmentRelationship"></see></summary>
    let ``Security/ExploitCatalogVulnAssessmentRelationship`` =
        Namespaced_IRI.parse _namespace_name "Security/ExploitCatalogVulnAssessmentRelationship" |> NamespacedName

    /// <summary>
    /// Provides a CVSS version 4 assessment for a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssV4VulnAssessmentRelationship"></see></summary>
    let ``Security/CvssV4VulnAssessmentRelationship`` =
        Namespaced_IRI.parse _namespace_name "Security/CvssV4VulnAssessmentRelationship" |> NamespacedName

    /// <summary>
    /// Connects a vulnerability and an element designating the element as a product
    /// affected by the vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexAffectedVulnAssessmentRelationship"></see></summary>
    let ``Security/VexAffectedVulnAssessmentRelationship`` =
        Namespaced_IRI.parse _namespace_name "Security/VexAffectedVulnAssessmentRelationship" |> NamespacedName

    /// <summary>
    /// Links a vulnerability and one or more elements designating the latter as products
    /// not affected by the vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexNotAffectedVulnAssessmentRelationship"></see></summary>
    let ``Security/VexNotAffectedVulnAssessmentRelationship`` =
        Namespaced_IRI.parse _namespace_name "Security/VexNotAffectedVulnAssessmentRelationship" |> NamespacedName

    /// <summary>
    /// Provides a CVSS version 3 assessment for a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssV3VulnAssessmentRelationship"></see></summary>
    let ``Security/CvssV3VulnAssessmentRelationship`` =
        Namespaced_IRI.parse _namespace_name "Security/CvssV3VulnAssessmentRelationship" |> NamespacedName

    /// <summary>
    /// Specifies a vulnerability and its associated information.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/Vulnerability"></see></summary>
    let ``Security/Vulnerability`` =
        Namespaced_IRI.parse _namespace_name "Security/Vulnerability" |> NamespacedName

    /// <summary>
    /// Designates elements as products where the impact of a vulnerability is being
    /// investigated.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexUnderInvestigationVulnAssessmentRelationship"></see></summary>
    let ``Security/VexUnderInvestigationVulnAssessmentRelationship`` =
        Namespaced_IRI.parse _namespace_name "Security/VexUnderInvestigationVulnAssessmentRelationship" |> NamespacedName

    /// <summary>
    /// Provides an EPSS assessment for a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/EpssVulnAssessmentRelationship"></see></summary>
    let ``Security/EpssVulnAssessmentRelationship`` =
        Namespaced_IRI.parse _namespace_name "Security/EpssVulnAssessmentRelationship" |> NamespacedName

    /// <summary>
    /// Links a vulnerability and elements representing products (in the VEX sense) where
    /// a fix has been applied and are no longer affected.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexFixedVulnAssessmentRelationship"></see></summary>
    let ``Security/VexFixedVulnAssessmentRelationship`` =
        Namespaced_IRI.parse _namespace_name "Security/VexFixedVulnAssessmentRelationship" |> NamespacedName

    /// <summary>
    /// A mapping between prefixes and namespace partial URIs.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/NamespaceMap"></see></summary>
    let ``Core/NamespaceMap`` =
        Namespaced_IRI.parse _namespace_name "Core/NamespaceMap" |> NamespacedName

    /// <summary>
    /// Provide context for a relationship that occurs in the lifecycle.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopedRelationship"></see></summary>
    let ``Core/LifecycleScopedRelationship`` =
        Namespaced_IRI.parse _namespace_name "Core/LifecycleScopedRelationship" |> NamespacedName

    /// <summary>
    /// A key with an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ElementMap"></see></summary>
    let ``Core/ElementMap`` =
        Namespaced_IRI.parse _namespace_name "Core/ElementMap" |> NamespacedName

    /// <summary>
    /// Describes how an Agent provides support for an Artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportRelationship"></see></summary>
    let ``Core/SupportRelationship`` =
        Namespaced_IRI.parse _namespace_name "Core/SupportRelationship" |> NamespacedName

    /// <summary>
    /// The measure of length refers to the dimension of an object or space that describes how long it is, typically expressed in various units depending on the system of measurement being used.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/MeasureOfLength"></see></summary>
    let ``Core/MeasureOfLength`` =
        Namespaced_IRI.parse _namespace_name "Core/MeasureOfLength" |> NamespacedName

    /// <summary>
    /// A concrete subclass of Element used by Individuals in the
    /// Core profile.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IndividualElement"></see></summary>
    let ``Core/IndividualElement`` =
        Namespaced_IRI.parse _namespace_name "Core/IndividualElement" |> NamespacedName

    /// <summary>
    /// UnitofMeasure specify information structures through industry standards for Units of Measure, Quantity Kinds, Dimensions and Data Types.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/UnitOfMeasure"></see></summary>
    let ``Core/UnitOfMeasure`` =
        Namespaced_IRI.parse _namespace_name "Core/UnitOfMeasure" |> NamespacedName

    /// <summary>
    /// A tuple of two positive integers that define a range.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PositiveIntegerRange"></see></summary>
    let ``Core/PositiveIntegerRange`` =
        Namespaced_IRI.parse _namespace_name "Core/PositiveIntegerRange" |> NamespacedName

    /// <summary>
    /// A map of Element identifiers that are used within an SpdxDocument but defined
    /// external to that SpdxDocument.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalMap"></see></summary>
    let ``Core/ExternalMap`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalMap" |> NamespacedName

    /// <summary>
    /// A collection of SPDX Elements that could potentially be serialized.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpdxDocument"></see></summary>
    let ``Core/SpdxDocument`` =
        Namespaced_IRI.parse _namespace_name "Core/SpdxDocument" |> NamespacedName

    /// <summary>
    /// An individual human being.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Person"></see></summary>
    let ``Core/Person`` =
        Namespaced_IRI.parse _namespace_name "Core/Person" |> NamespacedName

    /// <summary>
    /// A group of people who work together in an organized way for a shared purpose.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Organization"></see></summary>
    let ``Core/Organization`` =
        Namespaced_IRI.parse _namespace_name "Core/Organization" |> NamespacedName

    /// <summary>
    /// The measure of mass refers to the quantity of matter in an object or substance.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/MeasureOfMass"></see></summary>
    let ``Core/MeasureOfMass`` =
        Namespaced_IRI.parse _namespace_name "Core/MeasureOfMass" |> NamespacedName

    /// <summary>
    /// A distinct unit representing a requirement, as used in systems, software, and hardware engineering.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Requirement"></see></summary>
    let ``Core/Requirement`` =
        Namespaced_IRI.parse _namespace_name "Core/Requirement" |> NamespacedName

    /// <summary>
    /// A software agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SoftwareAgent"></see></summary>
    let ``Core/SoftwareAgent`` =
        Namespaced_IRI.parse _namespace_name "Core/SoftwareAgent" |> NamespacedName

    /// <summary>
    /// An SPDX version 2.X compatible verification method for software packages.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PackageVerificationCode"></see></summary>
    let ``Core/PackageVerificationCode`` =
        Namespaced_IRI.parse _namespace_name "Core/PackageVerificationCode" |> NamespacedName

    /// <summary>
    /// A physical location is a tangible, geographically identifiable place where objects, people, or assets exist or operate.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PhysicalLocation"></see></summary>
    let ``Core/PhysicalLocation`` =
        Namespaced_IRI.parse _namespace_name "Core/PhysicalLocation" |> NamespacedName

    /// <summary>
    /// Regulation represents a rule or directive maintained by an authority.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Regulation"></see></summary>
    let ``Core/Regulation`` =
        Namespaced_IRI.parse _namespace_name "Core/Regulation" |> NamespacedName

    /// <summary>
    /// A Package that contains a dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetPackage"></see></summary>
    let ``Dataset/DatasetPackage`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetPackage" |> NamespacedName

    /// <summary>
    /// A license that is not listed on the SPDX License List.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/CustomLicense"></see></summary>
    let ``ExpandedLicensing/CustomLicense`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/CustomLicense" |> NamespacedName

    /// <summary>
    /// Portion of an AnyLicenseInfo representing this version, or any later version,
    /// of the indicated License.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/OrLaterOperator"></see></summary>
    let ``ExpandedLicensing/OrLaterOperator`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/OrLaterOperator" |> NamespacedName

    /// <summary>
    /// A license that is listed on the SPDX License List.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ListedLicense"></see></summary>
    let ``ExpandedLicensing/ListedLicense`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/ListedLicense" |> NamespacedName

    /// <summary>
    /// Portion of an AnyLicenseInfo representing a set of licensing information where
    /// only one of the elements applies.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/DisjunctiveLicenseSet"></see></summary>
    let ``ExpandedLicensing/DisjunctiveLicenseSet`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/DisjunctiveLicenseSet" |> NamespacedName

    /// <summary>
    /// A license exception that is listed on the SPDX Exceptions list.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ListedLicenseException"></see></summary>
    let ``ExpandedLicensing/ListedLicenseException`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/ListedLicenseException" |> NamespacedName

    /// <summary>
    /// Portion of an AnyLicenseInfo representing a License which has additional
    /// text applied to it.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/WithAdditionOperator"></see></summary>
    let ``ExpandedLicensing/WithAdditionOperator`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/WithAdditionOperator" |> NamespacedName

    /// <summary>
    /// A concrete subclass of AnyLicenseInfo used by Individuals in the
    /// ExpandedLicensing profile.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/IndividualLicensingInfo"></see></summary>
    let ``ExpandedLicensing/IndividualLicensingInfo`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/IndividualLicensingInfo" |> NamespacedName

    /// <summary>
    /// A license addition that is not listed on the SPDX Exceptions List.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/CustomLicenseAddition"></see></summary>
    let ``ExpandedLicensing/CustomLicenseAddition`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/CustomLicenseAddition" |> NamespacedName

    /// <summary>
    /// Portion of an AnyLicenseInfo representing a set of licensing information
    /// where all elements apply.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ConjunctiveLicenseSet"></see></summary>
    let ``ExpandedLicensing/ConjunctiveLicenseSet`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/ConjunctiveLicenseSet" |> NamespacedName

    /// <summary>
    /// An SPDX Element containing an SPDX license expression string.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/LicenseExpression"></see></summary>
    let ``SimpleLicensing/LicenseExpression`` =
        Namespaced_IRI.parse _namespace_name "SimpleLicensing/LicenseExpression" |> NamespacedName

    /// <summary>
    /// A license or addition that is not listed on the SPDX License List.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/SimpleLicensingText"></see></summary>
    let ``SimpleLicensing/SimpleLicensingText`` =
        Namespaced_IRI.parse _namespace_name "SimpleLicensing/SimpleLicensingText" |> NamespacedName

    /// <summary>
    /// A property name with an associated value.
    /// <see href="https://spdx.org/rdf/3.1/terms/Extension/CdxPropertyEntry"></see></summary>
    let ``Extension/CdxPropertyEntry`` =
        Namespaced_IRI.parse _namespace_name "Extension/CdxPropertyEntry" |> NamespacedName

    /// <summary>
    /// Temporary endeavor with a beginning and an end and that must be used to create a unique product, service or result.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/Project"></see></summary>
    let ``Operations/Project`` =
        Namespaced_IRI.parse _namespace_name "Operations/Project" |> NamespacedName

    /// <summary>
    /// Assement of an Element for export control classification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/ExportControlClassificationAssessment"></see></summary>
    let ``Operations/ExportControlClassificationAssessment`` =
        Namespaced_IRI.parse _namespace_name "Operations/ExportControlClassificationAssessment" |> NamespacedName

    /// <summary>
    /// Assement of an Element for export control classification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/ExportControlClassification"></see></summary>
    let ``Operations/ExportControlClassification`` =
        Namespaced_IRI.parse _namespace_name "Operations/ExportControlClassification" |> NamespacedName

    /// <summary>
    /// This is the state of an affected Element at a specific moment in time.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/StateAction"></see></summary>
    let ``SupplyChain/StateAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/StateAction" |> NamespacedName

    /// <summary>
    /// A state is an instance that describes what a system, component, subsystem, process, or project has achieved at any given time.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/State"></see></summary>
    let ``SupplyChain/State`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/State" |> NamespacedName

    /// <summary>
    /// AssemblyAction represents the event of creating a product by assembling individual components.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/AssemblyAction"></see></summary>
    let ``SupplyChain/AssemblyAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/AssemblyAction" |> NamespacedName

    /// <summary>
    /// The Boundary Definition Process refers to the process class used to produce boundaries.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryDefinitionProcess"></see></summary>
    let ``SupplyChain/BoundaryDefinitionProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/BoundaryDefinitionProcess" |> NamespacedName

    /// <summary>
    /// The destruction process is defined in this process.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/DestroyProcess"></see></summary>
    let ``SupplyChain/DestroyProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/DestroyProcess" |> NamespacedName

    /// <summary>
    /// ResponsibilityChangeAction refers to the transfer of responsibility from one party to another.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityChangeAction"></see></summary>
    let ``SupplyChain/ResponsibilityChangeAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ResponsibilityChangeAction" |> NamespacedName

    /// <summary>
    /// A PlanAction involves the execution of a plan in relation to a PlanProcess.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/PlanAction"></see></summary>
    let ``SupplyChain/PlanAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/PlanAction" |> NamespacedName

    /// <summary>
    /// The record of destruction is entered in this action.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/DestroyAction"></see></summary>
    let ``SupplyChain/DestroyAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/DestroyAction" |> NamespacedName

    /// <summary>
    /// An actual change to a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ChangeAction"></see></summary>
    let ``SupplyChain/ChangeAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ChangeAction" |> NamespacedName

    /// <summary>
    /// A prescribed change to a product's location.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/TransportProcess"></see></summary>
    let ``SupplyChain/TransportProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/TransportProcess" |> NamespacedName

    /// <summary>
    /// Products out of specification require a resolution action. This is the action of resolution.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResolutionAction"></see></summary>
    let ``SupplyChain/ResolutionAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ResolutionAction" |> NamespacedName

    /// <summary>
    /// Test Process defines the testing process for an element.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/TestProcess"></see></summary>
    let ``SupplyChain/TestProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/TestProcess" |> NamespacedName

    /// <summary>
    /// This process is used to determine the state of an affected Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/DefinedStateProcess"></see></summary>
    let ``SupplyChain/DefinedStateProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/DefinedStateProcess" |> NamespacedName

    /// <summary>
    /// Prescribes the storage of a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/StorageProcess"></see></summary>
    let ``SupplyChain/StorageProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/StorageProcess" |> NamespacedName

    /// <summary>
    /// Records the storage of a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/StorageAction"></see></summary>
    let ``SupplyChain/StorageAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/StorageAction" |> NamespacedName

    /// <summary>
    /// Process plans outline the stages of implementation or use related to a process.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/PlanProcess"></see></summary>
    let ``SupplyChain/PlanProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/PlanProcess" |> NamespacedName

    /// <summary>
    /// Reproduction is the biological process by which organisms generate new individuals of the same species.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ReproduceAction"></see></summary>
    let ``SupplyChain/ReproduceAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ReproduceAction" |> NamespacedName

    /// <summary>
    /// Reproduction is the biological process by which living organisms produce offspring.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ReproduceProcess"></see></summary>
    let ``SupplyChain/ReproduceProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ReproduceProcess" |> NamespacedName

    /// <summary>
    /// An action of crossing a boundary is defined in this class.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryCrossingAction"></see></summary>
    let ``SupplyChain/BoundaryCrossingAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/BoundaryCrossingAction" |> NamespacedName

    /// <summary>
    /// Inspection Process defines specific various processes needed to satisfy the inspection requirements for a specific product or service.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/InspectionProcess"></see></summary>
    let ``SupplyChain/InspectionProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/InspectionProcess" |> NamespacedName

    /// <summary>
    /// Class that describes an InstantiateVirtualHardwareProcess that is used to define VirtualHardware and its source.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/InstantiateVirtualHardwareProcess"></see></summary>
    let ``SupplyChain/InstantiateVirtualHardwareProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/InstantiateVirtualHardwareProcess" |> NamespacedName

    /// <summary>
    /// The AssemblyProcess represents the process of creating a product by assembling a set of components, potentially in a way that allows for at disassembly (at least partially).
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/AssemblyProcess"></see></summary>
    let ``SupplyChain/AssemblyProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/AssemblyProcess" |> NamespacedName

    /// <summary>
    /// This class represents the process involved in manufacturing products.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ManufactureProcess"></see></summary>
    let ``SupplyChain/ManufactureProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ManufactureProcess" |> NamespacedName

    /// <summary>
    /// The boundary definition is used to define boundaries.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryDefinitionAction"></see></summary>
    let ``SupplyChain/BoundaryDefinitionAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/BoundaryDefinitionAction" |> NamespacedName

    /// <summary>
    /// An out of specification action is defined in this class.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/OutOfSpecAction"></see></summary>
    let ``SupplyChain/OutOfSpecAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/OutOfSpecAction" |> NamespacedName

    /// <summary>
    /// ResponsibilityChangeProcess refers to the process of transferring responsibility from one party to another.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityChangeProcess"></see></summary>
    let ``SupplyChain/ResponsibilityChangeProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ResponsibilityChangeProcess" |> NamespacedName

    /// <summary>
    /// Harvest is the process of extracting goods or products from nature.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/HarvestProcess"></see></summary>
    let ``SupplyChain/HarvestProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/HarvestProcess" |> NamespacedName

    /// <summary>
    /// An inspection action refers to a specific activity or set of activities performed during an inspection to examine, verify, or evaluate an item, process, or system.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/InspectionAction"></see></summary>
    let ``SupplyChain/InspectionAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/InspectionAction" |> NamespacedName

    /// <summary>
    /// A prescribed change to a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ChangeProcess"></see></summary>
    let ``SupplyChain/ChangeProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ChangeProcess" |> NamespacedName

    /// <summary>
    /// ManufactureAction represents the act of creating a product by a manufacturing process.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ManufactureAction"></see></summary>
    let ``SupplyChain/ManufactureAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ManufactureAction" |> NamespacedName

    /// <summary>
    /// An actual change to a product's location.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/TransportAction"></see></summary>
    let ``SupplyChain/TransportAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/TransportAction" |> NamespacedName

    /// <summary>
    /// HarvestAction represents the act of creating a product by directly extracting goods or materials from nature.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/HarvestAction"></see></summary>
    let ``SupplyChain/HarvestAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/HarvestAction" |> NamespacedName

    /// <summary>
    /// A test action is a specific action associated with a test.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/TestAction"></see></summary>
    let ``SupplyChain/TestAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/TestAction" |> NamespacedName

    /// <summary>
    /// Software provided as a service over a network.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/SoftwareService"></see></summary>
    let ``Service/SoftwareService`` =
        Namespaced_IRI.parse _namespace_name "Service/SoftwareService" |> NamespacedName

    /// <summary>
    /// Refers to any object that stores content on a computer.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/File"></see></summary>
    let ``Software/File`` =
        Namespaced_IRI.parse _namespace_name "Software/File" |> NamespacedName

    /// <summary>
    /// A collection of SPDX Elements describing a single package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/Sbom"></see></summary>
    let ``Software/Sbom`` =
        Namespaced_IRI.parse _namespace_name "Software/Sbom" |> NamespacedName

    /// <summary>
    /// Describes a certain part of a file.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/Snippet"></see></summary>
    let ``Software/Snippet`` =
        Namespaced_IRI.parse _namespace_name "Software/Snippet" |> NamespacedName

    /// <summary>
    /// A canonical, unique, immutable identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifier"></see></summary>
    let ``Software/ContentIdentifier`` =
        Namespaced_IRI.parse _namespace_name "Software/ContentIdentifier" |> NamespacedName

    /// <summary>
    /// Class that describes an instance of VirtualHardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardware"></see></summary>
    let ``Hardware/VirtualHardware`` =
        Namespaced_IRI.parse _namespace_name "Hardware/VirtualHardware" |> NamespacedName

    /// <summary>
    /// Dimensions generally refer to measurable extents or attributes that define the size, shape, or scale of an object, system, or concept.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/Dimensions"></see></summary>
    let ``Hardware/Dimensions`` =
        Namespaced_IRI.parse _namespace_name "Hardware/Dimensions" |> NamespacedName

    /// <summary>
    /// A product specification (product spec) is a detailed document that outlines the technical, functional, and design requirements of a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/ProductSpecification"></see></summary>
    let ``Hardware/ProductSpecification`` =
        Namespaced_IRI.parse _namespace_name "Hardware/ProductSpecification" |> NamespacedName

    /// <summary>
    /// Class that describes a physical instance of Hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/PhysicalHardware"></see></summary>
    let ``Hardware/PhysicalHardware`` =
        Namespaced_IRI.parse _namespace_name "Hardware/PhysicalHardware" |> NamespacedName

    /// <summary>
    /// Products or commodities produced as a bulk unit are called bulk products. Commodities are often sold in bulk.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/BulkHardware"></see></summary>
    let ``Hardware/BulkHardware`` =
        Namespaced_IRI.parse _namespace_name "Hardware/BulkHardware" |> NamespacedName

    /// <summary>
    /// Specifies an Extension characterization of some aspect of an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/extension"></see></summary>
    let ``Core/extension`` =
        Namespaced_IRI.parse _namespace_name "Core/extension" |> NamespacedName

    /// <summary>
    /// This property is used to denote the root Element(s) of a tree of elements contained in a BOM.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/rootElement"></see></summary>
    let ``Core/rootElement`` =
        Namespaced_IRI.parse _namespace_name "Core/rootElement" |> NamespacedName

    /// <summary>
    /// Refers to one or more Elements that are part of an ElementCollection.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/element"></see></summary>
    let ``Core/element`` =
        Namespaced_IRI.parse _namespace_name "Core/element" |> NamespacedName

    /// <summary>
    /// Enumeration of the valid profiles.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType"></see></summary>
    let ``Core/ProfileIdentifierType`` =
        Namespaced_IRI.parse _namespace_name "Core/ProfileIdentifierType" |> NamespacedName

    /// <summary>
    /// The element follows the Core profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/core"></see></summary>
    let ``Core/ProfileIdentifierType/core`` =
        Namespaced_IRI.parse _namespace_name "Core/ProfileIdentifierType/core" |> NamespacedName

    /// <summary>
    /// The element follows the Software profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/software"></see></summary>
    let ``Core/ProfileIdentifierType/software`` =
        Namespaced_IRI.parse _namespace_name "Core/ProfileIdentifierType/software" |> NamespacedName

    /// <summary>
    /// The element follows the SimpleLicensing profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/simpleLicensing"></see></summary>
    let ``Core/ProfileIdentifierType/simpleLicensing`` =
        Namespaced_IRI.parse _namespace_name "Core/ProfileIdentifierType/simpleLicensing" |> NamespacedName

    /// <summary>
    /// The element follows the ExpandedLicensing profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/expandedLicensing"></see></summary>
    let ``Core/ProfileIdentifierType/expandedLicensing`` =
        Namespaced_IRI.parse _namespace_name "Core/ProfileIdentifierType/expandedLicensing" |> NamespacedName

    /// <summary>
    /// The element follows the Security profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/security"></see></summary>
    let ``Core/ProfileIdentifierType/security`` =
        Namespaced_IRI.parse _namespace_name "Core/ProfileIdentifierType/security" |> NamespacedName

    /// <summary>
    /// The element follows the Build profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/build"></see></summary>
    let ``Core/ProfileIdentifierType/build`` =
        Namespaced_IRI.parse _namespace_name "Core/ProfileIdentifierType/build" |> NamespacedName

    /// <summary>
    /// The element follows the AI profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/ai"></see></summary>
    let ``Core/ProfileIdentifierType/ai`` =
        Namespaced_IRI.parse _namespace_name "Core/ProfileIdentifierType/ai" |> NamespacedName

    /// <summary>
    /// The element follows the Dataset profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/dataset"></see></summary>
    let ``Core/ProfileIdentifierType/dataset`` =
        Namespaced_IRI.parse _namespace_name "Core/ProfileIdentifierType/dataset" |> NamespacedName

    /// <summary>
    /// The element follows the Extension profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/extension"></see></summary>
    let ``Core/ProfileIdentifierType/extension`` =
        Namespaced_IRI.parse _namespace_name "Core/ProfileIdentifierType/extension" |> NamespacedName

    /// <summary>
    /// The element follows the Lite profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/lite"></see></summary>
    let ``Core/ProfileIdentifierType/lite`` =
        Namespaced_IRI.parse _namespace_name "Core/ProfileIdentifierType/lite" |> NamespacedName

    /// <summary>
    /// The element follows the Hardware profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/hardware"></see></summary>
    let ``Core/ProfileIdentifierType/hardware`` =
        Namespaced_IRI.parse _namespace_name "Core/ProfileIdentifierType/hardware" |> NamespacedName

    /// <summary>
    /// The element follows the SupplyChain profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/supplyChain"></see></summary>
    let ``Core/ProfileIdentifierType/supplyChain`` =
        Namespaced_IRI.parse _namespace_name "Core/ProfileIdentifierType/supplyChain" |> NamespacedName

    /// <summary>
    /// Describes one a profile which the creator of this ElementCollection intends to
    /// conform to.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/profileConformance"></see></summary>
    let ``Core/profileConformance`` =
        Namespaced_IRI.parse _namespace_name "Core/profileConformance" |> NamespacedName

    /// <summary>
    /// A value used in a key-value pair with a generic key that refers to an Element
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/elementValue"></see></summary>
    let ``Core/elementValue`` =
        Namespaced_IRI.parse _namespace_name "Core/elementValue" |> NamespacedName

    /// <summary>
    /// Provides the location for more information regarding an external identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/identifierLocator"></see></summary>
    let ``Core/identifierLocator`` =
        Namespaced_IRI.parse _namespace_name "Core/identifierLocator" |> NamespacedName

    /// <summary>
    /// Specifies the type of an external identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType"></see></summary>
    let ``Core/ExternalIdentifierType`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType" |> NamespacedName

    /// <summary>
    /// [Common Platform Enumeration Specification 2.2](https://cpe.mitre.org/files/cpe-specification_2.2.pdf).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cpe22"></see></summary>
    let ``Core/ExternalIdentifierType/cpe22`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/cpe22" |> NamespacedName

    /// <summary>
    /// [Common Platform Enumeration: Naming Specification Version 2.3](https://csrc.nist.gov/publications/detail/nistir/7695/final).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cpe23"></see></summary>
    let ``Core/ExternalIdentifierType/cpe23`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/cpe23" |> NamespacedName

    /// <summary>
    /// Common Vulnerabilities and Exposures identifiers, an identifier for a specific software flaw defined within the official CVE Dictionary and that conforms to the [CVE specification](https://csrc.nist.gov/glossary/term/cve_id).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cve"></see></summary>
    let ``Core/ExternalIdentifierType/cve`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/cve" |> NamespacedName

    /// <summary>
    /// [Data Universal Numbering System (D-U-N-S) Number](https://www.dnb.com/en-us/smb/duns.html) is a unique nine-digit identifier, issued by Dun &amp; Bradstreet, that identifies a business entity, often on a location-specific basis.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/duns"></see></summary>
    let ``Core/ExternalIdentifierType/duns`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/duns" |> NamespacedName

    /// <summary>
    /// Email address, as defined in [RFC 3696](https://datatracker.ietf.org/doc/rfc3696/) Section 3.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/email"></see></summary>
    let ``Core/ExternalIdentifierType/email`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/email" |> NamespacedName

    /// <summary>
    /// The UUID used by a reporting management system or any other lifecycle management tool to uniquely identify an evidence relationship item. UUID, or universally unique ID, is a standard term to refer to evidence items.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/evidenceUUID"></see></summary>
    let ``Core/ExternalIdentifierType/evidenceUUID`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/evidenceUUID" |> NamespacedName

    /// <summary>
    /// [Gitoid](https://www.iana.org/assignments/uri-schemes/prov/gitoid), stands for [Git Object ID](https://git-scm.com/book/en/v2/Git-Internals-Git-Objects). A gitoid of type blob is a unique hash of a binary artifact. A gitoid may represent either an [Artifact Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-identifier-types) for the software artifact or an [Input Manifest Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#input-manifest-identifier) for the software artifact's associated [Artifact Input Manifest](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-input-manifest); this ambiguity exists because the Artifact Input Manifest is itself an artifact, and the gitoid of that artifact is its valid identifier. Gitoids calculated on software artifacts (Snippet, File, or Package Elements) should be recorded in the SPDX 3 SoftwareArtifact's contentIdentifier property. Gitoids calculated on the Artifact Input Manifest (Input Manifest Identifier) should be recorded in the SPDX 3 Element's externalIdentifier property. See [OmniBOR Specification](https://github.com/omnibor/spec/), a minimalistic specification for describing software [Artifact Dependency Graphs](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-dependency-graph-adg).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gitoid"></see></summary>
    let ``Core/ExternalIdentifierType/gitoid`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/gitoid" |> NamespacedName

    /// <summary>
    /// [Global Location Number (GLN)](https://www.gs1.org/standards/id-keys/gln) is a 13-digit number, assigned by GS1, that uniquely identifies a legal entity (e.g., a company or customer), a function within a legal entity, a physical location (e.g., a warehouse or a specific shelf in a store), or a digital location (e.g., an Electronic Data Interchange (EDI) gateway).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gln"></see></summary>
    let ``Core/ExternalIdentifierType/gln`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/gln" |> NamespacedName

    /// <summary>
    /// [GLobal Unique Enterprise (GLUE) Identifiers](https://datatracker.ietf.org/doc/draft-ietf-spice-glue-id/), as defined by the IETF Internet-Draft, is expressed as a GLUE URI, a Uniform Resource Identifier that standardizes the representation of existing organizational entity identifiers.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/glue"></see></summary>
    let ``Core/ExternalIdentifierType/glue`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/glue" |> NamespacedName

    /// <summary>
    /// [Global Trade Item Number (GTIN)](https://www.gs1.org/standards/id-keys/gtin) is a number, assigned by GS1, that uniquely identifies a trade item (product or service).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gtin"></see></summary>
    let ``Core/ExternalIdentifierType/gtin`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/gtin" |> NamespacedName

    /// <summary>
    /// The [Harmonized System (HS)](https://www.wcoomd.org/en/topics/nomenclature/overview/what-is-the-harmonized-system.aspx) of tariff nomenclature is an internationally standardized system of names and numbers, defined by the World Customs Organization, used to classify traded products.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/hsCodes"></see></summary>
    let ``Core/ExternalIdentifierType/hsCodes`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/hsCodes" |> NamespacedName

    /// <summary>
    /// The [Legal Entity Identifier (LEI)](https://www.gleif.org/en/organizational-identity/introducing-the-legal-entity-identifier-lei) is a 20-character, alphanumeric code based on the [ISO 17442](https://www.iso.org/standard/78829.html) standard developed by the International Organization for Standardization.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/lei"></see></summary>
    let ``Core/ExternalIdentifierType/lei`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/lei" |> NamespacedName

    /// <summary>
    /// Used when the type does not match any of the other options.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/other"></see></summary>
    let ``Core/ExternalIdentifierType/other`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/other" |> NamespacedName

    /// <summary>
    /// Package URL, as defined in the corresponding [Annex](../../../annexes/pkg-url-specification.md) of this document.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/packageUrl"></see></summary>
    let ``Core/ExternalIdentifierType/packageUrl`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/packageUrl" |> NamespacedName

    /// <summary>
    /// Phone number; A string of decimal digits that uniquely indicates the network termination point defined in [RFC 3966](https://datatracker.ietf.org/doc/rfc3966/) Section 5.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/phoneNumber"></see></summary>
    let ``Core/ExternalIdentifierType/phoneNumber`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/phoneNumber" |> NamespacedName

    /// <summary>
    /// The UUID used by a requirements management or any other lifecycle management tool to uniquely identify a requirement item. UUID, or universally unique ID, is a standard term in requirements engineering.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/requirementUUID"></see></summary>
    let ``Core/ExternalIdentifierType/requirementUUID`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/requirementUUID" |> NamespacedName

    /// <summary>
    /// Used when there is a security related identifier of unspecified type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/securityOther"></see></summary>
    let ``Core/ExternalIdentifierType/securityOther`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/securityOther" |> NamespacedName

    /// <summary>
    /// SoftWare Hash IDentifier, a persistent intrinsic identifier for digital artifacts, such as files, trees (also known as directories or folders), commits, and other objects typically found in version control systems. The format of the identifiers is defined in the [SWHID specification](https://www.swhid.org/swhid-specification/v1.2/) ([ISO/IEC 18670](https://www.iso.org/standard/89985.html)). They typically look like `swh:1:cnt:94a9ed024d3859793618152ea559a168bbcbb5e2`.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/swhid"></see></summary>
    let ``Core/ExternalIdentifierType/swhid`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/swhid" |> NamespacedName

    /// <summary>
    /// Concise Software Identification (CoSWID) tag, as defined in [RFC 9393](https://datatracker.ietf.org/doc/rfc9393/) Section 2.3.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/swid"></see></summary>
    let ``Core/ExternalIdentifierType/swid`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/swid" |> NamespacedName

    /// <summary>
    /// [Uniform Resource Identifier (URI) Schemes](https://www.iana.org/assignments/uri-schemes/uri-schemes.xhtml). The scheme used in order to locate a resource.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/urlScheme"></see></summary>
    let ``Core/ExternalIdentifierType/urlScheme`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/urlScheme" |> NamespacedName

    /// <summary>
    /// The UUID used by a verification management system or any other lifecycle management tool to uniquely identify a verification item. UUID, or universally unique ID, is a standard term to refer to verification items.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/verificationUUID"></see></summary>
    let ``Core/ExternalIdentifierType/verificationUUID`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/verificationUUID" |> NamespacedName

    /// <summary>
    /// Absolute URL that can be used to locate a resource, as defined in [RFC 7230](https://datatracker.ietf.org/doc/rfc7230/) Section 2.7.1 or Section 2.7.2.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/webpage"></see></summary>
    let ``Core/ExternalIdentifierType/webpage`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalIdentifierType/webpage" |> NamespacedName

    /// <summary>
    /// Specifies the type of the external identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/externalIdentifierType"></see></summary>
    let ``Core/externalIdentifierType`` =
        Namespaced_IRI.parse _namespace_name "Core/externalIdentifierType" |> NamespacedName

    /// <summary>
    /// Uniquely identifies an external element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/identifier"></see></summary>
    let ``Core/identifier`` =
        Namespaced_IRI.parse _namespace_name "Core/identifier" |> NamespacedName

    /// <summary>
    /// An entity that is authorized to issue identification credentials.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/issuingAuthority"></see></summary>
    let ``Core/issuingAuthority`` =
        Namespaced_IRI.parse _namespace_name "Core/issuingAuthority" |> NamespacedName

    /// <summary>
    /// Identifies an external Element used within an SpdxDocument but defined
    /// external to that SpdxDocument.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/externalSpdxId"></see></summary>
    let ``Core/externalSpdxId`` =
        Namespaced_IRI.parse _namespace_name "Core/externalSpdxId" |> NamespacedName

    /// <summary>
    /// Provides an indication of where to retrieve an external Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/locationHint"></see></summary>
    let ``Core/locationHint`` =
        Namespaced_IRI.parse _namespace_name "Core/locationHint" |> NamespacedName

    /// <summary>
    /// Artifact representing a serialization instance of SPDX data containing the
    /// definition of a particular Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/definingArtifact"></see></summary>
    let ``Core/definingArtifact`` =
        Namespaced_IRI.parse _namespace_name "Core/definingArtifact" |> NamespacedName

    /// <summary>
    /// Specifies the type of an external reference.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType"></see></summary>
    let ``Core/ExternalRefType`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType" |> NamespacedName

    /// <summary>
    /// A reference to an alternative download location.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/altDownloadLocation"></see></summary>
    let ``Core/ExternalRefType/altDownloadLocation`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/altDownloadLocation" |> NamespacedName

    /// <summary>
    /// A reference to an alternative web page.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/altWebPage"></see></summary>
    let ``Core/ExternalRefType/altWebPage`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/altWebPage" |> NamespacedName

    /// <summary>
    /// A reference to binary artifacts related to a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/binaryArtifact"></see></summary>
    let ``Core/ExternalRefType/binaryArtifact`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/binaryArtifact" |> NamespacedName

    /// <summary>
    /// A reference to a Bower package. The package locator format, looks like `package#version`, is defined in the "install" section of [Bower API documentation](https://bower.io/docs/api/#install).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/bower"></see></summary>
    let ``Core/ExternalRefType/bower`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/bower" |> NamespacedName

    /// <summary>
    /// A reference build metadata related to a published package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/buildMeta"></see></summary>
    let ``Core/ExternalRefType/buildMeta`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/buildMeta" |> NamespacedName

    /// <summary>
    /// A reference build system used to create or publish the package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/buildSystem"></see></summary>
    let ``Core/ExternalRefType/buildSystem`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/buildSystem" |> NamespacedName

    /// <summary>
    /// A reference to the instant messaging system used by the maintainer for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/chat"></see></summary>
    let ``Core/ExternalRefType/chat`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/chat" |> NamespacedName

    /// <summary>
    /// A reference to a certification report for a package from an accredited/independent body.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/certificationReport"></see></summary>
    let ``Core/ExternalRefType/certificationReport`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/certificationReport" |> NamespacedName

    /// <summary>
    /// A reference to a Software Composition Analysis (SCA) report.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/componentAnalysisReport"></see></summary>
    let ``Core/ExternalRefType/componentAnalysisReport`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/componentAnalysisReport" |> NamespacedName

    /// <summary>
    /// [Common Weakness Enumeration](https://csrc.nist.gov/glossary/term/common_weakness_enumeration). A reference to a source of software flaw defined within the official [CWE List](https://cwe.mitre.org/data/) that conforms to the [CWE specification](https://cwe.mitre.org/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/cwe"></see></summary>
    let ``Core/ExternalRefType/cwe`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/cwe" |> NamespacedName

    /// <summary>
    /// A reference to the documentation for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/documentation"></see></summary>
    let ``Core/ExternalRefType/documentation`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/documentation" |> NamespacedName

    /// <summary>
    /// A reference to a dynamic analysis report for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/dynamicAnalysisReport"></see></summary>
    let ``Core/ExternalRefType/dynamicAnalysisReport`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/dynamicAnalysisReport" |> NamespacedName

    /// <summary>
    /// A reference to the End Of Sale (EOS) and/or End Of Life (EOL) information related to a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/eolNotice"></see></summary>
    let ``Core/ExternalRefType/eolNotice`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/eolNotice" |> NamespacedName

    /// <summary>
    /// A reference to an export control assessment for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/exportControlAssessment"></see></summary>
    let ``Core/ExternalRefType/exportControlAssessment`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/exportControlAssessment" |> NamespacedName

    /// <summary>
    /// A reference to funding information related to a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/funding"></see></summary>
    let ``Core/ExternalRefType/funding`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/funding" |> NamespacedName

    /// <summary>
    /// A reference to the issue tracker for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/issueTracker"></see></summary>
    let ``Core/ExternalRefType/issueTracker`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/issueTracker" |> NamespacedName

    /// <summary>
    /// A reference to the mailing list used by the maintainer for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/mailingList"></see></summary>
    let ``Core/ExternalRefType/mailingList`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/mailingList" |> NamespacedName

    /// <summary>
    /// A reference to a Maven repository artifact. The artifact locator format is defined in the [Maven documentation](https://maven.apache.org/guides/mini/guide-naming-conventions.html) and looks like `groupId:artifactId[:version]`.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/mavenCentral"></see></summary>
    let ``Core/ExternalRefType/mavenCentral`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/mavenCentral" |> NamespacedName

    /// <summary>
    /// A reference to metrics related to package such as OpenSSF scorecards.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/metrics"></see></summary>
    let ``Core/ExternalRefType/metrics`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/metrics" |> NamespacedName

    /// <summary>
    /// A reference to an npm package. The package locator format is defined in the [npm documentation](https://docs.npmjs.com/cli/v10/configuring-npm/package-json) and looks like `package@version`.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/npm"></see></summary>
    let ``Core/ExternalRefType/npm`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/npm" |> NamespacedName

    /// <summary>
    /// A reference to a NuGet package. The package locator format is defined in the [NuGet documentation](https://docs.nuget.org) and looks like `package/version`.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/nuget"></see></summary>
    let ``Core/ExternalRefType/nuget`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/nuget" |> NamespacedName

    /// <summary>
    /// A reference to additional license information related to an artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/license"></see></summary>
    let ``Core/ExternalRefType/license`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/license" |> NamespacedName

    /// <summary>
    /// Used when the type does not match any of the other options.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/other"></see></summary>
    let ``Core/ExternalRefType/other`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/other" |> NamespacedName

    /// <summary>
    /// A reference to a privacy assessment for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/privacyAssessment"></see></summary>
    let ``Core/ExternalRefType/privacyAssessment`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/privacyAssessment" |> NamespacedName

    /// <summary>
    /// A reference to additional product metadata such as reference within organization's product catalog.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/productMetadata"></see></summary>
    let ``Core/ExternalRefType/productMetadata`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/productMetadata" |> NamespacedName

    /// <summary>
    /// A reference to a purchase order for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/purchaseOrder"></see></summary>
    let ``Core/ExternalRefType/purchaseOrder`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/purchaseOrder" |> NamespacedName

    /// <summary>
    /// A reference to a quality assessment for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/qualityAssessmentReport"></see></summary>
    let ``Core/ExternalRefType/qualityAssessmentReport`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/qualityAssessmentReport" |> NamespacedName

    /// <summary>
    /// A reference to the release notes for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/releaseNotes"></see></summary>
    let ``Core/ExternalRefType/releaseNotes`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/releaseNotes" |> NamespacedName

    /// <summary>
    /// A reference to a published list of releases for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/releaseHistory"></see></summary>
    let ``Core/ExternalRefType/releaseHistory`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/releaseHistory" |> NamespacedName

    /// <summary>
    /// A reference to a risk assessment for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/riskAssessment"></see></summary>
    let ``Core/ExternalRefType/riskAssessment`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/riskAssessment" |> NamespacedName

    /// <summary>
    /// A reference to a runtime analysis report for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/runtimeAnalysisReport"></see></summary>
    let ``Core/ExternalRefType/runtimeAnalysisReport`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/runtimeAnalysisReport" |> NamespacedName

    /// <summary>
    /// A reference to information assuring that the software is developed using security practices as defined by [NIST SP 800-218 Secure Software Development Framework (SSDF) Version 1.1](https://csrc.nist.gov/pubs/sp/800/218/final) or [CISA Secure Software Development Attestation Form](https://www.cisa.gov/resources-tools/resources/secure-software-development-attestation-form).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/secureSoftwareAttestation"></see></summary>
    let ``Core/ExternalRefType/secureSoftwareAttestation`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/secureSoftwareAttestation" |> NamespacedName

    /// <summary>
    /// A reference to a published security advisory (where advisory as defined per [ISO 29147:2018](https://www.iso.org/standard/72311.html)) that may affect one or more elements, e.g., vendor advisories or specific NVD entries.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityAdvisory"></see></summary>
    let ``Core/ExternalRefType/securityAdvisory`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/securityAdvisory" |> NamespacedName

    /// <summary>
    /// A reference to the security adversary model for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityAdversaryModel"></see></summary>
    let ``Core/ExternalRefType/securityAdversaryModel`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/securityAdversaryModel" |> NamespacedName

    /// <summary>
    /// A reference to the patch or source code that fixes a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityFix"></see></summary>
    let ``Core/ExternalRefType/securityFix`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/securityFix" |> NamespacedName

    /// <summary>
    /// A reference to related security information of unspecified type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityOther"></see></summary>
    let ``Core/ExternalRefType/securityOther`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/securityOther" |> NamespacedName

    /// <summary>
    /// A reference to a [penetration test](https://en.wikipedia.org/wiki/Penetration_test) report for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityPenTestReport"></see></summary>
    let ``Core/ExternalRefType/securityPenTestReport`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/securityPenTestReport" |> NamespacedName

    /// <summary>
    /// A reference to instructions for reporting newly discovered security vulnerabilities for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityPolicy"></see></summary>
    let ``Core/ExternalRefType/securityPolicy`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/securityPolicy" |> NamespacedName

    /// <summary>
    /// A reference the [security threat model](https://en.wikipedia.org/wiki/Threat_model) for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityThreatModel"></see></summary>
    let ``Core/ExternalRefType/securityThreatModel`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/securityThreatModel" |> NamespacedName

    /// <summary>
    /// A reference to a social media channel for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/socialMedia"></see></summary>
    let ``Core/ExternalRefType/socialMedia`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/socialMedia" |> NamespacedName

    /// <summary>
    /// A reference to an artifact containing the sources for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/sourceArtifact"></see></summary>
    let ``Core/ExternalRefType/sourceArtifact`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/sourceArtifact" |> NamespacedName

    /// <summary>
    /// A reference to a static analysis report for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/staticAnalysisReport"></see></summary>
    let ``Core/ExternalRefType/staticAnalysisReport`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/staticAnalysisReport" |> NamespacedName

    /// <summary>
    /// A reference to the software support channel or other support information for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/support"></see></summary>
    let ``Core/ExternalRefType/support`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/support" |> NamespacedName

    /// <summary>
    /// A reference to a version control system related to a software artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vcs"></see></summary>
    let ``Core/ExternalRefType/vcs`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/vcs" |> NamespacedName

    /// <summary>
    /// A reference to a Vulnerability Disclosure Report (VDR) which provides the software supplier's analysis and findings describing the impact (or lack of impact) that reported vulnerabilities have on packages or products in the supplier's SBOM as defined in [NIST SP 800-161 Cybersecurity Supply Chain Risk Management Practices for Systems and Organizations](https://csrc.nist.gov/pubs/sp/800/161/r1/final).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vulnerabilityDisclosureReport"></see></summary>
    let ``Core/ExternalRefType/vulnerabilityDisclosureReport`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/vulnerabilityDisclosureReport" |> NamespacedName

    /// <summary>
    /// A reference to a Vulnerability Exploitability eXchange (VEX) statement which provides information on whether a product is impacted by a specific vulnerability in an included package and, if affected, whether there are actions recommended to remediate. See also [NTIA VEX one-page summary](https://ntia.gov/files/ntia/publications/vex_one-page_summary.pdf).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vulnerabilityExploitabilityAssessment"></see></summary>
    let ``Core/ExternalRefType/vulnerabilityExploitabilityAssessment`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/vulnerabilityExploitabilityAssessment" |> NamespacedName

    /// <summary>
    /// A reference to an X.509 certificate as defined in [RFC 1422](https://datatracker.ietf.org/doc/rfc1422/). The media type shall be one of application/x-x509-ca-cert or application/x-x509-user-cert.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/x509Cert"></see></summary>
    let ``Core/ExternalRefType/x509Cert`` =
        Namespaced_IRI.parse _namespace_name "Core/ExternalRefType/x509Cert" |> NamespacedName

    /// <summary>
    /// Specifies the type of the external reference.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/externalRefType"></see></summary>
    let ``Core/externalRefType`` =
        Namespaced_IRI.parse _namespace_name "Core/externalRefType" |> NamespacedName

    /// <summary>
    /// Provides the location of an external reference.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/locator"></see></summary>
    let ``Core/locator`` =
        Namespaced_IRI.parse _namespace_name "Core/locator" |> NamespacedName

    /// <summary>
    /// A mathematical algorithm that maps data of arbitrary size to a bit string.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm"></see></summary>
    let ``Core/HashAlgorithm`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm" |> NamespacedName

    /// <summary>
    /// Adler-32 checksum is part of the widely used zlib compression library as defined in [RFC 1950](https://datatracker.ietf.org/doc/rfc1950/) Section 2.3.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/adler32"></see></summary>
    let ``Core/HashAlgorithm/adler32`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/adler32" |> NamespacedName

    /// <summary>
    /// BLAKE2b algorithm with a digest size of 256, as defined in [RFC 7693](https://datatracker.ietf.org/doc/rfc7693/) Section 4.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b256"></see></summary>
    let ``Core/HashAlgorithm/blake2b256`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/blake2b256" |> NamespacedName

    /// <summary>
    /// BLAKE2b algorithm with a digest size of 384, as defined in [RFC 7693](https://datatracker.ietf.org/doc/rfc7693/) Section 4.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b384"></see></summary>
    let ``Core/HashAlgorithm/blake2b384`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/blake2b384" |> NamespacedName

    /// <summary>
    /// BLAKE2b algorithm with a digest size of 512, as defined in [RFC 7693](https://datatracker.ietf.org/doc/rfc7693/) Section 4.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b512"></see></summary>
    let ``Core/HashAlgorithm/blake2b512`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/blake2b512" |> NamespacedName

    /// <summary>
    /// [BLAKE3](https://github.com/BLAKE3-team/BLAKE3-specs/blob/master/blake3.pdf)
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake3"></see></summary>
    let ``Core/HashAlgorithm/blake3`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/blake3" |> NamespacedName

    /// <summary>
    /// [Dilithium](https://pq-crystals.org/dilithium/)
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/crystalsDilithium"></see></summary>
    let ``Core/HashAlgorithm/crystalsDilithium`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/crystalsDilithium" |> NamespacedName

    /// <summary>
    /// [Kyber](https://pq-crystals.org/kyber/)
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/crystalsKyber"></see></summary>
    let ``Core/HashAlgorithm/crystalsKyber`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/crystalsKyber" |> NamespacedName

    /// <summary>
    /// [FALCON](https://falcon-sign.info/falcon.pdf)
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/falcon"></see></summary>
    let ``Core/HashAlgorithm/falcon`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/falcon" |> NamespacedName

    /// <summary>
    /// MD2 message-digest algorithm, as defined in [RFC 1319](https://datatracker.ietf.org/doc/rfc1319/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md2"></see></summary>
    let ``Core/HashAlgorithm/md2`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/md2" |> NamespacedName

    /// <summary>
    /// MD4 message-digest algorithm, as defined in [RFC 1186](https://datatracker.ietf.org/doc/rfc1186/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md4"></see></summary>
    let ``Core/HashAlgorithm/md4`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/md4" |> NamespacedName

    /// <summary>
    /// MD5 message-digest algorithm, as defined in [RFC 1321](https://datatracker.ietf.org/doc/rfc1321/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md5"></see></summary>
    let ``Core/HashAlgorithm/md5`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/md5" |> NamespacedName

    /// <summary>
    /// [MD6 hash function](https://people.csail.mit.edu/rivest/pubs/RABCx08.pdf)
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md6"></see></summary>
    let ``Core/HashAlgorithm/md6`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/md6" |> NamespacedName

    /// <summary>
    /// any hashing algorithm that does not exist in this list of entries
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/other"></see></summary>
    let ``Core/HashAlgorithm/other`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/other" |> NamespacedName

    /// <summary>
    /// SHA-1, a secure hashing algorithm, as defined in [RFC 3174](https://datatracker.ietf.org/doc/rfc3174/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha1"></see></summary>
    let ``Core/HashAlgorithm/sha1`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/sha1" |> NamespacedName

    /// <summary>
    /// SHA-2 with a digest length of 224, as defined in [RFC 3874](https://datatracker.ietf.org/doc/rfc3874/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha224"></see></summary>
    let ``Core/HashAlgorithm/sha224`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/sha224" |> NamespacedName

    /// <summary>
    /// SHA-2 with a digest length of 256, as defined in [RFC 6234](https://datatracker.ietf.org/doc/rfc6234/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha256"></see></summary>
    let ``Core/HashAlgorithm/sha256`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/sha256" |> NamespacedName

    /// <summary>
    /// SHA-2 with a digest length of 384, as defined in [RFC 6234](https://datatracker.ietf.org/doc/rfc6234/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha384"></see></summary>
    let ``Core/HashAlgorithm/sha384`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/sha384" |> NamespacedName

    /// <summary>
    /// SHA-2 with a digest length of 512, as defined in [RFC 6234](https://datatracker.ietf.org/doc/rfc6234/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha512"></see></summary>
    let ``Core/HashAlgorithm/sha512`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/sha512" |> NamespacedName

    /// <summary>
    /// SHA-3 with a digest length of 224, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_224"></see></summary>
    let ``Core/HashAlgorithm/sha3_224`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/sha3_224" |> NamespacedName

    /// <summary>
    /// SHA-3 with a digest length of 256, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_256"></see></summary>
    let ``Core/HashAlgorithm/sha3_256`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/sha3_256" |> NamespacedName

    /// <summary>
    /// SHA-3 with a digest length of 384, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_384"></see></summary>
    let ``Core/HashAlgorithm/sha3_384`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/sha3_384" |> NamespacedName

    /// <summary>
    /// SHA-3 with a digest length of 512, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_512"></see></summary>
    let ``Core/HashAlgorithm/sha3_512`` =
        Namespaced_IRI.parse _namespace_name "Core/HashAlgorithm/sha3_512" |> NamespacedName

    /// <summary>
    /// Specifies the algorithm used for calculating the hash value.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/algorithm"></see></summary>
    let ``Core/algorithm`` =
        Namespaced_IRI.parse _namespace_name "Core/algorithm" |> NamespacedName

    /// <summary>
    /// The result of applying a hash algorithm to an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/hashValue"></see></summary>
    let ``Core/hashValue`` =
        Namespaced_IRI.parse _namespace_name "Core/hashValue" |> NamespacedName

    /// <summary>
    /// Provide an enumerated set of lifecycle phases that can provide context to relationships.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType"></see></summary>
    let ``Core/LifecycleScopeType`` =
        Namespaced_IRI.parse _namespace_name "Core/LifecycleScopeType" |> NamespacedName

    /// <summary>
    /// A relationship has specific context implications during an element's build phase, during development.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/build"></see></summary>
    let ``Core/LifecycleScopeType/build`` =
        Namespaced_IRI.parse _namespace_name "Core/LifecycleScopeType/build" |> NamespacedName

    /// <summary>
    /// A relationship has specific context implications for a product's retirement and/or decommissioning.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/decommission"></see></summary>
    let ``Core/LifecycleScopeType/decommission`` =
        Namespaced_IRI.parse _namespace_name "Core/LifecycleScopeType/decommission" |> NamespacedName

    /// <summary>
    /// A relationship has specific context implications during an element's design.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/design"></see></summary>
    let ``Core/LifecycleScopeType/design`` =
        Namespaced_IRI.parse _namespace_name "Core/LifecycleScopeType/design" |> NamespacedName

    /// <summary>
    /// A relationship has specific context implications during development phase of an element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/development"></see></summary>
    let ``Core/LifecycleScopeType/development`` =
        Namespaced_IRI.parse _namespace_name "Core/LifecycleScopeType/development" |> NamespacedName

    /// <summary>
    /// A relationship has other specific context information necessary to capture that the above set of enumerations does not handle.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/other"></see></summary>
    let ``Core/LifecycleScopeType/other`` =
        Namespaced_IRI.parse _namespace_name "Core/LifecycleScopeType/other" |> NamespacedName

    /// <summary>
    /// A relationship has specific context implications during the execution phase of an element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/runtime"></see></summary>
    let ``Core/LifecycleScopeType/runtime`` =
        Namespaced_IRI.parse _namespace_name "Core/LifecycleScopeType/runtime" |> NamespacedName

    /// <summary>
    /// A relationship has specific context implications during an element's testing phase, during development.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/test"></see></summary>
    let ``Core/LifecycleScopeType/test`` =
        Namespaced_IRI.parse _namespace_name "Core/LifecycleScopeType/test" |> NamespacedName

    /// <summary>
    /// A relationship has specific context implications for a product update.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/update"></see></summary>
    let ``Core/LifecycleScopeType/update`` =
        Namespaced_IRI.parse _namespace_name "Core/LifecycleScopeType/update" |> NamespacedName

    /// <summary>
    /// Capture the scope of information about a specific relationship between elements.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/scope"></see></summary>
    let ``Core/scope`` =
        Namespaced_IRI.parse _namespace_name "Core/scope" |> NamespacedName

    /// <summary>
    /// A known location is specified at this time.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/locationTime"></see></summary>
    let ``Core/locationTime`` =
        Namespaced_IRI.parse _namespace_name "Core/locationTime" |> NamespacedName

    /// <summary>
    /// A substitute for a URI.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/prefix"></see></summary>
    let ``Core/prefix`` =
        Namespaced_IRI.parse _namespace_name "Core/prefix" |> NamespacedName

    /// <summary>
    /// Provides an unambiguous mechanism for conveying a URI fragment portion of an
    /// Element ID.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/namespace"></see></summary>
    let ``Core/namespace`` =
        Namespaced_IRI.parse _namespace_name "Core/namespace" |> NamespacedName

    /// <summary>
    /// An Individual Value for Element representing a set of Elements of unknown
    /// identity or cardinality (number).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/NoAssertionElement"></see></summary>
    let ``Core/NoAssertionElement`` =
        Namespaced_IRI.parse _namespace_name "Core/NoAssertionElement" |> NamespacedName

    /// <summary>
    /// An Individual Value for Element representing a set of Elements with
    /// cardinality (number/count) of zero.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/NoneElement"></see></summary>
    let ``Core/NoneElement`` =
        Namespaced_IRI.parse _namespace_name "Core/NoneElement" |> NamespacedName

    /// <summary>
    /// The headquartersLocation defines the location of the organization's headquarters.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/headquartersLocation"></see></summary>
    let ``Core/headquartersLocation`` =
        Namespaced_IRI.parse _namespace_name "Core/headquartersLocation" |> NamespacedName

    /// <summary>
    /// The relative file name of a file to be excluded from the
    /// `PackageVerificationCode`.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/packageVerificationCodeExcludedFile"></see></summary>
    let ``Core/packageVerificationCodeExcludedFile`` =
        Namespaced_IRI.parse _namespace_name "Core/packageVerificationCodeExcludedFile" |> NamespacedName

    /// <summary>
    /// City is a specific name used to define a locality.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/city"></see></summary>
    let ``Core/city`` =
        Namespaced_IRI.parse _namespace_name "Core/city" |> NamespacedName

    /// <summary>
    /// A code that identifies a county.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/countyCode"></see></summary>
    let ``Core/countyCode`` =
        Namespaced_IRI.parse _namespace_name "Core/countyCode" |> NamespacedName

    /// <summary>
    /// The name of the recipient expressed in text.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/postalName"></see></summary>
    let ``Core/postalName`` =
        Namespaced_IRI.parse _namespace_name "Core/postalName" |> NamespacedName

    /// <summary>
    /// Text specifying a province or state.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/provinceStateCode"></see></summary>
    let ``Core/provinceStateCode`` =
        Namespaced_IRI.parse _namespace_name "Core/provinceStateCode" |> NamespacedName

    /// <summary>
    /// This is a set of point coordinates as defined in by the GPS standard.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/geographicPointLocation"></see></summary>
    let ``Core/geographicPointLocation`` =
        Namespaced_IRI.parse _namespace_name "Core/geographicPointLocation" |> NamespacedName

    /// <summary>
    /// Specifies a country code of the location.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/country"></see></summary>
    let ``Core/country`` =
        Namespaced_IRI.parse _namespace_name "Core/country" |> NamespacedName

    /// <summary>
    /// The number that identifies a PO box. A PO box is a box in a post office or other postal service location assigned to an organization where postal items may be kept.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/postOfficeBoxNumber"></see></summary>
    let ``Core/postOfficeBoxNumber`` =
        Namespaced_IRI.parse _namespace_name "Core/postOfficeBoxNumber" |> NamespacedName

    /// <summary>
    /// Street address includes a street number, name and unit ID to identify a specific street.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/streetAddress"></see></summary>
    let ``Core/streetAddress`` =
        Namespaced_IRI.parse _namespace_name "Core/streetAddress" |> NamespacedName

    /// <summary>
    /// Text specifying the postal code for an address.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/postalCode"></see></summary>
    let ``Core/postalCode`` =
        Namespaced_IRI.parse _namespace_name "Core/postalCode" |> NamespacedName

    /// <summary>
    /// Defines the end of a range.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/endIntegerRange"></see></summary>
    let ``Core/endIntegerRange`` =
        Namespaced_IRI.parse _namespace_name "Core/endIntegerRange" |> NamespacedName

    /// <summary>
    /// Defines the beginning of a range.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/beginIntegerRange"></see></summary>
    let ``Core/beginIntegerRange`` =
        Namespaced_IRI.parse _namespace_name "Core/beginIntegerRange" |> NamespacedName

    /// <summary>
    /// Specifies the time from which an element is no longer applicable / valid.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/endTime"></see></summary>
    let ``Core/endTime`` =
        Namespaced_IRI.parse _namespace_name "Core/endTime" |> NamespacedName

    /// <summary>
    /// References the Element on the left-hand side of a relationship.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/from"></see></summary>
    let ``Core/from`` =
        Namespaced_IRI.parse _namespace_name "Core/from" |> NamespacedName

    /// <summary>
    /// References an Element on the right-hand side of a relationship.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/to"></see></summary>
    let ``Core/to`` = Namespaced_IRI.parse _namespace_name "Core/to" |> NamespacedName

    /// <summary>
    /// Information about the relationship between two Elements.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType"></see></summary>
    let ``Core/RelationshipType`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType" |> NamespacedName

    /// <summary>
    /// The `from` Vulnerability, Action or DefinedProcess affects each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/affects"></see></summary>
    let ``Core/RelationshipType/affects`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/affects" |> NamespacedName

    /// <summary>
    /// The `from` Element is amended by each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/amendedBy"></see></summary>
    let ``Core/RelationshipType/amendedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/amendedBy" |> NamespacedName

    /// <summary>
    /// The `from` Element is an ancestor of each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/ancestorOf"></see></summary>
    let ``Core/RelationshipType/ancestorOf`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/ancestorOf" |> NamespacedName

    /// <summary>
    /// The `from` Element is available from the additional supplier described by each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/availableFrom"></see></summary>
    let ``Core/RelationshipType/availableFrom`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/availableFrom" |> NamespacedName

    /// <summary>
    /// The `from` Element is a configuration applied to each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/configures"></see></summary>
    let ``Core/RelationshipType/configures`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/configures" |> NamespacedName

    /// <summary>
    /// The `from` Element conforms to each `to` Specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/conformsTo"></see></summary>
    let ``Core/RelationshipType/conformsTo`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/conformsTo" |> NamespacedName

    /// <summary>
    /// The `from` Element contains each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/contains"></see></summary>
    let ``Core/RelationshipType/contains`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/contains" |> NamespacedName

    /// <summary>
    /// The `from` Vulnerability is coordinatedBy the `to` Agent(s) (vendor, researcher, or consumer agent).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/coordinatedBy"></see></summary>
    let ``Core/RelationshipType/coordinatedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/coordinatedBy" |> NamespacedName

    /// <summary>
    /// The `from` Element has been copied to each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/copiedTo"></see></summary>
    let ``Core/RelationshipType/copiedTo`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/copiedTo" |> NamespacedName

    /// <summary>
    /// The `from` Element's Action or DefinedProcess is createdBy `to` Agent(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/createdBy"></see></summary>
    let ``Core/RelationshipType/createdBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/createdBy" |> NamespacedName

    /// <summary>
    /// The `from` Agent is delegating an action to the Agent of the `to` Relationship (which shall be of type invokedBy), during a LifecycleScopeType (e.g. the `to` invokedBy Relationship is being done on behalf of `from`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/delegatedTo"></see></summary>
    let ``Core/RelationshipType/delegatedTo`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/delegatedTo" |> NamespacedName

    /// <summary>
    /// The `from` Element depends on each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/dependsOn"></see></summary>
    let ``Core/RelationshipType/dependsOn`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/dependsOn" |> NamespacedName

    /// <summary>
    /// The `from` Element is a descendant of each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/descendantOf"></see></summary>
    let ``Core/RelationshipType/descendantOf`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/descendantOf" |> NamespacedName

    /// <summary>
    /// The `from` Element describes each `to` Element. To denote the root(s) of a tree of elements in a collection, the rootElement property shall be used.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/describes"></see></summary>
    let ``Core/RelationshipType/describes`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/describes" |> NamespacedName

    /// <summary>
    /// The `from` Vulnerability has no impact on each `to` Element. The use of the `doesNotAffect` is constrained to `VexNotAffectedVulnAssessmentRelationship` classed relationships.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/doesNotAffect"></see></summary>
    let ``Core/RelationshipType/doesNotAffect`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/doesNotAffect" |> NamespacedName

    /// <summary>
    /// The `from` Element has been evaluated on the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/evaluatedOn"></see></summary>
    let ``Core/RelationshipType/evaluatedOn`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/evaluatedOn" |> NamespacedName

    /// <summary>
    /// The `from` Element expands out as an artifact described by each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/expandsTo"></see></summary>
    let ``Core/RelationshipType/expandsTo`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/expandsTo" |> NamespacedName

    /// <summary>
    /// The `from` Vulnerability has had an exploit created against it by each `to` Agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/exploitCreatedBy"></see></summary>
    let ``Core/RelationshipType/exploitCreatedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/exploitCreatedBy" |> NamespacedName

    /// <summary>
    /// The `from` Element has been finetuned on the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/finetunedOn"></see></summary>
    let ``Core/RelationshipType/finetunedOn`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/finetunedOn" |> NamespacedName

    /// <summary>
    /// Designates a `from` Vulnerability has been fixed by the `to` Agent(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/fixedBy"></see></summary>
    let ``Core/RelationshipType/fixedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/fixedBy" |> NamespacedName

    /// <summary>
    /// A `from` Vulnerability has been fixed in each `to` Element. The use of the `fixedIn` type is constrained to `VexFixedVulnAssessmentRelationship` classed relationships.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/fixedIn"></see></summary>
    let ``Core/RelationshipType/fixedIn`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/fixedIn" |> NamespacedName

    /// <summary>
    /// The `to` Element succeeds the `from` Element, establishing a unidirectional sequence. This succession is defined as chronological, procedural, or logical. It is used to represent either a temporal order (e.g., in a workflow) or a logical order for processing and traversal (e.g., in an ordered list).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/follows"></see></summary>
    let ``Core/RelationshipType/follows`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/follows" |> NamespacedName

    /// <summary>
    /// Designates a `from` Vulnerability was originally discovered by the `to` Agent(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/foundBy"></see></summary>
    let ``Core/RelationshipType/foundBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/foundBy" |> NamespacedName

    /// <summary>
    /// The `from` Element generates each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/generates"></see></summary>
    let ``Core/RelationshipType/generates`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/generates" |> NamespacedName

    /// <summary>
    /// Every `to` Element is a file added to the `from` Element (`from` hasAddedFile `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAddedFile"></see></summary>
    let ``Core/RelationshipType/hasAddedFile`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasAddedFile" |> NamespacedName

    /// <summary>
    /// Relates a `from` Vulnerability and each `to` Element with a security assessment. To be used with `VulnAssessmentRelationship` types.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAssessmentFor"></see></summary>
    let ``Core/RelationshipType/hasAssessmentFor`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasAssessmentFor" |> NamespacedName

    /// <summary>
    /// Used to associate a `from` Artifact with each `to` Vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAssociatedVulnerability"></see></summary>
    let ``Core/RelationshipType/hasAssociatedVulnerability`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasAssociatedVulnerability" |> NamespacedName

    /// <summary>
    /// The `from` SoftwareArtifact is concluded by the SPDX data creator to be governed by each `to` AnyLicenseInfo.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasConcludedLicense"></see></summary>
    let ``Core/RelationshipType/hasConcludedLicense`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasConcludedLicense" |> NamespacedName

    /// <summary>
    /// The `from` Artifact has each `to` Agent as a contact point. The use of `hasContactPoint` type is constrained to `ContactPointRelationship` typed relationships. The type of contact (i.e. security) may be specified using a `ContactPointRelationship` element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasContactPoint"></see></summary>
    let ``Core/RelationshipType/hasContactPoint`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasContactPoint" |> NamespacedName

    /// <summary>
    /// The `from` Element treats each `to` Element as a data file. A data file is an artifact that stores data required or optional for the `from` Element's functionality. A data file can be a database file, an index file, a log file, an AI model file, a calibration data file, a temporary file, a backup file, and more. For AI training dataset, test dataset, test artifact, configuration data, build input data, and build output data, please consider using the more specific relationship types: `trainedOn`, `testedOn`, `hasTest`, `configures`, `hasInput`, and `hasOutput`, respectively. This relationship does not imply dependency.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDataFile"></see></summary>
    let ``Core/RelationshipType/hasDataFile`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasDataFile" |> NamespacedName

    /// <summary>
    /// The `from` SoftwareArtifact was discovered to actually contain each `to` AnyLicenseInfo (for example, as detected by automated tooling).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDeclaredLicense"></see></summary>
    let ``Core/RelationshipType/hasDeclaredLicense`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasDeclaredLicense" |> NamespacedName

    /// <summary>
    /// Every `to` Element is a file deleted from the `from` Element (`from` hasDeletedFile `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDeletedFile"></see></summary>
    let ``Core/RelationshipType/hasDeletedFile`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasDeletedFile" |> NamespacedName

    /// <summary>
    /// The `from` Element has manifest files that contain dependency information in each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDependencyManifest"></see></summary>
    let ``Core/RelationshipType/hasDependencyManifest`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasDependencyManifest" |> NamespacedName

    /// <summary>
    /// The `from` Element is distributed as an artifact in each `to` Element (e.g. an RPM or archive file).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDistributionArtifact"></see></summary>
    let ``Core/RelationshipType/hasDistributionArtifact`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasDistributionArtifact" |> NamespacedName

    /// <summary>
    /// The `from` Element is documented by each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDocumentation"></see></summary>
    let ``Core/RelationshipType/hasDocumentation`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasDocumentation" |> NamespacedName

    /// <summary>
    /// The `from` Element dynamically links in each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDynamicLink"></see></summary>
    let ``Core/RelationshipType/hasDynamicLink`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasDynamicLink" |> NamespacedName

    /// <summary>
    /// Every `to` Element is considered as evidence for the `from` Element (`from` hasEvidence `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasEvidence"></see></summary>
    let ``Core/RelationshipType/hasEvidence`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasEvidence" |> NamespacedName

    /// <summary>
    /// Every `to` Element is an example for the `from` Element (`from` hasExample `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasExample"></see></summary>
    let ``Core/RelationshipType/hasExample`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasExample" |> NamespacedName

    /// <summary>
    /// The `from` Build was run on the `to` Element during a LifecycleScopeType period (e.g. the host that the build runs on).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasHost"></see></summary>
    let ``Core/RelationshipType/hasHost`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasHost" |> NamespacedName

    /// <summary>
    /// The `from` Build, DefinedProcess or Action element has each `to` Element as an input.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasInput"></see></summary>
    let ``Core/RelationshipType/hasInput`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasInput" |> NamespacedName

    /// <summary>
    /// Every `to` Element is metadata about the `from` Element (`from` hasMetadata `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasMetadata"></see></summary>
    let ``Core/RelationshipType/hasMetadata`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasMetadata" |> NamespacedName

    /// <summary>
    /// Every `to` Element is an optional component of the `from` Element (`from` hasOptionalComponent `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOptionalComponent"></see></summary>
    let ``Core/RelationshipType/hasOptionalComponent`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasOptionalComponent" |> NamespacedName

    /// <summary>
    /// The `from` Element optionally depends on each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOptionalDependency"></see></summary>
    let ``Core/RelationshipType/hasOptionalDependency`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasOptionalDependency" |> NamespacedName

    /// <summary>
    /// The `from` Build, DefinedProcess or Action element generates each `to` Element as an output.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOutput"></see></summary>
    let ``Core/RelationshipType/hasOutput`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasOutput" |> NamespacedName

    /// <summary>
    /// The `from` Element has a prerequisite on each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasPrerequisite"></see></summary>
    let ``Core/RelationshipType/hasPrerequisite`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasPrerequisite" |> NamespacedName

    /// <summary>
    /// The `from` Element has a dependency on each `to` Element, dependency is not in the distributed artifact, but assumed to be provided, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasProvidedDependency"></see></summary>
    let ``Core/RelationshipType/hasProvidedDependency`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasProvidedDependency" |> NamespacedName

    /// <summary>
    /// The `from` Element has a requirement on each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasRequirement"></see></summary>
    let ``Core/RelationshipType/hasRequirement`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasRequirement" |> NamespacedName

    /// <summary>
    /// The `from` ResolutionAction point to the `to` OutOfSpecAction that is addressed.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasResolution"></see></summary>
    let ``Core/RelationshipType/hasResolution`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasResolution" |> NamespacedName

    /// <summary>
    /// Every `to` Element is a specification for the `from` Element (`from` hasSpecification `to`), during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasSpecification"></see></summary>
    let ``Core/RelationshipType/hasSpecification`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasSpecification" |> NamespacedName

    /// <summary>
    /// The `from` Element statically links in each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasStaticLink"></see></summary>
    let ``Core/RelationshipType/hasStaticLink`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasStaticLink" |> NamespacedName

    /// <summary>
    /// Every `to` Element is a test artifact for the `from` Element (`from` hasTest `to`), during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasTest"></see></summary>
    let ``Core/RelationshipType/hasTest`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasTest" |> NamespacedName

    /// <summary>
    /// Every `to` Element is a test case for the `from` Element (`from` hasTestCase `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasTestCase"></see></summary>
    let ``Core/RelationshipType/hasTestCase`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasTestCase" |> NamespacedName

    /// <summary>
    /// Every `to` Element is a variant the `from` Element (`from` hasVariant `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasVariant"></see></summary>
    let ``Core/RelationshipType/hasVariant`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/hasVariant" |> NamespacedName

    /// <summary>
    /// The `from` Requirement is implemented in the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/implementedBy"></see></summary>
    let ``Core/RelationshipType/implementedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/implementedBy" |> NamespacedName

    /// <summary>
    /// The `from` Element was invoked by the `to` Agent, during a LifecycleScopeType period (for example, a Build element that describes a build step).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/invokedBy"></see></summary>
    let ``Core/RelationshipType/invokedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/invokedBy" |> NamespacedName

    /// <summary>
    /// `from` element located at a specific `to` location. A time period is optional.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/locatedAt"></see></summary>
    let ``Core/RelationshipType/locatedAt`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/locatedAt" |> NamespacedName

    /// <summary>
    /// The `from` Element is modified by each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/modifiedBy"></see></summary>
    let ``Core/RelationshipType/modifiedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/modifiedBy" |> NamespacedName

    /// <summary>
    /// Every `to` Element is related to the `from` Element where the relationship type is not described by any of the SPDX relationship types (this relationship is directionless).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/other"></see></summary>
    let ``Core/RelationshipType/other`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/other" |> NamespacedName

    /// <summary>
    /// Every `to` Element is a packaged instance of the `from` Element (`from` packagedBy `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/packagedBy"></see></summary>
    let ``Core/RelationshipType/packagedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/packagedBy" |> NamespacedName

    /// <summary>
    /// Every `to` Element is a patch for the `from` Element (`from` patchedBy `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/patchedBy"></see></summary>
    let ``Core/RelationshipType/patchedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/patchedBy" |> NamespacedName

    /// <summary>
    /// The `from` Element has been pretrained on the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/pretrainedOn"></see></summary>
    let ``Core/RelationshipType/pretrainedOn`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/pretrainedOn" |> NamespacedName

    /// <summary>
    /// The `from` Agent provides support for each `to` Artifact. Shall be a `SupportRelationship` type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/providesSupportFor"></see></summary>
    let ``Core/RelationshipType/providesSupportFor`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/providesSupportFor" |> NamespacedName

    /// <summary>
    /// Every `from` action is performedBy `to` Agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/performedBy"></see></summary>
    let ``Core/RelationshipType/performedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/performedBy" |> NamespacedName

    /// <summary>
    /// Designates a `from` Vulnerability was made available for public use or reference by each `to` Agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/publishedBy"></see></summary>
    let ``Core/RelationshipType/publishedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/publishedBy" |> NamespacedName

    /// <summary>
    /// Designates a `from` Vulnerability was first reported to a project, vendor, or tracking database for formal identification by each `to` Agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/reportedBy"></see></summary>
    let ``Core/RelationshipType/reportedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/reportedBy" |> NamespacedName

    /// <summary>
    /// Designates a `from` Vulnerability's details were tracked, aggregated, and/or enriched to improve context (i.e. NVD) by each `to` Agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/republishedBy"></see></summary>
    let ``Core/RelationshipType/republishedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/republishedBy" |> NamespacedName

    /// <summary>
    /// The `to` OutOfSpecAction is resolved in the `from` ResolutionAction.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/resolved"></see></summary>
    let ``Core/RelationshipType/resolved`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/resolved" |> NamespacedName

    /// <summary>
    /// The `from` Element (the instructions) of runs on each `to` Hardware (processing element), during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/runsOn"></see></summary>
    let ``Core/RelationshipType/runsOn`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/runsOn" |> NamespacedName

    /// <summary>
    /// The `from` SpdxDocument can be found in a serialized form in each `to` Artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/serializedInArtifact"></see></summary>
    let ``Core/RelationshipType/serializedInArtifact`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/serializedInArtifact" |> NamespacedName

    /// <summary>
    /// The `from` Element has been tested on the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/testedOn"></see></summary>
    let ``Core/RelationshipType/testedOn`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/testedOn" |> NamespacedName

    /// <summary>
    /// the `from` Requirement is refined and further elaborated by each `to` Requirement, which contains more detailed implementation information.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/tracedToDetail"></see></summary>
    let ``Core/RelationshipType/tracedToDetail`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/tracedToDetail" |> NamespacedName

    /// <summary>
    /// The `from` Element has been trained on the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/trainedOn"></see></summary>
    let ``Core/RelationshipType/trainedOn`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/trainedOn" |> NamespacedName

    /// <summary>
    /// The `from` Vulnerability impact is being investigated for each `to` Element. The use of the `underInvestigationFor` type is constrained to `VexUnderInvestigationVulnAssessmentRelationship` classed relationships.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/underInvestigationFor"></see></summary>
    let ``Core/RelationshipType/underInvestigationFor`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/underInvestigationFor" |> NamespacedName

    /// <summary>
    /// The `from` Element uses each `to` Element as a tool, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/usesTool"></see></summary>
    let ``Core/RelationshipType/usesTool`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/usesTool" |> NamespacedName

    /// <summary>
    /// The `from` Element has been validated on the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/validatedOn"></see></summary>
    let ``Core/RelationshipType/validatedOn`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/validatedOn" |> NamespacedName

    /// <summary>
    /// The `from` Requirement that has verification (test, review, analysis etc.) details defined in the `to` RequirementVerification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/verifiedBy"></see></summary>
    let ``Core/RelationshipType/verifiedBy`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipType/verifiedBy" |> NamespacedName

    /// <summary>
    /// Information about the relationship between two Elements.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/relationshipType"></see></summary>
    let ``Core/relationshipType`` =
        Namespaced_IRI.parse _namespace_name "Core/relationshipType" |> NamespacedName

    /// <summary>
    /// Indicates whether a relationship is known to be complete, incomplete, or if no assertion is made with respect to relationship completeness.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness"></see></summary>
    let ``Core/RelationshipCompleteness`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipCompleteness" |> NamespacedName

    /// <summary>
    /// The relationship is known not to be exhaustive.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/incomplete"></see></summary>
    let ``Core/RelationshipCompleteness/incomplete`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipCompleteness/incomplete" |> NamespacedName

    /// <summary>
    /// The relationship is known to be exhaustive.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/complete"></see></summary>
    let ``Core/RelationshipCompleteness/complete`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipCompleteness/complete" |> NamespacedName

    /// <summary>
    /// No assertion can be made about the completeness of the relationship.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/noAssertion"></see></summary>
    let ``Core/RelationshipCompleteness/noAssertion`` =
        Namespaced_IRI.parse _namespace_name "Core/RelationshipCompleteness/noAssertion" |> NamespacedName

    /// <summary>
    /// Provides information about the completeness of relationships.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/completeness"></see></summary>
    let ``Core/completeness`` =
        Namespaced_IRI.parse _namespace_name "Core/completeness" |> NamespacedName

    /// <summary>
    /// Specifies the time from which an element is applicable / valid.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/startTime"></see></summary>
    let ``Core/startTime`` =
        Namespaced_IRI.parse _namespace_name "Core/startTime" |> NamespacedName

    /// <summary>
    /// A text describing the actual need defined by the requirement.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/requirementStatement"></see></summary>
    let ``Core/requirementStatement`` =
        Namespaced_IRI.parse _namespace_name "Core/requirementStatement" |> NamespacedName

    /// <summary>
    /// The product lifecycle phase, the requirement is applicable for.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/devLifecycleStage"></see></summary>
    let ``Core/devLifecycleStage`` =
        Namespaced_IRI.parse _namespace_name "Core/devLifecycleStage" |> NamespacedName

    /// <summary>
    /// Provides a universally unique Requirement ID.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/requirementUUID"></see></summary>
    let ``Core/requirementUUID`` =
        Namespaced_IRI.parse _namespace_name "Core/requirementUUID" |> NamespacedName

    /// <summary>
    /// Text used to define the rationale or additional information.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/requirementRationale"></see></summary>
    let ``Core/requirementRationale`` =
        Namespaced_IRI.parse _namespace_name "Core/requirementRationale" |> NamespacedName

    /// <summary>
    /// Abstract class representing a license combination consisting of one or more licenses.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/AnyLicenseInfo"></see></summary>
    let ``SimpleLicensing/AnyLicenseInfo`` =
        Namespaced_IRI.parse _namespace_name "SimpleLicensing/AnyLicenseInfo" |> NamespacedName

    /// <summary>
    /// Provides the license under which the SPDX documentation of the Element can be
    /// used.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/dataLicense"></see></summary>
    let ``Core/dataLicense`` =
        Namespaced_IRI.parse _namespace_name "Core/dataLicense" |> NamespacedName

    /// <summary>
    /// Provides a NamespaceMap of prefixes and associated namespace partial URIs applicable to an SpdxDocument and independent of any specific serialization format or instance.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/namespaceMap"></see></summary>
    let ``Core/namespaceMap`` =
        Namespaced_IRI.parse _namespace_name "Core/namespaceMap" |> NamespacedName

    /// <summary>
    /// Provides an ExternalMap of Element identifiers.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/import"></see></summary>
    let ``Core/import`` =
        Namespaced_IRI.parse _namespace_name "Core/import" |> NamespacedName

    /// <summary>
    /// A specification type defines the nature of a specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType"></see></summary>
    let ``Core/SpecificationType`` =
        Namespaced_IRI.parse _namespace_name "Core/SpecificationType" |> NamespacedName

    /// <summary>
    /// A formal standard is a standard ratified by a recognized standards-development organization and published as a normative reference.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/formalStandard"></see></summary>
    let ``Core/SpecificationType/formalStandard`` =
        Namespaced_IRI.parse _namespace_name "Core/SpecificationType/formalStandard" |> NamespacedName

    /// <summary>
    /// A mandatory legal specification issued by a governmental or regulatory authority. Compliance is enforceable by law.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/regulation"></see></summary>
    let ``Core/SpecificationType/regulation`` =
        Namespaced_IRI.parse _namespace_name "Core/SpecificationType/regulation" |> NamespacedName

    /// <summary>
    /// A specification is a detailed document (or set of documents) that describes the requirements, design, behavior, or other characteristics of a system, component, or process so that all stakeholders have a clear, unambiguous reference.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/specification"></see></summary>
    let ``Core/SpecificationType/specification`` =
        Namespaced_IRI.parse _namespace_name "Core/SpecificationType/specification" |> NamespacedName

    /// <summary>
    /// Any specification that does not fall under any of the other entries.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/other"></see></summary>
    let ``Core/SpecificationType/other`` =
        Namespaced_IRI.parse _namespace_name "Core/SpecificationType/other" |> NamespacedName

    /// <summary>
    /// A specification type defines the nature of a specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/specType"></see></summary>
    let ``Core/specType`` =
        Namespaced_IRI.parse _namespace_name "Core/specType" |> NamespacedName

    /// <summary>
    /// Quantity is the amount in the selected QUDT unit.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/quantity"></see></summary>
    let ``Core/quantity`` =
        Namespaced_IRI.parse _namespace_name "Core/quantity" |> NamespacedName

    /// <summary>
    /// QUDT unit is used for measurement criteria based on product type, region and use.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/unitQUDT"></see></summary>
    let ``Core/unitQUDT`` =
        Namespaced_IRI.parse _namespace_name "Core/unitQUDT" |> NamespacedName

    /// <summary>
    /// A characterization of some aspect of an Element that is associated with the Element in a generalized fashion.
    /// <see href="https://spdx.org/rdf/3.1/terms/Extension/Extension"></see></summary>
    let ``Extension/Extension`` =
        Namespaced_IRI.parse _namespace_name "Extension/Extension" |> NamespacedName

    /// <summary>
    /// Specifies a human language used within the content of an Element or a property.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/inLanguage"></see></summary>
    let ``Core/inLanguage`` =
        Namespaced_IRI.parse _namespace_name "Core/inLanguage" |> NamespacedName

    /// <summary>
    /// Confidentiality level.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType"></see></summary>
    let ``Dataset/ConfidentialityLevelType`` =
        Namespaced_IRI.parse _namespace_name "Dataset/ConfidentialityLevelType" |> NamespacedName

    /// <summary>
    /// Data points in the dataset can be shared only with specific organizations and their clients on a need to know basis.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/amber"></see></summary>
    let ``Dataset/ConfidentialityLevelType/amber`` =
        Namespaced_IRI.parse _namespace_name "Dataset/ConfidentialityLevelType/amber" |> NamespacedName

    /// <summary>
    /// Dataset may be distributed freely, without restriction.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/clear"></see></summary>
    let ``Dataset/ConfidentialityLevelType/clear`` =
        Namespaced_IRI.parse _namespace_name "Dataset/ConfidentialityLevelType/clear" |> NamespacedName

    /// <summary>
    /// Dataset can be shared within a community of peers and partners.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/green"></see></summary>
    let ``Dataset/ConfidentialityLevelType/green`` =
        Namespaced_IRI.parse _namespace_name "Dataset/ConfidentialityLevelType/green" |> NamespacedName

    /// <summary>
    /// Data points in the dataset are highly confidential and can only be shared with named recipients.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/red"></see></summary>
    let ``Dataset/ConfidentialityLevelType/red`` =
        Namespaced_IRI.parse _namespace_name "Dataset/ConfidentialityLevelType/red" |> NamespacedName

    /// <summary>
    /// Availability of dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType"></see></summary>
    let ``Dataset/DatasetAvailabilityType`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetAvailabilityType" |> NamespacedName

    /// <summary>
    /// Dataset is not publicly available and can only be accessed after affirmatively accepting terms on a clickthrough webpage.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/clickthrough"></see></summary>
    let ``Dataset/DatasetAvailabilityType/clickthrough`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetAvailabilityType/clickthrough" |> NamespacedName

    /// <summary>
    /// Dataset is publicly available and can be downloaded directly.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/directDownload"></see></summary>
    let ``Dataset/DatasetAvailabilityType/directDownload`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetAvailabilityType/directDownload" |> NamespacedName

    /// <summary>
    /// Dataset is publicly available, but not all at once, and can only be accessed through queries which return parts of the dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/query"></see></summary>
    let ``Dataset/DatasetAvailabilityType/query`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetAvailabilityType/query" |> NamespacedName

    /// <summary>
    /// Dataset is not publicly available and an email registration is required before accessing the dataset, although without an affirmative acceptance of terms.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/registration"></see></summary>
    let ``Dataset/DatasetAvailabilityType/registration`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetAvailabilityType/registration" |> NamespacedName

    /// <summary>
    /// Dataset provider is not making available the underlying data and the dataset shall be reassembled, typically using the provided script for scraping the data.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/scrapingScript"></see></summary>
    let ``Dataset/DatasetAvailabilityType/scrapingScript`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetAvailabilityType/scrapingScript" |> NamespacedName

    /// <summary>
    /// Mechanism to update the dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/datasetUpdateMechanism"></see></summary>
    let ``Dataset/datasetUpdateMechanism`` =
        Namespaced_IRI.parse _namespace_name "Dataset/datasetUpdateMechanism" |> NamespacedName

    /// <summary>
    /// Preprocessing steps that were applied to the raw data to create the given dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/dataPreprocessing"></see></summary>
    let ``Dataset/dataPreprocessing`` =
        Namespaced_IRI.parse _namespace_name "Dataset/dataPreprocessing" |> NamespacedName

    /// <summary>
    /// **DEPRECATED in SPDX 3.1.**
    /// Use [/Core/intendedUse](../../Core/Properties/intendedUse.md) instead.
    ///
    /// The intended use of a given dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/intendedUse"></see></summary>
    let ``Dataset/intendedUse`` =
        Namespaced_IRI.parse _namespace_name "Dataset/intendedUse" |> NamespacedName

    /// <summary>
    /// Describes a sensor used for collecting the data.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/sensor"></see></summary>
    let ``Dataset/sensor`` =
        Namespaced_IRI.parse _namespace_name "Dataset/sensor" |> NamespacedName

    /// <summary>
    /// How the dataset was collected.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/dataCollectionProcess"></see></summary>
    let ``Dataset/dataCollectionProcess`` =
        Namespaced_IRI.parse _namespace_name "Dataset/dataCollectionProcess" |> NamespacedName

    /// <summary>
    /// Potentially noisy elements of the dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/datasetNoise"></see></summary>
    let ``Dataset/datasetNoise`` =
        Namespaced_IRI.parse _namespace_name "Dataset/datasetNoise" |> NamespacedName

    /// <summary>
    /// Availability of a dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/datasetAvailability"></see></summary>
    let ``Dataset/datasetAvailability`` =
        Namespaced_IRI.parse _namespace_name "Dataset/datasetAvailability" |> NamespacedName

    /// <summary>
    /// Enumeration of dataset types.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType"></see></summary>
    let ``Dataset/DatasetType`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType" |> NamespacedName

    /// <summary>
    /// Data is audio based, such as a collection of music from the 80s.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/audio"></see></summary>
    let ``Dataset/DatasetType/audio`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/audio" |> NamespacedName

    /// <summary>
    /// Data that is classified into a discrete number of categories, such as the eye color of a population of people.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/categorical"></see></summary>
    let ``Dataset/DatasetType/categorical`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/categorical" |> NamespacedName

    /// <summary>
    /// Data is in the form of a graph where entries are somehow related to each other through edges, such a social network of friends.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/graph"></see></summary>
    let ``Dataset/DatasetType/graph`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/graph" |> NamespacedName

    /// <summary>
    /// Data is a collection of images such as pictures of animals.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/image"></see></summary>
    let ``Dataset/DatasetType/image`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/image" |> NamespacedName

    /// <summary>
    /// Data type is not known.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/noAssertion"></see></summary>
    let ``Dataset/DatasetType/noAssertion`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/noAssertion" |> NamespacedName

    /// <summary>
    /// Data consists only of numeric entries.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/numeric"></see></summary>
    let ``Dataset/DatasetType/numeric`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/numeric" |> NamespacedName

    /// <summary>
    /// Data is of a type not included in this list.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/other"></see></summary>
    let ``Dataset/DatasetType/other`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/other" |> NamespacedName

    /// <summary>
    /// Data is recorded from a physical sensor, such as a thermometer reading or biometric device.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/sensor"></see></summary>
    let ``Dataset/DatasetType/sensor`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/sensor" |> NamespacedName

    /// <summary>
    /// Data is stored in tabular format or retrieved from a relational database.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/structured"></see></summary>
    let ``Dataset/DatasetType/structured`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/structured" |> NamespacedName

    /// <summary>
    /// Data describes the syntax or semantics of a language or text, such as a parse tree used for natural language processing.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/syntactic"></see></summary>
    let ``Dataset/DatasetType/syntactic`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/syntactic" |> NamespacedName

    /// <summary>
    /// Data consists of unstructured text, such as a book, a Wikipedia article (without images), or a transcript.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/text"></see></summary>
    let ``Dataset/DatasetType/text`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/text" |> NamespacedName

    /// <summary>
    /// Data is recorded in an ordered sequence of timestamped entries, such as the price of a stock over the course of a day.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/timeseries"></see></summary>
    let ``Dataset/DatasetType/timeseries`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/timeseries" |> NamespacedName

    /// <summary>
    /// Data is recorded with a timestamp for each entry, but not necessarily ordered or at specific intervals, such as when a taxi ride starts and ends.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/timestamp"></see></summary>
    let ``Dataset/DatasetType/timestamp`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/timestamp" |> NamespacedName

    /// <summary>
    /// Data is video based, such as a collection of movie clips featuring Tom Hanks.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/video"></see></summary>
    let ``Dataset/DatasetType/video`` =
        Namespaced_IRI.parse _namespace_name "Dataset/DatasetType/video" |> NamespacedName

    /// <summary>
    /// Type of data in a dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/datasetType"></see></summary>
    let ``Dataset/datasetType`` =
        Namespaced_IRI.parse _namespace_name "Dataset/datasetType" |> NamespacedName

    /// <summary>
    /// Records the biases that the dataset is known to encompass.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/knownBias"></see></summary>
    let ``Dataset/knownBias`` =
        Namespaced_IRI.parse _namespace_name "Dataset/knownBias" |> NamespacedName

    /// <summary>
    /// Confidentiality level of the data points contained in the dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/confidentialityLevel"></see></summary>
    let ``Dataset/confidentialityLevel`` =
        Namespaced_IRI.parse _namespace_name "Dataset/confidentialityLevel" |> NamespacedName

    /// <summary>
    /// Describes if any sensitive personal information is present in the dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/hasSensitivePersonalInformation"></see></summary>
    let ``Dataset/hasSensitivePersonalInformation`` =
        Namespaced_IRI.parse _namespace_name "Dataset/hasSensitivePersonalInformation" |> NamespacedName

    /// <summary>
    /// **DEPRECATED in SPDX 3.1.**
    /// Use [/Software/artifactSize](../../Software/Properties/artifactSize.md)
    /// instead.
    ///
    /// Size of the dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/datasetSize"></see></summary>
    let ``Dataset/datasetSize`` =
        Namespaced_IRI.parse _namespace_name "Dataset/datasetSize" |> NamespacedName

    /// <summary>
    /// Anonymization methods used.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/anonymizationMethodUsed"></see></summary>
    let ``Dataset/anonymizationMethodUsed`` =
        Namespaced_IRI.parse _namespace_name "Dataset/anonymizationMethodUsed" |> NamespacedName

    /// <summary>
    /// A license expression participating in a license set.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/member"></see></summary>
    let ``ExpandedLicensing/member`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/member" |> NamespacedName

    /// <summary>
    /// Abstract class for the portion of an AnyLicenseInfo representing a license.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/License"></see></summary>
    let ``ExpandedLicensing/License`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/License" |> NamespacedName

    /// <summary>
    /// Abstract class for additional text intended to be added to a License, but
    /// which is not itself a standalone License.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/LicenseAddition"></see></summary>
    let ``ExpandedLicensing/LicenseAddition`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/LicenseAddition" |> NamespacedName

    /// <summary>
    /// Abstract class representing a License or an OrLaterOperator.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ExtendableLicense"></see></summary>
    let ``ExpandedLicensing/ExtendableLicense`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/ExtendableLicense" |> NamespacedName

    /// <summary>
    /// Identifies the full text of a License or Addition.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseText"></see></summary>
    let ``SimpleLicensing/licenseText`` =
        Namespaced_IRI.parse _namespace_name "SimpleLicensing/licenseText" |> NamespacedName

    /// <summary>
    /// Specifies whether the License is listed as approved by the
    /// Open Source Initiative (OSI).
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isOsiApproved"></see></summary>
    let ``ExpandedLicensing/isOsiApproved`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/isOsiApproved" |> NamespacedName

    /// <summary>
    /// Specifies the licenseId that is preferred to be used in place of a deprecated
    /// License or LicenseAddition.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/obsoletedBy"></see></summary>
    let ``ExpandedLicensing/obsoletedBy`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/obsoletedBy" |> NamespacedName

    /// <summary>
    /// Identifies all the text and metadata associated with a license in the license
    /// XML format.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/licenseXml"></see></summary>
    let ``ExpandedLicensing/licenseXml`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/licenseXml" |> NamespacedName

    /// <summary>
    /// Specifies whether a license or additional text identifier has been marked as
    /// deprecated.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isDeprecatedLicenseId"></see></summary>
    let ``ExpandedLicensing/isDeprecatedLicenseId`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/isDeprecatedLicenseId" |> NamespacedName

    /// <summary>
    /// Contains a URL where the License or LicenseAddition can be found in use.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/seeAlso"></see></summary>
    let ``ExpandedLicensing/seeAlso`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/seeAlso" |> NamespacedName

    /// <summary>
    /// Specifies whether the License is listed as free by the
    /// Free Software Foundation (FSF).
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isFsfLibre"></see></summary>
    let ``ExpandedLicensing/isFsfLibre`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/isFsfLibre" |> NamespacedName

    /// <summary>
    /// Identifies the full text of a License, in SPDX templating format.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardLicenseTemplate"></see></summary>
    let ``ExpandedLicensing/standardLicenseTemplate`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/standardLicenseTemplate" |> NamespacedName

    /// <summary>
    /// Provides a License author's preferred text to indicate that a file is covered
    /// by the License.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardLicenseHeader"></see></summary>
    let ``ExpandedLicensing/standardLicenseHeader`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/standardLicenseHeader" |> NamespacedName

    /// <summary>
    /// Specifies whether an additional text identifier has been marked as deprecated.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isDeprecatedAdditionId"></see></summary>
    let ``ExpandedLicensing/isDeprecatedAdditionId`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/isDeprecatedAdditionId" |> NamespacedName

    /// <summary>
    /// Identifies the full text of a LicenseAddition, in SPDX templating format.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardAdditionTemplate"></see></summary>
    let ``ExpandedLicensing/standardAdditionTemplate`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/standardAdditionTemplate" |> NamespacedName

    /// <summary>
    /// Identifies the full text of a LicenseAddition.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/additionText"></see></summary>
    let ``ExpandedLicensing/additionText`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/additionText" |> NamespacedName

    /// <summary>
    /// Specifies the SPDX License List version in which this license or exception
    /// identifier was deprecated.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/deprecatedVersion"></see></summary>
    let ``ExpandedLicensing/deprecatedVersion`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/deprecatedVersion" |> NamespacedName

    /// <summary>
    /// Specifies the SPDX License List version in which this ListedLicense or
    /// ListedLicenseException identifier was first added.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/listVersionAdded"></see></summary>
    let ``ExpandedLicensing/listVersionAdded`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/listVersionAdded" |> NamespacedName

    /// <summary>
    /// An Individual Value for License when no assertion can be made about its actual
    /// value.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/NoAssertionLicense"></see></summary>
    let ``ExpandedLicensing/NoAssertionLicense`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/NoAssertionLicense" |> NamespacedName

    /// <summary>
    ///   <see href="https://spdx.org/rdf/3.1/terms/Licensing/NoAssertion"></see>
    /// </summary>
    let ``Licensing/NoAssertion`` =
        Namespaced_IRI.parse _namespace_name "Licensing/NoAssertion" |> NamespacedName

    /// <summary>
    /// An Individual Value for License where the SPDX data creator determines that no
    /// license is present.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/NoneLicense"></see></summary>
    let ``ExpandedLicensing/NoneLicense`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/NoneLicense" |> NamespacedName

    /// <summary>
    ///   <see href="https://spdx.org/rdf/3.1/terms/Licensing/None"></see>
    /// </summary>
    let ``Licensing/None`` =
        Namespaced_IRI.parse _namespace_name "Licensing/None" |> NamespacedName

    /// <summary>
    /// A License participating in an 'or later' model.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectLicense"></see></summary>
    let ``ExpandedLicensing/subjectLicense`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/subjectLicense" |> NamespacedName

    /// <summary>
    /// A LicenseAddition participating in a 'with addition' model.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectAddition"></see></summary>
    let ``ExpandedLicensing/subjectAddition`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/subjectAddition" |> NamespacedName

    /// <summary>
    /// A License participating in a 'with addition' model.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectExtendableLicense"></see></summary>
    let ``ExpandedLicensing/subjectExtendableLicense`` =
        Namespaced_IRI.parse _namespace_name "ExpandedLicensing/subjectExtendableLicense" |> NamespacedName

    /// <summary>
    /// A type of extension consisting of a list of name value pairs.
    /// <see href="https://spdx.org/rdf/3.1/terms/Extension/CdxPropertiesExtension"></see></summary>
    let ``Extension/CdxPropertiesExtension`` =
        Namespaced_IRI.parse _namespace_name "Extension/CdxPropertiesExtension" |> NamespacedName

    /// <summary>
    /// Provides a map of a property name to a value.
    /// <see href="https://spdx.org/rdf/3.1/terms/Extension/cdxProperty"></see></summary>
    let ``Extension/cdxProperty`` =
        Namespaced_IRI.parse _namespace_name "Extension/cdxProperty" |> NamespacedName

    /// <summary>
    /// A name used in a CdxPropertyEntry name-value pair.
    /// <see href="https://spdx.org/rdf/3.1/terms/Extension/cdxPropName"></see></summary>
    let ``Extension/cdxPropName`` =
        Namespaced_IRI.parse _namespace_name "Extension/cdxPropName" |> NamespacedName

    /// <summary>
    /// A value used in a CdxPropertyEntry name-value pair.
    /// <see href="https://spdx.org/rdf/3.1/terms/Extension/cdxPropValue"></see></summary>
    let ``Extension/cdxPropValue`` =
        Namespaced_IRI.parse _namespace_name "Extension/cdxPropValue" |> NamespacedName

    /// <summary>
    /// Indicates the specific RequirementVerification instance on which the EvaluationResult is based.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluationBasedOn"></see></summary>
    let ``FunctionalSafety/evaluationBasedOn`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/evaluationBasedOn" |> NamespacedName

    /// <summary>
    /// EvaluationResultType describes the outcome of an evaluation or verification process with.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType"></see></summary>
    let ``FunctionalSafety/EvaluationResultType`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/EvaluationResultType" |> NamespacedName

    /// <summary>
    /// Indicates a successful evaluation where the requirement or condition is clearly met.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/pass"></see></summary>
    let ``FunctionalSafety/EvaluationResultType/pass`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/EvaluationResultType/pass" |> NamespacedName

    /// <summary>
    /// Indicates a failed evaluation where the requirement or condition is not met.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/fail"></see></summary>
    let ``FunctionalSafety/EvaluationResultType/fail`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/EvaluationResultType/fail" |> NamespacedName

    /// <summary>
    /// Inconclusive refers to a result or outcome from a verification, test, or analysis that cannot be clearly classified as either positive (successful, pass) or negative (failed, reject). An inconclusive result means there was not enough clear evidence, data, or signal to make a definitive determination, and further investigation or additional testing is necessary. An inconclusive result always shall need a comment on it.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/inconclusive"></see></summary>
    let ``FunctionalSafety/EvaluationResultType/inconclusive`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/EvaluationResultType/inconclusive" |> NamespacedName

    /// <summary>
    /// Evaluation is an outcome considering results of a verification.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluation"></see></summary>
    let ``FunctionalSafety/evaluation`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/evaluation" |> NamespacedName

    /// <summary>
    /// Detailed explanation or reasoning that supports the EvaluationResult.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluationRationale"></see></summary>
    let ``FunctionalSafety/evaluationRationale`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/evaluationRationale" |> NamespacedName

    /// <summary>
    /// EvidenceType refers to categories of documented or observable proof used to verify compliance, qualification, or performance
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType"></see></summary>
    let ``FunctionalSafety/EvidenceType`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/EvidenceType" |> NamespacedName

    /// <summary>
    /// Structured documentation of test results, inspections, or analyses.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/report"></see></summary>
    let ``FunctionalSafety/EvidenceType/report`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/EvidenceType/report" |> NamespacedName

    /// <summary>
    /// Time-stamped records capturing system or operational data recorded as usually as a response to specific triggers in a specified environment.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/log"></see></summary>
    let ``FunctionalSafety/EvidenceType/log`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/EvidenceType/log" |> NamespacedName

    /// <summary>
    /// Captured datastream like audio, video, or any other kind of continuous electronic capture of events, behavior or conditions.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/recording"></see></summary>
    let ``FunctionalSafety/EvidenceType/recording`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/EvidenceType/recording" |> NamespacedName

    /// <summary>
    /// Documentation of direct monitoring or witnessing of the demonstration of processes, tests, or any kind of system responses during a specified timeframe under specified environmental conditions.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/observation"></see></summary>
    let ``FunctionalSafety/EvidenceType/observation`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/EvidenceType/observation" |> NamespacedName

    /// <summary>
    /// Any other relevant type of proof or documentation not covered above.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/other"></see></summary>
    let ``FunctionalSafety/EvidenceType/other`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/EvidenceType/other" |> NamespacedName

    /// <summary>
    /// evidenceCategory refers to a category of documented or observable proof.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evidenceCategory"></see></summary>
    let ``FunctionalSafety/evidenceCategory`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/evidenceCategory" |> NamespacedName

    /// <summary>
    /// A evidenceUUID is a universally unique identifier (UUID) assigned to an entity, item, or requirement.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evidenceUUID"></see></summary>
    let ``FunctionalSafety/evidenceUUID`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/evidenceUUID" |> NamespacedName

    /// <summary>
    /// A verificationRationale is supporting information that justifies the verification details.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationRationale"></see></summary>
    let ``FunctionalSafety/verificationRationale`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/verificationRationale" |> NamespacedName

    /// <summary>
    /// Verification preconditions are initial criteria that are to be met prior to initiating the verification method.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationPrecondition"></see></summary>
    let ``FunctionalSafety/verificationPrecondition`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/verificationPrecondition" |> NamespacedName

    /// <summary>
    /// A verificationUUID is a universally unique identifier (UUID) assigned to a Verification item.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationUUID"></see></summary>
    let ``FunctionalSafety/verificationUUID`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/verificationUUID" |> NamespacedName

    /// <summary>
    /// Enumeration of verification types.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType"></see></summary>
    let ``FunctionalSafety/VerificationType`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/VerificationType" |> NamespacedName

    /// <summary>
    /// Analytical evaluating of data, designs, or processes methodically to verify correctness against standards or expectations. Typical analysis methods are FMEA, FTA, STPA, static analysis for MISRA compliance etc.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/analysis"></see></summary>
    let ``FunctionalSafety/VerificationType/analysis`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/VerificationType/analysis" |> NamespacedName

    /// <summary>
    /// A systematic examination of a system, process, or outcome to evaluate compliance of specific work products with a specific expectation with a specification, regulation or standard. Often involves judgement and a rationale of this judgement.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/assessment"></see></summary>
    let ``FunctionalSafety/VerificationType/assessment`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/VerificationType/assessment" |> NamespacedName

    /// <summary>
    /// An examination typically focusing on compliance with policies, standards, or regulations. Usually this is done during an audit meeting, while the assessment also involves deep and detailed reviews of work products (e.g. requirements, verification specifications, reports etc.)
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/audit"></see></summary>
    let ``FunctionalSafety/VerificationType/audit`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/VerificationType/audit" |> NamespacedName

    /// <summary>
    /// Demonstrating and monitoring or recording that the item under verification to confirm that a requirement is met by the item under verification.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/demonstration"></see></summary>
    let ``FunctionalSafety/VerificationType/demonstration`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/VerificationType/demonstration" |> NamespacedName

    /// <summary>
    /// A thorough examination or checking of documentation, records, processes, or systems to confirm compliance or adherence. An inspection needs to have a defined set of acceptance criteria (e.g. a checklist), a documentation of roles involved in the inspection (e.g. to document the inspector's independence) and a clear documentation of when and how it was performed.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/inspection"></see></summary>
    let ``FunctionalSafety/VerificationType/inspection`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/VerificationType/inspection" |> NamespacedName

    /// <summary>
    /// Any other specialized or custom verification method that fits the context.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/other"></see></summary>
    let ``FunctionalSafety/VerificationType/other`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/VerificationType/other" |> NamespacedName

    /// <summary>
    /// A examination or checking of documentation, records, processes, or systems to confirm compliance or adherence with an upper level requirement. Typically done as peer review, offline review or review meeting.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/review"></see></summary>
    let ``FunctionalSafety/VerificationType/review`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/VerificationType/review" |> NamespacedName

    /// <summary>
    /// Conducting controlled tests, experiments or simulations to verify that specific requirements regarding performance, functionality, robustness, etc. are met.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/test"></see></summary>
    let ``FunctionalSafety/VerificationType/test`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/VerificationType/test" |> NamespacedName

    /// <summary>
    /// verificationMethod refers to the specific approach used for a checking an element's conformance with its requirements.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationMethod"></see></summary>
    let ``FunctionalSafety/verificationMethod`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/verificationMethod" |> NamespacedName

    /// <summary>
    /// Verification postcondition that are true immediately after a verification method has been performed
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationPostcondition"></see></summary>
    let ``FunctionalSafety/verificationPostcondition`` =
        Namespaced_IRI.parse _namespace_name "FunctionalSafety/verificationPostcondition" |> NamespacedName

    /// <summary>
    /// Class that describes an instance of Hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/Hardware"></see></summary>
    let ``Hardware/Hardware`` =
        Namespaced_IRI.parse _namespace_name "Hardware/Hardware" |> NamespacedName

    /// <summary>
    /// The amount or measure of a bulk product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/bulkQuantity"></see></summary>
    let ``Hardware/bulkQuantity`` =
        Namespaced_IRI.parse _namespace_name "Hardware/bulkQuantity" |> NamespacedName

    /// <summary>
    /// Information related to hardware dimension.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/yAxisLength"></see></summary>
    let ``Hardware/yAxisLength`` =
        Namespaced_IRI.parse _namespace_name "Hardware/yAxisLength" |> NamespacedName

    /// <summary>
    /// Information related to hardware dimension.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/zAxisLength"></see></summary>
    let ``Hardware/zAxisLength`` =
        Namespaced_IRI.parse _namespace_name "Hardware/zAxisLength" |> NamespacedName

    /// <summary>
    /// Information related to hardware dimension.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/xAxisLength"></see></summary>
    let ``Hardware/xAxisLength`` =
        Namespaced_IRI.parse _namespace_name "Hardware/xAxisLength" |> NamespacedName

    /// <summary>
    /// Hazards are potential sources of harm, danger, or adverse effects to people, property, the environment, or systems within or related to a specific piece of hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/hazard"></see></summary>
    let ``Hardware/hazard`` =
        Namespaced_IRI.parse _namespace_name "Hardware/hazard" |> NamespacedName

    /// <summary>
    /// Additional relevance information.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/additionalInformation"></see></summary>
    let ``Hardware/additionalInformation`` =
        Namespaced_IRI.parse _namespace_name "Hardware/additionalInformation" |> NamespacedName

    /// <summary>
    /// Identifier for specific product is called a serial number.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/serialNumber"></see></summary>
    let ``Hardware/serialNumber`` =
        Namespaced_IRI.parse _namespace_name "Hardware/serialNumber" |> NamespacedName

    /// <summary>
    /// Product Part Number as defined by OEM.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/partNumber"></see></summary>
    let ``Hardware/partNumber`` =
        Namespaced_IRI.parse _namespace_name "Hardware/partNumber" |> NamespacedName

    /// <summary>
    /// Date of product release.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/releaseDate"></see></summary>
    let ``Hardware/releaseDate`` =
        Namespaced_IRI.parse _namespace_name "Hardware/releaseDate" |> NamespacedName

    /// <summary>
    /// The Agent who is responsible for product branding such as an OEM.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/productAgent"></see></summary>
    let ``Hardware/productAgent`` =
        Namespaced_IRI.parse _namespace_name "Hardware/productAgent" |> NamespacedName

    /// <summary>
    /// The category describes the hardware item in a DefinedType.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/category"></see></summary>
    let ``Hardware/category`` =
        Namespaced_IRI.parse _namespace_name "Hardware/category" |> NamespacedName

    /// <summary>
    /// It is the authoritative or credible entity, document, or body of knowledge that provides the meaning of an additionalInformation key and/or its values, ensuring accuracy, context, and standardization.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/additionalInformationSpecification"></see></summary>
    let ``Hardware/additionalInformationSpecification`` =
        Namespaced_IRI.parse _namespace_name "Hardware/additionalInformationSpecification" |> NamespacedName

    /// <summary>
    /// Version identifier for the hardware product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/hardwareVersion"></see></summary>
    let ``Hardware/hardwareVersion`` =
        Namespaced_IRI.parse _namespace_name "Hardware/hardwareVersion" |> NamespacedName

    /// <summary>
    /// Identifier for product production batch.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/batchNumber"></see></summary>
    let ``Hardware/batchNumber`` =
        Namespaced_IRI.parse _namespace_name "Hardware/batchNumber" |> NamespacedName

    /// <summary>
    /// Information related to hardware dimension.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/dimensions"></see></summary>
    let ``Hardware/dimensions`` =
        Namespaced_IRI.parse _namespace_name "Hardware/dimensions" |> NamespacedName

    /// <summary>
    /// A point representing the mean position of the matter in a body or system.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/centerOfMass"></see></summary>
    let ``Hardware/centerOfMass`` =
        Namespaced_IRI.parse _namespace_name "Hardware/centerOfMass" |> NamespacedName

    /// <summary>
    /// Information related to massOfHardware physical hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/massOfHardware"></see></summary>
    let ``Hardware/massOfHardware`` =
        Namespaced_IRI.parse _namespace_name "Hardware/massOfHardware" |> NamespacedName

    /// <summary>
    /// Version identifier for the item.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/itemVersion"></see></summary>
    let ``Hardware/itemVersion`` =
        Namespaced_IRI.parse _namespace_name "Hardware/itemVersion" |> NamespacedName

    /// <summary>
    /// VirtualHardwareModelType sets the VirtualHardware Model Type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType"></see></summary>
    let ``Hardware/VirtualHardwareModelType`` =
        Namespaced_IRI.parse _namespace_name "Hardware/VirtualHardwareModelType" |> NamespacedName

    /// <summary>
    /// Simulation the function of the hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/function"></see></summary>
    let ``Hardware/VirtualHardwareModelType/function`` =
        Namespaced_IRI.parse _namespace_name "Hardware/VirtualHardwareModelType/function" |> NamespacedName

    /// <summary>
    /// Simulation architectures with precise cycle-level accuracy.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/cycle"></see></summary>
    let ``Hardware/VirtualHardwareModelType/cycle`` =
        Namespaced_IRI.parse _namespace_name "Hardware/VirtualHardwareModelType/cycle" |> NamespacedName

    /// <summary>
    /// All other simulation types.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/other"></see></summary>
    let ``Hardware/VirtualHardwareModelType/other`` =
        Namespaced_IRI.parse _namespace_name "Hardware/VirtualHardwareModelType/other" |> NamespacedName

    /// <summary>
    /// Information related to virtual hardware simulation.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/virtualHardwareModel"></see></summary>
    let ``Hardware/virtualHardwareModel`` =
        Namespaced_IRI.parse _namespace_name "Hardware/virtualHardwareModel" |> NamespacedName

    /// <summary>
    /// Information related to physical hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/mass"></see></summary>
    let ``Hardware/mass`` =
        Namespaced_IRI.parse _namespace_name "Hardware/mass" |> NamespacedName

    /// <summary>
    /// Specification basis for the export control classification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/exportControlSpecification"></see></summary>
    let ``Operations/exportControlSpecification`` =
        Namespaced_IRI.parse _namespace_name "Operations/exportControlSpecification" |> NamespacedName

    /// <summary>
    /// Weight to express relevance in de minimis consideration.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/weight"></see></summary>
    let ``Operations/weight`` =
        Namespaced_IRI.parse _namespace_name "Operations/weight" |> NamespacedName

    /// <summary>
    /// Expression for the export control classification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/exportClassification"></see></summary>
    let ``Operations/exportClassification`` =
        Namespaced_IRI.parse _namespace_name "Operations/exportClassification" |> NamespacedName

    /// <summary>
    /// Country for which export controls must be taken into account.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/exportingCountry"></see></summary>
    let ``Operations/exportingCountry`` =
        Namespaced_IRI.parse _namespace_name "Operations/exportingCountry" |> NamespacedName

    /// <summary>
    /// Timestamp, when an assessment was conducted.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/assessmentTimestamp"></see></summary>
    let ``Operations/assessmentTimestamp`` =
        Namespaced_IRI.parse _namespace_name "Operations/assessmentTimestamp" |> NamespacedName

    /// <summary>
    /// Specifies an Element as subject of an assessment.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/assessmentResult"></see></summary>
    let ``Operations/assessmentResult`` =
        Namespaced_IRI.parse _namespace_name "Operations/assessmentResult" |> NamespacedName

    /// <summary>
    /// An entity providing an assessment.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/assessor"></see></summary>
    let ``Operations/assessor`` =
        Namespaced_IRI.parse _namespace_name "Operations/assessor" |> NamespacedName

    /// <summary>
    /// Specifies an Element as subject of an assessment.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/assessedElement"></see></summary>
    let ``Operations/assessedElement`` =
        Namespaced_IRI.parse _namespace_name "Operations/assessedElement" |> NamespacedName

    /// <summary>
    /// Sets the context for an assessment iby specifying the related project.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/assessmentContext"></see></summary>
    let ``Operations/assessmentContext`` =
        Namespaced_IRI.parse _namespace_name "Operations/assessmentContext" |> NamespacedName

    /// <summary>
    /// Time when the project starts or is planned to start.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/projectStartTime"></see></summary>
    let ``Operations/projectStartTime`` =
        Namespaced_IRI.parse _namespace_name "Operations/projectStartTime" |> NamespacedName

    /// <summary>
    /// Time when the project ends or is planned to end.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/projectEndTime"></see></summary>
    let ``Operations/projectEndTime`` =
        Namespaced_IRI.parse _namespace_name "Operations/projectEndTime" |> NamespacedName

    /// <summary>
    /// Owner or Lead of the project.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/projectOwner"></see></summary>
    let ``Operations/projectOwner`` =
        Namespaced_IRI.parse _namespace_name "Operations/projectOwner" |> NamespacedName

    /// <summary>
    /// Sponsor of the project.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/projectSponsor"></see></summary>
    let ``Operations/projectSponsor`` =
        Namespaced_IRI.parse _namespace_name "Operations/projectSponsor" |> NamespacedName

    /// <summary>
    /// Link to the project contract.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/projectContract"></see></summary>
    let ``Operations/projectContract`` =
        Namespaced_IRI.parse _namespace_name "Operations/projectContract" |> NamespacedName

    /// <summary>
    /// Title of the project.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/projectTitle"></see></summary>
    let ``Operations/projectTitle`` =
        Namespaced_IRI.parse _namespace_name "Operations/projectTitle" |> NamespacedName

    /// <summary>
    /// Provides the result of an export control assessment.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/exportControlClassificationResult"></see></summary>
    let ``Operations/exportControlClassificationResult`` =
        Namespaced_IRI.parse _namespace_name "Operations/exportControlClassificationResult" |> NamespacedName

    /// <summary>
    /// Specifies the CVSS base, temporal, threat, or environmental severity type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType"></see></summary>
    let ``Security/CvssSeverityType`` =
        Namespaced_IRI.parse _namespace_name "Security/CvssSeverityType" |> NamespacedName

    /// <summary>
    /// When a CVSS score is between 9.0 - 10.0.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/critical"></see></summary>
    let ``Security/CvssSeverityType/critical`` =
        Namespaced_IRI.parse _namespace_name "Security/CvssSeverityType/critical" |> NamespacedName

    /// <summary>
    /// When a CVSS score is between 7.0 - 8.9.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/high"></see></summary>
    let ``Security/CvssSeverityType/high`` =
        Namespaced_IRI.parse _namespace_name "Security/CvssSeverityType/high" |> NamespacedName

    /// <summary>
    /// When a CVSS score is between 0.1 - 3.9.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/low"></see></summary>
    let ``Security/CvssSeverityType/low`` =
        Namespaced_IRI.parse _namespace_name "Security/CvssSeverityType/low" |> NamespacedName

    /// <summary>
    /// When a CVSS score is between 4.0 - 6.9.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/medium"></see></summary>
    let ``Security/CvssSeverityType/medium`` =
        Namespaced_IRI.parse _namespace_name "Security/CvssSeverityType/medium" |> NamespacedName

    /// <summary>
    /// When a CVSS score is 0.0.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/none"></see></summary>
    let ``Security/CvssSeverityType/none`` =
        Namespaced_IRI.parse _namespace_name "Security/CvssSeverityType/none" |> NamespacedName

    /// <summary>
    /// Abstract ancestor class for all vulnerability assessments.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VulnAssessmentRelationship"></see></summary>
    let ``Security/VulnAssessmentRelationship`` =
        Namespaced_IRI.parse _namespace_name "Security/VulnAssessmentRelationship" |> NamespacedName

    /// <summary>
    /// Specifies the CVSS vector string for a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/vectorString"></see></summary>
    let ``Security/vectorString`` =
        Namespaced_IRI.parse _namespace_name "Security/vectorString" |> NamespacedName

    /// <summary>
    /// Provides a numerical (0-10) representation of the severity of a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/score"></see></summary>
    let ``Security/score`` =
        Namespaced_IRI.parse _namespace_name "Security/score" |> NamespacedName

    /// <summary>
    /// Specifies the CVSS qualitative severity rating of a vulnerability in relation to a piece of software.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/severity"></see></summary>
    let ``Security/severity`` =
        Namespaced_IRI.parse _namespace_name "Security/severity" |> NamespacedName

    /// <summary>
    /// The percentile of the current probability score.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/percentile"></see></summary>
    let ``Security/percentile`` =
        Namespaced_IRI.parse _namespace_name "Security/percentile" |> NamespacedName

    /// <summary>
    /// A probability score between 0 and 1 of a vulnerability being exploited.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/probability"></see></summary>
    let ``Security/probability`` =
        Namespaced_IRI.parse _namespace_name "Security/probability" |> NamespacedName

    /// <summary>
    /// Specifies the exploit catalog type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType"></see></summary>
    let ``Security/ExploitCatalogType`` =
        Namespaced_IRI.parse _namespace_name "Security/ExploitCatalogType" |> NamespacedName

    /// <summary>
    /// CISA's Known Exploited Vulnerability (KEV) catalog.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType/kev"></see></summary>
    let ``Security/ExploitCatalogType/kev`` =
        Namespaced_IRI.parse _namespace_name "Security/ExploitCatalogType/kev" |> NamespacedName

    /// <summary>
    /// Other exploit catalogs.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType/other"></see></summary>
    let ``Security/ExploitCatalogType/other`` =
        Namespaced_IRI.parse _namespace_name "Security/ExploitCatalogType/other" |> NamespacedName

    /// <summary>
    /// Specifies the exploit catalog type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/catalogType"></see></summary>
    let ``Security/catalogType`` =
        Namespaced_IRI.parse _namespace_name "Security/catalogType" |> NamespacedName

    /// <summary>
    /// Provides the location of an exploit catalog.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/locator"></see></summary>
    let ``Security/locator`` =
        Namespaced_IRI.parse _namespace_name "Security/locator" |> NamespacedName

    /// <summary>
    /// Denote whether a CVE is present in an exploit catalog.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/exploited"></see></summary>
    let ``Security/exploited`` =
        Namespaced_IRI.parse _namespace_name "Security/exploited" |> NamespacedName

    /// <summary>
    /// Specifies the SSVC decision type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType"></see></summary>
    let ``Security/SsvcDecisionType`` =
        Namespaced_IRI.parse _namespace_name "Security/SsvcDecisionType" |> NamespacedName

    /// <summary>
    /// The vulnerability requires attention from the organization's internal, supervisory-level and leadership-level individuals. Necessary actions include requesting assistance or information about the vulnerability, as well as publishing a notification either internally and/or externally. Typically, internal groups would meet to determine the overall response and then execute agreed upon actions. CISA recommends remediating Act vulnerabilities as soon as possible.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/act"></see></summary>
    let ``Security/SsvcDecisionType/act`` =
        Namespaced_IRI.parse _namespace_name "Security/SsvcDecisionType/act" |> NamespacedName

    /// <summary>
    /// The vulnerability requires attention from the organization's internal, supervisory-level individuals. Necessary actions include requesting assistance or information about the vulnerability, and may involve publishing a notification either internally and/or externally. CISA recommends remediating Attend vulnerabilities sooner than standard update timelines.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/attend"></see></summary>
    let ``Security/SsvcDecisionType/attend`` =
        Namespaced_IRI.parse _namespace_name "Security/SsvcDecisionType/attend" |> NamespacedName

    /// <summary>
    /// The vulnerability does not require action at this time. The organization would continue to track the vulnerability and reassess it if new information becomes available. CISA recommends remediating Track vulnerabilities within standard update timelines.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/track"></see></summary>
    let ``Security/SsvcDecisionType/track`` =
        Namespaced_IRI.parse _namespace_name "Security/SsvcDecisionType/track" |> NamespacedName

    /// <summary>
    /// ("Track\*" in the SSVC spec) The vulnerability contains specific characteristics that may require closer monitoring for changes. CISA recommends remediating Track\* vulnerabilities within standard update timelines.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/trackStar"></see></summary>
    let ``Security/SsvcDecisionType/trackStar`` =
        Namespaced_IRI.parse _namespace_name "Security/SsvcDecisionType/trackStar" |> NamespacedName

    /// <summary>
    /// Provide the enumeration of possible decisions in the
    /// [Stakeholder-Specific Vulnerability Categorization (SSVC) decision tree](https://www.cisa.gov/stakeholder-specific-vulnerability-categorization-ssvc).
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/decisionType"></see></summary>
    let ``Security/decisionType`` =
        Namespaced_IRI.parse _namespace_name "Security/decisionType" |> NamespacedName

    /// <summary>
    /// Abstract ancestor class for all VEX relationships.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexVulnAssessmentRelationship"></see></summary>
    let ``Security/VexVulnAssessmentRelationship`` =
        Namespaced_IRI.parse _namespace_name "Security/VexVulnAssessmentRelationship" |> NamespacedName

    /// <summary>
    /// Provides advise on how to mitigate or remediate a vulnerability when a VEX product
    /// is affected by it.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/actionStatement"></see></summary>
    let ``Security/actionStatement`` =
        Namespaced_IRI.parse _namespace_name "Security/actionStatement" |> NamespacedName

    /// <summary>
    /// Records the time when a recommended action was communicated in a VEX statement
    /// to mitigate a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/actionStatementTime"></see></summary>
    let ``Security/actionStatementTime`` =
        Namespaced_IRI.parse _namespace_name "Security/actionStatementTime" |> NamespacedName

    /// <summary>
    /// Specifies the VEX justification type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType"></see></summary>
    let ``Security/VexJustificationType`` =
        Namespaced_IRI.parse _namespace_name "Security/VexJustificationType" |> NamespacedName

    /// <summary>
    /// The software is not affected because the vulnerable component is not in the product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/componentNotPresent"></see></summary>
    let ``Security/VexJustificationType/componentNotPresent`` =
        Namespaced_IRI.parse _namespace_name "Security/VexJustificationType/componentNotPresent" |> NamespacedName

    /// <summary>
    /// Built-in inline controls or mitigations prevent an adversary from leveraging the vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/inlineMitigationsAlreadyExist"></see></summary>
    let ``Security/VexJustificationType/inlineMitigationsAlreadyExist`` =
        Namespaced_IRI.parse _namespace_name "Security/VexJustificationType/inlineMitigationsAlreadyExist" |> NamespacedName

    /// <summary>
    /// The vulnerable component is present, and the component contains the vulnerable code. However, vulnerable code is used in such a way that an attacker cannot mount any anticipated attack.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary"></see></summary>
    let ``Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary`` =
        Namespaced_IRI.parse _namespace_name "Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary" |> NamespacedName

    /// <summary>
    /// The affected code is not reachable through the execution of the code, including non-anticipated states of the product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeNotInExecutePath"></see></summary>
    let ``Security/VexJustificationType/vulnerableCodeNotInExecutePath`` =
        Namespaced_IRI.parse _namespace_name "Security/VexJustificationType/vulnerableCodeNotInExecutePath" |> NamespacedName

    /// <summary>
    /// The product is not affected because the code underlying the vulnerability is not present in the product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeNotPresent"></see></summary>
    let ``Security/VexJustificationType/vulnerableCodeNotPresent`` =
        Namespaced_IRI.parse _namespace_name "Security/VexJustificationType/vulnerableCodeNotPresent" |> NamespacedName

    /// <summary>
    /// Explains why a VEX product is not affected by a vulnerability. It is an
    /// alternative in VexNotAffectedVulnAssessmentRelationship to the machine-readable
    /// justification label.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/impactStatement"></see></summary>
    let ``Security/impactStatement`` =
        Namespaced_IRI.parse _namespace_name "Security/impactStatement" |> NamespacedName

    /// <summary>
    /// Impact justification label to be used when linking a vulnerability to an element
    /// representing a VEX product with a VexNotAffectedVulnAssessmentRelationship
    /// relationship.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/justificationType"></see></summary>
    let ``Security/justificationType`` =
        Namespaced_IRI.parse _namespace_name "Security/justificationType" |> NamespacedName

    /// <summary>
    /// Timestamp of impact statement.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/impactStatementTime"></see></summary>
    let ``Security/impactStatementTime`` =
        Namespaced_IRI.parse _namespace_name "Security/impactStatementTime" |> NamespacedName

    /// <summary>
    /// Conveys information about how VEX status was determined.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/statusNotes"></see></summary>
    let ``Security/statusNotes`` =
        Namespaced_IRI.parse _namespace_name "Security/statusNotes" |> NamespacedName

    /// <summary>
    /// Specifies the version of a VEX statement.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/vexVersion"></see></summary>
    let ``Security/vexVersion`` =
        Namespaced_IRI.parse _namespace_name "Security/vexVersion" |> NamespacedName

    /// <summary>
    /// Specifies a time when a vulnerability assessment was modified
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/modifiedTime"></see></summary>
    let ``Security/modifiedTime`` =
        Namespaced_IRI.parse _namespace_name "Security/modifiedTime" |> NamespacedName

    /// <summary>
    /// Specifies the time when a vulnerability was published.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/publishedTime"></see></summary>
    let ``Security/publishedTime`` =
        Namespaced_IRI.parse _namespace_name "Security/publishedTime" |> NamespacedName

    /// <summary>
    /// Specified the time and date when a vulnerability was withdrawn.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/withdrawnTime"></see></summary>
    let ``Security/withdrawnTime`` =
        Namespaced_IRI.parse _namespace_name "Security/withdrawnTime" |> NamespacedName

    /// <summary>
    /// A distinct article or unit related to Software.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwareArtifact"></see></summary>
    let ``Software/SoftwareArtifact`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwareArtifact" |> NamespacedName

    /// <summary>
    /// Specifies an Element contained in a piece of software where a vulnerability was
    /// found.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/assessedElement"></see></summary>
    let ``Security/assessedElement`` =
        Namespaced_IRI.parse _namespace_name "Security/assessedElement" |> NamespacedName

    /// <summary>
    /// Protocols which support authentication.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType"></see></summary>
    let ``Service/AuthenticationProtocolType`` =
        Namespaced_IRI.parse _namespace_name "Service/AuthenticationProtocolType" |> NamespacedName

    /// <summary>
    /// Certificate Revocation List, or CRL, is a list of revoked certificates that is downloaded from the Certificate Authority (CA).
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/crl"></see></summary>
    let ``Service/AuthenticationProtocolType/crl`` =
        Namespaced_IRI.parse _namespace_name "Service/AuthenticationProtocolType/crl" |> NamespacedName

    /// <summary>
    /// Online Certificate Status Protocol, or OCSP, is a common scheme used to maintain the security of a server and other network resources.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/ocsp"></see></summary>
    let ``Service/AuthenticationProtocolType/ocsp`` =
        Namespaced_IRI.parse _namespace_name "Service/AuthenticationProtocolType/ocsp" |> NamespacedName

    /// <summary>
    /// An authentication protocol not covered by one of the other AuthenticationProtocolTypes.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/other"></see></summary>
    let ``Service/AuthenticationProtocolType/other`` =
        Namespaced_IRI.parse _namespace_name "Service/AuthenticationProtocolType/other" |> NamespacedName

    /// <summary>
    /// Transport Layer Security, or TLS, is a widely adopted security protocol designed to facilitate privacy and data security for communications over the Internet.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/tls"></see></summary>
    let ``Service/AuthenticationProtocolType/tls`` =
        Namespaced_IRI.parse _namespace_name "Service/AuthenticationProtocolType/tls" |> NamespacedName

    /// <summary>
    /// Authentication protocol used by a server.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/serverAuthenticationProtocol"></see></summary>
    let ``Service/serverAuthenticationProtocol`` =
        Namespaced_IRI.parse _namespace_name "Service/serverAuthenticationProtocol" |> NamespacedName

    /// <summary>
    /// The provider of a SoftwareService.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/provider"></see></summary>
    let ``Service/provider`` =
        Namespaced_IRI.parse _namespace_name "Service/provider" |> NamespacedName

    /// <summary>
    /// Specifies a country code where a software service is hosted.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/serviceHostingCountry"></see></summary>
    let ``Service/serviceHostingCountry`` =
        Namespaced_IRI.parse _namespace_name "Service/serviceHostingCountry" |> NamespacedName

    /// <summary>
    /// Maps a "LicenseRef-" string for a custom license or a "AdditionRef-" string for
    /// a custom license addition to a `CustomLicense`, a `CustomLicenseAddition`, or a
    /// `SimpleLicensingText`.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/customIdToLicense"></see></summary>
    let ``SimpleLicensing/customIdToLicense`` =
        Namespaced_IRI.parse _namespace_name "SimpleLicensing/customIdToLicense" |> NamespacedName

    /// <summary>
    /// A string in the license expression format.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseExpression"></see></summary>
    let ``SimpleLicensing/licenseExpression`` =
        Namespaced_IRI.parse _namespace_name "SimpleLicensing/licenseExpression" |> NamespacedName

    /// <summary>
    /// **DEPRECATED in SPDX 3.1.**
    /// Use [customIdToLicense](./customIdToLicense.md) instead.
    ///
    /// Maps a LicenseRef or AdditionRef string for a Custom License or a Custom
    /// License Addition to its URI ID.
    ///
    /// **NOTE:**
    /// This property is deprecated and only included for backward compatibility.
    /// New documents should use [customIdToLicense](./customIdToLicense.md) instead.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/customIdToUri"></see></summary>
    let ``SimpleLicensing/customIdToUri`` =
        Namespaced_IRI.parse _namespace_name "SimpleLicensing/customIdToUri" |> NamespacedName

    /// <summary>
    /// The version of the SPDX License List used in the license expression.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseListVersion"></see></summary>
    let ``SimpleLicensing/licenseListVersion`` =
        Namespaced_IRI.parse _namespace_name "SimpleLicensing/licenseListVersion" |> NamespacedName

    /// <summary>
    /// Specifies the type of a content identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType"></see></summary>
    let ``Software/ContentIdentifierType`` =
        Namespaced_IRI.parse _namespace_name "Software/ContentIdentifierType" |> NamespacedName

    /// <summary>
    /// [Gitoid](https://www.iana.org/assignments/uri-schemes/prov/gitoid), stands for [Git Object ID](https://git-scm.com/book/en/v2/Git-Internals-Git-Objects). A gitoid of type blob is a unique hash of a binary artifact. A gitoid may represent either an [Artifact Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-identifier-types) for the software artifact or an [Input Manifest Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#input-manifest-identifier) for the software artifact's associated [Artifact Input Manifest](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-input-manifest); this ambiguity exists because the Artifact Input Manifest is itself an artifact, and the gitoid of that artifact is its valid identifier. Gitoids calculated on software artifacts (Snippet, File, or Package Elements) should be recorded in the SPDX 3 SoftwareArtifact's contentIdentifier property. Gitoids calculated on the Artifact Input Manifest (Input Manifest Identifier) should be recorded in the SPDX 3 Element's externalIdentifier property. See [OmniBOR Specification](https://github.com/omnibor/spec/), a minimalistic specification for describing software [Artifact Dependency Graphs](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-dependency-graph-adg).
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType/gitoid"></see></summary>
    let ``Software/ContentIdentifierType/gitoid`` =
        Namespaced_IRI.parse _namespace_name "Software/ContentIdentifierType/gitoid" |> NamespacedName

    /// <summary>
    /// SoftWare Hash IDentifier, a persistent intrinsic identifier for digital artifacts, such as files, trees (also known as directories or folders), commits, and other objects typically found in version control systems. The format of the identifiers is defined in the [SWHID specification](https://www.swhid.org/swhid-specification/v1.2/) ([ISO/IEC 18670](https://www.iso.org/standard/89985.html)). They typically look like `swh:1:cnt:94a9ed024d3859793618152ea559a168bbcbb5e2`.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType/swhid"></see></summary>
    let ``Software/ContentIdentifierType/swhid`` =
        Namespaced_IRI.parse _namespace_name "Software/ContentIdentifierType/swhid" |> NamespacedName

    /// <summary>
    /// Specifies the type of the content identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/contentIdentifierType"></see></summary>
    let ``Software/contentIdentifierType`` =
        Namespaced_IRI.parse _namespace_name "Software/contentIdentifierType" |> NamespacedName

    /// <summary>
    /// Specifies the value of the content identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/contentIdentifierValue"></see></summary>
    let ``Software/contentIdentifierValue`` =
        Namespaced_IRI.parse _namespace_name "Software/contentIdentifierValue" |> NamespacedName

    /// <summary>
    /// Enumeration of the different kinds of SPDX file.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/FileKindType"></see></summary>
    let ``Software/FileKindType`` =
        Namespaced_IRI.parse _namespace_name "Software/FileKindType" |> NamespacedName

    /// <summary>
    /// The file represents a single file (default).
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/FileKindType/file"></see></summary>
    let ``Software/FileKindType/file`` =
        Namespaced_IRI.parse _namespace_name "Software/FileKindType/file" |> NamespacedName

    /// <summary>
    /// The file represents a directory and all content stored in that directory.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/FileKindType/directory"></see></summary>
    let ``Software/FileKindType/directory`` =
        Namespaced_IRI.parse _namespace_name "Software/FileKindType/directory" |> NamespacedName

    /// <summary>
    /// Describes if a given file is a directory or non-directory kind of file.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/fileKind"></see></summary>
    let ``Software/fileKind`` =
        Namespaced_IRI.parse _namespace_name "Software/fileKind" |> NamespacedName

    /// <summary>
    /// Provides a place for the SPDX data creator to record the package URL string
    /// (in accordance with the Package URL specification) for a software Package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/packageUrl"></see></summary>
    let ``Software/packageUrl`` =
        Namespaced_IRI.parse _namespace_name "Software/packageUrl" |> NamespacedName

    /// <summary>
    /// Records any relevant background information or additional comments
    /// about the origin of the package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/sourceInfo"></see></summary>
    let ``Software/sourceInfo`` =
        Namespaced_IRI.parse _namespace_name "Software/sourceInfo" |> NamespacedName

    /// <summary>
    /// Identify the version of a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/packageVersion"></see></summary>
    let ``Software/packageVersion`` =
        Namespaced_IRI.parse _namespace_name "Software/packageVersion" |> NamespacedName

    /// <summary>
    /// A place for the SPDX document creator to record a website that serves as the
    /// package's home page.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/homePage"></see></summary>
    let ``Software/homePage`` =
        Namespaced_IRI.parse _namespace_name "Software/homePage" |> NamespacedName

    /// <summary>
    /// Identifies the download Uniform Resource Identifier for the package at the time
    /// that the document was created.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/downloadLocation"></see></summary>
    let ``Software/downloadLocation`` =
        Namespaced_IRI.parse _namespace_name "Software/downloadLocation" |> NamespacedName

    /// <summary>
    /// Provides a set of values to be used to describe the common types of SBOMs that
    /// tools may create.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType"></see></summary>
    let ``Software/SbomType`` =
        Namespaced_IRI.parse _namespace_name "Software/SbomType" |> NamespacedName

    /// <summary>
    /// SBOM of intended, planned software project or product with included components (some of which may not yet exist) for a new software artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType/design"></see></summary>
    let ``Software/SbomType/design`` =
        Namespaced_IRI.parse _namespace_name "Software/SbomType/design" |> NamespacedName

    /// <summary>
    /// SBOM created directly from the development environment, source files, and included dependencies used to build a product artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType/source"></see></summary>
    let ``Software/SbomType/source`` =
        Namespaced_IRI.parse _namespace_name "Software/SbomType/source" |> NamespacedName

    /// <summary>
    /// SBOM generated as part of the process of building the software to create a releasable artifact (e.g., executable or package) from data such as source files, dependencies, built components, build process ephemeral data, and other SBOMs.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType/build"></see></summary>
    let ``Software/SbomType/build`` =
        Namespaced_IRI.parse _namespace_name "Software/SbomType/build" |> NamespacedName

    /// <summary>
    /// SBOM provides an inventory of software that is present on a system. This may be an assembly of other SBOMs that combines analysis of configuration options, and examination of execution behavior in a (potentially simulated) deployment environment.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType/deployed"></see></summary>
    let ``Software/SbomType/deployed`` =
        Namespaced_IRI.parse _namespace_name "Software/SbomType/deployed" |> NamespacedName

    /// <summary>
    /// SBOM generated through instrumenting the system running the software, to capture only components present in the system, as well as external call-outs or dynamically loaded components. In some contexts, this may also be referred to as an "Instrumented" or "Dynamic" SBOM.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType/runtime"></see></summary>
    let ``Software/SbomType/runtime`` =
        Namespaced_IRI.parse _namespace_name "Software/SbomType/runtime" |> NamespacedName

    /// <summary>
    /// SBOM generated through analysis of artifacts (e.g., executables, packages, containers, and virtual machine images) after its build. Such analysis generally requires a variety of heuristics. In some contexts, this may also be referred to as a "3rd party" SBOM.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType/analyzed"></see></summary>
    let ``Software/SbomType/analyzed`` =
        Namespaced_IRI.parse _namespace_name "Software/SbomType/analyzed" |> NamespacedName

    /// <summary>
    /// Provides information about the type of an SBOM.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/sbomType"></see></summary>
    let ``Software/sbomType`` =
        Namespaced_IRI.parse _namespace_name "Software/sbomType" |> NamespacedName

    /// <summary>
    /// Defines the original host file that the snippet information applies to.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/snippetFromFile"></see></summary>
    let ``Software/snippetFromFile`` =
        Namespaced_IRI.parse _namespace_name "Software/snippetFromFile" |> NamespacedName

    /// <summary>
    /// Defines the line range in the original host file that the snippet information
    /// applies to.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/lineRange"></see></summary>
    let ``Software/lineRange`` =
        Namespaced_IRI.parse _namespace_name "Software/lineRange" |> NamespacedName

    /// <summary>
    /// Defines the byte range in the original host file that the snippet information
    /// applies to.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/byteRange"></see></summary>
    let ``Software/byteRange`` =
        Namespaced_IRI.parse _namespace_name "Software/byteRange" |> NamespacedName

    /// <summary>
    /// Provides information about the primary purpose of an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose"></see></summary>
    let ``Software/SoftwarePurpose`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose" |> NamespacedName

    /// <summary>
    /// The Element is a software application.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/application"></see></summary>
    let ``Software/SoftwarePurpose/application`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/application" |> NamespacedName

    /// <summary>
    /// The Element is an archived collection of one or more files (.tar, .zip, etc.).
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/archive"></see></summary>
    let ``Software/SoftwarePurpose/archive`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/archive" |> NamespacedName

    /// <summary>
    /// The Element is a bill of materials.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/bom"></see></summary>
    let ``Software/SoftwarePurpose/bom`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/bom" |> NamespacedName

    /// <summary>
    /// The Element is configuration data.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/configuration"></see></summary>
    let ``Software/SoftwarePurpose/configuration`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/configuration" |> NamespacedName

    /// <summary>
    /// The Element is a container image which can be used by a container runtime application.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/container"></see></summary>
    let ``Software/SoftwarePurpose/container`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/container" |> NamespacedName

    /// <summary>
    /// The Element is data.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/data"></see></summary>
    let ``Software/SoftwarePurpose/data`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/data" |> NamespacedName

    /// <summary>
    /// The Element refers to a chipset, processor, or electronic board.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/device"></see></summary>
    let ``Software/SoftwarePurpose/device`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/device" |> NamespacedName

    /// <summary>
    /// The Element refers to a disk image that can be written to a disk, booted in a VM, etc. A disk image typically contains most or all of the components necessary to boot, such as bootloaders, kernels, firmware, userspace, etc.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/diskImage"></see></summary>
    let ``Software/SoftwarePurpose/diskImage`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/diskImage" |> NamespacedName

    /// <summary>
    /// The Element represents software that controls hardware devices.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/deviceDriver"></see></summary>
    let ``Software/SoftwarePurpose/deviceDriver`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/deviceDriver" |> NamespacedName

    /// <summary>
    /// The Element is documentation.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/documentation"></see></summary>
    let ``Software/SoftwarePurpose/documentation`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/documentation" |> NamespacedName

    /// <summary>
    /// The Element is the evidence that a specification or requirement has been fulfilled.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/evidence"></see></summary>
    let ``Software/SoftwarePurpose/evidence`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/evidence" |> NamespacedName

    /// <summary>
    /// The Element is an Artifact that can be run on a computer.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/executable"></see></summary>
    let ``Software/SoftwarePurpose/executable`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/executable" |> NamespacedName

    /// <summary>
    /// The Element is a single file which can be independently distributed (configuration file, statically linked binary, Kubernetes deployment, etc.).
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/file"></see></summary>
    let ``Software/SoftwarePurpose/file`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/file" |> NamespacedName

    /// <summary>
    /// The Element is a file system image that can be written to a disk (or virtual) partition.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/filesystemImage"></see></summary>
    let ``Software/SoftwarePurpose/filesystemImage`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/filesystemImage" |> NamespacedName

    /// <summary>
    /// The Element provides low level control over a device's hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/firmware"></see></summary>
    let ``Software/SoftwarePurpose/firmware`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/firmware" |> NamespacedName

    /// <summary>
    /// The Element is a software framework.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/framework"></see></summary>
    let ``Software/SoftwarePurpose/framework`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/framework" |> NamespacedName

    /// <summary>
    /// The Element is used to install software on disk.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/install"></see></summary>
    let ``Software/SoftwarePurpose/install`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/install" |> NamespacedName

    /// <summary>
    /// The Element is a software library.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/library"></see></summary>
    let ``Software/SoftwarePurpose/library`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/library" |> NamespacedName

    /// <summary>
    /// The Element is a software manifest.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/manifest"></see></summary>
    let ``Software/SoftwarePurpose/manifest`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/manifest" |> NamespacedName

    /// <summary>
    /// The Element is a machine learning or artificial intelligence model.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/model"></see></summary>
    let ``Software/SoftwarePurpose/model`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/model" |> NamespacedName

    /// <summary>
    /// The Element is a module of a piece of software.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/module"></see></summary>
    let ``Software/SoftwarePurpose/module`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/module" |> NamespacedName

    /// <summary>
    /// The Element is an operating system.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/operatingSystem"></see></summary>
    let ``Software/SoftwarePurpose/operatingSystem`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/operatingSystem" |> NamespacedName

    /// <summary>
    /// The Element doesn't fit into any of the other categories.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/other"></see></summary>
    let ``Software/SoftwarePurpose/other`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/other" |> NamespacedName

    /// <summary>
    /// The Element contains a set of changes to update, fix, or improve another Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/patch"></see></summary>
    let ``Software/SoftwarePurpose/patch`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/patch" |> NamespacedName

    /// <summary>
    /// The Element represents a runtime environment.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/platform"></see></summary>
    let ``Software/SoftwarePurpose/platform`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/platform" |> NamespacedName

    /// <summary>
    /// The Element provides a requirement needed as input for another Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/requirement"></see></summary>
    let ``Software/SoftwarePurpose/requirement`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/requirement" |> NamespacedName

    /// <summary>
    /// The Element is a single or a collection of source files.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/source"></see></summary>
    let ``Software/SoftwarePurpose/source`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/source" |> NamespacedName

    /// <summary>
    /// The Element is a plan, guideline or strategy how to create, perform or analyze an application.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/specification"></see></summary>
    let ``Software/SoftwarePurpose/specification`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/specification" |> NamespacedName

    /// <summary>
    /// The Element is a test used to verify functionality on a software element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/test"></see></summary>
    let ``Software/SoftwarePurpose/test`` =
        Namespaced_IRI.parse _namespace_name "Software/SoftwarePurpose/test" |> NamespacedName

    /// <summary>
    /// Provides information about the primary purpose of the software artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/primaryPurpose"></see></summary>
    let ``Software/primaryPurpose`` =
        Namespaced_IRI.parse _namespace_name "Software/primaryPurpose" |> NamespacedName

    /// <summary>
    /// A canonical, unique, immutable identifier of the artifact content, that may be
    /// used for verifying its identity and/or integrity.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/contentIdentifier"></see></summary>
    let ``Software/contentIdentifier`` =
        Namespaced_IRI.parse _namespace_name "Software/contentIdentifier" |> NamespacedName

    /// <summary>
    /// Provides additional purpose information of the software artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/additionalPurpose"></see></summary>
    let ``Software/additionalPurpose`` =
        Namespaced_IRI.parse _namespace_name "Software/additionalPurpose" |> NamespacedName

    /// <summary>
    /// Identifies the size of a software Artifact, in bytes.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/artifactSize"></see></summary>
    let ``Software/artifactSize`` =
        Namespaced_IRI.parse _namespace_name "Software/artifactSize" |> NamespacedName

    /// <summary>
    /// Identifies the text of one or more copyright notices for a software Package,
    /// File or Snippet, if any.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/copyrightText"></see></summary>
    let ``Software/copyrightText`` =
        Namespaced_IRI.parse _namespace_name "Software/copyrightText" |> NamespacedName

    /// <summary>
    /// Provides a place for the SPDX data creator to record acknowledgement text for
    /// a software Package, File or Snippet.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/attributionText"></see></summary>
    let ``Software/attributionText`` =
        Namespaced_IRI.parse _namespace_name "Software/attributionText" |> NamespacedName

    /// <summary>
    /// CreationAction represents an event of product creation.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/CreateAction"></see></summary>
    let ``SupplyChain/CreateAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/CreateAction" |> NamespacedName

    /// <summary>
    /// The CreateProcess refers to the abstract process class that can be used to represent the process of creation of a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/CreateProcess"></see></summary>
    let ``SupplyChain/CreateProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/CreateProcess" |> NamespacedName

    /// <summary>
    /// The action of product use.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/UseAction"></see></summary>
    let ``SupplyChain/UseAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/UseAction" |> NamespacedName

    /// <summary>
    /// The boundary parameters define the area or region needed to describe a boundary.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/boundaryParameter"></see></summary>
    let ``SupplyChain/boundaryParameter`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/boundaryParameter" |> NamespacedName

    /// <summary>
    /// An actual alteration of a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ModifyAction"></see></summary>
    let ``SupplyChain/ModifyAction`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ModifyAction" |> NamespacedName

    /// <summary>
    /// A prescribed alteration of a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ModifyProcess"></see></summary>
    let ``SupplyChain/ModifyProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ModifyProcess" |> NamespacedName

    /// <summary>
    /// Use Process defines actions used by elements.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/UseProcess"></see></summary>
    let ``SupplyChain/UseProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/UseProcess" |> NamespacedName

    /// <summary>
    /// The valid state for DefinedStateProcess.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/validState"></see></summary>
    let ``SupplyChain/validState`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/validState" |> NamespacedName

    /// <summary>
    /// This is the agent that performed the act of destroying the item.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/destructionPerformedBy"></see></summary>
    let ``SupplyChain/destructionPerformedBy`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/destructionPerformedBy" |> NamespacedName

    /// <summary>
    /// The planned location that a good, product or material is inspected.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedInspectionLocation"></see></summary>
    let ``SupplyChain/plannedInspectionLocation`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/plannedInspectionLocation" |> NamespacedName

    /// <summary>
    /// This is the individual, business, or organization who currently manages goods, services, or assets.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/current"></see></summary>
    let ``SupplyChain/current`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/current" |> NamespacedName

    /// <summary>
    /// The element that has it's responsibility changed.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/responsibilityChangedOn"></see></summary>
    let ``SupplyChain/responsibilityChangedOn`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/responsibilityChangedOn" |> NamespacedName

    /// <summary>
    /// This is the individual, business, or organization who was previously managing goods, services, or assets.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/previous"></see></summary>
    let ``SupplyChain/previous`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/previous" |> NamespacedName

    /// <summary>
    /// These categories help define sets Responsibility Type.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType"></see></summary>
    let ``SupplyChain/ResponsibilityType`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ResponsibilityType" |> NamespacedName

    /// <summary>
    /// Ownership refers to the legal right to control, manage, and benefit from an asset, resource, or responsibility. It establishes authority, accountability, and entitlements over something, whether it's property, a business, intellectual property, or responsibilities.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType/ownership"></see></summary>
    let ``SupplyChain/ResponsibilityType/ownership`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ResponsibilityType/ownership" |> NamespacedName

    /// <summary>
    /// Custody refers to the responsibility, control, and safekeeping of an asset, person, or legal entity. It involves both physical possession and legal authority over something or someone.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType/custody"></see></summary>
    let ``SupplyChain/ResponsibilityType/custody`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/ResponsibilityType/custody" |> NamespacedName

    /// <summary>
    /// Requirements can be categorized into various types based on their focus, purpose, and scope.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/responsibilityCategory"></see></summary>
    let ``SupplyChain/responsibilityCategory`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/responsibilityCategory" |> NamespacedName

    /// <summary>
    /// This is the planned individual, business, or organization who currently manages goods, services, or assets.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedCurrent"></see></summary>
    let ``SupplyChain/plannedCurrent`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/plannedCurrent" |> NamespacedName

    /// <summary>
    /// This is the planned product associated with the change of responsibility.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedProductOfResponsibilityChange"></see></summary>
    let ``SupplyChain/plannedProductOfResponsibilityChange`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/plannedProductOfResponsibilityChange" |> NamespacedName

    /// <summary>
    /// This is the planned individual, business, or organization who was previously managing goods, services, or assets.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedPrevious"></see></summary>
    let ``SupplyChain/plannedPrevious`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/plannedPrevious" |> NamespacedName

    /// <summary>
    /// This is the state of an affected Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/currentState"></see></summary>
    let ``SupplyChain/currentState`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/currentState" |> NamespacedName

    /// <summary>
    /// This is how the currentState of an affected Element is found.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/decisionProcess"></see></summary>
    let ``SupplyChain/decisionProcess`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/decisionProcess" |> NamespacedName

    /// <summary>
    /// The planned location that a good, product or material is stored.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedStorageLocation"></see></summary>
    let ``SupplyChain/plannedStorageLocation`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/plannedStorageLocation" |> NamespacedName

    /// <summary>
    /// The location for picking up a package or item.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/pickupLocation"></see></summary>
    let ``SupplyChain/pickupLocation`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/pickupLocation" |> NamespacedName

    /// <summary>
    /// The location for dropping off or delivering a package or item.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/dropoffLocation"></see></summary>
    let ``SupplyChain/dropoffLocation`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/dropoffLocation" |> NamespacedName

    /// <summary>
    /// A transport route refers to the specific path or network used to move people, goods, data, or resources from one location to another.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/transportRoute"></see></summary>
    let ``SupplyChain/transportRoute`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/transportRoute" |> NamespacedName

    /// <summary>
    /// The location for picking up a package or item.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/forPickupLocation"></see></summary>
    let ``SupplyChain/forPickupLocation`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/forPickupLocation" |> NamespacedName

    /// <summary>
    /// A transport route refers to the planned path or network used to move people, goods, data, or resources from one location to another.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedTransportRoutes"></see></summary>
    let ``SupplyChain/plannedTransportRoutes`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/plannedTransportRoutes" |> NamespacedName

    /// <summary>
    /// The location that an item will be dropping off or delivered.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/forDropoffLocation"></see></summary>
    let ``SupplyChain/forDropoffLocation`` =
        Namespaced_IRI.parse _namespace_name "SupplyChain/forDropoffLocation" |> NamespacedName
