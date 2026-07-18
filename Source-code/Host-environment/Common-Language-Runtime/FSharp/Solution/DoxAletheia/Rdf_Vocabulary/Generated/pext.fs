namespace http.www.ontotext.com.proton.protonext.hash

open DoxAletheia.Rdf_Vocabulary

module pext =
    let _namespace_name = "http://www.ontotext.com/proton/protonext#"
    /// <summary>
    /// An unattended electronic machine in a public place, connected to a data system and related equipment and activated by a bank customer to obtain cash withdrawals and other banking services.
    /// <see href="http://www.ontotext.com/proton/protonext#ATM"></see></summary>
    let ATM = Namespaced_IRI.parse _namespace_name "ATM" |> NamespacedName

    /// <summary>
    /// (ADL FT: Telecommunication Features) We use this category for antenna field sites; for communication centers; for radio stations; for television stations; and for transmission lines. NIMA GNS designators COMC, STNR, STNS.
    /// <see href="http://www.ontotext.com/proton/protonext#TelecomFacility"></see></summary>
    let TelecomFacility =
        Namespaced_IRI.parse _namespace_name "TelecomFacility" |> NamespacedName

    /// <summary>
    /// A journal publishing scientific articles
    /// <see href="http://www.ontotext.com/proton/protonext#AcademicJournal"></see></summary>
    let AcademicJournal =
        Namespaced_IRI.parse _namespace_name "AcademicJournal" |> NamespacedName

    /// <summary>
    /// A periodic paperback publication; "it takes several years before a magazine starts to break even or make money"), WordNet 1.7.1. This includes also journals and digests. The specific issues typically contain a number of different articles.
    /// <see href="http://www.ontotext.com/proton/protonext#Magazine"></see></summary>
    let Magazine = Namespaced_IRI.parse _namespace_name "Magazine" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#Accident"></see>
    /// </summary>
    let Accident = Namespaced_IRI.parse _namespace_name "Accident" |> NamespacedName
    /// <summary>
    /// An explicit agreement between agents. Typically, service providers (e.g. banks or ISPs) provide accounts to their customers or users, which are considered account owners. The existence of the account depends on the provider, even though the user owns it in some metaphoric sense. Examples could be bank, ISP, e-Commerce, ICQ, email accounts. The accounts are usually aligned with a sort of contract.
    /// <see href="http://www.ontotext.com/proton/protonext#Account"></see></summary>
    let Account = Namespaced_IRI.parse _namespace_name "Account" |> NamespacedName

    /// <summary>
    /// The event of the acquiring of one organization by another.
    /// <see href="http://www.ontotext.com/proton/protonext#Acquirement"></see></summary>
    let Acquirement =
        Namespaced_IRI.parse _namespace_name "Acquirement" |> NamespacedName

    /// <summary>
    /// Each activity is a Happening which involves volition and participants. It has temporal dimension. It is distinguished from Events by the fact that the activity does not trigger change of state and does not have a conceptual end point.
    /// <see href="http://www.ontotext.com/proton/protonext#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName
    /// <summary>
    /// Any actor acts in a dramatic production and who works in film, television, theatre, or radio in that capacity. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Actor"></see></summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName

    /// <summary>
    /// A profession in the area of art.
    /// <see href="http://www.ontotext.com/proton/protonext#ArtProfession"></see></summary>
    let ArtProfession =
        Namespaced_IRI.parse _namespace_name "ArtProfession" |> NamespacedName

    /// <summary>
    /// Any sort of address, specifying how to locate something somewhere.
    /// <see href="http://www.ontotext.com/proton/protonext#Address"></see></summary>
    let Address = Namespaced_IRI.parse _namespace_name "Address" |> NamespacedName

    /// <summary>
    /// Any administrative region. NIMA GNS designators - PCLIX
    /// <see href="http://www.ontotext.com/proton/protonext#AdministrativeRegion"></see></summary>
    let AdministrativeRegion =
        Namespaced_IRI.parse _namespace_name "AdministrativeRegion" |> NamespacedName

    /// <summary>
    /// (ADL FT) Places or areas with clustered or scattered buildings and a permanent human population. ... We use this category for agricultural colonies; for communes; for communities; for hamlets; for homesteads; for locales; for localities; for metropolitan areas; for populated localities; for ppl; for pueblos; for settlements; for suburbs; for villages; and with religious facilities for religious populated places. NIMA GNS designator PPL, PPL(x)
    /// <see href="http://www.ontotext.com/proton/protonext#PopulatedPlace"></see></summary>
    let PopulatedPlace =
        Namespaced_IRI.parse _namespace_name "PopulatedPlace" |> NamespacedName

    /// <summary>
    /// A tract of land set aside for agricultural settlement. NIMA GNS designator L.AGRC.
    /// <see href="http://www.ontotext.com/proton/protonext#AgriculturalColony"></see></summary>
    let AgriculturalColony =
        Namespaced_IRI.parse _namespace_name "AgriculturalColony" |> NamespacedName

    /// <summary>
    /// Any sort of land regions which are sort of natural, i.e. excluding urban areas, political and administrative regions. It combines number of ADL feature types under Physiographic features and Regions. Omitted ADL sub-classes: Badlands, Bars, Basins, Bight, Cirques, Cliffs, Dunes, Flats, Karst areas. Ledges, Massifs, Mineral deposit areas, Moraines, Natural rock formations, Arches, Playas, Seafloor Features, Tectonic features, Volcanic features (Volcano put under Mountain), Subcontinents. NIMA GNS designators FSR, FURU, HMCK, PLDR, RKFL, SINK, SLID, SLP, SLPU, TERU, TRR.
    /// <see href="http://www.ontotext.com/proton/protonext#LandRegion"></see></summary>
    let LandRegion = Namespaced_IRI.parse _namespace_name "LandRegion" |> NamespacedName

    /// <summary>
    /// An agricultural facility; a building and/or tract of land used for improving agriculture
    /// <see href="http://www.ontotext.com/proton/protonext#AgriculturalFacility"></see></summary>
    let AgriculturalFacility =
        Namespaced_IRI.parse _namespace_name "AgriculturalFacility" |> NamespacedName

    /// <summary>
    /// (ADL FT: Manmade Features, no def) Any regions and locations determined artificially, as a result of human activity. Many of the ADL sub-classes are omitted. NIMA GNS - no direct equivalent, although many sub-types are defined as classes (S, R) and designators.
    /// <see href="http://www.ontotext.com/proton/protonext#Facility"></see></summary>
    let Facility = Namespaced_IRI.parse _namespace_name "Facility" |> NamespacedName
    /// <summary>
    /// An area used to store supplies, provide barracks for air force personnel, hangars and runways for aircraft, and from which operations are initiated
    /// <see href="http://www.ontotext.com/proton/protonext#Airbase"></see></summary>
    let Airbase = Namespaced_IRI.parse _namespace_name "Airbase" |> NamespacedName

    /// <summary>
    /// (ADL FTT) We use this category for air force bases; for army facilities; for arsenals; for artillery ranges; for barracks; for bases (military); for camps (military); for forts; for infantry camps; for maneuver areas; for military bases; for military installations; for national guard facilities; and for naval bases. The following NIMA designators fit here: MILB, INSM, SCHM. The following ADL types are skipped as irrelevant: Cadastral areas,
    /// <see href="http://www.ontotext.com/proton/protonext#MilitaryAreas"></see></summary>
    let MilitaryAreas =
        Namespaced_IRI.parse _namespace_name "MilitaryAreas" |> NamespacedName

    /// <summary>
    /// A company providing air transport services.
    /// <see href="http://www.ontotext.com/proton/protonext#Airline"></see></summary>
    let Airline = Namespaced_IRI.parse _namespace_name "Airline" |> NamespacedName
    /// <summary>
    /// A private, legal, corporate entity with the legal rights to own property, manage itself, and sue or be sued. It is established by a charter or registration granted by the government.
    /// <see href="http://www.ontotext.com/proton/protonext#Company"></see></summary>
    let Company = Namespaced_IRI.parse _namespace_name "Company" |> NamespacedName

    /// <summary>
    /// Engines of airplanes
    /// <see href="http://www.ontotext.com/proton/protonext#AirplaneEngine"></see></summary>
    let AirplaneEngine =
        Namespaced_IRI.parse _namespace_name "AirplaneEngine" |> NamespacedName

    /// <summary>
    /// Any produced device with particular purpose that uses energy to perform some activity. The device has parts that perform or assist in performing any type of work. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Machine"></see></summary>
    let Machine = Namespaced_IRI.parse _namespace_name "Machine" |> NamespacedName

    /// <summary>
    /// A concrete model of an airplane which determines the main features of any airplane of this model. For example, Boeing 737, Airbus A330, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#AirplaneModel"></see></summary>
    let AirplaneModel =
        Namespaced_IRI.parse _namespace_name "AirplaneModel" |> NamespacedName

    /// <summary>
    /// An airport, including heliports. NIMA GNS designators AIRP, AIRH.
    /// <see href="http://www.ontotext.com/proton/protonext#Airport"></see></summary>
    let Airport = Namespaced_IRI.parse _namespace_name "Airport" |> NamespacedName

    /// <summary>
    /// (ADL FT: Transportation Features) We use this category for air routes; for caravan routes; for corridors; for crossings; for depots; for ferries; for fords (crossings); for fuel depots; for gates (manmade); for halting places (transportation); for highway maintenance sites; for portages; for rest houses; for routes; for ship tracks; for stock routes; for terminals (transportation); and for transit facilities. Omitted sub-classes: Aqueducts, Cableways, Parking Sites. NIMA GNS designator - no direct equivalents.
    /// <see href="http://www.ontotext.com/proton/protonext#TransportFacility"></see></summary>
    let TransportFacility =
        Namespaced_IRI.parse _namespace_name "TransportFacility" |> NamespacedName

    /// <summary>
    /// An recording of a several songs. Usually from the same singer.
    /// <see href="http://www.ontotext.com/proton/protonext#Album"></see></summary>
    let Album = Namespaced_IRI.parse _namespace_name "Album" |> NamespacedName

    /// <summary>
    /// An recording of a piece of music.
    /// <see href="http://www.ontotext.com/proton/protonext#AudioRecording"></see></summary>
    let AudioRecording =
        Namespaced_IRI.parse _namespace_name "AudioRecording" |> NamespacedName

    /// <summary>
    /// A type (specific receipe) for a beverage. For instance: Guiness Beer, Absolut Currant, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#AlcoholicBeverage"></see></summary>
    let AlcoholicBeverage =
        Namespaced_IRI.parse _namespace_name "AlcoholicBeverage" |> NamespacedName

    /// <summary>
    /// Any liquid suitable for drinking (WordNet, 1.7). The instances of this class are types of drinks, specific receipts. For instance: Diet Coke, Bacardi Spice.
    /// <see href="http://www.ontotext.com/proton/protonext#Beverage"></see></summary>
    let Beverage = Namespaced_IRI.parse _namespace_name "Beverage" |> NamespacedName
    /// <summary>
    /// Any ambassador, a title of a position of representing a country abroad
    /// <see href="http://www.ontotext.com/proton/protonext#Ambassador"></see></summary>
    let Ambassador = Namespaced_IRI.parse _namespace_name "Ambassador" |> NamespacedName
    /// <summary>
    /// The name of a position a person holds within an organization.
    /// <see href="http://www.ontotext.com/proton/protonext#JobTitle"></see></summary>
    let JobTitle = Namespaced_IRI.parse _namespace_name "JobTitle" |> NamespacedName

    /// <summary>
    /// Any American football league
    /// <see href="http://www.ontotext.com/proton/protonext#AmericanFootballLeague"></see></summary>
    let AmericanFootballLeague =
        Namespaced_IRI.parse _namespace_name "AmericanFootballLeague" |> NamespacedName

    /// <summary>
    /// Any sports league, a group of sports teams or individual athletes that compete against each other in a specific sport. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#SportsLeague"></see></summary>
    let SportsLeague =
        Namespaced_IRI.parse _namespace_name "SportsLeague" |> NamespacedName

    /// <summary>
    /// Any player of American football.
    /// <see href="http://www.ontotext.com/proton/protonext#AmericanFootballPlayer"></see></summary>
    let AmericanFootballPlayer =
        Namespaced_IRI.parse _namespace_name "AmericanFootballPlayer" |> NamespacedName

    /// <summary>
    /// A profession of a person involved in a sport.
    /// <see href="http://www.ontotext.com/proton/protonext#Sportsman"></see></summary>
    let Sportsman = Namespaced_IRI.parse _namespace_name "Sportsman" |> NamespacedName

    /// <summary>
    /// Any American Football Team
    /// <see href="http://www.ontotext.com/proton/protonext#AmericanFootballTeam"></see></summary>
    let AmericanFootballTeam =
        Namespaced_IRI.parse _namespace_name "AmericanFootballTeam" |> NamespacedName

    /// <summary>
    /// A group of people gathered for some task, say a project. Teams are usually not formally established and not meant to perform as a single agent for purposes outside the scope of their task. Teams may "live" within organizations, spread between multiple organizations, or be independent form any organization.
    /// <see href="http://www.ontotext.com/proton/protonext#Team"></see></summary>
    let Team = Namespaced_IRI.parse _namespace_name "Team" |> NamespacedName
    /// <summary>
    /// Amphibian denotes animals such as frogs, salamanders, and caecilians, that are ectothermic (or cold-blooded) animals and metamorphose from a juvenile water-breathing form, either to an adult air-breathing form, or to a paedomorph that retains some juvenile characteristics. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Amphibian"></see></summary>
    let Amphibian = Namespaced_IRI.parse _namespace_name "Amphibian" |> NamespacedName
    /// <summary>
    /// Animals are a major group of multicellular, eukaryotic organisms. Their body plan eventually becomes fixed as they develop. Most animals are motile. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Animal"></see></summary>
    let Animal = Namespaced_IRI.parse _namespace_name "Animal" |> NamespacedName

    /// <summary>
    /// (ADL FT) Commercially operated enterprises that offer rides, games, and other forms of entertainment. NIMA GNS designator - no equivalents.
    /// <see href="http://www.ontotext.com/proton/protonext#AmusementPark"></see></summary>
    let AmusementPark =
        Namespaced_IRI.parse _namespace_name "AmusementPark" |> NamespacedName

    /// <summary>
    /// (ADL FT) We use this category for access areas; for access sites; for boardwalks; for casinos; for clubs (recreational); for country clubs; for fairgrounds; for fishing areas; for fishing lodges; for fitness centers; for gun clubs; for hunt posts; for hunting lodges; for ice skating rinks; for playgrounds; for recreation sites; for resorts; for riding stables; for spas; for sportsman lodges; for stables; for yacht clubs; for youth centers; and for youth facilities. NIMA GNS designators - no direct equivalents.
    /// <see href="http://www.ontotext.com/proton/protonext#RecreationalFacility"></see></summary>
    let RecreationalFacility =
        Namespaced_IRI.parse _namespace_name "RecreationalFacility" |> NamespacedName

    /// <summary>
    /// Living object is any organism which is living, e.g. breathing and regular lifecycle.
    /// <see href="http://www.ontotext.com/proton/protonext#LivingObject"></see></summary>
    let LivingObject =
        Namespaced_IRI.parse _namespace_name "LivingObject" |> NamespacedName

    /// <summary>
    /// A formal public statement; "the government made an announcement about the changes in the drug war" ; "a declaration of independence".) WordNet 1.7.1
    /// <see href="http://www.ontotext.com/proton/protonext#Announcement"></see></summary>
    let Announcement =
        Namespaced_IRI.parse _namespace_name "Announcement" |> NamespacedName

    /// <summary>
    /// A document that is published or intended for publishing
    /// <see href="http://www.ontotext.com/proton/protonext#PublishedMaterial"></see></summary>
    let PublishedMaterial =
        Namespaced_IRI.parse _namespace_name "PublishedMaterial" |> NamespacedName

    /// <summary>
    /// Arachnid denotes a class of joint-legged invertebrate animals in the subphylum Chelicerata. All arachnids have eight legs, although in some species the front pair may convert to a sensory function. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Arachnid"></see></summary>
    let Arachnid = Namespaced_IRI.parse _namespace_name "Arachnid" |> NamespacedName
    /// <summary>
    /// A natural or man-made structure in the form of an arch
    /// <see href="http://www.ontotext.com/proton/protonext#Arch"></see></summary>
    let Arch = Namespaced_IRI.parse _namespace_name "Arch" |> NamespacedName
    /// <summary>
    /// Archaea (archeon) are a group of single-celled microorganisms without a cell nucleus or any other membrane-bound organelles (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Archaea"></see></summary>
    let Archaea = Namespaced_IRI.parse _namespace_name "Archaea" |> NamespacedName

    /// <summary>
    /// (ADL FT) Seas or areas in a sea that contain numerous islands; also, the island groups themselves. NIMA GNS designator - no equivalent.
    /// <see href="http://www.ontotext.com/proton/protonext#Archipelago"></see></summary>
    let Archipelago =
        Namespaced_IRI.parse _namespace_name "Archipelago" |> NamespacedName

    /// <summary>
    /// Any architect, a profession of planning, design and oversight of the construction of buildings. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Architect"></see></summary>
    let Architect = Namespaced_IRI.parse _namespace_name "Architect" |> NamespacedName
    /// <summary>
    /// A profession is a vocation founded upon specialized educational training. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#Profession"></see></summary>
    let Profession = Namespaced_IRI.parse _namespace_name "Profession" |> NamespacedName
    /// <summary>
    /// Any arena
    /// <see href="http://www.ontotext.com/proton/protonext#Arena"></see></summary>
    let Arena = Namespaced_IRI.parse _namespace_name "Arena" |> NamespacedName
    /// <summary>
    /// (ADL FT) Permanent constructions that are roofed and usually walled. [USGS Circ 1048] We use this category for administrative facilities; for administrative facilities; for animal pounds; for animal shelters; for aquariums; for barns; for border posts; for cabins; for castles; for city halls; for civic centers; for civil buildings; for club houses; for coast guard stations; for commissaries; for community centers; for community houses; for conference facilities; for consulates; for convention centers; for customs houses; for customs posts; for depots; for embassy buildings; for exhibition buildings; for facilities; for facility centers; for fire stations; for firehouses; for forest stations; for government buildings; for guard stations; for halls; for headquarters; for hostels; for hotels; for houses; for inns; for inspection stations; for legation buildings; for lodges; for missions; for motels; for neighborhood centers; for offices; for park headquarters; for patrol posts; for pavilions; for planetariums; for plazas; for police posts; for public buildings; for ranger stations; for restaurants; for shelters; for shops; for stations; for structures; for student unions; for studios; for substations; for taverns; for town halls; for trading posts; for treatment plants; for United States Government establishments; for visitor centers; for walls; and for warehouses NIMA GNS designator BLDG.
    /// <see href="http://www.ontotext.com/proton/protonext#Building"></see></summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName
    /// <summary>
    /// Art is the product or process of deliberately arranging items (often with symbolic significance) in a way that influences and affects one or more of the senses, emotions, and intellect. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#Art"></see></summary>
    let Art = Namespaced_IRI.parse _namespace_name "Art" |> NamespacedName

    /// <summary>
    /// Any sort of general social phenomenon, such as particular sort of art or science
    /// <see href="http://www.ontotext.com/proton/protonext#SocialAbstraction"></see></summary>
    let SocialAbstraction =
        Namespaced_IRI.parse _namespace_name "SocialAbstraction" |> NamespacedName

    /// <summary>
    /// A specific performance taking place at some moment, somewhere. Quite often starting at 19:00 in the theatre, stadium, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#ArtPerformance"></see></summary>
    let ArtPerformance =
        Namespaced_IRI.parse _namespace_name "ArtPerformance" |> NamespacedName

    /// <summary>
    /// Any artery as a part of the body.
    /// <see href="http://www.ontotext.com/proton/protonext#Artery"></see></summary>
    let Artery = Namespaced_IRI.parse _namespace_name "Artery" |> NamespacedName
    /// <summary>
    /// Any part of the body of any living entity
    /// <see href="http://www.ontotext.com/proton/protonext#BodyPart"></see></summary>
    let BodyPart = Namespaced_IRI.parse _namespace_name "BodyPart" |> NamespacedName
    /// <summary>
    /// A relatively short document published as a part of Resource Collection.
    /// <see href="http://www.ontotext.com/proton/protonext#Article"></see></summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName

    /// <summary>
    /// A satellite created by humans
    /// <see href="http://www.ontotext.com/proton/protonext#ArtificialSatellite"></see></summary>
    let ArtificialSatellite =
        Namespaced_IRI.parse _namespace_name "ArtificialSatellite" |> NamespacedName

    /// <summary>
    /// An astronomic object orbiting around a planet or star. Definition partly derived from WordNet 1.7
    /// <see href="http://www.ontotext.com/proton/protonext#Satellite"></see></summary>
    let Satellite = Namespaced_IRI.parse _namespace_name "Satellite" |> NamespacedName
    /// <summary>
    /// Any artist a profession engaging in a broad spectrum of activities related to creating art, practicing the arts and/or demonstrating an art. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Artist"></see></summary>
    let Artist = Namespaced_IRI.parse _namespace_name "Artist" |> NamespacedName
    /// <summary>
    /// Asteroids are a class of small Solar System bodies in orbit around the Sun. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#Asteroid"></see></summary>
    let Asteroid = Namespaced_IRI.parse _namespace_name "Asteroid" |> NamespacedName

    /// <summary>
    /// Any object studied by astronomers, (usually quite large natural and inanimate) object that is located in the physical universe and is not on the surface of the Earth. Definition partly derived from OpenCyc 0.7
    /// <see href="http://www.ontotext.com/proton/protonext#AstronomicalObject"></see></summary>
    let AstronomicalObject =
        Namespaced_IRI.parse _namespace_name "AstronomicalObject" |> NamespacedName

    /// <summary>
    /// Any astronaut, a profession allowing to command, pilot, or serve as a crew member of a spacecraft. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Astronaut"></see></summary>
    let Astronaut = Namespaced_IRI.parse _namespace_name "Astronaut" |> NamespacedName
    /// <summary>
    /// Any athlete, a profession involving sport activities.
    /// <see href="http://www.ontotext.com/proton/protonext#Athlete"></see></summary>
    let Athlete = Namespaced_IRI.parse _namespace_name "Athlete" |> NamespacedName
    /// <summary>
    /// Any atoll
    /// <see href="http://www.ontotext.com/proton/protonext#Atoll"></see></summary>
    let Atoll = Namespaced_IRI.parse _namespace_name "Atoll" |> NamespacedName
    /// <summary>
    /// (ADL FT) Tracts of land smaller than a continent, surrounded by the water of an ocean, sea, lake or stream. [Glossary of Geology, 4th ed.] We use this category for atolls; for cays; for island arcs; for isles; for islets; for keys (islands); for land-tied islands; and for mangrove islands. NIMA GNS designator ISL, ISLF, ISLM, ISLS, ISLT, ISLX
    /// <see href="http://www.ontotext.com/proton/protonext#Island"></see></summary>
    let Island = Namespaced_IRI.parse _namespace_name "Island" |> NamespacedName

    /// <summary>
    /// An original piece of music.
    /// <see href="http://www.ontotext.com/proton/protonext#MusicalComposition"></see></summary>
    let MusicalComposition =
        Namespaced_IRI.parse _namespace_name "MusicalComposition" |> NamespacedName

    /// <summary>
    /// Any Australian football league
    /// <see href="http://www.ontotext.com/proton/protonext#AustralianFootballLeague"></see></summary>
    let AustralianFootballLeague =
        Namespaced_IRI.parse _namespace_name "AustralianFootballLeague" |> NamespacedName

    /// <summary>
    /// The profession of an australian rules football player
    /// <see href="http://www.ontotext.com/proton/protonext#AustralianRulesFootballPlayer"></see></summary>
    let AustralianRulesFootballPlayer =
        Namespaced_IRI.parse _namespace_name "AustralianRulesFootballPlayer" |> NamespacedName

    /// <summary>
    /// Any Auto Racing league
    /// <see href="http://www.ontotext.com/proton/protonext#AutoRacingLeague"></see></summary>
    let AutoRacingLeague =
        Namespaced_IRI.parse _namespace_name "AutoRacingLeague" |> NamespacedName

    /// <summary>
    /// Engines of automobiles
    /// <see href="http://www.ontotext.com/proton/protonext#AutomobileEngine"></see></summary>
    let AutomobileEngine =
        Namespaced_IRI.parse _namespace_name "AutomobileEngine" |> NamespacedName

    /// <summary>
    /// Any award. An award is something given to a person or a group of people to recognize excellence in a certain field; a certificate of excellence, for example trophies, titles, medals, badges, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Award"></see></summary>
    let Award = Namespaced_IRI.parse _namespace_name "Award" |> NamespacedName
    /// <summary>
    /// Bacteria is a single-celled, prokaryote microorganisms, typically a few micrometres in length (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Bacteria"></see></summary>
    let Bacteria = Namespaced_IRI.parse _namespace_name "Bacteria" |> NamespacedName

    /// <summary>
    /// The profession of badminton player
    /// <see href="http://www.ontotext.com/proton/protonext#BadmintonPlayer"></see></summary>
    let BadmintonPlayer =
        Namespaced_IRI.parse _namespace_name "BadmintonPlayer" |> NamespacedName

    /// <summary>
    /// Any band, a group performing music or other activity together.
    /// <see href="http://www.ontotext.com/proton/protonext#Band"></see></summary>
    let Band = Namespaced_IRI.parse _namespace_name "Band" |> NamespacedName
    /// <summary>
    /// A business establishment in which money is kept for saving or commercial purposes or is invested, supplied for loans, or exchanged.
    /// A company providing financial services like credits, deposits, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Bank"></see></summary>
    let Bank = Namespaced_IRI.parse _namespace_name "Bank" |> NamespacedName
    /// <summary>
    /// A building for lodging military personnel
    /// <see href="http://www.ontotext.com/proton/protonext#Barracks"></see></summary>
    let Barracks = Namespaced_IRI.parse _namespace_name "Barracks" |> NamespacedName

    /// <summary>
    /// Any Baseball league
    /// <see href="http://www.ontotext.com/proton/protonext#BaseballLeague"></see></summary>
    let BaseballLeague =
        Namespaced_IRI.parse _namespace_name "BaseballLeague" |> NamespacedName

    /// <summary>
    /// The profession of baseball player
    /// <see href="http://www.ontotext.com/proton/protonext#BaseballPlayer"></see></summary>
    let BaseballPlayer =
        Namespaced_IRI.parse _namespace_name "BaseballPlayer" |> NamespacedName

    /// <summary>
    /// Any Baseball team
    /// <see href="http://www.ontotext.com/proton/protonext#BaseballTeam"></see></summary>
    let BaseballTeam =
        Namespaced_IRI.parse _namespace_name "BaseballTeam" |> NamespacedName

    /// <summary>
    /// Any Basketball league
    /// <see href="http://www.ontotext.com/proton/protonext#BasketballLeague"></see></summary>
    let BasketballLeague =
        Namespaced_IRI.parse _namespace_name "BasketballLeague" |> NamespacedName

    /// <summary>
    /// The profession of basketball player
    /// <see href="http://www.ontotext.com/proton/protonext#BasketballPlayer"></see></summary>
    let BasketballPlayer =
        Namespaced_IRI.parse _namespace_name "BasketballPlayer" |> NamespacedName

    /// <summary>
    /// Any basketball team
    /// <see href="http://www.ontotext.com/proton/protonext#BasketballTeam"></see></summary>
    let BasketballTeam =
        Namespaced_IRI.parse _namespace_name "BasketballTeam" |> NamespacedName

    /// <summary>
    /// A site of a land battle of historical importance. NIMA GNS designator L.BTL.
    /// <see href="http://www.ontotext.com/proton/protonext#Battlefield"></see></summary>
    let Battlefield =
        Namespaced_IRI.parse _namespace_name "Battlefield" |> NamespacedName

    /// <summary>
    /// Any Historic Place, an old place with historic value.
    /// <see href="http://www.ontotext.com/proton/protonext#HistoricPlace"></see></summary>
    let HistoricPlace =
        Namespaced_IRI.parse _namespace_name "HistoricPlace" |> NamespacedName

    /// <summary>
    /// (ADL FT) Indentations of a coastline or shoreline enclosing a part of a body of water; bodies of water partly surrounded by land. We use this category for bahias; for coves; and for embayments. NIMA GNS designators BAY, BAYS.
    /// <see href="http://www.ontotext.com/proton/protonext#Bay"></see></summary>
    let Bay = Namespaced_IRI.parse _namespace_name "Bay" |> NamespacedName

    /// <summary>
    /// (ADL FT: Hydrographic Features) For natural bodies of water. For constructed waterways, reservoirs, and such, use 'hydrographic structures'. We use this category for bodies of water; for eddies; for fluvial features; for marine features; for overfalls; for upwellings; for water bodies; for waterholes; and for whirlpools. Many of the ADL hydrographic features ignored. NIMA GNS class H.
    /// <see href="http://www.ontotext.com/proton/protonext#WaterRegion"></see></summary>
    let WaterRegion =
        Namespaced_IRI.parse _namespace_name "WaterRegion" |> NamespacedName

    /// <summary>
    /// (ADL FT) Sloping shores along a body of water that is washed by waves or tides and is usually covered by sand or gravel. ... We use this category for sandy areas; and for strands. NIMA GNS designator BCH, BCHS.
    /// <see href="http://www.ontotext.com/proton/protonext#Beach"></see></summary>
    let Beach = Namespaced_IRI.parse _namespace_name "Beach" |> NamespacedName
    /// <summary>
    /// A fixed artificial navigation mark
    /// <see href="http://www.ontotext.com/proton/protonext#Beacon"></see></summary>
    let Beacon = Namespaced_IRI.parse _namespace_name "Beacon" |> NamespacedName

    /// <summary>
    /// A specific chemical compound, such as H2O or Zarin.
    /// <see href="http://www.ontotext.com/proton/protonext#ChemicalCompound"></see></summary>
    let ChemicalCompound =
        Namespaced_IRI.parse _namespace_name "ChemicalCompound" |> NamespacedName

    /// <summary>
    /// An open body of water forming a slight recession in a coastline
    /// <see href="http://www.ontotext.com/proton/protonext#Bight"></see></summary>
    let Bight = Namespaced_IRI.parse _namespace_name "Bight" |> NamespacedName

    /// <summary>
    /// (ADL FT) Geographic regions characterized chiefly by the dominant forms of plant life and the prevailing climate. [Adapted from American Heritage Dict. of the English Language, 4th ed.] We use this category for biomes; for ecoregions; and for vegetation. Omitted ADL sub-classes: Barren lands, Grasslands, Habitats, Snow Regions, Wetlands. NIMA GNS designator - no equivalent. Some correspondence to class Hypsographic Features.
    /// <see href="http://www.ontotext.com/proton/protonext#BiogeographicRegion"></see></summary>
    let BiogeographicRegion =
        Namespaced_IRI.parse _namespace_name "BiogeographicRegion" |> NamespacedName

    /// <summary>
    /// A database containing information about biological entities.
    /// <see href="http://www.ontotext.com/proton/protonext#BiologicalDatabase"></see></summary>
    let BiologicalDatabase =
        Namespaced_IRI.parse _namespace_name "BiologicalDatabase" |> NamespacedName

    /// <summary>
    /// A dataset loaded in a system supporting search, update and other operations over the information in the dataset.
    /// <see href="http://www.ontotext.com/proton/protonext#Database"></see></summary>
    let Database = Namespaced_IRI.parse _namespace_name "Database" |> NamespacedName

    /// <summary>
    /// Any substance or element that has biological nature or origine.
    /// <see href="http://www.ontotext.com/proton/protonext#BiologicalSubstance"></see></summary>
    let BiologicalSubstance =
        Namespaced_IRI.parse _namespace_name "BiologicalSubstance" |> NamespacedName

    /// <summary>
    /// Bird denotes feathered, winged, bipedal, endothermic (warm-blooded), egg-laying, vertebrate animals. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Bird"></see></summary>
    let Bird = Namespaced_IRI.parse _namespace_name "Bird" |> NamespacedName
    /// <summary>
    /// Any bishop, an official in the Roman-Catholic church.
    /// <see href="http://www.ontotext.com/proton/protonext#Bishop"></see></summary>
    let Bishop = Namespaced_IRI.parse _namespace_name "Bishop" |> NamespacedName

    /// <summary>
    /// The social function of a cleric, involving the church.
    /// <see href="http://www.ontotext.com/proton/protonext#ClericTitle"></see></summary>
    let ClericTitle =
        Namespaced_IRI.parse _namespace_name "ClericTitle" |> NamespacedName

    /// <summary>
    /// A meeting whose main participants are members of a board.
    /// <see href="http://www.ontotext.com/proton/protonext#BoardMeeting"></see></summary>
    let BoardMeeting =
        Namespaced_IRI.parse _namespace_name "BoardMeeting" |> NamespacedName

    /// <summary>
    /// A meeting is a gathering of two or more people that has been convened for the purpose of achieving a common goal through verbal interaction, such as sharing information or reaching an agreement. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#Meeting"></see></summary>
    let Meeting = Namespaced_IRI.parse _namespace_name "Meeting" |> NamespacedName

    /// <summary>
    /// Any board member, a title of the member of the board of any board
    /// <see href="http://www.ontotext.com/proton/protonext#BoardMember"></see></summary>
    let BoardMember =
        Namespaced_IRI.parse _namespace_name "BoardMember" |> NamespacedName

    /// <summary>
    /// http://www.eionet.europa.eu/gemet/concept?ns=1&amp;cp=12161. NIMA GNS designator H.BOG.
    /// <see href="http://www.ontotext.com/proton/protonext#Bog"></see></summary>
    let Bog = Namespaced_IRI.parse _namespace_name "Bog" |> NamespacedName
    /// <summary>
    /// Any bone as a part of the body.
    /// <see href="http://www.ontotext.com/proton/protonext#Bone"></see></summary>
    let Bone = Namespaced_IRI.parse _namespace_name "Bone" |> NamespacedName
    /// <summary>
    /// A relatively large published document. It may or may not have chapters. There could be series of books considered as volumes of a single one.
    /// <see href="http://www.ontotext.com/proton/protonext#Book"></see></summary>
    let Book = Namespaced_IRI.parse _namespace_name "Book" |> NamespacedName
    /// <summary>
    /// The profession of boxer
    /// <see href="http://www.ontotext.com/proton/protonext#Boxer"></see></summary>
    let Boxer = Namespaced_IRI.parse _namespace_name "Boxer" |> NamespacedName

    /// <summary>
    /// Any Boxing league
    /// <see href="http://www.ontotext.com/proton/protonext#BoxingLeague"></see></summary>
    let BoxingLeague =
        Namespaced_IRI.parse _namespace_name "BoxingLeague" |> NamespacedName

    /// <summary>
    /// Any brain as a part of the body.
    /// <see href="http://www.ontotext.com/proton/protonext#Brain"></see></summary>
    let Brain = Namespaced_IRI.parse _namespace_name "Brain" |> NamespacedName
    /// <summary>
    /// The American Marketing Association defines a brand as a "Name, term, design, symbol, or any other feature that identifies one seller's good or service as distinct from those of other sellers." Wikipedia. Examples: Dodge and Milka
    /// <see href="http://www.ontotext.com/proton/protonext#Brand"></see></summary>
    let Brand = Namespaced_IRI.parse _namespace_name "Brand" |> NamespacedName
    /// <summary>
    /// A structure erected to break the force of waves at the entrance to a harbor or port
    /// <see href="http://www.ontotext.com/proton/protonext#Breakwater"></see></summary>
    let Breakwater = Namespaced_IRI.parse _namespace_name "Breakwater" |> NamespacedName
    /// <summary>
    /// (ADL FT) Structures erected over a depression or obstacle to carry traffic. [USGS Circ 1048] We use this category for covered bridges; for drawbridges; for overpasses; for trestles; and for viaducts. NIMA GNS designator BDG, BDGQ.
    /// <see href="http://www.ontotext.com/proton/protonext#Bridge"></see></summary>
    let Bridge = Namespaced_IRI.parse _namespace_name "Bridge" |> NamespacedName

    /// <summary>
    /// Any British Royalty, a title of a memebr of the British royal family.
    /// <see href="http://www.ontotext.com/proton/protonext#BritishRoyalty"></see></summary>
    let BritishRoyalty =
        Namespaced_IRI.parse _namespace_name "BritishRoyalty" |> NamespacedName

    /// <summary>
    /// The social function of a nobelty.
    /// <see href="http://www.ontotext.com/proton/protonext#NobeltyTitle"></see></summary>
    let NobeltyTitle =
        Namespaced_IRI.parse _namespace_name "NobeltyTitle" |> NamespacedName

    /// <summary>
    /// A broadcast network is an organization, such as a corporation or other voluntary association, that provides live television or recorded content, such as movies, newscasts, sports, Public affairs programming, and other television programs for broadcast over a group of radio stations or television stations. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#BroadcastNetwork"></see></summary>
    let BroadcastNetwork =
        Namespaced_IRI.parse _namespace_name "BroadcastNetwork" |> NamespacedName

    /// <summary>
    /// A company that broadcasts audio or video content to a dispersed audience via any audio visual medium. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#Broadcaster"></see></summary>
    let Broadcaster =
        Namespaced_IRI.parse _namespace_name "Broadcaster" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#MediaCompany"></see>
    /// </summary>
    let MediaCompany =
        Namespaced_IRI.parse _namespace_name "MediaCompany" |> NamespacedName

    /// <summary>
    /// Professional toreros (also called matadors) who execute various formal moves which can be interpreted and innovated according to the bullfighter's style or school. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#BullFighter"></see></summary>
    let BullFighter =
        Namespaced_IRI.parse _namespace_name "BullFighter" |> NamespacedName

    /// <summary>
    /// A small clump of conspicuous bushes in an otherwise bare area
    /// <see href="http://www.ontotext.com/proton/protonext#BushLand"></see></summary>
    let BushLand = Namespaced_IRI.parse _namespace_name "BushLand" |> NamespacedName

    /// <summary>
    /// An abstraction related to business.
    /// <see href="http://www.ontotext.com/proton/protonext#BusinessAbstraction"></see></summary>
    let BusinessAbstraction =
        Namespaced_IRI.parse _namespace_name "BusinessAbstraction" |> NamespacedName

    /// <summary>
    /// Any CEO, a title of a chief executive officer of an organization.
    /// <see href="http://www.ontotext.com/proton/protonext#CEO"></see></summary>
    let CEO = Namespaced_IRI.parse _namespace_name "CEO" |> NamespacedName

    /// <summary>
    /// A specific month of the year, such as: Jan., Feb., etc.
    /// <see href="http://www.ontotext.com/proton/protonext#CalendarMonth"></see></summary>
    let CalendarMonth =
        Namespaced_IRI.parse _namespace_name "CalendarMonth" |> NamespacedName

    /// <summary>
    /// Any sort of abstraction used to refer to specific periods of time. Thus, the month of September is an instance of this class, while Sept 1989 is not (it is a specific TimeInterval, and thus not abstract)
    /// <see href="http://www.ontotext.com/proton/protonext#TemporalAbstraction"></see></summary>
    let TemporalAbstraction =
        Namespaced_IRI.parse _namespace_name "TemporalAbstraction" |> NamespacedName

    /// <summary>
    /// A specific year, such as 2000, taken as a time interval
    /// <see href="http://www.ontotext.com/proton/protonext#CalendarYear"></see></summary>
    let CalendarYear =
        Namespaced_IRI.parse _namespace_name "CalendarYear" |> NamespacedName

    /// <summary>
    /// (ADL FT) Designated areas on which primitive structure(s) are erected for temporary shelter or where recreational vehicles are temporarily parked. [USGS Circ 1048] We use this category for campgrounds; for camping sites; for logging camps; for oil camps; for refugee camps; for RV parks; and for trailer parks (recreational). NIMA GNS designators CMP, CMPL, CMPLA, CMPO, CMPQ, CMPRF.
    /// <see href="http://www.ontotext.com/proton/protonext#Camp"></see></summary>
    let Camp = Namespaced_IRI.parse _namespace_name "Camp" |> NamespacedName

    /// <summary>
    /// Any Canadian Football league
    /// <see href="http://www.ontotext.com/proton/protonext#CanadianFootballLeague"></see></summary>
    let CanadianFootballLeague =
        Namespaced_IRI.parse _namespace_name "CanadianFootballLeague" |> NamespacedName

    /// <summary>
    /// Any player of Canadian football.
    /// <see href="http://www.ontotext.com/proton/protonext#CanadianFootballPlayer"></see></summary>
    let CanadianFootballPlayer =
        Namespaced_IRI.parse _namespace_name "CanadianFootballPlayer" |> NamespacedName

    /// <summary>
    /// Any Canadian Football Team
    /// <see href="http://www.ontotext.com/proton/protonext#CanadianFootballTeam"></see></summary>
    let CanadianFootballTeam =
        Namespaced_IRI.parse _namespace_name "CanadianFootballTeam" |> NamespacedName

    /// <summary>
    /// (ADL FT) Artificial waterways with no flow or a controlled flow used for navigation (canal), or for draining or irrigating land (ditch). We use this category for canal bends; for canalized streams; for ditch mouths; for ditches; for drainage canals; for drainage ditches; for drains (channels); for flumes (manmade); for irrigation canals; for irrigation ditches; for irrigation systems; for laterals; for navigation canals; and for underground irrigation canals. NIMA GNS designators CNL,CNLA, CNLB, CNLD, CNLI, CNLN, CNLQ, CNLSB, CNLX.
    /// <see href="http://www.ontotext.com/proton/protonext#Canal"></see></summary>
    let Canal = Namespaced_IRI.parse _namespace_name "Canal" |> NamespacedName

    /// <summary>
    /// (ADL FT) For constructed bodies of water. For natural water bodies, use 'hydrographic features'. We use this category for boat landings; for boat launches; for boat ramps; for sluices; and for water mills. Many sub-classes omitted; those considered are also made sub-classes of WaterRegion. NIMA GNS ... no direct equivalent.
    /// <see href="http://www.ontotext.com/proton/protonext#HydrographicStructure"></see></summary>
    let HydrographicStructure =
        Namespaced_IRI.parse _namespace_name "HydrographicStructure" |> NamespacedName

    /// <summary>
    /// (ADL FT) Relatively narrow, deep depressions with steep sides, the bottom of which generally has a continuous slope ... We use this category for barrancas; for chasms; for flumes (natural); for gorges; for gulches; for quebradas; and for ravines. NIMA GNS designator CNSU, CNYN, CNYU, GRGE, RAVU, RVN.
    /// <see href="http://www.ontotext.com/proton/protonext#Canyon"></see></summary>
    let Canyon = Namespaced_IRI.parse _namespace_name "Canyon" |> NamespacedName
    /// <summary>
    /// (ADL FT) Low-lying land bordered by higher ground; especially elongate, relatively large gently sloping depressions of the Earth's surface, commonly situated between two mountains or between ranges of hills or mountains, and often containing a stream with an outlet. [Glossary of Geology, 4th ed.] We use this category for forks (physiographic features); for glens; for hanging valleys; for hollows; for median valleys; and for shelf valleys (seafloor). NIMA GNS designators VAL, VALG, VALU, VALS, VALX, VLSU, FRKU, FRSU, MDVU, SHVU.
    /// <see href="http://www.ontotext.com/proton/protonext#Valley"></see></summary>
    let Valley = Namespaced_IRI.parse _namespace_name "Valley" |> NamespacedName
    /// <summary>
    /// (ADL FT) Projection of land extending into a body of water that prominently marks a change in or interrupts the coastal trend of that water body. We use this category for headlands; for peninsulas; for points (physiographic); and for promontories. NIMA GNS designator CAPE, HDLD, PROM.
    /// <see href="http://www.ontotext.com/proton/protonext#Cape"></see></summary>
    let Cape = Namespaced_IRI.parse _namespace_name "Cape" |> NamespacedName
    /// <summary>
    /// (ADL FT) Towns or cities that are the official seats of government in a political entity, such as a state or nation. [American Heritage Dic. of the English Language, 4th ed.] We use this category for county seats; for national capitals; and for state capitals. NIMA GNS designators PPLC, PPLA
    /// <see href="http://www.ontotext.com/proton/protonext#Capital"></see></summary>
    let Capital = Namespaced_IRI.parse _namespace_name "Capital" |> NamespacedName
    /// <summary>
    /// (ADL FT) For smaller, less formally established communities, use 'populated places'. For independent cities, use 'countries, 2nd order divisions. Incorporated populated places. [Adapted from USGS Circ 1048] We use this category for municipalities; for towns; and for urban areas. NIMA GNS designator PPL.
    /// <see href="http://www.ontotext.com/proton/protonext#City"></see></summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName
    /// <summary>
    /// Any automoabile car.
    /// <see href="http://www.ontotext.com/proton/protonext#Car"></see></summary>
    let Car = Namespaced_IRI.parse _namespace_name "Car" |> NamespacedName
    /// <summary>
    /// Any sort of specific vehicle, mean of transportation.
    /// <see href="http://www.ontotext.com/proton/protonext#Vehicle"></see></summary>
    let Vehicle = Namespaced_IRI.parse _namespace_name "Vehicle" |> NamespacedName
    /// <summary>
    /// A concrete model of a car which determines the main features of any car of this model. For example, Ford-T or BMW Z3.
    /// <see href="http://www.ontotext.com/proton/protonext#CarModel"></see></summary>
    let CarModel = Namespaced_IRI.parse _namespace_name "CarModel" |> NamespacedName
    /// <summary>
    /// Any Cardinal, a high official in the Roman-Catholic church.
    /// <see href="http://www.ontotext.com/proton/protonext#Cardinal"></see></summary>
    let Cardinal = Namespaced_IRI.parse _namespace_name "Cardinal" |> NamespacedName
    /// <summary>
    /// (ADL FT) Natural underground passageways or chambers, or hollowed out cavities in the side of a cliff. ... We use this category for cave entrances; for caverns; for grottoes; for natural tunnels; and for underground lakes. NIMA GNS designator CAVE.
    /// <see href="http://www.ontotext.com/proton/protonext#Cave"></see></summary>
    let Cave = Namespaced_IRI.parse _namespace_name "Cave" |> NamespacedName
    /// <summary>
    /// The situation of holding a position in a society as celebrity.
    /// <see href="http://www.ontotext.com/proton/protonext#Celebrity"></see></summary>
    let Celebrity = Namespaced_IRI.parse _namespace_name "Celebrity" |> NamespacedName

    /// <summary>
    /// The social function of celebrity, a status of notoriety in the society.
    /// <see href="http://www.ontotext.com/proton/protonext#CelebrityTitle"></see></summary>
    let CelebrityTitle =
        Namespaced_IRI.parse _namespace_name "CelebrityTitle" |> NamespacedName

    /// <summary>
    /// The name of a function a person has in the society like nobely, job title, celebrity, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#SocialFunction"></see></summary>
    let SocialFunction =
        Namespaced_IRI.parse _namespace_name "SocialFunction" |> NamespacedName

    /// <summary>
    /// Any Chancellor, a title of various official positions in the governments of many nations. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Chancellor"></see></summary>
    let Chancellor = Namespaced_IRI.parse _namespace_name "Chancellor" |> NamespacedName
    /// <summary>
    /// (ADL FT) (a) Relatively narrow seas or stretches of water between two close landmasses and connecting two larger bodies of water; (b) Deeper parts of a moving body of water (as bays, estuaries, or straits) through which the main current flows or which affords the best passage through an area otherwise too shallow to navigate. ... We use this category for chutes (hydrographic); for cutoffs (hydrographic); for inlets; for lake channels; for marine channels; for narrows (hydrographic); for navigation channels; for reaches (hydrographic); for sounds (bodies of water); and for straits. NIMA GNS designators CHN, CHNL, CHNM, CHNN, STRT.
    /// <see href="http://www.ontotext.com/proton/protonext#Channel"></see></summary>
    let Channel = Namespaced_IRI.parse _namespace_name "Channel" |> NamespacedName
    /// <summary>
    /// Any Charity, an organization involved in the practice of benevolent giving and caring. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Charity"></see></summary>
    let Charity = Namespaced_IRI.parse _namespace_name "Charity" |> NamespacedName

    /// <summary>
    /// Any Non-Profit Organization, an organization that does not distribute its surplus funds to owners or shareholders, but instead uses them to help pursue its goals. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Non-ProfitOrganisation"></see></summary>
    let ``Non-ProfitOrganisation`` =
        Namespaced_IRI.parse _namespace_name "Non-ProfitOrganisation" |> NamespacedName

    /// <summary>
    /// Any substance or element that has chemical nature.
    /// <see href="http://www.ontotext.com/proton/protonext#ChemicalSubstance"></see></summary>
    let ChemicalSubstance =
        Namespaced_IRI.parse _namespace_name "ChemicalSubstance" |> NamespacedName

    /// <summary>
    /// A chemical element is a pure chemical substance consisting of one type of atom distinguished by its atomic number, which is the number of protons in its nucleus. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#ChemicalElement"></see></summary>
    let ChemicalElement =
        Namespaced_IRI.parse _namespace_name "ChemicalElement" |> NamespacedName

    /// <summary>
    /// The profession of a chess player
    /// <see href="http://www.ontotext.com/proton/protonext#ChessPlayer"></see></summary>
    let ChessPlayer =
        Namespaced_IRI.parse _namespace_name "ChessPlayer" |> NamespacedName

    /// <summary>
    /// Any Christian Patriarch.
    /// <see href="http://www.ontotext.com/proton/protonext#ChristianPatriarch"></see></summary>
    let ChristianPatriarch =
        Namespaced_IRI.parse _namespace_name "ChristianPatriarch" |> NamespacedName

    /// <summary>
    /// Describes a populated place with organisation, like city, village, town
    /// <see href="http://www.ontotext.com/proton/protonext#Settlement"></see></summary>
    let Settlement = Namespaced_IRI.parse _namespace_name "Settlement" |> NamespacedName
    /// <summary>
    /// The situation of holding a position in society as cleric.
    /// <see href="http://www.ontotext.com/proton/protonext#Cleric"></see></summary>
    let Cleric = Namespaced_IRI.parse _namespace_name "Cleric" |> NamespacedName
    /// <summary>
    /// (ADL FT: Coastal Zones) Strips of land (of indefinite width) that extend from the low-tide line inland to the first major change in landform features. [Adapted from Glossary of Geology, 4th ed.] We use this category for coastal plains; for coasts; for intertidal zones; for offshore areas; for shorelines; and for shores. NIMA GNS designators CST, SHOR.
    /// <see href="http://www.ontotext.com/proton/protonext#Coast"></see></summary>
    let Coast = Namespaced_IRI.parse _namespace_name "Coast" |> NamespacedName

    /// <summary>
    /// A planting of coconut trees
    /// <see href="http://www.ontotext.com/proton/protonext#CoconutGrove"></see></summary>
    let CoconutGrove =
        Namespaced_IRI.parse _namespace_name "CoconutGrove" |> NamespacedName

    /// <summary>
    /// An education organization between the school and the university. In some cases it is a part of university.
    /// College
    /// <see href="http://www.ontotext.com/proton/protonext#College"></see></summary>
    let College = Namespaced_IRI.parse _namespace_name "College" |> NamespacedName

    /// <summary>
    /// An organization devoted to teaching activities.
    /// <see href="http://www.ontotext.com/proton/protonext#EducationalOrganization"></see></summary>
    let EducationalOrganization =
        Namespaced_IRI.parse _namespace_name "EducationalOrganization" |> NamespacedName

    /// <summary>
    /// Any colour, a visual perceptual property, e.g. red, blue, yellow, etc. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Colour"></see></summary>
    let Colour = Namespaced_IRI.parse _namespace_name "Colour" |> NamespacedName
    /// <summary>
    /// The profession of a comedian
    /// <see href="http://www.ontotext.com/proton/protonext#Comedian"></see></summary>
    let Comedian = Namespaced_IRI.parse _namespace_name "Comedian" |> NamespacedName

    /// <summary>
    /// A character from a comics.
    /// <see href="http://www.ontotext.com/proton/protonext#ComicsCharacter"></see></summary>
    let ComicsCharacter =
        Namespaced_IRI.parse _namespace_name "ComicsCharacter" |> NamespacedName

    /// <summary>
    /// The characters in fictional artwork like movies, books, etc
    /// <see href="http://www.ontotext.com/proton/protonext#FictionalCharacter"></see></summary>
    let FictionalCharacter =
        Namespaced_IRI.parse _namespace_name "FictionalCharacter" |> NamespacedName

    /// <summary>
    /// The profession of comics creator
    /// <see href="http://www.ontotext.com/proton/protonext#ComicsCreator"></see></summary>
    let ComicsCreator =
        Namespaced_IRI.parse _namespace_name "ComicsCreator" |> NamespacedName

    /// <summary>
    /// Any commander, title of being commander or having a leading role in a military unit or other organization.
    /// <see href="http://www.ontotext.com/proton/protonext#Commander"></see></summary>
    let Commander = Namespaced_IRI.parse _namespace_name "Commander" |> NamespacedName

    /// <summary>
    /// Organization that buys or sells goods or services for a profit. It may also be a Business or it may merely be a sub-organization of a Business entity.
    /// <see href="http://www.ontotext.com/proton/protonext#CommercialOrganization"></see></summary>
    let CommercialOrganization =
        Namespaced_IRI.parse _namespace_name "CommercialOrganization" |> NamespacedName

    /// <summary>
    /// An art performance consisting of playing music.
    /// <see href="http://www.ontotext.com/proton/protonext#Concert"></see></summary>
    let Concert = Namespaced_IRI.parse _namespace_name "Concert" |> NamespacedName
    /// <summary>
    /// in geography, describes the meeting of two or more bodies of water. The opposite of a watershed. NIMA GNS designator H.CNFL.
    /// <see href="http://www.ontotext.com/proton/protonext#Confluence"></see></summary>
    let Confluence = Namespaced_IRI.parse _namespace_name "Confluence" |> NamespacedName

    /// <summary>
    /// Any Congressman, a title of a position in congress.
    /// <see href="http://www.ontotext.com/proton/protonext#Congressman"></see></summary>
    let Congressman =
        Namespaced_IRI.parse _namespace_name "Congressman" |> NamespacedName

    /// <summary>
    /// (ADL FT) Earth's major land masses, including both dry land and continental shelves. NIMA GNS designator - no equivalent.
    /// <see href="http://www.ontotext.com/proton/protonext#Continent"></see></summary>
    let Continent = Namespaced_IRI.parse _namespace_name "Continent" |> NamespacedName

    /// <summary>
    /// A zone adjacent to a continent (or around an island) that extends from the low water line to a depth at which there is usually a marked increase of slope towards oceanic depths
    /// <see href="http://www.ontotext.com/proton/protonext#ContinentalShelf"></see></summary>
    let ContinentalShelf =
        Namespaced_IRI.parse _namespace_name "ContinentalShelf" |> NamespacedName

    /// <summary>
    /// Any sort of contract or treaty, as well, as other documents signed or otherwise accepted by more than one agent.
    /// <see href="http://www.ontotext.com/proton/protonext#Contract"></see></summary>
    let Contract = Namespaced_IRI.parse _namespace_name "Contract" |> NamespacedName
    /// <summary>
    /// (ADL FTT) Territory occupied by a large group of people organized under a single, usually independent government, and recognized internationally as a country. [Adapted from American Heritage Dic. of the English Language, 4th ed.] We use this category for nations; and for republics. NIMA GNS designators PCL, PCLD, PCLF, PCLI, PCLS. FIPS 10-4 is applicable, difining: Basic geopolitical entities assigned country codes include the following categories: (a) independent states; (b) dependent areas; (c) areas of quasi-independence, non-contiguous territories, possessions without populations, areas with special sovereignty associations, areas without sovereignty; (d) political regimes not recognized by the United States; and (e) outlying areas of the United States. The list of basic entities provides complete coverage of the land areas of the world without overlap or duplication.
    /// <see href="http://www.ontotext.com/proton/protonext#Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName

    /// <summary>
    /// (ADL, Political Entity) We use this category for commonwealths; for dependent political entities; for freely associated states; for independent political entities; for oblasts; for political entities; and for semi-independent political entities. Sub-classes omitted: Countries, 4th order divisions. NIMA GNS class: A, Administrative Boundary Features.
    /// <see href="http://www.ontotext.com/proton/protonext#PoliticalRegion"></see></summary>
    let PoliticalRegion =
        Namespaced_IRI.parse _namespace_name "PoliticalRegion" |> NamespacedName

    /// <summary>
    /// A capital of a Country. NIMA GNS designator PPLC.
    /// <see href="http://www.ontotext.com/proton/protonext#CountryCapital"></see></summary>
    let CountryCapital =
        Namespaced_IRI.parse _namespace_name "CountryCapital" |> NamespacedName

    /// <summary>
    /// (ADL FT: Countries, 2nd order divisions) Second-order divisions of a nation such as parishes, boroughs, counties, municipios, or judicial divisions, and independent cities such as those in Maryland, Missouri, Nevada, and Virginia. [Adapted from USGS Circ 1048] We use this category for boroughs; for counties; for judicial divisions; for municipios; for parishes; and for second-order administrative divisions. NIMA GNS designator ADM2.
    /// <see href="http://www.ontotext.com/proton/protonext#County"></see></summary>
    let County = Namespaced_IRI.parse _namespace_name "County" |> NamespacedName
    /// <summary>
    /// a small type of bay or coastal inlet. http://www.eionet.europa.eu/gemet/concept/10142 NIMA GNS designator H.COVE.
    /// <see href="http://www.ontotext.com/proton/protonext#Cove"></see></summary>
    let Cove = Namespaced_IRI.parse _namespace_name "Cove" |> NamespacedName
    /// <summary>
    /// (ADL FT) Circular-shaped depressions at the summit of a volcanic core or on the surface of the land caused by the impact of a meteorite; man-made depressions caused by an explosion. ... We use this category for calderas. NIMA GNS designator CRTR, CLDA.
    /// <see href="http://www.ontotext.com/proton/protonext#Crater"></see></summary>
    let Crater = Namespaced_IRI.parse _namespace_name "Crater" |> NamespacedName
    /// <summary>
    /// (ADL FT: Guts) Relatively small coastal waterways connecting larger bodies of water or other waterways. NIMA GNS designator CRKT, INLT.
    /// <see href="http://www.ontotext.com/proton/protonext#Creek"></see></summary>
    let Creek = Namespaced_IRI.parse _namespace_name "Creek" |> NamespacedName

    /// <summary>
    /// Any Cricket league
    /// <see href="http://www.ontotext.com/proton/protonext#CricketLeague"></see></summary>
    let CricketLeague =
        Namespaced_IRI.parse _namespace_name "CricketLeague" |> NamespacedName

    /// <summary>
    /// The profession of cricketer
    /// <see href="http://www.ontotext.com/proton/protonext#Cricketer"></see></summary>
    let Cricketer = Namespaced_IRI.parse _namespace_name "Cricketer" |> NamespacedName
    /// <summary>
    /// Crustaceans denotes a group of arthropods animals, which includes crabs, lobsters, crayfish, shrimp, krill and barnacles. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Crustacean"></see></summary>
    let Crustacean = Namespaced_IRI.parse _namespace_name "Crustacean" |> NamespacedName

    /// <summary>
    /// An area under cultivation
    /// <see href="http://www.ontotext.com/proton/protonext#CultivatedArea"></see></summary>
    let CultivatedArea =
        Namespaced_IRI.parse _namespace_name "CultivatedArea" |> NamespacedName

    /// <summary>
    /// Any Curling league
    /// <see href="http://www.ontotext.com/proton/protonext#CurlingLeague"></see></summary>
    let CurlingLeague =
        Namespaced_IRI.parse _namespace_name "CurlingLeague" |> NamespacedName

    /// <summary>
    /// Specific currency, usually national
    /// <see href="http://www.ontotext.com/proton/protonext#Currency"></see></summary>
    let Currency = Namespaced_IRI.parse _namespace_name "Currency" |> NamespacedName
    /// <summary>
    /// A particular notation for representation, standardization, and/or structuring of infomation. It can range from db schema, through ontology, to any sort of taxonomies, nomenclatures and subject hierarchies. Examples are Dublin Core, KIMO, SIC, XML, RDFS
    /// <see href="http://www.ontotext.com/proton/protonext#DataSchema"></see></summary>
    let DataSchema = Namespaced_IRI.parse _namespace_name "DataSchema" |> NamespacedName
    /// <summary>
    /// A dataset is information encoded in a defined structure (for example, lists, tables, and databases), intended to be useful for direct machine processing (DCMI Type.) Somehow structured and interrelated body of information, data, or knowledge. This includes databases, knowledge bases, catalogues, registries, specific lists, etc. All tangible aspects (like media or host) are irrelevant for this class - it only considers the abstract information. What can be considered as a single document is outside the scope of this class, although it can be comprehensive in terms of size and structure.
    /// <see href="http://www.ontotext.com/proton/protonext#Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName
    /// <summary>
    /// A specific date, as 12th of April, 1956, as the time period (the 24 hours of the day)
    /// <see href="http://www.ontotext.com/proton/protonext#Date"></see></summary>
    let Date = Namespaced_IRI.parse _namespace_name "Date" |> NamespacedName
    /// <summary>
    /// A specific day of a given month. The days are numbered from 1 to 28, 29, 30, or 31 depending on the month and the year.
    /// <see href="http://www.ontotext.com/proton/protonext#DayOfMonth"></see></summary>
    let DayOfMonth = Namespaced_IRI.parse _namespace_name "DayOfMonth" |> NamespacedName
    /// <summary>
    /// A specific day of the week. The week has seven days: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday.
    /// <see href="http://www.ontotext.com/proton/protonext#DayOfWeek"></see></summary>
    let DayOfWeek = Namespaced_IRI.parse _namespace_name "DayOfWeek" |> NamespacedName
    /// <summary>
    /// Specific time (point) during the day, when the day is not specified. Like in "the supermarket is closing 20:30 p.m."
    /// <see href="http://www.ontotext.com/proton/protonext#DayTime"></see></summary>
    let DayTime = Namespaced_IRI.parse _namespace_name "DayTime" |> NamespacedName
    /// <summary>
    /// The event to die.
    /// <see href="http://www.ontotext.com/proton/protonext#Death"></see></summary>
    let Death = Namespaced_IRI.parse _namespace_name "Death" |> NamespacedName
    /// <summary>
    /// (ADL FT) Flat plains formed by alluvial deposits at the mouth of a stream. NIMA GNS designator DLTA.
    /// <see href="http://www.ontotext.com/proton/protonext#Delta"></see></summary>
    let Delta = Namespaced_IRI.parse _namespace_name "Delta" |> NamespacedName
    /// <summary>
    /// The occupation of deputy
    /// <see href="http://www.ontotext.com/proton/protonext#Deputy"></see></summary>
    let Deputy = Namespaced_IRI.parse _namespace_name "Deputy" |> NamespacedName
    /// <summary>
    /// (ADL FT) Regions rendered barren or partially barren by environmental extremes, especially by low rainfall. [USGS Circ 1048] We use this category for arid regions; for bajadas; for rock deserts; for sandy areas; for sandy deserts; and for stony deserts. NIMA GNS designators DSRT, ERG, HMDA, REG.
    /// <see href="http://www.ontotext.com/proton/protonext#Desert"></see></summary>
    let Desert = Namespaced_IRI.parse _namespace_name "Desert" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#Device"></see>
    /// </summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName
    /// <summary>
    /// A specific sort of desease, such as AIDS, SARS, Parcinson, etc. The instances of those class can often by considered as terms instead of entities, but in all cases, those are the general phenomena, not the particular situations when somebody is suffering the disease.
    /// <see href="http://www.ontotext.com/proton/protonext#Disease"></see></summary>
    let Disease = Namespaced_IRI.parse _namespace_name "Disease" |> NamespacedName
    /// <summary>
    /// A ditch is usually defined as a small to moderate depression created to channel water.(Wikipedia). http://www.eionet.europa.eu/gemet/concept/2276. NIMA GNS designators H.DTCH, H.DTCHD, H.DTCHI, H.DTCHM.
    /// <see href="http://www.ontotext.com/proton/protonext#Ditch"></see></summary>
    let Ditch = Namespaced_IRI.parse _namespace_name "Ditch" |> NamespacedName
    /// <summary>
    /// Branch, division, department, laboratory, etc. within an organisation. Usually, not a legal agent and not independent.
    /// <see href="http://www.ontotext.com/proton/protonext#Division"></see></summary>
    let Division = Namespaced_IRI.parse _namespace_name "Division" |> NamespacedName

    /// <summary>
    /// An area drained by a stream. NIMA GNS designator L.BSND.
    /// <see href="http://www.ontotext.com/proton/protonext#DrainageBasin"></see></summary>
    let DrainageBasin =
        Namespaced_IRI.parse _namespace_name "DrainageBasin" |> NamespacedName

    /// <summary>
    /// A chemical substance used to improve the health condition of a person, animal, etc. For example, Aspirin, Viagra, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Drug"></see></summary>
    let Drug = Namespaced_IRI.parse _namespace_name "Drug" |> NamespacedName
    /// <summary>
    /// An identifier that determines a electronic mail box.
    /// <see href="http://www.ontotext.com/proton/protonext#EMail"></see></summary>
    let EMail = Namespaced_IRI.parse _namespace_name "EMail" |> NamespacedName

    /// <summary>
    /// An identifier that determines a resource on the Internet.
    /// <see href="http://www.ontotext.com/proton/protonext#InternetAddress"></see></summary>
    let InternetAddress =
        Namespaced_IRI.parse _namespace_name "InternetAddress" |> NamespacedName

    /// <summary>
    /// Generic concept of Election which is normally held at regular periods of time, president elections of the US, municipal elections, etc..
    /// <see href="http://www.ontotext.com/proton/protonext#Election"></see></summary>
    let Election = Namespaced_IRI.parse _namespace_name "Election" |> NamespacedName

    /// <summary>
    /// Recurring sequence of events, such as Olympic Games, etc..
    /// <see href="http://www.ontotext.com/proton/protonext#RecurringEvent"></see></summary>
    let RecurringEvent =
        Namespaced_IRI.parse _namespace_name "RecurringEvent" |> NamespacedName

    /// <summary>
    /// Election happening at a particular date.
    /// <see href="http://www.ontotext.com/proton/protonext#ElectionOccurrence"></see></summary>
    let ElectionOccurrence =
        Namespaced_IRI.parse _namespace_name "ElectionOccurrence" |> NamespacedName

    /// <summary>
    /// A webpage of a map
    /// <see href="http://www.ontotext.com/proton/protonext#ElectronicMap"></see></summary>
    let ElectronicMap =
        Namespaced_IRI.parse _namespace_name "ElectronicMap" |> NamespacedName

    /// <summary>
    /// Embryology is a science that studies the development of the embryo. This class denotes different composing substances/elements of the embryo and related body parts, and hence is referred to as a body part. It is inspired form DBPedia Embryology/AnatomicalStructure, which has instances as Blastocyst, Amniotic cavity, Vitelline membrane, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#EmbryoBodyPart"></see></summary>
    let EmbryoBodyPart =
        Namespaced_IRI.parse _namespace_name "EmbryoBodyPart" |> NamespacedName

    /// <summary>
    /// Any Entertainment Company, a company involved in the entertainment business, e.g. Warner Brothers, MTV, Lido, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#EntertainmentCompany"></see></summary>
    let EntertainmentCompany =
        Namespaced_IRI.parse _namespace_name "EntertainmentCompany" |> NamespacedName

    /// <summary>
    /// A partly enclosed coastal body of water with one or more rivers or streams flowing into it, and with a free connection to the open sea. NIMA GNS designator H.ESTY.
    /// <see href="http://www.ontotext.com/proton/protonext#Estuary"></see></summary>
    let Estuary = Namespaced_IRI.parse _namespace_name "Estuary" |> NamespacedName

    /// <summary>
    /// Any ethnic group. A group of people whose members identify with each other, through a common heritage, often consisting of a common language, a common culture (often including a shared religion) and an ideology that stresses common ancestry or endogamy. (Wikipedia).
    /// <see href="http://www.ontotext.com/proton/protonext#EthnicGroup"></see></summary>
    let EthnicGroup =
        Namespaced_IRI.parse _namespace_name "EthnicGroup" |> NamespacedName

    /// <summary>
    /// An inlet which has been filled in, or blocked by deposits
    /// <see href="http://www.ontotext.com/proton/protonext#FInlet"></see></summary>
    let FInlet = Namespaced_IRI.parse _namespace_name "FInlet" |> NamespacedName

    /// <summary>
    /// Any model, a profession involving posing to draw attention to a particualr object or cause.
    /// <see href="http://www.ontotext.com/proton/protonext#FashionModel"></see></summary>
    let FashionModel =
        Namespaced_IRI.parse _namespace_name "FashionModel" |> NamespacedName

    /// <summary>
    /// A phone number connected to a fax machine.
    /// <see href="http://www.ontotext.com/proton/protonext#FaxNumber"></see></summary>
    let FaxNumber = Namespaced_IRI.parse _namespace_name "FaxNumber" |> NamespacedName

    /// <summary>
    /// A sequence of digits which represents an address of a telephone device within a telephone net.
    /// <see href="http://www.ontotext.com/proton/protonext#PhoneNumber"></see></summary>
    let PhoneNumber =
        Namespaced_IRI.parse _namespace_name "PhoneNumber" |> NamespacedName

    /// <summary>
    /// Any widely recognized festival or holiday, such as, Christmas or St. Valentine's Day.
    /// <see href="http://www.ontotext.com/proton/protonext#Festival"></see></summary>
    let Festival = Namespaced_IRI.parse _namespace_name "Festival" |> NamespacedName

    /// <summary>
    /// An occurrence of a Festival or holiday, Sofia Film Festival 2011, Christmas of 2010 or St. Valentine's Day of 2011.
    /// <see href="http://www.ontotext.com/proton/protonext#FestivalOccurrence"></see></summary>
    let FestivalOccurrence =
        Namespaced_IRI.parse _namespace_name "FestivalOccurrence" |> NamespacedName

    /// <summary>
    /// Any Field Hockey league
    /// <see href="http://www.ontotext.com/proton/protonext#FieldHockeyLeague"></see></summary>
    let FieldHockeyLeague =
        Namespaced_IRI.parse _namespace_name "FieldHockeyLeague" |> NamespacedName

    /// <summary>
    /// The profession of figure skater
    /// <see href="http://www.ontotext.com/proton/protonext#FigureSkater"></see></summary>
    let FigureSkater =
        Namespaced_IRI.parse _namespace_name "FigureSkater" |> NamespacedName

    /// <summary>
    /// Any festival involving showing a film.
    /// <see href="http://www.ontotext.com/proton/protonext#FilmFestival"></see></summary>
    let FilmFestival =
        Namespaced_IRI.parse _namespace_name "FilmFestival" |> NamespacedName

    /// <summary>
    /// A fish is any gill-bearing aquatic vertebrate (or craniate) animal that lacks limbs with digits. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Fish"></see></summary>
    let Fish = Namespaced_IRI.parse _namespace_name "Fish" |> NamespacedName

    /// <summary>
    /// A bank or area where fishermen go to catch fish. NIMA GNS designator H.FISH.
    /// <see href="http://www.ontotext.com/proton/protonext#FishingArea"></see></summary>
    let FishingArea =
        Namespaced_IRI.parse _namespace_name "FishingArea" |> NamespacedName

    /// <summary>
    /// (ADL FT) Long narrow glacially-eroded inlets of the sea, U-shaped and steep-walled, generally several hundred meters deep, between high rocky cliffs or slopes along a mountainous coast. ... We use this category for fiords; and for lochs. NIMA GNS designator FJD, FJDS.
    /// <see href="http://www.ontotext.com/proton/protonext#Fjord"></see></summary>
    let Fjord = Namespaced_IRI.parse _namespace_name "Fjord" |> NamespacedName

    /// <summary>
    /// Any flowering plant
    /// <see href="http://www.ontotext.com/proton/protonext#FloweringPlant"></see></summary>
    let FloweringPlant =
        Namespaced_IRI.parse _namespace_name "FloweringPlant" |> NamespacedName

    /// <summary>
    /// Plants are living organisms. They include familiar organisms such as trees, flowers, herbs, bushes, grasses, vines, ferns, mosses, and green algae. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Plant"></see></summary>
    let Plant = Namespaced_IRI.parse _namespace_name "Plant" |> NamespacedName
    /// <summary>
    /// Food is any eatable or drinkable substance that is normally consumed by humans. DBPedia
    /// <see href="http://www.ontotext.com/proton/protonext#Food"></see></summary>
    let Food = Namespaced_IRI.parse _namespace_name "Food" |> NamespacedName

    /// <summary>
    /// Any instance of a soccer match.
    /// <see href="http://www.ontotext.com/proton/protonext#FootballMatch"></see></summary>
    let FootballMatch =
        Namespaced_IRI.parse _namespace_name "FootballMatch" |> NamespacedName

    /// <summary>
    /// A sport game is any instance of a sport event, where teams or individuals gather to play according to particular predetermined rules, such as soccer match, tennis match, car race, etc. It can also denote the activity of playing a particular sport game.
    /// <see href="http://www.ontotext.com/proton/protonext#SportGame"></see></summary>
    let SportGame = Namespaced_IRI.parse _namespace_name "SportGame" |> NamespacedName
    /// <summary>
    /// (ADL FT) Dense growths of trees, plants, and underbrush covering a large area. [American Heritage Dic. of the English Language, 4th ed.] We use this category for forest reserves; and for national forests. Omitted ADL sub-classes: Petrified forests, Rain forests, Woods (the sub-classes collapsed here). NIMA GNS designator FRST, FRSTF, GDVC, GRVO, GRVP, GRVPN, TREE.
    /// <see href="http://www.ontotext.com/proton/protonext#Forest"></see></summary>
    let Forest = Namespaced_IRI.parse _namespace_name "Forest" |> NamespacedName

    /// <summary>
    /// An area in a forest with trees removed. NIMA GNS designator L.CLG.
    /// <see href="http://www.ontotext.com/proton/protonext#ForestClearing"></see></summary>
    let ForestClearing =
        Namespaced_IRI.parse _namespace_name "ForestClearing" |> NamespacedName

    /// <summary>
    /// The profession of formula one racer
    /// <see href="http://www.ontotext.com/proton/protonext#FormulaOneRacer"></see></summary>
    let FormulaOneRacer =
        Namespaced_IRI.parse _namespace_name "FormulaOneRacer" |> NamespacedName

    /// <summary>
    /// Fungus is a member of a large group of eukaryotic organisms that includes microorganisms such as yeasts and molds (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Fungus"></see></summary>
    let Fungus = Namespaced_IRI.parse _namespace_name "Fungus" |> NamespacedName

    /// <summary>
    /// The profession of gaelic games player
    /// <see href="http://www.ontotext.com/proton/protonext#GaelicGamesPlayer"></see></summary>
    let GaelicGamesPlayer =
        Namespaced_IRI.parse _namespace_name "GaelicGamesPlayer" |> NamespacedName

    /// <summary>
    /// A galaxy is a massive, gravitationally bound system that consists of stars and stellar remnants, an interstellar medium of gas and dust, and an important but poorly understood component tentatively dubbed dark matter. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#Galaxy"></see></summary>
    let Galaxy = Namespaced_IRI.parse _namespace_name "Galaxy" |> NamespacedName
    /// <summary>
    /// Game. Activity involving participants usually divided in teams, which obeys particualr rules, and has often a winner.
    /// <see href="http://www.ontotext.com/proton/protonext#Game"></see></summary>
    let Game = Namespaced_IRI.parse _namespace_name "Game" |> NamespacedName
    /// <summary>
    /// (ADL FT) Ravines or gorges cut deeply through mountain ridges, or between hills or mountains. We use this category for cols; for defiles; for passes; for saddles (physiographic); and for sills (physiographic). NIMA GNS designator GAP, GAPU, GAPF, PASS, SILL, SILU.
    /// <see href="http://www.ontotext.com/proton/protonext#Gap"></see></summary>
    let Gap = Namespaced_IRI.parse _namespace_name "Gap" |> NamespacedName
    /// <summary>
    /// A gene is a molecular unit of heredity of a living organism. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#Gene"></see></summary>
    let Gene = Namespaced_IRI.parse _namespace_name "Gene" |> NamespacedName
    /// <summary>
    /// Any Genre. Denotes any category of literature as well as various other forms of art or culture, e.g., music, based on some loose set of stylistic criteria. Genres are formed by conventions that change over time as new genres are invented and the use of old ones are discontinued. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Genre"></see></summary>
    let Genre = Namespaced_IRI.parse _namespace_name "Genre" |> NamespacedName

    /// <summary>
    /// Any Geographic Region with lattitude and longitude coordinates
    /// <see href="http://www.ontotext.com/proton/protonext#GeographicLocation"></see></summary>
    let GeographicLocation =
        Namespaced_IRI.parse _namespace_name "GeographicLocation" |> NamespacedName

    /// <summary>
    /// Any geopolitical organization, an organization based on geo-political principles.
    /// <see href="http://www.ontotext.com/proton/protonext#GeopoliticalOrganization"></see></summary>
    let GeopoliticalOrganization =
        Namespaced_IRI.parse _namespace_name "GeopoliticalOrganization" |> NamespacedName

    /// <summary>
    /// A spring characterized by intermittent discharge of water ejected turbulently and accompanied by a vapour phase (steam). NIMA GNS designator H.GYSR.
    /// <see href="http://www.ontotext.com/proton/protonext#Geyser"></see></summary>
    let Geyser = Namespaced_IRI.parse _namespace_name "Geyser" |> NamespacedName
    /// <summary>
    /// (ADL FT) Places where underground water flows naturally to the surface of the Earth. ... We use this category for mineral springs; and for sulfur springs. NIMA GNS designators SPNG, SPNS, SPNT.
    /// <see href="http://www.ontotext.com/proton/protonext#Spring"></see></summary>
    let Spring = Namespaced_IRI.parse _namespace_name "Spring" |> NamespacedName
    /// <summary>
    /// A mass of ice, usually at high latitudes or high elevations, with sufficient thickness to flow away from the source area in lobes, tongues, or masses
    /// <see href="http://www.ontotext.com/proton/protonext#Glacier"></see></summary>
    let Glacier = Namespaced_IRI.parse _namespace_name "Glacier" |> NamespacedName

    /// <summary>
    /// Things like Southeastern Europe, Middle East, Oceania are global regions
    /// <see href="http://www.ontotext.com/proton/protonext#GlobalRegion"></see></summary>
    let GlobalRegion =
        Namespaced_IRI.parse _namespace_name "GlobalRegion" |> NamespacedName

    /// <summary>
    /// Any Golf league
    /// <see href="http://www.ontotext.com/proton/protonext#GolfLeague"></see></summary>
    let GolfLeague = Namespaced_IRI.parse _namespace_name "GolfLeague" |> NamespacedName
    /// <summary>
    /// Any player of Golf.
    /// <see href="http://www.ontotext.com/proton/protonext#GolfPlayer"></see></summary>
    let GolfPlayer = Namespaced_IRI.parse _namespace_name "GolfPlayer" |> NamespacedName
    /// <summary>
    /// The government of a country.
    /// The governmental cabinet
    /// <see href="http://www.ontotext.com/proton/protonext#Government"></see></summary>
    let Government = Namespaced_IRI.parse _namespace_name "Government" |> NamespacedName

    /// <summary>
    /// The government of a country, i.e. the authorized country administration, without account for a specific government elected and being in power for some period. This notion of government groups all the administration, including any sort of ministries, agencies, commissions, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#GovernmentOrganization"></see></summary>
    let GovernmentOrganization =
        Namespaced_IRI.parse _namespace_name "GovernmentOrganization" |> NamespacedName

    /// <summary>
    /// A government agency is a permanent or semi-permanent organization in the machinery of government that is responsible for the oversight and administration of specific functions, such as an intelligence agency. DBPedia
    /// The governmental cabinet
    /// <see href="http://www.ontotext.com/proton/protonext#GovernmentAgency"></see></summary>
    let GovernmentAgency =
        Namespaced_IRI.parse _namespace_name "GovernmentAgency" |> NamespacedName

    /// <summary>
    /// A government building, a building which serves the government, or where government officials work.
    /// <see href="http://www.ontotext.com/proton/protonext#GovernmentBuilding"></see></summary>
    let GovernmentBuilding =
        Namespaced_IRI.parse _namespace_name "GovernmentBuilding" |> NamespacedName

    /// <summary>
    /// Any Governor, a title of Governor of a district.
    /// <see href="http://www.ontotext.com/proton/protonext#Governor"></see></summary>
    let Governor = Namespaced_IRI.parse _namespace_name "Governor" |> NamespacedName
    /// <summary>
    /// Any grape
    /// <see href="http://www.ontotext.com/proton/protonext#Grape"></see></summary>
    let Grape = Namespaced_IRI.parse _namespace_name "Grape" |> NamespacedName
    /// <summary>
    /// An area dominated by grass vegetation
    /// <see href="http://www.ontotext.com/proton/protonext#Grassland"></see></summary>
    let Grassland = Namespaced_IRI.parse _namespace_name "Grassland" |> NamespacedName

    /// <summary>
    /// Any player of a gridilon football.
    /// <see href="http://www.ontotext.com/proton/protonext#GridironFootballPlayer"></see></summary>
    let GridironFootballPlayer =
        Namespaced_IRI.parse _namespace_name "GridironFootballPlayer" |> NamespacedName

    /// <summary>
    /// (ADL FT) Largest of various forms of inlets of the sea; usually larger, more enclosed, and more deeply indented than bays. NIMA GNS designator GULF.
    /// <see href="http://www.ontotext.com/proton/protonext#Gulf"></see></summary>
    let Gulf = Namespaced_IRI.parse _namespace_name "Gulf" |> NamespacedName
    /// <summary>
    /// A seamount having a comparatively smooth, flat top
    /// <see href="http://www.ontotext.com/proton/protonext#Guyot"></see></summary>
    let Guyot = Namespaced_IRI.parse _namespace_name "Guyot" |> NamespacedName

    /// <summary>
    /// Any Handball league
    /// <see href="http://www.ontotext.com/proton/protonext#HandballLeague"></see></summary>
    let HandballLeague =
        Namespaced_IRI.parse _namespace_name "HandballLeague" |> NamespacedName

    /// <summary>
    /// (ADL FT) Sheltered areas of water where ships or other watercraft can anchor or dock. We use this category for anchorages; for anclajes; for boat yards; for boatyards; for dock yards; for docking basins; for dockyards; for dry docks; for harbors; for marine terminals; for moorings; for ports; for roadsteads (anchorages); and for turning basins. The following sub-classes included (i.e. not-distinguishable): Marinas, Piers. NIMA GNS designators HBR, HBRX, MAR, BTYD, PIER, DCK, DCKB, DCKY, PRT, AIRS.
    /// <see href="http://www.ontotext.com/proton/protonext#Harbor"></see></summary>
    let Harbor = Namespaced_IRI.parse _namespace_name "Harbor" |> NamespacedName
    /// <summary>
    /// An upland moor or sandy area dominated by low shrubby vegetation including heather
    /// <see href="http://www.ontotext.com/proton/protonext#Heath"></see></summary>
    let Heath = Namespaced_IRI.parse _namespace_name "Heath" |> NamespacedName

    /// <summary>
    /// Any Historic Building, an old building with historic value.
    /// <see href="http://www.ontotext.com/proton/protonext#HistoricBuilding"></see></summary>
    let HistoricBuilding =
        Namespaced_IRI.parse _namespace_name "HistoricBuilding" |> NamespacedName

    /// <summary>
    /// Any place with some particular value, which triggers interest.
    /// <see href="http://www.ontotext.com/proton/protonext#LocationOfSpecialInterest"></see></summary>
    let LocationOfSpecialInterest =
        Namespaced_IRI.parse _namespace_name "LocationOfSpecialInterest" |> NamespacedName

    /// <summary>
    /// Any Hockey team
    /// <see href="http://www.ontotext.com/proton/protonext#HockeyTeam"></see></summary>
    let HockeyTeam = Namespaced_IRI.parse _namespace_name "HockeyTeam" |> NamespacedName
    /// <summary>
    /// A Holiday is a day designated as having special significance for which individuals, a government, or a religious group have deemed that observance is warranted. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#Holiday"></see></summary>
    let Holiday = Namespaced_IRI.parse _namespace_name "Holiday" |> NamespacedName
    /// <summary>
    /// The web page address of a page that is considered main for a web cite.
    /// <see href="http://www.ontotext.com/proton/protonext#HomePage"></see></summary>
    let HomePage = Namespaced_IRI.parse _namespace_name "HomePage" |> NamespacedName
    /// <summary>
    /// The internet address of a web page on the net.
    /// <see href="http://www.ontotext.com/proton/protonext#WebPage"></see></summary>
    let WebPage = Namespaced_IRI.parse _namespace_name "WebPage" |> NamespacedName
    /// <summary>
    /// Any Hospital, a building which is a hospital.
    /// <see href="http://www.ontotext.com/proton/protonext#Hospital"></see></summary>
    let Hospital = Namespaced_IRI.parse _namespace_name "Hospital" |> NamespacedName
    /// <summary>
    /// A hotel is an establishment that provides paid lodging on a short-term basis. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#Hotel"></see></summary>
    let Hotel = Namespaced_IRI.parse _namespace_name "Hotel" |> NamespacedName
    /// <summary>
    /// Human is a mammal referred to Primate. Also of the sort of hommo sapiens. It has two subClasses: Man and Woman.
    /// <see href="http://www.ontotext.com/proton/protonext#Human"></see></summary>
    let Human = Namespaced_IRI.parse _namespace_name "Human" |> NamespacedName
    /// <summary>
    /// Mammals are members of a class of air-breathing vertebrate animals characterized by the possession of hair, three middle ear bones, and mammary glands functional in mothers with young. Most mammals also possess sweat glands and specialized teeth, and the largest group of mammals, the placentals, have a placenta which feeds the offspring during gestation. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Mammal"></see></summary>
    let Mammal = Namespaced_IRI.parse _namespace_name "Mammal" |> NamespacedName
    /// <summary>
    /// An Internet Protocol address (IP address) is a numerical label assigned to each device (e.g., computer, printer) participating in a computer network that uses the Internet Protocol for communication. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#IPAddress"></see></summary>
    let IPAddress = Namespaced_IRI.parse _namespace_name "IPAddress" |> NamespacedName
    /// <summary>
    /// The ISBN (International Standard Book Number) is a unique machine-readable identification number, which marks any book unmistakably.
    /// <see href="http://www.ontotext.com/proton/protonext#ISBN"></see></summary>
    let ISBN = Namespaced_IRI.parse _namespace_name "ISBN" |> NamespacedName
    /// <summary>
    /// The ISSN (International Standard Serial Number) is an eight-digit number which identifies periodical publications as such, including electronic serials. More than one million ISSN numbers have so far been assigned.
    /// <see href="http://www.ontotext.com/proton/protonext#ISSN"></see></summary>
    let ISSN = Namespaced_IRI.parse _namespace_name "ISSN" |> NamespacedName

    /// <summary>
    /// A periodical publication, disregarding its specific issues, numbers, volumes, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#PeriodicalPublication"></see></summary>
    let PeriodicalPublication =
        Namespaced_IRI.parse _namespace_name "PeriodicalPublication" |> NamespacedName

    /// <summary>
    /// Any Ice Hockey league
    /// <see href="http://www.ontotext.com/proton/protonext#IceHockeyLeague"></see></summary>
    let IceHockeyLeague =
        Namespaced_IRI.parse _namespace_name "IceHockeyLeague" |> NamespacedName

    /// <summary>
    /// The profession of ice hockey player
    /// <see href="http://www.ontotext.com/proton/protonext#IceHockeyPlayer"></see></summary>
    let IceHockeyPlayer =
        Namespaced_IRI.parse _namespace_name "IceHockeyPlayer" |> NamespacedName

    /// <summary>
    /// A dome-shaped mass of glacial ice covering an area of mountain summits or other high lands; smaller than an ice sheet
    /// <see href="http://www.ontotext.com/proton/protonext#Icecap"></see></summary>
    let Icecap = Namespaced_IRI.parse _namespace_name "Icecap" |> NamespacedName
    /// <summary>
    /// An ideology is a set of ideas that constitute one's goals, expectations, and actions. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#Ideology"></see></summary>
    let Ideology = Namespaced_IRI.parse _namespace_name "Ideology" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#ImageDocument"></see>
    /// </summary>
    let ImageDocument =
        Namespaced_IRI.parse _namespace_name "ImageDocument" |> NamespacedName

    /// <summary>
    /// A classification of companies that have similar production processes, similar products, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#IndustrySector"></see></summary>
    let IndustrySector =
        Namespaced_IRI.parse _namespace_name "IndustrySector" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#InformationSpace"></see>
    /// </summary>
    let InformationSpace =
        Namespaced_IRI.parse _namespace_name "InformationSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#InformationSpaceProfile"></see>
    /// </summary>
    let InformationSpaceProfile =
        Namespaced_IRI.parse _namespace_name "InformationSpaceProfile" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#Profile"></see>
    /// </summary>
    let Profile = Namespaced_IRI.parse _namespace_name "Profile" |> NamespacedName

    /// <summary>
    /// Any Inline Hockey league
    /// <see href="http://www.ontotext.com/proton/protonext#InlineHockeyLeague"></see></summary>
    let InlineHockeyLeague =
        Namespaced_IRI.parse _namespace_name "InlineHockeyLeague" |> NamespacedName

    /// <summary>
    /// Insects are a class within the arthropods that have a chitinous exoskeleton, a three-part body (head, thorax, and abdomen), three pairs of jointed legs, compound eyes, and two antennae. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Insect"></see></summary>
    let Insect = Namespaced_IRI.parse _namespace_name "Insect" |> NamespacedName
    /// <summary>
    /// A research organization devoted primarily on search in some scientific research.
    /// <see href="http://www.ontotext.com/proton/protonext#Institute"></see></summary>
    let Institute = Namespaced_IRI.parse _namespace_name "Institute" |> NamespacedName

    /// <summary>
    /// An organization performing scientific research.
    /// <see href="http://www.ontotext.com/proton/protonext#ResearchOrganization"></see></summary>
    let ResearchOrganization =
        Namespaced_IRI.parse _namespace_name "ResearchOrganization" |> NamespacedName

    /// <summary>
    /// A company providing insurance services agains different dangerous or risky events.
    /// <see href="http://www.ontotext.com/proton/protonext#InsuranceCompany"></see></summary>
    let InsuranceCompany =
        Namespaced_IRI.parse _namespace_name "InsuranceCompany" |> NamespacedName

    /// <summary>
    /// Legal international organization. Legal in this case means officially recognized by more than one government.
    /// <see href="http://www.ontotext.com/proton/protonext#InternationalOrganization"></see></summary>
    let InternationalOrganization =
        Namespaced_IRI.parse _namespace_name "InternationalOrganization" |> NamespacedName

    /// <summary>
    /// A domain name is an identification string that defines the area of administrative autonomy, authority, or control in the Internet. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#InternetDomain"></see></summary>
    let InternetDomain =
        Namespaced_IRI.parse _namespace_name "InternetDomain" |> NamespacedName

    /// <summary>
    /// A network of ditches and one or more of the following elements: water supply, reservoir, canal, pump, well, drain, etc. NIMA GNS designator H.SYSI.
    /// <see href="http://www.ontotext.com/proton/protonext#IrrigationSystem"></see></summary>
    let IrrigationSystem =
        Namespaced_IRI.parse _namespace_name "IrrigationSystem" |> NamespacedName

    /// <summary>
    /// A specific issue, number, and/or volume of periodical publication such as magazine.
    /// <see href="http://www.ontotext.com/proton/protonext#IssueOfPeriodical"></see></summary>
    let IssueOfPeriodical =
        Namespaced_IRI.parse _namespace_name "IssueOfPeriodical" |> NamespacedName

    /// <summary>
    /// (ADL FT) Narrow sections of land in a body of water connecting two larger land areas. NIMA GNS designator ISTH.
    /// <see href="http://www.ontotext.com/proton/protonext#Isthmus"></see></summary>
    let Isthmus = Namespaced_IRI.parse _namespace_name "Isthmus" |> NamespacedName
    /// <summary>
    /// Any journalist, a profession of collecting and disseminating information about current events, people, trends, and issues. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Journalist"></see></summary>
    let Journalist = Namespaced_IRI.parse _namespace_name "Journalist" |> NamespacedName
    /// <summary>
    /// Any judge, a profession of presiding over a court of law, either alone or as part of a panel of judges. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Judge"></see></summary>
    let Judge = Namespaced_IRI.parse _namespace_name "Judge" |> NamespacedName
    /// <summary>
    /// (ADL FT) Tropical regions of wild, tangled, dense vegetation. NIMA GNS designator - no equivalent.
    /// <see href="http://www.ontotext.com/proton/protonext#Jungle"></see></summary>
    let Jungle = Namespaced_IRI.parse _namespace_name "Jungle" |> NamespacedName

    /// <summary>
    /// Any Lacrosse league
    /// <see href="http://www.ontotext.com/proton/protonext#LacrosseLeague"></see></summary>
    let LacrosseLeague =
        Namespaced_IRI.parse _namespace_name "LacrosseLeague" |> NamespacedName

    /// <summary>
    /// A body of water cut off from the open sea by coral reefs or sand bars. http://www.eionet.europa.eu/gemet/concept/4589. NIMA GNS designator H.LGN, H.LGNS, H.LGNX.
    /// <see href="http://www.ontotext.com/proton/protonext#Lagoon"></see></summary>
    let Lagoon = Namespaced_IRI.parse _namespace_name "Lagoon" |> NamespacedName
    /// <summary>
    /// (ADL FT) Use 'reservoirs' for human engineered lakes. Natural inland bodies of standing water, generally of appreciable size, occupying a depression in the Earth's surface. [Adapted from Glossary of Geology, 4th ed.] We use this category for beaver ponds; for crater lakes; for dry lakes; for fish ponds; for fishponds; for inland seas; for intermittent lakes; for intermittent oxbow lakes; for intermittent ponds; for intermittent pools; for intermittent salt lakes; for intermittent salt ponds; for lagoons; for laguna; for lake beds; for lochs; for millponds; for oxbow lakes; for ponds; for pools (water bodies); for salt evaporation ponds; for salt lakes; for salt ponds; and for tarns. NIMA GNS designators LBED, LK, LKC, LKI, LKN, LKNI, LKO, LKOI, LKS, LKSB, LKSC, LKSI, LKSN, LKSNI, LKX
    /// <see href="http://www.ontotext.com/proton/protonext#Lake"></see></summary>
    let Lake = Namespaced_IRI.parse _namespace_name "Lake" |> NamespacedName
    /// <summary>
    /// A tract of land without homogeneous character or boundaries. NIMA GNS designator L.AREA.
    /// <see href="http://www.ontotext.com/proton/protonext#LandArea"></see></summary>
    let LandArea = Namespaced_IRI.parse _namespace_name "LandArea" |> NamespacedName

    /// <summary>
    /// (ADL FT) Areas from which rockets/missiles may be housed and projected, usually equipped with associated buildings and facilities. [USGS Circ 1048] We use this category for missile sites. NIMA GNS designator - no equivalent.
    /// <see href="http://www.ontotext.com/proton/protonext#LaunchFacility"></see></summary>
    let LaunchFacility =
        Namespaced_IRI.parse _namespace_name "LaunchFacility" |> NamespacedName

    /// <summary>
    /// A law firm is a business entity formed by one or more lawyers to engage in the practice of law. The primary service provided by a law firm is to advise clients (individuals or corporations) about their legal rights and responsibilities, and to represent their clients in civil or criminal cases, business transactions, and other matters in which legal advice and other assistance are sought. DBPedia
    /// <see href="http://www.ontotext.com/proton/protonext#LawFirm"></see></summary>
    let LawFirm = Namespaced_IRI.parse _namespace_name "LawFirm" |> NamespacedName
    /// <summary>
    /// Any lawyer, a profession of according to Black's Law Dictionary, is a person learned in the law; as an attorney, counsel or solicitor; a person who is practicing law. of judges. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Lawyer"></see></summary>
    let Lawyer = Namespaced_IRI.parse _namespace_name "Lawyer" |> NamespacedName
    /// <summary>
    /// Denotes concrete legal cases, such as Dennis v. United States, Francis v. Resweber, United_States v. Virginia, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#LegalCases"></see></summary>
    let LegalCases = Namespaced_IRI.parse _namespace_name "LegalCases" |> NamespacedName

    /// <summary>
    /// Various sorts of legislative documents, including consitutions, laws, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Legislation"></see></summary>
    let Legislation =
        Namespaced_IRI.parse _namespace_name "Legislation" |> NamespacedName

    /// <summary>
    /// A collection of books, journals, audio and video materials, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Library"></see></summary>
    let Library = Namespaced_IRI.parse _namespace_name "Library" |> NamespacedName

    /// <summary>
    /// A collection is an aggregation of information resources. The term collection means that the resource is described as a group; its parts may be separately described and navigated. (DCMI type Collection)
    /// <see href="http://www.ontotext.com/proton/protonext#ResourceCollection"></see></summary>
    let ResourceCollection =
        Namespaced_IRI.parse _namespace_name "ResourceCollection" |> NamespacedName

    /// <summary>
    /// A building in which library organization is housed.
    /// <see href="http://www.ontotext.com/proton/protonext#LibraryBuilding"></see></summary>
    let LibraryBuilding =
        Namespaced_IRI.parse _namespace_name "LibraryBuilding" |> NamespacedName

    /// <summary>
    /// An education organization teaching pupils from first grade to tenth/eleventh/twelfth grade. It could be a primary school, or a secondary school.
    /// <see href="http://www.ontotext.com/proton/protonext#LibraryOrganization"></see></summary>
    let LibraryOrganization =
        Namespaced_IRI.parse _namespace_name "LibraryOrganization" |> NamespacedName

    /// <summary>
    /// Any lieutenant, title in a military unit.
    /// <see href="http://www.ontotext.com/proton/protonext#Lieutenant"></see></summary>
    let Lieutenant = Namespaced_IRI.parse _namespace_name "Lieutenant" |> NamespacedName
    /// <summary>
    /// A tower, building, or other type of structure designed to emit light from a system of lamps and lenses and used as an aid to navigation for maritime pilots at sea or on inland waterways
    /// <see href="http://www.ontotext.com/proton/protonext#LightHouse"></see></summary>
    let LightHouse = Namespaced_IRI.parse _namespace_name "LightHouse" |> NamespacedName

    /// <summary>
    /// (ADL FT) We use this category for astronomical stations; for beacons; for bench marks; for boundaries; for boundary markers; for buoys; for control points; for geodectic stations; for geographic centers; for landmarks (reference locations); for light houses; for light stations; for lighthouses; for markers; for milestones; for plaques; for poles (sphere); for triangulation stations; and for walls. NIMNA GNS designators LTHSE, BP, TRIG.
    /// <see href="http://www.ontotext.com/proton/protonext#ReferenceLocation"></see></summary>
    let ReferenceLocation =
        Namespaced_IRI.parse _namespace_name "ReferenceLocation" |> NamespacedName

    /// <summary>
    /// A capital of a Province or smaller administrative region. NIMA GNS designator PPLA.
    /// <see href="http://www.ontotext.com/proton/protonext#LocalCapital"></see></summary>
    let LocalCapital =
        Namespaced_IRI.parse _namespace_name "LocalCapital" |> NamespacedName

    /// <summary>
    /// (ADL FT) Stretches of water in canals, streams, or docks, enclosed by gates at each end, and used in raising and lowering boats as they pass from one water level to another. NIMA GNS designator LOCK.
    /// <see href="http://www.ontotext.com/proton/protonext#Lock"></see></summary>
    let Lock = Namespaced_IRI.parse _namespace_name "Lock" |> NamespacedName
    /// <summary>
    /// Locomotive, a railway vehicle that provides the motive power for a train. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Locomotive"></see></summary>
    let Locomotive = Namespaced_IRI.parse _namespace_name "Locomotive" |> NamespacedName
    /// <summary>
    /// Lymph is a general concept gathering all lymph nodes of the body.
    /// <see href="http://www.ontotext.com/proton/protonext#LymphNode"></see></summary>
    let LymphNode = Namespaced_IRI.parse _namespace_name "LymphNode" |> NamespacedName

    /// <summary>
    /// A specific issue of a magazine, journal or digest.
    /// <see href="http://www.ontotext.com/proton/protonext#MagazineIssue"></see></summary>
    let MagazineIssue =
        Namespaced_IRI.parse _namespace_name "MagazineIssue" |> NamespacedName

    /// <summary>
    /// A male human.
    /// <see href="http://www.ontotext.com/proton/protonext#Man"></see></summary>
    let Man = Namespaced_IRI.parse _namespace_name "Man" |> NamespacedName
    /// <summary>
    /// Any manager, the title of a management position in an organization.
    /// <see href="http://www.ontotext.com/proton/protonext#Manager"></see></summary>
    let Manager = Namespaced_IRI.parse _namespace_name "Manager" |> NamespacedName
    /// <summary>
    /// In contrast to IndustrySector, the market is determined by the customers instead of the business or the manifacturers. The market can be defined in terms of types of goods/services, geographic region, price levels and typical customer behaviours. Corresponding to the third sense in WordNet 1.7.1 "the customers for a particular product or service".
    /// <see href="http://www.ontotext.com/proton/protonext#Market"></see></summary>
    let Market = Namespaced_IRI.parse _namespace_name "Market" |> NamespacedName
    /// <summary>
    /// An area of open ground overlaid with wet peaty soils; a wetland dominated by grass-like vegetation; a flat area, subject to periodic salt water inundation, dominated by grassy salt-tolerant plants; a salt flat or salt encrusted plain subject to periodic inundation from flooding or high tides
    /// <see href="http://www.ontotext.com/proton/protonext#Marsh"></see></summary>
    let Marsh = Namespaced_IRI.parse _namespace_name "Marsh" |> NamespacedName

    /// <summary>
    /// The profession of a martial artist
    /// <see href="http://www.ontotext.com/proton/protonext#MartialArtist"></see></summary>
    let MartialArtist =
        Namespaced_IRI.parse _namespace_name "MartialArtist" |> NamespacedName

    /// <summary>
    /// Any Mayor, a title of the head of a municipality.
    /// <see href="http://www.ontotext.com/proton/protonext#Mayor"></see></summary>
    let Mayor = Namespaced_IRI.parse _namespace_name "Mayor" |> NamespacedName
    /// <summary>
    /// A small, poorly drained area dominated by grassy vegetation
    /// <see href="http://www.ontotext.com/proton/protonext#Meadow"></see></summary>
    let Meadow = Namespaced_IRI.parse _namespace_name "Meadow" |> NamespacedName
    /// <summary>
    /// A brand of a media company.
    /// <see href="http://www.ontotext.com/proton/protonext#MediaBrand"></see></summary>
    let MediaBrand = Namespaced_IRI.parse _namespace_name "MediaBrand" |> NamespacedName

    /// <summary>
    /// A mass media product (for instance a newspaper) abstracted from its organizational and ownership aspects (i.e. from its publisher) and considered more as a social phenomenon, partly a brand.
    /// <see href="http://www.ontotext.com/proton/protonext#MediaProduct"></see></summary>
    let MediaProduct =
        Namespaced_IRI.parse _namespace_name "MediaProduct" |> NamespacedName

    /// <summary>
    /// A collection of articles or presentations published as a book.
    /// <see href="http://www.ontotext.com/proton/protonext#MeetingProceedings"></see></summary>
    let MeetingProceedings =
        Namespaced_IRI.parse _namespace_name "MeetingProceedings" |> NamespacedName

    /// <summary>
    /// Any member of parliament, a title of a member of parliament.
    /// <see href="http://www.ontotext.com/proton/protonext#MemberOfParliament"></see></summary>
    let MemberOfParliament =
        Namespaced_IRI.parse _namespace_name "MemberOfParliament" |> NamespacedName

    /// <summary>
    /// An area of a document that can be considered a mention of something.
    /// <see href="http://www.ontotext.com/proton/protonext#Mention"></see></summary>
    let Mention = Namespaced_IRI.parse _namespace_name "Mention" |> NamespacedName
    /// <summary>
    /// A written message, including various postings in newspapers or public sources, job position adverts, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Message"></see></summary>
    let Message = Namespaced_IRI.parse _namespace_name "Message" |> NamespacedName

    /// <summary>
    /// Any military command, the organization which has a commanding role in a military organization.
    /// <see href="http://www.ontotext.com/proton/protonext#MilitaryCommand"></see></summary>
    let MilitaryCommand =
        Namespaced_IRI.parse _namespace_name "MilitaryCommand" |> NamespacedName

    /// <summary>
    /// Any military unit, a smaller military organization.
    /// <see href="http://www.ontotext.com/proton/protonext#MilitaryUnit"></see></summary>
    let MilitaryUnit =
        Namespaced_IRI.parse _namespace_name "MilitaryUnit" |> NamespacedName

    /// <summary>
    /// An event of organized, armed, and often prolonged conflict carried on between states, nations, or other parties. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#MilitaryConflict"></see></summary>
    let MilitaryConflict =
        Namespaced_IRI.parse _namespace_name "MilitaryConflict" |> NamespacedName

    /// <summary>
    /// Any military organisation, the structuring of the armed forces of a state so as to offer military capability required by the national defence policy. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#MilitaryOrganization"></see></summary>
    let MilitaryOrganization =
        Namespaced_IRI.parse _namespace_name "MilitaryOrganization" |> NamespacedName

    /// <summary>
    /// Any occupation involving service in the military.
    /// <see href="http://www.ontotext.com/proton/protonext#MilitaryPerson"></see></summary>
    let MilitaryPerson =
        Namespaced_IRI.parse _namespace_name "MilitaryPerson" |> NamespacedName

    /// <summary>
    /// (ADL FT) Places or areas from which commercial minerals are or were removed by excavation from the Earth. [Adapted from USGS Feature Class Definitions &lt;http://mapping.usgs.gov/www/ti/GNIS/gnis_users_guide_appendixc.html&gt;] We use this category for adits (mine sites); for chrome mines; for coal mines; for collieries; for copper mines; for diatomite mines; for gold mines; for gravel pits; for iron mines; for lead mines; for mine entrances; for mine shafts; for mines; for mining areas; for mining camps; for nickel mines; for open pit mines; for placer mines; for quarries; for salt mines; for strip mines; and for tin mines. NIMA GNS designators MN, MNA, MNAU, MNC, MNCR, MNDT, MNCU, MNFE, MNN, MNNI, MNPB, MNPL. MNQ, MNSN.
    /// <see href="http://www.ontotext.com/proton/protonext#MineSite"></see></summary>
    let MineSite = Namespaced_IRI.parse _namespace_name "MineSite" |> NamespacedName
    /// <summary>
    /// (Department) A specific ministry or department, structural unit of the government of specific country with focus and authority on specific problems of the country.
    /// <see href="http://www.ontotext.com/proton/protonext#Ministry"></see></summary>
    let Ministry = Namespaced_IRI.parse _namespace_name "Ministry" |> NamespacedName

    /// <summary>
    /// Any Mixed Martial Arts league
    /// <see href="http://www.ontotext.com/proton/protonext#MixedMartialArtsLeague"></see></summary>
    let MixedMartialArtsLeague =
        Namespaced_IRI.parse _namespace_name "MixedMartialArtsLeague" |> NamespacedName

    /// <summary>
    /// Mollusca is a large phylum of invertebrate animals. This is the largest marine phylum, comprising about 23% of all the named marine organisms. Numerous molluscs also live in freshwater and terrestrial habitats. Molluscs are highly diverse, not only in size and in anatomical structure, but also in behaviour and in habitat. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Mollusca"></see></summary>
    let Mollusca = Namespaced_IRI.parse _namespace_name "Mollusca" |> NamespacedName
    /// <summary>
    /// Any Monarch, a title of a head of state in a monarchy.
    /// <see href="http://www.ontotext.com/proton/protonext#Monarch"></see></summary>
    let Monarch = Namespaced_IRI.parse _namespace_name "Monarch" |> NamespacedName
    /// <summary>
    /// A specific amount of money in specific currency
    /// <see href="http://www.ontotext.com/proton/protonext#Money"></see></summary>
    let Money = Namespaced_IRI.parse _namespace_name "Money" |> NamespacedName
    /// <summary>
    /// A specific month, like Dec 2000, as a time period.
    /// <see href="http://www.ontotext.com/proton/protonext#Month"></see></summary>
    let Month = Namespaced_IRI.parse _namespace_name "Month" |> NamespacedName
    /// <summary>
    /// (ADL FT) Structures erected as memorials. [Adapted from American Heritage Dic. of the English Language, 4th ed.] We use this category for cairns; for landmarks (monuments); for memorials; for national monuments; for pyramids; for shrines; for statues; and for tombs. NIMA GNS designators MNMT, PYR, PYRS, CARN.
    /// <see href="http://www.ontotext.com/proton/protonext#Monument"></see></summary>
    let Monument = Namespaced_IRI.parse _namespace_name "Monument" |> NamespacedName

    /// <summary>
    /// Any Motorcycle Racing league
    /// <see href="http://www.ontotext.com/proton/protonext#MotorcycleRacingLeague"></see></summary>
    let MotorcycleRacingLeague =
        Namespaced_IRI.parse _namespace_name "MotorcycleRacingLeague" |> NamespacedName

    /// <summary>
    /// (ADL FT) Landmasses that project conspicuously above their surroundings. [USGS Circ 1048] We use this category for cerros; for cordilleras; for foothills; for hills; for knolls; for mounds; and for mounts. Omitted ADL sub-classes: Continental divides. NIMA GNS designator MT, MTS, MTSU, MTU, MND, KNLU, KNSU, CDAU, HLL, HLLS, HLLU, HLSU.
    /// <see href="http://www.ontotext.com/proton/protonext#Mountain"></see></summary>
    let Mountain = Namespaced_IRI.parse _namespace_name "Mountain" |> NamespacedName

    /// <summary>
    /// Any mountain pass. NIMA GNS designators - no direct equivalents
    /// <see href="http://www.ontotext.com/proton/protonext#MountainPass"></see></summary>
    let MountainPass =
        Namespaced_IRI.parse _namespace_name "MountainPass" |> NamespacedName

    /// <summary>
    /// (ADL FT) (a) Chains of hills or mountains; (b) somewhat linear, complex mountainous or hilly areas. ... We use this category for ranges (physiographic); and for sierra. NIMA GNS designator RNGU.
    /// <see href="http://www.ontotext.com/proton/protonext#MountainRange"></see></summary>
    let MountainRange =
        Namespaced_IRI.parse _namespace_name "MountainRange" |> NamespacedName

    /// <summary>
    /// (ADL FT) Peaks of mountains. [USGS Circ 1048] We use this category for ahus; for mountain crests; for nunataks; for peaks; and for summits. NIMA GNS designators PK, PKS, PKSU, PKU.
    /// <see href="http://www.ontotext.com/proton/protonext#MountainSummit"></see></summary>
    let MountainSummit =
        Namespaced_IRI.parse _namespace_name "MountainSummit" |> NamespacedName

    /// <summary>
    /// A film, also called a movie or motion picture, is a series of still or moving images. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#Movie"></see></summary>
    let Movie = Namespaced_IRI.parse _namespace_name "Movie" |> NamespacedName
    /// <summary>
    /// A relatively level area of mud either between high and low tide lines, or subject to flooding; a large flat area of mud or sand attached to the shore and alternately covered and uncovered by the tide; a tropical tidal mud flat characterized by mangrove vegetation
    /// <see href="http://www.ontotext.com/proton/protonext#MudFlat"></see></summary>
    let MudFlat = Namespaced_IRI.parse _namespace_name "MudFlat" |> NamespacedName
    /// <summary>
    /// Any muscle of a body.
    /// <see href="http://www.ontotext.com/proton/protonext#Muscle"></see></summary>
    let Muscle = Namespaced_IRI.parse _namespace_name "Muscle" |> NamespacedName
    /// <summary>
    /// Any museum, an institution that houses and cares for a collection of artifacts and other objects of scientific, artistic, or historical importance and makes them available for public viewing through exhibits that may be permanent or temporary. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Museum"></see></summary>
    let Museum = Namespaced_IRI.parse _namespace_name "Museum" |> NamespacedName

    /// <summary>
    /// Any Musical company, a company involved in the music business, e.g. sells compositions, recordings and performances of music, like Soni Music Entertainment.
    /// <see href="http://www.ontotext.com/proton/protonext#MusicCompany"></see></summary>
    let MusicCompany =
        Namespaced_IRI.parse _namespace_name "MusicCompany" |> NamespacedName

    /// <summary>
    /// Any festival involving playing music.
    /// <see href="http://www.ontotext.com/proton/protonext#MusicFestival"></see></summary>
    let MusicFestival =
        Namespaced_IRI.parse _namespace_name "MusicFestival" |> NamespacedName

    /// <summary>
    /// Any genre which pertians to music, e.g. classical, folk, pop, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#MusicGenre"></see></summary>
    let MusicGenre = Namespaced_IRI.parse _namespace_name "MusicGenre" |> NamespacedName
    /// <summary>
    /// Musical is a form of theatre or movie combining music, songs, spoken dialogue and dance. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Musical"></see></summary>
    let Musical = Namespaced_IRI.parse _namespace_name "Musical" |> NamespacedName

    /// <summary>
    /// Musical Instrument, a device created or adapted for the purpose of making musical sounds. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#MusicalInstrument"></see></summary>
    let MusicalInstrument =
        Namespaced_IRI.parse _namespace_name "MusicalInstrument" |> NamespacedName

    /// <summary>
    /// Any musician, a profession of writing, performing, or making music. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Musician"></see></summary>
    let Musician = Namespaced_IRI.parse _namespace_name "Musician" |> NamespacedName
    /// <summary>
    /// A tidal strait. NIMA GNS designator H.NRWS.
    /// <see href="http://www.ontotext.com/proton/protonext#Narrows"></see></summary>
    let Narrows = Namespaced_IRI.parse _namespace_name "Narrows" |> NamespacedName

    /// <summary>
    /// The profession of nascar driver
    /// <see href="http://www.ontotext.com/proton/protonext#NascarDriver"></see></summary>
    let NascarDriver =
        Namespaced_IRI.parse _namespace_name "NascarDriver" |> NamespacedName

    /// <summary>
    /// The profession of national collegiate athletic association athlete
    /// <see href="http://www.ontotext.com/proton/protonext#NationalCollegiateAthleticAssociationAthlete"></see></summary>
    let NationalCollegiateAthleticAssociationAthlete =
        Namespaced_IRI.parse _namespace_name "NationalCollegiateAthleticAssociationAthlete" |> NamespacedName

    /// <summary>
    /// Any nationality. In most cases it is connected with a country name, but there are notionalities without countries - Kurd, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Nationality"></see></summary>
    let Nationality =
        Namespaced_IRI.parse _namespace_name "Nationality" |> NamespacedName

    /// <summary>
    /// Such as particular disease, the Gulfstream and other similar natural abstractions. The particular events or objects which could instantiate an abstract natural phenomena (i.e. specific sickness event caused by a disease) are not instances of this class.
    /// <see href="http://www.ontotext.com/proton/protonext#NaturalPhenomenon"></see></summary>
    let NaturalPhenomenon =
        Namespaced_IRI.parse _namespace_name "NaturalPhenomenon" |> NamespacedName

    /// <summary>
    /// A satellite which is not a direct result of human activity
    /// <see href="http://www.ontotext.com/proton/protonext#NaturalSatellite"></see></summary>
    let NaturalSatellite =
        Namespaced_IRI.parse _namespace_name "NaturalSatellite" |> NamespacedName

    /// <summary>
    /// Nerve is a general concept gathering all nerves of a body.
    /// <see href="http://www.ontotext.com/proton/protonext#Nerve"></see></summary>
    let Nerve = Namespaced_IRI.parse _namespace_name "Nerve" |> NamespacedName
    /// <summary>
    /// A news agency is an organization of journalists established to supply news reports to news organizations: newspapers, magazines, and radio and television broadcasters. Wikipedia
    /// <see href="http://www.ontotext.com/proton/protonext#NewsAgency"></see></summary>
    let NewsAgency = Namespaced_IRI.parse _namespace_name "NewsAgency" |> NamespacedName
    /// <summary>
    /// A newspaper abstracted from its organizational and ownership aspects as well as from a specific issue or paper body.
    /// <see href="http://www.ontotext.com/proton/protonext#Newspaper"></see></summary>
    let Newspaper = Namespaced_IRI.parse _namespace_name "Newspaper" |> NamespacedName

    /// <summary>
    /// A specific issue of a newspaper.
    /// <see href="http://www.ontotext.com/proton/protonext#NewspaperIssue"></see></summary>
    let NewspaperIssue =
        Namespaced_IRI.parse _namespace_name "NewspaperIssue" |> NamespacedName

    /// <summary>
    /// The situation of holding a position in society as nobelty.
    /// <see href="http://www.ontotext.com/proton/protonext#Nobelty"></see></summary>
    let Nobelty = Namespaced_IRI.parse _namespace_name "Nobelty" |> NamespacedName

    /// <summary>
    /// A type (specific receipe) for a beverage. For instance: Coca Cola, Schweppes, Apple Juice, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#NonAlcoholicBeverage"></see></summary>
    let NonAlcoholicBeverage =
        Namespaced_IRI.parse _namespace_name "NonAlcoholicBeverage" |> NamespacedName

    /// <summary>
    /// A non-geographic region in some 3D space. The Longitude and Latitude properties for such objects could be void.
    /// <see href="http://www.ontotext.com/proton/protonext#NonGeographicLocation"></see></summary>
    let NonGeographicLocation =
        Namespaced_IRI.parse _namespace_name "NonGeographicLocation" |> NamespacedName

    /// <summary>
    /// (ADL FT) Fertile, vegetated areas in the midst of a desert, where the water table has come close enough to the surface for wells and springs or seepages to exist, thus making them suitable for human habitation. NIMA GNS designator OAS.
    /// <see href="http://www.ontotext.com/proton/protonext#Oasis"></see></summary>
    let Oasis = Namespaced_IRI.parse _namespace_name "Oasis" |> NamespacedName
    /// <summary>
    /// (ADL FT) Continuous salt-water bodies that surround the continents and fill the Earth's great depressions. NIMA GNS designator OCN
    /// <see href="http://www.ontotext.com/proton/protonext#Ocean"></see></summary>
    let Ocean = Namespaced_IRI.parse _namespace_name "Ocean" |> NamespacedName
    /// <summary>
    /// (ADL FT) Large bodies of salt water. NIMA GNS designator SEA
    /// <see href="http://www.ontotext.com/proton/protonext#Sea"></see></summary>
    let Sea = Namespaced_IRI.parse _namespace_name "Sea" |> NamespacedName
    /// <summary>
    /// Something offered (as a proposal or bid), WordNet 1.7.1. An offer is a statement made by the offerer to a specific agent or without recepient.
    /// <see href="http://www.ontotext.com/proton/protonext#Offer"></see></summary>
    let Offer = Namespaced_IRI.parse _namespace_name "Offer" |> NamespacedName

    /// <summary>
    /// A meeting whose main participants are political entities playing official roles within it.
    /// <see href="http://www.ontotext.com/proton/protonext#OfficialPoliticalMeeting"></see></summary>
    let OfficialPoliticalMeeting =
        Namespaced_IRI.parse _namespace_name "OfficialPoliticalMeeting" |> NamespacedName

    /// <summary>
    /// A job position having a representative function with respect to an organization. Usually this is a position within a governmental organization.
    /// <see href="http://www.ontotext.com/proton/protonext#OfficialPosition"></see></summary>
    let OfficialPosition =
        Namespaced_IRI.parse _namespace_name "OfficialPosition" |> NamespacedName

    /// <summary>
    /// (ADL FT) Areas with reserves of recoverable petroleum or where petroleum has been removed from the Earth. ... We use this category for gas fields; for gasfields; for oilfields; for petroleum fields; and for storage fields (petroleum). NIMA GNS designator CMPO, OILF, OILQ, OILW, PMPO, GASF.
    /// <see href="http://www.ontotext.com/proton/protonext#OilField"></see></summary>
    let OilField = Namespaced_IRI.parse _namespace_name "OilField" |> NamespacedName

    /// <summary>
    /// The institution of Olympic Games held every 4 years
    /// <see href="http://www.ontotext.com/proton/protonext#OlympicGames"></see></summary>
    let OlympicGames =
        Namespaced_IRI.parse _namespace_name "OlympicGames" |> NamespacedName

    /// <summary>
    /// A specific issue of the games, like Athens 2004
    /// <see href="http://www.ontotext.com/proton/protonext#OlympicGamesOccurrence"></see></summary>
    let OlympicGamesOccurrence =
        Namespaced_IRI.parse _namespace_name "OlympicGamesOccurrence" |> NamespacedName

    /// <summary>
    /// An event involving use, maintain or improve of physical fitness of its participants. Usually it is organized.
    /// <see href="http://www.ontotext.com/proton/protonext#SportEvent"></see></summary>
    let SportEvent = Namespaced_IRI.parse _namespace_name "SportEvent" |> NamespacedName

    /// <summary>
    /// An art performance following an opera music and script.
    /// <see href="http://www.ontotext.com/proton/protonext#OperaPerformance"></see></summary>
    let OperaPerformance =
        Namespaced_IRI.parse _namespace_name "OperaPerformance" |> NamespacedName

    /// <summary>
    /// A planting of fruit or nut trees
    /// <see href="http://www.ontotext.com/proton/protonext#Orchard"></see></summary>
    let Orchard = Namespaced_IRI.parse _namespace_name "Orchard" |> NamespacedName
    /// <summary>
    /// A statement used to request someone to supply something in return for payment and providing specifications and quantities. WordNet 2.1.
    /// <see href="http://www.ontotext.com/proton/protonext#Order"></see></summary>
    let Order = Namespaced_IRI.parse _namespace_name "Order" |> NamespacedName
    /// <summary>
    /// The situation of holding a position in a society as out of law.
    /// <see href="http://www.ontotext.com/proton/protonext#OutOfLaws"></see></summary>
    let OutOfLaws = Namespaced_IRI.parse _namespace_name "OutOfLaws" |> NamespacedName

    /// <summary>
    /// Criminal, the social function of a person who has committed a crime and is out of the law.
    /// <see href="http://www.ontotext.com/proton/protonext#OutOfLawsTitle"></see></summary>
    let OutOfLawsTitle =
        Namespaced_IRI.parse _namespace_name "OutOfLawsTitle" |> NamespacedName

    /// <summary>
    /// An area of breaking waves caused by the meeting of currents or by waves moving against the current. NIMA GNS designator H.OVF.
    /// <see href="http://www.ontotext.com/proton/protonext#Overfalls"></see></summary>
    let Overfalls = Namespaced_IRI.parse _namespace_name "Overfalls" |> NamespacedName

    /// <summary>
    /// Any Paintball league
    /// <see href="http://www.ontotext.com/proton/protonext#PaintballLeague"></see></summary>
    let PaintballLeague =
        Namespaced_IRI.parse _namespace_name "PaintballLeague" |> NamespacedName

    /// <summary>
    /// Any painting, the results of a practice of applying paint, pigment, color or other medium[1] to a surface (support base). (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Painting"></see></summary>
    let Painting = Namespaced_IRI.parse _namespace_name "Painting" |> NamespacedName
    /// <summary>
    /// An artifact, namely a piece of art, usually, matterial object. Typical instances are paintings and sculptures. Corresponds to the Wordnet 1.7.1 synset "art, fine art - the products of human creativity; works of art collectively; "an art exhibition"@en ; "a fine collection of art")"
    /// <see href="http://www.ontotext.com/proton/protonext#PieceOfArt"></see></summary>
    let PieceOfArt = Namespaced_IRI.parse _namespace_name "PieceOfArt" |> NamespacedName
    /// <summary>
    /// A district of religious land. NIMA GNS designator A.PRSH.
    /// <see href="http://www.ontotext.com/proton/protonext#Parish"></see></summary>
    let Parish = Namespaced_IRI.parse _namespace_name "Parish" |> NamespacedName
    /// <summary>
    /// (ADL FT) Places or areas developed for public use or recreation. [USGS Circ 1048] We use this category for arboretums; for botanical gardens; for commemorative areas; for commons; for gardens; for marine parks; for national forests; for national parks; for national seashores; for park gates; for picnic areas; for playgrounds; for provincial parks; for public use areas; for recreation areas; for rest areas; for scenic areas; for state forests; for state parks; for urban parks; for village squares; for wilderness areas; for zoological gardens; and for zoos. Omitted sub-classes: Viewing locations. NIMA GNS designators PRK, PRKHQ, PRKGT
    /// <see href="http://www.ontotext.com/proton/protonext#Park"></see></summary>
    let Park = Namespaced_IRI.parse _namespace_name "Park" |> NamespacedName
    /// <summary>
    /// A legislative assembly representative at national or regional level. It can also be called Senate, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Parliament"></see></summary>
    let Parliament = Namespaced_IRI.parse _namespace_name "Parliament" |> NamespacedName

    /// <summary>
    /// Any organization which has a political functions.
    /// <see href="http://www.ontotext.com/proton/protonext#PoliticalEntity"></see></summary>
    let PoliticalEntity =
        Namespaced_IRI.parse _namespace_name "PoliticalEntity" |> NamespacedName

    /// <summary>
    /// A registered (or awaiting registration) patent for specific invention or design.
    /// <see href="http://www.ontotext.com/proton/protonext#Patent"></see></summary>
    let Patent = Namespaced_IRI.parse _namespace_name "Patent" |> NamespacedName
    /// <summary>
    /// A land region surrounded by water from most sides, but having land connect to bigger land region. NIMA GNS designator PEN, PENX.
    /// <see href="http://www.ontotext.com/proton/protonext#Peninsula"></see></summary>
    let Peninsula = Namespaced_IRI.parse _namespace_name "Peninsula" |> NamespacedName
    /// <summary>
    /// A specific percent value
    /// <see href="http://www.ontotext.com/proton/protonext#Percent"></see></summary>
    let Percent = Namespaced_IRI.parse _namespace_name "Percent" |> NamespacedName

    /// <summary>
    /// Buildings where cultural events are presented before an audience. We use this category for amphitheaters; for amphitheatres; for auditoriums; for bowls (performance); for coliseums; for concert halls; for opera houses; for playhouses; for recital halls; for stages (performance); for symphony halls; for theaters; and for theatres. NIMA GNS designator AMTH.
    /// <see href="http://www.ontotext.com/proton/protonext#PerformanceSite"></see></summary>
    let PerformanceSite =
        Namespaced_IRI.parse _namespace_name "PerformanceSite" |> NamespacedName

    /// <summary>
    /// An area underlain by an oil-rich structural basin. NIMA GNS designator L.BSNP.
    /// <see href="http://www.ontotext.com/proton/protonext#PetroleumBasin"></see></summary>
    let PetroleumBasin =
        Namespaced_IRI.parse _namespace_name "PetroleumBasin" |> NamespacedName

    /// <summary>
    /// Any philosopher, a profession of studying of general and fundamental problems, such as those connected with existence, knowledge, values, reason, mind, and language.
    /// <see href="http://www.ontotext.com/proton/protonext#Philosopher"></see></summary>
    let Philosopher =
        Namespaced_IRI.parse _namespace_name "Philosopher" |> NamespacedName

    /// <summary>
    /// (ADL FT) Tubular conduits of substantial length, with pumps, valves, and control devices, for conveying fluids, gases, or finely divided solids. [USGS Circ 1048] We use this category for compressor stations; for gas pipelines; for oil pipeline junctions; for oil pipeline terminals; for oil pipelines; for oil pumping stations; for pump houses; for pumphouses; for pumping stations; and for water pumping stations. NIMA GNS designators OILP, OILJ, TRMO, PMPO, PMPW.
    /// <see href="http://www.ontotext.com/proton/protonext#Pipeline"></see></summary>
    let Pipeline = Namespaced_IRI.parse _namespace_name "Pipeline" |> NamespacedName
    /// <summary>
    /// (ADL FT) Regions of general uniform slope, comparatively level and of considerable extent. [USGS Circ 1048] We use this category for interfluves; and for llanos. NIMA GNS designators PLN, PLNU, PLNX, INTF.
    /// <see href="http://www.ontotext.com/proton/protonext#Plain"></see></summary>
    let Plain = Namespaced_IRI.parse _namespace_name "Plain" |> NamespacedName
    /// <summary>
    /// Any of the celestial bodies (other than comets or satellites) that revolve around the sun in the solar system. Definition partly derived from WordNet 1.7
    /// <see href="http://www.ontotext.com/proton/protonext#Planet"></see></summary>
    let Planet = Namespaced_IRI.parse _namespace_name "Planet" |> NamespacedName
    /// <summary>
    /// (ADL FT) Comparatively flat areas of great extent and elevation; specif. extensive land regions considerably above the adjacent country or above sea level; commonly limited on at least one side by an abrupt descent, have flat or nearly smooth surfaces but are often dissected by deep valleys and surmounted by high hills or mountains, and have a large part of their total surface at or near the summit level. We use this category for table mountains; and for tablelands. The ADL type Mesas, collapsed here. NIMA GNS designators PLAT, PLTX, PLTU, MESA, MESU, TMSU, TMST.
    /// <see href="http://www.ontotext.com/proton/protonext#Plateau"></see></summary>
    let Plateau = Namespaced_IRI.parse _namespace_name "Plateau" |> NamespacedName
    /// <summary>
    /// A play is a form of literature written by a playwright, usually consisting of scripted dialogue between characters, intended for theatrical performance rather than just reading. DBPedia
    /// <see href="http://www.ontotext.com/proton/protonext#Play"></see></summary>
    let Play = Namespaced_IRI.parse _namespace_name "Play" |> NamespacedName

    /// <summary>
    /// The occupation of playboy playmate
    /// <see href="http://www.ontotext.com/proton/protonext#PlayboyPlaymate"></see></summary>
    let PlayboyPlaymate =
        Namespaced_IRI.parse _namespace_name "PlayboyPlaymate" |> NamespacedName

    /// <summary>
    /// The profession of a poker player
    /// <see href="http://www.ontotext.com/proton/protonext#PokerPlayer"></see></summary>
    let PokerPlayer =
        Namespaced_IRI.parse _namespace_name "PokerPlayer" |> NamespacedName

    /// <summary>
    /// A title of Polish kings.
    /// <see href="http://www.ontotext.com/proton/protonext#PolishKing"></see></summary>
    let PolishKing = Namespaced_IRI.parse _namespace_name "PolishKing" |> NamespacedName

    /// <summary>
    /// An organization to gain political power. Definition taken from WordNet 1.7
    /// <see href="http://www.ontotext.com/proton/protonext#PoliticalParty"></see></summary>
    let PoliticalParty =
        Namespaced_IRI.parse _namespace_name "PoliticalParty" |> NamespacedName

    /// <summary>
    /// Any Politician, a profession of participating in the political life of a given society.
    /// <see href="http://www.ontotext.com/proton/protonext#Politician"></see></summary>
    let Politician = Namespaced_IRI.parse _namespace_name "Politician" |> NamespacedName
    /// <summary>
    /// Any Polo league
    /// <see href="http://www.ontotext.com/proton/protonext#PoloLeague"></see></summary>
    let PoloLeague = Namespaced_IRI.parse _namespace_name "PoloLeague" |> NamespacedName
    /// <summary>
    /// A pond is a body of standing water, either natural or man-made, that is usually smaller than a lake. (Wikipedia). http://www.eionet.europa.eu/gemet/concept/6507. NIMA GNS designator H.PND, H.PNDI, H.PNDN, H.PNDNI, H.PNDS, H.PNDSF, H.PNDSI, H.PNDSN, H.MFGN.
    /// <see href="http://www.ontotext.com/proton/protonext#Pond"></see></summary>
    let Pond = Namespaced_IRI.parse _namespace_name "Pond" |> NamespacedName
    /// <summary>
    /// A small and comparatively still, deep part of a larger body of water. NIMA GNS designator H.POOL, H.POOLI.
    /// <see href="http://www.ontotext.com/proton/protonext#Pool"></see></summary>
    let Pool = Namespaced_IRI.parse _namespace_name "Pool" |> NamespacedName
    /// <summary>
    /// Any Pope. the head of the Roman-Catholic church.
    /// <see href="http://www.ontotext.com/proton/protonext#Pope"></see></summary>
    let Pope = Namespaced_IRI.parse _namespace_name "Pope" |> NamespacedName

    /// <summary>
    /// Part of a postal address denoting the name of a village, town, city, country, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#PopulatedPlaceName"></see></summary>
    let PopulatedPlaceName =
        Namespaced_IRI.parse _namespace_name "PopulatedPlaceName" |> NamespacedName

    /// <summary>
    /// The situation of a job position which is available in a particular organization, such as CEO, CTO, executive assistant, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#PositionOrganization"></see></summary>
    let PositionOrganization =
        Namespaced_IRI.parse _namespace_name "PositionOrganization" |> NamespacedName

    /// <summary>
    /// Any property, e.g. possessions, the situation of owning an object.
    /// <see href="http://www.ontotext.com/proton/protonext#Possession"></see></summary>
    let Possession = Namespaced_IRI.parse _namespace_name "Possession" |> NamespacedName

    /// <summary>
    /// An address of a geographical place - usually a building. A postal address consists, usually, of a country name, zip code, city/village name, street name and number, a person name.
    /// <see href="http://www.ontotext.com/proton/protonext#PostalAddress"></see></summary>
    let PostalAddress =
        Namespaced_IRI.parse _namespace_name "PostalAddress" |> NamespacedName

    /// <summary>
    /// Any power station
    /// <see href="http://www.ontotext.com/proton/protonext#PowerStation"></see></summary>
    let PowerStation =
        Namespaced_IRI.parse _namespace_name "PowerStation" |> NamespacedName

    /// <summary>
    /// Any president, a title of a president of a country or an organization.
    /// <see href="http://www.ontotext.com/proton/protonext#President"></see></summary>
    let President = Namespaced_IRI.parse _namespace_name "President" |> NamespacedName
    /// <summary>
    /// Any priest, a professsion of a person who is authorized to perform the sacred rites of a religion. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Priest"></see></summary>
    let Priest = Namespaced_IRI.parse _namespace_name "Priest" |> NamespacedName

    /// <summary>
    /// Any prime minister, a title Prime minister of a country.
    /// <see href="http://www.ontotext.com/proton/protonext#PrimeMinister"></see></summary>
    let PrimeMinister =
        Namespaced_IRI.parse _namespace_name "PrimeMinister" |> NamespacedName

    /// <summary>
    /// A formal language for encoding of computer programs.
    /// <see href="http://www.ontotext.com/proton/protonext#ProgrammingLanguage"></see></summary>
    let ProgrammingLanguage =
        Namespaced_IRI.parse _namespace_name "ProgrammingLanguage" |> NamespacedName

    /// <summary>
    /// A project is carefully planned event to achieve a particular aim. Based on Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#Project"></see></summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName

    /// <summary>
    /// Any Protected Area, an area which benefits of special attention and is with limited access or protected in other ways.
    /// <see href="http://www.ontotext.com/proton/protonext#ProtectedArea"></see></summary>
    let ProtectedArea =
        Namespaced_IRI.parse _namespace_name "ProtectedArea" |> NamespacedName

    /// <summary>
    /// Denotes any protein as a biological substance.
    /// <see href="http://www.ontotext.com/proton/protonext#Protein"></see></summary>
    let Protein = Namespaced_IRI.parse _namespace_name "Protein" |> NamespacedName
    /// <summary>
    /// (ADL FT: Countries, 1st Order Divisions) First-order divisions of a nation. [USGS Circ 1048] We use this category for cantons; for first-order administrative divisions; for provinces; for states; and for territories. NIMA GNS designator ADM1. Also corresponds to the FIPS 10-4 principal administrative division defined as "an administrative area directly subordinate to the pertinent governing authority " NIMA GNS designator ADM1.
    /// <see href="http://www.ontotext.com/proton/protonext#Province"></see></summary>
    let Province = Namespaced_IRI.parse _namespace_name "Province" |> NamespacedName

    /// <summary>
    /// Company which is publicly traded on a Stock Exchange.
    /// <see href="http://www.ontotext.com/proton/protonext#PublicCompany"></see></summary>
    let PublicCompany =
        Namespaced_IRI.parse _namespace_name "PublicCompany" |> NamespacedName

    /// <summary>
    /// An organization which main activity is mass publishing of information. Often, the publishers issue periodic and/or non-periodic documents on paper media. While on-line publishing is considered a typical activity for publishers, the streaming electronic media such as TV and Radio Stations are not.
    /// <see href="http://www.ontotext.com/proton/protonext#PublishingCompany"></see></summary>
    let PublishingCompany =
        Namespaced_IRI.parse _namespace_name "PublishingCompany" |> NamespacedName

    /// <summary>
    /// A specific quarter of a specific year, such as Q4 1999
    /// <see href="http://www.ontotext.com/proton/protonext#Quarter"></see></summary>
    let Quarter = Namespaced_IRI.parse _namespace_name "Quarter" |> NamespacedName
    /// <summary>
    /// A racecourse is a horse racing track.
    /// <see href="http://www.ontotext.com/proton/protonext#RaceCourse"></see></summary>
    let RaceCourse = Namespaced_IRI.parse _namespace_name "RaceCourse" |> NamespacedName

    /// <summary>
    /// (ADL FT) Fields, centers, or open areas maintained for the purpose of holding sporting events and activities. [USGS Circ 1048] We use this category for aquatic centers; for arenas; for athletic complexes; for athletic fields; for ball parks; for baseball fields; for dragways; for equestrian centers; for fields; for football fields; for golf clubs; for golf courses; for gymnasiums; for natatoriums; for physical education facilities; for pistol ranges (sport); for polo fields; for pools, swimming; for race tracks; for racecourses; for racetracks; for raceways; for rifle ranges; for rodeo grounds; for shooting ranges (sport); for skeet shooting ranges; for ski areas; for ski facilities; for ski trails; for speedways; for stadiums; for swim clubs; for swimming pools; for tennis clubs; and for tennis courts. NIMA GNS designators RECG, RECR, STDM, ATHF.
    /// <see href="http://www.ontotext.com/proton/protonext#SportFacility"></see></summary>
    let SportFacility =
        Namespaced_IRI.parse _namespace_name "SportFacility" |> NamespacedName

    /// <summary>
    /// A company that broadcasts audio content.
    /// <see href="http://www.ontotext.com/proton/protonext#RadioCompany"></see></summary>
    let RadioCompany =
        Namespaced_IRI.parse _namespace_name "RadioCompany" |> NamespacedName

    /// <summary>
    /// Any Radio Controlled Racing league
    /// <see href="http://www.ontotext.com/proton/protonext#RadioControlledRacingLeague"></see></summary>
    let RadioControlledRacingLeague =
        Namespaced_IRI.parse _namespace_name "RadioControlledRacingLeague" |> NamespacedName

    /// <summary>
    /// A brand of a radio station.
    /// <see href="http://www.ontotext.com/proton/protonext#RadioStation"></see></summary>
    let RadioStation =
        Namespaced_IRI.parse _namespace_name "RadioStation" |> NamespacedName

    /// <summary>
    /// (ADL FT: Railroad Features) We use this category for metro rail stations; for railroad junctions; for railroad sidings; for railroad spurs; for railroad stations; for railroad stops; for railroad switches; for railroad yards; for railways; for subway stations; for switches (railroad); and for tramways. NIMA GNS designator RJCT, RR, RRQ, RSD, RSGNL, RSTN, RSTNQ, RSTP, RSTPQ, RYD.
    /// <see href="http://www.ontotext.com/proton/protonext#RailroadFacility"></see></summary>
    let RailroadFacility =
        Namespaced_IRI.parse _namespace_name "RailroadFacility" |> NamespacedName

    /// <summary>
    /// A tunnel for trains. NIMA GNS designator RTNL.
    /// <see href="http://www.ontotext.com/proton/protonext#RailroadTunnel"></see></summary>
    let RailroadTunnel =
        Namespaced_IRI.parse _namespace_name "RailroadTunnel" |> NamespacedName

    /// <summary>
    /// (ADL FT) Underground or underwater passages. [USGS Circ 1048] We use this category for canal tunnels; for railroad tunnels; and for road tunnels. NIMA GNS designator TNL, TNLC, TNLN, TNLRD, TNLS
    /// <see href="http://www.ontotext.com/proton/protonext#Tunnel"></see></summary>
    let Tunnel = Namespaced_IRI.parse _namespace_name "Tunnel" |> NamespacedName
    /// <summary>
    /// A gentle slope connecting areas of different elevations
    /// <see href="http://www.ontotext.com/proton/protonext#Ramp"></see></summary>
    let Ramp = Namespaced_IRI.parse _namespace_name "Ramp" |> NamespacedName
    /// <summary>
    /// A turbulent section of a stream associated with a steep, irregular stream bed. NIMA GNS designator H.RPDS.
    /// <see href="http://www.ontotext.com/proton/protonext#Rapids"></see></summary>
    let Rapids = Namespaced_IRI.parse _namespace_name "Rapids" |> NamespacedName
    /// <summary>
    /// (ADL FT) Chains of rocks or coral at or near the surface of water. [USGS Circ 1048] We use this category for barrier reefs; and for fringing reefs. Collapsed ADL sub-class: Coral Reefs. NIMA GNS designator RF, RFSU, RFU, RFC, H.RFX.
    /// <see href="http://www.ontotext.com/proton/protonext#Reef"></see></summary>
    let Reef = Namespaced_IRI.parse _namespace_name "Reef" |> NamespacedName
    /// <summary>
    /// A referee is the person of authority, in a variety of sports, who is responsible for presiding over the game from a neutral point of view. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Referee"></see></summary>
    let Referee = Namespaced_IRI.parse _namespace_name "Referee" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#RegionMention"></see>
    /// </summary>
    let RegionMention =
        Namespaced_IRI.parse _namespace_name "RegionMention" |> NamespacedName

    /// <summary>
    /// Things like Monastery, Church
    /// <see href="http://www.ontotext.com/proton/protonext#ReligiousLocation"></see></summary>
    let ReligiousLocation =
        Namespaced_IRI.parse _namespace_name "ReligiousLocation" |> NamespacedName

    /// <summary>
    /// Organization which offers ideas and opinions about life. Just joking.
    /// <see href="http://www.ontotext.com/proton/protonext#ReligiousOrganization"></see></summary>
    let ReligiousOrganization =
        Namespaced_IRI.parse _namespace_name "ReligiousOrganization" |> NamespacedName

    /// <summary>
    /// A document describing the result of some event.
    /// <see href="http://www.ontotext.com/proton/protonext#Report"></see></summary>
    let Report = Namespaced_IRI.parse _namespace_name "Report" |> NamespacedName
    /// <summary>
    /// Reptiles are animals in the class Reptilia. They are characterized by breathing air, laying shelled eggs, and having skin covered in scales and/or scutes. Reptiles are classically viewed as having a "cold-blooded" metabolism. They are tetrapods. Modern reptiles inhabit every continent with the exception of Antarctica. Example of an reptile is the crocodile. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Reptile"></see></summary>
    let Reptile = Namespaced_IRI.parse _namespace_name "Reptile" |> NamespacedName

    /// <summary>
    /// Specific research area, topic or field.
    /// <see href="http://www.ontotext.com/proton/protonext#ResearchArea"></see></summary>
    let ResearchArea =
        Namespaced_IRI.parse _namespace_name "ResearchArea" |> NamespacedName

    /// <summary>
    /// (ADL FT) Areas set aside for the preservation of fauna, flora, and their natural habitats. [Macmillan Encyc., 2001] We use this category for agricultural reserves; for conservation areas; for demonstration areas; for environmental areas; for forest reserves; for game management areas; for hunting reserves; for management areas (reserves); for natural areas; for nature reserves; for palm tree reserves; for preserves; for primitive areas; for protected areas; for reservations (nature sites); for road less areas; for sanctuaries (wildlife); for wildlife areas; for wildlife refuges; and for wildlife reserves. NIMA GNS designators RES, RESA, RESF, RESH, RESN, RESP, RESV, RESW.
    /// <see href="http://www.ontotext.com/proton/protonext#Reserve"></see></summary>
    let Reserve = Namespaced_IRI.parse _namespace_name "Reserve" |> NamespacedName
    /// <summary>
    /// (ADL FT) Artificially impounded bodies of water. We use this category for covered reservoirs; and for intermittent reservoirs. (incl. dams) NIMA GNS designator RSV, RSVI.
    /// <see href="http://www.ontotext.com/proton/protonext#Reservoir"></see></summary>
    let Reservoir = Namespaced_IRI.parse _namespace_name "Reservoir" |> NamespacedName
    /// <summary>
    /// Any restaurant, a place where food, drink and dessert to customers is prepared and served in return for money. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Restaurant"></see></summary>
    let Restaurant = Namespaced_IRI.parse _namespace_name "Restaurant" |> NamespacedName
    /// <summary>
    /// (ADL FT) Elevations with a narrow, elongated crest which can be part of a hill or mountain. ... We use this category for aretes; for beach ridges; for cuestas; for eskers; for hogbacks; for icecap ridges; for rises (seafloor); and for spurs (physiographic). Omitted ADL sub-classes: Drumlin. NIMA GNS designators RDGB, RDGE, RDGG, RDGU, RISU, SPRU, SPUR.
    /// <see href="http://www.ontotext.com/proton/protonext#Ridge"></see></summary>
    let Ridge = Namespaced_IRI.parse _namespace_name "Ridge" |> NamespacedName
    /// <summary>
    /// (ADL FT) Natural freshwater surface streams of considerable volume and a permanent or seasonal flow, moving in a definite channel toward a sea, lake, or another river; any large streams, or ones larger than brooks or creeks, such as the trunk stream and larger branches of a drainage system. We use this category for rios. NIM GNS designators ... no direct equivalents!
    /// <see href="http://www.ontotext.com/proton/protonext#River"></see></summary>
    let River = Namespaced_IRI.parse _namespace_name "River" |> NamespacedName
    /// <summary>
    /// (ADL FT) Linear bodies of water flowing on the Earth's surface. We use this category for anabranches; for brooks; for burns (hydrographic); for confluences; for creeks; for distributaries; for dry stream beds; for forks (physiographic features); for intermittent streams; for lost rivers; for meanders; for stream bends; for stream mouths; for tidal creeks; for tributaries; and for watercourses. NIMA GNS designators STM, STMA, STMB, STMC, STMD, STMH, STMI, STMIX, STMM, STMQ, STMS, STMSB, STMX
    /// <see href="http://www.ontotext.com/proton/protonext#Stream"></see></summary>
    let Stream = Namespaced_IRI.parse _namespace_name "Stream" |> NamespacedName

    /// <summary>
    /// A new channel cut by a river across the neck of an oxbow. NIMA GNS designator H.CUTF.
    /// <see href="http://www.ontotext.com/proton/protonext#RiverCutoff"></see></summary>
    let RiverCutoff =
        Namespaced_IRI.parse _namespace_name "RiverCutoff" |> NamespacedName

    /// <summary>
    /// (ADL FT) Open ways for passage of vehicles. [USGS Circ 1048] We use this category for caravan routes; for causeways; for drives; for highways; for intersections; for parkways; for road bends; for road cuts; for road junctions; for roads; for streets; and for traffic circles. NIMA GNS designators CSWY, CSWYQ, RD, RDA, RDB, RDCUT, RDJCT, RDST, RTE, STKR.
    /// <see href="http://www.ontotext.com/proton/protonext#Roadway"></see></summary>
    let Roadway = Namespaced_IRI.parse _namespace_name "Roadway" |> NamespacedName
    /// <summary>
    /// A rugby team
    /// A sport club that organizes the playing of rugby.
    /// <see href="http://www.ontotext.com/proton/protonext#RugbyClub"></see></summary>
    let RugbyClub = Namespaced_IRI.parse _namespace_name "RugbyClub" |> NamespacedName
    /// <summary>
    /// A sports club, football club or F1 team. Those should be considered commercial although in many cases they are not run for profit.
    /// An organization arranging the practice of some sports by teams or individuals.
    /// <see href="http://www.ontotext.com/proton/protonext#SportClub"></see></summary>
    let SportClub = Namespaced_IRI.parse _namespace_name "SportClub" |> NamespacedName

    /// <summary>
    /// Any Rugby League
    /// <see href="http://www.ontotext.com/proton/protonext#RugbyLeague"></see></summary>
    let RugbyLeague =
        Namespaced_IRI.parse _namespace_name "RugbyLeague" |> NamespacedName

    /// <summary>
    /// The profession of rugby player
    /// <see href="http://www.ontotext.com/proton/protonext#RugbyPlayer"></see></summary>
    let RugbyPlayer =
        Namespaced_IRI.parse _namespace_name "RugbyPlayer" |> NamespacedName

    /// <summary>
    /// A low part, resembling in shape a saddle, in a ridge or between contiguous seamounts
    /// <see href="http://www.ontotext.com/proton/protonext#Saddleback"></see></summary>
    let Saddleback = Namespaced_IRI.parse _namespace_name "Saddleback" |> NamespacedName
    /// <summary>
    /// Any saint, a holy person, in whom Christ dwells, whether in heaven or in earth.
    /// <see href="http://www.ontotext.com/proton/protonext#Saint"></see></summary>
    let Saint = Namespaced_IRI.parse _namespace_name "Saint" |> NamespacedName
    /// <summary>
    /// Any event in which a participant is receiving a good from another participant of the event on the basis of some payment.
    /// <see href="http://www.ontotext.com/proton/protonext#Sale"></see></summary>
    let Sale = Namespaced_IRI.parse _namespace_name "Sale" |> NamespacedName
    /// <summary>
    /// An education organization teaching pupils from first grade to tenth/eleventh/twelfth grade. It could be a primary school, or a secondary school.
    /// <see href="http://www.ontotext.com/proton/protonext#School"></see></summary>
    let School = Namespaced_IRI.parse _namespace_name "School" |> NamespacedName
    /// <summary>
    /// A well established, big research area
    /// <see href="http://www.ontotext.com/proton/protonext#Science"></see></summary>
    let Science = Namespaced_IRI.parse _namespace_name "Science" |> NamespacedName
    /// <summary>
    /// Any scientist, a profession of studying and making research on a particualr subject.
    /// <see href="http://www.ontotext.com/proton/protonext#Scientist"></see></summary>
    let Scientist = Namespaced_IRI.parse _namespace_name "Scientist" |> NamespacedName
    /// <summary>
    /// An area of low trees, bushes, and shrubs stunted by some environmental limitation
    /// <see href="http://www.ontotext.com/proton/protonext#Scrubland"></see></summary>
    let Scrubland = Namespaced_IRI.parse _namespace_name "Scrubland" |> NamespacedName
    /// <summary>
    /// Any sculpture, three-dimensional artwork created by shaping or combining hard materials. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Sculpture"></see></summary>
    let Sculpture = Namespaced_IRI.parse _namespace_name "Sculpture" |> NamespacedName
    /// <summary>
    /// A long arm of the sea forming a channel between the mainland and an island or islands; or connecting two larger bodies of water. NIMA GNS designator H.SD.
    /// <see href="http://www.ontotext.com/proton/protonext#SeaSound"></see></summary>
    let SeaSound = Namespaced_IRI.parse _namespace_name "SeaSound" |> NamespacedName
    /// <summary>
    /// An elongate (tongue-like) extension of a flat sea floor into an adjacent higher feature
    /// <see href="http://www.ontotext.com/proton/protonext#SeaTongue"></see></summary>
    let SeaTongue = Namespaced_IRI.parse _namespace_name "SeaTongue" |> NamespacedName
    /// <summary>
    /// A long, narrow, characteristically very deep and asymmetrical depression of the sea floor, with relatively steep sides
    /// <see href="http://www.ontotext.com/proton/protonext#SeaTrench"></see></summary>
    let SeaTrench = Namespaced_IRI.parse _namespace_name "SeaTrench" |> NamespacedName
    /// <summary>
    /// A long depression of the sea floor characteristically flat bottomed and steep sided, and normally shallower than a trench
    /// <see href="http://www.ontotext.com/proton/protonext#SeaTrough"></see></summary>
    let SeaTrough = Namespaced_IRI.parse _namespace_name "SeaTrough" |> NamespacedName

    /// <summary>
    /// Continuously sloping, elongated depressions commonly found in fans or plains and customarily bordered by levees on one or two sides (U.SCSU; U.SCSU)
    /// <see href="http://www.ontotext.com/proton/protonext#Seachannels"></see></summary>
    let Seachannels =
        Namespaced_IRI.parse _namespace_name "Seachannels" |> NamespacedName

    /// <summary>
    /// An elevation rising generally more than 1,000 meters and of limited extent across the summit. (U.SMSU; U.SMU)
    /// <see href="http://www.ontotext.com/proton/protonext#Seamount"></see></summary>
    let Seamount = Namespaced_IRI.parse _namespace_name "Seamount" |> NamespacedName
    /// <summary>
    /// One of the seasons of the year. In the places with a temperate climate there are four seasons: spring, summer, autumn, and winter.
    /// <see href="http://www.ontotext.com/proton/protonext#Season"></see></summary>
    let Season = Namespaced_IRI.parse _namespace_name "Season" |> NamespacedName
    /// <summary>
    /// An area of a document that can be considered a document in itself. Compare with pext:Mention, which is also an area of a document. Imported from the iSIM ontology.
    /// <see href="http://www.ontotext.com/proton/protonext#Section"></see></summary>
    let Section = Namespaced_IRI.parse _namespace_name "Section" |> NamespacedName
    /// <summary>
    /// Any Senator, a title of the member of the senat.
    /// <see href="http://www.ontotext.com/proton/protonext#Senator"></see></summary>
    let Senator = Namespaced_IRI.parse _namespace_name "Senator" |> NamespacedName
    /// <summary>
    /// A vehicle which moves on water.
    /// <see href="http://www.ontotext.com/proton/protonext#Ship"></see></summary>
    let Ship = Namespaced_IRI.parse _namespace_name "Ship" |> NamespacedName
    /// <summary>
    /// Hazards to surface navigation composed of unconsolidated material. (U.SHSU; U.SHLU)
    /// <see href="http://www.ontotext.com/proton/protonext#Shoal"></see></summary>
    let Shoal = Namespaced_IRI.parse _namespace_name "Shoal" |> NamespacedName

    /// <summary>
    /// Any Shopping Mall, a building which is a shopping mall
    /// <see href="http://www.ontotext.com/proton/protonext#ShoppingMall"></see></summary>
    let ShoppingMall =
        Namespaced_IRI.parse _namespace_name "ShoppingMall" |> NamespacedName

    /// <summary>
    /// A representative for a musician album.
    /// Any Single Album
    /// <see href="http://www.ontotext.com/proton/protonext#SingleAlbum"></see></summary>
    let SingleAlbum =
        Namespaced_IRI.parse _namespace_name "SingleAlbum" |> NamespacedName

    /// <summary>
    /// Any Single Song and Album
    /// <see href="http://www.ontotext.com/proton/protonext#SingleSongOrAlbum"></see></summary>
    let SingleSongOrAlbum =
        Namespaced_IRI.parse _namespace_name "SingleSongOrAlbum" |> NamespacedName

    /// <summary>
    /// A representative for an album or a musician song.
    /// <see href="http://www.ontotext.com/proton/protonext#SingleSong"></see></summary>
    let SingleSong = Namespaced_IRI.parse _namespace_name "SingleSong" |> NamespacedName
    /// <summary>
    /// An recording of a song.
    /// <see href="http://www.ontotext.com/proton/protonext#Song"></see></summary>
    let Song = Namespaced_IRI.parse _namespace_name "Song" |> NamespacedName

    /// <summary>
    /// Any sites of special scientific interest, a place with scientific value, where some scientific activities or experiments are carried out, or which is observed for scientific reasons.
    /// <see href="http://www.ontotext.com/proton/protonext#SiteOfSpecialScientificInterest"></see></summary>
    let SiteOfSpecialScientificInterest =
        Namespaced_IRI.parse _namespace_name "SiteOfSpecialScientificInterest" |> NamespacedName

    /// <summary>
    /// Any Ski Area, a mounatain area (usually) where there re ski resorts or one can ski.
    /// <see href="http://www.ontotext.com/proton/protonext#SkiArea"></see></summary>
    let SkiArea = Namespaced_IRI.parse _namespace_name "SkiArea" |> NamespacedName
    /// <summary>
    /// Any Skyscraper, a highrise building, usually in downtown city areas.
    /// <see href="http://www.ontotext.com/proton/protonext#Skyscraper"></see></summary>
    let Skyscraper = Namespaced_IRI.parse _namespace_name "Skyscraper" |> NamespacedName

    /// <summary>
    /// A profession of a sportsman that plays snooker, which is a billiard derivate. From DBPedia
    /// <see href="http://www.ontotext.com/proton/protonext#SnookerPlayer"></see></summary>
    let SnookerPlayer =
        Namespaced_IRI.parse _namespace_name "SnookerPlayer" |> NamespacedName

    /// <summary>
    /// A soccer (football) team
    /// A sport club that organizes the playing of soccer.
    /// <see href="http://www.ontotext.com/proton/protonext#SoccerClub"></see></summary>
    let SoccerClub = Namespaced_IRI.parse _namespace_name "SoccerClub" |> NamespacedName

    /// <summary>
    /// Any Soccer league
    /// <see href="http://www.ontotext.com/proton/protonext#SoccerLeague"></see></summary>
    let SoccerLeague =
        Namespaced_IRI.parse _namespace_name "SoccerLeague" |> NamespacedName

    /// <summary>
    /// Any soccer manager, the title of a manager of a soccer team.
    /// <see href="http://www.ontotext.com/proton/protonext#SoccerManager"></see></summary>
    let SoccerManager =
        Namespaced_IRI.parse _namespace_name "SoccerManager" |> NamespacedName

    /// <summary>
    /// The profession of soccer player
    /// <see href="http://www.ontotext.com/proton/protonext#SoccerPlayer"></see></summary>
    let SoccerPlayer =
        Namespaced_IRI.parse _namespace_name "SoccerPlayer" |> NamespacedName

    /// <summary>
    /// Any Softball league
    /// <see href="http://www.ontotext.com/proton/protonext#SoftballLeague"></see></summary>
    let SoftballLeague =
        Namespaced_IRI.parse _namespace_name "SoftballLeague" |> NamespacedName

    /// <summary>
    /// Software is a collection of computer programs and related data that provide the instructions telling a computer what to do. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Software"></see></summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName

    /// <summary>
    /// An artificial agent which operates in a software environment.
    /// <see href="http://www.ontotext.com/proton/protonext#SoftwareAgent"></see></summary>
    let SoftwareAgent =
        Namespaced_IRI.parse _namespace_name "SoftwareAgent" |> NamespacedName

    /// <summary>
    /// Any Mission in space in which space shuttles or space crafts are involved.
    /// <see href="http://www.ontotext.com/proton/protonext#SpaceMission"></see></summary>
    let SpaceMission =
        Namespaced_IRI.parse _namespace_name "SpaceMission" |> NamespacedName

    /// <summary>
    /// A Spaceshuttle is a reusable launch system and orbital spacecraft operated by the U.S. National Aeronautics and Space Administration (NASA) (Wikipedia).
    /// <see href="http://www.ontotext.com/proton/protonext#SpaceShuttle"></see></summary>
    let SpaceShuttle =
        Namespaced_IRI.parse _namespace_name "SpaceShuttle" |> NamespacedName

    /// <summary>
    /// [WN1.7] Space vehicle - a craft capable of traveling in outer space; technically a satellite around the sun.
    /// <see href="http://www.ontotext.com/proton/protonext#Spacecraft"></see></summary>
    let Spacecraft = Namespaced_IRI.parse _namespace_name "Spacecraft" |> NamespacedName

    /// <summary>
    /// Any Spacestation. A space station (also called an orbital station) is a manned satellite designed to remain in space. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#SpaceStation"></see></summary>
    let SpaceStation =
        Namespaced_IRI.parse _namespace_name "SpaceStation" |> NamespacedName

    /// <summary>
    /// Any Speedway league
    /// <see href="http://www.ontotext.com/proton/protonext#SpeedwayLeague"></see></summary>
    let SpeedwayLeague =
        Namespaced_IRI.parse _namespace_name "SpeedwayLeague" |> NamespacedName

    /// <summary>
    /// Any speedway team
    /// <see href="http://www.ontotext.com/proton/protonext#SpeedwayTeam"></see></summary>
    let SpeedwayTeam =
        Namespaced_IRI.parse _namespace_name "SpeedwayTeam" |> NamespacedName

    /// <summary>
    /// A specific type of sport game
    /// <see href="http://www.ontotext.com/proton/protonext#Sport"></see></summary>
    let Sport = Namespaced_IRI.parse _namespace_name "Sport" |> NamespacedName

    /// <summary>
    /// A building providing facilities for practice of sport(s).
    /// <see href="http://www.ontotext.com/proton/protonext#SportBuilding"></see></summary>
    let SportBuilding =
        Namespaced_IRI.parse _namespace_name "SportBuilding" |> NamespacedName

    /// <summary>
    /// An organization (local, national or international) which main activity is related to one or more sports. Those could be clubs, as well, as all the sorts of federations.
    /// <see href="http://www.ontotext.com/proton/protonext#SportOrganization"></see></summary>
    let SportOrganization =
        Namespaced_IRI.parse _namespace_name "SportOrganization" |> NamespacedName

    /// <summary>
    /// Denotes a point scored in a given sport game.
    /// <see href="http://www.ontotext.com/proton/protonext#SportGamePoint"></see></summary>
    let SportGamePoint =
        Namespaced_IRI.parse _namespace_name "SportGamePoint" |> NamespacedName

    /// <summary>
    /// An organization representing which controls the practice of some sport on national, regional or international level.
    /// <see href="http://www.ontotext.com/proton/protonext#SportsFederation"></see></summary>
    let SportsFederation =
        Namespaced_IRI.parse _namespace_name "SportsFederation" |> NamespacedName

    /// <summary>
    /// A special sort of sport building, usually for open-air sports such as soccer.
    /// <see href="http://www.ontotext.com/proton/protonext#Stadium"></see></summary>
    let Stadium = Namespaced_IRI.parse _namespace_name "Stadium" |> NamespacedName
    /// <summary>
    /// An astronomic object of hot gases that radiates energy derived from thermonuclear reactions in the interior. Definition partly derived from WordNet 1.7
    /// <see href="http://www.ontotext.com/proton/protonext#Star"></see></summary>
    let Star = Namespaced_IRI.parse _namespace_name "Star" |> NamespacedName
    /// <summary>
    /// Any station, a place where busses, trains, sheeps, boats, etc. stop, like railway station, bussstop, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Station"></see></summary>
    let Station = Namespaced_IRI.parse _namespace_name "Station" |> NamespacedName

    /// <summary>
    /// Stock Exchange where public companies are traded, e. g. Nasdaq, NYSE, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#StockExchange"></see></summary>
    let StockExchange =
        Namespaced_IRI.parse _namespace_name "StockExchange" |> NamespacedName

    /// <summary>
    /// A stock exchange/market index is a method of measuring a section of the stock market. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#StockExchangeIndex"></see></summary>
    let StockExchangeIndex =
        Namespaced_IRI.parse _namespace_name "StockExchangeIndex" |> NamespacedName

    /// <summary>
    /// The general notion for a roadway within a city or village, often, surrounded by buildings. We put here boulevards, streets, avenues, etc. NIMA GNS designator - missing.
    /// <see href="http://www.ontotext.com/proton/protonext#Street"></see></summary>
    let Street = Namespaced_IRI.parse _namespace_name "Street" |> NamespacedName
    /// <summary>
    /// Part of a postal address denoting the street name.
    /// <see href="http://www.ontotext.com/proton/protonext#StreetName"></see></summary>
    let StreetName = Namespaced_IRI.parse _namespace_name "StreetName" |> NamespacedName

    /// <summary>
    /// Part of a postal address denoting the street number.
    /// <see href="http://www.ontotext.com/proton/protonext#StreetNumber"></see></summary>
    let StreetNumber =
        Namespaced_IRI.parse _namespace_name "StreetNumber" |> NamespacedName

    /// <summary>
    /// The profession of swimmer
    /// <see href="http://www.ontotext.com/proton/protonext#Swimmer"></see></summary>
    let Swimmer = Namespaced_IRI.parse _namespace_name "Swimmer" |> NamespacedName
    /// <summary>
    /// A brand of a television channel.
    /// <see href="http://www.ontotext.com/proton/protonext#TVChannel"></see></summary>
    let TVChannel = Namespaced_IRI.parse _namespace_name "TVChannel" |> NamespacedName
    /// <summary>
    /// A company that broadcasts audio and video content.
    /// <see href="http://www.ontotext.com/proton/protonext#TVCompany"></see></summary>
    let TVCompany = Namespaced_IRI.parse _namespace_name "TVCompany" |> NamespacedName
    /// <summary>
    /// A telecommunications company
    /// <see href="http://www.ontotext.com/proton/protonext#Telecom"></see></summary>
    let Telecom = Namespaced_IRI.parse _namespace_name "Telecom" |> NamespacedName

    /// <summary>
    /// Denotes any episod of any television series.
    /// <see href="http://www.ontotext.com/proton/protonext#TelevisionEpisode"></see></summary>
    let TelevisionEpisode =
        Namespaced_IRI.parse _namespace_name "TelevisionEpisode" |> NamespacedName

    /// <summary>
    /// Denotes programms produced in the television and for television airing.
    /// <see href="http://www.ontotext.com/proton/protonext#TelevisionProduct"></see></summary>
    let TelevisionProduct =
        Namespaced_IRI.parse _namespace_name "TelevisionProduct" |> NamespacedName

    /// <summary>
    /// Any television show
    /// <see href="http://www.ontotext.com/proton/protonext#TelevisionShow"></see></summary>
    let TelevisionShow =
        Namespaced_IRI.parse _namespace_name "TelevisionShow" |> NamespacedName

    /// <summary>
    /// Any Tennis league
    /// <see href="http://www.ontotext.com/proton/protonext#TennisLeague"></see></summary>
    let TennisLeague =
        Namespaced_IRI.parse _namespace_name "TennisLeague" |> NamespacedName

    /// <summary>
    /// The profession of tennis player
    /// <see href="http://www.ontotext.com/proton/protonext#TennisPlayer"></see></summary>
    let TennisPlayer =
        Namespaced_IRI.parse _namespace_name "TennisPlayer" |> NamespacedName

    /// <summary>
    /// Territory a region of land which can be a part of contry that is non-sovereign or a geographic region determined by some charateristics. (Wikipedia) (http://www.eionet.europa.eu/gemet/concept?ns=1&amp;cp=8401. NIMA GNS designator A.TERR.
    /// <see href="http://www.ontotext.com/proton/protonext#Territory"></see></summary>
    let Territory = Namespaced_IRI.parse _namespace_name "Territory" |> NamespacedName

    /// <summary>
    /// An art performance following a stage play.
    /// <see href="http://www.ontotext.com/proton/protonext#TheatrePerformance"></see></summary>
    let TheatrePerformance =
        Namespaced_IRI.parse _namespace_name "TheatrePerformance" |> NamespacedName

    /// <summary>
    /// A time zone is a region on Earth that has a uniform standard time for legal, commercial, and social purposes. Wikipedia.
    /// <see href="http://www.ontotext.com/proton/protonext#TimeZone"></see></summary>
    let TimeZone = Namespaced_IRI.parse _namespace_name "TimeZone" |> NamespacedName
    /// <summary>
    /// A Tournament which is held regularly at particular time intervals, every year, every week, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#Tournament"></see></summary>
    let Tournament = Namespaced_IRI.parse _namespace_name "Tournament" |> NamespacedName

    /// <summary>
    /// A Tournament held at a particular time
    /// <see href="http://www.ontotext.com/proton/protonext#TournamentOccurrence"></see></summary>
    let TournamentOccurrence =
        Namespaced_IRI.parse _namespace_name "TournamentOccurrence" |> NamespacedName

    /// <summary>
    /// (ADL FT) Manmade structures, higher than their diameter, generally used for observation, storage, or electronic transmission. We use this category for carillons; for fire lookouts; and for pagodas. NIMA GNS designator TOWR.
    /// <see href="http://www.ontotext.com/proton/protonext#Tower"></see></summary>
    let Tower = Namespaced_IRI.parse _namespace_name "Tower" |> NamespacedName
    /// <summary>
    /// Any town
    /// <see href="http://www.ontotext.com/proton/protonext#Town"></see></summary>
    let Town = Namespaced_IRI.parse _namespace_name "Town" |> NamespacedName
    /// <summary>
    /// Any Trade Union, an organization of workers that have banded together to achieve common goals such as better working conditions. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#TradeUnion"></see></summary>
    let TradeUnion = Namespaced_IRI.parse _namespace_name "TradeUnion" |> NamespacedName
    /// <summary>
    /// (ADL FT) Treeless, level, or gently rolling plains characteristic of arctic or subarctic regions, having a permanently frozen subsoil, and usually supporting low growing vegetation such as lichens, mosses, and stunted shrubs. [USGS Circ 1048] We use this category for Arctic land. NIMA GNS designator TUND, LAND.
    /// <see href="http://www.ontotext.com/proton/protonext#Tundra"></see></summary>
    let Tundra = Namespaced_IRI.parse _namespace_name "Tundra" |> NamespacedName
    /// <summary>
    /// An educational organization higher than school.
    /// <see href="http://www.ontotext.com/proton/protonext#University"></see></summary>
    let University = Namespaced_IRI.parse _namespace_name "University" |> NamespacedName

    /// <summary>
    /// (ADL FT: Countries, 3rd order divisions) Minor civil units. [USGS Circ 1048] We use this category for barrios; for precincts; for third-order administrative divisions; and for townships. NIMA GNS designator ADM3.
    /// <see href="http://www.ontotext.com/proton/protonext#UrbanDistrict"></see></summary>
    let UrbanDistrict =
        Namespaced_IRI.parse _namespace_name "UrbanDistrict" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#User"></see>
    /// </summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#UserProfile"></see>
    /// </summary>
    let UserProfile =
        Namespaced_IRI.parse _namespace_name "UserProfile" |> NamespacedName

    /// <summary>
    /// Vein is a general concept gathering all veins of a body.
    /// <see href="http://www.ontotext.com/proton/protonext#Vein"></see></summary>
    let Vein = Namespaced_IRI.parse _namespace_name "Vein" |> NamespacedName

    /// <summary>
    /// Any Vice President, the title of a vice president in a country or in an organization.
    /// <see href="http://www.ontotext.com/proton/protonext#VicePresident"></see></summary>
    let VicePresident =
        Namespaced_IRI.parse _namespace_name "VicePresident" |> NamespacedName

    /// <summary>
    /// Any Vice Prime Minister, the title of a vice prime minister in a country.
    /// <see href="http://www.ontotext.com/proton/protonext#VicePrimeMinister"></see></summary>
    let VicePrimeMinister =
        Namespaced_IRI.parse _namespace_name "VicePrimeMinister" |> NamespacedName

    /// <summary>
    /// Any electronic game that involves interaction with a user interface to generate visual feedback on a video device. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#VideoGame"></see></summary>
    let VideoGame = Namespaced_IRI.parse _namespace_name "VideoGame" |> NamespacedName

    /// <summary>
    /// Any Videogames league
    /// <see href="http://www.ontotext.com/proton/protonext#VideogamesLeague"></see></summary>
    let VideogamesLeague =
        Namespaced_IRI.parse _namespace_name "VideogamesLeague" |> NamespacedName

    /// <summary>
    /// Any village
    /// <see href="http://www.ontotext.com/proton/protonext#Village"></see></summary>
    let Village = Namespaced_IRI.parse _namespace_name "Village" |> NamespacedName
    /// <summary>
    /// Plantings of grapevines
    /// <see href="http://www.ontotext.com/proton/protonext#Vineyard"></see></summary>
    let Vineyard = Namespaced_IRI.parse _namespace_name "Vineyard" |> NamespacedName
    /// <summary>
    /// (ADL FT) Vents in the surface of the Earth through which magma and associated gases erupt; also, the forms or structures, usually conical, that are produced by the erupted material. NIMA GNS designator VLC.
    /// <see href="http://www.ontotext.com/proton/protonext#Volcano"></see></summary>
    let Volcano = Namespaced_IRI.parse _namespace_name "Volcano" |> NamespacedName

    /// <summary>
    /// Any Volleyball league
    /// <see href="http://www.ontotext.com/proton/protonext#VolleyballLeague"></see></summary>
    let VolleyballLeague =
        Namespaced_IRI.parse _namespace_name "VolleyballLeague" |> NamespacedName

    /// <summary>
    /// A profession of a volleyball player.
    /// <see href="http://www.ontotext.com/proton/protonext#VolleyballPlayer"></see></summary>
    let VolleyballPlayer =
        Namespaced_IRI.parse _namespace_name "VolleyballPlayer" |> NamespacedName

    /// <summary>
    /// A valley or ravine, bounded by relatively steep banks. NIMA GNS designator H.WAD, H.WADB, H.WADJ, H.WADM, H.WADS, H.WADX.
    /// <see href="http://www.ontotext.com/proton/protonext#Wadi"></see></summary>
    let Wadi = Namespaced_IRI.parse _namespace_name "Wadi" |> NamespacedName
    /// <summary>
    /// (ADL FT: Banks) Sloping margins of, or the ground bordering, a stream, and serving to confine the water to the natural channel during the normal course of flow. [Glossary of Geology, 4th ed.] We use this category for stream banks. NIMA GNS designator BKSU, BNK, BNKR, BNKU, BNKX.
    /// <see href="http://www.ontotext.com/proton/protonext#WaterBank"></see></summary>
    let WaterBank = Namespaced_IRI.parse _namespace_name "WaterBank" |> NamespacedName

    /// <summary>
    /// A net transport of ocean water along a definable path. http://www.eionet.europa.eu/gemet/concept/5792 NIMA GNS designator H.CRNT.
    /// <see href="http://www.ontotext.com/proton/protonext#WaterCurrent"></see></summary>
    let WaterCurrent =
        Namespaced_IRI.parse _namespace_name "WaterCurrent" |> NamespacedName

    /// <summary>
    /// A straight section of a navigable stream or channel between two bends. NIMA GNS designator H.RCH.
    /// <see href="http://www.ontotext.com/proton/protonext#WaterReach"></see></summary>
    let WaterReach = Namespaced_IRI.parse _namespace_name "WaterReach" |> NamespacedName
    /// <summary>
    /// A contained pool or tank of water at, below, or above ground level. NIMA GNS designator H.RSVT.
    /// <see href="http://www.ontotext.com/proton/protonext#WaterTank"></see></summary>
    let WaterTank = Namespaced_IRI.parse _namespace_name "WaterTank" |> NamespacedName

    /// <summary>
    /// A natural, well-defined channel produced by flowing water, or an artificial channel designed to carry flowing water. NIMA GNS designator H.WTRC.
    /// <see href="http://www.ontotext.com/proton/protonext#Watercourse"></see></summary>
    let Watercourse =
        Namespaced_IRI.parse _namespace_name "Watercourse" |> NamespacedName

    /// <summary>
    /// (ADL FT) Perpendicular or very steep falls of water in the course of a stream. ... We use this category for cascades; for cataracts; and for falls. NIMA GNS designator FLLS, FLLSX
    /// <see href="http://www.ontotext.com/proton/protonext#Waterfalls"></see></summary>
    let Waterfalls = Namespaced_IRI.parse _namespace_name "Waterfalls" |> NamespacedName
    /// <summary>
    /// A natural hole, hollow, or small depression that contains water, used by man and animals, especially in arid areas. NIMA GNS designator H.WTRH.
    /// <see href="http://www.ontotext.com/proton/protonext#Waterhole"></see></summary>
    let Waterhole = Namespaced_IRI.parse _namespace_name "Waterhole" |> NamespacedName

    /// <summary>
    /// A concrete model of a weapon that determines its main features. For example, Patriot, SU-28, and Kalashnikov.
    /// <see href="http://www.ontotext.com/proton/protonext#WeaponModelOrSystem"></see></summary>
    let WeaponModelOrSystem =
        Namespaced_IRI.parse _namespace_name "WeaponModelOrSystem" |> NamespacedName

    /// <summary>
    /// A specific week of a specific year (say the 41st of 2001)
    /// <see href="http://www.ontotext.com/proton/protonext#Week"></see></summary>
    let Week = Namespaced_IRI.parse _namespace_name "Week" |> NamespacedName
    /// <summary>
    /// A cylindrical hole, pit, or tunnel drilled or dug down to a depth from which water, oil, or gas can be pumped or brought to the surface. NIMA GNS designator H.WLL, H.WLLQ, H.WLLS.
    /// <see href="http://www.ontotext.com/proton/protonext#Well"></see></summary>
    let Well = Namespaced_IRI.parse _namespace_name "Well" |> NamespacedName
    /// <summary>
    /// A turbulent, rotating movement of water in a stream. NIMA GNS designator H.WHRL.
    /// <see href="http://www.ontotext.com/proton/protonext#Whirlpool"></see></summary>
    let Whirlpool = Namespaced_IRI.parse _namespace_name "Whirlpool" |> NamespacedName
    /// <summary>
    /// Any Wine Region, a region where wine is produced.
    /// <see href="http://www.ontotext.com/proton/protonext#WineRegion"></see></summary>
    let WineRegion = Namespaced_IRI.parse _namespace_name "WineRegion" |> NamespacedName
    /// <summary>
    /// A female human.
    /// <see href="http://www.ontotext.com/proton/protonext#Woman"></see></summary>
    let Woman = Namespaced_IRI.parse _namespace_name "Woman" |> NamespacedName

    /// <summary>
    /// Any world heritage site, a old site with historic value of world magnitude to be preserved.
    /// <see href="http://www.ontotext.com/proton/protonext#WorldHeritageSite"></see></summary>
    let WorldHeritageSite =
        Namespaced_IRI.parse _namespace_name "WorldHeritageSite" |> NamespacedName

    /// <summary>
    /// The profession of wrestler
    /// <see href="http://www.ontotext.com/proton/protonext#Wrestler"></see></summary>
    let Wrestler = Namespaced_IRI.parse _namespace_name "Wrestler" |> NamespacedName
    /// <summary>
    /// Any writer, a profession of producing literary content. (Wikipedia)
    /// <see href="http://www.ontotext.com/proton/protonext#Writer"></see></summary>
    let Writer = Namespaced_IRI.parse _namespace_name "Writer" |> NamespacedName
    /// <summary>
    /// Part of a postal address denoting the zip code.
    /// <see href="http://www.ontotext.com/proton/protonext#ZipCode"></see></summary>
    let ZipCode = Namespaced_IRI.parse _namespace_name "ZipCode" |> NamespacedName
    /// <summary>
    /// A land region defined to play a role. For example, a buffer between two nations in which military presence is minimal or absent or zone around the site of the Chernobyl disaster to protect people from radiation. (NIMA GNS designator A.ZN, A.ZNB.
    /// <see href="http://www.ontotext.com/proton/protonext#Zone"></see></summary>
    let Zone = Namespaced_IRI.parse _namespace_name "Zone" |> NamespacedName

    /// <summary>
    /// A relation between an account and an agent (usually organization) providing and managing it
    /// <see href="http://www.ontotext.com/proton/protonext#accountProvider"></see></summary>
    let accountProvider =
        Namespaced_IRI.parse _namespace_name "accountProvider" |> NamespacedName

    /// <summary>
    /// The participant of an acquirement event which became a property of another participant in this event.
    /// <see href="http://www.ontotext.com/proton/protonext#acquired"></see></summary>
    let acquired = Namespaced_IRI.parse _namespace_name "acquired" |> NamespacedName
    /// <summary>
    /// The participant of an acquirement event which became an owner of another participant in this event.
    /// <see href="http://www.ontotext.com/proton/protonext#acquirer"></see></summary>
    let acquirer = Namespaced_IRI.parse _namespace_name "acquirer" |> NamespacedName

    /// <summary>
    /// Denotes that the organization is active within the industry sector
    /// <see href="http://www.ontotext.com/proton/protonext#activeInSector"></see></summary>
    let activeInSector =
        Namespaced_IRI.parse _namespace_name "activeInSector" |> NamespacedName

    /// <summary>
    /// The general part-of relation that takes place between a whole and each of its parts. It has number of specializations.
    /// <see href="http://www.ontotext.com/proton/protonext#subSectorOf"></see></summary>
    let subSectorOf =
        Namespaced_IRI.parse _namespace_name "subSectorOf" |> NamespacedName

    /// <summary>
    /// A concrete job position appointed by a given person.
    /// <see href="http://www.ontotext.com/proton/protonext#appointedBy"></see></summary>
    let appointedBy =
        Namespaced_IRI.parse _namespace_name "appointedBy" |> NamespacedName

    /// <summary>
    /// A concrete job position which is assigned to the position available in a given organization.
    /// <see href="http://www.ontotext.com/proton/protonext#appointmentFor"></see></summary>
    let appointmentFor =
        Namespaced_IRI.parse _namespace_name "appointmentFor" |> NamespacedName

    /// <summary>
    /// The relation between a facility and its architect.
    /// <see href="http://www.ontotext.com/proton/protonext#architect"></see></summary>
    let architect = Namespaced_IRI.parse _namespace_name "architect" |> NamespacedName

    /// <summary>
    /// A relation between a person and his/her profession.
    /// <see href="http://www.ontotext.com/proton/protonext#hasProfession"></see></summary>
    let hasProfession =
        Namespaced_IRI.parse _namespace_name "hasProfession" |> NamespacedName

    /// <summary>
    /// Any author of a product. Links any object to its author (producer).
    /// <see href="http://www.ontotext.com/proton/protonext#authorOf"></see></summary>
    let authorOf = Namespaced_IRI.parse _namespace_name "authorOf" |> NamespacedName
    /// <summary>
    /// Any author of a product. Links an author (producer) to its creation .
    /// <see href="http://www.ontotext.com/proton/protonext#isAuthorOf"></see></summary>
    let isAuthorOf = Namespaced_IRI.parse _namespace_name "isAuthorOf" |> NamespacedName
    /// <summary>
    /// The relation between a person and the date he/she is born.
    /// <see href="http://www.ontotext.com/proton/protonext#birthDate"></see></summary>
    let birthDate = Namespaced_IRI.parse _namespace_name "birthDate" |> NamespacedName
    /// <summary>
    /// The relation between a person and the place he/she is born.
    /// <see href="http://www.ontotext.com/proton/protonext#birthPlace"></see></summary>
    let birthPlace = Namespaced_IRI.parse _namespace_name "birthPlace" |> NamespacedName

    /// <summary>
    /// The relation between a car model and the country it is assembled in.
    /// <see href="http://www.ontotext.com/proton/protonext#carAssemblyIn"></see></summary>
    let carAssemblyIn =
        Namespaced_IRI.parse _namespace_name "carAssemblyIn" |> NamespacedName

    /// <summary>
    /// Any cause of death.
    /// <see href="http://www.ontotext.com/proton/protonext#causeOfDeath"></see></summary>
    let causeOfDeath =
        Namespaced_IRI.parse _namespace_name "causeOfDeath" |> NamespacedName

    /// <summary>
    /// the relation between a military unit and the organization it represents in a military conflict.
    /// <see href="http://www.ontotext.com/proton/protonext#combatantFrom"></see></summary>
    let combatantFrom =
        Namespaced_IRI.parse _namespace_name "combatantFrom" |> NamespacedName

    /// <summary>
    /// It links a dataset with a schema it complies to.
    /// <see href="http://www.ontotext.com/proton/protonext#compliantWithSchema"></see></summary>
    let compliantWithSchema =
        Namespaced_IRI.parse _namespace_name "compliantWithSchema" |> NamespacedName

    /// <summary>
    /// The relation between a military organization, which participates as a combatant in a military conflict
    /// <see href="http://www.ontotext.com/proton/protonext#conflictCombatant"></see></summary>
    let conflictCombatant =
        Namespaced_IRI.parse _namespace_name "conflictCombatant" |> NamespacedName

    /// <summary>
    /// Relation between two locations where the first contains the other.
    /// The relation between a location and another location that is contained by the first one.
    /// <see href="http://www.ontotext.com/proton/protonext#containsLocation"></see></summary>
    let containsLocation =
        Namespaced_IRI.parse _namespace_name "containsLocation" |> NamespacedName

    /// <summary>
    /// The relation between a recurring event and its frequency.
    /// <see href="http://www.ontotext.com/proton/protonext#currentFrequency"></see></summary>
    let currentFrequency =
        Namespaced_IRI.parse _namespace_name "currentFrequency" |> NamespacedName

    /// <summary>
    /// Typically, associated with the creation or availability of the resource. Recommended best practice for encoding the date value is defined in a profile of ISO 8601 [W3CDTF] and includes (among others) dates of the form YYYY-MM-DD. This date is related to an event of publishing which here is implicit. If necessary for the task it can be made explicit in an extension of the ontology.
    /// <see href="http://www.ontotext.com/proton/protonext#datePublished"></see></summary>
    let datePublished =
        Namespaced_IRI.parse _namespace_name "datePublished" |> NamespacedName

    /// <summary>
    /// The relation between a person and the date he/she died.
    /// <see href="http://www.ontotext.com/proton/protonext#deathDate"></see></summary>
    let deathDate = Namespaced_IRI.parse _namespace_name "deathDate" |> NamespacedName
    /// <summary>
    /// The relation between a person and the place he/she died.
    /// <see href="http://www.ontotext.com/proton/protonext#deathPlace"></see></summary>
    let deathPlace = Namespaced_IRI.parse _namespace_name "deathPlace" |> NamespacedName

    /// <summary>
    /// Any author of engineering and architecture designs. The relation between an author and the facility he has designed.
    /// <see href="http://www.ontotext.com/proton/protonext#designerOfFacility"></see></summary>
    let designerOfFacility =
        Namespaced_IRI.parse _namespace_name "designerOfFacility" |> NamespacedName

    /// <summary>
    /// the relation between an official position, usually political and the location it represents. The district represented by an official position, usually political.
    /// <see href="http://www.ontotext.com/proton/protonext#districtRepresented"></see></summary>
    let districtRepresented =
        Namespaced_IRI.parse _namespace_name "districtRepresented" |> NamespacedName

    /// <summary>
    /// The date of the last occurrence of a recurring event.
    /// <see href="http://www.ontotext.com/proton/protonext#finalOccuranceDate"></see></summary>
    let finalOccuranceDate =
        Namespaced_IRI.parse _namespace_name "finalOccuranceDate" |> NamespacedName

    /// <summary>
    /// The date of the first occurrence of a recurring event.
    /// <see href="http://www.ontotext.com/proton/protonext#firstOccuranceDate"></see></summary>
    let firstOccuranceDate =
        Namespaced_IRI.parse _namespace_name "firstOccuranceDate" |> NamespacedName

    /// <summary>
    /// Net Income last year.
    /// <see href="http://www.ontotext.com/proton/protonext#fiscalNetIncome"></see></summary>
    let fiscalNetIncome =
        Namespaced_IRI.parse _namespace_name "fiscalNetIncome" |> NamespacedName

    /// <summary>
    /// Sales last year.
    /// <see href="http://www.ontotext.com/proton/protonext#fiscalSales"></see></summary>
    let fiscalSales =
        Namespaced_IRI.parse _namespace_name "fiscalSales" |> NamespacedName

    /// <summary>
    /// The relation between an agent and the genre he is occupied in.
    /// <see href="http://www.ontotext.com/proton/protonext#genreOfAgent"></see></summary>
    let genreOfAgent =
        Namespaced_IRI.parse _namespace_name "genreOfAgent" |> NamespacedName

    /// <summary>
    /// Relates address to an agent. Will be used for URL, email and other addresses.
    /// <see href="http://www.ontotext.com/proton/protonext#hasAddress"></see></summary>
    let hasAddress = Namespaced_IRI.parse _namespace_name "hasAddress" |> NamespacedName
    /// <summary>
    /// A relation between a city and an airport near to the city.
    /// <see href="http://www.ontotext.com/proton/protonext#hasAirport"></see></summary>
    let hasAirport = Namespaced_IRI.parse _namespace_name "hasAirport" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasBottomOffset"></see>
    /// </summary>
    let hasBottomOffset =
        Namespaced_IRI.parse _namespace_name "hasBottomOffset" |> NamespacedName

    /// <summary>
    /// Relates a person and his/her brother.
    /// <see href="http://www.ontotext.com/proton/protonext#hasBrother"></see></summary>
    let hasBrother = Namespaced_IRI.parse _namespace_name "hasBrother" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasCapabilities"></see>
    /// </summary>
    let hasCapabilities =
        Namespaced_IRI.parse _namespace_name "hasCapabilities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasCapital"></see>
    /// </summary>
    let hasCapital = Namespaced_IRI.parse _namespace_name "hasCapital" |> NamespacedName

    /// <summary>
    /// The relation between the status of celebrity and its celebrity title of notoriety in the society.
    /// <see href="http://www.ontotext.com/proton/protonext#hasCelebrityTitle"></see></summary>
    let hasCelebrityTitle =
        Namespaced_IRI.parse _namespace_name "hasCelebrityTitle" |> NamespacedName

    /// <summary>
    /// Generic property relating a Social Position to its name defined as an instance of a sub-class of pext:SocialFunction
    /// <see href="http://www.ontotext.com/proton/protonext#hasSocialFunctionTitle"></see></summary>
    let hasSocialFunctionTitle =
        Namespaced_IRI.parse _namespace_name "hasSocialFunctionTitle" |> NamespacedName

    /// <summary>
    /// The relation between a Cleric and its cleric title, like Bishop, Pole, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#hasClericTitle"></see></summary>
    let hasClericTitle =
        Namespaced_IRI.parse _namespace_name "hasClericTitle" |> NamespacedName

    /// <summary>
    /// Denotes that the Sector has the specified SIC code
    /// <see href="http://www.ontotext.com/proton/protonext#hasCode"></see></summary>
    let hasCode = Namespaced_IRI.parse _namespace_name "hasCode" |> NamespacedName

    /// <summary>
    /// The relation between a military unit and the person who commands it.
    /// <see href="http://www.ontotext.com/proton/protonext#hasCommander"></see></summary>
    let hasCommander =
        Namespaced_IRI.parse _namespace_name "hasCommander" |> NamespacedName

    /// <summary>
    /// A relation between a country and the currency used within the country
    /// <see href="http://www.ontotext.com/proton/protonext#hasCurrency"></see></summary>
    let hasCurrency =
        Namespaced_IRI.parse _namespace_name "hasCurrency" |> NamespacedName

    /// <summary>
    /// Relates a person and his/her daughter.
    /// <see href="http://www.ontotext.com/proton/protonext#hasDaughter"></see></summary>
    let hasDaughter =
        Namespaced_IRI.parse _namespace_name "hasDaughter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasDevice"></see>
    /// </summary>
    let hasDevice = Namespaced_IRI.parse _namespace_name "hasDevice" |> NamespacedName
    /// <summary>
    /// Relates an object (usually a person) to its email.
    /// <see href="http://www.ontotext.com/proton/protonext#hasEMail"></see></summary>
    let hasEMail = Namespaced_IRI.parse _namespace_name "hasEMail" |> NamespacedName

    /// <summary>
    /// Relates an object to its internet address.
    /// <see href="http://www.ontotext.com/proton/protonext#hasInternetAddress"></see></summary>
    let hasInternetAddress =
        Namespaced_IRI.parse _namespace_name "hasInternetAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasEndOffset"></see>
    /// </summary>
    let hasEndOffset =
        Namespaced_IRI.parse _namespace_name "hasEndOffset" |> NamespacedName

    /// <summary>
    /// Relates a person and his/her father.
    /// <see href="http://www.ontotext.com/proton/protonext#hasFather"></see></summary>
    let hasFather = Namespaced_IRI.parse _namespace_name "hasFather" |> NamespacedName
    /// <summary>
    /// Relates an object (usually an organization) to its fax number.
    /// <see href="http://www.ontotext.com/proton/protonext#hasFax"></see></summary>
    let hasFax = Namespaced_IRI.parse _namespace_name "hasFax" |> NamespacedName

    /// <summary>
    /// A relation between a country and its government
    /// <see href="http://www.ontotext.com/proton/protonext#hasGovernment"></see></summary>
    let hasGovernment =
        Namespaced_IRI.parse _namespace_name "hasGovernment" |> NamespacedName

    /// <summary>
    /// Relates a woman to her spouse.
    /// <see href="http://www.ontotext.com/proton/protonext#hasHusband"></see></summary>
    let hasHusband = Namespaced_IRI.parse _namespace_name "hasHusband" |> NamespacedName

    /// <summary>
    /// a relation between an Information Space and its Profile
    /// <see href="http://www.ontotext.com/proton/protonext#hasISProfile"></see></summary>
    let hasISProfile =
        Namespaced_IRI.parse _namespace_name "hasISProfile" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasLeftOffset"></see>
    /// </summary>
    let hasLeftOffset =
        Namespaced_IRI.parse _namespace_name "hasLeftOffset" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasStartOffset"></see>
    /// </summary>
    let hasStartOffset =
        Namespaced_IRI.parse _namespace_name "hasStartOffset" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasLocation"></see>
    /// </summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    /// The relation between a minister and his/her ministry.
    /// <see href="http://www.ontotext.com/proton/protonext#hasMinister"></see></summary>
    let hasMinister =
        Namespaced_IRI.parse _namespace_name "hasMinister" |> NamespacedName

    /// <summary>
    /// Relates an object (usually a person) to its mobile phone number.
    /// <see href="http://www.ontotext.com/proton/protonext#hasMobilePhone"></see></summary>
    let hasMobilePhone =
        Namespaced_IRI.parse _namespace_name "hasMobilePhone" |> NamespacedName

    /// <summary>
    /// Relates an object (usually a person or an organization) to its telephone number.
    /// <see href="http://www.ontotext.com/proton/protonext#hasPhone"></see></summary>
    let hasPhone = Namespaced_IRI.parse _namespace_name "hasPhone" |> NamespacedName
    /// <summary>
    /// Relates a person to his/her mother.
    /// <see href="http://www.ontotext.com/proton/protonext#hasMother"></see></summary>
    let hasMother = Namespaced_IRI.parse _namespace_name "hasMother" |> NamespacedName

    /// <summary>
    /// The relation between the social position and the social title of nobelty.
    /// <see href="http://www.ontotext.com/proton/protonext#hasNobeltyTitle"></see></summary>
    let hasNobeltyTitle =
        Namespaced_IRI.parse _namespace_name "hasNobeltyTitle" |> NamespacedName

    /// <summary>
    /// The relation between the status of a criminal, and title, for instance a prisoner.
    /// <see href="http://www.ontotext.com/proton/protonext#hasOutOfLawsTitle"></see></summary>
    let hasOutOfLawsTitle =
        Namespaced_IRI.parse _namespace_name "hasOutOfLawsTitle" |> NamespacedName

    /// <summary>
    /// The relation between a given sport game event and a point scored in it.
    /// <see href="http://www.ontotext.com/proton/protonext#hasPoint"></see></summary>
    let hasPoint = Namespaced_IRI.parse _namespace_name "hasPoint" |> NamespacedName

    /// <summary>
    /// The relation between a government and its head.
    /// <see href="http://www.ontotext.com/proton/protonext#hasPrimeMinister"></see></summary>
    let hasPrimeMinister =
        Namespaced_IRI.parse _namespace_name "hasPrimeMinister" |> NamespacedName

    /// <summary>
    /// An entity responsible for making the resource available. Examples of Publisher include a person, an organization, or a service. (DC2003ISO)
    /// <see href="http://www.ontotext.com/proton/protonext#hasPublisher"></see></summary>
    let hasPublisher =
        Namespaced_IRI.parse _namespace_name "hasPublisher" |> NamespacedName

    /// <summary>
    /// The relation between a particular event as an element of a recurring event.
    /// <see href="http://www.ontotext.com/proton/protonext#hasRecurringEventInstance"></see></summary>
    let hasRecurringEventInstance =
        Namespaced_IRI.parse _namespace_name "hasRecurringEventInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasRightOffset"></see>
    /// </summary>
    let hasRightOffset =
        Namespaced_IRI.parse _namespace_name "hasRightOffset" |> NamespacedName

    /// <summary>
    /// Relates a happening with some of the roles in it
    /// <see href="http://www.ontotext.com/proton/protonext#hasRole"></see></summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName
    /// <summary>
    /// Natural relation between documents and sections. Imported from the iSIM ontology.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSection"></see></summary>
    let hasSection = Namespaced_IRI.parse _namespace_name "hasSection" |> NamespacedName

    /// <summary>
    /// A relation between a commercial organization and a person that owns shares of the organization.
    /// <see href="http://www.ontotext.com/proton/protonext#hasShareholder"></see></summary>
    let hasShareholder =
        Namespaced_IRI.parse _namespace_name "hasShareholder" |> NamespacedName

    /// <summary>
    /// Relates a person to his/her sister.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSister"></see></summary>
    let hasSister = Namespaced_IRI.parse _namespace_name "hasSister" |> NamespacedName

    /// <summary>
    /// The relation between a person and the social position of Celebrity he has.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSocialPositionCelebrity"></see></summary>
    let hasSocialPositionCelebrity =
        Namespaced_IRI.parse _namespace_name "hasSocialPositionCelebrity" |> NamespacedName

    /// <summary>
    /// The relation between a social position of Celebrity and the person who has it.
    /// <see href="http://www.ontotext.com/proton/protonext#socialPositionCelebrity"></see></summary>
    let socialPositionCelebrity =
        Namespaced_IRI.parse _namespace_name "socialPositionCelebrity" |> NamespacedName

    /// <summary>
    /// The relation between a person and the social position of Cleric he has.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSocialPositionCleric"></see></summary>
    let hasSocialPositionCleric =
        Namespaced_IRI.parse _namespace_name "hasSocialPositionCleric" |> NamespacedName

    /// <summary>
    /// The relation between a social position of Cleric and the person who has it.
    /// <see href="http://www.ontotext.com/proton/protonext#socialPositionCleric"></see></summary>
    let socialPositionCleric =
        Namespaced_IRI.parse _namespace_name "socialPositionCleric" |> NamespacedName

    /// <summary>
    /// The relation between a person and the social position of Nobelty he has.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSocialPositionNobelty"></see></summary>
    let hasSocialPositionNobelty =
        Namespaced_IRI.parse _namespace_name "hasSocialPositionNobelty" |> NamespacedName

    /// <summary>
    /// The relation between a social position of Nobelty and the person who has it.
    /// <see href="http://www.ontotext.com/proton/protonext#socialPositionNobelty"></see></summary>
    let socialPositionNobelty =
        Namespaced_IRI.parse _namespace_name "socialPositionNobelty" |> NamespacedName

    /// <summary>
    /// The relation between a person and the social position of OutOfLaws he has.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSocialPositionOutOfLaws"></see></summary>
    let hasSocialPositionOutOfLaws =
        Namespaced_IRI.parse _namespace_name "hasSocialPositionOutOfLaws" |> NamespacedName

    /// <summary>
    /// The relation between a social position of OutOfLaws and the person who has it.
    /// <see href="http://www.ontotext.com/proton/protonext#socialPositionOutOfLaws"></see></summary>
    let socialPositionOutOfLaws =
        Namespaced_IRI.parse _namespace_name "socialPositionOutOfLaws" |> NamespacedName

    /// <summary>
    /// Relates a person to his/her son.
    /// <see href="http://www.ontotext.com/proton/protonext#hasSon"></see></summary>
    let hasSon = Namespaced_IRI.parse _namespace_name "hasSon" |> NamespacedName

    /// <summary>
    /// Relates an object (usually a person) to its stationary phone number.
    /// <see href="http://www.ontotext.com/proton/protonext#hasStationaryPhone"></see></summary>
    let hasStationaryPhone =
        Namespaced_IRI.parse _namespace_name "hasStationaryPhone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasString"></see>
    /// </summary>
    let hasString = Namespaced_IRI.parse _namespace_name "hasString" |> NamespacedName
    /// <summary>
    /// Relates a job position to its title.
    /// <see href="http://www.ontotext.com/proton/protonext#hasTitle"></see></summary>
    let hasTitle = Namespaced_IRI.parse _namespace_name "hasTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#hasTopOffset"></see>
    /// </summary>
    let hasTopOffset =
        Namespaced_IRI.parse _namespace_name "hasTopOffset" |> NamespacedName

    /// <summary>
    /// Relates a currency to its unit. Examples: dollar, euro, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#hasUnit"></see></summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName

    /// <summary>
    /// a relation between an User and its Profile
    /// <see href="http://www.ontotext.com/proton/protonext#hasUserProfile"></see></summary>
    let hasUserProfile =
        Namespaced_IRI.parse _namespace_name "hasUserProfile" |> NamespacedName

    /// <summary>
    /// Relates an object (usually a person or an organization) to its web page.
    /// <see href="http://www.ontotext.com/proton/protonext#hasWebPage"></see></summary>
    let hasWebPage = Namespaced_IRI.parse _namespace_name "hasWebPage" |> NamespacedName
    /// <summary>
    /// Relates a man to his spouse.
    /// <see href="http://www.ontotext.com/proton/protonext#hasWife"></see></summary>
    let hasWife = Namespaced_IRI.parse _namespace_name "hasWife" |> NamespacedName
    /// <summary>
    /// The relation between an organization and the industry sector it is active in.
    /// <see href="http://www.ontotext.com/proton/protonext#industryOf"></see></summary>
    let industryOf = Namespaced_IRI.parse _namespace_name "industryOf" |> NamespacedName

    /// <summary>
    /// A place where a person is born. The relation between a location and a person who is born in this location.
    /// <see href="http://www.ontotext.com/proton/protonext#isBirthPlaceOf"></see></summary>
    let isBirthPlaceOf =
        Namespaced_IRI.parse _namespace_name "isBirthPlaceOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#isCurrentlyInterestedIn"></see>
    /// </summary>
    let isCurrentlyInterestedIn =
        Namespaced_IRI.parse _namespace_name "isCurrentlyInterestedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protonext#isInterestedIn"></see>
    /// </summary>
    let isInterestedIn =
        Namespaced_IRI.parse _namespace_name "isInterestedIn" |> NamespacedName

    /// <summary>
    /// The relation between an RDF document containing the descriptions of locations that share a common border
    /// <see href="http://www.ontotext.com/proton/protonext#isWrittenAbout"></see></summary>
    let isWrittenAbout =
        Namespaced_IRI.parse _namespace_name "isWrittenAbout" |> NamespacedName

    /// <summary>
    /// A relation of a specific issue, number, and/or volume and a periodical publication.
    /// <see href="http://www.ontotext.com/proton/protonext#issueOf"></see></summary>
    let issueOf = Namespaced_IRI.parse _namespace_name "issueOf" |> NamespacedName

    /// <summary>
    /// The relation between a geographic region and a map depicting its location
    /// <see href="http://www.ontotext.com/proton/protonext#locationMap"></see></summary>
    let locationMap =
        Namespaced_IRI.parse _namespace_name "locationMap" |> NamespacedName

    /// <summary>
    /// The name of a georgaphic region.
    /// <see href="http://www.ontotext.com/proton/protonext#locationName"></see></summary>
    let locationName =
        Namespaced_IRI.parse _namespace_name "locationName" |> NamespacedName

    /// <summary>
    /// The relation between a musician and the instrument he plays
    /// <see href="http://www.ontotext.com/proton/protonext#musicInstrument"></see></summary>
    let musicInstrument =
        Namespaced_IRI.parse _namespace_name "musicInstrument" |> NamespacedName

    /// <summary>
    /// The nationality of a person. The relation between a person and his nationality.
    /// <see href="http://www.ontotext.com/proton/protonext#nationalityOf"></see></summary>
    let nationalityOf =
        Namespaced_IRI.parse _namespace_name "nationalityOf" |> NamespacedName

    /// <summary>
    /// The relation of a location nearby another location
    /// <see href="http://www.ontotext.com/proton/protonext#nearby"></see></summary>
    let nearby = Namespaced_IRI.parse _namespace_name "nearby" |> NamespacedName
    /// <summary>
    /// The relation of a location sharing a common location with another location
    /// <see href="http://www.ontotext.com/proton/protonext#neighbour"></see></summary>
    let neighbour = Namespaced_IRI.parse _namespace_name "neighbour" |> NamespacedName
    /// <summary>
    /// The relation between a government organization and its country.
    /// <see href="http://www.ontotext.com/proton/protonext#ofCountry"></see></summary>
    let ofCountry = Namespaced_IRI.parse _namespace_name "ofCountry" |> NamespacedName

    /// <summary>
    /// This property models the Person-&gt;hasPosition-&gt;Location.
    /// <see href="http://www.ontotext.com/proton/protonext#officialPositionIn"></see></summary>
    let officialPositionIn =
        Namespaced_IRI.parse _namespace_name "officialPositionIn" |> NamespacedName

    /// <summary>
    /// The relation between an organization and a concrete job position in it.
    /// <see href="http://www.ontotext.com/proton/protonext#organizationPosition"></see></summary>
    let organizationPosition =
        Namespaced_IRI.parse _namespace_name "organizationPosition" |> NamespacedName

    /// <summary>
    /// The relationship between an object and an agent who owns it.
    /// <see href="http://www.ontotext.com/proton/protonext#ownerOf"></see></summary>
    let ownerOf = Namespaced_IRI.parse _namespace_name "ownerOf" |> NamespacedName

    /// <summary>
    /// The relationship between an object being a property/possessions of somebody.
    /// <see href="http://www.ontotext.com/proton/protonext#ownershipOf"></see></summary>
    let ownershipOf =
        Namespaced_IRI.parse _namespace_name "ownershipOf" |> NamespacedName

    /// <summary>
    /// Relation between the part of postal address and a given postal address.
    /// <see href="http://www.ontotext.com/proton/protonext#partOfPostalAddress"></see></summary>
    let partOfPostalAddress =
        Namespaced_IRI.parse _namespace_name "partOfPostalAddress" |> NamespacedName

    /// <summary>
    /// The relation between the scored point in a sport game and the sport club who won it.
    /// <see href="http://www.ontotext.com/proton/protonext#pointAwardedTo"></see></summary>
    let pointAwardedTo =
        Namespaced_IRI.parse _namespace_name "pointAwardedTo" |> NamespacedName

    /// <summary>
    /// The relation between a position and the contact information for it. This contact information can be the postal address of the office for the position or an virtual address in the Internet.
    /// <see href="http://www.ontotext.com/proton/protonext#positionContactInformation"></see></summary>
    let positionContactInformation =
        Namespaced_IRI.parse _namespace_name "positionContactInformation" |> NamespacedName

    /// <summary>
    /// The relation between the job position and the organization it is available in. The organization where the job position is available.
    /// <see href="http://www.ontotext.com/proton/protonext#positionWithinOrganization"></see></summary>
    let positionWithinOrganization =
        Namespaced_IRI.parse _namespace_name "positionWithinOrganization" |> NamespacedName

    /// <summary>
    /// The relation between a producer and the product produced. The producer is restricted to an organization, like Microsoft, Ford, GM, etc.
    /// <see href="http://www.ontotext.com/proton/protonext#productOf"></see></summary>
    let productOf = Namespaced_IRI.parse _namespace_name "productOf" |> NamespacedName

    /// <summary>
    /// A relation between an article and the colelction within which the article is published.
    /// <see href="http://www.ontotext.com/proton/protonext#publishedWithin"></see></summary>
    let publishedWithin =
        Namespaced_IRI.parse _namespace_name "publishedWithin" |> NamespacedName

    /// <summary>
    /// Name of the company on the Stock Exchange, where it is traded. At present, if a company is traded on two SEs with different indices, there is no way to encode which of them is applicable where.
    /// <see href="http://www.ontotext.com/proton/protonext#stockExchangeIndex"></see></summary>
    let stockExchangeIndex =
        Namespaced_IRI.parse _namespace_name "stockExchangeIndex" |> NamespacedName

    /// <summary>
    /// Relates the Public Company to the Stock Exchange where it is traded
    /// <see href="http://www.ontotext.com/proton/protonext#tradedOn"></see></summary>
    let tradedOn = Namespaced_IRI.parse _namespace_name "tradedOn" |> NamespacedName

    /// <summary>
    /// Describes the transmission type of a given car model
    /// <see href="http://www.ontotext.com/proton/protonext#transmission"></see></summary>
    let transmission =
        Namespaced_IRI.parse _namespace_name "transmission" |> NamespacedName
