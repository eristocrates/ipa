namespace http.meta.icos_cp.eu.ontologies.cpmeta.slash

open DoxAletheia.Rdf_Vocabulary

module cpmeta =
    let _namespace_name = "http://meta.icos-cp.eu/ontologies/cpmeta/"
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/AS"></see>
    /// </summary>
    let AS = Namespaced_IRI.parse _namespace_name "AS" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/belongsToTheNetworkOf"></see>
    /// </summary>
    let belongsToTheNetworkOf =
        Namespaced_IRI.parse _namespace_name "belongsToTheNetworkOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/IcosStation"></see>
    /// </summary>
    let IcosStation =
        Namespaced_IRI.parse _namespace_name "IcosStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryDatum"></see>
    /// </summary>
    let AncillaryDatum =
        Namespaced_IRI.parse _namespace_name "AncillaryDatum" |> NamespacedName

    /// <summary>
    /// contains the ancillary value(s), submission date, and optional information date
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryEntry"></see></summary>
    let AncillaryEntry =
        Namespaced_IRI.parse _namespace_name "AncillaryEntry" |> NamespacedName

    /// <summary>
    /// the class of ancillary values coming from controlled vocabularies
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryValue"></see></summary>
    let AncillaryValue =
        Namespaced_IRI.parse _namespace_name "AncillaryValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/AtmoStation"></see>
    /// </summary>
    let AtmoStation =
        Namespaced_IRI.parse _namespace_name "AtmoStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Station"></see>
    /// </summary>
    let Station = Namespaced_IRI.parse _namespace_name "Station" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/CentralFacility"></see>
    /// </summary>
    let CentralFacility =
        Namespaced_IRI.parse _namespace_name "CentralFacility" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Organization"></see>
    /// </summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ClimateZone"></see>
    /// </summary>
    let ClimateZone =
        Namespaced_IRI.parse _namespace_name "ClimateZone" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Collection"></see>
    /// </summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isNextVersionOf"></see>
    /// </summary>
    let isNextVersionOf =
        Namespaced_IRI.parse _namespace_name "isNextVersionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataObject"></see>
    /// </summary>
    let DataObject = Namespaced_IRI.parse _namespace_name "DataObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataAcquisition"></see>
    /// </summary>
    let DataAcquisition =
        Namespaced_IRI.parse _namespace_name "DataAcquisition" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasObjectSpec"></see>
    /// </summary>
    let hasObjectSpec =
        Namespaced_IRI.parse _namespace_name "hasObjectSpec" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/StaticObject"></see>
    /// </summary>
    let StaticObject =
        Namespaced_IRI.parse _namespace_name "StaticObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataObjectSpec"></see>
    /// </summary>
    let DataObjectSpec =
        Namespaced_IRI.parse _namespace_name "DataObjectSpec" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAssociatedProject"></see>
    /// </summary>
    let hasAssociatedProject =
        Namespaced_IRI.parse _namespace_name "hasAssociatedProject" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDataTheme"></see>
    /// </summary>
    let hasDataTheme =
        Namespaced_IRI.parse _namespace_name "hasDataTheme" |> NamespacedName

    /// <summary>
    /// data stream encoding, e.g. zip, gzip, plain file
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEncoding"></see></summary>
    let hasEncoding =
        Namespaced_IRI.parse _namespace_name "hasEncoding" |> NamespacedName

    /// <summary>
    /// format of the Data Object; will be used to determine the machinery for processing it
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFormat"></see></summary>
    let hasFormat = Namespaced_IRI.parse _namespace_name "hasFormat" |> NamespacedName

    /// <summary>
    /// Data level according to ICOS classification. Does not imply the data are official ICOS data.
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDataLevel"></see></summary>
    let hasDataLevel =
        Namespaced_IRI.parse _namespace_name "hasDataLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataObjectSpecifyingThing"></see>
    /// </summary>
    let DataObjectSpecifyingThing =
        Namespaced_IRI.parse _namespace_name "DataObjectSpecifyingThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataProduction"></see>
    /// </summary>
    let DataProduction =
        Namespaced_IRI.parse _namespace_name "DataProduction" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedBy"></see>
    /// </summary>
    let wasPerformedBy =
        Namespaced_IRI.parse _namespace_name "wasPerformedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataSubmission"></see>
    /// </summary>
    let DataSubmission =
        Namespaced_IRI.parse _namespace_name "DataSubmission" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DataTheme"></see>
    /// </summary>
    let DataTheme = Namespaced_IRI.parse _namespace_name "DataTheme" |> NamespacedName
    /// <summary>
    /// URL link to SVG icon to be used in user interfaces
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasIcon"></see></summary>
    let hasIcon = Namespaced_IRI.parse _namespace_name "hasIcon" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DatasetColumn"></see>
    /// </summary>
    let DatasetColumn =
        Namespaced_IRI.parse _namespace_name "DatasetColumn" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasValueFormat"></see>
    /// </summary>
    let hasValueFormat =
        Namespaced_IRI.parse _namespace_name "hasValueFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasValueType"></see>
    /// </summary>
    let hasValueType =
        Namespaced_IRI.parse _namespace_name "hasValueType" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasColumnTitle"></see>
    /// </summary>
    let hasColumnTitle =
        Namespaced_IRI.parse _namespace_name "hasColumnTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DatasetSpec"></see>
    /// </summary>
    let DatasetSpec =
        Namespaced_IRI.parse _namespace_name "DatasetSpec" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DatasetVariable"></see>
    /// </summary>
    let DatasetVariable =
        Namespaced_IRI.parse _namespace_name "DatasetVariable" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVariableTitle"></see>
    /// </summary>
    let hasVariableTitle =
        Namespaced_IRI.parse _namespace_name "hasVariableTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/DocumentObject"></see>
    /// </summary>
    let DocumentObject =
        Namespaced_IRI.parse _namespace_name "DocumentObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ES"></see>
    /// </summary>
    let ES = Namespaced_IRI.parse _namespace_name "ES" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/EcosystemType"></see>
    /// </summary>
    let EcosystemType =
        Namespaced_IRI.parse _namespace_name "EcosystemType" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/FluxnetStation"></see>
    /// </summary>
    let FluxnetStation =
        Namespaced_IRI.parse _namespace_name "FluxnetStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Funder"></see>
    /// </summary>
    let Funder = Namespaced_IRI.parse _namespace_name "Funder" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Funding"></see>
    /// </summary>
    let Funding = Namespaced_IRI.parse _namespace_name "Funding" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFunder"></see>
    /// </summary>
    let hasFunder = Namespaced_IRI.parse _namespace_name "hasFunder" |> NamespacedName

    /// <summary>
    /// ISO 3166-1 alpha-2 country code
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/countryCode"></see></summary>
    let countryCode =
        Namespaced_IRI.parse _namespace_name "countryCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/IngosStation"></see>
    /// </summary>
    let IngosStation =
        Namespaced_IRI.parse _namespace_name "IngosStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Instrument"></see>
    /// </summary>
    let Instrument = Namespaced_IRI.parse _namespace_name "Instrument" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasInstrumentOwner"></see>
    /// </summary>
    let hasInstrumentOwner =
        Namespaced_IRI.parse _namespace_name "hasInstrumentOwner" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVendor"></see>
    /// </summary>
    let hasVendor = Namespaced_IRI.parse _namespace_name "hasVendor" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasModel"></see>
    /// </summary>
    let hasModel = Namespaced_IRI.parse _namespace_name "hasModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSerialNumber"></see>
    /// </summary>
    let hasSerialNumber =
        Namespaced_IRI.parse _namespace_name "hasSerialNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/LatLonBox"></see>
    /// </summary>
    let LatLonBox = Namespaced_IRI.parse _namespace_name "LatLonBox" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/SpatialCoverage"></see>
    /// </summary>
    let SpatialCoverage =
        Namespaced_IRI.parse _namespace_name "SpatialCoverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEasternBound"></see>
    /// </summary>
    let hasEasternBound =
        Namespaced_IRI.parse _namespace_name "hasEasternBound" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasNorthernBound"></see>
    /// </summary>
    let hasNorthernBound =
        Namespaced_IRI.parse _namespace_name "hasNorthernBound" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSouthernBound"></see>
    /// </summary>
    let hasSouthernBound =
        Namespaced_IRI.parse _namespace_name "hasSouthernBound" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasWesternBound"></see>
    /// </summary>
    let hasWesternBound =
        Namespaced_IRI.parse _namespace_name "hasWesternBound" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Membership"></see>
    /// </summary>
    let Membership = Namespaced_IRI.parse _namespace_name "Membership" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/atOrganization"></see>
    /// </summary>
    let atOrganization =
        Namespaced_IRI.parse _namespace_name "atOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasRole"></see>
    /// </summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/NeonStation"></see>
    /// </summary>
    let NeonStation =
        Namespaced_IRI.parse _namespace_name "NeonStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/OS"></see>
    /// </summary>
    let OS = Namespaced_IRI.parse _namespace_name "OS" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ObjectEncoding"></see>
    /// </summary>
    let ObjectEncoding =
        Namespaced_IRI.parse _namespace_name "ObjectEncoding" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ObjectFormat"></see>
    /// </summary>
    let ObjectFormat =
        Namespaced_IRI.parse _namespace_name "ObjectFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasName"></see>
    /// </summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEmail"></see>
    /// </summary>
    let hasEmail = Namespaced_IRI.parse _namespace_name "hasEmail" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFirstName"></see>
    /// </summary>
    let hasFirstName =
        Namespaced_IRI.parse _namespace_name "hasFirstName" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLastName"></see>
    /// </summary>
    let hasLastName =
        Namespaced_IRI.parse _namespace_name "hasLastName" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Position"></see>
    /// </summary>
    let Position = Namespaced_IRI.parse _namespace_name "Position" |> NamespacedName

    /// <summary>
    /// Decimal degrees in WGS84/GRS80
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLatitude"></see></summary>
    let hasLatitude =
        Namespaced_IRI.parse _namespace_name "hasLatitude" |> NamespacedName

    /// <summary>
    /// Decimal degrees in WGS84/GRS80
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLongitude"></see></summary>
    let hasLongitude =
        Namespaced_IRI.parse _namespace_name "hasLongitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Project"></see>
    /// </summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName

    /// <summary>
    /// The kind of physical quantity, for example volume, length, concentration. Can be basic or derived, standard or non-standard. Implies an associated physical quantity dimension but does not have a fixed unit of measurement.
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/QuantityKind"></see></summary>
    let QuantityKind =
        Namespaced_IRI.parse _namespace_name "QuantityKind" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Role"></see>
    /// </summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/SailDrone"></see>
    /// </summary>
    let SailDrone = Namespaced_IRI.parse _namespace_name "SailDrone" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/SimpleDataObject"></see>
    /// </summary>
    let SimpleDataObject =
        Namespaced_IRI.parse _namespace_name "SimpleDataObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/SpatialDataObject"></see>
    /// </summary>
    let SpatialDataObject =
        Namespaced_IRI.parse _namespace_name "SpatialDataObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasAcquiredBy"></see>
    /// </summary>
    let wasAcquiredBy =
        Namespaced_IRI.parse _namespace_name "wasAcquiredBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/SimpleObjectSpec"></see>
    /// </summary>
    let SimpleObjectSpec =
        Namespaced_IRI.parse _namespace_name "SimpleObjectSpec" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/containsDataset"></see>
    /// </summary>
    let containsDataset =
        Namespaced_IRI.parse _namespace_name "containsDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/TabularDatasetSpec"></see>
    /// </summary>
    let TabularDatasetSpec =
        Namespaced_IRI.parse _namespace_name "TabularDatasetSpec" |> NamespacedName

    /// <summary>
    /// Physical research site
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/Site"></see></summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEcosystemType"></see>
    /// </summary>
    let hasEcosystemType =
        Namespaced_IRI.parse _namespace_name "hasEcosystemType" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSpatialCoverage"></see>
    /// </summary>
    let hasSpatialCoverage =
        Namespaced_IRI.parse _namespace_name "hasSpatialCoverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasProducedBy"></see>
    /// </summary>
    let wasProducedBy =
        Namespaced_IRI.parse _namespace_name "wasProducedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEndTime"></see>
    /// </summary>
    let hasEndTime = Namespaced_IRI.parse _namespace_name "hasEndTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStartTime"></see>
    /// </summary>
    let hasStartTime =
        Namespaced_IRI.parse _namespace_name "hasStartTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasSubmittedBy"></see>
    /// </summary>
    let wasSubmittedBy =
        Namespaced_IRI.parse _namespace_name "wasSubmittedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStationId"></see>
    /// </summary>
    let hasStationId =
        Namespaced_IRI.parse _namespace_name "hasStationId" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/StringVocabulary"></see>
    /// </summary>
    let StringVocabulary =
        Namespaced_IRI.parse _namespace_name "StringVocabulary" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/containsString"></see>
    /// </summary>
    let containsString =
        Namespaced_IRI.parse _namespace_name "containsString" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ValueFormat"></see>
    /// </summary>
    let ValueFormat =
        Namespaced_IRI.parse _namespace_name "ValueFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasColumn"></see>
    /// </summary>
    let hasColumn = Namespaced_IRI.parse _namespace_name "hasColumn" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ThematicCenter"></see>
    /// </summary>
    let ThematicCenter =
        Namespaced_IRI.parse _namespace_name "ThematicCenter" |> NamespacedName

    /// <summary>
    /// Domain-specific meaning of the values
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ValueType"></see></summary>
    let ValueType = Namespaced_IRI.parse _namespace_name "ValueType" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/VariableInfo"></see>
    /// </summary>
    let VariableInfo =
        Namespaced_IRI.parse _namespace_name "VariableInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/WdcggStation"></see>
    /// </summary>
    let WdcggStation =
        Namespaced_IRI.parse _namespace_name "WdcggStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asGeoJSON"></see>
    /// </summary>
    let asGeoJSON = Namespaced_IRI.parse _namespace_name "asGeoJSON" |> NamespacedName

    /// <summary>
    /// Semicolon-separated ASCII, with #-prefixed multi-line header
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiAtcProductTimeSer"></see></summary>
    let asciiAtcProductTimeSer =
        Namespaced_IRI.parse _namespace_name "asciiAtcProductTimeSer" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasGoodFlagValue"></see>
    /// </summary>
    let hasGoodFlagValue =
        Namespaced_IRI.parse _namespace_name "hasGoodFlagValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiAtcTimeSer"></see>
    /// </summary>
    let asciiAtcTimeSer =
        Namespaced_IRI.parse _namespace_name "asciiAtcTimeSer" |> NamespacedName

    /// <summary>
    /// The first two columns are expected to be the beginning and the end of the averaging period in yyyyMMddHHmm format (no DST)
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiEtcHalfHourlyProductTimeSer"></see></summary>
    let asciiEtcHalfHourlyProductTimeSer =
        Namespaced_IRI.parse _namespace_name "asciiEtcHalfHourlyProductTimeSer" |> NamespacedName

    /// <summary>
    /// Local dateTime timestamp without any daylight savings time adjustments, that is, local winter time.
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/etcLocalDateTime"></see></summary>
    let etcLocalDateTime =
        Namespaced_IRI.parse _namespace_name "etcLocalDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiEtcRawTimeSer"></see>
    /// </summary>
    let asciiEtcRawTimeSer =
        Namespaced_IRI.parse _namespace_name "asciiEtcRawTimeSer" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiEtcTimeSer"></see>
    /// </summary>
    let asciiEtcTimeSer =
        Namespaced_IRI.parse _namespace_name "asciiEtcTimeSer" |> NamespacedName

    /// <summary>
    /// Single-line comment, first column is UTC ISO-8601 timestamp, NaN for missing values, comma-separated.
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiOtcProductCsv"></see></summary>
    let asciiOtcProductCsv =
        Namespaced_IRI.parse _namespace_name "asciiOtcProductCsv" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiOtcSocatTimeSer"></see>
    /// </summary>
    let asciiOtcSocatTimeSer =
        Namespaced_IRI.parse _namespace_name "asciiOtcSocatTimeSer" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiWdcggTimeSer"></see>
    /// </summary>
    let asciiWdcggTimeSer =
        Namespaced_IRI.parse _namespace_name "asciiWdcggTimeSer" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/awardNumber"></see>
    /// </summary>
    let awardNumber =
        Namespaced_IRI.parse _namespace_name "awardNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/fundingInfoProp"></see>
    /// </summary>
    let fundingInfoProp =
        Namespaced_IRI.parse _namespace_name "fundingInfoProp" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/awardTitle"></see>
    /// </summary>
    let awardTitle = Namespaced_IRI.parse _namespace_name "awardTitle" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/awardURI"></see>
    /// </summary>
    let awardURI = Namespaced_IRI.parse _namespace_name "awardURI" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/binEtcRawTimeSer"></see>
    /// </summary>
    let binEtcRawTimeSer =
        Namespaced_IRI.parse _namespace_name "binEtcRawTimeSer" |> NamespacedName

    /// <summary>
    /// a character from the basic multilingual plane
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/bmpChar"></see></summary>
    let bmpChar = Namespaced_IRI.parse _namespace_name "bmpChar" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/broaderEcosystem"></see>
    /// </summary>
    let broaderEcosystem =
        Namespaced_IRI.parse _namespace_name "broaderEcosystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/country"></see>
    /// </summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStationSpecificParam"></see>
    /// </summary>
    let hasStationSpecificParam =
        Namespaced_IRI.parse _namespace_name "hasStationSpecificParam" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/csvWithIso8601tsFirstCol"></see>
    /// </summary>
    let csvWithIso8601tsFirstCol =
        Namespaced_IRI.parse _namespace_name "csvWithIso8601tsFirstCol" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/etcDate"></see>
    /// </summary>
    let etcDate = Namespaced_IRI.parse _namespace_name "etcDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/etcRawTimeSerMultiZip"></see>
    /// </summary>
    let etcRawTimeSerMultiZip =
        Namespaced_IRI.parse _namespace_name "etcRawTimeSerMultiZip" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/excel"></see>
    /// </summary>
    let excel = Namespaced_IRI.parse _namespace_name "excel" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/float32"></see>
    /// </summary>
    let float32 = Namespaced_IRI.parse _namespace_name "float32" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/float64"></see>
    /// </summary>
    let float64 = Namespaced_IRI.parse _namespace_name "float64" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/funderIdentifier"></see>
    /// </summary>
    let funderIdentifier =
        Namespaced_IRI.parse _namespace_name "funderIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/funderIdentifierType"></see>
    /// </summary>
    let funderIdentifierType =
        Namespaced_IRI.parse _namespace_name "funderIdentifierType" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/gzipEncoding"></see>
    /// </summary>
    let gzipEncoding =
        Namespaced_IRI.parse _namespace_name "gzipEncoding" |> NamespacedName

    /// <summary>
    /// Contains a JSON array with actual column names
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasActualColumnNames"></see></summary>
    let hasActualColumnNames =
        Namespaced_IRI.parse _namespace_name "hasActualColumnNames" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasActualVariable"></see>
    /// </summary>
    let hasActualVariable =
        Namespaced_IRI.parse _namespace_name "hasActualVariable" |> NamespacedName

    /// <summary>
    /// parent property for ancillary value properties whose values are plain literals (not from vocabularies)
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryDataValue"></see></summary>
    let hasAncillaryDataValue =
        Namespaced_IRI.parse _namespace_name "hasAncillaryDataValue" |> NamespacedName

    /// <summary>
    /// ancillary entry associated with a station
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryEntry"></see></summary>
    let hasAncillaryEntry =
        Namespaced_IRI.parse _namespace_name "hasAncillaryEntry" |> NamespacedName

    /// <summary>
    /// parent property for ancillary value properties whose values come from controlled vocabularies
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryObjectValue"></see></summary>
    let hasAncillaryObjectValue =
        Namespaced_IRI.parse _namespace_name "hasAncillaryObjectValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAssociatedPublication"></see>
    /// </summary>
    let hasAssociatedPublication =
        Namespaced_IRI.parse _namespace_name "hasAssociatedPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAtcId"></see>
    /// </summary>
    let hasAtcId = Namespaced_IRI.parse _namespace_name "hasAtcId" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasTcId"></see>
    /// </summary>
    let hasTcId = Namespaced_IRI.parse _namespace_name "hasTcId" |> NamespacedName

    /// <summary>
    /// to be used for determining the order of names in citation strings
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAttributionWeight"></see></summary>
    let hasAttributionWeight =
        Namespaced_IRI.parse _namespace_name "hasAttributionWeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasExtraRoleInfo"></see>
    /// </summary>
    let hasExtraRoleInfo =
        Namespaced_IRI.parse _namespace_name "hasExtraRoleInfo" |> NamespacedName

    /// <summary>
    /// a synthetic property; the RDF triples with it as a predicate are to be created by business-logic-based inference, not inserted into the triple store explicitly
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasCitationString"></see></summary>
    let hasCitationString =
        Namespaced_IRI.parse _namespace_name "hasCitationString" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasClimateZone"></see>
    /// </summary>
    let hasClimateZone =
        Namespaced_IRI.parse _namespace_name "hasClimateZone" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVariable"></see>
    /// </summary>
    let hasVariable =
        Namespaced_IRI.parse _namespace_name "hasVariable" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDepiction"></see>
    /// </summary>
    let hasDepiction =
        Namespaced_IRI.parse _namespace_name "hasDepiction" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDocumentationObject"></see>
    /// </summary>
    let hasDocumentationObject =
        Namespaced_IRI.parse _namespace_name "hasDocumentationObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDocumentationUri"></see>
    /// </summary>
    let hasDocumentationUri =
        Namespaced_IRI.parse _namespace_name "hasDocumentationUri" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDoi"></see>
    /// </summary>
    let hasDoi = Namespaced_IRI.parse _namespace_name "hasDoi" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/latlongs"></see>
    /// </summary>
    let latlongs = Namespaced_IRI.parse _namespace_name "latlongs" |> NamespacedName

    /// <summary>
    /// Elevation above sea level in meters
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasElevation"></see></summary>
    let hasElevation =
        Namespaced_IRI.parse _namespace_name "hasElevation" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEndDate"></see>
    /// </summary>
    let hasEndDate = Namespaced_IRI.parse _namespace_name "hasEndDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEtcId"></see>
    /// </summary>
    let hasEtcId = Namespaced_IRI.parse _namespace_name "hasEtcId" |> NamespacedName

    /// <summary>
    /// parent property for concrete format-specific metadata properties
    /// used for WDCGG data, may be retired in the future
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFormatSpecificMetadata"></see></summary>
    let hasFormatSpecificMetadata =
        Namespaced_IRI.parse _namespace_name "hasFormatSpecificMetadata" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFunding"></see>
    /// </summary>
    let hasFunding = Namespaced_IRI.parse _namespace_name "hasFunding" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasHideFromSearchPolicy"></see>
    /// </summary>
    let hasHideFromSearchPolicy =
        Namespaced_IRI.parse _namespace_name "hasHideFromSearchPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasPolicy"></see>
    /// </summary>
    let hasPolicy = Namespaced_IRI.parse _namespace_name "hasPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasInstrumentComponent"></see>
    /// </summary>
    let hasInstrumentComponent =
        Namespaced_IRI.parse _namespace_name "hasInstrumentComponent" |> NamespacedName

    /// <summary>
    /// A "virtual" property, created for keyword search in SPARQL. A multi-value counterpart of cpmeta:hasKeywords, which contains a string with comma-separated list of keywords.
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasKeyword"></see></summary>
    let hasKeyword = Namespaced_IRI.parse _namespace_name "hasKeyword" |> NamespacedName

    /// <summary>
    /// String representing a comma-separated list of keywords
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasKeywords"></see></summary>
    let hasKeywords =
        Namespaced_IRI.parse _namespace_name "hasKeywords" |> NamespacedName

    /// <summary>
    /// the date when the station was approved by ICOS and got labelled as an ICOS station
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLabelingDate"></see></summary>
    let hasLabelingDate =
        Namespaced_IRI.parse _namespace_name "hasLabelingDate" |> NamespacedName

    /// <summary>
    /// URL link to an icon that can be used by web apps to show e.g. locations of stations
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMarkerIcon"></see></summary>
    let hasMarkerIcon =
        Namespaced_IRI.parse _namespace_name "hasMarkerIcon" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMaxValue"></see>
    /// </summary>
    let hasMaxValue =
        Namespaced_IRI.parse _namespace_name "hasMaxValue" |> NamespacedName

    /// <summary>
    /// measured in mm
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualPrecip"></see></summary>
    let hasMeanAnnualPrecip =
        Namespaced_IRI.parse _namespace_name "hasMeanAnnualPrecip" |> NamespacedName

    /// <summary>
    /// measured in W m-2
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualRadiation"></see></summary>
    let hasMeanAnnualRadiation =
        Namespaced_IRI.parse _namespace_name "hasMeanAnnualRadiation" |> NamespacedName

    /// <summary>
    /// measured in °C
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualTemp"></see></summary>
    let hasMeanAnnualTemp =
        Namespaced_IRI.parse _namespace_name "hasMeanAnnualTemp" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMembership"></see>
    /// </summary>
    let hasMembership =
        Namespaced_IRI.parse _namespace_name "hasMembership" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMinValue"></see>
    /// </summary>
    let hasMinValue =
        Namespaced_IRI.parse _namespace_name "hasMinValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasNumberOfRows"></see>
    /// </summary>
    let hasNumberOfRows =
        Namespaced_IRI.parse _namespace_name "hasNumberOfRows" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasOperationalPeriod"></see>
    /// </summary>
    let hasOperationalPeriod =
        Namespaced_IRI.parse _namespace_name "hasOperationalPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasOrcidId"></see>
    /// </summary>
    let hasOrcidId = Namespaced_IRI.parse _namespace_name "hasOrcidId" |> NamespacedName

    /// <summary>
    /// umbrella property for organizing id-related properties
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStringId"></see></summary>
    let hasStringId =
        Namespaced_IRI.parse _namespace_name "hasStringId" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasOtcId"></see>
    /// </summary>
    let hasOtcId = Namespaced_IRI.parse _namespace_name "hasOtcId" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasQuantityKind"></see>
    /// </summary>
    let hasQuantityKind =
        Namespaced_IRI.parse _namespace_name "hasQuantityKind" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasResponsibleOrganization"></see>
    /// </summary>
    let hasResponsibleOrganization =
        Namespaced_IRI.parse _namespace_name "hasResponsibleOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSamplingHeight"></see>
    /// </summary>
    let hasSamplingHeight =
        Namespaced_IRI.parse _namespace_name "hasSamplingHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSamplingPoint"></see>
    /// </summary>
    let hasSamplingPoint =
        Namespaced_IRI.parse _namespace_name "hasSamplingPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSha256sum"></see>
    /// </summary>
    let hasSha256sum =
        Namespaced_IRI.parse _namespace_name "hasSha256sum" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSizeInBytes"></see>
    /// </summary>
    let hasSizeInBytes =
        Namespaced_IRI.parse _namespace_name "hasSizeInBytes" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSkipPidMintingPolicy"></see>
    /// </summary>
    let hasSkipPidMintingPolicy =
        Namespaced_IRI.parse _namespace_name "hasSkipPidMintingPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSkipStoragePolicy"></see>
    /// </summary>
    let hasSkipStoragePolicy =
        Namespaced_IRI.parse _namespace_name "hasSkipStoragePolicy" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStartDate"></see>
    /// </summary>
    let hasStartDate =
        Namespaced_IRI.parse _namespace_name "hasStartDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStationClass"></see>
    /// </summary>
    let hasStationClass =
        Namespaced_IRI.parse _namespace_name "hasStationClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasTemporalResolution"></see>
    /// </summary>
    let hasTemporalResolution =
        Namespaced_IRI.parse _namespace_name "hasTemporalResolution" |> NamespacedName

    /// <summary>
    /// offset of local timezone from UTC
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasTimeZoneOffset"></see></summary>
    let hasTimeZoneOffset =
        Namespaced_IRI.parse _namespace_name "hasTimeZoneOffset" |> NamespacedName

    /// <summary>
    /// unit of measurement
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasUnit"></see></summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName

    /// <summary>
    /// A "virtual" property only used to define a variable in SPARQL, to support variable-name search. Is a multi-valued counterpart of cpmeta:hasActualColumnNames (for SimpleDataObjects), which contains a JSON array. Also, used to indicate variable name that a sensor is measuring (via Deployment).
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVariableName"></see></summary>
    let hasVariableName =
        Namespaced_IRI.parse _namespace_name "hasVariableName" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/hasWigosId"></see>
    /// </summary>
    let hasWigosId = Namespaced_IRI.parse _namespace_name "hasWigosId" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/icosLicence"></see>
    /// </summary>
    let icosLicence =
        Namespaced_IRI.parse _namespace_name "icosLicence" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_BSV"></see>
    /// </summary>
    let igbp_BSV = Namespaced_IRI.parse _namespace_name "igbp_BSV" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_CRO"></see>
    /// </summary>
    let igbp_CRO = Namespaced_IRI.parse _namespace_name "igbp_CRO" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_CSH"></see>
    /// </summary>
    let igbp_CSH = Namespaced_IRI.parse _namespace_name "igbp_CSH" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_CVM"></see>
    /// </summary>
    let igbp_CVM = Namespaced_IRI.parse _namespace_name "igbp_CVM" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_DBF"></see>
    /// </summary>
    let igbp_DBF = Namespaced_IRI.parse _namespace_name "igbp_DBF" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_DNF"></see>
    /// </summary>
    let igbp_DNF = Namespaced_IRI.parse _namespace_name "igbp_DNF" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_EBF"></see>
    /// </summary>
    let igbp_EBF = Namespaced_IRI.parse _namespace_name "igbp_EBF" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_ENF"></see>
    /// </summary>
    let igbp_ENF = Namespaced_IRI.parse _namespace_name "igbp_ENF" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_GRA"></see>
    /// </summary>
    let igbp_GRA = Namespaced_IRI.parse _namespace_name "igbp_GRA" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_MF"></see>
    /// </summary>
    let igbp_MF = Namespaced_IRI.parse _namespace_name "igbp_MF" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_OSH"></see>
    /// </summary>
    let igbp_OSH = Namespaced_IRI.parse _namespace_name "igbp_OSH" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_SAV"></see>
    /// </summary>
    let igbp_SAV = Namespaced_IRI.parse _namespace_name "igbp_SAV" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_SNO"></see>
    /// </summary>
    let igbp_SNO = Namespaced_IRI.parse _namespace_name "igbp_SNO" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_URB"></see>
    /// </summary>
    let igbp_URB = Namespaced_IRI.parse _namespace_name "igbp_URB" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_WAT"></see>
    /// </summary>
    let igbp_WAT = Namespaced_IRI.parse _namespace_name "igbp_WAT" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_WET"></see>
    /// </summary>
    let igbp_WET = Namespaced_IRI.parse _namespace_name "igbp_WET" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_WSA"></see>
    /// </summary>
    let igbp_WSA = Namespaced_IRI.parse _namespace_name "igbp_WSA" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/image"></see>
    /// </summary>
    let image = Namespaced_IRI.parse _namespace_name "image" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/impliesDefaultLicence"></see>
    /// </summary>
    let impliesDefaultLicence =
        Namespaced_IRI.parse _namespace_name "impliesDefaultLicence" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/ingosRar"></see>
    /// </summary>
    let ingosRar = Namespaced_IRI.parse _namespace_name "ingosRar" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/int32"></see>
    /// </summary>
    let int32 = Namespaced_IRI.parse _namespace_name "int32" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isOptionalColumn"></see>
    /// </summary>
    let isOptionalColumn =
        Namespaced_IRI.parse _namespace_name "isOptionalColumn" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isOptionalVariable"></see>
    /// </summary>
    let isOptionalVariable =
        Namespaced_IRI.parse _namespace_name "isOptionalVariable" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isQualityFlagFor"></see>
    /// </summary>
    let isQualityFlagFor =
        Namespaced_IRI.parse _namespace_name "isQualityFlagFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isRegexColumn"></see>
    /// </summary>
    let isRegexColumn =
        Namespaced_IRI.parse _namespace_name "isRegexColumn" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isRegexVariable"></see>
    /// </summary>
    let isRegexVariable =
        Namespaced_IRI.parse _namespace_name "isRegexVariable" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/iso8601date"></see>
    /// </summary>
    let iso8601date =
        Namespaced_IRI.parse _namespace_name "iso8601date" |> NamespacedName

    /// <summary>
    /// Internally represented as int64 milliseconds since Unix epoch.
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/iso8601dateTime"></see></summary>
    let iso8601dateTime =
        Namespaced_IRI.parse _namespace_name "iso8601dateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/iso8601timeOfDay"></see>
    /// </summary>
    let iso8601timeOfDay =
        Namespaced_IRI.parse _namespace_name "iso8601timeOfDay" |> NamespacedName

    /// <summary>
    /// May use space instead of 'T' for separator
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/isoLikeLocalDateTime"></see></summary>
    let isoLikeLocalDateTime =
        Namespaced_IRI.parse _namespace_name "isoLikeLocalDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Af"></see>
    /// </summary>
    let koppen_Af = Namespaced_IRI.parse _namespace_name "koppen_Af" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Am"></see>
    /// </summary>
    let koppen_Am = Namespaced_IRI.parse _namespace_name "koppen_Am" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Aw_As"></see>
    /// </summary>
    let koppen_Aw_As =
        Namespaced_IRI.parse _namespace_name "koppen_Aw_As" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BSh"></see>
    /// </summary>
    let koppen_BSh = Namespaced_IRI.parse _namespace_name "koppen_BSh" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BSk"></see>
    /// </summary>
    let koppen_BSk = Namespaced_IRI.parse _namespace_name "koppen_BSk" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BWh"></see>
    /// </summary>
    let koppen_BWh = Namespaced_IRI.parse _namespace_name "koppen_BWh" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BWk"></see>
    /// </summary>
    let koppen_BWk = Namespaced_IRI.parse _namespace_name "koppen_BWk" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cfa"></see>
    /// </summary>
    let koppen_Cfa = Namespaced_IRI.parse _namespace_name "koppen_Cfa" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cfb"></see>
    /// </summary>
    let koppen_Cfb = Namespaced_IRI.parse _namespace_name "koppen_Cfb" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cfc"></see>
    /// </summary>
    let koppen_Cfc = Namespaced_IRI.parse _namespace_name "koppen_Cfc" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Csa"></see>
    /// </summary>
    let koppen_Csa = Namespaced_IRI.parse _namespace_name "koppen_Csa" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Csb"></see>
    /// </summary>
    let koppen_Csb = Namespaced_IRI.parse _namespace_name "koppen_Csb" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Csc"></see>
    /// </summary>
    let koppen_Csc = Namespaced_IRI.parse _namespace_name "koppen_Csc" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cwa"></see>
    /// </summary>
    let koppen_Cwa = Namespaced_IRI.parse _namespace_name "koppen_Cwa" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cwb"></see>
    /// </summary>
    let koppen_Cwb = Namespaced_IRI.parse _namespace_name "koppen_Cwb" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cwc"></see>
    /// </summary>
    let koppen_Cwc = Namespaced_IRI.parse _namespace_name "koppen_Cwc" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfa"></see>
    /// </summary>
    let koppen_Dfa = Namespaced_IRI.parse _namespace_name "koppen_Dfa" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfb"></see>
    /// </summary>
    let koppen_Dfb = Namespaced_IRI.parse _namespace_name "koppen_Dfb" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfc"></see>
    /// </summary>
    let koppen_Dfc = Namespaced_IRI.parse _namespace_name "koppen_Dfc" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfd"></see>
    /// </summary>
    let koppen_Dfd = Namespaced_IRI.parse _namespace_name "koppen_Dfd" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsa"></see>
    /// </summary>
    let koppen_Dsa = Namespaced_IRI.parse _namespace_name "koppen_Dsa" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsb"></see>
    /// </summary>
    let koppen_Dsb = Namespaced_IRI.parse _namespace_name "koppen_Dsb" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsc"></see>
    /// </summary>
    let koppen_Dsc = Namespaced_IRI.parse _namespace_name "koppen_Dsc" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsd"></see>
    /// </summary>
    let koppen_Dsd = Namespaced_IRI.parse _namespace_name "koppen_Dsd" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwa"></see>
    /// </summary>
    let koppen_Dwa = Namespaced_IRI.parse _namespace_name "koppen_Dwa" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwb"></see>
    /// </summary>
    let koppen_Dwb = Namespaced_IRI.parse _namespace_name "koppen_Dwb" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwc"></see>
    /// </summary>
    let koppen_Dwc = Namespaced_IRI.parse _namespace_name "koppen_Dwc" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwd"></see>
    /// </summary>
    let koppen_Dwd = Namespaced_IRI.parse _namespace_name "koppen_Dwd" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_EF"></see>
    /// </summary>
    let koppen_EF = Namespaced_IRI.parse _namespace_name "koppen_EF" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_ET"></see>
    /// </summary>
    let koppen_ET = Namespaced_IRI.parse _namespace_name "koppen_ET" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/locatedAt"></see>
    /// </summary>
    let locatedAt = Namespaced_IRI.parse _namespace_name "locatedAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/multiImageZip"></see>
    /// </summary>
    let multiImageZip =
        Namespaced_IRI.parse _namespace_name "multiImageZip" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/netcdf"></see>
    /// </summary>
    let netcdf = Namespaced_IRI.parse _namespace_name "netcdf" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/netcdfTimeSeries"></see>
    /// </summary>
    let netcdfTimeSeries =
        Namespaced_IRI.parse _namespace_name "netcdfTimeSeries" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/operatesOn"></see>
    /// </summary>
    let operatesOn = Namespaced_IRI.parse _namespace_name "operatesOn" |> NamespacedName
    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/otcRawData"></see>
    /// </summary>
    let otcRawData = Namespaced_IRI.parse _namespace_name "otcRawData" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/plainFileEncoding"></see>
    /// </summary>
    let plainFileEncoding =
        Namespaced_IRI.parse _namespace_name "plainFileEncoding" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/string"></see>
    /// </summary>
    let string = Namespaced_IRI.parse _namespace_name "string" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasHostedBy"></see>
    /// </summary>
    let wasHostedBy =
        Namespaced_IRI.parse _namespace_name "wasHostedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasParticipatedInBy"></see>
    /// </summary>
    let wasParticipatedInBy =
        Namespaced_IRI.parse _namespace_name "wasParticipatedInBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedAt"></see>
    /// </summary>
    let wasPerformedAt =
        Namespaced_IRI.parse _namespace_name "wasPerformedAt" |> NamespacedName

    /// <summary>
    /// instrument used to perform data acquisition
    /// <see href="http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedWith"></see></summary>
    let wasPerformedWith =
        Namespaced_IRI.parse _namespace_name "wasPerformedWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/zipArchive"></see>
    /// </summary>
    let zipArchive = Namespaced_IRI.parse _namespace_name "zipArchive" |> NamespacedName

    /// <summary>
    ///   <see href="http://meta.icos-cp.eu/ontologies/cpmeta/zipEncoding"></see>
    /// </summary>
    let zipEncoding =
        Namespaced_IRI.parse _namespace_name "zipEncoding" |> NamespacedName
