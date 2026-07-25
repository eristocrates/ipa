namespace http.spitfire_project.eu.ontology.ns.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module spt =
    let _namespace_iri = Namespace_Iri spt |> NamespaceIRI
    /// <summary>
    ///   <para>spt:linkQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/linkQuality">http://spitfire-project.eu/ontology/ns/linkQuality</seealso>
    let linkQuality = Prefixed_Name(spt, "linkQuality") |> PrefixedName
    /// <summary>
    ///   <para>spt:maxValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/maxValue">http://spitfire-project.eu/ontology/ns/maxValue</seealso>
    let maxValue = Prefixed_Name(spt, "maxValue") |> PrefixedName
    /// <summary>
    ///   <para>spt:message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/message">http://spitfire-project.eu/ontology/ns/message</seealso>
    let message = Prefixed_Name(spt, "message") |> PrefixedName
    /// <summary>
    ///   <para>spt:netLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/netLink">http://spitfire-project.eu/ontology/ns/netLink</seealso>
    let netLink = Prefixed_Name(spt, "netLink") |> PrefixedName
    /// <summary>
    ///   <para>spt:outOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/outOf">http://spitfire-project.eu/ontology/ns/outOf</seealso>
    let outOf = Prefixed_Name(spt, "outOf") |> PrefixedName
    /// <summary>
    ///   <para>spt:owns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/owns">http://spitfire-project.eu/ontology/ns/owns</seealso>
    let owns = Prefixed_Name(spt, "owns") |> PrefixedName
    /// <summary>
    ///   <para>spt:priorityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/priorityLevel">http://spitfire-project.eu/ontology/ns/priorityLevel</seealso>
    let priorityLevel = Prefixed_Name(spt, "priorityLevel") |> PrefixedName
    /// <summary>
    ///   <para>spt:sameContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/sameContext">http://spitfire-project.eu/ontology/ns/sameContext</seealso>
    let sameContext = Prefixed_Name(spt, "sameContext") |> PrefixedName
    /// <summary>
    ///   <para>spt:sameDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/sameDomain">http://spitfire-project.eu/ontology/ns/sameDomain</seealso>
    let sameDomain = Prefixed_Name(spt, "sameDomain") |> PrefixedName
    /// <summary>
    ///   <para>spt:sameLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/sameLocation">http://spitfire-project.eu/ontology/ns/sameLocation</seealso>
    let sameLocation = Prefixed_Name(spt, "sameLocation") |> PrefixedName
    /// <summary>
    ///   <para>spt:sameTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/sameTime">http://spitfire-project.eu/ontology/ns/sameTime</seealso>
    let sameTime = Prefixed_Name(spt, "sameTime") |> PrefixedName
    /// <summary>
    ///   <para>spt:sensed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/sensed">http://spitfire-project.eu/ontology/ns/sensed</seealso>
    let sensed = Prefixed_Name(spt, "sensed") |> PrefixedName
    /// <summary>
    ///   <para>spt:sensedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/sensedBy">http://spitfire-project.eu/ontology/ns/sensedBy</seealso>
    let sensedBy = Prefixed_Name(spt, "sensedBy") |> PrefixedName
    /// <summary>
    ///   <para>spt:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/status">http://spitfire-project.eu/ontology/ns/status</seealso>
    let status = Prefixed_Name(spt, "status") |> PrefixedName
    /// <summary>
    ///   <para>spt:tEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Datetime after which a given entity and all the triples referred to it, are not valid anymore.</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/tEnd">http://spitfire-project.eu/ontology/ns/tEnd</seealso>
    let tEnd = Prefixed_Name(spt, "tEnd") |> PrefixedName
    /// <summary>
    ///   <para>spt:totAreas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/totAreas">http://spitfire-project.eu/ontology/ns/totAreas</seealso>
    let totAreas = Prefixed_Name(spt, "totAreas") |> PrefixedName
    /// <summary>
    ///   <para>spt:tsMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/tsMap">http://spitfire-project.eu/ontology/ns/tsMap</seealso>
    let tsMap = Prefixed_Name(spt, "tsMap") |> PrefixedName
    /// <summary>
    ///   <para>spt:tsMapOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/tsMapOf">http://spitfire-project.eu/ontology/ns/tsMapOf</seealso>
    let tsMapOf = Prefixed_Name(spt, "tsMapOf") |> PrefixedName
    /// <summary>
    ///   <para>spt:uom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Unit of Measurement in use on a specific device or sensor or sensing device</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/uom">http://spitfire-project.eu/ontology/ns/uom</seealso>
    let uom = Prefixed_Name(spt, "uom") |> PrefixedName
    /// <summary>
    ///   <para>spt:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/value">http://spitfire-project.eu/ontology/ns/value</seealso>
    let value = Prefixed_Name(spt, "value") |> PrefixedName
    /// <summary>
    ///   <para>spt:wornBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/wornBy">http://spitfire-project.eu/ontology/ns/wornBy</seealso>
    let wornBy = Prefixed_Name(spt, "wornBy") |> PrefixedName
    /// <summary>
    ///   <para>spt:weatherForecast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/weatherForecast">http://spitfire-project.eu/ontology/ns/weatherForecast</seealso>
    let weatherForecast = Prefixed_Name(spt, "weatherForecast") |> PrefixedName
    /// <summary>
    ///   <para>spt:Acoustic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Acoustic">http://spitfire-project.eu/ontology/ns/Acoustic</seealso>
    let Acoustic = Prefixed_Name(spt, "Acoustic") |> PrefixedName
    /// <summary>
    ///   <para>spt:Transducer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Transducer">http://spitfire-project.eu/ontology/ns/Transducer</seealso>
    let Transducer = Prefixed_Name(spt, "Transducer") |> PrefixedName
    /// <summary>
    ///   <para>spt:AccessLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/AccessLayer">http://spitfire-project.eu/ontology/ns/AccessLayer</seealso>
    let AccessLayer = Prefixed_Name(spt, "AccessLayer") |> PrefixedName
    /// <summary>
    ///   <para>spt:minValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/minValue">http://spitfire-project.eu/ontology/ns/minValue</seealso>
    let minValue = Prefixed_Name(spt, "minValue") |> PrefixedName
    /// <summary>
    ///   <para>spt:isLinkOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/isLinkOf">http://spitfire-project.eu/ontology/ns/isLinkOf</seealso>
    let isLinkOf = Prefixed_Name(spt, "isLinkOf") |> PrefixedName
    /// <summary>
    ///   <para>spt:hasLink</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/hasLink">http://spitfire-project.eu/ontology/ns/hasLink</seealso>
    let hasLink = Prefixed_Name(spt, "hasLink") |> PrefixedName
    /// <summary>
    ///   <para>spt:obs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/obs">http://spitfire-project.eu/ontology/ns/obs</seealso>
    let obs = Prefixed_Name(spt, "obs") |> PrefixedName
    /// <summary>
    ///   <para>spt:ModelLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/ModelLayer">http://spitfire-project.eu/ontology/ns/ModelLayer</seealso>
    let ModelLayer = Prefixed_Name(spt, "ModelLayer") |> PrefixedName
    /// <summary>
    ///   <para>spt:Actuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Actuator">http://spitfire-project.eu/ontology/ns/Actuator</seealso>
    let Actuator = Prefixed_Name(spt, "Actuator") |> PrefixedName
    /// <summary>
    ///   <para>spt:Agent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Agent">http://spitfire-project.eu/ontology/ns/Agent</seealso>
    let Agent = Prefixed_Name(spt, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>spt:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/title">http://spitfire-project.eu/ontology/ns/title</seealso>
    let title = Prefixed_Name(spt, "title") |> PrefixedName
    /// <summary>
    ///   <para>spt:under</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/under">http://spitfire-project.eu/ontology/ns/under</seealso>
    let under = Prefixed_Name(spt, "under") |> PrefixedName
    /// <summary>
    ///   <para>spt:valueRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/valueRange">http://spitfire-project.eu/ontology/ns/valueRange</seealso>
    let valueRange = Prefixed_Name(spt, "valueRange") |> PrefixedName
    /// <summary>
    ///   <para>spt:wears</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/wears">http://spitfire-project.eu/ontology/ns/wears</seealso>
    let wears = Prefixed_Name(spt, "wears") |> PrefixedName
    /// <summary>
    ///   <para>spt:Energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Energy">http://spitfire-project.eu/ontology/ns/Energy</seealso>
    let Energy = Prefixed_Name(spt, "Energy") |> PrefixedName
    /// <summary>
    ///   <para>spt:ActuatedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/ActuatedProperty">http://spitfire-project.eu/ontology/ns/ActuatedProperty</seealso>
    let ActuatedProperty = Prefixed_Name(spt, "ActuatedProperty") |> PrefixedName
    /// <summary>
    ///   <para>spt:Chemical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Chemical">http://spitfire-project.eu/ontology/ns/Chemical</seealso>
    let Chemical = Prefixed_Name(spt, "Chemical") |> PrefixedName
    /// <summary>
    ///   <para>spt:DeviceRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/DeviceRole">http://spitfire-project.eu/ontology/ns/DeviceRole</seealso>
    let DeviceRole = Prefixed_Name(spt, "DeviceRole") |> PrefixedName
    /// <summary>
    ///   <para>spt:Magnetic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Magnetic">http://spitfire-project.eu/ontology/ns/Magnetic</seealso>
    let Magnetic = Prefixed_Name(spt, "Magnetic") |> PrefixedName
    /// <summary>
    ///   <para>spt:EnergySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/EnergySource">http://spitfire-project.eu/ontology/ns/EnergySource</seealso>
    let EnergySource = Prefixed_Name(spt, "EnergySource") |> PrefixedName
    /// <summary>
    ///   <para>spt:HierarchicalModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/HierarchicalModel">http://spitfire-project.eu/ontology/ns/HierarchicalModel</seealso>
    let HierarchicalModel = Prefixed_Name(spt, "HierarchicalModel") |> PrefixedName
    /// <summary>
    ///   <para>spt:LinkProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/LinkProperty">http://spitfire-project.eu/ontology/ns/LinkProperty</seealso>
    let LinkProperty = Prefixed_Name(spt, "LinkProperty") |> PrefixedName
    /// <summary>
    ///   <para>spt:MeshModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/MeshModel">http://spitfire-project.eu/ontology/ns/MeshModel</seealso>
    let MeshModel = Prefixed_Name(spt, "MeshModel") |> PrefixedName
    /// <summary>
    ///   <para>spt:NetworkProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/NetworkProperty">http://spitfire-project.eu/ontology/ns/NetworkProperty</seealso>
    let NetworkProperty = Prefixed_Name(spt, "NetworkProperty") |> PrefixedName
    /// <summary>
    ///   <para>spt:Electromagnetic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Electromagnetic">http://spitfire-project.eu/ontology/ns/Electromagnetic</seealso>
    let Electromagnetic = Prefixed_Name(spt, "Electromagnetic") |> PrefixedName
    /// <summary>
    ///   <para>spt:FlatModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/FlatModel">http://spitfire-project.eu/ontology/ns/FlatModel</seealso>
    let FlatModel = Prefixed_Name(spt, "FlatModel") |> PrefixedName
    /// <summary>
    ///   <para>spt:Green</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Green">http://spitfire-project.eu/ontology/ns/Green</seealso>
    let Green = Prefixed_Name(spt, "Green") |> PrefixedName
    /// <summary>
    ///   <para>spt:LinkActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/LinkActivity">http://spitfire-project.eu/ontology/ns/LinkActivity</seealso>
    let LinkActivity = Prefixed_Name(spt, "LinkActivity") |> PrefixedName
    /// <summary>
    ///   <para>spt:EnergyLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/EnergyLabel">http://spitfire-project.eu/ontology/ns/EnergyLabel</seealso>
    let EnergyLabel = Prefixed_Name(spt, "EnergyLabel") |> PrefixedName
    /// <summary>
    ///   <para>spt:NetworkTopology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/NetworkTopology">http://spitfire-project.eu/ontology/ns/NetworkTopology</seealso>
    let NetworkTopology = Prefixed_Name(spt, "NetworkTopology") |> PrefixedName
    /// <summary>
    ///   <para>spt:Light</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Light">http://spitfire-project.eu/ontology/ns/Light</seealso>
    let Light = Prefixed_Name(spt, "Light") |> PrefixedName
    /// <summary>
    ///   <para>spt:LinkReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Link Review.</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/LinkReview">http://spitfire-project.eu/ontology/ns/LinkReview</seealso>
    let LinkReview = Prefixed_Name(spt, "LinkReview") |> PrefixedName
    /// <summary>
    ///   <para>spt:LinkQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/LinkQuality">http://spitfire-project.eu/ontology/ns/LinkQuality</seealso>
    let LinkQuality = Prefixed_Name(spt, "LinkQuality") |> PrefixedName
    /// <summary>
    ///   <para>spt:Motion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Motion">http://spitfire-project.eu/ontology/ns/Motion</seealso>
    let Motion = Prefixed_Name(spt, "Motion") |> PrefixedName
    /// <summary>
    ///   <para>spt:NotGreen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/NotGreen">http://spitfire-project.eu/ontology/ns/NotGreen</seealso>
    let NotGreen = Prefixed_Name(spt, "NotGreen") |> PrefixedName
    /// <summary>
    ///   <para>spt:OV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation Value.</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/OV">http://spitfire-project.eu/ontology/ns/OV</seealso>
    let OV = Prefixed_Name(spt, "OV") |> PrefixedName
    /// <summary>
    ///   <para>spt:Power</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Power">http://spitfire-project.eu/ontology/ns/Power</seealso>
    let Power = Prefixed_Name(spt, "Power") |> PrefixedName
    /// <summary>
    ///   <para>spt:Renewable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Renewable">http://spitfire-project.eu/ontology/ns/Renewable</seealso>
    let Renewable = Prefixed_Name(spt, "Renewable") |> PrefixedName
    /// <summary>
    ///   <para>spt:SensorProjectTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/SensorProjectTopic">http://spitfire-project.eu/ontology/ns/SensorProjectTopic</seealso>
    let SensorProjectTopic = Prefixed_Name(spt, "SensorProjectTopic") |> PrefixedName
    /// <summary>
    ///   <para>spt:TSMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Versions of a same observed Property (Quantity) which vary across time and space, as captured by the sensor's observed values.</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/TSMap">http://spitfire-project.eu/ontology/ns/TSMap</seealso>
    let TSMap = Prefixed_Name(spt, "TSMap") |> PrefixedName
    /// <summary>
    ///   <para>spt:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Unit">http://spitfire-project.eu/ontology/ns/Unit</seealso>
    let Unit = Prefixed_Name(spt, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>spt:actuate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/actuate">http://spitfire-project.eu/ontology/ns/actuate</seealso>
    let actuate = Prefixed_Name(spt, "actuate") |> PrefixedName
    /// <summary>
    ///   <para>spt:avgValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/avgValue">http://spitfire-project.eu/ontology/ns/avgValue</seealso>
    let avgValue = Prefixed_Name(spt, "avgValue") |> PrefixedName
    /// <summary>
    ///   <para>spt:belongsToLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/belongsToLayer">http://spitfire-project.eu/ontology/ns/belongsToLayer</seealso>
    let belongsToLayer = Prefixed_Name(spt, "belongsToLayer") |> PrefixedName
    /// <summary>
    ///   <para>spt:confidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/confidence">http://spitfire-project.eu/ontology/ns/confidence</seealso>
    let confidence = Prefixed_Name(spt, "confidence") |> PrefixedName
    /// <summary>
    ///   <para>spt:describesNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/describesNetwork">http://spitfire-project.eu/ontology/ns/describesNetwork</seealso>
    let describesNetwork = Prefixed_Name(spt, "describesNetwork") |> PrefixedName
    /// <summary>
    ///   <para>spt:energyConsumed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/energyConsumed">http://spitfire-project.eu/ontology/ns/energyConsumed</seealso>
    let energyConsumed = Prefixed_Name(spt, "energyConsumed") |> PrefixedName
    /// <summary>
    ///   <para>spt:energyLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/energyLabel">http://spitfire-project.eu/ontology/ns/energyLabel</seealso>
    let energyLabel = Prefixed_Name(spt, "energyLabel") |> PrefixedName
    /// <summary>
    ///   <para>spt:Mechanical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Mechanical">http://spitfire-project.eu/ontology/ns/Mechanical</seealso>
    let Mechanical = Prefixed_Name(spt, "Mechanical") |> PrefixedName
    /// <summary>
    ///   <para>spt:Mood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Mood">http://spitfire-project.eu/ontology/ns/Mood</seealso>
    let Mood = Prefixed_Name(spt, "Mood") |> PrefixedName
    /// <summary>
    ///   <para>spt:NetworkLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/NetworkLink">http://spitfire-project.eu/ontology/ns/NetworkLink</seealso>
    let NetworkLink = Prefixed_Name(spt, "NetworkLink") |> PrefixedName
    /// <summary>
    ///   <para>spt:NetworkQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/NetworkQuality">http://spitfire-project.eu/ontology/ns/NetworkQuality</seealso>
    let NetworkQuality = Prefixed_Name(spt, "NetworkQuality") |> PrefixedName
    /// <summary>
    ///   <para>spt:NotRenewable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/NotRenewable">http://spitfire-project.eu/ontology/ns/NotRenewable</seealso>
    let NotRenewable = Prefixed_Name(spt, "NotRenewable") |> PrefixedName
    /// <summary>
    ///   <para>spt:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Place">http://spitfire-project.eu/ontology/ns/Place</seealso>
    let Place = Prefixed_Name(spt, "Place") |> PrefixedName
    /// <summary>
    ///   <para>spt:TemporalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/TemporalProperty">http://spitfire-project.eu/ontology/ns/TemporalProperty</seealso>
    let TemporalProperty = Prefixed_Name(spt, "TemporalProperty") |> PrefixedName

    /// <summary>
    ///   <para>spt:PlatformTemporalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/PlatformTemporalProperty">http://spitfire-project.eu/ontology/ns/PlatformTemporalProperty</seealso>
    let PlatformTemporalProperty =
        Prefixed_Name(spt, "PlatformTemporalProperty") |> PrefixedName

    /// <summary>
    ///   <para>spt:SensorNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/SensorNetwork">http://spitfire-project.eu/ontology/ns/SensorNetwork</seealso>
    let SensorNetwork = Prefixed_Name(spt, "SensorNetwork") |> PrefixedName
    /// <summary>
    ///   <para>spt:SensorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/SensorRole">http://spitfire-project.eu/ontology/ns/SensorRole</seealso>
    let SensorRole = Prefixed_Name(spt, "SensorRole") |> PrefixedName
    /// <summary>
    ///   <para>spt:Thermal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Thermal">http://spitfire-project.eu/ontology/ns/Thermal</seealso>
    let Thermal = Prefixed_Name(spt, "Thermal") |> PrefixedName
    /// <summary>
    ///   <para>spt:activityEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relationship among a LinkActivity and the end datetime of the time range which it refers to.</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/activityEnd">http://spitfire-project.eu/ontology/ns/activityEnd</seealso>
    let activityEnd = Prefixed_Name(spt, "activityEnd") |> PrefixedName
    /// <summary>
    ///   <para>spt:Quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observed property (Quantity).</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Quantity">http://spitfire-project.eu/ontology/ns/Quantity</seealso>
    let Quantity = Prefixed_Name(spt, "Quantity") |> PrefixedName

    /// <summary>
    ///   <para>spt:SensorTemporalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/SensorTemporalProperty">http://spitfire-project.eu/ontology/ns/SensorTemporalProperty</seealso>
    let SensorTemporalProperty =
        Prefixed_Name(spt, "SensorTemporalProperty") |> PrefixedName

    /// <summary>
    ///   <para>spt:activityStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relationship among an Activity and the start datetime of the time range which it refers to.</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/activityStart">http://spitfire-project.eu/ontology/ns/activityStart</seealso>
    let activityStart = Prefixed_Name(spt, "activityStart") |> PrefixedName
    /// <summary>
    ///   <para>spt:actuatedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/actuatedProperty">http://spitfire-project.eu/ontology/ns/actuatedProperty</seealso>
    let actuatedProperty = Prefixed_Name(spt, "actuatedProperty") |> PrefixedName
    /// <summary>
    ///   <para>spt:actuatedPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/actuatedPropertyOf">http://spitfire-project.eu/ontology/ns/actuatedPropertyOf</seealso>
    let actuatedPropertyOf = Prefixed_Name(spt, "actuatedPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>spt:belongsToNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/belongsToNetwork">http://spitfire-project.eu/ontology/ns/belongsToNetwork</seealso>
    let belongsToNetwork = Prefixed_Name(spt, "belongsToNetwork") |> PrefixedName
    /// <summary>
    ///   <para>spt:bytes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/bytes">http://spitfire-project.eu/ontology/ns/bytes</seealso>
    let bytes = Prefixed_Name(spt, "bytes") |> PrefixedName
    /// <summary>
    ///   <para>spt:containedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/containedIn">http://spitfire-project.eu/ontology/ns/containedIn</seealso>
    let containedIn = Prefixed_Name(spt, "containedIn") |> PrefixedName
    /// <summary>
    ///   <para>spt:endpoint</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/endpoint">http://spitfire-project.eu/ontology/ns/endpoint</seealso>
    let endpoint = Prefixed_Name(spt, "endpoint") |> PrefixedName
    /// <summary>
    ///   <para>spt:actuatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/actuatedBy">http://spitfire-project.eu/ontology/ns/actuatedBy</seealso>
    let actuatedBy = Prefixed_Name(spt, "actuatedBy") |> PrefixedName
    /// <summary>
    ///   <para>spt:energyOutcomes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/energyOutcomes">http://spitfire-project.eu/ontology/ns/energyOutcomes</seealso>
    let energyOutcomes = Prefixed_Name(spt, "energyOutcomes") |> PrefixedName
    /// <summary>
    ///   <para>spt:energyUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/energyUsedIn">http://spitfire-project.eu/ontology/ns/energyUsedIn</seealso>
    let energyUsedIn = Prefixed_Name(spt, "energyUsedIn") |> PrefixedName
    /// <summary>
    ///   <para>spt:to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/to">http://spitfire-project.eu/ontology/ns/to</seealso>
    let to_ = Prefixed_Name(spt, "to") |> PrefixedName
    /// <summary>
    ///   <para>spt:energyRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/energyRate">http://spitfire-project.eu/ontology/ns/energyRate</seealso>
    let energyRate = Prefixed_Name(spt, "energyRate") |> PrefixedName

    /// <summary>
    ///   <para>spt:context-types#Status</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/context-types#Status">http://spitfire-project.eu/ontology/ns/context-types#Status</seealso>
    let ``context_types#Status`` =
        Prefixed_Name(spt, "context-types#Status") |> PrefixedName

    /// <summary>
    ///   <para>spt:energySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/energySource">http://spitfire-project.eu/ontology/ns/energySource</seealso>
    let energySource = Prefixed_Name(spt, "energySource") |> PrefixedName
    /// <summary>
    ///   <para>spt:forSTatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/forSTatus">http://spitfire-project.eu/ontology/ns/forSTatus</seealso>
    let forSTatus = Prefixed_Name(spt, "forSTatus") |> PrefixedName
    /// <summary>
    ///   <para>spt:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/from">http://spitfire-project.eu/ontology/ns/from</seealso>
    let from = Prefixed_Name(spt, "from") |> PrefixedName
    /// <summary>
    ///   <para>spt:inputEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/inputEnergy">http://spitfire-project.eu/ontology/ns/inputEnergy</seealso>
    let inputEnergy = Prefixed_Name(spt, "inputEnergy") |> PrefixedName
    /// <summary>
    ///   <para>spt:ipDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/ipDevice">http://spitfire-project.eu/ontology/ns/ipDevice</seealso>
    let ipDevice = Prefixed_Name(spt, "ipDevice") |> PrefixedName
    /// <summary>
    ///   <para>spt:ipGate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/ipGate">http://spitfire-project.eu/ontology/ns/ipGate</seealso>
    let ipGate = Prefixed_Name(spt, "ipGate") |> PrefixedName
    /// <summary>
    ///   <para>spt:isLayerOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/isLayerOf">http://spitfire-project.eu/ontology/ns/isLayerOf</seealso>
    let isLayerOf = Prefixed_Name(spt, "isLayerOf") |> PrefixedName
    /// <summary>
    ///   <para>spt:layerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/layerOf">http://spitfire-project.eu/ontology/ns/layerOf</seealso>
    let layerOf = Prefixed_Name(spt, "layerOf") |> PrefixedName
    /// <summary>
    ///   <para>spt:linkActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/linkActivity">http://spitfire-project.eu/ontology/ns/linkActivity</seealso>
    let linkActivity = Prefixed_Name(spt, "linkActivity") |> PrefixedName
    /// <summary>
    ///   <para>spt:linkActivityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/linkActivityOf">http://spitfire-project.eu/ontology/ns/linkActivityOf</seealso>
    let linkActivityOf = Prefixed_Name(spt, "linkActivityOf") |> PrefixedName
    /// <summary>
    ///   <para>spt:isQualityOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/isQualityOf">http://spitfire-project.eu/ontology/ns/isQualityOf</seealso>
    let isQualityOf = Prefixed_Name(spt, "isQualityOf") |> PrefixedName
    /// <summary>
    ///   <para>spt:linkQualityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/linkQualityOf">http://spitfire-project.eu/ontology/ns/linkQualityOf</seealso>
    let linkQualityOf = Prefixed_Name(spt, "linkQualityOf") |> PrefixedName
    /// <summary>
    ///   <para>spt:linkQualityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/linkQualityValue">http://spitfire-project.eu/ontology/ns/linkQualityValue</seealso>
    let linkQualityValue = Prefixed_Name(spt, "linkQualityValue") |> PrefixedName
    /// <summary>
    ///   <para>spt:forStatus</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/forStatus">http://spitfire-project.eu/ontology/ns/forStatus</seealso>
    let forStatus = Prefixed_Name(spt, "forStatus") |> PrefixedName
    /// <summary>
    ///   <para>spt:nearby</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/nearby">http://spitfire-project.eu/ontology/ns/nearby</seealso>
    let nearby = Prefixed_Name(spt, "nearby") |> PrefixedName
    /// <summary>
    ///   <para>spt:netLinkOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/netLinkOf">http://spitfire-project.eu/ontology/ns/netLinkOf</seealso>
    let netLinkOf = Prefixed_Name(spt, "netLinkOf") |> PrefixedName
    /// <summary>
    ///   <para>spt:netRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/netRole">http://spitfire-project.eu/ontology/ns/netRole</seealso>
    let netRole = Prefixed_Name(spt, "netRole") |> PrefixedName
    /// <summary>
    ///   <para>spt:obsBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/obsBy">http://spitfire-project.eu/ontology/ns/obsBy</seealso>
    let obsBy = Prefixed_Name(spt, "obsBy") |> PrefixedName
    /// <summary>
    ///   <para>spt:out</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/out">http://spitfire-project.eu/ontology/ns/out</seealso>
    let out = Prefixed_Name(spt, "out") |> PrefixedName
    /// <summary>
    ///   <para>spt:over</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/over">http://spitfire-project.eu/ontology/ns/over</seealso>
    let over = Prefixed_Name(spt, "over") |> PrefixedName
    /// <summary>
    ///   <para>spt:ownedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/ownedBy">http://spitfire-project.eu/ontology/ns/ownedBy</seealso>
    let ownedBy = Prefixed_Name(spt, "ownedBy") |> PrefixedName
    /// <summary>
    ///   <para>spt:projectTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/projectTopic">http://spitfire-project.eu/ontology/ns/projectTopic</seealso>
    let projectTopic = Prefixed_Name(spt, "projectTopic") |> PrefixedName
    /// <summary>
    ///   <para>spt:projectTopicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/projectTopicOf">http://spitfire-project.eu/ontology/ns/projectTopicOf</seealso>
    let projectTopicOf = Prefixed_Name(spt, "projectTopicOf") |> PrefixedName
    /// <summary>
    ///   <para>spt:sameAsLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/sameAsLink">http://spitfire-project.eu/ontology/ns/sameAsLink</seealso>
    let sameAsLink = Prefixed_Name(spt, "sameAsLink") |> PrefixedName
    /// <summary>
    ///   <para>spt:savedEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/savedEnergy">http://spitfire-project.eu/ontology/ns/savedEnergy</seealso>
    let savedEnergy = Prefixed_Name(spt, "savedEnergy") |> PrefixedName
    /// <summary>
    ///   <para>spt:SavedEnergy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/SavedEnergy">http://spitfire-project.eu/ontology/ns/SavedEnergy</seealso>
    let SavedEnergy = Prefixed_Name(spt, "SavedEnergy") |> PrefixedName
    /// <summary>
    ///   <para>spt:savedEnergyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/savedEnergyOf">http://spitfire-project.eu/ontology/ns/savedEnergyOf</seealso>
    let savedEnergyOf = Prefixed_Name(spt, "savedEnergyOf") |> PrefixedName
    /// <summary>
    ///   <para>spt:seeAlsoLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/seeAlsoLink">http://spitfire-project.eu/ontology/ns/seeAlsoLink</seealso>
    let seeAlsoLink = Prefixed_Name(spt, "seeAlsoLink") |> PrefixedName
    /// <summary>
    ///   <para>spt:tStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Datetime at which a given entity and all the triples referred to it, start to be valid.</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/tStart">http://spitfire-project.eu/ontology/ns/tStart</seealso>
    let tStart = Prefixed_Name(spt, "tStart") |> PrefixedName
    /// <summary>
    ///   <para>spt:temporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/temporal">http://spitfire-project.eu/ontology/ns/temporal</seealso>
    let temporal = Prefixed_Name(spt, "temporal") |> PrefixedName
    /// <summary>
    ///   <para>spt:temporalOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/temporalOf">http://spitfire-project.eu/ontology/ns/temporalOf</seealso>
    let temporalOf = Prefixed_Name(spt, "temporalOf") |> PrefixedName
    /// <summary>
    ///   <para>spt:feed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/feed">http://spitfire-project.eu/ontology/ns/feed</seealso>
    let feed = Prefixed_Name(spt, "feed") |> PrefixedName
    /// <summary>
    ///   <para>spt:mood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/mood">http://spitfire-project.eu/ontology/ns/mood</seealso>
    let mood = Prefixed_Name(spt, "mood") |> PrefixedName
    /// <summary>
    ///   <para>spt:outputEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/outputEnergy">http://spitfire-project.eu/ontology/ns/outputEnergy</seealso>
    let outputEnergy = Prefixed_Name(spt, "outputEnergy") |> PrefixedName
    /// <summary>
    ///   <para>spt:layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/layer">http://spitfire-project.eu/ontology/ns/layer</seealso>
    let layer = Prefixed_Name(spt, "layer") |> PrefixedName
    /// <summary>
    ///   <para>spt:hasLayer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/hasLayer">http://spitfire-project.eu/ontology/ns/hasLayer</seealso>
    let hasLayer = Prefixed_Name(spt, "hasLayer") |> PrefixedName
    /// <summary>
    ///   <para>spt:linkActivityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relationship among a LinkActivity and the amount of packets received in the time range specified by the predicates :startDateTime and :endDateTime</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/linkActivityValue">http://spitfire-project.eu/ontology/ns/linkActivityValue</seealso>
    let linkActivityValue = Prefixed_Name(spt, "linkActivityValue") |> PrefixedName
    /// <summary>
    ///   <para>spt:Activity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Activity">http://spitfire-project.eu/ontology/ns/Activity</seealso>
    let Activity = Prefixed_Name(spt, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>spt:CoreLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/CoreLayer">http://spitfire-project.eu/ontology/ns/CoreLayer</seealso>
    let CoreLayer = Prefixed_Name(spt, "CoreLayer") |> PrefixedName
    /// <summary>
    ///   <para>spt:DataLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Link Association.</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/DataLink">http://spitfire-project.eu/ontology/ns/DataLink</seealso>
    let DataLink = Prefixed_Name(spt, "DataLink") |> PrefixedName
    /// <summary>
    ///   <para>spt:DistributionLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/DistributionLayer">http://spitfire-project.eu/ontology/ns/DistributionLayer</seealso>
    let DistributionLayer = Prefixed_Name(spt, "DistributionLayer") |> PrefixedName
    /// <summary>
    ///   <para>spt:Electrical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://spitfire-project.eu/ontology/ns/Electrical">http://spitfire-project.eu/ontology/ns/Electrical</seealso>
    let Electrical = Prefixed_Name(spt, "Electrical") |> PrefixedName
