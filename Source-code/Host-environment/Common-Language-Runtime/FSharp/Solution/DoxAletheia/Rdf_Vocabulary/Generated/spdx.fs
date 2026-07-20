namespace https.spdx.org.rdf._3._1.terms.slash

open DoxAletheia

module spdx =
    let _namespace_name = "https://spdx.org/rdf/3.1/terms/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Provides information about the creation of the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/CreationInfo"></see></summary>
    let ``Core/CreationInfo`` = _prefix "Core/CreationInfo"
    /// <summary>
    /// Identifies when the Element was originally created.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/created"></see></summary>
    let ``Core/created`` = _prefix "Core/created"
    /// <summary>
    /// Identifies who or what created the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/createdBy"></see></summary>
    let ``Core/createdBy`` = _prefix "Core/createdBy"
    /// <summary>
    /// An Organization representing the SPDX Project.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpdxOrganization"></see></summary>
    let ``Core/SpdxOrganization`` = _prefix "Core/SpdxOrganization"
    /// <summary>
    /// Provides a reference number that can be used to understand how to parse and
    /// interpret an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/specVersion"></see></summary>
    let ``Core/specVersion`` = _prefix "Core/specVersion"
    /// <summary>
    /// A Package that contains AI software or an AI model.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/AIPackage"></see></summary>
    let ``AI/AIPackage`` = _prefix "AI/AIPackage"
    /// <summary>
    /// Refers to any unit of content that can be associated with a distribution of
    /// software.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/Package"></see></summary>
    let ``Software/Package`` = _prefix "Software/Package"
    /// <summary>
    /// Safety risk level.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType"></see></summary>
    let ``AI/SafetyRiskAssessmentType`` = _prefix "AI/SafetyRiskAssessmentType"

    /// <summary>
    /// The highest level of risk posed by an AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/serious"></see></summary>
    let ``AI/SafetyRiskAssessmentType/serious`` =
        _prefix "AI/SafetyRiskAssessmentType/serious"

    /// <summary>
    /// The second-highest level of risk posed by an AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/high"></see></summary>
    let ``AI/SafetyRiskAssessmentType/high`` =
        _prefix "AI/SafetyRiskAssessmentType/high"

    /// <summary>
    /// The third-highest level of risk posed by an AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/medium"></see></summary>
    let ``AI/SafetyRiskAssessmentType/medium`` =
        _prefix "AI/SafetyRiskAssessmentType/medium"

    /// <summary>
    /// Low/no risk is posed by an AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/low"></see></summary>
    let ``AI/SafetyRiskAssessmentType/low`` = _prefix "AI/SafetyRiskAssessmentType/low"
    /// <summary>
    /// Results of general safety risk assessment of the AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/safetyRiskAssessment"></see></summary>
    let ``AI/safetyRiskAssessment`` = _prefix "AI/safetyRiskAssessment"
    /// <summary>
    /// Preprocessing steps applied to the training data before the model training.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/modelDataPreprocessing"></see></summary>
    let ``AI/modelDataPreprocessing`` = _prefix "AI/modelDataPreprocessing"
    /// <summary>
    /// Type of the model used in the AI software.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/typeOfModel"></see></summary>
    let ``AI/typeOfModel`` = _prefix "AI/typeOfModel"
    /// <summary>
    /// Information about the AI software, not including the model description.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/informationAboutApplication"></see></summary>
    let ``AI/informationAboutApplication`` = _prefix "AI/informationAboutApplication"
    /// <summary>
    /// Information about different steps of the training process.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/informationAboutTraining"></see></summary>
    let ``AI/informationAboutTraining`` = _prefix "AI/informationAboutTraining"
    /// <summary>
    /// Limitation of the AI software.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/limitation"></see></summary>
    let ``AI/limitation`` = _prefix "AI/limitation"
    /// <summary>
    /// Categories of presence or absence.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PresenceType"></see></summary>
    let ``Core/PresenceType`` = _prefix "Core/PresenceType"
    /// <summary>
    /// Indicates presence of the field.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PresenceType/yes"></see></summary>
    let ``Core/PresenceType/yes`` = _prefix "Core/PresenceType/yes"
    /// <summary>
    /// Indicates absence of the field.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PresenceType/no"></see></summary>
    let ``Core/PresenceType/no`` = _prefix "Core/PresenceType/no"
    /// <summary>
    /// Makes no assertion about the field.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PresenceType/noAssertion"></see></summary>
    let ``Core/PresenceType/noAssertion`` = _prefix "Core/PresenceType/noAssertion"

    /// <summary>
    /// Records if sensitive personal information is used during model training or
    /// could be used during the inference.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/useSensitivePersonalInformation"></see></summary>
    let ``AI/useSensitivePersonalInformation`` =
        _prefix "AI/useSensitivePersonalInformation"

    /// <summary>
    /// A key with an associated value.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/DictionaryEntry"></see></summary>
    let ``Core/DictionaryEntry`` = _prefix "Core/DictionaryEntry"
    /// <summary>
    /// Threshold that was used for computation of a metric described in
    /// the metric field.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/metricDecisionThreshold"></see></summary>
    let ``AI/metricDecisionThreshold`` = _prefix "AI/metricDecisionThreshold"
    /// <summary>
    /// Defines the level of automation a system possesses.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel"></see></summary>
    let ``Core/IsoAutomationLevel`` = _prefix "Core/IsoAutomationLevel"

    /// <summary>
    /// Level 6 - Autonomous. The system is capable of modifying its intended domain of use or its goals without external intervention, control or oversight.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/autonomous"></see></summary>
    let ``Core/IsoAutomationLevel/autonomous`` =
        _prefix "Core/IsoAutomationLevel/autonomous"

    /// <summary>
    /// Level 5 - Full automation. The system is capable of performing its entire mission without external intervention.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/fullAutomation"></see></summary>
    let ``Core/IsoAutomationLevel/fullAutomation`` =
        _prefix "Core/IsoAutomationLevel/fullAutomation"

    /// <summary>
    /// Level 4 - High automation. The system performs parts of its mission without external intervention.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/highAutomation"></see></summary>
    let ``Core/IsoAutomationLevel/highAutomation`` =
        _prefix "Core/IsoAutomationLevel/highAutomation"

    /// <summary>
    /// Level 3 - Conditional automation. The system can propose strategies and then automatically execute the approved plan, with an external agent being ready to take over when necessary.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/conditionalAutomation"></see></summary>
    let ``Core/IsoAutomationLevel/conditionalAutomation`` =
        _prefix "Core/IsoAutomationLevel/conditionalAutomation"

    /// <summary>
    /// Level 2 - Partial automation or task automation. Some sub-functions of the system are fully automated while the system remain under control of an external agent. The system can perform actions for an approved task without requiring the agent's continuous direct control.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/partialAutomation"></see></summary>
    let ``Core/IsoAutomationLevel/partialAutomation`` =
        _prefix "Core/IsoAutomationLevel/partialAutomation"

    /// <summary>
    /// Level 1 - Assistive automation. The system assists an operator.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/assistiveAutomation"></see></summary>
    let ``Core/IsoAutomationLevel/assistiveAutomation`` =
        _prefix "Core/IsoAutomationLevel/assistiveAutomation"

    /// <summary>
    /// Level 0 - Not automated. No automation. The operator fully controls the system.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/notAutomated"></see></summary>
    let ``Core/IsoAutomationLevel/notAutomated`` =
        _prefix "Core/IsoAutomationLevel/notAutomated"

    /// <summary>
    /// ISO level of automation.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/isoAutomationLevel"></see></summary>
    let ``Core/isoAutomationLevel`` = _prefix "Core/isoAutomationLevel"
    /// <summary>
    /// Metric used to evaluate the AI model.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/metric"></see></summary>
    let ``AI/metric`` = _prefix "AI/metric"
    /// <summary>
    /// **DEPRECATED in SPDX 3.1.**
    /// Use [/Core/isoAutomationLevel](../../Core/Properties/isoAutomationLevel.md)
    /// instead.
    ///
    /// Indicates whether the system can perform a decision or action without human
    /// involvement or guidance.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/autonomyType"></see></summary>
    let ``AI/autonomyType`` = _prefix "AI/autonomyType"
    /// <summary>
    /// Hyperparameter used to build the AI model contained in the AI package.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/hyperparameter"></see></summary>
    let ``AI/hyperparameter`` = _prefix "AI/hyperparameter"
    /// <summary>
    /// A class for describing the energy consumption incurred by an AI model in
    /// different stages of its lifecycle.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/EnergyConsumption"></see></summary>
    let ``AI/EnergyConsumption`` = _prefix "AI/EnergyConsumption"
    /// <summary>
    /// Energy consumption incurred by an AI model.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/energyConsumption"></see></summary>
    let ``AI/energyConsumption`` = _prefix "AI/energyConsumption"
    /// <summary>
    /// Standard that an artifact is being complied with.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/standardCompliance"></see></summary>
    let ``AI/standardCompliance`` = _prefix "AI/standardCompliance"
    /// <summary>
    /// Methods that can be used to explain the results from the AI model.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/modelExplainability"></see></summary>
    let ``AI/modelExplainability`` = _prefix "AI/modelExplainability"
    /// <summary>
    /// Domain in which the AI package can be used.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/domain"></see></summary>
    let ``AI/domain`` = _prefix "AI/domain"
    /// <summary>
    /// The class that helps note down the quantity of energy consumption and the unit
    /// used for measurement.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/EnergyConsumptionDescription"></see></summary>
    let ``AI/EnergyConsumptionDescription`` = _prefix "AI/EnergyConsumptionDescription"
    /// <summary>
    /// Energy consumed when finetuning the AI model that is
    /// being used in the AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/finetuningEnergyConsumption"></see></summary>
    let ``AI/finetuningEnergyConsumption`` = _prefix "AI/finetuningEnergyConsumption"
    /// <summary>
    /// Energy consumed when training the AI model that is
    /// being used in the AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/trainingEnergyConsumption"></see></summary>
    let ``AI/trainingEnergyConsumption`` = _prefix "AI/trainingEnergyConsumption"
    /// <summary>
    /// Energy consumed during inference time by an AI model
    /// that is being used in the AI system.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/inferenceEnergyConsumption"></see></summary>
    let ``AI/inferenceEnergyConsumption`` = _prefix "AI/inferenceEnergyConsumption"
    /// <summary>
    /// Unit of energy consumption.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType"></see></summary>
    let ``AI/EnergyUnitType`` = _prefix "AI/EnergyUnitType"
    /// <summary>
    /// Kilowatt-hour.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/kilowattHour"></see></summary>
    let ``AI/EnergyUnitType/kilowattHour`` = _prefix "AI/EnergyUnitType/kilowattHour"
    /// <summary>
    /// Megajoule.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/megajoule"></see></summary>
    let ``AI/EnergyUnitType/megajoule`` = _prefix "AI/EnergyUnitType/megajoule"
    /// <summary>
    /// Any other units of energy measurement.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/other"></see></summary>
    let ``AI/EnergyUnitType/other`` = _prefix "AI/EnergyUnitType/other"
    /// <summary>
    /// Unit in which energy is measured.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/energyUnit"></see></summary>
    let ``AI/energyUnit`` = _prefix "AI/energyUnit"
    /// <summary>
    /// Energy quantity.
    /// <see href="https://spdx.org/rdf/3.1/terms/AI/energyQuantity"></see></summary>
    let ``AI/energyQuantity`` = _prefix "AI/energyQuantity"
    /// <summary>
    /// Class that describes a build instance of software/artifacts.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/Build"></see></summary>
    let ``Build/Build`` = _prefix "Build/Build"
    /// <summary>
    /// Base domain class from which all other SPDX 3 domain classes derive.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Element"></see></summary>
    let ``Core/Element`` = _prefix "Core/Element"
    /// <summary>
    /// Property describing a parameter used in an instance of a build.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/parameter"></see></summary>
    let ``Build/parameter`` = _prefix "Build/parameter"
    /// <summary>
    /// Property describing the session in which a build is invoked.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/environment"></see></summary>
    let ``Build/environment`` = _prefix "Build/environment"
    /// <summary>
    /// Property describes the invocation entrypoint of a build.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/configSourceEntrypoint"></see></summary>
    let ``Build/configSourceEntrypoint`` = _prefix "Build/configSourceEntrypoint"
    /// <summary>
    /// A buildId is a locally unique identifier used by a builder to identify a unique
    /// instance of a build produced by it.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/buildId"></see></summary>
    let ``Build/buildId`` = _prefix "Build/buildId"
    /// <summary>
    /// A buildType is a hint that is used to indicate the toolchain, platform, or
    /// infrastructure that the build was invoked on.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/buildType"></see></summary>
    let ``Build/buildType`` = _prefix "Build/buildType"
    /// <summary>
    /// Property that describes the URI of the build configuration source file.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/configSourceUri"></see></summary>
    let ``Build/configSourceUri`` = _prefix "Build/configSourceUri"
    /// <summary>
    /// Property describing the start time of a build.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/buildStartTime"></see></summary>
    let ``Build/buildStartTime`` = _prefix "Build/buildStartTime"
    /// <summary>
    /// A mathematically calculated representation of a grouping of data.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Hash"></see></summary>
    let ``Core/Hash`` = _prefix "Core/Hash"
    /// <summary>
    /// Property that describes the digest of the build configuration file used to
    /// invoke a build.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/configSourceDigest"></see></summary>
    let ``Build/configSourceDigest`` = _prefix "Build/configSourceDigest"
    /// <summary>
    /// Property that describes the time at which a build stops.
    /// <see href="https://spdx.org/rdf/3.1/terms/Build/buildEndTime"></see></summary>
    let ``Build/buildEndTime`` = _prefix "Build/buildEndTime"
    /// <summary>
    /// Class that describes an action that has occurred.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Action"></see></summary>
    let ``Core/Action`` = _prefix "Core/Action"
    /// <summary>
    /// A distinct article or unit within the domain.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Artifact"></see></summary>
    let ``Core/Artifact`` = _prefix "Core/Artifact"
    /// <summary>
    /// Property describing the start time of an action.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/actionStartTime"></see></summary>
    let ``Core/actionStartTime`` = _prefix "Core/actionStartTime"
    /// <summary>
    /// Additional relevance information.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/additionalInformation"></see></summary>
    let ``Core/additionalInformation`` = _prefix "Core/additionalInformation"
    /// <summary>
    /// Property that describes the time at which an action stops.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/actionEndTime"></see></summary>
    let ``Core/actionEndTime`` = _prefix "Core/actionEndTime"
    /// <summary>
    /// Location is used to define the location, address or coordinates of a place.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Location"></see></summary>
    let ``Core/Location`` = _prefix "Core/Location"
    /// <summary>
    /// Location of a specific action.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/actionLocation"></see></summary>
    let ``Core/actionLocation`` = _prefix "Core/actionLocation"
    /// <summary>
    /// Agent represents anything with the potential to act on a system.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Agent"></see></summary>
    let ``Core/Agent`` = _prefix "Core/Agent"
    /// <summary>
    /// An assertion made in relation to one or more elements.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Annotation"></see></summary>
    let ``Core/Annotation`` = _prefix "Core/Annotation"
    /// <summary>
    /// Commentary on an assertion that an annotator has made.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/statement"></see></summary>
    let ``Core/statement`` = _prefix "Core/statement"
    /// <summary>
    /// Provides information about the content type of an Element or a property.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/contentType"></see></summary>
    let ``Core/contentType`` = _prefix "Core/contentType"
    /// <summary>
    /// Specifies the type of an annotation.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/AnnotationType"></see></summary>
    let ``Core/AnnotationType`` = _prefix "Core/AnnotationType"
    /// <summary>
    /// Used to store extra information about an Element which is not part of a review (e.g. extra information provided during the creation of the Element).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/AnnotationType/other"></see></summary>
    let ``Core/AnnotationType/other`` = _prefix "Core/AnnotationType/other"
    /// <summary>
    /// Used when someone reviews the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/AnnotationType/review"></see></summary>
    let ``Core/AnnotationType/review`` = _prefix "Core/AnnotationType/review"
    /// <summary>
    /// Describes the type of annotation.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/annotationType"></see></summary>
    let ``Core/annotationType`` = _prefix "Core/annotationType"
    /// <summary>
    /// An Element an annotator has made an assertion about.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/subject"></see></summary>
    let ``Core/subject`` = _prefix "Core/subject"
    /// <summary>
    /// Specifies the time an artifact was built.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/builtTime"></see></summary>
    let ``Core/builtTime`` = _prefix "Core/builtTime"
    /// <summary>
    /// Identifies who or what supplied the artifact or VulnAssessmentRelationship
    /// referenced by the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/suppliedBy"></see></summary>
    let ``Core/suppliedBy`` = _prefix "Core/suppliedBy"
    /// <summary>
    /// Specifies until when the artifact can be used before its usage needs to be
    /// reassessed.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/validUntilTime"></see></summary>
    let ``Core/validUntilTime`` = _prefix "Core/validUntilTime"
    /// <summary>
    /// The intendedUse property is designed to capture a summary of how or for what item or artifact is meant to be used for.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/intendedUse"></see></summary>
    let ``Core/intendedUse`` = _prefix "Core/intendedUse"
    /// <summary>
    /// Identifies from where or whom the Element originally came.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/originatedBy"></see></summary>
    let ``Core/originatedBy`` = _prefix "Core/originatedBy"
    /// <summary>
    /// The name of a relevant standard that may apply to an artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/standardName"></see></summary>
    let ``Core/standardName`` = _prefix "Core/standardName"
    /// <summary>
    /// Specifies the time an artifact was released.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/releaseTime"></see></summary>
    let ``Core/releaseTime`` = _prefix "Core/releaseTime"
    /// <summary>
    /// Type of support that is associated with an artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType"></see></summary>
    let ``Core/SupportType`` = _prefix "Core/SupportType"
    /// <summary>
    /// The artifact is in active development and is not considered ready for formal support from the supplier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/development"></see></summary>
    let ``Core/SupportType/development`` = _prefix "Core/SupportType/development"
    /// <summary>
    /// The artifact has been released, and is supported from the supplier. There is a validUntilDate that can provide additional information about the duration of support.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/support"></see></summary>
    let ``Core/SupportType/support`` = _prefix "Core/SupportType/support"
    /// <summary>
    /// In addition to being supported by the supplier, the software is known to have been deployed and is in use. For a software as a service provider, this implies the software is now available as a service.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/deployed"></see></summary>
    let ``Core/SupportType/deployed`` = _prefix "Core/SupportType/deployed"
    /// <summary>
    /// The artifact has been released, and there is limited support available from the supplier. There is a validUntilDate that can provide additional information about the duration of support.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/limitedSupport"></see></summary>
    let ``Core/SupportType/limitedSupport`` = _prefix "Core/SupportType/limitedSupport"
    /// <summary>
    /// There is a defined end of support for the artifact from the supplier. This may also be referred to as end of life. There is a validUntilDate that can be used to signal when support ends for the artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/endOfSupport"></see></summary>
    let ``Core/SupportType/endOfSupport`` = _prefix "Core/SupportType/endOfSupport"
    /// <summary>
    /// There is no support for the artifact from the supplier, consumer assumes any support obligations.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/noSupport"></see></summary>
    let ``Core/SupportType/noSupport`` = _prefix "Core/SupportType/noSupport"
    /// <summary>
    /// No assertion about the type of support is made. This is considered the default if no other support type is used.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportType/noAssertion"></see></summary>
    let ``Core/SupportType/noAssertion`` = _prefix "Core/SupportType/noAssertion"
    /// <summary>
    /// Specifies the level of support associated with an artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/supportLevel"></see></summary>
    let ``Core/supportLevel`` = _prefix "Core/supportLevel"
    /// <summary>
    /// A container for a grouping of SPDX 3 content characterizing details
    /// (provenance, composition, licensing, etc.) about a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Bom"></see></summary>
    let ``Core/Bom`` = _prefix "Core/Bom"
    /// <summary>
    /// A collection of Elements that have a shared context.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Bundle"></see></summary>
    let ``Core/Bundle`` = _prefix "Core/Bundle"
    /// <summary>
    /// A collection of Elements, not necessarily with unifying context.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ElementCollection"></see></summary>
    let ``Core/ElementCollection`` = _prefix "Core/ElementCollection"
    /// <summary>
    /// Gives information about the circumstances or unifying properties
    /// that Elements of the bundle have been assembled under.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/context"></see></summary>
    let ``Core/context`` = _prefix "Core/context"
    /// <summary>
    /// A contact point from an Artifact to an Agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationship"></see></summary>
    let ``Core/ContactPointRelationship`` = _prefix "Core/ContactPointRelationship"
    /// <summary>
    /// Describes a relationship between one or more elements.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Relationship"></see></summary>
    let ``Core/Relationship`` = _prefix "Core/Relationship"

    /// <summary>
    /// Information about the type of contact point for `ContactPointRelationship`s.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType"></see></summary>
    let ``Core/ContactPointRelationshipType`` =
        _prefix "Core/ContactPointRelationshipType"

    /// <summary>
    /// A contact point for compliance (i.e. export control, licensing).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/compliance"></see></summary>
    let ``Core/ContactPointRelationshipType/compliance`` =
        _prefix "Core/ContactPointRelationshipType/compliance"

    /// <summary>
    /// A generic contact point to be used when the contact type does not match any of the other options.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/other"></see></summary>
    let ``Core/ContactPointRelationshipType/other`` =
        _prefix "Core/ContactPointRelationshipType/other"

    /// <summary>
    /// A contact for reporting security vulnerabilities.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/securityVulnerability"></see></summary>
    let ``Core/ContactPointRelationshipType/securityVulnerability`` =
        _prefix "Core/ContactPointRelationshipType/securityVulnerability"

    /// <summary>
    /// A contact point for support.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/support"></see></summary>
    let ``Core/ContactPointRelationshipType/support`` =
        _prefix "Core/ContactPointRelationshipType/support"

    /// <summary>
    /// Identifies the nature of the contactPointRelationship.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/contactType"></see></summary>
    let ``Core/contactType`` = _prefix "Core/contactType"
    /// <summary>
    /// Provide consumers with comments by the creator of the Element about the
    /// Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/comment"></see></summary>
    let ``Core/comment`` = _prefix "Core/comment"
    /// <summary>
    /// An element of hardware and/or software utilized to carry out a particular function.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Tool"></see></summary>
    let ``Core/Tool`` = _prefix "Core/Tool"
    /// <summary>
    /// Identifies the tooling that was used during the creation of the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/createdUsing"></see></summary>
    let ``Core/createdUsing`` = _prefix "Core/createdUsing"
    /// <summary>
    /// Class that describes a process.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/DefinedProcess"></see></summary>
    let ``Core/DefinedProcess`` = _prefix "Core/DefinedProcess"
    /// <summary>
    /// Defines the version of a specific process.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/processVersion"></see></summary>
    let ``Core/processVersion`` = _prefix "Core/processVersion"
    /// <summary>
    /// The ProcessReadinessType is defined by the enumeration.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType"></see></summary>
    let ``Core/ProcessReadinessType`` = _prefix "Core/ProcessReadinessType"
    /// <summary>
    /// in production
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/draft"></see></summary>
    let ``Core/ProcessReadinessType/draft`` = _prefix "Core/ProcessReadinessType/draft"

    /// <summary>
    /// in use
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/active"></see></summary>
    let ``Core/ProcessReadinessType/active`` =
        _prefix "Core/ProcessReadinessType/active"

    /// <summary>
    /// superseded or not valid at present
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/obsolete"></see></summary>
    let ``Core/ProcessReadinessType/obsolete`` =
        _prefix "Core/ProcessReadinessType/obsolete"

    /// <summary>
    /// other
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/other"></see></summary>
    let ``Core/ProcessReadinessType/other`` = _prefix "Core/ProcessReadinessType/other"
    /// <summary>
    /// processReadiness describes the readiness of a process.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/processReadiness"></see></summary>
    let ``Core/processReadiness`` = _prefix "Core/processReadiness"
    /// <summary>
    /// The reason a process exists.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/processRationale"></see></summary>
    let ``Core/processRationale`` = _prefix "Core/processRationale"
    /// <summary>
    /// The DefinedType class associates a specific type with its defined source.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/DefinedType"></see></summary>
    let ``Core/DefinedType`` = _prefix "Core/DefinedType"
    /// <summary>
    /// A specification is a detailed description of the design, requirements,
    /// or features of a product, process, or system.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Specification"></see></summary>
    let ``Core/Specification`` = _prefix "Core/Specification"
    /// <summary>
    /// It is the authoritative or credible entity, document, or body of knowledge that provides the meaning of a type, ensuring accuracy, context, and standardization.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/definitionSource"></see></summary>
    let ``Core/definitionSource`` = _prefix "Core/definitionSource"
    /// <summary>
    /// typeFromSource is a value used to define an item within the definitionSource.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/typeFromSource"></see></summary>
    let ``Core/typeFromSource`` = _prefix "Core/typeFromSource"
    /// <summary>
    /// A key used in a generic key-value pair.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/key"></see></summary>
    let ``Core/key`` = _prefix "Core/key"
    /// <summary>
    /// A value used in a generic key-value pair.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/value"></see></summary>
    let ``Core/value`` = _prefix "Core/value"
    /// <summary>
    /// A reference to a resource outside the scope of SPDX 3 content related to an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRef"></see></summary>
    let ``Core/ExternalRef`` = _prefix "Core/ExternalRef"
    /// <summary>
    /// Points to a resource outside the scope of the SPDX 3 content
    /// that provides additional characteristics of an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/externalRef"></see></summary>
    let ``Core/externalRef`` = _prefix "Core/externalRef"
    /// <summary>
    /// Provides information about the creation of the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/creationInfo"></see></summary>
    let ``Core/creationInfo`` = _prefix "Core/creationInfo"
    /// <summary>
    /// Provides an independently reproducible mechanism that permits verification of a specific Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IntegrityMethod"></see></summary>
    let ``Core/IntegrityMethod`` = _prefix "Core/IntegrityMethod"
    /// <summary>
    /// Provides an IntegrityMethod with which the integrity of an Element can be
    /// asserted.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/verifiedUsing"></see></summary>
    let ``Core/verifiedUsing`` = _prefix "Core/verifiedUsing"
    /// <summary>
    /// A short description of an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/summary"></see></summary>
    let ``Core/summary`` = _prefix "Core/summary"
    /// <summary>
    /// Identifies the name of an Element as designated by the creator.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/name"></see></summary>
    let ``Core/name`` = _prefix "Core/name"
    /// <summary>
    /// A reference to a resource identifier defined outside the scope of SPDX 3 content that uniquely identifies an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifier"></see></summary>
    let ``Core/ExternalIdentifier`` = _prefix "Core/ExternalIdentifier"
    /// <summary>
    /// Provides a reference to a resource outside the scope of SPDX 3 content
    /// that uniquely identifies an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/externalIdentifier"></see></summary>
    let ``Core/externalIdentifier`` = _prefix "Core/externalIdentifier"
    /// <summary>
    /// Provides a detailed description of the Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/description"></see></summary>
    let ``Core/description`` = _prefix "Core/description"

    /// <summary>
    /// RequirementVerification class defines the base properties of a verification.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/RequirementVerification"></see></summary>
    let ``FunctionalSafety/RequirementVerification`` =
        _prefix "FunctionalSafety/RequirementVerification"

    /// <summary>
    /// EvidenceRelationship defines the association between pieces of evidence and EvaluationResult.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceRelationship"></see></summary>
    let ``FunctionalSafety/EvidenceRelationship`` =
        _prefix "FunctionalSafety/EvidenceRelationship"

    /// <summary>
    /// EvaluationResult is the result of an evaluation.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResult"></see></summary>
    let ``FunctionalSafety/EvaluationResult`` =
        _prefix "FunctionalSafety/EvaluationResult"

    /// <summary>
    /// Provides an SSVC assessment for a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/SsvcVulnAssessmentRelationship"></see></summary>
    let ``Security/SsvcVulnAssessmentRelationship`` =
        _prefix "Security/SsvcVulnAssessmentRelationship"

    /// <summary>
    /// Provides a CVSS version 2.0 assessment for a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssV2VulnAssessmentRelationship"></see></summary>
    let ``Security/CvssV2VulnAssessmentRelationship`` =
        _prefix "Security/CvssV2VulnAssessmentRelationship"

    /// <summary>
    /// Provides an exploit assessment of a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogVulnAssessmentRelationship"></see></summary>
    let ``Security/ExploitCatalogVulnAssessmentRelationship`` =
        _prefix "Security/ExploitCatalogVulnAssessmentRelationship"

    /// <summary>
    /// Provides a CVSS version 4 assessment for a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssV4VulnAssessmentRelationship"></see></summary>
    let ``Security/CvssV4VulnAssessmentRelationship`` =
        _prefix "Security/CvssV4VulnAssessmentRelationship"

    /// <summary>
    /// Connects a vulnerability and an element designating the element as a product
    /// affected by the vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexAffectedVulnAssessmentRelationship"></see></summary>
    let ``Security/VexAffectedVulnAssessmentRelationship`` =
        _prefix "Security/VexAffectedVulnAssessmentRelationship"

    /// <summary>
    /// Links a vulnerability and one or more elements designating the latter as products
    /// not affected by the vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexNotAffectedVulnAssessmentRelationship"></see></summary>
    let ``Security/VexNotAffectedVulnAssessmentRelationship`` =
        _prefix "Security/VexNotAffectedVulnAssessmentRelationship"

    /// <summary>
    /// Provides a CVSS version 3 assessment for a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssV3VulnAssessmentRelationship"></see></summary>
    let ``Security/CvssV3VulnAssessmentRelationship`` =
        _prefix "Security/CvssV3VulnAssessmentRelationship"

    /// <summary>
    /// Specifies a vulnerability and its associated information.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/Vulnerability"></see></summary>
    let ``Security/Vulnerability`` = _prefix "Security/Vulnerability"

    /// <summary>
    /// Designates elements as products where the impact of a vulnerability is being
    /// investigated.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexUnderInvestigationVulnAssessmentRelationship"></see></summary>
    let ``Security/VexUnderInvestigationVulnAssessmentRelationship`` =
        _prefix "Security/VexUnderInvestigationVulnAssessmentRelationship"

    /// <summary>
    /// Provides an EPSS assessment for a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/EpssVulnAssessmentRelationship"></see></summary>
    let ``Security/EpssVulnAssessmentRelationship`` =
        _prefix "Security/EpssVulnAssessmentRelationship"

    /// <summary>
    /// Links a vulnerability and elements representing products (in the VEX sense) where
    /// a fix has been applied and are no longer affected.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexFixedVulnAssessmentRelationship"></see></summary>
    let ``Security/VexFixedVulnAssessmentRelationship`` =
        _prefix "Security/VexFixedVulnAssessmentRelationship"

    /// <summary>
    /// A mapping between prefixes and namespace partial URIs.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/NamespaceMap"></see></summary>
    let ``Core/NamespaceMap`` = _prefix "Core/NamespaceMap"

    /// <summary>
    /// Provide context for a relationship that occurs in the lifecycle.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopedRelationship"></see></summary>
    let ``Core/LifecycleScopedRelationship`` =
        _prefix "Core/LifecycleScopedRelationship"

    /// <summary>
    /// A key with an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ElementMap"></see></summary>
    let ``Core/ElementMap`` = _prefix "Core/ElementMap"
    /// <summary>
    /// Describes how an Agent provides support for an Artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SupportRelationship"></see></summary>
    let ``Core/SupportRelationship`` = _prefix "Core/SupportRelationship"
    /// <summary>
    /// The measure of length refers to the dimension of an object or space that describes how long it is, typically expressed in various units depending on the system of measurement being used.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/MeasureOfLength"></see></summary>
    let ``Core/MeasureOfLength`` = _prefix "Core/MeasureOfLength"
    /// <summary>
    /// A concrete subclass of Element used by Individuals in the
    /// Core profile.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/IndividualElement"></see></summary>
    let ``Core/IndividualElement`` = _prefix "Core/IndividualElement"
    /// <summary>
    /// UnitofMeasure specify information structures through industry standards for Units of Measure, Quantity Kinds, Dimensions and Data Types.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/UnitOfMeasure"></see></summary>
    let ``Core/UnitOfMeasure`` = _prefix "Core/UnitOfMeasure"
    /// <summary>
    /// A tuple of two positive integers that define a range.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PositiveIntegerRange"></see></summary>
    let ``Core/PositiveIntegerRange`` = _prefix "Core/PositiveIntegerRange"
    /// <summary>
    /// A map of Element identifiers that are used within an SpdxDocument but defined
    /// external to that SpdxDocument.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalMap"></see></summary>
    let ``Core/ExternalMap`` = _prefix "Core/ExternalMap"
    /// <summary>
    /// A collection of SPDX Elements that could potentially be serialized.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpdxDocument"></see></summary>
    let ``Core/SpdxDocument`` = _prefix "Core/SpdxDocument"
    /// <summary>
    /// An individual human being.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Person"></see></summary>
    let ``Core/Person`` = _prefix "Core/Person"
    /// <summary>
    /// A group of people who work together in an organized way for a shared purpose.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Organization"></see></summary>
    let ``Core/Organization`` = _prefix "Core/Organization"
    /// <summary>
    /// The measure of mass refers to the quantity of matter in an object or substance.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/MeasureOfMass"></see></summary>
    let ``Core/MeasureOfMass`` = _prefix "Core/MeasureOfMass"
    /// <summary>
    /// A distinct unit representing a requirement, as used in systems, software, and hardware engineering.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Requirement"></see></summary>
    let ``Core/Requirement`` = _prefix "Core/Requirement"
    /// <summary>
    /// A software agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SoftwareAgent"></see></summary>
    let ``Core/SoftwareAgent`` = _prefix "Core/SoftwareAgent"
    /// <summary>
    /// An SPDX version 2.X compatible verification method for software packages.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PackageVerificationCode"></see></summary>
    let ``Core/PackageVerificationCode`` = _prefix "Core/PackageVerificationCode"
    /// <summary>
    /// A physical location is a tangible, geographically identifiable place where objects, people, or assets exist or operate.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/PhysicalLocation"></see></summary>
    let ``Core/PhysicalLocation`` = _prefix "Core/PhysicalLocation"
    /// <summary>
    /// Regulation represents a rule or directive maintained by an authority.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/Regulation"></see></summary>
    let ``Core/Regulation`` = _prefix "Core/Regulation"
    /// <summary>
    /// A Package that contains a dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetPackage"></see></summary>
    let ``Dataset/DatasetPackage`` = _prefix "Dataset/DatasetPackage"
    /// <summary>
    /// A license that is not listed on the SPDX License List.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/CustomLicense"></see></summary>
    let ``ExpandedLicensing/CustomLicense`` = _prefix "ExpandedLicensing/CustomLicense"

    /// <summary>
    /// Portion of an AnyLicenseInfo representing this version, or any later version,
    /// of the indicated License.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/OrLaterOperator"></see></summary>
    let ``ExpandedLicensing/OrLaterOperator`` =
        _prefix "ExpandedLicensing/OrLaterOperator"

    /// <summary>
    /// A license that is listed on the SPDX License List.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ListedLicense"></see></summary>
    let ``ExpandedLicensing/ListedLicense`` = _prefix "ExpandedLicensing/ListedLicense"

    /// <summary>
    /// Portion of an AnyLicenseInfo representing a set of licensing information where
    /// only one of the elements applies.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/DisjunctiveLicenseSet"></see></summary>
    let ``ExpandedLicensing/DisjunctiveLicenseSet`` =
        _prefix "ExpandedLicensing/DisjunctiveLicenseSet"

    /// <summary>
    /// A license exception that is listed on the SPDX Exceptions list.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ListedLicenseException"></see></summary>
    let ``ExpandedLicensing/ListedLicenseException`` =
        _prefix "ExpandedLicensing/ListedLicenseException"

    /// <summary>
    /// Portion of an AnyLicenseInfo representing a License which has additional
    /// text applied to it.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/WithAdditionOperator"></see></summary>
    let ``ExpandedLicensing/WithAdditionOperator`` =
        _prefix "ExpandedLicensing/WithAdditionOperator"

    /// <summary>
    /// A concrete subclass of AnyLicenseInfo used by Individuals in the
    /// ExpandedLicensing profile.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/IndividualLicensingInfo"></see></summary>
    let ``ExpandedLicensing/IndividualLicensingInfo`` =
        _prefix "ExpandedLicensing/IndividualLicensingInfo"

    /// <summary>
    /// A license addition that is not listed on the SPDX Exceptions List.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/CustomLicenseAddition"></see></summary>
    let ``ExpandedLicensing/CustomLicenseAddition`` =
        _prefix "ExpandedLicensing/CustomLicenseAddition"

    /// <summary>
    /// Portion of an AnyLicenseInfo representing a set of licensing information
    /// where all elements apply.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ConjunctiveLicenseSet"></see></summary>
    let ``ExpandedLicensing/ConjunctiveLicenseSet`` =
        _prefix "ExpandedLicensing/ConjunctiveLicenseSet"

    /// <summary>
    /// An SPDX Element containing an SPDX license expression string.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/LicenseExpression"></see></summary>
    let ``SimpleLicensing/LicenseExpression`` =
        _prefix "SimpleLicensing/LicenseExpression"

    /// <summary>
    /// A license or addition that is not listed on the SPDX License List.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/SimpleLicensingText"></see></summary>
    let ``SimpleLicensing/SimpleLicensingText`` =
        _prefix "SimpleLicensing/SimpleLicensingText"

    /// <summary>
    /// A property name with an associated value.
    /// <see href="https://spdx.org/rdf/3.1/terms/Extension/CdxPropertyEntry"></see></summary>
    let ``Extension/CdxPropertyEntry`` = _prefix "Extension/CdxPropertyEntry"
    /// <summary>
    /// Temporary endeavor with a beginning and an end and that must be used to create a unique product, service or result.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/Project"></see></summary>
    let ``Operations/Project`` = _prefix "Operations/Project"

    /// <summary>
    /// Assement of an Element for export control classification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/ExportControlClassificationAssessment"></see></summary>
    let ``Operations/ExportControlClassificationAssessment`` =
        _prefix "Operations/ExportControlClassificationAssessment"

    /// <summary>
    /// Assement of an Element for export control classification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/ExportControlClassification"></see></summary>
    let ``Operations/ExportControlClassification`` =
        _prefix "Operations/ExportControlClassification"

    /// <summary>
    /// This is the state of an affected Element at a specific moment in time.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/StateAction"></see></summary>
    let ``SupplyChain/StateAction`` = _prefix "SupplyChain/StateAction"
    /// <summary>
    /// A state is an instance that describes what a system, component, subsystem, process, or project has achieved at any given time.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/State"></see></summary>
    let ``SupplyChain/State`` = _prefix "SupplyChain/State"
    /// <summary>
    /// AssemblyAction represents the event of creating a product by assembling individual components.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/AssemblyAction"></see></summary>
    let ``SupplyChain/AssemblyAction`` = _prefix "SupplyChain/AssemblyAction"

    /// <summary>
    /// The Boundary Definition Process refers to the process class used to produce boundaries.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryDefinitionProcess"></see></summary>
    let ``SupplyChain/BoundaryDefinitionProcess`` =
        _prefix "SupplyChain/BoundaryDefinitionProcess"

    /// <summary>
    /// The destruction process is defined in this process.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/DestroyProcess"></see></summary>
    let ``SupplyChain/DestroyProcess`` = _prefix "SupplyChain/DestroyProcess"

    /// <summary>
    /// ResponsibilityChangeAction refers to the transfer of responsibility from one party to another.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityChangeAction"></see></summary>
    let ``SupplyChain/ResponsibilityChangeAction`` =
        _prefix "SupplyChain/ResponsibilityChangeAction"

    /// <summary>
    /// A PlanAction involves the execution of a plan in relation to a PlanProcess.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/PlanAction"></see></summary>
    let ``SupplyChain/PlanAction`` = _prefix "SupplyChain/PlanAction"
    /// <summary>
    /// The record of destruction is entered in this action.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/DestroyAction"></see></summary>
    let ``SupplyChain/DestroyAction`` = _prefix "SupplyChain/DestroyAction"
    /// <summary>
    /// An actual change to a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ChangeAction"></see></summary>
    let ``SupplyChain/ChangeAction`` = _prefix "SupplyChain/ChangeAction"
    /// <summary>
    /// A prescribed change to a product's location.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/TransportProcess"></see></summary>
    let ``SupplyChain/TransportProcess`` = _prefix "SupplyChain/TransportProcess"
    /// <summary>
    /// Products out of specification require a resolution action. This is the action of resolution.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResolutionAction"></see></summary>
    let ``SupplyChain/ResolutionAction`` = _prefix "SupplyChain/ResolutionAction"
    /// <summary>
    /// Test Process defines the testing process for an element.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/TestProcess"></see></summary>
    let ``SupplyChain/TestProcess`` = _prefix "SupplyChain/TestProcess"
    /// <summary>
    /// This process is used to determine the state of an affected Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/DefinedStateProcess"></see></summary>
    let ``SupplyChain/DefinedStateProcess`` = _prefix "SupplyChain/DefinedStateProcess"
    /// <summary>
    /// Prescribes the storage of a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/StorageProcess"></see></summary>
    let ``SupplyChain/StorageProcess`` = _prefix "SupplyChain/StorageProcess"
    /// <summary>
    /// Records the storage of a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/StorageAction"></see></summary>
    let ``SupplyChain/StorageAction`` = _prefix "SupplyChain/StorageAction"
    /// <summary>
    /// Process plans outline the stages of implementation or use related to a process.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/PlanProcess"></see></summary>
    let ``SupplyChain/PlanProcess`` = _prefix "SupplyChain/PlanProcess"
    /// <summary>
    /// Reproduction is the biological process by which organisms generate new individuals of the same species.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ReproduceAction"></see></summary>
    let ``SupplyChain/ReproduceAction`` = _prefix "SupplyChain/ReproduceAction"
    /// <summary>
    /// Reproduction is the biological process by which living organisms produce offspring.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ReproduceProcess"></see></summary>
    let ``SupplyChain/ReproduceProcess`` = _prefix "SupplyChain/ReproduceProcess"

    /// <summary>
    /// An action of crossing a boundary is defined in this class.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryCrossingAction"></see></summary>
    let ``SupplyChain/BoundaryCrossingAction`` =
        _prefix "SupplyChain/BoundaryCrossingAction"

    /// <summary>
    /// Inspection Process defines specific various processes needed to satisfy the inspection requirements for a specific product or service.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/InspectionProcess"></see></summary>
    let ``SupplyChain/InspectionProcess`` = _prefix "SupplyChain/InspectionProcess"

    /// <summary>
    /// Class that describes an InstantiateVirtualHardwareProcess that is used to define VirtualHardware and its source.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/InstantiateVirtualHardwareProcess"></see></summary>
    let ``SupplyChain/InstantiateVirtualHardwareProcess`` =
        _prefix "SupplyChain/InstantiateVirtualHardwareProcess"

    /// <summary>
    /// The AssemblyProcess represents the process of creating a product by assembling a set of components, potentially in a way that allows for at disassembly (at least partially).
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/AssemblyProcess"></see></summary>
    let ``SupplyChain/AssemblyProcess`` = _prefix "SupplyChain/AssemblyProcess"
    /// <summary>
    /// This class represents the process involved in manufacturing products.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ManufactureProcess"></see></summary>
    let ``SupplyChain/ManufactureProcess`` = _prefix "SupplyChain/ManufactureProcess"

    /// <summary>
    /// The boundary definition is used to define boundaries.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryDefinitionAction"></see></summary>
    let ``SupplyChain/BoundaryDefinitionAction`` =
        _prefix "SupplyChain/BoundaryDefinitionAction"

    /// <summary>
    /// An out of specification action is defined in this class.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/OutOfSpecAction"></see></summary>
    let ``SupplyChain/OutOfSpecAction`` = _prefix "SupplyChain/OutOfSpecAction"

    /// <summary>
    /// ResponsibilityChangeProcess refers to the process of transferring responsibility from one party to another.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityChangeProcess"></see></summary>
    let ``SupplyChain/ResponsibilityChangeProcess`` =
        _prefix "SupplyChain/ResponsibilityChangeProcess"

    /// <summary>
    /// Harvest is the process of extracting goods or products from nature.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/HarvestProcess"></see></summary>
    let ``SupplyChain/HarvestProcess`` = _prefix "SupplyChain/HarvestProcess"
    /// <summary>
    /// An inspection action refers to a specific activity or set of activities performed during an inspection to examine, verify, or evaluate an item, process, or system.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/InspectionAction"></see></summary>
    let ``SupplyChain/InspectionAction`` = _prefix "SupplyChain/InspectionAction"
    /// <summary>
    /// A prescribed change to a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ChangeProcess"></see></summary>
    let ``SupplyChain/ChangeProcess`` = _prefix "SupplyChain/ChangeProcess"
    /// <summary>
    /// ManufactureAction represents the act of creating a product by a manufacturing process.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ManufactureAction"></see></summary>
    let ``SupplyChain/ManufactureAction`` = _prefix "SupplyChain/ManufactureAction"
    /// <summary>
    /// An actual change to a product's location.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/TransportAction"></see></summary>
    let ``SupplyChain/TransportAction`` = _prefix "SupplyChain/TransportAction"
    /// <summary>
    /// HarvestAction represents the act of creating a product by directly extracting goods or materials from nature.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/HarvestAction"></see></summary>
    let ``SupplyChain/HarvestAction`` = _prefix "SupplyChain/HarvestAction"
    /// <summary>
    /// A test action is a specific action associated with a test.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/TestAction"></see></summary>
    let ``SupplyChain/TestAction`` = _prefix "SupplyChain/TestAction"
    /// <summary>
    /// Software provided as a service over a network.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/SoftwareService"></see></summary>
    let ``Service/SoftwareService`` = _prefix "Service/SoftwareService"
    /// <summary>
    /// Refers to any object that stores content on a computer.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/File"></see></summary>
    let ``Software/File`` = _prefix "Software/File"
    /// <summary>
    /// A collection of SPDX Elements describing a single package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/Sbom"></see></summary>
    let ``Software/Sbom`` = _prefix "Software/Sbom"
    /// <summary>
    /// Describes a certain part of a file.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/Snippet"></see></summary>
    let ``Software/Snippet`` = _prefix "Software/Snippet"
    /// <summary>
    /// A canonical, unique, immutable identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifier"></see></summary>
    let ``Software/ContentIdentifier`` = _prefix "Software/ContentIdentifier"
    /// <summary>
    /// Class that describes an instance of VirtualHardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardware"></see></summary>
    let ``Hardware/VirtualHardware`` = _prefix "Hardware/VirtualHardware"
    /// <summary>
    /// Dimensions generally refer to measurable extents or attributes that define the size, shape, or scale of an object, system, or concept.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/Dimensions"></see></summary>
    let ``Hardware/Dimensions`` = _prefix "Hardware/Dimensions"
    /// <summary>
    /// A product specification (product spec) is a detailed document that outlines the technical, functional, and design requirements of a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/ProductSpecification"></see></summary>
    let ``Hardware/ProductSpecification`` = _prefix "Hardware/ProductSpecification"
    /// <summary>
    /// Class that describes a physical instance of Hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/PhysicalHardware"></see></summary>
    let ``Hardware/PhysicalHardware`` = _prefix "Hardware/PhysicalHardware"
    /// <summary>
    /// Products or commodities produced as a bulk unit are called bulk products. Commodities are often sold in bulk.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/BulkHardware"></see></summary>
    let ``Hardware/BulkHardware`` = _prefix "Hardware/BulkHardware"
    /// <summary>
    /// Specifies an Extension characterization of some aspect of an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/extension"></see></summary>
    let ``Core/extension`` = _prefix "Core/extension"
    /// <summary>
    /// This property is used to denote the root Element(s) of a tree of elements contained in a BOM.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/rootElement"></see></summary>
    let ``Core/rootElement`` = _prefix "Core/rootElement"
    /// <summary>
    /// Refers to one or more Elements that are part of an ElementCollection.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/element"></see></summary>
    let ``Core/element`` = _prefix "Core/element"
    /// <summary>
    /// Enumeration of the valid profiles.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType"></see></summary>
    let ``Core/ProfileIdentifierType`` = _prefix "Core/ProfileIdentifierType"
    /// <summary>
    /// The element follows the Core profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/core"></see></summary>
    let ``Core/ProfileIdentifierType/core`` = _prefix "Core/ProfileIdentifierType/core"

    /// <summary>
    /// The element follows the Software profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/software"></see></summary>
    let ``Core/ProfileIdentifierType/software`` =
        _prefix "Core/ProfileIdentifierType/software"

    /// <summary>
    /// The element follows the SimpleLicensing profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/simpleLicensing"></see></summary>
    let ``Core/ProfileIdentifierType/simpleLicensing`` =
        _prefix "Core/ProfileIdentifierType/simpleLicensing"

    /// <summary>
    /// The element follows the ExpandedLicensing profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/expandedLicensing"></see></summary>
    let ``Core/ProfileIdentifierType/expandedLicensing`` =
        _prefix "Core/ProfileIdentifierType/expandedLicensing"

    /// <summary>
    /// The element follows the Security profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/security"></see></summary>
    let ``Core/ProfileIdentifierType/security`` =
        _prefix "Core/ProfileIdentifierType/security"

    /// <summary>
    /// The element follows the Build profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/build"></see></summary>
    let ``Core/ProfileIdentifierType/build`` =
        _prefix "Core/ProfileIdentifierType/build"

    /// <summary>
    /// The element follows the AI profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/ai"></see></summary>
    let ``Core/ProfileIdentifierType/ai`` = _prefix "Core/ProfileIdentifierType/ai"

    /// <summary>
    /// The element follows the Dataset profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/dataset"></see></summary>
    let ``Core/ProfileIdentifierType/dataset`` =
        _prefix "Core/ProfileIdentifierType/dataset"

    /// <summary>
    /// The element follows the Extension profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/extension"></see></summary>
    let ``Core/ProfileIdentifierType/extension`` =
        _prefix "Core/ProfileIdentifierType/extension"

    /// <summary>
    /// The element follows the Lite profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/lite"></see></summary>
    let ``Core/ProfileIdentifierType/lite`` = _prefix "Core/ProfileIdentifierType/lite"

    /// <summary>
    /// The element follows the Hardware profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/hardware"></see></summary>
    let ``Core/ProfileIdentifierType/hardware`` =
        _prefix "Core/ProfileIdentifierType/hardware"

    /// <summary>
    /// The element follows the SupplyChain profile specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/supplyChain"></see></summary>
    let ``Core/ProfileIdentifierType/supplyChain`` =
        _prefix "Core/ProfileIdentifierType/supplyChain"

    /// <summary>
    /// Describes one a profile which the creator of this ElementCollection intends to
    /// conform to.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/profileConformance"></see></summary>
    let ``Core/profileConformance`` = _prefix "Core/profileConformance"
    /// <summary>
    /// A value used in a key-value pair with a generic key that refers to an Element
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/elementValue"></see></summary>
    let ``Core/elementValue`` = _prefix "Core/elementValue"
    /// <summary>
    /// Provides the location for more information regarding an external identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/identifierLocator"></see></summary>
    let ``Core/identifierLocator`` = _prefix "Core/identifierLocator"
    /// <summary>
    /// Specifies the type of an external identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType"></see></summary>
    let ``Core/ExternalIdentifierType`` = _prefix "Core/ExternalIdentifierType"

    /// <summary>
    /// [Common Platform Enumeration Specification 2.2](https://cpe.mitre.org/files/cpe-specification_2.2.pdf).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cpe22"></see></summary>
    let ``Core/ExternalIdentifierType/cpe22`` =
        _prefix "Core/ExternalIdentifierType/cpe22"

    /// <summary>
    /// [Common Platform Enumeration: Naming Specification Version 2.3](https://csrc.nist.gov/publications/detail/nistir/7695/final).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cpe23"></see></summary>
    let ``Core/ExternalIdentifierType/cpe23`` =
        _prefix "Core/ExternalIdentifierType/cpe23"

    /// <summary>
    /// Common Vulnerabilities and Exposures identifiers, an identifier for a specific software flaw defined within the official CVE Dictionary and that conforms to the [CVE specification](https://csrc.nist.gov/glossary/term/cve_id).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cve"></see></summary>
    let ``Core/ExternalIdentifierType/cve`` = _prefix "Core/ExternalIdentifierType/cve"

    /// <summary>
    /// [Data Universal Numbering System (D-U-N-S) Number](https://www.dnb.com/en-us/smb/duns.html) is a unique nine-digit identifier, issued by Dun &amp; Bradstreet, that identifies a business entity, often on a location-specific basis.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/duns"></see></summary>
    let ``Core/ExternalIdentifierType/duns`` =
        _prefix "Core/ExternalIdentifierType/duns"

    /// <summary>
    /// Email address, as defined in [RFC 3696](https://datatracker.ietf.org/doc/rfc3696/) Section 3.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/email"></see></summary>
    let ``Core/ExternalIdentifierType/email`` =
        _prefix "Core/ExternalIdentifierType/email"

    /// <summary>
    /// The UUID used by a reporting management system or any other lifecycle management tool to uniquely identify an evidence relationship item. UUID, or universally unique ID, is a standard term to refer to evidence items.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/evidenceUUID"></see></summary>
    let ``Core/ExternalIdentifierType/evidenceUUID`` =
        _prefix "Core/ExternalIdentifierType/evidenceUUID"

    /// <summary>
    /// [Gitoid](https://www.iana.org/assignments/uri-schemes/prov/gitoid), stands for [Git Object ID](https://git-scm.com/book/en/v2/Git-Internals-Git-Objects). A gitoid of type blob is a unique hash of a binary artifact. A gitoid may represent either an [Artifact Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-identifier-types) for the software artifact or an [Input Manifest Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#input-manifest-identifier) for the software artifact's associated [Artifact Input Manifest](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-input-manifest); this ambiguity exists because the Artifact Input Manifest is itself an artifact, and the gitoid of that artifact is its valid identifier. Gitoids calculated on software artifacts (Snippet, File, or Package Elements) should be recorded in the SPDX 3 SoftwareArtifact's contentIdentifier property. Gitoids calculated on the Artifact Input Manifest (Input Manifest Identifier) should be recorded in the SPDX 3 Element's externalIdentifier property. See [OmniBOR Specification](https://github.com/omnibor/spec/), a minimalistic specification for describing software [Artifact Dependency Graphs](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-dependency-graph-adg).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gitoid"></see></summary>
    let ``Core/ExternalIdentifierType/gitoid`` =
        _prefix "Core/ExternalIdentifierType/gitoid"

    /// <summary>
    /// [Global Location Number (GLN)](https://www.gs1.org/standards/id-keys/gln) is a 13-digit number, assigned by GS1, that uniquely identifies a legal entity (e.g., a company or customer), a function within a legal entity, a physical location (e.g., a warehouse or a specific shelf in a store), or a digital location (e.g., an Electronic Data Interchange (EDI) gateway).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gln"></see></summary>
    let ``Core/ExternalIdentifierType/gln`` = _prefix "Core/ExternalIdentifierType/gln"

    /// <summary>
    /// [GLobal Unique Enterprise (GLUE) Identifiers](https://datatracker.ietf.org/doc/draft-ietf-spice-glue-id/), as defined by the IETF Internet-Draft, is expressed as a GLUE URI, a Uniform Resource Identifier that standardizes the representation of existing organizational entity identifiers.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/glue"></see></summary>
    let ``Core/ExternalIdentifierType/glue`` =
        _prefix "Core/ExternalIdentifierType/glue"

    /// <summary>
    /// [Global Trade Item Number (GTIN)](https://www.gs1.org/standards/id-keys/gtin) is a number, assigned by GS1, that uniquely identifies a trade item (product or service).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gtin"></see></summary>
    let ``Core/ExternalIdentifierType/gtin`` =
        _prefix "Core/ExternalIdentifierType/gtin"

    /// <summary>
    /// The [Harmonized System (HS)](https://www.wcoomd.org/en/topics/nomenclature/overview/what-is-the-harmonized-system.aspx) of tariff nomenclature is an internationally standardized system of names and numbers, defined by the World Customs Organization, used to classify traded products.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/hsCodes"></see></summary>
    let ``Core/ExternalIdentifierType/hsCodes`` =
        _prefix "Core/ExternalIdentifierType/hsCodes"

    /// <summary>
    /// The [Legal Entity Identifier (LEI)](https://www.gleif.org/en/organizational-identity/introducing-the-legal-entity-identifier-lei) is a 20-character, alphanumeric code based on the [ISO 17442](https://www.iso.org/standard/78829.html) standard developed by the International Organization for Standardization.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/lei"></see></summary>
    let ``Core/ExternalIdentifierType/lei`` = _prefix "Core/ExternalIdentifierType/lei"

    /// <summary>
    /// Used when the type does not match any of the other options.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/other"></see></summary>
    let ``Core/ExternalIdentifierType/other`` =
        _prefix "Core/ExternalIdentifierType/other"

    /// <summary>
    /// Package URL, as defined in the corresponding [Annex](../../../annexes/pkg-url-specification.md) of this document.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/packageUrl"></see></summary>
    let ``Core/ExternalIdentifierType/packageUrl`` =
        _prefix "Core/ExternalIdentifierType/packageUrl"

    /// <summary>
    /// Phone number; A string of decimal digits that uniquely indicates the network termination point defined in [RFC 3966](https://datatracker.ietf.org/doc/rfc3966/) Section 5.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/phoneNumber"></see></summary>
    let ``Core/ExternalIdentifierType/phoneNumber`` =
        _prefix "Core/ExternalIdentifierType/phoneNumber"

    /// <summary>
    /// The UUID used by a requirements management or any other lifecycle management tool to uniquely identify a requirement item. UUID, or universally unique ID, is a standard term in requirements engineering.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/requirementUUID"></see></summary>
    let ``Core/ExternalIdentifierType/requirementUUID`` =
        _prefix "Core/ExternalIdentifierType/requirementUUID"

    /// <summary>
    /// Used when there is a security related identifier of unspecified type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/securityOther"></see></summary>
    let ``Core/ExternalIdentifierType/securityOther`` =
        _prefix "Core/ExternalIdentifierType/securityOther"

    /// <summary>
    /// SoftWare Hash IDentifier, a persistent intrinsic identifier for digital artifacts, such as files, trees (also known as directories or folders), commits, and other objects typically found in version control systems. The format of the identifiers is defined in the [SWHID specification](https://www.swhid.org/swhid-specification/v1.2/) ([ISO/IEC 18670](https://www.iso.org/standard/89985.html)). They typically look like `swh:1:cnt:94a9ed024d3859793618152ea559a168bbcbb5e2`.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/swhid"></see></summary>
    let ``Core/ExternalIdentifierType/swhid`` =
        _prefix "Core/ExternalIdentifierType/swhid"

    /// <summary>
    /// Concise Software Identification (CoSWID) tag, as defined in [RFC 9393](https://datatracker.ietf.org/doc/rfc9393/) Section 2.3.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/swid"></see></summary>
    let ``Core/ExternalIdentifierType/swid`` =
        _prefix "Core/ExternalIdentifierType/swid"

    /// <summary>
    /// [Uniform Resource Identifier (URI) Schemes](https://www.iana.org/assignments/uri-schemes/uri-schemes.xhtml). The scheme used in order to locate a resource.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/urlScheme"></see></summary>
    let ``Core/ExternalIdentifierType/urlScheme`` =
        _prefix "Core/ExternalIdentifierType/urlScheme"

    /// <summary>
    /// The UUID used by a verification management system or any other lifecycle management tool to uniquely identify a verification item. UUID, or universally unique ID, is a standard term to refer to verification items.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/verificationUUID"></see></summary>
    let ``Core/ExternalIdentifierType/verificationUUID`` =
        _prefix "Core/ExternalIdentifierType/verificationUUID"

    /// <summary>
    /// Absolute URL that can be used to locate a resource, as defined in [RFC 7230](https://datatracker.ietf.org/doc/rfc7230/) Section 2.7.1 or Section 2.7.2.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/webpage"></see></summary>
    let ``Core/ExternalIdentifierType/webpage`` =
        _prefix "Core/ExternalIdentifierType/webpage"

    /// <summary>
    /// Specifies the type of the external identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/externalIdentifierType"></see></summary>
    let ``Core/externalIdentifierType`` = _prefix "Core/externalIdentifierType"
    /// <summary>
    /// Uniquely identifies an external element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/identifier"></see></summary>
    let ``Core/identifier`` = _prefix "Core/identifier"
    /// <summary>
    /// An entity that is authorized to issue identification credentials.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/issuingAuthority"></see></summary>
    let ``Core/issuingAuthority`` = _prefix "Core/issuingAuthority"
    /// <summary>
    /// Identifies an external Element used within an SpdxDocument but defined
    /// external to that SpdxDocument.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/externalSpdxId"></see></summary>
    let ``Core/externalSpdxId`` = _prefix "Core/externalSpdxId"
    /// <summary>
    /// Provides an indication of where to retrieve an external Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/locationHint"></see></summary>
    let ``Core/locationHint`` = _prefix "Core/locationHint"
    /// <summary>
    /// Artifact representing a serialization instance of SPDX data containing the
    /// definition of a particular Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/definingArtifact"></see></summary>
    let ``Core/definingArtifact`` = _prefix "Core/definingArtifact"
    /// <summary>
    /// Specifies the type of an external reference.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType"></see></summary>
    let ``Core/ExternalRefType`` = _prefix "Core/ExternalRefType"

    /// <summary>
    /// A reference to an alternative download location.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/altDownloadLocation"></see></summary>
    let ``Core/ExternalRefType/altDownloadLocation`` =
        _prefix "Core/ExternalRefType/altDownloadLocation"

    /// <summary>
    /// A reference to an alternative web page.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/altWebPage"></see></summary>
    let ``Core/ExternalRefType/altWebPage`` = _prefix "Core/ExternalRefType/altWebPage"

    /// <summary>
    /// A reference to binary artifacts related to a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/binaryArtifact"></see></summary>
    let ``Core/ExternalRefType/binaryArtifact`` =
        _prefix "Core/ExternalRefType/binaryArtifact"

    /// <summary>
    /// A reference to a Bower package. The package locator format, looks like `package#version`, is defined in the "install" section of [Bower API documentation](https://bower.io/docs/api/#install).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/bower"></see></summary>
    let ``Core/ExternalRefType/bower`` = _prefix "Core/ExternalRefType/bower"
    /// <summary>
    /// A reference build metadata related to a published package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/buildMeta"></see></summary>
    let ``Core/ExternalRefType/buildMeta`` = _prefix "Core/ExternalRefType/buildMeta"

    /// <summary>
    /// A reference build system used to create or publish the package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/buildSystem"></see></summary>
    let ``Core/ExternalRefType/buildSystem`` =
        _prefix "Core/ExternalRefType/buildSystem"

    /// <summary>
    /// A reference to the instant messaging system used by the maintainer for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/chat"></see></summary>
    let ``Core/ExternalRefType/chat`` = _prefix "Core/ExternalRefType/chat"

    /// <summary>
    /// A reference to a certification report for a package from an accredited/independent body.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/certificationReport"></see></summary>
    let ``Core/ExternalRefType/certificationReport`` =
        _prefix "Core/ExternalRefType/certificationReport"

    /// <summary>
    /// A reference to a Software Composition Analysis (SCA) report.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/componentAnalysisReport"></see></summary>
    let ``Core/ExternalRefType/componentAnalysisReport`` =
        _prefix "Core/ExternalRefType/componentAnalysisReport"

    /// <summary>
    /// [Common Weakness Enumeration](https://csrc.nist.gov/glossary/term/common_weakness_enumeration). A reference to a source of software flaw defined within the official [CWE List](https://cwe.mitre.org/data/) that conforms to the [CWE specification](https://cwe.mitre.org/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/cwe"></see></summary>
    let ``Core/ExternalRefType/cwe`` = _prefix "Core/ExternalRefType/cwe"

    /// <summary>
    /// A reference to the documentation for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/documentation"></see></summary>
    let ``Core/ExternalRefType/documentation`` =
        _prefix "Core/ExternalRefType/documentation"

    /// <summary>
    /// A reference to a dynamic analysis report for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/dynamicAnalysisReport"></see></summary>
    let ``Core/ExternalRefType/dynamicAnalysisReport`` =
        _prefix "Core/ExternalRefType/dynamicAnalysisReport"

    /// <summary>
    /// A reference to the End Of Sale (EOS) and/or End Of Life (EOL) information related to a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/eolNotice"></see></summary>
    let ``Core/ExternalRefType/eolNotice`` = _prefix "Core/ExternalRefType/eolNotice"

    /// <summary>
    /// A reference to an export control assessment for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/exportControlAssessment"></see></summary>
    let ``Core/ExternalRefType/exportControlAssessment`` =
        _prefix "Core/ExternalRefType/exportControlAssessment"

    /// <summary>
    /// A reference to funding information related to a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/funding"></see></summary>
    let ``Core/ExternalRefType/funding`` = _prefix "Core/ExternalRefType/funding"

    /// <summary>
    /// A reference to the issue tracker for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/issueTracker"></see></summary>
    let ``Core/ExternalRefType/issueTracker`` =
        _prefix "Core/ExternalRefType/issueTracker"

    /// <summary>
    /// A reference to the mailing list used by the maintainer for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/mailingList"></see></summary>
    let ``Core/ExternalRefType/mailingList`` =
        _prefix "Core/ExternalRefType/mailingList"

    /// <summary>
    /// A reference to a Maven repository artifact. The artifact locator format is defined in the [Maven documentation](https://maven.apache.org/guides/mini/guide-naming-conventions.html) and looks like `groupId:artifactId[:version]`.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/mavenCentral"></see></summary>
    let ``Core/ExternalRefType/mavenCentral`` =
        _prefix "Core/ExternalRefType/mavenCentral"

    /// <summary>
    /// A reference to metrics related to package such as OpenSSF scorecards.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/metrics"></see></summary>
    let ``Core/ExternalRefType/metrics`` = _prefix "Core/ExternalRefType/metrics"
    /// <summary>
    /// A reference to an npm package. The package locator format is defined in the [npm documentation](https://docs.npmjs.com/cli/v10/configuring-npm/package-json) and looks like `package@version`.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/npm"></see></summary>
    let ``Core/ExternalRefType/npm`` = _prefix "Core/ExternalRefType/npm"
    /// <summary>
    /// A reference to a NuGet package. The package locator format is defined in the [NuGet documentation](https://docs.nuget.org) and looks like `package/version`.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/nuget"></see></summary>
    let ``Core/ExternalRefType/nuget`` = _prefix "Core/ExternalRefType/nuget"
    /// <summary>
    /// A reference to additional license information related to an artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/license"></see></summary>
    let ``Core/ExternalRefType/license`` = _prefix "Core/ExternalRefType/license"
    /// <summary>
    /// Used when the type does not match any of the other options.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/other"></see></summary>
    let ``Core/ExternalRefType/other`` = _prefix "Core/ExternalRefType/other"

    /// <summary>
    /// A reference to a privacy assessment for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/privacyAssessment"></see></summary>
    let ``Core/ExternalRefType/privacyAssessment`` =
        _prefix "Core/ExternalRefType/privacyAssessment"

    /// <summary>
    /// A reference to additional product metadata such as reference within organization's product catalog.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/productMetadata"></see></summary>
    let ``Core/ExternalRefType/productMetadata`` =
        _prefix "Core/ExternalRefType/productMetadata"

    /// <summary>
    /// A reference to a purchase order for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/purchaseOrder"></see></summary>
    let ``Core/ExternalRefType/purchaseOrder`` =
        _prefix "Core/ExternalRefType/purchaseOrder"

    /// <summary>
    /// A reference to a quality assessment for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/qualityAssessmentReport"></see></summary>
    let ``Core/ExternalRefType/qualityAssessmentReport`` =
        _prefix "Core/ExternalRefType/qualityAssessmentReport"

    /// <summary>
    /// A reference to the release notes for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/releaseNotes"></see></summary>
    let ``Core/ExternalRefType/releaseNotes`` =
        _prefix "Core/ExternalRefType/releaseNotes"

    /// <summary>
    /// A reference to a published list of releases for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/releaseHistory"></see></summary>
    let ``Core/ExternalRefType/releaseHistory`` =
        _prefix "Core/ExternalRefType/releaseHistory"

    /// <summary>
    /// A reference to a risk assessment for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/riskAssessment"></see></summary>
    let ``Core/ExternalRefType/riskAssessment`` =
        _prefix "Core/ExternalRefType/riskAssessment"

    /// <summary>
    /// A reference to a runtime analysis report for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/runtimeAnalysisReport"></see></summary>
    let ``Core/ExternalRefType/runtimeAnalysisReport`` =
        _prefix "Core/ExternalRefType/runtimeAnalysisReport"

    /// <summary>
    /// A reference to information assuring that the software is developed using security practices as defined by [NIST SP 800-218 Secure Software Development Framework (SSDF) Version 1.1](https://csrc.nist.gov/pubs/sp/800/218/final) or [CISA Secure Software Development Attestation Form](https://www.cisa.gov/resources-tools/resources/secure-software-development-attestation-form).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/secureSoftwareAttestation"></see></summary>
    let ``Core/ExternalRefType/secureSoftwareAttestation`` =
        _prefix "Core/ExternalRefType/secureSoftwareAttestation"

    /// <summary>
    /// A reference to a published security advisory (where advisory as defined per [ISO 29147:2018](https://www.iso.org/standard/72311.html)) that may affect one or more elements, e.g., vendor advisories or specific NVD entries.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityAdvisory"></see></summary>
    let ``Core/ExternalRefType/securityAdvisory`` =
        _prefix "Core/ExternalRefType/securityAdvisory"

    /// <summary>
    /// A reference to the security adversary model for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityAdversaryModel"></see></summary>
    let ``Core/ExternalRefType/securityAdversaryModel`` =
        _prefix "Core/ExternalRefType/securityAdversaryModel"

    /// <summary>
    /// A reference to the patch or source code that fixes a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityFix"></see></summary>
    let ``Core/ExternalRefType/securityFix`` =
        _prefix "Core/ExternalRefType/securityFix"

    /// <summary>
    /// A reference to related security information of unspecified type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityOther"></see></summary>
    let ``Core/ExternalRefType/securityOther`` =
        _prefix "Core/ExternalRefType/securityOther"

    /// <summary>
    /// A reference to a [penetration test](https://en.wikipedia.org/wiki/Penetration_test) report for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityPenTestReport"></see></summary>
    let ``Core/ExternalRefType/securityPenTestReport`` =
        _prefix "Core/ExternalRefType/securityPenTestReport"

    /// <summary>
    /// A reference to instructions for reporting newly discovered security vulnerabilities for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityPolicy"></see></summary>
    let ``Core/ExternalRefType/securityPolicy`` =
        _prefix "Core/ExternalRefType/securityPolicy"

    /// <summary>
    /// A reference the [security threat model](https://en.wikipedia.org/wiki/Threat_model) for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityThreatModel"></see></summary>
    let ``Core/ExternalRefType/securityThreatModel`` =
        _prefix "Core/ExternalRefType/securityThreatModel"

    /// <summary>
    /// A reference to a social media channel for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/socialMedia"></see></summary>
    let ``Core/ExternalRefType/socialMedia`` =
        _prefix "Core/ExternalRefType/socialMedia"

    /// <summary>
    /// A reference to an artifact containing the sources for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/sourceArtifact"></see></summary>
    let ``Core/ExternalRefType/sourceArtifact`` =
        _prefix "Core/ExternalRefType/sourceArtifact"

    /// <summary>
    /// A reference to a static analysis report for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/staticAnalysisReport"></see></summary>
    let ``Core/ExternalRefType/staticAnalysisReport`` =
        _prefix "Core/ExternalRefType/staticAnalysisReport"

    /// <summary>
    /// A reference to the software support channel or other support information for a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/support"></see></summary>
    let ``Core/ExternalRefType/support`` = _prefix "Core/ExternalRefType/support"
    /// <summary>
    /// A reference to a version control system related to a software artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vcs"></see></summary>
    let ``Core/ExternalRefType/vcs`` = _prefix "Core/ExternalRefType/vcs"

    /// <summary>
    /// A reference to a Vulnerability Disclosure Report (VDR) which provides the software supplier's analysis and findings describing the impact (or lack of impact) that reported vulnerabilities have on packages or products in the supplier's SBOM as defined in [NIST SP 800-161 Cybersecurity Supply Chain Risk Management Practices for Systems and Organizations](https://csrc.nist.gov/pubs/sp/800/161/r1/final).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vulnerabilityDisclosureReport"></see></summary>
    let ``Core/ExternalRefType/vulnerabilityDisclosureReport`` =
        _prefix "Core/ExternalRefType/vulnerabilityDisclosureReport"

    /// <summary>
    /// A reference to a Vulnerability Exploitability eXchange (VEX) statement which provides information on whether a product is impacted by a specific vulnerability in an included package and, if affected, whether there are actions recommended to remediate. See also [NTIA VEX one-page summary](https://ntia.gov/files/ntia/publications/vex_one-page_summary.pdf).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vulnerabilityExploitabilityAssessment"></see></summary>
    let ``Core/ExternalRefType/vulnerabilityExploitabilityAssessment`` =
        _prefix "Core/ExternalRefType/vulnerabilityExploitabilityAssessment"

    /// <summary>
    /// A reference to an X.509 certificate as defined in [RFC 1422](https://datatracker.ietf.org/doc/rfc1422/). The media type shall be one of application/x-x509-ca-cert or application/x-x509-user-cert.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/x509Cert"></see></summary>
    let ``Core/ExternalRefType/x509Cert`` = _prefix "Core/ExternalRefType/x509Cert"
    /// <summary>
    /// Specifies the type of the external reference.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/externalRefType"></see></summary>
    let ``Core/externalRefType`` = _prefix "Core/externalRefType"
    /// <summary>
    /// Provides the location of an external reference.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/locator"></see></summary>
    let ``Core/locator`` = _prefix "Core/locator"
    /// <summary>
    /// A mathematical algorithm that maps data of arbitrary size to a bit string.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm"></see></summary>
    let ``Core/HashAlgorithm`` = _prefix "Core/HashAlgorithm"
    /// <summary>
    /// Adler-32 checksum is part of the widely used zlib compression library as defined in [RFC 1950](https://datatracker.ietf.org/doc/rfc1950/) Section 2.3.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/adler32"></see></summary>
    let ``Core/HashAlgorithm/adler32`` = _prefix "Core/HashAlgorithm/adler32"
    /// <summary>
    /// BLAKE2b algorithm with a digest size of 256, as defined in [RFC 7693](https://datatracker.ietf.org/doc/rfc7693/) Section 4.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b256"></see></summary>
    let ``Core/HashAlgorithm/blake2b256`` = _prefix "Core/HashAlgorithm/blake2b256"
    /// <summary>
    /// BLAKE2b algorithm with a digest size of 384, as defined in [RFC 7693](https://datatracker.ietf.org/doc/rfc7693/) Section 4.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b384"></see></summary>
    let ``Core/HashAlgorithm/blake2b384`` = _prefix "Core/HashAlgorithm/blake2b384"
    /// <summary>
    /// BLAKE2b algorithm with a digest size of 512, as defined in [RFC 7693](https://datatracker.ietf.org/doc/rfc7693/) Section 4.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b512"></see></summary>
    let ``Core/HashAlgorithm/blake2b512`` = _prefix "Core/HashAlgorithm/blake2b512"
    /// <summary>
    /// [BLAKE3](https://github.com/BLAKE3-team/BLAKE3-specs/blob/master/blake3.pdf)
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake3"></see></summary>
    let ``Core/HashAlgorithm/blake3`` = _prefix "Core/HashAlgorithm/blake3"

    /// <summary>
    /// [Dilithium](https://pq-crystals.org/dilithium/)
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/crystalsDilithium"></see></summary>
    let ``Core/HashAlgorithm/crystalsDilithium`` =
        _prefix "Core/HashAlgorithm/crystalsDilithium"

    /// <summary>
    /// [Kyber](https://pq-crystals.org/kyber/)
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/crystalsKyber"></see></summary>
    let ``Core/HashAlgorithm/crystalsKyber`` =
        _prefix "Core/HashAlgorithm/crystalsKyber"

    /// <summary>
    /// [FALCON](https://falcon-sign.info/falcon.pdf)
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/falcon"></see></summary>
    let ``Core/HashAlgorithm/falcon`` = _prefix "Core/HashAlgorithm/falcon"
    /// <summary>
    /// MD2 message-digest algorithm, as defined in [RFC 1319](https://datatracker.ietf.org/doc/rfc1319/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md2"></see></summary>
    let ``Core/HashAlgorithm/md2`` = _prefix "Core/HashAlgorithm/md2"
    /// <summary>
    /// MD4 message-digest algorithm, as defined in [RFC 1186](https://datatracker.ietf.org/doc/rfc1186/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md4"></see></summary>
    let ``Core/HashAlgorithm/md4`` = _prefix "Core/HashAlgorithm/md4"
    /// <summary>
    /// MD5 message-digest algorithm, as defined in [RFC 1321](https://datatracker.ietf.org/doc/rfc1321/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md5"></see></summary>
    let ``Core/HashAlgorithm/md5`` = _prefix "Core/HashAlgorithm/md5"
    /// <summary>
    /// [MD6 hash function](https://people.csail.mit.edu/rivest/pubs/RABCx08.pdf)
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md6"></see></summary>
    let ``Core/HashAlgorithm/md6`` = _prefix "Core/HashAlgorithm/md6"
    /// <summary>
    /// any hashing algorithm that does not exist in this list of entries
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/other"></see></summary>
    let ``Core/HashAlgorithm/other`` = _prefix "Core/HashAlgorithm/other"
    /// <summary>
    /// SHA-1, a secure hashing algorithm, as defined in [RFC 3174](https://datatracker.ietf.org/doc/rfc3174/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha1"></see></summary>
    let ``Core/HashAlgorithm/sha1`` = _prefix "Core/HashAlgorithm/sha1"
    /// <summary>
    /// SHA-2 with a digest length of 224, as defined in [RFC 3874](https://datatracker.ietf.org/doc/rfc3874/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha224"></see></summary>
    let ``Core/HashAlgorithm/sha224`` = _prefix "Core/HashAlgorithm/sha224"
    /// <summary>
    /// SHA-2 with a digest length of 256, as defined in [RFC 6234](https://datatracker.ietf.org/doc/rfc6234/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha256"></see></summary>
    let ``Core/HashAlgorithm/sha256`` = _prefix "Core/HashAlgorithm/sha256"
    /// <summary>
    /// SHA-2 with a digest length of 384, as defined in [RFC 6234](https://datatracker.ietf.org/doc/rfc6234/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha384"></see></summary>
    let ``Core/HashAlgorithm/sha384`` = _prefix "Core/HashAlgorithm/sha384"
    /// <summary>
    /// SHA-2 with a digest length of 512, as defined in [RFC 6234](https://datatracker.ietf.org/doc/rfc6234/).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha512"></see></summary>
    let ``Core/HashAlgorithm/sha512`` = _prefix "Core/HashAlgorithm/sha512"
    /// <summary>
    /// SHA-3 with a digest length of 224, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_224"></see></summary>
    let ``Core/HashAlgorithm/sha3_224`` = _prefix "Core/HashAlgorithm/sha3_224"
    /// <summary>
    /// SHA-3 with a digest length of 256, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_256"></see></summary>
    let ``Core/HashAlgorithm/sha3_256`` = _prefix "Core/HashAlgorithm/sha3_256"
    /// <summary>
    /// SHA-3 with a digest length of 384, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_384"></see></summary>
    let ``Core/HashAlgorithm/sha3_384`` = _prefix "Core/HashAlgorithm/sha3_384"
    /// <summary>
    /// SHA-3 with a digest length of 512, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_512"></see></summary>
    let ``Core/HashAlgorithm/sha3_512`` = _prefix "Core/HashAlgorithm/sha3_512"
    /// <summary>
    /// Specifies the algorithm used for calculating the hash value.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/algorithm"></see></summary>
    let ``Core/algorithm`` = _prefix "Core/algorithm"
    /// <summary>
    /// The result of applying a hash algorithm to an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/hashValue"></see></summary>
    let ``Core/hashValue`` = _prefix "Core/hashValue"
    /// <summary>
    /// Provide an enumerated set of lifecycle phases that can provide context to relationships.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType"></see></summary>
    let ``Core/LifecycleScopeType`` = _prefix "Core/LifecycleScopeType"
    /// <summary>
    /// A relationship has specific context implications during an element's build phase, during development.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/build"></see></summary>
    let ``Core/LifecycleScopeType/build`` = _prefix "Core/LifecycleScopeType/build"

    /// <summary>
    /// A relationship has specific context implications for a product's retirement and/or decommissioning.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/decommission"></see></summary>
    let ``Core/LifecycleScopeType/decommission`` =
        _prefix "Core/LifecycleScopeType/decommission"

    /// <summary>
    /// A relationship has specific context implications during an element's design.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/design"></see></summary>
    let ``Core/LifecycleScopeType/design`` = _prefix "Core/LifecycleScopeType/design"

    /// <summary>
    /// A relationship has specific context implications during development phase of an element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/development"></see></summary>
    let ``Core/LifecycleScopeType/development`` =
        _prefix "Core/LifecycleScopeType/development"

    /// <summary>
    /// A relationship has other specific context information necessary to capture that the above set of enumerations does not handle.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/other"></see></summary>
    let ``Core/LifecycleScopeType/other`` = _prefix "Core/LifecycleScopeType/other"
    /// <summary>
    /// A relationship has specific context implications during the execution phase of an element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/runtime"></see></summary>
    let ``Core/LifecycleScopeType/runtime`` = _prefix "Core/LifecycleScopeType/runtime"
    /// <summary>
    /// A relationship has specific context implications during an element's testing phase, during development.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/test"></see></summary>
    let ``Core/LifecycleScopeType/test`` = _prefix "Core/LifecycleScopeType/test"
    /// <summary>
    /// A relationship has specific context implications for a product update.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/update"></see></summary>
    let ``Core/LifecycleScopeType/update`` = _prefix "Core/LifecycleScopeType/update"
    /// <summary>
    /// Capture the scope of information about a specific relationship between elements.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/scope"></see></summary>
    let ``Core/scope`` = _prefix "Core/scope"
    /// <summary>
    /// A known location is specified at this time.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/locationTime"></see></summary>
    let ``Core/locationTime`` = _prefix "Core/locationTime"
    /// <summary>
    /// A substitute for a URI.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/prefix"></see></summary>
    let ``Core/prefix`` = _prefix "Core/prefix"
    /// <summary>
    /// Provides an unambiguous mechanism for conveying a URI fragment portion of an
    /// Element ID.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/namespace"></see></summary>
    let ``Core/namespace`` = _prefix "Core/namespace"
    /// <summary>
    /// An Individual Value for Element representing a set of Elements of unknown
    /// identity or cardinality (number).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/NoAssertionElement"></see></summary>
    let ``Core/NoAssertionElement`` = _prefix "Core/NoAssertionElement"
    /// <summary>
    /// An Individual Value for Element representing a set of Elements with
    /// cardinality (number/count) of zero.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/NoneElement"></see></summary>
    let ``Core/NoneElement`` = _prefix "Core/NoneElement"
    /// <summary>
    /// The headquartersLocation defines the location of the organization's headquarters.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/headquartersLocation"></see></summary>
    let ``Core/headquartersLocation`` = _prefix "Core/headquartersLocation"

    /// <summary>
    /// The relative file name of a file to be excluded from the
    /// `PackageVerificationCode`.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/packageVerificationCodeExcludedFile"></see></summary>
    let ``Core/packageVerificationCodeExcludedFile`` =
        _prefix "Core/packageVerificationCodeExcludedFile"

    /// <summary>
    /// City is a specific name used to define a locality.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/city"></see></summary>
    let ``Core/city`` = _prefix "Core/city"
    /// <summary>
    /// A code that identifies a county.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/countyCode"></see></summary>
    let ``Core/countyCode`` = _prefix "Core/countyCode"
    /// <summary>
    /// The name of the recipient expressed in text.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/postalName"></see></summary>
    let ``Core/postalName`` = _prefix "Core/postalName"
    /// <summary>
    /// Text specifying a province or state.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/provinceStateCode"></see></summary>
    let ``Core/provinceStateCode`` = _prefix "Core/provinceStateCode"
    /// <summary>
    /// This is a set of point coordinates as defined in by the GPS standard.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/geographicPointLocation"></see></summary>
    let ``Core/geographicPointLocation`` = _prefix "Core/geographicPointLocation"
    /// <summary>
    /// Specifies a country code of the location.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/country"></see></summary>
    let ``Core/country`` = _prefix "Core/country"
    /// <summary>
    /// The number that identifies a PO box. A PO box is a box in a post office or other postal service location assigned to an organization where postal items may be kept.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/postOfficeBoxNumber"></see></summary>
    let ``Core/postOfficeBoxNumber`` = _prefix "Core/postOfficeBoxNumber"
    /// <summary>
    /// Street address includes a street number, name and unit ID to identify a specific street.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/streetAddress"></see></summary>
    let ``Core/streetAddress`` = _prefix "Core/streetAddress"
    /// <summary>
    /// Text specifying the postal code for an address.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/postalCode"></see></summary>
    let ``Core/postalCode`` = _prefix "Core/postalCode"
    /// <summary>
    /// Defines the end of a range.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/endIntegerRange"></see></summary>
    let ``Core/endIntegerRange`` = _prefix "Core/endIntegerRange"
    /// <summary>
    /// Defines the beginning of a range.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/beginIntegerRange"></see></summary>
    let ``Core/beginIntegerRange`` = _prefix "Core/beginIntegerRange"
    /// <summary>
    /// Specifies the time from which an element is no longer applicable / valid.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/endTime"></see></summary>
    let ``Core/endTime`` = _prefix "Core/endTime"
    /// <summary>
    /// References the Element on the left-hand side of a relationship.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/from"></see></summary>
    let ``Core/from`` = _prefix "Core/from"
    /// <summary>
    /// References an Element on the right-hand side of a relationship.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/to"></see></summary>
    let ``Core/to`` = _prefix "Core/to"
    /// <summary>
    /// Information about the relationship between two Elements.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType"></see></summary>
    let ``Core/RelationshipType`` = _prefix "Core/RelationshipType"
    /// <summary>
    /// The `from` Vulnerability, Action or DefinedProcess affects each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/affects"></see></summary>
    let ``Core/RelationshipType/affects`` = _prefix "Core/RelationshipType/affects"
    /// <summary>
    /// The `from` Element is amended by each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/amendedBy"></see></summary>
    let ``Core/RelationshipType/amendedBy`` = _prefix "Core/RelationshipType/amendedBy"

    /// <summary>
    /// The `from` Element is an ancestor of each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/ancestorOf"></see></summary>
    let ``Core/RelationshipType/ancestorOf`` =
        _prefix "Core/RelationshipType/ancestorOf"

    /// <summary>
    /// The `from` Element is available from the additional supplier described by each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/availableFrom"></see></summary>
    let ``Core/RelationshipType/availableFrom`` =
        _prefix "Core/RelationshipType/availableFrom"

    /// <summary>
    /// The `from` Element is a configuration applied to each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/configures"></see></summary>
    let ``Core/RelationshipType/configures`` =
        _prefix "Core/RelationshipType/configures"

    /// <summary>
    /// The `from` Element conforms to each `to` Specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/conformsTo"></see></summary>
    let ``Core/RelationshipType/conformsTo`` =
        _prefix "Core/RelationshipType/conformsTo"

    /// <summary>
    /// The `from` Element contains each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/contains"></see></summary>
    let ``Core/RelationshipType/contains`` = _prefix "Core/RelationshipType/contains"

    /// <summary>
    /// The `from` Vulnerability is coordinatedBy the `to` Agent(s) (vendor, researcher, or consumer agent).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/coordinatedBy"></see></summary>
    let ``Core/RelationshipType/coordinatedBy`` =
        _prefix "Core/RelationshipType/coordinatedBy"

    /// <summary>
    /// The `from` Element has been copied to each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/copiedTo"></see></summary>
    let ``Core/RelationshipType/copiedTo`` = _prefix "Core/RelationshipType/copiedTo"
    /// <summary>
    /// The `from` Element's Action or DefinedProcess is createdBy `to` Agent(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/createdBy"></see></summary>
    let ``Core/RelationshipType/createdBy`` = _prefix "Core/RelationshipType/createdBy"

    /// <summary>
    /// The `from` Agent is delegating an action to the Agent of the `to` Relationship (which shall be of type invokedBy), during a LifecycleScopeType (e.g. the `to` invokedBy Relationship is being done on behalf of `from`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/delegatedTo"></see></summary>
    let ``Core/RelationshipType/delegatedTo`` =
        _prefix "Core/RelationshipType/delegatedTo"

    /// <summary>
    /// The `from` Element depends on each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/dependsOn"></see></summary>
    let ``Core/RelationshipType/dependsOn`` = _prefix "Core/RelationshipType/dependsOn"

    /// <summary>
    /// The `from` Element is a descendant of each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/descendantOf"></see></summary>
    let ``Core/RelationshipType/descendantOf`` =
        _prefix "Core/RelationshipType/descendantOf"

    /// <summary>
    /// The `from` Element describes each `to` Element. To denote the root(s) of a tree of elements in a collection, the rootElement property shall be used.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/describes"></see></summary>
    let ``Core/RelationshipType/describes`` = _prefix "Core/RelationshipType/describes"

    /// <summary>
    /// The `from` Vulnerability has no impact on each `to` Element. The use of the `doesNotAffect` is constrained to `VexNotAffectedVulnAssessmentRelationship` classed relationships.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/doesNotAffect"></see></summary>
    let ``Core/RelationshipType/doesNotAffect`` =
        _prefix "Core/RelationshipType/doesNotAffect"

    /// <summary>
    /// The `from` Element has been evaluated on the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/evaluatedOn"></see></summary>
    let ``Core/RelationshipType/evaluatedOn`` =
        _prefix "Core/RelationshipType/evaluatedOn"

    /// <summary>
    /// The `from` Element expands out as an artifact described by each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/expandsTo"></see></summary>
    let ``Core/RelationshipType/expandsTo`` = _prefix "Core/RelationshipType/expandsTo"

    /// <summary>
    /// The `from` Vulnerability has had an exploit created against it by each `to` Agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/exploitCreatedBy"></see></summary>
    let ``Core/RelationshipType/exploitCreatedBy`` =
        _prefix "Core/RelationshipType/exploitCreatedBy"

    /// <summary>
    /// The `from` Element has been finetuned on the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/finetunedOn"></see></summary>
    let ``Core/RelationshipType/finetunedOn`` =
        _prefix "Core/RelationshipType/finetunedOn"

    /// <summary>
    /// Designates a `from` Vulnerability has been fixed by the `to` Agent(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/fixedBy"></see></summary>
    let ``Core/RelationshipType/fixedBy`` = _prefix "Core/RelationshipType/fixedBy"
    /// <summary>
    /// A `from` Vulnerability has been fixed in each `to` Element. The use of the `fixedIn` type is constrained to `VexFixedVulnAssessmentRelationship` classed relationships.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/fixedIn"></see></summary>
    let ``Core/RelationshipType/fixedIn`` = _prefix "Core/RelationshipType/fixedIn"
    /// <summary>
    /// The `to` Element succeeds the `from` Element, establishing a unidirectional sequence. This succession is defined as chronological, procedural, or logical. It is used to represent either a temporal order (e.g., in a workflow) or a logical order for processing and traversal (e.g., in an ordered list).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/follows"></see></summary>
    let ``Core/RelationshipType/follows`` = _prefix "Core/RelationshipType/follows"
    /// <summary>
    /// Designates a `from` Vulnerability was originally discovered by the `to` Agent(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/foundBy"></see></summary>
    let ``Core/RelationshipType/foundBy`` = _prefix "Core/RelationshipType/foundBy"
    /// <summary>
    /// The `from` Element generates each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/generates"></see></summary>
    let ``Core/RelationshipType/generates`` = _prefix "Core/RelationshipType/generates"

    /// <summary>
    /// Every `to` Element is a file added to the `from` Element (`from` hasAddedFile `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAddedFile"></see></summary>
    let ``Core/RelationshipType/hasAddedFile`` =
        _prefix "Core/RelationshipType/hasAddedFile"

    /// <summary>
    /// Relates a `from` Vulnerability and each `to` Element with a security assessment. To be used with `VulnAssessmentRelationship` types.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAssessmentFor"></see></summary>
    let ``Core/RelationshipType/hasAssessmentFor`` =
        _prefix "Core/RelationshipType/hasAssessmentFor"

    /// <summary>
    /// Used to associate a `from` Artifact with each `to` Vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAssociatedVulnerability"></see></summary>
    let ``Core/RelationshipType/hasAssociatedVulnerability`` =
        _prefix "Core/RelationshipType/hasAssociatedVulnerability"

    /// <summary>
    /// The `from` SoftwareArtifact is concluded by the SPDX data creator to be governed by each `to` AnyLicenseInfo.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasConcludedLicense"></see></summary>
    let ``Core/RelationshipType/hasConcludedLicense`` =
        _prefix "Core/RelationshipType/hasConcludedLicense"

    /// <summary>
    /// The `from` Artifact has each `to` Agent as a contact point. The use of `hasContactPoint` type is constrained to `ContactPointRelationship` typed relationships. The type of contact (i.e. security) may be specified using a `ContactPointRelationship` element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasContactPoint"></see></summary>
    let ``Core/RelationshipType/hasContactPoint`` =
        _prefix "Core/RelationshipType/hasContactPoint"

    /// <summary>
    /// The `from` Element treats each `to` Element as a data file. A data file is an artifact that stores data required or optional for the `from` Element's functionality. A data file can be a database file, an index file, a log file, an AI model file, a calibration data file, a temporary file, a backup file, and more. For AI training dataset, test dataset, test artifact, configuration data, build input data, and build output data, please consider using the more specific relationship types: `trainedOn`, `testedOn`, `hasTest`, `configures`, `hasInput`, and `hasOutput`, respectively. This relationship does not imply dependency.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDataFile"></see></summary>
    let ``Core/RelationshipType/hasDataFile`` =
        _prefix "Core/RelationshipType/hasDataFile"

    /// <summary>
    /// The `from` SoftwareArtifact was discovered to actually contain each `to` AnyLicenseInfo (for example, as detected by automated tooling).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDeclaredLicense"></see></summary>
    let ``Core/RelationshipType/hasDeclaredLicense`` =
        _prefix "Core/RelationshipType/hasDeclaredLicense"

    /// <summary>
    /// Every `to` Element is a file deleted from the `from` Element (`from` hasDeletedFile `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDeletedFile"></see></summary>
    let ``Core/RelationshipType/hasDeletedFile`` =
        _prefix "Core/RelationshipType/hasDeletedFile"

    /// <summary>
    /// The `from` Element has manifest files that contain dependency information in each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDependencyManifest"></see></summary>
    let ``Core/RelationshipType/hasDependencyManifest`` =
        _prefix "Core/RelationshipType/hasDependencyManifest"

    /// <summary>
    /// The `from` Element is distributed as an artifact in each `to` Element (e.g. an RPM or archive file).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDistributionArtifact"></see></summary>
    let ``Core/RelationshipType/hasDistributionArtifact`` =
        _prefix "Core/RelationshipType/hasDistributionArtifact"

    /// <summary>
    /// The `from` Element is documented by each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDocumentation"></see></summary>
    let ``Core/RelationshipType/hasDocumentation`` =
        _prefix "Core/RelationshipType/hasDocumentation"

    /// <summary>
    /// The `from` Element dynamically links in each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDynamicLink"></see></summary>
    let ``Core/RelationshipType/hasDynamicLink`` =
        _prefix "Core/RelationshipType/hasDynamicLink"

    /// <summary>
    /// Every `to` Element is considered as evidence for the `from` Element (`from` hasEvidence `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasEvidence"></see></summary>
    let ``Core/RelationshipType/hasEvidence`` =
        _prefix "Core/RelationshipType/hasEvidence"

    /// <summary>
    /// Every `to` Element is an example for the `from` Element (`from` hasExample `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasExample"></see></summary>
    let ``Core/RelationshipType/hasExample`` =
        _prefix "Core/RelationshipType/hasExample"

    /// <summary>
    /// The `from` Build was run on the `to` Element during a LifecycleScopeType period (e.g. the host that the build runs on).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasHost"></see></summary>
    let ``Core/RelationshipType/hasHost`` = _prefix "Core/RelationshipType/hasHost"
    /// <summary>
    /// The `from` Build, DefinedProcess or Action element has each `to` Element as an input.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasInput"></see></summary>
    let ``Core/RelationshipType/hasInput`` = _prefix "Core/RelationshipType/hasInput"

    /// <summary>
    /// Every `to` Element is metadata about the `from` Element (`from` hasMetadata `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasMetadata"></see></summary>
    let ``Core/RelationshipType/hasMetadata`` =
        _prefix "Core/RelationshipType/hasMetadata"

    /// <summary>
    /// Every `to` Element is an optional component of the `from` Element (`from` hasOptionalComponent `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOptionalComponent"></see></summary>
    let ``Core/RelationshipType/hasOptionalComponent`` =
        _prefix "Core/RelationshipType/hasOptionalComponent"

    /// <summary>
    /// The `from` Element optionally depends on each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOptionalDependency"></see></summary>
    let ``Core/RelationshipType/hasOptionalDependency`` =
        _prefix "Core/RelationshipType/hasOptionalDependency"

    /// <summary>
    /// The `from` Build, DefinedProcess or Action element generates each `to` Element as an output.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOutput"></see></summary>
    let ``Core/RelationshipType/hasOutput`` = _prefix "Core/RelationshipType/hasOutput"

    /// <summary>
    /// The `from` Element has a prerequisite on each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasPrerequisite"></see></summary>
    let ``Core/RelationshipType/hasPrerequisite`` =
        _prefix "Core/RelationshipType/hasPrerequisite"

    /// <summary>
    /// The `from` Element has a dependency on each `to` Element, dependency is not in the distributed artifact, but assumed to be provided, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasProvidedDependency"></see></summary>
    let ``Core/RelationshipType/hasProvidedDependency`` =
        _prefix "Core/RelationshipType/hasProvidedDependency"

    /// <summary>
    /// The `from` Element has a requirement on each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasRequirement"></see></summary>
    let ``Core/RelationshipType/hasRequirement`` =
        _prefix "Core/RelationshipType/hasRequirement"

    /// <summary>
    /// The `from` ResolutionAction point to the `to` OutOfSpecAction that is addressed.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasResolution"></see></summary>
    let ``Core/RelationshipType/hasResolution`` =
        _prefix "Core/RelationshipType/hasResolution"

    /// <summary>
    /// Every `to` Element is a specification for the `from` Element (`from` hasSpecification `to`), during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasSpecification"></see></summary>
    let ``Core/RelationshipType/hasSpecification`` =
        _prefix "Core/RelationshipType/hasSpecification"

    /// <summary>
    /// The `from` Element statically links in each `to` Element, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasStaticLink"></see></summary>
    let ``Core/RelationshipType/hasStaticLink`` =
        _prefix "Core/RelationshipType/hasStaticLink"

    /// <summary>
    /// Every `to` Element is a test artifact for the `from` Element (`from` hasTest `to`), during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasTest"></see></summary>
    let ``Core/RelationshipType/hasTest`` = _prefix "Core/RelationshipType/hasTest"

    /// <summary>
    /// Every `to` Element is a test case for the `from` Element (`from` hasTestCase `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasTestCase"></see></summary>
    let ``Core/RelationshipType/hasTestCase`` =
        _prefix "Core/RelationshipType/hasTestCase"

    /// <summary>
    /// Every `to` Element is a variant the `from` Element (`from` hasVariant `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasVariant"></see></summary>
    let ``Core/RelationshipType/hasVariant`` =
        _prefix "Core/RelationshipType/hasVariant"

    /// <summary>
    /// The `from` Requirement is implemented in the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/implementedBy"></see></summary>
    let ``Core/RelationshipType/implementedBy`` =
        _prefix "Core/RelationshipType/implementedBy"

    /// <summary>
    /// The `from` Element was invoked by the `to` Agent, during a LifecycleScopeType period (for example, a Build element that describes a build step).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/invokedBy"></see></summary>
    let ``Core/RelationshipType/invokedBy`` = _prefix "Core/RelationshipType/invokedBy"
    /// <summary>
    /// `from` element located at a specific `to` location. A time period is optional.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/locatedAt"></see></summary>
    let ``Core/RelationshipType/locatedAt`` = _prefix "Core/RelationshipType/locatedAt"

    /// <summary>
    /// The `from` Element is modified by each `to` Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/modifiedBy"></see></summary>
    let ``Core/RelationshipType/modifiedBy`` =
        _prefix "Core/RelationshipType/modifiedBy"

    /// <summary>
    /// Every `to` Element is related to the `from` Element where the relationship type is not described by any of the SPDX relationship types (this relationship is directionless).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/other"></see></summary>
    let ``Core/RelationshipType/other`` = _prefix "Core/RelationshipType/other"

    /// <summary>
    /// Every `to` Element is a packaged instance of the `from` Element (`from` packagedBy `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/packagedBy"></see></summary>
    let ``Core/RelationshipType/packagedBy`` =
        _prefix "Core/RelationshipType/packagedBy"

    /// <summary>
    /// Every `to` Element is a patch for the `from` Element (`from` patchedBy `to`).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/patchedBy"></see></summary>
    let ``Core/RelationshipType/patchedBy`` = _prefix "Core/RelationshipType/patchedBy"

    /// <summary>
    /// The `from` Element has been pretrained on the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/pretrainedOn"></see></summary>
    let ``Core/RelationshipType/pretrainedOn`` =
        _prefix "Core/RelationshipType/pretrainedOn"

    /// <summary>
    /// The `from` Agent provides support for each `to` Artifact. Shall be a `SupportRelationship` type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/providesSupportFor"></see></summary>
    let ``Core/RelationshipType/providesSupportFor`` =
        _prefix "Core/RelationshipType/providesSupportFor"

    /// <summary>
    /// Every `from` action is performedBy `to` Agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/performedBy"></see></summary>
    let ``Core/RelationshipType/performedBy`` =
        _prefix "Core/RelationshipType/performedBy"

    /// <summary>
    /// Designates a `from` Vulnerability was made available for public use or reference by each `to` Agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/publishedBy"></see></summary>
    let ``Core/RelationshipType/publishedBy`` =
        _prefix "Core/RelationshipType/publishedBy"

    /// <summary>
    /// Designates a `from` Vulnerability was first reported to a project, vendor, or tracking database for formal identification by each `to` Agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/reportedBy"></see></summary>
    let ``Core/RelationshipType/reportedBy`` =
        _prefix "Core/RelationshipType/reportedBy"

    /// <summary>
    /// Designates a `from` Vulnerability's details were tracked, aggregated, and/or enriched to improve context (i.e. NVD) by each `to` Agent.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/republishedBy"></see></summary>
    let ``Core/RelationshipType/republishedBy`` =
        _prefix "Core/RelationshipType/republishedBy"

    /// <summary>
    /// The `to` OutOfSpecAction is resolved in the `from` ResolutionAction.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/resolved"></see></summary>
    let ``Core/RelationshipType/resolved`` = _prefix "Core/RelationshipType/resolved"
    /// <summary>
    /// The `from` Element (the instructions) of runs on each `to` Hardware (processing element), during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/runsOn"></see></summary>
    let ``Core/RelationshipType/runsOn`` = _prefix "Core/RelationshipType/runsOn"

    /// <summary>
    /// The `from` SpdxDocument can be found in a serialized form in each `to` Artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/serializedInArtifact"></see></summary>
    let ``Core/RelationshipType/serializedInArtifact`` =
        _prefix "Core/RelationshipType/serializedInArtifact"

    /// <summary>
    /// The `from` Element has been tested on the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/testedOn"></see></summary>
    let ``Core/RelationshipType/testedOn`` = _prefix "Core/RelationshipType/testedOn"

    /// <summary>
    /// the `from` Requirement is refined and further elaborated by each `to` Requirement, which contains more detailed implementation information.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/tracedToDetail"></see></summary>
    let ``Core/RelationshipType/tracedToDetail`` =
        _prefix "Core/RelationshipType/tracedToDetail"

    /// <summary>
    /// The `from` Element has been trained on the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/trainedOn"></see></summary>
    let ``Core/RelationshipType/trainedOn`` = _prefix "Core/RelationshipType/trainedOn"

    /// <summary>
    /// The `from` Vulnerability impact is being investigated for each `to` Element. The use of the `underInvestigationFor` type is constrained to `VexUnderInvestigationVulnAssessmentRelationship` classed relationships.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/underInvestigationFor"></see></summary>
    let ``Core/RelationshipType/underInvestigationFor`` =
        _prefix "Core/RelationshipType/underInvestigationFor"

    /// <summary>
    /// The `from` Element uses each `to` Element as a tool, during a LifecycleScopeType period.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/usesTool"></see></summary>
    let ``Core/RelationshipType/usesTool`` = _prefix "Core/RelationshipType/usesTool"

    /// <summary>
    /// The `from` Element has been validated on the `to` Element(s).
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/validatedOn"></see></summary>
    let ``Core/RelationshipType/validatedOn`` =
        _prefix "Core/RelationshipType/validatedOn"

    /// <summary>
    /// The `from` Requirement that has verification (test, review, analysis etc.) details defined in the `to` RequirementVerification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/verifiedBy"></see></summary>
    let ``Core/RelationshipType/verifiedBy`` =
        _prefix "Core/RelationshipType/verifiedBy"

    /// <summary>
    /// Information about the relationship between two Elements.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/relationshipType"></see></summary>
    let ``Core/relationshipType`` = _prefix "Core/relationshipType"
    /// <summary>
    /// Indicates whether a relationship is known to be complete, incomplete, or if no assertion is made with respect to relationship completeness.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness"></see></summary>
    let ``Core/RelationshipCompleteness`` = _prefix "Core/RelationshipCompleteness"

    /// <summary>
    /// The relationship is known not to be exhaustive.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/incomplete"></see></summary>
    let ``Core/RelationshipCompleteness/incomplete`` =
        _prefix "Core/RelationshipCompleteness/incomplete"

    /// <summary>
    /// The relationship is known to be exhaustive.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/complete"></see></summary>
    let ``Core/RelationshipCompleteness/complete`` =
        _prefix "Core/RelationshipCompleteness/complete"

    /// <summary>
    /// No assertion can be made about the completeness of the relationship.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/noAssertion"></see></summary>
    let ``Core/RelationshipCompleteness/noAssertion`` =
        _prefix "Core/RelationshipCompleteness/noAssertion"

    /// <summary>
    /// Provides information about the completeness of relationships.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/completeness"></see></summary>
    let ``Core/completeness`` = _prefix "Core/completeness"
    /// <summary>
    /// Specifies the time from which an element is applicable / valid.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/startTime"></see></summary>
    let ``Core/startTime`` = _prefix "Core/startTime"
    /// <summary>
    /// A text describing the actual need defined by the requirement.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/requirementStatement"></see></summary>
    let ``Core/requirementStatement`` = _prefix "Core/requirementStatement"
    /// <summary>
    /// The product lifecycle phase, the requirement is applicable for.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/devLifecycleStage"></see></summary>
    let ``Core/devLifecycleStage`` = _prefix "Core/devLifecycleStage"
    /// <summary>
    /// Provides a universally unique Requirement ID.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/requirementUUID"></see></summary>
    let ``Core/requirementUUID`` = _prefix "Core/requirementUUID"
    /// <summary>
    /// Text used to define the rationale or additional information.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/requirementRationale"></see></summary>
    let ``Core/requirementRationale`` = _prefix "Core/requirementRationale"
    /// <summary>
    /// Abstract class representing a license combination consisting of one or more licenses.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/AnyLicenseInfo"></see></summary>
    let ``SimpleLicensing/AnyLicenseInfo`` = _prefix "SimpleLicensing/AnyLicenseInfo"
    /// <summary>
    /// Provides the license under which the SPDX documentation of the Element can be
    /// used.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/dataLicense"></see></summary>
    let ``Core/dataLicense`` = _prefix "Core/dataLicense"
    /// <summary>
    /// Provides a NamespaceMap of prefixes and associated namespace partial URIs applicable to an SpdxDocument and independent of any specific serialization format or instance.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/namespaceMap"></see></summary>
    let ``Core/namespaceMap`` = _prefix "Core/namespaceMap"
    /// <summary>
    /// Provides an ExternalMap of Element identifiers.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/import"></see></summary>
    let ``Core/import`` = _prefix "Core/import"
    /// <summary>
    /// A specification type defines the nature of a specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType"></see></summary>
    let ``Core/SpecificationType`` = _prefix "Core/SpecificationType"

    /// <summary>
    /// A formal standard is a standard ratified by a recognized standards-development organization and published as a normative reference.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/formalStandard"></see></summary>
    let ``Core/SpecificationType/formalStandard`` =
        _prefix "Core/SpecificationType/formalStandard"

    /// <summary>
    /// A mandatory legal specification issued by a governmental or regulatory authority. Compliance is enforceable by law.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/regulation"></see></summary>
    let ``Core/SpecificationType/regulation`` =
        _prefix "Core/SpecificationType/regulation"

    /// <summary>
    /// A specification is a detailed document (or set of documents) that describes the requirements, design, behavior, or other characteristics of a system, component, or process so that all stakeholders have a clear, unambiguous reference.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/specification"></see></summary>
    let ``Core/SpecificationType/specification`` =
        _prefix "Core/SpecificationType/specification"

    /// <summary>
    /// Any specification that does not fall under any of the other entries.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/other"></see></summary>
    let ``Core/SpecificationType/other`` = _prefix "Core/SpecificationType/other"
    /// <summary>
    /// A specification type defines the nature of a specification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/specType"></see></summary>
    let ``Core/specType`` = _prefix "Core/specType"
    /// <summary>
    /// Quantity is the amount in the selected QUDT unit.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/quantity"></see></summary>
    let ``Core/quantity`` = _prefix "Core/quantity"
    /// <summary>
    /// QUDT unit is used for measurement criteria based on product type, region and use.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/unitQUDT"></see></summary>
    let ``Core/unitQUDT`` = _prefix "Core/unitQUDT"
    /// <summary>
    /// A characterization of some aspect of an Element that is associated with the Element in a generalized fashion.
    /// <see href="https://spdx.org/rdf/3.1/terms/Extension/Extension"></see></summary>
    let ``Extension/Extension`` = _prefix "Extension/Extension"
    /// <summary>
    /// Specifies a human language used within the content of an Element or a property.
    /// <see href="https://spdx.org/rdf/3.1/terms/Core/inLanguage"></see></summary>
    let ``Core/inLanguage`` = _prefix "Core/inLanguage"

    /// <summary>
    /// Confidentiality level.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType"></see></summary>
    let ``Dataset/ConfidentialityLevelType`` =
        _prefix "Dataset/ConfidentialityLevelType"

    /// <summary>
    /// Data points in the dataset can be shared only with specific organizations and their clients on a need to know basis.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/amber"></see></summary>
    let ``Dataset/ConfidentialityLevelType/amber`` =
        _prefix "Dataset/ConfidentialityLevelType/amber"

    /// <summary>
    /// Dataset may be distributed freely, without restriction.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/clear"></see></summary>
    let ``Dataset/ConfidentialityLevelType/clear`` =
        _prefix "Dataset/ConfidentialityLevelType/clear"

    /// <summary>
    /// Dataset can be shared within a community of peers and partners.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/green"></see></summary>
    let ``Dataset/ConfidentialityLevelType/green`` =
        _prefix "Dataset/ConfidentialityLevelType/green"

    /// <summary>
    /// Data points in the dataset are highly confidential and can only be shared with named recipients.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/red"></see></summary>
    let ``Dataset/ConfidentialityLevelType/red`` =
        _prefix "Dataset/ConfidentialityLevelType/red"

    /// <summary>
    /// Availability of dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType"></see></summary>
    let ``Dataset/DatasetAvailabilityType`` = _prefix "Dataset/DatasetAvailabilityType"

    /// <summary>
    /// Dataset is not publicly available and can only be accessed after affirmatively accepting terms on a clickthrough webpage.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/clickthrough"></see></summary>
    let ``Dataset/DatasetAvailabilityType/clickthrough`` =
        _prefix "Dataset/DatasetAvailabilityType/clickthrough"

    /// <summary>
    /// Dataset is publicly available and can be downloaded directly.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/directDownload"></see></summary>
    let ``Dataset/DatasetAvailabilityType/directDownload`` =
        _prefix "Dataset/DatasetAvailabilityType/directDownload"

    /// <summary>
    /// Dataset is publicly available, but not all at once, and can only be accessed through queries which return parts of the dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/query"></see></summary>
    let ``Dataset/DatasetAvailabilityType/query`` =
        _prefix "Dataset/DatasetAvailabilityType/query"

    /// <summary>
    /// Dataset is not publicly available and an email registration is required before accessing the dataset, although without an affirmative acceptance of terms.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/registration"></see></summary>
    let ``Dataset/DatasetAvailabilityType/registration`` =
        _prefix "Dataset/DatasetAvailabilityType/registration"

    /// <summary>
    /// Dataset provider is not making available the underlying data and the dataset shall be reassembled, typically using the provided script for scraping the data.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/scrapingScript"></see></summary>
    let ``Dataset/DatasetAvailabilityType/scrapingScript`` =
        _prefix "Dataset/DatasetAvailabilityType/scrapingScript"

    /// <summary>
    /// Mechanism to update the dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/datasetUpdateMechanism"></see></summary>
    let ``Dataset/datasetUpdateMechanism`` = _prefix "Dataset/datasetUpdateMechanism"
    /// <summary>
    /// Preprocessing steps that were applied to the raw data to create the given dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/dataPreprocessing"></see></summary>
    let ``Dataset/dataPreprocessing`` = _prefix "Dataset/dataPreprocessing"
    /// <summary>
    /// **DEPRECATED in SPDX 3.1.**
    /// Use [/Core/intendedUse](../../Core/Properties/intendedUse.md) instead.
    ///
    /// The intended use of a given dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/intendedUse"></see></summary>
    let ``Dataset/intendedUse`` = _prefix "Dataset/intendedUse"
    /// <summary>
    /// Describes a sensor used for collecting the data.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/sensor"></see></summary>
    let ``Dataset/sensor`` = _prefix "Dataset/sensor"
    /// <summary>
    /// How the dataset was collected.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/dataCollectionProcess"></see></summary>
    let ``Dataset/dataCollectionProcess`` = _prefix "Dataset/dataCollectionProcess"
    /// <summary>
    /// Potentially noisy elements of the dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/datasetNoise"></see></summary>
    let ``Dataset/datasetNoise`` = _prefix "Dataset/datasetNoise"
    /// <summary>
    /// Availability of a dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/datasetAvailability"></see></summary>
    let ``Dataset/datasetAvailability`` = _prefix "Dataset/datasetAvailability"
    /// <summary>
    /// Enumeration of dataset types.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType"></see></summary>
    let ``Dataset/DatasetType`` = _prefix "Dataset/DatasetType"
    /// <summary>
    /// Data is audio based, such as a collection of music from the 80s.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/audio"></see></summary>
    let ``Dataset/DatasetType/audio`` = _prefix "Dataset/DatasetType/audio"
    /// <summary>
    /// Data that is classified into a discrete number of categories, such as the eye color of a population of people.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/categorical"></see></summary>
    let ``Dataset/DatasetType/categorical`` = _prefix "Dataset/DatasetType/categorical"
    /// <summary>
    /// Data is in the form of a graph where entries are somehow related to each other through edges, such a social network of friends.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/graph"></see></summary>
    let ``Dataset/DatasetType/graph`` = _prefix "Dataset/DatasetType/graph"
    /// <summary>
    /// Data is a collection of images such as pictures of animals.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/image"></see></summary>
    let ``Dataset/DatasetType/image`` = _prefix "Dataset/DatasetType/image"
    /// <summary>
    /// Data type is not known.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/noAssertion"></see></summary>
    let ``Dataset/DatasetType/noAssertion`` = _prefix "Dataset/DatasetType/noAssertion"
    /// <summary>
    /// Data consists only of numeric entries.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/numeric"></see></summary>
    let ``Dataset/DatasetType/numeric`` = _prefix "Dataset/DatasetType/numeric"
    /// <summary>
    /// Data is of a type not included in this list.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/other"></see></summary>
    let ``Dataset/DatasetType/other`` = _prefix "Dataset/DatasetType/other"
    /// <summary>
    /// Data is recorded from a physical sensor, such as a thermometer reading or biometric device.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/sensor"></see></summary>
    let ``Dataset/DatasetType/sensor`` = _prefix "Dataset/DatasetType/sensor"
    /// <summary>
    /// Data is stored in tabular format or retrieved from a relational database.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/structured"></see></summary>
    let ``Dataset/DatasetType/structured`` = _prefix "Dataset/DatasetType/structured"
    /// <summary>
    /// Data describes the syntax or semantics of a language or text, such as a parse tree used for natural language processing.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/syntactic"></see></summary>
    let ``Dataset/DatasetType/syntactic`` = _prefix "Dataset/DatasetType/syntactic"
    /// <summary>
    /// Data consists of unstructured text, such as a book, a Wikipedia article (without images), or a transcript.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/text"></see></summary>
    let ``Dataset/DatasetType/text`` = _prefix "Dataset/DatasetType/text"
    /// <summary>
    /// Data is recorded in an ordered sequence of timestamped entries, such as the price of a stock over the course of a day.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/timeseries"></see></summary>
    let ``Dataset/DatasetType/timeseries`` = _prefix "Dataset/DatasetType/timeseries"
    /// <summary>
    /// Data is recorded with a timestamp for each entry, but not necessarily ordered or at specific intervals, such as when a taxi ride starts and ends.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/timestamp"></see></summary>
    let ``Dataset/DatasetType/timestamp`` = _prefix "Dataset/DatasetType/timestamp"
    /// <summary>
    /// Data is video based, such as a collection of movie clips featuring Tom Hanks.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/video"></see></summary>
    let ``Dataset/DatasetType/video`` = _prefix "Dataset/DatasetType/video"
    /// <summary>
    /// Type of data in a dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/datasetType"></see></summary>
    let ``Dataset/datasetType`` = _prefix "Dataset/datasetType"
    /// <summary>
    /// Records the biases that the dataset is known to encompass.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/knownBias"></see></summary>
    let ``Dataset/knownBias`` = _prefix "Dataset/knownBias"
    /// <summary>
    /// Confidentiality level of the data points contained in the dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/confidentialityLevel"></see></summary>
    let ``Dataset/confidentialityLevel`` = _prefix "Dataset/confidentialityLevel"

    /// <summary>
    /// Describes if any sensitive personal information is present in the dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/hasSensitivePersonalInformation"></see></summary>
    let ``Dataset/hasSensitivePersonalInformation`` =
        _prefix "Dataset/hasSensitivePersonalInformation"

    /// <summary>
    /// **DEPRECATED in SPDX 3.1.**
    /// Use [/Software/artifactSize](../../Software/Properties/artifactSize.md)
    /// instead.
    ///
    /// Size of the dataset.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/datasetSize"></see></summary>
    let ``Dataset/datasetSize`` = _prefix "Dataset/datasetSize"
    /// <summary>
    /// Anonymization methods used.
    /// <see href="https://spdx.org/rdf/3.1/terms/Dataset/anonymizationMethodUsed"></see></summary>
    let ``Dataset/anonymizationMethodUsed`` = _prefix "Dataset/anonymizationMethodUsed"
    /// <summary>
    /// A license expression participating in a license set.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/member"></see></summary>
    let ``ExpandedLicensing/member`` = _prefix "ExpandedLicensing/member"
    /// <summary>
    /// Abstract class for the portion of an AnyLicenseInfo representing a license.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/License"></see></summary>
    let ``ExpandedLicensing/License`` = _prefix "ExpandedLicensing/License"

    /// <summary>
    /// Abstract class for additional text intended to be added to a License, but
    /// which is not itself a standalone License.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/LicenseAddition"></see></summary>
    let ``ExpandedLicensing/LicenseAddition`` =
        _prefix "ExpandedLicensing/LicenseAddition"

    /// <summary>
    /// Abstract class representing a License or an OrLaterOperator.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ExtendableLicense"></see></summary>
    let ``ExpandedLicensing/ExtendableLicense`` =
        _prefix "ExpandedLicensing/ExtendableLicense"

    /// <summary>
    /// Identifies the full text of a License or Addition.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseText"></see></summary>
    let ``SimpleLicensing/licenseText`` = _prefix "SimpleLicensing/licenseText"
    /// <summary>
    /// Specifies whether the License is listed as approved by the
    /// Open Source Initiative (OSI).
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isOsiApproved"></see></summary>
    let ``ExpandedLicensing/isOsiApproved`` = _prefix "ExpandedLicensing/isOsiApproved"
    /// <summary>
    /// Specifies the licenseId that is preferred to be used in place of a deprecated
    /// License or LicenseAddition.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/obsoletedBy"></see></summary>
    let ``ExpandedLicensing/obsoletedBy`` = _prefix "ExpandedLicensing/obsoletedBy"
    /// <summary>
    /// Identifies all the text and metadata associated with a license in the license
    /// XML format.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/licenseXml"></see></summary>
    let ``ExpandedLicensing/licenseXml`` = _prefix "ExpandedLicensing/licenseXml"

    /// <summary>
    /// Specifies whether a license or additional text identifier has been marked as
    /// deprecated.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isDeprecatedLicenseId"></see></summary>
    let ``ExpandedLicensing/isDeprecatedLicenseId`` =
        _prefix "ExpandedLicensing/isDeprecatedLicenseId"

    /// <summary>
    /// Contains a URL where the License or LicenseAddition can be found in use.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/seeAlso"></see></summary>
    let ``ExpandedLicensing/seeAlso`` = _prefix "ExpandedLicensing/seeAlso"
    /// <summary>
    /// Specifies whether the License is listed as free by the
    /// Free Software Foundation (FSF).
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isFsfLibre"></see></summary>
    let ``ExpandedLicensing/isFsfLibre`` = _prefix "ExpandedLicensing/isFsfLibre"

    /// <summary>
    /// Identifies the full text of a License, in SPDX templating format.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardLicenseTemplate"></see></summary>
    let ``ExpandedLicensing/standardLicenseTemplate`` =
        _prefix "ExpandedLicensing/standardLicenseTemplate"

    /// <summary>
    /// Provides a License author's preferred text to indicate that a file is covered
    /// by the License.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardLicenseHeader"></see></summary>
    let ``ExpandedLicensing/standardLicenseHeader`` =
        _prefix "ExpandedLicensing/standardLicenseHeader"

    /// <summary>
    /// Specifies whether an additional text identifier has been marked as deprecated.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isDeprecatedAdditionId"></see></summary>
    let ``ExpandedLicensing/isDeprecatedAdditionId`` =
        _prefix "ExpandedLicensing/isDeprecatedAdditionId"

    /// <summary>
    /// Identifies the full text of a LicenseAddition, in SPDX templating format.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardAdditionTemplate"></see></summary>
    let ``ExpandedLicensing/standardAdditionTemplate`` =
        _prefix "ExpandedLicensing/standardAdditionTemplate"

    /// <summary>
    /// Identifies the full text of a LicenseAddition.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/additionText"></see></summary>
    let ``ExpandedLicensing/additionText`` = _prefix "ExpandedLicensing/additionText"

    /// <summary>
    /// Specifies the SPDX License List version in which this license or exception
    /// identifier was deprecated.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/deprecatedVersion"></see></summary>
    let ``ExpandedLicensing/deprecatedVersion`` =
        _prefix "ExpandedLicensing/deprecatedVersion"

    /// <summary>
    /// Specifies the SPDX License List version in which this ListedLicense or
    /// ListedLicenseException identifier was first added.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/listVersionAdded"></see></summary>
    let ``ExpandedLicensing/listVersionAdded`` =
        _prefix "ExpandedLicensing/listVersionAdded"

    /// <summary>
    /// An Individual Value for License when no assertion can be made about its actual
    /// value.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/NoAssertionLicense"></see></summary>
    let ``ExpandedLicensing/NoAssertionLicense`` =
        _prefix "ExpandedLicensing/NoAssertionLicense"

    /// <summary>
    ///   <see href="https://spdx.org/rdf/3.1/terms/Licensing/NoAssertion"></see>
    /// </summary>
    let ``Licensing/NoAssertion`` = _prefix "Licensing/NoAssertion"
    /// <summary>
    /// An Individual Value for License where the SPDX data creator determines that no
    /// license is present.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/NoneLicense"></see></summary>
    let ``ExpandedLicensing/NoneLicense`` = _prefix "ExpandedLicensing/NoneLicense"
    /// <summary>
    ///   <see href="https://spdx.org/rdf/3.1/terms/Licensing/None"></see>
    /// </summary>
    let ``Licensing/None`` = _prefix "Licensing/None"

    /// <summary>
    /// A License participating in an 'or later' model.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectLicense"></see></summary>
    let ``ExpandedLicensing/subjectLicense`` =
        _prefix "ExpandedLicensing/subjectLicense"

    /// <summary>
    /// A LicenseAddition participating in a 'with addition' model.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectAddition"></see></summary>
    let ``ExpandedLicensing/subjectAddition`` =
        _prefix "ExpandedLicensing/subjectAddition"

    /// <summary>
    /// A License participating in a 'with addition' model.
    /// <see href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectExtendableLicense"></see></summary>
    let ``ExpandedLicensing/subjectExtendableLicense`` =
        _prefix "ExpandedLicensing/subjectExtendableLicense"

    /// <summary>
    /// A type of extension consisting of a list of name value pairs.
    /// <see href="https://spdx.org/rdf/3.1/terms/Extension/CdxPropertiesExtension"></see></summary>
    let ``Extension/CdxPropertiesExtension`` =
        _prefix "Extension/CdxPropertiesExtension"

    /// <summary>
    /// Provides a map of a property name to a value.
    /// <see href="https://spdx.org/rdf/3.1/terms/Extension/cdxProperty"></see></summary>
    let ``Extension/cdxProperty`` = _prefix "Extension/cdxProperty"
    /// <summary>
    /// A name used in a CdxPropertyEntry name-value pair.
    /// <see href="https://spdx.org/rdf/3.1/terms/Extension/cdxPropName"></see></summary>
    let ``Extension/cdxPropName`` = _prefix "Extension/cdxPropName"
    /// <summary>
    /// A value used in a CdxPropertyEntry name-value pair.
    /// <see href="https://spdx.org/rdf/3.1/terms/Extension/cdxPropValue"></see></summary>
    let ``Extension/cdxPropValue`` = _prefix "Extension/cdxPropValue"

    /// <summary>
    /// Indicates the specific RequirementVerification instance on which the EvaluationResult is based.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluationBasedOn"></see></summary>
    let ``FunctionalSafety/evaluationBasedOn`` =
        _prefix "FunctionalSafety/evaluationBasedOn"

    /// <summary>
    /// EvaluationResultType describes the outcome of an evaluation or verification process with.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType"></see></summary>
    let ``FunctionalSafety/EvaluationResultType`` =
        _prefix "FunctionalSafety/EvaluationResultType"

    /// <summary>
    /// Indicates a successful evaluation where the requirement or condition is clearly met.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/pass"></see></summary>
    let ``FunctionalSafety/EvaluationResultType/pass`` =
        _prefix "FunctionalSafety/EvaluationResultType/pass"

    /// <summary>
    /// Indicates a failed evaluation where the requirement or condition is not met.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/fail"></see></summary>
    let ``FunctionalSafety/EvaluationResultType/fail`` =
        _prefix "FunctionalSafety/EvaluationResultType/fail"

    /// <summary>
    /// Inconclusive refers to a result or outcome from a verification, test, or analysis that cannot be clearly classified as either positive (successful, pass) or negative (failed, reject). An inconclusive result means there was not enough clear evidence, data, or signal to make a definitive determination, and further investigation or additional testing is necessary. An inconclusive result always shall need a comment on it.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/inconclusive"></see></summary>
    let ``FunctionalSafety/EvaluationResultType/inconclusive`` =
        _prefix "FunctionalSafety/EvaluationResultType/inconclusive"

    /// <summary>
    /// Evaluation is an outcome considering results of a verification.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluation"></see></summary>
    let ``FunctionalSafety/evaluation`` = _prefix "FunctionalSafety/evaluation"

    /// <summary>
    /// Detailed explanation or reasoning that supports the EvaluationResult.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluationRationale"></see></summary>
    let ``FunctionalSafety/evaluationRationale`` =
        _prefix "FunctionalSafety/evaluationRationale"

    /// <summary>
    /// EvidenceType refers to categories of documented or observable proof used to verify compliance, qualification, or performance
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType"></see></summary>
    let ``FunctionalSafety/EvidenceType`` = _prefix "FunctionalSafety/EvidenceType"

    /// <summary>
    /// Structured documentation of test results, inspections, or analyses.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/report"></see></summary>
    let ``FunctionalSafety/EvidenceType/report`` =
        _prefix "FunctionalSafety/EvidenceType/report"

    /// <summary>
    /// Time-stamped records capturing system or operational data recorded as usually as a response to specific triggers in a specified environment.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/log"></see></summary>
    let ``FunctionalSafety/EvidenceType/log`` =
        _prefix "FunctionalSafety/EvidenceType/log"

    /// <summary>
    /// Captured datastream like audio, video, or any other kind of continuous electronic capture of events, behavior or conditions.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/recording"></see></summary>
    let ``FunctionalSafety/EvidenceType/recording`` =
        _prefix "FunctionalSafety/EvidenceType/recording"

    /// <summary>
    /// Documentation of direct monitoring or witnessing of the demonstration of processes, tests, or any kind of system responses during a specified timeframe under specified environmental conditions.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/observation"></see></summary>
    let ``FunctionalSafety/EvidenceType/observation`` =
        _prefix "FunctionalSafety/EvidenceType/observation"

    /// <summary>
    /// Any other relevant type of proof or documentation not covered above.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/other"></see></summary>
    let ``FunctionalSafety/EvidenceType/other`` =
        _prefix "FunctionalSafety/EvidenceType/other"

    /// <summary>
    /// evidenceCategory refers to a category of documented or observable proof.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evidenceCategory"></see></summary>
    let ``FunctionalSafety/evidenceCategory`` =
        _prefix "FunctionalSafety/evidenceCategory"

    /// <summary>
    /// A evidenceUUID is a universally unique identifier (UUID) assigned to an entity, item, or requirement.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evidenceUUID"></see></summary>
    let ``FunctionalSafety/evidenceUUID`` = _prefix "FunctionalSafety/evidenceUUID"

    /// <summary>
    /// A verificationRationale is supporting information that justifies the verification details.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationRationale"></see></summary>
    let ``FunctionalSafety/verificationRationale`` =
        _prefix "FunctionalSafety/verificationRationale"

    /// <summary>
    /// Verification preconditions are initial criteria that are to be met prior to initiating the verification method.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationPrecondition"></see></summary>
    let ``FunctionalSafety/verificationPrecondition`` =
        _prefix "FunctionalSafety/verificationPrecondition"

    /// <summary>
    /// A verificationUUID is a universally unique identifier (UUID) assigned to a Verification item.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationUUID"></see></summary>
    let ``FunctionalSafety/verificationUUID`` =
        _prefix "FunctionalSafety/verificationUUID"

    /// <summary>
    /// Enumeration of verification types.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType"></see></summary>
    let ``FunctionalSafety/VerificationType`` =
        _prefix "FunctionalSafety/VerificationType"

    /// <summary>
    /// Analytical evaluating of data, designs, or processes methodically to verify correctness against standards or expectations. Typical analysis methods are FMEA, FTA, STPA, static analysis for MISRA compliance etc.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/analysis"></see></summary>
    let ``FunctionalSafety/VerificationType/analysis`` =
        _prefix "FunctionalSafety/VerificationType/analysis"

    /// <summary>
    /// A systematic examination of a system, process, or outcome to evaluate compliance of specific work products with a specific expectation with a specification, regulation or standard. Often involves judgement and a rationale of this judgement.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/assessment"></see></summary>
    let ``FunctionalSafety/VerificationType/assessment`` =
        _prefix "FunctionalSafety/VerificationType/assessment"

    /// <summary>
    /// An examination typically focusing on compliance with policies, standards, or regulations. Usually this is done during an audit meeting, while the assessment also involves deep and detailed reviews of work products (e.g. requirements, verification specifications, reports etc.)
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/audit"></see></summary>
    let ``FunctionalSafety/VerificationType/audit`` =
        _prefix "FunctionalSafety/VerificationType/audit"

    /// <summary>
    /// Demonstrating and monitoring or recording that the item under verification to confirm that a requirement is met by the item under verification.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/demonstration"></see></summary>
    let ``FunctionalSafety/VerificationType/demonstration`` =
        _prefix "FunctionalSafety/VerificationType/demonstration"

    /// <summary>
    /// A thorough examination or checking of documentation, records, processes, or systems to confirm compliance or adherence. An inspection needs to have a defined set of acceptance criteria (e.g. a checklist), a documentation of roles involved in the inspection (e.g. to document the inspector's independence) and a clear documentation of when and how it was performed.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/inspection"></see></summary>
    let ``FunctionalSafety/VerificationType/inspection`` =
        _prefix "FunctionalSafety/VerificationType/inspection"

    /// <summary>
    /// Any other specialized or custom verification method that fits the context.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/other"></see></summary>
    let ``FunctionalSafety/VerificationType/other`` =
        _prefix "FunctionalSafety/VerificationType/other"

    /// <summary>
    /// A examination or checking of documentation, records, processes, or systems to confirm compliance or adherence with an upper level requirement. Typically done as peer review, offline review or review meeting.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/review"></see></summary>
    let ``FunctionalSafety/VerificationType/review`` =
        _prefix "FunctionalSafety/VerificationType/review"

    /// <summary>
    /// Conducting controlled tests, experiments or simulations to verify that specific requirements regarding performance, functionality, robustness, etc. are met.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/test"></see></summary>
    let ``FunctionalSafety/VerificationType/test`` =
        _prefix "FunctionalSafety/VerificationType/test"

    /// <summary>
    /// verificationMethod refers to the specific approach used for a checking an element's conformance with its requirements.
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationMethod"></see></summary>
    let ``FunctionalSafety/verificationMethod`` =
        _prefix "FunctionalSafety/verificationMethod"

    /// <summary>
    /// Verification postcondition that are true immediately after a verification method has been performed
    /// <see href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationPostcondition"></see></summary>
    let ``FunctionalSafety/verificationPostcondition`` =
        _prefix "FunctionalSafety/verificationPostcondition"

    /// <summary>
    /// Class that describes an instance of Hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/Hardware"></see></summary>
    let ``Hardware/Hardware`` = _prefix "Hardware/Hardware"
    /// <summary>
    /// The amount or measure of a bulk product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/bulkQuantity"></see></summary>
    let ``Hardware/bulkQuantity`` = _prefix "Hardware/bulkQuantity"
    /// <summary>
    /// Information related to hardware dimension.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/yAxisLength"></see></summary>
    let ``Hardware/yAxisLength`` = _prefix "Hardware/yAxisLength"
    /// <summary>
    /// Information related to hardware dimension.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/zAxisLength"></see></summary>
    let ``Hardware/zAxisLength`` = _prefix "Hardware/zAxisLength"
    /// <summary>
    /// Information related to hardware dimension.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/xAxisLength"></see></summary>
    let ``Hardware/xAxisLength`` = _prefix "Hardware/xAxisLength"
    /// <summary>
    /// Hazards are potential sources of harm, danger, or adverse effects to people, property, the environment, or systems within or related to a specific piece of hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/hazard"></see></summary>
    let ``Hardware/hazard`` = _prefix "Hardware/hazard"
    /// <summary>
    /// Additional relevance information.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/additionalInformation"></see></summary>
    let ``Hardware/additionalInformation`` = _prefix "Hardware/additionalInformation"
    /// <summary>
    /// Identifier for specific product is called a serial number.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/serialNumber"></see></summary>
    let ``Hardware/serialNumber`` = _prefix "Hardware/serialNumber"
    /// <summary>
    /// Product Part Number as defined by OEM.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/partNumber"></see></summary>
    let ``Hardware/partNumber`` = _prefix "Hardware/partNumber"
    /// <summary>
    /// Date of product release.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/releaseDate"></see></summary>
    let ``Hardware/releaseDate`` = _prefix "Hardware/releaseDate"
    /// <summary>
    /// The Agent who is responsible for product branding such as an OEM.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/productAgent"></see></summary>
    let ``Hardware/productAgent`` = _prefix "Hardware/productAgent"
    /// <summary>
    /// The category describes the hardware item in a DefinedType.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/category"></see></summary>
    let ``Hardware/category`` = _prefix "Hardware/category"

    /// <summary>
    /// It is the authoritative or credible entity, document, or body of knowledge that provides the meaning of an additionalInformation key and/or its values, ensuring accuracy, context, and standardization.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/additionalInformationSpecification"></see></summary>
    let ``Hardware/additionalInformationSpecification`` =
        _prefix "Hardware/additionalInformationSpecification"

    /// <summary>
    /// Version identifier for the hardware product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/hardwareVersion"></see></summary>
    let ``Hardware/hardwareVersion`` = _prefix "Hardware/hardwareVersion"
    /// <summary>
    /// Identifier for product production batch.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/batchNumber"></see></summary>
    let ``Hardware/batchNumber`` = _prefix "Hardware/batchNumber"
    /// <summary>
    /// Information related to hardware dimension.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/dimensions"></see></summary>
    let ``Hardware/dimensions`` = _prefix "Hardware/dimensions"
    /// <summary>
    /// A point representing the mean position of the matter in a body or system.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/centerOfMass"></see></summary>
    let ``Hardware/centerOfMass`` = _prefix "Hardware/centerOfMass"
    /// <summary>
    /// Information related to massOfHardware physical hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/massOfHardware"></see></summary>
    let ``Hardware/massOfHardware`` = _prefix "Hardware/massOfHardware"
    /// <summary>
    /// Version identifier for the item.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/itemVersion"></see></summary>
    let ``Hardware/itemVersion`` = _prefix "Hardware/itemVersion"

    /// <summary>
    /// VirtualHardwareModelType sets the VirtualHardware Model Type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType"></see></summary>
    let ``Hardware/VirtualHardwareModelType`` =
        _prefix "Hardware/VirtualHardwareModelType"

    /// <summary>
    /// Simulation the function of the hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/function"></see></summary>
    let ``Hardware/VirtualHardwareModelType/function`` =
        _prefix "Hardware/VirtualHardwareModelType/function"

    /// <summary>
    /// Simulation architectures with precise cycle-level accuracy.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/cycle"></see></summary>
    let ``Hardware/VirtualHardwareModelType/cycle`` =
        _prefix "Hardware/VirtualHardwareModelType/cycle"

    /// <summary>
    /// All other simulation types.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/other"></see></summary>
    let ``Hardware/VirtualHardwareModelType/other`` =
        _prefix "Hardware/VirtualHardwareModelType/other"

    /// <summary>
    /// Information related to virtual hardware simulation.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/virtualHardwareModel"></see></summary>
    let ``Hardware/virtualHardwareModel`` = _prefix "Hardware/virtualHardwareModel"
    /// <summary>
    /// Information related to physical hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Hardware/mass"></see></summary>
    let ``Hardware/mass`` = _prefix "Hardware/mass"

    /// <summary>
    /// Specification basis for the export control classification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/exportControlSpecification"></see></summary>
    let ``Operations/exportControlSpecification`` =
        _prefix "Operations/exportControlSpecification"

    /// <summary>
    /// Weight to express relevance in de minimis consideration.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/weight"></see></summary>
    let ``Operations/weight`` = _prefix "Operations/weight"
    /// <summary>
    /// Expression for the export control classification.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/exportClassification"></see></summary>
    let ``Operations/exportClassification`` = _prefix "Operations/exportClassification"
    /// <summary>
    /// Country for which export controls must be taken into account.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/exportingCountry"></see></summary>
    let ``Operations/exportingCountry`` = _prefix "Operations/exportingCountry"
    /// <summary>
    /// Timestamp, when an assessment was conducted.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/assessmentTimestamp"></see></summary>
    let ``Operations/assessmentTimestamp`` = _prefix "Operations/assessmentTimestamp"
    /// <summary>
    /// Specifies an Element as subject of an assessment.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/assessmentResult"></see></summary>
    let ``Operations/assessmentResult`` = _prefix "Operations/assessmentResult"
    /// <summary>
    /// An entity providing an assessment.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/assessor"></see></summary>
    let ``Operations/assessor`` = _prefix "Operations/assessor"
    /// <summary>
    /// Specifies an Element as subject of an assessment.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/assessedElement"></see></summary>
    let ``Operations/assessedElement`` = _prefix "Operations/assessedElement"
    /// <summary>
    /// Sets the context for an assessment iby specifying the related project.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/assessmentContext"></see></summary>
    let ``Operations/assessmentContext`` = _prefix "Operations/assessmentContext"
    /// <summary>
    /// Time when the project starts or is planned to start.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/projectStartTime"></see></summary>
    let ``Operations/projectStartTime`` = _prefix "Operations/projectStartTime"
    /// <summary>
    /// Time when the project ends or is planned to end.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/projectEndTime"></see></summary>
    let ``Operations/projectEndTime`` = _prefix "Operations/projectEndTime"
    /// <summary>
    /// Owner or Lead of the project.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/projectOwner"></see></summary>
    let ``Operations/projectOwner`` = _prefix "Operations/projectOwner"
    /// <summary>
    /// Sponsor of the project.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/projectSponsor"></see></summary>
    let ``Operations/projectSponsor`` = _prefix "Operations/projectSponsor"
    /// <summary>
    /// Link to the project contract.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/projectContract"></see></summary>
    let ``Operations/projectContract`` = _prefix "Operations/projectContract"
    /// <summary>
    /// Title of the project.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/projectTitle"></see></summary>
    let ``Operations/projectTitle`` = _prefix "Operations/projectTitle"

    /// <summary>
    /// Provides the result of an export control assessment.
    /// <see href="https://spdx.org/rdf/3.1/terms/Operations/exportControlClassificationResult"></see></summary>
    let ``Operations/exportControlClassificationResult`` =
        _prefix "Operations/exportControlClassificationResult"

    /// <summary>
    /// Specifies the CVSS base, temporal, threat, or environmental severity type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType"></see></summary>
    let ``Security/CvssSeverityType`` = _prefix "Security/CvssSeverityType"

    /// <summary>
    /// When a CVSS score is between 9.0 - 10.0.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/critical"></see></summary>
    let ``Security/CvssSeverityType/critical`` =
        _prefix "Security/CvssSeverityType/critical"

    /// <summary>
    /// When a CVSS score is between 7.0 - 8.9.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/high"></see></summary>
    let ``Security/CvssSeverityType/high`` = _prefix "Security/CvssSeverityType/high"
    /// <summary>
    /// When a CVSS score is between 0.1 - 3.9.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/low"></see></summary>
    let ``Security/CvssSeverityType/low`` = _prefix "Security/CvssSeverityType/low"

    /// <summary>
    /// When a CVSS score is between 4.0 - 6.9.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/medium"></see></summary>
    let ``Security/CvssSeverityType/medium`` =
        _prefix "Security/CvssSeverityType/medium"

    /// <summary>
    /// When a CVSS score is 0.0.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/none"></see></summary>
    let ``Security/CvssSeverityType/none`` = _prefix "Security/CvssSeverityType/none"

    /// <summary>
    /// Abstract ancestor class for all vulnerability assessments.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VulnAssessmentRelationship"></see></summary>
    let ``Security/VulnAssessmentRelationship`` =
        _prefix "Security/VulnAssessmentRelationship"

    /// <summary>
    /// Specifies the CVSS vector string for a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/vectorString"></see></summary>
    let ``Security/vectorString`` = _prefix "Security/vectorString"
    /// <summary>
    /// Provides a numerical (0-10) representation of the severity of a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/score"></see></summary>
    let ``Security/score`` = _prefix "Security/score"
    /// <summary>
    /// Specifies the CVSS qualitative severity rating of a vulnerability in relation to a piece of software.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/severity"></see></summary>
    let ``Security/severity`` = _prefix "Security/severity"
    /// <summary>
    /// The percentile of the current probability score.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/percentile"></see></summary>
    let ``Security/percentile`` = _prefix "Security/percentile"
    /// <summary>
    /// A probability score between 0 and 1 of a vulnerability being exploited.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/probability"></see></summary>
    let ``Security/probability`` = _prefix "Security/probability"
    /// <summary>
    /// Specifies the exploit catalog type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType"></see></summary>
    let ``Security/ExploitCatalogType`` = _prefix "Security/ExploitCatalogType"
    /// <summary>
    /// CISA's Known Exploited Vulnerability (KEV) catalog.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType/kev"></see></summary>
    let ``Security/ExploitCatalogType/kev`` = _prefix "Security/ExploitCatalogType/kev"

    /// <summary>
    /// Other exploit catalogs.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType/other"></see></summary>
    let ``Security/ExploitCatalogType/other`` =
        _prefix "Security/ExploitCatalogType/other"

    /// <summary>
    /// Specifies the exploit catalog type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/catalogType"></see></summary>
    let ``Security/catalogType`` = _prefix "Security/catalogType"
    /// <summary>
    /// Provides the location of an exploit catalog.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/locator"></see></summary>
    let ``Security/locator`` = _prefix "Security/locator"
    /// <summary>
    /// Denote whether a CVE is present in an exploit catalog.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/exploited"></see></summary>
    let ``Security/exploited`` = _prefix "Security/exploited"
    /// <summary>
    /// Specifies the SSVC decision type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType"></see></summary>
    let ``Security/SsvcDecisionType`` = _prefix "Security/SsvcDecisionType"
    /// <summary>
    /// The vulnerability requires attention from the organization's internal, supervisory-level and leadership-level individuals. Necessary actions include requesting assistance or information about the vulnerability, as well as publishing a notification either internally and/or externally. Typically, internal groups would meet to determine the overall response and then execute agreed upon actions. CISA recommends remediating Act vulnerabilities as soon as possible.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/act"></see></summary>
    let ``Security/SsvcDecisionType/act`` = _prefix "Security/SsvcDecisionType/act"

    /// <summary>
    /// The vulnerability requires attention from the organization's internal, supervisory-level individuals. Necessary actions include requesting assistance or information about the vulnerability, and may involve publishing a notification either internally and/or externally. CISA recommends remediating Attend vulnerabilities sooner than standard update timelines.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/attend"></see></summary>
    let ``Security/SsvcDecisionType/attend`` =
        _prefix "Security/SsvcDecisionType/attend"

    /// <summary>
    /// The vulnerability does not require action at this time. The organization would continue to track the vulnerability and reassess it if new information becomes available. CISA recommends remediating Track vulnerabilities within standard update timelines.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/track"></see></summary>
    let ``Security/SsvcDecisionType/track`` = _prefix "Security/SsvcDecisionType/track"

    /// <summary>
    /// ("Track\*" in the SSVC spec) The vulnerability contains specific characteristics that may require closer monitoring for changes. CISA recommends remediating Track\* vulnerabilities within standard update timelines.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/trackStar"></see></summary>
    let ``Security/SsvcDecisionType/trackStar`` =
        _prefix "Security/SsvcDecisionType/trackStar"

    /// <summary>
    /// Provide the enumeration of possible decisions in the
    /// [Stakeholder-Specific Vulnerability Categorization (SSVC) decision tree](https://www.cisa.gov/stakeholder-specific-vulnerability-categorization-ssvc).
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/decisionType"></see></summary>
    let ``Security/decisionType`` = _prefix "Security/decisionType"

    /// <summary>
    /// Abstract ancestor class for all VEX relationships.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexVulnAssessmentRelationship"></see></summary>
    let ``Security/VexVulnAssessmentRelationship`` =
        _prefix "Security/VexVulnAssessmentRelationship"

    /// <summary>
    /// Provides advise on how to mitigate or remediate a vulnerability when a VEX product
    /// is affected by it.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/actionStatement"></see></summary>
    let ``Security/actionStatement`` = _prefix "Security/actionStatement"
    /// <summary>
    /// Records the time when a recommended action was communicated in a VEX statement
    /// to mitigate a vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/actionStatementTime"></see></summary>
    let ``Security/actionStatementTime`` = _prefix "Security/actionStatementTime"
    /// <summary>
    /// Specifies the VEX justification type.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType"></see></summary>
    let ``Security/VexJustificationType`` = _prefix "Security/VexJustificationType"

    /// <summary>
    /// The software is not affected because the vulnerable component is not in the product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/componentNotPresent"></see></summary>
    let ``Security/VexJustificationType/componentNotPresent`` =
        _prefix "Security/VexJustificationType/componentNotPresent"

    /// <summary>
    /// Built-in inline controls or mitigations prevent an adversary from leveraging the vulnerability.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/inlineMitigationsAlreadyExist"></see></summary>
    let ``Security/VexJustificationType/inlineMitigationsAlreadyExist`` =
        _prefix "Security/VexJustificationType/inlineMitigationsAlreadyExist"

    /// <summary>
    /// The vulnerable component is present, and the component contains the vulnerable code. However, vulnerable code is used in such a way that an attacker cannot mount any anticipated attack.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary"></see></summary>
    let ``Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary`` =
        _prefix "Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary"

    /// <summary>
    /// The affected code is not reachable through the execution of the code, including non-anticipated states of the product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeNotInExecutePath"></see></summary>
    let ``Security/VexJustificationType/vulnerableCodeNotInExecutePath`` =
        _prefix "Security/VexJustificationType/vulnerableCodeNotInExecutePath"

    /// <summary>
    /// The product is not affected because the code underlying the vulnerability is not present in the product.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeNotPresent"></see></summary>
    let ``Security/VexJustificationType/vulnerableCodeNotPresent`` =
        _prefix "Security/VexJustificationType/vulnerableCodeNotPresent"

    /// <summary>
    /// Explains why a VEX product is not affected by a vulnerability. It is an
    /// alternative in VexNotAffectedVulnAssessmentRelationship to the machine-readable
    /// justification label.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/impactStatement"></see></summary>
    let ``Security/impactStatement`` = _prefix "Security/impactStatement"
    /// <summary>
    /// Impact justification label to be used when linking a vulnerability to an element
    /// representing a VEX product with a VexNotAffectedVulnAssessmentRelationship
    /// relationship.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/justificationType"></see></summary>
    let ``Security/justificationType`` = _prefix "Security/justificationType"
    /// <summary>
    /// Timestamp of impact statement.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/impactStatementTime"></see></summary>
    let ``Security/impactStatementTime`` = _prefix "Security/impactStatementTime"
    /// <summary>
    /// Conveys information about how VEX status was determined.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/statusNotes"></see></summary>
    let ``Security/statusNotes`` = _prefix "Security/statusNotes"
    /// <summary>
    /// Specifies the version of a VEX statement.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/vexVersion"></see></summary>
    let ``Security/vexVersion`` = _prefix "Security/vexVersion"
    /// <summary>
    /// Specifies a time when a vulnerability assessment was modified
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/modifiedTime"></see></summary>
    let ``Security/modifiedTime`` = _prefix "Security/modifiedTime"
    /// <summary>
    /// Specifies the time when a vulnerability was published.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/publishedTime"></see></summary>
    let ``Security/publishedTime`` = _prefix "Security/publishedTime"
    /// <summary>
    /// Specified the time and date when a vulnerability was withdrawn.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/withdrawnTime"></see></summary>
    let ``Security/withdrawnTime`` = _prefix "Security/withdrawnTime"
    /// <summary>
    /// A distinct article or unit related to Software.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwareArtifact"></see></summary>
    let ``Software/SoftwareArtifact`` = _prefix "Software/SoftwareArtifact"
    /// <summary>
    /// Specifies an Element contained in a piece of software where a vulnerability was
    /// found.
    /// <see href="https://spdx.org/rdf/3.1/terms/Security/assessedElement"></see></summary>
    let ``Security/assessedElement`` = _prefix "Security/assessedElement"

    /// <summary>
    /// Protocols which support authentication.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType"></see></summary>
    let ``Service/AuthenticationProtocolType`` =
        _prefix "Service/AuthenticationProtocolType"

    /// <summary>
    /// Certificate Revocation List, or CRL, is a list of revoked certificates that is downloaded from the Certificate Authority (CA).
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/crl"></see></summary>
    let ``Service/AuthenticationProtocolType/crl`` =
        _prefix "Service/AuthenticationProtocolType/crl"

    /// <summary>
    /// Online Certificate Status Protocol, or OCSP, is a common scheme used to maintain the security of a server and other network resources.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/ocsp"></see></summary>
    let ``Service/AuthenticationProtocolType/ocsp`` =
        _prefix "Service/AuthenticationProtocolType/ocsp"

    /// <summary>
    /// An authentication protocol not covered by one of the other AuthenticationProtocolTypes.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/other"></see></summary>
    let ``Service/AuthenticationProtocolType/other`` =
        _prefix "Service/AuthenticationProtocolType/other"

    /// <summary>
    /// Transport Layer Security, or TLS, is a widely adopted security protocol designed to facilitate privacy and data security for communications over the Internet.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/tls"></see></summary>
    let ``Service/AuthenticationProtocolType/tls`` =
        _prefix "Service/AuthenticationProtocolType/tls"

    /// <summary>
    /// Authentication protocol used by a server.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/serverAuthenticationProtocol"></see></summary>
    let ``Service/serverAuthenticationProtocol`` =
        _prefix "Service/serverAuthenticationProtocol"

    /// <summary>
    /// The provider of a SoftwareService.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/provider"></see></summary>
    let ``Service/provider`` = _prefix "Service/provider"
    /// <summary>
    /// Specifies a country code where a software service is hosted.
    /// <see href="https://spdx.org/rdf/3.1/terms/Service/serviceHostingCountry"></see></summary>
    let ``Service/serviceHostingCountry`` = _prefix "Service/serviceHostingCountry"

    /// <summary>
    /// Maps a "LicenseRef-" string for a custom license or a "AdditionRef-" string for
    /// a custom license addition to a `CustomLicense`, a `CustomLicenseAddition`, or a
    /// `SimpleLicensingText`.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/customIdToLicense"></see></summary>
    let ``SimpleLicensing/customIdToLicense`` =
        _prefix "SimpleLicensing/customIdToLicense"

    /// <summary>
    /// A string in the license expression format.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseExpression"></see></summary>
    let ``SimpleLicensing/licenseExpression`` =
        _prefix "SimpleLicensing/licenseExpression"

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
    let ``SimpleLicensing/customIdToUri`` = _prefix "SimpleLicensing/customIdToUri"

    /// <summary>
    /// The version of the SPDX License List used in the license expression.
    /// <see href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseListVersion"></see></summary>
    let ``SimpleLicensing/licenseListVersion`` =
        _prefix "SimpleLicensing/licenseListVersion"

    /// <summary>
    /// Specifies the type of a content identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType"></see></summary>
    let ``Software/ContentIdentifierType`` = _prefix "Software/ContentIdentifierType"

    /// <summary>
    /// [Gitoid](https://www.iana.org/assignments/uri-schemes/prov/gitoid), stands for [Git Object ID](https://git-scm.com/book/en/v2/Git-Internals-Git-Objects). A gitoid of type blob is a unique hash of a binary artifact. A gitoid may represent either an [Artifact Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-identifier-types) for the software artifact or an [Input Manifest Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#input-manifest-identifier) for the software artifact's associated [Artifact Input Manifest](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-input-manifest); this ambiguity exists because the Artifact Input Manifest is itself an artifact, and the gitoid of that artifact is its valid identifier. Gitoids calculated on software artifacts (Snippet, File, or Package Elements) should be recorded in the SPDX 3 SoftwareArtifact's contentIdentifier property. Gitoids calculated on the Artifact Input Manifest (Input Manifest Identifier) should be recorded in the SPDX 3 Element's externalIdentifier property. See [OmniBOR Specification](https://github.com/omnibor/spec/), a minimalistic specification for describing software [Artifact Dependency Graphs](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-dependency-graph-adg).
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType/gitoid"></see></summary>
    let ``Software/ContentIdentifierType/gitoid`` =
        _prefix "Software/ContentIdentifierType/gitoid"

    /// <summary>
    /// SoftWare Hash IDentifier, a persistent intrinsic identifier for digital artifacts, such as files, trees (also known as directories or folders), commits, and other objects typically found in version control systems. The format of the identifiers is defined in the [SWHID specification](https://www.swhid.org/swhid-specification/v1.2/) ([ISO/IEC 18670](https://www.iso.org/standard/89985.html)). They typically look like `swh:1:cnt:94a9ed024d3859793618152ea559a168bbcbb5e2`.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType/swhid"></see></summary>
    let ``Software/ContentIdentifierType/swhid`` =
        _prefix "Software/ContentIdentifierType/swhid"

    /// <summary>
    /// Specifies the type of the content identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/contentIdentifierType"></see></summary>
    let ``Software/contentIdentifierType`` = _prefix "Software/contentIdentifierType"
    /// <summary>
    /// Specifies the value of the content identifier.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/contentIdentifierValue"></see></summary>
    let ``Software/contentIdentifierValue`` = _prefix "Software/contentIdentifierValue"
    /// <summary>
    /// Enumeration of the different kinds of SPDX file.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/FileKindType"></see></summary>
    let ``Software/FileKindType`` = _prefix "Software/FileKindType"
    /// <summary>
    /// The file represents a single file (default).
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/FileKindType/file"></see></summary>
    let ``Software/FileKindType/file`` = _prefix "Software/FileKindType/file"
    /// <summary>
    /// The file represents a directory and all content stored in that directory.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/FileKindType/directory"></see></summary>
    let ``Software/FileKindType/directory`` = _prefix "Software/FileKindType/directory"
    /// <summary>
    /// Describes if a given file is a directory or non-directory kind of file.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/fileKind"></see></summary>
    let ``Software/fileKind`` = _prefix "Software/fileKind"
    /// <summary>
    /// Provides a place for the SPDX data creator to record the package URL string
    /// (in accordance with the Package URL specification) for a software Package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/packageUrl"></see></summary>
    let ``Software/packageUrl`` = _prefix "Software/packageUrl"
    /// <summary>
    /// Records any relevant background information or additional comments
    /// about the origin of the package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/sourceInfo"></see></summary>
    let ``Software/sourceInfo`` = _prefix "Software/sourceInfo"
    /// <summary>
    /// Identify the version of a package.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/packageVersion"></see></summary>
    let ``Software/packageVersion`` = _prefix "Software/packageVersion"
    /// <summary>
    /// A place for the SPDX document creator to record a website that serves as the
    /// package's home page.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/homePage"></see></summary>
    let ``Software/homePage`` = _prefix "Software/homePage"
    /// <summary>
    /// Identifies the download Uniform Resource Identifier for the package at the time
    /// that the document was created.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/downloadLocation"></see></summary>
    let ``Software/downloadLocation`` = _prefix "Software/downloadLocation"
    /// <summary>
    /// Provides a set of values to be used to describe the common types of SBOMs that
    /// tools may create.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType"></see></summary>
    let ``Software/SbomType`` = _prefix "Software/SbomType"
    /// <summary>
    /// SBOM of intended, planned software project or product with included components (some of which may not yet exist) for a new software artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType/design"></see></summary>
    let ``Software/SbomType/design`` = _prefix "Software/SbomType/design"
    /// <summary>
    /// SBOM created directly from the development environment, source files, and included dependencies used to build a product artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType/source"></see></summary>
    let ``Software/SbomType/source`` = _prefix "Software/SbomType/source"
    /// <summary>
    /// SBOM generated as part of the process of building the software to create a releasable artifact (e.g., executable or package) from data such as source files, dependencies, built components, build process ephemeral data, and other SBOMs.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType/build"></see></summary>
    let ``Software/SbomType/build`` = _prefix "Software/SbomType/build"
    /// <summary>
    /// SBOM provides an inventory of software that is present on a system. This may be an assembly of other SBOMs that combines analysis of configuration options, and examination of execution behavior in a (potentially simulated) deployment environment.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType/deployed"></see></summary>
    let ``Software/SbomType/deployed`` = _prefix "Software/SbomType/deployed"
    /// <summary>
    /// SBOM generated through instrumenting the system running the software, to capture only components present in the system, as well as external call-outs or dynamically loaded components. In some contexts, this may also be referred to as an "Instrumented" or "Dynamic" SBOM.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType/runtime"></see></summary>
    let ``Software/SbomType/runtime`` = _prefix "Software/SbomType/runtime"
    /// <summary>
    /// SBOM generated through analysis of artifacts (e.g., executables, packages, containers, and virtual machine images) after its build. Such analysis generally requires a variety of heuristics. In some contexts, this may also be referred to as a "3rd party" SBOM.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SbomType/analyzed"></see></summary>
    let ``Software/SbomType/analyzed`` = _prefix "Software/SbomType/analyzed"
    /// <summary>
    /// Provides information about the type of an SBOM.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/sbomType"></see></summary>
    let ``Software/sbomType`` = _prefix "Software/sbomType"
    /// <summary>
    /// Defines the original host file that the snippet information applies to.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/snippetFromFile"></see></summary>
    let ``Software/snippetFromFile`` = _prefix "Software/snippetFromFile"
    /// <summary>
    /// Defines the line range in the original host file that the snippet information
    /// applies to.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/lineRange"></see></summary>
    let ``Software/lineRange`` = _prefix "Software/lineRange"
    /// <summary>
    /// Defines the byte range in the original host file that the snippet information
    /// applies to.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/byteRange"></see></summary>
    let ``Software/byteRange`` = _prefix "Software/byteRange"
    /// <summary>
    /// Provides information about the primary purpose of an Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose"></see></summary>
    let ``Software/SoftwarePurpose`` = _prefix "Software/SoftwarePurpose"

    /// <summary>
    /// The Element is a software application.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/application"></see></summary>
    let ``Software/SoftwarePurpose/application`` =
        _prefix "Software/SoftwarePurpose/application"

    /// <summary>
    /// The Element is an archived collection of one or more files (.tar, .zip, etc.).
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/archive"></see></summary>
    let ``Software/SoftwarePurpose/archive`` =
        _prefix "Software/SoftwarePurpose/archive"

    /// <summary>
    /// The Element is a bill of materials.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/bom"></see></summary>
    let ``Software/SoftwarePurpose/bom`` = _prefix "Software/SoftwarePurpose/bom"

    /// <summary>
    /// The Element is configuration data.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/configuration"></see></summary>
    let ``Software/SoftwarePurpose/configuration`` =
        _prefix "Software/SoftwarePurpose/configuration"

    /// <summary>
    /// The Element is a container image which can be used by a container runtime application.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/container"></see></summary>
    let ``Software/SoftwarePurpose/container`` =
        _prefix "Software/SoftwarePurpose/container"

    /// <summary>
    /// The Element is data.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/data"></see></summary>
    let ``Software/SoftwarePurpose/data`` = _prefix "Software/SoftwarePurpose/data"
    /// <summary>
    /// The Element refers to a chipset, processor, or electronic board.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/device"></see></summary>
    let ``Software/SoftwarePurpose/device`` = _prefix "Software/SoftwarePurpose/device"

    /// <summary>
    /// The Element refers to a disk image that can be written to a disk, booted in a VM, etc. A disk image typically contains most or all of the components necessary to boot, such as bootloaders, kernels, firmware, userspace, etc.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/diskImage"></see></summary>
    let ``Software/SoftwarePurpose/diskImage`` =
        _prefix "Software/SoftwarePurpose/diskImage"

    /// <summary>
    /// The Element represents software that controls hardware devices.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/deviceDriver"></see></summary>
    let ``Software/SoftwarePurpose/deviceDriver`` =
        _prefix "Software/SoftwarePurpose/deviceDriver"

    /// <summary>
    /// The Element is documentation.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/documentation"></see></summary>
    let ``Software/SoftwarePurpose/documentation`` =
        _prefix "Software/SoftwarePurpose/documentation"

    /// <summary>
    /// The Element is the evidence that a specification or requirement has been fulfilled.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/evidence"></see></summary>
    let ``Software/SoftwarePurpose/evidence`` =
        _prefix "Software/SoftwarePurpose/evidence"

    /// <summary>
    /// The Element is an Artifact that can be run on a computer.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/executable"></see></summary>
    let ``Software/SoftwarePurpose/executable`` =
        _prefix "Software/SoftwarePurpose/executable"

    /// <summary>
    /// The Element is a single file which can be independently distributed (configuration file, statically linked binary, Kubernetes deployment, etc.).
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/file"></see></summary>
    let ``Software/SoftwarePurpose/file`` = _prefix "Software/SoftwarePurpose/file"

    /// <summary>
    /// The Element is a file system image that can be written to a disk (or virtual) partition.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/filesystemImage"></see></summary>
    let ``Software/SoftwarePurpose/filesystemImage`` =
        _prefix "Software/SoftwarePurpose/filesystemImage"

    /// <summary>
    /// The Element provides low level control over a device's hardware.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/firmware"></see></summary>
    let ``Software/SoftwarePurpose/firmware`` =
        _prefix "Software/SoftwarePurpose/firmware"

    /// <summary>
    /// The Element is a software framework.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/framework"></see></summary>
    let ``Software/SoftwarePurpose/framework`` =
        _prefix "Software/SoftwarePurpose/framework"

    /// <summary>
    /// The Element is used to install software on disk.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/install"></see></summary>
    let ``Software/SoftwarePurpose/install`` =
        _prefix "Software/SoftwarePurpose/install"

    /// <summary>
    /// The Element is a software library.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/library"></see></summary>
    let ``Software/SoftwarePurpose/library`` =
        _prefix "Software/SoftwarePurpose/library"

    /// <summary>
    /// The Element is a software manifest.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/manifest"></see></summary>
    let ``Software/SoftwarePurpose/manifest`` =
        _prefix "Software/SoftwarePurpose/manifest"

    /// <summary>
    /// The Element is a machine learning or artificial intelligence model.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/model"></see></summary>
    let ``Software/SoftwarePurpose/model`` = _prefix "Software/SoftwarePurpose/model"
    /// <summary>
    /// The Element is a module of a piece of software.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/module"></see></summary>
    let ``Software/SoftwarePurpose/module`` = _prefix "Software/SoftwarePurpose/module"

    /// <summary>
    /// The Element is an operating system.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/operatingSystem"></see></summary>
    let ``Software/SoftwarePurpose/operatingSystem`` =
        _prefix "Software/SoftwarePurpose/operatingSystem"

    /// <summary>
    /// The Element doesn't fit into any of the other categories.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/other"></see></summary>
    let ``Software/SoftwarePurpose/other`` = _prefix "Software/SoftwarePurpose/other"
    /// <summary>
    /// The Element contains a set of changes to update, fix, or improve another Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/patch"></see></summary>
    let ``Software/SoftwarePurpose/patch`` = _prefix "Software/SoftwarePurpose/patch"

    /// <summary>
    /// The Element represents a runtime environment.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/platform"></see></summary>
    let ``Software/SoftwarePurpose/platform`` =
        _prefix "Software/SoftwarePurpose/platform"

    /// <summary>
    /// The Element provides a requirement needed as input for another Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/requirement"></see></summary>
    let ``Software/SoftwarePurpose/requirement`` =
        _prefix "Software/SoftwarePurpose/requirement"

    /// <summary>
    /// The Element is a single or a collection of source files.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/source"></see></summary>
    let ``Software/SoftwarePurpose/source`` = _prefix "Software/SoftwarePurpose/source"

    /// <summary>
    /// The Element is a plan, guideline or strategy how to create, perform or analyze an application.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/specification"></see></summary>
    let ``Software/SoftwarePurpose/specification`` =
        _prefix "Software/SoftwarePurpose/specification"

    /// <summary>
    /// The Element is a test used to verify functionality on a software element.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/test"></see></summary>
    let ``Software/SoftwarePurpose/test`` = _prefix "Software/SoftwarePurpose/test"
    /// <summary>
    /// Provides information about the primary purpose of the software artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/primaryPurpose"></see></summary>
    let ``Software/primaryPurpose`` = _prefix "Software/primaryPurpose"
    /// <summary>
    /// A canonical, unique, immutable identifier of the artifact content, that may be
    /// used for verifying its identity and/or integrity.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/contentIdentifier"></see></summary>
    let ``Software/contentIdentifier`` = _prefix "Software/contentIdentifier"
    /// <summary>
    /// Provides additional purpose information of the software artifact.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/additionalPurpose"></see></summary>
    let ``Software/additionalPurpose`` = _prefix "Software/additionalPurpose"
    /// <summary>
    /// Identifies the size of a software Artifact, in bytes.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/artifactSize"></see></summary>
    let ``Software/artifactSize`` = _prefix "Software/artifactSize"
    /// <summary>
    /// Identifies the text of one or more copyright notices for a software Package,
    /// File or Snippet, if any.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/copyrightText"></see></summary>
    let ``Software/copyrightText`` = _prefix "Software/copyrightText"
    /// <summary>
    /// Provides a place for the SPDX data creator to record acknowledgement text for
    /// a software Package, File or Snippet.
    /// <see href="https://spdx.org/rdf/3.1/terms/Software/attributionText"></see></summary>
    let ``Software/attributionText`` = _prefix "Software/attributionText"
    /// <summary>
    /// CreationAction represents an event of product creation.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/CreateAction"></see></summary>
    let ``SupplyChain/CreateAction`` = _prefix "SupplyChain/CreateAction"
    /// <summary>
    /// The CreateProcess refers to the abstract process class that can be used to represent the process of creation of a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/CreateProcess"></see></summary>
    let ``SupplyChain/CreateProcess`` = _prefix "SupplyChain/CreateProcess"
    /// <summary>
    /// The action of product use.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/UseAction"></see></summary>
    let ``SupplyChain/UseAction`` = _prefix "SupplyChain/UseAction"
    /// <summary>
    /// The boundary parameters define the area or region needed to describe a boundary.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/boundaryParameter"></see></summary>
    let ``SupplyChain/boundaryParameter`` = _prefix "SupplyChain/boundaryParameter"
    /// <summary>
    /// An actual alteration of a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ModifyAction"></see></summary>
    let ``SupplyChain/ModifyAction`` = _prefix "SupplyChain/ModifyAction"
    /// <summary>
    /// A prescribed alteration of a product.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ModifyProcess"></see></summary>
    let ``SupplyChain/ModifyProcess`` = _prefix "SupplyChain/ModifyProcess"
    /// <summary>
    /// Use Process defines actions used by elements.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/UseProcess"></see></summary>
    let ``SupplyChain/UseProcess`` = _prefix "SupplyChain/UseProcess"
    /// <summary>
    /// The valid state for DefinedStateProcess.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/validState"></see></summary>
    let ``SupplyChain/validState`` = _prefix "SupplyChain/validState"

    /// <summary>
    /// This is the agent that performed the act of destroying the item.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/destructionPerformedBy"></see></summary>
    let ``SupplyChain/destructionPerformedBy`` =
        _prefix "SupplyChain/destructionPerformedBy"

    /// <summary>
    /// The planned location that a good, product or material is inspected.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedInspectionLocation"></see></summary>
    let ``SupplyChain/plannedInspectionLocation`` =
        _prefix "SupplyChain/plannedInspectionLocation"

    /// <summary>
    /// This is the individual, business, or organization who currently manages goods, services, or assets.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/current"></see></summary>
    let ``SupplyChain/current`` = _prefix "SupplyChain/current"

    /// <summary>
    /// The element that has it's responsibility changed.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/responsibilityChangedOn"></see></summary>
    let ``SupplyChain/responsibilityChangedOn`` =
        _prefix "SupplyChain/responsibilityChangedOn"

    /// <summary>
    /// This is the individual, business, or organization who was previously managing goods, services, or assets.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/previous"></see></summary>
    let ``SupplyChain/previous`` = _prefix "SupplyChain/previous"
    /// <summary>
    /// These categories help define sets Responsibility Type.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType"></see></summary>
    let ``SupplyChain/ResponsibilityType`` = _prefix "SupplyChain/ResponsibilityType"

    /// <summary>
    /// Ownership refers to the legal right to control, manage, and benefit from an asset, resource, or responsibility. It establishes authority, accountability, and entitlements over something, whether it's property, a business, intellectual property, or responsibilities.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType/ownership"></see></summary>
    let ``SupplyChain/ResponsibilityType/ownership`` =
        _prefix "SupplyChain/ResponsibilityType/ownership"

    /// <summary>
    /// Custody refers to the responsibility, control, and safekeeping of an asset, person, or legal entity. It involves both physical possession and legal authority over something or someone.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType/custody"></see></summary>
    let ``SupplyChain/ResponsibilityType/custody`` =
        _prefix "SupplyChain/ResponsibilityType/custody"

    /// <summary>
    /// Requirements can be categorized into various types based on their focus, purpose, and scope.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/responsibilityCategory"></see></summary>
    let ``SupplyChain/responsibilityCategory`` =
        _prefix "SupplyChain/responsibilityCategory"

    /// <summary>
    /// This is the planned individual, business, or organization who currently manages goods, services, or assets.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedCurrent"></see></summary>
    let ``SupplyChain/plannedCurrent`` = _prefix "SupplyChain/plannedCurrent"

    /// <summary>
    /// This is the planned product associated with the change of responsibility.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedProductOfResponsibilityChange"></see></summary>
    let ``SupplyChain/plannedProductOfResponsibilityChange`` =
        _prefix "SupplyChain/plannedProductOfResponsibilityChange"

    /// <summary>
    /// This is the planned individual, business, or organization who was previously managing goods, services, or assets.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedPrevious"></see></summary>
    let ``SupplyChain/plannedPrevious`` = _prefix "SupplyChain/plannedPrevious"
    /// <summary>
    /// This is the state of an affected Element.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/currentState"></see></summary>
    let ``SupplyChain/currentState`` = _prefix "SupplyChain/currentState"
    /// <summary>
    /// This is how the currentState of an affected Element is found.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/decisionProcess"></see></summary>
    let ``SupplyChain/decisionProcess`` = _prefix "SupplyChain/decisionProcess"

    /// <summary>
    /// The planned location that a good, product or material is stored.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedStorageLocation"></see></summary>
    let ``SupplyChain/plannedStorageLocation`` =
        _prefix "SupplyChain/plannedStorageLocation"

    /// <summary>
    /// The location for picking up a package or item.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/pickupLocation"></see></summary>
    let ``SupplyChain/pickupLocation`` = _prefix "SupplyChain/pickupLocation"
    /// <summary>
    /// The location for dropping off or delivering a package or item.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/dropoffLocation"></see></summary>
    let ``SupplyChain/dropoffLocation`` = _prefix "SupplyChain/dropoffLocation"
    /// <summary>
    /// A transport route refers to the specific path or network used to move people, goods, data, or resources from one location to another.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/transportRoute"></see></summary>
    let ``SupplyChain/transportRoute`` = _prefix "SupplyChain/transportRoute"
    /// <summary>
    /// The location for picking up a package or item.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/forPickupLocation"></see></summary>
    let ``SupplyChain/forPickupLocation`` = _prefix "SupplyChain/forPickupLocation"

    /// <summary>
    /// A transport route refers to the planned path or network used to move people, goods, data, or resources from one location to another.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedTransportRoutes"></see></summary>
    let ``SupplyChain/plannedTransportRoutes`` =
        _prefix "SupplyChain/plannedTransportRoutes"

    /// <summary>
    /// The location that an item will be dropping off or delivered.
    /// <see href="https://spdx.org/rdf/3.1/terms/SupplyChain/forDropoffLocation"></see></summary>
    let ``SupplyChain/forDropoffLocation`` = _prefix "SupplyChain/forDropoffLocation"
