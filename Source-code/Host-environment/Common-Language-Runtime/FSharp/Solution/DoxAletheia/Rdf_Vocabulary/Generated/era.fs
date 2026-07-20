namespace http.data.europa.eu._949.slash

open DoxAletheia

module era =
    let _namespace_name = "http://data.europa.eu/949/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A set of different infrastructure objects sharing the same common technical characteristics. The parameters may not be restricted to only one railway subsystem, but it can include common characteristics from each one of them (infrastructure, energy, track-side CCS)
    /// <see href="http://data.europa.eu/949/CommonCharacteristicsSubset"></see></summary>
    let CommonCharacteristicsSubset = _prefix "CommonCharacteristicsSubset"
    /// <summary>
    /// A running track means any track used for train service movements; passing loops and meeting loops on plain line or track connections only required for train operation are not published
    /// <see href="http://data.europa.eu/949/RunningTrack"></see></summary>
    let RunningTrack = _prefix "RunningTrack"
    /// <summary>
    /// A railway tunnel is an excavation or a construction around the track provided to allow the railway to pass for example higher land, buildings or water.
    /// <see href="http://data.europa.eu/949/Tunnel"></see></summary>
    let Tunnel = _prefix "Tunnel"
    /// <summary>
    /// A section of line means the part of line between adjacent operational points and may consist of several tracks.
    /// <see href="http://data.europa.eu/949/SectionOfLine"></see></summary>
    let SectionOfLine = _prefix "SectionOfLine"
    /// <summary>
    /// Platform for the purpose of RINF is understood as a platform edge. A platform concerns only the part of the structure neighbouring to the track (interfaced with trains).
    /// <see href="http://data.europa.eu/949/PlatformEdge"></see></summary>
    let PlatformEdge = _prefix "PlatformEdge"
    /// <summary>
    /// A vehicle type that has been authorized to operate on the EU railway infrastructure. Type means a vehicle type defining the basic design characteristics of the vehicle as covered by a type or design examination certificate described in the relevant verification module.
    ///
    /// Basic design characteristics means the parameters that are used to identify the vehicle type as specified in the issued vehicle type authorisation and recorded in the European Register of Authorised Vehicle Types ('ERATV').
    ///
    /// The above mentioned certificate should be documented using era:certificate.
    ///
    /// <see href="http://data.europa.eu/949/VehicleType"></see></summary>
    let VehicleType = _prefix "VehicleType"
    /// <summary>
    /// Sidings are all those tracks where running trains in service movements ends and which are not used for operational routing of a train.
    /// <see href="http://data.europa.eu/949/Siding"></see></summary>
    let Siding = _prefix "Siding"
    /// <summary>
    /// Safety system used to detect the presence of vehicles on the railway track.
    /// <see href="http://data.europa.eu/949/TrainDetectionSystem"></see></summary>
    let TrainDetectionSystem = _prefix "TrainDetectionSystem"
    /// <summary>
    /// System that is used to transmit electrical energy to road or rail vehicles.
    /// <see href="http://data.europa.eu/949/ContactLineSystem"></see></summary>
    let ContactLineSystem = _prefix "ContactLineSystem"
    /// <summary>
    /// This class encompasses all those classes that represent features that are  implemented in the European railway infrastructure. It is a subclass of the ERA Feature that has a spatial representation. It covers tracks, platforms, signals, tunnels, operational points, and sections of line.
    /// A feature that belongs to the infrastructure can be abstracted (hasAbstraction) as a topological object. It also is related to the infrastructure manager through the property infrastructureMgr.
    /// <see href="http://data.europa.eu/949/InfrastructureElement"></see></summary>
    let InfrastructureElement = _prefix "InfrastructureElement"
    /// <summary>
    /// A pair of rails over which rail borne vehicles can run.
    /// <see href="http://data.europa.eu/949/Track"></see></summary>
    let Track = _prefix "Track"
    /// <summary>
    /// Represents a linear positioning system used for referencing positions on the network.
    /// It can also represent a sequence of one or more sections of line, used for regular railway operations.
    /// <see href="http://data.europa.eu/949/LinearPositioningSystem"></see></summary>
    let LinearPositioningSystem = _prefix "LinearPositioningSystem"
    /// <summary>
    /// An operational point (OP) means any location for train service operations, where train services may begin and end or change route, and where passenger or freight services may be provided; operational point also means any location at boundaries between Member States or infrastructure managers.
    /// <see href="http://data.europa.eu/949/OperationalPoint"></see></summary>
    let OperationalPoint = _prefix "OperationalPoint"
    /// <summary>
    /// A railway signal is a visual display device (next to the tracks or via a DMI in the cabin) that conveys instructions or provides advance warning of instructions regarding the driver's authority to proceed.
    /// <see href="http://data.europa.eu/949/Signal"></see></summary>
    let Signal = _prefix "Signal"
    /// <summary>
    /// TSI compliant train protection system ERTMS / ETCS application level and baseline related to the track side equipment.
    /// <see href="http://data.europa.eu/949/ETCS"></see></summary>
    let ETCS = _prefix "ETCS"
    /// <summary>
    /// A reference to a specific railway line.
    /// <see href="http://data.europa.eu/949/LineReference"></see></summary>
    let LineReference = _prefix "LineReference"
    /// <summary>
    /// It is a structure constructed for the exclusive purpose of carrying railroad traffic across an obstruction. It can be used for defining non-stopping areas, big metal mass, resistance to traffic load etc.
    /// <see href="http://data.europa.eu/949/Bridge"></see></summary>
    let Bridge = _prefix "Bridge"
    /// <summary>
    /// Document in any of the ERA systems, e.g. reference document in RINF.
    /// <see href="http://data.europa.eu/949/Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// A specific vehicle or wagon able and allowed to operate over railway infrastructure.
    /// <see href="http://data.europa.eu/949/Vehicle"></see></summary>
    let Vehicle = _prefix "Vehicle"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/MinAxleLoadVehicleCategory"></see>
    /// </summary>
    let MinAxleLoadVehicleCategory = _prefix "MinAxleLoadVehicleCategory"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/_:genid-nodeid-node1jfsuh0nsx2"></see>
    /// </summary>
    let ``_:genid-nodeid-node1jfsuh0nsx2`` = _prefix "_:genid-nodeid-node1jfsuh0nsx2"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/_:genid-nodeid-node1jfsuh0nsx3"></see>
    /// </summary>
    let ``_:genid-nodeid-node1jfsuh0nsx3`` = _prefix "_:genid-nodeid-node1jfsuh0nsx3"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/_:genid-nodeid-node1jfsuh0nsx4"></see>
    /// </summary>
    let ``_:genid-nodeid-node1jfsuh0nsx4`` = _prefix "_:genid-nodeid-node1jfsuh0nsx4"
    /// <summary>
    /// Is an organisation or a physical person
    /// <see href="http://data.europa.eu/949/Body"></see></summary>
    let Body = _prefix "Body"
    /// <summary>
    /// Annotation used to point to the SHACL shape that implements the validation for a certain RINF parameter (property). Each shape contains constraints for valid datatypes, patterns, min and max count, valid SKOS values and business rules.
    /// <see href="http://data.europa.eu/949/shaclShapeValidationRule"></see></summary>
    let shaclShapeValidationRule = _prefix "shaclShapeValidationRule"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BodyShape"></see>
    /// </summary>
    let ``shapes/BodyShape`` = _prefix "shapes/BodyShape"
    /// <summary>
    /// The natural or legal person that, being the owner of a vehicle or having the right to use it,
    /// exploits the vehicle as a means of transport and is registered as such in a vehicle register referred to in Article 47 of (EU)2016/797.
    /// <see href="http://data.europa.eu/949/VehicleKeeper"></see></summary>
    let VehicleKeeper = _prefix "VehicleKeeper"
    /// <summary>
    /// (deprecated) Replaced by the era:Body class and era:manufacturer property. A company or organization that manufactures vehicles.
    /// <see href="http://data.europa.eu/949/Manufacturer"></see></summary>
    let Manufacturer = _prefix "Manufacturer"
    /// <summary>
    /// (deprecated) The infrastructure manager owns and operates the railway network and related infrastructure.
    /// <see href="http://data.europa.eu/949/InfrastructureManager"></see></summary>
    let InfrastructureManager = _prefix "InfrastructureManager"
    /// <summary>
    /// Represents an n-ary relationship between a Body and a role
    /// <see href="http://data.europa.eu/949/OrganisationRole"></see></summary>
    let OrganisationRole = _prefix "OrganisationRole"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BridgeShape"></see>
    /// </summary>
    let ``shapes/BridgeShape`` = _prefix "shapes/BridgeShape"
    /// <summary>
    /// Encompasses all those areas (outside of the operational gauge) or sections (those in tunnels excluded) which influence operation in the gauge itself, such as
    /// - safe areas,
    /// - restricted areas (non-stopping areas or industrial risk locations).
    ///
    /// For these areas in tunnels, use era:SpecialTunnelArea.
    /// <see href="http://data.europa.eu/949/SpecialArea"></see></summary>
    let SpecialArea = _prefix "SpecialArea"
    /// <summary>
    /// Primary Location is a place used by IM to define a path for a train in TAF/TAP TSI framework/messages. This location is a rail point inside the rail network where train starts, ends, stops, or runs through or change line. This location must be managed by an Infrastructure Manager (IM) identified by company code.
    ///
    /// Primary locations are identified by single and unique Primary Location codes. Primary location code is allocated based on processes defined by national entity. Primary location codes are used in any kind of TAF/TAP communication.
    ///
    /// See: Handbook 9.3.3 / page 60
    /// <see href="http://data.europa.eu/949/PrimaryLocation"></see></summary>
    let PrimaryLocation = _prefix "PrimaryLocation"
    /// <summary>
    /// Represents a kilometric post in the linear positioning system.
    /// <see href="http://data.europa.eu/949/KilometricPost"></see></summary>
    let KilometricPost = _prefix "KilometricPost"
    /// <summary>
    /// ETCS trackside centralised unit controlling ETCS train movements in level 2.
    ///
    /// A centralised safety unit that receives train position information via radio and sends movement authorities via radio to trains.
    /// <see href="http://data.europa.eu/949/RadioBlockCenter"></see></summary>
    let RadioBlockCenter = _prefix "RadioBlockCenter"
    /// <summary>
    /// A unit of track comprising two fixed rails (stock rails) and two movable rails (switch rails) used to direct vehicles from one track to another track.
    /// <see href="http://data.europa.eu/949/Switch"></see></summary>
    let Switch = _prefix "Switch"
    /// <summary>
    /// A level crossing is an intersection where a railway line crosses a road or a path at the same level. It can be used for the implementation of the ETCS trackside or to identify potential collision scenarios
    /// <see href="http://data.europa.eu/949/LevelCrossing"></see></summary>
    let LevelCrossing = _prefix "LevelCrossing"
    /// <summary>
    /// A trackside Hot Axle Box Detector (HABD), necessary for the route compatibility check.
    /// Specific for the French, Italian and Swedish networks
    /// <see href="http://data.europa.eu/949/HABD"></see></summary>
    let HABD = _prefix "HABD"
    /// <summary>
    /// Certificate of a vehicle type. Can be in one of the following states: Amended, New, Suspended, Withdrawn.
    /// <see href="http://data.europa.eu/949/Certificate"></see></summary>
    let Certificate = _prefix "Certificate"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CommonCharacteristicsSubsetShape"></see>
    /// </summary>
    let ``shapes/CommonCharacteristicsSubsetShape`` =
        _prefix "shapes/CommonCharacteristicsSubsetShape"

    /// <summary>
    /// Class that encompasses the features that are part of the physical infrastructure (class InfrastructureElement) and the topological objects (class TopologicalObject). It is a subclass of the geographical Feature class that has a spatial representation.
    /// <see href="http://data.europa.eu/949/Feature"></see></summary>
    let Feature = _prefix "Feature"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactLineSystemShape"></see>
    /// </summary>
    let ``shapes/ContactLineSystemShape`` = _prefix "shapes/ContactLineSystemShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DocumentShape"></see>
    /// </summary>
    let ``shapes/DocumentShape`` = _prefix "shapes/DocumentShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ETCSShape"></see>
    /// </summary>
    let ``shapes/ETCSShape`` = _prefix "shapes/ETCSShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FeatureShape"></see>
    /// </summary>
    let ``shapes/FeatureShape`` = _prefix "shapes/FeatureShape"
    /// <summary>
    /// The union of TemporalDuration that represents a time extent and TemporalEntity that represents a temporal interval or instant.
    /// <see href="http://data.europa.eu/949/TemporalFeature"></see></summary>
    let TemporalFeature = _prefix "TemporalFeature"

    /// <summary>
    /// Specific for route compatibility check on French network.
    /// <see href="http://data.europa.eu/949/FrenchTrainDetectionSystemLimitation"></see></summary>
    let FrenchTrainDetectionSystemLimitation =
        _prefix "FrenchTrainDetectionSystemLimitation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationShape"></see>
    /// </summary>
    let ``shapes/FrenchTrainDetectionSystemLimitationShape`` =
        _prefix "shapes/FrenchTrainDetectionSystemLimitationShape"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InfrastructureElementShape"></see>
    /// </summary>
    let ``shapes/InfrastructureElementShape`` =
        _prefix "shapes/InfrastructureElementShape"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/KilometricPostShape"></see>
    /// </summary>
    let ``shapes/KilometricPostShape`` = _prefix "shapes/KilometricPostShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LevelCrossingShape"></see>
    /// </summary>
    let ``shapes/LevelCrossingShape`` = _prefix "shapes/LevelCrossingShape"
    /// <summary>
    /// Pieces of tracks composing the topology
    /// <see href="http://data.europa.eu/949/LinearElement"></see></summary>
    let LinearElement = _prefix "LinearElement"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinearElementShape"></see>
    /// </summary>
    let ``shapes/LinearElementShape`` = _prefix "shapes/LinearElementShape"
    /// <summary>
    /// It is a representation of all building blocks of the topology. It references an associated topological network element.
    /// <see href="http://data.europa.eu/949/NetElement"></see></summary>
    let NetElement = _prefix "NetElement"
    /// <summary>
    /// Represents a non-linear element in the network.
    /// <see href="http://data.europa.eu/949/NonLinearElement"></see></summary>
    let NonLinearElement = _prefix "NonLinearElement"
    /// <summary>
    /// Represents a section of a linear element.
    /// <see href="http://data.europa.eu/949/LinearElementSection"></see></summary>
    let LinearElementSection = _prefix "LinearElementSection"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinearElementSectionShape"></see>
    /// </summary>
    let ``shapes/LinearElementSectionShape`` =
        _prefix "shapes/LinearElementSectionShape"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinearPositioningSystemShape"></see>
    /// </summary>
    let ``shapes/LinearPositioningSystemShape`` =
        _prefix "shapes/LinearPositioningSystemShape"

    /// <summary>
    /// Represents coordinates in a linear positioning system.
    /// <see href="http://data.europa.eu/949/LinearPositioningSystemCoordinate"></see></summary>
    let LinearPositioningSystemCoordinate = _prefix "LinearPositioningSystemCoordinate"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinearPositioningSystemCoordinateShape"></see>
    /// </summary>
    let ``shapes/LinearPositioningSystemCoordinateShape`` =
        _prefix "shapes/LinearPositioningSystemCoordinateShape"

    /// <summary>
    /// Frequency, appearance and positioning of a sign indicating distance as reference post. Two types of signs are normally available: kilometre post and hectometre post.
    /// - A kilometre post is a lineside sign indicating the distance from a specific point, usually being the starting point of the railway line.
    /// - A hectometre post is a lineside sign indicating a relative distance.
    /// <see href="http://data.europa.eu/949/LinesideDistanceIndication"></see></summary>
    let LinesideDistanceIndication = _prefix "LinesideDistanceIndication"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationShape"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationShape`` =
        _prefix "shapes/LinesideDistanceIndicationShape"

    /// <summary>
    /// This class together with properties loadCapabilityLineCategory and loadCapabilitySpeed replaces the previous loadCapability SKOS property.
    /// A combination of the line category and speed at the weakest point of the track.
    /// Each track can have several load capability (structured) values, and each one has values for load model line category and load model speed.
    /// <see href="http://data.europa.eu/949/LoadCapability"></see></summary>
    let LoadCapability = _prefix "LoadCapability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LoadCapabilityShape"></see>
    /// </summary>
    let ``shapes/LoadCapabilityShape`` = _prefix "shapes/LoadCapabilityShape"
    /// <summary>
    /// A combination of the line category and speed at the weakest point of the track. The reason for deprecation is that the load capability property 1.1.1.1.2.4 was defined incorrectly as a SKOS property. It is composed of two values: (1)  line category, and (2) speed. Only line category is a list of predefined values (SKOS), whereas speed is an integer (according to the RINF application guide).
    /// <see href="http://data.europa.eu/949/loadCapability"></see></summary>
    let loadCapability = _prefix "loadCapability"
    /// <summary>
    /// Vehicle manufacturer company.
    /// <see href="http://data.europa.eu/949/manufacturer"></see></summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/MaximumMagneticField"></see>
    /// </summary>
    let MaximumMagneticField = _prefix "MaximumMagneticField"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumMagneticFieldShape"></see>
    /// </summary>
    let ``shapes/MaximumMagneticFieldShape`` =
        _prefix "shapes/MaximumMagneticFieldShape"

    /// <summary>
    /// Indication of types of train detection systems installed.
    /// <see href="http://data.europa.eu/949/trainDetectionSystemType"></see></summary>
    let trainDetectionSystemType = _prefix "trainDetectionSystemType"
    /// <summary>
    /// Combination of maximum speed and maximum cant deficiency for which the vehicle was assessed.
    /// <see href="http://data.europa.eu/949/MaximumSpeedAndCantDeficiency"></see></summary>
    let MaximumSpeedAndCantDeficiency = _prefix "MaximumSpeedAndCantDeficiency"
    /// <summary>
    /// Combination of maximum speed and maximum cant deficiency for which the vehicle was assessed.
    ///
    /// This property was before an object skos property. The values for this property do not come from a list of predefined values. Thus, the original object property was replaced by this datatype property with range xsd:string.
    /// Deprecated because of replacement by a class and two integer properties. The reason is that the property represents two concepts: [number] km/h for maximum speed - [number] mm for maximum cant deficiency.
    /// <see href="http://data.europa.eu/949/maximumSpeedAndCantDeficiency"></see></summary>
    let maximumSpeedAndCantDeficiency = _prefix "maximumSpeedAndCantDeficiency"
    /// <summary>
    /// Impedance as defined in the TSI CCS (Annex I, Appendix A, Table A.2 -Index 77).
    ///
    /// Minimum vehicle impedance (between wheels and pantograph) (only for vehicles equipped for 1500V or 3000V DC).
    ///
    /// Per Voltage:
    /// [1500]: [CCCC]+[ZZZZ], with input capacitance [CCCC](Cin) and input impedance [ZZZZ](Zin)
    /// [3000]: [CCCC]+[ZZZZ], idem.
    /// <see href="http://data.europa.eu/949/MinVehicleImpedance"></see></summary>
    let MinVehicleImpedance = _prefix "MinVehicleImpedance"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleImpedanceShape"></see>
    /// </summary>
    let ``shapes/MinVehicleImpedanceShape`` = _prefix "shapes/MinVehicleImpedanceShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/MinimumVerticalRadius"></see>
    /// </summary>
    let MinimumVerticalRadius = _prefix "MinimumVerticalRadius"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumVerticalRadiusShape"></see>
    /// </summary>
    let ``shapes/MinimumVerticalRadiusShape`` =
        _prefix "shapes/MinimumVerticalRadiusShape"

    /// <summary>
    /// Railway line within a member state.
    /// A line is a sequence of one or more sections of line, which connects operational points and which may consist of several tracks used for regular railway operation.
    /// <see href="http://data.europa.eu/949/NationalRailwayLine"></see></summary>
    let NationalRailwayLine = _prefix "NationalRailwayLine"
    /// <summary>
    /// Represents an area reference in the network.
    /// <see href="http://data.europa.eu/949/NetAreaReference"></see></summary>
    let NetAreaReference = _prefix "NetAreaReference"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetAreaReferenceShape"></see>
    /// </summary>
    let ``shapes/NetAreaReferenceShape`` = _prefix "shapes/NetAreaReferenceShape"
    /// <summary>
    /// Basic positioning reference within the ERA ontology. It represents different types of geographical locations. Geographical coordinates are provided according to the standard World Geodetic System (WGS84).
    /// <see href="http://data.europa.eu/949/NetBasicReference"></see></summary>
    let NetBasicReference = _prefix "NetBasicReference"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetBasicReferenceShape"></see>
    /// </summary>
    let ``shapes/NetBasicReferenceShape`` = _prefix "shapes/NetBasicReferenceShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetElementShape"></see>
    /// </summary>
    let ``shapes/NetElementShape`` = _prefix "shapes/NetElementShape"
    /// <summary>
    /// Defines a relation between two elements.
    /// <see href="http://data.europa.eu/949/NetRelation"></see></summary>
    let NetRelation = _prefix "NetRelation"
    /// <summary>
    /// Represents a linear reference in the network.
    /// <see href="http://data.europa.eu/949/NetLinearReference"></see></summary>
    let NetLinearReference = _prefix "NetLinearReference"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetLinearReferenceShape"></see>
    /// </summary>
    let ``shapes/NetLinearReferenceShape`` = _prefix "shapes/NetLinearReferenceShape"
    /// <summary>
    /// Represents a point reference in the network.
    /// <see href="http://data.europa.eu/949/NetPointReference"></see></summary>
    let NetPointReference = _prefix "NetPointReference"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetPointReferenceShape"></see>
    /// </summary>
    let ``shapes/NetPointReferenceShape`` = _prefix "shapes/NetPointReferenceShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetRelationShape"></see>
    /// </summary>
    let ``shapes/NetRelationShape`` = _prefix "shapes/NetRelationShape"
    /// <summary>
    /// Determines if the position of the topological element A in a relation is the origin of element A.
    /// <see href="http://data.europa.eu/949/isOnOriginOfElementA"></see></summary>
    let isOnOriginOfElementA = _prefix "isOnOriginOfElementA"
    /// <summary>
    /// Determines if the position of the topological element B in a relation is the origin of element B.
    /// <see href="http://data.europa.eu/949/isOnOriginOfElementB"></see></summary>
    let isOnOriginOfElementB = _prefix "isOnOriginOfElementB"
    /// <summary>
    /// Indicates the navigation possibilities between two related topological linear elements.
    /// <see href="http://data.europa.eu/949/navigability"></see></summary>
    let navigability = _prefix "navigability"
    /// <summary>
    /// References the second topological linear element in an oriented relation.
    /// For example, it may indicate the object that corresponds to a section of line, an operational point or a track inside an operational point connected at end.
    /// <see href="http://data.europa.eu/949/elementB"></see></summary>
    let elementB = _prefix "elementB"
    /// <summary>
    /// References the first topological element in an oriented relation.
    /// For example, it may indicate the object that corresponds to a section of line, an operational point or a track inside an operational point connected at start.
    /// <see href="http://data.europa.eu/949/elementA"></see></summary>
    let elementA = _prefix "elementA"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NonLinearElementShape"></see>
    /// </summary>
    let ``shapes/NonLinearElementShape`` = _prefix "shapes/NonLinearElementShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OperationalPointShape"></see>
    /// </summary>
    let ``shapes/OperationalPointShape`` = _prefix "shapes/OperationalPointShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OrganisationRoleShape"></see>
    /// </summary>
    let ``shapes/OrganisationRoleShape`` = _prefix "shapes/OrganisationRoleShape"
    /// <summary>
    /// Represents the orientation of a railway object in relation to a carrier linear element. It can be described by direction, orientation and side.
    /// <see href="http://data.europa.eu/949/Orientation"></see></summary>
    let Orientation = _prefix "Orientation"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OrientationShape"></see>
    /// </summary>
    let ``shapes/OrientationShape`` = _prefix "shapes/OrientationShape"
    /// <summary>
    /// Applicability interval defines the date interval in which a characteristic of an infrastructure element is applicable. This interval can be applied for any of the technical characteristics or general information of infrastructure elements. This helps identifying planned changes applied to technical parameters over time.
    /// <see href="http://data.europa.eu/949/ParameterApplicability"></see></summary>
    let ParameterApplicability = _prefix "ParameterApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ParameterApplicabilityShape"></see>
    /// </summary>
    let ``shapes/ParameterApplicabilityShape`` =
        _prefix "shapes/ParameterApplicabilityShape"

    /// <summary>
    /// Indication of required several information on phase separation.
    /// <see href="http://data.europa.eu/949/PhaseInfo"></see></summary>
    let PhaseInfo = _prefix "PhaseInfo"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoShape"></see>
    /// </summary>
    let ``shapes/PhaseInfoShape`` = _prefix "shapes/PhaseInfoShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/phaseInfo"></see>
    /// </summary>
    let phaseInfo = _prefix "phaseInfo"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/stable"></see>
    /// </summary>
    let stable = _prefix "stable"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PlatformEdgeShape"></see>
    /// </summary>
    let ``shapes/PlatformEdgeShape`` = _prefix "shapes/PlatformEdgeShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PrimaryLocationShape"></see>
    /// </summary>
    let ``shapes/PrimaryLocationShape`` = _prefix "shapes/PrimaryLocationShape"
    /// <summary>
    /// The reference that a physical infrastructure element has it on the topology. It may be used to define the positioning or a representation as a point, line or area
    /// <see href="http://data.europa.eu/949/netReference"></see></summary>
    let netReference = _prefix "netReference"
    /// <summary>
    /// Subsidiary location must be linked to a Primary Location and specifies in more detailed way part, attributes, or usage of Primary location. It may be also a non-rail point or a rail point that is not managed by an Infrastructure Manager (IM). It may be defined by entity having company code according to their needs. The Subsidiary location is optional and dependent upon business needs.
    /// <see href="http://data.europa.eu/949/SubsidiaryLocation"></see></summary>
    let SubsidiaryLocation = _prefix "SubsidiaryLocation"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RadioBlockCenterShape"></see>
    /// </summary>
    let ``shapes/RadioBlockCenterShape`` = _prefix "shapes/RadioBlockCenterShape"
    /// <summary>
    /// Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.
    /// Each track can have several raised pantographs per train allowed (structured) values, and each one has values for number of pantographs, minimum distance between pantographs, in metres, and speed considered in km/h.
    /// <see href="http://data.europa.eu/949/RaisedPantographsDistanceAndSpeed"></see></summary>
    let RaisedPantographsDistanceAndSpeed = _prefix "RaisedPantographsDistanceAndSpeed"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RaisedPantographsDistanceAndSpeedShape"></see>
    /// </summary>
    let ``shapes/RaisedPantographsDistanceAndSpeedShape`` =
        _prefix "shapes/RaisedPantographsDistanceAndSpeedShape"

    /// <summary>
    /// List of reference border points that are specified in the RINF Application Guide.
    /// <see href="http://data.europa.eu/949/ReferenceBorderPoint"></see></summary>
    let ReferenceBorderPoint = _prefix "ReferenceBorderPoint"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ReferenceBorderPointShape"></see>
    /// </summary>
    let ``shapes/ReferenceBorderPointShape`` =
        _prefix "shapes/ReferenceBorderPointShape"

    /// <summary>
    /// Relates the information that each country maintains on a border point, to the operational point that represents the general information on the border point.
    /// <see href="http://data.europa.eu/949/borderPointOf"></see></summary>
    let borderPointOf = _prefix "borderPointOf"
    /// <summary>
    /// Relates an operational point that represents the general information of a border point to the information that each country maintains for the border point.
    /// <see href="http://data.europa.eu/949/opInfoPerCountry"></see></summary>
    let opInfoPerCountry = _prefix "opInfoPerCountry"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RunningTrackShape"></see>
    /// </summary>
    let ``shapes/RunningTrackShape`` = _prefix "shapes/RunningTrackShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SectionOfLineShape"></see>
    /// </summary>
    let ``shapes/SectionOfLineShape`` = _prefix "shapes/SectionOfLineShape"
    /// <summary>
    /// Operational point at the end of section of line (kilometres increasing from start OP to the end OP).
    /// <see href="http://data.europa.eu/949/opEnd"></see></summary>
    let opEnd = _prefix "opEnd"
    /// <summary>
    /// Operational point at the start of section of line (kilometres increasing from start OP to the end OP).
    /// <see href="http://data.europa.eu/949/opStart"></see></summary>
    let opStart = _prefix "opStart"
    /// <summary>
    /// Indicates a relationship with a national railway line at a specific kilometer point.
    /// For a Section of Line: unique line identification or unique line number within Member State.
    /// <see href="http://data.europa.eu/949/nationalLine"></see></summary>
    let nationalLine = _prefix "nationalLine"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SidingShape"></see>
    /// </summary>
    let ``shapes/SidingShape`` = _prefix "shapes/SidingShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SignalShape"></see>
    /// </summary>
    let ``shapes/SignalShape`` = _prefix "shapes/SignalShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SpecialAreaShape"></see>
    /// </summary>
    let ``shapes/SpecialAreaShape`` = _prefix "shapes/SpecialAreaShape"
    /// <summary>
    /// Area or location within a tunnel where there are:
    /// - a safe area: a walkway, evacuation and rescue points;
    /// - a restricted area (non-stopping area or industrial risk location in a tunnel).
    /// <see href="http://data.europa.eu/949/SpecialTunnelArea"></see></summary>
    let SpecialTunnelArea = _prefix "SpecialTunnelArea"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SpecialTunnelAreaShape"></see>
    /// </summary>
    let ``shapes/SpecialTunnelAreaShape`` = _prefix "shapes/SpecialTunnelAreaShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsidiaryLocationShape"></see>
    /// </summary>
    let ``shapes/SubsidiaryLocationShape`` = _prefix "shapes/SubsidiaryLocationShape"
    /// <summary>
    /// Relates a subsidiary location with a primary location.
    /// <see href="http://data.europa.eu/949/linkedToPrimaryLocation"></see></summary>
    let linkedToPrimaryLocation = _prefix "linkedToPrimaryLocation"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SwitchShape"></see>
    /// </summary>
    let ``shapes/SwitchShape`` = _prefix "shapes/SwitchShape"
    /// <summary>
    /// Indication of required several information on system separation.
    /// <see href="http://data.europa.eu/949/SystemSeparationInfo"></see></summary>
    let SystemSeparationInfo = _prefix "SystemSeparationInfo"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SystemSeparationInfoShape"></see>
    /// </summary>
    let ``shapes/SystemSeparationInfoShape`` =
        _prefix "shapes/SystemSeparationInfoShape"

    /// <summary>
    /// (deprecated) Indication of required several information on system separation.
    /// Deprecated because of replacement by four properties. The reason is that the property is composed of four values: length [NNN], the length of the system separation in metres; switch off breaker [Y/N]. Single selection of 'Y=yes' or 'N=no' to show whether the breaker has to be switched off;  lower pantograph [Y/N]. Single selection of 'Y=yes' or 'N=no' to show whether the pantograph has to be lowered, and [CharacterString]  to show whether the supply system has to be changed.
    /// <see href="http://data.europa.eu/949/systemSeparationInfo"></see></summary>
    let systemSeparationInfo = _prefix "systemSeparationInfo"
    /// <summary>
    /// Represents the TEN-T network classification of an element, including its network level, type of traffic, and associated European transport corridors.
    /// <see href="http://data.europa.eu/949/TENTCorridor"></see></summary>
    let TENTCorridor = _prefix "TENTCorridor"
    /// <summary>
    /// Indication whether rules exist and are compliant with the TSI.
    /// <see href="http://data.europa.eu/949/TSIMagneticFields"></see></summary>
    let TSIMagneticFields = _prefix "TSIMagneticFields"
    /// <summary>
    /// Annotation used to point to the applicability of a parameter in RINF. Values are Y/N/NYA
    /// <see href="http://data.europa.eu/949/applicable"></see></summary>
    let applicable = _prefix "applicable"
    /// <summary>
    /// Property that links an object SKOS property to a the URI of the corresponding SKOS Concept Scheme.
    /// <see href="http://data.europa.eu/949/inSkosConceptScheme"></see></summary>
    let inSkosConceptScheme = _prefix "inSkosConceptScheme"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/tsi-existence-and-compliances/TSIExistenceAndCompliances"></see>
    /// </summary>
    let ``concepts/tsi-existence-and-compliances/TSIExistenceAndCompliances`` =
        _prefix "concepts/tsi-existence-and-compliances/TSIExistenceAndCompliances"

    /// <summary>
    /// Annotation used to point to legal obligation of a parameter in RINF
    /// <see href="http://data.europa.eu/949/legalDeadline"></see></summary>
    let legalDeadline = _prefix "legalDeadline"
    /// <summary>
    /// Index code used in the original definition of a parameter in RINF.
    /// <see href="http://data.europa.eu/949/rinfIndex"></see></summary>
    let rinfIndex = _prefix "rinfIndex"
    /// <summary>
    /// Indication whether rules exist and are compliant with the TSI.
    /// <see href="http://data.europa.eu/949/tsiMagneticFields"></see></summary>
    let tsiMagneticFields = _prefix "tsiMagneticFields"
    /// <summary>
    /// Indication whether rules exist and are compliant with the TSI.
    /// <see href="http://data.europa.eu/949/TSITractionHarmonics"></see></summary>
    let TSITractionHarmonics = _prefix "TSITractionHarmonics"
    /// <summary>
    /// Corresponding XML name as indicated in the RINF application guide
    /// <see href="http://data.europa.eu/949/XMLName"></see></summary>
    let XMLName = _prefix "XMLName"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/tsi-compliances/TSICompliances"></see>
    /// </summary>
    let ``concepts/tsi-compliances/TSICompliances`` =
        _prefix "concepts/tsi-compliances/TSICompliances"

    /// <summary>
    /// Indication whether rules exist and are compliant with the TSI.
    /// <see href="http://data.europa.eu/949/tsiTractionHarmonics"></see></summary>
    let tsiTractionHarmonics = _prefix "tsiTractionHarmonics"
    /// <summary>
    /// Represents a topological coordinate.
    /// <see href="http://data.europa.eu/949/TopologicalCoordinate"></see></summary>
    let TopologicalCoordinate = _prefix "TopologicalCoordinate"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TopologicalCoordinateShape"></see>
    /// </summary>
    let ``shapes/TopologicalCoordinateShape`` =
        _prefix "shapes/TopologicalCoordinateShape"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemShape"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemShape`` =
        _prefix "shapes/TrainDetectionSystemShape"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TunnelShape"></see>
    /// </summary>
    let ``shapes/TunnelShape`` = _prefix "shapes/TunnelShape"
    /// <summary>
    /// The natural or legal person that, being the owner of a vehicle or having the right to use it,
    /// exploits the vehicle as a means of transport and is registered as such in a vehicle register referred to in Article 47 of (EU)2016/797.
    /// <see href="http://data.europa.eu/949/vehicleKeeper"></see></summary>
    let vehicleKeeper = _prefix "vehicleKeeper"
    /// <summary>
    /// Existence of limit for acceleration of train if stopping or recovering speed close to a level crossing expressed in a specific reference acceleration curve.
    /// <see href="http://data.europa.eu/949/accelerationLevelCrossing"></see></summary>
    let accelerationLevelCrossing = _prefix "accelerationLevelCrossing"
    /// <summary>
    /// This property is used to specify dependencies in natural language not covered by skos:scopeNote
    /// <see href="http://data.europa.eu/949/dependencyNote"></see></summary>
    let dependencyNote = _prefix "dependencyNote"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AccelerationLevelCrossingApplicability"></see>
    /// </summary>
    let ``shapes/AccelerationLevelCrossingApplicability`` =
        _prefix "shapes/AccelerationLevelCrossingApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AccelerationLevelCrossing"></see>
    /// </summary>
    let ``shapes/AccelerationLevelCrossing`` =
        _prefix "shapes/AccelerationLevelCrossing"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/healthSafetyAndEnvironmentObjParameter"></see>
    /// </summary>
    let healthSafetyAndEnvironmentObjParameter =
        _prefix "healthSafetyAndEnvironmentObjParameter"

    /// <summary>
    /// Electronic document available in two EU languages from the IM stored by the Agency providing additional information as defined in point (2) of point 4.2.2.6.2 of TSI OPE.
    /// <see href="http://data.europa.eu/949/additionalBrakingInformationDocument"></see></summary>
    let additionalBrakingInformationDocument =
        _prefix "additionalBrakingInformationDocument"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AdditionalBrakingInformationDocumentApplicability"></see>
    /// </summary>
    let ``shapes/AdditionalBrakingInformationDocumentApplicability`` =
        _prefix "shapes/AdditionalBrakingInformationDocumentApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AdditionalBrakingInformationDocument"></see>
    /// </summary>
    let ``shapes/AdditionalBrakingInformationDocument`` =
        _prefix "shapes/AdditionalBrakingInformationDocument"

    /// <summary>
    /// Indicates whether a RINF parameter is used in Route Compatibility Check calculations according to Commission Implementing Regulation (EU) 2019/773 of 16 May 2019 on the technical specification for interoperability relating to the operation and traffic management subsystem of the rail system within the European Union and repealing Decision.
    /// <see href="http://data.europa.eu/949/usedInRCCCalculations"></see></summary>
    let usedInRCCCalculations = _prefix "usedInRCCCalculations"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/brakeRelatedObjParameter"></see>
    /// </summary>
    let brakeRelatedObjParameter = _prefix "brakeRelatedObjParameter"
    /// <summary>
    /// Annotation property used in SHACL shapes. Name of the classes that are the subject of properties that are being validated in a SHACL shape.
    /// <see href="http://data.europa.eu/949/affectedClass"></see></summary>
    let affectedClass = _prefix "affectedClass"
    /// <summary>
    /// Annotation property used in SHACL shapes. Name of the properties that are being validated in a SHACL shape.
    /// <see href="http://data.europa.eu/949/affectedProperty"></see></summary>
    let affectedProperty = _prefix "affectedProperty"
    /// <summary>
    /// Specifies the linear elements aggregated by a non-linear element.
    /// <see href="http://data.europa.eu/949/aggregates"></see></summary>
    let aggregates = _prefix "aggregates"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Aggregates"></see>
    /// </summary>
    let ``shapes/Aggregates`` = _prefix "shapes/Aggregates"
    /// <summary>
    /// The organisation in charge to allocate the code for the subsidiary location.
    /// <see href="http://data.europa.eu/949/allocationCompany"></see></summary>
    let allocationCompany = _prefix "allocationCompany"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AllocationCompany"></see>
    /// </summary>
    let ``shapes/AllocationCompany`` = _prefix "shapes/AllocationCompany"
    /// <summary>
    /// Alternative name of a vehicle type.
    /// <see href="http://data.europa.eu/949/alternativeName"></see></summary>
    let alternativeName = _prefix "alternativeName"
    /// <summary>
    /// Index code used in the original definition of a parameter in ERATV.
    /// <see href="http://data.europa.eu/949/eratvIndex"></see></summary>
    let eratvIndex = _prefix "eratvIndex"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/vehicleTypeTechnicalDataCharacteristic"></see>
    /// </summary>
    let vehicleTypeTechnicalDataCharacteristic =
        _prefix "vehicleTypeTechnicalDataCharacteristic"

    /// <summary>
    /// Altitude range.
    /// <see href="http://data.europa.eu/949/altitudeRange"></see></summary>
    let altitudeRange = _prefix "altitudeRange"
    /// <summary>
    /// Altitude range value for 'X' if value 'AX' is selected in altitude range.
    /// <see href="http://data.europa.eu/949/altitudeRangeDetail"></see></summary>
    let altitudeRangeDetail = _prefix "altitudeRangeDetail"
    /// <summary>
    /// Specifies if the section applies in both directions (optional).
    /// <see href="http://data.europa.eu/949/appliesInBothDirections"></see></summary>
    let appliesInBothDirections = _prefix "appliesInBothDirections"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AppliesInBothDirections"></see>
    /// </summary>
    let ``shapes/AppliesInBothDirections`` = _prefix "shapes/AppliesInBothDirections"
    /// <summary>
    /// The direction relative to the origin of the linear element towards the point reference applies.
    /// <see href="http://data.europa.eu/949/appliesToDirection"></see></summary>
    let appliesToDirection = _prefix "appliesToDirection"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/orientations/OrientationDirections"></see>
    /// </summary>
    let ``concepts/orientations/OrientationDirections`` =
        _prefix "concepts/orientations/OrientationDirections"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AppliesToDirectionSKOS"></see>
    /// </summary>
    let ``shapes/AppliesToDirectionSKOS`` = _prefix "shapes/AppliesToDirectionSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AppliesToDirection"></see>
    /// </summary>
    let ``shapes/AppliesToDirection`` = _prefix "shapes/AppliesToDirection"
    /// <summary>
    /// Information of the train access level for which the boarding aid can be used.
    /// <see href="http://data.europa.eu/949/areaBoardingAid"></see></summary>
    let areaBoardingAid = _prefix "areaBoardingAid"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AreaBoardingAid"></see>
    /// </summary>
    let ``shapes/AreaBoardingAid`` = _prefix "shapes/AreaBoardingAid"
    /// <summary>
    /// Magnitude of a quantity, defined and adopted by convention or by law, that is used as a standard for measurement of the same kind of quantity.
    /// <see href="http://data.europa.eu/949/unitOfMeasure"></see></summary>
    let unitOfMeasure = _prefix "unitOfMeasure"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/platformDataParameter"></see>
    /// </summary>
    let platformDataParameter = _prefix "platformDataParameter"
    /// <summary>
    /// Indication of existence of equipment or staff supporting the train crew in starting the train.
    /// <see href="http://data.europa.eu/949/assistanceStartingTrain"></see></summary>
    let assistanceStartingTrain = _prefix "assistanceStartingTrain"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AssistanceStartingTrain"></see>
    /// </summary>
    let ``shapes/AssistanceStartingTrain`` = _prefix "shapes/AssistanceStartingTrain"
    /// <summary>
    /// Supported ATO communication systems from trackside.
    /// <see href="http://data.europa.eu/949/atoCommunicationSystem"></see></summary>
    let atoCommunicationSystem = _prefix "atoCommunicationSystem"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ato-commsys/ATOCommSystem"></see>
    /// </summary>
    let ``concepts/ato-commsys/ATOCommSystem`` =
        _prefix "concepts/ato-commsys/ATOCommSystem"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AtoCommunicationSystem"></see>
    /// </summary>
    let ``shapes/AtoCommunicationSystem`` = _prefix "shapes/AtoCommunicationSystem"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AtoCommunicationSystemSKOS"></see>
    /// </summary>
    let ``shapes/AtoCommunicationSystemSKOS`` =
        _prefix "shapes/AtoCommunicationSystemSKOS"

    /// <summary>
    /// The index of a vocabulary term in Appendix D2 Elements the infrastructure manager has to provide to the railway undertaking for the Route Book from the document Commission Implementing Regulation (EU) 2019/773 of 16 May 2019 on the technical specification for interoperability relating to the operation and traffic management subsystem of the rail system within the European Union and repealing Decision 2012/757/EU.
    /// <see href="http://data.europa.eu/949/tsiOPEAppendixD2Index"></see></summary>
    let tsiOPEAppendixD2Index = _prefix "tsiOPEAppendixD2Index"
    /// <summary>
    /// ATO grade of automation installed lineside.
    /// <see href="http://data.europa.eu/949/atoGradeAutomation"></see></summary>
    let atoGradeAutomation = _prefix "atoGradeAutomation"
    /// <summary>
    /// ETCS baseline installed lineside.
    /// <see href="http://data.europa.eu/949/etcsBaseline"></see></summary>
    let etcsBaseline = _prefix "etcsBaseline"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/automatedTrainOperationObjParameter"></see>
    /// </summary>
    let automatedTrainOperationObjParameter =
        _prefix "automatedTrainOperationObjParameter"

    /// <summary>
    /// List of unacceptable errors impacting the IM network that are required to be solved in the on-board ATO according to the CCS TSI point 7.2.10.3 specification maintenance point.
    /// <see href="http://data.europa.eu/949/atoErrorCorrectionsOnboard"></see></summary>
    let atoErrorCorrectionsOnboard = _prefix "atoErrorCorrectionsOnboard"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ato-grades-automation/ATOGradeOfAutomation"></see>
    /// </summary>
    let ``concepts/ato-grades-automation/ATOGradeOfAutomation`` =
        _prefix "concepts/ato-grades-automation/ATOGradeOfAutomation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AtoGradeAutomationSKOS"></see>
    /// </summary>
    let ``shapes/AtoGradeAutomationSKOS`` = _prefix "shapes/AtoGradeAutomationSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AtoGradeAutomation"></see>
    /// </summary>
    let ``shapes/AtoGradeAutomation`` = _prefix "shapes/AtoGradeAutomation"
    /// <summary>
    /// ATO system version according to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/atoSystemVersion"></see></summary>
    let atoSystemVersion = _prefix "atoSystemVersion"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ato-s-versions/ATOSystemVersions"></see>
    /// </summary>
    let ``concepts/ato-s-versions/ATOSystemVersions`` =
        _prefix "concepts/ato-s-versions/ATOSystemVersions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AtoSystemVersionSKOS"></see>
    /// </summary>
    let ``shapes/AtoSystemVersionSKOS`` = _prefix "shapes/AtoSystemVersionSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AtoSystemVersion"></see>
    /// </summary>
    let ``shapes/AtoSystemVersion`` = _prefix "shapes/AtoSystemVersion"
    /// <summary>
    /// Indicates the country(ies) in where a vehicle type has been authorized to operate.
    /// <see href="http://data.europa.eu/949/authorizedCountry"></see></summary>
    let authorizedCountry = _prefix "authorizedCountry"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/vehicleTypeTechnicalObjectCharacteristic"></see>
    /// </summary>
    let vehicleTypeTechnicalObjectCharacteristic =
        _prefix "vehicleTypeTechnicalObjectCharacteristic"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/ccsSubsystemObjParameter"></see>
    /// </summary>
    let ccsSubsystemObjParameter = _prefix "ccsSubsystemObjParameter"
    /// <summary>
    /// Indication of whether an automatic dropping device (ADD) required on the vehicle.
    /// <see href="http://data.europa.eu/949/automaticDroppingDeviceRequired"></see></summary>
    let automaticDroppingDeviceRequired = _prefix "automaticDroppingDeviceRequired"
    /// <summary>
    /// This property is used to annotate in human readable the format of parameters
    /// <see href="http://data.europa.eu/949/formatNote"></see></summary>
    let formatNote = _prefix "formatNote"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AutomaticDroppingDeviceRequired"></see>
    /// </summary>
    let ``shapes/AutomaticDroppingDeviceRequired`` =
        _prefix "shapes/AutomaticDroppingDeviceRequired"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AutomaticDroppingDeviceRequiredApplicability"></see>
    /// </summary>
    let ``shapes/AutomaticDroppingDeviceRequiredApplicability`` =
        _prefix "shapes/AutomaticDroppingDeviceRequiredApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/requirementsRollingStockDataParameter"></see>
    /// </summary>
    let requirementsRollingStockDataParameter =
        _prefix "requirementsRollingStockDataParameter"

    /// <summary>
    /// Axle bearing condition monitoring.
    /// <see href="http://data.europa.eu/949/axleBearingConditionMonitoring"></see></summary>
    let axleBearingConditionMonitoring = _prefix "axleBearingConditionMonitoring"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/axle-monitoring/AxleBearingMonitoring"></see>
    /// </summary>
    let ``concepts/axle-monitoring/AxleBearingMonitoring`` =
        _prefix "concepts/axle-monitoring/AxleBearingMonitoring"

    /// <summary>
    /// Position of the axles along the unit. a: Distance between axles; b: Distance from end axle to the end of the nearest coupling plane; c: distance between two inside axles.
    /// <see href="http://data.europa.eu/949/axleSpacing"></see></summary>
    let axleSpacing = _prefix "axleSpacing"
    /// <summary>
    /// Indicates that an infrastructure element belongs to a certain subset that contains common characteristics.
    /// <see href="http://data.europa.eu/949/belongsTo"></see></summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BelongsTo"></see>
    /// </summary>
    let ``shapes/BelongsTo`` = _prefix "shapes/BelongsTo"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BelongsToUniqueIM"></see>
    /// </summary>
    let ``shapes/BelongsToUniqueIM`` = _prefix "shapes/BelongsToUniqueIM"
    /// <summary>
    /// Indicates that a subset with common characteristics contains a certain infrastructure element.
    /// <see href="http://data.europa.eu/949/contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// Indication of existence of metal mass in the vicinity of the location, susceptible of perturbating the reading of balises by the on-board system.
    /// <see href="http://data.europa.eu/949/bigMetalMass"></see></summary>
    let bigMetalMass = _prefix "bigMetalMass"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BigMetalMass"></see>
    /// </summary>
    let ``shapes/BigMetalMass`` = _prefix "shapes/BigMetalMass"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BigMetalMassApplicability"></see>
    /// </summary>
    let ``shapes/BigMetalMassApplicability`` =
        _prefix "shapes/BigMetalMassApplicability"

    /// <summary>
    /// ETCS application level related to the track side equipment.
    /// <see href="http://data.europa.eu/949/etcsLevelType"></see></summary>
    let etcsLevelType = _prefix "etcsLevelType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/tsiCompliantTrainProtectionSystemDataParameter"></see>
    /// </summary>
    let tsiCompliantTrainProtectionSystemDataParameter =
        _prefix "tsiCompliantTrainProtectionSystemDataParameter"

    /// <summary>
    /// Description of any integrated boarding aids (if provided).
    /// <see href="http://data.europa.eu/949/boardingAids"></see></summary>
    let boardingAids = _prefix "boardingAids"
    /// <summary>
    /// Border point identification in the list of reference border points in the RINF application guide.
    /// <see href="http://data.europa.eu/949/borderPointId"></see></summary>
    let borderPointId = _prefix "borderPointId"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BorderPointId"></see>
    /// </summary>
    let ``shapes/BorderPointId`` = _prefix "shapes/BorderPointId"
    /// <summary>
    /// Relates an operational point that is a border point with an instance of the list of reference border points that are specified in the RINF Application Guide.
    /// <see href="http://data.europa.eu/949/referenceBorderPoint"></see></summary>
    let referenceBorderPoint = _prefix "referenceBorderPoint"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/brakeRelatedDataParameter"></see>
    /// </summary>
    let brakeRelatedDataParameter = _prefix "brakeRelatedDataParameter"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/ccsSubsystemDataParameter"></see>
    /// </summary>
    let ccsSubsystemDataParameter = _prefix "ccsSubsystemDataParameter"
    /// <summary>
    /// Brake weight percentage (lambda) or Braked mass.
    /// <see href="http://data.europa.eu/949/brakeWeightPercentage"></see></summary>
    let brakeWeightPercentage = _prefix "brakeWeightPercentage"
    /// <summary>
    /// The canonical URI is defined for each instance of an Infrastructure element, e.g. section of line, operational point, track, tunnel, siding.
    /// Objects of the infrastructure generated through RML mappings include (when provided) their validity start and end dates. With its identifier, plus all identifiers of its "parent" elements, and its validity dates, a hash URI is generated.
    /// The canonical URI is the element's URI with its identifiers and without the validity dates. All of the hash URIs of an element point to its canonical URI.
    /// Additionally, SoLs point to the canonical URIs of their start OP and end OP.
    /// <see href="http://data.europa.eu/949/canonicalURI"></see></summary>
    let canonicalURI = _prefix "canonicalURI"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CanonicalURI"></see>
    /// </summary>
    let ``shapes/CanonicalURI`` = _prefix "shapes/CanonicalURI"
    /// <summary>
    /// Cant deficiency (maximum uncompensated lateral acceleration) for which the vehicle has been assessed. For dual gauge vehicles values for each gauge have to be indicated.
    /// <see href="http://data.europa.eu/949/cantDefficiency"></see></summary>
    let cantDefficiency = _prefix "cantDefficiency"
    /// <summary>
    /// Maximum cant deficiency expressed in millimetres defined as difference between the applied cant and a higher equilibrium cant the line has been designed for.
    /// <see href="http://data.europa.eu/949/cantDeficiency"></see></summary>
    let cantDeficiency = _prefix "cantDeficiency"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CantDeficiency"></see>
    /// </summary>
    let ``shapes/CantDeficiency`` = _prefix "shapes/CantDeficiency"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/trackDataParameter"></see>
    /// </summary>
    let trackDataParameter = _prefix "trackDataParameter"
    /// <summary>
    /// Essential information for railway undertakings with a worse (lower) tolerated cant deficiency than those for which the ETCS trackside provides SSP (Static Speed Profiles) in conjunction with parameter "Other Cant Deficiency train categories for which the ETCS trackside is configured to provide SSP".
    /// <see href="http://data.europa.eu/949/cantDeficiencyBasicSSP"></see></summary>
    let cantDeficiencyBasicSSP = _prefix "cantDeficiencyBasicSSP"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/cant-deficiencies/CantDeficiencies"></see>
    /// </summary>
    let ``concepts/cant-deficiencies/CantDeficiencies`` =
        _prefix "concepts/cant-deficiencies/CantDeficiencies"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CantDeficiencyBasicSSP"></see>
    /// </summary>
    let ``shapes/CantDeficiencyBasicSSP`` = _prefix "shapes/CantDeficiencyBasicSSP"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CantDeficiencyBasicSSPSKOS"></see>
    /// </summary>
    let ``shapes/CantDeficiencyBasicSSPSKOS`` =
        _prefix "shapes/CantDeficiencyBasicSSPSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CantDeficiencyBasicSSPApplicability"></see>
    /// </summary>
    let ``shapes/CantDeficiencyBasicSSPApplicability`` =
        _prefix "shapes/CantDeficiencyBasicSSPApplicability"

    /// <summary>
    /// The index of a vocabulary term in Appendix D3 ERTMS trackside engineering information relevant to operation that the infrastructure manager shall provide to the railway undertaking.
    /// <see href="http://data.europa.eu/949/tsiOPEAppendixD3Index"></see></summary>
    let tsiOPEAppendixD3Index = _prefix "tsiOPEAppendixD3Index"
    /// <summary>
    /// Essential information for drivers of trains with a worse (lower) tolerated cant deficiency than those for which the ETCS trackside provides SSP (Static Speed Profiles) in conjunction with parameter "Cant Deficiency used for the basic SSP".
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/otherCantDeficiencyBasicSSP"></see></summary>
    let otherCantDeficiencyBasicSSP = _prefix "otherCantDeficiencyBasicSSP"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/tsiCompliantTrainProtectionSystemObjParameter"></see>
    /// </summary>
    let tsiCompliantTrainProtectionSystemObjParameter =
        _prefix "tsiCompliantTrainProtectionSystemObjParameter"

    /// <summary>
    /// The carrier linear element in relation to which the orientation is based on
    /// <see href="http://data.europa.eu/949/carrierLinearElement"></see></summary>
    let carrierLinearElement = _prefix "carrierLinearElement"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CarrierLinearElement"></see>
    /// </summary>
    let ``shapes/CarrierLinearElement`` = _prefix "shapes/CarrierLinearElement"
    /// <summary>
    /// (Deprecated) Vehicle category.
    /// <see href="http://data.europa.eu/949/category"></see></summary>
    let category = _prefix "category"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/vehicle-types/Categories"></see>
    /// </summary>
    let ``concepts/vehicle-types/Categories`` =
        _prefix "concepts/vehicle-types/Categories"

    /// <summary>
    /// Indicates the core purpose of a railway vehicle: delivering traction, transporting goods or passengers or serving as a special vehicle.
    /// <see href="http://data.europa.eu/949/vehicleCategory"></see></summary>
    let vehicleCategory = _prefix "vehicleCategory"
    /// <summary>
    /// Maximum rated current from the catenary (to be indicated for each electrical energy supply system the vehicle is equipped for), given in A.
    /// <see href="http://data.europa.eu/949/catenaryMaxRatedCurrent"></see></summary>
    let catenaryMaxRatedCurrent = _prefix "catenaryMaxRatedCurrent"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/rinfTechnicalDataCharacteristic"></see>
    /// </summary>
    let rinfTechnicalDataCharacteristic = _prefix "rinfTechnicalDataCharacteristic"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/ccsSubsystemDeclarationsVerificationTrackDataParameter"></see>
    /// </summary>
    let ccsSubsystemDeclarationsVerificationTrackDataParameter =
        _prefix "ccsSubsystemDeclarationsVerificationTrackDataParameter"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/ccsSubsystemDeclarationsVerificationTrackObjParameter"></see>
    /// </summary>
    let ccsSubsystemDeclarationsVerificationTrackObjParameter =
        _prefix "ccsSubsystemDeclarationsVerificationTrackObjParameter"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/rinfTechnicalObjectCharacteristic"></see>
    /// </summary>
    let rinfTechnicalObjectCharacteristic = _prefix "rinfTechnicalObjectCharacteristic"
    /// <summary>
    /// For this Vehicle Type, the type or design examination certificate described in the relevant verification module as issued by
    /// Notified Bodies, supporting the EC Declaration(s) of Verification for the subsystems in scope of the type's authorisation by an authorizing entity.
    /// <see href="http://data.europa.eu/949/certificate"></see></summary>
    let certificate = _prefix "certificate"
    /// <summary>
    /// Category of a Railway company. Can be Infrastructure, Freight or Passenger. Deprecated as it will be integrated with the Organisations properties.
    /// <see href="http://data.europa.eu/949/companyCodeCategory"></see></summary>
    let companyCodeCategory = _prefix "companyCodeCategory"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/company-code-categories/CompanyCodeCategories"></see>
    /// </summary>
    let ``concepts/company-code-categories/CompanyCodeCategories`` =
        _prefix "concepts/company-code-categories/CompanyCodeCategories"

    /// <summary>
    /// Electronic document available in two EU languages from the IM stored by the Agency with:
    /// - precise procedures for the static and dynamic route compatibility checks;
    /// Or
    /// - relevant information for carrying out the checks for specific structures.
    /// <see href="http://data.europa.eu/949/compatibilityProcedureDocument"></see></summary>
    let compatibilityProcedureDocument = _prefix "compatibilityProcedureDocument"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CompatibilityProcedureDocument"></see>
    /// </summary>
    let ``shapes/CompatibilityProcedureDocument`` =
        _prefix "shapes/CompatibilityProcedureDocument"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/performanceObjParameter"></see>
    /// </summary>
    let performanceObjParameter = _prefix "performanceObjParameter"
    /// <summary>
    /// Compliance of the tunnel with TSI INF at the maximum permitted speed
    /// <see href="http://data.europa.eu/949/complianceInfTsi"></see></summary>
    let complianceInfTsi = _prefix "complianceInfTsi"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ComplianceInfTsiP"></see>
    /// </summary>
    let ``shapes/ComplianceInfTsiP`` = _prefix "shapes/ComplianceInfTsiP"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ComplianceInfTsiApplicability"></see>
    /// </summary>
    let ``shapes/ComplianceInfTsiApplicability`` =
        _prefix "shapes/ComplianceInfTsiApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/tunnelDataParameter"></see>
    /// </summary>
    let tunnelDataParameter = _prefix "tunnelDataParameter"
    /// <summary>
    /// Indicates if a vehicle's composite brake block is retrofitted
    /// <see href="http://data.europa.eu/949/compositeBrakeBlockRetrofitted"></see></summary>
    let compositeBrakeBlockRetrofitted = _prefix "compositeBrakeBlockRetrofitted"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/vehicleTechnicalDataCharacteristic"></see>
    /// </summary>
    let vehicleTechnicalDataCharacteristic =
        _prefix "vehicleTechnicalDataCharacteristic"

    /// <summary>
    /// Indication whether regenerative braking is permitted, not permitted, or permitted under specific conditions.
    /// <see href="http://data.europa.eu/949/conditionalRegenerativeBrake"></see></summary>
    let conditionalRegenerativeBrake = _prefix "conditionalRegenerativeBrake"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/regenerative-braking/RegenerativeBraking"></see>
    /// </summary>
    let ``concepts/regenerative-braking/RegenerativeBraking`` =
        _prefix "concepts/regenerative-braking/RegenerativeBraking"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionalRegenerativeBrakeSKOS"></see>
    /// </summary>
    let ``shapes/ConditionalRegenerativeBrakeSKOS`` =
        _prefix "shapes/ConditionalRegenerativeBrakeSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionalRegenerativeBrake"></see>
    /// </summary>
    let ``shapes/ConditionalRegenerativeBrake`` =
        _prefix "shapes/ConditionalRegenerativeBrake"

    /// <summary>
    /// Indication of the type of the contact line system.
    /// <see href="http://data.europa.eu/949/contactLineSystemType"></see></summary>
    let contactLineSystemType = _prefix "contactLineSystemType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trackResistanceToAppliedLoadsObjParameter"></see>
    /// </summary>
    let trackResistanceToAppliedLoadsObjParameter =
        _prefix "trackResistanceToAppliedLoadsObjParameter"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trackObjParameter"></see>
    /// </summary>
    let trackObjParameter = _prefix "trackObjParameter"

    /// <summary>
    /// Name and/or reference of the document specifying the conditions applying in regards to regenerative braking.
    /// <see href="http://data.europa.eu/949/conditionsAppliedRegenerativeBraking"></see></summary>
    let conditionsAppliedRegenerativeBraking =
        _prefix "conditionsAppliedRegenerativeBraking"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsAppliedRegenerativeBrakingApplicability"></see>
    /// </summary>
    let ``shapes/ConditionsAppliedRegenerativeBrakingApplicability`` =
        _prefix "shapes/ConditionsAppliedRegenerativeBrakingApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsAppliedRegenerativeBraking"></see>
    /// </summary>
    let ``shapes/ConditionsAppliedRegenerativeBraking`` =
        _prefix "shapes/ConditionsAppliedRegenerativeBraking"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/contactLineSystemObjParameter"></see>
    /// </summary>
    let contactLineSystemObjParameter = _prefix "contactLineSystemObjParameter"

    /// <summary>
    /// Conditions set by IMs according to a standardised document
    /// <see href="http://data.europa.eu/949/conditionsChargingElectricEnergyStorage"></see></summary>
    let conditionsChargingElectricEnergyStorage =
        _prefix "conditionsChargingElectricEnergyStorage"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsChargingElectricEnergyStorage"></see>
    /// </summary>
    let ``shapes/ConditionsChargingElectricEnergyStorage`` =
        _prefix "shapes/ConditionsChargingElectricEnergyStorage"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/contactLineSystemDataParameter"></see>
    /// </summary>
    let contactLineSystemDataParameter = _prefix "contactLineSystemDataParameter"
    /// <summary>
    /// Name and/or reference of the document specifying the Special technical conditions required to switch over between ERTMS/ETCS and Class B systems.
    /// <see href="http://data.europa.eu/949/conditionsSwitchClassBSystems"></see></summary>
    let conditionsSwitchClassBSystems = _prefix "conditionsSwitchClassBSystems"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsSwitchClassBSystems"></see>
    /// </summary>
    let ``shapes/ConditionsSwitchClassBSystems`` =
        _prefix "shapes/ConditionsSwitchClassBSystems"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsSwitchClassBSystemsApplicability"></see>
    /// </summary>
    let ``shapes/ConditionsSwitchClassBSystemsApplicability`` =
        _prefix "shapes/ConditionsSwitchClassBSystemsApplicability"

    /// <summary>
    /// Indication whether a switch over between different systems whilst running exists.
    /// <see href="http://data.europa.eu/949/switchProtectControlWarning"></see></summary>
    let switchProtectControlWarning = _prefix "switchProtectControlWarning"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/transitionsBetweenSystemsObjParameter"></see>
    /// </summary>
    let transitionsBetweenSystemsObjParameter =
        _prefix "transitionsBetweenSystemsObjParameter"

    /// <summary>
    /// Conditions to switch over between different class B train protection, control and warning systems.
    /// <see href="http://data.europa.eu/949/conditionsSwitchTrainProtectionSystems"></see></summary>
    let conditionsSwitchTrainProtectionSystems =
        _prefix "conditionsSwitchTrainProtectionSystems"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsSwitchTrainProtectionSystems"></see>
    /// </summary>
    let ``shapes/ConditionsSwitchTrainProtectionSystems`` =
        _prefix "shapes/ConditionsSwitchTrainProtectionSystems"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/transitionsBetweenSystemsDataParameter"></see>
    /// </summary>
    let transitionsBetweenSystemsDataParameter =
        _prefix "transitionsBetweenSystemsDataParameter"

    /// <summary>
    /// Conditions of use regarding train formation.
    /// <see href="http://data.europa.eu/949/conditionsTrainFormation"></see></summary>
    let conditionsTrainFormation = _prefix "conditionsTrainFormation"
    /// <summary>
    /// Details of any conditions for using the reflective plates on freight corridors. Specific case for Portugal and Spain until 1.1.2025 and Belgium and France until 1.1.2026.
    /// <see href="http://data.europa.eu/949/conditionsUseReflectivePlates"></see></summary>
    let conditionsUseReflectivePlates = _prefix "conditionsUseReflectivePlates"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/conditions-use-reflective-plates/ConditionsUseReflectivePlates"></see>
    /// </summary>
    let ``concepts/conditions-use-reflective-plates/ConditionsUseReflectivePlates`` =
        _prefix "concepts/conditions-use-reflective-plates/ConditionsUseReflectivePlates"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsUseReflectivePlates"></see>
    /// </summary>
    let ``shapes/ConditionsUseReflectivePlates`` =
        _prefix "shapes/ConditionsUseReflectivePlates"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsUseReflectivePlatesSKOS"></see>
    /// </summary>
    let ``shapes/ConditionsUseReflectivePlatesSKOS`` =
        _prefix "shapes/ConditionsUseReflectivePlatesSKOS"

    /// <summary>
    /// Represents a bidirectional connection between two Track instances.
    /// <see href="http://data.europa.eu/949/connectedTo"></see></summary>
    let connectedTo = _prefix "connectedTo"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/trackGenericObjParameter"></see>
    /// </summary>
    let trackGenericObjParameter = _prefix "trackGenericObjParameter"
    /// <summary>
    /// System that is used to transmit electrical energy to road or rail vehicles.
    /// <see href="http://data.europa.eu/949/contactLineSystem"></see></summary>
    let contactLineSystem = _prefix "contactLineSystem"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactLineSystem"></see>
    /// </summary>
    let ``shapes/ContactLineSystem`` = _prefix "shapes/ContactLineSystem"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/energySubsystemDataParameter"></see>
    /// </summary>
    let energySubsystemDataParameter = _prefix "energySubsystemDataParameter"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/energySubsystemObjParameter"></see>
    /// </summary>
    let energySubsystemObjParameter = _prefix "energySubsystemObjParameter"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/contact-line-systems/ContactLineSystems"></see>
    /// </summary>
    let ``concepts/contact-line-systems/ContactLineSystems`` =
        _prefix "concepts/contact-line-systems/ContactLineSystems"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactLineSystemTypeNotElectrifiedApplicability"></see>
    /// </summary>
    let ``shapes/ContactLineSystemTypeNotElectrifiedApplicability`` =
        _prefix "shapes/ContactLineSystemTypeNotElectrifiedApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactLineSystemType"></see>
    /// </summary>
    let ``shapes/ContactLineSystemType`` = _prefix "shapes/ContactLineSystemType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactLineSystemTypeThirdOrFourthRailApplicability"></see>
    /// </summary>
    let ``shapes/ContactLineSystemTypeThirdOrFourthRailApplicability`` =
        _prefix "shapes/ContactLineSystemTypeThirdOrFourthRailApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactLineSystemTypeSKOS"></see>
    /// </summary>
    let ``shapes/ContactLineSystemTypeSKOS`` =
        _prefix "shapes/ContactLineSystemTypeSKOS"

    /// <summary>
    /// Indication of which contact strip materials are permitted to be used.
    /// <see href="http://data.europa.eu/949/contactStripMaterial"></see></summary>
    let contactStripMaterial = _prefix "contactStripMaterial"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/contact-strip-materials/ContactStripMaterials"></see>
    /// </summary>
    let ``concepts/contact-strip-materials/ContactStripMaterials`` =
        _prefix "concepts/contact-strip-materials/ContactStripMaterials"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactStripMaterialSKOS"></see>
    /// </summary>
    let ``shapes/ContactStripMaterialSKOS`` = _prefix "shapes/ContactStripMaterialSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactStripMaterialApplicability"></see>
    /// </summary>
    let ``shapes/ContactStripMaterialApplicability`` =
        _prefix "shapes/ContactStripMaterialApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/pantographObjParameter"></see>
    /// </summary>
    let pantographObjParameter = _prefix "pantographObjParameter"

    /// <summary>
    /// Indication of max. percentage of contact strip material Impregnated Carbon permitted to be used.
    /// <see href="http://data.europa.eu/949/contactStripMaterialMetallicContent"></see></summary>
    let contactStripMaterialMetallicContent =
        _prefix "contactStripMaterialMetallicContent"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactStripMaterialMetallicContent"></see>
    /// </summary>
    let ``shapes/ContactStripMaterialMetallicContent`` =
        _prefix "shapes/ContactStripMaterialMetallicContent"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/pantographDataParameter"></see>
    /// </summary>
    let pantographDataParameter = _prefix "pantographDataParameter"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/containerHandlingFlag"></see>
    /// </summary>
    let containerHandlingFlag = _prefix "containerHandlingFlag"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContainerHandlingFlag"></see>
    /// </summary>
    let ``shapes/ContainerHandlingFlag`` = _prefix "shapes/ContainerHandlingFlag"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Contains"></see>
    /// </summary>
    let ``shapes/Contains`` = _prefix "shapes/Contains"
    /// <summary>
    /// Smallest cross section area in square metres of the tunnel
    /// <see href="http://data.europa.eu/949/crossSectionArea"></see></summary>
    let crossSectionArea = _prefix "crossSectionArea"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CrossSectionAreaApplicability"></see>
    /// </summary>
    let ``shapes/CrossSectionAreaApplicability`` =
        _prefix "shapes/CrossSectionAreaApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CrossSectionAreaT"></see>
    /// </summary>
    let ``shapes/CrossSectionAreaT`` = _prefix "shapes/CrossSectionAreaT"
    /// <summary>
    /// Indication of whether an on board current or power limitation function on vehicles is required.
    /// <see href="http://data.europa.eu/949/currentLimitationRequired"></see></summary>
    let currentLimitationRequired = _prefix "currentLimitationRequired"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CurrentLimitationRequiredApplicability"></see>
    /// </summary>
    let ``shapes/CurrentLimitationRequiredApplicability`` =
        _prefix "shapes/CurrentLimitationRequiredApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CurrentLimitationRequired"></see>
    /// </summary>
    let ``shapes/CurrentLimitationRequired`` =
        _prefix "shapes/CurrentLimitationRequired"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/currentlyValid"></see>
    /// </summary>
    let currentlyValid = _prefix "currentlyValid"
    /// <summary>
    /// Maximum distance for overriding the train trip in metres, according to the specification referenced in Appendix A-1, index [C].
    /// <see href="http://data.europa.eu/949/dNvovtrp"></see></summary>
    let dNvovtrp = _prefix "dNvovtrp"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DNvovtrp"></see>
    /// </summary>
    let ``shapes/DNvovtrp`` = _prefix "shapes/DNvovtrp"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DNvovtrpApplicability"></see>
    /// </summary>
    let ``shapes/DNvovtrpApplicability`` = _prefix "shapes/DNvovtrpApplicability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/etcsNationalValuesDataParameter"></see>
    /// </summary>
    let etcsNationalValuesDataParameter = _prefix "etcsNationalValuesDataParameter"
    /// <summary>
    /// Maximum distance for reversing in Post Trip mode in metres, according to the specification referenced in Appendix A-1, index [C].
    /// <see href="http://data.europa.eu/949/dNvpotrp"></see></summary>
    let dNvpotrp = _prefix "dNvpotrp"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DNvpotrpApplicability"></see>
    /// </summary>
    let ``shapes/DNvpotrpApplicability`` = _prefix "shapes/DNvpotrpApplicability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DNvpotrp"></see>
    /// </summary>
    let ``shapes/DNvpotrp`` = _prefix "shapes/DNvpotrp"
    /// <summary>
    /// Parameter used by the ETCS on-board to supervise the distance allowed to be travelled under the roll-away protection and the reverse movement protection, in metres
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/dNvroll"></see></summary>
    let dNvroll = _prefix "dNvroll"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DNvroll"></see>
    /// </summary>
    let ``shapes/DNvroll`` = _prefix "shapes/DNvroll"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DNvrollApplicability"></see>
    /// </summary>
    let ``shapes/DNvrollApplicability`` = _prefix "shapes/DNvrollApplicability"
    /// <summary>
    /// Dangerous goods for which the vehicle is suitable (tank code).
    /// <see href="http://data.europa.eu/949/dangerousGoodsTankCode"></see></summary>
    let dangerousGoodsTankCode = _prefix "dangerousGoodsTankCode"
    /// <summary>
    /// Data SIM Card GSM-R Home Network.
    /// <see href="http://data.europa.eu/949/dataGSMRNetwork"></see></summary>
    let dataGSMRNetwork = _prefix "dataGSMRNetwork"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gsmr-networks/GSMRNetworks"></see>
    /// </summary>
    let ``concepts/gsmr-networks/GSMRNetworks`` =
        _prefix "concepts/gsmr-networks/GSMRNetworks"

    /// <summary>
    /// Radio requirements used for demonstrating technical compatibility data.
    /// <see href="http://data.europa.eu/949/dataRadioCompatible"></see></summary>
    let dataRadioCompatible = _prefix "dataRadioCompatible"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/radio-system-compatibilities-data/RadioSystemCompatibilitiesData"></see>
    /// </summary>
    let ``concepts/radio-system-compatibilities-data/RadioSystemCompatibilitiesData`` =
        _prefix "concepts/radio-system-compatibilities-data/RadioSystemCompatibilitiesData"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DataRadioCompatible"></see>
    /// </summary>
    let ``shapes/DataRadioCompatible`` = _prefix "shapes/DataRadioCompatible"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DataRadioCompatibleSKOS"></see>
    /// </summary>
    let ``shapes/DataRadioCompatibleSKOS`` = _prefix "shapes/DataRadioCompatibleSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DataRadioCompatibleApplicability"></see>
    /// </summary>
    let ``shapes/DataRadioCompatibleApplicability`` =
        _prefix "shapes/DataRadioCompatibleApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/tsiCompliantRadioObjParameter"></see>
    /// </summary>
    let tsiCompliantRadioObjParameter = _prefix "tsiCompliantRadioObjParameter"
    /// <summary>
    /// (deprecated) not in use anymore. For the purposes of the register of infrastructure, each infrastructure manager may describe its railway network optionally via common characteristic subsets.
    /// <see href="http://data.europa.eu/949/definesSubset"></see></summary>
    let definesSubset = _prefix "definesSubset"
    /// <summary>
    /// Unique number for EI declarations following the same format requirements as specified for EC declarations in Annex VII of Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/demonstrationENE"></see></summary>
    let demonstrationENE = _prefix "demonstrationENE"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DemonstrationENE"></see>
    /// </summary>
    let ``shapes/DemonstrationENE`` = _prefix "shapes/DemonstrationENE"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/energySubsystemDeclarationsVerificationTrackDataParameter"></see>
    /// </summary>
    let energySubsystemDeclarationsVerificationTrackDataParameter =
        _prefix "energySubsystemDeclarationsVerificationTrackDataParameter"

    /// <summary>
    /// Unique number for EI declarations following the same format requirements as specified for EC declarations in Annex VII of Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/demonstrationINF"></see></summary>
    let demonstrationINF = _prefix "demonstrationINF"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DemonstrationINFS"></see>
    /// </summary>
    let ``shapes/DemonstrationINFS`` = _prefix "shapes/DemonstrationINFS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DemonstrationINF"></see>
    /// </summary>
    let ``shapes/DemonstrationINF`` = _prefix "shapes/DemonstrationINF"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/infraSubsystemDeclarationsVerificationTrackDataParameter"></see>
    /// </summary>
    let infraSubsystemDeclarationsVerificationTrackDataParameter =
        _prefix "infraSubsystemDeclarationsVerificationTrackDataParameter"

    /// <summary>
    /// Unique number for EI declarations following the same format requirements as specified for EC declarations in Annex VII of Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/demonstrationSRT"></see></summary>
    let demonstrationSRT = _prefix "demonstrationSRT"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DemonstrationSRT"></see>
    /// </summary>
    let ``shapes/DemonstrationSRT`` = _prefix "shapes/DemonstrationSRT"
    /// <summary>
    /// Design mass under exceptional payload.
    /// <see href="http://data.europa.eu/949/designMassExceptionalPayload"></see></summary>
    let designMassExceptionalPayload = _prefix "designMassExceptionalPayload"
    /// <summary>
    /// Design mass under normal payload.
    /// <see href="http://data.europa.eu/949/designMassNormalPayload"></see></summary>
    let designMassNormalPayload = _prefix "designMassNormalPayload"
    /// <summary>
    /// Design mass in working order.
    /// <see href="http://data.europa.eu/949/designMassWorkingOrder"></see></summary>
    let designMassWorkingOrder = _prefix "designMassWorkingOrder"
    /// <summary>
    /// Indication whether it is allowed to use diesel or other thermal traction in the tunnel
    /// <see href="http://data.europa.eu/949/dieselThermalAllowed"></see></summary>
    let dieselThermalAllowed = _prefix "dieselThermalAllowed"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DieselThermalAllowed"></see>
    /// </summary>
    let ``shapes/DieselThermalAllowed`` = _prefix "shapes/DieselThermalAllowed"
    /// <summary>
    /// Diagrammatic representation of the operational point in Well Known Text polyline
    /// <see href="http://data.europa.eu/949/digitalSchematicOverview"></see></summary>
    let digitalSchematicOverview = _prefix "digitalSchematicOverview"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DigitalSchematicOverview"></see>
    /// </summary>
    let ``shapes/DigitalSchematicOverview`` = _prefix "shapes/DigitalSchematicOverview"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/opGenericDataParameter"></see>
    /// </summary>
    let opGenericDataParameter = _prefix "opGenericDataParameter"
    /// <summary>
    /// The direction of the orientation of a railway element, in relation to the carrier linear element
    /// <see href="http://data.europa.eu/949/direction"></see></summary>
    let direction = _prefix "direction"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Direction"></see>
    /// </summary>
    let ``shapes/Direction`` = _prefix "shapes/Direction"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DirectionSKOS"></see>
    /// </summary>
    let ``shapes/DirectionSKOS`` = _prefix "shapes/DirectionSKOS"
    /// <summary>
    /// Distance between the signboard authorizing the driver to  raise pantograph  or  close the circuit breaker  after passing the phase separation and the end of the phase separation section.
    /// <see href="http://data.europa.eu/949/distSignToPhaseEnd"></see></summary>
    let distSignToPhaseEnd = _prefix "distSignToPhaseEnd"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DistSignToPhaseEnd"></see>
    /// </summary>
    let ``shapes/DistSignToPhaseEnd`` = _prefix "shapes/DistSignToPhaseEnd"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/oclSeparationSectionsDataParameter"></see>
    /// </summary>
    let oclSeparationSectionsDataParameter =
        _prefix "oclSeparationSectionsDataParameter"

    /// <summary>
    /// Name and/or reference of the document specifying the restriction(s) related to the position of Multiple Traction unit(s) to comply with contact line separation.
    /// <see href="http://data.europa.eu/949/documentRestrictionPositionContactLineSeparation"></see></summary>
    let documentRestrictionPositionContactLineSeparation =
        _prefix "documentRestrictionPositionContactLineSeparation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DocumentRestrictionPositionContactLineSeparation"></see>
    /// </summary>
    let ``shapes/DocumentRestrictionPositionContactLineSeparation`` =
        _prefix "shapes/DocumentRestrictionPositionContactLineSeparation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/requirementsRollingStockObjParameter"></see>
    /// </summary>
    let requirementsRollingStockObjParameter =
        _prefix "requirementsRollingStockObjParameter"

    /// <summary>
    /// Name and/or reference of the document specifying the restriction(s) related to power consumption of specific electric traction unit(s).
    /// <see href="http://data.europa.eu/949/documentRestrictionPowerConsumption"></see></summary>
    let documentRestrictionPowerConsumption =
        _prefix "documentRestrictionPowerConsumption"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DocumentRestrictionPowerConsumption"></see>
    /// </summary>
    let ``shapes/DocumentRestrictionPowerConsumption`` =
        _prefix "shapes/DocumentRestrictionPowerConsumption"

    /// <summary>
    /// URL that is used to download a document, e.g. url for a reference document in RINF.
    /// <see href="http://data.europa.eu/949/documentUrl"></see></summary>
    let documentUrl = _prefix "documentUrl"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DocumentUrl"></see>
    /// </summary>
    let ``shapes/DocumentUrl`` = _prefix "shapes/DocumentUrl"
    /// <summary>
    /// Number of driving cabs. For wagons the number of driving cabs is to be set to zero (0).
    /// <see href="http://data.europa.eu/949/drivingCabs"></see></summary>
    let drivingCabs = _prefix "drivingCabs"
    /// <summary>
    /// Possibility of preventing the use of the eddy current track brake (only if fitted with eddy current brake)
    /// <see href="http://data.europa.eu/949/eddyCurrentBrakePrevention"></see></summary>
    let eddyCurrentBrakePrevention = _prefix "eddyCurrentBrakePrevention"
    /// <summary>
    /// Indication of limitations on the use of eddy current brakes.
    /// <see href="http://data.europa.eu/949/eddyCurrentBraking"></see></summary>
    let eddyCurrentBraking = _prefix "eddyCurrentBraking"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/eddy-current-braking/EddyCurrentBraking"></see>
    /// </summary>
    let ``concepts/eddy-current-braking/EddyCurrentBraking`` =
        _prefix "concepts/eddy-current-braking/EddyCurrentBraking"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EddyCurrentBraking"></see>
    /// </summary>
    let ``shapes/EddyCurrentBraking`` = _prefix "shapes/EddyCurrentBraking"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EddyCurrentBrakingSKOS"></see>
    /// </summary>
    let ``shapes/EddyCurrentBrakingSKOS`` = _prefix "shapes/EddyCurrentBrakingSKOS"

    /// <summary>
    /// Electronic document available in two EU languages from the IM stored by the Agency with conditions for the use of eddy current brakes identified in 1.1.1.1.6.2.
    /// <see href="http://data.europa.eu/949/eddyCurrentBrakingConditionsDocument"></see></summary>
    let eddyCurrentBrakingConditionsDocument =
        _prefix "eddyCurrentBrakingConditionsDocument"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EddyCurrentBrakingConditionsDocumentApplicability"></see>
    /// </summary>
    let ``shapes/EddyCurrentBrakingConditionsDocumentApplicability`` =
        _prefix "shapes/EddyCurrentBrakingConditionsDocumentApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EddyCurrentBrakingConditionsDocument"></see>
    /// </summary>
    let ``shapes/EddyCurrentBrakingConditionsDocument`` =
        _prefix "shapes/EddyCurrentBrakingConditionsDocument"

    /// <summary>
    /// Eddy current track brake fitted. New property defined to distinguish it from eddyCurrentBraking which is a RINF SKOS property.
    /// <see href="http://data.europa.eu/949/eddyCurrentBrakingFitted"></see></summary>
    let eddyCurrentBrakingFitted = _prefix "eddyCurrentBrakingFitted"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ElementA"></see>
    /// </summary>
    let ``shapes/ElementA`` = _prefix "shapes/ElementA"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ElementB"></see>
    /// </summary>
    let ``shapes/ElementB`` = _prefix "shapes/ElementB"
    /// <summary>
    /// References the topology object of a higher-granularity level which contains a lower-granularity topology object.
    /// <see href="http://data.europa.eu/949/elementPart"></see></summary>
    let elementPart = _prefix "elementPart"
    /// <summary>
    /// Stopping distance and deceleration profile for each load condition per design maximum speed.
    /// <see href="http://data.europa.eu/949/emergencyBrake"></see></summary>
    let emergencyBrake = _prefix "emergencyBrake"
    /// <summary>
    /// Type of end coupling (indicating tensile and compressive forces).
    /// <see href="http://data.europa.eu/949/endCouplingType"></see></summary>
    let endCouplingType = _prefix "endCouplingType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/end-coupling-type/EndCouplingType"></see>
    /// </summary>
    let ``concepts/end-coupling-type/EndCouplingType`` =
        _prefix "concepts/end-coupling-type/EndCouplingType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/endIntrinsicCoordinate"></see>
    /// </summary>
    let endIntrinsicCoordinate = _prefix "endIntrinsicCoordinate"
    /// <summary>
    /// Geographical coordinates in decimal degrees and km of the line at the end of a tunnel.
    /// <see href="http://data.europa.eu/949/endLocation"></see></summary>
    let endLocation = _prefix "endLocation"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EndLocation"></see>
    /// </summary>
    let ``shapes/EndLocation`` = _prefix "shapes/EndLocation"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/tunnelObjParameter"></see>
    /// </summary>
    let tunnelObjParameter = _prefix "tunnelObjParameter"
    /// <summary>
    /// End offset of the section from the origin.
    /// <see href="http://data.europa.eu/949/endOffsetFromOrigin"></see></summary>
    let endOffsetFromOrigin = _prefix "endOffsetFromOrigin"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EndOffsetFromOrigin"></see>
    /// </summary>
    let ``shapes/EndOffsetFromOrigin`` = _prefix "shapes/EndOffsetFromOrigin"
    /// <summary>
    /// Specifies the ending point of a linear reference.
    /// <see href="http://data.europa.eu/949/endsAt"></see></summary>
    let endsAt = _prefix "endsAt"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EndsAt"></see>
    /// </summary>
    let ``shapes/EndsAt`` = _prefix "shapes/EndsAt"
    /// <summary>
    /// TSI conform energy meter for billing purposes installed on board.
    /// <see href="http://data.europa.eu/949/energyMeterInstalled"></see></summary>
    let energyMeterInstalled = _prefix "energyMeterInstalled"
    /// <summary>
    /// Maximum power (to be indicated for each energy supply system the vehicle is equipped for), given in kW.
    /// <see href="http://data.europa.eu/949/energySupplyMaxPower"></see></summary>
    let energySupplyMaxPower = _prefix "energySupplyMaxPower"
    /// <summary>
    /// Indication of the traction supply system (nominal voltage and frequency).
    /// <see href="http://data.europa.eu/949/energySupplySystem"></see></summary>
    let energySupplySystem = _prefix "energySupplySystem"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/energy-supply-systems/EnergySupplySystems"></see>
    /// </summary>
    let ``concepts/energy-supply-systems/EnergySupplySystems`` =
        _prefix "concepts/energy-supply-systems/EnergySupplySystems"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EnergySupplySystem"></see>
    /// </summary>
    let ``shapes/EnergySupplySystem`` = _prefix "shapes/EnergySupplySystem"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EnergySupplySystemSKOS"></see>
    /// </summary>
    let ``shapes/EnergySupplySystemSKOS`` = _prefix "shapes/EnergySupplySystemSKOS"
    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication if the traction supply system (nominal voltage and frequency) is fully compliant with TSI.
    /// <see href="http://data.europa.eu/949/energySupplySystemTSICompliant"></see></summary>
    let energySupplySystemTSICompliant = _prefix "energySupplySystemTSICompliant"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EnergySupplySystemTSICompliant"></see>
    /// </summary>
    let ``shapes/EnergySupplySystemTSICompliant`` =
        _prefix "shapes/EnergySupplySystemTSICompliant"

    /// <summary>
    /// List of unacceptable errors impacting the IM network that are required to be solved in the on-board according to the TSI CCS point 7.2.10.3 specification maintenance point (ETCS, GSM-R and/or ATO). An additional parameter (era:errorCorrectionsOnboardExplanation) must document if a non-implemented CR has been accepted by the IM.
    /// <see href="http://data.europa.eu/949/errorCorrectionsOnboard"></see></summary>
    let errorCorrectionsOnboard = _prefix "errorCorrectionsOnboard"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/error-corrections/OnboardErrorCorrections"></see>
    /// </summary>
    let ``concepts/error-corrections/OnboardErrorCorrections`` =
        _prefix "concepts/error-corrections/OnboardErrorCorrections"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ErrorCorrectionsOnboardSKOS"></see>
    /// </summary>
    let ``shapes/ErrorCorrectionsOnboardSKOS`` =
        _prefix "shapes/ErrorCorrectionsOnboardSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ErrorCorrectionsOnboard"></see>
    /// </summary>
    let ``shapes/ErrorCorrectionsOnboard`` = _prefix "shapes/ErrorCorrectionsOnboard"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/ertmsErrorCorrectionsOnBoard"></see>
    /// </summary>
    let ertmsErrorCorrectionsOnBoard = _prefix "ertmsErrorCorrectionsOnBoard"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/etcsErrorCorrectionsOnboard"></see>
    /// </summary>
    let etcsErrorCorrectionsOnboard = _prefix "etcsErrorCorrectionsOnboard"
    /// <summary>
    /// List of unacceptable errors impacting the IM network that are required to be solved in the on-board according to the CCS TSI point 7.2.10.3 specification maintenance point.
    /// The reason for deprecation is that this parameter does not appear in the latest legal text.
    /// <see href="http://data.europa.eu/949/gsmrErrorCorrectionsOnboard"></see></summary>
    let gsmrErrorCorrectionsOnboard = _prefix "gsmrErrorCorrectionsOnboard"

    /// <summary>
    /// Explanation on why a mandatory onboard CR required to be solved in the on-board (ETCS, GSM-R and/or ATO) was accepted by the IM.
    /// <see href="http://data.europa.eu/949/errorCorrectionsOnboardExplanation"></see></summary>
    let errorCorrectionsOnboardExplanation =
        _prefix "errorCorrectionsOnboardExplanation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ErrorCorrectionsOnboardExplanation"></see>
    /// </summary>
    let ``shapes/ErrorCorrectionsOnboardExplanation`` =
        _prefix "shapes/ErrorCorrectionsOnboardExplanation"

    /// <summary>
    /// European Train Control System (ETCS) application level supported by the track side equipment.
    /// <see href="http://data.europa.eu/949/etcs"></see></summary>
    let etcs = _prefix "etcs"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Etcs"></see>
    /// </summary>
    let ``shapes/Etcs`` = _prefix "shapes/Etcs"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-baselines/ETCSBaselines"></see>
    /// </summary>
    let ``concepts/etcs-baselines/ETCSBaselines`` =
        _prefix "concepts/etcs-baselines/ETCSBaselines"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsBaselineApplicability"></see>
    /// </summary>
    let ``shapes/EtcsBaselineApplicability`` =
        _prefix "shapes/EtcsBaselineApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsBaseline"></see>
    /// </summary>
    let ``shapes/EtcsBaseline`` = _prefix "shapes/EtcsBaseline"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsBaselineSKOS"></see>
    /// </summary>
    let ``shapes/EtcsBaselineSKOS`` = _prefix "shapes/EtcsBaselineSKOS"
    /// <summary>
    /// Data communication application for ETCS implementation.
    /// <see href="http://data.europa.eu/949/etcsDataCommApp"></see></summary>
    let etcsDataCommApp = _prefix "etcsDataCommApp"
    /// <summary>
    /// ERTMS / ETCS application level for degraded situation related to the track side equipment.
    /// <see href="http://data.europa.eu/949/etcsDegradedSituation"></see></summary>
    let etcsDegradedSituation = _prefix "etcsDegradedSituation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-situation/ETCSSituations"></see>
    /// </summary>
    let ``concepts/etcs-situation/ETCSSituations`` =
        _prefix "concepts/etcs-situation/ETCSSituations"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsDegradedSituation"></see>
    /// </summary>
    let ``shapes/EtcsDegradedSituation`` = _prefix "shapes/EtcsDegradedSituation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsDegradedSituationApplicability"></see>
    /// </summary>
    let ``shapes/EtcsDegradedSituationApplicability`` =
        _prefix "shapes/EtcsDegradedSituationApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsDegradedSituationSKOS"></see>
    /// </summary>
    let ``shapes/EtcsDegradedSituationSKOS`` =
        _prefix "shapes/EtcsDegradedSituationSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/lineSideSystemDegradedSituationObjParameter"></see>
    /// </summary>
    let lineSideSystemDegradedSituationObjParameter =
        _prefix "lineSideSystemDegradedSituationObjParameter"

    /// <summary>
    /// ETCS equipment on-board and its level.
    /// <see href="http://data.europa.eu/949/etcsEquipmentOnBoardLevel"></see></summary>
    let etcsEquipmentOnBoardLevel = _prefix "etcsEquipmentOnBoardLevel"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-equipment-on-board-level/eratv/ETCSEquipmentLevels"></see>
    /// </summary>
    let ``concepts/etcs-equipment-on-board-level/eratv/ETCSEquipmentLevels`` =
        _prefix "concepts/etcs-equipment-on-board-level/eratv/ETCSEquipmentLevels"

    /// <summary>
    /// If the trackside does not implement any solution to cover non-protected LXs (which are normally protected by means of a technical system), then drivers will be required to comply with instructions received from other sources
    /// <see href="http://data.europa.eu/949/etcsImplementsLevelCrossingProcedure"></see></summary>
    let etcsImplementsLevelCrossingProcedure =
        _prefix "etcsImplementsLevelCrossingProcedure"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsImplementsLevelCrossingProcedureApplicability"></see>
    /// </summary>
    let ``shapes/EtcsImplementsLevelCrossingProcedureApplicability`` =
        _prefix "shapes/EtcsImplementsLevelCrossingProcedureApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsImplementsLevelCrossingProcedure"></see>
    /// </summary>
    let ``shapes/EtcsImplementsLevelCrossingProcedure`` =
        _prefix "shapes/EtcsImplementsLevelCrossingProcedure"

    /// <summary>
    /// Information about installed trackside equipment capable to transmit infill information by loop or Global System for Mobile communications for Railways (GSM-R) for level 1 installations.
    /// <see href="http://data.europa.eu/949/etcsInfill"></see></summary>
    let etcsInfill = _prefix "etcsInfill"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-infills/ETCSInfills"></see>
    /// </summary>
    let ``concepts/etcs-infills/ETCSInfills`` =
        _prefix "concepts/etcs-infills/ETCSInfills"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsInfillSKOS"></see>
    /// </summary>
    let ``shapes/EtcsInfillSKOS`` = _prefix "shapes/EtcsInfillSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsInfillApplicability"></see>
    /// </summary>
    let ``shapes/EtcsInfillApplicability`` = _prefix "shapes/EtcsInfillApplicability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsInfill"></see>
    /// </summary>
    let ``shapes/EtcsInfill`` = _prefix "shapes/EtcsInfill"
    /// <summary>
    /// Indication whether infill is required to access the line for safety reasons.
    /// <see href="http://data.europa.eu/949/etcsInfillLineAccess"></see></summary>
    let etcsInfillLineAccess = _prefix "etcsInfillLineAccess"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsInfillLineAccess"></see>
    /// </summary>
    let ``shapes/EtcsInfillLineAccess`` = _prefix "shapes/EtcsInfillLineAccess"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsInfillLineAccessApplicability"></see>
    /// </summary>
    let ``shapes/EtcsInfillLineAccessApplicability`` =
        _prefix "shapes/EtcsInfillLineAccessApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-levels/ETCSLevels"></see>
    /// </summary>
    let ``concepts/etcs-levels/ETCSLevels`` = _prefix "concepts/etcs-levels/ETCSLevels"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsLevelTypeSKOS"></see>
    /// </summary>
    let ``shapes/EtcsLevelTypeSKOS`` = _prefix "shapes/EtcsLevelTypeSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsLevelType"></see>
    /// </summary>
    let ``shapes/EtcsLevelType`` = _prefix "shapes/EtcsLevelType"
    /// <summary>
    /// Transmittable track conditions by the CCSSubsystem, according to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/etcsTransmittedTrackConditions"></see></summary>
    let etcsTransmittedTrackConditions = _prefix "etcsTransmittedTrackConditions"
    /// <summary>
    /// ETCS requirements used for demonstrating technical compatibility.
    /// <see href="http://data.europa.eu/949/etcsSystemCompatibility"></see></summary>
    let etcsSystemCompatibility = _prefix "etcsSystemCompatibility"
    /// <summary>
    /// Unique RBC identification (NID_C+NID_RBC)  as defined in the specification referenced in Appendix A-1, index [C] (TSI CCS).
    /// <see href="http://data.europa.eu/949/rbcID"></see></summary>
    let rbcID = _prefix "rbcID"
    /// <summary>
    /// Number of simultaneous communication session on board for ETCS level 2 required for a smooth running of the train. This relates to the radio block centre (RBC) handling of communication sessions. Not safety critical and no matter of interoperability.
    /// <see href="http://data.europa.eu/949/gsmRActiveMobiles"></see></summary>
    let gsmRActiveMobiles = _prefix "gsmRActiveMobiles"
    /// <summary>
    /// Unique RBC calling number (NID_RADIO) as defined in the specification referenced in Appendix A-1, index [C].
    /// <see href="http://data.europa.eu/949/rbcPhone"></see></summary>
    let rbcPhone = _prefix "rbcPhone"
    /// <summary>
    /// ETCS M_version according to the specification referenced in Appendix A-1, index [C], SRS 7.5.1.9.
    /// <see href="http://data.europa.eu/949/etcsMVersion"></see></summary>
    let etcsMVersion = _prefix "etcsMVersion"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-m-versions/ETCSMVersions"></see>
    /// </summary>
    let ``concepts/etcs-m-versions/ETCSMVersions`` =
        _prefix "concepts/etcs-m-versions/ETCSMVersions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsMVersionApplicability"></see>
    /// </summary>
    let ``shapes/EtcsMVersionApplicability`` =
        _prefix "shapes/EtcsMVersionApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsMVersionSKOS"></see>
    /// </summary>
    let ``shapes/EtcsMVersionSKOS`` = _prefix "shapes/EtcsMVersionSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsMVersion"></see>
    /// </summary>
    let ``shapes/EtcsMVersion`` = _prefix "shapes/EtcsMVersion"
    /// <summary>
    /// ETCS national applications implemented (NID_XUSER of Packet 44).
    /// <see href="http://data.europa.eu/949/etcsNationalApplications"></see></summary>
    let etcsNationalApplications = _prefix "etcsNationalApplications"
    /// <summary>
    /// Indication whether data for national applications is transmitted between track and train.
    /// <see href="http://data.europa.eu/949/etcsNationalPacket44"></see></summary>
    let etcsNationalPacket44 = _prefix "etcsNationalPacket44"
    /// <summary>
    /// Indication whether data for national packet 44 applications is transmitted between track and train.
    /// <see href="http://data.europa.eu/949/hasEtcsNationalPacket44"></see></summary>
    let hasEtcsNationalPacket44 = _prefix "hasEtcsNationalPacket44"
    /// <summary>
    /// Indication whether data for national applications is transmitted between track and train.
    /// <see href="http://data.europa.eu/949/etcsNationalPacket44Function"></see></summary>
    let etcsNationalPacket44Function = _prefix "etcsNationalPacket44Function"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-national-packet-44-functions/ETCSNationalPacket44Functions"></see>
    /// </summary>
    let ``concepts/etcs-national-packet-44-functions/ETCSNationalPacket44Functions`` =
        _prefix "concepts/etcs-national-packet-44-functions/ETCSNationalPacket44Functions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsNationalPacket44Function"></see>
    /// </summary>
    let ``shapes/EtcsNationalPacket44Function`` =
        _prefix "shapes/EtcsNationalPacket44Function"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsNationalPacket44FunctionSKOS"></see>
    /// </summary>
    let ``shapes/EtcsNationalPacket44FunctionSKOS`` =
        _prefix "shapes/EtcsNationalPacket44FunctionSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/etcsNationalValuesObjParameter"></see>
    /// </summary>
    let etcsNationalValuesObjParameter = _prefix "etcsNationalValuesObjParameter"
    /// <summary>
    /// ETCS on-board implementation.
    /// <see href="http://data.europa.eu/949/etcsOnBoardImplementation"></see></summary>
    let etcsOnBoardImplementation = _prefix "etcsOnBoardImplementation"
    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Optional ETCS functions which might improve operation on the line.
    /// <see href="http://data.europa.eu/949/etcsOptionalFunctions"></see></summary>
    let etcsOptionalFunctions = _prefix "etcsOptionalFunctions"
    /// <summary>
    /// Indication of the document where restrictions or conditions due to partial compliance with the TSI CCS are described.
    /// <see href="http://data.europa.eu/949/etcsRestrictionsConditionsDoc"></see></summary>
    let etcsRestrictionsConditionsDoc = _prefix "etcsRestrictionsConditionsDoc"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsRestrictionsConditionsDoc"></see>
    /// </summary>
    let ``shapes/EtcsRestrictionsConditionsDoc`` =
        _prefix "shapes/EtcsRestrictionsConditionsDoc"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsRestrictionsConditionsDocApplicability"></see>
    /// </summary>
    let ``shapes/EtcsRestrictionsConditionsDocApplicability`` =
        _prefix "shapes/EtcsRestrictionsConditionsDocApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-system-compatibilities/ETCSSystemCompatibilities"></see>
    /// </summary>
    let ``concepts/etcs-system-compatibilities/ETCSSystemCompatibilities`` =
        _prefix "concepts/etcs-system-compatibilities/ETCSSystemCompatibilities"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsSystemCompatibilitySKOS"></see>
    /// </summary>
    let ``shapes/EtcsSystemCompatibilitySKOS`` =
        _prefix "shapes/EtcsSystemCompatibilitySKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsSystemCompatibilityApplicability"></see>
    /// </summary>
    let ``shapes/EtcsSystemCompatibilityApplicability`` =
        _prefix "shapes/EtcsSystemCompatibilityApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsSystemCompatibility"></see>
    /// </summary>
    let ``shapes/EtcsSystemCompatibility`` = _prefix "shapes/EtcsSystemCompatibility"

    /// <summary>
    /// (Deprecated) List of ETCS system version 2.2 or 3.0 functionalities to be required in the next 5 years according to TSI CCS point 6.1.1.2 and Appendix G
    /// <see href="http://data.europa.eu/949/etcsSystemFunctionalitiesNextFiveYears"></see></summary>
    let etcsSystemFunctionalitiesNextFiveYears =
        _prefix "etcsSystemFunctionalitiesNextFiveYears"

    /// <summary>
    /// If the trackside does not provide Track Conditions, the driver will need to be informed about such conditions via alternative methods.
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/etcsTransmitsTrackConditions"></see></summary>
    let etcsTransmitsTrackConditions = _prefix "etcsTransmitsTrackConditions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsTransmitsTrackConditionsApplicability"></see>
    /// </summary>
    let ``shapes/EtcsTransmitsTrackConditionsApplicability`` =
        _prefix "shapes/EtcsTransmitsTrackConditionsApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsTransmitsTrackConditions"></see>
    /// </summary>
    let ``shapes/EtcsTransmitsTrackConditions`` =
        _prefix "shapes/EtcsTransmitsTrackConditions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-transmitted-tcs/TransmittedTrackConditions"></see>
    /// </summary>
    let ``concepts/etcs-transmitted-tcs/TransmittedTrackConditions`` =
        _prefix "concepts/etcs-transmitted-tcs/TransmittedTrackConditions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsTransmittedTrackConditions"></see>
    /// </summary>
    let ``shapes/EtcsTransmittedTrackConditions`` =
        _prefix "shapes/EtcsTransmittedTrackConditions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsTransmittedTrackConditionsSKOS"></see>
    /// </summary>
    let ``shapes/EtcsTransmittedTrackConditionsSKOS`` =
        _prefix "shapes/EtcsTransmittedTrackConditionsSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsTransmittedTrackConditionsApplicability"></see>
    /// </summary>
    let ``shapes/EtcsTransmittedTrackConditionsApplicability`` =
        _prefix "shapes/EtcsTransmittedTrackConditionsApplicability"

    /// <summary>
    /// Indication of which European Transport Corridor the element belongs to.
    /// <see href="http://data.europa.eu/949/europeanTransportCorridor"></see></summary>
    let europeanTransportCorridor = _prefix "europeanTransportCorridor"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/european-transport-corridors/EuropeanTransportCorridors"></see>
    /// </summary>
    let ``concepts/european-transport-corridors/EuropeanTransportCorridors`` =
        _prefix "concepts/european-transport-corridors/EuropeanTransportCorridors"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EuropeanTransportCorridorSKOS"></see>
    /// </summary>
    let ``shapes/EuropeanTransportCorridorSKOS`` =
        _prefix "shapes/EuropeanTransportCorridorSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EuropeanTransportCorridor"></see>
    /// </summary>
    let ``shapes/EuropeanTransportCorridor`` =
        _prefix "shapes/EuropeanTransportCorridor"

    /// <summary>
    /// Indicates whether special vehicles are exempted from the need to install ATO (Automatic Train Operation) for this infrastructure element.
    /// <see href="http://data.europa.eu/949/exemptSpecialVehiclesFromATO"></see></summary>
    let exemptSpecialVehiclesFromATO = _prefix "exemptSpecialVehiclesFromATO"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ExemptSpecialVehiclesFromATO"></see>
    /// </summary>
    let ``shapes/ExemptSpecialVehiclesFromATO`` =
        _prefix "shapes/ExemptSpecialVehiclesFromATO"

    /// <summary>
    /// Indicates whether special vehicles are exempted from the need to install ETCS (European Train Control System) for this infrastructure element.
    /// <see href="http://data.europa.eu/949/exemptSpecialVehiclesFromETCS"></see></summary>
    let exemptSpecialVehiclesFromETCS = _prefix "exemptSpecialVehiclesFromETCS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ExemptSpecialVehiclesFromETCS"></see>
    /// </summary>
    let ``shapes/ExemptSpecialVehiclesFromETCS`` =
        _prefix "shapes/ExemptSpecialVehiclesFromETCS"

    /// <summary>
    /// Indicates whether special vehicles are exempted from the need to install RMR (Railway Mobile Radio) for this infrastructure element.
    /// <see href="http://data.europa.eu/949/exemptSpecialVehiclesFromRMR"></see></summary>
    let exemptSpecialVehiclesFromRMR = _prefix "exemptSpecialVehiclesFromRMR"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ExemptSpecialVehiclesFromRMR"></see>
    /// </summary>
    let ``shapes/ExemptSpecialVehiclesFromRMR`` =
        _prefix "shapes/ExemptSpecialVehiclesFromRMR"

    /// <summary>
    /// Indicate, if there are any wind restrictions for a bridge.
    /// <see href="http://data.europa.eu/949/existBridgeWindRestriction"></see></summary>
    let existBridgeWindRestriction = _prefix "existBridgeWindRestriction"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/bridgeWindRestriction"></see>
    /// </summary>
    let bridgeWindRestriction = _prefix "bridgeWindRestriction"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/networkStatementsDataCharacteristic"></see>
    /// </summary>
    let networkStatementsDataCharacteristic =
        _prefix "networkStatementsDataCharacteristic"

    /// <summary>
    /// Indicate, if there are any opening hours of the section of a line or Tunnel or Bridge.
    /// <see href="http://data.europa.eu/949/existOpeningHoursLimitation"></see></summary>
    let existOpeningHoursLimitation = _prefix "existOpeningHoursLimitation"
    /// <summary>
    /// Opening hours of the section of a line or tunnel or a bridge
    /// <see href="http://data.europa.eu/949/openingHoursLimitation"></see></summary>
    let openingHoursLimitation = _prefix "openingHoursLimitation"
    /// <summary>
    /// Indicate, if there are any limits on transportation of dangerous goods.
    /// <see href="http://data.europa.eu/949/existRestrictedDangerousGood"></see></summary>
    let existRestrictedDangerousGood = _prefix "existRestrictedDangerousGood"
    /// <summary>
    /// Description of the type of dangerous good that are not allowed in the tunnel
    /// <see href="http://data.europa.eu/949/restrictedDangerousGood"></see></summary>
    let restrictedDangerousGood = _prefix "restrictedDangerousGood"

    /// <summary>
    /// Indicate, if there are any limits on specific time of a day for transport of dangerous goods.
    /// <see href="http://data.europa.eu/949/existRestrictedPeriodOfTimeDangerousGood"></see></summary>
    let existRestrictedPeriodOfTimeDangerousGood =
        _prefix "existRestrictedPeriodOfTimeDangerousGood"

    /// <summary>
    /// Describes the period of time for which the transport of dangerous goods is not allowed in the Section of Line
    /// <see href="http://data.europa.eu/949/restrictedPeriodOfTimeDangerousGood"></see></summary>
    let restrictedPeriodOfTimeDangerousGood =
        _prefix "restrictedPeriodOfTimeDangerousGood"

    /// <summary>
    /// Indicate, if there are any limits on specific type of vehicle in the tunnel.
    /// <see href="http://data.europa.eu/949/existRestrictedTypeOfVehicleOfTunnel"></see></summary>
    let existRestrictedTypeOfVehicleOfTunnel =
        _prefix "existRestrictedTypeOfVehicleOfTunnel"

    /// <summary>
    /// Specific types of vehicles restricted in the tunnel.
    /// <see href="http://data.europa.eu/949/restrictedTypeOfVehicleInTunnel"></see></summary>
    let restrictedTypeOfVehicleInTunnel = _prefix "restrictedTypeOfVehicleInTunnel"
    /// <summary>
    /// Indicate, if passenger and freight trains meeting together in a tunnel is allowed
    /// <see href="http://data.europa.eu/949/existTrainExclusionOfSimultaneity"></see></summary>
    let existTrainExclusionOfSimultaneity = _prefix "existTrainExclusionOfSimultaneity"
    /// <summary>
    /// Indication that the full section of line (or a part of it) it is identified by the Infrastructure Managers (and communicated to the RU) where drivers are not supposed to get off the locomotive.
    /// <see href="http://data.europa.eu/949/existenceOfIndustrialRisk"></see></summary>
    let existenceOfIndustrialRisk = _prefix "existenceOfIndustrialRisk"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/routeBookDataParameter"></see>
    /// </summary>
    let routeBookDataParameter = _prefix "routeBookDataParameter"
    /// <summary>
    /// Wheel material is ferromagnetic.
    /// <see href="http://data.europa.eu/949/ferromagneticWheelMaterial"></see></summary>
    let ferromagneticWheelMaterial = _prefix "ferromagneticWheelMaterial"
    /// <summary>
    /// Fire safety category for tunnels.
    /// <see href="http://data.europa.eu/949/fireSafetyCategory"></see></summary>
    let fireSafetyCategory = _prefix "fireSafetyCategory"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/rolling-stock-fire/Categories"></see>
    /// </summary>
    let ``concepts/rolling-stock-fire/Categories`` =
        _prefix "concepts/rolling-stock-fire/Categories"

    /// <summary>
    /// Number of fixed seats.
    /// <see href="http://data.europa.eu/949/fixedSeats"></see></summary>
    let fixedSeats = _prefix "fixedSeats"
    /// <summary>
    /// Indication whether the use of on-board device for flange lubrication is forbidden.
    /// <see href="http://data.europa.eu/949/flangeLubeForbidden"></see></summary>
    let flangeLubeForbidden = _prefix "flangeLubeForbidden"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FlangeLubeForbidden"></see>
    /// </summary>
    let ``shapes/FlangeLubeForbidden`` = _prefix "shapes/FlangeLubeForbidden"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/healthSafetyAndEnvironmentDataParameter"></see>
    /// </summary>
    let healthSafetyAndEnvironmentDataParameter =
        _prefix "healthSafetyAndEnvironmentDataParameter"

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication whether rules for activation or deactivation of flange lubrication exist.
    /// <see href="http://data.europa.eu/949/flangeLubeRules"></see></summary>
    let flangeLubeRules = _prefix "flangeLubeRules"
    /// <summary>
    /// Indicates if the vehicle type is fitted for flange lubrication.
    /// <see href="http://data.europa.eu/949/flangeLubricationFitted"></see></summary>
    let flangeLubricationFitted = _prefix "flangeLubricationFitted"
    /// <summary>
    /// Indication whether the line is designated to a Railway Freight Corridor.
    /// <see href="http://data.europa.eu/949/freightCorridor"></see></summary>
    let freightCorridor = _prefix "freightCorridor"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/freight-corridor/FreightCorridors"></see>
    /// </summary>
    let ``concepts/freight-corridor/FreightCorridors`` =
        _prefix "concepts/freight-corridor/FreightCorridors"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FreightCorridorSKOS"></see>
    /// </summary>
    let ``shapes/FreightCorridorSKOS`` = _prefix "shapes/FreightCorridorSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FreightCorridorPreDeprecationWarning"></see>
    /// </summary>
    let ``shapes/FreightCorridorPreDeprecationWarning`` =
        _prefix "shapes/FreightCorridorPreDeprecationWarning"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FreightCorridor"></see>
    /// </summary>
    let ``shapes/FreightCorridor`` = _prefix "shapes/FreightCorridor"
    /// <summary>
    /// Freight possible flag attached to a Primary Location.
    /// <see href="http://data.europa.eu/949/freightFlag"></see></summary>
    let freightFlag = _prefix "freightFlag"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FreightFlag"></see>
    /// </summary>
    let ``shapes/FreightFlag`` = _prefix "shapes/FreightFlag"

    /// <summary>
    /// Specific for route compatibility check on French network. The reason for deprecation is because of replacement by a class, an object property and two datatype properties. The reason is that the property is composed of two values: A boolean [Y/N] and  a number N is between 1 and 8.
    /// <see href="http://data.europa.eu/949/frenchTrainDetectionSystemLimitation"></see></summary>
    let frenchTrainDetectionSystemLimitation =
        _prefix "frenchTrainDetectionSystemLimitation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/train-detection/FrenchTrainDetectionSystemLimitations"></see>
    /// </summary>
    let ``concepts/train-detection/FrenchTrainDetectionSystemLimitations`` =
        _prefix "concepts/train-detection/FrenchTrainDetectionSystemLimitations"

    /// <summary>
    /// Part of the section with train detection limitation that indicates if it is applicable. Only for the French network.
    /// <see href="http://data.europa.eu/949/frenchTrainDetectionSystemLimitationApplicable"></see></summary>
    let frenchTrainDetectionSystemLimitationApplicable =
        _prefix "frenchTrainDetectionSystemLimitationApplicable"

    /// <summary>
    /// Part of the section with train detection limitation that indicates the type of train detection limitation.
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
    /// [8] 45-second delay for specific announcement reset devices
    /// <see href="http://data.europa.eu/949/frenchTrainDetectionSystemLimitationNumber"></see></summary>
    let frenchTrainDetectionSystemLimitationNumber =
        _prefix "frenchTrainDetectionSystemLimitationNumber"

    /// <summary>
    /// Specific for route compatibility check on French network.
    /// <see href="http://data.europa.eu/949/tdsFrenchTrainDetectionSystemLimitation"></see></summary>
    let tdsFrenchTrainDetectionSystemLimitation =
        _prefix "tdsFrenchTrainDetectionSystemLimitation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationApplicable"></see>
    /// </summary>
    let ``shapes/FrenchTrainDetectionSystemLimitationApplicable`` =
        _prefix "shapes/FrenchTrainDetectionSystemLimitationApplicable"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/train-detection-numbers/FrenchTrainDetectionSystemLimitationNumbers"></see>
    /// </summary>
    let ``concepts/train-detection-numbers/FrenchTrainDetectionSystemLimitationNumbers`` =
        _prefix "concepts/train-detection-numbers/FrenchTrainDetectionSystemLimitationNumbers"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationNumberSKOS"></see>
    /// </summary>
    let ``shapes/FrenchTrainDetectionSystemLimitationNumberSKOS`` =
        _prefix "shapes/FrenchTrainDetectionSystemLimitationNumberSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationNumber"></see>
    /// </summary>
    let ``shapes/FrenchTrainDetectionSystemLimitationNumber`` =
        _prefix "shapes/FrenchTrainDetectionSystemLimitationNumber"

    /// <summary>
    /// Bands of the frequency management of the train detection systems as defined in the TSI CCS, and in the specific cases or technical documents referred to in Article 13 of TSI CCS when they are available.
    /// <see href="http://data.europa.eu/949/frequencyBandsForDetection"></see></summary>
    let frequencyBandsForDetection = _prefix "frequencyBandsForDetection"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/train-detection/FrequencyBandsForDetection"></see>
    /// </summary>
    let ``concepts/train-detection/FrequencyBandsForDetection`` =
        _prefix "concepts/train-detection/FrequencyBandsForDetection"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FrequencyBandsForDetectionSKOS"></see>
    /// </summary>
    let ``shapes/FrequencyBandsForDetectionSKOS`` =
        _prefix "shapes/FrequencyBandsForDetectionSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FrequencyBandsForDetection"></see>
    /// </summary>
    let ``shapes/FrequencyBandsForDetection`` =
        _prefix "shapes/FrequencyBandsForDetection"

    /// <summary>
    /// The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band.
    /// It should be provided in 3 directions.
    /// <see href="http://data.europa.eu/949/tdsMaximumMagneticField"></see></summary>
    let tdsMaximumMagneticField = _prefix "tdsMaximumMagneticField"
    /// <summary>
    /// Impedance as defined in the specification referenced in Appendix A-1, index [D]
    /// <see href="http://data.europa.eu/949/minVehicleImpedance"></see></summary>
    let minVehicleImpedance = _prefix "minVehicleImpedance"
    /// <summary>
    /// Maximum interference current limits allowed for track circuits for a defined frequency band.
    /// <see href="http://data.europa.eu/949/maximumInterferenceCurrent"></see></summary>
    let maximumInterferenceCurrent = _prefix "maximumInterferenceCurrent"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trainDetectionSystemBasedFrequencyBandsObjParameter"></see>
    /// </summary>
    let trainDetectionSystemBasedFrequencyBandsObjParameter =
        _prefix "trainDetectionSystemBasedFrequencyBandsObjParameter"

    /// <summary>
    /// Location of particular points requiring specific checks due to deviations from gauging referred to in parameter "Gauging"
    /// <see href="http://data.europa.eu/949/gaugingCheckLocation"></see></summary>
    let gaugingCheckLocation = _prefix "gaugingCheckLocation"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GaugingCheckLocation"></see>
    /// </summary>
    let ``shapes/GaugingCheckLocation`` = _prefix "shapes/GaugingCheckLocation"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/lineLayoutDataParameter"></see>
    /// </summary>
    let lineLayoutDataParameter = _prefix "lineLayoutDataParameter"
    /// <summary>
    /// Gauges as defined in European standard or other local gauges, including lower or upper part.
    /// <see href="http://data.europa.eu/949/gaugingProfile"></see></summary>
    let gaugingProfile = _prefix "gaugingProfile"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gaugings/GaugingProfiles"></see>
    /// </summary>
    let ``concepts/gaugings/GaugingProfiles`` =
        _prefix "concepts/gaugings/GaugingProfiles"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GaugingProfileSKOS"></see>
    /// </summary>
    let ``shapes/GaugingProfileSKOS`` = _prefix "shapes/GaugingProfileSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GaugingProfile"></see>
    /// </summary>
    let ``shapes/GaugingProfile`` = _prefix "shapes/GaugingProfile"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/lineLayoutObjParameter"></see>
    /// </summary>
    let lineLayoutObjParameter = _prefix "lineLayoutObjParameter"
    /// <summary>
    /// Electronic document available from the IM stored by the Agency with the transversal section of the particular points requiring specific checks due to deviations from gauging referred to in parameter "Gauging". Where relevant, guidance for the check with the particular point may be attached to the document with the transversal section.
    /// <see href="http://data.europa.eu/949/gaugingTransversalDocument"></see></summary>
    let gaugingTransversalDocument = _prefix "gaugingTransversalDocument"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GaugingTransversalDocument"></see>
    /// </summary>
    let ``shapes/GaugingTransversalDocument`` =
        _prefix "shapes/GaugingTransversalDocument"

    /// <summary>
    /// Indication if GPRS can be used for ETCS
    /// <see href="http://data.europa.eu/949/gprsForETCS"></see></summary>
    let gprsForETCS = _prefix "gprsForETCS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GprsForETCS"></see>
    /// </summary>
    let ``shapes/GprsForETCS`` = _prefix "shapes/GprsForETCS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GprsForETCSApplicability"></see>
    /// </summary>
    let ``shapes/GprsForETCSApplicability`` = _prefix "shapes/GprsForETCSApplicability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/tsiCompliantRadioDataParameter"></see>
    /// </summary>
    let tsiCompliantRadioDataParameter = _prefix "tsiCompliantRadioDataParameter"
    /// <summary>
    /// Indication of the area in which GPRS can be used for ETCS, expressed as a list of GPRS-enabled RBCs.
    /// <see href="http://data.europa.eu/949/gprsImplementationArea"></see></summary>
    let gprsImplementationArea = _prefix "gprsImplementationArea"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GprsImplementationAreaApplicability"></see>
    /// </summary>
    let ``shapes/GprsImplementationAreaApplicability`` =
        _prefix "shapes/GprsImplementationAreaApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GprsImplementationArea"></see>
    /// </summary>
    let ``shapes/GprsImplementationArea`` = _prefix "shapes/GprsImplementationArea"
    /// <summary>
    /// Maximum value of the gradient for stabling tracks expressed in millimetres per metre.
    /// <see href="http://data.europa.eu/949/gradient"></see></summary>
    let gradient = _prefix "gradient"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Gradient"></see>
    /// </summary>
    let ``shapes/Gradient`` = _prefix "shapes/Gradient"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/sidingDataParameter"></see>
    /// </summary>
    let sidingDataParameter = _prefix "sidingDataParameter"
    /// <summary>
    /// Sequence of gradient values and locations of change in gradient
    /// <see href="http://data.europa.eu/949/gradientProfile"></see></summary>
    let gradientProfile = _prefix "gradientProfile"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GradientProfile"></see>
    /// </summary>
    let ``shapes/GradientProfile`` = _prefix "shapes/GradientProfile"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gsmr-number-active-mobiles/NumberActiveMobiles"></see>
    /// </summary>
    let ``concepts/gsmr-number-active-mobiles/NumberActiveMobiles`` =
        _prefix "concepts/gsmr-number-active-mobiles/NumberActiveMobiles"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRActiveMobilesSKOS"></see>
    /// </summary>
    let ``shapes/GsmRActiveMobilesSKOS`` = _prefix "shapes/GsmRActiveMobilesSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRActiveMobilesApplicability"></see>
    /// </summary>
    let ``shapes/GsmRActiveMobilesApplicability`` =
        _prefix "shapes/GsmRActiveMobilesApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRActiveMobiles"></see>
    /// </summary>
    let ``shapes/GsmRActiveMobiles`` = _prefix "shapes/GsmRActiveMobiles"
    /// <summary>
    /// Any additional information on network characteristics or corresponding document available from the IM and stored by the Agency, e.g.; interference level, leading to the recommendation of additional on-board protection.
    /// <see href="http://data.europa.eu/949/gsmRAdditionalInfo"></see></summary>
    let gsmRAdditionalInfo = _prefix "gsmRAdditionalInfo"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRAdditionalInfoApplicability"></see>
    /// </summary>
    let ``shapes/GsmRAdditionalInfoApplicability`` =
        _prefix "shapes/GsmRAdditionalInfoApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRAdditionalInfo"></see>
    /// </summary>
    let ``shapes/GsmRAdditionalInfo`` = _prefix "shapes/GsmRAdditionalInfo"
    /// <summary>
    /// Indication if there is no GSMR coverage
    /// <see href="http://data.europa.eu/949/gsmRNoCoverage"></see></summary>
    let gsmRNoCoverage = _prefix "gsmRNoCoverage"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRNoCoverageApplicability"></see>
    /// </summary>
    let ``shapes/GsmRNoCoverageApplicability`` =
        _prefix "shapes/GsmRNoCoverageApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRNoCoverage"></see>
    /// </summary>
    let ``shapes/GsmRNoCoverage`` = _prefix "shapes/GsmRNoCoverage"
    /// <summary>
    /// Use of optional GSM-R functions which might improve operation on the line. They are for information only and not for network access criteria.
    /// <see href="http://data.europa.eu/949/gsmROptionalFunctions"></see></summary>
    let gsmROptionalFunctions = _prefix "gsmROptionalFunctions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gsmr-optional-functions/OptionalFunctions"></see>
    /// </summary>
    let ``concepts/gsmr-optional-functions/OptionalFunctions`` =
        _prefix "concepts/gsmr-optional-functions/OptionalFunctions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmROptionalFunctionsSKOS"></see>
    /// </summary>
    let ``shapes/GsmROptionalFunctionsSKOS`` =
        _prefix "shapes/GsmROptionalFunctionsSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmROptionalFunctions"></see>
    /// </summary>
    let ``shapes/GsmROptionalFunctions`` = _prefix "shapes/GsmROptionalFunctions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmROptionalFunctionsApplicability"></see>
    /// </summary>
    let ``shapes/GsmROptionalFunctionsApplicability`` =
        _prefix "shapes/GsmROptionalFunctionsApplicability"

    /// <summary>
    /// GSM-R Radio Data communication on board and its Baseline.
    /// <see href="http://data.europa.eu/949/gsmRRadioDataCommunication"></see></summary>
    let gsmRRadioDataCommunication = _prefix "gsmRRadioDataCommunication"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gsm-r-radio-data-communication/GSMRRadioDataCommunications"></see>
    /// </summary>
    let ``concepts/gsm-r-radio-data-communication/GSMRRadioDataCommunications`` =
        _prefix "concepts/gsm-r-radio-data-communication/GSMRRadioDataCommunications"

    /// <summary>
    /// Number of GSM-R mobile sets in driving cab for data transmission.
    /// <see href="http://data.europa.eu/949/gsmRSetsInDrivingCab"></see></summary>
    let gsmRSetsInDrivingCab = _prefix "gsmRSetsInDrivingCab"
    /// <summary>
    /// GSM-R functional requirements specification and system requirements specification in accordance with the specification respectively referenced in Appendix A-1, index [E] and index [F], version number installed lineside.
    /// <see href="http://data.europa.eu/949/gsmRVersion"></see></summary>
    let gsmRVersion = _prefix "gsmRVersion"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gsmr-versions/GSMRVersions"></see>
    /// </summary>
    let ``concepts/gsmr-versions/GSMRVersions`` =
        _prefix "concepts/gsmr-versions/GSMRVersions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRVersion"></see>
    /// </summary>
    let ``shapes/GsmRVersion`` = _prefix "shapes/GsmRVersion"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRVersionSKOS"></see>
    /// </summary>
    let ``shapes/GsmRVersionSKOS`` = _prefix "shapes/GsmRVersionSKOS"

    /// <summary>
    /// These constraints, where applicable, are meant to manage the limited number of circuit-switched radio connections that can be handled simultaneously by a Radio Block Center.
    /// <see href="http://data.europa.eu/949/gsmrConstraintsOperateOnlyInCircuitSwitch"></see></summary>
    let gsmrConstraintsOperateOnlyInCircuitSwitch =
        _prefix "gsmrConstraintsOperateOnlyInCircuitSwitch"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gsmr-cs-constraints/GSMRConstraints"></see>
    /// </summary>
    let ``concepts/gsmr-cs-constraints/GSMRConstraints`` =
        _prefix "concepts/gsmr-cs-constraints/GSMRConstraints"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmrConstraintsOperateOnlyInCircuitSwitchApplicability"></see>
    /// </summary>
    let ``shapes/GsmrConstraintsOperateOnlyInCircuitSwitchApplicability`` =
        _prefix "shapes/GsmrConstraintsOperateOnlyInCircuitSwitchApplicability"

    /// <summary>
    /// This feature will determine the applicable operational rules for drivers and signallers when dealing with cab radios registered under wrong numbers.
    /// <see href="http://data.europa.eu/949/gsmrForcedDeregistrationFunctionalNumber"></see></summary>
    let gsmrForcedDeregistrationFunctionalNumber =
        _prefix "gsmrForcedDeregistrationFunctionalNumber"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmrForcedDeregistrationFunctionalNumberApplicability"></see>
    /// </summary>
    let ``shapes/GsmrForcedDeregistrationFunctionalNumberApplicability`` =
        _prefix "shapes/GsmrForcedDeregistrationFunctionalNumberApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmrForcedDeregistrationFunctionalNumber"></see>
    /// </summary>
    let ``shapes/GsmrForcedDeregistrationFunctionalNumber`` =
        _prefix "shapes/GsmrForcedDeregistrationFunctionalNumber"

    /// <summary>
    /// Name of the own GSM-R network and list of GSM-R networks which are covered by a roaming agreement (for CS services).
    /// <see href="http://data.europa.eu/949/gsmrNetworkCoverage"></see></summary>
    let gsmrNetworkCoverage = _prefix "gsmrNetworkCoverage"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmrNetworkCoverage"></see>
    /// </summary>
    let ``shapes/GsmrNetworkCoverage`` = _prefix "shapes/GsmrNetworkCoverage"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmrNetworkCoverageSKOS"></see>
    /// </summary>
    let ``shapes/GsmrNetworkCoverageSKOS`` = _prefix "shapes/GsmrNetworkCoverageSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmrNetworkCoverageApplicability"></see>
    /// </summary>
    let ``shapes/GsmrNetworkCoverageApplicability`` =
        _prefix "shapes/GsmrNetworkCoverageApplicability"

    /// <summary>
    /// Handover point flag attached to a Primary location.
    /// <see href="http://data.europa.eu/949/handoverPointFlag"></see></summary>
    let handoverPointFlag = _prefix "handoverPointFlag"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HandoverPointFlag"></see>
    /// </summary>
    let ``shapes/HandoverPointFlag`` = _prefix "shapes/HandoverPointFlag"
    /// <summary>
    /// Property that links a physical entity with its topological abstraction representation.
    /// <see href="http://data.europa.eu/949/hasAbstraction"></see></summary>
    let hasAbstraction = _prefix "hasAbstraction"
    /// <summary>
    /// Availability by the IM of additional information as defined in point (2) of point 4.2.2.6.2 of Regulation (EU) 2023/1693 - TSI OPE
    /// <see href="http://data.europa.eu/949/hasAdditionalBrakingInformation"></see></summary>
    let hasAdditionalBrakingInformation = _prefix "hasAdditionalBrakingInformation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasAdditionalBrakingInformation"></see>
    /// </summary>
    let ``shapes/HasAdditionalBrakingInformation`` =
        _prefix "shapes/HasAdditionalBrakingInformation"

    /// <summary>
    /// Automatic dropping device (ADD) fitted (to be indicated for each energy supply system the vehicle is equipped for).
    /// <see href="http://data.europa.eu/949/hasAutomaticDroppingDevice"></see></summary>
    let hasAutomaticDroppingDevice = _prefix "hasAutomaticDroppingDevice"
    /// <summary>
    /// Specifies whether track construction is with sleepers embedded in ballast or not.
    /// <see href="http://data.europa.eu/949/hasBallast"></see></summary>
    let hasBallast = _prefix "hasBallast"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasBallast"></see>
    /// </summary>
    let ``shapes/HasBallast`` = _prefix "shapes/HasBallast"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasBallastApplicability"></see>
    /// </summary>
    let ``shapes/HasBallastApplicability`` = _prefix "shapes/HasBallastApplicability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/hasBridge"></see>
    /// </summary>
    let hasBridge = _prefix "hasBridge"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasBridge"></see>
    /// </summary>
    let ``shapes/HasBridge`` = _prefix "shapes/HasBridge"
    /// <summary>
    /// Vehicle equipped with a cant deficiency compensation system (tilting vehicle).
    /// <see href="http://data.europa.eu/949/hasCantDefficiencyCompensation"></see></summary>
    let hasCantDefficiencyCompensation = _prefix "hasCantDefficiencyCompensation"
    /// <summary>
    /// Indicates whether any neighbouring section of line belongs to different Infrastructure Manager
    /// <see href="http://data.europa.eu/949/hasConnectingIM"></see></summary>
    let hasConnectingIM = _prefix "hasConnectingIM"
    /// <summary>
    /// Electric units equipped with power or current limitation function.
    /// <see href="http://data.europa.eu/949/hasCurrentLimitation"></see></summary>
    let hasCurrentLimitation = _prefix "hasCurrentLimitation"
    /// <summary>
    /// Indication whether restrictions or conditions due to partial compliance with the TSI CCS exist.
    /// <see href="http://data.europa.eu/949/hasETCSRestrictionsConditions"></see></summary>
    let hasETCSRestrictionsConditions = _prefix "hasETCSRestrictionsConditions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasETCSRestrictionsConditionsApplicability"></see>
    /// </summary>
    let ``shapes/HasETCSRestrictionsConditionsApplicability`` =
        _prefix "shapes/HasETCSRestrictionsConditionsApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasETCSRestrictionsConditions"></see>
    /// </summary>
    let ``shapes/HasETCSRestrictionsConditions`` =
        _prefix "shapes/HasETCSRestrictionsConditions"

    /// <summary>
    /// Indication whether exists an installation of electric shore supply (fixed installation for servicing trains).
    /// <see href="http://data.europa.eu/949/hasElectricShoreSupply"></see></summary>
    let hasElectricShoreSupply = _prefix "hasElectricShoreSupply"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasElectricShoreSupply"></see>
    /// </summary>
    let ``shapes/HasElectricShoreSupply`` = _prefix "shapes/HasElectricShoreSupply"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/sidingFixedInstalationsDataParameter"></see>
    /// </summary>
    let sidingFixedInstalationsDataParameter =
        _prefix "sidingFixedInstalationsDataParameter"

    /// <summary>
    /// Indication whether emergency plan exists.
    /// <see href="http://data.europa.eu/949/hasEmergencyPlan"></see></summary>
    let hasEmergencyPlan = _prefix "hasEmergencyPlan"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasEmergencyPlan"></see>
    /// </summary>
    let ``shapes/HasEmergencyPlan`` = _prefix "shapes/HasEmergencyPlan"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasEmergencyPlanApplicability"></see>
    /// </summary>
    let ``shapes/HasEmergencyPlanApplicability`` =
        _prefix "shapes/HasEmergencyPlanApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasEtcsNationalPacket44"></see>
    /// </summary>
    let ``shapes/HasEtcsNationalPacket44`` = _prefix "shapes/HasEtcsNationalPacket44"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasEtcsNationalPacket44Applicability"></see>
    /// </summary>
    let ``shapes/HasEtcsNationalPacket44Applicability`` =
        _prefix "shapes/HasEtcsNationalPacket44Applicability"

    /// <summary>
    /// Indication of existence of evacuation and rescue points
    /// <see href="http://data.europa.eu/949/hasEvacuationAndRescuePoints"></see></summary>
    let hasEvacuationAndRescuePoints = _prefix "hasEvacuationAndRescuePoints"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasEvacuationAndRescuePoints"></see>
    /// </summary>
    let ``shapes/HasEvacuationAndRescuePoints`` =
        _prefix "shapes/HasEvacuationAndRescuePoints"

    /// <summary>
    /// Indication whether exists an installation of external cleaning facility (fixed installation for servicing trains) as defined in TSI INF
    /// <see href="http://data.europa.eu/949/hasExternalCleaning"></see></summary>
    let hasExternalCleaning = _prefix "hasExternalCleaning"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasExternalCleaning"></see>
    /// </summary>
    let ``shapes/HasExternalCleaning`` = _prefix "shapes/HasExternalCleaning"
    /// <summary>
    /// Existence of trackside HABD
    /// <see href="http://data.europa.eu/949/hasHotAxleBoxDetector"></see></summary>
    let hasHotAxleBoxDetector = _prefix "hasHotAxleBoxDetector"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasHotAxleBoxDetector"></see>
    /// </summary>
    let ``shapes/HasHotAxleBoxDetector`` = _prefix "shapes/HasHotAxleBoxDetector"
    /// <summary>
    /// Property that links a topological abstraction entity with its physical representation.
    /// <see href="http://data.europa.eu/949/hasImplementation"></see></summary>
    let hasImplementation = _prefix "hasImplementation"
    /// <summary>
    /// Specifies the linear referencing system to which the kilometre post is referenced. The linear referencing system is commonly the main railway line and it provides the framework for identifying the post's location along the railway line, using distance measurements rather than geographical coordinates.
    /// <see href="http://data.europa.eu/949/hasLRS"></see></summary>
    let hasLRS = _prefix "hasLRS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasLrsCoordinate"></see>
    /// </summary>
    let ``shapes/HasLrsCoordinate`` = _prefix "shapes/HasLrsCoordinate"
    /// <summary>
    /// Indication whether level crossings (including pedestrian track crossing) exist on the section of line.
    /// <see href="http://data.europa.eu/949/hasLevelCrossings"></see></summary>
    let hasLevelCrossings = _prefix "hasLevelCrossings"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasLevelCrossings"></see>
    /// </summary>
    let ``shapes/HasLevelCrossings`` = _prefix "shapes/HasLevelCrossings"
    /// <summary>
    /// Specifies the LRS coordinate associated with a topological coordinate.
    /// <see href="http://data.europa.eu/949/hasLrsCoordinate"></see></summary>
    let hasLrsCoordinate = _prefix "hasLrsCoordinate"
    /// <summary>
    /// Possibility of preventing the use of the lubrication device (only if fitted with flange lubrication).
    /// <see href="http://data.europa.eu/949/hasLubricationDevicePrevention"></see></summary>
    let hasLubricationDevicePrevention = _prefix "hasLubricationDevicePrevention"
    /// <summary>
    /// Indicate, if there are any limits on noise levels.
    /// <see href="http://data.europa.eu/949/hasNoiseLevelLimit"></see></summary>
    let hasNoiseLevelLimit = _prefix "hasNoiseLevelLimit"
    /// <summary>
    /// Maximum allowed noise level in decibels (dB).
    /// <see href="http://data.europa.eu/949/maxNoiseLevelOfSoL"></see></summary>
    let maxNoiseLevelOfSoL = _prefix "maxNoiseLevelOfSoL"
    /// <summary>
    /// Relates the Organisation role instance (the role played by an Organisation)  with the specific role in the taxonomy of organisation roles.
    /// <see href="http://data.europa.eu/949/hasOrganisationRole"></see></summary>
    let hasOrganisationRole = _prefix "hasOrganisationRole"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/organisation-roles/OrgRoles"></see>
    /// </summary>
    let ``concepts/organisation-roles/OrgRoles`` =
        _prefix "concepts/organisation-roles/OrgRoles"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasOrganisationRoleSKOS"></see>
    /// </summary>
    let ``shapes/HasOrganisationRoleSKOS`` = _prefix "shapes/HasOrganisationRoleSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasOrganisationRole"></see>
    /// </summary>
    let ``shapes/HasOrganisationRole`` = _prefix "shapes/HasOrganisationRole"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/hasOrientation"></see>
    /// </summary>
    let hasOrientation = _prefix "hasOrientation"
    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication if other train protection, control and warning systems in normal operation are installed lineside.
    /// <see href="http://data.europa.eu/949/hasOtherTrainProtection"></see></summary>
    let hasOtherTrainProtection = _prefix "hasOtherTrainProtection"
    /// <summary>
    /// Indicates if a vehicle type has parking brake.
    /// <see href="http://data.europa.eu/949/hasParkingBrake"></see></summary>
    let hasParkingBrake = _prefix "hasParkingBrake"
    /// <summary>
    /// Indicates that an infrastructure element is composed of one or more other (distinct) infrastructure elements.
    /// This property is used to represent part-whole relationships between infrastructure elements.
    /// An element cannot be a part of itself.
    /// <see href="http://data.europa.eu/949/hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasPartOP"></see>
    /// </summary>
    let ``shapes/HasPartOP`` = _prefix "shapes/HasPartOP"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasPart"></see>
    /// </summary>
    let ``shapes/HasPart`` = _prefix "shapes/HasPart"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasPartSoL"></see>
    /// </summary>
    let ``shapes/HasPartSoL`` = _prefix "shapes/HasPartSoL"
    /// <summary>
    /// Reference to a related siding.
    /// <see href="http://data.europa.eu/949/siding"></see></summary>
    let siding = _prefix "siding"
    /// <summary>
    /// Reference to a related railway track.
    /// <see href="http://data.europa.eu/949/track"></see></summary>
    let track = _prefix "track"
    /// <summary>
    /// Indicates that an infrastructure element is a part of another (distinct) infrastructure element.
    /// An element cannot be part of itself.
    /// This property is the inverse of era:hasPart and represents the partial or whole-part relationship between infrastructure elements.
    /// <see href="http://data.europa.eu/949/isPartOf"></see></summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    /// Indication of existence of phase separation and required information.
    /// <see href="http://data.europa.eu/949/hasPhaseSeparation"></see></summary>
    let hasPhaseSeparation = _prefix "hasPhaseSeparation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasPhaseSeparationApplicability"></see>
    /// </summary>
    let ``shapes/HasPhaseSeparationApplicability`` =
        _prefix "shapes/HasPhaseSeparationApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasPhaseSeparation"></see>
    /// </summary>
    let ``shapes/HasPhaseSeparation`` = _prefix "shapes/HasPhaseSeparation"
    /// <summary>
    /// Indication of the existence of the curvature of the platform.
    /// <see href="http://data.europa.eu/949/hasPlatformCurvature"></see></summary>
    let hasPlatformCurvature = _prefix "hasPlatformCurvature"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasPlatformCurvature"></see>
    /// </summary>
    let ``shapes/HasPlatformCurvature`` = _prefix "shapes/HasPlatformCurvature"
    /// <summary>
    /// Indication whether exists an installation of refuelling (fixed installation for servicing trains) as defined in TSI INF.
    /// <see href="http://data.europa.eu/949/hasRefuelling"></see></summary>
    let hasRefuelling = _prefix "hasRefuelling"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasRefuelling"></see>
    /// </summary>
    let ``shapes/HasRefuelling`` = _prefix "shapes/HasRefuelling"
    /// <summary>
    /// Indication whether regenerative braking is permitted or not.
    /// <see href="http://data.europa.eu/949/hasRegenerativeBrake"></see></summary>
    let hasRegenerativeBrake = _prefix "hasRegenerativeBrake"
    /// <summary>
    /// Indication whether an installation of sand restocking exists (fixed installation for servicing trains).
    /// <see href="http://data.europa.eu/949/hasSandRestocking"></see></summary>
    let hasSandRestocking = _prefix "hasSandRestocking"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasSandRestocking"></see>
    /// </summary>
    let ``shapes/HasSandRestocking`` = _prefix "shapes/HasSandRestocking"
    /// <summary>
    /// Possibility of preventing the use of sanding.
    /// <see href="http://data.europa.eu/949/hasSandingPrevention"></see></summary>
    let hasSandingPrevention = _prefix "hasSandingPrevention"
    /// <summary>
    /// The existence of a schematic overview of the operational point in digital form.
    /// <see href="http://data.europa.eu/949/hasSchematicOverviewOPDigitalForm"></see></summary>
    let hasSchematicOverviewOPDigitalForm = _prefix "hasSchematicOverviewOPDigitalForm"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasSchematicOverviewOPDigitalForm"></see>
    /// </summary>
    let ``shapes/HasSchematicOverviewOPDigitalForm`` =
        _prefix "shapes/HasSchematicOverviewOPDigitalForm"

    /// <summary>
    /// The ordered sequence of topological linear elements which create a linear net reference.
    /// <see href="http://data.europa.eu/949/hasSequence"></see></summary>
    let hasSequence = _prefix "hasSequence"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasSequence"></see>
    /// </summary>
    let ``shapes/HasSequence`` = _prefix "shapes/HasSequence"
    /// <summary>
    /// Climatic conditions on the line are severe according to European standard.
    /// <see href="http://data.europa.eu/949/hasSevereWeatherConditions"></see></summary>
    let hasSevereWeatherConditions = _prefix "hasSevereWeatherConditions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasSevereWeatherConditions"></see>
    /// </summary>
    let ``shapes/HasSevereWeatherConditions`` =
        _prefix "shapes/HasSevereWeatherConditions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/performanceDataParameter"></see>
    /// </summary>
    let performanceDataParameter = _prefix "performanceDataParameter"
    /// <summary>
    /// Indicates the presence of shunting restrictions.
    /// <see href="http://data.europa.eu/949/hasShuntingRestrictions"></see></summary>
    let hasShuntingRestrictions = _prefix "hasShuntingRestrictions"
    /// <summary>
    /// Indication of existence of system separation
    /// <see href="http://data.europa.eu/949/hasSystemSeparation"></see></summary>
    let hasSystemSeparation = _prefix "hasSystemSeparation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasSystemSeparationApplicability"></see>
    /// </summary>
    let ``shapes/HasSystemSeparationApplicability`` =
        _prefix "shapes/HasSystemSeparationApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasSystemSeparation"></see>
    /// </summary>
    let ``shapes/HasSystemSeparation`` = _prefix "shapes/HasSystemSeparation"
    /// <summary>
    /// Indication if there is any train detection system installed and fully compliant with the TSI CCS
    /// <see href="http://data.europa.eu/949/hasTSITrainDetection"></see></summary>
    let hasTSITrainDetection = _prefix "hasTSITrainDetection"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasTSITrainDetection"></see>
    /// </summary>
    let ``shapes/HasTSITrainDetection`` = _prefix "shapes/HasTSITrainDetection"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trainDetectionSystemBasedFrequencyBandsDataParameter"></see>
    /// </summary>
    let trainDetectionSystemBasedFrequencyBandsDataParameter =
        _prefix "trainDetectionSystemBasedFrequencyBandsDataParameter"

    /// <summary>
    /// Indication whether exists an installation of toilet discharge (fixed installation for servicing trains) as defined in TSI INF
    /// <see href="http://data.europa.eu/949/hasToiletDischarge"></see></summary>
    let hasToiletDischarge = _prefix "hasToiletDischarge"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasToiletDischarge"></see>
    /// </summary>
    let ``shapes/HasToiletDischarge`` = _prefix "shapes/HasToiletDischarge"
    /// <summary>
    /// Specifies the topological coordinate of a network point reference.
    /// <see href="http://data.europa.eu/949/hasTopoCoordinate"></see></summary>
    let hasTopoCoordinate = _prefix "hasTopoCoordinate"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasTopoCoordinate"></see>
    /// </summary>
    let ``shapes/HasTopoCoordinate`` = _prefix "shapes/HasTopoCoordinate"
    /// <summary>
    /// Indication of on-board management system about completeness of the train information.
    /// <see href="http://data.europa.eu/949/hasTrainIntegrityConfirmation"></see></summary>
    let hasTrainIntegrityConfirmation = _prefix "hasTrainIntegrityConfirmation"
    /// <summary>
    /// Indication of existence of walkways
    /// <see href="http://data.europa.eu/949/hasWalkway"></see></summary>
    let hasWalkway = _prefix "hasWalkway"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasWalkway"></see>
    /// </summary>
    let ``shapes/HasWalkway`` = _prefix "shapes/HasWalkway"
    /// <summary>
    /// Indication whether exists an installation of water restocking (fixed installation for servicing trains) as defined in TSI INF
    /// <see href="http://data.europa.eu/949/hasWaterRestocking"></see></summary>
    let hasWaterRestocking = _prefix "hasWaterRestocking"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasWaterRestocking"></see>
    /// </summary>
    let ``shapes/HasWaterRestocking`` = _prefix "shapes/HasWaterRestocking"
    /// <summary>
    /// Indicates the presence of a wheel slide protection system.
    /// <see href="http://data.europa.eu/949/hasWheelSlideProtectionSystem"></see></summary>
    let hasWheelSlideProtectionSystem = _prefix "hasWheelSlideProtectionSystem"
    /// <summary>
    /// This property indicates for each infrastructure element, the source, i.e. the identifier  or key that was input to the hash function in order to generate the hash value that is part of the hash URI.
    /// <see href="http://data.europa.eu/949/hashSource"></see></summary>
    let hashSource = _prefix "hashSource"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/infraSubsystemDataParameter"></see>
    /// </summary>
    let infraSubsystemDataParameter = _prefix "infraSubsystemDataParameter"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/infraSubsystemObjParameter"></see>
    /// </summary>
    let infraSubsystemObjParameter = _prefix "infraSubsystemObjParameter"
    /// <summary>
    /// For sections of line with a maximum permitted speed of 200 km/h or more. Information regarding the procedure to be used to perform the dynamic compatibility check.
    /// <see href="http://data.europa.eu/949/highSpeedLoadModelCompliance"></see></summary>
    let highSpeedLoadModelCompliance = _prefix "highSpeedLoadModelCompliance"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HighSpeedLoadModelCompliance"></see>
    /// </summary>
    let ``shapes/HighSpeedLoadModelCompliance`` =
        _prefix "shapes/HighSpeedLoadModelCompliance"

    /// <summary>
    /// Direction of measurement of trackside HABD, specific for the French Italian and Swedish networks.
    /// <see href="http://data.europa.eu/949/hotAxleBoxDetectorDirection"></see></summary>
    let hotAxleBoxDetectorDirection = _prefix "hotAxleBoxDetectorDirection"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/hot-axle-box-detector-direction/HotAxleBoxDetectorDirections"></see>
    /// </summary>
    let ``concepts/hot-axle-box-detector-direction/HotAxleBoxDetectorDirections`` =
        _prefix "concepts/hot-axle-box-detector-direction/HotAxleBoxDetectorDirections"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirectionApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorDirectionApplicability`` =
        _prefix "shapes/HotAxleBoxDetectorDirectionApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirection"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorDirection`` =
        _prefix "shapes/HotAxleBoxDetectorDirection"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirectionCountryApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorDirectionCountryApplicability`` =
        _prefix "shapes/HotAxleBoxDetectorDirectionCountryApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirectionSKOS"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorDirectionSKOS`` =
        _prefix "shapes/HotAxleBoxDetectorDirectionSKOS"

    /// <summary>
    /// Specific for the French Italian and Swedish networks.
    /// Generation of trackside hot axle box detector.
    /// <see href="http://data.europa.eu/949/hotAxleBoxDetectorGeneration"></see></summary>
    let hotAxleBoxDetectorGeneration = _prefix "hotAxleBoxDetectorGeneration"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorGenerationCountryApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorGenerationCountryApplicability`` =
        _prefix "shapes/HotAxleBoxDetectorGenerationCountryApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorGeneration"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorGeneration`` =
        _prefix "shapes/HotAxleBoxDetectorGeneration"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorGenerationApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorGenerationApplicability`` =
        _prefix "shapes/HotAxleBoxDetectorGenerationApplicability"

    /// <summary>
    /// Specific for the French, Italian and Swedish networks.
    /// Applicable if trackside HABD is not TSI compliant, identification of trackside hot axle box detector.
    /// <see href="http://data.europa.eu/949/hotAxleBoxDetectorIdentification"></see></summary>
    let hotAxleBoxDetectorIdentification = _prefix "hotAxleBoxDetectorIdentification"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorIdentificationCountryApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorIdentificationCountryApplicability`` =
        _prefix "shapes/HotAxleBoxDetectorIdentificationCountryApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorIdentificationApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorIdentificationApplicability`` =
        _prefix "shapes/HotAxleBoxDetectorIdentificationApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorIdentification"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorIdentification`` =
        _prefix "shapes/HotAxleBoxDetectorIdentification"

    /// <summary>
    /// Specific for the French Italian and Swedish networks.
    /// Applicable if trackside HABD is not TSI compliant, localisation of trackside hot axle box detector.
    /// <see href="http://data.europa.eu/949/hotAxleBoxDetectorLocation"></see></summary>
    let hotAxleBoxDetectorLocation = _prefix "hotAxleBoxDetectorLocation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorLocationCountryApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorLocationCountryApplicability`` =
        _prefix "shapes/HotAxleBoxDetectorLocationCountryApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorLocation"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorLocation`` =
        _prefix "shapes/HotAxleBoxDetectorLocation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorLocationApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorLocationApplicability`` =
        _prefix "shapes/HotAxleBoxDetectorLocationApplicability"

    /// <summary>
    /// Specific for the French, Italian and Swedish networks.
    /// Trackside HABD compliant to TSI means that the HABD Trackside is compliant with:
    /// - EN 15437-1:2009 referred in TSIs (LOC&amp;PAS: 4.2.3.3.2.2, WAG TSI: 4.2.3.4),
    /// - Specific cases mentioned in TSIs (LOC&amp;PAS TSI, WAG TSI).
    /// <see href="http://data.europa.eu/949/hotAxleBoxDetectorTSICompliant"></see></summary>
    let hotAxleBoxDetectorTSICompliant = _prefix "hotAxleBoxDetectorTSICompliant"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorTSICompliant"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorTSICompliant`` =
        _prefix "shapes/HotAxleBoxDetectorTSICompliant"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorTSICompliantCountryApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorTSICompliantCountryApplicability`` =
        _prefix "shapes/HotAxleBoxDetectorTSICompliantCountryApplicability"

    /// <summary>
    /// Unique RBC identification (NID_C+NID_RBC) and calling number (NID_RADIO) as defined in the specification referenced in Appendix A-1, index [C].
    /// <see href="http://data.europa.eu/949/idPhoneErtmsRadioBlockCenter"></see></summary>
    let idPhoneErtmsRadioBlockCenter = _prefix "idPhoneErtmsRadioBlockCenter"
    /// <summary>
    /// Infrastructure manager means any body or firm responsible in particular for establishing, managing and maintaining railway infrastructure, including traffic management and control-command signalling;
    /// the functions of the infrastructure manager on a network or part of a network may be allocated to different bodies or firms. Definition in (Article 3(2))
    /// <see href="http://data.europa.eu/949/imCode"></see></summary>
    let imCode = _prefix "imCode"
    /// <summary>
    /// Infrastructure manager means any body or undertaking that is responsible in particular for establishing and maintaining railway infrastructure or a part thereof.
    /// Four alpha-numeric code allocated by ERA to a body. It represents the Infrastructure Manager (IM) code in RINF.
    /// Infrastructure manager means any body or firm responsible in particular for establishing, managing and maintaining railway infrastructure, including traffic management and control-command signalling;
    /// the functions of the infrastructure manager on a network or part of a network may be allocated to different bodies or firms. Definition in (Article 3(2))
    /// <see href="http://data.europa.eu/949/organisationCode"></see></summary>
    let organisationCode = _prefix "organisationCode"
    /// <summary>
    /// Indicates the country in which an entity resides.
    /// <see href="http://data.europa.eu/949/inCountry"></see></summary>
    let inCountry = _prefix "inCountry"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InCountry"></see>
    /// </summary>
    let ``shapes/InCountry`` = _prefix "shapes/InCountry"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InCountrySKOS"></see>
    /// </summary>
    let ``shapes/InCountrySKOS`` = _prefix "shapes/InCountrySKOS"
    /// <summary>
    /// Reference to NUTS-3 place or city
    /// <see href="http://data.europa.eu/949/inNUTS3"></see></summary>
    let inNUTS3 = _prefix "inNUTS3"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InNUTS3"></see>
    /// </summary>
    let ``shapes/InNUTS3`` = _prefix "shapes/InNUTS3"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InNUTS3SKOS"></see>
    /// </summary>
    let ``shapes/InNUTS3SKOS`` = _prefix "shapes/InNUTS3SKOS"
    /// <summary>
    /// List of linear references included in an network area reference.
    /// <see href="http://data.europa.eu/949/includes"></see></summary>
    let includes = _prefix "includes"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Includes"></see>
    /// </summary>
    let ``shapes/Includes`` = _prefix "shapes/Includes"
    /// <summary>
    /// Relates a subset with common characteristics with its IM, represented by an instance of organisation role that points to the "infrastructure manager" concept in the taxonomy.
    /// <see href="http://data.europa.eu/949/infrastructureManager"></see></summary>
    let infrastructureManager = _prefix "infrastructureManager"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InfrastructureManagerSKOSValue"></see>
    /// </summary>
    let ``shapes/InfrastructureManagerSKOSValue`` =
        _prefix "shapes/InfrastructureManagerSKOSValue"

    /// <summary>
    /// (deprecated) not in use. Relates any feature implemented in the European railway infrastructure with its infrastructure manager.
    /// <see href="http://data.europa.eu/949/infrastructureMgr"></see></summary>
    let infrastructureMgr = _prefix "infrastructureMgr"
    /// <summary>
    /// Name and/or reference of the document specifying the Special instructions to switch over between different radio systems.
    /// <see href="http://data.europa.eu/949/instructionsSwitchRadioSystems"></see></summary>
    let instructionsSwitchRadioSystems = _prefix "instructionsSwitchRadioSystems"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InstructionsSwitchRadioSystemsApplicability"></see>
    /// </summary>
    let ``shapes/InstructionsSwitchRadioSystemsApplicability`` =
        _prefix "shapes/InstructionsSwitchRadioSystemsApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InstructionsSwitchRadioSystems"></see>
    /// </summary>
    let ``shapes/InstructionsSwitchRadioSystems`` =
        _prefix "shapes/InstructionsSwitchRadioSystems"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/IsOnOriginOfElementA"></see>
    /// </summary>
    let ``shapes/IsOnOriginOfElementA`` = _prefix "shapes/IsOnOriginOfElementA"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/IsOnOriginOfElementB"></see>
    /// </summary>
    let ``shapes/IsOnOriginOfElementB`` = _prefix "shapes/IsOnOriginOfElementB"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/IsPartOf"></see>
    /// </summary>
    let ``shapes/IsPartOf`` = _prefix "shapes/IsPartOf"
    /// <summary>
    /// Belonging to a 'quieter route' in accordance with Article 5b of TSI NOI.
    /// <see href="http://data.europa.eu/949/isQuietRoute"></see></summary>
    let isQuietRoute = _prefix "isQuietRoute"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/IsQuietRoute"></see>
    /// </summary>
    let ``shapes/IsQuietRoute`` = _prefix "shapes/IsQuietRoute"
    /// <summary>
    /// Kilometer number of the kilometric post related to line identification defining the location of an infrastructure element.
    /// <see href="http://data.europa.eu/949/kilometer"></see></summary>
    let kilometer = _prefix "kilometer"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Kilometer"></see>
    /// </summary>
    let ``shapes/Kilometer`` = _prefix "shapes/Kilometer"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/signalDataParameter"></see>
    /// </summary>
    let signalDataParameter = _prefix "signalDataParameter"
    /// <summary>
    /// The closest kilometric post on the line, used as a reference by the LRS coordinate.
    /// <see href="http://data.europa.eu/949/kmPost"></see></summary>
    let kmPost = _prefix "kmPost"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/KmPost"></see>
    /// </summary>
    let ``shapes/KmPost`` = _prefix "shapes/KmPost"
    /// <summary>
    /// Name of the kilometric post (optional).
    /// <see href="http://data.europa.eu/949/kmPostName"></see></summary>
    let kmPostName = _prefix "kmPostName"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/KmPostName"></see>
    /// </summary>
    let ``shapes/KmPostName`` = _prefix "shapes/KmPostName"
    /// <summary>
    /// Indication of radio legacy systems installed.
    /// <see href="http://data.europa.eu/949/legacyRadioSystem"></see></summary>
    let legacyRadioSystem = _prefix "legacyRadioSystem"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/legacy-radio-systems/LegacyRadioSystems"></see>
    /// </summary>
    let ``concepts/legacy-radio-systems/LegacyRadioSystems`` =
        _prefix "concepts/legacy-radio-systems/LegacyRadioSystems"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LegacyRadioSystem"></see>
    /// </summary>
    let ``shapes/LegacyRadioSystem`` = _prefix "shapes/LegacyRadioSystem"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LegacyRadioSystemSKOS"></see>
    /// </summary>
    let ``shapes/LegacyRadioSystemSKOS`` = _prefix "shapes/LegacyRadioSystemSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/otherRadioSystemsObjParameter"></see>
    /// </summary>
    let otherRadioSystemsObjParameter = _prefix "otherRadioSystemsObjParameter"
    /// <summary>
    /// Generic super-property for different types of length
    /// <see href="http://data.europa.eu/949/length"></see></summary>
    let length = _prefix "length"
    /// <summary>
    /// Length of a topological linear element.
    /// <see href="http://data.europa.eu/949/lengthOfNetLinearElement"></see></summary>
    let lengthOfNetLinearElement = _prefix "lengthOfNetLinearElement"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LengthOfNetLinearElement"></see>
    /// </summary>
    let ``shapes/LengthOfNetLinearElement`` = _prefix "shapes/LengthOfNetLinearElement"
    /// <summary>
    /// The maximum continuous length (expressed in metres) of that part of platform in front of which a train is intended to remain stationary in normal operating conditions for passengers to board and alight from the train, making appropriate allowance for stopping tolerances.
    /// <see href="http://data.europa.eu/949/lengthOfPlatform"></see></summary>
    let lengthOfPlatform = _prefix "lengthOfPlatform"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LengthP"></see>
    /// </summary>
    let ``shapes/LengthP`` = _prefix "shapes/LengthP"
    /// <summary>
    /// Length between operational points at start and end of section of line.
    /// <see href="http://data.europa.eu/949/lengthOfSectionOfLine"></see></summary>
    let lengthOfSectionOfLine = _prefix "lengthOfSectionOfLine"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SolLength"></see>
    /// </summary>
    let ``shapes/SolLength`` = _prefix "shapes/SolLength"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/solGenericDataParameter"></see>
    /// </summary>
    let solGenericDataParameter = _prefix "solGenericDataParameter"
    /// <summary>
    /// Total length of the siding/stabling track expressed in metres where trains can be parked safely.
    /// <see href="http://data.europa.eu/949/lengthOfSiding"></see></summary>
    let lengthOfSiding = _prefix "lengthOfSiding"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LengthS"></see>
    /// </summary>
    let ``shapes/LengthS`` = _prefix "shapes/LengthS"
    /// <summary>
    /// Length of a tunnel in metres from entrance portal to exit portal.
    /// <see href="http://data.europa.eu/949/lengthOfTunnel"></see></summary>
    let lengthOfTunnel = _prefix "lengthOfTunnel"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LengthOfTunnel"></see>
    /// </summary>
    let ``shapes/LengthOfTunnel`` = _prefix "shapes/LengthOfTunnel"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/lengthOfVehicle"></see>
    /// </summary>
    let lengthOfVehicle = _prefix "lengthOfVehicle"
    /// <summary>
    /// letter marking
    /// <see href="http://data.europa.eu/949/letterMarking"></see></summary>
    let letterMarking = _prefix "letterMarking"
    /// <summary>
    /// Classification of a line according to the TSI INF
    /// <see href="http://data.europa.eu/949/lineCategory"></see></summary>
    let lineCategory = _prefix "lineCategory"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/line-category/LineCategories"></see>
    /// </summary>
    let ``concepts/line-category/LineCategories`` =
        _prefix "concepts/line-category/LineCategories"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LineCategory"></see>
    /// </summary>
    let ``shapes/LineCategory`` = _prefix "shapes/LineCategory"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LineCategorySKOS"></see>
    /// </summary>
    let ``shapes/LineCategorySKOS`` = _prefix "shapes/LineCategorySKOS"
    /// <summary>
    /// Unique line identification or unique line number within Member State.
    /// <see href="http://data.europa.eu/949/lineId"></see></summary>
    let lineId = _prefix "lineId"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LineId"></see>
    /// </summary>
    let ``shapes/LineId`` = _prefix "shapes/LineId"
    /// <summary>
    /// Unique line identification or unique line number within Member State.
    /// <see href="http://data.europa.eu/949/lineNationalId"></see></summary>
    let lineNationalId = _prefix "lineNationalId"
    /// <summary>
    /// Indicates a relationship with a national railway line at a specific kilometer point.
    /// <see href="http://data.europa.eu/949/lineReference"></see></summary>
    let lineReference = _prefix "lineReference"
    /// <summary>
    /// Part of the End of tunnel that indicates the km of the line at the end of a tunnel.
    ///
    /// The End of tunnel is the Geographical coordinates in decimal degrees and km of the line at the end of a tunnel.
    /// <see href="http://data.europa.eu/949/lineReferenceTunnelEnd"></see></summary>
    let lineReferenceTunnelEnd = _prefix "lineReferenceTunnelEnd"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LineReferenceTunnelEnd"></see>
    /// </summary>
    let ``shapes/LineReferenceTunnelEnd`` = _prefix "shapes/LineReferenceTunnelEnd"
    /// <summary>
    /// Part of the End of tunnel that indicates the km of the line at the end of a tunnel.
    /// The End of tunnel is the Geographical coordinates in decimal degrees and km of the line at the end of a tunnel. The reason for deprecation is that the property is now a subproperty of lineReference in order to represent the kilometer in relation to a national railway line
    /// <see href="http://data.europa.eu/949/tunnelKilometerEnd"></see></summary>
    let tunnelKilometerEnd = _prefix "tunnelKilometerEnd"
    /// <summary>
    /// Part of the Start of tunnel that indicates the km of the line at the beginning of a tunnel.
    ///
    /// The Start of tunnel is the Geographical coordinates in decimal degrees and km of the line at the beginning of a tunnel.
    /// <see href="http://data.europa.eu/949/lineReferenceTunnelStart"></see></summary>
    let lineReferenceTunnelStart = _prefix "lineReferenceTunnelStart"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LineReferenceTunnelStart"></see>
    /// </summary>
    let ``shapes/LineReferenceTunnelStart`` = _prefix "shapes/LineReferenceTunnelStart"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/tunnelKilometerStart"></see>
    /// </summary>
    let tunnelKilometerStart = _prefix "tunnelKilometerStart"
    /// <summary>
    /// Indicates the position of an object within a linear positioning system. For example, relative to a national railway line
    /// <see href="http://data.europa.eu/949/linearCoordinate"></see></summary>
    let linearCoordinate = _prefix "linearCoordinate"
    /// <summary>
    /// Indication of types of appearance of track lineside distance indications.
    /// <see href="http://data.europa.eu/949/linesideDistanceIndication"></see></summary>
    let linesideDistanceIndication = _prefix "linesideDistanceIndication"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationCCS"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationCCS`` =
        _prefix "shapes/LinesideDistanceIndicationCCS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationRT"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationRT`` =
        _prefix "shapes/LinesideDistanceIndicationRT"

    /// <summary>
    /// Indication of types of appearance of track lineside distance indications.
    /// <see href="http://data.europa.eu/949/linesideDistanceIndicationAppearance"></see></summary>
    let linesideDistanceIndicationAppearance =
        _prefix "linesideDistanceIndicationAppearance"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/lineside-distance-indication-appearance/LinesideDistanceIndicationAppearance"></see>
    /// </summary>
    let ``concepts/lineside-distance-indication-appearance/LinesideDistanceIndicationAppearance`` =
        _prefix "concepts/lineside-distance-indication-appearance/LinesideDistanceIndicationAppearance"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationAppearanceSKOS"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationAppearanceSKOS`` =
        _prefix "shapes/LinesideDistanceIndicationAppearanceSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationAppearance"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationAppearance`` =
        _prefix "shapes/LinesideDistanceIndicationAppearance"

    /// <summary>
    /// Frequency of track lineside distance indications.
    /// <see href="http://data.europa.eu/949/linesideDistanceIndicationFrequency"></see></summary>
    let linesideDistanceIndicationFrequency =
        _prefix "linesideDistanceIndicationFrequency"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationFrequency"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationFrequency`` =
        _prefix "shapes/LinesideDistanceIndicationFrequency"

    /// <summary>
    /// Indication of the side along the track where the lineside indication is positioned (left or right, or both sides).
    /// <see href="http://data.europa.eu/949/linesideDistanceIndicationPositioning"></see></summary>
    let linesideDistanceIndicationPositioning =
        _prefix "linesideDistanceIndicationPositioning"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/lineside-distance-indication-positioning/LinesideDistanceIndicationPositioning"></see>
    /// </summary>
    let ``concepts/lineside-distance-indication-positioning/LinesideDistanceIndicationPositioning`` =
        _prefix "concepts/lineside-distance-indication-positioning/LinesideDistanceIndicationPositioning"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationPositioningSKOS"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationPositioningSKOS`` =
        _prefix "shapes/LinesideDistanceIndicationPositioningSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationPositioning"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationPositioning`` =
        _prefix "shapes/LinesideDistanceIndicationPositioning"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinkedToPrimaryLocation"></see>
    /// </summary>
    let ``shapes/LinkedToPrimaryLocation`` = _prefix "shapes/LinkedToPrimaryLocation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/load-capabilities/LoadCapabilities"></see>
    /// </summary>
    let ``concepts/load-capabilities/LoadCapabilities`` =
        _prefix "concepts/load-capabilities/LoadCapabilities"

    /// <summary>
    /// Relates the track with the class LoadCapability. A combination of the line category and speed at the weakest point of the track.
    /// <see href="http://data.europa.eu/949/trackLoadCapability"></see></summary>
    let trackLoadCapability = _prefix "trackLoadCapability"
    /// <summary>
    /// Part of the load capability of a track that corresponds to the line category of the load model.
    /// The load capability is a value selected from the list of load models representing the line category which is amended by value of speed [km/h] permitted for a specific load model. The list of values may also be Route Availability which is amended by value of speed [miles/h] permitted for a specific load model.
    /// <see href="http://data.europa.eu/949/loadCapabilityLineCategory"></see></summary>
    let loadCapabilityLineCategory = _prefix "loadCapabilityLineCategory"
    /// <summary>
    /// Part of the load capability of a track that corresponds to the speed of the load model
    /// <see href="http://data.europa.eu/949/loadCapabilitySpeed"></see></summary>
    let loadCapabilitySpeed = _prefix "loadCapabilitySpeed"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/load-capability-line-categories/LoadCapabilityLineCategories"></see>
    /// </summary>
    let ``concepts/load-capability-line-categories/LoadCapabilityLineCategories`` =
        _prefix "concepts/load-capability-line-categories/LoadCapabilityLineCategories"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LoadCapabilityLineCategory"></see>
    /// </summary>
    let ``shapes/LoadCapabilityLineCategory`` =
        _prefix "shapes/LoadCapabilityLineCategory"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LoadCapabilityLineCategorySKOS"></see>
    /// </summary>
    let ``shapes/LoadCapabilityLineCategorySKOS`` =
        _prefix "shapes/LoadCapabilityLineCategorySKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LoadCapabilitySpeed"></see>
    /// </summary>
    let ``shapes/LoadCapabilitySpeed`` = _prefix "shapes/LoadCapabilitySpeed"
    /// <summary>
    /// Maximum physical dimensions (height and width) to which an open rail wagon can be loaded
    /// <see href="http://data.europa.eu/949/loadingGauge"></see></summary>
    let loadingGauge = _prefix "loadingGauge"
    /// <summary>
    /// Height of loading platform (for flat wagons and combined transport), given in mm.
    /// <see href="http://data.europa.eu/949/loadingPlatformHeight"></see></summary>
    let loadingPlatformHeight = _prefix "loadingPlatformHeight"
    /// <summary>
    /// Existence of rules and restrictions of a strictly local nature
    /// <see href="http://data.europa.eu/949/localRulesOrRestrictions"></see></summary>
    let localRulesOrRestrictions = _prefix "localRulesOrRestrictions"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LocalRulesOrRestrictions"></see>
    /// </summary>
    let ``shapes/LocalRulesOrRestrictions`` = _prefix "shapes/LocalRulesOrRestrictions"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/rulesDataParameter"></see>
    /// </summary>
    let rulesDataParameter = _prefix "rulesDataParameter"
    /// <summary>
    /// Electronic document available from the IM stored by the Agency providing additional information.
    /// <see href="http://data.europa.eu/949/localRulesOrRestrictionsDoc"></see></summary>
    let localRulesOrRestrictionsDoc = _prefix "localRulesOrRestrictionsDoc"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LocalRulesOrRestrictionsDoc"></see>
    /// </summary>
    let ``shapes/LocalRulesOrRestrictionsDoc`` =
        _prefix "shapes/LocalRulesOrRestrictionsDoc"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LocalRulesOrRestrictionsDocApplicability"></see>
    /// </summary>
    let ``shapes/LocalRulesOrRestrictionsDocApplicability`` =
        _prefix "shapes/LocalRulesOrRestrictionsDocApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/rulesObjParameter"></see>
    /// </summary>
    let rulesObjParameter = _prefix "rulesObjParameter"
    /// <summary>
    /// The preferred line referencing system.
    /// <see href="http://data.europa.eu/949/lrsMethod"></see></summary>
    let lrsMethod = _prefix "lrsMethod"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/lines/ReferenceSystems"></see>
    /// </summary>
    let ``concepts/lines/ReferenceSystems`` = _prefix "concepts/lines/ReferenceSystems"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LrsMethod"></see>
    /// </summary>
    let ``shapes/LrsMethod`` = _prefix "shapes/LrsMethod"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LrsMethodSKOS"></see>
    /// </summary>
    let ``shapes/LrsMethodSKOS`` = _prefix "shapes/LrsMethodSKOS"
    /// <summary>
    /// On-Board system reaction when T_NVCONTACT expires
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/mNvcontact"></see></summary>
    let mNvcontact = _prefix "mNvcontact"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-reactions-contact/ETCSReactionsNVContact"></see>
    /// </summary>
    let ``concepts/etcs-reactions-contact/ETCSReactionsNVContact`` =
        _prefix "concepts/etcs-reactions-contact/ETCSReactionsNVContact"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MNvcontact"></see>
    /// </summary>
    let ``shapes/MNvcontact`` = _prefix "shapes/MNvcontact"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MNvcontactApplicability"></see>
    /// </summary>
    let ``shapes/MNvcontactApplicability`` = _prefix "shapes/MNvcontactApplicability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MNvcontactSKOS"></see>
    /// </summary>
    let ``shapes/MNvcontactSKOS`` = _prefix "shapes/MNvcontactSKOS"
    /// <summary>
    /// Entry of Driver ID permitted while running According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/mNvderun"></see></summary>
    let mNvderun = _prefix "mNvderun"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MNvderun"></see>
    /// </summary>
    let ``shapes/MNvderun`` = _prefix "shapes/MNvderun"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MNvderunApplicability"></see>
    /// </summary>
    let ``shapes/MNvderunApplicability`` = _prefix "shapes/MNvderunApplicability"
    /// <summary>
    /// Possibility of preventing the use of the magnetic track brake (only if fitted with magnetic brake)
    /// <see href="http://data.europa.eu/949/magneticBrakePrevention"></see></summary>
    let magneticBrakePrevention = _prefix "magneticBrakePrevention"
    /// <summary>
    /// Indication of limitations on the use of magnetic brakes.
    /// <see href="http://data.europa.eu/949/magneticBraking"></see></summary>
    let magneticBraking = _prefix "magneticBraking"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/magnetic-braking/MagneticBraking"></see>
    /// </summary>
    let ``concepts/magnetic-braking/MagneticBraking`` =
        _prefix "concepts/magnetic-braking/MagneticBraking"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MagneticBrakingSKOS"></see>
    /// </summary>
    let ``shapes/MagneticBrakingSKOS`` = _prefix "shapes/MagneticBrakingSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MagneticBraking"></see>
    /// </summary>
    let ``shapes/MagneticBraking`` = _prefix "shapes/MagneticBraking"
    /// <summary>
    /// Electronic document available in two EU languages from the IM stored by the Agency with conditions for the use of magnetic brakes identified in 1.1.1.1.6.3.
    /// <see href="http://data.europa.eu/949/magneticBrakingConditionsDocument"></see></summary>
    let magneticBrakingConditionsDocument = _prefix "magneticBrakingConditionsDocument"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MagneticBrakingConditionsDocument"></see>
    /// </summary>
    let ``shapes/MagneticBrakingConditionsDocument`` =
        _prefix "shapes/MagneticBrakingConditionsDocument"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MagneticBrakingConditionsDocumentApplicability"></see>
    /// </summary>
    let ``shapes/MagneticBrakingConditionsDocumentApplicability`` =
        _prefix "shapes/MagneticBrakingConditionsDocumentApplicability"

    /// <summary>
    /// Magnetic track brake fitted. New property defined to distinguish it from magneticBraking which is a RINF SKOS property.
    /// <see href="http://data.europa.eu/949/magneticBrakingFitted"></see></summary>
    let magneticBrakingFitted = _prefix "magneticBrakingFitted"
    /// <summary>
    /// Indicates the country in which a vehicle or vehicle type is manufactured.
    /// <see href="http://data.europa.eu/949/manufacturingCountry"></see></summary>
    let manufacturingCountry = _prefix "manufacturingCountry"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/vehicleTechnicalObjCharacteristic"></see>
    /// </summary>
    let vehicleTechnicalObjCharacteristic = _prefix "vehicleTechnicalObjCharacteristic"
    /// <summary>
    /// Mass per wheel, given in kg.
    /// <see href="http://data.europa.eu/949/massPerWheel"></see></summary>
    let massPerWheel = _prefix "massPerWheel"
    /// <summary>
    /// Maximum permitted axle load, given in tons.
    /// <see href="http://data.europa.eu/949/maxAxleLoadOfSoL"></see></summary>
    let maxAxleLoadOfSoL = _prefix "maxAxleLoadOfSoL"
    /// <summary>
    /// Indication of the maximum allowable train current at standstill expressed in amperes.
    /// <see href="http://data.europa.eu/949/maxCurrentStandstillPantograph"></see></summary>
    let maxCurrentStandstillPantograph = _prefix "maxCurrentStandstillPantograph"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaxCurrentStandstillPantograph"></see>
    /// </summary>
    let ``shapes/MaxCurrentStandstillPantograph`` =
        _prefix "shapes/MaxCurrentStandstillPantograph"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaxCurrentStandstillPantographS"></see>
    /// </summary>
    let ``shapes/MaxCurrentStandstillPantographS`` =
        _prefix "shapes/MaxCurrentStandstillPantographS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaxCurrentStandstillPantographApplicability"></see>
    /// </summary>
    let ``shapes/MaxCurrentStandstillPantographApplicability`` =
        _prefix "shapes/MaxCurrentStandstillPantographApplicability"

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter. Indication of maximum permitted distance between two consecutive axles in case of TSI non-compliance, given in millimetres.
    /// <see href="http://data.europa.eu/949/maxDistConsecutiveAxles"></see></summary>
    let maxDistConsecutiveAxles = _prefix "maxDistConsecutiveAxles"
    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication of maximum distance between end of train and first axle, given in millimetres, applicable for both sides (front and rear) of a vehicle or train.
    /// <see href="http://data.europa.eu/949/maxDistEndTrainFirstAxle"></see></summary>
    let maxDistEndTrainFirstAxle = _prefix "maxDistEndTrainFirstAxle"
    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter. Maximum permitted flange height, given in millimetres.
    /// <see href="http://data.europa.eu/949/maxFlangeHeight"></see></summary>
    let maxFlangeHeight = _prefix "maxFlangeHeight"
    /// <summary>
    /// The value of maximum permitted impedance given in ohm in case of TSI non-compliance. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/maxImpedanceWheelset"></see></summary>
    let maxImpedanceWheelset = _prefix "maxImpedanceWheelset"
    /// <summary>
    /// Maximum length of the vehicle nose.
    /// <see href="http://data.europa.eu/949/maxLengthVehicleNose"></see></summary>
    let maxLengthVehicleNose = _prefix "maxLengthVehicleNose"
    /// <summary>
    /// Maximum train length in meters allowed on a section of line, without special permission, for the operation of freight trains.
    ///                             In accordance with Regulation (EU) 2024/1679, Article 15(2)(c), this maximum length must be supported by the infrastructure manager's ability
    ///                             to allocate sufficient train paths for freight trains of at least 740 meters (including the locomotive or locomotives), as required for the TEN-T network.
    /// <see href="http://data.europa.eu/949/maxPermittedTrainLength"></see></summary>
    let maxPermittedTrainLength = _prefix "maxPermittedTrainLength"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaxPermittedTrainLength"></see>
    /// </summary>
    let ``shapes/MaxPermittedTrainLength`` = _prefix "shapes/MaxPermittedTrainLength"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaxPermittedTrainLengthApplicability"></see>
    /// </summary>
    let ``shapes/MaxPermittedTrainLengthApplicability`` =
        _prefix "shapes/MaxPermittedTrainLengthApplicability"

    /// <summary>
    /// Maximum amount of sand accepted on the track within value of sanding output for 30s, given in grams.
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/maxSandingOutput"></see></summary>
    let maxSandingOutput = _prefix "maxSandingOutput"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/max-amount-sandings/MaxAmountSandings"></see>
    /// </summary>
    let ``concepts/max-amount-sandings/MaxAmountSandings`` =
        _prefix "concepts/max-amount-sandings/MaxAmountSandings"

    /// <summary>
    /// Indication of the maximum allowable train current expressed in amperes.
    /// <see href="http://data.europa.eu/949/maxTrainCurrent"></see></summary>
    let maxTrainCurrent = _prefix "maxTrainCurrent"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumTrainCurrent"></see>
    /// </summary>
    let ``shapes/MaximumTrainCurrent`` = _prefix "shapes/MaximumTrainCurrent"
    /// <summary>
    /// Indicate the speed limit in a tunnel
    /// <see href="http://data.europa.eu/949/maxTunnelSpeed"></see></summary>
    let maxTunnelSpeed = _prefix "maxTunnelSpeed"
    /// <summary>
    /// Indicates the maximun wind speed for which the bridge can operate
    /// <see href="http://data.europa.eu/949/maxbridgeWind"></see></summary>
    let maxbridgeWind = _prefix "maxbridgeWind"
    /// <summary>
    /// Highest point of the section of line above sea level in reference to Normal Amsterdam's Peil (NAP).
    /// <see href="http://data.europa.eu/949/maximumAltitude"></see></summary>
    let maximumAltitude = _prefix "maximumAltitude"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumAltitude"></see>
    /// </summary>
    let ``shapes/MaximumAltitude`` = _prefix "shapes/MaximumAltitude"
    /// <summary>
    /// Maximum train deceleration given in m/s².
    /// <see href="http://data.europa.eu/949/maximumAverageDeceleration"></see></summary>
    let maximumAverageDeceleration = _prefix "maximumAverageDeceleration"
    /// <summary>
    /// Maximum brake thermal energy capacity given in kJ
    /// <see href="http://data.europa.eu/949/maximumBrakeThermalEnergyCapacity"></see></summary>
    let maximumBrakeThermalEnergyCapacity = _prefix "maximumBrakeThermalEnergyCapacity"
    /// <summary>
    /// The maximum value of the braking distance [in metres] of a train shall be given for the maximum line speed.
    /// <see href="http://data.europa.eu/949/maximumBrakingDistance"></see></summary>
    let maximumBrakingDistance = _prefix "maximumBrakingDistance"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumBrakingDistance"></see>
    /// </summary>
    let ``shapes/MaximumBrakingDistance`` = _prefix "shapes/MaximumBrakingDistance"
    /// <summary>
    /// Indication of the maximum contact wire height expressed in metres.
    /// <see href="http://data.europa.eu/949/maximumContactWireHeight"></see></summary>
    let maximumContactWireHeight = _prefix "maximumContactWireHeight"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumContactWireHeightApplicability"></see>
    /// </summary>
    let ``shapes/MaximumContactWireHeightApplicability`` =
        _prefix "shapes/MaximumContactWireHeightApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumContactWireHeight"></see>
    /// </summary>
    let ``shapes/MaximumContactWireHeight`` = _prefix "shapes/MaximumContactWireHeight"
    /// <summary>
    /// Maximum design speed.
    /// <see href="http://data.europa.eu/949/maximumDesignSpeed"></see></summary>
    let maximumDesignSpeed = _prefix "maximumDesignSpeed"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumInterferenceCurrent"></see>
    /// </summary>
    let ``shapes/MaximumInterferenceCurrent`` =
        _prefix "shapes/MaximumInterferenceCurrent"

    /// <summary>
    /// Maximum interference current limits allowed for track circuits for a defined frequency band.
    /// <see href="http://data.europa.eu/949/maximumInterferenceCurrentEvaluation"></see></summary>
    let maximumInterferenceCurrentEvaluation =
        _prefix "maximumInterferenceCurrentEvaluation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumInterferenceCurrentEvaluation"></see>
    /// </summary>
    let ``shapes/MaximumInterferenceCurrentEvaluation`` =
        _prefix "shapes/MaximumInterferenceCurrentEvaluation"

    /// <summary>
    /// Maximum number of trainsets or locomotives coupled together in multiple operation.
    /// <see href="http://data.europa.eu/949/maximumLocomotivesCoupled"></see></summary>
    let maximumLocomotivesCoupled = _prefix "maximumLocomotivesCoupled"
    /// <summary>
    /// The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band. Direction X.
    /// <see href="http://data.europa.eu/949/maximumMagneticFieldDirectionX"></see></summary>
    let maximumMagneticFieldDirectionX = _prefix "maximumMagneticFieldDirectionX"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumMagneticFieldDirectionX"></see>
    /// </summary>
    let ``shapes/MaximumMagneticFieldDirectionX`` =
        _prefix "shapes/MaximumMagneticFieldDirectionX"

    /// <summary>
    /// The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band. Direction Y.
    /// <see href="http://data.europa.eu/949/maximumMagneticFieldDirectionY"></see></summary>
    let maximumMagneticFieldDirectionY = _prefix "maximumMagneticFieldDirectionY"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumMagneticFieldDirectionY"></see>
    /// </summary>
    let ``shapes/MaximumMagneticFieldDirectionY`` =
        _prefix "shapes/MaximumMagneticFieldDirectionY"

    /// <summary>
    /// The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band. Direction Z.
    /// <see href="http://data.europa.eu/949/maximumMagneticFieldDirectionZ"></see></summary>
    let maximumMagneticFieldDirectionZ = _prefix "maximumMagneticFieldDirectionZ"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumMagneticFieldDirectionZ"></see>
    /// </summary>
    let ``shapes/MaximumMagneticFieldDirectionZ`` =
        _prefix "shapes/MaximumMagneticFieldDirectionZ"

    /// <summary>
    /// Maximum permitted meter load, given in tons
    /// <see href="http://data.europa.eu/949/maximumPermittedMeterLoad"></see></summary>
    let maximumPermittedMeterLoad = _prefix "maximumPermittedMeterLoad"
    /// <summary>
    /// Nominal maximum operational speed on the line as a result of infrastructure, energy and control, command signalling subsystem characteristics expressed in kilometres/hour.
    /// <see href="http://data.europa.eu/949/maximumPermittedSpeed"></see></summary>
    let maximumPermittedSpeed = _prefix "maximumPermittedSpeed"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumPermittedSpeed"></see>
    /// </summary>
    let ``shapes/MaximumPermittedSpeed`` = _prefix "shapes/MaximumPermittedSpeed"
    /// <summary>
    /// At maximum service brake: Stopping distance, Maximum deceleration, for the load condition 'design mass under normal payload' at the design maximum speed.
    /// <see href="http://data.europa.eu/949/maximumServiceBrake"></see></summary>
    let maximumServiceBrake = _prefix "maximumServiceBrake"
    /// <summary>
    /// Part of the combination of maximum speed and maximum cant deficiency for which the vehicle was assessed. Corresponds to the maximum cant deficiency.
    /// <see href="http://data.europa.eu/949/vehicleTypeMaximumCantDeficiency"></see></summary>
    let vehicleTypeMaximumCantDeficiency = _prefix "vehicleTypeMaximumCantDeficiency"

    /// <summary>
    /// Relates the vehicle type with its values of maximum speed and cant deficiency.
    /// <see href="http://data.europa.eu/949/vehicleTypeMaximumSpeedAndCantDeficiency"></see></summary>
    let vehicleTypeMaximumSpeedAndCantDeficiency =
        _prefix "vehicleTypeMaximumSpeedAndCantDeficiency"

    /// <summary>
    /// Part of the combination of maximum speed and maximum cant deficiency for which the vehicle was assessed. Corresponds to the maximum speed.
    /// <see href="http://data.europa.eu/949/vehicleTypeMaximumSpeed"></see></summary>
    let vehicleTypeMaximumSpeed = _prefix "vehicleTypeMaximumSpeed"
    /// <summary>
    /// Maximum speed when empty.
    /// <see href="http://data.europa.eu/949/maximumSpeedEmpty"></see></summary>
    let maximumSpeedEmpty = _prefix "maximumSpeedEmpty"
    /// <summary>
    /// Deprecated because both RINF and ERATV define a temperature range as a set of predefined values (see https://www.era.europa.eu/system/files/2023-04/iu-eratv_application_guide_for_register_2016-797_en_0.pdf). Maximum temperature allowed for unrestricted operation access, according to European standard.
    /// <see href="http://data.europa.eu/949/maximumTemperature"></see></summary>
    let maximumTemperature = _prefix "maximumTemperature"
    /// <summary>
    /// Temperature range for unrestricted access to the line.
    /// <see href="http://data.europa.eu/949/temperatureRange"></see></summary>
    let temperatureRange = _prefix "temperatureRange"
    /// <summary>
    /// Limit for longitudinal track resistance given as a maximum allowed train deceleration and expressed in metres per square second.
    /// <see href="http://data.europa.eu/949/maximumTrainDeceleration"></see></summary>
    let maximumTrainDeceleration = _prefix "maximumTrainDeceleration"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumTrainDeceleration"></see>
    /// </summary>
    let ``shapes/MaximumTrainDeceleration`` = _prefix "shapes/MaximumTrainDeceleration"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trackResistanceToAppliedLoadsDataParameter"></see>
    /// </summary>
    let trackResistanceToAppliedLoadsDataParameter =
        _prefix "trackResistanceToAppliedLoadsDataParameter"

    /// <summary>
    /// Maximum train length allowed on a line or section
    /// <see href="http://data.europa.eu/949/maximumTrainLength"></see></summary>
    let maximumTrainLength = _prefix "maximumTrainLength"
    /// <summary>
    /// Measured distance from the origin of the LRS.
    /// <see href="http://data.europa.eu/949/measuredDistance"></see></summary>
    let measuredDistance = _prefix "measuredDistance"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MeasuredDistance"></see>
    /// </summary>
    let ``shapes/MeasuredDistance`` = _prefix "shapes/MeasuredDistance"

    /// <summary>
    /// Type meets the requirements necessary for validity of the vehicle authorisation granted by one Member State in other MSs.
    /// <see href="http://data.europa.eu/949/meetsRequirementVehicleAuthorisation"></see></summary>
    let meetsRequirementVehicleAuthorisation =
        _prefix "meetsRequirementVehicleAuthorisation"

    /// <summary>
    /// Minimum permitted axle load, given in tons.
    /// <see href="http://data.europa.eu/949/minAxleLoad"></see></summary>
    let minAxleLoad = _prefix "minAxleLoad"
    /// <summary>
    /// Represents the category of vehicle which is amended by value of minimum permitted axle load [tons] (property minAxleLoad).
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/minAxleLoadVehicleCategory"></see></summary>
    let minAxleLoadVehicleCategory = _prefix "minAxleLoadVehicleCategory"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/min-axle-load-vehicle-categories/MinAxleLoadVehicleCategories"></see>
    /// </summary>
    let ``concepts/min-axle-load-vehicle-categories/MinAxleLoadVehicleCategories`` =
        _prefix "concepts/min-axle-load-vehicle-categories/MinAxleLoadVehicleCategories"

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.
    /// <see href="http://data.europa.eu/949/minDistConsecutiveAxles"></see></summary>
    let minDistConsecutiveAxles = _prefix "minDistConsecutiveAxles"
    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.
    /// <see href="http://data.europa.eu/949/minDistFirstLastAxle"></see></summary>
    let minDistFirstLastAxle = _prefix "minDistFirstLastAxle"
    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.
    /// <see href="http://data.europa.eu/949/minFlangeHeight"></see></summary>
    let minFlangeHeight = _prefix "minFlangeHeight"
    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.
    /// <see href="http://data.europa.eu/949/minFlangeThickness"></see></summary>
    let minFlangeThickness = _prefix "minFlangeThickness"
    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.
    /// <see href="http://data.europa.eu/949/minRimWidth"></see></summary>
    let minRimWidth = _prefix "minRimWidth"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/otherTrainDetectionSystemsDataParameter"></see>
    /// </summary>
    let otherTrainDetectionSystemsDataParameter =
        _prefix "otherTrainDetectionSystemsDataParameter"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleImpedance"></see>
    /// </summary>
    let ``shapes/MinVehicleImpedance`` = _prefix "shapes/MinVehicleImpedance"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleImpedanceApplicability"></see>
    /// </summary>
    let ``shapes/MinVehicleImpedanceApplicability`` =
        _prefix "shapes/MinVehicleImpedanceApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/minVehicleImpedanceVoltages"></see>
    /// </summary>
    let minVehicleImpedanceVoltages = _prefix "minVehicleImpedanceVoltages"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleImpedanceVoltagesSKOS"></see>
    /// </summary>
    let ``shapes/MinVehicleImpedanceVoltagesSKOS`` =
        _prefix "shapes/MinVehicleImpedanceVoltagesSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleImpedanceVoltagesApplicability"></see>
    /// </summary>
    let ``shapes/MinVehicleImpedanceVoltagesApplicability`` =
        _prefix "shapes/MinVehicleImpedanceVoltagesApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleImpedanceVoltages"></see>
    /// </summary>
    let ``shapes/MinVehicleImpedanceVoltages`` =
        _prefix "shapes/MinVehicleImpedanceVoltages"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/minVehicleInputCapacitance"></see>
    /// </summary>
    let minVehicleInputCapacitance = _prefix "minVehicleInputCapacitance"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleInputCapacitance"></see>
    /// </summary>
    let ``shapes/MinVehicleInputCapacitance`` =
        _prefix "shapes/MinVehicleInputCapacitance"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleInputCapacitanceApplicability"></see>
    /// </summary>
    let ``shapes/MinVehicleInputCapacitanceApplicability`` =
        _prefix "shapes/MinVehicleInputCapacitanceApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/minVehicleInputImpedance"></see>
    /// </summary>
    let minVehicleInputImpedance = _prefix "minVehicleInputImpedance"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleInputImpedance"></see>
    /// </summary>
    let ``shapes/MinVehicleInputImpedance`` = _prefix "shapes/MinVehicleInputImpedance"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleInputImpedanceApplicability"></see>
    /// </summary>
    let ``shapes/MinVehicleInputImpedanceApplicability`` =
        _prefix "shapes/MinVehicleInputImpedanceApplicability"

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.
    /// <see href="http://data.europa.eu/949/minWheelDiameter"></see></summary>
    let minWheelDiameter = _prefix "minWheelDiameter"
    /// <summary>
    /// Minimum vertical concave curve radius capability.
    /// <see href="http://data.europa.eu/949/minimumConcaveVerticalRadius"></see></summary>
    let minimumConcaveVerticalRadius = _prefix "minimumConcaveVerticalRadius"
    /// <summary>
    /// Indication of the minimum contact wire height expressed in metres.
    /// <see href="http://data.europa.eu/949/minimumContactWireHeight"></see></summary>
    let minimumContactWireHeight = _prefix "minimumContactWireHeight"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumContactWireHeightApplicability"></see>
    /// </summary>
    let ``shapes/MinimumContactWireHeightApplicability`` =
        _prefix "shapes/MinimumContactWireHeightApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumContactWireHeight"></see>
    /// </summary>
    let ``shapes/MinimumContactWireHeight`` = _prefix "shapes/MinimumContactWireHeight"
    /// <summary>
    /// Minimum vertical convex curve radius capability.
    /// <see href="http://data.europa.eu/949/minimumConvexVerticalRadius"></see></summary>
    let minimumConvexVerticalRadius = _prefix "minimumConvexVerticalRadius"
    /// <summary>
    /// Radius of the smallest horizontal curve, expressed in metres.
    /// <see href="http://data.europa.eu/949/minimumHorizontalRadius"></see></summary>
    let minimumHorizontalRadius = _prefix "minimumHorizontalRadius"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumHorizontalRadiusS"></see>
    /// </summary>
    let ``shapes/MinimumHorizontalRadiusS`` = _prefix "shapes/MinimumHorizontalRadiusS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumHorizontalRadius"></see>
    /// </summary>
    let ``shapes/MinimumHorizontalRadius`` = _prefix "shapes/MinimumHorizontalRadius"
    /// <summary>
    /// Deprecated because both RINF and ERATV define a temperature range as a set of predefined values (see https://www.era.europa.eu/system/files/2023-04/iu-eratv_application_guide_for_register_2016-797_en_0.pdf). Minimum temperature allowed for unrestricted operation access, according to European standard.
    /// <see href="http://data.europa.eu/949/minimumTemperature"></see></summary>
    let minimumTemperature = _prefix "minimumTemperature"
    /// <summary>
    /// Radius of the smallest vertical curve expressed in metres.
    /// <see href="http://data.europa.eu/949/minimumVerticalRadius"></see></summary>
    let minimumVerticalRadius = _prefix "minimumVerticalRadius"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumVerticalRadius"></see>
    /// </summary>
    let ``shapes/MinimumVerticalRadius`` = _prefix "shapes/MinimumVerticalRadius"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/sidingObjParameter"></see>
    /// </summary>
    let sidingObjParameter = _prefix "sidingObjParameter"
    /// <summary>
    /// Part of the minimum radius of vertical curve that indicates the crest
    /// <see href="http://data.europa.eu/949/minimumVerticalRadiusCrest"></see></summary>
    let minimumVerticalRadiusCrest = _prefix "minimumVerticalRadiusCrest"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumVerticalRadiusCrest"></see>
    /// </summary>
    let ``shapes/MinimumVerticalRadiusCrest`` =
        _prefix "shapes/MinimumVerticalRadiusCrest"

    /// <summary>
    /// Part of the minimum radius of vertical curve that indicates the hollow
    /// <see href="http://data.europa.eu/949/minimumVerticalRadiusHollow"></see></summary>
    let minimumVerticalRadiusHollow = _prefix "minimumVerticalRadiusHollow"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumVerticalRadiusHollow"></see>
    /// </summary>
    let ``shapes/MinimumVerticalRadiusHollow`` =
        _prefix "shapes/MinimumVerticalRadiusHollow"

    /// <summary>
    /// Maximum unguided length of fixed obtuse crossings is based on a minimum wheel diameter in service expressed in millimetres.
    /// <see href="http://data.europa.eu/949/minimumWheelDiameter"></see></summary>
    let minimumWheelDiameter = _prefix "minimumWheelDiameter"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumWheelDiameter"></see>
    /// </summary>
    let ``shapes/MinimumWheelDiameter`` = _prefix "shapes/MinimumWheelDiameter"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/switchesAndCrossingsDataParameter"></see>
    /// </summary>
    let switchesAndCrossingsDataParameter = _prefix "switchesAndCrossingsDataParameter"
    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication whether more than one train protection, control and warning system is required to be on-board and active simultaneously.
    /// <see href="http://data.europa.eu/949/multipleTrainProtectionRequired"></see></summary>
    let multipleTrainProtectionRequired = _prefix "multipleTrainProtectionRequired"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NationalLineSoL"></see>
    /// </summary>
    let ``shapes/NationalLineSoL`` = _prefix "shapes/NationalLineSoL"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/solGenericObjParameter"></see>
    /// </summary>
    let solGenericObjParameter = _prefix "solGenericObjParameter"
    /// <summary>
    /// National classification for load capability
    /// <see href="http://data.europa.eu/949/nationalLoadCapability"></see></summary>
    let nationalLoadCapability = _prefix "nationalLoadCapability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NationalLoadCapability"></see>
    /// </summary>
    let ``shapes/NationalLoadCapability`` = _prefix "shapes/NationalLoadCapability"
    /// <summary>
    /// Categorisation of how a passenger train with a fire on board will continue to operate for a defined time period - according to national rules if they exist.
    /// <see href="http://data.europa.eu/949/nationalRollingStockFireCategory"></see></summary>
    let nationalRollingStockFireCategory = _prefix "nationalRollingStockFireCategory"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NationalRollingStockFireCategoryApplicability"></see>
    /// </summary>
    let ``shapes/NationalRollingStockFireCategoryApplicability`` =
        _prefix "shapes/NationalRollingStockFireCategoryApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NationalRollingStockFireCategory"></see>
    /// </summary>
    let ``shapes/NationalRollingStockFireCategory`` =
        _prefix "shapes/NationalRollingStockFireCategory"

    /// <summary>
    /// Set of parameters for adapting the braking curves calculated by the ETCS on-board system to match accuracy, performance and safety margins imposed by the infrastructure manager.
    /// It copies the content of Packet 3 or of Packet 203 as defined in the specification referenced in Appendix A-1, index [C].
    /// <see href="http://data.europa.eu/949/nationalValuesBrakeModel"></see></summary>
    let nationalValuesBrakeModel = _prefix "nationalValuesBrakeModel"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NationalValuesBrakeModel"></see>
    /// </summary>
    let ``shapes/NationalValuesBrakeModel`` = _prefix "shapes/NationalValuesBrakeModel"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NationalValuesBrakeModelApplicability"></see>
    /// </summary>
    let ``shapes/NationalValuesBrakeModelApplicability`` =
        _prefix "shapes/NationalValuesBrakeModelApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/navigabilities/Navigabilities"></see>
    /// </summary>
    let ``concepts/navigabilities/Navigabilities`` =
        _prefix "concepts/navigabilities/Navigabilities"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Navigability"></see>
    /// </summary>
    let ``shapes/Navigability`` = _prefix "shapes/Navigability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NavigabilitySKOS"></see>
    /// </summary>
    let ``shapes/NavigabilitySKOS`` = _prefix "shapes/NavigabilitySKOS"
    /// <summary>
    /// References an associated topological object.
    /// The reason for deprecating this property is that it is defined as "References an associated topological object." and the vocabulary has already a property "hasAbstraction" which relates the implementation layer with the topological layer, https://citnet.tech.ec.europa.eu/CITnet/confluence/pages/viewpage.action?pageId=1122974879.
    /// <see href="http://data.europa.eu/949/netElement"></see></summary>
    let netElement = _prefix "netElement"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetReference"></see>
    /// </summary>
    let ``shapes/NetReference`` = _prefix "shapes/NetReference"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetReferenceOP"></see>
    /// </summary>
    let ``shapes/NetReferenceOP`` = _prefix "shapes/NetReferenceOP"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetReferenceSOL"></see>
    /// </summary>
    let ``shapes/NetReferenceSOL`` = _prefix "shapes/NetReferenceSOL"
    /// <summary>
    /// Denotes a non-coded restrictions for this particular vehicleType, as a set of sentences.
    /// <see href="http://data.europa.eu/949/nonCodedRestrictions"></see></summary>
    let nonCodedRestrictions = _prefix "nonCodedRestrictions"
    /// <summary>
    /// Reference to a property that is not applicable.
    /// <see href="http://data.europa.eu/949/notApplicable"></see></summary>
    let notApplicable = _prefix "notApplicable"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NotApplicable"></see>
    /// </summary>
    let ``shapes/NotApplicable`` = _prefix "shapes/NotApplicable"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NotApplicableShape"></see>
    /// </summary>
    let ``shapes/NotApplicableShape`` = _prefix "shapes/NotApplicableShape"
    /// <summary>
    /// Reference to a property that is not provided.
    /// <see href="http://data.europa.eu/949/notYetAvailable"></see></summary>
    let notYetAvailable = _prefix "notYetAvailable"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NotYetAvailable"></see>
    /// </summary>
    let ``shapes/NotYetAvailable`` = _prefix "shapes/NotYetAvailable"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NotYetAvailableShape"></see>
    /// </summary>
    let ``shapes/NotYetAvailableShape`` = _prefix "shapes/NotYetAvailableShape"
    /// <summary>
    /// Number of elements in the rake of freight wagons (only for subcategory 'rake of freight wagons')
    /// <see href="http://data.europa.eu/949/numberElementsRakeFreightWagons"></see></summary>
    let numberElementsRakeFreightWagons = _prefix "numberElementsRakeFreightWagons"

    /// <summary>
    /// Number of pantographs in contact with the overhead contact line (OCL) (to be indicated for each energy supply system the vehicle is equipped for).
    /// <see href="http://data.europa.eu/949/numberOfPantographsInContactWithOCL"></see></summary>
    let numberOfPantographsInContactWithOCL =
        _prefix "numberOfPantographsInContactWithOCL"

    /// <summary>
    /// Number of toilets.
    /// <see href="http://data.europa.eu/949/numberOfToilets"></see></summary>
    let numberOfToilets = _prefix "numberOfToilets"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/oclSeparationSectionsObjParameter"></see>
    /// </summary>
    let oclSeparationSectionsObjParameter = _prefix "oclSeparationSectionsObjParameter"
    /// <summary>
    /// OCL type.
    /// <see href="http://data.europa.eu/949/oclType"></see></summary>
    let oclType = _prefix "oclType"
    /// <summary>
    /// Indicates the parameter (object or datatype property) for which an applicability is being defined.
    /// <see href="http://data.europa.eu/949/ofParameter"></see></summary>
    let ofParameter = _prefix "ofParameter"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OfParameter"></see>
    /// </summary>
    let ``shapes/OfParameter`` = _prefix "shapes/OfParameter"
    /// <summary>
    /// Relative distance from a reference kilometric post
    /// <see href="http://data.europa.eu/949/offsetFromKilometricPost"></see></summary>
    let offsetFromKilometricPost = _prefix "offsetFromKilometricPost"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OffsetFromKilometricPost"></see>
    /// </summary>
    let ``shapes/OffsetFromKilometricPost`` = _prefix "shapes/OffsetFromKilometricPost"
    /// <summary>
    /// Offset from the origin in a topological coordinate.
    /// <see href="http://data.europa.eu/949/offsetFromOrigin"></see></summary>
    let offsetFromOrigin = _prefix "offsetFromOrigin"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OffsetFromOrigin"></see>
    /// </summary>
    let ``shapes/OffsetFromOrigin`` = _prefix "shapes/OffsetFromOrigin"
    /// <summary>
    /// Specifies the linear element a section belongs to.
    /// <see href="http://data.europa.eu/949/onElement"></see></summary>
    let onElement = _prefix "onElement"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OnElement"></see>
    /// </summary>
    let ``shapes/OnElement`` = _prefix "shapes/OnElement"
    /// <summary>
    /// Specifies the linear element a coordinate is associated with.
    /// <see href="http://data.europa.eu/949/onLinearElement"></see></summary>
    let onLinearElement = _prefix "onLinearElement"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OnLinearElement"></see>
    /// </summary>
    let ``shapes/OnLinearElement`` = _prefix "shapes/OnLinearElement"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpEndExists"></see>
    /// </summary>
    let ``shapes/OpEndExists`` = _prefix "shapes/OpEndExists"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpEnd"></see>
    /// </summary>
    let ``shapes/OpEnd`` = _prefix "shapes/OpEnd"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/opGenericObjParameter"></see>
    /// </summary>
    let opGenericObjParameter = _prefix "opGenericObjParameter"
    /// <summary>
    /// Name normally related to the town or village or to traffic control purpose.
    /// <see href="http://data.europa.eu/949/opName"></see></summary>
    let opName = _prefix "opName"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpName"></see>
    /// </summary>
    let ``shapes/OpName`` = _prefix "shapes/OpName"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpStart"></see>
    /// </summary>
    let ``shapes/OpStart`` = _prefix "shapes/OpStart"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpStartExists"></see>
    /// </summary>
    let ``shapes/OpStartExists`` = _prefix "shapes/OpStartExists"
    /// <summary>
    /// Type of facility in relation to the dominating operational functions.
    /// <see href="http://data.europa.eu/949/opType"></see></summary>
    let opType = _prefix "opType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/op-types/OperationalPointTypes"></see>
    /// </summary>
    let ``concepts/op-types/OperationalPointTypes`` =
        _prefix "concepts/op-types/OperationalPointTypes"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpTypeSKOS"></see>
    /// </summary>
    let ``shapes/OpTypeSKOS`` = _prefix "shapes/OpTypeSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpTypeP"></see>
    /// </summary>
    let ``shapes/OpTypeP`` = _prefix "shapes/OpTypeP"
    /// <summary>
    /// Type of track gauge changeover facility.
    /// <see href="http://data.europa.eu/949/opTypeGaugeChangeover"></see></summary>
    let opTypeGaugeChangeover = _prefix "opTypeGaugeChangeover"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpTypeGaugeChangeover"></see>
    /// </summary>
    let ``shapes/OpTypeGaugeChangeover`` = _prefix "shapes/OpTypeGaugeChangeover"
    /// <summary>
    /// The language or languages used in daily operation by infrastructure manager and published in its Network Statement, for the communication of operational or safety related messages between the staff of the infrastructure manager and the railway undertaking.
    /// <see href="http://data.europa.eu/949/operatingLanguage"></see></summary>
    let operatingLanguage = _prefix "operatingLanguage"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/routeBookObjectParameter"></see>
    /// </summary>
    let routeBookObjectParameter = _prefix "routeBookObjectParameter"
    /// <summary>
    /// Double track type.
    /// <see href="http://data.europa.eu/949/operationalRegimeType"></see></summary>
    let operationalRegimeType = _prefix "operationalRegimeType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/operational-regime-types/OperationalRegimeTypes"></see>
    /// </summary>
    let ``concepts/operational-regime-types/OperationalRegimeTypes`` =
        _prefix "concepts/operational-regime-types/OperationalRegimeTypes"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OperationalRegimeType"></see>
    /// </summary>
    let ``shapes/OperationalRegimeType`` = _prefix "shapes/OperationalRegimeType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OperationalRegimeTypeSKOS"></see>
    /// </summary>
    let ``shapes/OperationalRegimeTypeSKOS`` =
        _prefix "shapes/OperationalRegimeTypeSKOS"

    /// <summary>
    /// Indicates an operational restriction of vehicle or wagon. Parking brake type (if the vehicle is fitted with it).
    /// <see href="http://data.europa.eu/949/operationalRestriction"></see></summary>
    let operationalRestriction = _prefix "operationalRestriction"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/restrictions/Restrictions"></see>
    /// </summary>
    let ``concepts/restrictions/Restrictions`` =
        _prefix "concepts/restrictions/Restrictions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OrganisationCode"></see>
    /// </summary>
    let ``shapes/OrganisationCode`` = _prefix "shapes/OrganisationCode"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/trackGenericDataParameter"></see>
    /// </summary>
    let trackGenericDataParameter = _prefix "trackGenericDataParameter"
    /// <summary>
    /// (deprecated) not in use anymore
    /// <see href="http://data.europa.eu/949/osmClass"></see></summary>
    let osmClass = _prefix "osmClass"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/osm-classes/OSMClasses"></see>
    /// </summary>
    let ``concepts/osm-classes/OSMClasses`` = _prefix "concepts/osm-classes/OSMClasses"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherCantDeficiencyBasicSSP"></see>
    /// </summary>
    let ``shapes/OtherCantDeficiencyBasicSSP`` =
        _prefix "shapes/OtherCantDeficiencyBasicSSP"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherCantDeficiencyBasicSSPApplicability"></see>
    /// </summary>
    let ``shapes/OtherCantDeficiencyBasicSSPApplicability`` =
        _prefix "shapes/OtherCantDeficiencyBasicSSPApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherCantDeficiencyBasicSSPSKOS"></see>
    /// </summary>
    let ``shapes/OtherCantDeficiencyBasicSSPSKOS`` =
        _prefix "shapes/OtherCantDeficiencyBasicSSPSKOS"

    /// <summary>
    /// Indication of pantograph heads which are allowed to be used.
    /// <see href="http://data.europa.eu/949/otherPantographHead"></see></summary>
    let otherPantographHead = _prefix "otherPantographHead"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/other-pantograph-heads/OtherPantographHeads"></see>
    /// </summary>
    let ``concepts/other-pantograph-heads/OtherPantographHeads`` =
        _prefix "concepts/other-pantograph-heads/OtherPantographHeads"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherPantographHeadSKOS"></see>
    /// </summary>
    let ``shapes/OtherPantographHeadSKOS`` = _prefix "shapes/OtherPantographHeadSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherPantographHeadApplicability"></see>
    /// </summary>
    let ``shapes/OtherPantographHeadApplicability`` =
        _prefix "shapes/OtherPantographHeadApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/otherTrainDetectionSystemsObjParameter"></see>
    /// </summary>
    let otherTrainDetectionSystemsObjParameter =
        _prefix "otherTrainDetectionSystemsObjParameter"

    /// <summary>
    /// Indication of existence of other system than ETCS for degraded situation.
    /// <see href="http://data.europa.eu/949/otherTrainProtection"></see></summary>
    let otherTrainProtection = _prefix "otherTrainProtection"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/other-protection-control-warning/OtherProtectionControlWarnings"></see>
    /// </summary>
    let ``concepts/other-protection-control-warning/OtherProtectionControlWarnings`` =
        _prefix "concepts/other-protection-control-warning/OtherProtectionControlWarnings"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherTrainProtectionSKOS"></see>
    /// </summary>
    let ``shapes/OtherTrainProtectionSKOS`` = _prefix "shapes/OtherTrainProtectionSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherTrainProtectionApplicability"></see>
    /// </summary>
    let ``shapes/OtherTrainProtectionApplicability`` =
        _prefix "shapes/OtherTrainProtectionApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherTrainProtection"></see>
    /// </summary>
    let ``shapes/OtherTrainProtection`` = _prefix "shapes/OtherTrainProtection"
    /// <summary>
    /// Relates an infrastructure element or a common characteristics subset with the applicability of a certain parameter.
    /// <see href="http://data.europa.eu/949/parameterApplicability"></see></summary>
    let parameterApplicability = _prefix "parameterApplicability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ParameterApplicability"></see>
    /// </summary>
    let ``shapes/ParameterApplicability`` = _prefix "shapes/ParameterApplicability"
    /// <summary>
    /// This property is used to link an applicability to the precise value of the parameter
    /// <see href="http://data.europa.eu/949/parameterValue"></see></summary>
    let parameterValue = _prefix "parameterValue"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ParameterValue"></see>
    /// </summary>
    let ``shapes/ParameterValue`` = _prefix "shapes/ParameterValue"
    /// <summary>
    /// In the case of a change in the value of a parameter, there needs to be an information on the type of the new value. The “Value type” will have different possible options: “nominal”, “planned temporary restriction”, “permanent restriction”, “planned temporary closure”.
    /// <see href="http://data.europa.eu/949/parameterValueType"></see></summary>
    let parameterValueType = _prefix "parameterValueType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/parameterApplicability/ValueTypes"></see>
    /// </summary>
    let ``concepts/parameterApplicability/ValueTypes`` =
        _prefix "concepts/parameterApplicability/ValueTypes"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ParameterValueTypeSKOS"></see>
    /// </summary>
    let ``shapes/ParameterValueTypeSKOS`` = _prefix "shapes/ParameterValueTypeSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ParameterValueType"></see>
    /// </summary>
    let ``shapes/ParameterValueType`` = _prefix "shapes/ParameterValueType"
    /// <summary>
    /// Indicates whether all vehicles of this type must be equipped with a parking brake.
    /// <see href="http://data.europa.eu/949/parkingBrake"></see></summary>
    let parkingBrake = _prefix "parkingBrake"
    /// <summary>
    /// All vehicles of this type must be equipped with a parking brake (parking brake mandatory for vehicles of this type).
    /// <see href="http://data.europa.eu/949/parkingBrakeMandatory"></see></summary>
    let parkingBrakeMandatory = _prefix "parkingBrakeMandatory"
    /// <summary>
    /// Maximum gradient on which the unit is kept immobilised by the parking brake alone (if the vehicle is fitted with it).
    /// <see href="http://data.europa.eu/949/parkingBrakeMaximumGradient"></see></summary>
    let parkingBrakeMaximumGradient = _prefix "parkingBrakeMaximumGradient"
    /// <summary>
    /// Parking brake type (if the vehicle is fitted with it).
    /// <see href="http://data.europa.eu/949/parkingBrakeType"></see></summary>
    let parkingBrakeType = _prefix "parkingBrakeType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/brake-parking-type/BrakeParkingType"></see>
    /// </summary>
    let ``concepts/brake-parking-type/BrakeParkingType`` =
        _prefix "concepts/brake-parking-type/BrakeParkingType"

    /// <summary>
    /// Links an element to its TEN-T network classification, which includes network level, type of traffic, and European transport corridor information.
    /// <see href="http://data.europa.eu/949/partOfTENT"></see></summary>
    let partOfTENT = _prefix "partOfTENT"
    /// <summary>
    /// Pass-by noise level given in dB(A).
    /// <see href="http://data.europa.eu/949/passByNoiseLevel"></see></summary>
    let passByNoiseLevel = _prefix "passByNoiseLevel"
    /// <summary>
    /// Passenger possible flag attached to a Primary Location
    /// <see href="http://data.europa.eu/949/passengerFlag"></see></summary>
    let passengerFlag = _prefix "passengerFlag"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PassengerFlag"></see>
    /// </summary>
    let ``shapes/PassengerFlag`` = _prefix "shapes/PassengerFlag"
    /// <summary>
    /// References a tunnel that a track goes through.
    /// <see href="http://data.europa.eu/949/passesThroughTunnel"></see></summary>
    let passesThroughTunnel = _prefix "passesThroughTunnel"
    /// <summary>
    /// Permissible payload for different line categories.
    /// <see href="http://data.europa.eu/949/permissiblePayload"></see></summary>
    let permissiblePayload = _prefix "permissiblePayload"

    /// <summary>
    /// Point at which IM authorises charging of electric energy storage for traction purposes at standstill.
    /// <see href="http://data.europa.eu/949/permissionChargingElectricEnergyTractionStandstill"></see></summary>
    let permissionChargingElectricEnergyTractionStandstill =
        _prefix "permissionChargingElectricEnergyTractionStandstill"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PermissionChargingElectricEnergyTractionStandstill"></see>
    /// </summary>
    let ``shapes/PermissionChargingElectricEnergyTractionStandstill`` =
        _prefix "shapes/PermissionChargingElectricEnergyTractionStandstill"

    /// <summary>
    /// Sections where is permitted to use the reflective plates on rail freight corridors, with a view to prioritise the current bottlenecks. Specific case for Belgium, France, Italy, Portugal and Spain until 1.1.2026
    /// <see href="http://data.europa.eu/949/permitUseReflectivePlates"></see></summary>
    let permitUseReflectivePlates = _prefix "permitUseReflectivePlates"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PermitUseReflectivePlates"></see>
    /// </summary>
    let ``shapes/PermitUseReflectivePlates`` =
        _prefix "shapes/PermitUseReflectivePlates"

    /// <summary>
    /// Indication of contact force allowed expressed in newton.
    /// <see href="http://data.europa.eu/949/permittedContactForce"></see></summary>
    let permittedContactForce = _prefix "permittedContactForce"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PermittedContactForce"></see>
    /// </summary>
    let ``shapes/PermittedContactForce`` = _prefix "shapes/PermittedContactForce"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PermittedContactForceApplicability"></see>
    /// </summary>
    let ``shapes/PermittedContactForceApplicability`` =
        _prefix "shapes/PermittedContactForceApplicability"

    /// <summary>
    /// Part of the phase info of a track that shows whether the breaker has to be switched off.
    /// <see href="http://data.europa.eu/949/phaseInfoSwitchOffBreaker"></see></summary>
    let phaseInfoSwitchOffBreaker = _prefix "phaseInfoSwitchOffBreaker"
    /// <summary>
    /// Relates the Track with PhaseInfo. Indication of required several information on phase separation.
    /// <see href="http://data.europa.eu/949/trackPhaseInfo"></see></summary>
    let trackPhaseInfo = _prefix "trackPhaseInfo"
    /// <summary>
    /// Part of the phase info of a track that corresponds to the length of the phase separation in metres.
    /// <see href="http://data.europa.eu/949/phaseInfoLength"></see></summary>
    let phaseInfoLength = _prefix "phaseInfoLength"
    /// <summary>
    /// Part of the phase info of a track that indicates the location from the start of the line where the new value is valid.
    /// <see href="http://data.europa.eu/949/phaseInfoKm"></see></summary>
    let phaseInfoKm = _prefix "phaseInfoKm"
    /// <summary>
    /// Part of the phase info of a track that shows whether a pantograph has to be lowered.
    /// <see href="http://data.europa.eu/949/phaseInfoPantographLowered"></see></summary>
    let phaseInfoPantographLowered = _prefix "phaseInfoPantographLowered"
    /// <summary>
    /// Part of the phase info of a track that corresponds to the single selection of Y=yes or N=no to show if the energy supply system changes
    /// <see href="http://data.europa.eu/949/phaseInfoChangeSupplySystem"></see></summary>
    let phaseInfoChangeSupplySystem = _prefix "phaseInfoChangeSupplySystem"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoChangeSupplySystem"></see>
    /// </summary>
    let ``shapes/PhaseInfoChangeSupplySystem`` =
        _prefix "shapes/PhaseInfoChangeSupplySystem"

    /// <summary>
    /// Part of the phase info of a track that corresponds to the single selection of 'MIN=minimum' or 'MAX=maximum' to show whether the length is a minimum distance between the inner contact strips of the pantographs or a maximum distance between the outer contact strips of the pantographs. Multiple strings for this parameter are accepted.
    /// <see href="http://data.europa.eu/949/phaseInfoDistanceType"></see></summary>
    let phaseInfoDistanceType = _prefix "phaseInfoDistanceType"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoDistanceType"></see>
    /// </summary>
    let ``shapes/PhaseInfoDistanceType`` = _prefix "shapes/PhaseInfoDistanceType"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoKm"></see>
    /// </summary>
    let ``shapes/PhaseInfoKm`` = _prefix "shapes/PhaseInfoKm"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoLength"></see>
    /// </summary>
    let ``shapes/PhaseInfoLength`` = _prefix "shapes/PhaseInfoLength"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoPantographLowered"></see>
    /// </summary>
    let ``shapes/PhaseInfoPantographLowered`` =
        _prefix "shapes/PhaseInfoPantographLowered"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoSwitchOffBreaker"></see>
    /// </summary>
    let ``shapes/PhaseInfoSwitchOffBreaker`` =
        _prefix "shapes/PhaseInfoSwitchOffBreaker"

    /// <summary>
    /// Reference to a related platform edge.
    /// <see href="http://data.europa.eu/949/platformEdge"></see></summary>
    let platformEdge = _prefix "platformEdge"
    /// <summary>
    /// Distance between the upper surface of platform and running surface of the neighbouring track. It is the nominal value expressed in millimetres.
    /// <see href="http://data.europa.eu/949/platformHeight"></see></summary>
    let platformHeight = _prefix "platformHeight"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/platform-heights/PlatformHeights"></see>
    /// </summary>
    let ``concepts/platform-heights/PlatformHeights`` =
        _prefix "concepts/platform-heights/PlatformHeights"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PlatformHeightP"></see>
    /// </summary>
    let ``shapes/PlatformHeightP`` = _prefix "shapes/PlatformHeightP"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PlatformHeightSKOS"></see>
    /// </summary>
    let ``shapes/PlatformHeightSKOS`` = _prefix "shapes/PlatformHeightSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/platformObjParameter"></see>
    /// </summary>
    let platformObjParameter = _prefix "platformObjParameter"
    /// <summary>
    /// Unique platform identification or unique platform number within an Operational Point.
    /// <see href="http://data.europa.eu/949/platformId"></see></summary>
    let platformId = _prefix "platformId"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PlatformId"></see>
    /// </summary>
    let ``shapes/PlatformId`` = _prefix "shapes/PlatformId"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NoRepeatedPlatformIdsOP"></see>
    /// </summary>
    let ``shapes/NoRepeatedPlatformIdsOP`` = _prefix "shapes/NoRepeatedPlatformIdsOP"
    /// <summary>
    /// Description of any portable boarding aids if considered in the design of the vehicle for meeting the PRM TSI requirements.
    /// <see href="http://data.europa.eu/949/portableBoardingAids"></see></summary>
    let portableBoardingAids = _prefix "portableBoardingAids"
    /// <summary>
    /// Determines the position of the topological object A in a relation.
    /// <see href="http://data.europa.eu/949/positionOnA"></see></summary>
    let positionOnA = _prefix "positionOnA"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/relation-positions/RelationPositions"></see>
    /// </summary>
    let ``concepts/relation-positions/RelationPositions`` =
        _prefix "concepts/relation-positions/RelationPositions"

    /// <summary>
    /// Determines the position of the topological object B in a relation.
    /// <see href="http://data.europa.eu/949/positionOnB"></see></summary>
    let positionOnB = _prefix "positionOnB"
    /// <summary>
    /// Possibility of preventing the use of the regenerative brake (only if fitted with regenerative brake).
    /// <see href="http://data.europa.eu/949/preventRegenerativeBrakeUse"></see></summary>
    let preventRegenerativeBrakeUse = _prefix "preventRegenerativeBrakeUse"
    /// <summary>
    /// Denotes a the previous VehicleType.
    /// <see href="http://data.europa.eu/949/previousVehicleType"></see></summary>
    let previousVehicleType = _prefix "previousVehicleType"
    /// <summary>
    /// Primary location code developed for information exchange in accordance with the TSIs relating to the telematics applications subsystem.
    /// <see href="http://data.europa.eu/949/primaryLocation"></see></summary>
    let primaryLocation = _prefix "primaryLocation"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PrimaryLocation"></see>
    /// </summary>
    let ``shapes/PrimaryLocation`` = _prefix "shapes/PrimaryLocation"
    /// <summary>
    /// Not used anymore. It has been replaced by era:primaryLocationCode.
    /// Primary location code developed for information exchange in accordance with the TSIs relating to the telematics applications subsystem
    /// <see href="http://data.europa.eu/949/tafTAPCode"></see></summary>
    let tafTAPCode = _prefix "tafTAPCode"
    /// <summary>
    /// Primary location code developed for information exchange in accordance with the TSIs relating to the telematics applications subsystem.
    /// <see href="http://data.europa.eu/949/primaryLocationCode"></see></summary>
    let primaryLocationCode = _prefix "primaryLocationCode"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PrimaryLocationCode"></see>
    /// </summary>
    let ``shapes/PrimaryLocationCode`` = _prefix "shapes/PrimaryLocationCode"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/primaryLocationName"></see>
    /// </summary>
    let primaryLocationName = _prefix "primaryLocationName"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PrimaryLocationName"></see>
    /// </summary>
    let ``shapes/PrimaryLocationName`` = _prefix "shapes/PrimaryLocationName"
    /// <summary>
    /// Number of priority seats.
    /// <see href="http://data.europa.eu/949/prioritySeats"></see></summary>
    let prioritySeats = _prefix "prioritySeats"
    /// <summary>
    /// Number of PRM accessible toilets.
    /// <see href="http://data.europa.eu/949/prmAccessibleToilets"></see></summary>
    let prmAccessibleToilets = _prefix "prmAccessibleToilets"
    /// <summary>
    /// Coding for combined transport for semi-trailers (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B].
    /// <see href="http://data.europa.eu/949/profileNumberSemiTrailers"></see></summary>
    let profileNumberSemiTrailers = _prefix "profileNumberSemiTrailers"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/profile-num-semi-trailers/ProfileNumbersSemiTrailers"></see>
    /// </summary>
    let ``concepts/profile-num-semi-trailers/ProfileNumbersSemiTrailers`` =
        _prefix "concepts/profile-num-semi-trailers/ProfileNumbersSemiTrailers"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ProfileNumberSemiTrailersSKOS"></see>
    /// </summary>
    let ``shapes/ProfileNumberSemiTrailersSKOS`` =
        _prefix "shapes/ProfileNumberSemiTrailersSKOS"

    /// <summary>
    /// Coding for combined transport with swap bodies (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B]
    /// <see href="http://data.europa.eu/949/profileNumberSwapBodies"></see></summary>
    let profileNumberSwapBodies = _prefix "profileNumberSwapBodies"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/profile-num-swap-bodies/ProfileNumbersSwapBodies"></see>
    /// </summary>
    let ``concepts/profile-num-swap-bodies/ProfileNumbersSwapBodies`` =
        _prefix "concepts/profile-num-swap-bodies/ProfileNumbersSwapBodies"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ProfileNumberSwapBodiesSKOS"></see>
    /// </summary>
    let ``shapes/ProfileNumberSwapBodiesSKOS`` =
        _prefix "shapes/ProfileNumberSwapBodiesSKOS"

    /// <summary>
    /// Indication of which class B system is installed.
    /// <see href="http://data.europa.eu/949/protectionLegacySystem"></see></summary>
    let protectionLegacySystem = _prefix "protectionLegacySystem"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ProtectionLegacySystemSKOS"></see>
    /// </summary>
    let ``shapes/ProtectionLegacySystemSKOS`` =
        _prefix "shapes/ProtectionLegacySystemSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trainProtectionLegacySystemObjParameter"></see>
    /// </summary>
    let trainProtectionLegacySystemObjParameter =
        _prefix "trainProtectionLegacySystemObjParameter"

    /// <summary>
    /// Existence of roaming to a public network.
    ///
    ///                          In case of Y, provide the name of the public network(s) under parameter "Details on GSM-R roaming to public networks".
    /// <see href="http://data.europa.eu/949/publicNetworkRoaming"></see></summary>
    let publicNetworkRoaming = _prefix "publicNetworkRoaming"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PublicNetworkRoamingApplicability"></see>
    /// </summary>
    let ``shapes/PublicNetworkRoamingApplicability`` =
        _prefix "shapes/PublicNetworkRoamingApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PublicNetworkRoaming"></see>
    /// </summary>
    let ``shapes/PublicNetworkRoaming`` = _prefix "shapes/PublicNetworkRoaming"
    /// <summary>
    /// If roaming to public networks is configured, please indicate to which networks, for which users and in which areas.
    /// <see href="http://data.europa.eu/949/publicNetworkRoamingDetails"></see></summary>
    let publicNetworkRoamingDetails = _prefix "publicNetworkRoamingDetails"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PublicNetworkRoamingDetailsApplicability"></see>
    /// </summary>
    let ``shapes/PublicNetworkRoamingDetailsApplicability`` =
        _prefix "shapes/PublicNetworkRoamingDetailsApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PublicNetworkRoamingDetails"></see>
    /// </summary>
    let ``shapes/PublicNetworkRoamingDetails`` =
        _prefix "shapes/PublicNetworkRoamingDetails"

    /// <summary>
    /// Qualifier determining whether the driver is allowed to modify the adhesion factor used by the ETCS on-board to calculate the braking curves.
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/qNvdriverAdhes"></see></summary>
    let qNvdriverAdhes = _prefix "qNvdriverAdhes"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/adhf-qualifier/AdhesionFactorChange"></see>
    /// </summary>
    let ``concepts/adhf-qualifier/AdhesionFactorChange`` =
        _prefix "concepts/adhf-qualifier/AdhesionFactorChange"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvdriverAdhes"></see>
    /// </summary>
    let ``shapes/QNvdriverAdhes`` = _prefix "shapes/QNvdriverAdhes"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvdriverAdhesSKOS"></see>
    /// </summary>
    let ``shapes/QNvdriverAdhesSKOS`` = _prefix "shapes/QNvdriverAdhesSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvdriverAdhesApplicability"></see>
    /// </summary>
    let ``shapes/QNvdriverAdhesApplicability`` =
        _prefix "shapes/QNvdriverAdhesApplicability"

    /// <summary>
    /// Qualifier defining whether the application of the emergency brake for reasons other than a trip can be revoked as soon as the conditions for it have disappeared or after the train has come to a complete standstill.
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/qNvemrrls"></see></summary>
    let qNvemrrls = _prefix "qNvemrrls"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ebr-qualifier/EBReleaseQualifier"></see>
    /// </summary>
    let ``concepts/ebr-qualifier/EBReleaseQualifier`` =
        _prefix "concepts/ebr-qualifier/EBReleaseQualifier"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvemrrls"></see>
    /// </summary>
    let ``shapes/QNvemrrls`` = _prefix "shapes/QNvemrrls"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvemrrlsSKOS"></see>
    /// </summary>
    let ``shapes/QNvemrrlsSKOS`` = _prefix "shapes/QNvemrrlsSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvemrrlsApplicability"></see>
    /// </summary>
    let ``shapes/QNvemrrlsApplicability`` = _prefix "shapes/QNvemrrlsApplicability"
    /// <summary>
    /// Permission to use service brake in target speed monitoring
    /// <see href="http://data.europa.eu/949/qNvsbtsmperm"></see></summary>
    let qNvsbtsmperm = _prefix "qNvsbtsmperm"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvsbtsmperm"></see>
    /// </summary>
    let ``shapes/QNvsbtsmperm`` = _prefix "shapes/QNvsbtsmperm"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvsbtsmpermApplicability"></see>
    /// </summary>
    let ``shapes/QNvsbtsmpermApplicability`` =
        _prefix "shapes/QNvsbtsmpermApplicability"

    /// <summary>
    /// Quasi-static guiding force (if exceeds the limit defined in TSI or not defined in the TSI), given in kN.
    /// <see href="http://data.europa.eu/949/quasiStaticGuidingForce"></see></summary>
    let quasiStaticGuidingForce = _prefix "quasiStaticGuidingForce"
    /// <summary>
    /// Country where a vehicle may operate without noise restrictions.
    /// <see href="http://data.europa.eu/949/quieterRoutesExemptedCountry"></see></summary>
    let quieterRoutesExemptedCountry = _prefix "quieterRoutesExemptedCountry"
    /// <summary>
    /// Unique identification of the GSM-R network the calling mobile station has to register with, as defined in the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/radioNetworkId"></see></summary>
    let radioNetworkId = _prefix "radioNetworkId"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RadioNetworkId"></see>
    /// </summary>
    let ``shapes/RadioNetworkId`` = _prefix "shapes/RadioNetworkId"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RadioNetworkIdApplicability"></see>
    /// </summary>
    let ``shapes/RadioNetworkIdApplicability`` =
        _prefix "shapes/RadioNetworkIdApplicability"

    /// <summary>
    /// Special conditions implemented on-board to switch over between different radio systems. Given as combination of systems installed on board ('System XX'_'System YY').
    /// <see href="http://data.europa.eu/949/radioSwitchOverSpecialConditions"></see></summary>
    let radioSwitchOverSpecialConditions = _prefix "radioSwitchOverSpecialConditions"
    /// <summary>
    /// An angle defining the inclination of the head of a rail relative to the running surface.
    /// <see href="http://data.europa.eu/949/railInclination"></see></summary>
    let railInclination = _prefix "railInclination"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/rail-inclinations/RailInclinations"></see>
    /// </summary>
    let ``concepts/rail-inclinations/RailInclinations`` =
        _prefix "concepts/rail-inclinations/RailInclinations"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RailInclination"></see>
    /// </summary>
    let ``shapes/RailInclination`` = _prefix "shapes/RailInclination"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RailInclinationSKOS"></see>
    /// </summary>
    let ``shapes/RailInclinationSKOS`` = _prefix "shapes/RailInclinationSKOS"
    /// <summary>
    /// (deprecated) Type of railway system. Can be "High-speed" or "Conventional". Deprecated due to the lack of information
    /// <see href="http://data.europa.eu/949/railSystemType"></see></summary>
    let railSystemType = _prefix "railSystemType"
    /// <summary>
    /// Part of the raised pantographs distance and speed of a track that corresponds to the minimum distance between pantographs, in metres.
    /// <see href="http://data.europa.eu/949/raisedPantographsDistance"></see></summary>
    let raisedPantographsDistance = _prefix "raisedPantographsDistance"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RaisedPantographsDistance"></see>
    /// </summary>
    let ``shapes/RaisedPantographsDistance`` =
        _prefix "shapes/RaisedPantographsDistance"

    /// <summary>
    /// Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.
    /// <see href="http://data.europa.eu/949/raisedPantographsDistanceAndSpeed"></see></summary>
    let raisedPantographsDistanceAndSpeed = _prefix "raisedPantographsDistanceAndSpeed"
    /// <summary>
    /// Part of the raised pantographs distance and speed of a track that corresponds to the number of pantographs.
    /// <see href="http://data.europa.eu/949/raisedPantographsNumber"></see></summary>
    let raisedPantographsNumber = _prefix "raisedPantographsNumber"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RaisedPantographsNumber"></see>
    /// </summary>
    let ``shapes/RaisedPantographsNumber`` = _prefix "shapes/RaisedPantographsNumber"
    /// <summary>
    /// Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.
    /// <see href="http://data.europa.eu/949/raisedPantographsSpeed"></see></summary>
    let raisedPantographsSpeed = _prefix "raisedPantographsSpeed"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RaisedPantographsSpeed"></see>
    /// </summary>
    let ``shapes/RaisedPantographsSpeed`` = _prefix "shapes/RaisedPantographsSpeed"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RbcID"></see>
    /// </summary>
    let ``shapes/RbcID`` = _prefix "shapes/RbcID"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RbcPhone"></see>
    /// </summary>
    let ``shapes/RbcPhone`` = _prefix "shapes/RbcPhone"
    /// <summary>
    /// List of cases subject to system design choices made by the infrastructure manager according to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/reasonsEtcsRadioBlockCenterReject"></see></summary>
    let reasonsEtcsRadioBlockCenterReject = _prefix "reasonsEtcsRadioBlockCenterReject"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-rbc-reject-reasons/ETCSRBCRejectionReasons"></see>
    /// </summary>
    let ``concepts/etcs-rbc-reject-reasons/ETCSRBCRejectionReasons`` =
        _prefix "concepts/etcs-rbc-reject-reasons/ETCSRBCRejectionReasons"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ReasonsEtcsRadioBlockCenterRejectSKOS"></see>
    /// </summary>
    let ``shapes/ReasonsEtcsRadioBlockCenterRejectSKOS`` =
        _prefix "shapes/ReasonsEtcsRadioBlockCenterRejectSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ReasonsEtcsRadioBlockCenterReject"></see>
    /// </summary>
    let ``shapes/ReasonsEtcsRadioBlockCenterReject`` =
        _prefix "shapes/ReasonsEtcsRadioBlockCenterReject"

    /// <summary>
    /// Sections where two steady red lights are required in accordance with TSI OPE
    /// Sections where permissive driving is possible in accordance with point 4.2.2.1.2 of TSI OPE
    /// <see href="http://data.europa.eu/949/redLightsRequired"></see></summary>
    let redLightsRequired = _prefix "redLightsRequired"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RedLightsRequired"></see>
    /// </summary>
    let ``shapes/RedLightsRequired`` = _prefix "shapes/RedLightsRequired"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RedLightsRequiredCountryApplicability"></see>
    /// </summary>
    let ``shapes/RedLightsRequiredCountryApplicability`` =
        _prefix "shapes/RedLightsRequiredCountryApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ReferenceBorderPoint"></see>
    /// </summary>
    let ``shapes/ReferenceBorderPoint`` = _prefix "shapes/ReferenceBorderPoint"
    /// <summary>
    /// Pass-by noise level was measured under reference conditions.
    /// <see href="http://data.europa.eu/949/referencePassByNoiseLevel"></see></summary>
    let referencePassByNoiseLevel = _prefix "referencePassByNoiseLevel"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/relatedElectromagneticInterferencesDataParameter"></see>
    /// </summary>
    let relatedElectromagneticInterferencesDataParameter =
        _prefix "relatedElectromagneticInterferencesDataParameter"

    /// <summary>
    /// Distance in meters to the danger point
    /// <see href="http://data.europa.eu/949/relativeDistanceDangerPoint"></see></summary>
    let relativeDistanceDangerPoint = _prefix "relativeDistanceDangerPoint"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RelativeDistanceDangerPoint"></see>
    /// </summary>
    let ``shapes/RelativeDistanceDangerPoint`` =
        _prefix "shapes/RelativeDistanceDangerPoint"

    /// <summary>
    /// Indicates the position of an object relative to the linear coordinates of the associated topological object.
    /// <see href="http://data.europa.eu/949/relativePosition"></see></summary>
    let relativePosition = _prefix "relativePosition"
    /// <summary>
    /// Indication whether possibility to activate/deactivate sanding devices by driver, according to instructions from the Infrastructure Manager, is required or not. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/requiredSandingOverride"></see></summary>
    let requiredSandingOverride = _prefix "requiredSandingOverride"
    /// <summary>
    /// Indicates the relationship of a Body to the organisation roles that it can play.
    /// <see href="http://data.europa.eu/949/role"></see></summary>
    let role = _prefix "role"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Role"></see>
    /// </summary>
    let ``shapes/Role`` = _prefix "shapes/Role"
    /// <summary>
    /// Indicates the corresponding Body that plays a certain organisation role.
    /// <see href="http://data.europa.eu/949/roleOf"></see></summary>
    let roleOf = _prefix "roleOf"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RoleOf"></see>
    /// </summary>
    let ``shapes/RoleOf`` = _prefix "shapes/RoleOf"
    /// <summary>
    /// Categorisation how a passenger train with a fire on board will continue to operate for a defined time period
    /// Passenger train fire category in accordance with point 4.1.4 of TSI LOC&amp;PAS.
    /// <see href="http://data.europa.eu/949/rollingStockFireCategory"></see></summary>
    let rollingStockFireCategory = _prefix "rollingStockFireCategory"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RollingStockFireCategorySKOS"></see>
    /// </summary>
    let ``shapes/RollingStockFireCategorySKOS`` =
        _prefix "shapes/RollingStockFireCategorySKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RollingStockFireCategoryApplicability"></see>
    /// </summary>
    let ``shapes/RollingStockFireCategoryApplicability`` =
        _prefix "shapes/RollingStockFireCategoryApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RollingStockFireCategory"></see>
    /// </summary>
    let ``shapes/RollingStockFireCategory`` = _prefix "shapes/RollingStockFireCategory"

    /// <summary>
    /// Indication whether safe consist train length information from on-board is required to access the line for safety reasons and the required safety integrity level.
    /// <see href="http://data.europa.eu/949/safeConsistLengthInformationNecessary"></see></summary>
    let safeConsistLengthInformationNecessary =
        _prefix "safeConsistLengthInformationNecessary"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/safe-consist-length/SafeConsistLengthNecessary"></see>
    /// </summary>
    let ``concepts/safe-consist-length/SafeConsistLengthNecessary`` =
        _prefix "concepts/safe-consist-length/SafeConsistLengthNecessary"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SafeConsistLengthInformationNecessarySKOS"></see>
    /// </summary>
    let ``shapes/SafeConsistLengthInformationNecessarySKOS`` =
        _prefix "shapes/SafeConsistLengthInformationNecessarySKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SafeConsistLengthInformationNecessary"></see>
    /// </summary>
    let ``shapes/SafeConsistLengthInformationNecessary`` =
        _prefix "shapes/SafeConsistLengthInformationNecessary"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SafeConsistLengthInformationNecessaryApplicability"></see>
    /// </summary>
    let ``shapes/SafeConsistLengthInformationNecessaryApplicability`` =
        _prefix "shapes/SafeConsistLengthInformationNecessaryApplicability"

    /// <summary>
    /// Document providing the schematic overview of the operational point
    /// <see href="http://data.europa.eu/949/schematicOverviewOP"></see></summary>
    let schematicOverviewOP = _prefix "schematicOverviewOP"
    /// <summary>
    /// Annotation property used in SHACL shapes. Indicates if the SHACL shape is validating a property of a specific instance ("local"), or if it needs to check other instances ("global"). For example, SHACL shape to validate no repeated ids within a specific track.
    /// <see href="http://data.europa.eu/949/scope"></see></summary>
    let scope = _prefix "scope"

    /// <summary>
    /// Shortest distance between two pantographs in contact with the OCL (to be indicated for each energy supply system the vehicle is equipped for; to be indicated for single and, if applicable, multiple operation) (only if number of raised pantographs is more than 1).
    /// <see href="http://data.europa.eu/949/shortestDistanceBetweenPantographsInContactWithOCL"></see></summary>
    let shortestDistanceBetweenPantographsInContactWithOCL =
        _prefix "shortestDistanceBetweenPantographsInContactWithOCL"

    /// <summary>
    /// Indication of the position of the signal in relation to the track in the running direction from the origin of the referencing system (e.g., direction of the main line)
    /// <see href="http://data.europa.eu/949/side"></see></summary>
    let side = _prefix "side"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/orientations/Sides"></see>
    /// </summary>
    let ``concepts/orientations/Sides`` = _prefix "concepts/orientations/Sides"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Side"></see>
    /// </summary>
    let ``shapes/Side`` = _prefix "shapes/Side"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SideSKOS"></see>
    /// </summary>
    let ``shapes/SideSKOS`` = _prefix "shapes/SideSKOS"
    /// <summary>
    /// Unique siding identification or number within an Operational Point.
    /// <see href="http://data.europa.eu/949/sidingId"></see></summary>
    let sidingId = _prefix "sidingId"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SidingId"></see>
    /// </summary>
    let ``shapes/SidingId`` = _prefix "shapes/SidingId"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NoRepeatedSidingIds"></see>
    /// </summary>
    let ``shapes/NoRepeatedSidingIds`` = _prefix "shapes/NoRepeatedSidingIds"
    /// <summary>
    /// Identifier of signal.
    /// <see href="http://data.europa.eu/949/signalId"></see></summary>
    let signalId = _prefix "signalId"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SignalId"></see>
    /// </summary>
    let ``shapes/SignalId`` = _prefix "shapes/SignalId"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/signalObjParameter"></see>
    /// </summary>
    let signalObjParameter = _prefix "signalObjParameter"
    /// <summary>
    /// Relative position to the line of reference, given in km and indication if the signal refers to normal or opposite track direction
    /// <see href="http://data.europa.eu/949/signalOrientation"></see></summary>
    let signalOrientation = _prefix "signalOrientation"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SignalOrientationSKOS"></see>
    /// </summary>
    let ``shapes/SignalOrientationSKOS`` = _prefix "shapes/SignalOrientationSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SignalOrientation"></see>
    /// </summary>
    let ``shapes/SignalOrientation`` = _prefix "shapes/SignalOrientation"
    /// <summary>
    /// Signalling information for Route Book compilation. This list shall include fixed signals that protect danger points
    /// <see href="http://data.europa.eu/949/signalType"></see></summary>
    let signalType = _prefix "signalType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/signal-types/SignalTypes"></see>
    /// </summary>
    let ``concepts/signal-types/SignalTypes`` =
        _prefix "concepts/signal-types/SignalTypes"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SignalTypeSKOS"></see>
    /// </summary>
    let ``shapes/SignalTypeSKOS`` = _prefix "shapes/SignalTypeSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SignalType"></see>
    /// </summary>
    let ``shapes/SignalType`` = _prefix "shapes/SignalType"
    /// <summary>
    /// Number of sleeping places.
    /// <see href="http://data.europa.eu/949/sleepingPlaces"></see></summary>
    let sleepingPlaces = _prefix "sleepingPlaces"
    /// <summary>
    /// Snow, ice and hail conditions.
    /// <see href="http://data.europa.eu/949/snowIceHailConditions"></see></summary>
    let snowIceHailConditions = _prefix "snowIceHailConditions"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ice-conditions/IceConditions"></see>
    /// </summary>
    let ``concepts/ice-conditions/IceConditions`` =
        _prefix "concepts/ice-conditions/IceConditions"

    /// <summary>
    /// Kind of section of line expressing size of presented data which depends on fact whether it connects OPs generated by division of a big node into several OPs or not.
    /// <see href="http://data.europa.eu/949/solNature"></see></summary>
    let solNature = _prefix "solNature"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/sol-natures/SoLNatures"></see>
    /// </summary>
    let ``concepts/sol-natures/SoLNatures`` = _prefix "concepts/sol-natures/SoLNatures"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SolNatureApplicability"></see>
    /// </summary>
    let ``shapes/SolNatureApplicability`` = _prefix "shapes/SolNatureApplicability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SolNature"></see>
    /// </summary>
    let ``shapes/SolNature`` = _prefix "shapes/SolNature"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SolNatureSKOS"></see>
    /// </summary>
    let ``shapes/SolNatureSKOS`` = _prefix "shapes/SolNatureSKOS"
    /// <summary>
    /// Indicates the special area or location types such as safe areas and restricted area types.
    /// <see href="http://data.europa.eu/949/specialAreaType"></see></summary>
    let specialAreaType = _prefix "specialAreaType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/special-area-types/SpecialAreaTypes"></see>
    /// </summary>
    let ``concepts/special-area-types/SpecialAreaTypes`` =
        _prefix "concepts/special-area-types/SpecialAreaTypes"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SpecialAreaType"></see>
    /// </summary>
    let ``shapes/SpecialAreaType`` = _prefix "shapes/SpecialAreaType"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SpecialAreaTypeSKOS"></see>
    /// </summary>
    let ``shapes/SpecialAreaTypeSKOS`` = _prefix "shapes/SpecialAreaTypeSKOS"
    /// <summary>
    /// Relates a tunnel with a special area or location.
    /// <see href="http://data.europa.eu/949/specialTunnelArea"></see></summary>
    let specialTunnelArea = _prefix "specialTunnelArea"
    /// <summary>
    /// Special type of service on a line or a section of a line.
    /// <see href="http://data.europa.eu/949/specializedInfrastructure"></see></summary>
    let specializedInfrastructure = _prefix "specializedInfrastructure"
    /// <summary>
    /// Any relevant information from the IM relating to the line layout
    /// <see href="http://data.europa.eu/949/specificInformation"></see></summary>
    let specificInformation = _prefix "specificInformation"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SpecificInformation"></see>
    /// </summary>
    let ``shapes/SpecificInformation`` = _prefix "shapes/SpecificInformation"

    /// <summary>
    /// Coding for combined transport for containers (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B]
    /// <see href="http://data.europa.eu/949/standardCombinedTransportContainers"></see></summary>
    let standardCombinedTransportContainers =
        _prefix "standardCombinedTransportContainers"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/standard-combined-transport-containers/StandardCombinedTransportContainers"></see>
    /// </summary>
    let ``concepts/standard-combined-transport-containers/StandardCombinedTransportContainers`` =
        _prefix "concepts/standard-combined-transport-containers/StandardCombinedTransportContainers"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StandardCombinedTransportContainers"></see>
    /// </summary>
    let ``shapes/StandardCombinedTransportContainers`` =
        _prefix "shapes/StandardCombinedTransportContainers"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StandardCombinedTransportContainersSKOS"></see>
    /// </summary>
    let ``shapes/StandardCombinedTransportContainersSKOS`` =
        _prefix "shapes/StandardCombinedTransportContainersSKOS"

    /// <summary>
    /// Coding for combined transport for roller units (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B]
    /// <see href="http://data.europa.eu/949/standardCombinedTransportRollerUnits"></see></summary>
    let standardCombinedTransportRollerUnits =
        _prefix "standardCombinedTransportRollerUnits"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/standard-combined-transport-roller-units/StandardCombinedTransportRollerUnits"></see>
    /// </summary>
    let ``concepts/standard-combined-transport-roller-units/StandardCombinedTransportRollerUnits`` =
        _prefix "concepts/standard-combined-transport-roller-units/StandardCombinedTransportRollerUnits"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StandardCombinedRollerUnitsSKOS"></see>
    /// </summary>
    let ``shapes/StandardCombinedRollerUnitsSKOS`` =
        _prefix "shapes/StandardCombinedRollerUnitsSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StandardCombinedRollerUnits"></see>
    /// </summary>
    let ``shapes/StandardCombinedRollerUnits`` =
        _prefix "shapes/StandardCombinedRollerUnits"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/startIntrinsicCoordinate"></see>
    /// </summary>
    let startIntrinsicCoordinate = _prefix "startIntrinsicCoordinate"
    /// <summary>
    /// Part of the Start of tunnel that indicates the Geographical coordinates according to the standard World Geodetic System (WGS). Precision for both geographical latitude and geographical longitude is assumed as [NN.NNNNNNN] in degrees with decimals what gives discretion of 10 cm in the network.
    /// The Start of tunnel is the Geographical coordinates in decimal degrees and km of the line at the beginning of a tunnel.
    /// <see href="http://data.europa.eu/949/startLocation"></see></summary>
    let startLocation = _prefix "startLocation"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StartLocation"></see>
    /// </summary>
    let ``shapes/StartLocation`` = _prefix "shapes/StartLocation"
    /// <summary>
    /// Start offset of the section from the origin.
    /// <see href="http://data.europa.eu/949/startOffsetFromOrigin"></see></summary>
    let startOffsetFromOrigin = _prefix "startOffsetFromOrigin"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StartOffsetFromOrigin"></see>
    /// </summary>
    let ``shapes/StartOffsetFromOrigin`` = _prefix "shapes/StartOffsetFromOrigin"
    /// <summary>
    /// starting noise level given in dB(A).
    /// <see href="http://data.europa.eu/949/startingNoiseLevel"></see></summary>
    let startingNoiseLevel = _prefix "startingNoiseLevel"
    /// <summary>
    /// Specifies the starting point of a linear reference.
    /// <see href="http://data.europa.eu/949/startsAt"></see></summary>
    let startsAt = _prefix "startsAt"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StartsAt"></see>
    /// </summary>
    let ``shapes/StartsAt`` = _prefix "shapes/StartsAt"
    /// <summary>
    /// Denoting the state of the certificate Can be in one of the following: Amended, New, Suspended, Withdrawn.
    /// <see href="http://data.europa.eu/949/state"></see></summary>
    let state = _prefix "state"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/states/States"></see>
    /// </summary>
    let ``concepts/states/States`` = _prefix "concepts/states/States"
    /// <summary>
    /// Static axle load under exceptional payload.
    /// <see href="http://data.europa.eu/949/staticAxleLoadExceptionalPayload"></see></summary>
    let staticAxleLoadExceptionalPayload = _prefix "staticAxleLoadExceptionalPayload"
    /// <summary>
    /// Static axle load under normal payload.
    /// <see href="http://data.europa.eu/949/staticAxleLoadNormalPayload"></see></summary>
    let staticAxleLoadNormalPayload = _prefix "staticAxleLoadNormalPayload"
    /// <summary>
    /// Static axle load in working order.
    /// <see href="http://data.europa.eu/949/staticAxleLoadWorkingOrder"></see></summary>
    let staticAxleLoadWorkingOrder = _prefix "staticAxleLoadWorkingOrder"
    /// <summary>
    /// stationary noise level given in dB(A).
    /// <see href="http://data.europa.eu/949/stationaryNoiseLevel"></see></summary>
    let stationaryNoiseLevel = _prefix "stationaryNoiseLevel"
    /// <summary>
    /// Structural category.
    /// <see href="http://data.europa.eu/949/structuralCategory"></see></summary>
    let structuralCategory = _prefix "structuralCategory"
    /// <summary>
    /// Localisation of structures requiring specific checks
    /// <see href="http://data.europa.eu/949/structureCheckLocation"></see></summary>
    let structureCheckLocation = _prefix "structureCheckLocation"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StructureCheckLocation"></see>
    /// </summary>
    let ``shapes/StructureCheckLocation`` = _prefix "shapes/StructureCheckLocation"
    /// <summary>
    /// (Deprecated) Vehicle subcategory.
    /// <see href="http://data.europa.eu/949/subCategory"></see></summary>
    let subCategory = _prefix "subCategory"
    /// <summary>
    /// Indicates the further classification (but not any family/platform) of vehicles within a vehicle category.
    /// <see href="http://data.europa.eu/949/vehicleSubCategory"></see></summary>
    let vehicleSubCategory = _prefix "vehicleSubCategory"
    /// <summary>
    /// A subset of elements with common characteristics could be identified with a unique name/id.
    /// <see href="http://data.europa.eu/949/subsetName"></see></summary>
    let subsetName = _prefix "subsetName"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsetName"></see>
    /// </summary>
    let ``shapes/SubsetName`` = _prefix "shapes/SubsetName"
    /// <summary>
    /// Relates a subset with common characteristics with another subset with common characteristics.
    /// <see href="http://data.europa.eu/949/subsetOf"></see></summary>
    let subsetOf = _prefix "subsetOf"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsetOf"></see>
    /// </summary>
    let ``shapes/SubsetOf`` = _prefix "shapes/SubsetOf"
    /// <summary>
    /// The numeric code for the subsidiary location
    /// <see href="http://data.europa.eu/949/subsidiaryLocationCode"></see></summary>
    let subsidiaryLocationCode = _prefix "subsidiaryLocationCode"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsidiaryLocationCode"></see>
    /// </summary>
    let ``shapes/SubsidiaryLocationCode`` = _prefix "shapes/SubsidiaryLocationCode"
    /// <summary>
    /// The common name given to the subsidiary location
    /// <see href="http://data.europa.eu/949/subsidiaryLocationName"></see></summary>
    let subsidiaryLocationName = _prefix "subsidiaryLocationName"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsidiaryLocationName"></see>
    /// </summary>
    let ``shapes/SubsidiaryLocationName`` = _prefix "shapes/SubsidiaryLocationName"
    /// <summary>
    /// Indicates the subsidiary location type that belongs to a taxonomy.
    /// <see href="http://data.europa.eu/949/subsidiaryLocationType"></see></summary>
    let subsidiaryLocationType = _prefix "subsidiaryLocationType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/subsidiary-location-types/SubsidiaryLocationTypes"></see>
    /// </summary>
    let ``concepts/subsidiary-location-types/SubsidiaryLocationTypes`` =
        _prefix "concepts/subsidiary-location-types/SubsidiaryLocationTypes"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsidiaryLocationTypeSKOS"></see>
    /// </summary>
    let ``shapes/SubsidiaryLocationTypeSKOS`` =
        _prefix "shapes/SubsidiaryLocationTypeSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsidiaryLocationType"></see>
    /// </summary>
    let ``shapes/SubsidiaryLocationType`` = _prefix "shapes/SubsidiaryLocationType"
    /// <summary>
    /// Platform height for which the vehicle is designed.
    /// <see href="http://data.europa.eu/949/supportedPlatformHeight"></see></summary>
    let supportedPlatformHeight = _prefix "supportedPlatformHeight"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SwitchProtectControlWarningApplicability"></see>
    /// </summary>
    let ``shapes/SwitchProtectControlWarningApplicability`` =
        _prefix "shapes/SwitchProtectControlWarningApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SwitchProtectControlWarning"></see>
    /// </summary>
    let ``shapes/SwitchProtectControlWarning`` =
        _prefix "shapes/SwitchProtectControlWarning"

    /// <summary>
    /// Indication whether a switch over between different radio systems and no communication system whilst running exists.
    /// <see href="http://data.europa.eu/949/switchRadioSystem"></see></summary>
    let switchRadioSystem = _prefix "switchRadioSystem"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SwitchRadioSystemApplicability"></see>
    /// </summary>
    let ``shapes/SwitchRadioSystemApplicability`` =
        _prefix "shapes/SwitchRadioSystemApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SwitchRadioSystem"></see>
    /// </summary>
    let ``shapes/SwitchRadioSystem`` = _prefix "shapes/SwitchRadioSystem"
    /// <summary>
    /// Indication of required several information on system separation
    /// <see href="http://data.europa.eu/949/trackSystemSeparationInfo"></see></summary>
    let trackSystemSeparationInfo = _prefix "trackSystemSeparationInfo"

    /// <summary>
    /// Part of the system separation info of a track that shows whether the breaker has to be switched off.
    /// The system separation info is the Indication of required several information on system separation.
    /// <see href="http://data.europa.eu/949/systemSeparationInfoSwitchOffBreaker"></see></summary>
    let systemSeparationInfoSwitchOffBreaker =
        _prefix "systemSeparationInfoSwitchOffBreaker"

    /// <summary>
    /// Part of the system separation info of a track that shows the length of the system separation in metres.
    /// The system separation info is the Indication of required several information on system separation.
    /// <see href="http://data.europa.eu/949/systemSeparationInfoLength"></see></summary>
    let systemSeparationInfoLength = _prefix "systemSeparationInfoLength"
    /// <summary>
    /// Part of the system separation info of a track. Indicates the location from the start of the line where the new value is valid.
    /// The system separation info is the Indication of required several information on system separation.
    /// <see href="http://data.europa.eu/949/systemSeparationInfoKm"></see></summary>
    let systemSeparationInfoKm = _prefix "systemSeparationInfoKm"

    /// <summary>
    /// Part of the system separation info of a track that shows whether the supply system has to be changed.
    /// The system separation info is the Indication of required several information on system separation.
    /// <see href="http://data.europa.eu/949/systemSeparationInfoChangeSupplySystem"></see></summary>
    let systemSeparationInfoChangeSupplySystem =
        _prefix "systemSeparationInfoChangeSupplySystem"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SystemSeparationInfoChangeSupplySystem"></see>
    /// </summary>
    let ``shapes/SystemSeparationInfoChangeSupplySystem`` =
        _prefix "shapes/SystemSeparationInfoChangeSupplySystem"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SystemSeparationInfoKm"></see>
    /// </summary>
    let ``shapes/SystemSeparationInfoKm`` = _prefix "shapes/SystemSeparationInfoKm"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SystemSeparationInfoLength"></see>
    /// </summary>
    let ``shapes/SystemSeparationInfoLength`` =
        _prefix "shapes/SystemSeparationInfoLength"

    /// <summary>
    /// Part of the system separation info of a track that shows whether the pantograph has to be lowered.
    /// The system separation info is the Indication of required several information on system separation.
    /// <see href="http://data.europa.eu/949/systemSeparationInfoPantographLowered"></see></summary>
    let systemSeparationInfoPantographLowered =
        _prefix "systemSeparationInfoPantographLowered"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SystemSeparationInfoPantographLowered"></see>
    /// </summary>
    let ``shapes/SystemSeparationInfoPantographLowered`` =
        _prefix "shapes/SystemSeparationInfoPantographLowered"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SystemSeparationInfoSwitchOffBreaker"></see>
    /// </summary>
    let ``shapes/SystemSeparationInfoSwitchOffBreaker`` =
        _prefix "shapes/SystemSeparationInfoSwitchOffBreaker"

    /// <summary>
    /// Maximum time without a safe message from Radio Block Center before train reacts in seconds.
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/tNvcontact"></see></summary>
    let tNvcontact = _prefix "tNvcontact"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TNvcontactApplicability"></see>
    /// </summary>
    let ``shapes/TNvcontactApplicability`` = _prefix "shapes/TNvcontactApplicability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TNvcontact"></see>
    /// </summary>
    let ``shapes/TNvcontact`` = _prefix "shapes/TNvcontact"
    /// <summary>
    /// Maximum time for overriding the train trip in seconds.
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/tNvovtrp"></see></summary>
    let tNvovtrp = _prefix "tNvovtrp"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TNvovtrpApplicability"></see>
    /// </summary>
    let ``shapes/TNvovtrpApplicability`` = _prefix "shapes/TNvovtrpApplicability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TNvovtrp"></see>
    /// </summary>
    let ``shapes/TNvovtrp`` = _prefix "shapes/TNvovtrp"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TdsFrenchTrainDetectionSystemLimitation"></see>
    /// </summary>
    let ``shapes/TdsFrenchTrainDetectionSystemLimitation`` =
        _prefix "shapes/TdsFrenchTrainDetectionSystemLimitation"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TdsMaximumMagneticFieldApplicability"></see>
    /// </summary>
    let ``shapes/TdsMaximumMagneticFieldApplicability`` =
        _prefix "shapes/TdsMaximumMagneticFieldApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TdsMaximumMagneticField"></see>
    /// </summary>
    let ``shapes/TdsMaximumMagneticField`` = _prefix "shapes/TdsMaximumMagneticField"
    /// <summary>
    /// Indication of load given in tons depending of the category of vehicle. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tdsMinAxleLoadVehicleCategory"></see></summary>
    let tdsMinAxleLoadVehicleCategory = _prefix "tdsMinAxleLoadVehicleCategory"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/temperature-ranges/TemperatureRanges"></see>
    /// </summary>
    let ``concepts/temperature-ranges/TemperatureRanges`` =
        _prefix "concepts/temperature-ranges/TemperatureRanges"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TemperatureRange"></see>
    /// </summary>
    let ``shapes/TemperatureRange`` = _prefix "shapes/TemperatureRange"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TemperatureRangeSKOS"></see>
    /// </summary>
    let ``shapes/TemperatureRangeSKOS`` = _prefix "shapes/TemperatureRangeSKOS"
    /// <summary>
    /// Indication of the part of the trans-European network the infrastructure element belongs to.
    /// <see href="http://data.europa.eu/949/tenClassification"></see></summary>
    let tenClassification = _prefix "tenClassification"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ten-classifications/TENClassifications"></see>
    /// </summary>
    let ``concepts/ten-classifications/TENClassifications`` =
        _prefix "concepts/ten-classifications/TENClassifications"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationS"></see>
    /// </summary>
    let ``shapes/TenClassificationS`` = _prefix "shapes/TenClassificationS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationT"></see>
    /// </summary>
    let ``shapes/TenClassificationT`` = _prefix "shapes/TenClassificationT"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationSKOSS"></see>
    /// </summary>
    let ``shapes/TenClassificationSKOSS`` = _prefix "shapes/TenClassificationSKOSS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationSKOST"></see>
    /// </summary>
    let ``shapes/TenClassificationSKOST`` = _prefix "shapes/TenClassificationSKOST"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationSKOSP"></see>
    /// </summary>
    let ``shapes/TenClassificationSKOSP`` = _prefix "shapes/TenClassificationSKOSP"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationPreDeprecationWarning"></see>
    /// </summary>
    let ``shapes/TenClassificationPreDeprecationWarning`` =
        _prefix "shapes/TenClassificationPreDeprecationWarning"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationP"></see>
    /// </summary>
    let ``shapes/TenClassificationP`` = _prefix "shapes/TenClassificationP"
    /// <summary>
    /// Indication of the GIS identity (GIS ID) of the section of TEN-T database to which the track belongs
    /// <see href="http://data.europa.eu/949/tenGISId"></see></summary>
    let tenGISId = _prefix "tenGISId"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenGISId"></see>
    /// </summary>
    let ``shapes/TenGISId`` = _prefix "shapes/TenGISId"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenGISIdApplicability"></see>
    /// </summary>
    let ``shapes/TenGISIdApplicability`` = _prefix "shapes/TenGISIdApplicability"
    /// <summary>
    /// Classification of the element according to its level in the Trans-European Transport Network (TEN-T).
    /// <see href="http://data.europa.eu/949/tentNetworkLevel"></see></summary>
    let tentNetworkLevel = _prefix "tentNetworkLevel"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ten-t-network-levels/TENTNetworkLevels"></see>
    /// </summary>
    let ``concepts/ten-t-network-levels/TENTNetworkLevels`` =
        _prefix "concepts/ten-t-network-levels/TENTNetworkLevels"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TentNetworkLevelSKOS"></see>
    /// </summary>
    let ``shapes/TentNetworkLevelSKOS`` = _prefix "shapes/TentNetworkLevelSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TentNetworkLevel"></see>
    /// </summary>
    let ``shapes/TentNetworkLevel`` = _prefix "shapes/TentNetworkLevel"
    /// <summary>
    /// Used to annotate properties coming from the TenT regulations, to be used for monitoring the provision of the data.
    /// <see href="http://data.europa.eu/949/tentReference"></see></summary>
    let tentReference = _prefix "tentReference"
    /// <summary>
    /// Thermal capacity distance. If no reference case is indicated.
    /// <see href="http://data.europa.eu/949/thermalCapacityDistance"></see></summary>
    let thermalCapacityDistance = _prefix "thermalCapacityDistance"
    /// <summary>
    /// Thermal capacity gradient. If no reference case is indicated.
    /// <see href="http://data.europa.eu/949/thermalCapacityGradient"></see></summary>
    let thermalCapacityGradient = _prefix "thermalCapacityGradient"
    /// <summary>
    /// Thermal capacity speed. If no reference case is indicated.
    /// <see href="http://data.europa.eu/949/thermalCapacitySpeed"></see></summary>
    let thermalCapacitySpeed = _prefix "thermalCapacitySpeed"
    /// <summary>
    /// Reference case of a TSI thermal capacity.
    /// <see href="http://data.europa.eu/949/thermalCapacityTSIReference"></see></summary>
    let thermalCapacityTSIReference = _prefix "thermalCapacityTSIReference"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/thermal-capacity/ThermalCapacityTSIReferences"></see>
    /// </summary>
    let ``concepts/thermal-capacity/ThermalCapacityTSIReferences`` =
        _prefix "concepts/thermal-capacity/ThermalCapacityTSIReferences"

    /// <summary>
    /// Thermal capacity time. If no reference case is indicated.
    /// <see href="http://data.europa.eu/949/thermalCapacityTime"></see></summary>
    let thermalCapacityTime = _prefix "thermalCapacityTime"
    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication whether tilting functions are supported by ETCS.
    /// <see href="http://data.europa.eu/949/tiltingSupported"></see></summary>
    let tiltingSupported = _prefix "tiltingSupported"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TiltingSupported"></see>
    /// </summary>
    let ``shapes/TiltingSupported`` = _prefix "shapes/TiltingSupported"
    /// <summary>
    /// Total vehicle mass (for each vehicle of the unit), given in kg.
    /// <see href="http://data.europa.eu/949/totalVehicleMass"></see></summary>
    let totalVehicleMass = _prefix "totalVehicleMass"
    /// <summary>
    /// The normal running direction is:
    /// - the same as the direction defined by the start and end of the SoL: (N)
    /// - the opposite to the direction defined by the start and end of the SoL: (O)
    /// - both directions: (B)
    /// <see href="http://data.europa.eu/949/trackDirection"></see></summary>
    let trackDirection = _prefix "trackDirection"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/track-running-directions/TrackRunningDirections"></see>
    /// </summary>
    let ``concepts/track-running-directions/TrackRunningDirections`` =
        _prefix "concepts/track-running-directions/TrackRunningDirections"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SoLTrackDirectionMinCount"></see>
    /// </summary>
    let ``shapes/SoLTrackDirectionMinCount`` =
        _prefix "shapes/SoLTrackDirectionMinCount"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackDirectionSKOS"></see>
    /// </summary>
    let ``shapes/TrackDirectionSKOS`` = _prefix "shapes/TrackDirectionSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SoLTrackDirectionMaxCount"></see>
    /// </summary>
    let ``shapes/SoLTrackDirectionMaxCount`` =
        _prefix "shapes/SoLTrackDirectionMaxCount"

    /// <summary>
    /// Unique track identification or unique track number within operational point or section of line
    /// <see href="http://data.europa.eu/949/trackId"></see></summary>
    let trackId = _prefix "trackId"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NoRepeatedTrackIdsSoL"></see>
    /// </summary>
    let ``shapes/NoRepeatedTrackIdsSoL`` = _prefix "shapes/NoRepeatedTrackIdsSoL"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackId"></see>
    /// </summary>
    let ``shapes/TrackId`` = _prefix "shapes/TrackId"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NoRepeatedTrackIdsOP"></see>
    /// </summary>
    let ``shapes/NoRepeatedTrackIdsOP`` = _prefix "shapes/NoRepeatedTrackIdsOP"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackLoadCapability"></see>
    /// </summary>
    let ``shapes/TrackLoadCapability`` = _prefix "shapes/TrackLoadCapability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackPhaseInfo"></see>
    /// </summary>
    let ``shapes/TrackPhaseInfo`` = _prefix "shapes/TrackPhaseInfo"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackPhaseInfoApplicability"></see>
    /// </summary>
    let ``shapes/TrackPhaseInfoApplicability`` =
        _prefix "shapes/TrackPhaseInfoApplicability"

    /// <summary>
    /// Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.
    /// <see href="http://data.europa.eu/949/trackRaisedPantographsDistanceAndSpeed"></see></summary>
    let trackRaisedPantographsDistanceAndSpeed =
        _prefix "trackRaisedPantographsDistanceAndSpeed"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackRaisedPantographsDistanceAndSpeed"></see>
    /// </summary>
    let ``shapes/TrackRaisedPantographsDistanceAndSpeed`` =
        _prefix "shapes/TrackRaisedPantographsDistanceAndSpeed"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackRaisedPantographDistanceAndSpeedApplicability"></see>
    /// </summary>
    let ``shapes/TrackRaisedPantographDistanceAndSpeedApplicability`` =
        _prefix "shapes/TrackRaisedPantographDistanceAndSpeedApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackSystemSeparationInfoApplicability"></see>
    /// </summary>
    let ``shapes/TrackSystemSeparationInfoApplicability`` =
        _prefix "shapes/TrackSystemSeparationInfoApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackSystemSeparationInfo"></see>
    /// </summary>
    let ``shapes/TrackSystemSeparationInfo`` =
        _prefix "shapes/TrackSystemSeparationInfo"

    /// <summary>
    /// Link between the running track and the HABD, covering the RINF parameters 1.1.1.1.7.(5-9)
    /// <see href="http://data.europa.eu/949/tracksideHabd"></see></summary>
    let tracksideHabd = _prefix "tracksideHabd"

    /// <summary>
    /// Special conditions implemented on-board to switch over between different train protection control and warning systems. Given as combination of systems installed on board ('System XX'_'System YY').
    /// <see href="http://data.europa.eu/949/trainControlSwitchOverSpecialConditions"></see></summary>
    let trainControlSwitchOverSpecialConditions =
        _prefix "trainControlSwitchOverSpecialConditions"

    /// <summary>
    /// Technical characteristics of the train detection systems installed in the section of line.
    /// <see href="http://data.europa.eu/949/trainDetectionSystem"></see></summary>
    let trainDetectionSystem = _prefix "trainDetectionSystem"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystem"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystem`` = _prefix "shapes/TrainDetectionSystem"
    /// <summary>
    /// Reference to the technical specification of train detection system, in accordance with the specification referenced in Appendix A-1, index [D]
    /// <see href="http://data.europa.eu/949/trainDetectionSystemSpecificCheck"></see></summary>
    let trainDetectionSystemSpecificCheck = _prefix "trainDetectionSystemSpecificCheck"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/train-detection-specific-checks/TrainDetectionSystemsSpecificChecks"></see>
    /// </summary>
    let ``concepts/train-detection-specific-checks/TrainDetectionSystemsSpecificChecks`` =
        _prefix "concepts/train-detection-specific-checks/TrainDetectionSystemsSpecificChecks"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckApplicability"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemSpecificCheckApplicability`` =
        _prefix "shapes/TrainDetectionSystemSpecificCheckApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckSKOS"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemSpecificCheckSKOS`` =
        _prefix "shapes/TrainDetectionSystemSpecificCheckSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheck"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemSpecificCheck`` =
        _prefix "shapes/TrainDetectionSystemSpecificCheck"

    /// <summary>
    /// Electronic document from the IM stored by the Agency with precise values in accordance with TSI CCS Article13 and the specification referenced in Appendix A-1, index [D], for the specific check to be performed for train detection systems identified in parameter "Type of track circuits or axle counters to which specific checks are needed".
    /// <see href="http://data.europa.eu/949/trainDetectionSystemSpecificCheckDocument"></see></summary>
    let trainDetectionSystemSpecificCheckDocument =
        _prefix "trainDetectionSystemSpecificCheckDocument"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckDocumentApplicability"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemSpecificCheckDocumentApplicability`` =
        _prefix "shapes/TrainDetectionSystemSpecificCheckDocumentApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckDocument"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemSpecificCheckDocument`` =
        _prefix "shapes/TrainDetectionSystemSpecificCheckDocument"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/train-detection/TrainDetectionSystems"></see>
    /// </summary>
    let ``concepts/train-detection/TrainDetectionSystems`` =
        _prefix "concepts/train-detection/TrainDetectionSystems"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemType"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemType`` = _prefix "shapes/TrainDetectionSystemType"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemTypeSKOS"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemTypeSKOS`` =
        _prefix "shapes/TrainDetectionSystemTypeSKOS"

    /// <summary>
    /// Indication whether train confirmation from on-board is required to access the line for safety reasons.
    /// <see href="http://data.europa.eu/949/trainIntegrityOnBoardRequired"></see></summary>
    let trainIntegrityOnBoardRequired = _prefix "trainIntegrityOnBoardRequired"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainIntegrityOnBoardRequired"></see>
    /// </summary>
    let ``shapes/TrainIntegrityOnBoardRequired`` =
        _prefix "shapes/TrainIntegrityOnBoardRequired"

    /// <summary>
    /// Indicates the suitability for transport on ferries.
    /// <see href="http://data.europa.eu/949/transportableOnFerry"></see></summary>
    let transportableOnFerry = _prefix "transportableOnFerry"
    /// <summary>
    /// Indicates if a certain property is TSI compliant.The reason for deprecation is that it is used in SKOS "OtherPantographHeads" and "TsiPantographHeads" to indicate in the first case if a SKOS concept is not tsiCompliant (false) and in the second case that the concept is tsiCompliant (true). These two SKOS were originally one SKOS, "PantographHeads". Currently with the two SKOS the property is redundant.
    /// <see href="http://data.europa.eu/949/tsiCompliant"></see></summary>
    let tsiCompliant = _prefix "tsiCompliant"
    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. TSI compliance of rules on the use of composite brake blocks.
    /// <see href="http://data.europa.eu/949/tsiCompliantCompositeBrakeBlocks"></see></summary>
    let tsiCompliantCompositeBrakeBlocks = _prefix "tsiCompliantCompositeBrakeBlocks"
    /// <summary>
    /// TSI compliance of Ferromagnetic characteristics of wheel material required. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantFerromagneticWheel"></see></summary>
    let tsiCompliantFerromagneticWheel = _prefix "tsiCompliantFerromagneticWheel"

    /// <summary>
    /// Indication whether required distance between two consecutive axles is compliant with the TSI. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantMaxDistConsecutiveAxles"></see></summary>
    let tsiCompliantMaxDistConsecutiveAxles =
        _prefix "tsiCompliantMaxDistConsecutiveAxles"

    /// <summary>
    /// TSI compliance of maximum permitted impedance between opposite wheels of a wheelset. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantMaxImpedanceWheelset"></see></summary>
    let tsiCompliantMaxImpedanceWheelset = _prefix "tsiCompliantMaxImpedanceWheelset"
    /// <summary>
    /// TSI compliance of rules for vehicle metal construction. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantMetalConstruction"></see></summary>
    let tsiCompliantMetalConstruction = _prefix "tsiCompliantMetalConstruction"
    /// <summary>
    /// TSI compliance of rules for metal-free space around wheels. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantMetalFreeSpace"></see></summary>
    let tsiCompliantMetalFreeSpace = _prefix "tsiCompliantMetalFreeSpace"
    /// <summary>
    /// TSI compliance of rules on combination of RST characteristics influencing shunting impedance. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantRSTShuntImpedance"></see></summary>
    let tsiCompliantRSTShuntImpedance = _prefix "tsiCompliantRSTShuntImpedance"
    /// <summary>
    /// TSI Compliance of rules on sand characteristics. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantSandCharacteristics"></see></summary>
    let tsiCompliantSandCharacteristics = _prefix "tsiCompliantSandCharacteristics"
    /// <summary>
    /// TSI compliance of sanding rules to allow compatibility with track circuits. Too much sand brings the risk of not detecting trains in tracks equipped with track circuits. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantSanding"></see></summary>
    let tsiCompliantSanding = _prefix "tsiCompliantSanding"
    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. TSI compliance of rules on shunt assisting devices.
    /// <see href="http://data.europa.eu/949/tsiCompliantShuntDevices"></see></summary>
    let tsiCompliantShuntDevices = _prefix "tsiCompliantShuntDevices"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TsiMagneticFields"></see>
    /// </summary>
    let ``shapes/TsiMagneticFields`` = _prefix "shapes/TsiMagneticFields"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TsiMagneticFieldsApplicability"></see>
    /// </summary>
    let ``shapes/TsiMagneticFieldsApplicability`` =
        _prefix "shapes/TsiMagneticFieldsApplicability"

    /// <summary>
    /// The index of a vocabulary term in Appendix D1 Vehicle and train Route compatibility checks.
    /// <see href="http://data.europa.eu/949/tsiOPEAppendixD1Index"></see></summary>
    let tsiOPEAppendixD1Index = _prefix "tsiOPEAppendixD1Index"
    /// <summary>
    /// Indication of TSI compliant pantograph heads which are allowed to be used.
    /// <see href="http://data.europa.eu/949/tsiPantographHead"></see></summary>
    let tsiPantographHead = _prefix "tsiPantographHead"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/compliant-pantograph-heads/CompliantPantographHeads"></see>
    /// </summary>
    let ``concepts/compliant-pantograph-heads/CompliantPantographHeads`` =
        _prefix "concepts/compliant-pantograph-heads/CompliantPantographHeads"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TsiPantographHeadSKOS"></see>
    /// </summary>
    let ``shapes/TsiPantographHeadSKOS`` = _prefix "shapes/TsiPantographHeadSKOS"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TsiPantographHeadApplicability"></see>
    /// </summary>
    let ``shapes/TsiPantographHeadApplicability`` =
        _prefix "shapes/TsiPantographHeadApplicability"

    /// <summary>
    /// Switches and crossings are maintained to in service limit dimension as specified in TSI.
    /// <see href="http://data.europa.eu/949/tsiSwitchCrossing"></see></summary>
    let tsiSwitchCrossing = _prefix "tsiSwitchCrossing"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TSISwitchCrossing"></see>
    /// </summary>
    let ``shapes/TSISwitchCrossing`` = _prefix "shapes/TSISwitchCrossing"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TsiTractionHarmonics"></see>
    /// </summary>
    let ``shapes/TsiTractionHarmonics`` = _prefix "shapes/TsiTractionHarmonics"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TsiTractionHarmonicsApplicability"></see>
    /// </summary>
    let ``shapes/TsiTractionHarmonicsApplicability`` =
        _prefix "shapes/TsiTractionHarmonicsApplicability"

    /// <summary>
    /// Electronic document available from the IM stored by the Agency with precise description of the clearance gauge and geometry of the tunnel.
    /// <see href="http://data.europa.eu/949/tunnelDocRef"></see></summary>
    let tunnelDocRef = _prefix "tunnelDocRef"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TunnelDocRef"></see>
    /// </summary>
    let ``shapes/TunnelDocRef`` = _prefix "shapes/TunnelDocRef"
    /// <summary>
    /// Unique tunnel identification or unique tunnel number within Member State
    /// <see href="http://data.europa.eu/949/tunnelIdentification"></see></summary>
    let tunnelIdentification = _prefix "tunnelIdentification"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TunnelIdentification"></see>
    /// </summary>
    let ``shapes/TunnelIdentification`` = _prefix "shapes/TunnelIdentification"
    /// <summary>
    /// Classification of the type of traffic carried on the element.
    /// <see href="http://data.europa.eu/949/typeOfTraffic"></see></summary>
    let typeOfTraffic = _prefix "typeOfTraffic"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/traffic-types/TrafficTypes"></see>
    /// </summary>
    let ``concepts/traffic-types/TrafficTypes`` =
        _prefix "concepts/traffic-types/TrafficTypes"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TypeOfTraffic"></see>
    /// </summary>
    let ``shapes/TypeOfTraffic`` = _prefix "shapes/TypeOfTraffic"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TypeOfTrafficSKOS"></see>
    /// </summary>
    let ``shapes/TypeOfTrafficSKOS`` = _prefix "shapes/TypeOfTrafficSKOS"
    /// <summary>
    /// Indicates the registrationVersion with Ids 10, 20 and 30 indicating registration according to Directive 2008/57/EC and implementing Decision 2011/665/EU, and 40 and 50 indicating registration according to regime described in Directive 2008/57/EC.
    /// The allowed values for this property belong to the SKOS Concept Scheme http://data.europa.eu/949/concepts/type-version-ids/TypeVersionIds.
    /// <see href="http://data.europa.eu/949/typeVersionId"></see></summary>
    let typeVersionId = _prefix "typeVersionId"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/type-version-ids/TypeVersionIds"></see>
    /// </summary>
    let ``concepts/type-version-ids/TypeVersionIds`` =
        _prefix "concepts/type-version-ids/TypeVersionIds"

    /// <summary>
    /// Serial number that identifies a vehicle type.
    /// <see href="http://data.europa.eu/949/typeVersionNumber"></see></summary>
    let typeVersionNumber = _prefix "typeVersionNumber"
    /// <summary>
    /// Highest non-permanent voltage (Umax2) for France on lines not compliant with values defined in the EN50163:2004+A1:2007+A2:2020+A3:2022
    /// <see href="http://data.europa.eu/949/umax2"></see></summary>
    let umax2 = _prefix "umax2"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Umax2"></see>
    /// </summary>
    let ``shapes/Umax2`` = _prefix "shapes/Umax2"
    /// <summary>
    /// Code composed of country code and alphanumeric operational point code.
    /// <see href="http://data.europa.eu/949/uopid"></see></summary>
    let uopid = _prefix "uopid"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/UopidP"></see>
    /// </summary>
    let ``shapes/UopidP`` = _prefix "shapes/UopidP"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BorderPointValidCodeAndCoordinates"></see>
    /// </summary>
    let ``shapes/BorderPointValidCodeAndCoordinates`` =
        _prefix "shapes/BorderPointValidCodeAndCoordinates"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BorderPointUopidPrefix"></see>
    /// </summary>
    let ``shapes/BorderPointUopidPrefix`` = _prefix "shapes/BorderPointUopidPrefix"
    /// <summary>
    /// Indication if group 555 is used.
    /// <see href="http://data.europa.eu/949/usesGroup555"></see></summary>
    let usesGroup555 = _prefix "usesGroup555"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/UsesGroup555Applicability"></see>
    /// </summary>
    let ``shapes/UsesGroup555Applicability`` =
        _prefix "shapes/UsesGroup555Applicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/UsesGroup555"></see>
    /// </summary>
    let ``shapes/UsesGroup555`` = _prefix "shapes/UsesGroup555"
    /// <summary>
    /// Speed limit allowing the driver to select the  override  function in km/h
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/vNvallowovtrp"></see></summary>
    let vNvallowovtrp = _prefix "vNvallowovtrp"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VNvallowovtrpApplicability"></see>
    /// </summary>
    let ``shapes/VNvallowovtrpApplicability`` =
        _prefix "shapes/VNvallowovtrpApplicability"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VNvallowovtrp"></see>
    /// </summary>
    let ``shapes/VNvallowovtrp`` = _prefix "shapes/VNvallowovtrp"
    /// <summary>
    /// Override speed limit to be supervised when the "override" function is active in km/h.
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/vNvsupovtrp"></see></summary>
    let vNvsupovtrp = _prefix "vNvsupovtrp"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VNvsupovtrpApplicability"></see>
    /// </summary>
    let ``shapes/VNvsupovtrpApplicability`` = _prefix "shapes/VNvsupovtrpApplicability"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VNvsupovtrp"></see>
    /// </summary>
    let ``shapes/VNvsupovtrp`` = _prefix "shapes/VNvsupovtrp"
    /// <summary>
    /// Relates a feature with a temporal feature to indicate a validity period.
    /// <see href="http://data.europa.eu/949/validity"></see></summary>
    let validity = _prefix "validity"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Validity"></see>
    /// </summary>
    let ``shapes/Validity`` = _prefix "shapes/Validity"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/validityEndDate"></see>
    /// </summary>
    let validityEndDate = _prefix "validityEndDate"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/validityStartDate"></see>
    /// </summary>
    let validityStartDate = _prefix "validityStartDate"
    /// <summary>
    /// Mean contact force.
    /// <see href="http://data.europa.eu/949/vehicleContactForce"></see></summary>
    let vehicleContactForce = _prefix "vehicleContactForce"
    /// <summary>
    /// Vehicle kinematic gauge  that corresponds to other gauges assessed using the kinematic method
    /// <see href="http://data.europa.eu/949/vehicleKinematicGaugeOther"></see></summary>
    let vehicleKinematicGaugeOther = _prefix "vehicleKinematicGaugeOther"
    /// <summary>
    /// Vehicle Maximum sanding output, given in grams per second.
    /// <see href="http://data.europa.eu/949/vehicleMaxSandingOutput"></see></summary>
    let vehicleMaxSandingOutput = _prefix "vehicleMaxSandingOutput"
    /// <summary>
    /// Identification number of a vehicle or wagon.
    /// <see href="http://data.europa.eu/949/vehicleNumber"></see></summary>
    let vehicleNumber = _prefix "vehicleNumber"
    /// <summary>
    /// Pantograph head geometry (to be indicated for each energy supply system the vehicle is equipped for).
    /// <see href="http://data.europa.eu/949/vehiclePantographHead"></see></summary>
    let vehiclePantographHead = _prefix "vehiclePantographHead"
    /// <summary>
    /// Manufacturing series of a vehicle.
    /// <see href="http://data.europa.eu/949/vehicleSeries"></see></summary>
    let vehicleSeries = _prefix "vehicleSeries"
    /// <summary>
    /// Indicates the vehicle type of a specific vehicle or wagon.
    /// <see href="http://data.europa.eu/949/vehicleType"></see></summary>
    let vehicleType = _prefix "vehicleType"
    /// <summary>
    /// The infrastructure managers shall provide through RINF the information to the RU regarding list of vehicle types compatible with the route for which they have already verified compatibility for parameter Traffic load and load carrying capacity of infrastructure and train detection systems, where such information is available.
    /// <see href="http://data.europa.eu/949/vehicleTypesCompatibleTrafficLoad"></see></summary>
    let vehicleTypesCompatibleTrafficLoad = _prefix "vehicleTypesCompatibleTrafficLoad"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/verifiedRccObjParameter"></see>
    /// </summary>
    let verifiedRccObjParameter = _prefix "verifiedRccObjParameter"
    /// <summary>
    /// The infrastructure managers shall provide through RINF the information or a document to the RU regarding list of vehicles compatible with the route for which they have already verified compatibility for parameter Traffic load and load carrying capacity of infrastructure and train detection systems, where such information is available.
    /// <see href="http://data.europa.eu/949/vehiclesCompatibleTrafficLoad"></see></summary>
    let vehiclesCompatibleTrafficLoad = _prefix "vehiclesCompatibleTrafficLoad"
    /// <summary>
    /// Number of vehicles composing the fixed formation (for fixed formation only). Note: the value is mandatory for all vehicle categories. If the vehicle is composed of only one car, the indicated value shall be '1'.
    /// <see href="http://data.europa.eu/949/vehiclesComposingFixedFormation"></see></summary>
    let vehiclesComposingFixedFormation = _prefix "vehiclesComposingFixedFormation"
    /// <summary>
    /// Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/verificationCCS"></see></summary>
    let verificationCCS = _prefix "verificationCCS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VerificationCCS"></see>
    /// </summary>
    let ``shapes/VerificationCCS`` = _prefix "shapes/VerificationCCS"
    /// <summary>
    /// Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/verificationENE"></see></summary>
    let verificationENE = _prefix "verificationENE"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VerificationENE"></see>
    /// </summary>
    let ``shapes/VerificationENE`` = _prefix "shapes/VerificationENE"
    /// <summary>
    /// Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/verificationINF"></see></summary>
    let verificationINF = _prefix "verificationINF"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VerificationINF"></see>
    /// </summary>
    let ``shapes/VerificationINF`` = _prefix "shapes/VerificationINF"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VerificationINFS"></see>
    /// </summary>
    let ``shapes/VerificationINFS`` = _prefix "shapes/VerificationINFS"
    /// <summary>
    /// Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/verificationSRT"></see></summary>
    let verificationSRT = _prefix "verificationSRT"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VerificationSRT"></see>
    /// </summary>
    let ``shapes/VerificationSRT`` = _prefix "shapes/VerificationSRT"
    /// <summary>
    /// Voice SIM Card GSM-R Home Network. The allowed values for this property belong to the SKOS Concept Scheme http://data.europa.eu/949/concepts/gsmr-networks/GSMRNetworks
    /// <see href="http://data.europa.eu/949/voiceGSMRNetwork"></see></summary>
    let voiceGSMRNetwork = _prefix "voiceGSMRNetwork"
    /// <summary>
    /// Voice and operational communication implementation.
    /// <see href="http://data.europa.eu/949/voiceOperationalCommImpl"></see></summary>
    let voiceOperationalCommImpl = _prefix "voiceOperationalCommImpl"
    /// <summary>
    /// Radio requirements used for demonstrating technical compatibility voice.
    /// <see href="http://data.europa.eu/949/voiceRadioCompatible"></see></summary>
    let voiceRadioCompatible = _prefix "voiceRadioCompatible"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/radio-system-compatibilities-voice/RadioSystemCompatibilitiesVoice"></see>
    /// </summary>
    let ``concepts/radio-system-compatibilities-voice/RadioSystemCompatibilitiesVoice`` =
        _prefix "concepts/radio-system-compatibilities-voice/RadioSystemCompatibilitiesVoice"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VoiceRadioCompatibleSKOS"></see>
    /// </summary>
    let ``shapes/VoiceRadioCompatibleSKOS`` = _prefix "shapes/VoiceRadioCompatibleSKOS"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VoiceRadioCompatible"></see>
    /// </summary>
    let ``shapes/VoiceRadioCompatible`` = _prefix "shapes/VoiceRadioCompatible"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VoiceRadioCompatibleApplicability"></see>
    /// </summary>
    let ``shapes/VoiceRadioCompatibleApplicability`` =
        _prefix "shapes/VoiceRadioCompatibleApplicability"

    /// <summary>
    /// A single value expressed in millimetres that identifies the track gauge.
    /// <see href="http://data.europa.eu/949/wheelSetGauge"></see></summary>
    let wheelSetGauge = _prefix "wheelSetGauge"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/nominal-track-gauges/NominalTrackGauges"></see>
    /// </summary>
    let ``concepts/nominal-track-gauges/NominalTrackGauges`` =
        _prefix "concepts/nominal-track-gauges/NominalTrackGauges"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/WheelSetGauge"></see>
    /// </summary>
    let ``shapes/WheelSetGauge`` = _prefix "shapes/WheelSetGauge"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/WheelSetGaugeSKOS"></see>
    /// </summary>
    let ``shapes/WheelSetGaugeSKOS`` = _prefix "shapes/WheelSetGaugeSKOS"
    /// <summary>
    /// Wheelset gauge changeover facility. The allowed values for this property belong to the SKOS Concept Scheme http://data.europa.eu/949/concepts/gauge-changeover-facilities/GaugeChangeoverFacilities
    /// <see href="http://data.europa.eu/949/wheelSetGaugeChangeoverFacility"></see></summary>
    let wheelSetGaugeChangeoverFacility = _prefix "wheelSetGaugeChangeoverFacility"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gauge-changeover-facilities/GaugeChangeoverFacilities"></see>
    /// </summary>
    let ``concepts/gauge-changeover-facilities/GaugeChangeoverFacilities`` =
        _prefix "concepts/gauge-changeover-facilities/GaugeChangeoverFacilities"

    /// <summary>
    /// Wheel gauge transformation method. Defined if more than one wheel gauges have been selected.
    /// <see href="http://data.europa.eu/949/wheelSetGaugeTransformationMethod"></see></summary>
    let wheelSetGaugeTransformationMethod = _prefix "wheelSetGaugeTransformationMethod"
    /// <summary>
    /// Number of wheelchair accessible sleeping places.
    /// <see href="http://data.europa.eu/949/wheelchairSleepingPlaces"></see></summary>
    let wheelchairSleepingPlaces = _prefix "wheelchairSleepingPlaces"
    /// <summary>
    /// Number of wheelchair spaces.
    /// <see href="http://data.europa.eu/949/wheelchairSpaces"></see></summary>
    let wheelchairSpaces = _prefix "wheelchairSpaces"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GeometryShape"></see>
    /// </summary>
    let ``shapes/GeometryShape`` = _prefix "shapes/GeometryShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AsWKT"></see>
    /// </summary>
    let ``shapes/AsWKT`` = _prefix "shapes/AsWKT"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BorderPointValidCoordinates"></see>
    /// </summary>
    let ``shapes/BorderPointValidCoordinates`` =
        _prefix "shapes/BorderPointValidCoordinates"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BorderPointValidCoordinatesViaNetReference"></see>
    /// </summary>
    let ``shapes/BorderPointValidCoordinatesViaNetReference`` =
        _prefix "shapes/BorderPointValidCoordinatesViaNetReference"

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasGeometry"></see>
    /// </summary>
    let ``shapes/HasGeometry`` = _prefix "shapes/HasGeometry"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InstantShape"></see>
    /// </summary>
    let ``shapes/InstantShape`` = _prefix "shapes/InstantShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TemporalDurationShape"></see>
    /// </summary>
    let ``shapes/TemporalDurationShape`` = _prefix "shapes/TemporalDurationShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TemporalEntityShape"></see>
    /// </summary>
    let ``shapes/TemporalEntityShape`` = _prefix "shapes/TemporalEntityShape"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasBeginning"></see>
    /// </summary>
    let ``shapes/HasBeginning`` = _prefix "shapes/HasBeginning"
    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasEnd"></see>
    /// </summary>
    let ``shapes/HasEnd`` = _prefix "shapes/HasEnd"
