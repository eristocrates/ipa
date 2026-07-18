namespace https.w3id.org.seas.slash

open DoxAletheia.Rdf_Vocabulary

module seas_stats =
    let _namespace_name = "https://w3id.org/seas/"

    /// <summary>
    /// places used for people gathering for entertainment, worship, and eating or drinking. Examples: churches, restaurants.
    /// <see href="https://w3id.org/seas/AssemblyBuilding"></see></summary>
    let AssemblyBuilding =
        Namespaced_IRI.parse _namespace_name "AssemblyBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seas/BuildingOntology"></see>
    /// </summary>
    let BuildingOntology =
        Namespaced_IRI.parse _namespace_name "BuildingOntology" |> NamespacedName

    /// <summary>
    /// A  non-residential building is a building at least half of which is used for other than residential purposes.
    /// <see href="https://w3id.org/seas/NonResidentalBuilding"></see></summary>
    let NonResidentalBuilding =
        Namespaced_IRI.parse _namespace_name "NonResidentalBuilding" |> NamespacedName

    /// <summary>
    /// the part of a building, especially of a house, directly under a roof; garret.
    /// <see href="https://w3id.org/seas/Attic"></see></summary>
    let Attic = Namespaced_IRI.parse _namespace_name "Attic" |> NamespacedName
    /// <summary>
    /// A room in a building space enclosed by surfaces, this could also be modelled as role of space, not subclass of the space itself.
    /// <see href="https://w3id.org/seas/Room"></see></summary>
    let Room = Namespaced_IRI.parse _namespace_name "Room" |> NamespacedName
    /// <summary>
    /// An accessible structure extending from a building, especially outside a window.
    /// <see href="https://w3id.org/seas/Balcony"></see></summary>
    let Balcony = Namespaced_IRI.parse _namespace_name "Balcony" |> NamespacedName

    /// <summary>
    /// A Space is a 3D volume bounded by surfaces. According to the FIEMSER definition, a building space in SAREF defines the physical spaces of the building.
    /// <see href="https://w3id.org/seas/BuildingSpace"></see></summary>
    let BuildingSpace =
        Namespaced_IRI.parse _namespace_name "BuildingSpace" |> NamespacedName

    /// <summary>
    /// A story of a building, partly or wholly underground.
    /// <see href="https://w3id.org/seas/Basement"></see></summary>
    let Basement = Namespaced_IRI.parse _namespace_name "Basement" |> NamespacedName
    /// <summary>
    /// Bathroom is mainly used for bathing &amp;amp; washing up related activities.
    /// <see href="https://w3id.org/seas/Bathroom"></see></summary>
    let Bathroom = Namespaced_IRI.parse _namespace_name "Bathroom" |> NamespacedName
    /// <summary>
    /// Bedroom is used mainly for sleeping.
    /// <see href="https://w3id.org/seas/Bedroom"></see></summary>
    let Bedroom = Namespaced_IRI.parse _namespace_name "Bedroom" |> NamespacedName
    /// <summary>
    /// Buildings are roofed constructions which can be used separately, have been built for permanent purposes, can be entered by persons and are suitable or intended for protecting persons, animals or objects.
    /// <see href="https://w3id.org/seas/Building"></see></summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName

    /// <summary>
    /// Constructions are structures connected with the ground which are made of construction materials and components and/or for which construction work is carried out.
    /// <see href="https://w3id.org/seas/Construction"></see></summary>
    let Construction =
        Namespaced_IRI.parse _namespace_name "Construction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seas/Zone"></see>
    /// </summary>
    let Zone = Namespaced_IRI.parse _namespace_name "Zone" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seas/ZoneOntology"></see>
    /// </summary>
    let ZoneOntology =
        Namespaced_IRI.parse _namespace_name "ZoneOntology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seas/BuildingOntology-0.9"></see>
    /// </summary>
    let ``BuildingOntology-0.9`` =
        Namespaced_IRI.parse _namespace_name "BuildingOntology-0.9" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seas/BuildingOntology-1.0"></see>
    /// </summary>
    let ``BuildingOntology-1.0`` =
        Namespaced_IRI.parse _namespace_name "BuildingOntology-1.0" |> NamespacedName

    /// <summary>
    /// Connection between two building spaces, where they may potentially exchange heat, humidity, agents.
    /// <see href="https://w3id.org/seas/BuildingSpaceConnection"></see></summary>
    let BuildingSpaceConnection =
        Namespaced_IRI.parse _namespace_name "BuildingSpaceConnection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seas/connectsSystem"></see>
    /// </summary>
    let connectsSystem =
        Namespaced_IRI.parse _namespace_name "connectsSystem" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seas/connectsSystemAt"></see>
    /// </summary>
    let connectsSystemAt =
        Namespaced_IRI.parse _namespace_name "connectsSystemAt" |> NamespacedName

    /// <summary>
    /// Surface that marks the frontier of a building space, and represents the connection point to other building spaces.
    /// <see href="https://w3id.org/seas/BuildingSpaceFrontier"></see></summary>
    let BuildingSpaceFrontier =
        Namespaced_IRI.parse _namespace_name "BuildingSpaceFrontier" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seas/ZoneConnection"></see>
    /// </summary>
    let ZoneConnection =
        Namespaced_IRI.parse _namespace_name "ZoneConnection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seas/connectionPointOf"></see>
    /// </summary>
    let connectionPointOf =
        Namespaced_IRI.parse _namespace_name "connectionPointOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seas/connectsSystemThrough"></see>
    /// </summary>
    let connectsSystemThrough =
        Namespaced_IRI.parse _namespace_name "connectsSystemThrough" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seas/ZoneFrontier"></see>
    /// </summary>
    let ZoneFrontier =
        Namespaced_IRI.parse _namespace_name "ZoneFrontier" |> NamespacedName

    /// <summary>
    /// A man made structure with spatial properties.
    /// <see href="https://w3id.org/seas/BuildingSpatialStructure"></see></summary>
    let BuildingSpatialStructure =
        Namespaced_IRI.parse _namespace_name "BuildingSpatialStructure" |> NamespacedName

    /// <summary>
    /// The storey represents a (nearly) horizontal aggregation of spaces that are vertically bound.
    /// <see href="https://w3id.org/seas/BuildingStorey"></see></summary>
    let BuildingStorey =
        Namespaced_IRI.parse _namespace_name "BuildingStorey" |> NamespacedName

    /// <summary>
    /// Ceiling is a downwards tilted horizontal surface.
    /// <see href="https://w3id.org/seas/Ceiling"></see></summary>
    let Ceiling = Namespaced_IRI.parse _namespace_name "Ceiling" |> NamespacedName

    /// <summary>
    /// Civil engineering works are all constructions not classified under buildings : railways, roads, bridges, highways, airport runways, dams etc.
    /// <see href="https://w3id.org/seas/CivilEngineeringWork"></see></summary>
    let CivilEngineeringWork =
        Namespaced_IRI.parse _namespace_name "CivilEngineeringWork" |> NamespacedName

    /// <summary>
    /// A closed building space connection is a closed connection between two building spaces.
    ///
    ///   This separation may for instance be a wall, i.e., a (tilted more than 60 percent) vertical surface.
    ///
    ///   Instances of `seas:ClosedBuildingSpaceConnection` may be typed by classes from specialized building ontologies.
    /// <see href="https://w3id.org/seas/ClosedBuildingSpaceConnection"></see></summary>
    let ClosedBuildingSpaceConnection =
        Namespaced_IRI.parse _namespace_name "ClosedBuildingSpaceConnection" |> NamespacedName

    /// <summary>
    /// A gallery or passage connecting parts of a building; hallway.
    /// <see href="https://w3id.org/seas/Corridor"></see></summary>
    let Corridor = Namespaced_IRI.parse _namespace_name "Corridor" |> NamespacedName
    /// <summary>
    /// An entrance hall, corridor, or vestibule, as in a public building, often serving as an anteroom; foyer.
    /// <see href="https://w3id.org/seas/Lobby"></see></summary>
    let Lobby = Namespaced_IRI.parse _namespace_name "Lobby" |> NamespacedName
    /// <summary>
    /// A room in which meals are eaten, as in a home or hotel, especially the room in which the major or more formal meals are eaten.
    /// <see href="https://w3id.org/seas/DiningRoom"></see></summary>
    let DiningRoom = Namespaced_IRI.parse _namespace_name "DiningRoom" |> NamespacedName
    /// <summary>
    /// the large flat piece of wood, glass etc that you move when you go into or out of a building, room, vehicle etc, or when you open a cupboard (Longman Dictionary of Contemporary English Online)
    /// <see href="https://w3id.org/seas/Door"></see></summary>
    let Door = Namespaced_IRI.parse _namespace_name "Door" |> NamespacedName

    /// <summary>
    /// Schools and day care centers.
    /// <see href="https://w3id.org/seas/EducationalBuilding"></see></summary>
    let EducationalBuilding =
        Namespaced_IRI.parse _namespace_name "EducationalBuilding" |> NamespacedName

    /// <summary>
    /// Elevator is used to transport people between different floors.
    /// <see href="https://w3id.org/seas/Elevator"></see></summary>
    let Elevator = Namespaced_IRI.parse _namespace_name "Elevator" |> NamespacedName
    /// <summary>
    /// A floor is a upwards tilted horzontal surface, could be divided to interior, exposed (outside) or raised floor.
    /// <see href="https://w3id.org/seas/Floor"></see></summary>
    let Floor = Namespaced_IRI.parse _namespace_name "Floor" |> NamespacedName
    /// <summary>
    /// Room for garage.
    /// <see href="https://w3id.org/seas/Garage"></see></summary>
    let Garage = Namespaced_IRI.parse _namespace_name "Garage" |> NamespacedName
    /// <summary>
    /// A building, room, or zone, usually chiefly of glass, in which the temperature is maintained within a desired range, used for cultivating tender plants or growing plants out of season.
    /// <see href="https://w3id.org/seas/Greenhouse"></see></summary>
    let Greenhouse = Namespaced_IRI.parse _namespace_name "Greenhouse" |> NamespacedName
    /// <summary>
    /// A large entrance room of a house or building.
    /// <see href="https://w3id.org/seas/Hall"></see></summary>
    let Hall = Namespaced_IRI.parse _namespace_name "Hall" |> NamespacedName

    /// <summary>
    /// A secondary residential building used only occasionally during vacations such as a summerhouse or cottage.
    /// <see href="https://w3id.org/seas/HolidayBuilding"></see></summary>
    let HolidayBuilding =
        Namespaced_IRI.parse _namespace_name "HolidayBuilding" |> NamespacedName

    /// <summary>
    /// A residential building is a building at least half of which is used for residential purposes.
    /// <see href="https://w3id.org/seas/ResidentalBuilding"></see></summary>
    let ResidentalBuilding =
        Namespaced_IRI.parse _namespace_name "ResidentalBuilding" |> NamespacedName

    /// <summary>
    /// A work or office space set up in a person's home and used exclusively for business on a regular basis.
    /// <see href="https://w3id.org/seas/HomeOffice"></see></summary>
    let HomeOffice = Namespaced_IRI.parse _namespace_name "HomeOffice" |> NamespacedName
    /// <summary>
    /// A room, set of rooms, or building where the business of a commercial or industrial organization or of a professional person is conducted.
    /// <see href="https://w3id.org/seas/Office"></see></summary>
    let Office = Namespaced_IRI.parse _namespace_name "Office" |> NamespacedName

    /// <summary>
    /// Buildings used for industrial production, e.g. factories, workshops, slaughterhouses, breweries, assembly plants, etc.
    /// <see href="https://w3id.org/seas/IndustrialBuilding"></see></summary>
    let IndustrialBuilding =
        Namespaced_IRI.parse _namespace_name "IndustrialBuilding" |> NamespacedName

    /// <summary>
    /// Institutions such as hospitals providing medical and surgical treatment and nursing care for ill or injured people.
    /// <see href="https://w3id.org/seas/InstitutionalBuilding"></see></summary>
    let InstitutionalBuilding =
        Namespaced_IRI.parse _namespace_name "InstitutionalBuilding" |> NamespacedName

    /// <summary>
    /// Kitchen is a room used mainly for cooking and possibly eating.
    /// <see href="https://w3id.org/seas/Kitchen"></see></summary>
    let Kitchen = Namespaced_IRI.parse _namespace_name "Kitchen" |> NamespacedName
    /// <summary>
    /// A room or zone, as in a home or apartment building, reserved for doing the family wash.
    /// <see href="https://w3id.org/seas/Laundry"></see></summary>
    let Laundry = Namespaced_IRI.parse _namespace_name "Laundry" |> NamespacedName
    /// <summary>
    /// Living Room is the main room of daytime activity.
    /// <see href="https://w3id.org/seas/LivingRoom"></see></summary>
    let LivingRoom = Namespaced_IRI.parse _namespace_name "LivingRoom" |> NamespacedName

    /// <summary>
    /// A house typically consuming half the energy than a norm house.
    /// <see href="https://w3id.org/seas/LowEnergyHouse"></see></summary>
    let LowEnergyHouse =
        Namespaced_IRI.parse _namespace_name "LowEnergyHouse" |> NamespacedName

    /// <summary>
    /// Places where goods are displayed and sold. Examples: grocery stores, department stores, and gas stations.
    /// <see href="https://w3id.org/seas/MercantileBuilding"></see></summary>
    let MercantileBuilding =
        Namespaced_IRI.parse _namespace_name "MercantileBuilding" |> NamespacedName

    /// <summary>
    /// A building fulfilling the minimal criteria for energy efficiency.
    /// <see href="https://w3id.org/seas/NormHouse"></see></summary>
    let NormHouse = Namespaced_IRI.parse _namespace_name "NormHouse" |> NamespacedName

    /// <summary>
    /// Places where services are provided. Examples: banks, insurance agencies.
    /// <see href="https://w3id.org/seas/OfficeBuilding"></see></summary>
    let OfficeBuilding =
        Namespaced_IRI.parse _namespace_name "OfficeBuilding" |> NamespacedName

    /// <summary>
    /// Detached house.
    /// <see href="https://w3id.org/seas/OneDwellingBuilding"></see></summary>
    let OneDwellingBuilding =
        Namespaced_IRI.parse _namespace_name "OneDwellingBuilding" |> NamespacedName

    /// <summary>
    /// A detached small residential building.
    /// <see href="https://w3id.org/seas/SmallHouse"></see></summary>
    let SmallHouse = Namespaced_IRI.parse _namespace_name "SmallHouse" |> NamespacedName

    /// <summary>
    /// An open building space connection is a connection between two building spaces that is open.
    ///
    ///   This connection may for instance be a hole in a wall, or a virtual separation between two offices in an open space.
    ///
    ///   Instances of `seas:OpenBuildingSpaceConnection` may be typed by classes from specialized building ontologies.
    /// <see href="https://w3id.org/seas/OpenBuildingSpaceConnection"></see></summary>
    let OpenBuildingSpaceConnection =
        Namespaced_IRI.parse _namespace_name "OpenBuildingSpaceConnection" |> NamespacedName

    /// <summary>
    /// An opennable building space connection is a connection between two building spaces that has a certain degree of openness.
    ///
    ///   This connection may for instance be a window or a door.
    ///
    ///   Instances of `seas:OpennableBuildingSpaceConnection` may be typed by classes from specialized building ontologies.
    /// <see href="https://w3id.org/seas/OpennableBuildingSpaceConnection"></see></summary>
    let OpennableBuildingSpaceConnection =
        Namespaced_IRI.parse _namespace_name "OpennableBuildingSpaceConnection" |> NamespacedName

    /// <summary>
    /// A house typically consuming a quarter of the energy than a norm house.
    /// <see href="https://w3id.org/seas/PassiveHouse"></see></summary>
    let PassiveHouse =
        Namespaced_IRI.parse _namespace_name "PassiveHouse" |> NamespacedName

    /// <summary>
    /// A net plus-energy building is a building that over a year does generates more energy than it uses.
    /// <see href="https://w3id.org/seas/PlusEnergyBuilding"></see></summary>
    let PlusEnergyBuilding =
        Namespaced_IRI.parse _namespace_name "PlusEnergyBuilding" |> NamespacedName

    /// <summary>
    /// Places housing any type of a power plants.
    /// <see href="https://w3id.org/seas/PowerplantBuilding"></see></summary>
    let PowerplantBuilding =
        Namespaced_IRI.parse _namespace_name "PowerplantBuilding" |> NamespacedName

    /// <summary>
    /// A (tilted more than 60 percent) vertical surface that separates building spaces.
    /// <see href="https://w3id.org/seas/Roof"></see></summary>
    let Roof = Namespaced_IRI.parse _namespace_name "Roof" |> NamespacedName
    /// <summary>
    /// Sauna is a special type bathroom for enjoying heated steam.
    /// <see href="https://w3id.org/seas/Sauna"></see></summary>
    let Sauna = Namespaced_IRI.parse _namespace_name "Sauna" |> NamespacedName

    /// <summary>
    /// Building site is a locale containing one or more separate buildings. They are zones.
    /// <see href="https://w3id.org/seas/SiteOfBuilding"></see></summary>
    let SiteOfBuilding =
        Namespaced_IRI.parse _namespace_name "SiteOfBuilding" |> NamespacedName

    /// <summary>
    /// A construction designed to bridge a large vertical distance by dividing it into smaller vertical distances, called steps.
    /// <see href="https://w3id.org/seas/Stairs"></see></summary>
    let Stairs = Namespaced_IRI.parse _namespace_name "Stairs" |> NamespacedName

    /// <summary>
    /// Places where items are stored. Examples: warehouses, reservoirs and silos.
    /// <see href="https://w3id.org/seas/StorageBuilding"></see></summary>
    let StorageBuilding =
        Namespaced_IRI.parse _namespace_name "StorageBuilding" |> NamespacedName

    /// <summary>
    /// Room for storage.
    /// <see href="https://w3id.org/seas/StorageRoom"></see></summary>
    let StorageRoom =
        Namespaced_IRI.parse _namespace_name "StorageRoom" |> NamespacedName

    /// <summary>
    /// A structure, either attached or integrated into a building, which allows enjoyment of the surrounding landscape while being sheltered from adverse weather.
    /// <see href="https://w3id.org/seas/Sunroom"></see></summary>
    let Sunroom = Namespaced_IRI.parse _namespace_name "Sunroom" |> NamespacedName

    /// <summary>
    /// A tank or large artificial basin, as of concrete, for filling with water for swimming.
    /// <see href="https://w3id.org/seas/SwimmingPool"></see></summary>
    let SwimmingPool =
        Namespaced_IRI.parse _namespace_name "SwimmingPool" |> NamespacedName

    /// <summary>
    /// A small house, especially one for children to play in, built or placed up in the branches of a tree.
    /// <see href="https://w3id.org/seas/TreeHouse"></see></summary>
    let TreeHouse = Namespaced_IRI.parse _namespace_name "TreeHouse" |> NamespacedName

    /// <summary>
    /// Room for other special utilities and hobbies.
    /// <see href="https://w3id.org/seas/UtilityRoom"></see></summary>
    let UtilityRoom =
        Namespaced_IRI.parse _namespace_name "UtilityRoom" |> NamespacedName

    /// <summary>
    /// A roof upwards tilted surface tilted up part of upper envelope of building.
    /// <see href="https://w3id.org/seas/Wall"></see></summary>
    let Wall = Namespaced_IRI.parse _namespace_name "Wall" |> NamespacedName
    /// <summary>
    /// a space or an zone of glass in the wall of a building or vehicle that lets in light (Longman Dictionary of Contemporary English Online)
    /// <see href="https://w3id.org/seas/Window"></see></summary>
    let Window = Namespaced_IRI.parse _namespace_name "Window" |> NamespacedName
    /// <summary>
    /// A small usually walled and often paved zone open to the sky and adjacent to a building.
    /// <see href="https://w3id.org/seas/Yard"></see></summary>
    let Yard = Namespaced_IRI.parse _namespace_name "Yard" |> NamespacedName

    /// <summary>
    /// A net zero-energy building (ZEB) is a building that over a year does not use more energy than it generates.
    /// <see href="https://w3id.org/seas/ZeroEnergyBuilding"></see></summary>
    let ZeroEnergyBuilding =
        Namespaced_IRI.parse _namespace_name "ZeroEnergyBuilding" |> NamespacedName
