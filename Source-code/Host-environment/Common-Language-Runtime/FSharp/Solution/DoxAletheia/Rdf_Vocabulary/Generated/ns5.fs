namespace https.spdx.org.rdf._3._1.terms.AI.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ns5 =
    let _namespace_iri = Namespace_Iri ns5 |> NamespaceIRI
    /// <summary>
    ///   <para>spdx:AI/AIPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A Package that contains AI software or an AI model."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/AIPackage">https://spdx.org/rdf/3.1/terms/AI/AIPackage</seealso>
    let AIPackage = Prefixed_Name(ns5, "AIPackage") |> PrefixedName
    /// <summary>
    ///   <para>spdx:AI/EnergyConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A class for describing the energy consumption incurred by an AI model in
    /// different stages of its lifecycle."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/EnergyConsumption">https://spdx.org/rdf/3.1/terms/AI/EnergyConsumption</seealso>
    let EnergyConsumption = Prefixed_Name(ns5, "EnergyConsumption") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/EnergyConsumptionDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"The class that helps note down the quantity of energy consumption and the unit
    /// used for measurement."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/EnergyConsumptionDescription">https://spdx.org/rdf/3.1/terms/AI/EnergyConsumptionDescription</seealso>
    let EnergyConsumptionDescription =
        Prefixed_Name(ns5, "EnergyConsumptionDescription") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/EnergyUnitType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unit of energy consumption."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType">https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType</seealso>
    let EnergyUnitType = Prefixed_Name(ns5, "EnergyUnitType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/EnergyUnitType/kilowattHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:AI/EnergyUnitType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Kilowatt-hour."</para>
    /// labels<para>"kilowattHour"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/kilowattHour">https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/kilowattHour</seealso>
    let ``EnergyUnitType/kilowattHour`` =
        Prefixed_Name(ns5, "EnergyUnitType/kilowattHour") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/EnergyUnitType/megajoule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:AI/EnergyUnitType</para>
    ///   <para>"Megajoule."</para>
    /// labels<para>"megajoule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/megajoule">https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/megajoule</seealso>
    let ``EnergyUnitType/megajoule`` =
        Prefixed_Name(ns5, "EnergyUnitType/megajoule") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/EnergyUnitType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:AI/EnergyUnitType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Any other units of energy measurement."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/other">https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/other</seealso>
    let ``EnergyUnitType/other`` =
        Prefixed_Name(ns5, "EnergyUnitType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/SafetyRiskAssessmentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Safety risk level."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType">https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType</seealso>
    let SafetyRiskAssessmentType =
        Prefixed_Name(ns5, "SafetyRiskAssessmentType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/SafetyRiskAssessmentType/high</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:AI/SafetyRiskAssessmentType</para>
    ///   <para>"The second-highest level of risk posed by an AI system."</para>
    /// labels<para>"high"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/high">https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/high</seealso>
    let ``SafetyRiskAssessmentType/high`` =
        Prefixed_Name(ns5, "SafetyRiskAssessmentType/high") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/SafetyRiskAssessmentType/low</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:AI/SafetyRiskAssessmentType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Low/no risk is posed by an AI system."</para>
    /// labels<para>"low"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/low">https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/low</seealso>
    let ``SafetyRiskAssessmentType/low`` =
        Prefixed_Name(ns5, "SafetyRiskAssessmentType/low") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/SafetyRiskAssessmentType/medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:AI/SafetyRiskAssessmentType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The third-highest level of risk posed by an AI system."</para>
    /// labels<para>"medium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/medium">https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/medium</seealso>
    let ``SafetyRiskAssessmentType/medium`` =
        Prefixed_Name(ns5, "SafetyRiskAssessmentType/medium") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/SafetyRiskAssessmentType/serious</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:AI/SafetyRiskAssessmentType</para>
    ///   <para>"The highest level of risk posed by an AI system."</para>
    /// labels<para>"serious"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/serious">https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/serious</seealso>
    let ``SafetyRiskAssessmentType/serious`` =
        Prefixed_Name(ns5, "SafetyRiskAssessmentType/serious") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/autonomyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"**DEPRECATED in SPDX 3.1.**
    /// Use [/Core/isoAutomationLevel](../../Core/Properties/isoAutomationLevel.md)
    /// instead.
    ///
    /// Indicates whether the system can perform a decision or action without human
    /// involvement or guidance."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/autonomyType">https://spdx.org/rdf/3.1/terms/AI/autonomyType</seealso>
    let autonomyType = Prefixed_Name(ns5, "autonomyType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:AI/domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Domain in which the AI package can be used."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/domain">https://spdx.org/rdf/3.1/terms/AI/domain</seealso>
    let domain = Prefixed_Name(ns5, "domain") |> PrefixedName
    /// <summary>
    ///   <para>spdx:AI/energyConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Energy consumption incurred by an AI model."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/energyConsumption">https://spdx.org/rdf/3.1/terms/AI/energyConsumption</seealso>
    let energyConsumption = Prefixed_Name(ns5, "energyConsumption") |> PrefixedName
    /// <summary>
    ///   <para>spdx:AI/energyQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Energy quantity."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/energyQuantity">https://spdx.org/rdf/3.1/terms/AI/energyQuantity</seealso>
    let energyQuantity = Prefixed_Name(ns5, "energyQuantity") |> PrefixedName
    /// <summary>
    ///   <para>spdx:AI/energyUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Unit in which energy is measured."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/energyUnit">https://spdx.org/rdf/3.1/terms/AI/energyUnit</seealso>
    let energyUnit = Prefixed_Name(ns5, "energyUnit") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/finetuningEnergyConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Energy consumed when finetuning the AI model that is
    /// being used in the AI system."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/finetuningEnergyConsumption">https://spdx.org/rdf/3.1/terms/AI/finetuningEnergyConsumption</seealso>
    let finetuningEnergyConsumption =
        Prefixed_Name(ns5, "finetuningEnergyConsumption") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/hyperparameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Hyperparameter used to build the AI model contained in the AI package."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/hyperparameter">https://spdx.org/rdf/3.1/terms/AI/hyperparameter</seealso>
    let hyperparameter = Prefixed_Name(ns5, "hyperparameter") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/inferenceEnergyConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Energy consumed during inference time by an AI model
    /// that is being used in the AI system."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/inferenceEnergyConsumption">https://spdx.org/rdf/3.1/terms/AI/inferenceEnergyConsumption</seealso>
    let inferenceEnergyConsumption =
        Prefixed_Name(ns5, "inferenceEnergyConsumption") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/informationAboutApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information about the AI software, not including the model description."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/informationAboutApplication">https://spdx.org/rdf/3.1/terms/AI/informationAboutApplication</seealso>
    let informationAboutApplication =
        Prefixed_Name(ns5, "informationAboutApplication") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/informationAboutTraining</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information about different steps of the training process."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/informationAboutTraining">https://spdx.org/rdf/3.1/terms/AI/informationAboutTraining</seealso>
    let informationAboutTraining =
        Prefixed_Name(ns5, "informationAboutTraining") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/limitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Limitation of the AI software."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/limitation">https://spdx.org/rdf/3.1/terms/AI/limitation</seealso>
    let limitation = Prefixed_Name(ns5, "limitation") |> PrefixedName
    /// <summary>
    ///   <para>spdx:AI/metric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Metric used to evaluate the AI model."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/metric">https://spdx.org/rdf/3.1/terms/AI/metric</seealso>
    let metric = Prefixed_Name(ns5, "metric") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/metricDecisionThreshold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Threshold that was used for computation of a metric described in
    /// the metric field."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/metricDecisionThreshold">https://spdx.org/rdf/3.1/terms/AI/metricDecisionThreshold</seealso>
    let metricDecisionThreshold =
        Prefixed_Name(ns5, "metricDecisionThreshold") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/modelDataPreprocessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Preprocessing steps applied to the training data before the model training."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/modelDataPreprocessing">https://spdx.org/rdf/3.1/terms/AI/modelDataPreprocessing</seealso>
    let modelDataPreprocessing =
        Prefixed_Name(ns5, "modelDataPreprocessing") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/modelExplainability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Methods that can be used to explain the results from the AI model."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/modelExplainability">https://spdx.org/rdf/3.1/terms/AI/modelExplainability</seealso>
    let modelExplainability = Prefixed_Name(ns5, "modelExplainability") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/safetyRiskAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Results of general safety risk assessment of the AI system."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/safetyRiskAssessment">https://spdx.org/rdf/3.1/terms/AI/safetyRiskAssessment</seealso>
    let safetyRiskAssessment =
        Prefixed_Name(ns5, "safetyRiskAssessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/standardCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Standard that an artifact is being complied with."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/standardCompliance">https://spdx.org/rdf/3.1/terms/AI/standardCompliance</seealso>
    let standardCompliance = Prefixed_Name(ns5, "standardCompliance") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/trainingEnergyConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Energy consumed when training the AI model that is
    /// being used in the AI system."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/trainingEnergyConsumption">https://spdx.org/rdf/3.1/terms/AI/trainingEnergyConsumption</seealso>
    let trainingEnergyConsumption =
        Prefixed_Name(ns5, "trainingEnergyConsumption") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/typeOfModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Type of the model used in the AI software."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/typeOfModel">https://spdx.org/rdf/3.1/terms/AI/typeOfModel</seealso>
    let typeOfModel = Prefixed_Name(ns5, "typeOfModel") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/useSensitivePersonalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Records if sensitive personal information is used during model training or
    /// could be used during the inference."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/useSensitivePersonalInformation">https://spdx.org/rdf/3.1/terms/AI/useSensitivePersonalInformation</seealso>
    let useSensitivePersonalInformation =
        Prefixed_Name(ns5, "useSensitivePersonalInformation") |> PrefixedName
