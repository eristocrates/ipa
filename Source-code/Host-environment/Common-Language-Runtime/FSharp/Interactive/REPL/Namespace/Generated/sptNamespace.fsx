#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module spt =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://spitfire-project.eu/ontology/ns/" "spt"

    let AccessLayer = _prefixId.prefix "AccessLayer"
    let Acoustic = _prefixId.prefix "Acoustic"
    let Activity = _prefixId.prefix "Activity"
    let ActuatedProperty = _prefixId.prefix "ActuatedProperty"
    let Actuator = _prefixId.prefix "Actuator"
    let Agent = _prefixId.prefix "Agent"
    let Chemical = _prefixId.prefix "Chemical"
    let CoreLayer = _prefixId.prefix "CoreLayer"
    /// <summary>
    ///   <para>rdfs:comment : Link Association.^^xsd:string</para>
    ///   <a href="http://spitfire-project.eu/ontology/ns/DataLink">spt:DataLink</a>
    /// </summary>
    let DataLink = _prefixId.prefix "DataLink"
    let DeviceRole = _prefixId.prefix "DeviceRole"
    let DistributionLayer = _prefixId.prefix "DistributionLayer"
    let Electrical = _prefixId.prefix "Electrical"
    let Electromagnetic = _prefixId.prefix "Electromagnetic"
    let Energy = _prefixId.prefix "Energy"
    let EnergyLabel = _prefixId.prefix "EnergyLabel"
    let EnergySource = _prefixId.prefix "EnergySource"
    let FlatModel = _prefixId.prefix "FlatModel"
    let Green = _prefixId.prefix "Green"
    let HierarchicalModel = _prefixId.prefix "HierarchicalModel"
    let Light = _prefixId.prefix "Light"
    let LinkActivity = _prefixId.prefix "LinkActivity"
    let LinkProperty = _prefixId.prefix "LinkProperty"
    let LinkQuality = _prefixId.prefix "LinkQuality"
    /// <summary>
    ///   <para>rdfs:comment : Link Review.^^xsd:string</para>
    ///   <a href="http://spitfire-project.eu/ontology/ns/LinkReview">spt:LinkReview</a>
    /// </summary>
    let LinkReview = _prefixId.prefix "LinkReview"
    let Magnetic = _prefixId.prefix "Magnetic"
    let Mechanical = _prefixId.prefix "Mechanical"
    let MeshModel = _prefixId.prefix "MeshModel"
    let ModelLayer = _prefixId.prefix "ModelLayer"
    let Mood = _prefixId.prefix "Mood"
    let Motion = _prefixId.prefix "Motion"
    let NetworkLink = _prefixId.prefix "NetworkLink"
    let NetworkProperty = _prefixId.prefix "NetworkProperty"
    let NetworkQuality = _prefixId.prefix "NetworkQuality"
    let NetworkTopology = _prefixId.prefix "NetworkTopology"
    let NotGreen = _prefixId.prefix "NotGreen"
    let NotRenewable = _prefixId.prefix "NotRenewable"
    /// <summary>
    ///   <para>rdfs:comment : Observation Value.^^xsd:string</para>
    ///   <a href="http://spitfire-project.eu/ontology/ns/OV">spt:OV</a>
    /// </summary>
    let OV = _prefixId.prefix "OV"
    let Place = _prefixId.prefix "Place"
    let PlatformTemporalProperty = _prefixId.prefix "PlatformTemporalProperty"
    let Power = _prefixId.prefix "Power"
    /// <summary>
    ///   <para>rdfs:comment : Observed property (Quantity).^^xsd:string</para>
    ///   <a href="http://spitfire-project.eu/ontology/ns/Quantity">spt:Quantity</a>
    /// </summary>
    let Quantity = _prefixId.prefix "Quantity"
    let Renewable = _prefixId.prefix "Renewable"
    let SavedEnergy = _prefixId.prefix "SavedEnergy"
    let SensorNetwork = _prefixId.prefix "SensorNetwork"
    let SensorProjectTopic = _prefixId.prefix "SensorProjectTopic"
    let SensorRole = _prefixId.prefix "SensorRole"
    let SensorTemporalProperty = _prefixId.prefix "SensorTemporalProperty"
    /// <summary>
    ///   <para>rdfs:comment : Versions of a same observed Property (Quantity) which vary across time and space, as captured by the sensor's observed values.^^xsd:string</para>
    ///   <a href="http://spitfire-project.eu/ontology/ns/TSMap">spt:TSMap</a>
    /// </summary>
    let TSMap = _prefixId.prefix "TSMap"
    let TemporalProperty = _prefixId.prefix "TemporalProperty"
    let Thermal = _prefixId.prefix "Thermal"
    let Transducer = _prefixId.prefix "Transducer"
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>rdfs:comment : Relationship among a LinkActivity and the end datetime of the time range which it refers to.^^xsd:string</para>
    ///   <a href="http://spitfire-project.eu/ontology/ns/activityEnd">spt:activityEnd</a>
    /// </summary>
    let activityEnd = _prefixId.prefix "activityEnd"
    /// <summary>
    ///   <para>rdfs:comment : Relationship among an Activity and the start datetime of the time range which it refers to.^^xsd:string</para>
    ///   <a href="http://spitfire-project.eu/ontology/ns/activityStart">spt:activityStart</a>
    /// </summary>
    let activityStart = _prefixId.prefix "activityStart"
    let actuate = _prefixId.prefix "actuate"
    let actuatedBy = _prefixId.prefix "actuatedBy"
    let actuatedProperty = _prefixId.prefix "actuatedProperty"
    let actuatedPropertyOf = _prefixId.prefix "actuatedPropertyOf"
    let avgValue = _prefixId.prefix "avgValue"
    let belongsToLayer = _prefixId.prefix "belongsToLayer"
    let belongsToNetwork = _prefixId.prefix "belongsToNetwork"
    let bytes = _prefixId.prefix "bytes"
    let confidence = _prefixId.prefix "confidence"
    let containedIn = _prefixId.prefix "containedIn"
    let describesNetwork = _prefixId.prefix "describesNetwork"
    let endpoint = _prefixId.prefix "endpoint"
    let energyConsumed = _prefixId.prefix "energyConsumed"
    let energyLabel = _prefixId.prefix "energyLabel"
    let energyOutcomes = _prefixId.prefix "energyOutcomes"
    let energyRate = _prefixId.prefix "energyRate"
    let energySource = _prefixId.prefix "energySource"
    let energyUsedIn = _prefixId.prefix "energyUsedIn"
    let feed = _prefixId.prefix "feed"
    let forSTatus = _prefixId.prefix "forSTatus"
    let forStatus = _prefixId.prefix "forStatus"
    let from = _prefixId.prefix "from"
    let hasLayer = _prefixId.prefix "hasLayer"
    let hasLink = _prefixId.prefix "hasLink"
    let inputEnergy = _prefixId.prefix "inputEnergy"
    let ipDevice = _prefixId.prefix "ipDevice"
    let ipGate = _prefixId.prefix "ipGate"
    let isLayerOf = _prefixId.prefix "isLayerOf"
    let isLinkOf = _prefixId.prefix "isLinkOf"
    let isQualityOf = _prefixId.prefix "isQualityOf"
    let layer = _prefixId.prefix "layer"
    let layerOf = _prefixId.prefix "layerOf"
    let linkActivity = _prefixId.prefix "linkActivity"
    let linkActivityOf = _prefixId.prefix "linkActivityOf"
    /// <summary>
    ///   <para>rdfs:comment : Relationship among a LinkActivity and the amount of packets received in the time range specified by the predicates :startDateTime and :endDateTime^^xsd:string</para>
    ///   <a href="http://spitfire-project.eu/ontology/ns/linkActivityValue">spt:linkActivityValue</a>
    /// </summary>
    let linkActivityValue = _prefixId.prefix "linkActivityValue"
    let linkQuality = _prefixId.prefix "linkQuality"
    let linkQualityOf = _prefixId.prefix "linkQualityOf"
    let linkQualityValue = _prefixId.prefix "linkQualityValue"
    let maxValue = _prefixId.prefix "maxValue"
    let message = _prefixId.prefix "message"
    let minValue = _prefixId.prefix "minValue"
    let mood = _prefixId.prefix "mood"
    let nearby = _prefixId.prefix "nearby"
    let netLink = _prefixId.prefix "netLink"
    let netLinkOf = _prefixId.prefix "netLinkOf"
    let netRole = _prefixId.prefix "netRole"
    let obs = _prefixId.prefix "obs"
    let obsBy = _prefixId.prefix "obsBy"
    let out = _prefixId.prefix "out"
    let outOf = _prefixId.prefix "outOf"
    let outputEnergy = _prefixId.prefix "outputEnergy"
    let over = _prefixId.prefix "over"
    let ownedBy = _prefixId.prefix "ownedBy"
    let owns = _prefixId.prefix "owns"
    let priorityLevel = _prefixId.prefix "priorityLevel"
    let projectTopic = _prefixId.prefix "projectTopic"
    let projectTopicOf = _prefixId.prefix "projectTopicOf"
    let sameAsLink = _prefixId.prefix "sameAsLink"
    let sameContext = _prefixId.prefix "sameContext"
    let sameDomain = _prefixId.prefix "sameDomain"
    let sameLocation = _prefixId.prefix "sameLocation"
    let sameTime = _prefixId.prefix "sameTime"
    let savedEnergy = _prefixId.prefix "savedEnergy"
    let savedEnergyOf = _prefixId.prefix "savedEnergyOf"
    let seeAlsoLink = _prefixId.prefix "seeAlsoLink"
    let sensed = _prefixId.prefix "sensed"
    let sensedBy = _prefixId.prefix "sensedBy"
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:comment : Datetime after which a given entity and all the triples referred to it, are not valid anymore.^^xsd:string</para>
    ///   <a href="http://spitfire-project.eu/ontology/ns/tEnd">spt:tEnd</a>
    /// </summary>
    let tEnd = _prefixId.prefix "tEnd"
    /// <summary>
    ///   <para>rdfs:comment : Datetime at which a given entity and all the triples referred to it, start to be valid.^^xsd:string</para>
    ///   <a href="http://spitfire-project.eu/ontology/ns/tStart">spt:tStart</a>
    /// </summary>
    let tStart = _prefixId.prefix "tStart"
    let temporal = _prefixId.prefix "temporal"
    let temporalOf = _prefixId.prefix "temporalOf"
    let title = _prefixId.prefix "title"
    let to_ = _prefixId.prefix "to"
    let totAreas = _prefixId.prefix "totAreas"
    let tsMap = _prefixId.prefix "tsMap"
    let tsMapOf = _prefixId.prefix "tsMapOf"
    let under = _prefixId.prefix "under"
    /// <summary>
    ///   <para>rdfs:comment : Unit of Measurement in use on a specific device or sensor or sensing device^^xsd:string</para>
    ///   <a href="http://spitfire-project.eu/ontology/ns/uom">spt:uom</a>
    /// </summary>
    let uom = _prefixId.prefix "uom"
    let value = _prefixId.prefix "value"
    let valueRange = _prefixId.prefix "valueRange"
    let wears = _prefixId.prefix "wears"
    let weatherForecast = _prefixId.prefix "weatherForecast"
    let wornBy = _prefixId.prefix "wornBy"
