namespace https.w3id.org.seas.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module seas_stats =
    let _namespace_iri = Namespace_Iri seas_stats |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:seas/</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seas/">https://w3id.org/seas/</seealso>
    let _prefix_iri = Prefixed_Name(seas_stats, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/#Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seas/#Property">https://w3id.org/seas/#Property</seealso>
    let ``_#Property`` = Prefixed_Name(seas_stats, "#Property") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/ArchitectureOntology-2.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ArchitectureOntology-2.0">https://w3id.org/seas/ArchitectureOntology-2.0</seealso>
    let ``ArchitectureOntology_2.0`` =
        Prefixed_Name(seas_stats, "ArchitectureOntology-2.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/AssemblyBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"places used for people gathering for entertainment, worship, and eating or drinking. Examples: churches, restaurants."</para>
    /// labels<para>"Assembly Building"</para></remarks>
    /// <seealso href="https://w3id.org/seas/AssemblyBuilding">https://w3id.org/seas/AssemblyBuilding</seealso>
    let AssemblyBuilding = Prefixed_Name(seas_stats, "AssemblyBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/Attic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the part of a building, especially of a house, directly under a roof; garret."</para>
    /// labels<para>"Attic"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Attic">https://w3id.org/seas/Attic</seealso>
    let Attic = Prefixed_Name(seas_stats, "Attic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/Balcony</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An accessible structure extending from a building, especially outside a window."</para>
    /// labels<para>"Balcony"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Balcony">https://w3id.org/seas/Balcony</seealso>
    let Balcony = Prefixed_Name(seas_stats, "Balcony") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/Basement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A story of a building, partly or wholly underground."</para>
    /// labels<para>"Basement"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Basement">https://w3id.org/seas/Basement</seealso>
    let Basement = Prefixed_Name(seas_stats, "Basement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/Bathroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Bathroom is mainly used for bathing &amp;amp; washing up related activities."</para>
    /// labels<para>"Bathroom"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Bathroom">https://w3id.org/seas/Bathroom</seealso>
    let Bathroom = Prefixed_Name(seas_stats, "Bathroom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/BatteryOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/BatteryOntology-1.0">https://w3id.org/seas/BatteryOntology-1.0</seealso>
    let ``BatteryOntology_1.0`` =
        Prefixed_Name(seas_stats, "BatteryOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/Bedroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Bedroom is used mainly for sleeping."</para>
    /// labels<para>"Bedroom"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Bedroom">https://w3id.org/seas/Bedroom</seealso>
    let Bedroom = Prefixed_Name(seas_stats, "Bedroom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/BooleanPropertyOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/BooleanPropertyOntology-1.0">https://w3id.org/seas/BooleanPropertyOntology-1.0</seealso>
    let ``BooleanPropertyOntology_1.0`` =
        Prefixed_Name(seas_stats, "BooleanPropertyOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Buildings are roofed constructions which can be used separately, have been built for permanent purposes, can be entered by persons and are suitable or intended for protecting persons, animals or objects."</para>
    /// labels<para>"Building"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Building">https://w3id.org/seas/Building</seealso>
    let Building = Prefixed_Name(seas_stats, "Building") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/BuildingOntology</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/BuildingOntology">https://w3id.org/seas/BuildingOntology</seealso>
    let BuildingOntology = Prefixed_Name(seas_stats, "BuildingOntology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/BuildingOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/BuildingOntology-1.0">https://w3id.org/seas/BuildingOntology-1.0</seealso>
    let ``BuildingOntology_1.0`` =
        Prefixed_Name(seas_stats, "BuildingOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/BuildingSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Space is a 3D volume bounded by surfaces. It represents the physical spaces of the building."</para>
    /// labels<para>"Building Space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Building Space"</para></remarks>
    /// <seealso href="https://w3id.org/seas/BuildingSpace">https://w3id.org/seas/BuildingSpace</seealso>
    let BuildingSpace = Prefixed_Name(seas_stats, "BuildingSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/BuildingSpatialStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A man made structure with spatial properties."</para>
    /// labels<para>"Building Spatial Structure"</para></remarks>
    /// <seealso href="https://w3id.org/seas/BuildingSpatialStructure">https://w3id.org/seas/BuildingSpatialStructure</seealso>
    let BuildingSpatialStructure =
        Prefixed_Name(seas_stats, "BuildingSpatialStructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/BuildingStorey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The storey represents a (nearly) horizontal aggregation of spaces that are vertically bound."</para>
    /// labels<para>"Building Storey"</para></remarks>
    /// <seealso href="https://w3id.org/seas/BuildingStorey">https://w3id.org/seas/BuildingStorey</seealso>
    let BuildingStorey = Prefixed_Name(seas_stats, "BuildingStorey") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/ComfortOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ComfortOntology-1.0">https://w3id.org/seas/ComfortOntology-1.0</seealso>
    let ``ComfortOntology_1.0`` =
        Prefixed_Name(seas_stats, "ComfortOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/CommunicationConnection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/CommunicationConnection">https://w3id.org/seas/CommunicationConnection</seealso>
    let CommunicationConnection =
        Prefixed_Name(seas_stats, "CommunicationConnection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/CommunicationConnectionPoint</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/CommunicationConnectionPoint">https://w3id.org/seas/CommunicationConnectionPoint</seealso>
    let CommunicationConnectionPoint =
        Prefixed_Name(seas_stats, "CommunicationConnectionPoint") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/CommunicationDevice</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/CommunicationDevice">https://w3id.org/seas/CommunicationDevice</seealso>
    let CommunicationDevice =
        Prefixed_Name(seas_stats, "CommunicationDevice") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/ComplexOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ComplexOntology-1.0">https://w3id.org/seas/ComplexOntology-1.0</seealso>
    let ``ComplexOntology_1.0`` =
        Prefixed_Name(seas_stats, "ComplexOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/Corridor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gallery or passage connecting parts of a building; hallway."</para>
    /// labels<para>"Corridor"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Corridor">https://w3id.org/seas/Corridor</seealso>
    let Corridor = Prefixed_Name(seas_stats, "Corridor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/DeviceOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/DeviceOntology-1.0">https://w3id.org/seas/DeviceOntology-1.0</seealso>
    let ``DeviceOntology_1.0`` =
        Prefixed_Name(seas_stats, "DeviceOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/DiningRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A room in which meals are eaten, as in a home or hotel, especially the room in which the major or more formal meals are eaten."</para>
    /// labels<para>"Dining Room"</para></remarks>
    /// <seealso href="https://w3id.org/seas/DiningRoom">https://w3id.org/seas/DiningRoom</seealso>
    let DiningRoom = Prefixed_Name(seas_stats, "DiningRoom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/Door</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the large flat piece of wood, glass etc that you move when you go into or out of a building, room, vehicle etc, or when you open a cupboard (Longman Dictionary of Contemporary English Online)"</para>
    /// labels<para>"Door"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Door">https://w3id.org/seas/Door</seealso>
    let Door = Prefixed_Name(seas_stats, "Door") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/EducationalBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Schools and day care centers."</para>
    /// labels<para>"Educational Building"</para></remarks>
    /// <seealso href="https://w3id.org/seas/EducationalBuilding">https://w3id.org/seas/EducationalBuilding</seealso>
    let EducationalBuilding =
        Prefixed_Name(seas_stats, "EducationalBuilding") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/ElectricPowerSystemOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ElectricPowerSystemOntology-1.0">https://w3id.org/seas/ElectricPowerSystemOntology-1.0</seealso>
    let ``ElectricPowerSystemOntology_1.0`` =
        Prefixed_Name(seas_stats, "ElectricPowerSystemOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/ElectricVehicleOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ElectricVehicleOntology-1.0">https://w3id.org/seas/ElectricVehicleOntology-1.0</seealso>
    let ``ElectricVehicleOntology_1.0`` =
        Prefixed_Name(seas_stats, "ElectricVehicleOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/Elevator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Elevator is used to transport people between different floors."</para>
    /// labels<para>"Elevator"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Elevator">https://w3id.org/seas/Elevator</seealso>
    let Elevator = Prefixed_Name(seas_stats, "Elevator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/EnergyFormOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/EnergyFormOntology-1.0">https://w3id.org/seas/EnergyFormOntology-1.0</seealso>
    let ``EnergyFormOntology_1.0`` =
        Prefixed_Name(seas_stats, "EnergyFormOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/EvaluationOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/EvaluationOntology-1.0">https://w3id.org/seas/EvaluationOntology-1.0</seealso>
    let ``EvaluationOntology_1.0`` =
        Prefixed_Name(seas_stats, "EvaluationOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/FailableSystemOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/FailableSystemOntology-1.0">https://w3id.org/seas/FailableSystemOntology-1.0</seealso>
    let ``FailableSystemOntology_1.0`` =
        Prefixed_Name(seas_stats, "FailableSystemOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/FeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A feature of interest is an abstraction of a real world phenomena (thing, person, event, etc). A feature of interest is then defined in terms of its properties."</para>
    /// labels<para>"Feature of Interest"</para></remarks>
    /// <seealso href="https://w3id.org/seas/FeatureOfInterest">https://w3id.org/seas/FeatureOfInterest</seealso>
    let FeatureOfInterest =
        Prefixed_Name(seas_stats, "FeatureOfInterest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/FeatureOfInterestOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seas/FeatureOfInterestOntology">https://w3id.org/seas/FeatureOfInterestOntology</seealso>
    let FeatureOfInterestOntology =
        Prefixed_Name(seas_stats, "FeatureOfInterestOntology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/FeatureOfInterestOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/FeatureOfInterestOntology-1.0">https://w3id.org/seas/FeatureOfInterestOntology-1.0</seealso>
    let ``FeatureOfInterestOntology_1.0`` =
        Prefixed_Name(seas_stats, "FeatureOfInterestOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/FlexibilityOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/FlexibilityOntology-1.0">https://w3id.org/seas/FlexibilityOntology-1.0</seealso>
    let ``FlexibilityOntology_1.0`` =
        Prefixed_Name(seas_stats, "FlexibilityOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/ForecastingOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ForecastingOntology-1.0">https://w3id.org/seas/ForecastingOntology-1.0</seealso>
    let ``ForecastingOntology_1.0`` =
        Prefixed_Name(seas_stats, "ForecastingOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/GreenKPIOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/GreenKPIOntology-1.0">https://w3id.org/seas/GreenKPIOntology-1.0</seealso>
    let ``GreenKPIOntology_1.0`` =
        Prefixed_Name(seas_stats, "GreenKPIOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/Greenhouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A building, room, or zone, usually chiefly of glass, in which the temperature is maintained within a desired range, used for cultivating tender plants or growing plants out of season."</para>
    /// labels<para>"Greenhouse"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Greenhouse">https://w3id.org/seas/Greenhouse</seealso>
    let Greenhouse = Prefixed_Name(seas_stats, "Greenhouse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/Hall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A large entrance room of a house or building."</para>
    /// labels<para>"Hall"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Hall">https://w3id.org/seas/Hall</seealso>
    let Hall = Prefixed_Name(seas_stats, "Hall") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/HomeOffice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A work or office space set up in a person's home and used exclusively for business on a regular basis."</para>
    /// labels<para>"Tree house"</para></remarks>
    /// <seealso href="https://w3id.org/seas/HomeOffice">https://w3id.org/seas/HomeOffice</seealso>
    let HomeOffice = Prefixed_Name(seas_stats, "HomeOffice") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/IndustrialBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Buildings used for industrial production, e.g. factories, workshops, slaughterhouses, breweries, assembly plants, etc."</para>
    /// labels<para>"Industrial Building"</para></remarks>
    /// <seealso href="https://w3id.org/seas/IndustrialBuilding">https://w3id.org/seas/IndustrialBuilding</seealso>
    let IndustrialBuilding =
        Prefixed_Name(seas_stats, "IndustrialBuilding") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/InstitutionalBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Institutions such as hospitals providing medical and surgical treatment and nursing care for ill or injured people."</para>
    /// labels<para>"Institutional Building"</para></remarks>
    /// <seealso href="https://w3id.org/seas/InstitutionalBuilding">https://w3id.org/seas/InstitutionalBuilding</seealso>
    let InstitutionalBuilding =
        Prefixed_Name(seas_stats, "InstitutionalBuilding") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/Kitchen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Kitchen is a room used mainly for cooking and possibly eating."</para>
    /// labels<para>"Kitchen"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Kitchen">https://w3id.org/seas/Kitchen</seealso>
    let Kitchen = Prefixed_Name(seas_stats, "Kitchen") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/Laundry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A room or zone, as in a home or apartment building, reserved for doing the family wash."</para>
    /// labels<para>"Laundry"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Laundry">https://w3id.org/seas/Laundry</seealso>
    let Laundry = Prefixed_Name(seas_stats, "Laundry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/LivingRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Living Room is the main room of daytime activity."</para>
    /// labels<para>"Living Room"</para></remarks>
    /// <seealso href="https://w3id.org/seas/LivingRoom">https://w3id.org/seas/LivingRoom</seealso>
    let LivingRoom = Prefixed_Name(seas_stats, "LivingRoom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/Lobby</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An entrance hall, corridor, or vestibule, as in a public building, often serving as an anteroom; foyer."</para>
    /// labels<para>"Lobby"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Lobby">https://w3id.org/seas/Lobby</seealso>
    let Lobby = Prefixed_Name(seas_stats, "Lobby") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/MercantileBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Places where goods are displayed and sold. Examples: grocery stores, department stores, and gas stations."</para>
    /// labels<para>"Mercantile Building"</para></remarks>
    /// <seealso href="https://w3id.org/seas/MercantileBuilding">https://w3id.org/seas/MercantileBuilding</seealso>
    let MercantileBuilding =
        Prefixed_Name(seas_stats, "MercantileBuilding") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/NonResidentialBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A  non-residential building is a building at least half of which is used for other than residential purposes. "</para>
    /// labels<para>"Non-Residential Building"</para></remarks>
    /// <seealso href="https://w3id.org/seas/NonResidentialBuilding">https://w3id.org/seas/NonResidentialBuilding</seealso>
    let NonResidentialBuilding =
        Prefixed_Name(seas_stats, "NonResidentialBuilding") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/OfferingOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/OfferingOntology-1.0">https://w3id.org/seas/OfferingOntology-1.0</seealso>
    let ``OfferingOntology_1.0`` =
        Prefixed_Name(seas_stats, "OfferingOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/Office</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A room, set of rooms, or building where the business of a commercial or industrial organization or of a professional person is conducted."</para>
    /// labels<para>"Office"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Office">https://w3id.org/seas/Office</seealso>
    let Office = Prefixed_Name(seas_stats, "Office") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/OfficeBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Places where services are provided. Examples: banks, insurance agencies."</para>
    /// labels<para>"Business Building"</para></remarks>
    /// <seealso href="https://w3id.org/seas/OfficeBuilding">https://w3id.org/seas/OfficeBuilding</seealso>
    let OfficeBuilding = Prefixed_Name(seas_stats, "OfficeBuilding") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/OperatingOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/OperatingOntology-1.0">https://w3id.org/seas/OperatingOntology-1.0</seealso>
    let ``OperatingOntology_1.0`` =
        Prefixed_Name(seas_stats, "OperatingOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/OptimizationOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/OptimizationOntology-1.0">https://w3id.org/seas/OptimizationOntology-1.0</seealso>
    let ``OptimizationOntology_1.0`` =
        Prefixed_Name(seas_stats, "OptimizationOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/PercentageProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of properties that are quantified using some percentage value."</para>
    /// labels<para>"Percentage Property"</para></remarks>
    /// <seealso href="https://w3id.org/seas/PercentageProperty">https://w3id.org/seas/PercentageProperty</seealso>
    let PercentageProperty =
        Prefixed_Name(seas_stats, "PercentageProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/PeriodicSignalOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/PeriodicSignalOntology-1.0">https://w3id.org/seas/PeriodicSignalOntology-1.0</seealso>
    let ``PeriodicSignalOntology_1.0`` =
        Prefixed_Name(seas_stats, "PeriodicSignalOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/PhotovoltaicOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/PhotovoltaicOntology-1.0">https://w3id.org/seas/PhotovoltaicOntology-1.0</seealso>
    let ``PhotovoltaicOntology_1.0`` =
        Prefixed_Name(seas_stats, "PhotovoltaicOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/PlayerOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/PlayerOntology-1.0">https://w3id.org/seas/PlayerOntology-1.0</seealso>
    let ``PlayerOntology_1.0`` =
        Prefixed_Name(seas_stats, "PlayerOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An observable or operable Quality of an Event or Object. That is, not a quality of an abstract entity as is also allowed by DUL's Quality, but rather an aspect of an entity that is intrinsic to and cannot exist without the entity and is observable by a sensor, or operable by an actuator.
    ///
    /// On the other hand, a property may also itself be a feature of interest. For example if a fridge uses alternative current energy, then several aspects of its energy consumption property may be quantified. Examples of such aspects include:
    ///
    /// - the active power consumption;
    /// - the reactive power consumption;
    /// - the phase of voltage relative to current;
    /// - the frequency;
    /// - the minimal operating value of the frequency;
    /// - the number of occurences of unusual values.
    ///
    /// These are different properties of the same property:
    ///
    /// ```
    /// ex:activePower a owl:ObjectProperty ;
    ///   rdfs:subPropertyOf seas:hasProperty ;
    ///   rdfs:domain seas:PowerProperty ;
    ///   rdfs:range seas:PowerProperty .
    ///
    /// &lt;fridge/1/consumption&gt; a seas:FeatureOfInterest ;
    ///   ex:activePower &lt;fridge/1/consumption/activePower&gt; .
    /// ```
    ///
    /// "</para>
    /// labels<para>"Property"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Property">https://w3id.org/seas/Property</seealso>
    let Property = Prefixed_Name(seas_stats, "Property") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/ResidentialBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A residential building is a building at least half of which is used for residential purposes. "</para>
    /// labels<para>"Residential Building"</para></remarks>
    /// <seealso href="https://w3id.org/seas/ResidentialBuilding">https://w3id.org/seas/ResidentialBuilding</seealso>
    let ResidentialBuilding =
        Prefixed_Name(seas_stats, "ResidentialBuilding") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A room in a building space enclosed by surfaces, this could also be modelled as role of space, not subclass of the space itself."</para>
    /// labels<para>"Room"</para><para>"Room"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/seas/Room">https://w3id.org/seas/Room</seealso>
    let Room = Prefixed_Name(seas_stats, "Room") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/SiteOfBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Building site is a locale containing one or more separate buildings. They are zones."</para>
    /// labels<para>"Site Of Building"</para></remarks>
    /// <seealso href="https://w3id.org/seas/SiteOfBuilding">https://w3id.org/seas/SiteOfBuilding</seealso>
    let SiteOfBuilding = Prefixed_Name(seas_stats, "SiteOfBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/Stairs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A construction designed to bridge a large vertical distance by dividing it into smaller vertical distances, called steps."</para>
    /// labels<para>"Stairs"</para></remarks>
    /// <seealso href="https://w3id.org/seas/Stairs">https://w3id.org/seas/Stairs</seealso>
    let Stairs = Prefixed_Name(seas_stats, "Stairs") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/StatisticsOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/StatisticsOntology-1.0">https://w3id.org/seas/StatisticsOntology-1.0</seealso>
    let ``StatisticsOntology_1.0`` =
        Prefixed_Name(seas_stats, "StatisticsOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/StorageRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Room for storage."</para>
    /// labels<para>"Storage Room"</para></remarks>
    /// <seealso href="https://w3id.org/seas/StorageRoom">https://w3id.org/seas/StorageRoom</seealso>
    let StorageRoom = Prefixed_Name(seas_stats, "StorageRoom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/SwimmingPool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tank or large artificial basin, as of concrete, for filling with water for swimming."</para>
    /// labels<para>"Swimming Pool"</para></remarks>
    /// <seealso href="https://w3id.org/seas/SwimmingPool">https://w3id.org/seas/SwimmingPool</seealso>
    let SwimmingPool = Prefixed_Name(seas_stats, "SwimmingPool") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/System</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/System">https://w3id.org/seas/System</seealso>
    let System = Prefixed_Name(seas_stats, "System") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/SystemOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/SystemOntology-1.0">https://w3id.org/seas/SystemOntology-1.0</seealso>
    let ``SystemOntology_1.0`` =
        Prefixed_Name(seas_stats, "SystemOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/ThermodynamicSystemOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ThermodynamicSystemOntology-1.0">https://w3id.org/seas/ThermodynamicSystemOntology-1.0</seealso>
    let ``ThermodynamicSystemOntology_1.0`` =
        Prefixed_Name(seas_stats, "ThermodynamicSystemOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/TimeOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/TimeOntology-1.0">https://w3id.org/seas/TimeOntology-1.0</seealso>
    let ``TimeOntology_1.0`` =
        Prefixed_Name(seas_stats, "TimeOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/TradingOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/TradingOntology-1.0">https://w3id.org/seas/TradingOntology-1.0</seealso>
    let ``TradingOntology_1.0`` =
        Prefixed_Name(seas_stats, "TradingOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/UtilityRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Room for other special utilities and hobbies."</para>
    /// labels<para>"Utility Room"</para></remarks>
    /// <seealso href="https://w3id.org/seas/UtilityRoom">https://w3id.org/seas/UtilityRoom</seealso>
    let UtilityRoom = Prefixed_Name(seas_stats, "UtilityRoom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/ZoneLightingOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ZoneLightingOntology-1.0">https://w3id.org/seas/ZoneLightingOntology-1.0</seealso>
    let ``ZoneLightingOntology_1.0`` =
        Prefixed_Name(seas_stats, "ZoneLightingOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/ZoneOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ZoneOntology-1.0">https://w3id.org/seas/ZoneOntology-1.0</seealso>
    let ``ZoneOntology_1.0`` =
        Prefixed_Name(seas_stats, "ZoneOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/connectionPointOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/connectionPointOf">https://w3id.org/seas/connectionPointOf</seealso>
    let connectionPointOf =
        Prefixed_Name(seas_stats, "connectionPointOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seas/connectsSystem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/connectsSystem">https://w3id.org/seas/connectsSystem</seealso>
    let connectsSystem = Prefixed_Name(seas_stats, "connectsSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/connectsSystemAt</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/connectsSystemAt">https://w3id.org/seas/connectsSystemAt</seealso>
    let connectsSystemAt = Prefixed_Name(seas_stats, "connectsSystemAt") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/derivesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a seas:Property of another seas:Property it derives from.
    ///
    /// For example,
    ///
    /// ```
    /// &lt;fridge/1/consumptionPower&gt; seas:derivesFrom &lt;fridge/1/consumedEnergy&gt; .
    /// ```
    ///
    /// This property is symmetric, and the derived property is also a property of the feature of interest:
    ///
    /// ```
    /// seas:hasProperty &lt; seas:hasProperty o seas:derivesFrom
    /// ```
    ///
    /// "</para>
    /// labels<para>"derives from"</para></remarks>
    /// <seealso href="https://w3id.org/seas/derivesFrom">https://w3id.org/seas/derivesFrom</seealso>
    let derivesFrom = Prefixed_Name(seas_stats, "derivesFrom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a seas:FeatureOfInterest to a seas:Property of that feature. In the first version of the SSN ontology, this concept was defined as a subproperty of dul:hasQuality. dul:hasQuality is a relation between entities and qualities, e.g. 'Dmitri's skin is yellowish'.
    ///
    /// For example, the following RDF graph describes that feature of interest `&lt;fridge/1&gt;` has property `&lt;fridge/1/consumption&gt;` .
    ///
    /// ```
    /// &lt;fridge/1&gt; seas:hasProperty &lt;fridge/1/consumption&gt; .
    /// ```
    /// "</para>
    /// labels<para>"property"</para></remarks>
    /// <seealso href="https://w3id.org/seas/hasProperty">https://w3id.org/seas/hasProperty</seealso>
    let hasProperty = Prefixed_Name(seas_stats, "hasProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/isPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a seas:Property of its one and only seas:FeatureOfInterest.
    ///   For example,
    ///
    /// ```
    /// &lt;fridge/1/consumption&gt; seas:isPropertyOf &lt;fridge/1&gt; .
    /// ```
    /// "</para>
    /// labels<para>"is property of"</para></remarks>
    /// <seealso href="https://w3id.org/seas/isPropertyOf">https://w3id.org/seas/isPropertyOf</seealso>
    let isPropertyOf = Prefixed_Name(seas_stats, "isPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/seas-0.9</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/seas-0.9">https://w3id.org/seas/seas-0.9</seealso>
    let ``seas_0.9`` = Prefixed_Name(seas_stats, "seas-0.9") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/seas-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/seas-1.0">https://w3id.org/seas/seas-1.0</seealso>
    let ``seas_1.0`` = Prefixed_Name(seas_stats, "seas-1.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seas/subSystemOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/subSystemOf">https://w3id.org/seas/subSystemOf</seealso>
    let subSystemOf = Prefixed_Name(seas_stats, "subSystemOf") |> PrefixedName
