#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module md =
    let _prefixId = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#" "md"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:notation : MD_AggregateInformation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Aggregate information^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#AggregateInformation">md:AggregateInformation</a>
    /// </summary>
    let AggregateInformation = _prefixId.prefix "AggregateInformation"
    /// <summary>
    ///   <para>rdfs:label : Application schema.name^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ApplicationSchema.name">md:ApplicationSchema.name</a>
    /// </summary>
    let ApplicationSchema'_period_'name = _prefixId.prefix "ApplicationSchema.name"
    /// <summary>
    ///   <para>skos:notation : MD_ApplicationSchemaInformation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Application schema information^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ApplicationSchemaInformation">md:ApplicationSchemaInformation</a>
    /// </summary>
    let ApplicationSchemaInformation = _prefixId.prefix "ApplicationSchemaInformation"
    /// <summary>
    ///   <para>rdfs:label : Band^^xsd:string</para>
    ///   <para>skos:notation : MD_Band^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Band">md:Band</a>
    /// </summary>
    let Band = _prefixId.prefix "Band"
    /// <summary>
    ///   <para>skos:notation : MD_BrowseGraphic^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Browse graphic^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#BrowseGraphic">md:BrowseGraphic</a>
    /// </summary>
    let BrowseGraphic = _prefixId.prefix "BrowseGraphic"
    /// <summary>
    ///   <para>skos:notation : MD_CellGeometryCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Cell geometry code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CellGeometryCode">md:CellGeometryCode</a>
    /// </summary>
    let CellGeometryCode = _prefixId.prefix "CellGeometryCode"
    /// <summary>
    ///   <para>skos:notation : MD_CharacterSetCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Character set code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CharacterSetCode">md:CharacterSetCode</a>
    /// </summary>
    let CharacterSetCode = _prefixId.prefix "CharacterSetCode"
    /// <summary>
    ///   <para>skos:notation : MD_ClassificationCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Classification code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ClassificationCode">md:ClassificationCode</a>
    /// </summary>
    let ClassificationCode = _prefixId.prefix "ClassificationCode"
    /// <summary>
    ///   <para>skos:notation : MD_Constraints^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Constraints^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Constraints">md:Constraints</a>
    /// </summary>
    let Constraints = _prefixId.prefix "Constraints"
    /// <summary>
    ///   <para>skos:notation : MD_ContentInformation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Content information^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ContentInformation">md:ContentInformation</a>
    /// </summary>
    let ContentInformation = _prefixId.prefix "ContentInformation"
    /// <summary>
    ///   <para>skos:notation : MD_CoverageContentTypeCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Coverage content type code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CoverageContentTypeCode">md:CoverageContentTypeCode</a>
    /// </summary>
    let CoverageContentTypeCode = _prefixId.prefix "CoverageContentTypeCode"
    /// <summary>
    ///   <para>skos:notation : MD_CoverageDescription^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Coverage description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#CoverageDescription">md:CoverageDescription</a>
    /// </summary>
    let CoverageDescription = _prefixId.prefix "CoverageDescription"
    /// <summary>
    ///   <para>rdfs:label : Data identification^^xsd:string</para>
    ///   <para>skos:notation : MD_DataIdentification^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DataIdentification">md:DataIdentification</a>
    /// </summary>
    let DataIdentification = _prefixId.prefix "DataIdentification"
    /// <summary>
    ///   <para>skos:notation : MD_DatatypeCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Datatype code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DatatypeCode">md:DatatypeCode</a>
    /// </summary>
    let DatatypeCode = _prefixId.prefix "DatatypeCode"
    /// <summary>
    ///   <para>rdfs:label : Digital transfer options^^xsd:string</para>
    ///   <para>skos:notation : MD_DigitalTransferOptions^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DigitalTransferOptions">md:DigitalTransferOptions</a>
    /// </summary>
    let DigitalTransferOptions = _prefixId.prefix "DigitalTransferOptions"
    /// <summary>
    ///   <para>skos:notation : MD_Dimension^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Dimension^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Dimension">md:Dimension</a>
    /// </summary>
    let Dimension = _prefixId.prefix "Dimension"
    /// <summary>
    ///   <para>skos:notation : MD_DimensionNameTypeCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Dimension name type code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DimensionNameTypeCode">md:DimensionNameTypeCode</a>
    /// </summary>
    let DimensionNameTypeCode = _prefixId.prefix "DimensionNameTypeCode"
    /// <summary>
    ///   <para>rdfs:label : Distribution^^xsd:string</para>
    ///   <para>skos:notation : MD_Distribution^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Distribution">md:Distribution</a>
    /// </summary>
    let Distribution = _prefixId.prefix "Distribution"
    /// <summary>
    ///   <para>skos:notation : MD_DistributionUnits^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Distribution units^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#DistributionUnits">md:DistributionUnits</a>
    /// </summary>
    let DistributionUnits = _prefixId.prefix "DistributionUnits"
    /// <summary>
    ///   <para>rdfs:label : Distributor^^xsd:string</para>
    ///   <para>skos:notation : MD_Distributor^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Distributor">md:Distributor</a>
    /// </summary>
    let Distributor = _prefixId.prefix "Distributor"
    /// <summary>
    ///   <para>skos:notation : MD_ExtendedElementInformation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Extended element information^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ExtendedElementInformation">md:ExtendedElementInformation</a>
    /// </summary>
    let ExtendedElementInformation = _prefixId.prefix "ExtendedElementInformation"
    /// <summary>
    ///   <para>skos:notation : MD_FeatureCatalogueDescription^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Feature catalogue description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#FeatureCatalogueDescription">md:FeatureCatalogueDescription</a>
    /// </summary>
    let FeatureCatalogueDescription = _prefixId.prefix "FeatureCatalogueDescription"
    /// <summary>
    ///   <para>rdfs:label : Format^^xsd:string</para>
    ///   <para>skos:notation : MD_Format^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Format">md:Format</a>
    /// </summary>
    let Format = _prefixId.prefix "Format"
    /// <summary>
    ///   <para>skos:notation : MD_GeometricObjectTypeCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Geometric object type code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#GeometricObjectTypeCode">md:GeometricObjectTypeCode</a>
    /// </summary>
    let GeometricObjectTypeCode = _prefixId.prefix "GeometricObjectTypeCode"
    /// <summary>
    ///   <para>skos:notation : MD_GeometricObjects^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Geometric objects^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#GeometricObjects">md:GeometricObjects</a>
    /// </summary>
    let GeometricObjects = _prefixId.prefix "GeometricObjects"
    /// <summary>
    ///   <para>skos:notation : MD_Georectified^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Georectified^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Georectified">md:Georectified</a>
    /// </summary>
    let Georectified = _prefixId.prefix "Georectified"
    /// <summary>
    ///   <para>skos:notation : MD_Georeferenceable^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Georeferenceable^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Georeferenceable">md:Georeferenceable</a>
    /// </summary>
    let Georeferenceable = _prefixId.prefix "Georeferenceable"
    /// <summary>
    ///   <para>skos:notation : MD_GridSpatialRepresentation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Grid spatial representation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#GridSpatialRepresentation">md:GridSpatialRepresentation</a>
    /// </summary>
    let GridSpatialRepresentation = _prefixId.prefix "GridSpatialRepresentation"
    /// <summary>
    ///   <para>rdfs:label : Identification^^xsd:string</para>
    ///   <para>skos:notation : MD_Identification^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Identification">md:Identification</a>
    /// </summary>
    let Identification = _prefixId.prefix "Identification"
    /// <summary>
    ///   <para>skos:notation : MD_ImageDescription^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Image description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ImageDescription">md:ImageDescription</a>
    /// </summary>
    let ImageDescription = _prefixId.prefix "ImageDescription"
    /// <summary>
    ///   <para>skos:notation : MD_ImagingConditionCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Imaging condition code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ImagingConditionCode">md:ImagingConditionCode</a>
    /// </summary>
    let ImagingConditionCode = _prefixId.prefix "ImagingConditionCode"
    /// <summary>
    ///   <para>skos:notation : MD_KeywordTypeCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Keyword type code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#KeywordTypeCode">md:KeywordTypeCode</a>
    /// </summary>
    let KeywordTypeCode = _prefixId.prefix "KeywordTypeCode"
    /// <summary>
    ///   <para>skos:notation : MD_Keywords^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Keywords^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Keywords">md:Keywords</a>
    /// </summary>
    let Keywords = _prefixId.prefix "Keywords"
    /// <summary>
    ///   <para>rdfs:label : Legal constraints^^xsd:string</para>
    ///   <para>skos:notation : MD_LegalConstraints^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#LegalConstraints">md:LegalConstraints</a>
    /// </summary>
    let LegalConstraints = _prefixId.prefix "LegalConstraints"
    /// <summary>
    ///   <para>skos:notation : MD_MaintenanceFrequencyCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Maintenance frequency code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MaintenanceFrequencyCode">md:MaintenanceFrequencyCode</a>
    /// </summary>
    let MaintenanceFrequencyCode = _prefixId.prefix "MaintenanceFrequencyCode"
    /// <summary>
    ///   <para>skos:notation : MD_MaintenanceInformation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Maintenance^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MaintenanceInformation">md:MaintenanceInformation</a>
    /// </summary>
    let MaintenanceInformation = _prefixId.prefix "MaintenanceInformation"
    /// <summary>
    ///   <para>rdfs:label : Medium^^xsd:string</para>
    ///   <para>skos:notation : MD_Medium^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Medium">md:Medium</a>
    /// </summary>
    let Medium = _prefixId.prefix "Medium"
    let Medium'_period_'name = _prefixId.prefix "Medium.name"
    /// <summary>
    ///   <para>skos:notation : MD_MediumFormatCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Medium format code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MediumFormatCode">md:MediumFormatCode</a>
    /// </summary>
    let MediumFormatCode = _prefixId.prefix "MediumFormatCode"
    /// <summary>
    ///   <para>skos:notation : MD_MediumNameCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Medium name code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MediumNameCode">md:MediumNameCode</a>
    /// </summary>
    let MediumNameCode = _prefixId.prefix "MediumNameCode"
    /// <summary>
    ///   <para>skos:notation : MD_Metadata^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Metadata record</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Metadata">md:Metadata</a>
    /// </summary>
    let Metadata = _prefixId.prefix "Metadata"
    /// <summary>
    ///   <para>skos:notation : MD_MetadataExtensionInformation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Metadata extension information^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#MetadataExtensionInformation">md:MetadataExtensionInformation</a>
    /// </summary>
    let MetadataExtensionInformation = _prefixId.prefix "MetadataExtensionInformation"
    let ObligationCode = _prefixId.prefix "ObligationCode"
    let PixelOrientationCode = _prefixId.prefix "PixelOrientationCode"
    /// <summary>
    ///   <para>skos:notation : MD_PortrayalCatalogueReference^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Portrayal catalogue reference^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#PortrayalCatalogueReference">md:PortrayalCatalogueReference</a>
    /// </summary>
    let PortrayalCatalogueReference = _prefixId.prefix "PortrayalCatalogueReference"
    /// <summary>
    ///   <para>skos:notation : MD_ProgressCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Progress code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ProgressCode">md:ProgressCode</a>
    /// </summary>
    let ProgressCode = _prefixId.prefix "ProgressCode"
    /// <summary>
    ///   <para>skos:notation : MD_RangeDimension^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Range dimension^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#RangeDimension">md:RangeDimension</a>
    /// </summary>
    let RangeDimension = _prefixId.prefix "RangeDimension"
    /// <summary>
    ///   <para>skos:notation : MD_ReferenceSystem^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Reference system^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ReferenceSystem">md:ReferenceSystem</a>
    /// </summary>
    let ReferenceSystem = _prefixId.prefix "ReferenceSystem"
    /// <summary>
    ///   <para>skos:notation : MD_RepresentativeFraction^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Representative fraction^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#RepresentativeFraction">md:RepresentativeFraction</a>
    /// </summary>
    let RepresentativeFraction = _prefixId.prefix "RepresentativeFraction"
    /// <summary>
    ///   <para>skos:notation : MD_Resolution^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Resolution^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Resolution">md:Resolution</a>
    /// </summary>
    let Resolution = _prefixId.prefix "Resolution"
    /// <summary>
    ///   <para>skos:notation : MD_RestrictionCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Restriction code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#RestrictionCode">md:RestrictionCode</a>
    /// </summary>
    let RestrictionCode = _prefixId.prefix "RestrictionCode"
    /// <summary>
    ///   <para>skos:notation : MD_ScopeCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Scope code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ScopeCode">md:ScopeCode</a>
    /// </summary>
    let ScopeCode = _prefixId.prefix "ScopeCode"
    /// <summary>
    ///   <para>skos:notation : MD_ScopeDescription^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Scope description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#ScopeDescription">md:ScopeDescription</a>
    /// </summary>
    let ScopeDescription = _prefixId.prefix "ScopeDescription"
    /// <summary>
    ///   <para>rdfs:label : Security constraints^^xsd:string</para>
    ///   <para>skos:notation : MD_SecurityConstraints^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#SecurityConstraints">md:SecurityConstraints</a>
    /// </summary>
    let SecurityConstraints = _prefixId.prefix "SecurityConstraints"
    /// <summary>
    ///   <para>skos:notation : MD_SpatialRepresentation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Spatial representation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#SpatialRepresentation">md:SpatialRepresentation</a>
    /// </summary>
    let SpatialRepresentation = _prefixId.prefix "SpatialRepresentation"
    /// <summary>
    ///   <para>skos:notation : MD_SpatialRepresentationTypeCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Spatial representation type code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#SpatialRepresentationTypeCode">md:SpatialRepresentationTypeCode</a>
    /// </summary>
    let SpatialRepresentationTypeCode = _prefixId.prefix "SpatialRepresentationTypeCode"
    /// <summary>
    ///   <para>skos:notation : MD_StandardOrderProcess^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Standard order process^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#StandardOrderProcess">md:StandardOrderProcess</a>
    /// </summary>
    let StandardOrderProcess = _prefixId.prefix "StandardOrderProcess"
    /// <summary>
    ///   <para>skos:notation : MD_TopicCategoryCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Topic category code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#TopicCategoryCode">md:TopicCategoryCode</a>
    /// </summary>
    let TopicCategoryCode = _prefixId.prefix "TopicCategoryCode"
    /// <summary>
    ///   <para>skos:notation : MD_TopologyLevelCode^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Topology level code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#TopologyLevelCode">md:TopologyLevelCode</a>
    /// </summary>
    let TopologyLevelCode = _prefixId.prefix "TopologyLevelCode"
    /// <summary>
    ///   <para>skos:notation : MD_Usage^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Usage^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#Usage">md:Usage</a>
    /// </summary>
    let Usage = _prefixId.prefix "Usage"
    /// <summary>
    ///   <para>skos:notation : MD_VectorSpatialRepresentation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Vector spatial representation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#VectorSpatialRepresentation">md:VectorSpatialRepresentation</a>
    /// </summary>
    let VectorSpatialRepresentation = _prefixId.prefix "VectorSpatialRepresentation"
    /// <summary>
    ///   <para>rdfs:label : abstract^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#abstract">md:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>rdfs:label : access constraints^^xsd:string</para>
    ///   <para>rdfs:comment : Value should be chosen from &lt;http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata/RestrictionCode&gt;^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#accessConstraints">md:accessConstraints</a>
    /// </summary>
    let accessConstraints = _prefixId.prefix "accessConstraints"
    /// <summary>
    ///   <para>rdfs:label : aggregate data set identifier^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#aggregateDataSetIdentifier">md:aggregateDataSetIdentifier</a>
    /// </summary>
    let aggregateDataSetIdentifier = _prefixId.prefix "aggregateDataSetIdentifier"
    /// <summary>
    ///   <para>rdfs:label : aggregate data set name^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#aggregateDataSetName">md:aggregateDataSetName</a>
    /// </summary>
    let aggregateDataSetName = _prefixId.prefix "aggregateDataSetName"
    /// <summary>
    ///   <para>rdfs:label : aggregation info^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#aggregationInfo">md:aggregationInfo</a>
    /// </summary>
    let aggregationInfo = _prefixId.prefix "aggregationInfo"
    /// <summary>
    ///   <para>rdfs:label : amendment number^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#amendmentNumber">md:amendmentNumber</a>
    /// </summary>
    let amendmentNumber = _prefixId.prefix "amendmentNumber"
    /// <summary>
    ///   <para>rdfs:label : application schema info^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#applicationSchemaInfo">md:applicationSchemaInfo</a>
    /// </summary>
    let applicationSchemaInfo = _prefixId.prefix "applicationSchemaInfo"
    /// <summary>
    ///   <para>rdfs:label : assocation type^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#assocationType">md:assocationType</a>
    /// </summary>
    let assocationType = _prefixId.prefix "assocationType"
    /// <summary>
    ///   <para>rdfs:label : attribute description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#attributeDescription">md:attributeDescription</a>
    /// </summary>
    let attributeDescription = _prefixId.prefix "attributeDescription"
    /// <summary>
    ///   <para>rdfs:label : authority^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#authority">md:authority</a>
    /// </summary>
    let authority = _prefixId.prefix "authority"
    /// <summary>
    ///   <para>rdfs:label : axis dimension properties^^xsd:string</para>
    ///   <para>rdfs:comment : Sequence members are md:Dimension^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#axisDimensionProperties">md:axisDimensionProperties</a>
    /// </summary>
    let axisDimensionProperties = _prefixId.prefix "axisDimensionProperties"
    /// <summary>
    ///   <para>rdfs:label : bits per value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#bitsPerValue">md:bitsPerValue</a>
    /// </summary>
    let bitsPerValue = _prefixId.prefix "bitsPerValue"

    /// <summary>
    ///   <para>rdfs:label : camera calibration information availability^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cameraCalibrationInformationAvailability">md:cameraCalibrationInformationAvailability</a>
    /// </summary>
    let cameraCalibrationInformationAvailability = _prefixId.prefix "cameraCalibrationInformationAvailability"

    /// <summary>
    ///   <para>rdfs:label : cell geometry^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cellGeometry">md:cellGeometry</a>
    /// </summary>
    let cellGeometry = _prefixId.prefix "cellGeometry"
    /// <summary>
    ///   <para>rdfs:label : center point^^xsd:string</para>
    ///   <para>rdfs:comment : Sequence members are gm:Point^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#centerPoint">md:centerPoint</a>
    /// </summary>
    let centerPoint = _prefixId.prefix "centerPoint"
    /// <summary>
    ///   <para>rdfs:label : character set^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#characterSet">md:characterSet</a>
    /// </summary>
    let characterSet = _prefixId.prefix "characterSet"
    /// <summary>
    ///   <para>rdfs:label : check point availability^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#checkPointAvailability">md:checkPointAvailability</a>
    /// </summary>
    let checkPointAvailability = _prefixId.prefix "checkPointAvailability"
    /// <summary>
    ///   <para>rdfs:label : check point description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#checkPointDescription">md:checkPointDescription</a>
    /// </summary>
    let checkPointDescription = _prefixId.prefix "checkPointDescription"
    /// <summary>
    ///   <para>rdfs:label : citation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#citation">md:citation</a>
    /// </summary>
    let citation = _prefixId.prefix "citation"
    /// <summary>
    ///   <para>rdfs:label : classification^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#classification">md:classification</a>
    /// </summary>
    let classification = _prefixId.prefix "classification"
    /// <summary>
    ///   <para>rdfs:label : classification system^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#classificationSystem">md:classificationSystem</a>
    /// </summary>
    let classificationSystem = _prefixId.prefix "classificationSystem"
    /// <summary>
    ///   <para>rdfs:label : cloud cover percentage^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cloudCoverPercentage">md:cloudCoverPercentage</a>
    /// </summary>
    let cloudCoverPercentage = _prefixId.prefix "cloudCoverPercentage"
    /// <summary>
    ///   <para>rdfs:label : compliance code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#complianceCode">md:complianceCode</a>
    /// </summary>
    let complianceCode = _prefixId.prefix "complianceCode"
    /// <summary>
    ///   <para>rdfs:label : compression generation quantity^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#compressionGenerationQuantity">md:compressionGenerationQuantity</a>
    /// </summary>
    let compressionGenerationQuantity = _prefixId.prefix "compressionGenerationQuantity"
    /// <summary>
    ///   <para>rdfs:label : condition^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#condition">md:condition</a>
    /// </summary>
    let condition = _prefixId.prefix "condition"
    /// <summary>
    ///   <para>rdfs:label : constraint language^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#constraintLanguage">md:constraintLanguage</a>
    /// </summary>
    let constraintLanguage = _prefixId.prefix "constraintLanguage"
    /// <summary>
    ///   <para>rdfs:label : contact^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#contact">md:contact</a>
    /// </summary>
    let contact = _prefixId.prefix "contact"
    /// <summary>
    ///   <para>rdfs:label : content info^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#contentInfo">md:contentInfo</a>
    /// </summary>
    let contentInfo = _prefixId.prefix "contentInfo"
    /// <summary>
    ///   <para>rdfs:label : content type^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#contentType">md:contentType</a>
    /// </summary>
    let contentType = _prefixId.prefix "contentType"
    /// <summary>
    ///   <para>rdfs:label : control point availability^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#controlPointAvailability">md:controlPointAvailability</a>
    /// </summary>
    let controlPointAvailability = _prefixId.prefix "controlPointAvailability"
    /// <summary>
    ///   <para>rdfs:label : corner point^^xsd:string</para>
    ///   <para>rdfs:comment : Sequence members are GM_Point^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#cornerPoints">md:cornerPoints</a>
    /// </summary>
    let cornerPoints = _prefixId.prefix "cornerPoints"
    /// <summary>
    ///   <para>rdfs:label : credit^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#credit">md:credit</a>
    /// </summary>
    let credit = _prefixId.prefix "credit"
    /// <summary>
    ///   <para>rdfs:label : data quality info^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dataQualityInfo">md:dataQualityInfo</a>
    /// </summary>
    let dataQualityInfo = _prefixId.prefix "dataQualityInfo"
    /// <summary>
    ///   <para>rdfs:label : data set^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dataSet">md:dataSet</a>
    /// </summary>
    let dataSet = _prefixId.prefix "dataSet"
    /// <summary>
    ///   <para>rdfs:label : data type^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dataType">md:dataType</a>
    /// </summary>
    let dataType = _prefixId.prefix "dataType"
    /// <summary>
    ///   <para>rdfs:label : date of next update^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dateOfNextUpdate">md:dateOfNextUpdate</a>
    /// </summary>
    let dateOfNextUpdate = _prefixId.prefix "dateOfNextUpdate"
    /// <summary>
    ///   <para>rdfs:label : date stamp^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dateStamp">md:dateStamp</a>
    /// </summary>
    let dateStamp = _prefixId.prefix "dateStamp"
    /// <summary>
    ///   <para>rdfs:label : definition^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#definition">md:definition</a>
    /// </summary>
    let definition = _prefixId.prefix "definition"
    /// <summary>
    ///   <para>rdfs:label : denominator^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#denominator">md:denominator</a>
    /// </summary>
    let denominator = _prefixId.prefix "denominator"
    /// <summary>
    ///   <para>rdfs:label : density^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#density">md:density</a>
    /// </summary>
    let density = _prefixId.prefix "density"
    /// <summary>
    ///   <para>rdfs:label : density units^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#densityUnits">md:densityUnits</a>
    /// </summary>
    let densityUnits = _prefixId.prefix "densityUnits"
    /// <summary>
    ///   <para>rdfs:label : describes^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#describes">md:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:label : descriptive keywords^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#descriptiveKeywords">md:descriptiveKeywords</a>
    /// </summary>
    let descriptiveKeywords = _prefixId.prefix "descriptiveKeywords"
    /// <summary>
    ///   <para>rdfs:label : descriptor^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#descriptor">md:descriptor</a>
    /// </summary>
    let descriptor = _prefixId.prefix "descriptor"
    /// <summary>
    ///   <para>rdfs:label : dimension^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dimension">md:dimension</a>
    /// </summary>
    let dimension = _prefixId.prefix "dimension"
    /// <summary>
    ///   <para>rdfs:label : dimension name^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dimensionName">md:dimensionName</a>
    /// </summary>
    let dimensionName = _prefixId.prefix "dimensionName"
    /// <summary>
    ///   <para>rdfs:label : dimension size^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#dimensionSize">md:dimensionSize</a>
    /// </summary>
    let dimensionSize = _prefixId.prefix "dimensionSize"
    /// <summary>
    ///   <para>rdfs:label : distribution format^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributionFormat">md:distributionFormat</a>
    /// </summary>
    let distributionFormat = _prefixId.prefix "distributionFormat"
    /// <summary>
    ///   <para>rdfs:label : distribution info^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributionInfo">md:distributionInfo</a>
    /// </summary>
    let distributionInfo = _prefixId.prefix "distributionInfo"
    /// <summary>
    ///   <para>rdfs:label : distribution order process^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributionOrderProcess">md:distributionOrderProcess</a>
    /// </summary>
    let distributionOrderProcess = _prefixId.prefix "distributionOrderProcess"
    /// <summary>
    ///   <para>rdfs:label : distributor^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributor">md:distributor</a>
    /// </summary>
    let distributor = _prefixId.prefix "distributor"
    /// <summary>
    ///   <para>rdfs:label : distributor contact^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributorContact">md:distributorContact</a>
    /// </summary>
    let distributorContact = _prefixId.prefix "distributorContact"
    /// <summary>
    ///   <para>rdfs:label : distributor format^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributorFormat">md:distributorFormat</a>
    /// </summary>
    let distributorFormat = _prefixId.prefix "distributorFormat"
    /// <summary>
    ///   <para>rdfs:label : distributor transfer options^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#distributorTransferOptions">md:distributorTransferOptions</a>
    /// </summary>
    let distributorTransferOptions = _prefixId.prefix "distributorTransferOptions"
    /// <summary>
    ///   <para>rdfs:label : domain code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#domainCode">md:domainCode</a>
    /// </summary>
    let domainCode = _prefixId.prefix "domainCode"
    /// <summary>
    ///   <para>rdfs:label : domain value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#domainValue">md:domainValue</a>
    /// </summary>
    let domainValue = _prefixId.prefix "domainValue"
    /// <summary>
    ///   <para>rdfs:label : environment description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#environmentDescription">md:environmentDescription</a>
    /// </summary>
    let environmentDescription = _prefixId.prefix "environmentDescription"
    /// <summary>
    ///   <para>rdfs:label : equivalent scale^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#equivalentScale">md:equivalentScale</a>
    /// </summary>
    let equivalentScale = _prefixId.prefix "equivalentScale"
    /// <summary>
    ///   <para>rdfs:label : extended element information^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#extendedElementInformation">md:extendedElementInformation</a>
    /// </summary>
    let extendedElementInformation = _prefixId.prefix "extendedElementInformation"
    /// <summary>
    ///   <para>rdfs:label : extension on line resource^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#extensionOnLineResource">md:extensionOnLineResource</a>
    /// </summary>
    let extensionOnLineResource = _prefixId.prefix "extensionOnLineResource"
    /// <summary>
    ///   <para>rdfs:label : extent^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#extent">md:extent</a>
    /// </summary>
    let extent = _prefixId.prefix "extent"
    /// <summary>
    ///   <para>rdfs:label : feature attribute^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureAttribute">md:featureAttribute</a>
    /// </summary>
    let featureAttribute = _prefixId.prefix "featureAttribute"
    /// <summary>
    ///   <para>rdfs:label : feature catalogue citation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureCatalogueCitation">md:featureCatalogueCitation</a>
    /// </summary>
    let featureCatalogueCitation = _prefixId.prefix "featureCatalogueCitation"
    /// <summary>
    ///   <para>rdfs:label : feature type^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureType">md:featureType</a>
    /// </summary>
    let featureType = _prefixId.prefix "featureType"
    /// <summary>
    ///   <para>rdfs:label : feature types^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#featureTypes">md:featureTypes</a>
    /// </summary>
    let featureTypes = _prefixId.prefix "featureTypes"
    /// <summary>
    ///   <para>rdfs:label : fees^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fees">md:fees</a>
    /// </summary>
    let fees = _prefixId.prefix "fees"
    /// <summary>
    ///   <para>rdfs:label : file decompression technique^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileDecompressionTechnique">md:fileDecompressionTechnique</a>
    /// </summary>
    let fileDecompressionTechnique = _prefixId.prefix "fileDecompressionTechnique"
    /// <summary>
    ///   <para>rdfs:label : file description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileDescription">md:fileDescription</a>
    /// </summary>
    let fileDescription = _prefixId.prefix "fileDescription"
    /// <summary>
    ///   <para>rdfs:label : file identifier^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileIdentifier">md:fileIdentifier</a>
    /// </summary>
    let fileIdentifier = _prefixId.prefix "fileIdentifier"
    /// <summary>
    ///   <para>rdfs:label : file name^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileName">md:fileName</a>
    /// </summary>
    let fileName = _prefixId.prefix "fileName"
    /// <summary>
    ///   <para>rdfs:label : file type^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#fileType">md:fileType</a>
    /// </summary>
    let fileType = _prefixId.prefix "fileType"

    /// <summary>
    ///   <para>rdfs:label : film distortion information availability^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#filmDistortionInformationAvailability">md:filmDistortionInformationAvailability</a>
    /// </summary>
    let filmDistortionInformationAvailability = _prefixId.prefix "filmDistortionInformationAvailability"

    /// <summary>
    ///   <para>rdfs:label : format distributor^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#formatDistributor">md:formatDistributor</a>
    /// </summary>
    let formatDistributor = _prefixId.prefix "formatDistributor"
    /// <summary>
    ///   <para>rdfs:label : geometric object count^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#geometricObjectCount">md:geometricObjectCount</a>
    /// </summary>
    let geometricObjectCount = _prefixId.prefix "geometricObjectCount"
    /// <summary>
    ///   <para>rdfs:label : geometric object type^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#geometricObjectType">md:geometricObjectType</a>
    /// </summary>
    let geometricObjectType = _prefixId.prefix "geometricObjectType"
    /// <summary>
    ///   <para>rdfs:label : geometric objects^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#geometricObjects">md:geometricObjects</a>
    /// </summary>
    let geometricObjects = _prefixId.prefix "geometricObjects"
    /// <summary>
    ///   <para>rdfs:label : georeferenced parameters^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#georeferencedParameters">md:georeferencedParameters</a>
    /// </summary>
    let georeferencedParameters = _prefixId.prefix "georeferencedParameters"
    /// <summary>
    ///   <para>rdfs:label : graphic overview^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#graphicOverview">md:graphicOverview</a>
    /// </summary>
    let graphicOverview = _prefixId.prefix "graphicOverview"
    /// <summary>
    ///   <para>rdfs:label : graphics file^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#graphicsFile">md:graphicsFile</a>
    /// </summary>
    let graphicsFile = _prefixId.prefix "graphicsFile"
    /// <summary>
    ///   <para>rdfs:label : handling description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#handlingDescription">md:handlingDescription</a>
    /// </summary>
    let handlingDescription = _prefixId.prefix "handlingDescription"
    /// <summary>
    ///   <para>rdfs:label : hierarchy level^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#hierarchyLevel">md:hierarchyLevel</a>
    /// </summary>
    let hierarchyLevel = _prefixId.prefix "hierarchyLevel"
    /// <summary>
    ///   <para>rdfs:label : hierarchy level name^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#hierarchyLevelName">md:hierarchyLevelName</a>
    /// </summary>
    let hierarchyLevelName = _prefixId.prefix "hierarchyLevelName"
    /// <summary>
    ///   <para>rdfs:label : identification info^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#identificationInfo">md:identificationInfo</a>
    /// </summary>
    let identificationInfo = _prefixId.prefix "identificationInfo"
    /// <summary>
    ///   <para>rdfs:label : illumination Azimuth Angle^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#illuminationAzimuthAngle">md:illuminationAzimuthAngle</a>
    /// </summary>
    let illuminationAzimuthAngle = _prefixId.prefix "illuminationAzimuthAngle"
    /// <summary>
    ///   <para>rdfs:label : illumination elevation Angle^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#illuminationElevationAngle">md:illuminationElevationAngle</a>
    /// </summary>
    let illuminationElevationAngle = _prefixId.prefix "illuminationElevationAngle"
    /// <summary>
    ///   <para>rdfs:label : image quality code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#imageQualityCode">md:imageQualityCode</a>
    /// </summary>
    let imageQualityCode = _prefixId.prefix "imageQualityCode"
    /// <summary>
    ///   <para>rdfs:label : imaging condition^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#imagingCondition">md:imagingCondition</a>
    /// </summary>
    let imagingCondition = _prefixId.prefix "imagingCondition"
    /// <summary>
    ///   <para>rdfs:label : included with dataset^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#includedWithDataset">md:includedWithDataset</a>
    /// </summary>
    let includedWithDataset = _prefixId.prefix "includedWithDataset"
    /// <summary>
    ///   <para>rdfs:label : initiative type^^xsd:string</para>
    ///   <para>rdfs:comment : Value should be chosen from &lt;http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataset/InitiativeTypeCode&gt;^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#initiativeType">md:initiativeType</a>
    /// </summary>
    let initiativeType = _prefixId.prefix "initiativeType"
    /// <summary>
    ///   <para>rdfs:label : keyword^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#keyword">md:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>rdfs:label : language^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#language">md:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"

    /// <summary>
    ///   <para>rdfs:label : lens distortion information availability^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#lensDistortionInformationAvailability">md:lensDistortionInformationAvailability</a>
    /// </summary>
    let lensDistortionInformationAvailability = _prefixId.prefix "lensDistortionInformationAvailability"

    /// <summary>
    ///   <para>rdfs:label : locale^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#locale">md:locale</a>
    /// </summary>
    let locale = _prefixId.prefix "locale"
    /// <summary>
    ///   <para>rdfs:label : maintenance and update frequency^^xsd:string</para>
    ///   <para>rdfs:comment : Value should be chosen from &lt;http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata/MaintenanceFrequenceCode&gt;^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maintenanceAndUpdateFrequency">md:maintenanceAndUpdateFrequency</a>
    /// </summary>
    let maintenanceAndUpdateFrequency = _prefixId.prefix "maintenanceAndUpdateFrequency"
    /// <summary>
    ///   <para>rdfs:label : maintenance note^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maintenanceNote">md:maintenanceNote</a>
    /// </summary>
    let maintenanceNote = _prefixId.prefix "maintenanceNote"
    /// <summary>
    ///   <para>rdfs:label : max value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maxValue">md:maxValue</a>
    /// </summary>
    let maxValue = _prefixId.prefix "maxValue"
    /// <summary>
    ///   <para>rdfs:label : maximum occurrence^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#maximumOccurrence">md:maximumOccurrence</a>
    /// </summary>
    let maximumOccurrence = _prefixId.prefix "maximumOccurrence"
    /// <summary>
    ///   <para>rdfs:label : medium format^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#mediumFormat">md:mediumFormat</a>
    /// </summary>
    let mediumFormat = _prefixId.prefix "mediumFormat"
    /// <summary>
    ///   <para>rdfs:label : medium note^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#mediumNote">md:mediumNote</a>
    /// </summary>
    let mediumNote = _prefixId.prefix "mediumNote"
    /// <summary>
    ///   <para>rdfs:label : metadata constraints^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataConstraints">md:metadataConstraints</a>
    /// </summary>
    let metadataConstraints = _prefixId.prefix "metadataConstraints"
    /// <summary>
    ///   <para>rdfs:label : metadata extension info^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataExtensionInfo">md:metadataExtensionInfo</a>
    /// </summary>
    let metadataExtensionInfo = _prefixId.prefix "metadataExtensionInfo"
    /// <summary>
    ///   <para>rdfs:label : metadata maintenance^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataMaintenance">md:metadataMaintenance</a>
    /// </summary>
    let metadataMaintenance = _prefixId.prefix "metadataMaintenance"
    /// <summary>
    ///   <para>rdfs:label : metadata standard name^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataStandardName">md:metadataStandardName</a>
    /// </summary>
    let metadataStandardName = _prefixId.prefix "metadataStandardName"
    /// <summary>
    ///   <para>rdfs:label : metadata standard version^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#metadataStandardVersion">md:metadataStandardVersion</a>
    /// </summary>
    let metadataStandardVersion = _prefixId.prefix "metadataStandardVersion"
    /// <summary>
    ///   <para>rdfs:label : min value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#minValue">md:minValue</a>
    /// </summary>
    let minValue = _prefixId.prefix "minValue"
    /// <summary>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#name">md:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : number of dimensions^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#numberOfDimensions">md:numberOfDimensions</a>
    /// </summary>
    let numberOfDimensions = _prefixId.prefix "numberOfDimensions"
    /// <summary>
    ///   <para>rdfs:label : obligation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#obligation">md:obligation</a>
    /// </summary>
    let obligation = _prefixId.prefix "obligation"
    /// <summary>
    ///   <para>rdfs:label : off line^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#offLine">md:offLine</a>
    /// </summary>
    let offLine = _prefixId.prefix "offLine"
    /// <summary>
    ///   <para>rdfs:label : offset^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#offset">md:offset</a>
    /// </summary>
    let offset = _prefixId.prefix "offset"
    /// <summary>
    ///   <para>rdfs:label : online^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#online">md:online</a>
    /// </summary>
    let online = _prefixId.prefix "online"
    /// <summary>
    ///   <para>rdfs:label : ordering instructions^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#orderingInstructions">md:orderingInstructions</a>
    /// </summary>
    let orderingInstructions = _prefixId.prefix "orderingInstructions"

    /// <summary>
    ///   <para>rdfs:label : orientation parameter availability^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#orientationParameterAvailability">md:orientationParameterAvailability</a>
    /// </summary>
    let orientationParameterAvailability = _prefixId.prefix "orientationParameterAvailability"

    /// <summary>
    ///   <para>rdfs:label : orientation parameter description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#orientationParameterDescription">md:orientationParameterDescription</a>
    /// </summary>
    let orientationParameterDescription = _prefixId.prefix "orientationParameterDescription"

    /// <summary>
    ///   <para>rdfs:label : other constraints^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#otherConstraints">md:otherConstraints</a>
    /// </summary>
    let otherConstraints = _prefixId.prefix "otherConstraints"
    /// <summary>
    ///   <para>rdfs:label : parameter citation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#parameterCitation">md:parameterCitation</a>
    /// </summary>
    let parameterCitation = _prefixId.prefix "parameterCitation"
    /// <summary>
    ///   <para>rdfs:label : parent entity^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#parentEntity">md:parentEntity</a>
    /// </summary>
    let parentEntity = _prefixId.prefix "parentEntity"
    /// <summary>
    ///   <para>rdfs:label : parent identifier^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#parentIdentifier">md:parentIdentifier</a>
    /// </summary>
    let parentIdentifier = _prefixId.prefix "parentIdentifier"
    /// <summary>
    ///   <para>rdfs:label : peak response^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#peakResponse">md:peakResponse</a>
    /// </summary>
    let peakResponse = _prefixId.prefix "peakResponse"
    /// <summary>
    ///   <para>rdfs:label : planned available date time^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#plannedAvailableDateTime">md:plannedAvailableDateTime</a>
    /// </summary>
    let plannedAvailableDateTime = _prefixId.prefix "plannedAvailableDateTime"
    /// <summary>
    ///   <para>rdfs:label : point in pixel^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#pointInPixel">md:pointInPixel</a>
    /// </summary>
    let pointInPixel = _prefixId.prefix "pointInPixel"
    /// <summary>
    ///   <para>rdfs:label : point of contact^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#pointOfContact">md:pointOfContact</a>
    /// </summary>
    let pointOfContact = _prefixId.prefix "pointOfContact"
    /// <summary>
    ///   <para>rdfs:label : portrayal catalogue citation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#portrayalCatalogueCitation">md:portrayalCatalogueCitation</a>
    /// </summary>
    let portrayalCatalogueCitation = _prefixId.prefix "portrayalCatalogueCitation"
    /// <summary>
    ///   <para>rdfs:label : portrayal catalogue info^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#portrayalCatalogueInfo">md:portrayalCatalogueInfo</a>
    /// </summary>
    let portrayalCatalogueInfo = _prefixId.prefix "portrayalCatalogueInfo"
    /// <summary>
    ///   <para>rdfs:label : processing level code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#processingLevelCode">md:processingLevelCode</a>
    /// </summary>
    let processingLevelCode = _prefixId.prefix "processingLevelCode"
    /// <summary>
    ///   <para>rdfs:label : property type^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#propertyType">md:propertyType</a>
    /// </summary>
    let propertyType = _prefixId.prefix "propertyType"
    /// <summary>
    ///   <para>rdfs:label : purpose^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#purpose">md:purpose</a>
    /// </summary>
    let purpose = _prefixId.prefix "purpose"

    /// <summary>
    ///   <para>rdfs:label : radiometric calibration information availability^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#radiometricCalibrationInformationAvailability">md:radiometricCalibrationInformationAvailability</a>
    /// </summary>
    let radiometricCalibrationInformationAvailability = _prefixId.prefix "radiometricCalibrationInformationAvailability"

    /// <summary>
    ///   <para>rdfs:label : rationale^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#rationale">md:rationale</a>
    /// </summary>
    let rationale = _prefixId.prefix "rationale"
    /// <summary>
    ///   <para>rdfs:label : reference system identifier^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#referenceSystemIdentifier">md:referenceSystemIdentifier</a>
    /// </summary>
    let referenceSystemIdentifier = _prefixId.prefix "referenceSystemIdentifier"
    /// <summary>
    ///   <para>rdfs:label : reference system info^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#referenceSystemInfo">md:referenceSystemInfo</a>
    /// </summary>
    let referenceSystemInfo = _prefixId.prefix "referenceSystemInfo"
    /// <summary>
    ///   <para>rdfs:label : resolution^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resolution">md:resolution</a>
    /// </summary>
    let resolution = _prefixId.prefix "resolution"
    /// <summary>
    ///   <para>rdfs:label : resource constraints^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceConstraints">md:resourceConstraints</a>
    /// </summary>
    let resourceConstraints = _prefixId.prefix "resourceConstraints"
    /// <summary>
    ///   <para>rdfs:label : resource format^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceFormat">md:resourceFormat</a>
    /// </summary>
    let resourceFormat = _prefixId.prefix "resourceFormat"
    /// <summary>
    ///   <para>rdfs:label : resource maintenance^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceMaintenance">md:resourceMaintenance</a>
    /// </summary>
    let resourceMaintenance = _prefixId.prefix "resourceMaintenance"
    /// <summary>
    ///   <para>rdfs:label : resource specific usage^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#resourceSpecificUsage">md:resourceSpecificUsage</a>
    /// </summary>
    let resourceSpecificUsage = _prefixId.prefix "resourceSpecificUsage"
    /// <summary>
    ///   <para>rdfs:label : rule^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#rule">md:rule</a>
    /// </summary>
    let rule = _prefixId.prefix "rule"
    /// <summary>
    ///   <para>rdfs:label : scale factor^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#scaleFactor">md:scaleFactor</a>
    /// </summary>
    let scaleFactor = _prefixId.prefix "scaleFactor"
    /// <summary>
    ///   <para>rdfs:label : schema ascii^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#schemaAscii">md:schemaAscii</a>
    /// </summary>
    let schemaAscii = _prefixId.prefix "schemaAscii"
    /// <summary>
    ///   <para>rdfs:label : schema language^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#schemaLanguage">md:schemaLanguage</a>
    /// </summary>
    let schemaLanguage = _prefixId.prefix "schemaLanguage"
    /// <summary>
    ///   <para>rdfs:label : sequence identifier^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#sequenceIdentifier">md:sequenceIdentifier</a>
    /// </summary>
    let sequenceIdentifier = _prefixId.prefix "sequenceIdentifier"
    /// <summary>
    ///   <para>rdfs:label : series^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#series">md:series</a>
    /// </summary>
    let series = _prefixId.prefix "series"
    /// <summary>
    ///   <para>rdfs:label : short name^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#shortName">md:shortName</a>
    /// </summary>
    let shortName = _prefixId.prefix "shortName"
    /// <summary>
    ///   <para>rdfs:label : software development file^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#softwareDevelopmentFile">md:softwareDevelopmentFile</a>
    /// </summary>
    let softwareDevelopmentFile = _prefixId.prefix "softwareDevelopmentFile"
    /// <summary>
    ///   <para>rdfs:label : software development file format^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#softwareDevelopmentFileFormat">md:softwareDevelopmentFileFormat</a>
    /// </summary>
    let softwareDevelopmentFileFormat = _prefixId.prefix "softwareDevelopmentFileFormat"
    /// <summary>
    ///   <para>rdfs:label : source^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#source">md:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : spatial representation info^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#spatialRepresentationInfo">md:spatialRepresentationInfo</a>
    /// </summary>
    let spatialRepresentationInfo = _prefixId.prefix "spatialRepresentationInfo"
    /// <summary>
    ///   <para>rdfs:label : spatial representation type^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#spatialRepresentationType">md:spatialRepresentationType</a>
    /// </summary>
    let spatialRepresentationType = _prefixId.prefix "spatialRepresentationType"
    /// <summary>
    ///   <para>rdfs:label : spatial resolution^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#spatialResolution">md:spatialResolution</a>
    /// </summary>
    let spatialResolution = _prefixId.prefix "spatialResolution"
    /// <summary>
    ///   <para>rdfs:label : specific usage^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#specificUsage">md:specificUsage</a>
    /// </summary>
    let specificUsage = _prefixId.prefix "specificUsage"
    /// <summary>
    ///   <para>rdfs:label : specification^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#specification">md:specification</a>
    /// </summary>
    let specification = _prefixId.prefix "specification"
    /// <summary>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#status">md:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:label : supplemental information^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#supplementalInformation">md:supplementalInformation</a>
    /// </summary>
    let supplementalInformation = _prefixId.prefix "supplementalInformation"
    /// <summary>
    ///   <para>rdfs:label : thesaurus name^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#thesaurusName">md:thesaurusName</a>
    /// </summary>
    let thesaurusName = _prefixId.prefix "thesaurusName"
    /// <summary>
    ///   <para>rdfs:label : tone gradation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#toneGradation">md:toneGradation</a>
    /// </summary>
    let toneGradation = _prefixId.prefix "toneGradation"
    /// <summary>
    ///   <para>rdfs:label : topic category^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#topicCategory">md:topicCategory</a>
    /// </summary>
    let topicCategory = _prefixId.prefix "topicCategory"
    /// <summary>
    ///   <para>rdfs:label : topology level^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#topologyLevel">md:topologyLevel</a>
    /// </summary>
    let topologyLevel = _prefixId.prefix "topologyLevel"
    /// <summary>
    ///   <para>rdfs:label : transfer options^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transferOptions">md:transferOptions</a>
    /// </summary>
    let transferOptions = _prefixId.prefix "transferOptions"
    /// <summary>
    ///   <para>rdfs:label : transfer size^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transferSize">md:transferSize</a>
    /// </summary>
    let transferSize = _prefixId.prefix "transferSize"

    /// <summary>
    ///   <para>rdfs:label : transformation dimension description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transformationDimensionDescription">md:transformationDimensionDescription</a>
    /// </summary>
    let transformationDimensionDescription = _prefixId.prefix "transformationDimensionDescription"

    /// <summary>
    ///   <para>rdfs:label : transformation dimension mapping^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transformationDimensionMapping">md:transformationDimensionMapping</a>
    /// </summary>
    let transformationDimensionMapping = _prefixId.prefix "transformationDimensionMapping"

    /// <summary>
    ///   <para>rdfs:label : transformation parameter availability^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#transformationParameterAvailability">md:transformationParameterAvailability</a>
    /// </summary>
    let transformationParameterAvailability = _prefixId.prefix "transformationParameterAvailability"

    /// <summary>
    ///   <para>rdfs:label : triangulation indicator^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#triangulationIndicator">md:triangulationIndicator</a>
    /// </summary>
    let triangulationIndicator = _prefixId.prefix "triangulationIndicator"
    /// <summary>
    ///   <para>rdfs:label : turnaround^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#turnaround">md:turnaround</a>
    /// </summary>
    let turnaround = _prefixId.prefix "turnaround"
    /// <summary>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#type">md:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:label : units^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#units">md:units</a>
    /// </summary>
    let units = _prefixId.prefix "units"
    /// <summary>
    ///   <para>rdfs:label : units of distribution^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#unitsOfDistribution">md:unitsOfDistribution</a>
    /// </summary>
    let unitsOfDistribution = _prefixId.prefix "unitsOfDistribution"
    /// <summary>
    ///   <para>rdfs:label : update scope^^xsd:string</para>
    ///   <para>rdfs:comment : Value should be chosen from &lt;http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata/ScopeCode&gt;^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#updateScope">md:updateScope</a>
    /// </summary>
    let updateScope = _prefixId.prefix "updateScope"
    /// <summary>
    ///   <para>rdfs:label : update scope description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#updateScopeDescription">md:updateScopeDescription</a>
    /// </summary>
    let updateScopeDescription = _prefixId.prefix "updateScopeDescription"
    /// <summary>
    ///   <para>rdfs:label : usage date time^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#usageDateTime">md:usageDateTime</a>
    /// </summary>
    let usageDateTime = _prefixId.prefix "usageDateTime"
    /// <summary>
    ///   <para>rdfs:label : use constraints^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#useConstraints">md:useConstraints</a>
    /// </summary>
    let useConstraints = _prefixId.prefix "useConstraints"
    /// <summary>
    ///   <para>rdfs:label : use limitation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#useLimitation">md:useLimitation</a>
    /// </summary>
    let useLimitation = _prefixId.prefix "useLimitation"
    /// <summary>
    ///   <para>rdfs:label : user contact info^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userContactInfo">md:userContactInfo</a>
    /// </summary>
    let userContactInfo = _prefixId.prefix "userContactInfo"

    /// <summary>
    ///   <para>rdfs:label : user defined maintenance frequency^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userDefinedMaintenanceFrequency">md:userDefinedMaintenanceFrequency</a>
    /// </summary>
    let userDefinedMaintenanceFrequency = _prefixId.prefix "userDefinedMaintenanceFrequency"

    /// <summary>
    ///   <para>rdfs:label : user determined limitations^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userDeterminedLimitations">md:userDeterminedLimitations</a>
    /// </summary>
    let userDeterminedLimitations = _prefixId.prefix "userDeterminedLimitations"
    /// <summary>
    ///   <para>rdfs:label : user note^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#userNote">md:userNote</a>
    /// </summary>
    let userNote = _prefixId.prefix "userNote"
    /// <summary>
    ///   <para>rdfs:label : version^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#version">md:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
    /// <summary>
    ///   <para>rdfs:label : volumes^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#volumes">md:volumes</a>
    /// </summary>
    let volumes = _prefixId.prefix "volumes"
