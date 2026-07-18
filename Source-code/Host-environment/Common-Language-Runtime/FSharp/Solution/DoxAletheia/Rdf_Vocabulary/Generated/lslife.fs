namespace http.ontology.cybershare.utep.edu.ELSEWeb.elseweb_lifemapper.owl.hash

open DoxAletheia.Rdf_Vocabulary

module lslife =
    let _namespace_name =
        "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#"

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutableExperimentSpecification"></see>
    /// </summary>
    let ExecutableExperimentSpecification =
        Namespaced_IRI.parse _namespace_name "ExecutableExperimentSpecification" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperAlgorithm"></see>
    /// </summary>
    let LifemapperAlgorithm =
        Namespaced_IRI.parse _namespace_name "LifemapperAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesModellingAlgorithm"></see>
    /// </summary>
    let specifiesModellingAlgorithm =
        Namespaced_IRI.parse _namespace_name "specifiesModellingAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ModellingScenario"></see>
    /// </summary>
    let ModellingScenario =
        Namespaced_IRI.parse _namespace_name "ModellingScenario" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesModellingScenario"></see>
    /// </summary>
    let specifiesModellingScenario =
        Namespaced_IRI.parse _namespace_name "specifiesModellingScenario" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceSet"></see>
    /// </summary>
    let SpeciesOccurrenceSet =
        Namespaced_IRI.parse _namespace_name "SpeciesOccurrenceSet" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesOccurrenceSet"></see>
    /// </summary>
    let specifiesOccurrenceSet =
        Namespaced_IRI.parse _namespace_name "specifiesOccurrenceSet" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutedExperimentSpecification"></see>
    /// </summary>
    let ExecutedExperimentSpecification =
        Namespaced_IRI.parse _namespace_name "ExecutedExperimentSpecification" |> NamespacedName

    /// <summary>
    /// An experiment result provides a result ID and a URL where the result of an experiment can be retrieved.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExperimentResult"></see></summary>
    let ExperimentResult =
        Namespaced_IRI.parse _namespace_name "ExperimentResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResult"></see>
    /// </summary>
    let hasExperimentResult =
        Namespaced_IRI.parse _namespace_name "hasExperimentResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutedWCSDataset"></see>
    /// </summary>
    let ExecutedWCSDataset =
        Namespaced_IRI.parse _namespace_name "ExecutedWCSDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#InputWCSDataset"></see>
    /// </summary>
    let InputWCSDataset =
        Namespaced_IRI.parse _namespace_name "InputWCSDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#WCSResponse"></see>
    /// </summary>
    let WCSResponse =
        Namespaced_IRI.parse _namespace_name "WCSResponse" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasWCSResponse"></see>
    /// </summary>
    let hasWCSResponse =
        Namespaced_IRI.parse _namespace_name "hasWCSResponse" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResultID"></see>
    /// </summary>
    let hasExperimentResultID =
        Namespaced_IRI.parse _namespace_name "hasExperimentResultID" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResultURL"></see>
    /// </summary>
    let hasExperimentResultURL =
        Namespaced_IRI.parse _namespace_name "hasExperimentResultURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExtractedWCSResponse"></see>
    /// </summary>
    let ExtractedWCSResponse =
        Namespaced_IRI.parse _namespace_name "ExtractedWCSResponse" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#TIFFDataset"></see>
    /// </summary>
    let TIFFDataset =
        Namespaced_IRI.parse _namespace_name "TIFFDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExtractedPayload"></see>
    /// </summary>
    let hasExtractedPayload =
        Namespaced_IRI.parse _namespace_name "hasExtractedPayload" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasJSONExperimentSpecificationURL"></see>
    /// </summary>
    let hasJSONExperimentSpecificationURL =
        Namespaced_IRI.parse _namespace_name "hasJSONExperimentSpecificationURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerUnits"></see>
    /// </summary>
    let hasLayerUnits =
        Namespaced_IRI.parse _namespace_name "hasLayerUnits" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasTypeCode"></see>
    /// </summary>
    let hasTypeCode =
        Namespaced_IRI.parse _namespace_name "hasTypeCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#InputWCSDatasetExperimentSpecification"></see>
    /// </summary>
    let InputWCSDatasetExperimentSpecification =
        Namespaced_IRI.parse _namespace_name "InputWCSDatasetExperimentSpecification" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#JSONExperimentSpecification"></see>
    /// </summary>
    let JSONExperimentSpecification =
        Namespaced_IRI.parse _namespace_name "JSONExperimentSpecification" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasInputWCSDataset"></see>
    /// </summary>
    let hasInputWCSDataset =
        Namespaced_IRI.parse _namespace_name "hasInputWCSDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Layer"></see>
    /// </summary>
    let Layer = Namespaced_IRI.parse _namespace_name "Layer" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerID"></see>
    /// </summary>
    let hasLayerID = Namespaced_IRI.parse _namespace_name "hasLayerID" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerURL"></see>
    /// </summary>
    let hasLayerURL =
        Namespaced_IRI.parse _namespace_name "hasLayerURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperParameters"></see>
    /// </summary>
    let LifemapperParameters =
        Namespaced_IRI.parse _namespace_name "LifemapperParameters" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasAlgorithmCode"></see>
    /// </summary>
    let hasAlgorithmCode =
        Namespaced_IRI.parse _namespace_name "hasAlgorithmCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperParameter"></see>
    /// </summary>
    let LifemapperParameter =
        Namespaced_IRI.parse _namespace_name "LifemapperParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperSoftware"></see>
    /// </summary>
    let LifemapperSoftware =
        Namespaced_IRI.parse _namespace_name "LifemapperSoftware" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Scenario"></see>
    /// </summary>
    let Scenario = Namespaced_IRI.parse _namespace_name "Scenario" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#isModellingScenarioOf"></see>
    /// </summary>
    let isModellingScenarioOf =
        Namespaced_IRI.parse _namespace_name "isModellingScenarioOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ParameterDescription"></see>
    /// </summary>
    let ParameterDescription =
        Namespaced_IRI.parse _namespace_name "ParameterDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterClass"></see>
    /// </summary>
    let hasParameterClass =
        Namespaced_IRI.parse _namespace_name "hasParameterClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLowerBoundInclusive"></see>
    /// </summary>
    let hasLowerBoundInclusive =
        Namespaced_IRI.parse _namespace_name "hasLowerBoundInclusive" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasUpperBoundInclusive"></see>
    /// </summary>
    let hasUpperBoundInclusive =
        Namespaced_IRI.parse _namespace_name "hasUpperBoundInclusive" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ParameterDescriptions"></see>
    /// </summary>
    let ParameterDescriptions =
        Namespaced_IRI.parse _namespace_name "ParameterDescriptions" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#describesBehaviorOf"></see>
    /// </summary>
    let describesBehaviorOf =
        Namespaced_IRI.parse _namespace_name "describesBehaviorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterDescription"></see>
    /// </summary>
    let hasParameterDescription =
        Namespaced_IRI.parse _namespace_name "hasParameterDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterCollectionClass"></see>
    /// </summary>
    let hasParameterCollectionClass =
        Namespaced_IRI.parse _namespace_name "hasParameterCollectionClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#PostedScenario"></see>
    /// </summary>
    let PostedScenario =
        Namespaced_IRI.parse _namespace_name "PostedScenario" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#UnpostedScenario"></see>
    /// </summary>
    let UnpostedScenario =
        Namespaced_IRI.parse _namespace_name "UnpostedScenario" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasPublishedScenario"></see>
    /// </summary>
    let hasPublishedScenario =
        Namespaced_IRI.parse _namespace_name "hasPublishedScenario" |> NamespacedName

    /// <summary>
    /// A TIFF dataset with information about the layers it contains.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#PostedTIFFDataset"></see></summary>
    let PostedTIFFDataset =
        Namespaced_IRI.parse _namespace_name "PostedTIFFDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasPublishedLayer"></see>
    /// </summary>
    let hasPublishedLayer =
        Namespaced_IRI.parse _namespace_name "hasPublishedLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioID"></see>
    /// </summary>
    let hasScenarioID =
        Namespaced_IRI.parse _namespace_name "hasScenarioID" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioURL"></see>
    /// </summary>
    let hasScenarioURL =
        Namespaced_IRI.parse _namespace_name "hasScenarioURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ScenarioLayer"></see>
    /// </summary>
    let ScenarioLayer =
        Namespaced_IRI.parse _namespace_name "ScenarioLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#isScenarioLayerOf"></see>
    /// </summary>
    let isScenarioLayerOf =
        Namespaced_IRI.parse _namespace_name "isScenarioLayerOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Species"></see>
    /// </summary>
    let Species = Namespaced_IRI.parse _namespace_name "Species" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasGenusName"></see>
    /// </summary>
    let hasGenusName =
        Namespaced_IRI.parse _namespace_name "hasGenusName" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceDataset"></see>
    /// </summary>
    let SpeciesOccurrenceDataset =
        Namespaced_IRI.parse _namespace_name "SpeciesOccurrenceDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceLayer"></see>
    /// </summary>
    let SpeciesOccurrenceLayer =
        Namespaced_IRI.parse _namespace_name "SpeciesOccurrenceLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasOccurrenceOfSpecies"></see>
    /// </summary>
    let hasOccurrenceOfSpecies =
        Namespaced_IRI.parse _namespace_name "hasOccurrenceOfSpecies" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasNumberOfOccurrences"></see>
    /// </summary>
    let hasNumberOfOccurrences =
        Namespaced_IRI.parse _namespace_name "hasNumberOfOccurrences" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasOccurrenceSetID"></see>
    /// </summary>
    let hasOccurrenceSetID =
        Namespaced_IRI.parse _namespace_name "hasOccurrenceSetID" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioLayer"></see>
    /// </summary>
    let hasScenarioLayer =
        Namespaced_IRI.parse _namespace_name "hasScenarioLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasDefaultValue"></see>
    /// </summary>
    let hasDefaultValue =
        Namespaced_IRI.parse _namespace_name "hasDefaultValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasModellingScenario"></see>
    /// </summary>
    let hasModellingScenario =
        Namespaced_IRI.parse _namespace_name "hasModellingScenario" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesProjectionScenario"></see>
    /// </summary>
    let specifiesProjectionScenario =
        Namespaced_IRI.parse _namespace_name "specifiesProjectionScenario" |> NamespacedName
