namespace http.ontology.cybershare.utep.edu.ELSEWeb.elseweb_lifemapper.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lslife =
    let _namespace_iri = Namespace_Iri lslife |> NamespaceIRI

    /// <summary>
    ///   <para>lslife:LifemapperAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>lifemapper algorithm</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperAlgorithm">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperAlgorithm</seealso>
    let LifemapperAlgorithm =
        Prefixed_Name(lslife, "LifemapperAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>lslife:specifiesProjectionScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>specifies projection scenario</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesProjectionScenario">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesProjectionScenario</seealso>
    let specifiesProjectionScenario =
        Prefixed_Name(lslife, "specifiesProjectionScenario") |> PrefixedName

    /// <summary>
    ///   <para>lslife:ExecutableExperimentSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>executable experiment specification</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutableExperimentSpecification">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutableExperimentSpecification</seealso>
    let ExecutableExperimentSpecification =
        Prefixed_Name(lslife, "ExecutableExperimentSpecification") |> PrefixedName

    /// <summary>
    ///   <para>lslife:specifiesModellingScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>specifies modelling scenario</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesModellingScenario">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesModellingScenario</seealso>
    let specifiesModellingScenario =
        Prefixed_Name(lslife, "specifiesModellingScenario") |> PrefixedName

    /// <summary>
    ///   <para>lslife:SpeciesOccurrenceSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>species ocurrence set</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceSet">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceSet</seealso>
    let SpeciesOccurrenceSet =
        Prefixed_Name(lslife, "SpeciesOccurrenceSet") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasDefaultValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has default value</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasDefaultValue">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasDefaultValue</seealso>
    let hasDefaultValue = Prefixed_Name(lslife, "hasDefaultValue") |> PrefixedName
    /// <summary>
    ///   <para>lslife:ExperimentResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An experiment result provides a result ID and a URL where the result of an experiment can be retrieved.</para>
    /// labels<para>experiment result</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExperimentResult">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExperimentResult</seealso>
    let ExperimentResult = Prefixed_Name(lslife, "ExperimentResult") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasModellingScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has modelling scenario</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasModellingScenario">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasModellingScenario</seealso>
    let hasModellingScenario =
        Prefixed_Name(lslife, "hasModellingScenario") |> PrefixedName

    /// <summary>
    ///   <para>lslife:specifiesModellingAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>specifies modelling algorithm</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesModellingAlgorithm">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesModellingAlgorithm</seealso>
    let specifiesModellingAlgorithm =
        Prefixed_Name(lslife, "specifiesModellingAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>lslife:specifiesOccurrenceSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>specifies occurrence set</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesOccurrenceSet">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#specifiesOccurrenceSet</seealso>
    let specifiesOccurrenceSet =
        Prefixed_Name(lslife, "specifiesOccurrenceSet") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasExperimentResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has experiment result</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResult">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResult</seealso>
    let hasExperimentResult =
        Prefixed_Name(lslife, "hasExperimentResult") |> PrefixedName

    /// <summary>
    ///   <para>lslife:ExecutedWCSDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>executed wcs dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutedWCSDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutedWCSDataset</seealso>
    let ExecutedWCSDataset = Prefixed_Name(lslife, "ExecutedWCSDataset") |> PrefixedName
    /// <summary>
    ///   <para>lslife:hasWCSResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has wcs response</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasWCSResponse">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasWCSResponse</seealso>
    let hasWCSResponse = Prefixed_Name(lslife, "hasWCSResponse") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasExperimentResultID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has experiment result id</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResultID">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResultID</seealso>
    let hasExperimentResultID =
        Prefixed_Name(lslife, "hasExperimentResultID") |> PrefixedName

    /// <summary>
    ///   <para>lslife:ModellingScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>modelling scenario</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ModellingScenario">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ModellingScenario</seealso>
    let ModellingScenario = Prefixed_Name(lslife, "ModellingScenario") |> PrefixedName
    /// <summary>
    ///   <para>lslife:InputWCSDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>input wcs dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#InputWCSDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#InputWCSDataset</seealso>
    let InputWCSDataset = Prefixed_Name(lslife, "InputWCSDataset") |> PrefixedName
    /// <summary>
    ///   <para>lslife:hasPublishedLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has published layer</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasPublishedLayer">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasPublishedLayer</seealso>
    let hasPublishedLayer = Prefixed_Name(lslife, "hasPublishedLayer") |> PrefixedName
    /// <summary>
    ///   <para>lslife:hasScenarioURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has scenario url</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioURL">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioURL</seealso>
    let hasScenarioURL = Prefixed_Name(lslife, "hasScenarioURL") |> PrefixedName
    /// <summary>
    ///   <para>lslife:hasGenusName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has genus name</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasGenusName">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasGenusName</seealso>
    let hasGenusName = Prefixed_Name(lslife, "hasGenusName") |> PrefixedName
    /// <summary>
    ///   <para>lslife:hasOccurrenceSetID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has occurrence set id</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasOccurrenceSetID">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasOccurrenceSetID</seealso>
    let hasOccurrenceSetID = Prefixed_Name(lslife, "hasOccurrenceSetID") |> PrefixedName
    /// <summary>
    ///   <para>lslife:hasScenarioLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has scenario layer</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioLayer">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioLayer</seealso>
    let hasScenarioLayer = Prefixed_Name(lslife, "hasScenarioLayer") |> PrefixedName

    /// <summary>
    ///   <para>lslife:ExecutedExperimentSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>executed experiment specification</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutedExperimentSpecification">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExecutedExperimentSpecification</seealso>
    let ExecutedExperimentSpecification =
        Prefixed_Name(lslife, "ExecutedExperimentSpecification") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasExperimentResultURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has experiment result url</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResultURL">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExperimentResultURL</seealso>
    let hasExperimentResultURL =
        Prefixed_Name(lslife, "hasExperimentResultURL") |> PrefixedName

    /// <summary>
    ///   <para>lslife:TIFFDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>tiff dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#TIFFDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#TIFFDataset</seealso>
    let TIFFDataset = Prefixed_Name(lslife, "TIFFDataset") |> PrefixedName
    /// <summary>
    ///   <para>lslife:WCSResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>wcs response</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#WCSResponse">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#WCSResponse</seealso>
    let WCSResponse = Prefixed_Name(lslife, "WCSResponse") |> PrefixedName

    /// <summary>
    ///   <para>lslife:ExtractedWCSResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>extracted wcs response</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExtractedWCSResponse">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ExtractedWCSResponse</seealso>
    let ExtractedWCSResponse =
        Prefixed_Name(lslife, "ExtractedWCSResponse") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasExtractedPayload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has extracted payload</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExtractedPayload">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasExtractedPayload</seealso>
    let hasExtractedPayload =
        Prefixed_Name(lslife, "hasExtractedPayload") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasJSONExperimentSpecificationURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has json experiment specification  url</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasJSONExperimentSpecificationURL">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasJSONExperimentSpecificationURL</seealso>
    let hasJSONExperimentSpecificationURL =
        Prefixed_Name(lslife, "hasJSONExperimentSpecificationURL") |> PrefixedName

    /// <summary>
    ///   <para>lslife:InputWCSDatasetExperimentSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>input wcs dataset experiment specification</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#InputWCSDatasetExperimentSpecification">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#InputWCSDatasetExperimentSpecification</seealso>
    let InputWCSDatasetExperimentSpecification =
        Prefixed_Name(lslife, "InputWCSDatasetExperimentSpecification") |> PrefixedName

    /// <summary>
    ///   <para>lslife:Layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>layer</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Layer">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Layer</seealso>
    let Layer = Prefixed_Name(lslife, "Layer") |> PrefixedName
    /// <summary>
    ///   <para>lslife:hasTypeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has type code</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasTypeCode">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasTypeCode</seealso>
    let hasTypeCode = Prefixed_Name(lslife, "hasTypeCode") |> PrefixedName
    /// <summary>
    ///   <para>lslife:hasInputWCSDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has input wcs dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasInputWCSDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasInputWCSDataset</seealso>
    let hasInputWCSDataset = Prefixed_Name(lslife, "hasInputWCSDataset") |> PrefixedName
    /// <summary>
    ///   <para>lslife:hasLayerUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has layer units</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerUnits">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerUnits</seealso>
    let hasLayerUnits = Prefixed_Name(lslife, "hasLayerUnits") |> PrefixedName

    /// <summary>
    ///   <para>lslife:JSONExperimentSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>json experiment specification</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#JSONExperimentSpecification">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#JSONExperimentSpecification</seealso>
    let JSONExperimentSpecification =
        Prefixed_Name(lslife, "JSONExperimentSpecification") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasLayerID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has layer id</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerID">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerID</seealso>
    let hasLayerID = Prefixed_Name(lslife, "hasLayerID") |> PrefixedName
    /// <summary>
    ///   <para>lslife:hasLayerURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has layer url</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerURL">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLayerURL</seealso>
    let hasLayerURL = Prefixed_Name(lslife, "hasLayerURL") |> PrefixedName

    /// <summary>
    ///   <para>lslife:LifemapperParameters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>lifemapper parameters</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperParameters">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperParameters</seealso>
    let LifemapperParameters =
        Prefixed_Name(lslife, "LifemapperParameters") |> PrefixedName

    /// <summary>
    ///   <para>lslife:LifemapperParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>lifemapper parameter</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperParameter">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperParameter</seealso>
    let LifemapperParameter =
        Prefixed_Name(lslife, "LifemapperParameter") |> PrefixedName

    /// <summary>
    ///   <para>lslife:LifemapperSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>lifemapper software</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperSoftware">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#LifemapperSoftware</seealso>
    let LifemapperSoftware = Prefixed_Name(lslife, "LifemapperSoftware") |> PrefixedName

    /// <summary>
    ///   <para>lslife:isModellingScenarioOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is modelling scenaio of</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#isModellingScenarioOf">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#isModellingScenarioOf</seealso>
    let isModellingScenarioOf =
        Prefixed_Name(lslife, "isModellingScenarioOf") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasLowerBoundInclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has lower bound inclusive</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLowerBoundInclusive">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasLowerBoundInclusive</seealso>
    let hasLowerBoundInclusive =
        Prefixed_Name(lslife, "hasLowerBoundInclusive") |> PrefixedName

    /// <summary>
    ///   <para>lslife:ParameterDescriptions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>parameter descriptions</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ParameterDescriptions">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ParameterDescriptions</seealso>
    let ParameterDescriptions =
        Prefixed_Name(lslife, "ParameterDescriptions") |> PrefixedName

    /// <summary>
    ///   <para>lslife:PostedScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>posted scenario</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#PostedScenario">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#PostedScenario</seealso>
    let PostedScenario = Prefixed_Name(lslife, "PostedScenario") |> PrefixedName
    /// <summary>
    ///   <para>lslife:PostedTIFFDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A TIFF dataset with information about the layers it contains.</para>
    /// labels<para>posted tiff dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#PostedTIFFDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#PostedTIFFDataset</seealso>
    let PostedTIFFDataset = Prefixed_Name(lslife, "PostedTIFFDataset") |> PrefixedName
    /// <summary>
    ///   <para>lslife:hasScenarioID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has scenario id</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioID">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasScenarioID</seealso>
    let hasScenarioID = Prefixed_Name(lslife, "hasScenarioID") |> PrefixedName
    /// <summary>
    ///   <para>lslife:ScenarioLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>scenario layer</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ScenarioLayer">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ScenarioLayer</seealso>
    let ScenarioLayer = Prefixed_Name(lslife, "ScenarioLayer") |> PrefixedName
    /// <summary>
    ///   <para>lslife:isScenarioLayerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is scenario layer of</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#isScenarioLayerOf">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#isScenarioLayerOf</seealso>
    let isScenarioLayerOf = Prefixed_Name(lslife, "isScenarioLayerOf") |> PrefixedName
    /// <summary>
    ///   <para>lslife:Species</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>species</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Species">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Species</seealso>
    let Species = Prefixed_Name(lslife, "Species") |> PrefixedName

    /// <summary>
    ///   <para>lslife:SpeciesOccurrenceDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>species occurrence dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceDataset</seealso>
    let SpeciesOccurrenceDataset =
        Prefixed_Name(lslife, "SpeciesOccurrenceDataset") |> PrefixedName

    /// <summary>
    ///   <para>lslife:SpeciesOccurrenceLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A layer containing data about species ocurrence.</para><para>species occurrence layer</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceLayer">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#SpeciesOccurrenceLayer</seealso>
    let SpeciesOccurrenceLayer =
        Prefixed_Name(lslife, "SpeciesOccurrenceLayer") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasOccurrenceOfSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has occurrence of species</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasOccurrenceOfSpecies">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasOccurrenceOfSpecies</seealso>
    let hasOccurrenceOfSpecies =
        Prefixed_Name(lslife, "hasOccurrenceOfSpecies") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasNumberOfOccurrences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has number of occurrences</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasNumberOfOccurrences">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasNumberOfOccurrences</seealso>
    let hasNumberOfOccurrences =
        Prefixed_Name(lslife, "hasNumberOfOccurrences") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasAlgorithmCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has algorithm code</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasAlgorithmCode">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasAlgorithmCode</seealso>
    let hasAlgorithmCode = Prefixed_Name(lslife, "hasAlgorithmCode") |> PrefixedName

    /// <summary>
    ///   <para>lslife:ParameterDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>parameter description</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ParameterDescription">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#ParameterDescription</seealso>
    let ParameterDescription =
        Prefixed_Name(lslife, "ParameterDescription") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasUpperBoundInclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has upper bound inclusive</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasUpperBoundInclusive">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasUpperBoundInclusive</seealso>
    let hasUpperBoundInclusive =
        Prefixed_Name(lslife, "hasUpperBoundInclusive") |> PrefixedName

    /// <summary>
    ///   <para>lslife:describesBehaviorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>describes behavior of</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#describesBehaviorOf">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#describesBehaviorOf</seealso>
    let describesBehaviorOf =
        Prefixed_Name(lslife, "describesBehaviorOf") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasParameterDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has parameter description</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterDescription">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterDescription</seealso>
    let hasParameterDescription =
        Prefixed_Name(lslife, "hasParameterDescription") |> PrefixedName

    /// <summary>
    ///   <para>lslife:Scenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>scenario</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Scenario">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#Scenario</seealso>
    let Scenario = Prefixed_Name(lslife, "Scenario") |> PrefixedName
    /// <summary>
    ///   <para>lslife:hasParameterClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has parameter class</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterClass">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterClass</seealso>
    let hasParameterClass = Prefixed_Name(lslife, "hasParameterClass") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasParameterCollectionClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has parameter collection class</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterCollectionClass">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasParameterCollectionClass</seealso>
    let hasParameterCollectionClass =
        Prefixed_Name(lslife, "hasParameterCollectionClass") |> PrefixedName

    /// <summary>
    ///   <para>lslife:hasPublishedScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has published scenario</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasPublishedScenario">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#hasPublishedScenario</seealso>
    let hasPublishedScenario =
        Prefixed_Name(lslife, "hasPublishedScenario") |> PrefixedName

    /// <summary>
    ///   <para>lslife:UnpostedScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>unposted scenario</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#UnpostedScenario">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#UnpostedScenario</seealso>
    let UnpostedScenario = Prefixed_Name(lslife, "UnpostedScenario") |> PrefixedName
