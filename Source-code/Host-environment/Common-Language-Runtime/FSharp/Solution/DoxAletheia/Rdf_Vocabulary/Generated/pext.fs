namespace http.www.ontotext.com.proton.protonext.hash

open DoxAletheia

module pext =
    let _namespace_name = "http://www.ontotext.com/proton/protonext#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An unattended electronic machine in a public place, connected to a data system and related equipment and activated by a bank customer to obtain cash withdrawals and other banking services.
    /// <see href="http://www.ontotext.com/proton/protonext#ATM"></see></summary>
    let ATM = _prefix "ATM"
    /// <summary>
    /// (ADL FT: Telecommunication Features) We use this category for antenna field sites; for communication centers; for radio stations; for television stations; and for transmission lines. NIMA GNS designators COMC, STNR, STNS.
    /// <see href="http://www.ontotext.com/proton/protonext#TelecomFacility"></see></summary>
    let TelecomFacility = _prefix "TelecomFacility"
    /// <summary>
    /// A journal publishing scientific articles
    /// <see href="http://www.ontotext.com/proton/protonext#AcademicJournal"></see></summary>
    let AcademicJournal = _prefix "AcademicJournal"
    /// <summary>
    /// A periodic paperback publication; "it takes several years before a magazine starts to break even or make money"), WordNet 1.7.1. This includes also journals and digests. The specific issues typically contain a number of different articles.
    /// <see href="http://www.ontotext.com/proton/protonext#Magazine"></see></summary>
    let Magazine = _prefix "Magazine"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#Accident"></see>
    /// </summary>
    let Accident = _prefix "Accident"
    /// <summary>
    /// An explicit agreement between agents. Typically, service providers (e.g. banks or ISPs) provide accounts to their customers or users, which are considered account owners. The existence of the account depends on the provider, even though the user owns it in some metaphoric sense. Examples could be bank, ISP, e-Commerce, ICQ, email accounts. The accounts are usually aligned with a sort of contract.
    /// <see href="http://www.ontotext.com/proton/protonext#Account"></see></summary>
    let Account = _prefix "Account"
    /// <summary>
    /// The event of the acquiring of one organization by another.
    /// <see href="http://www.ontotext.com/proton/protonext#Acquirement"></see></summary>
    let Acquirement = _prefix "Acquirement"
    /// <summary>
    /// Each activity is a Happening which involves volition and participants. It has temporal dimension. It is distinguished from Events by the fact that the activity does not trigger change of state and does not have a conceptual end point.
    /// <see href="http://www.ontotext.com/proton/protonext#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    /// Any actor acts in a dramatic production and who works in film, television, theatre, or radio in that capacity. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Actor"></see></summary>
    let Actor = _prefix "Actor"
    /// <summary>
    /// A profession in the area of art.
    /// <see href="http://www.ontotext.com/proton/protonext#ArtProfession"></see></summary>
    let ArtProfession = _prefix "ArtProfession"
    /// <summary>
    /// Any sort of address, specifying how to locate something somewhere.
    /// <see href="http://www.ontotext.com/proton/protonext#Address"></see></summary>
    let Address = _prefix "Address"
    /// <summary>
    /// Any administrative region. NIMA GNS designators - PCLIX
    /// <see href="http://www.ontotext.com/proton/protonext#AdministrativeRegion"></see></summary>
    let AdministrativeRegion = _prefix "AdministrativeRegion"
    /// <summary>
    /// (ADL FT) Places or areas with clustered or scattered buildings and a permanent human population. ... We use this category for agricultural colonies; for communes; for communities; for hamlets; for homesteads; for locales; for localities; for metropolitan areas; for populated localities; for ppl; for pueblos; for settlements; for suburbs; for villages; and with religious facilities for religious populated places. NIMA GNS designator PPL, PPL(x)
    /// <see href="http://www.ontotext.com/proton/protonext#PopulatedPlace"></see></summary>
    let PopulatedPlace = _prefix "PopulatedPlace"
    /// <summary>
    /// A tract of land set aside for agricultural settlement. NIMA GNS designator L.AGRC.
    /// <see href="http://www.ontotext.com/proton/protonext#AgriculturalColony"></see></summary>
    let AgriculturalColony = _prefix "AgriculturalColony"
    /// <summary>
    /// Any sort of land regions which are sort of natural, i.e. excluding urban areas, political and administrative regions. It combines number of ADL feature types under Physiographic features and Regions. Omitted ADL sub-classes: Badlands, Bars, Basins, Bight, Cirques, Cliffs, Dunes, Flats, Karst areas. Ledges, Massifs, Mineral deposit areas, Moraines, Natural rock formations, Arches, Playas, Seafloor Features, Tectonic features, Volcanic features (Volcano put under Mountain), Subcontinents. NIMA GNS designators FSR, FURU, HMCK, PLDR, RKFL, SINK, SLID, SLP, SLPU, TERU, TRR.
    /// <see href="http://www.ontotext.com/proton/protonext#LandRegion"></see></summary>
    let LandRegion = _prefix "LandRegion"
    /// <summary>
    /// An agricultural facility; a building and/or tract of land used for improving agriculture
    /// <see href="http://www.ontotext.com/proton/protonext#AgriculturalFacility"></see></summary>
    let AgriculturalFacility = _prefix "AgriculturalFacility"
    /// <summary>
    /// (ADL FT: Manmade Features, no def) Any regions and locations determined artificially, as a result of human activity. Many of the ADL sub-classes are omitted. NIMA GNS - no direct equivalent, although many sub-types are defined as classes (S, R) and designators.
    /// <see href="http://www.ontotext.com/proton/protonext#Facility"></see></summary>
    let Facility = _prefix "Facility"
    /// <summary>
    /// An area used to store supplies, provide barracks for air force personnel, hangars and runways for aircraft, and from which operations are initiated
    /// <see href="http://www.ontotext.com/proton/protonext#Airbase"></see></summary>
    let Airbase = _prefix "Airbase"
    /// <summary>
    /// (ADL FTT) We use this category for air force bases; for army facilities; for arsenals; for artillery ranges; for barracks; for bases (military); for camps (military); for forts; for infantry camps; for maneuver areas; for military bases; for military installations; for national guard facilities; and for naval bases. The following NIMA designators fit here: MILB, INSM, SCHM. The following ADL types are skipped as irrelevant: Cadastral areas,
    /// <see href="http://www.ontotext.com/proton/protonext#MilitaryAreas"></see></summary>
    let MilitaryAreas = _prefix "MilitaryAreas"
    /// <summary>
    /// A company providing air transport services.
    /// <see href="http://www.ontotext.com/proton/protonext#Airline"></see></summary>
    let Airline = _prefix "Airline"
    /// <summary>
    /// A private, legal, corporate entity with the legal rights to own property, manage itself, and sue or be sued. It is established by a charter or registration granted by the government.
    /// <see href="http://www.ontotext.com/proton/protonext#Company"></see></summary>
    let Company = _prefix "Company"
    /// <summary>
    /// Engines of airplanes
    /// <see href="http://www.ontotext.com/proton/protonext#AirplaneEngine"></see></summary>
    let AirplaneEngine = _prefix "AirplaneEngine"
    /// <summary>
    /// Any produced device with particular purpose that uses energy to perform some activity. The device has parts that perform or assist in performing any type of work. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Machine"></see></summary>
    let Machine = _prefix "Machine"
    /// <summary>
    /// A concrete model of an airplane which determines the main features of any airplane of this model. For example, Boeing 737, Airbus A330, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#AirplaneModel"></see></summary>
    let AirplaneModel = _prefix "AirplaneModel"
    /// <summary>
    /// An airport, including heliports. NIMA GNS designators AIRP, AIRH.
    /// <see href="http://www.ontotext.com/proton/protonext#Airport"></see></summary>
    let Airport = _prefix "Airport"
    /// <summary>
    /// (ADL FT: Transportation Features) We use this category for air routes; for caravan routes; for corridors; for crossings; for depots; for ferries; for fords (crossings); for fuel depots; for gates (manmade); for halting places (transportation); for highway maintenance sites; for portages; for rest houses; for routes; for ship tracks; for stock routes; for terminals (transportation); and for transit facilities. Omitted sub-classes: Aqueducts, Cableways, Parking Sites. NIMA GNS designator - no direct equivalents.
    /// <see href="http://www.ontotext.com/proton/protonext#TransportFacility"></see></summary>
    let TransportFacility = _prefix "TransportFacility"
    /// <summary>
    /// An recording of a several songs. Usually from the same singer.
    /// <see href="http://www.ontotext.com/proton/protonext#Album"></see></summary>
    let Album = _prefix "Album"
    /// <summary>
    /// An recording of a piece of music.
    /// <see href="http://www.ontotext.com/proton/protonext#AudioRecording"></see></summary>
    let AudioRecording = _prefix "AudioRecording"
    /// <summary>
    /// A type (specific receipe) for a beverage. For instance: Guiness Beer, Absolut Currant, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#AlcoholicBeverage"></see></summary>
    let AlcoholicBeverage = _prefix "AlcoholicBeverage"
    /// <summary>
    /// Any liquid suitable for drinking (WordNet, 1.7). The instances of this class are types of drinks, specific receipts. For instance: Diet Coke, Bacardi Spice.
    /// <see href="http://www.ontotext.com/proton/protonext#Beverage"></see></summary>
    let Beverage = _prefix "Beverage"
    /// <summary>
    /// Any ambassador, a title of a position of representing a country abroad
    /// <see href="http://www.ontotext.com/proton/protonext#Ambassador"></see></summary>
    let Ambassador = _prefix "Ambassador"
    /// <summary>
    /// The name of a position a person holds within an organization.
    /// <see href="http://www.ontotext.com/proton/protonext#JobTitle"></see></summary>
    let JobTitle = _prefix "JobTitle"
    /// <summary>
    /// Any American football league
    /// <see href="http://www.ontotext.com/proton/protonext#AmericanFootballLeague"></see></summary>
    let AmericanFootballLeague = _prefix "AmericanFootballLeague"
    /// <summary>
    /// Any sports league, a group of sports teams or individual athletes that compete against each other in a specific sport. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#SportsLeague"></see></summary>
    let SportsLeague = _prefix "SportsLeague"
    /// <summary>
    /// Any player of American football.
    /// <see href="http://www.ontotext.com/proton/protonext#AmericanFootballPlayer"></see></summary>
    let AmericanFootballPlayer = _prefix "AmericanFootballPlayer"
    /// <summary>
    /// A profession of a person involved in a sport.
    /// <see href="http://www.ontotext.com/proton/protonext#Sportsman"></see></summary>
    let Sportsman = _prefix "Sportsman"
    /// <summary>
    /// Any American Football Team
    /// <see href="http://www.ontotext.com/proton/protonext#AmericanFootballTeam"></see></summary>
    let AmericanFootballTeam = _prefix "AmericanFootballTeam"
    /// <summary>
    /// A group of people gathered for some task, say a project. Teams are usually not formally established and not meant to perform as a single agent for purposes outside the scope of their task. Teams may "live" within organizations, spread between multiple organizations, or be independent form any organization.
    /// <see href="http://www.ontotext.com/proton/protonext#Team"></see></summary>
    let Team = _prefix "Team"
    /// <summary>
    /// Amphibian denotes animals such as frogs, salamanders, and caecilians, that are ectothermic (or cold-blooded) animals and metamorphose from a juvenile water-breathing form, either to an adult air-breathing form, or to a paedomorph that retains some juvenile characteristics. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Amphibian"></see></summary>
    let Amphibian = _prefix "Amphibian"
    /// <summary>
    /// Animals are a major group of multicellular, eukaryotic organisms. Their body plan eventually becomes fixed as they develop. Most animals are motile. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Animal"></see></summary>
    let Animal = _prefix "Animal"
    /// <summary>
    /// (ADL FT) Commercially operated enterprises that offer rides, games, and other forms of entertainment. NIMA GNS designator - no equivalents.
    /// <see href="http://www.ontotext.com/proton/protonext#AmusementPark"></see></summary>
    let AmusementPark = _prefix "AmusementPark"
    /// <summary>
    /// (ADL FT) We use this category for access areas; for access sites; for boardwalks; for casinos; for clubs (recreational); for country clubs; for fairgrounds; for fishing areas; for fishing lodges; for fitness centers; for gun clubs; for hunt posts; for hunting lodges; for ice skating rinks; for playgrounds; for recreation sites; for resorts; for riding stables; for spas; for sportsman lodges; for stables; for yacht clubs; for youth centers; and for youth facilities. NIMA GNS designators - no direct equivalents.
    /// <see href="http://www.ontotext.com/proton/protonext#RecreationalFacility"></see></summary>
    let RecreationalFacility = _prefix "RecreationalFacility"
    /// <summary>
    /// Living object is any organism which is living, e.g. breathing and regular lifecycle.
    /// <see href="http://www.ontotext.com/proton/protonext#LivingObject"></see></summary>
    let LivingObject = _prefix "LivingObject"
    /// <summary>
    /// A formal public statement; "the government made an announcement about the changes in the drug war" ; "a declaration of independence".) WordNet 1.7.1
    /// <see href="http://www.ontotext.com/proton/protonext#Announcement"></see></summary>
    let Announcement = _prefix "Announcement"
    /// <summary>
    /// A document that is published or intended for publishing
    /// <see href="http://www.ontotext.com/proton/protonext#PublishedMaterial"></see></summary>
    let PublishedMaterial = _prefix "PublishedMaterial"
    /// <summary>
    /// Arachnid denotes a class of joint-legged invertebrate animals in the subphylum Chelicerata. All arachnids have eight legs, although in some species the front pair may convert to a sensory function. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Arachnid"></see></summary>
    let Arachnid = _prefix "Arachnid"
    /// <summary>
    /// A natural or man-made structure in the form of an arch
    /// <see href="http://www.ontotext.com/proton/protonext#Arch"></see></summary>
    let Arch = _prefix "Arch"
    /// <summary>
    /// Archaea (archeon) are a group of single-celled microorganisms without a cell nucleus or any other membrane-bound organelles (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Archaea"></see></summary>
    let Archaea = _prefix "Archaea"
    /// <summary>
    /// (ADL FT) Seas or areas in a sea that contain numerous islands; also, the island groups themselves. NIMA GNS designator - no equivalent.
    /// <see href="http://www.ontotext.com/proton/protonext#Archipelago"></see></summary>
    let Archipelago = _prefix "Archipelago"
    /// <summary>
    /// Any architect, a profession of planning, design and oversight of the construction of buildings. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Architect"></see></summary>
    let Architect = _prefix "Architect"
    /// <summary>
    /// A profession is a vocation founded upon specialized educational training. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#Profession"></see></summary>
    let Profession = _prefix "Profession"
    /// <summary>
    /// Any arena
    /// <see href="http://www.ontotext.com/proton/protonext#Arena"></see></summary>
    let Arena = _prefix "Arena"
    /// <summary>
    /// (ADL FT) Permanent constructions that are roofed and usually walled. [USGS Circ 1048] We use this category for administrative facilities; for administrative facilities; for animal pounds; for animal shelters; for aquariums; for barns; for border posts; for cabins; for castles; for city halls; for civic centers; for civil buildings; for club houses; for coast guard stations; for commissaries; for community centers; for community houses; for conference facilities; for consulates; for convention centers; for customs houses; for customs posts; for depots; for embassy buildings; for exhibition buildings; for facilities; for facility centers; for fire stations; for firehouses; for forest stations; for government buildings; for guard stations; for halls; for headquarters; for hostels; for hotels; for houses; for inns; for inspection stations; for legation buildings; for lodges; for missions; for motels; for neighborhood centers; for offices; for park headquarters; for patrol posts; for pavilions; for planetariums; for plazas; for police posts; for public buildings; for ranger stations; for restaurants; for shelters; for shops; for stations; for structures; for student unions; for studios; for substations; for taverns; for town halls; for trading posts; for treatment plants; for United States Government establishments; for visitor centers; for walls; and for warehouses NIMA GNS designator BLDG.
    /// <see href="http://www.ontotext.com/proton/protonext#Building"></see></summary>
    let Building = _prefix "Building"
    /// <summary>
    /// Art is the product or process of deliberately arranging items (often with symbolic significance) in a way that influences and affects one or more of the senses, emotions, and intellect. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#Art"></see></summary>
    let Art = _prefix "Art"
    /// <summary>
    /// Any sort of general social phenomenon, such as particular sort of art or science
    /// <see href="http://www.ontotext.com/proton/protonext#SocialAbstraction"></see></summary>
    let SocialAbstraction = _prefix "SocialAbstraction"
    /// <summary>
    /// A specific performance taking place at some moment, somewhere. Quite often starting at 19:00 in the theatre, stadium, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#ArtPerformance"></see></summary>
    let ArtPerformance = _prefix "ArtPerformance"
    /// <summary>
    /// Any artery as a part of the body.
    /// <see href="http://www.ontotext.com/proton/protonext#Artery"></see></summary>
    let Artery = _prefix "Artery"
    /// <summary>
    /// Any part of the body of any living entity
    /// <see href="http://www.ontotext.com/proton/protonext#BodyPart"></see></summary>
    let BodyPart = _prefix "BodyPart"
    /// <summary>
    /// A relatively short document published as a part of Resource Collection.
    /// <see href="http://www.ontotext.com/proton/protonext#Article"></see></summary>
    let Article = _prefix "Article"
    /// <summary>
    /// A satellite created by humans
    /// <see href="http://www.ontotext.com/proton/protonext#ArtificialSatellite"></see></summary>
    let ArtificialSatellite = _prefix "ArtificialSatellite"
    /// <summary>
    /// An astronomic object orbiting around a planet or star. Definition partly derived from WordNet 1.7
    /// <see href="http://www.ontotext.com/proton/protonext#Satellite"></see></summary>
    let Satellite = _prefix "Satellite"
    /// <summary>
    /// Any artist a profession engaging in a broad spectrum of activities related to creating art, practicing the arts and/or demonstrating an art. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Artist"></see></summary>
    let Artist = _prefix "Artist"
    /// <summary>
    /// Asteroids are a class of small Solar System bodies in orbit around the Sun. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#Asteroid"></see></summary>
    let Asteroid = _prefix "Asteroid"
    /// <summary>
    /// Any object studied by astronomers, (usually quite large natural and inanimate) object that is located in the physical universe and is not on the surface of the Earth. Definition partly derived from OpenCyc 0.7
    /// <see href="http://www.ontotext.com/proton/protonext#AstronomicalObject"></see></summary>
    let AstronomicalObject = _prefix "AstronomicalObject"
    /// <summary>
    /// Any astronaut, a profession allowing to command, pilot, or serve as a crew member of a spacecraft. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Astronaut"></see></summary>
    let Astronaut = _prefix "Astronaut"
    /// <summary>
    /// Any athlete, a profession involving sport activities.
    /// <see href="http://www.ontotext.com/proton/protonext#Athlete"></see></summary>
    let Athlete = _prefix "Athlete"
    /// <summary>
    /// Any atoll
    /// <see href="http://www.ontotext.com/proton/protonext#Atoll"></see></summary>
    let Atoll = _prefix "Atoll"
    /// <summary>
    /// (ADL FT) Tracts of land smaller than a continent, surrounded by the water of an ocean, sea, lake or stream. [Glossary of Geology, 4th ed.] We use this category for atolls; for cays; for island arcs; for isles; for islets; for keys (islands); for land-tied islands; and for mangrove islands. NIMA GNS designator ISL, ISLF, ISLM, ISLS, ISLT, ISLX
    /// <see href="http://www.ontotext.com/proton/protonext#Island"></see></summary>
    let Island = _prefix "Island"
    /// <summary>
    /// An original piece of music.
    /// <see href="http://www.ontotext.com/proton/protonext#MusicalComposition"></see></summary>
    let MusicalComposition = _prefix "MusicalComposition"
    /// <summary>
    /// Any Australian football league
    /// <see href="http://www.ontotext.com/proton/protonext#AustralianFootballLeague"></see></summary>
    let AustralianFootballLeague = _prefix "AustralianFootballLeague"
    /// <summary>
    /// The profession of an australian rules football player
    /// <see href="http://www.ontotext.com/proton/protonext#AustralianRulesFootballPlayer"></see></summary>
    let AustralianRulesFootballPlayer = _prefix "AustralianRulesFootballPlayer"
    /// <summary>
    /// Any Auto Racing league
    /// <see href="http://www.ontotext.com/proton/protonext#AutoRacingLeague"></see></summary>
    let AutoRacingLeague = _prefix "AutoRacingLeague"
    /// <summary>
    /// Engines of automobiles
    /// <see href="http://www.ontotext.com/proton/protonext#AutomobileEngine"></see></summary>
    let AutomobileEngine = _prefix "AutomobileEngine"
    /// <summary>
    /// Any award. An award is something given to a person or a group of people to recognize excellence in a certain field; a certificate of excellence, for example trophies, titles, medals, badges, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Award"></see></summary>
    let Award = _prefix "Award"
    /// <summary>
    /// Bacteria is a single-celled, prokaryote microorganisms, typically a few micrometres in length (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Bacteria"></see></summary>
    let Bacteria = _prefix "Bacteria"
    /// <summary>
    /// The profession of badminton player
    /// <see href="http://www.ontotext.com/proton/protonext#BadmintonPlayer"></see></summary>
    let BadmintonPlayer = _prefix "BadmintonPlayer"
    /// <summary>
    /// Any band, a group performing music or other activity together.
    /// <see href="http://www.ontotext.com/proton/protonext#Band"></see></summary>
    let Band = _prefix "Band"
    /// <summary>
    /// A business establishment in which money is kept for saving or commercial purposes or is invested, supplied for loans, or exchanged.
    /// A company providing financial services like credits, deposits, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Bank"></see></summary>
    let Bank = _prefix "Bank"
    /// <summary>
    /// A building for lodging military personnel
    /// <see href="http://www.ontotext.com/proton/protonext#Barracks"></see></summary>
    let Barracks = _prefix "Barracks"
    /// <summary>
    /// Any Baseball league
    /// <see href="http://www.ontotext.com/proton/protonext#BaseballLeague"></see></summary>
    let BaseballLeague = _prefix "BaseballLeague"
    /// <summary>
    /// The profession of baseball player
    /// <see href="http://www.ontotext.com/proton/protonext#BaseballPlayer"></see></summary>
    let BaseballPlayer = _prefix "BaseballPlayer"
    /// <summary>
    /// Any Baseball team
    /// <see href="http://www.ontotext.com/proton/protonext#BaseballTeam"></see></summary>
    let BaseballTeam = _prefix "BaseballTeam"
    /// <summary>
    /// Any Basketball league
    /// <see href="http://www.ontotext.com/proton/protonext#BasketballLeague"></see></summary>
    let BasketballLeague = _prefix "BasketballLeague"
    /// <summary>
    /// The profession of basketball player
    /// <see href="http://www.ontotext.com/proton/protonext#BasketballPlayer"></see></summary>
    let BasketballPlayer = _prefix "BasketballPlayer"
    /// <summary>
    /// Any basketball team
    /// <see href="http://www.ontotext.com/proton/protonext#BasketballTeam"></see></summary>
    let BasketballTeam = _prefix "BasketballTeam"
    /// <summary>
    /// A site of a land battle of historical importance. NIMA GNS designator L.BTL.
    /// <see href="http://www.ontotext.com/proton/protonext#Battlefield"></see></summary>
    let Battlefield = _prefix "Battlefield"
    /// <summary>
    /// Any Historic Place, an old place with historic value.
    /// <see href="http://www.ontotext.com/proton/protonext#HistoricPlace"></see></summary>
    let HistoricPlace = _prefix "HistoricPlace"
    /// <summary>
    /// (ADL FT) Indentations of a coastline or shoreline enclosing a part of a body of water; bodies of water partly surrounded by land. We use this category for bahias; for coves; and for embayments. NIMA GNS designators BAY, BAYS.
    /// <see href="http://www.ontotext.com/proton/protonext#Bay"></see></summary>
    let Bay = _prefix "Bay"
    /// <summary>
    /// (ADL FT: Hydrographic Features) For natural bodies of water. For constructed waterways, reservoirs, and such, use 'hydrographic structures'. We use this category for bodies of water; for eddies; for fluvial features; for marine features; for overfalls; for upwellings; for water bodies; for waterholes; and for whirlpools. Many of the ADL hydrographic features ignored. NIMA GNS class H.
    /// <see href="http://www.ontotext.com/proton/protonext#WaterRegion"></see></summary>
    let WaterRegion = _prefix "WaterRegion"
    /// <summary>
    /// (ADL FT) Sloping shores along a body of water that is washed by waves or tides and is usually covered by sand or gravel. ... We use this category for sandy areas; and for strands. NIMA GNS designator BCH, BCHS.
    /// <see href="http://www.ontotext.com/proton/protonext#Beach"></see></summary>
    let Beach = _prefix "Beach"
    /// <summary>
    /// A fixed artificial navigation mark
    /// <see href="http://www.ontotext.com/proton/protonext#Beacon"></see></summary>
    let Beacon = _prefix "Beacon"
    /// <summary>
    /// A specific chemical compound, such as H2O or Zarin.
    /// <see href="http://www.ontotext.com/proton/protonext#ChemicalCompound"></see></summary>
    let ChemicalCompound = _prefix "ChemicalCompound"
    /// <summary>
    /// An open body of water forming a slight recession in a coastline
    /// <see href="http://www.ontotext.com/proton/protonext#Bight"></see></summary>
    let Bight = _prefix "Bight"
    /// <summary>
    /// (ADL FT) Geographic regions characterized chiefly by the dominant forms of plant life and the prevailing climate. [Adapted from American Heritage Dict. of the English Language, 4th ed.] We use this category for biomes; for ecoregions; and for vegetation. Omitted ADL sub-classes: Barren lands, Grasslands, Habitats, Snow Regions, Wetlands. NIMA GNS designator - no equivalent. Some correspondence to class Hypsographic Features.
    /// <see href="http://www.ontotext.com/proton/protonext#BiogeographicRegion"></see></summary>
    let BiogeographicRegion = _prefix "BiogeographicRegion"
    /// <summary>
    /// A database containing information about biological entities.
    /// <see href="http://www.ontotext.com/proton/protonext#BiologicalDatabase"></see></summary>
    let BiologicalDatabase = _prefix "BiologicalDatabase"
    /// <summary>
    /// A dataset loaded in a system supporting search, update and other operations over the information in the dataset.
    /// <see href="http://www.ontotext.com/proton/protonext#Database"></see></summary>
    let Database = _prefix "Database"
    /// <summary>
    /// Any substance or element that has biological nature or origine.
    /// <see href="http://www.ontotext.com/proton/protonext#BiologicalSubstance"></see></summary>
    let BiologicalSubstance = _prefix "BiologicalSubstance"
    /// <summary>
    /// Bird denotes feathered, winged, bipedal, endothermic (warm-blooded), egg-laying, vertebrate animals. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Bird"></see></summary>
    let Bird = _prefix "Bird"
    /// <summary>
    /// Any bishop, an official in the Roman-Catholic church.
    /// <see href="http://www.ontotext.com/proton/protonext#Bishop"></see></summary>
    let Bishop = _prefix "Bishop"
    /// <summary>
    /// The social function of a cleric, involving the church.
    /// <see href="http://www.ontotext.com/proton/protonext#ClericTitle"></see></summary>
    let ClericTitle = _prefix "ClericTitle"
    /// <summary>
    /// A meeting whose main participants are members of a board.
    /// <see href="http://www.ontotext.com/proton/protonext#BoardMeeting"></see></summary>
    let BoardMeeting = _prefix "BoardMeeting"
    /// <summary>
    /// A meeting is a gathering of two or more people that has been convened for the purpose of achieving a common goal through verbal interaction, such as sharing information or reaching an agreement. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#Meeting"></see></summary>
    let Meeting = _prefix "Meeting"
    /// <summary>
    /// Any board member, a title of the member of the board of any board
    /// <see href="http://www.ontotext.com/proton/protonext#BoardMember"></see></summary>
    let BoardMember = _prefix "BoardMember"
    /// <summary>
    /// http://www.eionet.europa.eu/gemet/concept?ns=1&amp;cp=12161. NIMA GNS designator H.BOG.
    /// <see href="http://www.ontotext.com/proton/protonext#Bog"></see></summary>
    let Bog = _prefix "Bog"
    /// <summary>
    /// Any bone as a part of the body.
    /// <see href="http://www.ontotext.com/proton/protonext#Bone"></see></summary>
    let Bone = _prefix "Bone"
    /// <summary>
    /// A relatively large published document. It may or may not have chapters. There could be series of books considered as volumes of a single one.
    /// <see href="http://www.ontotext.com/proton/protonext#Book"></see></summary>
    let Book = _prefix "Book"
    /// <summary>
    /// The profession of boxer
    /// <see href="http://www.ontotext.com/proton/protonext#Boxer"></see></summary>
    let Boxer = _prefix "Boxer"
    /// <summary>
    /// Any Boxing league
    /// <see href="http://www.ontotext.com/proton/protonext#BoxingLeague"></see></summary>
    let BoxingLeague = _prefix "BoxingLeague"
    /// <summary>
    /// Any brain as a part of the body.
    /// <see href="http://www.ontotext.com/proton/protonext#Brain"></see></summary>
    let Brain = _prefix "Brain"
    /// <summary>
    /// The American Marketing Association defines a brand as a "Name, term, design, symbol, or any other feature that identifies one seller's good or service as distinct from those of other sellers." Wikipedia. Examples: Dodge and Milka
    /// <see href="http://www.ontotext.com/proton/protonext#Brand"></see></summary>
    let Brand = _prefix "Brand"
    /// <summary>
    /// A structure erected to break the force of waves at the entrance to a harbor or port
    /// <see href="http://www.ontotext.com/proton/protonext#Breakwater"></see></summary>
    let Breakwater = _prefix "Breakwater"
    /// <summary>
    /// (ADL FT) Structures erected over a depression or obstacle to carry traffic. [USGS Circ 1048] We use this category for covered bridges; for drawbridges; for overpasses; for trestles; and for viaducts. NIMA GNS designator BDG, BDGQ.
    /// <see href="http://www.ontotext.com/proton/protonext#Bridge"></see></summary>
    let Bridge = _prefix "Bridge"
    /// <summary>
    /// Any British Royalty, a title of a memebr of the British royal family.
    /// <see href="http://www.ontotext.com/proton/protonext#BritishRoyalty"></see></summary>
    let BritishRoyalty = _prefix "BritishRoyalty"
    /// <summary>
    /// The social function of a nobelty.
    /// <see href="http://www.ontotext.com/proton/protonext#NobeltyTitle"></see></summary>
    let NobeltyTitle = _prefix "NobeltyTitle"
    /// <summary>
    /// A broadcast network is an organization, such as a corporation or other voluntary association, that provides live television or recorded content, such as movies, newscasts, sports, Public affairs programming, and other television programs for broadcast over a group of radio stations or television stations. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#BroadcastNetwork"></see></summary>
    let BroadcastNetwork = _prefix "BroadcastNetwork"
    /// <summary>
    /// A company that broadcasts audio or video content to a dispersed audience via any audio visual medium. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#Broadcaster"></see></summary>
    let Broadcaster = _prefix "Broadcaster"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#MediaCompany"></see>
    /// </summary>
    let MediaCompany = _prefix "MediaCompany"
    /// <summary>
    /// Professional toreros (also called matadors) who execute various formal moves which can be interpreted and innovated according to the bullfighter's style or school. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#BullFighter"></see></summary>
    let BullFighter = _prefix "BullFighter"
    /// <summary>
    /// A small clump of conspicuous bushes in an otherwise bare area
    /// <see href="http://www.ontotext.com/proton/protonext#BushLand"></see></summary>
    let BushLand = _prefix "BushLand"
    /// <summary>
    /// An abstraction related to business.
    /// <see href="http://www.ontotext.com/proton/protonext#BusinessAbstraction"></see></summary>
    let BusinessAbstraction = _prefix "BusinessAbstraction"
    /// <summary>
    /// Any CEO, a title of a chief executive officer of an organization.
    /// <see href="http://www.ontotext.com/proton/protonext#CEO"></see></summary>
    let CEO = _prefix "CEO"
    /// <summary>
    /// A specific month of the year, such as: Jan., Feb., etc.
    /// <see href="http://www.ontotext.com/proton/protonext#CalendarMonth"></see></summary>
    let CalendarMonth = _prefix "CalendarMonth"
    /// <summary>
    /// Any sort of abstraction used to refer to specific periods of time. Thus, the month of September is an instance of this class, while Sept 1989 is not (it is a specific TimeInterval, and thus not abstract)
    /// <see href="http://www.ontotext.com/proton/protonext#TemporalAbstraction"></see></summary>
    let TemporalAbstraction = _prefix "TemporalAbstraction"
    /// <summary>
    /// A specific year, such as 2000, taken as a time interval
    /// <see href="http://www.ontotext.com/proton/protonext#CalendarYear"></see></summary>
    let CalendarYear = _prefix "CalendarYear"
    /// <summary>
    /// (ADL FT) Designated areas on which primitive structure(s) are erected for temporary shelter or where recreational vehicles are temporarily parked. [USGS Circ 1048] We use this category for campgrounds; for camping sites; for logging camps; for oil camps; for refugee camps; for RV parks; and for trailer parks (recreational). NIMA GNS designators CMP, CMPL, CMPLA, CMPO, CMPQ, CMPRF.
    /// <see href="http://www.ontotext.com/proton/protonext#Camp"></see></summary>
    let Camp = _prefix "Camp"
    /// <summary>
    /// Any Canadian Football league
    /// <see href="http://www.ontotext.com/proton/protonext#CanadianFootballLeague"></see></summary>
    let CanadianFootballLeague = _prefix "CanadianFootballLeague"
    /// <summary>
    /// Any player of Canadian football.
    /// <see href="http://www.ontotext.com/proton/protonext#CanadianFootballPlayer"></see></summary>
    let CanadianFootballPlayer = _prefix "CanadianFootballPlayer"
    /// <summary>
    /// Any Canadian Football Team
    /// <see href="http://www.ontotext.com/proton/protonext#CanadianFootballTeam"></see></summary>
    let CanadianFootballTeam = _prefix "CanadianFootballTeam"
    /// <summary>
    /// (ADL FT) Artificial waterways with no flow or a controlled flow used for navigation (canal), or for draining or irrigating land (ditch). We use this category for canal bends; for canalized streams; for ditch mouths; for ditches; for drainage canals; for drainage ditches; for drains (channels); for flumes (manmade); for irrigation canals; for irrigation ditches; for irrigation systems; for laterals; for navigation canals; and for underground irrigation canals. NIMA GNS designators CNL,CNLA, CNLB, CNLD, CNLI, CNLN, CNLQ, CNLSB, CNLX.
    /// <see href="http://www.ontotext.com/proton/protonext#Canal"></see></summary>
    let Canal = _prefix "Canal"
    /// <summary>
    /// (ADL FT) For constructed bodies of water. For natural water bodies, use 'hydrographic features'. We use this category for boat landings; for boat launches; for boat ramps; for sluices; and for water mills. Many sub-classes omitted; those considered are also made sub-classes of WaterRegion. NIMA GNS ... no direct equivalent.
    /// <see href="http://www.ontotext.com/proton/protonext#HydrographicStructure"></see></summary>
    let HydrographicStructure = _prefix "HydrographicStructure"
    /// <summary>
    /// (ADL FT) Relatively narrow, deep depressions with steep sides, the bottom of which generally has a continuous slope ... We use this category for barrancas; for chasms; for flumes (natural); for gorges; for gulches; for quebradas; and for ravines. NIMA GNS designator CNSU, CNYN, CNYU, GRGE, RAVU, RVN.
    /// <see href="http://www.ontotext.com/proton/protonext#Canyon"></see></summary>
    let Canyon = _prefix "Canyon"
    /// <summary>
    /// (ADL FT) Low-lying land bordered by higher ground; especially elongate, relatively large gently sloping depressions of the Earth's surface, commonly situated between two mountains or between ranges of hills or mountains, and often containing a stream with an outlet. [Glossary of Geology, 4th ed.] We use this category for forks (physiographic features); for glens; for hanging valleys; for hollows; for median valleys; and for shelf valleys (seafloor). NIMA GNS designators VAL, VALG, VALU, VALS, VALX, VLSU, FRKU, FRSU, MDVU, SHVU.
    /// <see href="http://www.ontotext.com/proton/protonext#Valley"></see></summary>
    let Valley = _prefix "Valley"
    /// <summary>
    /// (ADL FT) Projection of land extending into a body of water that prominently marks a change in or interrupts the coastal trend of that water body. We use this category for headlands; for peninsulas; for points (physiographic); and for promontories. NIMA GNS designator CAPE, HDLD, PROM.
    /// <see href="http://www.ontotext.com/proton/protonext#Cape"></see></summary>
    let Cape = _prefix "Cape"
    /// <summary>
    /// (ADL FT) Towns or cities that are the official seats of government in a political entity, such as a state or nation. [American Heritage Dic. of the English Language, 4th ed.] We use this category for county seats; for national capitals; and for state capitals. NIMA GNS designators PPLC, PPLA
    /// <see href="http://www.ontotext.com/proton/protonext#Capital"></see></summary>
    let Capital = _prefix "Capital"
    /// <summary>
    /// (ADL FT) For smaller, less formally established communities, use 'populated places'. For independent cities, use 'countries, 2nd order divisions. Incorporated populated places. [Adapted from USGS Circ 1048] We use this category for municipalities; for towns; and for urban areas. NIMA GNS designator PPL.
    /// <see href="http://www.ontotext.com/proton/protonext#City"></see></summary>
    let City = _prefix "City"
    /// <summary>
    /// Any automoabile car.
    /// <see href="http://www.ontotext.com/proton/protonext#Car"></see></summary>
    let Car = _prefix "Car"
    /// <summary>
    /// Any sort of specific vehicle, mean of transportation.
    /// <see href="http://www.ontotext.com/proton/protonext#Vehicle"></see></summary>
    let Vehicle = _prefix "Vehicle"
    /// <summary>
    /// A concrete model of a car which determines the main features of any car of this model. For example, Ford-T or BMW Z3.
    /// <see href="http://www.ontotext.com/proton/protonext#CarModel"></see></summary>
    let CarModel = _prefix "CarModel"
    /// <summary>
    /// Any Cardinal, a high official in the Roman-Catholic church.
    /// <see href="http://www.ontotext.com/proton/protonext#Cardinal"></see></summary>
    let Cardinal = _prefix "Cardinal"
    /// <summary>
    /// (ADL FT) Natural underground passageways or chambers, or hollowed out cavities in the side of a cliff. ... We use this category for cave entrances; for caverns; for grottoes; for natural tunnels; and for underground lakes. NIMA GNS designator CAVE.
    /// <see href="http://www.ontotext.com/proton/protonext#Cave"></see></summary>
    let Cave = _prefix "Cave"
    /// <summary>
    /// The situation of holding a position in a society as celebrity.
    /// <see href="http://www.ontotext.com/proton/protonext#Celebrity"></see></summary>
    let Celebrity = _prefix "Celebrity"
    /// <summary>
    /// The social function of celebrity, a status of notoriety in the society.
    /// <see href="http://www.ontotext.com/proton/protonext#CelebrityTitle"></see></summary>
    let CelebrityTitle = _prefix "CelebrityTitle"
    /// <summary>
    /// The name of a function a person has in the society like nobely, job title, celebrity, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#SocialFunction"></see></summary>
    let SocialFunction = _prefix "SocialFunction"
    /// <summary>
    /// Any Chancellor, a title of various official positions in the governments of many nations. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Chancellor"></see></summary>
    let Chancellor = _prefix "Chancellor"
    /// <summary>
    /// (ADL FT) (a) Relatively narrow seas or stretches of water between two close landmasses and connecting two larger bodies of water; (b) Deeper parts of a moving body of water (as bays, estuaries, or straits) through which the main current flows or which affords the best passage through an area otherwise too shallow to navigate. ... We use this category for chutes (hydrographic); for cutoffs (hydrographic); for inlets; for lake channels; for marine channels; for narrows (hydrographic); for navigation channels; for reaches (hydrographic); for sounds (bodies of water); and for straits. NIMA GNS designators CHN, CHNL, CHNM, CHNN, STRT.
    /// <see href="http://www.ontotext.com/proton/protonext#Channel"></see></summary>
    let Channel = _prefix "Channel"
    /// <summary>
    /// Any Charity, an organization involved in the practice of benevolent giving and caring. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Charity"></see></summary>
    let Charity = _prefix "Charity"
    /// <summary>
    /// Any Non-Profit Organization, an organization that does not distribute its surplus funds to owners or shareholders, but instead uses them to help pursue its goals. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Non-ProfitOrganisation"></see></summary>
    let ``Non-ProfitOrganisation`` = _prefix "Non-ProfitOrganisation"
    /// <summary>
    /// Any substance or element that has chemical nature.
    /// <see href="http://www.ontotext.com/proton/protonext#ChemicalSubstance"></see></summary>
    let ChemicalSubstance = _prefix "ChemicalSubstance"
    /// <summary>
    /// A chemical element is a pure chemical substance consisting of one type of atom distinguished by its atomic number, which is the number of protons in its nucleus. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#ChemicalElement"></see></summary>
    let ChemicalElement = _prefix "ChemicalElement"
    /// <summary>
    /// The profession of a chess player
    /// <see href="http://www.ontotext.com/proton/protonext#ChessPlayer"></see></summary>
    let ChessPlayer = _prefix "ChessPlayer"
    /// <summary>
    /// Any Christian Patriarch.
    /// <see href="http://www.ontotext.com/proton/protonext#ChristianPatriarch"></see></summary>
    let ChristianPatriarch = _prefix "ChristianPatriarch"
    /// <summary>
    /// Describes a populated place with organisation, like city, village, town
    /// <see href="http://www.ontotext.com/proton/protonext#Settlement"></see></summary>
    let Settlement = _prefix "Settlement"
    /// <summary>
    /// The situation of holding a position in society as cleric.
    /// <see href="http://www.ontotext.com/proton/protonext#Cleric"></see></summary>
    let Cleric = _prefix "Cleric"
    /// <summary>
    /// (ADL FT: Coastal Zones) Strips of land (of indefinite width) that extend from the low-tide line inland to the first major change in landform features. [Adapted from Glossary of Geology, 4th ed.] We use this category for coastal plains; for coasts; for intertidal zones; for offshore areas; for shorelines; and for shores. NIMA GNS designators CST, SHOR.
    /// <see href="http://www.ontotext.com/proton/protonext#Coast"></see></summary>
    let Coast = _prefix "Coast"
    /// <summary>
    /// A planting of coconut trees
    /// <see href="http://www.ontotext.com/proton/protonext#CoconutGrove"></see></summary>
    let CoconutGrove = _prefix "CoconutGrove"
    /// <summary>
    /// An education organization between the school and the university. In some cases it is a part of university.
    /// College
    /// <see href="http://www.ontotext.com/proton/protonext#College"></see></summary>
    let College = _prefix "College"
    /// <summary>
    /// An organization devoted to teaching activities.
    /// <see href="http://www.ontotext.com/proton/protonext#EducationalOrganization"></see></summary>
    let EducationalOrganization = _prefix "EducationalOrganization"
    /// <summary>
    /// Any colour, a visual perceptual property, e.g. red, blue, yellow, etc. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Colour"></see></summary>
    let Colour = _prefix "Colour"
    /// <summary>
    /// The profession of a comedian
    /// <see href="http://www.ontotext.com/proton/protonext#Comedian"></see></summary>
    let Comedian = _prefix "Comedian"
    /// <summary>
    /// A character from a comics.
    /// <see href="http://www.ontotext.com/proton/protonext#ComicsCharacter"></see></summary>
    let ComicsCharacter = _prefix "ComicsCharacter"
    /// <summary>
    /// The characters in fictional artwork like movies, books, etc
    /// <see href="http://www.ontotext.com/proton/protonext#FictionalCharacter"></see></summary>
    let FictionalCharacter = _prefix "FictionalCharacter"
    /// <summary>
    /// The profession of comics creator
    /// <see href="http://www.ontotext.com/proton/protonext#ComicsCreator"></see></summary>
    let ComicsCreator = _prefix "ComicsCreator"
    /// <summary>
    /// Any commander, title of being commander or having a leading role in a military unit or other organization.
    /// <see href="http://www.ontotext.com/proton/protonext#Commander"></see></summary>
    let Commander = _prefix "Commander"
    /// <summary>
    /// Organization that buys or sells goods or services for a profit. It may also be a Business or it may merely be a sub-organization of a Business entity.
    /// <see href="http://www.ontotext.com/proton/protonext#CommercialOrganization"></see></summary>
    let CommercialOrganization = _prefix "CommercialOrganization"
    /// <summary>
    /// An art performance consisting of playing music.
    /// <see href="http://www.ontotext.com/proton/protonext#Concert"></see></summary>
    let Concert = _prefix "Concert"
    /// <summary>
    /// in geography, describes the meeting of two or more bodies of water. The opposite of a watershed. NIMA GNS designator H.CNFL.
    /// <see href="http://www.ontotext.com/proton/protonext#Confluence"></see></summary>
    let Confluence = _prefix "Confluence"
    /// <summary>
    /// Any Congressman, a title of a position in congress.
    /// <see href="http://www.ontotext.com/proton/protonext#Congressman"></see></summary>
    let Congressman = _prefix "Congressman"
    /// <summary>
    /// (ADL FT) Earth's major land masses, including both dry land and continental shelves. NIMA GNS designator - no equivalent.
    /// <see href="http://www.ontotext.com/proton/protonext#Continent"></see></summary>
    let Continent = _prefix "Continent"
    /// <summary>
    /// A zone adjacent to a continent (or around an island) that extends from the low water line to a depth at which there is usually a marked increase of slope towards oceanic depths
    /// <see href="http://www.ontotext.com/proton/protonext#ContinentalShelf"></see></summary>
    let ContinentalShelf = _prefix "ContinentalShelf"
    /// <summary>
    /// Any sort of contract or treaty, as well, as other documents signed or otherwise accepted by more than one agent.
    /// <see href="http://www.ontotext.com/proton/protonext#Contract"></see></summary>
    let Contract = _prefix "Contract"
    /// <summary>
    /// (ADL FTT) Territory occupied by a large group of people organized under a single, usually independent government, and recognized internationally as a country. [Adapted from American Heritage Dic. of the English Language, 4th ed.] We use this category for nations; and for republics. NIMA GNS designators PCL, PCLD, PCLF, PCLI, PCLS. FIPS 10-4 is applicable, difining: Basic geopolitical entities assigned country codes include the following categories: (a) independent states; (b) dependent areas; (c) areas of quasi-independence, non-contiguous territories, possessions without populations, areas with special sovereignty associations, areas without sovereignty; (d) political regimes not recognized by the United States; and (e) outlying areas of the United States. The list of basic entities provides complete coverage of the land areas of the world without overlap or duplication.
    /// <see href="http://www.ontotext.com/proton/protonext#Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    /// (ADL, Political Entity) We use this category for commonwealths; for dependent political entities; for freely associated states; for independent political entities; for oblasts; for political entities; and for semi-independent political entities. Sub-classes omitted: Countries, 4th order divisions. NIMA GNS class: A, Administrative Boundary Features.
    /// <see href="http://www.ontotext.com/proton/protonext#PoliticalRegion"></see></summary>
    let PoliticalRegion = _prefix "PoliticalRegion"
    /// <summary>
    /// A capital of a Country. NIMA GNS designator PPLC.
    /// <see href="http://www.ontotext.com/proton/protonext#CountryCapital"></see></summary>
    let CountryCapital = _prefix "CountryCapital"
    /// <summary>
    /// (ADL FT: Countries, 2nd order divisions) Second-order divisions of a nation such as parishes, boroughs, counties, municipios, or judicial divisions, and independent cities such as those in Maryland, Missouri, Nevada, and Virginia. [Adapted from USGS Circ 1048] We use this category for boroughs; for counties; for judicial divisions; for municipios; for parishes; and for second-order administrative divisions. NIMA GNS designator ADM2.
    /// <see href="http://www.ontotext.com/proton/protonext#County"></see></summary>
    let County = _prefix "County"
    /// <summary>
    /// a small type of bay or coastal inlet. http://www.eionet.europa.eu/gemet/concept/10142 NIMA GNS designator H.COVE.
    /// <see href="http://www.ontotext.com/proton/protonext#Cove"></see></summary>
    let Cove = _prefix "Cove"
    /// <summary>
    /// (ADL FT) Circular-shaped depressions at the summit of a volcanic core or on the surface of the land caused by the impact of a meteorite; man-made depressions caused by an explosion. ... We use this category for calderas. NIMA GNS designator CRTR, CLDA.
    /// <see href="http://www.ontotext.com/proton/protonext#Crater"></see></summary>
    let Crater = _prefix "Crater"
    /// <summary>
    /// (ADL FT: Guts) Relatively small coastal waterways connecting larger bodies of water or other waterways. NIMA GNS designator CRKT, INLT.
    /// <see href="http://www.ontotext.com/proton/protonext#Creek"></see></summary>
    let Creek = _prefix "Creek"
    /// <summary>
    /// Any Cricket league
    /// <see href="http://www.ontotext.com/proton/protonext#CricketLeague"></see></summary>
    let CricketLeague = _prefix "CricketLeague"
    /// <summary>
    /// The profession of cricketer
    /// <see href="http://www.ontotext.com/proton/protonext#Cricketer"></see></summary>
    let Cricketer = _prefix "Cricketer"
    /// <summary>
    /// Crustaceans denotes a group of arthropods animals, which includes crabs, lobsters, crayfish, shrimp, krill and barnacles. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Crustacean"></see></summary>
    let Crustacean = _prefix "Crustacean"
    /// <summary>
    /// An area under cultivation
    /// <see href="http://www.ontotext.com/proton/protonext#CultivatedArea"></see></summary>
    let CultivatedArea = _prefix "CultivatedArea"
    /// <summary>
    /// Any Curling league
    /// <see href="http://www.ontotext.com/proton/protonext#CurlingLeague"></see></summary>
    let CurlingLeague = _prefix "CurlingLeague"
    /// <summary>
    /// Specific currency, usually national
    /// <see href="http://www.ontotext.com/proton/protonext#Currency"></see></summary>
    let Currency = _prefix "Currency"
    /// <summary>
    /// A particular notation for representation, standardization, and/or structuring of infomation. It can range from db schema, through ontology, to any sort of taxonomies, nomenclatures and subject hierarchies. Examples are Dublin Core, KIMO, SIC, XML, RDFS
    /// <see href="http://www.ontotext.com/proton/protonext#DataSchema"></see></summary>
    let DataSchema = _prefix "DataSchema"
    /// <summary>
    /// A dataset is information encoded in a defined structure (for example, lists, tables, and databases), intended to be useful for direct machine processing (DCMI Type.) Somehow structured and interrelated body of information, data, or knowledge. This includes databases, knowledge bases, catalogues, registries, specific lists, etc. All tangible aspects (like media or host) are irrelevant for this class - it only considers the abstract information. What can be considered as a single document is outside the scope of this class, although it can be comprehensive in terms of size and structure.
    /// <see href="http://www.ontotext.com/proton/protonext#Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// A specific date, as 12th of April, 1956, as the time period (the 24 hours of the day)
    /// <see href="http://www.ontotext.com/proton/protonext#Date"></see></summary>
    let Date = _prefix "Date"
    /// <summary>
    /// A specific day of a given month. The days are numbered from 1 to 28, 29, 30, or 31 depending on the month and the year.
    /// <see href="http://www.ontotext.com/proton/protonext#DayOfMonth"></see></summary>
    let DayOfMonth = _prefix "DayOfMonth"
    /// <summary>
    /// A specific day of the week. The week has seven days: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday.
    /// <see href="http://www.ontotext.com/proton/protonext#DayOfWeek"></see></summary>
    let DayOfWeek = _prefix "DayOfWeek"
    /// <summary>
    /// Specific time (point) during the day, when the day is not specified. Like in "the supermarket is closing 20:30 p.m."
    /// <see href="http://www.ontotext.com/proton/protonext#DayTime"></see></summary>
    let DayTime = _prefix "DayTime"
    /// <summary>
    /// The event to die.
    /// <see href="http://www.ontotext.com/proton/protonext#Death"></see></summary>
    let Death = _prefix "Death"
    /// <summary>
    /// (ADL FT) Flat plains formed by alluvial deposits at the mouth of a stream. NIMA GNS designator DLTA.
    /// <see href="http://www.ontotext.com/proton/protonext#Delta"></see></summary>
    let Delta = _prefix "Delta"
    /// <summary>
    /// The occupation of deputy
    /// <see href="http://www.ontotext.com/proton/protonext#Deputy"></see></summary>
    let Deputy = _prefix "Deputy"
    /// <summary>
    /// (ADL FT) Regions rendered barren or partially barren by environmental extremes, especially by low rainfall. [USGS Circ 1048] We use this category for arid regions; for bajadas; for rock deserts; for sandy areas; for sandy deserts; and for stony deserts. NIMA GNS designators DSRT, ERG, HMDA, REG.
    /// <see href="http://www.ontotext.com/proton/protonext#Desert"></see></summary>
    let Desert = _prefix "Desert"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#Device"></see>
    /// </summary>
    let Device = _prefix "Device"
    /// <summary>
    /// A specific sort of desease, such as AIDS, SARS, Parcinson, etc. The instances of those class can often by considered as terms instead of entities, but in all cases, those are the general phenomena, not the particular situations when somebody is suffering the disease.
    /// <see href="http://www.ontotext.com/proton/protonext#Disease"></see></summary>
    let Disease = _prefix "Disease"
    /// <summary>
    /// A ditch is usually defined as a small to moderate depression created to channel water.(Wikipedia). http://www.eionet.europa.eu/gemet/concept/2276. NIMA GNS designators H.DTCH, H.DTCHD, H.DTCHI, H.DTCHM.
    /// <see href="http://www.ontotext.com/proton/protonext#Ditch"></see></summary>
    let Ditch = _prefix "Ditch"
    /// <summary>
    /// Branch, division, department, laboratory, etc. within an organisation. Usually, not a legal agent and not independent.
    /// <see href="http://www.ontotext.com/proton/protonext#Division"></see></summary>
    let Division = _prefix "Division"
    /// <summary>
    /// An area drained by a stream. NIMA GNS designator L.BSND.
    /// <see href="http://www.ontotext.com/proton/protonext#DrainageBasin"></see></summary>
    let DrainageBasin = _prefix "DrainageBasin"
    /// <summary>
    /// A chemical substance used to improve the health condition of a person, animal, etc. For example, Aspirin, Viagra, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Drug"></see></summary>
    let Drug = _prefix "Drug"
    /// <summary>
    /// An identifier that determines a electronic mail box.
    /// <see href="http://www.ontotext.com/proton/protonext#EMail"></see></summary>
    let EMail = _prefix "EMail"
    /// <summary>
    /// An identifier that determines a resource on the Internet.
    /// <see href="http://www.ontotext.com/proton/protonext#InternetAddress"></see></summary>
    let InternetAddress = _prefix "InternetAddress"
    /// <summary>
    /// Generic concept of Election which is normally held at regular periods of time, president elections of the US, municipal elections, etc..
    /// <see href="http://www.ontotext.com/proton/protonext#Election"></see></summary>
    let Election = _prefix "Election"
    /// <summary>
    /// Recurring sequence of events, such as Olympic Games, etc..
    /// <see href="http://www.ontotext.com/proton/protonext#RecurringEvent"></see></summary>
    let RecurringEvent = _prefix "RecurringEvent"
    /// <summary>
    /// Election happening at a particular date.
    /// <see href="http://www.ontotext.com/proton/protonext#ElectionOccurrence"></see></summary>
    let ElectionOccurrence = _prefix "ElectionOccurrence"
    /// <summary>
    /// A webpage of a map
    /// <see href="http://www.ontotext.com/proton/protonext#ElectronicMap"></see></summary>
    let ElectronicMap = _prefix "ElectronicMap"
    /// <summary>
    /// Embryology is a science that studies the development of the embryo. This class denotes different composing substances/elements of the embryo and related body parts, and hence is referred to as a body part. It is inspired form DBPedia Embryology/AnatomicalStructure, which has instances as Blastocyst, Amniotic cavity, Vitelline membrane, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#EmbryoBodyPart"></see></summary>
    let EmbryoBodyPart = _prefix "EmbryoBodyPart"
    /// <summary>
    /// Any Entertainment Company, a company involved in the entertainment business, e.g. Warner Brothers, MTV, Lido, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#EntertainmentCompany"></see></summary>
    let EntertainmentCompany = _prefix "EntertainmentCompany"
    /// <summary>
    /// A partly enclosed coastal body of water with one or more rivers or streams flowing into it, and with a free connection to the open sea. NIMA GNS designator H.ESTY.
    /// <see href="http://www.ontotext.com/proton/protonext#Estuary"></see></summary>
    let Estuary = _prefix "Estuary"
    /// <summary>
    /// Any ethnic group. A group of people whose members identify with each other, through a common heritage, often consisting of a common language, a common culture (often including a shared religion) and an ideology that stresses common ancestry or endogamy. (Wikipedia).
    /// <see href="http://www.ontotext.com/proton/protonext#EthnicGroup"></see></summary>
    let EthnicGroup = _prefix "EthnicGroup"
    /// <summary>
    /// An inlet which has been filled in, or blocked by deposits
    /// <see href="http://www.ontotext.com/proton/protonext#FInlet"></see></summary>
    let FInlet = _prefix "FInlet"
    /// <summary>
    /// Any model, a profession involving posing to draw attention to a particualr object or cause.
    /// <see href="http://www.ontotext.com/proton/protonext#FashionModel"></see></summary>
    let FashionModel = _prefix "FashionModel"
    /// <summary>
    /// A phone number connected to a fax machine.
    /// <see href="http://www.ontotext.com/proton/protonext#FaxNumber"></see></summary>
    let FaxNumber = _prefix "FaxNumber"
    /// <summary>
    /// A sequence of digits which represents an address of a telephone device within a telephone net.
    /// <see href="http://www.ontotext.com/proton/protonext#PhoneNumber"></see></summary>
    let PhoneNumber = _prefix "PhoneNumber"
    /// <summary>
    /// Any widely recognized festival or holiday, such as, Christmas or St. Valentine's Day.
    /// <see href="http://www.ontotext.com/proton/protonext#Festival"></see></summary>
    let Festival = _prefix "Festival"
    /// <summary>
    /// An occurrence of a Festival or holiday, Sofia Film Festival 2011, Christmas of 2010 or St. Valentine's Day of 2011.
    /// <see href="http://www.ontotext.com/proton/protonext#FestivalOccurrence"></see></summary>
    let FestivalOccurrence = _prefix "FestivalOccurrence"
    /// <summary>
    /// Any Field Hockey league
    /// <see href="http://www.ontotext.com/proton/protonext#FieldHockeyLeague"></see></summary>
    let FieldHockeyLeague = _prefix "FieldHockeyLeague"
    /// <summary>
    /// The profession of figure skater
    /// <see href="http://www.ontotext.com/proton/protonext#FigureSkater"></see></summary>
    let FigureSkater = _prefix "FigureSkater"
    /// <summary>
    /// Any festival involving showing a film.
    /// <see href="http://www.ontotext.com/proton/protonext#FilmFestival"></see></summary>
    let FilmFestival = _prefix "FilmFestival"
    /// <summary>
    /// A fish is any gill-bearing aquatic vertebrate (or craniate) animal that lacks limbs with digits. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Fish"></see></summary>
    let Fish = _prefix "Fish"
    /// <summary>
    /// A bank or area where fishermen go to catch fish. NIMA GNS designator H.FISH.
    /// <see href="http://www.ontotext.com/proton/protonext#FishingArea"></see></summary>
    let FishingArea = _prefix "FishingArea"
    /// <summary>
    /// (ADL FT) Long narrow glacially-eroded inlets of the sea, U-shaped and steep-walled, generally several hundred meters deep, between high rocky cliffs or slopes along a mountainous coast. ... We use this category for fiords; and for lochs. NIMA GNS designator FJD, FJDS.
    /// <see href="http://www.ontotext.com/proton/protonext#Fjord"></see></summary>
    let Fjord = _prefix "Fjord"
    /// <summary>
    /// Any flowering plant
    /// <see href="http://www.ontotext.com/proton/protonext#FloweringPlant"></see></summary>
    let FloweringPlant = _prefix "FloweringPlant"
    /// <summary>
    /// Plants are living organisms. They include familiar organisms such as trees, flowers, herbs, bushes, grasses, vines, ferns, mosses, and green algae. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Plant"></see></summary>
    let Plant = _prefix "Plant"
    /// <summary>
    /// Food is any eatable or drinkable substance that is normally consumed by humans. DBPedia
    /// <see href="http://www.ontotext.com/proton/protonext#Food"></see></summary>
    let Food = _prefix "Food"
    /// <summary>
    /// Any instance of a soccer match.
    /// <see href="http://www.ontotext.com/proton/protonext#FootballMatch"></see></summary>
    let FootballMatch = _prefix "FootballMatch"
    /// <summary>
    /// A sport game is any instance of a sport event, where teams or individuals gather to play according to particular predetermined rules, such as soccer match, tennis match, car race, etc. It can also denote the activity of playing a particular sport game.
    /// <see href="http://www.ontotext.com/proton/protonext#SportGame"></see></summary>
    let SportGame = _prefix "SportGame"
    /// <summary>
    /// (ADL FT) Dense growths of trees, plants, and underbrush covering a large area. [American Heritage Dic. of the English Language, 4th ed.] We use this category for forest reserves; and for national forests. Omitted ADL sub-classes: Petrified forests, Rain forests, Woods (the sub-classes collapsed here). NIMA GNS designator FRST, FRSTF, GDVC, GRVO, GRVP, GRVPN, TREE.
    /// <see href="http://www.ontotext.com/proton/protonext#Forest"></see></summary>
    let Forest = _prefix "Forest"
    /// <summary>
    /// An area in a forest with trees removed. NIMA GNS designator L.CLG.
    /// <see href="http://www.ontotext.com/proton/protonext#ForestClearing"></see></summary>
    let ForestClearing = _prefix "ForestClearing"
    /// <summary>
    /// The profession of formula one racer
    /// <see href="http://www.ontotext.com/proton/protonext#FormulaOneRacer"></see></summary>
    let FormulaOneRacer = _prefix "FormulaOneRacer"
    /// <summary>
    /// Fungus is a member of a large group of eukaryotic organisms that includes microorganisms such as yeasts and molds (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Fungus"></see></summary>
    let Fungus = _prefix "Fungus"
    /// <summary>
    /// The profession of gaelic games player
    /// <see href="http://www.ontotext.com/proton/protonext#GaelicGamesPlayer"></see></summary>
    let GaelicGamesPlayer = _prefix "GaelicGamesPlayer"
    /// <summary>
    /// A galaxy is a massive, gravitationally bound system that consists of stars and stellar remnants, an interstellar medium of gas and dust, and an important but poorly understood component tentatively dubbed dark matter. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#Galaxy"></see></summary>
    let Galaxy = _prefix "Galaxy"
    /// <summary>
    /// Game. Activity involving participants usually divided in teams, which obeys particualr rules, and has often a winner.
    /// <see href="http://www.ontotext.com/proton/protonext#Game"></see></summary>
    let Game = _prefix "Game"
    /// <summary>
    /// (ADL FT) Ravines or gorges cut deeply through mountain ridges, or between hills or mountains. We use this category for cols; for defiles; for passes; for saddles (physiographic); and for sills (physiographic). NIMA GNS designator GAP, GAPU, GAPF, PASS, SILL, SILU.
    /// <see href="http://www.ontotext.com/proton/protonext#Gap"></see></summary>
    let Gap = _prefix "Gap"
    /// <summary>
    /// A gene is a molecular unit of heredity of a living organism. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#Gene"></see></summary>
    let Gene = _prefix "Gene"
    /// <summary>
    /// Any Genre. Denotes any category of literature as well as various other forms of art or culture, e.g., music, based on some loose set of stylistic criteria. Genres are formed by conventions that change over time as new genres are invented and the use of old ones are discontinued. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Genre"></see></summary>
    let Genre = _prefix "Genre"
    /// <summary>
    /// Any Geographic Region with lattitude and longitude coordinates
    /// <see href="http://www.ontotext.com/proton/protonext#GeographicLocation"></see></summary>
    let GeographicLocation = _prefix "GeographicLocation"
    /// <summary>
    /// Any geopolitical organization, an organization based on geo-political principles.
    /// <see href="http://www.ontotext.com/proton/protonext#GeopoliticalOrganization"></see></summary>
    let GeopoliticalOrganization = _prefix "GeopoliticalOrganization"
    /// <summary>
    /// A spring characterized by intermittent discharge of water ejected turbulently and accompanied by a vapour phase (steam). NIMA GNS designator H.GYSR.
    /// <see href="http://www.ontotext.com/proton/protonext#Geyser"></see></summary>
    let Geyser = _prefix "Geyser"
    /// <summary>
    /// (ADL FT) Places where underground water flows naturally to the surface of the Earth. ... We use this category for mineral springs; and for sulfur springs. NIMA GNS designators SPNG, SPNS, SPNT.
    /// <see href="http://www.ontotext.com/proton/protonext#Spring"></see></summary>
    let Spring = _prefix "Spring"
    /// <summary>
    /// A mass of ice, usually at high latitudes or high elevations, with sufficient thickness to flow away from the source area in lobes, tongues, or masses
    /// <see href="http://www.ontotext.com/proton/protonext#Glacier"></see></summary>
    let Glacier = _prefix "Glacier"
    /// <summary>
    /// Things like Southeastern Europe, Middle East, Oceania are global regions
    /// <see href="http://www.ontotext.com/proton/protonext#GlobalRegion"></see></summary>
    let GlobalRegion = _prefix "GlobalRegion"
    /// <summary>
    /// Any Golf league
    /// <see href="http://www.ontotext.com/proton/protonext#GolfLeague"></see></summary>
    let GolfLeague = _prefix "GolfLeague"
    /// <summary>
    /// Any player of Golf.
    /// <see href="http://www.ontotext.com/proton/protonext#GolfPlayer"></see></summary>
    let GolfPlayer = _prefix "GolfPlayer"
    /// <summary>
    /// The government of a country.
    /// The governmental cabinet
    /// <see href="http://www.ontotext.com/proton/protonext#Government"></see></summary>
    let Government = _prefix "Government"
    /// <summary>
    /// The government of a country, i.e. the authorized country administration, without account for a specific government elected and being in power for some period. This notion of government groups all the administration, including any sort of ministries, agencies, commissions, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#GovernmentOrganization"></see></summary>
    let GovernmentOrganization = _prefix "GovernmentOrganization"
    /// <summary>
    /// A government agency is a permanent or semi-permanent organization in the machinery of government that is responsible for the oversight and administration of specific functions, such as an intelligence agency. DBPedia
    /// The governmental cabinet
    /// <see href="http://www.ontotext.com/proton/protonext#GovernmentAgency"></see></summary>
    let GovernmentAgency = _prefix "GovernmentAgency"
    /// <summary>
    /// A government building, a building which serves the government, or where government officials work.
    /// <see href="http://www.ontotext.com/proton/protonext#GovernmentBuilding"></see></summary>
    let GovernmentBuilding = _prefix "GovernmentBuilding"
    /// <summary>
    /// Any Governor, a title of Governor of a district.
    /// <see href="http://www.ontotext.com/proton/protonext#Governor"></see></summary>
    let Governor = _prefix "Governor"
    /// <summary>
    /// Any grape
    /// <see href="http://www.ontotext.com/proton/protonext#Grape"></see></summary>
    let Grape = _prefix "Grape"
    /// <summary>
    /// An area dominated by grass vegetation
    /// <see href="http://www.ontotext.com/proton/protonext#Grassland"></see></summary>
    let Grassland = _prefix "Grassland"
    /// <summary>
    /// Any player of a gridilon football.
    /// <see href="http://www.ontotext.com/proton/protonext#GridironFootballPlayer"></see></summary>
    let GridironFootballPlayer = _prefix "GridironFootballPlayer"
    /// <summary>
    /// (ADL FT) Largest of various forms of inlets of the sea; usually larger, more enclosed, and more deeply indented than bays. NIMA GNS designator GULF.
    /// <see href="http://www.ontotext.com/proton/protonext#Gulf"></see></summary>
    let Gulf = _prefix "Gulf"
    /// <summary>
    /// A seamount having a comparatively smooth, flat top
    /// <see href="http://www.ontotext.com/proton/protonext#Guyot"></see></summary>
    let Guyot = _prefix "Guyot"
    /// <summary>
    /// Any Handball league
    /// <see href="http://www.ontotext.com/proton/protonext#HandballLeague"></see></summary>
    let HandballLeague = _prefix "HandballLeague"
    /// <summary>
    /// (ADL FT) Sheltered areas of water where ships or other watercraft can anchor or dock. We use this category for anchorages; for anclajes; for boat yards; for boatyards; for dock yards; for docking basins; for dockyards; for dry docks; for harbors; for marine terminals; for moorings; for ports; for roadsteads (anchorages); and for turning basins. The following sub-classes included (i.e. not-distinguishable): Marinas, Piers. NIMA GNS designators HBR, HBRX, MAR, BTYD, PIER, DCK, DCKB, DCKY, PRT, AIRS.
    /// <see href="http://www.ontotext.com/proton/protonext#Harbor"></see></summary>
    let Harbor = _prefix "Harbor"
    /// <summary>
    /// An upland moor or sandy area dominated by low shrubby vegetation including heather
    /// <see href="http://www.ontotext.com/proton/protonext#Heath"></see></summary>
    let Heath = _prefix "Heath"
    /// <summary>
    /// Any Historic Building, an old building with historic value.
    /// <see href="http://www.ontotext.com/proton/protonext#HistoricBuilding"></see></summary>
    let HistoricBuilding = _prefix "HistoricBuilding"
    /// <summary>
    /// Any place with some particular value, which triggers interest.
    /// <see href="http://www.ontotext.com/proton/protonext#LocationOfSpecialInterest"></see></summary>
    let LocationOfSpecialInterest = _prefix "LocationOfSpecialInterest"
    /// <summary>
    /// Any Hockey team
    /// <see href="http://www.ontotext.com/proton/protonext#HockeyTeam"></see></summary>
    let HockeyTeam = _prefix "HockeyTeam"
    /// <summary>
    /// A Holiday is a day designated as having special significance for which individuals, a government, or a religious group have deemed that observance is warranted. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#Holiday"></see></summary>
    let Holiday = _prefix "Holiday"
    /// <summary>
    /// The web page address of a page that is considered main for a web cite.
    /// <see href="http://www.ontotext.com/proton/protonext#HomePage"></see></summary>
    let HomePage = _prefix "HomePage"
    /// <summary>
    /// The internet address of a web page on the net.
    /// <see href="http://www.ontotext.com/proton/protonext#WebPage"></see></summary>
    let WebPage = _prefix "WebPage"
    /// <summary>
    /// Any Hospital, a building which is a hospital.
    /// <see href="http://www.ontotext.com/proton/protonext#Hospital"></see></summary>
    let Hospital = _prefix "Hospital"
    /// <summary>
    /// A hotel is an establishment that provides paid lodging on a short-term basis. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#Hotel"></see></summary>
    let Hotel = _prefix "Hotel"
    /// <summary>
    /// Human is a mammal referred to Primate. Also of the sort of hommo sapiens. It has two subClasses: Man and Woman.
    /// <see href="http://www.ontotext.com/proton/protonext#Human"></see></summary>
    let Human = _prefix "Human"
    /// <summary>
    /// Mammals are members of a class of air-breathing vertebrate animals characterized by the possession of hair, three middle ear bones, and mammary glands functional in mothers with young. Most mammals also possess sweat glands and specialized teeth, and the largest group of mammals, the placentals, have a placenta which feeds the offspring during gestation. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Mammal"></see></summary>
    let Mammal = _prefix "Mammal"
    /// <summary>
    /// An Internet Protocol address (IP address) is a numerical label assigned to each device (e.g., computer, printer) participating in a computer network that uses the Internet Protocol for communication. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#IPAddress"></see></summary>
    let IPAddress = _prefix "IPAddress"
    /// <summary>
    /// The ISBN (International Standard Book Number) is a unique machine-readable identification number, which marks any book unmistakably.
    /// <see href="http://www.ontotext.com/proton/protonext#ISBN"></see></summary>
    let ISBN = _prefix "ISBN"
    /// <summary>
    /// The ISSN (International Standard Serial Number) is an eight-digit number which identifies periodical publications as such, including electronic serials. More than one million ISSN numbers have so far been assigned.
    /// <see href="http://www.ontotext.com/proton/protonext#ISSN"></see></summary>
    let ISSN = _prefix "ISSN"
    /// <summary>
    /// A periodical publication, disregarding its specific issues, numbers, volumes, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#PeriodicalPublication"></see></summary>
    let PeriodicalPublication = _prefix "PeriodicalPublication"
    /// <summary>
    /// Any Ice Hockey league
    /// <see href="http://www.ontotext.com/proton/protonext#IceHockeyLeague"></see></summary>
    let IceHockeyLeague = _prefix "IceHockeyLeague"
    /// <summary>
    /// The profession of ice hockey player
    /// <see href="http://www.ontotext.com/proton/protonext#IceHockeyPlayer"></see></summary>
    let IceHockeyPlayer = _prefix "IceHockeyPlayer"
    /// <summary>
    /// A dome-shaped mass of glacial ice covering an area of mountain summits or other high lands; smaller than an ice sheet
    /// <see href="http://www.ontotext.com/proton/protonext#Icecap"></see></summary>
    let Icecap = _prefix "Icecap"
    /// <summary>
    /// An ideology is a set of ideas that constitute one's goals, expectations, and actions. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#Ideology"></see></summary>
    let Ideology = _prefix "Ideology"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#ImageDocument"></see>
    /// </summary>
    let ImageDocument = _prefix "ImageDocument"
    /// <summary>
    /// A classification of companies that have similar production processes, similar products, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#IndustrySector"></see></summary>
    let IndustrySector = _prefix "IndustrySector"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#InformationSpace"></see>
    /// </summary>
    let InformationSpace = _prefix "InformationSpace"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#InformationSpaceProfile"></see>
    /// </summary>
    let InformationSpaceProfile = _prefix "InformationSpaceProfile"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#Profile"></see>
    /// </summary>
    let Profile = _prefix "Profile"
    /// <summary>
    /// Any Inline Hockey league
    /// <see href="http://www.ontotext.com/proton/protonext#InlineHockeyLeague"></see></summary>
    let InlineHockeyLeague = _prefix "InlineHockeyLeague"
    /// <summary>
    /// Insects are a class within the arthropods that have a chitinous exoskeleton, a three-part body (head, thorax, and abdomen), three pairs of jointed legs, compound eyes, and two antennae. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Insect"></see></summary>
    let Insect = _prefix "Insect"
    /// <summary>
    /// A research organization devoted primarily on search in some scientific research.
    /// <see href="http://www.ontotext.com/proton/protonext#Institute"></see></summary>
    let Institute = _prefix "Institute"
    /// <summary>
    /// An organization performing scientific research.
    /// <see href="http://www.ontotext.com/proton/protonext#ResearchOrganization"></see></summary>
    let ResearchOrganization = _prefix "ResearchOrganization"
    /// <summary>
    /// A company providing insurance services agains different dangerous or risky events.
    /// <see href="http://www.ontotext.com/proton/protonext#InsuranceCompany"></see></summary>
    let InsuranceCompany = _prefix "InsuranceCompany"
    /// <summary>
    /// Legal international organization. Legal in this case means officially recognized by more than one government.
    /// <see href="http://www.ontotext.com/proton/protonext#InternationalOrganization"></see></summary>
    let InternationalOrganization = _prefix "InternationalOrganization"
    /// <summary>
    /// A domain name is an identification string that defines the area of administrative autonomy, authority, or control in the Internet. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#InternetDomain"></see></summary>
    let InternetDomain = _prefix "InternetDomain"
    /// <summary>
    /// A network of ditches and one or more of the following elements: water supply, reservoir, canal, pump, well, drain, etc. NIMA GNS designator H.SYSI.
    /// <see href="http://www.ontotext.com/proton/protonext#IrrigationSystem"></see></summary>
    let IrrigationSystem = _prefix "IrrigationSystem"
    /// <summary>
    /// A specific issue, number, and/or volume of periodical publication such as magazine.
    /// <see href="http://www.ontotext.com/proton/protonext#IssueOfPeriodical"></see></summary>
    let IssueOfPeriodical = _prefix "IssueOfPeriodical"
    /// <summary>
    /// (ADL FT) Narrow sections of land in a body of water connecting two larger land areas. NIMA GNS designator ISTH.
    /// <see href="http://www.ontotext.com/proton/protonext#Isthmus"></see></summary>
    let Isthmus = _prefix "Isthmus"
    /// <summary>
    /// Any journalist, a profession of collecting and disseminating information about current events, people, trends, and issues. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Journalist"></see></summary>
    let Journalist = _prefix "Journalist"
    /// <summary>
    /// Any judge, a profession of presiding over a court of law, either alone or as part of a panel of judges. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Judge"></see></summary>
    let Judge = _prefix "Judge"
    /// <summary>
    /// (ADL FT) Tropical regions of wild, tangled, dense vegetation. NIMA GNS designator - no equivalent.
    /// <see href="http://www.ontotext.com/proton/protonext#Jungle"></see></summary>
    let Jungle = _prefix "Jungle"
    /// <summary>
    /// Any Lacrosse league
    /// <see href="http://www.ontotext.com/proton/protonext#LacrosseLeague"></see></summary>
    let LacrosseLeague = _prefix "LacrosseLeague"
    /// <summary>
    /// A body of water cut off from the open sea by coral reefs or sand bars. http://www.eionet.europa.eu/gemet/concept/4589. NIMA GNS designator H.LGN, H.LGNS, H.LGNX.
    /// <see href="http://www.ontotext.com/proton/protonext#Lagoon"></see></summary>
    let Lagoon = _prefix "Lagoon"
    /// <summary>
    /// (ADL FT) Use 'reservoirs' for human engineered lakes. Natural inland bodies of standing water, generally of appreciable size, occupying a depression in the Earth's surface. [Adapted from Glossary of Geology, 4th ed.] We use this category for beaver ponds; for crater lakes; for dry lakes; for fish ponds; for fishponds; for inland seas; for intermittent lakes; for intermittent oxbow lakes; for intermittent ponds; for intermittent pools; for intermittent salt lakes; for intermittent salt ponds; for lagoons; for laguna; for lake beds; for lochs; for millponds; for oxbow lakes; for ponds; for pools (water bodies); for salt evaporation ponds; for salt lakes; for salt ponds; and for tarns. NIMA GNS designators LBED, LK, LKC, LKI, LKN, LKNI, LKO, LKOI, LKS, LKSB, LKSC, LKSI, LKSN, LKSNI, LKX
    /// <see href="http://www.ontotext.com/proton/protonext#Lake"></see></summary>
    let Lake = _prefix "Lake"
    /// <summary>
    /// A tract of land without homogeneous character or boundaries. NIMA GNS designator L.AREA.
    /// <see href="http://www.ontotext.com/proton/protonext#LandArea"></see></summary>
    let LandArea = _prefix "LandArea"
    /// <summary>
    /// (ADL FT) Areas from which rockets/missiles may be housed and projected, usually equipped with associated buildings and facilities. [USGS Circ 1048] We use this category for missile sites. NIMA GNS designator - no equivalent.
    /// <see href="http://www.ontotext.com/proton/protonext#LaunchFacility"></see></summary>
    let LaunchFacility = _prefix "LaunchFacility"
    /// <summary>
    /// A law firm is a business entity formed by one or more lawyers to engage in the practice of law. The primary service provided by a law firm is to advise clients (individuals or corporations) about their legal rights and responsibilities, and to represent their clients in civil or criminal cases, business transactions, and other matters in which legal advice and other assistance are sought. DBPedia
    /// <see href="http://www.ontotext.com/proton/protonext#LawFirm"></see></summary>
    let LawFirm = _prefix "LawFirm"
    /// <summary>
    /// Any lawyer, a profession of according to Black's Law Dictionary, is a person learned in the law; as an attorney, counsel or solicitor; a person who is practicing law. of judges. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Lawyer"></see></summary>
    let Lawyer = _prefix "Lawyer"
    /// <summary>
    /// Denotes concrete legal cases, such as Dennis v. United States, Francis v. Resweber, United_States v. Virginia, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#LegalCases"></see></summary>
    let LegalCases = _prefix "LegalCases"
    /// <summary>
    /// Various sorts of legislative documents, including consitutions, laws, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Legislation"></see></summary>
    let Legislation = _prefix "Legislation"
    /// <summary>
    /// A collection of books, journals, audio and video materials, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Library"></see></summary>
    let Library = _prefix "Library"
    /// <summary>
    /// A collection is an aggregation of information resources. The term collection means that the resource is described as a group; its parts may be separately described and navigated. (DCMI type Collection)
    /// <see href="http://www.ontotext.com/proton/protonext#ResourceCollection"></see></summary>
    let ResourceCollection = _prefix "ResourceCollection"
    /// <summary>
    /// A building in which library organization is housed.
    /// <see href="http://www.ontotext.com/proton/protonext#LibraryBuilding"></see></summary>
    let LibraryBuilding = _prefix "LibraryBuilding"
    /// <summary>
    /// An education organization teaching pupils from first grade to tenth/eleventh/twelfth grade. It could be a primary school, or a secondary school.
    /// <see href="http://www.ontotext.com/proton/protonext#LibraryOrganization"></see></summary>
    let LibraryOrganization = _prefix "LibraryOrganization"
    /// <summary>
    /// Any lieutenant, title in a military unit.
    /// <see href="http://www.ontotext.com/proton/protonext#Lieutenant"></see></summary>
    let Lieutenant = _prefix "Lieutenant"
    /// <summary>
    /// A tower, building, or other type of structure designed to emit light from a system of lamps and lenses and used as an aid to navigation for maritime pilots at sea or on inland waterways
    /// <see href="http://www.ontotext.com/proton/protonext#LightHouse"></see></summary>
    let LightHouse = _prefix "LightHouse"
    /// <summary>
    /// (ADL FT) We use this category for astronomical stations; for beacons; for bench marks; for boundaries; for boundary markers; for buoys; for control points; for geodectic stations; for geographic centers; for landmarks (reference locations); for light houses; for light stations; for lighthouses; for markers; for milestones; for plaques; for poles (sphere); for triangulation stations; and for walls. NIMNA GNS designators LTHSE, BP, TRIG.
    /// <see href="http://www.ontotext.com/proton/protonext#ReferenceLocation"></see></summary>
    let ReferenceLocation = _prefix "ReferenceLocation"
    /// <summary>
    /// A capital of a Province or smaller administrative region. NIMA GNS designator PPLA.
    /// <see href="http://www.ontotext.com/proton/protonext#LocalCapital"></see></summary>
    let LocalCapital = _prefix "LocalCapital"
    /// <summary>
    /// (ADL FT) Stretches of water in canals, streams, or docks, enclosed by gates at each end, and used in raising and lowering boats as they pass from one water level to another. NIMA GNS designator LOCK.
    /// <see href="http://www.ontotext.com/proton/protonext#Lock"></see></summary>
    let Lock = _prefix "Lock"
    /// <summary>
    /// Locomotive, a railway vehicle that provides the motive power for a train. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Locomotive"></see></summary>
    let Locomotive = _prefix "Locomotive"
    /// <summary>
    /// Lymph is a general concept gathering all lymph nodes of the body.
    /// <see href="http://www.ontotext.com/proton/protonext#LymphNode"></see></summary>
    let LymphNode = _prefix "LymphNode"
    /// <summary>
    /// A specific issue of a magazine, journal or digest.
    /// <see href="http://www.ontotext.com/proton/protonext#MagazineIssue"></see></summary>
    let MagazineIssue = _prefix "MagazineIssue"
    /// <summary>
    /// A male human.
    /// <see href="http://www.ontotext.com/proton/protonext#Man"></see></summary>
    let Man = _prefix "Man"
    /// <summary>
    /// Any manager, the title of a management position in an organization.
    /// <see href="http://www.ontotext.com/proton/protonext#Manager"></see></summary>
    let Manager = _prefix "Manager"
    /// <summary>
    /// In contrast to IndustrySector, the market is determined by the customers instead of the business or the manifacturers. The market can be defined in terms of types of goods/services, geographic region, price levels and typical customer behaviours. Corresponding to the third sense in WordNet 1.7.1 "the customers for a particular product or service".
    /// <see href="http://www.ontotext.com/proton/protonext#Market"></see></summary>
    let Market = _prefix "Market"
    /// <summary>
    /// An area of open ground overlaid with wet peaty soils; a wetland dominated by grass-like vegetation; a flat area, subject to periodic salt water inundation, dominated by grassy salt-tolerant plants; a salt flat or salt encrusted plain subject to periodic inundation from flooding or high tides
    /// <see href="http://www.ontotext.com/proton/protonext#Marsh"></see></summary>
    let Marsh = _prefix "Marsh"
    /// <summary>
    /// The profession of a martial artist
    /// <see href="http://www.ontotext.com/proton/protonext#MartialArtist"></see></summary>
    let MartialArtist = _prefix "MartialArtist"
    /// <summary>
    /// Any Mayor, a title of the head of a municipality.
    /// <see href="http://www.ontotext.com/proton/protonext#Mayor"></see></summary>
    let Mayor = _prefix "Mayor"
    /// <summary>
    /// A small, poorly drained area dominated by grassy vegetation
    /// <see href="http://www.ontotext.com/proton/protonext#Meadow"></see></summary>
    let Meadow = _prefix "Meadow"
    /// <summary>
    /// A brand of a media company.
    /// <see href="http://www.ontotext.com/proton/protonext#MediaBrand"></see></summary>
    let MediaBrand = _prefix "MediaBrand"
    /// <summary>
    /// A mass media product (for instance a newspaper) abstracted from its organizational and ownership aspects (i.e. from its publisher) and considered more as a social phenomenon, partly a brand.
    /// <see href="http://www.ontotext.com/proton/protonext#MediaProduct"></see></summary>
    let MediaProduct = _prefix "MediaProduct"
    /// <summary>
    /// A collection of articles or presentations published as a book.
    /// <see href="http://www.ontotext.com/proton/protonext#MeetingProceedings"></see></summary>
    let MeetingProceedings = _prefix "MeetingProceedings"
    /// <summary>
    /// Any member of parliament, a title of a member of parliament.
    /// <see href="http://www.ontotext.com/proton/protonext#MemberOfParliament"></see></summary>
    let MemberOfParliament = _prefix "MemberOfParliament"
    /// <summary>
    /// An area of a document that can be considered a mention of something.
    /// <see href="http://www.ontotext.com/proton/protonext#Mention"></see></summary>
    let Mention = _prefix "Mention"
    /// <summary>
    /// A written message, including various postings in newspapers or public sources, job position adverts, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Message"></see></summary>
    let Message = _prefix "Message"
    /// <summary>
    /// Any military command, the organization which has a commanding role in a military organization.
    /// <see href="http://www.ontotext.com/proton/protonext#MilitaryCommand"></see></summary>
    let MilitaryCommand = _prefix "MilitaryCommand"
    /// <summary>
    /// Any military unit, a smaller military organization.
    /// <see href="http://www.ontotext.com/proton/protonext#MilitaryUnit"></see></summary>
    let MilitaryUnit = _prefix "MilitaryUnit"
    /// <summary>
    /// An event of organized, armed, and often prolonged conflict carried on between states, nations, or other parties. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#MilitaryConflict"></see></summary>
    let MilitaryConflict = _prefix "MilitaryConflict"
    /// <summary>
    /// Any military organisation, the structuring of the armed forces of a state so as to offer military capability required by the national defence policy. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#MilitaryOrganization"></see></summary>
    let MilitaryOrganization = _prefix "MilitaryOrganization"
    /// <summary>
    /// Any occupation involving service in the military.
    /// <see href="http://www.ontotext.com/proton/protonext#MilitaryPerson"></see></summary>
    let MilitaryPerson = _prefix "MilitaryPerson"
    /// <summary>
    /// (ADL FT) Places or areas from which commercial minerals are or were removed by excavation from the Earth. [Adapted from USGS Feature Class Definitions &lt;http://mapping.usgs.gov/www/ti/GNIS/gnis_users_guide_appendixc.html&gt;] We use this category for adits (mine sites); for chrome mines; for coal mines; for collieries; for copper mines; for diatomite mines; for gold mines; for gravel pits; for iron mines; for lead mines; for mine entrances; for mine shafts; for mines; for mining areas; for mining camps; for nickel mines; for open pit mines; for placer mines; for quarries; for salt mines; for strip mines; and for tin mines. NIMA GNS designators MN, MNA, MNAU, MNC, MNCR, MNDT, MNCU, MNFE, MNN, MNNI, MNPB, MNPL. MNQ, MNSN.
    /// <see href="http://www.ontotext.com/proton/protonext#MineSite"></see></summary>
    let MineSite = _prefix "MineSite"
    /// <summary>
    /// (Department) A specific ministry or department, structural unit of the government of specific country with focus and authority on specific problems of the country.
    /// <see href="http://www.ontotext.com/proton/protonext#Ministry"></see></summary>
    let Ministry = _prefix "Ministry"
    /// <summary>
    /// Any Mixed Martial Arts league
    /// <see href="http://www.ontotext.com/proton/protonext#MixedMartialArtsLeague"></see></summary>
    let MixedMartialArtsLeague = _prefix "MixedMartialArtsLeague"
    /// <summary>
    /// Mollusca is a large phylum of invertebrate animals. This is the largest marine phylum, comprising about 23% of all the named marine organisms. Numerous molluscs also live in freshwater and terrestrial habitats. Molluscs are highly diverse, not only in size and in anatomical structure, but also in behaviour and in habitat. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Mollusca"></see></summary>
    let Mollusca = _prefix "Mollusca"
    /// <summary>
    /// Any Monarch, a title of a head of state in a monarchy.
    /// <see href="http://www.ontotext.com/proton/protonext#Monarch"></see></summary>
    let Monarch = _prefix "Monarch"
    /// <summary>
    /// A specific amount of money in specific currency
    /// <see href="http://www.ontotext.com/proton/protonext#Money"></see></summary>
    let Money = _prefix "Money"
    /// <summary>
    /// A specific month, like Dec 2000, as a time period.
    /// <see href="http://www.ontotext.com/proton/protonext#Month"></see></summary>
    let Month = _prefix "Month"
    /// <summary>
    /// (ADL FT) Structures erected as memorials. [Adapted from American Heritage Dic. of the English Language, 4th ed.] We use this category for cairns; for landmarks (monuments); for memorials; for national monuments; for pyramids; for shrines; for statues; and for tombs. NIMA GNS designators MNMT, PYR, PYRS, CARN.
    /// <see href="http://www.ontotext.com/proton/protonext#Monument"></see></summary>
    let Monument = _prefix "Monument"
    /// <summary>
    /// Any Motorcycle Racing league
    /// <see href="http://www.ontotext.com/proton/protonext#MotorcycleRacingLeague"></see></summary>
    let MotorcycleRacingLeague = _prefix "MotorcycleRacingLeague"
    /// <summary>
    /// (ADL FT) Landmasses that project conspicuously above their surroundings. [USGS Circ 1048] We use this category for cerros; for cordilleras; for foothills; for hills; for knolls; for mounds; and for mounts. Omitted ADL sub-classes: Continental divides. NIMA GNS designator MT, MTS, MTSU, MTU, MND, KNLU, KNSU, CDAU, HLL, HLLS, HLLU, HLSU.
    /// <see href="http://www.ontotext.com/proton/protonext#Mountain"></see></summary>
    let Mountain = _prefix "Mountain"
    /// <summary>
    /// Any mountain pass. NIMA GNS designators - no direct equivalents
    /// <see href="http://www.ontotext.com/proton/protonext#MountainPass"></see></summary>
    let MountainPass = _prefix "MountainPass"
    /// <summary>
    /// (ADL FT) (a) Chains of hills or mountains; (b) somewhat linear, complex mountainous or hilly areas. ... We use this category for ranges (physiographic); and for sierra. NIMA GNS designator RNGU.
    /// <see href="http://www.ontotext.com/proton/protonext#MountainRange"></see></summary>
    let MountainRange = _prefix "MountainRange"
    /// <summary>
    /// (ADL FT) Peaks of mountains. [USGS Circ 1048] We use this category for ahus; for mountain crests; for nunataks; for peaks; and for summits. NIMA GNS designators PK, PKS, PKSU, PKU.
    /// <see href="http://www.ontotext.com/proton/protonext#MountainSummit"></see></summary>
    let MountainSummit = _prefix "MountainSummit"
    /// <summary>
    /// A film, also called a movie or motion picture, is a series of still or moving images. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#Movie"></see></summary>
    let Movie = _prefix "Movie"
    /// <summary>
    /// A relatively level area of mud either between high and low tide lines, or subject to flooding; a large flat area of mud or sand attached to the shore and alternately covered and uncovered by the tide; a tropical tidal mud flat characterized by mangrove vegetation
    /// <see href="http://www.ontotext.com/proton/protonext#MudFlat"></see></summary>
    let MudFlat = _prefix "MudFlat"
    /// <summary>
    /// Any muscle of a body.
    /// <see href="http://www.ontotext.com/proton/protonext#Muscle"></see></summary>
    let Muscle = _prefix "Muscle"
    /// <summary>
    /// Any museum, an institution that houses and cares for a collection of artifacts and other objects of scientific, artistic, or historical importance and makes them available for public viewing through exhibits that may be permanent or temporary. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Museum"></see></summary>
    let Museum = _prefix "Museum"
    /// <summary>
    /// Any Musical company, a company involved in the music business, e.g. sells compositions, recordings and performances of music, like Soni Music Entertainment.
    /// <see href="http://www.ontotext.com/proton/protonext#MusicCompany"></see></summary>
    let MusicCompany = _prefix "MusicCompany"
    /// <summary>
    /// Any festival involving playing music.
    /// <see href="http://www.ontotext.com/proton/protonext#MusicFestival"></see></summary>
    let MusicFestival = _prefix "MusicFestival"
    /// <summary>
    /// Any genre which pertians to music, e.g. classical, folk, pop, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#MusicGenre"></see></summary>
    let MusicGenre = _prefix "MusicGenre"
    /// <summary>
    /// Musical is a form of theatre or movie combining music, songs, spoken dialogue and dance. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Musical"></see></summary>
    let Musical = _prefix "Musical"
    /// <summary>
    /// Musical Instrument, a device created or adapted for the purpose of making musical sounds. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#MusicalInstrument"></see></summary>
    let MusicalInstrument = _prefix "MusicalInstrument"
    /// <summary>
    /// Any musician, a profession of writing, performing, or making music. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Musician"></see></summary>
    let Musician = _prefix "Musician"
    /// <summary>
    /// A tidal strait. NIMA GNS designator H.NRWS.
    /// <see href="http://www.ontotext.com/proton/protonext#Narrows"></see></summary>
    let Narrows = _prefix "Narrows"
    /// <summary>
    /// The profession of nascar driver
    /// <see href="http://www.ontotext.com/proton/protonext#NascarDriver"></see></summary>
    let NascarDriver = _prefix "NascarDriver"

    /// <summary>
    /// The profession of national collegiate athletic association athlete
    /// <see href="http://www.ontotext.com/proton/protonext#NationalCollegiateAthleticAssociationAthlete"></see></summary>
    let NationalCollegiateAthleticAssociationAthlete =
        _prefix "NationalCollegiateAthleticAssociationAthlete"

    /// <summary>
    /// Any nationality. In most cases it is connected with a country name, but there are notionalities without countries - Kurd, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Nationality"></see></summary>
    let Nationality = _prefix "Nationality"
    /// <summary>
    /// Such as particular disease, the Gulfstream and other similar natural abstractions. The particular events or objects which could instantiate an abstract natural phenomena (i.e. specific sickness event caused by a disease) are not instances of this class.
    /// <see href="http://www.ontotext.com/proton/protonext#NaturalPhenomenon"></see></summary>
    let NaturalPhenomenon = _prefix "NaturalPhenomenon"
    /// <summary>
    /// A satellite which is not a direct result of human activity
    /// <see href="http://www.ontotext.com/proton/protonext#NaturalSatellite"></see></summary>
    let NaturalSatellite = _prefix "NaturalSatellite"
    /// <summary>
    /// Nerve is a general concept gathering all nerves of a body.
    /// <see href="http://www.ontotext.com/proton/protonext#Nerve"></see></summary>
    let Nerve = _prefix "Nerve"
    /// <summary>
    /// A news agency is an organization of journalists established to supply news reports to news organizations: newspapers, magazines, and radio and television broadcasters. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#NewsAgency"></see></summary>
    let NewsAgency = _prefix "NewsAgency"
    /// <summary>
    /// A newspaper abstracted from its organizational and ownership aspects as well as from a specific issue or paper body.
    /// <see href="http://www.ontotext.com/proton/protonext#Newspaper"></see></summary>
    let Newspaper = _prefix "Newspaper"
    /// <summary>
    /// A specific issue of a newspaper.
    /// <see href="http://www.ontotext.com/proton/protonext#NewspaperIssue"></see></summary>
    let NewspaperIssue = _prefix "NewspaperIssue"
    /// <summary>
    /// The situation of holding a position in society as nobelty.
    /// <see href="http://www.ontotext.com/proton/protonext#Nobelty"></see></summary>
    let Nobelty = _prefix "Nobelty"
    /// <summary>
    /// A type (specific receipe) for a beverage. For instance: Coca Cola, Schweppes, Apple Juice, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#NonAlcoholicBeverage"></see></summary>
    let NonAlcoholicBeverage = _prefix "NonAlcoholicBeverage"
    /// <summary>
    /// A non-geographic region in some 3D space. The Longitude and Latitude properties for such objects could be void.
    /// <see href="http://www.ontotext.com/proton/protonext#NonGeographicLocation"></see></summary>
    let NonGeographicLocation = _prefix "NonGeographicLocation"
    /// <summary>
    /// (ADL FT) Fertile, vegetated areas in the midst of a desert, where the water table has come close enough to the surface for wells and springs or seepages to exist, thus making them suitable for human habitation. NIMA GNS designator OAS.
    /// <see href="http://www.ontotext.com/proton/protonext#Oasis"></see></summary>
    let Oasis = _prefix "Oasis"
    /// <summary>
    /// (ADL FT) Continuous salt-water bodies that surround the continents and fill the Earth's great depressions. NIMA GNS designator OCN
    /// <see href="http://www.ontotext.com/proton/protonext#Ocean"></see></summary>
    let Ocean = _prefix "Ocean"
    /// <summary>
    /// (ADL FT) Large bodies of salt water. NIMA GNS designator SEA
    /// <see href="http://www.ontotext.com/proton/protonext#Sea"></see></summary>
    let Sea = _prefix "Sea"
    /// <summary>
    /// Something offered (as a proposal or bid), WordNet 1.7.1. An offer is a statement made by the offerer to a specific agent or without recepient.
    /// <see href="http://www.ontotext.com/proton/protonext#Offer"></see></summary>
    let Offer = _prefix "Offer"
    /// <summary>
    /// A meeting whose main participants are political entities playing official roles within it.
    /// <see href="http://www.ontotext.com/proton/protonext#OfficialPoliticalMeeting"></see></summary>
    let OfficialPoliticalMeeting = _prefix "OfficialPoliticalMeeting"
    /// <summary>
    /// A job position having a representative function with respect to an organization. Usually this is a position within a governmental organization.
    /// <see href="http://www.ontotext.com/proton/protonext#OfficialPosition"></see></summary>
    let OfficialPosition = _prefix "OfficialPosition"
    /// <summary>
    /// (ADL FT) Areas with reserves of recoverable petroleum or where petroleum has been removed from the Earth. ... We use this category for gas fields; for gasfields; for oilfields; for petroleum fields; and for storage fields (petroleum). NIMA GNS designator CMPO, OILF, OILQ, OILW, PMPO, GASF.
    /// <see href="http://www.ontotext.com/proton/protonext#OilField"></see></summary>
    let OilField = _prefix "OilField"
    /// <summary>
    /// The institution of Olympic Games held every 4 years
    /// <see href="http://www.ontotext.com/proton/protonext#OlympicGames"></see></summary>
    let OlympicGames = _prefix "OlympicGames"
    /// <summary>
    /// A specific issue of the games, like Athens 2004
    /// <see href="http://www.ontotext.com/proton/protonext#OlympicGamesOccurrence"></see></summary>
    let OlympicGamesOccurrence = _prefix "OlympicGamesOccurrence"
    /// <summary>
    /// An event involving use, maintain or improve of physical fitness of its participants. Usually it is organized.
    /// <see href="http://www.ontotext.com/proton/protonext#SportEvent"></see></summary>
    let SportEvent = _prefix "SportEvent"
    /// <summary>
    /// An art performance following an opera music and script.
    /// <see href="http://www.ontotext.com/proton/protonext#OperaPerformance"></see></summary>
    let OperaPerformance = _prefix "OperaPerformance"
    /// <summary>
    /// A planting of fruit or nut trees
    /// <see href="http://www.ontotext.com/proton/protonext#Orchard"></see></summary>
    let Orchard = _prefix "Orchard"
    /// <summary>
    /// A statement used to request someone to supply something in return for payment and providing specifications and quantities. WordNet 2.1.
    /// <see href="http://www.ontotext.com/proton/protonext#Order"></see></summary>
    let Order = _prefix "Order"
    /// <summary>
    /// The situation of holding a position in a society as out of law.
    /// <see href="http://www.ontotext.com/proton/protonext#OutOfLaws"></see></summary>
    let OutOfLaws = _prefix "OutOfLaws"
    /// <summary>
    /// Criminal, the social function of a person who has committed a crime and is out of the law.
    /// <see href="http://www.ontotext.com/proton/protonext#OutOfLawsTitle"></see></summary>
    let OutOfLawsTitle = _prefix "OutOfLawsTitle"
    /// <summary>
    /// An area of breaking waves caused by the meeting of currents or by waves moving against the current. NIMA GNS designator H.OVF.
    /// <see href="http://www.ontotext.com/proton/protonext#Overfalls"></see></summary>
    let Overfalls = _prefix "Overfalls"
    /// <summary>
    /// Any Paintball league
    /// <see href="http://www.ontotext.com/proton/protonext#PaintballLeague"></see></summary>
    let PaintballLeague = _prefix "PaintballLeague"
    /// <summary>
    /// Any painting, the results of a practice of applying paint, pigment, color or other medium[1] to a surface (support base). (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Painting"></see></summary>
    let Painting = _prefix "Painting"
    /// <summary>
    /// An artifact, namely a piece of art, usually, matterial object. Typical instances are paintings and sculptures. Corresponds to the Wordnet 1.7.1 synset "art, fine art - the products of human creativity; works of art collectively; "an art exhibition"@en ; "a fine collection of art")"
    /// <see href="http://www.ontotext.com/proton/protonext#PieceOfArt"></see></summary>
    let PieceOfArt = _prefix "PieceOfArt"
    /// <summary>
    /// A district of religious land. NIMA GNS designator A.PRSH.
    /// <see href="http://www.ontotext.com/proton/protonext#Parish"></see></summary>
    let Parish = _prefix "Parish"
    /// <summary>
    /// (ADL FT) Places or areas developed for public use or recreation. [USGS Circ 1048] We use this category for arboretums; for botanical gardens; for commemorative areas; for commons; for gardens; for marine parks; for national forests; for national parks; for national seashores; for park gates; for picnic areas; for playgrounds; for provincial parks; for public use areas; for recreation areas; for rest areas; for scenic areas; for state forests; for state parks; for urban parks; for village squares; for wilderness areas; for zoological gardens; and for zoos. Omitted sub-classes: Viewing locations. NIMA GNS designators PRK, PRKHQ, PRKGT
    /// <see href="http://www.ontotext.com/proton/protonext#Park"></see></summary>
    let Park = _prefix "Park"
    /// <summary>
    /// A legislative assembly representative at national or regional level. It can also be called Senate, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Parliament"></see></summary>
    let Parliament = _prefix "Parliament"
    /// <summary>
    /// Any organization which has a political functions.
    /// <see href="http://www.ontotext.com/proton/protonext#PoliticalEntity"></see></summary>
    let PoliticalEntity = _prefix "PoliticalEntity"
    /// <summary>
    /// A registered (or awaiting registration) patent for specific invention or design.
    /// <see href="http://www.ontotext.com/proton/protonext#Patent"></see></summary>
    let Patent = _prefix "Patent"
    /// <summary>
    /// A land region surrounded by water from most sides, but having land connect to bigger land region. NIMA GNS designator PEN, PENX.
    /// <see href="http://www.ontotext.com/proton/protonext#Peninsula"></see></summary>
    let Peninsula = _prefix "Peninsula"
    /// <summary>
    /// A specific percent value
    /// <see href="http://www.ontotext.com/proton/protonext#Percent"></see></summary>
    let Percent = _prefix "Percent"
    /// <summary>
    /// Buildings where cultural events are presented before an audience. We use this category for amphitheaters; for amphitheatres; for auditoriums; for bowls (performance); for coliseums; for concert halls; for opera houses; for playhouses; for recital halls; for stages (performance); for symphony halls; for theaters; and for theatres. NIMA GNS designator AMTH.
    /// <see href="http://www.ontotext.com/proton/protonext#PerformanceSite"></see></summary>
    let PerformanceSite = _prefix "PerformanceSite"
    /// <summary>
    /// An area underlain by an oil-rich structural basin. NIMA GNS designator L.BSNP.
    /// <see href="http://www.ontotext.com/proton/protonext#PetroleumBasin"></see></summary>
    let PetroleumBasin = _prefix "PetroleumBasin"
    /// <summary>
    /// Any philosopher, a profession of studying of general and fundamental problems, such as those connected with existence, knowledge, values, reason, mind, and language.
    /// <see href="http://www.ontotext.com/proton/protonext#Philosopher"></see></summary>
    let Philosopher = _prefix "Philosopher"
    /// <summary>
    /// (ADL FT) Tubular conduits of substantial length, with pumps, valves, and control devices, for conveying fluids, gases, or finely divided solids. [USGS Circ 1048] We use this category for compressor stations; for gas pipelines; for oil pipeline junctions; for oil pipeline terminals; for oil pipelines; for oil pumping stations; for pump houses; for pumphouses; for pumping stations; and for water pumping stations. NIMA GNS designators OILP, OILJ, TRMO, PMPO, PMPW.
    /// <see href="http://www.ontotext.com/proton/protonext#Pipeline"></see></summary>
    let Pipeline = _prefix "Pipeline"
    /// <summary>
    /// (ADL FT) Regions of general uniform slope, comparatively level and of considerable extent. [USGS Circ 1048] We use this category for interfluves; and for llanos. NIMA GNS designators PLN, PLNU, PLNX, INTF.
    /// <see href="http://www.ontotext.com/proton/protonext#Plain"></see></summary>
    let Plain = _prefix "Plain"
    /// <summary>
    /// Any of the celestial bodies (other than comets or satellites) that revolve around the sun in the solar system. Definition partly derived from WordNet 1.7
    /// <see href="http://www.ontotext.com/proton/protonext#Planet"></see></summary>
    let Planet = _prefix "Planet"
    /// <summary>
    /// (ADL FT) Comparatively flat areas of great extent and elevation; specif. extensive land regions considerably above the adjacent country or above sea level; commonly limited on at least one side by an abrupt descent, have flat or nearly smooth surfaces but are often dissected by deep valleys and surmounted by high hills or mountains, and have a large part of their total surface at or near the summit level. We use this category for table mountains; and for tablelands. The ADL type Mesas, collapsed here. NIMA GNS designators PLAT, PLTX, PLTU, MESA, MESU, TMSU, TMST.
    /// <see href="http://www.ontotext.com/proton/protonext#Plateau"></see></summary>
    let Plateau = _prefix "Plateau"
    /// <summary>
    /// A play is a form of literature written by a playwright, usually consisting of scripted dialogue between characters, intended for theatrical performance rather than just reading. DBPedia
    /// <see href="http://www.ontotext.com/proton/protonext#Play"></see></summary>
    let Play = _prefix "Play"
    /// <summary>
    /// The occupation of playboy playmate
    /// <see href="http://www.ontotext.com/proton/protonext#PlayboyPlaymate"></see></summary>
    let PlayboyPlaymate = _prefix "PlayboyPlaymate"
    /// <summary>
    /// The profession of a poker player
    /// <see href="http://www.ontotext.com/proton/protonext#PokerPlayer"></see></summary>
    let PokerPlayer = _prefix "PokerPlayer"
    /// <summary>
    /// A title of Polish kings.
    /// <see href="http://www.ontotext.com/proton/protonext#PolishKing"></see></summary>
    let PolishKing = _prefix "PolishKing"
    /// <summary>
    /// An organization to gain political power. Definition taken from WordNet 1.7
    /// <see href="http://www.ontotext.com/proton/protonext#PoliticalParty"></see></summary>
    let PoliticalParty = _prefix "PoliticalParty"
    /// <summary>
    /// Any Politician, a profession of participating in the political life of a given society.
    /// <see href="http://www.ontotext.com/proton/protonext#Politician"></see></summary>
    let Politician = _prefix "Politician"
    /// <summary>
    /// Any Polo league
    /// <see href="http://www.ontotext.com/proton/protonext#PoloLeague"></see></summary>
    let PoloLeague = _prefix "PoloLeague"
    /// <summary>
    /// A pond is a body of standing water, either natural or man-made, that is usually smaller than a lake. (Wikipedia). http://www.eionet.europa.eu/gemet/concept/6507. NIMA GNS designator H.PND, H.PNDI, H.PNDN, H.PNDNI, H.PNDS, H.PNDSF, H.PNDSI, H.PNDSN, H.MFGN.
    /// <see href="http://www.ontotext.com/proton/protonext#Pond"></see></summary>
    let Pond = _prefix "Pond"
    /// <summary>
    /// A small and comparatively still, deep part of a larger body of water. NIMA GNS designator H.POOL, H.POOLI.
    /// <see href="http://www.ontotext.com/proton/protonext#Pool"></see></summary>
    let Pool = _prefix "Pool"
    /// <summary>
    /// Any Pope. the head of the Roman-Catholic church.
    /// <see href="http://www.ontotext.com/proton/protonext#Pope"></see></summary>
    let Pope = _prefix "Pope"
    /// <summary>
    /// Part of a postal address denoting the name of a village, town, city, country, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#PopulatedPlaceName"></see></summary>
    let PopulatedPlaceName = _prefix "PopulatedPlaceName"
    /// <summary>
    /// The situation of a job position which is available in a particular organization, such as CEO, CTO, executive assistant, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#PositionOrganization"></see></summary>
    let PositionOrganization = _prefix "PositionOrganization"
    /// <summary>
    /// Any property, e.g. possessions, the situation of owning an object.
    /// <see href="http://www.ontotext.com/proton/protonext#Possession"></see></summary>
    let Possession = _prefix "Possession"
    /// <summary>
    /// An address of a geographical place - usually a building. A postal address consists, usually, of a country name, zip code, city/village name, street name and number, a person name.
    /// <see href="http://www.ontotext.com/proton/protonext#PostalAddress"></see></summary>
    let PostalAddress = _prefix "PostalAddress"
    /// <summary>
    /// Any power station
    /// <see href="http://www.ontotext.com/proton/protonext#PowerStation"></see></summary>
    let PowerStation = _prefix "PowerStation"
    /// <summary>
    /// Any president, a title of a president of a country or an organization.
    /// <see href="http://www.ontotext.com/proton/protonext#President"></see></summary>
    let President = _prefix "President"
    /// <summary>
    /// Any priest, a professsion of a person who is authorized to perform the sacred rites of a religion. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Priest"></see></summary>
    let Priest = _prefix "Priest"
    /// <summary>
    /// Any prime minister, a title Prime minister of a country.
    /// <see href="http://www.ontotext.com/proton/protonext#PrimeMinister"></see></summary>
    let PrimeMinister = _prefix "PrimeMinister"
    /// <summary>
    /// A formal language for encoding of computer programs.
    /// <see href="http://www.ontotext.com/proton/protonext#ProgrammingLanguage"></see></summary>
    let ProgrammingLanguage = _prefix "ProgrammingLanguage"
    /// <summary>
    /// A project is carefully planned event to achieve a particular aim. Based on Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// Any Protected Area, an area which benefits of special attention and is with limited access or protected in other ways.
    /// <see href="http://www.ontotext.com/proton/protonext#ProtectedArea"></see></summary>
    let ProtectedArea = _prefix "ProtectedArea"
    /// <summary>
    /// Denotes any protein as a biological substance.
    /// <see href="http://www.ontotext.com/proton/protonext#Protein"></see></summary>
    let Protein = _prefix "Protein"
    /// <summary>
    /// (ADL FT: Countries, 1st Order Divisions) First-order divisions of a nation. [USGS Circ 1048] We use this category for cantons; for first-order administrative divisions; for provinces; for states; and for territories. NIMA GNS designator ADM1. Also corresponds to the FIPS 10-4 principal administrative division defined as "an administrative area directly subordinate to the pertinent governing authority " NIMA GNS designator ADM1.
    /// <see href="http://www.ontotext.com/proton/protonext#Province"></see></summary>
    let Province = _prefix "Province"
    /// <summary>
    /// Company which is publicly traded on a Stock Exchange.
    /// <see href="http://www.ontotext.com/proton/protonext#PublicCompany"></see></summary>
    let PublicCompany = _prefix "PublicCompany"
    /// <summary>
    /// An organization which main activity is mass publishing of information. Often, the publishers issue periodic and/or non-periodic documents on paper media. While on-line publishing is considered a typical activity for publishers, the streaming electronic media such as TV and Radio Stations are not.
    /// <see href="http://www.ontotext.com/proton/protonext#PublishingCompany"></see></summary>
    let PublishingCompany = _prefix "PublishingCompany"
    /// <summary>
    /// A specific quarter of a specific year, such as Q4 1999
    /// <see href="http://www.ontotext.com/proton/protonext#Quarter"></see></summary>
    let Quarter = _prefix "Quarter"
    /// <summary>
    /// A racecourse is a horse racing track.
    /// <see href="http://www.ontotext.com/proton/protonext#RaceCourse"></see></summary>
    let RaceCourse = _prefix "RaceCourse"
    /// <summary>
    /// (ADL FT) Fields, centers, or open areas maintained for the purpose of holding sporting events and activities. [USGS Circ 1048] We use this category for aquatic centers; for arenas; for athletic complexes; for athletic fields; for ball parks; for baseball fields; for dragways; for equestrian centers; for fields; for football fields; for golf clubs; for golf courses; for gymnasiums; for natatoriums; for physical education facilities; for pistol ranges (sport); for polo fields; for pools, swimming; for race tracks; for racecourses; for racetracks; for raceways; for rifle ranges; for rodeo grounds; for shooting ranges (sport); for skeet shooting ranges; for ski areas; for ski facilities; for ski trails; for speedways; for stadiums; for swim clubs; for swimming pools; for tennis clubs; and for tennis courts. NIMA GNS designators RECG, RECR, STDM, ATHF.
    /// <see href="http://www.ontotext.com/proton/protonext#SportFacility"></see></summary>
    let SportFacility = _prefix "SportFacility"
    /// <summary>
    /// A company that broadcasts audio content.
    /// <see href="http://www.ontotext.com/proton/protonext#RadioCompany"></see></summary>
    let RadioCompany = _prefix "RadioCompany"
    /// <summary>
    /// Any Radio Controlled Racing league
    /// <see href="http://www.ontotext.com/proton/protonext#RadioControlledRacingLeague"></see></summary>
    let RadioControlledRacingLeague = _prefix "RadioControlledRacingLeague"
    /// <summary>
    /// A brand of a radio station.
    /// <see href="http://www.ontotext.com/proton/protonext#RadioStation"></see></summary>
    let RadioStation = _prefix "RadioStation"
    /// <summary>
    /// (ADL FT: Railroad Features) We use this category for metro rail stations; for railroad junctions; for railroad sidings; for railroad spurs; for railroad stations; for railroad stops; for railroad switches; for railroad yards; for railways; for subway stations; for switches (railroad); and for tramways. NIMA GNS designator RJCT, RR, RRQ, RSD, RSGNL, RSTN, RSTNQ, RSTP, RSTPQ, RYD.
    /// <see href="http://www.ontotext.com/proton/protonext#RailroadFacility"></see></summary>
    let RailroadFacility = _prefix "RailroadFacility"
    /// <summary>
    /// A tunnel for trains. NIMA GNS designator RTNL.
    /// <see href="http://www.ontotext.com/proton/protonext#RailroadTunnel"></see></summary>
    let RailroadTunnel = _prefix "RailroadTunnel"
    /// <summary>
    /// (ADL FT) Underground or underwater passages. [USGS Circ 1048] We use this category for canal tunnels; for railroad tunnels; and for road tunnels. NIMA GNS designator TNL, TNLC, TNLN, TNLRD, TNLS
    /// <see href="http://www.ontotext.com/proton/protonext#Tunnel"></see></summary>
    let Tunnel = _prefix "Tunnel"
    /// <summary>
    /// A gentle slope connecting areas of different elevations
    /// <see href="http://www.ontotext.com/proton/protonext#Ramp"></see></summary>
    let Ramp = _prefix "Ramp"
    /// <summary>
    /// A turbulent section of a stream associated with a steep, irregular stream bed. NIMA GNS designator H.RPDS.
    /// <see href="http://www.ontotext.com/proton/protonext#Rapids"></see></summary>
    let Rapids = _prefix "Rapids"
    /// <summary>
    /// (ADL FT) Chains of rocks or coral at or near the surface of water. [USGS Circ 1048] We use this category for barrier reefs; and for fringing reefs. Collapsed ADL sub-class: Coral Reefs. NIMA GNS designator RF, RFSU, RFU, RFC, H.RFX.
    /// <see href="http://www.ontotext.com/proton/protonext#Reef"></see></summary>
    let Reef = _prefix "Reef"
    /// <summary>
    /// A referee is the person of authority, in a variety of sports, who is responsible for presiding over the game from a neutral point of view. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Referee"></see></summary>
    let Referee = _prefix "Referee"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#RegionMention"></see>
    /// </summary>
    let RegionMention = _prefix "RegionMention"
    /// <summary>
    /// Things like Monastery, Church
    /// <see href="http://www.ontotext.com/proton/protonext#ReligiousLocation"></see></summary>
    let ReligiousLocation = _prefix "ReligiousLocation"
    /// <summary>
    /// Organization which offers ideas and opinions about life. Just joking.
    /// <see href="http://www.ontotext.com/proton/protonext#ReligiousOrganization"></see></summary>
    let ReligiousOrganization = _prefix "ReligiousOrganization"
    /// <summary>
    /// A document describing the result of some event.
    /// <see href="http://www.ontotext.com/proton/protonext#Report"></see></summary>
    let Report = _prefix "Report"
    /// <summary>
    /// Reptiles are animals in the class Reptilia. They are characterized by breathing air, laying shelled eggs, and having skin covered in scales and/or scutes. Reptiles are classically viewed as having a "cold-blooded" metabolism. They are tetrapods. Modern reptiles inhabit every continent with the exception of Antarctica. Example of an reptile is the crocodile. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Reptile"></see></summary>
    let Reptile = _prefix "Reptile"
    /// <summary>
    /// Specific research area, topic or field.
    /// <see href="http://www.ontotext.com/proton/protonext#ResearchArea"></see></summary>
    let ResearchArea = _prefix "ResearchArea"
    /// <summary>
    /// (ADL FT) Areas set aside for the preservation of fauna, flora, and their natural habitats. [Macmillan Encyc., 2001] We use this category for agricultural reserves; for conservation areas; for demonstration areas; for environmental areas; for forest reserves; for game management areas; for hunting reserves; for management areas (reserves); for natural areas; for nature reserves; for palm tree reserves; for preserves; for primitive areas; for protected areas; for reservations (nature sites); for road less areas; for sanctuaries (wildlife); for wildlife areas; for wildlife refuges; and for wildlife reserves. NIMA GNS designators RES, RESA, RESF, RESH, RESN, RESP, RESV, RESW.
    /// <see href="http://www.ontotext.com/proton/protonext#Reserve"></see></summary>
    let Reserve = _prefix "Reserve"
    /// <summary>
    /// (ADL FT) Artificially impounded bodies of water. We use this category for covered reservoirs; and for intermittent reservoirs. (incl. dams) NIMA GNS designator RSV, RSVI.
    /// <see href="http://www.ontotext.com/proton/protonext#Reservoir"></see></summary>
    let Reservoir = _prefix "Reservoir"
    /// <summary>
    /// Any restaurant, a place where food, drink and dessert to customers is prepared and served in return for money. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Restaurant"></see></summary>
    let Restaurant = _prefix "Restaurant"
    /// <summary>
    /// (ADL FT) Elevations with a narrow, elongated crest which can be part of a hill or mountain. ... We use this category for aretes; for beach ridges; for cuestas; for eskers; for hogbacks; for icecap ridges; for rises (seafloor); and for spurs (physiographic). Omitted ADL sub-classes: Drumlin. NIMA GNS designators RDGB, RDGE, RDGG, RDGU, RISU, SPRU, SPUR.
    /// <see href="http://www.ontotext.com/proton/protonext#Ridge"></see></summary>
    let Ridge = _prefix "Ridge"
    /// <summary>
    /// (ADL FT) Natural freshwater surface streams of considerable volume and a permanent or seasonal flow, moving in a definite channel toward a sea, lake, or another river; any large streams, or ones larger than brooks or creeks, such as the trunk stream and larger branches of a drainage system. We use this category for rios. NIM GNS designators ... no direct equivalents!
    /// <see href="http://www.ontotext.com/proton/protonext#River"></see></summary>
    let River = _prefix "River"
    /// <summary>
    /// (ADL FT) Linear bodies of water flowing on the Earth's surface. We use this category for anabranches; for brooks; for burns (hydrographic); for confluences; for creeks; for distributaries; for dry stream beds; for forks (physiographic features); for intermittent streams; for lost rivers; for meanders; for stream bends; for stream mouths; for tidal creeks; for tributaries; and for watercourses. NIMA GNS designators STM, STMA, STMB, STMC, STMD, STMH, STMI, STMIX, STMM, STMQ, STMS, STMSB, STMX
    /// <see href="http://www.ontotext.com/proton/protonext#Stream"></see></summary>
    let Stream = _prefix "Stream"
    /// <summary>
    /// A new channel cut by a river across the neck of an oxbow. NIMA GNS designator H.CUTF.
    /// <see href="http://www.ontotext.com/proton/protonext#RiverCutoff"></see></summary>
    let RiverCutoff = _prefix "RiverCutoff"
    /// <summary>
    /// (ADL FT) Open ways for passage of vehicles. [USGS Circ 1048] We use this category for caravan routes; for causeways; for drives; for highways; for intersections; for parkways; for road bends; for road cuts; for road junctions; for roads; for streets; and for traffic circles. NIMA GNS designators CSWY, CSWYQ, RD, RDA, RDB, RDCUT, RDJCT, RDST, RTE, STKR.
    /// <see href="http://www.ontotext.com/proton/protonext#Roadway"></see></summary>
    let Roadway = _prefix "Roadway"
    /// <summary>
    /// A rugby team
    /// A sport club that organizes the playing of rugby.
    /// <see href="http://www.ontotext.com/proton/protonext#RugbyClub"></see></summary>
    let RugbyClub = _prefix "RugbyClub"
    /// <summary>
    /// A sports club, football club or F1 team. Those should be considered commercial although in many cases they are not run for profit.
    /// An organization arranging the practice of some sports by teams or individuals.
    /// <see href="http://www.ontotext.com/proton/protonext#SportClub"></see></summary>
    let SportClub = _prefix "SportClub"
    /// <summary>
    /// Any Rugby League
    /// <see href="http://www.ontotext.com/proton/protonext#RugbyLeague"></see></summary>
    let RugbyLeague = _prefix "RugbyLeague"
    /// <summary>
    /// The profession of rugby player
    /// <see href="http://www.ontotext.com/proton/protonext#RugbyPlayer"></see></summary>
    let RugbyPlayer = _prefix "RugbyPlayer"
    /// <summary>
    /// A low part, resembling in shape a saddle, in a ridge or between contiguous seamounts
    /// <see href="http://www.ontotext.com/proton/protonext#Saddleback"></see></summary>
    let Saddleback = _prefix "Saddleback"
    /// <summary>
    /// Any saint, a holy person, in whom Christ dwells, whether in heaven or in earth.
    /// <see href="http://www.ontotext.com/proton/protonext#Saint"></see></summary>
    let Saint = _prefix "Saint"
    /// <summary>
    /// Any event in which a participant is receiving a good from another participant of the event on the basis of some payment.
    /// <see href="http://www.ontotext.com/proton/protonext#Sale"></see></summary>
    let Sale = _prefix "Sale"
    /// <summary>
    /// An education organization teaching pupils from first grade to tenth/eleventh/twelfth grade. It could be a primary school, or a secondary school.
    /// <see href="http://www.ontotext.com/proton/protonext#School"></see></summary>
    let School = _prefix "School"
    /// <summary>
    /// A well established, big research area
    /// <see href="http://www.ontotext.com/proton/protonext#Science"></see></summary>
    let Science = _prefix "Science"
    /// <summary>
    /// Any scientist, a profession of studying and making research on a particualr subject.
    /// <see href="http://www.ontotext.com/proton/protonext#Scientist"></see></summary>
    let Scientist = _prefix "Scientist"
    /// <summary>
    /// An area of low trees, bushes, and shrubs stunted by some environmental limitation
    /// <see href="http://www.ontotext.com/proton/protonext#Scrubland"></see></summary>
    let Scrubland = _prefix "Scrubland"
    /// <summary>
    /// Any sculpture, three-dimensional artwork created by shaping or combining hard materials. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Sculpture"></see></summary>
    let Sculpture = _prefix "Sculpture"
    /// <summary>
    /// A long arm of the sea forming a channel between the mainland and an island or islands; or connecting two larger bodies of water. NIMA GNS designator H.SD.
    /// <see href="http://www.ontotext.com/proton/protonext#SeaSound"></see></summary>
    let SeaSound = _prefix "SeaSound"
    /// <summary>
    /// An elongate (tongue-like) extension of a flat sea floor into an adjacent higher feature
    /// <see href="http://www.ontotext.com/proton/protonext#SeaTongue"></see></summary>
    let SeaTongue = _prefix "SeaTongue"
    /// <summary>
    /// A long, narrow, characteristically very deep and asymmetrical depression of the sea floor, with relatively steep sides
    /// <see href="http://www.ontotext.com/proton/protonext#SeaTrench"></see></summary>
    let SeaTrench = _prefix "SeaTrench"
    /// <summary>
    /// A long depression of the sea floor characteristically flat bottomed and steep sided, and normally shallower than a trench
    /// <see href="http://www.ontotext.com/proton/protonext#SeaTrough"></see></summary>
    let SeaTrough = _prefix "SeaTrough"
    /// <summary>
    /// Continuously sloping, elongated depressions commonly found in fans or plains and customarily bordered by levees on one or two sides (U.SCSU; U.SCSU)
    /// <see href="http://www.ontotext.com/proton/protonext#Seachannels"></see></summary>
    let Seachannels = _prefix "Seachannels"
    /// <summary>
    /// An elevation rising generally more than 1,000 meters and of limited extent across the summit. (U.SMSU; U.SMU)
    /// <see href="http://www.ontotext.com/proton/protonext#Seamount"></see></summary>
    let Seamount = _prefix "Seamount"
    /// <summary>
    /// One of the seasons of the year. In the places with a temperate climate there are four seasons: spring, summer, autumn, and winter.
    /// <see href="http://www.ontotext.com/proton/protonext#Season"></see></summary>
    let Season = _prefix "Season"
    /// <summary>
    /// An area of a document that can be considered a document in itself. Compare with pext:Mention, which is also an area of a document. Imported from the iSIM ontology.
    /// <see href="http://www.ontotext.com/proton/protonext#Section"></see></summary>
    let Section = _prefix "Section"
    /// <summary>
    /// Any Senator, a title of the member of the senat.
    /// <see href="http://www.ontotext.com/proton/protonext#Senator"></see></summary>
    let Senator = _prefix "Senator"
    /// <summary>
    /// A vehicle which moves on water.
    /// <see href="http://www.ontotext.com/proton/protonext#Ship"></see></summary>
    let Ship = _prefix "Ship"
    /// <summary>
    /// Hazards to surface navigation composed of unconsolidated material. (U.SHSU; U.SHLU)
    /// <see href="http://www.ontotext.com/proton/protonext#Shoal"></see></summary>
    let Shoal = _prefix "Shoal"
    /// <summary>
    /// Any Shopping Mall, a building which is a shopping mall
    /// <see href="http://www.ontotext.com/proton/protonext#ShoppingMall"></see></summary>
    let ShoppingMall = _prefix "ShoppingMall"
    /// <summary>
    /// A representative for a musician album.
    /// Any Single Album
    /// <see href="http://www.ontotext.com/proton/protonext#SingleAlbum"></see></summary>
    let SingleAlbum = _prefix "SingleAlbum"
    /// <summary>
    /// Any Single Song and Album
    /// <see href="http://www.ontotext.com/proton/protonext#SingleSongOrAlbum"></see></summary>
    let SingleSongOrAlbum = _prefix "SingleSongOrAlbum"
    /// <summary>
    /// A representative for an album or a musician song.
    /// <see href="http://www.ontotext.com/proton/protonext#SingleSong"></see></summary>
    let SingleSong = _prefix "SingleSong"
    /// <summary>
    /// An recording of a song.
    /// <see href="http://www.ontotext.com/proton/protonext#Song"></see></summary>
    let Song = _prefix "Song"
    /// <summary>
    /// Any sites of special scientific interest, a place with scientific value, where some scientific activities or experiments are carried out, or which is observed for scientific reasons.
    /// <see href="http://www.ontotext.com/proton/protonext#SiteOfSpecialScientificInterest"></see></summary>
    let SiteOfSpecialScientificInterest = _prefix "SiteOfSpecialScientificInterest"
    /// <summary>
    /// Any Ski Area, a mounatain area (usually) where there re ski resorts or one can ski.
    /// <see href="http://www.ontotext.com/proton/protonext#SkiArea"></see></summary>
    let SkiArea = _prefix "SkiArea"
    /// <summary>
    /// Any Skyscraper, a highrise building, usually in downtown city areas.
    /// <see href="http://www.ontotext.com/proton/protonext#Skyscraper"></see></summary>
    let Skyscraper = _prefix "Skyscraper"
    /// <summary>
    /// A profession of a sportsman that plays snooker, which is a billiard derivate. From DBPedia
    /// <see href="http://www.ontotext.com/proton/protonext#SnookerPlayer"></see></summary>
    let SnookerPlayer = _prefix "SnookerPlayer"
    /// <summary>
    /// A soccer (football) team
    /// A sport club that organizes the playing of soccer.
    /// <see href="http://www.ontotext.com/proton/protonext#SoccerClub"></see></summary>
    let SoccerClub = _prefix "SoccerClub"
    /// <summary>
    /// Any Soccer league
    /// <see href="http://www.ontotext.com/proton/protonext#SoccerLeague"></see></summary>
    let SoccerLeague = _prefix "SoccerLeague"
    /// <summary>
    /// Any soccer manager, the title of a manager of a soccer team.
    /// <see href="http://www.ontotext.com/proton/protonext#SoccerManager"></see></summary>
    let SoccerManager = _prefix "SoccerManager"
    /// <summary>
    /// The profession of soccer player
    /// <see href="http://www.ontotext.com/proton/protonext#SoccerPlayer"></see></summary>
    let SoccerPlayer = _prefix "SoccerPlayer"
    /// <summary>
    /// Any Softball league
    /// <see href="http://www.ontotext.com/proton/protonext#SoftballLeague"></see></summary>
    let SoftballLeague = _prefix "SoftballLeague"
    /// <summary>
    /// Software is a collection of computer programs and related data that provide the instructions telling a computer what to do. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Software"></see></summary>
    let Software = _prefix "Software"
    /// <summary>
    /// An artificial agent which operates in a software environment.
    /// <see href="http://www.ontotext.com/proton/protonext#SoftwareAgent"></see></summary>
    let SoftwareAgent = _prefix "SoftwareAgent"
    /// <summary>
    /// Any Mission in space in which space shuttles or space crafts are involved.
    /// <see href="http://www.ontotext.com/proton/protonext#SpaceMission"></see></summary>
    let SpaceMission = _prefix "SpaceMission"
    /// <summary>
    /// A Spaceshuttle is a reusable launch system and orbital spacecraft operated by the U.S. National Aeronautics and Space Administration (NASA) (Wikipedia).
    /// <see href="http://www.ontotext.com/proton/protonext#SpaceShuttle"></see></summary>
    let SpaceShuttle = _prefix "SpaceShuttle"
    /// <summary>
    /// [WN1.7] Space vehicle - a craft capable of traveling in outer space; technically a satellite around the sun.
    /// <see href="http://www.ontotext.com/proton/protonext#Spacecraft"></see></summary>
    let Spacecraft = _prefix "Spacecraft"
    /// <summary>
    /// Any Spacestation. A space station (also called an orbital station) is a manned satellite designed to remain in space. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#SpaceStation"></see></summary>
    let SpaceStation = _prefix "SpaceStation"
    /// <summary>
    /// Any Speedway league
    /// <see href="http://www.ontotext.com/proton/protonext#SpeedwayLeague"></see></summary>
    let SpeedwayLeague = _prefix "SpeedwayLeague"
    /// <summary>
    /// Any speedway team
    /// <see href="http://www.ontotext.com/proton/protonext#SpeedwayTeam"></see></summary>
    let SpeedwayTeam = _prefix "SpeedwayTeam"
    /// <summary>
    /// A specific type of sport game
    /// <see href="http://www.ontotext.com/proton/protonext#Sport"></see></summary>
    let Sport = _prefix "Sport"
    /// <summary>
    /// A building providing facilities for practice of sport(s).
    /// <see href="http://www.ontotext.com/proton/protonext#SportBuilding"></see></summary>
    let SportBuilding = _prefix "SportBuilding"
    /// <summary>
    /// An organization (local, national or international) which main activity is related to one or more sports. Those could be clubs, as well, as all the sorts of federations.
    /// <see href="http://www.ontotext.com/proton/protonext#SportOrganization"></see></summary>
    let SportOrganization = _prefix "SportOrganization"
    /// <summary>
    /// Denotes a point scored in a given sport game.
    /// <see href="http://www.ontotext.com/proton/protonext#SportGamePoint"></see></summary>
    let SportGamePoint = _prefix "SportGamePoint"
    /// <summary>
    /// An organization representing which controls the practice of some sport on national, regional or international level.
    /// <see href="http://www.ontotext.com/proton/protonext#SportsFederation"></see></summary>
    let SportsFederation = _prefix "SportsFederation"
    /// <summary>
    /// A special sort of sport building, usually for open-air sports such as soccer.
    /// <see href="http://www.ontotext.com/proton/protonext#Stadium"></see></summary>
    let Stadium = _prefix "Stadium"
    /// <summary>
    /// An astronomic object of hot gases that radiates energy derived from thermonuclear reactions in the interior. Definition partly derived from WordNet 1.7
    /// <see href="http://www.ontotext.com/proton/protonext#Star"></see></summary>
    let Star = _prefix "Star"
    /// <summary>
    /// Any station, a place where busses, trains, sheeps, boats, etc. stop, like railway station, bussstop, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Station"></see></summary>
    let Station = _prefix "Station"
    /// <summary>
    /// Stock Exchange where public companies are traded, e. g. Nasdaq, NYSE, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#StockExchange"></see></summary>
    let StockExchange = _prefix "StockExchange"
    /// <summary>
    /// A stock exchange/market index is a method of measuring a section of the stock market. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#StockExchangeIndex"></see></summary>
    let StockExchangeIndex = _prefix "StockExchangeIndex"
    /// <summary>
    /// The general notion for a roadway within a city or village, often, surrounded by buildings. We put here boulevards, streets, avenues, etc. NIMA GNS designator - missing.
    /// <see href="http://www.ontotext.com/proton/protonext#Street"></see></summary>
    let Street = _prefix "Street"
    /// <summary>
    /// Part of a postal address denoting the street name.
    /// <see href="http://www.ontotext.com/proton/protonext#StreetName"></see></summary>
    let StreetName = _prefix "StreetName"
    /// <summary>
    /// Part of a postal address denoting the street number.
    /// <see href="http://www.ontotext.com/proton/protonext#StreetNumber"></see></summary>
    let StreetNumber = _prefix "StreetNumber"
    /// <summary>
    /// The profession of swimmer
    /// <see href="http://www.ontotext.com/proton/protonext#Swimmer"></see></summary>
    let Swimmer = _prefix "Swimmer"
    /// <summary>
    /// A brand of a television channel.
    /// <see href="http://www.ontotext.com/proton/protonext#TVChannel"></see></summary>
    let TVChannel = _prefix "TVChannel"
    /// <summary>
    /// A company that broadcasts audio and video content.
    /// <see href="http://www.ontotext.com/proton/protonext#TVCompany"></see></summary>
    let TVCompany = _prefix "TVCompany"
    /// <summary>
    /// A telecommunications company
    /// <see href="http://www.ontotext.com/proton/protonext#Telecom"></see></summary>
    let Telecom = _prefix "Telecom"
    /// <summary>
    /// Denotes any episod of any television series.
    /// <see href="http://www.ontotext.com/proton/protonext#TelevisionEpisode"></see></summary>
    let TelevisionEpisode = _prefix "TelevisionEpisode"
    /// <summary>
    /// Denotes programms produced in the television and for television airing.
    /// <see href="http://www.ontotext.com/proton/protonext#TelevisionProduct"></see></summary>
    let TelevisionProduct = _prefix "TelevisionProduct"
    /// <summary>
    /// Any television show
    /// <see href="http://www.ontotext.com/proton/protonext#TelevisionShow"></see></summary>
    let TelevisionShow = _prefix "TelevisionShow"
    /// <summary>
    /// Any Tennis league
    /// <see href="http://www.ontotext.com/proton/protonext#TennisLeague"></see></summary>
    let TennisLeague = _prefix "TennisLeague"
    /// <summary>
    /// The profession of tennis player
    /// <see href="http://www.ontotext.com/proton/protonext#TennisPlayer"></see></summary>
    let TennisPlayer = _prefix "TennisPlayer"
    /// <summary>
    /// Territory a region of land which can be a part of contry that is non-sovereign or a geographic region determined by some charateristics. (Wikipedia) (http://www.eionet.europa.eu/gemet/concept?ns=1&amp;cp=8401. NIMA GNS designator A.TERR.
    /// <see href="http://www.ontotext.com/proton/protonext#Territory"></see></summary>
    let Territory = _prefix "Territory"
    /// <summary>
    /// An art performance following a stage play.
    /// <see href="http://www.ontotext.com/proton/protonext#TheatrePerformance"></see></summary>
    let TheatrePerformance = _prefix "TheatrePerformance"
    /// <summary>
    /// A time zone is a region on Earth that has a uniform standard time for legal, commercial, and social purposes. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#TimeZone"></see></summary>
    let TimeZone = _prefix "TimeZone"
    /// <summary>
    /// A Tournament which is held regularly at particular time intervals, every year, every week, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Tournament"></see></summary>
    let Tournament = _prefix "Tournament"
    /// <summary>
    /// A Tournament held at a particular time
    /// <see href="http://www.ontotext.com/proton/protonext#TournamentOccurrence"></see></summary>
    let TournamentOccurrence = _prefix "TournamentOccurrence"
    /// <summary>
    /// (ADL FT) Manmade structures, higher than their diameter, generally used for observation, storage, or electronic transmission. We use this category for carillons; for fire lookouts; and for pagodas. NIMA GNS designator TOWR.
    /// <see href="http://www.ontotext.com/proton/protonext#Tower"></see></summary>
    let Tower = _prefix "Tower"
    /// <summary>
    /// Any town
    /// <see href="http://www.ontotext.com/proton/protonext#Town"></see></summary>
    let Town = _prefix "Town"
    /// <summary>
    /// Any Trade Union, an organization of workers that have banded together to achieve common goals such as better working conditions. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#TradeUnion"></see></summary>
    let TradeUnion = _prefix "TradeUnion"
    /// <summary>
    /// (ADL FT) Treeless, level, or gently rolling plains characteristic of arctic or subarctic regions, having a permanently frozen subsoil, and usually supporting low growing vegetation such as lichens, mosses, and stunted shrubs. [USGS Circ 1048] We use this category for Arctic land. NIMA GNS designator TUND, LAND.
    /// <see href="http://www.ontotext.com/proton/protonext#Tundra"></see></summary>
    let Tundra = _prefix "Tundra"
    /// <summary>
    /// An educational organization higher than school.
    /// <see href="http://www.ontotext.com/proton/protonext#University"></see></summary>
    let University = _prefix "University"
    /// <summary>
    /// (ADL FT: Countries, 3rd order divisions) Minor civil units. [USGS Circ 1048] We use this category for barrios; for precincts; for third-order administrative divisions; and for townships. NIMA GNS designator ADM3.
    /// <see href="http://www.ontotext.com/proton/protonext#UrbanDistrict"></see></summary>
    let UrbanDistrict = _prefix "UrbanDistrict"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#User"></see>
    /// </summary>
    let User = _prefix "User"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#UserProfile"></see>
    /// </summary>
    let UserProfile = _prefix "UserProfile"
    /// <summary>
    /// Vein is a general concept gathering all veins of a body.
    /// <see href="http://www.ontotext.com/proton/protonext#Vein"></see></summary>
    let Vein = _prefix "Vein"
    /// <summary>
    /// Any Vice President, the title of a vice president in a country or in an organization.
    /// <see href="http://www.ontotext.com/proton/protonext#VicePresident"></see></summary>
    let VicePresident = _prefix "VicePresident"
    /// <summary>
    /// Any Vice Prime Minister, the title of a vice prime minister in a country.
    /// <see href="http://www.ontotext.com/proton/protonext#VicePrimeMinister"></see></summary>
    let VicePrimeMinister = _prefix "VicePrimeMinister"
    /// <summary>
    /// Any electronic game that involves interaction with a user interface to generate visual feedback on a video device. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#VideoGame"></see></summary>
    let VideoGame = _prefix "VideoGame"
    /// <summary>
    /// Any Videogames league
    /// <see href="http://www.ontotext.com/proton/protonext#VideogamesLeague"></see></summary>
    let VideogamesLeague = _prefix "VideogamesLeague"
    /// <summary>
    /// Any village
    /// <see href="http://www.ontotext.com/proton/protonext#Village"></see></summary>
    let Village = _prefix "Village"
    /// <summary>
    /// Plantings of grapevines
    /// <see href="http://www.ontotext.com/proton/protonext#Vineyard"></see></summary>
    let Vineyard = _prefix "Vineyard"
    /// <summary>
    /// (ADL FT) Vents in the surface of the Earth through which magma and associated gases erupt; also, the forms or structures, usually conical, that are produced by the erupted material. NIMA GNS designator VLC.
    /// <see href="http://www.ontotext.com/proton/protonext#Volcano"></see></summary>
    let Volcano = _prefix "Volcano"
    /// <summary>
    /// Any Volleyball league
    /// <see href="http://www.ontotext.com/proton/protonext#VolleyballLeague"></see></summary>
    let VolleyballLeague = _prefix "VolleyballLeague"
    /// <summary>
    /// A profession of a volleyball player.
    /// <see href="http://www.ontotext.com/proton/protonext#VolleyballPlayer"></see></summary>
    let VolleyballPlayer = _prefix "VolleyballPlayer"
    /// <summary>
    /// A valley or ravine, bounded by relatively steep banks. NIMA GNS designator H.WAD, H.WADB, H.WADJ, H.WADM, H.WADS, H.WADX.
    /// <see href="http://www.ontotext.com/proton/protonext#Wadi"></see></summary>
    let Wadi = _prefix "Wadi"
    /// <summary>
    /// (ADL FT: Banks) Sloping margins of, or the ground bordering, a stream, and serving to confine the water to the natural channel during the normal course of flow. [Glossary of Geology, 4th ed.] We use this category for stream banks. NIMA GNS designator BKSU, BNK, BNKR, BNKU, BNKX.
    /// <see href="http://www.ontotext.com/proton/protonext#WaterBank"></see></summary>
    let WaterBank = _prefix "WaterBank"
    /// <summary>
    /// A net transport of ocean water along a definable path. http://www.eionet.europa.eu/gemet/concept/5792 NIMA GNS designator H.CRNT.
    /// <see href="http://www.ontotext.com/proton/protonext#WaterCurrent"></see></summary>
    let WaterCurrent = _prefix "WaterCurrent"
    /// <summary>
    /// A straight section of a navigable stream or channel between two bends. NIMA GNS designator H.RCH.
    /// <see href="http://www.ontotext.com/proton/protonext#WaterReach"></see></summary>
    let WaterReach = _prefix "WaterReach"
    /// <summary>
    /// A contained pool or tank of water at, below, or above ground level. NIMA GNS designator H.RSVT.
    /// <see href="http://www.ontotext.com/proton/protonext#WaterTank"></see></summary>
    let WaterTank = _prefix "WaterTank"
    /// <summary>
    /// A natural, well-defined channel produced by flowing water, or an artificial channel designed to carry flowing water. NIMA GNS designator H.WTRC.
    /// <see href="http://www.ontotext.com/proton/protonext#Watercourse"></see></summary>
    let Watercourse = _prefix "Watercourse"
    /// <summary>
    /// (ADL FT) Perpendicular or very steep falls of water in the course of a stream. ... We use this category for cascades; for cataracts; and for falls. NIMA GNS designator FLLS, FLLSX
    /// <see href="http://www.ontotext.com/proton/protonext#Waterfalls"></see></summary>
    let Waterfalls = _prefix "Waterfalls"
    /// <summary>
    /// A natural hole, hollow, or small depression that contains water, used by man and animals, especially in arid areas. NIMA GNS designator H.WTRH.
    /// <see href="http://www.ontotext.com/proton/protonext#Waterhole"></see></summary>
    let Waterhole = _prefix "Waterhole"
    /// <summary>
    /// A concrete model of a weapon that determines its main features. For example, Patriot, SU-28, and Kalashnikov.
    /// <see href="http://www.ontotext.com/proton/protonext#WeaponModelOrSystem"></see></summary>
    let WeaponModelOrSystem = _prefix "WeaponModelOrSystem"
    /// <summary>
    /// A specific week of a specific year (say the 41st of 2001)
    /// <see href="http://www.ontotext.com/proton/protonext#Week"></see></summary>
    let Week = _prefix "Week"
    /// <summary>
    /// A cylindrical hole, pit, or tunnel drilled or dug down to a depth from which water, oil, or gas can be pumped or brought to the surface. NIMA GNS designator H.WLL, H.WLLQ, H.WLLS.
    /// <see href="http://www.ontotext.com/proton/protonext#Well"></see></summary>
    let Well = _prefix "Well"
    /// <summary>
    /// A turbulent, rotating movement of water in a stream. NIMA GNS designator H.WHRL.
    /// <see href="http://www.ontotext.com/proton/protonext#Whirlpool"></see></summary>
    let Whirlpool = _prefix "Whirlpool"
    /// <summary>
    /// Any Wine Region, a region where wine is produced.
    /// <see href="http://www.ontotext.com/proton/protonext#WineRegion"></see></summary>
    let WineRegion = _prefix "WineRegion"
    /// <summary>
    /// A female human.
    /// <see href="http://www.ontotext.com/proton/protonext#Woman"></see></summary>
    let Woman = _prefix "Woman"
    /// <summary>
    /// Any world heritage site, a old site with historic value of world magnitude to be preserved.
    /// <see href="http://www.ontotext.com/proton/protonext#WorldHeritageSite"></see></summary>
    let WorldHeritageSite = _prefix "WorldHeritageSite"
    /// <summary>
    /// The profession of wrestler
    /// <see href="http://www.ontotext.com/proton/protonext#Wrestler"></see></summary>
    let Wrestler = _prefix "Wrestler"
    /// <summary>
    /// Any writer, a profession of producing literary content. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Writer"></see></summary>
    let Writer = _prefix "Writer"
    /// <summary>
    /// Part of a postal address denoting the zip code.
    /// <see href="http://www.ontotext.com/proton/protonext#ZipCode"></see></summary>
    let ZipCode = _prefix "ZipCode"
    /// <summary>
    /// A land region defined to play a role. For example, a buffer between two nations in which military presence is minimal or absent or zone around the site of the Chernobyl disaster to protect people from radiation. (NIMA GNS designator A.ZN, A.ZNB.
    /// <see href="http://www.ontotext.com/proton/protonext#Zone"></see></summary>
    let Zone = _prefix "Zone"
    /// <summary>
    /// A relation between an account and an agent (usually organization) providing and managing it
    /// <see href="http://www.ontotext.com/proton/protonext#accountProvider"></see></summary>
    let accountProvider = _prefix "accountProvider"
    /// <summary>
    /// The participant of an acquirement event which became a property of another participant in this event.
    /// <see href="http://www.ontotext.com/proton/protonext#acquired"></see></summary>
    let acquired = _prefix "acquired"
    /// <summary>
    /// The participant of an acquirement event which became an owner of another participant in this event.
    /// <see href="http://www.ontotext.com/proton/protonext#acquirer"></see></summary>
    let acquirer = _prefix "acquirer"
    /// <summary>
    /// Denotes that the organization is active within the industry sector
    /// <see href="http://www.ontotext.com/proton/protonext#activeInSector"></see></summary>
    let activeInSector = _prefix "activeInSector"
    /// <summary>
    /// The general part-of relation that takes place between a whole and each of its parts. It has number of specializations.
    /// <see href="http://www.ontotext.com/proton/protonext#subSectorOf"></see></summary>
    let subSectorOf = _prefix "subSectorOf"
    /// <summary>
    /// A concrete job position appointed by a given person.
    /// <see href="http://www.ontotext.com/proton/protonext#appointedBy"></see></summary>
    let appointedBy = _prefix "appointedBy"
    /// <summary>
    /// A concrete job position which is assigned to the position available in a given organization.
    /// <see href="http://www.ontotext.com/proton/protonext#appointmentFor"></see></summary>
    let appointmentFor = _prefix "appointmentFor"
    /// <summary>
    /// The relation between a facility and its architect.
    /// <see href="http://www.ontotext.com/proton/protonext#architect"></see></summary>
    let architect = _prefix "architect"
    /// <summary>
    /// A relation between a person and his/her profession.
    /// <see href="http://www.ontotext.com/proton/protonext#hasProfession"></see></summary>
    let hasProfession = _prefix "hasProfession"
    /// <summary>
    /// Any author of a product. Links any object to its author (producer).
    /// <see href="http://www.ontotext.com/proton/protonext#authorOf"></see></summary>
    let authorOf = _prefix "authorOf"
    /// <summary>
    /// Any author of a product. Links an author (producer) to its creation .
    /// <see href="http://www.ontotext.com/proton/protonext#isAuthorOf"></see></summary>
    let isAuthorOf = _prefix "isAuthorOf"
    /// <summary>
    /// The relation between a person and the date he/she is born.
    /// <see href="http://www.ontotext.com/proton/protonext#birthDate"></see></summary>
    let birthDate = _prefix "birthDate"
    /// <summary>
    /// The relation between a person and the place he/she is born.
    /// <see href="http://www.ontotext.com/proton/protonext#birthPlace"></see></summary>
    let birthPlace = _prefix "birthPlace"
    /// <summary>
    /// The relation between a car model and the country it is assembled in.
    /// <see href="http://www.ontotext.com/proton/protonext#carAssemblyIn"></see></summary>
    let carAssemblyIn = _prefix "carAssemblyIn"
    /// <summary>
    /// Any cause of death.
    /// <see href="http://www.ontotext.com/proton/protonext#causeOfDeath"></see></summary>
    let causeOfDeath = _prefix "causeOfDeath"
    /// <summary>
    /// the relation between a military unit and the organization it represents in a military conflict.
    /// <see href="http://www.ontotext.com/proton/protonext#combatantFrom"></see></summary>
    let combatantFrom = _prefix "combatantFrom"
    /// <summary>
    /// It links a dataset with a schema it complies to.
    /// <see href="http://www.ontotext.com/proton/protonext#compliantWithSchema"></see></summary>
    let compliantWithSchema = _prefix "compliantWithSchema"
    /// <summary>
    /// The relation between a military organization, which participates as a combatant in a military conflict
    /// <see href="http://www.ontotext.com/proton/protonext#conflictCombatant"></see></summary>
    let conflictCombatant = _prefix "conflictCombatant"
    /// <summary>
    /// Relation between two locations where the first contains the other.
    /// The relation between a location and another location that is contained by the first one.
    /// <see href="http://www.ontotext.com/proton/protonext#containsLocation"></see></summary>
    let containsLocation = _prefix "containsLocation"
    /// <summary>
    /// The relation between a recurring event and its frequency.
    /// <see href="http://www.ontotext.com/proton/protonext#currentFrequency"></see></summary>
    let currentFrequency = _prefix "currentFrequency"
    /// <summary>
    /// Typically, associated with the creation or availability of the resource. Recommended best practice for encoding the date value is defined in a profile of ISO 8601 [W3CDTF] and includes (among others) dates of the form YYYY-MM-DD. This date is related to an event of publishing which here is implicit. If necessary for the task it can be made explicit in an extension of the ontology.
    /// <see href="http://www.ontotext.com/proton/protonext#datePublished"></see></summary>
    let datePublished = _prefix "datePublished"
    /// <summary>
    /// The relation between a person and the date he/she died.
    /// <see href="http://www.ontotext.com/proton/protonext#deathDate"></see></summary>
    let deathDate = _prefix "deathDate"
    /// <summary>
    /// The relation between a person and the place he/she died.
    /// <see href="http://www.ontotext.com/proton/protonext#deathPlace"></see></summary>
    let deathPlace = _prefix "deathPlace"
    /// <summary>
    /// Any author of engineering and architecture designs. The relation between an author and the facility he has designed.
    /// <see href="http://www.ontotext.com/proton/protonext#designerOfFacility"></see></summary>
    let designerOfFacility = _prefix "designerOfFacility"
    /// <summary>
    /// the relation between an official position, usually political and the location it represents. The district represented by an official position, usually political.
    /// <see href="http://www.ontotext.com/proton/protonext#districtRepresented"></see></summary>
    let districtRepresented = _prefix "districtRepresented"
    /// <summary>
    /// The date of the last occurrence of a recurring event.
    /// <see href="http://www.ontotext.com/proton/protonext#finalOccuranceDate"></see></summary>
    let finalOccuranceDate = _prefix "finalOccuranceDate"
    /// <summary>
    /// The date of the first occurrence of a recurring event.
    /// <see href="http://www.ontotext.com/proton/protonext#firstOccuranceDate"></see></summary>
    let firstOccuranceDate = _prefix "firstOccuranceDate"
    /// <summary>
    /// Net Income last year.
    /// <see href="http://www.ontotext.com/proton/protonext#fiscalNetIncome"></see></summary>
    let fiscalNetIncome = _prefix "fiscalNetIncome"
    /// <summary>
    /// Sales last year.
    /// <see href="http://www.ontotext.com/proton/protonext#fiscalSales"></see></summary>
    let fiscalSales = _prefix "fiscalSales"
    /// <summary>
    /// The relation between an agent and the genre he is occupied in.
    /// <see href="http://www.ontotext.com/proton/protonext#genreOfAgent"></see></summary>
    let genreOfAgent = _prefix "genreOfAgent"
    /// <summary>
    /// Relates address to an agent. Will be used for URL, email and other addresses.
    /// <see href="http://www.ontotext.com/proton/protonext#hasAddress"></see></summary>
    let hasAddress = _prefix "hasAddress"
    /// <summary>
    /// A relation between a city and an airport near to the city.
    /// <see href="http://www.ontotext.com/proton/protonext#hasAirport"></see></summary>
    let hasAirport = _prefix "hasAirport"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasBottomOffset"></see>
    /// </summary>
    let hasBottomOffset = _prefix "hasBottomOffset"
    /// <summary>
    /// Relates a person and his/her brother.
    /// <see href="http://www.ontotext.com/proton/protonext#hasBrother"></see></summary>
    let hasBrother = _prefix "hasBrother"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasCapabilities"></see>
    /// </summary>
    let hasCapabilities = _prefix "hasCapabilities"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasCapital"></see>
    /// </summary>
    let hasCapital = _prefix "hasCapital"
    /// <summary>
    /// The relation between the status of celebrity and its celebrity title of notoriety in the society.
    /// <see href="http://www.ontotext.com/proton/protonext#hasCelebrityTitle"></see></summary>
    let hasCelebrityTitle = _prefix "hasCelebrityTitle"
    /// <summary>
    /// Generic property relating a Social Position to its name defined as an instance of a sub-class of pext:SocialFunction
    /// <see href="http://www.ontotext.com/proton/protonext#hasSocialFunctionTitle"></see></summary>
    let hasSocialFunctionTitle = _prefix "hasSocialFunctionTitle"
    /// <summary>
    /// The relation between a Cleric and its cleric title, like Bishop, Pole, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#hasClericTitle"></see></summary>
    let hasClericTitle = _prefix "hasClericTitle"
    /// <summary>
    /// Denotes that the Sector has the specified SIC code
    /// <see href="http://www.ontotext.com/proton/protonext#hasCode"></see></summary>
    let hasCode = _prefix "hasCode"
    /// <summary>
    /// The relation between a military unit and the person who commands it.
    /// <see href="http://www.ontotext.com/proton/protonext#hasCommander"></see></summary>
    let hasCommander = _prefix "hasCommander"
    /// <summary>
    /// A relation between a country and the currency used within the country
    /// <see href="http://www.ontotext.com/proton/protonext#hasCurrency"></see></summary>
    let hasCurrency = _prefix "hasCurrency"
    /// <summary>
    /// Relates a person and his/her daughter.
    /// <see href="http://www.ontotext.com/proton/protonext#hasDaughter"></see></summary>
    let hasDaughter = _prefix "hasDaughter"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasDevice"></see>
    /// </summary>
    let hasDevice = _prefix "hasDevice"
    /// <summary>
    /// Relates an object (usually a person) to its email.
    /// <see href="http://www.ontotext.com/proton/protonext#hasEMail"></see></summary>
    let hasEMail = _prefix "hasEMail"
    /// <summary>
    /// Relates an object to its internet address.
    /// <see href="http://www.ontotext.com/proton/protonext#hasInternetAddress"></see></summary>
    let hasInternetAddress = _prefix "hasInternetAddress"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasEndOffset"></see>
    /// </summary>
    let hasEndOffset = _prefix "hasEndOffset"
    /// <summary>
    /// Relates a person and his/her father.
    /// <see href="http://www.ontotext.com/proton/protonext#hasFather"></see></summary>
    let hasFather = _prefix "hasFather"
    /// <summary>
    /// Relates an object (usually an organization) to its fax number.
    /// <see href="http://www.ontotext.com/proton/protonext#hasFax"></see></summary>
    let hasFax = _prefix "hasFax"
    /// <summary>
    /// A relation between a country and its government
    /// <see href="http://www.ontotext.com/proton/protonext#hasGovernment"></see></summary>
    let hasGovernment = _prefix "hasGovernment"
    /// <summary>
    /// Relates a woman to her spouse.
    /// <see href="http://www.ontotext.com/proton/protonext#hasHusband"></see></summary>
    let hasHusband = _prefix "hasHusband"
    /// <summary>
    /// a relation between an Information Space and its Profile
    /// <see href="http://www.ontotext.com/proton/protonext#hasISProfile"></see></summary>
    let hasISProfile = _prefix "hasISProfile"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasLeftOffset"></see>
    /// </summary>
    let hasLeftOffset = _prefix "hasLeftOffset"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasStartOffset"></see>
    /// </summary>
    let hasStartOffset = _prefix "hasStartOffset"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasLocation"></see>
    /// </summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    /// The relation between a minister and his/her ministry.
    /// <see href="http://www.ontotext.com/proton/protonext#hasMinister"></see></summary>
    let hasMinister = _prefix "hasMinister"
    /// <summary>
    /// Relates an object (usually a person) to its mobile phone number.
    /// <see href="http://www.ontotext.com/proton/protonext#hasMobilePhone"></see></summary>
    let hasMobilePhone = _prefix "hasMobilePhone"
    /// <summary>
    /// Relates an object (usually a person or an organization) to its telephone number.
    /// <see href="http://www.ontotext.com/proton/protonext#hasPhone"></see></summary>
    let hasPhone = _prefix "hasPhone"
    /// <summary>
    /// Relates a person to his/her mother.
    /// <see href="http://www.ontotext.com/proton/protonext#hasMother"></see></summary>
    let hasMother = _prefix "hasMother"
    /// <summary>
    /// The relation between the social position and the social title of nobelty.
    /// <see href="http://www.ontotext.com/proton/protonext#hasNobeltyTitle"></see></summary>
    let hasNobeltyTitle = _prefix "hasNobeltyTitle"
    /// <summary>
    /// The relation between the status of a criminal, and title, for instance a prisoner.
    /// <see href="http://www.ontotext.com/proton/protonext#hasOutOfLawsTitle"></see></summary>
    let hasOutOfLawsTitle = _prefix "hasOutOfLawsTitle"
    /// <summary>
    /// The relation between a given sport game event and a point scored in it.
    /// <see href="http://www.ontotext.com/proton/protonext#hasPoint"></see></summary>
    let hasPoint = _prefix "hasPoint"
    /// <summary>
    /// The relation between a government and its head.
    /// <see href="http://www.ontotext.com/proton/protonext#hasPrimeMinister"></see></summary>
    let hasPrimeMinister = _prefix "hasPrimeMinister"
    /// <summary>
    /// An entity responsible for making the resource available. Examples of Publisher include a person, an organization, or a service. (DC2003ISO)
    /// <see href="http://www.ontotext.com/proton/protonext#hasPublisher"></see></summary>
    let hasPublisher = _prefix "hasPublisher"
    /// <summary>
    /// The relation between a particular event as an element of a recurring event.
    /// <see href="http://www.ontotext.com/proton/protonext#hasRecurringEventInstance"></see></summary>
    let hasRecurringEventInstance = _prefix "hasRecurringEventInstance"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasRightOffset"></see>
    /// </summary>
    let hasRightOffset = _prefix "hasRightOffset"
    /// <summary>
    /// Relates a happening with some of the roles in it
    /// <see href="http://www.ontotext.com/proton/protonext#hasRole"></see></summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    /// Natural relation between documents and sections. Imported from the iSIM ontology.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSection"></see></summary>
    let hasSection = _prefix "hasSection"
    /// <summary>
    /// A relation between a commercial organization and a person that owns shares of the organization.
    /// <see href="http://www.ontotext.com/proton/protonext#hasShareholder"></see></summary>
    let hasShareholder = _prefix "hasShareholder"
    /// <summary>
    /// Relates a person to his/her sister.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSister"></see></summary>
    let hasSister = _prefix "hasSister"
    /// <summary>
    /// The relation between a person and the social position of Celebrity he has.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSocialPositionCelebrity"></see></summary>
    let hasSocialPositionCelebrity = _prefix "hasSocialPositionCelebrity"
    /// <summary>
    /// The relation between a social position of Celebrity and the person who has it.
    /// <see href="http://www.ontotext.com/proton/protonext#socialPositionCelebrity"></see></summary>
    let socialPositionCelebrity = _prefix "socialPositionCelebrity"
    /// <summary>
    /// The relation between a person and the social position of Cleric he has.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSocialPositionCleric"></see></summary>
    let hasSocialPositionCleric = _prefix "hasSocialPositionCleric"
    /// <summary>
    /// The relation between a social position of Cleric and the person who has it.
    /// <see href="http://www.ontotext.com/proton/protonext#socialPositionCleric"></see></summary>
    let socialPositionCleric = _prefix "socialPositionCleric"
    /// <summary>
    /// The relation between a person and the social position of Nobelty he has.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSocialPositionNobelty"></see></summary>
    let hasSocialPositionNobelty = _prefix "hasSocialPositionNobelty"
    /// <summary>
    /// The relation between a social position of Nobelty and the person who has it.
    /// <see href="http://www.ontotext.com/proton/protonext#socialPositionNobelty"></see></summary>
    let socialPositionNobelty = _prefix "socialPositionNobelty"
    /// <summary>
    /// The relation between a person and the social position of OutOfLaws he has.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSocialPositionOutOfLaws"></see></summary>
    let hasSocialPositionOutOfLaws = _prefix "hasSocialPositionOutOfLaws"
    /// <summary>
    /// The relation between a social position of OutOfLaws and the person who has it.
    /// <see href="http://www.ontotext.com/proton/protonext#socialPositionOutOfLaws"></see></summary>
    let socialPositionOutOfLaws = _prefix "socialPositionOutOfLaws"
    /// <summary>
    /// Relates a person to his/her son.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSon"></see></summary>
    let hasSon = _prefix "hasSon"
    /// <summary>
    /// Relates an object (usually a person) to its stationary phone number.
    /// <see href="http://www.ontotext.com/proton/protonext#hasStationaryPhone"></see></summary>
    let hasStationaryPhone = _prefix "hasStationaryPhone"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasString"></see>
    /// </summary>
    let hasString = _prefix "hasString"
    /// <summary>
    /// Relates a job position to its title.
    /// <see href="http://www.ontotext.com/proton/protonext#hasTitle"></see></summary>
    let hasTitle = _prefix "hasTitle"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasTopOffset"></see>
    /// </summary>
    let hasTopOffset = _prefix "hasTopOffset"
    /// <summary>
    /// Relates a currency to its unit. Examples: dollar, euro, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#hasUnit"></see></summary>
    let hasUnit = _prefix "hasUnit"
    /// <summary>
    /// a relation between an User and its Profile
    /// <see href="http://www.ontotext.com/proton/protonext#hasUserProfile"></see></summary>
    let hasUserProfile = _prefix "hasUserProfile"
    /// <summary>
    /// Relates an object (usually a person or an organization) to its web page.
    /// <see href="http://www.ontotext.com/proton/protonext#hasWebPage"></see></summary>
    let hasWebPage = _prefix "hasWebPage"
    /// <summary>
    /// Relates a man to his spouse.
    /// <see href="http://www.ontotext.com/proton/protonext#hasWife"></see></summary>
    let hasWife = _prefix "hasWife"
    /// <summary>
    /// The relation between an organization and the industry sector it is active in.
    /// <see href="http://www.ontotext.com/proton/protonext#industryOf"></see></summary>
    let industryOf = _prefix "industryOf"
    /// <summary>
    /// A place where a person is born. The relation between a location and a person who is born in this location.
    /// <see href="http://www.ontotext.com/proton/protonext#isBirthPlaceOf"></see></summary>
    let isBirthPlaceOf = _prefix "isBirthPlaceOf"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#isCurrentlyInterestedIn"></see>
    /// </summary>
    let isCurrentlyInterestedIn = _prefix "isCurrentlyInterestedIn"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#isInterestedIn"></see>
    /// </summary>
    let isInterestedIn = _prefix "isInterestedIn"
    /// <summary>
    /// The relation between an RDF document containing the descriptions of locations that share a common border
    /// <see href="http://www.ontotext.com/proton/protonext#isWrittenAbout"></see></summary>
    let isWrittenAbout = _prefix "isWrittenAbout"
    /// <summary>
    /// A relation of a specific issue, number, and/or volume and a periodical publication.
    /// <see href="http://www.ontotext.com/proton/protonext#issueOf"></see></summary>
    let issueOf = _prefix "issueOf"
    /// <summary>
    /// The relation between a geographic region and a map depicting its location
    /// <see href="http://www.ontotext.com/proton/protonext#locationMap"></see></summary>
    let locationMap = _prefix "locationMap"
    /// <summary>
    /// The name of a georgaphic region.
    /// <see href="http://www.ontotext.com/proton/protonext#locationName"></see></summary>
    let locationName = _prefix "locationName"
    /// <summary>
    /// The relation between a musician and the instrument he plays
    /// <see href="http://www.ontotext.com/proton/protonext#musicInstrument"></see></summary>
    let musicInstrument = _prefix "musicInstrument"
    /// <summary>
    /// The nationality of a person. The relation between a person and his nationality.
    /// <see href="http://www.ontotext.com/proton/protonext#nationalityOf"></see></summary>
    let nationalityOf = _prefix "nationalityOf"
    /// <summary>
    /// The relation of a location nearby another location
    /// <see href="http://www.ontotext.com/proton/protonext#nearby"></see></summary>
    let nearby = _prefix "nearby"
    /// <summary>
    /// The relation of a location sharing a common location with another location
    /// <see href="http://www.ontotext.com/proton/protonext#neighbour"></see></summary>
    let neighbour = _prefix "neighbour"
    /// <summary>
    /// The relation between a government organization and its country.
    /// <see href="http://www.ontotext.com/proton/protonext#ofCountry"></see></summary>
    let ofCountry = _prefix "ofCountry"
    /// <summary>
    /// This property models the Person-&gt;hasPosition-&gt;Location.
    /// <see href="http://www.ontotext.com/proton/protonext#officialPositionIn"></see></summary>
    let officialPositionIn = _prefix "officialPositionIn"
    /// <summary>
    /// The relation between an organization and a concrete job position in it.
    /// <see href="http://www.ontotext.com/proton/protonext#organizationPosition"></see></summary>
    let organizationPosition = _prefix "organizationPosition"
    /// <summary>
    /// The relationship between an object and an agent who owns it.
    /// <see href="http://www.ontotext.com/proton/protonext#ownerOf"></see></summary>
    let ownerOf = _prefix "ownerOf"
    /// <summary>
    /// The relationship between an object being a property/possessions of somebody.
    /// <see href="http://www.ontotext.com/proton/protonext#ownershipOf"></see></summary>
    let ownershipOf = _prefix "ownershipOf"
    /// <summary>
    /// Relation between the part of postal address and a given postal address.
    /// <see href="http://www.ontotext.com/proton/protonext#partOfPostalAddress"></see></summary>
    let partOfPostalAddress = _prefix "partOfPostalAddress"
    /// <summary>
    /// The relation between the scored point in a sport game and the sport club who won it.
    /// <see href="http://www.ontotext.com/proton/protonext#pointAwardedTo"></see></summary>
    let pointAwardedTo = _prefix "pointAwardedTo"
    /// <summary>
    /// The relation between a position and the contact information for it. This contact information can be the postal address of the office for the position or an virtual address in the Internet.
    /// <see href="http://www.ontotext.com/proton/protonext#positionContactInformation"></see></summary>
    let positionContactInformation = _prefix "positionContactInformation"
    /// <summary>
    /// The relation between the job position and the organization it is available in. The organization where the job position is available.
    /// <see href="http://www.ontotext.com/proton/protonext#positionWithinOrganization"></see></summary>
    let positionWithinOrganization = _prefix "positionWithinOrganization"
    /// <summary>
    /// The relation between a producer and the product produced. The producer is restricted to an organization, like Microsoft, Ford, GM, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#productOf"></see></summary>
    let productOf = _prefix "productOf"
    /// <summary>
    /// A relation between an article and the colelction within which the article is published.
    /// <see href="http://www.ontotext.com/proton/protonext#publishedWithin"></see></summary>
    let publishedWithin = _prefix "publishedWithin"
    /// <summary>
    /// Name of the company on the Stock Exchange, where it is traded. At present, if a company is traded on two SEs with different indices, there is no way to encode which of them is applicable where.
    /// <see href="http://www.ontotext.com/proton/protonext#stockExchangeIndex"></see></summary>
    let stockExchangeIndex = _prefix "stockExchangeIndex"
    /// <summary>
    /// Relates the Public Company to the Stock Exchange where it is traded
    /// <see href="http://www.ontotext.com/proton/protonext#tradedOn"></see></summary>
    let tradedOn = _prefix "tradedOn"
    /// <summary>
    /// Describes the transmission type of a given car model
    /// <see href="http://www.ontotext.com/proton/protonext#transmission"></see></summary>
    let transmission = _prefix "transmission"
