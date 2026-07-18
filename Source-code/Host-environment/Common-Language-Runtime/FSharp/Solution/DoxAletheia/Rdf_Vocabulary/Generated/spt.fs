namespace http.spitfire_project.eu.ontology.ns.slash

open DoxAletheia.Rdf_Vocabulary

module spt =
    let _namespace_name = "http://spitfire-project.eu/ontology/ns/"

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/AccessLayer"></see>
    /// </summary>
    let AccessLayer =
        Namespaced_IRI.parse _namespace_name "AccessLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/ModelLayer"></see>
    /// </summary>
    let ModelLayer = Namespaced_IRI.parse _namespace_name "ModelLayer" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Acoustic"></see>
    /// </summary>
    let Acoustic = Namespaced_IRI.parse _namespace_name "Acoustic" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Energy"></see>
    /// </summary>
    let Energy = Namespaced_IRI.parse _namespace_name "Energy" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Activity"></see>
    /// </summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/ActuatedProperty"></see>
    /// </summary>
    let ActuatedProperty =
        Namespaced_IRI.parse _namespace_name "ActuatedProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Actuator"></see>
    /// </summary>
    let Actuator = Namespaced_IRI.parse _namespace_name "Actuator" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Transducer"></see>
    /// </summary>
    let Transducer = Namespaced_IRI.parse _namespace_name "Transducer" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Agent"></see>
    /// </summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Chemical"></see>
    /// </summary>
    let Chemical = Namespaced_IRI.parse _namespace_name "Chemical" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/CoreLayer"></see>
    /// </summary>
    let CoreLayer = Namespaced_IRI.parse _namespace_name "CoreLayer" |> NamespacedName
    /// <summary>
    /// Link Association.
    /// <see href="http://spitfire-project.eu/ontology/ns/DataLink"></see></summary>
    let DataLink = Namespaced_IRI.parse _namespace_name "DataLink" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/DeviceRole"></see>
    /// </summary>
    let DeviceRole = Namespaced_IRI.parse _namespace_name "DeviceRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/DistributionLayer"></see>
    /// </summary>
    let DistributionLayer =
        Namespaced_IRI.parse _namespace_name "DistributionLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Electrical"></see>
    /// </summary>
    let Electrical = Namespaced_IRI.parse _namespace_name "Electrical" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Electromagnetic"></see>
    /// </summary>
    let Electromagnetic =
        Namespaced_IRI.parse _namespace_name "Electromagnetic" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Magnetic"></see>
    /// </summary>
    let Magnetic = Namespaced_IRI.parse _namespace_name "Magnetic" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/EnergyLabel"></see>
    /// </summary>
    let EnergyLabel =
        Namespaced_IRI.parse _namespace_name "EnergyLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/EnergySource"></see>
    /// </summary>
    let EnergySource =
        Namespaced_IRI.parse _namespace_name "EnergySource" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/FlatModel"></see>
    /// </summary>
    let FlatModel = Namespaced_IRI.parse _namespace_name "FlatModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/NetworkTopology"></see>
    /// </summary>
    let NetworkTopology =
        Namespaced_IRI.parse _namespace_name "NetworkTopology" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Green"></see>
    /// </summary>
    let Green = Namespaced_IRI.parse _namespace_name "Green" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/HierarchicalModel"></see>
    /// </summary>
    let HierarchicalModel =
        Namespaced_IRI.parse _namespace_name "HierarchicalModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Light"></see>
    /// </summary>
    let Light = Namespaced_IRI.parse _namespace_name "Light" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/LinkActivity"></see>
    /// </summary>
    let LinkActivity =
        Namespaced_IRI.parse _namespace_name "LinkActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/LinkProperty"></see>
    /// </summary>
    let LinkProperty =
        Namespaced_IRI.parse _namespace_name "LinkProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/LinkQuality"></see>
    /// </summary>
    let LinkQuality =
        Namespaced_IRI.parse _namespace_name "LinkQuality" |> NamespacedName

    /// <summary>
    /// Link Review.
    /// <see href="http://spitfire-project.eu/ontology/ns/LinkReview"></see></summary>
    let LinkReview = Namespaced_IRI.parse _namespace_name "LinkReview" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Mechanical"></see>
    /// </summary>
    let Mechanical = Namespaced_IRI.parse _namespace_name "Mechanical" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/MeshModel"></see>
    /// </summary>
    let MeshModel = Namespaced_IRI.parse _namespace_name "MeshModel" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Mood"></see>
    /// </summary>
    let Mood = Namespaced_IRI.parse _namespace_name "Mood" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Motion"></see>
    /// </summary>
    let Motion = Namespaced_IRI.parse _namespace_name "Motion" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/NetworkLink"></see>
    /// </summary>
    let NetworkLink =
        Namespaced_IRI.parse _namespace_name "NetworkLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/NetworkProperty"></see>
    /// </summary>
    let NetworkProperty =
        Namespaced_IRI.parse _namespace_name "NetworkProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/NetworkQuality"></see>
    /// </summary>
    let NetworkQuality =
        Namespaced_IRI.parse _namespace_name "NetworkQuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/NotGreen"></see>
    /// </summary>
    let NotGreen = Namespaced_IRI.parse _namespace_name "NotGreen" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/NotRenewable"></see>
    /// </summary>
    let NotRenewable =
        Namespaced_IRI.parse _namespace_name "NotRenewable" |> NamespacedName

    /// <summary>
    /// Observation Value.
    /// <see href="http://spitfire-project.eu/ontology/ns/OV"></see></summary>
    let OV = Namespaced_IRI.parse _namespace_name "OV" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Place"></see>
    /// </summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/PlatformTemporalProperty"></see>
    /// </summary>
    let PlatformTemporalProperty =
        Namespaced_IRI.parse _namespace_name "PlatformTemporalProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/TemporalProperty"></see>
    /// </summary>
    let TemporalProperty =
        Namespaced_IRI.parse _namespace_name "TemporalProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Power"></see>
    /// </summary>
    let Power = Namespaced_IRI.parse _namespace_name "Power" |> NamespacedName
    /// <summary>
    /// Observed property (Quantity).
    /// <see href="http://spitfire-project.eu/ontology/ns/Quantity"></see></summary>
    let Quantity = Namespaced_IRI.parse _namespace_name "Quantity" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Renewable"></see>
    /// </summary>
    let Renewable = Namespaced_IRI.parse _namespace_name "Renewable" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/SensorNetwork"></see>
    /// </summary>
    let SensorNetwork =
        Namespaced_IRI.parse _namespace_name "SensorNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/SensorProjectTopic"></see>
    /// </summary>
    let SensorProjectTopic =
        Namespaced_IRI.parse _namespace_name "SensorProjectTopic" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/SensorRole"></see>
    /// </summary>
    let SensorRole = Namespaced_IRI.parse _namespace_name "SensorRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/SensorTemporalProperty"></see>
    /// </summary>
    let SensorTemporalProperty =
        Namespaced_IRI.parse _namespace_name "SensorTemporalProperty" |> NamespacedName

    /// <summary>
    /// Versions of a same observed Property (Quantity) which vary across time and space, as captured by the sensor's observed values.
    /// <see href="http://spitfire-project.eu/ontology/ns/TSMap"></see></summary>
    let TSMap = Namespaced_IRI.parse _namespace_name "TSMap" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Thermal"></see>
    /// </summary>
    let Thermal = Namespaced_IRI.parse _namespace_name "Thermal" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/Unit"></see>
    /// </summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName

    /// <summary>
    /// Relationship among a LinkActivity and the end datetime of the time range which it refers to.
    /// <see href="http://spitfire-project.eu/ontology/ns/activityEnd"></see></summary>
    let activityEnd =
        Namespaced_IRI.parse _namespace_name "activityEnd" |> NamespacedName

    /// <summary>
    /// Relationship among an Activity and the start datetime of the time range which it refers to.
    /// <see href="http://spitfire-project.eu/ontology/ns/activityStart"></see></summary>
    let activityStart =
        Namespaced_IRI.parse _namespace_name "activityStart" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/actuate"></see>
    /// </summary>
    let actuate = Namespaced_IRI.parse _namespace_name "actuate" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/actuatedBy"></see>
    /// </summary>
    let actuatedBy = Namespaced_IRI.parse _namespace_name "actuatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/actuatedProperty"></see>
    /// </summary>
    let actuatedProperty =
        Namespaced_IRI.parse _namespace_name "actuatedProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/actuatedPropertyOf"></see>
    /// </summary>
    let actuatedPropertyOf =
        Namespaced_IRI.parse _namespace_name "actuatedPropertyOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/avgValue"></see>
    /// </summary>
    let avgValue = Namespaced_IRI.parse _namespace_name "avgValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/belongsToLayer"></see>
    /// </summary>
    let belongsToLayer =
        Namespaced_IRI.parse _namespace_name "belongsToLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/belongsToNetwork"></see>
    /// </summary>
    let belongsToNetwork =
        Namespaced_IRI.parse _namespace_name "belongsToNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/bytes"></see>
    /// </summary>
    let bytes = Namespaced_IRI.parse _namespace_name "bytes" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/confidence"></see>
    /// </summary>
    let confidence = Namespaced_IRI.parse _namespace_name "confidence" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/containedIn"></see>
    /// </summary>
    let containedIn =
        Namespaced_IRI.parse _namespace_name "containedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/describesNetwork"></see>
    /// </summary>
    let describesNetwork =
        Namespaced_IRI.parse _namespace_name "describesNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/endpoint"></see>
    /// </summary>
    let endpoint = Namespaced_IRI.parse _namespace_name "endpoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/energyConsumed"></see>
    /// </summary>
    let energyConsumed =
        Namespaced_IRI.parse _namespace_name "energyConsumed" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/energyLabel"></see>
    /// </summary>
    let energyLabel =
        Namespaced_IRI.parse _namespace_name "energyLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/energyOutcomes"></see>
    /// </summary>
    let energyOutcomes =
        Namespaced_IRI.parse _namespace_name "energyOutcomes" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/energyRate"></see>
    /// </summary>
    let energyRate = Namespaced_IRI.parse _namespace_name "energyRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/energySource"></see>
    /// </summary>
    let energySource =
        Namespaced_IRI.parse _namespace_name "energySource" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/energyUsedIn"></see>
    /// </summary>
    let energyUsedIn =
        Namespaced_IRI.parse _namespace_name "energyUsedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/feed"></see>
    /// </summary>
    let feed = Namespaced_IRI.parse _namespace_name "feed" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/forSTatus"></see>
    /// </summary>
    let forSTatus = Namespaced_IRI.parse _namespace_name "forSTatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/context-types#Status"></see>
    /// </summary>
    let ``context-types#Status`` =
        Namespaced_IRI.parse _namespace_name "context-types#Status" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/mood"></see>
    /// </summary>
    let mood = Namespaced_IRI.parse _namespace_name "mood" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/from"></see>
    /// </summary>
    let from = Namespaced_IRI.parse _namespace_name "from" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/to"></see>
    /// </summary>
    let to_ = Namespaced_IRI.parse _namespace_name "to" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/inputEnergy"></see>
    /// </summary>
    let inputEnergy =
        Namespaced_IRI.parse _namespace_name "inputEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/outputEnergy"></see>
    /// </summary>
    let outputEnergy =
        Namespaced_IRI.parse _namespace_name "outputEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/ipDevice"></see>
    /// </summary>
    let ipDevice = Namespaced_IRI.parse _namespace_name "ipDevice" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/ipGate"></see>
    /// </summary>
    let ipGate = Namespaced_IRI.parse _namespace_name "ipGate" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/layer"></see>
    /// </summary>
    let layer = Namespaced_IRI.parse _namespace_name "layer" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/isLayerOf"></see>
    /// </summary>
    let isLayerOf = Namespaced_IRI.parse _namespace_name "isLayerOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/layerOf"></see>
    /// </summary>
    let layerOf = Namespaced_IRI.parse _namespace_name "layerOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/hasLayer"></see>
    /// </summary>
    let hasLayer = Namespaced_IRI.parse _namespace_name "hasLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/linkActivity"></see>
    /// </summary>
    let linkActivity =
        Namespaced_IRI.parse _namespace_name "linkActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/linkActivityOf"></see>
    /// </summary>
    let linkActivityOf =
        Namespaced_IRI.parse _namespace_name "linkActivityOf" |> NamespacedName

    /// <summary>
    /// Relationship among a LinkActivity and the amount of packets received in the time range specified by the predicates :startDateTime and :endDateTime
    /// <see href="http://spitfire-project.eu/ontology/ns/linkActivityValue"></see></summary>
    let linkActivityValue =
        Namespaced_IRI.parse _namespace_name "linkActivityValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/linkQuality"></see>
    /// </summary>
    let linkQuality =
        Namespaced_IRI.parse _namespace_name "linkQuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/isQualityOf"></see>
    /// </summary>
    let isQualityOf =
        Namespaced_IRI.parse _namespace_name "isQualityOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/linkQualityOf"></see>
    /// </summary>
    let linkQualityOf =
        Namespaced_IRI.parse _namespace_name "linkQualityOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/linkQualityValue"></see>
    /// </summary>
    let linkQualityValue =
        Namespaced_IRI.parse _namespace_name "linkQualityValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/maxValue"></see>
    /// </summary>
    let maxValue = Namespaced_IRI.parse _namespace_name "maxValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/message"></see>
    /// </summary>
    let message = Namespaced_IRI.parse _namespace_name "message" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/minValue"></see>
    /// </summary>
    let minValue = Namespaced_IRI.parse _namespace_name "minValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/forStatus"></see>
    /// </summary>
    let forStatus = Namespaced_IRI.parse _namespace_name "forStatus" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/nearby"></see>
    /// </summary>
    let nearby = Namespaced_IRI.parse _namespace_name "nearby" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/netLink"></see>
    /// </summary>
    let netLink = Namespaced_IRI.parse _namespace_name "netLink" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/isLinkOf"></see>
    /// </summary>
    let isLinkOf = Namespaced_IRI.parse _namespace_name "isLinkOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/netLinkOf"></see>
    /// </summary>
    let netLinkOf = Namespaced_IRI.parse _namespace_name "netLinkOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/hasLink"></see>
    /// </summary>
    let hasLink = Namespaced_IRI.parse _namespace_name "hasLink" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/netRole"></see>
    /// </summary>
    let netRole = Namespaced_IRI.parse _namespace_name "netRole" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/obs"></see>
    /// </summary>
    let obs = Namespaced_IRI.parse _namespace_name "obs" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/obsBy"></see>
    /// </summary>
    let obsBy = Namespaced_IRI.parse _namespace_name "obsBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/out"></see>
    /// </summary>
    let out = Namespaced_IRI.parse _namespace_name "out" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/outOf"></see>
    /// </summary>
    let outOf = Namespaced_IRI.parse _namespace_name "outOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/over"></see>
    /// </summary>
    let over = Namespaced_IRI.parse _namespace_name "over" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/ownedBy"></see>
    /// </summary>
    let ownedBy = Namespaced_IRI.parse _namespace_name "ownedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/owns"></see>
    /// </summary>
    let owns = Namespaced_IRI.parse _namespace_name "owns" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/priorityLevel"></see>
    /// </summary>
    let priorityLevel =
        Namespaced_IRI.parse _namespace_name "priorityLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/projectTopic"></see>
    /// </summary>
    let projectTopic =
        Namespaced_IRI.parse _namespace_name "projectTopic" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/projectTopicOf"></see>
    /// </summary>
    let projectTopicOf =
        Namespaced_IRI.parse _namespace_name "projectTopicOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sameAsLink"></see>
    /// </summary>
    let sameAsLink = Namespaced_IRI.parse _namespace_name "sameAsLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sameContext"></see>
    /// </summary>
    let sameContext =
        Namespaced_IRI.parse _namespace_name "sameContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sameDomain"></see>
    /// </summary>
    let sameDomain = Namespaced_IRI.parse _namespace_name "sameDomain" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sameLocation"></see>
    /// </summary>
    let sameLocation =
        Namespaced_IRI.parse _namespace_name "sameLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sameTime"></see>
    /// </summary>
    let sameTime = Namespaced_IRI.parse _namespace_name "sameTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/savedEnergy"></see>
    /// </summary>
    let savedEnergy =
        Namespaced_IRI.parse _namespace_name "savedEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/SavedEnergy"></see>
    /// </summary>
    let SavedEnergy =
        Namespaced_IRI.parse _namespace_name "SavedEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/savedEnergyOf"></see>
    /// </summary>
    let savedEnergyOf =
        Namespaced_IRI.parse _namespace_name "savedEnergyOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/seeAlsoLink"></see>
    /// </summary>
    let seeAlsoLink =
        Namespaced_IRI.parse _namespace_name "seeAlsoLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sensed"></see>
    /// </summary>
    let sensed = Namespaced_IRI.parse _namespace_name "sensed" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/sensedBy"></see>
    /// </summary>
    let sensedBy = Namespaced_IRI.parse _namespace_name "sensedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/status"></see>
    /// </summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    /// Datetime after which a given entity and all the triples referred to it, are not valid anymore.
    /// <see href="http://spitfire-project.eu/ontology/ns/tEnd"></see></summary>
    let tEnd = Namespaced_IRI.parse _namespace_name "tEnd" |> NamespacedName
    /// <summary>
    /// Datetime at which a given entity and all the triples referred to it, start to be valid.
    /// <see href="http://spitfire-project.eu/ontology/ns/tStart"></see></summary>
    let tStart = Namespaced_IRI.parse _namespace_name "tStart" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/temporal"></see>
    /// </summary>
    let temporal = Namespaced_IRI.parse _namespace_name "temporal" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/temporalOf"></see>
    /// </summary>
    let temporalOf = Namespaced_IRI.parse _namespace_name "temporalOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/totAreas"></see>
    /// </summary>
    let totAreas = Namespaced_IRI.parse _namespace_name "totAreas" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/tsMap"></see>
    /// </summary>
    let tsMap = Namespaced_IRI.parse _namespace_name "tsMap" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/tsMapOf"></see>
    /// </summary>
    let tsMapOf = Namespaced_IRI.parse _namespace_name "tsMapOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/under"></see>
    /// </summary>
    let under = Namespaced_IRI.parse _namespace_name "under" |> NamespacedName
    /// <summary>
    /// Unit of Measurement in use on a specific device or sensor or sensing device
    /// <see href="http://spitfire-project.eu/ontology/ns/uom"></see></summary>
    let uom = Namespaced_IRI.parse _namespace_name "uom" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/valueRange"></see>
    /// </summary>
    let valueRange = Namespaced_IRI.parse _namespace_name "valueRange" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/wears"></see>
    /// </summary>
    let wears = Namespaced_IRI.parse _namespace_name "wears" |> NamespacedName
    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/wornBy"></see>
    /// </summary>
    let wornBy = Namespaced_IRI.parse _namespace_name "wornBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://spitfire-project.eu/ontology/ns/weatherForecast"></see>
    /// </summary>
    let weatherForecast =
        Namespaced_IRI.parse _namespace_name "weatherForecast" |> NamespacedName
