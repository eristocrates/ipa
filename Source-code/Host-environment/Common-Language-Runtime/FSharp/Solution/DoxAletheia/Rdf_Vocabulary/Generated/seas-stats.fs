namespace https.w3id.org.seas.slash

open DoxAletheia

module seas_stats =
    let _namespace_name = "https://w3id.org/seas/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// places used for people gathering for entertainment, worship, and eating or drinking. Examples: churches, restaurants.
    /// <see href="https://w3id.org/seas/AssemblyBuilding"></see></summary>
    let AssemblyBuilding = _prefix "AssemblyBuilding"
    /// <summary>
    ///   <see href="https://w3id.org/seas/BuildingOntology"></see>
    /// </summary>
    let BuildingOntology = _prefix "BuildingOntology"
    /// <summary>
    /// A  non-residential building is a building at least half of which is used for other than residential purposes.
    /// <see href="https://w3id.org/seas/NonResidentalBuilding"></see></summary>
    let NonResidentalBuilding = _prefix "NonResidentalBuilding"
    /// <summary>
    /// the part of a building, especially of a house, directly under a roof; garret.
    /// <see href="https://w3id.org/seas/Attic"></see></summary>
    let Attic = _prefix "Attic"
    /// <summary>
    /// A room in a building space enclosed by surfaces, this could also be modelled as role of space, not subclass of the space itself.
    /// <see href="https://w3id.org/seas/Room"></see></summary>
    let Room = _prefix "Room"
    /// <summary>
    /// An accessible structure extending from a building, especially outside a window.
    /// <see href="https://w3id.org/seas/Balcony"></see></summary>
    let Balcony = _prefix "Balcony"
    /// <summary>
    /// A Space is a 3D volume bounded by surfaces. According to the FIEMSER definition, a building space in SAREF defines the physical spaces of the building.
    /// <see href="https://w3id.org/seas/BuildingSpace"></see></summary>
    let BuildingSpace = _prefix "BuildingSpace"
    /// <summary>
    /// A story of a building, partly or wholly underground.
    /// <see href="https://w3id.org/seas/Basement"></see></summary>
    let Basement = _prefix "Basement"
    /// <summary>
    /// Bathroom is mainly used for bathing &amp;amp; washing up related activities.
    /// <see href="https://w3id.org/seas/Bathroom"></see></summary>
    let Bathroom = _prefix "Bathroom"
    /// <summary>
    /// Bedroom is used mainly for sleeping.
    /// <see href="https://w3id.org/seas/Bedroom"></see></summary>
    let Bedroom = _prefix "Bedroom"
    /// <summary>
    /// Buildings are roofed constructions which can be used separately, have been built for permanent purposes, can be entered by persons and are suitable or intended for protecting persons, animals or objects.
    /// <see href="https://w3id.org/seas/Building"></see></summary>
    let Building = _prefix "Building"
    /// <summary>
    /// Constructions are structures connected with the ground which are made of construction materials and components and/or for which construction work is carried out.
    /// <see href="https://w3id.org/seas/Construction"></see></summary>
    let Construction = _prefix "Construction"
    /// <summary>
    ///   <see href="https://w3id.org/seas/Zone"></see>
    /// </summary>
    let Zone = _prefix "Zone"
    /// <summary>
    ///   <see href="https://w3id.org/seas/ZoneOntology"></see>
    /// </summary>
    let ZoneOntology = _prefix "ZoneOntology"
    /// <summary>
    ///   <see href="https://w3id.org/seas/BuildingOntology-0.9"></see>
    /// </summary>
    let ``BuildingOntology-0.9`` = _prefix "BuildingOntology-0.9"
    /// <summary>
    ///   <see href="https://w3id.org/seas/BuildingOntology-1.0"></see>
    /// </summary>
    let ``BuildingOntology-1.0`` = _prefix "BuildingOntology-1.0"
    /// <summary>
    /// Connection between two building spaces, where they may potentially exchange heat, humidity, agents.
    /// <see href="https://w3id.org/seas/BuildingSpaceConnection"></see></summary>
    let BuildingSpaceConnection = _prefix "BuildingSpaceConnection"
    /// <summary>
    ///   <see href="https://w3id.org/seas/connectsSystem"></see>
    /// </summary>
    let connectsSystem = _prefix "connectsSystem"
    /// <summary>
    ///   <see href="https://w3id.org/seas/connectsSystemAt"></see>
    /// </summary>
    let connectsSystemAt = _prefix "connectsSystemAt"
    /// <summary>
    /// Surface that marks the frontier of a building space, and represents the connection point to other building spaces.
    /// <see href="https://w3id.org/seas/BuildingSpaceFrontier"></see></summary>
    let BuildingSpaceFrontier = _prefix "BuildingSpaceFrontier"
    /// <summary>
    ///   <see href="https://w3id.org/seas/ZoneConnection"></see>
    /// </summary>
    let ZoneConnection = _prefix "ZoneConnection"
    /// <summary>
    ///   <see href="https://w3id.org/seas/connectionPointOf"></see>
    /// </summary>
    let connectionPointOf = _prefix "connectionPointOf"
    /// <summary>
    ///   <see href="https://w3id.org/seas/connectsSystemThrough"></see>
    /// </summary>
    let connectsSystemThrough = _prefix "connectsSystemThrough"
    /// <summary>
    ///   <see href="https://w3id.org/seas/ZoneFrontier"></see>
    /// </summary>
    let ZoneFrontier = _prefix "ZoneFrontier"
    /// <summary>
    /// A man made structure with spatial properties.
    /// <see href="https://w3id.org/seas/BuildingSpatialStructure"></see></summary>
    let BuildingSpatialStructure = _prefix "BuildingSpatialStructure"
    /// <summary>
    /// The storey represents a (nearly) horizontal aggregation of spaces that are vertically bound.
    /// <see href="https://w3id.org/seas/BuildingStorey"></see></summary>
    let BuildingStorey = _prefix "BuildingStorey"
    /// <summary>
    /// Ceiling is a downwards tilted horizontal surface.
    /// <see href="https://w3id.org/seas/Ceiling"></see></summary>
    let Ceiling = _prefix "Ceiling"
    /// <summary>
    /// Civil engineering works are all constructions not classified under buildings : railways, roads, bridges, highways, airport runways, dams etc.
    /// <see href="https://w3id.org/seas/CivilEngineeringWork"></see></summary>
    let CivilEngineeringWork = _prefix "CivilEngineeringWork"
    /// <summary>
    /// A closed building space connection is a closed connection between two building spaces.
    ///
    ///   This separation may for instance be a wall, i.e., a (tilted more than 60 percent) vertical surface.
    ///
    ///   Instances of `seas:ClosedBuildingSpaceConnection` may be typed by classes from specialized building ontologies.
    /// <see href="https://w3id.org/seas/ClosedBuildingSpaceConnection"></see></summary>
    let ClosedBuildingSpaceConnection = _prefix "ClosedBuildingSpaceConnection"
    /// <summary>
    /// A gallery or passage connecting parts of a building; hallway.
    /// <see href="https://w3id.org/seas/Corridor"></see></summary>
    let Corridor = _prefix "Corridor"
    /// <summary>
    /// An entrance hall, corridor, or vestibule, as in a public building, often serving as an anteroom; foyer.
    /// <see href="https://w3id.org/seas/Lobby"></see></summary>
    let Lobby = _prefix "Lobby"
    /// <summary>
    /// A room in which meals are eaten, as in a home or hotel, especially the room in which the major or more formal meals are eaten.
    /// <see href="https://w3id.org/seas/DiningRoom"></see></summary>
    let DiningRoom = _prefix "DiningRoom"
    /// <summary>
    /// the large flat piece of wood, glass etc that you move when you go into or out of a building, room, vehicle etc, or when you open a cupboard (Longman Dictionary of Contemporary English Online)
    /// <see href="https://w3id.org/seas/Door"></see></summary>
    let Door = _prefix "Door"
    /// <summary>
    /// Schools and day care centers.
    /// <see href="https://w3id.org/seas/EducationalBuilding"></see></summary>
    let EducationalBuilding = _prefix "EducationalBuilding"
    /// <summary>
    /// Elevator is used to transport people between different floors.
    /// <see href="https://w3id.org/seas/Elevator"></see></summary>
    let Elevator = _prefix "Elevator"
    /// <summary>
    /// A floor is a upwards tilted horzontal surface, could be divided to interior, exposed (outside) or raised floor.
    /// <see href="https://w3id.org/seas/Floor"></see></summary>
    let Floor = _prefix "Floor"
    /// <summary>
    /// Room for garage.
    /// <see href="https://w3id.org/seas/Garage"></see></summary>
    let Garage = _prefix "Garage"
    /// <summary>
    /// A building, room, or zone, usually chiefly of glass, in which the temperature is maintained within a desired range, used for cultivating tender plants or growing plants out of season.
    /// <see href="https://w3id.org/seas/Greenhouse"></see></summary>
    let Greenhouse = _prefix "Greenhouse"
    /// <summary>
    /// A large entrance room of a house or building.
    /// <see href="https://w3id.org/seas/Hall"></see></summary>
    let Hall = _prefix "Hall"
    /// <summary>
    /// A secondary residential building used only occasionally during vacations such as a summerhouse or cottage.
    /// <see href="https://w3id.org/seas/HolidayBuilding"></see></summary>
    let HolidayBuilding = _prefix "HolidayBuilding"
    /// <summary>
    /// A residential building is a building at least half of which is used for residential purposes.
    /// <see href="https://w3id.org/seas/ResidentalBuilding"></see></summary>
    let ResidentalBuilding = _prefix "ResidentalBuilding"
    /// <summary>
    /// A work or office space set up in a person's home and used exclusively for business on a regular basis.
    /// <see href="https://w3id.org/seas/HomeOffice"></see></summary>
    let HomeOffice = _prefix "HomeOffice"
    /// <summary>
    /// A room, set of rooms, or building where the business of a commercial or industrial organization or of a professional person is conducted.
    /// <see href="https://w3id.org/seas/Office"></see></summary>
    let Office = _prefix "Office"
    /// <summary>
    /// Buildings used for industrial production, e.g. factories, workshops, slaughterhouses, breweries, assembly plants, etc.
    /// <see href="https://w3id.org/seas/IndustrialBuilding"></see></summary>
    let IndustrialBuilding = _prefix "IndustrialBuilding"
    /// <summary>
    /// Institutions such as hospitals providing medical and surgical treatment and nursing care for ill or injured people.
    /// <see href="https://w3id.org/seas/InstitutionalBuilding"></see></summary>
    let InstitutionalBuilding = _prefix "InstitutionalBuilding"
    /// <summary>
    /// Kitchen is a room used mainly for cooking and possibly eating.
    /// <see href="https://w3id.org/seas/Kitchen"></see></summary>
    let Kitchen = _prefix "Kitchen"
    /// <summary>
    /// A room or zone, as in a home or apartment building, reserved for doing the family wash.
    /// <see href="https://w3id.org/seas/Laundry"></see></summary>
    let Laundry = _prefix "Laundry"
    /// <summary>
    /// Living Room is the main room of daytime activity.
    /// <see href="https://w3id.org/seas/LivingRoom"></see></summary>
    let LivingRoom = _prefix "LivingRoom"
    /// <summary>
    /// A house typically consuming half the energy than a norm house.
    /// <see href="https://w3id.org/seas/LowEnergyHouse"></see></summary>
    let LowEnergyHouse = _prefix "LowEnergyHouse"
    /// <summary>
    /// Places where goods are displayed and sold. Examples: grocery stores, department stores, and gas stations.
    /// <see href="https://w3id.org/seas/MercantileBuilding"></see></summary>
    let MercantileBuilding = _prefix "MercantileBuilding"
    /// <summary>
    /// A building fulfilling the minimal criteria for energy efficiency.
    /// <see href="https://w3id.org/seas/NormHouse"></see></summary>
    let NormHouse = _prefix "NormHouse"
    /// <summary>
    /// Places where services are provided. Examples: banks, insurance agencies.
    /// <see href="https://w3id.org/seas/OfficeBuilding"></see></summary>
    let OfficeBuilding = _prefix "OfficeBuilding"
    /// <summary>
    /// Detached house.
    /// <see href="https://w3id.org/seas/OneDwellingBuilding"></see></summary>
    let OneDwellingBuilding = _prefix "OneDwellingBuilding"
    /// <summary>
    /// A detached small residential building.
    /// <see href="https://w3id.org/seas/SmallHouse"></see></summary>
    let SmallHouse = _prefix "SmallHouse"
    /// <summary>
    /// An open building space connection is a connection between two building spaces that is open.
    ///
    ///   This connection may for instance be a hole in a wall, or a virtual separation between two offices in an open space.
    ///
    ///   Instances of `seas:OpenBuildingSpaceConnection` may be typed by classes from specialized building ontologies.
    /// <see href="https://w3id.org/seas/OpenBuildingSpaceConnection"></see></summary>
    let OpenBuildingSpaceConnection = _prefix "OpenBuildingSpaceConnection"
    /// <summary>
    /// An opennable building space connection is a connection between two building spaces that has a certain degree of openness.
    ///
    ///   This connection may for instance be a window or a door.
    ///
    ///   Instances of `seas:OpennableBuildingSpaceConnection` may be typed by classes from specialized building ontologies.
    /// <see href="https://w3id.org/seas/OpennableBuildingSpaceConnection"></see></summary>
    let OpennableBuildingSpaceConnection = _prefix "OpennableBuildingSpaceConnection"
    /// <summary>
    /// A house typically consuming a quarter of the energy than a norm house.
    /// <see href="https://w3id.org/seas/PassiveHouse"></see></summary>
    let PassiveHouse = _prefix "PassiveHouse"
    /// <summary>
    /// A net plus-energy building is a building that over a year does generates more energy than it uses.
    /// <see href="https://w3id.org/seas/PlusEnergyBuilding"></see></summary>
    let PlusEnergyBuilding = _prefix "PlusEnergyBuilding"
    /// <summary>
    /// Places housing any type of a power plants.
    /// <see href="https://w3id.org/seas/PowerplantBuilding"></see></summary>
    let PowerplantBuilding = _prefix "PowerplantBuilding"
    /// <summary>
    /// A (tilted more than 60 percent) vertical surface that separates building spaces.
    /// <see href="https://w3id.org/seas/Roof"></see></summary>
    let Roof = _prefix "Roof"
    /// <summary>
    /// Sauna is a special type bathroom for enjoying heated steam.
    /// <see href="https://w3id.org/seas/Sauna"></see></summary>
    let Sauna = _prefix "Sauna"
    /// <summary>
    /// Building site is a locale containing one or more separate buildings. They are zones.
    /// <see href="https://w3id.org/seas/SiteOfBuilding"></see></summary>
    let SiteOfBuilding = _prefix "SiteOfBuilding"
    /// <summary>
    /// A construction designed to bridge a large vertical distance by dividing it into smaller vertical distances, called steps.
    /// <see href="https://w3id.org/seas/Stairs"></see></summary>
    let Stairs = _prefix "Stairs"
    /// <summary>
    /// Places where items are stored. Examples: warehouses, reservoirs and silos.
    /// <see href="https://w3id.org/seas/StorageBuilding"></see></summary>
    let StorageBuilding = _prefix "StorageBuilding"
    /// <summary>
    /// Room for storage.
    /// <see href="https://w3id.org/seas/StorageRoom"></see></summary>
    let StorageRoom = _prefix "StorageRoom"
    /// <summary>
    /// A structure, either attached or integrated into a building, which allows enjoyment of the surrounding landscape while being sheltered from adverse weather.
    /// <see href="https://w3id.org/seas/Sunroom"></see></summary>
    let Sunroom = _prefix "Sunroom"
    /// <summary>
    /// A tank or large artificial basin, as of concrete, for filling with water for swimming.
    /// <see href="https://w3id.org/seas/SwimmingPool"></see></summary>
    let SwimmingPool = _prefix "SwimmingPool"
    /// <summary>
    /// A small house, especially one for children to play in, built or placed up in the branches of a tree.
    /// <see href="https://w3id.org/seas/TreeHouse"></see></summary>
    let TreeHouse = _prefix "TreeHouse"
    /// <summary>
    /// Room for other special utilities and hobbies.
    /// <see href="https://w3id.org/seas/UtilityRoom"></see></summary>
    let UtilityRoom = _prefix "UtilityRoom"
    /// <summary>
    /// A roof upwards tilted surface tilted up part of upper envelope of building.
    /// <see href="https://w3id.org/seas/Wall"></see></summary>
    let Wall = _prefix "Wall"
    /// <summary>
    /// a space or an zone of glass in the wall of a building or vehicle that lets in light (Longman Dictionary of Contemporary English Online)
    /// <see href="https://w3id.org/seas/Window"></see></summary>
    let Window = _prefix "Window"
    /// <summary>
    /// A small usually walled and often paved zone open to the sky and adjacent to a building.
    /// <see href="https://w3id.org/seas/Yard"></see></summary>
    let Yard = _prefix "Yard"
    /// <summary>
    /// A net zero-energy building (ZEB) is a building that over a year does not use more energy than it generates.
    /// <see href="https://w3id.org/seas/ZeroEnergyBuilding"></see></summary>
    let ZeroEnergyBuilding = _prefix "ZeroEnergyBuilding"
