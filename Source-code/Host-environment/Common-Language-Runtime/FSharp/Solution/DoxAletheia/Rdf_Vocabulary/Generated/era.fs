namespace http.data.europa.eu._949.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module era =
    let _namespace_iri = Namespace_Iri era |> NamespaceIRI
    /// <summary>
    ///   <para>era:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This is the human and machine-readable Ontology governed by the European Union Agency for Railways (https://www.era.europa.eu/). It represents the concepts and relationships linked to the sectorial legal framework and the use cases under the Agency´s remit, as described in the Commission Implementing Regulation (EU) [to be updated after publication] on the common specifications for the register of railway infrastructure [to be updated after publication].
    ///
    ///
    /// Currently, this Ontology covers the European railway infrastructure and the vehicle types authorized to operate over it. It is a semantic/browsable representation of the RINF application guide (1) and ERATV application guide (2) that were built by domain experts in the RINF and ERATV working parties.
    ///
    /// The Ontology also includes the route book concepts described in appendix D2 "Elements the infrastructure manager has to provide to the railway undertaking for the Route Book" as presented in the Commission Implementing Regulation (EU) [to be updated after publication] 2019/773 of 16 May 2019 on the technical specification for interoperability relating to the operation and traffic management subsystem of the rail system within the European Union and [to be updated after publication] and the Appendix D3 [to be updated after publication]."</para>
    /// labels<para>"ERA Ontology"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/">http://data.europa.eu/949/</seealso>
    let _prefix_iri = Prefixed_Name(era, "") |> PrefixedName
    /// <summary>
    ///   <para>era:Body</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an organisation or a physical person"</para>
    /// labels<para>"Body"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/Body">http://data.europa.eu/949/Body</seealso>
    let Body = Prefixed_Name(era, "Body") |> PrefixedName
    /// <summary>
    ///   <para>era:Bridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a structure constructed for the exclusive purpose of carrying railroad traffic across an obstruction. It can be used for defining non-stopping areas, big metal mass, resistance to traffic load etc."</para>
    /// labels<para>"Bridge"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/Bridge">http://data.europa.eu/949/Bridge</seealso>
    let Bridge = Prefixed_Name(era, "Bridge") |> PrefixedName
    /// <summary>
    ///   <para>era:Certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Certificate of a vehicle type. Can be in one of the following states: Amended, New, Suspended, Withdrawn."</para>
    /// labels<para>"Certificate"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/Certificate">http://data.europa.eu/949/Certificate</seealso>
    let Certificate = Prefixed_Name(era, "Certificate") |> PrefixedName

    /// <summary>
    ///   <para>era:CommonCharacteristicsSubset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of different infrastructure objects sharing the same common technical characteristics. The parameters may not be restricted to only one railway subsystem, but it can include common characteristics from each one of them (infrastructure, energy, track-side CCS)"</para>
    /// labels<para>"Subset with common characteristics"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/CommonCharacteristicsSubset">http://data.europa.eu/949/CommonCharacteristicsSubset</seealso>
    let CommonCharacteristicsSubset =
        Prefixed_Name(era, "CommonCharacteristicsSubset") |> PrefixedName

    /// <summary>
    ///   <para>era:ContactLineSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"System that is used to transmit electrical energy to road or rail vehicles."</para>
    /// labels<para>"Contact Line System"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/ContactLineSystem">http://data.europa.eu/949/ContactLineSystem</seealso>
    let ContactLineSystem = Prefixed_Name(era, "ContactLineSystem") |> PrefixedName
    /// <summary>
    ///   <para>era:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Document in any of the ERA systems, e.g. reference document in RINF."</para>
    /// labels<para>"ERA Document"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/Document">http://data.europa.eu/949/Document</seealso>
    let Document = Prefixed_Name(era, "Document") |> PrefixedName
    /// <summary>
    ///   <para>era:ETCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"TSI compliant train protection system ERTMS / ETCS application level and baseline related to the track side equipment."</para>
    /// labels<para>"ETCS"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/ETCS">http://data.europa.eu/949/ETCS</seealso>
    let ETCS = Prefixed_Name(era, "ETCS") |> PrefixedName
    /// <summary>
    ///   <para>era:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that encompasses the features that are part of the physical infrastructure (class InfrastructureElement) and the topological objects (class TopologicalObject). It is a subclass of the geographical Feature class that has a spatial representation."</para>
    /// labels<para>"ERA Feature"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/Feature">http://data.europa.eu/949/Feature</seealso>
    let Feature = Prefixed_Name(era, "Feature") |> PrefixedName

    /// <summary>
    ///   <para>era:FrenchTrainDetectionSystemLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specific for route compatibility check on French network."</para>
    /// labels<para>"Section with train detection limitation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/FrenchTrainDetectionSystemLimitation">http://data.europa.eu/949/FrenchTrainDetectionSystemLimitation</seealso>
    let FrenchTrainDetectionSystemLimitation =
        Prefixed_Name(era, "FrenchTrainDetectionSystemLimitation") |> PrefixedName

    /// <summary>
    ///   <para>era:HABD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A trackside Hot Axle Box Detector (HABD), necessary for the route compatibility check.
    /// Specific for the French, Italian and Swedish networks"</para>
    /// labels<para>"Hot Axle Box Detector"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/HABD">http://data.europa.eu/949/HABD</seealso>
    let HABD = Prefixed_Name(era, "HABD") |> PrefixedName

    /// <summary>
    ///   <para>era:InfrastructureElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class encompasses all those classes that represent features that are  implemented in the European railway infrastructure. It is a subclass of the ERA Feature that has a spatial representation. It covers tracks, platforms, signals, tunnels, operational points, and sections of line.
    /// A feature that belongs to the infrastructure can be abstracted (hasAbstraction) as a topological object. It also is related to the infrastructure manager through the property infrastructureMgr."</para>
    /// labels<para>"Infrastructure element"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/InfrastructureElement">http://data.europa.eu/949/InfrastructureElement</seealso>
    let InfrastructureElement =
        Prefixed_Name(era, "InfrastructureElement") |> PrefixedName

    /// <summary>
    ///   <para>era:InfrastructureManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(deprecated) The infrastructure manager owns and operates the railway network and related infrastructure."</para>
    /// labels<para>"Infrastructure manager"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/InfrastructureManager">http://data.europa.eu/949/InfrastructureManager</seealso>
    let InfrastructureManager =
        Prefixed_Name(era, "InfrastructureManager") |> PrefixedName

    /// <summary>
    ///   <para>era:KilometricPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a kilometric post in the linear positioning system."</para>
    /// labels<para>"Kilometric Post"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/KilometricPost">http://data.europa.eu/949/KilometricPost</seealso>
    let KilometricPost = Prefixed_Name(era, "KilometricPost") |> PrefixedName
    /// <summary>
    ///   <para>era:LevelCrossing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A level crossing is an intersection where a railway line crosses a road or a path at the same level. It can be used for the implementation of the ETCS trackside or to identify potential collision scenarios"</para>
    /// labels<para>"Level crossing"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/LevelCrossing">http://data.europa.eu/949/LevelCrossing</seealso>
    let LevelCrossing = Prefixed_Name(era, "LevelCrossing") |> PrefixedName
    /// <summary>
    ///   <para>era:LineReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A reference to a specific railway line."</para>
    /// labels<para>"(deprecated) Railway location"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/LineReference">http://data.europa.eu/949/LineReference</seealso>
    let LineReference = Prefixed_Name(era, "LineReference") |> PrefixedName
    /// <summary>
    ///   <para>era:LinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Pieces of tracks composing the topology"</para>
    /// labels<para>"Linear Element"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/LinearElement">http://data.europa.eu/949/LinearElement</seealso>
    let LinearElement = Prefixed_Name(era, "LinearElement") |> PrefixedName

    /// <summary>
    ///   <para>era:LinearElementSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a section of a linear element."</para>
    /// labels<para>"Linear Element Section"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/LinearElementSection">http://data.europa.eu/949/LinearElementSection</seealso>
    let LinearElementSection =
        Prefixed_Name(era, "LinearElementSection") |> PrefixedName

    /// <summary>
    ///   <para>era:LinearPositioningSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a linear positioning system used for referencing positions on the network.
    /// It can also represent a sequence of one or more sections of line, used for regular railway operations."</para>
    /// labels<para>"Linear Positioning System"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/LinearPositioningSystem">http://data.europa.eu/949/LinearPositioningSystem</seealso>
    let LinearPositioningSystem =
        Prefixed_Name(era, "LinearPositioningSystem") |> PrefixedName

    /// <summary>
    ///   <para>era:LinearPositioningSystemCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents coordinates in a linear positioning system."</para>
    /// labels<para>"Linear Positioning System Coordinate"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/LinearPositioningSystemCoordinate">http://data.europa.eu/949/LinearPositioningSystemCoordinate</seealso>
    let LinearPositioningSystemCoordinate =
        Prefixed_Name(era, "LinearPositioningSystemCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>era:LinesideDistanceIndication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Frequency, appearance and positioning of a sign indicating distance as reference post. Two types of signs are normally available: kilometre post and hectometre post.
    /// - A kilometre post is a lineside sign indicating the distance from a specific point, usually being the starting point of the railway line.
    /// - A hectometre post is a lineside sign indicating a relative distance."</para>
    /// labels<para>"Lineside indications of distance"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/LinesideDistanceIndication">http://data.europa.eu/949/LinesideDistanceIndication</seealso>
    let LinesideDistanceIndication =
        Prefixed_Name(era, "LinesideDistanceIndication") |> PrefixedName

    /// <summary>
    ///   <para>era:LoadCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A combination of the line category and speed at the weakest point of the track.
    /// Each track can have several load capability (structured) values, and each one has values for load model line category and load model speed."</para>
    ///   <para>"This class together with properties loadCapabilityLineCategory and loadCapabilitySpeed replaces the previous loadCapability SKOS property."</para>
    /// labels<para>"Load capability"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/LoadCapability">http://data.europa.eu/949/LoadCapability</seealso>
    let LoadCapability = Prefixed_Name(era, "LoadCapability") |> PrefixedName
    /// <summary>
    ///   <para>era:Manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(deprecated) Replaced by the era:Body class and era:manufacturer property. A company or organization that manufactures vehicles."</para>
    /// labels<para>"(deprecated) Manufacturer"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/Manufacturer">http://data.europa.eu/949/Manufacturer</seealso>
    let Manufacturer = Prefixed_Name(era, "Manufacturer") |> PrefixedName

    /// <summary>
    ///   <para>era:MaximumMagneticField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Maximum magnetic field"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/MaximumMagneticField">http://data.europa.eu/949/MaximumMagneticField</seealso>
    let MaximumMagneticField =
        Prefixed_Name(era, "MaximumMagneticField") |> PrefixedName

    /// <summary>
    ///   <para>era:MaximumSpeedAndCantDeficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Combination of maximum speed and maximum cant deficiency for which the vehicle was assessed."</para>
    /// labels<para>"Maximum speed and cant deficiency"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/MaximumSpeedAndCantDeficiency">http://data.europa.eu/949/MaximumSpeedAndCantDeficiency</seealso>
    let MaximumSpeedAndCantDeficiency =
        Prefixed_Name(era, "MaximumSpeedAndCantDeficiency") |> PrefixedName

    /// <summary>
    ///   <para>era:MinAxleLoadVehicleCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"(deprecated) Min axle load vehicle category"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/MinAxleLoadVehicleCategory">http://data.europa.eu/949/MinAxleLoadVehicleCategory</seealso>
    let MinAxleLoadVehicleCategory =
        Prefixed_Name(era, "MinAxleLoadVehicleCategory") |> PrefixedName

    /// <summary>
    ///   <para>era:MinVehicleImpedance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Impedance as defined in the TSI CCS (Annex I, Appendix A, Table A.2 -Index 77).
    ///
    /// Minimum vehicle impedance (between wheels and pantograph) (only for vehicles equipped for 1500V or 3000V DC).
    ///
    /// Per Voltage:
    /// [1500]: [CCCC]+[ZZZZ], with input capacitance [CCCC](Cin) and input impedance [ZZZZ](Zin)
    /// [3000]: [CCCC]+[ZZZZ], idem."</para>
    /// labels<para>"Minimum Vehicle Impedance"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/MinVehicleImpedance">http://data.europa.eu/949/MinVehicleImpedance</seealso>
    let MinVehicleImpedance = Prefixed_Name(era, "MinVehicleImpedance") |> PrefixedName

    /// <summary>
    ///   <para>era:MinimumVerticalRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Minimum radius of vertical curve"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/MinimumVerticalRadius">http://data.europa.eu/949/MinimumVerticalRadius</seealso>
    let MinimumVerticalRadius =
        Prefixed_Name(era, "MinimumVerticalRadius") |> PrefixedName

    /// <summary>
    ///   <para>era:NationalRailwayLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Railway line within a member state.
    /// A line is a sequence of one or more sections of line, which connects operational points and which may consist of several tracks used for regular railway operation."</para>
    /// labels<para>"(deprecated) National railway line"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/NationalRailwayLine">http://data.europa.eu/949/NationalRailwayLine</seealso>
    let NationalRailwayLine = Prefixed_Name(era, "NationalRailwayLine") |> PrefixedName
    /// <summary>
    ///   <para>era:NetAreaReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents an area reference in the network."</para>
    /// labels<para>"Net Area Reference"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/NetAreaReference">http://data.europa.eu/949/NetAreaReference</seealso>
    let NetAreaReference = Prefixed_Name(era, "NetAreaReference") |> PrefixedName
    /// <summary>
    ///   <para>era:NetBasicReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Basic positioning reference within the ERA ontology. It represents different types of geographical locations. Geographical coordinates are provided according to the standard World Geodetic System (WGS84)."</para>
    /// labels<para>"Net Basic Reference"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/NetBasicReference">http://data.europa.eu/949/NetBasicReference</seealso>
    let NetBasicReference = Prefixed_Name(era, "NetBasicReference") |> PrefixedName
    /// <summary>
    ///   <para>era:NetElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a representation of all building blocks of the topology. It references an associated topological network element."</para>
    /// labels<para>"Net element"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/NetElement">http://data.europa.eu/949/NetElement</seealso>
    let NetElement = Prefixed_Name(era, "NetElement") |> PrefixedName
    /// <summary>
    ///   <para>era:NetLinearReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a linear reference in the network."</para>
    /// labels<para>"Net Linear Reference"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/NetLinearReference">http://data.europa.eu/949/NetLinearReference</seealso>
    let NetLinearReference = Prefixed_Name(era, "NetLinearReference") |> PrefixedName
    /// <summary>
    ///   <para>era:NetPointReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a point reference in the network."</para>
    /// labels<para>"Net Point Reference"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/NetPointReference">http://data.europa.eu/949/NetPointReference</seealso>
    let NetPointReference = Prefixed_Name(era, "NetPointReference") |> PrefixedName
    /// <summary>
    ///   <para>era:NetRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines a relation between two elements."</para>
    /// labels<para>"Net Relation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/NetRelation">http://data.europa.eu/949/NetRelation</seealso>
    let NetRelation = Prefixed_Name(era, "NetRelation") |> PrefixedName
    /// <summary>
    ///   <para>era:NonLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a non-linear element in the network."</para>
    /// labels<para>"Non-Linear Element"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/NonLinearElement">http://data.europa.eu/949/NonLinearElement</seealso>
    let NonLinearElement = Prefixed_Name(era, "NonLinearElement") |> PrefixedName
    /// <summary>
    ///   <para>era:OperationalPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An operational point (OP) means any location for train service operations, where train services may begin and end or change route, and where passenger or freight services may be provided; operational point also means any location at boundaries between Member States or infrastructure managers."</para>
    /// labels<para>"Operational Point"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/OperationalPoint">http://data.europa.eu/949/OperationalPoint</seealso>
    let OperationalPoint = Prefixed_Name(era, "OperationalPoint") |> PrefixedName
    /// <summary>
    ///   <para>era:OrganisationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents an n-ary relationship between a Body and a role"</para>
    /// labels<para>"Organisation Role"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/OrganisationRole">http://data.europa.eu/949/OrganisationRole</seealso>
    let OrganisationRole = Prefixed_Name(era, "OrganisationRole") |> PrefixedName
    /// <summary>
    ///   <para>era:Orientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the orientation of a railway object in relation to a carrier linear element. It can be described by direction, orientation and side."</para>
    /// labels<para>"Orientation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/Orientation">http://data.europa.eu/949/Orientation</seealso>
    let Orientation = Prefixed_Name(era, "Orientation") |> PrefixedName

    /// <summary>
    ///   <para>era:ParameterApplicability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Applicability interval defines the date interval in which a characteristic of an infrastructure element is applicable. This interval can be applied for any of the technical characteristics or general information of infrastructure elements. This helps identifying planned changes applied to technical parameters over time."</para>
    /// labels<para>"Parameter applicability"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/ParameterApplicability">http://data.europa.eu/949/ParameterApplicability</seealso>
    let ParameterApplicability =
        Prefixed_Name(era, "ParameterApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:PhaseInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of required several information on phase separation."</para>
    /// labels<para>"Phase info"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/PhaseInfo">http://data.europa.eu/949/PhaseInfo</seealso>
    let PhaseInfo = Prefixed_Name(era, "PhaseInfo") |> PrefixedName
    /// <summary>
    ///   <para>era:PlatformEdge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Platform for the purpose of RINF is understood as a platform edge. A platform concerns only the part of the structure neighbouring to the track (interfaced with trains)."</para>
    /// labels<para>"Platform edge"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/PlatformEdge">http://data.europa.eu/949/PlatformEdge</seealso>
    let PlatformEdge = Prefixed_Name(era, "PlatformEdge") |> PrefixedName
    /// <summary>
    ///   <para>era:PrimaryLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Primary Location is a place used by IM to define a path for a train in TAF/TAP TSI framework/messages. This location is a rail point inside the rail network where train starts, ends, stops, or runs through or change line. This location must be managed by an Infrastructure Manager (IM) identified by company code.
    ///
    /// Primary locations are identified by single and unique Primary Location codes. Primary location code is allocated based on processes defined by national entity. Primary location codes are used in any kind of TAF/TAP communication.
    ///
    /// See: Handbook 9.3.3 / page 60"</para>
    /// labels<para>"Primary Location"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/PrimaryLocation">http://data.europa.eu/949/PrimaryLocation</seealso>
    let PrimaryLocation = Prefixed_Name(era, "PrimaryLocation") |> PrefixedName
    /// <summary>
    ///   <para>era:RadioBlockCenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ETCS trackside centralised unit controlling ETCS train movements in level 2.
    ///
    /// A centralised safety unit that receives train position information via radio and sends movement authorities via radio to trains."</para>
    /// labels<para>"Radio Block Center"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/RadioBlockCenter">http://data.europa.eu/949/RadioBlockCenter</seealso>
    let RadioBlockCenter = Prefixed_Name(era, "RadioBlockCenter") |> PrefixedName

    /// <summary>
    ///   <para>era:RaisedPantographsDistanceAndSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed.
    /// Each track can have several raised pantographs per train allowed (structured) values, and each one has values for number of pantographs, minimum distance between pantographs, in metres, and speed considered in km/h."</para>
    /// labels<para>"Requirements for number of raised pantographs and spacing between them, at the given speed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/RaisedPantographsDistanceAndSpeed">http://data.europa.eu/949/RaisedPantographsDistanceAndSpeed</seealso>
    let RaisedPantographsDistanceAndSpeed =
        Prefixed_Name(era, "RaisedPantographsDistanceAndSpeed") |> PrefixedName

    /// <summary>
    ///   <para>era:ReferenceBorderPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"List of reference border points that are specified in the RINF Application Guide."</para>
    /// labels<para>"Reference border point"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/ReferenceBorderPoint">http://data.europa.eu/949/ReferenceBorderPoint</seealso>
    let ReferenceBorderPoint =
        Prefixed_Name(era, "ReferenceBorderPoint") |> PrefixedName

    /// <summary>
    ///   <para>era:RunningTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A running track means any track used for train service movements; passing loops and meeting loops on plain line or track connections only required for train operation are not published"</para>
    /// labels<para>"Running track"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/RunningTrack">http://data.europa.eu/949/RunningTrack</seealso>
    let RunningTrack = Prefixed_Name(era, "RunningTrack") |> PrefixedName
    /// <summary>
    ///   <para>era:SectionOfLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A section of line means the part of line between adjacent operational points and may consist of several tracks."</para>
    /// labels<para>"Section Of Line"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/SectionOfLine">http://data.europa.eu/949/SectionOfLine</seealso>
    let SectionOfLine = Prefixed_Name(era, "SectionOfLine") |> PrefixedName
    /// <summary>
    ///   <para>era:Siding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sidings are all those tracks where running trains in service movements ends and which are not used for operational routing of a train."</para>
    /// labels<para>"Siding"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/Siding">http://data.europa.eu/949/Siding</seealso>
    let Siding = Prefixed_Name(era, "Siding") |> PrefixedName
    /// <summary>
    ///   <para>era:Signal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A railway signal is a visual display device (next to the tracks or via a DMI in the cabin) that conveys instructions or provides advance warning of instructions regarding the driver's authority to proceed."</para>
    /// labels<para>"Signal"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/Signal">http://data.europa.eu/949/Signal</seealso>
    let Signal = Prefixed_Name(era, "Signal") |> PrefixedName
    /// <summary>
    ///   <para>era:SpecialArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Encompasses all those areas (outside of the operational gauge) or sections (those in tunnels excluded) which influence operation in the gauge itself, such as
    /// - safe areas,
    /// - restricted areas (non-stopping areas or industrial risk locations).
    ///
    /// For these areas in tunnels, use era:SpecialTunnelArea."</para>
    /// labels<para>"Special area"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/SpecialArea">http://data.europa.eu/949/SpecialArea</seealso>
    let SpecialArea = Prefixed_Name(era, "SpecialArea") |> PrefixedName
    /// <summary>
    ///   <para>era:SpecialTunnelArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Area or location within a tunnel where there are:
    /// - a safe area: a walkway, evacuation and rescue points;
    /// - a restricted area (non-stopping area or industrial risk location in a tunnel)."</para>
    /// labels<para>"Special tunnel area"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/SpecialTunnelArea">http://data.europa.eu/949/SpecialTunnelArea</seealso>
    let SpecialTunnelArea = Prefixed_Name(era, "SpecialTunnelArea") |> PrefixedName
    /// <summary>
    ///   <para>era:SubsidiaryLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Subsidiary location must be linked to a Primary Location and specifies in more detailed way part, attributes, or usage of Primary location. It may be also a non-rail point or a rail point that is not managed by an Infrastructure Manager (IM). It may be defined by entity having company code according to their needs. The Subsidiary location is optional and dependent upon business needs."</para>
    /// labels<para>"Subsidiary location"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/SubsidiaryLocation">http://data.europa.eu/949/SubsidiaryLocation</seealso>
    let SubsidiaryLocation = Prefixed_Name(era, "SubsidiaryLocation") |> PrefixedName
    /// <summary>
    ///   <para>era:Switch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unit of track comprising two fixed rails (stock rails) and two movable rails (switch rails) used to direct vehicles from one track to another track."</para>
    /// labels<para>"Switch"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/Switch">http://data.europa.eu/949/Switch</seealso>
    let Switch = Prefixed_Name(era, "Switch") |> PrefixedName

    /// <summary>
    ///   <para>era:SystemSeparationInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of required several information on system separation."</para>
    /// labels<para>"System separation info"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/SystemSeparationInfo">http://data.europa.eu/949/SystemSeparationInfo</seealso>
    let SystemSeparationInfo =
        Prefixed_Name(era, "SystemSeparationInfo") |> PrefixedName

    /// <summary>
    ///   <para>era:TENTCorridor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the TEN-T network classification of an element, including its network level, type of traffic, and associated European transport corridors."</para>
    /// labels<para>"TEN-T Corridor"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/TENTCorridor">http://data.europa.eu/949/TENTCorridor</seealso>
    let TENTCorridor = Prefixed_Name(era, "TENTCorridor") |> PrefixedName
    /// <summary>
    ///   <para>era:TSIMagneticFields</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication whether rules exist and are compliant with the TSI."</para>
    /// labels<para>"Existence and TSI compliance of rules for magnetic fields emitted by a vehicle"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/TSIMagneticFields">http://data.europa.eu/949/TSIMagneticFields</seealso>
    let TSIMagneticFields = Prefixed_Name(era, "TSIMagneticFields") |> PrefixedName

    /// <summary>
    ///   <para>era:TSITractionHarmonics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication whether rules exist and are compliant with the TSI."</para>
    /// labels<para>"Existence and TSI compliance of limits in harmonics in the traction current of vehicles"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/TSITractionHarmonics">http://data.europa.eu/949/TSITractionHarmonics</seealso>
    let TSITractionHarmonics =
        Prefixed_Name(era, "TSITractionHarmonics") |> PrefixedName

    /// <summary>
    ///   <para>era:TemporalFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The union of TemporalDuration that represents a time extent and TemporalEntity that represents a temporal interval or instant."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temporal Feature"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/TemporalFeature">http://data.europa.eu/949/TemporalFeature</seealso>
    let TemporalFeature = Prefixed_Name(era, "TemporalFeature") |> PrefixedName

    /// <summary>
    ///   <para>era:TopologicalCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a topological coordinate."</para>
    /// labels<para>"Topological Coordinate"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/TopologicalCoordinate">http://data.europa.eu/949/TopologicalCoordinate</seealso>
    let TopologicalCoordinate =
        Prefixed_Name(era, "TopologicalCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>era:Track</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A pair of rails over which rail borne vehicles can run."</para>
    /// labels<para>"Track"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/Track">http://data.europa.eu/949/Track</seealso>
    let Track = Prefixed_Name(era, "Track") |> PrefixedName

    /// <summary>
    ///   <para>era:TrainDetectionSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Safety system used to detect the presence of vehicles on the railway track."</para>
    /// labels<para>"Train Detection System"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/TrainDetectionSystem">http://data.europa.eu/949/TrainDetectionSystem</seealso>
    let TrainDetectionSystem =
        Prefixed_Name(era, "TrainDetectionSystem") |> PrefixedName

    /// <summary>
    ///   <para>era:Tunnel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A railway tunnel is an excavation or a construction around the track provided to allow the railway to pass for example higher land, buildings or water."</para>
    /// labels<para>"Tunnel"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/Tunnel">http://data.europa.eu/949/Tunnel</seealso>
    let Tunnel = Prefixed_Name(era, "Tunnel") |> PrefixedName
    /// <summary>
    ///   <para>era:Vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific vehicle or wagon able and allowed to operate over railway infrastructure."</para>
    /// labels<para>"Vehicle"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/Vehicle">http://data.europa.eu/949/Vehicle</seealso>
    let Vehicle = Prefixed_Name(era, "Vehicle") |> PrefixedName
    /// <summary>
    ///   <para>era:VehicleKeeper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The natural or legal person that, being the owner of a vehicle or having the right to use it,
    /// exploits the vehicle as a means of transport and is registered as such in a vehicle register referred to in Article 47 of (EU)2016/797."</para>
    /// labels<para>"(deprecated) Vehicle Keeper"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/VehicleKeeper">http://data.europa.eu/949/VehicleKeeper</seealso>
    let VehicleKeeper = Prefixed_Name(era, "VehicleKeeper") |> PrefixedName
    /// <summary>
    ///   <para>era:VehicleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A vehicle type that has been authorized to operate on the EU railway infrastructure. Type means a vehicle type defining the basic design characteristics of the vehicle as covered by a type or design examination certificate described in the relevant verification module.
    ///
    /// Basic design characteristics means the parameters that are used to identify the vehicle type as specified in the issued vehicle type authorisation and recorded in the European Register of Authorised Vehicle Types ('ERATV').
    ///
    /// The above mentioned certificate should be documented using era:certificate.
    /// "</para>
    /// labels<para>"Vehicle Type"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/VehicleType">http://data.europa.eu/949/VehicleType</seealso>
    let VehicleType = Prefixed_Name(era, "VehicleType") |> PrefixedName
    /// <summary>
    ///   <para>era:XMLName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Corresponding XML name as indicated in the RINF application guide"</para>
    /// labels<para>"XML name"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/XMLName">http://data.europa.eu/949/XMLName</seealso>
    let XMLName = Prefixed_Name(era, "XMLName") |> PrefixedName

    /// <summary>
    ///   <para>era:_:genid-nodeid-node1jfsuh0nsx2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/_:genid-nodeid-node1jfsuh0nsx2">http://data.europa.eu/949/_:genid-nodeid-node1jfsuh0nsx2</seealso>
    let ``_:genid_nodeid_node1jfsuh0nsx2`` =
        Prefixed_Name(era, "_:genid-nodeid-node1jfsuh0nsx2") |> PrefixedName

    /// <summary>
    ///   <para>era:_:genid-nodeid-node1jfsuh0nsx3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/_:genid-nodeid-node1jfsuh0nsx3">http://data.europa.eu/949/_:genid-nodeid-node1jfsuh0nsx3</seealso>
    let ``_:genid_nodeid_node1jfsuh0nsx3`` =
        Prefixed_Name(era, "_:genid-nodeid-node1jfsuh0nsx3") |> PrefixedName

    /// <summary>
    ///   <para>era:_:genid-nodeid-node1jfsuh0nsx4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/_:genid-nodeid-node1jfsuh0nsx4">http://data.europa.eu/949/_:genid-nodeid-node1jfsuh0nsx4</seealso>
    let ``_:genid_nodeid_node1jfsuh0nsx4`` =
        Prefixed_Name(era, "_:genid-nodeid-node1jfsuh0nsx4") |> PrefixedName

    /// <summary>
    ///   <para>era:accelerationLevelCrossing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Existence of limit for acceleration of train if stopping or recovering speed close to a level crossing expressed in a specific reference acceleration curve."</para>
    /// labels<para>"Acceleration allowed near level crossing"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/accelerationLevelCrossing">http://data.europa.eu/949/accelerationLevelCrossing</seealso>
    let accelerationLevelCrossing =
        Prefixed_Name(era, "accelerationLevelCrossing") |> PrefixedName

    /// <summary>
    ///   <para>era:additionalBrakingInformationDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Electronic document available in two EU languages from the IM stored by the Agency providing additional information as defined in point (2) of point 4.2.2.6.2 of TSI OPE."</para>
    /// labels<para>"Documents available by the IM relating to braking performance"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/additionalBrakingInformationDocument">http://data.europa.eu/949/additionalBrakingInformationDocument</seealso>
    let additionalBrakingInformationDocument =
        Prefixed_Name(era, "additionalBrakingInformationDocument") |> PrefixedName

    /// <summary>
    ///   <para>era:affectedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Annotation property used in SHACL shapes. Name of the classes that are the subject of properties that are being validated in a SHACL shape."</para>
    /// labels<para>"affected Class"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/affectedClass">http://data.europa.eu/949/affectedClass</seealso>
    let affectedClass = Prefixed_Name(era, "affectedClass") |> PrefixedName
    /// <summary>
    ///   <para>era:affectedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Annotation property used in SHACL shapes. Name of the properties that are being validated in a SHACL shape."</para>
    /// labels<para>"affected Property"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/affectedProperty">http://data.europa.eu/949/affectedProperty</seealso>
    let affectedProperty = Prefixed_Name(era, "affectedProperty") |> PrefixedName
    /// <summary>
    ///   <para>era:aggregates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the linear elements aggregated by a non-linear element."</para>
    /// labels<para>"aggregates"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/aggregates">http://data.europa.eu/949/aggregates</seealso>
    let aggregates = Prefixed_Name(era, "aggregates") |> PrefixedName
    /// <summary>
    ///   <para>era:allocationCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The organisation in charge to allocate the code for the subsidiary location."</para>
    /// labels<para>"allocation company"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/allocationCompany">http://data.europa.eu/949/allocationCompany</seealso>
    let allocationCompany = Prefixed_Name(era, "allocationCompany") |> PrefixedName
    /// <summary>
    ///   <para>era:alternativeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Alternative name of a vehicle type."</para>
    /// labels<para>"Vehicle Type - Alternative name"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/alternativeName">http://data.europa.eu/949/alternativeName</seealso>
    let alternativeName = Prefixed_Name(era, "alternativeName") |> PrefixedName
    /// <summary>
    ///   <para>era:altitudeRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Altitude range."</para>
    /// labels<para>"Altitude range"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/altitudeRange">http://data.europa.eu/949/altitudeRange</seealso>
    let altitudeRange = Prefixed_Name(era, "altitudeRange") |> PrefixedName
    /// <summary>
    ///   <para>era:altitudeRangeDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Altitude range value for 'X' if value 'AX' is selected in altitude range."</para>
    /// labels<para>"Altitude range detail"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/altitudeRangeDetail">http://data.europa.eu/949/altitudeRangeDetail</seealso>
    let altitudeRangeDetail = Prefixed_Name(era, "altitudeRangeDetail") |> PrefixedName
    /// <summary>
    ///   <para>era:applicable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Annotation used to point to the applicability of a parameter in RINF. Values are Y/N/NYA"</para>
    /// labels<para>"applicable"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/applicable">http://data.europa.eu/949/applicable</seealso>
    let applicable = Prefixed_Name(era, "applicable") |> PrefixedName

    /// <summary>
    ///   <para>era:appliesInBothDirections</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies if the section applies in both directions (optional)."</para>
    /// labels<para>"applies in both directions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/appliesInBothDirections">http://data.europa.eu/949/appliesInBothDirections</seealso>
    let appliesInBothDirections =
        Prefixed_Name(era, "appliesInBothDirections") |> PrefixedName

    /// <summary>
    ///   <para>era:appliesToDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The direction relative to the origin of the linear element towards the point reference applies."</para>
    /// labels<para>"applies to direction"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/appliesToDirection">http://data.europa.eu/949/appliesToDirection</seealso>
    let appliesToDirection = Prefixed_Name(era, "appliesToDirection") |> PrefixedName
    /// <summary>
    ///   <para>era:areaBoardingAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information of the train access level for which the boarding aid can be used."</para>
    /// labels<para>"Range of use of the platform boarding aid"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/areaBoardingAid">http://data.europa.eu/949/areaBoardingAid</seealso>
    let areaBoardingAid = Prefixed_Name(era, "areaBoardingAid") |> PrefixedName

    /// <summary>
    ///   <para>era:assistanceStartingTrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of existence of equipment or staff supporting the train crew in starting the train."</para>
    /// labels<para>"Existence of platform assistance for starting train"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/assistanceStartingTrain">http://data.europa.eu/949/assistanceStartingTrain</seealso>
    let assistanceStartingTrain =
        Prefixed_Name(era, "assistanceStartingTrain") |> PrefixedName

    /// <summary>
    ///   <para>era:atoCommunicationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Supported ATO communication systems from trackside."</para>
    /// labels<para>"ATO communication system"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/atoCommunicationSystem">http://data.europa.eu/949/atoCommunicationSystem</seealso>
    let atoCommunicationSystem =
        Prefixed_Name(era, "atoCommunicationSystem") |> PrefixedName

    /// <summary>
    ///   <para>era:atoErrorCorrectionsOnboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"List of unacceptable errors impacting the IM network that are required to be solved in the on-board ATO according to the CCS TSI point 7.2.10.3 specification maintenance point."</para>
    /// labels<para>"(Deprecated) ATO error corrections required for the on-board. Use: errorCorrectionsOnboard"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/atoErrorCorrectionsOnboard">http://data.europa.eu/949/atoErrorCorrectionsOnboard</seealso>
    let atoErrorCorrectionsOnboard =
        Prefixed_Name(era, "atoErrorCorrectionsOnboard") |> PrefixedName

    /// <summary>
    ///   <para>era:atoGradeAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ATO grade of automation installed lineside."</para>
    /// labels<para>"ATO Grade of Automation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/atoGradeAutomation">http://data.europa.eu/949/atoGradeAutomation</seealso>
    let atoGradeAutomation = Prefixed_Name(era, "atoGradeAutomation") |> PrefixedName
    /// <summary>
    ///   <para>era:atoSystemVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"ATO system version according to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"ATO System version"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/atoSystemVersion">http://data.europa.eu/949/atoSystemVersion</seealso>
    let atoSystemVersion = Prefixed_Name(era, "atoSystemVersion") |> PrefixedName
    /// <summary>
    ///   <para>era:authorizedCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the country(ies) in where a vehicle type has been authorized to operate."</para>
    /// labels<para>"authorized country"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/authorizedCountry">http://data.europa.eu/949/authorizedCountry</seealso>
    let authorizedCountry = Prefixed_Name(era, "authorizedCountry") |> PrefixedName

    /// <summary>
    ///   <para>era:automatedTrainOperationObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Automated Train Operation (ATO)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/automatedTrainOperationObjParameter">http://data.europa.eu/949/automatedTrainOperationObjParameter</seealso>
    let automatedTrainOperationObjParameter =
        Prefixed_Name(era, "automatedTrainOperationObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:automaticDroppingDeviceRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of whether an automatic dropping device (ADD) required on the vehicle."</para>
    /// labels<para>"Automatic dropping device required"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/automaticDroppingDeviceRequired">http://data.europa.eu/949/automaticDroppingDeviceRequired</seealso>
    let automaticDroppingDeviceRequired =
        Prefixed_Name(era, "automaticDroppingDeviceRequired") |> PrefixedName

    /// <summary>
    ///   <para>era:axleBearingConditionMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Axle bearing condition monitoring."</para>
    /// labels<para>"axle bearing condition monitoring"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/axleBearingConditionMonitoring">http://data.europa.eu/949/axleBearingConditionMonitoring</seealso>
    let axleBearingConditionMonitoring =
        Prefixed_Name(era, "axleBearingConditionMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>era:axleSpacing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Position of the axles along the unit. a: Distance between axles; b: Distance from end axle to the end of the nearest coupling plane; c: distance between two inside axles."</para>
    /// labels<para>"Axle spacing"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/axleSpacing">http://data.europa.eu/949/axleSpacing</seealso>
    let axleSpacing = Prefixed_Name(era, "axleSpacing") |> PrefixedName
    /// <summary>
    ///   <para>era:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an infrastructure element belongs to a certain subset that contains common characteristics."</para>
    /// labels<para>"belongs to"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/belongsTo">http://data.europa.eu/949/belongsTo</seealso>
    let belongsTo = Prefixed_Name(era, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>era:bigMetalMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of existence of metal mass in the vicinity of the location, susceptible of perturbating the reading of balises by the on-board system."</para>
    /// labels<para>"Big Metal Mass"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/bigMetalMass">http://data.europa.eu/949/bigMetalMass</seealso>
    let bigMetalMass = Prefixed_Name(era, "bigMetalMass") |> PrefixedName
    /// <summary>
    ///   <para>era:boardingAids</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Description of any integrated boarding aids (if provided)."</para>
    /// labels<para>"Boarding aids"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/boardingAids">http://data.europa.eu/949/boardingAids</seealso>
    let boardingAids = Prefixed_Name(era, "boardingAids") |> PrefixedName
    /// <summary>
    ///   <para>era:borderPointId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Border point identification in the list of reference border points in the RINF application guide."</para>
    /// labels<para>"Border point identification"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/borderPointId">http://data.europa.eu/949/borderPointId</seealso>
    let borderPointId = Prefixed_Name(era, "borderPointId") |> PrefixedName
    /// <summary>
    ///   <para>era:borderPointOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates the information that each country maintains on a border point, to the operational point that represents the general information on the border point."</para>
    /// labels<para>"border point of"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/borderPointOf">http://data.europa.eu/949/borderPointOf</seealso>
    let borderPointOf = Prefixed_Name(era, "borderPointOf") |> PrefixedName

    /// <summary>
    ///   <para>era:brakeRelatedDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Brake related parameters"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/brakeRelatedDataParameter">http://data.europa.eu/949/brakeRelatedDataParameter</seealso>
    let brakeRelatedDataParameter =
        Prefixed_Name(era, "brakeRelatedDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:brakeRelatedObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Brake related parameters"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/brakeRelatedObjParameter">http://data.europa.eu/949/brakeRelatedObjParameter</seealso>
    let brakeRelatedObjParameter =
        Prefixed_Name(era, "brakeRelatedObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:brakeWeightPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Brake weight percentage (lambda) or Braked mass."</para>
    /// labels<para>"Brake weight percentage"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/brakeWeightPercentage">http://data.europa.eu/949/brakeWeightPercentage</seealso>
    let brakeWeightPercentage =
        Prefixed_Name(era, "brakeWeightPercentage") |> PrefixedName

    /// <summary>
    ///   <para>era:bridgeWindRestriction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/bridgeWindRestriction">http://data.europa.eu/949/bridgeWindRestriction</seealso>
    let bridgeWindRestriction =
        Prefixed_Name(era, "bridgeWindRestriction") |> PrefixedName

    /// <summary>
    ///   <para>era:canonicalURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The canonical URI is defined for each instance of an Infrastructure element, e.g. section of line, operational point, track, tunnel, siding.
    /// Objects of the infrastructure generated through RML mappings include (when provided) their validity start and end dates. With its identifier, plus all identifiers of its "parent" elements, and its validity dates, a hash URI is generated.
    /// The canonical URI is the element's URI with its identifiers and without the validity dates. All of the hash URIs of an element point to its canonical URI.
    /// Additionally, SoLs point to the canonical URIs of their start OP and end OP."</para>
    /// labels<para>"Canonical URI"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/canonicalURI">http://data.europa.eu/949/canonicalURI</seealso>
    let canonicalURI = Prefixed_Name(era, "canonicalURI") |> PrefixedName
    /// <summary>
    ///   <para>era:cantDefficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Cant deficiency (maximum uncompensated lateral acceleration) for which the vehicle has been assessed. For dual gauge vehicles values for each gauge have to be indicated."</para>
    /// labels<para>"Cant defficiency"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/cantDefficiency">http://data.europa.eu/949/cantDefficiency</seealso>
    let cantDefficiency = Prefixed_Name(era, "cantDefficiency") |> PrefixedName
    /// <summary>
    ///   <para>era:cantDeficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Maximum cant deficiency expressed in millimetres defined as difference between the applied cant and a higher equilibrium cant the line has been designed for."</para>
    /// labels<para>"Cant deficiency"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/cantDeficiency">http://data.europa.eu/949/cantDeficiency</seealso>
    let cantDeficiency = Prefixed_Name(era, "cantDeficiency") |> PrefixedName

    /// <summary>
    ///   <para>era:cantDeficiencyBasicSSP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Essential information for railway undertakings with a worse (lower) tolerated cant deficiency than those for which the ETCS trackside provides SSP (Static Speed Profiles) in conjunction with parameter "Other Cant Deficiency train categories for which the ETCS trackside is configured to provide SSP"."</para>
    /// labels<para>"Cant Deficiency used for the basic SSP"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/cantDeficiencyBasicSSP">http://data.europa.eu/949/cantDeficiencyBasicSSP</seealso>
    let cantDeficiencyBasicSSP =
        Prefixed_Name(era, "cantDeficiencyBasicSSP") |> PrefixedName

    /// <summary>
    ///   <para>era:carrierLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The carrier linear element in relation to which the orientation is based on"</para>
    /// labels<para>"carrier linear element"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/carrierLinearElement">http://data.europa.eu/949/carrierLinearElement</seealso>
    let carrierLinearElement =
        Prefixed_Name(era, "carrierLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>era:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"(Deprecated) Vehicle category."</para>
    /// </remarks>
    /// <seealso href="http://data.europa.eu/949/category">http://data.europa.eu/949/category</seealso>
    let category = Prefixed_Name(era, "category") |> PrefixedName

    /// <summary>
    ///   <para>era:catenaryMaxRatedCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum rated current from the catenary (to be indicated for each electrical energy supply system the vehicle is equipped for), given in A."</para>
    /// labels<para>"Catenary max rated current"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/catenaryMaxRatedCurrent">http://data.europa.eu/949/catenaryMaxRatedCurrent</seealso>
    let catenaryMaxRatedCurrent =
        Prefixed_Name(era, "catenaryMaxRatedCurrent") |> PrefixedName

    /// <summary>
    ///   <para>era:ccsSubsystemDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Control-command and signalling subsystem"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/ccsSubsystemDataParameter">http://data.europa.eu/949/ccsSubsystemDataParameter</seealso>
    let ccsSubsystemDataParameter =
        Prefixed_Name(era, "ccsSubsystemDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:ccsSubsystemDeclarationsVerificationTrackDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Declarations of verification for track"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/ccsSubsystemDeclarationsVerificationTrackDataParameter">http://data.europa.eu/949/ccsSubsystemDeclarationsVerificationTrackDataParameter</seealso>
    let ccsSubsystemDeclarationsVerificationTrackDataParameter =
        Prefixed_Name(era, "ccsSubsystemDeclarationsVerificationTrackDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:ccsSubsystemDeclarationsVerificationTrackObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Declarations of verification for track"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/ccsSubsystemDeclarationsVerificationTrackObjParameter">http://data.europa.eu/949/ccsSubsystemDeclarationsVerificationTrackObjParameter</seealso>
    let ccsSubsystemDeclarationsVerificationTrackObjParameter =
        Prefixed_Name(era, "ccsSubsystemDeclarationsVerificationTrackObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:ccsSubsystemObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Control-command and signalling subsystem"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/ccsSubsystemObjParameter">http://data.europa.eu/949/ccsSubsystemObjParameter</seealso>
    let ccsSubsystemObjParameter =
        Prefixed_Name(era, "ccsSubsystemObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For this Vehicle Type, the type or design examination certificate described in the relevant verification module as issued by
    /// Notified Bodies, supporting the EC Declaration(s) of Verification for the subsystems in scope of the type's authorisation by an authorizing entity."</para>
    /// labels<para>"Certificate"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/certificate">http://data.europa.eu/949/certificate</seealso>
    let certificate = Prefixed_Name(era, "certificate") |> PrefixedName
    /// <summary>
    ///   <para>era:companyCodeCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Category of a Railway company. Can be Infrastructure, Freight or Passenger. Deprecated as it will be integrated with the Organisations properties."</para>
    /// labels<para>"Company code category"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/companyCodeCategory">http://data.europa.eu/949/companyCodeCategory</seealso>
    let companyCodeCategory = Prefixed_Name(era, "companyCodeCategory") |> PrefixedName

    /// <summary>
    ///   <para>era:compatibilityProcedureDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Electronic document available in two EU languages from the IM stored by the Agency with:
    /// - precise procedures for the static and dynamic route compatibility checks;
    /// Or
    /// - relevant information for carrying out the checks for specific structures."</para>
    /// labels<para>"Document with the procedure(s) for static and dynamic route compatibility checks"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/compatibilityProcedureDocument">http://data.europa.eu/949/compatibilityProcedureDocument</seealso>
    let compatibilityProcedureDocument =
        Prefixed_Name(era, "compatibilityProcedureDocument") |> PrefixedName

    /// <summary>
    ///   <para>era:complianceInfTsi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Compliance of the tunnel with TSI INF at the maximum permitted speed"</para>
    /// labels<para>"Compliance of the tunnel with TSI INF"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/complianceInfTsi">http://data.europa.eu/949/complianceInfTsi</seealso>
    let complianceInfTsi = Prefixed_Name(era, "complianceInfTsi") |> PrefixedName

    /// <summary>
    ///   <para>era:compositeBrakeBlockRetrofitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates if a vehicle's composite brake block is retrofitted"</para>
    /// labels<para>"Composite brake block retrofitted"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/compositeBrakeBlockRetrofitted">http://data.europa.eu/949/compositeBrakeBlockRetrofitted</seealso>
    let compositeBrakeBlockRetrofitted =
        Prefixed_Name(era, "compositeBrakeBlockRetrofitted") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/adhf-qualifier/AdhesionFactorChange</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/adhf-qualifier/AdhesionFactorChange">http://data.europa.eu/949/concepts/adhf-qualifier/AdhesionFactorChange</seealso>
    let ``concepts/adhf_qualifier/AdhesionFactorChange`` =
        Prefixed_Name(era, "concepts/adhf-qualifier/AdhesionFactorChange") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/ato-commsys/ATOCommSystem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/ato-commsys/ATOCommSystem">http://data.europa.eu/949/concepts/ato-commsys/ATOCommSystem</seealso>
    let ``concepts/ato_commsys/ATOCommSystem`` =
        Prefixed_Name(era, "concepts/ato-commsys/ATOCommSystem") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/ato-grades-automation/ATOGradeOfAutomation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/ato-grades-automation/ATOGradeOfAutomation">http://data.europa.eu/949/concepts/ato-grades-automation/ATOGradeOfAutomation</seealso>
    let ``concepts/ato_grades_automation/ATOGradeOfAutomation`` =
        Prefixed_Name(era, "concepts/ato-grades-automation/ATOGradeOfAutomation") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/ato-s-versions/ATOSystemVersions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/ato-s-versions/ATOSystemVersions">http://data.europa.eu/949/concepts/ato-s-versions/ATOSystemVersions</seealso>
    let ``concepts/ato_s_versions/ATOSystemVersions`` =
        Prefixed_Name(era, "concepts/ato-s-versions/ATOSystemVersions") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/axle-monitoring/AxleBearingMonitoring</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/axle-monitoring/AxleBearingMonitoring">http://data.europa.eu/949/concepts/axle-monitoring/AxleBearingMonitoring</seealso>
    let ``concepts/axle_monitoring/AxleBearingMonitoring`` =
        Prefixed_Name(era, "concepts/axle-monitoring/AxleBearingMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/brake-parking-type/BrakeParkingType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/brake-parking-type/BrakeParkingType">http://data.europa.eu/949/concepts/brake-parking-type/BrakeParkingType</seealso>
    let ``concepts/brake_parking_type/BrakeParkingType`` =
        Prefixed_Name(era, "concepts/brake-parking-type/BrakeParkingType") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/cant-deficiencies/CantDeficiencies</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/cant-deficiencies/CantDeficiencies">http://data.europa.eu/949/concepts/cant-deficiencies/CantDeficiencies</seealso>
    let ``concepts/cant_deficiencies/CantDeficiencies`` =
        Prefixed_Name(era, "concepts/cant-deficiencies/CantDeficiencies") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/company-code-categories/CompanyCodeCategories</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/company-code-categories/CompanyCodeCategories">http://data.europa.eu/949/concepts/company-code-categories/CompanyCodeCategories</seealso>
    let ``concepts/company_code_categories/CompanyCodeCategories`` =
        Prefixed_Name(era, "concepts/company-code-categories/CompanyCodeCategories") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/compliant-pantograph-heads/CompliantPantographHeads</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/compliant-pantograph-heads/CompliantPantographHeads">http://data.europa.eu/949/concepts/compliant-pantograph-heads/CompliantPantographHeads</seealso>
    let ``concepts/compliant_pantograph_heads/CompliantPantographHeads`` =
        Prefixed_Name(era, "concepts/compliant-pantograph-heads/CompliantPantographHeads") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/conditions-use-reflective-plates/ConditionsUseReflectivePlates</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/conditions-use-reflective-plates/ConditionsUseReflectivePlates">http://data.europa.eu/949/concepts/conditions-use-reflective-plates/ConditionsUseReflectivePlates</seealso>
    let ``concepts/conditions_use_reflective_plates/ConditionsUseReflectivePlates`` =
        Prefixed_Name(era, "concepts/conditions-use-reflective-plates/ConditionsUseReflectivePlates") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/contact-line-systems/ContactLineSystems</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/contact-line-systems/ContactLineSystems">http://data.europa.eu/949/concepts/contact-line-systems/ContactLineSystems</seealso>
    let ``concepts/contact_line_systems/ContactLineSystems`` =
        Prefixed_Name(era, "concepts/contact-line-systems/ContactLineSystems") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/contact-strip-materials/ContactStripMaterials</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/contact-strip-materials/ContactStripMaterials">http://data.europa.eu/949/concepts/contact-strip-materials/ContactStripMaterials</seealso>
    let ``concepts/contact_strip_materials/ContactStripMaterials`` =
        Prefixed_Name(era, "concepts/contact-strip-materials/ContactStripMaterials") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/ebr-qualifier/EBReleaseQualifier</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/ebr-qualifier/EBReleaseQualifier">http://data.europa.eu/949/concepts/ebr-qualifier/EBReleaseQualifier</seealso>
    let ``concepts/ebr_qualifier/EBReleaseQualifier`` =
        Prefixed_Name(era, "concepts/ebr-qualifier/EBReleaseQualifier") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/eddy-current-braking/EddyCurrentBraking</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/eddy-current-braking/EddyCurrentBraking">http://data.europa.eu/949/concepts/eddy-current-braking/EddyCurrentBraking</seealso>
    let ``concepts/eddy_current_braking/EddyCurrentBraking`` =
        Prefixed_Name(era, "concepts/eddy-current-braking/EddyCurrentBraking") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/end-coupling-type/EndCouplingType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/end-coupling-type/EndCouplingType">http://data.europa.eu/949/concepts/end-coupling-type/EndCouplingType</seealso>
    let ``concepts/end_coupling_type/EndCouplingType`` =
        Prefixed_Name(era, "concepts/end-coupling-type/EndCouplingType") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/energy-supply-systems/EnergySupplySystems</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/energy-supply-systems/EnergySupplySystems">http://data.europa.eu/949/concepts/energy-supply-systems/EnergySupplySystems</seealso>
    let ``concepts/energy_supply_systems/EnergySupplySystems`` =
        Prefixed_Name(era, "concepts/energy-supply-systems/EnergySupplySystems") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/error-corrections/OnboardErrorCorrections</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/error-corrections/OnboardErrorCorrections">http://data.europa.eu/949/concepts/error-corrections/OnboardErrorCorrections</seealso>
    let ``concepts/error_corrections/OnboardErrorCorrections`` =
        Prefixed_Name(era, "concepts/error-corrections/OnboardErrorCorrections") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/etcs-baselines/ETCSBaselines</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/etcs-baselines/ETCSBaselines">http://data.europa.eu/949/concepts/etcs-baselines/ETCSBaselines</seealso>
    let ``concepts/etcs_baselines/ETCSBaselines`` =
        Prefixed_Name(era, "concepts/etcs-baselines/ETCSBaselines") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/etcs-equipment-on-board-level/eratv/ETCSEquipmentLevels</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/etcs-equipment-on-board-level/eratv/ETCSEquipmentLevels">http://data.europa.eu/949/concepts/etcs-equipment-on-board-level/eratv/ETCSEquipmentLevels</seealso>
    let ``concepts/etcs_equipment_on_board_level/eratv/ETCSEquipmentLevels`` =
        Prefixed_Name(era, "concepts/etcs-equipment-on-board-level/eratv/ETCSEquipmentLevels") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/etcs-infills/ETCSInfills</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/etcs-infills/ETCSInfills">http://data.europa.eu/949/concepts/etcs-infills/ETCSInfills</seealso>
    let ``concepts/etcs_infills/ETCSInfills`` =
        Prefixed_Name(era, "concepts/etcs-infills/ETCSInfills") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/etcs-levels/ETCSLevels</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/etcs-levels/ETCSLevels">http://data.europa.eu/949/concepts/etcs-levels/ETCSLevels</seealso>
    let ``concepts/etcs_levels/ETCSLevels`` =
        Prefixed_Name(era, "concepts/etcs-levels/ETCSLevels") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/etcs-m-versions/ETCSMVersions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/etcs-m-versions/ETCSMVersions">http://data.europa.eu/949/concepts/etcs-m-versions/ETCSMVersions</seealso>
    let ``concepts/etcs_m_versions/ETCSMVersions`` =
        Prefixed_Name(era, "concepts/etcs-m-versions/ETCSMVersions") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/etcs-national-packet-44-functions/ETCSNationalPacket44Functions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/etcs-national-packet-44-functions/ETCSNationalPacket44Functions">http://data.europa.eu/949/concepts/etcs-national-packet-44-functions/ETCSNationalPacket44Functions</seealso>
    let ``concepts/etcs_national_packet_44_functions/ETCSNationalPacket44Functions`` =
        Prefixed_Name(era, "concepts/etcs-national-packet-44-functions/ETCSNationalPacket44Functions") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/etcs-rbc-reject-reasons/ETCSRBCRejectionReasons</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/etcs-rbc-reject-reasons/ETCSRBCRejectionReasons">http://data.europa.eu/949/concepts/etcs-rbc-reject-reasons/ETCSRBCRejectionReasons</seealso>
    let ``concepts/etcs_rbc_reject_reasons/ETCSRBCRejectionReasons`` =
        Prefixed_Name(era, "concepts/etcs-rbc-reject-reasons/ETCSRBCRejectionReasons") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/etcs-reactions-contact/ETCSReactionsNVContact</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/etcs-reactions-contact/ETCSReactionsNVContact">http://data.europa.eu/949/concepts/etcs-reactions-contact/ETCSReactionsNVContact</seealso>
    let ``concepts/etcs_reactions_contact/ETCSReactionsNVContact`` =
        Prefixed_Name(era, "concepts/etcs-reactions-contact/ETCSReactionsNVContact") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/etcs-situation/ETCSSituations</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/etcs-situation/ETCSSituations">http://data.europa.eu/949/concepts/etcs-situation/ETCSSituations</seealso>
    let ``concepts/etcs_situation/ETCSSituations`` =
        Prefixed_Name(era, "concepts/etcs-situation/ETCSSituations") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/etcs-system-compatibilities/ETCSSystemCompatibilities</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/etcs-system-compatibilities/ETCSSystemCompatibilities">http://data.europa.eu/949/concepts/etcs-system-compatibilities/ETCSSystemCompatibilities</seealso>
    let ``concepts/etcs_system_compatibilities/ETCSSystemCompatibilities`` =
        Prefixed_Name(era, "concepts/etcs-system-compatibilities/ETCSSystemCompatibilities") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/etcs-transmitted-tcs/TransmittedTrackConditions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/etcs-transmitted-tcs/TransmittedTrackConditions">http://data.europa.eu/949/concepts/etcs-transmitted-tcs/TransmittedTrackConditions</seealso>
    let ``concepts/etcs_transmitted_tcs/TransmittedTrackConditions`` =
        Prefixed_Name(era, "concepts/etcs-transmitted-tcs/TransmittedTrackConditions") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/european-transport-corridors/EuropeanTransportCorridors</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/european-transport-corridors/EuropeanTransportCorridors">http://data.europa.eu/949/concepts/european-transport-corridors/EuropeanTransportCorridors</seealso>
    let ``concepts/european_transport_corridors/EuropeanTransportCorridors`` =
        Prefixed_Name(era, "concepts/european-transport-corridors/EuropeanTransportCorridors") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/freight-corridor/FreightCorridors</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/freight-corridor/FreightCorridors">http://data.europa.eu/949/concepts/freight-corridor/FreightCorridors</seealso>
    let ``concepts/freight_corridor/FreightCorridors`` =
        Prefixed_Name(era, "concepts/freight-corridor/FreightCorridors") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/gauge-changeover-facilities/GaugeChangeoverFacilities</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/gauge-changeover-facilities/GaugeChangeoverFacilities">http://data.europa.eu/949/concepts/gauge-changeover-facilities/GaugeChangeoverFacilities</seealso>
    let ``concepts/gauge_changeover_facilities/GaugeChangeoverFacilities`` =
        Prefixed_Name(era, "concepts/gauge-changeover-facilities/GaugeChangeoverFacilities") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/gaugings/GaugingProfiles</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/gaugings/GaugingProfiles">http://data.europa.eu/949/concepts/gaugings/GaugingProfiles</seealso>
    let ``concepts/gaugings/GaugingProfiles`` =
        Prefixed_Name(era, "concepts/gaugings/GaugingProfiles") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/gsm-r-radio-data-communication/GSMRRadioDataCommunications</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/gsm-r-radio-data-communication/GSMRRadioDataCommunications">http://data.europa.eu/949/concepts/gsm-r-radio-data-communication/GSMRRadioDataCommunications</seealso>
    let ``concepts/gsm_r_radio_data_communication/GSMRRadioDataCommunications`` =
        Prefixed_Name(era, "concepts/gsm-r-radio-data-communication/GSMRRadioDataCommunications") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/gsmr-cs-constraints/GSMRConstraints</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/gsmr-cs-constraints/GSMRConstraints">http://data.europa.eu/949/concepts/gsmr-cs-constraints/GSMRConstraints</seealso>
    let ``concepts/gsmr_cs_constraints/GSMRConstraints`` =
        Prefixed_Name(era, "concepts/gsmr-cs-constraints/GSMRConstraints") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/gsmr-networks/GSMRNetworks</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/gsmr-networks/GSMRNetworks">http://data.europa.eu/949/concepts/gsmr-networks/GSMRNetworks</seealso>
    let ``concepts/gsmr_networks/GSMRNetworks`` =
        Prefixed_Name(era, "concepts/gsmr-networks/GSMRNetworks") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/gsmr-number-active-mobiles/NumberActiveMobiles</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/gsmr-number-active-mobiles/NumberActiveMobiles">http://data.europa.eu/949/concepts/gsmr-number-active-mobiles/NumberActiveMobiles</seealso>
    let ``concepts/gsmr_number_active_mobiles/NumberActiveMobiles`` =
        Prefixed_Name(era, "concepts/gsmr-number-active-mobiles/NumberActiveMobiles") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/gsmr-optional-functions/OptionalFunctions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/gsmr-optional-functions/OptionalFunctions">http://data.europa.eu/949/concepts/gsmr-optional-functions/OptionalFunctions</seealso>
    let ``concepts/gsmr_optional_functions/OptionalFunctions`` =
        Prefixed_Name(era, "concepts/gsmr-optional-functions/OptionalFunctions") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/gsmr-versions/GSMRVersions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/gsmr-versions/GSMRVersions">http://data.europa.eu/949/concepts/gsmr-versions/GSMRVersions</seealso>
    let ``concepts/gsmr_versions/GSMRVersions`` =
        Prefixed_Name(era, "concepts/gsmr-versions/GSMRVersions") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/hot-axle-box-detector-direction/HotAxleBoxDetectorDirections</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/hot-axle-box-detector-direction/HotAxleBoxDetectorDirections">http://data.europa.eu/949/concepts/hot-axle-box-detector-direction/HotAxleBoxDetectorDirections</seealso>
    let ``concepts/hot_axle_box_detector_direction/HotAxleBoxDetectorDirections`` =
        Prefixed_Name(era, "concepts/hot-axle-box-detector-direction/HotAxleBoxDetectorDirections") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/ice-conditions/IceConditions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/ice-conditions/IceConditions">http://data.europa.eu/949/concepts/ice-conditions/IceConditions</seealso>
    let ``concepts/ice_conditions/IceConditions`` =
        Prefixed_Name(era, "concepts/ice-conditions/IceConditions") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/legacy-radio-systems/LegacyRadioSystems</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/legacy-radio-systems/LegacyRadioSystems">http://data.europa.eu/949/concepts/legacy-radio-systems/LegacyRadioSystems</seealso>
    let ``concepts/legacy_radio_systems/LegacyRadioSystems`` =
        Prefixed_Name(era, "concepts/legacy-radio-systems/LegacyRadioSystems") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/line-category/LineCategories</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/line-category/LineCategories">http://data.europa.eu/949/concepts/line-category/LineCategories</seealso>
    let ``concepts/line_category/LineCategories`` =
        Prefixed_Name(era, "concepts/line-category/LineCategories") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/lines/ReferenceSystems</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/lines/ReferenceSystems">http://data.europa.eu/949/concepts/lines/ReferenceSystems</seealso>
    let ``concepts/lines/ReferenceSystems`` =
        Prefixed_Name(era, "concepts/lines/ReferenceSystems") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/lineside-distance-indication-appearance/LinesideDistanceIndicationAppearance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/lineside-distance-indication-appearance/LinesideDistanceIndicationAppearance">http://data.europa.eu/949/concepts/lineside-distance-indication-appearance/LinesideDistanceIndicationAppearance</seealso>
    let ``concepts/lineside_distance_indication_appearance/LinesideDistanceIndicationAppearance`` =
        Prefixed_Name(era, "concepts/lineside-distance-indication-appearance/LinesideDistanceIndicationAppearance") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/lineside-distance-indication-positioning/LinesideDistanceIndicationPositioning</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/lineside-distance-indication-positioning/LinesideDistanceIndicationPositioning">http://data.europa.eu/949/concepts/lineside-distance-indication-positioning/LinesideDistanceIndicationPositioning</seealso>
    let ``concepts/lineside_distance_indication_positioning/LinesideDistanceIndicationPositioning`` =
        Prefixed_Name(era, "concepts/lineside-distance-indication-positioning/LinesideDistanceIndicationPositioning") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/load-capabilities/LoadCapabilities</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/load-capabilities/LoadCapabilities">http://data.europa.eu/949/concepts/load-capabilities/LoadCapabilities</seealso>
    let ``concepts/load_capabilities/LoadCapabilities`` =
        Prefixed_Name(era, "concepts/load-capabilities/LoadCapabilities") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/load-capability-line-categories/LoadCapabilityLineCategories</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/load-capability-line-categories/LoadCapabilityLineCategories">http://data.europa.eu/949/concepts/load-capability-line-categories/LoadCapabilityLineCategories</seealso>
    let ``concepts/load_capability_line_categories/LoadCapabilityLineCategories`` =
        Prefixed_Name(era, "concepts/load-capability-line-categories/LoadCapabilityLineCategories") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/magnetic-braking/MagneticBraking</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/magnetic-braking/MagneticBraking">http://data.europa.eu/949/concepts/magnetic-braking/MagneticBraking</seealso>
    let ``concepts/magnetic_braking/MagneticBraking`` =
        Prefixed_Name(era, "concepts/magnetic-braking/MagneticBraking") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/max-amount-sandings/MaxAmountSandings</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/max-amount-sandings/MaxAmountSandings">http://data.europa.eu/949/concepts/max-amount-sandings/MaxAmountSandings</seealso>
    let ``concepts/max_amount_sandings/MaxAmountSandings`` =
        Prefixed_Name(era, "concepts/max-amount-sandings/MaxAmountSandings") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/min-axle-load-vehicle-categories/MinAxleLoadVehicleCategories</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/min-axle-load-vehicle-categories/MinAxleLoadVehicleCategories">http://data.europa.eu/949/concepts/min-axle-load-vehicle-categories/MinAxleLoadVehicleCategories</seealso>
    let ``concepts/min_axle_load_vehicle_categories/MinAxleLoadVehicleCategories`` =
        Prefixed_Name(era, "concepts/min-axle-load-vehicle-categories/MinAxleLoadVehicleCategories") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/navigabilities/Navigabilities</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/navigabilities/Navigabilities">http://data.europa.eu/949/concepts/navigabilities/Navigabilities</seealso>
    let ``concepts/navigabilities/Navigabilities`` =
        Prefixed_Name(era, "concepts/navigabilities/Navigabilities") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/nominal-track-gauges/NominalTrackGauges</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/nominal-track-gauges/NominalTrackGauges">http://data.europa.eu/949/concepts/nominal-track-gauges/NominalTrackGauges</seealso>
    let ``concepts/nominal_track_gauges/NominalTrackGauges`` =
        Prefixed_Name(era, "concepts/nominal-track-gauges/NominalTrackGauges") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/op-types/OperationalPointTypes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/op-types/OperationalPointTypes">http://data.europa.eu/949/concepts/op-types/OperationalPointTypes</seealso>
    let ``concepts/op_types/OperationalPointTypes`` =
        Prefixed_Name(era, "concepts/op-types/OperationalPointTypes") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/operational-regime-types/OperationalRegimeTypes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/operational-regime-types/OperationalRegimeTypes">http://data.europa.eu/949/concepts/operational-regime-types/OperationalRegimeTypes</seealso>
    let ``concepts/operational_regime_types/OperationalRegimeTypes`` =
        Prefixed_Name(era, "concepts/operational-regime-types/OperationalRegimeTypes") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/organisation-roles/OrgRoles</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/organisation-roles/OrgRoles">http://data.europa.eu/949/concepts/organisation-roles/OrgRoles</seealso>
    let ``concepts/organisation_roles/OrgRoles`` =
        Prefixed_Name(era, "concepts/organisation-roles/OrgRoles") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/orientations/OrientationDirections</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/orientations/OrientationDirections">http://data.europa.eu/949/concepts/orientations/OrientationDirections</seealso>
    let ``concepts/orientations/OrientationDirections`` =
        Prefixed_Name(era, "concepts/orientations/OrientationDirections") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/orientations/Sides</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/orientations/Sides">http://data.europa.eu/949/concepts/orientations/Sides</seealso>
    let ``concepts/orientations/Sides`` =
        Prefixed_Name(era, "concepts/orientations/Sides") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/osm-classes/OSMClasses</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/osm-classes/OSMClasses">http://data.europa.eu/949/concepts/osm-classes/OSMClasses</seealso>
    let ``concepts/osm_classes/OSMClasses`` =
        Prefixed_Name(era, "concepts/osm-classes/OSMClasses") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/other-pantograph-heads/OtherPantographHeads</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/other-pantograph-heads/OtherPantographHeads">http://data.europa.eu/949/concepts/other-pantograph-heads/OtherPantographHeads</seealso>
    let ``concepts/other_pantograph_heads/OtherPantographHeads`` =
        Prefixed_Name(era, "concepts/other-pantograph-heads/OtherPantographHeads") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/other-protection-control-warning/OtherProtectionControlWarnings</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/other-protection-control-warning/OtherProtectionControlWarnings">http://data.europa.eu/949/concepts/other-protection-control-warning/OtherProtectionControlWarnings</seealso>
    let ``concepts/other_protection_control_warning/OtherProtectionControlWarnings`` =
        Prefixed_Name(era, "concepts/other-protection-control-warning/OtherProtectionControlWarnings") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/parameterApplicability/ValueTypes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/parameterApplicability/ValueTypes">http://data.europa.eu/949/concepts/parameterApplicability/ValueTypes</seealso>
    let ``concepts/parameterApplicability/ValueTypes`` =
        Prefixed_Name(era, "concepts/parameterApplicability/ValueTypes") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/platform-heights/PlatformHeights</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/platform-heights/PlatformHeights">http://data.europa.eu/949/concepts/platform-heights/PlatformHeights</seealso>
    let ``concepts/platform_heights/PlatformHeights`` =
        Prefixed_Name(era, "concepts/platform-heights/PlatformHeights") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/profile-num-semi-trailers/ProfileNumbersSemiTrailers</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/profile-num-semi-trailers/ProfileNumbersSemiTrailers">http://data.europa.eu/949/concepts/profile-num-semi-trailers/ProfileNumbersSemiTrailers</seealso>
    let ``concepts/profile_num_semi_trailers/ProfileNumbersSemiTrailers`` =
        Prefixed_Name(era, "concepts/profile-num-semi-trailers/ProfileNumbersSemiTrailers") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/profile-num-swap-bodies/ProfileNumbersSwapBodies</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/profile-num-swap-bodies/ProfileNumbersSwapBodies">http://data.europa.eu/949/concepts/profile-num-swap-bodies/ProfileNumbersSwapBodies</seealso>
    let ``concepts/profile_num_swap_bodies/ProfileNumbersSwapBodies`` =
        Prefixed_Name(era, "concepts/profile-num-swap-bodies/ProfileNumbersSwapBodies") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/radio-system-compatibilities-data/RadioSystemCompatibilitiesData</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/radio-system-compatibilities-data/RadioSystemCompatibilitiesData">http://data.europa.eu/949/concepts/radio-system-compatibilities-data/RadioSystemCompatibilitiesData</seealso>
    let ``concepts/radio_system_compatibilities_data/RadioSystemCompatibilitiesData`` =
        Prefixed_Name(era, "concepts/radio-system-compatibilities-data/RadioSystemCompatibilitiesData") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/radio-system-compatibilities-voice/RadioSystemCompatibilitiesVoice</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/radio-system-compatibilities-voice/RadioSystemCompatibilitiesVoice">http://data.europa.eu/949/concepts/radio-system-compatibilities-voice/RadioSystemCompatibilitiesVoice</seealso>
    let ``concepts/radio_system_compatibilities_voice/RadioSystemCompatibilitiesVoice`` =
        Prefixed_Name(era, "concepts/radio-system-compatibilities-voice/RadioSystemCompatibilitiesVoice") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/rail-inclinations/RailInclinations</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/rail-inclinations/RailInclinations">http://data.europa.eu/949/concepts/rail-inclinations/RailInclinations</seealso>
    let ``concepts/rail_inclinations/RailInclinations`` =
        Prefixed_Name(era, "concepts/rail-inclinations/RailInclinations") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/regenerative-braking/RegenerativeBraking</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/regenerative-braking/RegenerativeBraking">http://data.europa.eu/949/concepts/regenerative-braking/RegenerativeBraking</seealso>
    let ``concepts/regenerative_braking/RegenerativeBraking`` =
        Prefixed_Name(era, "concepts/regenerative-braking/RegenerativeBraking") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/relation-positions/RelationPositions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/relation-positions/RelationPositions">http://data.europa.eu/949/concepts/relation-positions/RelationPositions</seealso>
    let ``concepts/relation_positions/RelationPositions`` =
        Prefixed_Name(era, "concepts/relation-positions/RelationPositions") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/restrictions/Restrictions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/restrictions/Restrictions">http://data.europa.eu/949/concepts/restrictions/Restrictions</seealso>
    let ``concepts/restrictions/Restrictions`` =
        Prefixed_Name(era, "concepts/restrictions/Restrictions") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/rolling-stock-fire/Categories</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/rolling-stock-fire/Categories">http://data.europa.eu/949/concepts/rolling-stock-fire/Categories</seealso>
    let ``concepts/rolling_stock_fire/Categories`` =
        Prefixed_Name(era, "concepts/rolling-stock-fire/Categories") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/safe-consist-length/SafeConsistLengthNecessary</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/safe-consist-length/SafeConsistLengthNecessary">http://data.europa.eu/949/concepts/safe-consist-length/SafeConsistLengthNecessary</seealso>
    let ``concepts/safe_consist_length/SafeConsistLengthNecessary`` =
        Prefixed_Name(era, "concepts/safe-consist-length/SafeConsistLengthNecessary") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/signal-types/SignalTypes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/signal-types/SignalTypes">http://data.europa.eu/949/concepts/signal-types/SignalTypes</seealso>
    let ``concepts/signal_types/SignalTypes`` =
        Prefixed_Name(era, "concepts/signal-types/SignalTypes") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/sol-natures/SoLNatures</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/sol-natures/SoLNatures">http://data.europa.eu/949/concepts/sol-natures/SoLNatures</seealso>
    let ``concepts/sol_natures/SoLNatures`` =
        Prefixed_Name(era, "concepts/sol-natures/SoLNatures") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/special-area-types/SpecialAreaTypes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/special-area-types/SpecialAreaTypes">http://data.europa.eu/949/concepts/special-area-types/SpecialAreaTypes</seealso>
    let ``concepts/special_area_types/SpecialAreaTypes`` =
        Prefixed_Name(era, "concepts/special-area-types/SpecialAreaTypes") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/standard-combined-transport-containers/StandardCombinedTransportContainers</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/standard-combined-transport-containers/StandardCombinedTransportContainers">http://data.europa.eu/949/concepts/standard-combined-transport-containers/StandardCombinedTransportContainers</seealso>
    let ``concepts/standard_combined_transport_containers/StandardCombinedTransportContainers`` =
        Prefixed_Name(era, "concepts/standard-combined-transport-containers/StandardCombinedTransportContainers") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/standard-combined-transport-roller-units/StandardCombinedTransportRollerUnits</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/standard-combined-transport-roller-units/StandardCombinedTransportRollerUnits">http://data.europa.eu/949/concepts/standard-combined-transport-roller-units/StandardCombinedTransportRollerUnits</seealso>
    let ``concepts/standard_combined_transport_roller_units/StandardCombinedTransportRollerUnits`` =
        Prefixed_Name(era, "concepts/standard-combined-transport-roller-units/StandardCombinedTransportRollerUnits") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/states/States</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/states/States">http://data.europa.eu/949/concepts/states/States</seealso>
    let ``concepts/states/States`` =
        Prefixed_Name(era, "concepts/states/States") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/subsidiary-location-types/SubsidiaryLocationTypes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/subsidiary-location-types/SubsidiaryLocationTypes">http://data.europa.eu/949/concepts/subsidiary-location-types/SubsidiaryLocationTypes</seealso>
    let ``concepts/subsidiary_location_types/SubsidiaryLocationTypes`` =
        Prefixed_Name(era, "concepts/subsidiary-location-types/SubsidiaryLocationTypes") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/temperature-ranges/TemperatureRanges</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/temperature-ranges/TemperatureRanges">http://data.europa.eu/949/concepts/temperature-ranges/TemperatureRanges</seealso>
    let ``concepts/temperature_ranges/TemperatureRanges`` =
        Prefixed_Name(era, "concepts/temperature-ranges/TemperatureRanges") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/ten-classifications/TENClassifications</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/ten-classifications/TENClassifications">http://data.europa.eu/949/concepts/ten-classifications/TENClassifications</seealso>
    let ``concepts/ten_classifications/TENClassifications`` =
        Prefixed_Name(era, "concepts/ten-classifications/TENClassifications") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/ten-t-network-levels/TENTNetworkLevels</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/ten-t-network-levels/TENTNetworkLevels">http://data.europa.eu/949/concepts/ten-t-network-levels/TENTNetworkLevels</seealso>
    let ``concepts/ten_t_network_levels/TENTNetworkLevels`` =
        Prefixed_Name(era, "concepts/ten-t-network-levels/TENTNetworkLevels") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/thermal-capacity/ThermalCapacityTSIReferences</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/thermal-capacity/ThermalCapacityTSIReferences">http://data.europa.eu/949/concepts/thermal-capacity/ThermalCapacityTSIReferences</seealso>
    let ``concepts/thermal_capacity/ThermalCapacityTSIReferences`` =
        Prefixed_Name(era, "concepts/thermal-capacity/ThermalCapacityTSIReferences") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/track-running-directions/TrackRunningDirections</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/track-running-directions/TrackRunningDirections">http://data.europa.eu/949/concepts/track-running-directions/TrackRunningDirections</seealso>
    let ``concepts/track_running_directions/TrackRunningDirections`` =
        Prefixed_Name(era, "concepts/track-running-directions/TrackRunningDirections") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/traffic-types/TrafficTypes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/traffic-types/TrafficTypes">http://data.europa.eu/949/concepts/traffic-types/TrafficTypes</seealso>
    let ``concepts/traffic_types/TrafficTypes`` =
        Prefixed_Name(era, "concepts/traffic-types/TrafficTypes") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/train-detection-numbers/FrenchTrainDetectionSystemLimitationNumbers</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/train-detection-numbers/FrenchTrainDetectionSystemLimitationNumbers">http://data.europa.eu/949/concepts/train-detection-numbers/FrenchTrainDetectionSystemLimitationNumbers</seealso>
    let ``concepts/train_detection_numbers/FrenchTrainDetectionSystemLimitationNumbers`` =
        Prefixed_Name(era, "concepts/train-detection-numbers/FrenchTrainDetectionSystemLimitationNumbers") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/train-detection-specific-checks/TrainDetectionSystemsSpecificChecks</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/train-detection-specific-checks/TrainDetectionSystemsSpecificChecks">http://data.europa.eu/949/concepts/train-detection-specific-checks/TrainDetectionSystemsSpecificChecks</seealso>
    let ``concepts/train_detection_specific_checks/TrainDetectionSystemsSpecificChecks`` =
        Prefixed_Name(era, "concepts/train-detection-specific-checks/TrainDetectionSystemsSpecificChecks") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/train-detection/FrenchTrainDetectionSystemLimitations</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/train-detection/FrenchTrainDetectionSystemLimitations">http://data.europa.eu/949/concepts/train-detection/FrenchTrainDetectionSystemLimitations</seealso>
    let ``concepts/train_detection/FrenchTrainDetectionSystemLimitations`` =
        Prefixed_Name(era, "concepts/train-detection/FrenchTrainDetectionSystemLimitations") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/train-detection/FrequencyBandsForDetection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/train-detection/FrequencyBandsForDetection">http://data.europa.eu/949/concepts/train-detection/FrequencyBandsForDetection</seealso>
    let ``concepts/train_detection/FrequencyBandsForDetection`` =
        Prefixed_Name(era, "concepts/train-detection/FrequencyBandsForDetection") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/train-detection/TrainDetectionSystems</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/train-detection/TrainDetectionSystems">http://data.europa.eu/949/concepts/train-detection/TrainDetectionSystems</seealso>
    let ``concepts/train_detection/TrainDetectionSystems`` =
        Prefixed_Name(era, "concepts/train-detection/TrainDetectionSystems") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/tsi-compliances/TSICompliances</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/tsi-compliances/TSICompliances">http://data.europa.eu/949/concepts/tsi-compliances/TSICompliances</seealso>
    let ``concepts/tsi_compliances/TSICompliances`` =
        Prefixed_Name(era, "concepts/tsi-compliances/TSICompliances") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/tsi-existence-and-compliances/TSIExistenceAndCompliances</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/tsi-existence-and-compliances/TSIExistenceAndCompliances">http://data.europa.eu/949/concepts/tsi-existence-and-compliances/TSIExistenceAndCompliances</seealso>
    let ``concepts/tsi_existence_and_compliances/TSIExistenceAndCompliances`` =
        Prefixed_Name(era, "concepts/tsi-existence-and-compliances/TSIExistenceAndCompliances") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/type-version-ids/TypeVersionIds</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/type-version-ids/TypeVersionIds">http://data.europa.eu/949/concepts/type-version-ids/TypeVersionIds</seealso>
    let ``concepts/type_version_ids/TypeVersionIds`` =
        Prefixed_Name(era, "concepts/type-version-ids/TypeVersionIds") |> PrefixedName

    /// <summary>
    ///   <para>era:concepts/vehicle-types/Categories</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/concepts/vehicle-types/Categories">http://data.europa.eu/949/concepts/vehicle-types/Categories</seealso>
    let ``concepts/vehicle_types/Categories`` =
        Prefixed_Name(era, "concepts/vehicle-types/Categories") |> PrefixedName

    /// <summary>
    ///   <para>era:conditionalRegenerativeBrake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indication whether regenerative braking is permitted, not permitted, or permitted under specific conditions."</para>
    /// labels<para>"Permission for regenerative braking"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/conditionalRegenerativeBrake">http://data.europa.eu/949/conditionalRegenerativeBrake</seealso>
    let conditionalRegenerativeBrake =
        Prefixed_Name(era, "conditionalRegenerativeBrake") |> PrefixedName

    /// <summary>
    ///   <para>era:conditionsAppliedRegenerativeBraking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Name and/or reference of the document specifying the conditions applying in regards to regenerative braking."</para>
    /// labels<para>"Conditions applying in regards to regenerative braking"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/conditionsAppliedRegenerativeBraking">http://data.europa.eu/949/conditionsAppliedRegenerativeBraking</seealso>
    let conditionsAppliedRegenerativeBraking =
        Prefixed_Name(era, "conditionsAppliedRegenerativeBraking") |> PrefixedName

    /// <summary>
    ///   <para>era:conditionsChargingElectricEnergyStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Conditions set by IMs according to a standardised document"</para>
    /// labels<para>"Permitted conditions for charging electric energy storage for traction purposes at standstill"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/conditionsChargingElectricEnergyStorage">http://data.europa.eu/949/conditionsChargingElectricEnergyStorage</seealso>
    let conditionsChargingElectricEnergyStorage =
        Prefixed_Name(era, "conditionsChargingElectricEnergyStorage") |> PrefixedName

    /// <summary>
    ///   <para>era:conditionsSwitchClassBSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Name and/or reference of the document specifying the Special technical conditions required to switch over between ERTMS/ETCS and Class B systems."</para>
    /// labels<para>"Special technical conditions required to switch over between ERTMS/ETCS and Class B systems"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/conditionsSwitchClassBSystems">http://data.europa.eu/949/conditionsSwitchClassBSystems</seealso>
    let conditionsSwitchClassBSystems =
        Prefixed_Name(era, "conditionsSwitchClassBSystems") |> PrefixedName

    /// <summary>
    ///   <para>era:conditionsSwitchTrainProtectionSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Conditions to switch over between different class B train protection, control and warning systems."</para>
    /// labels<para>"Special conditions to switch over between different class B train protection, control and warning systems"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/conditionsSwitchTrainProtectionSystems">http://data.europa.eu/949/conditionsSwitchTrainProtectionSystems</seealso>
    let conditionsSwitchTrainProtectionSystems =
        Prefixed_Name(era, "conditionsSwitchTrainProtectionSystems") |> PrefixedName

    /// <summary>
    ///   <para>era:conditionsTrainFormation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Conditions of use regarding train formation."</para>
    /// labels<para>"Conditions train formation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/conditionsTrainFormation">http://data.europa.eu/949/conditionsTrainFormation</seealso>
    let conditionsTrainFormation =
        Prefixed_Name(era, "conditionsTrainFormation") |> PrefixedName

    /// <summary>
    ///   <para>era:conditionsUseReflectivePlates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Details of any conditions for using the reflective plates on freight corridors. Specific case for Portugal and Spain until 1.1.2025 and Belgium and France until 1.1.2026."</para>
    /// labels<para>"Conditions for use of reflective plates"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/conditionsUseReflectivePlates">http://data.europa.eu/949/conditionsUseReflectivePlates</seealso>
    let conditionsUseReflectivePlates =
        Prefixed_Name(era, "conditionsUseReflectivePlates") |> PrefixedName

    /// <summary>
    ///   <para>era:connectedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Represents a bidirectional connection between two Track instances."</para>
    /// labels<para>"connected to"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/connectedTo">http://data.europa.eu/949/connectedTo</seealso>
    let connectedTo = Prefixed_Name(era, "connectedTo") |> PrefixedName
    /// <summary>
    ///   <para>era:contactLineSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"System that is used to transmit electrical energy to road or rail vehicles."</para>
    /// labels<para>"contact line system"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/contactLineSystem">http://data.europa.eu/949/contactLineSystem</seealso>
    let contactLineSystem = Prefixed_Name(era, "contactLineSystem") |> PrefixedName

    /// <summary>
    ///   <para>era:contactLineSystemDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Contact line system"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/contactLineSystemDataParameter">http://data.europa.eu/949/contactLineSystemDataParameter</seealso>
    let contactLineSystemDataParameter =
        Prefixed_Name(era, "contactLineSystemDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:contactLineSystemObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Contact line system"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/contactLineSystemObjParameter">http://data.europa.eu/949/contactLineSystemObjParameter</seealso>
    let contactLineSystemObjParameter =
        Prefixed_Name(era, "contactLineSystemObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:contactLineSystemType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indication of the type of the contact line system."</para>
    /// labels<para>"Type of contact line system"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/contactLineSystemType">http://data.europa.eu/949/contactLineSystemType</seealso>
    let contactLineSystemType =
        Prefixed_Name(era, "contactLineSystemType") |> PrefixedName

    /// <summary>
    ///   <para>era:contactStripMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of which contact strip materials are permitted to be used."</para>
    /// labels<para>"Permitted contact strip material"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/contactStripMaterial">http://data.europa.eu/949/contactStripMaterial</seealso>
    let contactStripMaterial =
        Prefixed_Name(era, "contactStripMaterial") |> PrefixedName

    /// <summary>
    ///   <para>era:contactStripMaterialMetallicContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of max. percentage of contact strip material Impregnated Carbon permitted to be used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contact strip material metallic content"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/contactStripMaterialMetallicContent">http://data.europa.eu/949/contactStripMaterialMetallicContent</seealso>
    let contactStripMaterialMetallicContent =
        Prefixed_Name(era, "contactStripMaterialMetallicContent") |> PrefixedName

    /// <summary>
    ///   <para>era:containerHandlingFlag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"container handling flag"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/containerHandlingFlag">http://data.europa.eu/949/containerHandlingFlag</seealso>
    let containerHandlingFlag =
        Prefixed_Name(era, "containerHandlingFlag") |> PrefixedName

    /// <summary>
    ///   <para>era:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a subset with common characteristics contains a certain infrastructure element."</para>
    /// labels<para>"contains"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/contains">http://data.europa.eu/949/contains</seealso>
    let contains = Prefixed_Name(era, "contains") |> PrefixedName
    /// <summary>
    ///   <para>era:crossSectionArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Smallest cross section area in square metres of the tunnel"</para>
    /// labels<para>"Cross section area"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/crossSectionArea">http://data.europa.eu/949/crossSectionArea</seealso>
    let crossSectionArea = Prefixed_Name(era, "crossSectionArea") |> PrefixedName

    /// <summary>
    ///   <para>era:currentLimitationRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of whether an on board current or power limitation function on vehicles is required."</para>
    /// labels<para>"Current or power limitation on board required"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/currentLimitationRequired">http://data.europa.eu/949/currentLimitationRequired</seealso>
    let currentLimitationRequired =
        Prefixed_Name(era, "currentLimitationRequired") |> PrefixedName

    /// <summary>
    ///   <para>era:currentlyValid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Currently valid"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/currentlyValid">http://data.europa.eu/949/currentlyValid</seealso>
    let currentlyValid = Prefixed_Name(era, "currentlyValid") |> PrefixedName
    /// <summary>
    ///   <para>era:dNvovtrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"Maximum distance for overriding the train trip in metres, according to the specification referenced in Appendix A-1, index [C]."</para>
    /// labels<para>"D_NVOVTRP"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/dNvovtrp">http://data.europa.eu/949/dNvovtrp</seealso>
    let dNvovtrp = Prefixed_Name(era, "dNvovtrp") |> PrefixedName
    /// <summary>
    ///   <para>era:dNvpotrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum distance for reversing in Post Trip mode in metres, according to the specification referenced in Appendix A-1, index [C]."</para>
    /// labels<para>"D_NVPOTRP"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/dNvpotrp">http://data.europa.eu/949/dNvpotrp</seealso>
    let dNvpotrp = Prefixed_Name(era, "dNvpotrp") |> PrefixedName
    /// <summary>
    ///   <para>era:dNvroll</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Parameter used by the ETCS on-board to supervise the distance allowed to be travelled under the roll-away protection and the reverse movement protection, in metres
    /// According to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"D_NVROLL"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/dNvroll">http://data.europa.eu/949/dNvroll</seealso>
    let dNvroll = Prefixed_Name(era, "dNvroll") |> PrefixedName

    /// <summary>
    ///   <para>era:dangerousGoodsTankCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Dangerous goods for which the vehicle is suitable (tank code)."</para>
    /// labels<para>"Dangerous goods tank code"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/dangerousGoodsTankCode">http://data.europa.eu/949/dangerousGoodsTankCode</seealso>
    let dangerousGoodsTankCode =
        Prefixed_Name(era, "dangerousGoodsTankCode") |> PrefixedName

    /// <summary>
    ///   <para>era:dataGSMRNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Data SIM Card GSM-R Home Network."</para>
    /// labels<para>"Data GSM-R network"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/dataGSMRNetwork">http://data.europa.eu/949/dataGSMRNetwork</seealso>
    let dataGSMRNetwork = Prefixed_Name(era, "dataGSMRNetwork") |> PrefixedName
    /// <summary>
    ///   <para>era:dataRadioCompatible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Radio requirements used for demonstrating technical compatibility data."</para>
    /// labels<para>"Radio system compatibility data"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/dataRadioCompatible">http://data.europa.eu/949/dataRadioCompatible</seealso>
    let dataRadioCompatible = Prefixed_Name(era, "dataRadioCompatible") |> PrefixedName
    /// <summary>
    ///   <para>era:definesSubset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"(deprecated) not in use anymore. For the purposes of the register of infrastructure, each infrastructure manager may describe its railway network optionally via common characteristic subsets."</para>
    /// labels<para>"Defines subset"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/definesSubset">http://data.europa.eu/949/definesSubset</seealso>
    let definesSubset = Prefixed_Name(era, "definesSubset") |> PrefixedName
    /// <summary>
    ///   <para>era:demonstrationENE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Unique number for EI declarations following the same format requirements as specified for EC declarations in Annex VII of Commission Implementing Regulation (EU) 2019/250."</para>
    /// labels<para>"EI declaration of demonstration (as defined Recommendation 2014/881/EU) for track relating to compliance with the requirements from TSIs applicable to energy subsystem"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/demonstrationENE">http://data.europa.eu/949/demonstrationENE</seealso>
    let demonstrationENE = Prefixed_Name(era, "demonstrationENE") |> PrefixedName
    /// <summary>
    ///   <para>era:demonstrationINF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique number for EI declarations following the same format requirements as specified for EC declarations in Annex VII of Commission Implementing Regulation (EU) 2019/250."</para>
    /// labels<para>"EI declaration of demonstration (as defined in Commission 2014/881/EU (2)) relating to compliance with the requirements from TSIs applicable to infrastructure subsystem"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/demonstrationINF">http://data.europa.eu/949/demonstrationINF</seealso>
    let demonstrationINF = Prefixed_Name(era, "demonstrationINF") |> PrefixedName
    /// <summary>
    ///   <para>era:demonstrationSRT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Unique number for EI declarations following the same format requirements as specified for EC declarations in Annex VII of Commission Implementing Regulation (EU) 2019/250."</para>
    /// labels<para>"EI declaration of demonstration (as defined in Recommendation 2014/881/EU) relating to compliance with the requirements from TSIs applicable to railway tunnel"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/demonstrationSRT">http://data.europa.eu/949/demonstrationSRT</seealso>
    let demonstrationSRT = Prefixed_Name(era, "demonstrationSRT") |> PrefixedName
    /// <summary>
    ///   <para>era:dependencyNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This property is used to specify dependencies in natural language not covered by skos:scopeNote"</para>
    /// labels<para>"dependency note"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/dependencyNote">http://data.europa.eu/949/dependencyNote</seealso>
    let dependencyNote = Prefixed_Name(era, "dependencyNote") |> PrefixedName

    /// <summary>
    ///   <para>era:designMassExceptionalPayload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Design mass under exceptional payload."</para>
    /// labels<para>"Design mass under exceptional payload"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/designMassExceptionalPayload">http://data.europa.eu/949/designMassExceptionalPayload</seealso>
    let designMassExceptionalPayload =
        Prefixed_Name(era, "designMassExceptionalPayload") |> PrefixedName

    /// <summary>
    ///   <para>era:designMassNormalPayload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Design mass under normal payload."</para>
    /// labels<para>"Design mass under normal payload"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/designMassNormalPayload">http://data.europa.eu/949/designMassNormalPayload</seealso>
    let designMassNormalPayload =
        Prefixed_Name(era, "designMassNormalPayload") |> PrefixedName

    /// <summary>
    ///   <para>era:designMassWorkingOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Design mass in working order."</para>
    /// labels<para>"Design mass in working order"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/designMassWorkingOrder">http://data.europa.eu/949/designMassWorkingOrder</seealso>
    let designMassWorkingOrder =
        Prefixed_Name(era, "designMassWorkingOrder") |> PrefixedName

    /// <summary>
    ///   <para>era:dieselThermalAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication whether it is allowed to use diesel or other thermal traction in the tunnel"</para>
    /// labels<para>"Diesel or other thermal traction allowed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/dieselThermalAllowed">http://data.europa.eu/949/dieselThermalAllowed</seealso>
    let dieselThermalAllowed =
        Prefixed_Name(era, "dieselThermalAllowed") |> PrefixedName

    /// <summary>
    ///   <para>era:digitalSchematicOverview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Diagrammatic representation of the operational point in Well Known Text polyline"</para>
    /// labels<para>"Digital schematic overview"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/digitalSchematicOverview">http://data.europa.eu/949/digitalSchematicOverview</seealso>
    let digitalSchematicOverview =
        Prefixed_Name(era, "digitalSchematicOverview") |> PrefixedName

    /// <summary>
    ///   <para>era:direction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The direction of the orientation of a railway element, in relation to the carrier linear element"</para>
    /// labels<para>"direction"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/direction">http://data.europa.eu/949/direction</seealso>
    let direction = Prefixed_Name(era, "direction") |> PrefixedName
    /// <summary>
    ///   <para>era:distSignToPhaseEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Distance between the signboard authorizing the driver to  raise pantograph  or  close the circuit breaker  after passing the phase separation and the end of the phase separation section."</para>
    /// labels<para>"Distance between signboard and phase separation ending"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/distSignToPhaseEnd">http://data.europa.eu/949/distSignToPhaseEnd</seealso>
    let distSignToPhaseEnd = Prefixed_Name(era, "distSignToPhaseEnd") |> PrefixedName

    /// <summary>
    ///   <para>era:documentRestrictionPositionContactLineSeparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Name and/or reference of the document specifying the restriction(s) related to the position of Multiple Traction unit(s) to comply with contact line separation."</para>
    /// labels<para>"Document with restriction related to the position of Multiple Traction unit(s) to comply with contact line separation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/documentRestrictionPositionContactLineSeparation">http://data.europa.eu/949/documentRestrictionPositionContactLineSeparation</seealso>
    let documentRestrictionPositionContactLineSeparation =
        Prefixed_Name(era, "documentRestrictionPositionContactLineSeparation") |> PrefixedName

    /// <summary>
    ///   <para>era:documentRestrictionPowerConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Name and/or reference of the document specifying the restriction(s) related to power consumption of specific electric traction unit(s)."</para>
    /// labels<para>"Document with restriction related to power consumption of specific electric traction unit(s)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/documentRestrictionPowerConsumption">http://data.europa.eu/949/documentRestrictionPowerConsumption</seealso>
    let documentRestrictionPowerConsumption =
        Prefixed_Name(era, "documentRestrictionPowerConsumption") |> PrefixedName

    /// <summary>
    ///   <para>era:documentUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"URL that is used to download a document, e.g. url for a reference document in RINF."</para>
    /// labels<para>"Document URL"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/documentUrl">http://data.europa.eu/949/documentUrl</seealso>
    let documentUrl = Prefixed_Name(era, "documentUrl") |> PrefixedName
    /// <summary>
    ///   <para>era:drivingCabs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of driving cabs. For wagons the number of driving cabs is to be set to zero (0)."</para>
    /// labels<para>"Driving cabs"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/drivingCabs">http://data.europa.eu/949/drivingCabs</seealso>
    let drivingCabs = Prefixed_Name(era, "drivingCabs") |> PrefixedName

    /// <summary>
    ///   <para>era:eddyCurrentBrakePrevention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Possibility of preventing the use of the eddy current track brake (only if fitted with eddy current brake)"</para>
    /// labels<para>"Eddy current brake prevention"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/eddyCurrentBrakePrevention">http://data.europa.eu/949/eddyCurrentBrakePrevention</seealso>
    let eddyCurrentBrakePrevention =
        Prefixed_Name(era, "eddyCurrentBrakePrevention") |> PrefixedName

    /// <summary>
    ///   <para>era:eddyCurrentBraking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indication of limitations on the use of eddy current brakes."</para>
    /// labels<para>"Use of eddy current brakes"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/eddyCurrentBraking">http://data.europa.eu/949/eddyCurrentBraking</seealso>
    let eddyCurrentBraking = Prefixed_Name(era, "eddyCurrentBraking") |> PrefixedName

    /// <summary>
    ///   <para>era:eddyCurrentBrakingConditionsDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Electronic document available in two EU languages from the IM stored by the Agency with conditions for the use of eddy current brakes identified in 1.1.1.1.6.2."</para>
    /// labels<para>"Document with the conditions for the use of eddy current brakes"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/eddyCurrentBrakingConditionsDocument">http://data.europa.eu/949/eddyCurrentBrakingConditionsDocument</seealso>
    let eddyCurrentBrakingConditionsDocument =
        Prefixed_Name(era, "eddyCurrentBrakingConditionsDocument") |> PrefixedName

    /// <summary>
    ///   <para>era:eddyCurrentBrakingFitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Eddy current track brake fitted. New property defined to distinguish it from eddyCurrentBraking which is a RINF SKOS property."</para>
    /// labels<para>"Eddy current braking fitted"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/eddyCurrentBrakingFitted">http://data.europa.eu/949/eddyCurrentBrakingFitted</seealso>
    let eddyCurrentBrakingFitted =
        Prefixed_Name(era, "eddyCurrentBrakingFitted") |> PrefixedName

    /// <summary>
    ///   <para>era:elementA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"References the first topological element in an oriented relation.
    /// For example, it may indicate the object that corresponds to a section of line, an operational point or a track inside an operational point connected at start."</para>
    /// labels<para>"Element A"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/elementA">http://data.europa.eu/949/elementA</seealso>
    let elementA = Prefixed_Name(era, "elementA") |> PrefixedName
    /// <summary>
    ///   <para>era:elementB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"References the second topological linear element in an oriented relation.
    /// For example, it may indicate the object that corresponds to a section of line, an operational point or a track inside an operational point connected at end."</para>
    /// labels<para>"Element B"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/elementB">http://data.europa.eu/949/elementB</seealso>
    let elementB = Prefixed_Name(era, "elementB") |> PrefixedName
    /// <summary>
    ///   <para>era:elementPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"References the topology object of a higher-granularity level which contains a lower-granularity topology object."</para>
    /// labels<para>"Element part"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/elementPart">http://data.europa.eu/949/elementPart</seealso>
    let elementPart = Prefixed_Name(era, "elementPart") |> PrefixedName
    /// <summary>
    ///   <para>era:emergencyBrake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Stopping distance and deceleration profile for each load condition per design maximum speed."</para>
    /// labels<para>"Emergency braking"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/emergencyBrake">http://data.europa.eu/949/emergencyBrake</seealso>
    let emergencyBrake = Prefixed_Name(era, "emergencyBrake") |> PrefixedName
    /// <summary>
    ///   <para>era:endCouplingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Type of end coupling (indicating tensile and compressive forces)."</para>
    /// labels<para>"End coupling type"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/endCouplingType">http://data.europa.eu/949/endCouplingType</seealso>
    let endCouplingType = Prefixed_Name(era, "endCouplingType") |> PrefixedName

    /// <summary>
    ///   <para>era:endIntrinsicCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"End intrinsic coordinate"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/endIntrinsicCoordinate">http://data.europa.eu/949/endIntrinsicCoordinate</seealso>
    let endIntrinsicCoordinate =
        Prefixed_Name(era, "endIntrinsicCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>era:endLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Geographical coordinates in decimal degrees and km of the line at the end of a tunnel."</para>
    /// labels<para>"End of tunnel"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/endLocation">http://data.europa.eu/949/endLocation</seealso>
    let endLocation = Prefixed_Name(era, "endLocation") |> PrefixedName
    /// <summary>
    ///   <para>era:endOffsetFromOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"End offset of the section from the origin."</para>
    /// labels<para>"end offset from the origin"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/endOffsetFromOrigin">http://data.europa.eu/949/endOffsetFromOrigin</seealso>
    let endOffsetFromOrigin = Prefixed_Name(era, "endOffsetFromOrigin") |> PrefixedName
    /// <summary>
    ///   <para>era:endsAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the ending point of a linear reference."</para>
    /// labels<para>"ends at"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/endsAt">http://data.europa.eu/949/endsAt</seealso>
    let endsAt = Prefixed_Name(era, "endsAt") |> PrefixedName

    /// <summary>
    ///   <para>era:energyMeterInstalled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"TSI conform energy meter for billing purposes installed on board."</para>
    /// labels<para>"Energy meter installed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/energyMeterInstalled">http://data.europa.eu/949/energyMeterInstalled</seealso>
    let energyMeterInstalled =
        Prefixed_Name(era, "energyMeterInstalled") |> PrefixedName

    /// <summary>
    ///   <para>era:energySubsystemDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Energy subsystem"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/energySubsystemDataParameter">http://data.europa.eu/949/energySubsystemDataParameter</seealso>
    let energySubsystemDataParameter =
        Prefixed_Name(era, "energySubsystemDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:energySubsystemDeclarationsVerificationTrackDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Declarations of verification for track"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/energySubsystemDeclarationsVerificationTrackDataParameter">http://data.europa.eu/949/energySubsystemDeclarationsVerificationTrackDataParameter</seealso>
    let energySubsystemDeclarationsVerificationTrackDataParameter =
        Prefixed_Name(era, "energySubsystemDeclarationsVerificationTrackDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:energySubsystemObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Energy subsystem"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/energySubsystemObjParameter">http://data.europa.eu/949/energySubsystemObjParameter</seealso>
    let energySubsystemObjParameter =
        Prefixed_Name(era, "energySubsystemObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:energySupplyMaxPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum power (to be indicated for each energy supply system the vehicle is equipped for), given in kW."</para>
    /// labels<para>"Energy supply max power"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/energySupplyMaxPower">http://data.europa.eu/949/energySupplyMaxPower</seealso>
    let energySupplyMaxPower =
        Prefixed_Name(era, "energySupplyMaxPower") |> PrefixedName

    /// <summary>
    ///   <para>era:energySupplySystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indication of the traction supply system (nominal voltage and frequency)."</para>
    /// labels<para>"Energy supply system (Voltage and frequency)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/energySupplySystem">http://data.europa.eu/949/energySupplySystem</seealso>
    let energySupplySystem = Prefixed_Name(era, "energySupplySystem") |> PrefixedName

    /// <summary>
    ///   <para>era:energySupplySystemTSICompliant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication if the traction supply system (nominal voltage and frequency) is fully compliant with TSI."</para>
    /// labels<para>"Energy supply system TSI compliant"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/energySupplySystemTSICompliant">http://data.europa.eu/949/energySupplySystemTSICompliant</seealso>
    let energySupplySystemTSICompliant =
        Prefixed_Name(era, "energySupplySystemTSICompliant") |> PrefixedName

    /// <summary>
    ///   <para>era:eratvIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Index code used in the original definition of a parameter in ERATV."</para>
    /// labels<para>"ERATV index"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/eratvIndex">http://data.europa.eu/949/eratvIndex</seealso>
    let eratvIndex = Prefixed_Name(era, "eratvIndex") |> PrefixedName

    /// <summary>
    ///   <para>era:errorCorrectionsOnboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"List of unacceptable errors impacting the IM network that are required to be solved in the on-board according to the TSI CCS point 7.2.10.3 specification maintenance point (ETCS, GSM-R and/or ATO). An additional parameter (era:errorCorrectionsOnboardExplanation) must document if a non-implemented CR has been accepted by the IM."</para>
    /// labels<para>"Error corrections required for the on-board ETCS, GSM-R and/or ATO function"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/errorCorrectionsOnboard">http://data.europa.eu/949/errorCorrectionsOnboard</seealso>
    let errorCorrectionsOnboard =
        Prefixed_Name(era, "errorCorrectionsOnboard") |> PrefixedName

    /// <summary>
    ///   <para>era:errorCorrectionsOnboardExplanation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Explanation on why a mandatory onboard CR required to be solved in the on-board (ETCS, GSM-R and/or ATO) was accepted by the IM."</para>
    /// labels<para>"Reasons for Error corrections required, but accepted by the IM for the on-board ETCS, GSM-R and/or ATO function"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/errorCorrectionsOnboardExplanation">http://data.europa.eu/949/errorCorrectionsOnboardExplanation</seealso>
    let errorCorrectionsOnboardExplanation =
        Prefixed_Name(era, "errorCorrectionsOnboardExplanation") |> PrefixedName

    /// <summary>
    ///   <para>era:ertmsErrorCorrectionsOnBoard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"(Deprecated) ERTMS error corrections required for the on-board."</para></remarks>
    /// <seealso href="http://data.europa.eu/949/ertmsErrorCorrectionsOnBoard">http://data.europa.eu/949/ertmsErrorCorrectionsOnBoard</seealso>
    let ertmsErrorCorrectionsOnBoard =
        Prefixed_Name(era, "ertmsErrorCorrectionsOnBoard") |> PrefixedName

    /// <summary>
    ///   <para>era:etcs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"European Train Control System (ETCS) application level supported by the track side equipment."</para>
    /// labels<para>"TSI compliant train protection system (ETCS)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcs">http://data.europa.eu/949/etcs</seealso>
    let etcs = Prefixed_Name(era, "etcs") |> PrefixedName
    /// <summary>
    ///   <para>era:etcsBaseline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"ETCS baseline installed lineside."</para>
    /// labels<para>"ETCS baseline"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsBaseline">http://data.europa.eu/949/etcsBaseline</seealso>
    let etcsBaseline = Prefixed_Name(era, "etcsBaseline") |> PrefixedName
    /// <summary>
    ///   <para>era:etcsDataCommApp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Data communication application for ETCS implementation."</para>
    /// labels<para>"ETCS data communication application"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsDataCommApp">http://data.europa.eu/949/etcsDataCommApp</seealso>
    let etcsDataCommApp = Prefixed_Name(era, "etcsDataCommApp") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsDegradedSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ERTMS / ETCS application level for degraded situation related to the track side equipment."</para>
    /// labels<para>"ETCS level for degraded situation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsDegradedSituation">http://data.europa.eu/949/etcsDegradedSituation</seealso>
    let etcsDegradedSituation =
        Prefixed_Name(era, "etcsDegradedSituation") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsEquipmentOnBoardLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ETCS equipment on-board and its level."</para>
    /// labels<para>"ETCS equipment level"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsEquipmentOnBoardLevel">http://data.europa.eu/949/etcsEquipmentOnBoardLevel</seealso>
    let etcsEquipmentOnBoardLevel =
        Prefixed_Name(era, "etcsEquipmentOnBoardLevel") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsErrorCorrectionsOnboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"(Deprecated) ETCS error corrections required for the on-board."</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsErrorCorrectionsOnboard">http://data.europa.eu/949/etcsErrorCorrectionsOnboard</seealso>
    let etcsErrorCorrectionsOnboard =
        Prefixed_Name(era, "etcsErrorCorrectionsOnboard") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsImplementsLevelCrossingProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"If the trackside does not implement any solution to cover non-protected LXs (which are normally protected by means of a technical system), then drivers will be required to comply with instructions received from other sources"</para>
    /// labels<para>"ETCS trackside implements level crossing procedure or an equivalent solution"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsImplementsLevelCrossingProcedure">http://data.europa.eu/949/etcsImplementsLevelCrossingProcedure</seealso>
    let etcsImplementsLevelCrossingProcedure =
        Prefixed_Name(era, "etcsImplementsLevelCrossingProcedure") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsInfill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information about installed trackside equipment capable to transmit infill information by loop or Global System for Mobile communications for Railways (GSM-R) for level 1 installations."</para>
    /// labels<para>"ETCS infill installed line-side"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsInfill">http://data.europa.eu/949/etcsInfill</seealso>
    let etcsInfill = Prefixed_Name(era, "etcsInfill") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsInfillLineAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication whether infill is required to access the line for safety reasons."</para>
    /// labels<para>"ETCS infill necessary for line access"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsInfillLineAccess">http://data.europa.eu/949/etcsInfillLineAccess</seealso>
    let etcsInfillLineAccess =
        Prefixed_Name(era, "etcsInfillLineAccess") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsLevelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"ETCS application level related to the track side equipment."</para>
    /// labels<para>"European Train Control System (ETCS) level"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsLevelType">http://data.europa.eu/949/etcsLevelType</seealso>
    let etcsLevelType = Prefixed_Name(era, "etcsLevelType") |> PrefixedName
    /// <summary>
    ///   <para>era:etcsMVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"ETCS M_version according to the specification referenced in Appendix A-1, index [C], SRS 7.5.1.9."</para>
    /// labels<para>"ETCS M_version"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsMVersion">http://data.europa.eu/949/etcsMVersion</seealso>
    let etcsMVersion = Prefixed_Name(era, "etcsMVersion") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsNationalApplications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"ETCS national applications implemented (NID_XUSER of Packet 44)."</para>
    /// labels<para>"ETCS national applications"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsNationalApplications">http://data.europa.eu/949/etcsNationalApplications</seealso>
    let etcsNationalApplications =
        Prefixed_Name(era, "etcsNationalApplications") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsNationalPacket44</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication whether data for national applications is transmitted between track and train."</para>
    /// labels<para>"ETCS national packet 44 application implemented"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsNationalPacket44">http://data.europa.eu/949/etcsNationalPacket44</seealso>
    let etcsNationalPacket44 =
        Prefixed_Name(era, "etcsNationalPacket44") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsNationalPacket44Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication whether data for national applications is transmitted between track and train."</para>
    /// labels<para>"ETCS national packet 44 application implemented"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsNationalPacket44Function">http://data.europa.eu/949/etcsNationalPacket44Function</seealso>
    let etcsNationalPacket44Function =
        Prefixed_Name(era, "etcsNationalPacket44Function") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsNationalValuesDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"ETCS National Values"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsNationalValuesDataParameter">http://data.europa.eu/949/etcsNationalValuesDataParameter</seealso>
    let etcsNationalValuesDataParameter =
        Prefixed_Name(era, "etcsNationalValuesDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsNationalValuesObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ETCS National Values"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsNationalValuesObjParameter">http://data.europa.eu/949/etcsNationalValuesObjParameter</seealso>
    let etcsNationalValuesObjParameter =
        Prefixed_Name(era, "etcsNationalValuesObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsOnBoardImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"ETCS on-board implementation."</para>
    /// labels<para>"ETCS on-board implementation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsOnBoardImplementation">http://data.europa.eu/949/etcsOnBoardImplementation</seealso>
    let etcsOnBoardImplementation =
        Prefixed_Name(era, "etcsOnBoardImplementation") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsOptionalFunctions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. Optional ETCS functions which might improve operation on the line."</para>
    /// labels<para>"ETCS optional functions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsOptionalFunctions">http://data.europa.eu/949/etcsOptionalFunctions</seealso>
    let etcsOptionalFunctions =
        Prefixed_Name(era, "etcsOptionalFunctions") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsRestrictionsConditionsDoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of the document where restrictions or conditions due to partial compliance with the TSI CCS are described."</para>
    /// labels<para>"document with operating restrictions or conditions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsRestrictionsConditionsDoc">http://data.europa.eu/949/etcsRestrictionsConditionsDoc</seealso>
    let etcsRestrictionsConditionsDoc =
        Prefixed_Name(era, "etcsRestrictionsConditionsDoc") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsSystemCompatibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"ETCS requirements used for demonstrating technical compatibility."</para>
    /// labels<para>"ETCS system compatibility"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsSystemCompatibility">http://data.europa.eu/949/etcsSystemCompatibility</seealso>
    let etcsSystemCompatibility =
        Prefixed_Name(era, "etcsSystemCompatibility") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsSystemFunctionalitiesNextFiveYears</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"(Deprecated) List of ETCS system version 2.2 or 3.0 functionalities to be required in the next 5 years according to TSI CCS point 6.1.1.2 and Appendix G"</para>
    /// labels<para>"ETCS system version 2.2 or 3.0 functionalities to be required in the next 5 years"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsSystemFunctionalitiesNextFiveYears">http://data.europa.eu/949/etcsSystemFunctionalitiesNextFiveYears</seealso>
    let etcsSystemFunctionalitiesNextFiveYears =
        Prefixed_Name(era, "etcsSystemFunctionalitiesNextFiveYears") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsTransmitsTrackConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"If the trackside does not provide Track Conditions, the driver will need to be informed about such conditions via alternative methods.
    /// According to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"Is the ETCS trackside engineered to transmit Track Conditions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsTransmitsTrackConditions">http://data.europa.eu/949/etcsTransmitsTrackConditions</seealso>
    let etcsTransmitsTrackConditions =
        Prefixed_Name(era, "etcsTransmitsTrackConditions") |> PrefixedName

    /// <summary>
    ///   <para>era:etcsTransmittedTrackConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Transmittable track conditions by the CCSSubsystem, according to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"Track conditions which can be transmitted"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/etcsTransmittedTrackConditions">http://data.europa.eu/949/etcsTransmittedTrackConditions</seealso>
    let etcsTransmittedTrackConditions =
        Prefixed_Name(era, "etcsTransmittedTrackConditions") |> PrefixedName

    /// <summary>
    ///   <para>era:europeanTransportCorridor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication of which European Transport Corridor the element belongs to."</para>
    /// labels<para>"European transport corridor"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/europeanTransportCorridor">http://data.europa.eu/949/europeanTransportCorridor</seealso>
    let europeanTransportCorridor =
        Prefixed_Name(era, "europeanTransportCorridor") |> PrefixedName

    /// <summary>
    ///   <para>era:exemptSpecialVehiclesFromATO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether special vehicles are exempted from the need to install ATO (Automatic Train Operation) for this infrastructure element."</para>
    /// labels<para>"exempt special vehicles from ATO"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/exemptSpecialVehiclesFromATO">http://data.europa.eu/949/exemptSpecialVehiclesFromATO</seealso>
    let exemptSpecialVehiclesFromATO =
        Prefixed_Name(era, "exemptSpecialVehiclesFromATO") |> PrefixedName

    /// <summary>
    ///   <para>era:exemptSpecialVehiclesFromETCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether special vehicles are exempted from the need to install ETCS (European Train Control System) for this infrastructure element."</para>
    /// labels<para>"exempt special vehicles from ETCS"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/exemptSpecialVehiclesFromETCS">http://data.europa.eu/949/exemptSpecialVehiclesFromETCS</seealso>
    let exemptSpecialVehiclesFromETCS =
        Prefixed_Name(era, "exemptSpecialVehiclesFromETCS") |> PrefixedName

    /// <summary>
    ///   <para>era:exemptSpecialVehiclesFromRMR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether special vehicles are exempted from the need to install RMR (Railway Mobile Radio) for this infrastructure element."</para>
    /// labels<para>"exempt special vehicles from RMR"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/exemptSpecialVehiclesFromRMR">http://data.europa.eu/949/exemptSpecialVehiclesFromRMR</seealso>
    let exemptSpecialVehiclesFromRMR =
        Prefixed_Name(era, "exemptSpecialVehiclesFromRMR") |> PrefixedName

    /// <summary>
    ///   <para>era:existBridgeWindRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indicate, if there are any wind restrictions for a bridge."</para>
    /// labels<para>"Existence of bridge wind restriction"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/existBridgeWindRestriction">http://data.europa.eu/949/existBridgeWindRestriction</seealso>
    let existBridgeWindRestriction =
        Prefixed_Name(era, "existBridgeWindRestriction") |> PrefixedName

    /// <summary>
    ///   <para>era:existOpeningHoursLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicate, if there are any opening hours of the section of a line or Tunnel or Bridge."</para>
    /// labels<para>"Existence of opening hours limitation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/existOpeningHoursLimitation">http://data.europa.eu/949/existOpeningHoursLimitation</seealso>
    let existOpeningHoursLimitation =
        Prefixed_Name(era, "existOpeningHoursLimitation") |> PrefixedName

    /// <summary>
    ///   <para>era:existRestrictedDangerousGood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indicate, if there are any limits on transportation of dangerous goods."</para>
    /// labels<para>"Existence of restricted dangerous goods"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/existRestrictedDangerousGood">http://data.europa.eu/949/existRestrictedDangerousGood</seealso>
    let existRestrictedDangerousGood =
        Prefixed_Name(era, "existRestrictedDangerousGood") |> PrefixedName

    /// <summary>
    ///   <para>era:existRestrictedPeriodOfTimeDangerousGood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicate, if there are any limits on specific time of a day for transport of dangerous goods."</para>
    /// labels<para>"Existence of restricted periods of time for dangerous goods transportation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/existRestrictedPeriodOfTimeDangerousGood">http://data.europa.eu/949/existRestrictedPeriodOfTimeDangerousGood</seealso>
    let existRestrictedPeriodOfTimeDangerousGood =
        Prefixed_Name(era, "existRestrictedPeriodOfTimeDangerousGood") |> PrefixedName

    /// <summary>
    ///   <para>era:existRestrictedTypeOfVehicleOfTunnel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicate, if there are any limits on specific type of vehicle in the tunnel."</para>
    /// labels<para>"Existence of restricted type of vehicle in tunnel"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/existRestrictedTypeOfVehicleOfTunnel">http://data.europa.eu/949/existRestrictedTypeOfVehicleOfTunnel</seealso>
    let existRestrictedTypeOfVehicleOfTunnel =
        Prefixed_Name(era, "existRestrictedTypeOfVehicleOfTunnel") |> PrefixedName

    /// <summary>
    ///   <para>era:existTrainExclusionOfSimultaneity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indicate, if passenger and freight trains meeting together in a tunnel is allowed"</para>
    /// labels<para>"Exclusion of simultaneity"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/existTrainExclusionOfSimultaneity">http://data.europa.eu/949/existTrainExclusionOfSimultaneity</seealso>
    let existTrainExclusionOfSimultaneity =
        Prefixed_Name(era, "existTrainExclusionOfSimultaneity") |> PrefixedName

    /// <summary>
    ///   <para>era:existenceOfIndustrialRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication that the full section of line (or a part of it) it is identified by the Infrastructure Managers (and communicated to the RU) where drivers are not supposed to get off the locomotive."</para>
    /// labels<para>"Industrial risks — locations where it is dangerous for the driver to step out"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/existenceOfIndustrialRisk">http://data.europa.eu/949/existenceOfIndustrialRisk</seealso>
    let existenceOfIndustrialRisk =
        Prefixed_Name(era, "existenceOfIndustrialRisk") |> PrefixedName

    /// <summary>
    ///   <para>era:ferromagneticWheelMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Wheel material is ferromagnetic."</para>
    /// labels<para>"Ferromagnetic wheel material"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/ferromagneticWheelMaterial">http://data.europa.eu/949/ferromagneticWheelMaterial</seealso>
    let ferromagneticWheelMaterial =
        Prefixed_Name(era, "ferromagneticWheelMaterial") |> PrefixedName

    /// <summary>
    ///   <para>era:fireSafetyCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Fire safety category for tunnels."</para>
    /// labels<para>"Fire safety category"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/fireSafetyCategory">http://data.europa.eu/949/fireSafetyCategory</seealso>
    let fireSafetyCategory = Prefixed_Name(era, "fireSafetyCategory") |> PrefixedName
    /// <summary>
    ///   <para>era:fixedSeats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of fixed seats."</para>
    /// labels<para>"Fixed seats"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/fixedSeats">http://data.europa.eu/949/fixedSeats</seealso>
    let fixedSeats = Prefixed_Name(era, "fixedSeats") |> PrefixedName
    /// <summary>
    ///   <para>era:flangeLubeForbidden</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication whether the use of on-board device for flange lubrication is forbidden."</para>
    /// labels<para>"Use of flange lubrication forbidden"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/flangeLubeForbidden">http://data.europa.eu/949/flangeLubeForbidden</seealso>
    let flangeLubeForbidden = Prefixed_Name(era, "flangeLubeForbidden") |> PrefixedName
    /// <summary>
    ///   <para>era:flangeLubeRules</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication whether rules for activation or deactivation of flange lubrication exist."</para>
    /// labels<para>"Existence of rules on on-board flange lubrication"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/flangeLubeRules">http://data.europa.eu/949/flangeLubeRules</seealso>
    let flangeLubeRules = Prefixed_Name(era, "flangeLubeRules") |> PrefixedName

    /// <summary>
    ///   <para>era:flangeLubricationFitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates if the vehicle type is fitted for flange lubrication."</para>
    /// labels<para>"Flange lubrication fitted"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/flangeLubricationFitted">http://data.europa.eu/949/flangeLubricationFitted</seealso>
    let flangeLubricationFitted =
        Prefixed_Name(era, "flangeLubricationFitted") |> PrefixedName

    /// <summary>
    ///   <para>era:formatNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This property is used to annotate in human readable the format of parameters"</para>
    /// labels<para>"format note"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/formatNote">http://data.europa.eu/949/formatNote</seealso>
    let formatNote = Prefixed_Name(era, "formatNote") |> PrefixedName
    /// <summary>
    ///   <para>era:freightCorridor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication whether the line is designated to a Railway Freight Corridor."</para>
    /// labels<para>"Part of a Railway Freight Corridor"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/freightCorridor">http://data.europa.eu/949/freightCorridor</seealso>
    let freightCorridor = Prefixed_Name(era, "freightCorridor") |> PrefixedName
    /// <summary>
    ///   <para>era:freightFlag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Freight possible flag attached to a Primary Location."</para>
    /// labels<para>"freight flag"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/freightFlag">http://data.europa.eu/949/freightFlag</seealso>
    let freightFlag = Prefixed_Name(era, "freightFlag") |> PrefixedName

    /// <summary>
    ///   <para>era:frenchTrainDetectionSystemLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specific for route compatibility check on French network. The reason for deprecation is because of replacement by a class, an object property and two datatype properties. The reason is that the property is composed of two values: A boolean [Y/N] and  a number N is between 1 and 8."</para>
    /// labels<para>"Section with train detection limitation, only for the French network"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/frenchTrainDetectionSystemLimitation">http://data.europa.eu/949/frenchTrainDetectionSystemLimitation</seealso>
    let frenchTrainDetectionSystemLimitation =
        Prefixed_Name(era, "frenchTrainDetectionSystemLimitation") |> PrefixedName

    /// <summary>
    ///   <para>era:frenchTrainDetectionSystemLimitationApplicable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the section with train detection limitation that indicates if it is applicable. Only for the French network."</para>
    /// labels<para>"Section with train detection limitation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/frenchTrainDetectionSystemLimitationApplicable">http://data.europa.eu/949/frenchTrainDetectionSystemLimitationApplicable</seealso>
    let frenchTrainDetectionSystemLimitationApplicable =
        Prefixed_Name(era, "frenchTrainDetectionSystemLimitationApplicable") |> PrefixedName

    /// <summary>
    ///   <para>era:frenchTrainDetectionSystemLimitationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Part of the section with train detection limitation that indicates the type of train detection limitation.
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
    /// [8] 45-second delay for specific announcement reset devices"</para>
    /// labels<para>"Section with train detection limitation number, only for French network"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/frenchTrainDetectionSystemLimitationNumber">http://data.europa.eu/949/frenchTrainDetectionSystemLimitationNumber</seealso>
    let frenchTrainDetectionSystemLimitationNumber =
        Prefixed_Name(era, "frenchTrainDetectionSystemLimitationNumber") |> PrefixedName

    /// <summary>
    ///   <para>era:frequencyBandsForDetection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Bands of the frequency management of the train detection systems as defined in the TSI CCS, and in the specific cases or technical documents referred to in Article 13 of TSI CCS when they are available."</para>
    /// labels<para>"Frequency bands for detection"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/frequencyBandsForDetection">http://data.europa.eu/949/frequencyBandsForDetection</seealso>
    let frequencyBandsForDetection =
        Prefixed_Name(era, "frequencyBandsForDetection") |> PrefixedName

    /// <summary>
    ///   <para>era:gaugingCheckLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Location of particular points requiring specific checks due to deviations from gauging referred to in parameter "Gauging""</para>
    /// labels<para>"Railway location of particular points requiring specific checks"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gaugingCheckLocation">http://data.europa.eu/949/gaugingCheckLocation</seealso>
    let gaugingCheckLocation =
        Prefixed_Name(era, "gaugingCheckLocation") |> PrefixedName

    /// <summary>
    ///   <para>era:gaugingProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Gauges as defined in European standard or other local gauges, including lower or upper part."</para>
    /// labels<para>"Gauging"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gaugingProfile">http://data.europa.eu/949/gaugingProfile</seealso>
    let gaugingProfile = Prefixed_Name(era, "gaugingProfile") |> PrefixedName

    /// <summary>
    ///   <para>era:gaugingTransversalDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Electronic document available from the IM stored by the Agency with the transversal section of the particular points requiring specific checks due to deviations from gauging referred to in parameter "Gauging". Where relevant, guidance for the check with the particular point may be attached to the document with the transversal section."</para>
    /// labels<para>"Document with the transversal section of the particular points requiring specific checks"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gaugingTransversalDocument">http://data.europa.eu/949/gaugingTransversalDocument</seealso>
    let gaugingTransversalDocument =
        Prefixed_Name(era, "gaugingTransversalDocument") |> PrefixedName

    /// <summary>
    ///   <para>era:gprsForETCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indication if GPRS can be used for ETCS"</para>
    /// labels<para>"GPRS for ETCS"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gprsForETCS">http://data.europa.eu/949/gprsForETCS</seealso>
    let gprsForETCS = Prefixed_Name(era, "gprsForETCS") |> PrefixedName

    /// <summary>
    ///   <para>era:gprsImplementationArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of the area in which GPRS can be used for ETCS, expressed as a list of GPRS-enabled RBCs."</para>
    /// labels<para>"Area of implementation of GPRS"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gprsImplementationArea">http://data.europa.eu/949/gprsImplementationArea</seealso>
    let gprsImplementationArea =
        Prefixed_Name(era, "gprsImplementationArea") |> PrefixedName

    /// <summary>
    ///   <para>era:gradient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Maximum value of the gradient for stabling tracks expressed in millimetres per metre."</para>
    /// labels<para>"Gradient for stabling tracks"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gradient">http://data.europa.eu/949/gradient</seealso>
    let gradient = Prefixed_Name(era, "gradient") |> PrefixedName
    /// <summary>
    ///   <para>era:gradientProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Sequence of gradient values and locations of change in gradient"</para>
    /// labels<para>"Gradient profile"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gradientProfile">http://data.europa.eu/949/gradientProfile</seealso>
    let gradientProfile = Prefixed_Name(era, "gradientProfile") |> PrefixedName
    /// <summary>
    ///   <para>era:gsmRActiveMobiles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Number of simultaneous communication session on board for ETCS level 2 required for a smooth running of the train. This relates to the radio block centre (RBC) handling of communication sessions. Not safety critical and no matter of interoperability."</para>
    /// labels<para>"Number of active GSM-R mobiles (EDOR) or simultaneous communication session on board for ETCS level 2 needed to perform radio block centre handovers without having an operational disruption"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gsmRActiveMobiles">http://data.europa.eu/949/gsmRActiveMobiles</seealso>
    let gsmRActiveMobiles = Prefixed_Name(era, "gsmRActiveMobiles") |> PrefixedName
    /// <summary>
    ///   <para>era:gsmRAdditionalInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Any additional information on network characteristics or corresponding document available from the IM and stored by the Agency, e.g.; interference level, leading to the recommendation of additional on-board protection."</para>
    /// labels<para>"Additional information on network characteristics"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gsmRAdditionalInfo">http://data.europa.eu/949/gsmRAdditionalInfo</seealso>
    let gsmRAdditionalInfo = Prefixed_Name(era, "gsmRAdditionalInfo") |> PrefixedName
    /// <summary>
    ///   <para>era:gsmRNoCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indication if there is no GSMR coverage"</para>
    /// labels<para>"No GSMR coverage"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gsmRNoCoverage">http://data.europa.eu/949/gsmRNoCoverage</seealso>
    let gsmRNoCoverage = Prefixed_Name(era, "gsmRNoCoverage") |> PrefixedName

    /// <summary>
    ///   <para>era:gsmROptionalFunctions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Use of optional GSM-R functions which might improve operation on the line. They are for information only and not for network access criteria."</para>
    /// labels<para>"Optional GSM-R functions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gsmROptionalFunctions">http://data.europa.eu/949/gsmROptionalFunctions</seealso>
    let gsmROptionalFunctions =
        Prefixed_Name(era, "gsmROptionalFunctions") |> PrefixedName

    /// <summary>
    ///   <para>era:gsmRRadioDataCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"GSM-R Radio Data communication on board and its Baseline."</para>
    /// labels<para>"GSM-R radio data communication"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gsmRRadioDataCommunication">http://data.europa.eu/949/gsmRRadioDataCommunication</seealso>
    let gsmRRadioDataCommunication =
        Prefixed_Name(era, "gsmRRadioDataCommunication") |> PrefixedName

    /// <summary>
    ///   <para>era:gsmRSetsInDrivingCab</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of GSM-R mobile sets in driving cab for data transmission."</para>
    /// labels<para>"GSM-R sets in driving cab"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gsmRSetsInDrivingCab">http://data.europa.eu/949/gsmRSetsInDrivingCab</seealso>
    let gsmRSetsInDrivingCab =
        Prefixed_Name(era, "gsmRSetsInDrivingCab") |> PrefixedName

    /// <summary>
    ///   <para>era:gsmRVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"GSM-R functional requirements specification and system requirements specification in accordance with the specification respectively referenced in Appendix A-1, index [E] and index [F], version number installed lineside."</para>
    /// labels<para>"GSM-R version"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gsmRVersion">http://data.europa.eu/949/gsmRVersion</seealso>
    let gsmRVersion = Prefixed_Name(era, "gsmRVersion") |> PrefixedName

    /// <summary>
    ///   <para>era:gsmrConstraintsOperateOnlyInCircuitSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"These constraints, where applicable, are meant to manage the limited number of circuit-switched radio connections that can be handled simultaneously by a Radio Block Center."</para>
    /// labels<para>"Specific constraints imposed by the GSM-R network operator on ETCS on-board units only able to operate in circuit-switch"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gsmrConstraintsOperateOnlyInCircuitSwitch">http://data.europa.eu/949/gsmrConstraintsOperateOnlyInCircuitSwitch</seealso>
    let gsmrConstraintsOperateOnlyInCircuitSwitch =
        Prefixed_Name(era, "gsmrConstraintsOperateOnlyInCircuitSwitch") |> PrefixedName

    /// <summary>
    ///   <para>era:gsmrErrorCorrectionsOnboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"List of unacceptable errors impacting the IM network that are required to be solved in the on-board according to the CCS TSI point 7.2.10.3 specification maintenance point.
    /// The reason for deprecation is that this parameter does not appear in the latest legal text."</para>
    /// labels<para>"(Deprecated) GSM-R error corrections required for the on-board"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gsmrErrorCorrectionsOnboard">http://data.europa.eu/949/gsmrErrorCorrectionsOnboard</seealso>
    let gsmrErrorCorrectionsOnboard =
        Prefixed_Name(era, "gsmrErrorCorrectionsOnboard") |> PrefixedName

    /// <summary>
    ///   <para>era:gsmrForcedDeregistrationFunctionalNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This feature will determine the applicable operational rules for drivers and signallers when dealing with cab radios registered under wrong numbers."</para>
    /// labels<para>"GSM-R network is configured to allow forced de-registration of a functional number by another driver"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gsmrForcedDeregistrationFunctionalNumber">http://data.europa.eu/949/gsmrForcedDeregistrationFunctionalNumber</seealso>
    let gsmrForcedDeregistrationFunctionalNumber =
        Prefixed_Name(era, "gsmrForcedDeregistrationFunctionalNumber") |> PrefixedName

    /// <summary>
    ///   <para>era:gsmrNetworkCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Name of the own GSM-R network and list of GSM-R networks which are covered by a roaming agreement (for CS services)."</para>
    /// labels<para>"GSM-R networks covered by a roaming agreement"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/gsmrNetworkCoverage">http://data.europa.eu/949/gsmrNetworkCoverage</seealso>
    let gsmrNetworkCoverage = Prefixed_Name(era, "gsmrNetworkCoverage") |> PrefixedName
    /// <summary>
    ///   <para>era:handoverPointFlag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Handover point flag attached to a Primary location."</para>
    /// labels<para>"handover point flag"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/handoverPointFlag">http://data.europa.eu/949/handoverPointFlag</seealso>
    let handoverPointFlag = Prefixed_Name(era, "handoverPointFlag") |> PrefixedName
    /// <summary>
    ///   <para>era:hasAbstraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that links a physical entity with its topological abstraction representation."</para>
    /// labels<para>"Has abstraction"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasAbstraction">http://data.europa.eu/949/hasAbstraction</seealso>
    let hasAbstraction = Prefixed_Name(era, "hasAbstraction") |> PrefixedName

    /// <summary>
    ///   <para>era:hasAdditionalBrakingInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Availability by the IM of additional information as defined in point (2) of point 4.2.2.6.2 of Regulation (EU) 2023/1693 - TSI OPE"</para>
    /// labels<para>"Availability by the IM of additional information"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasAdditionalBrakingInformation">http://data.europa.eu/949/hasAdditionalBrakingInformation</seealso>
    let hasAdditionalBrakingInformation =
        Prefixed_Name(era, "hasAdditionalBrakingInformation") |> PrefixedName

    /// <summary>
    ///   <para>era:hasAutomaticDroppingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Automatic dropping device (ADD) fitted (to be indicated for each energy supply system the vehicle is equipped for)."</para>
    /// labels<para>"Has automatic dropping device"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasAutomaticDroppingDevice">http://data.europa.eu/949/hasAutomaticDroppingDevice</seealso>
    let hasAutomaticDroppingDevice =
        Prefixed_Name(era, "hasAutomaticDroppingDevice") |> PrefixedName

    /// <summary>
    ///   <para>era:hasBallast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies whether track construction is with sleepers embedded in ballast or not."</para>
    /// labels<para>"Existence of ballast"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasBallast">http://data.europa.eu/949/hasBallast</seealso>
    let hasBallast = Prefixed_Name(era, "hasBallast") |> PrefixedName
    /// <summary>
    ///   <para>era:hasBridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"Has bridge"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasBridge">http://data.europa.eu/949/hasBridge</seealso>
    let hasBridge = Prefixed_Name(era, "hasBridge") |> PrefixedName

    /// <summary>
    ///   <para>era:hasCantDefficiencyCompensation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Vehicle equipped with a cant deficiency compensation system (tilting vehicle)."</para>
    /// labels<para>"Has cant deficiency compensation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasCantDefficiencyCompensation">http://data.europa.eu/949/hasCantDefficiencyCompensation</seealso>
    let hasCantDefficiencyCompensation =
        Prefixed_Name(era, "hasCantDefficiencyCompensation") |> PrefixedName

    /// <summary>
    ///   <para>era:hasConnectingIM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indicates whether any neighbouring section of line belongs to different Infrastructure Manager"</para>
    /// labels<para>"Connecting Infrastructure Manager"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasConnectingIM">http://data.europa.eu/949/hasConnectingIM</seealso>
    let hasConnectingIM = Prefixed_Name(era, "hasConnectingIM") |> PrefixedName

    /// <summary>
    ///   <para>era:hasCurrentLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Electric units equipped with power or current limitation function."</para>
    /// labels<para>"Has current limitation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasCurrentLimitation">http://data.europa.eu/949/hasCurrentLimitation</seealso>
    let hasCurrentLimitation =
        Prefixed_Name(era, "hasCurrentLimitation") |> PrefixedName

    /// <summary>
    ///   <para>era:hasETCSRestrictionsConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication whether restrictions or conditions due to partial compliance with the TSI CCS exist."</para>
    /// labels<para>"Existence of operating restrictions or conditions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasETCSRestrictionsConditions">http://data.europa.eu/949/hasETCSRestrictionsConditions</seealso>
    let hasETCSRestrictionsConditions =
        Prefixed_Name(era, "hasETCSRestrictionsConditions") |> PrefixedName

    /// <summary>
    ///   <para>era:hasElectricShoreSupply</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication whether exists an installation of electric shore supply (fixed installation for servicing trains)."</para>
    /// labels<para>"Existence of electric shore supply"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasElectricShoreSupply">http://data.europa.eu/949/hasElectricShoreSupply</seealso>
    let hasElectricShoreSupply =
        Prefixed_Name(era, "hasElectricShoreSupply") |> PrefixedName

    /// <summary>
    ///   <para>era:hasEmergencyPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication whether emergency plan exists."</para>
    /// labels<para>"Existence of emergency plan"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasEmergencyPlan">http://data.europa.eu/949/hasEmergencyPlan</seealso>
    let hasEmergencyPlan = Prefixed_Name(era, "hasEmergencyPlan") |> PrefixedName

    /// <summary>
    ///   <para>era:hasEtcsNationalPacket44</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication whether data for national packet 44 applications is transmitted between track and train."</para>
    /// labels<para>"has ETCS national packet 44 application implemented"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasEtcsNationalPacket44">http://data.europa.eu/949/hasEtcsNationalPacket44</seealso>
    let hasEtcsNationalPacket44 =
        Prefixed_Name(era, "hasEtcsNationalPacket44") |> PrefixedName

    /// <summary>
    ///   <para>era:hasEvacuationAndRescuePoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of existence of evacuation and rescue points"</para>
    /// labels<para>"Existence of evacuation and rescue points"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasEvacuationAndRescuePoints">http://data.europa.eu/949/hasEvacuationAndRescuePoints</seealso>
    let hasEvacuationAndRescuePoints =
        Prefixed_Name(era, "hasEvacuationAndRescuePoints") |> PrefixedName

    /// <summary>
    ///   <para>era:hasExternalCleaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication whether exists an installation of external cleaning facility (fixed installation for servicing trains) as defined in TSI INF"</para>
    /// labels<para>"Existence of external cleaning facilities"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasExternalCleaning">http://data.europa.eu/949/hasExternalCleaning</seealso>
    let hasExternalCleaning = Prefixed_Name(era, "hasExternalCleaning") |> PrefixedName

    /// <summary>
    ///   <para>era:hasHotAxleBoxDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Existence of trackside HABD"</para>
    /// labels<para>"Existence of trackside hot axle box detector (HABD)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasHotAxleBoxDetector">http://data.europa.eu/949/hasHotAxleBoxDetector</seealso>
    let hasHotAxleBoxDetector =
        Prefixed_Name(era, "hasHotAxleBoxDetector") |> PrefixedName

    /// <summary>
    ///   <para>era:hasImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that links a topological abstraction entity with its physical representation."</para>
    /// labels<para>"Has implementation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasImplementation">http://data.europa.eu/949/hasImplementation</seealso>
    let hasImplementation = Prefixed_Name(era, "hasImplementation") |> PrefixedName
    /// <summary>
    ///   <para>era:hasLRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the linear referencing system to which the kilometre post is referenced. The linear referencing system is commonly the main railway line and it provides the framework for identifying the post's location along the railway line, using distance measurements rather than geographical coordinates."</para>
    /// labels<para>"has linear referencing system"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasLRS">http://data.europa.eu/949/hasLRS</seealso>
    let hasLRS = Prefixed_Name(era, "hasLRS") |> PrefixedName
    /// <summary>
    ///   <para>era:hasLevelCrossings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication whether level crossings (including pedestrian track crossing) exist on the section of line."</para>
    /// labels<para>"Existence of level crossings"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasLevelCrossings">http://data.europa.eu/949/hasLevelCrossings</seealso>
    let hasLevelCrossings = Prefixed_Name(era, "hasLevelCrossings") |> PrefixedName
    /// <summary>
    ///   <para>era:hasLrsCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the LRS coordinate associated with a topological coordinate."</para>
    /// labels<para>"has line referencing system coordinate"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasLrsCoordinate">http://data.europa.eu/949/hasLrsCoordinate</seealso>
    let hasLrsCoordinate = Prefixed_Name(era, "hasLrsCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>era:hasLubricationDevicePrevention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Possibility of preventing the use of the lubrication device (only if fitted with flange lubrication)."</para>
    /// labels<para>"Has lubrication device prevention"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasLubricationDevicePrevention">http://data.europa.eu/949/hasLubricationDevicePrevention</seealso>
    let hasLubricationDevicePrevention =
        Prefixed_Name(era, "hasLubricationDevicePrevention") |> PrefixedName

    /// <summary>
    ///   <para>era:hasNoiseLevelLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicate, if there are any limits on noise levels."</para>
    /// labels<para>"Has noise level limits"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasNoiseLevelLimit">http://data.europa.eu/949/hasNoiseLevelLimit</seealso>
    let hasNoiseLevelLimit = Prefixed_Name(era, "hasNoiseLevelLimit") |> PrefixedName
    /// <summary>
    ///   <para>era:hasOrganisationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates the Organisation role instance (the role played by an Organisation)  with the specific role in the taxonomy of organisation roles."</para>
    /// labels<para>"has organisation role"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasOrganisationRole">http://data.europa.eu/949/hasOrganisationRole</seealso>
    let hasOrganisationRole = Prefixed_Name(era, "hasOrganisationRole") |> PrefixedName
    /// <summary>
    ///   <para>era:hasOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has orientation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasOrientation">http://data.europa.eu/949/hasOrientation</seealso>
    let hasOrientation = Prefixed_Name(era, "hasOrientation") |> PrefixedName

    /// <summary>
    ///   <para>era:hasOtherTrainProtection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication if other train protection, control and warning systems in normal operation are installed lineside."</para>
    /// labels<para>"Existence of other train protection, control and warning systems installed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasOtherTrainProtection">http://data.europa.eu/949/hasOtherTrainProtection</seealso>
    let hasOtherTrainProtection =
        Prefixed_Name(era, "hasOtherTrainProtection") |> PrefixedName

    /// <summary>
    ///   <para>era:hasParkingBrake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates if a vehicle type has parking brake."</para>
    /// labels<para>"Has parking brake"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasParkingBrake">http://data.europa.eu/949/hasParkingBrake</seealso>
    let hasParkingBrake = Prefixed_Name(era, "hasParkingBrake") |> PrefixedName
    /// <summary>
    ///   <para>era:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Indicates that an infrastructure element is composed of one or more other (distinct) infrastructure elements.
    /// This property is used to represent part-whole relationships between infrastructure elements.
    /// An element cannot be a part of itself."</para>
    /// labels<para>"has part"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasPart">http://data.europa.eu/949/hasPart</seealso>
    let hasPart = Prefixed_Name(era, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>era:hasPhaseSeparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of existence of phase separation and required information."</para>
    /// labels<para>"Phase separation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasPhaseSeparation">http://data.europa.eu/949/hasPhaseSeparation</seealso>
    let hasPhaseSeparation = Prefixed_Name(era, "hasPhaseSeparation") |> PrefixedName

    /// <summary>
    ///   <para>era:hasPlatformCurvature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of the existence of the curvature of the platform."</para>
    /// labels<para>"Curvature of the platform"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasPlatformCurvature">http://data.europa.eu/949/hasPlatformCurvature</seealso>
    let hasPlatformCurvature =
        Prefixed_Name(era, "hasPlatformCurvature") |> PrefixedName

    /// <summary>
    ///   <para>era:hasRefuelling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication whether exists an installation of refuelling (fixed installation for servicing trains) as defined in TSI INF."</para>
    /// labels<para>"Existence of refuelling"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasRefuelling">http://data.europa.eu/949/hasRefuelling</seealso>
    let hasRefuelling = Prefixed_Name(era, "hasRefuelling") |> PrefixedName

    /// <summary>
    ///   <para>era:hasRegenerativeBrake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication whether regenerative braking is permitted or not."</para>
    /// labels<para>"Permission for regenerative braking"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasRegenerativeBrake">http://data.europa.eu/949/hasRegenerativeBrake</seealso>
    let hasRegenerativeBrake =
        Prefixed_Name(era, "hasRegenerativeBrake") |> PrefixedName

    /// <summary>
    ///   <para>era:hasSandRestocking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication whether an installation of sand restocking exists (fixed installation for servicing trains)."</para>
    /// labels<para>"Existence of sand restocking"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasSandRestocking">http://data.europa.eu/949/hasSandRestocking</seealso>
    let hasSandRestocking = Prefixed_Name(era, "hasSandRestocking") |> PrefixedName

    /// <summary>
    ///   <para>era:hasSandingPrevention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Possibility of preventing the use of sanding."</para>
    /// labels<para>"Has sanding prevention"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasSandingPrevention">http://data.europa.eu/949/hasSandingPrevention</seealso>
    let hasSandingPrevention =
        Prefixed_Name(era, "hasSandingPrevention") |> PrefixedName

    /// <summary>
    ///   <para>era:hasSchematicOverviewOPDigitalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The existence of a schematic overview of the operational point in digital form."</para>
    /// labels<para>"Schematic overview of the operational point in digital form"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasSchematicOverviewOPDigitalForm">http://data.europa.eu/949/hasSchematicOverviewOPDigitalForm</seealso>
    let hasSchematicOverviewOPDigitalForm =
        Prefixed_Name(era, "hasSchematicOverviewOPDigitalForm") |> PrefixedName

    /// <summary>
    ///   <para>era:hasSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ordered sequence of topological linear elements which create a linear net reference."</para>
    /// labels<para>"has sequence"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasSequence">http://data.europa.eu/949/hasSequence</seealso>
    let hasSequence = Prefixed_Name(era, "hasSequence") |> PrefixedName

    /// <summary>
    ///   <para>era:hasSevereWeatherConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Climatic conditions on the line are severe according to European standard."</para>
    /// labels<para>"Existence of severe climatic conditions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasSevereWeatherConditions">http://data.europa.eu/949/hasSevereWeatherConditions</seealso>
    let hasSevereWeatherConditions =
        Prefixed_Name(era, "hasSevereWeatherConditions") |> PrefixedName

    /// <summary>
    ///   <para>era:hasShuntingRestrictions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the presence of shunting restrictions."</para>
    /// labels<para>"Has shunting restrictions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasShuntingRestrictions">http://data.europa.eu/949/hasShuntingRestrictions</seealso>
    let hasShuntingRestrictions =
        Prefixed_Name(era, "hasShuntingRestrictions") |> PrefixedName

    /// <summary>
    ///   <para>era:hasSystemSeparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indication of existence of system separation"</para>
    /// labels<para>"System separation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasSystemSeparation">http://data.europa.eu/949/hasSystemSeparation</seealso>
    let hasSystemSeparation = Prefixed_Name(era, "hasSystemSeparation") |> PrefixedName

    /// <summary>
    ///   <para>era:hasTSITrainDetection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication if there is any train detection system installed and fully compliant with the TSI CCS"</para>
    /// labels<para>"Existence of train detection system fully compliant with the TSI"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasTSITrainDetection">http://data.europa.eu/949/hasTSITrainDetection</seealso>
    let hasTSITrainDetection =
        Prefixed_Name(era, "hasTSITrainDetection") |> PrefixedName

    /// <summary>
    ///   <para>era:hasToiletDischarge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication whether exists an installation of toilet discharge (fixed installation for servicing trains) as defined in TSI INF"</para>
    /// labels<para>"Existence of toilet discharge"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasToiletDischarge">http://data.europa.eu/949/hasToiletDischarge</seealso>
    let hasToiletDischarge = Prefixed_Name(era, "hasToiletDischarge") |> PrefixedName
    /// <summary>
    ///   <para>era:hasTopoCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the topological coordinate of a network point reference."</para>
    /// labels<para>"has topological coordinate"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasTopoCoordinate">http://data.europa.eu/949/hasTopoCoordinate</seealso>
    let hasTopoCoordinate = Prefixed_Name(era, "hasTopoCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>era:hasTrainIntegrityConfirmation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of on-board management system about completeness of the train information."</para>
    /// labels<para>"Has train integrity confirmation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasTrainIntegrityConfirmation">http://data.europa.eu/949/hasTrainIntegrityConfirmation</seealso>
    let hasTrainIntegrityConfirmation =
        Prefixed_Name(era, "hasTrainIntegrityConfirmation") |> PrefixedName

    /// <summary>
    ///   <para>era:hasWalkway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of existence of walkways"</para>
    /// labels<para>"Existence of walkways"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasWalkway">http://data.europa.eu/949/hasWalkway</seealso>
    let hasWalkway = Prefixed_Name(era, "hasWalkway") |> PrefixedName
    /// <summary>
    ///   <para>era:hasWaterRestocking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indication whether exists an installation of water restocking (fixed installation for servicing trains) as defined in TSI INF"</para>
    /// labels<para>"Existence of water restocking"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasWaterRestocking">http://data.europa.eu/949/hasWaterRestocking</seealso>
    let hasWaterRestocking = Prefixed_Name(era, "hasWaterRestocking") |> PrefixedName

    /// <summary>
    ///   <para>era:hasWheelSlideProtectionSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the presence of a wheel slide protection system."</para>
    /// labels<para>"Has wheel slide protection system"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hasWheelSlideProtectionSystem">http://data.europa.eu/949/hasWheelSlideProtectionSystem</seealso>
    let hasWheelSlideProtectionSystem =
        Prefixed_Name(era, "hasWheelSlideProtectionSystem") |> PrefixedName

    /// <summary>
    ///   <para>era:hashSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This property indicates for each infrastructure element, the source, i.e. the identifier  or key that was input to the hash function in order to generate the hash value that is part of the hash URI."</para>
    /// labels<para>"Hash source"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hashSource">http://data.europa.eu/949/hashSource</seealso>
    let hashSource = Prefixed_Name(era, "hashSource") |> PrefixedName

    /// <summary>
    ///   <para>era:healthSafetyAndEnvironmentDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Health, safety and environment"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/healthSafetyAndEnvironmentDataParameter">http://data.europa.eu/949/healthSafetyAndEnvironmentDataParameter</seealso>
    let healthSafetyAndEnvironmentDataParameter =
        Prefixed_Name(era, "healthSafetyAndEnvironmentDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:healthSafetyAndEnvironmentObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Health, safety and environment"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/healthSafetyAndEnvironmentObjParameter">http://data.europa.eu/949/healthSafetyAndEnvironmentObjParameter</seealso>
    let healthSafetyAndEnvironmentObjParameter =
        Prefixed_Name(era, "healthSafetyAndEnvironmentObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:highSpeedLoadModelCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"For sections of line with a maximum permitted speed of 200 km/h or more. Information regarding the procedure to be used to perform the dynamic compatibility check."</para>
    /// labels<para>"Compliance of structures with the High Speed Load Model (HSLM)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/highSpeedLoadModelCompliance">http://data.europa.eu/949/highSpeedLoadModelCompliance</seealso>
    let highSpeedLoadModelCompliance =
        Prefixed_Name(era, "highSpeedLoadModelCompliance") |> PrefixedName

    /// <summary>
    ///   <para>era:hotAxleBoxDetectorDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Direction of measurement of trackside HABD, specific for the French Italian and Swedish networks."</para>
    /// labels<para>"Direction of measurement of trackside HABD"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hotAxleBoxDetectorDirection">http://data.europa.eu/949/hotAxleBoxDetectorDirection</seealso>
    let hotAxleBoxDetectorDirection =
        Prefixed_Name(era, "hotAxleBoxDetectorDirection") |> PrefixedName

    /// <summary>
    ///   <para>era:hotAxleBoxDetectorGeneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specific for the French Italian and Swedish networks.
    /// Generation of trackside hot axle box detector."</para>
    /// labels<para>"Generation of trackside HABD"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hotAxleBoxDetectorGeneration">http://data.europa.eu/949/hotAxleBoxDetectorGeneration</seealso>
    let hotAxleBoxDetectorGeneration =
        Prefixed_Name(era, "hotAxleBoxDetectorGeneration") |> PrefixedName

    /// <summary>
    ///   <para>era:hotAxleBoxDetectorIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Specific for the French, Italian and Swedish networks.
    /// Applicable if trackside HABD is not TSI compliant, identification of trackside hot axle box detector."</para>
    /// labels<para>"Identification of trackside HABD"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hotAxleBoxDetectorIdentification">http://data.europa.eu/949/hotAxleBoxDetectorIdentification</seealso>
    let hotAxleBoxDetectorIdentification =
        Prefixed_Name(era, "hotAxleBoxDetectorIdentification") |> PrefixedName

    /// <summary>
    ///   <para>era:hotAxleBoxDetectorLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specific for the French Italian and Swedish networks.
    /// Applicable if trackside HABD is not TSI compliant, localisation of trackside hot axle box detector."</para>
    /// labels<para>"Railway location of trackside HABD"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hotAxleBoxDetectorLocation">http://data.europa.eu/949/hotAxleBoxDetectorLocation</seealso>
    let hotAxleBoxDetectorLocation =
        Prefixed_Name(era, "hotAxleBoxDetectorLocation") |> PrefixedName

    /// <summary>
    ///   <para>era:hotAxleBoxDetectorTSICompliant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specific for the French, Italian and Swedish networks.
    /// Trackside HABD compliant to TSI means that the HABD Trackside is compliant with:
    /// - EN 15437-1:2009 referred in TSIs (LOC&amp;PAS: 4.2.3.3.2.2, WAG TSI: 4.2.3.4),
    /// - Specific cases mentioned in TSIs (LOC&amp;PAS TSI, WAG TSI)."</para>
    /// labels<para>"Trackside HABD TSI compliant"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/hotAxleBoxDetectorTSICompliant">http://data.europa.eu/949/hotAxleBoxDetectorTSICompliant</seealso>
    let hotAxleBoxDetectorTSICompliant =
        Prefixed_Name(era, "hotAxleBoxDetectorTSICompliant") |> PrefixedName

    /// <summary>
    ///   <para>era:idPhoneErtmsRadioBlockCenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique RBC identification (NID_C+NID_RBC) and calling number (NID_RADIO) as defined in the specification referenced in Appendix A-1, index [C]."</para>
    /// labels<para>"(deprecated) ID and phone number of ERTMS/ETCS Radio Block Center"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/idPhoneErtmsRadioBlockCenter">http://data.europa.eu/949/idPhoneErtmsRadioBlockCenter</seealso>
    let idPhoneErtmsRadioBlockCenter =
        Prefixed_Name(era, "idPhoneErtmsRadioBlockCenter") |> PrefixedName

    /// <summary>
    ///   <para>era:imCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Infrastructure manager means any body or firm responsible in particular for establishing, managing and maintaining railway infrastructure, including traffic management and control-command signalling;
    /// the functions of the infrastructure manager on a network or part of a network may be allocated to different bodies or firms. Definition in (Article 3(2))"</para>
    /// labels<para>"Infrastructure manager (IM)'s code"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/imCode">http://data.europa.eu/949/imCode</seealso>
    let imCode = Prefixed_Name(era, "imCode") |> PrefixedName
    /// <summary>
    ///   <para>era:inCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the country in which an entity resides."</para>
    /// labels<para>"In country"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/inCountry">http://data.europa.eu/949/inCountry</seealso>
    let inCountry = Prefixed_Name(era, "inCountry") |> PrefixedName
    /// <summary>
    ///   <para>era:inNUTS3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Reference to NUTS-3 place or city"</para>
    /// labels<para>"In NUTS-3"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/inNUTS3">http://data.europa.eu/949/inNUTS3</seealso>
    let inNUTS3 = Prefixed_Name(era, "inNUTS3") |> PrefixedName
    /// <summary>
    ///   <para>era:inSkosConceptScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Property that links an object SKOS property to a the URI of the corresponding SKOS Concept Scheme."</para>
    /// labels<para>"in SKOS Concept Scheme"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/inSkosConceptScheme">http://data.europa.eu/949/inSkosConceptScheme</seealso>
    let inSkosConceptScheme = Prefixed_Name(era, "inSkosConceptScheme") |> PrefixedName
    /// <summary>
    ///   <para>era:includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"List of linear references included in an network area reference."</para>
    /// labels<para>"includes list of linear references"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/includes">http://data.europa.eu/949/includes</seealso>
    let includes = Prefixed_Name(era, "includes") |> PrefixedName

    /// <summary>
    ///   <para>era:infraSubsystemDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Infrastructure subsystem"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/infraSubsystemDataParameter">http://data.europa.eu/949/infraSubsystemDataParameter</seealso>
    let infraSubsystemDataParameter =
        Prefixed_Name(era, "infraSubsystemDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:infraSubsystemDeclarationsVerificationTrackDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Declarations of verification for track"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/infraSubsystemDeclarationsVerificationTrackDataParameter">http://data.europa.eu/949/infraSubsystemDeclarationsVerificationTrackDataParameter</seealso>
    let infraSubsystemDeclarationsVerificationTrackDataParameter =
        Prefixed_Name(era, "infraSubsystemDeclarationsVerificationTrackDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:infraSubsystemObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Infrastructure subsystem"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/infraSubsystemObjParameter">http://data.europa.eu/949/infraSubsystemObjParameter</seealso>
    let infraSubsystemObjParameter =
        Prefixed_Name(era, "infraSubsystemObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:infrastructureManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Relates a subset with common characteristics with its IM, represented by an instance of organisation role that points to the "infrastructure manager" concept in the taxonomy."</para>
    /// labels<para>"infrastructure manager"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/infrastructureManager">http://data.europa.eu/949/infrastructureManager</seealso>
    let infrastructureManager =
        Prefixed_Name(era, "infrastructureManager") |> PrefixedName

    /// <summary>
    ///   <para>era:infrastructureMgr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"(deprecated) not in use. Relates any feature implemented in the European railway infrastructure with its infrastructure manager."</para>
    /// labels<para>"Infrastructure manager"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/infrastructureMgr">http://data.europa.eu/949/infrastructureMgr</seealso>
    let infrastructureMgr = Prefixed_Name(era, "infrastructureMgr") |> PrefixedName

    /// <summary>
    ///   <para>era:instructionsSwitchRadioSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Name and/or reference of the document specifying the Special instructions to switch over between different radio systems."</para>
    /// labels<para>"Special instructions to switch over between different radio systems"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/instructionsSwitchRadioSystems">http://data.europa.eu/949/instructionsSwitchRadioSystems</seealso>
    let instructionsSwitchRadioSystems =
        Prefixed_Name(era, "instructionsSwitchRadioSystems") |> PrefixedName

    /// <summary>
    ///   <para>era:isOnOriginOfElementA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Determines if the position of the topological element A in a relation is the origin of element A."</para>
    /// labels<para>"is on origin of element A"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/isOnOriginOfElementA">http://data.europa.eu/949/isOnOriginOfElementA</seealso>
    let isOnOriginOfElementA =
        Prefixed_Name(era, "isOnOriginOfElementA") |> PrefixedName

    /// <summary>
    ///   <para>era:isOnOriginOfElementB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Determines if the position of the topological element B in a relation is the origin of element B."</para>
    /// labels<para>"is on origin of element B"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/isOnOriginOfElementB">http://data.europa.eu/949/isOnOriginOfElementB</seealso>
    let isOnOriginOfElementB =
        Prefixed_Name(era, "isOnOriginOfElementB") |> PrefixedName

    /// <summary>
    ///   <para>era:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Indicates that an infrastructure element is a part of another (distinct) infrastructure element.
    /// An element cannot be part of itself.
    /// This property is the inverse of era:hasPart and represents the partial or whole-part relationship between infrastructure elements."</para>
    /// labels<para>"is part of"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/isPartOf">http://data.europa.eu/949/isPartOf</seealso>
    let isPartOf = Prefixed_Name(era, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>era:isQuietRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Belonging to a 'quieter route' in accordance with Article 5b of TSI NOI."</para>
    /// labels<para>"Belonging to a quieter route"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/isQuietRoute">http://data.europa.eu/949/isQuietRoute</seealso>
    let isQuietRoute = Prefixed_Name(era, "isQuietRoute") |> PrefixedName
    /// <summary>
    ///   <para>era:kilometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Kilometer number of the kilometric post related to line identification defining the location of an infrastructure element."</para>
    /// labels<para>"kilometer number"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/kilometer">http://data.europa.eu/949/kilometer</seealso>
    let kilometer = Prefixed_Name(era, "kilometer") |> PrefixedName
    /// <summary>
    ///   <para>era:kmPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The closest kilometric post on the line, used as a reference by the LRS coordinate."</para>
    /// labels<para>"km post for reference"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/kmPost">http://data.europa.eu/949/kmPost</seealso>
    let kmPost = Prefixed_Name(era, "kmPost") |> PrefixedName
    /// <summary>
    ///   <para>era:kmPostName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name of the kilometric post (optional)."</para>
    /// labels<para>"kilometric post name"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/kmPostName">http://data.europa.eu/949/kmPostName</seealso>
    let kmPostName = Prefixed_Name(era, "kmPostName") |> PrefixedName
    /// <summary>
    ///   <para>era:legacyRadioSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of radio legacy systems installed."</para>
    /// labels<para>"Other radio systems installed (Radio Legacy Systems)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/legacyRadioSystem">http://data.europa.eu/949/legacyRadioSystem</seealso>
    let legacyRadioSystem = Prefixed_Name(era, "legacyRadioSystem") |> PrefixedName
    /// <summary>
    ///   <para>era:legalDeadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Annotation used to point to legal obligation of a parameter in RINF"</para>
    /// labels<para>"legal deadline"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/legalDeadline">http://data.europa.eu/949/legalDeadline</seealso>
    let legalDeadline = Prefixed_Name(era, "legalDeadline") |> PrefixedName
    /// <summary>
    ///   <para>era:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Generic super-property for different types of length"</para>
    /// labels<para>"Length"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/length">http://data.europa.eu/949/length</seealso>
    let length = Prefixed_Name(era, "length") |> PrefixedName

    /// <summary>
    ///   <para>era:lengthOfNetLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Length of a topological linear element."</para>
    /// labels<para>"length of net linear element"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lengthOfNetLinearElement">http://data.europa.eu/949/lengthOfNetLinearElement</seealso>
    let lengthOfNetLinearElement =
        Prefixed_Name(era, "lengthOfNetLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>era:lengthOfPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The maximum continuous length (expressed in metres) of that part of platform in front of which a train is intended to remain stationary in normal operating conditions for passengers to board and alight from the train, making appropriate allowance for stopping tolerances."</para>
    /// labels<para>"Usable length of platform"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lengthOfPlatform">http://data.europa.eu/949/lengthOfPlatform</seealso>
    let lengthOfPlatform = Prefixed_Name(era, "lengthOfPlatform") |> PrefixedName

    /// <summary>
    ///   <para>era:lengthOfSectionOfLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Length between operational points at start and end of section of line."</para>
    /// labels<para>"Length of section of line"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lengthOfSectionOfLine">http://data.europa.eu/949/lengthOfSectionOfLine</seealso>
    let lengthOfSectionOfLine =
        Prefixed_Name(era, "lengthOfSectionOfLine") |> PrefixedName

    /// <summary>
    ///   <para>era:lengthOfSiding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Total length of the siding/stabling track expressed in metres where trains can be parked safely."</para>
    /// labels<para>"Usable length of siding"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lengthOfSiding">http://data.europa.eu/949/lengthOfSiding</seealso>
    let lengthOfSiding = Prefixed_Name(era, "lengthOfSiding") |> PrefixedName
    /// <summary>
    ///   <para>era:lengthOfTunnel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Length of a tunnel in metres from entrance portal to exit portal."</para>
    /// labels<para>"Length of tunnel"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lengthOfTunnel">http://data.europa.eu/949/lengthOfTunnel</seealso>
    let lengthOfTunnel = Prefixed_Name(era, "lengthOfTunnel") |> PrefixedName
    /// <summary>
    ///   <para>era:lengthOfVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"Vehicle length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lengthOfVehicle">http://data.europa.eu/949/lengthOfVehicle</seealso>
    let lengthOfVehicle = Prefixed_Name(era, "lengthOfVehicle") |> PrefixedName
    /// <summary>
    ///   <para>era:letterMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"letter marking"</para>
    /// labels<para>"Letter marking"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/letterMarking">http://data.europa.eu/949/letterMarking</seealso>
    let letterMarking = Prefixed_Name(era, "letterMarking") |> PrefixedName
    /// <summary>
    ///   <para>era:lineCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Classification of a line according to the TSI INF"</para>
    /// labels<para>"Category of line"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lineCategory">http://data.europa.eu/949/lineCategory</seealso>
    let lineCategory = Prefixed_Name(era, "lineCategory") |> PrefixedName
    /// <summary>
    ///   <para>era:lineId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Unique line identification or unique line number within Member State."</para>
    /// labels<para>"line identifier"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lineId">http://data.europa.eu/949/lineId</seealso>
    let lineId = Prefixed_Name(era, "lineId") |> PrefixedName

    /// <summary>
    ///   <para>era:lineLayoutDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Line layout"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lineLayoutDataParameter">http://data.europa.eu/949/lineLayoutDataParameter</seealso>
    let lineLayoutDataParameter =
        Prefixed_Name(era, "lineLayoutDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:lineLayoutObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Line layout"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lineLayoutObjParameter">http://data.europa.eu/949/lineLayoutObjParameter</seealso>
    let lineLayoutObjParameter =
        Prefixed_Name(era, "lineLayoutObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:lineNationalId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Unique line identification or unique line number within Member State."</para>
    /// labels<para>"(deprecated) National line identification"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lineNationalId">http://data.europa.eu/949/lineNationalId</seealso>
    let lineNationalId = Prefixed_Name(era, "lineNationalId") |> PrefixedName
    /// <summary>
    ///   <para>era:lineReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a relationship with a national railway line at a specific kilometer point."</para>
    /// labels<para>"(deprecated) Railway location of an infrastructure object"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lineReference">http://data.europa.eu/949/lineReference</seealso>
    let lineReference = Prefixed_Name(era, "lineReference") |> PrefixedName

    /// <summary>
    ///   <para>era:lineReferenceTunnelEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Part of the End of tunnel that indicates the km of the line at the end of a tunnel.
    ///
    /// The End of tunnel is the Geographical coordinates in decimal degrees and km of the line at the end of a tunnel."</para>
    /// labels<para>"End of tunnel kilometer"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lineReferenceTunnelEnd">http://data.europa.eu/949/lineReferenceTunnelEnd</seealso>
    let lineReferenceTunnelEnd =
        Prefixed_Name(era, "lineReferenceTunnelEnd") |> PrefixedName

    /// <summary>
    ///   <para>era:lineReferenceTunnelStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Part of the Start of tunnel that indicates the km of the line at the beginning of a tunnel.
    ///
    /// The Start of tunnel is the Geographical coordinates in decimal degrees and km of the line at the beginning of a tunnel."</para>
    /// labels<para>"Start of tunnel kilometer"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lineReferenceTunnelStart">http://data.europa.eu/949/lineReferenceTunnelStart</seealso>
    let lineReferenceTunnelStart =
        Prefixed_Name(era, "lineReferenceTunnelStart") |> PrefixedName

    /// <summary>
    ///   <para>era:lineSideSystemDegradedSituationObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Line-side system for degraded situation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lineSideSystemDegradedSituationObjParameter">http://data.europa.eu/949/lineSideSystemDegradedSituationObjParameter</seealso>
    let lineSideSystemDegradedSituationObjParameter =
        Prefixed_Name(era, "lineSideSystemDegradedSituationObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:linearCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the position of an object within a linear positioning system. For example, relative to a national railway line"</para>
    /// labels<para>"Linear coordinate"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/linearCoordinate">http://data.europa.eu/949/linearCoordinate</seealso>
    let linearCoordinate = Prefixed_Name(era, "linearCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>era:linesideDistanceIndication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication of types of appearance of track lineside distance indications."</para>
    /// labels<para>"Lineside distance indication"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/linesideDistanceIndication">http://data.europa.eu/949/linesideDistanceIndication</seealso>
    let linesideDistanceIndication =
        Prefixed_Name(era, "linesideDistanceIndication") |> PrefixedName

    /// <summary>
    ///   <para>era:linesideDistanceIndicationAppearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication of types of appearance of track lineside distance indications."</para>
    /// labels<para>"Lineside distance indication appearance"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/linesideDistanceIndicationAppearance">http://data.europa.eu/949/linesideDistanceIndicationAppearance</seealso>
    let linesideDistanceIndicationAppearance =
        Prefixed_Name(era, "linesideDistanceIndicationAppearance") |> PrefixedName

    /// <summary>
    ///   <para>era:linesideDistanceIndicationFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Frequency of track lineside distance indications."</para>
    /// labels<para>"Lineside distance indication frequency"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/linesideDistanceIndicationFrequency">http://data.europa.eu/949/linesideDistanceIndicationFrequency</seealso>
    let linesideDistanceIndicationFrequency =
        Prefixed_Name(era, "linesideDistanceIndicationFrequency") |> PrefixedName

    /// <summary>
    ///   <para>era:linesideDistanceIndicationPositioning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indication of the side along the track where the lineside indication is positioned (left or right, or both sides)."</para>
    /// labels<para>"Lineside distance indication positioning"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/linesideDistanceIndicationPositioning">http://data.europa.eu/949/linesideDistanceIndicationPositioning</seealso>
    let linesideDistanceIndicationPositioning =
        Prefixed_Name(era, "linesideDistanceIndicationPositioning") |> PrefixedName

    /// <summary>
    ///   <para>era:linkedToPrimaryLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a subsidiary location with a primary location."</para>
    /// labels<para>"linked to primary location"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/linkedToPrimaryLocation">http://data.europa.eu/949/linkedToPrimaryLocation</seealso>
    let linkedToPrimaryLocation =
        Prefixed_Name(era, "linkedToPrimaryLocation") |> PrefixedName

    /// <summary>
    ///   <para>era:loadCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A combination of the line category and speed at the weakest point of the track. The reason for deprecation is that the load capability property 1.1.1.1.2.4 was defined incorrectly as a SKOS property. It is composed of two values: (1)  line category, and (2) speed. Only line category is a list of predefined values (SKOS), whereas speed is an integer (according to the RINF application guide)."</para>
    /// labels<para>"Load Capability"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/loadCapability">http://data.europa.eu/949/loadCapability</seealso>
    let loadCapability = Prefixed_Name(era, "loadCapability") |> PrefixedName

    /// <summary>
    ///   <para>era:loadCapabilityLineCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Part of the load capability of a track that corresponds to the line category of the load model.
    /// The load capability is a value selected from the list of load models representing the line category which is amended by value of speed [km/h] permitted for a specific load model. The list of values may also be Route Availability which is amended by value of speed [miles/h] permitted for a specific load model."</para>
    /// labels<para>"Load capability line category"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/loadCapabilityLineCategory">http://data.europa.eu/949/loadCapabilityLineCategory</seealso>
    let loadCapabilityLineCategory =
        Prefixed_Name(era, "loadCapabilityLineCategory") |> PrefixedName

    /// <summary>
    ///   <para>era:loadCapabilitySpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the load capability of a track that corresponds to the speed of the load model"</para>
    /// labels<para>"Load capability speed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/loadCapabilitySpeed">http://data.europa.eu/949/loadCapabilitySpeed</seealso>
    let loadCapabilitySpeed = Prefixed_Name(era, "loadCapabilitySpeed") |> PrefixedName
    /// <summary>
    ///   <para>era:loadingGauge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum physical dimensions (height and width) to which an open rail wagon can be loaded"</para>
    /// labels<para>"Loading gauge"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/loadingGauge">http://data.europa.eu/949/loadingGauge</seealso>
    let loadingGauge = Prefixed_Name(era, "loadingGauge") |> PrefixedName

    /// <summary>
    ///   <para>era:loadingPlatformHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Height of loading platform (for flat wagons and combined transport), given in mm."</para>
    /// labels<para>"Loading platform height"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/loadingPlatformHeight">http://data.europa.eu/949/loadingPlatformHeight</seealso>
    let loadingPlatformHeight =
        Prefixed_Name(era, "loadingPlatformHeight") |> PrefixedName

    /// <summary>
    ///   <para>era:localRulesOrRestrictions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Existence of rules and restrictions of a strictly local nature"</para>
    /// labels<para>"Existence of rules and restrictions of a strictly local nature"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/localRulesOrRestrictions">http://data.europa.eu/949/localRulesOrRestrictions</seealso>
    let localRulesOrRestrictions =
        Prefixed_Name(era, "localRulesOrRestrictions") |> PrefixedName

    /// <summary>
    ///   <para>era:localRulesOrRestrictionsDoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Electronic document available from the IM stored by the Agency providing additional information."</para>
    /// labels<para>"Documents regarding the rules or restrictions of a strictly local nature available by the IM"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/localRulesOrRestrictionsDoc">http://data.europa.eu/949/localRulesOrRestrictionsDoc</seealso>
    let localRulesOrRestrictionsDoc =
        Prefixed_Name(era, "localRulesOrRestrictionsDoc") |> PrefixedName

    /// <summary>
    ///   <para>era:lrsMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The preferred line referencing system."</para>
    /// labels<para>"type of line referencing system"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/lrsMethod">http://data.europa.eu/949/lrsMethod</seealso>
    let lrsMethod = Prefixed_Name(era, "lrsMethod") |> PrefixedName
    /// <summary>
    ///   <para>era:mNvcontact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"On-Board system reaction when T_NVCONTACT expires
    /// According to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"M_NVCONTACT"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/mNvcontact">http://data.europa.eu/949/mNvcontact</seealso>
    let mNvcontact = Prefixed_Name(era, "mNvcontact") |> PrefixedName
    /// <summary>
    ///   <para>era:mNvderun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Entry of Driver ID permitted while running According to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"M_NVDERUN"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/mNvderun">http://data.europa.eu/949/mNvderun</seealso>
    let mNvderun = Prefixed_Name(era, "mNvderun") |> PrefixedName

    /// <summary>
    ///   <para>era:magneticBrakePrevention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Possibility of preventing the use of the magnetic track brake (only if fitted with magnetic brake)"</para>
    /// labels<para>"Magnetic brake prevention"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/magneticBrakePrevention">http://data.europa.eu/949/magneticBrakePrevention</seealso>
    let magneticBrakePrevention =
        Prefixed_Name(era, "magneticBrakePrevention") |> PrefixedName

    /// <summary>
    ///   <para>era:magneticBraking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of limitations on the use of magnetic brakes."</para>
    /// labels<para>"Use of magnetic brakes"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/magneticBraking">http://data.europa.eu/949/magneticBraking</seealso>
    let magneticBraking = Prefixed_Name(era, "magneticBraking") |> PrefixedName

    /// <summary>
    ///   <para>era:magneticBrakingConditionsDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Electronic document available in two EU languages from the IM stored by the Agency with conditions for the use of magnetic brakes identified in 1.1.1.1.6.3."</para>
    /// labels<para>"Document with the conditions for the use of magnetic brakes"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/magneticBrakingConditionsDocument">http://data.europa.eu/949/magneticBrakingConditionsDocument</seealso>
    let magneticBrakingConditionsDocument =
        Prefixed_Name(era, "magneticBrakingConditionsDocument") |> PrefixedName

    /// <summary>
    ///   <para>era:magneticBrakingFitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Magnetic track brake fitted. New property defined to distinguish it from magneticBraking which is a RINF SKOS property."</para>
    /// labels<para>"Magnetic braking fitted"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/magneticBrakingFitted">http://data.europa.eu/949/magneticBrakingFitted</seealso>
    let magneticBrakingFitted =
        Prefixed_Name(era, "magneticBrakingFitted") |> PrefixedName

    /// <summary>
    ///   <para>era:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Vehicle manufacturer company."</para>
    /// labels<para>"manufactured by"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/manufacturer">http://data.europa.eu/949/manufacturer</seealso>
    let manufacturer = Prefixed_Name(era, "manufacturer") |> PrefixedName

    /// <summary>
    ///   <para>era:manufacturingCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the country in which a vehicle or vehicle type is manufactured."</para>
    /// labels<para>"Manufacturing country"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/manufacturingCountry">http://data.europa.eu/949/manufacturingCountry</seealso>
    let manufacturingCountry =
        Prefixed_Name(era, "manufacturingCountry") |> PrefixedName

    /// <summary>
    ///   <para>era:massPerWheel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Mass per wheel, given in kg."</para>
    /// labels<para>"Mass per wheel"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/massPerWheel">http://data.europa.eu/949/massPerWheel</seealso>
    let massPerWheel = Prefixed_Name(era, "massPerWheel") |> PrefixedName
    /// <summary>
    ///   <para>era:maxAxleLoadOfSoL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Maximum permitted axle load, given in tons."</para>
    /// labels<para>"Maximum Axle load"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maxAxleLoadOfSoL">http://data.europa.eu/949/maxAxleLoadOfSoL</seealso>
    let maxAxleLoadOfSoL = Prefixed_Name(era, "maxAxleLoadOfSoL") |> PrefixedName

    /// <summary>
    ///   <para>era:maxCurrentStandstillPantograph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indication of the maximum allowable train current at standstill expressed in amperes."</para>
    /// labels<para>"Maximum current at standstill per pantograph"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maxCurrentStandstillPantograph">http://data.europa.eu/949/maxCurrentStandstillPantograph</seealso>
    let maxCurrentStandstillPantograph =
        Prefixed_Name(era, "maxCurrentStandstillPantograph") |> PrefixedName

    /// <summary>
    ///   <para>era:maxDistConsecutiveAxles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter. Indication of maximum permitted distance between two consecutive axles in case of TSI non-compliance, given in millimetres."</para>
    /// labels<para>"Maximum permitted distance between two consecutive axles in case of TSI non-compliance"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maxDistConsecutiveAxles">http://data.europa.eu/949/maxDistConsecutiveAxles</seealso>
    let maxDistConsecutiveAxles =
        Prefixed_Name(era, "maxDistConsecutiveAxles") |> PrefixedName

    /// <summary>
    ///   <para>era:maxDistEndTrainFirstAxle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication of maximum distance between end of train and first axle, given in millimetres, applicable for both sides (front and rear) of a vehicle or train."</para>
    /// labels<para>"Maximum distance between end of train and first axle"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maxDistEndTrainFirstAxle">http://data.europa.eu/949/maxDistEndTrainFirstAxle</seealso>
    let maxDistEndTrainFirstAxle =
        Prefixed_Name(era, "maxDistEndTrainFirstAxle") |> PrefixedName

    /// <summary>
    ///   <para>era:maxFlangeHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter. Maximum permitted flange height, given in millimetres."</para>
    /// labels<para>"Maximum permitted height of the flange"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maxFlangeHeight">http://data.europa.eu/949/maxFlangeHeight</seealso>
    let maxFlangeHeight = Prefixed_Name(era, "maxFlangeHeight") |> PrefixedName

    /// <summary>
    ///   <para>era:maxImpedanceWheelset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The value of maximum permitted impedance given in ohm in case of TSI non-compliance. Deprecated according to the amendment to the Regulation (EU) 2019/777."</para>
    /// labels<para>"Maximum permitted impedance between opposite wheels of a wheelset when not TSI compliant"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maxImpedanceWheelset">http://data.europa.eu/949/maxImpedanceWheelset</seealso>
    let maxImpedanceWheelset =
        Prefixed_Name(era, "maxImpedanceWheelset") |> PrefixedName

    /// <summary>
    ///   <para>era:maxLengthVehicleNose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum length of the vehicle nose."</para>
    /// labels<para>"Maximum length vehicle nose"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maxLengthVehicleNose">http://data.europa.eu/949/maxLengthVehicleNose</seealso>
    let maxLengthVehicleNose =
        Prefixed_Name(era, "maxLengthVehicleNose") |> PrefixedName

    /// <summary>
    ///   <para>era:maxNoiseLevelOfSoL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Maximum allowed noise level in decibels (dB)."</para>
    /// labels<para>"Maximum noise level"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maxNoiseLevelOfSoL">http://data.europa.eu/949/maxNoiseLevelOfSoL</seealso>
    let maxNoiseLevelOfSoL = Prefixed_Name(era, "maxNoiseLevelOfSoL") |> PrefixedName

    /// <summary>
    ///   <para>era:maxPermittedTrainLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum train length in meters allowed on a section of line, without special permission, for the operation of freight trains.
    ///                             In accordance with Regulation (EU) 2024/1679, Article 15(2)(c), this maximum length must be supported by the infrastructure manager's ability
    ///                             to allocate sufficient train paths for freight trains of at least 740 meters (including the locomotive or locomotives), as required for the TEN-T network."</para>
    /// labels<para>"Maximum train length allowed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maxPermittedTrainLength">http://data.europa.eu/949/maxPermittedTrainLength</seealso>
    let maxPermittedTrainLength =
        Prefixed_Name(era, "maxPermittedTrainLength") |> PrefixedName

    /// <summary>
    ///   <para>era:maxSandingOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Maximum amount of sand accepted on the track within value of sanding output for 30s, given in grams.
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777."</para>
    /// labels<para>"Maximum amount of sand"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maxSandingOutput">http://data.europa.eu/949/maxSandingOutput</seealso>
    let maxSandingOutput = Prefixed_Name(era, "maxSandingOutput") |> PrefixedName
    /// <summary>
    ///   <para>era:maxTrainCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indication of the maximum allowable train current expressed in amperes."</para>
    /// labels<para>"Maximum train current"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maxTrainCurrent">http://data.europa.eu/949/maxTrainCurrent</seealso>
    let maxTrainCurrent = Prefixed_Name(era, "maxTrainCurrent") |> PrefixedName
    /// <summary>
    ///   <para>era:maxTunnelSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicate the speed limit in a tunnel"</para>
    /// labels<para>"Tunnel speed limit"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maxTunnelSpeed">http://data.europa.eu/949/maxTunnelSpeed</seealso>
    let maxTunnelSpeed = Prefixed_Name(era, "maxTunnelSpeed") |> PrefixedName
    /// <summary>
    ///   <para>era:maxbridgeWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the maximun wind speed for which the bridge can operate"</para>
    /// labels<para>"Maximun bridge wind"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maxbridgeWind">http://data.europa.eu/949/maxbridgeWind</seealso>
    let maxbridgeWind = Prefixed_Name(era, "maxbridgeWind") |> PrefixedName
    /// <summary>
    ///   <para>era:maximumAltitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Highest point of the section of line above sea level in reference to Normal Amsterdam's Peil (NAP)."</para>
    /// labels<para>"Maximum altitude"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumAltitude">http://data.europa.eu/949/maximumAltitude</seealso>
    let maximumAltitude = Prefixed_Name(era, "maximumAltitude") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumAverageDeceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum train deceleration given in m/s²."</para>
    /// labels<para>"Maximum average deceleration"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumAverageDeceleration">http://data.europa.eu/949/maximumAverageDeceleration</seealso>
    let maximumAverageDeceleration =
        Prefixed_Name(era, "maximumAverageDeceleration") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumBrakeThermalEnergyCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum brake thermal energy capacity given in kJ"</para>
    /// labels<para>"Maximum brake thermal energy capacity"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumBrakeThermalEnergyCapacity">http://data.europa.eu/949/maximumBrakeThermalEnergyCapacity</seealso>
    let maximumBrakeThermalEnergyCapacity =
        Prefixed_Name(era, "maximumBrakeThermalEnergyCapacity") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumBrakingDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The maximum value of the braking distance [in metres] of a train shall be given for the maximum line speed."</para>
    /// labels<para>"Maximum braking distance requested"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumBrakingDistance">http://data.europa.eu/949/maximumBrakingDistance</seealso>
    let maximumBrakingDistance =
        Prefixed_Name(era, "maximumBrakingDistance") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumContactWireHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of the maximum contact wire height expressed in metres."</para>
    /// labels<para>"Maximum contact wire height"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumContactWireHeight">http://data.europa.eu/949/maximumContactWireHeight</seealso>
    let maximumContactWireHeight =
        Prefixed_Name(era, "maximumContactWireHeight") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumDesignSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum design speed."</para>
    /// labels<para>"Maximum design speed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumDesignSpeed">http://data.europa.eu/949/maximumDesignSpeed</seealso>
    let maximumDesignSpeed = Prefixed_Name(era, "maximumDesignSpeed") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumInterferenceCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Maximum interference current limits allowed for track circuits for a defined frequency band."</para>
    /// labels<para>"Maximum interference current"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumInterferenceCurrent">http://data.europa.eu/949/maximumInterferenceCurrent</seealso>
    let maximumInterferenceCurrent =
        Prefixed_Name(era, "maximumInterferenceCurrent") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumInterferenceCurrentEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Maximum interference current limits allowed for track circuits for a defined frequency band. "</para>
    /// labels<para>"Evaluation parameters if maximum interference current is not measured in the preferred bands"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumInterferenceCurrentEvaluation">http://data.europa.eu/949/maximumInterferenceCurrentEvaluation</seealso>
    let maximumInterferenceCurrentEvaluation =
        Prefixed_Name(era, "maximumInterferenceCurrentEvaluation") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumLocomotivesCoupled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum number of trainsets or locomotives coupled together in multiple operation."</para>
    /// labels<para>"Maximum locomotives coupled"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumLocomotivesCoupled">http://data.europa.eu/949/maximumLocomotivesCoupled</seealso>
    let maximumLocomotivesCoupled =
        Prefixed_Name(era, "maximumLocomotivesCoupled") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumMagneticFieldDirectionX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band. Direction X."</para>
    /// labels<para>"Maximum magnetic field direction X"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumMagneticFieldDirectionX">http://data.europa.eu/949/maximumMagneticFieldDirectionX</seealso>
    let maximumMagneticFieldDirectionX =
        Prefixed_Name(era, "maximumMagneticFieldDirectionX") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumMagneticFieldDirectionY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band. Direction Y."</para>
    /// labels<para>"Maximum magnetic field direction Y"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumMagneticFieldDirectionY">http://data.europa.eu/949/maximumMagneticFieldDirectionY</seealso>
    let maximumMagneticFieldDirectionY =
        Prefixed_Name(era, "maximumMagneticFieldDirectionY") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumMagneticFieldDirectionZ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band. Direction Z."</para>
    /// labels<para>"Maximum magnetic field direction Z"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumMagneticFieldDirectionZ">http://data.europa.eu/949/maximumMagneticFieldDirectionZ</seealso>
    let maximumMagneticFieldDirectionZ =
        Prefixed_Name(era, "maximumMagneticFieldDirectionZ") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumPermittedMeterLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum permitted meter load, given in tons"</para>
    /// labels<para>"Maximum permitted meter load"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumPermittedMeterLoad">http://data.europa.eu/949/maximumPermittedMeterLoad</seealso>
    let maximumPermittedMeterLoad =
        Prefixed_Name(era, "maximumPermittedMeterLoad") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumPermittedSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Nominal maximum operational speed on the line as a result of infrastructure, energy and control, command signalling subsystem characteristics expressed in kilometres/hour."</para>
    /// labels<para>"Maximum permitted speed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumPermittedSpeed">http://data.europa.eu/949/maximumPermittedSpeed</seealso>
    let maximumPermittedSpeed =
        Prefixed_Name(era, "maximumPermittedSpeed") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumServiceBrake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"At maximum service brake: Stopping distance, Maximum deceleration, for the load condition 'design mass under normal payload' at the design maximum speed."</para>
    /// labels<para>"Maximum service break"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumServiceBrake">http://data.europa.eu/949/maximumServiceBrake</seealso>
    let maximumServiceBrake = Prefixed_Name(era, "maximumServiceBrake") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumSpeedAndCantDeficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Combination of maximum speed and maximum cant deficiency for which the vehicle was assessed.
    ///
    /// This property was before an object skos property. The values for this property do not come from a list of predefined values. Thus, the original object property was replaced by this datatype property with range xsd:string.
    /// Deprecated because of replacement by a class and two integer properties. The reason is that the property represents two concepts: [number] km/h for maximum speed - [number] mm for maximum cant deficiency."</para>
    /// labels<para>"Maximum speed and cant deficiency"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumSpeedAndCantDeficiency">http://data.europa.eu/949/maximumSpeedAndCantDeficiency</seealso>
    let maximumSpeedAndCantDeficiency =
        Prefixed_Name(era, "maximumSpeedAndCantDeficiency") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumSpeedEmpty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum speed when empty."</para>
    /// labels<para>"Maximum speed empty"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumSpeedEmpty">http://data.europa.eu/949/maximumSpeedEmpty</seealso>
    let maximumSpeedEmpty = Prefixed_Name(era, "maximumSpeedEmpty") |> PrefixedName
    /// <summary>
    ///   <para>era:maximumTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated because both RINF and ERATV define a temperature range as a set of predefined values (see https://www.era.europa.eu/system/files/2023-04/iu-eratv_application_guide_for_register_2016-797_en_0.pdf). Maximum temperature allowed for unrestricted operation access, according to European standard."</para>
    /// labels<para>"Temperature range (maximum)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumTemperature">http://data.europa.eu/949/maximumTemperature</seealso>
    let maximumTemperature = Prefixed_Name(era, "maximumTemperature") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumTrainDeceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Limit for longitudinal track resistance given as a maximum allowed train deceleration and expressed in metres per square second."</para>
    /// labels<para>"Maximum train deceleration"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumTrainDeceleration">http://data.europa.eu/949/maximumTrainDeceleration</seealso>
    let maximumTrainDeceleration =
        Prefixed_Name(era, "maximumTrainDeceleration") |> PrefixedName

    /// <summary>
    ///   <para>era:maximumTrainLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum train length allowed on a line or section"</para>
    /// labels<para>"Maximum Train Length"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/maximumTrainLength">http://data.europa.eu/949/maximumTrainLength</seealso>
    let maximumTrainLength = Prefixed_Name(era, "maximumTrainLength") |> PrefixedName
    /// <summary>
    ///   <para>era:measuredDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Measured distance from the origin of the LRS."</para>
    /// labels<para>"measured distance"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/measuredDistance">http://data.europa.eu/949/measuredDistance</seealso>
    let measuredDistance = Prefixed_Name(era, "measuredDistance") |> PrefixedName

    /// <summary>
    ///   <para>era:meetsRequirementVehicleAuthorisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Type meets the requirements necessary for validity of the vehicle authorisation granted by one Member State in other MSs."</para>
    /// labels<para>"Meets requirement vehicle authorisation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/meetsRequirementVehicleAuthorisation">http://data.europa.eu/949/meetsRequirementVehicleAuthorisation</seealso>
    let meetsRequirementVehicleAuthorisation =
        Prefixed_Name(era, "meetsRequirementVehicleAuthorisation") |> PrefixedName

    /// <summary>
    ///   <para>era:minAxleLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Minimum permitted axle load, given in tons."</para>
    /// labels<para>"Minimum permitted axle load"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minAxleLoad">http://data.europa.eu/949/minAxleLoad</seealso>
    let minAxleLoad = Prefixed_Name(era, "minAxleLoad") |> PrefixedName

    /// <summary>
    ///   <para>era:minAxleLoadVehicleCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Represents the category of vehicle which is amended by value of minimum permitted axle load [tons] (property minAxleLoad).
    /// Deprecated according to the amendment to the Regulation (EU) 2019/777."</para>
    /// labels<para>"Minimum axle load vehicle category"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minAxleLoadVehicleCategory">http://data.europa.eu/949/minAxleLoadVehicleCategory</seealso>
    let minAxleLoadVehicleCategory =
        Prefixed_Name(era, "minAxleLoadVehicleCategory") |> PrefixedName

    /// <summary>
    ///   <para>era:minDistConsecutiveAxles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter."</para>
    /// labels<para>"Minimum permitted distance between two consecutive axles"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minDistConsecutiveAxles">http://data.europa.eu/949/minDistConsecutiveAxles</seealso>
    let minDistConsecutiveAxles =
        Prefixed_Name(era, "minDistConsecutiveAxles") |> PrefixedName

    /// <summary>
    ///   <para>era:minDistFirstLastAxle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter."</para>
    /// labels<para>"Minimum permitted distance between first and last axle"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minDistFirstLastAxle">http://data.europa.eu/949/minDistFirstLastAxle</seealso>
    let minDistFirstLastAxle =
        Prefixed_Name(era, "minDistFirstLastAxle") |> PrefixedName

    /// <summary>
    ///   <para>era:minFlangeHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter."</para>
    /// labels<para>"Minimum permitted height of the flange"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minFlangeHeight">http://data.europa.eu/949/minFlangeHeight</seealso>
    let minFlangeHeight = Prefixed_Name(era, "minFlangeHeight") |> PrefixedName
    /// <summary>
    ///   <para>era:minFlangeThickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter."</para>
    /// labels<para>"Minimum permitted thickness of the flange"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minFlangeThickness">http://data.europa.eu/949/minFlangeThickness</seealso>
    let minFlangeThickness = Prefixed_Name(era, "minFlangeThickness") |> PrefixedName
    /// <summary>
    ///   <para>era:minRimWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter."</para>
    /// labels<para>"Minimum permitted width of the rim"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minRimWidth">http://data.europa.eu/949/minRimWidth</seealso>
    let minRimWidth = Prefixed_Name(era, "minRimWidth") |> PrefixedName
    /// <summary>
    ///   <para>era:minVehicleImpedance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Impedance as defined in the specification referenced in Appendix A-1, index [D]"</para>
    /// labels<para>"Vehicle impedance"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minVehicleImpedance">http://data.europa.eu/949/minVehicleImpedance</seealso>
    let minVehicleImpedance = Prefixed_Name(era, "minVehicleImpedance") |> PrefixedName

    /// <summary>
    ///   <para>era:minVehicleImpedanceVoltages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"minimum Vehicle Impedance (Voltage applicable)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minVehicleImpedanceVoltages">http://data.europa.eu/949/minVehicleImpedanceVoltages</seealso>
    let minVehicleImpedanceVoltages =
        Prefixed_Name(era, "minVehicleImpedanceVoltages") |> PrefixedName

    /// <summary>
    ///   <para>era:minVehicleInputCapacitance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"minimal vehicle input capacitance"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minVehicleInputCapacitance">http://data.europa.eu/949/minVehicleInputCapacitance</seealso>
    let minVehicleInputCapacitance =
        Prefixed_Name(era, "minVehicleInputCapacitance") |> PrefixedName

    /// <summary>
    ///   <para>era:minVehicleInputImpedance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"minimal vehicle input impedance"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minVehicleInputImpedance">http://data.europa.eu/949/minVehicleInputImpedance</seealso>
    let minVehicleInputImpedance =
        Prefixed_Name(era, "minVehicleInputImpedance") |> PrefixedName

    /// <summary>
    ///   <para>era:minWheelDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. However, the parameter remains as it is also an ERATV parameter."</para>
    /// labels<para>"Minimum permitted wheel diameter"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minWheelDiameter">http://data.europa.eu/949/minWheelDiameter</seealso>
    let minWheelDiameter = Prefixed_Name(era, "minWheelDiameter") |> PrefixedName

    /// <summary>
    ///   <para>era:minimumConcaveVerticalRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Minimum vertical concave curve radius capability."</para>
    /// labels<para>"Minimum concave vertical radius"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minimumConcaveVerticalRadius">http://data.europa.eu/949/minimumConcaveVerticalRadius</seealso>
    let minimumConcaveVerticalRadius =
        Prefixed_Name(era, "minimumConcaveVerticalRadius") |> PrefixedName

    /// <summary>
    ///   <para>era:minimumContactWireHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of the minimum contact wire height expressed in metres."</para>
    /// labels<para>"Minimum contact wire height"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minimumContactWireHeight">http://data.europa.eu/949/minimumContactWireHeight</seealso>
    let minimumContactWireHeight =
        Prefixed_Name(era, "minimumContactWireHeight") |> PrefixedName

    /// <summary>
    ///   <para>era:minimumConvexVerticalRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Minimum vertical convex curve radius capability."</para>
    /// labels<para>"Minimum convex vertical radius"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minimumConvexVerticalRadius">http://data.europa.eu/949/minimumConvexVerticalRadius</seealso>
    let minimumConvexVerticalRadius =
        Prefixed_Name(era, "minimumConvexVerticalRadius") |> PrefixedName

    /// <summary>
    ///   <para>era:minimumHorizontalRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Radius of the smallest horizontal curve, expressed in metres."</para>
    /// labels<para>"Minimum radius of horizontal curve"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minimumHorizontalRadius">http://data.europa.eu/949/minimumHorizontalRadius</seealso>
    let minimumHorizontalRadius =
        Prefixed_Name(era, "minimumHorizontalRadius") |> PrefixedName

    /// <summary>
    ///   <para>era:minimumTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated because both RINF and ERATV define a temperature range as a set of predefined values (see https://www.era.europa.eu/system/files/2023-04/iu-eratv_application_guide_for_register_2016-797_en_0.pdf). Minimum temperature allowed for unrestricted operation access, according to European standard."</para>
    /// labels<para>"Temperature range (minimum)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minimumTemperature">http://data.europa.eu/949/minimumTemperature</seealso>
    let minimumTemperature = Prefixed_Name(era, "minimumTemperature") |> PrefixedName

    /// <summary>
    ///   <para>era:minimumVerticalRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Radius of the smallest vertical curve expressed in metres."</para>
    /// labels<para>"Minimum radius of vertical curve"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minimumVerticalRadius">http://data.europa.eu/949/minimumVerticalRadius</seealso>
    let minimumVerticalRadius =
        Prefixed_Name(era, "minimumVerticalRadius") |> PrefixedName

    /// <summary>
    ///   <para>era:minimumVerticalRadiusCrest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the minimum radius of vertical curve that indicates the crest"</para>
    /// labels<para>"Minimum radius of vertical curve crest"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minimumVerticalRadiusCrest">http://data.europa.eu/949/minimumVerticalRadiusCrest</seealso>
    let minimumVerticalRadiusCrest =
        Prefixed_Name(era, "minimumVerticalRadiusCrest") |> PrefixedName

    /// <summary>
    ///   <para>era:minimumVerticalRadiusHollow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the minimum radius of vertical curve that indicates the hollow"</para>
    /// labels<para>"Minimum radius of vertical curve hollow"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minimumVerticalRadiusHollow">http://data.europa.eu/949/minimumVerticalRadiusHollow</seealso>
    let minimumVerticalRadiusHollow =
        Prefixed_Name(era, "minimumVerticalRadiusHollow") |> PrefixedName

    /// <summary>
    ///   <para>era:minimumWheelDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Maximum unguided length of fixed obtuse crossings is based on a minimum wheel diameter in service expressed in millimetres."</para>
    /// labels<para>"Minimum wheel diameter for fixed obtuse crossings"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/minimumWheelDiameter">http://data.europa.eu/949/minimumWheelDiameter</seealso>
    let minimumWheelDiameter =
        Prefixed_Name(era, "minimumWheelDiameter") |> PrefixedName

    /// <summary>
    ///   <para>era:multipleTrainProtectionRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication whether more than one train protection, control and warning system is required to be on-board and active simultaneously."</para>
    /// labels<para>"Need for more than one train protection, control and warning system required on board"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/multipleTrainProtectionRequired">http://data.europa.eu/949/multipleTrainProtectionRequired</seealso>
    let multipleTrainProtectionRequired =
        Prefixed_Name(era, "multipleTrainProtectionRequired") |> PrefixedName

    /// <summary>
    ///   <para>era:nationalLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a relationship with a national railway line at a specific kilometer point.
    /// For a Section of Line: unique line identification or unique line number within Member State."</para>
    /// labels<para>"national line identification"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/nationalLine">http://data.europa.eu/949/nationalLine</seealso>
    let nationalLine = Prefixed_Name(era, "nationalLine") |> PrefixedName

    /// <summary>
    ///   <para>era:nationalLoadCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"National classification for load capability"</para>
    /// labels<para>"National classification for load capability"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/nationalLoadCapability">http://data.europa.eu/949/nationalLoadCapability</seealso>
    let nationalLoadCapability =
        Prefixed_Name(era, "nationalLoadCapability") |> PrefixedName

    /// <summary>
    ///   <para>era:nationalRollingStockFireCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Categorisation of how a passenger train with a fire on board will continue to operate for a defined time period - according to national rules if they exist."</para>
    /// labels<para>"National fire category of rolling stock required"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/nationalRollingStockFireCategory">http://data.europa.eu/949/nationalRollingStockFireCategory</seealso>
    let nationalRollingStockFireCategory =
        Prefixed_Name(era, "nationalRollingStockFireCategory") |> PrefixedName

    /// <summary>
    ///   <para>era:nationalValuesBrakeModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Set of parameters for adapting the braking curves calculated by the ETCS on-board system to match accuracy, performance and safety margins imposed by the infrastructure manager.
    /// It copies the content of Packet 3 or of Packet 203 as defined in the specification referenced in Appendix A-1, index [C]."</para>
    /// labels<para>"National Values used for the brake model"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/nationalValuesBrakeModel">http://data.europa.eu/949/nationalValuesBrakeModel</seealso>
    let nationalValuesBrakeModel =
        Prefixed_Name(era, "nationalValuesBrakeModel") |> PrefixedName

    /// <summary>
    ///   <para>era:navigability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the navigation possibilities between two related topological linear elements."</para>
    /// labels<para>"Navigability"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/navigability">http://data.europa.eu/949/navigability</seealso>
    let navigability = Prefixed_Name(era, "navigability") |> PrefixedName
    /// <summary>
    ///   <para>era:netElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"References an associated topological object.
    /// The reason for deprecating this property is that it is defined as "References an associated topological object." and the vocabulary has already a property "hasAbstraction" which relates the implementation layer with the topological layer, https://citnet.tech.ec.europa.eu/CITnet/confluence/pages/viewpage.action?pageId=1122974879."</para>
    /// labels<para>"Net element"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/netElement">http://data.europa.eu/949/netElement</seealso>
    let netElement = Prefixed_Name(era, "netElement") |> PrefixedName
    /// <summary>
    ///   <para>era:netReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The reference that a physical infrastructure element has it on the topology. It may be used to define the positioning or a representation as a point, line or area"</para>
    /// labels<para>"net reference"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/netReference">http://data.europa.eu/949/netReference</seealso>
    let netReference = Prefixed_Name(era, "netReference") |> PrefixedName

    /// <summary>
    ///   <para>era:networkStatementsDataCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Network statements characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.europa.eu/949/networkStatementsDataCharacteristic">http://data.europa.eu/949/networkStatementsDataCharacteristic</seealso>
    let networkStatementsDataCharacteristic =
        Prefixed_Name(era, "networkStatementsDataCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>era:nonCodedRestrictions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Denotes a non-coded restrictions for this particular vehicleType, as a set of sentences."</para>
    /// labels<para>"Non coded restrictions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/nonCodedRestrictions">http://data.europa.eu/949/nonCodedRestrictions</seealso>
    let nonCodedRestrictions =
        Prefixed_Name(era, "nonCodedRestrictions") |> PrefixedName

    /// <summary>
    ///   <para>era:notApplicable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Reference to a property that is not applicable."</para>
    /// labels<para>"Not applicable"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/notApplicable">http://data.europa.eu/949/notApplicable</seealso>
    let notApplicable = Prefixed_Name(era, "notApplicable") |> PrefixedName
    /// <summary>
    ///   <para>era:notYetAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Reference to a property that is not provided."</para>
    /// labels<para>"Not provided"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/notYetAvailable">http://data.europa.eu/949/notYetAvailable</seealso>
    let notYetAvailable = Prefixed_Name(era, "notYetAvailable") |> PrefixedName

    /// <summary>
    ///   <para>era:numberElementsRakeFreightWagons</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of elements in the rake of freight wagons (only for subcategory 'rake of freight wagons')"</para>
    /// labels<para>"Number elements rake freight wagons"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/numberElementsRakeFreightWagons">http://data.europa.eu/949/numberElementsRakeFreightWagons</seealso>
    let numberElementsRakeFreightWagons =
        Prefixed_Name(era, "numberElementsRakeFreightWagons") |> PrefixedName

    /// <summary>
    ///   <para>era:numberOfPantographsInContactWithOCL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of pantographs in contact with the overhead contact line (OCL) (to be indicated for each energy supply system the vehicle is equipped for)."</para>
    /// labels<para>"Number of pantographs in contact with OCL"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/numberOfPantographsInContactWithOCL">http://data.europa.eu/949/numberOfPantographsInContactWithOCL</seealso>
    let numberOfPantographsInContactWithOCL =
        Prefixed_Name(era, "numberOfPantographsInContactWithOCL") |> PrefixedName

    /// <summary>
    ///   <para>era:numberOfToilets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of toilets."</para>
    /// labels<para>"Number of toilets"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/numberOfToilets">http://data.europa.eu/949/numberOfToilets</seealso>
    let numberOfToilets = Prefixed_Name(era, "numberOfToilets") |> PrefixedName

    /// <summary>
    ///   <para>era:oclSeparationSectionsDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"OCL separation sections"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/oclSeparationSectionsDataParameter">http://data.europa.eu/949/oclSeparationSectionsDataParameter</seealso>
    let oclSeparationSectionsDataParameter =
        Prefixed_Name(era, "oclSeparationSectionsDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:oclSeparationSectionsObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"OCL separation sections"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/oclSeparationSectionsObjParameter">http://data.europa.eu/949/oclSeparationSectionsObjParameter</seealso>
    let oclSeparationSectionsObjParameter =
        Prefixed_Name(era, "oclSeparationSectionsObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:oclType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"OCL type."</para>
    /// labels<para>"Ocl type"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/oclType">http://data.europa.eu/949/oclType</seealso>
    let oclType = Prefixed_Name(era, "oclType") |> PrefixedName
    /// <summary>
    ///   <para>era:ofParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the parameter (object or datatype property) for which an applicability is being defined."</para>
    /// labels<para>"of parameter"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/ofParameter">http://data.europa.eu/949/ofParameter</seealso>
    let ofParameter = Prefixed_Name(era, "ofParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:offsetFromKilometricPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Relative distance from a reference kilometric post "</para>
    /// labels<para>"offset"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/offsetFromKilometricPost">http://data.europa.eu/949/offsetFromKilometricPost</seealso>
    let offsetFromKilometricPost =
        Prefixed_Name(era, "offsetFromKilometricPost") |> PrefixedName

    /// <summary>
    ///   <para>era:offsetFromOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Offset from the origin in a topological coordinate."</para>
    /// labels<para>"offset from origin"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/offsetFromOrigin">http://data.europa.eu/949/offsetFromOrigin</seealso>
    let offsetFromOrigin = Prefixed_Name(era, "offsetFromOrigin") |> PrefixedName
    /// <summary>
    ///   <para>era:onElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the linear element a section belongs to."</para>
    /// labels<para>"on element"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/onElement">http://data.europa.eu/949/onElement</seealso>
    let onElement = Prefixed_Name(era, "onElement") |> PrefixedName
    /// <summary>
    ///   <para>era:onLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the linear element a coordinate is associated with."</para>
    /// labels<para>"on linear element"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/onLinearElement">http://data.europa.eu/949/onLinearElement</seealso>
    let onLinearElement = Prefixed_Name(era, "onLinearElement") |> PrefixedName
    /// <summary>
    ///   <para>era:opEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Operational point at the end of section of line (kilometres increasing from start OP to the end OP)."</para>
    /// labels<para>"Operational point at end of section of line"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/opEnd">http://data.europa.eu/949/opEnd</seealso>
    let opEnd = Prefixed_Name(era, "opEnd") |> PrefixedName

    /// <summary>
    ///   <para>era:opGenericDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Operational point generic information"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/opGenericDataParameter">http://data.europa.eu/949/opGenericDataParameter</seealso>
    let opGenericDataParameter =
        Prefixed_Name(era, "opGenericDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:opGenericObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Operational point generic information"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/opGenericObjParameter">http://data.europa.eu/949/opGenericObjParameter</seealso>
    let opGenericObjParameter =
        Prefixed_Name(era, "opGenericObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:opInfoPerCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an operational point that represents the general information of a border point to the information that each country maintains for the border point."</para>
    /// labels<para>"Border point information per country"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/opInfoPerCountry">http://data.europa.eu/949/opInfoPerCountry</seealso>
    let opInfoPerCountry = Prefixed_Name(era, "opInfoPerCountry") |> PrefixedName
    /// <summary>
    ///   <para>era:opName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name normally related to the town or village or to traffic control purpose."</para>
    /// labels<para>"Name of operational point"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/opName">http://data.europa.eu/949/opName</seealso>
    let opName = Prefixed_Name(era, "opName") |> PrefixedName
    /// <summary>
    ///   <para>era:opStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Operational point at the start of section of line (kilometres increasing from start OP to the end OP)."</para>
    /// labels<para>"Operational point at start of section of line"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/opStart">http://data.europa.eu/949/opStart</seealso>
    let opStart = Prefixed_Name(era, "opStart") |> PrefixedName
    /// <summary>
    ///   <para>era:opType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Type of facility in relation to the dominating operational functions."</para>
    /// labels<para>"Type of operational point"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/opType">http://data.europa.eu/949/opType</seealso>
    let opType = Prefixed_Name(era, "opType") |> PrefixedName

    /// <summary>
    ///   <para>era:opTypeGaugeChangeover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Type of track gauge changeover facility."</para>
    /// labels<para>"Type of track gauge changeover facility"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/opTypeGaugeChangeover">http://data.europa.eu/949/opTypeGaugeChangeover</seealso>
    let opTypeGaugeChangeover =
        Prefixed_Name(era, "opTypeGaugeChangeover") |> PrefixedName

    /// <summary>
    ///   <para>era:openingHoursLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Opening hours of the section of a line or tunnel or a bridge"</para>
    /// labels<para>"Opening hours limitation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/openingHoursLimitation">http://data.europa.eu/949/openingHoursLimitation</seealso>
    let openingHoursLimitation =
        Prefixed_Name(era, "openingHoursLimitation") |> PrefixedName

    /// <summary>
    ///   <para>era:operatingLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The language or languages used in daily operation by infrastructure manager and published in its Network Statement, for the communication of operational or safety related messages between the staff of the infrastructure manager and the railway undertaking."</para>
    /// labels<para>"Operating language"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/operatingLanguage">http://data.europa.eu/949/operatingLanguage</seealso>
    let operatingLanguage = Prefixed_Name(era, "operatingLanguage") |> PrefixedName

    /// <summary>
    ///   <para>era:operationalRegimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Double track type."</para>
    /// labels<para>"Operational regime"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/operationalRegimeType">http://data.europa.eu/949/operationalRegimeType</seealso>
    let operationalRegimeType =
        Prefixed_Name(era, "operationalRegimeType") |> PrefixedName

    /// <summary>
    ///   <para>era:operationalRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates an operational restriction of vehicle or wagon. Parking brake type (if the vehicle is fitted with it)."</para>
    /// labels<para>"Operational restriction"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/operationalRestriction">http://data.europa.eu/949/operationalRestriction</seealso>
    let operationalRestriction =
        Prefixed_Name(era, "operationalRestriction") |> PrefixedName

    /// <summary>
    ///   <para>era:organisationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Infrastructure manager means any body or undertaking that is responsible in particular for establishing and maintaining railway infrastructure or a part thereof."</para>
    ///   <para>"Four alpha-numeric code allocated by ERA to a body. It represents the Infrastructure Manager (IM) code in RINF.
    /// Infrastructure manager means any body or firm responsible in particular for establishing, managing and maintaining railway infrastructure, including traffic management and control-command signalling;
    /// the functions of the infrastructure manager on a network or part of a network may be allocated to different bodies or firms. Definition in (Article 3(2))"</para>
    /// labels<para>"organisation code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.europa.eu/949/organisationCode">http://data.europa.eu/949/organisationCode</seealso>
    let organisationCode = Prefixed_Name(era, "organisationCode") |> PrefixedName
    /// <summary>
    ///   <para>era:osmClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"(deprecated) not in use anymore"</para>
    /// labels<para>"Open street map class"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/osmClass">http://data.europa.eu/949/osmClass</seealso>
    let osmClass = Prefixed_Name(era, "osmClass") |> PrefixedName

    /// <summary>
    ///   <para>era:otherCantDeficiencyBasicSSP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Essential information for drivers of trains with a worse (lower) tolerated cant deficiency than those for which the ETCS trackside provides SSP (Static Speed Profiles) in conjunction with parameter "Cant Deficiency used for the basic SSP".
    /// According to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"Other Cant Deficiency train categories for which the ETCS trackside is configured to provide SSP"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/otherCantDeficiencyBasicSSP">http://data.europa.eu/949/otherCantDeficiencyBasicSSP</seealso>
    let otherCantDeficiencyBasicSSP =
        Prefixed_Name(era, "otherCantDeficiencyBasicSSP") |> PrefixedName

    /// <summary>
    ///   <para>era:otherPantographHead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication of pantograph heads which are allowed to be used."</para>
    /// labels<para>"Accepted other pantograph heads"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/otherPantographHead">http://data.europa.eu/949/otherPantographHead</seealso>
    let otherPantographHead = Prefixed_Name(era, "otherPantographHead") |> PrefixedName

    /// <summary>
    ///   <para>era:otherRadioSystemsObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Radio Legacy Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.europa.eu/949/otherRadioSystemsObjParameter">http://data.europa.eu/949/otherRadioSystemsObjParameter</seealso>
    let otherRadioSystemsObjParameter =
        Prefixed_Name(era, "otherRadioSystemsObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:otherTrainDetectionSystemsDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Other train detection systems"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/otherTrainDetectionSystemsDataParameter">http://data.europa.eu/949/otherTrainDetectionSystemsDataParameter</seealso>
    let otherTrainDetectionSystemsDataParameter =
        Prefixed_Name(era, "otherTrainDetectionSystemsDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:otherTrainDetectionSystemsObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Other train detection systems"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/otherTrainDetectionSystemsObjParameter">http://data.europa.eu/949/otherTrainDetectionSystemsObjParameter</seealso>
    let otherTrainDetectionSystemsObjParameter =
        Prefixed_Name(era, "otherTrainDetectionSystemsObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:otherTrainProtection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of existence of other system than ETCS for degraded situation."</para>
    /// labels<para>"Other train protection, control and warning systems for degraded situation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/otherTrainProtection">http://data.europa.eu/949/otherTrainProtection</seealso>
    let otherTrainProtection =
        Prefixed_Name(era, "otherTrainProtection") |> PrefixedName

    /// <summary>
    ///   <para>era:pantographDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Pantograph"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/pantographDataParameter">http://data.europa.eu/949/pantographDataParameter</seealso>
    let pantographDataParameter =
        Prefixed_Name(era, "pantographDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:pantographObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Pantograph"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/pantographObjParameter">http://data.europa.eu/949/pantographObjParameter</seealso>
    let pantographObjParameter =
        Prefixed_Name(era, "pantographObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:parameterApplicability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Relates an infrastructure element or a common characteristics subset with the applicability of a certain parameter."</para>
    /// labels<para>"parameter applicability"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/parameterApplicability">http://data.europa.eu/949/parameterApplicability</seealso>
    let parameterApplicability =
        Prefixed_Name(era, "parameterApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:parameterValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property is used to link an applicability to the precise value of the parameter"</para>
    /// labels<para>"Parameter value"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/parameterValue">http://data.europa.eu/949/parameterValue</seealso>
    let parameterValue = Prefixed_Name(era, "parameterValue") |> PrefixedName
    /// <summary>
    ///   <para>era:parameterValueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the case of a change in the value of a parameter, there needs to be an information on the type of the new value. The “Value type” will have different possible options: “nominal”, “planned temporary restriction”, “permanent restriction”, “planned temporary closure”."</para>
    /// labels<para>"parameter value type"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/parameterValueType">http://data.europa.eu/949/parameterValueType</seealso>
    let parameterValueType = Prefixed_Name(era, "parameterValueType") |> PrefixedName
    /// <summary>
    ///   <para>era:parkingBrake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether all vehicles of this type must be equipped with a parking brake."</para>
    /// labels<para>"Parking brake"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/parkingBrake">http://data.europa.eu/949/parkingBrake</seealso>
    let parkingBrake = Prefixed_Name(era, "parkingBrake") |> PrefixedName

    /// <summary>
    ///   <para>era:parkingBrakeMandatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"All vehicles of this type must be equipped with a parking brake (parking brake mandatory for vehicles of this type)."</para>
    /// labels<para>"Parking brake mandatory"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/parkingBrakeMandatory">http://data.europa.eu/949/parkingBrakeMandatory</seealso>
    let parkingBrakeMandatory =
        Prefixed_Name(era, "parkingBrakeMandatory") |> PrefixedName

    /// <summary>
    ///   <para>era:parkingBrakeMaximumGradient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum gradient on which the unit is kept immobilised by the parking brake alone (if the vehicle is fitted with it)."</para>
    /// labels<para>"Parking brake maximum gradient"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/parkingBrakeMaximumGradient">http://data.europa.eu/949/parkingBrakeMaximumGradient</seealso>
    let parkingBrakeMaximumGradient =
        Prefixed_Name(era, "parkingBrakeMaximumGradient") |> PrefixedName

    /// <summary>
    ///   <para>era:parkingBrakeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Parking brake type (if the vehicle is fitted with it)."</para>
    /// labels<para>"Parking brake type"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/parkingBrakeType">http://data.europa.eu/949/parkingBrakeType</seealso>
    let parkingBrakeType = Prefixed_Name(era, "parkingBrakeType") |> PrefixedName
    /// <summary>
    ///   <para>era:partOfTENT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Links an element to its TEN-T network classification, which includes network level, type of traffic, and European transport corridor information."</para>
    /// labels<para>"part of TEN-T"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/partOfTENT">http://data.europa.eu/949/partOfTENT</seealso>
    let partOfTENT = Prefixed_Name(era, "partOfTENT") |> PrefixedName
    /// <summary>
    ///   <para>era:passByNoiseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Pass-by noise level given in dB(A)."</para>
    /// labels<para>"Pass-by noise level"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/passByNoiseLevel">http://data.europa.eu/949/passByNoiseLevel</seealso>
    let passByNoiseLevel = Prefixed_Name(era, "passByNoiseLevel") |> PrefixedName
    /// <summary>
    ///   <para>era:passengerFlag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Passenger possible flag attached to a Primary Location"</para>
    /// labels<para>"passenger flag"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/passengerFlag">http://data.europa.eu/949/passengerFlag</seealso>
    let passengerFlag = Prefixed_Name(era, "passengerFlag") |> PrefixedName
    /// <summary>
    ///   <para>era:passesThroughTunnel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"References a tunnel that a track goes through."</para>
    /// labels<para>"Passes through tunnel"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/passesThroughTunnel">http://data.europa.eu/949/passesThroughTunnel</seealso>
    let passesThroughTunnel = Prefixed_Name(era, "passesThroughTunnel") |> PrefixedName

    /// <summary>
    ///   <para>era:performanceDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Performance parameter"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/performanceDataParameter">http://data.europa.eu/949/performanceDataParameter</seealso>
    let performanceDataParameter =
        Prefixed_Name(era, "performanceDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:performanceObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Performance parameter"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/performanceObjParameter">http://data.europa.eu/949/performanceObjParameter</seealso>
    let performanceObjParameter =
        Prefixed_Name(era, "performanceObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:permissiblePayload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Permissible payload for different line categories."</para>
    /// labels<para>"Permissible payload"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/permissiblePayload">http://data.europa.eu/949/permissiblePayload</seealso>
    let permissiblePayload = Prefixed_Name(era, "permissiblePayload") |> PrefixedName

    /// <summary>
    ///   <para>era:permissionChargingElectricEnergyTractionStandstill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Point at which IM authorises charging of electric energy storage for traction purposes at standstill."</para>
    /// labels<para>"Permission for charging electric energy storage for traction purposes at standstill"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/permissionChargingElectricEnergyTractionStandstill">http://data.europa.eu/949/permissionChargingElectricEnergyTractionStandstill</seealso>
    let permissionChargingElectricEnergyTractionStandstill =
        Prefixed_Name(era, "permissionChargingElectricEnergyTractionStandstill") |> PrefixedName

    /// <summary>
    ///   <para>era:permitUseReflectivePlates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sections where is permitted to use the reflective plates on rail freight corridors, with a view to prioritise the current bottlenecks. Specific case for Belgium, France, Italy, Portugal and Spain until 1.1.2026"</para>
    /// labels<para>"Permit of use of reflective plates"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/permitUseReflectivePlates">http://data.europa.eu/949/permitUseReflectivePlates</seealso>
    let permitUseReflectivePlates =
        Prefixed_Name(era, "permitUseReflectivePlates") |> PrefixedName

    /// <summary>
    ///   <para>era:permittedContactForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of contact force allowed expressed in newton."</para>
    /// labels<para>"Contact force permitted"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/permittedContactForce">http://data.europa.eu/949/permittedContactForce</seealso>
    let permittedContactForce =
        Prefixed_Name(era, "permittedContactForce") |> PrefixedName

    /// <summary>
    ///   <para>era:phaseInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Information on phase separation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/phaseInfo">http://data.europa.eu/949/phaseInfo</seealso>
    let phaseInfo = Prefixed_Name(era, "phaseInfo") |> PrefixedName

    /// <summary>
    ///   <para>era:phaseInfoChangeSupplySystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the phase info of a track that corresponds to the single selection of Y=yes or N=no to show if the energy supply system changes"</para>
    /// labels<para>"Phase info change supply system"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/phaseInfoChangeSupplySystem">http://data.europa.eu/949/phaseInfoChangeSupplySystem</seealso>
    let phaseInfoChangeSupplySystem =
        Prefixed_Name(era, "phaseInfoChangeSupplySystem") |> PrefixedName

    /// <summary>
    ///   <para>era:phaseInfoDistanceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the phase info of a track that corresponds to the single selection of 'MIN=minimum' or 'MAX=maximum' to show whether the length is a minimum distance between the inner contact strips of the pantographs or a maximum distance between the outer contact strips of the pantographs. Multiple strings for this parameter are accepted."</para>
    /// labels<para>"Phase info distance type"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/phaseInfoDistanceType">http://data.europa.eu/949/phaseInfoDistanceType</seealso>
    let phaseInfoDistanceType =
        Prefixed_Name(era, "phaseInfoDistanceType") |> PrefixedName

    /// <summary>
    ///   <para>era:phaseInfoKm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the phase info of a track that indicates the location from the start of the line where the new value is valid."</para>
    /// labels<para>"Phase info Km"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/phaseInfoKm">http://data.europa.eu/949/phaseInfoKm</seealso>
    let phaseInfoKm = Prefixed_Name(era, "phaseInfoKm") |> PrefixedName
    /// <summary>
    ///   <para>era:phaseInfoLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the phase info of a track that corresponds to the length of the phase separation in metres."</para>
    /// labels<para>"Phase info length"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/phaseInfoLength">http://data.europa.eu/949/phaseInfoLength</seealso>
    let phaseInfoLength = Prefixed_Name(era, "phaseInfoLength") |> PrefixedName

    /// <summary>
    ///   <para>era:phaseInfoPantographLowered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the phase info of a track that shows whether a pantograph has to be lowered."</para>
    /// labels<para>"Phase info pantograph lowered"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/phaseInfoPantographLowered">http://data.europa.eu/949/phaseInfoPantographLowered</seealso>
    let phaseInfoPantographLowered =
        Prefixed_Name(era, "phaseInfoPantographLowered") |> PrefixedName

    /// <summary>
    ///   <para>era:phaseInfoSwitchOffBreaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Part of the phase info of a track that shows whether the breaker has to be switched off."</para>
    /// labels<para>"Phase info switch off breaker"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/phaseInfoSwitchOffBreaker">http://data.europa.eu/949/phaseInfoSwitchOffBreaker</seealso>
    let phaseInfoSwitchOffBreaker =
        Prefixed_Name(era, "phaseInfoSwitchOffBreaker") |> PrefixedName

    /// <summary>
    ///   <para>era:platformDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Platform"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/platformDataParameter">http://data.europa.eu/949/platformDataParameter</seealso>
    let platformDataParameter =
        Prefixed_Name(era, "platformDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:platformEdge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Reference to a related platform edge."</para>
    /// labels<para>"Platform edge"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/platformEdge">http://data.europa.eu/949/platformEdge</seealso>
    let platformEdge = Prefixed_Name(era, "platformEdge") |> PrefixedName
    /// <summary>
    ///   <para>era:platformHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Distance between the upper surface of platform and running surface of the neighbouring track. It is the nominal value expressed in millimetres."</para>
    /// labels<para>"Height of platform"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/platformHeight">http://data.europa.eu/949/platformHeight</seealso>
    let platformHeight = Prefixed_Name(era, "platformHeight") |> PrefixedName
    /// <summary>
    ///   <para>era:platformId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Unique platform identification or unique platform number within an Operational Point."</para>
    /// labels<para>"Identification of platform"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/platformId">http://data.europa.eu/949/platformId</seealso>
    let platformId = Prefixed_Name(era, "platformId") |> PrefixedName

    /// <summary>
    ///   <para>era:platformObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Platform"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/platformObjParameter">http://data.europa.eu/949/platformObjParameter</seealso>
    let platformObjParameter =
        Prefixed_Name(era, "platformObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:portableBoardingAids</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Description of any portable boarding aids if considered in the design of the vehicle for meeting the PRM TSI requirements."</para>
    /// labels<para>"Portable boarding aids"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/portableBoardingAids">http://data.europa.eu/949/portableBoardingAids</seealso>
    let portableBoardingAids =
        Prefixed_Name(era, "portableBoardingAids") |> PrefixedName

    /// <summary>
    ///   <para>era:positionOnA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Determines the position of the topological object A in a relation."</para>
    /// labels<para>"Position on A"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/positionOnA">http://data.europa.eu/949/positionOnA</seealso>
    let positionOnA = Prefixed_Name(era, "positionOnA") |> PrefixedName
    /// <summary>
    ///   <para>era:positionOnB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Determines the position of the topological object B in a relation."</para>
    /// labels<para>"Position on B"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/positionOnB">http://data.europa.eu/949/positionOnB</seealso>
    let positionOnB = Prefixed_Name(era, "positionOnB") |> PrefixedName

    /// <summary>
    ///   <para>era:preventRegenerativeBrakeUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Possibility of preventing the use of the regenerative brake (only if fitted with regenerative brake)."</para>
    /// labels<para>"Prevent regenerative brake use"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/preventRegenerativeBrakeUse">http://data.europa.eu/949/preventRegenerativeBrakeUse</seealso>
    let preventRegenerativeBrakeUse =
        Prefixed_Name(era, "preventRegenerativeBrakeUse") |> PrefixedName

    /// <summary>
    ///   <para>era:previousVehicleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes a the previous VehicleType."</para>
    /// labels<para>"Previous vehicle type"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/previousVehicleType">http://data.europa.eu/949/previousVehicleType</seealso>
    let previousVehicleType = Prefixed_Name(era, "previousVehicleType") |> PrefixedName
    /// <summary>
    ///   <para>era:primaryLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Primary location code developed for information exchange in accordance with the TSIs relating to the telematics applications subsystem."</para>
    /// labels<para>"primary location"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/primaryLocation">http://data.europa.eu/949/primaryLocation</seealso>
    let primaryLocation = Prefixed_Name(era, "primaryLocation") |> PrefixedName
    /// <summary>
    ///   <para>era:primaryLocationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Primary location code developed for information exchange in accordance with the TSIs relating to the telematics applications subsystem."</para>
    /// labels<para>"primary location code"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/primaryLocationCode">http://data.europa.eu/949/primaryLocationCode</seealso>
    let primaryLocationCode = Prefixed_Name(era, "primaryLocationCode") |> PrefixedName
    /// <summary>
    ///   <para>era:primaryLocationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"primary location name"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/primaryLocationName">http://data.europa.eu/949/primaryLocationName</seealso>
    let primaryLocationName = Prefixed_Name(era, "primaryLocationName") |> PrefixedName
    /// <summary>
    ///   <para>era:prioritySeats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of priority seats."</para>
    /// labels<para>"Priority seats"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/prioritySeats">http://data.europa.eu/949/prioritySeats</seealso>
    let prioritySeats = Prefixed_Name(era, "prioritySeats") |> PrefixedName

    /// <summary>
    ///   <para>era:prmAccessibleToilets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of PRM accessible toilets."</para>
    /// labels<para>"Prm accessible toilets"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/prmAccessibleToilets">http://data.europa.eu/949/prmAccessibleToilets</seealso>
    let prmAccessibleToilets =
        Prefixed_Name(era, "prmAccessibleToilets") |> PrefixedName

    /// <summary>
    ///   <para>era:profileNumberSemiTrailers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Coding for combined transport for semi-trailers (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B]."</para>
    /// labels<para>"Standard combined transport profile number for semi-trailers"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/profileNumberSemiTrailers">http://data.europa.eu/949/profileNumberSemiTrailers</seealso>
    let profileNumberSemiTrailers =
        Prefixed_Name(era, "profileNumberSemiTrailers") |> PrefixedName

    /// <summary>
    ///   <para>era:profileNumberSwapBodies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Coding for combined transport with swap bodies (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B]"</para>
    /// labels<para>"Standard combined transport profile number for swap bodies"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/profileNumberSwapBodies">http://data.europa.eu/949/profileNumberSwapBodies</seealso>
    let profileNumberSwapBodies =
        Prefixed_Name(era, "profileNumberSwapBodies") |> PrefixedName

    /// <summary>
    ///   <para>era:protectionLegacySystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication of which class B system is installed."</para>
    /// labels<para>"Train protection legacy system"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/protectionLegacySystem">http://data.europa.eu/949/protectionLegacySystem</seealso>
    let protectionLegacySystem =
        Prefixed_Name(era, "protectionLegacySystem") |> PrefixedName

    /// <summary>
    ///   <para>era:publicNetworkRoaming</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Existence of roaming to a public network.
    ///
    ///                          In case of Y, provide the name of the public network(s) under parameter "Details on GSM-R roaming to public networks"."</para>
    /// labels<para>"Existence of GSM-R roaming to public networks"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/publicNetworkRoaming">http://data.europa.eu/949/publicNetworkRoaming</seealso>
    let publicNetworkRoaming =
        Prefixed_Name(era, "publicNetworkRoaming") |> PrefixedName

    /// <summary>
    ///   <para>era:publicNetworkRoamingDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"If roaming to public networks is configured, please indicate to which networks, for which users and in which areas."</para>
    /// labels<para>"Details on GSM-R roaming to public networks"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/publicNetworkRoamingDetails">http://data.europa.eu/949/publicNetworkRoamingDetails</seealso>
    let publicNetworkRoamingDetails =
        Prefixed_Name(era, "publicNetworkRoamingDetails") |> PrefixedName

    /// <summary>
    ///   <para>era:qNvdriverAdhes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Qualifier determining whether the driver is allowed to modify the adhesion factor used by the ETCS on-board to calculate the braking curves.
    /// According to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"Q_NVDRIVER_ADHES"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/qNvdriverAdhes">http://data.europa.eu/949/qNvdriverAdhes</seealso>
    let qNvdriverAdhes = Prefixed_Name(era, "qNvdriverAdhes") |> PrefixedName
    /// <summary>
    ///   <para>era:qNvemrrls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Qualifier defining whether the application of the emergency brake for reasons other than a trip can be revoked as soon as the conditions for it have disappeared or after the train has come to a complete standstill.
    /// According to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"Q_NVEMRRLS"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/qNvemrrls">http://data.europa.eu/949/qNvemrrls</seealso>
    let qNvemrrls = Prefixed_Name(era, "qNvemrrls") |> PrefixedName
    /// <summary>
    ///   <para>era:qNvsbtsmperm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Permission to use service brake in target speed monitoring"</para>
    /// labels<para>"Q_NVSBTSMPERM"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/qNvsbtsmperm">http://data.europa.eu/949/qNvsbtsmperm</seealso>
    let qNvsbtsmperm = Prefixed_Name(era, "qNvsbtsmperm") |> PrefixedName

    /// <summary>
    ///   <para>era:quasiStaticGuidingForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Quasi-static guiding force (if exceeds the limit defined in TSI or not defined in the TSI), given in kN."</para>
    /// labels<para>"Quasi static guiding force"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/quasiStaticGuidingForce">http://data.europa.eu/949/quasiStaticGuidingForce</seealso>
    let quasiStaticGuidingForce =
        Prefixed_Name(era, "quasiStaticGuidingForce") |> PrefixedName

    /// <summary>
    ///   <para>era:quieterRoutesExemptedCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Country where a vehicle may operate without noise restrictions."</para>
    /// labels<para>"Quieter route exempted country"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/quieterRoutesExemptedCountry">http://data.europa.eu/949/quieterRoutesExemptedCountry</seealso>
    let quieterRoutesExemptedCountry =
        Prefixed_Name(era, "quieterRoutesExemptedCountry") |> PrefixedName

    /// <summary>
    ///   <para>era:radioNetworkId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Unique identification of the GSM-R network the calling mobile station has to register with, as defined in the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"Radio Network ID"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/radioNetworkId">http://data.europa.eu/949/radioNetworkId</seealso>
    let radioNetworkId = Prefixed_Name(era, "radioNetworkId") |> PrefixedName

    /// <summary>
    ///   <para>era:radioSwitchOverSpecialConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Special conditions implemented on-board to switch over between different radio systems. Given as combination of systems installed on board ('System XX'_'System YY')."</para>
    /// labels<para>"Radio switch over special conditions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/radioSwitchOverSpecialConditions">http://data.europa.eu/949/radioSwitchOverSpecialConditions</seealso>
    let radioSwitchOverSpecialConditions =
        Prefixed_Name(era, "radioSwitchOverSpecialConditions") |> PrefixedName

    /// <summary>
    ///   <para>era:railInclination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"An angle defining the inclination of the head of a rail relative to the running surface."</para>
    /// labels<para>"Rail inclination"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/railInclination">http://data.europa.eu/949/railInclination</seealso>
    let railInclination = Prefixed_Name(era, "railInclination") |> PrefixedName
    /// <summary>
    ///   <para>era:railSystemType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"(deprecated) Type of railway system. Can be "High-speed" or "Conventional". Deprecated due to the lack of information"</para>
    /// labels<para>"Rail system type"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/railSystemType">http://data.europa.eu/949/railSystemType</seealso>
    let railSystemType = Prefixed_Name(era, "railSystemType") |> PrefixedName

    /// <summary>
    ///   <para>era:raisedPantographsDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the raised pantographs distance and speed of a track that corresponds to the minimum distance between pantographs, in metres."</para>
    /// labels<para>"Requirements for spacing between raised pantographs, at the given speed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/raisedPantographsDistance">http://data.europa.eu/949/raisedPantographsDistance</seealso>
    let raisedPantographsDistance =
        Prefixed_Name(era, "raisedPantographsDistance") |> PrefixedName

    /// <summary>
    ///   <para>era:raisedPantographsDistanceAndSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed."</para>
    /// labels<para>"(deprecated) Requirements for number of raised pantographs and spacing between them, at the given speed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/raisedPantographsDistanceAndSpeed">http://data.europa.eu/949/raisedPantographsDistanceAndSpeed</seealso>
    let raisedPantographsDistanceAndSpeed =
        Prefixed_Name(era, "raisedPantographsDistanceAndSpeed") |> PrefixedName

    /// <summary>
    ///   <para>era:raisedPantographsNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the raised pantographs distance and speed of a track that corresponds to the number of pantographs."</para>
    /// labels<para>"Requirements for number of raised pantographs, at the given speed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/raisedPantographsNumber">http://data.europa.eu/949/raisedPantographsNumber</seealso>
    let raisedPantographsNumber =
        Prefixed_Name(era, "raisedPantographsNumber") |> PrefixedName

    /// <summary>
    ///   <para>era:raisedPantographsSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed."</para>
    /// labels<para>"Raised pantographs speed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/raisedPantographsSpeed">http://data.europa.eu/949/raisedPantographsSpeed</seealso>
    let raisedPantographsSpeed =
        Prefixed_Name(era, "raisedPantographsSpeed") |> PrefixedName

    /// <summary>
    ///   <para>era:rbcID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Unique RBC identification (NID_C+NID_RBC)  as defined in the specification referenced in Appendix A-1, index [C] (TSI CCS)."</para>
    /// labels<para>"ID of ERTMS/ETCS Radio Block Center"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/rbcID">http://data.europa.eu/949/rbcID</seealso>
    let rbcID = Prefixed_Name(era, "rbcID") |> PrefixedName
    /// <summary>
    ///   <para>era:rbcPhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique RBC calling number (NID_RADIO) as defined in the specification referenced in Appendix A-1, index [C]."</para>
    /// labels<para>"Phone number of ERTMS/ETCS Radio Block Center"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/rbcPhone">http://data.europa.eu/949/rbcPhone</seealso>
    let rbcPhone = Prefixed_Name(era, "rbcPhone") |> PrefixedName

    /// <summary>
    ///   <para>era:reasonsEtcsRadioBlockCenterReject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"List of cases subject to system design choices made by the infrastructure manager according to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"Reasons for which an ETCS Radio Block Center can reject a train"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/reasonsEtcsRadioBlockCenterReject">http://data.europa.eu/949/reasonsEtcsRadioBlockCenterReject</seealso>
    let reasonsEtcsRadioBlockCenterReject =
        Prefixed_Name(era, "reasonsEtcsRadioBlockCenterReject") |> PrefixedName

    /// <summary>
    ///   <para>era:redLightsRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sections where permissive driving is possible in accordance with point 4.2.2.1.2 of TSI OPE"</para>
    ///   <para>"Sections where two steady red lights are required in accordance with TSI OPE"</para>
    /// labels<para>"Steady red lights required"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/redLightsRequired">http://data.europa.eu/949/redLightsRequired</seealso>
    let redLightsRequired = Prefixed_Name(era, "redLightsRequired") |> PrefixedName

    /// <summary>
    ///   <para>era:referenceBorderPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an operational point that is a border point with an instance of the list of reference border points that are specified in the RINF Application Guide."</para>
    /// labels<para>"reference border point"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/referenceBorderPoint">http://data.europa.eu/949/referenceBorderPoint</seealso>
    let referenceBorderPoint =
        Prefixed_Name(era, "referenceBorderPoint") |> PrefixedName

    /// <summary>
    ///   <para>era:referencePassByNoiseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Pass-by noise level was measured under reference conditions."</para>
    /// labels<para>"Reference pass-by noise level"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/referencePassByNoiseLevel">http://data.europa.eu/949/referencePassByNoiseLevel</seealso>
    let referencePassByNoiseLevel =
        Prefixed_Name(era, "referencePassByNoiseLevel") |> PrefixedName

    /// <summary>
    ///   <para>era:relatedElectromagneticInterferencesDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Parameters related to electromagnetic interferences"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/relatedElectromagneticInterferencesDataParameter">http://data.europa.eu/949/relatedElectromagneticInterferencesDataParameter</seealso>
    let relatedElectromagneticInterferencesDataParameter =
        Prefixed_Name(era, "relatedElectromagneticInterferencesDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:relativeDistanceDangerPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Distance in meters to the danger point"</para>
    /// labels<para>"Relative distance of the danger point"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/relativeDistanceDangerPoint">http://data.europa.eu/949/relativeDistanceDangerPoint</seealso>
    let relativeDistanceDangerPoint =
        Prefixed_Name(era, "relativeDistanceDangerPoint") |> PrefixedName

    /// <summary>
    ///   <para>era:relativePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the position of an object relative to the linear coordinates of the associated topological object."</para>
    /// labels<para>"Relative position"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/relativePosition">http://data.europa.eu/949/relativePosition</seealso>
    let relativePosition = Prefixed_Name(era, "relativePosition") |> PrefixedName

    /// <summary>
    ///   <para>era:requiredSandingOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication whether possibility to activate/deactivate sanding devices by driver, according to instructions from the Infrastructure Manager, is required or not. Deprecated according to the amendment to the Regulation (EU) 2019/777."</para>
    /// labels<para>"Sanding override by driver required"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/requiredSandingOverride">http://data.europa.eu/949/requiredSandingOverride</seealso>
    let requiredSandingOverride =
        Prefixed_Name(era, "requiredSandingOverride") |> PrefixedName

    /// <summary>
    ///   <para>era:requirementsRollingStockDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Requirements for rolling stock"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/requirementsRollingStockDataParameter">http://data.europa.eu/949/requirementsRollingStockDataParameter</seealso>
    let requirementsRollingStockDataParameter =
        Prefixed_Name(era, "requirementsRollingStockDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:requirementsRollingStockObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Requirements for rolling stock"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/requirementsRollingStockObjParameter">http://data.europa.eu/949/requirementsRollingStockObjParameter</seealso>
    let requirementsRollingStockObjParameter =
        Prefixed_Name(era, "requirementsRollingStockObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:restrictedDangerousGood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Description of the type of dangerous good that are not allowed in the tunnel"</para>
    /// labels<para>"Restricted dangerous goods"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/restrictedDangerousGood">http://data.europa.eu/949/restrictedDangerousGood</seealso>
    let restrictedDangerousGood =
        Prefixed_Name(era, "restrictedDangerousGood") |> PrefixedName

    /// <summary>
    ///   <para>era:restrictedPeriodOfTimeDangerousGood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Describes the period of time for which the transport of dangerous goods is not allowed in the Section of Line"</para>
    /// labels<para>"Restricted periods of time for dangerous goods transportation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/restrictedPeriodOfTimeDangerousGood">http://data.europa.eu/949/restrictedPeriodOfTimeDangerousGood</seealso>
    let restrictedPeriodOfTimeDangerousGood =
        Prefixed_Name(era, "restrictedPeriodOfTimeDangerousGood") |> PrefixedName

    /// <summary>
    ///   <para>era:restrictedTypeOfVehicleInTunnel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specific types of vehicles restricted in the tunnel."</para>
    /// labels<para>"Restricted type of vehicle in tunnel"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/restrictedTypeOfVehicleInTunnel">http://data.europa.eu/949/restrictedTypeOfVehicleInTunnel</seealso>
    let restrictedTypeOfVehicleInTunnel =
        Prefixed_Name(era, "restrictedTypeOfVehicleInTunnel") |> PrefixedName

    /// <summary>
    ///   <para>era:rinfIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Index code used in the original definition of a parameter in RINF."</para>
    /// labels<para>"RINF index"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/rinfIndex">http://data.europa.eu/949/rinfIndex</seealso>
    let rinfIndex = Prefixed_Name(era, "rinfIndex") |> PrefixedName

    /// <summary>
    ///   <para>era:rinfTechnicalDataCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"RINF Technical characteristic"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/rinfTechnicalDataCharacteristic">http://data.europa.eu/949/rinfTechnicalDataCharacteristic</seealso>
    let rinfTechnicalDataCharacteristic =
        Prefixed_Name(era, "rinfTechnicalDataCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>era:rinfTechnicalObjectCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"RINF Technical characteristic"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/rinfTechnicalObjectCharacteristic">http://data.europa.eu/949/rinfTechnicalObjectCharacteristic</seealso>
    let rinfTechnicalObjectCharacteristic =
        Prefixed_Name(era, "rinfTechnicalObjectCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>era:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the relationship of a Body to the organisation roles that it can play."</para>
    /// labels<para>"role"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/role">http://data.europa.eu/949/role</seealso>
    let role = Prefixed_Name(era, "role") |> PrefixedName
    /// <summary>
    ///   <para>era:roleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the corresponding Body that plays a certain organisation role."</para>
    /// labels<para>"role of"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/roleOf">http://data.europa.eu/949/roleOf</seealso>
    let roleOf = Prefixed_Name(era, "roleOf") |> PrefixedName

    /// <summary>
    ///   <para>era:rollingStockFireCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Categorisation how a passenger train with a fire on board will continue to operate for a defined time period"</para>
    ///   <para>"Passenger train fire category in accordance with point 4.1.4 of TSI LOC&amp;PAS."</para>
    /// labels<para>"Fire category of rolling stock required"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/rollingStockFireCategory">http://data.europa.eu/949/rollingStockFireCategory</seealso>
    let rollingStockFireCategory =
        Prefixed_Name(era, "rollingStockFireCategory") |> PrefixedName

    /// <summary>
    ///   <para>era:routeBookDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Route book specific parameters"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/routeBookDataParameter">http://data.europa.eu/949/routeBookDataParameter</seealso>
    let routeBookDataParameter =
        Prefixed_Name(era, "routeBookDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:routeBookObjectParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Route book specific parameters"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/routeBookObjectParameter">http://data.europa.eu/949/routeBookObjectParameter</seealso>
    let routeBookObjectParameter =
        Prefixed_Name(era, "routeBookObjectParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:rulesDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Rules and restrictions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/rulesDataParameter">http://data.europa.eu/949/rulesDataParameter</seealso>
    let rulesDataParameter = Prefixed_Name(era, "rulesDataParameter") |> PrefixedName
    /// <summary>
    ///   <para>era:rulesObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Rules and restrictions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/rulesObjParameter">http://data.europa.eu/949/rulesObjParameter</seealso>
    let rulesObjParameter = Prefixed_Name(era, "rulesObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:safeConsistLengthInformationNecessary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indication whether safe consist train length information from on-board is required to access the line for safety reasons and the required safety integrity level."</para>
    /// labels<para>"Safe consist length information from on-board necessary for access the line and SIL"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/safeConsistLengthInformationNecessary">http://data.europa.eu/949/safeConsistLengthInformationNecessary</seealso>
    let safeConsistLengthInformationNecessary =
        Prefixed_Name(era, "safeConsistLengthInformationNecessary") |> PrefixedName

    /// <summary>
    ///   <para>era:schematicOverviewOP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Document providing the schematic overview of the operational point"</para>
    /// labels<para>"Schematic overview of the operational point"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/schematicOverviewOP">http://data.europa.eu/949/schematicOverviewOP</seealso>
    let schematicOverviewOP = Prefixed_Name(era, "schematicOverviewOP") |> PrefixedName
    /// <summary>
    ///   <para>era:scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Annotation property used in SHACL shapes. Indicates if the SHACL shape is validating a property of a specific instance ("local"), or if it needs to check other instances ("global"). For example, SHACL shape to validate no repeated ids within a specific track."</para>
    /// labels<para>"scope"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/scope">http://data.europa.eu/949/scope</seealso>
    let scope = Prefixed_Name(era, "scope") |> PrefixedName

    /// <summary>
    ///   <para>era:shaclShapeValidationRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Annotation used to point to the SHACL shape that implements the validation for a certain RINF parameter (property). Each shape contains constraints for valid datatypes, patterns, min and max count, valid SKOS values and business rules."</para>
    /// labels<para>"SHACL shape validation rule"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/shaclShapeValidationRule">http://data.europa.eu/949/shaclShapeValidationRule</seealso>
    let shaclShapeValidationRule =
        Prefixed_Name(era, "shaclShapeValidationRule") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AccelerationLevelCrossing</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AccelerationLevelCrossing">http://data.europa.eu/949/shapes/AccelerationLevelCrossing</seealso>
    let ``shapes/AccelerationLevelCrossing`` =
        Prefixed_Name(era, "shapes/AccelerationLevelCrossing") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AccelerationLevelCrossingApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AccelerationLevelCrossingApplicability">http://data.europa.eu/949/shapes/AccelerationLevelCrossingApplicability</seealso>
    let ``shapes/AccelerationLevelCrossingApplicability`` =
        Prefixed_Name(era, "shapes/AccelerationLevelCrossingApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AdditionalBrakingInformationDocument</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AdditionalBrakingInformationDocument">http://data.europa.eu/949/shapes/AdditionalBrakingInformationDocument</seealso>
    let ``shapes/AdditionalBrakingInformationDocument`` =
        Prefixed_Name(era, "shapes/AdditionalBrakingInformationDocument") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AdditionalBrakingInformationDocumentApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AdditionalBrakingInformationDocumentApplicability">http://data.europa.eu/949/shapes/AdditionalBrakingInformationDocumentApplicability</seealso>
    let ``shapes/AdditionalBrakingInformationDocumentApplicability`` =
        Prefixed_Name(era, "shapes/AdditionalBrakingInformationDocumentApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/Aggregates</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/Aggregates">http://data.europa.eu/949/shapes/Aggregates</seealso>
    let ``shapes/Aggregates`` = Prefixed_Name(era, "shapes/Aggregates") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AllocationCompany</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AllocationCompany">http://data.europa.eu/949/shapes/AllocationCompany</seealso>
    let ``shapes/AllocationCompany`` =
        Prefixed_Name(era, "shapes/AllocationCompany") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AppliesInBothDirections</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AppliesInBothDirections">http://data.europa.eu/949/shapes/AppliesInBothDirections</seealso>
    let ``shapes/AppliesInBothDirections`` =
        Prefixed_Name(era, "shapes/AppliesInBothDirections") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AppliesToDirection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AppliesToDirection">http://data.europa.eu/949/shapes/AppliesToDirection</seealso>
    let ``shapes/AppliesToDirection`` =
        Prefixed_Name(era, "shapes/AppliesToDirection") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AppliesToDirectionSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AppliesToDirectionSKOS">http://data.europa.eu/949/shapes/AppliesToDirectionSKOS</seealso>
    let ``shapes/AppliesToDirectionSKOS`` =
        Prefixed_Name(era, "shapes/AppliesToDirectionSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AreaBoardingAid</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AreaBoardingAid">http://data.europa.eu/949/shapes/AreaBoardingAid</seealso>
    let ``shapes/AreaBoardingAid`` =
        Prefixed_Name(era, "shapes/AreaBoardingAid") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AsWKT</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AsWKT">http://data.europa.eu/949/shapes/AsWKT</seealso>
    let ``shapes/AsWKT`` = Prefixed_Name(era, "shapes/AsWKT") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AssistanceStartingTrain</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AssistanceStartingTrain">http://data.europa.eu/949/shapes/AssistanceStartingTrain</seealso>
    let ``shapes/AssistanceStartingTrain`` =
        Prefixed_Name(era, "shapes/AssistanceStartingTrain") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AtoCommunicationSystem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AtoCommunicationSystem">http://data.europa.eu/949/shapes/AtoCommunicationSystem</seealso>
    let ``shapes/AtoCommunicationSystem`` =
        Prefixed_Name(era, "shapes/AtoCommunicationSystem") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AtoCommunicationSystemSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AtoCommunicationSystemSKOS">http://data.europa.eu/949/shapes/AtoCommunicationSystemSKOS</seealso>
    let ``shapes/AtoCommunicationSystemSKOS`` =
        Prefixed_Name(era, "shapes/AtoCommunicationSystemSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AtoGradeAutomation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AtoGradeAutomation">http://data.europa.eu/949/shapes/AtoGradeAutomation</seealso>
    let ``shapes/AtoGradeAutomation`` =
        Prefixed_Name(era, "shapes/AtoGradeAutomation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AtoGradeAutomationSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AtoGradeAutomationSKOS">http://data.europa.eu/949/shapes/AtoGradeAutomationSKOS</seealso>
    let ``shapes/AtoGradeAutomationSKOS`` =
        Prefixed_Name(era, "shapes/AtoGradeAutomationSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AtoSystemVersion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AtoSystemVersion">http://data.europa.eu/949/shapes/AtoSystemVersion</seealso>
    let ``shapes/AtoSystemVersion`` =
        Prefixed_Name(era, "shapes/AtoSystemVersion") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AtoSystemVersionSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AtoSystemVersionSKOS">http://data.europa.eu/949/shapes/AtoSystemVersionSKOS</seealso>
    let ``shapes/AtoSystemVersionSKOS`` =
        Prefixed_Name(era, "shapes/AtoSystemVersionSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AutomaticDroppingDeviceRequired</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AutomaticDroppingDeviceRequired">http://data.europa.eu/949/shapes/AutomaticDroppingDeviceRequired</seealso>
    let ``shapes/AutomaticDroppingDeviceRequired`` =
        Prefixed_Name(era, "shapes/AutomaticDroppingDeviceRequired") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/AutomaticDroppingDeviceRequiredApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/AutomaticDroppingDeviceRequiredApplicability">http://data.europa.eu/949/shapes/AutomaticDroppingDeviceRequiredApplicability</seealso>
    let ``shapes/AutomaticDroppingDeviceRequiredApplicability`` =
        Prefixed_Name(era, "shapes/AutomaticDroppingDeviceRequiredApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/BelongsTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/BelongsTo">http://data.europa.eu/949/shapes/BelongsTo</seealso>
    let ``shapes/BelongsTo`` = Prefixed_Name(era, "shapes/BelongsTo") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/BelongsToUniqueIM</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/BelongsToUniqueIM">http://data.europa.eu/949/shapes/BelongsToUniqueIM</seealso>
    let ``shapes/BelongsToUniqueIM`` =
        Prefixed_Name(era, "shapes/BelongsToUniqueIM") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/BigMetalMass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/BigMetalMass">http://data.europa.eu/949/shapes/BigMetalMass</seealso>
    let ``shapes/BigMetalMass`` =
        Prefixed_Name(era, "shapes/BigMetalMass") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/BigMetalMassApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/BigMetalMassApplicability">http://data.europa.eu/949/shapes/BigMetalMassApplicability</seealso>
    let ``shapes/BigMetalMassApplicability`` =
        Prefixed_Name(era, "shapes/BigMetalMassApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/BodyShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/BodyShape">http://data.europa.eu/949/shapes/BodyShape</seealso>
    let ``shapes/BodyShape`` = Prefixed_Name(era, "shapes/BodyShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/BorderPointId</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/BorderPointId">http://data.europa.eu/949/shapes/BorderPointId</seealso>
    let ``shapes/BorderPointId`` =
        Prefixed_Name(era, "shapes/BorderPointId") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/BorderPointUopidPrefix</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/BorderPointUopidPrefix">http://data.europa.eu/949/shapes/BorderPointUopidPrefix</seealso>
    let ``shapes/BorderPointUopidPrefix`` =
        Prefixed_Name(era, "shapes/BorderPointUopidPrefix") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/BorderPointValidCodeAndCoordinates</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/BorderPointValidCodeAndCoordinates">http://data.europa.eu/949/shapes/BorderPointValidCodeAndCoordinates</seealso>
    let ``shapes/BorderPointValidCodeAndCoordinates`` =
        Prefixed_Name(era, "shapes/BorderPointValidCodeAndCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/BorderPointValidCoordinates</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/BorderPointValidCoordinates">http://data.europa.eu/949/shapes/BorderPointValidCoordinates</seealso>
    let ``shapes/BorderPointValidCoordinates`` =
        Prefixed_Name(era, "shapes/BorderPointValidCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/BorderPointValidCoordinatesViaNetReference</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/BorderPointValidCoordinatesViaNetReference">http://data.europa.eu/949/shapes/BorderPointValidCoordinatesViaNetReference</seealso>
    let ``shapes/BorderPointValidCoordinatesViaNetReference`` =
        Prefixed_Name(era, "shapes/BorderPointValidCoordinatesViaNetReference") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/BridgeShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/BridgeShape">http://data.europa.eu/949/shapes/BridgeShape</seealso>
    let ``shapes/BridgeShape`` =
        Prefixed_Name(era, "shapes/BridgeShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/CanonicalURI</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/CanonicalURI">http://data.europa.eu/949/shapes/CanonicalURI</seealso>
    let ``shapes/CanonicalURI`` =
        Prefixed_Name(era, "shapes/CanonicalURI") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/CantDeficiency</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/CantDeficiency">http://data.europa.eu/949/shapes/CantDeficiency</seealso>
    let ``shapes/CantDeficiency`` =
        Prefixed_Name(era, "shapes/CantDeficiency") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/CantDeficiencyBasicSSP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/CantDeficiencyBasicSSP">http://data.europa.eu/949/shapes/CantDeficiencyBasicSSP</seealso>
    let ``shapes/CantDeficiencyBasicSSP`` =
        Prefixed_Name(era, "shapes/CantDeficiencyBasicSSP") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/CantDeficiencyBasicSSPApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/CantDeficiencyBasicSSPApplicability">http://data.europa.eu/949/shapes/CantDeficiencyBasicSSPApplicability</seealso>
    let ``shapes/CantDeficiencyBasicSSPApplicability`` =
        Prefixed_Name(era, "shapes/CantDeficiencyBasicSSPApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/CantDeficiencyBasicSSPSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/CantDeficiencyBasicSSPSKOS">http://data.europa.eu/949/shapes/CantDeficiencyBasicSSPSKOS</seealso>
    let ``shapes/CantDeficiencyBasicSSPSKOS`` =
        Prefixed_Name(era, "shapes/CantDeficiencyBasicSSPSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/CarrierLinearElement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/CarrierLinearElement">http://data.europa.eu/949/shapes/CarrierLinearElement</seealso>
    let ``shapes/CarrierLinearElement`` =
        Prefixed_Name(era, "shapes/CarrierLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/CommonCharacteristicsSubsetShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/CommonCharacteristicsSubsetShape">http://data.europa.eu/949/shapes/CommonCharacteristicsSubsetShape</seealso>
    let ``shapes/CommonCharacteristicsSubsetShape`` =
        Prefixed_Name(era, "shapes/CommonCharacteristicsSubsetShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/CompatibilityProcedureDocument</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/CompatibilityProcedureDocument">http://data.europa.eu/949/shapes/CompatibilityProcedureDocument</seealso>
    let ``shapes/CompatibilityProcedureDocument`` =
        Prefixed_Name(era, "shapes/CompatibilityProcedureDocument") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ComplianceInfTsiApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ComplianceInfTsiApplicability">http://data.europa.eu/949/shapes/ComplianceInfTsiApplicability</seealso>
    let ``shapes/ComplianceInfTsiApplicability`` =
        Prefixed_Name(era, "shapes/ComplianceInfTsiApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ComplianceInfTsiP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ComplianceInfTsiP">http://data.europa.eu/949/shapes/ComplianceInfTsiP</seealso>
    let ``shapes/ComplianceInfTsiP`` =
        Prefixed_Name(era, "shapes/ComplianceInfTsiP") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ConditionalRegenerativeBrake</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ConditionalRegenerativeBrake">http://data.europa.eu/949/shapes/ConditionalRegenerativeBrake</seealso>
    let ``shapes/ConditionalRegenerativeBrake`` =
        Prefixed_Name(era, "shapes/ConditionalRegenerativeBrake") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ConditionalRegenerativeBrakeSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ConditionalRegenerativeBrakeSKOS">http://data.europa.eu/949/shapes/ConditionalRegenerativeBrakeSKOS</seealso>
    let ``shapes/ConditionalRegenerativeBrakeSKOS`` =
        Prefixed_Name(era, "shapes/ConditionalRegenerativeBrakeSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ConditionsAppliedRegenerativeBraking</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ConditionsAppliedRegenerativeBraking">http://data.europa.eu/949/shapes/ConditionsAppliedRegenerativeBraking</seealso>
    let ``shapes/ConditionsAppliedRegenerativeBraking`` =
        Prefixed_Name(era, "shapes/ConditionsAppliedRegenerativeBraking") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ConditionsAppliedRegenerativeBrakingApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ConditionsAppliedRegenerativeBrakingApplicability">http://data.europa.eu/949/shapes/ConditionsAppliedRegenerativeBrakingApplicability</seealso>
    let ``shapes/ConditionsAppliedRegenerativeBrakingApplicability`` =
        Prefixed_Name(era, "shapes/ConditionsAppliedRegenerativeBrakingApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ConditionsChargingElectricEnergyStorage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ConditionsChargingElectricEnergyStorage">http://data.europa.eu/949/shapes/ConditionsChargingElectricEnergyStorage</seealso>
    let ``shapes/ConditionsChargingElectricEnergyStorage`` =
        Prefixed_Name(era, "shapes/ConditionsChargingElectricEnergyStorage") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ConditionsSwitchClassBSystems</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ConditionsSwitchClassBSystems">http://data.europa.eu/949/shapes/ConditionsSwitchClassBSystems</seealso>
    let ``shapes/ConditionsSwitchClassBSystems`` =
        Prefixed_Name(era, "shapes/ConditionsSwitchClassBSystems") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ConditionsSwitchClassBSystemsApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ConditionsSwitchClassBSystemsApplicability">http://data.europa.eu/949/shapes/ConditionsSwitchClassBSystemsApplicability</seealso>
    let ``shapes/ConditionsSwitchClassBSystemsApplicability`` =
        Prefixed_Name(era, "shapes/ConditionsSwitchClassBSystemsApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ConditionsSwitchTrainProtectionSystems</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ConditionsSwitchTrainProtectionSystems">http://data.europa.eu/949/shapes/ConditionsSwitchTrainProtectionSystems</seealso>
    let ``shapes/ConditionsSwitchTrainProtectionSystems`` =
        Prefixed_Name(era, "shapes/ConditionsSwitchTrainProtectionSystems") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ConditionsUseReflectivePlates</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ConditionsUseReflectivePlates">http://data.europa.eu/949/shapes/ConditionsUseReflectivePlates</seealso>
    let ``shapes/ConditionsUseReflectivePlates`` =
        Prefixed_Name(era, "shapes/ConditionsUseReflectivePlates") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ConditionsUseReflectivePlatesSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ConditionsUseReflectivePlatesSKOS">http://data.europa.eu/949/shapes/ConditionsUseReflectivePlatesSKOS</seealso>
    let ``shapes/ConditionsUseReflectivePlatesSKOS`` =
        Prefixed_Name(era, "shapes/ConditionsUseReflectivePlatesSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ContactLineSystem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ContactLineSystem">http://data.europa.eu/949/shapes/ContactLineSystem</seealso>
    let ``shapes/ContactLineSystem`` =
        Prefixed_Name(era, "shapes/ContactLineSystem") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ContactLineSystemShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ContactLineSystemShape">http://data.europa.eu/949/shapes/ContactLineSystemShape</seealso>
    let ``shapes/ContactLineSystemShape`` =
        Prefixed_Name(era, "shapes/ContactLineSystemShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ContactLineSystemType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ContactLineSystemType">http://data.europa.eu/949/shapes/ContactLineSystemType</seealso>
    let ``shapes/ContactLineSystemType`` =
        Prefixed_Name(era, "shapes/ContactLineSystemType") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ContactLineSystemTypeNotElectrifiedApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ContactLineSystemTypeNotElectrifiedApplicability">http://data.europa.eu/949/shapes/ContactLineSystemTypeNotElectrifiedApplicability</seealso>
    let ``shapes/ContactLineSystemTypeNotElectrifiedApplicability`` =
        Prefixed_Name(era, "shapes/ContactLineSystemTypeNotElectrifiedApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ContactLineSystemTypeSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ContactLineSystemTypeSKOS">http://data.europa.eu/949/shapes/ContactLineSystemTypeSKOS</seealso>
    let ``shapes/ContactLineSystemTypeSKOS`` =
        Prefixed_Name(era, "shapes/ContactLineSystemTypeSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ContactLineSystemTypeThirdOrFourthRailApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ContactLineSystemTypeThirdOrFourthRailApplicability">http://data.europa.eu/949/shapes/ContactLineSystemTypeThirdOrFourthRailApplicability</seealso>
    let ``shapes/ContactLineSystemTypeThirdOrFourthRailApplicability`` =
        Prefixed_Name(era, "shapes/ContactLineSystemTypeThirdOrFourthRailApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ContactStripMaterialApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ContactStripMaterialApplicability">http://data.europa.eu/949/shapes/ContactStripMaterialApplicability</seealso>
    let ``shapes/ContactStripMaterialApplicability`` =
        Prefixed_Name(era, "shapes/ContactStripMaterialApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ContactStripMaterialMetallicContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ContactStripMaterialMetallicContent">http://data.europa.eu/949/shapes/ContactStripMaterialMetallicContent</seealso>
    let ``shapes/ContactStripMaterialMetallicContent`` =
        Prefixed_Name(era, "shapes/ContactStripMaterialMetallicContent") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ContactStripMaterialSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ContactStripMaterialSKOS">http://data.europa.eu/949/shapes/ContactStripMaterialSKOS</seealso>
    let ``shapes/ContactStripMaterialSKOS`` =
        Prefixed_Name(era, "shapes/ContactStripMaterialSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ContainerHandlingFlag</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ContainerHandlingFlag">http://data.europa.eu/949/shapes/ContainerHandlingFlag</seealso>
    let ``shapes/ContainerHandlingFlag`` =
        Prefixed_Name(era, "shapes/ContainerHandlingFlag") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/Contains</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/Contains">http://data.europa.eu/949/shapes/Contains</seealso>
    let ``shapes/Contains`` = Prefixed_Name(era, "shapes/Contains") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/CrossSectionAreaApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/CrossSectionAreaApplicability">http://data.europa.eu/949/shapes/CrossSectionAreaApplicability</seealso>
    let ``shapes/CrossSectionAreaApplicability`` =
        Prefixed_Name(era, "shapes/CrossSectionAreaApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/CrossSectionAreaT</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/CrossSectionAreaT">http://data.europa.eu/949/shapes/CrossSectionAreaT</seealso>
    let ``shapes/CrossSectionAreaT`` =
        Prefixed_Name(era, "shapes/CrossSectionAreaT") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/CurrentLimitationRequired</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/CurrentLimitationRequired">http://data.europa.eu/949/shapes/CurrentLimitationRequired</seealso>
    let ``shapes/CurrentLimitationRequired`` =
        Prefixed_Name(era, "shapes/CurrentLimitationRequired") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/CurrentLimitationRequiredApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/CurrentLimitationRequiredApplicability">http://data.europa.eu/949/shapes/CurrentLimitationRequiredApplicability</seealso>
    let ``shapes/CurrentLimitationRequiredApplicability`` =
        Prefixed_Name(era, "shapes/CurrentLimitationRequiredApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DNvovtrp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DNvovtrp">http://data.europa.eu/949/shapes/DNvovtrp</seealso>
    let ``shapes/DNvovtrp`` = Prefixed_Name(era, "shapes/DNvovtrp") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DNvovtrpApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DNvovtrpApplicability">http://data.europa.eu/949/shapes/DNvovtrpApplicability</seealso>
    let ``shapes/DNvovtrpApplicability`` =
        Prefixed_Name(era, "shapes/DNvovtrpApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DNvpotrp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DNvpotrp">http://data.europa.eu/949/shapes/DNvpotrp</seealso>
    let ``shapes/DNvpotrp`` = Prefixed_Name(era, "shapes/DNvpotrp") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DNvpotrpApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DNvpotrpApplicability">http://data.europa.eu/949/shapes/DNvpotrpApplicability</seealso>
    let ``shapes/DNvpotrpApplicability`` =
        Prefixed_Name(era, "shapes/DNvpotrpApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DNvroll</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DNvroll">http://data.europa.eu/949/shapes/DNvroll</seealso>
    let ``shapes/DNvroll`` = Prefixed_Name(era, "shapes/DNvroll") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DNvrollApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DNvrollApplicability">http://data.europa.eu/949/shapes/DNvrollApplicability</seealso>
    let ``shapes/DNvrollApplicability`` =
        Prefixed_Name(era, "shapes/DNvrollApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DataRadioCompatible</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DataRadioCompatible">http://data.europa.eu/949/shapes/DataRadioCompatible</seealso>
    let ``shapes/DataRadioCompatible`` =
        Prefixed_Name(era, "shapes/DataRadioCompatible") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DataRadioCompatibleApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DataRadioCompatibleApplicability">http://data.europa.eu/949/shapes/DataRadioCompatibleApplicability</seealso>
    let ``shapes/DataRadioCompatibleApplicability`` =
        Prefixed_Name(era, "shapes/DataRadioCompatibleApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DataRadioCompatibleSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DataRadioCompatibleSKOS">http://data.europa.eu/949/shapes/DataRadioCompatibleSKOS</seealso>
    let ``shapes/DataRadioCompatibleSKOS`` =
        Prefixed_Name(era, "shapes/DataRadioCompatibleSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DemonstrationENE</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DemonstrationENE">http://data.europa.eu/949/shapes/DemonstrationENE</seealso>
    let ``shapes/DemonstrationENE`` =
        Prefixed_Name(era, "shapes/DemonstrationENE") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DemonstrationINF</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DemonstrationINF">http://data.europa.eu/949/shapes/DemonstrationINF</seealso>
    let ``shapes/DemonstrationINF`` =
        Prefixed_Name(era, "shapes/DemonstrationINF") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DemonstrationINFS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DemonstrationINFS">http://data.europa.eu/949/shapes/DemonstrationINFS</seealso>
    let ``shapes/DemonstrationINFS`` =
        Prefixed_Name(era, "shapes/DemonstrationINFS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DemonstrationSRT</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DemonstrationSRT">http://data.europa.eu/949/shapes/DemonstrationSRT</seealso>
    let ``shapes/DemonstrationSRT`` =
        Prefixed_Name(era, "shapes/DemonstrationSRT") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DieselThermalAllowed</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DieselThermalAllowed">http://data.europa.eu/949/shapes/DieselThermalAllowed</seealso>
    let ``shapes/DieselThermalAllowed`` =
        Prefixed_Name(era, "shapes/DieselThermalAllowed") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DigitalSchematicOverview</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DigitalSchematicOverview">http://data.europa.eu/949/shapes/DigitalSchematicOverview</seealso>
    let ``shapes/DigitalSchematicOverview`` =
        Prefixed_Name(era, "shapes/DigitalSchematicOverview") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/Direction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/Direction">http://data.europa.eu/949/shapes/Direction</seealso>
    let ``shapes/Direction`` = Prefixed_Name(era, "shapes/Direction") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DirectionSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DirectionSKOS">http://data.europa.eu/949/shapes/DirectionSKOS</seealso>
    let ``shapes/DirectionSKOS`` =
        Prefixed_Name(era, "shapes/DirectionSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DistSignToPhaseEnd</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DistSignToPhaseEnd">http://data.europa.eu/949/shapes/DistSignToPhaseEnd</seealso>
    let ``shapes/DistSignToPhaseEnd`` =
        Prefixed_Name(era, "shapes/DistSignToPhaseEnd") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DocumentRestrictionPositionContactLineSeparation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DocumentRestrictionPositionContactLineSeparation">http://data.europa.eu/949/shapes/DocumentRestrictionPositionContactLineSeparation</seealso>
    let ``shapes/DocumentRestrictionPositionContactLineSeparation`` =
        Prefixed_Name(era, "shapes/DocumentRestrictionPositionContactLineSeparation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DocumentRestrictionPowerConsumption</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DocumentRestrictionPowerConsumption">http://data.europa.eu/949/shapes/DocumentRestrictionPowerConsumption</seealso>
    let ``shapes/DocumentRestrictionPowerConsumption`` =
        Prefixed_Name(era, "shapes/DocumentRestrictionPowerConsumption") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DocumentShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DocumentShape">http://data.europa.eu/949/shapes/DocumentShape</seealso>
    let ``shapes/DocumentShape`` =
        Prefixed_Name(era, "shapes/DocumentShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/DocumentUrl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/DocumentUrl">http://data.europa.eu/949/shapes/DocumentUrl</seealso>
    let ``shapes/DocumentUrl`` =
        Prefixed_Name(era, "shapes/DocumentUrl") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ETCSShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ETCSShape">http://data.europa.eu/949/shapes/ETCSShape</seealso>
    let ``shapes/ETCSShape`` = Prefixed_Name(era, "shapes/ETCSShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EddyCurrentBraking</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EddyCurrentBraking">http://data.europa.eu/949/shapes/EddyCurrentBraking</seealso>
    let ``shapes/EddyCurrentBraking`` =
        Prefixed_Name(era, "shapes/EddyCurrentBraking") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EddyCurrentBrakingConditionsDocument</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EddyCurrentBrakingConditionsDocument">http://data.europa.eu/949/shapes/EddyCurrentBrakingConditionsDocument</seealso>
    let ``shapes/EddyCurrentBrakingConditionsDocument`` =
        Prefixed_Name(era, "shapes/EddyCurrentBrakingConditionsDocument") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EddyCurrentBrakingConditionsDocumentApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EddyCurrentBrakingConditionsDocumentApplicability">http://data.europa.eu/949/shapes/EddyCurrentBrakingConditionsDocumentApplicability</seealso>
    let ``shapes/EddyCurrentBrakingConditionsDocumentApplicability`` =
        Prefixed_Name(era, "shapes/EddyCurrentBrakingConditionsDocumentApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EddyCurrentBrakingSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EddyCurrentBrakingSKOS">http://data.europa.eu/949/shapes/EddyCurrentBrakingSKOS</seealso>
    let ``shapes/EddyCurrentBrakingSKOS`` =
        Prefixed_Name(era, "shapes/EddyCurrentBrakingSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ElementA</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ElementA">http://data.europa.eu/949/shapes/ElementA</seealso>
    let ``shapes/ElementA`` = Prefixed_Name(era, "shapes/ElementA") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/ElementB</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ElementB">http://data.europa.eu/949/shapes/ElementB</seealso>
    let ``shapes/ElementB`` = Prefixed_Name(era, "shapes/ElementB") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EndLocation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EndLocation">http://data.europa.eu/949/shapes/EndLocation</seealso>
    let ``shapes/EndLocation`` =
        Prefixed_Name(era, "shapes/EndLocation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EndOffsetFromOrigin</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EndOffsetFromOrigin">http://data.europa.eu/949/shapes/EndOffsetFromOrigin</seealso>
    let ``shapes/EndOffsetFromOrigin`` =
        Prefixed_Name(era, "shapes/EndOffsetFromOrigin") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EndsAt</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EndsAt">http://data.europa.eu/949/shapes/EndsAt</seealso>
    let ``shapes/EndsAt`` = Prefixed_Name(era, "shapes/EndsAt") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EnergySupplySystem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EnergySupplySystem">http://data.europa.eu/949/shapes/EnergySupplySystem</seealso>
    let ``shapes/EnergySupplySystem`` =
        Prefixed_Name(era, "shapes/EnergySupplySystem") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EnergySupplySystemSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EnergySupplySystemSKOS">http://data.europa.eu/949/shapes/EnergySupplySystemSKOS</seealso>
    let ``shapes/EnergySupplySystemSKOS`` =
        Prefixed_Name(era, "shapes/EnergySupplySystemSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EnergySupplySystemTSICompliant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EnergySupplySystemTSICompliant">http://data.europa.eu/949/shapes/EnergySupplySystemTSICompliant</seealso>
    let ``shapes/EnergySupplySystemTSICompliant`` =
        Prefixed_Name(era, "shapes/EnergySupplySystemTSICompliant") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ErrorCorrectionsOnboard</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ErrorCorrectionsOnboard">http://data.europa.eu/949/shapes/ErrorCorrectionsOnboard</seealso>
    let ``shapes/ErrorCorrectionsOnboard`` =
        Prefixed_Name(era, "shapes/ErrorCorrectionsOnboard") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ErrorCorrectionsOnboardExplanation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ErrorCorrectionsOnboardExplanation">http://data.europa.eu/949/shapes/ErrorCorrectionsOnboardExplanation</seealso>
    let ``shapes/ErrorCorrectionsOnboardExplanation`` =
        Prefixed_Name(era, "shapes/ErrorCorrectionsOnboardExplanation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ErrorCorrectionsOnboardSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ErrorCorrectionsOnboardSKOS">http://data.europa.eu/949/shapes/ErrorCorrectionsOnboardSKOS</seealso>
    let ``shapes/ErrorCorrectionsOnboardSKOS`` =
        Prefixed_Name(era, "shapes/ErrorCorrectionsOnboardSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/Etcs</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/Etcs">http://data.europa.eu/949/shapes/Etcs</seealso>
    let ``shapes/Etcs`` = Prefixed_Name(era, "shapes/Etcs") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsBaseline</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsBaseline">http://data.europa.eu/949/shapes/EtcsBaseline</seealso>
    let ``shapes/EtcsBaseline`` =
        Prefixed_Name(era, "shapes/EtcsBaseline") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsBaselineApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsBaselineApplicability">http://data.europa.eu/949/shapes/EtcsBaselineApplicability</seealso>
    let ``shapes/EtcsBaselineApplicability`` =
        Prefixed_Name(era, "shapes/EtcsBaselineApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsBaselineSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsBaselineSKOS">http://data.europa.eu/949/shapes/EtcsBaselineSKOS</seealso>
    let ``shapes/EtcsBaselineSKOS`` =
        Prefixed_Name(era, "shapes/EtcsBaselineSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsDegradedSituation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsDegradedSituation">http://data.europa.eu/949/shapes/EtcsDegradedSituation</seealso>
    let ``shapes/EtcsDegradedSituation`` =
        Prefixed_Name(era, "shapes/EtcsDegradedSituation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsDegradedSituationApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsDegradedSituationApplicability">http://data.europa.eu/949/shapes/EtcsDegradedSituationApplicability</seealso>
    let ``shapes/EtcsDegradedSituationApplicability`` =
        Prefixed_Name(era, "shapes/EtcsDegradedSituationApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsDegradedSituationSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsDegradedSituationSKOS">http://data.europa.eu/949/shapes/EtcsDegradedSituationSKOS</seealso>
    let ``shapes/EtcsDegradedSituationSKOS`` =
        Prefixed_Name(era, "shapes/EtcsDegradedSituationSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsImplementsLevelCrossingProcedure</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsImplementsLevelCrossingProcedure">http://data.europa.eu/949/shapes/EtcsImplementsLevelCrossingProcedure</seealso>
    let ``shapes/EtcsImplementsLevelCrossingProcedure`` =
        Prefixed_Name(era, "shapes/EtcsImplementsLevelCrossingProcedure") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsImplementsLevelCrossingProcedureApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsImplementsLevelCrossingProcedureApplicability">http://data.europa.eu/949/shapes/EtcsImplementsLevelCrossingProcedureApplicability</seealso>
    let ``shapes/EtcsImplementsLevelCrossingProcedureApplicability`` =
        Prefixed_Name(era, "shapes/EtcsImplementsLevelCrossingProcedureApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsInfill</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsInfill">http://data.europa.eu/949/shapes/EtcsInfill</seealso>
    let ``shapes/EtcsInfill`` = Prefixed_Name(era, "shapes/EtcsInfill") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsInfillApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsInfillApplicability">http://data.europa.eu/949/shapes/EtcsInfillApplicability</seealso>
    let ``shapes/EtcsInfillApplicability`` =
        Prefixed_Name(era, "shapes/EtcsInfillApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsInfillLineAccess</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsInfillLineAccess">http://data.europa.eu/949/shapes/EtcsInfillLineAccess</seealso>
    let ``shapes/EtcsInfillLineAccess`` =
        Prefixed_Name(era, "shapes/EtcsInfillLineAccess") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsInfillLineAccessApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsInfillLineAccessApplicability">http://data.europa.eu/949/shapes/EtcsInfillLineAccessApplicability</seealso>
    let ``shapes/EtcsInfillLineAccessApplicability`` =
        Prefixed_Name(era, "shapes/EtcsInfillLineAccessApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsInfillSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsInfillSKOS">http://data.europa.eu/949/shapes/EtcsInfillSKOS</seealso>
    let ``shapes/EtcsInfillSKOS`` =
        Prefixed_Name(era, "shapes/EtcsInfillSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsLevelType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsLevelType">http://data.europa.eu/949/shapes/EtcsLevelType</seealso>
    let ``shapes/EtcsLevelType`` =
        Prefixed_Name(era, "shapes/EtcsLevelType") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsLevelTypeSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsLevelTypeSKOS">http://data.europa.eu/949/shapes/EtcsLevelTypeSKOS</seealso>
    let ``shapes/EtcsLevelTypeSKOS`` =
        Prefixed_Name(era, "shapes/EtcsLevelTypeSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsMVersion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsMVersion">http://data.europa.eu/949/shapes/EtcsMVersion</seealso>
    let ``shapes/EtcsMVersion`` =
        Prefixed_Name(era, "shapes/EtcsMVersion") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsMVersionApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsMVersionApplicability">http://data.europa.eu/949/shapes/EtcsMVersionApplicability</seealso>
    let ``shapes/EtcsMVersionApplicability`` =
        Prefixed_Name(era, "shapes/EtcsMVersionApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsMVersionSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsMVersionSKOS">http://data.europa.eu/949/shapes/EtcsMVersionSKOS</seealso>
    let ``shapes/EtcsMVersionSKOS`` =
        Prefixed_Name(era, "shapes/EtcsMVersionSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsNationalPacket44Function</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsNationalPacket44Function">http://data.europa.eu/949/shapes/EtcsNationalPacket44Function</seealso>
    let ``shapes/EtcsNationalPacket44Function`` =
        Prefixed_Name(era, "shapes/EtcsNationalPacket44Function") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsNationalPacket44FunctionSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsNationalPacket44FunctionSKOS">http://data.europa.eu/949/shapes/EtcsNationalPacket44FunctionSKOS</seealso>
    let ``shapes/EtcsNationalPacket44FunctionSKOS`` =
        Prefixed_Name(era, "shapes/EtcsNationalPacket44FunctionSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsRestrictionsConditionsDoc</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsRestrictionsConditionsDoc">http://data.europa.eu/949/shapes/EtcsRestrictionsConditionsDoc</seealso>
    let ``shapes/EtcsRestrictionsConditionsDoc`` =
        Prefixed_Name(era, "shapes/EtcsRestrictionsConditionsDoc") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsRestrictionsConditionsDocApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsRestrictionsConditionsDocApplicability">http://data.europa.eu/949/shapes/EtcsRestrictionsConditionsDocApplicability</seealso>
    let ``shapes/EtcsRestrictionsConditionsDocApplicability`` =
        Prefixed_Name(era, "shapes/EtcsRestrictionsConditionsDocApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsSystemCompatibility</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsSystemCompatibility">http://data.europa.eu/949/shapes/EtcsSystemCompatibility</seealso>
    let ``shapes/EtcsSystemCompatibility`` =
        Prefixed_Name(era, "shapes/EtcsSystemCompatibility") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsSystemCompatibilityApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsSystemCompatibilityApplicability">http://data.europa.eu/949/shapes/EtcsSystemCompatibilityApplicability</seealso>
    let ``shapes/EtcsSystemCompatibilityApplicability`` =
        Prefixed_Name(era, "shapes/EtcsSystemCompatibilityApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsSystemCompatibilitySKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsSystemCompatibilitySKOS">http://data.europa.eu/949/shapes/EtcsSystemCompatibilitySKOS</seealso>
    let ``shapes/EtcsSystemCompatibilitySKOS`` =
        Prefixed_Name(era, "shapes/EtcsSystemCompatibilitySKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsTransmitsTrackConditions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsTransmitsTrackConditions">http://data.europa.eu/949/shapes/EtcsTransmitsTrackConditions</seealso>
    let ``shapes/EtcsTransmitsTrackConditions`` =
        Prefixed_Name(era, "shapes/EtcsTransmitsTrackConditions") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsTransmitsTrackConditionsApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsTransmitsTrackConditionsApplicability">http://data.europa.eu/949/shapes/EtcsTransmitsTrackConditionsApplicability</seealso>
    let ``shapes/EtcsTransmitsTrackConditionsApplicability`` =
        Prefixed_Name(era, "shapes/EtcsTransmitsTrackConditionsApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsTransmittedTrackConditions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsTransmittedTrackConditions">http://data.europa.eu/949/shapes/EtcsTransmittedTrackConditions</seealso>
    let ``shapes/EtcsTransmittedTrackConditions`` =
        Prefixed_Name(era, "shapes/EtcsTransmittedTrackConditions") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsTransmittedTrackConditionsApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsTransmittedTrackConditionsApplicability">http://data.europa.eu/949/shapes/EtcsTransmittedTrackConditionsApplicability</seealso>
    let ``shapes/EtcsTransmittedTrackConditionsApplicability`` =
        Prefixed_Name(era, "shapes/EtcsTransmittedTrackConditionsApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EtcsTransmittedTrackConditionsSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EtcsTransmittedTrackConditionsSKOS">http://data.europa.eu/949/shapes/EtcsTransmittedTrackConditionsSKOS</seealso>
    let ``shapes/EtcsTransmittedTrackConditionsSKOS`` =
        Prefixed_Name(era, "shapes/EtcsTransmittedTrackConditionsSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EuropeanTransportCorridor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EuropeanTransportCorridor">http://data.europa.eu/949/shapes/EuropeanTransportCorridor</seealso>
    let ``shapes/EuropeanTransportCorridor`` =
        Prefixed_Name(era, "shapes/EuropeanTransportCorridor") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/EuropeanTransportCorridorSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/EuropeanTransportCorridorSKOS">http://data.europa.eu/949/shapes/EuropeanTransportCorridorSKOS</seealso>
    let ``shapes/EuropeanTransportCorridorSKOS`` =
        Prefixed_Name(era, "shapes/EuropeanTransportCorridorSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ExemptSpecialVehiclesFromATO</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ExemptSpecialVehiclesFromATO">http://data.europa.eu/949/shapes/ExemptSpecialVehiclesFromATO</seealso>
    let ``shapes/ExemptSpecialVehiclesFromATO`` =
        Prefixed_Name(era, "shapes/ExemptSpecialVehiclesFromATO") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ExemptSpecialVehiclesFromETCS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ExemptSpecialVehiclesFromETCS">http://data.europa.eu/949/shapes/ExemptSpecialVehiclesFromETCS</seealso>
    let ``shapes/ExemptSpecialVehiclesFromETCS`` =
        Prefixed_Name(era, "shapes/ExemptSpecialVehiclesFromETCS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ExemptSpecialVehiclesFromRMR</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ExemptSpecialVehiclesFromRMR">http://data.europa.eu/949/shapes/ExemptSpecialVehiclesFromRMR</seealso>
    let ``shapes/ExemptSpecialVehiclesFromRMR`` =
        Prefixed_Name(era, "shapes/ExemptSpecialVehiclesFromRMR") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/FeatureShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/FeatureShape">http://data.europa.eu/949/shapes/FeatureShape</seealso>
    let ``shapes/FeatureShape`` =
        Prefixed_Name(era, "shapes/FeatureShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/FlangeLubeForbidden</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/FlangeLubeForbidden">http://data.europa.eu/949/shapes/FlangeLubeForbidden</seealso>
    let ``shapes/FlangeLubeForbidden`` =
        Prefixed_Name(era, "shapes/FlangeLubeForbidden") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/FreightCorridor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/FreightCorridor">http://data.europa.eu/949/shapes/FreightCorridor</seealso>
    let ``shapes/FreightCorridor`` =
        Prefixed_Name(era, "shapes/FreightCorridor") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/FreightCorridorPreDeprecationWarning</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/FreightCorridorPreDeprecationWarning">http://data.europa.eu/949/shapes/FreightCorridorPreDeprecationWarning</seealso>
    let ``shapes/FreightCorridorPreDeprecationWarning`` =
        Prefixed_Name(era, "shapes/FreightCorridorPreDeprecationWarning") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/FreightCorridorSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/FreightCorridorSKOS">http://data.europa.eu/949/shapes/FreightCorridorSKOS</seealso>
    let ``shapes/FreightCorridorSKOS`` =
        Prefixed_Name(era, "shapes/FreightCorridorSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/FreightFlag</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/FreightFlag">http://data.europa.eu/949/shapes/FreightFlag</seealso>
    let ``shapes/FreightFlag`` =
        Prefixed_Name(era, "shapes/FreightFlag") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/FrenchTrainDetectionSystemLimitationApplicable</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationApplicable">http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationApplicable</seealso>
    let ``shapes/FrenchTrainDetectionSystemLimitationApplicable`` =
        Prefixed_Name(era, "shapes/FrenchTrainDetectionSystemLimitationApplicable") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/FrenchTrainDetectionSystemLimitationNumber</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationNumber">http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationNumber</seealso>
    let ``shapes/FrenchTrainDetectionSystemLimitationNumber`` =
        Prefixed_Name(era, "shapes/FrenchTrainDetectionSystemLimitationNumber") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/FrenchTrainDetectionSystemLimitationNumberSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationNumberSKOS">http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationNumberSKOS</seealso>
    let ``shapes/FrenchTrainDetectionSystemLimitationNumberSKOS`` =
        Prefixed_Name(era, "shapes/FrenchTrainDetectionSystemLimitationNumberSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/FrenchTrainDetectionSystemLimitationShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationShape">http://data.europa.eu/949/shapes/FrenchTrainDetectionSystemLimitationShape</seealso>
    let ``shapes/FrenchTrainDetectionSystemLimitationShape`` =
        Prefixed_Name(era, "shapes/FrenchTrainDetectionSystemLimitationShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/FrequencyBandsForDetection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/FrequencyBandsForDetection">http://data.europa.eu/949/shapes/FrequencyBandsForDetection</seealso>
    let ``shapes/FrequencyBandsForDetection`` =
        Prefixed_Name(era, "shapes/FrequencyBandsForDetection") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/FrequencyBandsForDetectionSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/FrequencyBandsForDetectionSKOS">http://data.europa.eu/949/shapes/FrequencyBandsForDetectionSKOS</seealso>
    let ``shapes/FrequencyBandsForDetectionSKOS`` =
        Prefixed_Name(era, "shapes/FrequencyBandsForDetectionSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GaugingCheckLocation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GaugingCheckLocation">http://data.europa.eu/949/shapes/GaugingCheckLocation</seealso>
    let ``shapes/GaugingCheckLocation`` =
        Prefixed_Name(era, "shapes/GaugingCheckLocation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GaugingProfile</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GaugingProfile">http://data.europa.eu/949/shapes/GaugingProfile</seealso>
    let ``shapes/GaugingProfile`` =
        Prefixed_Name(era, "shapes/GaugingProfile") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GaugingProfileSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GaugingProfileSKOS">http://data.europa.eu/949/shapes/GaugingProfileSKOS</seealso>
    let ``shapes/GaugingProfileSKOS`` =
        Prefixed_Name(era, "shapes/GaugingProfileSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GaugingTransversalDocument</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GaugingTransversalDocument">http://data.europa.eu/949/shapes/GaugingTransversalDocument</seealso>
    let ``shapes/GaugingTransversalDocument`` =
        Prefixed_Name(era, "shapes/GaugingTransversalDocument") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GeometryShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GeometryShape">http://data.europa.eu/949/shapes/GeometryShape</seealso>
    let ``shapes/GeometryShape`` =
        Prefixed_Name(era, "shapes/GeometryShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GprsForETCS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GprsForETCS">http://data.europa.eu/949/shapes/GprsForETCS</seealso>
    let ``shapes/GprsForETCS`` =
        Prefixed_Name(era, "shapes/GprsForETCS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GprsForETCSApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GprsForETCSApplicability">http://data.europa.eu/949/shapes/GprsForETCSApplicability</seealso>
    let ``shapes/GprsForETCSApplicability`` =
        Prefixed_Name(era, "shapes/GprsForETCSApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GprsImplementationArea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GprsImplementationArea">http://data.europa.eu/949/shapes/GprsImplementationArea</seealso>
    let ``shapes/GprsImplementationArea`` =
        Prefixed_Name(era, "shapes/GprsImplementationArea") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GprsImplementationAreaApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GprsImplementationAreaApplicability">http://data.europa.eu/949/shapes/GprsImplementationAreaApplicability</seealso>
    let ``shapes/GprsImplementationAreaApplicability`` =
        Prefixed_Name(era, "shapes/GprsImplementationAreaApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/Gradient</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/Gradient">http://data.europa.eu/949/shapes/Gradient</seealso>
    let ``shapes/Gradient`` = Prefixed_Name(era, "shapes/Gradient") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GradientProfile</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GradientProfile">http://data.europa.eu/949/shapes/GradientProfile</seealso>
    let ``shapes/GradientProfile`` =
        Prefixed_Name(era, "shapes/GradientProfile") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmRActiveMobiles</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmRActiveMobiles">http://data.europa.eu/949/shapes/GsmRActiveMobiles</seealso>
    let ``shapes/GsmRActiveMobiles`` =
        Prefixed_Name(era, "shapes/GsmRActiveMobiles") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmRActiveMobilesApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmRActiveMobilesApplicability">http://data.europa.eu/949/shapes/GsmRActiveMobilesApplicability</seealso>
    let ``shapes/GsmRActiveMobilesApplicability`` =
        Prefixed_Name(era, "shapes/GsmRActiveMobilesApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmRActiveMobilesSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmRActiveMobilesSKOS">http://data.europa.eu/949/shapes/GsmRActiveMobilesSKOS</seealso>
    let ``shapes/GsmRActiveMobilesSKOS`` =
        Prefixed_Name(era, "shapes/GsmRActiveMobilesSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmRAdditionalInfo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmRAdditionalInfo">http://data.europa.eu/949/shapes/GsmRAdditionalInfo</seealso>
    let ``shapes/GsmRAdditionalInfo`` =
        Prefixed_Name(era, "shapes/GsmRAdditionalInfo") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmRAdditionalInfoApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmRAdditionalInfoApplicability">http://data.europa.eu/949/shapes/GsmRAdditionalInfoApplicability</seealso>
    let ``shapes/GsmRAdditionalInfoApplicability`` =
        Prefixed_Name(era, "shapes/GsmRAdditionalInfoApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmRNoCoverage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmRNoCoverage">http://data.europa.eu/949/shapes/GsmRNoCoverage</seealso>
    let ``shapes/GsmRNoCoverage`` =
        Prefixed_Name(era, "shapes/GsmRNoCoverage") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmRNoCoverageApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmRNoCoverageApplicability">http://data.europa.eu/949/shapes/GsmRNoCoverageApplicability</seealso>
    let ``shapes/GsmRNoCoverageApplicability`` =
        Prefixed_Name(era, "shapes/GsmRNoCoverageApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmROptionalFunctions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmROptionalFunctions">http://data.europa.eu/949/shapes/GsmROptionalFunctions</seealso>
    let ``shapes/GsmROptionalFunctions`` =
        Prefixed_Name(era, "shapes/GsmROptionalFunctions") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmROptionalFunctionsApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmROptionalFunctionsApplicability">http://data.europa.eu/949/shapes/GsmROptionalFunctionsApplicability</seealso>
    let ``shapes/GsmROptionalFunctionsApplicability`` =
        Prefixed_Name(era, "shapes/GsmROptionalFunctionsApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmROptionalFunctionsSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmROptionalFunctionsSKOS">http://data.europa.eu/949/shapes/GsmROptionalFunctionsSKOS</seealso>
    let ``shapes/GsmROptionalFunctionsSKOS`` =
        Prefixed_Name(era, "shapes/GsmROptionalFunctionsSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmRVersion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmRVersion">http://data.europa.eu/949/shapes/GsmRVersion</seealso>
    let ``shapes/GsmRVersion`` =
        Prefixed_Name(era, "shapes/GsmRVersion") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmRVersionSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmRVersionSKOS">http://data.europa.eu/949/shapes/GsmRVersionSKOS</seealso>
    let ``shapes/GsmRVersionSKOS`` =
        Prefixed_Name(era, "shapes/GsmRVersionSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmrConstraintsOperateOnlyInCircuitSwitchApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmrConstraintsOperateOnlyInCircuitSwitchApplicability">http://data.europa.eu/949/shapes/GsmrConstraintsOperateOnlyInCircuitSwitchApplicability</seealso>
    let ``shapes/GsmrConstraintsOperateOnlyInCircuitSwitchApplicability`` =
        Prefixed_Name(era, "shapes/GsmrConstraintsOperateOnlyInCircuitSwitchApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmrForcedDeregistrationFunctionalNumber</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmrForcedDeregistrationFunctionalNumber">http://data.europa.eu/949/shapes/GsmrForcedDeregistrationFunctionalNumber</seealso>
    let ``shapes/GsmrForcedDeregistrationFunctionalNumber`` =
        Prefixed_Name(era, "shapes/GsmrForcedDeregistrationFunctionalNumber") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmrForcedDeregistrationFunctionalNumberApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmrForcedDeregistrationFunctionalNumberApplicability">http://data.europa.eu/949/shapes/GsmrForcedDeregistrationFunctionalNumberApplicability</seealso>
    let ``shapes/GsmrForcedDeregistrationFunctionalNumberApplicability`` =
        Prefixed_Name(era, "shapes/GsmrForcedDeregistrationFunctionalNumberApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmrNetworkCoverage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmrNetworkCoverage">http://data.europa.eu/949/shapes/GsmrNetworkCoverage</seealso>
    let ``shapes/GsmrNetworkCoverage`` =
        Prefixed_Name(era, "shapes/GsmrNetworkCoverage") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmrNetworkCoverageApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmrNetworkCoverageApplicability">http://data.europa.eu/949/shapes/GsmrNetworkCoverageApplicability</seealso>
    let ``shapes/GsmrNetworkCoverageApplicability`` =
        Prefixed_Name(era, "shapes/GsmrNetworkCoverageApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/GsmrNetworkCoverageSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/GsmrNetworkCoverageSKOS">http://data.europa.eu/949/shapes/GsmrNetworkCoverageSKOS</seealso>
    let ``shapes/GsmrNetworkCoverageSKOS`` =
        Prefixed_Name(era, "shapes/GsmrNetworkCoverageSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HandoverPointFlag</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HandoverPointFlag">http://data.europa.eu/949/shapes/HandoverPointFlag</seealso>
    let ``shapes/HandoverPointFlag`` =
        Prefixed_Name(era, "shapes/HandoverPointFlag") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasAdditionalBrakingInformation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasAdditionalBrakingInformation">http://data.europa.eu/949/shapes/HasAdditionalBrakingInformation</seealso>
    let ``shapes/HasAdditionalBrakingInformation`` =
        Prefixed_Name(era, "shapes/HasAdditionalBrakingInformation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasBallast</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasBallast">http://data.europa.eu/949/shapes/HasBallast</seealso>
    let ``shapes/HasBallast`` = Prefixed_Name(era, "shapes/HasBallast") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasBallastApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasBallastApplicability">http://data.europa.eu/949/shapes/HasBallastApplicability</seealso>
    let ``shapes/HasBallastApplicability`` =
        Prefixed_Name(era, "shapes/HasBallastApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasBeginning</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasBeginning">http://data.europa.eu/949/shapes/HasBeginning</seealso>
    let ``shapes/HasBeginning`` =
        Prefixed_Name(era, "shapes/HasBeginning") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasBridge</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasBridge">http://data.europa.eu/949/shapes/HasBridge</seealso>
    let ``shapes/HasBridge`` = Prefixed_Name(era, "shapes/HasBridge") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasETCSRestrictionsConditions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasETCSRestrictionsConditions">http://data.europa.eu/949/shapes/HasETCSRestrictionsConditions</seealso>
    let ``shapes/HasETCSRestrictionsConditions`` =
        Prefixed_Name(era, "shapes/HasETCSRestrictionsConditions") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasETCSRestrictionsConditionsApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasETCSRestrictionsConditionsApplicability">http://data.europa.eu/949/shapes/HasETCSRestrictionsConditionsApplicability</seealso>
    let ``shapes/HasETCSRestrictionsConditionsApplicability`` =
        Prefixed_Name(era, "shapes/HasETCSRestrictionsConditionsApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasElectricShoreSupply</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasElectricShoreSupply">http://data.europa.eu/949/shapes/HasElectricShoreSupply</seealso>
    let ``shapes/HasElectricShoreSupply`` =
        Prefixed_Name(era, "shapes/HasElectricShoreSupply") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasEmergencyPlan</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasEmergencyPlan">http://data.europa.eu/949/shapes/HasEmergencyPlan</seealso>
    let ``shapes/HasEmergencyPlan`` =
        Prefixed_Name(era, "shapes/HasEmergencyPlan") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasEmergencyPlanApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasEmergencyPlanApplicability">http://data.europa.eu/949/shapes/HasEmergencyPlanApplicability</seealso>
    let ``shapes/HasEmergencyPlanApplicability`` =
        Prefixed_Name(era, "shapes/HasEmergencyPlanApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasEnd</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasEnd">http://data.europa.eu/949/shapes/HasEnd</seealso>
    let ``shapes/HasEnd`` = Prefixed_Name(era, "shapes/HasEnd") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasEtcsNationalPacket44</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasEtcsNationalPacket44">http://data.europa.eu/949/shapes/HasEtcsNationalPacket44</seealso>
    let ``shapes/HasEtcsNationalPacket44`` =
        Prefixed_Name(era, "shapes/HasEtcsNationalPacket44") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasEtcsNationalPacket44Applicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasEtcsNationalPacket44Applicability">http://data.europa.eu/949/shapes/HasEtcsNationalPacket44Applicability</seealso>
    let ``shapes/HasEtcsNationalPacket44Applicability`` =
        Prefixed_Name(era, "shapes/HasEtcsNationalPacket44Applicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasEvacuationAndRescuePoints</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasEvacuationAndRescuePoints">http://data.europa.eu/949/shapes/HasEvacuationAndRescuePoints</seealso>
    let ``shapes/HasEvacuationAndRescuePoints`` =
        Prefixed_Name(era, "shapes/HasEvacuationAndRescuePoints") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasExternalCleaning</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasExternalCleaning">http://data.europa.eu/949/shapes/HasExternalCleaning</seealso>
    let ``shapes/HasExternalCleaning`` =
        Prefixed_Name(era, "shapes/HasExternalCleaning") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasGeometry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasGeometry">http://data.europa.eu/949/shapes/HasGeometry</seealso>
    let ``shapes/HasGeometry`` =
        Prefixed_Name(era, "shapes/HasGeometry") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasHotAxleBoxDetector</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasHotAxleBoxDetector">http://data.europa.eu/949/shapes/HasHotAxleBoxDetector</seealso>
    let ``shapes/HasHotAxleBoxDetector`` =
        Prefixed_Name(era, "shapes/HasHotAxleBoxDetector") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasLevelCrossings</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasLevelCrossings">http://data.europa.eu/949/shapes/HasLevelCrossings</seealso>
    let ``shapes/HasLevelCrossings`` =
        Prefixed_Name(era, "shapes/HasLevelCrossings") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasLrsCoordinate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasLrsCoordinate">http://data.europa.eu/949/shapes/HasLrsCoordinate</seealso>
    let ``shapes/HasLrsCoordinate`` =
        Prefixed_Name(era, "shapes/HasLrsCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasOrganisationRole</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasOrganisationRole">http://data.europa.eu/949/shapes/HasOrganisationRole</seealso>
    let ``shapes/HasOrganisationRole`` =
        Prefixed_Name(era, "shapes/HasOrganisationRole") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasOrganisationRoleSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasOrganisationRoleSKOS">http://data.europa.eu/949/shapes/HasOrganisationRoleSKOS</seealso>
    let ``shapes/HasOrganisationRoleSKOS`` =
        Prefixed_Name(era, "shapes/HasOrganisationRoleSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasPart</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasPart">http://data.europa.eu/949/shapes/HasPart</seealso>
    let ``shapes/HasPart`` = Prefixed_Name(era, "shapes/HasPart") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/HasPartOP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasPartOP">http://data.europa.eu/949/shapes/HasPartOP</seealso>
    let ``shapes/HasPartOP`` = Prefixed_Name(era, "shapes/HasPartOP") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/HasPartSoL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasPartSoL">http://data.europa.eu/949/shapes/HasPartSoL</seealso>
    let ``shapes/HasPartSoL`` = Prefixed_Name(era, "shapes/HasPartSoL") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasPhaseSeparation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasPhaseSeparation">http://data.europa.eu/949/shapes/HasPhaseSeparation</seealso>
    let ``shapes/HasPhaseSeparation`` =
        Prefixed_Name(era, "shapes/HasPhaseSeparation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasPhaseSeparationApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasPhaseSeparationApplicability">http://data.europa.eu/949/shapes/HasPhaseSeparationApplicability</seealso>
    let ``shapes/HasPhaseSeparationApplicability`` =
        Prefixed_Name(era, "shapes/HasPhaseSeparationApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasPlatformCurvature</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasPlatformCurvature">http://data.europa.eu/949/shapes/HasPlatformCurvature</seealso>
    let ``shapes/HasPlatformCurvature`` =
        Prefixed_Name(era, "shapes/HasPlatformCurvature") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasRefuelling</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasRefuelling">http://data.europa.eu/949/shapes/HasRefuelling</seealso>
    let ``shapes/HasRefuelling`` =
        Prefixed_Name(era, "shapes/HasRefuelling") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasSandRestocking</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasSandRestocking">http://data.europa.eu/949/shapes/HasSandRestocking</seealso>
    let ``shapes/HasSandRestocking`` =
        Prefixed_Name(era, "shapes/HasSandRestocking") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasSchematicOverviewOPDigitalForm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasSchematicOverviewOPDigitalForm">http://data.europa.eu/949/shapes/HasSchematicOverviewOPDigitalForm</seealso>
    let ``shapes/HasSchematicOverviewOPDigitalForm`` =
        Prefixed_Name(era, "shapes/HasSchematicOverviewOPDigitalForm") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasSequence</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasSequence">http://data.europa.eu/949/shapes/HasSequence</seealso>
    let ``shapes/HasSequence`` =
        Prefixed_Name(era, "shapes/HasSequence") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasSevereWeatherConditions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasSevereWeatherConditions">http://data.europa.eu/949/shapes/HasSevereWeatherConditions</seealso>
    let ``shapes/HasSevereWeatherConditions`` =
        Prefixed_Name(era, "shapes/HasSevereWeatherConditions") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasSystemSeparation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasSystemSeparation">http://data.europa.eu/949/shapes/HasSystemSeparation</seealso>
    let ``shapes/HasSystemSeparation`` =
        Prefixed_Name(era, "shapes/HasSystemSeparation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasSystemSeparationApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasSystemSeparationApplicability">http://data.europa.eu/949/shapes/HasSystemSeparationApplicability</seealso>
    let ``shapes/HasSystemSeparationApplicability`` =
        Prefixed_Name(era, "shapes/HasSystemSeparationApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasTSITrainDetection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasTSITrainDetection">http://data.europa.eu/949/shapes/HasTSITrainDetection</seealso>
    let ``shapes/HasTSITrainDetection`` =
        Prefixed_Name(era, "shapes/HasTSITrainDetection") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasToiletDischarge</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasToiletDischarge">http://data.europa.eu/949/shapes/HasToiletDischarge</seealso>
    let ``shapes/HasToiletDischarge`` =
        Prefixed_Name(era, "shapes/HasToiletDischarge") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasTopoCoordinate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasTopoCoordinate">http://data.europa.eu/949/shapes/HasTopoCoordinate</seealso>
    let ``shapes/HasTopoCoordinate`` =
        Prefixed_Name(era, "shapes/HasTopoCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasWalkway</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasWalkway">http://data.europa.eu/949/shapes/HasWalkway</seealso>
    let ``shapes/HasWalkway`` = Prefixed_Name(era, "shapes/HasWalkway") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HasWaterRestocking</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HasWaterRestocking">http://data.europa.eu/949/shapes/HasWaterRestocking</seealso>
    let ``shapes/HasWaterRestocking`` =
        Prefixed_Name(era, "shapes/HasWaterRestocking") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HighSpeedLoadModelCompliance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HighSpeedLoadModelCompliance">http://data.europa.eu/949/shapes/HighSpeedLoadModelCompliance</seealso>
    let ``shapes/HighSpeedLoadModelCompliance`` =
        Prefixed_Name(era, "shapes/HighSpeedLoadModelCompliance") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorDirection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirection">http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirection</seealso>
    let ``shapes/HotAxleBoxDetectorDirection`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorDirection") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorDirectionApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirectionApplicability">http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirectionApplicability</seealso>
    let ``shapes/HotAxleBoxDetectorDirectionApplicability`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorDirectionApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorDirectionCountryApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirectionCountryApplicability">http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirectionCountryApplicability</seealso>
    let ``shapes/HotAxleBoxDetectorDirectionCountryApplicability`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorDirectionCountryApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorDirectionSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirectionSKOS">http://data.europa.eu/949/shapes/HotAxleBoxDetectorDirectionSKOS</seealso>
    let ``shapes/HotAxleBoxDetectorDirectionSKOS`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorDirectionSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorGeneration</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorGeneration">http://data.europa.eu/949/shapes/HotAxleBoxDetectorGeneration</seealso>
    let ``shapes/HotAxleBoxDetectorGeneration`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorGeneration") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorGenerationApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorGenerationApplicability">http://data.europa.eu/949/shapes/HotAxleBoxDetectorGenerationApplicability</seealso>
    let ``shapes/HotAxleBoxDetectorGenerationApplicability`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorGenerationApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorGenerationCountryApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorGenerationCountryApplicability">http://data.europa.eu/949/shapes/HotAxleBoxDetectorGenerationCountryApplicability</seealso>
    let ``shapes/HotAxleBoxDetectorGenerationCountryApplicability`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorGenerationCountryApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorIdentification</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorIdentification">http://data.europa.eu/949/shapes/HotAxleBoxDetectorIdentification</seealso>
    let ``shapes/HotAxleBoxDetectorIdentification`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorIdentification") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorIdentificationApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorIdentificationApplicability">http://data.europa.eu/949/shapes/HotAxleBoxDetectorIdentificationApplicability</seealso>
    let ``shapes/HotAxleBoxDetectorIdentificationApplicability`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorIdentificationApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorIdentificationCountryApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorIdentificationCountryApplicability">http://data.europa.eu/949/shapes/HotAxleBoxDetectorIdentificationCountryApplicability</seealso>
    let ``shapes/HotAxleBoxDetectorIdentificationCountryApplicability`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorIdentificationCountryApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorLocation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorLocation">http://data.europa.eu/949/shapes/HotAxleBoxDetectorLocation</seealso>
    let ``shapes/HotAxleBoxDetectorLocation`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorLocation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorLocationApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorLocationApplicability">http://data.europa.eu/949/shapes/HotAxleBoxDetectorLocationApplicability</seealso>
    let ``shapes/HotAxleBoxDetectorLocationApplicability`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorLocationApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorLocationCountryApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorLocationCountryApplicability">http://data.europa.eu/949/shapes/HotAxleBoxDetectorLocationCountryApplicability</seealso>
    let ``shapes/HotAxleBoxDetectorLocationCountryApplicability`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorLocationCountryApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorTSICompliant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorTSICompliant">http://data.europa.eu/949/shapes/HotAxleBoxDetectorTSICompliant</seealso>
    let ``shapes/HotAxleBoxDetectorTSICompliant`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorTSICompliant") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/HotAxleBoxDetectorTSICompliantCountryApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/HotAxleBoxDetectorTSICompliantCountryApplicability">http://data.europa.eu/949/shapes/HotAxleBoxDetectorTSICompliantCountryApplicability</seealso>
    let ``shapes/HotAxleBoxDetectorTSICompliantCountryApplicability`` =
        Prefixed_Name(era, "shapes/HotAxleBoxDetectorTSICompliantCountryApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/InCountry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/InCountry">http://data.europa.eu/949/shapes/InCountry</seealso>
    let ``shapes/InCountry`` = Prefixed_Name(era, "shapes/InCountry") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/InCountrySKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/InCountrySKOS">http://data.europa.eu/949/shapes/InCountrySKOS</seealso>
    let ``shapes/InCountrySKOS`` =
        Prefixed_Name(era, "shapes/InCountrySKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/InNUTS3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/InNUTS3">http://data.europa.eu/949/shapes/InNUTS3</seealso>
    let ``shapes/InNUTS3`` = Prefixed_Name(era, "shapes/InNUTS3") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/InNUTS3SKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/InNUTS3SKOS">http://data.europa.eu/949/shapes/InNUTS3SKOS</seealso>
    let ``shapes/InNUTS3SKOS`` =
        Prefixed_Name(era, "shapes/InNUTS3SKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/Includes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/Includes">http://data.europa.eu/949/shapes/Includes</seealso>
    let ``shapes/Includes`` = Prefixed_Name(era, "shapes/Includes") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/InfrastructureElementShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/InfrastructureElementShape">http://data.europa.eu/949/shapes/InfrastructureElementShape</seealso>
    let ``shapes/InfrastructureElementShape`` =
        Prefixed_Name(era, "shapes/InfrastructureElementShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/InfrastructureManagerSKOSValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/InfrastructureManagerSKOSValue">http://data.europa.eu/949/shapes/InfrastructureManagerSKOSValue</seealso>
    let ``shapes/InfrastructureManagerSKOSValue`` =
        Prefixed_Name(era, "shapes/InfrastructureManagerSKOSValue") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/InstantShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/InstantShape">http://data.europa.eu/949/shapes/InstantShape</seealso>
    let ``shapes/InstantShape`` =
        Prefixed_Name(era, "shapes/InstantShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/InstructionsSwitchRadioSystems</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/InstructionsSwitchRadioSystems">http://data.europa.eu/949/shapes/InstructionsSwitchRadioSystems</seealso>
    let ``shapes/InstructionsSwitchRadioSystems`` =
        Prefixed_Name(era, "shapes/InstructionsSwitchRadioSystems") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/InstructionsSwitchRadioSystemsApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/InstructionsSwitchRadioSystemsApplicability">http://data.europa.eu/949/shapes/InstructionsSwitchRadioSystemsApplicability</seealso>
    let ``shapes/InstructionsSwitchRadioSystemsApplicability`` =
        Prefixed_Name(era, "shapes/InstructionsSwitchRadioSystemsApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/IsOnOriginOfElementA</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/IsOnOriginOfElementA">http://data.europa.eu/949/shapes/IsOnOriginOfElementA</seealso>
    let ``shapes/IsOnOriginOfElementA`` =
        Prefixed_Name(era, "shapes/IsOnOriginOfElementA") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/IsOnOriginOfElementB</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/IsOnOriginOfElementB">http://data.europa.eu/949/shapes/IsOnOriginOfElementB</seealso>
    let ``shapes/IsOnOriginOfElementB`` =
        Prefixed_Name(era, "shapes/IsOnOriginOfElementB") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/IsPartOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/IsPartOf">http://data.europa.eu/949/shapes/IsPartOf</seealso>
    let ``shapes/IsPartOf`` = Prefixed_Name(era, "shapes/IsPartOf") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/IsQuietRoute</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/IsQuietRoute">http://data.europa.eu/949/shapes/IsQuietRoute</seealso>
    let ``shapes/IsQuietRoute`` =
        Prefixed_Name(era, "shapes/IsQuietRoute") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/Kilometer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/Kilometer">http://data.europa.eu/949/shapes/Kilometer</seealso>
    let ``shapes/Kilometer`` = Prefixed_Name(era, "shapes/Kilometer") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/KilometricPostShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/KilometricPostShape">http://data.europa.eu/949/shapes/KilometricPostShape</seealso>
    let ``shapes/KilometricPostShape`` =
        Prefixed_Name(era, "shapes/KilometricPostShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/KmPost</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/KmPost">http://data.europa.eu/949/shapes/KmPost</seealso>
    let ``shapes/KmPost`` = Prefixed_Name(era, "shapes/KmPost") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/KmPostName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/KmPostName">http://data.europa.eu/949/shapes/KmPostName</seealso>
    let ``shapes/KmPostName`` = Prefixed_Name(era, "shapes/KmPostName") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LegacyRadioSystem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LegacyRadioSystem">http://data.europa.eu/949/shapes/LegacyRadioSystem</seealso>
    let ``shapes/LegacyRadioSystem`` =
        Prefixed_Name(era, "shapes/LegacyRadioSystem") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LegacyRadioSystemSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LegacyRadioSystemSKOS">http://data.europa.eu/949/shapes/LegacyRadioSystemSKOS</seealso>
    let ``shapes/LegacyRadioSystemSKOS`` =
        Prefixed_Name(era, "shapes/LegacyRadioSystemSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LengthOfNetLinearElement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LengthOfNetLinearElement">http://data.europa.eu/949/shapes/LengthOfNetLinearElement</seealso>
    let ``shapes/LengthOfNetLinearElement`` =
        Prefixed_Name(era, "shapes/LengthOfNetLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LengthOfTunnel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LengthOfTunnel">http://data.europa.eu/949/shapes/LengthOfTunnel</seealso>
    let ``shapes/LengthOfTunnel`` =
        Prefixed_Name(era, "shapes/LengthOfTunnel") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LengthP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LengthP">http://data.europa.eu/949/shapes/LengthP</seealso>
    let ``shapes/LengthP`` = Prefixed_Name(era, "shapes/LengthP") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/LengthS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LengthS">http://data.europa.eu/949/shapes/LengthS</seealso>
    let ``shapes/LengthS`` = Prefixed_Name(era, "shapes/LengthS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LevelCrossingShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LevelCrossingShape">http://data.europa.eu/949/shapes/LevelCrossingShape</seealso>
    let ``shapes/LevelCrossingShape`` =
        Prefixed_Name(era, "shapes/LevelCrossingShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LineCategory</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LineCategory">http://data.europa.eu/949/shapes/LineCategory</seealso>
    let ``shapes/LineCategory`` =
        Prefixed_Name(era, "shapes/LineCategory") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LineCategorySKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LineCategorySKOS">http://data.europa.eu/949/shapes/LineCategorySKOS</seealso>
    let ``shapes/LineCategorySKOS`` =
        Prefixed_Name(era, "shapes/LineCategorySKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LineId</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LineId">http://data.europa.eu/949/shapes/LineId</seealso>
    let ``shapes/LineId`` = Prefixed_Name(era, "shapes/LineId") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LineReferenceTunnelEnd</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LineReferenceTunnelEnd">http://data.europa.eu/949/shapes/LineReferenceTunnelEnd</seealso>
    let ``shapes/LineReferenceTunnelEnd`` =
        Prefixed_Name(era, "shapes/LineReferenceTunnelEnd") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LineReferenceTunnelStart</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LineReferenceTunnelStart">http://data.europa.eu/949/shapes/LineReferenceTunnelStart</seealso>
    let ``shapes/LineReferenceTunnelStart`` =
        Prefixed_Name(era, "shapes/LineReferenceTunnelStart") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LinearElementSectionShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LinearElementSectionShape">http://data.europa.eu/949/shapes/LinearElementSectionShape</seealso>
    let ``shapes/LinearElementSectionShape`` =
        Prefixed_Name(era, "shapes/LinearElementSectionShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LinearElementShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LinearElementShape">http://data.europa.eu/949/shapes/LinearElementShape</seealso>
    let ``shapes/LinearElementShape`` =
        Prefixed_Name(era, "shapes/LinearElementShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LinearPositioningSystemCoordinateShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LinearPositioningSystemCoordinateShape">http://data.europa.eu/949/shapes/LinearPositioningSystemCoordinateShape</seealso>
    let ``shapes/LinearPositioningSystemCoordinateShape`` =
        Prefixed_Name(era, "shapes/LinearPositioningSystemCoordinateShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LinearPositioningSystemShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LinearPositioningSystemShape">http://data.europa.eu/949/shapes/LinearPositioningSystemShape</seealso>
    let ``shapes/LinearPositioningSystemShape`` =
        Prefixed_Name(era, "shapes/LinearPositioningSystemShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LinesideDistanceIndicationAppearance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationAppearance">http://data.europa.eu/949/shapes/LinesideDistanceIndicationAppearance</seealso>
    let ``shapes/LinesideDistanceIndicationAppearance`` =
        Prefixed_Name(era, "shapes/LinesideDistanceIndicationAppearance") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LinesideDistanceIndicationAppearanceSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationAppearanceSKOS">http://data.europa.eu/949/shapes/LinesideDistanceIndicationAppearanceSKOS</seealso>
    let ``shapes/LinesideDistanceIndicationAppearanceSKOS`` =
        Prefixed_Name(era, "shapes/LinesideDistanceIndicationAppearanceSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LinesideDistanceIndicationCCS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationCCS">http://data.europa.eu/949/shapes/LinesideDistanceIndicationCCS</seealso>
    let ``shapes/LinesideDistanceIndicationCCS`` =
        Prefixed_Name(era, "shapes/LinesideDistanceIndicationCCS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LinesideDistanceIndicationFrequency</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationFrequency">http://data.europa.eu/949/shapes/LinesideDistanceIndicationFrequency</seealso>
    let ``shapes/LinesideDistanceIndicationFrequency`` =
        Prefixed_Name(era, "shapes/LinesideDistanceIndicationFrequency") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LinesideDistanceIndicationPositioning</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationPositioning">http://data.europa.eu/949/shapes/LinesideDistanceIndicationPositioning</seealso>
    let ``shapes/LinesideDistanceIndicationPositioning`` =
        Prefixed_Name(era, "shapes/LinesideDistanceIndicationPositioning") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LinesideDistanceIndicationPositioningSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationPositioningSKOS">http://data.europa.eu/949/shapes/LinesideDistanceIndicationPositioningSKOS</seealso>
    let ``shapes/LinesideDistanceIndicationPositioningSKOS`` =
        Prefixed_Name(era, "shapes/LinesideDistanceIndicationPositioningSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LinesideDistanceIndicationRT</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationRT">http://data.europa.eu/949/shapes/LinesideDistanceIndicationRT</seealso>
    let ``shapes/LinesideDistanceIndicationRT`` =
        Prefixed_Name(era, "shapes/LinesideDistanceIndicationRT") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LinesideDistanceIndicationShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LinesideDistanceIndicationShape">http://data.europa.eu/949/shapes/LinesideDistanceIndicationShape</seealso>
    let ``shapes/LinesideDistanceIndicationShape`` =
        Prefixed_Name(era, "shapes/LinesideDistanceIndicationShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LinkedToPrimaryLocation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LinkedToPrimaryLocation">http://data.europa.eu/949/shapes/LinkedToPrimaryLocation</seealso>
    let ``shapes/LinkedToPrimaryLocation`` =
        Prefixed_Name(era, "shapes/LinkedToPrimaryLocation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LoadCapabilityLineCategory</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LoadCapabilityLineCategory">http://data.europa.eu/949/shapes/LoadCapabilityLineCategory</seealso>
    let ``shapes/LoadCapabilityLineCategory`` =
        Prefixed_Name(era, "shapes/LoadCapabilityLineCategory") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LoadCapabilityLineCategorySKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LoadCapabilityLineCategorySKOS">http://data.europa.eu/949/shapes/LoadCapabilityLineCategorySKOS</seealso>
    let ``shapes/LoadCapabilityLineCategorySKOS`` =
        Prefixed_Name(era, "shapes/LoadCapabilityLineCategorySKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LoadCapabilityShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LoadCapabilityShape">http://data.europa.eu/949/shapes/LoadCapabilityShape</seealso>
    let ``shapes/LoadCapabilityShape`` =
        Prefixed_Name(era, "shapes/LoadCapabilityShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LoadCapabilitySpeed</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LoadCapabilitySpeed">http://data.europa.eu/949/shapes/LoadCapabilitySpeed</seealso>
    let ``shapes/LoadCapabilitySpeed`` =
        Prefixed_Name(era, "shapes/LoadCapabilitySpeed") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LocalRulesOrRestrictions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LocalRulesOrRestrictions">http://data.europa.eu/949/shapes/LocalRulesOrRestrictions</seealso>
    let ``shapes/LocalRulesOrRestrictions`` =
        Prefixed_Name(era, "shapes/LocalRulesOrRestrictions") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LocalRulesOrRestrictionsDoc</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LocalRulesOrRestrictionsDoc">http://data.europa.eu/949/shapes/LocalRulesOrRestrictionsDoc</seealso>
    let ``shapes/LocalRulesOrRestrictionsDoc`` =
        Prefixed_Name(era, "shapes/LocalRulesOrRestrictionsDoc") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LocalRulesOrRestrictionsDocApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LocalRulesOrRestrictionsDocApplicability">http://data.europa.eu/949/shapes/LocalRulesOrRestrictionsDocApplicability</seealso>
    let ``shapes/LocalRulesOrRestrictionsDocApplicability`` =
        Prefixed_Name(era, "shapes/LocalRulesOrRestrictionsDocApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LrsMethod</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LrsMethod">http://data.europa.eu/949/shapes/LrsMethod</seealso>
    let ``shapes/LrsMethod`` = Prefixed_Name(era, "shapes/LrsMethod") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/LrsMethodSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/LrsMethodSKOS">http://data.europa.eu/949/shapes/LrsMethodSKOS</seealso>
    let ``shapes/LrsMethodSKOS`` =
        Prefixed_Name(era, "shapes/LrsMethodSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MNvcontact</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MNvcontact">http://data.europa.eu/949/shapes/MNvcontact</seealso>
    let ``shapes/MNvcontact`` = Prefixed_Name(era, "shapes/MNvcontact") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MNvcontactApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MNvcontactApplicability">http://data.europa.eu/949/shapes/MNvcontactApplicability</seealso>
    let ``shapes/MNvcontactApplicability`` =
        Prefixed_Name(era, "shapes/MNvcontactApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MNvcontactSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MNvcontactSKOS">http://data.europa.eu/949/shapes/MNvcontactSKOS</seealso>
    let ``shapes/MNvcontactSKOS`` =
        Prefixed_Name(era, "shapes/MNvcontactSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MNvderun</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MNvderun">http://data.europa.eu/949/shapes/MNvderun</seealso>
    let ``shapes/MNvderun`` = Prefixed_Name(era, "shapes/MNvderun") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MNvderunApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MNvderunApplicability">http://data.europa.eu/949/shapes/MNvderunApplicability</seealso>
    let ``shapes/MNvderunApplicability`` =
        Prefixed_Name(era, "shapes/MNvderunApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MagneticBraking</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MagneticBraking">http://data.europa.eu/949/shapes/MagneticBraking</seealso>
    let ``shapes/MagneticBraking`` =
        Prefixed_Name(era, "shapes/MagneticBraking") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MagneticBrakingConditionsDocument</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MagneticBrakingConditionsDocument">http://data.europa.eu/949/shapes/MagneticBrakingConditionsDocument</seealso>
    let ``shapes/MagneticBrakingConditionsDocument`` =
        Prefixed_Name(era, "shapes/MagneticBrakingConditionsDocument") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MagneticBrakingConditionsDocumentApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MagneticBrakingConditionsDocumentApplicability">http://data.europa.eu/949/shapes/MagneticBrakingConditionsDocumentApplicability</seealso>
    let ``shapes/MagneticBrakingConditionsDocumentApplicability`` =
        Prefixed_Name(era, "shapes/MagneticBrakingConditionsDocumentApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MagneticBrakingSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MagneticBrakingSKOS">http://data.europa.eu/949/shapes/MagneticBrakingSKOS</seealso>
    let ``shapes/MagneticBrakingSKOS`` =
        Prefixed_Name(era, "shapes/MagneticBrakingSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaxCurrentStandstillPantograph</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaxCurrentStandstillPantograph">http://data.europa.eu/949/shapes/MaxCurrentStandstillPantograph</seealso>
    let ``shapes/MaxCurrentStandstillPantograph`` =
        Prefixed_Name(era, "shapes/MaxCurrentStandstillPantograph") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaxCurrentStandstillPantographApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaxCurrentStandstillPantographApplicability">http://data.europa.eu/949/shapes/MaxCurrentStandstillPantographApplicability</seealso>
    let ``shapes/MaxCurrentStandstillPantographApplicability`` =
        Prefixed_Name(era, "shapes/MaxCurrentStandstillPantographApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaxCurrentStandstillPantographS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaxCurrentStandstillPantographS">http://data.europa.eu/949/shapes/MaxCurrentStandstillPantographS</seealso>
    let ``shapes/MaxCurrentStandstillPantographS`` =
        Prefixed_Name(era, "shapes/MaxCurrentStandstillPantographS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaxPermittedTrainLength</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaxPermittedTrainLength">http://data.europa.eu/949/shapes/MaxPermittedTrainLength</seealso>
    let ``shapes/MaxPermittedTrainLength`` =
        Prefixed_Name(era, "shapes/MaxPermittedTrainLength") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaxPermittedTrainLengthApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaxPermittedTrainLengthApplicability">http://data.europa.eu/949/shapes/MaxPermittedTrainLengthApplicability</seealso>
    let ``shapes/MaxPermittedTrainLengthApplicability`` =
        Prefixed_Name(era, "shapes/MaxPermittedTrainLengthApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaximumAltitude</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaximumAltitude">http://data.europa.eu/949/shapes/MaximumAltitude</seealso>
    let ``shapes/MaximumAltitude`` =
        Prefixed_Name(era, "shapes/MaximumAltitude") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaximumBrakingDistance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaximumBrakingDistance">http://data.europa.eu/949/shapes/MaximumBrakingDistance</seealso>
    let ``shapes/MaximumBrakingDistance`` =
        Prefixed_Name(era, "shapes/MaximumBrakingDistance") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaximumContactWireHeight</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaximumContactWireHeight">http://data.europa.eu/949/shapes/MaximumContactWireHeight</seealso>
    let ``shapes/MaximumContactWireHeight`` =
        Prefixed_Name(era, "shapes/MaximumContactWireHeight") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaximumContactWireHeightApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaximumContactWireHeightApplicability">http://data.europa.eu/949/shapes/MaximumContactWireHeightApplicability</seealso>
    let ``shapes/MaximumContactWireHeightApplicability`` =
        Prefixed_Name(era, "shapes/MaximumContactWireHeightApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaximumInterferenceCurrent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaximumInterferenceCurrent">http://data.europa.eu/949/shapes/MaximumInterferenceCurrent</seealso>
    let ``shapes/MaximumInterferenceCurrent`` =
        Prefixed_Name(era, "shapes/MaximumInterferenceCurrent") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaximumInterferenceCurrentEvaluation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaximumInterferenceCurrentEvaluation">http://data.europa.eu/949/shapes/MaximumInterferenceCurrentEvaluation</seealso>
    let ``shapes/MaximumInterferenceCurrentEvaluation`` =
        Prefixed_Name(era, "shapes/MaximumInterferenceCurrentEvaluation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaximumMagneticFieldDirectionX</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaximumMagneticFieldDirectionX">http://data.europa.eu/949/shapes/MaximumMagneticFieldDirectionX</seealso>
    let ``shapes/MaximumMagneticFieldDirectionX`` =
        Prefixed_Name(era, "shapes/MaximumMagneticFieldDirectionX") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaximumMagneticFieldDirectionY</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaximumMagneticFieldDirectionY">http://data.europa.eu/949/shapes/MaximumMagneticFieldDirectionY</seealso>
    let ``shapes/MaximumMagneticFieldDirectionY`` =
        Prefixed_Name(era, "shapes/MaximumMagneticFieldDirectionY") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaximumMagneticFieldDirectionZ</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaximumMagneticFieldDirectionZ">http://data.europa.eu/949/shapes/MaximumMagneticFieldDirectionZ</seealso>
    let ``shapes/MaximumMagneticFieldDirectionZ`` =
        Prefixed_Name(era, "shapes/MaximumMagneticFieldDirectionZ") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaximumMagneticFieldShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaximumMagneticFieldShape">http://data.europa.eu/949/shapes/MaximumMagneticFieldShape</seealso>
    let ``shapes/MaximumMagneticFieldShape`` =
        Prefixed_Name(era, "shapes/MaximumMagneticFieldShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaximumPermittedSpeed</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaximumPermittedSpeed">http://data.europa.eu/949/shapes/MaximumPermittedSpeed</seealso>
    let ``shapes/MaximumPermittedSpeed`` =
        Prefixed_Name(era, "shapes/MaximumPermittedSpeed") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaximumTrainCurrent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaximumTrainCurrent">http://data.europa.eu/949/shapes/MaximumTrainCurrent</seealso>
    let ``shapes/MaximumTrainCurrent`` =
        Prefixed_Name(era, "shapes/MaximumTrainCurrent") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MaximumTrainDeceleration</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MaximumTrainDeceleration">http://data.europa.eu/949/shapes/MaximumTrainDeceleration</seealso>
    let ``shapes/MaximumTrainDeceleration`` =
        Prefixed_Name(era, "shapes/MaximumTrainDeceleration") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MeasuredDistance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MeasuredDistance">http://data.europa.eu/949/shapes/MeasuredDistance</seealso>
    let ``shapes/MeasuredDistance`` =
        Prefixed_Name(era, "shapes/MeasuredDistance") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinVehicleImpedance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinVehicleImpedance">http://data.europa.eu/949/shapes/MinVehicleImpedance</seealso>
    let ``shapes/MinVehicleImpedance`` =
        Prefixed_Name(era, "shapes/MinVehicleImpedance") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinVehicleImpedanceApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinVehicleImpedanceApplicability">http://data.europa.eu/949/shapes/MinVehicleImpedanceApplicability</seealso>
    let ``shapes/MinVehicleImpedanceApplicability`` =
        Prefixed_Name(era, "shapes/MinVehicleImpedanceApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinVehicleImpedanceShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinVehicleImpedanceShape">http://data.europa.eu/949/shapes/MinVehicleImpedanceShape</seealso>
    let ``shapes/MinVehicleImpedanceShape`` =
        Prefixed_Name(era, "shapes/MinVehicleImpedanceShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinVehicleImpedanceVoltages</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinVehicleImpedanceVoltages">http://data.europa.eu/949/shapes/MinVehicleImpedanceVoltages</seealso>
    let ``shapes/MinVehicleImpedanceVoltages`` =
        Prefixed_Name(era, "shapes/MinVehicleImpedanceVoltages") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinVehicleImpedanceVoltagesApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinVehicleImpedanceVoltagesApplicability">http://data.europa.eu/949/shapes/MinVehicleImpedanceVoltagesApplicability</seealso>
    let ``shapes/MinVehicleImpedanceVoltagesApplicability`` =
        Prefixed_Name(era, "shapes/MinVehicleImpedanceVoltagesApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinVehicleImpedanceVoltagesSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinVehicleImpedanceVoltagesSKOS">http://data.europa.eu/949/shapes/MinVehicleImpedanceVoltagesSKOS</seealso>
    let ``shapes/MinVehicleImpedanceVoltagesSKOS`` =
        Prefixed_Name(era, "shapes/MinVehicleImpedanceVoltagesSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinVehicleInputCapacitance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinVehicleInputCapacitance">http://data.europa.eu/949/shapes/MinVehicleInputCapacitance</seealso>
    let ``shapes/MinVehicleInputCapacitance`` =
        Prefixed_Name(era, "shapes/MinVehicleInputCapacitance") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinVehicleInputCapacitanceApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinVehicleInputCapacitanceApplicability">http://data.europa.eu/949/shapes/MinVehicleInputCapacitanceApplicability</seealso>
    let ``shapes/MinVehicleInputCapacitanceApplicability`` =
        Prefixed_Name(era, "shapes/MinVehicleInputCapacitanceApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinVehicleInputImpedance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinVehicleInputImpedance">http://data.europa.eu/949/shapes/MinVehicleInputImpedance</seealso>
    let ``shapes/MinVehicleInputImpedance`` =
        Prefixed_Name(era, "shapes/MinVehicleInputImpedance") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinVehicleInputImpedanceApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinVehicleInputImpedanceApplicability">http://data.europa.eu/949/shapes/MinVehicleInputImpedanceApplicability</seealso>
    let ``shapes/MinVehicleInputImpedanceApplicability`` =
        Prefixed_Name(era, "shapes/MinVehicleInputImpedanceApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinimumContactWireHeight</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinimumContactWireHeight">http://data.europa.eu/949/shapes/MinimumContactWireHeight</seealso>
    let ``shapes/MinimumContactWireHeight`` =
        Prefixed_Name(era, "shapes/MinimumContactWireHeight") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinimumContactWireHeightApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinimumContactWireHeightApplicability">http://data.europa.eu/949/shapes/MinimumContactWireHeightApplicability</seealso>
    let ``shapes/MinimumContactWireHeightApplicability`` =
        Prefixed_Name(era, "shapes/MinimumContactWireHeightApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinimumHorizontalRadius</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinimumHorizontalRadius">http://data.europa.eu/949/shapes/MinimumHorizontalRadius</seealso>
    let ``shapes/MinimumHorizontalRadius`` =
        Prefixed_Name(era, "shapes/MinimumHorizontalRadius") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinimumHorizontalRadiusS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinimumHorizontalRadiusS">http://data.europa.eu/949/shapes/MinimumHorizontalRadiusS</seealso>
    let ``shapes/MinimumHorizontalRadiusS`` =
        Prefixed_Name(era, "shapes/MinimumHorizontalRadiusS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinimumVerticalRadius</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinimumVerticalRadius">http://data.europa.eu/949/shapes/MinimumVerticalRadius</seealso>
    let ``shapes/MinimumVerticalRadius`` =
        Prefixed_Name(era, "shapes/MinimumVerticalRadius") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinimumVerticalRadiusCrest</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinimumVerticalRadiusCrest">http://data.europa.eu/949/shapes/MinimumVerticalRadiusCrest</seealso>
    let ``shapes/MinimumVerticalRadiusCrest`` =
        Prefixed_Name(era, "shapes/MinimumVerticalRadiusCrest") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinimumVerticalRadiusHollow</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinimumVerticalRadiusHollow">http://data.europa.eu/949/shapes/MinimumVerticalRadiusHollow</seealso>
    let ``shapes/MinimumVerticalRadiusHollow`` =
        Prefixed_Name(era, "shapes/MinimumVerticalRadiusHollow") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinimumVerticalRadiusShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinimumVerticalRadiusShape">http://data.europa.eu/949/shapes/MinimumVerticalRadiusShape</seealso>
    let ``shapes/MinimumVerticalRadiusShape`` =
        Prefixed_Name(era, "shapes/MinimumVerticalRadiusShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/MinimumWheelDiameter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/MinimumWheelDiameter">http://data.europa.eu/949/shapes/MinimumWheelDiameter</seealso>
    let ``shapes/MinimumWheelDiameter`` =
        Prefixed_Name(era, "shapes/MinimumWheelDiameter") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NationalLineSoL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NationalLineSoL">http://data.europa.eu/949/shapes/NationalLineSoL</seealso>
    let ``shapes/NationalLineSoL`` =
        Prefixed_Name(era, "shapes/NationalLineSoL") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NationalLoadCapability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NationalLoadCapability">http://data.europa.eu/949/shapes/NationalLoadCapability</seealso>
    let ``shapes/NationalLoadCapability`` =
        Prefixed_Name(era, "shapes/NationalLoadCapability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NationalRollingStockFireCategory</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NationalRollingStockFireCategory">http://data.europa.eu/949/shapes/NationalRollingStockFireCategory</seealso>
    let ``shapes/NationalRollingStockFireCategory`` =
        Prefixed_Name(era, "shapes/NationalRollingStockFireCategory") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NationalRollingStockFireCategoryApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NationalRollingStockFireCategoryApplicability">http://data.europa.eu/949/shapes/NationalRollingStockFireCategoryApplicability</seealso>
    let ``shapes/NationalRollingStockFireCategoryApplicability`` =
        Prefixed_Name(era, "shapes/NationalRollingStockFireCategoryApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NationalValuesBrakeModel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NationalValuesBrakeModel">http://data.europa.eu/949/shapes/NationalValuesBrakeModel</seealso>
    let ``shapes/NationalValuesBrakeModel`` =
        Prefixed_Name(era, "shapes/NationalValuesBrakeModel") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NationalValuesBrakeModelApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NationalValuesBrakeModelApplicability">http://data.europa.eu/949/shapes/NationalValuesBrakeModelApplicability</seealso>
    let ``shapes/NationalValuesBrakeModelApplicability`` =
        Prefixed_Name(era, "shapes/NationalValuesBrakeModelApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/Navigability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/Navigability">http://data.europa.eu/949/shapes/Navigability</seealso>
    let ``shapes/Navigability`` =
        Prefixed_Name(era, "shapes/Navigability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NavigabilitySKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NavigabilitySKOS">http://data.europa.eu/949/shapes/NavigabilitySKOS</seealso>
    let ``shapes/NavigabilitySKOS`` =
        Prefixed_Name(era, "shapes/NavigabilitySKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NetAreaReferenceShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NetAreaReferenceShape">http://data.europa.eu/949/shapes/NetAreaReferenceShape</seealso>
    let ``shapes/NetAreaReferenceShape`` =
        Prefixed_Name(era, "shapes/NetAreaReferenceShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NetBasicReferenceShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NetBasicReferenceShape">http://data.europa.eu/949/shapes/NetBasicReferenceShape</seealso>
    let ``shapes/NetBasicReferenceShape`` =
        Prefixed_Name(era, "shapes/NetBasicReferenceShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NetElementShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NetElementShape">http://data.europa.eu/949/shapes/NetElementShape</seealso>
    let ``shapes/NetElementShape`` =
        Prefixed_Name(era, "shapes/NetElementShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NetLinearReferenceShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NetLinearReferenceShape">http://data.europa.eu/949/shapes/NetLinearReferenceShape</seealso>
    let ``shapes/NetLinearReferenceShape`` =
        Prefixed_Name(era, "shapes/NetLinearReferenceShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NetPointReferenceShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NetPointReferenceShape">http://data.europa.eu/949/shapes/NetPointReferenceShape</seealso>
    let ``shapes/NetPointReferenceShape`` =
        Prefixed_Name(era, "shapes/NetPointReferenceShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NetReference</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NetReference">http://data.europa.eu/949/shapes/NetReference</seealso>
    let ``shapes/NetReference`` =
        Prefixed_Name(era, "shapes/NetReference") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NetReferenceOP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NetReferenceOP">http://data.europa.eu/949/shapes/NetReferenceOP</seealso>
    let ``shapes/NetReferenceOP`` =
        Prefixed_Name(era, "shapes/NetReferenceOP") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NetReferenceSOL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NetReferenceSOL">http://data.europa.eu/949/shapes/NetReferenceSOL</seealso>
    let ``shapes/NetReferenceSOL`` =
        Prefixed_Name(era, "shapes/NetReferenceSOL") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NetRelationShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NetRelationShape">http://data.europa.eu/949/shapes/NetRelationShape</seealso>
    let ``shapes/NetRelationShape`` =
        Prefixed_Name(era, "shapes/NetRelationShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NoRepeatedPlatformIdsOP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NoRepeatedPlatformIdsOP">http://data.europa.eu/949/shapes/NoRepeatedPlatformIdsOP</seealso>
    let ``shapes/NoRepeatedPlatformIdsOP`` =
        Prefixed_Name(era, "shapes/NoRepeatedPlatformIdsOP") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NoRepeatedSidingIds</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NoRepeatedSidingIds">http://data.europa.eu/949/shapes/NoRepeatedSidingIds</seealso>
    let ``shapes/NoRepeatedSidingIds`` =
        Prefixed_Name(era, "shapes/NoRepeatedSidingIds") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NoRepeatedTrackIdsOP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NoRepeatedTrackIdsOP">http://data.europa.eu/949/shapes/NoRepeatedTrackIdsOP</seealso>
    let ``shapes/NoRepeatedTrackIdsOP`` =
        Prefixed_Name(era, "shapes/NoRepeatedTrackIdsOP") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NoRepeatedTrackIdsSoL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NoRepeatedTrackIdsSoL">http://data.europa.eu/949/shapes/NoRepeatedTrackIdsSoL</seealso>
    let ``shapes/NoRepeatedTrackIdsSoL`` =
        Prefixed_Name(era, "shapes/NoRepeatedTrackIdsSoL") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NonLinearElementShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NonLinearElementShape">http://data.europa.eu/949/shapes/NonLinearElementShape</seealso>
    let ``shapes/NonLinearElementShape`` =
        Prefixed_Name(era, "shapes/NonLinearElementShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NotApplicable</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NotApplicable">http://data.europa.eu/949/shapes/NotApplicable</seealso>
    let ``shapes/NotApplicable`` =
        Prefixed_Name(era, "shapes/NotApplicable") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NotApplicableShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NotApplicableShape">http://data.europa.eu/949/shapes/NotApplicableShape</seealso>
    let ``shapes/NotApplicableShape`` =
        Prefixed_Name(era, "shapes/NotApplicableShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NotYetAvailable</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NotYetAvailable">http://data.europa.eu/949/shapes/NotYetAvailable</seealso>
    let ``shapes/NotYetAvailable`` =
        Prefixed_Name(era, "shapes/NotYetAvailable") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/NotYetAvailableShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/NotYetAvailableShape">http://data.europa.eu/949/shapes/NotYetAvailableShape</seealso>
    let ``shapes/NotYetAvailableShape`` =
        Prefixed_Name(era, "shapes/NotYetAvailableShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OfParameter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OfParameter">http://data.europa.eu/949/shapes/OfParameter</seealso>
    let ``shapes/OfParameter`` =
        Prefixed_Name(era, "shapes/OfParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OffsetFromKilometricPost</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OffsetFromKilometricPost">http://data.europa.eu/949/shapes/OffsetFromKilometricPost</seealso>
    let ``shapes/OffsetFromKilometricPost`` =
        Prefixed_Name(era, "shapes/OffsetFromKilometricPost") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OffsetFromOrigin</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OffsetFromOrigin">http://data.europa.eu/949/shapes/OffsetFromOrigin</seealso>
    let ``shapes/OffsetFromOrigin`` =
        Prefixed_Name(era, "shapes/OffsetFromOrigin") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OnElement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OnElement">http://data.europa.eu/949/shapes/OnElement</seealso>
    let ``shapes/OnElement`` = Prefixed_Name(era, "shapes/OnElement") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OnLinearElement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OnLinearElement">http://data.europa.eu/949/shapes/OnLinearElement</seealso>
    let ``shapes/OnLinearElement`` =
        Prefixed_Name(era, "shapes/OnLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OpEnd</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OpEnd">http://data.europa.eu/949/shapes/OpEnd</seealso>
    let ``shapes/OpEnd`` = Prefixed_Name(era, "shapes/OpEnd") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OpEndExists</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OpEndExists">http://data.europa.eu/949/shapes/OpEndExists</seealso>
    let ``shapes/OpEndExists`` =
        Prefixed_Name(era, "shapes/OpEndExists") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OpName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OpName">http://data.europa.eu/949/shapes/OpName</seealso>
    let ``shapes/OpName`` = Prefixed_Name(era, "shapes/OpName") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/OpStart</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OpStart">http://data.europa.eu/949/shapes/OpStart</seealso>
    let ``shapes/OpStart`` = Prefixed_Name(era, "shapes/OpStart") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OpStartExists</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OpStartExists">http://data.europa.eu/949/shapes/OpStartExists</seealso>
    let ``shapes/OpStartExists`` =
        Prefixed_Name(era, "shapes/OpStartExists") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OpTypeGaugeChangeover</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OpTypeGaugeChangeover">http://data.europa.eu/949/shapes/OpTypeGaugeChangeover</seealso>
    let ``shapes/OpTypeGaugeChangeover`` =
        Prefixed_Name(era, "shapes/OpTypeGaugeChangeover") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OpTypeP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OpTypeP">http://data.europa.eu/949/shapes/OpTypeP</seealso>
    let ``shapes/OpTypeP`` = Prefixed_Name(era, "shapes/OpTypeP") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/OpTypeSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OpTypeSKOS">http://data.europa.eu/949/shapes/OpTypeSKOS</seealso>
    let ``shapes/OpTypeSKOS`` = Prefixed_Name(era, "shapes/OpTypeSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OperationalPointShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OperationalPointShape">http://data.europa.eu/949/shapes/OperationalPointShape</seealso>
    let ``shapes/OperationalPointShape`` =
        Prefixed_Name(era, "shapes/OperationalPointShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OperationalRegimeType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OperationalRegimeType">http://data.europa.eu/949/shapes/OperationalRegimeType</seealso>
    let ``shapes/OperationalRegimeType`` =
        Prefixed_Name(era, "shapes/OperationalRegimeType") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OperationalRegimeTypeSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OperationalRegimeTypeSKOS">http://data.europa.eu/949/shapes/OperationalRegimeTypeSKOS</seealso>
    let ``shapes/OperationalRegimeTypeSKOS`` =
        Prefixed_Name(era, "shapes/OperationalRegimeTypeSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OrganisationCode</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OrganisationCode">http://data.europa.eu/949/shapes/OrganisationCode</seealso>
    let ``shapes/OrganisationCode`` =
        Prefixed_Name(era, "shapes/OrganisationCode") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OrganisationRoleShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OrganisationRoleShape">http://data.europa.eu/949/shapes/OrganisationRoleShape</seealso>
    let ``shapes/OrganisationRoleShape`` =
        Prefixed_Name(era, "shapes/OrganisationRoleShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OrientationShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OrientationShape">http://data.europa.eu/949/shapes/OrientationShape</seealso>
    let ``shapes/OrientationShape`` =
        Prefixed_Name(era, "shapes/OrientationShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OtherCantDeficiencyBasicSSP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OtherCantDeficiencyBasicSSP">http://data.europa.eu/949/shapes/OtherCantDeficiencyBasicSSP</seealso>
    let ``shapes/OtherCantDeficiencyBasicSSP`` =
        Prefixed_Name(era, "shapes/OtherCantDeficiencyBasicSSP") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OtherCantDeficiencyBasicSSPApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OtherCantDeficiencyBasicSSPApplicability">http://data.europa.eu/949/shapes/OtherCantDeficiencyBasicSSPApplicability</seealso>
    let ``shapes/OtherCantDeficiencyBasicSSPApplicability`` =
        Prefixed_Name(era, "shapes/OtherCantDeficiencyBasicSSPApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OtherCantDeficiencyBasicSSPSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OtherCantDeficiencyBasicSSPSKOS">http://data.europa.eu/949/shapes/OtherCantDeficiencyBasicSSPSKOS</seealso>
    let ``shapes/OtherCantDeficiencyBasicSSPSKOS`` =
        Prefixed_Name(era, "shapes/OtherCantDeficiencyBasicSSPSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OtherPantographHeadApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OtherPantographHeadApplicability">http://data.europa.eu/949/shapes/OtherPantographHeadApplicability</seealso>
    let ``shapes/OtherPantographHeadApplicability`` =
        Prefixed_Name(era, "shapes/OtherPantographHeadApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OtherPantographHeadSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OtherPantographHeadSKOS">http://data.europa.eu/949/shapes/OtherPantographHeadSKOS</seealso>
    let ``shapes/OtherPantographHeadSKOS`` =
        Prefixed_Name(era, "shapes/OtherPantographHeadSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OtherTrainProtection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OtherTrainProtection">http://data.europa.eu/949/shapes/OtherTrainProtection</seealso>
    let ``shapes/OtherTrainProtection`` =
        Prefixed_Name(era, "shapes/OtherTrainProtection") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OtherTrainProtectionApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OtherTrainProtectionApplicability">http://data.europa.eu/949/shapes/OtherTrainProtectionApplicability</seealso>
    let ``shapes/OtherTrainProtectionApplicability`` =
        Prefixed_Name(era, "shapes/OtherTrainProtectionApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/OtherTrainProtectionSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/OtherTrainProtectionSKOS">http://data.europa.eu/949/shapes/OtherTrainProtectionSKOS</seealso>
    let ``shapes/OtherTrainProtectionSKOS`` =
        Prefixed_Name(era, "shapes/OtherTrainProtectionSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ParameterApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ParameterApplicability">http://data.europa.eu/949/shapes/ParameterApplicability</seealso>
    let ``shapes/ParameterApplicability`` =
        Prefixed_Name(era, "shapes/ParameterApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ParameterApplicabilityShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ParameterApplicabilityShape">http://data.europa.eu/949/shapes/ParameterApplicabilityShape</seealso>
    let ``shapes/ParameterApplicabilityShape`` =
        Prefixed_Name(era, "shapes/ParameterApplicabilityShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ParameterValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ParameterValue">http://data.europa.eu/949/shapes/ParameterValue</seealso>
    let ``shapes/ParameterValue`` =
        Prefixed_Name(era, "shapes/ParameterValue") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ParameterValueType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ParameterValueType">http://data.europa.eu/949/shapes/ParameterValueType</seealso>
    let ``shapes/ParameterValueType`` =
        Prefixed_Name(era, "shapes/ParameterValueType") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ParameterValueTypeSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ParameterValueTypeSKOS">http://data.europa.eu/949/shapes/ParameterValueTypeSKOS</seealso>
    let ``shapes/ParameterValueTypeSKOS`` =
        Prefixed_Name(era, "shapes/ParameterValueTypeSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PassengerFlag</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PassengerFlag">http://data.europa.eu/949/shapes/PassengerFlag</seealso>
    let ``shapes/PassengerFlag`` =
        Prefixed_Name(era, "shapes/PassengerFlag") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PermissionChargingElectricEnergyTractionStandstill</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PermissionChargingElectricEnergyTractionStandstill">http://data.europa.eu/949/shapes/PermissionChargingElectricEnergyTractionStandstill</seealso>
    let ``shapes/PermissionChargingElectricEnergyTractionStandstill`` =
        Prefixed_Name(era, "shapes/PermissionChargingElectricEnergyTractionStandstill") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PermitUseReflectivePlates</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PermitUseReflectivePlates">http://data.europa.eu/949/shapes/PermitUseReflectivePlates</seealso>
    let ``shapes/PermitUseReflectivePlates`` =
        Prefixed_Name(era, "shapes/PermitUseReflectivePlates") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PermittedContactForce</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PermittedContactForce">http://data.europa.eu/949/shapes/PermittedContactForce</seealso>
    let ``shapes/PermittedContactForce`` =
        Prefixed_Name(era, "shapes/PermittedContactForce") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PermittedContactForceApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PermittedContactForceApplicability">http://data.europa.eu/949/shapes/PermittedContactForceApplicability</seealso>
    let ``shapes/PermittedContactForceApplicability`` =
        Prefixed_Name(era, "shapes/PermittedContactForceApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PhaseInfoChangeSupplySystem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PhaseInfoChangeSupplySystem">http://data.europa.eu/949/shapes/PhaseInfoChangeSupplySystem</seealso>
    let ``shapes/PhaseInfoChangeSupplySystem`` =
        Prefixed_Name(era, "shapes/PhaseInfoChangeSupplySystem") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PhaseInfoDistanceType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PhaseInfoDistanceType">http://data.europa.eu/949/shapes/PhaseInfoDistanceType</seealso>
    let ``shapes/PhaseInfoDistanceType`` =
        Prefixed_Name(era, "shapes/PhaseInfoDistanceType") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PhaseInfoKm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PhaseInfoKm">http://data.europa.eu/949/shapes/PhaseInfoKm</seealso>
    let ``shapes/PhaseInfoKm`` =
        Prefixed_Name(era, "shapes/PhaseInfoKm") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PhaseInfoLength</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PhaseInfoLength">http://data.europa.eu/949/shapes/PhaseInfoLength</seealso>
    let ``shapes/PhaseInfoLength`` =
        Prefixed_Name(era, "shapes/PhaseInfoLength") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PhaseInfoPantographLowered</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PhaseInfoPantographLowered">http://data.europa.eu/949/shapes/PhaseInfoPantographLowered</seealso>
    let ``shapes/PhaseInfoPantographLowered`` =
        Prefixed_Name(era, "shapes/PhaseInfoPantographLowered") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PhaseInfoShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PhaseInfoShape">http://data.europa.eu/949/shapes/PhaseInfoShape</seealso>
    let ``shapes/PhaseInfoShape`` =
        Prefixed_Name(era, "shapes/PhaseInfoShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PhaseInfoSwitchOffBreaker</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PhaseInfoSwitchOffBreaker">http://data.europa.eu/949/shapes/PhaseInfoSwitchOffBreaker</seealso>
    let ``shapes/PhaseInfoSwitchOffBreaker`` =
        Prefixed_Name(era, "shapes/PhaseInfoSwitchOffBreaker") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PlatformEdgeShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PlatformEdgeShape">http://data.europa.eu/949/shapes/PlatformEdgeShape</seealso>
    let ``shapes/PlatformEdgeShape`` =
        Prefixed_Name(era, "shapes/PlatformEdgeShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PlatformHeightP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PlatformHeightP">http://data.europa.eu/949/shapes/PlatformHeightP</seealso>
    let ``shapes/PlatformHeightP`` =
        Prefixed_Name(era, "shapes/PlatformHeightP") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PlatformHeightSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PlatformHeightSKOS">http://data.europa.eu/949/shapes/PlatformHeightSKOS</seealso>
    let ``shapes/PlatformHeightSKOS`` =
        Prefixed_Name(era, "shapes/PlatformHeightSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PlatformId</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PlatformId">http://data.europa.eu/949/shapes/PlatformId</seealso>
    let ``shapes/PlatformId`` = Prefixed_Name(era, "shapes/PlatformId") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PrimaryLocation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PrimaryLocation">http://data.europa.eu/949/shapes/PrimaryLocation</seealso>
    let ``shapes/PrimaryLocation`` =
        Prefixed_Name(era, "shapes/PrimaryLocation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PrimaryLocationCode</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PrimaryLocationCode">http://data.europa.eu/949/shapes/PrimaryLocationCode</seealso>
    let ``shapes/PrimaryLocationCode`` =
        Prefixed_Name(era, "shapes/PrimaryLocationCode") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PrimaryLocationName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PrimaryLocationName">http://data.europa.eu/949/shapes/PrimaryLocationName</seealso>
    let ``shapes/PrimaryLocationName`` =
        Prefixed_Name(era, "shapes/PrimaryLocationName") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PrimaryLocationShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PrimaryLocationShape">http://data.europa.eu/949/shapes/PrimaryLocationShape</seealso>
    let ``shapes/PrimaryLocationShape`` =
        Prefixed_Name(era, "shapes/PrimaryLocationShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ProfileNumberSemiTrailersSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ProfileNumberSemiTrailersSKOS">http://data.europa.eu/949/shapes/ProfileNumberSemiTrailersSKOS</seealso>
    let ``shapes/ProfileNumberSemiTrailersSKOS`` =
        Prefixed_Name(era, "shapes/ProfileNumberSemiTrailersSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ProfileNumberSwapBodiesSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ProfileNumberSwapBodiesSKOS">http://data.europa.eu/949/shapes/ProfileNumberSwapBodiesSKOS</seealso>
    let ``shapes/ProfileNumberSwapBodiesSKOS`` =
        Prefixed_Name(era, "shapes/ProfileNumberSwapBodiesSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ProtectionLegacySystemSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ProtectionLegacySystemSKOS">http://data.europa.eu/949/shapes/ProtectionLegacySystemSKOS</seealso>
    let ``shapes/ProtectionLegacySystemSKOS`` =
        Prefixed_Name(era, "shapes/ProtectionLegacySystemSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PublicNetworkRoaming</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PublicNetworkRoaming">http://data.europa.eu/949/shapes/PublicNetworkRoaming</seealso>
    let ``shapes/PublicNetworkRoaming`` =
        Prefixed_Name(era, "shapes/PublicNetworkRoaming") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PublicNetworkRoamingApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PublicNetworkRoamingApplicability">http://data.europa.eu/949/shapes/PublicNetworkRoamingApplicability</seealso>
    let ``shapes/PublicNetworkRoamingApplicability`` =
        Prefixed_Name(era, "shapes/PublicNetworkRoamingApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PublicNetworkRoamingDetails</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PublicNetworkRoamingDetails">http://data.europa.eu/949/shapes/PublicNetworkRoamingDetails</seealso>
    let ``shapes/PublicNetworkRoamingDetails`` =
        Prefixed_Name(era, "shapes/PublicNetworkRoamingDetails") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/PublicNetworkRoamingDetailsApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/PublicNetworkRoamingDetailsApplicability">http://data.europa.eu/949/shapes/PublicNetworkRoamingDetailsApplicability</seealso>
    let ``shapes/PublicNetworkRoamingDetailsApplicability`` =
        Prefixed_Name(era, "shapes/PublicNetworkRoamingDetailsApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/QNvdriverAdhes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/QNvdriverAdhes">http://data.europa.eu/949/shapes/QNvdriverAdhes</seealso>
    let ``shapes/QNvdriverAdhes`` =
        Prefixed_Name(era, "shapes/QNvdriverAdhes") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/QNvdriverAdhesApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/QNvdriverAdhesApplicability">http://data.europa.eu/949/shapes/QNvdriverAdhesApplicability</seealso>
    let ``shapes/QNvdriverAdhesApplicability`` =
        Prefixed_Name(era, "shapes/QNvdriverAdhesApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/QNvdriverAdhesSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/QNvdriverAdhesSKOS">http://data.europa.eu/949/shapes/QNvdriverAdhesSKOS</seealso>
    let ``shapes/QNvdriverAdhesSKOS`` =
        Prefixed_Name(era, "shapes/QNvdriverAdhesSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/QNvemrrls</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/QNvemrrls">http://data.europa.eu/949/shapes/QNvemrrls</seealso>
    let ``shapes/QNvemrrls`` = Prefixed_Name(era, "shapes/QNvemrrls") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/QNvemrrlsApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/QNvemrrlsApplicability">http://data.europa.eu/949/shapes/QNvemrrlsApplicability</seealso>
    let ``shapes/QNvemrrlsApplicability`` =
        Prefixed_Name(era, "shapes/QNvemrrlsApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/QNvemrrlsSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/QNvemrrlsSKOS">http://data.europa.eu/949/shapes/QNvemrrlsSKOS</seealso>
    let ``shapes/QNvemrrlsSKOS`` =
        Prefixed_Name(era, "shapes/QNvemrrlsSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/QNvsbtsmperm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/QNvsbtsmperm">http://data.europa.eu/949/shapes/QNvsbtsmperm</seealso>
    let ``shapes/QNvsbtsmperm`` =
        Prefixed_Name(era, "shapes/QNvsbtsmperm") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/QNvsbtsmpermApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/QNvsbtsmpermApplicability">http://data.europa.eu/949/shapes/QNvsbtsmpermApplicability</seealso>
    let ``shapes/QNvsbtsmpermApplicability`` =
        Prefixed_Name(era, "shapes/QNvsbtsmpermApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RadioBlockCenterShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RadioBlockCenterShape">http://data.europa.eu/949/shapes/RadioBlockCenterShape</seealso>
    let ``shapes/RadioBlockCenterShape`` =
        Prefixed_Name(era, "shapes/RadioBlockCenterShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RadioNetworkId</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RadioNetworkId">http://data.europa.eu/949/shapes/RadioNetworkId</seealso>
    let ``shapes/RadioNetworkId`` =
        Prefixed_Name(era, "shapes/RadioNetworkId") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RadioNetworkIdApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RadioNetworkIdApplicability">http://data.europa.eu/949/shapes/RadioNetworkIdApplicability</seealso>
    let ``shapes/RadioNetworkIdApplicability`` =
        Prefixed_Name(era, "shapes/RadioNetworkIdApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RailInclination</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RailInclination">http://data.europa.eu/949/shapes/RailInclination</seealso>
    let ``shapes/RailInclination`` =
        Prefixed_Name(era, "shapes/RailInclination") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RailInclinationSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RailInclinationSKOS">http://data.europa.eu/949/shapes/RailInclinationSKOS</seealso>
    let ``shapes/RailInclinationSKOS`` =
        Prefixed_Name(era, "shapes/RailInclinationSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RaisedPantographsDistance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RaisedPantographsDistance">http://data.europa.eu/949/shapes/RaisedPantographsDistance</seealso>
    let ``shapes/RaisedPantographsDistance`` =
        Prefixed_Name(era, "shapes/RaisedPantographsDistance") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RaisedPantographsDistanceAndSpeedShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RaisedPantographsDistanceAndSpeedShape">http://data.europa.eu/949/shapes/RaisedPantographsDistanceAndSpeedShape</seealso>
    let ``shapes/RaisedPantographsDistanceAndSpeedShape`` =
        Prefixed_Name(era, "shapes/RaisedPantographsDistanceAndSpeedShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RaisedPantographsNumber</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RaisedPantographsNumber">http://data.europa.eu/949/shapes/RaisedPantographsNumber</seealso>
    let ``shapes/RaisedPantographsNumber`` =
        Prefixed_Name(era, "shapes/RaisedPantographsNumber") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RaisedPantographsSpeed</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RaisedPantographsSpeed">http://data.europa.eu/949/shapes/RaisedPantographsSpeed</seealso>
    let ``shapes/RaisedPantographsSpeed`` =
        Prefixed_Name(era, "shapes/RaisedPantographsSpeed") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RbcID</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RbcID">http://data.europa.eu/949/shapes/RbcID</seealso>
    let ``shapes/RbcID`` = Prefixed_Name(era, "shapes/RbcID") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/RbcPhone</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RbcPhone">http://data.europa.eu/949/shapes/RbcPhone</seealso>
    let ``shapes/RbcPhone`` = Prefixed_Name(era, "shapes/RbcPhone") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ReasonsEtcsRadioBlockCenterReject</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ReasonsEtcsRadioBlockCenterReject">http://data.europa.eu/949/shapes/ReasonsEtcsRadioBlockCenterReject</seealso>
    let ``shapes/ReasonsEtcsRadioBlockCenterReject`` =
        Prefixed_Name(era, "shapes/ReasonsEtcsRadioBlockCenterReject") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ReasonsEtcsRadioBlockCenterRejectSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ReasonsEtcsRadioBlockCenterRejectSKOS">http://data.europa.eu/949/shapes/ReasonsEtcsRadioBlockCenterRejectSKOS</seealso>
    let ``shapes/ReasonsEtcsRadioBlockCenterRejectSKOS`` =
        Prefixed_Name(era, "shapes/ReasonsEtcsRadioBlockCenterRejectSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RedLightsRequired</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RedLightsRequired">http://data.europa.eu/949/shapes/RedLightsRequired</seealso>
    let ``shapes/RedLightsRequired`` =
        Prefixed_Name(era, "shapes/RedLightsRequired") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RedLightsRequiredCountryApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RedLightsRequiredCountryApplicability">http://data.europa.eu/949/shapes/RedLightsRequiredCountryApplicability</seealso>
    let ``shapes/RedLightsRequiredCountryApplicability`` =
        Prefixed_Name(era, "shapes/RedLightsRequiredCountryApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ReferenceBorderPoint</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ReferenceBorderPoint">http://data.europa.eu/949/shapes/ReferenceBorderPoint</seealso>
    let ``shapes/ReferenceBorderPoint`` =
        Prefixed_Name(era, "shapes/ReferenceBorderPoint") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/ReferenceBorderPointShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/ReferenceBorderPointShape">http://data.europa.eu/949/shapes/ReferenceBorderPointShape</seealso>
    let ``shapes/ReferenceBorderPointShape`` =
        Prefixed_Name(era, "shapes/ReferenceBorderPointShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RelativeDistanceDangerPoint</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RelativeDistanceDangerPoint">http://data.europa.eu/949/shapes/RelativeDistanceDangerPoint</seealso>
    let ``shapes/RelativeDistanceDangerPoint`` =
        Prefixed_Name(era, "shapes/RelativeDistanceDangerPoint") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/Role</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/Role">http://data.europa.eu/949/shapes/Role</seealso>
    let ``shapes/Role`` = Prefixed_Name(era, "shapes/Role") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/RoleOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RoleOf">http://data.europa.eu/949/shapes/RoleOf</seealso>
    let ``shapes/RoleOf`` = Prefixed_Name(era, "shapes/RoleOf") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RollingStockFireCategory</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RollingStockFireCategory">http://data.europa.eu/949/shapes/RollingStockFireCategory</seealso>
    let ``shapes/RollingStockFireCategory`` =
        Prefixed_Name(era, "shapes/RollingStockFireCategory") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RollingStockFireCategoryApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RollingStockFireCategoryApplicability">http://data.europa.eu/949/shapes/RollingStockFireCategoryApplicability</seealso>
    let ``shapes/RollingStockFireCategoryApplicability`` =
        Prefixed_Name(era, "shapes/RollingStockFireCategoryApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RollingStockFireCategorySKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RollingStockFireCategorySKOS">http://data.europa.eu/949/shapes/RollingStockFireCategorySKOS</seealso>
    let ``shapes/RollingStockFireCategorySKOS`` =
        Prefixed_Name(era, "shapes/RollingStockFireCategorySKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/RunningTrackShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/RunningTrackShape">http://data.europa.eu/949/shapes/RunningTrackShape</seealso>
    let ``shapes/RunningTrackShape`` =
        Prefixed_Name(era, "shapes/RunningTrackShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SafeConsistLengthInformationNecessary</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SafeConsistLengthInformationNecessary">http://data.europa.eu/949/shapes/SafeConsistLengthInformationNecessary</seealso>
    let ``shapes/SafeConsistLengthInformationNecessary`` =
        Prefixed_Name(era, "shapes/SafeConsistLengthInformationNecessary") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SafeConsistLengthInformationNecessaryApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SafeConsistLengthInformationNecessaryApplicability">http://data.europa.eu/949/shapes/SafeConsistLengthInformationNecessaryApplicability</seealso>
    let ``shapes/SafeConsistLengthInformationNecessaryApplicability`` =
        Prefixed_Name(era, "shapes/SafeConsistLengthInformationNecessaryApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SafeConsistLengthInformationNecessarySKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SafeConsistLengthInformationNecessarySKOS">http://data.europa.eu/949/shapes/SafeConsistLengthInformationNecessarySKOS</seealso>
    let ``shapes/SafeConsistLengthInformationNecessarySKOS`` =
        Prefixed_Name(era, "shapes/SafeConsistLengthInformationNecessarySKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SectionOfLineShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SectionOfLineShape">http://data.europa.eu/949/shapes/SectionOfLineShape</seealso>
    let ``shapes/SectionOfLineShape`` =
        Prefixed_Name(era, "shapes/SectionOfLineShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/Side</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/Side">http://data.europa.eu/949/shapes/Side</seealso>
    let ``shapes/Side`` = Prefixed_Name(era, "shapes/Side") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/SideSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SideSKOS">http://data.europa.eu/949/shapes/SideSKOS</seealso>
    let ``shapes/SideSKOS`` = Prefixed_Name(era, "shapes/SideSKOS") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/SidingId</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SidingId">http://data.europa.eu/949/shapes/SidingId</seealso>
    let ``shapes/SidingId`` = Prefixed_Name(era, "shapes/SidingId") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SidingShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SidingShape">http://data.europa.eu/949/shapes/SidingShape</seealso>
    let ``shapes/SidingShape`` =
        Prefixed_Name(era, "shapes/SidingShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SignalId</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SignalId">http://data.europa.eu/949/shapes/SignalId</seealso>
    let ``shapes/SignalId`` = Prefixed_Name(era, "shapes/SignalId") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SignalOrientation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SignalOrientation">http://data.europa.eu/949/shapes/SignalOrientation</seealso>
    let ``shapes/SignalOrientation`` =
        Prefixed_Name(era, "shapes/SignalOrientation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SignalOrientationSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SignalOrientationSKOS">http://data.europa.eu/949/shapes/SignalOrientationSKOS</seealso>
    let ``shapes/SignalOrientationSKOS`` =
        Prefixed_Name(era, "shapes/SignalOrientationSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SignalShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SignalShape">http://data.europa.eu/949/shapes/SignalShape</seealso>
    let ``shapes/SignalShape`` =
        Prefixed_Name(era, "shapes/SignalShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SignalType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SignalType">http://data.europa.eu/949/shapes/SignalType</seealso>
    let ``shapes/SignalType`` = Prefixed_Name(era, "shapes/SignalType") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SignalTypeSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SignalTypeSKOS">http://data.europa.eu/949/shapes/SignalTypeSKOS</seealso>
    let ``shapes/SignalTypeSKOS`` =
        Prefixed_Name(era, "shapes/SignalTypeSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SoLTrackDirectionMaxCount</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SoLTrackDirectionMaxCount">http://data.europa.eu/949/shapes/SoLTrackDirectionMaxCount</seealso>
    let ``shapes/SoLTrackDirectionMaxCount`` =
        Prefixed_Name(era, "shapes/SoLTrackDirectionMaxCount") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SoLTrackDirectionMinCount</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SoLTrackDirectionMinCount">http://data.europa.eu/949/shapes/SoLTrackDirectionMinCount</seealso>
    let ``shapes/SoLTrackDirectionMinCount`` =
        Prefixed_Name(era, "shapes/SoLTrackDirectionMinCount") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SolLength</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SolLength">http://data.europa.eu/949/shapes/SolLength</seealso>
    let ``shapes/SolLength`` = Prefixed_Name(era, "shapes/SolLength") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/SolNature</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SolNature">http://data.europa.eu/949/shapes/SolNature</seealso>
    let ``shapes/SolNature`` = Prefixed_Name(era, "shapes/SolNature") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SolNatureApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SolNatureApplicability">http://data.europa.eu/949/shapes/SolNatureApplicability</seealso>
    let ``shapes/SolNatureApplicability`` =
        Prefixed_Name(era, "shapes/SolNatureApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SolNatureSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SolNatureSKOS">http://data.europa.eu/949/shapes/SolNatureSKOS</seealso>
    let ``shapes/SolNatureSKOS`` =
        Prefixed_Name(era, "shapes/SolNatureSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SpecialAreaShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SpecialAreaShape">http://data.europa.eu/949/shapes/SpecialAreaShape</seealso>
    let ``shapes/SpecialAreaShape`` =
        Prefixed_Name(era, "shapes/SpecialAreaShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SpecialAreaType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SpecialAreaType">http://data.europa.eu/949/shapes/SpecialAreaType</seealso>
    let ``shapes/SpecialAreaType`` =
        Prefixed_Name(era, "shapes/SpecialAreaType") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SpecialAreaTypeSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SpecialAreaTypeSKOS">http://data.europa.eu/949/shapes/SpecialAreaTypeSKOS</seealso>
    let ``shapes/SpecialAreaTypeSKOS`` =
        Prefixed_Name(era, "shapes/SpecialAreaTypeSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SpecialTunnelAreaShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SpecialTunnelAreaShape">http://data.europa.eu/949/shapes/SpecialTunnelAreaShape</seealso>
    let ``shapes/SpecialTunnelAreaShape`` =
        Prefixed_Name(era, "shapes/SpecialTunnelAreaShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SpecificInformation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SpecificInformation">http://data.europa.eu/949/shapes/SpecificInformation</seealso>
    let ``shapes/SpecificInformation`` =
        Prefixed_Name(era, "shapes/SpecificInformation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/StandardCombinedRollerUnits</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/StandardCombinedRollerUnits">http://data.europa.eu/949/shapes/StandardCombinedRollerUnits</seealso>
    let ``shapes/StandardCombinedRollerUnits`` =
        Prefixed_Name(era, "shapes/StandardCombinedRollerUnits") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/StandardCombinedRollerUnitsSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/StandardCombinedRollerUnitsSKOS">http://data.europa.eu/949/shapes/StandardCombinedRollerUnitsSKOS</seealso>
    let ``shapes/StandardCombinedRollerUnitsSKOS`` =
        Prefixed_Name(era, "shapes/StandardCombinedRollerUnitsSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/StandardCombinedTransportContainers</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/StandardCombinedTransportContainers">http://data.europa.eu/949/shapes/StandardCombinedTransportContainers</seealso>
    let ``shapes/StandardCombinedTransportContainers`` =
        Prefixed_Name(era, "shapes/StandardCombinedTransportContainers") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/StandardCombinedTransportContainersSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/StandardCombinedTransportContainersSKOS">http://data.europa.eu/949/shapes/StandardCombinedTransportContainersSKOS</seealso>
    let ``shapes/StandardCombinedTransportContainersSKOS`` =
        Prefixed_Name(era, "shapes/StandardCombinedTransportContainersSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/StartLocation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/StartLocation">http://data.europa.eu/949/shapes/StartLocation</seealso>
    let ``shapes/StartLocation`` =
        Prefixed_Name(era, "shapes/StartLocation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/StartOffsetFromOrigin</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/StartOffsetFromOrigin">http://data.europa.eu/949/shapes/StartOffsetFromOrigin</seealso>
    let ``shapes/StartOffsetFromOrigin`` =
        Prefixed_Name(era, "shapes/StartOffsetFromOrigin") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/StartsAt</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/StartsAt">http://data.europa.eu/949/shapes/StartsAt</seealso>
    let ``shapes/StartsAt`` = Prefixed_Name(era, "shapes/StartsAt") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/StructureCheckLocation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/StructureCheckLocation">http://data.europa.eu/949/shapes/StructureCheckLocation</seealso>
    let ``shapes/StructureCheckLocation`` =
        Prefixed_Name(era, "shapes/StructureCheckLocation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SubsetName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SubsetName">http://data.europa.eu/949/shapes/SubsetName</seealso>
    let ``shapes/SubsetName`` = Prefixed_Name(era, "shapes/SubsetName") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/SubsetOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SubsetOf">http://data.europa.eu/949/shapes/SubsetOf</seealso>
    let ``shapes/SubsetOf`` = Prefixed_Name(era, "shapes/SubsetOf") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SubsidiaryLocationCode</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SubsidiaryLocationCode">http://data.europa.eu/949/shapes/SubsidiaryLocationCode</seealso>
    let ``shapes/SubsidiaryLocationCode`` =
        Prefixed_Name(era, "shapes/SubsidiaryLocationCode") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SubsidiaryLocationName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SubsidiaryLocationName">http://data.europa.eu/949/shapes/SubsidiaryLocationName</seealso>
    let ``shapes/SubsidiaryLocationName`` =
        Prefixed_Name(era, "shapes/SubsidiaryLocationName") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SubsidiaryLocationShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SubsidiaryLocationShape">http://data.europa.eu/949/shapes/SubsidiaryLocationShape</seealso>
    let ``shapes/SubsidiaryLocationShape`` =
        Prefixed_Name(era, "shapes/SubsidiaryLocationShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SubsidiaryLocationType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SubsidiaryLocationType">http://data.europa.eu/949/shapes/SubsidiaryLocationType</seealso>
    let ``shapes/SubsidiaryLocationType`` =
        Prefixed_Name(era, "shapes/SubsidiaryLocationType") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SubsidiaryLocationTypeSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SubsidiaryLocationTypeSKOS">http://data.europa.eu/949/shapes/SubsidiaryLocationTypeSKOS</seealso>
    let ``shapes/SubsidiaryLocationTypeSKOS`` =
        Prefixed_Name(era, "shapes/SubsidiaryLocationTypeSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SwitchProtectControlWarning</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SwitchProtectControlWarning">http://data.europa.eu/949/shapes/SwitchProtectControlWarning</seealso>
    let ``shapes/SwitchProtectControlWarning`` =
        Prefixed_Name(era, "shapes/SwitchProtectControlWarning") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SwitchProtectControlWarningApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SwitchProtectControlWarningApplicability">http://data.europa.eu/949/shapes/SwitchProtectControlWarningApplicability</seealso>
    let ``shapes/SwitchProtectControlWarningApplicability`` =
        Prefixed_Name(era, "shapes/SwitchProtectControlWarningApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SwitchRadioSystem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SwitchRadioSystem">http://data.europa.eu/949/shapes/SwitchRadioSystem</seealso>
    let ``shapes/SwitchRadioSystem`` =
        Prefixed_Name(era, "shapes/SwitchRadioSystem") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SwitchRadioSystemApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SwitchRadioSystemApplicability">http://data.europa.eu/949/shapes/SwitchRadioSystemApplicability</seealso>
    let ``shapes/SwitchRadioSystemApplicability`` =
        Prefixed_Name(era, "shapes/SwitchRadioSystemApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SwitchShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SwitchShape">http://data.europa.eu/949/shapes/SwitchShape</seealso>
    let ``shapes/SwitchShape`` =
        Prefixed_Name(era, "shapes/SwitchShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SystemSeparationInfoChangeSupplySystem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SystemSeparationInfoChangeSupplySystem">http://data.europa.eu/949/shapes/SystemSeparationInfoChangeSupplySystem</seealso>
    let ``shapes/SystemSeparationInfoChangeSupplySystem`` =
        Prefixed_Name(era, "shapes/SystemSeparationInfoChangeSupplySystem") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SystemSeparationInfoKm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SystemSeparationInfoKm">http://data.europa.eu/949/shapes/SystemSeparationInfoKm</seealso>
    let ``shapes/SystemSeparationInfoKm`` =
        Prefixed_Name(era, "shapes/SystemSeparationInfoKm") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SystemSeparationInfoLength</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SystemSeparationInfoLength">http://data.europa.eu/949/shapes/SystemSeparationInfoLength</seealso>
    let ``shapes/SystemSeparationInfoLength`` =
        Prefixed_Name(era, "shapes/SystemSeparationInfoLength") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SystemSeparationInfoPantographLowered</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SystemSeparationInfoPantographLowered">http://data.europa.eu/949/shapes/SystemSeparationInfoPantographLowered</seealso>
    let ``shapes/SystemSeparationInfoPantographLowered`` =
        Prefixed_Name(era, "shapes/SystemSeparationInfoPantographLowered") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SystemSeparationInfoShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SystemSeparationInfoShape">http://data.europa.eu/949/shapes/SystemSeparationInfoShape</seealso>
    let ``shapes/SystemSeparationInfoShape`` =
        Prefixed_Name(era, "shapes/SystemSeparationInfoShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/SystemSeparationInfoSwitchOffBreaker</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/SystemSeparationInfoSwitchOffBreaker">http://data.europa.eu/949/shapes/SystemSeparationInfoSwitchOffBreaker</seealso>
    let ``shapes/SystemSeparationInfoSwitchOffBreaker`` =
        Prefixed_Name(era, "shapes/SystemSeparationInfoSwitchOffBreaker") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TNvcontact</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TNvcontact">http://data.europa.eu/949/shapes/TNvcontact</seealso>
    let ``shapes/TNvcontact`` = Prefixed_Name(era, "shapes/TNvcontact") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TNvcontactApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TNvcontactApplicability">http://data.europa.eu/949/shapes/TNvcontactApplicability</seealso>
    let ``shapes/TNvcontactApplicability`` =
        Prefixed_Name(era, "shapes/TNvcontactApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TNvovtrp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TNvovtrp">http://data.europa.eu/949/shapes/TNvovtrp</seealso>
    let ``shapes/TNvovtrp`` = Prefixed_Name(era, "shapes/TNvovtrp") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TNvovtrpApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TNvovtrpApplicability">http://data.europa.eu/949/shapes/TNvovtrpApplicability</seealso>
    let ``shapes/TNvovtrpApplicability`` =
        Prefixed_Name(era, "shapes/TNvovtrpApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TSISwitchCrossing</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TSISwitchCrossing">http://data.europa.eu/949/shapes/TSISwitchCrossing</seealso>
    let ``shapes/TSISwitchCrossing`` =
        Prefixed_Name(era, "shapes/TSISwitchCrossing") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TdsFrenchTrainDetectionSystemLimitation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TdsFrenchTrainDetectionSystemLimitation">http://data.europa.eu/949/shapes/TdsFrenchTrainDetectionSystemLimitation</seealso>
    let ``shapes/TdsFrenchTrainDetectionSystemLimitation`` =
        Prefixed_Name(era, "shapes/TdsFrenchTrainDetectionSystemLimitation") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TdsMaximumMagneticField</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TdsMaximumMagneticField">http://data.europa.eu/949/shapes/TdsMaximumMagneticField</seealso>
    let ``shapes/TdsMaximumMagneticField`` =
        Prefixed_Name(era, "shapes/TdsMaximumMagneticField") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TdsMaximumMagneticFieldApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TdsMaximumMagneticFieldApplicability">http://data.europa.eu/949/shapes/TdsMaximumMagneticFieldApplicability</seealso>
    let ``shapes/TdsMaximumMagneticFieldApplicability`` =
        Prefixed_Name(era, "shapes/TdsMaximumMagneticFieldApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TemperatureRange</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TemperatureRange">http://data.europa.eu/949/shapes/TemperatureRange</seealso>
    let ``shapes/TemperatureRange`` =
        Prefixed_Name(era, "shapes/TemperatureRange") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TemperatureRangeSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TemperatureRangeSKOS">http://data.europa.eu/949/shapes/TemperatureRangeSKOS</seealso>
    let ``shapes/TemperatureRangeSKOS`` =
        Prefixed_Name(era, "shapes/TemperatureRangeSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TemporalDurationShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TemporalDurationShape">http://data.europa.eu/949/shapes/TemporalDurationShape</seealso>
    let ``shapes/TemporalDurationShape`` =
        Prefixed_Name(era, "shapes/TemporalDurationShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TemporalEntityShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TemporalEntityShape">http://data.europa.eu/949/shapes/TemporalEntityShape</seealso>
    let ``shapes/TemporalEntityShape`` =
        Prefixed_Name(era, "shapes/TemporalEntityShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TenClassificationP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TenClassificationP">http://data.europa.eu/949/shapes/TenClassificationP</seealso>
    let ``shapes/TenClassificationP`` =
        Prefixed_Name(era, "shapes/TenClassificationP") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TenClassificationPreDeprecationWarning</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TenClassificationPreDeprecationWarning">http://data.europa.eu/949/shapes/TenClassificationPreDeprecationWarning</seealso>
    let ``shapes/TenClassificationPreDeprecationWarning`` =
        Prefixed_Name(era, "shapes/TenClassificationPreDeprecationWarning") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TenClassificationS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TenClassificationS">http://data.europa.eu/949/shapes/TenClassificationS</seealso>
    let ``shapes/TenClassificationS`` =
        Prefixed_Name(era, "shapes/TenClassificationS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TenClassificationSKOSP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TenClassificationSKOSP">http://data.europa.eu/949/shapes/TenClassificationSKOSP</seealso>
    let ``shapes/TenClassificationSKOSP`` =
        Prefixed_Name(era, "shapes/TenClassificationSKOSP") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TenClassificationSKOSS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TenClassificationSKOSS">http://data.europa.eu/949/shapes/TenClassificationSKOSS</seealso>
    let ``shapes/TenClassificationSKOSS`` =
        Prefixed_Name(era, "shapes/TenClassificationSKOSS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TenClassificationSKOST</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TenClassificationSKOST">http://data.europa.eu/949/shapes/TenClassificationSKOST</seealso>
    let ``shapes/TenClassificationSKOST`` =
        Prefixed_Name(era, "shapes/TenClassificationSKOST") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TenClassificationT</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TenClassificationT">http://data.europa.eu/949/shapes/TenClassificationT</seealso>
    let ``shapes/TenClassificationT`` =
        Prefixed_Name(era, "shapes/TenClassificationT") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TenGISId</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TenGISId">http://data.europa.eu/949/shapes/TenGISId</seealso>
    let ``shapes/TenGISId`` = Prefixed_Name(era, "shapes/TenGISId") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TenGISIdApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TenGISIdApplicability">http://data.europa.eu/949/shapes/TenGISIdApplicability</seealso>
    let ``shapes/TenGISIdApplicability`` =
        Prefixed_Name(era, "shapes/TenGISIdApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TentNetworkLevel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TentNetworkLevel">http://data.europa.eu/949/shapes/TentNetworkLevel</seealso>
    let ``shapes/TentNetworkLevel`` =
        Prefixed_Name(era, "shapes/TentNetworkLevel") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TentNetworkLevelSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TentNetworkLevelSKOS">http://data.europa.eu/949/shapes/TentNetworkLevelSKOS</seealso>
    let ``shapes/TentNetworkLevelSKOS`` =
        Prefixed_Name(era, "shapes/TentNetworkLevelSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TiltingSupported</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TiltingSupported">http://data.europa.eu/949/shapes/TiltingSupported</seealso>
    let ``shapes/TiltingSupported`` =
        Prefixed_Name(era, "shapes/TiltingSupported") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TopologicalCoordinateShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TopologicalCoordinateShape">http://data.europa.eu/949/shapes/TopologicalCoordinateShape</seealso>
    let ``shapes/TopologicalCoordinateShape`` =
        Prefixed_Name(era, "shapes/TopologicalCoordinateShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrackDirectionSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrackDirectionSKOS">http://data.europa.eu/949/shapes/TrackDirectionSKOS</seealso>
    let ``shapes/TrackDirectionSKOS`` =
        Prefixed_Name(era, "shapes/TrackDirectionSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrackId</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrackId">http://data.europa.eu/949/shapes/TrackId</seealso>
    let ``shapes/TrackId`` = Prefixed_Name(era, "shapes/TrackId") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrackLoadCapability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrackLoadCapability">http://data.europa.eu/949/shapes/TrackLoadCapability</seealso>
    let ``shapes/TrackLoadCapability`` =
        Prefixed_Name(era, "shapes/TrackLoadCapability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrackPhaseInfo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrackPhaseInfo">http://data.europa.eu/949/shapes/TrackPhaseInfo</seealso>
    let ``shapes/TrackPhaseInfo`` =
        Prefixed_Name(era, "shapes/TrackPhaseInfo") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrackPhaseInfoApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrackPhaseInfoApplicability">http://data.europa.eu/949/shapes/TrackPhaseInfoApplicability</seealso>
    let ``shapes/TrackPhaseInfoApplicability`` =
        Prefixed_Name(era, "shapes/TrackPhaseInfoApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrackRaisedPantographDistanceAndSpeedApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrackRaisedPantographDistanceAndSpeedApplicability">http://data.europa.eu/949/shapes/TrackRaisedPantographDistanceAndSpeedApplicability</seealso>
    let ``shapes/TrackRaisedPantographDistanceAndSpeedApplicability`` =
        Prefixed_Name(era, "shapes/TrackRaisedPantographDistanceAndSpeedApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrackRaisedPantographsDistanceAndSpeed</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrackRaisedPantographsDistanceAndSpeed">http://data.europa.eu/949/shapes/TrackRaisedPantographsDistanceAndSpeed</seealso>
    let ``shapes/TrackRaisedPantographsDistanceAndSpeed`` =
        Prefixed_Name(era, "shapes/TrackRaisedPantographsDistanceAndSpeed") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrackSystemSeparationInfo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrackSystemSeparationInfo">http://data.europa.eu/949/shapes/TrackSystemSeparationInfo</seealso>
    let ``shapes/TrackSystemSeparationInfo`` =
        Prefixed_Name(era, "shapes/TrackSystemSeparationInfo") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrackSystemSeparationInfoApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrackSystemSeparationInfoApplicability">http://data.europa.eu/949/shapes/TrackSystemSeparationInfoApplicability</seealso>
    let ``shapes/TrackSystemSeparationInfoApplicability`` =
        Prefixed_Name(era, "shapes/TrackSystemSeparationInfoApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrainDetectionSystem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrainDetectionSystem">http://data.europa.eu/949/shapes/TrainDetectionSystem</seealso>
    let ``shapes/TrainDetectionSystem`` =
        Prefixed_Name(era, "shapes/TrainDetectionSystem") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrainDetectionSystemShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrainDetectionSystemShape">http://data.europa.eu/949/shapes/TrainDetectionSystemShape</seealso>
    let ``shapes/TrainDetectionSystemShape`` =
        Prefixed_Name(era, "shapes/TrainDetectionSystemShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrainDetectionSystemSpecificCheck</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheck">http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheck</seealso>
    let ``shapes/TrainDetectionSystemSpecificCheck`` =
        Prefixed_Name(era, "shapes/TrainDetectionSystemSpecificCheck") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrainDetectionSystemSpecificCheckApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckApplicability">http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckApplicability</seealso>
    let ``shapes/TrainDetectionSystemSpecificCheckApplicability`` =
        Prefixed_Name(era, "shapes/TrainDetectionSystemSpecificCheckApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrainDetectionSystemSpecificCheckDocument</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckDocument">http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckDocument</seealso>
    let ``shapes/TrainDetectionSystemSpecificCheckDocument`` =
        Prefixed_Name(era, "shapes/TrainDetectionSystemSpecificCheckDocument") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrainDetectionSystemSpecificCheckDocumentApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckDocumentApplicability">http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckDocumentApplicability</seealso>
    let ``shapes/TrainDetectionSystemSpecificCheckDocumentApplicability`` =
        Prefixed_Name(era, "shapes/TrainDetectionSystemSpecificCheckDocumentApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrainDetectionSystemSpecificCheckSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckSKOS">http://data.europa.eu/949/shapes/TrainDetectionSystemSpecificCheckSKOS</seealso>
    let ``shapes/TrainDetectionSystemSpecificCheckSKOS`` =
        Prefixed_Name(era, "shapes/TrainDetectionSystemSpecificCheckSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrainDetectionSystemType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrainDetectionSystemType">http://data.europa.eu/949/shapes/TrainDetectionSystemType</seealso>
    let ``shapes/TrainDetectionSystemType`` =
        Prefixed_Name(era, "shapes/TrainDetectionSystemType") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrainDetectionSystemTypeSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrainDetectionSystemTypeSKOS">http://data.europa.eu/949/shapes/TrainDetectionSystemTypeSKOS</seealso>
    let ``shapes/TrainDetectionSystemTypeSKOS`` =
        Prefixed_Name(era, "shapes/TrainDetectionSystemTypeSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TrainIntegrityOnBoardRequired</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TrainIntegrityOnBoardRequired">http://data.europa.eu/949/shapes/TrainIntegrityOnBoardRequired</seealso>
    let ``shapes/TrainIntegrityOnBoardRequired`` =
        Prefixed_Name(era, "shapes/TrainIntegrityOnBoardRequired") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TsiMagneticFields</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TsiMagneticFields">http://data.europa.eu/949/shapes/TsiMagneticFields</seealso>
    let ``shapes/TsiMagneticFields`` =
        Prefixed_Name(era, "shapes/TsiMagneticFields") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TsiMagneticFieldsApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TsiMagneticFieldsApplicability">http://data.europa.eu/949/shapes/TsiMagneticFieldsApplicability</seealso>
    let ``shapes/TsiMagneticFieldsApplicability`` =
        Prefixed_Name(era, "shapes/TsiMagneticFieldsApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TsiPantographHeadApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TsiPantographHeadApplicability">http://data.europa.eu/949/shapes/TsiPantographHeadApplicability</seealso>
    let ``shapes/TsiPantographHeadApplicability`` =
        Prefixed_Name(era, "shapes/TsiPantographHeadApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TsiPantographHeadSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TsiPantographHeadSKOS">http://data.europa.eu/949/shapes/TsiPantographHeadSKOS</seealso>
    let ``shapes/TsiPantographHeadSKOS`` =
        Prefixed_Name(era, "shapes/TsiPantographHeadSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TsiTractionHarmonics</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TsiTractionHarmonics">http://data.europa.eu/949/shapes/TsiTractionHarmonics</seealso>
    let ``shapes/TsiTractionHarmonics`` =
        Prefixed_Name(era, "shapes/TsiTractionHarmonics") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TsiTractionHarmonicsApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TsiTractionHarmonicsApplicability">http://data.europa.eu/949/shapes/TsiTractionHarmonicsApplicability</seealso>
    let ``shapes/TsiTractionHarmonicsApplicability`` =
        Prefixed_Name(era, "shapes/TsiTractionHarmonicsApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TunnelDocRef</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TunnelDocRef">http://data.europa.eu/949/shapes/TunnelDocRef</seealso>
    let ``shapes/TunnelDocRef`` =
        Prefixed_Name(era, "shapes/TunnelDocRef") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TunnelIdentification</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TunnelIdentification">http://data.europa.eu/949/shapes/TunnelIdentification</seealso>
    let ``shapes/TunnelIdentification`` =
        Prefixed_Name(era, "shapes/TunnelIdentification") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TunnelShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TunnelShape">http://data.europa.eu/949/shapes/TunnelShape</seealso>
    let ``shapes/TunnelShape`` =
        Prefixed_Name(era, "shapes/TunnelShape") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TypeOfTraffic</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TypeOfTraffic">http://data.europa.eu/949/shapes/TypeOfTraffic</seealso>
    let ``shapes/TypeOfTraffic`` =
        Prefixed_Name(era, "shapes/TypeOfTraffic") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/TypeOfTrafficSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/TypeOfTrafficSKOS">http://data.europa.eu/949/shapes/TypeOfTrafficSKOS</seealso>
    let ``shapes/TypeOfTrafficSKOS`` =
        Prefixed_Name(era, "shapes/TypeOfTrafficSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/Umax2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/Umax2">http://data.europa.eu/949/shapes/Umax2</seealso>
    let ``shapes/Umax2`` = Prefixed_Name(era, "shapes/Umax2") |> PrefixedName
    /// <summary>
    ///   <para>era:shapes/UopidP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/UopidP">http://data.europa.eu/949/shapes/UopidP</seealso>
    let ``shapes/UopidP`` = Prefixed_Name(era, "shapes/UopidP") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/UsesGroup555</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/UsesGroup555">http://data.europa.eu/949/shapes/UsesGroup555</seealso>
    let ``shapes/UsesGroup555`` =
        Prefixed_Name(era, "shapes/UsesGroup555") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/UsesGroup555Applicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/UsesGroup555Applicability">http://data.europa.eu/949/shapes/UsesGroup555Applicability</seealso>
    let ``shapes/UsesGroup555Applicability`` =
        Prefixed_Name(era, "shapes/UsesGroup555Applicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/VNvallowovtrp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/VNvallowovtrp">http://data.europa.eu/949/shapes/VNvallowovtrp</seealso>
    let ``shapes/VNvallowovtrp`` =
        Prefixed_Name(era, "shapes/VNvallowovtrp") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/VNvallowovtrpApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/VNvallowovtrpApplicability">http://data.europa.eu/949/shapes/VNvallowovtrpApplicability</seealso>
    let ``shapes/VNvallowovtrpApplicability`` =
        Prefixed_Name(era, "shapes/VNvallowovtrpApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/VNvsupovtrp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/VNvsupovtrp">http://data.europa.eu/949/shapes/VNvsupovtrp</seealso>
    let ``shapes/VNvsupovtrp`` =
        Prefixed_Name(era, "shapes/VNvsupovtrp") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/VNvsupovtrpApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/VNvsupovtrpApplicability">http://data.europa.eu/949/shapes/VNvsupovtrpApplicability</seealso>
    let ``shapes/VNvsupovtrpApplicability`` =
        Prefixed_Name(era, "shapes/VNvsupovtrpApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/Validity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/Validity">http://data.europa.eu/949/shapes/Validity</seealso>
    let ``shapes/Validity`` = Prefixed_Name(era, "shapes/Validity") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/VerificationCCS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/VerificationCCS">http://data.europa.eu/949/shapes/VerificationCCS</seealso>
    let ``shapes/VerificationCCS`` =
        Prefixed_Name(era, "shapes/VerificationCCS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/VerificationENE</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/VerificationENE">http://data.europa.eu/949/shapes/VerificationENE</seealso>
    let ``shapes/VerificationENE`` =
        Prefixed_Name(era, "shapes/VerificationENE") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/VerificationINF</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/VerificationINF">http://data.europa.eu/949/shapes/VerificationINF</seealso>
    let ``shapes/VerificationINF`` =
        Prefixed_Name(era, "shapes/VerificationINF") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/VerificationINFS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/VerificationINFS">http://data.europa.eu/949/shapes/VerificationINFS</seealso>
    let ``shapes/VerificationINFS`` =
        Prefixed_Name(era, "shapes/VerificationINFS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/VerificationSRT</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/VerificationSRT">http://data.europa.eu/949/shapes/VerificationSRT</seealso>
    let ``shapes/VerificationSRT`` =
        Prefixed_Name(era, "shapes/VerificationSRT") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/VoiceRadioCompatible</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/VoiceRadioCompatible">http://data.europa.eu/949/shapes/VoiceRadioCompatible</seealso>
    let ``shapes/VoiceRadioCompatible`` =
        Prefixed_Name(era, "shapes/VoiceRadioCompatible") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/VoiceRadioCompatibleApplicability</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/VoiceRadioCompatibleApplicability">http://data.europa.eu/949/shapes/VoiceRadioCompatibleApplicability</seealso>
    let ``shapes/VoiceRadioCompatibleApplicability`` =
        Prefixed_Name(era, "shapes/VoiceRadioCompatibleApplicability") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/VoiceRadioCompatibleSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/VoiceRadioCompatibleSKOS">http://data.europa.eu/949/shapes/VoiceRadioCompatibleSKOS</seealso>
    let ``shapes/VoiceRadioCompatibleSKOS`` =
        Prefixed_Name(era, "shapes/VoiceRadioCompatibleSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/WheelSetGauge</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/WheelSetGauge">http://data.europa.eu/949/shapes/WheelSetGauge</seealso>
    let ``shapes/WheelSetGauge`` =
        Prefixed_Name(era, "shapes/WheelSetGauge") |> PrefixedName

    /// <summary>
    ///   <para>era:shapes/WheelSetGaugeSKOS</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/shapes/WheelSetGaugeSKOS">http://data.europa.eu/949/shapes/WheelSetGaugeSKOS</seealso>
    let ``shapes/WheelSetGaugeSKOS`` =
        Prefixed_Name(era, "shapes/WheelSetGaugeSKOS") |> PrefixedName

    /// <summary>
    ///   <para>era:shortestDistanceBetweenPantographsInContactWithOCL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Shortest distance between two pantographs in contact with the OCL (to be indicated for each energy supply system the vehicle is equipped for; to be indicated for single and, if applicable, multiple operation) (only if number of raised pantographs is more than 1)."</para>
    /// labels<para>"Shortest distance between pantographs in contact with OCL"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/shortestDistanceBetweenPantographsInContactWithOCL">http://data.europa.eu/949/shortestDistanceBetweenPantographsInContactWithOCL</seealso>
    let shortestDistanceBetweenPantographsInContactWithOCL =
        Prefixed_Name(era, "shortestDistanceBetweenPantographsInContactWithOCL") |> PrefixedName

    /// <summary>
    ///   <para>era:side</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication of the position of the signal in relation to the track in the running direction from the origin of the referencing system (e.g., direction of the main line)"</para>
    /// labels<para>"on side"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/side">http://data.europa.eu/949/side</seealso>
    let side = Prefixed_Name(era, "side") |> PrefixedName
    /// <summary>
    ///   <para>era:siding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Reference to a related siding."</para>
    /// labels<para>"Siding"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/siding">http://data.europa.eu/949/siding</seealso>
    let siding = Prefixed_Name(era, "siding") |> PrefixedName
    /// <summary>
    ///   <para>era:sidingDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Siding"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/sidingDataParameter">http://data.europa.eu/949/sidingDataParameter</seealso>
    let sidingDataParameter = Prefixed_Name(era, "sidingDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:sidingFixedInstalationsDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Fixed installations for servicing trains"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/sidingFixedInstalationsDataParameter">http://data.europa.eu/949/sidingFixedInstalationsDataParameter</seealso>
    let sidingFixedInstalationsDataParameter =
        Prefixed_Name(era, "sidingFixedInstalationsDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:sidingId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique siding identification or number within an Operational Point."</para>
    /// labels<para>"Identification of siding"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/sidingId">http://data.europa.eu/949/sidingId</seealso>
    let sidingId = Prefixed_Name(era, "sidingId") |> PrefixedName
    /// <summary>
    ///   <para>era:sidingObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Siding"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/sidingObjParameter">http://data.europa.eu/949/sidingObjParameter</seealso>
    let sidingObjParameter = Prefixed_Name(era, "sidingObjParameter") |> PrefixedName
    /// <summary>
    ///   <para>era:signalDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Signal"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/signalDataParameter">http://data.europa.eu/949/signalDataParameter</seealso>
    let signalDataParameter = Prefixed_Name(era, "signalDataParameter") |> PrefixedName
    /// <summary>
    ///   <para>era:signalId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Identifier of signal."</para>
    /// labels<para>"Name of signal"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/signalId">http://data.europa.eu/949/signalId</seealso>
    let signalId = Prefixed_Name(era, "signalId") |> PrefixedName
    /// <summary>
    ///   <para>era:signalObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Signal"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/signalObjParameter">http://data.europa.eu/949/signalObjParameter</seealso>
    let signalObjParameter = Prefixed_Name(era, "signalObjParameter") |> PrefixedName
    /// <summary>
    ///   <para>era:signalOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Relative position to the line of reference, given in km and indication if the signal refers to normal or opposite track direction"</para>
    /// labels<para>"Signal orientation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/signalOrientation">http://data.europa.eu/949/signalOrientation</seealso>
    let signalOrientation = Prefixed_Name(era, "signalOrientation") |> PrefixedName
    /// <summary>
    ///   <para>era:signalType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Signalling information for Route Book compilation. This list shall include fixed signals that protect danger points"</para>
    /// labels<para>"Type of signal"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/signalType">http://data.europa.eu/949/signalType</seealso>
    let signalType = Prefixed_Name(era, "signalType") |> PrefixedName
    /// <summary>
    ///   <para>era:sleepingPlaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of sleeping places."</para>
    /// labels<para>"Sleeping places"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/sleepingPlaces">http://data.europa.eu/949/sleepingPlaces</seealso>
    let sleepingPlaces = Prefixed_Name(era, "sleepingPlaces") |> PrefixedName

    /// <summary>
    ///   <para>era:snowIceHailConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Snow, ice and hail conditions."</para>
    /// labels<para>"Snow ice hail conditions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/snowIceHailConditions">http://data.europa.eu/949/snowIceHailConditions</seealso>
    let snowIceHailConditions =
        Prefixed_Name(era, "snowIceHailConditions") |> PrefixedName

    /// <summary>
    ///   <para>era:solGenericDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Section of line generic information"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/solGenericDataParameter">http://data.europa.eu/949/solGenericDataParameter</seealso>
    let solGenericDataParameter =
        Prefixed_Name(era, "solGenericDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:solGenericObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Section of line generic information"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/solGenericObjParameter">http://data.europa.eu/949/solGenericObjParameter</seealso>
    let solGenericObjParameter =
        Prefixed_Name(era, "solGenericObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:solNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Kind of section of line expressing size of presented data which depends on fact whether it connects OPs generated by division of a big node into several OPs or not."</para>
    /// labels<para>"Nature of Section of Line"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/solNature">http://data.europa.eu/949/solNature</seealso>
    let solNature = Prefixed_Name(era, "solNature") |> PrefixedName
    /// <summary>
    ///   <para>era:specialAreaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the special area or location types such as safe areas and restricted area types."</para>
    /// labels<para>"Special area type"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/specialAreaType">http://data.europa.eu/949/specialAreaType</seealso>
    let specialAreaType = Prefixed_Name(era, "specialAreaType") |> PrefixedName
    /// <summary>
    ///   <para>era:specialTunnelArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a tunnel with a special area or location."</para>
    /// labels<para>"Special tunnel area"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/specialTunnelArea">http://data.europa.eu/949/specialTunnelArea</seealso>
    let specialTunnelArea = Prefixed_Name(era, "specialTunnelArea") |> PrefixedName

    /// <summary>
    ///   <para>era:specializedInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Special type of service on a line or a section of a line."</para>
    /// labels<para>"Specialized infrastructure"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/specializedInfrastructure">http://data.europa.eu/949/specializedInfrastructure</seealso>
    let specializedInfrastructure =
        Prefixed_Name(era, "specializedInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>era:specificInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Any relevant information from the IM relating to the line layout"</para>
    /// labels<para>"Specific information"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/specificInformation">http://data.europa.eu/949/specificInformation</seealso>
    let specificInformation = Prefixed_Name(era, "specificInformation") |> PrefixedName
    /// <summary>
    ///   <para>era:stable</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/949/stable">http://data.europa.eu/949/stable</seealso>
    let stable = Prefixed_Name(era, "stable") |> PrefixedName

    /// <summary>
    ///   <para>era:standardCombinedTransportContainers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Coding for combined transport for containers (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B]"</para>
    /// labels<para>"Standard combined transport profile number for containers"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/standardCombinedTransportContainers">http://data.europa.eu/949/standardCombinedTransportContainers</seealso>
    let standardCombinedTransportContainers =
        Prefixed_Name(era, "standardCombinedTransportContainers") |> PrefixedName

    /// <summary>
    ///   <para>era:standardCombinedTransportRollerUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Coding for combined transport for roller units (for all freight and mixed-traffic lines) in accordance with the specification referenced in Appendix A-1, index [B]"</para>
    /// labels<para>"Standard combined transport profile number for roller units"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/standardCombinedTransportRollerUnits">http://data.europa.eu/949/standardCombinedTransportRollerUnits</seealso>
    let standardCombinedTransportRollerUnits =
        Prefixed_Name(era, "standardCombinedTransportRollerUnits") |> PrefixedName

    /// <summary>
    ///   <para>era:startIntrinsicCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Start intrinsic coordinate"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/startIntrinsicCoordinate">http://data.europa.eu/949/startIntrinsicCoordinate</seealso>
    let startIntrinsicCoordinate =
        Prefixed_Name(era, "startIntrinsicCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>era:startLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Part of the Start of tunnel that indicates the Geographical coordinates according to the standard World Geodetic System (WGS). Precision for both geographical latitude and geographical longitude is assumed as [NN.NNNNNNN] in degrees with decimals what gives discretion of 10 cm in the network.
    /// The Start of tunnel is the Geographical coordinates in decimal degrees and km of the line at the beginning of a tunnel."</para>
    /// labels<para>"Start of tunnel location"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/startLocation">http://data.europa.eu/949/startLocation</seealso>
    let startLocation = Prefixed_Name(era, "startLocation") |> PrefixedName

    /// <summary>
    ///   <para>era:startOffsetFromOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Start offset of the section from the origin."</para>
    /// labels<para>"start offset from origin"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/startOffsetFromOrigin">http://data.europa.eu/949/startOffsetFromOrigin</seealso>
    let startOffsetFromOrigin =
        Prefixed_Name(era, "startOffsetFromOrigin") |> PrefixedName

    /// <summary>
    ///   <para>era:startingNoiseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"starting noise level given in dB(A)."</para>
    /// labels<para>"Starting noise level"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/startingNoiseLevel">http://data.europa.eu/949/startingNoiseLevel</seealso>
    let startingNoiseLevel = Prefixed_Name(era, "startingNoiseLevel") |> PrefixedName
    /// <summary>
    ///   <para>era:startsAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the starting point of a linear reference."</para>
    /// labels<para>"starts at"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/startsAt">http://data.europa.eu/949/startsAt</seealso>
    let startsAt = Prefixed_Name(era, "startsAt") |> PrefixedName
    /// <summary>
    ///   <para>era:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denoting the state of the certificate Can be in one of the following: Amended, New, Suspended, Withdrawn."</para>
    /// labels<para>"State"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/state">http://data.europa.eu/949/state</seealso>
    let state = Prefixed_Name(era, "state") |> PrefixedName

    /// <summary>
    ///   <para>era:staticAxleLoadExceptionalPayload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Static axle load under exceptional payload."</para>
    /// labels<para>"Static axle load under exceptional payload"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/staticAxleLoadExceptionalPayload">http://data.europa.eu/949/staticAxleLoadExceptionalPayload</seealso>
    let staticAxleLoadExceptionalPayload =
        Prefixed_Name(era, "staticAxleLoadExceptionalPayload") |> PrefixedName

    /// <summary>
    ///   <para>era:staticAxleLoadNormalPayload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Static axle load under normal payload."</para>
    /// labels<para>"Static axle load under normal payload"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/staticAxleLoadNormalPayload">http://data.europa.eu/949/staticAxleLoadNormalPayload</seealso>
    let staticAxleLoadNormalPayload =
        Prefixed_Name(era, "staticAxleLoadNormalPayload") |> PrefixedName

    /// <summary>
    ///   <para>era:staticAxleLoadWorkingOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Static axle load in working order."</para>
    /// labels<para>"Static axle load in working order"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/staticAxleLoadWorkingOrder">http://data.europa.eu/949/staticAxleLoadWorkingOrder</seealso>
    let staticAxleLoadWorkingOrder =
        Prefixed_Name(era, "staticAxleLoadWorkingOrder") |> PrefixedName

    /// <summary>
    ///   <para>era:stationaryNoiseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"stationary noise level given in dB(A)."</para>
    /// labels<para>"Stationary noise level"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/stationaryNoiseLevel">http://data.europa.eu/949/stationaryNoiseLevel</seealso>
    let stationaryNoiseLevel =
        Prefixed_Name(era, "stationaryNoiseLevel") |> PrefixedName

    /// <summary>
    ///   <para>era:structuralCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Structural category."</para>
    /// labels<para>"Structural category"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/structuralCategory">http://data.europa.eu/949/structuralCategory</seealso>
    let structuralCategory = Prefixed_Name(era, "structuralCategory") |> PrefixedName

    /// <summary>
    ///   <para>era:structureCheckLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Localisation of structures requiring specific checks"</para>
    /// labels<para>"Railway location of structures requiring specific checks"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/structureCheckLocation">http://data.europa.eu/949/structureCheckLocation</seealso>
    let structureCheckLocation =
        Prefixed_Name(era, "structureCheckLocation") |> PrefixedName

    /// <summary>
    ///   <para>era:subCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"(Deprecated) Vehicle subcategory."</para>
    /// </remarks>
    /// <seealso href="http://data.europa.eu/949/subCategory">http://data.europa.eu/949/subCategory</seealso>
    let subCategory = Prefixed_Name(era, "subCategory") |> PrefixedName
    /// <summary>
    ///   <para>era:subsetName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A subset of elements with common characteristics could be identified with a unique name/id."</para>
    /// labels<para>"Name of a subset with common characteristics"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/subsetName">http://data.europa.eu/949/subsetName</seealso>
    let subsetName = Prefixed_Name(era, "subsetName") |> PrefixedName
    /// <summary>
    ///   <para>era:subsetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Relates a subset with common characteristics with another subset with common characteristics."</para>
    /// labels<para>"subset of"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/subsetOf">http://data.europa.eu/949/subsetOf</seealso>
    let subsetOf = Prefixed_Name(era, "subsetOf") |> PrefixedName

    /// <summary>
    ///   <para>era:subsidiaryLocationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The numeric code for the subsidiary location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subsidiary location code"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/subsidiaryLocationCode">http://data.europa.eu/949/subsidiaryLocationCode</seealso>
    let subsidiaryLocationCode =
        Prefixed_Name(era, "subsidiaryLocationCode") |> PrefixedName

    /// <summary>
    ///   <para>era:subsidiaryLocationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The common name given to the subsidiary location"</para>
    /// labels<para>"subsidiary location name"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/subsidiaryLocationName">http://data.europa.eu/949/subsidiaryLocationName</seealso>
    let subsidiaryLocationName =
        Prefixed_Name(era, "subsidiaryLocationName") |> PrefixedName

    /// <summary>
    ///   <para>era:subsidiaryLocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the subsidiary location type that belongs to a taxonomy."</para>
    /// labels<para>"subsidiary location type"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/subsidiaryLocationType">http://data.europa.eu/949/subsidiaryLocationType</seealso>
    let subsidiaryLocationType =
        Prefixed_Name(era, "subsidiaryLocationType") |> PrefixedName

    /// <summary>
    ///   <para>era:supportedPlatformHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Platform height for which the vehicle is designed."</para>
    /// labels<para>"Supported platform height"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/supportedPlatformHeight">http://data.europa.eu/949/supportedPlatformHeight</seealso>
    let supportedPlatformHeight =
        Prefixed_Name(era, "supportedPlatformHeight") |> PrefixedName

    /// <summary>
    ///   <para>era:switchProtectControlWarning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication whether a switch over between different systems whilst running exists."</para>
    /// labels<para>"Existence of switch over between different protection, control and warning systems while running"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/switchProtectControlWarning">http://data.europa.eu/949/switchProtectControlWarning</seealso>
    let switchProtectControlWarning =
        Prefixed_Name(era, "switchProtectControlWarning") |> PrefixedName

    /// <summary>
    ///   <para>era:switchRadioSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indication whether a switch over between different radio systems and no communication system whilst running exists."</para>
    /// labels<para>"Existence of switch over between different radio systems"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/switchRadioSystem">http://data.europa.eu/949/switchRadioSystem</seealso>
    let switchRadioSystem = Prefixed_Name(era, "switchRadioSystem") |> PrefixedName

    /// <summary>
    ///   <para>era:switchesAndCrossingsDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Switches and crossings"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/switchesAndCrossingsDataParameter">http://data.europa.eu/949/switchesAndCrossingsDataParameter</seealso>
    let switchesAndCrossingsDataParameter =
        Prefixed_Name(era, "switchesAndCrossingsDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:systemSeparationInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"(deprecated) Indication of required several information on system separation.
    /// Deprecated because of replacement by four properties. The reason is that the property is composed of four values: length [NNN], the length of the system separation in metres; switch off breaker [Y/N]. Single selection of 'Y=yes' or 'N=no' to show whether the breaker has to be switched off;  lower pantograph [Y/N]. Single selection of 'Y=yes' or 'N=no' to show whether the pantograph has to be lowered, and [CharacterString]  to show whether the supply system has to be changed."</para>
    /// labels<para>"(deprecated) Information on system separation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/systemSeparationInfo">http://data.europa.eu/949/systemSeparationInfo</seealso>
    let systemSeparationInfo =
        Prefixed_Name(era, "systemSeparationInfo") |> PrefixedName

    /// <summary>
    ///   <para>era:systemSeparationInfoChangeSupplySystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the system separation info of a track that shows whether the supply system has to be changed.
    /// The system separation info is the Indication of required several information on system separation."</para>
    /// labels<para>"System separation info change supply system"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/systemSeparationInfoChangeSupplySystem">http://data.europa.eu/949/systemSeparationInfoChangeSupplySystem</seealso>
    let systemSeparationInfoChangeSupplySystem =
        Prefixed_Name(era, "systemSeparationInfoChangeSupplySystem") |> PrefixedName

    /// <summary>
    ///   <para>era:systemSeparationInfoKm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the system separation info of a track. Indicates the location from the start of the line where the new value is valid.
    /// The system separation info is the Indication of required several information on system separation."</para>
    /// labels<para>"System separation info Km"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/systemSeparationInfoKm">http://data.europa.eu/949/systemSeparationInfoKm</seealso>
    let systemSeparationInfoKm =
        Prefixed_Name(era, "systemSeparationInfoKm") |> PrefixedName

    /// <summary>
    ///   <para>era:systemSeparationInfoLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the system separation info of a track that shows the length of the system separation in metres.
    /// The system separation info is the Indication of required several information on system separation."</para>
    /// labels<para>"System separation info length"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/systemSeparationInfoLength">http://data.europa.eu/949/systemSeparationInfoLength</seealso>
    let systemSeparationInfoLength =
        Prefixed_Name(era, "systemSeparationInfoLength") |> PrefixedName

    /// <summary>
    ///   <para>era:systemSeparationInfoPantographLowered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the system separation info of a track that shows whether the pantograph has to be lowered.
    /// The system separation info is the Indication of required several information on system separation."</para>
    /// labels<para>"System separation info  pantograph lowered"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/systemSeparationInfoPantographLowered">http://data.europa.eu/949/systemSeparationInfoPantographLowered</seealso>
    let systemSeparationInfoPantographLowered =
        Prefixed_Name(era, "systemSeparationInfoPantographLowered") |> PrefixedName

    /// <summary>
    ///   <para>era:systemSeparationInfoSwitchOffBreaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Part of the system separation info of a track that shows whether the breaker has to be switched off.
    /// The system separation info is the Indication of required several information on system separation."</para>
    /// labels<para>"System separation info switch off breaker"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/systemSeparationInfoSwitchOffBreaker">http://data.europa.eu/949/systemSeparationInfoSwitchOffBreaker</seealso>
    let systemSeparationInfoSwitchOffBreaker =
        Prefixed_Name(era, "systemSeparationInfoSwitchOffBreaker") |> PrefixedName

    /// <summary>
    ///   <para>era:tNvcontact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Maximum time without a safe message from Radio Block Center before train reacts in seconds.
    /// According to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"T_NVCONTACT"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tNvcontact">http://data.europa.eu/949/tNvcontact</seealso>
    let tNvcontact = Prefixed_Name(era, "tNvcontact") |> PrefixedName
    /// <summary>
    ///   <para>era:tNvovtrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Maximum time for overriding the train trip in seconds.
    /// According to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"T_NVOVTRP"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tNvovtrp">http://data.europa.eu/949/tNvovtrp</seealso>
    let tNvovtrp = Prefixed_Name(era, "tNvovtrp") |> PrefixedName
    /// <summary>
    ///   <para>era:tafTAPCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Primary location code developed for information exchange in accordance with the TSIs relating to the telematics applications subsystem"</para>
    ///   <para>"Not used anymore. It has been replaced by era:primaryLocationCode."</para>
    /// labels<para>"OP primary location code"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tafTAPCode">http://data.europa.eu/949/tafTAPCode</seealso>
    let tafTAPCode = Prefixed_Name(era, "tafTAPCode") |> PrefixedName

    /// <summary>
    ///   <para>era:tdsFrenchTrainDetectionSystemLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Specific for route compatibility check on French network."</para>
    /// labels<para>"Section with train detection limitation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tdsFrenchTrainDetectionSystemLimitation">http://data.europa.eu/949/tdsFrenchTrainDetectionSystemLimitation</seealso>
    let tdsFrenchTrainDetectionSystemLimitation =
        Prefixed_Name(era, "tdsFrenchTrainDetectionSystemLimitation") |> PrefixedName

    /// <summary>
    ///   <para>era:tdsMaximumMagneticField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The maximum magnetic field limits allowed for axle counters (in dB µA/m) for a defined frequency band.
    /// It should be provided in 3 directions."</para>
    /// labels<para>"Maximum magnetic field"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tdsMaximumMagneticField">http://data.europa.eu/949/tdsMaximumMagneticField</seealso>
    let tdsMaximumMagneticField =
        Prefixed_Name(era, "tdsMaximumMagneticField") |> PrefixedName

    /// <summary>
    ///   <para>era:tdsMinAxleLoadVehicleCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication of load given in tons depending of the category of vehicle. Deprecated according to the amendment to the Regulation (EU) 2019/777."</para>
    /// labels<para>"Train detection system min axle load vehicle category"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tdsMinAxleLoadVehicleCategory">http://data.europa.eu/949/tdsMinAxleLoadVehicleCategory</seealso>
    let tdsMinAxleLoadVehicleCategory =
        Prefixed_Name(era, "tdsMinAxleLoadVehicleCategory") |> PrefixedName

    /// <summary>
    ///   <para>era:temperatureRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Temperature range for unrestricted access to the line."</para>
    /// labels<para>"Temperature range"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/temperatureRange">http://data.europa.eu/949/temperatureRange</seealso>
    let temperatureRange = Prefixed_Name(era, "temperatureRange") |> PrefixedName
    /// <summary>
    ///   <para>era:tenClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication of the part of the trans-European network the infrastructure element belongs to."</para>
    /// labels<para>"TEN classification of track"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tenClassification">http://data.europa.eu/949/tenClassification</seealso>
    let tenClassification = Prefixed_Name(era, "tenClassification") |> PrefixedName
    /// <summary>
    ///   <para>era:tenGISId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of the GIS identity (GIS ID) of the section of TEN-T database to which the track belongs"</para>
    /// labels<para>"TEN geographic information system identity (GIS ID)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tenGISId">http://data.europa.eu/949/tenGISId</seealso>
    let tenGISId = Prefixed_Name(era, "tenGISId") |> PrefixedName
    /// <summary>
    ///   <para>era:tentNetworkLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Classification of the element according to its level in the Trans-European Transport Network (TEN-T)."</para>
    /// labels<para>"TEN-T network level"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tentNetworkLevel">http://data.europa.eu/949/tentNetworkLevel</seealso>
    let tentNetworkLevel = Prefixed_Name(era, "tentNetworkLevel") |> PrefixedName
    /// <summary>
    ///   <para>era:tentReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Used to annotate properties coming from the TenT regulations, to be used for monitoring the provision of the data."</para>
    /// labels<para>"TenT reference"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tentReference">http://data.europa.eu/949/tentReference</seealso>
    let tentReference = Prefixed_Name(era, "tentReference") |> PrefixedName

    /// <summary>
    ///   <para>era:thermalCapacityDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Thermal capacity distance. If no reference case is indicated."</para>
    /// labels<para>"Thermal capacity distance"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/thermalCapacityDistance">http://data.europa.eu/949/thermalCapacityDistance</seealso>
    let thermalCapacityDistance =
        Prefixed_Name(era, "thermalCapacityDistance") |> PrefixedName

    /// <summary>
    ///   <para>era:thermalCapacityGradient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Thermal capacity gradient. If no reference case is indicated."</para>
    /// labels<para>"Thermal capacity gradient"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/thermalCapacityGradient">http://data.europa.eu/949/thermalCapacityGradient</seealso>
    let thermalCapacityGradient =
        Prefixed_Name(era, "thermalCapacityGradient") |> PrefixedName

    /// <summary>
    ///   <para>era:thermalCapacitySpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Thermal capacity speed. If no reference case is indicated."</para>
    /// labels<para>"Thermal capacity speed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/thermalCapacitySpeed">http://data.europa.eu/949/thermalCapacitySpeed</seealso>
    let thermalCapacitySpeed =
        Prefixed_Name(era, "thermalCapacitySpeed") |> PrefixedName

    /// <summary>
    ///   <para>era:thermalCapacityTSIReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Reference case of a TSI thermal capacity."</para>
    /// labels<para>"Thermal capacity TSI reference"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/thermalCapacityTSIReference">http://data.europa.eu/949/thermalCapacityTSIReference</seealso>
    let thermalCapacityTSIReference =
        Prefixed_Name(era, "thermalCapacityTSIReference") |> PrefixedName

    /// <summary>
    ///   <para>era:thermalCapacityTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Thermal capacity time. If no reference case is indicated."</para>
    /// labels<para>"Thermal capacity time"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/thermalCapacityTime">http://data.europa.eu/949/thermalCapacityTime</seealso>
    let thermalCapacityTime = Prefixed_Name(era, "thermalCapacityTime") |> PrefixedName
    /// <summary>
    ///   <para>era:tiltingSupported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. Indication whether tilting functions are supported by ETCS."</para>
    /// labels<para>"Indication whether tilting functions are supported by ETCS"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tiltingSupported">http://data.europa.eu/949/tiltingSupported</seealso>
    let tiltingSupported = Prefixed_Name(era, "tiltingSupported") |> PrefixedName
    /// <summary>
    ///   <para>era:totalVehicleMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Total vehicle mass (for each vehicle of the unit), given in kg."</para>
    /// labels<para>"Total vehicle mass"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/totalVehicleMass">http://data.europa.eu/949/totalVehicleMass</seealso>
    let totalVehicleMass = Prefixed_Name(era, "totalVehicleMass") |> PrefixedName
    /// <summary>
    ///   <para>era:track</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Reference to a related railway track."</para>
    /// labels<para>"Track"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/track">http://data.europa.eu/949/track</seealso>
    let track = Prefixed_Name(era, "track") |> PrefixedName
    /// <summary>
    ///   <para>era:trackDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Track parameters"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trackDataParameter">http://data.europa.eu/949/trackDataParameter</seealso>
    let trackDataParameter = Prefixed_Name(era, "trackDataParameter") |> PrefixedName
    /// <summary>
    ///   <para>era:trackDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The normal running direction is:
    /// - the same as the direction defined by the start and end of the SoL: (N)
    /// - the opposite to the direction defined by the start and end of the SoL: (O)
    /// - both directions: (B)"</para>
    /// labels<para>"Normal running direction"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trackDirection">http://data.europa.eu/949/trackDirection</seealso>
    let trackDirection = Prefixed_Name(era, "trackDirection") |> PrefixedName

    /// <summary>
    ///   <para>era:trackGenericDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Running track generic information"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trackGenericDataParameter">http://data.europa.eu/949/trackGenericDataParameter</seealso>
    let trackGenericDataParameter =
        Prefixed_Name(era, "trackGenericDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:trackGenericObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Running track generic information"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trackGenericObjParameter">http://data.europa.eu/949/trackGenericObjParameter</seealso>
    let trackGenericObjParameter =
        Prefixed_Name(era, "trackGenericObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:trackId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique track identification or unique track number within operational point or section of line"</para>
    /// labels<para>"Identification of track"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trackId">http://data.europa.eu/949/trackId</seealso>
    let trackId = Prefixed_Name(era, "trackId") |> PrefixedName
    /// <summary>
    ///   <para>era:trackLoadCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Relates the track with the class LoadCapability. A combination of the line category and speed at the weakest point of the track."</para>
    /// labels<para>"Load capability"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trackLoadCapability">http://data.europa.eu/949/trackLoadCapability</seealso>
    let trackLoadCapability = Prefixed_Name(era, "trackLoadCapability") |> PrefixedName
    /// <summary>
    ///   <para>era:trackObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Track parameters"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trackObjParameter">http://data.europa.eu/949/trackObjParameter</seealso>
    let trackObjParameter = Prefixed_Name(era, "trackObjParameter") |> PrefixedName
    /// <summary>
    ///   <para>era:trackPhaseInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates the Track with PhaseInfo. Indication of required several information on phase separation."</para>
    /// labels<para>"Information on phase separation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trackPhaseInfo">http://data.europa.eu/949/trackPhaseInfo</seealso>
    let trackPhaseInfo = Prefixed_Name(era, "trackPhaseInfo") |> PrefixedName

    /// <summary>
    ///   <para>era:trackRaisedPantographsDistanceAndSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication of maximum number of raised pantographs per train allowed and minimum spacing centre line to centre line of adjacent pantograph heads, expressed in metres, at the given speed."</para>
    /// labels<para>"Requirements for number of raised pantographs and spacing between them, at the given speed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trackRaisedPantographsDistanceAndSpeed">http://data.europa.eu/949/trackRaisedPantographsDistanceAndSpeed</seealso>
    let trackRaisedPantographsDistanceAndSpeed =
        Prefixed_Name(era, "trackRaisedPantographsDistanceAndSpeed") |> PrefixedName

    /// <summary>
    ///   <para>era:trackResistanceToAppliedLoadsDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Track resistance to applied loads"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trackResistanceToAppliedLoadsDataParameter">http://data.europa.eu/949/trackResistanceToAppliedLoadsDataParameter</seealso>
    let trackResistanceToAppliedLoadsDataParameter =
        Prefixed_Name(era, "trackResistanceToAppliedLoadsDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:trackResistanceToAppliedLoadsObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Track resistance to applied loads"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trackResistanceToAppliedLoadsObjParameter">http://data.europa.eu/949/trackResistanceToAppliedLoadsObjParameter</seealso>
    let trackResistanceToAppliedLoadsObjParameter =
        Prefixed_Name(era, "trackResistanceToAppliedLoadsObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:trackSystemSeparationInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication of required several information on system separation"</para>
    /// labels<para>"Information on system separation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trackSystemSeparationInfo">http://data.europa.eu/949/trackSystemSeparationInfo</seealso>
    let trackSystemSeparationInfo =
        Prefixed_Name(era, "trackSystemSeparationInfo") |> PrefixedName

    /// <summary>
    ///   <para>era:tracksideHabd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between the running track and the HABD, covering the RINF parameters 1.1.1.1.7.(5-9)"</para>
    /// labels<para>"hot axle box detector (HABD)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tracksideHabd">http://data.europa.eu/949/tracksideHabd</seealso>
    let tracksideHabd = Prefixed_Name(era, "tracksideHabd") |> PrefixedName

    /// <summary>
    ///   <para>era:trainControlSwitchOverSpecialConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Special conditions implemented on-board to switch over between different train protection control and warning systems. Given as combination of systems installed on board ('System XX'_'System YY')."</para>
    /// labels<para>"Train control switch over special conditions"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trainControlSwitchOverSpecialConditions">http://data.europa.eu/949/trainControlSwitchOverSpecialConditions</seealso>
    let trainControlSwitchOverSpecialConditions =
        Prefixed_Name(era, "trainControlSwitchOverSpecialConditions") |> PrefixedName

    /// <summary>
    ///   <para>era:trainDetectionSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Technical characteristics of the train detection systems installed in the section of line."</para>
    /// labels<para>"train detection system"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trainDetectionSystem">http://data.europa.eu/949/trainDetectionSystem</seealso>
    let trainDetectionSystem =
        Prefixed_Name(era, "trainDetectionSystem") |> PrefixedName

    /// <summary>
    ///   <para>era:trainDetectionSystemBasedFrequencyBandsDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Train detection systems defined based on frequency bands"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trainDetectionSystemBasedFrequencyBandsDataParameter">http://data.europa.eu/949/trainDetectionSystemBasedFrequencyBandsDataParameter</seealso>
    let trainDetectionSystemBasedFrequencyBandsDataParameter =
        Prefixed_Name(era, "trainDetectionSystemBasedFrequencyBandsDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:trainDetectionSystemBasedFrequencyBandsObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Train detection systems defined based on frequency bands"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trainDetectionSystemBasedFrequencyBandsObjParameter">http://data.europa.eu/949/trainDetectionSystemBasedFrequencyBandsObjParameter</seealso>
    let trainDetectionSystemBasedFrequencyBandsObjParameter =
        Prefixed_Name(era, "trainDetectionSystemBasedFrequencyBandsObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:trainDetectionSystemSpecificCheck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Reference to the technical specification of train detection system, in accordance with the specification referenced in Appendix A-1, index [D]"</para>
    /// labels<para>"Type of track circuits or axle counters to which specific checks are needed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trainDetectionSystemSpecificCheck">http://data.europa.eu/949/trainDetectionSystemSpecificCheck</seealso>
    let trainDetectionSystemSpecificCheck =
        Prefixed_Name(era, "trainDetectionSystemSpecificCheck") |> PrefixedName

    /// <summary>
    ///   <para>era:trainDetectionSystemSpecificCheckDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Electronic document from the IM stored by the Agency with precise values in accordance with TSI CCS Article13 and the specification referenced in Appendix A-1, index [D], for the specific check to be performed for train detection systems identified in parameter "Type of track circuits or axle counters to which specific checks are needed"."</para>
    /// labels<para>"Document with the procedure(s) related to the type of train detection systems declared in "Type of track circuits or axle counters to which specific checks are needed""</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trainDetectionSystemSpecificCheckDocument">http://data.europa.eu/949/trainDetectionSystemSpecificCheckDocument</seealso>
    let trainDetectionSystemSpecificCheckDocument =
        Prefixed_Name(era, "trainDetectionSystemSpecificCheckDocument") |> PrefixedName

    /// <summary>
    ///   <para>era:trainDetectionSystemType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication of types of train detection systems installed."</para>
    /// labels<para>"Type of train detection system"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trainDetectionSystemType">http://data.europa.eu/949/trainDetectionSystemType</seealso>
    let trainDetectionSystemType =
        Prefixed_Name(era, "trainDetectionSystemType") |> PrefixedName

    /// <summary>
    ///   <para>era:trainIntegrityOnBoardRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication whether train confirmation from on-board is required to access the line for safety reasons."</para>
    /// labels<para>"Train integrity confirmation from on-board (not from driver) necessary for line access"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trainIntegrityOnBoardRequired">http://data.europa.eu/949/trainIntegrityOnBoardRequired</seealso>
    let trainIntegrityOnBoardRequired =
        Prefixed_Name(era, "trainIntegrityOnBoardRequired") |> PrefixedName

    /// <summary>
    ///   <para>era:trainProtectionLegacySystemObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Train protection legacy systems"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/trainProtectionLegacySystemObjParameter">http://data.europa.eu/949/trainProtectionLegacySystemObjParameter</seealso>
    let trainProtectionLegacySystemObjParameter =
        Prefixed_Name(era, "trainProtectionLegacySystemObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:transitionsBetweenSystemsDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Transitions between systems"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/transitionsBetweenSystemsDataParameter">http://data.europa.eu/949/transitionsBetweenSystemsDataParameter</seealso>
    let transitionsBetweenSystemsDataParameter =
        Prefixed_Name(era, "transitionsBetweenSystemsDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:transitionsBetweenSystemsObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Transitions between systems"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/transitionsBetweenSystemsObjParameter">http://data.europa.eu/949/transitionsBetweenSystemsObjParameter</seealso>
    let transitionsBetweenSystemsObjParameter =
        Prefixed_Name(era, "transitionsBetweenSystemsObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:transportableOnFerry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the suitability for transport on ferries."</para>
    /// labels<para>"Transportable on ferry"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/transportableOnFerry">http://data.europa.eu/949/transportableOnFerry</seealso>
    let transportableOnFerry =
        Prefixed_Name(era, "transportableOnFerry") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates if a certain property is TSI compliant.The reason for deprecation is that it is used in SKOS "OtherPantographHeads" and "TsiPantographHeads" to indicate in the first case if a SKOS concept is not tsiCompliant (false) and in the second case that the concept is tsiCompliant (true). These two SKOS were originally one SKOS, "PantographHeads". Currently with the two SKOS the property is redundant."</para>
    /// labels<para>"Tsi compliant"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliant">http://data.europa.eu/949/tsiCompliant</seealso>
    let tsiCompliant = Prefixed_Name(era, "tsiCompliant") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantCompositeBrakeBlocks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. TSI compliance of rules on the use of composite brake blocks."</para>
    /// labels<para>"TSI compliance of rules on the use of composite brake blocks"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantCompositeBrakeBlocks">http://data.europa.eu/949/tsiCompliantCompositeBrakeBlocks</seealso>
    let tsiCompliantCompositeBrakeBlocks =
        Prefixed_Name(era, "tsiCompliantCompositeBrakeBlocks") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantFerromagneticWheel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"TSI compliance of Ferromagnetic characteristics of wheel material required. Deprecated according to the amendment to the Regulation (EU) 2019/777."</para>
    /// labels<para>"TSI compliance of Ferromagnetic characteristics of wheel material required"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantFerromagneticWheel">http://data.europa.eu/949/tsiCompliantFerromagneticWheel</seealso>
    let tsiCompliantFerromagneticWheel =
        Prefixed_Name(era, "tsiCompliantFerromagneticWheel") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantMaxDistConsecutiveAxles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication whether required distance between two consecutive axles is compliant with the TSI. Deprecated according to the amendment to the Regulation (EU) 2019/777."</para>
    /// labels<para>"TSI compliance of maximum permitted distance between two consecutive axles"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantMaxDistConsecutiveAxles">http://data.europa.eu/949/tsiCompliantMaxDistConsecutiveAxles</seealso>
    let tsiCompliantMaxDistConsecutiveAxles =
        Prefixed_Name(era, "tsiCompliantMaxDistConsecutiveAxles") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantMaxImpedanceWheelset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"TSI compliance of maximum permitted impedance between opposite wheels of a wheelset. Deprecated according to the amendment to the Regulation (EU) 2019/777."</para>
    /// labels<para>"TSI compliance of maximum permitted impedance between opposite wheels of a wheelset"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantMaxImpedanceWheelset">http://data.europa.eu/949/tsiCompliantMaxImpedanceWheelset</seealso>
    let tsiCompliantMaxImpedanceWheelset =
        Prefixed_Name(era, "tsiCompliantMaxImpedanceWheelset") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantMetalConstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"TSI compliance of rules for vehicle metal construction. Deprecated according to the amendment to the Regulation (EU) 2019/777."</para>
    /// labels<para>"TSI compliance of rules for vehicle metal construction"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantMetalConstruction">http://data.europa.eu/949/tsiCompliantMetalConstruction</seealso>
    let tsiCompliantMetalConstruction =
        Prefixed_Name(era, "tsiCompliantMetalConstruction") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantMetalFreeSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"TSI compliance of rules for metal-free space around wheels. Deprecated according to the amendment to the Regulation (EU) 2019/777."</para>
    /// labels<para>"TSI compliance of rules for metal-free space around wheels"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantMetalFreeSpace">http://data.europa.eu/949/tsiCompliantMetalFreeSpace</seealso>
    let tsiCompliantMetalFreeSpace =
        Prefixed_Name(era, "tsiCompliantMetalFreeSpace") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantRSTShuntImpedance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"TSI compliance of rules on combination of RST characteristics influencing shunting impedance. Deprecated according to the amendment to the Regulation (EU) 2019/777."</para>
    /// labels<para>"TSI compliance of rules on combination of RST characteristics influencing shunting impedance"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantRSTShuntImpedance">http://data.europa.eu/949/tsiCompliantRSTShuntImpedance</seealso>
    let tsiCompliantRSTShuntImpedance =
        Prefixed_Name(era, "tsiCompliantRSTShuntImpedance") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantRadioDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"TSI compliant radio (RMR)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantRadioDataParameter">http://data.europa.eu/949/tsiCompliantRadioDataParameter</seealso>
    let tsiCompliantRadioDataParameter =
        Prefixed_Name(era, "tsiCompliantRadioDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantRadioObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"TSI compliant radio (RMR)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantRadioObjParameter">http://data.europa.eu/949/tsiCompliantRadioObjParameter</seealso>
    let tsiCompliantRadioObjParameter =
        Prefixed_Name(era, "tsiCompliantRadioObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantSandCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"TSI Compliance of rules on sand characteristics. Deprecated according to the amendment to the Regulation (EU) 2019/777."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TSI Compliance of rules on sand characteristics"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantSandCharacteristics">http://data.europa.eu/949/tsiCompliantSandCharacteristics</seealso>
    let tsiCompliantSandCharacteristics =
        Prefixed_Name(era, "tsiCompliantSandCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantSanding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"TSI compliance of sanding rules to allow compatibility with track circuits. Too much sand brings the risk of not detecting trains in tracks equipped with track circuits. Deprecated according to the amendment to the Regulation (EU) 2019/777."</para>
    /// labels<para>"TSI compliance of sanding"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantSanding">http://data.europa.eu/949/tsiCompliantSanding</seealso>
    let tsiCompliantSanding = Prefixed_Name(era, "tsiCompliantSanding") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantShuntDevices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Deprecated according to the amendment to the Regulation (EU) 2019/777. TSI compliance of rules on shunt assisting devices."</para>
    /// labels<para>"TSI compliance of rules on shunt assisting devices"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantShuntDevices">http://data.europa.eu/949/tsiCompliantShuntDevices</seealso>
    let tsiCompliantShuntDevices =
        Prefixed_Name(era, "tsiCompliantShuntDevices") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantTrainProtectionSystemDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"TSI compliant train protection system (ETCS)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantTrainProtectionSystemDataParameter">http://data.europa.eu/949/tsiCompliantTrainProtectionSystemDataParameter</seealso>
    let tsiCompliantTrainProtectionSystemDataParameter =
        Prefixed_Name(era, "tsiCompliantTrainProtectionSystemDataParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiCompliantTrainProtectionSystemObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"TSI compliant train protection system (ETCS)"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiCompliantTrainProtectionSystemObjParameter">http://data.europa.eu/949/tsiCompliantTrainProtectionSystemObjParameter</seealso>
    let tsiCompliantTrainProtectionSystemObjParameter =
        Prefixed_Name(era, "tsiCompliantTrainProtectionSystemObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiMagneticFields</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication whether rules exist and are compliant with the TSI."</para>
    /// labels<para>"Existence and TSI compliance of rules for magnetic fields emitted by a vehicle"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiMagneticFields">http://data.europa.eu/949/tsiMagneticFields</seealso>
    let tsiMagneticFields = Prefixed_Name(era, "tsiMagneticFields") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiOPEAppendixD1Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The index of a vocabulary term in Appendix D1 Vehicle and train Route compatibility checks."</para>
    /// labels<para>"TSI operation appendix D1 index"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiOPEAppendixD1Index">http://data.europa.eu/949/tsiOPEAppendixD1Index</seealso>
    let tsiOPEAppendixD1Index =
        Prefixed_Name(era, "tsiOPEAppendixD1Index") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiOPEAppendixD2Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The index of a vocabulary term in Appendix D2 Elements the infrastructure manager has to provide to the railway undertaking for the Route Book from the document Commission Implementing Regulation (EU) 2019/773 of 16 May 2019 on the technical specification for interoperability relating to the operation and traffic management subsystem of the rail system within the European Union and repealing Decision 2012/757/EU."</para>
    /// labels<para>"TSI operation appendix D2 index"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiOPEAppendixD2Index">http://data.europa.eu/949/tsiOPEAppendixD2Index</seealso>
    let tsiOPEAppendixD2Index =
        Prefixed_Name(era, "tsiOPEAppendixD2Index") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiOPEAppendixD3Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The index of a vocabulary term in Appendix D3 ERTMS trackside engineering information relevant to operation that the infrastructure manager shall provide to the railway undertaking."</para>
    /// labels<para>"TSI operation appendix D3 index"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiOPEAppendixD3Index">http://data.europa.eu/949/tsiOPEAppendixD3Index</seealso>
    let tsiOPEAppendixD3Index =
        Prefixed_Name(era, "tsiOPEAppendixD3Index") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiPantographHead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication of TSI compliant pantograph heads which are allowed to be used."</para>
    /// labels<para>"Accepted TSI compliant pantograph heads"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiPantographHead">http://data.europa.eu/949/tsiPantographHead</seealso>
    let tsiPantographHead = Prefixed_Name(era, "tsiPantographHead") |> PrefixedName
    /// <summary>
    ///   <para>era:tsiSwitchCrossing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Switches and crossings are maintained to in service limit dimension as specified in TSI."</para>
    /// labels<para>"TSI compliance of in-service values for switches and crossings"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiSwitchCrossing">http://data.europa.eu/949/tsiSwitchCrossing</seealso>
    let tsiSwitchCrossing = Prefixed_Name(era, "tsiSwitchCrossing") |> PrefixedName

    /// <summary>
    ///   <para>era:tsiTractionHarmonics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indication whether rules exist and are compliant with the TSI."</para>
    /// labels<para>"Existence and TSI compliance of limits in harmonics in the traction current of vehicles"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tsiTractionHarmonics">http://data.europa.eu/949/tsiTractionHarmonics</seealso>
    let tsiTractionHarmonics =
        Prefixed_Name(era, "tsiTractionHarmonics") |> PrefixedName

    /// <summary>
    ///   <para>era:tunnelDataParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Tunnel"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tunnelDataParameter">http://data.europa.eu/949/tunnelDataParameter</seealso>
    let tunnelDataParameter = Prefixed_Name(era, "tunnelDataParameter") |> PrefixedName
    /// <summary>
    ///   <para>era:tunnelDocRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Electronic document available from the IM stored by the Agency with precise description of the clearance gauge and geometry of the tunnel."</para>
    /// labels<para>"Document available from the IM with precise description of the tunnel"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tunnelDocRef">http://data.europa.eu/949/tunnelDocRef</seealso>
    let tunnelDocRef = Prefixed_Name(era, "tunnelDocRef") |> PrefixedName

    /// <summary>
    ///   <para>era:tunnelIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique tunnel identification or unique tunnel number within Member State"</para>
    /// labels<para>"Tunnel identification"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tunnelIdentification">http://data.europa.eu/949/tunnelIdentification</seealso>
    let tunnelIdentification =
        Prefixed_Name(era, "tunnelIdentification") |> PrefixedName

    /// <summary>
    ///   <para>era:tunnelKilometerEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the End of tunnel that indicates the km of the line at the end of a tunnel.
    /// The End of tunnel is the Geographical coordinates in decimal degrees and km of the line at the end of a tunnel. The reason for deprecation is that the property is now a subproperty of lineReference in order to represent the kilometer in relation to a national railway line"</para>
    /// labels<para>"(deprecated) End of tunnel kilometer"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tunnelKilometerEnd">http://data.europa.eu/949/tunnelKilometerEnd</seealso>
    let tunnelKilometerEnd = Prefixed_Name(era, "tunnelKilometerEnd") |> PrefixedName

    /// <summary>
    ///   <para>era:tunnelKilometerStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"(deprecated) Start of tunnel kilometer"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tunnelKilometerStart">http://data.europa.eu/949/tunnelKilometerStart</seealso>
    let tunnelKilometerStart =
        Prefixed_Name(era, "tunnelKilometerStart") |> PrefixedName

    /// <summary>
    ///   <para>era:tunnelObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Tunnel"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/tunnelObjParameter">http://data.europa.eu/949/tunnelObjParameter</seealso>
    let tunnelObjParameter = Prefixed_Name(era, "tunnelObjParameter") |> PrefixedName
    /// <summary>
    ///   <para>era:typeOfTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Classification of the type of traffic carried on the element."</para>
    /// labels<para>"Type of traffic"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/typeOfTraffic">http://data.europa.eu/949/typeOfTraffic</seealso>
    let typeOfTraffic = Prefixed_Name(era, "typeOfTraffic") |> PrefixedName
    /// <summary>
    ///   <para>era:typeVersionId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the registrationVersion with Ids 10, 20 and 30 indicating registration according to Directive 2008/57/EC and implementing Decision 2011/665/EU, and 40 and 50 indicating registration according to regime described in Directive 2008/57/EC.
    /// The allowed values for this property belong to the SKOS Concept Scheme http://data.europa.eu/949/concepts/type-version-ids/TypeVersionIds."</para>
    /// labels<para>"Type version id"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/typeVersionId">http://data.europa.eu/949/typeVersionId</seealso>
    let typeVersionId = Prefixed_Name(era, "typeVersionId") |> PrefixedName
    /// <summary>
    ///   <para>era:typeVersionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Serial number that identifies a vehicle type."</para>
    /// labels<para>"Type version number"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/typeVersionNumber">http://data.europa.eu/949/typeVersionNumber</seealso>
    let typeVersionNumber = Prefixed_Name(era, "typeVersionNumber") |> PrefixedName
    /// <summary>
    ///   <para>era:umax2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Highest non-permanent voltage (Umax2) for France on lines not compliant with values defined in the EN50163:2004+A1:2007+A2:2020+A3:2022"</para>
    /// labels<para>"Umax2 for the French network"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/umax2">http://data.europa.eu/949/umax2</seealso>
    let umax2 = Prefixed_Name(era, "umax2") |> PrefixedName
    /// <summary>
    ///   <para>era:unitOfMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Magnitude of a quantity, defined and adopted by convention or by law, that is used as a standard for measurement of the same kind of quantity."</para>
    /// labels<para>"Unit of measure"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/unitOfMeasure">http://data.europa.eu/949/unitOfMeasure</seealso>
    let unitOfMeasure = Prefixed_Name(era, "unitOfMeasure") |> PrefixedName
    /// <summary>
    ///   <para>era:uopid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Code composed of country code and alphanumeric operational point code."</para>
    /// labels<para>"Unique OP ID"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/uopid">http://data.europa.eu/949/uopid</seealso>
    let uopid = Prefixed_Name(era, "uopid") |> PrefixedName

    /// <summary>
    ///   <para>era:usedInRCCCalculations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Indicates whether a RINF parameter is used in Route Compatibility Check calculations according to Commission Implementing Regulation (EU) 2019/773 of 16 May 2019 on the technical specification for interoperability relating to the operation and traffic management subsystem of the rail system within the European Union and repealing Decision."</para>
    /// labels<para>"Parameter is used in Route Compatibility Check (RCC) calculations"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/usedInRCCCalculations">http://data.europa.eu/949/usedInRCCCalculations</seealso>
    let usedInRCCCalculations =
        Prefixed_Name(era, "usedInRCCCalculations") |> PrefixedName

    /// <summary>
    ///   <para>era:usesGroup555</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication if group 555 is used."</para>
    /// labels<para>"GSM-R use of group 555"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/usesGroup555">http://data.europa.eu/949/usesGroup555</seealso>
    let usesGroup555 = Prefixed_Name(era, "usesGroup555") |> PrefixedName
    /// <summary>
    ///   <para>era:vNvallowovtrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Speed limit allowing the driver to select the  override  function in km/h
    /// According to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"V_NVALLOWOVTRP"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vNvallowovtrp">http://data.europa.eu/949/vNvallowovtrp</seealso>
    let vNvallowovtrp = Prefixed_Name(era, "vNvallowovtrp") |> PrefixedName
    /// <summary>
    ///   <para>era:vNvsupovtrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Override speed limit to be supervised when the "override" function is active in km/h.
    /// According to the specification referenced in Appendix A-1, index [C]"</para>
    /// labels<para>"V_NVSUPOVTRP"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vNvsupovtrp">http://data.europa.eu/949/vNvsupovtrp</seealso>
    let vNvsupovtrp = Prefixed_Name(era, "vNvsupovtrp") |> PrefixedName
    /// <summary>
    ///   <para>era:validity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a feature with a temporal feature to indicate a validity period."</para>
    /// labels<para>"validity"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/validity">http://data.europa.eu/949/validity</seealso>
    let validity = Prefixed_Name(era, "validity") |> PrefixedName
    /// <summary>
    ///   <para>era:validityEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Validity end date"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/validityEndDate">http://data.europa.eu/949/validityEndDate</seealso>
    let validityEndDate = Prefixed_Name(era, "validityEndDate") |> PrefixedName
    /// <summary>
    ///   <para>era:validityStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Validity start date"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/validityStartDate">http://data.europa.eu/949/validityStartDate</seealso>
    let validityStartDate = Prefixed_Name(era, "validityStartDate") |> PrefixedName
    /// <summary>
    ///   <para>era:vehicleCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the core purpose of a railway vehicle: delivering traction, transporting goods or passengers or serving as a special vehicle."</para>
    /// labels<para>"Vehicle category"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleCategory">http://data.europa.eu/949/vehicleCategory</seealso>
    let vehicleCategory = Prefixed_Name(era, "vehicleCategory") |> PrefixedName
    /// <summary>
    ///   <para>era:vehicleContactForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Mean contact force."</para>
    /// labels<para>"Vehicle contact force"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleContactForce">http://data.europa.eu/949/vehicleContactForce</seealso>
    let vehicleContactForce = Prefixed_Name(era, "vehicleContactForce") |> PrefixedName
    /// <summary>
    ///   <para>era:vehicleKeeper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The natural or legal person that, being the owner of a vehicle or having the right to use it,
    /// exploits the vehicle as a means of transport and is registered as such in a vehicle register referred to in Article 47 of (EU)2016/797."</para>
    /// labels<para>"vehicle keeper"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleKeeper">http://data.europa.eu/949/vehicleKeeper</seealso>
    let vehicleKeeper = Prefixed_Name(era, "vehicleKeeper") |> PrefixedName

    /// <summary>
    ///   <para>era:vehicleKinematicGaugeOther</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Vehicle kinematic gauge  that corresponds to other gauges assessed using the kinematic method"</para>
    /// labels<para>"Vehicle kinematic gauge other"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleKinematicGaugeOther">http://data.europa.eu/949/vehicleKinematicGaugeOther</seealso>
    let vehicleKinematicGaugeOther =
        Prefixed_Name(era, "vehicleKinematicGaugeOther") |> PrefixedName

    /// <summary>
    ///   <para>era:vehicleMaxSandingOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Vehicle Maximum sanding output, given in grams per second."</para>
    /// labels<para>"Vehicle max sanding output"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleMaxSandingOutput">http://data.europa.eu/949/vehicleMaxSandingOutput</seealso>
    let vehicleMaxSandingOutput =
        Prefixed_Name(era, "vehicleMaxSandingOutput") |> PrefixedName

    /// <summary>
    ///   <para>era:vehicleNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identification number of a vehicle or wagon."</para>
    /// labels<para>"Vehicle number"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleNumber">http://data.europa.eu/949/vehicleNumber</seealso>
    let vehicleNumber = Prefixed_Name(era, "vehicleNumber") |> PrefixedName

    /// <summary>
    ///   <para>era:vehiclePantographHead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Pantograph head geometry (to be indicated for each energy supply system the vehicle is equipped for)."</para>
    /// labels<para>"Vehicle pantograph head"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehiclePantographHead">http://data.europa.eu/949/vehiclePantographHead</seealso>
    let vehiclePantographHead =
        Prefixed_Name(era, "vehiclePantographHead") |> PrefixedName

    /// <summary>
    ///   <para>era:vehicleSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Manufacturing series of a vehicle."</para>
    /// labels<para>"Vehicle series"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleSeries">http://data.europa.eu/949/vehicleSeries</seealso>
    let vehicleSeries = Prefixed_Name(era, "vehicleSeries") |> PrefixedName
    /// <summary>
    ///   <para>era:vehicleSubCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the further classification (but not any family/platform) of vehicles within a vehicle category."</para>
    /// labels<para>"Vehicle subcategory"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleSubCategory">http://data.europa.eu/949/vehicleSubCategory</seealso>
    let vehicleSubCategory = Prefixed_Name(era, "vehicleSubCategory") |> PrefixedName

    /// <summary>
    ///   <para>era:vehicleTechnicalDataCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Vehicle technical characteristic"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleTechnicalDataCharacteristic">http://data.europa.eu/949/vehicleTechnicalDataCharacteristic</seealso>
    let vehicleTechnicalDataCharacteristic =
        Prefixed_Name(era, "vehicleTechnicalDataCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>era:vehicleTechnicalObjCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Vehicle technical characteristic"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleTechnicalObjCharacteristic">http://data.europa.eu/949/vehicleTechnicalObjCharacteristic</seealso>
    let vehicleTechnicalObjCharacteristic =
        Prefixed_Name(era, "vehicleTechnicalObjCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>era:vehicleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the vehicle type of a specific vehicle or wagon."</para>
    /// labels<para>"Vehicle type"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleType">http://data.europa.eu/949/vehicleType</seealso>
    let vehicleType = Prefixed_Name(era, "vehicleType") |> PrefixedName

    /// <summary>
    ///   <para>era:vehicleTypeMaximumCantDeficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the combination of maximum speed and maximum cant deficiency for which the vehicle was assessed. Corresponds to the maximum cant deficiency."</para>
    /// labels<para>"Vehicle type maximum cant deficiency"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleTypeMaximumCantDeficiency">http://data.europa.eu/949/vehicleTypeMaximumCantDeficiency</seealso>
    let vehicleTypeMaximumCantDeficiency =
        Prefixed_Name(era, "vehicleTypeMaximumCantDeficiency") |> PrefixedName

    /// <summary>
    ///   <para>era:vehicleTypeMaximumSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part of the combination of maximum speed and maximum cant deficiency for which the vehicle was assessed. Corresponds to the maximum speed."</para>
    /// labels<para>"Vehicle type maximum speed"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleTypeMaximumSpeed">http://data.europa.eu/949/vehicleTypeMaximumSpeed</seealso>
    let vehicleTypeMaximumSpeed =
        Prefixed_Name(era, "vehicleTypeMaximumSpeed") |> PrefixedName

    /// <summary>
    ///   <para>era:vehicleTypeMaximumSpeedAndCantDeficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates the vehicle type with its values of maximum speed and cant deficiency."</para>
    /// labels<para>"Vehicle type maximum speed and cant deficiency"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleTypeMaximumSpeedAndCantDeficiency">http://data.europa.eu/949/vehicleTypeMaximumSpeedAndCantDeficiency</seealso>
    let vehicleTypeMaximumSpeedAndCantDeficiency =
        Prefixed_Name(era, "vehicleTypeMaximumSpeedAndCantDeficiency") |> PrefixedName

    /// <summary>
    ///   <para>era:vehicleTypeTechnicalDataCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Vehicle type technical characteristic"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleTypeTechnicalDataCharacteristic">http://data.europa.eu/949/vehicleTypeTechnicalDataCharacteristic</seealso>
    let vehicleTypeTechnicalDataCharacteristic =
        Prefixed_Name(era, "vehicleTypeTechnicalDataCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>era:vehicleTypeTechnicalObjectCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Vehicle type technical characteristic"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleTypeTechnicalObjectCharacteristic">http://data.europa.eu/949/vehicleTypeTechnicalObjectCharacteristic</seealso>
    let vehicleTypeTechnicalObjectCharacteristic =
        Prefixed_Name(era, "vehicleTypeTechnicalObjectCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>era:vehicleTypesCompatibleTrafficLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The infrastructure managers shall provide through RINF the information to the RU regarding list of vehicle types compatible with the route for which they have already verified compatibility for parameter Traffic load and load carrying capacity of infrastructure and train detection systems, where such information is available."</para>
    /// labels<para>"List of vehicle types already identified as compatible with Traffic load and load carrying capacity of infrastructure and train detection systems"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehicleTypesCompatibleTrafficLoad">http://data.europa.eu/949/vehicleTypesCompatibleTrafficLoad</seealso>
    let vehicleTypesCompatibleTrafficLoad =
        Prefixed_Name(era, "vehicleTypesCompatibleTrafficLoad") |> PrefixedName

    /// <summary>
    ///   <para>era:vehiclesCompatibleTrafficLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The infrastructure managers shall provide through RINF the information or a document to the RU regarding list of vehicles compatible with the route for which they have already verified compatibility for parameter Traffic load and load carrying capacity of infrastructure and train detection systems, where such information is available."</para>
    /// labels<para>"List of vehicles already identified as compatible with Traffic load and load carrying capacity of infrastructure and train detection systems"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehiclesCompatibleTrafficLoad">http://data.europa.eu/949/vehiclesCompatibleTrafficLoad</seealso>
    let vehiclesCompatibleTrafficLoad =
        Prefixed_Name(era, "vehiclesCompatibleTrafficLoad") |> PrefixedName

    /// <summary>
    ///   <para>era:vehiclesComposingFixedFormation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of vehicles composing the fixed formation (for fixed formation only). Note: the value is mandatory for all vehicle categories. If the vehicle is composed of only one car, the indicated value shall be '1'."</para>
    /// labels<para>"Vehicles composing fixed formation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/vehiclesComposingFixedFormation">http://data.europa.eu/949/vehiclesComposingFixedFormation</seealso>
    let vehiclesComposingFixedFormation =
        Prefixed_Name(era, "vehiclesComposingFixedFormation") |> PrefixedName

    /// <summary>
    ///   <para>era:verificationCCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250."</para>
    /// labels<para>"EC declaration of verification for track relating to compliance with the requirements from TSIs applicable to control, command signalling subsystem"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/verificationCCS">http://data.europa.eu/949/verificationCCS</seealso>
    let verificationCCS = Prefixed_Name(era, "verificationCCS") |> PrefixedName
    /// <summary>
    ///   <para>era:verificationENE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250."</para>
    /// labels<para>"EC declaration of verification for track relating to compliance with the requirements from TSIs applicable to energy subsystem"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/verificationENE">http://data.europa.eu/949/verificationENE</seealso>
    let verificationENE = Prefixed_Name(era, "verificationENE") |> PrefixedName
    /// <summary>
    ///   <para>era:verificationINF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250."</para>
    /// labels<para>"EC declaration of verification for infrastructure element relating to compliance with the requirements from TSIs applicable to infrastructure subsystem"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/verificationINF">http://data.europa.eu/949/verificationINF</seealso>
    let verificationINF = Prefixed_Name(era, "verificationINF") |> PrefixedName
    /// <summary>
    ///   <para>era:verificationSRT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique number for EC declarations in accordance with Commission Implementing Regulation (EU) 2019/250."</para>
    /// labels<para>"EC declaration of verification relating to compliance with the requirements from TSIs applicable to railway tunnel"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/verificationSRT">http://data.europa.eu/949/verificationSRT</seealso>
    let verificationSRT = Prefixed_Name(era, "verificationSRT") |> PrefixedName

    /// <summary>
    ///   <para>era:verifiedRccObjParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Vehicles for which Route compatibility is verified"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/verifiedRccObjParameter">http://data.europa.eu/949/verifiedRccObjParameter</seealso>
    let verifiedRccObjParameter =
        Prefixed_Name(era, "verifiedRccObjParameter") |> PrefixedName

    /// <summary>
    ///   <para>era:voiceGSMRNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Voice SIM Card GSM-R Home Network. The allowed values for this property belong to the SKOS Concept Scheme http://data.europa.eu/949/concepts/gsmr-networks/GSMRNetworks"</para>
    /// labels<para>"Voice GSM-R network"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/voiceGSMRNetwork">http://data.europa.eu/949/voiceGSMRNetwork</seealso>
    let voiceGSMRNetwork = Prefixed_Name(era, "voiceGSMRNetwork") |> PrefixedName

    /// <summary>
    ///   <para>era:voiceOperationalCommImpl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Voice and operational communication implementation."</para>
    /// labels<para>"Voice operational communication implementation"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/voiceOperationalCommImpl">http://data.europa.eu/949/voiceOperationalCommImpl</seealso>
    let voiceOperationalCommImpl =
        Prefixed_Name(era, "voiceOperationalCommImpl") |> PrefixedName

    /// <summary>
    ///   <para>era:voiceRadioCompatible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Radio requirements used for demonstrating technical compatibility voice."</para>
    /// labels<para>"Radio system compatibility voice"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/voiceRadioCompatible">http://data.europa.eu/949/voiceRadioCompatible</seealso>
    let voiceRadioCompatible =
        Prefixed_Name(era, "voiceRadioCompatible") |> PrefixedName

    /// <summary>
    ///   <para>era:wheelSetGauge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A single value expressed in millimetres that identifies the track gauge."</para>
    /// labels<para>"Nominal track gauge"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/wheelSetGauge">http://data.europa.eu/949/wheelSetGauge</seealso>
    let wheelSetGauge = Prefixed_Name(era, "wheelSetGauge") |> PrefixedName

    /// <summary>
    ///   <para>era:wheelSetGaugeChangeoverFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Wheelset gauge changeover facility. The allowed values for this property belong to the SKOS Concept Scheme http://data.europa.eu/949/concepts/gauge-changeover-facilities/GaugeChangeoverFacilities"</para>
    /// labels<para>"Wheelset gauge changeover facility"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/wheelSetGaugeChangeoverFacility">http://data.europa.eu/949/wheelSetGaugeChangeoverFacility</seealso>
    let wheelSetGaugeChangeoverFacility =
        Prefixed_Name(era, "wheelSetGaugeChangeoverFacility") |> PrefixedName

    /// <summary>
    ///   <para>era:wheelSetGaugeTransformationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Wheel gauge transformation method. Defined if more than one wheel gauges have been selected."</para>
    /// labels<para>"Wheel set gauge transformation method"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/wheelSetGaugeTransformationMethod">http://data.europa.eu/949/wheelSetGaugeTransformationMethod</seealso>
    let wheelSetGaugeTransformationMethod =
        Prefixed_Name(era, "wheelSetGaugeTransformationMethod") |> PrefixedName

    /// <summary>
    ///   <para>era:wheelchairSleepingPlaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of wheelchair accessible sleeping places."</para>
    /// labels<para>"Wheelchair sleeping spaces"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/wheelchairSleepingPlaces">http://data.europa.eu/949/wheelchairSleepingPlaces</seealso>
    let wheelchairSleepingPlaces =
        Prefixed_Name(era, "wheelchairSleepingPlaces") |> PrefixedName

    /// <summary>
    ///   <para>era:wheelchairSpaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of wheelchair spaces."</para>
    /// labels<para>"Wheelchair spaces"</para></remarks>
    /// <seealso href="http://data.europa.eu/949/wheelchairSpaces">http://data.europa.eu/949/wheelchairSpaces</seealso>
    let wheelchairSpaces = Prefixed_Name(era, "wheelchairSpaces") |> PrefixedName
