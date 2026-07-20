namespace http.ontology.cybershare.utep.edu.ELSEWeb.elseweb_lifemapper.owl.hash

open DoxAletheia

module lslife =
    let _namespace_name =
        "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutableExperimentSpecification"></see>
    /// </summary>
    let ExecutableExperimentSpecification = _prefix "ExecutableExperimentSpecification"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperAlgorithm"></see>
    /// </summary>
    let LifemapperAlgorithm = _prefix "LifemapperAlgorithm"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesModellingAlgorithm"></see>
    /// </summary>
    let specifiesModellingAlgorithm = _prefix "specifiesModellingAlgorithm"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ModellingScenario"></see>
    /// </summary>
    let ModellingScenario = _prefix "ModellingScenario"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesModellingScenario"></see>
    /// </summary>
    let specifiesModellingScenario = _prefix "specifiesModellingScenario"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceSet"></see>
    /// </summary>
    let SpeciesOccurrenceSet = _prefix "SpeciesOccurrenceSet"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesOccurrenceSet"></see>
    /// </summary>
    let specifiesOccurrenceSet = _prefix "specifiesOccurrenceSet"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutedExperimentSpecification"></see>
    /// </summary>
    let ExecutedExperimentSpecification = _prefix "ExecutedExperimentSpecification"
    /// <summary>
    /// An experiment result provides a result ID and a URL where the result of an experiment can be retrieved.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExperimentResult"></see></summary>
    let ExperimentResult = _prefix "ExperimentResult"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResult"></see>
    /// </summary>
    let hasExperimentResult = _prefix "hasExperimentResult"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutedWCSDataset"></see>
    /// </summary>
    let ExecutedWCSDataset = _prefix "ExecutedWCSDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#InputWCSDataset"></see>
    /// </summary>
    let InputWCSDataset = _prefix "InputWCSDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#WCSResponse"></see>
    /// </summary>
    let WCSResponse = _prefix "WCSResponse"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasWCSResponse"></see>
    /// </summary>
    let hasWCSResponse = _prefix "hasWCSResponse"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResultID"></see>
    /// </summary>
    let hasExperimentResultID = _prefix "hasExperimentResultID"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResultURL"></see>
    /// </summary>
    let hasExperimentResultURL = _prefix "hasExperimentResultURL"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExtractedWCSResponse"></see>
    /// </summary>
    let ExtractedWCSResponse = _prefix "ExtractedWCSResponse"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#TIFFDataset"></see>
    /// </summary>
    let TIFFDataset = _prefix "TIFFDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExtractedPayload"></see>
    /// </summary>
    let hasExtractedPayload = _prefix "hasExtractedPayload"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasJSONExperimentSpecificationURL"></see>
    /// </summary>
    let hasJSONExperimentSpecificationURL = _prefix "hasJSONExperimentSpecificationURL"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerUnits"></see>
    /// </summary>
    let hasLayerUnits = _prefix "hasLayerUnits"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasTypeCode"></see>
    /// </summary>
    let hasTypeCode = _prefix "hasTypeCode"

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#InputWCSDatasetExperimentSpecification"></see>
    /// </summary>
    let InputWCSDatasetExperimentSpecification =
        _prefix "InputWCSDatasetExperimentSpecification"

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#JSONExperimentSpecification"></see>
    /// </summary>
    let JSONExperimentSpecification = _prefix "JSONExperimentSpecification"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasInputWCSDataset"></see>
    /// </summary>
    let hasInputWCSDataset = _prefix "hasInputWCSDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Layer"></see>
    /// </summary>
    let Layer = _prefix "Layer"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerID"></see>
    /// </summary>
    let hasLayerID = _prefix "hasLayerID"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerURL"></see>
    /// </summary>
    let hasLayerURL = _prefix "hasLayerURL"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperParameters"></see>
    /// </summary>
    let LifemapperParameters = _prefix "LifemapperParameters"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasAlgorithmCode"></see>
    /// </summary>
    let hasAlgorithmCode = _prefix "hasAlgorithmCode"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperParameter"></see>
    /// </summary>
    let LifemapperParameter = _prefix "LifemapperParameter"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperSoftware"></see>
    /// </summary>
    let LifemapperSoftware = _prefix "LifemapperSoftware"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Scenario"></see>
    /// </summary>
    let Scenario = _prefix "Scenario"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#isModellingScenarioOf"></see>
    /// </summary>
    let isModellingScenarioOf = _prefix "isModellingScenarioOf"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ParameterDescription"></see>
    /// </summary>
    let ParameterDescription = _prefix "ParameterDescription"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterClass"></see>
    /// </summary>
    let hasParameterClass = _prefix "hasParameterClass"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLowerBoundInclusive"></see>
    /// </summary>
    let hasLowerBoundInclusive = _prefix "hasLowerBoundInclusive"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasUpperBoundInclusive"></see>
    /// </summary>
    let hasUpperBoundInclusive = _prefix "hasUpperBoundInclusive"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ParameterDescriptions"></see>
    /// </summary>
    let ParameterDescriptions = _prefix "ParameterDescriptions"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#describesBehaviorOf"></see>
    /// </summary>
    let describesBehaviorOf = _prefix "describesBehaviorOf"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterDescription"></see>
    /// </summary>
    let hasParameterDescription = _prefix "hasParameterDescription"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterCollectionClass"></see>
    /// </summary>
    let hasParameterCollectionClass = _prefix "hasParameterCollectionClass"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#PostedScenario"></see>
    /// </summary>
    let PostedScenario = _prefix "PostedScenario"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#UnpostedScenario"></see>
    /// </summary>
    let UnpostedScenario = _prefix "UnpostedScenario"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasPublishedScenario"></see>
    /// </summary>
    let hasPublishedScenario = _prefix "hasPublishedScenario"
    /// <summary>
    /// A TIFF dataset with information about the layers it contains.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#PostedTIFFDataset"></see></summary>
    let PostedTIFFDataset = _prefix "PostedTIFFDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasPublishedLayer"></see>
    /// </summary>
    let hasPublishedLayer = _prefix "hasPublishedLayer"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioID"></see>
    /// </summary>
    let hasScenarioID = _prefix "hasScenarioID"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioURL"></see>
    /// </summary>
    let hasScenarioURL = _prefix "hasScenarioURL"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ScenarioLayer"></see>
    /// </summary>
    let ScenarioLayer = _prefix "ScenarioLayer"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#isScenarioLayerOf"></see>
    /// </summary>
    let isScenarioLayerOf = _prefix "isScenarioLayerOf"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Species"></see>
    /// </summary>
    let Species = _prefix "Species"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasGenusName"></see>
    /// </summary>
    let hasGenusName = _prefix "hasGenusName"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceDataset"></see>
    /// </summary>
    let SpeciesOccurrenceDataset = _prefix "SpeciesOccurrenceDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceLayer"></see>
    /// </summary>
    let SpeciesOccurrenceLayer = _prefix "SpeciesOccurrenceLayer"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasOccurrenceOfSpecies"></see>
    /// </summary>
    let hasOccurrenceOfSpecies = _prefix "hasOccurrenceOfSpecies"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasNumberOfOccurrences"></see>
    /// </summary>
    let hasNumberOfOccurrences = _prefix "hasNumberOfOccurrences"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasOccurrenceSetID"></see>
    /// </summary>
    let hasOccurrenceSetID = _prefix "hasOccurrenceSetID"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioLayer"></see>
    /// </summary>
    let hasScenarioLayer = _prefix "hasScenarioLayer"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasDefaultValue"></see>
    /// </summary>
    let hasDefaultValue = _prefix "hasDefaultValue"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasModellingScenario"></see>
    /// </summary>
    let hasModellingScenario = _prefix "hasModellingScenario"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesProjectionScenario"></see>
    /// </summary>
    let specifiesProjectionScenario = _prefix "specifiesProjectionScenario"
