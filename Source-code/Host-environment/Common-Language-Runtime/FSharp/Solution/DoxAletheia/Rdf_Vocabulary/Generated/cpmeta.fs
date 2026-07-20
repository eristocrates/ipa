namespace http.meta.icos_cp.eu.ontologies.cpmeta.slash

open DoxAletheia

module cpmeta =
    let _namespace_name = "http://meta.icos-cp.eu/ontologies/cpmeta/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/AS"></see>
    /// </summary>
    let AS = _prefix "AS"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/belongsToTheNetworkOf"></see>
    /// </summary>
    let belongsToTheNetworkOf = _prefix "belongsToTheNetworkOf"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/IcosStation"></see>
    /// </summary>
    let IcosStation = _prefix "IcosStation"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryDatum"></see>
    /// </summary>
    let AncillaryDatum = _prefix "AncillaryDatum"
    /// <summary>
    /// contains the ancillary value(s), submission date, and optional information date
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryEntry"></see></summary>
    let AncillaryEntry = _prefix "AncillaryEntry"
    /// <summary>
    /// the class of ancillary values coming from controlled vocabularies
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryValue"></see></summary>
    let AncillaryValue = _prefix "AncillaryValue"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/AtmoStation"></see>
    /// </summary>
    let AtmoStation = _prefix "AtmoStation"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Station"></see>
    /// </summary>
    let Station = _prefix "Station"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/CentralFacility"></see>
    /// </summary>
    let CentralFacility = _prefix "CentralFacility"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Organization"></see>
    /// </summary>
    let Organization = _prefix "Organization"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ClimateZone"></see>
    /// </summary>
    let ClimateZone = _prefix "ClimateZone"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Collection"></see>
    /// </summary>
    let Collection = _prefix "Collection"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isNextVersionOf"></see>
    /// </summary>
    let isNextVersionOf = _prefix "isNextVersionOf"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataObject"></see>
    /// </summary>
    let DataObject = _prefix "DataObject"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataAcquisition"></see>
    /// </summary>
    let DataAcquisition = _prefix "DataAcquisition"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasObjectSpec"></see>
    /// </summary>
    let hasObjectSpec = _prefix "hasObjectSpec"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/StaticObject"></see>
    /// </summary>
    let StaticObject = _prefix "StaticObject"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataObjectSpec"></see>
    /// </summary>
    let DataObjectSpec = _prefix "DataObjectSpec"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAssociatedProject"></see>
    /// </summary>
    let hasAssociatedProject = _prefix "hasAssociatedProject"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDataTheme"></see>
    /// </summary>
    let hasDataTheme = _prefix "hasDataTheme"
    /// <summary>
    /// data stream encoding, e.g. zip, gzip, plain file
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEncoding"></see></summary>
    let hasEncoding = _prefix "hasEncoding"
    /// <summary>
    /// format of the Data Object; will be used to determine the machinery for processing it
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFormat"></see></summary>
    let hasFormat = _prefix "hasFormat"
    /// <summary>
    /// Data level according to ICOS classification. Does not imply the data are official ICOS data.
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDataLevel"></see></summary>
    let hasDataLevel = _prefix "hasDataLevel"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataObjectSpecifyingThing"></see>
    /// </summary>
    let DataObjectSpecifyingThing = _prefix "DataObjectSpecifyingThing"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataProduction"></see>
    /// </summary>
    let DataProduction = _prefix "DataProduction"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedBy"></see>
    /// </summary>
    let wasPerformedBy = _prefix "wasPerformedBy"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataSubmission"></see>
    /// </summary>
    let DataSubmission = _prefix "DataSubmission"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataTheme"></see>
    /// </summary>
    let DataTheme = _prefix "DataTheme"
    /// <summary>
    /// URL link to SVG icon to be used in user interfaces
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasIcon"></see></summary>
    let hasIcon = _prefix "hasIcon"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DatasetColumn"></see>
    /// </summary>
    let DatasetColumn = _prefix "DatasetColumn"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasValueFormat"></see>
    /// </summary>
    let hasValueFormat = _prefix "hasValueFormat"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasValueType"></see>
    /// </summary>
    let hasValueType = _prefix "hasValueType"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasColumnTitle"></see>
    /// </summary>
    let hasColumnTitle = _prefix "hasColumnTitle"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DatasetSpec"></see>
    /// </summary>
    let DatasetSpec = _prefix "DatasetSpec"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DatasetVariable"></see>
    /// </summary>
    let DatasetVariable = _prefix "DatasetVariable"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVariableTitle"></see>
    /// </summary>
    let hasVariableTitle = _prefix "hasVariableTitle"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DocumentObject"></see>
    /// </summary>
    let DocumentObject = _prefix "DocumentObject"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ES"></see>
    /// </summary>
    let ES = _prefix "ES"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/EcosystemType"></see>
    /// </summary>
    let EcosystemType = _prefix "EcosystemType"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/FluxnetStation"></see>
    /// </summary>
    let FluxnetStation = _prefix "FluxnetStation"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Funder"></see>
    /// </summary>
    let Funder = _prefix "Funder"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Funding"></see>
    /// </summary>
    let Funding = _prefix "Funding"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFunder"></see>
    /// </summary>
    let hasFunder = _prefix "hasFunder"
    /// <summary>
    /// ISO 3166-1 alpha-2 country code
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/countryCode"></see></summary>
    let countryCode = _prefix "countryCode"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/IngosStation"></see>
    /// </summary>
    let IngosStation = _prefix "IngosStation"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Instrument"></see>
    /// </summary>
    let Instrument = _prefix "Instrument"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasInstrumentOwner"></see>
    /// </summary>
    let hasInstrumentOwner = _prefix "hasInstrumentOwner"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVendor"></see>
    /// </summary>
    let hasVendor = _prefix "hasVendor"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasModel"></see>
    /// </summary>
    let hasModel = _prefix "hasModel"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSerialNumber"></see>
    /// </summary>
    let hasSerialNumber = _prefix "hasSerialNumber"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/LatLonBox"></see>
    /// </summary>
    let LatLonBox = _prefix "LatLonBox"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/SpatialCoverage"></see>
    /// </summary>
    let SpatialCoverage = _prefix "SpatialCoverage"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEasternBound"></see>
    /// </summary>
    let hasEasternBound = _prefix "hasEasternBound"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasNorthernBound"></see>
    /// </summary>
    let hasNorthernBound = _prefix "hasNorthernBound"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSouthernBound"></see>
    /// </summary>
    let hasSouthernBound = _prefix "hasSouthernBound"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasWesternBound"></see>
    /// </summary>
    let hasWesternBound = _prefix "hasWesternBound"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Membership"></see>
    /// </summary>
    let Membership = _prefix "Membership"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/atOrganization"></see>
    /// </summary>
    let atOrganization = _prefix "atOrganization"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasRole"></see>
    /// </summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/NeonStation"></see>
    /// </summary>
    let NeonStation = _prefix "NeonStation"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/OS"></see>
    /// </summary>
    let OS = _prefix "OS"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ObjectEncoding"></see>
    /// </summary>
    let ObjectEncoding = _prefix "ObjectEncoding"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ObjectFormat"></see>
    /// </summary>
    let ObjectFormat = _prefix "ObjectFormat"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasName"></see>
    /// </summary>
    let hasName = _prefix "hasName"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEmail"></see>
    /// </summary>
    let hasEmail = _prefix "hasEmail"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFirstName"></see>
    /// </summary>
    let hasFirstName = _prefix "hasFirstName"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLastName"></see>
    /// </summary>
    let hasLastName = _prefix "hasLastName"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Position"></see>
    /// </summary>
    let Position = _prefix "Position"
    /// <summary>
    /// Decimal degrees in WGS84/GRS80
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLatitude"></see></summary>
    let hasLatitude = _prefix "hasLatitude"
    /// <summary>
    /// Decimal degrees in WGS84/GRS80
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLongitude"></see></summary>
    let hasLongitude = _prefix "hasLongitude"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Project"></see>
    /// </summary>
    let Project = _prefix "Project"
    /// <summary>
    /// The kind of physical quantity, for example volume, length, concentration. Can be basic or derived, standard or non-standard. Implies an associated physical quantity dimension but does not have a fixed unit of measurement.
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/QuantityKind"></see></summary>
    let QuantityKind = _prefix "QuantityKind"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Role"></see>
    /// </summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/SailDrone"></see>
    /// </summary>
    let SailDrone = _prefix "SailDrone"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/SimpleDataObject"></see>
    /// </summary>
    let SimpleDataObject = _prefix "SimpleDataObject"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/SpatialDataObject"></see>
    /// </summary>
    let SpatialDataObject = _prefix "SpatialDataObject"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasAcquiredBy"></see>
    /// </summary>
    let wasAcquiredBy = _prefix "wasAcquiredBy"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/SimpleObjectSpec"></see>
    /// </summary>
    let SimpleObjectSpec = _prefix "SimpleObjectSpec"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/containsDataset"></see>
    /// </summary>
    let containsDataset = _prefix "containsDataset"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/TabularDatasetSpec"></see>
    /// </summary>
    let TabularDatasetSpec = _prefix "TabularDatasetSpec"
    /// <summary>
    /// Physical research site
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Site"></see></summary>
    let Site = _prefix "Site"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEcosystemType"></see>
    /// </summary>
    let hasEcosystemType = _prefix "hasEcosystemType"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSpatialCoverage"></see>
    /// </summary>
    let hasSpatialCoverage = _prefix "hasSpatialCoverage"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasProducedBy"></see>
    /// </summary>
    let wasProducedBy = _prefix "wasProducedBy"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEndTime"></see>
    /// </summary>
    let hasEndTime = _prefix "hasEndTime"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStartTime"></see>
    /// </summary>
    let hasStartTime = _prefix "hasStartTime"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasSubmittedBy"></see>
    /// </summary>
    let wasSubmittedBy = _prefix "wasSubmittedBy"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStationId"></see>
    /// </summary>
    let hasStationId = _prefix "hasStationId"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/StringVocabulary"></see>
    /// </summary>
    let StringVocabulary = _prefix "StringVocabulary"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/containsString"></see>
    /// </summary>
    let containsString = _prefix "containsString"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ValueFormat"></see>
    /// </summary>
    let ValueFormat = _prefix "ValueFormat"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasColumn"></see>
    /// </summary>
    let hasColumn = _prefix "hasColumn"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ThematicCenter"></see>
    /// </summary>
    let ThematicCenter = _prefix "ThematicCenter"
    /// <summary>
    /// Domain-specific meaning of the values
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ValueType"></see></summary>
    let ValueType = _prefix "ValueType"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/VariableInfo"></see>
    /// </summary>
    let VariableInfo = _prefix "VariableInfo"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/WdcggStation"></see>
    /// </summary>
    let WdcggStation = _prefix "WdcggStation"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asGeoJSON"></see>
    /// </summary>
    let asGeoJSON = _prefix "asGeoJSON"
    /// <summary>
    /// Semicolon-separated ASCII, with #-prefixed multi-line header
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiAtcProductTimeSer"></see></summary>
    let asciiAtcProductTimeSer = _prefix "asciiAtcProductTimeSer"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasGoodFlagValue"></see>
    /// </summary>
    let hasGoodFlagValue = _prefix "hasGoodFlagValue"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiAtcTimeSer"></see>
    /// </summary>
    let asciiAtcTimeSer = _prefix "asciiAtcTimeSer"
    /// <summary>
    /// The first two columns are expected to be the beginning and the end of the averaging period in yyyyMMddHHmm format (no DST)
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiEtcHalfHourlyProductTimeSer"></see></summary>
    let asciiEtcHalfHourlyProductTimeSer = _prefix "asciiEtcHalfHourlyProductTimeSer"
    /// <summary>
    /// Local dateTime timestamp without any daylight savings time adjustments, that is, local winter time.
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/etcLocalDateTime"></see></summary>
    let etcLocalDateTime = _prefix "etcLocalDateTime"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiEtcRawTimeSer"></see>
    /// </summary>
    let asciiEtcRawTimeSer = _prefix "asciiEtcRawTimeSer"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiEtcTimeSer"></see>
    /// </summary>
    let asciiEtcTimeSer = _prefix "asciiEtcTimeSer"
    /// <summary>
    /// Single-line comment, first column is UTC ISO-8601 timestamp, NaN for missing values, comma-separated.
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiOtcProductCsv"></see></summary>
    let asciiOtcProductCsv = _prefix "asciiOtcProductCsv"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiOtcSocatTimeSer"></see>
    /// </summary>
    let asciiOtcSocatTimeSer = _prefix "asciiOtcSocatTimeSer"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiWdcggTimeSer"></see>
    /// </summary>
    let asciiWdcggTimeSer = _prefix "asciiWdcggTimeSer"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/awardNumber"></see>
    /// </summary>
    let awardNumber = _prefix "awardNumber"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/fundingInfoProp"></see>
    /// </summary>
    let fundingInfoProp = _prefix "fundingInfoProp"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/awardTitle"></see>
    /// </summary>
    let awardTitle = _prefix "awardTitle"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/awardURI"></see>
    /// </summary>
    let awardURI = _prefix "awardURI"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/binEtcRawTimeSer"></see>
    /// </summary>
    let binEtcRawTimeSer = _prefix "binEtcRawTimeSer"
    /// <summary>
    /// a character from the basic multilingual plane
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/bmpChar"></see></summary>
    let bmpChar = _prefix "bmpChar"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/broaderEcosystem"></see>
    /// </summary>
    let broaderEcosystem = _prefix "broaderEcosystem"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/country"></see>
    /// </summary>
    let country = _prefix "country"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStationSpecificParam"></see>
    /// </summary>
    let hasStationSpecificParam = _prefix "hasStationSpecificParam"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/csvWithIso8601tsFirstCol"></see>
    /// </summary>
    let csvWithIso8601tsFirstCol = _prefix "csvWithIso8601tsFirstCol"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/etcDate"></see>
    /// </summary>
    let etcDate = _prefix "etcDate"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/etcRawTimeSerMultiZip"></see>
    /// </summary>
    let etcRawTimeSerMultiZip = _prefix "etcRawTimeSerMultiZip"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/excel"></see>
    /// </summary>
    let excel = _prefix "excel"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/float32"></see>
    /// </summary>
    let float32 = _prefix "float32"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/float64"></see>
    /// </summary>
    let float64 = _prefix "float64"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/funderIdentifier"></see>
    /// </summary>
    let funderIdentifier = _prefix "funderIdentifier"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/funderIdentifierType"></see>
    /// </summary>
    let funderIdentifierType = _prefix "funderIdentifierType"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/gzipEncoding"></see>
    /// </summary>
    let gzipEncoding = _prefix "gzipEncoding"
    /// <summary>
    /// Contains a JSON array with actual column names
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasActualColumnNames"></see></summary>
    let hasActualColumnNames = _prefix "hasActualColumnNames"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasActualVariable"></see>
    /// </summary>
    let hasActualVariable = _prefix "hasActualVariable"
    /// <summary>
    /// parent property for ancillary value properties whose values are plain literals (not from vocabularies)
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryDataValue"></see></summary>
    let hasAncillaryDataValue = _prefix "hasAncillaryDataValue"
    /// <summary>
    /// ancillary entry associated with a station
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryEntry"></see></summary>
    let hasAncillaryEntry = _prefix "hasAncillaryEntry"
    /// <summary>
    /// parent property for ancillary value properties whose values come from controlled vocabularies
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryObjectValue"></see></summary>
    let hasAncillaryObjectValue = _prefix "hasAncillaryObjectValue"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAssociatedPublication"></see>
    /// </summary>
    let hasAssociatedPublication = _prefix "hasAssociatedPublication"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAtcId"></see>
    /// </summary>
    let hasAtcId = _prefix "hasAtcId"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasTcId"></see>
    /// </summary>
    let hasTcId = _prefix "hasTcId"
    /// <summary>
    /// to be used for determining the order of names in citation strings
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAttributionWeight"></see></summary>
    let hasAttributionWeight = _prefix "hasAttributionWeight"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasExtraRoleInfo"></see>
    /// </summary>
    let hasExtraRoleInfo = _prefix "hasExtraRoleInfo"
    /// <summary>
    /// a synthetic property; the RDF triples with it as a predicate are to be created by business-logic-based inference, not inserted into the triple store explicitly
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasCitationString"></see></summary>
    let hasCitationString = _prefix "hasCitationString"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasClimateZone"></see>
    /// </summary>
    let hasClimateZone = _prefix "hasClimateZone"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVariable"></see>
    /// </summary>
    let hasVariable = _prefix "hasVariable"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDepiction"></see>
    /// </summary>
    let hasDepiction = _prefix "hasDepiction"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDocumentationObject"></see>
    /// </summary>
    let hasDocumentationObject = _prefix "hasDocumentationObject"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDocumentationUri"></see>
    /// </summary>
    let hasDocumentationUri = _prefix "hasDocumentationUri"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDoi"></see>
    /// </summary>
    let hasDoi = _prefix "hasDoi"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/latlongs"></see>
    /// </summary>
    let latlongs = _prefix "latlongs"
    /// <summary>
    /// Elevation above sea level in meters
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasElevation"></see></summary>
    let hasElevation = _prefix "hasElevation"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEndDate"></see>
    /// </summary>
    let hasEndDate = _prefix "hasEndDate"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEtcId"></see>
    /// </summary>
    let hasEtcId = _prefix "hasEtcId"
    /// <summary>
    /// parent property for concrete format-specific metadata properties
    /// used for WDCGG data, may be retired in the future
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFormatSpecificMetadata"></see></summary>
    let hasFormatSpecificMetadata = _prefix "hasFormatSpecificMetadata"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFunding"></see>
    /// </summary>
    let hasFunding = _prefix "hasFunding"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasHideFromSearchPolicy"></see>
    /// </summary>
    let hasHideFromSearchPolicy = _prefix "hasHideFromSearchPolicy"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasPolicy"></see>
    /// </summary>
    let hasPolicy = _prefix "hasPolicy"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasInstrumentComponent"></see>
    /// </summary>
    let hasInstrumentComponent = _prefix "hasInstrumentComponent"
    /// <summary>
    /// A "virtual" property, created for keyword search in SPARQL. A multi-value counterpart of cpmeta:hasKeywords, which contains a string with comma-separated list of keywords.
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasKeyword"></see></summary>
    let hasKeyword = _prefix "hasKeyword"
    /// <summary>
    /// String representing a comma-separated list of keywords
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasKeywords"></see></summary>
    let hasKeywords = _prefix "hasKeywords"
    /// <summary>
    /// the date when the station was approved by ICOS and got labelled as an ICOS station
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLabelingDate"></see></summary>
    let hasLabelingDate = _prefix "hasLabelingDate"
    /// <summary>
    /// URL link to an icon that can be used by web apps to show e.g. locations of stations
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMarkerIcon"></see></summary>
    let hasMarkerIcon = _prefix "hasMarkerIcon"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMaxValue"></see>
    /// </summary>
    let hasMaxValue = _prefix "hasMaxValue"
    /// <summary>
    /// measured in mm
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualPrecip"></see></summary>
    let hasMeanAnnualPrecip = _prefix "hasMeanAnnualPrecip"
    /// <summary>
    /// measured in W m-2
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualRadiation"></see></summary>
    let hasMeanAnnualRadiation = _prefix "hasMeanAnnualRadiation"
    /// <summary>
    /// measured in °C
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualTemp"></see></summary>
    let hasMeanAnnualTemp = _prefix "hasMeanAnnualTemp"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMembership"></see>
    /// </summary>
    let hasMembership = _prefix "hasMembership"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMinValue"></see>
    /// </summary>
    let hasMinValue = _prefix "hasMinValue"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasNumberOfRows"></see>
    /// </summary>
    let hasNumberOfRows = _prefix "hasNumberOfRows"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasOperationalPeriod"></see>
    /// </summary>
    let hasOperationalPeriod = _prefix "hasOperationalPeriod"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasOrcidId"></see>
    /// </summary>
    let hasOrcidId = _prefix "hasOrcidId"
    /// <summary>
    /// umbrella property for organizing id-related properties
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStringId"></see></summary>
    let hasStringId = _prefix "hasStringId"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasOtcId"></see>
    /// </summary>
    let hasOtcId = _prefix "hasOtcId"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasQuantityKind"></see>
    /// </summary>
    let hasQuantityKind = _prefix "hasQuantityKind"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasResponsibleOrganization"></see>
    /// </summary>
    let hasResponsibleOrganization = _prefix "hasResponsibleOrganization"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSamplingHeight"></see>
    /// </summary>
    let hasSamplingHeight = _prefix "hasSamplingHeight"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSamplingPoint"></see>
    /// </summary>
    let hasSamplingPoint = _prefix "hasSamplingPoint"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSha256sum"></see>
    /// </summary>
    let hasSha256sum = _prefix "hasSha256sum"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSizeInBytes"></see>
    /// </summary>
    let hasSizeInBytes = _prefix "hasSizeInBytes"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSkipPidMintingPolicy"></see>
    /// </summary>
    let hasSkipPidMintingPolicy = _prefix "hasSkipPidMintingPolicy"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSkipStoragePolicy"></see>
    /// </summary>
    let hasSkipStoragePolicy = _prefix "hasSkipStoragePolicy"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStartDate"></see>
    /// </summary>
    let hasStartDate = _prefix "hasStartDate"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStationClass"></see>
    /// </summary>
    let hasStationClass = _prefix "hasStationClass"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasTemporalResolution"></see>
    /// </summary>
    let hasTemporalResolution = _prefix "hasTemporalResolution"
    /// <summary>
    /// offset of local timezone from UTC
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasTimeZoneOffset"></see></summary>
    let hasTimeZoneOffset = _prefix "hasTimeZoneOffset"
    /// <summary>
    /// unit of measurement
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasUnit"></see></summary>
    let hasUnit = _prefix "hasUnit"
    /// <summary>
    /// A "virtual" property only used to define a variable in SPARQL, to support variable-name search. Is a multi-valued counterpart of cpmeta:hasActualColumnNames (for SimpleDataObjects), which contains a JSON array. Also, used to indicate variable name that a sensor is measuring (via Deployment).
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVariableName"></see></summary>
    let hasVariableName = _prefix "hasVariableName"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasWigosId"></see>
    /// </summary>
    let hasWigosId = _prefix "hasWigosId"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/icosLicence"></see>
    /// </summary>
    let icosLicence = _prefix "icosLicence"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_BSV"></see>
    /// </summary>
    let igbp_BSV = _prefix "igbp_BSV"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_CRO"></see>
    /// </summary>
    let igbp_CRO = _prefix "igbp_CRO"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_CSH"></see>
    /// </summary>
    let igbp_CSH = _prefix "igbp_CSH"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_CVM"></see>
    /// </summary>
    let igbp_CVM = _prefix "igbp_CVM"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_DBF"></see>
    /// </summary>
    let igbp_DBF = _prefix "igbp_DBF"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_DNF"></see>
    /// </summary>
    let igbp_DNF = _prefix "igbp_DNF"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_EBF"></see>
    /// </summary>
    let igbp_EBF = _prefix "igbp_EBF"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_ENF"></see>
    /// </summary>
    let igbp_ENF = _prefix "igbp_ENF"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_GRA"></see>
    /// </summary>
    let igbp_GRA = _prefix "igbp_GRA"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_MF"></see>
    /// </summary>
    let igbp_MF = _prefix "igbp_MF"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_OSH"></see>
    /// </summary>
    let igbp_OSH = _prefix "igbp_OSH"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_SAV"></see>
    /// </summary>
    let igbp_SAV = _prefix "igbp_SAV"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_SNO"></see>
    /// </summary>
    let igbp_SNO = _prefix "igbp_SNO"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_URB"></see>
    /// </summary>
    let igbp_URB = _prefix "igbp_URB"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_WAT"></see>
    /// </summary>
    let igbp_WAT = _prefix "igbp_WAT"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_WET"></see>
    /// </summary>
    let igbp_WET = _prefix "igbp_WET"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_WSA"></see>
    /// </summary>
    let igbp_WSA = _prefix "igbp_WSA"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/image"></see>
    /// </summary>
    let image = _prefix "image"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/impliesDefaultLicence"></see>
    /// </summary>
    let impliesDefaultLicence = _prefix "impliesDefaultLicence"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ingosRar"></see>
    /// </summary>
    let ingosRar = _prefix "ingosRar"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/int32"></see>
    /// </summary>
    let int32 = _prefix "int32"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isOptionalColumn"></see>
    /// </summary>
    let isOptionalColumn = _prefix "isOptionalColumn"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isOptionalVariable"></see>
    /// </summary>
    let isOptionalVariable = _prefix "isOptionalVariable"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isQualityFlagFor"></see>
    /// </summary>
    let isQualityFlagFor = _prefix "isQualityFlagFor"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isRegexColumn"></see>
    /// </summary>
    let isRegexColumn = _prefix "isRegexColumn"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isRegexVariable"></see>
    /// </summary>
    let isRegexVariable = _prefix "isRegexVariable"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/iso8601date"></see>
    /// </summary>
    let iso8601date = _prefix "iso8601date"
    /// <summary>
    /// Internally represented as int64 milliseconds since Unix epoch.
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/iso8601dateTime"></see></summary>
    let iso8601dateTime = _prefix "iso8601dateTime"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/iso8601timeOfDay"></see>
    /// </summary>
    let iso8601timeOfDay = _prefix "iso8601timeOfDay"
    /// <summary>
    /// May use space instead of 'T' for separator
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isoLikeLocalDateTime"></see></summary>
    let isoLikeLocalDateTime = _prefix "isoLikeLocalDateTime"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Af"></see>
    /// </summary>
    let koppen_Af = _prefix "koppen_Af"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Am"></see>
    /// </summary>
    let koppen_Am = _prefix "koppen_Am"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Aw_As"></see>
    /// </summary>
    let koppen_Aw_As = _prefix "koppen_Aw_As"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BSh"></see>
    /// </summary>
    let koppen_BSh = _prefix "koppen_BSh"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BSk"></see>
    /// </summary>
    let koppen_BSk = _prefix "koppen_BSk"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BWh"></see>
    /// </summary>
    let koppen_BWh = _prefix "koppen_BWh"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BWk"></see>
    /// </summary>
    let koppen_BWk = _prefix "koppen_BWk"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cfa"></see>
    /// </summary>
    let koppen_Cfa = _prefix "koppen_Cfa"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cfb"></see>
    /// </summary>
    let koppen_Cfb = _prefix "koppen_Cfb"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cfc"></see>
    /// </summary>
    let koppen_Cfc = _prefix "koppen_Cfc"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Csa"></see>
    /// </summary>
    let koppen_Csa = _prefix "koppen_Csa"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Csb"></see>
    /// </summary>
    let koppen_Csb = _prefix "koppen_Csb"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Csc"></see>
    /// </summary>
    let koppen_Csc = _prefix "koppen_Csc"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cwa"></see>
    /// </summary>
    let koppen_Cwa = _prefix "koppen_Cwa"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cwb"></see>
    /// </summary>
    let koppen_Cwb = _prefix "koppen_Cwb"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cwc"></see>
    /// </summary>
    let koppen_Cwc = _prefix "koppen_Cwc"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfa"></see>
    /// </summary>
    let koppen_Dfa = _prefix "koppen_Dfa"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfb"></see>
    /// </summary>
    let koppen_Dfb = _prefix "koppen_Dfb"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfc"></see>
    /// </summary>
    let koppen_Dfc = _prefix "koppen_Dfc"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfd"></see>
    /// </summary>
    let koppen_Dfd = _prefix "koppen_Dfd"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsa"></see>
    /// </summary>
    let koppen_Dsa = _prefix "koppen_Dsa"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsb"></see>
    /// </summary>
    let koppen_Dsb = _prefix "koppen_Dsb"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsc"></see>
    /// </summary>
    let koppen_Dsc = _prefix "koppen_Dsc"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsd"></see>
    /// </summary>
    let koppen_Dsd = _prefix "koppen_Dsd"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwa"></see>
    /// </summary>
    let koppen_Dwa = _prefix "koppen_Dwa"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwb"></see>
    /// </summary>
    let koppen_Dwb = _prefix "koppen_Dwb"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwc"></see>
    /// </summary>
    let koppen_Dwc = _prefix "koppen_Dwc"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwd"></see>
    /// </summary>
    let koppen_Dwd = _prefix "koppen_Dwd"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_EF"></see>
    /// </summary>
    let koppen_EF = _prefix "koppen_EF"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_ET"></see>
    /// </summary>
    let koppen_ET = _prefix "koppen_ET"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/locatedAt"></see>
    /// </summary>
    let locatedAt = _prefix "locatedAt"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/multiImageZip"></see>
    /// </summary>
    let multiImageZip = _prefix "multiImageZip"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/netcdf"></see>
    /// </summary>
    let netcdf = _prefix "netcdf"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/netcdfTimeSeries"></see>
    /// </summary>
    let netcdfTimeSeries = _prefix "netcdfTimeSeries"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/operatesOn"></see>
    /// </summary>
    let operatesOn = _prefix "operatesOn"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/otcRawData"></see>
    /// </summary>
    let otcRawData = _prefix "otcRawData"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/plainFileEncoding"></see>
    /// </summary>
    let plainFileEncoding = _prefix "plainFileEncoding"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/string"></see>
    /// </summary>
    let string = _prefix "string"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasHostedBy"></see>
    /// </summary>
    let wasHostedBy = _prefix "wasHostedBy"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasParticipatedInBy"></see>
    /// </summary>
    let wasParticipatedInBy = _prefix "wasParticipatedInBy"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedAt"></see>
    /// </summary>
    let wasPerformedAt = _prefix "wasPerformedAt"
    /// <summary>
    /// instrument used to perform data acquisition
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedWith"></see></summary>
    let wasPerformedWith = _prefix "wasPerformedWith"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/zipArchive"></see>
    /// </summary>
    let zipArchive = _prefix "zipArchive"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/zipEncoding"></see>
    /// </summary>
    let zipEncoding = _prefix "zipEncoding"
