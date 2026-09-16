#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module seasbo =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/seas/" "seasbo"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : AssemblyBuildingrdfs:label : Kokoontumisrakennus</para>
    ///   <para>rdfs:comment : places used for people gathering for entertainment, worship, and eating or drinking. Examples: churches, restaurants.</para>
    ///   <a href="https://w3id.org/seas/AssemblyBuilding">seasbo:AssemblyBuilding</a>
    /// </summary>
    let AssemblyBuilding = _prefixId.prefix "AssemblyBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Attic</para>
    ///   <para>rdfs:comment : the part of a building, especially of a house, directly under a roof; garret.</para>
    ///   <a href="https://w3id.org/seas/Attic">seasbo:Attic</a>
    /// </summary>
    let Attic = _prefixId.prefix "Attic"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Balcony</para>
    ///   <para>rdfs:comment : An accessible structure extending from a building, especially outside a window.</para>
    ///   <a href="https://w3id.org/seas/Balcony">seasbo:Balcony</a>
    /// </summary>
    let Balcony = _prefixId.prefix "Balcony"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Basement</para>
    ///   <para>rdfs:comment : A story of a building, partly or wholly underground.</para>
    ///   <a href="https://w3id.org/seas/Basement">seasbo:Basement</a>
    /// </summary>
    let Basement = _prefixId.prefix "Basement"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Bathroom</para>
    ///   <para>rdfs:comment : Bathroom is mainly used for bathing &amp;amp; washing up related activities.</para>
    ///   <a href="https://w3id.org/seas/Bathroom">seasbo:Bathroom</a>
    /// </summary>
    let Bathroom = _prefixId.prefix "Bathroom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Bedroom</para>
    ///   <para>rdfs:comment : Bedroom is used mainly for sleeping.</para>
    ///   <a href="https://w3id.org/seas/Bedroom">seasbo:Bedroom</a>
    /// </summary>
    let Bedroom = _prefixId.prefix "Bedroom"
    /// <summary>
    ///   <para>rdfs:comment : Buildings are roofed constructions which can be used separately, have been built for permanent purposes, can be entered by persons and are suitable or intended for protecting persons, animals or objects.</para>
    ///   <para>rdfs:label : Building</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="https://w3id.org/seas/Building">seasbo:Building</a>
    /// </summary>
    let Building = _prefixId.prefix "Building"
    let BuildingOntology = _prefixId.prefix "BuildingOntology"
    let BuildingOntology_0'_period_'9 = _prefixId.prefix "BuildingOntology-0.9"
    let BuildingOntology_1'_period_'0 = _prefixId.prefix "BuildingOntology-1.0"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : BuildingSpace</para>
    ///   <para>rdfs:comment : A Space is a 3D volume bounded by surfaces. According to the FIEMSER definition, a building space in SAREF defines the physical spaces of the building.</para>
    ///   <a href="https://w3id.org/seas/BuildingSpace">seasbo:BuildingSpace</a>
    /// </summary>
    let BuildingSpace = _prefixId.prefix "BuildingSpace"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Building Space Connection</para>
    ///   <para>rdfs:comment : Connection between two building spaces, where they may potentially exchange heat, humidity, agents.</para>
    ///   <a href="https://w3id.org/seas/BuildingSpaceConnection">seasbo:BuildingSpaceConnection</a>
    /// </summary>
    let BuildingSpaceConnection = _prefixId.prefix "BuildingSpaceConnection"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Building Space Frontier</para>
    ///   <para>rdfs:comment : Surface that marks the frontier of a building space, and represents the connection point to other building spaces.</para>
    ///   <a href="https://w3id.org/seas/BuildingSpaceFrontier">seasbo:BuildingSpaceFrontier</a>
    /// </summary>
    let BuildingSpaceFrontier = _prefixId.prefix "BuildingSpaceFrontier"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : BuildingSpatialStructure</para>
    ///   <para>rdfs:comment : A man made structure with spatial properties.</para>
    ///   <a href="https://w3id.org/seas/BuildingSpatialStructure">seasbo:BuildingSpatialStructure</a>
    /// </summary>
    let BuildingSpatialStructure = _prefixId.prefix "BuildingSpatialStructure"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : BuildingStorey</para>
    ///   <para>rdfs:comment : The storey represents a (nearly) horizontal aggregation of spaces that are vertically bound.</para>
    ///   <a href="https://w3id.org/seas/BuildingStorey">seasbo:BuildingStorey</a>
    /// </summary>
    let BuildingStorey = _prefixId.prefix "BuildingStorey"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Ceiling</para>
    ///   <para>rdfs:comment : Ceiling is a downwards tilted horizontal surface.</para>
    ///   <a href="https://w3id.org/seas/Ceiling">seasbo:Ceiling</a>
    /// </summary>
    let Ceiling = _prefixId.prefix "Ceiling"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : CivilEngnineeringWork</para>
    ///   <para>rdfs:comment : Civil engineering works are all constructions not classified under buildings : railways, roads, bridges, highways, airport runways, dams etc.</para>
    ///   <a href="https://w3id.org/seas/CivilEngineeringWork">seasbo:CivilEngineeringWork</a>
    /// </summary>
    let CivilEngineeringWork = _prefixId.prefix "CivilEngineeringWork"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Closed Building Space Connection</para>
    ///   <para>rdfs:comment : A closed building space connection is a closed connection between two building spaces.
    ///
    ///   This separation may for instance be a wall, i.e., a (tilted more than 60 percent) vertical surface.
    ///
    ///   Instances of `seas:ClosedBuildingSpaceConnection` may be typed by classes from specialized building ontologies.</para>
    ///   <a href="https://w3id.org/seas/ClosedBuildingSpaceConnection">seasbo:ClosedBuildingSpaceConnection</a>
    /// </summary>
    let ClosedBuildingSpaceConnection = _prefixId.prefix "ClosedBuildingSpaceConnection"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Construction</para>
    ///   <para>rdfs:comment : Constructions are structures connected with the ground which are made of construction materials and components and/or for which construction work is carried out.</para>
    ///   <a href="https://w3id.org/seas/Construction">seasbo:Construction</a>
    /// </summary>
    let Construction = _prefixId.prefix "Construction"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Corridor</para>
    ///   <para>rdfs:comment : A gallery or passage connecting parts of a building; hallway.</para>
    ///   <a href="https://w3id.org/seas/Corridor">seasbo:Corridor</a>
    /// </summary>
    let Corridor = _prefixId.prefix "Corridor"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Dining Room</para>
    ///   <para>rdfs:comment : A room in which meals are eaten, as in a home or hotel, especially the room in which the major or more formal meals are eaten.</para>
    ///   <a href="https://w3id.org/seas/DiningRoom">seasbo:DiningRoom</a>
    /// </summary>
    let DiningRoom = _prefixId.prefix "DiningRoom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Door</para>
    ///   <para>rdfs:comment : the large flat piece of wood, glass etc that you move when you go into or out of a building, room, vehicle etc, or when you open a cupboard (Longman Dictionary of Contemporary English Online)</para>
    ///   <a href="https://w3id.org/seas/Door">seasbo:Door</a>
    /// </summary>
    let Door = _prefixId.prefix "Door"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : EducationalBuildingrdfs:label : Opetusrakennus</para>
    ///   <para>rdfs:comment : Schools and day care centers.</para>
    ///   <a href="https://w3id.org/seas/EducationalBuilding">seasbo:EducationalBuilding</a>
    /// </summary>
    let EducationalBuilding = _prefixId.prefix "EducationalBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Elevator</para>
    ///   <para>rdfs:comment : Elevator is used to transport people between different floors.</para>
    ///   <a href="https://w3id.org/seas/Elevator">seasbo:Elevator</a>
    /// </summary>
    let Elevator = _prefixId.prefix "Elevator"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Floor</para>
    ///   <para>rdfs:comment : A floor is a upwards tilted horzontal surface, could be divided to interior, exposed (outside) or raised floor.</para>
    ///   <a href="https://w3id.org/seas/Floor">seasbo:Floor</a>
    /// </summary>
    let Floor = _prefixId.prefix "Floor"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Garage</para>
    ///   <para>rdfs:comment : Room for garage.</para>
    ///   <a href="https://w3id.org/seas/Garage">seasbo:Garage</a>
    /// </summary>
    let Garage = _prefixId.prefix "Garage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Greenhouse</para>
    ///   <para>rdfs:comment : A building, room, or zone, usually chiefly of glass, in which the temperature is maintained within a desired range, used for cultivating tender plants or growing plants out of season.</para>
    ///   <a href="https://w3id.org/seas/Greenhouse">seasbo:Greenhouse</a>
    /// </summary>
    let Greenhouse = _prefixId.prefix "Greenhouse"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Hall</para>
    ///   <para>rdfs:comment : A large entrance room of a house or building.</para>
    ///   <a href="https://w3id.org/seas/Hall">seasbo:Hall</a>
    /// </summary>
    let Hall = _prefixId.prefix "Hall"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : HolidayBuildingrdfs:label : VapaaAjanRakennus</para>
    ///   <para>rdfs:comment : A secondary residential building used only occasionally during vacations such as a summerhouse or cottage. </para>
    ///   <a href="https://w3id.org/seas/HolidayBuilding">seasbo:HolidayBuilding</a>
    /// </summary>
    let HolidayBuilding = _prefixId.prefix "HolidayBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Tree house</para>
    ///   <para>rdfs:comment : A work or office space set up in a person's home and used exclusively for business on a regular basis.</para>
    ///   <a href="https://w3id.org/seas/HomeOffice">seasbo:HomeOffice</a>
    /// </summary>
    let HomeOffice = _prefixId.prefix "HomeOffice"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : IndustrialBuilding</para>
    ///   <para>rdfs:comment : Buildings used for industrial production, e.g. factories, workshops, slaughterhouses, breweries, assembly plants, etc.</para>
    ///   <a href="https://w3id.org/seas/IndustrialBuilding">seasbo:IndustrialBuilding</a>
    /// </summary>
    let IndustrialBuilding = _prefixId.prefix "IndustrialBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : InstitutionalBuildingrdfs:label : HoitoalanRakennus</para>
    ///   <para>rdfs:comment : Institutions such as hospitals providing medical and surgical treatment and nursing care for ill or injured people.</para>
    ///   <a href="https://w3id.org/seas/InstitutionalBuilding">seasbo:InstitutionalBuilding</a>
    /// </summary>
    let InstitutionalBuilding = _prefixId.prefix "InstitutionalBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Kitchen</para>
    ///   <para>rdfs:comment : Kitchen is a room used mainly for cooking and possibly eating.</para>
    ///   <a href="https://w3id.org/seas/Kitchen">seasbo:Kitchen</a>
    /// </summary>
    let Kitchen = _prefixId.prefix "Kitchen"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Laundry</para>
    ///   <para>rdfs:comment : A room or zone, as in a home or apartment building, reserved for doing the family wash.</para>
    ///   <a href="https://w3id.org/seas/Laundry">seasbo:Laundry</a>
    /// </summary>
    let Laundry = _prefixId.prefix "Laundry"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Living Room</para>
    ///   <para>rdfs:comment : Living Room is the main room of daytime activity.</para>
    ///   <a href="https://w3id.org/seas/LivingRoom">seasbo:LivingRoom</a>
    /// </summary>
    let LivingRoom = _prefixId.prefix "LivingRoom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Lobby</para>
    ///   <para>rdfs:comment : An entrance hall, corridor, or vestibule, as in a public building, often serving as an anteroom; foyer.</para>
    ///   <a href="https://w3id.org/seas/Lobby">seasbo:Lobby</a>
    /// </summary>
    let Lobby = _prefixId.prefix "Lobby"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : LowEnergyHouserdfs:label : Matalaenergiatalo</para>
    ///   <para>rdfs:comment : A house typically consuming half the energy than a norm house.</para>
    ///   <a href="https://w3id.org/seas/LowEnergyHouse">seasbo:LowEnergyHouse</a>
    /// </summary>
    let LowEnergyHouse = _prefixId.prefix "LowEnergyHouse"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : MercantileBuildingrdfs:label : Liikerakennus</para>
    ///   <para>rdfs:comment : Places where goods are displayed and sold. Examples: grocery stores, department stores, and gas stations.</para>
    ///   <a href="https://w3id.org/seas/MercantileBuilding">seasbo:MercantileBuilding</a>
    /// </summary>
    let MercantileBuilding = _prefixId.prefix "MercantileBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : NonResidentalBuilding</para>
    ///   <para>rdfs:comment : A  non-residential building is a building at least half of which is used for other than residential purposes. </para>
    ///   <a href="https://w3id.org/seas/NonResidentalBuilding">seasbo:NonResidentalBuilding</a>
    /// </summary>
    let NonResidentalBuilding = _prefixId.prefix "NonResidentalBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : NormHouserdfs:label : Normitalo</para>
    ///   <para>rdfs:comment : A building fulfilling the minimal criteria for energy efficiency.</para>
    ///   <a href="https://w3id.org/seas/NormHouse">seasbo:NormHouse</a>
    /// </summary>
    let NormHouse = _prefixId.prefix "NormHouse"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Office</para>
    ///   <para>rdfs:comment : A room, set of rooms, or building where the business of a commercial or industrial organization or of a professional person is conducted.</para>
    ///   <a href="https://w3id.org/seas/Office">seasbo:Office</a>
    /// </summary>
    let Office = _prefixId.prefix "Office"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : BusinessBuildingrdfs:label : Toimistorakennus</para>
    ///   <para>rdfs:comment : Places where services are provided. Examples: banks, insurance agencies.</para>
    ///   <a href="https://w3id.org/seas/OfficeBuilding">seasbo:OfficeBuilding</a>
    /// </summary>
    let OfficeBuilding = _prefixId.prefix "OfficeBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : OneDwellingBuildingrdfs:label : YhdenAsunnonTalo</para>
    ///   <para>rdfs:comment : Detached house.</para>
    ///   <a href="https://w3id.org/seas/OneDwellingBuilding">seasbo:OneDwellingBuilding</a>
    /// </summary>
    let OneDwellingBuilding = _prefixId.prefix "OneDwellingBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Open Building Space Connection</para>
    ///   <para>rdfs:comment : An open building space connection is a connection between two building spaces that is open.
    ///
    ///   This connection may for instance be a hole in a wall, or a virtual separation between two offices in an open space.
    ///
    ///   Instances of `seas:OpenBuildingSpaceConnection` may be typed by classes from specialized building ontologies.</para>
    ///   <a href="https://w3id.org/seas/OpenBuildingSpaceConnection">seasbo:OpenBuildingSpaceConnection</a>
    /// </summary>
    let OpenBuildingSpaceConnection = _prefixId.prefix "OpenBuildingSpaceConnection"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Opennable Building Space Connection</para>
    ///   <para>rdfs:comment : An opennable building space connection is a connection between two building spaces that has a certain degree of openness.
    ///
    ///   This connection may for instance be a window or a door.
    ///
    ///   Instances of `seas:OpennableBuildingSpaceConnection` may be typed by classes from specialized building ontologies.</para>
    ///   <a href="https://w3id.org/seas/OpennableBuildingSpaceConnection">seasbo:OpennableBuildingSpaceConnection</a>
    /// </summary>
    let OpennableBuildingSpaceConnection = _prefixId.prefix "OpennableBuildingSpaceConnection"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : PassiveHouserdfs:label : Passiivitalo</para>
    ///   <para>rdfs:comment : A house typically consuming a quarter of the energy than a norm house.</para>
    ///   <a href="https://w3id.org/seas/PassiveHouse">seasbo:PassiveHouse</a>
    /// </summary>
    let PassiveHouse = _prefixId.prefix "PassiveHouse"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : PlusEnergyBuildingrdfs:label : Plusenergiatalo</para>
    ///   <para>rdfs:comment : A net plus-energy building is a building that over a year does generates more energy than it uses. </para>
    ///   <a href="https://w3id.org/seas/PlusEnergyBuilding">seasbo:PlusEnergyBuilding</a>
    /// </summary>
    let PlusEnergyBuilding = _prefixId.prefix "PlusEnergyBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : PowerplantBuildingrdfs:label : VoimalaRakennus</para>
    ///   <para>rdfs:comment : Places housing any type of a power plants.</para>
    ///   <a href="https://w3id.org/seas/PowerplantBuilding">seasbo:PowerplantBuilding</a>
    /// </summary>
    let PowerplantBuilding = _prefixId.prefix "PowerplantBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : ResidentalBuildingrdfs:label : Asuinrakennus</para>
    ///   <para>rdfs:comment : A residential building is a building at least half of which is used for residential purposes. </para>
    ///   <a href="https://w3id.org/seas/ResidentalBuilding">seasbo:ResidentalBuilding</a>
    /// </summary>
    let ResidentalBuilding = _prefixId.prefix "ResidentalBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Roof</para>
    ///   <para>rdfs:comment : A (tilted more than 60 percent) vertical surface that separates building spaces.</para>
    ///   <a href="https://w3id.org/seas/Roof">seasbo:Roof</a>
    /// </summary>
    let Roof = _prefixId.prefix "Roof"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Room</para>
    ///   <para>rdfs:comment : A room in a building space enclosed by surfaces, this could also be modelled as role of space, not subclass of the space itself.</para>
    ///   <a href="https://w3id.org/seas/Room">seasbo:Room</a>
    /// </summary>
    let Room = _prefixId.prefix "Room"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Sauna</para>
    ///   <para>rdfs:comment : Sauna is a special type bathroom for enjoying heated steam.</para>
    ///   <a href="https://w3id.org/seas/Sauna">seasbo:Sauna</a>
    /// </summary>
    let Sauna = _prefixId.prefix "Sauna"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : SiteOfBuilding</para>
    ///   <para>rdfs:comment : Building site is a locale containing one or more separate buildings. They are zones.</para>
    ///   <a href="https://w3id.org/seas/SiteOfBuilding">seasbo:SiteOfBuilding</a>
    /// </summary>
    let SiteOfBuilding = _prefixId.prefix "SiteOfBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : SmallHouserdfs:label : Pientalo</para>
    ///   <para>rdfs:comment : A detached small residential building.</para>
    ///   <a href="https://w3id.org/seas/SmallHouse">seasbo:SmallHouse</a>
    /// </summary>
    let SmallHouse = _prefixId.prefix "SmallHouse"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Stairs</para>
    ///   <para>rdfs:comment : A construction designed to bridge a large vertical distance by dividing it into smaller vertical distances, called steps.</para>
    ///   <a href="https://w3id.org/seas/Stairs">seasbo:Stairs</a>
    /// </summary>
    let Stairs = _prefixId.prefix "Stairs"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : StorageBuildingrdfs:label : VarastoRakennus</para>
    ///   <para>rdfs:comment : Places where items are stored. Examples: warehouses, reservoirs and silos.</para>
    ///   <a href="https://w3id.org/seas/StorageBuilding">seasbo:StorageBuilding</a>
    /// </summary>
    let StorageBuilding = _prefixId.prefix "StorageBuilding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Storage Room</para>
    ///   <para>rdfs:comment : Room for storage.</para>
    ///   <a href="https://w3id.org/seas/StorageRoom">seasbo:StorageRoom</a>
    /// </summary>
    let StorageRoom = _prefixId.prefix "StorageRoom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Swimming Pool</para>
    ///   <para>rdfs:comment : A structure, either attached or integrated into a building, which allows enjoyment of the surrounding landscape while being sheltered from adverse weather.</para>
    ///   <a href="https://w3id.org/seas/Sunroom">seasbo:Sunroom</a>
    /// </summary>
    let Sunroom = _prefixId.prefix "Sunroom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Swimming Pool</para>
    ///   <para>rdfs:comment : A tank or large artificial basin, as of concrete, for filling with water for swimming.</para>
    ///   <a href="https://w3id.org/seas/SwimmingPool">seasbo:SwimmingPool</a>
    /// </summary>
    let SwimmingPool = _prefixId.prefix "SwimmingPool"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Tree House</para>
    ///   <para>rdfs:comment : A small house, especially one for children to play in, built or placed up in the branches of a tree.</para>
    ///   <a href="https://w3id.org/seas/TreeHouse">seasbo:TreeHouse</a>
    /// </summary>
    let TreeHouse = _prefixId.prefix "TreeHouse"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Utility Room</para>
    ///   <para>rdfs:comment : Room for other special utilities and hobbies.</para>
    ///   <a href="https://w3id.org/seas/UtilityRoom">seasbo:UtilityRoom</a>
    /// </summary>
    let UtilityRoom = _prefixId.prefix "UtilityRoom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Wall</para>
    ///   <para>rdfs:comment : A roof upwards tilted surface tilted up part of upper envelope of building.</para>
    ///   <a href="https://w3id.org/seas/Wall">seasbo:Wall</a>
    /// </summary>
    let Wall = _prefixId.prefix "Wall"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Window</para>
    ///   <para>rdfs:comment : a space or an zone of glass in the wall of a building or vehicle that lets in light (Longman Dictionary of Contemporary English Online)</para>
    ///   <a href="https://w3id.org/seas/Window">seasbo:Window</a>
    /// </summary>
    let Window = _prefixId.prefix "Window"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Yard</para>
    ///   <para>rdfs:comment : A small usually walled and often paved zone open to the sky and adjacent to a building.</para>
    ///   <a href="https://w3id.org/seas/Yard">seasbo:Yard</a>
    /// </summary>
    let Yard = _prefixId.prefix "Yard"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : ZeroEnergyBuildingrdfs:label : Nollaenergiatalo</para>
    ///   <para>rdfs:comment : A net zero-energy building (ZEB) is a building that over a year does not use more energy than it generates. </para>
    ///   <a href="https://w3id.org/seas/ZeroEnergyBuilding">seasbo:ZeroEnergyBuilding</a>
    /// </summary>
    let ZeroEnergyBuilding = _prefixId.prefix "ZeroEnergyBuilding"
    let Zone = _prefixId.prefix "Zone"
    let ZoneConnection = _prefixId.prefix "ZoneConnection"
    let ZoneFrontier = _prefixId.prefix "ZoneFrontier"
    let ZoneOntology = _prefixId.prefix "ZoneOntology"
    let connectionPointOf = _prefixId.prefix "connectionPointOf"
    let connectsSystem = _prefixId.prefix "connectsSystem"
    let connectsSystemAt = _prefixId.prefix "connectsSystemAt"
    let connectsSystemThrough = _prefixId.prefix "connectsSystemThrough"
