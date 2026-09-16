#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module era =
    let _prefixId = PrefixId.fromNamespaceLabel "http://data.europa.eu/949/" "era"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Body</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>rdfs:comment : Is an organisation or a physical person</para>
    ///   <para>dcterms:created : 2024-06-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/Body">era:Body</a>
    /// </summary>
    let Body = _prefixId.prefix "Body"
    /// <summary>
    ///   <para>rdfs:comment : It is a structure constructed for the exclusive purpose of carrying railroad traffic across an obstruction. It can be used for defining non-stopping areas, big metal mass, resistance to traffic load etc.</para>
    ///   <para>dcterms:modified : 2025-01-30^^xsd:datedcterms:modified : 2025-03-01^^xsd:date</para>
    ///   <para>rdfs:label : Bridge</para>
    ///   <a href="http://data.europa.eu/949/Bridge">era:Bridge</a>
    /// </summary>
    let Bridge = _prefixId.prefix "Bridge"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Certificate</para>
    ///   <para>rdfs:comment : Certificate of a vehicle type. Can be in one of the following states: Amended, New, Suspended, Withdrawn.</para>
    ///   <para>dcterms:modified : 2024-10-24^^xsd:datedcterms:modified : 2022-06-15^^xsd:date</para>
    ///   <para>dcterms:created : 2022-06-15^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/Certificate">era:Certificate</a>
    /// </summary>
    let Certificate = _prefixId.prefix "Certificate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2026-01-11^^xsd:datedcterms:modified : 2024-10-31^^xsd:datedcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2025-08-26^^xsd:date</para>
    ///   <para>rdfs:comment : A set of different infrastructure objects sharing the same common technical characteristics. The parameters may not be restricted to only one railway subsystem, but it can include common characteristics from each one of them (infrastructure, energy, track-side CCS)</para>
    ///   <para>dcterms:created : 2022-11-04^^xsd:date</para>
    ///   <para>rdfs:label : Subset with common characteristics</para>
    ///   <a href="http://data.europa.eu/949/CommonCharacteristicsSubset">era:CommonCharacteristicsSubset</a>
    /// </summary>
    let CommonCharacteristicsSubset = _prefixId.prefix "CommonCharacteristicsSubset"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Contact Line System</para>
    ///   <para>rdfs:comment : System that is used to transmit electrical energy to road or rail vehicles.</para>
    ///   <para>dcterms:modified : 2021-08-04^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-04^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/ContactLineSystem">era:ContactLineSystem</a>
    /// </summary>
    let ContactLineSystem = _prefixId.prefix "ContactLineSystem"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ERA Document</para>
    ///   <para>rdfs:comment : Document in any of the ERA systems, e.g. reference document in RINF.</para>
    ///   <para>dcterms:created : 2024-04-23^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/Document">era:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ETCS</para>
    ///   <para>rdfs:comment : TSI compliant train protection system ERTMS / ETCS application level and baseline related to the track side equipment.</para>
    ///   <para>dcterms:modified : 2021-08-07^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-07^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/ETCS">era:ETCS</a>
    /// </summary>
    let ETCS = _prefixId.prefix "ETCS"
    /// <summary>
    ///   <para>rdfs:label : ERA Feature</para>
    ///   <para>rdfs:comment : Class that encompasses the features that are part of the physical infrastructure (class InfrastructureElement) and the topological objects (class TopologicalObject). It is a subclass of the geographical Feature class that has a spatial representation.</para>
    ///   <para>dcterms:modified : 2022-10-27^^xsd:date</para>
    ///   <para>dcterms:created : 2022-07-07^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/Feature">era:Feature</a>
    /// </summary>
    let Feature = _prefixId.prefix "Feature"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Section with train detection limitation</para>
    ///   <para>rdfs:comment : Specific for route compatibility check on French network.</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/FrenchTrainDetectionSystemLimitation">era:FrenchTrainDetectionSystemLimitation</a>
    /// </summary>
    let FrenchTrainDetectionSystemLimitation = _prefixId.prefix "FrenchTrainDetectionSystemLimitation"

    /// <summary>
    ///   <para>rdfs:comment : A trackside Hot Axle Box Detector (HABD), necessary for the route compatibility check.
    /// Specific for the French, Italian and Swedish networks</para>
    ///   <para>dcterms:modified : 2025-03-01^^xsd:date</para>
    ///   <para>rdfs:label : Hot Axle Box Detector</para>
    ///   <para>dcterms:created : 2025-02-20^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/HABD">era:HABD</a>
    /// </summary>
    let HABD = _prefixId.prefix "HABD"
    /// <summary>
    ///   <para>rdfs:comment : This class encompasses all those classes that represent features that are  implemented in the European railway infrastructure. It is a subclass of the ERA Feature that has a spatial representation. It covers tracks, platforms, signals, tunnels, operational points, and sections of line.
    /// A feature that belongs to the infrastructure can be abstracted (hasAbstraction) as a topological object. It also is related to the infrastructure manager through the property infrastructureMgr.</para>
    ///   <para>dcterms:created : 2022-07-07^^xsd:date</para>
    ///   <para>rdfs:label : Infrastructure element</para>
    ///   <para>dcterms:modified : 2025-04-30^^xsd:datedcterms:modified : 2022-10-27^^xsd:datedcterms:modified : 2024-10-28^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/InfrastructureElement">era:InfrastructureElement</a>
    /// </summary>
    let InfrastructureElement = _prefixId.prefix "InfrastructureElement"
    /// <summary>
    ///   <para>skos:scopeNote : See point (2) of Article 3 of Directive 2012/34/EU of the European Parliament and of the Council establishing a single European railway area.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Infrastructure manager</para>
    ///   <para>rdfs:comment : (deprecated) The infrastructure manager owns and operates the railway network and related infrastructure.</para>
    ///   <a href="http://data.europa.eu/949/InfrastructureManager">era:InfrastructureManager</a>
    /// </summary>
    let InfrastructureManager = _prefixId.prefix "InfrastructureManager"
    /// <summary>
    ///   <para>rdfs:comment : Represents a kilometric post in the linear positioning system.</para>
    ///   <para>dcterms:modified : 2025-01-30^^xsd:datedcterms:modified : 2025-03-01^^xsd:date</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <para>rdfs:label : Kilometric Post</para>
    ///   <a href="http://data.europa.eu/949/KilometricPost">era:KilometricPost</a>
    /// </summary>
    let KilometricPost = _prefixId.prefix "KilometricPost"
    /// <summary>
    ///   <para>dcterms:modified : 2025-03-01^^xsd:datedcterms:modified : 2025-01-30^^xsd:date</para>
    ///   <para>rdfs:label : Level crossing</para>
    ///   <para>rdfs:comment : A level crossing is an intersection where a railway line crosses a road or a path at the same level. It can be used for the implementation of the ETCS trackside or to identify potential collision scenarios</para>
    ///   <a href="http://data.europa.eu/949/LevelCrossing">era:LevelCrossing</a>
    /// </summary>
    let LevelCrossing = _prefixId.prefix "LevelCrossing"
    /// <summary>
    ///   <para>dcterms:modified : 2021-01-29^^xsd:datedcterms:modified : 2024-10-24^^xsd:datedcterms:modified : 2024-11-29^^xsd:date</para>
    ///   <para>dcterms:created : 2021-01-29^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:altLabel : Line reference^^xsd:string</para>
    ///   <para>rdfs:comment : A reference to a specific railway line.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : (deprecated) Railway location</para>
    ///   <a href="http://data.europa.eu/949/LineReference">era:LineReference</a>
    /// </summary>
    let LineReference = _prefixId.prefix "LineReference"
    /// <summary>
    ///   <para>dcterms:modified : 2024-11-29^^xsd:datedcterms:modified : 2025-03-01^^xsd:date</para>
    ///   <para>rdfs:label : Linear Element</para>
    ///   <para>rdfs:comment : Pieces of tracks composing the topology</para>
    ///   <para>skos:scopeNote : This class represents an edge in the topological graph. It represents a linear element in the network.</para>
    ///   <a href="http://data.europa.eu/949/LinearElement">era:LinearElement</a>
    /// </summary>
    let LinearElement = _prefixId.prefix "LinearElement"
    /// <summary>
    ///   <para>skos:scopeNote : A linear element section is a finer granularity of a linear element, representing a specific portion of it. This concept is introduced to address the cases when a linear element needs to be split such as a part of it is used by a net referencing (more in the paragraph describing the positioning on the network). By using start and end offsets measured from origin of the element in ascending order, sections eliminate the need for intrinsic coordinates and instead rely on distances along the linear element.</para>
    ///   <para>rdfs:label : Linear Element Section</para>
    ///   <para>rdfs:comment : Represents a section of a linear element.</para>
    ///   <a href="http://data.europa.eu/949/LinearElementSection">era:LinearElementSection</a>
    /// </summary>
    let LinearElementSection = _prefixId.prefix "LinearElementSection"
    /// <summary>
    ///   <para>rdfs:label : Linear Positioning System</para>
    ///   <para>rdfs:comment : Represents a linear positioning system used for referencing positions on the network.
    /// It can also represent a sequence of one or more sections of line, used for regular railway operations.</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/LinearPositioningSystem">era:LinearPositioningSystem</a>
    /// </summary>
    let LinearPositioningSystem = _prefixId.prefix "LinearPositioningSystem"

    /// <summary>
    ///   <para>rdfs:label : Linear Positioning System Coordinate</para>
    ///   <para>rdfs:comment : Represents coordinates in a linear positioning system.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/LinearPositioningSystemCoordinate">era:LinearPositioningSystemCoordinate</a>
    /// </summary>
    let LinearPositioningSystemCoordinate = _prefixId.prefix "LinearPositioningSystemCoordinate"

    /// <summary>
    ///   <para>rdfs:label : Lineside indications of distance</para>
    ///   <para>rdfs:comment : Frequency, appearance and positioning of a sign indicating distance as reference post. Two types of signs are normally available: kilometre post and hectometre post.
    /// - A kilometre post is a lineside sign indicating the distance from a specific point, usually being the starting point of the railway line.
    /// - A hectometre post is a lineside sign indicating a relative distance.</para>
    ///   <para>dcterms:modified : 2025-01-30^^xsd:date</para>
    ///   <para>dcterms:created : 2024-12-12^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/LinesideDistanceIndication">era:LinesideDistanceIndication</a>
    /// </summary>
    let LinesideDistanceIndication = _prefixId.prefix "LinesideDistanceIndication"
    /// <summary>
    ///   <para>rdfs:comment : This class together with properties loadCapabilityLineCategory and loadCapabilitySpeed replaces the previous loadCapability SKOS property.rdfs:comment : A combination of the line category and speed at the weakest point of the track.
    /// Each track can have several load capability (structured) values, and each one has values for load model line category and load model speed.</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : At this step, RINF does not allow to enter additional data referred to additional speed regulations and operating requirements relating to locomotives (e.g., locomotive classes and associated maximum speed) or traffic types (e.g., maximum speed of freight traffic or passenger traffic).
    ///
    /// The load capability describes the weakest point of this track within this section of line (which is normally a bridge or other sub-track structure). It is expressed as a combination of the line category and speed permitted for trains exerting loads defined for this line category. The result of the classification process is set out in EN 15528:2021 (Annex A) and referred to in that standard as “Line Category”.
    ///
    /// It represents the ability of the infrastructure to withstand the vertical loads imposed by vehicles on the track for regular service as a combination of Line Category with a permitted speed according to EN 15528:2021
    ///
    /// More than one combination may be published for the same track if applicable, but it has to be done by repetition of the parameter with one value selected only - that is why 'Y' is given in line 'Can be repeated'.
    ///
    /// For the following cases, it is not possible to use EN 15528:20021categories of line classification:
    /// - TSI categories of line P1520 and F1520 (passenger traffic or freight traffic at any speed)
    /// - TSI categories of line P1600 and F1600 (passenger traffic or freight traffic at any speed)</para>
    ///   <para>rdfs:label : Load capability</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/LoadCapability">era:LoadCapability</a>
    /// </summary>
    let LoadCapability = _prefixId.prefix "LoadCapability"
    /// <summary>
    ///   <para>rdfs:comment : (deprecated) Replaced by the era:Body class and era:manufacturer property. A company or organization that manufactures vehicles.</para>
    ///   <para>rdfs:label : (deprecated) Manufacturer</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2024-06-03^^xsd:datedcterms:modified : 2020-11-19^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2020-11-19^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/Manufacturer">era:Manufacturer</a>
    /// </summary>
    let Manufacturer = _prefixId.prefix "Manufacturer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Maximum magnetic field</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/MaximumMagneticField">era:MaximumMagneticField</a>
    /// </summary>
    let MaximumMagneticField = _prefixId.prefix "MaximumMagneticField"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Maximum speed and cant deficiency</para>
    ///   <para>rdfs:comment : Combination of maximum speed and maximum cant deficiency for which the vehicle was assessed.</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/MaximumSpeedAndCantDeficiency">era:MaximumSpeedAndCantDeficiency</a>
    /// </summary>
    let MaximumSpeedAndCantDeficiency = _prefixId.prefix "MaximumSpeedAndCantDeficiency"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : (deprecated) Min axle load vehicle category</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>dcterms:created : 2023-01-25^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/MinAxleLoadVehicleCategory">era:MinAxleLoadVehicleCategory</a>
    /// </summary>
    let MinAxleLoadVehicleCategory = _prefixId.prefix "MinAxleLoadVehicleCategory"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-09/index077_-_ERA_ERTMS_033281_v5.pdf^^xsd:anyURI</para>
    ///   <para>rdfs:label : Minimum Vehicle Impedance</para>
    ///   <para>dcterms:created : 2024-05-30^^xsd:date</para>
    ///   <para>rdfs:comment : Impedance as defined in the TSI CCS (Annex I, Appendix A, Table A.2 -Index 77).
    ///
    /// Minimum vehicle impedance (between wheels and pantograph) (only for vehicles equipped for 1500V or 3000V DC).
    ///
    /// Per Voltage:
    /// [1500]: [CCCC]+[ZZZZ], with input capacitance [CCCC](Cin) and input impedance [ZZZZ](Zin)
    /// [3000]: [CCCC]+[ZZZZ], idem.</para>
    ///   <para>skos:scopeNote : The MinVehicleImpedance class is applicable for track circuits.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/MinVehicleImpedance">era:MinVehicleImpedance</a>
    /// </summary>
    let MinVehicleImpedance = _prefixId.prefix "MinVehicleImpedance"
    /// <summary>
    ///   <para>skos:scopeNote : Presentation of parameter 1.2.2.0.3.3 'Minimum radius of vertical curve'</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Minimum radius of vertical curve</para>
    ///   <para>dcterms:created : 2021-12-12^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/MinimumVerticalRadius">era:MinimumVerticalRadius</a>
    /// </summary>
    let MinimumVerticalRadius = _prefixId.prefix "MinimumVerticalRadius"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2021-01-25^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : (deprecated) National railway line</para>
    ///   <para>dcterms:modified : 2024-11-29^^xsd:datedcterms:modified : 2021-08-03^^xsd:date</para>
    ///   <para>rdfs:comment : Railway line within a member state.
    /// A line is a sequence of one or more sections of line, which connects operational points and which may consist of several tracks used for regular railway operation.</para>
    ///   <a href="http://data.europa.eu/949/NationalRailwayLine">era:NationalRailwayLine</a>
    /// </summary>
    let NationalRailwayLine = _prefixId.prefix "NationalRailwayLine"
    /// <summary>
    ///   <para>skos:scopeNote : It is used for infrastructure elements positioned in relation to the topology as a subnetwork. (e.g.: tunnels, non-stopping area, stations etc.)</para>
    ///   <para>skos:example : Example: non-stopping area, cross section area, area of implementation of GPRS etc.</para>
    ///   <para>rdfs:label : Net Area Reference</para>
    ///   <para>rdfs:comment : Represents an area reference in the network.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/NetAreaReference">era:NetAreaReference</a>
    /// </summary>
    let NetAreaReference = _prefixId.prefix "NetAreaReference"
    /// <summary>
    ///   <para>skos:scopeNote : </para>
    ///   <para>rdfs:seeAlso : https://wiki.railtopomodel.org/wiki/Object_positioning_in_the_network^^xsd:anyURI</para>
    ///   <para>rdfs:label : Net Basic Reference</para>
    ///   <para>rdfs:comment : Basic positioning reference within the ERA ontology. It represents different types of geographical locations. Geographical coordinates are provided according to the standard World Geodetic System (WGS84).</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/NetBasicReference">era:NetBasicReference</a>
    /// </summary>
    let NetBasicReference = _prefixId.prefix "NetBasicReference"
    /// <summary>
    ///   <para>rdfs:label : Net element</para>
    ///   <para>rdfs:seeAlso : https://wiki.railtopomodel.org/wiki/Topological_structure_(network)^^xsd:anyURI</para>
    ///   <para>dcterms:modified : 2025-04-30^^xsd:date</para>
    ///   <para>rdfs:comment : It is a representation of all building blocks of the topology. It references an associated topological network element.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/NetElement">era:NetElement</a>
    /// </summary>
    let NetElement = _prefixId.prefix "NetElement"
    /// <summary>
    ///   <para>skos:scopeNote : It is used for infrastructure elements positioned in relation to the topology as a line, or along a path. (e.g.: tracks, bridges, platform edges, etc.)</para>
    ///   <para>skos:example : Example: tracks, tunnels, bridges, platform edges etc.</para>
    ///   <para>rdfs:label : Net Linear Reference</para>
    ///   <para>rdfs:comment : Represents a linear reference in the network.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/NetLinearReference">era:NetLinearReference</a>
    /// </summary>
    let NetLinearReference = _prefixId.prefix "NetLinearReference"
    /// <summary>
    ///   <para>skos:scopeNote : It is used for infrastructure elements positioned in relation to the topology as a point. (e.g.: signals, ETCS balises, buffer stops, etc.)</para>
    ///   <para>rdfs:label : Net Point Reference</para>
    ///   <para>rdfs:comment : Represents a point reference in the network.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/NetPointReference">era:NetPointReference</a>
    /// </summary>
    let NetPointReference = _prefixId.prefix "NetPointReference"
    /// <summary>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <para>rdfs:label : Net Relation</para>
    ///   <para>rdfs:comment : Defines a relation between two elements.</para>
    ///   <para>dcterms:modified : 2025-03-10^^xsd:datedcterms:modified : 2025-11-21^^xsd:date</para>
    ///   <para>rdfs:seeAlso : https://wiki.railtopomodel.org/wiki/Topological_structure_(network)^^xsd:anyURI</para>
    ///   <para>skos:scopeNote : Connectivity and the navigability between consecutive linear elements are resolved by using net relations. It models how different elements are related to each other, representing a transition from one element to another.
    /// Net relations specify where two linear elements connect. This could be at the origin of one element, the end of another, or even at specific offsets along their lengths. For example, two tracks might connect at a junction, with one ending at offset 1500 and the other beginning at offset 0.
    /// NetRelation explicitly models these connections by linking two linear elements (elementA and elementB) and defining their physical or logical relationship.
    /// Net relations also specify the permitted directions of travel:
    /// •	AB: Trains can move from element A to element B.
    /// •	BA: Trains can move from element B to element A.
    /// •	Both: Movement is bidirectional.
    /// •	None: No movement is allowed between the two elements.
    /// To make this even more precise, net relations include information about whether the connection is at the origin of each element. For example, a relation might indicate that Track A ends at its origin (offset 0) and connects to Track B at its start (isOnOriginOfElementA and isOnOriginOfElementB).
    /// </para>
    ///   <a href="http://data.europa.eu/949/NetRelation">era:NetRelation</a>
    /// </summary>
    let NetRelation = _prefixId.prefix "NetRelation"
    /// <summary>
    ///   <para>skos:scopeNote : Non-linear elements complement the linear structure by serving as connection or interaction points. They represent features such as stations, depots, or complex junctions. They often serve as aggregation points for linear elements, where multiple tracks meet or like logical entities that support operations like passenger boarding or train storage. These elements may optionally aggregate linear elements.</para>
    ///   <para>rdfs:label : Non-Linear Element</para>
    ///   <para>rdfs:comment : Represents a non-linear element in the network.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/NonLinearElement">era:NonLinearElement</a>
    /// </summary>
    let NonLinearElement = _prefixId.prefix "NonLinearElement"
    /// <summary>
    ///   <para>dcterms:modified : 2022-07-07^^xsd:datedcterms:modified : 2025-01-30^^xsd:datedcterms:modified : 2025-03-01^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Operational Point</para>
    ///   <para>rdfs:comment : An operational point (OP) means any location for train service operations, where train services may begin and end or change route, and where passenger or freight services may be provided; operational point also means any location at boundaries between Member States or infrastructure managers.</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/OperationalPoint">era:OperationalPoint</a>
    /// </summary>
    let OperationalPoint = _prefixId.prefix "OperationalPoint"
    /// <summary>
    ///   <para>rdfs:label : Organisation Role</para>
    ///   <para>rdfs:comment : Represents an n-ary relationship between a Body and a role</para>
    ///   <a href="http://data.europa.eu/949/OrganisationRole">era:OrganisationRole</a>
    /// </summary>
    let OrganisationRole = _prefixId.prefix "OrganisationRole"
    /// <summary>
    ///   <para>rdfs:label : Orientation</para>
    ///   <para>rdfs:comment : Represents the orientation of a railway object in relation to a carrier linear element. It can be described by direction, orientation and side.</para>
    ///   <a href="http://data.europa.eu/949/Orientation">era:Orientation</a>
    /// </summary>
    let Orientation = _prefixId.prefix "Orientation"
    /// <summary>
    ///   <para>rdfs:label : Parameter applicability</para>
    ///   <para>rdfs:comment : Applicability interval defines the date interval in which a characteristic of an infrastructure element is applicable. This interval can be applied for any of the technical characteristics or general information of infrastructure elements. This helps identifying planned changes applied to technical parameters over time.</para>
    ///   <para>dcterms:modified : 2024-10-28^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/ParameterApplicability">era:ParameterApplicability</a>
    /// </summary>
    let ParameterApplicability = _prefixId.prefix "ParameterApplicability"
    /// <summary>
    ///   <para>rdfs:label : Phase info</para>
    ///   <para>rdfs:comment : Indication of required several information on phase separation.</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/PhaseInfo">era:PhaseInfo</a>
    /// </summary>
    let PhaseInfo = _prefixId.prefix "PhaseInfo"
    /// <summary>
    ///   <para>dcterms:modified : 2025-01-30^^xsd:datedcterms:modified : 2023-11-10^^xsd:datedcterms:modified : 2025-03-01^^xsd:date</para>
    ///   <para>rdfs:comment : Platform for the purpose of RINF is understood as a platform edge. A platform concerns only the part of the structure neighbouring to the track (interfaced with trains).</para>
    ///   <para>rdfs:label : Platform edge</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-02^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/PlatformEdge">era:PlatformEdge</a>
    /// </summary>
    let PlatformEdge = _prefixId.prefix "PlatformEdge"
    /// <summary>
    ///   <para>skos:example : Primary locations are for example: stations, yards, halts, handover points, border points, open access terminals. </para>
    ///   <para>dcterms:modified : 2024-10-28^^xsd:datedcterms:modified : 2025-06-06^^xsd:datedcterms:modified : 2025-03-01^^xsd:date</para>
    ///   <para>rdfs:label : Primary Location</para>
    ///   <para>rdfs:comment : Primary Location is a place used by IM to define a path for a train in TAF/TAP TSI framework/messages. This location is a rail point inside the rail network where train starts, ends, stops, or runs through or change line. This location must be managed by an Infrastructure Manager (IM) identified by company code.
    ///
    /// Primary locations are identified by single and unique Primary Location codes. Primary location code is allocated based on processes defined by national entity. Primary location codes are used in any kind of TAF/TAP communication.
    ///
    /// See: Handbook 9.3.3 / page 60</para>
    ///   <para>rdfs:seeAlso : http://taf-jsg.info/wp-content/uploads/2025/07/JSG-Handbook-3.7-with-XSD-3.5.1.0.pdf^^xsd:anyURI</para>
    ///   <a href="http://data.europa.eu/949/PrimaryLocation">era:PrimaryLocation</a>
    /// </summary>
    let PrimaryLocation = _prefixId.prefix "PrimaryLocation"
    /// <summary>
    ///   <para>rdfs:label : Radio Block Center</para>
    ///   <para>rdfs:seeAlso : https://eur-lex.europa.eu/legal-content/EN/TXT/?uri=CELEX%3A32023R1693&amp;qid=1698394526534^^xsd:anyURIrdfs:seeAlso : https://www.era.europa.eu/system/files/2023-09/index003_-_SUBSET-023_v400.pdf^^xsd:anyURI</para>
    ///   <para>rdfs:comment : ETCS trackside centralised unit controlling ETCS train movements in level 2.
    ///
    /// A centralised safety unit that receives train position information via radio and sends movement authorities via radio to trains.</para>
    ///   <a href="http://data.europa.eu/949/RadioBlockCenter">era:RadioBlockCenter</a>
    /// </summary>
    let RadioBlockCenter = _prefixId.prefix "RadioBlockCenter"

    /// <summary>
    ///   <para>skos:scopeNote : This class gives the information about the number of pantographs and the distance between them at a given speed for which the Overhead Contact Line (OCL) has been designed.
    /// As for different speeds different combinations of number of pantographs and distance between them may exist, so this class can be repeated to present all of them.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Requirements for number of raised pantographs and spacing between them, at the given speed</para>
    ///   <para>rdfs:comment : Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.
    /// Each track can have several raised pantographs per train allowed (structured) values, and each one has values for number of pantographs, minimum distance between pantographs, in metres, and speed considered in km/h.</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/RaisedPantographsDistanceAndSpeed">era:RaisedPantographsDistanceAndSpeed</a>
    /// </summary>
    let RaisedPantographsDistanceAndSpeed = _prefixId.prefix "RaisedPantographsDistanceAndSpeed"

    /// <summary>
    ///   <para>dcterms:created : 2024-10-24^^xsd:date</para>
    ///   <para>rdfs:label : Reference border point</para>
    ///   <para>rdfs:comment : List of reference border points that are specified in the RINF Application Guide.</para>
    ///   <para>dcterms:modifed : 2025-02-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/ReferenceBorderPoint">era:ReferenceBorderPoint</a>
    /// </summary>
    let ReferenceBorderPoint = _prefixId.prefix "ReferenceBorderPoint"
    /// <summary>
    ///   <para>rdfs:comment : A running track means any track used for train service movements; passing loops and meeting loops on plain line or track connections only required for train operation are not published</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>skos:scopeNote : There might be more than one track within the Section of Line, so then the whole set of data for track has to be repeated for each track within the SoL.</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-11-20^^xsd:datedcterms:modified : 2022-07-07^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Running track</para>
    ///   <a href="http://data.europa.eu/949/RunningTrack">era:RunningTrack</a>
    /// </summary>
    let RunningTrack = _prefixId.prefix "RunningTrack"
    /// <summary>
    ///   <para>rdfs:label : Section Of Line</para>
    ///   <para>dcterms:modified : 2025-01-30^^xsd:datedcterms:modified : 2025-03-01^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2022-07-07^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A section of line means the part of line between adjacent operational points and may consist of several tracks.</para>
    ///   <para>skos:scopeNote : Each network shall be described using as many SoLs as necessary. Each SoL   is generated and identified by OP IDs at start and at end. A SoL only belongs to one Line.</para>
    ///   <para>dcterms:created : 2021-04-02^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/SectionOfLine">era:SectionOfLine</a>
    /// </summary>
    let SectionOfLine = _prefixId.prefix "SectionOfLine"
    /// <summary>
    ///   <para>rdfs:label : Siding</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-11-20^^xsd:datedcterms:modified : 2022-10-27^^xsd:date</para>
    ///   <para>rdfs:comment : Sidings are all those tracks where running trains in service movements ends and which are not used for operational routing of a train.</para>
    ///   <para>skos:definition : Siding - Any track(s) within an operational point which is not used for operational routing of a train.</para>
    ///   <para>dcterms:created : 2021-08-10^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/Siding">era:Siding</a>
    /// </summary>
    let Siding = _prefixId.prefix "Siding"
    /// <summary>
    ///   <para>dcterms:modified : 2022-10-27^^xsd:datedcterms:modified : 2025-03-01^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-01-30^^xsd:date</para>
    ///   <para>dcterms:created : 2021-04-01^^xsd:date</para>
    ///   <para>rdfs:comment : A railway signal is a visual display device (next to the tracks or via a DMI in the cabin) that conveys instructions or provides advance warning of instructions regarding the driver's authority to proceed.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:definition : Apparatus by means of which a conventional visual or acoustic indication is given, generally concerning the movements/movement authorities of railway vehicles.</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-09/index003_-_SUBSET-023_v400.pdf^^xsd:anyURI</para>
    ///   <para>rdfs:label : Signal</para>
    ///   <a href="http://data.europa.eu/949/Signal">era:Signal</a>
    /// </summary>
    let Signal = _prefixId.prefix "Signal"
    /// <summary>
    ///   <para>dcterms:created : 2022-10-27^^xsd:date</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-03-01^^xsd:date</para>
    ///   <para>skos:definition : Non-stopping Area: Area defined by the Infrastructure Manager where it may not be safe or suitable to stop a train.
    /// Safe Area: Area defined by the Infrastructure Manager where it is safe or suitable to stop and evacuate a train.
    /// Industrial Risk Area: locations where it is dangerous for the driver to step out.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Encompasses all those areas (outside of the operational gauge) or sections (those in tunnels excluded) which influence operation in the gauge itself, such as
    /// - safe areas,
    /// - restricted areas (non-stopping areas or industrial risk locations).
    ///
    /// For these areas in tunnels, use era:SpecialTunnelArea.</para>
    ///   <para>skos:editorialNote : TODO review the definition^^xsd:string</para>
    ///   <para>rdfs:label : Special area</para>
    ///   <a href="http://data.europa.eu/949/SpecialArea">era:SpecialArea</a>
    /// </summary>
    let SpecialArea = _prefixId.prefix "SpecialArea"
    /// <summary>
    ///   <para>rdfs:comment : Area or location within a tunnel where there are:
    /// - a safe area: a walkway, evacuation and rescue points;
    /// - a restricted area (non-stopping area or industrial risk location in a tunnel).</para>
    ///   <para>dcterms:created : 2022-10-27^^xsd:date</para>
    ///   <para>skos:editorialNote : TODO review the definition^^xsd:string</para>
    ///   <para>rdfs:label : Special tunnel area</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/SpecialTunnelArea">era:SpecialTunnelArea</a>
    /// </summary>
    let SpecialTunnelArea = _prefixId.prefix "SpecialTunnelArea"
    /// <summary>
    ///   <para>rdfs:comment : Subsidiary location must be linked to a Primary Location and specifies in more detailed way part, attributes, or usage of Primary location. It may be also a non-rail point or a rail point that is not managed by an Infrastructure Manager (IM). It may be defined by entity having company code according to their needs. The Subsidiary location is optional and dependent upon business needs.</para>
    ///   <para>rdfs:label : Subsidiary location</para>
    ///   <para>rdfs:seeAlso : http://taf-jsg.info/wp-content/uploads/2024/01/20231018-JGS-Handbook-3.4-with-XSD-3.4.0.0.pdf^^xsd:anyURI</para>
    ///   <para>dcterms:created : 2024-05-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-03-10^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/SubsidiaryLocation">era:SubsidiaryLocation</a>
    /// </summary>
    let SubsidiaryLocation = _prefixId.prefix "SubsidiaryLocation"
    /// <summary>
    ///   <para>rdfs:label : Switch</para>
    ///   <para>rdfs:comment : A unit of track comprising two fixed rails (stock rails) and two movable rails (switch rails) used to direct vehicles from one track to another track.</para>
    ///   <para>dcterms:modified : 2025-03-01^^xsd:datedcterms:modified : 2025-01-30^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/Switch">era:Switch</a>
    /// </summary>
    let Switch = _prefixId.prefix "Switch"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : System separation info</para>
    ///   <para>rdfs:comment : Indication of required several information on system separation.</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/SystemSeparationInfo">era:SystemSeparationInfo</a>
    /// </summary>
    let SystemSeparationInfo = _prefixId.prefix "SystemSeparationInfo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : TEN-T Corridor</para>
    ///   <para>rdfs:comment : Represents the TEN-T network classification of an element, including its network level, type of traffic, and associated European transport corridors.</para>
    ///   <para>dcterms:created : 2025-11-17^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/TENTCorridor">era:TENTCorridor</a>
    /// </summary>
    let TENTCorridor = _prefixId.prefix "TENTCorridor"
    /// <summary>
    ///   <para>rdfs:label : Existence and TSI compliance of rules for magnetic fields emitted by a vehicle</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guideera:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:comment : Indication whether rules exist and are compliant with the TSI.</para>
    ///   <para>era:rinfIndex : 1.2.1.1.8.1^^xsd:stringera:rinfIndex : 1.1.1.3.9.1^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-09/index077_-_ERA_ERTMS_033281_v5.pdf^^xsd:anyURI</para>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2024-04-25^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/TSIMagneticFields">era:TSIMagneticFields</a>
    /// </summary>
    let TSIMagneticFields = _prefixId.prefix "TSIMagneticFields"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>era:XMLName : CEI_TSITractionHarmonics^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.1.8.2^^xsd:stringera:rinfIndex : 1.1.1.3.9.2^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2025-03-04^^xsd:date</para>
    ///   <para>rdfs:comment : Indication whether rules exist and are compliant with the TSI.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latestera:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>rdfs:label : Existence and TSI compliance of limits in harmonics in the traction current of vehicles</para>
    ///   <para>skos:scopeNote : Compatibility with track circuits and wheel detectors of axle counters. The harmonics in the traction current in the rails can interfere with the operation of track circuits. The DC current in the rails may saturate the detectors of the axle counters, preventing their  operation.
    ///  none  shall be selected when respective national rules do not exist.</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/TSITractionHarmonics">era:TSITractionHarmonics</a>
    /// </summary>
    let TSITractionHarmonics = _prefixId.prefix "TSITractionHarmonics"
    /// <summary>
    ///   <para>rdfs:label : Temporal Feature</para>
    ///   <para>rdfs:comment : The union of TemporalDuration that represents a time extent and TemporalEntity that represents a temporal interval or instant.^^xsd:string</para>
    ///   <para>dcterms:created : 2024-05-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/TemporalFeature">era:TemporalFeature</a>
    /// </summary>
    let TemporalFeature = _prefixId.prefix "TemporalFeature"
    /// <summary>
    ///   <para>rdfs:label : Topological Coordinate</para>
    ///   <para>rdfs:comment : Represents a topological coordinate.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/TopologicalCoordinate">era:TopologicalCoordinate</a>
    /// </summary>
    let TopologicalCoordinate = _prefixId.prefix "TopologicalCoordinate"
    /// <summary>
    ///   <para>rdfs:label : Track</para>
    ///   <para>rdfs:comment : A pair of rails over which rail borne vehicles can run.</para>
    ///   <para>dcterms:modified : 2025-03-01^^xsd:datedcterms:modified : 2025-01-30^^xsd:date</para>
    ///   <para>dcterms:created : 2024-11-20^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/Track">era:Track</a>
    /// </summary>
    let Track = _prefixId.prefix "Track"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Train Detection System</para>
    ///   <para>rdfs:comment : Safety system used to detect the presence of vehicles on the railway track.</para>
    ///   <para>dcterms:modified : 2021-08-07^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-07^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/TrainDetectionSystem">era:TrainDetectionSystem</a>
    /// </summary>
    let TrainDetectionSystem = _prefixId.prefix "TrainDetectionSystem"
    /// <summary>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-01-30^^xsd:datedcterms:modified : 2022-07-07^^xsd:date</para>
    ///   <para>rdfs:comment : A railway tunnel is an excavation or a construction around the track provided to allow the railway to pass for example higher land, buildings or water.</para>
    ///   <para>rdfs:label : Tunnel</para>
    ///   <para>skos:definition : A railway tunnel is an excavation or a construction around the track provided to allow the railway to pass for example higher land, buildings or water.
    ///
    /// The length of a tunnel is defined as the length of the fully enclosed section, measured at rail level. A tunnel in the context of this TSI is 0.1 km or longer.
    /// Where certain requirements apply only to longer tunnels, thresholds are mentioned in the relevant clauses.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/Tunnel">era:Tunnel</a>
    /// </summary>
    let Tunnel = _prefixId.prefix "Tunnel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Vehicle</para>
    ///   <para>rdfs:comment : A specific vehicle or wagon able and allowed to operate over railway infrastructure.</para>
    ///   <para>dcterms:modified : 2020-11-22^^xsd:date</para>
    ///   <para>dcterms:created : 2020-11-22^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/Vehicle">era:Vehicle</a>
    /// </summary>
    let Vehicle = _prefixId.prefix "Vehicle"
    /// <summary>
    ///   <para>dcterms:created : 2020-11-23^^xsd:date</para>
    ///   <para>dcterms:modified : 2020-11-23^^xsd:datedcterms:modified : 2024-06-03^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : The natural or legal person that, being the owner of a vehicle or having the right to use it,
    /// exploits the vehicle as a means of transport and is registered as such in a vehicle register referred to in Article 47 of (EU)2016/797.</para>
    ///   <para>rdfs:label : (deprecated) Vehicle Keeper</para>
    ///   <a href="http://data.europa.eu/949/VehicleKeeper">era:VehicleKeeper</a>
    /// </summary>
    let VehicleKeeper = _prefixId.prefix "VehicleKeeper"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Vehicle Type</para>
    ///   <para>rdfs:comment : A vehicle type that has been authorized to operate on the EU railway infrastructure. Type means a vehicle type defining the basic design characteristics of the vehicle as covered by a type or design examination certificate described in the relevant verification module.
    ///
    /// Basic design characteristics means the parameters that are used to identify the vehicle type as specified in the issued vehicle type authorisation and recorded in the European Register of Authorised Vehicle Types ('ERATV').
    ///
    /// The above mentioned certificate should be documented using era:certificate.
    /// </para>
    ///   <para>dcterms:modified : 2024-06-03^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2020-07-29^^xsd:date</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/VehicleType">era:VehicleType</a>
    /// </summary>
    let VehicleType = _prefixId.prefix "VehicleType"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/sites/default/files/registers/docs/rinf_application_guide_for_register_en.pdf^^xsd:anyURI</para>
    ///   <para>rdfs:label : XML name</para>
    ///   <para>rdfs:comment : Corresponding XML name as indicated in the RINF application guide</para>
    ///   <para>dcterms:modified : 2024-08-13^^xsd:date</para>
    ///   <para>dcterms:created : 2023-05-26^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/XMLName">era:XMLName</a>
    /// </summary>
    let XMLName = _prefixId.prefix "XMLName"

    let ``_:genid_nodeid_node1jfsuh0nsx2`` = _prefixId.prefix "_:genid-nodeid-node1jfsuh0nsx2"

    let ``_:genid_nodeid_node1jfsuh0nsx3`` = _prefixId.prefix "_:genid-nodeid-node1jfsuh0nsx3"

    let ``_:genid_nodeid_node1jfsuh0nsx4`` = _prefixId.prefix "_:genid-nodeid-node1jfsuh0nsx4"

    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.1.7.3^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-11-20^^xsd:date</para>
    ///   <para>rdfs:comment : Existence of limit for acceleration of train if stopping or recovering speed close to a level crossing expressed in a specific reference acceleration curve.</para>
    ///   <para>rdfs:label : Acceleration allowed near level crossing</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:XMLName : IHS_AccelerationLevelCrossing^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>skos:scopeNote : The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <para>era:dependencyNote : Mandatory value when the level crossing is defined</para>
    ///   <a href="http://data.europa.eu/949/accelerationLevelCrossing">era:accelerationLevelCrossing</a>
    /// </summary>
    let accelerationLevelCrossing = _prefixId.prefix "accelerationLevelCrossing"

    /// <summary>
    ///   <para>era:XMLName : CBP_BrakePerfDocRef^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Documents available by the IM relating to braking performance</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-04-23^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>rdfs:comment : Electronic document available in two EU languages from the IM stored by the Agency providing additional information as defined in point (2) of point 4.2.2.6.2 of TSI OPE.</para>
    ///   <para>skos:changeNote : Change from datatype property to object property in order to point to the class Document (reference document)</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.11.3^^xsd:string</para>
    ///   <para>skos:scopeNote : The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <para>era:dependencyNote : Only applicable when for parameter 1.1.1.3.11.2 True is selected</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <a href="http://data.europa.eu/949/additionalBrakingInformationDocument">era:additionalBrakingInformationDocument</a>
    /// </summary>
    let additionalBrakingInformationDocument = _prefixId.prefix "additionalBrakingInformationDocument"

    /// <summary>
    ///   <para>rdfs:label : affected Class</para>
    ///   <para>rdfs:comment : Annotation property used in SHACL shapes. Name of the classes that are the subject of properties that are being validated in a SHACL shape.</para>
    ///   <para>dcterms:created : 2024-11-04^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/affectedClass">era:affectedClass</a>
    /// </summary>
    let affectedClass = _prefixId.prefix "affectedClass"
    /// <summary>
    ///   <para>rdfs:label : affected Property</para>
    ///   <para>rdfs:comment : Annotation property used in SHACL shapes. Name of the properties that are being validated in a SHACL shape.</para>
    ///   <para>dcterms:created : 2024-11-04^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/affectedProperty">era:affectedProperty</a>
    /// </summary>
    let affectedProperty = _prefixId.prefix "affectedProperty"
    /// <summary>
    ///   <para>rdfs:label : aggregates</para>
    ///   <para>rdfs:comment : Specifies the linear elements aggregated by a non-linear element.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/aggregates">era:aggregates</a>
    /// </summary>
    let aggregates = _prefixId.prefix "aggregates"
    /// <summary>
    ///   <para>rdfs:label : allocation company</para>
    ///   <para>rdfs:comment : The organisation in charge to allocate the code for the subsidiary location.</para>
    ///   <para>dcterms:modified : 2024-10-24^^xsd:date</para>
    ///   <para>dcterms:created : 2024-05-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/allocationCompany">era:allocationCompany</a>
    /// </summary>
    let allocationCompany = _prefixId.prefix "allocationCompany"
    /// <summary>
    ///   <para>rdfs:comment : Alternative name of a vehicle type.</para>
    ///   <para>dcterms:modified : 2020-07-29^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:eratvIndex : 1.2^^xsd:string</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>rdfs:label : Vehicle Type - Alternative name</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/alternativeName">era:alternativeName</a>
    /// </summary>
    let alternativeName = _prefixId.prefix "alternativeName"
    /// <summary>
    ///   <para>rdfs:comment : Altitude range.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-26^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.3.2^^xsd:string</para>
    ///   <para>rdfs:label : Altitude range</para>
    ///   <a href="http://data.europa.eu/949/altitudeRange">era:altitudeRange</a>
    /// </summary>
    let altitudeRange = _prefixId.prefix "altitudeRange"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-26^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.3.2.1^^xsd:string</para>
    ///   <para>rdfs:label : Altitude range detail</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <para>rdfs:comment : Altitude range value for 'X' if value 'AX' is selected in altitude range.</para>
    ///   <a href="http://data.europa.eu/949/altitudeRangeDetail">era:altitudeRangeDetail</a>
    /// </summary>
    let altitudeRangeDetail = _prefixId.prefix "altitudeRangeDetail"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : applicable</para>
    ///   <para>rdfs:comment : Annotation used to point to the applicability of a parameter in RINF. Values are Y/N/NYA</para>
    ///   <para>dcterms:created : 2024-11-22^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/applicable">era:applicable</a>
    /// </summary>
    let applicable = _prefixId.prefix "applicable"
    /// <summary>
    ///   <para>rdfs:label : applies in both directions</para>
    ///   <para>rdfs:comment : Specifies if the section applies in both directions (optional).</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/appliesInBothDirections">era:appliesInBothDirections</a>
    /// </summary>
    let appliesInBothDirections = _prefixId.prefix "appliesInBothDirections"
    /// <summary>
    ///   <para>rdfs:comment : The direction relative to the origin of the linear element towards the point reference applies.</para>
    ///   <para>rdfs:label : applies to direction</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/appliesToDirection">era:appliesToDirection</a>
    /// </summary>
    let appliesToDirection = _prefixId.prefix "appliesToDirection"
    /// <summary>
    ///   <para>rdfs:label : Range of use of the platform boarding aid</para>
    ///   <para>rdfs:comment : Information of the train access level for which the boarding aid can be used.</para>
    ///   <para>era:rinfIndex : 1.2.1.0.6.7^^xsd:string</para>
    ///   <para>era:XMLName : IPL_AreaBoardingAid^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>skos:scopeNote : Information of the train access level for which the boarding aid can be used. Data is presented as the vertical difference that is overcome by the platform boarding aid in millimetres. The value “0” means that the platform is not equipped with a platform boarding aid.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2023-01-20^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-02^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/areaBoardingAid">era:areaBoardingAid</a>
    /// </summary>
    let areaBoardingAid = _prefixId.prefix "areaBoardingAid"
    /// <summary>
    ///   <para>rdfs:label : Existence of platform assistance for starting train</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2021-08-02^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:created : 2021-08-02^^xsd:date</para>
    ///   <para>rdfs:comment : Indication of existence of equipment or staff supporting the train crew in starting the train.</para>
    ///   <para>era:XMLName : IPL_AssistanceStartingTrain^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.0.6.6^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/assistanceStartingTrain">era:assistanceStartingTrain</a>
    /// </summary>
    let assistanceStartingTrain = _prefixId.prefix "assistanceStartingTrain"
    /// <summary>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:dependencyNote : Applicable when 'ATO Grade of Automation' is applicable</para>
    ///   <para>skos:scopeNote : ATO system communication system to the specification referenced in TSI CCS (4.2.4 &amp; 4.2.19).
    ///                            Parameter only applicable when ETCS Baseline &gt; 4 MR1 and ATO is implemented</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2024-12-05^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.10.3^^xsd:stringera:rinfIndex : 1.1.1.3.13.3^^xsd:string</para>
    ///   <para>era:XMLName : CAO_ATOCommSystem^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.9^^xsd:string</para>
    ///   <para>rdfs:comment : Supported ATO communication systems from trackside.</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:label : ATO communication system</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/atoCommunicationSystem">era:atoCommunicationSystem</a>
    /// </summary>
    let atoCommunicationSystem = _prefixId.prefix "atoCommunicationSystem"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : (Deprecated) ATO error corrections required for the on-board. Use: errorCorrectionsOnboard</para>
    ///   <para>rdfs:comment : List of unacceptable errors impacting the IM network that are required to be solved in the on-board ATO according to the CCS TSI point 7.2.10.3 specification maintenance point.</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.13.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/atoErrorCorrectionsOnboard">era:atoErrorCorrectionsOnboard</a>
    /// </summary>
    let atoErrorCorrectionsOnboard = _prefixId.prefix "atoErrorCorrectionsOnboard"
    /// <summary>
    ///   <para>era:dependencyNote : Parameter only applicable when ETCS Baseline &gt; 4 MR1 and ATO is implemented</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>skos:scopeNote : ATO is an optional function added in ETCS B4, only available under L2. See: TSI CCS, 4.2.4 &amp; 4.2.19.
    ///
    ///                        Parameter only applicable when ETCS Baseline &gt; 4 MR1 and ATO is implemented</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:XMLName : CAO_ATOGradeAutomation^^xsd:string</para>
    ///   <para>rdfs:label : ATO Grade of Automation</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.13.1^^xsd:stringera:rinfIndex : 1.2.1.1.10.1^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.8^^xsd:string</para>
    ///   <para>rdfs:comment : ATO grade of automation installed lineside.</para>
    ///   <a href="http://data.europa.eu/949/atoGradeAutomation">era:atoGradeAutomation</a>
    /// </summary>
    let atoGradeAutomation = _prefixId.prefix "atoGradeAutomation"
    /// <summary>
    ///   <para>era:dependencyNote : Applicable when 'ATO Grade of Automation' is applicable</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>skos:scopeNote : ATO is an optional function added in ETCS B4, only available under L2. See: TSI CCS, 4.2.4 &amp; 4.2.19.
    ///
    ///                      Parameter only applicable when ETCS Baseline &gt; 4 MR1 and ATO is implemented</para>
    ///   <para>rdfs:label : ATO System version</para>
    ///   <para>rdfs:comment : ATO system version according to the specification referenced in Appendix A-1, index [C]</para>
    ///   <para>era:rinfIndex : 1.2.1.1.10.2^^xsd:stringera:rinfIndex : 1.1.1.3.13.2^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.8^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:XMLName : CAO_ATOSystemvers^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/atoSystemVersion">era:atoSystemVersion</a>
    /// </summary>
    let atoSystemVersion = _prefixId.prefix "atoSystemVersion"
    /// <summary>
    ///   <para>dcterms:created : 2020-09-30^^xsd:date</para>
    ///   <para>dcterms:modified : 2020-09-30^^xsd:date</para>
    ///   <para>rdfs:label : authorized country</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the country(ies) in where a vehicle type has been authorized to operate.</para>
    ///   <a href="http://data.europa.eu/949/authorizedCountry">era:authorizedCountry</a>
    /// </summary>
    let authorizedCountry = _prefixId.prefix "authorizedCountry"

    /// <summary>
    ///   <para>rdfs:label : Automated Train Operation (ATO)</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.10^^xsd:stringera:rinfIndex : 1.1.1.3.13^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/automatedTrainOperationObjParameter">era:automatedTrainOperationObjParameter</a>
    /// </summary>
    let automatedTrainOperationObjParameter = _prefixId.prefix "automatedTrainOperationObjParameter"

    /// <summary>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:dependencyNote : A value is mandatory if the value  Overhead contact line (OCL)  is selected for parameter "Type of contact line system"</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:label : Automatic dropping device required</para>
    ///   <para>era:XMLName : ERS_AutoDropRequired^^xsd:string</para>
    ///   <para>era:formatNote : Y/N^^xsd:string</para>
    ///   <para>rdfs:seeAlso : LOC&amp;PAS TSI: 4.2.8.2.9.10
    /// EN 50206-1:2010^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>rdfs:comment : Indication of whether an automatic dropping device (ADD) required on the vehicle.</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.5.3^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/automaticDroppingDeviceRequired">era:automaticDroppingDeviceRequired</a>
    /// </summary>
    let automaticDroppingDeviceRequired = _prefixId.prefix "automaticDroppingDeviceRequired"

    /// <summary>
    ///   <para>rdfs:comment : Axle bearing condition monitoring.</para>
    ///   <para>dcterms:modified : 2021-08-02^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.9.2^^xsd:string</para>
    ///   <para>rdfs:label : axle bearing condition monitoring</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/axleBearingConditionMonitoring">era:axleBearingConditionMonitoring</a>
    /// </summary>
    let axleBearingConditionMonitoring = _prefixId.prefix "axleBearingConditionMonitoring"

    /// <summary>
    ///   <para>rdfs:comment : Position of the axles along the unit. a: Distance between axles; b: Distance from end axle to the end of the nearest coupling plane; c: distance between two inside axles.</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Axle spacing</para>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.5.3.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/axleSpacing">era:axleSpacing</a>
    /// </summary>
    let axleSpacing = _prefixId.prefix "axleSpacing"
    /// <summary>
    ///   <para>rdfs:label : belongs to</para>
    ///   <para>rdfs:comment : Indicates that an infrastructure element belongs to a certain subset that contains common characteristics.</para>
    ///   <para>dcterms:created : 2024-05-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2024-10-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/belongsTo">era:belongsTo</a>
    /// </summary>
    let belongsTo = _prefixId.prefix "belongsTo"
    /// <summary>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>rdfs:comment : Indication of existence of metal mass in the vicinity of the location, susceptible of perturbating the reading of balises by the on-board system.</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.18^^xsd:stringera:rinfIndex : 1.2.1.1.1.18^^xsd:string</para>
    ///   <para>era:XMLName : CEN_BigMetalMass^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.10^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guideera:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>rdfs:label : Big Metal Mass</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:formatNote : Y/N^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : According to the specification referenced in TSI CCS.</para>
    ///   <a href="http://data.europa.eu/949/bigMetalMass">era:bigMetalMass</a>
    /// </summary>
    let bigMetalMass = _prefixId.prefix "bigMetalMass"
    /// <summary>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.12.3.2^^xsd:string</para>
    ///   <para>rdfs:comment : Description of any integrated boarding aids (if provided).</para>
    ///   <para>rdfs:label : Boarding aids</para>
    ///   <a href="http://data.europa.eu/949/boardingAids">era:boardingAids</a>
    /// </summary>
    let boardingAids = _prefixId.prefix "boardingAids"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Border point identification</para>
    ///   <para>rdfs:comment : Border point identification in the list of reference border points in the RINF application guide.</para>
    ///   <para>dcterms:created : 2024-11-26</para>
    ///   <a href="http://data.europa.eu/949/borderPointId">era:borderPointId</a>
    /// </summary>
    let borderPointId = _prefixId.prefix "borderPointId"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2024-10-25^^xsd:date</para>
    ///   <para>dcterms:created : 2023-01-20^^xsd:date</para>
    ///   <para>rdfs:comment : Relates the information that each country maintains on a border point, to the operational point that represents the general information on the border point.</para>
    ///   <para>rdfs:label : border point of</para>
    ///   <a href="http://data.europa.eu/949/borderPointOf">era:borderPointOf</a>
    /// </summary>
    let borderPointOf = _prefixId.prefix "borderPointOf"
    /// <summary>
    ///   <para>rdfs:label : Brake related parameters</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.11^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/brakeRelatedDataParameter">era:brakeRelatedDataParameter</a>
    /// </summary>
    let brakeRelatedDataParameter = _prefixId.prefix "brakeRelatedDataParameter"
    /// <summary>
    ///   <para>rdfs:label : Brake related parameters</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.11^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/brakeRelatedObjParameter">era:brakeRelatedObjParameter</a>
    /// </summary>
    let brakeRelatedObjParameter = _prefixId.prefix "brakeRelatedObjParameter"
    /// <summary>
    ///   <para>era:eratvIndex : 4.7.6^^xsd:string</para>
    ///   <para>rdfs:comment : Brake weight percentage (lambda) or Braked mass.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Brake weight percentage</para>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/brakeWeightPercentage">era:brakeWeightPercentage</a>
    /// </summary>
    let brakeWeightPercentage = _prefixId.prefix "brakeWeightPercentage"
    let bridgeWindRestriction = _prefixId.prefix "bridgeWindRestriction"
    /// <summary>
    ///   <para>rdfs:label : Canonical URI</para>
    ///   <para>rdfs:comment : The canonical URI is defined for each instance of an Infrastructure element, e.g. section of line, operational point, track, tunnel, siding.
    /// Objects of the infrastructure generated through RML mappings include (when provided) their validity start and end dates. With its identifier, plus all identifiers of its "parent" elements, and its validity dates, a hash URI is generated.
    /// The canonical URI is the element's URI with its identifiers and without the validity dates. All of the hash URIs of an element point to its canonical URI.
    /// Additionally, SoLs point to the canonical URIs of their start OP and end OP.</para>
    ///   <para>dcterms:modified : 2024-02-06^^xsd:date</para>
    ///   <para>dcterms:created : 2022-12-13^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/canonicalURI">era:canonicalURI</a>
    /// </summary>
    let canonicalURI = _prefixId.prefix "canonicalURI"
    /// <summary>
    ///   <para>rdfs:comment : Cant deficiency (maximum uncompensated lateral acceleration) for which the vehicle has been assessed. For dual gauge vehicles values for each gauge have to be indicated.</para>
    ///   <para>rdfs:label : Cant defficiency</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>era:eratvIndex : 4.6.1^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:datedcterms:modified : 2025-03-05^^xsd:datedcterms:modified : 2024-06-26^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-26^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/cantDefficiency">era:cantDefficiency</a>
    /// </summary>
    let cantDefficiency = _prefixId.prefix "cantDefficiency"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-09-10^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>rdfs:seeAlso : INF TSI: 4.2.4.3^^xsd:string</para>
    ///   <para>skos:scopeNote : In case of positive value of cant deficiency or zero symbol  '+' shall be applied. In case of negative cant deficiency symbol '-' has to be selected. Value of the cant deficiency shall be given in millimetres. In case of lateral uncompensated acceleration on a 1435 mm track gauge of 1.0 m/s2 the value of 153 mm may be published.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:rinfIndex : 1.1.1.1.4.2^^xsd:string</para>
    ///   <para>rdfs:label : Cant deficiency</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>era:XMLName : ITP_CantDeficiency^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:formatNote : +/-NNN^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Maximum cant deficiency expressed in millimetres defined as difference between the applied cant and a higher equilibrium cant the line has been designed for.</para>
    ///   <a href="http://data.europa.eu/949/cantDeficiency">era:cantDeficiency</a>
    /// </summary>
    let cantDeficiency = _prefixId.prefix "cantDeficiency"
    /// <summary>
    ///   <para>rdfs:label : Cant Deficiency used for the basic SSP</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>rdfs:comment : Essential information for railway undertakings with a worse (lower) tolerated cant deficiency than those for which the ETCS trackside provides SSP (Static Speed Profiles) in conjunction with parameter "Other Cant Deficiency train categories for which the ETCS trackside is configured to provide SSP".</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.14^^xsd:stringera:rinfIndex : 1.1.1.3.2.14^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.3^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>skos:scopeNote : The values indicated in millimetres correspond to tracks with UIC gauge. For tracks with a gauge different from UIC, the values provided here are the equivalent ones for UIC gauge, as the actual physical cant deficiency values differ. Please refer to parameter 1.1.1.1.4.2 for more details.
    ///                            Subset-026 (3.11.3.2.1.1) definition:
    /// a) The "Cant Deficiency" SSP categories: the cant deficiency value assigned to one category shall define the maximum speed, determined by suspension design, at which a particular train can traverse a curve and thus can be used to set a specific speed limit in a curve with regards to this category.</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/cantDeficiencyBasicSSP">era:cantDeficiencyBasicSSP</a>
    /// </summary>
    let cantDeficiencyBasicSSP = _prefixId.prefix "cantDeficiencyBasicSSP"
    /// <summary>
    ///   <para>rdfs:label : carrier linear element</para>
    ///   <para>rdfs:comment : The carrier linear element in relation to which the orientation is based on</para>
    ///   <para>dcterms:created : 2025-01-30^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/carrierLinearElement">era:carrierLinearElement</a>
    /// </summary>
    let carrierLinearElement = _prefixId.prefix "carrierLinearElement"
    /// <summary>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-02-13^^xsd:datedcterms:modified : 2021-08-03^^xsd:date</para>
    ///   <para>era:eratvIndex : 1.4^^xsd:string</para>
    ///   <para>rdfs:comment : (Deprecated) Vehicle category.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/category">era:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:comment : Maximum rated current from the catenary (to be indicated for each electrical energy supply system the vehicle is equipped for), given in A.</para>
    ///   <para>era:eratvIndex : 4.10.3^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:label : Catenary max rated current</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/catenaryMaxRatedCurrent">era:catenaryMaxRatedCurrent</a>
    /// </summary>
    let catenaryMaxRatedCurrent = _prefixId.prefix "catenaryMaxRatedCurrent"
    /// <summary>
    ///   <para>rdfs:label : Control-command and signalling subsystem</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/ccsSubsystemDataParameter">era:ccsSubsystemDataParameter</a>
    /// </summary>
    let ccsSubsystemDataParameter = _prefixId.prefix "ccsSubsystemDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Declarations of verification for track</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/ccsSubsystemDeclarationsVerificationTrackDataParameter">era:ccsSubsystemDeclarationsVerificationTrackDataParameter</a>
    /// </summary>
    let ccsSubsystemDeclarationsVerificationTrackDataParameter = _prefixId.prefix "ccsSubsystemDeclarationsVerificationTrackDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Declarations of verification for track</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/ccsSubsystemDeclarationsVerificationTrackObjParameter">era:ccsSubsystemDeclarationsVerificationTrackObjParameter</a>
    /// </summary>
    let ccsSubsystemDeclarationsVerificationTrackObjParameter = _prefixId.prefix "ccsSubsystemDeclarationsVerificationTrackObjParameter"

    /// <summary>
    ///   <para>rdfs:label : Control-command and signalling subsystem</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/ccsSubsystemObjParameter">era:ccsSubsystemObjParameter</a>
    /// </summary>
    let ccsSubsystemObjParameter = _prefixId.prefix "ccsSubsystemObjParameter"
    /// <summary>
    ///   <para>dcterms:modified : 2022-11-15^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2024-10-30^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : For this Vehicle Type, the type or design examination certificate described in the relevant verification module as issued by
    /// Notified Bodies, supporting the EC Declaration(s) of Verification for the subsystems in scope of the type's authorisation by an authorizing entity.</para>
    ///   <para>rdfs:label : Certificate</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2022-06-15^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/certificate">era:certificate</a>
    /// </summary>
    let certificate = _prefixId.prefix "certificate"
    /// <summary>
    ///   <para>dcterms:created : 2023-04-04^^xsd:date</para>
    ///   <para>rdfs:label : Company code category</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2024-10-25^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Category of a Railway company. Can be Infrastructure, Freight or Passenger. Deprecated as it will be integrated with the Organisations properties.</para>
    ///   <a href="http://data.europa.eu/949/companyCodeCategory">era:companyCodeCategory</a>
    /// </summary>
    let companyCodeCategory = _prefixId.prefix "companyCodeCategory"

    /// <summary>
    ///   <para>skos:changeNote : Change from datatype property to object property in order to point to the class Document (reference document)</para>
    ///   <para>rdfs:label : Document with the procedure(s) for static and dynamic route compatibility checks</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-04-23^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Electronic document available in two EU languages from the IM stored by the Agency with:
    /// - precise procedures for the static and dynamic route compatibility checks;
    /// Or
    /// - relevant information for carrying out the checks for specific structures.</para>
    ///   <para>skos:scopeNote : The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:XMLName : IPP_StructureCheckDocRef^^xsd:string</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>era:rinfIndex : 1.1.1.1.2.4.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/compatibilityProcedureDocument">era:compatibilityProcedureDocument</a>
    /// </summary>
    let compatibilityProcedureDocument = _prefixId.prefix "compatibilityProcedureDocument"

    /// <summary>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:XMLName : ITU_TSITunnel^^xsd:string</para>
    ///   <para>era:dependencyNote : Mandatory if the speed of the line is equal or greater than 200km/h </para>
    ///   <para>rdfs:seeAlso : [4.2.10.1 of INF TSI on Maximum pressure variations in tunnels | ]^^xsd:stringrdfs:seeAlso : https://eur-lex.europa.eu/eli/reg/2014/1299/2023-09-28#:~:text=4.2.10.1.%C2%A0%C2%A0%C2%A0%20Maximum%20pressure%20variations%20in%20tunnels^^xsd:anyURI</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Compliance of the tunnel with TSI INF</para>
    ///   <para>rdfs:comment : Compliance of the tunnel with TSI INF at the maximum permitted speed</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:legalDeadline : 1 January 2021</para>
    ///   <para>era:rinfIndex : 1.1.1.1.8.8.1^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/complianceInfTsi">era:complianceInfTsi</a>
    /// </summary>
    let complianceInfTsi = _prefixId.prefix "complianceInfTsi"

    /// <summary>
    ///   <para>dcterms:created : 2020-11-23^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates if a vehicle's composite brake block is retrofitted</para>
    ///   <para>dcterms:modified : 2020-11-23^^xsd:date</para>
    ///   <para>rdfs:label : Composite brake block retrofitted</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/compositeBrakeBlockRetrofitted">era:compositeBrakeBlockRetrofitted</a>
    /// </summary>
    let compositeBrakeBlockRetrofitted = _prefixId.prefix "compositeBrakeBlockRetrofitted"

    /// <summary>
    ///   <para>era:XMLName : ECS_RegenerativeBraking^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-01-20^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-12-10^^xsd:datedcterms:modified : 2024-09-25^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.3.7^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.2.2.4^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>rdfs:label : Permission for regenerative braking</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:comment : Indication whether regenerative braking is permitted, not permitted, or permitted under specific conditions.</para>
    ///   <para>skos:scopeNote : When regenerative braking is "allowed under conditions", a document must be provided under 1.1.1.2.2.4.1.
    ///
    /// For RINF XML data sets:
    /// As long as the data provision through XML data sets is allowed, an XML attribute called “Set” will be used to link the value of this parameter to the parameter 1.1.1.2.2.1.1 / ECS_SystemType</para>
    ///   <para>era:dependencyNote : When `not electrified` is chosen in parameter 1.1.1.2.2.1.1, then this parameter is not applicable. </para>
    ///   <a href="http://data.europa.eu/949/conditionalRegenerativeBrake">era:conditionalRegenerativeBrake</a>
    /// </summary>
    let conditionalRegenerativeBrake = _prefixId.prefix "conditionalRegenerativeBrake"

    /// <summary>
    ///   <para>rdfs:comment : Name and/or reference of the document specifying the conditions applying in regards to regenerative braking.</para>
    ///   <para>era:XMLName : ECS_ConditionRegBraking^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Conditions applying in regards to regenerative braking</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-11-04^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.2.4.1^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.3.7^^xsd:string</para>
    ///   <para>era:dependencyNote : When `not electrified` is chosen in parameter 1.1.1.2.2.1.1, then this parameter is not applicable. Mandatory when parameter 1.1.1.2.2.4 announces Conditions.</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>dcterms:created : 2022-11-10^^xsd:date</para>
    ///   <para>skos:scopeNote : The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <a href="http://data.europa.eu/949/conditionsAppliedRegenerativeBraking">era:conditionsAppliedRegenerativeBraking</a>
    /// </summary>
    let conditionsAppliedRegenerativeBraking = _prefixId.prefix "conditionsAppliedRegenerativeBraking"

    /// <summary>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.0.7.2^^xsd:string</para>
    ///   <para>era:legalDeadline : Contrary to the Regulation, the deadline is not 30 June 2024 at the latest, but 12 months after publication of Article 7 Guide</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Permitted conditions for charging electric energy storage for traction purposes at standstill</para>
    ///   <para>rdfs:comment : Conditions set by IMs according to a standardised document</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/conditionsChargingElectricEnergyStorage">era:conditionsChargingElectricEnergyStorage</a>
    /// </summary>
    let conditionsChargingElectricEnergyStorage = _prefixId.prefix "conditionsChargingElectricEnergyStorage"

    /// <summary>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:comment : Name and/or reference of the document specifying the Special technical conditions required to switch over between ERTMS/ETCS and Class B systems.</para>
    ///   <para>dcterms:created : 2022-10-28^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.8.3^^xsd:stringera:rinfIndex : 1.2.1.1.7.3^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.3^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-11-04^^xsd:datedcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:XMLName : CTS_SwitchERTMSClassBCondition^^xsd:string</para>
    ///   <para>skos:scopeNote : The details of the conditions to switch between Class B train protection systems must be published.
    ///
    /// The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:dependencyNote : Applicable when at least two different class of protection systems exist.</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:label : Special technical conditions required to switch over between ERTMS/ETCS and Class B systems</para>
    ///   <a href="http://data.europa.eu/949/conditionsSwitchClassBSystems">era:conditionsSwitchClassBSystems</a>
    /// </summary>
    let conditionsSwitchClassBSystems = _prefixId.prefix "conditionsSwitchClassBSystems"

    /// <summary>
    ///   <para>era:XMLName : CTS_SwitchProtectControlWarnCondition^^xsd:string</para>
    ///   <para>rdfs:label : Special conditions to switch over between different class B train protection, control and warning systems</para>
    ///   <para>dcterms:created : 2022-10-28^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.7.1.1^^xsd:stringera:rinfIndex : 1.1.1.3.8.1.1^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:dependencyNote : Applicable when at least two different protection, control and warning systems exist.</para>
    ///   <para>skos:scopeNote : Switch over between different systems whilst running. Installation depends on local conditions. </para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Conditions to switch over between different class B train protection, control and warning systems.</para>
    ///   <para>era:formatNote : NNN^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.2^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <a href="http://data.europa.eu/949/conditionsSwitchTrainProtectionSystems">era:conditionsSwitchTrainProtectionSystems</a>
    /// </summary>
    let conditionsSwitchTrainProtectionSystems = _prefixId.prefix "conditionsSwitchTrainProtectionSystems"

    /// <summary>
    ///   <para>dcterms:modified : 2021-08-25^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.1.4^^xsd:string</para>
    ///   <para>rdfs:comment : Conditions of use regarding train formation.</para>
    ///   <para>rdfs:label : Conditions train formation</para>
    ///   <para>dcterms:created : 2021-08-25^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/conditionsTrainFormation">era:conditionsTrainFormation</a>
    /// </summary>
    let conditionsTrainFormation = _prefixId.prefix "conditionsTrainFormation"
    /// <summary>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:seeAlso : 4.2.2.1.3.2 of TSI OPE (Commission Implementing Regulation (EU) 2019/773 of 16 May 2019)^^xsd:string</para>
    ///   <para>rdfs:label : Conditions for use of reflective plates</para>
    ///   <para>era:rinfIndex : 1.1.1.1.7.12.1^^xsd:string</para>
    ///   <para>rdfs:comment : Details of any conditions for using the reflective plates on freight corridors. Specific case for Portugal and Spain until 1.1.2025 and Belgium and France until 1.1.2026.</para>
    ///   <para>skos:scopeNote : From TSI OPE: Member States shall in particular endeavour to permit the use of reflective plates on rail freight corridors, with a view to prioritise the current bottlenecks. These sections and details of any conditions pertaining to them shall be recorded in the RINF. Until the information is encoded in RINF, the infrastructure manager shall ensure the information is communicated to railway undertakings by other appropriate means. The infrastructure manager shall identify the sections of lines on which 2 steady red lights are required in the RINF. </para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2026-01-22^^xsd:datedcterms:modified : 2024-09-24^^xsd:date</para>
    ///   <para>era:dependencyNote : A value is mandatory if the value of parameter "Permit of use of reflective plates" is boolean "Yes"</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/conditionsUseReflectivePlates">era:conditionsUseReflectivePlates</a>
    /// </summary>
    let conditionsUseReflectivePlates = _prefixId.prefix "conditionsUseReflectivePlates"
    /// <summary>
    ///   <para>dcterms:created : 2025-03-10^^xsd:date</para>
    ///   <para>rdfs:comment : Represents a bidirectional connection between two Track instances.</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:rinfIndex : 1.2.4.1^^xsd:stringera:rinfIndex : 1.1.1.0.1.2^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>skos:altLabel : Internal connectionskos:altLabel : Tracks connectivity to operational points</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : connected to</para>
    ///   <para>skos:scopeNote : This property defines a connection between two tracks. It is symmetric, meaning if a track A is connected to track B, then track B is also connected to track A. A track cannot be connected to itself (irreflexive property).
    /// Used to indicate connectivity between track instances in a network, ensuring that connections are non-self-referential and in the normal running direction of the track.
    ///
    /// This is a simplistic representation of the internal connectivity of the tracks in an operational point or the connectivity of the tracks between operational points and sections of line.
    /// For a more detailed representation of connectivity and navigability, this information should be available on the topology of the network.</para>
    ///   <para>skos:example : Track_A connectedTo Track_B implies Track_B connectedTo Track_A.</para>
    ///   <a href="http://data.europa.eu/949/connectedTo">era:connectedTo</a>
    /// </summary>
    let connectedTo = _prefixId.prefix "connectedTo"
    /// <summary>
    ///   <para>rdfs:label : contact line system</para>
    ///   <para>skos:scopeNote : It can be repeated as many times as the number of different contact line system types are present.
    ///
    /// For RDF data provision:
    /// The value of this property is an instance of the era:ContactLineSystem, which has as properties the parameters 1.1.1.2.2.1.2, 1.1.1.2.2.2, 1.1.1.2.2.4 and 1.1.1.2.5.1.
    ///
    /// For RINF XML data sets:
    /// As long as the data provision through XML data sets is allowed, this property is the equivalent of the "Set" attribute, grouping parameters 1.1.1.2.2.1.2, 1.1.1.2.2.2, 1.1.1.2.2.4 and 1.1.1.2.5.1.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : System that is used to transmit electrical energy to road or rail vehicles.</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2021-09-11^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/contactLineSystem">era:contactLineSystem</a>
    /// </summary>
    let contactLineSystem = _prefixId.prefix "contactLineSystem"

    /// <summary>
    ///   <para>rdfs:label : Contact line system</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/contactLineSystemDataParameter">era:contactLineSystemDataParameter</a>
    /// </summary>
    let contactLineSystemDataParameter = _prefixId.prefix "contactLineSystemDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Contact line system</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/contactLineSystemObjParameter">era:contactLineSystemObjParameter</a>
    /// </summary>
    let contactLineSystemObjParameter = _prefixId.prefix "contactLineSystemObjParameter"
    /// <summary>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2021-08-06^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.2.1.1^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-06^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Indication of the type of the contact line system.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:XMLName : ECS_SystemType^^xsd:string</para>
    ///   <para>era:dependencyNote : If this parameter is repeated, parameters 1.1.1.2.2.1.2, and 1.1.1.2.2.2 shall be created also for the corresponding type. These two parameters are to be considered children of the current. </para>
    ///   <para>rdfs:label : Type of contact line system</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : When the value is "not electrified", then all parameters 1.1.1.2.2.1.2 - 1.1.1.2.5.3 are not applicable.
    /// When the value is “Third Rail” or “Fourth Rail”, then parameters 1.1.1.2.2.3, 1.1.1.2.2.5 - 1.1.1.2.4.2.3, 1.1.1.2.5.2 and 1.1.1.2.5.3 are not applicable
    ///
    /// For RINF XML data sets:
    /// As long as the data provision through XML data sets is allowed, if this parameter is repeated, parameters 1.1.1.2.2.1.2, 1.1.1.2.2.2, 1.1.1.2.2.4 and 1.1.1.2.5.1 shall be created also for the corresponding type. These four parameters are to be considered children of the current.
    /// For grouping “children” parameters of the current parameter, an XML attribute called “set” must be declared at the parent and children levels with the same keyword value.</para>
    ///   <a href="http://data.europa.eu/949/contactLineSystemType">era:contactLineSystemType</a>
    /// </summary>
    let contactLineSystemType = _prefixId.prefix "contactLineSystemType"
    /// <summary>
    ///   <para>skos:scopeNote : [NN] for impregnated carbon concern the metallic content in %. In case of selection of this option, the respective value of the metallic content has to be added. [NN] is the maximum percentage allowed.
    ///
    /// In case of permitted material different than specified in predefined list, send ERA a change request.
    ///
    /// When more than one value of the parameter has to be published, then parameter will to be repeated as many times as the number of values.</para>
    ///   <para>era:dependencyNote : Mandatory only if “Overhead contact line (OCL)” is selected in 1.1.1.2.2.1.1, otherwise the parameter is not applicable.</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : LOC&amp;PAS TSI: 4.2.8.2.9.4.2^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of which contact strip materials are permitted to be used.</para>
    ///   <para>dcterms:modified : 2024-09-25^^xsd:datedcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.3.4^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:eratvIndex : 4.10.10^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:XMLName : EPA_StripMaterial^^xsd:string</para>
    ///   <para>rdfs:label : Permitted contact strip material</para>
    ///   <a href="http://data.europa.eu/949/contactStripMaterial">era:contactStripMaterial</a>
    /// </summary>
    let contactStripMaterial = _prefixId.prefix "contactStripMaterial"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:dependencyNote : Mandatory only if impregnated carbon ([NN] % of metallic content)” is selected in 1.1.1.2.3.4, otherwise no value should be provided</para>
    ///   <para>dcterms:modified : 2024-09-25^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>rdfs:label : Contact strip material metallic content</para>
    ///   <para>skos:scopeNote : In case that the value of the property era:contactStripMaterial is "impregnated carbon", it is the metallic content in % (this value must be added). This is the maximum percentage allowed.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:XMLName : EPA_StripMaterial^^xsd:string</para>
    ///   <para>rdfs:seeAlso : LOC&amp;PAS TSI: 4.2.8.2.9.4.2^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.2.3.4^^xsd:string</para>
    ///   <para>dcterms:created : 2023-01-25^^xsd:date</para>
    ///   <para>rdfs:comment : Indication of max. percentage of contact strip material Impregnated Carbon permitted to be used.^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/contactStripMaterialMetallicContent">era:contactStripMaterialMetallicContent</a>
    /// </summary>
    let contactStripMaterialMetallicContent = _prefixId.prefix "contactStripMaterialMetallicContent"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : container handling flag</para>
    ///   <para>dcterms:created : 2024-06-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/containerHandlingFlag">era:containerHandlingFlag</a>
    /// </summary>
    let containerHandlingFlag = _prefixId.prefix "containerHandlingFlag"
    /// <summary>
    ///   <para>rdfs:label : contains</para>
    ///   <para>rdfs:comment : Indicates that a subset with common characteristics contains a certain infrastructure element.</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/contains">era:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : [4.2.10.1 of INF TSI on Maximum pressure variations in tunnels | ^^xsd:stringrdfs:seeAlso : https://eur-lex.europa.eu/eli/reg/2014/1299/2023-09-28#:~:text=4.2.10.1.%C2%A0%C2%A0%C2%A0%20Maximum%20pressure%20variations%20in%20tunnels^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Smallest cross section area in square metres of the tunnel</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2021-08-03^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>era:dependencyNote : Mandatory if the speed of the line is equal or greater than 200km/h </para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:label : Cross section area</para>
    ///   <para>era:rinfIndex : 1.1.1.1.8.8^^xsd:string</para>
    ///   <para>era:XMLName : ITU_CrossSectionArea^^xsd:string</para>
    ///   <para>skos:scopeNote : Smallest real cross section area (expressed in square metres) of the tunnel.
    ///
    /// Reference: 4.2.10.1 of INF TSI on Maximum pressure variations in tunnels.</para>
    ///   <para>era:formatNote : NNN^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/crossSectionArea">era:crossSectionArea</a>
    /// </summary>
    let crossSectionArea = _prefixId.prefix "crossSectionArea"
    /// <summary>
    ///   <para>era:dependencyNote : When "not electrified" is chosen in parameter "Type of contact line system", then this parameter is not applicable. </para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>era:formatNote : Y/N^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <para>rdfs:seeAlso :  LOC&amp;PAS TSI: 4.2.8.2.4^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:label : Current or power limitation on board required</para>
    ///   <para>rdfs:comment : Indication of whether an on board current or power limitation function on vehicles is required.</para>
    ///   <para>era:XMLName : ERS_PowerLimitOnBoard^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.2.5.1^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/currentLimitationRequired">era:currentLimitationRequired</a>
    /// </summary>
    let currentLimitationRequired = _prefixId.prefix "currentLimitationRequired"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Currently valid</para>
    ///   <para>dcterms:created : 2022-12-13^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/currentlyValid">era:currentlyValid</a>
    /// </summary>
    let currentlyValid = _prefixId.prefix "currentlyValid"
    /// <summary>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-12-05^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:formatNote : NNNNNNN.N whereby the last digit is only used when Q_SCALE = 10 CM^^xsd:string</para>
    ///   <para>dcterms:created : 2022-11-07^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.16.5^^xsd:stringera:rinfIndex : 1.2.1.1.1.16.5^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>rdfs:label : D_NVOVTRP</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.5.5^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>skos:scopeNote : Precision: the value must be expressed in meter.
    ///
    /// Depending on the chosen Q_SCALE, the maximal value will be: +327670 M, +32767 M or +3276.7 M.
    ///
    /// As in TSI CCS Subset 26, chapter 7. 7.5.1.15 D_NVOVTRP.</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>rdfs:comment : Maximum distance for overriding the train trip in metres, according to the specification referenced in Appendix A-1, index [C].</para>
    ///   <a href="http://data.europa.eu/949/dNvovtrp">era:dNvovtrp</a>
    /// </summary>
    let dNvovtrp = _prefixId.prefix "dNvovtrp"
    /// <summary>
    ///   <para>rdfs:label : D_NVPOTRP</para>
    ///   <para>rdfs:comment : Maximum distance for reversing in Post Trip mode in metres, according to the specification referenced in Appendix A-1, index [C].</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.16.7^^xsd:stringera:rinfIndex : 1.1.1.3.2.16.7^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2022-11-07^^xsd:date</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-12-05^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:formatNote : NNNNNNN.N whereby the last digit is only used when Q_SCALE = 10 CM^^xsd:string</para>
    ///   <para>skos:scopeNote : Precision: the value must be expressed in meter.
    ///
    /// Depending on the chosen Q_SCALE, the maximal value will be: +327670 M, +32767 M or +3276.7 M.
    ///
    /// See: TSI CCS (Subset 26, chapter 7. 7.5.1.16 D_NVPOTRP)</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.5.7^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/dNvpotrp">era:dNvpotrp</a>
    /// </summary>
    let dNvpotrp = _prefixId.prefix "dNvpotrp"
    /// <summary>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-12-05^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>rdfs:comment : Parameter used by the ETCS on-board to supervise the distance allowed to be travelled under the roll-away protection and the reverse movement protection, in metres
    /// According to the specification referenced in Appendix A-1, index [C]</para>
    ///   <para>rdfs:label : D_NVROLL</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.16.1^^xsd:stringera:rinfIndex : 1.2.1.1.1.16.1^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.5.1^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>era:formatNote : A number of form at NNNNNN.N, from 0 to 327670^^xsd:string</para>
    ///   <para>skos:scopeNote : Precision: [NNNNNN.N], with N a decimal number (0 9).
    ///
    /// See: TSI CCS (Subset 26, chapter 7. 7.5.1.17 D_NVROLL)</para>
    ///   <para>dcterms:created : 2022-11-07^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/dNvroll">era:dNvroll</a>
    /// </summary>
    let dNvroll = _prefixId.prefix "dNvroll"
    /// <summary>
    ///   <para>dcterms:modified : 2021-08-25^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Dangerous goods for which the vehicle is suitable (tank code).</para>
    ///   <para>era:eratvIndex : 4.1.9^^xsd:string</para>
    ///   <para>rdfs:label : Dangerous goods tank code</para>
    ///   <para>dcterms:created : 2021-08-25^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/dangerousGoodsTankCode">era:dangerousGoodsTankCode</a>
    /// </summary>
    let dangerousGoodsTankCode = _prefixId.prefix "dangerousGoodsTankCode"
    /// <summary>
    ///   <para>dcterms:modified : 2021-08-02^^xsd:date</para>
    ///   <para>rdfs:comment : Data SIM Card GSM-R Home Network.</para>
    ///   <para>rdfs:label : Data GSM-R network</para>
    ///   <para>era:eratvIndex : 4.13.2.11^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/dataGSMRNetwork">era:dataGSMRNetwork</a>
    /// </summary>
    let dataGSMRNetwork = _prefixId.prefix "dataGSMRNetwork"
    /// <summary>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-05/esc-rsc_technical_document_en.pdf^^xsd:anyURIrdfs:seeAlso : https://www.era.europa.eu/era-folder/radio-system-compatibility-rsc-voice-and-data-documents^^xsd:anyURI</para>
    ///   <para>era:rinfIndex : 1.2.1.1.2.10^^xsd:stringera:rinfIndex : 1.1.1.3.3.10^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Radio requirements used for demonstrating technical compatibility data.</para>
    ///   <para>era:dependencyNote : GSM-R  and ETCS L2 must be installed for this parameter to be applicable.</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : 16 January 2020</para>
    ///   <para>dcterms:created : 2020-08-31^^xsd:date</para>
    ///   <para>era:XMLName : CRG_RadioCompData^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.13.2.8^^xsd:string</para>
    ///   <para>skos:scopeNote : Information on RSC data requirements per country.
    ///
    /// Vehicles are considered compatible with the infrastructure regarding this parameter, if any of the values declared matches.
    /// In case the value “Not Defined” or “RSC-EU-0” is used, repetitions with additional values are not expected.</para>
    ///   <para>rdfs:label : Radio system compatibility data</para>
    ///   <a href="http://data.europa.eu/949/dataRadioCompatible">era:dataRadioCompatible</a>
    /// </summary>
    let dataRadioCompatible = _prefixId.prefix "dataRadioCompatible"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2022-11-04^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:label : Defines subset</para>
    ///   <para>rdfs:comment : (deprecated) not in use anymore. For the purposes of the register of infrastructure, each infrastructure manager may describe its railway network optionally via common characteristic subsets.</para>
    ///   <a href="http://data.europa.eu/949/definesSubset">era:definesSubset</a>
    /// </summary>
    let definesSubset = _prefixId.prefix "definesSubset"
    /// <summary>
    ///   <para>rdfs:label : EI declaration of demonstration (as defined Recommendation 2014/881/EU) for track relating to compliance with the requirements from TSIs applicable to energy subsystem</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>rdfs:comment : Unique number for EI declarations following the same format requirements as specified for EC declarations in Annex VII of Commission Implementing Regulation (EU) 2019/250.</para>
    ///   <para>era:rinfIndex : 1.1.1.2.1.2^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:XMLName : EDE_EIDemonstration^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <a href="http://data.europa.eu/949/demonstrationENE">era:demonstrationENE</a>
    /// </summary>
    let demonstrationENE = _prefixId.prefix "demonstrationENE"
    /// <summary>
    ///   <para>rdfs:comment : Unique number for EI declarations following the same format requirements as specified for EC declarations in Annex VII of Commission Implementing Regulation (EU) 2019/250.</para>
    ///   <para>skos:scopeNote : It may happen that several EI declarations were issued - then parameter has to be repeated as many times as many declarations were issued.
    ///
    /// The procedure for demonstration that existing network fits to requirements of the TSIs is executed on voluntary basis, so when EI declaration do not exist then the parameter is optional. If EI declaration was not issued, then field shall be left empty. skos:scopeNote : EI declaration of demonstration (as defined Commission 2014/881/EU) for track relating to compliance with the requirements from TSIs applicable to infrastructure subsystem.
    ///
    /// It may happen that several EI declarations were issued - then parameter has to be repeated as many times as many declarations were issued.
    ///
    /// The procedure for demonstration that existing network fits to requirements of the TSIs is executed on voluntary basis, so when EI declaration do not exist then the parameter is optional. If EI declaration was not issued, then field shall be left empty. </para>
    ///   <para>era:rinfIndex : 1.2.2.0.1.2^^xsd:stringera:rinfIndex : 1.1.1.1.1.2^^xsd:stringera:rinfIndex : 1.2.1.0.1.2^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>era:XMLName : IDE_EIDemonstration^^xsd:string</para>
    ///   <para>rdfs:label : EI declaration of demonstration (as defined in Commission 2014/881/EU (2)) relating to compliance with the requirements from TSIs applicable to infrastructure subsystem</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:formatNote : CC/RRRRRRRRRRRRRR/YYYY/NNNNNN^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/demonstrationINF">era:demonstrationINF</a>
    /// </summary>
    let demonstrationINF = _prefixId.prefix "demonstrationINF"
    /// <summary>
    ///   <para>era:rinfIndex : 1.2.1.0.5.4^^xsd:stringera:rinfIndex : 1.1.1.1.8.6^^xsd:stringera:rinfIndex : 1.2.2.0.5.4^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>rdfs:seeAlso : [22] Recommendation 2014/881/EU^^xsd:string</para>
    ///   <para>era:XMLName : ITU_EIDemonstration^^xsd:string</para>
    ///   <para>skos:scopeNote : (SRT) in title means that here we include only declarations concerning requirements of SRT TSI for infrastructure system on the specific track.
    /// Parameter shall be repeated when different EI declarations were issued for different elements of infrastructure subsystem on the specific track in the tunnel.
    /// It may happen that several EI declarations were issued   then parameter has to be repeated as many times as many declarations were issued.
    /// The procedure for demonstration that existing network fits to requirements of the TSIs is executed on voluntary bases, so when EI declaration do not exist then the parameter is optional. </para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:dependencyNote :  Applicable in case when the demonstration was executed and EI declaration was issued.
    ///
    /// The procedure for demonstration that existing network fits to requirements of the TSIs is executed on voluntary bases, so when EI declaration do not exist then the parameter is optional.</para>
    ///   <para>rdfs:label : EI declaration of demonstration (as defined in Recommendation 2014/881/EU) relating to compliance with the requirements from TSIs applicable to railway tunnel</para>
    ///   <para>rdfs:comment : Unique number for EI declarations following the same format requirements as specified for EC declarations in Annex VII of Commission Implementing Regulation (EU) 2019/250.</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-06-26^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:formatNote : CC/RRRRRRRRRRRRRR/YYYY/NNNNNN^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/demonstrationSRT">era:demonstrationSRT</a>
    /// </summary>
    let demonstrationSRT = _prefixId.prefix "demonstrationSRT"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dependency note</para>
    ///   <para>rdfs:comment : This property is used to specify dependencies in natural language not covered by skos:scopeNote</para>
    ///   <para>dcterms:created : 2024-12-02^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/dependencyNote">era:dependencyNote</a>
    /// </summary>
    let dependencyNote = _prefixId.prefix "dependencyNote"
    /// <summary>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:datedcterms:modified : 2024-06-26^^xsd:date</para>
    ///   <para>rdfs:comment : Design mass under exceptional payload.</para>
    ///   <para>era:eratvIndex : 4.5.2.3^^xsd:string</para>
    ///   <para>rdfs:label : Design mass under exceptional payload</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/designMassExceptionalPayload">era:designMassExceptionalPayload</a>
    /// </summary>
    let designMassExceptionalPayload = _prefixId.prefix "designMassExceptionalPayload"
    /// <summary>
    ///   <para>rdfs:comment : Design mass under normal payload.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-06-26^^xsd:datedcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>rdfs:label : Design mass under normal payload</para>
    ///   <para>era:eratvIndex : 4.5.2.2^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/designMassNormalPayload">era:designMassNormalPayload</a>
    /// </summary>
    let designMassNormalPayload = _prefixId.prefix "designMassNormalPayload"
    /// <summary>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:datedcterms:modified : 2024-06-26^^xsd:date</para>
    ///   <para>rdfs:label : Design mass in working order</para>
    ///   <para>rdfs:comment : Design mass in working order.</para>
    ///   <para>era:eratvIndex : 4.5.2.1^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/designMassWorkingOrder">era:designMassWorkingOrder</a>
    /// </summary>
    let designMassWorkingOrder = _prefixId.prefix "designMassWorkingOrder"
    /// <summary>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>rdfs:label : Diesel or other thermal traction allowed</para>
    ///   <para>era:rinfIndex : 1.2.1.0.5.9^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>rdfs:comment : Indication whether it is allowed to use diesel or other thermal traction in the tunnel</para>
    ///   <para>dcterms:modified : 2021-08-09^^xsd:date</para>
    ///   <para>era:XMLName : ITU_DieselThermAllowed^^xsd:string</para>
    ///   <para>era:legalDeadline : 1 January 2021</para>
    ///   <a href="http://data.europa.eu/949/dieselThermalAllowed">era:dieselThermalAllowed</a>
    /// </summary>
    let dieselThermalAllowed = _prefixId.prefix "dieselThermalAllowed"
    /// <summary>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.1^^xsd:string</para>
    ///   <para>rdfs:label : Digital schematic overview</para>
    ///   <para>rdfs:comment : Diagrammatic representation of the operational point in Well Known Text polyline</para>
    ///   <para>era:rinfIndex : 1.2.0.0.0.7.2^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/digitalSchematicOverview">era:digitalSchematicOverview</a>
    /// </summary>
    let digitalSchematicOverview = _prefixId.prefix "digitalSchematicOverview"
    /// <summary>
    ///   <para>dcterms:modified : 2026-01-22^^xsd:date</para>
    ///   <para>dcterms:created : 2024-04-23^^xsd:date</para>
    ///   <para>rdfs:label : direction</para>
    ///   <para>rdfs:comment : The direction of the orientation of a railway element, in relation to the carrier linear element</para>
    ///   <a href="http://data.europa.eu/949/direction">era:direction</a>
    /// </summary>
    let direction = _prefixId.prefix "direction"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:formatNote : NNN^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>skos:scopeNote : Specific for route compatibility check on French network.</para>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.4.3^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>rdfs:label : Distance between signboard and phase separation ending</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : EOS_DistSignToPhaseEnd^^xsd:string</para>
    ///   <para>rdfs:comment : Distance between the signboard authorizing the driver to  raise pantograph  or  close the circuit breaker  after passing the phase separation and the end of the phase separation section.</para>
    ///   <para>era:dependencyNote : It is applicable ( Y ) only if the value  Overhead contact line (OCL)  is selected for parameter "Type of contact line system"</para>
    ///   <a href="http://data.europa.eu/949/distSignToPhaseEnd">era:distSignToPhaseEnd</a>
    /// </summary>
    let distSignToPhaseEnd = _prefixId.prefix "distSignToPhaseEnd"

    /// <summary>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:label : Document with restriction related to the position of Multiple Traction unit(s) to comply with contact line separation</para>
    ///   <para>era:XMLName : ERS_RestrictionMTDoc^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.2.5.5^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-11-04^^xsd:date</para>
    ///   <para>skos:scopeNote : The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:comment : Name and/or reference of the document specifying the restriction(s) related to the position of Multiple Traction unit(s) to comply with contact line separation.</para>
    ///   <a href="http://data.europa.eu/949/documentRestrictionPositionContactLineSeparation">era:documentRestrictionPositionContactLineSeparation</a>
    /// </summary>
    let documentRestrictionPositionContactLineSeparation = _prefixId.prefix "documentRestrictionPositionContactLineSeparation"

    /// <summary>
    ///   <para>dcterms:modified : 2024-11-04^^xsd:date</para>
    ///   <para>skos:scopeNote : The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <para>rdfs:comment : Name and/or reference of the document specifying the restriction(s) related to power consumption of specific electric traction unit(s).</para>
    ///   <para>era:XMLName : ERS_RestrictionPowerConsDoc^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.2.5.4^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:label : Document with restriction related to power consumption of specific electric traction unit(s)</para>
    ///   <a href="http://data.europa.eu/949/documentRestrictionPowerConsumption">era:documentRestrictionPowerConsumption</a>
    /// </summary>
    let documentRestrictionPowerConsumption = _prefixId.prefix "documentRestrictionPowerConsumption"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Document URL</para>
    ///   <para>rdfs:comment : URL that is used to download a document, e.g. url for a reference document in RINF.</para>
    ///   <para>dcterms:created : 2024-04-23^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/documentUrl">era:documentUrl</a>
    /// </summary>
    let documentUrl = _prefixId.prefix "documentUrl"
    /// <summary>
    ///   <para>rdfs:comment : Number of driving cabs. For wagons the number of driving cabs is to be set to zero (0).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Driving cabs</para>
    ///   <para>dcterms:created : 2021-08-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-08-24^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.1.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/drivingCabs">era:drivingCabs</a>
    /// </summary>
    let drivingCabs = _prefixId.prefix "drivingCabs"
    /// <summary>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.7.4.1.2^^xsd:string</para>
    ///   <para>rdfs:label : Eddy current brake prevention</para>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Possibility of preventing the use of the eddy current track brake (only if fitted with eddy current brake)</para>
    ///   <a href="http://data.europa.eu/949/eddyCurrentBrakePrevention">era:eddyCurrentBrakePrevention</a>
    /// </summary>
    let eddyCurrentBrakePrevention = _prefixId.prefix "eddyCurrentBrakePrevention"
    /// <summary>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:modified : 2022-09-06^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:label : Use of eddy current brakes</para>
    ///   <para>era:rinfIndex : 1.1.1.1.6.2^^xsd:stringera:rinfIndex : 1.2.1.0.4.2^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>skos:scopeNote : The use of both brakes is allowed or not under exterior conditions (depending on the features of the train engines for example).
    /// The RINF can't be filled without more precisions.</para>
    ///   <para>era:XMLName : ILR_EddyCurrentBrakes^^xsd:string</para>
    ///   <para>rdfs:seeAlso : INF TSI: 4.2.6.2.2 (2)
    /// OPE TSI: 4.2.2.6.2 (1) (iv)^^xsd:string</para>
    ///   <para>skos:editorialNote : This property has been modified to be a RINF parameter (its eratvIndex is deleted). It is treated as a SKOS by RINF and as a boolean by ERATV. A new ERATV datatype property has been defined, eddyCurrentBrakingFitted with boolean values.</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of limitations on the use of eddy current brakes.</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.5^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/eddyCurrentBraking">era:eddyCurrentBraking</a>
    /// </summary>
    let eddyCurrentBraking = _prefixId.prefix "eddyCurrentBraking"

    /// <summary>
    ///   <para>dcterms:modified : 2021-09-10^^xsd:datedcterms:modified : 2024-04-23^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:dependencyNote : Mandatory value to be provided when 1.1.1.1.6.2/Use of eddy current brakes is  allowed under conditions  or  allowed under conditions only for emergency brake</para>
    ///   <para>era:XMLName : ILR_ECBDocRef^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Electronic document available in two EU languages from the IM stored by the Agency with conditions for the use of eddy current brakes identified in 1.1.1.1.6.2.</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>skos:changeNote : Change from datatype property to object property in order to point to the class Document (reference document)</para>
    ///   <para>era:rinfIndex : 1.1.1.1.6.4^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.5^^xsd:string</para>
    ///   <para>skos:scopeNote : If there exist conditions to allow the use of eddy current brakes.
    ///
    /// The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <para>rdfs:label : Document with the conditions for the use of eddy current brakes</para>
    ///   <a href="http://data.europa.eu/949/eddyCurrentBrakingConditionsDocument">era:eddyCurrentBrakingConditionsDocument</a>
    /// </summary>
    let eddyCurrentBrakingConditionsDocument = _prefixId.prefix "eddyCurrentBrakingConditionsDocument"

    /// <summary>
    ///   <para>rdfs:comment : Eddy current track brake fitted. New property defined to distinguish it from eddyCurrentBraking which is a RINF SKOS property.</para>
    ///   <para>era:eratvIndex : 4.7.4.1.1^^xsd:string</para>
    ///   <para>rdfs:label : Eddy current braking fitted</para>
    ///   <para>dcterms:created : 2022-09-06^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/eddyCurrentBrakingFitted">era:eddyCurrentBrakingFitted</a>
    /// </summary>
    let eddyCurrentBrakingFitted = _prefixId.prefix "eddyCurrentBrakingFitted"
    /// <summary>
    ///   <para>era:rinfIndex : 1.2.4.1^^xsd:stringera:rinfIndex : 1.1.1.0.1.2^^xsd:string</para>
    ///   <para>dcterms:created : 2021-04-01^^xsd:date</para>
    ///   <para>dcterms:modified : 2024-11-29^^xsd:datedcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : References the first topological element in an oriented relation.
    /// For example, it may indicate the object that corresponds to a section of line, an operational point or a track inside an operational point connected at start.</para>
    ///   <para>rdfs:label : Element A</para>
    ///   <para>skos:altLabel : Internal connection</para>
    ///   <a href="http://data.europa.eu/949/elementA">era:elementA</a>
    /// </summary>
    let elementA = _prefixId.prefix "elementA"
    /// <summary>
    ///   <para>dcterms:created : 2021-04-01^^xsd:date</para>
    ///   <para>dcterms:modified : 2024-11-29^^xsd:datedcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>skos:altLabel : Internal connection</para>
    ///   <para>rdfs:comment : References the second topological linear element in an oriented relation.
    /// For example, it may indicate the object that corresponds to a section of line, an operational point or a track inside an operational point connected at end.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.4.1^^xsd:stringera:rinfIndex : 1.1.1.0.1.2^^xsd:string</para>
    ///   <para>rdfs:label : Element B</para>
    ///   <a href="http://data.europa.eu/949/elementB">era:elementB</a>
    /// </summary>
    let elementB = _prefixId.prefix "elementB"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Element part</para>
    ///   <para>rdfs:comment : References the topology object of a higher-granularity level which contains a lower-granularity topology object.</para>
    ///   <para>dcterms:modified : 2021-04-01^^xsd:date</para>
    ///   <para>dcterms:created : 2021-04-01^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/elementPart">era:elementPart</a>
    /// </summary>
    let elementPart = _prefixId.prefix "elementPart"
    /// <summary>
    ///   <para>rdfs:comment : Stopping distance and deceleration profile for each load condition per design maximum speed.</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <para>rdfs:label : Emergency braking</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.7.5^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/emergencyBrake">era:emergencyBrake</a>
    /// </summary>
    let emergencyBrake = _prefixId.prefix "emergencyBrake"
    /// <summary>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Type of end coupling (indicating tensile and compressive forces).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.9.1^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:label : End coupling type</para>
    ///   <a href="http://data.europa.eu/949/endCouplingType">era:endCouplingType</a>
    /// </summary>
    let endCouplingType = _prefixId.prefix "endCouplingType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : End intrinsic coordinate</para>
    ///   <para>dcterms:modified : 2021-04-01^^xsd:date</para>
    ///   <para>dcterms:created : 2021-04-01^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/endIntrinsicCoordinate">era:endIntrinsicCoordinate</a>
    /// </summary>
    let endIntrinsicCoordinate = _prefixId.prefix "endIntrinsicCoordinate"
    /// <summary>
    ///   <para>skos:example : Latitude=`51.5479123` Longitude=`-0.076732`^^xsd:string</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:XMLName : SOLTunnelEnd^^xsd:string</para>
    ///   <para>rdfs:comment : Geographical coordinates in decimal degrees and km of the line at the end of a tunnel.</para>
    ///   <para>skos:scopeNote : Geographical coordinates according to the standard World Geodetic System (WGS).  Precision for both geographical latitude and geographical longitude is assumed as [NN.NNNNNNN] in degrees with decimals what gives discretion of 10 cm in the network.
    /// Kilometre shall concern the national line identification given in 1.1.0.0.0.2
    /// Location of the point which is assumed to be the end of the tunnel it is the point on the track centre line where is laid the vertical shadow of the extreme part of the tunnel s portal.</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-02-05^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.8.4^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>rdfs:label : End of tunnel</para>
    ///   <a href="http://data.europa.eu/949/endLocation">era:endLocation</a>
    /// </summary>
    let endLocation = _prefixId.prefix "endLocation"
    /// <summary>
    ///   <para>dcterms:modified : 2025-01-30^^xsd:date</para>
    ///   <para>rdfs:comment : End offset of the section from the origin.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <para>rdfs:label : end offset from the origin</para>
    ///   <a href="http://data.europa.eu/949/endOffsetFromOrigin">era:endOffsetFromOrigin</a>
    /// </summary>
    let endOffsetFromOrigin = _prefixId.prefix "endOffsetFromOrigin"
    /// <summary>
    ///   <para>rdfs:label : ends at</para>
    ///   <para>rdfs:comment : Specifies the ending point of a linear reference.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/endsAt">era:endsAt</a>
    /// </summary>
    let endsAt = _prefixId.prefix "endsAt"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.10.12^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : TSI conform energy meter for billing purposes installed on board.</para>
    ///   <para>rdfs:label : Energy meter installed</para>
    ///   <a href="http://data.europa.eu/949/energyMeterInstalled">era:energyMeterInstalled</a>
    /// </summary>
    let energyMeterInstalled = _prefixId.prefix "energyMeterInstalled"
    /// <summary>
    ///   <para>rdfs:label : Energy subsystem</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/energySubsystemDataParameter">era:energySubsystemDataParameter</a>
    /// </summary>
    let energySubsystemDataParameter = _prefixId.prefix "energySubsystemDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Declarations of verification for track</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/energySubsystemDeclarationsVerificationTrackDataParameter">era:energySubsystemDeclarationsVerificationTrackDataParameter</a>
    /// </summary>
    let energySubsystemDeclarationsVerificationTrackDataParameter = _prefixId.prefix "energySubsystemDeclarationsVerificationTrackDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Energy subsystem</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/energySubsystemObjParameter">era:energySubsystemObjParameter</a>
    /// </summary>
    let energySubsystemObjParameter = _prefixId.prefix "energySubsystemObjParameter"
    /// <summary>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:label : Energy supply max power</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.10.2^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Maximum power (to be indicated for each energy supply system the vehicle is equipped for), given in kW.</para>
    ///   <a href="http://data.europa.eu/949/energySupplyMaxPower">era:energySupplyMaxPower</a>
    /// </summary>
    let energySupplyMaxPower = _prefixId.prefix "energySupplyMaxPower"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>skos:scopeNote : If the real values exceed range of the EN 50163:2004+A1:2007+A2:2020+A3:2022, they could be introduced by the Agency on request via a process of change request.
    /// See: ENE TSI: 4.2.3 and EN 50163:2004: clause 4
    ///
    /// For RINF XML data sets:
    /// As long as the data provision through XML data sets is allowed, an XML attribute called “Set” will be used to link the value of this parameter to the parameter 1.1.1.2.2.1.1 / ECS_SystemType</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Energy supply system (Voltage and frequency)</para>
    ///   <para>era:XMLName : ECS_VoltFreq^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of the traction supply system (nominal voltage and frequency).</para>
    ///   <para>era:rinfIndex : 1.1.1.2.2.1.2^^xsd:string</para>
    ///   <para>rdfs:seeAlso : EN 50163:2004+A1:2007+A2:2020+A3:2022: clause 4
    /// ENE TSI:4.2.3^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.3.1^^xsd:string</para>
    ///   <para>era:dependencyNote : When `not electrified` is chosen in parameter 1.1.1.2.2.1.1, then this parameter is not applicable.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:eratvIndex : 4.10.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/energySupplySystem">era:energySupplySystem</a>
    /// </summary>
    let energySupplySystem = _prefixId.prefix "energySupplySystem"

    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.2.2.1.2.1^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2021-08-06^^xsd:date</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication if the traction supply system (nominal voltage and frequency) is fully compliant with TSI.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Energy supply system TSI compliant</para>
    ///   <para>era:XMLName : ECS_TSIVoltFreq^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/energySupplySystemTSICompliant">era:energySupplySystemTSICompliant</a>
    /// </summary>
    let energySupplySystemTSICompliant = _prefixId.prefix "energySupplySystemTSICompliant"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ERATV index</para>
    ///   <para>rdfs:comment : Index code used in the original definition of a parameter in ERATV.</para>
    ///   <para>dcterms:modified : 2024-08-13^^xsd:datedcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>dcterms:created : 2020-11-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/eratvIndex">era:eratvIndex</a>
    /// </summary>
    let eratvIndex = _prefixId.prefix "eratvIndex"
    /// <summary>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>rdfs:comment : List of unacceptable errors impacting the IM network that are required to be solved in the on-board according to the TSI CCS point 7.2.10.3 specification maintenance point (ETCS, GSM-R and/or ATO). An additional parameter (era:errorCorrectionsOnboardExplanation) must document if a non-implemented CR has been accepted by the IM.</para>
    ///   <para>skos:scopeNote : This parameter should be limited to those required for the onboard, in order to allow normal service as defined in Art. 10 CR. The values will come from a list.
    /// IM's may choose to make available the optional ETCS error corrections as well, but this should be done using other means than the RINF register.
    /// This parameter should also be understood as ETCS, ATO and GSM-R related error corrections required for the on-board. pending a formal update and approval of the relevant legislative annex.
    /// For the specific track the error corrections to be applied is one list only.</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>era:legalDeadline : 12 months after the entry into force of TSI CCS and at least 12 months after publication of Article 7 Guide</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Error corrections required for the on-board ETCS, GSM-R and/or ATO function</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.19^^xsd:stringera:rinfIndex : 1.1.1.3.1.2^^xsd:string</para>
    ///   <para>dcterms:created : 2024-04-18^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/errorCorrectionsOnboard">era:errorCorrectionsOnboard</a>
    /// </summary>
    let errorCorrectionsOnboard = _prefixId.prefix "errorCorrectionsOnboard"

    /// <summary>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>rdfs:comment : Explanation on why a mandatory onboard CR required to be solved in the on-board (ETCS, GSM-R and/or ATO) was accepted by the IM.</para>
    ///   <para>dcterms:created : 2024-04-18^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after the entry into force of TSI CCS and at least 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:label : Reasons for Error corrections required, but accepted by the IM for the on-board ETCS, GSM-R and/or ATO function</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.1.2^^xsd:stringera:rinfIndex : 1.2.1.1.1.19^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/errorCorrectionsOnboardExplanation">era:errorCorrectionsOnboardExplanation</a>
    /// </summary>
    let errorCorrectionsOnboardExplanation = _prefixId.prefix "errorCorrectionsOnboardExplanation"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : (Deprecated) ERTMS error corrections required for the on-board.</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>dcterms:created : 2024-01-08^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/ertmsErrorCorrectionsOnBoard">era:ertmsErrorCorrectionsOnBoard</a>
    /// </summary>
    let ertmsErrorCorrectionsOnBoard = _prefixId.prefix "ertmsErrorCorrectionsOnBoard"
    /// <summary>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-08-13^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-07^^xsd:date</para>
    ///   <para>skos:scopeNote : It can be repeated as many times as the number of different ETCS levels are present.
    ///
    /// For RDF data provision:
    /// The value of this property is an instance of the era:ETCS, which has as properties the parameters 1.1.1.3.2.1 and 1.1.1.3.2.2.
    ///
    /// For RINF XML data sets:
    /// As long as the data provision through XML data sets is allowed, this property is the equivalent of the "Set" attribute, grouping parameters 1.1.1.3.2.1 and 1.1.1.3.2.2.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : TSI compliant train protection system (ETCS)</para>
    ///   <para>rdfs:comment : European Train Control System (ETCS) application level supported by the track side equipment.</para>
    ///   <a href="http://data.europa.eu/949/etcs">era:etcs</a>
    /// </summary>
    let etcs = _prefixId.prefix "etcs"
    /// <summary>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.2^^xsd:stringera:rinfIndex : 1.2.1.1.1.2^^xsd:string</para>
    ///   <para>rdfs:label : ETCS baseline</para>
    ///   <para>dcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2021-08-31^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : ETCS baseline installed lineside.</para>
    ///   <para>skos:scopeNote : The ETCS baseline needs to be provided for each available ETCS Level. See: TSI CCS (Table A2)</para>
    ///   <para>era:XMLName : CPE_Baseline^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.7^^xsd:string</para>
    ///   <para>rdfs:seeAlso : TSI CCS (Table A2)^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-07^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.13.1.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/etcsBaseline">era:etcsBaseline</a>
    /// </summary>
    let etcsBaseline = _prefixId.prefix "etcsBaseline"
    /// <summary>
    ///   <para>rdfs:comment : Data communication application for ETCS implementation.</para>
    ///   <para>era:eratvIndex : 4.13.2.9^^xsd:string</para>
    ///   <para>rdfs:label : ETCS data communication application</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/etcsDataCommApp">era:etcsDataCommApp</a>
    /// </summary>
    let etcsDataCommApp = _prefixId.prefix "etcsDataCommApp"
    /// <summary>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>skos:example : Level 1 as a degraded mode for Level 2.^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.9.1^^xsd:stringera:rinfIndex : 1.1.1.3.10.1^^xsd:string</para>
    ///   <para>era:dependencyNote : Mandatory when ETCS is present. </para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ETCS level for degraded situation</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>era:XMLName : CLD_ETCSSituation^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.1^^xsd:string</para>
    ///   <para>skos:scopeNote : System for degraded situation.
    ///
    /// In case of failure of the ETCS Level for normal operation, train movement can be supervised in another ETCS Level.
    ///
    /// If parameter 1.1.1.3.2.1 is not used (no ETCS), no degradation is possible, so only "none" level is possible for degraded .
    /// It assumed that the degraded level has to be lower than the actual operating level.
    /// See also TSI OPE 4.2.3.6. Degraded operation.</para>
    ///   <para>rdfs:comment : ERTMS / ETCS application level for degraded situation related to the track side equipment.</para>
    ///   <para>rdfs:seeAlso : https://eur-lex.europa.eu/eli/reg_impl/2019/773/oj^^xsd:anyURI</para>
    ///   <a href="http://data.europa.eu/949/etcsDegradedSituation">era:etcsDegradedSituation</a>
    /// </summary>
    let etcsDegradedSituation = _prefixId.prefix "etcsDegradedSituation"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : ETCS equipment on-board and its level.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:label : ETCS equipment level</para>
    ///   <para>era:eratvIndex : 4.13.1.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/etcsEquipmentOnBoardLevel">era:etcsEquipmentOnBoardLevel</a>
    /// </summary>
    let etcsEquipmentOnBoardLevel = _prefixId.prefix "etcsEquipmentOnBoardLevel"
    /// <summary>
    ///   <para>rdfs:label : (Deprecated) ETCS error corrections required for the on-board.</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/etcsErrorCorrectionsOnboard">era:etcsErrorCorrectionsOnboard</a>
    /// </summary>
    let etcsErrorCorrectionsOnboard = _prefixId.prefix "etcsErrorCorrectionsOnboard"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ETCS trackside implements level crossing procedure or an equivalent solution</para>
    ///   <para>rdfs:comment : If the trackside does not implement any solution to cover non-protected LXs (which are normally protected by means of a technical system), then drivers will be required to comply with instructions received from other sources</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>skos:scopeNote : See: TSI CCS (Subset-026, Chapter 5, section 5.16)</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.2^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.13^^xsd:stringera:rinfIndex : 1.1.1.3.2.13^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:dependencyNote : Applicable and mandatory when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>dcterms:created : 2022-11-04^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/etcsImplementsLevelCrossingProcedure">era:etcsImplementsLevelCrossingProcedure</a>
    /// </summary>
    let etcsImplementsLevelCrossingProcedure = _prefixId.prefix "etcsImplementsLevelCrossingProcedure"

    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.3.2.4^^xsd:stringera:rinfIndex : 1.2.1.1.1.4^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-03-04^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latestera:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.13.1.3^^xsd:string</para>
    ///   <para>rdfs:label : ETCS infill installed line-side</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:XMLName : CPE_InfillLineSide^^xsd:string</para>
    ///   <para>skos:scopeNote : TSI CCS (4.2.2 &amp; 4.3.3)</para>
    ///   <para>era:dependencyNote : Mandatory in case of ETCS level 1 and infill device(s) are installed. Otherwise it is not applicable.</para>
    ///   <para>rdfs:comment : Information about installed trackside equipment capable to transmit infill information by loop or Global System for Mobile communications for Railways (GSM-R) for level 1 installations.</para>
    ///   <a href="http://data.europa.eu/949/etcsInfill">era:etcsInfill</a>
    /// </summary>
    let etcsInfill = _prefixId.prefix "etcsInfill"
    /// <summary>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latestera:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>rdfs:label : ETCS infill necessary for line access</para>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2025-03-04^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>rdfs:comment : Indication whether infill is required to access the line for safety reasons.</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.3^^xsd:stringera:rinfIndex : 1.1.1.3.2.3^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : CPE_Infill^^xsd:string</para>
    ///   <para>skos:scopeNote : As indicated in CCS TSI section 7.2.9.1, an ETCS Level 1 trackside application may require that the on-board is equipped with the corresponding in-fill data transmission (Euroloop or radio) if the release speed is set to zero for safety reasons.
    ///
    /// See: TSI CCS 7.2.9.1 &amp; 4.2.3 </para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1) and the ETCS level is 1.</para>
    ///   <a href="http://data.europa.eu/949/etcsInfillLineAccess">era:etcsInfillLineAccess</a>
    /// </summary>
    let etcsInfillLineAccess = _prefixId.prefix "etcsInfillLineAccess"
    /// <summary>
    ///   <para>era:XMLName : CPE_Level^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-07^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-01-23^^xsd:datedcterms:modified : 2024-08-13^^xsd:date</para>
    ///   <para>rdfs:seeAlso : TSI CCS (Subset-026, Chapter 2, 2.6)^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.1^^xsd:stringera:rinfIndex : 1.1.1.3.2.1^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.7^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : European Train Control System (ETCS) level</para>
    ///   <para>rdfs:comment : ETCS application level related to the track side equipment.</para>
    ///   <para>skos:scopeNote : The different ERTMS / ETCS application levels are a way to express the possible operating relationships between track and train.
    ///
    /// Level definitions are principally related to the track side equipment used, to the way the track side information reaches the on-board units and to which functions are processed in the track side and in the on-board equipment respectively.
    ///
    /// If ETCS is on the trackside (one or more levels are selected), all other ETCS parameters (from 1.1.1.3.2.2 to 1.1.1.3.2.10) are applicable and mandatory to be populated with values .
    /// If the line is only equipped with Class B, this should be reflected in Parameter 1.1.1.3.5.3, and this parameter is “N”(not applicable).
    ///
    /// The ETCS value NTC is only relevant when the line is dual equipped with ETCS (i.e., balises are placed in the track) and Class B system, and both systems are in operation at the same time.
    /// In those cases, this parameter should be filled relevant ETCS Level and repeated with the value NTC.
    ///
    /// If the line is only equipped with Class B, this should be reflected in Parameter 1.1.1.3.5.3, and this parameter etcsLevelType should not be used.
    ///
    /// If operation in the line is authorised for ETCS and non ETCS vehicles using class B system, Parameter 1.1.1.3.5.3 shall also be used in combination with 1.1.1.3.2.1.
    /// See: TSI CCS (Subset-026, Chapter 2, 2.6)</para>
    ///   <a href="http://data.europa.eu/949/etcsLevelType">era:etcsLevelType</a>
    /// </summary>
    let etcsLevelType = _prefixId.prefix "etcsLevelType"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>rdfs:label : ETCS M_version</para>
    ///   <para>rdfs:comment : ETCS M_version according to the specification referenced in Appendix A-1, index [C], SRS 7.5.1.9.</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.10^^xsd:stringera:rinfIndex : 1.1.1.3.2.10^^xsd:string</para>
    ///   <para>era:legalDeadline : 1 January 2021era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-03-04^^xsd:date</para>
    ///   <para>era:XMLName : CPE_MVersion^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>skos:scopeNote : See: TSI CCS (Subset-026, Chapter 7, 7.5.1.79 M_VERSION)</para>
    ///   <a href="http://data.europa.eu/949/etcsMVersion">era:etcsMVersion</a>
    /// </summary>
    let etcsMVersion = _prefixId.prefix "etcsMVersion"
    /// <summary>
    ///   <para>rdfs:label : ETCS national applications</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : ETCS national applications implemented (NID_XUSER of Packet 44).</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.13.1.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/etcsNationalApplications">era:etcsNationalApplications</a>
    /// </summary>
    let etcsNationalApplications = _prefixId.prefix "etcsNationalApplications"
    /// <summary>
    ///   <para>era:rinfIndex : 1.2.1.1.1.5^^xsd:stringera:rinfIndex : 1.1.1.3.2.5^^xsd:string</para>
    ///   <para>rdfs:comment : Indication whether data for national applications is transmitted between track and train.</para>
    ///   <para>dcterms:modified : 2025-05-05^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : ETCS national packet 44 application implemented</para>
    ///   <a href="http://data.europa.eu/949/etcsNationalPacket44">era:etcsNationalPacket44</a>
    /// </summary>
    let etcsNationalPacket44 = _prefixId.prefix "etcsNationalPacket44"
    /// <summary>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>skos:scopeNote : Value can be `false` or a link to the implemented functions.
    ///
    /// Packets 44 are the means to transmit data for national applications between train and track and vice versa, using the data transmission facilities included within the ETCS.
    /// NID_XUSER values managed by ERA in a document about ETCS variables available on ERA website.
    ///
    /// See: TSI CCS (7.4.3 &amp; 6.2.4.2)</para>
    ///   <para>rdfs:comment : Indication whether data for national applications is transmitted between track and train.</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2024-11-20^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-05-05^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>rdfs:label : ETCS national packet 44 application implemented</para>
    ///   <a href="http://data.europa.eu/949/etcsNationalPacket44Function">era:etcsNationalPacket44Function</a>
    /// </summary>
    let etcsNationalPacket44Function = _prefixId.prefix "etcsNationalPacket44Function"

    /// <summary>
    ///   <para>rdfs:label : ETCS National Values</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.16^^xsd:stringera:rinfIndex : 1.1.1.3.2.16^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/etcsNationalValuesDataParameter">era:etcsNationalValuesDataParameter</a>
    /// </summary>
    let etcsNationalValuesDataParameter = _prefixId.prefix "etcsNationalValuesDataParameter"

    /// <summary>
    ///   <para>rdfs:label : ETCS National Values</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.16^^xsd:stringera:rinfIndex : 1.1.1.3.2.16^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/etcsNationalValuesObjParameter">era:etcsNationalValuesObjParameter</a>
    /// </summary>
    let etcsNationalValuesObjParameter = _prefixId.prefix "etcsNationalValuesObjParameter"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : ETCS on-board implementation.</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:label : ETCS on-board implementation</para>
    ///   <para>era:eratvIndex : 4.13.1.7^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/etcsOnBoardImplementation">era:etcsOnBoardImplementation</a>
    /// </summary>
    let etcsOnBoardImplementation = _prefixId.prefix "etcsOnBoardImplementation"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.7^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. Optional ETCS functions which might improve operation on the line.</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>rdfs:label : ETCS optional functions</para>
    ///   <a href="http://data.europa.eu/949/etcsOptionalFunctions">era:etcsOptionalFunctions</a>
    /// </summary>
    let etcsOptionalFunctions = _prefixId.prefix "etcsOptionalFunctions"
    /// <summary>
    ///   <para>dcterms:modified : 2025-05-05^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2022-11/restrictions_and_added_functions_en_1.doc^^xsd:anyURIrdfs:seeAlso : https://www.era.europa.eu/content/certification-issues^^xsd:anyURI</para>
    ///   <para>rdfs:label : document with operating restrictions or conditions</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>skos:scopeNote : If not `false` (property hasEtcsRestrictionsConditions), a link to the conditions must be provided. The RU has to contact the IM to be informed about these conditions.
    /// These conditions and restrictions of use are considered in section 6.4 of the CCS TSI. They should be described using the template available on Agency website (Certification and deviations - Guidelines for using the ERA template) with the following link.
    ///
    /// The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <para>rdfs:comment : Indication of the document where restrictions or conditions due to partial compliance with the TSI CCS are described.</para>
    ///   <a href="http://data.europa.eu/949/etcsRestrictionsConditionsDoc">era:etcsRestrictionsConditionsDoc</a>
    /// </summary>
    let etcsRestrictionsConditionsDoc = _prefixId.prefix "etcsRestrictionsConditionsDoc"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:XMLName : CPE_SystemCompatibility^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURIrdfs:seeAlso : https://www.era.europa.eu/system/files/2023-05/esc-rsc_technical_document_en.pdf^^xsd:anyURI</para>
    ///   <para>rdfs:label : ETCS system compatibility</para>
    ///   <para>era:eratvIndex : 4.13.1.8^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.9^^xsd:stringera:rinfIndex : 1.2.1.1.1.9^^xsd:string</para>
    ///   <para>rdfs:comment : ETCS requirements used for demonstrating technical compatibility.</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : 16 January 2020</para>
    ///   <para>skos:scopeNote : The Values "Not defined" or "ESC-EU-0" should not be combined with other values.
    ///
    /// For application in CCS Onboard:
    /// The vehicles are considered compatible with the infrastructure for this parameter, if their parameter value matches any of the values declared on the trackside.
    ///
    /// For application in CCS Trackside:
    /// The Infrastructure Manager is responsible for defining the ESC type(s). All sections of the Union network which require the same set of checks for the demonstration of ESC shall have the same ESC type.
    ///
    /// See: TSI CCS, Appendix A, Table A 1, 4.2.17 a.
    /// The list of ESC Types is published and maintained by the European Union Agency for Railways in the technical document "ESC/RSC technical document, TD/011REC1028".
    /// The Agency shall assess the checks unless they have been assessed by a NoBo as required in Table 6.3 row 10.
    /// The assessment by the Agency shall be done within 2 months of receipt thereof, unless a longer period is agreed between the Agency and the Infrastructure Manager but not exceeding 4 months in total.
    /// The technical document will be updated within 10 working days after positive assessment.
    ///
    /// The ESC Types shall only be used when published with status "Valid" in the Agency Technical document referred above.</para>
    ///   <para>dcterms:created : 2020-08-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/etcsSystemCompatibility">era:etcsSystemCompatibility</a>
    /// </summary>
    let etcsSystemCompatibility = _prefixId.prefix "etcsSystemCompatibility"

    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:applicable : N^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.20^^xsd:stringera:rinfIndex : 1.1.1.3.2.19^^xsd:string</para>
    ///   <para>rdfs:label : ETCS system version 2.2 or 3.0 functionalities to be required in the next 5 years</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>skos:scopeNote : Not needed for internal trackside params (no use at the moment).
    /// This parameter was intented for a former version of Appendix G, but the requirement is stil in CCS TSI 6.1.1.2. </para>
    ///   <para>rdfs:comment : (Deprecated) List of ETCS system version 2.2 or 3.0 functionalities to be required in the next 5 years according to TSI CCS point 6.1.1.2 and Appendix G</para>
    ///   <a href="http://data.europa.eu/949/etcsSystemFunctionalitiesNextFiveYears">era:etcsSystemFunctionalitiesNextFiveYears</a>
    /// </summary>
    let etcsSystemFunctionalitiesNextFiveYears = _prefixId.prefix "etcsSystemFunctionalitiesNextFiveYears"

    /// <summary>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>dcterms:created : 2022-11-04^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.12^^xsd:stringera:rinfIndex : 1.1.1.3.2.12^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.1^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : If the trackside does not provide Track Conditions, the driver will need to be informed about such conditions via alternative methods.
    /// According to the specification referenced in Appendix A-1, index [C]</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:label : Is the ETCS trackside engineered to transmit Track Conditions</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>skos:scopeNote : According to the specification referenced in Appendix A-1, index [C]
    /// If the trackside does not provide Track Conditions, the driver will need to be informed about such conditions via alternative methods.
    /// In ETCS level NTC and level 0 track conditions are not managed (at least in Baseline 2)
    /// See: TSI CCS (Subset-026, Chapter 5, section 5.18)</para>
    ///   <a href="http://data.europa.eu/949/etcsTransmitsTrackConditions">era:etcsTransmitsTrackConditions</a>
    /// </summary>
    let etcsTransmitsTrackConditions = _prefixId.prefix "etcsTransmitsTrackConditions"

    /// <summary>
    ///   <para>era:tsiOPEAppendixD3Index : 1.1^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Transmittable track conditions by the CCSSubsystem, according to the specification referenced in Appendix A-1, index [C]</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.12.1^^xsd:stringera:rinfIndex : 1.2.1.1.1.12.1^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2023-04-18^^xsd:datedcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>skos:scopeNote : See: TSI CCS (Subset-026, Chapter 5, section 5.18.1.1)</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:dependencyNote : Mandatory when ETCS is present (a value is provided on 1.1.1.3.2.1) and value of 1.1.1.3.2.12 is True.</para>
    ///   <para>rdfs:label : Track conditions which can be transmitted</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:created : 2022-11-16^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/etcsTransmittedTrackConditions">era:etcsTransmittedTrackConditions</a>
    /// </summary>
    let etcsTransmittedTrackConditions = _prefixId.prefix "etcsTransmittedTrackConditions"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2025-11-17^^xsd:date</para>
    ///   <para>rdfs:comment : Indication of which European Transport Corridor the element belongs to.</para>
    ///   <para>rdfs:label : European transport corridor</para>
    ///   <a href="http://data.europa.eu/949/europeanTransportCorridor">era:europeanTransportCorridor</a>
    /// </summary>
    let europeanTransportCorridor = _prefixId.prefix "europeanTransportCorridor"
    /// <summary>
    ///   <para>rdfs:label : exempt special vehicles from ATO</para>
    ///   <para>rdfs:comment : Indicates whether special vehicles are exempted from the need to install ATO (Automatic Train Operation) for this infrastructure element.</para>
    ///   <para>dcterms:created : 2025-10-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/exemptSpecialVehiclesFromATO">era:exemptSpecialVehiclesFromATO</a>
    /// </summary>
    let exemptSpecialVehiclesFromATO = _prefixId.prefix "exemptSpecialVehiclesFromATO"
    /// <summary>
    ///   <para>rdfs:label : exempt special vehicles from ETCS</para>
    ///   <para>rdfs:comment : Indicates whether special vehicles are exempted from the need to install ETCS (European Train Control System) for this infrastructure element.</para>
    ///   <para>dcterms:created : 2025-10-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/exemptSpecialVehiclesFromETCS">era:exemptSpecialVehiclesFromETCS</a>
    /// </summary>
    let exemptSpecialVehiclesFromETCS = _prefixId.prefix "exemptSpecialVehiclesFromETCS"
    /// <summary>
    ///   <para>rdfs:label : exempt special vehicles from RMR</para>
    ///   <para>rdfs:comment : Indicates whether special vehicles are exempted from the need to install RMR (Railway Mobile Radio) for this infrastructure element.</para>
    ///   <para>dcterms:created : 2025-10-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/exemptSpecialVehiclesFromRMR">era:exemptSpecialVehiclesFromRMR</a>
    /// </summary>
    let exemptSpecialVehiclesFromRMR = _prefixId.prefix "exemptSpecialVehiclesFromRMR"
    /// <summary>
    ///   <para>dcterms:created : 2025-09-30^^xsd:date</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicate, if there are any wind restrictions for a bridge.</para>
    ///   <para>rdfs:label : Existence of bridge wind restriction</para>
    ///   <a href="http://data.europa.eu/949/existBridgeWindRestriction">era:existBridgeWindRestriction</a>
    /// </summary>
    let existBridgeWindRestriction = _prefixId.prefix "existBridgeWindRestriction"
    /// <summary>
    ///   <para>rdfs:label : Existence of opening hours limitation</para>
    ///   <para>dcterms:created : 2025-09-30^^xsd:date</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicate, if there are any opening hours of the section of a line or Tunnel or Bridge.</para>
    ///   <a href="http://data.europa.eu/949/existOpeningHoursLimitation">era:existOpeningHoursLimitation</a>
    /// </summary>
    let existOpeningHoursLimitation = _prefixId.prefix "existOpeningHoursLimitation"
    /// <summary>
    ///   <para>rdfs:comment : Indicate, if there are any limits on transportation of dangerous goods.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:created : 2025-09-30^^xsd:date</para>
    ///   <para>rdfs:label : Existence of restricted dangerous goods</para>
    ///   <a href="http://data.europa.eu/949/existRestrictedDangerousGood">era:existRestrictedDangerousGood</a>
    /// </summary>
    let existRestrictedDangerousGood = _prefixId.prefix "existRestrictedDangerousGood"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Existence of restricted periods of time for dangerous goods transportation</para>
    ///   <para>rdfs:comment : Indicate, if there are any limits on specific time of a day for transport of dangerous goods.</para>
    ///   <para>dcterms:created : 2025-09-30^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/existRestrictedPeriodOfTimeDangerousGood">era:existRestrictedPeriodOfTimeDangerousGood</a>
    /// </summary>
    let existRestrictedPeriodOfTimeDangerousGood = _prefixId.prefix "existRestrictedPeriodOfTimeDangerousGood"

    /// <summary>
    ///   <para>dcterms:created : 2025-09-30^^xsd:date</para>
    ///   <para>rdfs:comment : Indicate, if there are any limits on specific type of vehicle in the tunnel.</para>
    ///   <para>rdfs:label : Existence of restricted type of vehicle in tunnel</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/existRestrictedTypeOfVehicleOfTunnel">era:existRestrictedTypeOfVehicleOfTunnel</a>
    /// </summary>
    let existRestrictedTypeOfVehicleOfTunnel = _prefixId.prefix "existRestrictedTypeOfVehicleOfTunnel"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Exclusion of simultaneity</para>
    ///   <para>rdfs:comment : Indicate, if passenger and freight trains meeting together in a tunnel is allowed</para>
    ///   <para>dcterms:created : 2025-09-30^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/existTrainExclusionOfSimultaneity">era:existTrainExclusionOfSimultaneity</a>
    /// </summary>
    let existTrainExclusionOfSimultaneity = _prefixId.prefix "existTrainExclusionOfSimultaneity"

    /// <summary>
    ///   <para>era:formatNote : Y/N^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.5^^xsd:string</para>
    ///   <para>skos:scopeNote : Although it is just an indication of existence of an industrial risk, the area covering the industrial risk should be references on the topological network.
    /// For the route book purpose, the industrial risks should be defined as linear references instead of area. SpecialArea of type "industrial risk" should be used</para>
    ///   <para>era:applicable : Y/NYA^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : RBS_IndRisks^^xsd:string</para>
    ///   <para>rdfs:comment : Indication that the full section of line (or a part of it) it is identified by the Infrastructure Managers (and communicated to the RU) where drivers are not supposed to get off the locomotive.</para>
    ///   <para>rdfs:label : Industrial risks — locations where it is dangerous for the driver to step out</para>
    ///   <para>era:rinfIndex : 1.1.0.0.1.1^^xsd:string</para>
    ///   <para>dcterms:created : 2025-01-30^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/existenceOfIndustrialRisk">era:existenceOfIndustrialRisk</a>
    /// </summary>
    let existenceOfIndustrialRisk = _prefixId.prefix "existenceOfIndustrialRisk"
    /// <summary>
    ///   <para>era:eratvIndex : 4.14.2.12^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-09-01^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-09-01^^xsd:date</para>
    ///   <para>rdfs:label : Ferromagnetic wheel material</para>
    ///   <para>rdfs:comment : Wheel material is ferromagnetic.</para>
    ///   <a href="http://data.europa.eu/949/ferromagneticWheelMaterial">era:ferromagneticWheelMaterial</a>
    /// </summary>
    let ferromagneticWheelMaterial = _prefixId.prefix "ferromagneticWheelMaterial"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-03^^xsd:date</para>
    ///   <para>dcterms:created : 2020-08-29^^xsd:date</para>
    ///   <para>rdfs:label : Fire safety category</para>
    ///   <para>era:eratvIndex : 4.4.1^^xsd:string</para>
    ///   <para>rdfs:comment : Fire safety category for tunnels.</para>
    ///   <a href="http://data.europa.eu/949/fireSafetyCategory">era:fireSafetyCategory</a>
    /// </summary>
    let fireSafetyCategory = _prefixId.prefix "fireSafetyCategory"
    /// <summary>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.12.1.1^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Fixed seats</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Number of fixed seats.</para>
    ///   <a href="http://data.europa.eu/949/fixedSeats">era:fixedSeats</a>
    /// </summary>
    let fixedSeats = _prefixId.prefix "fixedSeats"
    /// <summary>
    ///   <para>rdfs:comment : Indication whether the use of on-board device for flange lubrication is forbidden.</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:formatNote : in XML: Y/N^^xsd:string</para>
    ///   <para>rdfs:label : Use of flange lubrication forbidden</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : IHS_FlangeLubeForbidden^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2021-09-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.7.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/flangeLubeForbidden">era:flangeLubeForbidden</a>
    /// </summary>
    let flangeLubeForbidden = _prefixId.prefix "flangeLubeForbidden"
    /// <summary>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication whether rules for activation or deactivation of flange lubrication exist.</para>
    ///   <para>era:XMLName : CTD_FlangeLubeRules^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Existence of rules on on-board flange lubrication</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.20^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/flangeLubeRules">era:flangeLubeRules</a>
    /// </summary>
    let flangeLubeRules = _prefixId.prefix "flangeLubeRules"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates if the vehicle type is fitted for flange lubrication.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.9.3.1^^xsd:string</para>
    ///   <para>rdfs:label : Flange lubrication fitted</para>
    ///   <a href="http://data.europa.eu/949/flangeLubricationFitted">era:flangeLubricationFitted</a>
    /// </summary>
    let flangeLubricationFitted = _prefixId.prefix "flangeLubricationFitted"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : format note</para>
    ///   <para>rdfs:comment : This property is used to annotate in human readable the format of parameters</para>
    ///   <para>dcterms:created : 2024-12-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/formatNote">era:formatNote</a>
    /// </summary>
    let formatNote = _prefixId.prefix "formatNote"
    /// <summary>
    ///   <para>era:rinfIndex : 1.2.1.0.2.3^^xsd:stringera:rinfIndex : 1.1.1.1.2.3^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2025-11-17^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>skos:scopeNote : It is recommended to use the property era:europeanTransportCorridor with the respective SKOS concepts instead of this property. Not applicable if the line is not part of an RFC. If a line belongs to several corridors, repeat the parameter.</para>
    ///   <para>rdfs:comment : Indication whether the line is designated to a Railway Freight Corridor.</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>rdfs:seeAlso : [6] Reg 913/2010/EC^^xsd:string</para>
    ///   <para>rdfs:label : Part of a Railway Freight Corridor</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:XMLName : IPP_FreightCorridor^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/freightCorridor">era:freightCorridor</a>
    /// </summary>
    let freightCorridor = _prefixId.prefix "freightCorridor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Freight possible flag attached to a Primary Location.</para>
    ///   <para>dcterms:created : 2024-06-03^^xsd:date</para>
    ///   <para>rdfs:label : freight flag</para>
    ///   <a href="http://data.europa.eu/949/freightFlag">era:freightFlag</a>
    /// </summary>
    let freightFlag = _prefixId.prefix "freightFlag"

    /// <summary>
    ///   <para>rdfs:label : Section with train detection limitation, only for the French network</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:comment : Specific for route compatibility check on French network. The reason for deprecation is because of replacement by a class, an object property and two datatype properties. The reason is that the property is composed of two values: A boolean [Y/N] and  a number N is between 1 and 8.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2022-04-05^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/frenchTrainDetectionSystemLimitation">era:frenchTrainDetectionSystemLimitation</a>
    /// </summary>
    let frenchTrainDetectionSystemLimitation = _prefixId.prefix "frenchTrainDetectionSystemLimitation"

    /// <summary>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Section with train detection limitation</para>
    ///   <para>rdfs:comment : Part of the section with train detection limitation that indicates if it is applicable. Only for the French network.</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/frenchTrainDetectionSystemLimitationApplicable">era:frenchTrainDetectionSystemLimitationApplicable</a>
    /// </summary>
    let frenchTrainDetectionSystemLimitationApplicable = _prefixId.prefix "frenchTrainDetectionSystemLimitationApplicable"

    /// <summary>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:label : Section with train detection limitation number, only for French network</para>
    ///   <para>rdfs:comment : Part of the section with train detection limitation that indicates the type of train detection limitation.
    ///
    /// Specific for route compatibility check on French network.
    ///
    /// Sections with:
    /// [1] Tonnage circulated per track is inferior to 15000 tons/day/track
    /// [2] Directional Interlocking
    /// [3] 45-second delay for directional interlocking
    /// [4] Installation with track circuit announcement
    /// [5] Absence of a shunting assistance pedal in the normal direction of circulation for non-reversible double track lines
    /// [6] Absence of a shunting assistance pedal regardless of the direction of traffic for single track lines and tracks for two way working
    /// [7] Absence of a pedal announcement mechanism
    /// [8] 45-second delay for specific announcement reset devices</para>
    ///   <a href="http://data.europa.eu/949/frenchTrainDetectionSystemLimitationNumber">era:frenchTrainDetectionSystemLimitationNumber</a>
    /// </summary>
    let frenchTrainDetectionSystemLimitationNumber = _prefixId.prefix "frenchTrainDetectionSystemLimitationNumber"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.4.2^^xsd:stringera:rinfIndex : 1.2.1.1.3.2^^xsd:string</para>
    ///   <para>rdfs:comment : Bands of the frequency management of the train detection systems as defined in the TSI CCS, and in the specific cases or technical documents referred to in Article 13 of TSI CCS when they are available.</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-09/index077_-_ERA_ERTMS_033281_v5.pdf^^xsd:anyURIrdfs:seeAlso : https://eur-lex.europa.eu/eli/reg_impl/2023/1695/oj^^xsd:anyURI</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:XMLName : CCD_FreqBandDetec^^xsd:string</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:label : Frequency bands for detection</para>
    ///   <para>skos:scopeNote : Verification of compliance with TSI includes application of notified national rules (when they exist).
    ///
    /// Multiple selection from a predefined list:
    /// - Axle Counters: bands A1-A3
    /// - Track circuits: bands A1-A8</para>
    ///   <a href="http://data.europa.eu/949/frequencyBandsForDetection">era:frequencyBandsForDetection</a>
    /// </summary>
    let frequencyBandsForDetection = _prefixId.prefix "frequencyBandsForDetection"
    /// <summary>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>skos:scopeNote : This parameter is applicable when the IM wants to highlight a particular point requiring checks and provide info via parameter 'Document with the transversal section of the particular points requiring specific checks'.
    ///
    /// The railway location identifies the location of the structure in the system of reference of the line to which the track belongs.
    ///
    /// The location (generally the distance from the origin of the line to the point of interest for the specific check) on a line is given in kilometres with decimals (precision of 0.001).</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.0.3.5^^xsd:stringera:rinfIndex : 1.1.1.1.3.1.2^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-11-19^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>era:XMLName : ILL_GaugeCheckLoc^^xsd:string</para>
    ///   <para>rdfs:label : Railway location of particular points requiring specific checks</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Location of particular points requiring specific checks due to deviations from gauging referred to in parameter "Gauging"</para>
    ///   <a href="http://data.europa.eu/949/gaugingCheckLocation">era:gaugingCheckLocation</a>
    /// </summary>
    let gaugingCheckLocation = _prefixId.prefix "gaugingCheckLocation"
    /// <summary>
    ///   <para>rdfs:comment : Gauges as defined in European standard or other local gauges, including lower or upper part.</para>
    ///   <para>era:XMLName : ILL_Gauging^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-06-26^^xsd:datedcterms:modified : 2025-03-08^^xsd:datedcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>skos:scopeNote : It is possible to include additional values than the already identified and included in the concept scheme. They will be introduced by the Agency on request via a process of change request.
    ///
    ///                    UK in respect of the Northern Ireland have a reference profile, but defined based on national rule:
    /// 7.3.2.2 Specific case Ireland and UK for Northern Ireland ('P')
    /// It is permissible for the reference profile of the upper and the lower part of the unit to be established in accordance with the national technical rules notified for this purpose.
    ///
    ///                    See also:
    /// - Annex D1 OPE TSI
    /// - INF TSI: 4.2.3.1, 4.2.3.2 </para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:eratvIndex : 3.1.2.3^^xsd:stringera:eratvIndex : 4.2.1^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.0.3.4^^xsd:stringera:rinfIndex : 1.1.1.1.3.1.1^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2022-11/list_harmonised_national_restriction_codes_en.pdf^^xsd:anyURI</para>
    ///   <para>rdfs:label : Gauging</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/gaugingProfile">era:gaugingProfile</a>
    /// </summary>
    let gaugingProfile = _prefixId.prefix "gaugingProfile"
    /// <summary>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : ILL_GaugeCheckDocRef^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.0.3.6^^xsd:stringera:rinfIndex : 1.1.1.1.3.1.3^^xsd:string</para>
    ///   <para>rdfs:comment : Electronic document available from the IM stored by the Agency with the transversal section of the particular points requiring specific checks due to deviations from gauging referred to in parameter "Gauging". Where relevant, guidance for the check with the particular point may be attached to the document with the transversal section.</para>
    ///   <para>skos:scopeNote : The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-04-23^^xsd:date</para>
    ///   <para>rdfs:label : Document with the transversal section of the particular points requiring specific checks</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>skos:changeNote : Change from datatype property to object property in order to point to the class Document (reference document)</para>
    ///   <a href="http://data.europa.eu/949/gaugingTransversalDocument">era:gaugingTransversalDocument</a>
    /// </summary>
    let gaugingTransversalDocument = _prefixId.prefix "gaugingTransversalDocument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:dependencyNote : GSM-R and ETCS L2 must be installed for this parameter to be applicable.</para>
    ///   <para>skos:scopeNote : Sections of EIRENE and ETCS subsets for trackside in TSI</para>
    ///   <para>rdfs:label : GPRS for ETCS</para>
    ///   <para>dcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:XMLName : CRG_GPRSForETCS^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.1.2.3.2^^xsd:stringera:rinfIndex : 1.1.1.3.3.3.2^^xsd:string</para>
    ///   <para>era:legalDeadline : 1 January 2021era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>rdfs:comment : Indication if GPRS can be used for ETCS</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/gprsForETCS">era:gprsForETCS</a>
    /// </summary>
    let gprsForETCS = _prefixId.prefix "gprsForETCS"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : 1 January 2021</para>
    ///   <para>skos:scopeNote : Since GPRS can be used for ETCS, indicate in which areas it is implemented (e.g.: whole section, only between two signals, at the station…)</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>era:dependencyNote : GSM-R, ETCS L2 and GPRS for ETCS must be installed for this parameter to be applicable.</para>
    ///   <para>era:XMLName : CRG_GPRSAreaOfImpl^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.1.2.3.3^^xsd:stringera:rinfIndex : 1.1.1.3.3.3.3^^xsd:string</para>
    ///   <para>rdfs:seeAlso : Sections of EIRENE optional for trackside in TSI</para>
    ///   <para>rdfs:comment : Indication of the area in which GPRS can be used for ETCS, expressed as a list of GPRS-enabled RBCs.</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Area of implementation of GPRS</para>
    ///   <a href="http://data.europa.eu/949/gprsImplementationArea">era:gprsImplementationArea</a>
    /// </summary>
    let gprsImplementationArea = _prefixId.prefix "gprsImplementationArea"
    /// <summary>
    ///   <para>dcterms:modified : 2021-08-10^^xsd:datedcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:label : Gradient for stabling tracks</para>
    ///   <para>era:rinfIndex : 1.2.2.0.3.1^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-10^^xsd:date</para>
    ///   <para>era:XMLName : ILL_Gradient^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Maximum value of the gradient for stabling tracks expressed in millimetres per metre.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/gradient">era:gradient</a>
    /// </summary>
    let gradient = _prefixId.prefix "gradient"
    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.1.3.6^^xsd:string</para>
    ///   <para>rdfs:seeAlso : INF TSI: 4.2.3.3^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:formatNote : in XML:  +/-NN.N (+/-NNNN.NNN)^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-09-10^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>rdfs:comment : Sequence of gradient values and locations of change in gradient</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.2^^xsd:stringera:tsiOPEAppendixD2Index : 3.2.1^^xsd:string</para>
    ///   <para>era:XMLName : ILL_GradProfile^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>rdfs:label : Gradient profile</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>skos:scopeNote : Data on the values of gradient along a SoL is given as a chain of information:
    ///
    /// Gradient (location) The first location corresponding to the start of the first value of the gradient is the centre point of start OP. If there are different values of the gradient, the parameter will be repeated. The last location will correspond to the point where the last value of the gradient starts. This value will be available until the centre point of the end OP.
    ///
    /// If there is only one value for the gradient along the track, then the location is not required, only the +/-NN.N value is expected.
    ///
    /// Gradient is expressed in mm/m; location is expressed in km of the line.
    ///
    /// Positive gradient (uphill) is marked with "+" and negative gradient (downhill) is marked by "-".
    ///
    /// The sequence shall follow the increasing kilometres of the line, and this does not take into consideration the running direction of the specific track. This will make the profile easier to read.
    ///
    /// Changes in gradient shall be registered only as far as necessary for train running calculations (minimum length of constant gradient shall be 500 m, the minimum change of gradient value shall be 0,5 mm/m).
    ///
    /// The required precision for gradient value is 0,5 mm/m, the required precision of location of the points of change of gradient is 10 m. The points of change of gradient are the points of vertical intersection of each vertical curve.</para>
    ///   <a href="http://data.europa.eu/949/gradientProfile">era:gradientProfile</a>
    /// </summary>
    let gradientProfile = _prefixId.prefix "gradientProfile"
    /// <summary>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>rdfs:label : Number of active GSM-R mobiles (EDOR) or simultaneous communication session on board for ETCS level 2 needed to perform radio block centre handovers without having an operational disruption</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:comment : Number of simultaneous communication session on board for ETCS level 2 required for a smooth running of the train. This relates to the radio block centre (RBC) handling of communication sessions. Not safety critical and no matter of interoperability.</para>
    ///   <para>era:XMLName : CRG_NumActiveMob^^xsd:string</para>
    ///   <para>era:dependencyNote : GSM-R and ETCS level 2 must be installed for this parameter to be applicable.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.3.2^^xsd:stringera:rinfIndex : 1.2.1.1.2.2^^xsd:string</para>
    ///   <para>skos:scopeNote : In case there is no ETCS Level 2 in the line, do this parameter must be flagged as Not Applicable.
    /// In case there is ETCS Level 2 in the line, the minimum number of EDOR required on board would be 1.
    /// In case ETCS baseline 3 release 2 or baseline 4 is selected, select "2" .
    /// Please select " 1"  or "2" , taking into account that TSI compliant trains may only be fitted with 1 EDOR.</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/gsmRActiveMobiles">era:gsmRActiveMobiles</a>
    /// </summary>
    let gsmRActiveMobiles = _prefixId.prefix "gsmRActiveMobiles"
    /// <summary>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.3.3.1^^xsd:stringera:rinfIndex : 1.2.1.1.2.3.1^^xsd:string</para>
    ///   <para>era:XMLName : CRG_AdditionalnetworkInfo^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>skos:scopeNote : Please use this field to indicate any additional information on the GSM-R network.
    ///
    /// The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <para>rdfs:comment : Any additional information on network characteristics or corresponding document available from the IM and stored by the Agency, e.g.; interference level, leading to the recommendation of additional on-board protection.</para>
    ///   <para>skos:changeNote : Change from datatype property to object property in order to point to the class Document (reference document)</para>
    ///   <para>era:legalDeadline : 1 January 2021era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>rdfs:label : Additional information on network characteristics</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:dependencyNote : GSM-R must be installed for this parameter to be applicable</para>
    ///   <a href="http://data.europa.eu/949/gsmRAdditionalInfo">era:gsmRAdditionalInfo</a>
    /// </summary>
    let gsmRAdditionalInfo = _prefixId.prefix "gsmRAdditionalInfo"
    /// <summary>
    ///   <para>dcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : 1 January 2021</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:dependencyNote : GSM-R (parameter 1.1.1.3.3.1) must be installed for this parameter to be applicable.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : No GSMR coverage</para>
    ///   <para>era:rinfIndex : 1.1.1.3.3.8^^xsd:stringera:rinfIndex : 1.2.1.1.2.8^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>era:XMLName : CRG_GSMRNoCoverage^^xsd:string</para>
    ///   <para>rdfs:comment : Indication if there is no GSMR coverage</para>
    ///   <para>skos:scopeNote : If GSM-R is not installed, this parameter should not be used.
    /// This parameter is mainly to capture the case of Radio Hole functionality (lack of GSM-R coverage), that is foreseen in the ETCS specifications as packet 68.
    /// Another possible use is the declaration of a temporary situation where, although the area is in principle covered by GSM-R, there is a long-term outage or a project for replacement of the radio (i.e. a section that will not be covered with GSM-R for half a year or longer).</para>
    ///   <a href="http://data.europa.eu/949/gsmRNoCoverage">era:gsmRNoCoverage</a>
    /// </summary>
    let gsmRNoCoverage = _prefixId.prefix "gsmRNoCoverage"
    /// <summary>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>rdfs:label : Optional GSM-R functions</para>
    ///   <para>era:dependencyNote : GSM-R (parameter 1.1.1.3.3.1) must be installed for this parameter to be applicable</para>
    ///   <para>era:rinfIndex : 1.1.1.3.3.3^^xsd:stringera:rinfIndex : 1.2.1.1.2.3^^xsd:string</para>
    ///   <para>era:XMLName : CRG_OptionalFunctions^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latestera:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>rdfs:comment : Use of optional GSM-R functions which might improve operation on the line. They are for information only and not for network access criteria.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>skos:scopeNote : (*1) These inputs refer to the expected behaviour by the network, i.e. if there is any area or point where an automatic selection of network should be done or if there is any location where balises to instruct a change of radio network have been installed.
    /// In order to be able to attend to these indications (automatic network, network change by balise) some configuration is needed in the mobile.
    /// In case there is a balise used to announce the change of the network, or if there are locations where the network selection is planned by the IM to be done automatically (and not manually, as stated in the requirements). It should be considered as an item that is related to the design of the infrastructure.
    ///
    /// (*2) the possibility to dial 112 is something specific to the network that should be communicated to the vehicles accessing it.
    ///
    /// (*3) the use of broadcast calls is something specific to the network that has to be configured in it.
    ///
    /// (*4) it is something specific to the network that has to be configured in it if the service is provided.
    ///
    /// (*5) it is something specific to the network that has to be configured in it if the service is provided; something may need to be configured on the network but also in the mobile subscriber data if it wants to use the service. What is requested here is the information of the network capability.
    ///
    /// (*6) if they are configured on the network. Please indicate which in the "Other information" box.
    ///
    /// (*7) To be selected if other data applications, different from ETCS L2, can be used within the network -
    ///
    /// (*8) if it is configured on the network.
    ///  "GSM-R Shunting used" in order to make public if the GSM-R is used in the network for shunting activities.
    ///
    /// (*9) Please specify in the "Other information" box for which services /applications are they planned and which are the frequencies in use.
    ///
    /// (*11) Please use this field to indicate any additional information on network characteristics, e.g.; interference level, leading to the need of additional on-board protection;
    /// </para>
    ///   <a href="http://data.europa.eu/949/gsmROptionalFunctions">era:gsmROptionalFunctions</a>
    /// </summary>
    let gsmROptionalFunctions = _prefixId.prefix "gsmROptionalFunctions"
    /// <summary>
    ///   <para>rdfs:label : GSM-R radio data communication</para>
    ///   <para>era:eratvIndex : 4.13.2.7^^xsd:string</para>
    ///   <para>rdfs:comment : GSM-R Radio Data communication on board and its Baseline.</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/gsmRRadioDataCommunication">era:gsmRRadioDataCommunication</a>
    /// </summary>
    let gsmRRadioDataCommunication = _prefixId.prefix "gsmRRadioDataCommunication"
    /// <summary>
    ///   <para>era:eratvIndex : 4.13.2.2^^xsd:string</para>
    ///   <para>rdfs:comment : Number of GSM-R mobile sets in driving cab for data transmission.</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : GSM-R sets in driving cab</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/gsmRSetsInDrivingCab">era:gsmRSetsInDrivingCab</a>
    /// </summary>
    let gsmRSetsInDrivingCab = _prefixId.prefix "gsmRSetsInDrivingCab"
    /// <summary>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.1.7^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>skos:scopeNote : GSM-R functional requirements specification and system requirements specification in accordance with the specification respectively referenced in TSI CCS (Annex ), version number installed lineside.
    ///
    /// Since more than one version may be installed in different areas, this property can have multiple values.
    /// In case there is no GSM-R network available, this property shall be flagged as not applicable and all other GSM-R parameters ('Number of active GSM-R mobiles (EDOR) or simultaneous communication session on-board for ETCS Level 2 needed to perform radio block centre handovers without having an operational disruption' and 'Optional GSM-R functions') shall be flagged as not applicable.</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:dependencyNote : GSM-R must be installed for this parameter to be applicable and a value to be provided. If this property is not used, all GSM-R related properties should not be used either.</para>
    ///   <para>rdfs:comment : GSM-R functional requirements specification and system requirements specification in accordance with the specification respectively referenced in Appendix A-1, index [E] and index [F], version number installed lineside.</para>
    ///   <para>era:rinfIndex : 1.1.1.3.3.1^^xsd:stringera:rinfIndex : 1.2.1.1.2.1^^xsd:string</para>
    ///   <para>era:XMLName : CRG_Version^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : GSM-R version</para>
    ///   <para>rdfs:seeAlso : Referenced in Appendix A-1, index [E] and index [F]</para>
    ///   <para>era:eratvIndex : 4.13.2.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/gsmRVersion">era:gsmRVersion</a>
    /// </summary>
    let gsmRVersion = _prefixId.prefix "gsmRVersion"

    /// <summary>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:label : Specific constraints imposed by the GSM-R network operator on ETCS on-board units only able to operate in circuit-switch</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:dependencyNote : GSM-R and ETCS L2 must be installed for this parameter to be applicable. Multiple values are allowed.</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:rinfIndex : 1.2.1.1.2.12^^xsd:string</para>
    ///   <para>rdfs:comment : These constraints, where applicable, are meant to manage the limited number of circuit-switched radio connections that can be handled simultaneously by a Radio Block Center.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD3Index : 2.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/gsmrConstraintsOperateOnlyInCircuitSwitch">era:gsmrConstraintsOperateOnlyInCircuitSwitch</a>
    /// </summary>
    let gsmrConstraintsOperateOnlyInCircuitSwitch = _prefixId.prefix "gsmrConstraintsOperateOnlyInCircuitSwitch"

    /// <summary>
    ///   <para>rdfs:label : (Deprecated) GSM-R error corrections required for the on-board</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : List of unacceptable errors impacting the IM network that are required to be solved in the on-board according to the CCS TSI point 7.2.10.3 specification maintenance point.
    /// The reason for deprecation is that this parameter does not appear in the latest legal text.</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/gsmrErrorCorrectionsOnboard">era:gsmrErrorCorrectionsOnboard</a>
    /// </summary>
    let gsmrErrorCorrectionsOnboard = _prefixId.prefix "gsmrErrorCorrectionsOnboard"

    /// <summary>
    ///   <para>dcterms:created : 2022-11-07^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.2.11^^xsd:stringera:rinfIndex : 1.1.1.3.3.11^^xsd:string</para>
    ///   <para>rdfs:comment : This feature will determine the applicable operational rules for drivers and signallers when dealing with cab radios registered under wrong numbers.</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD3Index : 2.1^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>skos:scopeNote : See documents regarding Operational Harmonisation ETCS.</para>
    ///   <para>era:dependencyNote : GSM-R and ETCS L2 must be installed for this parameter to be applicable.</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:label : GSM-R network is configured to allow forced de-registration of a functional number by another driver</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/gsmrForcedDeregistrationFunctionalNumber">era:gsmrForcedDeregistrationFunctionalNumber</a>
    /// </summary>
    let gsmrForcedDeregistrationFunctionalNumber = _prefixId.prefix "gsmrForcedDeregistrationFunctionalNumber"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : 16 January 2020</para>
    ///   <para>rdfs:label : GSM-R networks covered by a roaming agreement</para>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>era:dependencyNote : GSM-R must be installed for this parameter to be applicable</para>
    ///   <para>era:rinfIndex : 1.2.1.1.2.5^^xsd:stringera:rinfIndex : 1.1.1.3.3.5^^xsd:string</para>
    ///   <para>skos:scopeNote : Name of the own GSM-R network and list of GSM-R networks which are covered by a roaming agreement for CS services.
    /// This list is managed by UIC. The Agency will monitor it in order to update the list of possible values when necessary.
    /// For Route Compatibility purposes and simplicity, the own network needs to be declared by the IM, so the RUs can systematically check the compatibility.
    /// For voice services, roaming for CS is applicable.  For ETCS, as long as roaming for CS is ensured, the interoperability will be guaranteed.</para>
    ///   <para>rdfs:comment : Name of the own GSM-R network and list of GSM-R networks which are covered by a roaming agreement (for CS services).</para>
    ///   <para>dcterms:created : 2020-08-31^^xsd:date</para>
    ///   <para>era:XMLName : CRG_RoamingAgreement^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/gsmrNetworkCoverage">era:gsmrNetworkCoverage</a>
    /// </summary>
    let gsmrNetworkCoverage = _prefixId.prefix "gsmrNetworkCoverage"
    /// <summary>
    ///   <para>dcterms:created : 2024-06-03^^xsd:date</para>
    ///   <para>rdfs:comment : Handover point flag attached to a Primary location.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : handover point flag</para>
    ///   <a href="http://data.europa.eu/949/handoverPointFlag">era:handoverPointFlag</a>
    /// </summary>
    let handoverPointFlag = _prefixId.prefix "handoverPointFlag"
    /// <summary>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2022-10-27^^xsd:date</para>
    ///   <para>rdfs:label : Has abstraction</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>rdfs:comment : Property that links a physical entity with its topological abstraction representation.</para>
    ///   <a href="http://data.europa.eu/949/hasAbstraction">era:hasAbstraction</a>
    /// </summary>
    let hasAbstraction = _prefixId.prefix "hasAbstraction"

    /// <summary>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:XMLName : CBP_AddInfoAvailable^^xsd:string</para>
    ///   <para>skos:scopeNote : [See TSI OPE 4.2.2.6.2 (2)]</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.11.2^^xsd:string</para>
    ///   <para>rdfs:comment : Availability by the IM of additional information as defined in point (2) of point 4.2.2.6.2 of Regulation (EU) 2023/1693 - TSI OPE</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Availability by the IM of additional information</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <a href="http://data.europa.eu/949/hasAdditionalBrakingInformation">era:hasAdditionalBrakingInformation</a>
    /// </summary>
    let hasAdditionalBrakingInformation = _prefixId.prefix "hasAdditionalBrakingInformation"

    /// <summary>
    ///   <para>rdfs:comment : Automatic dropping device (ADD) fitted (to be indicated for each energy supply system the vehicle is equipped for).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.10.11^^xsd:string</para>
    ///   <para>rdfs:label : Has automatic dropping device</para>
    ///   <a href="http://data.europa.eu/949/hasAutomaticDroppingDevice">era:hasAutomaticDroppingDevice</a>
    /// </summary>
    let hasAutomaticDroppingDevice = _prefixId.prefix "hasAutomaticDroppingDevice"
    /// <summary>
    ///   <para>era:formatNote : in XML: Y/N^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.4.4^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2021-09-10^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:XMLName : ITP_Ballast^^xsd:string</para>
    ///   <para>skos:scopeNote : This parameter is related to phenomena of ballast pick-up observed for the high-speed traffic.
    /// Requirements regarding ballast pick-up reduction at infrastructure subsystem level only applies to lines intended to be operated at speed greater than 250 km/h and is an open point in INF TSI: 4.2.10.3
    /// The parameter is about the phenomenon of ballast pick-up observed for the high-speed traffic, not about the ballast itself.
    /// As so far any specifications for mitigation of the problem were disclosed, the only information from RINF will be data about the network where the problems may be faced.</para>
    ///   <para>rdfs:seeAlso : Loc&amp;Pas TSI 4.2.6.2.5
    /// INF TSI : 4.2.10.3^^xsd:string</para>
    ///   <para>era:dependencyNote : Mandatory for tracks with permitted speed (parameter 1.1.1.1.2.5) greater than 250km/h</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>rdfs:comment : Specifies whether track construction is with sleepers embedded in ballast or not.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:label : Existence of ballast</para>
    ///   <a href="http://data.europa.eu/949/hasBallast">era:hasBallast</a>
    /// </summary>
    let hasBallast = _prefixId.prefix "hasBallast"
    /// <summary>
    ///   <para>skos:definition : Whether or not a track is associated with a bridge.</para>
    ///   <para>dcterms:created : 2024-12-10^^xsd:date</para>
    ///   <para>rdfs:label : Has bridge</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasBridge">era:hasBridge</a>
    /// </summary>
    let hasBridge = _prefixId.prefix "hasBridge"

    /// <summary>
    ///   <para>dcterms:created : 2021-08-26^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.6.2^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has cant deficiency compensation</para>
    ///   <para>rdfs:comment : Vehicle equipped with a cant deficiency compensation system (tilting vehicle).</para>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/hasCantDefficiencyCompensation">era:hasCantDefficiencyCompensation</a>
    /// </summary>
    let hasCantDefficiencyCompensation = _prefixId.prefix "hasCantDefficiencyCompensation"

    /// <summary>
    ///   <para>rdfs:label : Connecting Infrastructure Manager</para>
    ///   <para>rdfs:comment : Indicates whether any neighbouring section of line belongs to different Infrastructure Manager</para>
    ///   <para>dcterms:created : 2025-09-29^^xsd:date</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasConnectingIM">era:hasConnectingIM</a>
    /// </summary>
    let hasConnectingIM = _prefixId.prefix "hasConnectingIM"
    /// <summary>
    ///   <para>rdfs:label : Has current limitation</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:comment : Electric units equipped with power or current limitation function.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.10.14^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasCurrentLimitation">era:hasCurrentLimitation</a>
    /// </summary>
    let hasCurrentLimitation = _prefixId.prefix "hasCurrentLimitation"
    /// <summary>
    ///   <para>rdfs:label : Existence of operating restrictions or conditions</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-11-20^^xsd:date</para>
    ///   <para>rdfs:comment : Indication whether restrictions or conditions due to partial compliance with the TSI CCS exist.</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/content/certification-issues^^xsd:anyURIrdfs:seeAlso : https://www.era.europa.eu/system/files/2022-11/restrictions_and_added_functions_en_1.doc^^xsd:anyURI</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.6^^xsd:stringera:rinfIndex : 1.1.1.3.2.6^^xsd:string</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>skos:scopeNote : If operational restrictions and conditions are applicable, a document will be provided as a value of era:era:etcsRestrictionsConditionsDoc property. The RU has to contact the IM to be informed about these conditions.
    ///
    /// These conditions and restrictions of use are considered in section 6.4 of the CCS TSI. They should be described using the template available on Agency website (Certification
    /// and deviations - Guidelines for using the ERA template) with the following link: https://www.era.europa.eu/activities/european-rail-traffic-management-system-ertms_en#meeting6.</para>
    ///   <para>era:XMLName : CPE_RestrictionsConditions^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasETCSRestrictionsConditions">era:hasETCSRestrictionsConditions</a>
    /// </summary>
    let hasETCSRestrictionsConditions = _prefixId.prefix "hasETCSRestrictionsConditions"
    /// <summary>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2021-08-10^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>era:XMLName : ITS_ElectricShoreSupply^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.2.0.4.6^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-10^^xsd:date</para>
    ///   <para>rdfs:label : Existence of electric shore supply</para>
    ///   <para>rdfs:comment : Indication whether exists an installation of electric shore supply (fixed installation for servicing trains).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasElectricShoreSupply">era:hasElectricShoreSupply</a>
    /// </summary>
    let hasElectricShoreSupply = _prefixId.prefix "hasElectricShoreSupply"
    /// <summary>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2021-08-10^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.0.5.6^^xsd:stringera:rinfIndex : 1.1.1.1.8.9^^xsd:stringera:rinfIndex : 1.2.2.0.5.6^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SRT TSI: 4.4.2
    /// OPE TSI: 4.2.3.7^^xsd:string</para>
    ///   <para>skos:scopeNote : A value may not be applicable for tunnels shorter than 1 km, as for them the fire category according SRT TSI does not exist.
    /// Emergency plan has to be a document developed for each tunnel under the direction of the IM, in co-operation, where appropriate, with RUs, Rescue services and relevant authorities. It shall be consistent with the self-rescue, evacuation and rescue facilities provided.
    /// It is applicable for tunnels longer than 1 km, in accordance with section 4.4.2 of SRT TSI, the emergency plan is mandatory only for tunnel length of more than 1km.
    ///
    /// SRT TSI: 4.4.2
    /// OPE TSI: 4.2.3.7</para>
    ///   <para>era:XMLName : ITU_EmergencyPlan^^xsd:string</para>
    ///   <para>rdfs:comment : Indication whether emergency plan exists.</para>
    ///   <para>rdfs:label : Existence of emergency plan</para>
    ///   <para>era:dependencyNote : Mandatory for tunnels longer than 1 km</para>
    ///   <a href="http://data.europa.eu/949/hasEmergencyPlan">era:hasEmergencyPlan</a>
    /// </summary>
    let hasEmergencyPlan = _prefixId.prefix "hasEmergencyPlan"
    /// <summary>
    ///   <para>rdfs:comment : Indication whether data for national packet 44 applications is transmitted between track and train.</para>
    ///   <para>era:XMLName : CPE_NatApplication^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latestera:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>dcterms:modified : 2025-05-05^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.5^^xsd:stringera:rinfIndex : 1.2.1.1.1.5^^xsd:string</para>
    ///   <para>rdfs:label : has ETCS national packet 44 application implemented</para>
    ///   <para>dcterms:created : 2024-11-20^^xsd:date</para>
    ///   <para>era:dependencyNote : Only applicable when selected value for 1.1.1.3.2.1 (ETCS present).</para>
    ///   <para>skos:scopeNote : Value can be `false` or a link to the implemented functions. The hasEtcsNationalPacket44 property represents the true or false value. The etcsNationalPacket44Function represents the functions.
    ///
    /// Packets 44 are the means to transmit data for national applications between train and track and vice versa, using the data transmission facilities included within the ETCS.
    /// NID_XUSER values managed by ERA in a document about ETCS variables available on ERA website.
    ///
    /// See: TSI CCS (7.4.3 &amp; 6.2.4.2).</para>
    ///   <a href="http://data.europa.eu/949/hasEtcsNationalPacket44">era:hasEtcsNationalPacket44</a>
    /// </summary>
    let hasEtcsNationalPacket44 = _prefixId.prefix "hasEtcsNationalPacket44"
    /// <summary>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.3^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>era:dependencyNote : Mandatory for TSI-compliant tunnels longer than 0.5 km</para>
    ///   <para>era:XMLName : ITU_EvacAndRescuePoints^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.2.0.5.10^^xsd:stringera:rinfIndex : 1.2.1.0.5.11^^xsd:stringera:rinfIndex : 1.1.1.1.8.13^^xsd:string</para>
    ///   <para>dcterms:created : 2022-10-27^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : Point 4.2.1.7.  "Evacuation and rescue points" of the Commission Regulation (EU) No 1303/2014 of 18 November 2014 concerning the technical specification for interoperability relating to safety in railway tunnels of the rail system of the European Union|https://eur-lex.europa.eu/legal-content/EN/TXT/?qid=1566396648532&amp;uri=CELEX%3A02014R1303-20190616^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Indication of existence of evacuation and rescue points</para>
    ///   <para>rdfs:label : Existence of evacuation and rescue points</para>
    ///   <a href="http://data.europa.eu/949/hasEvacuationAndRescuePoints">era:hasEvacuationAndRescuePoints</a>
    /// </summary>
    let hasEvacuationAndRescuePoints = _prefixId.prefix "hasEvacuationAndRescuePoints"
    /// <summary>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-10^^xsd:date</para>
    ///   <para>era:XMLName : ITS_ExternalCleaning^^xsd:string</para>
    ///   <para>rdfs:label : Existence of external cleaning facilities</para>
    ///   <para>era:rinfIndex : 1.2.2.0.4.2^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indication whether exists an installation of external cleaning facility (fixed installation for servicing trains) as defined in TSI INF</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasExternalCleaning">era:hasExternalCleaning</a>
    /// </summary>
    let hasExternalCleaning = _prefixId.prefix "hasExternalCleaning"
    /// <summary>
    ///   <para>rdfs:label : Existence of trackside hot axle box detector (HABD)</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.7.4^^xsd:string</para>
    ///   <para>era:XMLName : IHS_HABDExist^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Existence of trackside HABD</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>skos:scopeNote : The aim of axle bearing condition monitoring is to detect deficient axle box bearings. The TSI Loc&amp;Pas provides with the requirement that units of maximum design speed higher than or equal to 250 km/h, on board detection equipment shall be provided. For units of maximum design speed lower than 250 km/h, and designed to be operated on others track gauge systems than the 1 520 mm system, axle bearing condition monitoring shall be provided and be achieved either by on board equipment or by using track side equipment. Track side equipment (also known as HABD) are defined from the perspective of rolling stock, for which the zone visible to the trackside equipment is defined by the area referred in the standard EN 15437-1:2009, as required by the TSI Loc&amp;Pas.
    /// This parameter is to indicate whether the section of line is equipped with trackside hot axle box detector (HABD) and is necessary for the route compatibility check.</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>rdfs:seeAlso : TSI Loc&amp;Pas: 4.2.10.2.3, 4.2.3.3.2
    /// WAG TSI: 4.2.3.4
    /// EN 15437-1:2009^^xsd:string</para>
    ///   <para>era:formatNote : in XML: Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasHotAxleBoxDetector">era:hasHotAxleBoxDetector</a>
    /// </summary>
    let hasHotAxleBoxDetector = _prefixId.prefix "hasHotAxleBoxDetector"
    /// <summary>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>rdfs:comment : Property that links a topological abstraction entity with its physical representation.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Has implementation</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2022-10-27^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasImplementation">era:hasImplementation</a>
    /// </summary>
    let hasImplementation = _prefixId.prefix "hasImplementation"
    /// <summary>
    ///   <para>rdfs:label : has linear referencing system</para>
    ///   <para>rdfs:comment : Specifies the linear referencing system to which the kilometre post is referenced. The linear referencing system is commonly the main railway line and it provides the framework for identifying the post's location along the railway line, using distance measurements rather than geographical coordinates.</para>
    ///   <para>dcterms:modified : 2025-03-10^^xsd:date</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/hasLRS">era:hasLRS</a>
    /// </summary>
    let hasLRS = _prefixId.prefix "hasLRS"
    /// <summary>
    ///   <para>dcterms:modified : 2021-09-11^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>era:formatNote : in XML: Y/N^^xsd:string</para>
    ///   <para>skos:scopeNote : This parameter concerns the level crossing of the railway with a road or a street. Provision the correct location of the level crossing(s) is not required, but RINF data model allows providing such information on a voluntary basis, and it can be a geographical information and/or a reference to a line referencing system.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>era:XMLName : IHS_LevelCrossing^^xsd:string</para>
    ///   <para>rdfs:label : Existence of level crossings</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>rdfs:comment : Indication whether level crossings (including pedestrian track crossing) exist on the section of line.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.7.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasLevelCrossings">era:hasLevelCrossings</a>
    /// </summary>
    let hasLevelCrossings = _prefixId.prefix "hasLevelCrossings"
    /// <summary>
    ///   <para>rdfs:label : has line referencing system coordinate</para>
    ///   <para>rdfs:comment : Specifies the LRS coordinate associated with a topological coordinate.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/hasLrsCoordinate">era:hasLrsCoordinate</a>
    /// </summary>
    let hasLrsCoordinate = _prefixId.prefix "hasLrsCoordinate"

    /// <summary>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Possibility of preventing the use of the lubrication device (only if fitted with flange lubrication).</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has lubrication device prevention</para>
    ///   <para>era:eratvIndex : 4.9.3.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasLubricationDevicePrevention">era:hasLubricationDevicePrevention</a>
    /// </summary>
    let hasLubricationDevicePrevention = _prefixId.prefix "hasLubricationDevicePrevention"

    /// <summary>
    ///   <para>dcterms:created : 2025-09-29^^xsd:date</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Has noise level limits</para>
    ///   <para>rdfs:comment : Indicate, if there are any limits on noise levels.</para>
    ///   <a href="http://data.europa.eu/949/hasNoiseLevelLimit">era:hasNoiseLevelLimit</a>
    /// </summary>
    let hasNoiseLevelLimit = _prefixId.prefix "hasNoiseLevelLimit"
    /// <summary>
    ///   <para>rdfs:comment : Relates the Organisation role instance (the role played by an Organisation)  with the specific role in the taxonomy of organisation roles.</para>
    ///   <para>rdfs:label : has organisation role</para>
    ///   <para>dcterms:created : 2024-06-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/hasOrganisationRole">era:hasOrganisationRole</a>
    /// </summary>
    let hasOrganisationRole = _prefixId.prefix "hasOrganisationRole"
    /// <summary>
    ///   <para>rdfs:label : has orientation</para>
    ///   <para>dcterms:created : 2024-10-28^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/hasOrientation">era:hasOrientation</a>
    /// </summary>
    let hasOrientation = _prefixId.prefix "hasOrientation"
    /// <summary>
    ///   <para>rdfs:label : Existence of other train protection, control and warning systems installed</para>
    ///   <para>era:rinfIndex : 1.1.1.3.5.1^^xsd:string</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication if other train protection, control and warning systems in normal operation are installed lineside.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/hasOtherTrainProtection">era:hasOtherTrainProtection</a>
    /// </summary>
    let hasOtherTrainProtection = _prefixId.prefix "hasOtherTrainProtection"
    /// <summary>
    ///   <para>rdfs:comment : Indicates if a vehicle type has parking brake.</para>
    ///   <para>dcterms:created : 2021-08-26^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has parking brake</para>
    ///   <para>era:eratvIndex : 4.7.3.4^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/hasParkingBrake">era:hasParkingBrake</a>
    /// </summary>
    let hasParkingBrake = _prefixId.prefix "hasParkingBrake"
    /// <summary>
    ///   <para>dcterms:created : 2024-05-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-01-30^^xsd:datedcterms:modified : 2025-07-24^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates that an infrastructure element is composed of one or more other (distinct) infrastructure elements.
    /// This property is used to represent part-whole relationships between infrastructure elements.
    /// An element cannot be a part of itself.</para>
    ///   <para>rdfs:label : has part</para>
    ///   <a href="http://data.europa.eu/949/hasPart">era:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>era:XMLName : EOS_Phase^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>era:formatNote : in XML: Y/N^^xsd:string</para>
    ///   <para>era:dependencyNote : A value is mandatory only if 1.1.1.2.2.1.1 parameter values is  Overhead contact line (OCL) , otherwise applicability flag is "N" (not applicable)</para>
    ///   <para>era:rinfIndex : 1.1.1.2.4.1.1^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>skos:scopeNote : In case of existence of phase separation on the track or on the section of the line the option  True  shall be selected.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of existence of phase separation and required information.</para>
    ///   <para>rdfs:label : Phase separation</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <a href="http://data.europa.eu/949/hasPhaseSeparation">era:hasPhaseSeparation</a>
    /// </summary>
    let hasPhaseSeparation = _prefixId.prefix "hasPhaseSeparation"
    /// <summary>
    ///   <para>rdfs:comment : Indication of the existence of the curvature of the platform.</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.3.8^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:XMLName : IPL_Curvature^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.0.6.8^^xsd:string</para>
    ///   <para>dcterms:created : 2022-10-27^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:label : Curvature of the platform</para>
    ///   <a href="http://data.europa.eu/949/hasPlatformCurvature">era:hasPlatformCurvature</a>
    /// </summary>
    let hasPlatformCurvature = _prefixId.prefix "hasPlatformCurvature"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Existence of refuelling</para>
    ///   <para>era:rinfIndex : 1.2.2.0.4.4^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:created : 2021-08-10^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:XMLName : ITS_Refuelling^^xsd:string</para>
    ///   <para>rdfs:comment : Indication whether exists an installation of refuelling (fixed installation for servicing trains) as defined in TSI INF.</para>
    ///   <a href="http://data.europa.eu/949/hasRefuelling">era:hasRefuelling</a>
    /// </summary>
    let hasRefuelling = _prefixId.prefix "hasRefuelling"
    /// <summary>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-08-06^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.7.4.3.1^^xsd:string</para>
    ///   <para>rdfs:comment : Indication whether regenerative braking is permitted or not.</para>
    ///   <para>rdfs:label : Permission for regenerative braking</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasRegenerativeBrake">era:hasRegenerativeBrake</a>
    /// </summary>
    let hasRegenerativeBrake = _prefixId.prefix "hasRegenerativeBrake"
    /// <summary>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:created : 2021-08-10^^xsd:date</para>
    ///   <para>rdfs:label : Existence of sand restocking</para>
    ///   <para>dcterms:modified : 2021-08-10^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>rdfs:comment : Indication whether an installation of sand restocking exists (fixed installation for servicing trains).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : ITS_SandRestocking^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.2.0.4.5^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasSandRestocking">era:hasSandRestocking</a>
    /// </summary>
    let hasSandRestocking = _prefixId.prefix "hasSandRestocking"
    /// <summary>
    ///   <para>rdfs:comment : Possibility of preventing the use of sanding.</para>
    ///   <para>era:eratvIndex : 4.14.2.12^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-09-01^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-09-01^^xsd:date</para>
    ///   <para>rdfs:label : Has sanding prevention</para>
    ///   <a href="http://data.europa.eu/949/hasSandingPrevention">era:hasSandingPrevention</a>
    /// </summary>
    let hasSandingPrevention = _prefixId.prefix "hasSandingPrevention"

    /// <summary>
    ///   <para>rdfs:label : Schematic overview of the operational point in digital form</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.1^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.0.0.0.7^^xsd:string</para>
    ///   <para>rdfs:comment : The existence of a schematic overview of the operational point in digital form.</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasSchematicOverviewOPDigitalForm">era:hasSchematicOverviewOPDigitalForm</a>
    /// </summary>
    let hasSchematicOverviewOPDigitalForm = _prefixId.prefix "hasSchematicOverviewOPDigitalForm"

    /// <summary>
    ///   <para>rdfs:label : has sequence</para>
    ///   <para>rdfs:comment : The ordered sequence of topological linear elements which create a linear net reference.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/hasSequence">era:hasSequence</a>
    /// </summary>
    let hasSequence = _prefixId.prefix "hasSequence"
    /// <summary>
    ///   <para>rdfs:comment : Climatic conditions on the line are severe according to European standard.</para>
    ///   <para>era:XMLName : IPP_SevereClimateCon^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-09-10^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Existence of severe climatic conditions</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:rinfIndex : 1.1.1.1.2.8^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:seeAlso : EN 50125-1 (2014): 4.7
    /// LOC&amp;PAS TSI:4.2.6.1.2^^xsd:string</para>
    ///   <para>skos:scopeNote : Value 'true' shall be selected in case there are possible severe climatic conditions to be expected, i.e. a significant amount of snow or ice is to be expected during winter and vehicle should be designed accordingly to be able to run in such conditions. (compliance to 4.2.6.1.2(3),(4) of TSI Loc&amp;Pas required). 'False' to be selected otherwise.
    ///
    /// Nominal and severe conditions are defined at TSI Loc&amp;Pas level, section 4.2.6.1.2, which requires that the applicant declares to which snow conditions a vehicle complies with : either "nominal" or "severe" conditions. This technical aspect is reflected in the parameter 4.3.3 "Snow, ice and hail conditions" of ERATV , which will provide the two possible values:
    /// - Nominal conditions correspond to compliance with clause 4.7 of EN 50125 as referred in the §4.2.6.1.2 (1) of TSI Loc&amp;Pas.
    /// To be noted: It is not required to precise the categorisation S1, S2 or S3 as mentioned in the EN 50125.
    /// - Severe conditions correspond to compliance with §4.2.6.1.2 (3) and (4) : the applicant designs and tests its vehicle according to the different scenarios mentioned in the TSI §4.2.6.1.2 (3) (snowdrift, powder snow, temperature gradient, etc.) and set the related provisions to achieve this as required by §4.2.6.1.2 (4) (obstacle deflector of sufficient size, effect of ice and snow on running gear and brake function, etc.).</para>
    ///   <a href="http://data.europa.eu/949/hasSevereWeatherConditions">era:hasSevereWeatherConditions</a>
    /// </summary>
    let hasSevereWeatherConditions = _prefixId.prefix "hasSevereWeatherConditions"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates the presence of shunting restrictions.</para>
    ///   <para>era:eratvIndex : 4.8.3^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:label : Has shunting restrictions</para>
    ///   <a href="http://data.europa.eu/949/hasShuntingRestrictions">era:hasShuntingRestrictions</a>
    /// </summary>
    let hasShuntingRestrictions = _prefixId.prefix "hasShuntingRestrictions"
    /// <summary>
    ///   <para>era:formatNote : Y/N^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.4.2.1^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>skos:scopeNote : In case of existence of system separation on the track or on the section of the line and required information on the section of the line, the option  Y=yes  shall be selected.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:label : System separation</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:dependencyNote : It is applicable ( Y ) only if the value  Overhead contact line (OCL)  is selected for parameter "Type of contact line system"</para>
    ///   <para>era:XMLName : EOS_System^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of existence of system separation</para>
    ///   <a href="http://data.europa.eu/949/hasSystemSeparation">era:hasSystemSeparation</a>
    /// </summary>
    let hasSystemSeparation = _prefixId.prefix "hasSystemSeparation"
    /// <summary>
    ///   <para>era:rinfIndex : 1.2.1.1.3.1^^xsd:stringera:rinfIndex : 1.1.1.3.4.1^^xsd:string</para>
    ///   <para>skos:scopeNote : Verification of compliance with TSI includes application of notified national rules (when they exist).
    ///
    /// See: (Annex I, Appendix A, Table A.2 -Index 77).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-09/index077_-_ERA_ERTMS_033281_v5.pdf^^xsd:anyURI</para>
    ///   <para>era:XMLName : CCD_TSITrainDetection^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>rdfs:label : Existence of train detection system fully compliant with the TSI</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:comment : Indication if there is any train detection system installed and fully compliant with the TSI CCS</para>
    ///   <a href="http://data.europa.eu/949/hasTSITrainDetection">era:hasTSITrainDetection</a>
    /// </summary>
    let hasTSITrainDetection = _prefixId.prefix "hasTSITrainDetection"
    /// <summary>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>rdfs:label : Existence of toilet discharge</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-10^^xsd:date</para>
    ///   <para>rdfs:comment : Indication whether exists an installation of toilet discharge (fixed installation for servicing trains) as defined in TSI INF</para>
    ///   <para>era:XMLName : ITS_ToiletDischarge^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:rinfIndex : 1.2.2.0.4.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasToiletDischarge">era:hasToiletDischarge</a>
    /// </summary>
    let hasToiletDischarge = _prefixId.prefix "hasToiletDischarge"
    /// <summary>
    ///   <para>rdfs:label : has topological coordinate</para>
    ///   <para>rdfs:comment : Specifies the topological coordinate of a network point reference.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/hasTopoCoordinate">era:hasTopoCoordinate</a>
    /// </summary>
    let hasTopoCoordinate = _prefixId.prefix "hasTopoCoordinate"
    /// <summary>
    ///   <para>rdfs:label : Has train integrity confirmation</para>
    ///   <para>era:eratvIndex : 4.13.1.9^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-31^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>rdfs:comment : Indication of on-board management system about completeness of the train information.</para>
    ///   <a href="http://data.europa.eu/949/hasTrainIntegrityConfirmation">era:hasTrainIntegrityConfirmation</a>
    /// </summary>
    let hasTrainIntegrityConfirmation = _prefixId.prefix "hasTrainIntegrityConfirmation"
    /// <summary>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>era:XMLName : ITU_Walkways^^xsd:string</para>
    ///   <para>skos:scopeNote : Indicates the existence of "Escape walkways", if the tunnel is longer than 0.5km then definition from Section 4.2.1.6 of TSI SRT applies.
    /// If the selected value is "true", provide the boolean value for "Is TSI compliant".
    /// On top of the requirements set out in the TSI SRT, the application guide to the TSI allows to use a ballastless track as a walkway. So, a 'Yes' in this parameters might not result in a physical standalone walkway.
    ///
    /// For Siding the mechanism to locate a specific object is different depending on the member state. The TWG is still working on it.</para>
    ///   <para>era:rinfIndex : 1.1.1.1.8.12^^xsd:stringera:rinfIndex : 1.2.2.0.5.9^^xsd:stringera:rinfIndex : 1.2.1.0.5.10^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:altLabel : Existence of walkways in tunnel</para>
    ///   <para>rdfs:comment : Indication of existence of walkways</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.3^^xsd:string</para>
    ///   <para>era:dependencyNote : Mandatory for TSI-compliant tunnels longer than 0.5 km</para>
    ///   <para>era:applicable : Y/NYA^^xsd:string</para>
    ///   <para>rdfs:seeAlso : Point 4.2.1.6. "Escape walkways" of the Commission Regulation (EU) No 1303/2014 of 18 November 2014 concerning the technical specification for interoperability relating to safety in railway tunnels of the rail system of the European Union|https://eur-lex.europa.eu/legal-content/EN/TXT/?qid=1566396648532&amp;uri=CELEX%3A02014R1303-20190616 ^^xsd:anyURI</para>
    ///   <para>rdfs:label : Existence of walkways</para>
    ///   <para>dcterms:created : 2022-10-27^^xsd:date</para>
    ///   <para>era:formatNote : [Y/N]
    ///
    /// If =Y then TSI-Compliant OR NON-TSI-Compliant^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hasWalkway">era:hasWalkway</a>
    /// </summary>
    let hasWalkway = _prefixId.prefix "hasWalkway"
    /// <summary>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:XMLName : ITS_WaterRestocking^^xsd:string</para>
    ///   <para>rdfs:label : Existence of water restocking</para>
    ///   <para>era:rinfIndex : 1.2.2.0.4.3^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>rdfs:comment : Indication whether exists an installation of water restocking (fixed installation for servicing trains) as defined in TSI INF</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-10^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/hasWaterRestocking">era:hasWaterRestocking</a>
    /// </summary>
    let hasWaterRestocking = _prefixId.prefix "hasWaterRestocking"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the presence of a wheel slide protection system.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.7.8^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:label : Has wheel slide protection system</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/hasWheelSlideProtectionSystem">era:hasWheelSlideProtectionSystem</a>
    /// </summary>
    let hasWheelSlideProtectionSystem = _prefixId.prefix "hasWheelSlideProtectionSystem"
    /// <summary>
    ///   <para>rdfs:label : Hash source</para>
    ///   <para>rdfs:comment : This property indicates for each infrastructure element, the source, i.e. the identifier  or key that was input to the hash function in order to generate the hash value that is part of the hash URI.</para>
    ///   <para>dcterms:created : 2024-02-06^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/hashSource">era:hashSource</a>
    /// </summary>
    let hashSource = _prefixId.prefix "hashSource"

    /// <summary>
    ///   <para>rdfs:label : Health, safety and environment</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.7^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/healthSafetyAndEnvironmentDataParameter">era:healthSafetyAndEnvironmentDataParameter</a>
    /// </summary>
    let healthSafetyAndEnvironmentDataParameter = _prefixId.prefix "healthSafetyAndEnvironmentDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Health, safety and environment</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.7^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/healthSafetyAndEnvironmentObjParameter">era:healthSafetyAndEnvironmentObjParameter</a>
    /// </summary>
    let healthSafetyAndEnvironmentObjParameter = _prefixId.prefix "healthSafetyAndEnvironmentObjParameter"

    /// <summary>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.2.4.2^^xsd:string</para>
    ///   <para>rdfs:seeAlso : Annex D1 OPE TSI
    /// INF TSI: 4.2.7.1.2(2)^^xsd:string</para>
    ///   <para>rdfs:label : Compliance of structures with the High Speed Load Model (HSLM)</para>
    ///   <para>rdfs:comment : For sections of line with a maximum permitted speed of 200 km/h or more. Information regarding the procedure to be used to perform the dynamic compatibility check.</para>
    ///   <para>era:XMLName : IPP_HSLMCompliant^^xsd:string</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>skos:scopeNote : (TSI INF 4.2.7.1.2(2)) Applicable if the maximum permitted speed of the running track is more than 200km/h and the structures within the section of line are all compatible with the High Speed Load Model (HSLM); information regarding the procedure to be used to perform the dynamic compatibility check shall be provided as well.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/highSpeedLoadModelCompliance">era:highSpeedLoadModelCompliance</a>
    /// </summary>
    let highSpeedLoadModelCompliance = _prefixId.prefix "highSpeedLoadModelCompliance"
    /// <summary>
    ///   <para>skos:changeNote : This property was previously a datatype property with domain Track and range string. As its values are a list of three predefined values, it is now a SKOS.</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>rdfs:label : Direction of measurement of trackside HABD</para>
    ///   <para>rdfs:comment : Direction of measurement of trackside HABD, specific for the French Italian and Swedish networks.</para>
    ///   <para>dcterms:created : 2022-07-08^^xsd:date</para>
    ///   <para>era:dependencyNote : Mandatory if the HABD is not TSI compliant (the value of parameter 1.1.1.1.7.5 (Trackside HABD TSI compliant) is 'False')</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2025-02-20^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>era:XMLName : IHS_HABDDirection^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.7.9^^xsd:string</para>
    ///   <para>skos:scopeNote : Specific for the French Italian and Swedish networks.
    /// Applicable if trackside HABD is not TSI compliant, direction of measurement of trackside hot axle box detector.
    /// If the direction of measurement is:
    /// -	the same as the direction defined by the start and end of the SoL: (N)
    /// -	the opposite to the direction defined by the start and end of the SoL: (O)
    /// -	both directions: (B)</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hotAxleBoxDetectorDirection">era:hotAxleBoxDetectorDirection</a>
    /// </summary>
    let hotAxleBoxDetectorDirection = _prefixId.prefix "hotAxleBoxDetectorDirection"
    /// <summary>
    ///   <para>skos:scopeNote : Waiting provision of possible answers by the French, Italian and Swedish NREs </para>
    ///   <para>era:rinfIndex : 1.1.1.1.7.7^^xsd:string</para>
    ///   <para>rdfs:label : Generation of trackside HABD</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:XMLName : IHS_HABDGen^^xsd:string</para>
    ///   <para>era:dependencyNote : Mandatory if the HABD is not TSI compliant (the value of parameter 1.1.1.1.7.5 (Trackside HABD TSI compliant) is 'False')</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2021-09-11^^xsd:date</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Specific for the French Italian and Swedish networks.
    /// Generation of trackside hot axle box detector.</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/hotAxleBoxDetectorGeneration">era:hotAxleBoxDetectorGeneration</a>
    /// </summary>
    let hotAxleBoxDetectorGeneration = _prefixId.prefix "hotAxleBoxDetectorGeneration"

    /// <summary>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2025-09-03^^xsd:datedcterms:modified : 2021-09-11^^xsd:date</para>
    ///   <para>rdfs:comment : Specific for the French, Italian and Swedish networks.
    /// Applicable if trackside HABD is not TSI compliant, identification of trackside hot axle box detector.</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:XMLName : IHS_HABDID^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:dependencyNote : Mandatory if the HABD is not TSI compliant (the value of parameter 1.1.1.1.7.5 (Trackside HABD TSI compliant) is 'False')</para>
    ///   <para>era:rinfIndex : 1.1.1.1.7.6^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>rdfs:label : Identification of trackside HABD</para>
    ///   <a href="http://data.europa.eu/949/hotAxleBoxDetectorIdentification">era:hotAxleBoxDetectorIdentification</a>
    /// </summary>
    let hotAxleBoxDetectorIdentification = _prefixId.prefix "hotAxleBoxDetectorIdentification"

    /// <summary>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:XMLName : IHS_HABDLoc^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.7.8^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>rdfs:comment : Specific for the French Italian and Swedish networks.
    /// Applicable if trackside HABD is not TSI compliant, localisation of trackside hot axle box detector.</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2021-09-11^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:dependencyNote : Mandatory if the HABD is not TSI compliant (the value of parameter 1.1.1.1.7.5 (Trackside HABD TSI compliant) is 'False')</para>
    ///   <para>rdfs:label : Railway location of trackside HABD</para>
    ///   <para>skos:scopeNote : The location (generally the distance from the origin of the line to the point of interest) on a line is given in kilometres with decimals (precision of 0.001).
    ///
    /// It may be also possible to provide the location of the HABD as an era:netReference property for the HABD pointing to an era:NetPointReference with (at least)era:LinearPositioningSystemCoordinate</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/hotAxleBoxDetectorLocation">era:hotAxleBoxDetectorLocation</a>
    /// </summary>
    let hotAxleBoxDetectorLocation = _prefixId.prefix "hotAxleBoxDetectorLocation"

    /// <summary>
    ///   <para>era:XMLName : IHS_TSIHABD^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>rdfs:seeAlso : TSI LOC&amp;PAS: 4.2.3.3.2.2, and 7.3.2.3
    /// WAG TSI: 4.2.3.4 and 7.3.2.2
    /// EN 15437-1:2009^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-09-11^^xsd:date</para>
    ///   <para>rdfs:label : Trackside HABD TSI compliant</para>
    ///   <para>era:rinfIndex : 1.1.1.1.7.5^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Specific for the French, Italian and Swedish networks.
    /// Trackside HABD compliant to TSI means that the HABD Trackside is compliant with:
    /// - EN 15437-1:2009 referred in TSIs (LOC&amp;PAS: 4.2.3.3.2.2, WAG TSI: 4.2.3.4),
    /// - Specific cases mentioned in TSIs (LOC&amp;PAS TSI, WAG TSI).</para>
    ///   <a href="http://data.europa.eu/949/hotAxleBoxDetectorTSICompliant">era:hotAxleBoxDetectorTSICompliant</a>
    /// </summary>
    let hotAxleBoxDetectorTSICompliant = _prefixId.prefix "hotAxleBoxDetectorTSICompliant"

    /// <summary>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.7^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-12-05^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:comment : Unique RBC identification (NID_C+NID_RBC) and calling number (NID_RADIO) as defined in the specification referenced in Appendix A-1, index [C].</para>
    ///   <para>skos:scopeNote : Non-harmonizable character string: [Contents of P42, not P143]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.17^^xsd:stringera:rinfIndex : 1.1.1.3.2.17^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>rdfs:label : (deprecated) ID and phone number of ERTMS/ETCS Radio Block Center</para>
    ///   <a href="http://data.europa.eu/949/idPhoneErtmsRadioBlockCenter">era:idPhoneErtmsRadioBlockCenter</a>
    /// </summary>
    let idPhoneErtmsRadioBlockCenter = _prefixId.prefix "idPhoneErtmsRadioBlockCenter"
    /// <summary>
    ///   <para>dcterms:modified : 2024-10-30^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-06-03^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-11-12^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-02^^xsd:date</para>
    ///   <para>rdfs:comment : Infrastructure manager means any body or firm responsible in particular for establishing, managing and maintaining railway infrastructure, including traffic management and control-command signalling;
    /// the functions of the infrastructure manager on a network or part of a network may be allocated to different bodies or firms. Definition in (Article 3(2))</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Infrastructure manager (IM)'s code</para>
    ///   <para>rdfs:seeAlso : https://eur-lex.europa.eu/eli/dir/2012/34/oj#d1e885-32-1^^xsd:anyURI</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/imCode">era:imCode</a>
    /// </summary>
    let imCode = _prefixId.prefix "imCode"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the country in which an entity resides.</para>
    ///   <para>dcterms:created : 2020-09-01^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-03-10^^xsd:datedcterms:modified : 2020-11-20^^xsd:date</para>
    ///   <para>rdfs:label : In country</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/inCountry">era:inCountry</a>
    /// </summary>
    let inCountry = _prefixId.prefix "inCountry"
    /// <summary>
    ///   <para>rdfs:label : In NUTS-3</para>
    ///   <para>dcterms:created : 2025-09-21^^xsd:date</para>
    ///   <para>rdfs:comment : Reference to NUTS-3 place or city</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/inNUTS3">era:inNUTS3</a>
    /// </summary>
    let inNUTS3 = _prefixId.prefix "inNUTS3"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : in SKOS Concept Scheme</para>
    ///   <para>rdfs:comment : Property that links an object SKOS property to a the URI of the corresponding SKOS Concept Scheme.</para>
    ///   <para>dcterms:modified : 2024-08-13^^xsd:date</para>
    ///   <para>dcterms:created : 2022-11-17^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/inSkosConceptScheme">era:inSkosConceptScheme</a>
    /// </summary>
    let inSkosConceptScheme = _prefixId.prefix "inSkosConceptScheme"
    /// <summary>
    ///   <para>rdfs:label : includes list of linear references</para>
    ///   <para>rdfs:comment : List of linear references included in an network area reference.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/includes">era:includes</a>
    /// </summary>
    let includes = _prefixId.prefix "includes"
    /// <summary>
    ///   <para>rdfs:label : Infrastructure subsystem</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/infraSubsystemDataParameter">era:infraSubsystemDataParameter</a>
    /// </summary>
    let infraSubsystemDataParameter = _prefixId.prefix "infraSubsystemDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Declarations of verification for track</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/infraSubsystemDeclarationsVerificationTrackDataParameter">era:infraSubsystemDeclarationsVerificationTrackDataParameter</a>
    /// </summary>
    let infraSubsystemDeclarationsVerificationTrackDataParameter = _prefixId.prefix "infraSubsystemDeclarationsVerificationTrackDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Infrastructure subsystem</para>
    ///   <para>dcterms:modified : 2024-10-28^^xsd:date</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/infraSubsystemObjParameter">era:infraSubsystemObjParameter</a>
    /// </summary>
    let infraSubsystemObjParameter = _prefixId.prefix "infraSubsystemObjParameter"
    /// <summary>
    ///   <para>rdfs:comment : Relates a subset with common characteristics with its IM, represented by an instance of organisation role that points to the "infrastructure manager" concept in the taxonomy.</para>
    ///   <para>dcterms:created : 2024-10-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-03-10^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : infrastructure manager</para>
    ///   <a href="http://data.europa.eu/949/infrastructureManager">era:infrastructureManager</a>
    /// </summary>
    let infrastructureManager = _prefixId.prefix "infrastructureManager"
    /// <summary>
    ///   <para>rdfs:comment : (deprecated) not in use. Relates any feature implemented in the European railway infrastructure with its infrastructure manager.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2022-07-07^^xsd:date</para>
    ///   <para>rdfs:label : Infrastructure manager</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/infrastructureMgr">era:infrastructureMgr</a>
    /// </summary>
    let infrastructureMgr = _prefixId.prefix "infrastructureMgr"

    /// <summary>
    ///   <para>era:XMLName : CTS_SwitchRadioSystemCondition^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:comment : Name and/or reference of the document specifying the Special instructions to switch over between different radio systems.</para>
    ///   <para>era:dependencyNote : Applicable when at least two different radio systems exist. </para>
    ///   <para>era:rinfIndex : 1.2.1.1.7.2.1^^xsd:stringera:rinfIndex : 1.1.1.3.8.2.1^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>dcterms:modified : 2024-11-04^^xsd:datedcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2022-10-28^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.4^^xsd:string</para>
    ///   <para>rdfs:label : Special instructions to switch over between different radio systems</para>
    ///   <para>skos:scopeNote : The details of the conditions to switch radio systems must be published.
    ///
    /// The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <a href="http://data.europa.eu/949/instructionsSwitchRadioSystems">era:instructionsSwitchRadioSystems</a>
    /// </summary>
    let instructionsSwitchRadioSystems = _prefixId.prefix "instructionsSwitchRadioSystems"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:altLabel : Internal connection</para>
    ///   <para>era:rinfIndex : 1.1.1.0.1.2^^xsd:stringera:rinfIndex : 1.2.4.1^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-11-29^^xsd:datedcterms:modified : 2021-08-03^^xsd:date</para>
    ///   <para>rdfs:label : is on origin of element A</para>
    ///   <para>rdfs:seeAlso : https://rsm-evolution.org/220927_RSM/EARoot/EA2/EA2/EA291.html^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Determines if the position of the topological element A in a relation is the origin of element A.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:datedcterms:created : 2021-04-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/isOnOriginOfElementA">era:isOnOriginOfElementA</a>
    /// </summary>
    let isOnOriginOfElementA = _prefixId.prefix "isOnOriginOfElementA"
    /// <summary>
    ///   <para>skos:altLabel : Internal connection</para>
    ///   <para>era:rinfIndex : 1.1.1.0.1.2^^xsd:stringera:rinfIndex : 1.2.4.1^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-11-29^^xsd:datedcterms:modified : 2021-08-03^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Determines if the position of the topological element B in a relation is the origin of element B.</para>
    ///   <para>rdfs:seeAlso : https://rsm-evolution.org/220927_RSM/EARoot/EA2/EA2/EA291.html^^xsd:anyURI</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:datedcterms:created : 2021-04-03^^xsd:date</para>
    ///   <para>rdfs:label : is on origin of element B</para>
    ///   <a href="http://data.europa.eu/949/isOnOriginOfElementB">era:isOnOriginOfElementB</a>
    /// </summary>
    let isOnOriginOfElementB = _prefixId.prefix "isOnOriginOfElementB"
    /// <summary>
    ///   <para>dcterms:modified : 2025-01-30^^xsd:date</para>
    ///   <para>dcterms:created : 2024-05-24^^xsd:date</para>
    ///   <para>rdfs:label : is part of</para>
    ///   <para>rdfs:comment : Indicates that an infrastructure element is a part of another (distinct) infrastructure element.
    /// An element cannot be part of itself.
    /// This property is the inverse of era:hasPart and represents the partial or whole-part relationship between infrastructure elements.</para>
    ///   <a href="http://data.europa.eu/949/isPartOf">era:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>era:legalDeadline : 1 January 2021</para>
    ///   <para>skos:scopeNote : Art 5B: A quieter route means a part of the railway infrastructure with a minimum length of 20 km on which the average number of daily operated freight trains during the night-time as defined in national legislation transposing Directive 2002/49/EC of the European Parliament and of the Council (5) was higher than 12. The freight traffic in the years 2015, 2016 and 2017 shall be the basis for the calculation of that average number. In case the freight traffic due to exceptional circumstances diverges in a given year from that average number by more than 25 %, the Member State concerned can calculate the average number on the basis of the remaining two years.
    /// Art 5.C 1:   Member States shall designate quieter routes in accordance with Article 5b and the procedure set out in Appendix D.1 of the Annex. They shall provide the European Union Agency for Railways ( the Agency ) with a list of quieter routes six months after the date of publication of this Regulation at the latest. The Agency shall publish those lists on its website.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:formatNote : in XML: Y/N^^xsd:string</para>
    ///   <para>era:XMLName : IHS_QuietRoute^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.7.11^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>dcterms:created : 2020-11-04^^xsd:date</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>rdfs:comment : Belonging to a 'quieter route' in accordance with Article 5b of TSI NOI.</para>
    ///   <para>rdfs:seeAlso : Art 5b of Regulation (EU) 1304/2014 (amended by Regulation (EU) 2019/774) of 16 May 2019^^xsd:string</para>
    ///   <para>rdfs:label : Belonging to a quieter route</para>
    ///   <a href="http://data.europa.eu/949/isQuietRoute">era:isQuietRoute</a>
    /// </summary>
    let isQuietRoute = _prefixId.prefix "isQuietRoute"
    /// <summary>
    ///   <para>dcterms:created : 2021-01-29^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-01-30^^xsd:datedcterms:modified : 2021-01-29^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-10-24^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.2.2^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Kilometer number of the kilometric post related to line identification defining the location of an infrastructure element.</para>
    ///   <para>era:XMLName : OPRailwayLocation^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.0.0.0.6^^xsd:string</para>
    ///   <para>rdfs:label : kilometer number</para>
    ///   <para>skos:scopeNote : For walkways: Value provided in Kilometric point of the start of the walkway and the length in m. Repeatable values for each location.
    /// For rescue points: Value provided in Kilometric point of the start of the point of evacuation and rescue point and the length in m. Repeatable values for each location.
    /// For signals: Relative position to the line identified under parameter 1.1.0.0.0.2, given in km ([reference point, via era:referent] / [NNN.NNN] ).</para>
    ///   <para>skos:altLabel : Railway location of Operational point</para>
    ///   <a href="http://data.europa.eu/949/kilometer">era:kilometer</a>
    /// </summary>
    let kilometer = _prefixId.prefix "kilometer"
    /// <summary>
    ///   <para>rdfs:label : km post for reference</para>
    ///   <para>rdfs:comment : The closest kilometric post on the line, used as a reference by the LRS coordinate.</para>
    ///   <para>dcterms:modified : 2025-03-10^^xsd:date</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/kmPost">era:kmPost</a>
    /// </summary>
    let kmPost = _prefixId.prefix "kmPost"
    /// <summary>
    ///   <para>dcterms:modified : 2025-03-10^^xsd:datedcterms:modified : 2024-10-24^^xsd:datedcterms:modified : 2024-11-29^^xsd:date</para>
    ///   <para>dcterms:created : 2024-05-24^^xsd:date</para>
    ///   <para>skos:altLabel : mileage post</para>
    ///   <para>rdfs:label : kilometric post name</para>
    ///   <para>rdfs:comment : Name of the kilometric post (optional).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/kmPostName">era:kmPostName</a>
    /// </summary>
    let kmPostName = _prefixId.prefix "kmPostName"
    /// <summary>
    ///   <para>rdfs:comment : Indication of radio legacy systems installed.</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.1.7^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.6.1^^xsd:stringera:rinfIndex : 1.2.1.1.5.1^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.13.2.3^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://eur-lex.europa.eu/legal-content/EN/TXT/?uri=CELEX%3A32023R1695&amp;qid=1694158367331#d1295e32-554-1^^xsd:anyURIrdfs:seeAlso : https://www.era.europa.eu/system/files/2022-11/list_harmonised_national_restriction_codes_en %281%29.pdf?t=1707149802^^xsd:anyURI</para>
    ///   <para>era:legalDeadline : 16 January 2020era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>skos:scopeNote : The list is in line with ERA/TD/2011-09/INT, Table 4, and is now in 3.4 of the annex II of TSI CCS.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Other radio systems installed (Radio Legacy Systems)</para>
    ///   <para>era:XMLName : CRS_Installed^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2020-08-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/legacyRadioSystem">era:legacyRadioSystem</a>
    /// </summary>
    let legacyRadioSystem = _prefixId.prefix "legacyRadioSystem"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : legal deadline</para>
    ///   <para>rdfs:comment : Annotation used to point to legal obligation of a parameter in RINF</para>
    ///   <para>dcterms:created : 2024-11-22^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/legalDeadline">era:legalDeadline</a>
    /// </summary>
    let legalDeadline = _prefixId.prefix "legalDeadline"
    /// <summary>
    ///   <para>rdfs:comment : Generic super-property for different types of length</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2024-11-04^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>skos:scopeNote : The length can be
    /// - a section of line (For operational length, use era:lengthOfSectionOfLine),
    /// - a tunnel (For operational length, use era:lengthOfTunnel),
    /// - a platform (For its usable length, use era:lengthOfPlatform),
    /// - a siding (For its usable length, use era:lengthOfSiding), and
    /// - length of other areas such as
    ///   - a non-stopping area (accuracy +- 10m),
    ///   - a walkway,
    ///   - an evacuation and rescue point.
    /// - a vehicle length.skos:scopeNote : Position of the start of the walkway:  [integer] m (from the same origin point of the kilometer post.)
    /// Lenght of the walkway: [integer] m</para>
    ///   <para>rdfs:seeAlso : ERA^^xsd:string</para>
    ///   <para>dcterms:created : 2021-04-01^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Length</para>
    ///   <a href="http://data.europa.eu/949/length">era:length</a>
    /// </summary>
    let length = _prefixId.prefix "length"
    /// <summary>
    ///   <para>rdfs:comment : Length of a topological linear element.</para>
    ///   <para>rdfs:label : length of net linear element</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/lengthOfNetLinearElement">era:lengthOfNetLinearElement</a>
    /// </summary>
    let lengthOfNetLinearElement = _prefixId.prefix "lengthOfNetLinearElement"
    /// <summary>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.0.6.4^^xsd:string</para>
    ///   <para>era:formatNote : NNNN^^xsd:string</para>
    ///   <para>rdfs:label : Usable length of platform</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.3^^xsd:stringera:tsiOPEAppendixD2Index : 2.3.6^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:comment : The maximum continuous length (expressed in metres) of that part of platform in front of which a train is intended to remain stationary in normal operating conditions for passengers to board and alight from the train, making appropriate allowance for stopping tolerances.</para>
    ///   <para>era:XMLName : IPL_Length^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2024-05-16^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : INF TSI: 4.2.1, 4.2.9.1
    /// OPE TSI: 4.2.2.5.2, 4.2.2.7.2^^xsd:string</para>
    ///   <para>skos:scopeNote : Platform dimensions are always related to one neighbouring track at a time.
    /// So, if two tracks are along a platform, this platform should be divided into two RINF platforms to have precise description of each.</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/lengthOfPlatform">era:lengthOfPlatform</a>
    /// </summary>
    let lengthOfPlatform = _prefixId.prefix "lengthOfPlatform"
    /// <summary>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:XMLName : SOLLength^^xsd:string</para>
    ///   <para>rdfs:comment : Length between operational points at start and end of section of line.</para>
    ///   <para>dcterms:created : 2024-05-16^^xsd:date</para>
    ///   <para>rdfs:label : Length of section of line</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.3^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.0.0.0.5^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/lengthOfSectionOfLine">era:lengthOfSectionOfLine</a>
    /// </summary>
    let lengthOfSectionOfLine = _prefixId.prefix "lengthOfSectionOfLine"
    /// <summary>
    ///   <para>dcterms:created : 2024-05-16^^xsd:date</para>
    ///   <para>rdfs:comment : Total length of the siding/stabling track expressed in metres where trains can be parked safely.</para>
    ///   <para>era:rinfIndex : 1.2.2.0.2.1^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.3^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:XMLName : IPP_Length^^xsd:string</para>
    ///   <para>rdfs:label : Usable length of siding</para>
    ///   <a href="http://data.europa.eu/949/lengthOfSiding">era:lengthOfSiding</a>
    /// </summary>
    let lengthOfSiding = _prefixId.prefix "lengthOfSiding"
    /// <summary>
    ///   <para>rdfs:comment : Length of a tunnel in metres from entrance portal to exit portal.</para>
    ///   <para>era:rinfIndex : 1.2.1.0.5.5^^xsd:stringera:rinfIndex : 1.1.1.1.8.7^^xsd:stringera:rinfIndex : 1.2.2.0.5.5^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:formatNote : NNNNN^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-03-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>rdfs:label : Length of tunnel</para>
    ///   <para>dcterms:created : 2024-05-16^^xsd:date</para>
    ///   <para>skos:scopeNote : Length of a tunnel is expressed in metres from portal to portal at the level of the top of rail. </para>
    ///   <para>era:XMLName : ITU_Length^^xsd:string</para>
    ///   <para>era:dependencyNote : Only applicable for a tunnel with length of 100 metres or more.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.3^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/lengthOfTunnel">era:lengthOfTunnel</a>
    /// </summary>
    let lengthOfTunnel = _prefixId.prefix "lengthOfTunnel"
    /// <summary>
    ///   <para>era:eratvIndex : 4.8.1^^xsd:string</para>
    ///   <para>rdfs:label : Vehicle length^^xsd:string</para>
    ///   <para>dcterms:created : 2024-11-04^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/lengthOfVehicle">era:lengthOfVehicle</a>
    /// </summary>
    let lengthOfVehicle = _prefixId.prefix "lengthOfVehicle"
    /// <summary>
    ///   <para>rdfs:label : Letter marking</para>
    ///   <para>rdfs:comment : letter marking</para>
    ///   <para>dcterms:created : 2021-08-25^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.1.7^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-25^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/letterMarking">era:letterMarking</a>
    /// </summary>
    let letterMarking = _prefixId.prefix "letterMarking"
    /// <summary>
    ///   <para>skos:scopeNote : INF TSI (4.2.1) classifies lines based on the type of traffic (traffic code).
    ///
    /// TSI categories of line shall be used for the classification of existing lines to define a target system so that the relevant performance parameters will be met.
    ///
    /// The TSI category of line is a combination of traffic codes. For lines where only one type of traffic is carried (for example a freight only line), a single code can be used to describe the requirements; where mixed traffic runs the category will be described by one or more codes for passenger and freight in case of two types of traffic. Then the parameter is repeated if relevant. The combined traffic codes describe the envelope within which the desired mix of traffic can be accommodated.
    ///
    /// Technical scope of the INF TSI includes all the networks (TEN and off-TEN) for nominal track gauges 1435, 1520, 1524, 1600 and 1668 mm.
    /// It is not applicable when track is not included in technical scope of the TSI.
    /// When more than one value of the parameter has to be published, then parameter has to be repeated as many times as many values of the parameter will be published.</para>
    ///   <para>era:XMLName : IPP_LineCat^^xsd:string</para>
    ///   <para>rdfs:label : Category of line</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:rinfIndex : 1.2.1.0.2.2^^xsd:stringera:rinfIndex : 1.1.1.1.2.2^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-02^^xsd:date</para>
    ///   <para>rdfs:comment : Classification of a line according to the TSI INF</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:example : If a line is operated by passenger trains with speed of 250 km/h, local commuter trains with speed of 120 km/h and heavy freight trains in the night, then the best combination of traffic codes seems to be P2, P5 and F1.
    /// Then, the TSI category of line for this case would simply be P2-P5-F1.^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/lineCategory">era:lineCategory</a>
    /// </summary>
    let lineCategory = _prefixId.prefix "lineCategory"
    /// <summary>
    ///   <para>dcterms:modified : 2025-09-03^^xsd:datedcterms:modified : 2024-11-18^^xsd:date</para>
    ///   <para>era:XMLName : SOLLineIdentification^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.2.1.1^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.0.0.0.2^^xsd:string</para>
    ///   <para>rdfs:comment : Unique line identification or unique line number within Member State.</para>
    ///   <para>rdfs:label : line identifier</para>
    ///   <a href="http://data.europa.eu/949/lineId">era:lineId</a>
    /// </summary>
    let lineId = _prefixId.prefix "lineId"
    /// <summary>
    ///   <para>rdfs:label : Line layout</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.0.3^^xsd:stringera:rinfIndex : 1.1.1.1.3^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/lineLayoutDataParameter">era:lineLayoutDataParameter</a>
    /// </summary>
    let lineLayoutDataParameter = _prefixId.prefix "lineLayoutDataParameter"
    /// <summary>
    ///   <para>rdfs:label : Line layout</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.0.3^^xsd:stringera:rinfIndex : 1.1.1.1.3^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/lineLayoutObjParameter">era:lineLayoutObjParameter</a>
    /// </summary>
    let lineLayoutObjParameter = _prefixId.prefix "lineLayoutObjParameter"
    /// <summary>
    ///   <para>rdfs:label : (deprecated) National line identification</para>
    ///   <para>era:rinfIndex : 1.1.0.0.0.2^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-10-28^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.2.1.1^^xsd:string</para>
    ///   <para>dcterms:created : 2020-09-30^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : SOLLineIdentification^^xsd:string</para>
    ///   <para>rdfs:comment : Unique line identification or unique line number within Member State.</para>
    ///   <a href="http://data.europa.eu/949/lineNationalId">era:lineNationalId</a>
    /// </summary>
    let lineNationalId = _prefixId.prefix "lineNationalId"
    /// <summary>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-11-29^^xsd:datedcterms:modified : 2024-10-24^^xsd:datedcterms:modified : 2025-01-30^^xsd:date</para>
    ///   <para>rdfs:label : (deprecated) Railway location of an infrastructure object</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2021-01-29^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a relationship with a national railway line at a specific kilometer point.</para>
    ///   <a href="http://data.europa.eu/949/lineReference">era:lineReference</a>
    /// </summary>
    let lineReference = _prefixId.prefix "lineReference"
    /// <summary>
    ///   <para>skos:example : Kilometer=`0.270`^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-10-24^^xsd:datedcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2024-11-29^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.8.4^^xsd:string</para>
    ///   <para>rdfs:label : End of tunnel kilometer</para>
    ///   <para>dcterms:created : 2024-02-05^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>skos:scopeNote : Parameters of this group (from 1.1.1.1.8.1 to 1.1.1.1.8.13) are only applicable if tunnels exist on the SoL</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Part of the End of tunnel that indicates the km of the line at the end of a tunnel.
    ///
    /// The End of tunnel is the Geographical coordinates in decimal degrees and km of the line at the end of a tunnel.</para>
    ///   <para>era:XMLName : SOLTunnelEnd^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/lineReferenceTunnelEnd">era:lineReferenceTunnelEnd</a>
    /// </summary>
    let lineReferenceTunnelEnd = _prefixId.prefix "lineReferenceTunnelEnd"
    /// <summary>
    ///   <para>skos:example : Kilometer=`0.895`^^xsd:string</para>
    ///   <para>era:XMLName : SOLTunnelStart^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>skos:scopeNote : Geographical coordinates according to the standard World Geodetic System (WGS).  Precision for both geographical latitude and geographical longitude is assumed as [NN.NNNNNNN] in degrees with decimals what gives discretion of 10 cm in the network.
    /// Kilometre shall concern the national line identification given in 1.1.0.0.0.2
    /// Location of the point which is assumed to be the beginning of the tunnel it is the point on the track centre line where is laid the vertical shadow of the extreme part of the tunnel s portal.</para>
    ///   <para>dcterms:modified : 2024-10-24^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2024-11-29^^xsd:date</para>
    ///   <para>rdfs:comment : Part of the Start of tunnel that indicates the km of the line at the beginning of a tunnel.
    ///
    /// The Start of tunnel is the Geographical coordinates in decimal degrees and km of the line at the beginning of a tunnel.</para>
    ///   <para>dcterms:created : 2024-02-05^^xsd:date</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.8.3^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Start of tunnel kilometer</para>
    ///   <a href="http://data.europa.eu/949/lineReferenceTunnelStart">era:lineReferenceTunnelStart</a>
    /// </summary>
    let lineReferenceTunnelStart = _prefixId.prefix "lineReferenceTunnelStart"

    /// <summary>
    ///   <para>rdfs:label : Line-side system for degraded situation</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.9^^xsd:stringera:rinfIndex : 1.1.1.3.10^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/lineSideSystemDegradedSituationObjParameter">era:lineSideSystemDegradedSituationObjParameter</a>
    /// </summary>
    let lineSideSystemDegradedSituationObjParameter = _prefixId.prefix "lineSideSystemDegradedSituationObjParameter"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:editorialNote : The reason for deprecation is that this property is not specified in the latest legal text nor the RINF application guide. Also, no data has been provided for this property.</para>
    ///   <para>dcterms:modified : 2023-11-10^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2021-04-01^^xsd:date</para>
    ///   <para>rdfs:label : Linear coordinate</para>
    ///   <para>rdfs:comment : Indicates the position of an object within a linear positioning system. For example, relative to a national railway line</para>
    ///   <a href="http://data.europa.eu/949/linearCoordinate">era:linearCoordinate</a>
    /// </summary>
    let linearCoordinate = _prefixId.prefix "linearCoordinate"
    /// <summary>
    ///   <para>rdfs:label : Lineside distance indication</para>
    ///   <para>dcterms:created : 2024-12-12^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.0.0.3^^xsd:string</para>
    ///   <para>era:formatNote : [NNNN] frequency in meters
    /// Appearance - selectable list
    /// [L/R] - the side along the track where the lineside indication is positioned (left or right)</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : Frequency, appearance and positioning of a sign indicating distance as reference post. Two types of sign are normally available: kilometer post and hectometer post.
    /// - A kilometer post is a lineside sign indicating the distance from a specific point, usually being the strarting point of the railway line.
    /// - An hectometer post is a lineside sign indicating a relative distance.</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2025-01-30^^xsd:date</para>
    ///   <para>rdfs:comment : Indication of types of appearance of track lineside distance indications.</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.1.3^^xsd:string</para>
    ///   <para>era:XMLName : SOL_LineDistIndication^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/linesideDistanceIndication">era:linesideDistanceIndication</a>
    /// </summary>
    let linesideDistanceIndication = _prefixId.prefix "linesideDistanceIndication"

    /// <summary>
    ///   <para>rdfs:label : Lineside distance indication appearance</para>
    ///   <para>dcterms:modified : 2025-01-30^^xsd:datedcterms:modified : 2024-09-24^^xsd:datedcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:created : 2022-10-27^^xsd:date</para>
    ///   <para>rdfs:comment : Indication of types of appearance of track lineside distance indications.</para>
    ///   <a href="http://data.europa.eu/949/linesideDistanceIndicationAppearance">era:linesideDistanceIndicationAppearance</a>
    /// </summary>
    let linesideDistanceIndicationAppearance = _prefixId.prefix "linesideDistanceIndicationAppearance"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Frequency of track lineside distance indications.</para>
    ///   <para>rdfs:label : Lineside distance indication frequency</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>dcterms:created : 2022-10-27^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/linesideDistanceIndicationFrequency">era:linesideDistanceIndicationFrequency</a>
    /// </summary>
    let linesideDistanceIndicationFrequency = _prefixId.prefix "linesideDistanceIndicationFrequency"

    /// <summary>
    ///   <para>dcterms:created : 2022-10-27^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2026-01-11^^xsd:datedcterms:modified : 2025-01-30^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>rdfs:label : Lineside distance indication positioning</para>
    ///   <para>rdfs:comment : Indication of the side along the track where the lineside indication is positioned (left or right, or both sides).</para>
    ///   <para>era:formatNote : A selection between 3 possible selectable values:
    /// - Left, or
    /// - Right, or
    /// - Left and Right</para>
    ///   <a href="http://data.europa.eu/949/linesideDistanceIndicationPositioning">era:linesideDistanceIndicationPositioning</a>
    /// </summary>
    let linesideDistanceIndicationPositioning = _prefixId.prefix "linesideDistanceIndicationPositioning"

    /// <summary>
    ///   <para>rdfs:label : linked to primary location</para>
    ///   <para>rdfs:comment : Relates a subsidiary location with a primary location.</para>
    ///   <para>dcterms:created : 2024-10-28^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/linkedToPrimaryLocation">era:linkedToPrimaryLocation</a>
    /// </summary>
    let linkedToPrimaryLocation = _prefixId.prefix "linkedToPrimaryLocation"
    /// <summary>
    ///   <para>rdfs:comment : A combination of the line category and speed at the weakest point of the track. The reason for deprecation is that the load capability property 1.1.1.1.2.4 was defined incorrectly as a SKOS property. It is composed of two values: (1)  line category, and (2) speed. Only line category is a list of predefined values (SKOS), whereas speed is an integer (according to the RINF application guide).</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2023-01-20^^xsd:date</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.2.4^^xsd:string</para>
    ///   <para>era:XMLName : IPP_LoadCap^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Load Capability</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/loadCapability">era:loadCapability</a>
    /// </summary>
    let loadCapability = _prefixId.prefix "loadCapability"
    /// <summary>
    ///   <para>rdfs:label : Load capability line category</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>rdfs:comment : Part of the load capability of a track that corresponds to the line category of the load model.
    /// The load capability is a value selected from the list of load models representing the line category which is amended by value of speed [km/h] permitted for a specific load model. The list of values may also be Route Availability which is amended by value of speed [miles/h] permitted for a specific load model.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-01-20^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/loadCapabilityLineCategory">era:loadCapabilityLineCategory</a>
    /// </summary>
    let loadCapabilityLineCategory = _prefixId.prefix "loadCapabilityLineCategory"
    /// <summary>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>dcterms:created : 2023-01-20^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Load capability speed</para>
    ///   <para>rdfs:comment : Part of the load capability of a track that corresponds to the speed of the load model</para>
    ///   <a href="http://data.europa.eu/949/loadCapabilitySpeed">era:loadCapabilitySpeed</a>
    /// </summary>
    let loadCapabilitySpeed = _prefixId.prefix "loadCapabilitySpeed"
    /// <summary>
    ///   <para>rdfs:comment : Maximum physical dimensions (height and width) to which an open rail wagon can be loaded</para>
    ///   <para>skos:editorialNote : TODO- review the range as it might be a list of SKOS concepts</para>
    ///   <para>rdfs:label : Loading gauge</para>
    ///   <para>dcterms:created : 2025-09-29^^xsd:date</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-09/ERA_technical-document-combined%20transport%20%28slide%208%201%20out%20of%203%29.pdf^^xsd:anyURI</para>
    ///   <a href="http://data.europa.eu/949/loadingGauge">era:loadingGauge</a>
    /// </summary>
    let loadingGauge = _prefixId.prefix "loadingGauge"
    /// <summary>
    ///   <para>era:eratvIndex : 4.8.7^^xsd:string</para>
    ///   <para>rdfs:label : Loading platform height</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Height of loading platform (for flat wagons and combined transport), given in mm.</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/loadingPlatformHeight">era:loadingPlatformHeight</a>
    /// </summary>
    let loadingPlatformHeight = _prefixId.prefix "loadingPlatformHeight"
    /// <summary>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>era:legalDeadline : 1 January 2021</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>era:XMLName : RUL_LocalRulesOrRestrictions^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.4.1^^xsd:stringera:rinfIndex : 1.2.3.1^^xsd:string</para>
    ///   <para>rdfs:label : Existence of rules and restrictions of a strictly local nature</para>
    ///   <para>rdfs:comment : Existence of rules and restrictions of a strictly local nature</para>
    ///   <para>skos:scopeNote : There is a general obligation for Member States to notify existing national rules but:  Member States may decide not to notify rules and restrictions of a strictly local nature. In such cases, Member States shall mention those rules and restrictions in the registers of infrastructure.
    /// In this eventuality, this parameter allows the IM accordingly to its Member State decision to declare the existence of such rules and to provide them with the parameter 'Documents regarding the rules or restrictions of a strictly local nature available by the IM'</para>
    ///   <para>era:formatNote : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/localRulesOrRestrictions">era:localRulesOrRestrictions</a>
    /// </summary>
    let localRulesOrRestrictions = _prefixId.prefix "localRulesOrRestrictions"
    /// <summary>
    ///   <para>rdfs:seeAlso : IOD: Notification of national rules Art 14. 11^^xsd:string</para>
    ///   <para>era:dependencyNote : Mandatory to provide at least a document if parameter "Existence of rules and restrictions of a strictly local nature" value is boolean "Yes"</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>skos:scopeNote : The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.
    ///
    /// IOD: Notification of national rules Art 14. 11. Member States may decide not to notify rules and restrictions of a strictly local nature. In such cases, Member States shall mention those rules and restrictions in the registers of infrastructure referred to in Article 49</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Documents regarding the rules or restrictions of a strictly local nature available by the IM</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-04-23^^xsd:datedcterms:modified : 2023-01-20^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.3.2^^xsd:stringera:rinfIndex : 1.1.1.4.2^^xsd:string</para>
    ///   <para>era:legalDeadline : 1 January 2021</para>
    ///   <para>skos:changeNote : Change from datatype property to object property in order to point to the class Document (reference document)</para>
    ///   <para>rdfs:comment : Electronic document available from the IM stored by the Agency providing additional information.</para>
    ///   <para>era:XMLName : RUL_LocalRulesOrRestrictionsDocRef^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/localRulesOrRestrictionsDoc">era:localRulesOrRestrictionsDoc</a>
    /// </summary>
    let localRulesOrRestrictionsDoc = _prefixId.prefix "localRulesOrRestrictionsDoc"
    /// <summary>
    ///   <para>rdfs:label : type of line referencing system</para>
    ///   <para>rdfs:comment : The preferred line referencing system.</para>
    ///   <para>skos:editorialNote : TODO: provide example^^xsd:string</para>
    ///   <para>dcterms:created : 2024-04-18^^xsd:date</para>
    ///   <para>dcterms:modified : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/lrsMethod">era:lrsMethod</a>
    /// </summary>
    let lrsMethod = _prefixId.prefix "lrsMethod"
    /// <summary>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.16.9^^xsd:stringera:rinfIndex : 1.1.1.3.2.16.9^^xsd:string</para>
    ///   <para>skos:scopeNote : See: TSI CCS (Subset-026, chapter 7. 7.5.1.74 M_NVCONTACT)</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>dcterms:created : 2022-11-07^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.5.9^^xsd:string</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>rdfs:label : M_NVCONTACT</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:comment : On-Board system reaction when T_NVCONTACT expires
    /// According to the specification referenced in Appendix A-1, index [C]</para>
    ///   <a href="http://data.europa.eu/949/mNvcontact">era:mNvcontact</a>
    /// </summary>
    let mNvcontact = _prefixId.prefix "mNvcontact"
    /// <summary>
    ///   <para>skos:scopeNote : See: TSI CCS (Subset 26, chapter 7. 7.5.1.75 M_NVDERUN)</para>
    ///   <para>rdfs:label : M_NVDERUN</para>
    ///   <para>dcterms:modified : 2023-04-18^^xsd:datedcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.16.10^^xsd:stringera:rinfIndex : 1.2.1.1.1.16.10^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:comment : Entry of Driver ID permitted while running According to the specification referenced in Appendix A-1, index [C]</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.5.10^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>dcterms:created : 2022-11-07^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <a href="http://data.europa.eu/949/mNvderun">era:mNvderun</a>
    /// </summary>
    let mNvderun = _prefixId.prefix "mNvderun"
    /// <summary>
    ///   <para>rdfs:comment : Possibility of preventing the use of the magnetic track brake (only if fitted with magnetic brake)</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Magnetic brake prevention</para>
    ///   <para>era:eratvIndex : 4.7.4.2.2^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-04-13^^xsd:date</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/magneticBrakePrevention">era:magneticBrakePrevention</a>
    /// </summary>
    let magneticBrakePrevention = _prefixId.prefix "magneticBrakePrevention"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.0.4.3^^xsd:stringera:rinfIndex : 1.1.1.1.6.3^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2022-09-12^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>rdfs:label : Use of magnetic brakes</para>
    ///   <para>era:XMLName : ILR_MagneticBrakes^^xsd:string</para>
    ///   <para>skos:changeNote : This property has been modified to be a RINF parameter (its eratvIndex is deleted). It is treated as a SKOS by RINF and as a boolean by ERATV. A new ERATV datatype property has been defined, magneticBrakingFitted with boolean values.</para>
    ///   <para>rdfs:seeAlso : INF TSI: 4.2.6.2.2
    ///                     OPE TSI: 4.2.2.6.2 (1) (iv)^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latestera:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of limitations on the use of magnetic brakes.</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.6^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/magneticBraking">era:magneticBraking</a>
    /// </summary>
    let magneticBraking = _prefixId.prefix "magneticBraking"

    /// <summary>
    ///   <para>era:dependencyNote : Mandatory value to be provided when 1.1.1.1.6.3 / Use of magnetic brakes is 'allowed under conditions' or 'allowed under conditions only for emergency brake'.</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.6.5^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:changeNote : Change from datatype property to object property in order to point to the class Document (reference document)</para>
    ///   <para>skos:scopeNote : If there exist conditions to allow the use of magnetic brakes.
    ///
    /// The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <para>era:XMLName : ILR_MBDocRef^^xsd:string</para>
    ///   <para>rdfs:comment : Electronic document available in two EU languages from the IM stored by the Agency with conditions for the use of magnetic brakes identified in 1.1.1.1.6.3.</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:label : Document with the conditions for the use of magnetic brakes</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-04-23^^xsd:datedcterms:modified : 2021-09-11^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.6^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/magneticBrakingConditionsDocument">era:magneticBrakingConditionsDocument</a>
    /// </summary>
    let magneticBrakingConditionsDocument = _prefixId.prefix "magneticBrakingConditionsDocument"

    /// <summary>
    ///   <para>dcterms:created : 2022-09-12^^xsd:date</para>
    ///   <para>rdfs:label : Magnetic braking fitted</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Magnetic track brake fitted. New property defined to distinguish it from magneticBraking which is a RINF SKOS property.</para>
    ///   <para>era:eratvIndex : 4.7.4.2.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/magneticBrakingFitted">era:magneticBrakingFitted</a>
    /// </summary>
    let magneticBrakingFitted = _prefixId.prefix "magneticBrakingFitted"
    /// <summary>
    ///   <para>rdfs:comment : Vehicle manufacturer company.</para>
    ///   <para>rdfs:label : manufactured by</para>
    ///   <para>dcterms:modified : 2020-11-19^^xsd:datedcterms:modified : 2024-06-03^^xsd:datedcterms:modified : 2024-10-24^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/manufacturer">era:manufacturer</a>
    /// </summary>
    let manufacturer = _prefixId.prefix "manufacturer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the country in which a vehicle or vehicle type is manufactured.</para>
    ///   <para>dcterms:created : 2020-09-30^^xsd:date</para>
    ///   <para>rdfs:label : Manufacturing country</para>
    ///   <para>dcterms:modified : 2020-11-22^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/manufacturingCountry">era:manufacturingCountry</a>
    /// </summary>
    let manufacturingCountry = _prefixId.prefix "manufacturingCountry"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-26^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.5.6^^xsd:string</para>
    ///   <para>rdfs:comment : Mass per wheel, given in kg.</para>
    ///   <para>rdfs:label : Mass per wheel</para>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/massPerWheel">era:massPerWheel</a>
    /// </summary>
    let massPerWheel = _prefixId.prefix "massPerWheel"
    /// <summary>
    ///   <para>rdfs:comment : Maximum permitted axle load, given in tons.</para>
    ///   <para>rdfs:seeAlso : UIC leaflet 700-0</para>
    ///   <para>rdfs:label : Maximum Axle load</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:created : 2025-09-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/maxAxleLoadOfSoL">era:maxAxleLoadOfSoL</a>
    /// </summary>
    let maxAxleLoadOfSoL = _prefixId.prefix "maxAxleLoadOfSoL"

    /// <summary>
    ///   <para>rdfs:label : Maximum current at standstill per pantograph</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest for DC systems
    /// 30 June 2024 for AC systems</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:seeAlso : ENE TSI: 4.2.5, LOC&amp;PAS TSI: 4.2.8.2.5^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:dependencyNote : This parameter is applicable only the type of contact line system is 'Overhead contact line (OCL)'
    /// In sidings, it may be not applicable, in the following cases:
    /// - siding is not electrified
    /// - Siding is destined to freight traffic, whose trains have a low consumption in stationary (the maximum demand of energy is due to air conditioning systems, which is not significant in these trains).
    /// - Siding is used in access to depots or workshops.</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-05-16^^xsd:datedcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2024-09-25^^xsd:date</para>
    ///   <para>era:formatNote : NNN^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of the maximum allowable train current at standstill expressed in amperes.</para>
    ///   <para>era:rinfIndex : 1.1.1.2.2.3^^xsd:stringera:rinfIndex : 1.2.2.0.6.1^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.10.4^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.3.8^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : ECS_MaxStandstillCurrent^^xsd:string</para>
    ///   <para>skos:scopeNote : Parameter related to current taken by the vehicle when it is not in a traction or regenerative mode, e.g. preheating, air-condition, etc.
    /// Due to operational reasons, trains can get stuck on SoL for hours, and in some cases, this parameter is even the reason the air-condition is shut down</para>
    ///   <a href="http://data.europa.eu/949/maxCurrentStandstillPantograph">era:maxCurrentStandstillPantograph</a>
    /// </summary>
    let maxCurrentStandstillPantograph = _prefixId.prefix "maxCurrentStandstillPantograph"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter. Indication of maximum permitted distance between two consecutive axles in case of TSI non-compliance, given in millimetres.</para>
    ///   <para>rdfs:label : Maximum permitted distance between two consecutive axles in case of TSI non-compliance</para>
    ///   <para>era:eratvIndex : 4.14.2.1^^xsd:string</para>
    ///   <para>era:XMLName : CTD_MaxDistConsecutiveAxles^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/maxDistConsecutiveAxles">era:maxDistConsecutiveAxles</a>
    /// </summary>
    let maxDistConsecutiveAxles = _prefixId.prefix "maxDistConsecutiveAxles"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.5^^xsd:string</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication of maximum distance between end of train and first axle, given in millimetres, applicable for both sides (front and rear) of a vehicle or train.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>era:XMLName : CTD_MaxDistEndTrainFirstAxle^^xsd:string</para>
    ///   <para>rdfs:label : Maximum distance between end of train and first axle</para>
    ///   <a href="http://data.europa.eu/949/maxDistEndTrainFirstAxle">era:maxDistEndTrainFirstAxle</a>
    /// </summary>
    let maxDistEndTrainFirstAxle = _prefixId.prefix "maxDistEndTrainFirstAxle"
    /// <summary>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter. Maximum permitted flange height, given in millimetres.</para>
    ///   <para>era:eratvIndex : 4.14.2.9^^xsd:string</para>
    ///   <para>era:XMLName : CTD_MaxFlangeHeight^^xsd:string</para>
    ///   <para>rdfs:label : Maximum permitted height of the flange</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/maxFlangeHeight">era:maxFlangeHeight</a>
    /// </summary>
    let maxFlangeHeight = _prefixId.prefix "maxFlangeHeight"
    /// <summary>
    ///   <para>era:XMLName : CTD_MaxImpedanceWheelset^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>era:eratvIndex : 4.14.2.16^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>rdfs:label : Maximum permitted impedance between opposite wheels of a wheelset when not TSI compliant</para>
    ///   <para>rdfs:comment : The value of maximum permitted impedance given in ohm in case of TSI non-compliance. Deprecated according to the amendment to the Regulation (EU) 2019/777.</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.15.2^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/maxImpedanceWheelset">era:maxImpedanceWheelset</a>
    /// </summary>
    let maxImpedanceWheelset = _prefixId.prefix "maxImpedanceWheelset"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.14.2.4^^xsd:string</para>
    ///   <para>dcterms:created : 2021-09-01^^xsd:date</para>
    ///   <para>rdfs:label : Maximum length vehicle nose</para>
    ///   <para>dcterms:modified : 2021-09-01^^xsd:date</para>
    ///   <para>rdfs:comment : Maximum length of the vehicle nose.</para>
    ///   <a href="http://data.europa.eu/949/maxLengthVehicleNose">era:maxLengthVehicleNose</a>
    /// </summary>
    let maxLengthVehicleNose = _prefixId.prefix "maxLengthVehicleNose"
    /// <summary>
    ///   <para>rdfs:comment : Maximum allowed noise level in decibels (dB).</para>
    ///   <para>dcterms:created : 2025-09-29^^xsd:date</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>era:dependencyNote : A value of `true`should be previously set for the property era:hasNoiseLevelLimit to be able to provide value for this property</para>
    ///   <para>rdfs:label : Maximum noise level</para>
    ///   <a href="http://data.europa.eu/949/maxNoiseLevelOfSoL">era:maxNoiseLevelOfSoL</a>
    /// </summary>
    let maxNoiseLevelOfSoL = _prefixId.prefix "maxNoiseLevelOfSoL"
    /// <summary>
    ///   <para>dcterms:created : 2025-11-25^^xsd:date</para>
    ///   <para>era:dependencyNote : Applicable only to sections of lines belonging to TEN-T corridors.
    ///                             It applies to sections of lines where tracks have a TEN classification (1.1.1.1.2.1) that is neither 'off-TEN' nor not applicable ('N')</para>
    ///   <para>rdfs:comment : Maximum train length in meters allowed on a section of line, without special permission, for the operation of freight trains.
    ///                             In accordance with Regulation (EU) 2024/1679, Article 15(2)(c), this maximum length must be supported by the infrastructure manager's ability
    ///                             to allocate sufficient train paths for freight trains of at least 740 meters (including the locomotive or locomotives), as required for the TEN-T network.</para>
    ///   <para>skos:scopeNote : The specific allocation requirements for single and double-track lines are as follows:
    ///                             - Double-track lines: At least one train path every 2 hours per direction on average daily.
    ///                             - Single-track lines: At least one train path every 3 hours per direction, with a minimum of 12 daily train paths allocated.
    ///                             These allocation conditions must be met if requested by a railway undertaking, as specified in Regulation (EU) 2024/1679, Article 16(2)(b)(i)-(ii).</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:label : Maximum train length allowed</para>
    ///   <a href="http://data.europa.eu/949/maxPermittedTrainLength">era:maxPermittedTrainLength</a>
    /// </summary>
    let maxPermittedTrainLength = _prefixId.prefix "maxPermittedTrainLength"
    /// <summary>
    ///   <para>rdfs:comment : Maximum amount of sand accepted on the track within value of sanding output for 30s, given in grams.
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777.</para>
    ///   <para>era:XMLName : CTD_MaxSandOutput^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.17^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Maximum amount of sand</para>
    ///   <a href="http://data.europa.eu/949/maxSandingOutput">era:maxSandingOutput</a>
    /// </summary>
    let maxSandingOutput = _prefixId.prefix "maxSandingOutput"
    /// <summary>
    ///   <para>rdfs:label : Maximum train current</para>
    ///   <para>dcterms:modified : 2024-09-25^^xsd:datedcterms:modified : 2021-08-06^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-05-16^^xsd:date</para>
    ///   <para>skos:scopeNote : For RINF XML data sets:
    /// As long as the data provision through XML data sets is allowed, an XML attribute called "Set" will be used to link the value of this parameter to the parameter 1.1.1.2.2.1.1 / ECS_SystemType</para>
    ///   <para>era:XMLName : ECS_MaxTrainCurrent^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of the maximum allowable train current expressed in amperes.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.3.2^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.2.2.2^^xsd:string</para>
    ///   <para>era:dependencyNote : When `not electrified` is chosen in parameter 1.1.1.2.2.1.1, then this parameter is not applicable.</para>
    ///   <para>dcterms:created : 2021-08-06^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/maxTrainCurrent">era:maxTrainCurrent</a>
    /// </summary>
    let maxTrainCurrent = _prefixId.prefix "maxTrainCurrent"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicate the speed limit in a tunnel</para>
    ///   <para>rdfs:label : Tunnel speed limit</para>
    ///   <a href="http://data.europa.eu/949/maxTunnelSpeed">era:maxTunnelSpeed</a>
    /// </summary>
    let maxTunnelSpeed = _prefixId.prefix "maxTunnelSpeed"
    /// <summary>
    ///   <para>rdfs:label : Maximun bridge wind</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:created : 2025-09-30^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates the maximun wind speed for which the bridge can operate</para>
    ///   <a href="http://data.europa.eu/949/maxbridgeWind">era:maxbridgeWind</a>
    /// </summary>
    let maxbridgeWind = _prefixId.prefix "maxbridgeWind"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2022-10-20^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Highest point of the section of line above sea level in reference to Normal Amsterdam's Peil (NAP).</para>
    ///   <para>skos:scopeNote : Normaal Amsterdams Peil (NAP), called also Amsterdam Ordnance Datum, it is a vertical datum commonly in use in Europe as reference level for the description of the height of objects in relation to the sea level.
    ///
    /// The value of the parameter shall be given in metres, with tolerance of +/-100m.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:rinfIndex : 1.1.1.1.2.7^^xsd:string</para>
    ///   <para>rdfs:label : Maximum altitude</para>
    ///   <para>era:XMLName : IPP_MaxAltitude^^xsd:string</para>
    ///   <para>era:formatNote : [+/-][NNNN]^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/maximumAltitude">era:maximumAltitude</a>
    /// </summary>
    let maximumAltitude = _prefixId.prefix "maximumAltitude"
    /// <summary>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:datedcterms:modified : 2024-06-26^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-26^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Maximum average deceleration</para>
    ///   <para>rdfs:comment : Maximum train deceleration given in m/s².</para>
    ///   <para>era:eratvIndex : 4.7.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/maximumAverageDeceleration">era:maximumAverageDeceleration</a>
    /// </summary>
    let maximumAverageDeceleration = _prefixId.prefix "maximumAverageDeceleration"

    /// <summary>
    ///   <para>rdfs:comment : Maximum brake thermal energy capacity given in kJ</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-06-26^^xsd:datedcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-26^^xsd:date</para>
    ///   <para>rdfs:label : Maximum brake thermal energy capacity</para>
    ///   <para>era:eratvIndex : 4.7.2.1.6^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/maximumBrakeThermalEnergyCapacity">era:maximumBrakeThermalEnergyCapacity</a>
    /// </summary>
    let maximumBrakeThermalEnergyCapacity = _prefixId.prefix "maximumBrakeThermalEnergyCapacity"

    /// <summary>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2024-06-26^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>rdfs:label : Maximum braking distance requested</para>
    ///   <para>era:formatNote : NNNNN^^xsd:string</para>
    ///   <para>rdfs:comment : The maximum value of the braking distance [in metres] of a train shall be given for the maximum line speed.</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : This distance corresponds to the smallest physical distance between signals of the section of line at V max, taking into account the effect of gradient, minus the value of the safety margin used by the IM.
    ///
    /// The braking capability of a train allows it to respect this braking distance.
    ///
    /// Note that the OPE TSI provides for an exchange of detailed information between the infrastructure manager and the railway undertaking to ensure safe operation.
    ///
    /// See also:
    /// - OPE TSI: 4.2.2.6
    /// - CCS TSI: 4.2.2</para>
    ///   <para>era:XMLName : CBP_MaxBrakeDist^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:rinfIndex : 1.1.1.3.11.1^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/maximumBrakingDistance">era:maximumBrakingDistance</a>
    /// </summary>
    let maximumBrakingDistance = _prefixId.prefix "maximumBrakingDistance"
    /// <summary>
    ///   <para>rdfs:label : Maximum contact wire height</para>
    ///   <para>era:formatNote : N.NN^^xsd:string</para>
    ///   <para>era:dependencyNote : Mandatory only if “Overhead contact line (OCL)” is selected in 1.1.1.2.2.1.1, otherwise the parameter is not applicable.</para>
    ///   <para>era:XMLName : ECS_MaxWireHeight^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2021-09-11^^xsd:datedcterms:modified : 2024-09-25^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.10.5^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of the maximum contact wire height expressed in metres.</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>skos:scopeNote : The value given can be design value or the last known measured value. If there is no change in height, nominal value will be given.
    ///
    /// Values shall be given in metres with precision of 0.01 m.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:rinfIndex : 1.1.1.2.2.5^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/maximumContactWireHeight">era:maximumContactWireHeight</a>
    /// </summary>
    let maximumContactWireHeight = _prefixId.prefix "maximumContactWireHeight"
    /// <summary>
    ///   <para>rdfs:comment : Maximum design speed.</para>
    ///   <para>dcterms:modified : 2024-06-26^^xsd:datedcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Maximum design speed</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.1.2.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/maximumDesignSpeed">era:maximumDesignSpeed</a>
    /// </summary>
    let maximumDesignSpeed = _prefixId.prefix "maximumDesignSpeed"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-09/index077_-_ERA_ERTMS_033281_v5.pdf^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Maximum interference current limits allowed for track circuits for a defined frequency band.</para>
    ///   <para>era:rinfIndex : 1.1.1.3.4.2.1^^xsd:stringera:rinfIndex : 1.2.1.1.3.2.1^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:label : Maximum interference current</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:legalDeadline : For train detection system compliant with TSIs: 12 months after publication of Article 7 Guide.
    /// For train detection system not TSI compliant: in relation to article 13 of TSI CCS</para>
    ///   <para>era:XMLName : CCD_MaxInterfCurrent^^xsd:string</para>
    ///   <para>skos:scopeNote : To be expressed in A/m. Verification of compliance with TSI includes application of notified national rules (when they exist).
    ///
    /// Evaluation parameters must be added if preferred bands are not used. </para>
    ///   <para>era:dependencyNote : Evaluation parameters must be added if preferred bands are not used.</para>
    ///   <para>era:formatNote : NNN. An optional value could be filled in era:maximumInterferenceCurrentEvaluation^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/maximumInterferenceCurrent">era:maximumInterferenceCurrent</a>
    /// </summary>
    let maximumInterferenceCurrent = _prefixId.prefix "maximumInterferenceCurrent"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-09/index077_-_ERA_ERTMS_033281_v5.pdf^^xsd:anyURI</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guideera:legalDeadline : For train detection system compliant with TSIs: 12 months after publication of Article 7 Guide.
    /// For train detection system not TSI compliant: in relation to article 13 of TSI CCS</para>
    ///   <para>dcterms:created : 2024-04-18^^xsd:date</para>
    ///   <para>era:dependencyNote : If the preferred frequency bands are not used, (mandatory) description of the parameters for evaluation of compliance.
    /// If the preferred frequency bands are used, this parameter is optional.</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:rinfIndex : 1.2.1.1.3.2.1^^xsd:stringera:rinfIndex : 1.1.1.3.4.2.1^^xsd:string</para>
    ///   <para>rdfs:comment : Maximum interference current limits allowed for track circuits for a defined frequency band. </para>
    ///   <para>rdfs:label : Evaluation parameters if maximum interference current is not measured in the preferred bands</para>
    ///   <a href="http://data.europa.eu/949/maximumInterferenceCurrentEvaluation">era:maximumInterferenceCurrentEvaluation</a>
    /// </summary>
    let maximumInterferenceCurrentEvaluation = _prefixId.prefix "maximumInterferenceCurrentEvaluation"

    /// <summary>
    ///   <para>rdfs:comment : Maximum number of trainsets or locomotives coupled together in multiple operation.</para>
    ///   <para>era:eratvIndex : 4.1.5^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-25^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Maximum locomotives coupled</para>
    ///   <para>dcterms:modified : 2021-08-25^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/maximumLocomotivesCoupled">era:maximumLocomotivesCoupled</a>
    /// </summary>
    let maximumLocomotivesCoupled = _prefixId.prefix "maximumLocomotivesCoupled"

    /// <summary>
    ///   <para>skos:scopeNote : The maximumMagneticFieldDirectionX parameter is only applicable for axle counters.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:comment : The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band. Direction X.</para>
    ///   <para>rdfs:label : Maximum magnetic field direction X</para>
    ///   <a href="http://data.europa.eu/949/maximumMagneticFieldDirectionX">era:maximumMagneticFieldDirectionX</a>
    /// </summary>
    let maximumMagneticFieldDirectionX = _prefixId.prefix "maximumMagneticFieldDirectionX"

    /// <summary>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Maximum magnetic field direction Y</para>
    ///   <para>skos:scopeNote : The maximumMagneticFieldDirectionY parameter is only applicable for axle counters.</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>rdfs:comment : The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band. Direction Y.</para>
    ///   <a href="http://data.europa.eu/949/maximumMagneticFieldDirectionY">era:maximumMagneticFieldDirectionY</a>
    /// </summary>
    let maximumMagneticFieldDirectionY = _prefixId.prefix "maximumMagneticFieldDirectionY"

    /// <summary>
    ///   <para>rdfs:comment : The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band. Direction Z.</para>
    ///   <para>skos:scopeNote : The maximumMagneticFieldDirectionZ parameter is applicable for axle counters.</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>rdfs:label : Maximum magnetic field direction Z</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/maximumMagneticFieldDirectionZ">era:maximumMagneticFieldDirectionZ</a>
    /// </summary>
    let maximumMagneticFieldDirectionZ = _prefixId.prefix "maximumMagneticFieldDirectionZ"

    /// <summary>
    ///   <para>rdfs:comment : Maximum permitted meter load, given in tons</para>
    ///   <para>rdfs:label : Maximum permitted meter load</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:created : 2026-09-29^^xsd:date</para>
    ///   <para>rdfs:seeAlso : See: UIC leaflet 700-0</para>
    ///   <a href="http://data.europa.eu/949/maximumPermittedMeterLoad">era:maximumPermittedMeterLoad</a>
    /// </summary>
    let maximumPermittedMeterLoad = _prefixId.prefix "maximumPermittedMeterLoad"
    /// <summary>
    ///   <para>dcterms:modified : 2025-02-26^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>skos:example : In case INF, ENE and/or CCS allow different speeds, the max permitted speed on this track of this section of line shall be the lowest one.
    /// In case the maximum permitted speed for freight and passenger trains operation are different, the max permitted speed on this track of this section of line shall be the highest one.^^xsd:string</para>
    ///   <para>rdfs:seeAlso : INF TSI, ENE TSI, CCS TSI^^xsd:string</para>
    ///   <para>era:XMLName : IPP_MaxSpeed^^xsd:string</para>
    ///   <para>rdfs:label : Maximum permitted speed</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>skos:scopeNote : "Speed on the line" shall be understood as speed on the track of the section of line in question. </para>
    ///   <para>era:rinfIndex : 1.1.1.1.2.5^^xsd:string</para>
    ///   <para>rdfs:comment : Nominal maximum operational speed on the line as a result of infrastructure, energy and control, command signalling subsystem characteristics expressed in kilometres/hour.</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.1.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/maximumPermittedSpeed">era:maximumPermittedSpeed</a>
    /// </summary>
    let maximumPermittedSpeed = _prefixId.prefix "maximumPermittedSpeed"
    /// <summary>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.7.7^^xsd:string</para>
    ///   <para>rdfs:label : Maximum service break</para>
    ///   <para>rdfs:comment : At maximum service brake: Stopping distance, Maximum deceleration, for the load condition 'design mass under normal payload' at the design maximum speed.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-26^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/maximumServiceBrake">era:maximumServiceBrake</a>
    /// </summary>
    let maximumServiceBrake = _prefixId.prefix "maximumServiceBrake"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>era:eratvIndex : 4.6.4^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:label : Maximum speed and cant deficiency</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Combination of maximum speed and maximum cant deficiency for which the vehicle was assessed.
    ///
    /// This property was before an object skos property. The values for this property do not come from a list of predefined values. Thus, the original object property was replaced by this datatype property with range xsd:string.
    /// Deprecated because of replacement by a class and two integer properties. The reason is that the property represents two concepts: [number] km/h for maximum speed - [number] mm for maximum cant deficiency.</para>
    ///   <para>dcterms:modified : 2023-04-05^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/maximumSpeedAndCantDeficiency">era:maximumSpeedAndCantDeficiency</a>
    /// </summary>
    let maximumSpeedAndCantDeficiency = _prefixId.prefix "maximumSpeedAndCantDeficiency"
    /// <summary>
    ///   <para>era:eratvIndex : 4.1.2.2^^xsd:string</para>
    ///   <para>rdfs:label : Maximum speed empty</para>
    ///   <para>rdfs:comment : Maximum speed when empty.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-24^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/maximumSpeedEmpty">era:maximumSpeedEmpty</a>
    /// </summary>
    let maximumSpeedEmpty = _prefixId.prefix "maximumSpeedEmpty"
    /// <summary>
    ///   <para>era:XMLName : IPP_TempRange^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>era:rinfIndex : 1.1.1.1.2.6^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2024-09-25^^xsd:datedcterms:modified : 2021-09-10^^xsd:date</para>
    ///   <para>rdfs:label : Temperature range (maximum)</para>
    ///   <para>rdfs:comment : Deprecated because both RINF and ERATV define a temperature range as a set of predefined values (see https://www.era.europa.eu/system/files/2023-04/iu-eratv_application_guide_for_register_2016-797_en_0.pdf). Maximum temperature allowed for unrestricted operation access, according to European standard.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.3.1^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/maximumTemperature">era:maximumTemperature</a>
    /// </summary>
    let maximumTemperature = _prefixId.prefix "maximumTemperature"
    /// <summary>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>skos:scopeNote : New lines are assumed to be compliant with the TSI INF.
    /// For TSI compliant lines the default value of 2.5 m/s2 shall be presented.
    ///
    /// If for the design of the track the braking forces were assumed on basis of the deceleration lower value than 2.5 m/s2, the applied value of the deceleration has to be specified.</para>
    ///   <para>rdfs:seeAlso : INF TSI: 4.2.6^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>rdfs:comment : Limit for longitudinal track resistance given as a maximum allowed train deceleration and expressed in metres per square second.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2021-09-10^^xsd:date</para>
    ///   <para>era:formatNote : N.N^^xsd:string</para>
    ///   <para>era:dependencyNote : Not applicable if line is not in scope of INF TSI</para>
    ///   <para>rdfs:label : Maximum train deceleration</para>
    ///   <para>era:rinfIndex : 1.1.1.1.6.1^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : ILR_MaxDeceleration^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/maximumTrainDeceleration">era:maximumTrainDeceleration</a>
    /// </summary>
    let maximumTrainDeceleration = _prefixId.prefix "maximumTrainDeceleration"
    /// <summary>
    ///   <para>rdfs:comment : Maximum train length allowed on a line or section</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Maximum Train Length</para>
    ///   <para>dcterms:created : 2025-09-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/maximumTrainLength">era:maximumTrainLength</a>
    /// </summary>
    let maximumTrainLength = _prefixId.prefix "maximumTrainLength"
    /// <summary>
    ///   <para>rdfs:label : measured distance</para>
    ///   <para>rdfs:comment : Measured distance from the origin of the LRS.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/measuredDistance">era:measuredDistance</a>
    /// </summary>
    let measuredDistance = _prefixId.prefix "measuredDistance"

    /// <summary>
    ///   <para>rdfs:label : Meets requirement vehicle authorisation</para>
    ///   <para>era:eratvIndex : 4.1.8^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Type meets the requirements necessary for validity of the vehicle authorisation granted by one Member State in other MSs.</para>
    ///   <para>dcterms:modified : 2021-08-25^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-25^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/meetsRequirementVehicleAuthorisation">era:meetsRequirementVehicleAuthorisation</a>
    /// </summary>
    let meetsRequirementVehicleAuthorisation = _prefixId.prefix "meetsRequirementVehicleAuthorisation"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Minimum permitted axle load</para>
    ///   <para>rdfs:comment : Minimum permitted axle load, given in tons.</para>
    ///   <para>era:eratvIndex : 4.14.2.10^^xsd:string</para>
    ///   <para>skos:scopeNote : Should be deprecated according to the amendment to the Regulation (EU) 2019/777 but remains because it is also a parameter of ERATV.</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/minAxleLoad">era:minAxleLoad</a>
    /// </summary>
    let minAxleLoad = _prefixId.prefix "minAxleLoad"
    /// <summary>
    ///   <para>rdfs:comment : Represents the category of vehicle which is amended by value of minimum permitted axle load [tons] (property minAxleLoad).
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777.</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>era:XMLName : CTD_MinAxleLoadByVehicleCat^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.11.1^^xsd:string</para>
    ///   <para>rdfs:label : Minimum axle load vehicle category</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/minAxleLoadVehicleCategory">era:minAxleLoadVehicleCategory</a>
    /// </summary>
    let minAxleLoadVehicleCategory = _prefixId.prefix "minAxleLoadVehicleCategory"
    /// <summary>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.</para>
    ///   <para>era:eratvIndex : 4.14.2.2^^xsd:string</para>
    ///   <para>rdfs:label : Minimum permitted distance between two consecutive axles</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : Indication of minimum permitted distance between two consecutive axles, given in millimetres.</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/minDistConsecutiveAxles">era:minDistConsecutiveAxles</a>
    /// </summary>
    let minDistConsecutiveAxles = _prefixId.prefix "minDistConsecutiveAxles"
    /// <summary>
    ///   <para>rdfs:label : Minimum permitted distance between first and last axle</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.</para>
    ///   <para>era:eratvIndex : 4.14.2.3^^xsd:string</para>
    ///   <para>skos:scopeNote : Indication of minimum permitted distance between first and last axles, given in millimetres.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/minDistFirstLastAxle">era:minDistFirstLastAxle</a>
    /// </summary>
    let minDistFirstLastAxle = _prefixId.prefix "minDistFirstLastAxle"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : Minimum permitted flange height, given in millimetres.</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-09-01^^xsd:date</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.</para>
    ///   <para>rdfs:label : Minimum permitted height of the flange</para>
    ///   <para>era:eratvIndex : 4.14.2.8^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/minFlangeHeight">era:minFlangeHeight</a>
    /// </summary>
    let minFlangeHeight = _prefixId.prefix "minFlangeHeight"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.14.2.7^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-09-01^^xsd:date</para>
    ///   <para>skos:scopeNote : Minimum permitted flange thickness, given in millimetres.</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.</para>
    ///   <para>rdfs:label : Minimum permitted thickness of the flange</para>
    ///   <a href="http://data.europa.eu/949/minFlangeThickness">era:minFlangeThickness</a>
    /// </summary>
    let minFlangeThickness = _prefixId.prefix "minFlangeThickness"
    /// <summary>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.14.2.5^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:label : Minimum permitted width of the rim</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/minRimWidth">era:minRimWidth</a>
    /// </summary>
    let minRimWidth = _prefixId.prefix "minRimWidth"
    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.3.4.2.2^^xsd:stringera:rinfIndex : 1.2.1.1.3.2.2^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : For train detection system compliant with TSIs, 12 months after publication of Article 7 Guide.
    /// For train detection system not TSI compliant: in relation to article 13 of TSI CCS</para>
    ///   <para>rdfs:seeAlso : https://eur-lex.europa.eu/eli/reg_impl/2023/1695/oj^^xsd:anyURI</para>
    ///   <para>era:XMLName : CCD_VehicleImpedance^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>era:dependencyNote : Mandatory only for track circuits^^xsd:string</para>
    ///   <para>era:formatNote : The values is an instance of era:MinVehicleImpedance class with its 2 properties.	Per voltage : input Capacitance (Cin) and Input Impedance (Zin)</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>skos:scopeNote : Compatibility with track circuits. A track circuit is only able to detect rolling stock if the impedance between rails does not exceed a certain value.</para>
    ///   <para>rdfs:label : Vehicle impedance</para>
    ///   <para>rdfs:comment : Impedance as defined in the specification referenced in Appendix A-1, index [D]</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/minVehicleImpedance">era:minVehicleImpedance</a>
    /// </summary>
    let minVehicleImpedance = _prefixId.prefix "minVehicleImpedance"
    /// <summary>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : minimum Vehicle Impedance (Voltage applicable)</para>
    ///   <para>dcterms:created : 2024-05-30^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/minVehicleImpedanceVoltages">era:minVehicleImpedanceVoltages</a>
    /// </summary>
    let minVehicleImpedanceVoltages = _prefixId.prefix "minVehicleImpedanceVoltages"
    /// <summary>
    ///   <para>dcterms:created : 2024-05-30^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : minimal vehicle input capacitance</para>
    ///   <para>era:formatNote : For the selected DC voltage: [CCCC], as input capacitance [CCCC](Cin)</para>
    ///   <a href="http://data.europa.eu/949/minVehicleInputCapacitance">era:minVehicleInputCapacitance</a>
    /// </summary>
    let minVehicleInputCapacitance = _prefixId.prefix "minVehicleInputCapacitance"
    /// <summary>
    ///   <para>rdfs:label : minimal vehicle input impedance</para>
    ///   <para>era:formatNote : For the selected DC voltage: [ZZZZ], as input impedance [ZZZZ](Zin)</para>
    ///   <para>dcterms:created : 2024-05-30^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/minVehicleInputImpedance">era:minVehicleInputImpedance</a>
    /// </summary>
    let minVehicleInputImpedance = _prefixId.prefix "minVehicleInputImpedance"
    /// <summary>
    ///   <para>era:eratvIndex : 4.14.2.6^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Minimum permitted wheel diameter</para>
    ///   <para>skos:scopeNote : Minimum permitted wheel diameter, given in millimetres.</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/minWheelDiameter">era:minWheelDiameter</a>
    /// </summary>
    let minWheelDiameter = _prefixId.prefix "minWheelDiameter"
    /// <summary>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>rdfs:comment : Minimum vertical concave curve radius capability.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.8.6^^xsd:string</para>
    ///   <para>rdfs:label : Minimum concave vertical radius</para>
    ///   <a href="http://data.europa.eu/949/minimumConcaveVerticalRadius">era:minimumConcaveVerticalRadius</a>
    /// </summary>
    let minimumConcaveVerticalRadius = _prefixId.prefix "minimumConcaveVerticalRadius"
    /// <summary>
    ///   <para>dcterms:modified : 2021-09-11^^xsd:datedcterms:modified : 2024-09-25^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.10.5^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.2.2.6^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <para>rdfs:label : Minimum contact wire height</para>
    ///   <para>rdfs:comment : Indication of the minimum contact wire height expressed in metres.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>skos:scopeNote : The value given can be design value or the last known measured value. If there is no change in height, nominal value will be given.
    ///
    /// Values shall be given in metres with precision of 0.01 m.</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:XMLName : ECS_MinWireHeight^^xsd:string</para>
    ///   <para>era:dependencyNote : When `not electrified` is chosen in parameter 1.1.1.2.2.1.1, then this parameter is not applicable.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/minimumContactWireHeight">era:minimumContactWireHeight</a>
    /// </summary>
    let minimumContactWireHeight = _prefixId.prefix "minimumContactWireHeight"
    /// <summary>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:label : Minimum convex vertical radius</para>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.8.5^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Minimum vertical convex curve radius capability.</para>
    ///   <a href="http://data.europa.eu/949/minimumConvexVerticalRadius">era:minimumConvexVerticalRadius</a>
    /// </summary>
    let minimumConvexVerticalRadius = _prefixId.prefix "minimumConvexVerticalRadius"
    /// <summary>
    ///   <para>rdfs:comment : Radius of the smallest horizontal curve, expressed in metres.</para>
    ///   <para>era:formatNote : NNNNN^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:XMLName : ILL_MinRadHorzCurve^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-03-08^^xsd:datedcterms:modified : 2021-09-10^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.2.0.3.2^^xsd:stringera:rinfIndex : 1.1.1.1.3.7^^xsd:string</para>
    ///   <para>rdfs:seeAlso : INF TSI: 4.2.3.4
    /// EN 13803:2017, Tables N.A and N.2^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.8.4^^xsd:string</para>
    ///   <para>skos:scopeNote : To describe a straight section of line value " 99999" shall be used.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:label : Minimum radius of horizontal curve</para>
    ///   <a href="http://data.europa.eu/949/minimumHorizontalRadius">era:minimumHorizontalRadius</a>
    /// </summary>
    let minimumHorizontalRadius = _prefixId.prefix "minimumHorizontalRadius"
    /// <summary>
    ///   <para>rdfs:label : Temperature range (minimum)</para>
    ///   <para>rdfs:comment : Deprecated because both RINF and ERATV define a temperature range as a set of predefined values (see https://www.era.europa.eu/system/files/2023-04/iu-eratv_application_guide_for_register_2016-797_en_0.pdf). Minimum temperature allowed for unrestricted operation access, according to European standard.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>era:eratvIndex : 4.3.1^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-09-10^^xsd:datedcterms:modified : 2024-09-25^^xsd:date</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:XMLName : IPP_TempRange^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.2.6^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/minimumTemperature">era:minimumTemperature</a>
    /// </summary>
    let minimumTemperature = _prefixId.prefix "minimumTemperature"
    /// <summary>
    ///   <para>era:XMLName : ILL_MinRadVertCurve^^xsd:string</para>
    ///   <para>rdfs:comment : Radius of the smallest vertical curve expressed in metres.</para>
    ///   <para>skos:scopeNote : The radius of vertical curves (except for humps in marshalling yards) shall be at least 500 m on a crest or 900 m in a hollow.</para>
    ///   <para>era:formatNote : In RDF: the values points to an instance of era:MinimumVerticalRadius class with 2 properties for the crest and hollow values.
    ///                                                   In XML: NNN+NNN</para>
    ///   <para>dcterms:modified : 2024-12-12^^xsd:datedcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2023-04-05^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : INF TSI: 4.2.3.54^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.2.0.3.3^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>rdfs:label : Minimum radius of vertical curve</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <a href="http://data.europa.eu/949/minimumVerticalRadius">era:minimumVerticalRadius</a>
    /// </summary>
    let minimumVerticalRadius = _prefixId.prefix "minimumVerticalRadius"
    /// <summary>
    ///   <para>rdfs:label : Minimum radius of vertical curve crest</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:comment : Part of the minimum radius of vertical curve that indicates the crest</para>
    ///   <a href="http://data.europa.eu/949/minimumVerticalRadiusCrest">era:minimumVerticalRadiusCrest</a>
    /// </summary>
    let minimumVerticalRadiusCrest = _prefixId.prefix "minimumVerticalRadiusCrest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Part of the minimum radius of vertical curve that indicates the hollow</para>
    ///   <para>rdfs:label : Minimum radius of vertical curve hollow</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/minimumVerticalRadiusHollow">era:minimumVerticalRadiusHollow</a>
    /// </summary>
    let minimumVerticalRadiusHollow = _prefixId.prefix "minimumVerticalRadiusHollow"
    /// <summary>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2021-09-10^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>era:formatNote : NNN^^xsd:string</para>
    ///   <para>era:XMLName : ISC_MinWheelDiaFixObtuseCrossings^^xsd:string</para>
    ///   <para>rdfs:label : Minimum wheel diameter for fixed obtuse crossings</para>
    ///   <para>rdfs:seeAlso : INF TSI:  4.2.5.3^^xsd:string</para>
    ///   <para>skos:scopeNote : The minimum TSI value is 330 mm and this shall be used as a default value unless advised otherwise. If the value of the wheel diameter is bigger than 330 mm, it has to be specified.
    /// New lines are assumed to be compliant with the TSI INF. When the line is compliant to TSI the default value of 330 mm has to be presented.</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.8.2^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Maximum unguided length of fixed obtuse crossings is based on a minimum wheel diameter in service expressed in millimetres.</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.5.2^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <a href="http://data.europa.eu/949/minimumWheelDiameter">era:minimumWheelDiameter</a>
    /// </summary>
    let minimumWheelDiameter = _prefixId.prefix "minimumWheelDiameter"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication whether more than one train protection, control and warning system is required to be on-board and active simultaneously.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.5.2^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:label : Need for more than one train protection, control and warning system required on board</para>
    ///   <a href="http://data.europa.eu/949/multipleTrainProtectionRequired">era:multipleTrainProtectionRequired</a>
    /// </summary>
    let multipleTrainProtectionRequired = _prefixId.prefix "multipleTrainProtectionRequired"

    /// <summary>
    ///   <para>skos:scopeNote : Each SoL can belong to only one national line.
    ///
    /// In case when SoL is the track connecting between OPs within big node (resulting from division of big station into several smaller) the line can be identified using the name of this track.</para>
    ///   <para>rdfs:label : national line identification</para>
    ///   <para>dcterms:modified : 2024-11-18^^xsd:datedcterms:modified : 2024-11-29^^xsd:datedcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-10-24^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : SOLLineIdentification^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.0.0.0.2^^xsd:string</para>
    ///   <para>dcterms:created : 2024-05-24^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates a relationship with a national railway line at a specific kilometer point.
    /// For a Section of Line: unique line identification or unique line number within Member State.</para>
    ///   <a href="http://data.europa.eu/949/nationalLine">era:nationalLine</a>
    /// </summary>
    let nationalLine = _prefixId.prefix "nationalLine"
    /// <summary>
    ///   <para>skos:example : The French IM SNCF reseau is using the concept of 'groupe Demeaux' with the following definition is 'Groupe de classification de la voie tenant compte de la resistance de son armement en flexion verticale'.^^xsd:string</para>
    ///   <para>skos:scopeNote : Some Networks are using National classification for load capability (instead of parameter 1.1.1.1.2.4 Load capability that provide load capability in accordance with EN 15528)</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-09-10^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:XMLName : IPP_NCLoadCap^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.2.4.1^^xsd:string</para>
    ///   <para>rdfs:comment : National classification for load capability</para>
    ///   <para>rdfs:label : National classification for load capability</para>
    ///   <a href="http://data.europa.eu/949/nationalLoadCapability">era:nationalLoadCapability</a>
    /// </summary>
    let nationalLoadCapability = _prefixId.prefix "nationalLoadCapability"

    /// <summary>
    ///   <para>era:XMLName : ITU_NatFireCatReq^^xsd:string</para>
    ///   <para>rdfs:comment : Categorisation of how a passenger train with a fire on board will continue to operate for a defined time period - according to national rules if they exist.</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.8.11^^xsd:stringera:rinfIndex : 1.2.2.0.5.8^^xsd:stringera:rinfIndex : 1.2.1.0.5.8^^xsd:string</para>
    ///   <para>era:dependencyNote : Mandatory for tunnels without value for 1.1.1.8.10 and where national values exist.</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>skos:scopeNote : Data shall include both the category and brief name of the document introducing the categorisation.
    /// A value is mandatory only for tunnels when the value of the parameter 1.1.1.1.8.10 is  none  and national rules exist.
    /// It may be not applicable when respective national rules do not exist</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SRT TSI: 4.2.3.3.4
    ///                                      LOC&amp;PAS TSI : 4.2.10.4.4^^xsd:string</para>
    ///   <para>rdfs:label : National fire category of rolling stock required</para>
    ///   <a href="http://data.europa.eu/949/nationalRollingStockFireCategory">era:nationalRollingStockFireCategory</a>
    /// </summary>
    let nationalRollingStockFireCategory = _prefixId.prefix "nationalRollingStockFireCategory"

    /// <summary>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>rdfs:label : National Values used for the brake model</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.16.13^^xsd:stringera:rinfIndex : 1.2.1.1.1.16.13^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2024-12-05^^xsd:date</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:comment : Set of parameters for adapting the braking curves calculated by the ETCS on-board system to match accuracy, performance and safety margins imposed by the infrastructure manager.
    /// It copies the content of Packet 3 or of Packet 203 as defined in the specification referenced in Appendix A-1, index [C].</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.5.13^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>skos:scopeNote : Non-harmonizable character string: [Contents of P3/P203] (TSI CCS, Annex I, Appendix A, Table A.2 - Subset-026)</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/nationalValuesBrakeModel">era:nationalValuesBrakeModel</a>
    /// </summary>
    let nationalValuesBrakeModel = _prefixId.prefix "nationalValuesBrakeModel"
    /// <summary>
    ///   <para>rdfs:label : Navigability</para>
    ///   <para>rdfs:comment : Indicates the navigation possibilities between two related topological linear elements.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : •	AB: Trains can move from element A to element B.
    /// •	BA: Trains can move from element B to element A.
    /// •	Both: Movement is bidirectional.
    /// •	None: No movement is allowed between the two elements.
    /// </para>
    ///   <para>skos:altLabel : Internal connection</para>
    ///   <para>era:rinfIndex : 1.1.1.0.1.2^^xsd:stringera:rinfIndex : 1.2.4.1^^xsd:string</para>
    ///   <para>dcterms:created : 2021-04-01^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-08-03^^xsd:datedcterms:modified : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/navigability">era:navigability</a>
    /// </summary>
    let navigability = _prefixId.prefix "navigability"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Net element</para>
    ///   <para>rdfs:comment : References an associated topological object.
    /// The reason for deprecating this property is that it is defined as "References an associated topological object." and the vocabulary has already a property "hasAbstraction" which relates the implementation layer with the topological layer, https://citnet.tech.ec.europa.eu/CITnet/confluence/pages/viewpage.action?pageId=1122974879.</para>
    ///   <para>dcterms:modified : 2022-09-06^^xsd:date</para>
    ///   <para>dcterms:created : 2021-04-01^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/netElement">era:netElement</a>
    /// </summary>
    let netElement = _prefixId.prefix "netElement"
    /// <summary>
    ///   <para>rdfs:comment : The reference that a physical infrastructure element has it on the topology. It may be used to define the positioning or a representation as a point, line or area</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <para>rdfs:label : net reference</para>
    ///   <para>dcterms:modified : 2025-03-10^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/netReference">era:netReference</a>
    /// </summary>
    let netReference = _prefixId.prefix "netReference"

    /// <summary>
    ///   <para>rdfs:label : Network statements characteristic^^xsd:string</para>
    ///   <para>dcterms:created : 2025-09-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/networkStatementsDataCharacteristic">era:networkStatementsDataCharacteristic</a>
    /// </summary>
    let networkStatementsDataCharacteristic = _prefixId.prefix "networkStatementsDataCharacteristic"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-06-15^^xsd:date</para>
    ///   <para>rdfs:comment : Denotes a non-coded restrictions for this particular vehicleType, as a set of sentences.</para>
    ///   <para>dcterms:created : 2022-06-15^^xsd:date</para>
    ///   <para>rdfs:label : Non coded restrictions</para>
    ///   <a href="http://data.europa.eu/949/nonCodedRestrictions">era:nonCodedRestrictions</a>
    /// </summary>
    let nonCodedRestrictions = _prefixId.prefix "nonCodedRestrictions"
    /// <summary>
    ///   <para>dcterms:modified : 2025-03-10^^xsd:datedcterms:modified : 2021-09-13^^xsd:date</para>
    ///   <para>dcterms:created : 2021-09-13^^xsd:date</para>
    ///   <para>rdfs:label : Not applicable</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Reference to a property that is not applicable.</para>
    ///   <a href="http://data.europa.eu/949/notApplicable">era:notApplicable</a>
    /// </summary>
    let notApplicable = _prefixId.prefix "notApplicable"
    /// <summary>
    ///   <para>rdfs:comment : Reference to a property that is not provided.</para>
    ///   <para>dcterms:modified : 2023-10-11^^xsd:datedcterms:modified : 2025-03-10^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-09-13^^xsd:date</para>
    ///   <para>rdfs:label : Not provided</para>
    ///   <a href="http://data.europa.eu/949/notYetAvailable">era:notYetAvailable</a>
    /// </summary>
    let notYetAvailable = _prefixId.prefix "notYetAvailable"

    /// <summary>
    ///   <para>dcterms:created : 2021-08-25^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-08-25^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.1.6^^xsd:string</para>
    ///   <para>rdfs:comment : Number of elements in the rake of freight wagons (only for subcategory 'rake of freight wagons')</para>
    ///   <para>rdfs:label : Number elements rake freight wagons</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/numberElementsRakeFreightWagons">era:numberElementsRakeFreightWagons</a>
    /// </summary>
    let numberElementsRakeFreightWagons = _prefixId.prefix "numberElementsRakeFreightWagons"

    /// <summary>
    ///   <para>era:eratvIndex : 4.10.7^^xsd:string</para>
    ///   <para>dcterms:modified : 2020-11-19^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Number of pantographs in contact with the overhead contact line (OCL) (to be indicated for each energy supply system the vehicle is equipped for).</para>
    ///   <para>rdfs:label : Number of pantographs in contact with OCL</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/numberOfPantographsInContactWithOCL">era:numberOfPantographsInContactWithOCL</a>
    /// </summary>
    let numberOfPantographsInContactWithOCL = _prefixId.prefix "numberOfPantographsInContactWithOCL"

    /// <summary>
    ///   <para>rdfs:label : Number of toilets</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Number of toilets.</para>
    ///   <para>era:eratvIndex : 4.12.1.2^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/numberOfToilets">era:numberOfToilets</a>
    /// </summary>
    let numberOfToilets = _prefixId.prefix "numberOfToilets"

    /// <summary>
    ///   <para>rdfs:label : OCL separation sections</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/oclSeparationSectionsDataParameter">era:oclSeparationSectionsDataParameter</a>
    /// </summary>
    let oclSeparationSectionsDataParameter = _prefixId.prefix "oclSeparationSectionsDataParameter"

    /// <summary>
    ///   <para>rdfs:label : OCL separation sections</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/oclSeparationSectionsObjParameter">era:oclSeparationSectionsObjParameter</a>
    /// </summary>
    let oclSeparationSectionsObjParameter = _prefixId.prefix "oclSeparationSectionsObjParameter"

    /// <summary>
    ///   <para>era:eratvIndex : 4.10.9^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <para>dcterms:modified : 2020-10-03^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Ocl type</para>
    ///   <para>rdfs:comment : OCL type.</para>
    ///   <a href="http://data.europa.eu/949/oclType">era:oclType</a>
    /// </summary>
    let oclType = _prefixId.prefix "oclType"
    /// <summary>
    ///   <para>rdfs:label : of parameter</para>
    ///   <para>rdfs:comment : Indicates the parameter (object or datatype property) for which an applicability is being defined.</para>
    ///   <para>dcterms:modified : 2024-12-10^^xsd:date</para>
    ///   <para>dcterms:created : 2024-10-28^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/ofParameter">era:ofParameter</a>
    /// </summary>
    let ofParameter = _prefixId.prefix "ofParameter"
    /// <summary>
    ///   <para>rdfs:label : offset</para>
    ///   <para>rdfs:comment : Relative distance from a reference kilometric post </para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/offsetFromKilometricPost">era:offsetFromKilometricPost</a>
    /// </summary>
    let offsetFromKilometricPost = _prefixId.prefix "offsetFromKilometricPost"
    /// <summary>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <para>rdfs:comment : Offset from the origin in a topological coordinate.</para>
    ///   <para>dcterms:modified : 2025-10-07^^xsd:datedcterms:modified : 2025-01-30^^xsd:date</para>
    ///   <para>rdfs:label : offset from origin</para>
    ///   <a href="http://data.europa.eu/949/offsetFromOrigin">era:offsetFromOrigin</a>
    /// </summary>
    let offsetFromOrigin = _prefixId.prefix "offsetFromOrigin"
    /// <summary>
    ///   <para>rdfs:label : on element</para>
    ///   <para>rdfs:comment : Specifies the linear element a section belongs to.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/onElement">era:onElement</a>
    /// </summary>
    let onElement = _prefixId.prefix "onElement"
    /// <summary>
    ///   <para>rdfs:label : on linear element</para>
    ///   <para>rdfs:comment : Specifies the linear element a coordinate is associated with.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/onLinearElement">era:onLinearElement</a>
    /// </summary>
    let onLinearElement = _prefixId.prefix "onLinearElement"
    /// <summary>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>era:XMLName : SOLOPEnd^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-09-09^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:label : Operational point at end of section of line</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.1.2^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.0.0.0.4^^xsd:string</para>
    ///   <para>rdfs:comment : Operational point at the end of section of line (kilometres increasing from start OP to the end OP).</para>
    ///   <para>skos:scopeNote : Each SoL may have only one end OP, and each OP has unique OP ID within the MS. The “uniqueOPID” is defined in parameter 1.2.0.0.0.2.
    /// Each SoL has the principal direction of the traffic defined by increasing kilometres running from the start OP to the end OP.
    /// That is why the end OP is always located at highest kilometre of the line within the SoL.
    /// No validation will be performed by RINF application regarding which is the start and which the end OP. This requires IM's verification. </para>
    ///   <a href="http://data.europa.eu/949/opEnd">era:opEnd</a>
    /// </summary>
    let opEnd = _prefixId.prefix "opEnd"
    /// <summary>
    ///   <para>rdfs:label : Operational point generic information</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.0.0.0^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/opGenericDataParameter">era:opGenericDataParameter</a>
    /// </summary>
    let opGenericDataParameter = _prefixId.prefix "opGenericDataParameter"
    /// <summary>
    ///   <para>rdfs:label : Operational point generic information</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.0.0.0^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/opGenericObjParameter">era:opGenericObjParameter</a>
    /// </summary>
    let opGenericObjParameter = _prefixId.prefix "opGenericObjParameter"
    /// <summary>
    ///   <para>dcterms:modified : 2024-10-24^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an operational point that represents the general information of a border point to the information that each country maintains for the border point.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2023-01-20^^xsd:date</para>
    ///   <para>rdfs:label : Border point information per country</para>
    ///   <a href="http://data.europa.eu/949/opInfoPerCountry">era:opInfoPerCountry</a>
    /// </summary>
    let opInfoPerCountry = _prefixId.prefix "opInfoPerCountry"
    /// <summary>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:modified : 2025-08-26^^xsd:datedcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2021-09-13^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : OPName^^xsd:string</para>
    ///   <para>skos:scopeNote : Name of OP may not always exist in common use. In such case IM should propose a name for OP. </para>
    ///   <para>rdfs:label : Name of operational point</para>
    ///   <para>dcterms:created : 2021-09-13^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.3.1^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.0.0.0.1^^xsd:string</para>
    ///   <para>rdfs:comment : Name normally related to the town or village or to traffic control purpose.</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/opName">era:opName</a>
    /// </summary>
    let opName = _prefixId.prefix "opName"
    /// <summary>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>skos:scopeNote : Each SoL may have only one start OP, and each OP has unique OP ID within the MS. The “uniqueOPID” is defined in parameter 1.2.0.0.0.2.
    /// Each SoL has the principal direction of the traffic defined by increasing kilometres running from the start OP to the end OP.
    /// That is why the start OP is always located at lowest kilometre of the line within the SoL.
    /// No validation will be performed by RINF application regarding which is the start and which the end OP. This requires IM's verification. </para>
    ///   <para>dcterms:created : 2021-09-09^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.0.0.0.3^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:comment : Operational point at the start of section of line (kilometres increasing from start OP to the end OP).</para>
    ///   <para>rdfs:label : Operational point at start of section of line</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.1.1^^xsd:string</para>
    ///   <para>era:XMLName : SOLOPStart^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/opStart">era:opStart</a>
    /// </summary>
    let opStart = _prefixId.prefix "opStart"
    /// <summary>
    ///   <para>rdfs:comment : Type of facility in relation to the dominating operational functions.</para>
    ///   <para>era:rinfIndex : 1.2.0.0.0.4^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-03^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>skos:scopeNote : Each existing case has to be approximated to the one of the above defined types by including size, importance and dominating functions. It is most important to recognize the most important role of specific OP in the network. That is why only one type for one OP is permitted.
    ///
    /// For purpose of RINF, there were defined the following types of OPs:
    /// 1.	Station - large or major railway node with several functions, important for international traffic, basic for national railway system;
    /// 2.	Passenger terminal - station with dominating function of service for passenger traffic, serving as a central hub for passengers, often integrating rail operations with intermodal transport networks and large-scale passenger facilities, including ticketing, waiting areas, and other passenger services;
    /// 3.	Freight terminal - station dominantly serving for loading and unloading of freight trains;
    /// 4.	Depot or workshop - group of tracks used by depot or workshop for RST maintenance;
    /// 5.	Train technical services - group of tracks for servicing trains (parking, washing, etc.);
    /// 6.	Passenger stop - or halts - small OP consisting of at least one platform, normally serving mostly for local passenger services, without routing, dispatching, or train management facilities;
    /// 7.	Junction - OP consisting of at least one turnout, normally used mostly for changing direction of trains, with reduced or not existing other functions;
    /// 8.	Border point - located in the point where a border between MSs meets a railway line;
    /// 9.	Shunting yard - group of tracks used for shunting trains, mostly related to freight traffic;
    /// 10.	Switch - OP consisting of only one switch and the area around it, delimited and protected by entry signals, normally used for changing direction of trains, with reduced or not existing other functions;
    /// 11.	Domestic border point - designated location on the main lines where the infrastructure responsibilities transition between IMs.
    /// </para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.2.2^^xsd:stringera:tsiOPEAppendixD2Index : 2.3.2^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>era:XMLName : OPType^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>rdfs:label : Type of operational point</para>
    ///   <a href="http://data.europa.eu/949/opType">era:opType</a>
    /// </summary>
    let opType = _prefixId.prefix "opType"
    /// <summary>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2021-08-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.0.0.0.4.1^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-11^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:XMLName : OPTypeGaugeChangeover^^xsd:string</para>
    ///   <para>rdfs:label : Type of track gauge changeover facility</para>
    ///   <para>rdfs:comment : Type of track gauge changeover facility.</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <a href="http://data.europa.eu/949/opTypeGaugeChangeover">era:opTypeGaugeChangeover</a>
    /// </summary>
    let opTypeGaugeChangeover = _prefixId.prefix "opTypeGaugeChangeover"
    /// <summary>
    ///   <para>rdfs:comment : Opening hours of the section of a line or tunnel or a bridge</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Opening hours limitation</para>
    ///   <para>dcterms:created : 2025-09-30^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/openingHoursLimitation">era:openingHoursLimitation</a>
    /// </summary>
    let openingHoursLimitation = _prefixId.prefix "openingHoursLimitation"
    /// <summary>
    ///   <para>era:rinfIndex : 1.2.0.0.0.8^^xsd:stringera:rinfIndex : 1.1.0.0.1.2^^xsd:string</para>
    ///   <para>era:applicable : Y/NYA^^xsd:string</para>
    ///   <para>rdfs:comment : The language or languages used in daily operation by infrastructure manager and published in its Network Statement, for the communication of operational or safety related messages between the staff of the infrastructure manager and the railway undertaking.</para>
    ///   <para>rdfs:label : Operating language</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>era:formatNote : http://publications.europa.eu/resource/authority/language^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>dcterms:created : 2022-10-28^^xsd:date</para>
    ///   <para>era:XMLName : RBS_OpeLang^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.5.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/operatingLanguage">era:operatingLanguage</a>
    /// </summary>
    let operatingLanguage = _prefixId.prefix "operatingLanguage"
    /// <summary>
    ///   <para>dcterms:created : 2022-10-27^^xsd:date</para>
    ///   <para>rdfs:seeAlso : https://www.securite-ferroviaire.fr/sites/default/files/reglementations/pdf/2023-03/document-pedagogique-signaux-regimes-exploitation-v1.pdf^^xsd:anyURI</para>
    ///   <para>era:applicable : Y/NYA^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.0.0.1.3^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-24^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:XMLName : RBS_OpeReg^^xsd:string</para>
    ///   <para>rdfs:comment : Double track type.</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.7^^xsd:string</para>
    ///   <para>rdfs:label : Operational regime</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <a href="http://data.europa.eu/949/operationalRegimeType">era:operationalRegimeType</a>
    /// </summary>
    let operationalRegimeType = _prefixId.prefix "operationalRegimeType"
    /// <summary>
    ///   <para>dcterms:created : 2020-11-23^^xsd:date</para>
    ///   <para>rdfs:label : Operational restriction</para>
    ///   <para>dcterms:modified : 2021-08-03^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates an operational restriction of vehicle or wagon. Parking brake type (if the vehicle is fitted with it).</para>
    ///   <a href="http://data.europa.eu/949/operationalRestriction">era:operationalRestriction</a>
    /// </summary>
    let operationalRestriction = _prefixId.prefix "operationalRestriction"
    /// <summary>
    ///   <para>era:rinfIndex : 1.2.1.0.0.1^^xsd:stringera:rinfIndex : 1.2.2.0.0.1^^xsd:stringera:rinfIndex : 1.2.2.0.5.1^^xsd:stringera:rinfIndex : 1.1.1.1.8.1^^xsd:stringera:rinfIndex : 1.1.0.0.0.1^^xsd:stringera:rinfIndex : 1.2.1.0.6.1^^xsd:stringera:rinfIndex : 1.2.1.0.5.1^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-11-27^^xsd:datedcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2024-11-06^^xsd:datedcterms:modified : 2024-11-12^^xsd:datedcterms:modified : 2025-03-08^^xsd:date</para>
    ///   <para>rdfs:label : organisation code^^xsd:string</para>
    ///   <para>era:XMLName : OPTrackPlatformIMCode^^xsd:stringera:XMLName : OPTrackIMCode^^xsd:stringera:XMLName : OPSidingIMCode^^xsd:stringera:XMLName : OPSidingTunnelIMCode^^xsd:stringera:XMLName : SOLTunnelIMCode^^xsd:stringera:XMLName : OPTrackTunnelIMCode^^xsd:stringera:XMLName : SOLIMCode^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 1.1^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:seeAlso : https://eur-lex.europa.eu/eli/dir/2012/34/oj#d1e885-32-1^^xsd:anyURI</para>
    ///   <para>era:formatNote : AAAA^^xsd:string</para>
    ///   <para>dcterms:created : 2024-06-03^^xsd:date</para>
    ///   <para>skos:altLabel : IM's code</para>
    ///   <para>skos:example : Simplified example:
    /// :ABCD_IM rdf:type era:OrganisationRole;
    /// 	era:hasOrganisationRole era-skos:InfrastructureManager ;
    ///   era:roleOf :ABCD .
    /// :ABCD rdf:type era:Organisation ;
    /// 	  era:organisationCode "ABCD" ;
    ///     era:role :ABCD_IM .
    ///
    /// :0000_IM rdf:type era:OrganisationRole;
    /// 	era:hasOrganisationRole era-skos:InfrastructureManager.
    /// 	era:roleOf :0000_ORG.
    /// :0000_ORG rdf:type era:Body;
    ///      era:organisationCode "0000".
    ///
    /// #IM Code parameter - directly attached to a track
    /// :track2 rdf:type era:RunningTrack;
    /// 	era:infrastructureManager :0000_IM.^^xsd:string</para>
    ///   <para>rdfs:comment : Infrastructure manager means any body or undertaking that is responsible in particular for establishing and maintaining railway infrastructure or a part thereof.rdfs:comment : Four alpha-numeric code allocated by ERA to a body. It represents the Infrastructure Manager (IM) code in RINF.
    /// Infrastructure manager means any body or firm responsible in particular for establishing, managing and maintaining railway infrastructure, including traffic management and control-command signalling;
    /// the functions of the infrastructure manager on a network or part of a network may be allocated to different bodies or firms. Definition in (Article 3(2))</para>
    ///   <para>skos:scopeNote : The Code is a unique identifier for the Infrastructure Manager and it shall be verified on national level.
    /// - If the IM is subject to TAF/TAP TSIs, it corresponds to the code used in TAF/TAP TSIs.
    /// - In other cases, it corresponds to the "organisation code" assigned by the Agency for the specific needs of the RINF.
    /// Each Section of Line shall concern only one IM.
    /// To be able to follow the "only once" principle, the infrastructure manager code is a property of the organisation having the role of infrastructuer manager. For data provision, a subset of elements with common characteristics should be created with the era:infrastructureManager property having as value the instance of the infrastructure mananger role.</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/organisationCode">era:organisationCode</a>
    /// </summary>
    let organisationCode = _prefixId.prefix "organisationCode"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : (deprecated) not in use anymore</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:definition : Additional concept class according to OpenStreetMap.</para>
    ///   <para>rdfs:label : Open street map class</para>
    ///   <a href="http://data.europa.eu/949/osmClass">era:osmClass</a>
    /// </summary>
    let osmClass = _prefixId.prefix "osmClass"
    /// <summary>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.14.1^^xsd:stringera:rinfIndex : 1.2.1.1.1.14.1^^xsd:string</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.3^^xsd:string</para>
    ///   <para>rdfs:label : Other Cant Deficiency train categories for which the ETCS trackside is configured to provide SSP</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:comment : Essential information for drivers of trains with a worse (lower) tolerated cant deficiency than those for which the ETCS trackside provides SSP (Static Speed Profiles) in conjunction with parameter "Cant Deficiency used for the basic SSP".
    /// According to the specification referenced in Appendix A-1, index [C]</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>skos:scopeNote : The values indicated in millimetres correspond to tracks with UIC gauge. For tracks with a gauge different from UIC, the values provided here are the equivalent ones for UIC gauge, as the actual physical cant deficiency values differ. Please refer to parameter 1.1.1.1.4.2 for more details.
    ///
    /// Subset-026 (3.11.3.2.1.1) definition: b) The "other specific" SSP categories: it groups all other specific SSP categories corresponding to the other international train categories.</para>
    ///   <a href="http://data.europa.eu/949/otherCantDeficiencyBasicSSP">era:otherCantDeficiencyBasicSSP</a>
    /// </summary>
    let otherCantDeficiencyBasicSSP = _prefixId.prefix "otherCantDeficiencyBasicSSP"
    /// <summary>
    ///   <para>rdfs:label : Accepted other pantograph heads</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:comment : Indication of pantograph heads which are allowed to be used.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.2.3.2^^xsd:string</para>
    ///   <para>era:XMLName : EPA_OtherHeads^^xsd:string</para>
    ///   <para>dcterms:created : 2022-06-03^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>skos:scopeNote : The parameter may contain more than one type of the pantograph head - all of them shall be indicated by repetition of the parameter with different single selections.
    /// Additional values than the already identified in the list above are possible. They will be introduced by the Agency on request via a process of change request.</para>
    ///   <para>rdfs:seeAlso : EN 50367:2020+A1:2022: Annex B3
    /// LOC&amp;PAS TSI: 7.3.2.14 (specific cases)^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-25^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2022-06-03^^xsd:date</para>
    ///   <para>era:dependencyNote : Mandatory only if “Overhead contact line (OCL)” is selected in 1.1.1.2.2.1.1, otherwise the parameter is not applicable.</para>
    ///   <a href="http://data.europa.eu/949/otherPantographHead">era:otherPantographHead</a>
    /// </summary>
    let otherPantographHead = _prefixId.prefix "otherPantographHead"
    /// <summary>
    ///   <para>rdfs:label : Radio Legacy Systems^^xsd:string</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.5^^xsd:stringera:rinfIndex : 1.1.1.3.6^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/otherRadioSystemsObjParameter">era:otherRadioSystemsObjParameter</a>
    /// </summary>
    let otherRadioSystemsObjParameter = _prefixId.prefix "otherRadioSystemsObjParameter"

    /// <summary>
    ///   <para>rdfs:label : Other train detection systems</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.6^^xsd:stringera:rinfIndex : 1.1.1.3.7^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/otherTrainDetectionSystemsDataParameter">era:otherTrainDetectionSystemsDataParameter</a>
    /// </summary>
    let otherTrainDetectionSystemsDataParameter = _prefixId.prefix "otherTrainDetectionSystemsDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Other train detection systems</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.6^^xsd:stringera:rinfIndex : 1.1.1.3.7^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/otherTrainDetectionSystemsObjParameter">era:otherTrainDetectionSystemsObjParameter</a>
    /// </summary>
    let otherTrainDetectionSystemsObjParameter = _prefixId.prefix "otherTrainDetectionSystemsObjParameter"

    /// <summary>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latestera:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>era:dependencyNote : Only applicable when for parameter 1.1.1.3.10.1 "none" was selected.</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2022-11/list_harmonised_national_restriction_codes_en %281%29.pdf?t=1707149802^^xsd:anyURI</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.10.2^^xsd:stringera:rinfIndex : 1.2.1.1.9.2^^xsd:string</para>
    ///   <para>era:XMLName : CLD_OtherProtectControlWarn^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of existence of other system than ETCS for degraded situation.</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-03-04^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.1^^xsd:string</para>
    ///   <para>skos:scopeNote : Selected value shall answer the question whether any other system than ETCS exists on the respective track. The list of possible values is in line with ERA/TD/2011-09/INT, Table 3.</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:label : Other train protection, control and warning systems for degraded situation</para>
    ///   <a href="http://data.europa.eu/949/otherTrainProtection">era:otherTrainProtection</a>
    /// </summary>
    let otherTrainProtection = _prefixId.prefix "otherTrainProtection"
    /// <summary>
    ///   <para>rdfs:label : Pantograph</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.3^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/pantographDataParameter">era:pantographDataParameter</a>
    /// </summary>
    let pantographDataParameter = _prefixId.prefix "pantographDataParameter"
    /// <summary>
    ///   <para>rdfs:label : Pantograph</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.3^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/pantographObjParameter">era:pantographObjParameter</a>
    /// </summary>
    let pantographObjParameter = _prefixId.prefix "pantographObjParameter"
    /// <summary>
    ///   <para>rdfs:label : parameter applicability</para>
    ///   <para>rdfs:comment : Relates an infrastructure element or a common characteristics subset with the applicability of a certain parameter.</para>
    ///   <para>dcterms:modified : 2024-10-28^^xsd:date</para>
    ///   <para>dcterms:created : 2024-05-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/parameterApplicability">era:parameterApplicability</a>
    /// </summary>
    let parameterApplicability = _prefixId.prefix "parameterApplicability"
    /// <summary>
    ///   <para>rdfs:label : Parameter value</para>
    ///   <para>rdfs:comment : This property is used to link an applicability to the precise value of the parameter</para>
    ///   <para>dcterms:created : 2024-12-10^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/parameterValue">era:parameterValue</a>
    /// </summary>
    let parameterValue = _prefixId.prefix "parameterValue"
    /// <summary>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <para>rdfs:comment : In the case of a change in the value of a parameter, there needs to be an information on the type of the new value. The “Value type” will have different possible options: “nominal”, “planned temporary restriction”, “permanent restriction”, “planned temporary closure”.</para>
    ///   <para>rdfs:label : parameter value type</para>
    ///   <a href="http://data.europa.eu/949/parameterValueType">era:parameterValueType</a>
    /// </summary>
    let parameterValueType = _prefixId.prefix "parameterValueType"
    /// <summary>
    ///   <para>dcterms:modified : 2022-04-11^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.7.3^^xsd:string</para>
    ///   <para>rdfs:label : Parking brake</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates whether all vehicles of this type must be equipped with a parking brake.</para>
    ///   <para>dcterms:created : 2022-04-11^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/parkingBrake">era:parkingBrake</a>
    /// </summary>
    let parkingBrake = _prefixId.prefix "parkingBrake"
    /// <summary>
    ///   <para>rdfs:label : Parking brake mandatory</para>
    ///   <para>rdfs:comment : All vehicles of this type must be equipped with a parking brake (parking brake mandatory for vehicles of this type).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.7.3.1^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-26^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/parkingBrakeMandatory">era:parkingBrakeMandatory</a>
    /// </summary>
    let parkingBrakeMandatory = _prefixId.prefix "parkingBrakeMandatory"
    /// <summary>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>rdfs:label : Parking brake maximum gradient</para>
    ///   <para>rdfs:comment : Maximum gradient on which the unit is kept immobilised by the parking brake alone (if the vehicle is fitted with it).</para>
    ///   <para>era:eratvIndex : 4.7.3.3^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/parkingBrakeMaximumGradient">era:parkingBrakeMaximumGradient</a>
    /// </summary>
    let parkingBrakeMaximumGradient = _prefixId.prefix "parkingBrakeMaximumGradient"
    /// <summary>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.7.3.2^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-26^^xsd:date</para>
    ///   <para>rdfs:comment : Parking brake type (if the vehicle is fitted with it).</para>
    ///   <para>rdfs:label : Parking brake type</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/parkingBrakeType">era:parkingBrakeType</a>
    /// </summary>
    let parkingBrakeType = _prefixId.prefix "parkingBrakeType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : part of TEN-T</para>
    ///   <para>rdfs:comment : Links an element to its TEN-T network classification, which includes network level, type of traffic, and European transport corridor information.</para>
    ///   <para>dcterms:created : 2025-11-17^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/partOfTENT">era:partOfTENT</a>
    /// </summary>
    let partOfTENT = _prefixId.prefix "partOfTENT"
    /// <summary>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Pass-by noise level given in dB(A).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Pass-by noise level</para>
    ///   <para>era:eratvIndex : 4.11.1^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/passByNoiseLevel">era:passByNoiseLevel</a>
    /// </summary>
    let passByNoiseLevel = _prefixId.prefix "passByNoiseLevel"
    /// <summary>
    ///   <para>rdfs:comment : Passenger possible flag attached to a Primary Location</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : passenger flag</para>
    ///   <para>dcterms:created : 2025-09-21^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/passengerFlag">era:passengerFlag</a>
    /// </summary>
    let passengerFlag = _prefixId.prefix "passengerFlag"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2022-10-27^^xsd:datedcterms:modified : 2024-10-24^^xsd:datedcterms:modified : 2025-10-08^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>rdfs:comment : References a tunnel that a track goes through.</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>rdfs:label : Passes through tunnel</para>
    ///   <a href="http://data.europa.eu/949/passesThroughTunnel">era:passesThroughTunnel</a>
    /// </summary>
    let passesThroughTunnel = _prefixId.prefix "passesThroughTunnel"
    /// <summary>
    ///   <para>rdfs:label : Performance parameter</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.2.0.2^^xsd:stringera:rinfIndex : 1.2.1.0.2^^xsd:stringera:rinfIndex : 1.1.1.1.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/performanceDataParameter">era:performanceDataParameter</a>
    /// </summary>
    let performanceDataParameter = _prefixId.prefix "performanceDataParameter"
    /// <summary>
    ///   <para>rdfs:label : Performance parameter</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.2.0.2^^xsd:stringera:rinfIndex : 1.2.1.0.2^^xsd:stringera:rinfIndex : 1.1.1.1.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/performanceObjParameter">era:performanceObjParameter</a>
    /// </summary>
    let performanceObjParameter = _prefixId.prefix "performanceObjParameter"
    /// <summary>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.5.1^^xsd:string</para>
    ///   <para>rdfs:comment : Permissible payload for different line categories.</para>
    ///   <para>rdfs:label : Permissible payload</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/permissiblePayload">era:permissiblePayload</a>
    /// </summary>
    let permissiblePayload = _prefixId.prefix "permissiblePayload"

    /// <summary>
    ///   <para>era:legalDeadline : Contrary to the Regulation, the deadline is not 30 June 2024 at the latest, but 12 months after publication of Article 7 Guide</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Point at which IM authorises charging of electric energy storage for traction purposes at standstill.</para>
    ///   <para>rdfs:label : Permission for charging electric energy storage for traction purposes at standstill</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.0.7.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/permissionChargingElectricEnergyTractionStandstill">era:permissionChargingElectricEnergyTractionStandstill</a>
    /// </summary>
    let permissionChargingElectricEnergyTractionStandstill = _prefixId.prefix "permissionChargingElectricEnergyTractionStandstill"

    /// <summary>
    ///   <para>skos:scopeNote : From TSI OPE: Member States shall in particular endeavour to permit the use of reflective plates on rail freight corridors, with a view to prioritise the current bottlenecks. These sections and details of any conditions pertaining to them shall be recorded in the RINF. Until the information is encoded in RINF, the infrastructure manager shall ensure the information is communicated to railway undertakings by other appropriate means. The infrastructure manager shall identify the sections of lines on which 2 steady red lights are required in the RINF. </para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-09-22^^xsd:datedcterms:modified : 2026-01-22^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:seeAlso : 4.2.2.1.3.2 of TSI OPE (Commission Implementing Regulation (EU) 2019/773 of 16 May 2019)^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:comment : Sections where is permitted to use the reflective plates on rail freight corridors, with a view to prioritise the current bottlenecks. Specific case for Belgium, France, Italy, Portugal and Spain until 1.1.2026</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:label : Permit of use of reflective plates</para>
    ///   <para>era:rinfIndex : 1.1.1.1.7.12^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/permitUseReflectivePlates">era:permitUseReflectivePlates</a>
    /// </summary>
    let permitUseReflectivePlates = _prefixId.prefix "permitUseReflectivePlates"
    /// <summary>
    ///   <para>rdfs:seeAlso : LOC&amp;PAS TSI: 4.2.8.2.9.6
    /// ENE TSI: 4.2.11
    /// EN 50367:2020+A1:2022 Table 6^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.2.5.2^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <para>rdfs:label : Contact force permitted</para>
    ///   <para>era:dependencyNote : A value is mandatory if the value  Overhead contact line (OCL)  is selected for parameter "Type of contact line system"</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>skos:scopeNote : The formula of the function shall represent the curve describing the value of the contact force in relation to the speed.
    /// Static and maximum forces are given only for the maximum permitted line speed (see parameter number 1.1.1.1.2.5).</para>
    ///   <para>era:XMLName : ERS_ContactForce^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of contact force allowed expressed in newton.</para>
    ///   <para>era:formatNote : The force is either given as: a value of the static force and of the maximum force expressed in newtons, or as a formula for function of the speed^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/permittedContactForce">era:permittedContactForce</a>
    /// </summary>
    let permittedContactForce = _prefixId.prefix "permittedContactForce"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:label : Information on phase separation</para>
    ///   <para>skos:editorialNote :  Deprecated because of replacement by three properties. The reason is that the property is composed of three values: length [NNN] - the length of the phase separation in metres; switch off breaker [Y/N], single selection of 'yes' or 'no' to show whether the breaker has to be switched off; and lower pantograph [Y/N], single selection of 'yes' or 'no' to show whether the pantograph has to be lowered,
    ///                    Km [NNN.NNN] - the location from the start of the line where the new value is valid.</para>
    ///   <a href="http://data.europa.eu/949/phaseInfo">era:phaseInfo</a>
    /// </summary>
    let phaseInfo = _prefixId.prefix "phaseInfo"
    /// <summary>
    ///   <para>rdfs:label : Phase info change supply system</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-06-09^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>rdfs:comment : Part of the phase info of a track that corresponds to the single selection of Y=yes or N=no to show if the energy supply system changes</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2024-02-05^^xsd:date</para>
    ///   <para>skos:scopeNote :  The phase info is the indication of required several information on phase separation.</para>
    ///   <a href="http://data.europa.eu/949/phaseInfoChangeSupplySystem">era:phaseInfoChangeSupplySystem</a>
    /// </summary>
    let phaseInfoChangeSupplySystem = _prefixId.prefix "phaseInfoChangeSupplySystem"
    /// <summary>
    ///   <para>skos:scopeNote :  The phase info is the indication of required several information on phase separation.</para>
    ///   <para>rdfs:label : Phase info distance type</para>
    ///   <para>rdfs:comment : Part of the phase info of a track that corresponds to the single selection of 'MIN=minimum' or 'MAX=maximum' to show whether the length is a minimum distance between the inner contact strips of the pantographs or a maximum distance between the outer contact strips of the pantographs. Multiple strings for this parameter are accepted.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>dcterms:created : 2024-02-05^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/phaseInfoDistanceType">era:phaseInfoDistanceType</a>
    /// </summary>
    let phaseInfoDistanceType = _prefixId.prefix "phaseInfoDistanceType"
    /// <summary>
    ///   <para>rdfs:comment : Part of the phase info of a track that indicates the location from the start of the line where the new value is valid.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>skos:scopeNote :  The phase info is the indication of required several information on phase separation.</para>
    ///   <para>rdfs:label : Phase info Km</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/phaseInfoKm">era:phaseInfoKm</a>
    /// </summary>
    let phaseInfoKm = _prefixId.prefix "phaseInfoKm"
    /// <summary>
    ///   <para>skos:scopeNote : The phase info is the indication of required several information on phase separation.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>rdfs:comment : Part of the phase info of a track that corresponds to the length of the phase separation in metres.</para>
    ///   <para>rdfs:label : Phase info length</para>
    ///   <a href="http://data.europa.eu/949/phaseInfoLength">era:phaseInfoLength</a>
    /// </summary>
    let phaseInfoLength = _prefixId.prefix "phaseInfoLength"
    /// <summary>
    ///   <para>rdfs:comment : Part of the phase info of a track that shows whether a pantograph has to be lowered.</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:label : Phase info pantograph lowered</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote :  The phase info is the indication of required several information on phase separation.</para>
    ///   <a href="http://data.europa.eu/949/phaseInfoPantographLowered">era:phaseInfoPantographLowered</a>
    /// </summary>
    let phaseInfoPantographLowered = _prefixId.prefix "phaseInfoPantographLowered"
    /// <summary>
    ///   <para>skos:scopeNote :  The phase info is the indication of required several information on phase separation.</para>
    ///   <para>rdfs:comment : Part of the phase info of a track that shows whether the breaker has to be switched off.</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:label : Phase info switch off breaker</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/phaseInfoSwitchOffBreaker">era:phaseInfoSwitchOffBreaker</a>
    /// </summary>
    let phaseInfoSwitchOffBreaker = _prefixId.prefix "phaseInfoSwitchOffBreaker"
    /// <summary>
    ///   <para>rdfs:label : Platform</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.0.6^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/platformDataParameter">era:platformDataParameter</a>
    /// </summary>
    let platformDataParameter = _prefixId.prefix "platformDataParameter"
    /// <summary>
    ///   <para>rdfs:comment : Reference to a related platform edge.</para>
    ///   <para>dcterms:modified : 2023-11-10^^xsd:datedcterms:modified : 2025-10-08^^xsd:datedcterms:modified : 2024-10-24^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Platform edge</para>
    ///   <a href="http://data.europa.eu/949/platformEdge">era:platformEdge</a>
    /// </summary>
    let platformEdge = _prefixId.prefix "platformEdge"
    /// <summary>
    ///   <para>skos:scopeNote : Values included in the list are taken from PRM and INF TSIs including Specific Cases. They are the values which are mandatory for the design of the platform at the respective part of the network. They are not real values measured at real platforms.
    /// Platform dimensions are always related to one neighbouring track at a time.
    /// So, if two tracks are along a platform, this platform should be divided into two or more ‘RINF platforms’ to have precise description of each.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:comment : Distance between the upper surface of platform and running surface of the neighbouring track. It is the nominal value expressed in millimetres.</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.3.7^^xsd:string</para>
    ///   <para>rdfs:seeAlso : INF TSI: 4.2.9.2
    /// PRM TSI: 4.2.2.11
    /// OPE TSI: 2.3.7 of Appendix D2^^xsd:string</para>
    ///   <para>rdfs:label : Height of platform</para>
    ///   <para>era:XMLName : IPL_Height^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.0.6.5^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2021-08-02^^xsd:date</para>
    ///   <para>era:applicable : Y/^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2021-08-02^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/platformHeight">era:platformHeight</a>
    /// </summary>
    let platformHeight = _prefixId.prefix "platformHeight"
    /// <summary>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:modified : 2025-09-03^^xsd:datedcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:comment : Unique platform identification or unique platform number within an Operational Point.</para>
    ///   <para>era:XMLName : OPTrackPlatformIdentification^^xsd:string</para>
    ///   <para>rdfs:label : Identification of platform</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.3.5^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.0.6.2^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:created : 2021-09-13^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/platformId">era:platformId</a>
    /// </summary>
    let platformId = _prefixId.prefix "platformId"
    /// <summary>
    ///   <para>rdfs:label : Platform</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.0.6^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/platformObjParameter">era:platformObjParameter</a>
    /// </summary>
    let platformObjParameter = _prefixId.prefix "platformObjParameter"
    /// <summary>
    ///   <para>rdfs:label : Portable boarding aids</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Description of any portable boarding aids if considered in the design of the vehicle for meeting the PRM TSI requirements.</para>
    ///   <para>era:eratvIndex : 4.12.3.3^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/portableBoardingAids">era:portableBoardingAids</a>
    /// </summary>
    let portableBoardingAids = _prefixId.prefix "portableBoardingAids"
    /// <summary>
    ///   <para>era:rinfIndex : 1.2.4.1^^xsd:stringera:rinfIndex : 1.1.1.0.1.2^^xsd:string</para>
    ///   <para>skos:altLabel : Internal connection</para>
    ///   <para>dcterms:modified : 2021-08-03^^xsd:date</para>
    ///   <para>rdfs:comment : Determines the position of the topological object A in a relation.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2021-04-03^^xsd:date</para>
    ///   <para>rdfs:label : Position on A</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/positionOnA">era:positionOnA</a>
    /// </summary>
    let positionOnA = _prefixId.prefix "positionOnA"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-04-03^^xsd:date</para>
    ///   <para>rdfs:label : Position on B</para>
    ///   <para>era:rinfIndex : 1.2.4.1^^xsd:stringera:rinfIndex : 1.1.1.0.1.2^^xsd:string</para>
    ///   <para>skos:altLabel : Internal connection</para>
    ///   <para>rdfs:comment : Determines the position of the topological object B in a relation.</para>
    ///   <para>dcterms:modified : 2021-08-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/positionOnB">era:positionOnB</a>
    /// </summary>
    let positionOnB = _prefixId.prefix "positionOnB"
    /// <summary>
    ///   <para>rdfs:comment : Possibility of preventing the use of the regenerative brake (only if fitted with regenerative brake).</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.7.4.3.2^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Prevent regenerative brake use</para>
    ///   <a href="http://data.europa.eu/949/preventRegenerativeBrakeUse">era:preventRegenerativeBrakeUse</a>
    /// </summary>
    let preventRegenerativeBrakeUse = _prefixId.prefix "preventRegenerativeBrakeUse"
    /// <summary>
    ///   <para>rdfs:comment : Denotes a the previous VehicleType.</para>
    ///   <para>rdfs:label : Previous vehicle type</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-06-15^^xsd:date</para>
    ///   <para>dcterms:created : 2022-06-15^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/previousVehicleType">era:previousVehicleType</a>
    /// </summary>
    let previousVehicleType = _prefixId.prefix "previousVehicleType"
    /// <summary>
    ///   <para>era:tsiOPEAppendixD2Index : 2.2.2^^xsd:string</para>
    ///   <para>rdfs:comment : Primary location code developed for information exchange in accordance with the TSIs relating to the telematics applications subsystem.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:rinfIndex : 1.2.0.0.0.3^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-12-03^^xsd:datedcterms:modified : 2025-01-30^^xsd:date</para>
    ///   <para>era:XMLName : OPTafTapCode^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:dependencyNote : Applicable only in case when a primary location exists</para>
    ///   <para>rdfs:label : primary location</para>
    ///   <a href="http://data.europa.eu/949/primaryLocation">era:primaryLocation</a>
    /// </summary>
    let primaryLocation = _prefixId.prefix "primaryLocation"
    /// <summary>
    ///   <para>era:rinfIndex : 1.2.0.0.0.3^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.2.2^^xsd:string</para>
    ///   <para>era:XMLName : OPTafTapCode^^xsd:string</para>
    ///   <para>rdfs:label : primary location code</para>
    ///   <para>rdfs:comment : Primary location code developed for information exchange in accordance with the TSIs relating to the telematics applications subsystem.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2024-06-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/primaryLocationCode">era:primaryLocationCode</a>
    /// </summary>
    let primaryLocationCode = _prefixId.prefix "primaryLocationCode"
    /// <summary>
    ///   <para>rdfs:label : primary location name</para>
    ///   <para>dcterms:modified : 2025-08-29^^xsd:date</para>
    ///   <para>dcterms:created : 2024-06-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/primaryLocationName">era:primaryLocationName</a>
    /// </summary>
    let primaryLocationName = _prefixId.prefix "primaryLocationName"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Number of priority seats.</para>
    ///   <para>rdfs:label : Priority seats</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:datedcterms:modified : 2024-11-25^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.12.2.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/prioritySeats">era:prioritySeats</a>
    /// </summary>
    let prioritySeats = _prefixId.prefix "prioritySeats"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Prm accessible toilets</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:datedcterms:modified : 2024-11-25^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.12.2.3^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Number of PRM accessible toilets.</para>
    ///   <a href="http://data.europa.eu/949/prmAccessibleToilets">era:prmAccessibleToilets</a>
    /// </summary>
    let prmAccessibleToilets = _prefixId.prefix "prmAccessibleToilets"
    /// <summary>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>skos:scopeNote : The technical number is made up of the wagon compatibility code (1 letter) and the standard combined transport profile number (2 digits when width &lt;= 2500 mm or 3 digits when 2500 &lt; width &lt;= 2600 mm).
    /// Additional values than the already identified in the list above are possible. They will be introduced by the Agency on request via a process of change request.</para>
    ///   <para>era:rinfIndex : 1.1.1.1.3.5^^xsd:string</para>
    ///   <para>era:XMLName : ILL_ProfileNumSemiTrailers^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Standard combined transport profile number for semi-trailers</para>
    ///   <para>era:legalDeadline : by 16 March 2019 at the latest for lines belonging to the TEN (1.1.1.1.2.1)</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Coding for combined transport for semi-trailers (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B].</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/profileNumberSemiTrailers">era:profileNumberSemiTrailers</a>
    /// </summary>
    let profileNumberSemiTrailers = _prefixId.prefix "profileNumberSemiTrailers"
    /// <summary>
    ///   <para>era:XMLName : ILL_ProfileNumSwapBodies^^xsd:string</para>
    ///   <para>rdfs:comment : Coding for combined transport with swap bodies (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B]</para>
    ///   <para>skos:scopeNote : The technical number is made up of the wagon compatibility code (1 letter) and the standard combined transport profile number (2 digits when width &lt;= 2550 mm or 3 digits when, 2550 &lt; width &lt;= 2600 mm). </para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.3.4^^xsd:string</para>
    ///   <para>era:legalDeadline : by 16 March 2019 at the latest for lines belonging to the TEN (1.1.1.1.2.1)</para>
    ///   <para>rdfs:label : Standard combined transport profile number for swap bodies</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/profileNumberSwapBodies">era:profileNumberSwapBodies</a>
    /// </summary>
    let profileNumberSwapBodies = _prefixId.prefix "profileNumberSwapBodies"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://eur-lex.europa.eu/legal-content/EN/TXT/?uri=CELEX%3A32023R1695&amp;qid=1694158367331#d1295e32-554-1^^xsd:anyURIrdfs:seeAlso : https://www.era.europa.eu/system/files/2023-11/%5BK%5D%20ERA-TD-2011-09-INT-Coded%20restrictions-final.pdf^^xsd:anyURI</para>
    ///   <para>era:rinfIndex : 1.1.1.3.5.3^^xsd:stringera:rinfIndex : 1.2.1.1.4.1^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>skos:scopeNote : The list is in line with ERA/TD/2011-09/INT (v1.13), Table 3, and is now in 3.3 of the annex II of TSI CCS.</para>
    ///   <para>rdfs:comment : Indication of which class B system is installed.</para>
    ///   <para>rdfs:label : Train protection legacy system</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : 16 January 2020</para>
    ///   <para>dcterms:created : 2020-08-31^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.13.1.5^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : CPO_LegacyTrainProtection^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/protectionLegacySystem">era:protectionLegacySystem</a>
    /// </summary>
    let protectionLegacySystem = _prefixId.prefix "protectionLegacySystem"
    /// <summary>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2025-03-04^^xsd:date</para>
    ///   <para>era:legalDeadline : 1 January 2021era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>era:XMLName : CRG_RoamingPublic^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:label : Existence of GSM-R roaming to public networks</para>
    ///   <para>skos:scopeNote : Sections of EIRENE not covered by references in TSI.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.1.2.6^^xsd:stringera:rinfIndex : 1.1.1.3.3.6^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>era:dependencyNote : GSM-R must be installed for this parameter to be applicable</para>
    ///   <para>rdfs:comment : Existence of roaming to a public network.
    ///
    ///                          In case of Y, provide the name of the public network(s) under parameter "Details on GSM-R roaming to public networks".</para>
    ///   <a href="http://data.europa.eu/949/publicNetworkRoaming">era:publicNetworkRoaming</a>
    /// </summary>
    let publicNetworkRoaming = _prefixId.prefix "publicNetworkRoaming"
    /// <summary>
    ///   <para>era:legalDeadline : 1 January 2021era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.3.7^^xsd:stringera:rinfIndex : 1.2.1.1.2.7^^xsd:string</para>
    ///   <para>rdfs:comment : If roaming to public networks is configured, please indicate to which networks, for which users and in which areas.</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-03-04^^xsd:date</para>
    ///   <para>era:dependencyNote : Mandatory if GSM-R is installed and era:publicNetworkRoaming is 'true'. Otherwise, it is not applicable.</para>
    ///   <para>era:XMLName : CRG_RoamingPublicDetails^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>skos:scopeNote : List if any GSM-R functionality is not available when roaming to a public network (e.g. REC, Functional Addressing, Group Calls).
    /// Please also add if there is any operational restriction for vehicles that cannot roam into any of the available public networks.</para>
    ///   <para>rdfs:label : Details on GSM-R roaming to public networks</para>
    ///   <a href="http://data.europa.eu/949/publicNetworkRoamingDetails">era:publicNetworkRoamingDetails</a>
    /// </summary>
    let publicNetworkRoamingDetails = _prefixId.prefix "publicNetworkRoamingDetails"
    /// <summary>
    ///   <para>era:tsiOPEAppendixD3Index : 1.5.11^^xsd:string</para>
    ///   <para>skos:scopeNote : See: TSI CCS (Subset 26, chapter 7. 7.5.1.122 Q_NVDRIVER_ADHES)</para>
    ///   <para>rdfs:comment : Qualifier determining whether the driver is allowed to modify the adhesion factor used by the ETCS on-board to calculate the braking curves.
    /// According to the specification referenced in Appendix A-1, index [C]</para>
    ///   <para>dcterms:created : 2024-04-18^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.16.11^^xsd:stringera:rinfIndex : 1.1.1.3.2.16.11^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:label : Q_NVDRIVER_ADHES</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-20^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/qNvdriverAdhes">era:qNvdriverAdhes</a>
    /// </summary>
    let qNvdriverAdhes = _prefixId.prefix "qNvdriverAdhes"
    /// <summary>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.16.2^^xsd:stringera:rinfIndex : 1.2.1.1.1.16.2^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>skos:scopeNote : According to the specification referenced in Appendix A-1, index [C] - TSI CCS (Subset-026, chapter 7, 7.5.1.123 Q_NVEMRRLS)</para>
    ///   <para>rdfs:comment : Qualifier defining whether the application of the emergency brake for reasons other than a trip can be revoked as soon as the conditions for it have disappeared or after the train has come to a complete standstill.
    /// According to the specification referenced in Appendix A-1, index [C]</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>rdfs:label : Q_NVEMRRLS</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.5.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/qNvemrrls">era:qNvemrrls</a>
    /// </summary>
    let qNvemrrls = _prefixId.prefix "qNvemrrls"
    /// <summary>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.16.12^^xsd:stringera:rinfIndex : 1.1.1.3.2.16.12^^xsd:string</para>
    ///   <para>rdfs:comment : Permission to use service brake in target speed monitoring</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:label : Q_NVSBTSMPERM</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.5.12^^xsd:string</para>
    ///   <para>skos:scopeNote : See: TSI CCS (Subset-026, chapter 7. 7.5.1.124 Q_NVSBTSMPERM)</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <a href="http://data.europa.eu/949/qNvsbtsmperm">era:qNvsbtsmperm</a>
    /// </summary>
    let qNvsbtsmperm = _prefixId.prefix "qNvsbtsmperm"
    /// <summary>
    ///   <para>era:eratvIndex : 4.5.4^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Quasi static guiding force</para>
    ///   <para>dcterms:created : 2021-08-26^^xsd:date</para>
    ///   <para>rdfs:comment : Quasi-static guiding force (if exceeds the limit defined in TSI or not defined in the TSI), given in kN.</para>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/quasiStaticGuidingForce">era:quasiStaticGuidingForce</a>
    /// </summary>
    let quasiStaticGuidingForce = _prefixId.prefix "quasiStaticGuidingForce"
    /// <summary>
    ///   <para>dcterms:created : 2020-11-23^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2020-11-23^^xsd:date</para>
    ///   <para>rdfs:comment : Country where a vehicle may operate without noise restrictions.</para>
    ///   <para>rdfs:label : Quieter route exempted country</para>
    ///   <a href="http://data.europa.eu/949/quieterRoutesExemptedCountry">era:quieterRoutesExemptedCountry</a>
    /// </summary>
    let quieterRoutesExemptedCountry = _prefixId.prefix "quieterRoutesExemptedCountry"
    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.3.3.12^^xsd:stringera:rinfIndex : 1.2.1.1.2.13^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-12-05^^xsd:datedcterms:modified : 2025-09-03^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.4^^xsd:string</para>
    ///   <para>rdfs:comment : Unique identification of the GSM-R network the calling mobile station has to register with, as defined in the specification referenced in Appendix A-1, index [C]</para>
    ///   <para>era:dependencyNote : GSM-R must be installed for this parameter to be applicable.</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>skos:editorialNote : (sh:minCount 1)^^xsd:string</para>
    ///   <para>skos:scopeNote : According to the specification referenced in TSI CCS.</para>
    ///   <para>rdfs:label : Radio Network ID</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:formatNote : NNNNNN with N a decimal number (0 9).^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/radioNetworkId">era:radioNetworkId</a>
    /// </summary>
    let radioNetworkId = _prefixId.prefix "radioNetworkId"

    /// <summary>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Special conditions implemented on-board to switch over between different radio systems. Given as combination of systems installed on board ('System XX'_'System YY').</para>
    ///   <para>era:eratvIndex : 4.13.2.4^^xsd:string</para>
    ///   <para>rdfs:label : Radio switch over special conditions</para>
    ///   <a href="http://data.europa.eu/949/radioSwitchOverSpecialConditions">era:radioSwitchOverSpecialConditions</a>
    /// </summary>
    let radioSwitchOverSpecialConditions = _prefixId.prefix "radioSwitchOverSpecialConditions"

    /// <summary>
    ///   <para>era:eratvIndex : 4.6.5^^xsd:string</para>
    ///   <para>era:XMLName : ITP_RailInclination^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2022-10-20^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : INF TSI:4.2.4.7^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:formatNote : In XML the accepted value is NN, where N is a digit from 0 to 9.</para>
    ///   <para>rdfs:comment : An angle defining the inclination of the head of a rail relative to the running surface.</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Rail inclination</para>
    ///   <para>era:rinfIndex : 1.1.1.1.4.3^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>skos:scopeNote : This inclination is in most cases expressed for MS globally, but anyway it requires presentation for the specific track, when in one SoL more values occur.
    /// An angle defining the inclination of the head of a rail when installed in the track relative to the plane of the rails (running surface), equal to the angle between the axis of symmetry of the rail (or of an equivalent symmetrical rail having the same rail head profile) and the perpendicular to the plane of the rails. The typical values for the railway inclination are 1:20, 1:30, 1:40.</para>
    ///   <a href="http://data.europa.eu/949/railInclination">era:railInclination</a>
    /// </summary>
    let railInclination = _prefixId.prefix "railInclination"
    /// <summary>
    ///   <para>dcterms:created : 2022-11-04^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : (deprecated) Type of railway system. Can be "High-speed" or "Conventional". Deprecated due to the lack of information</para>
    ///   <para>rdfs:label : Rail system type</para>
    ///   <a href="http://data.europa.eu/949/railSystemType">era:railSystemType</a>
    /// </summary>
    let railSystemType = _prefixId.prefix "railSystemType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Part of the raised pantographs distance and speed of a track that corresponds to the minimum distance between pantographs, in metres.</para>
    ///   <para>rdfs:label : Requirements for spacing between raised pantographs, at the given speed</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>skos:definition : The raised pantographs distance and speed is the indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.</para>
    ///   <a href="http://data.europa.eu/949/raisedPantographsDistance">era:raisedPantographsDistance</a>
    /// </summary>
    let raisedPantographsDistance = _prefixId.prefix "raisedPantographsDistance"

    /// <summary>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <para>rdfs:label : (deprecated) Requirements for number of raised pantographs and spacing between them, at the given speed</para>
    ///   <para>skos:editorialNote : Deprecated because of replacement by a class and three integer properties The reason is that the property is composed of three values: [N] is number of pantographs; [NNN] is minimum distance between pantographs, in metres; [NNN] is the speed considered in km/h.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:comment : Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/raisedPantographsDistanceAndSpeed">era:raisedPantographsDistanceAndSpeed</a>
    /// </summary>
    let raisedPantographsDistanceAndSpeed = _prefixId.prefix "raisedPantographsDistanceAndSpeed"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Requirements for number of raised pantographs, at the given speed</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>rdfs:comment : Part of the raised pantographs distance and speed of a track that corresponds to the number of pantographs.</para>
    ///   <para>skos:definition : The raised pantographs distance and speed is the indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/raisedPantographsNumber">era:raisedPantographsNumber</a>
    /// </summary>
    let raisedPantographsNumber = _prefixId.prefix "raisedPantographsNumber"
    /// <summary>
    ///   <para>dcterms:modified : 2025-05-12^^xsd:datedcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:label : Raised pantographs speed</para>
    ///   <para>skos:definition : The raised pantographs distance and speed is the indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.</para>
    ///   <para>rdfs:comment : Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/raisedPantographsSpeed">era:raisedPantographsSpeed</a>
    /// </summary>
    let raisedPantographsSpeed = _prefixId.prefix "raisedPantographsSpeed"
    /// <summary>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.7^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:comment : Unique RBC identification (NID_C+NID_RBC)  as defined in the specification referenced in Appendix A-1, index [C] (TSI CCS).</para>
    ///   <para>era:XMLName : CEN_IDRBC^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.17^^xsd:stringera:rinfIndex : 1.2.1.1.1.17^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ID of ERTMS/ETCS Radio Block Center</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>dcterms:created : 2024-04-18^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:formatNote : NNNN NNNN with N a decimal number (0÷9)^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/rbcID">era:rbcID</a>
    /// </summary>
    let rbcID = _prefixId.prefix "rbcID"
    /// <summary>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.7^^xsd:string</para>
    ///   <para>era:XMLName : CEN_PhoneNumbRBC^^xsd:string</para>
    ///   <para>era:formatNote : NNNN NNNN NNNN NNNN with N a decimal number (0-9)^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2024-12-05^^xsd:date</para>
    ///   <para>rdfs:comment : Unique RBC calling number (NID_RADIO) as defined in the specification referenced in Appendix A-1, index [C].</para>
    ///   <para>rdfs:label : Phone number of ERTMS/ETCS Radio Block Center</para>
    ///   <para>dcterms:created : 2024-04-18^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.17^^xsd:stringera:rinfIndex : 1.2.1.1.1.17^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:applicable : ^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <a href="http://data.europa.eu/949/rbcPhone">era:rbcPhone</a>
    /// </summary>
    let rbcPhone = _prefixId.prefix "rbcPhone"

    /// <summary>
    ///   <para>era:tsiOPEAppendixD3Index : 1.4^^xsd:string</para>
    ///   <para>rdfs:label : Reasons for which an ETCS Radio Block Center can reject a train</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:comment : List of cases subject to system design choices made by the infrastructure manager according to the specification referenced in Appendix A-1, index [C]</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.15^^xsd:stringera:rinfIndex : 1.1.1.3.2.15^^xsd:string</para>
    ///   <para>dcterms:created : 2022-11-07^^xsd:date</para>
    ///   <para>skos:scopeNote : 1. Distinguish between mandatory and optional: decision was only to record the mandatory ones, but optional reasons can be added.
    /// 2. Providing the non-implemented CR-solution which have been accepted by IM, after check/approval with RU's, is also allowed.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <a href="http://data.europa.eu/949/reasonsEtcsRadioBlockCenterReject">era:reasonsEtcsRadioBlockCenterReject</a>
    /// </summary>
    let reasonsEtcsRadioBlockCenterReject = _prefixId.prefix "reasonsEtcsRadioBlockCenterReject"

    /// <summary>
    ///   <para>rdfs:comment : Sections where two steady red lights are required in accordance with TSI OPErdfs:comment : Sections where permissive driving is possible in accordance with point 4.2.2.1.2 of TSI OPE</para>
    ///   <para>dcterms:modified : 2025-06-16^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2025-09-10^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2025-11-12^^xsd:date</para>
    ///   <para>skos:scopeNote : From Regulation (EU) 2019/773 (TSI OPE) on tail marking in normal operation: this parameter is only for
    /// - freight trains during the transition phase until 31st December 2025 and
    /// - specific cases of Belgium, France, Italy, Portugal, and Spain who may continue to apply notified national rules that require freight trains to be equipped with 2 steady red lights as a condition to run on sections of their network, where this is justified by operating practices already in place and/or national rules notified before end of January 2019.
    /// Cooperation with neighbouring countries:
    /// In the meantime Member States concerned, in particular at the request of the railway undertakings, shall perform an assessment with a view to accept the use of 2 reflective plates in one or more sections of their network if the result of the assessment is positive and define appropriate conditions, which shall be based upon an assessment of the risks and operational requirements. This assessment shall be completed within a maximum period of 6 months after receiving the railway undertaking's request. The acceptance of reflective plates shall be granted, unless the Member State can duly justify the refusal based on the negative result of the assessment.
    /// Member States shall in particular endeavour to permit the use of reflective plates on rail freight corridors, with a view to prioritise the current bottlenecks. These sections and details of any conditions pertaining to them shall be recorded in the RINF. Until the information is encoded in RINF, the infrastructure manager shall ensure the information is communicated to railway undertakings by other appropriate means. The infrastructure manager shall identify the sections of lines on which 2 steady red lights are required in the RINF.</para>
    ///   <para>rdfs:seeAlso : art 4.2.2.1.3.2. of Implementing Regulation (EU) 2019/773 'Freight trains'^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>rdfs:label : Steady red lights required</para>
    ///   <para>era:rinfIndex : 1.1.1.1.7.10^^xsd:string</para>
    ///   <para>era:legalDeadline : 1 January 2021</para>
    ///   <para>era:XMLName : IHS_RedLights^^xsd:string</para>
    ///   <para>skos:altLabel : Permissive driving allowed</para>
    ///   <para>era:formatNote : in XML: Y/N^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/redLightsRequired">era:redLightsRequired</a>
    /// </summary>
    let redLightsRequired = _prefixId.prefix "redLightsRequired"
    /// <summary>
    ///   <para>dcterms:created : 2024-10-24^^xsd:date</para>
    ///   <para>rdfs:comment : Relates an operational point that is a border point with an instance of the list of reference border points that are specified in the RINF Application Guide.</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2025-02-24^^xsd:date</para>
    ///   <para>rdfs:label : reference border point</para>
    ///   <a href="http://data.europa.eu/949/referenceBorderPoint">era:referenceBorderPoint</a>
    /// </summary>
    let referenceBorderPoint = _prefixId.prefix "referenceBorderPoint"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Pass-by noise level was measured under reference conditions.</para>
    ///   <para>era:eratvIndex : 4.11.2^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Reference pass-by noise level</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/referencePassByNoiseLevel">era:referencePassByNoiseLevel</a>
    /// </summary>
    let referencePassByNoiseLevel = _prefixId.prefix "referencePassByNoiseLevel"

    /// <summary>
    ///   <para>rdfs:label : Parameters related to electromagnetic interferences</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.8^^xsd:stringera:rinfIndex : 1.1.1.3.9^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/relatedElectromagneticInterferencesDataParameter">era:relatedElectromagneticInterferencesDataParameter</a>
    /// </summary>
    let relatedElectromagneticInterferencesDataParameter = _prefixId.prefix "relatedElectromagneticInterferencesDataParameter"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:comment : Distance in meters to the danger point</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.3.3^^xsd:stringera:tsiOPEAppendixD2Index : 2.2.3^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:formatNote : NNN^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>skos:scopeNote : Danger point is defined in ERTMS/ETCS - Glossary of Terms and Abbreviations - version  4.0.0 - date 05/07/2023. For installations without ERTMS, the signalling definition is equivalent.
    /// See: TSI OPE Appendix D2 (2.3.3), the danger point relative distance from the signal itself.</para>
    ///   <para>rdfs:label : Relative distance of the danger point</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:rinfIndex : 1.2.1.0.8.4^^xsd:stringera:rinfIndex : 1.1.1.3.14.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/relativeDistanceDangerPoint">era:relativeDistanceDangerPoint</a>
    /// </summary>
    let relativeDistanceDangerPoint = _prefixId.prefix "relativeDistanceDangerPoint"
    /// <summary>
    ///   <para>rdfs:label : Relative position</para>
    ///   <para>rdfs:comment : Indicates the position of an object relative to the linear coordinates of the associated topological object.</para>
    ///   <para>dcterms:modified : 2023-11-10^^xsd:date</para>
    ///   <para>dcterms:created : 2021-04-01^^xsd:date</para>
    ///   <para>skos:editorialNote :  The reason for deprecation is that this property is not specified in the latest legal text nor the RINF application guide. Also, no data has been provided for this property.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/relativePosition">era:relativePosition</a>
    /// </summary>
    let relativePosition = _prefixId.prefix "relativePosition"
    /// <summary>
    ///   <para>rdfs:label : Sanding override by driver required</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:comment : Indication whether possibility to activate/deactivate sanding devices by driver, according to instructions from the Infrastructure Manager, is required or not. Deprecated according to the amendment to the Regulation (EU) 2019/777.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/requiredSandingOverride">era:requiredSandingOverride</a>
    /// </summary>
    let requiredSandingOverride = _prefixId.prefix "requiredSandingOverride"

    /// <summary>
    ///   <para>rdfs:label : Requirements for rolling stock</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.5^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/requirementsRollingStockDataParameter">era:requirementsRollingStockDataParameter</a>
    /// </summary>
    let requirementsRollingStockDataParameter = _prefixId.prefix "requirementsRollingStockDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Requirements for rolling stock</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.5^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/requirementsRollingStockObjParameter">era:requirementsRollingStockObjParameter</a>
    /// </summary>
    let requirementsRollingStockObjParameter = _prefixId.prefix "requirementsRollingStockObjParameter"

    /// <summary>
    ///   <para>rdfs:label : Restricted dangerous goods</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:created : 2025-09-30^^xsd:date</para>
    ///   <para>rdfs:comment : Description of the type of dangerous good that are not allowed in the tunnel</para>
    ///   <a href="http://data.europa.eu/949/restrictedDangerousGood">era:restrictedDangerousGood</a>
    /// </summary>
    let restrictedDangerousGood = _prefixId.prefix "restrictedDangerousGood"

    /// <summary>
    ///   <para>rdfs:label : Restricted periods of time for dangerous goods transportation</para>
    ///   <para>skos:editorialNote : The use of string for this property is temporary until there is harmonization of the concrete type from time ontology.</para>
    ///   <para>rdfs:comment : Describes the period of time for which the transport of dangerous goods is not allowed in the Section of Line</para>
    ///   <para>dcterms:created : 2025-09-30^^xsd:date</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/restrictedPeriodOfTimeDangerousGood">era:restrictedPeriodOfTimeDangerousGood</a>
    /// </summary>
    let restrictedPeriodOfTimeDangerousGood = _prefixId.prefix "restrictedPeriodOfTimeDangerousGood"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Specific types of vehicles restricted in the tunnel.</para>
    ///   <para>rdfs:label : Restricted type of vehicle in tunnel</para>
    ///   <para>dcterms:created : 2025-09-30^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/restrictedTypeOfVehicleInTunnel">era:restrictedTypeOfVehicleInTunnel</a>
    /// </summary>
    let restrictedTypeOfVehicleInTunnel = _prefixId.prefix "restrictedTypeOfVehicleInTunnel"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : RINF index</para>
    ///   <para>rdfs:comment : Index code used in the original definition of a parameter in RINF.</para>
    ///   <para>dcterms:modified : 2024-08-13^^xsd:datedcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>dcterms:created : 2020-11-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/rinfIndex">era:rinfIndex</a>
    /// </summary>
    let rinfIndex = _prefixId.prefix "rinfIndex"

    /// <summary>
    ///   <para>rdfs:label : RINF Technical characteristic</para>
    ///   <para>dcterms:modified : 2025-02-25^^xsd:date</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/rinfTechnicalDataCharacteristic">era:rinfTechnicalDataCharacteristic</a>
    /// </summary>
    let rinfTechnicalDataCharacteristic = _prefixId.prefix "rinfTechnicalDataCharacteristic"

    /// <summary>
    ///   <para>rdfs:label : RINF Technical characteristic</para>
    ///   <para>dcterms:modified : 2025-02-25^^xsd:date</para>
    ///   <para>dcterms:created : 2024-10-28^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/rinfTechnicalObjectCharacteristic">era:rinfTechnicalObjectCharacteristic</a>
    /// </summary>
    let rinfTechnicalObjectCharacteristic = _prefixId.prefix "rinfTechnicalObjectCharacteristic"

    /// <summary>
    ///   <para>rdfs:label : role</para>
    ///   <para>dcterms:created : 2024-06-03^^xsd:date</para>
    ///   <para>dcterms:modified : 2024-10-24^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates the relationship of a Body to the organisation roles that it can play.</para>
    ///   <a href="http://data.europa.eu/949/role">era:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>rdfs:label : role of</para>
    ///   <para>rdfs:comment : Indicates the corresponding Body that plays a certain organisation role.</para>
    ///   <para>dcterms:created : 2024-10-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/roleOf">era:roleOf</a>
    /// </summary>
    let roleOf = _prefixId.prefix "roleOf"
    /// <summary>
    ///   <para>era:rinfIndex : 1.2.1.0.5.7^^xsd:stringera:rinfIndex : 1.1.1.1.8.10^^xsd:stringera:rinfIndex : 1.2.2.0.5.7^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>skos:scopeNote : Wherever category B is not needed, generally the category A has to be understood as the default value.  None  shall be selected when none of A or B fire category is applied for a specific tunnel.
    /// For tunnels shorter than 1km, the fire category according to SRT TSI does not exist.</para>
    ///   <para>era:dependencyNote : Mandatory for tunnels longer than 1 km</para>
    ///   <para>rdfs:seeAlso : SRT TSI: 4.2.3.3.4
    /// LOC&amp;PAS TSI : 4.2.10.4.4^^xsd:string</para>
    ///   <para>era:XMLName : ITU_FireCatReq^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.3^^xsd:string</para>
    ///   <para>rdfs:comment : Categorisation how a passenger train with a fire on board will continue to operate for a defined time periodrdfs:comment : Passenger train fire category in accordance with point 4.1.4 of TSI LOC&amp;PAS.</para>
    ///   <para>rdfs:label : Fire category of rolling stock required</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <a href="http://data.europa.eu/949/rollingStockFireCategory">era:rollingStockFireCategory</a>
    /// </summary>
    let rollingStockFireCategory = _prefixId.prefix "rollingStockFireCategory"
    /// <summary>
    ///   <para>rdfs:label : Route book specific parameters</para>
    ///   <para>dcterms:created : 2025-01-30^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.0.0.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/routeBookDataParameter">era:routeBookDataParameter</a>
    /// </summary>
    let routeBookDataParameter = _prefixId.prefix "routeBookDataParameter"
    /// <summary>
    ///   <para>rdfs:label : Route book specific parameters</para>
    ///   <para>dcterms:created : 2025-01-30^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.0.0.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/routeBookObjectParameter">era:routeBookObjectParameter</a>
    /// </summary>
    let routeBookObjectParameter = _prefixId.prefix "routeBookObjectParameter"
    /// <summary>
    ///   <para>rdfs:label : Rules and restrictions</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.3^^xsd:stringera:rinfIndex : 1.1.1.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/rulesDataParameter">era:rulesDataParameter</a>
    /// </summary>
    let rulesDataParameter = _prefixId.prefix "rulesDataParameter"
    /// <summary>
    ///   <para>rdfs:label : Rules and restrictions</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.3^^xsd:stringera:rinfIndex : 1.1.1.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/rulesObjParameter">era:rulesObjParameter</a>
    /// </summary>
    let rulesObjParameter = _prefixId.prefix "rulesObjParameter"

    /// <summary>
    ///   <para>era:rinfIndex : 1.2.1.1.1.11^^xsd:stringera:rinfIndex : 1.1.1.3.2.11^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : CPE_SafeLenghtInf^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:comment : Indication whether safe consist train length information from on-board is required to access the line for safety reasons and the required safety integrity level.</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present and the level of ETCS is 2 (parameter 1.1.1.3.2.1).</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>skos:scopeNote : See: TSI CCS (Subset-026, Chapter 7, 7.5.1.112.1 and P10)</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:label : Safe consist length information from on-board necessary for access the line and SIL</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/safeConsistLengthInformationNecessary">era:safeConsistLengthInformationNecessary</a>
    /// </summary>
    let safeConsistLengthInformationNecessary = _prefixId.prefix "safeConsistLengthInformationNecessary"

    /// <summary>
    ///   <para>era:rinfIndex : 1.2.0.0.0.7.1^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:comment : Document providing the schematic overview of the operational point</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:label : Schematic overview of the operational point</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/schematicOverviewOP">era:schematicOverviewOP</a>
    /// </summary>
    let schematicOverviewOP = _prefixId.prefix "schematicOverviewOP"
    /// <summary>
    ///   <para>rdfs:label : scope</para>
    ///   <para>rdfs:comment : Annotation property used in SHACL shapes. Indicates if the SHACL shape is validating a property of a specific instance ("local"), or if it needs to check other instances ("global"). For example, SHACL shape to validate no repeated ids within a specific track.</para>
    ///   <para>dcterms:created : 2024-11-04^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/scope">era:scope</a>
    /// </summary>
    let scope = _prefixId.prefix "scope"
    /// <summary>
    ///   <para>rdfs:label : SHACL shape validation rule</para>
    ///   <para>rdfs:comment : Annotation used to point to the SHACL shape that implements the validation for a certain RINF parameter (property). Each shape contains constraints for valid datatypes, patterns, min and max count, valid SKOS values and business rules.</para>
    ///   <para>dcterms:created : 2024-11-04^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/shaclShapeValidationRule">era:shaclShapeValidationRule</a>
    /// </summary>
    let shaclShapeValidationRule = _prefixId.prefix "shaclShapeValidationRule"

    /// <summary>
    ///   <para>rdfs:comment : Shortest distance between two pantographs in contact with the OCL (to be indicated for each energy supply system the vehicle is equipped for; to be indicated for single and, if applicable, multiple operation) (only if number of raised pantographs is more than 1).</para>
    ///   <para>rdfs:label : Shortest distance between pantographs in contact with OCL</para>
    ///   <para>dcterms:modified : 2021-09-15^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.10.8^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/shortestDistanceBetweenPantographsInContactWithOCL">era:shortestDistanceBetweenPantographsInContactWithOCL</a>
    /// </summary>
    let shortestDistanceBetweenPantographsInContactWithOCL = _prefixId.prefix "shortestDistanceBetweenPantographsInContactWithOCL"

    /// <summary>
    ///   <para>rdfs:label : on side</para>
    ///   <para>dcterms:created : 2024-04-18^^xsd:date</para>
    ///   <para>rdfs:comment : Indication of the position of the signal in relation to the track in the running direction from the origin of the referencing system (e.g., direction of the main line)</para>
    ///   <para>dcterms:modified : 2025-03-10^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/side">era:side</a>
    /// </summary>
    let side = _prefixId.prefix "side"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-10^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-08-10^^xsd:datedcterms:modified : 2024-11-11^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Reference to a related siding.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Siding</para>
    ///   <a href="http://data.europa.eu/949/siding">era:siding</a>
    /// </summary>
    let siding = _prefixId.prefix "siding"
    /// <summary>
    ///   <para>rdfs:label : Siding</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/sidingDataParameter">era:sidingDataParameter</a>
    /// </summary>
    let sidingDataParameter = _prefixId.prefix "sidingDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Fixed installations for servicing trains</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.2.0.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/sidingFixedInstalationsDataParameter">era:sidingFixedInstalationsDataParameter</a>
    /// </summary>
    let sidingFixedInstalationsDataParameter = _prefixId.prefix "sidingFixedInstalationsDataParameter"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : OPSidingIdentification^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.2.1.4^^xsd:stringera:tsiOPEAppendixD2Index : 2.2.1^^xsd:string</para>
    ///   <para>dcterms:created : 2021-09-13^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:comment : Unique siding identification or number within an Operational Point.</para>
    ///   <para>rdfs:label : Identification of siding</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.2.0.0.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/sidingId">era:sidingId</a>
    /// </summary>
    let sidingId = _prefixId.prefix "sidingId"
    /// <summary>
    ///   <para>rdfs:label : Siding</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/sidingObjParameter">era:sidingObjParameter</a>
    /// </summary>
    let sidingObjParameter = _prefixId.prefix "sidingObjParameter"
    /// <summary>
    ///   <para>rdfs:label : Signal</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.14^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/signalDataParameter">era:signalDataParameter</a>
    /// </summary>
    let signalDataParameter = _prefixId.prefix "signalDataParameter"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.0.8.1^^xsd:stringera:rinfIndex : 1.1.1.3.14.1^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.2.3^^xsd:stringera:tsiOPEAppendixD2Index : 2.3.3^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:label : Name of signal</para>
    ///   <para>rdfs:comment : Identifier of signal.</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>skos:scopeNote : Operational identifier of the signal (on the track or in OP), as in the operational and maintenance provisions.</para>
    ///   <a href="http://data.europa.eu/949/signalId">era:signalId</a>
    /// </summary>
    let signalId = _prefixId.prefix "signalId"
    /// <summary>
    ///   <para>rdfs:label : Signal</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.14^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/signalObjParameter">era:signalObjParameter</a>
    /// </summary>
    let signalObjParameter = _prefixId.prefix "signalObjParameter"
    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.3.14.3^^xsd:stringera:rinfIndex : 1.2.1.0.8.3^^xsd:string</para>
    ///   <para>skos:example : @prefix era: &lt;http://era.europa.eu/949/&gt; .
    /// @prefix era-orient: &lt;http://data.europa.eu/949/concepts/orientations/&gt; .
    /// @prefix rdf: &lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#&gt; .
    ///
    /// era:signal1 a era:Signal ;
    ///     #signal's position
    ///     era:netReference [
    ///         a era:NetPointReference ;
    ///         era:hasLrsCoordinate [
    ///             a era:LinearPositioningSystemCoordinate ;
    ///             era:kmPost era:kp5 ;
    ///             era:offsetFromKilometricPost 231;
    ///             rdfs:label "5+231"@en ;
    ///         ]
    ///     ];
    ///     #signal's orientation (Normal)
    ///     era:signalOrientation era-orient:00.
    ///
    /// era:kp5 a era:KilometricPost ;
    ///     era:hasLRS [
    ///         a era:LinearPositioningSystem ;
    ///         era:lineId "National line 1"
    ///     ] ;
    ///     era:kmPostName "km 5" ;
    ///     era:measuredDistance 4995 .^^xsd:string</para>
    ///   <para>skos:scopeNote : Indication if the signal is applicable for operation on normal, opposite track direction or if it contains bidirectionally valid information (radio-based system only).
    ///
    /// The position of the signal is given in relation to a line reference, using the era:netReference property. In general it represents the kilometric point on the main line where the signal is positioned, or a distance from an origin point, when there are no kilometric posts available on the tracks/sidings. See the example.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.2.3^^xsd:stringera:tsiOPEAppendixD2Index : 2.3.3^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:comment : Relative position to the line of reference, given in km and indication if the signal refers to normal or opposite track direction</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:label : Signal orientation</para>
    ///   <a href="http://data.europa.eu/949/signalOrientation">era:signalOrientation</a>
    /// </summary>
    let signalOrientation = _prefixId.prefix "signalOrientation"
    /// <summary>
    ///   <para>era:rinfIndex : 1.2.1.0.8.2^^xsd:stringera:rinfIndex : 1.1.1.3.14.2^^xsd:string</para>
    ///   <para>skos:scopeNote : Indicates what function the signal (on the track or in OP) executes in relation to the track/switches.</para>
    ///   <para>rdfs:label : Type of signal</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.3.3^^xsd:stringera:tsiOPEAppendixD2Index : 2.2.3^^xsd:string</para>
    ///   <para>rdfs:comment : Signalling information for Route Book compilation. This list shall include fixed signals that protect danger points</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>dcterms:created : 2022-10-27^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/signalType">era:signalType</a>
    /// </summary>
    let signalType = _prefixId.prefix "signalType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:label : Sleeping places</para>
    ///   <para>rdfs:comment : Number of sleeping places.</para>
    ///   <para>dcterms:modified : 2021-09-15^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.12.1.3^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/sleepingPlaces">era:sleepingPlaces</a>
    /// </summary>
    let sleepingPlaces = _prefixId.prefix "sleepingPlaces"
    /// <summary>
    ///   <para>dcterms:modified : 2021-08-02^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.3.3^^xsd:string</para>
    ///   <para>rdfs:comment : Snow, ice and hail conditions.</para>
    ///   <para>rdfs:label : Snow ice hail conditions</para>
    ///   <a href="http://data.europa.eu/949/snowIceHailConditions">era:snowIceHailConditions</a>
    /// </summary>
    let snowIceHailConditions = _prefixId.prefix "snowIceHailConditions"
    /// <summary>
    ///   <para>rdfs:label : Section of line generic information</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.0.0.0^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/solGenericDataParameter">era:solGenericDataParameter</a>
    /// </summary>
    let solGenericDataParameter = _prefixId.prefix "solGenericDataParameter"
    /// <summary>
    ///   <para>rdfs:label : Section of line generic information</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.0.0.0^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/solGenericObjParameter">era:solGenericObjParameter</a>
    /// </summary>
    let solGenericObjParameter = _prefixId.prefix "solGenericObjParameter"
    /// <summary>
    ///   <para>rdfs:label : Nature of Section of Line</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>era:XMLName : SOLNature^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>rdfs:comment : Kind of section of line expressing size of presented data which depends on fact whether it connects OPs generated by division of a big node into several OPs or not.</para>
    ///   <para>era:rinfIndex : 1.1.0.0.0.6^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/solNature">era:solNature</a>
    /// </summary>
    let solNature = _prefixId.prefix "solNature"
    /// <summary>
    ///   <para>rdfs:label : Special area type</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.6^^xsd:stringera:tsiOPEAppendixD2Index : 3.2.3^^xsd:stringera:tsiOPEAppendixD2Index : 3.2.5^^xsd:stringera:tsiOPEAppendixD2Index : 3.3.5^^xsd:stringera:tsiOPEAppendixD2Index : 3.2.4^^xsd:stringera:tsiOPEAppendixD2Index : 3.3.6^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:created : 2022-10-27^^xsd:date</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.0.0.1.1^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the special area or location types such as safe areas and restricted area types.</para>
    ///   <a href="http://data.europa.eu/949/specialAreaType">era:specialAreaType</a>
    /// </summary>
    let specialAreaType = _prefixId.prefix "specialAreaType"
    /// <summary>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>dcterms:created : 2022-10-27^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.3^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a tunnel with a special area or location.</para>
    ///   <para>rdfs:label : Special tunnel area</para>
    ///   <a href="http://data.europa.eu/949/specialTunnelArea">era:specialTunnelArea</a>
    /// </summary>
    let specialTunnelArea = _prefixId.prefix "specialTunnelArea"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Specialized infrastructure</para>
    ///   <para>rdfs:comment : Special type of service on a line or a section of a line.</para>
    ///   <para>dcterms:created : 2025-09-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/specializedInfrastructure">era:specializedInfrastructure</a>
    /// </summary>
    let specializedInfrastructure = _prefixId.prefix "specializedInfrastructure"
    /// <summary>
    ///   <para>rdfs:comment : Any relevant information from the IM relating to the line layout</para>
    ///   <para>era:legalDeadline : 1 January 2021</para>
    ///   <para>era:XMLName : ILL_SpecificInfo^^xsd:string</para>
    ///   <para>skos:scopeNote : This parameter allows the IM to provide plain text with specific information about the track</para>
    ///   <para>dcterms:modified : 2021-09-10^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>rdfs:label : Specific information</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.3.5.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/specificInformation">era:specificInformation</a>
    /// </summary>
    let specificInformation = _prefixId.prefix "specificInformation"
    let stable = _prefixId.prefix "stable"

    /// <summary>
    ///   <para>era:legalDeadline : 12 months after the adoption of the Article 7 Guide for lines belonging to the TEN (1.1.1.1.2.1)</para>
    ///   <para>rdfs:label : Standard combined transport profile number for containers</para>
    ///   <para>era:rinfIndex : 1.1.1.1.3.8^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:XMLName : ILL_ProfileNumContainers^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:comment : Coding for combined transport for containers (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B]</para>
    ///   <para>dcterms:modified : 2025-02-20^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/standardCombinedTransportContainers">era:standardCombinedTransportContainers</a>
    /// </summary>
    let standardCombinedTransportContainers = _prefixId.prefix "standardCombinedTransportContainers"

    /// <summary>
    ///   <para>era:legalDeadline : 12 months after the adoption of the Article 7 Guide for lines belonging to the TEN (1.1.1.1.2.1)</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:label : Standard combined transport profile number for roller units</para>
    ///   <para>era:rinfIndex : 1.1.1.1.3.9^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Coding for combined transport for roller units (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B]</para>
    ///   <para>dcterms:modified : 2025-02-20^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:XMLName : ILL_ProfileNumRollerUnits^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/standardCombinedTransportRollerUnits">era:standardCombinedTransportRollerUnits</a>
    /// </summary>
    let standardCombinedTransportRollerUnits = _prefixId.prefix "standardCombinedTransportRollerUnits"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Start intrinsic coordinate</para>
    ///   <para>dcterms:modified : 2021-04-01^^xsd:date</para>
    ///   <para>dcterms:created : 2021-04-01^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/startIntrinsicCoordinate">era:startIntrinsicCoordinate</a>
    /// </summary>
    let startIntrinsicCoordinate = _prefixId.prefix "startIntrinsicCoordinate"
    /// <summary>
    ///   <para>era:XMLName : SOLTunnelStart^^xsd:string</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:modified : 2024-02-05^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.8.3^^xsd:string</para>
    ///   <para>rdfs:label : Start of tunnel location</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Part of the Start of tunnel that indicates the Geographical coordinates according to the standard World Geodetic System (WGS). Precision for both geographical latitude and geographical longitude is assumed as [NN.NNNNNNN] in degrees with decimals what gives discretion of 10 cm in the network.
    /// The Start of tunnel is the Geographical coordinates in decimal degrees and km of the line at the beginning of a tunnel.</para>
    ///   <a href="http://data.europa.eu/949/startLocation">era:startLocation</a>
    /// </summary>
    let startLocation = _prefixId.prefix "startLocation"
    /// <summary>
    ///   <para>rdfs:comment : Start offset of the section from the origin.</para>
    ///   <para>dcterms:modified : 2025-01-30^^xsd:date</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <para>rdfs:label : start offset from origin</para>
    ///   <a href="http://data.europa.eu/949/startOffsetFromOrigin">era:startOffsetFromOrigin</a>
    /// </summary>
    let startOffsetFromOrigin = _prefixId.prefix "startOffsetFromOrigin"
    /// <summary>
    ///   <para>rdfs:label : Starting noise level</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : starting noise level given in dB(A).</para>
    ///   <para>era:eratvIndex : 4.11.4^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/startingNoiseLevel">era:startingNoiseLevel</a>
    /// </summary>
    let startingNoiseLevel = _prefixId.prefix "startingNoiseLevel"
    /// <summary>
    ///   <para>rdfs:label : starts at</para>
    ///   <para>rdfs:comment : Specifies the starting point of a linear reference.</para>
    ///   <para>dcterms:created : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/startsAt">era:startsAt</a>
    /// </summary>
    let startsAt = _prefixId.prefix "startsAt"
    /// <summary>
    ///   <para>rdfs:comment : Denoting the state of the certificate Can be in one of the following: Amended, New, Suspended, Withdrawn.</para>
    ///   <para>rdfs:label : State</para>
    ///   <para>dcterms:modified : 2022-06-15^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2022-06-15^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/state">era:state</a>
    /// </summary>
    let state = _prefixId.prefix "state"

    /// <summary>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:label : Static axle load under exceptional payload</para>
    ///   <para>rdfs:comment : Static axle load under exceptional payload.</para>
    ///   <para>era:eratvIndex : 4.5.3.3^^xsd:string</para>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/staticAxleLoadExceptionalPayload">era:staticAxleLoadExceptionalPayload</a>
    /// </summary>
    let staticAxleLoadExceptionalPayload = _prefixId.prefix "staticAxleLoadExceptionalPayload"

    /// <summary>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>rdfs:label : Static axle load under normal payload</para>
    ///   <para>rdfs:comment : Static axle load under normal payload.</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.5.3.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/staticAxleLoadNormalPayload">era:staticAxleLoadNormalPayload</a>
    /// </summary>
    let staticAxleLoadNormalPayload = _prefixId.prefix "staticAxleLoadNormalPayload"
    /// <summary>
    ///   <para>era:eratvIndex : 4.5.3.1^^xsd:string</para>
    ///   <para>rdfs:comment : Static axle load in working order.</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Static axle load in working order</para>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/staticAxleLoadWorkingOrder">era:staticAxleLoadWorkingOrder</a>
    /// </summary>
    let staticAxleLoadWorkingOrder = _prefixId.prefix "staticAxleLoadWorkingOrder"
    /// <summary>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : stationary noise level given in dB(A).</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:label : Stationary noise level</para>
    ///   <para>era:eratvIndex : 4.11.3^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/stationaryNoiseLevel">era:stationaryNoiseLevel</a>
    /// </summary>
    let stationaryNoiseLevel = _prefixId.prefix "stationaryNoiseLevel"
    /// <summary>
    ///   <para>era:eratvIndex : 4.1.10^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-25^^xsd:date</para>
    ///   <para>rdfs:label : Structural category</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Structural category.</para>
    ///   <para>dcterms:modified : 2021-08-25^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/structuralCategory">era:structuralCategory</a>
    /// </summary>
    let structuralCategory = _prefixId.prefix "structuralCategory"
    /// <summary>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:label : Railway location of structures requiring specific checks</para>
    ///   <para>rdfs:comment : Localisation of structures requiring specific checks</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:rinfIndex : 1.1.1.1.2.4.3^^xsd:string</para>
    ///   <para>skos:scopeNote : The railway location identifies the location of the structure in the system of reference of the line to which the track belongs.</para>
    ///   <para>skos:example : The IM A knows that its bridge X might have problems with combination of speed and load above a certain limit values Z, and for that the IM A has a specific procedure W for the check to be done; if the vehicle operation is intended to be within this case (above the limit Z), then RU shall proceed in accordance to the procedure W; therefore the bridge X shall be referred to in the parameter of the RINF:  1.1.1.1.2.4.3 / Railway location of structures requiring specific checks.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>era:XMLName : IPP_StructureCheckLoc^^xsd:string</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>era:dependencyNote : This information is to be linked with parameter 1.1.1.1.2.4.4</para>
    ///   <a href="http://data.europa.eu/949/structureCheckLocation">era:structureCheckLocation</a>
    /// </summary>
    let structureCheckLocation = _prefixId.prefix "structureCheckLocation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 1.5^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-08-03^^xsd:datedcterms:modified : 2025-02-13^^xsd:date</para>
    ///   <para>rdfs:comment : (Deprecated) Vehicle subcategory.</para>
    ///   <a href="http://data.europa.eu/949/subCategory">era:subCategory</a>
    /// </summary>
    let subCategory = _prefixId.prefix "subCategory"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:example : Example: "ETCSbaseline2": describes all ETCS National values (1.1.1.3.2.16 group) </para>
    ///   <para>rdfs:comment : A subset of elements with common characteristics could be identified with a unique name/id.</para>
    ///   <para>dcterms:modified : 2025-09-05^^xsd:date</para>
    ///   <para>rdfs:label : Name of a subset with common characteristics</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/subsetName">era:subsetName</a>
    /// </summary>
    let subsetName = _prefixId.prefix "subsetName"
    /// <summary>
    ///   <para>rdfs:label : subset of</para>
    ///   <para>dcterms:modified : 2025-03-10^^xsd:date</para>
    ///   <para>skos:scopeNote : Whenever a subset (A) is a subset of another subset (B), then the subset (A) inherits all the common characteristics of subset (B), which is that all the infrastructure elements belonging to subset (A) will have as common characteristics the union of parameters (A) and (B).</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>rdfs:comment : Relates a subset with common characteristics with another subset with common characteristics.</para>
    ///   <a href="http://data.europa.eu/949/subsetOf">era:subsetOf</a>
    /// </summary>
    let subsetOf = _prefixId.prefix "subsetOf"
    /// <summary>
    ///   <para>rdfs:label : subsidiary location code</para>
    ///   <para>rdfs:comment : The numeric code for the subsidiary location^^xsd:string</para>
    ///   <para>dcterms:created : 2024-06-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/subsidiaryLocationCode">era:subsidiaryLocationCode</a>
    /// </summary>
    let subsidiaryLocationCode = _prefixId.prefix "subsidiaryLocationCode"
    /// <summary>
    ///   <para>rdfs:label : subsidiary location name</para>
    ///   <para>rdfs:comment : The common name given to the subsidiary location</para>
    ///   <para>dcterms:modified : 2025-09-05^^xsd:date</para>
    ///   <para>dcterms:created : 2024-06-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/subsidiaryLocationName">era:subsidiaryLocationName</a>
    /// </summary>
    let subsidiaryLocationName = _prefixId.prefix "subsidiaryLocationName"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the subsidiary location type that belongs to a taxonomy.</para>
    ///   <para>dcterms:created : 2024-05-24^^xsd:date</para>
    ///   <para>rdfs:label : subsidiary location type</para>
    ///   <a href="http://data.europa.eu/949/subsidiaryLocationType">era:subsidiaryLocationType</a>
    /// </summary>
    let subsidiaryLocationType = _prefixId.prefix "subsidiaryLocationType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.12.3.1^^xsd:string</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>rdfs:label : Supported platform height</para>
    ///   <para>dcterms:modified : 2021-08-02^^xsd:date</para>
    ///   <para>rdfs:comment : Platform height for which the vehicle is designed.</para>
    ///   <a href="http://data.europa.eu/949/supportedPlatformHeight">era:supportedPlatformHeight</a>
    /// </summary>
    let supportedPlatformHeight = _prefixId.prefix "supportedPlatformHeight"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:rinfIndex : 1.2.1.1.7.1^^xsd:stringera:rinfIndex : 1.1.1.3.8.1^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:dependencyNote : Applicable when at least two different protection, control and warning systems exist.</para>
    ///   <para>skos:scopeNote : Switch over between different systems whilst running. Installation depends on local conditions. </para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.2^^xsd:string</para>
    ///   <para>era:XMLName : CTS_SwitchProtectControlWarn^^xsd:string</para>
    ///   <para>rdfs:comment : Indication whether a switch over between different systems whilst running exists.</para>
    ///   <para>rdfs:label : Existence of switch over between different protection, control and warning systems while running</para>
    ///   <a href="http://data.europa.eu/949/switchProtectControlWarning">era:switchProtectControlWarning</a>
    /// </summary>
    let switchProtectControlWarning = _prefixId.prefix "switchProtectControlWarning"
    /// <summary>
    ///   <para>rdfs:label : Existence of switch over between different radio systems</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2025-03-04^^xsd:date</para>
    ///   <para>skos:scopeNote : Switch over between different radio systems and no communication system whilst running. Installation depends on local conditions.
    ///
    /// The "Indication if other radio systems in normal operation are installed line-side" is given in parameter 1.1.1.3.6.1 / SOL Track Parameter CRS_Installed</para>
    ///   <para>era:rinfIndex : 1.2.1.1.7.2^^xsd:stringera:rinfIndex : 1.1.1.3.8.2^^xsd:string</para>
    ///   <para>rdfs:comment : Indication whether a switch over between different radio systems and no communication system whilst running exists.</para>
    ///   <para>era:XMLName : CTS_SwitchRadioSystem^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latestera:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>era:dependencyNote : Applicable when at least two different radio systems exist. </para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/switchRadioSystem">era:switchRadioSystem</a>
    /// </summary>
    let switchRadioSystem = _prefixId.prefix "switchRadioSystem"

    /// <summary>
    ///   <para>rdfs:label : Switches and crossings</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.5^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/switchesAndCrossingsDataParameter">era:switchesAndCrossingsDataParameter</a>
    /// </summary>
    let switchesAndCrossingsDataParameter = _prefixId.prefix "switchesAndCrossingsDataParameter"

    /// <summary>
    ///   <para>rdfs:label : (deprecated) Information on system separation</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2023-04-05^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : (deprecated) Indication of required several information on system separation.
    /// Deprecated because of replacement by four properties. The reason is that the property is composed of four values: length [NNN], the length of the system separation in metres; switch off breaker [Y/N]. Single selection of 'Y=yes' or 'N=no' to show whether the breaker has to be switched off;  lower pantograph [Y/N]. Single selection of 'Y=yes' or 'N=no' to show whether the pantograph has to be lowered, and [CharacterString]  to show whether the supply system has to be changed.</para>
    ///   <a href="http://data.europa.eu/949/systemSeparationInfo">era:systemSeparationInfo</a>
    /// </summary>
    let systemSeparationInfo = _prefixId.prefix "systemSeparationInfo"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:comment : Part of the system separation info of a track that shows whether the supply system has to be changed.
    /// The system separation info is the Indication of required several information on system separation.</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2025-06-09^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : System separation info change supply system</para>
    ///   <a href="http://data.europa.eu/949/systemSeparationInfoChangeSupplySystem">era:systemSeparationInfoChangeSupplySystem</a>
    /// </summary>
    let systemSeparationInfoChangeSupplySystem = _prefixId.prefix "systemSeparationInfoChangeSupplySystem"

    /// <summary>
    ///   <para>rdfs:label : System separation info Km</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:comment : Part of the system separation info of a track. Indicates the location from the start of the line where the new value is valid.
    /// The system separation info is the Indication of required several information on system separation.</para>
    ///   <a href="http://data.europa.eu/949/systemSeparationInfoKm">era:systemSeparationInfoKm</a>
    /// </summary>
    let systemSeparationInfoKm = _prefixId.prefix "systemSeparationInfoKm"
    /// <summary>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Part of the system separation info of a track that shows the length of the system separation in metres.
    /// The system separation info is the Indication of required several information on system separation.</para>
    ///   <para>rdfs:label : System separation info length</para>
    ///   <a href="http://data.europa.eu/949/systemSeparationInfoLength">era:systemSeparationInfoLength</a>
    /// </summary>
    let systemSeparationInfoLength = _prefixId.prefix "systemSeparationInfoLength"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:label : System separation info  pantograph lowered</para>
    ///   <para>rdfs:comment : Part of the system separation info of a track that shows whether the pantograph has to be lowered.
    /// The system separation info is the Indication of required several information on system separation.</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/systemSeparationInfoPantographLowered">era:systemSeparationInfoPantographLowered</a>
    /// </summary>
    let systemSeparationInfoPantographLowered = _prefixId.prefix "systemSeparationInfoPantographLowered"

    /// <summary>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>rdfs:label : System separation info switch off breaker</para>
    ///   <para>rdfs:comment : Part of the system separation info of a track that shows whether the breaker has to be switched off.
    /// The system separation info is the Indication of required several information on system separation.</para>
    ///   <a href="http://data.europa.eu/949/systemSeparationInfoSwitchOffBreaker">era:systemSeparationInfoSwitchOffBreaker</a>
    /// </summary>
    let systemSeparationInfoSwitchOffBreaker = _prefixId.prefix "systemSeparationInfoSwitchOffBreaker"

    /// <summary>
    ///   <para>dcterms:created : 2022-11-07^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-12-05^^xsd:datedcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.16.8^^xsd:stringera:rinfIndex : 1.2.1.1.1.16.8^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Maximum time without a safe message from Radio Block Center before train reacts in seconds.
    /// According to the specification referenced in Appendix A-1, index [C]</para>
    ///   <para>rdfs:label : T_NVCONTACT</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.5.8^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>skos:scopeNote : Precision: [NNN], with N a decimal number (0÷9), NNN = 255 means ∞ seconds, so values cannot be higher.
    ///
    /// See: TSI CCS (Subset 26, chapter 7. 7.5.1.148 T_NVCONTACT)</para>
    ///   <para>era:formatNote : NNN, with N as a digit from 0 to 9. Value NNN = 255 means ∞ (infinity), so values cannot be higher.^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tNvcontact">era:tNvcontact</a>
    /// </summary>
    let tNvcontact = _prefixId.prefix "tNvcontact"
    /// <summary>
    ///   <para>skos:scopeNote : Precision: [NNN], with N a decimal number (0÷9)
    ///
    /// See: TSI CCS (Subset 26, chapter 7. 7.5.1.149 T_NVOVTRP)</para>
    ///   <para>dcterms:created : 2022-11-07^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-12-05^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>rdfs:label : T_NVOVTRP</para>
    ///   <para>rdfs:comment : Maximum time for overriding the train trip in seconds.
    /// According to the specification referenced in Appendix A-1, index [C]</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>era:formatNote : NNN, with N as a digit from 0 to 9. Value NNN = 255 means ∞ (infinity), so values cannot be higher.^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.16.6^^xsd:stringera:rinfIndex : 1.2.1.1.1.16.6^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.5.6^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tNvovtrp">era:tNvovtrp</a>
    /// </summary>
    let tNvovtrp = _prefixId.prefix "tNvovtrp"
    /// <summary>
    ///   <para>rdfs:label : OP primary location code</para>
    ///   <para>rdfs:comment : Not used anymore. It has been replaced by era:primaryLocationCode.rdfs:comment : Primary location code developed for information exchange in accordance with the TSIs relating to the telematics applications subsystem</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2024-06-03^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tafTAPCode">era:tafTAPCode</a>
    /// </summary>
    let tafTAPCode = _prefixId.prefix "tafTAPCode"

    /// <summary>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2025-03-04^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:XMLName : CTD_TCLimitation^^xsd:string</para>
    ///   <para>era:formatNote : The value of this parameter is an instance of the era:FrenchTrainDetectionSystemLimitation class with all its properties:
    ///  - true/false for the existence of a section with train detection limitation
    ///  - list of values from 1 to 8 defined in the taxonomy^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:legalDeadline : 16 January 2020era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.1.4^^xsd:stringera:rinfIndex : 1.2.1.1.6.3^^xsd:string</para>
    ///   <para>skos:scopeNote : Relates the class train detection system with the class that represents the section with train detection limitation. Select the special condition as applicable through National Rule from the List.
    ///
    /// For RINF XML data sets:
    /// As long as the data provision through XML data sets is allowed, the data format is a character string with the following structure:
    /// [Y/N]+[N]
    /// where:
    /// - [Y/N] - is the existence of section with train detection limitation
    /// - [N] is a number from 1 to 8 referring to sections with:
    ///     [1] Tonnage circulated per track is inferior to 15000 tons/day/track
    ///     [2] Directional Interlocking
    ///     [3] 45-second delay for directional interlocking
    ///     [4] Installation with track circuit announcement
    ///     [5] Absence of a shunting assistance pedal in the normal direction of circulation for non-reversible double track lines
    ///     [6] Absence of a shunting assistance pedal regardless of the direction of traffic for single track lines and tracks for two way working
    ///     [7] Absence of a pedal announcement mechanism
    ///     [8] 45-second delay for specific announcement reset devices.</para>
    ///   <para>rdfs:label : Section with train detection limitation</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:comment : Specific for route compatibility check on French network.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:dependencyNote : Only applicable on running tracks in France</para>
    ///   <a href="http://data.europa.eu/949/tdsFrenchTrainDetectionSystemLimitation">era:tdsFrenchTrainDetectionSystemLimitation</a>
    /// </summary>
    let tdsFrenchTrainDetectionSystemLimitation = _prefixId.prefix "tdsFrenchTrainDetectionSystemLimitation"

    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.3.4.2.3^^xsd:stringera:rinfIndex : 1.2.1.1.3.2.3^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-09/index077_-_ERA_ERTMS_033281_v5.pdf^^xsd:anyURI</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : For train detection system compliant with TSIs, 12 months after publication of Article 7 Guide.
    /// For train detection system not TSI compliant: in relation to article 13 of TSI CCS</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-03-04^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:dependencyNote : Mandatory for train detection systems based on axle counters</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : CCD_MaxMagnField^^xsd:string</para>
    ///   <para>skos:scopeNote : Relates the Axle Counter TrainDetectionSystem with its MaximumMagneticField in (X,Y,Z). Verification of compliance with TSI includes application of notified national rules (when they exist).</para>
    ///   <para>rdfs:comment : The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band.
    /// It should be provided in 3 directions.</para>
    ///   <para>rdfs:label : Maximum magnetic field</para>
    ///   <a href="http://data.europa.eu/949/tdsMaximumMagneticField">era:tdsMaximumMagneticField</a>
    /// </summary>
    let tdsMaximumMagneticField = _prefixId.prefix "tdsMaximumMagneticField"
    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.3.7.11.1^^xsd:string</para>
    ///   <para>dcterms:created : 2023-01-25^^xsd:date</para>
    ///   <para>rdfs:label : Train detection system min axle load vehicle category</para>
    ///   <para>rdfs:comment : Indication of load given in tons depending of the category of vehicle. Deprecated according to the amendment to the Regulation (EU) 2019/777.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : CTD_MinAxleLoadByVehicleCat^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/tdsMinAxleLoadVehicleCategory">era:tdsMinAxleLoadVehicleCategory</a>
    /// </summary>
    let tdsMinAxleLoadVehicleCategory = _prefixId.prefix "tdsMinAxleLoadVehicleCategory"
    /// <summary>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2024-06-26^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : Loc&amp;Pas TSI: 4.2.6.1.1
    /// 4.2.5 Wag TSI^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.3.1^^xsd:string</para>
    ///   <para>rdfs:comment : Temperature range for unrestricted access to the line.</para>
    ///   <para>dcterms:created : 2023-01-20^^xsd:date</para>
    ///   <para>skos:scopeNote : T1 (-25 to +40)
    /// T2 (-40 to +35)
    /// T3 (-25 to +45)
    /// Tx (-40 to +50)</para>
    ///   <para>rdfs:label : Temperature range</para>
    ///   <para>era:rinfIndex : 1.1.1.1.2.6^^xsd:string</para>
    ///   <para>era:XMLName : IPP_TempRange^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/temperatureRange">era:temperatureRange</a>
    /// </summary>
    let temperatureRange = _prefixId.prefix "temperatureRange"
    /// <summary>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:XMLName : IPL_TENClass^^xsd:stringera:XMLName : IPP_TENClass^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.2.0.0.3^^xsd:stringera:rinfIndex : 1.2.1.0.6.3^^xsd:stringera:rinfIndex : 1.2.1.0.2.1^^xsd:stringera:rinfIndex : 1.1.1.1.2.1^^xsd:string</para>
    ///   <para>skos:scopeNote : Article 39 2. freight lines of the core network as indicated in Annex I: at least 22,5 t axle load, 100 km/h line speed and the possibility of running trains with a length of 740 m.</para>
    ///   <para>rdfs:label : TEN classification of track</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of the part of the trans-European network the infrastructure element belongs to.</para>
    ///   <para>skos:altLabel : Trans-European Network (TEN) classification of track</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-02^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/tenClassification">era:tenClassification</a>
    /// </summary>
    let tenClassification = _prefixId.prefix "tenClassification"
    /// <summary>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>rdfs:seeAlso : http://ec.europa.eu/transport/infrastructure/tentec/tentec-portal/^^xsd:anyURIrdfs:seeAlso : https://transport.ec.europa.eu/transport-themes/infrastructure-and-investment/trans-european-transport-network-ten-t_en^^xsd:anyURI</para>
    ///   <para>dcterms:modified : 2025-09-03^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>rdfs:label : TEN geographic information system identity (GIS ID)</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : IPP_TENGISID^^xsd:string</para>
    ///   <para>skos:scopeNote : This parameter will be deprecated in a next revision. Please use value "Not applicable" until the RINF regulation is aligned. The information below remains for reference only.
    ///
    /// TENtec is the European Commission's information system to coordinate and support the Trans-European Transport Network Policy (TEN-T). For more details about the system and the legal background please follow the link to the TENtec Public Portal.
    ///
    /// The list of sections of the TEN networks with their GIS IDs can be requested via MOVE-TENTEC-PUBLIC@ec.europa.eu</para>
    ///   <para>era:legalDeadline : 1 January 2021</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of the GIS identity (GIS ID) of the section of TEN-T database to which the track belongs</para>
    ///   <para>era:rinfIndex : 1.1.1.1.2.1.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tenGISId">era:tenGISId</a>
    /// </summary>
    let tenGISId = _prefixId.prefix "tenGISId"
    /// <summary>
    ///   <para>rdfs:comment : Classification of the element according to its level in the Trans-European Transport Network (TEN-T).</para>
    ///   <para>dcterms:created : 2025-11-17^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : TEN-T network level</para>
    ///   <a href="http://data.europa.eu/949/tentNetworkLevel">era:tentNetworkLevel</a>
    /// </summary>
    let tentNetworkLevel = _prefixId.prefix "tentNetworkLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : TenT reference</para>
    ///   <para>rdfs:comment : Used to annotate properties coming from the TenT regulations, to be used for monitoring the provision of the data.</para>
    ///   <para>dcterms:created : 2024-11-26^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/tentReference">era:tentReference</a>
    /// </summary>
    let tentReference = _prefixId.prefix "tentReference"
    /// <summary>
    ///   <para>era:eratvIndex : 4.7.2.1.4^^xsd:string</para>
    ///   <para>rdfs:label : Thermal capacity distance</para>
    ///   <para>rdfs:comment : Thermal capacity distance. If no reference case is indicated.</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>dcterms:modified : 2024-06-26^^xsd:datedcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/thermalCapacityDistance">era:thermalCapacityDistance</a>
    /// </summary>
    let thermalCapacityDistance = _prefixId.prefix "thermalCapacityDistance"
    /// <summary>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:label : Thermal capacity gradient</para>
    ///   <para>rdfs:comment : Thermal capacity gradient. If no reference case is indicated.</para>
    ///   <para>era:eratvIndex : 4.7.2.1.3^^xsd:string</para>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/thermalCapacityGradient">era:thermalCapacityGradient</a>
    /// </summary>
    let thermalCapacityGradient = _prefixId.prefix "thermalCapacityGradient"
    /// <summary>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>rdfs:label : Thermal capacity speed</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.7.2.1.2^^xsd:string</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:comment : Thermal capacity speed. If no reference case is indicated.</para>
    ///   <a href="http://data.europa.eu/949/thermalCapacitySpeed">era:thermalCapacitySpeed</a>
    /// </summary>
    let thermalCapacitySpeed = _prefixId.prefix "thermalCapacitySpeed"
    /// <summary>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:comment : Reference case of a TSI thermal capacity.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-02^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.7.2.1.1^^xsd:string</para>
    ///   <para>rdfs:label : Thermal capacity TSI reference</para>
    ///   <a href="http://data.europa.eu/949/thermalCapacityTSIReference">era:thermalCapacityTSIReference</a>
    /// </summary>
    let thermalCapacityTSIReference = _prefixId.prefix "thermalCapacityTSIReference"
    /// <summary>
    ///   <para>era:eratvIndex : 4.7.2.1.5^^xsd:string</para>
    ///   <para>rdfs:label : Thermal capacity time</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:comment : Thermal capacity time. If no reference case is indicated.</para>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/thermalCapacityTime">era:thermalCapacityTime</a>
    /// </summary>
    let thermalCapacityTime = _prefixId.prefix "thermalCapacityTime"
    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.3.12.1^^xsd:string</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication whether tilting functions are supported by ETCS.</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>rdfs:label : Indication whether tilting functions are supported by ETCS</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/tiltingSupported">era:tiltingSupported</a>
    /// </summary>
    let tiltingSupported = _prefixId.prefix "tiltingSupported"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.5.5^^xsd:string</para>
    ///   <para>rdfs:label : Total vehicle mass</para>
    ///   <para>dcterms:modified : 2021-08-26^^xsd:date</para>
    ///   <para>rdfs:comment : Total vehicle mass (for each vehicle of the unit), given in kg.</para>
    ///   <para>dcterms:created : 2021-08-26^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/totalVehicleMass">era:totalVehicleMass</a>
    /// </summary>
    let totalVehicleMass = _prefixId.prefix "totalVehicleMass"
    /// <summary>
    ///   <para>dcterms:modified : 2024-11-11^^xsd:datedcterms:modified : 2021-09-09^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2021-08-09^^xsd:date</para>
    ///   <para>rdfs:label : Track</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Reference to a related railway track.</para>
    ///   <a href="http://data.europa.eu/949/track">era:track</a>
    /// </summary>
    let track = _prefixId.prefix "track"
    /// <summary>
    ///   <para>rdfs:label : Track parameters</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.0.4^^xsd:stringera:rinfIndex : 1.1.1.1.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trackDataParameter">era:trackDataParameter</a>
    /// </summary>
    let trackDataParameter = _prefixId.prefix "trackDataParameter"
    /// <summary>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:comment : The normal running direction is:
    /// - the same as the direction defined by the start and end of the SoL: (N)
    /// - the opposite to the direction defined by the start and end of the SoL: (O)
    /// - both directions: (B)</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Normal running direction</para>
    ///   <para>era:rinfIndex : 1.1.1.0.0.2^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>era:XMLName : SOLTrackDirection^^xsd:string</para>
    ///   <para>dcterms:created : 2021-09-09^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.2.1.1^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trackDirection">era:trackDirection</a>
    /// </summary>
    let trackDirection = _prefixId.prefix "trackDirection"
    /// <summary>
    ///   <para>rdfs:label : Running track generic information</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.0.0^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trackGenericDataParameter">era:trackGenericDataParameter</a>
    /// </summary>
    let trackGenericDataParameter = _prefixId.prefix "trackGenericDataParameter"
    /// <summary>
    ///   <para>rdfs:label : Running track generic information</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.0.0^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trackGenericObjParameter">era:trackGenericObjParameter</a>
    /// </summary>
    let trackGenericObjParameter = _prefixId.prefix "trackGenericObjParameter"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.2.1.1^^xsd:string</para>
    ///   <para>rdfs:comment : Unique track identification or unique track number within operational point or section of line</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2025-03-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.0.0.2^^xsd:stringera:rinfIndex : 1.1.1.0.0.1^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:created : 2021-09-09^^xsd:date</para>
    ///   <para>era:XMLName : SOLTrackIdentification^^xsd:stringera:XMLName : OPTrackIdentification^^xsd:string</para>
    ///   <para>skos:scopeNote : Each track shall have unique identification or number within the SoL. This number cannot be used for naming any other track in the same SoL.
    /// The check regarding the uniqueness of the ID within the SoL has to be done on national level (preferably by IM).</para>
    ///   <para>rdfs:label : Identification of track</para>
    ///   <a href="http://data.europa.eu/949/trackId">era:trackId</a>
    /// </summary>
    let trackId = _prefixId.prefix "trackId"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:formatNote : The value of this parameter is an instance of the era:LoadCapability class which consists of 2 properties:
    /// - era:loadCapabilityLineCategory - as a taxonomy of load models representing line category
    /// - era:loadCapabilitySpeed - integer for the value of speed [km/h] permitted for a specific load model
    ///
    /// For RINF XML data sets:
    /// As long as the data provision through XML data sets is allowed, the data format is:
    /// [CCCC] [NNN],
    /// where:
    /// - [CCCC] is a single selection from the predefined list of load models representing line category
    /// - [NNN] is the value of speed [km/h] permitted for a specific load model.</para>
    ///   <para>skos:scopeNote : At this step, RINF does not allow to enter additional data referred to additional speed regulations and operating requirements relating to locomotives (e.g., locomotive classes and associated maximum speed) or traffic types (e.g., maximum speed of freight traffic or passenger traffic).
    ///
    /// The load capability describes the weakest point of this track within this section of line (which is normally a bridge or other sub-track structure).
    /// It is expressed as a combination of the line category and speed permitted for trains exerting loads defined for this line category.
    /// The result of the classification process is set out in EN 15528:2021 (Annex A) and referred to in that standard as Line Category.
    ///
    /// The Load capability for UK in respect of Northern Ireland consists of RA and speed in miles per hour. RA shall be applied according to UK Railway Group Standard GE/RT8006, Issue Two, September 2010.
    ///
    /// More than one combination may be published for the same track if applicable, but it has to be done by repetition of the parameter with one value selected only  that is why Y is given in line Can be repeated.
    /// For the following cases, it is not possible to use EN 15528:2021 categories of line classification:
    /// - TSI categories of line P1520 and F1520 (passenger traffic or freight traffic at any speed)
    /// - TSI categories of line P1600 and F1600 (passenger traffic or freight traffic at any speed)
    ///
    /// When more than one value of the parameter has to be published, then parameter has to be repeated as many times as many values of the parameter will be published.</para>
    ///   <para>skos:example : The set of selected data may include: B2-160, D4-120 and E5-100
    /// When classifying infrastructure lines into line categories, the following options shall be used by the infrastructure manager to optimize freight traffic:
    /// Option 1: determination of the line category at maximum freight traffic speed (maximum 120 Km/h)
    /// Option 2: determination of a line category at an associated lower speed (less than the maximum freight traffic speed)
    /// Example of option 1 (Annex F of EN 15528:2021): In a given track, if the traffic is mixed, the local speed of the line is 90 Km/h and the determined line category is D4 at a maximum of 90 Km/h, the information displayed should be: D4/90.
    /// Example of option 2 (Annex F of EN 15528:2021): In a given track, if the traffic is mixed, the local speed of the line is 120 Km/h and the determined line category is C4 at a maximum of 120 Km/h and D4 at maximum of 90 Km/h, the information displayed should be: C4/120 and D4/90.^^xsd:string</para>
    ///   <para>dcterms:created : 2023-01-20^^xsd:date</para>
    ///   <para>rdfs:seeAlso : INF TSI: 4.2.1, 4.2.7.1, 4.2.7.2, 4.2.7.4
    /// Annex D1 OPE TSI^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.2.4^^xsd:string</para>
    ///   <para>era:XMLName : IPP_LoadCap^^xsd:string</para>
    ///   <para>rdfs:comment : Relates the track with the class LoadCapability. A combination of the line category and speed at the weakest point of the track.</para>
    ///   <para>rdfs:label : Load capability</para>
    ///   <a href="http://data.europa.eu/949/trackLoadCapability">era:trackLoadCapability</a>
    /// </summary>
    let trackLoadCapability = _prefixId.prefix "trackLoadCapability"
    /// <summary>
    ///   <para>rdfs:label : Track parameters</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.0.4^^xsd:stringera:rinfIndex : 1.1.1.1.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trackObjParameter">era:trackObjParameter</a>
    /// </summary>
    let trackObjParameter = _prefixId.prefix "trackObjParameter"
    /// <summary>
    ///   <para>era:formatNote : In RDF the range is an instance of the era:PhaseInfo class with all its properties.
    ///
    /// For RINF XML data sets:
    /// As long as the data provision through XML data sets is allowed, the data format is a character string with the following structure: distance type [MIN/MAX] + length [NNN] + switch off breaker [Y/N] + lower pantograph [Y/N] + km [NNN.NNN]. The structure of the string is as follows:
    /// - distance type [MIN/MAX] - single selection of 'MIN=minimum' or 'MAX=maximum' to show whether the length is a minimum distance between the inner contact strips of the pantographs or a maximum distance between the outer contact strips of the pantographs. Multiple strings for this parameter are accepted;
    /// - length [NNN] - the length of the phase separation in meters;
    /// - switch off breaker [Y/N], single selection of 'yes' or 'no' to show whether the breaker has to be switched off;
    /// - lower pantograph [Y/N], single selection of 'yes' or 'no' to show whether the pantograph has to be lowered,
    /// - Km [NNN.NNN] - the location from the start of the line where the new value is valid.</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:dependencyNote : A value is mandatory only if 1.1.1.2.4.1.1 parameter "Phase separation" value is "Y" (true), otherwise applicability flag is "N" (not applicable)</para>
    ///   <para>rdfs:label : Information on phase separation</para>
    ///   <para>dcterms:modified : 2025-06-09^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:seeAlso : ENE TSI: 4.2.15^^xsd:string</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:comment : Relates the Track with PhaseInfo. Indication of required several information on phase separation.</para>
    ///   <para>era:XMLName : EOS_InfoPhase^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.2.4.1.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trackPhaseInfo">era:trackPhaseInfo</a>
    /// </summary>
    let trackPhaseInfo = _prefixId.prefix "trackPhaseInfo"

    /// <summary>
    ///   <para>dcterms:modified : 2024-09-25^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>skos:scopeNote : This parameter gives the information about the number of pantographs and the distance between them at a given speed for which the Overhead Contact Line (OCL) has been designed.
    ///
    /// As for different speeds different combinations of number of pantographs and distance between them may exist, so this parameter can be repeated to present all of them.
    ///
    /// The raised pantographs distance and speed is the indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.
    ///
    /// See 4.2.13 (TSI ENE) and 4.2.8.2.9.7 (TSI LOC&amp;PAS)</para>
    ///   <para>rdfs:label : Requirements for number of raised pantographs and spacing between them, at the given speed</para>
    ///   <para>era:XMLName : EPA_NumRaisedSpeed^^xsd:string</para>
    ///   <para>era:dependencyNote : Mandatory only if “Overhead contact line (OCL)” is selected in 1.1.1.2.2.1.1, otherwise the parameter is not applicable.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>rdfs:comment : Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.2.3.3^^xsd:string</para>
    ///   <para>era:formatNote : Three values: [N] is number of pantographs; [NNN] is minimum distance between pantographs, in metres; [NNN] is the speed considered in km/h.^^xsd:string</para>
    ///   <para>skos:editorialNote : Relates the track with the class RaisedPantographsDistanceAndSpeed.^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:seeAlso : ENE TSI: 4.2.13 ;
    /// LOC&amp;PAS TSI: 4.2.8.2.9.7^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trackRaisedPantographsDistanceAndSpeed">era:trackRaisedPantographsDistanceAndSpeed</a>
    /// </summary>
    let trackRaisedPantographsDistanceAndSpeed = _prefixId.prefix "trackRaisedPantographsDistanceAndSpeed"

    /// <summary>
    ///   <para>rdfs:label : Track resistance to applied loads</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.6^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trackResistanceToAppliedLoadsDataParameter">era:trackResistanceToAppliedLoadsDataParameter</a>
    /// </summary>
    let trackResistanceToAppliedLoadsDataParameter = _prefixId.prefix "trackResistanceToAppliedLoadsDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Track resistance to applied loads</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.1.6^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trackResistanceToAppliedLoadsObjParameter">era:trackResistanceToAppliedLoadsObjParameter</a>
    /// </summary>
    let trackResistanceToAppliedLoadsObjParameter = _prefixId.prefix "trackResistanceToAppliedLoadsObjParameter"

    /// <summary>
    ///   <para>era:XMLName : EOS_InfoSystem^^xsd:string</para>
    ///   <para>rdfs:label : Information on system separation</para>
    ///   <para>skos:scopeNote : Length - the length of the system separation in meters
    /// Switch off breaker - single selection of  Y=yes  or  N=no  to show whether the breaker has to be switched off
    /// Lower pantograph - single selection of  Y=yes  or  N=no  to show whether the pantograph has to be lowered
    /// Km - the location from the start of the line where the new value is valid </para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2025-06-09^^xsd:datedcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>rdfs:seeAlso : ENE TSI: 4.2.16^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:formatNote : In RDF, the range is an instance of the era:SystemSeparationInfo class with all its properties.
    ///
    /// For RINF XML data sets:
    /// As long as the data provision through XML data sets is allowed, the data format is a character string with the following structure: length [NNN] + switch off breaker [Y/N] + lower pantograph [Y/N] + km [NNN.NNN] ^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of required several information on system separation</para>
    ///   <para>era:rinfIndex : 1.1.1.2.4.2.2^^xsd:string</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:dependencyNote : Mandatory if there is an indication of existence of system separation (parameter 1.1.1.2.4.2.1)</para>
    ///   <a href="http://data.europa.eu/949/trackSystemSeparationInfo">era:trackSystemSeparationInfo</a>
    /// </summary>
    let trackSystemSeparationInfo = _prefixId.prefix "trackSystemSeparationInfo"
    /// <summary>
    ///   <para>rdfs:label : hot axle box detector (HABD)</para>
    ///   <para>rdfs:comment : Link between the running track and the HABD, covering the RINF parameters 1.1.1.1.7.(5-9)</para>
    ///   <para>dcterms:created : 2025-02-20^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/tracksideHabd">era:tracksideHabd</a>
    /// </summary>
    let tracksideHabd = _prefixId.prefix "tracksideHabd"

    /// <summary>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:label : Train control switch over special conditions</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Special conditions implemented on-board to switch over between different train protection control and warning systems. Given as combination of systems installed on board ('System XX'_'System YY').</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.13.1.6^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trainControlSwitchOverSpecialConditions">era:trainControlSwitchOverSpecialConditions</a>
    /// </summary>
    let trainControlSwitchOverSpecialConditions = _prefixId.prefix "trainControlSwitchOverSpecialConditions"

    /// <summary>
    ///   <para>rdfs:label : train detection system</para>
    ///   <para>skos:scopeNote : It can be repeated as many times as the number of different train detection systems are present.
    /// Not all parameters are applicable to all types of train detection systems; it depends on the applicability condition.
    /// For RDF data provision:
    /// The value of this property is an instance of the era:TrainDetectionsystem, which has as properties the parameters with indices 1.1.1.3.7.x.
    ///
    /// For RINF XML data sets:
    /// As long as the data provision through XML data sets is allowed, this property is the equivalent of the "Set" attribute, grouping parameters 1.1.1.3.7.x.</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Technical characteristics of the train detection systems installed in the section of line.</para>
    ///   <para>dcterms:modified : 2021-09-12^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/trainDetectionSystem">era:trainDetectionSystem</a>
    /// </summary>
    let trainDetectionSystem = _prefixId.prefix "trainDetectionSystem"

    /// <summary>
    ///   <para>rdfs:label : Train detection systems defined based on frequency bands</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.3^^xsd:stringera:rinfIndex : 1.1.1.3.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trainDetectionSystemBasedFrequencyBandsDataParameter">era:trainDetectionSystemBasedFrequencyBandsDataParameter</a>
    /// </summary>
    let trainDetectionSystemBasedFrequencyBandsDataParameter = _prefixId.prefix "trainDetectionSystemBasedFrequencyBandsDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Train detection systems defined based on frequency bands</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.3^^xsd:stringera:rinfIndex : 1.1.1.3.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trainDetectionSystemBasedFrequencyBandsObjParameter">era:trainDetectionSystemBasedFrequencyBandsObjParameter</a>
    /// </summary>
    let trainDetectionSystemBasedFrequencyBandsObjParameter = _prefixId.prefix "trainDetectionSystemBasedFrequencyBandsObjParameter"

    /// <summary>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2020-08-24^^xsd:datedcterms:modified : 2021-08-08^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2024-10-31^^xsd:datedcterms:modified : 2024-09-25^^xsd:date</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-09/index077_-_ERA_ERTMS_033281_v5.pdf^^xsd:anyURI</para>
    ///   <para>era:legalDeadline : 16 January 2020era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.1.2^^xsd:stringera:rinfIndex : 1.2.1.1.6.1^^xsd:string</para>
    ///   <para>rdfs:comment : Reference to the technical specification of train detection system, in accordance with the specification referenced in Appendix A-1, index [D]</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:XMLName : CTD_TCCheck^^xsd:string</para>
    ///   <para>era:dependencyNote : It is applicable only when parameter "Type of train detection system" is applicable</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Type of track circuits or axle counters to which specific checks are needed</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>skos:scopeNote : String containing the name of the TD system for which checks are mentioned in 1.1.1.3.7.1.3.</para>
    ///   <a href="http://data.europa.eu/949/trainDetectionSystemSpecificCheck">era:trainDetectionSystemSpecificCheck</a>
    /// </summary>
    let trainDetectionSystemSpecificCheck = _prefixId.prefix "trainDetectionSystemSpecificCheck"

    /// <summary>
    ///   <para>skos:changeNote : Change from datatype property to object property in order to point to the class Document (reference document)</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.1.3^^xsd:stringera:rinfIndex : 1.2.1.1.6.2^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : 16 January 2020</para>
    ///   <para>era:XMLName : CTD_TCCheckDocRef^^xsd:string</para>
    ///   <para>rdfs:comment : Electronic document from the IM stored by the Agency with precise values in accordance with TSI CCS Article13 and the specification referenced in Appendix A-1, index [D], for the specific check to be performed for train detection systems identified in parameter "Type of track circuits or axle counters to which specific checks are needed".</para>
    ///   <para>dcterms:modified : 2024-04-23^^xsd:datedcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-09/index077_-_ERA_ERTMS_033281_v5.pdf^^xsd:anyURI</para>
    ///   <para>rdfs:label : Document with the procedure(s) related to the type of train detection systems declared in "Type of track circuits or axle counters to which specific checks are needed"</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <para>era:dependencyNote : It is applicable only when parameter "Type of train detection system" is applicable</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trainDetectionSystemSpecificCheckDocument">era:trainDetectionSystemSpecificCheckDocument</a>
    /// </summary>
    let trainDetectionSystemSpecificCheckDocument = _prefixId.prefix "trainDetectionSystemSpecificCheckDocument"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-07^^xsd:datedcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2024-04-18^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latestera:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>era:dependencyNote : Not all parameters are applicable to all types of train detection systems; it depends on the applicability condition.</para>
    ///   <para>skos:scopeNote : Verification of compliance with TSI includes application of notified national rules (when they exist).
    ///
    /// Explanation on data presentation:
    /// The option of "wheel detector" has to be also selected for: wheel sensor for axle counter, pedal or treadle.
    ///
    /// If there is no train detection system (if this parameters is not applicable) it has an impact on parameters "Type of track circuits or axle counter to which specific checks are needed" and "Document with the procedure(s) related to the type of train detection systems declared in 1.1.1.3.7.1.2 ( 1.2.1.1.6.1, if in OP)", making them also not applicable.skos:scopeNote : Explanation on data presentation:
    /// The option of "wheel detector" has to be also selected for: wheel sensor for axle counter, pedal or treadle.</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2021-08-07^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.1.1^^xsd:stringera:rinfIndex : 1.2.1.1.3.1.1^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.14.1^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of types of train detection systems installed.</para>
    ///   <para>era:XMLName : CTD_DetectionSystem^^xsd:string</para>
    ///   <para>rdfs:label : Type of train detection system</para>
    ///   <a href="http://data.europa.eu/949/trainDetectionSystemType">era:trainDetectionSystemType</a>
    /// </summary>
    let trainDetectionSystemType = _prefixId.prefix "trainDetectionSystemType"
    /// <summary>
    ///   <para>era:legalDeadline : 16 January 2020era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracks</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.8^^xsd:stringera:rinfIndex : 1.2.1.1.1.8^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.4.11^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS Level 2 is present, ETCS Baseline &gt; 4 MR1 and IM confirms train integrity function is required).era:dependencyNote : Parameter only applicable when ETCS Baseline &gt; 4 MR1 with operation requiring train integrity.</para>
    ///   <para>rdfs:comment : Indication whether train confirmation from on-board is required to access the line for safety reasons.</para>
    ///   <para>dcterms:created : 2020-08-31^^xsd:date</para>
    ///   <para>skos:scopeNote : In hybrid operation, the confirmation can be optional.
    /// See also: TSI CCS BDC 4.2.2 (Managing information about the completeness of the train (not from driver))</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : CPE_IntegrityConfirmation^^xsd:string</para>
    ///   <para>rdfs:label : Train integrity confirmation from on-board (not from driver) necessary for line access</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/trainIntegrityOnBoardRequired">era:trainIntegrityOnBoardRequired</a>
    /// </summary>
    let trainIntegrityOnBoardRequired = _prefixId.prefix "trainIntegrityOnBoardRequired"

    /// <summary>
    ///   <para>rdfs:label : Train protection legacy systems</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.4^^xsd:stringera:rinfIndex : 1.1.1.3.5^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/trainProtectionLegacySystemObjParameter">era:trainProtectionLegacySystemObjParameter</a>
    /// </summary>
    let trainProtectionLegacySystemObjParameter = _prefixId.prefix "trainProtectionLegacySystemObjParameter"

    /// <summary>
    ///   <para>rdfs:label : Transitions between systems</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.7^^xsd:stringera:rinfIndex : 1.1.1.3.8^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/transitionsBetweenSystemsDataParameter">era:transitionsBetweenSystemsDataParameter</a>
    /// </summary>
    let transitionsBetweenSystemsDataParameter = _prefixId.prefix "transitionsBetweenSystemsDataParameter"

    /// <summary>
    ///   <para>rdfs:label : Transitions between systems</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.7^^xsd:stringera:rinfIndex : 1.1.1.3.8^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/transitionsBetweenSystemsObjParameter">era:transitionsBetweenSystemsObjParameter</a>
    /// </summary>
    let transitionsBetweenSystemsObjParameter = _prefixId.prefix "transitionsBetweenSystemsObjParameter"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.8.8^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates the suitability for transport on ferries.</para>
    ///   <para>rdfs:label : Transportable on ferry</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/transportableOnFerry">era:transportableOnFerry</a>
    /// </summary>
    let transportableOnFerry = _prefixId.prefix "transportableOnFerry"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Tsi compliant</para>
    ///   <para>rdfs:comment : Indicates if a certain property is TSI compliant.The reason for deprecation is that it is used in SKOS "OtherPantographHeads" and "TsiPantographHeads" to indicate in the first case if a SKOS concept is not tsiCompliant (false) and in the second case that the concept is tsiCompliant (true). These two SKOS were originally one SKOS, "PantographHeads". Currently with the two SKOS the property is redundant.</para>
    ///   <para>dcterms:modified : 2023-01-23^^xsd:date</para>
    ///   <para>dcterms:created : 2020-11-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliant">era:tsiCompliant</a>
    /// </summary>
    let tsiCompliant = _prefixId.prefix "tsiCompliant"

    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.21^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:XMLName : CTD_TSICompositeBrakeBlocks^^xsd:string</para>
    ///   <para>rdfs:label : TSI compliance of rules on the use of composite brake blocks</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. TSI compliance of rules on the use of composite brake blocks.</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantCompositeBrakeBlocks">era:tsiCompliantCompositeBrakeBlocks</a>
    /// </summary>
    let tsiCompliantCompositeBrakeBlocks = _prefixId.prefix "tsiCompliantCompositeBrakeBlocks"

    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.14^^xsd:string</para>
    ///   <para>era:XMLName : CTD_TSIFerroWheelMat^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>rdfs:label : TSI compliance of Ferromagnetic characteristics of wheel material required</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:comment : TSI compliance of Ferromagnetic characteristics of wheel material required. Deprecated according to the amendment to the Regulation (EU) 2019/777.</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantFerromagneticWheel">era:tsiCompliantFerromagneticWheel</a>
    /// </summary>
    let tsiCompliantFerromagneticWheel = _prefixId.prefix "tsiCompliantFerromagneticWheel"

    /// <summary>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:label : TSI compliance of maximum permitted distance between two consecutive axles</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:created : 2021-08-07^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : CTD_TSIMaxDistConsecutiveAxles^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.2.1^^xsd:string</para>
    ///   <para>rdfs:comment : Indication whether required distance between two consecutive axles is compliant with the TSI. Deprecated according to the amendment to the Regulation (EU) 2019/777.</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantMaxDistConsecutiveAxles">era:tsiCompliantMaxDistConsecutiveAxles</a>
    /// </summary>
    let tsiCompliantMaxDistConsecutiveAxles = _prefixId.prefix "tsiCompliantMaxDistConsecutiveAxles"

    /// <summary>
    ///   <para>rdfs:comment : TSI compliance of maximum permitted impedance between opposite wheels of a wheelset. Deprecated according to the amendment to the Regulation (EU) 2019/777.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.15.1^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:XMLName : CTD_TSIMaxImpedanceWheelset^^xsd:string</para>
    ///   <para>rdfs:label : TSI compliance of maximum permitted impedance between opposite wheels of a wheelset</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantMaxImpedanceWheelset">era:tsiCompliantMaxImpedanceWheelset</a>
    /// </summary>
    let tsiCompliantMaxImpedanceWheelset = _prefixId.prefix "tsiCompliantMaxImpedanceWheelset"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>rdfs:label : TSI compliance of rules for vehicle metal construction</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>era:XMLName : CTD_TSIMetalConstruction^^xsd:string</para>
    ///   <para>rdfs:comment : TSI compliance of rules for vehicle metal construction. Deprecated according to the amendment to the Regulation (EU) 2019/777.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.13^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantMetalConstruction">era:tsiCompliantMetalConstruction</a>
    /// </summary>
    let tsiCompliantMetalConstruction = _prefixId.prefix "tsiCompliantMetalConstruction"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : CTD_TSIMetalFree^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : TSI compliance of rules for metal-free space around wheels</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:comment : TSI compliance of rules for metal-free space around wheels. Deprecated according to the amendment to the Regulation (EU) 2019/777.</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.12^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantMetalFreeSpace">era:tsiCompliantMetalFreeSpace</a>
    /// </summary>
    let tsiCompliantMetalFreeSpace = _prefixId.prefix "tsiCompliantMetalFreeSpace"
    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.3.7.23^^xsd:string</para>
    ///   <para>rdfs:comment : TSI compliance of rules on combination of RST characteristics influencing shunting impedance. Deprecated according to the amendment to the Regulation (EU) 2019/777.</para>
    ///   <para>era:XMLName : CTD_TSIRSTShuntImpedance^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : TSI compliance of rules on combination of RST characteristics influencing shunting impedance</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantRSTShuntImpedance">era:tsiCompliantRSTShuntImpedance</a>
    /// </summary>
    let tsiCompliantRSTShuntImpedance = _prefixId.prefix "tsiCompliantRSTShuntImpedance"

    /// <summary>
    ///   <para>rdfs:label : TSI compliant radio (RMR)</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.2^^xsd:stringera:rinfIndex : 1.1.1.3.3^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantRadioDataParameter">era:tsiCompliantRadioDataParameter</a>
    /// </summary>
    let tsiCompliantRadioDataParameter = _prefixId.prefix "tsiCompliantRadioDataParameter"

    /// <summary>
    ///   <para>rdfs:label : TSI compliant radio (RMR)</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.2^^xsd:stringera:rinfIndex : 1.1.1.3.3^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantRadioObjParameter">era:tsiCompliantRadioObjParameter</a>
    /// </summary>
    let tsiCompliantRadioObjParameter = _prefixId.prefix "tsiCompliantRadioObjParameter"

    /// <summary>
    ///   <para>era:XMLName : CTD_TSISandCharacteristics^^xsd:string</para>
    ///   <para>rdfs:comment : TSI Compliance of rules on sand characteristics. Deprecated according to the amendment to the Regulation (EU) 2019/777.^^xsd:string</para>
    ///   <para>rdfs:label : TSI Compliance of rules on sand characteristics</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.19^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantSandCharacteristics">era:tsiCompliantSandCharacteristics</a>
    /// </summary>
    let tsiCompliantSandCharacteristics = _prefixId.prefix "tsiCompliantSandCharacteristics"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:label : TSI compliance of sanding</para>
    ///   <para>rdfs:comment : TSI compliance of sanding rules to allow compatibility with track circuits. Too much sand brings the risk of not detecting trains in tracks equipped with track circuits. Deprecated according to the amendment to the Regulation (EU) 2019/777.</para>
    ///   <para>era:rinfIndex : 1.1.1.3.7.16^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantSanding">era:tsiCompliantSanding</a>
    /// </summary>
    let tsiCompliantSanding = _prefixId.prefix "tsiCompliantSanding"
    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.3.7.22^^xsd:string</para>
    ///   <para>rdfs:comment : Deprecated according to the amendment to the Regulation (EU) 2019/777. TSI compliance of rules on shunt assisting devices.</para>
    ///   <para>rdfs:label : TSI compliance of rules on shunt assisting devices</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>era:XMLName : CTD_TSIShuntDevices^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantShuntDevices">era:tsiCompliantShuntDevices</a>
    /// </summary>
    let tsiCompliantShuntDevices = _prefixId.prefix "tsiCompliantShuntDevices"

    /// <summary>
    ///   <para>rdfs:label : TSI compliant train protection system (ETCS)</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1^^xsd:stringera:rinfIndex : 1.1.1.3.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantTrainProtectionSystemDataParameter">era:tsiCompliantTrainProtectionSystemDataParameter</a>
    /// </summary>
    let tsiCompliantTrainProtectionSystemDataParameter = _prefixId.prefix "tsiCompliantTrainProtectionSystemDataParameter"

    /// <summary>
    ///   <para>rdfs:label : TSI compliant train protection system (ETCS)</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1^^xsd:stringera:rinfIndex : 1.1.1.3.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tsiCompliantTrainProtectionSystemObjParameter">era:tsiCompliantTrainProtectionSystemObjParameter</a>
    /// </summary>
    let tsiCompliantTrainProtectionSystemObjParameter = _prefixId.prefix "tsiCompliantTrainProtectionSystemObjParameter"

    /// <summary>
    ///   <para>era:dependencyNote : Applicable ( Y ) only when for parameter 1.1.1.3.7.1 the selected option is wheel detector. The parameter is not applicable when the rules do not exist.</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>rdfs:label : Existence and TSI compliance of rules for magnetic fields emitted by a vehicle</para>
    ///   <para>skos:scopeNote : The electromagnetic fields generated by rolling stock can interfere with the operation of axle counters and wheel detectors.
    ///                       'True' means the rules exist and are compliant with the frequency management specified in the TSI.
    ///                       'False' means the rules exist and are not compliant with the frequency management specified in the TSI.
    ///
    ///                       Verification of compliance with TSI includes application of notified national rules (when they exist) in case of part covered by open point.</para>
    ///   <para>dcterms:created : 2024-04-18^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.3.9.1^^xsd:stringera:rinfIndex : 1.2.1.1.8.1^^xsd:string</para>
    ///   <para>era:XMLName : CEI_TSIMagneticFields^^xsd:string</para>
    ///   <para>era:formatNote : Y/N^^xsd:string</para>
    ///   <para>rdfs:comment : Indication whether rules exist and are compliant with the TSI.</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-09/index077_-_ERA_ERTMS_033281_v5.pdf^^xsd:anyURI</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tsiMagneticFields">era:tsiMagneticFields</a>
    /// </summary>
    let tsiMagneticFields = _prefixId.prefix "tsiMagneticFields"
    /// <summary>
    ///   <para>skos:altLabel : Appendix D1 index</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : TSI operation appendix D1 index</para>
    ///   <para>rdfs:comment : The index of a vocabulary term in Appendix D1 Vehicle and train Route compatibility checks.</para>
    ///   <para>dcterms:created : 2024-11-26^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/tsiOPEAppendixD1Index">era:tsiOPEAppendixD1Index</a>
    /// </summary>
    let tsiOPEAppendixD1Index = _prefixId.prefix "tsiOPEAppendixD1Index"
    /// <summary>
    ///   <para>dcterms:modified : 2024-11-26^^xsd:datedcterms:modified : 2024-08-13^^xsd:date</para>
    ///   <para>skos:definition : The index of a vocabulary term in Appendix D2 Elements the infrastructure manager has to provide to the railway undertaking for the Route Book from the document Commission Implementing Regulation (EU) 2019/773 of 16 May 2019 on the technical specification for interoperability relating to the operation and traffic management subsystem of the rail system within the European Union and repealing Decision 2012/757/EU.</para>
    ///   <para>rdfs:comment : The index of a vocabulary term in Appendix D2 Elements the infrastructure manager has to provide to the railway undertaking for the Route Book from the document Commission Implementing Regulation (EU) 2019/773 of 16 May 2019 on the technical specification for interoperability relating to the operation and traffic management subsystem of the rail system within the European Union and repealing Decision 2012/757/EU.</para>
    ///   <para>rdfs:label : TSI operation appendix D2 index</para>
    ///   <para>dcterms:created : 2022-11-04^^xsd:date</para>
    ///   <para>skos:altLabel : Appendix D2 index</para>
    ///   <a href="http://data.europa.eu/949/tsiOPEAppendixD2Index">era:tsiOPEAppendixD2Index</a>
    /// </summary>
    let tsiOPEAppendixD2Index = _prefixId.prefix "tsiOPEAppendixD2Index"
    /// <summary>
    ///   <para>dcterms:created : 2022-11-04^^xsd:date</para>
    ///   <para>rdfs:comment : The index of a vocabulary term in Appendix D3 ERTMS trackside engineering information relevant to operation that the infrastructure manager shall provide to the railway undertaking.</para>
    ///   <para>rdfs:label : TSI operation appendix D3 index</para>
    ///   <para>dcterms:modified : 2024-08-13^^xsd:datedcterms:modified : 2024-11-26^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:altLabel : Appendix D3 index</para>
    ///   <a href="http://data.europa.eu/949/tsiOPEAppendixD3Index">era:tsiOPEAppendixD3Index</a>
    /// </summary>
    let tsiOPEAppendixD3Index = _prefixId.prefix "tsiOPEAppendixD3Index"
    /// <summary>
    ///   <para>skos:editorialNote : The allowed values for this property belong to the SKOS Concept Scheme http://data.europa.eu/949/concepts/compliant-pantograph-heads/CompliantPantographHeads.</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-09-25^^xsd:datedcterms:modified : 2021-09-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.2.3.1^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of TSI compliant pantograph heads which are allowed to be used.</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : The parameter can contain more than one pantograph defined in LOC&amp;PAS TSI. Presentation of those pantographs is done by repetition of the parameter with a single selection.
    /// If declaring acceptance of pantograph heads 1950 (type 1), both insulated and conductive horns shall be accepted.
    /// The head geometry of pantograph type 1600 mm is as depicted in the points 4.2.8.2.9.2.1 of LOC&amp;PAS TSI which refers to EN 50367:2020+A1:2022 Annex A.2 Figure A.6.
    /// The head geometry of pantograph type 1950 mm is as depicted in the points 4.2.8.2.9.2.2 of LOC&amp;PAS TSI which refers to EN 50367:2020+A1:2022 Annex A.2 Figure A.7.
    /// The head geometry for pantograph type 2000/2260 mm is depicted in the point 4.2.8.2.9.2.3 of LOC&amp;PAS TSI.</para>
    ///   <para>rdfs:label : Accepted TSI compliant pantograph heads</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:dependencyNote : Mandatory only if “Overhead contact line (OCL)” is selected in 1.1.1.2.2.1.1, otherwise the parameter is not applicable.</para>
    ///   <para>rdfs:seeAlso : LOC&amp;PAS TSI: 4.2.8.2.9.2
    /// EN 50367 (2012): Annex A.2 and EN 50206-1 (2010): 4.2 and 6.2.3^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:XMLName : EPA_TSIHeads^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <a href="http://data.europa.eu/949/tsiPantographHead">era:tsiPantographHead</a>
    /// </summary>
    let tsiPantographHead = _prefixId.prefix "tsiPantographHead"
    /// <summary>
    ///   <para>era:XMLName : ISC_TSISwitchCrossing^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>skos:scopeNote : If for existing track at least one parameter has less strict value than specified in the TSI, then 'N' (false) shall be selected.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-09-10^^xsd:datedcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>rdfs:seeAlso : INF TSI: 4.2.5 and 4.2.8.6^^xsd:string</para>
    ///   <para>rdfs:comment : Switches and crossings are maintained to in service limit dimension as specified in TSI.</para>
    ///   <para>era:rinfIndex : 1.1.1.1.5.1^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>rdfs:label : TSI compliance of in-service values for switches and crossings</para>
    ///   <para>era:formatNote : in XML: Y/N^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <a href="http://data.europa.eu/949/tsiSwitchCrossing">era:tsiSwitchCrossing</a>
    /// </summary>
    let tsiSwitchCrossing = _prefixId.prefix "tsiSwitchCrossing"
    /// <summary>
    ///   <para>rdfs:label : Existence and TSI compliance of limits in harmonics in the traction current of vehicles</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2024-04-18^^xsd:date</para>
    ///   <para>rdfs:comment : Indication whether rules exist and are compliant with the TSI.</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:XMLName : CEI_TSITractionHarmonics^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.9.2^^xsd:stringera:rinfIndex : 1.2.1.1.8.2^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>skos:scopeNote : Compatibility with track circuits and wheel detectors of axle counters.
    ///
    /// The harmonics in the traction current in the rails can interfere with the operation of track circuits. The DC current in the rails may saturate the detectors of the axle counters, preventing their operation.
    ///
    /// 'Y' means the rules exist and are compliant with the frequency management specified in the TSI.
    /// 'N' 'means the rules exist and are not compliant with the frequency management specified in the TSI.
    ///
    /// Verification of compliance with TSI includes application of notified national rules (when they exist) in case of part covered by open point.
    /// LOC&amp;PAS TSI : Appendix J-2, index 1, clause 3.2.2</para>
    ///   <a href="http://data.europa.eu/949/tsiTractionHarmonics">era:tsiTractionHarmonics</a>
    /// </summary>
    let tsiTractionHarmonics = _prefixId.prefix "tsiTractionHarmonics"
    /// <summary>
    ///   <para>rdfs:label : Tunnel</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.2.0.5^^xsd:stringera:rinfIndex : 1.2.1.0.5^^xsd:stringera:rinfIndex : 1.1.1.1.8^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tunnelDataParameter">era:tunnelDataParameter</a>
    /// </summary>
    let tunnelDataParameter = _prefixId.prefix "tunnelDataParameter"
    /// <summary>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-04-23^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>rdfs:label : Document available from the IM with precise description of the tunnel</para>
    ///   <para>era:rinfIndex : 1.1.1.1.8.8.2^^xsd:string</para>
    ///   <para>rdfs:comment : Electronic document available from the IM stored by the Agency with precise description of the clearance gauge and geometry of the tunnel.</para>
    ///   <para>era:XMLName : ITU_TunnelDocRef^^xsd:string</para>
    ///   <para>skos:scopeNote : The value of this parameter should be either a reference to a file name or an external link to a document.
    /// If a file name is provided, the Infrastructure Manager (IM) must upload a document with the same file name using the "Reference Documents Management" functionality in the RINF application. The document must be in electronic format and available in two official EU languages. In this case, the parameter value must be repeated for each document.
    /// If an external link is provided, the IM must ensure that the document is available at the provided link.</para>
    ///   <para>era:legalDeadline : 1 January 2021</para>
    ///   <a href="http://data.europa.eu/949/tunnelDocRef">era:tunnelDocRef</a>
    /// </summary>
    let tunnelDocRef = _prefixId.prefix "tunnelDocRef"
    /// <summary>
    ///   <para>era:XMLName : OPTrackTunnelIdentification^^xsd:stringera:XMLName : OPSidingTunnelIdentification^^xsd:stringera:XMLName : SOLTunnelIdentification^^xsd:string</para>
    ///   <para>era:tsiOPEAppendixD2Index : 3.2.3^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.0.5.2^^xsd:stringera:rinfIndex : 1.2.2.0.5.2^^xsd:stringera:rinfIndex : 1.1.1.1.8.2^^xsd:string</para>
    ///   <para>skos:scopeNote : Here should be given the name, number, code or any other expression which is normally used for the identification of the tunnel other than mentioned in parameters 1.1.1.1.8.3   1.1.1.1.8.4. In case when tunnel does not have its own identification within the Member State, the IM should deliver it himself</para>
    ///   <para>rdfs:comment : Unique tunnel identification or unique tunnel number within Member State</para>
    ///   <para>dcterms:modified : 2021-09-13^^xsd:datedcterms:modified : 2025-03-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>rdfs:label : Tunnel identification</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tunnelIdentification">era:tunnelIdentification</a>
    /// </summary>
    let tunnelIdentification = _prefixId.prefix "tunnelIdentification"
    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.1.8.4^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-02-05^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Part of the End of tunnel that indicates the km of the line at the end of a tunnel.
    /// The End of tunnel is the Geographical coordinates in decimal degrees and km of the line at the end of a tunnel. The reason for deprecation is that the property is now a subproperty of lineReference in order to represent the kilometer in relation to a national railway line</para>
    ///   <para>dcterms:created : 2023-03-29^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : (deprecated) End of tunnel kilometer</para>
    ///   <para>era:XMLName : SOLTunnelEnd^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tunnelKilometerEnd">era:tunnelKilometerEnd</a>
    /// </summary>
    let tunnelKilometerEnd = _prefixId.prefix "tunnelKilometerEnd"
    /// <summary>
    ///   <para>dcterms:created : 2023-03-29^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-02-05^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : (deprecated) Start of tunnel kilometer</para>
    ///   <a href="http://data.europa.eu/949/tunnelKilometerStart">era:tunnelKilometerStart</a>
    /// </summary>
    let tunnelKilometerStart = _prefixId.prefix "tunnelKilometerStart"
    /// <summary>
    ///   <para>rdfs:label : Tunnel</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.2.0.5^^xsd:stringera:rinfIndex : 1.2.1.0.5^^xsd:stringera:rinfIndex : 1.1.1.1.8^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/tunnelObjParameter">era:tunnelObjParameter</a>
    /// </summary>
    let tunnelObjParameter = _prefixId.prefix "tunnelObjParameter"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2025-11-17^^xsd:date</para>
    ///   <para>rdfs:label : Type of traffic</para>
    ///   <para>rdfs:comment : Classification of the type of traffic carried on the element.</para>
    ///   <a href="http://data.europa.eu/949/typeOfTraffic">era:typeOfTraffic</a>
    /// </summary>
    let typeOfTraffic = _prefixId.prefix "typeOfTraffic"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the registrationVersion with Ids 10, 20 and 30 indicating registration according to Directive 2008/57/EC and implementing Decision 2011/665/EU, and 40 and 50 indicating registration according to regime described in Directive 2008/57/EC.
    /// The allowed values for this property belong to the SKOS Concept Scheme http://data.europa.eu/949/concepts/type-version-ids/TypeVersionIds.</para>
    ///   <para>rdfs:label : Type version id</para>
    ///   <para>dcterms:created : 2022-11-03^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/typeVersionId">era:typeVersionId</a>
    /// </summary>
    let typeVersionId = _prefixId.prefix "typeVersionId"
    /// <summary>
    ///   <para>dcterms:modified : 2020-11-22^^xsd:date</para>
    ///   <para>rdfs:comment : Serial number that identifies a vehicle type.</para>
    ///   <para>dcterms:created : 2020-11-22^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Type version number</para>
    ///   <a href="http://data.europa.eu/949/typeVersionNumber">era:typeVersionNumber</a>
    /// </summary>
    let typeVersionNumber = _prefixId.prefix "typeVersionNumber"
    /// <summary>
    ///   <para>skos:scopeNote : Specific for the French network. It may concern DC 1.5kV and AC 25kV.
    ///
    ///           For RINF XML data sets:
    /// As long as the data provision through XML data sets is allowed, an XML attribute called “Set” will be used to link the value of this parameter to the parameter 1.1.1.2.2.1.1 / ECS_SystemType</para>
    ///   <para>era:legalDeadline : 16 January 2020</para>
    ///   <para>rdfs:seeAlso : ENE TSI: 4.2.4.1</para>
    ///   <para>dcterms:modified : 2025-02-28^^xsd:datedcterms:modified : 2024-09-25^^xsd:datedcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>dcterms:created : 2020-08-24^^xsd:date</para>
    ///   <para>rdfs:label : Umax2 for the French network</para>
    ///   <para>era:XMLName : ECS_Umax2^^xsd:string</para>
    ///   <para>era:dependencyNote : When `not electrified` is chosen in parameter 1.1.1.2.2.1.1, then this parameter is not applicable.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.2.2.1.3^^xsd:string</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Highest non-permanent voltage (Umax2) for France on lines not compliant with values defined in the EN50163:2004+A1:2007+A2:2020+A3:2022</para>
    ///   <a href="http://data.europa.eu/949/umax2">era:umax2</a>
    /// </summary>
    let umax2 = _prefixId.prefix "umax2"
    /// <summary>
    ///   <para>rdfs:label : Unit of measure</para>
    ///   <para>rdfs:comment : Magnitude of a quantity, defined and adopted by convention or by law, that is used as a standard for measurement of the same kind of quantity.</para>
    ///   <para>dcterms:modified : 2024-08-13^^xsd:date</para>
    ///   <para>dcterms:created : 2024-05-16^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/unitOfMeasure">era:unitOfMeasure</a>
    /// </summary>
    let unitOfMeasure = _prefixId.prefix "unitOfMeasure"
    /// <summary>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2025-02-24^^xsd:datedcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.2.0.0.0.2^^xsd:string</para>
    ///   <para>rdfs:comment : Code composed of country code and alphanumeric operational point code.</para>
    ///   <para>rdfs:label : Unique OP ID</para>
    ///   <para>era:XMLName : UniqueOPID^^xsd:string</para>
    ///   <para>rdfs:seeAlso : ISO 3166-1 alpha 2^^xsd:string</para>
    ///   <para>skos:scopeNote : Explanation on data presentation: The first two characters represent the country code in two-letter system of ISO.
    /// The second part  AAAAAAAAAA  is maximum 10 Characters String corresponding to OP code within the MS.
    /// 'LUAB4' or 'LUAB46TH-G' or 'LUAB4/-_ERT7' are accepted by the validation process.
    /// In case of  borders point , the code is to be selected in the corresponding list in annex 5.1 (this first part  AA  is EU. The second part is  AAAAAAAAAA ). Any OP ID that is not referenced in the annex 5.1 will not be accepted by the validation process.
    /// In case of  domestic borders point , the code will be selected in the corresponding list in annex 5.2 that will be developed later.
    /// Any OP ID that is not referenced in the annex 5.1 will not be accepted by the validation process.
    /// The provided OP ID must be unique within each Member State. The validation has to be made nationally by NRE. The exceptions are  Border point  and  domestic border point  that must be referenced in annex 5.1.</para>
    ///   <para>era:formatNote : CCAAAAAAAAAA
    /// The first part  CC  is the country code in two-letter system of ISO.
    /// The second part is alphanumeric OP code within the MS.
    /// For example, an OP code could be current abbreviation of name used in route books.
    /// In case of borders point, the code is to be selected in the corresponding list in annex 5.1^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:tsiOPEAppendixD2Index : 2.2.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/uopid">era:uopid</a>
    /// </summary>
    let uopid = _prefixId.prefix "uopid"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://eur-lex.europa.eu/eli/reg_impl/2019/773/oj#:~:text=Commission%20Implementing%20Regulation^^xsd:anyURI</para>
    ///   <para>rdfs:label : Parameter is used in Route Compatibility Check (RCC) calculations</para>
    ///   <para>rdfs:comment : Indicates whether a RINF parameter is used in Route Compatibility Check calculations according to Commission Implementing Regulation (EU) 2019/773 of 16 May 2019 on the technical specification for interoperability relating to the operation and traffic management subsystem of the rail system within the European Union and repealing Decision.</para>
    ///   <para>dcterms:created : 2023-04-12^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/usedInRCCCalculations">era:usedInRCCCalculations</a>
    /// </summary>
    let usedInRCCCalculations = _prefixId.prefix "usedInRCCCalculations"
    /// <summary>
    ///   <para>dcterms:created : 2020-08-31^^xsd:date</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>era:rinfIndex : 1.1.1.3.3.4^^xsd:stringera:rinfIndex : 1.2.1.1.2.4^^xsd:string</para>
    ///   <para>rdfs:comment : Indication if group 555 is used.</para>
    ///   <para>dcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2025-03-04^^xsd:datedcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>era:dependencyNote : GSM-R and ETCS L2 must be installed for this parameter to be applicable.</para>
    ///   <para>era:XMLName : CRG_Needof555^^xsd:string</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : 16 January 2020</para>
    ///   <para>skos:scopeNote : Sections of EIRENE not covered by references in TSI. GSM-R (parameter 1.1.1.3.3.1) and ETCS L2 (parameter 1.1.1.3.2.1) must be installed for this parameter to be applicable.</para>
    ///   <para>era:eratvIndex : 4.13.2.12^^xsd:string</para>
    ///   <para>rdfs:label : GSM-R use of group 555</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/usesGroup555">era:usesGroup555</a>
    /// </summary>
    let usesGroup555 = _prefixId.prefix "usesGroup555"
    /// <summary>
    ///   <para>dcterms:modified : 2023-03-14^^xsd:datedcterms:modified : 2024-12-05^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:rinfIndex : 1.1.1.3.2.16.3^^xsd:stringera:rinfIndex : 1.2.1.1.1.16.3^^xsd:string</para>
    ///   <para>skos:scopeNote : Format: [NNF], with N a decimal number (0÷9), [NNF] must be divisible by 5, so F=(0|5), max. `600`.
    ///
    /// See: TSI CCS (Subset-026, Chapter 7. 7.5.1.161)</para>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>era:formatNote : NNF, with N a decimal number (0 9), NNF must be divisible by 5, so F=(0|5), max. `600`^^xsd:string</para>
    ///   <para>rdfs:comment : Speed limit allowing the driver to select the  override  function in km/h
    /// According to the specification referenced in Appendix A-1, index [C]</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.5.3^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>rdfs:label : V_NVALLOWOVTRP</para>
    ///   <para>dcterms:created : 2022-11-07^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/vNvallowovtrp">era:vNvallowovtrp</a>
    /// </summary>
    let vNvallowovtrp = _prefixId.prefix "vNvallowovtrp"
    /// <summary>
    ///   <para>era:dependencyNote : A value has to be provided when ETCS is present (a value is provided on 1.1.1.3.2.1).</para>
    ///   <para>era:rinfIndex : 1.2.1.1.1.16.4^^xsd:stringera:rinfIndex : 1.1.1.3.2.16.4^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : V_NVSUPOVTRP</para>
    ///   <para>dcterms:modified : 2024-12-05^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2023-03-14^^xsd:date</para>
    ///   <para>dcterms:created : 2022-11-07^^xsd:date</para>
    ///   <para>era:tsiOPEAppendixD3Index : 1.5.4^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>era:formatNote : NNF, with N a decimal number (0 9), NNF must be divisible by 5, so F=(0|5), max. `600`^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/domains/technical-specifications-interoperability/control-command-and-signalling-tsi_en#oe-content-paragraph-1632^^xsd:anyURI</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>skos:scopeNote : Format: [NNF], with N a decimal number (0÷9), [NNF] is divisible by 5 so F=(0|5), max. `600`.
    ///
    /// See: TSI CCS (Subset-026, chapter 7. 7.5.1.163 V_NVSUPOVTRP)</para>
    ///   <para>rdfs:comment : Override speed limit to be supervised when the "override" function is active in km/h.
    /// According to the specification referenced in Appendix A-1, index [C]</para>
    ///   <a href="http://data.europa.eu/949/vNvsupovtrp">era:vNvsupovtrp</a>
    /// </summary>
    let vNvsupovtrp = _prefixId.prefix "vNvsupovtrp"
    /// <summary>
    ///   <para>rdfs:label : validity</para>
    ///   <para>rdfs:comment : Relates a feature with a temporal feature to indicate a validity period.</para>
    ///   <para>dcterms:modified : 2024-11-29^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/validity">era:validity</a>
    /// </summary>
    let validity = _prefixId.prefix "validity"
    /// <summary>
    ///   <para>skos:editorialNote : To be deprecated with the introduction of temporal entity</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Validity end date</para>
    ///   <para>dcterms:created : 2022-10-19^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/validityEndDate">era:validityEndDate</a>
    /// </summary>
    let validityEndDate = _prefixId.prefix "validityEndDate"
    /// <summary>
    ///   <para>skos:editorialNote : To be deprecated with the introduction of temporal entity</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Validity start date</para>
    ///   <para>dcterms:created : 2022-10-20^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/validityStartDate">era:validityStartDate</a>
    /// </summary>
    let validityStartDate = _prefixId.prefix "validityStartDate"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://eur-lex.europa.eu/eli/dec_impl/2011/665/2023-09-08#anx_III^^xsd:anyURI</para>
    ///   <para>era:eratvIndex : 1.4^^xsd:string</para>
    ///   <para>dcterms:created : 2025-02-13^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Vehicle category</para>
    ///   <para>rdfs:comment : Indicates the core purpose of a railway vehicle: delivering traction, transporting goods or passengers or serving as a special vehicle.</para>
    ///   <para>dcterms:modified : 2025-05-09^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/vehicleCategory">era:vehicleCategory</a>
    /// </summary>
    let vehicleCategory = _prefixId.prefix "vehicleCategory"
    /// <summary>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Mean contact force.</para>
    ///   <para>rdfs:label : Vehicle contact force</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.10.15^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/vehicleContactForce">era:vehicleContactForce</a>
    /// </summary>
    let vehicleContactForce = _prefixId.prefix "vehicleContactForce"
    /// <summary>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:datedcterms:modified : 2024-10-24^^xsd:datedcterms:modified : 2024-06-03^^xsd:date</para>
    ///   <para>dcterms:created : 2020-11-23^^xsd:date</para>
    ///   <para>rdfs:label : vehicle keeper</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The natural or legal person that, being the owner of a vehicle or having the right to use it,
    /// exploits the vehicle as a means of transport and is registered as such in a vehicle register referred to in Article 47 of (EU)2016/797.</para>
    ///   <a href="http://data.europa.eu/949/vehicleKeeper">era:vehicleKeeper</a>
    /// </summary>
    let vehicleKeeper = _prefixId.prefix "vehicleKeeper"
    /// <summary>
    ///   <para>rdfs:comment : Vehicle kinematic gauge  that corresponds to other gauges assessed using the kinematic method</para>
    ///   <para>dcterms:created : 2022-05-30^^xsd:date</para>
    ///   <para>rdfs:label : Vehicle kinematic gauge other</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.2.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/vehicleKinematicGaugeOther">era:vehicleKinematicGaugeOther</a>
    /// </summary>
    let vehicleKinematicGaugeOther = _prefixId.prefix "vehicleKinematicGaugeOther"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Vehicle Maximum sanding output, given in grams per second.</para>
    ///   <para>dcterms:modified : 2021-09-01^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.14.2.13^^xsd:string</para>
    ///   <para>rdfs:label : Vehicle max sanding output</para>
    ///   <para>dcterms:created : 2021-09-01^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/vehicleMaxSandingOutput">era:vehicleMaxSandingOutput</a>
    /// </summary>
    let vehicleMaxSandingOutput = _prefixId.prefix "vehicleMaxSandingOutput"
    /// <summary>
    ///   <para>rdfs:comment : Identification number of a vehicle or wagon.</para>
    ///   <para>dcterms:modified : 2020-11-24^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2020-11-24^^xsd:date</para>
    ///   <para>rdfs:label : Vehicle number</para>
    ///   <a href="http://data.europa.eu/949/vehicleNumber">era:vehicleNumber</a>
    /// </summary>
    let vehicleNumber = _prefixId.prefix "vehicleNumber"
    /// <summary>
    ///   <para>dcterms:modified : 2020-11-03^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.10.6^^xsd:string</para>
    ///   <para>rdfs:comment : Pantograph head geometry (to be indicated for each energy supply system the vehicle is equipped for).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Vehicle pantograph head</para>
    ///   <para>dcterms:created : 2020-08-25^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/vehiclePantographHead">era:vehiclePantographHead</a>
    /// </summary>
    let vehiclePantographHead = _prefixId.prefix "vehiclePantographHead"
    /// <summary>
    ///   <para>rdfs:label : Vehicle series</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Manufacturing series of a vehicle.</para>
    ///   <para>dcterms:created : 2020-11-22^^xsd:date</para>
    ///   <para>dcterms:modified : 2020-11-22^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/vehicleSeries">era:vehicleSeries</a>
    /// </summary>
    let vehicleSeries = _prefixId.prefix "vehicleSeries"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://eur-lex.europa.eu/eli/dec_impl/2011/665/2023-09-08#anx_III^^xsd:anyURI</para>
    ///   <para>era:eratvIndex : 1.5^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Vehicle subcategory</para>
    ///   <para>dcterms:created : 2025-02-13^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates the further classification (but not any family/platform) of vehicles within a vehicle category.</para>
    ///   <para>dcterms:modified : 2025-05-09^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/vehicleSubCategory">era:vehicleSubCategory</a>
    /// </summary>
    let vehicleSubCategory = _prefixId.prefix "vehicleSubCategory"

    /// <summary>
    ///   <para>rdfs:label : Vehicle technical characteristic</para>
    ///   <a href="http://data.europa.eu/949/vehicleTechnicalDataCharacteristic">era:vehicleTechnicalDataCharacteristic</a>
    /// </summary>
    let vehicleTechnicalDataCharacteristic = _prefixId.prefix "vehicleTechnicalDataCharacteristic"

    /// <summary>
    ///   <para>rdfs:label : Vehicle technical characteristic</para>
    ///   <a href="http://data.europa.eu/949/vehicleTechnicalObjCharacteristic">era:vehicleTechnicalObjCharacteristic</a>
    /// </summary>
    let vehicleTechnicalObjCharacteristic = _prefixId.prefix "vehicleTechnicalObjCharacteristic"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the vehicle type of a specific vehicle or wagon.</para>
    ///   <para>rdfs:label : Vehicle type</para>
    ///   <para>dcterms:created : 2020-11-22^^xsd:date</para>
    ///   <para>dcterms:modified : 2020-11-22^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/vehicleType">era:vehicleType</a>
    /// </summary>
    let vehicleType = _prefixId.prefix "vehicleType"

    /// <summary>
    ///   <para>era:eratvIndex : 4.6.4^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:label : Vehicle type maximum cant deficiency</para>
    ///   <para>rdfs:comment : Part of the combination of maximum speed and maximum cant deficiency for which the vehicle was assessed. Corresponds to the maximum cant deficiency.</para>
    ///   <a href="http://data.europa.eu/949/vehicleTypeMaximumCantDeficiency">era:vehicleTypeMaximumCantDeficiency</a>
    /// </summary>
    let vehicleTypeMaximumCantDeficiency = _prefixId.prefix "vehicleTypeMaximumCantDeficiency"

    /// <summary>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Part of the combination of maximum speed and maximum cant deficiency for which the vehicle was assessed. Corresponds to the maximum speed.</para>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>rdfs:label : Vehicle type maximum speed</para>
    ///   <para>era:eratvIndex : 4.6.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/vehicleTypeMaximumSpeed">era:vehicleTypeMaximumSpeed</a>
    /// </summary>
    let vehicleTypeMaximumSpeed = _prefixId.prefix "vehicleTypeMaximumSpeed"

    /// <summary>
    ///   <para>dcterms:created : 2023-04-05^^xsd:date</para>
    ///   <para>dcterms:modified : 2025-02-18^^xsd:date</para>
    ///   <para>rdfs:label : Vehicle type maximum speed and cant deficiency</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Relates the vehicle type with its values of maximum speed and cant deficiency.</para>
    ///   <para>era:eratvIndex : 4.6.4^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/vehicleTypeMaximumSpeedAndCantDeficiency">era:vehicleTypeMaximumSpeedAndCantDeficiency</a>
    /// </summary>
    let vehicleTypeMaximumSpeedAndCantDeficiency = _prefixId.prefix "vehicleTypeMaximumSpeedAndCantDeficiency"

    /// <summary>
    ///   <para>rdfs:label : Vehicle type technical characteristic</para>
    ///   <a href="http://data.europa.eu/949/vehicleTypeTechnicalDataCharacteristic">era:vehicleTypeTechnicalDataCharacteristic</a>
    /// </summary>
    let vehicleTypeTechnicalDataCharacteristic = _prefixId.prefix "vehicleTypeTechnicalDataCharacteristic"

    /// <summary>
    ///   <para>rdfs:label : Vehicle type technical characteristic</para>
    ///   <para>dcterms:created : 2024-10-31^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/vehicleTypeTechnicalObjectCharacteristic">era:vehicleTypeTechnicalObjectCharacteristic</a>
    /// </summary>
    let vehicleTypeTechnicalObjectCharacteristic = _prefixId.prefix "vehicleTypeTechnicalObjectCharacteristic"

    /// <summary>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>dcterms:modified : 2025-10-17^^xsd:datedcterms:modified : 2024-10-24^^xsd:datedcterms:modified : 2025-03-10^^xsd:datedcterms:modified : 2025-03-11^^xsd:date</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.5.1^^xsd:string</para>
    ///   <para>rdfs:label : List of vehicle types already identified as compatible with Traffic load and load carrying capacity of infrastructure and train detection systems</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The infrastructure managers shall provide through RINF the information to the RU regarding list of vehicle types compatible with the route for which they have already verified compatibility for parameter Traffic load and load carrying capacity of infrastructure and train detection systems, where such information is available.</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/vehicleTypesCompatibleTrafficLoad">era:vehicleTypesCompatibleTrafficLoad</a>
    /// </summary>
    let vehicleTypesCompatibleTrafficLoad = _prefixId.prefix "vehicleTypesCompatibleTrafficLoad"

    /// <summary>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide</para>
    ///   <para>dcterms:modified : 2025-03-11^^xsd:datedcterms:modified : 2024-10-24^^xsd:datedcterms:modified : 2025-10-17^^xsd:datedcterms:modified : 2025-03-10^^xsd:date</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.5.2^^xsd:string</para>
    ///   <para>rdfs:comment : The infrastructure managers shall provide through RINF the information or a document to the RU regarding list of vehicles compatible with the route for which they have already verified compatibility for parameter Traffic load and load carrying capacity of infrastructure and train detection systems, where such information is available.</para>
    ///   <para>dcterms:created : 2023-03-14^^xsd:date</para>
    ///   <para>rdfs:label : List of vehicles already identified as compatible with Traffic load and load carrying capacity of infrastructure and train detection systems</para>
    ///   <a href="http://data.europa.eu/949/vehiclesCompatibleTrafficLoad">era:vehiclesCompatibleTrafficLoad</a>
    /// </summary>
    let vehiclesCompatibleTrafficLoad = _prefixId.prefix "vehiclesCompatibleTrafficLoad"

    /// <summary>
    ///   <para>dcterms:modified : 2021-08-25^^xsd:date</para>
    ///   <para>rdfs:comment : Number of vehicles composing the fixed formation (for fixed formation only). Note: the value is mandatory for all vehicle categories. If the vehicle is composed of only one car, the indicated value shall be '1'.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.1.12^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-25^^xsd:date</para>
    ///   <para>rdfs:label : Vehicles composing fixed formation</para>
    ///   <a href="http://data.europa.eu/949/vehiclesComposingFixedFormation">era:vehiclesComposingFixedFormation</a>
    /// </summary>
    let vehiclesComposingFixedFormation = _prefixId.prefix "vehiclesComposingFixedFormation"

    /// <summary>
    ///   <para>rdfs:label : EC declaration of verification for track relating to compliance with the requirements from TSIs applicable to control, command signalling subsystem</para>
    ///   <para>era:formatNote : CC/RRRRRRRRRRRRRR/YYYY/NNNNNN^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>skos:scopeNote : (CCS) in title means that here we include only declarations concerning command   control and signalling subsystem on the specific track. For the specific track the several EC declarations may be issued, so parameter has to repeated as many times as many numbers of declarations has to be presented.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:XMLName : CDE_ECVerification^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.3.1.1^^xsd:string</para>
    ///   <para>rdfs:comment : Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250.</para>
    ///   <a href="http://data.europa.eu/949/verificationCCS">era:verificationCCS</a>
    /// </summary>
    let verificationCCS = _prefixId.prefix "verificationCCS"
    /// <summary>
    ///   <para>era:rinfIndex : 1.1.1.2.1.1^^xsd:string</para>
    ///   <para>rdfs:label : EC declaration of verification for track relating to compliance with the requirements from TSIs applicable to energy subsystem</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:date</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:XMLName : EDE_ECVerification^^xsd:string</para>
    ///   <para>rdfs:comment : Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250.</para>
    ///   <para>dcterms:created : 2021-08-08^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/verificationENE">era:verificationENE</a>
    /// </summary>
    let verificationENE = _prefixId.prefix "verificationENE"
    /// <summary>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250.</para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>skos:scopeNote : The parameter may be repeated only when several EC declarations were issued related to the INF subsystem.
    /// With the extension of scope according to the IOD, geographical scope of the INF TSI now includes all the networks (TEN and off-TEN) with the following nominal track gauges: 1435, 1520, 1524, 1600 and 1668 mm</para>
    ///   <para>era:rinfIndex : 1.2.1.0.1.1^^xsd:stringera:rinfIndex : 1.1.1.1.1.1^^xsd:stringera:rinfIndex : 1.2.2.0.1.1^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>rdfs:label : EC declaration of verification for infrastructure element relating to compliance with the requirements from TSIs applicable to infrastructure subsystem</para>
    ///   <para>era:XMLName : IDE_ECVerification^^xsd:string</para>
    ///   <para>era:formatNote : CC/RRRRRRRRRRRRRR/YYYY/NNNNNN^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <a href="http://data.europa.eu/949/verificationINF">era:verificationINF</a>
    /// </summary>
    let verificationINF = _prefixId.prefix "verificationINF"
    /// <summary>
    ///   <para>era:rinfIndex : 1.2.2.0.5.3^^xsd:stringera:rinfIndex : 1.1.1.1.8.5^^xsd:stringera:rinfIndex : 1.2.1.0.5.3^^xsd:string</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:formatNote : CC/RRRRRRRRRRRRRR/YYYY/NNNNNN^^xsd:string</para>
    ///   <para>rdfs:seeAlso : Document about practical arrangements for transmitting interoperability documents ERA/INF/10-2009/INT^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2024-09-19^^xsd:date</para>
    ///   <para>era:XMLName : ITU_ECVerification^^xsd:string</para>
    ///   <para>rdfs:label : EC declaration of verification relating to compliance with the requirements from TSIs applicable to railway tunnel</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : (SRT) in title means that here we include only declarations concerning requirements of SRT TSI for infrastructure system on the specific track.
    /// Parameter shall be repeated when different EC declarations were issued for different elements of infrastructure subsystem on the specific track in the tunnel.
    /// With the extension of scope according to Interoperability Directive 2016/797, geographical scope of the INF, ENE and CCS TSIs now includes all the networks (TEN and off-TEN) with the following nominal track gauges: 1435, 1520, 1524, 1600 and 1668 mm </para>
    ///   <para>dcterms:created : 2021-08-03^^xsd:date</para>
    ///   <para>rdfs:comment : Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250.</para>
    ///   <para>era:applicable : Y/N^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/verificationSRT">era:verificationSRT</a>
    /// </summary>
    let verificationSRT = _prefixId.prefix "verificationSRT"
    /// <summary>
    ///   <para>rdfs:label : Vehicles for which Route compatibility is verified</para>
    ///   <para>dcterms:created : 2025-03-11^^xsd:date</para>
    ///   <para>era:rinfIndex : 1.1.1.5^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/verifiedRccObjParameter">era:verifiedRccObjParameter</a>
    /// </summary>
    let verifiedRccObjParameter = _prefixId.prefix "verifiedRccObjParameter"
    /// <summary>
    ///   <para>rdfs:label : Voice GSM-R network</para>
    ///   <para>dcterms:created : 2020-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Voice SIM Card GSM-R Home Network. The allowed values for this property belong to the SKOS Concept Scheme http://data.europa.eu/949/concepts/gsmr-networks/GSMRNetworks</para>
    ///   <para>dcterms:modified : 2021-08-02^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:eratvIndex : 4.13.2.10^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/voiceGSMRNetwork">era:voiceGSMRNetwork</a>
    /// </summary>
    let voiceGSMRNetwork = _prefixId.prefix "voiceGSMRNetwork"
    /// <summary>
    ///   <para>rdfs:comment : Voice and operational communication implementation.</para>
    ///   <para>rdfs:label : Voice operational communication implementation</para>
    ///   <para>era:eratvIndex : 4.13.2.6^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/voiceOperationalCommImpl">era:voiceOperationalCommImpl</a>
    /// </summary>
    let voiceOperationalCommImpl = _prefixId.prefix "voiceOperationalCommImpl"
    /// <summary>
    ///   <para>dcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2024-04-18^^xsd:datedcterms:modified : 2021-09-12^^xsd:date</para>
    ///   <para>rdfs:seeAlso : https://www.era.europa.eu/system/files/2023-05/esc-rsc_technical_document_en.pdf^^xsd:anyURIrdfs:seeAlso : https://www.era.europa.eu/era-folder/radio-system-compatibility-rsc-voice-and-data-documents^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Radio requirements used for demonstrating technical compatibility voice.</para>
    ///   <para>dcterms:created : 2020-08-31^^xsd:date</para>
    ///   <para>era:legalDeadline : 12 months after publication of Article 7 Guide for OP tracksera:legalDeadline : 16 January 2020</para>
    ///   <para>era:eratvIndex : 4.13.2.5^^xsd:string</para>
    ///   <para>skos:scopeNote : Information on RSC voice requirements per country is given in the referred document.
    ///
    /// Vehicles are considered compatible with the infrastructure regarding this parameter, if any of the values declared matches.
    /// In case the value “Not Defined” or “RSC-EU-0” is used, repetitions with additional values are not expected.</para>
    ///   <para>era:XMLName : CRG_RadioCompVoice^^xsd:string</para>
    ///   <para>era:dependencyNote : GSM-R must be installed for this parameter to be applicable.
    /// In case of RSC-EU-0 or None, no other values are allowed.</para>
    ///   <para>rdfs:label : Radio system compatibility voice</para>
    ///   <para>era:applicable : Y/N/NYA^^xsd:string</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.2.1.1.2.9^^xsd:stringera:rinfIndex : 1.1.1.3.3.9^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/voiceRadioCompatible">era:voiceRadioCompatible</a>
    /// </summary>
    let voiceRadioCompatible = _prefixId.prefix "voiceRadioCompatible"
    /// <summary>
    ///   <para>era:eratvIndex : 4.1.3^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-01-08^^xsd:datedcterms:modified : 2025-11-19^^xsd:datedcterms:modified : 2024-09-19^^xsd:datedcterms:modified : 2025-02-28^^xsd:date</para>
    ///   <para>rdfs:label : Nominal track gauge</para>
    ///   <para>skos:scopeNote : In case of multi-rail track, a set of data is to be published separately to each pair of rails to be operated as separate track (the whole set of parameters for the separate track has to be delivered be careful then with the track identification). Nominal track gauges provided by the INF TSI are only 1435, 1520, 1524, 1600 and 1668.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2020-07-29^^xsd:date</para>
    ///   <para>rdfs:seeAlso : INF TSI: 4.2.4.1^^xsd:string</para>
    ///   <para>era:rinfIndex : 1.1.1.1.4.1^^xsd:stringera:rinfIndex : 1.2.1.0.4.1^^xsd:string</para>
    ///   <para>era:XMLName : ITP_NomGauge^^xsd:string</para>
    ///   <para>era:applicable : Y^^xsd:string</para>
    ///   <para>rdfs:comment : A single value expressed in millimetres that identifies the track gauge.</para>
    ///   <para>era:legalDeadline : In accordance with Implementing Decision 2014/880/EU and by 16 March 2019 at the latest</para>
    ///   <para>era:usedInRCCCalculations : true^^xsd:boolean</para>
    ///   <a href="http://data.europa.eu/949/wheelSetGauge">era:wheelSetGauge</a>
    /// </summary>
    let wheelSetGauge = _prefixId.prefix "wheelSetGauge"

    /// <summary>
    ///   <para>dcterms:created : 2020-09-01^^xsd:date</para>
    ///   <para>rdfs:label : Wheelset gauge changeover facility</para>
    ///   <para>era:eratvIndex : 4.1.11^^xsd:string</para>
    ///   <para>rdfs:comment : Wheelset gauge changeover facility. The allowed values for this property belong to the SKOS Concept Scheme http://data.europa.eu/949/concepts/gauge-changeover-facilities/GaugeChangeoverFacilities</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-08-24^^xsd:date</para>
    ///   <a href="http://data.europa.eu/949/wheelSetGaugeChangeoverFacility">era:wheelSetGaugeChangeoverFacility</a>
    /// </summary>
    let wheelSetGaugeChangeoverFacility = _prefixId.prefix "wheelSetGaugeChangeoverFacility"

    /// <summary>
    ///   <para>dcterms:modified : 2021-08-25^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Wheel gauge transformation method. Defined if more than one wheel gauges have been selected.</para>
    ///   <para>dcterms:created : 2021-08-25^^xsd:date</para>
    ///   <para>era:eratvIndex : 4.1.3.b^^xsd:string</para>
    ///   <para>rdfs:label : Wheel set gauge transformation method</para>
    ///   <a href="http://data.europa.eu/949/wheelSetGaugeTransformationMethod">era:wheelSetGaugeTransformationMethod</a>
    /// </summary>
    let wheelSetGaugeTransformationMethod = _prefixId.prefix "wheelSetGaugeTransformationMethod"

    /// <summary>
    ///   <para>era:eratvIndex : 4.12.2.4^^xsd:string</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:label : Wheelchair sleeping spaces</para>
    ///   <para>dcterms:modified : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:comment : Number of wheelchair accessible sleeping places.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/wheelchairSleepingPlaces">era:wheelchairSleepingPlaces</a>
    /// </summary>
    let wheelchairSleepingPlaces = _prefixId.prefix "wheelchairSleepingPlaces"
    /// <summary>
    ///   <para>dcterms:modified : 2023-01-23^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Number of wheelchair spaces.</para>
    ///   <para>dcterms:created : 2021-08-31^^xsd:date</para>
    ///   <para>rdfs:label : Wheelchair spaces</para>
    ///   <para>era:eratvIndex : 4.12.2.2^^xsd:string</para>
    ///   <a href="http://data.europa.eu/949/wheelchairSpaces">era:wheelchairSpaces</a>
    /// </summary>
    let wheelchairSpaces = _prefixId.prefix "wheelchairSpaces"
