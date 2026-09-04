#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lslife =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#" "lslife"

    /// <summary>
    ///   <para>sio:comment : An executable experiment specification specifies a modelling algorithm, a modelling scenario and an ocurrence set to generate a species distribution model.^^xsd:string</para>
    ///   <para>rdfs:label : executable experiment specification^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutableExperimentSpecification">lslife:ExecutableExperimentSpecification</a>
    /// </summary>
    let ExecutableExperimentSpecification =
        _prefixId.prefix "ExecutableExperimentSpecification"

    /// <summary>
    ///   <para>sio:comment : An executed experiment specification provides an experiment result.^^xsd:string</para>
    ///   <para>rdfs:label : executed experiment specification^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutedExperimentSpecification">lslife:ExecutedExperimentSpecification</a>
    /// </summary>
    let ExecutedExperimentSpecification =
        _prefixId.prefix "ExecutedExperimentSpecification"

    /// <summary>
    ///   <para>sio:comment : A dataset that is the output of a WCS service.^^xsd:string</para>
    ///   <para>rdfs:label : executed wcs dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutedWCSDataset">lslife:ExecutedWCSDataset</a>
    /// </summary>
    let ExecutedWCSDataset = _prefixId.prefix "ExecutedWCSDataset"
    /// <summary>
    ///   <para>rdfs:label : experiment result^^xsd:string</para>
    ///   <para>rdfs:comment : An experiment result provides a result ID and a URL where the result of an experiment can be retrieved.^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExperimentResult">lslife:ExperimentResult</a>
    /// </summary>
    let ExperimentResult = _prefixId.prefix "ExperimentResult"
    /// <summary>
    ///   <para>sio:comment : The TIFF dataset that contains the extracted payload from a WCS response.^^xsd:string</para>
    ///   <para>rdfs:label : extracted wcs response^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExtractedWCSResponse">lslife:ExtractedWCSResponse</a>
    /// </summary>
    let ExtractedWCSResponse = _prefixId.prefix "ExtractedWCSResponse"
    /// <summary>
    ///   <para>sio:comment : A dataset that is required as an input to a WCS service.^^xsd:string</para>
    ///   <para>rdfs:label : input wcs dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#InputWCSDataset">lslife:InputWCSDataset</a>
    /// </summary>
    let InputWCSDataset = _prefixId.prefix "InputWCSDataset"

    /// <summary>
    ///   <para>sio:comment : An experiment specification that provides an input wcs dataset.^^xsd:string</para>
    ///   <para>rdfs:label : input wcs dataset experiment specification^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#InputWCSDatasetExperimentSpecification">lslife:InputWCSDatasetExperimentSpecification</a>
    /// </summary>
    let InputWCSDatasetExperimentSpecification =
        _prefixId.prefix "InputWCSDatasetExperimentSpecification"

    /// <summary>
    ///   <para>sio:comment : The location of an experiment specification in the JSON format.^^xsd:string</para>
    ///   <para>rdfs:label : json experiment specification^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#JSONExperimentSpecification">lslife:JSONExperimentSpecification</a>
    /// </summary>
    let JSONExperimentSpecification = _prefixId.prefix "JSONExperimentSpecification"
    /// <summary>
    ///   <para>sio:comment : A unit of data (i.e. dataset) that is used as a component of a scenario specification.^^xsd:string</para>
    ///   <para>rdfs:label : layer^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Layer">lslife:Layer</a>
    /// </summary>
    let Layer = _prefixId.prefix "Layer"
    /// <summary>
    ///   <para>sio:comment : A species modelling algorithm provided by lifemapper that is controlled by lifemapper parameters.^^xsd:string</para>
    ///   <para>rdfs:label : lifemapper algorithm^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperAlgorithm">lslife:LifemapperAlgorithm</a>
    /// </summary>
    let LifemapperAlgorithm = _prefixId.prefix "LifemapperAlgorithm"
    /// <summary>
    ///   <para>sio:comment : A species modelling parameter that controls the behavior of a lifemapper algorithm.^^xsd:string</para>
    ///   <para>rdfs:label : lifemapper parameter^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperParameter">lslife:LifemapperParameter</a>
    /// </summary>
    let LifemapperParameter = _prefixId.prefix "LifemapperParameter"
    /// <summary>
    ///   <para>sio:comment : A set of parameters that controls the behaviour of a specific lifemapper algorithm.^^xsd:string</para>
    ///   <para>rdfs:label : lifemapper parameters^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperParameters">lslife:LifemapperParameters</a>
    /// </summary>
    let LifemapperParameters = _prefixId.prefix "LifemapperParameters"
    /// <summary>
    ///   <para>sio:comment : A species modelling software provided by lifemapper.^^xsd:string</para>
    ///   <para>rdfs:label : lifemapper software^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperSoftware">lslife:LifemapperSoftware</a>
    /// </summary>
    let LifemapperSoftware = _prefixId.prefix "LifemapperSoftware"
    /// <summary>
    ///   <para>sio:comment : A modelling scenario provides the specification of an experiment that can be executed.^^xsd:string</para>
    ///   <para>rdfs:label : modelling scenario^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ModellingScenario">lslife:ModellingScenario</a>
    /// </summary>
    let ModellingScenario = _prefixId.prefix "ModellingScenario"
    /// <summary>
    ///   <para>sio:comment : The description of an algorithm parameter.^^xsd:string</para>
    ///   <para>rdfs:label : parameter description^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ParameterDescription">lslife:ParameterDescription</a>
    /// </summary>
    let ParameterDescription = _prefixId.prefix "ParameterDescription"
    /// <summary>
    ///   <para>sio:comment : A set of parameter descriptions.^^xsd:string</para>
    ///   <para>rdfs:label : parameter descriptions^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ParameterDescriptions">lslife:ParameterDescriptions</a>
    /// </summary>
    let ParameterDescriptions = _prefixId.prefix "ParameterDescriptions"
    /// <summary>
    ///   <para>sio:comment : A scenario that has been posted.^^xsd:string</para>
    ///   <para>rdfs:label : posted scenario^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#PostedScenario">lslife:PostedScenario</a>
    /// </summary>
    let PostedScenario = _prefixId.prefix "PostedScenario"
    /// <summary>
    ///   <para>rdfs:label : posted tiff dataset^^xsd:string</para>
    ///   <para>rdfs:comment : A TIFF dataset with information about the layers it contains.^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#PostedTIFFDataset">lslife:PostedTIFFDataset</a>
    /// </summary>
    let PostedTIFFDataset = _prefixId.prefix "PostedTIFFDataset"
    /// <summary>
    ///   <para>sio:comment : A modelling scenario that provides the URL of the specification, an scenario ID and a URL where it can be retrieved.^^xsd:string</para>
    ///   <para>rdfs:label : scenario^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Scenario">lslife:Scenario</a>
    /// </summary>
    let Scenario = _prefixId.prefix "Scenario"
    /// <summary>
    ///   <para>sio:comment : A layer that composes a scenario.^^xsd:string</para>
    ///   <para>rdfs:label : scenario layer^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ScenarioLayer">lslife:ScenarioLayer</a>
    /// </summary>
    let ScenarioLayer = _prefixId.prefix "ScenarioLayer"
    /// <summary>
    ///   <para>sio:comment : A group of living organisms which is the principal natural taxonomic unit.^^xsd:stringsio:comment : Erinus alpinus^^xsd:string</para>
    ///   <para>rdfs:label : species^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Species">lslife:Species</a>
    /// </summary>
    let Species = _prefixId.prefix "Species"
    /// <summary>
    ///   <para>rdfs:label : species occurrence dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceDataset">lslife:SpeciesOccurrenceDataset</a>
    /// </summary>
    let SpeciesOccurrenceDataset = _prefixId.prefix "SpeciesOccurrenceDataset"
    /// <summary>
    ///   <para>rdfs:label : species occurrence layer^^xsd:stringrdfs:label : A layer containing data about species ocurrence.^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceLayer">lslife:SpeciesOccurrenceLayer</a>
    /// </summary>
    let SpeciesOccurrenceLayer = _prefixId.prefix "SpeciesOccurrenceLayer"
    /// <summary>
    ///   <para>sio:comment : An species ocurrence set provides a set of species ocurrences required to generate a disctibution model.^^xsd:string</para>
    ///   <para>rdfs:label : species ocurrence set^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceSet">lslife:SpeciesOccurrenceSet</a>
    /// </summary>
    let SpeciesOccurrenceSet = _prefixId.prefix "SpeciesOccurrenceSet"
    /// <summary>
    ///   <para>sio:comment : A dataset that is represented in TIFF format and provides the location where it can be retrieved, the units of the layers and the type code.^^xsd:string</para>
    ///   <para>rdfs:label : tiff dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#TIFFDataset">lslife:TIFFDataset</a>
    /// </summary>
    let TIFFDataset = _prefixId.prefix "TIFFDataset"
    /// <summary>
    ///   <para>sio:comment : A scenario that has not been posted and is composed by some scenario layer and has a JSON experiment specification URL.^^xsd:string</para>
    ///   <para>rdfs:label : unposted scenario^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#UnpostedScenario">lslife:UnpostedScenario</a>
    /// </summary>
    let UnpostedScenario = _prefixId.prefix "UnpostedScenario"
    /// <summary>
    ///   <para>sio:comment : A response obtained from a WCS server, including the response manifestation, the experiment specification URL, layer units and type code.^^xsd:string</para>
    ///   <para>rdfs:label : wcs response^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#WCSResponse">lslife:WCSResponse</a>
    /// </summary>
    let WCSResponse = _prefixId.prefix "WCSResponse"
    /// <summary>
    ///   <para>rdfs:label : describes behavior of^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#describesBehaviorOf">lslife:describesBehaviorOf</a>
    /// </summary>
    let describesBehaviorOf = _prefixId.prefix "describesBehaviorOf"
    /// <summary>
    ///   <para>rdfs:label : has algorithm code^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasAlgorithmCode">lslife:hasAlgorithmCode</a>
    /// </summary>
    let hasAlgorithmCode = _prefixId.prefix "hasAlgorithmCode"
    /// <summary>
    ///   <para>rdfs:label : has default value^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasDefaultValue">lslife:hasDefaultValue</a>
    /// </summary>
    let hasDefaultValue = _prefixId.prefix "hasDefaultValue"
    /// <summary>
    ///   <para>rdfs:label : has experiment result^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResult">lslife:hasExperimentResult</a>
    /// </summary>
    let hasExperimentResult = _prefixId.prefix "hasExperimentResult"
    /// <summary>
    ///   <para>rdfs:label : has experiment result id^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResultID">lslife:hasExperimentResultID</a>
    /// </summary>
    let hasExperimentResultID = _prefixId.prefix "hasExperimentResultID"
    /// <summary>
    ///   <para>rdfs:label : has experiment result url^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResultURL">lslife:hasExperimentResultURL</a>
    /// </summary>
    let hasExperimentResultURL = _prefixId.prefix "hasExperimentResultURL"
    /// <summary>
    ///   <para>rdfs:label : has extracted payload^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExtractedPayload">lslife:hasExtractedPayload</a>
    /// </summary>
    let hasExtractedPayload = _prefixId.prefix "hasExtractedPayload"
    /// <summary>
    ///   <para>rdfs:label : has genus name^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasGenusName">lslife:hasGenusName</a>
    /// </summary>
    let hasGenusName = _prefixId.prefix "hasGenusName"
    /// <summary>
    ///   <para>rdfs:label : has input wcs dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasInputWCSDataset">lslife:hasInputWCSDataset</a>
    /// </summary>
    let hasInputWCSDataset = _prefixId.prefix "hasInputWCSDataset"

    /// <summary>
    ///   <para>rdfs:label : has json experiment specification  url^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasJSONExperimentSpecificationURL">lslife:hasJSONExperimentSpecificationURL</a>
    /// </summary>
    let hasJSONExperimentSpecificationURL =
        _prefixId.prefix "hasJSONExperimentSpecificationURL"

    /// <summary>
    ///   <para>rdfs:label : has layer id^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerID">lslife:hasLayerID</a>
    /// </summary>
    let hasLayerID = _prefixId.prefix "hasLayerID"
    /// <summary>
    ///   <para>rdfs:label : has layer url^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerURL">lslife:hasLayerURL</a>
    /// </summary>
    let hasLayerURL = _prefixId.prefix "hasLayerURL"
    /// <summary>
    ///   <para>rdfs:label : has layer units^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerUnits">lslife:hasLayerUnits</a>
    /// </summary>
    let hasLayerUnits = _prefixId.prefix "hasLayerUnits"
    /// <summary>
    ///   <para>rdfs:label : has lower bound inclusive^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLowerBoundInclusive">lslife:hasLowerBoundInclusive</a>
    /// </summary>
    let hasLowerBoundInclusive = _prefixId.prefix "hasLowerBoundInclusive"
    /// <summary>
    ///   <para>rdfs:label : has modelling scenario^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasModellingScenario">lslife:hasModellingScenario</a>
    /// </summary>
    let hasModellingScenario = _prefixId.prefix "hasModellingScenario"
    /// <summary>
    ///   <para>rdfs:label : has number of occurrences^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasNumberOfOccurrences">lslife:hasNumberOfOccurrences</a>
    /// </summary>
    let hasNumberOfOccurrences = _prefixId.prefix "hasNumberOfOccurrences"
    /// <summary>
    ///   <para>rdfs:label : has occurrence of species^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasOccurrenceOfSpecies">lslife:hasOccurrenceOfSpecies</a>
    /// </summary>
    let hasOccurrenceOfSpecies = _prefixId.prefix "hasOccurrenceOfSpecies"
    /// <summary>
    ///   <para>rdfs:label : has occurrence set id^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasOccurrenceSetID">lslife:hasOccurrenceSetID</a>
    /// </summary>
    let hasOccurrenceSetID = _prefixId.prefix "hasOccurrenceSetID"
    /// <summary>
    ///   <para>rdfs:label : has parameter class^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterClass">lslife:hasParameterClass</a>
    /// </summary>
    let hasParameterClass = _prefixId.prefix "hasParameterClass"
    /// <summary>
    ///   <para>rdfs:label : has parameter collection class^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterCollectionClass">lslife:hasParameterCollectionClass</a>
    /// </summary>
    let hasParameterCollectionClass = _prefixId.prefix "hasParameterCollectionClass"
    /// <summary>
    ///   <para>rdfs:label : has parameter description^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterDescription">lslife:hasParameterDescription</a>
    /// </summary>
    let hasParameterDescription = _prefixId.prefix "hasParameterDescription"
    /// <summary>
    ///   <para>rdfs:label : has published layer^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasPublishedLayer">lslife:hasPublishedLayer</a>
    /// </summary>
    let hasPublishedLayer = _prefixId.prefix "hasPublishedLayer"
    /// <summary>
    ///   <para>rdfs:label : has published scenario^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasPublishedScenario">lslife:hasPublishedScenario</a>
    /// </summary>
    let hasPublishedScenario = _prefixId.prefix "hasPublishedScenario"
    /// <summary>
    ///   <para>rdfs:label : has scenario id^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioID">lslife:hasScenarioID</a>
    /// </summary>
    let hasScenarioID = _prefixId.prefix "hasScenarioID"
    /// <summary>
    ///   <para>rdfs:label : has scenario layer^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioLayer">lslife:hasScenarioLayer</a>
    /// </summary>
    let hasScenarioLayer = _prefixId.prefix "hasScenarioLayer"
    /// <summary>
    ///   <para>rdfs:label : has scenario url^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioURL">lslife:hasScenarioURL</a>
    /// </summary>
    let hasScenarioURL = _prefixId.prefix "hasScenarioURL"
    /// <summary>
    ///   <para>rdfs:label : has type code^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasTypeCode">lslife:hasTypeCode</a>
    /// </summary>
    let hasTypeCode = _prefixId.prefix "hasTypeCode"
    /// <summary>
    ///   <para>rdfs:label : has upper bound inclusive^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasUpperBoundInclusive">lslife:hasUpperBoundInclusive</a>
    /// </summary>
    let hasUpperBoundInclusive = _prefixId.prefix "hasUpperBoundInclusive"
    /// <summary>
    ///   <para>rdfs:label : has wcs response^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasWCSResponse">lslife:hasWCSResponse</a>
    /// </summary>
    let hasWCSResponse = _prefixId.prefix "hasWCSResponse"
    /// <summary>
    ///   <para>rdfs:label : is modelling scenaio of^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#isModellingScenarioOf">lslife:isModellingScenarioOf</a>
    /// </summary>
    let isModellingScenarioOf = _prefixId.prefix "isModellingScenarioOf"
    /// <summary>
    ///   <para>rdfs:label : is scenario layer of^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#isScenarioLayerOf">lslife:isScenarioLayerOf</a>
    /// </summary>
    let isScenarioLayerOf = _prefixId.prefix "isScenarioLayerOf"
    /// <summary>
    ///   <para>rdfs:label : specifies modelling algorithm^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesModellingAlgorithm">lslife:specifiesModellingAlgorithm</a>
    /// </summary>
    let specifiesModellingAlgorithm = _prefixId.prefix "specifiesModellingAlgorithm"
    /// <summary>
    ///   <para>rdfs:label : specifies modelling scenario^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesModellingScenario">lslife:specifiesModellingScenario</a>
    /// </summary>
    let specifiesModellingScenario = _prefixId.prefix "specifiesModellingScenario"
    /// <summary>
    ///   <para>rdfs:label : specifies occurrence set^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesOccurrenceSet">lslife:specifiesOccurrenceSet</a>
    /// </summary>
    let specifiesOccurrenceSet = _prefixId.prefix "specifiesOccurrenceSet"
    /// <summary>
    ///   <para>rdfs:label : specifies projection scenario^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesProjectionScenario">lslife:specifiesProjectionScenario</a>
    /// </summary>
    let specifiesProjectionScenario = _prefixId.prefix "specifiesProjectionScenario"
