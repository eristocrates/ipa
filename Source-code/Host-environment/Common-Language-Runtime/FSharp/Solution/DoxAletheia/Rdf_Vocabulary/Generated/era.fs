namespace http.data.europa.eu._949.slash

open DoxAletheia.Rdf_Vocabulary

module era =
    let _namespace_name = "http://data.europa.eu/949/"

    /// <summary>
    /// A set of different infrastructure objects sharing the same common technical characteristics. The parameters may not be restricted to only one railway subsystem, but it can include common characteristics from each one of them (infrastructure, energy, track-side CCS)
    /// <see href="http://data.europa.eu/949/CommonCharacteristicsSubset"></see></summary>
    let CommonCharacteristicsSubset =
        Namespaced_IRI.parse _namespace_name "CommonCharacteristicsSubset" |> NamespacedName

    /// <summary>
    /// A running track means any track used for train service movements; passing loops and meeting loops on plain line or track connections only required for train operation are not published
    /// <see href="http://data.europa.eu/949/RunningTrack"></see></summary>
    let RunningTrack =
        Namespaced_IRI.parse _namespace_name "RunningTrack" |> NamespacedName

    /// <summary>
    /// A railway tunnel is an excavation or a construction around the track provided to allow the railway to pass for example higher land, buildings or water.
    /// <see href="http://data.europa.eu/949/Tunnel"></see></summary>
    let Tunnel = Namespaced_IRI.parse _namespace_name "Tunnel" |> NamespacedName

    /// <summary>
    /// A section of line means the part of line between adjacent operational points and may consist of several tracks.
    /// <see href="http://data.europa.eu/949/SectionOfLine"></see></summary>
    let SectionOfLine =
        Namespaced_IRI.parse _namespace_name "SectionOfLine" |> NamespacedName

    /// <summary>
    /// Platform for the purpose of RINF is understood as a platform edge. A platform concerns only the part of the structure neighbouring to the track (interfaced with trains).
    /// <see href="http://data.europa.eu/949/PlatformEdge"></see></summary>
    let PlatformEdge =
        Namespaced_IRI.parse _namespace_name "PlatformEdge" |> NamespacedName

    /// <summary>
    /// A vehicle type that has been authorized to operate on the EU railway infrastructure. Type means a vehicle type defining the basic design characteristics of the vehicle as covered by a type or design examination certificate described in the relevant verification module.
    ///
    /// Basic design characteristics means the parameters that are used to identify the vehicle type as specified in the issued vehicle type authorisation and recorded in the European Register of Authorised Vehicle Types ('ERATV').
    ///
    /// The above mentioned certificate should be documented using era:certificate.
    ///
    /// <see href="http://data.europa.eu/949/VehicleType"></see></summary>
    let VehicleType =
        Namespaced_IRI.parse _namespace_name "VehicleType" |> NamespacedName

    /// <summary>
    /// Sidings are all those tracks where running trains in service movements ends and which are not used for operational routing of a train.
    /// <see href="http://data.europa.eu/949/Siding"></see></summary>
    let Siding = Namespaced_IRI.parse _namespace_name "Siding" |> NamespacedName

    /// <summary>
    /// Safety system used to detect the presence of vehicles on the railway track.
    /// <see href="http://data.europa.eu/949/TrainDetectionSystem"></see></summary>
    let TrainDetectionSystem =
        Namespaced_IRI.parse _namespace_name "TrainDetectionSystem" |> NamespacedName

    /// <summary>
    /// System that is used to transmit electrical energy to road or rail vehicles.
    /// <see href="http://data.europa.eu/949/ContactLineSystem"></see></summary>
    let ContactLineSystem =
        Namespaced_IRI.parse _namespace_name "ContactLineSystem" |> NamespacedName

    /// <summary>
    /// This class encompasses all those classes that represent features that are  implemented in the European railway infrastructure. It is a subclass of the ERA Feature that has a spatial representation. It covers tracks, platforms, signals, tunnels, operational points, and sections of line.
    /// A feature that belongs to the infrastructure can be abstracted (hasAbstraction) as a topological object. It also is related to the infrastructure manager through the property infrastructureMgr.
    /// <see href="http://data.europa.eu/949/InfrastructureElement"></see></summary>
    let InfrastructureElement =
        Namespaced_IRI.parse _namespace_name "InfrastructureElement" |> NamespacedName

    /// <summary>
    /// A pair of rails over which rail borne vehicles can run.
    /// <see href="http://data.europa.eu/949/Track"></see></summary>
    let Track = Namespaced_IRI.parse _namespace_name "Track" |> NamespacedName

    /// <summary>
    /// Represents a linear positioning system used for referencing positions on the network.
    /// It can also represent a sequence of one or more sections of line, used for regular railway operations.
    /// <see href="http://data.europa.eu/949/LinearPositioningSystem"></see></summary>
    let LinearPositioningSystem =
        Namespaced_IRI.parse _namespace_name "LinearPositioningSystem" |> NamespacedName

    /// <summary>
    /// An operational point (OP) means any location for train service operations, where train services may begin and end or change route, and where passenger or freight services may be provided; operational point also means any location at boundaries between Member States or infrastructure managers.
    /// <see href="http://data.europa.eu/949/OperationalPoint"></see></summary>
    let OperationalPoint =
        Namespaced_IRI.parse _namespace_name "OperationalPoint" |> NamespacedName

    /// <summary>
    /// A railway signal is a visual display device (next to the tracks or via a DMI in the cabin) that conveys instructions or provides advance warning of instructions regarding the driver's authority to proceed.
    /// <see href="http://data.europa.eu/949/Signal"></see></summary>
    let Signal = Namespaced_IRI.parse _namespace_name "Signal" |> NamespacedName
    /// <summary>
    /// TSI compliant train protection system ERTMS / ETCS application level and baseline related to the track side equipment.
    /// <see href="http://data.europa.eu/949/ETCS"></see></summary>
    let ETCS = Namespaced_IRI.parse _namespace_name "ETCS" |> NamespacedName

    /// <summary>
    /// A reference to a specific railway line.
    /// <see href="http://data.europa.eu/949/LineReference"></see></summary>
    let LineReference =
        Namespaced_IRI.parse _namespace_name "LineReference" |> NamespacedName

    /// <summary>
    /// It is a structure constructed for the exclusive purpose of carrying railroad traffic across an obstruction. It can be used for defining non-stopping areas, big metal mass, resistance to traffic load etc.
    /// <see href="http://data.europa.eu/949/Bridge"></see></summary>
    let Bridge = Namespaced_IRI.parse _namespace_name "Bridge" |> NamespacedName
    /// <summary>
    /// Document in any of the ERA systems, e.g. reference document in RINF.
    /// <see href="http://data.europa.eu/949/Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    /// A specific vehicle or wagon able and allowed to operate over railway infrastructure.
    /// <see href="http://data.europa.eu/949/Vehicle"></see></summary>
    let Vehicle = Namespaced_IRI.parse _namespace_name "Vehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/MinAxleLoadVehicleCategory"></see>
    /// </summary>
    let MinAxleLoadVehicleCategory =
        Namespaced_IRI.parse _namespace_name "MinAxleLoadVehicleCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/_:genid-nodeid-node1jfsuh0nsx2"></see>
    /// </summary>
    let ``_:genid-nodeid-node1jfsuh0nsx2`` =
        Namespaced_IRI.parse _namespace_name "_:genid-nodeid-node1jfsuh0nsx2" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/_:genid-nodeid-node1jfsuh0nsx3"></see>
    /// </summary>
    let ``_:genid-nodeid-node1jfsuh0nsx3`` =
        Namespaced_IRI.parse _namespace_name "_:genid-nodeid-node1jfsuh0nsx3" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/_:genid-nodeid-node1jfsuh0nsx4"></see>
    /// </summary>
    let ``_:genid-nodeid-node1jfsuh0nsx4`` =
        Namespaced_IRI.parse _namespace_name "_:genid-nodeid-node1jfsuh0nsx4" |> NamespacedName

    /// <summary>
    /// Is an organisation or a physical person
    /// <see href="http://data.europa.eu/949/Body"></see></summary>
    let Body = Namespaced_IRI.parse _namespace_name "Body" |> NamespacedName

    /// <summary>
    /// Annotation used to point to the SHACL shape that implements the validation for a certain RINF parameter (property). Each shape contains constraints for valid datatypes, patterns, min and max count, valid SKOS values and business rules.
    /// <see href="http://data.europa.eu/949/shaclShapeValidationRule"></see></summary>
    let shaclShapeValidationRule =
        Namespaced_IRI.parse _namespace_name "shaclShapeValidationRule" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BodyShape"></see>
    /// </summary>
    let ``shapes/BodyShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/BodyShape" |> NamespacedName

    /// <summary>
    /// The natural or legal person that, being the owner of a vehicle or having the right to use it,
    /// exploits the vehicle as a means of transport and is registered as such in a vehicle register referred to in Article 47 of (EU)2016/797.
    /// <see href="http://data.europa.eu/949/VehicleKeeper"></see></summary>
    let VehicleKeeper =
        Namespaced_IRI.parse _namespace_name "VehicleKeeper" |> NamespacedName

    /// <summary>
    /// (deprecated) Replaced by the era:Body class and era:manufacturer property. A company or organization that manufactures vehicles.
    /// <see href="http://data.europa.eu/949/Manufacturer"></see></summary>
    let Manufacturer =
        Namespaced_IRI.parse _namespace_name "Manufacturer" |> NamespacedName

    /// <summary>
    /// (deprecated) The infrastructure manager owns and operates the railway network and related infrastructure.
    /// <see href="http://data.europa.eu/949/InfrastructureManager"></see></summary>
    let InfrastructureManager =
        Namespaced_IRI.parse _namespace_name "InfrastructureManager" |> NamespacedName

    /// <summary>
    /// Represents an n-ary relationship between a Body and a role
    /// <see href="http://data.europa.eu/949/OrganisationRole"></see></summary>
    let OrganisationRole =
        Namespaced_IRI.parse _namespace_name "OrganisationRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BridgeShape"></see>
    /// </summary>
    let ``shapes/BridgeShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/BridgeShape" |> NamespacedName

    /// <summary>
    /// Encompasses all those areas (outside of the operational gauge) or sections (those in tunnels excluded) which influence operation in the gauge itself, such as
    /// - safe areas,
    /// - restricted areas (non-stopping areas or industrial risk locations).
    ///
    /// For these areas in tunnels, use era:SpecialTunnelArea.
    /// <see href="http://data.europa.eu/949/SpecialArea"></see></summary>
    let SpecialArea =
        Namespaced_IRI.parse _namespace_name "SpecialArea" |> NamespacedName

    /// <summary>
    /// Primary Location is a place used by IM to define a path for a train in TAF/TAP TSI framework/messages. This location is a rail point inside the rail network where train starts, ends, stops, or runs through or change line. This location must be managed by an Infrastructure Manager (IM) identified by company code.
    ///
    /// Primary locations are identified by single and unique Primary Location codes. Primary location code is allocated based on processes defined by national entity. Primary location codes are used in any kind of TAF/TAP communication.
    ///
    /// See: Handbook 9.3.3 / page 60
    /// <see href="http://data.europa.eu/949/PrimaryLocation"></see></summary>
    let PrimaryLocation =
        Namespaced_IRI.parse _namespace_name "PrimaryLocation" |> NamespacedName

    /// <summary>
    /// Represents a kilometric post in the linear positioning system.
    /// <see href="http://data.europa.eu/949/KilometricPost"></see></summary>
    let KilometricPost =
        Namespaced_IRI.parse _namespace_name "KilometricPost" |> NamespacedName

    /// <summary>
    /// ETCS trackside centralised unit controlling ETCS train movements in level 2.
    ///
    /// A centralised safety unit that receives train position information via radio and sends movement authorities via radio to trains.
    /// <see href="http://data.europa.eu/949/RadioBlockCenter"></see></summary>
    let RadioBlockCenter =
        Namespaced_IRI.parse _namespace_name "RadioBlockCenter" |> NamespacedName

    /// <summary>
    /// A unit of track comprising two fixed rails (stock rails) and two movable rails (switch rails) used to direct vehicles from one track to another track.
    /// <see href="http://data.europa.eu/949/Switch"></see></summary>
    let Switch = Namespaced_IRI.parse _namespace_name "Switch" |> NamespacedName

    /// <summary>
    /// A level crossing is an intersection where a railway line crosses a road or a path at the same level. It can be used for the implementation of the ETCS trackside or to identify potential collision scenarios
    /// <see href="http://data.europa.eu/949/LevelCrossing"></see></summary>
    let LevelCrossing =
        Namespaced_IRI.parse _namespace_name "LevelCrossing" |> NamespacedName

    /// <summary>
    /// A trackside Hot Axle Box Detector (HABD), necessary for the route compatibility check.
    /// Specific for the French, Italian and Swedish networks
    /// <see href="http://data.europa.eu/949/HABD"></see></summary>
    let HABD = Namespaced_IRI.parse _namespace_name "HABD" |> NamespacedName

    /// <summary>
    /// Certificate of a vehicle type. Can be in one of the following states: Amended, New, Suspended, Withdrawn.
    /// <see href="http://data.europa.eu/949/Certificate"></see></summary>
    let Certificate =
        Namespaced_IRI.parse _namespace_name "Certificate" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CommonCharacteristicsSubsetShape"></see>
    /// </summary>
    let ``shapes/CommonCharacteristicsSubsetShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/CommonCharacteristicsSubsetShape" |> NamespacedName

    /// <summary>
    /// Class that encompasses the features that are part of the physical infrastructure (class InfrastructureElement) and the topological objects (class TopologicalObject). It is a subclass of the geographical Feature class that has a spatial representation.
    /// <see href="http://data.europa.eu/949/Feature"></see></summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactLineSystemShape"></see>
    /// </summary>
    let ``shapes/ContactLineSystemShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/ContactLineSystemShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DocumentShape"></see>
    /// </summary>
    let ``shapes/DocumentShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/DocumentShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ETCSShape"></see>
    /// </summary>
    let ``shapes/ETCSShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/ETCSShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FeatureShape"></see>
    /// </summary>
    let ``shapes/FeatureShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/FeatureShape" |> NamespacedName

    /// <summary>
    /// The union of TemporalDuration that represents a time extent and TemporalEntity that represents a temporal interval or instant.
    /// <see href="http://data.europa.eu/949/TemporalFeature"></see></summary>
    let TemporalFeature =
        Namespaced_IRI.parse _namespace_name "TemporalFeature" |> NamespacedName

    /// <summary>
    /// Specific for route compatibility check on French network.
    /// <see href="http://data.europa.eu/949/FrenchTrainDetectionSystemLimitation"></see></summary>
    let FrenchTrainDetectionSystemLimitation =
        Namespaced_IRI.parse _namespace_name "FrenchTrainDetectionSystemLimitation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationShape"></see>
    /// </summary>
    let ``shapes/FrenchTrainDetectionSystemLimitationShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/FrenchTrainDetectionSystemLimitationShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InfrastructureElementShape"></see>
    /// </summary>
    let ``shapes/InfrastructureElementShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/InfrastructureElementShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/KilometricPostShape"></see>
    /// </summary>
    let ``shapes/KilometricPostShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/KilometricPostShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LevelCrossingShape"></see>
    /// </summary>
    let ``shapes/LevelCrossingShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/LevelCrossingShape" |> NamespacedName

    /// <summary>
    /// Pieces of tracks composing the topology
    /// <see href="http://data.europa.eu/949/LinearElement"></see></summary>
    let LinearElement =
        Namespaced_IRI.parse _namespace_name "LinearElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinearElementShape"></see>
    /// </summary>
    let ``shapes/LinearElementShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/LinearElementShape" |> NamespacedName

    /// <summary>
    /// It is a representation of all building blocks of the topology. It references an associated topological network element.
    /// <see href="http://data.europa.eu/949/NetElement"></see></summary>
    let NetElement = Namespaced_IRI.parse _namespace_name "NetElement" |> NamespacedName

    /// <summary>
    /// Represents a non-linear element in the network.
    /// <see href="http://data.europa.eu/949/NonLinearElement"></see></summary>
    let NonLinearElement =
        Namespaced_IRI.parse _namespace_name "NonLinearElement" |> NamespacedName

    /// <summary>
    /// Represents a section of a linear element.
    /// <see href="http://data.europa.eu/949/LinearElementSection"></see></summary>
    let LinearElementSection =
        Namespaced_IRI.parse _namespace_name "LinearElementSection" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinearElementSectionShape"></see>
    /// </summary>
    let ``shapes/LinearElementSectionShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/LinearElementSectionShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinearPositioningSystemShape"></see>
    /// </summary>
    let ``shapes/LinearPositioningSystemShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/LinearPositioningSystemShape" |> NamespacedName

    /// <summary>
    /// Represents coordinates in a linear positioning system.
    /// <see href="http://data.europa.eu/949/LinearPositioningSystemCoordinate"></see></summary>
    let LinearPositioningSystemCoordinate =
        Namespaced_IRI.parse _namespace_name "LinearPositioningSystemCoordinate" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinearPositioningSystemCoordinateShape"></see>
    /// </summary>
    let ``shapes/LinearPositioningSystemCoordinateShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/LinearPositioningSystemCoordinateShape" |> NamespacedName

    /// <summary>
    /// Frequency, appearance and positioning of a sign indicating distance as reference post. Two types of signs are normally available: kilometre post and hectometre post.
    /// - A kilometre post is a lineside sign indicating the distance from a specific point, usually being the starting point of the railway line.
    /// - A hectometre post is a lineside sign indicating a relative distance.
    /// <see href="http://data.europa.eu/949/LinesideDistanceIndication"></see></summary>
    let LinesideDistanceIndication =
        Namespaced_IRI.parse _namespace_name "LinesideDistanceIndication" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationShape"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/LinesideDistanceIndicationShape" |> NamespacedName

    /// <summary>
    /// This class together with properties loadCapabilityLineCategory and loadCapabilitySpeed replaces the previous loadCapability SKOS property.
    /// A combination of the line category and speed at the weakest point of the track.
    /// Each track can have several load capability (structured) values, and each one has values for load model line category and load model speed.
    /// <see href="http://data.europa.eu/949/LoadCapability"></see></summary>
    let LoadCapability =
        Namespaced_IRI.parse _namespace_name "LoadCapability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LoadCapabilityShape"></see>
    /// </summary>
    let ``shapes/LoadCapabilityShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/LoadCapabilityShape" |> NamespacedName

    /// <summary>
    /// A combination of the line category and speed at the weakest point of the track. The reason for deprecation is that the load capability property 1.1.1.1.2.4 was defined incorrectly as a SKOS property. It is composed of two values: (1)  line category, and (2) speed. Only line category is a list of predefined values (SKOS), whereas speed is an integer (according to the RINF application guide).
    /// <see href="http://data.europa.eu/949/loadCapability"></see></summary>
    let loadCapability =
        Namespaced_IRI.parse _namespace_name "loadCapability" |> NamespacedName

    /// <summary>
    /// Vehicle manufacturer company.
    /// <see href="http://data.europa.eu/949/manufacturer"></see></summary>
    let manufacturer =
        Namespaced_IRI.parse _namespace_name "manufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/MaximumMagneticField"></see>
    /// </summary>
    let MaximumMagneticField =
        Namespaced_IRI.parse _namespace_name "MaximumMagneticField" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumMagneticFieldShape"></see>
    /// </summary>
    let ``shapes/MaximumMagneticFieldShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaximumMagneticFieldShape" |> NamespacedName

    /// <summary>
    /// Indication of types of train detection systems installed.
    /// <see href="http://data.europa.eu/949/trainDetectionSystemType"></see></summary>
    let trainDetectionSystemType =
        Namespaced_IRI.parse _namespace_name "trainDetectionSystemType" |> NamespacedName

    /// <summary>
    /// Combination of maximum speed and maximum cant deficiency for which the vehicle was assessed.
    /// <see href="http://data.europa.eu/949/MaximumSpeedAndCantDeficiency"></see></summary>
    let MaximumSpeedAndCantDeficiency =
        Namespaced_IRI.parse _namespace_name "MaximumSpeedAndCantDeficiency" |> NamespacedName

    /// <summary>
    /// Combination of maximum speed and maximum cant deficiency for which the vehicle was assessed.
    ///
    /// This property was before an object skos property. The values for this property do not come from a list of predefined values. Thus, the original object property was replaced by this datatype property with range xsd:string.
    /// Deprecated because of replacement by a class and two integer properties. The reason is that the property represents two concepts: [number] km/h for maximum speed - [number] mm for maximum cant deficiency.
    /// <see href="http://data.europa.eu/949/maximumSpeedAndCantDeficiency"></see></summary>
    let maximumSpeedAndCantDeficiency =
        Namespaced_IRI.parse _namespace_name "maximumSpeedAndCantDeficiency" |> NamespacedName

    /// <summary>
    /// Impedance as defined in the TSI CCS (Annex I, Appendix A, Table A.2 -Index 77).
    ///
    /// Minimum vehicle impedance (between wheels and pantograph) (only for vehicles equipped for 1500V or 3000V DC).
    ///
    /// Per Voltage:
    /// [1500]: [CCCC]+[ZZZZ], with input capacitance [CCCC](Cin) and input impedance [ZZZZ](Zin)
    /// [3000]: [CCCC]+[ZZZZ], idem.
    /// <see href="http://data.europa.eu/949/MinVehicleImpedance"></see></summary>
    let MinVehicleImpedance =
        Namespaced_IRI.parse _namespace_name "MinVehicleImpedance" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleImpedanceShape"></see>
    /// </summary>
    let ``shapes/MinVehicleImpedanceShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinVehicleImpedanceShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/MinimumVerticalRadius"></see>
    /// </summary>
    let MinimumVerticalRadius =
        Namespaced_IRI.parse _namespace_name "MinimumVerticalRadius" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumVerticalRadiusShape"></see>
    /// </summary>
    let ``shapes/MinimumVerticalRadiusShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinimumVerticalRadiusShape" |> NamespacedName

    /// <summary>
    /// Railway line within a member state.
    /// A line is a sequence of one or more sections of line, which connects operational points and which may consist of several tracks used for regular railway operation.
    /// <see href="http://data.europa.eu/949/NationalRailwayLine"></see></summary>
    let NationalRailwayLine =
        Namespaced_IRI.parse _namespace_name "NationalRailwayLine" |> NamespacedName

    /// <summary>
    /// Represents an area reference in the network.
    /// <see href="http://data.europa.eu/949/NetAreaReference"></see></summary>
    let NetAreaReference =
        Namespaced_IRI.parse _namespace_name "NetAreaReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetAreaReferenceShape"></see>
    /// </summary>
    let ``shapes/NetAreaReferenceShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/NetAreaReferenceShape" |> NamespacedName

    /// <summary>
    /// Basic positioning reference within the ERA ontology. It represents different types of geographical locations. Geographical coordinates are provided according to the standard World Geodetic System (WGS84).
    /// <see href="http://data.europa.eu/949/NetBasicReference"></see></summary>
    let NetBasicReference =
        Namespaced_IRI.parse _namespace_name "NetBasicReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetBasicReferenceShape"></see>
    /// </summary>
    let ``shapes/NetBasicReferenceShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/NetBasicReferenceShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetElementShape"></see>
    /// </summary>
    let ``shapes/NetElementShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/NetElementShape" |> NamespacedName

    /// <summary>
    /// Defines a relation between two elements.
    /// <see href="http://data.europa.eu/949/NetRelation"></see></summary>
    let NetRelation =
        Namespaced_IRI.parse _namespace_name "NetRelation" |> NamespacedName

    /// <summary>
    /// Represents a linear reference in the network.
    /// <see href="http://data.europa.eu/949/NetLinearReference"></see></summary>
    let NetLinearReference =
        Namespaced_IRI.parse _namespace_name "NetLinearReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetLinearReferenceShape"></see>
    /// </summary>
    let ``shapes/NetLinearReferenceShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/NetLinearReferenceShape" |> NamespacedName

    /// <summary>
    /// Represents a point reference in the network.
    /// <see href="http://data.europa.eu/949/NetPointReference"></see></summary>
    let NetPointReference =
        Namespaced_IRI.parse _namespace_name "NetPointReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetPointReferenceShape"></see>
    /// </summary>
    let ``shapes/NetPointReferenceShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/NetPointReferenceShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetRelationShape"></see>
    /// </summary>
    let ``shapes/NetRelationShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/NetRelationShape" |> NamespacedName

    /// <summary>
    /// Determines if the position of the topological element A in a relation is the origin of element A.
    /// <see href="http://data.europa.eu/949/isOnOriginOfElementA"></see></summary>
    let isOnOriginOfElementA =
        Namespaced_IRI.parse _namespace_name "isOnOriginOfElementA" |> NamespacedName

    /// <summary>
    /// Determines if the position of the topological element B in a relation is the origin of element B.
    /// <see href="http://data.europa.eu/949/isOnOriginOfElementB"></see></summary>
    let isOnOriginOfElementB =
        Namespaced_IRI.parse _namespace_name "isOnOriginOfElementB" |> NamespacedName

    /// <summary>
    /// Indicates the navigation possibilities between two related topological linear elements.
    /// <see href="http://data.europa.eu/949/navigability"></see></summary>
    let navigability =
        Namespaced_IRI.parse _namespace_name "navigability" |> NamespacedName

    /// <summary>
    /// References the second topological linear element in an oriented relation.
    /// For example, it may indicate the object that corresponds to a section of line, an operational point or a track inside an operational point connected at end.
    /// <see href="http://data.europa.eu/949/elementB"></see></summary>
    let elementB = Namespaced_IRI.parse _namespace_name "elementB" |> NamespacedName
    /// <summary>
    /// References the first topological element in an oriented relation.
    /// For example, it may indicate the object that corresponds to a section of line, an operational point or a track inside an operational point connected at start.
    /// <see href="http://data.europa.eu/949/elementA"></see></summary>
    let elementA = Namespaced_IRI.parse _namespace_name "elementA" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NonLinearElementShape"></see>
    /// </summary>
    let ``shapes/NonLinearElementShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/NonLinearElementShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OperationalPointShape"></see>
    /// </summary>
    let ``shapes/OperationalPointShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/OperationalPointShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OrganisationRoleShape"></see>
    /// </summary>
    let ``shapes/OrganisationRoleShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/OrganisationRoleShape" |> NamespacedName

    /// <summary>
    /// Represents the orientation of a railway object in relation to a carrier linear element. It can be described by direction, orientation and side.
    /// <see href="http://data.europa.eu/949/Orientation"></see></summary>
    let Orientation =
        Namespaced_IRI.parse _namespace_name "Orientation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OrientationShape"></see>
    /// </summary>
    let ``shapes/OrientationShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/OrientationShape" |> NamespacedName

    /// <summary>
    /// Applicability interval defines the date interval in which a characteristic of an infrastructure element is applicable. This interval can be applied for any of the technical characteristics or general information of infrastructure elements. This helps identifying planned changes applied to technical parameters over time.
    /// <see href="http://data.europa.eu/949/ParameterApplicability"></see></summary>
    let ParameterApplicability =
        Namespaced_IRI.parse _namespace_name "ParameterApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ParameterApplicabilityShape"></see>
    /// </summary>
    let ``shapes/ParameterApplicabilityShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/ParameterApplicabilityShape" |> NamespacedName

    /// <summary>
    /// Indication of required several information on phase separation.
    /// <see href="http://data.europa.eu/949/PhaseInfo"></see></summary>
    let PhaseInfo = Namespaced_IRI.parse _namespace_name "PhaseInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoShape"></see>
    /// </summary>
    let ``shapes/PhaseInfoShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/PhaseInfoShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/phaseInfo"></see>
    /// </summary>
    let phaseInfo = Namespaced_IRI.parse _namespace_name "phaseInfo" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.europa.eu/949/stable"></see>
    /// </summary>
    let stable = Namespaced_IRI.parse _namespace_name "stable" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PlatformEdgeShape"></see>
    /// </summary>
    let ``shapes/PlatformEdgeShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/PlatformEdgeShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PrimaryLocationShape"></see>
    /// </summary>
    let ``shapes/PrimaryLocationShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/PrimaryLocationShape" |> NamespacedName

    /// <summary>
    /// The reference that a physical infrastructure element has it on the topology. It may be used to define the positioning or a representation as a point, line or area
    /// <see href="http://data.europa.eu/949/netReference"></see></summary>
    let netReference =
        Namespaced_IRI.parse _namespace_name "netReference" |> NamespacedName

    /// <summary>
    /// Subsidiary location must be linked to a Primary Location and specifies in more detailed way part, attributes, or usage of Primary location. It may be also a non-rail point or a rail point that is not managed by an Infrastructure Manager (IM). It may be defined by entity having company code according to their needs. The Subsidiary location is optional and dependent upon business needs.
    /// <see href="http://data.europa.eu/949/SubsidiaryLocation"></see></summary>
    let SubsidiaryLocation =
        Namespaced_IRI.parse _namespace_name "SubsidiaryLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RadioBlockCenterShape"></see>
    /// </summary>
    let ``shapes/RadioBlockCenterShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/RadioBlockCenterShape" |> NamespacedName

    /// <summary>
    /// Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.
    /// Each track can have several raised pantographs per train allowed (structured) values, and each one has values for number of pantographs, minimum distance between pantographs, in metres, and speed considered in km/h.
    /// <see href="http://data.europa.eu/949/RaisedPantographsDistanceAndSpeed"></see></summary>
    let RaisedPantographsDistanceAndSpeed =
        Namespaced_IRI.parse _namespace_name "RaisedPantographsDistanceAndSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RaisedPantographsDistanceAndSpeedShape"></see>
    /// </summary>
    let ``shapes/RaisedPantographsDistanceAndSpeedShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/RaisedPantographsDistanceAndSpeedShape" |> NamespacedName

    /// <summary>
    /// List of reference border points that are specified in the RINF Application Guide.
    /// <see href="http://data.europa.eu/949/ReferenceBorderPoint"></see></summary>
    let ReferenceBorderPoint =
        Namespaced_IRI.parse _namespace_name "ReferenceBorderPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ReferenceBorderPointShape"></see>
    /// </summary>
    let ``shapes/ReferenceBorderPointShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/ReferenceBorderPointShape" |> NamespacedName

    /// <summary>
    /// Relates the information that each country maintains on a border point, to the operational point that represents the general information on the border point.
    /// <see href="http://data.europa.eu/949/borderPointOf"></see></summary>
    let borderPointOf =
        Namespaced_IRI.parse _namespace_name "borderPointOf" |> NamespacedName

    /// <summary>
    /// Relates an operational point that represents the general information of a border point to the information that each country maintains for the border point.
    /// <see href="http://data.europa.eu/949/opInfoPerCountry"></see></summary>
    let opInfoPerCountry =
        Namespaced_IRI.parse _namespace_name "opInfoPerCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RunningTrackShape"></see>
    /// </summary>
    let ``shapes/RunningTrackShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/RunningTrackShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SectionOfLineShape"></see>
    /// </summary>
    let ``shapes/SectionOfLineShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/SectionOfLineShape" |> NamespacedName

    /// <summary>
    /// Operational point at the end of section of line (kilometres increasing from start OP to the end OP).
    /// <see href="http://data.europa.eu/949/opEnd"></see></summary>
    let opEnd = Namespaced_IRI.parse _namespace_name "opEnd" |> NamespacedName
    /// <summary>
    /// Operational point at the start of section of line (kilometres increasing from start OP to the end OP).
    /// <see href="http://data.europa.eu/949/opStart"></see></summary>
    let opStart = Namespaced_IRI.parse _namespace_name "opStart" |> NamespacedName

    /// <summary>
    /// Indicates a relationship with a national railway line at a specific kilometer point.
    /// For a Section of Line: unique line identification or unique line number within Member State.
    /// <see href="http://data.europa.eu/949/nationalLine"></see></summary>
    let nationalLine =
        Namespaced_IRI.parse _namespace_name "nationalLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SidingShape"></see>
    /// </summary>
    let ``shapes/SidingShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/SidingShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SignalShape"></see>
    /// </summary>
    let ``shapes/SignalShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/SignalShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SpecialAreaShape"></see>
    /// </summary>
    let ``shapes/SpecialAreaShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/SpecialAreaShape" |> NamespacedName

    /// <summary>
    /// Area or location within a tunnel where there are:
    /// - a safe area: a walkway, evacuation and rescue points;
    /// - a restricted area (non-stopping area or industrial risk location in a tunnel).
    /// <see href="http://data.europa.eu/949/SpecialTunnelArea"></see></summary>
    let SpecialTunnelArea =
        Namespaced_IRI.parse _namespace_name "SpecialTunnelArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SpecialTunnelAreaShape"></see>
    /// </summary>
    let ``shapes/SpecialTunnelAreaShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/SpecialTunnelAreaShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsidiaryLocationShape"></see>
    /// </summary>
    let ``shapes/SubsidiaryLocationShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/SubsidiaryLocationShape" |> NamespacedName

    /// <summary>
    /// Relates a subsidiary location with a primary location.
    /// <see href="http://data.europa.eu/949/linkedToPrimaryLocation"></see></summary>
    let linkedToPrimaryLocation =
        Namespaced_IRI.parse _namespace_name "linkedToPrimaryLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SwitchShape"></see>
    /// </summary>
    let ``shapes/SwitchShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/SwitchShape" |> NamespacedName

    /// <summary>
    /// Indication of required several information on system separation.
    /// <see href="http://data.europa.eu/949/SystemSeparationInfo"></see></summary>
    let SystemSeparationInfo =
        Namespaced_IRI.parse _namespace_name "SystemSeparationInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SystemSeparationInfoShape"></see>
    /// </summary>
    let ``shapes/SystemSeparationInfoShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/SystemSeparationInfoShape" |> NamespacedName

    /// <summary>
    /// (deprecated) Indication of required several information on system separation.
    /// Deprecated because of replacement by four properties. The reason is that the property is composed of four values: length [NNN], the length of the system separation in metres; switch off breaker [Y/N]. Single selection of 'Y=yes' or 'N=no' to show whether the breaker has to be switched off;  lower pantograph [Y/N]. Single selection of 'Y=yes' or 'N=no' to show whether the pantograph has to be lowered, and [CharacterString]  to show whether the supply system has to be changed.
    /// <see href="http://data.europa.eu/949/systemSeparationInfo"></see></summary>
    let systemSeparationInfo =
        Namespaced_IRI.parse _namespace_name "systemSeparationInfo" |> NamespacedName

    /// <summary>
    /// Represents the TEN-T network classification of an element, including its network level, type of traffic, and associated European transport corridors.
    /// <see href="http://data.europa.eu/949/TENTCorridor"></see></summary>
    let TENTCorridor =
        Namespaced_IRI.parse _namespace_name "TENTCorridor" |> NamespacedName

    /// <summary>
    /// Indication whether rules exist and are compliant with the TSI.
    /// <see href="http://data.europa.eu/949/TSIMagneticFields"></see></summary>
    let TSIMagneticFields =
        Namespaced_IRI.parse _namespace_name "TSIMagneticFields" |> NamespacedName

    /// <summary>
    /// Annotation used to point to the applicability of a parameter in RINF. Values are Y/N/NYA
    /// <see href="http://data.europa.eu/949/applicable"></see></summary>
    let applicable = Namespaced_IRI.parse _namespace_name "applicable" |> NamespacedName

    /// <summary>
    /// Property that links an object SKOS property to a the URI of the corresponding SKOS Concept Scheme.
    /// <see href="http://data.europa.eu/949/inSkosConceptScheme"></see></summary>
    let inSkosConceptScheme =
        Namespaced_IRI.parse _namespace_name "inSkosConceptScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/tsi-existence-and-compliances/TSIExistenceAndCompliances"></see>
    /// </summary>
    let ``concepts/tsi-existence-and-compliances/TSIExistenceAndCompliances`` =
        Namespaced_IRI.parse _namespace_name "concepts/tsi-existence-and-compliances/TSIExistenceAndCompliances" |> NamespacedName

    /// <summary>
    /// Annotation used to point to legal obligation of a parameter in RINF
    /// <see href="http://data.europa.eu/949/legalDeadline"></see></summary>
    let legalDeadline =
        Namespaced_IRI.parse _namespace_name "legalDeadline" |> NamespacedName

    /// <summary>
    /// Index code used in the original definition of a parameter in RINF.
    /// <see href="http://data.europa.eu/949/rinfIndex"></see></summary>
    let rinfIndex = Namespaced_IRI.parse _namespace_name "rinfIndex" |> NamespacedName

    /// <summary>
    /// Indication whether rules exist and are compliant with the TSI.
    /// <see href="http://data.europa.eu/949/tsiMagneticFields"></see></summary>
    let tsiMagneticFields =
        Namespaced_IRI.parse _namespace_name "tsiMagneticFields" |> NamespacedName

    /// <summary>
    /// Indication whether rules exist and are compliant with the TSI.
    /// <see href="http://data.europa.eu/949/TSITractionHarmonics"></see></summary>
    let TSITractionHarmonics =
        Namespaced_IRI.parse _namespace_name "TSITractionHarmonics" |> NamespacedName

    /// <summary>
    /// Corresponding XML name as indicated in the RINF application guide
    /// <see href="http://data.europa.eu/949/XMLName"></see></summary>
    let XMLName = Namespaced_IRI.parse _namespace_name "XMLName" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/tsi-compliances/TSICompliances"></see>
    /// </summary>
    let ``concepts/tsi-compliances/TSICompliances`` =
        Namespaced_IRI.parse _namespace_name "concepts/tsi-compliances/TSICompliances" |> NamespacedName

    /// <summary>
    /// Indication whether rules exist and are compliant with the TSI.
    /// <see href="http://data.europa.eu/949/tsiTractionHarmonics"></see></summary>
    let tsiTractionHarmonics =
        Namespaced_IRI.parse _namespace_name "tsiTractionHarmonics" |> NamespacedName

    /// <summary>
    /// Represents a topological coordinate.
    /// <see href="http://data.europa.eu/949/TopologicalCoordinate"></see></summary>
    let TopologicalCoordinate =
        Namespaced_IRI.parse _namespace_name "TopologicalCoordinate" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TopologicalCoordinateShape"></see>
    /// </summary>
    let ``shapes/TopologicalCoordinateShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/TopologicalCoordinateShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemShape"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrainDetectionSystemShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TunnelShape"></see>
    /// </summary>
    let ``shapes/TunnelShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/TunnelShape" |> NamespacedName

    /// <summary>
    /// The natural or legal person that, being the owner of a vehicle or having the right to use it,
    /// exploits the vehicle as a means of transport and is registered as such in a vehicle register referred to in Article 47 of (EU)2016/797.
    /// <see href="http://data.europa.eu/949/vehicleKeeper"></see></summary>
    let vehicleKeeper =
        Namespaced_IRI.parse _namespace_name "vehicleKeeper" |> NamespacedName

    /// <summary>
    /// Existence of limit for acceleration of train if stopping or recovering speed close to a level crossing expressed in a specific reference acceleration curve.
    /// <see href="http://data.europa.eu/949/accelerationLevelCrossing"></see></summary>
    let accelerationLevelCrossing =
        Namespaced_IRI.parse _namespace_name "accelerationLevelCrossing" |> NamespacedName

    /// <summary>
    /// This property is used to specify dependencies in natural language not covered by skos:scopeNote
    /// <see href="http://data.europa.eu/949/dependencyNote"></see></summary>
    let dependencyNote =
        Namespaced_IRI.parse _namespace_name "dependencyNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AccelerationLevelCrossingApplicability"></see>
    /// </summary>
    let ``shapes/AccelerationLevelCrossingApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/AccelerationLevelCrossingApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AccelerationLevelCrossing"></see>
    /// </summary>
    let ``shapes/AccelerationLevelCrossing`` =
        Namespaced_IRI.parse _namespace_name "shapes/AccelerationLevelCrossing" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/healthSafetyAndEnvironmentObjParameter"></see>
    /// </summary>
    let healthSafetyAndEnvironmentObjParameter =
        Namespaced_IRI.parse _namespace_name "healthSafetyAndEnvironmentObjParameter" |> NamespacedName

    /// <summary>
    /// Electronic document available in two EU languages from the IM stored by the Agency providing additional information as defined in point (2) of point 4.2.2.6.2 of TSI OPE.
    /// <see href="http://data.europa.eu/949/additionalBrakingInformationDocument"></see></summary>
    let additionalBrakingInformationDocument =
        Namespaced_IRI.parse _namespace_name "additionalBrakingInformationDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AdditionalBrakingInformationDocumentApplicability"></see>
    /// </summary>
    let ``shapes/AdditionalBrakingInformationDocumentApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/AdditionalBrakingInformationDocumentApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AdditionalBrakingInformationDocument"></see>
    /// </summary>
    let ``shapes/AdditionalBrakingInformationDocument`` =
        Namespaced_IRI.parse _namespace_name "shapes/AdditionalBrakingInformationDocument" |> NamespacedName

    /// <summary>
    /// Indicates whether a RINF parameter is used in Route Compatibility Check calculations according to Commission Implementing Regulation (EU) 2019/773 of 16 May 2019 on the technical specification for interoperability relating to the operation and traffic management subsystem of the rail system within the European Union and repealing Decision.
    /// <see href="http://data.europa.eu/949/usedInRCCCalculations"></see></summary>
    let usedInRCCCalculations =
        Namespaced_IRI.parse _namespace_name "usedInRCCCalculations" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/brakeRelatedObjParameter"></see>
    /// </summary>
    let brakeRelatedObjParameter =
        Namespaced_IRI.parse _namespace_name "brakeRelatedObjParameter" |> NamespacedName

    /// <summary>
    /// Annotation property used in SHACL shapes. Name of the classes that are the subject of properties that are being validated in a SHACL shape.
    /// <see href="http://data.europa.eu/949/affectedClass"></see></summary>
    let affectedClass =
        Namespaced_IRI.parse _namespace_name "affectedClass" |> NamespacedName

    /// <summary>
    /// Annotation property used in SHACL shapes. Name of the properties that are being validated in a SHACL shape.
    /// <see href="http://data.europa.eu/949/affectedProperty"></see></summary>
    let affectedProperty =
        Namespaced_IRI.parse _namespace_name "affectedProperty" |> NamespacedName

    /// <summary>
    /// Specifies the linear elements aggregated by a non-linear element.
    /// <see href="http://data.europa.eu/949/aggregates"></see></summary>
    let aggregates = Namespaced_IRI.parse _namespace_name "aggregates" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Aggregates"></see>
    /// </summary>
    let ``shapes/Aggregates`` =
        Namespaced_IRI.parse _namespace_name "shapes/Aggregates" |> NamespacedName

    /// <summary>
    /// The organisation in charge to allocate the code for the subsidiary location.
    /// <see href="http://data.europa.eu/949/allocationCompany"></see></summary>
    let allocationCompany =
        Namespaced_IRI.parse _namespace_name "allocationCompany" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AllocationCompany"></see>
    /// </summary>
    let ``shapes/AllocationCompany`` =
        Namespaced_IRI.parse _namespace_name "shapes/AllocationCompany" |> NamespacedName

    /// <summary>
    /// Alternative name of a vehicle type.
    /// <see href="http://data.europa.eu/949/alternativeName"></see></summary>
    let alternativeName =
        Namespaced_IRI.parse _namespace_name "alternativeName" |> NamespacedName

    /// <summary>
    /// Index code used in the original definition of a parameter in ERATV.
    /// <see href="http://data.europa.eu/949/eratvIndex"></see></summary>
    let eratvIndex = Namespaced_IRI.parse _namespace_name "eratvIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/vehicleTypeTechnicalDataCharacteristic"></see>
    /// </summary>
    let vehicleTypeTechnicalDataCharacteristic =
        Namespaced_IRI.parse _namespace_name "vehicleTypeTechnicalDataCharacteristic" |> NamespacedName

    /// <summary>
    /// Altitude range.
    /// <see href="http://data.europa.eu/949/altitudeRange"></see></summary>
    let altitudeRange =
        Namespaced_IRI.parse _namespace_name "altitudeRange" |> NamespacedName

    /// <summary>
    /// Altitude range value for 'X' if value 'AX' is selected in altitude range.
    /// <see href="http://data.europa.eu/949/altitudeRangeDetail"></see></summary>
    let altitudeRangeDetail =
        Namespaced_IRI.parse _namespace_name "altitudeRangeDetail" |> NamespacedName

    /// <summary>
    /// Specifies if the section applies in both directions (optional).
    /// <see href="http://data.europa.eu/949/appliesInBothDirections"></see></summary>
    let appliesInBothDirections =
        Namespaced_IRI.parse _namespace_name "appliesInBothDirections" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AppliesInBothDirections"></see>
    /// </summary>
    let ``shapes/AppliesInBothDirections`` =
        Namespaced_IRI.parse _namespace_name "shapes/AppliesInBothDirections" |> NamespacedName

    /// <summary>
    /// The direction relative to the origin of the linear element towards the point reference applies.
    /// <see href="http://data.europa.eu/949/appliesToDirection"></see></summary>
    let appliesToDirection =
        Namespaced_IRI.parse _namespace_name "appliesToDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/orientations/OrientationDirections"></see>
    /// </summary>
    let ``concepts/orientations/OrientationDirections`` =
        Namespaced_IRI.parse _namespace_name "concepts/orientations/OrientationDirections" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AppliesToDirectionSKOS"></see>
    /// </summary>
    let ``shapes/AppliesToDirectionSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/AppliesToDirectionSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AppliesToDirection"></see>
    /// </summary>
    let ``shapes/AppliesToDirection`` =
        Namespaced_IRI.parse _namespace_name "shapes/AppliesToDirection" |> NamespacedName

    /// <summary>
    /// Information of the train access level for which the boarding aid can be used.
    /// <see href="http://data.europa.eu/949/areaBoardingAid"></see></summary>
    let areaBoardingAid =
        Namespaced_IRI.parse _namespace_name "areaBoardingAid" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AreaBoardingAid"></see>
    /// </summary>
    let ``shapes/AreaBoardingAid`` =
        Namespaced_IRI.parse _namespace_name "shapes/AreaBoardingAid" |> NamespacedName

    /// <summary>
    /// Magnitude of a quantity, defined and adopted by convention or by law, that is used as a standard for measurement of the same kind of quantity.
    /// <see href="http://data.europa.eu/949/unitOfMeasure"></see></summary>
    let unitOfMeasure =
        Namespaced_IRI.parse _namespace_name "unitOfMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/platformDataParameter"></see>
    /// </summary>
    let platformDataParameter =
        Namespaced_IRI.parse _namespace_name "platformDataParameter" |> NamespacedName

    /// <summary>
    /// Indication of existence of equipment or staff supporting the train crew in starting the train.
    /// <see href="http://data.europa.eu/949/assistanceStartingTrain"></see></summary>
    let assistanceStartingTrain =
        Namespaced_IRI.parse _namespace_name "assistanceStartingTrain" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AssistanceStartingTrain"></see>
    /// </summary>
    let ``shapes/AssistanceStartingTrain`` =
        Namespaced_IRI.parse _namespace_name "shapes/AssistanceStartingTrain" |> NamespacedName

    /// <summary>
    /// Supported ATO communication systems from trackside.
    /// <see href="http://data.europa.eu/949/atoCommunicationSystem"></see></summary>
    let atoCommunicationSystem =
        Namespaced_IRI.parse _namespace_name "atoCommunicationSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ato-commsys/ATOCommSystem"></see>
    /// </summary>
    let ``concepts/ato-commsys/ATOCommSystem`` =
        Namespaced_IRI.parse _namespace_name "concepts/ato-commsys/ATOCommSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AtoCommunicationSystem"></see>
    /// </summary>
    let ``shapes/AtoCommunicationSystem`` =
        Namespaced_IRI.parse _namespace_name "shapes/AtoCommunicationSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AtoCommunicationSystemSKOS"></see>
    /// </summary>
    let ``shapes/AtoCommunicationSystemSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/AtoCommunicationSystemSKOS" |> NamespacedName

    /// <summary>
    /// The index of a vocabulary term in Appendix D2 Elements the infrastructure manager has to provide to the railway undertaking for the Route Book from the document Commission Implementing Regulation (EU) 2019/773 of 16 May 2019 on the technical specification for interoperability relating to the operation and traffic management subsystem of the rail system within the European Union and repealing Decision 2012/757/EU.
    /// <see href="http://data.europa.eu/949/tsiOPEAppendixD2Index"></see></summary>
    let tsiOPEAppendixD2Index =
        Namespaced_IRI.parse _namespace_name "tsiOPEAppendixD2Index" |> NamespacedName

    /// <summary>
    /// ATO grade of automation installed lineside.
    /// <see href="http://data.europa.eu/949/atoGradeAutomation"></see></summary>
    let atoGradeAutomation =
        Namespaced_IRI.parse _namespace_name "atoGradeAutomation" |> NamespacedName

    /// <summary>
    /// ETCS baseline installed lineside.
    /// <see href="http://data.europa.eu/949/etcsBaseline"></see></summary>
    let etcsBaseline =
        Namespaced_IRI.parse _namespace_name "etcsBaseline" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/automatedTrainOperationObjParameter"></see>
    /// </summary>
    let automatedTrainOperationObjParameter =
        Namespaced_IRI.parse _namespace_name "automatedTrainOperationObjParameter" |> NamespacedName

    /// <summary>
    /// List of unacceptable errors impacting the IM network that are required to be solved in the on-board ATO according to the CCS TSI point 7.2.10.3 specification maintenance point.
    /// <see href="http://data.europa.eu/949/atoErrorCorrectionsOnboard"></see></summary>
    let atoErrorCorrectionsOnboard =
        Namespaced_IRI.parse _namespace_name "atoErrorCorrectionsOnboard" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ato-grades-automation/ATOGradeOfAutomation"></see>
    /// </summary>
    let ``concepts/ato-grades-automation/ATOGradeOfAutomation`` =
        Namespaced_IRI.parse _namespace_name "concepts/ato-grades-automation/ATOGradeOfAutomation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AtoGradeAutomationSKOS"></see>
    /// </summary>
    let ``shapes/AtoGradeAutomationSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/AtoGradeAutomationSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AtoGradeAutomation"></see>
    /// </summary>
    let ``shapes/AtoGradeAutomation`` =
        Namespaced_IRI.parse _namespace_name "shapes/AtoGradeAutomation" |> NamespacedName

    /// <summary>
    /// ATO system version according to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/atoSystemVersion"></see></summary>
    let atoSystemVersion =
        Namespaced_IRI.parse _namespace_name "atoSystemVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ato-s-versions/ATOSystemVersions"></see>
    /// </summary>
    let ``concepts/ato-s-versions/ATOSystemVersions`` =
        Namespaced_IRI.parse _namespace_name "concepts/ato-s-versions/ATOSystemVersions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AtoSystemVersionSKOS"></see>
    /// </summary>
    let ``shapes/AtoSystemVersionSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/AtoSystemVersionSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AtoSystemVersion"></see>
    /// </summary>
    let ``shapes/AtoSystemVersion`` =
        Namespaced_IRI.parse _namespace_name "shapes/AtoSystemVersion" |> NamespacedName

    /// <summary>
    /// Indicates the country(ies) in where a vehicle type has been authorized to operate.
    /// <see href="http://data.europa.eu/949/authorizedCountry"></see></summary>
    let authorizedCountry =
        Namespaced_IRI.parse _namespace_name "authorizedCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/vehicleTypeTechnicalObjectCharacteristic"></see>
    /// </summary>
    let vehicleTypeTechnicalObjectCharacteristic =
        Namespaced_IRI.parse _namespace_name "vehicleTypeTechnicalObjectCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/ccsSubsystemObjParameter"></see>
    /// </summary>
    let ccsSubsystemObjParameter =
        Namespaced_IRI.parse _namespace_name "ccsSubsystemObjParameter" |> NamespacedName

    /// <summary>
    /// Indication of whether an automatic dropping device (ADD) required on the vehicle.
    /// <see href="http://data.europa.eu/949/automaticDroppingDeviceRequired"></see></summary>
    let automaticDroppingDeviceRequired =
        Namespaced_IRI.parse _namespace_name "automaticDroppingDeviceRequired" |> NamespacedName

    /// <summary>
    /// This property is used to annotate in human readable the format of parameters
    /// <see href="http://data.europa.eu/949/formatNote"></see></summary>
    let formatNote = Namespaced_IRI.parse _namespace_name "formatNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AutomaticDroppingDeviceRequired"></see>
    /// </summary>
    let ``shapes/AutomaticDroppingDeviceRequired`` =
        Namespaced_IRI.parse _namespace_name "shapes/AutomaticDroppingDeviceRequired" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AutomaticDroppingDeviceRequiredApplicability"></see>
    /// </summary>
    let ``shapes/AutomaticDroppingDeviceRequiredApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/AutomaticDroppingDeviceRequiredApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/requirementsRollingStockDataParameter"></see>
    /// </summary>
    let requirementsRollingStockDataParameter =
        Namespaced_IRI.parse _namespace_name "requirementsRollingStockDataParameter" |> NamespacedName

    /// <summary>
    /// Axle bearing condition monitoring.
    /// <see href="http://data.europa.eu/949/axleBearingConditionMonitoring"></see></summary>
    let axleBearingConditionMonitoring =
        Namespaced_IRI.parse _namespace_name "axleBearingConditionMonitoring" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/axle-monitoring/AxleBearingMonitoring"></see>
    /// </summary>
    let ``concepts/axle-monitoring/AxleBearingMonitoring`` =
        Namespaced_IRI.parse _namespace_name "concepts/axle-monitoring/AxleBearingMonitoring" |> NamespacedName

    /// <summary>
    /// Position of the axles along the unit. a: Distance between axles; b: Distance from end axle to the end of the nearest coupling plane; c: distance between two inside axles.
    /// <see href="http://data.europa.eu/949/axleSpacing"></see></summary>
    let axleSpacing =
        Namespaced_IRI.parse _namespace_name "axleSpacing" |> NamespacedName

    /// <summary>
    /// Indicates that an infrastructure element belongs to a certain subset that contains common characteristics.
    /// <see href="http://data.europa.eu/949/belongsTo"></see></summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BelongsTo"></see>
    /// </summary>
    let ``shapes/BelongsTo`` =
        Namespaced_IRI.parse _namespace_name "shapes/BelongsTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BelongsToUniqueIM"></see>
    /// </summary>
    let ``shapes/BelongsToUniqueIM`` =
        Namespaced_IRI.parse _namespace_name "shapes/BelongsToUniqueIM" |> NamespacedName

    /// <summary>
    /// Indicates that a subset with common characteristics contains a certain infrastructure element.
    /// <see href="http://data.europa.eu/949/contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    /// Indication of existence of metal mass in the vicinity of the location, susceptible of perturbating the reading of balises by the on-board system.
    /// <see href="http://data.europa.eu/949/bigMetalMass"></see></summary>
    let bigMetalMass =
        Namespaced_IRI.parse _namespace_name "bigMetalMass" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BigMetalMass"></see>
    /// </summary>
    let ``shapes/BigMetalMass`` =
        Namespaced_IRI.parse _namespace_name "shapes/BigMetalMass" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BigMetalMassApplicability"></see>
    /// </summary>
    let ``shapes/BigMetalMassApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/BigMetalMassApplicability" |> NamespacedName

    /// <summary>
    /// ETCS application level related to the track side equipment.
    /// <see href="http://data.europa.eu/949/etcsLevelType"></see></summary>
    let etcsLevelType =
        Namespaced_IRI.parse _namespace_name "etcsLevelType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/tsiCompliantTrainProtectionSystemDataParameter"></see>
    /// </summary>
    let tsiCompliantTrainProtectionSystemDataParameter =
        Namespaced_IRI.parse _namespace_name "tsiCompliantTrainProtectionSystemDataParameter" |> NamespacedName

    /// <summary>
    /// Description of any integrated boarding aids (if provided).
    /// <see href="http://data.europa.eu/949/boardingAids"></see></summary>
    let boardingAids =
        Namespaced_IRI.parse _namespace_name "boardingAids" |> NamespacedName

    /// <summary>
    /// Border point identification in the list of reference border points in the RINF application guide.
    /// <see href="http://data.europa.eu/949/borderPointId"></see></summary>
    let borderPointId =
        Namespaced_IRI.parse _namespace_name "borderPointId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BorderPointId"></see>
    /// </summary>
    let ``shapes/BorderPointId`` =
        Namespaced_IRI.parse _namespace_name "shapes/BorderPointId" |> NamespacedName

    /// <summary>
    /// Relates an operational point that is a border point with an instance of the list of reference border points that are specified in the RINF Application Guide.
    /// <see href="http://data.europa.eu/949/referenceBorderPoint"></see></summary>
    let referenceBorderPoint =
        Namespaced_IRI.parse _namespace_name "referenceBorderPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/brakeRelatedDataParameter"></see>
    /// </summary>
    let brakeRelatedDataParameter =
        Namespaced_IRI.parse _namespace_name "brakeRelatedDataParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/ccsSubsystemDataParameter"></see>
    /// </summary>
    let ccsSubsystemDataParameter =
        Namespaced_IRI.parse _namespace_name "ccsSubsystemDataParameter" |> NamespacedName

    /// <summary>
    /// Brake weight percentage (lambda) or Braked mass.
    /// <see href="http://data.europa.eu/949/brakeWeightPercentage"></see></summary>
    let brakeWeightPercentage =
        Namespaced_IRI.parse _namespace_name "brakeWeightPercentage" |> NamespacedName

    /// <summary>
    /// The canonical URI is defined for each instance of an Infrastructure element, e.g. section of line, operational point, track, tunnel, siding.
    /// Objects of the infrastructure generated through RML mappings include (when provided) their validity start and end dates. With its identifier, plus all identifiers of its "parent" elements, and its validity dates, a hash URI is generated.
    /// The canonical URI is the element's URI with its identifiers and without the validity dates. All of the hash URIs of an element point to its canonical URI.
    /// Additionally, SoLs point to the canonical URIs of their start OP and end OP.
    /// <see href="http://data.europa.eu/949/canonicalURI"></see></summary>
    let canonicalURI =
        Namespaced_IRI.parse _namespace_name "canonicalURI" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CanonicalURI"></see>
    /// </summary>
    let ``shapes/CanonicalURI`` =
        Namespaced_IRI.parse _namespace_name "shapes/CanonicalURI" |> NamespacedName

    /// <summary>
    /// Cant deficiency (maximum uncompensated lateral acceleration) for which the vehicle has been assessed. For dual gauge vehicles values for each gauge have to be indicated.
    /// <see href="http://data.europa.eu/949/cantDefficiency"></see></summary>
    let cantDefficiency =
        Namespaced_IRI.parse _namespace_name "cantDefficiency" |> NamespacedName

    /// <summary>
    /// Maximum cant deficiency expressed in millimetres defined as difference between the applied cant and a higher equilibrium cant the line has been designed for.
    /// <see href="http://data.europa.eu/949/cantDeficiency"></see></summary>
    let cantDeficiency =
        Namespaced_IRI.parse _namespace_name "cantDeficiency" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CantDeficiency"></see>
    /// </summary>
    let ``shapes/CantDeficiency`` =
        Namespaced_IRI.parse _namespace_name "shapes/CantDeficiency" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trackDataParameter"></see>
    /// </summary>
    let trackDataParameter =
        Namespaced_IRI.parse _namespace_name "trackDataParameter" |> NamespacedName

    /// <summary>
    /// Essential information for railway undertakings with a worse (lower) tolerated cant deficiency than those for which the ETCS trackside provides SSP (Static Speed Profiles) in conjunction with parameter "Other Cant Deficiency train categories for which the ETCS trackside is configured to provide SSP".
    /// <see href="http://data.europa.eu/949/cantDeficiencyBasicSSP"></see></summary>
    let cantDeficiencyBasicSSP =
        Namespaced_IRI.parse _namespace_name "cantDeficiencyBasicSSP" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/cant-deficiencies/CantDeficiencies"></see>
    /// </summary>
    let ``concepts/cant-deficiencies/CantDeficiencies`` =
        Namespaced_IRI.parse _namespace_name "concepts/cant-deficiencies/CantDeficiencies" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CantDeficiencyBasicSSP"></see>
    /// </summary>
    let ``shapes/CantDeficiencyBasicSSP`` =
        Namespaced_IRI.parse _namespace_name "shapes/CantDeficiencyBasicSSP" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CantDeficiencyBasicSSPSKOS"></see>
    /// </summary>
    let ``shapes/CantDeficiencyBasicSSPSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/CantDeficiencyBasicSSPSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CantDeficiencyBasicSSPApplicability"></see>
    /// </summary>
    let ``shapes/CantDeficiencyBasicSSPApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/CantDeficiencyBasicSSPApplicability" |> NamespacedName

    /// <summary>
    /// The index of a vocabulary term in Appendix D3 ERTMS trackside engineering information relevant to operation that the infrastructure manager shall provide to the railway undertaking.
    /// <see href="http://data.europa.eu/949/tsiOPEAppendixD3Index"></see></summary>
    let tsiOPEAppendixD3Index =
        Namespaced_IRI.parse _namespace_name "tsiOPEAppendixD3Index" |> NamespacedName

    /// <summary>
    /// Essential information for drivers of trains with a worse (lower) tolerated cant deficiency than those for which the ETCS trackside provides SSP (Static Speed Profiles) in conjunction with parameter "Cant Deficiency used for the basic SSP".
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/otherCantDeficiencyBasicSSP"></see></summary>
    let otherCantDeficiencyBasicSSP =
        Namespaced_IRI.parse _namespace_name "otherCantDeficiencyBasicSSP" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/tsiCompliantTrainProtectionSystemObjParameter"></see>
    /// </summary>
    let tsiCompliantTrainProtectionSystemObjParameter =
        Namespaced_IRI.parse _namespace_name "tsiCompliantTrainProtectionSystemObjParameter" |> NamespacedName

    /// <summary>
    /// The carrier linear element in relation to which the orientation is based on
    /// <see href="http://data.europa.eu/949/carrierLinearElement"></see></summary>
    let carrierLinearElement =
        Namespaced_IRI.parse _namespace_name "carrierLinearElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CarrierLinearElement"></see>
    /// </summary>
    let ``shapes/CarrierLinearElement`` =
        Namespaced_IRI.parse _namespace_name "shapes/CarrierLinearElement" |> NamespacedName

    /// <summary>
    /// (Deprecated) Vehicle category.
    /// <see href="http://data.europa.eu/949/category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/vehicle-types/Categories"></see>
    /// </summary>
    let ``concepts/vehicle-types/Categories`` =
        Namespaced_IRI.parse _namespace_name "concepts/vehicle-types/Categories" |> NamespacedName

    /// <summary>
    /// Indicates the core purpose of a railway vehicle: delivering traction, transporting goods or passengers or serving as a special vehicle.
    /// <see href="http://data.europa.eu/949/vehicleCategory"></see></summary>
    let vehicleCategory =
        Namespaced_IRI.parse _namespace_name "vehicleCategory" |> NamespacedName

    /// <summary>
    /// Maximum rated current from the catenary (to be indicated for each electrical energy supply system the vehicle is equipped for), given in A.
    /// <see href="http://data.europa.eu/949/catenaryMaxRatedCurrent"></see></summary>
    let catenaryMaxRatedCurrent =
        Namespaced_IRI.parse _namespace_name "catenaryMaxRatedCurrent" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/rinfTechnicalDataCharacteristic"></see>
    /// </summary>
    let rinfTechnicalDataCharacteristic =
        Namespaced_IRI.parse _namespace_name "rinfTechnicalDataCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/ccsSubsystemDeclarationsVerificationTrackDataParameter"></see>
    /// </summary>
    let ccsSubsystemDeclarationsVerificationTrackDataParameter =
        Namespaced_IRI.parse _namespace_name "ccsSubsystemDeclarationsVerificationTrackDataParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/ccsSubsystemDeclarationsVerificationTrackObjParameter"></see>
    /// </summary>
    let ccsSubsystemDeclarationsVerificationTrackObjParameter =
        Namespaced_IRI.parse _namespace_name "ccsSubsystemDeclarationsVerificationTrackObjParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/rinfTechnicalObjectCharacteristic"></see>
    /// </summary>
    let rinfTechnicalObjectCharacteristic =
        Namespaced_IRI.parse _namespace_name "rinfTechnicalObjectCharacteristic" |> NamespacedName

    /// <summary>
    /// For this Vehicle Type, the type or design examination certificate described in the relevant verification module as issued by
    /// Notified Bodies, supporting the EC Declaration(s) of Verification for the subsystems in scope of the type's authorisation by an authorizing entity.
    /// <see href="http://data.europa.eu/949/certificate"></see></summary>
    let certificate =
        Namespaced_IRI.parse _namespace_name "certificate" |> NamespacedName

    /// <summary>
    /// Category of a Railway company. Can be Infrastructure, Freight or Passenger. Deprecated as it will be integrated with the Organisations properties.
    /// <see href="http://data.europa.eu/949/companyCodeCategory"></see></summary>
    let companyCodeCategory =
        Namespaced_IRI.parse _namespace_name "companyCodeCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/company-code-categories/CompanyCodeCategories"></see>
    /// </summary>
    let ``concepts/company-code-categories/CompanyCodeCategories`` =
        Namespaced_IRI.parse _namespace_name "concepts/company-code-categories/CompanyCodeCategories" |> NamespacedName

    /// <summary>
    /// Electronic document available in two EU languages from the IM stored by the Agency with:
    /// - precise procedures for the static and dynamic route compatibility checks;
    /// Or
    /// - relevant information for carrying out the checks for specific structures.
    /// <see href="http://data.europa.eu/949/compatibilityProcedureDocument"></see></summary>
    let compatibilityProcedureDocument =
        Namespaced_IRI.parse _namespace_name "compatibilityProcedureDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CompatibilityProcedureDocument"></see>
    /// </summary>
    let ``shapes/CompatibilityProcedureDocument`` =
        Namespaced_IRI.parse _namespace_name "shapes/CompatibilityProcedureDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/performanceObjParameter"></see>
    /// </summary>
    let performanceObjParameter =
        Namespaced_IRI.parse _namespace_name "performanceObjParameter" |> NamespacedName

    /// <summary>
    /// Compliance of the tunnel with TSI INF at the maximum permitted speed
    /// <see href="http://data.europa.eu/949/complianceInfTsi"></see></summary>
    let complianceInfTsi =
        Namespaced_IRI.parse _namespace_name "complianceInfTsi" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ComplianceInfTsiP"></see>
    /// </summary>
    let ``shapes/ComplianceInfTsiP`` =
        Namespaced_IRI.parse _namespace_name "shapes/ComplianceInfTsiP" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ComplianceInfTsiApplicability"></see>
    /// </summary>
    let ``shapes/ComplianceInfTsiApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/ComplianceInfTsiApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/tunnelDataParameter"></see>
    /// </summary>
    let tunnelDataParameter =
        Namespaced_IRI.parse _namespace_name "tunnelDataParameter" |> NamespacedName

    /// <summary>
    /// Indicates if a vehicle's composite brake block is retrofitted
    /// <see href="http://data.europa.eu/949/compositeBrakeBlockRetrofitted"></see></summary>
    let compositeBrakeBlockRetrofitted =
        Namespaced_IRI.parse _namespace_name "compositeBrakeBlockRetrofitted" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/vehicleTechnicalDataCharacteristic"></see>
    /// </summary>
    let vehicleTechnicalDataCharacteristic =
        Namespaced_IRI.parse _namespace_name "vehicleTechnicalDataCharacteristic" |> NamespacedName

    /// <summary>
    /// Indication whether regenerative braking is permitted, not permitted, or permitted under specific conditions.
    /// <see href="http://data.europa.eu/949/conditionalRegenerativeBrake"></see></summary>
    let conditionalRegenerativeBrake =
        Namespaced_IRI.parse _namespace_name "conditionalRegenerativeBrake" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/regenerative-braking/RegenerativeBraking"></see>
    /// </summary>
    let ``concepts/regenerative-braking/RegenerativeBraking`` =
        Namespaced_IRI.parse _namespace_name "concepts/regenerative-braking/RegenerativeBraking" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionalRegenerativeBrakeSKOS"></see>
    /// </summary>
    let ``shapes/ConditionalRegenerativeBrakeSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/ConditionalRegenerativeBrakeSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionalRegenerativeBrake"></see>
    /// </summary>
    let ``shapes/ConditionalRegenerativeBrake`` =
        Namespaced_IRI.parse _namespace_name "shapes/ConditionalRegenerativeBrake" |> NamespacedName

    /// <summary>
    /// Indication of the type of the contact line system.
    /// <see href="http://data.europa.eu/949/contactLineSystemType"></see></summary>
    let contactLineSystemType =
        Namespaced_IRI.parse _namespace_name "contactLineSystemType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trackResistanceToAppliedLoadsObjParameter"></see>
    /// </summary>
    let trackResistanceToAppliedLoadsObjParameter =
        Namespaced_IRI.parse _namespace_name "trackResistanceToAppliedLoadsObjParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trackObjParameter"></see>
    /// </summary>
    let trackObjParameter =
        Namespaced_IRI.parse _namespace_name "trackObjParameter" |> NamespacedName

    /// <summary>
    /// Name and/or reference of the document specifying the conditions applying in regards to regenerative braking.
    /// <see href="http://data.europa.eu/949/conditionsAppliedRegenerativeBraking"></see></summary>
    let conditionsAppliedRegenerativeBraking =
        Namespaced_IRI.parse _namespace_name "conditionsAppliedRegenerativeBraking" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsAppliedRegenerativeBrakingApplicability"></see>
    /// </summary>
    let ``shapes/ConditionsAppliedRegenerativeBrakingApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/ConditionsAppliedRegenerativeBrakingApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsAppliedRegenerativeBraking"></see>
    /// </summary>
    let ``shapes/ConditionsAppliedRegenerativeBraking`` =
        Namespaced_IRI.parse _namespace_name "shapes/ConditionsAppliedRegenerativeBraking" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/contactLineSystemObjParameter"></see>
    /// </summary>
    let contactLineSystemObjParameter =
        Namespaced_IRI.parse _namespace_name "contactLineSystemObjParameter" |> NamespacedName

    /// <summary>
    /// Conditions set by IMs according to a standardised document
    /// <see href="http://data.europa.eu/949/conditionsChargingElectricEnergyStorage"></see></summary>
    let conditionsChargingElectricEnergyStorage =
        Namespaced_IRI.parse _namespace_name "conditionsChargingElectricEnergyStorage" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsChargingElectricEnergyStorage"></see>
    /// </summary>
    let ``shapes/ConditionsChargingElectricEnergyStorage`` =
        Namespaced_IRI.parse _namespace_name "shapes/ConditionsChargingElectricEnergyStorage" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/contactLineSystemDataParameter"></see>
    /// </summary>
    let contactLineSystemDataParameter =
        Namespaced_IRI.parse _namespace_name "contactLineSystemDataParameter" |> NamespacedName

    /// <summary>
    /// Name and/or reference of the document specifying the Special technical conditions required to switch over between ERTMS/ETCS and Class B systems.
    /// <see href="http://data.europa.eu/949/conditionsSwitchClassBSystems"></see></summary>
    let conditionsSwitchClassBSystems =
        Namespaced_IRI.parse _namespace_name "conditionsSwitchClassBSystems" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsSwitchClassBSystems"></see>
    /// </summary>
    let ``shapes/ConditionsSwitchClassBSystems`` =
        Namespaced_IRI.parse _namespace_name "shapes/ConditionsSwitchClassBSystems" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsSwitchClassBSystemsApplicability"></see>
    /// </summary>
    let ``shapes/ConditionsSwitchClassBSystemsApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/ConditionsSwitchClassBSystemsApplicability" |> NamespacedName

    /// <summary>
    /// Indication whether a switch over between different systems whilst running exists.
    /// <see href="http://data.europa.eu/949/switchProtectControlWarning"></see></summary>
    let switchProtectControlWarning =
        Namespaced_IRI.parse _namespace_name "switchProtectControlWarning" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/transitionsBetweenSystemsObjParameter"></see>
    /// </summary>
    let transitionsBetweenSystemsObjParameter =
        Namespaced_IRI.parse _namespace_name "transitionsBetweenSystemsObjParameter" |> NamespacedName

    /// <summary>
    /// Conditions to switch over between different class B train protection, control and warning systems.
    /// <see href="http://data.europa.eu/949/conditionsSwitchTrainProtectionSystems"></see></summary>
    let conditionsSwitchTrainProtectionSystems =
        Namespaced_IRI.parse _namespace_name "conditionsSwitchTrainProtectionSystems" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsSwitchTrainProtectionSystems"></see>
    /// </summary>
    let ``shapes/ConditionsSwitchTrainProtectionSystems`` =
        Namespaced_IRI.parse _namespace_name "shapes/ConditionsSwitchTrainProtectionSystems" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/transitionsBetweenSystemsDataParameter"></see>
    /// </summary>
    let transitionsBetweenSystemsDataParameter =
        Namespaced_IRI.parse _namespace_name "transitionsBetweenSystemsDataParameter" |> NamespacedName

    /// <summary>
    /// Conditions of use regarding train formation.
    /// <see href="http://data.europa.eu/949/conditionsTrainFormation"></see></summary>
    let conditionsTrainFormation =
        Namespaced_IRI.parse _namespace_name "conditionsTrainFormation" |> NamespacedName

    /// <summary>
    /// Details of any conditions for using the reflective plates on freight corridors. Specific case for Portugal and Spain until 1.1.2025 and Belgium and France until 1.1.2026.
    /// <see href="http://data.europa.eu/949/conditionsUseReflectivePlates"></see></summary>
    let conditionsUseReflectivePlates =
        Namespaced_IRI.parse _namespace_name "conditionsUseReflectivePlates" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/conditions-use-reflective-plates/ConditionsUseReflectivePlates"></see>
    /// </summary>
    let ``concepts/conditions-use-reflective-plates/ConditionsUseReflectivePlates`` =
        Namespaced_IRI.parse _namespace_name "concepts/conditions-use-reflective-plates/ConditionsUseReflectivePlates" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsUseReflectivePlates"></see>
    /// </summary>
    let ``shapes/ConditionsUseReflectivePlates`` =
        Namespaced_IRI.parse _namespace_name "shapes/ConditionsUseReflectivePlates" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ConditionsUseReflectivePlatesSKOS"></see>
    /// </summary>
    let ``shapes/ConditionsUseReflectivePlatesSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/ConditionsUseReflectivePlatesSKOS" |> NamespacedName

    /// <summary>
    /// Represents a bidirectional connection between two Track instances.
    /// <see href="http://data.europa.eu/949/connectedTo"></see></summary>
    let connectedTo =
        Namespaced_IRI.parse _namespace_name "connectedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trackGenericObjParameter"></see>
    /// </summary>
    let trackGenericObjParameter =
        Namespaced_IRI.parse _namespace_name "trackGenericObjParameter" |> NamespacedName

    /// <summary>
    /// System that is used to transmit electrical energy to road or rail vehicles.
    /// <see href="http://data.europa.eu/949/contactLineSystem"></see></summary>
    let contactLineSystem =
        Namespaced_IRI.parse _namespace_name "contactLineSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactLineSystem"></see>
    /// </summary>
    let ``shapes/ContactLineSystem`` =
        Namespaced_IRI.parse _namespace_name "shapes/ContactLineSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/energySubsystemDataParameter"></see>
    /// </summary>
    let energySubsystemDataParameter =
        Namespaced_IRI.parse _namespace_name "energySubsystemDataParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/energySubsystemObjParameter"></see>
    /// </summary>
    let energySubsystemObjParameter =
        Namespaced_IRI.parse _namespace_name "energySubsystemObjParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/contact-line-systems/ContactLineSystems"></see>
    /// </summary>
    let ``concepts/contact-line-systems/ContactLineSystems`` =
        Namespaced_IRI.parse _namespace_name "concepts/contact-line-systems/ContactLineSystems" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactLineSystemTypeNotElectrifiedApplicability"></see>
    /// </summary>
    let ``shapes/ContactLineSystemTypeNotElectrifiedApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/ContactLineSystemTypeNotElectrifiedApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactLineSystemType"></see>
    /// </summary>
    let ``shapes/ContactLineSystemType`` =
        Namespaced_IRI.parse _namespace_name "shapes/ContactLineSystemType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactLineSystemTypeThirdOrFourthRailApplicability"></see>
    /// </summary>
    let ``shapes/ContactLineSystemTypeThirdOrFourthRailApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/ContactLineSystemTypeThirdOrFourthRailApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactLineSystemTypeSKOS"></see>
    /// </summary>
    let ``shapes/ContactLineSystemTypeSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/ContactLineSystemTypeSKOS" |> NamespacedName

    /// <summary>
    /// Indication of which contact strip materials are permitted to be used.
    /// <see href="http://data.europa.eu/949/contactStripMaterial"></see></summary>
    let contactStripMaterial =
        Namespaced_IRI.parse _namespace_name "contactStripMaterial" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/contact-strip-materials/ContactStripMaterials"></see>
    /// </summary>
    let ``concepts/contact-strip-materials/ContactStripMaterials`` =
        Namespaced_IRI.parse _namespace_name "concepts/contact-strip-materials/ContactStripMaterials" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactStripMaterialSKOS"></see>
    /// </summary>
    let ``shapes/ContactStripMaterialSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/ContactStripMaterialSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactStripMaterialApplicability"></see>
    /// </summary>
    let ``shapes/ContactStripMaterialApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/ContactStripMaterialApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/pantographObjParameter"></see>
    /// </summary>
    let pantographObjParameter =
        Namespaced_IRI.parse _namespace_name "pantographObjParameter" |> NamespacedName

    /// <summary>
    /// Indication of max. percentage of contact strip material Impregnated Carbon permitted to be used.
    /// <see href="http://data.europa.eu/949/contactStripMaterialMetallicContent"></see></summary>
    let contactStripMaterialMetallicContent =
        Namespaced_IRI.parse _namespace_name "contactStripMaterialMetallicContent" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContactStripMaterialMetallicContent"></see>
    /// </summary>
    let ``shapes/ContactStripMaterialMetallicContent`` =
        Namespaced_IRI.parse _namespace_name "shapes/ContactStripMaterialMetallicContent" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/pantographDataParameter"></see>
    /// </summary>
    let pantographDataParameter =
        Namespaced_IRI.parse _namespace_name "pantographDataParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/containerHandlingFlag"></see>
    /// </summary>
    let containerHandlingFlag =
        Namespaced_IRI.parse _namespace_name "containerHandlingFlag" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ContainerHandlingFlag"></see>
    /// </summary>
    let ``shapes/ContainerHandlingFlag`` =
        Namespaced_IRI.parse _namespace_name "shapes/ContainerHandlingFlag" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Contains"></see>
    /// </summary>
    let ``shapes/Contains`` =
        Namespaced_IRI.parse _namespace_name "shapes/Contains" |> NamespacedName

    /// <summary>
    /// Smallest cross section area in square metres of the tunnel
    /// <see href="http://data.europa.eu/949/crossSectionArea"></see></summary>
    let crossSectionArea =
        Namespaced_IRI.parse _namespace_name "crossSectionArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CrossSectionAreaApplicability"></see>
    /// </summary>
    let ``shapes/CrossSectionAreaApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/CrossSectionAreaApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CrossSectionAreaT"></see>
    /// </summary>
    let ``shapes/CrossSectionAreaT`` =
        Namespaced_IRI.parse _namespace_name "shapes/CrossSectionAreaT" |> NamespacedName

    /// <summary>
    /// Indication of whether an on board current or power limitation function on vehicles is required.
    /// <see href="http://data.europa.eu/949/currentLimitationRequired"></see></summary>
    let currentLimitationRequired =
        Namespaced_IRI.parse _namespace_name "currentLimitationRequired" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CurrentLimitationRequiredApplicability"></see>
    /// </summary>
    let ``shapes/CurrentLimitationRequiredApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/CurrentLimitationRequiredApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/CurrentLimitationRequired"></see>
    /// </summary>
    let ``shapes/CurrentLimitationRequired`` =
        Namespaced_IRI.parse _namespace_name "shapes/CurrentLimitationRequired" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/currentlyValid"></see>
    /// </summary>
    let currentlyValid =
        Namespaced_IRI.parse _namespace_name "currentlyValid" |> NamespacedName

    /// <summary>
    /// Maximum distance for overriding the train trip in metres, according to the specification referenced in Appendix A-1, index [C].
    /// <see href="http://data.europa.eu/949/dNvovtrp"></see></summary>
    let dNvovtrp = Namespaced_IRI.parse _namespace_name "dNvovtrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DNvovtrp"></see>
    /// </summary>
    let ``shapes/DNvovtrp`` =
        Namespaced_IRI.parse _namespace_name "shapes/DNvovtrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DNvovtrpApplicability"></see>
    /// </summary>
    let ``shapes/DNvovtrpApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/DNvovtrpApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/etcsNationalValuesDataParameter"></see>
    /// </summary>
    let etcsNationalValuesDataParameter =
        Namespaced_IRI.parse _namespace_name "etcsNationalValuesDataParameter" |> NamespacedName

    /// <summary>
    /// Maximum distance for reversing in Post Trip mode in metres, according to the specification referenced in Appendix A-1, index [C].
    /// <see href="http://data.europa.eu/949/dNvpotrp"></see></summary>
    let dNvpotrp = Namespaced_IRI.parse _namespace_name "dNvpotrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DNvpotrpApplicability"></see>
    /// </summary>
    let ``shapes/DNvpotrpApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/DNvpotrpApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DNvpotrp"></see>
    /// </summary>
    let ``shapes/DNvpotrp`` =
        Namespaced_IRI.parse _namespace_name "shapes/DNvpotrp" |> NamespacedName

    /// <summary>
    /// Parameter used by the ETCS on-board to supervise the distance allowed to be travelled under the roll-away protection and the reverse movement protection, in metres
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/dNvroll"></see></summary>
    let dNvroll = Namespaced_IRI.parse _namespace_name "dNvroll" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DNvroll"></see>
    /// </summary>
    let ``shapes/DNvroll`` =
        Namespaced_IRI.parse _namespace_name "shapes/DNvroll" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DNvrollApplicability"></see>
    /// </summary>
    let ``shapes/DNvrollApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/DNvrollApplicability" |> NamespacedName

    /// <summary>
    /// Dangerous goods for which the vehicle is suitable (tank code).
    /// <see href="http://data.europa.eu/949/dangerousGoodsTankCode"></see></summary>
    let dangerousGoodsTankCode =
        Namespaced_IRI.parse _namespace_name "dangerousGoodsTankCode" |> NamespacedName

    /// <summary>
    /// Data SIM Card GSM-R Home Network.
    /// <see href="http://data.europa.eu/949/dataGSMRNetwork"></see></summary>
    let dataGSMRNetwork =
        Namespaced_IRI.parse _namespace_name "dataGSMRNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gsmr-networks/GSMRNetworks"></see>
    /// </summary>
    let ``concepts/gsmr-networks/GSMRNetworks`` =
        Namespaced_IRI.parse _namespace_name "concepts/gsmr-networks/GSMRNetworks" |> NamespacedName

    /// <summary>
    /// Radio requirements used for demonstrating technical compatibility data.
    /// <see href="http://data.europa.eu/949/dataRadioCompatible"></see></summary>
    let dataRadioCompatible =
        Namespaced_IRI.parse _namespace_name "dataRadioCompatible" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/radio-system-compatibilities-data/RadioSystemCompatibilitiesData"></see>
    /// </summary>
    let ``concepts/radio-system-compatibilities-data/RadioSystemCompatibilitiesData`` =
        Namespaced_IRI.parse _namespace_name "concepts/radio-system-compatibilities-data/RadioSystemCompatibilitiesData" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DataRadioCompatible"></see>
    /// </summary>
    let ``shapes/DataRadioCompatible`` =
        Namespaced_IRI.parse _namespace_name "shapes/DataRadioCompatible" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DataRadioCompatibleSKOS"></see>
    /// </summary>
    let ``shapes/DataRadioCompatibleSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/DataRadioCompatibleSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DataRadioCompatibleApplicability"></see>
    /// </summary>
    let ``shapes/DataRadioCompatibleApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/DataRadioCompatibleApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/tsiCompliantRadioObjParameter"></see>
    /// </summary>
    let tsiCompliantRadioObjParameter =
        Namespaced_IRI.parse _namespace_name "tsiCompliantRadioObjParameter" |> NamespacedName

    /// <summary>
    /// (deprecated) not in use anymore. For the purposes of the register of infrastructure, each infrastructure manager may describe its railway network optionally via common characteristic subsets.
    /// <see href="http://data.europa.eu/949/definesSubset"></see></summary>
    let definesSubset =
        Namespaced_IRI.parse _namespace_name "definesSubset" |> NamespacedName

    /// <summary>
    /// Unique number for EI declarations following the same format requirements as specified for EC declarations in Annex VII of Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/demonstrationENE"></see></summary>
    let demonstrationENE =
        Namespaced_IRI.parse _namespace_name "demonstrationENE" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DemonstrationENE"></see>
    /// </summary>
    let ``shapes/DemonstrationENE`` =
        Namespaced_IRI.parse _namespace_name "shapes/DemonstrationENE" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/energySubsystemDeclarationsVerificationTrackDataParameter"></see>
    /// </summary>
    let energySubsystemDeclarationsVerificationTrackDataParameter =
        Namespaced_IRI.parse _namespace_name "energySubsystemDeclarationsVerificationTrackDataParameter" |> NamespacedName

    /// <summary>
    /// Unique number for EI declarations following the same format requirements as specified for EC declarations in Annex VII of Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/demonstrationINF"></see></summary>
    let demonstrationINF =
        Namespaced_IRI.parse _namespace_name "demonstrationINF" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DemonstrationINFS"></see>
    /// </summary>
    let ``shapes/DemonstrationINFS`` =
        Namespaced_IRI.parse _namespace_name "shapes/DemonstrationINFS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DemonstrationINF"></see>
    /// </summary>
    let ``shapes/DemonstrationINF`` =
        Namespaced_IRI.parse _namespace_name "shapes/DemonstrationINF" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/infraSubsystemDeclarationsVerificationTrackDataParameter"></see>
    /// </summary>
    let infraSubsystemDeclarationsVerificationTrackDataParameter =
        Namespaced_IRI.parse _namespace_name "infraSubsystemDeclarationsVerificationTrackDataParameter" |> NamespacedName

    /// <summary>
    /// Unique number for EI declarations following the same format requirements as specified for EC declarations in Annex VII of Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/demonstrationSRT"></see></summary>
    let demonstrationSRT =
        Namespaced_IRI.parse _namespace_name "demonstrationSRT" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DemonstrationSRT"></see>
    /// </summary>
    let ``shapes/DemonstrationSRT`` =
        Namespaced_IRI.parse _namespace_name "shapes/DemonstrationSRT" |> NamespacedName

    /// <summary>
    /// Design mass under exceptional payload.
    /// <see href="http://data.europa.eu/949/designMassExceptionalPayload"></see></summary>
    let designMassExceptionalPayload =
        Namespaced_IRI.parse _namespace_name "designMassExceptionalPayload" |> NamespacedName

    /// <summary>
    /// Design mass under normal payload.
    /// <see href="http://data.europa.eu/949/designMassNormalPayload"></see></summary>
    let designMassNormalPayload =
        Namespaced_IRI.parse _namespace_name "designMassNormalPayload" |> NamespacedName

    /// <summary>
    /// Design mass in working order.
    /// <see href="http://data.europa.eu/949/designMassWorkingOrder"></see></summary>
    let designMassWorkingOrder =
        Namespaced_IRI.parse _namespace_name "designMassWorkingOrder" |> NamespacedName

    /// <summary>
    /// Indication whether it is allowed to use diesel or other thermal traction in the tunnel
    /// <see href="http://data.europa.eu/949/dieselThermalAllowed"></see></summary>
    let dieselThermalAllowed =
        Namespaced_IRI.parse _namespace_name "dieselThermalAllowed" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DieselThermalAllowed"></see>
    /// </summary>
    let ``shapes/DieselThermalAllowed`` =
        Namespaced_IRI.parse _namespace_name "shapes/DieselThermalAllowed" |> NamespacedName

    /// <summary>
    /// Diagrammatic representation of the operational point in Well Known Text polyline
    /// <see href="http://data.europa.eu/949/digitalSchematicOverview"></see></summary>
    let digitalSchematicOverview =
        Namespaced_IRI.parse _namespace_name "digitalSchematicOverview" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DigitalSchematicOverview"></see>
    /// </summary>
    let ``shapes/DigitalSchematicOverview`` =
        Namespaced_IRI.parse _namespace_name "shapes/DigitalSchematicOverview" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/opGenericDataParameter"></see>
    /// </summary>
    let opGenericDataParameter =
        Namespaced_IRI.parse _namespace_name "opGenericDataParameter" |> NamespacedName

    /// <summary>
    /// The direction of the orientation of a railway element, in relation to the carrier linear element
    /// <see href="http://data.europa.eu/949/direction"></see></summary>
    let direction = Namespaced_IRI.parse _namespace_name "direction" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Direction"></see>
    /// </summary>
    let ``shapes/Direction`` =
        Namespaced_IRI.parse _namespace_name "shapes/Direction" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DirectionSKOS"></see>
    /// </summary>
    let ``shapes/DirectionSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/DirectionSKOS" |> NamespacedName

    /// <summary>
    /// Distance between the signboard authorizing the driver to  raise pantograph  or  close the circuit breaker  after passing the phase separation and the end of the phase separation section.
    /// <see href="http://data.europa.eu/949/distSignToPhaseEnd"></see></summary>
    let distSignToPhaseEnd =
        Namespaced_IRI.parse _namespace_name "distSignToPhaseEnd" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DistSignToPhaseEnd"></see>
    /// </summary>
    let ``shapes/DistSignToPhaseEnd`` =
        Namespaced_IRI.parse _namespace_name "shapes/DistSignToPhaseEnd" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/oclSeparationSectionsDataParameter"></see>
    /// </summary>
    let oclSeparationSectionsDataParameter =
        Namespaced_IRI.parse _namespace_name "oclSeparationSectionsDataParameter" |> NamespacedName

    /// <summary>
    /// Name and/or reference of the document specifying the restriction(s) related to the position of Multiple Traction unit(s) to comply with contact line separation.
    /// <see href="http://data.europa.eu/949/documentRestrictionPositionContactLineSeparation"></see></summary>
    let documentRestrictionPositionContactLineSeparation =
        Namespaced_IRI.parse _namespace_name "documentRestrictionPositionContactLineSeparation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DocumentRestrictionPositionContactLineSeparation"></see>
    /// </summary>
    let ``shapes/DocumentRestrictionPositionContactLineSeparation`` =
        Namespaced_IRI.parse _namespace_name "shapes/DocumentRestrictionPositionContactLineSeparation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/requirementsRollingStockObjParameter"></see>
    /// </summary>
    let requirementsRollingStockObjParameter =
        Namespaced_IRI.parse _namespace_name "requirementsRollingStockObjParameter" |> NamespacedName

    /// <summary>
    /// Name and/or reference of the document specifying the restriction(s) related to power consumption of specific electric traction unit(s).
    /// <see href="http://data.europa.eu/949/documentRestrictionPowerConsumption"></see></summary>
    let documentRestrictionPowerConsumption =
        Namespaced_IRI.parse _namespace_name "documentRestrictionPowerConsumption" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DocumentRestrictionPowerConsumption"></see>
    /// </summary>
    let ``shapes/DocumentRestrictionPowerConsumption`` =
        Namespaced_IRI.parse _namespace_name "shapes/DocumentRestrictionPowerConsumption" |> NamespacedName

    /// <summary>
    /// URL that is used to download a document, e.g. url for a reference document in RINF.
    /// <see href="http://data.europa.eu/949/documentUrl"></see></summary>
    let documentUrl =
        Namespaced_IRI.parse _namespace_name "documentUrl" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/DocumentUrl"></see>
    /// </summary>
    let ``shapes/DocumentUrl`` =
        Namespaced_IRI.parse _namespace_name "shapes/DocumentUrl" |> NamespacedName

    /// <summary>
    /// Number of driving cabs. For wagons the number of driving cabs is to be set to zero (0).
    /// <see href="http://data.europa.eu/949/drivingCabs"></see></summary>
    let drivingCabs =
        Namespaced_IRI.parse _namespace_name "drivingCabs" |> NamespacedName

    /// <summary>
    /// Possibility of preventing the use of the eddy current track brake (only if fitted with eddy current brake)
    /// <see href="http://data.europa.eu/949/eddyCurrentBrakePrevention"></see></summary>
    let eddyCurrentBrakePrevention =
        Namespaced_IRI.parse _namespace_name "eddyCurrentBrakePrevention" |> NamespacedName

    /// <summary>
    /// Indication of limitations on the use of eddy current brakes.
    /// <see href="http://data.europa.eu/949/eddyCurrentBraking"></see></summary>
    let eddyCurrentBraking =
        Namespaced_IRI.parse _namespace_name "eddyCurrentBraking" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/eddy-current-braking/EddyCurrentBraking"></see>
    /// </summary>
    let ``concepts/eddy-current-braking/EddyCurrentBraking`` =
        Namespaced_IRI.parse _namespace_name "concepts/eddy-current-braking/EddyCurrentBraking" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EddyCurrentBraking"></see>
    /// </summary>
    let ``shapes/EddyCurrentBraking`` =
        Namespaced_IRI.parse _namespace_name "shapes/EddyCurrentBraking" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EddyCurrentBrakingSKOS"></see>
    /// </summary>
    let ``shapes/EddyCurrentBrakingSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/EddyCurrentBrakingSKOS" |> NamespacedName

    /// <summary>
    /// Electronic document available in two EU languages from the IM stored by the Agency with conditions for the use of eddy current brakes identified in 1.1.1.1.6.2.
    /// <see href="http://data.europa.eu/949/eddyCurrentBrakingConditionsDocument"></see></summary>
    let eddyCurrentBrakingConditionsDocument =
        Namespaced_IRI.parse _namespace_name "eddyCurrentBrakingConditionsDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EddyCurrentBrakingConditionsDocumentApplicability"></see>
    /// </summary>
    let ``shapes/EddyCurrentBrakingConditionsDocumentApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/EddyCurrentBrakingConditionsDocumentApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EddyCurrentBrakingConditionsDocument"></see>
    /// </summary>
    let ``shapes/EddyCurrentBrakingConditionsDocument`` =
        Namespaced_IRI.parse _namespace_name "shapes/EddyCurrentBrakingConditionsDocument" |> NamespacedName

    /// <summary>
    /// Eddy current track brake fitted. New property defined to distinguish it from eddyCurrentBraking which is a RINF SKOS property.
    /// <see href="http://data.europa.eu/949/eddyCurrentBrakingFitted"></see></summary>
    let eddyCurrentBrakingFitted =
        Namespaced_IRI.parse _namespace_name "eddyCurrentBrakingFitted" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ElementA"></see>
    /// </summary>
    let ``shapes/ElementA`` =
        Namespaced_IRI.parse _namespace_name "shapes/ElementA" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ElementB"></see>
    /// </summary>
    let ``shapes/ElementB`` =
        Namespaced_IRI.parse _namespace_name "shapes/ElementB" |> NamespacedName

    /// <summary>
    /// References the topology object of a higher-granularity level which contains a lower-granularity topology object.
    /// <see href="http://data.europa.eu/949/elementPart"></see></summary>
    let elementPart =
        Namespaced_IRI.parse _namespace_name "elementPart" |> NamespacedName

    /// <summary>
    /// Stopping distance and deceleration profile for each load condition per design maximum speed.
    /// <see href="http://data.europa.eu/949/emergencyBrake"></see></summary>
    let emergencyBrake =
        Namespaced_IRI.parse _namespace_name "emergencyBrake" |> NamespacedName

    /// <summary>
    /// Type of end coupling (indicating tensile and compressive forces).
    /// <see href="http://data.europa.eu/949/endCouplingType"></see></summary>
    let endCouplingType =
        Namespaced_IRI.parse _namespace_name "endCouplingType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/end-coupling-type/EndCouplingType"></see>
    /// </summary>
    let ``concepts/end-coupling-type/EndCouplingType`` =
        Namespaced_IRI.parse _namespace_name "concepts/end-coupling-type/EndCouplingType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/endIntrinsicCoordinate"></see>
    /// </summary>
    let endIntrinsicCoordinate =
        Namespaced_IRI.parse _namespace_name "endIntrinsicCoordinate" |> NamespacedName

    /// <summary>
    /// Geographical coordinates in decimal degrees and km of the line at the end of a tunnel.
    /// <see href="http://data.europa.eu/949/endLocation"></see></summary>
    let endLocation =
        Namespaced_IRI.parse _namespace_name "endLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EndLocation"></see>
    /// </summary>
    let ``shapes/EndLocation`` =
        Namespaced_IRI.parse _namespace_name "shapes/EndLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/tunnelObjParameter"></see>
    /// </summary>
    let tunnelObjParameter =
        Namespaced_IRI.parse _namespace_name "tunnelObjParameter" |> NamespacedName

    /// <summary>
    /// End offset of the section from the origin.
    /// <see href="http://data.europa.eu/949/endOffsetFromOrigin"></see></summary>
    let endOffsetFromOrigin =
        Namespaced_IRI.parse _namespace_name "endOffsetFromOrigin" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EndOffsetFromOrigin"></see>
    /// </summary>
    let ``shapes/EndOffsetFromOrigin`` =
        Namespaced_IRI.parse _namespace_name "shapes/EndOffsetFromOrigin" |> NamespacedName

    /// <summary>
    /// Specifies the ending point of a linear reference.
    /// <see href="http://data.europa.eu/949/endsAt"></see></summary>
    let endsAt = Namespaced_IRI.parse _namespace_name "endsAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EndsAt"></see>
    /// </summary>
    let ``shapes/EndsAt`` =
        Namespaced_IRI.parse _namespace_name "shapes/EndsAt" |> NamespacedName

    /// <summary>
    /// TSI conform energy meter for billing purposes installed on board.
    /// <see href="http://data.europa.eu/949/energyMeterInstalled"></see></summary>
    let energyMeterInstalled =
        Namespaced_IRI.parse _namespace_name "energyMeterInstalled" |> NamespacedName

    /// <summary>
    /// Maximum power (to be indicated for each energy supply system the vehicle is equipped for), given in kW.
    /// <see href="http://data.europa.eu/949/energySupplyMaxPower"></see></summary>
    let energySupplyMaxPower =
        Namespaced_IRI.parse _namespace_name "energySupplyMaxPower" |> NamespacedName

    /// <summary>
    /// Indication of the traction supply system (nominal voltage and frequency).
    /// <see href="http://data.europa.eu/949/energySupplySystem"></see></summary>
    let energySupplySystem =
        Namespaced_IRI.parse _namespace_name "energySupplySystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/energy-supply-systems/EnergySupplySystems"></see>
    /// </summary>
    let ``concepts/energy-supply-systems/EnergySupplySystems`` =
        Namespaced_IRI.parse _namespace_name "concepts/energy-supply-systems/EnergySupplySystems" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EnergySupplySystem"></see>
    /// </summary>
    let ``shapes/EnergySupplySystem`` =
        Namespaced_IRI.parse _namespace_name "shapes/EnergySupplySystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EnergySupplySystemSKOS"></see>
    /// </summary>
    let ``shapes/EnergySupplySystemSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/EnergySupplySystemSKOS" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication if the traction supply system (nominal voltage and frequency) is fully compliant with TSI.
    /// <see href="http://data.europa.eu/949/energySupplySystemTSICompliant"></see></summary>
    let energySupplySystemTSICompliant =
        Namespaced_IRI.parse _namespace_name "energySupplySystemTSICompliant" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EnergySupplySystemTSICompliant"></see>
    /// </summary>
    let ``shapes/EnergySupplySystemTSICompliant`` =
        Namespaced_IRI.parse _namespace_name "shapes/EnergySupplySystemTSICompliant" |> NamespacedName

    /// <summary>
    /// List of unacceptable errors impacting the IM network that are required to be solved in the on-board according to the TSI CCS point 7.2.10.3 specification maintenance point (ETCS, GSM-R and/or ATO). An additional parameter (era:errorCorrectionsOnboardExplanation) must document if a non-implemented CR has been accepted by the IM.
    /// <see href="http://data.europa.eu/949/errorCorrectionsOnboard"></see></summary>
    let errorCorrectionsOnboard =
        Namespaced_IRI.parse _namespace_name "errorCorrectionsOnboard" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/error-corrections/OnboardErrorCorrections"></see>
    /// </summary>
    let ``concepts/error-corrections/OnboardErrorCorrections`` =
        Namespaced_IRI.parse _namespace_name "concepts/error-corrections/OnboardErrorCorrections" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ErrorCorrectionsOnboardSKOS"></see>
    /// </summary>
    let ``shapes/ErrorCorrectionsOnboardSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/ErrorCorrectionsOnboardSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ErrorCorrectionsOnboard"></see>
    /// </summary>
    let ``shapes/ErrorCorrectionsOnboard`` =
        Namespaced_IRI.parse _namespace_name "shapes/ErrorCorrectionsOnboard" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/ertmsErrorCorrectionsOnBoard"></see>
    /// </summary>
    let ertmsErrorCorrectionsOnBoard =
        Namespaced_IRI.parse _namespace_name "ertmsErrorCorrectionsOnBoard" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/etcsErrorCorrectionsOnboard"></see>
    /// </summary>
    let etcsErrorCorrectionsOnboard =
        Namespaced_IRI.parse _namespace_name "etcsErrorCorrectionsOnboard" |> NamespacedName

    /// <summary>
    /// List of unacceptable errors impacting the IM network that are required to be solved in the on-board according to the CCS TSI point 7.2.10.3 specification maintenance point.
    /// The reason for deprecation is that this parameter does not appear in the latest legal text.
    /// <see href="http://data.europa.eu/949/gsmrErrorCorrectionsOnboard"></see></summary>
    let gsmrErrorCorrectionsOnboard =
        Namespaced_IRI.parse _namespace_name "gsmrErrorCorrectionsOnboard" |> NamespacedName

    /// <summary>
    /// Explanation on why a mandatory onboard CR required to be solved in the on-board (ETCS, GSM-R and/or ATO) was accepted by the IM.
    /// <see href="http://data.europa.eu/949/errorCorrectionsOnboardExplanation"></see></summary>
    let errorCorrectionsOnboardExplanation =
        Namespaced_IRI.parse _namespace_name "errorCorrectionsOnboardExplanation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ErrorCorrectionsOnboardExplanation"></see>
    /// </summary>
    let ``shapes/ErrorCorrectionsOnboardExplanation`` =
        Namespaced_IRI.parse _namespace_name "shapes/ErrorCorrectionsOnboardExplanation" |> NamespacedName

    /// <summary>
    /// European Train Control System (ETCS) application level supported by the track side equipment.
    /// <see href="http://data.europa.eu/949/etcs"></see></summary>
    let etcs = Namespaced_IRI.parse _namespace_name "etcs" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Etcs"></see>
    /// </summary>
    let ``shapes/Etcs`` =
        Namespaced_IRI.parse _namespace_name "shapes/Etcs" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-baselines/ETCSBaselines"></see>
    /// </summary>
    let ``concepts/etcs-baselines/ETCSBaselines`` =
        Namespaced_IRI.parse _namespace_name "concepts/etcs-baselines/ETCSBaselines" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsBaselineApplicability"></see>
    /// </summary>
    let ``shapes/EtcsBaselineApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsBaselineApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsBaseline"></see>
    /// </summary>
    let ``shapes/EtcsBaseline`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsBaseline" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsBaselineSKOS"></see>
    /// </summary>
    let ``shapes/EtcsBaselineSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsBaselineSKOS" |> NamespacedName

    /// <summary>
    /// Data communication application for ETCS implementation.
    /// <see href="http://data.europa.eu/949/etcsDataCommApp"></see></summary>
    let etcsDataCommApp =
        Namespaced_IRI.parse _namespace_name "etcsDataCommApp" |> NamespacedName

    /// <summary>
    /// ERTMS / ETCS application level for degraded situation related to the track side equipment.
    /// <see href="http://data.europa.eu/949/etcsDegradedSituation"></see></summary>
    let etcsDegradedSituation =
        Namespaced_IRI.parse _namespace_name "etcsDegradedSituation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-situation/ETCSSituations"></see>
    /// </summary>
    let ``concepts/etcs-situation/ETCSSituations`` =
        Namespaced_IRI.parse _namespace_name "concepts/etcs-situation/ETCSSituations" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsDegradedSituation"></see>
    /// </summary>
    let ``shapes/EtcsDegradedSituation`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsDegradedSituation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsDegradedSituationApplicability"></see>
    /// </summary>
    let ``shapes/EtcsDegradedSituationApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsDegradedSituationApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsDegradedSituationSKOS"></see>
    /// </summary>
    let ``shapes/EtcsDegradedSituationSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsDegradedSituationSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/lineSideSystemDegradedSituationObjParameter"></see>
    /// </summary>
    let lineSideSystemDegradedSituationObjParameter =
        Namespaced_IRI.parse _namespace_name "lineSideSystemDegradedSituationObjParameter" |> NamespacedName

    /// <summary>
    /// ETCS equipment on-board and its level.
    /// <see href="http://data.europa.eu/949/etcsEquipmentOnBoardLevel"></see></summary>
    let etcsEquipmentOnBoardLevel =
        Namespaced_IRI.parse _namespace_name "etcsEquipmentOnBoardLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-equipment-on-board-level/eratv/ETCSEquipmentLevels"></see>
    /// </summary>
    let ``concepts/etcs-equipment-on-board-level/eratv/ETCSEquipmentLevels`` =
        Namespaced_IRI.parse _namespace_name "concepts/etcs-equipment-on-board-level/eratv/ETCSEquipmentLevels" |> NamespacedName

    /// <summary>
    /// If the trackside does not implement any solution to cover non-protected LXs (which are normally protected by means of a technical system), then drivers will be required to comply with instructions received from other sources
    /// <see href="http://data.europa.eu/949/etcsImplementsLevelCrossingProcedure"></see></summary>
    let etcsImplementsLevelCrossingProcedure =
        Namespaced_IRI.parse _namespace_name "etcsImplementsLevelCrossingProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsImplementsLevelCrossingProcedureApplicability"></see>
    /// </summary>
    let ``shapes/EtcsImplementsLevelCrossingProcedureApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsImplementsLevelCrossingProcedureApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsImplementsLevelCrossingProcedure"></see>
    /// </summary>
    let ``shapes/EtcsImplementsLevelCrossingProcedure`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsImplementsLevelCrossingProcedure" |> NamespacedName

    /// <summary>
    /// Information about installed trackside equipment capable to transmit infill information by loop or Global System for Mobile communications for Railways (GSM-R) for level 1 installations.
    /// <see href="http://data.europa.eu/949/etcsInfill"></see></summary>
    let etcsInfill = Namespaced_IRI.parse _namespace_name "etcsInfill" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-infills/ETCSInfills"></see>
    /// </summary>
    let ``concepts/etcs-infills/ETCSInfills`` =
        Namespaced_IRI.parse _namespace_name "concepts/etcs-infills/ETCSInfills" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsInfillSKOS"></see>
    /// </summary>
    let ``shapes/EtcsInfillSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsInfillSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsInfillApplicability"></see>
    /// </summary>
    let ``shapes/EtcsInfillApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsInfillApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsInfill"></see>
    /// </summary>
    let ``shapes/EtcsInfill`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsInfill" |> NamespacedName

    /// <summary>
    /// Indication whether infill is required to access the line for safety reasons.
    /// <see href="http://data.europa.eu/949/etcsInfillLineAccess"></see></summary>
    let etcsInfillLineAccess =
        Namespaced_IRI.parse _namespace_name "etcsInfillLineAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsInfillLineAccess"></see>
    /// </summary>
    let ``shapes/EtcsInfillLineAccess`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsInfillLineAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsInfillLineAccessApplicability"></see>
    /// </summary>
    let ``shapes/EtcsInfillLineAccessApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsInfillLineAccessApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-levels/ETCSLevels"></see>
    /// </summary>
    let ``concepts/etcs-levels/ETCSLevels`` =
        Namespaced_IRI.parse _namespace_name "concepts/etcs-levels/ETCSLevels" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsLevelTypeSKOS"></see>
    /// </summary>
    let ``shapes/EtcsLevelTypeSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsLevelTypeSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsLevelType"></see>
    /// </summary>
    let ``shapes/EtcsLevelType`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsLevelType" |> NamespacedName

    /// <summary>
    /// Transmittable track conditions by the CCSSubsystem, according to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/etcsTransmittedTrackConditions"></see></summary>
    let etcsTransmittedTrackConditions =
        Namespaced_IRI.parse _namespace_name "etcsTransmittedTrackConditions" |> NamespacedName

    /// <summary>
    /// ETCS requirements used for demonstrating technical compatibility.
    /// <see href="http://data.europa.eu/949/etcsSystemCompatibility"></see></summary>
    let etcsSystemCompatibility =
        Namespaced_IRI.parse _namespace_name "etcsSystemCompatibility" |> NamespacedName

    /// <summary>
    /// Unique RBC identification (NID_C+NID_RBC)  as defined in the specification referenced in Appendix A-1, index [C] (TSI CCS).
    /// <see href="http://data.europa.eu/949/rbcID"></see></summary>
    let rbcID = Namespaced_IRI.parse _namespace_name "rbcID" |> NamespacedName

    /// <summary>
    /// Number of simultaneous communication session on board for ETCS level 2 required for a smooth running of the train. This relates to the radio block centre (RBC) handling of communication sessions. Not safety critical and no matter of interoperability.
    /// <see href="http://data.europa.eu/949/gsmRActiveMobiles"></see></summary>
    let gsmRActiveMobiles =
        Namespaced_IRI.parse _namespace_name "gsmRActiveMobiles" |> NamespacedName

    /// <summary>
    /// Unique RBC calling number (NID_RADIO) as defined in the specification referenced in Appendix A-1, index [C].
    /// <see href="http://data.europa.eu/949/rbcPhone"></see></summary>
    let rbcPhone = Namespaced_IRI.parse _namespace_name "rbcPhone" |> NamespacedName

    /// <summary>
    /// ETCS M_version according to the specification referenced in Appendix A-1, index [C], SRS 7.5.1.9.
    /// <see href="http://data.europa.eu/949/etcsMVersion"></see></summary>
    let etcsMVersion =
        Namespaced_IRI.parse _namespace_name "etcsMVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-m-versions/ETCSMVersions"></see>
    /// </summary>
    let ``concepts/etcs-m-versions/ETCSMVersions`` =
        Namespaced_IRI.parse _namespace_name "concepts/etcs-m-versions/ETCSMVersions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsMVersionApplicability"></see>
    /// </summary>
    let ``shapes/EtcsMVersionApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsMVersionApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsMVersionSKOS"></see>
    /// </summary>
    let ``shapes/EtcsMVersionSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsMVersionSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsMVersion"></see>
    /// </summary>
    let ``shapes/EtcsMVersion`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsMVersion" |> NamespacedName

    /// <summary>
    /// ETCS national applications implemented (NID_XUSER of Packet 44).
    /// <see href="http://data.europa.eu/949/etcsNationalApplications"></see></summary>
    let etcsNationalApplications =
        Namespaced_IRI.parse _namespace_name "etcsNationalApplications" |> NamespacedName

    /// <summary>
    /// Indication whether data for national applications is transmitted between track and train.
    /// <see href="http://data.europa.eu/949/etcsNationalPacket44"></see></summary>
    let etcsNationalPacket44 =
        Namespaced_IRI.parse _namespace_name "etcsNationalPacket44" |> NamespacedName

    /// <summary>
    /// Indication whether data for national packet 44 applications is transmitted between track and train.
    /// <see href="http://data.europa.eu/949/hasEtcsNationalPacket44"></see></summary>
    let hasEtcsNationalPacket44 =
        Namespaced_IRI.parse _namespace_name "hasEtcsNationalPacket44" |> NamespacedName

    /// <summary>
    /// Indication whether data for national applications is transmitted between track and train.
    /// <see href="http://data.europa.eu/949/etcsNationalPacket44Function"></see></summary>
    let etcsNationalPacket44Function =
        Namespaced_IRI.parse _namespace_name "etcsNationalPacket44Function" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-national-packet-44-functions/ETCSNationalPacket44Functions"></see>
    /// </summary>
    let ``concepts/etcs-national-packet-44-functions/ETCSNationalPacket44Functions`` =
        Namespaced_IRI.parse _namespace_name "concepts/etcs-national-packet-44-functions/ETCSNationalPacket44Functions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsNationalPacket44Function"></see>
    /// </summary>
    let ``shapes/EtcsNationalPacket44Function`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsNationalPacket44Function" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsNationalPacket44FunctionSKOS"></see>
    /// </summary>
    let ``shapes/EtcsNationalPacket44FunctionSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsNationalPacket44FunctionSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/etcsNationalValuesObjParameter"></see>
    /// </summary>
    let etcsNationalValuesObjParameter =
        Namespaced_IRI.parse _namespace_name "etcsNationalValuesObjParameter" |> NamespacedName

    /// <summary>
    /// ETCS on-board implementation.
    /// <see href="http://data.europa.eu/949/etcsOnBoardImplementation"></see></summary>
    let etcsOnBoardImplementation =
        Namespaced_IRI.parse _namespace_name "etcsOnBoardImplementation" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Optional ETCS functions which might improve operation on the line.
    /// <see href="http://data.europa.eu/949/etcsOptionalFunctions"></see></summary>
    let etcsOptionalFunctions =
        Namespaced_IRI.parse _namespace_name "etcsOptionalFunctions" |> NamespacedName

    /// <summary>
    /// Indication of the document where restrictions or conditions due to partial compliance with the TSI CCS are described.
    /// <see href="http://data.europa.eu/949/etcsRestrictionsConditionsDoc"></see></summary>
    let etcsRestrictionsConditionsDoc =
        Namespaced_IRI.parse _namespace_name "etcsRestrictionsConditionsDoc" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsRestrictionsConditionsDoc"></see>
    /// </summary>
    let ``shapes/EtcsRestrictionsConditionsDoc`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsRestrictionsConditionsDoc" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsRestrictionsConditionsDocApplicability"></see>
    /// </summary>
    let ``shapes/EtcsRestrictionsConditionsDocApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsRestrictionsConditionsDocApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-system-compatibilities/ETCSSystemCompatibilities"></see>
    /// </summary>
    let ``concepts/etcs-system-compatibilities/ETCSSystemCompatibilities`` =
        Namespaced_IRI.parse _namespace_name "concepts/etcs-system-compatibilities/ETCSSystemCompatibilities" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsSystemCompatibilitySKOS"></see>
    /// </summary>
    let ``shapes/EtcsSystemCompatibilitySKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsSystemCompatibilitySKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsSystemCompatibilityApplicability"></see>
    /// </summary>
    let ``shapes/EtcsSystemCompatibilityApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsSystemCompatibilityApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsSystemCompatibility"></see>
    /// </summary>
    let ``shapes/EtcsSystemCompatibility`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsSystemCompatibility" |> NamespacedName

    /// <summary>
    /// (Deprecated) List of ETCS system version 2.2 or 3.0 functionalities to be required in the next 5 years according to TSI CCS point 6.1.1.2 and Appendix G
    /// <see href="http://data.europa.eu/949/etcsSystemFunctionalitiesNextFiveYears"></see></summary>
    let etcsSystemFunctionalitiesNextFiveYears =
        Namespaced_IRI.parse _namespace_name "etcsSystemFunctionalitiesNextFiveYears" |> NamespacedName

    /// <summary>
    /// If the trackside does not provide Track Conditions, the driver will need to be informed about such conditions via alternative methods.
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/etcsTransmitsTrackConditions"></see></summary>
    let etcsTransmitsTrackConditions =
        Namespaced_IRI.parse _namespace_name "etcsTransmitsTrackConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsTransmitsTrackConditionsApplicability"></see>
    /// </summary>
    let ``shapes/EtcsTransmitsTrackConditionsApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsTransmitsTrackConditionsApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsTransmitsTrackConditions"></see>
    /// </summary>
    let ``shapes/EtcsTransmitsTrackConditions`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsTransmitsTrackConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-transmitted-tcs/TransmittedTrackConditions"></see>
    /// </summary>
    let ``concepts/etcs-transmitted-tcs/TransmittedTrackConditions`` =
        Namespaced_IRI.parse _namespace_name "concepts/etcs-transmitted-tcs/TransmittedTrackConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsTransmittedTrackConditions"></see>
    /// </summary>
    let ``shapes/EtcsTransmittedTrackConditions`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsTransmittedTrackConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsTransmittedTrackConditionsSKOS"></see>
    /// </summary>
    let ``shapes/EtcsTransmittedTrackConditionsSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsTransmittedTrackConditionsSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EtcsTransmittedTrackConditionsApplicability"></see>
    /// </summary>
    let ``shapes/EtcsTransmittedTrackConditionsApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/EtcsTransmittedTrackConditionsApplicability" |> NamespacedName

    /// <summary>
    /// Indication of which European Transport Corridor the element belongs to.
    /// <see href="http://data.europa.eu/949/europeanTransportCorridor"></see></summary>
    let europeanTransportCorridor =
        Namespaced_IRI.parse _namespace_name "europeanTransportCorridor" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/european-transport-corridors/EuropeanTransportCorridors"></see>
    /// </summary>
    let ``concepts/european-transport-corridors/EuropeanTransportCorridors`` =
        Namespaced_IRI.parse _namespace_name "concepts/european-transport-corridors/EuropeanTransportCorridors" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EuropeanTransportCorridorSKOS"></see>
    /// </summary>
    let ``shapes/EuropeanTransportCorridorSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/EuropeanTransportCorridorSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/EuropeanTransportCorridor"></see>
    /// </summary>
    let ``shapes/EuropeanTransportCorridor`` =
        Namespaced_IRI.parse _namespace_name "shapes/EuropeanTransportCorridor" |> NamespacedName

    /// <summary>
    /// Indicates whether special vehicles are exempted from the need to install ATO (Automatic Train Operation) for this infrastructure element.
    /// <see href="http://data.europa.eu/949/exemptSpecialVehiclesFromATO"></see></summary>
    let exemptSpecialVehiclesFromATO =
        Namespaced_IRI.parse _namespace_name "exemptSpecialVehiclesFromATO" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ExemptSpecialVehiclesFromATO"></see>
    /// </summary>
    let ``shapes/ExemptSpecialVehiclesFromATO`` =
        Namespaced_IRI.parse _namespace_name "shapes/ExemptSpecialVehiclesFromATO" |> NamespacedName

    /// <summary>
    /// Indicates whether special vehicles are exempted from the need to install ETCS (European Train Control System) for this infrastructure element.
    /// <see href="http://data.europa.eu/949/exemptSpecialVehiclesFromETCS"></see></summary>
    let exemptSpecialVehiclesFromETCS =
        Namespaced_IRI.parse _namespace_name "exemptSpecialVehiclesFromETCS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ExemptSpecialVehiclesFromETCS"></see>
    /// </summary>
    let ``shapes/ExemptSpecialVehiclesFromETCS`` =
        Namespaced_IRI.parse _namespace_name "shapes/ExemptSpecialVehiclesFromETCS" |> NamespacedName

    /// <summary>
    /// Indicates whether special vehicles are exempted from the need to install RMR (Railway Mobile Radio) for this infrastructure element.
    /// <see href="http://data.europa.eu/949/exemptSpecialVehiclesFromRMR"></see></summary>
    let exemptSpecialVehiclesFromRMR =
        Namespaced_IRI.parse _namespace_name "exemptSpecialVehiclesFromRMR" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ExemptSpecialVehiclesFromRMR"></see>
    /// </summary>
    let ``shapes/ExemptSpecialVehiclesFromRMR`` =
        Namespaced_IRI.parse _namespace_name "shapes/ExemptSpecialVehiclesFromRMR" |> NamespacedName

    /// <summary>
    /// Indicate, if there are any wind restrictions for a bridge.
    /// <see href="http://data.europa.eu/949/existBridgeWindRestriction"></see></summary>
    let existBridgeWindRestriction =
        Namespaced_IRI.parse _namespace_name "existBridgeWindRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/bridgeWindRestriction"></see>
    /// </summary>
    let bridgeWindRestriction =
        Namespaced_IRI.parse _namespace_name "bridgeWindRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/networkStatementsDataCharacteristic"></see>
    /// </summary>
    let networkStatementsDataCharacteristic =
        Namespaced_IRI.parse _namespace_name "networkStatementsDataCharacteristic" |> NamespacedName

    /// <summary>
    /// Indicate, if there are any opening hours of the section of a line or Tunnel or Bridge.
    /// <see href="http://data.europa.eu/949/existOpeningHoursLimitation"></see></summary>
    let existOpeningHoursLimitation =
        Namespaced_IRI.parse _namespace_name "existOpeningHoursLimitation" |> NamespacedName

    /// <summary>
    /// Opening hours of the section of a line or tunnel or a bridge
    /// <see href="http://data.europa.eu/949/openingHoursLimitation"></see></summary>
    let openingHoursLimitation =
        Namespaced_IRI.parse _namespace_name "openingHoursLimitation" |> NamespacedName

    /// <summary>
    /// Indicate, if there are any limits on transportation of dangerous goods.
    /// <see href="http://data.europa.eu/949/existRestrictedDangerousGood"></see></summary>
    let existRestrictedDangerousGood =
        Namespaced_IRI.parse _namespace_name "existRestrictedDangerousGood" |> NamespacedName

    /// <summary>
    /// Description of the type of dangerous good that are not allowed in the tunnel
    /// <see href="http://data.europa.eu/949/restrictedDangerousGood"></see></summary>
    let restrictedDangerousGood =
        Namespaced_IRI.parse _namespace_name "restrictedDangerousGood" |> NamespacedName

    /// <summary>
    /// Indicate, if there are any limits on specific time of a day for transport of dangerous goods.
    /// <see href="http://data.europa.eu/949/existRestrictedPeriodOfTimeDangerousGood"></see></summary>
    let existRestrictedPeriodOfTimeDangerousGood =
        Namespaced_IRI.parse _namespace_name "existRestrictedPeriodOfTimeDangerousGood" |> NamespacedName

    /// <summary>
    /// Describes the period of time for which the transport of dangerous goods is not allowed in the Section of Line
    /// <see href="http://data.europa.eu/949/restrictedPeriodOfTimeDangerousGood"></see></summary>
    let restrictedPeriodOfTimeDangerousGood =
        Namespaced_IRI.parse _namespace_name "restrictedPeriodOfTimeDangerousGood" |> NamespacedName

    /// <summary>
    /// Indicate, if there are any limits on specific type of vehicle in the tunnel.
    /// <see href="http://data.europa.eu/949/existRestrictedTypeOfVehicleOfTunnel"></see></summary>
    let existRestrictedTypeOfVehicleOfTunnel =
        Namespaced_IRI.parse _namespace_name "existRestrictedTypeOfVehicleOfTunnel" |> NamespacedName

    /// <summary>
    /// Specific types of vehicles restricted in the tunnel.
    /// <see href="http://data.europa.eu/949/restrictedTypeOfVehicleInTunnel"></see></summary>
    let restrictedTypeOfVehicleInTunnel =
        Namespaced_IRI.parse _namespace_name "restrictedTypeOfVehicleInTunnel" |> NamespacedName

    /// <summary>
    /// Indicate, if passenger and freight trains meeting together in a tunnel is allowed
    /// <see href="http://data.europa.eu/949/existTrainExclusionOfSimultaneity"></see></summary>
    let existTrainExclusionOfSimultaneity =
        Namespaced_IRI.parse _namespace_name "existTrainExclusionOfSimultaneity" |> NamespacedName

    /// <summary>
    /// Indication that the full section of line (or a part of it) it is identified by the Infrastructure Managers (and communicated to the RU) where drivers are not supposed to get off the locomotive.
    /// <see href="http://data.europa.eu/949/existenceOfIndustrialRisk"></see></summary>
    let existenceOfIndustrialRisk =
        Namespaced_IRI.parse _namespace_name "existenceOfIndustrialRisk" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/routeBookDataParameter"></see>
    /// </summary>
    let routeBookDataParameter =
        Namespaced_IRI.parse _namespace_name "routeBookDataParameter" |> NamespacedName

    /// <summary>
    /// Wheel material is ferromagnetic.
    /// <see href="http://data.europa.eu/949/ferromagneticWheelMaterial"></see></summary>
    let ferromagneticWheelMaterial =
        Namespaced_IRI.parse _namespace_name "ferromagneticWheelMaterial" |> NamespacedName

    /// <summary>
    /// Fire safety category for tunnels.
    /// <see href="http://data.europa.eu/949/fireSafetyCategory"></see></summary>
    let fireSafetyCategory =
        Namespaced_IRI.parse _namespace_name "fireSafetyCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/rolling-stock-fire/Categories"></see>
    /// </summary>
    let ``concepts/rolling-stock-fire/Categories`` =
        Namespaced_IRI.parse _namespace_name "concepts/rolling-stock-fire/Categories" |> NamespacedName

    /// <summary>
    /// Number of fixed seats.
    /// <see href="http://data.europa.eu/949/fixedSeats"></see></summary>
    let fixedSeats = Namespaced_IRI.parse _namespace_name "fixedSeats" |> NamespacedName

    /// <summary>
    /// Indication whether the use of on-board device for flange lubrication is forbidden.
    /// <see href="http://data.europa.eu/949/flangeLubeForbidden"></see></summary>
    let flangeLubeForbidden =
        Namespaced_IRI.parse _namespace_name "flangeLubeForbidden" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FlangeLubeForbidden"></see>
    /// </summary>
    let ``shapes/FlangeLubeForbidden`` =
        Namespaced_IRI.parse _namespace_name "shapes/FlangeLubeForbidden" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/healthSafetyAndEnvironmentDataParameter"></see>
    /// </summary>
    let healthSafetyAndEnvironmentDataParameter =
        Namespaced_IRI.parse _namespace_name "healthSafetyAndEnvironmentDataParameter" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication whether rules for activation or deactivation of flange lubrication exist.
    /// <see href="http://data.europa.eu/949/flangeLubeRules"></see></summary>
    let flangeLubeRules =
        Namespaced_IRI.parse _namespace_name "flangeLubeRules" |> NamespacedName

    /// <summary>
    /// Indicates if the vehicle type is fitted for flange lubrication.
    /// <see href="http://data.europa.eu/949/flangeLubricationFitted"></see></summary>
    let flangeLubricationFitted =
        Namespaced_IRI.parse _namespace_name "flangeLubricationFitted" |> NamespacedName

    /// <summary>
    /// Indication whether the line is designated to a Railway Freight Corridor.
    /// <see href="http://data.europa.eu/949/freightCorridor"></see></summary>
    let freightCorridor =
        Namespaced_IRI.parse _namespace_name "freightCorridor" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/freight-corridor/FreightCorridors"></see>
    /// </summary>
    let ``concepts/freight-corridor/FreightCorridors`` =
        Namespaced_IRI.parse _namespace_name "concepts/freight-corridor/FreightCorridors" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FreightCorridorSKOS"></see>
    /// </summary>
    let ``shapes/FreightCorridorSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/FreightCorridorSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FreightCorridorPreDeprecationWarning"></see>
    /// </summary>
    let ``shapes/FreightCorridorPreDeprecationWarning`` =
        Namespaced_IRI.parse _namespace_name "shapes/FreightCorridorPreDeprecationWarning" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FreightCorridor"></see>
    /// </summary>
    let ``shapes/FreightCorridor`` =
        Namespaced_IRI.parse _namespace_name "shapes/FreightCorridor" |> NamespacedName

    /// <summary>
    /// Freight possible flag attached to a Primary Location.
    /// <see href="http://data.europa.eu/949/freightFlag"></see></summary>
    let freightFlag =
        Namespaced_IRI.parse _namespace_name "freightFlag" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FreightFlag"></see>
    /// </summary>
    let ``shapes/FreightFlag`` =
        Namespaced_IRI.parse _namespace_name "shapes/FreightFlag" |> NamespacedName

    /// <summary>
    /// Specific for route compatibility check on French network. The reason for deprecation is because of replacement by a class, an object property and two datatype properties. The reason is that the property is composed of two values: A boolean [Y/N] and  a number N is between 1 and 8.
    /// <see href="http://data.europa.eu/949/frenchTrainDetectionSystemLimitation"></see></summary>
    let frenchTrainDetectionSystemLimitation =
        Namespaced_IRI.parse _namespace_name "frenchTrainDetectionSystemLimitation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/train-detection/FrenchTrainDetectionSystemLimitations"></see>
    /// </summary>
    let ``concepts/train-detection/FrenchTrainDetectionSystemLimitations`` =
        Namespaced_IRI.parse _namespace_name "concepts/train-detection/FrenchTrainDetectionSystemLimitations" |> NamespacedName

    /// <summary>
    /// Part of the section with train detection limitation that indicates if it is applicable. Only for the French network.
    /// <see href="http://data.europa.eu/949/frenchTrainDetectionSystemLimitationApplicable"></see></summary>
    let frenchTrainDetectionSystemLimitationApplicable =
        Namespaced_IRI.parse _namespace_name "frenchTrainDetectionSystemLimitationApplicable" |> NamespacedName

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
        Namespaced_IRI.parse _namespace_name "frenchTrainDetectionSystemLimitationNumber" |> NamespacedName

    /// <summary>
    /// Specific for route compatibility check on French network.
    /// <see href="http://data.europa.eu/949/tdsFrenchTrainDetectionSystemLimitation"></see></summary>
    let tdsFrenchTrainDetectionSystemLimitation =
        Namespaced_IRI.parse _namespace_name "tdsFrenchTrainDetectionSystemLimitation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationApplicable"></see>
    /// </summary>
    let ``shapes/FrenchTrainDetectionSystemLimitationApplicable`` =
        Namespaced_IRI.parse _namespace_name "shapes/FrenchTrainDetectionSystemLimitationApplicable" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/train-detection-numbers/FrenchTrainDetectionSystemLimitationNumbers"></see>
    /// </summary>
    let ``concepts/train-detection-numbers/FrenchTrainDetectionSystemLimitationNumbers`` =
        Namespaced_IRI.parse _namespace_name "concepts/train-detection-numbers/FrenchTrainDetectionSystemLimitationNumbers" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationNumberSKOS"></see>
    /// </summary>
    let ``shapes/FrenchTrainDetectionSystemLimitationNumberSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/FrenchTrainDetectionSystemLimitationNumberSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationNumber"></see>
    /// </summary>
    let ``shapes/FrenchTrainDetectionSystemLimitationNumber`` =
        Namespaced_IRI.parse _namespace_name "shapes/FrenchTrainDetectionSystemLimitationNumber" |> NamespacedName

    /// <summary>
    /// Bands of the frequency management of the train detection systems as defined in the TSI CCS, and in the specific cases or technical documents referred to in Article 13 of TSI CCS when they are available.
    /// <see href="http://data.europa.eu/949/frequencyBandsForDetection"></see></summary>
    let frequencyBandsForDetection =
        Namespaced_IRI.parse _namespace_name "frequencyBandsForDetection" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/train-detection/FrequencyBandsForDetection"></see>
    /// </summary>
    let ``concepts/train-detection/FrequencyBandsForDetection`` =
        Namespaced_IRI.parse _namespace_name "concepts/train-detection/FrequencyBandsForDetection" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FrequencyBandsForDetectionSKOS"></see>
    /// </summary>
    let ``shapes/FrequencyBandsForDetectionSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/FrequencyBandsForDetectionSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/FrequencyBandsForDetection"></see>
    /// </summary>
    let ``shapes/FrequencyBandsForDetection`` =
        Namespaced_IRI.parse _namespace_name "shapes/FrequencyBandsForDetection" |> NamespacedName

    /// <summary>
    /// The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band.
    /// It should be provided in 3 directions.
    /// <see href="http://data.europa.eu/949/tdsMaximumMagneticField"></see></summary>
    let tdsMaximumMagneticField =
        Namespaced_IRI.parse _namespace_name "tdsMaximumMagneticField" |> NamespacedName

    /// <summary>
    /// Impedance as defined in the specification referenced in Appendix A-1, index [D]
    /// <see href="http://data.europa.eu/949/minVehicleImpedance"></see></summary>
    let minVehicleImpedance =
        Namespaced_IRI.parse _namespace_name "minVehicleImpedance" |> NamespacedName

    /// <summary>
    /// Maximum interference current limits allowed for track circuits for a defined frequency band.
    /// <see href="http://data.europa.eu/949/maximumInterferenceCurrent"></see></summary>
    let maximumInterferenceCurrent =
        Namespaced_IRI.parse _namespace_name "maximumInterferenceCurrent" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trainDetectionSystemBasedFrequencyBandsObjParameter"></see>
    /// </summary>
    let trainDetectionSystemBasedFrequencyBandsObjParameter =
        Namespaced_IRI.parse _namespace_name "trainDetectionSystemBasedFrequencyBandsObjParameter" |> NamespacedName

    /// <summary>
    /// Location of particular points requiring specific checks due to deviations from gauging referred to in parameter "Gauging"
    /// <see href="http://data.europa.eu/949/gaugingCheckLocation"></see></summary>
    let gaugingCheckLocation =
        Namespaced_IRI.parse _namespace_name "gaugingCheckLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GaugingCheckLocation"></see>
    /// </summary>
    let ``shapes/GaugingCheckLocation`` =
        Namespaced_IRI.parse _namespace_name "shapes/GaugingCheckLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/lineLayoutDataParameter"></see>
    /// </summary>
    let lineLayoutDataParameter =
        Namespaced_IRI.parse _namespace_name "lineLayoutDataParameter" |> NamespacedName

    /// <summary>
    /// Gauges as defined in European standard or other local gauges, including lower or upper part.
    /// <see href="http://data.europa.eu/949/gaugingProfile"></see></summary>
    let gaugingProfile =
        Namespaced_IRI.parse _namespace_name "gaugingProfile" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gaugings/GaugingProfiles"></see>
    /// </summary>
    let ``concepts/gaugings/GaugingProfiles`` =
        Namespaced_IRI.parse _namespace_name "concepts/gaugings/GaugingProfiles" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GaugingProfileSKOS"></see>
    /// </summary>
    let ``shapes/GaugingProfileSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/GaugingProfileSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GaugingProfile"></see>
    /// </summary>
    let ``shapes/GaugingProfile`` =
        Namespaced_IRI.parse _namespace_name "shapes/GaugingProfile" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/lineLayoutObjParameter"></see>
    /// </summary>
    let lineLayoutObjParameter =
        Namespaced_IRI.parse _namespace_name "lineLayoutObjParameter" |> NamespacedName

    /// <summary>
    /// Electronic document available from the IM stored by the Agency with the transversal section of the particular points requiring specific checks due to deviations from gauging referred to in parameter "Gauging". Where relevant, guidance for the check with the particular point may be attached to the document with the transversal section.
    /// <see href="http://data.europa.eu/949/gaugingTransversalDocument"></see></summary>
    let gaugingTransversalDocument =
        Namespaced_IRI.parse _namespace_name "gaugingTransversalDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GaugingTransversalDocument"></see>
    /// </summary>
    let ``shapes/GaugingTransversalDocument`` =
        Namespaced_IRI.parse _namespace_name "shapes/GaugingTransversalDocument" |> NamespacedName

    /// <summary>
    /// Indication if GPRS can be used for ETCS
    /// <see href="http://data.europa.eu/949/gprsForETCS"></see></summary>
    let gprsForETCS =
        Namespaced_IRI.parse _namespace_name "gprsForETCS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GprsForETCS"></see>
    /// </summary>
    let ``shapes/GprsForETCS`` =
        Namespaced_IRI.parse _namespace_name "shapes/GprsForETCS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GprsForETCSApplicability"></see>
    /// </summary>
    let ``shapes/GprsForETCSApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/GprsForETCSApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/tsiCompliantRadioDataParameter"></see>
    /// </summary>
    let tsiCompliantRadioDataParameter =
        Namespaced_IRI.parse _namespace_name "tsiCompliantRadioDataParameter" |> NamespacedName

    /// <summary>
    /// Indication of the area in which GPRS can be used for ETCS, expressed as a list of GPRS-enabled RBCs.
    /// <see href="http://data.europa.eu/949/gprsImplementationArea"></see></summary>
    let gprsImplementationArea =
        Namespaced_IRI.parse _namespace_name "gprsImplementationArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GprsImplementationAreaApplicability"></see>
    /// </summary>
    let ``shapes/GprsImplementationAreaApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/GprsImplementationAreaApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GprsImplementationArea"></see>
    /// </summary>
    let ``shapes/GprsImplementationArea`` =
        Namespaced_IRI.parse _namespace_name "shapes/GprsImplementationArea" |> NamespacedName

    /// <summary>
    /// Maximum value of the gradient for stabling tracks expressed in millimetres per metre.
    /// <see href="http://data.europa.eu/949/gradient"></see></summary>
    let gradient = Namespaced_IRI.parse _namespace_name "gradient" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Gradient"></see>
    /// </summary>
    let ``shapes/Gradient`` =
        Namespaced_IRI.parse _namespace_name "shapes/Gradient" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/sidingDataParameter"></see>
    /// </summary>
    let sidingDataParameter =
        Namespaced_IRI.parse _namespace_name "sidingDataParameter" |> NamespacedName

    /// <summary>
    /// Sequence of gradient values and locations of change in gradient
    /// <see href="http://data.europa.eu/949/gradientProfile"></see></summary>
    let gradientProfile =
        Namespaced_IRI.parse _namespace_name "gradientProfile" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GradientProfile"></see>
    /// </summary>
    let ``shapes/GradientProfile`` =
        Namespaced_IRI.parse _namespace_name "shapes/GradientProfile" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gsmr-number-active-mobiles/NumberActiveMobiles"></see>
    /// </summary>
    let ``concepts/gsmr-number-active-mobiles/NumberActiveMobiles`` =
        Namespaced_IRI.parse _namespace_name "concepts/gsmr-number-active-mobiles/NumberActiveMobiles" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRActiveMobilesSKOS"></see>
    /// </summary>
    let ``shapes/GsmRActiveMobilesSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmRActiveMobilesSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRActiveMobilesApplicability"></see>
    /// </summary>
    let ``shapes/GsmRActiveMobilesApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmRActiveMobilesApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRActiveMobiles"></see>
    /// </summary>
    let ``shapes/GsmRActiveMobiles`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmRActiveMobiles" |> NamespacedName

    /// <summary>
    /// Any additional information on network characteristics or corresponding document available from the IM and stored by the Agency, e.g.; interference level, leading to the recommendation of additional on-board protection.
    /// <see href="http://data.europa.eu/949/gsmRAdditionalInfo"></see></summary>
    let gsmRAdditionalInfo =
        Namespaced_IRI.parse _namespace_name "gsmRAdditionalInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRAdditionalInfoApplicability"></see>
    /// </summary>
    let ``shapes/GsmRAdditionalInfoApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmRAdditionalInfoApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRAdditionalInfo"></see>
    /// </summary>
    let ``shapes/GsmRAdditionalInfo`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmRAdditionalInfo" |> NamespacedName

    /// <summary>
    /// Indication if there is no GSMR coverage
    /// <see href="http://data.europa.eu/949/gsmRNoCoverage"></see></summary>
    let gsmRNoCoverage =
        Namespaced_IRI.parse _namespace_name "gsmRNoCoverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRNoCoverageApplicability"></see>
    /// </summary>
    let ``shapes/GsmRNoCoverageApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmRNoCoverageApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRNoCoverage"></see>
    /// </summary>
    let ``shapes/GsmRNoCoverage`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmRNoCoverage" |> NamespacedName

    /// <summary>
    /// Use of optional GSM-R functions which might improve operation on the line. They are for information only and not for network access criteria.
    /// <see href="http://data.europa.eu/949/gsmROptionalFunctions"></see></summary>
    let gsmROptionalFunctions =
        Namespaced_IRI.parse _namespace_name "gsmROptionalFunctions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gsmr-optional-functions/OptionalFunctions"></see>
    /// </summary>
    let ``concepts/gsmr-optional-functions/OptionalFunctions`` =
        Namespaced_IRI.parse _namespace_name "concepts/gsmr-optional-functions/OptionalFunctions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmROptionalFunctionsSKOS"></see>
    /// </summary>
    let ``shapes/GsmROptionalFunctionsSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmROptionalFunctionsSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmROptionalFunctions"></see>
    /// </summary>
    let ``shapes/GsmROptionalFunctions`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmROptionalFunctions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmROptionalFunctionsApplicability"></see>
    /// </summary>
    let ``shapes/GsmROptionalFunctionsApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmROptionalFunctionsApplicability" |> NamespacedName

    /// <summary>
    /// GSM-R Radio Data communication on board and its Baseline.
    /// <see href="http://data.europa.eu/949/gsmRRadioDataCommunication"></see></summary>
    let gsmRRadioDataCommunication =
        Namespaced_IRI.parse _namespace_name "gsmRRadioDataCommunication" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gsm-r-radio-data-communication/GSMRRadioDataCommunications"></see>
    /// </summary>
    let ``concepts/gsm-r-radio-data-communication/GSMRRadioDataCommunications`` =
        Namespaced_IRI.parse _namespace_name "concepts/gsm-r-radio-data-communication/GSMRRadioDataCommunications" |> NamespacedName

    /// <summary>
    /// Number of GSM-R mobile sets in driving cab for data transmission.
    /// <see href="http://data.europa.eu/949/gsmRSetsInDrivingCab"></see></summary>
    let gsmRSetsInDrivingCab =
        Namespaced_IRI.parse _namespace_name "gsmRSetsInDrivingCab" |> NamespacedName

    /// <summary>
    /// GSM-R functional requirements specification and system requirements specification in accordance with the specification respectively referenced in Appendix A-1, index [E] and index [F], version number installed lineside.
    /// <see href="http://data.europa.eu/949/gsmRVersion"></see></summary>
    let gsmRVersion =
        Namespaced_IRI.parse _namespace_name "gsmRVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gsmr-versions/GSMRVersions"></see>
    /// </summary>
    let ``concepts/gsmr-versions/GSMRVersions`` =
        Namespaced_IRI.parse _namespace_name "concepts/gsmr-versions/GSMRVersions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRVersion"></see>
    /// </summary>
    let ``shapes/GsmRVersion`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmRVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmRVersionSKOS"></see>
    /// </summary>
    let ``shapes/GsmRVersionSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmRVersionSKOS" |> NamespacedName

    /// <summary>
    /// These constraints, where applicable, are meant to manage the limited number of circuit-switched radio connections that can be handled simultaneously by a Radio Block Center.
    /// <see href="http://data.europa.eu/949/gsmrConstraintsOperateOnlyInCircuitSwitch"></see></summary>
    let gsmrConstraintsOperateOnlyInCircuitSwitch =
        Namespaced_IRI.parse _namespace_name "gsmrConstraintsOperateOnlyInCircuitSwitch" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gsmr-cs-constraints/GSMRConstraints"></see>
    /// </summary>
    let ``concepts/gsmr-cs-constraints/GSMRConstraints`` =
        Namespaced_IRI.parse _namespace_name "concepts/gsmr-cs-constraints/GSMRConstraints" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmrConstraintsOperateOnlyInCircuitSwitchApplicability"></see>
    /// </summary>
    let ``shapes/GsmrConstraintsOperateOnlyInCircuitSwitchApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmrConstraintsOperateOnlyInCircuitSwitchApplicability" |> NamespacedName

    /// <summary>
    /// This feature will determine the applicable operational rules for drivers and signallers when dealing with cab radios registered under wrong numbers.
    /// <see href="http://data.europa.eu/949/gsmrForcedDeregistrationFunctionalNumber"></see></summary>
    let gsmrForcedDeregistrationFunctionalNumber =
        Namespaced_IRI.parse _namespace_name "gsmrForcedDeregistrationFunctionalNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmrForcedDeregistrationFunctionalNumberApplicability"></see>
    /// </summary>
    let ``shapes/GsmrForcedDeregistrationFunctionalNumberApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmrForcedDeregistrationFunctionalNumberApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmrForcedDeregistrationFunctionalNumber"></see>
    /// </summary>
    let ``shapes/GsmrForcedDeregistrationFunctionalNumber`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmrForcedDeregistrationFunctionalNumber" |> NamespacedName

    /// <summary>
    /// Name of the own GSM-R network and list of GSM-R networks which are covered by a roaming agreement (for CS services).
    /// <see href="http://data.europa.eu/949/gsmrNetworkCoverage"></see></summary>
    let gsmrNetworkCoverage =
        Namespaced_IRI.parse _namespace_name "gsmrNetworkCoverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmrNetworkCoverage"></see>
    /// </summary>
    let ``shapes/GsmrNetworkCoverage`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmrNetworkCoverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmrNetworkCoverageSKOS"></see>
    /// </summary>
    let ``shapes/GsmrNetworkCoverageSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmrNetworkCoverageSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GsmrNetworkCoverageApplicability"></see>
    /// </summary>
    let ``shapes/GsmrNetworkCoverageApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/GsmrNetworkCoverageApplicability" |> NamespacedName

    /// <summary>
    /// Handover point flag attached to a Primary location.
    /// <see href="http://data.europa.eu/949/handoverPointFlag"></see></summary>
    let handoverPointFlag =
        Namespaced_IRI.parse _namespace_name "handoverPointFlag" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HandoverPointFlag"></see>
    /// </summary>
    let ``shapes/HandoverPointFlag`` =
        Namespaced_IRI.parse _namespace_name "shapes/HandoverPointFlag" |> NamespacedName

    /// <summary>
    /// Property that links a physical entity with its topological abstraction representation.
    /// <see href="http://data.europa.eu/949/hasAbstraction"></see></summary>
    let hasAbstraction =
        Namespaced_IRI.parse _namespace_name "hasAbstraction" |> NamespacedName

    /// <summary>
    /// Availability by the IM of additional information as defined in point (2) of point 4.2.2.6.2 of Regulation (EU) 2023/1693 - TSI OPE
    /// <see href="http://data.europa.eu/949/hasAdditionalBrakingInformation"></see></summary>
    let hasAdditionalBrakingInformation =
        Namespaced_IRI.parse _namespace_name "hasAdditionalBrakingInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasAdditionalBrakingInformation"></see>
    /// </summary>
    let ``shapes/HasAdditionalBrakingInformation`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasAdditionalBrakingInformation" |> NamespacedName

    /// <summary>
    /// Automatic dropping device (ADD) fitted (to be indicated for each energy supply system the vehicle is equipped for).
    /// <see href="http://data.europa.eu/949/hasAutomaticDroppingDevice"></see></summary>
    let hasAutomaticDroppingDevice =
        Namespaced_IRI.parse _namespace_name "hasAutomaticDroppingDevice" |> NamespacedName

    /// <summary>
    /// Specifies whether track construction is with sleepers embedded in ballast or not.
    /// <see href="http://data.europa.eu/949/hasBallast"></see></summary>
    let hasBallast = Namespaced_IRI.parse _namespace_name "hasBallast" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasBallast"></see>
    /// </summary>
    let ``shapes/HasBallast`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasBallast" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasBallastApplicability"></see>
    /// </summary>
    let ``shapes/HasBallastApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasBallastApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/hasBridge"></see>
    /// </summary>
    let hasBridge = Namespaced_IRI.parse _namespace_name "hasBridge" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasBridge"></see>
    /// </summary>
    let ``shapes/HasBridge`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasBridge" |> NamespacedName

    /// <summary>
    /// Vehicle equipped with a cant deficiency compensation system (tilting vehicle).
    /// <see href="http://data.europa.eu/949/hasCantDefficiencyCompensation"></see></summary>
    let hasCantDefficiencyCompensation =
        Namespaced_IRI.parse _namespace_name "hasCantDefficiencyCompensation" |> NamespacedName

    /// <summary>
    /// Indicates whether any neighbouring section of line belongs to different Infrastructure Manager
    /// <see href="http://data.europa.eu/949/hasConnectingIM"></see></summary>
    let hasConnectingIM =
        Namespaced_IRI.parse _namespace_name "hasConnectingIM" |> NamespacedName

    /// <summary>
    /// Electric units equipped with power or current limitation function.
    /// <see href="http://data.europa.eu/949/hasCurrentLimitation"></see></summary>
    let hasCurrentLimitation =
        Namespaced_IRI.parse _namespace_name "hasCurrentLimitation" |> NamespacedName

    /// <summary>
    /// Indication whether restrictions or conditions due to partial compliance with the TSI CCS exist.
    /// <see href="http://data.europa.eu/949/hasETCSRestrictionsConditions"></see></summary>
    let hasETCSRestrictionsConditions =
        Namespaced_IRI.parse _namespace_name "hasETCSRestrictionsConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasETCSRestrictionsConditionsApplicability"></see>
    /// </summary>
    let ``shapes/HasETCSRestrictionsConditionsApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasETCSRestrictionsConditionsApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasETCSRestrictionsConditions"></see>
    /// </summary>
    let ``shapes/HasETCSRestrictionsConditions`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasETCSRestrictionsConditions" |> NamespacedName

    /// <summary>
    /// Indication whether exists an installation of electric shore supply (fixed installation for servicing trains).
    /// <see href="http://data.europa.eu/949/hasElectricShoreSupply"></see></summary>
    let hasElectricShoreSupply =
        Namespaced_IRI.parse _namespace_name "hasElectricShoreSupply" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasElectricShoreSupply"></see>
    /// </summary>
    let ``shapes/HasElectricShoreSupply`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasElectricShoreSupply" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/sidingFixedInstalationsDataParameter"></see>
    /// </summary>
    let sidingFixedInstalationsDataParameter =
        Namespaced_IRI.parse _namespace_name "sidingFixedInstalationsDataParameter" |> NamespacedName

    /// <summary>
    /// Indication whether emergency plan exists.
    /// <see href="http://data.europa.eu/949/hasEmergencyPlan"></see></summary>
    let hasEmergencyPlan =
        Namespaced_IRI.parse _namespace_name "hasEmergencyPlan" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasEmergencyPlan"></see>
    /// </summary>
    let ``shapes/HasEmergencyPlan`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasEmergencyPlan" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasEmergencyPlanApplicability"></see>
    /// </summary>
    let ``shapes/HasEmergencyPlanApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasEmergencyPlanApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasEtcsNationalPacket44"></see>
    /// </summary>
    let ``shapes/HasEtcsNationalPacket44`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasEtcsNationalPacket44" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasEtcsNationalPacket44Applicability"></see>
    /// </summary>
    let ``shapes/HasEtcsNationalPacket44Applicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasEtcsNationalPacket44Applicability" |> NamespacedName

    /// <summary>
    /// Indication of existence of evacuation and rescue points
    /// <see href="http://data.europa.eu/949/hasEvacuationAndRescuePoints"></see></summary>
    let hasEvacuationAndRescuePoints =
        Namespaced_IRI.parse _namespace_name "hasEvacuationAndRescuePoints" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasEvacuationAndRescuePoints"></see>
    /// </summary>
    let ``shapes/HasEvacuationAndRescuePoints`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasEvacuationAndRescuePoints" |> NamespacedName

    /// <summary>
    /// Indication whether exists an installation of external cleaning facility (fixed installation for servicing trains) as defined in TSI INF
    /// <see href="http://data.europa.eu/949/hasExternalCleaning"></see></summary>
    let hasExternalCleaning =
        Namespaced_IRI.parse _namespace_name "hasExternalCleaning" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasExternalCleaning"></see>
    /// </summary>
    let ``shapes/HasExternalCleaning`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasExternalCleaning" |> NamespacedName

    /// <summary>
    /// Existence of trackside HABD
    /// <see href="http://data.europa.eu/949/hasHotAxleBoxDetector"></see></summary>
    let hasHotAxleBoxDetector =
        Namespaced_IRI.parse _namespace_name "hasHotAxleBoxDetector" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasHotAxleBoxDetector"></see>
    /// </summary>
    let ``shapes/HasHotAxleBoxDetector`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasHotAxleBoxDetector" |> NamespacedName

    /// <summary>
    /// Property that links a topological abstraction entity with its physical representation.
    /// <see href="http://data.europa.eu/949/hasImplementation"></see></summary>
    let hasImplementation =
        Namespaced_IRI.parse _namespace_name "hasImplementation" |> NamespacedName

    /// <summary>
    /// Specifies the linear referencing system to which the kilometre post is referenced. The linear referencing system is commonly the main railway line and it provides the framework for identifying the post's location along the railway line, using distance measurements rather than geographical coordinates.
    /// <see href="http://data.europa.eu/949/hasLRS"></see></summary>
    let hasLRS = Namespaced_IRI.parse _namespace_name "hasLRS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasLrsCoordinate"></see>
    /// </summary>
    let ``shapes/HasLrsCoordinate`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasLrsCoordinate" |> NamespacedName

    /// <summary>
    /// Indication whether level crossings (including pedestrian track crossing) exist on the section of line.
    /// <see href="http://data.europa.eu/949/hasLevelCrossings"></see></summary>
    let hasLevelCrossings =
        Namespaced_IRI.parse _namespace_name "hasLevelCrossings" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasLevelCrossings"></see>
    /// </summary>
    let ``shapes/HasLevelCrossings`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasLevelCrossings" |> NamespacedName

    /// <summary>
    /// Specifies the LRS coordinate associated with a topological coordinate.
    /// <see href="http://data.europa.eu/949/hasLrsCoordinate"></see></summary>
    let hasLrsCoordinate =
        Namespaced_IRI.parse _namespace_name "hasLrsCoordinate" |> NamespacedName

    /// <summary>
    /// Possibility of preventing the use of the lubrication device (only if fitted with flange lubrication).
    /// <see href="http://data.europa.eu/949/hasLubricationDevicePrevention"></see></summary>
    let hasLubricationDevicePrevention =
        Namespaced_IRI.parse _namespace_name "hasLubricationDevicePrevention" |> NamespacedName

    /// <summary>
    /// Indicate, if there are any limits on noise levels.
    /// <see href="http://data.europa.eu/949/hasNoiseLevelLimit"></see></summary>
    let hasNoiseLevelLimit =
        Namespaced_IRI.parse _namespace_name "hasNoiseLevelLimit" |> NamespacedName

    /// <summary>
    /// Maximum allowed noise level in decibels (dB).
    /// <see href="http://data.europa.eu/949/maxNoiseLevelOfSoL"></see></summary>
    let maxNoiseLevelOfSoL =
        Namespaced_IRI.parse _namespace_name "maxNoiseLevelOfSoL" |> NamespacedName

    /// <summary>
    /// Relates the Organisation role instance (the role played by an Organisation)  with the specific role in the taxonomy of organisation roles.
    /// <see href="http://data.europa.eu/949/hasOrganisationRole"></see></summary>
    let hasOrganisationRole =
        Namespaced_IRI.parse _namespace_name "hasOrganisationRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/organisation-roles/OrgRoles"></see>
    /// </summary>
    let ``concepts/organisation-roles/OrgRoles`` =
        Namespaced_IRI.parse _namespace_name "concepts/organisation-roles/OrgRoles" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasOrganisationRoleSKOS"></see>
    /// </summary>
    let ``shapes/HasOrganisationRoleSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasOrganisationRoleSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasOrganisationRole"></see>
    /// </summary>
    let ``shapes/HasOrganisationRole`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasOrganisationRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/hasOrientation"></see>
    /// </summary>
    let hasOrientation =
        Namespaced_IRI.parse _namespace_name "hasOrientation" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication if other train protection, control and warning systems in normal operation are installed lineside.
    /// <see href="http://data.europa.eu/949/hasOtherTrainProtection"></see></summary>
    let hasOtherTrainProtection =
        Namespaced_IRI.parse _namespace_name "hasOtherTrainProtection" |> NamespacedName

    /// <summary>
    /// Indicates if a vehicle type has parking brake.
    /// <see href="http://data.europa.eu/949/hasParkingBrake"></see></summary>
    let hasParkingBrake =
        Namespaced_IRI.parse _namespace_name "hasParkingBrake" |> NamespacedName

    /// <summary>
    /// Indicates that an infrastructure element is composed of one or more other (distinct) infrastructure elements.
    /// This property is used to represent part-whole relationships between infrastructure elements.
    /// An element cannot be a part of itself.
    /// <see href="http://data.europa.eu/949/hasPart"></see></summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasPartOP"></see>
    /// </summary>
    let ``shapes/HasPartOP`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasPartOP" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasPart"></see>
    /// </summary>
    let ``shapes/HasPart`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasPartSoL"></see>
    /// </summary>
    let ``shapes/HasPartSoL`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasPartSoL" |> NamespacedName

    /// <summary>
    /// Reference to a related siding.
    /// <see href="http://data.europa.eu/949/siding"></see></summary>
    let siding = Namespaced_IRI.parse _namespace_name "siding" |> NamespacedName
    /// <summary>
    /// Reference to a related railway track.
    /// <see href="http://data.europa.eu/949/track"></see></summary>
    let track = Namespaced_IRI.parse _namespace_name "track" |> NamespacedName
    /// <summary>
    /// Indicates that an infrastructure element is a part of another (distinct) infrastructure element.
    /// An element cannot be part of itself.
    /// This property is the inverse of era:hasPart and represents the partial or whole-part relationship between infrastructure elements.
    /// <see href="http://data.europa.eu/949/isPartOf"></see></summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName

    /// <summary>
    /// Indication of existence of phase separation and required information.
    /// <see href="http://data.europa.eu/949/hasPhaseSeparation"></see></summary>
    let hasPhaseSeparation =
        Namespaced_IRI.parse _namespace_name "hasPhaseSeparation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasPhaseSeparationApplicability"></see>
    /// </summary>
    let ``shapes/HasPhaseSeparationApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasPhaseSeparationApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasPhaseSeparation"></see>
    /// </summary>
    let ``shapes/HasPhaseSeparation`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasPhaseSeparation" |> NamespacedName

    /// <summary>
    /// Indication of the existence of the curvature of the platform.
    /// <see href="http://data.europa.eu/949/hasPlatformCurvature"></see></summary>
    let hasPlatformCurvature =
        Namespaced_IRI.parse _namespace_name "hasPlatformCurvature" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasPlatformCurvature"></see>
    /// </summary>
    let ``shapes/HasPlatformCurvature`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasPlatformCurvature" |> NamespacedName

    /// <summary>
    /// Indication whether exists an installation of refuelling (fixed installation for servicing trains) as defined in TSI INF.
    /// <see href="http://data.europa.eu/949/hasRefuelling"></see></summary>
    let hasRefuelling =
        Namespaced_IRI.parse _namespace_name "hasRefuelling" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasRefuelling"></see>
    /// </summary>
    let ``shapes/HasRefuelling`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasRefuelling" |> NamespacedName

    /// <summary>
    /// Indication whether regenerative braking is permitted or not.
    /// <see href="http://data.europa.eu/949/hasRegenerativeBrake"></see></summary>
    let hasRegenerativeBrake =
        Namespaced_IRI.parse _namespace_name "hasRegenerativeBrake" |> NamespacedName

    /// <summary>
    /// Indication whether an installation of sand restocking exists (fixed installation for servicing trains).
    /// <see href="http://data.europa.eu/949/hasSandRestocking"></see></summary>
    let hasSandRestocking =
        Namespaced_IRI.parse _namespace_name "hasSandRestocking" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasSandRestocking"></see>
    /// </summary>
    let ``shapes/HasSandRestocking`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasSandRestocking" |> NamespacedName

    /// <summary>
    /// Possibility of preventing the use of sanding.
    /// <see href="http://data.europa.eu/949/hasSandingPrevention"></see></summary>
    let hasSandingPrevention =
        Namespaced_IRI.parse _namespace_name "hasSandingPrevention" |> NamespacedName

    /// <summary>
    /// The existence of a schematic overview of the operational point in digital form.
    /// <see href="http://data.europa.eu/949/hasSchematicOverviewOPDigitalForm"></see></summary>
    let hasSchematicOverviewOPDigitalForm =
        Namespaced_IRI.parse _namespace_name "hasSchematicOverviewOPDigitalForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasSchematicOverviewOPDigitalForm"></see>
    /// </summary>
    let ``shapes/HasSchematicOverviewOPDigitalForm`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasSchematicOverviewOPDigitalForm" |> NamespacedName

    /// <summary>
    /// The ordered sequence of topological linear elements which create a linear net reference.
    /// <see href="http://data.europa.eu/949/hasSequence"></see></summary>
    let hasSequence =
        Namespaced_IRI.parse _namespace_name "hasSequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasSequence"></see>
    /// </summary>
    let ``shapes/HasSequence`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasSequence" |> NamespacedName

    /// <summary>
    /// Climatic conditions on the line are severe according to European standard.
    /// <see href="http://data.europa.eu/949/hasSevereWeatherConditions"></see></summary>
    let hasSevereWeatherConditions =
        Namespaced_IRI.parse _namespace_name "hasSevereWeatherConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasSevereWeatherConditions"></see>
    /// </summary>
    let ``shapes/HasSevereWeatherConditions`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasSevereWeatherConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/performanceDataParameter"></see>
    /// </summary>
    let performanceDataParameter =
        Namespaced_IRI.parse _namespace_name "performanceDataParameter" |> NamespacedName

    /// <summary>
    /// Indicates the presence of shunting restrictions.
    /// <see href="http://data.europa.eu/949/hasShuntingRestrictions"></see></summary>
    let hasShuntingRestrictions =
        Namespaced_IRI.parse _namespace_name "hasShuntingRestrictions" |> NamespacedName

    /// <summary>
    /// Indication of existence of system separation
    /// <see href="http://data.europa.eu/949/hasSystemSeparation"></see></summary>
    let hasSystemSeparation =
        Namespaced_IRI.parse _namespace_name "hasSystemSeparation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasSystemSeparationApplicability"></see>
    /// </summary>
    let ``shapes/HasSystemSeparationApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasSystemSeparationApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasSystemSeparation"></see>
    /// </summary>
    let ``shapes/HasSystemSeparation`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasSystemSeparation" |> NamespacedName

    /// <summary>
    /// Indication if there is any train detection system installed and fully compliant with the TSI CCS
    /// <see href="http://data.europa.eu/949/hasTSITrainDetection"></see></summary>
    let hasTSITrainDetection =
        Namespaced_IRI.parse _namespace_name "hasTSITrainDetection" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasTSITrainDetection"></see>
    /// </summary>
    let ``shapes/HasTSITrainDetection`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasTSITrainDetection" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trainDetectionSystemBasedFrequencyBandsDataParameter"></see>
    /// </summary>
    let trainDetectionSystemBasedFrequencyBandsDataParameter =
        Namespaced_IRI.parse _namespace_name "trainDetectionSystemBasedFrequencyBandsDataParameter" |> NamespacedName

    /// <summary>
    /// Indication whether exists an installation of toilet discharge (fixed installation for servicing trains) as defined in TSI INF
    /// <see href="http://data.europa.eu/949/hasToiletDischarge"></see></summary>
    let hasToiletDischarge =
        Namespaced_IRI.parse _namespace_name "hasToiletDischarge" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasToiletDischarge"></see>
    /// </summary>
    let ``shapes/HasToiletDischarge`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasToiletDischarge" |> NamespacedName

    /// <summary>
    /// Specifies the topological coordinate of a network point reference.
    /// <see href="http://data.europa.eu/949/hasTopoCoordinate"></see></summary>
    let hasTopoCoordinate =
        Namespaced_IRI.parse _namespace_name "hasTopoCoordinate" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasTopoCoordinate"></see>
    /// </summary>
    let ``shapes/HasTopoCoordinate`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasTopoCoordinate" |> NamespacedName

    /// <summary>
    /// Indication of on-board management system about completeness of the train information.
    /// <see href="http://data.europa.eu/949/hasTrainIntegrityConfirmation"></see></summary>
    let hasTrainIntegrityConfirmation =
        Namespaced_IRI.parse _namespace_name "hasTrainIntegrityConfirmation" |> NamespacedName

    /// <summary>
    /// Indication of existence of walkways
    /// <see href="http://data.europa.eu/949/hasWalkway"></see></summary>
    let hasWalkway = Namespaced_IRI.parse _namespace_name "hasWalkway" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasWalkway"></see>
    /// </summary>
    let ``shapes/HasWalkway`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasWalkway" |> NamespacedName

    /// <summary>
    /// Indication whether exists an installation of water restocking (fixed installation for servicing trains) as defined in TSI INF
    /// <see href="http://data.europa.eu/949/hasWaterRestocking"></see></summary>
    let hasWaterRestocking =
        Namespaced_IRI.parse _namespace_name "hasWaterRestocking" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasWaterRestocking"></see>
    /// </summary>
    let ``shapes/HasWaterRestocking`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasWaterRestocking" |> NamespacedName

    /// <summary>
    /// Indicates the presence of a wheel slide protection system.
    /// <see href="http://data.europa.eu/949/hasWheelSlideProtectionSystem"></see></summary>
    let hasWheelSlideProtectionSystem =
        Namespaced_IRI.parse _namespace_name "hasWheelSlideProtectionSystem" |> NamespacedName

    /// <summary>
    /// This property indicates for each infrastructure element, the source, i.e. the identifier  or key that was input to the hash function in order to generate the hash value that is part of the hash URI.
    /// <see href="http://data.europa.eu/949/hashSource"></see></summary>
    let hashSource = Namespaced_IRI.parse _namespace_name "hashSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/infraSubsystemDataParameter"></see>
    /// </summary>
    let infraSubsystemDataParameter =
        Namespaced_IRI.parse _namespace_name "infraSubsystemDataParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/infraSubsystemObjParameter"></see>
    /// </summary>
    let infraSubsystemObjParameter =
        Namespaced_IRI.parse _namespace_name "infraSubsystemObjParameter" |> NamespacedName

    /// <summary>
    /// For sections of line with a maximum permitted speed of 200 km/h or more. Information regarding the procedure to be used to perform the dynamic compatibility check.
    /// <see href="http://data.europa.eu/949/highSpeedLoadModelCompliance"></see></summary>
    let highSpeedLoadModelCompliance =
        Namespaced_IRI.parse _namespace_name "highSpeedLoadModelCompliance" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HighSpeedLoadModelCompliance"></see>
    /// </summary>
    let ``shapes/HighSpeedLoadModelCompliance`` =
        Namespaced_IRI.parse _namespace_name "shapes/HighSpeedLoadModelCompliance" |> NamespacedName

    /// <summary>
    /// Direction of measurement of trackside HABD, specific for the French Italian and Swedish networks.
    /// <see href="http://data.europa.eu/949/hotAxleBoxDetectorDirection"></see></summary>
    let hotAxleBoxDetectorDirection =
        Namespaced_IRI.parse _namespace_name "hotAxleBoxDetectorDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/hot-axle-box-detector-direction/HotAxleBoxDetectorDirections"></see>
    /// </summary>
    let ``concepts/hot-axle-box-detector-direction/HotAxleBoxDetectorDirections`` =
        Namespaced_IRI.parse _namespace_name "concepts/hot-axle-box-detector-direction/HotAxleBoxDetectorDirections" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirectionApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorDirectionApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorDirectionApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirection"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorDirection`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirectionCountryApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorDirectionCountryApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorDirectionCountryApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirectionSKOS"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorDirectionSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorDirectionSKOS" |> NamespacedName

    /// <summary>
    /// Specific for the French Italian and Swedish networks.
    /// Generation of trackside hot axle box detector.
    /// <see href="http://data.europa.eu/949/hotAxleBoxDetectorGeneration"></see></summary>
    let hotAxleBoxDetectorGeneration =
        Namespaced_IRI.parse _namespace_name "hotAxleBoxDetectorGeneration" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorGenerationCountryApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorGenerationCountryApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorGenerationCountryApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorGeneration"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorGeneration`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorGeneration" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorGenerationApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorGenerationApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorGenerationApplicability" |> NamespacedName

    /// <summary>
    /// Specific for the French, Italian and Swedish networks.
    /// Applicable if trackside HABD is not TSI compliant, identification of trackside hot axle box detector.
    /// <see href="http://data.europa.eu/949/hotAxleBoxDetectorIdentification"></see></summary>
    let hotAxleBoxDetectorIdentification =
        Namespaced_IRI.parse _namespace_name "hotAxleBoxDetectorIdentification" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorIdentificationCountryApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorIdentificationCountryApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorIdentificationCountryApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorIdentificationApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorIdentificationApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorIdentificationApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorIdentification"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorIdentification`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorIdentification" |> NamespacedName

    /// <summary>
    /// Specific for the French Italian and Swedish networks.
    /// Applicable if trackside HABD is not TSI compliant, localisation of trackside hot axle box detector.
    /// <see href="http://data.europa.eu/949/hotAxleBoxDetectorLocation"></see></summary>
    let hotAxleBoxDetectorLocation =
        Namespaced_IRI.parse _namespace_name "hotAxleBoxDetectorLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorLocationCountryApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorLocationCountryApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorLocationCountryApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorLocation"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorLocation`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorLocationApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorLocationApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorLocationApplicability" |> NamespacedName

    /// <summary>
    /// Specific for the French, Italian and Swedish networks.
    /// Trackside HABD compliant to TSI means that the HABD Trackside is compliant with:
    /// - EN 15437-1:2009 referred in TSIs (LOC&amp;PAS: 4.2.3.3.2.2, WAG TSI: 4.2.3.4),
    /// - Specific cases mentioned in TSIs (LOC&amp;PAS TSI, WAG TSI).
    /// <see href="http://data.europa.eu/949/hotAxleBoxDetectorTSICompliant"></see></summary>
    let hotAxleBoxDetectorTSICompliant =
        Namespaced_IRI.parse _namespace_name "hotAxleBoxDetectorTSICompliant" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorTSICompliant"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorTSICompliant`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorTSICompliant" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorTSICompliantCountryApplicability"></see>
    /// </summary>
    let ``shapes/HotAxleBoxDetectorTSICompliantCountryApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/HotAxleBoxDetectorTSICompliantCountryApplicability" |> NamespacedName

    /// <summary>
    /// Unique RBC identification (NID_C+NID_RBC) and calling number (NID_RADIO) as defined in the specification referenced in Appendix A-1, index [C].
    /// <see href="http://data.europa.eu/949/idPhoneErtmsRadioBlockCenter"></see></summary>
    let idPhoneErtmsRadioBlockCenter =
        Namespaced_IRI.parse _namespace_name "idPhoneErtmsRadioBlockCenter" |> NamespacedName

    /// <summary>
    /// Infrastructure manager means any body or firm responsible in particular for establishing, managing and maintaining railway infrastructure, including traffic management and control-command signalling;
    /// the functions of the infrastructure manager on a network or part of a network may be allocated to different bodies or firms. Definition in (Article 3(2))
    /// <see href="http://data.europa.eu/949/imCode"></see></summary>
    let imCode = Namespaced_IRI.parse _namespace_name "imCode" |> NamespacedName

    /// <summary>
    /// Infrastructure manager means any body or undertaking that is responsible in particular for establishing and maintaining railway infrastructure or a part thereof.
    /// Four alpha-numeric code allocated by ERA to a body. It represents the Infrastructure Manager (IM) code in RINF.
    /// Infrastructure manager means any body or firm responsible in particular for establishing, managing and maintaining railway infrastructure, including traffic management and control-command signalling;
    /// the functions of the infrastructure manager on a network or part of a network may be allocated to different bodies or firms. Definition in (Article 3(2))
    /// <see href="http://data.europa.eu/949/organisationCode"></see></summary>
    let organisationCode =
        Namespaced_IRI.parse _namespace_name "organisationCode" |> NamespacedName

    /// <summary>
    /// Indicates the country in which an entity resides.
    /// <see href="http://data.europa.eu/949/inCountry"></see></summary>
    let inCountry = Namespaced_IRI.parse _namespace_name "inCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InCountry"></see>
    /// </summary>
    let ``shapes/InCountry`` =
        Namespaced_IRI.parse _namespace_name "shapes/InCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InCountrySKOS"></see>
    /// </summary>
    let ``shapes/InCountrySKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/InCountrySKOS" |> NamespacedName

    /// <summary>
    /// Reference to NUTS-3 place or city
    /// <see href="http://data.europa.eu/949/inNUTS3"></see></summary>
    let inNUTS3 = Namespaced_IRI.parse _namespace_name "inNUTS3" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InNUTS3"></see>
    /// </summary>
    let ``shapes/InNUTS3`` =
        Namespaced_IRI.parse _namespace_name "shapes/InNUTS3" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InNUTS3SKOS"></see>
    /// </summary>
    let ``shapes/InNUTS3SKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/InNUTS3SKOS" |> NamespacedName

    /// <summary>
    /// List of linear references included in an network area reference.
    /// <see href="http://data.europa.eu/949/includes"></see></summary>
    let includes = Namespaced_IRI.parse _namespace_name "includes" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Includes"></see>
    /// </summary>
    let ``shapes/Includes`` =
        Namespaced_IRI.parse _namespace_name "shapes/Includes" |> NamespacedName

    /// <summary>
    /// Relates a subset with common characteristics with its IM, represented by an instance of organisation role that points to the "infrastructure manager" concept in the taxonomy.
    /// <see href="http://data.europa.eu/949/infrastructureManager"></see></summary>
    let infrastructureManager =
        Namespaced_IRI.parse _namespace_name "infrastructureManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InfrastructureManagerSKOSValue"></see>
    /// </summary>
    let ``shapes/InfrastructureManagerSKOSValue`` =
        Namespaced_IRI.parse _namespace_name "shapes/InfrastructureManagerSKOSValue" |> NamespacedName

    /// <summary>
    /// (deprecated) not in use. Relates any feature implemented in the European railway infrastructure with its infrastructure manager.
    /// <see href="http://data.europa.eu/949/infrastructureMgr"></see></summary>
    let infrastructureMgr =
        Namespaced_IRI.parse _namespace_name "infrastructureMgr" |> NamespacedName

    /// <summary>
    /// Name and/or reference of the document specifying the Special instructions to switch over between different radio systems.
    /// <see href="http://data.europa.eu/949/instructionsSwitchRadioSystems"></see></summary>
    let instructionsSwitchRadioSystems =
        Namespaced_IRI.parse _namespace_name "instructionsSwitchRadioSystems" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InstructionsSwitchRadioSystemsApplicability"></see>
    /// </summary>
    let ``shapes/InstructionsSwitchRadioSystemsApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/InstructionsSwitchRadioSystemsApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InstructionsSwitchRadioSystems"></see>
    /// </summary>
    let ``shapes/InstructionsSwitchRadioSystems`` =
        Namespaced_IRI.parse _namespace_name "shapes/InstructionsSwitchRadioSystems" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/IsOnOriginOfElementA"></see>
    /// </summary>
    let ``shapes/IsOnOriginOfElementA`` =
        Namespaced_IRI.parse _namespace_name "shapes/IsOnOriginOfElementA" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/IsOnOriginOfElementB"></see>
    /// </summary>
    let ``shapes/IsOnOriginOfElementB`` =
        Namespaced_IRI.parse _namespace_name "shapes/IsOnOriginOfElementB" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/IsPartOf"></see>
    /// </summary>
    let ``shapes/IsPartOf`` =
        Namespaced_IRI.parse _namespace_name "shapes/IsPartOf" |> NamespacedName

    /// <summary>
    /// Belonging to a 'quieter route' in accordance with Article 5b of TSI NOI.
    /// <see href="http://data.europa.eu/949/isQuietRoute"></see></summary>
    let isQuietRoute =
        Namespaced_IRI.parse _namespace_name "isQuietRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/IsQuietRoute"></see>
    /// </summary>
    let ``shapes/IsQuietRoute`` =
        Namespaced_IRI.parse _namespace_name "shapes/IsQuietRoute" |> NamespacedName

    /// <summary>
    /// Kilometer number of the kilometric post related to line identification defining the location of an infrastructure element.
    /// <see href="http://data.europa.eu/949/kilometer"></see></summary>
    let kilometer = Namespaced_IRI.parse _namespace_name "kilometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Kilometer"></see>
    /// </summary>
    let ``shapes/Kilometer`` =
        Namespaced_IRI.parse _namespace_name "shapes/Kilometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/signalDataParameter"></see>
    /// </summary>
    let signalDataParameter =
        Namespaced_IRI.parse _namespace_name "signalDataParameter" |> NamespacedName

    /// <summary>
    /// The closest kilometric post on the line, used as a reference by the LRS coordinate.
    /// <see href="http://data.europa.eu/949/kmPost"></see></summary>
    let kmPost = Namespaced_IRI.parse _namespace_name "kmPost" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/KmPost"></see>
    /// </summary>
    let ``shapes/KmPost`` =
        Namespaced_IRI.parse _namespace_name "shapes/KmPost" |> NamespacedName

    /// <summary>
    /// Name of the kilometric post (optional).
    /// <see href="http://data.europa.eu/949/kmPostName"></see></summary>
    let kmPostName = Namespaced_IRI.parse _namespace_name "kmPostName" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/KmPostName"></see>
    /// </summary>
    let ``shapes/KmPostName`` =
        Namespaced_IRI.parse _namespace_name "shapes/KmPostName" |> NamespacedName

    /// <summary>
    /// Indication of radio legacy systems installed.
    /// <see href="http://data.europa.eu/949/legacyRadioSystem"></see></summary>
    let legacyRadioSystem =
        Namespaced_IRI.parse _namespace_name "legacyRadioSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/legacy-radio-systems/LegacyRadioSystems"></see>
    /// </summary>
    let ``concepts/legacy-radio-systems/LegacyRadioSystems`` =
        Namespaced_IRI.parse _namespace_name "concepts/legacy-radio-systems/LegacyRadioSystems" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LegacyRadioSystem"></see>
    /// </summary>
    let ``shapes/LegacyRadioSystem`` =
        Namespaced_IRI.parse _namespace_name "shapes/LegacyRadioSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LegacyRadioSystemSKOS"></see>
    /// </summary>
    let ``shapes/LegacyRadioSystemSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/LegacyRadioSystemSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/otherRadioSystemsObjParameter"></see>
    /// </summary>
    let otherRadioSystemsObjParameter =
        Namespaced_IRI.parse _namespace_name "otherRadioSystemsObjParameter" |> NamespacedName

    /// <summary>
    /// Generic super-property for different types of length
    /// <see href="http://data.europa.eu/949/length"></see></summary>
    let length = Namespaced_IRI.parse _namespace_name "length" |> NamespacedName

    /// <summary>
    /// Length of a topological linear element.
    /// <see href="http://data.europa.eu/949/lengthOfNetLinearElement"></see></summary>
    let lengthOfNetLinearElement =
        Namespaced_IRI.parse _namespace_name "lengthOfNetLinearElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LengthOfNetLinearElement"></see>
    /// </summary>
    let ``shapes/LengthOfNetLinearElement`` =
        Namespaced_IRI.parse _namespace_name "shapes/LengthOfNetLinearElement" |> NamespacedName

    /// <summary>
    /// The maximum continuous length (expressed in metres) of that part of platform in front of which a train is intended to remain stationary in normal operating conditions for passengers to board and alight from the train, making appropriate allowance for stopping tolerances.
    /// <see href="http://data.europa.eu/949/lengthOfPlatform"></see></summary>
    let lengthOfPlatform =
        Namespaced_IRI.parse _namespace_name "lengthOfPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LengthP"></see>
    /// </summary>
    let ``shapes/LengthP`` =
        Namespaced_IRI.parse _namespace_name "shapes/LengthP" |> NamespacedName

    /// <summary>
    /// Length between operational points at start and end of section of line.
    /// <see href="http://data.europa.eu/949/lengthOfSectionOfLine"></see></summary>
    let lengthOfSectionOfLine =
        Namespaced_IRI.parse _namespace_name "lengthOfSectionOfLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SolLength"></see>
    /// </summary>
    let ``shapes/SolLength`` =
        Namespaced_IRI.parse _namespace_name "shapes/SolLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/solGenericDataParameter"></see>
    /// </summary>
    let solGenericDataParameter =
        Namespaced_IRI.parse _namespace_name "solGenericDataParameter" |> NamespacedName

    /// <summary>
    /// Total length of the siding/stabling track expressed in metres where trains can be parked safely.
    /// <see href="http://data.europa.eu/949/lengthOfSiding"></see></summary>
    let lengthOfSiding =
        Namespaced_IRI.parse _namespace_name "lengthOfSiding" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LengthS"></see>
    /// </summary>
    let ``shapes/LengthS`` =
        Namespaced_IRI.parse _namespace_name "shapes/LengthS" |> NamespacedName

    /// <summary>
    /// Length of a tunnel in metres from entrance portal to exit portal.
    /// <see href="http://data.europa.eu/949/lengthOfTunnel"></see></summary>
    let lengthOfTunnel =
        Namespaced_IRI.parse _namespace_name "lengthOfTunnel" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LengthOfTunnel"></see>
    /// </summary>
    let ``shapes/LengthOfTunnel`` =
        Namespaced_IRI.parse _namespace_name "shapes/LengthOfTunnel" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/lengthOfVehicle"></see>
    /// </summary>
    let lengthOfVehicle =
        Namespaced_IRI.parse _namespace_name "lengthOfVehicle" |> NamespacedName

    /// <summary>
    /// letter marking
    /// <see href="http://data.europa.eu/949/letterMarking"></see></summary>
    let letterMarking =
        Namespaced_IRI.parse _namespace_name "letterMarking" |> NamespacedName

    /// <summary>
    /// Classification of a line according to the TSI INF
    /// <see href="http://data.europa.eu/949/lineCategory"></see></summary>
    let lineCategory =
        Namespaced_IRI.parse _namespace_name "lineCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/line-category/LineCategories"></see>
    /// </summary>
    let ``concepts/line-category/LineCategories`` =
        Namespaced_IRI.parse _namespace_name "concepts/line-category/LineCategories" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LineCategory"></see>
    /// </summary>
    let ``shapes/LineCategory`` =
        Namespaced_IRI.parse _namespace_name "shapes/LineCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LineCategorySKOS"></see>
    /// </summary>
    let ``shapes/LineCategorySKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/LineCategorySKOS" |> NamespacedName

    /// <summary>
    /// Unique line identification or unique line number within Member State.
    /// <see href="http://data.europa.eu/949/lineId"></see></summary>
    let lineId = Namespaced_IRI.parse _namespace_name "lineId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LineId"></see>
    /// </summary>
    let ``shapes/LineId`` =
        Namespaced_IRI.parse _namespace_name "shapes/LineId" |> NamespacedName

    /// <summary>
    /// Unique line identification or unique line number within Member State.
    /// <see href="http://data.europa.eu/949/lineNationalId"></see></summary>
    let lineNationalId =
        Namespaced_IRI.parse _namespace_name "lineNationalId" |> NamespacedName

    /// <summary>
    /// Indicates a relationship with a national railway line at a specific kilometer point.
    /// <see href="http://data.europa.eu/949/lineReference"></see></summary>
    let lineReference =
        Namespaced_IRI.parse _namespace_name "lineReference" |> NamespacedName

    /// <summary>
    /// Part of the End of tunnel that indicates the km of the line at the end of a tunnel.
    ///
    /// The End of tunnel is the Geographical coordinates in decimal degrees and km of the line at the end of a tunnel.
    /// <see href="http://data.europa.eu/949/lineReferenceTunnelEnd"></see></summary>
    let lineReferenceTunnelEnd =
        Namespaced_IRI.parse _namespace_name "lineReferenceTunnelEnd" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LineReferenceTunnelEnd"></see>
    /// </summary>
    let ``shapes/LineReferenceTunnelEnd`` =
        Namespaced_IRI.parse _namespace_name "shapes/LineReferenceTunnelEnd" |> NamespacedName

    /// <summary>
    /// Part of the End of tunnel that indicates the km of the line at the end of a tunnel.
    /// The End of tunnel is the Geographical coordinates in decimal degrees and km of the line at the end of a tunnel. The reason for deprecation is that the property is now a subproperty of lineReference in order to represent the kilometer in relation to a national railway line
    /// <see href="http://data.europa.eu/949/tunnelKilometerEnd"></see></summary>
    let tunnelKilometerEnd =
        Namespaced_IRI.parse _namespace_name "tunnelKilometerEnd" |> NamespacedName

    /// <summary>
    /// Part of the Start of tunnel that indicates the km of the line at the beginning of a tunnel.
    ///
    /// The Start of tunnel is the Geographical coordinates in decimal degrees and km of the line at the beginning of a tunnel.
    /// <see href="http://data.europa.eu/949/lineReferenceTunnelStart"></see></summary>
    let lineReferenceTunnelStart =
        Namespaced_IRI.parse _namespace_name "lineReferenceTunnelStart" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LineReferenceTunnelStart"></see>
    /// </summary>
    let ``shapes/LineReferenceTunnelStart`` =
        Namespaced_IRI.parse _namespace_name "shapes/LineReferenceTunnelStart" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/tunnelKilometerStart"></see>
    /// </summary>
    let tunnelKilometerStart =
        Namespaced_IRI.parse _namespace_name "tunnelKilometerStart" |> NamespacedName

    /// <summary>
    /// Indicates the position of an object within a linear positioning system. For example, relative to a national railway line
    /// <see href="http://data.europa.eu/949/linearCoordinate"></see></summary>
    let linearCoordinate =
        Namespaced_IRI.parse _namespace_name "linearCoordinate" |> NamespacedName

    /// <summary>
    /// Indication of types of appearance of track lineside distance indications.
    /// <see href="http://data.europa.eu/949/linesideDistanceIndication"></see></summary>
    let linesideDistanceIndication =
        Namespaced_IRI.parse _namespace_name "linesideDistanceIndication" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationCCS"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationCCS`` =
        Namespaced_IRI.parse _namespace_name "shapes/LinesideDistanceIndicationCCS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationRT"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationRT`` =
        Namespaced_IRI.parse _namespace_name "shapes/LinesideDistanceIndicationRT" |> NamespacedName

    /// <summary>
    /// Indication of types of appearance of track lineside distance indications.
    /// <see href="http://data.europa.eu/949/linesideDistanceIndicationAppearance"></see></summary>
    let linesideDistanceIndicationAppearance =
        Namespaced_IRI.parse _namespace_name "linesideDistanceIndicationAppearance" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/lineside-distance-indication-appearance/LinesideDistanceIndicationAppearance"></see>
    /// </summary>
    let ``concepts/lineside-distance-indication-appearance/LinesideDistanceIndicationAppearance`` =
        Namespaced_IRI.parse _namespace_name "concepts/lineside-distance-indication-appearance/LinesideDistanceIndicationAppearance" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationAppearanceSKOS"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationAppearanceSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/LinesideDistanceIndicationAppearanceSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationAppearance"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationAppearance`` =
        Namespaced_IRI.parse _namespace_name "shapes/LinesideDistanceIndicationAppearance" |> NamespacedName

    /// <summary>
    /// Frequency of track lineside distance indications.
    /// <see href="http://data.europa.eu/949/linesideDistanceIndicationFrequency"></see></summary>
    let linesideDistanceIndicationFrequency =
        Namespaced_IRI.parse _namespace_name "linesideDistanceIndicationFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationFrequency"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationFrequency`` =
        Namespaced_IRI.parse _namespace_name "shapes/LinesideDistanceIndicationFrequency" |> NamespacedName

    /// <summary>
    /// Indication of the side along the track where the lineside indication is positioned (left or right, or both sides).
    /// <see href="http://data.europa.eu/949/linesideDistanceIndicationPositioning"></see></summary>
    let linesideDistanceIndicationPositioning =
        Namespaced_IRI.parse _namespace_name "linesideDistanceIndicationPositioning" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/lineside-distance-indication-positioning/LinesideDistanceIndicationPositioning"></see>
    /// </summary>
    let ``concepts/lineside-distance-indication-positioning/LinesideDistanceIndicationPositioning`` =
        Namespaced_IRI.parse _namespace_name "concepts/lineside-distance-indication-positioning/LinesideDistanceIndicationPositioning" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationPositioningSKOS"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationPositioningSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/LinesideDistanceIndicationPositioningSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationPositioning"></see>
    /// </summary>
    let ``shapes/LinesideDistanceIndicationPositioning`` =
        Namespaced_IRI.parse _namespace_name "shapes/LinesideDistanceIndicationPositioning" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LinkedToPrimaryLocation"></see>
    /// </summary>
    let ``shapes/LinkedToPrimaryLocation`` =
        Namespaced_IRI.parse _namespace_name "shapes/LinkedToPrimaryLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/load-capabilities/LoadCapabilities"></see>
    /// </summary>
    let ``concepts/load-capabilities/LoadCapabilities`` =
        Namespaced_IRI.parse _namespace_name "concepts/load-capabilities/LoadCapabilities" |> NamespacedName

    /// <summary>
    /// Relates the track with the class LoadCapability. A combination of the line category and speed at the weakest point of the track.
    /// <see href="http://data.europa.eu/949/trackLoadCapability"></see></summary>
    let trackLoadCapability =
        Namespaced_IRI.parse _namespace_name "trackLoadCapability" |> NamespacedName

    /// <summary>
    /// Part of the load capability of a track that corresponds to the line category of the load model.
    /// The load capability is a value selected from the list of load models representing the line category which is amended by value of speed [km/h] permitted for a specific load model. The list of values may also be Route Availability which is amended by value of speed [miles/h] permitted for a specific load model.
    /// <see href="http://data.europa.eu/949/loadCapabilityLineCategory"></see></summary>
    let loadCapabilityLineCategory =
        Namespaced_IRI.parse _namespace_name "loadCapabilityLineCategory" |> NamespacedName

    /// <summary>
    /// Part of the load capability of a track that corresponds to the speed of the load model
    /// <see href="http://data.europa.eu/949/loadCapabilitySpeed"></see></summary>
    let loadCapabilitySpeed =
        Namespaced_IRI.parse _namespace_name "loadCapabilitySpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/load-capability-line-categories/LoadCapabilityLineCategories"></see>
    /// </summary>
    let ``concepts/load-capability-line-categories/LoadCapabilityLineCategories`` =
        Namespaced_IRI.parse _namespace_name "concepts/load-capability-line-categories/LoadCapabilityLineCategories" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LoadCapabilityLineCategory"></see>
    /// </summary>
    let ``shapes/LoadCapabilityLineCategory`` =
        Namespaced_IRI.parse _namespace_name "shapes/LoadCapabilityLineCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LoadCapabilityLineCategorySKOS"></see>
    /// </summary>
    let ``shapes/LoadCapabilityLineCategorySKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/LoadCapabilityLineCategorySKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LoadCapabilitySpeed"></see>
    /// </summary>
    let ``shapes/LoadCapabilitySpeed`` =
        Namespaced_IRI.parse _namespace_name "shapes/LoadCapabilitySpeed" |> NamespacedName

    /// <summary>
    /// Maximum physical dimensions (height and width) to which an open rail wagon can be loaded
    /// <see href="http://data.europa.eu/949/loadingGauge"></see></summary>
    let loadingGauge =
        Namespaced_IRI.parse _namespace_name "loadingGauge" |> NamespacedName

    /// <summary>
    /// Height of loading platform (for flat wagons and combined transport), given in mm.
    /// <see href="http://data.europa.eu/949/loadingPlatformHeight"></see></summary>
    let loadingPlatformHeight =
        Namespaced_IRI.parse _namespace_name "loadingPlatformHeight" |> NamespacedName

    /// <summary>
    /// Existence of rules and restrictions of a strictly local nature
    /// <see href="http://data.europa.eu/949/localRulesOrRestrictions"></see></summary>
    let localRulesOrRestrictions =
        Namespaced_IRI.parse _namespace_name "localRulesOrRestrictions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LocalRulesOrRestrictions"></see>
    /// </summary>
    let ``shapes/LocalRulesOrRestrictions`` =
        Namespaced_IRI.parse _namespace_name "shapes/LocalRulesOrRestrictions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/rulesDataParameter"></see>
    /// </summary>
    let rulesDataParameter =
        Namespaced_IRI.parse _namespace_name "rulesDataParameter" |> NamespacedName

    /// <summary>
    /// Electronic document available from the IM stored by the Agency providing additional information.
    /// <see href="http://data.europa.eu/949/localRulesOrRestrictionsDoc"></see></summary>
    let localRulesOrRestrictionsDoc =
        Namespaced_IRI.parse _namespace_name "localRulesOrRestrictionsDoc" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LocalRulesOrRestrictionsDoc"></see>
    /// </summary>
    let ``shapes/LocalRulesOrRestrictionsDoc`` =
        Namespaced_IRI.parse _namespace_name "shapes/LocalRulesOrRestrictionsDoc" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LocalRulesOrRestrictionsDocApplicability"></see>
    /// </summary>
    let ``shapes/LocalRulesOrRestrictionsDocApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/LocalRulesOrRestrictionsDocApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/rulesObjParameter"></see>
    /// </summary>
    let rulesObjParameter =
        Namespaced_IRI.parse _namespace_name "rulesObjParameter" |> NamespacedName

    /// <summary>
    /// The preferred line referencing system.
    /// <see href="http://data.europa.eu/949/lrsMethod"></see></summary>
    let lrsMethod = Namespaced_IRI.parse _namespace_name "lrsMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/lines/ReferenceSystems"></see>
    /// </summary>
    let ``concepts/lines/ReferenceSystems`` =
        Namespaced_IRI.parse _namespace_name "concepts/lines/ReferenceSystems" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LrsMethod"></see>
    /// </summary>
    let ``shapes/LrsMethod`` =
        Namespaced_IRI.parse _namespace_name "shapes/LrsMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/LrsMethodSKOS"></see>
    /// </summary>
    let ``shapes/LrsMethodSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/LrsMethodSKOS" |> NamespacedName

    /// <summary>
    /// On-Board system reaction when T_NVCONTACT expires
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/mNvcontact"></see></summary>
    let mNvcontact = Namespaced_IRI.parse _namespace_name "mNvcontact" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-reactions-contact/ETCSReactionsNVContact"></see>
    /// </summary>
    let ``concepts/etcs-reactions-contact/ETCSReactionsNVContact`` =
        Namespaced_IRI.parse _namespace_name "concepts/etcs-reactions-contact/ETCSReactionsNVContact" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MNvcontact"></see>
    /// </summary>
    let ``shapes/MNvcontact`` =
        Namespaced_IRI.parse _namespace_name "shapes/MNvcontact" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MNvcontactApplicability"></see>
    /// </summary>
    let ``shapes/MNvcontactApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/MNvcontactApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MNvcontactSKOS"></see>
    /// </summary>
    let ``shapes/MNvcontactSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/MNvcontactSKOS" |> NamespacedName

    /// <summary>
    /// Entry of Driver ID permitted while running According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/mNvderun"></see></summary>
    let mNvderun = Namespaced_IRI.parse _namespace_name "mNvderun" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MNvderun"></see>
    /// </summary>
    let ``shapes/MNvderun`` =
        Namespaced_IRI.parse _namespace_name "shapes/MNvderun" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MNvderunApplicability"></see>
    /// </summary>
    let ``shapes/MNvderunApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/MNvderunApplicability" |> NamespacedName

    /// <summary>
    /// Possibility of preventing the use of the magnetic track brake (only if fitted with magnetic brake)
    /// <see href="http://data.europa.eu/949/magneticBrakePrevention"></see></summary>
    let magneticBrakePrevention =
        Namespaced_IRI.parse _namespace_name "magneticBrakePrevention" |> NamespacedName

    /// <summary>
    /// Indication of limitations on the use of magnetic brakes.
    /// <see href="http://data.europa.eu/949/magneticBraking"></see></summary>
    let magneticBraking =
        Namespaced_IRI.parse _namespace_name "magneticBraking" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/magnetic-braking/MagneticBraking"></see>
    /// </summary>
    let ``concepts/magnetic-braking/MagneticBraking`` =
        Namespaced_IRI.parse _namespace_name "concepts/magnetic-braking/MagneticBraking" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MagneticBrakingSKOS"></see>
    /// </summary>
    let ``shapes/MagneticBrakingSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/MagneticBrakingSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MagneticBraking"></see>
    /// </summary>
    let ``shapes/MagneticBraking`` =
        Namespaced_IRI.parse _namespace_name "shapes/MagneticBraking" |> NamespacedName

    /// <summary>
    /// Electronic document available in two EU languages from the IM stored by the Agency with conditions for the use of magnetic brakes identified in 1.1.1.1.6.3.
    /// <see href="http://data.europa.eu/949/magneticBrakingConditionsDocument"></see></summary>
    let magneticBrakingConditionsDocument =
        Namespaced_IRI.parse _namespace_name "magneticBrakingConditionsDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MagneticBrakingConditionsDocument"></see>
    /// </summary>
    let ``shapes/MagneticBrakingConditionsDocument`` =
        Namespaced_IRI.parse _namespace_name "shapes/MagneticBrakingConditionsDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MagneticBrakingConditionsDocumentApplicability"></see>
    /// </summary>
    let ``shapes/MagneticBrakingConditionsDocumentApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/MagneticBrakingConditionsDocumentApplicability" |> NamespacedName

    /// <summary>
    /// Magnetic track brake fitted. New property defined to distinguish it from magneticBraking which is a RINF SKOS property.
    /// <see href="http://data.europa.eu/949/magneticBrakingFitted"></see></summary>
    let magneticBrakingFitted =
        Namespaced_IRI.parse _namespace_name "magneticBrakingFitted" |> NamespacedName

    /// <summary>
    /// Indicates the country in which a vehicle or vehicle type is manufactured.
    /// <see href="http://data.europa.eu/949/manufacturingCountry"></see></summary>
    let manufacturingCountry =
        Namespaced_IRI.parse _namespace_name "manufacturingCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/vehicleTechnicalObjCharacteristic"></see>
    /// </summary>
    let vehicleTechnicalObjCharacteristic =
        Namespaced_IRI.parse _namespace_name "vehicleTechnicalObjCharacteristic" |> NamespacedName

    /// <summary>
    /// Mass per wheel, given in kg.
    /// <see href="http://data.europa.eu/949/massPerWheel"></see></summary>
    let massPerWheel =
        Namespaced_IRI.parse _namespace_name "massPerWheel" |> NamespacedName

    /// <summary>
    /// Maximum permitted axle load, given in tons.
    /// <see href="http://data.europa.eu/949/maxAxleLoadOfSoL"></see></summary>
    let maxAxleLoadOfSoL =
        Namespaced_IRI.parse _namespace_name "maxAxleLoadOfSoL" |> NamespacedName

    /// <summary>
    /// Indication of the maximum allowable train current at standstill expressed in amperes.
    /// <see href="http://data.europa.eu/949/maxCurrentStandstillPantograph"></see></summary>
    let maxCurrentStandstillPantograph =
        Namespaced_IRI.parse _namespace_name "maxCurrentStandstillPantograph" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaxCurrentStandstillPantograph"></see>
    /// </summary>
    let ``shapes/MaxCurrentStandstillPantograph`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaxCurrentStandstillPantograph" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaxCurrentStandstillPantographS"></see>
    /// </summary>
    let ``shapes/MaxCurrentStandstillPantographS`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaxCurrentStandstillPantographS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaxCurrentStandstillPantographApplicability"></see>
    /// </summary>
    let ``shapes/MaxCurrentStandstillPantographApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaxCurrentStandstillPantographApplicability" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter. Indication of maximum permitted distance between two consecutive axles in case of TSI non-compliance, given in millimetres.
    /// <see href="http://data.europa.eu/949/maxDistConsecutiveAxles"></see></summary>
    let maxDistConsecutiveAxles =
        Namespaced_IRI.parse _namespace_name "maxDistConsecutiveAxles" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication of maximum distance between end of train and first axle, given in millimetres, applicable for both sides (front and rear) of a vehicle or train.
    /// <see href="http://data.europa.eu/949/maxDistEndTrainFirstAxle"></see></summary>
    let maxDistEndTrainFirstAxle =
        Namespaced_IRI.parse _namespace_name "maxDistEndTrainFirstAxle" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter. Maximum permitted flange height, given in millimetres.
    /// <see href="http://data.europa.eu/949/maxFlangeHeight"></see></summary>
    let maxFlangeHeight =
        Namespaced_IRI.parse _namespace_name "maxFlangeHeight" |> NamespacedName

    /// <summary>
    /// The value of maximum permitted impedance given in ohm in case of TSI non-compliance. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/maxImpedanceWheelset"></see></summary>
    let maxImpedanceWheelset =
        Namespaced_IRI.parse _namespace_name "maxImpedanceWheelset" |> NamespacedName

    /// <summary>
    /// Maximum length of the vehicle nose.
    /// <see href="http://data.europa.eu/949/maxLengthVehicleNose"></see></summary>
    let maxLengthVehicleNose =
        Namespaced_IRI.parse _namespace_name "maxLengthVehicleNose" |> NamespacedName

    /// <summary>
    /// Maximum train length in meters allowed on a section of line, without special permission, for the operation of freight trains.
    ///                             In accordance with Regulation (EU) 2024/1679, Article 15(2)(c), this maximum length must be supported by the infrastructure manager's ability
    ///                             to allocate sufficient train paths for freight trains of at least 740 meters (including the locomotive or locomotives), as required for the TEN-T network.
    /// <see href="http://data.europa.eu/949/maxPermittedTrainLength"></see></summary>
    let maxPermittedTrainLength =
        Namespaced_IRI.parse _namespace_name "maxPermittedTrainLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaxPermittedTrainLength"></see>
    /// </summary>
    let ``shapes/MaxPermittedTrainLength`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaxPermittedTrainLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaxPermittedTrainLengthApplicability"></see>
    /// </summary>
    let ``shapes/MaxPermittedTrainLengthApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaxPermittedTrainLengthApplicability" |> NamespacedName

    /// <summary>
    /// Maximum amount of sand accepted on the track within value of sanding output for 30s, given in grams.
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/maxSandingOutput"></see></summary>
    let maxSandingOutput =
        Namespaced_IRI.parse _namespace_name "maxSandingOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/max-amount-sandings/MaxAmountSandings"></see>
    /// </summary>
    let ``concepts/max-amount-sandings/MaxAmountSandings`` =
        Namespaced_IRI.parse _namespace_name "concepts/max-amount-sandings/MaxAmountSandings" |> NamespacedName

    /// <summary>
    /// Indication of the maximum allowable train current expressed in amperes.
    /// <see href="http://data.europa.eu/949/maxTrainCurrent"></see></summary>
    let maxTrainCurrent =
        Namespaced_IRI.parse _namespace_name "maxTrainCurrent" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumTrainCurrent"></see>
    /// </summary>
    let ``shapes/MaximumTrainCurrent`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaximumTrainCurrent" |> NamespacedName

    /// <summary>
    /// Indicate the speed limit in a tunnel
    /// <see href="http://data.europa.eu/949/maxTunnelSpeed"></see></summary>
    let maxTunnelSpeed =
        Namespaced_IRI.parse _namespace_name "maxTunnelSpeed" |> NamespacedName

    /// <summary>
    /// Indicates the maximun wind speed for which the bridge can operate
    /// <see href="http://data.europa.eu/949/maxbridgeWind"></see></summary>
    let maxbridgeWind =
        Namespaced_IRI.parse _namespace_name "maxbridgeWind" |> NamespacedName

    /// <summary>
    /// Highest point of the section of line above sea level in reference to Normal Amsterdam's Peil (NAP).
    /// <see href="http://data.europa.eu/949/maximumAltitude"></see></summary>
    let maximumAltitude =
        Namespaced_IRI.parse _namespace_name "maximumAltitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumAltitude"></see>
    /// </summary>
    let ``shapes/MaximumAltitude`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaximumAltitude" |> NamespacedName

    /// <summary>
    /// Maximum train deceleration given in m/s².
    /// <see href="http://data.europa.eu/949/maximumAverageDeceleration"></see></summary>
    let maximumAverageDeceleration =
        Namespaced_IRI.parse _namespace_name "maximumAverageDeceleration" |> NamespacedName

    /// <summary>
    /// Maximum brake thermal energy capacity given in kJ
    /// <see href="http://data.europa.eu/949/maximumBrakeThermalEnergyCapacity"></see></summary>
    let maximumBrakeThermalEnergyCapacity =
        Namespaced_IRI.parse _namespace_name "maximumBrakeThermalEnergyCapacity" |> NamespacedName

    /// <summary>
    /// The maximum value of the braking distance [in metres] of a train shall be given for the maximum line speed.
    /// <see href="http://data.europa.eu/949/maximumBrakingDistance"></see></summary>
    let maximumBrakingDistance =
        Namespaced_IRI.parse _namespace_name "maximumBrakingDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumBrakingDistance"></see>
    /// </summary>
    let ``shapes/MaximumBrakingDistance`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaximumBrakingDistance" |> NamespacedName

    /// <summary>
    /// Indication of the maximum contact wire height expressed in metres.
    /// <see href="http://data.europa.eu/949/maximumContactWireHeight"></see></summary>
    let maximumContactWireHeight =
        Namespaced_IRI.parse _namespace_name "maximumContactWireHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumContactWireHeightApplicability"></see>
    /// </summary>
    let ``shapes/MaximumContactWireHeightApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaximumContactWireHeightApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumContactWireHeight"></see>
    /// </summary>
    let ``shapes/MaximumContactWireHeight`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaximumContactWireHeight" |> NamespacedName

    /// <summary>
    /// Maximum design speed.
    /// <see href="http://data.europa.eu/949/maximumDesignSpeed"></see></summary>
    let maximumDesignSpeed =
        Namespaced_IRI.parse _namespace_name "maximumDesignSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumInterferenceCurrent"></see>
    /// </summary>
    let ``shapes/MaximumInterferenceCurrent`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaximumInterferenceCurrent" |> NamespacedName

    /// <summary>
    /// Maximum interference current limits allowed for track circuits for a defined frequency band.
    /// <see href="http://data.europa.eu/949/maximumInterferenceCurrentEvaluation"></see></summary>
    let maximumInterferenceCurrentEvaluation =
        Namespaced_IRI.parse _namespace_name "maximumInterferenceCurrentEvaluation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumInterferenceCurrentEvaluation"></see>
    /// </summary>
    let ``shapes/MaximumInterferenceCurrentEvaluation`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaximumInterferenceCurrentEvaluation" |> NamespacedName

    /// <summary>
    /// Maximum number of trainsets or locomotives coupled together in multiple operation.
    /// <see href="http://data.europa.eu/949/maximumLocomotivesCoupled"></see></summary>
    let maximumLocomotivesCoupled =
        Namespaced_IRI.parse _namespace_name "maximumLocomotivesCoupled" |> NamespacedName

    /// <summary>
    /// The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band. Direction X.
    /// <see href="http://data.europa.eu/949/maximumMagneticFieldDirectionX"></see></summary>
    let maximumMagneticFieldDirectionX =
        Namespaced_IRI.parse _namespace_name "maximumMagneticFieldDirectionX" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumMagneticFieldDirectionX"></see>
    /// </summary>
    let ``shapes/MaximumMagneticFieldDirectionX`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaximumMagneticFieldDirectionX" |> NamespacedName

    /// <summary>
    /// The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band. Direction Y.
    /// <see href="http://data.europa.eu/949/maximumMagneticFieldDirectionY"></see></summary>
    let maximumMagneticFieldDirectionY =
        Namespaced_IRI.parse _namespace_name "maximumMagneticFieldDirectionY" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumMagneticFieldDirectionY"></see>
    /// </summary>
    let ``shapes/MaximumMagneticFieldDirectionY`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaximumMagneticFieldDirectionY" |> NamespacedName

    /// <summary>
    /// The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band. Direction Z.
    /// <see href="http://data.europa.eu/949/maximumMagneticFieldDirectionZ"></see></summary>
    let maximumMagneticFieldDirectionZ =
        Namespaced_IRI.parse _namespace_name "maximumMagneticFieldDirectionZ" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumMagneticFieldDirectionZ"></see>
    /// </summary>
    let ``shapes/MaximumMagneticFieldDirectionZ`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaximumMagneticFieldDirectionZ" |> NamespacedName

    /// <summary>
    /// Maximum permitted meter load, given in tons
    /// <see href="http://data.europa.eu/949/maximumPermittedMeterLoad"></see></summary>
    let maximumPermittedMeterLoad =
        Namespaced_IRI.parse _namespace_name "maximumPermittedMeterLoad" |> NamespacedName

    /// <summary>
    /// Nominal maximum operational speed on the line as a result of infrastructure, energy and control, command signalling subsystem characteristics expressed in kilometres/hour.
    /// <see href="http://data.europa.eu/949/maximumPermittedSpeed"></see></summary>
    let maximumPermittedSpeed =
        Namespaced_IRI.parse _namespace_name "maximumPermittedSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumPermittedSpeed"></see>
    /// </summary>
    let ``shapes/MaximumPermittedSpeed`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaximumPermittedSpeed" |> NamespacedName

    /// <summary>
    /// At maximum service brake: Stopping distance, Maximum deceleration, for the load condition 'design mass under normal payload' at the design maximum speed.
    /// <see href="http://data.europa.eu/949/maximumServiceBrake"></see></summary>
    let maximumServiceBrake =
        Namespaced_IRI.parse _namespace_name "maximumServiceBrake" |> NamespacedName

    /// <summary>
    /// Part of the combination of maximum speed and maximum cant deficiency for which the vehicle was assessed. Corresponds to the maximum cant deficiency.
    /// <see href="http://data.europa.eu/949/vehicleTypeMaximumCantDeficiency"></see></summary>
    let vehicleTypeMaximumCantDeficiency =
        Namespaced_IRI.parse _namespace_name "vehicleTypeMaximumCantDeficiency" |> NamespacedName

    /// <summary>
    /// Relates the vehicle type with its values of maximum speed and cant deficiency.
    /// <see href="http://data.europa.eu/949/vehicleTypeMaximumSpeedAndCantDeficiency"></see></summary>
    let vehicleTypeMaximumSpeedAndCantDeficiency =
        Namespaced_IRI.parse _namespace_name "vehicleTypeMaximumSpeedAndCantDeficiency" |> NamespacedName

    /// <summary>
    /// Part of the combination of maximum speed and maximum cant deficiency for which the vehicle was assessed. Corresponds to the maximum speed.
    /// <see href="http://data.europa.eu/949/vehicleTypeMaximumSpeed"></see></summary>
    let vehicleTypeMaximumSpeed =
        Namespaced_IRI.parse _namespace_name "vehicleTypeMaximumSpeed" |> NamespacedName

    /// <summary>
    /// Maximum speed when empty.
    /// <see href="http://data.europa.eu/949/maximumSpeedEmpty"></see></summary>
    let maximumSpeedEmpty =
        Namespaced_IRI.parse _namespace_name "maximumSpeedEmpty" |> NamespacedName

    /// <summary>
    /// Deprecated because both RINF and ERATV define a temperature range as a set of predefined values (see https://www.era.europa.eu/system/files/2023-04/iu-eratv_application_guide_for_register_2016-797_en_0.pdf). Maximum temperature allowed for unrestricted operation access, according to European standard.
    /// <see href="http://data.europa.eu/949/maximumTemperature"></see></summary>
    let maximumTemperature =
        Namespaced_IRI.parse _namespace_name "maximumTemperature" |> NamespacedName

    /// <summary>
    /// Temperature range for unrestricted access to the line.
    /// <see href="http://data.europa.eu/949/temperatureRange"></see></summary>
    let temperatureRange =
        Namespaced_IRI.parse _namespace_name "temperatureRange" |> NamespacedName

    /// <summary>
    /// Limit for longitudinal track resistance given as a maximum allowed train deceleration and expressed in metres per square second.
    /// <see href="http://data.europa.eu/949/maximumTrainDeceleration"></see></summary>
    let maximumTrainDeceleration =
        Namespaced_IRI.parse _namespace_name "maximumTrainDeceleration" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MaximumTrainDeceleration"></see>
    /// </summary>
    let ``shapes/MaximumTrainDeceleration`` =
        Namespaced_IRI.parse _namespace_name "shapes/MaximumTrainDeceleration" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trackResistanceToAppliedLoadsDataParameter"></see>
    /// </summary>
    let trackResistanceToAppliedLoadsDataParameter =
        Namespaced_IRI.parse _namespace_name "trackResistanceToAppliedLoadsDataParameter" |> NamespacedName

    /// <summary>
    /// Maximum train length allowed on a line or section
    /// <see href="http://data.europa.eu/949/maximumTrainLength"></see></summary>
    let maximumTrainLength =
        Namespaced_IRI.parse _namespace_name "maximumTrainLength" |> NamespacedName

    /// <summary>
    /// Measured distance from the origin of the LRS.
    /// <see href="http://data.europa.eu/949/measuredDistance"></see></summary>
    let measuredDistance =
        Namespaced_IRI.parse _namespace_name "measuredDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MeasuredDistance"></see>
    /// </summary>
    let ``shapes/MeasuredDistance`` =
        Namespaced_IRI.parse _namespace_name "shapes/MeasuredDistance" |> NamespacedName

    /// <summary>
    /// Type meets the requirements necessary for validity of the vehicle authorisation granted by one Member State in other MSs.
    /// <see href="http://data.europa.eu/949/meetsRequirementVehicleAuthorisation"></see></summary>
    let meetsRequirementVehicleAuthorisation =
        Namespaced_IRI.parse _namespace_name "meetsRequirementVehicleAuthorisation" |> NamespacedName

    /// <summary>
    /// Minimum permitted axle load, given in tons.
    /// <see href="http://data.europa.eu/949/minAxleLoad"></see></summary>
    let minAxleLoad =
        Namespaced_IRI.parse _namespace_name "minAxleLoad" |> NamespacedName

    /// <summary>
    /// Represents the category of vehicle which is amended by value of minimum permitted axle load [tons] (property minAxleLoad).
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/minAxleLoadVehicleCategory"></see></summary>
    let minAxleLoadVehicleCategory =
        Namespaced_IRI.parse _namespace_name "minAxleLoadVehicleCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/min-axle-load-vehicle-categories/MinAxleLoadVehicleCategories"></see>
    /// </summary>
    let ``concepts/min-axle-load-vehicle-categories/MinAxleLoadVehicleCategories`` =
        Namespaced_IRI.parse _namespace_name "concepts/min-axle-load-vehicle-categories/MinAxleLoadVehicleCategories" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.
    /// <see href="http://data.europa.eu/949/minDistConsecutiveAxles"></see></summary>
    let minDistConsecutiveAxles =
        Namespaced_IRI.parse _namespace_name "minDistConsecutiveAxles" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.
    /// <see href="http://data.europa.eu/949/minDistFirstLastAxle"></see></summary>
    let minDistFirstLastAxle =
        Namespaced_IRI.parse _namespace_name "minDistFirstLastAxle" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.
    /// <see href="http://data.europa.eu/949/minFlangeHeight"></see></summary>
    let minFlangeHeight =
        Namespaced_IRI.parse _namespace_name "minFlangeHeight" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.
    /// <see href="http://data.europa.eu/949/minFlangeThickness"></see></summary>
    let minFlangeThickness =
        Namespaced_IRI.parse _namespace_name "minFlangeThickness" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.
    /// <see href="http://data.europa.eu/949/minRimWidth"></see></summary>
    let minRimWidth =
        Namespaced_IRI.parse _namespace_name "minRimWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/otherTrainDetectionSystemsDataParameter"></see>
    /// </summary>
    let otherTrainDetectionSystemsDataParameter =
        Namespaced_IRI.parse _namespace_name "otherTrainDetectionSystemsDataParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleImpedance"></see>
    /// </summary>
    let ``shapes/MinVehicleImpedance`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinVehicleImpedance" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleImpedanceApplicability"></see>
    /// </summary>
    let ``shapes/MinVehicleImpedanceApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinVehicleImpedanceApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/minVehicleImpedanceVoltages"></see>
    /// </summary>
    let minVehicleImpedanceVoltages =
        Namespaced_IRI.parse _namespace_name "minVehicleImpedanceVoltages" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleImpedanceVoltagesSKOS"></see>
    /// </summary>
    let ``shapes/MinVehicleImpedanceVoltagesSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinVehicleImpedanceVoltagesSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleImpedanceVoltagesApplicability"></see>
    /// </summary>
    let ``shapes/MinVehicleImpedanceVoltagesApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinVehicleImpedanceVoltagesApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleImpedanceVoltages"></see>
    /// </summary>
    let ``shapes/MinVehicleImpedanceVoltages`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinVehicleImpedanceVoltages" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/minVehicleInputCapacitance"></see>
    /// </summary>
    let minVehicleInputCapacitance =
        Namespaced_IRI.parse _namespace_name "minVehicleInputCapacitance" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleInputCapacitance"></see>
    /// </summary>
    let ``shapes/MinVehicleInputCapacitance`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinVehicleInputCapacitance" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleInputCapacitanceApplicability"></see>
    /// </summary>
    let ``shapes/MinVehicleInputCapacitanceApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinVehicleInputCapacitanceApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/minVehicleInputImpedance"></see>
    /// </summary>
    let minVehicleInputImpedance =
        Namespaced_IRI.parse _namespace_name "minVehicleInputImpedance" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleInputImpedance"></see>
    /// </summary>
    let ``shapes/MinVehicleInputImpedance`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinVehicleInputImpedance" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinVehicleInputImpedanceApplicability"></see>
    /// </summary>
    let ``shapes/MinVehicleInputImpedanceApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinVehicleInputImpedanceApplicability" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter.
    /// <see href="http://data.europa.eu/949/minWheelDiameter"></see></summary>
    let minWheelDiameter =
        Namespaced_IRI.parse _namespace_name "minWheelDiameter" |> NamespacedName

    /// <summary>
    /// Minimum vertical concave curve radius capability.
    /// <see href="http://data.europa.eu/949/minimumConcaveVerticalRadius"></see></summary>
    let minimumConcaveVerticalRadius =
        Namespaced_IRI.parse _namespace_name "minimumConcaveVerticalRadius" |> NamespacedName

    /// <summary>
    /// Indication of the minimum contact wire height expressed in metres.
    /// <see href="http://data.europa.eu/949/minimumContactWireHeight"></see></summary>
    let minimumContactWireHeight =
        Namespaced_IRI.parse _namespace_name "minimumContactWireHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumContactWireHeightApplicability"></see>
    /// </summary>
    let ``shapes/MinimumContactWireHeightApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinimumContactWireHeightApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumContactWireHeight"></see>
    /// </summary>
    let ``shapes/MinimumContactWireHeight`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinimumContactWireHeight" |> NamespacedName

    /// <summary>
    /// Minimum vertical convex curve radius capability.
    /// <see href="http://data.europa.eu/949/minimumConvexVerticalRadius"></see></summary>
    let minimumConvexVerticalRadius =
        Namespaced_IRI.parse _namespace_name "minimumConvexVerticalRadius" |> NamespacedName

    /// <summary>
    /// Radius of the smallest horizontal curve, expressed in metres.
    /// <see href="http://data.europa.eu/949/minimumHorizontalRadius"></see></summary>
    let minimumHorizontalRadius =
        Namespaced_IRI.parse _namespace_name "minimumHorizontalRadius" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumHorizontalRadiusS"></see>
    /// </summary>
    let ``shapes/MinimumHorizontalRadiusS`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinimumHorizontalRadiusS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumHorizontalRadius"></see>
    /// </summary>
    let ``shapes/MinimumHorizontalRadius`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinimumHorizontalRadius" |> NamespacedName

    /// <summary>
    /// Deprecated because both RINF and ERATV define a temperature range as a set of predefined values (see https://www.era.europa.eu/system/files/2023-04/iu-eratv_application_guide_for_register_2016-797_en_0.pdf). Minimum temperature allowed for unrestricted operation access, according to European standard.
    /// <see href="http://data.europa.eu/949/minimumTemperature"></see></summary>
    let minimumTemperature =
        Namespaced_IRI.parse _namespace_name "minimumTemperature" |> NamespacedName

    /// <summary>
    /// Radius of the smallest vertical curve expressed in metres.
    /// <see href="http://data.europa.eu/949/minimumVerticalRadius"></see></summary>
    let minimumVerticalRadius =
        Namespaced_IRI.parse _namespace_name "minimumVerticalRadius" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumVerticalRadius"></see>
    /// </summary>
    let ``shapes/MinimumVerticalRadius`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinimumVerticalRadius" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/sidingObjParameter"></see>
    /// </summary>
    let sidingObjParameter =
        Namespaced_IRI.parse _namespace_name "sidingObjParameter" |> NamespacedName

    /// <summary>
    /// Part of the minimum radius of vertical curve that indicates the crest
    /// <see href="http://data.europa.eu/949/minimumVerticalRadiusCrest"></see></summary>
    let minimumVerticalRadiusCrest =
        Namespaced_IRI.parse _namespace_name "minimumVerticalRadiusCrest" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumVerticalRadiusCrest"></see>
    /// </summary>
    let ``shapes/MinimumVerticalRadiusCrest`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinimumVerticalRadiusCrest" |> NamespacedName

    /// <summary>
    /// Part of the minimum radius of vertical curve that indicates the hollow
    /// <see href="http://data.europa.eu/949/minimumVerticalRadiusHollow"></see></summary>
    let minimumVerticalRadiusHollow =
        Namespaced_IRI.parse _namespace_name "minimumVerticalRadiusHollow" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumVerticalRadiusHollow"></see>
    /// </summary>
    let ``shapes/MinimumVerticalRadiusHollow`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinimumVerticalRadiusHollow" |> NamespacedName

    /// <summary>
    /// Maximum unguided length of fixed obtuse crossings is based on a minimum wheel diameter in service expressed in millimetres.
    /// <see href="http://data.europa.eu/949/minimumWheelDiameter"></see></summary>
    let minimumWheelDiameter =
        Namespaced_IRI.parse _namespace_name "minimumWheelDiameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/MinimumWheelDiameter"></see>
    /// </summary>
    let ``shapes/MinimumWheelDiameter`` =
        Namespaced_IRI.parse _namespace_name "shapes/MinimumWheelDiameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/switchesAndCrossingsDataParameter"></see>
    /// </summary>
    let switchesAndCrossingsDataParameter =
        Namespaced_IRI.parse _namespace_name "switchesAndCrossingsDataParameter" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication whether more than one train protection, control and warning system is required to be on-board and active simultaneously.
    /// <see href="http://data.europa.eu/949/multipleTrainProtectionRequired"></see></summary>
    let multipleTrainProtectionRequired =
        Namespaced_IRI.parse _namespace_name "multipleTrainProtectionRequired" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NationalLineSoL"></see>
    /// </summary>
    let ``shapes/NationalLineSoL`` =
        Namespaced_IRI.parse _namespace_name "shapes/NationalLineSoL" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/solGenericObjParameter"></see>
    /// </summary>
    let solGenericObjParameter =
        Namespaced_IRI.parse _namespace_name "solGenericObjParameter" |> NamespacedName

    /// <summary>
    /// National classification for load capability
    /// <see href="http://data.europa.eu/949/nationalLoadCapability"></see></summary>
    let nationalLoadCapability =
        Namespaced_IRI.parse _namespace_name "nationalLoadCapability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NationalLoadCapability"></see>
    /// </summary>
    let ``shapes/NationalLoadCapability`` =
        Namespaced_IRI.parse _namespace_name "shapes/NationalLoadCapability" |> NamespacedName

    /// <summary>
    /// Categorisation of how a passenger train with a fire on board will continue to operate for a defined time period - according to national rules if they exist.
    /// <see href="http://data.europa.eu/949/nationalRollingStockFireCategory"></see></summary>
    let nationalRollingStockFireCategory =
        Namespaced_IRI.parse _namespace_name "nationalRollingStockFireCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NationalRollingStockFireCategoryApplicability"></see>
    /// </summary>
    let ``shapes/NationalRollingStockFireCategoryApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/NationalRollingStockFireCategoryApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NationalRollingStockFireCategory"></see>
    /// </summary>
    let ``shapes/NationalRollingStockFireCategory`` =
        Namespaced_IRI.parse _namespace_name "shapes/NationalRollingStockFireCategory" |> NamespacedName

    /// <summary>
    /// Set of parameters for adapting the braking curves calculated by the ETCS on-board system to match accuracy, performance and safety margins imposed by the infrastructure manager.
    /// It copies the content of Packet 3 or of Packet 203 as defined in the specification referenced in Appendix A-1, index [C].
    /// <see href="http://data.europa.eu/949/nationalValuesBrakeModel"></see></summary>
    let nationalValuesBrakeModel =
        Namespaced_IRI.parse _namespace_name "nationalValuesBrakeModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NationalValuesBrakeModel"></see>
    /// </summary>
    let ``shapes/NationalValuesBrakeModel`` =
        Namespaced_IRI.parse _namespace_name "shapes/NationalValuesBrakeModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NationalValuesBrakeModelApplicability"></see>
    /// </summary>
    let ``shapes/NationalValuesBrakeModelApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/NationalValuesBrakeModelApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/navigabilities/Navigabilities"></see>
    /// </summary>
    let ``concepts/navigabilities/Navigabilities`` =
        Namespaced_IRI.parse _namespace_name "concepts/navigabilities/Navigabilities" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Navigability"></see>
    /// </summary>
    let ``shapes/Navigability`` =
        Namespaced_IRI.parse _namespace_name "shapes/Navigability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NavigabilitySKOS"></see>
    /// </summary>
    let ``shapes/NavigabilitySKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/NavigabilitySKOS" |> NamespacedName

    /// <summary>
    /// References an associated topological object.
    /// The reason for deprecating this property is that it is defined as "References an associated topological object." and the vocabulary has already a property "hasAbstraction" which relates the implementation layer with the topological layer, https://citnet.tech.ec.europa.eu/CITnet/confluence/pages/viewpage.action?pageId=1122974879.
    /// <see href="http://data.europa.eu/949/netElement"></see></summary>
    let netElement = Namespaced_IRI.parse _namespace_name "netElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetReference"></see>
    /// </summary>
    let ``shapes/NetReference`` =
        Namespaced_IRI.parse _namespace_name "shapes/NetReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetReferenceOP"></see>
    /// </summary>
    let ``shapes/NetReferenceOP`` =
        Namespaced_IRI.parse _namespace_name "shapes/NetReferenceOP" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NetReferenceSOL"></see>
    /// </summary>
    let ``shapes/NetReferenceSOL`` =
        Namespaced_IRI.parse _namespace_name "shapes/NetReferenceSOL" |> NamespacedName

    /// <summary>
    /// Denotes a non-coded restrictions for this particular vehicleType, as a set of sentences.
    /// <see href="http://data.europa.eu/949/nonCodedRestrictions"></see></summary>
    let nonCodedRestrictions =
        Namespaced_IRI.parse _namespace_name "nonCodedRestrictions" |> NamespacedName

    /// <summary>
    /// Reference to a property that is not applicable.
    /// <see href="http://data.europa.eu/949/notApplicable"></see></summary>
    let notApplicable =
        Namespaced_IRI.parse _namespace_name "notApplicable" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NotApplicable"></see>
    /// </summary>
    let ``shapes/NotApplicable`` =
        Namespaced_IRI.parse _namespace_name "shapes/NotApplicable" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NotApplicableShape"></see>
    /// </summary>
    let ``shapes/NotApplicableShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/NotApplicableShape" |> NamespacedName

    /// <summary>
    /// Reference to a property that is not provided.
    /// <see href="http://data.europa.eu/949/notYetAvailable"></see></summary>
    let notYetAvailable =
        Namespaced_IRI.parse _namespace_name "notYetAvailable" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NotYetAvailable"></see>
    /// </summary>
    let ``shapes/NotYetAvailable`` =
        Namespaced_IRI.parse _namespace_name "shapes/NotYetAvailable" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NotYetAvailableShape"></see>
    /// </summary>
    let ``shapes/NotYetAvailableShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/NotYetAvailableShape" |> NamespacedName

    /// <summary>
    /// Number of elements in the rake of freight wagons (only for subcategory 'rake of freight wagons')
    /// <see href="http://data.europa.eu/949/numberElementsRakeFreightWagons"></see></summary>
    let numberElementsRakeFreightWagons =
        Namespaced_IRI.parse _namespace_name "numberElementsRakeFreightWagons" |> NamespacedName

    /// <summary>
    /// Number of pantographs in contact with the overhead contact line (OCL) (to be indicated for each energy supply system the vehicle is equipped for).
    /// <see href="http://data.europa.eu/949/numberOfPantographsInContactWithOCL"></see></summary>
    let numberOfPantographsInContactWithOCL =
        Namespaced_IRI.parse _namespace_name "numberOfPantographsInContactWithOCL" |> NamespacedName

    /// <summary>
    /// Number of toilets.
    /// <see href="http://data.europa.eu/949/numberOfToilets"></see></summary>
    let numberOfToilets =
        Namespaced_IRI.parse _namespace_name "numberOfToilets" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/oclSeparationSectionsObjParameter"></see>
    /// </summary>
    let oclSeparationSectionsObjParameter =
        Namespaced_IRI.parse _namespace_name "oclSeparationSectionsObjParameter" |> NamespacedName

    /// <summary>
    /// OCL type.
    /// <see href="http://data.europa.eu/949/oclType"></see></summary>
    let oclType = Namespaced_IRI.parse _namespace_name "oclType" |> NamespacedName

    /// <summary>
    /// Indicates the parameter (object or datatype property) for which an applicability is being defined.
    /// <see href="http://data.europa.eu/949/ofParameter"></see></summary>
    let ofParameter =
        Namespaced_IRI.parse _namespace_name "ofParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OfParameter"></see>
    /// </summary>
    let ``shapes/OfParameter`` =
        Namespaced_IRI.parse _namespace_name "shapes/OfParameter" |> NamespacedName

    /// <summary>
    /// Relative distance from a reference kilometric post
    /// <see href="http://data.europa.eu/949/offsetFromKilometricPost"></see></summary>
    let offsetFromKilometricPost =
        Namespaced_IRI.parse _namespace_name "offsetFromKilometricPost" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OffsetFromKilometricPost"></see>
    /// </summary>
    let ``shapes/OffsetFromKilometricPost`` =
        Namespaced_IRI.parse _namespace_name "shapes/OffsetFromKilometricPost" |> NamespacedName

    /// <summary>
    /// Offset from the origin in a topological coordinate.
    /// <see href="http://data.europa.eu/949/offsetFromOrigin"></see></summary>
    let offsetFromOrigin =
        Namespaced_IRI.parse _namespace_name "offsetFromOrigin" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OffsetFromOrigin"></see>
    /// </summary>
    let ``shapes/OffsetFromOrigin`` =
        Namespaced_IRI.parse _namespace_name "shapes/OffsetFromOrigin" |> NamespacedName

    /// <summary>
    /// Specifies the linear element a section belongs to.
    /// <see href="http://data.europa.eu/949/onElement"></see></summary>
    let onElement = Namespaced_IRI.parse _namespace_name "onElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OnElement"></see>
    /// </summary>
    let ``shapes/OnElement`` =
        Namespaced_IRI.parse _namespace_name "shapes/OnElement" |> NamespacedName

    /// <summary>
    /// Specifies the linear element a coordinate is associated with.
    /// <see href="http://data.europa.eu/949/onLinearElement"></see></summary>
    let onLinearElement =
        Namespaced_IRI.parse _namespace_name "onLinearElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OnLinearElement"></see>
    /// </summary>
    let ``shapes/OnLinearElement`` =
        Namespaced_IRI.parse _namespace_name "shapes/OnLinearElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpEndExists"></see>
    /// </summary>
    let ``shapes/OpEndExists`` =
        Namespaced_IRI.parse _namespace_name "shapes/OpEndExists" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpEnd"></see>
    /// </summary>
    let ``shapes/OpEnd`` =
        Namespaced_IRI.parse _namespace_name "shapes/OpEnd" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/opGenericObjParameter"></see>
    /// </summary>
    let opGenericObjParameter =
        Namespaced_IRI.parse _namespace_name "opGenericObjParameter" |> NamespacedName

    /// <summary>
    /// Name normally related to the town or village or to traffic control purpose.
    /// <see href="http://data.europa.eu/949/opName"></see></summary>
    let opName = Namespaced_IRI.parse _namespace_name "opName" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpName"></see>
    /// </summary>
    let ``shapes/OpName`` =
        Namespaced_IRI.parse _namespace_name "shapes/OpName" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpStart"></see>
    /// </summary>
    let ``shapes/OpStart`` =
        Namespaced_IRI.parse _namespace_name "shapes/OpStart" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpStartExists"></see>
    /// </summary>
    let ``shapes/OpStartExists`` =
        Namespaced_IRI.parse _namespace_name "shapes/OpStartExists" |> NamespacedName

    /// <summary>
    /// Type of facility in relation to the dominating operational functions.
    /// <see href="http://data.europa.eu/949/opType"></see></summary>
    let opType = Namespaced_IRI.parse _namespace_name "opType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/op-types/OperationalPointTypes"></see>
    /// </summary>
    let ``concepts/op-types/OperationalPointTypes`` =
        Namespaced_IRI.parse _namespace_name "concepts/op-types/OperationalPointTypes" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpTypeSKOS"></see>
    /// </summary>
    let ``shapes/OpTypeSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/OpTypeSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpTypeP"></see>
    /// </summary>
    let ``shapes/OpTypeP`` =
        Namespaced_IRI.parse _namespace_name "shapes/OpTypeP" |> NamespacedName

    /// <summary>
    /// Type of track gauge changeover facility.
    /// <see href="http://data.europa.eu/949/opTypeGaugeChangeover"></see></summary>
    let opTypeGaugeChangeover =
        Namespaced_IRI.parse _namespace_name "opTypeGaugeChangeover" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OpTypeGaugeChangeover"></see>
    /// </summary>
    let ``shapes/OpTypeGaugeChangeover`` =
        Namespaced_IRI.parse _namespace_name "shapes/OpTypeGaugeChangeover" |> NamespacedName

    /// <summary>
    /// The language or languages used in daily operation by infrastructure manager and published in its Network Statement, for the communication of operational or safety related messages between the staff of the infrastructure manager and the railway undertaking.
    /// <see href="http://data.europa.eu/949/operatingLanguage"></see></summary>
    let operatingLanguage =
        Namespaced_IRI.parse _namespace_name "operatingLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/routeBookObjectParameter"></see>
    /// </summary>
    let routeBookObjectParameter =
        Namespaced_IRI.parse _namespace_name "routeBookObjectParameter" |> NamespacedName

    /// <summary>
    /// Double track type.
    /// <see href="http://data.europa.eu/949/operationalRegimeType"></see></summary>
    let operationalRegimeType =
        Namespaced_IRI.parse _namespace_name "operationalRegimeType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/operational-regime-types/OperationalRegimeTypes"></see>
    /// </summary>
    let ``concepts/operational-regime-types/OperationalRegimeTypes`` =
        Namespaced_IRI.parse _namespace_name "concepts/operational-regime-types/OperationalRegimeTypes" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OperationalRegimeType"></see>
    /// </summary>
    let ``shapes/OperationalRegimeType`` =
        Namespaced_IRI.parse _namespace_name "shapes/OperationalRegimeType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OperationalRegimeTypeSKOS"></see>
    /// </summary>
    let ``shapes/OperationalRegimeTypeSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/OperationalRegimeTypeSKOS" |> NamespacedName

    /// <summary>
    /// Indicates an operational restriction of vehicle or wagon. Parking brake type (if the vehicle is fitted with it).
    /// <see href="http://data.europa.eu/949/operationalRestriction"></see></summary>
    let operationalRestriction =
        Namespaced_IRI.parse _namespace_name "operationalRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/restrictions/Restrictions"></see>
    /// </summary>
    let ``concepts/restrictions/Restrictions`` =
        Namespaced_IRI.parse _namespace_name "concepts/restrictions/Restrictions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OrganisationCode"></see>
    /// </summary>
    let ``shapes/OrganisationCode`` =
        Namespaced_IRI.parse _namespace_name "shapes/OrganisationCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trackGenericDataParameter"></see>
    /// </summary>
    let trackGenericDataParameter =
        Namespaced_IRI.parse _namespace_name "trackGenericDataParameter" |> NamespacedName

    /// <summary>
    /// (deprecated) not in use anymore
    /// <see href="http://data.europa.eu/949/osmClass"></see></summary>
    let osmClass = Namespaced_IRI.parse _namespace_name "osmClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/osm-classes/OSMClasses"></see>
    /// </summary>
    let ``concepts/osm-classes/OSMClasses`` =
        Namespaced_IRI.parse _namespace_name "concepts/osm-classes/OSMClasses" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherCantDeficiencyBasicSSP"></see>
    /// </summary>
    let ``shapes/OtherCantDeficiencyBasicSSP`` =
        Namespaced_IRI.parse _namespace_name "shapes/OtherCantDeficiencyBasicSSP" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherCantDeficiencyBasicSSPApplicability"></see>
    /// </summary>
    let ``shapes/OtherCantDeficiencyBasicSSPApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/OtherCantDeficiencyBasicSSPApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherCantDeficiencyBasicSSPSKOS"></see>
    /// </summary>
    let ``shapes/OtherCantDeficiencyBasicSSPSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/OtherCantDeficiencyBasicSSPSKOS" |> NamespacedName

    /// <summary>
    /// Indication of pantograph heads which are allowed to be used.
    /// <see href="http://data.europa.eu/949/otherPantographHead"></see></summary>
    let otherPantographHead =
        Namespaced_IRI.parse _namespace_name "otherPantographHead" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/other-pantograph-heads/OtherPantographHeads"></see>
    /// </summary>
    let ``concepts/other-pantograph-heads/OtherPantographHeads`` =
        Namespaced_IRI.parse _namespace_name "concepts/other-pantograph-heads/OtherPantographHeads" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherPantographHeadSKOS"></see>
    /// </summary>
    let ``shapes/OtherPantographHeadSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/OtherPantographHeadSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherPantographHeadApplicability"></see>
    /// </summary>
    let ``shapes/OtherPantographHeadApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/OtherPantographHeadApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/otherTrainDetectionSystemsObjParameter"></see>
    /// </summary>
    let otherTrainDetectionSystemsObjParameter =
        Namespaced_IRI.parse _namespace_name "otherTrainDetectionSystemsObjParameter" |> NamespacedName

    /// <summary>
    /// Indication of existence of other system than ETCS for degraded situation.
    /// <see href="http://data.europa.eu/949/otherTrainProtection"></see></summary>
    let otherTrainProtection =
        Namespaced_IRI.parse _namespace_name "otherTrainProtection" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/other-protection-control-warning/OtherProtectionControlWarnings"></see>
    /// </summary>
    let ``concepts/other-protection-control-warning/OtherProtectionControlWarnings`` =
        Namespaced_IRI.parse _namespace_name "concepts/other-protection-control-warning/OtherProtectionControlWarnings" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherTrainProtectionSKOS"></see>
    /// </summary>
    let ``shapes/OtherTrainProtectionSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/OtherTrainProtectionSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherTrainProtectionApplicability"></see>
    /// </summary>
    let ``shapes/OtherTrainProtectionApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/OtherTrainProtectionApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/OtherTrainProtection"></see>
    /// </summary>
    let ``shapes/OtherTrainProtection`` =
        Namespaced_IRI.parse _namespace_name "shapes/OtherTrainProtection" |> NamespacedName

    /// <summary>
    /// Relates an infrastructure element or a common characteristics subset with the applicability of a certain parameter.
    /// <see href="http://data.europa.eu/949/parameterApplicability"></see></summary>
    let parameterApplicability =
        Namespaced_IRI.parse _namespace_name "parameterApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ParameterApplicability"></see>
    /// </summary>
    let ``shapes/ParameterApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/ParameterApplicability" |> NamespacedName

    /// <summary>
    /// This property is used to link an applicability to the precise value of the parameter
    /// <see href="http://data.europa.eu/949/parameterValue"></see></summary>
    let parameterValue =
        Namespaced_IRI.parse _namespace_name "parameterValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ParameterValue"></see>
    /// </summary>
    let ``shapes/ParameterValue`` =
        Namespaced_IRI.parse _namespace_name "shapes/ParameterValue" |> NamespacedName

    /// <summary>
    /// In the case of a change in the value of a parameter, there needs to be an information on the type of the new value. The “Value type” will have different possible options: “nominal”, “planned temporary restriction”, “permanent restriction”, “planned temporary closure”.
    /// <see href="http://data.europa.eu/949/parameterValueType"></see></summary>
    let parameterValueType =
        Namespaced_IRI.parse _namespace_name "parameterValueType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/parameterApplicability/ValueTypes"></see>
    /// </summary>
    let ``concepts/parameterApplicability/ValueTypes`` =
        Namespaced_IRI.parse _namespace_name "concepts/parameterApplicability/ValueTypes" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ParameterValueTypeSKOS"></see>
    /// </summary>
    let ``shapes/ParameterValueTypeSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/ParameterValueTypeSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ParameterValueType"></see>
    /// </summary>
    let ``shapes/ParameterValueType`` =
        Namespaced_IRI.parse _namespace_name "shapes/ParameterValueType" |> NamespacedName

    /// <summary>
    /// Indicates whether all vehicles of this type must be equipped with a parking brake.
    /// <see href="http://data.europa.eu/949/parkingBrake"></see></summary>
    let parkingBrake =
        Namespaced_IRI.parse _namespace_name "parkingBrake" |> NamespacedName

    /// <summary>
    /// All vehicles of this type must be equipped with a parking brake (parking brake mandatory for vehicles of this type).
    /// <see href="http://data.europa.eu/949/parkingBrakeMandatory"></see></summary>
    let parkingBrakeMandatory =
        Namespaced_IRI.parse _namespace_name "parkingBrakeMandatory" |> NamespacedName

    /// <summary>
    /// Maximum gradient on which the unit is kept immobilised by the parking brake alone (if the vehicle is fitted with it).
    /// <see href="http://data.europa.eu/949/parkingBrakeMaximumGradient"></see></summary>
    let parkingBrakeMaximumGradient =
        Namespaced_IRI.parse _namespace_name "parkingBrakeMaximumGradient" |> NamespacedName

    /// <summary>
    /// Parking brake type (if the vehicle is fitted with it).
    /// <see href="http://data.europa.eu/949/parkingBrakeType"></see></summary>
    let parkingBrakeType =
        Namespaced_IRI.parse _namespace_name "parkingBrakeType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/brake-parking-type/BrakeParkingType"></see>
    /// </summary>
    let ``concepts/brake-parking-type/BrakeParkingType`` =
        Namespaced_IRI.parse _namespace_name "concepts/brake-parking-type/BrakeParkingType" |> NamespacedName

    /// <summary>
    /// Links an element to its TEN-T network classification, which includes network level, type of traffic, and European transport corridor information.
    /// <see href="http://data.europa.eu/949/partOfTENT"></see></summary>
    let partOfTENT = Namespaced_IRI.parse _namespace_name "partOfTENT" |> NamespacedName

    /// <summary>
    /// Pass-by noise level given in dB(A).
    /// <see href="http://data.europa.eu/949/passByNoiseLevel"></see></summary>
    let passByNoiseLevel =
        Namespaced_IRI.parse _namespace_name "passByNoiseLevel" |> NamespacedName

    /// <summary>
    /// Passenger possible flag attached to a Primary Location
    /// <see href="http://data.europa.eu/949/passengerFlag"></see></summary>
    let passengerFlag =
        Namespaced_IRI.parse _namespace_name "passengerFlag" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PassengerFlag"></see>
    /// </summary>
    let ``shapes/PassengerFlag`` =
        Namespaced_IRI.parse _namespace_name "shapes/PassengerFlag" |> NamespacedName

    /// <summary>
    /// References a tunnel that a track goes through.
    /// <see href="http://data.europa.eu/949/passesThroughTunnel"></see></summary>
    let passesThroughTunnel =
        Namespaced_IRI.parse _namespace_name "passesThroughTunnel" |> NamespacedName

    /// <summary>
    /// Permissible payload for different line categories.
    /// <see href="http://data.europa.eu/949/permissiblePayload"></see></summary>
    let permissiblePayload =
        Namespaced_IRI.parse _namespace_name "permissiblePayload" |> NamespacedName

    /// <summary>
    /// Point at which IM authorises charging of electric energy storage for traction purposes at standstill.
    /// <see href="http://data.europa.eu/949/permissionChargingElectricEnergyTractionStandstill"></see></summary>
    let permissionChargingElectricEnergyTractionStandstill =
        Namespaced_IRI.parse _namespace_name "permissionChargingElectricEnergyTractionStandstill" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PermissionChargingElectricEnergyTractionStandstill"></see>
    /// </summary>
    let ``shapes/PermissionChargingElectricEnergyTractionStandstill`` =
        Namespaced_IRI.parse _namespace_name "shapes/PermissionChargingElectricEnergyTractionStandstill" |> NamespacedName

    /// <summary>
    /// Sections where is permitted to use the reflective plates on rail freight corridors, with a view to prioritise the current bottlenecks. Specific case for Belgium, France, Italy, Portugal and Spain until 1.1.2026
    /// <see href="http://data.europa.eu/949/permitUseReflectivePlates"></see></summary>
    let permitUseReflectivePlates =
        Namespaced_IRI.parse _namespace_name "permitUseReflectivePlates" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PermitUseReflectivePlates"></see>
    /// </summary>
    let ``shapes/PermitUseReflectivePlates`` =
        Namespaced_IRI.parse _namespace_name "shapes/PermitUseReflectivePlates" |> NamespacedName

    /// <summary>
    /// Indication of contact force allowed expressed in newton.
    /// <see href="http://data.europa.eu/949/permittedContactForce"></see></summary>
    let permittedContactForce =
        Namespaced_IRI.parse _namespace_name "permittedContactForce" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PermittedContactForce"></see>
    /// </summary>
    let ``shapes/PermittedContactForce`` =
        Namespaced_IRI.parse _namespace_name "shapes/PermittedContactForce" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PermittedContactForceApplicability"></see>
    /// </summary>
    let ``shapes/PermittedContactForceApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/PermittedContactForceApplicability" |> NamespacedName

    /// <summary>
    /// Part of the phase info of a track that shows whether the breaker has to be switched off.
    /// <see href="http://data.europa.eu/949/phaseInfoSwitchOffBreaker"></see></summary>
    let phaseInfoSwitchOffBreaker =
        Namespaced_IRI.parse _namespace_name "phaseInfoSwitchOffBreaker" |> NamespacedName

    /// <summary>
    /// Relates the Track with PhaseInfo. Indication of required several information on phase separation.
    /// <see href="http://data.europa.eu/949/trackPhaseInfo"></see></summary>
    let trackPhaseInfo =
        Namespaced_IRI.parse _namespace_name "trackPhaseInfo" |> NamespacedName

    /// <summary>
    /// Part of the phase info of a track that corresponds to the length of the phase separation in metres.
    /// <see href="http://data.europa.eu/949/phaseInfoLength"></see></summary>
    let phaseInfoLength =
        Namespaced_IRI.parse _namespace_name "phaseInfoLength" |> NamespacedName

    /// <summary>
    /// Part of the phase info of a track that indicates the location from the start of the line where the new value is valid.
    /// <see href="http://data.europa.eu/949/phaseInfoKm"></see></summary>
    let phaseInfoKm =
        Namespaced_IRI.parse _namespace_name "phaseInfoKm" |> NamespacedName

    /// <summary>
    /// Part of the phase info of a track that shows whether a pantograph has to be lowered.
    /// <see href="http://data.europa.eu/949/phaseInfoPantographLowered"></see></summary>
    let phaseInfoPantographLowered =
        Namespaced_IRI.parse _namespace_name "phaseInfoPantographLowered" |> NamespacedName

    /// <summary>
    /// Part of the phase info of a track that corresponds to the single selection of Y=yes or N=no to show if the energy supply system changes
    /// <see href="http://data.europa.eu/949/phaseInfoChangeSupplySystem"></see></summary>
    let phaseInfoChangeSupplySystem =
        Namespaced_IRI.parse _namespace_name "phaseInfoChangeSupplySystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoChangeSupplySystem"></see>
    /// </summary>
    let ``shapes/PhaseInfoChangeSupplySystem`` =
        Namespaced_IRI.parse _namespace_name "shapes/PhaseInfoChangeSupplySystem" |> NamespacedName

    /// <summary>
    /// Part of the phase info of a track that corresponds to the single selection of 'MIN=minimum' or 'MAX=maximum' to show whether the length is a minimum distance between the inner contact strips of the pantographs or a maximum distance between the outer contact strips of the pantographs. Multiple strings for this parameter are accepted.
    /// <see href="http://data.europa.eu/949/phaseInfoDistanceType"></see></summary>
    let phaseInfoDistanceType =
        Namespaced_IRI.parse _namespace_name "phaseInfoDistanceType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoDistanceType"></see>
    /// </summary>
    let ``shapes/PhaseInfoDistanceType`` =
        Namespaced_IRI.parse _namespace_name "shapes/PhaseInfoDistanceType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoKm"></see>
    /// </summary>
    let ``shapes/PhaseInfoKm`` =
        Namespaced_IRI.parse _namespace_name "shapes/PhaseInfoKm" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoLength"></see>
    /// </summary>
    let ``shapes/PhaseInfoLength`` =
        Namespaced_IRI.parse _namespace_name "shapes/PhaseInfoLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoPantographLowered"></see>
    /// </summary>
    let ``shapes/PhaseInfoPantographLowered`` =
        Namespaced_IRI.parse _namespace_name "shapes/PhaseInfoPantographLowered" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PhaseInfoSwitchOffBreaker"></see>
    /// </summary>
    let ``shapes/PhaseInfoSwitchOffBreaker`` =
        Namespaced_IRI.parse _namespace_name "shapes/PhaseInfoSwitchOffBreaker" |> NamespacedName

    /// <summary>
    /// Reference to a related platform edge.
    /// <see href="http://data.europa.eu/949/platformEdge"></see></summary>
    let platformEdge =
        Namespaced_IRI.parse _namespace_name "platformEdge" |> NamespacedName

    /// <summary>
    /// Distance between the upper surface of platform and running surface of the neighbouring track. It is the nominal value expressed in millimetres.
    /// <see href="http://data.europa.eu/949/platformHeight"></see></summary>
    let platformHeight =
        Namespaced_IRI.parse _namespace_name "platformHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/platform-heights/PlatformHeights"></see>
    /// </summary>
    let ``concepts/platform-heights/PlatformHeights`` =
        Namespaced_IRI.parse _namespace_name "concepts/platform-heights/PlatformHeights" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PlatformHeightP"></see>
    /// </summary>
    let ``shapes/PlatformHeightP`` =
        Namespaced_IRI.parse _namespace_name "shapes/PlatformHeightP" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PlatformHeightSKOS"></see>
    /// </summary>
    let ``shapes/PlatformHeightSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/PlatformHeightSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/platformObjParameter"></see>
    /// </summary>
    let platformObjParameter =
        Namespaced_IRI.parse _namespace_name "platformObjParameter" |> NamespacedName

    /// <summary>
    /// Unique platform identification or unique platform number within an Operational Point.
    /// <see href="http://data.europa.eu/949/platformId"></see></summary>
    let platformId = Namespaced_IRI.parse _namespace_name "platformId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PlatformId"></see>
    /// </summary>
    let ``shapes/PlatformId`` =
        Namespaced_IRI.parse _namespace_name "shapes/PlatformId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NoRepeatedPlatformIdsOP"></see>
    /// </summary>
    let ``shapes/NoRepeatedPlatformIdsOP`` =
        Namespaced_IRI.parse _namespace_name "shapes/NoRepeatedPlatformIdsOP" |> NamespacedName

    /// <summary>
    /// Description of any portable boarding aids if considered in the design of the vehicle for meeting the PRM TSI requirements.
    /// <see href="http://data.europa.eu/949/portableBoardingAids"></see></summary>
    let portableBoardingAids =
        Namespaced_IRI.parse _namespace_name "portableBoardingAids" |> NamespacedName

    /// <summary>
    /// Determines the position of the topological object A in a relation.
    /// <see href="http://data.europa.eu/949/positionOnA"></see></summary>
    let positionOnA =
        Namespaced_IRI.parse _namespace_name "positionOnA" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/relation-positions/RelationPositions"></see>
    /// </summary>
    let ``concepts/relation-positions/RelationPositions`` =
        Namespaced_IRI.parse _namespace_name "concepts/relation-positions/RelationPositions" |> NamespacedName

    /// <summary>
    /// Determines the position of the topological object B in a relation.
    /// <see href="http://data.europa.eu/949/positionOnB"></see></summary>
    let positionOnB =
        Namespaced_IRI.parse _namespace_name "positionOnB" |> NamespacedName

    /// <summary>
    /// Possibility of preventing the use of the regenerative brake (only if fitted with regenerative brake).
    /// <see href="http://data.europa.eu/949/preventRegenerativeBrakeUse"></see></summary>
    let preventRegenerativeBrakeUse =
        Namespaced_IRI.parse _namespace_name "preventRegenerativeBrakeUse" |> NamespacedName

    /// <summary>
    /// Denotes a the previous VehicleType.
    /// <see href="http://data.europa.eu/949/previousVehicleType"></see></summary>
    let previousVehicleType =
        Namespaced_IRI.parse _namespace_name "previousVehicleType" |> NamespacedName

    /// <summary>
    /// Primary location code developed for information exchange in accordance with the TSIs relating to the telematics applications subsystem.
    /// <see href="http://data.europa.eu/949/primaryLocation"></see></summary>
    let primaryLocation =
        Namespaced_IRI.parse _namespace_name "primaryLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PrimaryLocation"></see>
    /// </summary>
    let ``shapes/PrimaryLocation`` =
        Namespaced_IRI.parse _namespace_name "shapes/PrimaryLocation" |> NamespacedName

    /// <summary>
    /// Not used anymore. It has been replaced by era:primaryLocationCode.
    /// Primary location code developed for information exchange in accordance with the TSIs relating to the telematics applications subsystem
    /// <see href="http://data.europa.eu/949/tafTAPCode"></see></summary>
    let tafTAPCode = Namespaced_IRI.parse _namespace_name "tafTAPCode" |> NamespacedName

    /// <summary>
    /// Primary location code developed for information exchange in accordance with the TSIs relating to the telematics applications subsystem.
    /// <see href="http://data.europa.eu/949/primaryLocationCode"></see></summary>
    let primaryLocationCode =
        Namespaced_IRI.parse _namespace_name "primaryLocationCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PrimaryLocationCode"></see>
    /// </summary>
    let ``shapes/PrimaryLocationCode`` =
        Namespaced_IRI.parse _namespace_name "shapes/PrimaryLocationCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/primaryLocationName"></see>
    /// </summary>
    let primaryLocationName =
        Namespaced_IRI.parse _namespace_name "primaryLocationName" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PrimaryLocationName"></see>
    /// </summary>
    let ``shapes/PrimaryLocationName`` =
        Namespaced_IRI.parse _namespace_name "shapes/PrimaryLocationName" |> NamespacedName

    /// <summary>
    /// Number of priority seats.
    /// <see href="http://data.europa.eu/949/prioritySeats"></see></summary>
    let prioritySeats =
        Namespaced_IRI.parse _namespace_name "prioritySeats" |> NamespacedName

    /// <summary>
    /// Number of PRM accessible toilets.
    /// <see href="http://data.europa.eu/949/prmAccessibleToilets"></see></summary>
    let prmAccessibleToilets =
        Namespaced_IRI.parse _namespace_name "prmAccessibleToilets" |> NamespacedName

    /// <summary>
    /// Coding for combined transport for semi-trailers (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B].
    /// <see href="http://data.europa.eu/949/profileNumberSemiTrailers"></see></summary>
    let profileNumberSemiTrailers =
        Namespaced_IRI.parse _namespace_name "profileNumberSemiTrailers" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/profile-num-semi-trailers/ProfileNumbersSemiTrailers"></see>
    /// </summary>
    let ``concepts/profile-num-semi-trailers/ProfileNumbersSemiTrailers`` =
        Namespaced_IRI.parse _namespace_name "concepts/profile-num-semi-trailers/ProfileNumbersSemiTrailers" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ProfileNumberSemiTrailersSKOS"></see>
    /// </summary>
    let ``shapes/ProfileNumberSemiTrailersSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/ProfileNumberSemiTrailersSKOS" |> NamespacedName

    /// <summary>
    /// Coding for combined transport with swap bodies (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B]
    /// <see href="http://data.europa.eu/949/profileNumberSwapBodies"></see></summary>
    let profileNumberSwapBodies =
        Namespaced_IRI.parse _namespace_name "profileNumberSwapBodies" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/profile-num-swap-bodies/ProfileNumbersSwapBodies"></see>
    /// </summary>
    let ``concepts/profile-num-swap-bodies/ProfileNumbersSwapBodies`` =
        Namespaced_IRI.parse _namespace_name "concepts/profile-num-swap-bodies/ProfileNumbersSwapBodies" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ProfileNumberSwapBodiesSKOS"></see>
    /// </summary>
    let ``shapes/ProfileNumberSwapBodiesSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/ProfileNumberSwapBodiesSKOS" |> NamespacedName

    /// <summary>
    /// Indication of which class B system is installed.
    /// <see href="http://data.europa.eu/949/protectionLegacySystem"></see></summary>
    let protectionLegacySystem =
        Namespaced_IRI.parse _namespace_name "protectionLegacySystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ProtectionLegacySystemSKOS"></see>
    /// </summary>
    let ``shapes/ProtectionLegacySystemSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/ProtectionLegacySystemSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/trainProtectionLegacySystemObjParameter"></see>
    /// </summary>
    let trainProtectionLegacySystemObjParameter =
        Namespaced_IRI.parse _namespace_name "trainProtectionLegacySystemObjParameter" |> NamespacedName

    /// <summary>
    /// Existence of roaming to a public network.
    ///
    ///                          In case of Y, provide the name of the public network(s) under parameter "Details on GSM-R roaming to public networks".
    /// <see href="http://data.europa.eu/949/publicNetworkRoaming"></see></summary>
    let publicNetworkRoaming =
        Namespaced_IRI.parse _namespace_name "publicNetworkRoaming" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PublicNetworkRoamingApplicability"></see>
    /// </summary>
    let ``shapes/PublicNetworkRoamingApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/PublicNetworkRoamingApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PublicNetworkRoaming"></see>
    /// </summary>
    let ``shapes/PublicNetworkRoaming`` =
        Namespaced_IRI.parse _namespace_name "shapes/PublicNetworkRoaming" |> NamespacedName

    /// <summary>
    /// If roaming to public networks is configured, please indicate to which networks, for which users and in which areas.
    /// <see href="http://data.europa.eu/949/publicNetworkRoamingDetails"></see></summary>
    let publicNetworkRoamingDetails =
        Namespaced_IRI.parse _namespace_name "publicNetworkRoamingDetails" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PublicNetworkRoamingDetailsApplicability"></see>
    /// </summary>
    let ``shapes/PublicNetworkRoamingDetailsApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/PublicNetworkRoamingDetailsApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/PublicNetworkRoamingDetails"></see>
    /// </summary>
    let ``shapes/PublicNetworkRoamingDetails`` =
        Namespaced_IRI.parse _namespace_name "shapes/PublicNetworkRoamingDetails" |> NamespacedName

    /// <summary>
    /// Qualifier determining whether the driver is allowed to modify the adhesion factor used by the ETCS on-board to calculate the braking curves.
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/qNvdriverAdhes"></see></summary>
    let qNvdriverAdhes =
        Namespaced_IRI.parse _namespace_name "qNvdriverAdhes" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/adhf-qualifier/AdhesionFactorChange"></see>
    /// </summary>
    let ``concepts/adhf-qualifier/AdhesionFactorChange`` =
        Namespaced_IRI.parse _namespace_name "concepts/adhf-qualifier/AdhesionFactorChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvdriverAdhes"></see>
    /// </summary>
    let ``shapes/QNvdriverAdhes`` =
        Namespaced_IRI.parse _namespace_name "shapes/QNvdriverAdhes" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvdriverAdhesSKOS"></see>
    /// </summary>
    let ``shapes/QNvdriverAdhesSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/QNvdriverAdhesSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvdriverAdhesApplicability"></see>
    /// </summary>
    let ``shapes/QNvdriverAdhesApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/QNvdriverAdhesApplicability" |> NamespacedName

    /// <summary>
    /// Qualifier defining whether the application of the emergency brake for reasons other than a trip can be revoked as soon as the conditions for it have disappeared or after the train has come to a complete standstill.
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/qNvemrrls"></see></summary>
    let qNvemrrls = Namespaced_IRI.parse _namespace_name "qNvemrrls" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ebr-qualifier/EBReleaseQualifier"></see>
    /// </summary>
    let ``concepts/ebr-qualifier/EBReleaseQualifier`` =
        Namespaced_IRI.parse _namespace_name "concepts/ebr-qualifier/EBReleaseQualifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvemrrls"></see>
    /// </summary>
    let ``shapes/QNvemrrls`` =
        Namespaced_IRI.parse _namespace_name "shapes/QNvemrrls" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvemrrlsSKOS"></see>
    /// </summary>
    let ``shapes/QNvemrrlsSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/QNvemrrlsSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvemrrlsApplicability"></see>
    /// </summary>
    let ``shapes/QNvemrrlsApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/QNvemrrlsApplicability" |> NamespacedName

    /// <summary>
    /// Permission to use service brake in target speed monitoring
    /// <see href="http://data.europa.eu/949/qNvsbtsmperm"></see></summary>
    let qNvsbtsmperm =
        Namespaced_IRI.parse _namespace_name "qNvsbtsmperm" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvsbtsmperm"></see>
    /// </summary>
    let ``shapes/QNvsbtsmperm`` =
        Namespaced_IRI.parse _namespace_name "shapes/QNvsbtsmperm" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/QNvsbtsmpermApplicability"></see>
    /// </summary>
    let ``shapes/QNvsbtsmpermApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/QNvsbtsmpermApplicability" |> NamespacedName

    /// <summary>
    /// Quasi-static guiding force (if exceeds the limit defined in TSI or not defined in the TSI), given in kN.
    /// <see href="http://data.europa.eu/949/quasiStaticGuidingForce"></see></summary>
    let quasiStaticGuidingForce =
        Namespaced_IRI.parse _namespace_name "quasiStaticGuidingForce" |> NamespacedName

    /// <summary>
    /// Country where a vehicle may operate without noise restrictions.
    /// <see href="http://data.europa.eu/949/quieterRoutesExemptedCountry"></see></summary>
    let quieterRoutesExemptedCountry =
        Namespaced_IRI.parse _namespace_name "quieterRoutesExemptedCountry" |> NamespacedName

    /// <summary>
    /// Unique identification of the GSM-R network the calling mobile station has to register with, as defined in the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/radioNetworkId"></see></summary>
    let radioNetworkId =
        Namespaced_IRI.parse _namespace_name "radioNetworkId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RadioNetworkId"></see>
    /// </summary>
    let ``shapes/RadioNetworkId`` =
        Namespaced_IRI.parse _namespace_name "shapes/RadioNetworkId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RadioNetworkIdApplicability"></see>
    /// </summary>
    let ``shapes/RadioNetworkIdApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/RadioNetworkIdApplicability" |> NamespacedName

    /// <summary>
    /// Special conditions implemented on-board to switch over between different radio systems. Given as combination of systems installed on board ('System XX'_'System YY').
    /// <see href="http://data.europa.eu/949/radioSwitchOverSpecialConditions"></see></summary>
    let radioSwitchOverSpecialConditions =
        Namespaced_IRI.parse _namespace_name "radioSwitchOverSpecialConditions" |> NamespacedName

    /// <summary>
    /// An angle defining the inclination of the head of a rail relative to the running surface.
    /// <see href="http://data.europa.eu/949/railInclination"></see></summary>
    let railInclination =
        Namespaced_IRI.parse _namespace_name "railInclination" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/rail-inclinations/RailInclinations"></see>
    /// </summary>
    let ``concepts/rail-inclinations/RailInclinations`` =
        Namespaced_IRI.parse _namespace_name "concepts/rail-inclinations/RailInclinations" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RailInclination"></see>
    /// </summary>
    let ``shapes/RailInclination`` =
        Namespaced_IRI.parse _namespace_name "shapes/RailInclination" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RailInclinationSKOS"></see>
    /// </summary>
    let ``shapes/RailInclinationSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/RailInclinationSKOS" |> NamespacedName

    /// <summary>
    /// (deprecated) Type of railway system. Can be "High-speed" or "Conventional". Deprecated due to the lack of information
    /// <see href="http://data.europa.eu/949/railSystemType"></see></summary>
    let railSystemType =
        Namespaced_IRI.parse _namespace_name "railSystemType" |> NamespacedName

    /// <summary>
    /// Part of the raised pantographs distance and speed of a track that corresponds to the minimum distance between pantographs, in metres.
    /// <see href="http://data.europa.eu/949/raisedPantographsDistance"></see></summary>
    let raisedPantographsDistance =
        Namespaced_IRI.parse _namespace_name "raisedPantographsDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RaisedPantographsDistance"></see>
    /// </summary>
    let ``shapes/RaisedPantographsDistance`` =
        Namespaced_IRI.parse _namespace_name "shapes/RaisedPantographsDistance" |> NamespacedName

    /// <summary>
    /// Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.
    /// <see href="http://data.europa.eu/949/raisedPantographsDistanceAndSpeed"></see></summary>
    let raisedPantographsDistanceAndSpeed =
        Namespaced_IRI.parse _namespace_name "raisedPantographsDistanceAndSpeed" |> NamespacedName

    /// <summary>
    /// Part of the raised pantographs distance and speed of a track that corresponds to the number of pantographs.
    /// <see href="http://data.europa.eu/949/raisedPantographsNumber"></see></summary>
    let raisedPantographsNumber =
        Namespaced_IRI.parse _namespace_name "raisedPantographsNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RaisedPantographsNumber"></see>
    /// </summary>
    let ``shapes/RaisedPantographsNumber`` =
        Namespaced_IRI.parse _namespace_name "shapes/RaisedPantographsNumber" |> NamespacedName

    /// <summary>
    /// Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.
    /// <see href="http://data.europa.eu/949/raisedPantographsSpeed"></see></summary>
    let raisedPantographsSpeed =
        Namespaced_IRI.parse _namespace_name "raisedPantographsSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RaisedPantographsSpeed"></see>
    /// </summary>
    let ``shapes/RaisedPantographsSpeed`` =
        Namespaced_IRI.parse _namespace_name "shapes/RaisedPantographsSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RbcID"></see>
    /// </summary>
    let ``shapes/RbcID`` =
        Namespaced_IRI.parse _namespace_name "shapes/RbcID" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RbcPhone"></see>
    /// </summary>
    let ``shapes/RbcPhone`` =
        Namespaced_IRI.parse _namespace_name "shapes/RbcPhone" |> NamespacedName

    /// <summary>
    /// List of cases subject to system design choices made by the infrastructure manager according to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/reasonsEtcsRadioBlockCenterReject"></see></summary>
    let reasonsEtcsRadioBlockCenterReject =
        Namespaced_IRI.parse _namespace_name "reasonsEtcsRadioBlockCenterReject" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/etcs-rbc-reject-reasons/ETCSRBCRejectionReasons"></see>
    /// </summary>
    let ``concepts/etcs-rbc-reject-reasons/ETCSRBCRejectionReasons`` =
        Namespaced_IRI.parse _namespace_name "concepts/etcs-rbc-reject-reasons/ETCSRBCRejectionReasons" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ReasonsEtcsRadioBlockCenterRejectSKOS"></see>
    /// </summary>
    let ``shapes/ReasonsEtcsRadioBlockCenterRejectSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/ReasonsEtcsRadioBlockCenterRejectSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ReasonsEtcsRadioBlockCenterReject"></see>
    /// </summary>
    let ``shapes/ReasonsEtcsRadioBlockCenterReject`` =
        Namespaced_IRI.parse _namespace_name "shapes/ReasonsEtcsRadioBlockCenterReject" |> NamespacedName

    /// <summary>
    /// Sections where two steady red lights are required in accordance with TSI OPE
    /// Sections where permissive driving is possible in accordance with point 4.2.2.1.2 of TSI OPE
    /// <see href="http://data.europa.eu/949/redLightsRequired"></see></summary>
    let redLightsRequired =
        Namespaced_IRI.parse _namespace_name "redLightsRequired" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RedLightsRequired"></see>
    /// </summary>
    let ``shapes/RedLightsRequired`` =
        Namespaced_IRI.parse _namespace_name "shapes/RedLightsRequired" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RedLightsRequiredCountryApplicability"></see>
    /// </summary>
    let ``shapes/RedLightsRequiredCountryApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/RedLightsRequiredCountryApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/ReferenceBorderPoint"></see>
    /// </summary>
    let ``shapes/ReferenceBorderPoint`` =
        Namespaced_IRI.parse _namespace_name "shapes/ReferenceBorderPoint" |> NamespacedName

    /// <summary>
    /// Pass-by noise level was measured under reference conditions.
    /// <see href="http://data.europa.eu/949/referencePassByNoiseLevel"></see></summary>
    let referencePassByNoiseLevel =
        Namespaced_IRI.parse _namespace_name "referencePassByNoiseLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/relatedElectromagneticInterferencesDataParameter"></see>
    /// </summary>
    let relatedElectromagneticInterferencesDataParameter =
        Namespaced_IRI.parse _namespace_name "relatedElectromagneticInterferencesDataParameter" |> NamespacedName

    /// <summary>
    /// Distance in meters to the danger point
    /// <see href="http://data.europa.eu/949/relativeDistanceDangerPoint"></see></summary>
    let relativeDistanceDangerPoint =
        Namespaced_IRI.parse _namespace_name "relativeDistanceDangerPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RelativeDistanceDangerPoint"></see>
    /// </summary>
    let ``shapes/RelativeDistanceDangerPoint`` =
        Namespaced_IRI.parse _namespace_name "shapes/RelativeDistanceDangerPoint" |> NamespacedName

    /// <summary>
    /// Indicates the position of an object relative to the linear coordinates of the associated topological object.
    /// <see href="http://data.europa.eu/949/relativePosition"></see></summary>
    let relativePosition =
        Namespaced_IRI.parse _namespace_name "relativePosition" |> NamespacedName

    /// <summary>
    /// Indication whether possibility to activate/deactivate sanding devices by driver, according to instructions from the Infrastructure Manager, is required or not. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/requiredSandingOverride"></see></summary>
    let requiredSandingOverride =
        Namespaced_IRI.parse _namespace_name "requiredSandingOverride" |> NamespacedName

    /// <summary>
    /// Indicates the relationship of a Body to the organisation roles that it can play.
    /// <see href="http://data.europa.eu/949/role"></see></summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Role"></see>
    /// </summary>
    let ``shapes/Role`` =
        Namespaced_IRI.parse _namespace_name "shapes/Role" |> NamespacedName

    /// <summary>
    /// Indicates the corresponding Body that plays a certain organisation role.
    /// <see href="http://data.europa.eu/949/roleOf"></see></summary>
    let roleOf = Namespaced_IRI.parse _namespace_name "roleOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RoleOf"></see>
    /// </summary>
    let ``shapes/RoleOf`` =
        Namespaced_IRI.parse _namespace_name "shapes/RoleOf" |> NamespacedName

    /// <summary>
    /// Categorisation how a passenger train with a fire on board will continue to operate for a defined time period
    /// Passenger train fire category in accordance with point 4.1.4 of TSI LOC&amp;PAS.
    /// <see href="http://data.europa.eu/949/rollingStockFireCategory"></see></summary>
    let rollingStockFireCategory =
        Namespaced_IRI.parse _namespace_name "rollingStockFireCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RollingStockFireCategorySKOS"></see>
    /// </summary>
    let ``shapes/RollingStockFireCategorySKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/RollingStockFireCategorySKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RollingStockFireCategoryApplicability"></see>
    /// </summary>
    let ``shapes/RollingStockFireCategoryApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/RollingStockFireCategoryApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/RollingStockFireCategory"></see>
    /// </summary>
    let ``shapes/RollingStockFireCategory`` =
        Namespaced_IRI.parse _namespace_name "shapes/RollingStockFireCategory" |> NamespacedName

    /// <summary>
    /// Indication whether safe consist train length information from on-board is required to access the line for safety reasons and the required safety integrity level.
    /// <see href="http://data.europa.eu/949/safeConsistLengthInformationNecessary"></see></summary>
    let safeConsistLengthInformationNecessary =
        Namespaced_IRI.parse _namespace_name "safeConsistLengthInformationNecessary" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/safe-consist-length/SafeConsistLengthNecessary"></see>
    /// </summary>
    let ``concepts/safe-consist-length/SafeConsistLengthNecessary`` =
        Namespaced_IRI.parse _namespace_name "concepts/safe-consist-length/SafeConsistLengthNecessary" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SafeConsistLengthInformationNecessarySKOS"></see>
    /// </summary>
    let ``shapes/SafeConsistLengthInformationNecessarySKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/SafeConsistLengthInformationNecessarySKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SafeConsistLengthInformationNecessary"></see>
    /// </summary>
    let ``shapes/SafeConsistLengthInformationNecessary`` =
        Namespaced_IRI.parse _namespace_name "shapes/SafeConsistLengthInformationNecessary" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SafeConsistLengthInformationNecessaryApplicability"></see>
    /// </summary>
    let ``shapes/SafeConsistLengthInformationNecessaryApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/SafeConsistLengthInformationNecessaryApplicability" |> NamespacedName

    /// <summary>
    /// Document providing the schematic overview of the operational point
    /// <see href="http://data.europa.eu/949/schematicOverviewOP"></see></summary>
    let schematicOverviewOP =
        Namespaced_IRI.parse _namespace_name "schematicOverviewOP" |> NamespacedName

    /// <summary>
    /// Annotation property used in SHACL shapes. Indicates if the SHACL shape is validating a property of a specific instance ("local"), or if it needs to check other instances ("global"). For example, SHACL shape to validate no repeated ids within a specific track.
    /// <see href="http://data.europa.eu/949/scope"></see></summary>
    let scope = Namespaced_IRI.parse _namespace_name "scope" |> NamespacedName

    /// <summary>
    /// Shortest distance between two pantographs in contact with the OCL (to be indicated for each energy supply system the vehicle is equipped for; to be indicated for single and, if applicable, multiple operation) (only if number of raised pantographs is more than 1).
    /// <see href="http://data.europa.eu/949/shortestDistanceBetweenPantographsInContactWithOCL"></see></summary>
    let shortestDistanceBetweenPantographsInContactWithOCL =
        Namespaced_IRI.parse _namespace_name "shortestDistanceBetweenPantographsInContactWithOCL" |> NamespacedName

    /// <summary>
    /// Indication of the position of the signal in relation to the track in the running direction from the origin of the referencing system (e.g., direction of the main line)
    /// <see href="http://data.europa.eu/949/side"></see></summary>
    let side = Namespaced_IRI.parse _namespace_name "side" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/orientations/Sides"></see>
    /// </summary>
    let ``concepts/orientations/Sides`` =
        Namespaced_IRI.parse _namespace_name "concepts/orientations/Sides" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Side"></see>
    /// </summary>
    let ``shapes/Side`` =
        Namespaced_IRI.parse _namespace_name "shapes/Side" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SideSKOS"></see>
    /// </summary>
    let ``shapes/SideSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/SideSKOS" |> NamespacedName

    /// <summary>
    /// Unique siding identification or number within an Operational Point.
    /// <see href="http://data.europa.eu/949/sidingId"></see></summary>
    let sidingId = Namespaced_IRI.parse _namespace_name "sidingId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SidingId"></see>
    /// </summary>
    let ``shapes/SidingId`` =
        Namespaced_IRI.parse _namespace_name "shapes/SidingId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NoRepeatedSidingIds"></see>
    /// </summary>
    let ``shapes/NoRepeatedSidingIds`` =
        Namespaced_IRI.parse _namespace_name "shapes/NoRepeatedSidingIds" |> NamespacedName

    /// <summary>
    /// Identifier of signal.
    /// <see href="http://data.europa.eu/949/signalId"></see></summary>
    let signalId = Namespaced_IRI.parse _namespace_name "signalId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SignalId"></see>
    /// </summary>
    let ``shapes/SignalId`` =
        Namespaced_IRI.parse _namespace_name "shapes/SignalId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/signalObjParameter"></see>
    /// </summary>
    let signalObjParameter =
        Namespaced_IRI.parse _namespace_name "signalObjParameter" |> NamespacedName

    /// <summary>
    /// Relative position to the line of reference, given in km and indication if the signal refers to normal or opposite track direction
    /// <see href="http://data.europa.eu/949/signalOrientation"></see></summary>
    let signalOrientation =
        Namespaced_IRI.parse _namespace_name "signalOrientation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SignalOrientationSKOS"></see>
    /// </summary>
    let ``shapes/SignalOrientationSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/SignalOrientationSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SignalOrientation"></see>
    /// </summary>
    let ``shapes/SignalOrientation`` =
        Namespaced_IRI.parse _namespace_name "shapes/SignalOrientation" |> NamespacedName

    /// <summary>
    /// Signalling information for Route Book compilation. This list shall include fixed signals that protect danger points
    /// <see href="http://data.europa.eu/949/signalType"></see></summary>
    let signalType = Namespaced_IRI.parse _namespace_name "signalType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/signal-types/SignalTypes"></see>
    /// </summary>
    let ``concepts/signal-types/SignalTypes`` =
        Namespaced_IRI.parse _namespace_name "concepts/signal-types/SignalTypes" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SignalTypeSKOS"></see>
    /// </summary>
    let ``shapes/SignalTypeSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/SignalTypeSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SignalType"></see>
    /// </summary>
    let ``shapes/SignalType`` =
        Namespaced_IRI.parse _namespace_name "shapes/SignalType" |> NamespacedName

    /// <summary>
    /// Number of sleeping places.
    /// <see href="http://data.europa.eu/949/sleepingPlaces"></see></summary>
    let sleepingPlaces =
        Namespaced_IRI.parse _namespace_name "sleepingPlaces" |> NamespacedName

    /// <summary>
    /// Snow, ice and hail conditions.
    /// <see href="http://data.europa.eu/949/snowIceHailConditions"></see></summary>
    let snowIceHailConditions =
        Namespaced_IRI.parse _namespace_name "snowIceHailConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ice-conditions/IceConditions"></see>
    /// </summary>
    let ``concepts/ice-conditions/IceConditions`` =
        Namespaced_IRI.parse _namespace_name "concepts/ice-conditions/IceConditions" |> NamespacedName

    /// <summary>
    /// Kind of section of line expressing size of presented data which depends on fact whether it connects OPs generated by division of a big node into several OPs or not.
    /// <see href="http://data.europa.eu/949/solNature"></see></summary>
    let solNature = Namespaced_IRI.parse _namespace_name "solNature" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/sol-natures/SoLNatures"></see>
    /// </summary>
    let ``concepts/sol-natures/SoLNatures`` =
        Namespaced_IRI.parse _namespace_name "concepts/sol-natures/SoLNatures" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SolNatureApplicability"></see>
    /// </summary>
    let ``shapes/SolNatureApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/SolNatureApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SolNature"></see>
    /// </summary>
    let ``shapes/SolNature`` =
        Namespaced_IRI.parse _namespace_name "shapes/SolNature" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SolNatureSKOS"></see>
    /// </summary>
    let ``shapes/SolNatureSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/SolNatureSKOS" |> NamespacedName

    /// <summary>
    /// Indicates the special area or location types such as safe areas and restricted area types.
    /// <see href="http://data.europa.eu/949/specialAreaType"></see></summary>
    let specialAreaType =
        Namespaced_IRI.parse _namespace_name "specialAreaType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/special-area-types/SpecialAreaTypes"></see>
    /// </summary>
    let ``concepts/special-area-types/SpecialAreaTypes`` =
        Namespaced_IRI.parse _namespace_name "concepts/special-area-types/SpecialAreaTypes" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SpecialAreaType"></see>
    /// </summary>
    let ``shapes/SpecialAreaType`` =
        Namespaced_IRI.parse _namespace_name "shapes/SpecialAreaType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SpecialAreaTypeSKOS"></see>
    /// </summary>
    let ``shapes/SpecialAreaTypeSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/SpecialAreaTypeSKOS" |> NamespacedName

    /// <summary>
    /// Relates a tunnel with a special area or location.
    /// <see href="http://data.europa.eu/949/specialTunnelArea"></see></summary>
    let specialTunnelArea =
        Namespaced_IRI.parse _namespace_name "specialTunnelArea" |> NamespacedName

    /// <summary>
    /// Special type of service on a line or a section of a line.
    /// <see href="http://data.europa.eu/949/specializedInfrastructure"></see></summary>
    let specializedInfrastructure =
        Namespaced_IRI.parse _namespace_name "specializedInfrastructure" |> NamespacedName

    /// <summary>
    /// Any relevant information from the IM relating to the line layout
    /// <see href="http://data.europa.eu/949/specificInformation"></see></summary>
    let specificInformation =
        Namespaced_IRI.parse _namespace_name "specificInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SpecificInformation"></see>
    /// </summary>
    let ``shapes/SpecificInformation`` =
        Namespaced_IRI.parse _namespace_name "shapes/SpecificInformation" |> NamespacedName

    /// <summary>
    /// Coding for combined transport for containers (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B]
    /// <see href="http://data.europa.eu/949/standardCombinedTransportContainers"></see></summary>
    let standardCombinedTransportContainers =
        Namespaced_IRI.parse _namespace_name "standardCombinedTransportContainers" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/standard-combined-transport-containers/StandardCombinedTransportContainers"></see>
    /// </summary>
    let ``concepts/standard-combined-transport-containers/StandardCombinedTransportContainers`` =
        Namespaced_IRI.parse _namespace_name "concepts/standard-combined-transport-containers/StandardCombinedTransportContainers" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StandardCombinedTransportContainers"></see>
    /// </summary>
    let ``shapes/StandardCombinedTransportContainers`` =
        Namespaced_IRI.parse _namespace_name "shapes/StandardCombinedTransportContainers" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StandardCombinedTransportContainersSKOS"></see>
    /// </summary>
    let ``shapes/StandardCombinedTransportContainersSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/StandardCombinedTransportContainersSKOS" |> NamespacedName

    /// <summary>
    /// Coding for combined transport for roller units (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B]
    /// <see href="http://data.europa.eu/949/standardCombinedTransportRollerUnits"></see></summary>
    let standardCombinedTransportRollerUnits =
        Namespaced_IRI.parse _namespace_name "standardCombinedTransportRollerUnits" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/standard-combined-transport-roller-units/StandardCombinedTransportRollerUnits"></see>
    /// </summary>
    let ``concepts/standard-combined-transport-roller-units/StandardCombinedTransportRollerUnits`` =
        Namespaced_IRI.parse _namespace_name "concepts/standard-combined-transport-roller-units/StandardCombinedTransportRollerUnits" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StandardCombinedRollerUnitsSKOS"></see>
    /// </summary>
    let ``shapes/StandardCombinedRollerUnitsSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/StandardCombinedRollerUnitsSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StandardCombinedRollerUnits"></see>
    /// </summary>
    let ``shapes/StandardCombinedRollerUnits`` =
        Namespaced_IRI.parse _namespace_name "shapes/StandardCombinedRollerUnits" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/startIntrinsicCoordinate"></see>
    /// </summary>
    let startIntrinsicCoordinate =
        Namespaced_IRI.parse _namespace_name "startIntrinsicCoordinate" |> NamespacedName

    /// <summary>
    /// Part of the Start of tunnel that indicates the Geographical coordinates according to the standard World Geodetic System (WGS). Precision for both geographical latitude and geographical longitude is assumed as [NN.NNNNNNN] in degrees with decimals what gives discretion of 10 cm in the network.
    /// The Start of tunnel is the Geographical coordinates in decimal degrees and km of the line at the beginning of a tunnel.
    /// <see href="http://data.europa.eu/949/startLocation"></see></summary>
    let startLocation =
        Namespaced_IRI.parse _namespace_name "startLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StartLocation"></see>
    /// </summary>
    let ``shapes/StartLocation`` =
        Namespaced_IRI.parse _namespace_name "shapes/StartLocation" |> NamespacedName

    /// <summary>
    /// Start offset of the section from the origin.
    /// <see href="http://data.europa.eu/949/startOffsetFromOrigin"></see></summary>
    let startOffsetFromOrigin =
        Namespaced_IRI.parse _namespace_name "startOffsetFromOrigin" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StartOffsetFromOrigin"></see>
    /// </summary>
    let ``shapes/StartOffsetFromOrigin`` =
        Namespaced_IRI.parse _namespace_name "shapes/StartOffsetFromOrigin" |> NamespacedName

    /// <summary>
    /// starting noise level given in dB(A).
    /// <see href="http://data.europa.eu/949/startingNoiseLevel"></see></summary>
    let startingNoiseLevel =
        Namespaced_IRI.parse _namespace_name "startingNoiseLevel" |> NamespacedName

    /// <summary>
    /// Specifies the starting point of a linear reference.
    /// <see href="http://data.europa.eu/949/startsAt"></see></summary>
    let startsAt = Namespaced_IRI.parse _namespace_name "startsAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StartsAt"></see>
    /// </summary>
    let ``shapes/StartsAt`` =
        Namespaced_IRI.parse _namespace_name "shapes/StartsAt" |> NamespacedName

    /// <summary>
    /// Denoting the state of the certificate Can be in one of the following: Amended, New, Suspended, Withdrawn.
    /// <see href="http://data.europa.eu/949/state"></see></summary>
    let state = Namespaced_IRI.parse _namespace_name "state" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/states/States"></see>
    /// </summary>
    let ``concepts/states/States`` =
        Namespaced_IRI.parse _namespace_name "concepts/states/States" |> NamespacedName

    /// <summary>
    /// Static axle load under exceptional payload.
    /// <see href="http://data.europa.eu/949/staticAxleLoadExceptionalPayload"></see></summary>
    let staticAxleLoadExceptionalPayload =
        Namespaced_IRI.parse _namespace_name "staticAxleLoadExceptionalPayload" |> NamespacedName

    /// <summary>
    /// Static axle load under normal payload.
    /// <see href="http://data.europa.eu/949/staticAxleLoadNormalPayload"></see></summary>
    let staticAxleLoadNormalPayload =
        Namespaced_IRI.parse _namespace_name "staticAxleLoadNormalPayload" |> NamespacedName

    /// <summary>
    /// Static axle load in working order.
    /// <see href="http://data.europa.eu/949/staticAxleLoadWorkingOrder"></see></summary>
    let staticAxleLoadWorkingOrder =
        Namespaced_IRI.parse _namespace_name "staticAxleLoadWorkingOrder" |> NamespacedName

    /// <summary>
    /// stationary noise level given in dB(A).
    /// <see href="http://data.europa.eu/949/stationaryNoiseLevel"></see></summary>
    let stationaryNoiseLevel =
        Namespaced_IRI.parse _namespace_name "stationaryNoiseLevel" |> NamespacedName

    /// <summary>
    /// Structural category.
    /// <see href="http://data.europa.eu/949/structuralCategory"></see></summary>
    let structuralCategory =
        Namespaced_IRI.parse _namespace_name "structuralCategory" |> NamespacedName

    /// <summary>
    /// Localisation of structures requiring specific checks
    /// <see href="http://data.europa.eu/949/structureCheckLocation"></see></summary>
    let structureCheckLocation =
        Namespaced_IRI.parse _namespace_name "structureCheckLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/StructureCheckLocation"></see>
    /// </summary>
    let ``shapes/StructureCheckLocation`` =
        Namespaced_IRI.parse _namespace_name "shapes/StructureCheckLocation" |> NamespacedName

    /// <summary>
    /// (Deprecated) Vehicle subcategory.
    /// <see href="http://data.europa.eu/949/subCategory"></see></summary>
    let subCategory =
        Namespaced_IRI.parse _namespace_name "subCategory" |> NamespacedName

    /// <summary>
    /// Indicates the further classification (but not any family/platform) of vehicles within a vehicle category.
    /// <see href="http://data.europa.eu/949/vehicleSubCategory"></see></summary>
    let vehicleSubCategory =
        Namespaced_IRI.parse _namespace_name "vehicleSubCategory" |> NamespacedName

    /// <summary>
    /// A subset of elements with common characteristics could be identified with a unique name/id.
    /// <see href="http://data.europa.eu/949/subsetName"></see></summary>
    let subsetName = Namespaced_IRI.parse _namespace_name "subsetName" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsetName"></see>
    /// </summary>
    let ``shapes/SubsetName`` =
        Namespaced_IRI.parse _namespace_name "shapes/SubsetName" |> NamespacedName

    /// <summary>
    /// Relates a subset with common characteristics with another subset with common characteristics.
    /// <see href="http://data.europa.eu/949/subsetOf"></see></summary>
    let subsetOf = Namespaced_IRI.parse _namespace_name "subsetOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsetOf"></see>
    /// </summary>
    let ``shapes/SubsetOf`` =
        Namespaced_IRI.parse _namespace_name "shapes/SubsetOf" |> NamespacedName

    /// <summary>
    /// The numeric code for the subsidiary location
    /// <see href="http://data.europa.eu/949/subsidiaryLocationCode"></see></summary>
    let subsidiaryLocationCode =
        Namespaced_IRI.parse _namespace_name "subsidiaryLocationCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsidiaryLocationCode"></see>
    /// </summary>
    let ``shapes/SubsidiaryLocationCode`` =
        Namespaced_IRI.parse _namespace_name "shapes/SubsidiaryLocationCode" |> NamespacedName

    /// <summary>
    /// The common name given to the subsidiary location
    /// <see href="http://data.europa.eu/949/subsidiaryLocationName"></see></summary>
    let subsidiaryLocationName =
        Namespaced_IRI.parse _namespace_name "subsidiaryLocationName" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsidiaryLocationName"></see>
    /// </summary>
    let ``shapes/SubsidiaryLocationName`` =
        Namespaced_IRI.parse _namespace_name "shapes/SubsidiaryLocationName" |> NamespacedName

    /// <summary>
    /// Indicates the subsidiary location type that belongs to a taxonomy.
    /// <see href="http://data.europa.eu/949/subsidiaryLocationType"></see></summary>
    let subsidiaryLocationType =
        Namespaced_IRI.parse _namespace_name "subsidiaryLocationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/subsidiary-location-types/SubsidiaryLocationTypes"></see>
    /// </summary>
    let ``concepts/subsidiary-location-types/SubsidiaryLocationTypes`` =
        Namespaced_IRI.parse _namespace_name "concepts/subsidiary-location-types/SubsidiaryLocationTypes" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsidiaryLocationTypeSKOS"></see>
    /// </summary>
    let ``shapes/SubsidiaryLocationTypeSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/SubsidiaryLocationTypeSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SubsidiaryLocationType"></see>
    /// </summary>
    let ``shapes/SubsidiaryLocationType`` =
        Namespaced_IRI.parse _namespace_name "shapes/SubsidiaryLocationType" |> NamespacedName

    /// <summary>
    /// Platform height for which the vehicle is designed.
    /// <see href="http://data.europa.eu/949/supportedPlatformHeight"></see></summary>
    let supportedPlatformHeight =
        Namespaced_IRI.parse _namespace_name "supportedPlatformHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SwitchProtectControlWarningApplicability"></see>
    /// </summary>
    let ``shapes/SwitchProtectControlWarningApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/SwitchProtectControlWarningApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SwitchProtectControlWarning"></see>
    /// </summary>
    let ``shapes/SwitchProtectControlWarning`` =
        Namespaced_IRI.parse _namespace_name "shapes/SwitchProtectControlWarning" |> NamespacedName

    /// <summary>
    /// Indication whether a switch over between different radio systems and no communication system whilst running exists.
    /// <see href="http://data.europa.eu/949/switchRadioSystem"></see></summary>
    let switchRadioSystem =
        Namespaced_IRI.parse _namespace_name "switchRadioSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SwitchRadioSystemApplicability"></see>
    /// </summary>
    let ``shapes/SwitchRadioSystemApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/SwitchRadioSystemApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SwitchRadioSystem"></see>
    /// </summary>
    let ``shapes/SwitchRadioSystem`` =
        Namespaced_IRI.parse _namespace_name "shapes/SwitchRadioSystem" |> NamespacedName

    /// <summary>
    /// Indication of required several information on system separation
    /// <see href="http://data.europa.eu/949/trackSystemSeparationInfo"></see></summary>
    let trackSystemSeparationInfo =
        Namespaced_IRI.parse _namespace_name "trackSystemSeparationInfo" |> NamespacedName

    /// <summary>
    /// Part of the system separation info of a track that shows whether the breaker has to be switched off.
    /// The system separation info is the Indication of required several information on system separation.
    /// <see href="http://data.europa.eu/949/systemSeparationInfoSwitchOffBreaker"></see></summary>
    let systemSeparationInfoSwitchOffBreaker =
        Namespaced_IRI.parse _namespace_name "systemSeparationInfoSwitchOffBreaker" |> NamespacedName

    /// <summary>
    /// Part of the system separation info of a track that shows the length of the system separation in metres.
    /// The system separation info is the Indication of required several information on system separation.
    /// <see href="http://data.europa.eu/949/systemSeparationInfoLength"></see></summary>
    let systemSeparationInfoLength =
        Namespaced_IRI.parse _namespace_name "systemSeparationInfoLength" |> NamespacedName

    /// <summary>
    /// Part of the system separation info of a track. Indicates the location from the start of the line where the new value is valid.
    /// The system separation info is the Indication of required several information on system separation.
    /// <see href="http://data.europa.eu/949/systemSeparationInfoKm"></see></summary>
    let systemSeparationInfoKm =
        Namespaced_IRI.parse _namespace_name "systemSeparationInfoKm" |> NamespacedName

    /// <summary>
    /// Part of the system separation info of a track that shows whether the supply system has to be changed.
    /// The system separation info is the Indication of required several information on system separation.
    /// <see href="http://data.europa.eu/949/systemSeparationInfoChangeSupplySystem"></see></summary>
    let systemSeparationInfoChangeSupplySystem =
        Namespaced_IRI.parse _namespace_name "systemSeparationInfoChangeSupplySystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SystemSeparationInfoChangeSupplySystem"></see>
    /// </summary>
    let ``shapes/SystemSeparationInfoChangeSupplySystem`` =
        Namespaced_IRI.parse _namespace_name "shapes/SystemSeparationInfoChangeSupplySystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SystemSeparationInfoKm"></see>
    /// </summary>
    let ``shapes/SystemSeparationInfoKm`` =
        Namespaced_IRI.parse _namespace_name "shapes/SystemSeparationInfoKm" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SystemSeparationInfoLength"></see>
    /// </summary>
    let ``shapes/SystemSeparationInfoLength`` =
        Namespaced_IRI.parse _namespace_name "shapes/SystemSeparationInfoLength" |> NamespacedName

    /// <summary>
    /// Part of the system separation info of a track that shows whether the pantograph has to be lowered.
    /// The system separation info is the Indication of required several information on system separation.
    /// <see href="http://data.europa.eu/949/systemSeparationInfoPantographLowered"></see></summary>
    let systemSeparationInfoPantographLowered =
        Namespaced_IRI.parse _namespace_name "systemSeparationInfoPantographLowered" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SystemSeparationInfoPantographLowered"></see>
    /// </summary>
    let ``shapes/SystemSeparationInfoPantographLowered`` =
        Namespaced_IRI.parse _namespace_name "shapes/SystemSeparationInfoPantographLowered" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SystemSeparationInfoSwitchOffBreaker"></see>
    /// </summary>
    let ``shapes/SystemSeparationInfoSwitchOffBreaker`` =
        Namespaced_IRI.parse _namespace_name "shapes/SystemSeparationInfoSwitchOffBreaker" |> NamespacedName

    /// <summary>
    /// Maximum time without a safe message from Radio Block Center before train reacts in seconds.
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/tNvcontact"></see></summary>
    let tNvcontact = Namespaced_IRI.parse _namespace_name "tNvcontact" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TNvcontactApplicability"></see>
    /// </summary>
    let ``shapes/TNvcontactApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/TNvcontactApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TNvcontact"></see>
    /// </summary>
    let ``shapes/TNvcontact`` =
        Namespaced_IRI.parse _namespace_name "shapes/TNvcontact" |> NamespacedName

    /// <summary>
    /// Maximum time for overriding the train trip in seconds.
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/tNvovtrp"></see></summary>
    let tNvovtrp = Namespaced_IRI.parse _namespace_name "tNvovtrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TNvovtrpApplicability"></see>
    /// </summary>
    let ``shapes/TNvovtrpApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/TNvovtrpApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TNvovtrp"></see>
    /// </summary>
    let ``shapes/TNvovtrp`` =
        Namespaced_IRI.parse _namespace_name "shapes/TNvovtrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TdsFrenchTrainDetectionSystemLimitation"></see>
    /// </summary>
    let ``shapes/TdsFrenchTrainDetectionSystemLimitation`` =
        Namespaced_IRI.parse _namespace_name "shapes/TdsFrenchTrainDetectionSystemLimitation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TdsMaximumMagneticFieldApplicability"></see>
    /// </summary>
    let ``shapes/TdsMaximumMagneticFieldApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/TdsMaximumMagneticFieldApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TdsMaximumMagneticField"></see>
    /// </summary>
    let ``shapes/TdsMaximumMagneticField`` =
        Namespaced_IRI.parse _namespace_name "shapes/TdsMaximumMagneticField" |> NamespacedName

    /// <summary>
    /// Indication of load given in tons depending of the category of vehicle. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tdsMinAxleLoadVehicleCategory"></see></summary>
    let tdsMinAxleLoadVehicleCategory =
        Namespaced_IRI.parse _namespace_name "tdsMinAxleLoadVehicleCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/temperature-ranges/TemperatureRanges"></see>
    /// </summary>
    let ``concepts/temperature-ranges/TemperatureRanges`` =
        Namespaced_IRI.parse _namespace_name "concepts/temperature-ranges/TemperatureRanges" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TemperatureRange"></see>
    /// </summary>
    let ``shapes/TemperatureRange`` =
        Namespaced_IRI.parse _namespace_name "shapes/TemperatureRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TemperatureRangeSKOS"></see>
    /// </summary>
    let ``shapes/TemperatureRangeSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/TemperatureRangeSKOS" |> NamespacedName

    /// <summary>
    /// Indication of the part of the trans-European network the infrastructure element belongs to.
    /// <see href="http://data.europa.eu/949/tenClassification"></see></summary>
    let tenClassification =
        Namespaced_IRI.parse _namespace_name "tenClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ten-classifications/TENClassifications"></see>
    /// </summary>
    let ``concepts/ten-classifications/TENClassifications`` =
        Namespaced_IRI.parse _namespace_name "concepts/ten-classifications/TENClassifications" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationS"></see>
    /// </summary>
    let ``shapes/TenClassificationS`` =
        Namespaced_IRI.parse _namespace_name "shapes/TenClassificationS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationT"></see>
    /// </summary>
    let ``shapes/TenClassificationT`` =
        Namespaced_IRI.parse _namespace_name "shapes/TenClassificationT" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationSKOSS"></see>
    /// </summary>
    let ``shapes/TenClassificationSKOSS`` =
        Namespaced_IRI.parse _namespace_name "shapes/TenClassificationSKOSS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationSKOST"></see>
    /// </summary>
    let ``shapes/TenClassificationSKOST`` =
        Namespaced_IRI.parse _namespace_name "shapes/TenClassificationSKOST" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationSKOSP"></see>
    /// </summary>
    let ``shapes/TenClassificationSKOSP`` =
        Namespaced_IRI.parse _namespace_name "shapes/TenClassificationSKOSP" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationPreDeprecationWarning"></see>
    /// </summary>
    let ``shapes/TenClassificationPreDeprecationWarning`` =
        Namespaced_IRI.parse _namespace_name "shapes/TenClassificationPreDeprecationWarning" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenClassificationP"></see>
    /// </summary>
    let ``shapes/TenClassificationP`` =
        Namespaced_IRI.parse _namespace_name "shapes/TenClassificationP" |> NamespacedName

    /// <summary>
    /// Indication of the GIS identity (GIS ID) of the section of TEN-T database to which the track belongs
    /// <see href="http://data.europa.eu/949/tenGISId"></see></summary>
    let tenGISId = Namespaced_IRI.parse _namespace_name "tenGISId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenGISId"></see>
    /// </summary>
    let ``shapes/TenGISId`` =
        Namespaced_IRI.parse _namespace_name "shapes/TenGISId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TenGISIdApplicability"></see>
    /// </summary>
    let ``shapes/TenGISIdApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/TenGISIdApplicability" |> NamespacedName

    /// <summary>
    /// Classification of the element according to its level in the Trans-European Transport Network (TEN-T).
    /// <see href="http://data.europa.eu/949/tentNetworkLevel"></see></summary>
    let tentNetworkLevel =
        Namespaced_IRI.parse _namespace_name "tentNetworkLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/ten-t-network-levels/TENTNetworkLevels"></see>
    /// </summary>
    let ``concepts/ten-t-network-levels/TENTNetworkLevels`` =
        Namespaced_IRI.parse _namespace_name "concepts/ten-t-network-levels/TENTNetworkLevels" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TentNetworkLevelSKOS"></see>
    /// </summary>
    let ``shapes/TentNetworkLevelSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/TentNetworkLevelSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TentNetworkLevel"></see>
    /// </summary>
    let ``shapes/TentNetworkLevel`` =
        Namespaced_IRI.parse _namespace_name "shapes/TentNetworkLevel" |> NamespacedName

    /// <summary>
    /// Used to annotate properties coming from the TenT regulations, to be used for monitoring the provision of the data.
    /// <see href="http://data.europa.eu/949/tentReference"></see></summary>
    let tentReference =
        Namespaced_IRI.parse _namespace_name "tentReference" |> NamespacedName

    /// <summary>
    /// Thermal capacity distance. If no reference case is indicated.
    /// <see href="http://data.europa.eu/949/thermalCapacityDistance"></see></summary>
    let thermalCapacityDistance =
        Namespaced_IRI.parse _namespace_name "thermalCapacityDistance" |> NamespacedName

    /// <summary>
    /// Thermal capacity gradient. If no reference case is indicated.
    /// <see href="http://data.europa.eu/949/thermalCapacityGradient"></see></summary>
    let thermalCapacityGradient =
        Namespaced_IRI.parse _namespace_name "thermalCapacityGradient" |> NamespacedName

    /// <summary>
    /// Thermal capacity speed. If no reference case is indicated.
    /// <see href="http://data.europa.eu/949/thermalCapacitySpeed"></see></summary>
    let thermalCapacitySpeed =
        Namespaced_IRI.parse _namespace_name "thermalCapacitySpeed" |> NamespacedName

    /// <summary>
    /// Reference case of a TSI thermal capacity.
    /// <see href="http://data.europa.eu/949/thermalCapacityTSIReference"></see></summary>
    let thermalCapacityTSIReference =
        Namespaced_IRI.parse _namespace_name "thermalCapacityTSIReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/thermal-capacity/ThermalCapacityTSIReferences"></see>
    /// </summary>
    let ``concepts/thermal-capacity/ThermalCapacityTSIReferences`` =
        Namespaced_IRI.parse _namespace_name "concepts/thermal-capacity/ThermalCapacityTSIReferences" |> NamespacedName

    /// <summary>
    /// Thermal capacity time. If no reference case is indicated.
    /// <see href="http://data.europa.eu/949/thermalCapacityTime"></see></summary>
    let thermalCapacityTime =
        Namespaced_IRI.parse _namespace_name "thermalCapacityTime" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication whether tilting functions are supported by ETCS.
    /// <see href="http://data.europa.eu/949/tiltingSupported"></see></summary>
    let tiltingSupported =
        Namespaced_IRI.parse _namespace_name "tiltingSupported" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TiltingSupported"></see>
    /// </summary>
    let ``shapes/TiltingSupported`` =
        Namespaced_IRI.parse _namespace_name "shapes/TiltingSupported" |> NamespacedName

    /// <summary>
    /// Total vehicle mass (for each vehicle of the unit), given in kg.
    /// <see href="http://data.europa.eu/949/totalVehicleMass"></see></summary>
    let totalVehicleMass =
        Namespaced_IRI.parse _namespace_name "totalVehicleMass" |> NamespacedName

    /// <summary>
    /// The normal running direction is:
    /// - the same as the direction defined by the start and end of the SoL: (N)
    /// - the opposite to the direction defined by the start and end of the SoL: (O)
    /// - both directions: (B)
    /// <see href="http://data.europa.eu/949/trackDirection"></see></summary>
    let trackDirection =
        Namespaced_IRI.parse _namespace_name "trackDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/track-running-directions/TrackRunningDirections"></see>
    /// </summary>
    let ``concepts/track-running-directions/TrackRunningDirections`` =
        Namespaced_IRI.parse _namespace_name "concepts/track-running-directions/TrackRunningDirections" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SoLTrackDirectionMinCount"></see>
    /// </summary>
    let ``shapes/SoLTrackDirectionMinCount`` =
        Namespaced_IRI.parse _namespace_name "shapes/SoLTrackDirectionMinCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackDirectionSKOS"></see>
    /// </summary>
    let ``shapes/TrackDirectionSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrackDirectionSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/SoLTrackDirectionMaxCount"></see>
    /// </summary>
    let ``shapes/SoLTrackDirectionMaxCount`` =
        Namespaced_IRI.parse _namespace_name "shapes/SoLTrackDirectionMaxCount" |> NamespacedName

    /// <summary>
    /// Unique track identification or unique track number within operational point or section of line
    /// <see href="http://data.europa.eu/949/trackId"></see></summary>
    let trackId = Namespaced_IRI.parse _namespace_name "trackId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NoRepeatedTrackIdsSoL"></see>
    /// </summary>
    let ``shapes/NoRepeatedTrackIdsSoL`` =
        Namespaced_IRI.parse _namespace_name "shapes/NoRepeatedTrackIdsSoL" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackId"></see>
    /// </summary>
    let ``shapes/TrackId`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrackId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/NoRepeatedTrackIdsOP"></see>
    /// </summary>
    let ``shapes/NoRepeatedTrackIdsOP`` =
        Namespaced_IRI.parse _namespace_name "shapes/NoRepeatedTrackIdsOP" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackLoadCapability"></see>
    /// </summary>
    let ``shapes/TrackLoadCapability`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrackLoadCapability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackPhaseInfo"></see>
    /// </summary>
    let ``shapes/TrackPhaseInfo`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrackPhaseInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackPhaseInfoApplicability"></see>
    /// </summary>
    let ``shapes/TrackPhaseInfoApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrackPhaseInfoApplicability" |> NamespacedName

    /// <summary>
    /// Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.
    /// <see href="http://data.europa.eu/949/trackRaisedPantographsDistanceAndSpeed"></see></summary>
    let trackRaisedPantographsDistanceAndSpeed =
        Namespaced_IRI.parse _namespace_name "trackRaisedPantographsDistanceAndSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackRaisedPantographsDistanceAndSpeed"></see>
    /// </summary>
    let ``shapes/TrackRaisedPantographsDistanceAndSpeed`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrackRaisedPantographsDistanceAndSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackRaisedPantographDistanceAndSpeedApplicability"></see>
    /// </summary>
    let ``shapes/TrackRaisedPantographDistanceAndSpeedApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrackRaisedPantographDistanceAndSpeedApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackSystemSeparationInfoApplicability"></see>
    /// </summary>
    let ``shapes/TrackSystemSeparationInfoApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrackSystemSeparationInfoApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrackSystemSeparationInfo"></see>
    /// </summary>
    let ``shapes/TrackSystemSeparationInfo`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrackSystemSeparationInfo" |> NamespacedName

    /// <summary>
    /// Link between the running track and the HABD, covering the RINF parameters 1.1.1.1.7.(5-9)
    /// <see href="http://data.europa.eu/949/tracksideHabd"></see></summary>
    let tracksideHabd =
        Namespaced_IRI.parse _namespace_name "tracksideHabd" |> NamespacedName

    /// <summary>
    /// Special conditions implemented on-board to switch over between different train protection control and warning systems. Given as combination of systems installed on board ('System XX'_'System YY').
    /// <see href="http://data.europa.eu/949/trainControlSwitchOverSpecialConditions"></see></summary>
    let trainControlSwitchOverSpecialConditions =
        Namespaced_IRI.parse _namespace_name "trainControlSwitchOverSpecialConditions" |> NamespacedName

    /// <summary>
    /// Technical characteristics of the train detection systems installed in the section of line.
    /// <see href="http://data.europa.eu/949/trainDetectionSystem"></see></summary>
    let trainDetectionSystem =
        Namespaced_IRI.parse _namespace_name "trainDetectionSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystem"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystem`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrainDetectionSystem" |> NamespacedName

    /// <summary>
    /// Reference to the technical specification of train detection system, in accordance with the specification referenced in Appendix A-1, index [D]
    /// <see href="http://data.europa.eu/949/trainDetectionSystemSpecificCheck"></see></summary>
    let trainDetectionSystemSpecificCheck =
        Namespaced_IRI.parse _namespace_name "trainDetectionSystemSpecificCheck" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/train-detection-specific-checks/TrainDetectionSystemsSpecificChecks"></see>
    /// </summary>
    let ``concepts/train-detection-specific-checks/TrainDetectionSystemsSpecificChecks`` =
        Namespaced_IRI.parse _namespace_name "concepts/train-detection-specific-checks/TrainDetectionSystemsSpecificChecks" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckApplicability"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemSpecificCheckApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrainDetectionSystemSpecificCheckApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckSKOS"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemSpecificCheckSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrainDetectionSystemSpecificCheckSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheck"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemSpecificCheck`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrainDetectionSystemSpecificCheck" |> NamespacedName

    /// <summary>
    /// Electronic document from the IM stored by the Agency with precise values in accordance with TSI CCS Article13 and the specification referenced in Appendix A-1, index [D], for the specific check to be performed for train detection systems identified in parameter "Type of track circuits or axle counters to which specific checks are needed".
    /// <see href="http://data.europa.eu/949/trainDetectionSystemSpecificCheckDocument"></see></summary>
    let trainDetectionSystemSpecificCheckDocument =
        Namespaced_IRI.parse _namespace_name "trainDetectionSystemSpecificCheckDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckDocumentApplicability"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemSpecificCheckDocumentApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrainDetectionSystemSpecificCheckDocumentApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckDocument"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemSpecificCheckDocument`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrainDetectionSystemSpecificCheckDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/train-detection/TrainDetectionSystems"></see>
    /// </summary>
    let ``concepts/train-detection/TrainDetectionSystems`` =
        Namespaced_IRI.parse _namespace_name "concepts/train-detection/TrainDetectionSystems" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemType"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemType`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrainDetectionSystemType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainDetectionSystemTypeSKOS"></see>
    /// </summary>
    let ``shapes/TrainDetectionSystemTypeSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrainDetectionSystemTypeSKOS" |> NamespacedName

    /// <summary>
    /// Indication whether train confirmation from on-board is required to access the line for safety reasons.
    /// <see href="http://data.europa.eu/949/trainIntegrityOnBoardRequired"></see></summary>
    let trainIntegrityOnBoardRequired =
        Namespaced_IRI.parse _namespace_name "trainIntegrityOnBoardRequired" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TrainIntegrityOnBoardRequired"></see>
    /// </summary>
    let ``shapes/TrainIntegrityOnBoardRequired`` =
        Namespaced_IRI.parse _namespace_name "shapes/TrainIntegrityOnBoardRequired" |> NamespacedName

    /// <summary>
    /// Indicates the suitability for transport on ferries.
    /// <see href="http://data.europa.eu/949/transportableOnFerry"></see></summary>
    let transportableOnFerry =
        Namespaced_IRI.parse _namespace_name "transportableOnFerry" |> NamespacedName

    /// <summary>
    /// Indicates if a certain property is TSI compliant.The reason for deprecation is that it is used in SKOS "OtherPantographHeads" and "TsiPantographHeads" to indicate in the first case if a SKOS concept is not tsiCompliant (false) and in the second case that the concept is tsiCompliant (true). These two SKOS were originally one SKOS, "PantographHeads". Currently with the two SKOS the property is redundant.
    /// <see href="http://data.europa.eu/949/tsiCompliant"></see></summary>
    let tsiCompliant =
        Namespaced_IRI.parse _namespace_name "tsiCompliant" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. TSI compliance of rules on the use of composite brake blocks.
    /// <see href="http://data.europa.eu/949/tsiCompliantCompositeBrakeBlocks"></see></summary>
    let tsiCompliantCompositeBrakeBlocks =
        Namespaced_IRI.parse _namespace_name "tsiCompliantCompositeBrakeBlocks" |> NamespacedName

    /// <summary>
    /// TSI compliance of Ferromagnetic characteristics of wheel material required. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantFerromagneticWheel"></see></summary>
    let tsiCompliantFerromagneticWheel =
        Namespaced_IRI.parse _namespace_name "tsiCompliantFerromagneticWheel" |> NamespacedName

    /// <summary>
    /// Indication whether required distance between two consecutive axles is compliant with the TSI. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantMaxDistConsecutiveAxles"></see></summary>
    let tsiCompliantMaxDistConsecutiveAxles =
        Namespaced_IRI.parse _namespace_name "tsiCompliantMaxDistConsecutiveAxles" |> NamespacedName

    /// <summary>
    /// TSI compliance of maximum permitted impedance between opposite wheels of a wheelset. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantMaxImpedanceWheelset"></see></summary>
    let tsiCompliantMaxImpedanceWheelset =
        Namespaced_IRI.parse _namespace_name "tsiCompliantMaxImpedanceWheelset" |> NamespacedName

    /// <summary>
    /// TSI compliance of rules for vehicle metal construction. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantMetalConstruction"></see></summary>
    let tsiCompliantMetalConstruction =
        Namespaced_IRI.parse _namespace_name "tsiCompliantMetalConstruction" |> NamespacedName

    /// <summary>
    /// TSI compliance of rules for metal-free space around wheels. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantMetalFreeSpace"></see></summary>
    let tsiCompliantMetalFreeSpace =
        Namespaced_IRI.parse _namespace_name "tsiCompliantMetalFreeSpace" |> NamespacedName

    /// <summary>
    /// TSI compliance of rules on combination of RST characteristics influencing shunting impedance. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantRSTShuntImpedance"></see></summary>
    let tsiCompliantRSTShuntImpedance =
        Namespaced_IRI.parse _namespace_name "tsiCompliantRSTShuntImpedance" |> NamespacedName

    /// <summary>
    /// TSI Compliance of rules on sand characteristics. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantSandCharacteristics"></see></summary>
    let tsiCompliantSandCharacteristics =
        Namespaced_IRI.parse _namespace_name "tsiCompliantSandCharacteristics" |> NamespacedName

    /// <summary>
    /// TSI compliance of sanding rules to allow compatibility with track circuits. Too much sand brings the risk of not detecting trains in tracks equipped with track circuits. Deprecated according to the amendment to the Regulation (EU) 2019/777.
    /// <see href="http://data.europa.eu/949/tsiCompliantSanding"></see></summary>
    let tsiCompliantSanding =
        Namespaced_IRI.parse _namespace_name "tsiCompliantSanding" |> NamespacedName

    /// <summary>
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777. TSI compliance of rules on shunt assisting devices.
    /// <see href="http://data.europa.eu/949/tsiCompliantShuntDevices"></see></summary>
    let tsiCompliantShuntDevices =
        Namespaced_IRI.parse _namespace_name "tsiCompliantShuntDevices" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TsiMagneticFields"></see>
    /// </summary>
    let ``shapes/TsiMagneticFields`` =
        Namespaced_IRI.parse _namespace_name "shapes/TsiMagneticFields" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TsiMagneticFieldsApplicability"></see>
    /// </summary>
    let ``shapes/TsiMagneticFieldsApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/TsiMagneticFieldsApplicability" |> NamespacedName

    /// <summary>
    /// The index of a vocabulary term in Appendix D1 Vehicle and train Route compatibility checks.
    /// <see href="http://data.europa.eu/949/tsiOPEAppendixD1Index"></see></summary>
    let tsiOPEAppendixD1Index =
        Namespaced_IRI.parse _namespace_name "tsiOPEAppendixD1Index" |> NamespacedName

    /// <summary>
    /// Indication of TSI compliant pantograph heads which are allowed to be used.
    /// <see href="http://data.europa.eu/949/tsiPantographHead"></see></summary>
    let tsiPantographHead =
        Namespaced_IRI.parse _namespace_name "tsiPantographHead" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/compliant-pantograph-heads/CompliantPantographHeads"></see>
    /// </summary>
    let ``concepts/compliant-pantograph-heads/CompliantPantographHeads`` =
        Namespaced_IRI.parse _namespace_name "concepts/compliant-pantograph-heads/CompliantPantographHeads" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TsiPantographHeadSKOS"></see>
    /// </summary>
    let ``shapes/TsiPantographHeadSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/TsiPantographHeadSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TsiPantographHeadApplicability"></see>
    /// </summary>
    let ``shapes/TsiPantographHeadApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/TsiPantographHeadApplicability" |> NamespacedName

    /// <summary>
    /// Switches and crossings are maintained to in service limit dimension as specified in TSI.
    /// <see href="http://data.europa.eu/949/tsiSwitchCrossing"></see></summary>
    let tsiSwitchCrossing =
        Namespaced_IRI.parse _namespace_name "tsiSwitchCrossing" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TSISwitchCrossing"></see>
    /// </summary>
    let ``shapes/TSISwitchCrossing`` =
        Namespaced_IRI.parse _namespace_name "shapes/TSISwitchCrossing" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TsiTractionHarmonics"></see>
    /// </summary>
    let ``shapes/TsiTractionHarmonics`` =
        Namespaced_IRI.parse _namespace_name "shapes/TsiTractionHarmonics" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TsiTractionHarmonicsApplicability"></see>
    /// </summary>
    let ``shapes/TsiTractionHarmonicsApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/TsiTractionHarmonicsApplicability" |> NamespacedName

    /// <summary>
    /// Electronic document available from the IM stored by the Agency with precise description of the clearance gauge and geometry of the tunnel.
    /// <see href="http://data.europa.eu/949/tunnelDocRef"></see></summary>
    let tunnelDocRef =
        Namespaced_IRI.parse _namespace_name "tunnelDocRef" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TunnelDocRef"></see>
    /// </summary>
    let ``shapes/TunnelDocRef`` =
        Namespaced_IRI.parse _namespace_name "shapes/TunnelDocRef" |> NamespacedName

    /// <summary>
    /// Unique tunnel identification or unique tunnel number within Member State
    /// <see href="http://data.europa.eu/949/tunnelIdentification"></see></summary>
    let tunnelIdentification =
        Namespaced_IRI.parse _namespace_name "tunnelIdentification" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TunnelIdentification"></see>
    /// </summary>
    let ``shapes/TunnelIdentification`` =
        Namespaced_IRI.parse _namespace_name "shapes/TunnelIdentification" |> NamespacedName

    /// <summary>
    /// Classification of the type of traffic carried on the element.
    /// <see href="http://data.europa.eu/949/typeOfTraffic"></see></summary>
    let typeOfTraffic =
        Namespaced_IRI.parse _namespace_name "typeOfTraffic" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/traffic-types/TrafficTypes"></see>
    /// </summary>
    let ``concepts/traffic-types/TrafficTypes`` =
        Namespaced_IRI.parse _namespace_name "concepts/traffic-types/TrafficTypes" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TypeOfTraffic"></see>
    /// </summary>
    let ``shapes/TypeOfTraffic`` =
        Namespaced_IRI.parse _namespace_name "shapes/TypeOfTraffic" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TypeOfTrafficSKOS"></see>
    /// </summary>
    let ``shapes/TypeOfTrafficSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/TypeOfTrafficSKOS" |> NamespacedName

    /// <summary>
    /// Indicates the registrationVersion with Ids 10, 20 and 30 indicating registration according to Directive 2008/57/EC and implementing Decision 2011/665/EU, and 40 and 50 indicating registration according to regime described in Directive 2008/57/EC.
    /// The allowed values for this property belong to the SKOS Concept Scheme http://data.europa.eu/949/concepts/type-version-ids/TypeVersionIds.
    /// <see href="http://data.europa.eu/949/typeVersionId"></see></summary>
    let typeVersionId =
        Namespaced_IRI.parse _namespace_name "typeVersionId" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/type-version-ids/TypeVersionIds"></see>
    /// </summary>
    let ``concepts/type-version-ids/TypeVersionIds`` =
        Namespaced_IRI.parse _namespace_name "concepts/type-version-ids/TypeVersionIds" |> NamespacedName

    /// <summary>
    /// Serial number that identifies a vehicle type.
    /// <see href="http://data.europa.eu/949/typeVersionNumber"></see></summary>
    let typeVersionNumber =
        Namespaced_IRI.parse _namespace_name "typeVersionNumber" |> NamespacedName

    /// <summary>
    /// Highest non-permanent voltage (Umax2) for France on lines not compliant with values defined in the EN50163:2004+A1:2007+A2:2020+A3:2022
    /// <see href="http://data.europa.eu/949/umax2"></see></summary>
    let umax2 = Namespaced_IRI.parse _namespace_name "umax2" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Umax2"></see>
    /// </summary>
    let ``shapes/Umax2`` =
        Namespaced_IRI.parse _namespace_name "shapes/Umax2" |> NamespacedName

    /// <summary>
    /// Code composed of country code and alphanumeric operational point code.
    /// <see href="http://data.europa.eu/949/uopid"></see></summary>
    let uopid = Namespaced_IRI.parse _namespace_name "uopid" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/UopidP"></see>
    /// </summary>
    let ``shapes/UopidP`` =
        Namespaced_IRI.parse _namespace_name "shapes/UopidP" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BorderPointValidCodeAndCoordinates"></see>
    /// </summary>
    let ``shapes/BorderPointValidCodeAndCoordinates`` =
        Namespaced_IRI.parse _namespace_name "shapes/BorderPointValidCodeAndCoordinates" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BorderPointUopidPrefix"></see>
    /// </summary>
    let ``shapes/BorderPointUopidPrefix`` =
        Namespaced_IRI.parse _namespace_name "shapes/BorderPointUopidPrefix" |> NamespacedName

    /// <summary>
    /// Indication if group 555 is used.
    /// <see href="http://data.europa.eu/949/usesGroup555"></see></summary>
    let usesGroup555 =
        Namespaced_IRI.parse _namespace_name "usesGroup555" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/UsesGroup555Applicability"></see>
    /// </summary>
    let ``shapes/UsesGroup555Applicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/UsesGroup555Applicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/UsesGroup555"></see>
    /// </summary>
    let ``shapes/UsesGroup555`` =
        Namespaced_IRI.parse _namespace_name "shapes/UsesGroup555" |> NamespacedName

    /// <summary>
    /// Speed limit allowing the driver to select the  override  function in km/h
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/vNvallowovtrp"></see></summary>
    let vNvallowovtrp =
        Namespaced_IRI.parse _namespace_name "vNvallowovtrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VNvallowovtrpApplicability"></see>
    /// </summary>
    let ``shapes/VNvallowovtrpApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/VNvallowovtrpApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VNvallowovtrp"></see>
    /// </summary>
    let ``shapes/VNvallowovtrp`` =
        Namespaced_IRI.parse _namespace_name "shapes/VNvallowovtrp" |> NamespacedName

    /// <summary>
    /// Override speed limit to be supervised when the "override" function is active in km/h.
    /// According to the specification referenced in Appendix A-1, index [C]
    /// <see href="http://data.europa.eu/949/vNvsupovtrp"></see></summary>
    let vNvsupovtrp =
        Namespaced_IRI.parse _namespace_name "vNvsupovtrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VNvsupovtrpApplicability"></see>
    /// </summary>
    let ``shapes/VNvsupovtrpApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/VNvsupovtrpApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VNvsupovtrp"></see>
    /// </summary>
    let ``shapes/VNvsupovtrp`` =
        Namespaced_IRI.parse _namespace_name "shapes/VNvsupovtrp" |> NamespacedName

    /// <summary>
    /// Relates a feature with a temporal feature to indicate a validity period.
    /// <see href="http://data.europa.eu/949/validity"></see></summary>
    let validity = Namespaced_IRI.parse _namespace_name "validity" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/Validity"></see>
    /// </summary>
    let ``shapes/Validity`` =
        Namespaced_IRI.parse _namespace_name "shapes/Validity" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/validityEndDate"></see>
    /// </summary>
    let validityEndDate =
        Namespaced_IRI.parse _namespace_name "validityEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/validityStartDate"></see>
    /// </summary>
    let validityStartDate =
        Namespaced_IRI.parse _namespace_name "validityStartDate" |> NamespacedName

    /// <summary>
    /// Mean contact force.
    /// <see href="http://data.europa.eu/949/vehicleContactForce"></see></summary>
    let vehicleContactForce =
        Namespaced_IRI.parse _namespace_name "vehicleContactForce" |> NamespacedName

    /// <summary>
    /// Vehicle kinematic gauge  that corresponds to other gauges assessed using the kinematic method
    /// <see href="http://data.europa.eu/949/vehicleKinematicGaugeOther"></see></summary>
    let vehicleKinematicGaugeOther =
        Namespaced_IRI.parse _namespace_name "vehicleKinematicGaugeOther" |> NamespacedName

    /// <summary>
    /// Vehicle Maximum sanding output, given in grams per second.
    /// <see href="http://data.europa.eu/949/vehicleMaxSandingOutput"></see></summary>
    let vehicleMaxSandingOutput =
        Namespaced_IRI.parse _namespace_name "vehicleMaxSandingOutput" |> NamespacedName

    /// <summary>
    /// Identification number of a vehicle or wagon.
    /// <see href="http://data.europa.eu/949/vehicleNumber"></see></summary>
    let vehicleNumber =
        Namespaced_IRI.parse _namespace_name "vehicleNumber" |> NamespacedName

    /// <summary>
    /// Pantograph head geometry (to be indicated for each energy supply system the vehicle is equipped for).
    /// <see href="http://data.europa.eu/949/vehiclePantographHead"></see></summary>
    let vehiclePantographHead =
        Namespaced_IRI.parse _namespace_name "vehiclePantographHead" |> NamespacedName

    /// <summary>
    /// Manufacturing series of a vehicle.
    /// <see href="http://data.europa.eu/949/vehicleSeries"></see></summary>
    let vehicleSeries =
        Namespaced_IRI.parse _namespace_name "vehicleSeries" |> NamespacedName

    /// <summary>
    /// Indicates the vehicle type of a specific vehicle or wagon.
    /// <see href="http://data.europa.eu/949/vehicleType"></see></summary>
    let vehicleType =
        Namespaced_IRI.parse _namespace_name "vehicleType" |> NamespacedName

    /// <summary>
    /// The infrastructure managers shall provide through RINF the information to the RU regarding list of vehicle types compatible with the route for which they have already verified compatibility for parameter Traffic load and load carrying capacity of infrastructure and train detection systems, where such information is available.
    /// <see href="http://data.europa.eu/949/vehicleTypesCompatibleTrafficLoad"></see></summary>
    let vehicleTypesCompatibleTrafficLoad =
        Namespaced_IRI.parse _namespace_name "vehicleTypesCompatibleTrafficLoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/verifiedRccObjParameter"></see>
    /// </summary>
    let verifiedRccObjParameter =
        Namespaced_IRI.parse _namespace_name "verifiedRccObjParameter" |> NamespacedName

    /// <summary>
    /// The infrastructure managers shall provide through RINF the information or a document to the RU regarding list of vehicles compatible with the route for which they have already verified compatibility for parameter Traffic load and load carrying capacity of infrastructure and train detection systems, where such information is available.
    /// <see href="http://data.europa.eu/949/vehiclesCompatibleTrafficLoad"></see></summary>
    let vehiclesCompatibleTrafficLoad =
        Namespaced_IRI.parse _namespace_name "vehiclesCompatibleTrafficLoad" |> NamespacedName

    /// <summary>
    /// Number of vehicles composing the fixed formation (for fixed formation only). Note: the value is mandatory for all vehicle categories. If the vehicle is composed of only one car, the indicated value shall be '1'.
    /// <see href="http://data.europa.eu/949/vehiclesComposingFixedFormation"></see></summary>
    let vehiclesComposingFixedFormation =
        Namespaced_IRI.parse _namespace_name "vehiclesComposingFixedFormation" |> NamespacedName

    /// <summary>
    /// Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/verificationCCS"></see></summary>
    let verificationCCS =
        Namespaced_IRI.parse _namespace_name "verificationCCS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VerificationCCS"></see>
    /// </summary>
    let ``shapes/VerificationCCS`` =
        Namespaced_IRI.parse _namespace_name "shapes/VerificationCCS" |> NamespacedName

    /// <summary>
    /// Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/verificationENE"></see></summary>
    let verificationENE =
        Namespaced_IRI.parse _namespace_name "verificationENE" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VerificationENE"></see>
    /// </summary>
    let ``shapes/VerificationENE`` =
        Namespaced_IRI.parse _namespace_name "shapes/VerificationENE" |> NamespacedName

    /// <summary>
    /// Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/verificationINF"></see></summary>
    let verificationINF =
        Namespaced_IRI.parse _namespace_name "verificationINF" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VerificationINF"></see>
    /// </summary>
    let ``shapes/VerificationINF`` =
        Namespaced_IRI.parse _namespace_name "shapes/VerificationINF" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VerificationINFS"></see>
    /// </summary>
    let ``shapes/VerificationINFS`` =
        Namespaced_IRI.parse _namespace_name "shapes/VerificationINFS" |> NamespacedName

    /// <summary>
    /// Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250.
    /// <see href="http://data.europa.eu/949/verificationSRT"></see></summary>
    let verificationSRT =
        Namespaced_IRI.parse _namespace_name "verificationSRT" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VerificationSRT"></see>
    /// </summary>
    let ``shapes/VerificationSRT`` =
        Namespaced_IRI.parse _namespace_name "shapes/VerificationSRT" |> NamespacedName

    /// <summary>
    /// Voice SIM Card GSM-R Home Network. The allowed values for this property belong to the SKOS Concept Scheme http://data.europa.eu/949/concepts/gsmr-networks/GSMRNetworks
    /// <see href="http://data.europa.eu/949/voiceGSMRNetwork"></see></summary>
    let voiceGSMRNetwork =
        Namespaced_IRI.parse _namespace_name "voiceGSMRNetwork" |> NamespacedName

    /// <summary>
    /// Voice and operational communication implementation.
    /// <see href="http://data.europa.eu/949/voiceOperationalCommImpl"></see></summary>
    let voiceOperationalCommImpl =
        Namespaced_IRI.parse _namespace_name "voiceOperationalCommImpl" |> NamespacedName

    /// <summary>
    /// Radio requirements used for demonstrating technical compatibility voice.
    /// <see href="http://data.europa.eu/949/voiceRadioCompatible"></see></summary>
    let voiceRadioCompatible =
        Namespaced_IRI.parse _namespace_name "voiceRadioCompatible" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/radio-system-compatibilities-voice/RadioSystemCompatibilitiesVoice"></see>
    /// </summary>
    let ``concepts/radio-system-compatibilities-voice/RadioSystemCompatibilitiesVoice`` =
        Namespaced_IRI.parse _namespace_name "concepts/radio-system-compatibilities-voice/RadioSystemCompatibilitiesVoice" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VoiceRadioCompatibleSKOS"></see>
    /// </summary>
    let ``shapes/VoiceRadioCompatibleSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/VoiceRadioCompatibleSKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VoiceRadioCompatible"></see>
    /// </summary>
    let ``shapes/VoiceRadioCompatible`` =
        Namespaced_IRI.parse _namespace_name "shapes/VoiceRadioCompatible" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/VoiceRadioCompatibleApplicability"></see>
    /// </summary>
    let ``shapes/VoiceRadioCompatibleApplicability`` =
        Namespaced_IRI.parse _namespace_name "shapes/VoiceRadioCompatibleApplicability" |> NamespacedName

    /// <summary>
    /// A single value expressed in millimetres that identifies the track gauge.
    /// <see href="http://data.europa.eu/949/wheelSetGauge"></see></summary>
    let wheelSetGauge =
        Namespaced_IRI.parse _namespace_name "wheelSetGauge" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/nominal-track-gauges/NominalTrackGauges"></see>
    /// </summary>
    let ``concepts/nominal-track-gauges/NominalTrackGauges`` =
        Namespaced_IRI.parse _namespace_name "concepts/nominal-track-gauges/NominalTrackGauges" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/WheelSetGauge"></see>
    /// </summary>
    let ``shapes/WheelSetGauge`` =
        Namespaced_IRI.parse _namespace_name "shapes/WheelSetGauge" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/WheelSetGaugeSKOS"></see>
    /// </summary>
    let ``shapes/WheelSetGaugeSKOS`` =
        Namespaced_IRI.parse _namespace_name "shapes/WheelSetGaugeSKOS" |> NamespacedName

    /// <summary>
    /// Wheelset gauge changeover facility. The allowed values for this property belong to the SKOS Concept Scheme http://data.europa.eu/949/concepts/gauge-changeover-facilities/GaugeChangeoverFacilities
    /// <see href="http://data.europa.eu/949/wheelSetGaugeChangeoverFacility"></see></summary>
    let wheelSetGaugeChangeoverFacility =
        Namespaced_IRI.parse _namespace_name "wheelSetGaugeChangeoverFacility" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/concepts/gauge-changeover-facilities/GaugeChangeoverFacilities"></see>
    /// </summary>
    let ``concepts/gauge-changeover-facilities/GaugeChangeoverFacilities`` =
        Namespaced_IRI.parse _namespace_name "concepts/gauge-changeover-facilities/GaugeChangeoverFacilities" |> NamespacedName

    /// <summary>
    /// Wheel gauge transformation method. Defined if more than one wheel gauges have been selected.
    /// <see href="http://data.europa.eu/949/wheelSetGaugeTransformationMethod"></see></summary>
    let wheelSetGaugeTransformationMethod =
        Namespaced_IRI.parse _namespace_name "wheelSetGaugeTransformationMethod" |> NamespacedName

    /// <summary>
    /// Number of wheelchair accessible sleeping places.
    /// <see href="http://data.europa.eu/949/wheelchairSleepingPlaces"></see></summary>
    let wheelchairSleepingPlaces =
        Namespaced_IRI.parse _namespace_name "wheelchairSleepingPlaces" |> NamespacedName

    /// <summary>
    /// Number of wheelchair spaces.
    /// <see href="http://data.europa.eu/949/wheelchairSpaces"></see></summary>
    let wheelchairSpaces =
        Namespaced_IRI.parse _namespace_name "wheelchairSpaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/GeometryShape"></see>
    /// </summary>
    let ``shapes/GeometryShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/GeometryShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/AsWKT"></see>
    /// </summary>
    let ``shapes/AsWKT`` =
        Namespaced_IRI.parse _namespace_name "shapes/AsWKT" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BorderPointValidCoordinates"></see>
    /// </summary>
    let ``shapes/BorderPointValidCoordinates`` =
        Namespaced_IRI.parse _namespace_name "shapes/BorderPointValidCoordinates" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/BorderPointValidCoordinatesViaNetReference"></see>
    /// </summary>
    let ``shapes/BorderPointValidCoordinatesViaNetReference`` =
        Namespaced_IRI.parse _namespace_name "shapes/BorderPointValidCoordinatesViaNetReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasGeometry"></see>
    /// </summary>
    let ``shapes/HasGeometry`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasGeometry" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/InstantShape"></see>
    /// </summary>
    let ``shapes/InstantShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/InstantShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TemporalDurationShape"></see>
    /// </summary>
    let ``shapes/TemporalDurationShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/TemporalDurationShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/TemporalEntityShape"></see>
    /// </summary>
    let ``shapes/TemporalEntityShape`` =
        Namespaced_IRI.parse _namespace_name "shapes/TemporalEntityShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasBeginning"></see>
    /// </summary>
    let ``shapes/HasBeginning`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasBeginning" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/949/shapes/HasEnd"></see>
    /// </summary>
    let ``shapes/HasEnd`` =
        Namespaced_IRI.parse _namespace_name "shapes/HasEnd" |> NamespacedName
