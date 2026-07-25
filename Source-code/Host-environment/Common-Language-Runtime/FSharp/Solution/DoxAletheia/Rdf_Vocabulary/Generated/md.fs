namespace http.def.seegrid.csiro.au.isotc211.iso19115._2003.metadata.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module md =
    let _namespace_iri = Namespace_Iri md |> NamespaceIRI
    /// <summary>
    ///   <para>md:graphicOverview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>graphic overview</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#graphicOverview">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#graphicOverview</seealso>
    let graphicOverview = Prefixed_Name(md, "graphicOverview") |> PrefixedName
    /// <summary>
    ///   <para>md:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>abstract</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#abstract">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#abstract</seealso>
    let abstract_ = Prefixed_Name(md, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>md:topicCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>topic category</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#topicCategory">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#topicCategory</seealso>
    let topicCategory = Prefixed_Name(md, "topicCategory") |> PrefixedName
    /// <summary>
    ///   <para>md:obligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>obligation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#obligation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#obligation</seealso>
    let obligation = Prefixed_Name(md, "obligation") |> PrefixedName
    /// <summary>
    ///   <para>md:distributorFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>distributor format</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributorFormat">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributorFormat</seealso>
    let distributorFormat = Prefixed_Name(md, "distributorFormat") |> PrefixedName
    /// <summary>
    ///   <para>md:schemaLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>schema language</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#schemaLanguage">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#schemaLanguage</seealso>
    let schemaLanguage = Prefixed_Name(md, "schemaLanguage") |> PrefixedName
    /// <summary>
    ///   <para>md:spatialResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>spatial resolution</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#spatialResolution">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#spatialResolution</seealso>
    let spatialResolution = Prefixed_Name(md, "spatialResolution") |> PrefixedName

    /// <summary>
    ///   <para>md:maintenanceAndUpdateFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Value should be chosen from &lt;http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata/MaintenanceFrequenceCode&gt;</para>
    /// labels<para>maintenance and update frequency</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maintenanceAndUpdateFrequency">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maintenanceAndUpdateFrequency</seealso>
    let maintenanceAndUpdateFrequency =
        Prefixed_Name(md, "maintenanceAndUpdateFrequency") |> PrefixedName

    /// <summary>
    ///   <para>md:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>source</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#source">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#source</seealso>
    let source = Prefixed_Name(md, "source") |> PrefixedName
    /// <summary>
    ///   <para>md:useLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>use limitation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#useLimitation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#useLimitation</seealso>
    let useLimitation = Prefixed_Name(md, "useLimitation") |> PrefixedName

    /// <summary>
    ///   <para>md:referenceSystemIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reference system identifier</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#referenceSystemIdentifier">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#referenceSystemIdentifier</seealso>
    let referenceSystemIdentifier =
        Prefixed_Name(md, "referenceSystemIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>md:resourceFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>resource format</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceFormat">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceFormat</seealso>
    let resourceFormat = Prefixed_Name(md, "resourceFormat") |> PrefixedName
    /// <summary>
    ///   <para>md:dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dimension</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dimension">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dimension</seealso>
    let dimension = Prefixed_Name(md, "dimension") |> PrefixedName

    /// <summary>
    ///   <para>md:transformationParameterAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>transformation parameter availability</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transformationParameterAvailability">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transformationParameterAvailability</seealso>
    let transformationParameterAvailability =
        Prefixed_Name(md, "transformationParameterAvailability") |> PrefixedName

    /// <summary>
    ///   <para>md:ScopeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Scope code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ScopeCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ScopeCode</seealso>
    let ScopeCode = Prefixed_Name(md, "ScopeCode") |> PrefixedName

    /// <summary>
    ///   <para>md:transformationDimensionDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>transformation dimension description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transformationDimensionDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transformationDimensionDescription</seealso>
    let transformationDimensionDescription =
        Prefixed_Name(md, "transformationDimensionDescription") |> PrefixedName

    /// <summary>
    ///   <para>md:transferOptions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>transfer options</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transferOptions">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transferOptions</seealso>
    let transferOptions = Prefixed_Name(md, "transferOptions") |> PrefixedName
    /// <summary>
    ///   <para>md:includedWithDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>included with dataset</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#includedWithDataset">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#includedWithDataset</seealso>
    let includedWithDataset = Prefixed_Name(md, "includedWithDataset") |> PrefixedName
    /// <summary>
    ///   <para>md:KeywordTypeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Keyword type code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#KeywordTypeCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#KeywordTypeCode</seealso>
    let KeywordTypeCode = Prefixed_Name(md, "KeywordTypeCode") |> PrefixedName
    /// <summary>
    ///   <para>md:orderingInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ordering instructions</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#orderingInstructions">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#orderingInstructions</seealso>
    let orderingInstructions = Prefixed_Name(md, "orderingInstructions") |> PrefixedName
    /// <summary>
    ///   <para>md:Metadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Metadata record</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Metadata">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Metadata</seealso>
    let Metadata = Prefixed_Name(md, "Metadata") |> PrefixedName
    /// <summary>
    ///   <para>md:geometricObjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>geometric objects</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#geometricObjects">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#geometricObjects</seealso>
    let geometricObjects = Prefixed_Name(md, "geometricObjects") |> PrefixedName
    /// <summary>
    ///   <para>md:geometricObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>geometric object type</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#geometricObjectType">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#geometricObjectType</seealso>
    let geometricObjectType = Prefixed_Name(md, "geometricObjectType") |> PrefixedName

    /// <summary>
    ///   <para>md:FeatureCatalogueDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Feature catalogue description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#FeatureCatalogueDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#FeatureCatalogueDescription</seealso>
    let FeatureCatalogueDescription =
        Prefixed_Name(md, "FeatureCatalogueDescription") |> PrefixedName

    /// <summary>
    ///   <para>md:processingLevelCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>processing level code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#processingLevelCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#processingLevelCode</seealso>
    let processingLevelCode = Prefixed_Name(md, "processingLevelCode") |> PrefixedName
    /// <summary>
    ///   <para>md:citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>citation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#citation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#citation</seealso>
    let citation = Prefixed_Name(md, "citation") |> PrefixedName
    /// <summary>
    ///   <para>md:online</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>online</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#online">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#online</seealso>
    let online = Prefixed_Name(md, "online") |> PrefixedName
    /// <summary>
    ///   <para>md:dimensionName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dimension name</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dimensionName">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dimensionName</seealso>
    let dimensionName = Prefixed_Name(md, "dimensionName") |> PrefixedName

    /// <summary>
    ///   <para>md:aggregateDataSetIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>aggregate data set identifier</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#aggregateDataSetIdentifier">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#aggregateDataSetIdentifier</seealso>
    let aggregateDataSetIdentifier =
        Prefixed_Name(md, "aggregateDataSetIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>md:Distributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Distributor</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Distributor">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Distributor</seealso>
    let Distributor = Prefixed_Name(md, "Distributor") |> PrefixedName
    /// <summary>
    ///   <para>md:resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>resolution</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resolution">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resolution</seealso>
    let resolution = Prefixed_Name(md, "resolution") |> PrefixedName

    /// <summary>
    ///   <para>md:orientationParameterDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>orientation parameter description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#orientationParameterDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#orientationParameterDescription</seealso>
    let orientationParameterDescription =
        Prefixed_Name(md, "orientationParameterDescription") |> PrefixedName

    /// <summary>
    ///   <para>md:filmDistortionInformationAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>film distortion information availability</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#filmDistortionInformationAvailability">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#filmDistortionInformationAvailability</seealso>
    let filmDistortionInformationAvailability =
        Prefixed_Name(md, "filmDistortionInformationAvailability") |> PrefixedName

    /// <summary>
    ///   <para>md:ScopeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Scope description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ScopeDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ScopeDescription</seealso>
    let ScopeDescription = Prefixed_Name(md, "ScopeDescription") |> PrefixedName
    /// <summary>
    ///   <para>md:DatatypeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Datatype code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DatatypeCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DatatypeCode</seealso>
    let DatatypeCode = Prefixed_Name(md, "DatatypeCode") |> PrefixedName
    /// <summary>
    ///   <para>md:Band</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Band</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Band">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Band</seealso>
    let Band = Prefixed_Name(md, "Band") |> PrefixedName

    /// <summary>
    ///   <para>md:orientationParameterAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>orientation parameter availability</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#orientationParameterAvailability">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#orientationParameterAvailability</seealso>
    let orientationParameterAvailability =
        Prefixed_Name(md, "orientationParameterAvailability") |> PrefixedName

    /// <summary>
    ///   <para>md:volumes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>volumes</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#volumes">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#volumes</seealso>
    let volumes = Prefixed_Name(md, "volumes") |> PrefixedName

    /// <summary>
    ///   <para>md:ExtendedElementInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Extended element information</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ExtendedElementInformation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ExtendedElementInformation</seealso>
    let ExtendedElementInformation =
        Prefixed_Name(md, "ExtendedElementInformation") |> PrefixedName

    /// <summary>
    ///   <para>md:accessConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Value should be chosen from &lt;http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata/RestrictionCode&gt;</para>
    /// labels<para>access constraints</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#accessConstraints">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#accessConstraints</seealso>
    let accessConstraints = Prefixed_Name(md, "accessConstraints") |> PrefixedName
    /// <summary>
    ///   <para>md:offLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>off line</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#offLine">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#offLine</seealso>
    let offLine = Prefixed_Name(md, "offLine") |> PrefixedName
    /// <summary>
    ///   <para>md:cellGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>cell geometry</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cellGeometry">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cellGeometry</seealso>
    let cellGeometry = Prefixed_Name(md, "cellGeometry") |> PrefixedName
    /// <summary>
    ///   <para>md:DataIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Data identification</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DataIdentification">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DataIdentification</seealso>
    let DataIdentification = Prefixed_Name(md, "DataIdentification") |> PrefixedName
    /// <summary>
    ///   <para>md:rationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>rationale</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#rationale">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#rationale</seealso>
    let rationale = Prefixed_Name(md, "rationale") |> PrefixedName
    /// <summary>
    ///   <para>md:dimensionSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>dimension size</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dimensionSize">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dimensionSize</seealso>
    let dimensionSize = Prefixed_Name(md, "dimensionSize") |> PrefixedName
    /// <summary>
    ///   <para>md:useConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>use constraints</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#useConstraints">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#useConstraints</seealso>
    let useConstraints = Prefixed_Name(md, "useConstraints") |> PrefixedName

    /// <summary>
    ///   <para>md:metadataStandardVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>metadata standard version</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataStandardVersion">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataStandardVersion</seealso>
    let metadataStandardVersion =
        Prefixed_Name(md, "metadataStandardVersion") |> PrefixedName

    /// <summary>
    ///   <para>md:GeometricObjectTypeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geometric object type code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#GeometricObjectTypeCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#GeometricObjectTypeCode</seealso>
    let GeometricObjectTypeCode =
        Prefixed_Name(md, "GeometricObjectTypeCode") |> PrefixedName

    /// <summary>
    ///   <para>md:domainCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>domain code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#domainCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#domainCode</seealso>
    let domainCode = Prefixed_Name(md, "domainCode") |> PrefixedName
    /// <summary>
    ///   <para>md:ContentInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Content information</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ContentInformation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ContentInformation</seealso>
    let ContentInformation = Prefixed_Name(md, "ContentInformation") |> PrefixedName

    /// <summary>
    ///   <para>md:radiometricCalibrationInformationAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>radiometric calibration information availability</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#radiometricCalibrationInformationAvailability">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#radiometricCalibrationInformationAvailability</seealso>
    let radiometricCalibrationInformationAvailability =
        Prefixed_Name(md, "radiometricCalibrationInformationAvailability") |> PrefixedName

    /// <summary>
    ///   <para>md:Georectified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Georectified</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Georectified">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Georectified</seealso>
    let Georectified = Prefixed_Name(md, "Georectified") |> PrefixedName
    /// <summary>
    ///   <para>md:attributeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>attribute description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#attributeDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#attributeDescription</seealso>
    let attributeDescription = Prefixed_Name(md, "attributeDescription") |> PrefixedName
    /// <summary>
    ///   <para>md:thesaurusName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>thesaurus name</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#thesaurusName">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#thesaurusName</seealso>
    let thesaurusName = Prefixed_Name(md, "thesaurusName") |> PrefixedName

    /// <summary>
    ///   <para>md:georeferencedParameters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>georeferenced parameters</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#georeferencedParameters">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#georeferencedParameters</seealso>
    let georeferencedParameters =
        Prefixed_Name(md, "georeferencedParameters") |> PrefixedName

    /// <summary>
    ///   <para>md:compressionGenerationQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>compression generation quantity</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#compressionGenerationQuantity">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#compressionGenerationQuantity</seealso>
    let compressionGenerationQuantity =
        Prefixed_Name(md, "compressionGenerationQuantity") |> PrefixedName

    /// <summary>
    ///   <para>md:SpatialRepresentationTypeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Spatial representation type code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#SpatialRepresentationTypeCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#SpatialRepresentationTypeCode</seealso>
    let SpatialRepresentationTypeCode =
        Prefixed_Name(md, "SpatialRepresentationTypeCode") |> PrefixedName

    /// <summary>
    ///   <para>md:portrayalCatalogueInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>portrayal catalogue info</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#portrayalCatalogueInfo">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#portrayalCatalogueInfo</seealso>
    let portrayalCatalogueInfo =
        Prefixed_Name(md, "portrayalCatalogueInfo") |> PrefixedName

    /// <summary>
    ///   <para>md:illuminationAzimuthAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>illumination Azimuth Angle</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#illuminationAzimuthAngle">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#illuminationAzimuthAngle</seealso>
    let illuminationAzimuthAngle =
        Prefixed_Name(md, "illuminationAzimuthAngle") |> PrefixedName

    /// <summary>
    ///   <para>md:checkPointDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>check point description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#checkPointDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#checkPointDescription</seealso>
    let checkPointDescription =
        Prefixed_Name(md, "checkPointDescription") |> PrefixedName

    /// <summary>
    ///   <para>md:fileType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>file type</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileType">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileType</seealso>
    let fileType = Prefixed_Name(md, "fileType") |> PrefixedName
    /// <summary>
    ///   <para>md:toneGradation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>tone gradation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#toneGradation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#toneGradation</seealso>
    let toneGradation = Prefixed_Name(md, "toneGradation") |> PrefixedName
    /// <summary>
    ///   <para>md:descriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>descriptor</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#descriptor">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#descriptor</seealso>
    let descriptor = Prefixed_Name(md, "descriptor") |> PrefixedName

    /// <summary>
    ///   <para>md:spatialRepresentationInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>spatial representation info</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#spatialRepresentationInfo">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#spatialRepresentationInfo</seealso>
    let spatialRepresentationInfo =
        Prefixed_Name(md, "spatialRepresentationInfo") |> PrefixedName

    /// <summary>
    ///   <para>md:parentIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>parent identifier</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#parentIdentifier">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#parentIdentifier</seealso>
    let parentIdentifier = Prefixed_Name(md, "parentIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>md:pointInPixel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>point in pixel</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#pointInPixel">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#pointInPixel</seealso>
    let pointInPixel = Prefixed_Name(md, "pointInPixel") |> PrefixedName
    /// <summary>
    ///   <para>md:graphicsFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>graphics file</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#graphicsFile">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#graphicsFile</seealso>
    let graphicsFile = Prefixed_Name(md, "graphicsFile") |> PrefixedName
    /// <summary>
    ///   <para>md:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>type</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#type">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#type</seealso>
    let type_ = Prefixed_Name(md, "type") |> PrefixedName

    /// <summary>
    ///   <para>md:environmentDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>environment description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#environmentDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#environmentDescription</seealso>
    let environmentDescription =
        Prefixed_Name(md, "environmentDescription") |> PrefixedName

    /// <summary>
    ///   <para>md:contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>contact</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#contact">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#contact</seealso>
    let contact = Prefixed_Name(md, "contact") |> PrefixedName
    /// <summary>
    ///   <para>md:Constraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Constraints</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Constraints">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Constraints</seealso>
    let Constraints = Prefixed_Name(md, "Constraints") |> PrefixedName

    /// <summary>
    ///   <para>md:portrayalCatalogueCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>portrayal catalogue citation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#portrayalCatalogueCitation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#portrayalCatalogueCitation</seealso>
    let portrayalCatalogueCitation =
        Prefixed_Name(md, "portrayalCatalogueCitation") |> PrefixedName

    /// <summary>
    ///   <para>md:handlingDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>handling description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#handlingDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#handlingDescription</seealso>
    let handlingDescription = Prefixed_Name(md, "handlingDescription") |> PrefixedName
    /// <summary>
    ///   <para>md:parameterCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>parameter citation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#parameterCitation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#parameterCitation</seealso>
    let parameterCitation = Prefixed_Name(md, "parameterCitation") |> PrefixedName
    /// <summary>
    ///   <para>md:Usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Usage</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Usage">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Usage</seealso>
    let Usage = Prefixed_Name(md, "Usage") |> PrefixedName
    /// <summary>
    ///   <para>md:userNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>user note</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userNote">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userNote</seealso>
    let userNote = Prefixed_Name(md, "userNote") |> PrefixedName
    /// <summary>
    ///   <para>md:density</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>density</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#density">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#density</seealso>
    let density = Prefixed_Name(md, "density") |> PrefixedName
    /// <summary>
    ///   <para>md:SecurityConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Security constraints</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#SecurityConstraints">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#SecurityConstraints</seealso>
    let SecurityConstraints = Prefixed_Name(md, "SecurityConstraints") |> PrefixedName
    /// <summary>
    ///   <para>md:authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>authority</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#authority">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#authority</seealso>
    let authority = Prefixed_Name(md, "authority") |> PrefixedName
    /// <summary>
    ///   <para>md:purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>purpose</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#purpose">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#purpose</seealso>
    let purpose = Prefixed_Name(md, "purpose") |> PrefixedName
    /// <summary>
    ///   <para>md:dataQualityInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>data quality info</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dataQualityInfo">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dataQualityInfo</seealso>
    let dataQualityInfo = Prefixed_Name(md, "dataQualityInfo") |> PrefixedName

    /// <summary>
    ///   <para>md:DigitalTransferOptions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Digital transfer options</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DigitalTransferOptions">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DigitalTransferOptions</seealso>
    let DigitalTransferOptions =
        Prefixed_Name(md, "DigitalTransferOptions") |> PrefixedName

    /// <summary>
    ///   <para>md:fileDecompressionTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>file decompression technique</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileDecompressionTechnique">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileDecompressionTechnique</seealso>
    let fileDecompressionTechnique =
        Prefixed_Name(md, "fileDecompressionTechnique") |> PrefixedName

    /// <summary>
    ///   <para>md:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Format</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Format">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Format</seealso>
    let Format = Prefixed_Name(md, "Format") |> PrefixedName
    /// <summary>
    ///   <para>md:complianceCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>compliance code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#complianceCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#complianceCode</seealso>
    let complianceCode = Prefixed_Name(md, "complianceCode") |> PrefixedName
    /// <summary>
    ///   <para>md:extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>extent</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#extent">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#extent</seealso>
    let extent = Prefixed_Name(md, "extent") |> PrefixedName

    /// <summary>
    ///   <para>md:transformationDimensionMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>transformation dimension mapping</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transformationDimensionMapping">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transformationDimensionMapping</seealso>
    let transformationDimensionMapping =
        Prefixed_Name(md, "transformationDimensionMapping") |> PrefixedName

    /// <summary>
    ///   <para>md:MediumNameCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Medium name code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MediumNameCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MediumNameCode</seealso>
    let MediumNameCode = Prefixed_Name(md, "MediumNameCode") |> PrefixedName

    /// <summary>
    ///   <para>md:MetadataExtensionInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Metadata extension information</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MetadataExtensionInformation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MetadataExtensionInformation</seealso>
    let MetadataExtensionInformation =
        Prefixed_Name(md, "MetadataExtensionInformation") |> PrefixedName

    /// <summary>
    ///   <para>md:AggregateInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Aggregate information</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#AggregateInformation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#AggregateInformation</seealso>
    let AggregateInformation = Prefixed_Name(md, "AggregateInformation") |> PrefixedName
    /// <summary>
    ///   <para>md:minValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>min value</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#minValue">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#minValue</seealso>
    let minValue = Prefixed_Name(md, "minValue") |> PrefixedName
    /// <summary>
    ///   <para>md:ImagingConditionCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Imaging condition code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ImagingConditionCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ImagingConditionCode</seealso>
    let ImagingConditionCode = Prefixed_Name(md, "ImagingConditionCode") |> PrefixedName
    /// <summary>
    ///   <para>md:Keywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Keywords</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Keywords">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Keywords</seealso>
    let Keywords = Prefixed_Name(md, "Keywords") |> PrefixedName

    /// <summary>
    ///   <para>md:softwareDevelopmentFileFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>software development file format</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#softwareDevelopmentFileFormat">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#softwareDevelopmentFileFormat</seealso>
    let softwareDevelopmentFileFormat =
        Prefixed_Name(md, "softwareDevelopmentFileFormat") |> PrefixedName

    /// <summary>
    ///   <para>md:SpatialRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Spatial representation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#SpatialRepresentation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#SpatialRepresentation</seealso>
    let SpatialRepresentation =
        Prefixed_Name(md, "SpatialRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>md:metadataExtensionInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>metadata extension info</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataExtensionInfo">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataExtensionInfo</seealso>
    let metadataExtensionInfo =
        Prefixed_Name(md, "metadataExtensionInfo") |> PrefixedName

    /// <summary>
    ///   <para>md:dateStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>date stamp</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dateStamp">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dateStamp</seealso>
    let dateStamp = Prefixed_Name(md, "dateStamp") |> PrefixedName
    /// <summary>
    ///   <para>md:credit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>credit</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#credit">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#credit</seealso>
    let credit = Prefixed_Name(md, "credit") |> PrefixedName
    /// <summary>
    ///   <para>md:assocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>assocation type</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#assocationType">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#assocationType</seealso>
    let assocationType = Prefixed_Name(md, "assocationType") |> PrefixedName

    /// <summary>
    ///   <para>md:PortrayalCatalogueReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Portrayal catalogue reference</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#PortrayalCatalogueReference">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#PortrayalCatalogueReference</seealso>
    let PortrayalCatalogueReference =
        Prefixed_Name(md, "PortrayalCatalogueReference") |> PrefixedName

    /// <summary>
    ///   <para>md:distributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>distributor</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributor">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributor</seealso>
    let distributor = Prefixed_Name(md, "distributor") |> PrefixedName
    /// <summary>
    ///   <para>md:resourceMaintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>resource maintenance</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceMaintenance">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceMaintenance</seealso>
    let resourceMaintenance = Prefixed_Name(md, "resourceMaintenance") |> PrefixedName
    /// <summary>
    ///   <para>md:descriptiveKeywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>descriptive keywords</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#descriptiveKeywords">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#descriptiveKeywords</seealso>
    let descriptiveKeywords = Prefixed_Name(md, "descriptiveKeywords") |> PrefixedName
    /// <summary>
    ///   <para>md:CellGeometryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cell geometry code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CellGeometryCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CellGeometryCode</seealso>
    let CellGeometryCode = Prefixed_Name(md, "CellGeometryCode") |> PrefixedName
    /// <summary>
    ///   <para>md:specificUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>specific usage</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#specificUsage">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#specificUsage</seealso>
    let specificUsage = Prefixed_Name(md, "specificUsage") |> PrefixedName

    /// <summary>
    ///   <para>md:checkPointAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>check point availability</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#checkPointAvailability">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#checkPointAvailability</seealso>
    let checkPointAvailability =
        Prefixed_Name(md, "checkPointAvailability") |> PrefixedName

    /// <summary>
    ///   <para>md:dataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>data set</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dataSet">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dataSet</seealso>
    let dataSet = Prefixed_Name(md, "dataSet") |> PrefixedName
    /// <summary>
    ///   <para>md:featureType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>feature type</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureType">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureType</seealso>
    let featureType = Prefixed_Name(md, "featureType") |> PrefixedName
    /// <summary>
    ///   <para>md:pointOfContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>point of contact</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#pointOfContact">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#pointOfContact</seealso>
    let pointOfContact = Prefixed_Name(md, "pointOfContact") |> PrefixedName
    /// <summary>
    ///   <para>md:aggregateDataSetName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>aggregate data set name</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#aggregateDataSetName">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#aggregateDataSetName</seealso>
    let aggregateDataSetName = Prefixed_Name(md, "aggregateDataSetName") |> PrefixedName
    /// <summary>
    ///   <para>md:distributionInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>distribution info</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributionInfo">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributionInfo</seealso>
    let distributionInfo = Prefixed_Name(md, "distributionInfo") |> PrefixedName
    /// <summary>
    ///   <para>md:aggregationInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>aggregation info</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#aggregationInfo">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#aggregationInfo</seealso>
    let aggregationInfo = Prefixed_Name(md, "aggregationInfo") |> PrefixedName
    /// <summary>
    ///   <para>md:series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>series</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#series">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#series</seealso>
    let series = Prefixed_Name(md, "series") |> PrefixedName
    /// <summary>
    ///   <para>md:equivalentScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>equivalent scale</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#equivalentScale">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#equivalentScale</seealso>
    let equivalentScale = Prefixed_Name(md, "equivalentScale") |> PrefixedName
    /// <summary>
    ///   <para>md:fileDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>file description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileDescription</seealso>
    let fileDescription = Prefixed_Name(md, "fileDescription") |> PrefixedName
    /// <summary>
    ///   <para>md:peakResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>peak response</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#peakResponse">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#peakResponse</seealso>
    let peakResponse = Prefixed_Name(md, "peakResponse") |> PrefixedName

    /// <summary>
    ///   <para>md:triangulationIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>triangulation indicator</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#triangulationIndicator">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#triangulationIndicator</seealso>
    let triangulationIndicator =
        Prefixed_Name(md, "triangulationIndicator") |> PrefixedName

    /// <summary>
    ///   <para>md:resourceConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>resource constraints</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceConstraints">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceConstraints</seealso>
    let resourceConstraints = Prefixed_Name(md, "resourceConstraints") |> PrefixedName
    /// <summary>
    ///   <para>md:CoverageDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Coverage description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CoverageDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CoverageDescription</seealso>
    let CoverageDescription = Prefixed_Name(md, "CoverageDescription") |> PrefixedName
    /// <summary>
    ///   <para>md:contentInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>content info</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#contentInfo">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#contentInfo</seealso>
    let contentInfo = Prefixed_Name(md, "contentInfo") |> PrefixedName
    /// <summary>
    ///   <para>md:ImageDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Image description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ImageDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ImageDescription</seealso>
    let ImageDescription = Prefixed_Name(md, "ImageDescription") |> PrefixedName

    /// <summary>
    ///   <para>md:userDefinedMaintenanceFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>user defined maintenance frequency</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userDefinedMaintenanceFrequency">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userDefinedMaintenanceFrequency</seealso>
    let userDefinedMaintenanceFrequency =
        Prefixed_Name(md, "userDefinedMaintenanceFrequency") |> PrefixedName

    /// <summary>
    ///   <para>md:MediumFormatCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Medium format code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MediumFormatCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MediumFormatCode</seealso>
    let MediumFormatCode = Prefixed_Name(md, "MediumFormatCode") |> PrefixedName

    /// <summary>
    ///   <para>md:extensionOnLineResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>extension on line resource</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#extensionOnLineResource">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#extensionOnLineResource</seealso>
    let extensionOnLineResource =
        Prefixed_Name(md, "extensionOnLineResource") |> PrefixedName

    /// <summary>
    ///   <para>md:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>version</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#version">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#version</seealso>
    let version = Prefixed_Name(md, "version") |> PrefixedName
    /// <summary>
    ///   <para>md:hierarchyLevelName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hierarchy level name</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#hierarchyLevelName">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#hierarchyLevelName</seealso>
    let hierarchyLevelName = Prefixed_Name(md, "hierarchyLevelName") |> PrefixedName

    /// <summary>
    ///   <para>md:ApplicationSchemaInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Application schema information</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ApplicationSchemaInformation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ApplicationSchemaInformation</seealso>
    let ApplicationSchemaInformation =
        Prefixed_Name(md, "ApplicationSchemaInformation") |> PrefixedName

    /// <summary>
    ///   <para>md:distributionOrderProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>distribution order process</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributionOrderProcess">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributionOrderProcess</seealso>
    let distributionOrderProcess =
        Prefixed_Name(md, "distributionOrderProcess") |> PrefixedName

    /// <summary>
    ///   <para>md:TopologyLevelCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Topology level code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#TopologyLevelCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#TopologyLevelCode</seealso>
    let TopologyLevelCode = Prefixed_Name(md, "TopologyLevelCode") |> PrefixedName
    /// <summary>
    ///   <para>md:TopicCategoryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Topic category code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#TopicCategoryCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#TopicCategoryCode</seealso>
    let TopicCategoryCode = Prefixed_Name(md, "TopicCategoryCode") |> PrefixedName

    /// <summary>
    ///   <para>md:extendedElementInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>extended element information</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#extendedElementInformation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#extendedElementInformation</seealso>
    let extendedElementInformation =
        Prefixed_Name(md, "extendedElementInformation") |> PrefixedName

    /// <summary>
    ///   <para>md:StandardOrderProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Standard order process</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#StandardOrderProcess">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#StandardOrderProcess</seealso>
    let StandardOrderProcess = Prefixed_Name(md, "StandardOrderProcess") |> PrefixedName
    /// <summary>
    ///   <para>md:distributionFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>distribution format</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributionFormat">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributionFormat</seealso>
    let distributionFormat = Prefixed_Name(md, "distributionFormat") |> PrefixedName
    /// <summary>
    ///   <para>md:denominator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>denominator</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#denominator">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#denominator</seealso>
    let denominator = Prefixed_Name(md, "denominator") |> PrefixedName
    /// <summary>
    ///   <para>md:identificationInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>identification info</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#identificationInfo">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#identificationInfo</seealso>
    let identificationInfo = Prefixed_Name(md, "identificationInfo") |> PrefixedName

    /// <summary>
    ///   <para>md:applicationSchemaInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>application schema info</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#applicationSchemaInfo">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#applicationSchemaInfo</seealso>
    let applicationSchemaInfo =
        Prefixed_Name(md, "applicationSchemaInfo") |> PrefixedName

    /// <summary>
    ///   <para>md:specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>specification</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#specification">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#specification</seealso>
    let specification = Prefixed_Name(md, "specification") |> PrefixedName
    /// <summary>
    ///   <para>md:ObligationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>Obligation code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ObligationCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ObligationCode</seealso>
    let ObligationCode = Prefixed_Name(md, "ObligationCode") |> PrefixedName

    /// <summary>
    ///   <para>md:softwareDevelopmentFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>software development file</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#softwareDevelopmentFile">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#softwareDevelopmentFile</seealso>
    let softwareDevelopmentFile =
        Prefixed_Name(md, "softwareDevelopmentFile") |> PrefixedName

    /// <summary>
    ///   <para>md:RestrictionCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Restriction code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#RestrictionCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#RestrictionCode</seealso>
    let RestrictionCode = Prefixed_Name(md, "RestrictionCode") |> PrefixedName

    /// <summary>
    ///   <para>md:VectorSpatialRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Vector spatial representation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#VectorSpatialRepresentation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#VectorSpatialRepresentation</seealso>
    let VectorSpatialRepresentation =
        Prefixed_Name(md, "VectorSpatialRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>md:spatialRepresentationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>spatial representation type</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#spatialRepresentationType">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#spatialRepresentationType</seealso>
    let spatialRepresentationType =
        Prefixed_Name(md, "spatialRepresentationType") |> PrefixedName

    /// <summary>
    ///   <para>md:locale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>locale</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#locale">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#locale</seealso>
    let locale = Prefixed_Name(md, "locale") |> PrefixedName
    /// <summary>
    ///   <para>md:maximumOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>maximum occurrence</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maximumOccurrence">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maximumOccurrence</seealso>
    let maximumOccurrence = Prefixed_Name(md, "maximumOccurrence") |> PrefixedName
    /// <summary>
    ///   <para>md:cornerPoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Sequence members are GM_Point</para>
    /// labels<para>corner point</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cornerPoints">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cornerPoints</seealso>
    let cornerPoints = Prefixed_Name(md, "cornerPoints") |> PrefixedName

    /// <summary>
    ///   <para>md:updateScopeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>update scope description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#updateScopeDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#updateScopeDescription</seealso>
    let updateScopeDescription =
        Prefixed_Name(md, "updateScopeDescription") |> PrefixedName

    /// <summary>
    ///   <para>md:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>keyword</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#keyword">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#keyword</seealso>
    let keyword = Prefixed_Name(md, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>md:amendmentNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>amendment number</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#amendmentNumber">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#amendmentNumber</seealso>
    let amendmentNumber = Prefixed_Name(md, "amendmentNumber") |> PrefixedName
    /// <summary>
    ///   <para>md:sequenceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sequence identifier</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#sequenceIdentifier">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#sequenceIdentifier</seealso>
    let sequenceIdentifier = Prefixed_Name(md, "sequenceIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>md:usageDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>usage date time</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#usageDateTime">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#usageDateTime</seealso>
    let usageDateTime = Prefixed_Name(md, "usageDateTime") |> PrefixedName
    /// <summary>
    ///   <para>md:featureTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>feature types</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureTypes">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureTypes</seealso>
    let featureTypes = Prefixed_Name(md, "featureTypes") |> PrefixedName
    /// <summary>
    ///   <para>md:geometricObjectCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>geometric object count</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#geometricObjectCount">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#geometricObjectCount</seealso>
    let geometricObjectCount = Prefixed_Name(md, "geometricObjectCount") |> PrefixedName
    /// <summary>
    ///   <para>md:classificationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>classification system</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#classificationSystem">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#classificationSystem</seealso>
    let classificationSystem = Prefixed_Name(md, "classificationSystem") |> PrefixedName
    /// <summary>
    ///   <para>md:domainValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>domain value</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#domainValue">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#domainValue</seealso>
    let domainValue = Prefixed_Name(md, "domainValue") |> PrefixedName
    /// <summary>
    ///   <para>md:featureAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>feature attribute</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureAttribute">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureAttribute</seealso>
    let featureAttribute = Prefixed_Name(md, "featureAttribute") |> PrefixedName
    /// <summary>
    ///   <para>md:contentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>content type</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#contentType">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#contentType</seealso>
    let contentType = Prefixed_Name(md, "contentType") |> PrefixedName
    /// <summary>
    ///   <para>md:Distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Distribution</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Distribution">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Distribution</seealso>
    let Distribution = Prefixed_Name(md, "Distribution") |> PrefixedName
    /// <summary>
    ///   <para>md:fees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>fees</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fees">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fees</seealso>
    let fees = Prefixed_Name(md, "fees") |> PrefixedName
    /// <summary>
    ///   <para>md:PixelOrientationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>Pixel orientation code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#PixelOrientationCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#PixelOrientationCode</seealso>
    let PixelOrientationCode = Prefixed_Name(md, "PixelOrientationCode") |> PrefixedName
    /// <summary>
    ///   <para>md:userContactInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>user contact info</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userContactInfo">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userContactInfo</seealso>
    let userContactInfo = Prefixed_Name(md, "userContactInfo") |> PrefixedName

    /// <summary>
    ///   <para>md:GridSpatialRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Grid spatial representation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#GridSpatialRepresentation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#GridSpatialRepresentation</seealso>
    let GridSpatialRepresentation =
        Prefixed_Name(md, "GridSpatialRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>md:MaintenanceFrequencyCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Maintenance frequency code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MaintenanceFrequencyCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MaintenanceFrequencyCode</seealso>
    let MaintenanceFrequencyCode =
        Prefixed_Name(md, "MaintenanceFrequencyCode") |> PrefixedName

    /// <summary>
    ///   <para>md:turnaround</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>turnaround</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#turnaround">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#turnaround</seealso>
    let turnaround = Prefixed_Name(md, "turnaround") |> PrefixedName

    /// <summary>
    ///   <para>md:ApplicationSchema.name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Application schema.name</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ApplicationSchema.name">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ApplicationSchema.name</seealso>
    let ``ApplicationSchema.name`` =
        Prefixed_Name(md, "ApplicationSchema.name") |> PrefixedName

    /// <summary>
    ///   <para>md:DistributionUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Distribution units</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DistributionUnits">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DistributionUnits</seealso>
    let DistributionUnits = Prefixed_Name(md, "DistributionUnits") |> PrefixedName
    /// <summary>
    ///   <para>md:LegalConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Legal constraints</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#LegalConstraints">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#LegalConstraints</seealso>
    let LegalConstraints = Prefixed_Name(md, "LegalConstraints") |> PrefixedName
    /// <summary>
    ///   <para>md:offset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>offset</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#offset">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#offset</seealso>
    let offset = Prefixed_Name(md, "offset") |> PrefixedName

    /// <summary>
    ///   <para>md:featureCatalogueCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>feature catalogue citation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureCatalogueCitation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureCatalogueCitation</seealso>
    let featureCatalogueCitation =
        Prefixed_Name(md, "featureCatalogueCitation") |> PrefixedName

    /// <summary>
    ///   <para>md:Dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Dimension</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Dimension">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Dimension</seealso>
    let Dimension = Prefixed_Name(md, "Dimension") |> PrefixedName

    /// <summary>
    ///   <para>md:distributorTransferOptions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>distributor transfer options</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributorTransferOptions">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributorTransferOptions</seealso>
    let distributorTransferOptions =
        Prefixed_Name(md, "distributorTransferOptions") |> PrefixedName

    /// <summary>
    ///   <para>md:Identification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Identification</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Identification">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Identification</seealso>
    let Identification = Prefixed_Name(md, "Identification") |> PrefixedName
    /// <summary>
    ///   <para>md:rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>rule</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#rule">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#rule</seealso>
    let rule = Prefixed_Name(md, "rule") |> PrefixedName
    /// <summary>
    ///   <para>md:Georeferenceable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Georeferenceable</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Georeferenceable">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Georeferenceable</seealso>
    let Georeferenceable = Prefixed_Name(md, "Georeferenceable") |> PrefixedName
    /// <summary>
    ///   <para>md:Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Medium</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Medium">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Medium</seealso>
    let Medium = Prefixed_Name(md, "Medium") |> PrefixedName
    /// <summary>
    ///   <para>md:distributorContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>distributor contact</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributorContact">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributorContact</seealso>
    let distributorContact = Prefixed_Name(md, "distributorContact") |> PrefixedName
    /// <summary>
    ///   <para>md:ClassificationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Classification code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ClassificationCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ClassificationCode</seealso>
    let ClassificationCode = Prefixed_Name(md, "ClassificationCode") |> PrefixedName

    /// <summary>
    ///   <para>md:axisDimensionProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Sequence members are md:Dimension</para>
    /// labels<para>axis dimension properties</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#axisDimensionProperties">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#axisDimensionProperties</seealso>
    let axisDimensionProperties =
        Prefixed_Name(md, "axisDimensionProperties") |> PrefixedName

    /// <summary>
    ///   <para>md:units</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>units</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#units">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#units</seealso>
    let units = Prefixed_Name(md, "units") |> PrefixedName
    /// <summary>
    ///   <para>md:numberOfDimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>number of dimensions</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#numberOfDimensions">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#numberOfDimensions</seealso>
    let numberOfDimensions = Prefixed_Name(md, "numberOfDimensions") |> PrefixedName

    /// <summary>
    ///   <para>md:userDeterminedLimitations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>user determined limitations</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userDeterminedLimitations">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userDeterminedLimitations</seealso>
    let userDeterminedLimitations =
        Prefixed_Name(md, "userDeterminedLimitations") |> PrefixedName

    /// <summary>
    ///   <para>md:maintenanceNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>maintenance note</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maintenanceNote">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maintenanceNote</seealso>
    let maintenanceNote = Prefixed_Name(md, "maintenanceNote") |> PrefixedName
    /// <summary>
    ///   <para>md:referenceSystemInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reference system info</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#referenceSystemInfo">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#referenceSystemInfo</seealso>
    let referenceSystemInfo = Prefixed_Name(md, "referenceSystemInfo") |> PrefixedName
    /// <summary>
    ///   <para>md:dateOfNextUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>date of next update</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dateOfNextUpdate">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dateOfNextUpdate</seealso>
    let dateOfNextUpdate = Prefixed_Name(md, "dateOfNextUpdate") |> PrefixedName
    /// <summary>
    ///   <para>md:mediumFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>medium format</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#mediumFormat">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#mediumFormat</seealso>
    let mediumFormat = Prefixed_Name(md, "mediumFormat") |> PrefixedName
    /// <summary>
    ///   <para>md:fileIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>file identifier</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileIdentifier">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileIdentifier</seealso>
    let fileIdentifier = Prefixed_Name(md, "fileIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>md:ReferenceSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reference system</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ReferenceSystem">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ReferenceSystem</seealso>
    let ReferenceSystem = Prefixed_Name(md, "ReferenceSystem") |> PrefixedName
    /// <summary>
    ///   <para>md:dataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>data type</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dataType">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dataType</seealso>
    let dataType = Prefixed_Name(md, "dataType") |> PrefixedName
    /// <summary>
    ///   <para>md:cloudCoverPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>cloud cover percentage</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cloudCoverPercentage">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cloudCoverPercentage</seealso>
    let cloudCoverPercentage = Prefixed_Name(md, "cloudCoverPercentage") |> PrefixedName
    /// <summary>
    ///   <para>md:centerPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Sequence members are gm:Point</para>
    /// labels<para>center point</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#centerPoint">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#centerPoint</seealso>
    let centerPoint = Prefixed_Name(md, "centerPoint") |> PrefixedName
    /// <summary>
    ///   <para>md:GeometricObjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geometric objects</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#GeometricObjects">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#GeometricObjects</seealso>
    let GeometricObjects = Prefixed_Name(md, "GeometricObjects") |> PrefixedName
    /// <summary>
    ///   <para>md:updateScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Value should be chosen from &lt;http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata/ScopeCode&gt;</para>
    /// labels<para>update scope</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#updateScope">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#updateScope</seealso>
    let updateScope = Prefixed_Name(md, "updateScope") |> PrefixedName
    /// <summary>
    ///   <para>md:topologyLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>topology level</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#topologyLevel">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#topologyLevel</seealso>
    let topologyLevel = Prefixed_Name(md, "topologyLevel") |> PrefixedName
    /// <summary>
    ///   <para>md:Resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Resolution</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Resolution">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Resolution</seealso>
    let Resolution = Prefixed_Name(md, "Resolution") |> PrefixedName
    /// <summary>
    ///   <para>md:definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>definition</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#definition">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#definition</seealso>
    let definition = Prefixed_Name(md, "definition") |> PrefixedName
    /// <summary>
    ///   <para>md:maxValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>max value</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maxValue">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maxValue</seealso>
    let maxValue = Prefixed_Name(md, "maxValue") |> PrefixedName
    /// <summary>
    ///   <para>md:bitsPerValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>bits per value</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#bitsPerValue">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#bitsPerValue</seealso>
    let bitsPerValue = Prefixed_Name(md, "bitsPerValue") |> PrefixedName
    /// <summary>
    ///   <para>md:condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>condition</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#condition">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#condition</seealso>
    let condition = Prefixed_Name(md, "condition") |> PrefixedName
    /// <summary>
    ///   <para>md:classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>classification</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#classification">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#classification</seealso>
    let classification = Prefixed_Name(md, "classification") |> PrefixedName
    /// <summary>
    ///   <para>md:metadataMaintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>metadata maintenance</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataMaintenance">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataMaintenance</seealso>
    let metadataMaintenance = Prefixed_Name(md, "metadataMaintenance") |> PrefixedName
    /// <summary>
    ///   <para>md:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>name</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#name">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#name</seealso>
    let name = Prefixed_Name(md, "name") |> PrefixedName
    /// <summary>
    ///   <para>md:parentEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>parent entity</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#parentEntity">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#parentEntity</seealso>
    let parentEntity = Prefixed_Name(md, "parentEntity") |> PrefixedName
    /// <summary>
    ///   <para>md:BrowseGraphic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Browse graphic</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#BrowseGraphic">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#BrowseGraphic</seealso>
    let BrowseGraphic = Prefixed_Name(md, "BrowseGraphic") |> PrefixedName
    /// <summary>
    ///   <para>md:otherConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>other constraints</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#otherConstraints">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#otherConstraints</seealso>
    let otherConstraints = Prefixed_Name(md, "otherConstraints") |> PrefixedName
    /// <summary>
    ///   <para>md:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#</seealso>
    let _prefix_iri = Prefixed_Name(md, "") |> PrefixedName
    /// <summary>
    ///   <para>md:CharacterSetCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Character set code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CharacterSetCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CharacterSetCode</seealso>
    let CharacterSetCode = Prefixed_Name(md, "CharacterSetCode") |> PrefixedName
    /// <summary>
    ///   <para>md:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>language</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#language">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#language</seealso>
    let language = Prefixed_Name(md, "language") |> PrefixedName

    /// <summary>
    ///   <para>md:cameraCalibrationInformationAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>camera calibration information availability</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cameraCalibrationInformationAvailability">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cameraCalibrationInformationAvailability</seealso>
    let cameraCalibrationInformationAvailability =
        Prefixed_Name(md, "cameraCalibrationInformationAvailability") |> PrefixedName

    /// <summary>
    ///   <para>md:plannedAvailableDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>planned available date time</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#plannedAvailableDateTime">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#plannedAvailableDateTime</seealso>
    let plannedAvailableDateTime =
        Prefixed_Name(md, "plannedAvailableDateTime") |> PrefixedName

    /// <summary>
    ///   <para>md:propertyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>property type</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#propertyType">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#propertyType</seealso>
    let propertyType = Prefixed_Name(md, "propertyType") |> PrefixedName
    /// <summary>
    ///   <para>md:formatDistributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>format distributor</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#formatDistributor">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#formatDistributor</seealso>
    let formatDistributor = Prefixed_Name(md, "formatDistributor") |> PrefixedName
    /// <summary>
    ///   <para>md:mediumNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>medium note</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#mediumNote">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#mediumNote</seealso>
    let mediumNote = Prefixed_Name(md, "mediumNote") |> PrefixedName

    /// <summary>
    ///   <para>md:resourceSpecificUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>resource specific usage</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceSpecificUsage">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceSpecificUsage</seealso>
    let resourceSpecificUsage =
        Prefixed_Name(md, "resourceSpecificUsage") |> PrefixedName

    /// <summary>
    ///   <para>md:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>describes</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#describes">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#describes</seealso>
    let describes = Prefixed_Name(md, "describes") |> PrefixedName
    /// <summary>
    ///   <para>md:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>status</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#status">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#status</seealso>
    let status = Prefixed_Name(md, "status") |> PrefixedName

    /// <summary>
    ///   <para>md:MaintenanceInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Maintenance</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MaintenanceInformation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MaintenanceInformation</seealso>
    let MaintenanceInformation =
        Prefixed_Name(md, "MaintenanceInformation") |> PrefixedName

    /// <summary>
    ///   <para>md:shortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>short name</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#shortName">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#shortName</seealso>
    let shortName = Prefixed_Name(md, "shortName") |> PrefixedName
    /// <summary>
    ///   <para>md:scaleFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>scale factor</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#scaleFactor">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#scaleFactor</seealso>
    let scaleFactor = Prefixed_Name(md, "scaleFactor") |> PrefixedName

    /// <summary>
    ///   <para>md:supplementalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>supplemental information</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#supplementalInformation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#supplementalInformation</seealso>
    let supplementalInformation =
        Prefixed_Name(md, "supplementalInformation") |> PrefixedName

    /// <summary>
    ///   <para>md:controlPointAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>control point availability</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#controlPointAvailability">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#controlPointAvailability</seealso>
    let controlPointAvailability =
        Prefixed_Name(md, "controlPointAvailability") |> PrefixedName

    /// <summary>
    ///   <para>md:RangeDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Range dimension</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#RangeDimension">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#RangeDimension</seealso>
    let RangeDimension = Prefixed_Name(md, "RangeDimension") |> PrefixedName
    /// <summary>
    ///   <para>md:hierarchyLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hierarchy level</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#hierarchyLevel">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#hierarchyLevel</seealso>
    let hierarchyLevel = Prefixed_Name(md, "hierarchyLevel") |> PrefixedName
    /// <summary>
    ///   <para>md:constraintLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>constraint language</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#constraintLanguage">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#constraintLanguage</seealso>
    let constraintLanguage = Prefixed_Name(md, "constraintLanguage") |> PrefixedName
    /// <summary>
    ///   <para>md:transferSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>transfer size</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transferSize">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transferSize</seealso>
    let transferSize = Prefixed_Name(md, "transferSize") |> PrefixedName
    /// <summary>
    ///   <para>md:imageQualityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>image quality code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#imageQualityCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#imageQualityCode</seealso>
    let imageQualityCode = Prefixed_Name(md, "imageQualityCode") |> PrefixedName

    /// <summary>
    ///   <para>md:lensDistortionInformationAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>lens distortion information availability</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#lensDistortionInformationAvailability">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#lensDistortionInformationAvailability</seealso>
    let lensDistortionInformationAvailability =
        Prefixed_Name(md, "lensDistortionInformationAvailability") |> PrefixedName

    /// <summary>
    ///   <para>md:RepresentativeFraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Representative fraction</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#RepresentativeFraction">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#RepresentativeFraction</seealso>
    let RepresentativeFraction =
        Prefixed_Name(md, "RepresentativeFraction") |> PrefixedName

    /// <summary>
    ///   <para>md:schemaAscii</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>schema ascii</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#schemaAscii">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#schemaAscii</seealso>
    let schemaAscii = Prefixed_Name(md, "schemaAscii") |> PrefixedName
    /// <summary>
    ///   <para>md:fileName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>file name</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileName">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileName</seealso>
    let fileName = Prefixed_Name(md, "fileName") |> PrefixedName
    /// <summary>
    ///   <para>md:Medium.name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Medium.name">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Medium.name</seealso>
    let ``Medium.name`` = Prefixed_Name(md, "Medium.name") |> PrefixedName
    /// <summary>
    ///   <para>md:imagingCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>imaging condition</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#imagingCondition">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#imagingCondition</seealso>
    let imagingCondition = Prefixed_Name(md, "imagingCondition") |> PrefixedName
    /// <summary>
    ///   <para>md:ProgressCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Progress code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ProgressCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ProgressCode</seealso>
    let ProgressCode = Prefixed_Name(md, "ProgressCode") |> PrefixedName
    /// <summary>
    ///   <para>md:metadataStandardName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>metadata standard name</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataStandardName">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataStandardName</seealso>
    let metadataStandardName = Prefixed_Name(md, "metadataStandardName") |> PrefixedName
    /// <summary>
    ///   <para>md:characterSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>character set</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#characterSet">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#characterSet</seealso>
    let characterSet = Prefixed_Name(md, "characterSet") |> PrefixedName
    /// <summary>
    ///   <para>md:metadataConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>metadata constraints</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataConstraints">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataConstraints</seealso>
    let metadataConstraints = Prefixed_Name(md, "metadataConstraints") |> PrefixedName
    /// <summary>
    ///   <para>md:densityUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>density units</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#densityUnits">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#densityUnits</seealso>
    let densityUnits = Prefixed_Name(md, "densityUnits") |> PrefixedName
    /// <summary>
    ///   <para>md:initiativeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Value should be chosen from &lt;http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataset/InitiativeTypeCode&gt;</para>
    /// labels<para>initiative type</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#initiativeType">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#initiativeType</seealso>
    let initiativeType = Prefixed_Name(md, "initiativeType") |> PrefixedName

    /// <summary>
    ///   <para>md:DimensionNameTypeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Dimension name type code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DimensionNameTypeCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DimensionNameTypeCode</seealso>
    let DimensionNameTypeCode =
        Prefixed_Name(md, "DimensionNameTypeCode") |> PrefixedName

    /// <summary>
    ///   <para>md:illuminationElevationAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>illumination elevation Angle</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#illuminationElevationAngle">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#illuminationElevationAngle</seealso>
    let illuminationElevationAngle =
        Prefixed_Name(md, "illuminationElevationAngle") |> PrefixedName

    /// <summary>
    ///   <para>md:unitsOfDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>units of distribution</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#unitsOfDistribution">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#unitsOfDistribution</seealso>
    let unitsOfDistribution = Prefixed_Name(md, "unitsOfDistribution") |> PrefixedName

    /// <summary>
    ///   <para>md:CoverageContentTypeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Coverage content type code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CoverageContentTypeCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CoverageContentTypeCode</seealso>
    let CoverageContentTypeCode =
        Prefixed_Name(md, "CoverageContentTypeCode") |> PrefixedName
