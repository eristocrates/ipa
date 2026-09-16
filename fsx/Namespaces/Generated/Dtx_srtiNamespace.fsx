#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dtx_srti =
    let _prefixId = PrefixId.fromNamespaceLabel "http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#" "dtx_srti"

    /// <summary>
    ///   <para>rdfs:comment : A traffic condition which is not normal.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AbnormalTraffic">dtx_srti:AbnormalTraffic</a>
    /// </summary>
    let AbnormalTraffic = _prefixId.prefix "AbnormalTraffic"
    /// <summary>
    ///   <para>rdfs:comment : Descriptive terms for abnormal traffic conditions specifically relating to the nature of the traffic movement, implying levels of service.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AbnormalTrafficTypeEnum">dtx_srti:AbnormalTrafficTypeEnum</a>
    /// </summary>
    let AbnormalTrafficTypeEnum = _prefixId.prefix "AbnormalTrafficTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Accidents are events where one or more vehicles are involved in collisions or in leaving the roadway. These include collisions between vehicles or with other road users or obstacles.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Accident">dtx_srti:Accident</a>
    /// </summary>
    let Accident = _prefixId.prefix "Accident"
    /// <summary>
    ///   <para>rdfs:comment : Collection of descriptive terms for causes of accidents.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AccidentCauseEnum">dtx_srti:AccidentCauseEnum</a>
    /// </summary>
    let AccidentCauseEnum = _prefixId.prefix "AccidentCauseEnum"
    /// <summary>
    ///   <para>rdfs:comment : Collection of descriptive terms for types of accidents.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AccidentTypeEnum">dtx_srti:AccidentTypeEnum</a>
    /// </summary>
    let AccidentTypeEnum = _prefixId.prefix "AccidentTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : A collection of information relating to human activities external to the traffic stream or roadway which could disrupt traffic.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Activity">dtx_srti:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:comment : Alert C location</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertC">dtx_srti:AlertC</a>
    /// </summary>
    let AlertC = _prefixId.prefix "AlertC"
    /// <summary>
    ///   <para>rdfs:comment : An area defined by reference to a predefined ALERT-C location table.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCArea">dtx_srti:AlertCArea</a>
    /// </summary>
    let AlertCArea = _prefixId.prefix "AlertCArea"
    /// <summary>
    ///   <para>rdfs:comment : The direction of traffic flow along the road to which the information relates.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCDirection">dtx_srti:AlertCDirection</a>
    /// </summary>
    let AlertCDirection = _prefixId.prefix "AlertCDirection"
    /// <summary>
    ///   <para>rdfs:comment : Direction used to reach the primary location from the secondary location in ALERT-C location table, as defined in CEN ISO 14819-1</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCDirectionEnum">dtx_srti:AlertCDirectionEnum</a>
    /// </summary>
    let AlertCDirectionEnum = _prefixId.prefix "AlertCDirectionEnum"
    /// <summary>
    ///   <para>rdfs:comment : A linear section along a road defined between two points on the road by reference to a pre-defined ALERT-C location table. When there are multiple instances of AlertCLinear they should represent the same location using different location tables.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLinear">dtx_srti:AlertCLinear</a>
    /// </summary>
    let AlertCLinear = _prefixId.prefix "AlertCLinear"
    /// <summary>
    ///   <para>rdfs:comment : A linear section along a road defined by reference to a linear section in a pre-defined ALERT-C location table.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLinearByCode">dtx_srti:AlertCLinearByCode</a>
    /// </summary>
    let AlertCLinearByCode = _prefixId.prefix "AlertCLinearByCode"
    /// <summary>
    ///   <para>rdfs:comment : Identification of a specific point, linear or area location in an ALERT-C location table.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLocation">dtx_srti:AlertCLocation</a>
    /// </summary>
    let AlertCLocation = _prefixId.prefix "AlertCLocation"
    /// <summary>
    ///   <para>rdfs:comment : A linear section along a road between two points, primary and secondary, which are pre-defined in an ALERT-C location table. Direction is FROM the secondary point TO the primary point, i.e. the primary point is downstream of the secondary point.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2Linear">dtx_srti:AlertCMethod2Linear</a>
    /// </summary>
    let AlertCMethod2Linear = _prefixId.prefix "AlertCMethod2Linear"
    /// <summary>
    ///   <para>rdfs:comment : A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table and which has an associated direction of traffic flow.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2Point">dtx_srti:AlertCMethod2Point</a>
    /// </summary>
    let AlertCMethod2Point = _prefixId.prefix "AlertCMethod2Point"

    /// <summary>
    ///   <para>rdfs:comment : The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2PrimaryPointLocation">dtx_srti:AlertCMethod2PrimaryPointLocation</a>
    /// </summary>
    let AlertCMethod2PrimaryPointLocation = _prefixId.prefix "AlertCMethod2PrimaryPointLocation"

    /// <summary>
    ///   <para>rdfs:comment : The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2SecondaryPointLocation">dtx_srti:AlertCMethod2SecondaryPointLocation</a>
    /// </summary>
    let AlertCMethod2SecondaryPointLocation = _prefixId.prefix "AlertCMethod2SecondaryPointLocation"

    /// <summary>
    ///   <para>rdfs:comment : A linear section along a road between two points, primary and secondary, which are pre-defined ALERT-C locations plus offset distance. Direction is FROM the secondary point TO the primary point, i.e. the primary point is downstream of the secondary point.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4Linear">dtx_srti:AlertCMethod4Linear</a>
    /// </summary>
    let AlertCMethod4Linear = _prefixId.prefix "AlertCMethod4Linear"
    /// <summary>
    ///   <para>rdfs:comment : A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table plus an offset distance and which has an associated direction of traffic flow.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4Point">dtx_srti:AlertCMethod4Point</a>
    /// </summary>
    let AlertCMethod4Point = _prefixId.prefix "AlertCMethod4Point"

    /// <summary>
    ///   <para>rdfs:comment : The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table plus a non-negative offset distance.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4PrimaryPointLocation">dtx_srti:AlertCMethod4PrimaryPointLocation</a>
    /// </summary>
    let AlertCMethod4PrimaryPointLocation = _prefixId.prefix "AlertCMethod4PrimaryPointLocation"

    /// <summary>
    ///   <para>rdfs:comment : The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined Alert-C location table plus a non-negative offset distance.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4SecondaryPointLocation">dtx_srti:AlertCMethod4SecondaryPointLocation</a>
    /// </summary>
    let AlertCMethod4SecondaryPointLocation = _prefixId.prefix "AlertCMethod4SecondaryPointLocation"

    /// <summary>
    ///   <para>rdfs:comment : A single point on the road network defined by reference to a pre-defined ALERT-C location table and which has an associated direction of traffic flow.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCPoint">dtx_srti:AlertCPoint</a>
    /// </summary>
    let AlertCPoint = _prefixId.prefix "AlertCPoint"
    /// <summary>
    ///   <para>rdfs:comment : Coded level of vertical accuracy</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AltitudeAccuracyEnum">dtx_srti:AltitudeAccuracyEnum</a>
    /// </summary>
    let AltitudeAccuracyEnum = _prefixId.prefix "AltitudeAccuracyEnum"
    /// <summary>
    ///   <para>rdfs:comment : Evaluation of the altitude confidence assessed according to ETSI ISO 102894-2^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AltitudeConfidence">dtx_srti:AltitudeConfidence</a>
    /// </summary>
    let AltitudeConfidence = _prefixId.prefix "AltitudeConfidence"
    /// <summary>
    ///   <para>rdfs:comment : A measured or  value of Angles. An integer number representing an angle in whole degrees between 0 and 359.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AngleInDegreesValue">dtx_srti:AngleInDegreesValue</a>
    /// </summary>
    let AngleInDegreesValue = _prefixId.prefix "AngleInDegreesValue"
    /// <summary>
    ///   <para>rdfs:comment : An obstruction on the road resulting from the presence of animals.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AnimalPresenceObstruction">dtx_srti:AnimalPresenceObstruction</a>
    /// </summary>
    let AnimalPresenceObstruction = _prefixId.prefix "AnimalPresenceObstruction"
    /// <summary>
    ///   <para>rdfs:comment : Types of animal presence.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AnimalPresenceTypeEmum">dtx_srti:AnimalPresenceTypeEmum</a>
    /// </summary>
    let AnimalPresenceTypeEmum = _prefixId.prefix "AnimalPresenceTypeEmum"
    /// <summary>
    ///   <para>rdfs:comment : Location representing a geographic or geometric defined area which may be qualified by height information to provide additional geospatial discrimination (e.g. for snow in an area but only above a certain altitude). Associations:
    /// 0..*	AlertCArea
    /// 0..1	TpegAreaLocation
    /// 0..1	NamedArea
    /// 0..1	GmlMultiPolygon
    /// 0..1	OpenlrAreaLocationReference</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AreaLocation">dtx_srti:AreaLocation</a>
    /// </summary>
    let AreaLocation = _prefixId.prefix "AreaLocation"
    /// <summary>
    ///   <para>rdfs:comment : Type of area place(s)</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AreaPlacesEnum">dtx_srti:AreaPlacesEnum</a>
    /// </summary>
    let AreaPlacesEnum = _prefixId.prefix "AreaPlacesEnum"
    /// <summary>
    ///   <para>rdfs:comment : Supplementary positional information which details carriageway and lane locations. Several instances may exist where the element being described extends over more than one carriageway.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Carriageway">dtx_srti:Carriageway</a>
    /// </summary>
    let Carriageway = _prefixId.prefix "Carriageway"
    /// <summary>
    ///   <para>rdfs:comment : List of descriptors identifying specific carriageway details.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CarriagewayEnum">dtx_srti:CarriagewayEnum</a>
    /// </summary>
    let CarriagewayEnum = _prefixId.prefix "CarriagewayEnum"
    /// <summary>
    ///   <para>rdfs:comment : Types of causes of situations which are not managed or are off network.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CauseTypeEnum">dtx_srti:CauseTypeEnum</a>
    /// </summary>
    let CauseTypeEnum = _prefixId.prefix "CauseTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Common classes</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CommonClasses">dtx_srti:CommonClasses</a>
    /// </summary>
    let CommonClasses = _prefixId.prefix "CommonClasses"
    /// <summary>
    ///   <para>rdfs:comment : Types of computational methods used in deriving data values for data sets.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ComputationMethodEnum">dtx_srti:ComputationMethodEnum</a>
    /// </summary>
    let ComputationMethodEnum = _prefixId.prefix "ComputationMethodEnum"
    /// <summary>
    ///   <para>rdfs:comment : Any conditions which have the potential to degrade normal driving conditions.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Conditions">dtx_srti:Conditions</a>
    /// </summary>
    let Conditions = _prefixId.prefix "Conditions"
    /// <summary>
    ///   <para>rdfs:comment : &lt;&lt;enumeration&gt;&gt; Values of confidentiality.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConfidentialityValueEnum">dtx_srti:ConfidentialityValueEnum</a>
    /// </summary>
    let ConfidentialityValueEnum = _prefixId.prefix "ConfidentialityValueEnum"
    /// <summary>
    ///   <para>rdfs:comment : Types of works relating to construction.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConstructionWorkTypeEnum">dtx_srti:ConstructionWorkTypeEnum</a>
    /// </summary>
    let ConstructionWorkTypeEnum = _prefixId.prefix "ConstructionWorkTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Roadworks involving the construction of new infrastructure.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConstructionWorks">dtx_srti:ConstructionWorks</a>
    /// </summary>
    let ConstructionWorks = _prefixId.prefix "ConstructionWorks"
    /// <summary>
    ///   <para>rdfs:comment : A data value of something that can be measured or calculated. Any provided meta-data values specified in the attributes override any specified generic characteristics such as defined for a specific measurement in the MeasurementSiteTable.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DataValue">dtx_srti:DataValue</a>
    /// </summary>
    let DataValue = _prefixId.prefix "DataValue"
    /// <summary>
    ///   <para>rdfs:comment : The time band within which the additional travel time due to adverse travel conditions of any kind falls, when compared to "normal conditions".</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DelayBandEnum">dtx_srti:DelayBandEnum</a>
    /// </summary>
    let DelayBandEnum = _prefixId.prefix "DelayBandEnum"
    /// <summary>
    ///   <para>rdfs:comment : The details of the delays being caused by the situation element defined in the situation record. It is recommended to only use one of the optional attributes to avoid confusion.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Delays">dtx_srti:Delays</a>
    /// </summary>
    let Delays = _prefixId.prefix "Delays"
    /// <summary>
    ///   <para>rdfs:comment : Coarse classification of the delay.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DelaysTypeEnum">dtx_srti:DelaysTypeEnum</a>
    /// </summary>
    let DelaysTypeEnum = _prefixId.prefix "DelaysTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : List of directions of travel.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DirectionEnum">dtx_srti:DirectionEnum</a>
    /// </summary>
    let DirectionEnum = _prefixId.prefix "DirectionEnum"
    /// <summary>
    ///   <para>rdfs:comment : Main purpose of a direction of a road</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DirectionPurposeEnum">dtx_srti:DirectionPurposeEnum</a>
    /// </summary>
    let DirectionPurposeEnum = _prefixId.prefix "DirectionPurposeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Distance of a point along a linear element either measured from the start node or a defined referent on that linear element, where the start node is relative to the element definition rather than the direction of traffic flow.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceAlongLinearElement">dtx_srti:DistanceAlongLinearElement</a>
    /// </summary>
    let DistanceAlongLinearElement = _prefixId.prefix "DistanceAlongLinearElement"

    /// <summary>
    ///   <para>rdfs:comment : Distance of a point along a linear element measured from a "from referent" on the linear element, in the sense relative to the linear element definition rather than the direction of traffic flow or optionally towards a "towards referent".</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceFromLinearElementReferent">dtx_srti:DistanceFromLinearElementReferent</a>
    /// </summary>
    let DistanceFromLinearElementReferent = _prefixId.prefix "DistanceFromLinearElementReferent"

    /// <summary>
    ///   <para>rdfs:comment : Distance of a point along a linear element measured from the start node of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceFromLinearElementStart">dtx_srti:DistanceFromLinearElementStart</a>
    /// </summary>
    let DistanceFromLinearElementStart = _prefixId.prefix "DistanceFromLinearElementStart"

    /// <summary>
    ///   <para>rdfs:comment : Deliberate human action of either a public disorder nature or of a situation alert type which could disrupt traffic.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DisturbanceActivity">dtx_srti:DisturbanceActivity</a>
    /// </summary>
    let DisturbanceActivity = _prefixId.prefix "DisturbanceActivity"
    /// <summary>
    ///   <para>rdfs:comment : Types of disturbance activities.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DisturbanceActivityTypeEnum">dtx_srti:DisturbanceActivityTypeEnum</a>
    /// </summary>
    let DisturbanceActivityTypeEnum = _prefixId.prefix "DisturbanceActivityTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Types of the perceived driving conditions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DrivingConditionTypeEnum">dtx_srti:DrivingConditionTypeEnum</a>
    /// </summary>
    let DrivingConditionTypeEnum = _prefixId.prefix "DrivingConditionTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Data Dictionary.This clause contains the definitions of all enumerations which are used.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Enums">dtx_srti:Enums</a>
    /// </summary>
    let Enums = _prefixId.prefix "Enums"
    /// <summary>
    ///   <para>rdfs:comment : An obstruction on the road resulting from an environmental cause.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#EnvironmentalObstruction">dtx_srti:EnvironmentalObstruction</a>
    /// </summary>
    let EnvironmentalObstruction = _prefixId.prefix "EnvironmentalObstruction"

    /// <summary>
    ///   <para>rdfs:comment : Types of environmental obstructions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#EnvironmentalObstructionTypeEnum">dtx_srti:EnvironmentalObstructionTypeEnum</a>
    /// </summary>
    let EnvironmentalObstructionTypeEnum = _prefixId.prefix "EnvironmentalObstructionTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : General instruction and/or message that is issued by the network/road operator which is applicable to drivers and sometimes passengers.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralInstructionOrMessageToRoadUsers">dtx_srti:GeneralInstructionOrMessageToRoadUsers</a>
    /// </summary>
    let GeneralInstructionOrMessageToRoadUsers = _prefixId.prefix "GeneralInstructionOrMessageToRoadUsers"

    /// <summary>
    ///   <para>rdfs:comment : General instructions that may be issued to road users (specifically drivers and sometimes passengers) by an operator or operational system in support of network management activities or emergency situations.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralInstructionOrMessageToRoadUsersTypeEnum">dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</a>
    /// </summary>
    let GeneralInstructionOrMessageToRoadUsersTypeEnum = _prefixId.prefix "GeneralInstructionOrMessageToRoadUsersTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Network management action which is applicable to the road network and its users. "trafficManuallyDirectedBy" is only valid if "hasGeneralNetworkManagementTypeEnum" is set to "trafficBeingManuallyDirected".</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralNetworkManagement">dtx_srti:GeneralNetworkManagement</a>
    /// </summary>
    let GeneralNetworkManagement = _prefixId.prefix "GeneralNetworkManagement"

    /// <summary>
    ///   <para>rdfs:comment : Types of network management actions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralNetworkManagementTypeEnum">dtx_srti:GeneralNetworkManagementTypeEnum</a>
    /// </summary>
    let GeneralNetworkManagementTypeEnum = _prefixId.prefix "GeneralNetworkManagementTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Any stationary or moving obstacle of a physical nature, other than of an animal, vehicle, environmental, or damaged equipment nature.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralObstruction">dtx_srti:GeneralObstruction</a>
    /// </summary>
    let GeneralObstruction = _prefixId.prefix "GeneralObstruction"
    /// <summary>
    ///   <para>rdfs:comment : The OGC GeoSPARQL standard supports representing and querying geospatial data on the Semantic Web. GeoSPARQL defines a vocabulary for representing geospatial data in RDF, and it defines an extension to the SPARQL query language for processing geospatial data.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeoSparqlClasses">dtx_srti:GeoSparqlClasses</a>
    /// </summary>
    let GeoSparqlClasses = _prefixId.prefix "GeoSparqlClasses"
    /// <summary>
    ///   <para>rdfs:comment : Geo WGS84 vocabulary</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Geo_WGS84">dtx_srti:Geo_WGS84</a>
    /// </summary>
    let Geo_WGS84 = _prefixId.prefix "Geo_WGS84"
    /// <summary>
    ///   <para>rdfs:comment : Descriptor to help to identify a specific location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeographicCharacteristicEnum">dtx_srti:GeographicCharacteristicEnum</a>
    /// </summary>
    let GeographicCharacteristicEnum = _prefixId.prefix "GeographicCharacteristicEnum"
    /// <summary>
    ///   <para>rdfs:comment : GML location</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Gml">dtx_srti:Gml</a>
    /// </summary>
    let Gml = _prefixId.prefix "Gml"
    /// <summary>
    ///   <para>rdfs:comment : Line string based on GML (EN ISO 19136) definition: a curve defined by a series of two or more coordinate tuples. Unlike GML may be self-intersecting. If srsName attribute is not present, posList is assumed to use "ETRS89-LatLonh" reference system.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlLineString">dtx_srti:GmlLineString</a>
    /// </summary>
    let GmlLineString = _prefixId.prefix "GmlLineString"
    /// <summary>
    ///   <para>rdfs:comment : Closed line string not self-intersecting (i.e. having as last point the first point)</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlLinearRing">dtx_srti:GmlLinearRing</a>
    /// </summary>
    let GmlLinearRing = _prefixId.prefix "GmlLinearRing"
    /// <summary>
    ///   <para>rdfs:comment : An area defined by a set of polygons acording to GML (EN ISO 19136).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlMultiPolygon">dtx_srti:GmlMultiPolygon</a>
    /// </summary>
    let GmlMultiPolygon = _prefixId.prefix "GmlMultiPolygon"
    /// <summary>
    ///   <para>rdfs:comment : Planar surface defined by 1 exterior boundary and 0 or more interior boundaries</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlPolygon">dtx_srti:GmlPolygon</a>
    /// </summary>
    let GmlPolygon = _prefixId.prefix "GmlPolygon"
    /// <summary>
    ///   <para>rdfs:comment : Management information relating to the data contained within a publication.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeaderInformation">dtx_srti:HeaderInformation</a>
    /// </summary>
    let HeaderInformation = _prefixId.prefix "HeaderInformation"
    /// <summary>
    ///   <para>rdfs:comment : Third coordinate for points defined geodetically^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightCoordinate">dtx_srti:HeightCoordinate</a>
    /// </summary>
    let HeightCoordinate = _prefixId.prefix "HeightCoordinate"

    /// <summary>
    ///   <para>rdfs:comment : Third coordinate for points defined geodetically</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightCoordinateAssociationFrom">dtx_srti:HeightCoordinateAssociationFrom</a>
    /// </summary>
    let HeightCoordinateAssociationFrom = _prefixId.prefix "HeightCoordinateAssociationFrom"

    /// <summary>
    ///   <para>rdfs:comment : List of height or vertical gradings of road sections.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightGradeEnum">dtx_srti:HeightGradeEnum</a>
    /// </summary>
    let HeightGradeEnum = _prefixId.prefix "HeightGradeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Coded value for type of height</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightTypeEnum">dtx_srti:HeightTypeEnum</a>
    /// </summary>
    let HeightTypeEnum = _prefixId.prefix "HeightTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Impact">dtx_srti:Impact</a>
    /// </summary>
    let Impact = _prefixId.prefix "Impact"
    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ImportedClasses">dtx_srti:ImportedClasses</a>
    /// </summary>
    let ImportedClasses = _prefixId.prefix "ImportedClasses"

    let InformationDeliveryServicesEnum = _prefixId.prefix "InformationDeliveryServicesEnum"

    /// <summary>
    ///   <para>rdfs:comment : Status of the related information (i.e. real, test or exercise).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InformationStatusEnum">dtx_srti:InformationStatusEnum</a>
    /// </summary>
    let InformationStatusEnum = _prefixId.prefix "InformationStatusEnum"

    /// <summary>
    ///   <para>rdfs:comment : An obstruction on the road caused by one Infrastructure Damage</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDamageObstruction">dtx_srti:InfrastructureDamageObstruction</a>
    /// </summary>
    let InfrastructureDamageObstruction = _prefixId.prefix "InfrastructureDamageObstruction"

    /// <summary>
    ///   <para>rdfs:comment : Types of infrastructure damage which may have an effect on the road network.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDamageTypeEnum">dtx_srti:InfrastructureDamageTypeEnum</a>
    /// </summary>
    let InfrastructureDamageTypeEnum = _prefixId.prefix "InfrastructureDamageTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Descriptor identifying infrastructure to help to identify a specific location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDescriptorEnum">dtx_srti:InfrastructureDescriptorEnum</a>
    /// </summary>
    let InfrastructureDescriptorEnum = _prefixId.prefix "InfrastructureDescriptorEnum"
    /// <summary>
    ///   <para>rdfs:comment : An identifier/name whose range is specific to the particular country.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InternationalIdentifier">dtx_srti:InternationalIdentifier</a>
    /// </summary>
    let InternationalIdentifier = _prefixId.prefix "InternationalIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : Iso named area	The ISO 3166-2 representation for the named area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#IsoNamedArea">dtx_srti:IsoNamedArea</a>
    /// </summary>
    let IsoNamedArea = _prefixId.prefix "IsoNamedArea"
    /// <summary>
    ///   <para>rdfs:comment : Multiple (i.e. more than one) physically separate locations arranged as an ordered set that defines an itinerary or route. In SRTI is not included ItineraryByReference</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Itinerary">dtx_srti:Itinerary</a>
    /// </summary>
    let Itinerary = _prefixId.prefix "Itinerary"
    /// <summary>
    ///   <para>rdfs:comment : Multiple physically separate locations arranged as an ordered set that defines an itinerary or route. The index qualifier indicates the order.
    /// Association: 1..1 Location</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ItineraryByIndexedLocations">dtx_srti:ItineraryByIndexedLocations</a>
    /// </summary>
    let ItineraryByIndexedLocations = _prefixId.prefix "ItineraryByIndexedLocations"
    /// <summary>
    ///   <para>rdfs:comment : Country Representation ontology provides a reference model to support the first two parts of ISO 3166, along with the other coding systems:
    ///  - ISO 3166-1 (Country codes) establishes codes that represent the current names of countries, dependencies, and other areas of particular geopolitical interest, on the basis of lists of country names obtained from the United Nations.
    ///  - ISO 3166-2 (Country subdivision code) establishes a code that represents the names of the principal administrative divisions, or similar areas, of the countries, etc. included in the ISO 3166-1.
    ///  - ISO 3166-3 (Code for formerly used names of countries) establishes a code that represents non-current country names, i.e., the country names deleted from ISO 3166 since its first publication in 1974.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LCC_CountryRepresentation">dtx_srti:LCC_CountryRepresentation</a>
    /// </summary>
    let LCC_CountryRepresentation = _prefixId.prefix "LCC_CountryRepresentation"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a specific lane or group of lanes.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Lane">dtx_srti:Lane</a>
    /// </summary>
    let Lane = _prefixId.prefix "Lane"
    /// <summary>
    ///   <para>rdfs:comment : List of descriptors identifying specific lanes.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LaneEnum">dtx_srti:LaneEnum</a>
    /// </summary>
    let LaneEnum = _prefixId.prefix "LaneEnum"
    /// <summary>
    ///   <para>rdfs:comment : Directions of traffic flow relative to the direction in which the linear element is defined.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearDirectionEnum">dtx_srti:LinearDirectionEnum</a>
    /// </summary>
    let LinearDirectionEnum = _prefixId.prefix "LinearDirectionEnum"
    /// <summary>
    ///   <para>rdfs:comment : A linear element along a single linear object, consistent with EN ISO 19148 definitions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElement">dtx_srti:LinearElement</a>
    /// </summary>
    let LinearElement = _prefixId.prefix "LinearElement"
    /// <summary>
    ///   <para>rdfs:comment : A linear element along a single linear object defined by its identifier or code in a road network reference model (specified in LinearElement class) which segments the road network according to specific business rules.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByCode">dtx_srti:LinearElementByCode</a>
    /// </summary>
    let LinearElementByCode = _prefixId.prefix "LinearElementByCode"
    /// <summary>
    ///   <para>rdfs:comment : A linear element defined by a line string (class GmlLineString).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByLineString">dtx_srti:LinearElementByLineString</a>
    /// </summary>
    let LinearElementByLineString = _prefixId.prefix "LinearElementByLineString"
    /// <summary>
    ///   <para>rdfs:comment : A linear element along a single linear object defined by its start and end points.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByPoints">dtx_srti:LinearElementByPoints</a>
    /// </summary>
    let LinearElementByPoints = _prefixId.prefix "LinearElementByPoints"
    /// <summary>
    ///   <para>rdfs:comment : List of indicative natures of linear elements.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementNatureEnum">dtx_srti:LinearElementNatureEnum</a>
    /// </summary>
    let LinearElementNatureEnum = _prefixId.prefix "LinearElementNatureEnum"
    /// <summary>
    ///   <para>rdfs:comment : Location representing a linear section with optional directionality defined between two points. Any LinearLocation must have an instance of at least one of these classes. If using multiple instances, producers must take care to ensure they represent the same location.
    /// Associations:
    /// 0..1	OpenlrLinear
    /// 0..1	GmlLineString
    /// 0..1	SupplementaryPositionalDescription</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearLocation">dtx_srti:LinearLocation</a>
    /// </summary>
    let LinearLocation = _prefixId.prefix "LinearLocation"
    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes.Package LinearReferencing</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearReferencing">dtx_srti:LinearReferencing</a>
    /// </summary>
    let LinearReferencing = _prefixId.prefix "LinearReferencing"
    /// <summary>
    ///   <para>rdfs:comment : A linear section along a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearWithinLinearElement">dtx_srti:LinearWithinLinearElement</a>
    /// </summary>
    let LinearWithinLinearElement = _prefixId.prefix "LinearWithinLinearElement"
    /// <summary>
    ///   <para>rdfs:label : Location</para>
    ///   <para>rdfs:comment : The specification of a location either on a network (as a point or a linear location) or as an area. This may be provided in one or more referencing systems. Association: 0..1PointCoordinates. In SRTI is not included LocationByReference.</para>
    ///   <para>dcterms:replaces : groupOfLocations</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Location">dtx_srti:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationObjects">dtx_srti:LocationObjects</a>
    /// </summary>
    let LocationObjects = _prefixId.prefix "LocationObjects"
    /// <summary>
    ///   <para>rdfs:comment : Represents one or more physically separate locations. Multiple locations may be related, as in an itinerary or route, or may be unrelated. One LocationReference should not use multiple Location objects to represent the same physical location. In SRTI is not included LocationGroup</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReference">dtx_srti:LocationReference</a>
    /// </summary>
    let LocationReference = _prefixId.prefix "LocationReference"
    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReferencing">dtx_srti:LocationReferencing</a>
    /// </summary>
    let LocationReferencing = _prefixId.prefix "LocationReferencing"

    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReferencingEnumerations">dtx_srti:LocationReferencingEnumerations</a>
    /// </summary>
    let LocationReferencingEnumerations = _prefixId.prefix "LocationReferencingEnumerations"

    /// <summary>
    ///   <para>rdfs:comment : Types of maintenance vehicle actions associated with roadworks.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceVehicleActionsEnum">dtx_srti:MaintenanceVehicleActionsEnum</a>
    /// </summary>
    let MaintenanceVehicleActionsEnum = _prefixId.prefix "MaintenanceVehicleActionsEnum"
    /// <summary>
    ///   <para>rdfs:comment : Details of the maintenance vehicles involved in the roadworks activity.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceVehicles">dtx_srti:MaintenanceVehicles</a>
    /// </summary>
    let MaintenanceVehicles = _prefixId.prefix "MaintenanceVehicles"
    /// <summary>
    ///   <para>rdfs:comment : Roadworks involving the maintenance or installation of infrastructure.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceWorks">dtx_srti:MaintenanceWorks</a>
    /// </summary>
    let MaintenanceWorks = _prefixId.prefix "MaintenanceWorks"
    /// <summary>
    ///   <para>rdfs:comment : A measure of distance defined in metres in a floating point format.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MetresAsFloatValue">dtx_srti:MetresAsFloatValue</a>
    /// </summary>
    let MetresAsFloatValue = _prefixId.prefix "MetresAsFloatValue"

    /// <summary>
    ///   <para>rdfs:comment : A measure of distance defined in metres in a non negative integer format.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MetresAsNonNegativeIntegerValue">dtx_srti:MetresAsNonNegativeIntegerValue</a>
    /// </summary>
    let MetresAsNonNegativeIntegerValue = _prefixId.prefix "MetresAsNonNegativeIntegerValue"

    /// <summary>
    ///   <para>rdfs:comment : An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Mobility">dtx_srti:Mobility</a>
    /// </summary>
    let Mobility = _prefixId.prefix "Mobility"
    /// <summary>
    ///   <para>rdfs:comment : An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MobilityTypeEnum">dtx_srti:MobilityTypeEnum</a>
    /// </summary>
    let MobilityTypeEnum = _prefixId.prefix "MobilityTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : An area defined by a name and/or in terms of known boundaries, such as country or county boundaries or allocated control area of particular authority. The attributes do not form a union; instead, the smallest intersection forms the resulting area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NamedArea">dtx_srti:NamedArea</a>
    /// </summary>
    let NamedArea = _prefixId.prefix "NamedArea"
    /// <summary>
    ///   <para>rdfs:comment : Types of areas.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NamedAreaTypeEnum">dtx_srti:NamedAreaTypeEnum</a>
    /// </summary>
    let NamedAreaTypeEnum = _prefixId.prefix "NamedAreaTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : The specification of a location on a network (as a point or a linear location).Association: 0..1 SupplementaryPositionalDescriptionrdfs:comment : </para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NetworkLocation">dtx_srti:NetworkLocation</a>
    /// </summary>
    let NetworkLocation = _prefixId.prefix "NetworkLocation"
    /// <summary>
    ///   <para>rdfs:comment : Restrictions on road usage, whether by legal order or by operational decisions. It includes road and lane closures, weight and dimensional limits, banned turns, contraflows and alternate traffic operations.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NetworkManagement">dtx_srti:NetworkManagement</a>
    /// </summary>
    let NetworkManagement = _prefixId.prefix "NetworkManagement"
    /// <summary>
    ///   <para>rdfs:comment : Collects the added non-SRTI enumerations. Only for organizational purposes</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Non-SRTI_Enum">dtx_srti:Non-SRTI_Enum</a>
    /// </summary>
    let Non_SRTI_Enum = _prefixId.prefix "Non-SRTI_Enum"

    /// <summary>
    ///   <para>rdfs:comment : Types of road surface conditions which are not related to the weather.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NonWeatherRelatedRoadConditionTypeEnum">dtx_srti:NonWeatherRelatedRoadConditionTypeEnum</a>
    /// </summary>
    let NonWeatherRelatedRoadConditionTypeEnum = _prefixId.prefix "NonWeatherRelatedRoadConditionTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Road surface conditions that are not related to the weather but which may affect driving conditions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NonWeatherRelatedRoadConditions">dtx_srti:NonWeatherRelatedRoadConditions</a>
    /// </summary>
    let NonWeatherRelatedRoadConditions = _prefixId.prefix "NonWeatherRelatedRoadConditions"

    /// <summary>
    ///   <para>rdfs:comment : Types of NUTS codes (Nomenclature of territorial units for statistics) including LAU codes (Local Administrative Units).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NutsCodeTypeEnum">dtx_srti:NutsCodeTypeEnum</a>
    /// </summary>
    let NutsCodeTypeEnum = _prefixId.prefix "NutsCodeTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : The NUTS-Code representation for the named area (Nomenclature of territorial units for statistics) or its LAU code representation (Local Administrative Unit).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NutsNamedArea">dtx_srti:NutsNamedArea</a>
    /// </summary>
    let NutsNamedArea = _prefixId.prefix "NutsNamedArea"
    /// <summary>
    ///   <para>rdfs:comment : Any stationary or moving obstacle of a physical nature (e.g. obstacles or vehicles from an earlier accident, shed loads on carriageway, rock fall, abnormal or dangerous loads, or animals etc.) which could disrupt or endanger traffic.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Obstruction">dtx_srti:Obstruction</a>
    /// </summary>
    let Obstruction = _prefixId.prefix "Obstruction"
    /// <summary>
    ///   <para>rdfs:comment : Types of obstructions on the roadway.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ObstructionTypeEnum">dtx_srti:ObstructionTypeEnum</a>
    /// </summary>
    let ObstructionTypeEnum = _prefixId.prefix "ObstructionTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : The non-negative offset distance from the ALERT-C referenced point to the actual point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OffsetDistance">dtx_srti:OffsetDistance</a>
    /// </summary>
    let OffsetDistance = _prefixId.prefix "OffsetDistance"
    /// <summary>
    ///   <para>rdfs:comment : OpenLR location</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenLR">dtx_srti:OpenLR</a>
    /// </summary>
    let OpenLR = _prefixId.prefix "OpenLR"
    /// <summary>
    ///   <para>rdfs:comment : A two-dimensional part of the surface of the earth which is bounded by a closed curve. An area location may cover parts of the road network but does not necessarily need to. It is represented according to the OpenLR standard for Area Locations</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrAreaLocationReference">dtx_srti:OpenlrAreaLocationReference</a>
    /// </summary>
    let OpenlrAreaLocationReference = _prefixId.prefix "OpenlrAreaLocationReference"
    /// <summary>
    ///   <para>rdfs:comment : Holds common data that are used both in OpenlrPointAccessPoint and OpenlrPointAlongLine.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrBasePointLocation">dtx_srti:OpenlrBasePointLocation</a>
    /// </summary>
    let OpenlrBasePointLocation = _prefixId.prefix "OpenlrBasePointLocation"
    /// <summary>
    ///   <para>rdfs:comment : Base class used to hold data about a reference point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrBaseReferencePoint">dtx_srti:OpenlrBaseReferencePoint</a>
    /// </summary>
    let OpenlrBaseReferencePoint = _prefixId.prefix "OpenlrBaseReferencePoint"
    /// <summary>
    ///   <para>rdfs:comment : The OpenLR method of area definition by providing a center position and a radius</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrCircleLocationReference">dtx_srti:OpenlrCircleLocationReference</a>
    /// </summary>
    let OpenlrCircleLocationReference = _prefixId.prefix "OpenlrCircleLocationReference"

    /// <summary>
    ///   <para>rdfs:comment : The OpenLR method of area definition by providing a closed path (i.e. a circuit) in the road network.
    /// The boundary always consists of road segments</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrClosedLineLocationReference">dtx_srti:OpenlrClosedLineLocationReference</a>
    /// </summary>
    let OpenlrClosedLineLocationReference = _prefixId.prefix "OpenlrClosedLineLocationReference"

    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrEnumerations">dtx_srti:OpenlrEnumerations</a>
    /// </summary>
    let OpenlrEnumerations = _prefixId.prefix "OpenlrEnumerations"
    /// <summary>
    ///   <para>rdfs:comment : Enumeration of form of way</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrFormOfWayEnum">dtx_srti:OpenlrFormOfWayEnum</a>
    /// </summary>
    let OpenlrFormOfWayEnum = _prefixId.prefix "OpenlrFormOfWayEnum"
    /// <summary>
    ///   <para>rdfs:comment : Enumuration of functional road class</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrFunctionalRoadClassEnum">dtx_srti:OpenlrFunctionalRoadClassEnum</a>
    /// </summary>
    let OpenlrFunctionalRoadClassEnum = _prefixId.prefix "OpenlrFunctionalRoadClassEnum"
    /// <summary>
    ///   <para>rdfs:comment : A geo-coordinate pair is a position in a map defined by its longitude and latitude coordinate values.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrGeoCoordinate">dtx_srti:OpenlrGeoCoordinate</a>
    /// </summary>
    let OpenlrGeoCoordinate = _prefixId.prefix "OpenlrGeoCoordinate"
    /// <summary>
    ///   <para>rdfs:comment : Area defined using an OpenLR™ method consisting in defining it by a tessellation of rectangles</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrGridLocationReference">dtx_srti:OpenlrGridLocationReference</a>
    /// </summary>
    let OpenlrGridLocationReference = _prefixId.prefix "OpenlrGridLocationReference"

    /// <summary>
    ///   <para>rdfs:comment : The sequence of location reference points is terminated by a last location reference point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLastLocationReferencePoint">dtx_srti:OpenlrLastLocationReferencePoint</a>
    /// </summary>
    let OpenlrLastLocationReferencePoint = _prefixId.prefix "OpenlrLastLocationReferencePoint"

    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLine">dtx_srti:OpenlrLine</a>
    /// </summary>
    let OpenlrLine = _prefixId.prefix "OpenlrLine"
    /// <summary>
    ///   <para>rdfs:comment : Line attributes are part of a location reference point and consists of functional road class (FRC),form of way (FOW) and bearing (BEAR) data.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLineAttributes">dtx_srti:OpenlrLineAttributes</a>
    /// </summary>
    let OpenlrLineAttributes = _prefixId.prefix "OpenlrLineAttributes"
    /// <summary>
    ///   <para>rdfs:comment : A line location reference is defined by an ordered sequence of location reference points and a terminating last location reference point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLineLocationReference">dtx_srti:OpenlrLineLocationReference</a>
    /// </summary>
    let OpenlrLineLocationReference = _prefixId.prefix "OpenlrLineLocationReference"
    /// <summary>
    ///   <para>rdfs:comment : OpenLR line location reference</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLinear">dtx_srti:OpenlrLinear</a>
    /// </summary>
    let OpenlrLinear = _prefixId.prefix "OpenlrLinear"
    /// <summary>
    ///   <para>rdfs:comment : The basis of a location reference is a sequence of location reference points (LRPs).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLocationReferencePoint">dtx_srti:OpenlrLocationReferencePoint</a>
    /// </summary>
    let OpenlrLocationReferencePoint = _prefixId.prefix "OpenlrLocationReferencePoint"
    /// <summary>
    ///   <para>rdfs:comment : Offsets are used to locate the start and end of a location more precisely than bounding to the nodes in a network.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrOffsets">dtx_srti:OpenlrOffsets</a>
    /// </summary>
    let OpenlrOffsets = _prefixId.prefix "OpenlrOffsets"
    /// <summary>
    ///   <para>rdfs:comment : Enumeration of side of road</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrOrientationEnum">dtx_srti:OpenlrOrientationEnum</a>
    /// </summary>
    let OpenlrOrientationEnum = _prefixId.prefix "OpenlrOrientationEnum"
    /// <summary>
    ///   <para>rdfs:comment : Properties of the path from the associated location reference point to the next location reference point, which are specified to assist correct identification of the point in an external map data source.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPathAttributes">dtx_srti:OpenlrPathAttributes</a>
    /// </summary>
    let OpenlrPathAttributes = _prefixId.prefix "OpenlrPathAttributes"
    /// <summary>
    ///   <para>rdfs:comment : A point of interest (POI) along a line with access is a point location which is defined by a linear reference path, an offset value (defining the access point) from the starting node of this path and a coordinate pair that defines the POI itself.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPoiWithAccessPoint">dtx_srti:OpenlrPoiWithAccessPoint</a>
    /// </summary>
    let OpenlrPoiWithAccessPoint = _prefixId.prefix "OpenlrPoiWithAccessPoint"
    /// <summary>
    ///   <para>rdfs:comment : Point along a line</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPointAlongLine">dtx_srti:OpenlrPointAlongLine</a>
    /// </summary>
    let OpenlrPointAlongLine = _prefixId.prefix "OpenlrPointAlongLine"
    /// <summary>
    ///   <para>rdfs:comment : A point location is a zero-dimensional element in a map that specifies a geometric location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPointLocationReference">dtx_srti:OpenlrPointLocationReference</a>
    /// </summary>
    let OpenlrPointLocationReference = _prefixId.prefix "OpenlrPointLocationReference"
    /// <summary>
    ///   <para>rdfs:comment : A geodetic coordinate Tuple that defines the vertices of the underlying geometrical polygon.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPolygonCorners">dtx_srti:OpenlrPolygonCorners</a>
    /// </summary>
    let OpenlrPolygonCorners = _prefixId.prefix "OpenlrPolygonCorners"

    /// <summary>
    ///   <para>rdfs:comment : The OpenLR method of area definition by providing points that bound the area</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPolygonLocationReference">dtx_srti:OpenlrPolygonLocationReference</a>
    /// </summary>
    let OpenlrPolygonLocationReference = _prefixId.prefix "OpenlrPolygonLocationReference"

    /// <summary>
    ///   <para>rdfs:comment : Area delimited by a rectangle defined by the geodetic co-ordinates of the two ends of its diagonal from south-west to north-east (the rectangle having two sides that are parallel to lines of latitude)</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrRectangle">dtx_srti:OpenlrRectangle</a>
    /// </summary>
    let OpenlrRectangle = _prefixId.prefix "OpenlrRectangle"

    /// <summary>
    ///   <para>rdfs:comment : The openLR method of area definition by providing a rectangular shape defined by two geo-coordinate pairs</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrRectangleLocationReference">dtx_srti:OpenlrRectangleLocationReference</a>
    /// </summary>
    let OpenlrRectangleLocationReference = _prefixId.prefix "OpenlrRectangleLocationReference"

    /// <summary>
    ///   <para>rdfs:comment : Enumeration of side of road</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrSideOfRoadEnum">dtx_srti:OpenlrSideOfRoadEnum</a>
    /// </summary>
    let OpenlrSideOfRoadEnum = _prefixId.prefix "OpenlrSideOfRoadEnum"
    /// <summary>
    ///   <para>rdfs:comment : Actions that a traffic operator can decide to implement to prevent or help correct dangerous or poor driving conditions, including maintenance of the road infrastructure.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OperatorAction">dtx_srti:OperatorAction</a>
    /// </summary>
    let OperatorAction = _prefixId.prefix "OperatorAction"
    /// <summary>
    ///   <para>rdfs:comment : A continuous or discontinuous period of validity defined by overall bounding start and end times and the possible intersection of valid periods (potentially recurring) with the complement of exception periods (also potentially recurring).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OverallPeriod">dtx_srti:OverallPeriod</a>
    /// </summary>
    let OverallPeriod = _prefixId.prefix "OverallPeriod"
    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayLoadEnumerations">dtx_srti:PayLoadEnumerations</a>
    /// </summary>
    let PayLoadEnumerations = _prefixId.prefix "PayLoadEnumerations"
    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes. Package PayloadPublication</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayLoadPublishing">dtx_srti:PayLoadPublishing</a>
    /// </summary>
    let PayLoadPublishing = _prefixId.prefix "PayLoadPublishing"
    /// <summary>
    ///   <para>rdfs:comment : A payload publication of traffic related information or associated management information created at a specific point in time that can be exchanged via a DATEX II interface.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayloadPublication">dtx_srti:PayloadPublication</a>
    /// </summary>
    let PayloadPublication = _prefixId.prefix "PayloadPublication"

    /// <summary>
    ///   <para>rdfs:comment : Distance of a point along a linear element measured from the start node expressed as a percentage of the whole length of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PercentageDistanceAlongLinearElement">dtx_srti:PercentageDistanceAlongLinearElement</a>
    /// </summary>
    let PercentageDistanceAlongLinearElement = _prefixId.prefix "PercentageDistanceAlongLinearElement"

    /// <summary>
    ///   <para>rdfs:comment : Categories of person.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PersonCategoryEnum">dtx_srti:PersonCategoryEnum</a>
    /// </summary>
    let PersonCategoryEnum = _prefixId.prefix "PersonCategoryEnum"
    /// <summary>
    ///   <para>rdfs:comment : A point on a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with EN ISO 19148 definitions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointAlongLinearElement">dtx_srti:PointAlongLinearElement</a>
    /// </summary>
    let PointAlongLinearElement = _prefixId.prefix "PointAlongLinearElement"
    /// <summary>
    ///   <para>rdfs:comment : A single point defined only by a coordinate set with an optional bearing direction.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointByCoordinates">dtx_srti:PointByCoordinates</a>
    /// </summary>
    let PointByCoordinates = _prefixId.prefix "PointByCoordinates"
    /// <summary>
    ///   <para>rdfs:comment : In Datex II definition, a pair of planar coordinates defining the geodetic position of a single point using the European Terrestrial Reference System 1989 (ETRS89).
    ///
    /// Note: At the moment, in Spain it is used the WGS84 and so, the 2 references are possible ( geo/wgs84_pos (lat, long) / geo_core (xETRS89,yETRS89) ).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinates">dtx_srti:PointCoordinates</a>
    /// </summary>
    let PointCoordinates = _prefixId.prefix "PointCoordinates"

    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes.Package PointCoordinates.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinatesAssociationsFrom">dtx_srti:PointCoordinatesAssociationsFrom</a>
    /// </summary>
    let PointCoordinatesAssociationsFrom = _prefixId.prefix "PointCoordinatesAssociationsFrom"

    /// <summary>
    ///   <para>rdfs:comment : A pair of planar coordinates defining the geodetic position of a single point using the European Terrestrial Reference System 1989 (ETRS89).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinatesAssociationsTo">dtx_srti:PointCoordinatesAssociationsTo</a>
    /// </summary>
    let PointCoordinatesAssociationsTo = _prefixId.prefix "PointCoordinatesAssociationsTo"

    /// <summary>
    ///   <para>rdfs:comment : Location representing a single geospatial point.rdfs:comment : At least one of these aggregated classes must be present. If using multiple instances of the agregated classes, producers must take care to ensure they present the same location.
    ///
    /// Associations:
    /// 0..1	PointByCoordinates
    /// 0..*	PointAlongLinearElement
    /// 0..*	AlertCPoint
    /// 0..1	TpegPointLocation
    /// 0..1	OpenlrPointLocationReference</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointLocation">dtx_srti:PointLocation</a>
    /// </summary>
    let PointLocation = _prefixId.prefix "PointLocation"
    /// <summary>
    ///   <para>rdfs:comment : Any environmental conditions which may be affecting the driving conditions on the road.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PoorEnvironmentConditions">dtx_srti:PoorEnvironmentConditions</a>
    /// </summary>
    let PoorEnvironmentConditions = _prefixId.prefix "PoorEnvironmentConditions"
    /// <summary>
    ///   <para>rdfs:comment : Types of poor environmental conditions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PoorEnvironmentTypeEnum">dtx_srti:PoorEnvironmentTypeEnum</a>
    /// </summary>
    let PoorEnvironmentTypeEnum = _prefixId.prefix "PoorEnvironmentTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Horizontal position accuracy parameters defined according to EN 16803-1^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionAccuracy">dtx_srti:PositionAccuracy</a>
    /// </summary>
    let PositionAccuracy = _prefixId.prefix "PositionAccuracy"

    /// <summary>
    ///   <para>rdfs:comment : Error code for horizontal or vertical position confidence</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionConfidenceCodedErrorEnum">dtx_srti:PositionConfidenceCodedErrorEnum</a>
    /// </summary>
    let PositionConfidenceCodedErrorEnum = _prefixId.prefix "PositionConfidenceCodedErrorEnum"

    /// <summary>
    ///   <para>rdfs:comment : Confidence ellipse position defined in a shape of ellipse with a predefined confidence level (e.g. 95 %). The centre of the ellipse shape corresponds to the reference position point for which the position accuracy is evaluated.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionConfidenceEllipse">dtx_srti:PositionConfidenceEllipse</a>
    /// </summary>
    let PositionConfidenceEllipse = _prefixId.prefix "PositionConfidenceEllipse"
    /// <summary>
    ///   <para>rdfs:comment : Levels of confidence that the sender has in the information, ordered {certain, probable, risk of}.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ProbabilityOfOccurrenceEnum">dtx_srti:ProbabilityOfOccurrenceEnum</a>
    /// </summary>
    let ProbabilityOfOccurrenceEnum = _prefixId.prefix "ProbabilityOfOccurrenceEnum"
    /// <summary>
    ///   <para>rdfs:comment : Public event</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PublicEvent">dtx_srti:PublicEvent</a>
    /// </summary>
    let PublicEvent = _prefixId.prefix "PublicEvent"
    /// <summary>
    ///   <para>rdfs:comment : Types of public events.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PublicEventTypeEnum">dtx_srti:PublicEventTypeEnum</a>
    /// </summary>
    let PublicEventTypeEnum = _prefixId.prefix "PublicEventTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : RAMON geographic ontology describes countries, NUTS, and Local Administrative Units (LAU) related concepts and properties</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Ramon_geoClasses">dtx_srti:Ramon_geoClasses</a>
    /// </summary>
    let Ramon_geoClasses = _prefixId.prefix "Ramon_geoClasses"
    /// <summary>
    ///   <para>rdfs:comment : A referent on a linear object that has a known location such as a node, a reference marker (e.g. a marker-post), an intersection etc.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Referent">dtx_srti:Referent</a>
    /// </summary>
    let Referent = _prefixId.prefix "Referent"
    /// <summary>
    ///   <para>rdfs:comment : A set of types of known points along a linear object such as a road.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReferentTypeEnum">dtx_srti:ReferentTypeEnum</a>
    /// </summary>
    let ReferentTypeEnum = _prefixId.prefix "ReferentTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Identifies a relative position across a carriageway</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RelativePositionOnCarriagewayEnum">dtx_srti:RelativePositionOnCarriagewayEnum</a>
    /// </summary>
    let RelativePositionOnCarriagewayEnum = _prefixId.prefix "RelativePositionOnCarriagewayEnum"

    /// <summary>
    ///   <para>rdfs:comment : Assessment of the traffic flow conditions relative to normally expected conditions at this date/time.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RelativeTrafficFlowEnum">dtx_srti:RelativeTrafficFlowEnum</a>
    /// </summary>
    let RelativeTrafficFlowEnum = _prefixId.prefix "RelativeTrafficFlowEnum"
    /// <summary>
    ///   <para>rdfs:comment : Rerouting management action that is issued by the network/road operator.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReroutingManagement">dtx_srti:ReroutingManagement</a>
    /// </summary>
    let ReroutingManagement = _prefixId.prefix "ReroutingManagement"
    /// <summary>
    ///   <para>rdfs:comment : Management actions relating to rerouting.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReroutingManagementTypeEnum">dtx_srti:ReroutingManagementTypeEnum</a>
    /// </summary>
    let ReroutingManagementTypeEnum = _prefixId.prefix "ReroutingManagementTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Information on a road</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadInformation">dtx_srti:RoadInformation</a>
    /// </summary>
    let RoadInformation = _prefixId.prefix "RoadInformation"
    /// <summary>
    ///   <para>rdfs:comment : Types of road maintenance.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadMaintenanceTypeEnum">dtx_srti:RoadMaintenanceTypeEnum</a>
    /// </summary>
    let RoadMaintenanceTypeEnum = _prefixId.prefix "RoadMaintenanceTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Road, carriageway or lane management action that is instigated by the network/road operator.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadOrCarriagewayOrLaneManagement">dtx_srti:RoadOrCarriagewayOrLaneManagement</a>
    /// </summary>
    let RoadOrCarriagewayOrLaneManagement = _prefixId.prefix "RoadOrCarriagewayOrLaneManagement"

    /// <summary>
    ///   <para>rdfs:comment : Management actions relating to road, carriageway or lane usage.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadOrCarriagewayOrLaneManagementTypeEnum">dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</a>
    /// </summary>
    let RoadOrCarriagewayOrLaneManagementTypeEnum = _prefixId.prefix "RoadOrCarriagewayOrLaneManagementTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Conditions of the road surface which may affect driving conditions. These may be related to the weather (e.g. ice, snow etc.) or to other conditions (e.g. oil, mud, leaves etc. on the road)</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadSurfaceConditions">dtx_srti:RoadSurfaceConditions</a>
    /// </summary>
    let RoadSurfaceConditions = _prefixId.prefix "RoadSurfaceConditions"
    /// <summary>
    ///   <para>rdfs:comment : Highway maintenance, installation and construction activities that may potentially affect traffic operations.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadWorks">dtx_srti:RoadWorks</a>
    /// </summary>
    let RoadWorks = _prefixId.prefix "RoadWorks"
    /// <summary>
    ///   <para>rdfs:comment : Details of road side assistance required or being given.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadsideAssistance">dtx_srti:RoadsideAssistance</a>
    /// </summary>
    let RoadsideAssistance = _prefixId.prefix "RoadsideAssistance"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the nature of the road side assistance that will be, is or has been provided.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadsideAssistanceTypeEnum">dtx_srti:RoadsideAssistanceTypeEnum</a>
    /// </summary>
    let RoadsideAssistanceTypeEnum = _prefixId.prefix "RoadsideAssistanceTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Expected durations of roadworks in general terms.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadworksDurationEnum">dtx_srti:RoadworksDurationEnum</a>
    /// </summary>
    let RoadworksDurationEnum = _prefixId.prefix "RoadworksDurationEnum"
    /// <summary>
    ///   <para>rdfs:comment : Grade of complexity of the roadworks according to the responsible road operator. For example determined by size, duration and/or traffic disruption.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadworksScaleEnum">dtx_srti:RoadworksScaleEnum</a>
    /// </summary>
    let RoadworksScaleEnum = _prefixId.prefix "RoadworksScaleEnum"
    /// <summary>
    ///   <para>rdfs:comment : Levels of severity of a situation as whole assessed by the impact that the situation may have on traffic flow as perceived by the supplier.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SeverityEnum">dtx_srti:SeverityEnum</a>
    /// </summary>
    let SeverityEnum = _prefixId.prefix "SeverityEnum"
    /// <summary>
    ///   <para>rdfs:comment : Location representing a linear section along a single road with optional directionality defined between two points on the same road. No matter the kind of linear reference it uses, the constraint of using only a single road must be preserved. Associations:
    /// 0..1	TpegLinearLocation
    /// 0..*	AlertCLinear</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SingleRoadLinearLocation">dtx_srti:SingleRoadLinearLocation</a>
    /// </summary>
    let SingleRoadLinearLocation = _prefixId.prefix "SingleRoadLinearLocation"
    /// <summary>
    ///   <para>rdfs:comment : An identifiable instance of a traffic/travel situation comprising one or more traffic/travel circumstances which are linked by one or more causal relationships. Each traffic/travel circumstance is represented by a Situation Record.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Situation">dtx_srti:Situation</a>
    /// </summary>
    let Situation = _prefixId.prefix "Situation"
    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationEnumerations">dtx_srti:SituationEnumerations</a>
    /// </summary>
    let SituationEnumerations = _prefixId.prefix "SituationEnumerations"
    /// <summary>
    ///   <para>rdfs:comment : A publication containing zero or more traffic/travel situations.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationPublication">dtx_srti:SituationPublication</a>
    /// </summary>
    let SituationPublication = _prefixId.prefix "SituationPublication"
    /// <summary>
    ///   <para>rdfs:comment : Any situation record. An identifiable versioned instance of a single record/element within a situation.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationRecord">dtx_srti:SituationRecord</a>
    /// </summary>
    let SituationRecord = _prefixId.prefix "SituationRecord"
    /// <summary>
    ///   <para>rdfs:comment : Skos Vocabulary</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SkosClasses">dtx_srti:SkosClasses</a>
    /// </summary>
    let SkosClasses = _prefixId.prefix "SkosClasses"
    /// <summary>
    ///   <para>rdfs:comment : Details of the source from which the information was obtained.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Source">dtx_srti:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    /// <summary>
    ///   <para>rdfs:comment : Information about the technology used for measuring the data or the method used for obtaining qualitative descriptions relating to this version of the information.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SourceTypeEnum">dtx_srti:SourceTypeEnum</a>
    /// </summary>
    let SourceTypeEnum = _prefixId.prefix "SourceTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Speed management action that is instigated by the network/road operator.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedManagement">dtx_srti:SpeedManagement</a>
    /// </summary>
    let SpeedManagement = _prefixId.prefix "SpeedManagement"
    /// <summary>
    ///   <para>rdfs:comment : Management actions relating to speed.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedManagementTypeEnum">dtx_srti:SpeedManagementTypeEnum</a>
    /// </summary>
    let SpeedManagementTypeEnum = _prefixId.prefix "SpeedManagementTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of speed.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedValue">dtx_srti:SpeedValue</a>
    /// </summary>
    let SpeedValue = _prefixId.prefix "SpeedValue"
    /// <summary>
    ///   <para>rdfs:comment : ISO 3166-2 subdivison types.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SubdivisionTypeEnum">dtx_srti:SubdivisionTypeEnum</a>
    /// </summary>
    let SubdivisionTypeEnum = _prefixId.prefix "SubdivisionTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : The subjects with which the roadworks are associated.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SubjectTypeOfWorksEnum">dtx_srti:SubjectTypeOfWorksEnum</a>
    /// </summary>
    let SubjectTypeOfWorksEnum = _prefixId.prefix "SubjectTypeOfWorksEnum"
    /// <summary>
    ///   <para>rdfs:comment : The subjects with which the roadworks are associated.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Subjects">dtx_srti:Subjects</a>
    /// </summary>
    let Subjects = _prefixId.prefix "Subjects"

    /// <summary>
    ///   <para>rdfs:comment : A collection of supplementary positional information which improves the precision of the location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SupplementaryPositionalDescription">dtx_srti:SupplementaryPositionalDescription</a>
    /// </summary>
    let SupplementaryPositionalDescription = _prefixId.prefix "SupplementaryPositionalDescription"

    /// <summary>
    ///   <para>rdfs:comment : Supplementary positional information</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SupplementaryPositionalPack">dtx_srti:SupplementaryPositionalPack</a>
    /// </summary>
    let SupplementaryPositionalPack = _prefixId.prefix "SupplementaryPositionalPack"

    /// <summary>
    ///   <para>rdfs:comment : Types of linear location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TPEGLoc01LinearLocationSubtypeEnum">dtx_srti:TPEGLoc01LinearLocationSubtypeEnum</a>
    /// </summary>
    let TPEGLoc01LinearLocationSubtypeEnum = _prefixId.prefix "TPEGLoc01LinearLocationSubtypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : OWL-Time is an ontology of temporal concepts, for describing the temporal properties of resources. The vocabulary provided expresses facts about relations among instants and intervals, as well as durations. Time positions and durations may be expressed using either the conventional (Gregorian) calendar and clock, or using another temporal reference system such as Unix-time, geologic time, or different calendars.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TimeClasses">dtx_srti:TimeClasses</a>
    /// </summary>
    let TimeClasses = _prefixId.prefix "TimeClasses"
    /// <summary>
    ///   <para>rdfs:comment : A descriptor for describing an area location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegAreaDescriptor">dtx_srti:TpegAreaDescriptor</a>
    /// </summary>
    let TpegAreaDescriptor = _prefixId.prefix "TpegAreaDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A geographic or geometric area defined by a TPEG-Loc structure which may include height information for additional geospatial discrimination</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegAreaLocation">dtx_srti:TpegAreaLocation</a>
    /// </summary>
    let TpegAreaLocation = _prefixId.prefix "TpegAreaLocation"
    /// <summary>
    ///   <para>rdfs:comment : A collection of information providing descriptive references to locations using the TPEG-Loc location referencing approach.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegDescriptor">dtx_srti:TpegDescriptor</a>
    /// </summary>
    let TpegDescriptor = _prefixId.prefix "TpegDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegEnumerations">dtx_srti:TpegEnumerations</a>
    /// </summary>
    let TpegEnumerations = _prefixId.prefix "TpegEnumerations"
    /// <summary>
    ///   <para>rdfs:comment : A point on the road network which is framed between two other points on the same road.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegFramedPoint">dtx_srti:TpegFramedPoint</a>
    /// </summary>
    let TpegFramedPoint = _prefixId.prefix "TpegFramedPoint"
    /// <summary>
    ///   <para>rdfs:comment : A geometric area defined by a centre point and a radius.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegGeometricArea">dtx_srti:TpegGeometricArea</a>
    /// </summary>
    let TpegGeometricArea = _prefixId.prefix "TpegGeometricArea"
    /// <summary>
    ///   <para>rdfs:comment : Height information which provides additional discrimination for the applicable area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegHeight">dtx_srti:TpegHeight</a>
    /// </summary>
    let TpegHeight = _prefixId.prefix "TpegHeight"
    /// <summary>
    ///   <para>rdfs:comment : A descriptor for describing a junction by defining the intersecting roads.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegIlcPointDescriptor">dtx_srti:TpegIlcPointDescriptor</a>
    /// </summary>
    let TpegIlcPointDescriptor = _prefixId.prefix "TpegIlcPointDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A point on the road network which is a road junction point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegJunction">dtx_srti:TpegJunction</a>
    /// </summary>
    let TpegJunction = _prefixId.prefix "TpegJunction"
    /// <summary>
    ///   <para>rdfs:comment : A descriptor for describing a point at a junction on a road network.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegJunctionPointDescriptor">dtx_srti:TpegJunctionPointDescriptor</a>
    /// </summary>
    let TpegJunctionPointDescriptor = _prefixId.prefix "TpegJunctionPointDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A linear section along a single road defined between two points on the same road by a TPEG-Loc structure.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLinearLocation">dtx_srti:TpegLinearLocation</a>
    /// </summary>
    let TpegLinearLocation = _prefixId.prefix "TpegLinearLocation"
    /// <summary>
    ///   <para>rdfs:comment : Tpeg location</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc">dtx_srti:TpegLoc</a>
    /// </summary>
    let TpegLoc = _prefixId.prefix "TpegLoc"

    /// <summary>
    ///   <para>rdfs:comment : Types of area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01AreaLocationSubtypeEnum">dtx_srti:TpegLoc01AreaLocationSubtypeEnum</a>
    /// </summary>
    let TpegLoc01AreaLocationSubtypeEnum = _prefixId.prefix "TpegLoc01AreaLocationSubtypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Types of points on the road network framed by two other points on the same road.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01FramedPointLocationSubtypeEnum">dtx_srti:TpegLoc01FramedPointLocationSubtypeEnum</a>
    /// </summary>
    let TpegLoc01FramedPointLocationSubtypeEnum = _prefixId.prefix "TpegLoc01FramedPointLocationSubtypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Types of simple point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01SimplePointLocationSubtypeEnum">dtx_srti:TpegLoc01SimplePointLocationSubtypeEnum</a>
    /// </summary>
    let TpegLoc01SimplePointLocationSubtypeEnum = _prefixId.prefix "TpegLoc01SimplePointLocationSubtypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Descriptors for describing area locations.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03AreaDescriptorSubtypeEnum">dtx_srti:TpegLoc03AreaDescriptorSubtypeEnum</a>
    /// </summary>
    let TpegLoc03AreaDescriptorSubtypeEnum = _prefixId.prefix "TpegLoc03AreaDescriptorSubtypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Descriptors for describing a junction by identifying the intersecting roads at a road junction.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03IlcPointDescriptorSubtypeEnum">dtx_srti:TpegLoc03IlcPointDescriptorSubtypeEnum</a>
    /// </summary>
    let TpegLoc03IlcPointDescriptorSubtypeEnum = _prefixId.prefix "TpegLoc03IlcPointDescriptorSubtypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Descriptors for describing a point at a road junction.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03JunctionPointDescriptorSubtypeEnum">dtx_srti:TpegLoc03JunctionPointDescriptorSubtypeEnum</a>
    /// </summary>
    let TpegLoc03JunctionPointDescriptorSubtypeEnum = _prefixId.prefix "TpegLoc03JunctionPointDescriptorSubtypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Descriptors other than junction names and road descriptors which can help to identify the location of points on the road network.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03OtherPointDescriptorSubtypeEnum">dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</a>
    /// </summary>
    let TpegLoc03OtherPointDescriptorSubtypeEnum = _prefixId.prefix "TpegLoc03OtherPointDescriptorSubtypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Types of height.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc04HeightTypeEnum">dtx_srti:TpegLoc04HeightTypeEnum</a>
    /// </summary>
    let TpegLoc04HeightTypeEnum = _prefixId.prefix "TpegLoc04HeightTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : An area defined by a well-known name.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegNamedOnlyArea">dtx_srti:TpegNamedOnlyArea</a>
    /// </summary>
    let TpegNamedOnlyArea = _prefixId.prefix "TpegNamedOnlyArea"
    /// <summary>
    ///   <para>rdfs:comment : A point on the road network which is not a road junction point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegNonJunctionPoint">dtx_srti:TpegNonJunctionPoint</a>
    /// </summary>
    let TpegNonJunctionPoint = _prefixId.prefix "TpegNonJunctionPoint"
    /// <summary>
    ///   <para>rdfs:comment : General descriptor for describing a point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegOtherPointDescriptor">dtx_srti:TpegOtherPointDescriptor</a>
    /// </summary>
    let TpegOtherPointDescriptor = _prefixId.prefix "TpegOtherPointDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A point on the road network which is either a junction point or a non junction point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPoint">dtx_srti:TpegPoint</a>
    /// </summary>
    let TpegPoint = _prefixId.prefix "TpegPoint"
    /// <summary>
    ///   <para>rdfs:comment : A descriptor for describing a point location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPointDescriptor">dtx_srti:TpegPointDescriptor</a>
    /// </summary>
    let TpegPointDescriptor = _prefixId.prefix "TpegPointDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A single point on the road network defined by a TPEG-Loc structure and which has an associated direction of traffic flow.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPointLocation">dtx_srti:TpegPointLocation</a>
    /// </summary>
    let TpegPointLocation = _prefixId.prefix "TpegPointLocation"
    /// <summary>
    ///   <para>rdfs:comment : A point on the road network which is not bounded by any other points on the road network.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegSimplePoint">dtx_srti:TpegSimplePoint</a>
    /// </summary>
    let TpegSimplePoint = _prefixId.prefix "TpegSimplePoint"
    /// <summary>
    ///   <para>rdfs:comment : Types of constriction to which traffic is subjected as a result of an event.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficConstrictionTypeEnum">dtx_srti:TrafficConstrictionTypeEnum</a>
    /// </summary>
    let TrafficConstrictionTypeEnum = _prefixId.prefix "TrafficConstrictionTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Traffic element.rdfs:comment : An event which is not planned by the traffic operator, which is affecting, or has the potential to affect traffic flow.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficElement">dtx_srti:TrafficElement</a>
    /// </summary>
    let TrafficElement = _prefixId.prefix "TrafficElement"
    /// <summary>
    ///   <para>rdfs:comment : The consistency (steadiness) of the traffic flow.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficFlowCharateristicsEnum">dtx_srti:TrafficFlowCharateristicsEnum</a>
    /// </summary>
    let TrafficFlowCharateristicsEnum = _prefixId.prefix "TrafficFlowCharateristicsEnum"
    /// <summary>
    ///   <para>rdfs:comment : A characterization of the trend in the traffic conditions at the specified location and direction.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficTrendTypeEnum">dtx_srti:TrafficTrendTypeEnum</a>
    /// </summary>
    let TrafficTrendTypeEnum = _prefixId.prefix "TrafficTrendTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Types of public transport information.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TransitServiceInformationEnum">dtx_srti:TransitServiceInformationEnum</a>
    /// </summary>
    let TransitServiceInformationEnum = _prefixId.prefix "TransitServiceInformationEnum"
    /// <summary>
    ///   <para>rdfs:comment : Specification of validity, either explicitly or by a validity time period specification which may be discontinuous.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Validity">dtx_srti:Validity</a>
    /// </summary>
    let Validity = _prefixId.prefix "Validity"
    /// <summary>
    ///   <para>rdfs:comment : Values of validity status that can be assigned to a described event, action or item</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ValidityStatusEnum">dtx_srti:ValidityStatusEnum</a>
    /// </summary>
    let ValidityStatusEnum = _prefixId.prefix "ValidityStatusEnum"
    /// <summary>
    ///   <para>rdfs:comment : Details of an individual vehicle.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Vehicle">dtx_srti:Vehicle</a>
    /// </summary>
    let Vehicle = _prefixId.prefix "Vehicle"
    /// <summary>
    ///   <para>rdfs:comment : The characteristics of a vehicle, e.g. lorry of gross weight greater than 30 tonnes.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleCharacteristics">dtx_srti:VehicleCharacteristics</a>
    /// </summary>
    let VehicleCharacteristics = _prefixId.prefix "VehicleCharacteristics"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of the flow rate of vehicles.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleFlowValue">dtx_srti:VehicleFlowValue</a>
    /// </summary>
    let VehicleFlowValue = _prefixId.prefix "VehicleFlowValue"
    /// <summary>
    ///   <para>rdfs:comment : An obstruction on the road caused by one or more vehicles.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleObstruction">dtx_srti:VehicleObstruction</a>
    /// </summary>
    let VehicleObstruction = _prefixId.prefix "VehicleObstruction"
    /// <summary>
    ///   <para>rdfs:comment : Types of obstructions involving vehicles.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleObstructionTypeEnum">dtx_srti:VehicleObstructionTypeEnum</a>
    /// </summary>
    let VehicleObstructionTypeEnum = _prefixId.prefix "VehicleObstructionTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : The status of a vehicle.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleStatusEnum">dtx_srti:VehicleStatusEnum</a>
    /// </summary>
    let VehicleStatusEnum = _prefixId.prefix "VehicleStatusEnum"
    /// <summary>
    ///   <para>rdfs:comment : Types of vehicle.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleTypeEnum">dtx_srti:VehicleTypeEnum</a>
    /// </summary>
    let VehicleTypeEnum = _prefixId.prefix "VehicleTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Types of road surface conditions which are related to the weather.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WeatherRelatedRoadConditionType">dtx_srti:WeatherRelatedRoadConditionType</a>
    /// </summary>
    let WeatherRelatedRoadConditionType = _prefixId.prefix "WeatherRelatedRoadConditionType"

    /// <summary>
    ///   <para>rdfs:comment : Road surface conditions that are related to the weather which may affect the driving conditions, such as ice, snow or water.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WeatherRelatedRoadConditions">dtx_srti:WeatherRelatedRoadConditions</a>
    /// </summary>
    let WeatherRelatedRoadConditions = _prefixId.prefix "WeatherRelatedRoadConditions"
    /// <summary>
    ///   <para>rdfs:comment : Winter driving management action that is instigated by the network/road operator.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WinterDrivingManagement">dtx_srti:WinterDrivingManagement</a>
    /// </summary>
    let WinterDrivingManagement = _prefixId.prefix "WinterDrivingManagement"

    /// <summary>
    ///   <para>rdfs:comment : Type of winter equipment management action instigated by operator.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WinterEquipmentManagementTypeEnum">dtx_srti:WinterEquipmentManagementTypeEnum</a>
    /// </summary>
    let WinterEquipmentManagementTypeEnum = _prefixId.prefix "WinterEquipmentManagementTypeEnum"

    let abnormalLoad = _prefixId.prefix "abnormalLoad"
    let aboveGrade = _prefixId.prefix "aboveGrade"
    let aboveSeaLevelTPEGHeight = _prefixId.prefix "aboveSeaLevelTPEGHeight"
    let aboveStreetLevelTPEGHeight = _prefixId.prefix "aboveStreetLevelTPEGHeight"
    let aboveTPEGHeight = _prefixId.prefix "aboveTPEGHeight"
    let accident = _prefixId.prefix "accident"
    let accidentCause = _prefixId.prefix "accidentCause"

    let accidentInvolvingHazardousMaterials = _prefixId.prefix "accidentInvolvingHazardousMaterials"

    let accidentInvolvingHeavyLorries = _prefixId.prefix "accidentInvolvingHeavyLorries"

    let accidentInvolvingRadioactiveMaterial = _prefixId.prefix "accidentInvolvingRadioactiveMaterial"

    /// <summary>
    ///   <para>rdfs:comment : The extent to which the value is expected to be free from error, measured as a percentage of the data value. 100% means fully accurate.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracy">dtx_srti:accuracy</a>
    /// </summary>
    let accuracy = _prefixId.prefix "accuracy"
    /// <summary>
    ///   <para>rdfs:comment : Accuracy defined by the 50th percentile of the cumulative distribution of position errors.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile50">dtx_srti:accuracyPercentile50</a>
    /// </summary>
    let accuracyPercentile50 = _prefixId.prefix "accuracyPercentile50"
    /// <summary>
    ///   <para>rdfs:comment : Accuracy defined by the 75th percentile of the cumulative distribution of position errors</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile75">dtx_srti:accuracyPercentile75</a>
    /// </summary>
    let accuracyPercentile75 = _prefixId.prefix "accuracyPercentile75"
    /// <summary>
    ///   <para>rdfs:comment : Accuracy defined by the 95th percentile of the cumulative distribution of position errors</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile95">dtx_srti:accuracyPercentile95</a>
    /// </summary>
    let accuracyPercentile95 = _prefixId.prefix "accuracyPercentile95"
    let active = _prefixId.prefix "active"
    let administrativeAreaName = _prefixId.prefix "administrativeAreaName"
    let administrativeAtoll = _prefixId.prefix "administrativeAtoll"
    let administrativeReferenceName = _prefixId.prefix "administrativeReferenceName"
    let administrativeRegion = _prefixId.prefix "administrativeRegion"
    let administrativeTerritory = _prefixId.prefix "administrativeTerritory"
    let adult = _prefixId.prefix "adult"
    let againstLineDirection = _prefixId.prefix "againstLineDirection"
    let agriculturalShow = _prefixId.prefix "agriculturalShow"
    let agriculturalVehicle = _prefixId.prefix "agriculturalVehicle"
    let airAmbulance = _prefixId.prefix "airAmbulance"
    let airCrash = _prefixId.prefix "airCrash"
    let airShow = _prefixId.prefix "airShow"
    let airportName = _prefixId.prefix "airportName"
    /// <summary>
    ///   <para>rdfs:comment : ALERT-C name of a direction e.g. Brussels -&gt; Lille.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCDirectionNamed">dtx_srti:alertCDirectionNamed</a>
    /// </summary>
    let alertCDirectionNamed = _prefixId.prefix "alertCDirectionNamed"
    /// <summary>
    ///   <para>rdfs:comment : ALERT-C country code as defined in IEC 62106.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationCountryCode">dtx_srti:alertCLocationCountryCode</a>
    /// </summary>
    let alertCLocationCountryCode = _prefixId.prefix "alertCLocationCountryCode"
    /// <summary>
    ///   <para>rdfs:comment : Name of ALERT-C location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationName">dtx_srti:alertCLocationName</a>
    /// </summary>
    let alertCLocationName = _prefixId.prefix "alertCLocationName"
    /// <summary>
    ///   <para>rdfs:comment : Number allocated to an ALERT-C table in a country. Ref. EN ISO 14819-3 for the allocation of a location table number.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationTableNumber">dtx_srti:alertCLocationTableNumber</a>
    /// </summary>
    let alertCLocationTableNumber = _prefixId.prefix "alertCLocationTableNumber"
    /// <summary>
    ///   <para>rdfs:comment : Version number associated with an ALERT-C table reference.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationTableVersion">dtx_srti:alertCLocationTableVersion</a>
    /// </summary>
    let alertCLocationTableVersion = _prefixId.prefix "alertCLocationTableVersion"
    let aligned = _prefixId.prefix "aligned"
    let allDirections = _prefixId.prefix "allDirections"
    let allLanesCompleteCarriageway = _prefixId.prefix "allLanesCompleteCarriageway"
    let allowEmergencyVehiclesToPass = _prefixId.prefix "allowEmergencyVehiclesToPass"
    /// <summary>
    ///   <para>rdfs:comment : The allowed delivery channel.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allowedDeliveryChannel">dtx_srti:allowedDeliveryChannel</a>
    /// </summary>
    let allowedDeliveryChannel = _prefixId.prefix "allowedDeliveryChannel"
    let animalsOnTheRoad = _prefixId.prefix "animalsOnTheRoad"
    let anticlockwise = _prefixId.prefix "anticlockwise"
    let anyGeneralDeliveryService = _prefixId.prefix "anyGeneralDeliveryService"
    let anyVehicle = _prefixId.prefix "anyVehicle"
    let applicationRegion = _prefixId.prefix "applicationRegion"
    let approachWithCare = _prefixId.prefix "approachWithCare"
    let arcticRegion = _prefixId.prefix "arcticRegion"
    let areaName = _prefixId.prefix "areaName"
    /// <summary>
    ///   <para>rdfs:comment : The name of the area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#areaNameProperty">dtx_srti:areaNameProperty</a>
    /// </summary>
    let areaNameProperty = _prefixId.prefix "areaNameProperty"

    let arithmeticAverageOfSamplesBasedOnAFixedNumberOfSamples = _prefixId.prefix "arithmeticAverageOfSamplesBasedOnAFixedNumberOfSamples"

    let arithmeticAverageOfSamplesInATimePeriod = _prefixId.prefix "arithmeticAverageOfSamplesInATimePeriod"

    let aroundABendInRoad = _prefixId.prefix "aroundABendInRoad"
    let articulatedVehicle = _prefixId.prefix "articulatedVehicle"
    let atBorders = _prefixId.prefix "atBorders"
    let atGrade = _prefixId.prefix "atGrade"
    let atHighAltitudes = _prefixId.prefix "atHighAltitudes"
    let atMotorwayInterchange = _prefixId.prefix "atMotorwayInterchange"
    let atRestArea = _prefixId.prefix "atRestArea"
    let atSeaLevelTPEGHeight = _prefixId.prefix "atSeaLevelTPEGHeight"
    let atServiceArea = _prefixId.prefix "atServiceArea"
    let atStreetLevelTPEGHeight = _prefixId.prefix "atStreetLevelTPEGHeight"
    let atTPEGHeight = _prefixId.prefix "atTPEGHeight"
    let atTollPlaza = _prefixId.prefix "atTollPlaza"
    let atTunnelEntryOrExit = _prefixId.prefix "atTunnelEntryOrExit"
    let athleticsMeeting = _prefixId.prefix "athleticsMeeting"
    let automobileClubPatrol = _prefixId.prefix "automobileClubPatrol"
    let autonomousCity = _prefixId.prefix "autonomousCity"
    let autonomousCityInNorthAfrica = _prefixId.prefix "autonomousCityInNorthAfrica"
    let autonomousCommunity = _prefixId.prefix "autonomousCommunity"
    let autonomousDistrict = _prefixId.prefix "autonomousDistrict"
    let autonomousProvince = _prefixId.prefix "autonomousProvince"
    let autonomousRegion = _prefixId.prefix "autonomousRegion"
    let avalanches = _prefixId.prefix "avalanches"
    let avoidTheArea = _prefixId.prefix "avoidTheArea"
    let avoidanceOfObstacles = _prefixId.prefix "avoidanceOfObstacles"
    let badWeather = _prefixId.prefix "badWeather"
    let ballGame = _prefixId.prefix "ballGame"
    let baseballGame = _prefixId.prefix "baseballGame"
    let basketballGame = _prefixId.prefix "basketballGame"
    /// <summary>
    ///   <para>rdfs:comment : Accuracy defined by the 95th percentile of the cumulative distribution of position errors</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bearing">dtx_srti:bearing</a>
    /// </summary>
    let bearing = _prefixId.prefix "bearing"
    let belowGrade = _prefixId.prefix "belowGrade"
    let belowSeaLevelTPEGHeight = _prefixId.prefix "belowSeaLevelTPEGHeight"
    let belowStreetLevelTPEGHeight = _prefixId.prefix "belowStreetLevelTPEGHeight"
    let belowTPEGHeight = _prefixId.prefix "belowTPEGHeight"
    let betweenOneHourAndThreeHours = _prefixId.prefix "betweenOneHourAndThreeHours"

    let betweenTenMinutesAndThirtyMinutes = _prefixId.prefix "betweenTenMinutesAndThirtyMinutes"

    let betweenThirtyMinutesAndOneHour = _prefixId.prefix "betweenThirtyMinutesAndOneHour"

    let betweenThreeHoursAndSixHours = _prefixId.prefix "betweenThreeHoursAndSixHours"
    let bicycle = _prefixId.prefix "bicycle"
    let bicycleRace = _prefixId.prefix "bicycleRace"
    let blackIce = _prefixId.prefix "blackIce"
    let blastingWork = _prefixId.prefix "blastingWork"
    let blowingDust = _prefixId.prefix "blowingDust"
    let blowingSnow = _prefixId.prefix "blowingSnow"
    let boatRace = _prefixId.prefix "boatRace"
    let boatShow = _prefixId.prefix "boatShow"
    let both = _prefixId.prefix "both"
    let bothDirections = _prefixId.prefix "bothDirections"
    let bothSides = _prefixId.prefix "bothSides"
    let bothWays = _prefixId.prefix "bothWays"
    let boundary = _prefixId.prefix "boundary"
    let boxingTournament = _prefixId.prefix "boxingTournament"
    let bridge = _prefixId.prefix "bridge"
    let bridgeSwingInOperation = _prefixId.prefix "bridgeSwingInOperation"
    let brokenDown = _prefixId.prefix "brokenDown"
    let brokenDownHeavyLorry = _prefixId.prefix "brokenDownHeavyLorry"
    let brokenDownVehicle = _prefixId.prefix "brokenDownVehicle"
    let buildingName = _prefixId.prefix "buildingName"
    let bullFight = _prefixId.prefix "bullFight"
    let buriedCables = _prefixId.prefix "buriedCables"
    let buriedServices = _prefixId.prefix "buriedServices"
    let burntOut = _prefixId.prefix "burntOut"
    let burstPipe = _prefixId.prefix "burstPipe"
    let burstWaterMain = _prefixId.prefix "burstWaterMain"
    let bus = _prefixId.prefix "bus"
    let busLane = _prefixId.prefix "busLane"
    let busPassengerAssistance = _prefixId.prefix "busPassengerAssistance"
    let busStop = _prefixId.prefix "busStop"
    let busStopIdentifier = _prefixId.prefix "busStopIdentifier"
    let busStopName = _prefixId.prefix "busStopName"
    let cameraObservation = _prefixId.prefix "cameraObservation"
    let canalName = _prefixId.prefix "canalName"
    let canton = _prefixId.prefix "canton"
    /// <summary>
    ///   <para>rdfs:comment : The ratio of current capacity to the normal (free flow) road capacity in the defined direction, expressed as a percentage. Capacity is the maximum number of vehicles that can pass a specified point on the road, in unit time given the specified conditions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#capacityRemaining">dtx_srti:capacityRemaining</a>
    /// </summary>
    let capacityRemaining = _prefixId.prefix "capacityRemaining"
    let capitalCity = _prefixId.prefix "capitalCity"
    let car = _prefixId.prefix "car"
    let carOrLightVehicle = _prefixId.prefix "carOrLightVehicle"
    let carParkArea = _prefixId.prefix "carParkArea"
    let carPoolLane = _prefixId.prefix "carPoolLane"
    let carPoolLaneInOperation = _prefixId.prefix "carPoolLaneInOperation"
    let carWithCaravan = _prefixId.prefix "carWithCaravan"
    let carWithTrailer = _prefixId.prefix "carWithTrailer"
    let caravan = _prefixId.prefix "caravan"
    let carpoolArea = _prefixId.prefix "carpoolArea"
    let carriagewayBlocked = _prefixId.prefix "carriagewayBlocked"
    let carriagewayClosures = _prefixId.prefix "carriagewayClosures"

    let carriagewayPartiallyObstructed = _prefixId.prefix "carriagewayPartiallyObstructed"

    let centralReservation = _prefixId.prefix "centralReservation"
    let ceremonialEvent = _prefixId.prefix "ceremonialEvent"
    let certain = _prefixId.prefix "certain"
    let child = _prefixId.prefix "child"
    let childrenOnRoadway = _prefixId.prefix "childrenOnRoadway"
    let city = _prefixId.prefix "city"
    let cityMunicipality = _prefixId.prefix "cityMunicipality"
    let cityOfCountyRight = _prefixId.prefix "cityOfCountyRight"

    let clearALaneForEmergencyVehicles = _prefixId.prefix "clearALaneForEmergencyVehicles"

    let clearALaneForSnowploughsAndGrittingVehicles = _prefixId.prefix "clearALaneForSnowploughsAndGrittingVehicles"

    let clearanceWork = _prefixId.prefix "clearanceWork"
    let clockwise = _prefixId.prefix "clockwise"

    let closeAllWindowsTurnOffHeaterAndVents = _prefixId.prefix "closeAllWindowsTurnOffHeaterAndVents"

    let closedPermanentlyForTheWinter = _prefixId.prefix "closedPermanentlyForTheWinter"
    let collapsedSewer = _prefixId.prefix "collapsedSewer"
    let collision = _prefixId.prefix "collision"
    let commercialEvent = _prefixId.prefix "commercialEvent"
    let commune = _prefixId.prefix "commune"
    let concert = _prefixId.prefix "concert"
    /// <summary>
    ///   <para>rdfs:comment : The extent to which the related information may be circulated, according to the recipient type. Recipients must comply with this confidentiality statement. This overrides any confidentiality defined for the situation as a whole in the header information.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#confidentialityOverride">dtx_srti:confidentialityOverride</a>
    /// </summary>
    let confidentialityOverride = _prefixId.prefix "confidentialityOverride"
    let congestion = _prefixId.prefix "congestion"
    let connectingCarriageway = _prefixId.prefix "connectingCarriageway"

    let constructionOrMaintenanceVehicle = _prefixId.prefix "constructionOrMaintenanceVehicle"

    let constructionWork = _prefixId.prefix "constructionWork"
    let continent = _prefixId.prefix "continent"
    let contraflow = _prefixId.prefix "contraflow"
    let convoy = _prefixId.prefix "convoy"
    let convoyService = _prefixId.prefix "convoyService"
    let councilArea = _prefixId.prefix "councilArea"
    /// <summary>
    ///   <para>rdfs:comment : EN ISO 3166-1 two-character country code.rdfs:comment : Country</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#country">dtx_srti:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    let countryGroup = _prefixId.prefix "countryGroup"
    let county = _prefixId.prefix "county"
    let countyName = _prefixId.prefix "countyName"
    let crashBarrier = _prefixId.prefix "crashBarrier"
    let crawlerLane = _prefixId.prefix "crawlerLane"
    let cricketMatch = _prefixId.prefix "cricketMatch"
    let crossJunctionWithCare = _prefixId.prefix "crossJunctionWithCare"
    let crosswinds = _prefixId.prefix "crosswinds"
    let crowd = _prefixId.prefix "crowd"
    let culturalEvent = _prefixId.prefix "culturalEvent"
    let cycleLane = _prefixId.prefix "cycleLane"
    let cycleTrack = _prefixId.prefix "cycleTrack"
    let cyclistsOnRoadway = _prefixId.prefix "cyclistsOnRoadway"
    let damaged = _prefixId.prefix "damaged"
    let damagedAndImmobililized = _prefixId.prefix "damagedAndImmobililized"
    let damagedBridge = _prefixId.prefix "damagedBridge"
    let damagedCrashBarrier = _prefixId.prefix "damagedCrashBarrier"
    let damagedFlyover = _prefixId.prefix "damagedFlyover"
    let damagedGallery = _prefixId.prefix "damagedGallery"
    let damagedGantry = _prefixId.prefix "damagedGantry"
    let damagedRoadSurface = _prefixId.prefix "damagedRoadSurface"
    let damagedTunnel = _prefixId.prefix "damagedTunnel"
    let damagedVehicle = _prefixId.prefix "damagedVehicle"
    let damagedViaduct = _prefixId.prefix "damagedViaduct"
    /// <summary>
    ///   <para>rdfs:comment : Indication of whether the value is deemed to be erroneous by the supplier (true = erroneous). If not present, the data value is assumed to be ok. This may be used when automatic fault detection information relating to sensors is available.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#dataError">dtx_srti:dataError</a>
    /// </summary>
    let dataError = _prefixId.prefix "dataError"
    /// <summary>
    ///   <para>rdfs:comment : The default language used throughout the payload publicationrdfs:comment : Specifies the language by an ISO 639-1 2-alpha code</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#defaultLanguage">dtx_srti:defaultLanguage</a>
    /// </summary>
    let defaultLanguage = _prefixId.prefix "defaultLanguage"
    let definedByValidityTimeSpec = _prefixId.prefix "definedByValidityTimeSpec"
    /// <summary>
    ///   <para>rdfs:comment : The time band within which the additional travel time due to adverse travel conditions of any kind falls, when compared to "normal conditions".</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delayBand">dtx_srti:delayBand</a>
    /// </summary>
    let delayBand = _prefixId.prefix "delayBand"
    /// <summary>
    ///   <para>rdfs:comment : The value of the additional travel time due to adverse travel conditions of any kind, when compared to "normal conditions", given in seconds.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delayTimeValue">dtx_srti:delayTimeValue</a>
    /// </summary>
    let delayTimeValue = _prefixId.prefix "delayTimeValue"
    let delays = _prefixId.prefix "delays"
    let delaysOfUncertainDuration = _prefixId.prefix "delaysOfUncertainDuration"
    /// <summary>
    ///   <para>rdfs:comment : Coarse classification of the delay.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delaysType">dtx_srti:delaysType</a>
    /// </summary>
    let delaysType = _prefixId.prefix "delaysType"
    let demonstration = _prefixId.prefix "demonstration"
    let department = _prefixId.prefix "department"
    let dependency = _prefixId.prefix "dependency"
    /// <summary>
    ///   <para>rdfs:comment : Describes or elaborates the location. Here is used for values from RoadNumber or AdministrativeUnit.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#descriptor">dtx_srti:descriptor</a>
    /// </summary>
    let descriptor = _prefixId.prefix "descriptor"
    /// <summary>
    ///   <para>rdfs:comment : A text string which describes or elaborates the location. Here is used for values distinct to RoadNumbers or AdministrativeUnit.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#descriptorString">dtx_srti:descriptorString</a>
    /// </summary>
    let descriptorString = _prefixId.prefix "descriptorString"
    /// <summary>
    ///   <para>rdfs:comment : The direction of traffic flow at the specified point in terms of general destination direction.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionAtPoint">dtx_srti:directionAtPoint</a>
    /// </summary>
    let directionAtPoint = _prefixId.prefix "directionAtPoint"
    /// <summary>
    ///   <para>rdfs:comment : The direction of traffic flow on the linear section in terms of general destination direction.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionOnLinearSection">dtx_srti:directionOnLinearSection</a>
    /// </summary>
    let directionOnLinearSection = _prefixId.prefix "directionOnLinearSection"
    /// <summary>
    ///   <para>rdfs:comment : The direction of traffic flow at the specified point relative to the direction in which the linear element is defined.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionRelativeAtPoint">dtx_srti:directionRelativeAtPoint</a>
    /// </summary>
    let directionRelativeAtPoint = _prefixId.prefix "directionRelativeAtPoint"

    /// <summary>
    ///   <para>rdfs:comment : The direction of traffic flow on the linear section relative to the direction in which the linear element is defined.rdfs:comment : </para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionRelativeOnLinearSection">dtx_srti:directionRelativeOnLinearSection</a>
    /// </summary>
    let directionRelativeOnLinearSection = _prefixId.prefix "directionRelativeOnLinearSection"

    /// <summary>
    ///   <para>rdfs:comment : A measure of distance along a linear element.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#distanceAlong">dtx_srti:distanceAlong</a>
    /// </summary>
    let distanceAlong = _prefixId.prefix "distanceAlong"
    let district = _prefixId.prefix "district"
    let districtMunicipality = _prefixId.prefix "districtMunicipality"
    let districtWithSpecialStatus = _prefixId.prefix "districtWithSpecialStatus"
    let doNoUseStudTyres = _prefixId.prefix "doNoUseStudTyres"
    let doNotAllowUnnecessaryGaps = _prefixId.prefix "doNotAllowUnnecessaryGaps"
    let doNotFollowDiversionSigns = _prefixId.prefix "doNotFollowDiversionSigns"
    let doNotLeaveYourVehicle = _prefixId.prefix "doNotLeaveYourVehicle"

    let doNotThrowOutAnyBurningObjects = _prefixId.prefix "doNotThrowOutAnyBurningObjects"

    let doNotUseEntry = _prefixId.prefix "doNotUseEntry"
    let doNotUseExit = _prefixId.prefix "doNotUseExit"

    let doNotUseIntersectionOrJunction = _prefixId.prefix "doNotUseIntersectionOrJunction"

    let doNotUseNavigationSystems = _prefixId.prefix "doNotUseNavigationSystems"

    let doNotUseSpecifiedLanesOrCarriageways = _prefixId.prefix "doNotUseSpecifiedLanesOrCarriageways"

    let driveCarefully = _prefixId.prefix "driveCarefully"
    let driveWithExtremeCaution = _prefixId.prefix "driveWithExtremeCaution"
    let driverDistraction = _prefixId.prefix "driverDistraction"
    let driverDrugAbuse = _prefixId.prefix "driverDrugAbuse"
    let driverIllness = _prefixId.prefix "driverIllness"
    let eastBound = _prefixId.prefix "eastBound"
    let ellipsoidalHeight = _prefixId.prefix "ellipsoidalHeight"
    let emergencyLane = _prefixId.prefix "emergencyLane"
    let emergencyServices = _prefixId.prefix "emergencyServices"
    let emergencyServicesPerson = _prefixId.prefix "emergencyServicesPerson"
    let entity = _prefixId.prefix "entity"
    let entrySlipRoad = _prefixId.prefix "entrySlipRoad"
    let equalToOrLessThan100Metres = _prefixId.prefix "equalToOrLessThan100Metres"

    let equalToOrLessThan10Centimetres = _prefixId.prefix "equalToOrLessThan10Centimetres"

    let equalToOrLessThan10Metres = _prefixId.prefix "equalToOrLessThan10Metres"
    let equalToOrLessThan1Centimetre = _prefixId.prefix "equalToOrLessThan1Centimetre"
    let equalToOrLessThan1Metre = _prefixId.prefix "equalToOrLessThan1Metre"
    let equalToOrLessThan200Metres = _prefixId.prefix "equalToOrLessThan200Metres"

    let equalToOrLessThan20Centimetres = _prefixId.prefix "equalToOrLessThan20Centimetres"

    let equalToOrLessThan20Metres = _prefixId.prefix "equalToOrLessThan20Metres"
    let equalToOrLessThan2Centimetres = _prefixId.prefix "equalToOrLessThan2Centimetres"
    let equalToOrLessThan2Metres = _prefixId.prefix "equalToOrLessThan2Metres"

    let equalToOrLessThan50Centimetres = _prefixId.prefix "equalToOrLessThan50Centimetres"

    let equalToOrLessThan50Metres = _prefixId.prefix "equalToOrLessThan50Metres"
    let equalToOrLessThan5Centimetres = _prefixId.prefix "equalToOrLessThan5Centimetres"
    let equalToOrLessThan5Metres = _prefixId.prefix "equalToOrLessThan5Metres"
    let equipmentFailure = _prefixId.prefix "equipmentFailure"
    let erraticFlow = _prefixId.prefix "erraticFlow"
    let escapeLane = _prefixId.prefix "escapeLane"
    let evacuation = _prefixId.prefix "evacuation"
    let exceedingSpeedsLimits = _prefixId.prefix "exceedingSpeedsLimits"
    let excessAlcohol = _prefixId.prefix "excessAlcohol"
    let excessiveDriverTiredness = _prefixId.prefix "excessiveDriverTiredness"
    let exhibition = _prefixId.prefix "exhibition"
    let exitSlipRoad = _prefixId.prefix "exitSlipRoad"
    let expressLane = _prefixId.prefix "expressLane"
    let extremeCold = _prefixId.prefix "extremeCold"
    let extremeHeat = _prefixId.prefix "extremeHeat"
    let extremelyUrgent = _prefixId.prefix "extremelyUrgent"
    let fair = _prefixId.prefix "fair"
    let fallenPowerCables = _prefixId.prefix "fallenPowerCables"
    let fallenTrees = _prefixId.prefix "fallenTrees"
    /// <summary>
    ///   <para>rdfs:comment : A description of the information which is to be found in the publications originating from the particular feed (URL).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#feedDescription">dtx_srti:feedDescription</a>
    /// </summary>
    let feedDescription = _prefixId.prefix "feedDescription"
    /// <summary>
    ///   <para>rdfs:comment : A classification of the information which is to be found in the publications originating from the particular feed.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#feedType">dtx_srti:feedType</a>
    /// </summary>
    let feedType = _prefixId.prefix "feedType"
    let ferry = _prefixId.prefix "ferry"
    let ferryPortName = _prefixId.prefix "ferryPortName"
    let festival = _prefixId.prefix "festival"
    let filmTVMaking = _prefixId.prefix "filmTVMaking"
    let fireman = _prefixId.prefix "fireman"
    let firstAid = _prefixId.prefix "firstAid"
    let flashYourLights = _prefixId.prefix "flashYourLights"
    let flooding = _prefixId.prefix "flooding"
    let flyover = _prefixId.prefix "flyover"
    let fog = _prefixId.prefix "fog"
    let followDiversionSigns = _prefixId.prefix "followDiversionSigns"
    let followLocalDiversion = _prefixId.prefix "followLocalDiversion"
    let followSpecialMarkers = _prefixId.prefix "followSpecialMarkers"

    let followTheVehicleInFrontSmoothly = _prefixId.prefix "followTheVehicleInFrontSmoothly"

    let foodDelivery = _prefixId.prefix "foodDelivery"
    let footballMatch = _prefixId.prefix "footballMatch"
    let footpath = _prefixId.prefix "footpath"
    let fourWheelDrive = _prefixId.prefix "fourWheelDrive"
    let framedPoint = _prefixId.prefix "framedPoint"
    let frc0 = _prefixId.prefix "frc0"
    let frc1 = _prefixId.prefix "frc1"
    let frc2 = _prefixId.prefix "frc2"
    let frc3 = _prefixId.prefix "frc3"
    let frc4 = _prefixId.prefix "frc4"
    let frc5 = _prefixId.prefix "frc5"
    let frc6 = _prefixId.prefix "frc6"
    let frc7 = _prefixId.prefix "frc7"
    let freightVehicleOperator = _prefixId.prefix "freightVehicleOperator"
    let frost = _prefixId.prefix "frost"
    let funfair = _prefixId.prefix "funfair"
    let fuzzyArea = _prefixId.prefix "fuzzyArea"
    let gallery = _prefixId.prefix "gallery"
    let gantry = _prefixId.prefix "gantry"
    let gardeningOrFlowerShow = _prefixId.prefix "gardeningOrFlowerShow"
    let gasLeak = _prefixId.prefix "gasLeak"
    let gasMainWork = _prefixId.prefix "gasMainWork"
    /// <summary>
    ///   <para>rdfs:comment : General message that is issued by the network/road operator which is applicable to drivers and sometimes passengers, e.g. details about an amber alert (missing or abducted child alert).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#generalMessageToRoadUsers">dtx_srti:generalMessageToRoadUsers</a>
    /// </summary>
    let generalMessageToRoadUsers = _prefixId.prefix "generalMessageToRoadUsers"
    /// <summary>
    ///   <para>rdfs:comment : For organizational purposes</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geoSparqlDataProperties">dtx_srti:geoSparqlDataProperties</a>
    /// </summary>
    let geoSparqlDataProperties = _prefixId.prefix "geoSparqlDataProperties"
    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes. GeoSparql object properties</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geoSparqlObjectProperties">dtx_srti:geoSparqlObjectProperties</a>
    /// </summary>
    let geoSparqlObjectProperties = _prefixId.prefix "geoSparqlObjectProperties"
    /// <summary>
    ///   <para>rdfs:comment : For organizational purposes. Properties of the WGS84 Geo Positioning by World Wide Web Consortium (W3C). A vocabulary for representing latitude, longitude and altitude information in the WGS84 geodetic reference datum. WGS stands for the World Geodetic Survey.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geo_WGS84">dtx_srti:geo_WGS84</a>
    /// </summary>
    let geo_WGS84 = _prefixId.prefix "geo_WGS84"
    /// <summary>
    ///   <para>rdfs:comment : For organizational purposes. Properties of the ontology for the representation of Geographical Objects https://datos.ign.es/def/geo_core</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geo_core">dtx_srti:geo_core</a>
    /// </summary>
    let geo_core = _prefixId.prefix "geo_core"
    let geographicalEntity = _prefixId.prefix "geographicalEntity"
    /// <summary>
    ///   <para>rdfs:comment : Name of the multi-polygon area</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gmlAreaName">dtx_srti:gmlAreaName</a>
    /// </summary>
    let gmlAreaName = _prefixId.prefix "gmlAreaName"
    /// <summary>
    ///   <para>rdfs:comment : List of coordinate Tuples define the geometry of this GmlLineString. There must be at least 2 Tuples of coordinates.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gmlPosList">dtx_srti:gmlPosList</a>
    /// </summary>
    let gmlPosList = _prefixId.prefix "gmlPosList"
    let golfTournament = _prefixId.prefix "golfTournament"
    let governorate = _prefixId.prefix "governorate"
    let gravityRelatedHeight = _prefixId.prefix "gravityRelatedHeight"
    let hail = _prefixId.prefix "hail"
    let hardShoulder = _prefixId.prefix "hardShoulder"

    let hardShoulderRunningInOperation = _prefixId.prefix "hardShoulderRunningInOperation"

    let harmonicAverageOfSamplesInATimePeriod = _prefixId.prefix "harmonicAverageOfSamplesInATimePeriod"

    /// <summary>
    ///   <para>rdfs:comment : A characterization of the nature of abnormal traffic flow, i.e. specifically relating to the nature of the traffic movement, implying a level of service.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAbnormalTrafficType">dtx_srti:hasAbnormalTrafficType</a>
    /// </summary>
    let hasAbnormalTrafficType = _prefixId.prefix "hasAbnormalTrafficType"
    /// <summary>
    ///   <para>rdfs:comment : A characterization of the nature of the accident.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAccidentType">dtx_srti:hasAccidentType</a>
    /// </summary>
    let hasAccidentType = _prefixId.prefix "hasAccidentType"

    /// <summary>
    ///   <para>rdfs:comment : Identification of the road administration area which contains the specified linear section.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAdministrativeAreaOfLinearSection">dtx_srti:hasAdministrativeAreaOfLinearSection</a>
    /// </summary>
    let hasAdministrativeAreaOfLinearSection = _prefixId.prefix "hasAdministrativeAreaOfLinearSection"

    /// <summary>
    ///   <para>rdfs:comment : Identification of the road administration area which contains the specified point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAdministrativeAreaOfPoint">dtx_srti:hasAdministrativeAreaOfPoint</a>
    /// </summary>
    let hasAdministrativeAreaOfPoint = _prefixId.prefix "hasAdministrativeAreaOfPoint"
    /// <summary>
    ///   <para>rdfs:comment : The direction(s) of traffic flow to which the situation, traffic data or information is related.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCAffectedDirection">dtx_srti:hasAlertCAffectedDirection</a>
    /// </summary>
    let hasAlertCAffectedDirection = _prefixId.prefix "hasAlertCAffectedDirection"
    /// <summary>
    ///   <para>rdfs:comment : ALERT-C Area</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCArea">dtx_srti:hasAlertCArea</a>
    /// </summary>
    let hasAlertCArea = _prefixId.prefix "hasAlertCArea"
    /// <summary>
    ///   <para>rdfs:comment : The direction of traffic flow along the road to which the information relates.rdfs:comment : ALERT-C direction</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCDirection">dtx_srti:hasAlertCDirection</a>
    /// </summary>
    let hasAlertCDirection = _prefixId.prefix "hasAlertCDirection"
    /// <summary>
    ///   <para>rdfs:comment : Direction of navigation with respect to secondary to primary location (RDS direction)</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCDirectionCoded">dtx_srti:hasAlertCDirectionCoded</a>
    /// </summary>
    let hasAlertCDirectionCoded = _prefixId.prefix "hasAlertCDirectionCoded"
    /// <summary>
    ///   <para>rdfs:comment : The linear location expressed using AlertC. Multiple instances of AlertCLinear shall represent the same real-world geographic feature.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCLinear">dtx_srti:hasAlertCLinear</a>
    /// </summary>
    let hasAlertCLinear = _prefixId.prefix "hasAlertCLinear"
    /// <summary>
    ///   <para>rdfs:comment : Identification of a specific point, linear or area location in an ALERT-C location table.rdfs:comment : ALERT-C location</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCLocation">dtx_srti:hasAlertCLocation</a>
    /// </summary>
    let hasAlertCLocation = _prefixId.prefix "hasAlertCLocation"

    /// <summary>
    ///   <para>rdfs:comment : The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.rdfs:comment : ALERT-C method2 primary point location</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod2PrimaryPointLocation">dtx_srti:hasAlertCMethod2PrimaryPointLocation</a>
    /// </summary>
    let hasAlertCMethod2PrimaryPointLocation = _prefixId.prefix "hasAlertCMethod2PrimaryPointLocation"

    /// <summary>
    ///   <para>rdfs:comment : The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.rdfs:comment : ALERT-C method2 secondary point location</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod2SecondaryPointLocation">dtx_srti:hasAlertCMethod2SecondaryPointLocation</a>
    /// </summary>
    let hasAlertCMethod2SecondaryPointLocation = _prefixId.prefix "hasAlertCMethod2SecondaryPointLocation"

    /// <summary>
    ///   <para>rdfs:comment : The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table plus a non-negative offset distance.rdfs:comment : ALERT-C method4 primary point location</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod4PrimaryPointLocation">dtx_srti:hasAlertCMethod4PrimaryPointLocation</a>
    /// </summary>
    let hasAlertCMethod4PrimaryPointLocation = _prefixId.prefix "hasAlertCMethod4PrimaryPointLocation"

    /// <summary>
    ///   <para>rdfs:comment : The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined Alert-C location table plus a non-negative offset distance.rdfs:comment : ALERT-C method4 secondary point location</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod4SecondaryPointLocation">dtx_srti:hasAlertCMethod4SecondaryPointLocation</a>
    /// </summary>
    let hasAlertCMethod4SecondaryPointLocation = _prefixId.prefix "hasAlertCMethod4SecondaryPointLocation"

    /// <summary>
    ///   <para>rdfs:comment : The point location expressed using AlertC. Multiple instances of AlertCPoint shall represent the same real-world geographic feature.They should represent the same point using different location tables.rdfs:comment : PointLocation is associated to AlertCPoint with cardinality 0..*rdfs:comment : ALERT-C pointrdfs:comment : A single point on the road network defined by reference to a pre-defined ALERT-C location table and which has an associated direction of traffic flow.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCPoint">dtx_srti:hasAlertCPoint</a>
    /// </summary>
    let hasAlertCPoint = _prefixId.prefix "hasAlertCPoint"
    /// <summary>
    ///   <para>rdfs:comment : Absolute accuracy of reported value of a geographical point for a confidence level expressed by a coded scale.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAltitudeAccuracyCodedValue">dtx_srti:hasAltitudeAccuracyCodedValue</a>
    /// </summary>
    let hasAltitudeAccuracyCodedValue = _prefixId.prefix "hasAltitudeAccuracyCodedValue"
    /// <summary>
    ///   <para>rdfs:comment : Evaluation of the altitude confidence assessed according to ETSI ISO 102894-2</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAltitudeConfidence">dtx_srti:hasAltitudeConfidence</a>
    /// </summary>
    let hasAltitudeConfidence = _prefixId.prefix "hasAltitudeConfidence"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the nature of animals present on or near the roadway.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAnimalPresenceTypeEnum">dtx_srti:hasAnimalPresenceTypeEnum</a>
    /// </summary>
    let hasAnimalPresenceTypeEnum = _prefixId.prefix "hasAnimalPresenceTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Places, in generic terms, at which the corresponding information applies.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAreaPlacesEnum">dtx_srti:hasAreaPlacesEnum</a>
    /// </summary>
    let hasAreaPlacesEnum = _prefixId.prefix "hasAreaPlacesEnum"
    /// <summary>
    ///   <para>rdfs:comment : Supplementary positional information which details carriageway and lane locations. Several instances may exist where the element being described extends over more than one carriageway.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCarriageway">dtx_srti:hasCarriageway</a>
    /// </summary>
    let hasCarriageway = _prefixId.prefix "hasCarriageway"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the section of carriageway to which the location relates.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCarriagewayEnum">dtx_srti:hasCarriagewayEnum</a>
    /// </summary>
    let hasCarriagewayEnum = _prefixId.prefix "hasCarriagewayEnum"
    /// <summary>
    ///   <para>rdfs:comment : Centre point of a circular geometric area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCentrePoint">dtx_srti:hasCentrePoint</a>
    /// </summary>
    let hasCentrePoint = _prefixId.prefix "hasCentrePoint"
    /// <summary>
    ///   <para>rdfs:comment : Method of computation which has been used to compute this data value.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasComputationMethodEnum">dtx_srti:hasComputationMethodEnum</a>
    /// </summary>
    let hasComputationMethodEnum = _prefixId.prefix "hasComputationMethodEnum"
    /// <summary>
    ///   <para>rdfs:comment : The extent to which the related information may be circulated, according to the recipient type. Recipients must comply with this confidentiality statement.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasConfidentiality">dtx_srti:hasConfidentiality</a>
    /// </summary>
    let hasConfidentiality = _prefixId.prefix "hasConfidentiality"
    /// <summary>
    ///   <para>rdfs:comment : The type of construction work being performed.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasConstructionWorkType">dtx_srti:hasConstructionWorkType</a>
    /// </summary>
    let hasConstructionWorkType = _prefixId.prefix "hasConstructionWorkType"
    /// <summary>
    ///   <para>rdfs:comment : The ISO 3166-2 subdivision code for the named area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCountrySubdivision">dtx_srti:hasCountrySubdivision</a>
    /// </summary>
    let hasCountrySubdivision = _prefixId.prefix "hasCountrySubdivision"
    /// <summary>
    ///   <para>rdfs:comment : The details of the delays being caused by the situation element defined in the situation record. It is recommended to only use one of the optional attributes to avoid confusion.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDelays">dtx_srti:hasDelays</a>
    /// </summary>
    let hasDelays = _prefixId.prefix "hasDelays"
    /// <summary>
    ///   <para>rdfs:comment : Identifies the main purpose of the road at the location</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDirectionPurpose">dtx_srti:hasDirectionPurpose</a>
    /// </summary>
    let hasDirectionPurpose = _prefixId.prefix "hasDirectionPurpose"
    /// <summary>
    ///   <para>rdfs:comment : Distance of a point along a linear element either measured from the start node or a defined referent on that linear element, where the start node is relative to the element definition rather than the direction of traffic flow.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElement">dtx_srti:hasDistanceAlongLinearElement</a>
    /// </summary>
    let hasDistanceAlongLinearElement = _prefixId.prefix "hasDistanceAlongLinearElement"

    /// <summary>
    ///   <para>rdfs:comment : A point on the linear element that defines the start node of the linear section.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElementFrom">dtx_srti:hasDistanceAlongLinearElementFrom</a>
    /// </summary>
    let hasDistanceAlongLinearElementFrom = _prefixId.prefix "hasDistanceAlongLinearElementFrom"

    /// <summary>
    ///   <para>rdfs:comment : A point on the linear element that defines the end node of the linear section.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElementTo">dtx_srti:hasDistanceAlongLinearElementTo</a>
    /// </summary>
    let hasDistanceAlongLinearElementTo = _prefixId.prefix "hasDistanceAlongLinearElementTo"

    /// <summary>
    ///   <para>rdfs:comment : Deliberate human action of either a public disorder nature or of a situation alert type which could disrupt traffic.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDisturbanceActivityTypeEnum">dtx_srti:hasDisturbanceActivityTypeEnum</a>
    /// </summary>
    let hasDisturbanceActivityTypeEnum = _prefixId.prefix "hasDisturbanceActivityTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Types of the perceived driving conditions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDrivingConditionTypeEnum">dtx_srti:hasDrivingConditionTypeEnum</a>
    /// </summary>
    let hasDrivingConditionTypeEnum = _prefixId.prefix "hasDrivingConditionTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Characterization of an obstruction on the road resulting from an environmental cause.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasEnvironmentalObstructionTypeEnum">dtx_srti:hasEnvironmentalObstructionTypeEnum</a>
    /// </summary>
    let hasEnvironmentalObstructionTypeEnum = _prefixId.prefix "hasEnvironmentalObstructionTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : General instruction that is issued by the network/road operator which is applicable to drivers and sometimes passengers.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeneralInstructionOrMessageToRoadUsersType">dtx_srti:hasGeneralInstructionOrMessageToRoadUsersType</a>
    /// </summary>
    let hasGeneralInstructionOrMessageToRoadUsersType = _prefixId.prefix "hasGeneralInstructionOrMessageToRoadUsersType"

    /// <summary>
    ///   <para>rdfs:comment : The type of traffic management action instigated by the network/road operator.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeneralNetworkManagementType">dtx_srti:hasGeneralNetworkManagementType</a>
    /// </summary>
    let hasGeneralNetworkManagementType = _prefixId.prefix "hasGeneralNetworkManagementType"

    /// <summary>
    ///   <para>rdfs:comment : Descriptor which identifies a geographic characteristic to help identify the specific location</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeographicDescriptor">dtx_srti:hasGeographicDescriptor</a>
    /// </summary>
    let hasGeographicDescriptor = _prefixId.prefix "hasGeographicDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A boundary of a polygonal surface consisting of a ring i.e. in the normal 2D case, a closed polygonal line distinguished as exterior. Such a polygonal line has at least 4 pairs of coordinates</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlExteriorLinearRing">dtx_srti:hasGmlExteriorLinearRing</a>
    /// </summary>
    let hasGmlExteriorLinearRing = _prefixId.prefix "hasGmlExteriorLinearRing"
    /// <summary>
    ///   <para>rdfs:comment : A boundary of internal patches of a polygonal surface consisting of a ring feature</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlInteriorLinearRing">dtx_srti:hasGmlInteriorLinearRing</a>
    /// </summary>
    let hasGmlInteriorLinearRing = _prefixId.prefix "hasGmlInteriorLinearRing"
    /// <summary>
    ///   <para>rdfs:comment : Line string based on GML (EN ISO 19136) definition: a curve defined by a series of two or more coordinate tuples. Unlike GML may be self-intersecting. If srsName attribute is not present, posList is assumed to use "ETRS89-LatLonh" reference system.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlLineString">dtx_srti:hasGmlLineString</a>
    /// </summary>
    let hasGmlLineString = _prefixId.prefix "hasGmlLineString"
    /// <summary>
    ///   <para>rdfs:comment : An area defined by a set of polygons acording to GML (EN ISO 19136).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlMultiPolygon">dtx_srti:hasGmlMultiPolygon</a>
    /// </summary>
    let hasGmlMultiPolygon = _prefixId.prefix "hasGmlMultiPolygon"
    /// <summary>
    ///   <para>rdfs:comment : Planar surface defined by 1 exterior boundary and 0 or more interior boundaries</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlPolygon">dtx_srti:hasGmlPolygon</a>
    /// </summary>
    let hasGmlPolygon = _prefixId.prefix "hasGmlPolygon"
    /// <summary>
    ///   <para>rdfs:comment : Management information relating to the data contained within a publication.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeaderInformation">dtx_srti:hasHeaderInformation</a>
    /// </summary>
    let hasHeaderInformation = _prefixId.prefix "hasHeaderInformation"
    /// <summary>
    ///   <para>rdfs:comment : Third coordinate for points defined geodetically</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightCoordinate">dtx_srti:hasHeightCoordinate</a>
    /// </summary>
    let hasHeightCoordinate = _prefixId.prefix "hasHeightCoordinate"
    /// <summary>
    ///   <para>rdfs:comment : Identification of whether the linear section that is part of the linear element is at, above or below the normal elevation of a linear element of that type (e.g. road or road section) at that location, typically used to indicate "grade" separation.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightGradeOfLinearSection">dtx_srti:hasHeightGradeOfLinearSection</a>
    /// </summary>
    let hasHeightGradeOfLinearSection = _prefixId.prefix "hasHeightGradeOfLinearSection"
    /// <summary>
    ///   <para>rdfs:comment : Identification of whether the point on the linear element is at, above or below the normal elevation of a linear element of that type (e.g. road or road section) at that location, typically used to indicate "grade" separation.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightGradeOfPoint">dtx_srti:hasHeightGradeOfPoint</a>
    /// </summary>
    let hasHeightGradeOfPoint = _prefixId.prefix "hasHeightGradeOfPoint"
    /// <summary>
    ///   <para>rdfs:comment : Type of measured height.When it is omitted it is supposed to be the ellipsoidal height.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightTypeEnum">dtx_srti:hasHeightTypeEnum</a>
    /// </summary>
    let hasHeightTypeEnum = _prefixId.prefix "hasHeightTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Defines the horizontal position accuracy according EN 16803-1</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHorizontalPositionAccuracy">dtx_srti:hasHorizontalPositionAccuracy</a>
    /// </summary>
    let hasHorizontalPositionAccuracy = _prefixId.prefix "hasHorizontalPositionAccuracy"
    /// <summary>
    ///   <para>rdfs:comment : An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasImpact">dtx_srti:hasImpact</a>
    /// </summary>
    let hasImpact = _prefixId.prefix "hasImpact"
    /// <summary>
    ///   <para>rdfs:comment : An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions, but on opposite direction.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasImpactOnOppositeDirection">dtx_srti:hasImpactOnOppositeDirection</a>
    /// </summary>
    let hasImpactOnOppositeDirection = _prefixId.prefix "hasImpactOnOppositeDirection"
    /// <summary>
    ///   <para>rdfs:comment : The status of the related information (real, test, exercise ....).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInformationStatus">dtx_srti:hasInformationStatus</a>
    /// </summary>
    let hasInformationStatus = _prefixId.prefix "hasInformationStatus"
    /// <summary>
    ///   <para>rdfs:comment : Types of infrastructure damage which may have an effect on the road network.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInfrastructureDamageType">dtx_srti:hasInfrastructureDamageType</a>
    /// </summary>
    let hasInfrastructureDamageType = _prefixId.prefix "hasInfrastructureDamageType"
    /// <summary>
    ///   <para>rdfs:comment : Descriptor which identifies infrastructure to help identify the specific location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInfrastructureDescriptor">dtx_srti:hasInfrastructureDescriptor</a>
    /// </summary>
    let hasInfrastructureDescriptor = _prefixId.prefix "hasInfrastructureDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a specific lane or group of lanes.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLane">dtx_srti:hasLane</a>
    /// </summary>
    let hasLane = _prefixId.prefix "hasLane"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the specific lane to which the location relates.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLaneEnum">dtx_srti:hasLaneEnum</a>
    /// </summary>
    let hasLaneEnum = _prefixId.prefix "hasLaneEnum"
    /// <summary>
    ///   <para>rdfs:comment : Specifies a linear element along a single linear object, consistent with EN ISO 19148 definitions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearElement">dtx_srti:hasLinearElement</a>
    /// </summary>
    let hasLinearElement = _prefixId.prefix "hasLinearElement"
    /// <summary>
    ///   <para>rdfs:comment : An indication of the nature of the linear element.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearElementNature">dtx_srti:hasLinearElementNature</a>
    /// </summary>
    let hasLinearElementNature = _prefixId.prefix "hasLinearElementNature"
    /// <summary>
    ///   <para>rdfs:comment : Specifies a linear section along a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearWithinLinearElement">dtx_srti:hasLinearWithinLinearElement</a>
    /// </summary>
    let hasLinearWithinLinearElement = _prefixId.prefix "hasLinearWithinLinearElement"

    /// <summary>
    ///   <para>rdfs:comment : Specific location. Unique code within the ALERT-C location table which identifies the specific point, linear or area location.Unique code within the ALERT-C location table which identifies the specific point, linear or area location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationCodeForLinearLocation">dtx_srti:hasLocationCodeForLinearLocation</a>
    /// </summary>
    let hasLocationCodeForLinearLocation = _prefixId.prefix "hasLocationCodeForLinearLocation"

    /// <summary>
    ///   <para>rdfs:comment : A location contained in an itinerary (i.e. an ordered set of locations defining a route or itinerary).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationContainedInItinerary">dtx_srti:hasLocationContainedInItinerary</a>
    /// </summary>
    let hasLocationContainedInItinerary = _prefixId.prefix "hasLocationContainedInItinerary"

    /// <summary>
    ///   <para>rdfs:comment : Has a location reference</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationReference">dtx_srti:hasLocationReference</a>
    /// </summary>
    let hasLocationReference = _prefixId.prefix "hasLocationReference"
    /// <summary>
    ///   <para>rdfs:comment : The actions of the maintenance vehicles associated with the roadworks activities.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMaintenanceVehicleActions">dtx_srti:hasMaintenanceVehicleActions</a>
    /// </summary>
    let hasMaintenanceVehicleActions = _prefixId.prefix "hasMaintenanceVehicleActions"
    /// <summary>
    ///   <para>rdfs:comment : Details of the maintenance vehicles involved in the roadworks activity.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMaintenanceVehicles">dtx_srti:hasMaintenanceVehicles</a>
    /// </summary>
    let hasMaintenanceVehicles = _prefixId.prefix "hasMaintenanceVehicles"
    /// <summary>
    ///   <para>rdfs:comment : An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobility">dtx_srti:hasMobility</a>
    /// </summary>
    let hasMobility = _prefixId.prefix "hasMobility"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the mobility of activity</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityOfActivity">dtx_srti:hasMobilityOfActivity</a>
    /// </summary>
    let hasMobilityOfActivity = _prefixId.prefix "hasMobilityOfActivity"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the mobility of a obstruction</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityOfObstruction">dtx_srti:hasMobilityOfObstruction</a>
    /// </summary>
    let hasMobilityOfObstruction = _prefixId.prefix "hasMobilityOfObstruction"
    /// <summary>
    ///   <para>rdfs:comment : Types of mobility relating to a situation element defined by a SituationReord.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityType">dtx_srti:hasMobilityType</a>
    /// </summary>
    let hasMobilityType = _prefixId.prefix "hasMobilityType"
    /// <summary>
    ///   <para>rdfs:comment : An area defined by a name and/or in terms of known boundaries, such as country or county boundaries or allocated control area of particular authority. The attributes do not form a union; instead, the smallest intersection forms the resulting area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNamedArea">dtx_srti:hasNamedArea</a>
    /// </summary>
    let hasNamedArea = _prefixId.prefix "hasNamedArea"
    /// <summary>
    ///   <para>rdfs:comment : The type of the area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNamedAreaTypeEnum">dtx_srti:hasNamedAreaTypeEnum</a>
    /// </summary>
    let hasNamedAreaTypeEnum = _prefixId.prefix "hasNamedAreaTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : The type of road conditions which are not related to the weather.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNonWeatherRelatedRoadConditionTypeEnum">dtx_srti:hasNonWeatherRelatedRoadConditionTypeEnum</a>
    /// </summary>
    let hasNonWeatherRelatedRoadConditionTypeEnum = _prefixId.prefix "hasNonWeatherRelatedRoadConditionTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : The NUTS code type for the named area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNutsCodeTypeEnum">dtx_srti:hasNutsCodeTypeEnum</a>
    /// </summary>
    let hasNutsCodeTypeEnum = _prefixId.prefix "hasNutsCodeTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Characterization of the type of general obstruction.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasObstructionTypeEnum">dtx_srti:hasObstructionTypeEnum</a>
    /// </summary>
    let hasObstructionTypeEnum = _prefixId.prefix "hasObstructionTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : The non-negative offset distance from the ALERT-C referenced point to the actual point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOffsetDistance">dtx_srti:hasOffsetDistance</a>
    /// </summary>
    let hasOffsetDistance = _prefixId.prefix "hasOffsetDistance"

    /// <summary>
    ///   <para>rdfs:comment : A two-dimensional part of the surface of the earth which is bounded by a closed curve. An area location may cover parts of the road network but does not necessarily need to. It is represented according to the OpenLR standard for Area Locations</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrAreaLocationReference">dtx_srti:hasOpenlrAreaLocationReference</a>
    /// </summary>
    let hasOpenlrAreaLocationReference = _prefixId.prefix "hasOpenlrAreaLocationReference"

    /// <summary>
    ///   <para>rdfs:comment : Corresponding coordinates of an OpenLR point defined by its only coordinates.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrCoordinates">dtx_srti:hasOpenlrCoordinates</a>
    /// </summary>
    let hasOpenlrCoordinates = _prefixId.prefix "hasOpenlrCoordinates"
    /// <summary>
    ///   <para>rdfs:comment : First OpenLR reference in first/main direction.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrFirstDirection">dtx_srti:hasOpenlrFirstDirection</a>
    /// </summary>
    let hasOpenlrFirstDirection = _prefixId.prefix "hasOpenlrFirstDirection"
    /// <summary>
    ///   <para>rdfs:comment : A classification based on the importance of the role that the Road Element (or Ferry Connection) performs in the connectivity of the total road network. (EN ISO 14825 § 7.2.88)</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrFormOfWayEnum">dtx_srti:hasOpenlrFormOfWayEnum</a>
    /// </summary>
    let hasOpenlrFormOfWayEnum = _prefixId.prefix "hasOpenlrFormOfWayEnum"
    /// <summary>
    ///   <para>rdfs:comment : A geo-coordinate pair is a position in a map defined by its longitude and latitude coordinate values.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrGeoCoordinate">dtx_srti:hasOpenlrGeoCoordinate</a>
    /// </summary>
    let hasOpenlrGeoCoordinate = _prefixId.prefix "hasOpenlrGeoCoordinate"

    /// <summary>
    ///   <para>rdfs:comment : Allows defining the last point of the OpenLR path</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLastLocationReferencePoint">dtx_srti:hasOpenlrLastLocationReferencePoint</a>
    /// </summary>
    let hasOpenlrLastLocationReferencePoint = _prefixId.prefix "hasOpenlrLastLocationReferencePoint"

    /// <summary>
    ///   <para>rdfs:comment : Properties of the line towards the topologically adjacent OpenLR location referencing point, on the shortest path to that point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLineAttributes">dtx_srti:hasOpenlrLineAttributes</a>
    /// </summary>
    let hasOpenlrLineAttributes = _prefixId.prefix "hasOpenlrLineAttributes"
    /// <summary>
    ///   <para>rdfs:comment : OpenLR line location reference</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLinear">dtx_srti:hasOpenlrLinear</a>
    /// </summary>
    let hasOpenlrLinear = _prefixId.prefix "hasOpenlrLinear"

    /// <summary>
    ///   <para>rdfs:comment : Allows defining the first point of the OpenLR path</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLocationReferencePoint">dtx_srti:hasOpenlrLocationReferencePoint</a>
    /// </summary>
    let hasOpenlrLocationReferencePoint = _prefixId.prefix "hasOpenlrLocationReferencePoint"

    /// <summary>
    ///   <para>rdfs:comment : The lower left corner of the rectangle.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLowerLeft">dtx_srti:hasOpenlrLowerLeft</a>
    /// </summary>
    let hasOpenlrLowerLeft = _prefixId.prefix "hasOpenlrLowerLeft"

    /// <summary>
    ///   <para>rdfs:comment : The lowest FRC to the next point indicates the lowest functional road class used in the location reference path to the next LR-point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLowestFrcToNextLRPoint">dtx_srti:hasOpenlrLowestFrcToNextLRPoint</a>
    /// </summary>
    let hasOpenlrLowestFrcToNextLRPoint = _prefixId.prefix "hasOpenlrLowestFrcToNextLRPoint"

    /// <summary>
    ///   <para>rdfs:comment : Allows for adding offsets to the line location path defined by nodes when the starting (respectively ending) point does not coincide with a node.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOffsets">dtx_srti:hasOpenlrOffsets</a>
    /// </summary>
    let hasOpenlrOffsets = _prefixId.prefix "hasOpenlrOffsets"
    /// <summary>
    ///   <para>rdfs:comment : If both direction, this is the reference in the opposite direction against firstDirection.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOppositeDirection">dtx_srti:hasOpenlrOppositeDirection</a>
    /// </summary>
    let hasOpenlrOppositeDirection = _prefixId.prefix "hasOpenlrOppositeDirection"
    /// <summary>
    ///   <para>rdfs:comment : Orientation of the driving direction in relation with the direction of the underlying linear</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOrientation">dtx_srti:hasOpenlrOrientation</a>
    /// </summary>
    let hasOpenlrOrientation = _prefixId.prefix "hasOpenlrOrientation"
    /// <summary>
    ///   <para>rdfs:comment : Properties of the path from the associated location reference point to the next location reference point, which are specified to assist correct identification of the point in an external map data source.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPathAttributes">dtx_srti:hasOpenlrPathAttributes</a>
    /// </summary>
    let hasOpenlrPathAttributes = _prefixId.prefix "hasOpenlrPathAttributes"

    /// <summary>
    ///   <para>rdfs:comment : PointLocation is associated to OpenlrPointLocationReference with cardinality 0..1</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPointLocationReference">dtx_srti:hasOpenlrPointLocationReference</a>
    /// </summary>
    let hasOpenlrPointLocationReference = _prefixId.prefix "hasOpenlrPointLocationReference"

    /// <summary>
    ///   <para>rdfs:comment : A geodetic coordinate Tuple that defines the vertices of the underlying geometrical polygon.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPolygonCorners">dtx_srti:hasOpenlrPolygonCorners</a>
    /// </summary>
    let hasOpenlrPolygonCorners = _prefixId.prefix "hasOpenlrPolygonCorners"
    /// <summary>
    ///   <para>rdfs:comment : Area delimited by a rectangle defined by the geodetic co-ordinates of the two ends of its diagonal from south-west to north-east (the rectangle having two sides that are parallel to lines of latitude)</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrRectangle">dtx_srti:hasOpenlrRectangle</a>
    /// </summary>
    let hasOpenlrRectangle = _prefixId.prefix "hasOpenlrRectangle"
    /// <summary>
    ///   <para>rdfs:comment : Provides the of road where the corresponding point lies.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrSideOfRoad">dtx_srti:hasOpenlrSideOfRoad</a>
    /// </summary>
    let hasOpenlrSideOfRoad = _prefixId.prefix "hasOpenlrSideOfRoad"
    /// <summary>
    ///   <para>rdfs:comment : The upper right corner of the rectangle.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrUpperRight">dtx_srti:hasOpenlrUpperRight</a>
    /// </summary>
    let hasOpenlrUpperRight = _prefixId.prefix "hasOpenlrUpperRight"
    let hasOverallEndTime = _prefixId.prefix "hasOverallEndTime"
    let hasOverallStartTime = _prefixId.prefix "hasOverallStartTime"
    /// <summary>
    ///   <para>rdfs:comment : PointLocation is associated to PointAlongLinearElement with cardinality 0..*</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointAlongLinearElement">dtx_srti:hasPointAlongLinearElement</a>
    /// </summary>
    let hasPointAlongLinearElement = _prefixId.prefix "hasPointAlongLinearElement"
    /// <summary>
    ///   <para>rdfs:comment : PointLocation is associated to PointByCoordinates with cardinality 0..1</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointByCoordinates">dtx_srti:hasPointByCoordinates</a>
    /// </summary>
    let hasPointByCoordinates = _prefixId.prefix "hasPointByCoordinates"
    /// <summary>
    ///   <para>rdfs:comment : Coordinates that may be used by clients for visual display on user interfaces.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointCoordinates">dtx_srti:hasPointCoordinates</a>
    /// </summary>
    let hasPointCoordinates = _prefixId.prefix "hasPointCoordinates"
    /// <summary>
    ///   <para>rdfs:comment : Any environmental conditions which may be affecting the driving conditions on the road.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPoorEnvironmentTypeEnum">dtx_srti:hasPoorEnvironmentTypeEnum</a>
    /// </summary>
    let hasPoorEnvironmentTypeEnum = _prefixId.prefix "hasPoorEnvironmentTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Error code in case the altitude confidence is out of range or cannot be determined</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionConfidenceCodedErrorEnum">dtx_srti:hasPositionConfidenceCodedErrorEnum</a>
    /// </summary>
    let hasPositionConfidenceCodedErrorEnum = _prefixId.prefix "hasPositionConfidenceCodedErrorEnum"

    /// <summary>
    ///   <para>rdfs:comment : Confidence ellipse position defined in a shape of ellipse with a predefined confidence level (e.g. 95 %). The centre of the ellipse shape corresponds to the reference position point for which the position accuracy is evaluated.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionConfidenceEllipse">dtx_srti:hasPositionConfidenceEllipse</a>
    /// </summary>
    let hasPositionConfidenceEllipse = _prefixId.prefix "hasPositionConfidenceEllipse"
    /// <summary>
    ///   <para>rdfs:comment : Relative position across carriageway</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionOnCarriageway">dtx_srti:hasPositionOnCarriageway</a>
    /// </summary>
    let hasPositionOnCarriageway = _prefixId.prefix "hasPositionOnCarriageway"
    /// <summary>
    ///   <para>rdfs:comment : An assessment of the degree of likelihood that the reported event will occur.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasProbabilityOfOccurrence">dtx_srti:hasProbabilityOfOccurrence</a>
    /// </summary>
    let hasProbabilityOfOccurrence = _prefixId.prefix "hasProbabilityOfOccurrence"
    /// <summary>
    ///   <para>rdfs:comment : Specifies types of public events.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPublicEventType">dtx_srti:hasPublicEventType</a>
    /// </summary>
    let hasPublicEventType = _prefixId.prefix "hasPublicEventType"
    /// <summary>
    ///   <para>rdfs:comment : Specifies a referent on a linear object that has a known location such as a node, a reference marker (e.g. a marker-post), an intersection etc.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferent">dtx_srti:hasReferent</a>
    /// </summary>
    let hasReferent = _prefixId.prefix "hasReferent"

    /// <summary>
    ///   <para>rdfs:comment : The referent at a known location on the linear object which defines the end of the linear element.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentEndPointLinearElement">dtx_srti:hasReferentEndPointLinearElement</a>
    /// </summary>
    let hasReferentEndPointLinearElement = _prefixId.prefix "hasReferentEndPointLinearElement"

    /// <summary>
    ///   <para>rdfs:comment : A known location along the linear element from which the distanceAlong is measured, termed the "fromReferent" in EN ISO 19148.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentFrom">dtx_srti:hasReferentFrom</a>
    /// </summary>
    let hasReferentFrom = _prefixId.prefix "hasReferentFrom"

    /// <summary>
    ///   <para>rdfs:comment : A referent at a known location on the linear object which is neither the start or end of the linear element.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentIntermediatePointLinearElement">dtx_srti:hasReferentIntermediatePointLinearElement</a>
    /// </summary>
    let hasReferentIntermediatePointLinearElement = _prefixId.prefix "hasReferentIntermediatePointLinearElement"

    /// <summary>
    ///   <para>rdfs:comment : The referent at a known location on the linear object which defines the start of the linear element.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentStartPointLinearElement">dtx_srti:hasReferentStartPointLinearElement</a>
    /// </summary>
    let hasReferentStartPointLinearElement = _prefixId.prefix "hasReferentStartPointLinearElement"

    /// <summary>
    ///   <para>rdfs:comment : A known location along the linear element towards which the distanceAlong is measured, termed the "towardsReferent" in EN ISO 19148.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentTowards">dtx_srti:hasReferentTowards</a>
    /// </summary>
    let hasReferentTowards = _prefixId.prefix "hasReferentTowards"
    /// <summary>
    ///   <para>rdfs:comment : The type of the referent.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentTypeEnum">dtx_srti:hasReferentTypeEnum</a>
    /// </summary>
    let hasReferentTypeEnum = _prefixId.prefix "hasReferentTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Assessment of the traffic flow conditions relative to normally expected conditions at this date/time.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRelativeTrafficFlowEnum">dtx_srti:hasRelativeTrafficFlowEnum</a>
    /// </summary>
    let hasRelativeTrafficFlowEnum = _prefixId.prefix "hasRelativeTrafficFlowEnum"
    /// <summary>
    ///   <para>rdfs:comment : Management actions relating to rerouting.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReroutingManagementType">dtx_srti:hasReroutingManagementType</a>
    /// </summary>
    let hasReroutingManagementType = _prefixId.prefix "hasReroutingManagementType"
    /// <summary>
    ///   <para>rdfs:comment : Information on a set of one or more roads. The location could correspond to a part of the road identified, the whole stretch of road identified, or a combination of multiple road sections.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadInformation">dtx_srti:hasRoadInformation</a>
    /// </summary>
    let hasRoadInformation = _prefixId.prefix "hasRoadInformation"
    /// <summary>
    ///   <para>rdfs:comment : The type of road maintenance or installation work at the specified location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadMaintenanceType">dtx_srti:hasRoadMaintenanceType</a>
    /// </summary>
    let hasRoadMaintenanceType = _prefixId.prefix "hasRoadMaintenanceType"
    /// <summary>
    ///   <para>rdfs:comment : Identifier/number of the road. The road number designated by the road authority</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadNumber">dtx_srti:hasRoadNumber</a>
    /// </summary>
    let hasRoadNumber = _prefixId.prefix "hasRoadNumber"

    /// <summary>
    ///   <para>rdfs:comment : Management actions relating to road, carriageway or lane usage.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadOrCarriagewayOrLaneManagementType">dtx_srti:hasRoadOrCarriagewayOrLaneManagementType</a>
    /// </summary>
    let hasRoadOrCarriagewayOrLaneManagementType = _prefixId.prefix "hasRoadOrCarriagewayOrLaneManagementType"

    /// <summary>
    ///   <para>rdfs:comment : Indicates the nature of the road side assistance that will be, is or has been provided.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadsideAssistenceTypeEnum">dtx_srti:hasRoadsideAssistenceTypeEnum</a>
    /// </summary>
    let hasRoadsideAssistenceTypeEnum = _prefixId.prefix "hasRoadsideAssistenceTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Indicates in general terms the expected duration of the roadworks.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadworksDuration">dtx_srti:hasRoadworksDuration</a>
    /// </summary>
    let hasRoadworksDuration = _prefixId.prefix "hasRoadworksDuration"
    /// <summary>
    ///   <para>rdfs:comment : Grade of complexity of the roadworks according to the responsible road operator. For example determined by size, duration and/or traffic disruption.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadworksScaleEnum">dtx_srti:hasRoadworksScaleEnum</a>
    /// </summary>
    let hasRoadworksScaleEnum = _prefixId.prefix "hasRoadworksScaleEnum"

    /// <summary>
    ///   <para>rdfs:comment : Supplementary description that applies to the secondary end of the linear location. Use when properties change along the Linear. For a one-way linear the secondary end should be the destination end.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSecondarySupplementaryDescription">dtx_srti:hasSecondarySupplementaryDescription</a>
    /// </summary>
    let hasSecondarySupplementaryDescription = _prefixId.prefix "hasSecondarySupplementaryDescription"

    /// <summary>
    ///   <para>rdfs:comment : Provides a coded error in case the semi-major axis length is not defined</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSemiMajorAxisLengthCodedError">dtx_srti:hasSemiMajorAxisLengthCodedError</a>
    /// </summary>
    let hasSemiMajorAxisLengthCodedError = _prefixId.prefix "hasSemiMajorAxisLengthCodedError"

    /// <summary>
    ///   <para>rdfs:comment : Provides a coded error in case the semi-minor axis length is not defined</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSemiMinorAxisLengthCodedError">dtx_srti:hasSemiMinorAxisLengthCodedError</a>
    /// </summary>
    let hasSemiMinorAxisLengthCodedError = _prefixId.prefix "hasSemiMinorAxisLengthCodedError"

    /// <summary>
    ///   <para>rdfs:comment : Levels of severity of a situation as whole assessed by the impact that the situation may have on traffic flow as perceived by the supplier.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSeverityEnum">dtx_srti:hasSeverityEnum</a>
    /// </summary>
    let hasSeverityEnum = _prefixId.prefix "hasSeverityEnum"
    /// <summary>
    ///   <para>rdfs:comment : traffic/travel situations.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSituation">dtx_srti:hasSituation</a>
    /// </summary>
    let hasSituation = _prefixId.prefix "hasSituation"
    /// <summary>
    ///   <para>rdfs:comment : Details of the Situation</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSituationRecord">dtx_srti:hasSituationRecord</a>
    /// </summary>
    let hasSituationRecord = _prefixId.prefix "hasSituationRecord"
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:comment : Type of speed management action instigated by operator.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSpeedManagementType">dtx_srti:hasSpeedManagementType</a>
    /// </summary>
    let hasSpeedManagementType = _prefixId.prefix "hasSpeedManagementType"
    /// <summary>
    ///   <para>rdfs:comment : The ISO 3166-2 subdivison type for the named area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubdivisionTypeEnum">dtx_srti:hasSubdivisionTypeEnum</a>
    /// </summary>
    let hasSubdivisionTypeEnum = _prefixId.prefix "hasSubdivisionTypeEnum"
    let hasSubject = _prefixId.prefix "hasSubject"
    /// <summary>
    ///   <para>rdfs:comment : The subject type of the roadworks (i.e. on what the construction or maintenance work is being performed).^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubjectTypeOfWorks">dtx_srti:hasSubjectTypeOfWorks</a>
    /// </summary>
    let hasSubjectTypeOfWorks = _prefixId.prefix "hasSubjectTypeOfWorks"

    /// <summary>
    ///   <para>rdfs:comment : A collection of supplementary positional information which improves the precision of the location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSupplementaryPositionalDescription">dtx_srti:hasSupplementaryPositionalDescription</a>
    /// </summary>
    let hasSupplementaryPositionalDescription = _prefixId.prefix "hasSupplementaryPositionalDescription"

    /// <summary>
    ///   <para>rdfs:comment : Name of area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegAreaDescriptor">dtx_srti:hasTpegAreaDescriptor</a>
    /// </summary>
    let hasTpegAreaDescriptor = _prefixId.prefix "hasTpegAreaDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A geographic or geometric area defined by a TPEG-Loc structure which may include height information for additional geospatial discrimination.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegAreaLocation">dtx_srti:hasTpegAreaLocation</a>
    /// </summary>
    let hasTpegAreaLocation = _prefixId.prefix "hasTpegAreaLocation"
    /// <summary>
    ///   <para>rdfs:comment : A single non-junction point on the road network which is framed between two other specified points on the road network.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegFramedPoint">dtx_srti:hasTpegFramedPoint</a>
    /// </summary>
    let hasTpegFramedPoint = _prefixId.prefix "hasTpegFramedPoint"
    /// <summary>
    ///   <para>rdfs:comment : Height information which provides additional discrimination for the applicable area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegHeight">dtx_srti:hasTpegHeight</a>
    /// </summary>
    let hasTpegHeight = _prefixId.prefix "hasTpegHeight"
    /// <summary>
    ///   <para>rdfs:comment : A descriptor for describing a junction by identifying the intersecting roads at a road junction.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegIlcPointDescriptor">dtx_srti:hasTpegIlcPointDescriptor</a>
    /// </summary>
    let hasTpegIlcPointDescriptor = _prefixId.prefix "hasTpegIlcPointDescriptor"

    /// <summary>
    ///   <para>rdfs:comment : A name which identifies a junction point on the road network</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegJunctionPointDescriptor">dtx_srti:hasTpegJunctionPointDescriptor</a>
    /// </summary>
    let hasTpegJunctionPointDescriptor = _prefixId.prefix "hasTpegJunctionPointDescriptor"

    /// <summary>
    ///   <para>rdfs:comment : A linear section along a single road defined between two points on the same road by a TPEG-Loc structure.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegLinearLocation">dtx_srti:hasTpegLinearLocation</a>
    /// </summary>
    let hasTpegLinearLocation = _prefixId.prefix "hasTpegLinearLocation"
    /// <summary>
    ///   <para>rdfs:comment : A descriptive name which helps to identify the non-junction point. At least one descriptor must identify the road on which the point is located, i.e. must be of type 'linkName' or 'localLinkName'.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegOtherPointDescriptor">dtx_srti:hasTpegOtherPointDescriptor</a>
    /// </summary>
    let hasTpegOtherPointDescriptor = _prefixId.prefix "hasTpegOtherPointDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A single point defined by a coordinate set and TPEG descriptors.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPoint">dtx_srti:hasTpegPoint</a>
    /// </summary>
    let hasTpegPoint = _prefixId.prefix "hasTpegPoint"
    /// <summary>
    ///   <para>rdfs:comment : The location at the up stream end of the linear section of road.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointFrom">dtx_srti:hasTpegPointFrom</a>
    /// </summary>
    let hasTpegPointFrom = _prefixId.prefix "hasTpegPointFrom"
    /// <summary>
    ///   <para>rdfs:comment : PointLocation is associated to TpegPointLocation with cardinality 0..1</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointLocation">dtx_srti:hasTpegPointLocation</a>
    /// </summary>
    let hasTpegPointLocation = _prefixId.prefix "hasTpegPointLocation"
    /// <summary>
    ///   <para>rdfs:comment : The location at the down stream end of the linear section of road.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointTo">dtx_srti:hasTpegPointTo</a>
    /// </summary>
    let hasTpegPointTo = _prefixId.prefix "hasTpegPointTo"

    /// <summary>
    ///   <para>rdfs:comment : Types of the constriction to which traffic is subjected as a result of an event.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficConstrictionTypeEnum">dtx_srti:hasTrafficConstrictionTypeEnum</a>
    /// </summary>
    let hasTrafficConstrictionTypeEnum = _prefixId.prefix "hasTrafficConstrictionTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : The consistency (steadiness) of the traffic flow.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficFlowCharacteristicsEnum">dtx_srti:hasTrafficFlowCharacteristicsEnum</a>
    /// </summary>
    let hasTrafficFlowCharacteristicsEnum = _prefixId.prefix "hasTrafficFlowCharacteristicsEnum"

    /// <summary>
    ///   <para>rdfs:comment : A characterization of the trend in the traffic conditions at the specified location and direction.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficTrendTypeEnum">dtx_srti:hasTrafficTrendTypeEnum</a>
    /// </summary>
    let hasTrafficTrendTypeEnum = _prefixId.prefix "hasTrafficTrendTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Specification of validity, either explicitly or by a validity time period specification which may be discontinuous.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasValidity">dtx_srti:hasValidity</a>
    /// </summary>
    let hasValidity = _prefixId.prefix "hasValidity"
    /// <summary>
    ///   <para>rdfs:comment : Specification of validity, either explicitly overriding the validity time specification or confirming it.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasValidityStatus">dtx_srti:hasValidityStatus</a>
    /// </summary>
    let hasValidityStatus = _prefixId.prefix "hasValidityStatus"
    /// <summary>
    ///   <para>rdfs:comment : The characteristics of a vehicle, e.g. lorry of gross weight greater than 30 tonnes.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleCharacteristics">dtx_srti:hasVehicleCharacteristics</a>
    /// </summary>
    let hasVehicleCharacteristics = _prefixId.prefix "hasVehicleCharacteristics"
    /// <summary>
    ///   <para>rdfs:comment : Characterization of an obstruction on the road caused by one or more vehicles.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleObstructionTypeEnum">dtx_srti:hasVehicleObstructionTypeEnum</a>
    /// </summary>
    let hasVehicleObstructionTypeEnum = _prefixId.prefix "hasVehicleObstructionTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : Vehicle status.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleStatus">dtx_srti:hasVehicleStatus</a>
    /// </summary>
    let hasVehicleStatus = _prefixId.prefix "hasVehicleStatus"
    /// <summary>
    ///   <para>rdfs:comment : Vehicle type.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleTypeEnum">dtx_srti:hasVehicleTypeEnum</a>
    /// </summary>
    let hasVehicleTypeEnum = _prefixId.prefix "hasVehicleTypeEnum"
    /// <summary>
    ///   <para>rdfs:comment : The vehicle involved in the accident.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehiclesInvolved">dtx_srti:hasVehiclesInvolved</a>
    /// </summary>
    let hasVehiclesInvolved = _prefixId.prefix "hasVehiclesInvolved"
    /// <summary>
    ///   <para>rdfs:comment : Defines the horizontal position accuracy according EN 16803-1</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVerticalPositionAccuracy">dtx_srti:hasVerticalPositionAccuracy</a>
    /// </summary>
    let hasVerticalPositionAccuracy = _prefixId.prefix "hasVerticalPositionAccuracy"

    /// <summary>
    ///   <para>rdfs:comment : The type of road surface condition that is related to the weather which is affecting the driving conditions.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasWeatherRelatedRoadConditionTypeEnum">dtx_srti:hasWeatherRelatedRoadConditionTypeEnum</a>
    /// </summary>
    let hasWeatherRelatedRoadConditionTypeEnum = _prefixId.prefix "hasWeatherRelatedRoadConditionTypeEnum"

    /// <summary>
    ///   <para>rdfs:comment : Type of winter equipment management action instigated by operator.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasWinterEquipmentManagementType">dtx_srti:hasWinterEquipmentManagementType</a>
    /// </summary>
    let hasWinterEquipmentManagementType = _prefixId.prefix "hasWinterEquipmentManagementType"

    let hazardous = _prefixId.prefix "hazardous"
    let heavyTraffic = _prefixId.prefix "heavyTraffic"
    let heavyVehicleLane = _prefixId.prefix "heavyVehicleLane"
    /// <summary>
    ///   <para>rdfs:comment : A measurement of height in metres</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#height">dtx_srti:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    let heightRestrictionInOperation = _prefixId.prefix "heightRestrictionInOperation"
    /// <summary>
    ///   <para>rdfs:comment : Value in metres for the height measured vertically at to the planar coordinates the point corresponding.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heightValue">dtx_srti:heightValue</a>
    /// </summary>
    let heightValue = _prefixId.prefix "heightValue"
    let helicopterRescue = _prefixId.prefix "helicopterRescue"
    let herdOfAnimalsOnTheRoad = _prefixId.prefix "herdOfAnimalsOnTheRoad"
    let high = _prefixId.prefix "high"
    let highSidedVehicle = _prefixId.prefix "highSidedVehicle"
    let highest = _prefixId.prefix "highest"
    let hockeyGame = _prefixId.prefix "hockeyGame"
    let horseRaceMeeting = _prefixId.prefix "horseRaceMeeting"
    let ice = _prefixId.prefix "ice"
    let icyPatches = _prefixId.prefix "icyPatches"
    let impermissibleManoeuvre = _prefixId.prefix "impermissibleManoeuvre"
    /// <summary>
    ///   <para>rdfs:comment : For organizational purposes</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#importedDataProperties">dtx_srti:importedDataProperties</a>
    /// </summary>
    let importedDataProperties = _prefixId.prefix "importedDataProperties"
    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes. Imported object properties</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#importedObjectProperties">dtx_srti:importedObjectProperties</a>
    /// </summary>
    let importedObjectProperties = _prefixId.prefix "importedObjectProperties"
    let impossible = _prefixId.prefix "impossible"
    let improbable = _prefixId.prefix "improbable"
    let inBuiltUpAreas = _prefixId.prefix "inBuiltUpAreas"

    let inEmergencyWaitForPatrolService = _prefixId.prefix "inEmergencyWaitForPatrolService"

    let inForestedAreas = _prefixId.prefix "inForestedAreas"
    let inGalleries = _prefixId.prefix "inGalleries"
    let inGallery = _prefixId.prefix "inGallery"
    let inLowLyingAreas = _prefixId.prefix "inLowLyingAreas"
    let inRuralAreas = _prefixId.prefix "inRuralAreas"
    let inShadedAreas = _prefixId.prefix "inShadedAreas"
    let inTheCentre = _prefixId.prefix "inTheCentre"
    let inTheInnerCityAreas = _prefixId.prefix "inTheInnerCityAreas"
    let inTunnel = _prefixId.prefix "inTunnel"
    let inTunnels = _prefixId.prefix "inTunnels"
    let inbound = _prefixId.prefix "inbound"
    let inboundTowardsTown = _prefixId.prefix "inboundTowardsTown"
    let incident = _prefixId.prefix "incident"

    let increaseNormalFollowingDistance = _prefixId.prefix "increaseNormalFollowingDistance"

    let inductionLoopMonitoringStation = _prefixId.prefix "inductionLoopMonitoringStation"

    let industrialArea = _prefixId.prefix "industrialArea"
    let infant = _prefixId.prefix "infant"
    let infraredMonitoringStation = _prefixId.prefix "infraredMonitoringStation"
    let infrastructureFailure = _prefixId.prefix "infrastructureFailure"
    let innerRing = _prefixId.prefix "innerRing"
    let interchange = _prefixId.prefix "interchange"
    let intermittentShortTermClosures = _prefixId.prefix "intermittentShortTermClosures"
    let internalUse = _prefixId.prefix "internalUse"
    let internationalSportsMeeting = _prefixId.prefix "internationalSportsMeeting"
    let intersection = _prefixId.prefix "intersection"
    let intersectionName = _prefixId.prefix "intersectionName"
    /// <summary>
    ///   <para>rdfs:comment : It is location reference of ...</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#isLocationReferenceOf">dtx_srti:isLocationReferenceOf</a>
    /// </summary>
    let isLocationReferenceOf = _prefixId.prefix "isLocationReferenceOf"
    let jacknifed = _prefixId.prefix "jacknifed"
    let junction = _prefixId.prefix "junction"
    let junctionName = _prefixId.prefix "junctionName"
    let keepToTheLeft = _prefixId.prefix "keepToTheLeft"
    let keepToTheRight = _prefixId.prefix "keepToTheRight"
    let keepYourDistance = _prefixId.prefix "keepYourDistance"
    let laender = _prefixId.prefix "laender"
    let lake = _prefixId.prefix "lake"
    let lakeName = _prefixId.prefix "lakeName"
    let landmark = _prefixId.prefix "landmark"
    let landslips = _prefixId.prefix "landslips"
    let laneClosures = _prefixId.prefix "laneClosures"
    /// <summary>
    ///   <para>rdfs:comment : The number of the lane, where 1 is nearest the hard shoulder/verge and the numbers increase towards the central reservation/road axis.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#laneNumber">dtx_srti:laneNumber</a>
    /// </summary>
    let laneNumber = _prefixId.prefix "laneNumber"
    let lanesBlocked = _prefixId.prefix "lanesBlocked"
    let lanesDeviated = _prefixId.prefix "lanesDeviated"
    let lanesPartiallyObstructed = _prefixId.prefix "lanesPartiallyObstructed"
    let largeAnimalsOnTheRoad = _prefixId.prefix "largeAnimalsOnTheRoad"
    let largeArea = _prefixId.prefix "largeArea"
    let lau1Code = _prefixId.prefix "lau1Code"
    let lau2Code = _prefixId.prefix "lau2Code"
    let layBy = _prefixId.prefix "layBy"

    let leaveYourVehicleProceedToNextSafePlace = _prefixId.prefix "leaveYourVehicleProceedToNextSafePlace"

    let leavesOnRoad = _prefixId.prefix "leavesOnRoad"
    let left = _prefixId.prefix "left"
    let leftHandFeederRoad = _prefixId.prefix "leftHandFeederRoad"
    let leftHandParallelCarriageway = _prefixId.prefix "leftHandParallelCarriageway"
    let leftHandTurningLane = _prefixId.prefix "leftHandTurningLane"
    let leftLane = _prefixId.prefix "leftLane"
    /// <summary>
    ///   <para>rdfs:comment : This indicates the length (measured in metres) of carriageway (and lanes) affected by the associated traffic element.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lengthAffected">dtx_srti:lengthAffected</a>
    /// </summary>
    let lengthAffected = _prefixId.prefix "lengthAffected"
    let levelCrossing = _prefixId.prefix "levelCrossing"
    let lightingSystem = _prefixId.prefix "lightingSystem"
    let limitedVisibility = _prefixId.prefix "limitedVisibility"
    /// <summary>
    ///   <para>rdfs:comment : An identifier or code of a linear element (or link) in the road network reference model that is specified in the LinearElement class.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementIdentifier">dtx_srti:linearElementIdentifier</a>
    /// </summary>
    let linearElementIdentifier = _prefixId.prefix "linearElementIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : The identifier of a road network reference model which segments the road network according to specific business rules.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementReferenceModel">dtx_srti:linearElementReferenceModel</a>
    /// </summary>
    let linearElementReferenceModel = _prefixId.prefix "linearElementReferenceModel"

    /// <summary>
    ///   <para>rdfs:comment : The version of the identified road network reference model.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementReferenceModelVersion">dtx_srti:linearElementReferenceModelVersion</a>
    /// </summary>
    let linearElementReferenceModelVersion = _prefixId.prefix "linearElementReferenceModelVersion"

    let linkName = _prefixId.prefix "linkName"
    let localCouncil = _prefixId.prefix "localCouncil"
    let localLinkName = _prefixId.prefix "localLinkName"
    let localTrafficLane = _prefixId.prefix "localTrafficLane"
    /// <summary>
    ///   <para>rdfs:comment : Supplementary human-readable description of the location</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#locationDescription">dtx_srti:locationDescription</a>
    /// </summary>
    let locationDescription = _prefixId.prefix "locationDescription"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that the location is given with a precision which is better than the stated value in metres.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#locationPrecision">dtx_srti:locationPrecision</a>
    /// </summary>
    let locationPrecision = _prefixId.prefix "locationPrecision"
    let londonBorough = _prefixId.prefix "londonBorough"
    let longDelays = _prefixId.prefix "longDelays"
    let longHeavyLorry = _prefixId.prefix "longHeavyLorry"
    let longLoad = _prefixId.prefix "longLoad"
    let longTerm = _prefixId.prefix "longTerm"
    let longerThanSixHours = _prefixId.prefix "longerThanSixHours"
    let looseChippings = _prefixId.prefix "looseChippings"
    let looseSandOnRoad = _prefixId.prefix "looseSandOnRoad"
    let lorry = _prefixId.prefix "lorry"
    let low = _prefixId.prefix "low"
    let lowest = _prefixId.prefix "lowest"
    let mainCarriageway = _prefixId.prefix "mainCarriageway"

    let maintenanceVehiclesMergingIntoTrafficFlow = _prefixId.prefix "maintenanceVehiclesMergingIntoTrafficFlow"

    let maintenanceWork = _prefixId.prefix "maintenanceWork"
    let major = _prefixId.prefix "major"
    let majorEvent = _prefixId.prefix "majorEvent"
    let marathon = _prefixId.prefix "marathon"
    let market = _prefixId.prefix "market"
    let match_ = _prefixId.prefix "match"
    let measurementEquipment = _prefixId.prefix "measurementEquipment"
    let medianOfSamplesInATimePeriod = _prefixId.prefix "medianOfSamplesInATimePeriod"
    let medicalStaff = _prefixId.prefix "medicalStaff"
    let medium = _prefixId.prefix "medium"
    let mediumRoadworksScale = _prefixId.prefix "mediumRoadworksScale"
    let mediumTerm = _prefixId.prefix "mediumTerm"
    let memberOfThePublic = _prefixId.prefix "memberOfThePublic"
    let meteorologicalArea = _prefixId.prefix "meteorologicalArea"
    let metroStationName = _prefixId.prefix "metroStationName"
    let metropolitanArea = _prefixId.prefix "metropolitanArea"
    let metropolitanDepartment = _prefixId.prefix "metropolitanDepartment"
    let metropolitanDistrict = _prefixId.prefix "metropolitanDistrict"
    let metropolitanRegion = _prefixId.prefix "metropolitanRegion"
    let microwaveMonitoringStation = _prefixId.prefix "microwaveMonitoringStation"
    let middleLane = _prefixId.prefix "middleLane"
    let militaryConvoy = _prefixId.prefix "militaryConvoy"
    /// <summary>
    ///   <para>rdfs:comment : The minimum number of persons required in a vehicle in order for it to be allowed to transit the specified road section.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#minimumCarOccupancy">dtx_srti:minimumCarOccupancy</a>
    /// </summary>
    let minimumCarOccupancy = _prefixId.prefix "minimumCarOccupancy"
    let minor = _prefixId.prefix "minor"
    let mobile = _prefixId.prefix "mobile"
    let mobileTelephoneCaller = _prefixId.prefix "mobileTelephoneCaller"
    let moped = _prefixId.prefix "moped"
    let motorShow = _prefixId.prefix "motorShow"
    let motorSportRaceMeeting = _prefixId.prefix "motorSportRaceMeeting"
    let motorcycle = _prefixId.prefix "motorcycle"
    let motorcycleWithSideCar = _prefixId.prefix "motorcycleWithSideCar"
    let motorscooter = _prefixId.prefix "motorscooter"
    let motorway = _prefixId.prefix "motorway"
    let movingAverageOfSamples = _prefixId.prefix "movingAverageOfSamples"
    let mudOnRoad = _prefixId.prefix "mudOnRoad"
    let multipleCarriageway = _prefixId.prefix "multipleCarriageway"
    let multipleVehicleAccident = _prefixId.prefix "multipleVehicleAccident"
    let municipality = _prefixId.prefix "municipality"
    let narrowLanes = _prefixId.prefix "narrowLanes"
    let nationName = _prefixId.prefix "nationName"
    /// <summary>
    ///   <para>rdfs:comment : Identifier or name unique within the specified country.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nationalIdentifier">dtx_srti:nationalIdentifier</a>
    /// </summary>
    let nationalIdentifier = _prefixId.prefix "nationalIdentifier"
    let negative = _prefixId.prefix "negative"
    let negligible = _prefixId.prefix "negligible"
    let newRoadworksLayout = _prefixId.prefix "newRoadworksLayout"
    let noNakedFlames = _prefixId.prefix "noNakedFlames"
    let noOrientationOrUnknown = _prefixId.prefix "noOrientationOrUnknown"
    let noOvertaking = _prefixId.prefix "noOvertaking"
    let noRestriction = _prefixId.prefix "noRestriction"
    let noSmoking = _prefixId.prefix "noSmoking"
    let noStopping = _prefixId.prefix "noStopping"
    let noUturns = _prefixId.prefix "noUturns"
    let noiseProtection = _prefixId.prefix "noiseProtection"
    let nonLinkedPoint = _prefixId.prefix "nonLinkedPoint"
    let nonLinkedPointName = _prefixId.prefix "nonLinkedPointName"

    let nonPoliceEmergencyServicePatrol = _prefixId.prefix "nonPoliceEmergencyServicePatrol"

    let none = _prefixId.prefix "none"
    let normal = _prefixId.prefix "normal"
    let normalUrgency = _prefixId.prefix "normalUrgency"
    let northBound = _prefixId.prefix "northBound"
    let northEastBound = _prefixId.prefix "northEastBound"
    let northWestBound = _prefixId.prefix "northWestBound"
    let notKeepingASafeDistance = _prefixId.prefix "notKeepingASafeDistance"
    /// <summary>
    ///   <para>rdfs:comment : The number of inputs detected but not completed during the sampling or measurement period; e.g. vehicles detected entering but not exiting the detection zone.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfIncompleteInputs">dtx_srti:numberOfIncompleteInputs</a>
    /// </summary>
    let numberOfIncompleteInputs = _prefixId.prefix "numberOfIncompleteInputs"
    /// <summary>
    ///   <para>rdfs:comment : The number of input values used in the sampling or measurement period to determine the data value.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfInputValuesUsed">dtx_srti:numberOfInputValuesUsed</a>
    /// </summary>
    let numberOfInputValuesUsed = _prefixId.prefix "numberOfInputValuesUsed"
    /// <summary>
    ///   <para>rdfs:comment : The number of normally usable lanes on the carriageway which are now restricted either fully or partially (this may include the hard shoulder if it is normally available for operational use, e.g. in hard shoulder running schemes).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfLanesRestricted">dtx_srti:numberOfLanesRestricted</a>
    /// </summary>
    let numberOfLanesRestricted = _prefixId.prefix "numberOfLanesRestricted"
    /// <summary>
    ///   <para>rdfs:comment : The number of maintenance vehicles associated with the roadworks activities at the specified location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfMaintenanceVehicles">dtx_srti:numberOfMaintenanceVehicles</a>
    /// </summary>
    let numberOfMaintenanceVehicles = _prefixId.prefix "numberOfMaintenanceVehicles"
    /// <summary>
    ///   <para>rdfs:comment : Number of Obstructions. Not in SRTI profile</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfObstructions">dtx_srti:numberOfObstructions</a>
    /// </summary>
    let numberOfObstructions = _prefixId.prefix "numberOfObstructions"
    /// <summary>
    ///   <para>rdfs:comment : The number of usable lanes in the specified direction which remain fully operational (this may include the hard shoulder if it is being used as an operational lane).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfOperationalLanes">dtx_srti:numberOfOperationalLanes</a>
    /// </summary>
    let numberOfOperationalLanes = _prefixId.prefix "numberOfOperationalLanes"
    /// <summary>
    ///   <para>rdfs:comment : The number of subjects on which the roadworks (construction or maintenance) are being performed.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfSubjects">dtx_srti:numberOfSubjects</a>
    /// </summary>
    let numberOfSubjects = _prefixId.prefix "numberOfSubjects"
    /// <summary>
    ///   <para>rdfs:comment : The number of vehicles waiting in a queue.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfVehiclesWaiting">dtx_srti:numberOfVehiclesWaiting</a>
    /// </summary>
    let numberOfVehiclesWaiting = _prefixId.prefix "numberOfVehiclesWaiting"
    let nuts1Code = _prefixId.prefix "nuts1Code"
    let nuts2Code = _prefixId.prefix "nuts2Code"
    let nuts3Code = _prefixId.prefix "nuts3Code"
    /// <summary>
    ///   <para>rdfs:comment : The NUTS code for the named area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nutsCode">dtx_srti:nutsCode</a>
    /// </summary>
    let nutsCode = _prefixId.prefix "nutsCode"
    let objectOnTheRoad = _prefixId.prefix "objectOnTheRoad"
    let observeAmberAlert = _prefixId.prefix "observeAmberAlert"
    let observeSignals = _prefixId.prefix "observeSignals"
    let observeSigns = _prefixId.prefix "observeSigns"
    let observeSpeedLimits = _prefixId.prefix "observeSpeedLimits"
    let obstacleSignalling = _prefixId.prefix "obstacleSignalling"
    let obstruction = _prefixId.prefix "obstruction"
    /// <summary>
    ///   <para>rdfs:comment : The non-negative offset distance from the ALERT-C referenced point to the actual point. The ALERT-C locations in the primary and secondary locations must always encompass the linear section being specified, thus offset distance is towards the other point.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#offsetDistance">dtx_srti:offsetDistance</a>
    /// </summary>
    let offsetDistance = _prefixId.prefix "offsetDistance"
    let oilOnRoad = _prefixId.prefix "oilOnRoad"
    let onBorder = _prefixId.prefix "onBorder"
    let onBridge = _prefixId.prefix "onBridge"
    let onBridges = _prefixId.prefix "onBridges"
    let onConnector = _prefixId.prefix "onConnector"
    let onDownhillSections = _prefixId.prefix "onDownhillSections"
    let onElevatedSection = _prefixId.prefix "onElevatedSection"
    let onElevatedSections = _prefixId.prefix "onElevatedSections"
    let onEnteringOrLeavingTunnels = _prefixId.prefix "onEnteringOrLeavingTunnels"
    let onFire = _prefixId.prefix "onFire"
    let onFlyover = _prefixId.prefix "onFlyover"
    let onFlyovers = _prefixId.prefix "onFlyovers"
    let onIceRoad = _prefixId.prefix "onIceRoad"
    let onLevelCrossing = _prefixId.prefix "onLevelCrossing"
    let onLinkRoad = _prefixId.prefix "onLinkRoad"
    let onPass = _prefixId.prefix "onPass"
    let onPasses = _prefixId.prefix "onPasses"
    let onRoadOrUnknown = _prefixId.prefix "onRoadOrUnknown"
    let onRoundabout = _prefixId.prefix "onRoundabout"
    let onTheLeft = _prefixId.prefix "onTheLeft"
    let onTheRight = _prefixId.prefix "onTheRight"
    let onTheRoadway = _prefixId.prefix "onTheRoadway"
    let onTheWrongSideOfTheRoad = _prefixId.prefix "onTheWrongSideOfTheRoad"
    let onUndergroundSection = _prefixId.prefix "onUndergroundSection"
    let onUndergroundSections = _prefixId.prefix "onUndergroundSections"
    let onUnderpass = _prefixId.prefix "onUnderpass"
    let onUnderpasses = _prefixId.prefix "onUnderpasses"

    let onlyTravelIfAbsolutelyNecessary = _prefixId.prefix "onlyTravelIfAbsolutelyNecessary"

    /// <summary>
    ///   <para>rdfs:comment : Defines the bearing field as an integer value between 0 and 359</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrBearing">dtx_srti:openlrBearing</a>
    /// </summary>
    let openlrBearing = _prefixId.prefix "openlrBearing"
    /// <summary>
    ///   <para>rdfs:comment : The DNP attribute measures the distance in meters between two consecutive location reference-points along the location reference path described in the corresponding enumeration</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrDistanceToNextLRPoint">dtx_srti:openlrDistanceToNextLRPoint</a>
    /// </summary>
    let openlrDistanceToNextLRPoint = _prefixId.prefix "openlrDistanceToNextLRPoint"
    /// <summary>
    ///   <para>rdfs:comment : The negative offset along the line of the location measured along the line reference path between the end point of the location reference and the ending node of the line reference path.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNegativeOffset">dtx_srti:openlrNegativeOffset</a>
    /// </summary>
    let openlrNegativeOffset = _prefixId.prefix "openlrNegativeOffset"
    /// <summary>
    ///   <para>rdfs:comment : The number that the base rectangle should be multiplied in the east direction</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNumColumns">dtx_srti:openlrNumColumns</a>
    /// </summary>
    let openlrNumColumns = _prefixId.prefix "openlrNumColumns"
    /// <summary>
    ///   <para>rdfs:comment : The number that the base rectangle should be multiplied in the north direction</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNumRows">dtx_srti:openlrNumRows</a>
    /// </summary>
    let openlrNumRows = _prefixId.prefix "openlrNumRows"
    /// <summary>
    ///   <para>rdfs:comment : The positive offset along the line of the location measured along the line reference path between the start point of the location reference and the starting node of the line reference path.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrPositiveOffset">dtx_srti:openlrPositiveOffset</a>
    /// </summary>
    let openlrPositiveOffset = _prefixId.prefix "openlrPositiveOffset"
    /// <summary>
    ///   <para>rdfs:comment : The radius of the corresponding circular area.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrRadius">dtx_srti:openlrRadius</a>
    /// </summary>
    let openlrRadius = _prefixId.prefix "openlrRadius"
    let opposite = _prefixId.prefix "opposite"
    let oppositeCarriageway = _prefixId.prefix "oppositeCarriageway"
    let order1AdministrativeArea = _prefixId.prefix "order1AdministrativeArea"
    let order2AdministrativeArea = _prefixId.prefix "order2AdministrativeArea"
    let order3AdministrativeArea = _prefixId.prefix "order3AdministrativeArea"
    let order4AdministrativeArea = _prefixId.prefix "order4AdministrativeArea"
    let order5AdministrativeArea = _prefixId.prefix "order5AdministrativeArea"
    /// <summary>
    ///   <para>rdfs:comment : Normal number of lanes, potentially available for moving traffic, before reduction due to situations. Hard shoulder should not be counted unless it is sometimes used operationally for moving traffic.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#originalNumberOfLanes">dtx_srti:originalNumberOfLanes</a>
    /// </summary>
    let originalNumberOfLanes = _prefixId.prefix "originalNumberOfLanes"
    let other = _prefixId.prefix "other"
    let otherOfficialVehicle = _prefixId.prefix "otherOfficialVehicle"
    let outOfRange = _prefixId.prefix "outOfRange"
    let outbound = _prefixId.prefix "outbound"
    let outboundFromTown = _prefixId.prefix "outboundFromTown"
    let outerRing = _prefixId.prefix "outerRing"
    let overCrestOfHill = _prefixId.prefix "overCrestOfHill"
    let overnightClosures = _prefixId.prefix "overnightClosures"
    let overseasDepartment = _prefixId.prefix "overseasDepartment"
    let overseasRegion = _prefixId.prefix "overseasRegion"

    let overseasTerritorialCollectivity = _prefixId.prefix "overseasTerritorialCollectivity"

    let overtakeWithCare = _prefixId.prefix "overtakeWithCare"
    let overtakingLane = _prefixId.prefix "overtakingLane"
    let overturned = _prefixId.prefix "overturned"
    let parade = _prefixId.prefix "parade"
    let parallelCarriageway = _prefixId.prefix "parallelCarriageway"
    let parish = _prefixId.prefix "parish"
    let parkAndRideSite = _prefixId.prefix "parkAndRideSite"
    let parkingFacilityName = _prefixId.prefix "parkingFacilityName"
    let passableWithCare = _prefixId.prefix "passableWithCare"
    let pedestrianInRoad = _prefixId.prefix "pedestrianInRoad"
    let peopleOnRoadway = _prefixId.prefix "peopleOnRoadway"
    /// <summary>
    ///   <para>rdfs:comment : A measure of distance along a linear element from the start of the element expressed as a percentage of the total length of the linear object.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#percentageDistanceAlong">dtx_srti:percentageDistanceAlong</a>
    /// </summary>
    let percentageDistanceAlong = _prefixId.prefix "percentageDistanceAlong"
    let petrolOnRoad = _prefixId.prefix "petrolOnRoad"
    let planned = _prefixId.prefix "planned"
    let pointName = _prefixId.prefix "pointName"
    let pointOfInterestName = _prefixId.prefix "pointOfInterestName"
    let policeForceControlArea = _prefixId.prefix "policeForceControlArea"
    let policeForceControlAreaName = _prefixId.prefix "policeForceControlAreaName"
    let policePatrol = _prefixId.prefix "policePatrol"
    let policeSpeedChecksInOperation = _prefixId.prefix "policeSpeedChecksInOperation"
    let policeman = _prefixId.prefix "policeman"
    let politician = _prefixId.prefix "politician"
    let poorLaneAdherence = _prefixId.prefix "poorLaneAdherence"
    let poorMergeEntryOrExitJudgement = _prefixId.prefix "poorMergeEntryOrExitJudgement"
    let poorRoadSurfaceCondition = _prefixId.prefix "poorRoadSurfaceCondition"
    let poorSurfaceAdherence = _prefixId.prefix "poorSurfaceAdherence"
    let poorWeather = _prefixId.prefix "poorWeather"
    let positive = _prefixId.prefix "positive"
    let privateBreakdownService = _prefixId.prefix "privateBreakdownService"
    let probable = _prefixId.prefix "probable"
    let problemsAtBorderPost = _prefixId.prefix "problemsAtBorderPost"
    let problemsAtCustomPost = _prefixId.prefix "problemsAtCustomPost"
    let problemsOnLocalRoads = _prefixId.prefix "problemsOnLocalRoads"
    let procession = _prefixId.prefix "procession"
    let province = _prefixId.prefix "province"
    let publicAndPrivateUtilities = _prefixId.prefix "publicAndPrivateUtilities"
    /// <summary>
    ///   <para>rdfs:comment : Describes an available public transport alternative to the normal route</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicTransportAlternative">dtx_srti:publicTransportAlternative</a>
    /// </summary>
    let publicTransportAlternative = _prefixId.prefix "publicTransportAlternative"
    let publicTransportPassenger = _prefixId.prefix "publicTransportPassenger"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the publication creator using an international identifier</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicationCreator">dtx_srti:publicationCreator</a>
    /// </summary>
    let publicationCreator = _prefixId.prefix "publicationCreator"
    /// <summary>
    ///   <para>rdfs:comment : Date/time at which the payload publication was created.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicationTime">dtx_srti:publicationTime</a>
    /// </summary>
    let publicationTime = _prefixId.prefix "publicationTime"
    let pullOverToTheEdgeOfTheRoadway = _prefixId.prefix "pullOverToTheEdgeOfTheRoadway"
    let quarter = _prefixId.prefix "quarter"
    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes. Qudt object properties</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#qudtObjectProperties">dtx_srti:qudtObjectProperties</a>
    /// </summary>
    let qudtObjectProperties = _prefixId.prefix "qudtObjectProperties"
    /// <summary>
    ///   <para>rdfs:comment : The length of a queue or the average length of queues in separate lanes due to a situation.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#queueLength">dtx_srti:queueLength</a>
    /// </summary>
    let queueLength = _prefixId.prefix "queueLength"
    let queuingTraffic = _prefixId.prefix "queuingTraffic"
    let raceMeeting = _prefixId.prefix "raceMeeting"
    /// <summary>
    ///   <para>rdfs:comment : The radius of the corresponding circular area</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#radius">dtx_srti:radius</a>
    /// </summary>
    let radius = _prefixId.prefix "radius"
    let railCrash = _prefixId.prefix "railCrash"
    let railwayStation = _prefixId.prefix "railwayStation"
    let rain = _prefixId.prefix "rain"
    let rampMeteringInOperation = _prefixId.prefix "rampMeteringInOperation"
    let real = _prefixId.prefix "real"
    /// <summary>
    ///   <para>rdfs:comment : The reason why the value is deemed to be erroneous by the supplier.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reasonForDataError">dtx_srti:reasonForDataError</a>
    /// </summary>
    let reasonForDataError = _prefixId.prefix "reasonForDataError"
    let reduceYourSpeed = _prefixId.prefix "reduceYourSpeed"
    let referenceMarker = _prefixId.prefix "referenceMarker"
    /// <summary>
    ///   <para>rdfs:comment : Description of the referent.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentDescription">dtx_srti:referentDescription</a>
    /// </summary>
    let referentDescription = _prefixId.prefix "referentDescription"
    /// <summary>
    ///   <para>rdfs:comment : The identifier of the referent, unique on the specified linear element (i.e. road or part of).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentIdentifier">dtx_srti:referentIdentifier</a>
    /// </summary>
    let referentIdentifier = _prefixId.prefix "referentIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : The name of the referent, e.g. a junction or intersection name.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentName">dtx_srti:referentName</a>
    /// </summary>
    let referentName = _prefixId.prefix "referentName"
    let region = _prefixId.prefix "region"
    let regionName = _prefixId.prefix "regionName"
    let registeredMotoristObserver = _prefixId.prefix "registeredMotoristObserver"
    let relativeHeight = _prefixId.prefix "relativeHeight"
    /// <summary>
    ///   <para>rdfs:comment : An indication as to whether the source deems the associated information to be reliable/correct. "True" indicates it is deemed reliable.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reliable">dtx_srti:reliable</a>
    /// </summary>
    let reliable = _prefixId.prefix "reliable"
    let repairWork = _prefixId.prefix "repairWork"
    let republic = _prefixId.prefix "republic"
    let republicanCity = _prefixId.prefix "republicanCity"
    let rescueAndRecoveryWork = _prefixId.prefix "rescueAndRecoveryWork"
    /// <summary>
    ///   <para>rdfs:comment : The width of lanes after any lane narrowing^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#residualLaneWidth">dtx_srti:residualLaneWidth</a>
    /// </summary>
    let residualLaneWidth = _prefixId.prefix "residualLaneWidth"
    /// <summary>
    ///   <para>rdfs:comment : The total width of the combined operational lanes in the specified direction.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#residualRoadWidth">dtx_srti:residualRoadWidth</a>
    /// </summary>
    let residualRoadWidth = _prefixId.prefix "residualRoadWidth"
    let restrictedToAuthorities = _prefixId.prefix "restrictedToAuthorities"

    let restrictedToAuthoritiesAndTrafficOperators = _prefixId.prefix "restrictedToAuthoritiesAndTrafficOperators"

    let restrictedToAuthoritiesTrafficOperatorsAndPublishers = _prefixId.prefix "restrictedToAuthoritiesTrafficOperatorsAndPublishers"

    let restrictedToAuthoritiesTrafficOperatorsAndVms = _prefixId.prefix "restrictedToAuthoritiesTrafficOperatorsAndVms"

    let resurfacingWork = _prefixId.prefix "resurfacingWork"
    let right = _prefixId.prefix "right"
    let rightHandFeederRoad = _prefixId.prefix "rightHandFeederRoad"
    let rightHandParallelCarriageway = _prefixId.prefix "rightHandParallelCarriageway"
    let rightHandTurningLane = _prefixId.prefix "rightHandTurningLane"
    let rightLane = _prefixId.prefix "rightLane"
    let riskOf = _prefixId.prefix "riskOf"
    let riverName = _prefixId.prefix "riverName"
    let road = _prefixId.prefix "road"
    let roadAuthorities = _prefixId.prefix "roadAuthorities"
    let roadBlocked = _prefixId.prefix "roadBlocked"
    let roadCleared = _prefixId.prefix "roadCleared"
    let roadClosed = _prefixId.prefix "roadClosed"
    /// <summary>
    ///   <para>rdfs:comment : A destination associated with this road.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadDestination">dtx_srti:roadDestination</a>
    /// </summary>
    let roadDestination = _prefixId.prefix "roadDestination"
    let roadMarkingWork = _prefixId.prefix "roadMarkingWork"
    /// <summary>
    ///   <para>rdfs:comment : Name of the road</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadName">dtx_srti:roadName</a>
    /// </summary>
    let roadName = _prefixId.prefix "roadName"
    let roadNode = _prefixId.prefix "roadNode"
    let roadOperatorControlArea = _prefixId.prefix "roadOperatorControlArea"
    let roadOperatorPatrol = _prefixId.prefix "roadOperatorPatrol"
    let roadPartiallyObstructed = _prefixId.prefix "roadPartiallyObstructed"
    let roadSection = _prefixId.prefix "roadSection"
    let roadSigns = _prefixId.prefix "roadSigns"
    let roadSurfaceInPoorCondition = _prefixId.prefix "roadSurfaceInPoorCondition"
    let roadsideDrains = _prefixId.prefix "roadsideDrains"
    let roadsideEmbankment = _prefixId.prefix "roadsideEmbankment"
    let roadsideEquipment = _prefixId.prefix "roadsideEquipment"
    let roadsideEvent = _prefixId.prefix "roadsideEvent"
    let roadsideTelephoneCaller = _prefixId.prefix "roadsideTelephoneCaller"
    /// <summary>
    ///   <para>rdfs:comment : An external identifier for the roadworks</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadworksIdentifier">dtx_srti:roadworksIdentifier</a>
    /// </summary>
    let roadworksIdentifier = _prefixId.prefix "roadworksIdentifier"
    let rockfalls = _prefixId.prefix "rockfalls"
    let rollingRoadBlock = _prefixId.prefix "rollingRoadBlock"
    let roundabout = _prefixId.prefix "roundabout"
    let rugbyMatch = _prefixId.prefix "rugbyMatch"
    let ruralCounty = _prefixId.prefix "ruralCounty"
    let rushHourLane = _prefixId.prefix "rushHourLane"
    let rushHourLaneInOperation = _prefixId.prefix "rushHourLaneInOperation"
    /// <summary>
    ///   <para>rdfs:comment : Indicates, whether this SituationRecord specifies a safety related message according to Commission Delegated Regulation (EU) No 886/2013.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#safetyRelatedMessage">dtx_srti:safetyRelatedMessage</a>
    /// </summary>
    let safetyRelatedMessage = _prefixId.prefix "safetyRelatedMessage"
    let safetyServices = _prefixId.prefix "safetyServices"
    let saltAndGritSpreading = _prefixId.prefix "saltAndGritSpreading"
    let sandStorms = _prefixId.prefix "sandStorms"
    let sea = _prefixId.prefix "sea"
    let seaName = _prefixId.prefix "seaName"
    let securityExercise = _prefixId.prefix "securityExercise"
    let securityIncident = _prefixId.prefix "securityIncident"
    let segment = _prefixId.prefix "segment"
    let selfGovernedPart = _prefixId.prefix "selfGovernedPart"
    /// <summary>
    ///   <para>rdfs:comment : Half of length of the major axis, i.e. distance between the centre point and major axis point of the position accuracy ellipse.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisLength">dtx_srti:semiMajorAxisLength</a>
    /// </summary>
    let semiMajorAxisLength = _prefixId.prefix "semiMajorAxisLength"
    /// <summary>
    ///   <para>rdfs:comment : Orientation direction of the ellipse major axis of the position accuracy ellipse with regards to the geographic north.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisOrientation">dtx_srti:semiMajorAxisOrientation</a>
    /// </summary>
    let semiMajorAxisOrientation = _prefixId.prefix "semiMajorAxisOrientation"
    /// <summary>
    ///   <para>rdfs:comment : Indicates whether the ellipse orientation is unavailable (True) or not (False)</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisOrientationError">dtx_srti:semiMajorAxisOrientationError</a>
    /// </summary>
    let semiMajorAxisOrientationError = _prefixId.prefix "semiMajorAxisOrientationError"
    /// <summary>
    ///   <para>rdfs:comment : Half of length of the minor axis, i.e. distance between the centre point and minor axis point of the position accuracy ellipse</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMinorAxisLength">dtx_srti:semiMinorAxisLength</a>
    /// </summary>
    let semiMinorAxisLength = _prefixId.prefix "semiMinorAxisLength"
    /// <summary>
    ///   <para>rdfs:comment : The sequential number of an exit/entrance ramp from a given location in a given direction (normally used to indicate a specific exit/entrance in a complex junction/intersection).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sequentialRampNumber">dtx_srti:sequentialRampNumber</a>
    /// </summary>
    let sequentialRampNumber = _prefixId.prefix "sequentialRampNumber"
    let serviceAreaName = _prefixId.prefix "serviceAreaName"
    let serviceRoad = _prefixId.prefix "serviceRoad"
    let setDownArea = _prefixId.prefix "setDownArea"
    let severalMajorEvents = _prefixId.prefix "severalMajorEvents"
    let shedLoad = _prefixId.prefix "shedLoad"
    let shortTerm = _prefixId.prefix "shortTerm"
    let show = _prefixId.prefix "show"
    let showJumping = _prefixId.prefix "showJumping"
    let sickPerson = _prefixId.prefix "sickPerson"
    let singleAlternateLineTraffic = _prefixId.prefix "singleAlternateLineTraffic"
    let singleCarriageway = _prefixId.prefix "singleCarriageway"

    /// <summary>
    ///   <para>rdfs:comment : A unique alphanumeric reference (e.g. an external reference or a UUID) of the SituationRecord object (the first version of the record) that was created by the original supplier.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordCreationReference">dtx_srti:situationRecordCreationReference</a>
    /// </summary>
    let situationRecordCreationReference = _prefixId.prefix "situationRecordCreationReference"

    /// <summary>
    ///   <para>rdfs:comment : The date/time that the SituationRecord object (the first version of the record) was created by the original supplier.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordCreationTime">dtx_srti:situationRecordCreationTime</a>
    /// </summary>
    let situationRecordCreationTime = _prefixId.prefix "situationRecordCreationTime"

    /// <summary>
    ///   <para>rdfs:comment : The date/time that the current version of the Situation Record was written into the database of the original supplier in the supply chain.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordFirstSupplierVersionTime">dtx_srti:situationRecordFirstSupplierVersionTime</a>
    /// </summary>
    let situationRecordFirstSupplierVersionTime = _prefixId.prefix "situationRecordFirstSupplierVersionTime"

    let situationRecordObservationTime = _prefixId.prefix "situationRecordObservationTime"

    /// <summary>
    ///   <para>rdfs:comment : Version of Situation Record</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordVersion">dtx_srti:situationRecordVersion</a>
    /// </summary>
    let situationRecordVersion = _prefixId.prefix "situationRecordVersion"
    /// <summary>
    ///   <para>rdfs:comment : The date/time that this current version of the SituationRecord within the situation was written into the database of the supplier which is involved in the data exchange. Identity and version of record are defined by the class stereotype implementation.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordVersionTime">dtx_srti:situationRecordVersionTime</a>
    /// </summary>
    let situationRecordVersionTime = _prefixId.prefix "situationRecordVersionTime"
    /// <summary>
    ///   <para>rdfs:comment : For organizational purposes</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#skosDataProperties">dtx_srti:skosDataProperties</a>
    /// </summary>
    let skosDataProperties = _prefixId.prefix "skosDataProperties"
    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes. Skos object properties</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#skosObjectProperties">dtx_srti:skosObjectProperties</a>
    /// </summary>
    let skosObjectProperties = _prefixId.prefix "skosObjectProperties"
    let slipRoad = _prefixId.prefix "slipRoad"
    let slipRoads = _prefixId.prefix "slipRoads"
    let slipperyRoad = _prefixId.prefix "slipperyRoad"
    let slowMoving = _prefixId.prefix "slowMoving"
    let slowTraffic = _prefixId.prefix "slowTraffic"
    let slowVehicle = _prefixId.prefix "slowVehicle"
    let slowVehicleLane = _prefixId.prefix "slowVehicleLane"
    let smokeHazard = _prefixId.prefix "smokeHazard"
    let smoothFlow = _prefixId.prefix "smoothFlow"
    /// <summary>
    ///   <para>rdfs:comment : Coefficient required when a moving average is computed to give specific weights to the former average and the new data. A typical formula is, F being the smoothing factor: New average = (old average) F + (new data) (1 - F).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#smoothingFactor">dtx_srti:smoothingFactor</a>
    /// </summary>
    let smoothingFactor = _prefixId.prefix "smoothingFactor"
    let snowClearing = _prefixId.prefix "snowClearing"
    let snowDrifts = _prefixId.prefix "snowDrifts"
    let snowFall = _prefixId.prefix "snowFall"
    let snowploughsInUse = _prefixId.prefix "snowploughsInUse"
    /// <summary>
    ///   <para>rdfs:comment : EN ISO 3166-1 two-character country code of the source of the information.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceCountry">dtx_srti:sourceCountry</a>
    /// </summary>
    let sourceCountry = _prefixId.prefix "sourceCountry"
    /// <summary>
    ///   <para>rdfs:comment : Language independent textual code or identifier for the organisation or the equipment that has produced the information.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceIdentification">dtx_srti:sourceIdentification</a>
    /// </summary>
    let sourceIdentification = _prefixId.prefix "sourceIdentification"
    /// <summary>
    ///   <para>rdfs:comment : The name of the organisation which has produced the information relating to this version of the information.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceName">dtx_srti:sourceName</a>
    /// </summary>
    let sourceName = _prefixId.prefix "sourceName"
    /// <summary>
    ///   <para>rdfs:comment : Information about the technology used for measuring the data or the method used for obtaining qualitative descriptions relating to this version of the information.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceType">dtx_srti:sourceType</a>
    /// </summary>
    let sourceType = _prefixId.prefix "sourceType"
    let southBound = _prefixId.prefix "southBound"
    let southEastBound = _prefixId.prefix "southEastBound"
    let southWestBound = _prefixId.prefix "southWestBound"
    let specialMunicipality = _prefixId.prefix "specialMunicipality"
    /// <summary>
    ///   <para>rdfs:comment : Unique code within the ALERT-C location table which identifies the specific point, linear or area location.^^xsd:string</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#specificLocation">dtx_srti:specificLocation</a>
    /// </summary>
    let specificLocation = _prefixId.prefix "specificLocation"
    /// <summary>
    ///   <para>rdfs:comment : Speed of the mobile entity.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#speed">dtx_srti:speed</a>
    /// </summary>
    let speed = _prefixId.prefix "speed"
    let spillageOnTheRoad = _prefixId.prefix "spillageOnTheRoad"
    let sportsMeeting = _prefixId.prefix "sportsMeeting"
    let spotterAircraft = _prefixId.prefix "spotterAircraft"
    let spunAround = _prefixId.prefix "spunAround"
    /// <summary>
    ///   <para>rdfs:comment : Provides the size of the tuple of coordinates of each point. This number is 2 or 3. By default when omitted the dimension shall be interpreted as 2.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#srsDimension">dtx_srti:srsDimension</a>
    /// </summary>
    let srsDimension = _prefixId.prefix "srsDimension"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the Coordinate Reference System (CRS) used to interpret the coordinates in this GmlLineString</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#srsName">dtx_srti:srsName</a>
    /// </summary>
    let srsName = _prefixId.prefix "srsName"
    /// <summary>
    ///   <para>rdfs:comment : The standard deviation of the sample of input values from which this value was derived, measured in the units of the data value.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#standardDeviation">dtx_srti:standardDeviation</a>
    /// </summary>
    let standardDeviation = _prefixId.prefix "standardDeviation"
    let state = _prefixId.prefix "state"
    let stateOccasion = _prefixId.prefix "stateOccasion"
    let stationary = _prefixId.prefix "stationary"
    let stationaryTraffic = _prefixId.prefix "stationaryTraffic"
    let stopAndGo = _prefixId.prefix "stopAndGo"
    let stopAtNextSafePlace = _prefixId.prefix "stopAtNextSafePlace"
    let stopAtNextServiceArea = _prefixId.prefix "stopAtNextServiceArea"
    let stoppingToServiceEquipments = _prefixId.prefix "stoppingToServiceEquipments"
    let stormForceWinds = _prefixId.prefix "stormForceWinds"
    let strongGustsOfWinds = _prefixId.prefix "strongGustsOfWinds"
    let strongWinds = _prefixId.prefix "strongWinds"
    let subsidence = _prefixId.prefix "subsidence"
    /// <summary>
    ///   <para>rdfs:comment : A measure of data quality assigned to the value by the supplier. 100% equates to ideal/perfect quality. The method of calculation is supplier specific and needs to be agreed between supplier and client.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#supplierCalculatedDataQuality">dtx_srti:supplierCalculatedDataQuality</a>
    /// </summary>
    let supplierCalculatedDataQuality = _prefixId.prefix "supplierCalculatedDataQuality"
    let surfaceWater = _prefixId.prefix "surfaceWater"
    let suspended = _prefixId.prefix "suspended"
    let swarmOfInsects = _prefixId.prefix "swarmOfInsects"
    let switchOffEngine = _prefixId.prefix "switchOffEngine"

    let switchOffMobilePhonesAndTwoWayRadios = _prefixId.prefix "switchOffMobilePhonesAndTwoWayRadios"

    let tanker = _prefixId.prefix "tanker"
    let technicalExercise = _prefixId.prefix "technicalExercise"
    /// <summary>
    ///   <para>rdfs:comment : Temporary limit defining the maximum advisory or mandatory speed of vehicles.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#temporarySpeedLimit">dtx_srti:temporarySpeedLimit</a>
    /// </summary>
    let temporarySpeedLimit = _prefixId.prefix "temporarySpeedLimit"
    let temporaryTrafficLights = _prefixId.prefix "temporaryTrafficLights"
    let tennisTournament = _prefixId.prefix "tennisTournament"
    let territorialUnit = _prefixId.prefix "territorialUnit"
    let territory = _prefixId.prefix "territory"
    let terrorism = _prefixId.prefix "terrorism"
    let test = _prefixId.prefix "test"
    let testYourBrakes = _prefixId.prefix "testYourBrakes"
    let threeWheeledVehicle = _prefixId.prefix "threeWheeledVehicle"
    let throughTrafficLane = _prefixId.prefix "throughTrafficLane"
    let tidalFlowLane = _prefixId.prefix "tidalFlowLane"
    let tidalFlowLaneInOperation = _prefixId.prefix "tidalFlowLaneInOperation"
    let tidalRiverName = _prefixId.prefix "tidalRiverName"
    /// <summary>
    ///   <para>rdfs:comment : For organizational purposes</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#timeDataProperties">dtx_srti:timeDataProperties</a>
    /// </summary>
    let timeDataProperties = _prefixId.prefix "timeDataProperties"
    /// <summary>
    ///   <para>rdfs:comment : Only for organizational purposes. Time object properties</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#timeObjectProperties">dtx_srti:timeObjectProperties</a>
    /// </summary>
    let timeObjectProperties = _prefixId.prefix "timeObjectProperties"
    let tollGate = _prefixId.prefix "tollGate"
    let tollGatesOpen = _prefixId.prefix "tollGatesOpen"
    let touristArea = _prefixId.prefix "touristArea"
    let tournament = _prefixId.prefix "tournament"
    let townName = _prefixId.prefix "townName"
    /// <summary>
    ///   <para>rdfs:comment : The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegAreaDescriptorType">dtx_srti:tpegAreaDescriptorType</a>
    /// </summary>
    let tpegAreaDescriptorType = _prefixId.prefix "tpegAreaDescriptorType"
    /// <summary>
    ///   <para>rdfs:comment : The type of TPEG location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegAreaLocationType">dtx_srti:tpegAreaLocationType</a>
    /// </summary>
    let tpegAreaLocationType = _prefixId.prefix "tpegAreaLocationType"
    /// <summary>
    ///   <para>rdfs:comment : The direction of traffic flow.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegDirection">dtx_srti:tpegDirection</a>
    /// </summary>
    let tpegDirection = _prefixId.prefix "tpegDirection"
    /// <summary>
    ///   <para>rdfs:comment : The type of TPEG location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegFramedPointLocationType">dtx_srti:tpegFramedPointLocationType</a>
    /// </summary>
    let tpegFramedPointLocationType = _prefixId.prefix "tpegFramedPointLocationType"
    /// <summary>
    ///   <para>rdfs:comment : A descriptive identification of relative height using TPEG-Loc location referencing.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegHeightType">dtx_srti:tpegHeightType</a>
    /// </summary>
    let tpegHeightType = _prefixId.prefix "tpegHeightType"
    let tpegIlcName1 = _prefixId.prefix "tpegIlcName1"
    let tpegIlcName2 = _prefixId.prefix "tpegIlcName2"
    let tpegIlcName3 = _prefixId.prefix "tpegIlcName3"
    /// <summary>
    ///   <para>rdfs:comment : The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcPointDescriptorType">dtx_srti:tpegIlcPointDescriptorType</a>
    /// </summary>
    let tpegIlcPointDescriptorType = _prefixId.prefix "tpegIlcPointDescriptorType"

    /// <summary>
    ///   <para>rdfs:comment : The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegJunctionPointDescriptorType">dtx_srti:tpegJunctionPointDescriptorType</a>
    /// </summary>
    let tpegJunctionPointDescriptorType = _prefixId.prefix "tpegJunctionPointDescriptorType"

    /// <summary>
    ///   <para>rdfs:comment : The type of TPEG location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegLinearLocationType">dtx_srti:tpegLinearLocationType</a>
    /// </summary>
    let tpegLinearLocationType = _prefixId.prefix "tpegLinearLocationType"
    /// <summary>
    ///   <para>rdfs:comment : The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegOtherPointDescriptorType">dtx_srti:tpegOtherPointDescriptorType</a>
    /// </summary>
    let tpegOtherPointDescriptorType = _prefixId.prefix "tpegOtherPointDescriptorType"
    /// <summary>
    ///   <para>rdfs:comment : The type of TPEG location.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegSimplePointLocationType">dtx_srti:tpegSimplePointLocationType</a>
    /// </summary>
    let tpegSimplePointLocationType = _prefixId.prefix "tpegSimplePointLocationType"
    let tradeFair = _prefixId.prefix "tradeFair"
    let trafficArea = _prefixId.prefix "trafficArea"
    let trafficBeingManuallyDirected = _prefixId.prefix "trafficBeingManuallyDirected"
    let trafficBlocked = _prefixId.prefix "trafficBlocked"
    let trafficBuildingUp = _prefixId.prefix "trafficBuildingUp"
    let trafficEasing = _prefixId.prefix "trafficEasing"
    let trafficFlowNormal = _prefixId.prefix "trafficFlowNormal"
    let trafficHeavierThanNormal = _prefixId.prefix "trafficHeavierThanNormal"
    let trafficHeld = _prefixId.prefix "trafficHeld"
    let trafficLighterThanNormal = _prefixId.prefix "trafficLighterThanNormal"
    /// <summary>
    ///   <para>rdfs:comment : Type of person that is manually directing traffic (applicable if generalNetworkManagementType is set to "trafficBeingManuallyDirected").</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficManuallyDirectedBy">dtx_srti:trafficManuallyDirectedBy</a>
    /// </summary>
    let trafficManuallyDirectedBy = _prefixId.prefix "trafficManuallyDirectedBy"
    let trafficMonitoringStation = _prefixId.prefix "trafficMonitoringStation"
    let trafficOfficer = _prefixId.prefix "trafficOfficer"
    let trafficSquare = _prefixId.prefix "trafficSquare"
    let trafficStable = _prefixId.prefix "trafficStable"

    let trafficVeryMuchHeavierThanNormal = _prefixId.prefix "trafficVeryMuchHeavierThanNormal"

    let trafficVeryMuchLighterThanNormal = _prefixId.prefix "trafficVeryMuchLighterThanNormal"

    let trafficWarden = _prefixId.prefix "trafficWarden"
    let trailer = _prefixId.prefix "trailer"
    let tram = _prefixId.prefix "tram"
    let transitOperator = _prefixId.prefix "transitOperator"
    let tunnel = _prefixId.prefix "tunnel"
    let turnAroundInOperation = _prefixId.prefix "turnAroundInOperation"
    let turningLane = _prefixId.prefix "turningLane"
    let twoTierCounty = _prefixId.prefix "twoTierCounty"
    let twoWheeledVehicle = _prefixId.prefix "twoWheeledVehicle"
    let unavailable = _prefixId.prefix "unavailable"
    let undefined = _prefixId.prefix "undefined"
    let undefinedTPEGHeight = _prefixId.prefix "undefinedTPEGHeight"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that the road section where the roadworks are located is under traffic or not under traffic. 'True' indicates the road is under traffic.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#underTraffic">dtx_srti:underTraffic</a>
    /// </summary>
    let underTraffic = _prefixId.prefix "underTraffic"
    let underpass = _prefixId.prefix "underpass"
    let undisclosed = _prefixId.prefix "undisclosed"
    let unitaryAuthority = _prefixId.prefix "unitaryAuthority"
    let unknown = _prefixId.prefix "unknown"
    let unprotectedAccidentArea = _prefixId.prefix "unprotectedAccidentArea"
    let unspecifiedAbnormalTraffic = _prefixId.prefix "unspecifiedAbnormalTraffic"
    let unspecifiedCarriageway = _prefixId.prefix "unspecifiedCarriageway"
    let upToTenMinutes = _prefixId.prefix "upToTenMinutes"
    let urbanCounty = _prefixId.prefix "urbanCounty"
    let urgent = _prefixId.prefix "urgent"
    /// <summary>
    ///   <para>rdfs:comment : Indication of whether the roadworks are considered to be urgent whereby emergency work is being, or needs to be, undertaken to mitigate safety concerns. 'True' indicates they are urgent.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#urgentRoadworks">dtx_srti:urgentRoadworks</a>
    /// </summary>
    let urgentRoadworks = _prefixId.prefix "urgentRoadworks"
    let useBusService = _prefixId.prefix "useBusService"
    let useEntry = _prefixId.prefix "useEntry"
    let useExit = _prefixId.prefix "useExit"
    let useFogLights = _prefixId.prefix "useFogLights"
    let useHazardWarningLights = _prefixId.prefix "useHazardWarningLights"
    let useHeadlights = _prefixId.prefix "useHeadlights"
    let useIntersectionOrJunction = _prefixId.prefix "useIntersectionOrJunction"

    let useOfSpecifiedLanesOrCarriagewaysAllowed = _prefixId.prefix "useOfSpecifiedLanesOrCarriagewaysAllowed"

    let useRailService = _prefixId.prefix "useRailService"
    let useSnowChains = _prefixId.prefix "useSnowChains"
    let useSnowChainsOrTyres = _prefixId.prefix "useSnowChainsOrTyres"
    let useSnowTyres = _prefixId.prefix "useSnowTyres"

    let useSpecifiedLanesOrCarriageways = _prefixId.prefix "useSpecifiedLanesOrCarriageways"

    let useTramService = _prefixId.prefix "useTramService"
    let useUndergroundService = _prefixId.prefix "useUndergroundService"
    /// <summary>
    ///   <para>rdfs:comment : A specification of periods of validity defined by overall bounding start and end times and the possible intersection of valid periods with exception periods (exception periods overriding valid periods).</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#validityTimeSpecification">dtx_srti:validityTimeSpecification</a>
    /// </summary>
    let validityTimeSpecification = _prefixId.prefix "validityTimeSpecification"
    let van = _prefixId.prefix "van"
    let vandalism = _prefixId.prefix "vandalism"
    let vehicleFailure = _prefixId.prefix "vehicleFailure"
    /// <summary>
    ///   <para>rdfs:comment : A value of vehicle flow rate expressed in vehicles per hour.</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleFlowRate">dtx_srti:vehicleFlowRate</a>
    /// </summary>
    let vehicleFlowRate = _prefixId.prefix "vehicleFlowRate"
    let vehicleOnFire = _prefixId.prefix "vehicleOnFire"
    let vehicleOnWrongCarriageway = _prefixId.prefix "vehicleOnWrongCarriageway"
    let vehicleProbeMeasurement = _prefixId.prefix "vehicleProbeMeasurement"
    let vehicleRecovery = _prefixId.prefix "vehicleRecovery"
    let vehicleRepair = _prefixId.prefix "vehicleRepair"
    let vehicleStorageInOperation = _prefixId.prefix "vehicleStorageInOperation"
    let vehicleStuck = _prefixId.prefix "vehicleStuck"
    let vehicleWithCaravan = _prefixId.prefix "vehicleWithCaravan"
    let vehicleWithCatalyticConverter = _prefixId.prefix "vehicleWithCatalyticConverter"
    let vehicleWithOverwideLoad = _prefixId.prefix "vehicleWithOverwideLoad"
    let vehicleWithTrailer = _prefixId.prefix "vehicleWithTrailer"

    let vehicleWithoutCatalyticConverter = _prefixId.prefix "vehicleWithoutCatalyticConverter"

    /// <summary>
    ///   <para>rdfs:comment : Name of the venue at which the public event is being held</para>
    ///   <a href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#venueName">dtx_srti:venueName</a>
    /// </summary>
    let venueName = _prefixId.prefix "venueName"
    let verge = _prefixId.prefix "verge"
    let veryHazardous = _prefixId.prefix "veryHazardous"
    let veryImportantPerson = _prefixId.prefix "veryImportantPerson"
    let veryLongDelays = _prefixId.prefix "veryLongDelays"

    let videoProcessingMonitoringStation = _prefixId.prefix "videoProcessingMonitoringStation"

    let visibilityReduced = _prefixId.prefix "visibilityReduced"
    let vms = _prefixId.prefix "vms"
    let waitForEscortVehicle = _prefixId.prefix "waitForEscortVehicle"
    let ward = _prefixId.prefix "ward"
    let waterArea = _prefixId.prefix "waterArea"
    let waterMain = _prefixId.prefix "waterMain"
    let waterSportsMeeting = _prefixId.prefix "waterSportsMeeting"
    let weakBridge = _prefixId.prefix "weakBridge"
    let weightRestrictionInOperation = _prefixId.prefix "weightRestrictionInOperation"
    let westBound = _prefixId.prefix "westBound"
    let winterConditions = _prefixId.prefix "winterConditions"

    let winterEquipmentOnBoardRequired = _prefixId.prefix "winterEquipmentOnBoardRequired"

    let winterSportsMeeting = _prefixId.prefix "winterSportsMeeting"

    let withEvenNumberedRegistrationPlates = _prefixId.prefix "withEvenNumberedRegistrationPlates"

    let withLineDirection = _prefixId.prefix "withLineDirection"

    let withOddNumberedRegistrationPlates = _prefixId.prefix "withOddNumberedRegistrationPlates"

    let withinJunction = _prefixId.prefix "withinJunction"
