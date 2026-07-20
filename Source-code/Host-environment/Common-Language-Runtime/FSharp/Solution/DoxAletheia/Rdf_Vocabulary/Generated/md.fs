namespace http.def.seegrid.csiro.au.isotc211.iso19115._2003.metadata.hash

open DoxAletheia

module md =
    let _namespace_name = "http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#graphicOverview"></see>
    /// </summary>
    let graphicOverview = _prefix "graphicOverview"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CharacterSetCode"></see>
    /// </summary>
    let CharacterSetCode = _prefix "CharacterSetCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#language"></see>
    /// </summary>
    let language = _prefix "language"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#KeywordTypeCode"></see>
    /// </summary>
    let KeywordTypeCode = _prefix "KeywordTypeCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#abstract"></see>
    /// </summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#FeatureCatalogueDescription"></see>
    /// </summary>
    let FeatureCatalogueDescription = _prefix "FeatureCatalogueDescription"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#orderingInstructions"></see>
    /// </summary>
    let orderingInstructions = _prefix "orderingInstructions"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cameraCalibrationInformationAvailability"></see>
    /// </summary>
    let cameraCalibrationInformationAvailability =
        _prefix "cameraCalibrationInformationAvailability"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#plannedAvailableDateTime"></see>
    /// </summary>
    let plannedAvailableDateTime = _prefix "plannedAvailableDateTime"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#topicCategory"></see>
    /// </summary>
    let topicCategory = _prefix "topicCategory"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#obligation"></see>
    /// </summary>
    let obligation = _prefix "obligation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Metadata"></see>
    /// </summary>
    let Metadata = _prefix "Metadata"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#geometricObjects"></see>
    /// </summary>
    let geometricObjects = _prefix "geometricObjects"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#propertyType"></see>
    /// </summary>
    let propertyType = _prefix "propertyType"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#formatDistributor"></see>
    /// </summary>
    let formatDistributor = _prefix "formatDistributor"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#processingLevelCode"></see>
    /// </summary>
    let processingLevelCode = _prefix "processingLevelCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#volumes"></see>
    /// </summary>
    let volumes = _prefix "volumes"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributorFormat"></see>
    /// </summary>
    let distributorFormat = _prefix "distributorFormat"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#schemaLanguage"></see>
    /// </summary>
    let schemaLanguage = _prefix "schemaLanguage"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#citation"></see>
    /// </summary>
    let citation = _prefix "citation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#mediumNote"></see>
    /// </summary>
    let mediumNote = _prefix "mediumNote"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceSpecificUsage"></see>
    /// </summary>
    let resourceSpecificUsage = _prefix "resourceSpecificUsage"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#online"></see>
    /// </summary>
    let online = _prefix "online"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cellGeometry"></see>
    /// </summary>
    let cellGeometry = _prefix "cellGeometry"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#describes"></see>
    /// </summary>
    let describes = _prefix "describes"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#status"></see>
    /// </summary>
    let status = _prefix "status"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dimensionName"></see>
    /// </summary>
    let dimensionName = _prefix "dimensionName"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#spatialResolution"></see>
    /// </summary>
    let spatialResolution = _prefix "spatialResolution"
    /// <summary>
    /// Value should be chosen from &lt;http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata/MaintenanceFrequenceCode&gt;
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maintenanceAndUpdateFrequency"></see></summary>
    let maintenanceAndUpdateFrequency = _prefix "maintenanceAndUpdateFrequency"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Georectified"></see>
    /// </summary>
    let Georectified = _prefix "Georectified"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#aggregateDataSetIdentifier"></see>
    /// </summary>
    let aggregateDataSetIdentifier = _prefix "aggregateDataSetIdentifier"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MaintenanceInformation"></see>
    /// </summary>
    let MaintenanceInformation = _prefix "MaintenanceInformation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#shortName"></see>
    /// </summary>
    let shortName = _prefix "shortName"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DataIdentification"></see>
    /// </summary>
    let DataIdentification = _prefix "DataIdentification"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#geometricObjectType"></see>
    /// </summary>
    let geometricObjectType = _prefix "geometricObjectType"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Distributor"></see>
    /// </summary>
    let Distributor = _prefix "Distributor"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#source"></see>
    /// </summary>
    let source = _prefix "source"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#useLimitation"></see>
    /// </summary>
    let useLimitation = _prefix "useLimitation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#scaleFactor"></see>
    /// </summary>
    let scaleFactor = _prefix "scaleFactor"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#supplementalInformation"></see>
    /// </summary>
    let supplementalInformation = _prefix "supplementalInformation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#rationale"></see>
    /// </summary>
    let rationale = _prefix "rationale"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#attributeDescription"></see>
    /// </summary>
    let attributeDescription = _prefix "attributeDescription"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resolution"></see>
    /// </summary>
    let resolution = _prefix "resolution"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userNote"></see>
    /// </summary>
    let userNote = _prefix "userNote"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Format"></see>
    /// </summary>
    let Format = _prefix "Format"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#referenceSystemIdentifier"></see>
    /// </summary>
    let referenceSystemIdentifier = _prefix "referenceSystemIdentifier"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceFormat"></see>
    /// </summary>
    let resourceFormat = _prefix "resourceFormat"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#thesaurusName"></see>
    /// </summary>
    let thesaurusName = _prefix "thesaurusName"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#complianceCode"></see>
    /// </summary>
    let complianceCode = _prefix "complianceCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#georeferencedParameters"></see>
    /// </summary>
    let georeferencedParameters = _prefix "georeferencedParameters"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#density"></see>
    /// </summary>
    let density = _prefix "density"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#compressionGenerationQuantity"></see>
    /// </summary>
    let compressionGenerationQuantity = _prefix "compressionGenerationQuantity"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ExtendedElementInformation"></see>
    /// </summary>
    let ExtendedElementInformation = _prefix "ExtendedElementInformation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#SecurityConstraints"></see>
    /// </summary>
    let SecurityConstraints = _prefix "SecurityConstraints"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#AggregateInformation"></see>
    /// </summary>
    let AggregateInformation = _prefix "AggregateInformation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#authority"></see>
    /// </summary>
    let authority = _prefix "authority"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#SpatialRepresentationTypeCode"></see>
    /// </summary>
    let SpatialRepresentationTypeCode = _prefix "SpatialRepresentationTypeCode"
    /// <summary>
    /// Value should be chosen from &lt;http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata/RestrictionCode&gt;
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#accessConstraints"></see></summary>
    let accessConstraints = _prefix "accessConstraints"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataExtensionInfo"></see>
    /// </summary>
    let metadataExtensionInfo = _prefix "metadataExtensionInfo"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#purpose"></see>
    /// </summary>
    let purpose = _prefix "purpose"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#portrayalCatalogueInfo"></see>
    /// </summary>
    let portrayalCatalogueInfo = _prefix "portrayalCatalogueInfo"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#offLine"></see>
    /// </summary>
    let offLine = _prefix "offLine"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#minValue"></see>
    /// </summary>
    let minValue = _prefix "minValue"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dataQualityInfo"></see>
    /// </summary>
    let dataQualityInfo = _prefix "dataQualityInfo"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dateStamp"></see>
    /// </summary>
    let dateStamp = _prefix "dateStamp"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#illuminationAzimuthAngle"></see>
    /// </summary>
    let illuminationAzimuthAngle = _prefix "illuminationAzimuthAngle"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ImagingConditionCode"></see>
    /// </summary>
    let ImagingConditionCode = _prefix "ImagingConditionCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#assocationType"></see>
    /// </summary>
    let assocationType = _prefix "assocationType"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#credit"></see>
    /// </summary>
    let credit = _prefix "credit"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Keywords"></see>
    /// </summary>
    let Keywords = _prefix "Keywords"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#PortrayalCatalogueReference"></see>
    /// </summary>
    let PortrayalCatalogueReference = _prefix "PortrayalCatalogueReference"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DigitalTransferOptions"></see>
    /// </summary>
    let DigitalTransferOptions = _prefix "DigitalTransferOptions"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#softwareDevelopmentFileFormat"></see>
    /// </summary>
    let softwareDevelopmentFileFormat = _prefix "softwareDevelopmentFileFormat"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#checkPointDescription"></see>
    /// </summary>
    let checkPointDescription = _prefix "checkPointDescription"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileType"></see>
    /// </summary>
    let fileType = _prefix "fileType"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileDecompressionTechnique"></see>
    /// </summary>
    let fileDecompressionTechnique = _prefix "fileDecompressionTechnique"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#SpatialRepresentation"></see>
    /// </summary>
    let SpatialRepresentation = _prefix "SpatialRepresentation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#equivalentScale"></see>
    /// </summary>
    let equivalentScale = _prefix "equivalentScale"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributor"></see>
    /// </summary>
    let distributor = _prefix "distributor"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#toneGradation"></see>
    /// </summary>
    let toneGradation = _prefix "toneGradation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#descriptor"></see>
    /// </summary>
    let descriptor = _prefix "descriptor"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#domainValue"></see>
    /// </summary>
    let domainValue = _prefix "domainValue"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileDescription"></see>
    /// </summary>
    let fileDescription = _prefix "fileDescription"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceMaintenance"></see>
    /// </summary>
    let resourceMaintenance = _prefix "resourceMaintenance"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#spatialRepresentationInfo"></see>
    /// </summary>
    let spatialRepresentationInfo = _prefix "spatialRepresentationInfo"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#parentIdentifier"></see>
    /// </summary>
    let parentIdentifier = _prefix "parentIdentifier"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#peakResponse"></see>
    /// </summary>
    let peakResponse = _prefix "peakResponse"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureAttribute"></see>
    /// </summary>
    let featureAttribute = _prefix "featureAttribute"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#descriptiveKeywords"></see>
    /// </summary>
    let descriptiveKeywords = _prefix "descriptiveKeywords"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#triangulationIndicator"></see>
    /// </summary>
    let triangulationIndicator = _prefix "triangulationIndicator"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#contentType"></see>
    /// </summary>
    let contentType = _prefix "contentType"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Distribution"></see>
    /// </summary>
    let Distribution = _prefix "Distribution"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceConstraints"></see>
    /// </summary>
    let resourceConstraints = _prefix "resourceConstraints"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#pointInPixel"></see>
    /// </summary>
    let pointInPixel = _prefix "pointInPixel"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#graphicsFile"></see>
    /// </summary>
    let graphicsFile = _prefix "graphicsFile"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CellGeometryCode"></see>
    /// </summary>
    let CellGeometryCode = _prefix "CellGeometryCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dimensionSize"></see>
    /// </summary>
    let dimensionSize = _prefix "dimensionSize"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#GridSpatialRepresentation"></see>
    /// </summary>
    let GridSpatialRepresentation = _prefix "GridSpatialRepresentation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#specificUsage"></see>
    /// </summary>
    let specificUsage = _prefix "specificUsage"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#type"></see>
    /// </summary>
    let type_ = _prefix "type"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#environmentDescription"></see>
    /// </summary>
    let environmentDescription = _prefix "environmentDescription"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CoverageDescription"></see>
    /// </summary>
    let CoverageDescription = _prefix "CoverageDescription"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fees"></see>
    /// </summary>
    let fees = _prefix "fees"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#useConstraints"></see>
    /// </summary>
    let useConstraints = _prefix "useConstraints"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#checkPointAvailability"></see>
    /// </summary>
    let checkPointAvailability = _prefix "checkPointAvailability"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#contentInfo"></see>
    /// </summary>
    let contentInfo = _prefix "contentInfo"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MaintenanceFrequencyCode"></see>
    /// </summary>
    let MaintenanceFrequencyCode = _prefix "MaintenanceFrequencyCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#contact"></see>
    /// </summary>
    let contact = _prefix "contact"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Constraints"></see>
    /// </summary>
    let Constraints = _prefix "Constraints"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dataSet"></see>
    /// </summary>
    let dataSet = _prefix "dataSet"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ImageDescription"></see>
    /// </summary>
    let ImageDescription = _prefix "ImageDescription"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#PixelOrientationCode"></see>
    /// </summary>
    let PixelOrientationCode = _prefix "PixelOrientationCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataStandardVersion"></see>
    /// </summary>
    let metadataStandardVersion = _prefix "metadataStandardVersion"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DistributionUnits"></see>
    /// </summary>
    let DistributionUnits = _prefix "DistributionUnits"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userDefinedMaintenanceFrequency"></see>
    /// </summary>
    let userDefinedMaintenanceFrequency = _prefix "userDefinedMaintenanceFrequency"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MediumFormatCode"></see>
    /// </summary>
    let MediumFormatCode = _prefix "MediumFormatCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#turnaround"></see>
    /// </summary>
    let turnaround = _prefix "turnaround"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userContactInfo"></see>
    /// </summary>
    let userContactInfo = _prefix "userContactInfo"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#GeometricObjectTypeCode"></see>
    /// </summary>
    let GeometricObjectTypeCode = _prefix "GeometricObjectTypeCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureType"></see>
    /// </summary>
    let featureType = _prefix "featureType"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#pointOfContact"></see>
    /// </summary>
    let pointOfContact = _prefix "pointOfContact"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#portrayalCatalogueCitation"></see>
    /// </summary>
    let portrayalCatalogueCitation = _prefix "portrayalCatalogueCitation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#handlingDescription"></see>
    /// </summary>
    let handlingDescription = _prefix "handlingDescription"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#extensionOnLineResource"></see>
    /// </summary>
    let extensionOnLineResource = _prefix "extensionOnLineResource"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#version"></see>
    /// </summary>
    let version = _prefix "version"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maintenanceNote"></see>
    /// </summary>
    let maintenanceNote = _prefix "maintenanceNote"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#aggregateDataSetName"></see>
    /// </summary>
    let aggregateDataSetName = _prefix "aggregateDataSetName"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributionInfo"></see>
    /// </summary>
    let distributionInfo = _prefix "distributionInfo"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ApplicationSchema.name"></see>
    /// </summary>
    let ``ApplicationSchema.name`` = _prefix "ApplicationSchema.name"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#LegalConstraints"></see>
    /// </summary>
    let LegalConstraints = _prefix "LegalConstraints"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#domainCode"></see>
    /// </summary>
    let domainCode = _prefix "domainCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#referenceSystemInfo"></see>
    /// </summary>
    let referenceSystemInfo = _prefix "referenceSystemInfo"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#parameterCitation"></see>
    /// </summary>
    let parameterCitation = _prefix "parameterCitation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Usage"></see>
    /// </summary>
    let Usage = _prefix "Usage"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#hierarchyLevelName"></see>
    /// </summary>
    let hierarchyLevelName = _prefix "hierarchyLevelName"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ApplicationSchemaInformation"></see>
    /// </summary>
    let ApplicationSchemaInformation = _prefix "ApplicationSchemaInformation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#aggregationInfo"></see>
    /// </summary>
    let aggregationInfo = _prefix "aggregationInfo"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#series"></see>
    /// </summary>
    let series = _prefix "series"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ContentInformation"></see>
    /// </summary>
    let ContentInformation = _prefix "ContentInformation"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#radiometricCalibrationInformationAvailability"></see>
    /// </summary>
    let radiometricCalibrationInformationAvailability =
        _prefix "radiometricCalibrationInformationAvailability"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#offset"></see>
    /// </summary>
    let offset = _prefix "offset"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dateOfNextUpdate"></see>
    /// </summary>
    let dateOfNextUpdate = _prefix "dateOfNextUpdate"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dataType"></see>
    /// </summary>
    let dataType = _prefix "dataType"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureCatalogueCitation"></see>
    /// </summary>
    let featureCatalogueCitation = _prefix "featureCatalogueCitation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributionOrderProcess"></see>
    /// </summary>
    let distributionOrderProcess = _prefix "distributionOrderProcess"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#TopologyLevelCode"></see>
    /// </summary>
    let TopologyLevelCode = _prefix "TopologyLevelCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#mediumFormat"></see>
    /// </summary>
    let mediumFormat = _prefix "mediumFormat"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Dimension"></see>
    /// </summary>
    let Dimension = _prefix "Dimension"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileIdentifier"></see>
    /// </summary>
    let fileIdentifier = _prefix "fileIdentifier"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#TopicCategoryCode"></see>
    /// </summary>
    let TopicCategoryCode = _prefix "TopicCategoryCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#extendedElementInformation"></see>
    /// </summary>
    let extendedElementInformation = _prefix "extendedElementInformation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cloudCoverPercentage"></see>
    /// </summary>
    let cloudCoverPercentage = _prefix "cloudCoverPercentage"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ReferenceSystem"></see>
    /// </summary>
    let ReferenceSystem = _prefix "ReferenceSystem"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributorTransferOptions"></see>
    /// </summary>
    let distributorTransferOptions = _prefix "distributorTransferOptions"
    /// <summary>
    /// Sequence members are gm:Point
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#centerPoint"></see></summary>
    let centerPoint = _prefix "centerPoint"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Identification"></see>
    /// </summary>
    let Identification = _prefix "Identification"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#StandardOrderProcess"></see>
    /// </summary>
    let StandardOrderProcess = _prefix "StandardOrderProcess"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributionFormat"></see>
    /// </summary>
    let distributionFormat = _prefix "distributionFormat"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#controlPointAvailability"></see>
    /// </summary>
    let controlPointAvailability = _prefix "controlPointAvailability"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#RangeDimension"></see>
    /// </summary>
    let RangeDimension = _prefix "RangeDimension"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#GeometricObjects"></see>
    /// </summary>
    let GeometricObjects = _prefix "GeometricObjects"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#rule"></see>
    /// </summary>
    let rule = _prefix "rule"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#denominator"></see>
    /// </summary>
    let denominator = _prefix "denominator"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#identificationInfo"></see>
    /// </summary>
    let identificationInfo = _prefix "identificationInfo"
    /// <summary>
    /// Value should be chosen from &lt;http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata/ScopeCode&gt;
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#updateScope"></see></summary>
    let updateScope = _prefix "updateScope"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Georeferenceable"></see>
    /// </summary>
    let Georeferenceable = _prefix "Georeferenceable"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Medium"></see>
    /// </summary>
    let Medium = _prefix "Medium"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#hierarchyLevel"></see>
    /// </summary>
    let hierarchyLevel = _prefix "hierarchyLevel"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#constraintLanguage"></see>
    /// </summary>
    let constraintLanguage = _prefix "constraintLanguage"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transferSize"></see>
    /// </summary>
    let transferSize = _prefix "transferSize"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#imageQualityCode"></see>
    /// </summary>
    let imageQualityCode = _prefix "imageQualityCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#applicationSchemaInfo"></see>
    /// </summary>
    let applicationSchemaInfo = _prefix "applicationSchemaInfo"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#specification"></see>
    /// </summary>
    let specification = _prefix "specification"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#topologyLevel"></see>
    /// </summary>
    let topologyLevel = _prefix "topologyLevel"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributorContact"></see>
    /// </summary>
    let distributorContact = _prefix "distributorContact"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ClassificationCode"></see>
    /// </summary>
    let ClassificationCode = _prefix "ClassificationCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#orientationParameterDescription"></see>
    /// </summary>
    let orientationParameterDescription = _prefix "orientationParameterDescription"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#filmDistortionInformationAvailability"></see>
    /// </summary>
    let filmDistortionInformationAvailability =
        _prefix "filmDistortionInformationAvailability"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ObligationCode"></see>
    /// </summary>
    let ObligationCode = _prefix "ObligationCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#softwareDevelopmentFile"></see>
    /// </summary>
    let softwareDevelopmentFile = _prefix "softwareDevelopmentFile"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#RestrictionCode"></see>
    /// </summary>
    let RestrictionCode = _prefix "RestrictionCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#VectorSpatialRepresentation"></see>
    /// </summary>
    let VectorSpatialRepresentation = _prefix "VectorSpatialRepresentation"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#lensDistortionInformationAvailability"></see>
    /// </summary>
    let lensDistortionInformationAvailability =
        _prefix "lensDistortionInformationAvailability"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#RepresentativeFraction"></see>
    /// </summary>
    let RepresentativeFraction = _prefix "RepresentativeFraction"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#schemaAscii"></see>
    /// </summary>
    let schemaAscii = _prefix "schemaAscii"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileName"></see>
    /// </summary>
    let fileName = _prefix "fileName"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ScopeDescription"></see>
    /// </summary>
    let ScopeDescription = _prefix "ScopeDescription"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DatatypeCode"></see>
    /// </summary>
    let DatatypeCode = _prefix "DatatypeCode"
    /// <summary>
    /// Sequence members are md:Dimension
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#axisDimensionProperties"></see></summary>
    let axisDimensionProperties = _prefix "axisDimensionProperties"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#units"></see>
    /// </summary>
    let units = _prefix "units"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#spatialRepresentationType"></see>
    /// </summary>
    let spatialRepresentationType = _prefix "spatialRepresentationType"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#locale"></see>
    /// </summary>
    let locale = _prefix "locale"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maximumOccurrence"></see>
    /// </summary>
    let maximumOccurrence = _prefix "maximumOccurrence"
    /// <summary>
    /// Sequence members are GM_Point
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cornerPoints"></see></summary>
    let cornerPoints = _prefix "cornerPoints"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Resolution"></see>
    /// </summary>
    let Resolution = _prefix "Resolution"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Band"></see>
    /// </summary>
    let Band = _prefix "Band"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#orientationParameterAvailability"></see>
    /// </summary>
    let orientationParameterAvailability = _prefix "orientationParameterAvailability"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Medium.name"></see>
    /// </summary>
    let ``Medium.name`` = _prefix "Medium.name"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#imagingCondition"></see>
    /// </summary>
    let imagingCondition = _prefix "imagingCondition"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ProgressCode"></see>
    /// </summary>
    let ProgressCode = _prefix "ProgressCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataStandardName"></see>
    /// </summary>
    let metadataStandardName = _prefix "metadataStandardName"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#definition"></see>
    /// </summary>
    let definition = _prefix "definition"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dimension"></see>
    /// </summary>
    let dimension = _prefix "dimension"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transformationParameterAvailability"></see>
    /// </summary>
    let transformationParameterAvailability =
        _prefix "transformationParameterAvailability"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#updateScopeDescription"></see>
    /// </summary>
    let updateScopeDescription = _prefix "updateScopeDescription"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#keyword"></see>
    /// </summary>
    let keyword = _prefix "keyword"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#amendmentNumber"></see>
    /// </summary>
    let amendmentNumber = _prefix "amendmentNumber"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#sequenceIdentifier"></see>
    /// </summary>
    let sequenceIdentifier = _prefix "sequenceIdentifier"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#numberOfDimensions"></see>
    /// </summary>
    let numberOfDimensions = _prefix "numberOfDimensions"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userDeterminedLimitations"></see>
    /// </summary>
    let userDeterminedLimitations = _prefix "userDeterminedLimitations"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maxValue"></see>
    /// </summary>
    let maxValue = _prefix "maxValue"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#characterSet"></see>
    /// </summary>
    let characterSet = _prefix "characterSet"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataConstraints"></see>
    /// </summary>
    let metadataConstraints = _prefix "metadataConstraints"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#densityUnits"></see>
    /// </summary>
    let densityUnits = _prefix "densityUnits"
    /// <summary>
    /// Value should be chosen from &lt;http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataset/InitiativeTypeCode&gt;
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#initiativeType"></see></summary>
    let initiativeType = _prefix "initiativeType"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ScopeCode"></see>
    /// </summary>
    let ScopeCode = _prefix "ScopeCode"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transformationDimensionDescription"></see>
    /// </summary>
    let transformationDimensionDescription =
        _prefix "transformationDimensionDescription"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#bitsPerValue"></see>
    /// </summary>
    let bitsPerValue = _prefix "bitsPerValue"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#classification"></see>
    /// </summary>
    let classification = _prefix "classification"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#condition"></see>
    /// </summary>
    let condition = _prefix "condition"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#extent"></see>
    /// </summary>
    let extent = _prefix "extent"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#usageDateTime"></see>
    /// </summary>
    let usageDateTime = _prefix "usageDateTime"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureTypes"></see>
    /// </summary>
    let featureTypes = _prefix "featureTypes"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#geometricObjectCount"></see>
    /// </summary>
    let geometricObjectCount = _prefix "geometricObjectCount"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#classificationSystem"></see>
    /// </summary>
    let classificationSystem = _prefix "classificationSystem"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataMaintenance"></see>
    /// </summary>
    let metadataMaintenance = _prefix "metadataMaintenance"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transferOptions"></see>
    /// </summary>
    let transferOptions = _prefix "transferOptions"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#includedWithDataset"></see>
    /// </summary>
    let includedWithDataset = _prefix "includedWithDataset"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transformationDimensionMapping"></see>
    /// </summary>
    let transformationDimensionMapping = _prefix "transformationDimensionMapping"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#parentEntity"></see>
    /// </summary>
    let parentEntity = _prefix "parentEntity"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DimensionNameTypeCode"></see>
    /// </summary>
    let DimensionNameTypeCode = _prefix "DimensionNameTypeCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#illuminationElevationAngle"></see>
    /// </summary>
    let illuminationElevationAngle = _prefix "illuminationElevationAngle"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#unitsOfDistribution"></see>
    /// </summary>
    let unitsOfDistribution = _prefix "unitsOfDistribution"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CoverageContentTypeCode"></see>
    /// </summary>
    let CoverageContentTypeCode = _prefix "CoverageContentTypeCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MediumNameCode"></see>
    /// </summary>
    let MediumNameCode = _prefix "MediumNameCode"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#otherConstraints"></see>
    /// </summary>
    let otherConstraints = _prefix "otherConstraints"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#BrowseGraphic"></see>
    /// </summary>
    let BrowseGraphic = _prefix "BrowseGraphic"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MetadataExtensionInformation"></see>
    /// </summary>
    let MetadataExtensionInformation = _prefix "MetadataExtensionInformation"
