#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cpmeta =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://meta.icos-cp.eu/ontologies/cpmeta/" "cpmeta"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Atmospheric station^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/AS">cpmeta:AS</a>
    /// </summary>
    let AS = _prefixId.prefix "AS"
    let AncillaryDatum = _prefixId.prefix "AncillaryDatum"
    /// <summary>
    ///   <para>rdfs:label : Ancillary Entry^^xsd:string</para>
    ///   <para>rdfs:comment : contains the ancillary value(s), submission date, and optional information date^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryEntry">cpmeta:AncillaryEntry</a>
    /// </summary>
    let AncillaryEntry = _prefixId.prefix "AncillaryEntry"
    /// <summary>
    ///   <para>rdfs:label : Ancillary Value^^xsd:string</para>
    ///   <para>rdfs:comment : the class of ancillary values coming from controlled vocabularies^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryValue">cpmeta:AncillaryValue</a>
    /// </summary>
    let AncillaryValue = _prefixId.prefix "AncillaryValue"
    /// <summary>
    ///   <para>rdfs:label : ATMO station^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/AtmoStation">cpmeta:AtmoStation</a>
    /// </summary>
    let AtmoStation = _prefixId.prefix "AtmoStation"
    /// <summary>
    ///   <para>rdfs:label : Central Facility^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/CentralFacility">cpmeta:CentralFacility</a>
    /// </summary>
    let CentralFacility = _prefixId.prefix "CentralFacility"
    /// <summary>
    ///   <para>rdfs:label : Climate Zone^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/ClimateZone">cpmeta:ClimateZone</a>
    /// </summary>
    let ClimateZone = _prefixId.prefix "ClimateZone"
    let Collection = _prefixId.prefix "Collection"
    let DataAcquisition = _prefixId.prefix "DataAcquisition"
    let DataObject = _prefixId.prefix "DataObject"
    /// <summary>
    ///   <para>rdfs:label : Data Object specification^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/DataObjectSpec">cpmeta:DataObjectSpec</a>
    /// </summary>
    let DataObjectSpec = _prefixId.prefix "DataObjectSpec"
    let DataObjectSpecifyingThing = _prefixId.prefix "DataObjectSpecifyingThing"
    let DataProduction = _prefixId.prefix "DataProduction"
    let DataSubmission = _prefixId.prefix "DataSubmission"
    /// <summary>
    ///   <para>rdfs:label : Data Theme^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/DataTheme">cpmeta:DataTheme</a>
    /// </summary>
    let DataTheme = _prefixId.prefix "DataTheme"
    /// <summary>
    ///   <para>rdfs:label : Dataset column^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/DatasetColumn">cpmeta:DatasetColumn</a>
    /// </summary>
    let DatasetColumn = _prefixId.prefix "DatasetColumn"
    /// <summary>
    ///   <para>rdfs:label : Dataset Specification^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/DatasetSpec">cpmeta:DatasetSpec</a>
    /// </summary>
    let DatasetSpec = _prefixId.prefix "DatasetSpec"
    /// <summary>
    ///   <para>rdfs:label : Dataset variable^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/DatasetVariable">cpmeta:DatasetVariable</a>
    /// </summary>
    let DatasetVariable = _prefixId.prefix "DatasetVariable"
    let DocumentObject = _prefixId.prefix "DocumentObject"
    /// <summary>
    ///   <para>rdfs:label : Ecosystem station^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/ES">cpmeta:ES</a>
    /// </summary>
    let ES = _prefixId.prefix "ES"
    /// <summary>
    ///   <para>rdfs:label : Ecosystem Type^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/EcosystemType">cpmeta:EcosystemType</a>
    /// </summary>
    let EcosystemType = _prefixId.prefix "EcosystemType"
    /// <summary>
    ///   <para>rdfs:label : FLUXNET station^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/FluxnetStation">cpmeta:FluxnetStation</a>
    /// </summary>
    let FluxnetStation = _prefixId.prefix "FluxnetStation"
    let Funder = _prefixId.prefix "Funder"
    let Funding = _prefixId.prefix "Funding"
    /// <summary>
    ///   <para>rdfs:label : ICOS station^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/IcosStation">cpmeta:IcosStation</a>
    /// </summary>
    let IcosStation = _prefixId.prefix "IcosStation"
    /// <summary>
    ///   <para>rdfs:label : InGOS station^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/IngosStation">cpmeta:IngosStation</a>
    /// </summary>
    let IngosStation = _prefixId.prefix "IngosStation"
    let Instrument = _prefixId.prefix "Instrument"
    let LatLonBox = _prefixId.prefix "LatLonBox"
    /// <summary>
    ///   <para>rdfs:label : Membership^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/Membership">cpmeta:Membership</a>
    /// </summary>
    let Membership = _prefixId.prefix "Membership"
    /// <summary>
    ///   <para>rdfs:label : NEON station^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/NeonStation">cpmeta:NeonStation</a>
    /// </summary>
    let NeonStation = _prefixId.prefix "NeonStation"
    /// <summary>
    ///   <para>rdfs:label : Oceanic station^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/OS">cpmeta:OS</a>
    /// </summary>
    let OS = _prefixId.prefix "OS"
    let ObjectEncoding = _prefixId.prefix "ObjectEncoding"
    let ObjectFormat = _prefixId.prefix "ObjectFormat"
    let Organization = _prefixId.prefix "Organization"
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/Position">cpmeta:Position</a>
    /// </summary>
    let Position = _prefixId.prefix "Position"
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:label : Quantity Kind^^xsd:string</para>
    ///   <para>rdfs:comment : The kind of physical quantity, for example volume, length, concentration. Can be basic or derived, standard or non-standard. Implies an associated physical quantity dimension but does not have a fixed unit of measurement.^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/QuantityKind">cpmeta:QuantityKind</a>
    /// </summary>
    let QuantityKind = _prefixId.prefix "QuantityKind"
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Sail Drone^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/SailDrone">cpmeta:SailDrone</a>
    /// </summary>
    let SailDrone = _prefixId.prefix "SailDrone"
    let SimpleDataObject = _prefixId.prefix "SimpleDataObject"
    /// <summary>
    ///   <para>rdfs:label : Simple Object specification^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/SimpleObjectSpec">cpmeta:SimpleObjectSpec</a>
    /// </summary>
    let SimpleObjectSpec = _prefixId.prefix "SimpleObjectSpec"
    /// <summary>
    ///   <para>rdfs:comment : Physical research site^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/Site">cpmeta:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>rdfs:label : Spatial Coverage^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/SpatialCoverage">cpmeta:SpatialCoverage</a>
    /// </summary>
    let SpatialCoverage = _prefixId.prefix "SpatialCoverage"
    let SpatialDataObject = _prefixId.prefix "SpatialDataObject"
    let StaticObject = _prefixId.prefix "StaticObject"
    let Station = _prefixId.prefix "Station"
    let StringVocabulary = _prefixId.prefix "StringVocabulary"
    /// <summary>
    ///   <para>rdfs:label : Tabular Dataset Specification^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/TabularDatasetSpec">cpmeta:TabularDatasetSpec</a>
    /// </summary>
    let TabularDatasetSpec = _prefixId.prefix "TabularDatasetSpec"
    /// <summary>
    ///   <para>rdfs:label : Thematic Center^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/ThematicCenter">cpmeta:ThematicCenter</a>
    /// </summary>
    let ThematicCenter = _prefixId.prefix "ThematicCenter"
    let ValueFormat = _prefixId.prefix "ValueFormat"
    /// <summary>
    ///   <para>rdfs:label : Value Type^^xsd:string</para>
    ///   <para>rdfs:comment : Domain-specific meaning of the values^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/ValueType">cpmeta:ValueType</a>
    /// </summary>
    let ValueType = _prefixId.prefix "ValueType"
    let VariableInfo = _prefixId.prefix "VariableInfo"
    /// <summary>
    ///   <para>rdfs:label : WDCGG station^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/WdcggStation">cpmeta:WdcggStation</a>
    /// </summary>
    let WdcggStation = _prefixId.prefix "WdcggStation"
    /// <summary>
    ///   <para>rdfs:label : GeoJSON representation^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/asGeoJSON">cpmeta:asGeoJSON</a>
    /// </summary>
    let asGeoJSON = _prefixId.prefix "asGeoJSON"
    let asciiAtcProductTimeSer = _prefixId.prefix "asciiAtcProductTimeSer"
    let asciiAtcTimeSer = _prefixId.prefix "asciiAtcTimeSer"

    let asciiEtcHalfHourlyProductTimeSer =
        _prefixId.prefix "asciiEtcHalfHourlyProductTimeSer"

    let asciiEtcRawTimeSer = _prefixId.prefix "asciiEtcRawTimeSer"
    let asciiEtcTimeSer = _prefixId.prefix "asciiEtcTimeSer"
    let asciiOtcProductCsv = _prefixId.prefix "asciiOtcProductCsv"
    let asciiOtcSocatTimeSer = _prefixId.prefix "asciiOtcSocatTimeSer"
    let asciiWdcggTimeSer = _prefixId.prefix "asciiWdcggTimeSer"
    /// <summary>
    ///   <para>rdfs:label : at organization^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/atOrganization">cpmeta:atOrganization</a>
    /// </summary>
    let atOrganization = _prefixId.prefix "atOrganization"
    /// <summary>
    ///   <para>rdfs:label : award number^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/awardNumber">cpmeta:awardNumber</a>
    /// </summary>
    let awardNumber = _prefixId.prefix "awardNumber"
    /// <summary>
    ///   <para>rdfs:label : award title^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/awardTitle">cpmeta:awardTitle</a>
    /// </summary>
    let awardTitle = _prefixId.prefix "awardTitle"
    /// <summary>
    ///   <para>rdfs:label : award URI^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/awardURI">cpmeta:awardURI</a>
    /// </summary>
    let awardURI = _prefixId.prefix "awardURI"
    /// <summary>
    ///   <para>rdfs:label : belongs to thematic center^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/belongsToTheNetworkOf">cpmeta:belongsToTheNetworkOf</a>
    /// </summary>
    let belongsToTheNetworkOf = _prefixId.prefix "belongsToTheNetworkOf"
    let binEtcRawTimeSer = _prefixId.prefix "binEtcRawTimeSer"
    let bmpChar = _prefixId.prefix "bmpChar"
    /// <summary>
    ///   <para>rdfs:label : more general ecosystem^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/broaderEcosystem">cpmeta:broaderEcosystem</a>
    /// </summary>
    let broaderEcosystem = _prefixId.prefix "broaderEcosystem"
    /// <summary>
    ///   <para>rdfs:label : contains dataset^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/containsDataset">cpmeta:containsDataset</a>
    /// </summary>
    let containsDataset = _prefixId.prefix "containsDataset"
    let containsString = _prefixId.prefix "containsString"
    /// <summary>
    ///   <para>rdfs:label : Country^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/country">cpmeta:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:label : country code^^xsd:string</para>
    ///   <para>rdfs:comment : ISO 3166-1 alpha-2 country code^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/countryCode">cpmeta:countryCode</a>
    /// </summary>
    let countryCode = _prefixId.prefix "countryCode"
    let csvWithIso8601tsFirstCol = _prefixId.prefix "csvWithIso8601tsFirstCol"
    let etcDate = _prefixId.prefix "etcDate"
    let etcLocalDateTime = _prefixId.prefix "etcLocalDateTime"
    let etcRawTimeSerMultiZip = _prefixId.prefix "etcRawTimeSerMultiZip"
    let excel = _prefixId.prefix "excel"
    let float32 = _prefixId.prefix "float32"
    let float64 = _prefixId.prefix "float64"
    /// <summary>
    ///   <para>rdfs:label : funder identifier^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/funderIdentifier">cpmeta:funderIdentifier</a>
    /// </summary>
    let funderIdentifier = _prefixId.prefix "funderIdentifier"
    /// <summary>
    ///   <para>rdfs:label : funder identifier type^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/funderIdentifierType">cpmeta:funderIdentifierType</a>
    /// </summary>
    let funderIdentifierType = _prefixId.prefix "funderIdentifierType"
    let fundingInfoProp = _prefixId.prefix "fundingInfoProp"
    let gzipEncoding = _prefixId.prefix "gzipEncoding"
    /// <summary>
    ///   <para>rdfs:comment : Contains a JSON array with actual column names^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasActualColumnNames">cpmeta:hasActualColumnNames</a>
    /// </summary>
    let hasActualColumnNames = _prefixId.prefix "hasActualColumnNames"
    let hasActualVariable = _prefixId.prefix "hasActualVariable"
    /// <summary>
    ///   <para>rdfs:label : ancillary data value^^xsd:string</para>
    ///   <para>rdfs:comment : parent property for ancillary value properties whose values are plain literals (not from vocabularies)^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryDataValue">cpmeta:hasAncillaryDataValue</a>
    /// </summary>
    let hasAncillaryDataValue = _prefixId.prefix "hasAncillaryDataValue"
    /// <summary>
    ///   <para>rdfs:label : ancillary entry^^xsd:string</para>
    ///   <para>rdfs:comment : ancillary entry associated with a station^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryEntry">cpmeta:hasAncillaryEntry</a>
    /// </summary>
    let hasAncillaryEntry = _prefixId.prefix "hasAncillaryEntry"
    /// <summary>
    ///   <para>rdfs:label : ancillary object value^^xsd:string</para>
    ///   <para>rdfs:comment : parent property for ancillary value properties whose values come from controlled vocabularies^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryObjectValue">cpmeta:hasAncillaryObjectValue</a>
    /// </summary>
    let hasAncillaryObjectValue = _prefixId.prefix "hasAncillaryObjectValue"
    /// <summary>
    ///   <para>rdfs:label : associated with project^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAssociatedProject">cpmeta:hasAssociatedProject</a>
    /// </summary>
    let hasAssociatedProject = _prefixId.prefix "hasAssociatedProject"
    /// <summary>
    ///   <para>rdfs:label : associated publication^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAssociatedPublication">cpmeta:hasAssociatedPublication</a>
    /// </summary>
    let hasAssociatedPublication = _prefixId.prefix "hasAssociatedPublication"
    let hasAtcId = _prefixId.prefix "hasAtcId"
    /// <summary>
    ///   <para>rdfs:label : attribution weight^^xsd:string</para>
    ///   <para>rdfs:comment : to be used for determining the order of names in citation strings^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAttributionWeight">cpmeta:hasAttributionWeight</a>
    /// </summary>
    let hasAttributionWeight = _prefixId.prefix "hasAttributionWeight"
    /// <summary>
    ///   <para>rdfs:comment : a synthetic property; the RDF triples with it as a predicate are to be created by business-logic-based inference, not inserted into the triple store explicitly^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasCitationString">cpmeta:hasCitationString</a>
    /// </summary>
    let hasCitationString = _prefixId.prefix "hasCitationString"
    /// <summary>
    ///   <para>rdfs:label : climate zone^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasClimateZone">cpmeta:hasClimateZone</a>
    /// </summary>
    let hasClimateZone = _prefixId.prefix "hasClimateZone"
    /// <summary>
    ///   <para>rdfs:label : has column^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasColumn">cpmeta:hasColumn</a>
    /// </summary>
    let hasColumn = _prefixId.prefix "hasColumn"
    /// <summary>
    ///   <para>rdfs:label : column title^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasColumnTitle">cpmeta:hasColumnTitle</a>
    /// </summary>
    let hasColumnTitle = _prefixId.prefix "hasColumnTitle"
    /// <summary>
    ///   <para>rdfs:label : data level^^xsd:string</para>
    ///   <para>rdfs:comment : Data level according to ICOS classification. Does not imply the data are official ICOS data.^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDataLevel">cpmeta:hasDataLevel</a>
    /// </summary>
    let hasDataLevel = _prefixId.prefix "hasDataLevel"
    /// <summary>
    ///   <para>rdfs:label : has data theme^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDataTheme">cpmeta:hasDataTheme</a>
    /// </summary>
    let hasDataTheme = _prefixId.prefix "hasDataTheme"
    /// <summary>
    ///   <para>rdfs:label : has depiction^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDepiction">cpmeta:hasDepiction</a>
    /// </summary>
    let hasDepiction = _prefixId.prefix "hasDepiction"
    /// <summary>
    ///   <para>rdfs:label : has documentation^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDocumentationObject">cpmeta:hasDocumentationObject</a>
    /// </summary>
    let hasDocumentationObject = _prefixId.prefix "hasDocumentationObject"
    /// <summary>
    ///   <para>rdfs:label : documentation link^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDocumentationUri">cpmeta:hasDocumentationUri</a>
    /// </summary>
    let hasDocumentationUri = _prefixId.prefix "hasDocumentationUri"
    let hasDoi = _prefixId.prefix "hasDoi"
    /// <summary>
    ///   <para>rdfs:label : eastern bound^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEasternBound">cpmeta:hasEasternBound</a>
    /// </summary>
    let hasEasternBound = _prefixId.prefix "hasEasternBound"
    /// <summary>
    ///   <para>rdfs:label : ecosystem type^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEcosystemType">cpmeta:hasEcosystemType</a>
    /// </summary>
    let hasEcosystemType = _prefixId.prefix "hasEcosystemType"
    /// <summary>
    ///   <para>rdfs:label : Elevation^^xsd:string</para>
    ///   <para>rdfs:comment : Elevation above sea level in meters^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasElevation">cpmeta:hasElevation</a>
    /// </summary>
    let hasElevation = _prefixId.prefix "hasElevation"
    /// <summary>
    ///   <para>rdfs:label : E-mail^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEmail">cpmeta:hasEmail</a>
    /// </summary>
    let hasEmail = _prefixId.prefix "hasEmail"
    /// <summary>
    ///   <para>rdfs:label : encoding^^xsd:string</para>
    ///   <para>rdfs:comment : data stream encoding, e.g. zip, gzip, plain file^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEncoding">cpmeta:hasEncoding</a>
    /// </summary>
    let hasEncoding = _prefixId.prefix "hasEncoding"
    /// <summary>
    ///   <para>rdfs:label : end date^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEndDate">cpmeta:hasEndDate</a>
    /// </summary>
    let hasEndDate = _prefixId.prefix "hasEndDate"
    /// <summary>
    ///   <para>rdfs:label : end time^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEndTime">cpmeta:hasEndTime</a>
    /// </summary>
    let hasEndTime = _prefixId.prefix "hasEndTime"
    let hasEtcId = _prefixId.prefix "hasEtcId"
    /// <summary>
    ///   <para>rdfs:label : extra role info^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasExtraRoleInfo">cpmeta:hasExtraRoleInfo</a>
    /// </summary>
    let hasExtraRoleInfo = _prefixId.prefix "hasExtraRoleInfo"
    /// <summary>
    ///   <para>rdfs:label : first name^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFirstName">cpmeta:hasFirstName</a>
    /// </summary>
    let hasFirstName = _prefixId.prefix "hasFirstName"
    /// <summary>
    ///   <para>rdfs:label : format^^xsd:string</para>
    ///   <para>rdfs:comment : format of the Data Object; will be used to determine the machinery for processing it^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFormat">cpmeta:hasFormat</a>
    /// </summary>
    let hasFormat = _prefixId.prefix "hasFormat"
    /// <summary>
    ///   <para>rdfs:label : format-specific metadata^^xsd:string</para>
    ///   <para>rdfs:comment : parent property for concrete format-specific metadata properties^^xsd:stringrdfs:comment : used for WDCGG data, may be retired in the future^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFormatSpecificMetadata">cpmeta:hasFormatSpecificMetadata</a>
    /// </summary>
    let hasFormatSpecificMetadata = _prefixId.prefix "hasFormatSpecificMetadata"
    /// <summary>
    ///   <para>rdfs:label : funder^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFunder">cpmeta:hasFunder</a>
    /// </summary>
    let hasFunder = _prefixId.prefix "hasFunder"
    /// <summary>
    ///   <para>rdfs:label : has funding^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFunding">cpmeta:hasFunding</a>
    /// </summary>
    let hasFunding = _prefixId.prefix "hasFunding"
    let hasGoodFlagValue = _prefixId.prefix "hasGoodFlagValue"
    let hasHideFromSearchPolicy = _prefixId.prefix "hasHideFromSearchPolicy"
    /// <summary>
    ///   <para>rdfs:label : has icon^^xsd:string</para>
    ///   <para>rdfs:comment : URL link to SVG icon to be used in user interfaces^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasIcon">cpmeta:hasIcon</a>
    /// </summary>
    let hasIcon = _prefixId.prefix "hasIcon"
    let hasInstrumentComponent = _prefixId.prefix "hasInstrumentComponent"
    let hasInstrumentOwner = _prefixId.prefix "hasInstrumentOwner"
    /// <summary>
    ///   <para>rdfs:comment : A "virtual" property, created for keyword search in SPARQL. A multi-value counterpart of cpmeta:hasKeywords, which contains a string with comma-separated list of keywords.^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasKeyword">cpmeta:hasKeyword</a>
    /// </summary>
    let hasKeyword = _prefixId.prefix "hasKeyword"
    /// <summary>
    ///   <para>rdfs:comment : String representing a comma-separated list of keywords^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasKeywords">cpmeta:hasKeywords</a>
    /// </summary>
    let hasKeywords = _prefixId.prefix "hasKeywords"
    /// <summary>
    ///   <para>rdfs:label : labelling date^^xsd:string</para>
    ///   <para>rdfs:comment : the date when the station was approved by ICOS and got labelled as an ICOS station^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLabelingDate">cpmeta:hasLabelingDate</a>
    /// </summary>
    let hasLabelingDate = _prefixId.prefix "hasLabelingDate"
    /// <summary>
    ///   <para>rdfs:label : last name^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLastName">cpmeta:hasLastName</a>
    /// </summary>
    let hasLastName = _prefixId.prefix "hasLastName"
    /// <summary>
    ///   <para>rdfs:label : Latitude^^xsd:string</para>
    ///   <para>rdfs:comment : Decimal degrees in WGS84/GRS80^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLatitude">cpmeta:hasLatitude</a>
    /// </summary>
    let hasLatitude = _prefixId.prefix "hasLatitude"
    /// <summary>
    ///   <para>rdfs:label : Longitude^^xsd:string</para>
    ///   <para>rdfs:comment : Decimal degrees in WGS84/GRS80^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLongitude">cpmeta:hasLongitude</a>
    /// </summary>
    let hasLongitude = _prefixId.prefix "hasLongitude"
    /// <summary>
    ///   <para>rdfs:label : has marker icon^^xsd:string</para>
    ///   <para>rdfs:comment : URL link to an icon that can be used by web apps to show e.g. locations of stations^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMarkerIcon">cpmeta:hasMarkerIcon</a>
    /// </summary>
    let hasMarkerIcon = _prefixId.prefix "hasMarkerIcon"
    let hasMaxValue = _prefixId.prefix "hasMaxValue"
    /// <summary>
    ///   <para>rdfs:label : mean annual precipitation^^xsd:string</para>
    ///   <para>rdfs:comment : measured in mm^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualPrecip">cpmeta:hasMeanAnnualPrecip</a>
    /// </summary>
    let hasMeanAnnualPrecip = _prefixId.prefix "hasMeanAnnualPrecip"
    /// <summary>
    ///   <para>rdfs:label : mean annual radiation^^xsd:string</para>
    ///   <para>rdfs:comment : measured in W m-2^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualRadiation">cpmeta:hasMeanAnnualRadiation</a>
    /// </summary>
    let hasMeanAnnualRadiation = _prefixId.prefix "hasMeanAnnualRadiation"
    /// <summary>
    ///   <para>rdfs:label : mean annual temperature^^xsd:string</para>
    ///   <para>rdfs:comment : measured in °C^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualTemp">cpmeta:hasMeanAnnualTemp</a>
    /// </summary>
    let hasMeanAnnualTemp = _prefixId.prefix "hasMeanAnnualTemp"
    /// <summary>
    ///   <para>rdfs:label : has membership^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMembership">cpmeta:hasMembership</a>
    /// </summary>
    let hasMembership = _prefixId.prefix "hasMembership"
    let hasMinValue = _prefixId.prefix "hasMinValue"
    /// <summary>
    ///   <para>rdfs:label : instrument model^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasModel">cpmeta:hasModel</a>
    /// </summary>
    let hasModel = _prefixId.prefix "hasModel"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasName">cpmeta:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:label : northern bound^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasNorthernBound">cpmeta:hasNorthernBound</a>
    /// </summary>
    let hasNorthernBound = _prefixId.prefix "hasNorthernBound"
    /// <summary>
    ///   <para>rdfs:label : number of rows^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasNumberOfRows">cpmeta:hasNumberOfRows</a>
    /// </summary>
    let hasNumberOfRows = _prefixId.prefix "hasNumberOfRows"
    /// <summary>
    ///   <para>rdfs:label : has specification^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasObjectSpec">cpmeta:hasObjectSpec</a>
    /// </summary>
    let hasObjectSpec = _prefixId.prefix "hasObjectSpec"
    /// <summary>
    ///   <para>rdfs:label : operational period^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasOperationalPeriod">cpmeta:hasOperationalPeriod</a>
    /// </summary>
    let hasOperationalPeriod = _prefixId.prefix "hasOperationalPeriod"
    /// <summary>
    ///   <para>rdfs:label : Orcid ID^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasOrcidId">cpmeta:hasOrcidId</a>
    /// </summary>
    let hasOrcidId = _prefixId.prefix "hasOrcidId"
    let hasOtcId = _prefixId.prefix "hasOtcId"
    let hasPolicy = _prefixId.prefix "hasPolicy"
    /// <summary>
    ///   <para>rdfs:label : quantity kind^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasQuantityKind">cpmeta:hasQuantityKind</a>
    /// </summary>
    let hasQuantityKind = _prefixId.prefix "hasQuantityKind"
    /// <summary>
    ///   <para>rdfs:label : responsible organization^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasResponsibleOrganization">cpmeta:hasResponsibleOrganization</a>
    /// </summary>
    let hasResponsibleOrganization = _prefixId.prefix "hasResponsibleOrganization"
    /// <summary>
    ///   <para>rdfs:label : has role^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasRole">cpmeta:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    let hasSamplingHeight = _prefixId.prefix "hasSamplingHeight"
    let hasSamplingPoint = _prefixId.prefix "hasSamplingPoint"
    /// <summary>
    ///   <para>rdfs:label : serial number^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSerialNumber">cpmeta:hasSerialNumber</a>
    /// </summary>
    let hasSerialNumber = _prefixId.prefix "hasSerialNumber"
    /// <summary>
    ///   <para>rdfs:label : SHA-256 hashsum^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSha256sum">cpmeta:hasSha256sum</a>
    /// </summary>
    let hasSha256sum = _prefixId.prefix "hasSha256sum"
    let hasSizeInBytes = _prefixId.prefix "hasSizeInBytes"
    let hasSkipPidMintingPolicy = _prefixId.prefix "hasSkipPidMintingPolicy"
    let hasSkipStoragePolicy = _prefixId.prefix "hasSkipStoragePolicy"
    /// <summary>
    ///   <para>rdfs:label : southern bound^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSouthernBound">cpmeta:hasSouthernBound</a>
    /// </summary>
    let hasSouthernBound = _prefixId.prefix "hasSouthernBound"
    /// <summary>
    ///   <para>rdfs:label : spatial coverage^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSpatialCoverage">cpmeta:hasSpatialCoverage</a>
    /// </summary>
    let hasSpatialCoverage = _prefixId.prefix "hasSpatialCoverage"
    /// <summary>
    ///   <para>rdfs:label : start date^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStartDate">cpmeta:hasStartDate</a>
    /// </summary>
    let hasStartDate = _prefixId.prefix "hasStartDate"
    /// <summary>
    ///   <para>rdfs:label : start time^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStartTime">cpmeta:hasStartTime</a>
    /// </summary>
    let hasStartTime = _prefixId.prefix "hasStartTime"
    /// <summary>
    ///   <para>rdfs:label : Station Class^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStationClass">cpmeta:hasStationClass</a>
    /// </summary>
    let hasStationClass = _prefixId.prefix "hasStationClass"
    /// <summary>
    ///   <para>rdfs:label : Station ID^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStationId">cpmeta:hasStationId</a>
    /// </summary>
    let hasStationId = _prefixId.prefix "hasStationId"
    let hasStationSpecificParam = _prefixId.prefix "hasStationSpecificParam"
    /// <summary>
    ///   <para>rdfs:comment : umbrella property for organizing id-related properties^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStringId">cpmeta:hasStringId</a>
    /// </summary>
    let hasStringId = _prefixId.prefix "hasStringId"
    let hasTcId = _prefixId.prefix "hasTcId"
    let hasTemporalResolution = _prefixId.prefix "hasTemporalResolution"
    /// <summary>
    ///   <para>rdfs:label : time zone offset^^xsd:string</para>
    ///   <para>rdfs:comment : offset of local timezone from UTC^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasTimeZoneOffset">cpmeta:hasTimeZoneOffset</a>
    /// </summary>
    let hasTimeZoneOffset = _prefixId.prefix "hasTimeZoneOffset"
    /// <summary>
    ///   <para>rdfs:label : unit^^xsd:string</para>
    ///   <para>rdfs:comment : unit of measurement^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasUnit">cpmeta:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    /// <summary>
    ///   <para>rdfs:label : value format^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasValueFormat">cpmeta:hasValueFormat</a>
    /// </summary>
    let hasValueFormat = _prefixId.prefix "hasValueFormat"
    /// <summary>
    ///   <para>rdfs:label : value type^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasValueType">cpmeta:hasValueType</a>
    /// </summary>
    let hasValueType = _prefixId.prefix "hasValueType"
    /// <summary>
    ///   <para>rdfs:label : has variable^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVariable">cpmeta:hasVariable</a>
    /// </summary>
    let hasVariable = _prefixId.prefix "hasVariable"
    /// <summary>
    ///   <para>rdfs:comment : A "virtual" property only used to define a variable in SPARQL, to support variable-name search. Is a multi-valued counterpart of cpmeta:hasActualColumnNames (for SimpleDataObjects), which contains a JSON array. Also, used to indicate variable name that a sensor is measuring (via Deployment).^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVariableName">cpmeta:hasVariableName</a>
    /// </summary>
    let hasVariableName = _prefixId.prefix "hasVariableName"
    /// <summary>
    ///   <para>rdfs:label : variable title^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVariableTitle">cpmeta:hasVariableTitle</a>
    /// </summary>
    let hasVariableTitle = _prefixId.prefix "hasVariableTitle"
    let hasVendor = _prefixId.prefix "hasVendor"
    /// <summary>
    ///   <para>rdfs:label : western bound^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasWesternBound">cpmeta:hasWesternBound</a>
    /// </summary>
    let hasWesternBound = _prefixId.prefix "hasWesternBound"
    /// <summary>
    ///   <para>rdfs:label : WIGOS ID^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/hasWigosId">cpmeta:hasWigosId</a>
    /// </summary>
    let hasWigosId = _prefixId.prefix "hasWigosId"
    let icosLicence = _prefixId.prefix "icosLicence"
    let igbp_BSV = _prefixId.prefix "igbp_BSV"
    let igbp_CRO = _prefixId.prefix "igbp_CRO"
    let igbp_CSH = _prefixId.prefix "igbp_CSH"
    let igbp_CVM = _prefixId.prefix "igbp_CVM"
    let igbp_DBF = _prefixId.prefix "igbp_DBF"
    let igbp_DNF = _prefixId.prefix "igbp_DNF"
    let igbp_EBF = _prefixId.prefix "igbp_EBF"
    let igbp_ENF = _prefixId.prefix "igbp_ENF"
    let igbp_GRA = _prefixId.prefix "igbp_GRA"
    let igbp_MF = _prefixId.prefix "igbp_MF"
    let igbp_OSH = _prefixId.prefix "igbp_OSH"
    let igbp_SAV = _prefixId.prefix "igbp_SAV"
    let igbp_SNO = _prefixId.prefix "igbp_SNO"
    let igbp_URB = _prefixId.prefix "igbp_URB"
    let igbp_WAT = _prefixId.prefix "igbp_WAT"
    let igbp_WET = _prefixId.prefix "igbp_WET"
    let igbp_WSA = _prefixId.prefix "igbp_WSA"
    let image = _prefixId.prefix "image"
    /// <summary>
    ///   <para>rdfs:label : implies default licence^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/impliesDefaultLicence">cpmeta:impliesDefaultLicence</a>
    /// </summary>
    let impliesDefaultLicence = _prefixId.prefix "impliesDefaultLicence"
    let ingosRar = _prefixId.prefix "ingosRar"
    let int32 = _prefixId.prefix "int32"
    let isNextVersionOf = _prefixId.prefix "isNextVersionOf"
    let isOptionalColumn = _prefixId.prefix "isOptionalColumn"
    let isOptionalVariable = _prefixId.prefix "isOptionalVariable"
    /// <summary>
    ///   <para>rdfs:label : is a quality flag for^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/isQualityFlagFor">cpmeta:isQualityFlagFor</a>
    /// </summary>
    let isQualityFlagFor = _prefixId.prefix "isQualityFlagFor"
    let isRegexColumn = _prefixId.prefix "isRegexColumn"
    let isRegexVariable = _prefixId.prefix "isRegexVariable"
    let iso8601date = _prefixId.prefix "iso8601date"
    let iso8601dateTime = _prefixId.prefix "iso8601dateTime"
    let iso8601timeOfDay = _prefixId.prefix "iso8601timeOfDay"
    let isoLikeLocalDateTime = _prefixId.prefix "isoLikeLocalDateTime"
    let koppen_Af = _prefixId.prefix "koppen_Af"
    let koppen_Am = _prefixId.prefix "koppen_Am"
    let koppen_Aw_As = _prefixId.prefix "koppen_Aw_As"
    let koppen_BSh = _prefixId.prefix "koppen_BSh"
    let koppen_BSk = _prefixId.prefix "koppen_BSk"
    let koppen_BWh = _prefixId.prefix "koppen_BWh"
    let koppen_BWk = _prefixId.prefix "koppen_BWk"
    let koppen_Cfa = _prefixId.prefix "koppen_Cfa"
    let koppen_Cfb = _prefixId.prefix "koppen_Cfb"
    let koppen_Cfc = _prefixId.prefix "koppen_Cfc"
    let koppen_Csa = _prefixId.prefix "koppen_Csa"
    let koppen_Csb = _prefixId.prefix "koppen_Csb"
    let koppen_Csc = _prefixId.prefix "koppen_Csc"
    let koppen_Cwa = _prefixId.prefix "koppen_Cwa"
    let koppen_Cwb = _prefixId.prefix "koppen_Cwb"
    let koppen_Cwc = _prefixId.prefix "koppen_Cwc"
    let koppen_Dfa = _prefixId.prefix "koppen_Dfa"
    let koppen_Dfb = _prefixId.prefix "koppen_Dfb"
    let koppen_Dfc = _prefixId.prefix "koppen_Dfc"
    let koppen_Dfd = _prefixId.prefix "koppen_Dfd"
    let koppen_Dsa = _prefixId.prefix "koppen_Dsa"
    let koppen_Dsb = _prefixId.prefix "koppen_Dsb"
    let koppen_Dsc = _prefixId.prefix "koppen_Dsc"
    let koppen_Dsd = _prefixId.prefix "koppen_Dsd"
    let koppen_Dwa = _prefixId.prefix "koppen_Dwa"
    let koppen_Dwb = _prefixId.prefix "koppen_Dwb"
    let koppen_Dwc = _prefixId.prefix "koppen_Dwc"
    let koppen_Dwd = _prefixId.prefix "koppen_Dwd"
    let koppen_EF = _prefixId.prefix "koppen_EF"
    let koppen_ET = _prefixId.prefix "koppen_ET"
    let latlongs = _prefixId.prefix "latlongs"
    /// <summary>
    ///   <para>rdfs:label : located at^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/locatedAt">cpmeta:locatedAt</a>
    /// </summary>
    let locatedAt = _prefixId.prefix "locatedAt"
    let multiImageZip = _prefixId.prefix "multiImageZip"
    let netcdf = _prefixId.prefix "netcdf"
    let netcdfTimeSeries = _prefixId.prefix "netcdfTimeSeries"
    /// <summary>
    ///   <para>rdfs:label : operates on^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/operatesOn">cpmeta:operatesOn</a>
    /// </summary>
    let operatesOn = _prefixId.prefix "operatesOn"
    let otcRawData = _prefixId.prefix "otcRawData"
    let plainFileEncoding = _prefixId.prefix "plainFileEncoding"
    let string = _prefixId.prefix "string"
    /// <summary>
    ///   <para>rdfs:label : was acquired by^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/wasAcquiredBy">cpmeta:wasAcquiredBy</a>
    /// </summary>
    let wasAcquiredBy = _prefixId.prefix "wasAcquiredBy"
    let wasHostedBy = _prefixId.prefix "wasHostedBy"
    let wasParticipatedInBy = _prefixId.prefix "wasParticipatedInBy"
    /// <summary>
    ///   <para>rdfs:label : was performed at^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedAt">cpmeta:wasPerformedAt</a>
    /// </summary>
    let wasPerformedAt = _prefixId.prefix "wasPerformedAt"
    let wasPerformedBy = _prefixId.prefix "wasPerformedBy"
    /// <summary>
    ///   <para>rdfs:comment : instrument used to perform data acquisition^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedWith">cpmeta:wasPerformedWith</a>
    /// </summary>
    let wasPerformedWith = _prefixId.prefix "wasPerformedWith"
    /// <summary>
    ///   <para>rdfs:label : was produced by^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/wasProducedBy">cpmeta:wasProducedBy</a>
    /// </summary>
    let wasProducedBy = _prefixId.prefix "wasProducedBy"
    /// <summary>
    ///   <para>rdfs:label : was submitted by^^xsd:string</para>
    ///   <a href="http://meta.icos-cp.eu/ontologies/cpmeta/wasSubmittedBy">cpmeta:wasSubmittedBy</a>
    /// </summary>
    let wasSubmittedBy = _prefixId.prefix "wasSubmittedBy"
    let zipArchive = _prefixId.prefix "zipArchive"
    let zipEncoding = _prefixId.prefix "zipEncoding"
