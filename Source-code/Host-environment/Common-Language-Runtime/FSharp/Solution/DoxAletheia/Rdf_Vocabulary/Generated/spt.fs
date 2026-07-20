namespace http.spitfire_project.eu.ontology.ns.slash

open DoxAletheia

module spt =
    let _namespace_name = "http://spitfire-project.eu/ontology/ns/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/AccessLayer"></see>
    /// </summary>
    let AccessLayer = _prefix "AccessLayer"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/ModelLayer"></see>
    /// </summary>
    let ModelLayer = _prefix "ModelLayer"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Acoustic"></see>
    /// </summary>
    let Acoustic = _prefix "Acoustic"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Energy"></see>
    /// </summary>
    let Energy = _prefix "Energy"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Activity"></see>
    /// </summary>
    let Activity = _prefix "Activity"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/ActuatedProperty"></see>
    /// </summary>
    let ActuatedProperty = _prefix "ActuatedProperty"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Actuator"></see>
    /// </summary>
    let Actuator = _prefix "Actuator"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Transducer"></see>
    /// </summary>
    let Transducer = _prefix "Transducer"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Agent"></see>
    /// </summary>
    let Agent = _prefix "Agent"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Chemical"></see>
    /// </summary>
    let Chemical = _prefix "Chemical"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/CoreLayer"></see>
    /// </summary>
    let CoreLayer = _prefix "CoreLayer"
    /// <summary>
    /// Link Association.
    /// <see href="http://spitfire-project.eu/ontology/ns/DataLink"></see></summary>
    let DataLink = _prefix "DataLink"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/DeviceRole"></see>
    /// </summary>
    let DeviceRole = _prefix "DeviceRole"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/DistributionLayer"></see>
    /// </summary>
    let DistributionLayer = _prefix "DistributionLayer"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Electrical"></see>
    /// </summary>
    let Electrical = _prefix "Electrical"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Electromagnetic"></see>
    /// </summary>
    let Electromagnetic = _prefix "Electromagnetic"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Magnetic"></see>
    /// </summary>
    let Magnetic = _prefix "Magnetic"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/EnergyLabel"></see>
    /// </summary>
    let EnergyLabel = _prefix "EnergyLabel"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/EnergySource"></see>
    /// </summary>
    let EnergySource = _prefix "EnergySource"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/FlatModel"></see>
    /// </summary>
    let FlatModel = _prefix "FlatModel"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/NetworkTopology"></see>
    /// </summary>
    let NetworkTopology = _prefix "NetworkTopology"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Green"></see>
    /// </summary>
    let Green = _prefix "Green"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/HierarchicalModel"></see>
    /// </summary>
    let HierarchicalModel = _prefix "HierarchicalModel"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Light"></see>
    /// </summary>
    let Light = _prefix "Light"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/LinkActivity"></see>
    /// </summary>
    let LinkActivity = _prefix "LinkActivity"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/LinkProperty"></see>
    /// </summary>
    let LinkProperty = _prefix "LinkProperty"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/LinkQuality"></see>
    /// </summary>
    let LinkQuality = _prefix "LinkQuality"
    /// <summary>
    /// Link Review.
    /// <see href="http://spitfire-project.eu/ontology/ns/LinkReview"></see></summary>
    let LinkReview = _prefix "LinkReview"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Mechanical"></see>
    /// </summary>
    let Mechanical = _prefix "Mechanical"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/MeshModel"></see>
    /// </summary>
    let MeshModel = _prefix "MeshModel"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Mood"></see>
    /// </summary>
    let Mood = _prefix "Mood"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Motion"></see>
    /// </summary>
    let Motion = _prefix "Motion"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/NetworkLink"></see>
    /// </summary>
    let NetworkLink = _prefix "NetworkLink"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/NetworkProperty"></see>
    /// </summary>
    let NetworkProperty = _prefix "NetworkProperty"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/NetworkQuality"></see>
    /// </summary>
    let NetworkQuality = _prefix "NetworkQuality"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/NotGreen"></see>
    /// </summary>
    let NotGreen = _prefix "NotGreen"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/NotRenewable"></see>
    /// </summary>
    let NotRenewable = _prefix "NotRenewable"
    /// <summary>
    /// Observation Value.
    /// <see href="http://spitfire-project.eu/ontology/ns/OV"></see></summary>
    let OV = _prefix "OV"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Place"></see>
    /// </summary>
    let Place = _prefix "Place"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/PlatformTemporalProperty"></see>
    /// </summary>
    let PlatformTemporalProperty = _prefix "PlatformTemporalProperty"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/TemporalProperty"></see>
    /// </summary>
    let TemporalProperty = _prefix "TemporalProperty"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Power"></see>
    /// </summary>
    let Power = _prefix "Power"
    /// <summary>
    /// Observed property (Quantity).
    /// <see href="http://spitfire-project.eu/ontology/ns/Quantity"></see></summary>
    let Quantity = _prefix "Quantity"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Renewable"></see>
    /// </summary>
    let Renewable = _prefix "Renewable"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/SensorNetwork"></see>
    /// </summary>
    let SensorNetwork = _prefix "SensorNetwork"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/SensorProjectTopic"></see>
    /// </summary>
    let SensorProjectTopic = _prefix "SensorProjectTopic"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/SensorRole"></see>
    /// </summary>
    let SensorRole = _prefix "SensorRole"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/SensorTemporalProperty"></see>
    /// </summary>
    let SensorTemporalProperty = _prefix "SensorTemporalProperty"
    /// <summary>
    /// Versions of a same observed Property (Quantity) which vary across time and space, as captured by the sensor's observed values.
    /// <see href="http://spitfire-project.eu/ontology/ns/TSMap"></see></summary>
    let TSMap = _prefix "TSMap"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Thermal"></see>
    /// </summary>
    let Thermal = _prefix "Thermal"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Unit"></see>
    /// </summary>
    let Unit = _prefix "Unit"
    /// <summary>
    /// Relationship among a LinkActivity and the end datetime of the time range which it refers to.
    /// <see href="http://spitfire-project.eu/ontology/ns/activityEnd"></see></summary>
    let activityEnd = _prefix "activityEnd"
    /// <summary>
    /// Relationship among an Activity and the start datetime of the time range which it refers to.
    /// <see href="http://spitfire-project.eu/ontology/ns/activityStart"></see></summary>
    let activityStart = _prefix "activityStart"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/actuate"></see>
    /// </summary>
    let actuate = _prefix "actuate"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/actuatedBy"></see>
    /// </summary>
    let actuatedBy = _prefix "actuatedBy"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/actuatedProperty"></see>
    /// </summary>
    let actuatedProperty = _prefix "actuatedProperty"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/actuatedPropertyOf"></see>
    /// </summary>
    let actuatedPropertyOf = _prefix "actuatedPropertyOf"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/avgValue"></see>
    /// </summary>
    let avgValue = _prefix "avgValue"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/belongsToLayer"></see>
    /// </summary>
    let belongsToLayer = _prefix "belongsToLayer"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/belongsToNetwork"></see>
    /// </summary>
    let belongsToNetwork = _prefix "belongsToNetwork"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/bytes"></see>
    /// </summary>
    let bytes = _prefix "bytes"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/confidence"></see>
    /// </summary>
    let confidence = _prefix "confidence"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/containedIn"></see>
    /// </summary>
    let containedIn = _prefix "containedIn"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/describesNetwork"></see>
    /// </summary>
    let describesNetwork = _prefix "describesNetwork"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/endpoint"></see>
    /// </summary>
    let endpoint = _prefix "endpoint"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/energyConsumed"></see>
    /// </summary>
    let energyConsumed = _prefix "energyConsumed"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/energyLabel"></see>
    /// </summary>
    let energyLabel = _prefix "energyLabel"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/energyOutcomes"></see>
    /// </summary>
    let energyOutcomes = _prefix "energyOutcomes"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/energyRate"></see>
    /// </summary>
    let energyRate = _prefix "energyRate"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/energySource"></see>
    /// </summary>
    let energySource = _prefix "energySource"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/energyUsedIn"></see>
    /// </summary>
    let energyUsedIn = _prefix "energyUsedIn"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/feed"></see>
    /// </summary>
    let feed = _prefix "feed"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/forSTatus"></see>
    /// </summary>
    let forSTatus = _prefix "forSTatus"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/context-types#Status"></see>
    /// </summary>
    let ``context-types#Status`` = _prefix "context-types#Status"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/mood"></see>
    /// </summary>
    let mood = _prefix "mood"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/from"></see>
    /// </summary>
    let from = _prefix "from"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/to"></see>
    /// </summary>
    let to_ = _prefix "to"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/inputEnergy"></see>
    /// </summary>
    let inputEnergy = _prefix "inputEnergy"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/outputEnergy"></see>
    /// </summary>
    let outputEnergy = _prefix "outputEnergy"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/ipDevice"></see>
    /// </summary>
    let ipDevice = _prefix "ipDevice"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/ipGate"></see>
    /// </summary>
    let ipGate = _prefix "ipGate"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/layer"></see>
    /// </summary>
    let layer = _prefix "layer"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/isLayerOf"></see>
    /// </summary>
    let isLayerOf = _prefix "isLayerOf"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/layerOf"></see>
    /// </summary>
    let layerOf = _prefix "layerOf"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/hasLayer"></see>
    /// </summary>
    let hasLayer = _prefix "hasLayer"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/linkActivity"></see>
    /// </summary>
    let linkActivity = _prefix "linkActivity"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/linkActivityOf"></see>
    /// </summary>
    let linkActivityOf = _prefix "linkActivityOf"
    /// <summary>
    /// Relationship among a LinkActivity and the amount of packets received in the time range specified by the predicates :startDateTime and :endDateTime
    /// <see href="http://spitfire-project.eu/ontology/ns/linkActivityValue"></see></summary>
    let linkActivityValue = _prefix "linkActivityValue"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/linkQuality"></see>
    /// </summary>
    let linkQuality = _prefix "linkQuality"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/isQualityOf"></see>
    /// </summary>
    let isQualityOf = _prefix "isQualityOf"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/linkQualityOf"></see>
    /// </summary>
    let linkQualityOf = _prefix "linkQualityOf"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/linkQualityValue"></see>
    /// </summary>
    let linkQualityValue = _prefix "linkQualityValue"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/maxValue"></see>
    /// </summary>
    let maxValue = _prefix "maxValue"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/message"></see>
    /// </summary>
    let message = _prefix "message"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/minValue"></see>
    /// </summary>
    let minValue = _prefix "minValue"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/forStatus"></see>
    /// </summary>
    let forStatus = _prefix "forStatus"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/nearby"></see>
    /// </summary>
    let nearby = _prefix "nearby"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/netLink"></see>
    /// </summary>
    let netLink = _prefix "netLink"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/isLinkOf"></see>
    /// </summary>
    let isLinkOf = _prefix "isLinkOf"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/netLinkOf"></see>
    /// </summary>
    let netLinkOf = _prefix "netLinkOf"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/hasLink"></see>
    /// </summary>
    let hasLink = _prefix "hasLink"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/netRole"></see>
    /// </summary>
    let netRole = _prefix "netRole"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/obs"></see>
    /// </summary>
    let obs = _prefix "obs"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/obsBy"></see>
    /// </summary>
    let obsBy = _prefix "obsBy"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/out"></see>
    /// </summary>
    let out = _prefix "out"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/outOf"></see>
    /// </summary>
    let outOf = _prefix "outOf"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/over"></see>
    /// </summary>
    let over = _prefix "over"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/ownedBy"></see>
    /// </summary>
    let ownedBy = _prefix "ownedBy"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/owns"></see>
    /// </summary>
    let owns = _prefix "owns"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/priorityLevel"></see>
    /// </summary>
    let priorityLevel = _prefix "priorityLevel"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/projectTopic"></see>
    /// </summary>
    let projectTopic = _prefix "projectTopic"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/projectTopicOf"></see>
    /// </summary>
    let projectTopicOf = _prefix "projectTopicOf"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sameAsLink"></see>
    /// </summary>
    let sameAsLink = _prefix "sameAsLink"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sameContext"></see>
    /// </summary>
    let sameContext = _prefix "sameContext"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sameDomain"></see>
    /// </summary>
    let sameDomain = _prefix "sameDomain"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sameLocation"></see>
    /// </summary>
    let sameLocation = _prefix "sameLocation"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sameTime"></see>
    /// </summary>
    let sameTime = _prefix "sameTime"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/savedEnergy"></see>
    /// </summary>
    let savedEnergy = _prefix "savedEnergy"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/SavedEnergy"></see>
    /// </summary>
    let SavedEnergy = _prefix "SavedEnergy"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/savedEnergyOf"></see>
    /// </summary>
    let savedEnergyOf = _prefix "savedEnergyOf"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/seeAlsoLink"></see>
    /// </summary>
    let seeAlsoLink = _prefix "seeAlsoLink"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sensed"></see>
    /// </summary>
    let sensed = _prefix "sensed"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sensedBy"></see>
    /// </summary>
    let sensedBy = _prefix "sensedBy"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/status"></see>
    /// </summary>
    let status = _prefix "status"
    /// <summary>
    /// Datetime after which a given entity and all the triples referred to it, are not valid anymore.
    /// <see href="http://spitfire-project.eu/ontology/ns/tEnd"></see></summary>
    let tEnd = _prefix "tEnd"
    /// <summary>
    /// Datetime at which a given entity and all the triples referred to it, start to be valid.
    /// <see href="http://spitfire-project.eu/ontology/ns/tStart"></see></summary>
    let tStart = _prefix "tStart"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/temporal"></see>
    /// </summary>
    let temporal = _prefix "temporal"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/temporalOf"></see>
    /// </summary>
    let temporalOf = _prefix "temporalOf"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/title"></see>
    /// </summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/totAreas"></see>
    /// </summary>
    let totAreas = _prefix "totAreas"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/tsMap"></see>
    /// </summary>
    let tsMap = _prefix "tsMap"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/tsMapOf"></see>
    /// </summary>
    let tsMapOf = _prefix "tsMapOf"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/under"></see>
    /// </summary>
    let under = _prefix "under"
    /// <summary>
    /// Unit of Measurement in use on a specific device or sensor or sensing device
    /// <see href="http://spitfire-project.eu/ontology/ns/uom"></see></summary>
    let uom = _prefix "uom"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/valueRange"></see>
    /// </summary>
    let valueRange = _prefix "valueRange"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/wears"></see>
    /// </summary>
    let wears = _prefix "wears"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/wornBy"></see>
    /// </summary>
    let wornBy = _prefix "wornBy"
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/weatherForecast"></see>
    /// </summary>
    let weatherForecast = _prefix "weatherForecast"
