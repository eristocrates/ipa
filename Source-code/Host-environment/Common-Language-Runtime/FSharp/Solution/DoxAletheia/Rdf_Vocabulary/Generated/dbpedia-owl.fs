namespace http.dbpedia.org.ontology.slash

open DoxAletheia

module dbpedia_owl =
    let _namespace_name = "http://dbpedia.org/ontology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An abbey is a Catholic monastery or convent, under the authority of an Abbot or an Abbess, who serves as the spiritual father or mother of the community.
    /// <see href="http://dbpedia.org/ontology/Abbey"></see></summary>
    let Abbey = _prefix "Abbey"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ReligiousBuilding"></see>
    /// </summary>
    let ReligiousBuilding = _prefix "ReligiousBuilding"
    /// <summary>
    /// Monastery denotes the building, or complex of buildings, comprising the domestic quarters and workplace(s) of monastics, whether monks or nuns, and whether living in community or alone (hermits). The monastery generally includes a place reserved for prayer which may be a chapel, church or temple, and may also serve as an oratory.
    /// <see href="http://dbpedia.org/ontology/Monastery"></see></summary>
    let Monastery = _prefix "Monastery"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AcademicConference"></see>
    /// </summary>
    let AcademicConference = _prefix "AcademicConference"
    /// <summary>
    /// an event that is clearly different from strictly personal events
    /// <see href="http://dbpedia.org/ontology/SocietalEvent"></see></summary>
    let SocietalEvent = _prefix "SocietalEvent"
    /// <summary>
    /// An academic journal is a mostly peer-reviewed periodical in which scholarship relating to a particular academic discipline is published. Academic journals serve as forums for the introduction and presentation for scrutiny of new research, and the critique of existing research. Content typically takes the form of articles presenting original research, review articles, and book reviews.
    /// <see href="http://dbpedia.org/ontology/AcademicJournal"></see></summary>
    let AcademicJournal = _prefix "AcademicJournal"
    /// <summary>
    /// Periodical literature (also called a periodical publication or simply a periodical) is a published work that appears in a new edition on a regular schedule. The most familiar examples are the newspaper, often published daily, or weekly; or the magazine, typically published weekly, monthly or as a quarterly. Other examples would be a newsletter, a literary journal or learned journal, or a yearbook.
    /// <see href="http://dbpedia.org/ontology/PeriodicalLiterature"></see></summary>
    let PeriodicalLiterature = _prefix "PeriodicalLiterature"
    /// <summary>
    /// Genres of art, e.g. Mathematics, History, Philosophy, Medicine
    /// <see href="http://dbpedia.org/ontology/AcademicSubject"></see></summary>
    let AcademicSubject = _prefix "AcademicSubject"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TopicalConcept"></see>
    /// </summary>
    let TopicalConcept = _prefix "TopicalConcept"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Activity"></see>
    /// </summary>
    let Activity = _prefix "Activity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    /// An actor or actress is a person who acts in a dramatic production and who works in film, television, theatre, or radio in that capacity.
    /// <see href="http://dbpedia.org/ontology/Actor"></see></summary>
    let Actor = _prefix "Actor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Artist"></see>
    /// </summary>
    let Artist = _prefix "Artist"
    /// <summary>
    /// A PopulatedPlace under the jurisdiction of an administrative body. This body may administer either a whole region or one or more adjacent Settlements (town administration)
    /// <see href="http://dbpedia.org/ontology/AdministrativeRegion"></see></summary>
    let AdministrativeRegion = _prefix "AdministrativeRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Region"></see>
    /// </summary>
    let Region = _prefix "Region"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/%3Chttp://purl.org/dc/terms/Jurisdiction%3E"></see>
    /// </summary>
    let ``_%3Chttp://purl.org/dc/terms/Jurisdiction%3E`` =
        _prefix "%3Chttp://purl.org/dc/terms/Jurisdiction%3E"

    /// <summary>
    /// A pornographic actor or actress or a porn star is a person who performs sex acts in film, normally characterised as a pornographic film.
    /// <see href="http://dbpedia.org/ontology/AdultActor"></see></summary>
    let AdultActor = _prefix "AdultActor"
    /// <summary>
    /// Analogous to a foaf:Agent, an agent is an entity that acts. This is intended to be the super class of Person and Organisation.
    /// <see href="http://dbpedia.org/ontology/Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Immobile things or locations.
    /// <see href="http://dbpedia.org/ontology/Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Agglomeration"></see>
    /// </summary>
    let Agglomeration = _prefix "Agglomeration"
    /// <summary>
    /// As defined by the United States Geological Survey, a populated place is a place or area with clustered or scattered buildings and a permanent human population (city, settlement, town, or village) referenced with geographic coordinates (http://en.wikipedia.org/wiki/Populated_place).
    /// <see href="http://dbpedia.org/ontology/PopulatedPlace"></see></summary>
    let PopulatedPlace = _prefix "PopulatedPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Aircraft"></see>
    /// </summary>
    let Aircraft = _prefix "Aircraft"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation"></see>
    /// </summary>
    let MeanOfTransportation = _prefix "MeanOfTransportation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Airline"></see>
    /// </summary>
    let Airline = _prefix "Airline"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Company"></see>
    /// </summary>
    let Company = _prefix "Company"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Airport"></see>
    /// </summary>
    let Airport = _prefix "Airport"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Infrastructure"></see>
    /// </summary>
    let Infrastructure = _prefix "Infrastructure"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Album"></see>
    /// </summary>
    let Album = _prefix "Album"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MusicalWork"></see>
    /// </summary>
    let MusicalWork = _prefix "MusicalWork"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Altitude"></see>
    /// </summary>
    let Altitude = _prefix "Altitude"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AmateurBoxer"></see>
    /// </summary>
    let AmateurBoxer = _prefix "AmateurBoxer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Boxer"></see>
    /// </summary>
    let Boxer = _prefix "Boxer"
    /// <summary>
    /// An ambassador is the highest ranking diplomat that represents a nation and is usually accredited to a foreign sovereign or government, or to an international organization.
    /// <see href="http://dbpedia.org/ontology/Ambassador"></see></summary>
    let Ambassador = _prefix "Ambassador"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AmericanFootballCoach"></see>
    /// </summary>
    let AmericanFootballCoach = _prefix "AmericanFootballCoach"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Coach"></see>
    /// </summary>
    let Coach = _prefix "Coach"
    /// <summary>
    /// A group of sports teams that compete against each other in american football.
    /// <see href="http://dbpedia.org/ontology/AmericanFootballLeague"></see></summary>
    let AmericanFootballLeague = _prefix "AmericanFootballLeague"
    /// <summary>
    /// A group of sports teams or individual athletes that compete against each other in a specific sport.
    /// <see href="http://dbpedia.org/ontology/SportsLeague"></see></summary>
    let SportsLeague = _prefix "SportsLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AmericanFootballPlayer"></see>
    /// </summary>
    let AmericanFootballPlayer = _prefix "AmericanFootballPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GridironFootballPlayer"></see>
    /// </summary>
    let GridironFootballPlayer = _prefix "GridironFootballPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AmericanFootballTeam"></see>
    /// </summary>
    let AmericanFootballTeam = _prefix "AmericanFootballTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SportsTeam"></see>
    /// </summary>
    let SportsTeam = _prefix "SportsTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Amphibian"></see>
    /// </summary>
    let Amphibian = _prefix "Amphibian"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Animal"></see>
    /// </summary>
    let Animal = _prefix "Animal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AmusementParkAttraction"></see>
    /// </summary>
    let AmusementParkAttraction = _prefix "AmusementParkAttraction"
    /// <summary>
    /// An architectural structure is a human-made, free-standing, immobile outdoor construction (http://en.wikipedia.org/wiki/Architectural_structure).
    /// <see href="http://dbpedia.org/ontology/ArchitecturalStructure"></see></summary>
    let ArchitecturalStructure = _prefix "ArchitecturalStructure"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AnatomicalStructure"></see>
    /// </summary>
    let AnatomicalStructure = _prefix "AnatomicalStructure"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Eukaryote"></see>
    /// </summary>
    let Eukaryote = _prefix "Eukaryote"
    /// <summary>
    /// Anime/Manga character
    /// <see href="http://dbpedia.org/ontology/AnimangaCharacter"></see></summary>
    let AnimangaCharacter = _prefix "AnimangaCharacter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ComicsCharacter"></see>
    /// </summary>
    let ComicsCharacter = _prefix "ComicsCharacter"
    /// <summary>
    /// A style of animation originating in Japan
    /// <see href="http://dbpedia.org/ontology/Anime"></see></summary>
    let Anime = _prefix "Anime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cartoon"></see>
    /// </summary>
    let Cartoon = _prefix "Cartoon"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Annotation"></see>
    /// </summary>
    let Annotation = _prefix "Annotation"
    /// <summary>
    /// Written work is any text written to read it (e.g.: books, newspaper, articles)
    /// <see href="http://dbpedia.org/ontology/WrittenWork"></see></summary>
    let WrittenWork = _prefix "WrittenWork"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Arachnid"></see>
    /// </summary>
    let Arachnid = _prefix "Arachnid"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Archaea"></see>
    /// </summary>
    let Archaea = _prefix "Archaea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Species"></see>
    /// </summary>
    let Species = _prefix "Species"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Archeologist"></see>
    /// </summary>
    let Archeologist = _prefix "Archeologist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ArcherPlayer"></see>
    /// </summary>
    let ArcherPlayer = _prefix "ArcherPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Athlete"></see>
    /// </summary>
    let Athlete = _prefix "Athlete"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Archipelago"></see>
    /// </summary>
    let Archipelago = _prefix "Archipelago"
    /// <summary>
    /// The natural place encompasses all places occurring naturally in universe.
    /// <see href="http://dbpedia.org/ontology/NaturalPlace"></see></summary>
    let NaturalPlace = _prefix "NaturalPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Architect"></see>
    /// </summary>
    let Architect = _prefix "Architect"
    /// <summary>
    /// Collection of documents pertaining to a person or organisation.
    /// <see href="http://dbpedia.org/ontology/Archive"></see></summary>
    let Archive = _prefix "Archive"
    /// <summary>
    /// Collection of valuables is a collection considered to be a work in itself)
    /// <see href="http://dbpedia.org/ontology/CollectionOfValuables"></see></summary>
    let CollectionOfValuables = _prefix "CollectionOfValuables"
    /// <summary>
    /// Area of something. Use "value" for the value, "min" &amp; "max" for a range (if uncertain) and "rank" (integer) for the rank of that thing amongst its siblings (eg regions ordered by area)
    /// <see href="http://dbpedia.org/ontology/Area"></see></summary>
    let Area = _prefix "Area"
    /// <summary>
    /// An arena is an enclosed area, often circular or oval-shaped, designed to showcase theater, musical performances, or sporting events. (http://en.wikipedia.org/wiki/Arena)
    /// <see href="http://dbpedia.org/ontology/Arena"></see></summary>
    let Arena = _prefix "Arena"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Aristocrat"></see>
    /// </summary>
    let Aristocrat = _prefix "Aristocrat"
    /// <summary>
    /// An administrative (France) or lawcourts (Netherlands) body governing a territorial unity on the intermediate level, between local and national level
    /// <see href="http://dbpedia.org/ontology/Arrondissement"></see></summary>
    let Arrondissement = _prefix "Arrondissement"
    /// <summary>
    /// An administrative body governing some territorial unity, in this case a governmental administrative body
    /// <see href="http://dbpedia.org/ontology/GovernmentalAdministrativeRegion"></see></summary>
    let GovernmentalAdministrativeRegion = _prefix "GovernmentalAdministrativeRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Artery"></see>
    /// </summary>
    let Artery = _prefix "Artery"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Article"></see>
    /// </summary>
    let Article = _prefix "Article"
    /// <summary>
    /// In the context of spaceflight, an artificial satellite is an artificial object which has been intentionally placed into orbit.
    /// <see href="http://dbpedia.org/ontology/ArtificialSatellite"></see></summary>
    let ArtificialSatellite = _prefix "ArtificialSatellite"
    /// <summary>
    /// An astronomic object orbiting around a planet or star. Definition partly derived from http://www.ontotext.com/proton/protonext# (and thus WordNet 1.7).
    /// <see href="http://dbpedia.org/ontology/Satellite"></see></summary>
    let Satellite = _prefix "Satellite"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ArtistDiscography"></see>
    /// </summary>
    let ArtistDiscography = _prefix "ArtistDiscography"
    /// <summary>
    /// Genres of art, e.g. Pointillist, Modernist
    /// <see href="http://dbpedia.org/ontology/ArtisticGenre"></see></summary>
    let ArtisticGenre = _prefix "ArtisticGenre"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Genre"></see>
    /// </summary>
    let Genre = _prefix "Genre"
    /// <summary>
    /// A work of art, artwork, art piece, or art object is an aesthetic item or artistic creation.
    /// <see href="http://dbpedia.org/ontology/Artwork"></see></summary>
    let Artwork = _prefix "Artwork"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Work"></see>
    /// </summary>
    let Work = _prefix "Work"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Asteroid"></see>
    /// </summary>
    let Asteroid = _prefix "Asteroid"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CelestialBody"></see>
    /// </summary>
    let CelestialBody = _prefix "CelestialBody"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Astronaut"></see>
    /// </summary>
    let Astronaut = _prefix "Astronaut"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Astronaut/timeInSpace"></see>
    /// </summary>
    let ``Astronaut/timeInSpace`` = _prefix "Astronaut/timeInSpace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Athletics"></see>
    /// </summary>
    let Athletics = _prefix "Athletics"
    /// <summary>
    /// A sport is commonly defined as an organized, competitive, and skillful physical activity.
    /// <see href="http://dbpedia.org/ontology/Sport"></see></summary>
    let Sport = _prefix "Sport"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AthleticsPlayer"></see>
    /// </summary>
    let AthleticsPlayer = _prefix "AthleticsPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Atoll"></see>
    /// </summary>
    let Atoll = _prefix "Atoll"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Island"></see>
    /// </summary>
    let Island = _prefix "Island"
    /// <summary>
    /// An Attack is not necessarily part of a Military Conflict
    /// <see href="http://dbpedia.org/ontology/Attack"></see></summary>
    let Attack = _prefix "Attack"
    /// <summary>
    /// A group of sports teams that compete against each other in australian football.
    /// <see href="http://dbpedia.org/ontology/AustralianFootballLeague"></see></summary>
    let AustralianFootballLeague = _prefix "AustralianFootballLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AustralianFootballTeam"></see>
    /// </summary>
    let AustralianFootballTeam = _prefix "AustralianFootballTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AustralianRulesFootballPlayer"></see>
    /// </summary>
    let AustralianRulesFootballPlayer = _prefix "AustralianRulesFootballPlayer"
    /// <summary>
    /// a group of sports teams or individual athletes that compete against each other in auto racing
    /// <see href="http://dbpedia.org/ontology/AutoRacingLeague"></see></summary>
    let AutoRacingLeague = _prefix "AutoRacingLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Automobile"></see>
    /// </summary>
    let Automobile = _prefix "Automobile"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Automobile/fuelCapacity"></see>
    /// </summary>
    let ``Automobile/fuelCapacity`` = _prefix "Automobile/fuelCapacity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Automobile/wheelbase"></see>
    /// </summary>
    let ``Automobile/wheelbase`` = _prefix "Automobile/wheelbase"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AutomobileEngine"></see>
    /// </summary>
    let AutomobileEngine = _prefix "AutomobileEngine"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine"></see>
    /// </summary>
    let Engine = _prefix "Engine"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Award"></see>
    /// </summary>
    let Award = _prefix "Award"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BackScene"></see>
    /// </summary>
    let BackScene = _prefix "BackScene"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MusicalArtist"></see>
    /// </summary>
    let MusicalArtist = _prefix "MusicalArtist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Bacteria"></see>
    /// </summary>
    let Bacteria = _prefix "Bacteria"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BadmintonPlayer"></see>
    /// </summary>
    let BadmintonPlayer = _prefix "BadmintonPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Band"></see>
    /// </summary>
    let Band = _prefix "Band"
    /// <summary>
    /// An (informal) group of people.
    /// <see href="http://dbpedia.org/ontology/Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// a company which main services are banking or financial services.
    /// <see href="http://dbpedia.org/ontology/Bank"></see></summary>
    let Bank = _prefix "Bank"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Baronet"></see>
    /// </summary>
    let Baronet = _prefix "Baronet"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BritishRoyalty"></see>
    /// </summary>
    let BritishRoyalty = _prefix "BritishRoyalty"
    /// <summary>
    /// a group of sports teams that compete against each other in Baseball.
    /// <see href="http://dbpedia.org/ontology/BaseballLeague"></see></summary>
    let BaseballLeague = _prefix "BaseballLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BaseballPlayer"></see>
    /// </summary>
    let BaseballPlayer = _prefix "BaseballPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BaseballSeason"></see>
    /// </summary>
    let BaseballSeason = _prefix "BaseballSeason"
    /// <summary>
    /// A season for a particular sports team (as opposed to the season for the entire league that the team is in)
    /// <see href="http://dbpedia.org/ontology/SportsTeamSeason"></see></summary>
    let SportsTeamSeason = _prefix "SportsTeamSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BaseballTeam"></see>
    /// </summary>
    let BaseballTeam = _prefix "BaseballTeam"
    /// <summary>
    /// a group of sports teams that compete against each other in Basketball
    /// <see href="http://dbpedia.org/ontology/BasketballLeague"></see></summary>
    let BasketballLeague = _prefix "BasketballLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BasketballPlayer"></see>
    /// </summary>
    let BasketballPlayer = _prefix "BasketballPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BasketballTeam"></see>
    /// </summary>
    let BasketballTeam = _prefix "BasketballTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Bay"></see>
    /// </summary>
    let Bay = _prefix "Bay"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BodyOfWater"></see>
    /// </summary>
    let BodyOfWater = _prefix "BodyOfWater"
    /// <summary>
    /// The shore of a body of water, especially when sandy or pebbly.
    /// <see href="http://dbpedia.org/ontology/Beach"></see></summary>
    let Beach = _prefix "Beach"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BeachVolleyballPlayer"></see>
    /// </summary>
    let BeachVolleyballPlayer = _prefix "BeachVolleyballPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/VolleyballPlayer"></see>
    /// </summary>
    let VolleyballPlayer = _prefix "VolleyballPlayer"
    /// <summary>
    /// A beauty pageant titleholder
    /// <see href="http://dbpedia.org/ontology/BeautyQueen"></see></summary>
    let BeautyQueen = _prefix "BeautyQueen"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Beer"></see>
    /// </summary>
    let Beer = _prefix "Beer"
    /// <summary>
    /// A drink, or beverage, is a liquid which is specifically prepared for human consumption.
    /// <see href="http://dbpedia.org/ontology/Beverage"></see></summary>
    let Beverage = _prefix "Beverage"
    /// <summary>
    /// Food is any eatable or drinkable substance that is normally consumed by humans.
    /// <see href="http://dbpedia.org/ontology/Food"></see></summary>
    let Food = _prefix "Food"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Biathlete"></see>
    /// </summary>
    let Biathlete = _prefix "Biathlete"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WinterSportPlayer"></see>
    /// </summary>
    let WinterSportPlayer = _prefix "WinterSportPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BiologicalDatabase"></see>
    /// </summary>
    let BiologicalDatabase = _prefix "BiologicalDatabase"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Database"></see>
    /// </summary>
    let Database = _prefix "Database"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Biologist"></see>
    /// </summary>
    let Biologist = _prefix "Biologist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Scientist"></see>
    /// </summary>
    let Scientist = _prefix "Scientist"
    /// <summary>
    /// equivalent to http://ccdb.ucsd.edu/NIF/BIRNLex-OBO-UBO.owl#birnlex_22.
    /// <see href="http://dbpedia.org/ontology/Biomolecule"></see></summary>
    let Biomolecule = _prefix "Biomolecule"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Bird"></see>
    /// </summary>
    let Bird = _prefix "Bird"
    /// <summary>
    /// someone's birth as a type of personal event
    /// <see href="http://dbpedia.org/ontology/Birth"></see></summary>
    let Birth = _prefix "Birth"
    /// <summary>
    /// an event that occurs in someone's personal life
    /// <see href="http://dbpedia.org/ontology/PersonalEvent"></see></summary>
    let PersonalEvent = _prefix "PersonalEvent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Blazon"></see>
    /// </summary>
    let Blazon = _prefix "Blazon"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BloodVessel"></see>
    /// </summary>
    let BloodVessel = _prefix "BloodVessel"
    /// <summary>
    /// come from http://en.wikipedia.org/wiki/Category:Board_games
    /// <see href="http://dbpedia.org/ontology/BoardGame"></see></summary>
    let BoardGame = _prefix "BoardGame"
    /// <summary>
    /// a structured activity, usually undertaken for enjoyment and sometimes used as an educational tool
    /// <see href="http://dbpedia.org/ontology/Game"></see></summary>
    let Game = _prefix "Game"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BobsleighAthlete"></see>
    /// </summary>
    let BobsleighAthlete = _prefix "BobsleighAthlete"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Bodybuilder"></see>
    /// </summary>
    let Bodybuilder = _prefix "Bodybuilder"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Bone"></see>
    /// </summary>
    let Bone = _prefix "Bone"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Book"></see>
    /// </summary>
    let Book = _prefix "Book"
    /// <summary>
    /// a group of sports teams or players that compete against each other in Bowling
    /// <see href="http://dbpedia.org/ontology/BowlingLeague"></see></summary>
    let BowlingLeague = _prefix "BowlingLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Boxing"></see>
    /// </summary>
    let Boxing = _prefix "Boxing"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BoxingCategory"></see>
    /// </summary>
    let BoxingCategory = _prefix "BoxingCategory"
    /// <summary>
    /// A group of sports teams or fighters that compete against each other in Boxing
    /// <see href="http://dbpedia.org/ontology/BoxingLeague"></see></summary>
    let BoxingLeague = _prefix "BoxingLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BoxingStyle"></see>
    /// </summary>
    let BoxingStyle = _prefix "BoxingStyle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Brain"></see>
    /// </summary>
    let Brain = _prefix "Brain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Brewery"></see>
    /// </summary>
    let Brewery = _prefix "Brewery"
    /// <summary>
    /// A bridge is a structure built to span physical obstacles such as a body of water, valley, or road, for the purpose of providing passage over the obstacle (http://en.wikipedia.org/wiki/Bridge).
    /// <see href="http://dbpedia.org/ontology/Bridge"></see></summary>
    let Bridge = _prefix "Bridge"
    /// <summary>
    /// A route of transportation (thoroughfare) may refer to a public road, highway, path or trail or a route on water from one place to another for use by a variety of general traffic (http://en.wikipedia.org/wiki/Thoroughfare).
    /// <see href="http://dbpedia.org/ontology/RouteOfTransportation"></see></summary>
    let RouteOfTransportation = _prefix "RouteOfTransportation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Royalty"></see>
    /// </summary>
    let Royalty = _prefix "Royalty"
    /// <summary>
    /// A broadcast network is an organization, such as a corporation or other association, that provides live or recorded content, such as movies, newscasts, sports, and public affairs programs for broadcast over a group of radio or television stations. (http://en.wikipedia.org/wiki/Broadcast_network - 28/03/2011)
    /// <see href="http://dbpedia.org/ontology/BroadcastNetwork"></see></summary>
    let BroadcastNetwork = _prefix "BroadcastNetwork"
    /// <summary>
    /// A broadcaster is an organisation responsible for the production of radio or television programs and/or their transmission. (http://en.wikipedia.org/wiki/Broadcaster - 28/03/2011)
    /// <see href="http://dbpedia.org/ontology/Broadcaster"></see></summary>
    let Broadcaster = _prefix "Broadcaster"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Organisation"></see>
    /// </summary>
    let Organisation = _prefix "Organisation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BrownDwarf"></see>
    /// </summary>
    let BrownDwarf = _prefix "BrownDwarf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Star"></see>
    /// </summary>
    let Star = _prefix "Star"
    /// <summary>
    /// Building is defined as a Civil Engineering structure such as a house, worship center, factory etc. that has a foundation, wall, roof etc. that protect human being and their properties from direct harsh effect of weather like rain, wind, sun etc. (http://en.wikipedia.org/wiki/Building).
    /// <see href="http://dbpedia.org/ontology/Building"></see></summary>
    let Building = _prefix "Building"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Building/floorArea"></see>
    /// </summary>
    let ``Building/floorArea`` = _prefix "Building/floorArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BullFighter"></see>
    /// </summary>
    let BullFighter = _prefix "BullFighter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BusCompany"></see>
    /// </summary>
    let BusCompany = _prefix "BusCompany"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BusinessPerson"></see>
    /// </summary>
    let BusinessPerson = _prefix "BusinessPerson"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Camera"></see>
    /// </summary>
    let Camera = _prefix "Camera"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Device"></see>
    /// </summary>
    let Device = _prefix "Device"
    /// <summary>
    /// A group of sports teams that compete against each other in canadian football league.
    /// <see href="http://dbpedia.org/ontology/CanadianFootballLeague"></see></summary>
    let CanadianFootballLeague = _prefix "CanadianFootballLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CanadianFootballPlayer"></see>
    /// </summary>
    let CanadianFootballPlayer = _prefix "CanadianFootballPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CanadianFootballTeam"></see>
    /// </summary>
    let CanadianFootballTeam = _prefix "CanadianFootballTeam"
    /// <summary>
    /// a man-made channel for water
    /// <see href="http://dbpedia.org/ontology/Canal"></see></summary>
    let Canal = _prefix "Canal"
    /// <summary>
    /// a flowing body of water with a current, confined within a bed and stream banks
    /// <see href="http://dbpedia.org/ontology/Stream"></see></summary>
    let Stream = _prefix "Stream"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Canal/maximumBoatBeam"></see>
    /// </summary>
    let ``Canal/maximumBoatBeam`` = _prefix "Canal/maximumBoatBeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Canal/maximumBoatLength"></see>
    /// </summary>
    let ``Canal/maximumBoatLength`` = _prefix "Canal/maximumBoatLength"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Canal/originalMaximumBoatBeam"></see>
    /// </summary>
    let ``Canal/originalMaximumBoatBeam`` = _prefix "Canal/originalMaximumBoatBeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Canal/originalMaximumBoatLength"></see>
    /// </summary>
    let ``Canal/originalMaximumBoatLength`` = _prefix "Canal/originalMaximumBoatLength"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Canoeist"></see>
    /// </summary>
    let Canoeist = _prefix "Canoeist"
    /// <summary>
    /// An administrative (France) or lawcourts (Netherlands) body governing a territorial unity on the municipal level or somewhat above
    /// <see href="http://dbpedia.org/ontology/Canton"></see></summary>
    let Canton = _prefix "Canton"
    /// <summary>
    /// A municipality enjoying primary status in a state, country, province, or other region as its seat of government.
    /// <see href="http://dbpedia.org/ontology/Capital"></see></summary>
    let Capital = _prefix "Capital"
    /// <summary>
    /// a relatively large and permanent settlement, particularly a large urban settlement
    /// <see href="http://dbpedia.org/ontology/City"></see></summary>
    let City = _prefix "City"
    /// <summary>
    /// seat of a first order administration division.
    /// <see href="http://dbpedia.org/ontology/CapitalOfRegion"></see></summary>
    let CapitalOfRegion = _prefix "CapitalOfRegion"
    /// <summary>
    /// come from http://en.wikipedia.org/wiki/Category:Card_games
    /// <see href="http://dbpedia.org/ontology/CardGame"></see></summary>
    let CardGame = _prefix "CardGame"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cardinal"></see>
    /// </summary>
    let Cardinal = _prefix "Cardinal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cleric"></see>
    /// </summary>
    let Cleric = _prefix "Cleric"
    /// <summary>
    /// One of the four main directions on a compass or any other system to determine a geographical position
    /// <see href="http://dbpedia.org/ontology/CardinalDirection"></see></summary>
    let CardinalDirection = _prefix "CardinalDirection"
    /// <summary>
    /// this class marks a career step in the life of a person, e.g. a soccer player, holding information on the time span, matches and goals he or she achieved at a certain club
    /// <see href="http://dbpedia.org/ontology/CareerStation"></see></summary>
    let CareerStation = _prefix "CareerStation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TimePeriod"></see>
    /// </summary>
    let TimePeriod = _prefix "TimePeriod"
    /// <summary>
    /// A case is the total of work done to prepare for an administrative or business decision. As a rule, a case is reflected in a set of documents.
    /// <see href="http://dbpedia.org/ontology/Case"></see></summary>
    let Case = _prefix "Case"
    /// <summary>
    /// This class is meant to convey the notion of an amount work to be done. It is different from Activity in that it has a definite end and is being measured.
    /// <see href="http://dbpedia.org/ontology/UnitOfWork"></see></summary>
    let UnitOfWork = _prefix "UnitOfWork"
    /// <summary>
    /// In modern English, a casino is a facility which houses and accommodates certain types of gambling activities.
    /// <see href="http://dbpedia.org/ontology/Casino"></see></summary>
    let Casino = _prefix "Casino"
    /// <summary>
    /// Castles often are, but need not be a military structure. They can serve for status, pleasure and hunt as well.
    /// <see href="http://dbpedia.org/ontology/Castle"></see></summary>
    let Castle = _prefix "Castle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cat"></see>
    /// </summary>
    let Cat = _prefix "Cat"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Mammal"></see>
    /// </summary>
    let Mammal = _prefix "Mammal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Caterer"></see>
    /// </summary>
    let Caterer = _prefix "Caterer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cave"></see>
    /// </summary>
    let Cave = _prefix "Cave"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Celebrity"></see>
    /// </summary>
    let Celebrity = _prefix "Celebrity"
    /// <summary>
    /// A burial place
    /// <see href="http://dbpedia.org/ontology/Cemetery"></see></summary>
    let Cemetery = _prefix "Cemetery"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Chancellor"></see>
    /// </summary>
    let Chancellor = _prefix "Chancellor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Politician"></see>
    /// </summary>
    let Politician = _prefix "Politician"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChartsPlacements"></see>
    /// </summary>
    let ChartsPlacements = _prefix "ChartsPlacements"
    /// <summary>
    /// A milk product prepared for human consumption
    /// <see href="http://dbpedia.org/ontology/Cheese"></see></summary>
    let Cheese = _prefix "Cheese"
    /// <summary>
    /// a person who cooks professionally for other people
    /// <see href="http://dbpedia.org/ontology/Chef"></see></summary>
    let Chef = _prefix "Chef"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChemicalCompound"></see>
    /// </summary>
    let ChemicalCompound = _prefix "ChemicalCompound"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChemicalSubstance"></see>
    /// </summary>
    let ChemicalSubstance = _prefix "ChemicalSubstance"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChemicalElement"></see>
    /// </summary>
    let ChemicalElement = _prefix "ChemicalElement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChemicalSubstance/boilingPoint"></see>
    /// </summary>
    let ``ChemicalSubstance/boilingPoint`` = _prefix "ChemicalSubstance/boilingPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChemicalSubstance/density"></see>
    /// </summary>
    let ``ChemicalSubstance/density`` = _prefix "ChemicalSubstance/density"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChemicalSubstance/meltingPoint"></see>
    /// </summary>
    let ``ChemicalSubstance/meltingPoint`` = _prefix "ChemicalSubstance/meltingPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChessPlayer"></see>
    /// </summary>
    let ChessPlayer = _prefix "ChessPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChristianBishop"></see>
    /// </summary>
    let ChristianBishop = _prefix "ChristianBishop"
    /// <summary>
    /// Tenets of the Christian faith, e.g. Trinity, Nicene Creed
    /// <see href="http://dbpedia.org/ontology/ChristianDoctrine"></see></summary>
    let ChristianDoctrine = _prefix "ChristianDoctrine"
    /// <summary>
    /// Theological concepts, e.g. The apocalypse, Trinty, Stoicism
    /// <see href="http://dbpedia.org/ontology/TheologicalConcept"></see></summary>
    let TheologicalConcept = _prefix "TheologicalConcept"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChristianPatriarch"></see>
    /// </summary>
    let ChristianPatriarch = _prefix "ChristianPatriarch"
    /// <summary>
    /// This is used for church buildings, not any other meaning of church.
    /// <see href="http://dbpedia.org/ontology/Church"></see></summary>
    let Church = _prefix "Church"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Settlement"></see>
    /// </summary>
    let Settlement = _prefix "Settlement"
    /// <summary>
    /// District, borough, area or neighbourhood in a city or town
    /// <see href="http://dbpedia.org/ontology/CityDistrict"></see></summary>
    let CityDistrict = _prefix "CityDistrict"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ClassicalMusicArtist"></see>
    /// </summary>
    let ClassicalMusicArtist = _prefix "ClassicalMusicArtist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ClassicalMusicComposition"></see>
    /// </summary>
    let ClassicalMusicComposition = _prefix "ClassicalMusicComposition"
    /// <summary>
    /// An administrative body governing some territorial unity, in this case a clerical administrative body
    /// <see href="http://dbpedia.org/ontology/ClericalAdministrativeRegion"></see></summary>
    let ClericalAdministrativeRegion = _prefix "ClericalAdministrativeRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ClericalOrder"></see>
    /// </summary>
    let ClericalOrder = _prefix "ClericalOrder"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ReligiousOrganisation"></see>
    /// </summary>
    let ReligiousOrganisation = _prefix "ReligiousOrganisation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ClubMoss"></see>
    /// </summary>
    let ClubMoss = _prefix "ClubMoss"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Plant"></see>
    /// </summary>
    let Plant = _prefix "Plant"
    /// <summary>
    /// A coal pit is a place where charcoal is or was extracted
    /// <see href="http://dbpedia.org/ontology/CoalPit"></see></summary>
    let CoalPit = _prefix "CoalPit"
    /// <summary>
    /// A mine is a place where mineral resources are or were extracted
    /// <see href="http://dbpedia.org/ontology/Mine"></see></summary>
    let Mine = _prefix "Mine"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/College"></see>
    /// </summary>
    let College = _prefix "College"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/EducationalInstitution"></see>
    /// </summary>
    let EducationalInstitution = _prefix "EducationalInstitution"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CollegeCoach"></see>
    /// </summary>
    let CollegeCoach = _prefix "CollegeCoach"
    /// <summary>
    /// Color or colour is the visual perceptual property corresponding in humans to the categories called red, yellow, blue and others. Color derives from the spectrum of light (distribution of light energy versus wavelength) interacting in the eye with the spectral sensitivities of the light receptors.
    /// <see href="http://dbpedia.org/ontology/Colour"></see></summary>
    let Colour = _prefix "Colour"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Comedian"></see>
    /// </summary>
    let Comedian = _prefix "Comedian"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ComedyGroup"></see>
    /// </summary>
    let ComedyGroup = _prefix "ComedyGroup"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Comic"></see>
    /// </summary>
    let Comic = _prefix "Comic"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ComicStrip"></see>
    /// </summary>
    let ComicStrip = _prefix "ComicStrip"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FictionalCharacter"></see>
    /// </summary>
    let FictionalCharacter = _prefix "FictionalCharacter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ComicsCreator"></see>
    /// </summary>
    let ComicsCreator = _prefix "ComicsCreator"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Community"></see>
    /// </summary>
    let Community = _prefix "Community"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Competition"></see>
    /// </summary>
    let Competition = _prefix "Competition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConcentrationCamp"></see>
    /// </summary>
    let ConcentrationCamp = _prefix "ConcentrationCamp"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Congressman"></see>
    /// </summary>
    let Congressman = _prefix "Congressman"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Conifer"></see>
    /// </summary>
    let Conifer = _prefix "Conifer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Constellation"></see>
    /// </summary>
    let Constellation = _prefix "Constellation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Contest"></see>
    /// </summary>
    let Contest = _prefix "Contest"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Continent"></see>
    /// </summary>
    let Continent = _prefix "Continent"
    /// <summary>
    /// A quality assurance label for wines
    /// <see href="http://dbpedia.org/ontology/ControlledDesignationOfOriginWine"></see></summary>
    let ControlledDesignationOfOriginWine = _prefix "ControlledDesignationOfOriginWine"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Wine"></see>
    /// </summary>
    let Wine = _prefix "Wine"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Convention"></see>
    /// </summary>
    let Convention = _prefix "Convention"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem"></see>
    /// </summary>
    let ConveyorSystem = _prefix "ConveyorSystem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation"></see>
    /// </summary>
    let ``On-SiteTransportation`` = _prefix "On-SiteTransportation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem/diameter"></see>
    /// </summary>
    let ``ConveyorSystem/diameter`` = _prefix "ConveyorSystem/diameter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem/height"></see>
    /// </summary>
    let ``ConveyorSystem/height`` = _prefix "ConveyorSystem/height"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem/length"></see>
    /// </summary>
    let ``ConveyorSystem/length`` = _prefix "ConveyorSystem/length"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem/mass"></see>
    /// </summary>
    let ``ConveyorSystem/mass`` = _prefix "ConveyorSystem/mass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem/weight"></see>
    /// </summary>
    let ``ConveyorSystem/weight`` = _prefix "ConveyorSystem/weight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem/width"></see>
    /// </summary>
    let ``ConveyorSystem/width`` = _prefix "ConveyorSystem/width"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Country"></see>
    /// </summary>
    let Country = _prefix "Country"
    /// <summary>
    /// A country seat is a rural patch of land owned by a land owner.
    /// <see href="http://dbpedia.org/ontology/CountrySeat"></see></summary>
    let CountrySeat = _prefix "CountrySeat"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Crater"></see>
    /// </summary>
    let Crater = _prefix "Crater"
    /// <summary>
    /// the portion of a stream that is affected by ebb and flow of ocean tides
    /// <see href="http://dbpedia.org/ontology/Creek"></see></summary>
    let Creek = _prefix "Creek"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CricketGround"></see>
    /// </summary>
    let CricketGround = _prefix "CricketGround"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SportFacility"></see>
    /// </summary>
    let SportFacility = _prefix "SportFacility"
    /// <summary>
    /// a group of sports teams that compete against each other in Cricket
    /// <see href="http://dbpedia.org/ontology/CricketLeague"></see></summary>
    let CricketLeague = _prefix "CricketLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CricketTeam"></see>
    /// </summary>
    let CricketTeam = _prefix "CricketTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cricketer"></see>
    /// </summary>
    let Cricketer = _prefix "Cricketer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Criminal"></see>
    /// </summary>
    let Criminal = _prefix "Criminal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CrossCountrySkier"></see>
    /// </summary>
    let CrossCountrySkier = _prefix "CrossCountrySkier"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Crustacean"></see>
    /// </summary>
    let Crustacean = _prefix "Crustacean"
    /// <summary>
    /// A cultivar is a plant or grouping of plants selected for desirable characteristics that can be maintained by propagation. A plant whose origin or selection is primarily due to intentional human activity.
    /// <see href="http://dbpedia.org/ontology/CultivatedVariety"></see></summary>
    let CultivatedVariety = _prefix "CultivatedVariety"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Curler"></see>
    /// </summary>
    let Curler = _prefix "Curler"
    /// <summary>
    /// a group of sports teams that compete against each other in Curling
    /// <see href="http://dbpedia.org/ontology/CurlingLeague"></see></summary>
    let CurlingLeague = _prefix "CurlingLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Currency"></see>
    /// </summary>
    let Currency = _prefix "Currency"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cycad"></see>
    /// </summary>
    let Cycad = _prefix "Cycad"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CyclingCompetition"></see>
    /// </summary>
    let CyclingCompetition = _prefix "CyclingCompetition"
    /// <summary>
    /// a event of competitive physical activity
    /// <see href="http://dbpedia.org/ontology/SportsEvent"></see></summary>
    let SportsEvent = _prefix "SportsEvent"
    /// <summary>
    /// a group of sports teams that compete against each other in Cycling
    /// <see href="http://dbpedia.org/ontology/CyclingLeague"></see></summary>
    let CyclingLeague = _prefix "CyclingLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CyclingRace"></see>
    /// </summary>
    let CyclingRace = _prefix "CyclingRace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Race"></see>
    /// </summary>
    let Race = _prefix "Race"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CyclingTeam"></see>
    /// </summary>
    let CyclingTeam = _prefix "CyclingTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cyclist"></see>
    /// </summary>
    let Cyclist = _prefix "Cyclist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/DTMRacer"></see>
    /// </summary>
    let DTMRacer = _prefix "DTMRacer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RacingDriver"></see>
    /// </summary>
    let RacingDriver = _prefix "RacingDriver"
    /// <summary>
    /// A dam is part of a landscape infrastructure, like waterworks (canals) or roads, much more than a building, though, of course, it has been built, too.
    /// <see href="http://dbpedia.org/ontology/Dam"></see></summary>
    let Dam = _prefix "Dam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Dancer"></see>
    /// </summary>
    let Dancer = _prefix "Dancer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/DartsPlayer"></see>
    /// </summary>
    let DartsPlayer = _prefix "DartsPlayer"
    /// <summary>
    /// The intermediate level of a clerical administrative body between parish and diocese
    /// <see href="http://dbpedia.org/ontology/Deanery"></see></summary>
    let Deanery = _prefix "Deanery"
    /// <summary>
    /// someone's death as a type of personal event
    /// <see href="http://dbpedia.org/ontology/Death"></see></summary>
    let Death = _prefix "Death"
    /// <summary>
    /// An object, such as a medal or an order, that is awarded to honor the recipient ostentatiously.
    /// <see href="http://dbpedia.org/ontology/Decoration"></see></summary>
    let Decoration = _prefix "Decoration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Deity"></see>
    /// </summary>
    let Deity = _prefix "Deity"
    /// <summary>
    /// Population of a place. Uses these properties: populationTotal, year (when measured, populationYear), rank (sortOrder of this place amongst its siblings at the same level), name (areal measured by the population, eg: "locality", "municipality" or "comitat")
    /// <see href="http://dbpedia.org/ontology/Demographics"></see></summary>
    let Demographics = _prefix "Demographics"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Department"></see>
    /// </summary>
    let Department = _prefix "Department"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Depth"></see>
    /// </summary>
    let Depth = _prefix "Depth"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Deputy"></see>
    /// </summary>
    let Deputy = _prefix "Deputy"
    /// <summary>
    /// A barren area of land where little precipitation occurs.
    /// <see href="http://dbpedia.org/ontology/Desert"></see></summary>
    let Desert = _prefix "Desert"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/DigitalCamera"></see>
    /// </summary>
    let DigitalCamera = _prefix "DigitalCamera"
    /// <summary>
    /// A dike is an elongated naturally occurring ridge or artificially constructed fill or wall, which regulates water levels
    /// <see href="http://dbpedia.org/ontology/Dike"></see></summary>
    let Dike = _prefix "Dike"
    /// <summary>
    /// District or see under the supervision of a bishop.
    /// <see href="http://dbpedia.org/ontology/Diocese"></see></summary>
    let Diocese = _prefix "Diocese"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Diploma"></see>
    /// </summary>
    let Diploma = _prefix "Diploma"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Disease"></see>
    /// </summary>
    let Disease = _prefix "Disease"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/DisneyCharacter"></see>
    /// </summary>
    let DisneyCharacter = _prefix "DisneyCharacter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/District"></see>
    /// </summary>
    let District = _prefix "District"
    /// <summary>
    /// Conservancy, governmental agency dedicated to surface water management
    /// <see href="http://dbpedia.org/ontology/DistrictWaterBoard"></see></summary>
    let DistrictWaterBoard = _prefix "DistrictWaterBoard"
    /// <summary>
    /// two people's divorce as a type of personal event
    /// <see href="http://dbpedia.org/ontology/Divorce"></see></summary>
    let Divorce = _prefix "Divorce"
    /// <summary>
    /// Any document
    /// <see href="http://dbpedia.org/ontology/Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// type of document (official, informal etc.)
    /// <see href="http://dbpedia.org/ontology/DocumentType"></see></summary>
    let DocumentType = _prefix "DocumentType"
    /// <summary>
    /// a category within a classification system
    /// <see href="http://dbpedia.org/ontology/Type"></see></summary>
    let Type = _prefix "Type"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Dog"></see>
    /// </summary>
    let Dog = _prefix "Dog"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Drama"></see>
    /// </summary>
    let Drama = _prefix "Drama"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Drug"></see>
    /// </summary>
    let Drug = _prefix "Drug"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Drug/boilingPoint"></see>
    /// </summary>
    let ``Drug/boilingPoint`` = _prefix "Drug/boilingPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Drug/meltingPoint"></see>
    /// </summary>
    let ``Drug/meltingPoint`` = _prefix "Drug/meltingPoint"
    /// <summary>
    /// the result of a sudden release of energy in the Earth's crust that creates seismic waves
    /// <see href="http://dbpedia.org/ontology/Earthquake"></see></summary>
    let Earthquake = _prefix "Earthquake"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NaturalEvent"></see>
    /// </summary>
    let NaturalEvent = _prefix "NaturalEvent"
    /// <summary>
    /// An economist is a professional in the social science discipline of economics.
    /// <see href="http://dbpedia.org/ontology/Economist"></see></summary>
    let Economist = _prefix "Economist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Egyptologist"></see>
    /// </summary>
    let Egyptologist = _prefix "Egyptologist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Election"></see>
    /// </summary>
    let Election = _prefix "Election"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ElectionDiagram"></see>
    /// </summary>
    let ElectionDiagram = _prefix "ElectionDiagram"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ElectricalSubstation"></see>
    /// </summary>
    let ElectricalSubstation = _prefix "ElectricalSubstation"
    /// <summary>
    /// Public transport station (eg. railway station, metro station, bus station).
    /// <see href="http://dbpedia.org/ontology/Station"></see></summary>
    let Station = _prefix "Station"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Embryology"></see>
    /// </summary>
    let Embryology = _prefix "Embryology"
    /// <summary>
    /// a person, business, firm, etc, that employs workers.
    /// <see href="http://dbpedia.org/ontology/Employer"></see></summary>
    let Employer = _prefix "Employer"
    /// <summary>
    /// An employers' organisation is an organisation of entrepreneurs who work together to coordinate their actions in the field of labour relations
    /// <see href="http://dbpedia.org/ontology/EmployersOrganisation"></see></summary>
    let EmployersOrganisation = _prefix "EmployersOrganisation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/acceleration"></see>
    /// </summary>
    let ``Engine/acceleration`` = _prefix "Engine/acceleration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/co2Emission"></see>
    /// </summary>
    let ``Engine/co2Emission`` = _prefix "Engine/co2Emission"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/cylinderBore"></see>
    /// </summary>
    let ``Engine/cylinderBore`` = _prefix "Engine/cylinderBore"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/diameter"></see>
    /// </summary>
    let ``Engine/diameter`` = _prefix "Engine/diameter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/displacement"></see>
    /// </summary>
    let ``Engine/displacement`` = _prefix "Engine/displacement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/height"></see>
    /// </summary>
    let ``Engine/height`` = _prefix "Engine/height"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/length"></see>
    /// </summary>
    let ``Engine/length`` = _prefix "Engine/length"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/pistonStroke"></see>
    /// </summary>
    let ``Engine/pistonStroke`` = _prefix "Engine/pistonStroke"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/powerOutput"></see>
    /// </summary>
    let ``Engine/powerOutput`` = _prefix "Engine/powerOutput"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/topSpeed"></see>
    /// </summary>
    let ``Engine/topSpeed`` = _prefix "Engine/topSpeed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/torqueOutput"></see>
    /// </summary>
    let ``Engine/torqueOutput`` = _prefix "Engine/torqueOutput"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/weight"></see>
    /// </summary>
    let ``Engine/weight`` = _prefix "Engine/weight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/width"></see>
    /// </summary>
    let ``Engine/width`` = _prefix "Engine/width"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engineer"></see>
    /// </summary>
    let Engineer = _prefix "Engineer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Entomologist"></see>
    /// </summary>
    let Entomologist = _prefix "Entomologist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Enzyme"></see>
    /// </summary>
    let Enzyme = _prefix "Enzyme"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator"></see>
    /// </summary>
    let Escalator = _prefix "Escalator"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator/diameter"></see>
    /// </summary>
    let ``Escalator/diameter`` = _prefix "Escalator/diameter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator/height"></see>
    /// </summary>
    let ``Escalator/height`` = _prefix "Escalator/height"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator/length"></see>
    /// </summary>
    let ``Escalator/length`` = _prefix "Escalator/length"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator/mass"></see>
    /// </summary>
    let ``Escalator/mass`` = _prefix "Escalator/mass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator/weight"></see>
    /// </summary>
    let ``Escalator/weight`` = _prefix "Escalator/weight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator/width"></see>
    /// </summary>
    let ``Escalator/width`` = _prefix "Escalator/width"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/EthnicGroup"></see>
    /// </summary>
    let EthnicGroup = _prefix "EthnicGroup"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/EurovisionSongContestEntry"></see>
    /// </summary>
    let EurovisionSongContestEntry = _prefix "EurovisionSongContestEntry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Song"></see>
    /// </summary>
    let Song = _prefix "Song"
    /// <summary>
    /// A factory (previously manufactory) or manufacturing plant is an industrial site, usually consisting of buildings and machinery, or more commonly a complex having several buildings, where workers manufacture goods or operate machines processing one product into another.
    /// <see href="http://dbpedia.org/ontology/Factory"></see></summary>
    let Factory = _prefix "Factory"
    /// <summary>
    /// A group of people related by common descent, a lineage.
    /// <see href="http://dbpedia.org/ontology/Family"></see></summary>
    let Family = _prefix "Family"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Farmer"></see>
    /// </summary>
    let Farmer = _prefix "Farmer"
    /// <summary>
    /// type or code of dressing, according to the standards of the time or individual design.
    /// <see href="http://dbpedia.org/ontology/Fashion"></see></summary>
    let Fashion = _prefix "Fashion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FashionDesigner"></see>
    /// </summary>
    let FashionDesigner = _prefix "FashionDesigner"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Fencer"></see>
    /// </summary>
    let Fencer = _prefix "Fencer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Fern"></see>
    /// </summary>
    let Fern = _prefix "Fern"
    /// <summary>
    /// The territory under the authority of a feudal lord
    /// <see href="http://dbpedia.org/ontology/Fiefdom"></see></summary>
    let Fiefdom = _prefix "Fiefdom"
    /// <summary>
    /// Mostly for feudal forms of authority, but can also serve for historical forms of centralised authority
    /// <see href="http://dbpedia.org/ontology/HistoricalAreaOfAuthority"></see></summary>
    let HistoricalAreaOfAuthority = _prefix "HistoricalAreaOfAuthority"
    /// <summary>
    /// a group of sports teams that compete against each other in Field Hockey
    /// <see href="http://dbpedia.org/ontology/FieldHockeyLeague"></see></summary>
    let FieldHockeyLeague = _prefix "FieldHockeyLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FigureSkater"></see>
    /// </summary>
    let FigureSkater = _prefix "FigureSkater"
    /// <summary>
    /// A document with a filename
    /// <see href="http://dbpedia.org/ontology/File"></see></summary>
    let File = _prefix "File"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FillingStation"></see>
    /// </summary>
    let FillingStation = _prefix "FillingStation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Film"></see>
    /// </summary>
    let Film = _prefix "Film"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Wikidata:Q11424"></see>
    /// </summary>
    let ``Wikidata:Q11424`` = _prefix "Wikidata:Q11424"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FilmFestival"></see>
    /// </summary>
    let FilmFestival = _prefix "FilmFestival"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Fish"></see>
    /// </summary>
    let Fish = _prefix "Fish"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Flag"></see>
    /// </summary>
    let Flag = _prefix "Flag"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FloweringPlant"></see>
    /// </summary>
    let FloweringPlant = _prefix "FloweringPlant"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FootballLeagueSeason"></see>
    /// </summary>
    let FootballLeagueSeason = _prefix "FootballLeagueSeason"
    /// <summary>
    /// a competition between two football teams
    /// <see href="http://dbpedia.org/ontology/FootballMatch"></see></summary>
    let FootballMatch = _prefix "FootballMatch"
    /// <summary>
    /// A municipality that has ceased to exist, and most of the time got incorporated (wholesale or partly) into another municipality
    /// <see href="http://dbpedia.org/ontology/FormerMunicipality"></see></summary>
    let FormerMunicipality = _prefix "FormerMunicipality"
    /// <summary>
    /// An administrative body governing a territorial unity on the lower level, administering one or a few more settlements
    /// <see href="http://dbpedia.org/ontology/Municipality"></see></summary>
    let Municipality = _prefix "Municipality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FormulaOneRacer"></see>
    /// </summary>
    let FormulaOneRacer = _prefix "FormulaOneRacer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FormulaOneRacing"></see>
    /// </summary>
    let FormulaOneRacing = _prefix "FormulaOneRacing"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FormulaOneTeam"></see>
    /// </summary>
    let FormulaOneTeam = _prefix "FormulaOneTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Fungus"></see>
    /// </summary>
    let Fungus = _prefix "Fungus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GaelicGamesPlayer"></see>
    /// </summary>
    let GaelicGamesPlayer = _prefix "GaelicGamesPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy"></see>
    /// </summary>
    let Galaxy = _prefix "Galaxy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/apoapsis"></see>
    /// </summary>
    let ``Galaxy/apoapsis`` = _prefix "Galaxy/apoapsis"
    /// <summary>
    /// The average speed of a thing.
    /// <see href="http://dbpedia.org/ontology/Galaxy/averageSpeed"></see></summary>
    let ``Galaxy/averageSpeed`` = _prefix "Galaxy/averageSpeed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/density"></see>
    /// </summary>
    let ``Galaxy/density`` = _prefix "Galaxy/density"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/mass"></see>
    /// </summary>
    let ``Galaxy/mass`` = _prefix "Galaxy/mass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/maximumTemperature"></see>
    /// </summary>
    let ``Galaxy/maximumTemperature`` = _prefix "Galaxy/maximumTemperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/meanRadius"></see>
    /// </summary>
    let ``Galaxy/meanRadius`` = _prefix "Galaxy/meanRadius"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/meanTemperature"></see>
    /// </summary>
    let ``Galaxy/meanTemperature`` = _prefix "Galaxy/meanTemperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/minimumTemperature"></see>
    /// </summary>
    let ``Galaxy/minimumTemperature`` = _prefix "Galaxy/minimumTemperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/orbitalPeriod"></see>
    /// </summary>
    let ``Galaxy/orbitalPeriod`` = _prefix "Galaxy/orbitalPeriod"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/periapsis"></see>
    /// </summary>
    let ``Galaxy/periapsis`` = _prefix "Galaxy/periapsis"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/surfaceArea"></see>
    /// </summary>
    let ``Galaxy/surfaceArea`` = _prefix "Galaxy/surfaceArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/temperature"></see>
    /// </summary>
    let ``Galaxy/temperature`` = _prefix "Galaxy/temperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/volume"></see>
    /// </summary>
    let ``Galaxy/volume`` = _prefix "Galaxy/volume"
    /// <summary>
    /// A garden is a planned space, usually outdoors, set aside for the display, cultivation, and enjoyment of plants and other forms of nature. (http://en.wikipedia.org/wiki/Garden)
    /// <see href="http://dbpedia.org/ontology/Garden"></see></summary>
    let Garden = _prefix "Garden"
    /// <summary>
    /// Gate is defined as a built structure marking the entrance to a building or an estate.
    /// <see href="http://dbpedia.org/ontology/Gate"></see></summary>
    let Gate = _prefix "Gate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GatedCommunity"></see>
    /// </summary>
    let GatedCommunity = _prefix "GatedCommunity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Gene"></see>
    /// </summary>
    let Gene = _prefix "Gene"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GeneLocation"></see>
    /// </summary>
    let GeneLocation = _prefix "GeneLocation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GeologicalPeriod"></see>
    /// </summary>
    let GeologicalPeriod = _prefix "GeologicalPeriod"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GeopoliticalOrganisation"></see>
    /// </summary>
    let GeopoliticalOrganisation = _prefix "GeopoliticalOrganisation"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GeopoliticalOrganisation/areaMetro"></see>
    /// </summary>
    let ``GeopoliticalOrganisation/areaMetro`` =
        _prefix "GeopoliticalOrganisation/areaMetro"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GeopoliticalOrganisation/populationDensity"></see>
    /// </summary>
    let ``GeopoliticalOrganisation/populationDensity`` =
        _prefix "GeopoliticalOrganisation/populationDensity"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Ginkgo"></see>
    /// </summary>
    let Ginkgo = _prefix "Ginkgo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GivenName"></see>
    /// </summary>
    let GivenName = _prefix "GivenName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Name"></see>
    /// </summary>
    let Name = _prefix "Name"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Glacier"></see>
    /// </summary>
    let Glacier = _prefix "Glacier"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Globularswarm"></see>
    /// </summary>
    let Globularswarm = _prefix "Globularswarm"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Swarm"></see>
    /// </summary>
    let Swarm = _prefix "Swarm"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Gnetophytes"></see>
    /// </summary>
    let Gnetophytes = _prefix "Gnetophytes"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GolfCourse"></see>
    /// </summary>
    let GolfCourse = _prefix "GolfCourse"
    /// <summary>
    /// Golfplayer that compete against each other in Golf
    /// <see href="http://dbpedia.org/ontology/GolfLeague"></see></summary>
    let GolfLeague = _prefix "GolfLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GolfPlayer"></see>
    /// </summary>
    let GolfPlayer = _prefix "GolfPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GolfTournament"></see>
    /// </summary>
    let GolfTournament = _prefix "GolfTournament"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Tournament"></see>
    /// </summary>
    let Tournament = _prefix "Tournament"
    /// <summary>
    /// A government agency is a permanent or semi-permanent organization in the machinery of government that is responsible for the oversight and administration of specific functions, such as an intelligence agency.
    /// <see href="http://dbpedia.org/ontology/GovernmentAgency"></see></summary>
    let GovernmentAgency = _prefix "GovernmentAgency"
    /// <summary>
    /// A cabinet is a body of high-ranking state officials, typically consisting of the top leaders of the executive branch.
    /// <see href="http://dbpedia.org/ontology/GovernmentCabinet"></see></summary>
    let GovernmentCabinet = _prefix "GovernmentCabinet"
    /// <summary>
    /// a form of government
    /// <see href="http://dbpedia.org/ontology/GovernmentType"></see></summary>
    let GovernmentType = _prefix "GovernmentType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Governor"></see>
    /// </summary>
    let Governor = _prefix "Governor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GrandPrix"></see>
    /// </summary>
    let GrandPrix = _prefix "GrandPrix"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GrandPrix/course"></see>
    /// </summary>
    let ``GrandPrix/course`` = _prefix "GrandPrix/course"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GrandPrix/distance"></see>
    /// </summary>
    let ``GrandPrix/distance`` = _prefix "GrandPrix/distance"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Grape"></see>
    /// </summary>
    let Grape = _prefix "Grape"
    /// <summary>
    /// A monument erected on a tomb, or a memorial stone.
    /// <see href="http://dbpedia.org/ontology/GraveMonument"></see></summary>
    let GraveMonument = _prefix "GraveMonument"
    /// <summary>
    /// A type of structure (a statue or an art object) created to commemorate a person or important event, not necessarily of a catastrophic nature.
    /// <see href="http://dbpedia.org/ontology/Monument"></see></summary>
    let Monument = _prefix "Monument"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GreenAlga"></see>
    /// </summary>
    let GreenAlga = _prefix "GreenAlga"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GrossDomesticProduct"></see>
    /// </summary>
    let GrossDomesticProduct = _prefix "GrossDomesticProduct"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GrossDomesticProductPerCapita"></see>
    /// </summary>
    let GrossDomesticProductPerCapita = _prefix "GrossDomesticProductPerCapita"
    /// <summary>
    /// Describes the guitar
    /// <see href="http://dbpedia.org/ontology/Guitar"></see></summary>
    let Guitar = _prefix "Guitar"
    /// <summary>
    /// Describes all musical instrument
    /// <see href="http://dbpedia.org/ontology/Instrument"></see></summary>
    let Instrument = _prefix "Instrument"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Guitarist"></see>
    /// </summary>
    let Guitarist = _prefix "Guitarist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Instrumentalist"></see>
    /// </summary>
    let Instrumentalist = _prefix "Instrumentalist"
    /// <summary>
    /// A gymnast is one who performs gymnastics
    /// <see href="http://dbpedia.org/ontology/Gymnast"></see></summary>
    let Gymnast = _prefix "Gymnast"
    /// <summary>
    /// a group of sports teams that compete against each other in Handball
    /// <see href="http://dbpedia.org/ontology/HandballLeague"></see></summary>
    let HandballLeague = _prefix "HandballLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HandballPlayer"></see>
    /// </summary>
    let HandballPlayer = _prefix "HandballPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HandballTeam"></see>
    /// </summary>
    let HandballTeam = _prefix "HandballTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HighDiver"></see>
    /// </summary>
    let HighDiver = _prefix "HighDiver"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Historian"></see>
    /// </summary>
    let Historian = _prefix "Historian"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Writer"></see>
    /// </summary>
    let Writer = _prefix "Writer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HistoricBuilding"></see>
    /// </summary>
    let HistoricBuilding = _prefix "HistoricBuilding"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HistoricPlace"></see>
    /// </summary>
    let HistoricPlace = _prefix "HistoricPlace"
    /// <summary>
    /// A place which used to be a country.
    /// <see href="http://dbpedia.org/ontology/HistoricalCountry"></see></summary>
    let HistoricalCountry = _prefix "HistoricalCountry"
    /// <summary>
    /// a place which used to be a district.
    /// <see href="http://dbpedia.org/ontology/HistoricalDistrict"></see></summary>
    let HistoricalDistrict = _prefix "HistoricalDistrict"
    /// <summary>
    /// A historical Period should be linked to a Place by way of the property dct:spatial (already defined)
    /// <see href="http://dbpedia.org/ontology/HistoricalPeriod"></see></summary>
    let HistoricalPeriod = _prefix "HistoricalPeriod"
    /// <summary>
    /// A place which used to be a province.
    /// <see href="http://dbpedia.org/ontology/HistoricalProvince"></see></summary>
    let HistoricalProvince = _prefix "HistoricalProvince"
    /// <summary>
    /// An administrative body governing a territorial unity on the intermediate level, between local and national level
    /// <see href="http://dbpedia.org/ontology/Province"></see></summary>
    let Province = _prefix "Province"
    /// <summary>
    /// a place which used to be a region.
    /// <see href="http://dbpedia.org/ontology/HistoricalRegion"></see></summary>
    let HistoricalRegion = _prefix "HistoricalRegion"
    /// <summary>
    /// A place which used to be a city or town or village.
    /// <see href="http://dbpedia.org/ontology/HistoricalSettlement"></see></summary>
    let HistoricalSettlement = _prefix "HistoricalSettlement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HockeyClub"></see>
    /// </summary>
    let HockeyClub = _prefix "HockeyClub"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SportsClub"></see>
    /// </summary>
    let SportsClub = _prefix "SportsClub"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HockeyTeam"></see>
    /// </summary>
    let HockeyTeam = _prefix "HockeyTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Holiday"></see>
    /// </summary>
    let Holiday = _prefix "Holiday"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HollywoodCartoon"></see>
    /// </summary>
    let HollywoodCartoon = _prefix "HollywoodCartoon"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Horse"></see>
    /// </summary>
    let Horse = _prefix "Horse"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HorseRace"></see>
    /// </summary>
    let HorseRace = _prefix "HorseRace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HorseRider"></see>
    /// </summary>
    let HorseRider = _prefix "HorseRider"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HorseRiding"></see>
    /// </summary>
    let HorseRiding = _prefix "HorseRiding"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HorseTrainer"></see>
    /// </summary>
    let HorseTrainer = _prefix "HorseTrainer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Hospital"></see>
    /// </summary>
    let Hospital = _prefix "Hospital"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Host"></see>
    /// </summary>
    let Host = _prefix "Host"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TelevisionPersonality"></see>
    /// </summary>
    let TelevisionPersonality = _prefix "TelevisionPersonality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HotSpring"></see>
    /// </summary>
    let HotSpring = _prefix "HotSpring"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Hotel"></see>
    /// </summary>
    let Hotel = _prefix "Hotel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HumanDevelopmentIndex"></see>
    /// </summary>
    let HumanDevelopmentIndex = _prefix "HumanDevelopmentIndex"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HumanGene"></see>
    /// </summary>
    let HumanGene = _prefix "HumanGene"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HumanGeneLocation"></see>
    /// </summary>
    let HumanGeneLocation = _prefix "HumanGeneLocation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Humorist"></see>
    /// </summary>
    let Humorist = _prefix "Humorist"
    /// <summary>
    /// a group of sports teams that compete against each other in Ice Hockey.
    /// <see href="http://dbpedia.org/ontology/IceHockeyLeague"></see></summary>
    let IceHockeyLeague = _prefix "IceHockeyLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/IceHockeyPlayer"></see>
    /// </summary>
    let IceHockeyPlayer = _prefix "IceHockeyPlayer"
    /// <summary>
    /// for example: Progressivism_in_the_United_States, Classical_liberalism
    /// <see href="http://dbpedia.org/ontology/Ideology"></see></summary>
    let Ideology = _prefix "Ideology"
    /// <summary>
    /// A document that contains a visual image
    /// <see href="http://dbpedia.org/ontology/Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// An information device such as PDAs or Video game consoles, etc.
    /// <see href="http://dbpedia.org/ontology/InformationAppliance"></see></summary>
    let InformationAppliance = _prefix "InformationAppliance"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Infrastructure/length"></see>
    /// </summary>
    let ``Infrastructure/length`` = _prefix "Infrastructure/length"
    /// <summary>
    /// group of sports teams that compete against each other in Inline Hockey.
    /// <see href="http://dbpedia.org/ontology/InlineHockeyLeague"></see></summary>
    let InlineHockeyLeague = _prefix "InlineHockeyLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Insect"></see>
    /// </summary>
    let Insect = _prefix "Insect"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Intercommunality"></see>
    /// </summary>
    let Intercommunality = _prefix "Intercommunality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/InternationalFootballLeagueEvent"></see>
    /// </summary>
    let InternationalFootballLeagueEvent = _prefix "InternationalFootballLeagueEvent"
    /// <summary>
    /// An international organisation is either a private or a public organisation seeking to accomplish goals across country borders
    /// <see href="http://dbpedia.org/ontology/InternationalOrganisation"></see></summary>
    let InternationalOrganisation = _prefix "InternationalOrganisation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Jockey"></see>
    /// </summary>
    let Jockey = _prefix "Jockey"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Journalist"></see>
    /// </summary>
    let Journalist = _prefix "Journalist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Judge"></see>
    /// </summary>
    let Judge = _prefix "Judge"
    /// <summary>
    /// a group of sports teams that compete against each other in Lacrosse.
    /// <see href="http://dbpedia.org/ontology/LacrosseLeague"></see></summary>
    let LacrosseLeague = _prefix "LacrosseLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LacrossePlayer"></see>
    /// </summary>
    let LacrossePlayer = _prefix "LacrossePlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lake"></see>
    /// </summary>
    let Lake = _prefix "Lake"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lake/areaOfCatchment"></see>
    /// </summary>
    let ``Lake/areaOfCatchment`` = _prefix "Lake/areaOfCatchment"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lake/shoreLength"></see>
    /// </summary>
    let ``Lake/shoreLength`` = _prefix "Lake/shoreLength"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lake/volume"></see>
    /// </summary>
    let ``Lake/volume`` = _prefix "Lake/volume"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Language"></see>
    /// </summary>
    let Language = _prefix "Language"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LaunchPad"></see>
    /// </summary>
    let LaunchPad = _prefix "LaunchPad"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Law"></see>
    /// </summary>
    let Law = _prefix "Law"
    /// <summary>
    /// A law firm is a business entity formed by one or more lawyers to engage in the practice of law. The primary service provided by a law firm is to advise clients (individuals or corporations) about their legal rights and responsibilities, and to represent their clients in civil or criminal cases, business transactions, and other matters in which legal advice and other assistance are sought.
    /// <see href="http://dbpedia.org/ontology/LawFirm"></see></summary>
    let LawFirm = _prefix "LawFirm"
    /// <summary>
    /// a person who is practicing law.
    /// <see href="http://dbpedia.org/ontology/Lawyer"></see></summary>
    let Lawyer = _prefix "Lawyer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LegalCase"></see>
    /// </summary>
    let LegalCase = _prefix "LegalCase"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Legislature"></see>
    /// </summary>
    let Legislature = _prefix "Legislature"
    /// <summary>
    /// A letter from the alphabet.
    /// <see href="http://dbpedia.org/ontology/Letter"></see></summary>
    let Letter = _prefix "Letter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Library"></see>
    /// </summary>
    let Library = _prefix "Library"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lieutenant"></see>
    /// </summary>
    let Lieutenant = _prefix "Lieutenant"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LifeCycleEvent"></see>
    /// </summary>
    let LifeCycleEvent = _prefix "LifeCycleEvent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Ligament"></see>
    /// </summary>
    let Ligament = _prefix "Ligament"
    /// <summary>
    /// A style of Japanese novel
    /// <see href="http://dbpedia.org/ontology/LightNovel"></see></summary>
    let LightNovel = _prefix "LightNovel"
    /// <summary>
    /// A book of long narrative in literary prose
    /// <see href="http://dbpedia.org/ontology/Novel"></see></summary>
    let Novel = _prefix "Novel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lighthouse"></see>
    /// </summary>
    let Lighthouse = _prefix "Lighthouse"
    /// <summary>
    /// A Tower is a kind of structure (not necessarily a building) that is higher than the rest
    /// <see href="http://dbpedia.org/ontology/Tower"></see></summary>
    let Tower = _prefix "Tower"
    /// <summary>
    /// A coherent type of clothing or dressing following a particular fashion
    /// <see href="http://dbpedia.org/ontology/LineOfFashion"></see></summary>
    let LineOfFashion = _prefix "LineOfFashion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Linguist"></see>
    /// </summary>
    let Linguist = _prefix "Linguist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lipid"></see>
    /// </summary>
    let Lipid = _prefix "Lipid"
    /// <summary>
    /// A general list of items.
    /// <see href="http://dbpedia.org/ontology/List"></see></summary>
    let List = _prefix "List"
    /// <summary>
    /// Genres of literature, e.g. Satire, Gothic
    /// <see href="http://dbpedia.org/ontology/LiteraryGenre"></see></summary>
    let LiteraryGenre = _prefix "LiteraryGenre"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Locality"></see>
    /// </summary>
    let Locality = _prefix "Locality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lock"></see>
    /// </summary>
    let Lock = _prefix "Lock"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Locomotive"></see>
    /// </summary>
    let Locomotive = _prefix "Locomotive"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LunarCrater"></see>
    /// </summary>
    let LunarCrater = _prefix "LunarCrater"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LunarCrater/diameter"></see>
    /// </summary>
    let ``LunarCrater/diameter`` = _prefix "LunarCrater/diameter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lymph"></see>
    /// </summary>
    let Lymph = _prefix "Lymph"
    /// <summary>
    /// Magazines, periodicals, glossies or serials are publications, generally published on a regular schedule, containing a variety of articles. They are generally financed by advertising, by a purchase price, by pre-paid magazine subscriptions, or all three.
    /// <see href="http://dbpedia.org/ontology/Magazine"></see></summary>
    let Magazine = _prefix "Magazine"
    /// <summary>
    /// Manga are comics created in Japan
    /// <see href="http://dbpedia.org/ontology/Manga"></see></summary>
    let Manga = _prefix "Manga"
    /// <summary>
    /// Comics originally produced in China
    /// <see href="http://dbpedia.org/ontology/Manhua"></see></summary>
    let Manhua = _prefix "Manhua"
    /// <summary>
    /// Korean term for comics and print cartoons
    /// <see href="http://dbpedia.org/ontology/Manhwa"></see></summary>
    let Manhwa = _prefix "Manhwa"
    /// <summary>
    /// someone's marriage as a type of personal event
    /// <see href="http://dbpedia.org/ontology/Marriage"></see></summary>
    let Marriage = _prefix "Marriage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MartialArtist"></see>
    /// </summary>
    let MartialArtist = _prefix "MartialArtist"
    /// <summary>
    /// Mathematical concepts, e.g. Fibonacci numbers, Imaginary numbers, Symmetry
    /// <see href="http://dbpedia.org/ontology/MathematicalConcept"></see></summary>
    let MathematicalConcept = _prefix "MathematicalConcept"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Mayor"></see>
    /// </summary>
    let Mayor = _prefix "Mayor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation/diameter"></see>
    /// </summary>
    let ``MeanOfTransportation/diameter`` = _prefix "MeanOfTransportation/diameter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation/height"></see>
    /// </summary>
    let ``MeanOfTransportation/height`` = _prefix "MeanOfTransportation/height"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation/length"></see>
    /// </summary>
    let ``MeanOfTransportation/length`` = _prefix "MeanOfTransportation/length"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation/mass"></see>
    /// </summary>
    let ``MeanOfTransportation/mass`` = _prefix "MeanOfTransportation/mass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation/weight"></see>
    /// </summary>
    let ``MeanOfTransportation/weight`` = _prefix "MeanOfTransportation/weight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation/width"></see>
    /// </summary>
    let ``MeanOfTransportation/width`` = _prefix "MeanOfTransportation/width"
    /// <summary>
    /// storage and transmission channels or tools used to store and deliver information or data
    /// <see href="http://dbpedia.org/ontology/Media"></see></summary>
    let Media = _prefix "Media"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Medician"></see>
    /// </summary>
    let Medician = _prefix "Medician"
    /// <summary>
    /// The science and art of healing the human body and identifying the causes of disease
    /// <see href="http://dbpedia.org/ontology/Medicine"></see></summary>
    let Medicine = _prefix "Medicine"
    /// <summary>
    /// A regular or irregular meeting of people as an event to keep record of
    /// <see href="http://dbpedia.org/ontology/Meeting"></see></summary>
    let Meeting = _prefix "Meeting"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MemberOfParliament"></see>
    /// </summary>
    let MemberOfParliament = _prefix "MemberOfParliament"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MemberResistanceMovement"></see>
    /// </summary>
    let MemberResistanceMovement = _prefix "MemberResistanceMovement"
    /// <summary>
    /// A monument erected to commemorate a person, an event and/or group. In the case of a person, this might be a grave or tomb.
    /// <see href="http://dbpedia.org/ontology/Memorial"></see></summary>
    let Memorial = _prefix "Memorial"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MetroStation"></see>
    /// </summary>
    let MetroStation = _prefix "MetroStation"
    /// <summary>
    /// A microregion is a - mainy statistical - region in Brazil, at an administrative level between a meso-region and a community
    /// <see href="http://dbpedia.org/ontology/MicroRegion"></see></summary>
    let MicroRegion = _prefix "MicroRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryAircraft"></see>
    /// </summary>
    let MilitaryAircraft = _prefix "MilitaryAircraft"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryConflict"></see>
    /// </summary>
    let MilitaryConflict = _prefix "MilitaryConflict"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryPerson"></see>
    /// </summary>
    let MilitaryPerson = _prefix "MilitaryPerson"
    /// <summary>
    /// A military structure such as a Castle, Fortress, Wall, etc.
    /// <see href="http://dbpedia.org/ontology/MilitaryStructure"></see></summary>
    let MilitaryStructure = _prefix "MilitaryStructure"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryUnit"></see>
    /// </summary>
    let MilitaryUnit = _prefix "MilitaryUnit"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryVehicle"></see>
    /// </summary>
    let MilitaryVehicle = _prefix "MilitaryVehicle"
    /// <summary>
    /// a unit operation designed to break a solid material into smaller pieces
    /// <see href="http://dbpedia.org/ontology/Mill"></see></summary>
    let Mill = _prefix "Mill"
    /// <summary>
    /// A naturally occurring solid chemical substance.
    /// <see href="http://dbpedia.org/ontology/Mineral"></see></summary>
    let Mineral = _prefix "Mineral"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MixedMartialArtsEvent"></see>
    /// </summary>
    let MixedMartialArtsEvent = _prefix "MixedMartialArtsEvent"
    /// <summary>
    /// a group of sports teams that compete against each other in Mixed Martial Arts
    /// <see href="http://dbpedia.org/ontology/MixedMartialArtsLeague"></see></summary>
    let MixedMartialArtsLeague = _prefix "MixedMartialArtsLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MobilePhone"></see>
    /// </summary>
    let MobilePhone = _prefix "MobilePhone"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Model"></see>
    /// </summary>
    let Model = _prefix "Model"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Mollusca"></see>
    /// </summary>
    let Mollusca = _prefix "Mollusca"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Monarch"></see>
    /// </summary>
    let Monarch = _prefix "Monarch"
    /// <summary>
    /// A mosque, sometimes spelt mosk, is a place of worship for followers of Islam.
    /// <see href="http://dbpedia.org/ontology/Mosque"></see></summary>
    let Mosque = _prefix "Mosque"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Moss"></see>
    /// </summary>
    let Moss = _prefix "Moss"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MotocycleRacer"></see>
    /// </summary>
    let MotocycleRacer = _prefix "MotocycleRacer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MotorcycleRider"></see>
    /// </summary>
    let MotorcycleRider = _prefix "MotorcycleRider"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MotorRace"></see>
    /// </summary>
    let MotorRace = _prefix "MotorRace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Motorcycle"></see>
    /// </summary>
    let Motorcycle = _prefix "Motorcycle"
    /// <summary>
    /// a group of sports teams or bikerider that compete against each other in Motorcycle Racing
    /// <see href="http://dbpedia.org/ontology/MotorcycleRacingLeague"></see></summary>
    let MotorcycleRacingLeague = _prefix "MotorcycleRacingLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MotorsportRacer"></see>
    /// </summary>
    let MotorsportRacer = _prefix "MotorsportRacer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MotorsportSeason"></see>
    /// </summary>
    let MotorsportSeason = _prefix "MotorsportSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SportsSeason"></see>
    /// </summary>
    let SportsSeason = _prefix "SportsSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Mountain"></see>
    /// </summary>
    let Mountain = _prefix "Mountain"
    /// <summary>
    /// a path that allows the crossing of a mountain chain. It is usually a saddle point in between two areas of higher elevation
    /// <see href="http://dbpedia.org/ontology/MountainPass"></see></summary>
    let MountainPass = _prefix "MountainPass"
    /// <summary>
    /// a chain of mountains bordered by highlands or separated from other mountains by passes or valleys.
    /// <see href="http://dbpedia.org/ontology/MountainRange"></see></summary>
    let MountainRange = _prefix "MountainRange"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MouseGene"></see>
    /// </summary>
    let MouseGene = _prefix "MouseGene"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MouseGeneLocation"></see>
    /// </summary>
    let MouseGeneLocation = _prefix "MouseGeneLocation"
    /// <summary>
    /// a person who oversees making of film.
    /// <see href="http://dbpedia.org/ontology/MovieDirector"></see></summary>
    let MovieDirector = _prefix "MovieDirector"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovieGenre"></see>
    /// </summary>
    let MovieGenre = _prefix "MovieGenre"
    /// <summary>
    /// A visual document that is intended to be animated; equivalent to http://purl.org/dc/dcmitype/MovingImage
    /// <see href="http://dbpedia.org/ontology/MovingImage"></see></summary>
    let MovingImage = _prefix "MovingImage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway"></see>
    /// </summary>
    let MovingWalkway = _prefix "MovingWalkway"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway/diameter"></see>
    /// </summary>
    let ``MovingWalkway/diameter`` = _prefix "MovingWalkway/diameter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway/height"></see>
    /// </summary>
    let ``MovingWalkway/height`` = _prefix "MovingWalkway/height"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway/length"></see>
    /// </summary>
    let ``MovingWalkway/length`` = _prefix "MovingWalkway/length"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway/mass"></see>
    /// </summary>
    let ``MovingWalkway/mass`` = _prefix "MovingWalkway/mass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway/weight"></see>
    /// </summary>
    let ``MovingWalkway/weight`` = _prefix "MovingWalkway/weight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway/width"></see>
    /// </summary>
    let ``MovingWalkway/width`` = _prefix "MovingWalkway/width"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MultiVolumePublication"></see>
    /// </summary>
    let MultiVolumePublication = _prefix "MultiVolumePublication"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Murderer"></see>
    /// </summary>
    let Murderer = _prefix "Murderer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Muscle"></see>
    /// </summary>
    let Muscle = _prefix "Muscle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Museum"></see>
    /// </summary>
    let Museum = _prefix "Museum"
    /// <summary>
    /// a person who creates music.
    /// <see href="http://dbpedia.org/ontology/MusicComposer"></see></summary>
    let MusicComposer = _prefix "MusicComposer"
    /// <summary>
    /// A person who is the director of an orchestra or concert band.
    /// <see href="http://dbpedia.org/ontology/MusicDirector"></see></summary>
    let MusicDirector = _prefix "MusicDirector"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MusicFestival"></see>
    /// </summary>
    let MusicFestival = _prefix "MusicFestival"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MusicGenre"></see>
    /// </summary>
    let MusicGenre = _prefix "MusicGenre"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Musical"></see>
    /// </summary>
    let Musical = _prefix "Musical"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MythologicalFigure"></see>
    /// </summary>
    let MythologicalFigure = _prefix "MythologicalFigure"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NCAATeamSeason"></see>
    /// </summary>
    let NCAATeamSeason = _prefix "NCAATeamSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NarutoCharacter"></see>
    /// </summary>
    let NarutoCharacter = _prefix "NarutoCharacter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NascarDriver"></see>
    /// </summary>
    let NascarDriver = _prefix "NascarDriver"
    /// <summary>
    /// Patriotic musical composition which is the offcial national song.
    /// <see href="http://dbpedia.org/ontology/NationalAnthem"></see></summary>
    let NationalAnthem = _prefix "NationalAnthem"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NationalCollegiateAthleticAssociationAthlete"></see>
    /// </summary>
    let NationalCollegiateAthleticAssociationAthlete =
        _prefix "NationalCollegiateAthleticAssociationAthlete"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NationalFootballLeagueEvent"></see>
    /// </summary>
    let NationalFootballLeagueEvent = _prefix "NationalFootballLeagueEvent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NationalFootballLeagueSeason"></see>
    /// </summary>
    let NationalFootballLeagueSeason = _prefix "NationalFootballLeagueSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NationalSoccerClub"></see>
    /// </summary>
    let NationalSoccerClub = _prefix "NationalSoccerClub"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoccerClub"></see>
    /// </summary>
    let SoccerClub = _prefix "SoccerClub"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NaturalRegion"></see>
    /// </summary>
    let NaturalRegion = _prefix "NaturalRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Nerve"></see>
    /// </summary>
    let Nerve = _prefix "Nerve"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NetballPlayer"></see>
    /// </summary>
    let NetballPlayer = _prefix "NetballPlayer"
    /// <summary>
    /// A newspaper is a regularly scheduled publication containing news of current events, informative articles, diverse features and advertising. It usually is printed on relatively inexpensive, low-grade paper such as newsprint.
    /// <see href="http://dbpedia.org/ontology/Newspaper"></see></summary>
    let Newspaper = _prefix "Newspaper"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NobelPrize"></see>
    /// </summary>
    let NobelPrize = _prefix "NobelPrize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Noble"></see>
    /// </summary>
    let Noble = _prefix "Noble"
    /// <summary>
    /// Family deemed to be of noble descent
    /// <see href="http://dbpedia.org/ontology/NobleFamily"></see></summary>
    let NobleFamily = _prefix "NobleFamily"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Non-ProfitOrganisation"></see>
    /// </summary>
    let ``Non-ProfitOrganisation`` = _prefix "Non-ProfitOrganisation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NordicCombined"></see>
    /// </summary>
    let NordicCombined = _prefix "NordicCombined"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NuclearPowerStation"></see>
    /// </summary>
    let NuclearPowerStation = _prefix "NuclearPowerStation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PowerStation"></see>
    /// </summary>
    let PowerStation = _prefix "PowerStation"
    /// <summary>
    /// A body of saline water that composes much of a planet's hydrosphere.
    /// <see href="http://dbpedia.org/ontology/Ocean"></see></summary>
    let Ocean = _prefix "Ocean"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/OfficeHolder"></see>
    /// </summary>
    let OfficeHolder = _prefix "OfficeHolder"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/OldTerritory"></see>
    /// </summary>
    let OldTerritory = _prefix "OldTerritory"
    /// <summary>
    /// A territory may refer to a country subdivision, a non-sovereign geographic region.
    /// <see href="http://dbpedia.org/ontology/Territory"></see></summary>
    let Territory = _prefix "Territory"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/OlympicEvent"></see>
    /// </summary>
    let OlympicEvent = _prefix "OlympicEvent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Olympics"></see>
    /// </summary>
    let Olympics = _prefix "Olympics"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/OlympicResult"></see>
    /// </summary>
    let OlympicResult = _prefix "OlympicResult"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SportCompetitionResult"></see>
    /// </summary>
    let SportCompetitionResult = _prefix "SportCompetitionResult"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation/diameter"></see>
    /// </summary>
    let ``On-SiteTransportation/diameter`` = _prefix "On-SiteTransportation/diameter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation/height"></see>
    /// </summary>
    let ``On-SiteTransportation/height`` = _prefix "On-SiteTransportation/height"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation/length"></see>
    /// </summary>
    let ``On-SiteTransportation/length`` = _prefix "On-SiteTransportation/length"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation/mass"></see>
    /// </summary>
    let ``On-SiteTransportation/mass`` = _prefix "On-SiteTransportation/mass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation/weight"></see>
    /// </summary>
    let ``On-SiteTransportation/weight`` = _prefix "On-SiteTransportation/weight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation/width"></see>
    /// </summary>
    let ``On-SiteTransportation/width`` = _prefix "On-SiteTransportation/width"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Openswarm"></see>
    /// </summary>
    let Openswarm = _prefix "Openswarm"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Opera"></see>
    /// </summary>
    let Opera = _prefix "Opera"
    /// <summary>
    /// All types and sizes of organs
    /// <see href="http://dbpedia.org/ontology/Organ"></see></summary>
    let Organ = _prefix "Organ"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wgs84_pos:SpatialThing"></see>
    /// </summary>
    let ``wgs84_pos:SpatialThing`` = _prefix "wgs84_pos:SpatialThing"
    /// <summary>
    /// A member of an organisation.
    /// <see href="http://dbpedia.org/ontology/OrganisationMember"></see></summary>
    let OrganisationMember = _prefix "OrganisationMember"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Orphan"></see>
    /// </summary>
    let Orphan = _prefix "Orphan"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/OverseasDepartment"></see>
    /// </summary>
    let OverseasDepartment = _prefix "OverseasDepartment"
    /// <summary>
    /// a group of sports teams that compete against each other in Paintball
    /// <see href="http://dbpedia.org/ontology/PaintballLeague"></see></summary>
    let PaintballLeague = _prefix "PaintballLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Painter"></see>
    /// </summary>
    let Painter = _prefix "Painter"
    /// <summary>
    /// Describes a painting to assign picture entries in wikipedia to artists.
    /// <see href="http://dbpedia.org/ontology/Painting"></see></summary>
    let Painting = _prefix "Painting"
    /// <summary>
    /// The smallest unit of a clerical administrative body
    /// <see href="http://dbpedia.org/ontology/Parish"></see></summary>
    let Parish = _prefix "Parish"
    /// <summary>
    /// A park is an area of open space provided for recreational use. http://en.wikipedia.org/wiki/Park
    /// <see href="http://dbpedia.org/ontology/Park"></see></summary>
    let Park = _prefix "Park"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Parliament"></see>
    /// </summary>
    let Parliament = _prefix "Parliament"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PenaltyShootOut"></see>
    /// </summary>
    let PenaltyShootOut = _prefix "PenaltyShootOut"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PeriodOfArtisticStyle"></see>
    /// </summary>
    let PeriodOfArtisticStyle = _prefix "PeriodOfArtisticStyle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Person/height"></see>
    /// </summary>
    let ``Person/height`` = _prefix "Person/height"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Person/weight"></see>
    /// </summary>
    let ``Person/weight`` = _prefix "Person/weight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PersonFunction"></see>
    /// </summary>
    let PersonFunction = _prefix "PersonFunction"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Philosopher"></see>
    /// </summary>
    let Philosopher = _prefix "Philosopher"
    /// <summary>
    /// Philosophical concepts, e.g. Existentialism, Cogito Ergo Sum
    /// <see href="http://dbpedia.org/ontology/PhilosophicalConcept"></see></summary>
    let PhilosophicalConcept = _prefix "PhilosophicalConcept"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Photographer"></see>
    /// </summary>
    let Photographer = _prefix "Photographer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Location"></see>
    /// </summary>
    let Location = _prefix "Location"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet"></see>
    /// </summary>
    let Planet = _prefix "Planet"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/apoapsis"></see>
    /// </summary>
    let ``Planet/apoapsis`` = _prefix "Planet/apoapsis"
    /// <summary>
    /// The average speed of a thing.
    /// <see href="http://dbpedia.org/ontology/Planet/averageSpeed"></see></summary>
    let ``Planet/averageSpeed`` = _prefix "Planet/averageSpeed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/density"></see>
    /// </summary>
    let ``Planet/density`` = _prefix "Planet/density"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/mass"></see>
    /// </summary>
    let ``Planet/mass`` = _prefix "Planet/mass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/maximumTemperature"></see>
    /// </summary>
    let ``Planet/maximumTemperature`` = _prefix "Planet/maximumTemperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/meanRadius"></see>
    /// </summary>
    let ``Planet/meanRadius`` = _prefix "Planet/meanRadius"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/meanTemperature"></see>
    /// </summary>
    let ``Planet/meanTemperature`` = _prefix "Planet/meanTemperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/minimumTemperature"></see>
    /// </summary>
    let ``Planet/minimumTemperature`` = _prefix "Planet/minimumTemperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/orbitalPeriod"></see>
    /// </summary>
    let ``Planet/orbitalPeriod`` = _prefix "Planet/orbitalPeriod"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/periapsis"></see>
    /// </summary>
    let ``Planet/periapsis`` = _prefix "Planet/periapsis"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/surfaceArea"></see>
    /// </summary>
    let ``Planet/surfaceArea`` = _prefix "Planet/surfaceArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/temperature"></see>
    /// </summary>
    let ``Planet/temperature`` = _prefix "Planet/temperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/volume"></see>
    /// </summary>
    let ``Planet/volume`` = _prefix "Planet/volume"
    /// <summary>
    /// A play is a form of literature written by a playwright, usually consisting of scripted dialogue between characters, intended for theatrical performance rather than just reading.
    /// <see href="http://dbpedia.org/ontology/Play"></see></summary>
    let Play = _prefix "Play"
    /// <summary>
    /// A person who writes dramatic literature or drama.
    /// <see href="http://dbpedia.org/ontology/PlayWright"></see></summary>
    let PlayWright = _prefix "PlayWright"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PlayboyPlaymate"></see>
    /// </summary>
    let PlayboyPlaymate = _prefix "PlayboyPlaymate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Poem"></see>
    /// </summary>
    let Poem = _prefix "Poem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Poet"></see>
    /// </summary>
    let Poet = _prefix "Poet"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PokerPlayer"></see>
    /// </summary>
    let PokerPlayer = _prefix "PokerPlayer"
    /// <summary>
    /// Political concepts, e.g. Capitalism, Democracy
    /// <see href="http://dbpedia.org/ontology/PoliticalConcept"></see></summary>
    let PoliticalConcept = _prefix "PoliticalConcept"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PoliticalFunction"></see>
    /// </summary>
    let PoliticalFunction = _prefix "PoliticalFunction"
    /// <summary>
    /// for example: Democratic_Party_(United_States)
    /// <see href="http://dbpedia.org/ontology/PoliticalParty"></see></summary>
    let PoliticalParty = _prefix "PoliticalParty"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PoliticianSpouse"></see>
    /// </summary>
    let PoliticianSpouse = _prefix "PoliticianSpouse"
    /// <summary>
    /// A group of sports teams that compete against each other in Polo.
    /// <see href="http://dbpedia.org/ontology/PoloLeague"></see></summary>
    let PoloLeague = _prefix "PoloLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Polyhedron"></see>
    /// </summary>
    let Polyhedron = _prefix "Polyhedron"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Polysaccharide"></see>
    /// </summary>
    let Polysaccharide = _prefix "Polysaccharide"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Pope"></see>
    /// </summary>
    let Pope = _prefix "Pope"
    /// <summary>
    /// The area of the thing in square meters.
    /// <see href="http://dbpedia.org/ontology/PopulatedPlace/area"></see></summary>
    let ``PopulatedPlace/area`` = _prefix "PopulatedPlace/area"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PopulatedPlace/areaMetro"></see>
    /// </summary>
    let ``PopulatedPlace/areaMetro`` = _prefix "PopulatedPlace/areaMetro"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PopulatedPlace/areaTotal"></see>
    /// </summary>
    let ``PopulatedPlace/areaTotal`` = _prefix "PopulatedPlace/areaTotal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PopulatedPlace/areaUrban"></see>
    /// </summary>
    let ``PopulatedPlace/areaUrban`` = _prefix "PopulatedPlace/areaUrban"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PopulatedPlace/populationDensity"></see>
    /// </summary>
    let ``PopulatedPlace/populationDensity`` =
        _prefix "PopulatedPlace/populationDensity"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PopulatedPlace/populationMetroDensity"></see>
    /// </summary>
    let ``PopulatedPlace/populationMetroDensity`` =
        _prefix "PopulatedPlace/populationMetroDensity"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PopulatedPlace/populationUrbanDensity"></see>
    /// </summary>
    let ``PopulatedPlace/populationUrbanDensity`` =
        _prefix "PopulatedPlace/populationUrbanDensity"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Population"></see>
    /// </summary>
    let Population = _prefix "Population"
    /// <summary>
    /// a location on a coast or shore containing one or more harbors where ships can dock and transfer people or cargo to or from land.
    /// <see href="http://dbpedia.org/ontology/Port"></see></summary>
    let Port = _prefix "Port"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Prefecture"></see>
    /// </summary>
    let Prefecture = _prefix "Prefecture"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PrehistoricalPeriod"></see>
    /// </summary>
    let PrehistoricalPeriod = _prefix "PrehistoricalPeriod"
    /// <summary>
    /// TV or radio show presenter
    /// <see href="http://dbpedia.org/ontology/Presenter"></see></summary>
    let Presenter = _prefix "Presenter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/President"></see>
    /// </summary>
    let President = _prefix "President"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Priest"></see>
    /// </summary>
    let Priest = _prefix "Priest"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PrimeMinister"></see>
    /// </summary>
    let PrimeMinister = _prefix "PrimeMinister"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Prison"></see>
    /// </summary>
    let Prison = _prefix "Prison"
    /// <summary>
    /// a person who manages movies or music recordings.
    /// <see href="http://dbpedia.org/ontology/Producer"></see></summary>
    let Producer = _prefix "Producer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Profession"></see>
    /// </summary>
    let Profession = _prefix "Profession"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Professor"></see>
    /// </summary>
    let Professor = _prefix "Professor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ProgrammingLanguage"></see>
    /// </summary>
    let ProgrammingLanguage = _prefix "ProgrammingLanguage"
    /// <summary>
    /// A project is a temporary endeavor undertaken to achieve defined objectives.
    /// <see href="http://dbpedia.org/ontology/Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// This class should be used for protected nature. For enclosed neighbourhoods there is now class GatedCommunity
    /// <see href="http://dbpedia.org/ontology/ProtectedArea"></see></summary>
    let ProtectedArea = _prefix "ProtectedArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Protein"></see>
    /// </summary>
    let Protein = _prefix "Protein"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ProtohistoricalPeriod"></see>
    /// </summary>
    let ProtohistoricalPeriod = _prefix "ProtohistoricalPeriod"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Psychologist"></see>
    /// </summary>
    let Psychologist = _prefix "Psychologist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PublicService"></see>
    /// </summary>
    let PublicService = _prefix "PublicService"
    /// <summary>
    /// A public transit system is a shared passenger transportation service which is available for use by the general public. Public transport modes include buses, trolleybuses, trams and trains, 'rapid transit' (metro/subways/undergrounds etc) and ferries. Intercity public transport is dominated by airlines, coaches, and intercity rail. (http://en.wikipedia.org/wiki/Public_transit).
    /// <see href="http://dbpedia.org/ontology/PublicTransitSystem"></see></summary>
    let PublicTransitSystem = _prefix "PublicTransitSystem"
    /// <summary>
    /// Publishing company
    /// <see href="http://dbpedia.org/ontology/Publisher"></see></summary>
    let Publisher = _prefix "Publisher"
    /// <summary>
    /// a structure whose shape is roughly that of a pyramid in the geometric sense.
    /// <see href="http://dbpedia.org/ontology/Pyramid"></see></summary>
    let Pyramid = _prefix "Pyramid"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Quote"></see>
    /// </summary>
    let Quote = _prefix "Quote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RaceHorse"></see>
    /// </summary>
    let RaceHorse = _prefix "RaceHorse"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RaceTrack"></see>
    /// </summary>
    let RaceTrack = _prefix "RaceTrack"
    /// <summary>
    /// A racecourse is an alternate term for a horse racing track, found in countries such as the United Kingdom, Australia, Hong Kong, and the United Arab Emirates.
    /// <see href="http://dbpedia.org/ontology/Racecourse"></see></summary>
    let Racecourse = _prefix "Racecourse"
    /// <summary>
    /// A group of sports teams or person that compete against each other in radio-controlled racing.
    /// <see href="http://dbpedia.org/ontology/RadioControlledRacingLeague"></see></summary>
    let RadioControlledRacingLeague = _prefix "RadioControlledRacingLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RadioHost"></see>
    /// </summary>
    let RadioHost = _prefix "RadioHost"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RadioProgram"></see>
    /// </summary>
    let RadioProgram = _prefix "RadioProgram"
    /// <summary>
    /// A radio station has one line up. For instance the radio station BBC Radio 1. Not to be confused with the broadcasting network BBC, which has many radio stations.
    /// <see href="http://dbpedia.org/ontology/RadioStation"></see></summary>
    let RadioStation = _prefix "RadioStation"
    /// <summary>
    /// A railway line is a transport service by trains that pull passengers or freight provided by an organization. Not to be mistaken for railway track, which is the structure consisting of the rails. Wikipedia do not clearly differentiate between both, so there is one infobox describing tracks and lines.
    /// <see href="http://dbpedia.org/ontology/RailwayLine"></see></summary>
    let RailwayLine = _prefix "RailwayLine"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RailwayStation"></see>
    /// </summary>
    let RailwayStation = _prefix "RailwayStation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RailwayTunnel"></see>
    /// </summary>
    let RailwayTunnel = _prefix "RailwayTunnel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RallyDriver"></see>
    /// </summary>
    let RallyDriver = _prefix "RallyDriver"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Rebellion"></see>
    /// </summary>
    let Rebellion = _prefix "Rebellion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RecordLabel"></see>
    /// </summary>
    let RecordLabel = _prefix "RecordLabel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RecordOffice"></see>
    /// </summary>
    let RecordOffice = _prefix "RecordOffice"
    /// <summary>
    /// An official who watches a game or match closely to ensure that the rules are adhered to.
    /// <see href="http://dbpedia.org/ontology/Referee"></see></summary>
    let Referee = _prefix "Referee"
    /// <summary>
    /// Reference to a work (book, movie, website)  providing info about the subject
    /// <see href="http://dbpedia.org/ontology/Reference"></see></summary>
    let Reference = _prefix "Reference"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Regency"></see>
    /// </summary>
    let Regency = _prefix "Regency"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Religious"></see>
    /// </summary>
    let Religious = _prefix "Religious"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Reptile"></see>
    /// </summary>
    let Reptile = _prefix "Reptile"
    /// <summary>
    /// A research project is a scientific investigation, usually using scientific methods, to achieve defined objectives.
    /// <see href="http://dbpedia.org/ontology/ResearchProject"></see></summary>
    let ResearchProject = _prefix "ResearchProject"
    /// <summary>
    /// A rest area is part of a Road, meant to stop and rest. More often than not, there is a filling station
    /// <see href="http://dbpedia.org/ontology/RestArea"></see></summary>
    let RestArea = _prefix "RestArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Restaurant"></see>
    /// </summary>
    let Restaurant = _prefix "Restaurant"
    /// <summary>
    /// A Resume describes a persons work experience and skill set.
    /// <see href="http://dbpedia.org/ontology/Resume"></see></summary>
    let Resume = _prefix "Resume"
    /// <summary>
    /// a large natural stream
    /// <see href="http://dbpedia.org/ontology/River"></see></summary>
    let River = _prefix "River"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Road"></see>
    /// </summary>
    let Road = _prefix "Road"
    /// <summary>
    /// A road junction is a location where vehicular traffic going in different directions can proceed in a controlled manner designed to minimize accidents. In some cases, vehicles can change between different routes or directions of travel (http://en.wikipedia.org/wiki/Junction_%28road%29).
    /// <see href="http://dbpedia.org/ontology/RoadJunction"></see></summary>
    let RoadJunction = _prefix "RoadJunction"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RoadTunnel"></see>
    /// </summary>
    let RoadTunnel = _prefix "RoadTunnel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Rocket"></see>
    /// </summary>
    let Rocket = _prefix "Rocket"
    /// <summary>
    /// Payload mass in a typical Low Earth orbit
    /// <see href="http://dbpedia.org/ontology/Rocket/lowerEarthOrbitPayload"></see></summary>
    let ``Rocket/lowerEarthOrbitPayload`` = _prefix "Rocket/lowerEarthOrbitPayload"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Rocket/mass"></see>
    /// </summary>
    let ``Rocket/mass`` = _prefix "Rocket/mass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RocketEngine"></see>
    /// </summary>
    let RocketEngine = _prefix "RocketEngine"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RollerCoaster"></see>
    /// </summary>
    let RollerCoaster = _prefix "RollerCoaster"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RomanEmperor"></see>
    /// </summary>
    let RomanEmperor = _prefix "RomanEmperor"
    /// <summary>
    /// one stage or stop on a road.
    /// <see href="http://dbpedia.org/ontology/RouteStop"></see></summary>
    let RouteStop = _prefix "RouteStop"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Rower"></see>
    /// </summary>
    let Rower = _prefix "Rower"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RugbyClub"></see>
    /// </summary>
    let RugbyClub = _prefix "RugbyClub"
    /// <summary>
    /// A group of sports teams that compete against each other in rugby.
    /// <see href="http://dbpedia.org/ontology/RugbyLeague"></see></summary>
    let RugbyLeague = _prefix "RugbyLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RugbyPlayer"></see>
    /// </summary>
    let RugbyPlayer = _prefix "RugbyPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Saint"></see>
    /// </summary>
    let Saint = _prefix "Saint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Sales"></see>
    /// </summary>
    let Sales = _prefix "Sales"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SambaSchool"></see>
    /// </summary>
    let SambaSchool = _prefix "SambaSchool"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/School"></see>
    /// </summary>
    let School = _prefix "School"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/School/campusSize"></see>
    /// </summary>
    let ``School/campusSize`` = _prefix "School/campusSize"
    /// <summary>
    /// Scientific concepts, e.g. Theory of relativity, Quantum gravity
    /// <see href="http://dbpedia.org/ontology/ScientificConcept"></see></summary>
    let ScientificConcept = _prefix "ScientificConcept"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ScreenWriter"></see>
    /// </summary>
    let ScreenWriter = _prefix "ScreenWriter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Sculptor"></see>
    /// </summary>
    let Sculptor = _prefix "Sculptor"
    /// <summary>
    /// Sculpture is three-dimensional artwork created by shaping or combining hard materials, typically stone such as marble, metal, glass, or wood, or plastic materials such as clay, textiles, polymers and softer metals.
    /// <see href="http://dbpedia.org/ontology/Sculpture"></see></summary>
    let Sculpture = _prefix "Sculpture"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Sea"></see>
    /// </summary>
    let Sea = _prefix "Sea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Senator"></see>
    /// </summary>
    let Senator = _prefix "Senator"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SerialKiller"></see>
    /// </summary>
    let SerialKiller = _prefix "SerialKiller"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Ship"></see>
    /// </summary>
    let Ship = _prefix "Ship"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ShoppingMall"></see>
    /// </summary>
    let ShoppingMall = _prefix "ShoppingMall"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Shrine"></see>
    /// </summary>
    let Shrine = _prefix "Shrine"
    /// <summary>
    /// a person who sings.
    /// <see href="http://dbpedia.org/ontology/Singer"></see></summary>
    let Singer = _prefix "Singer"
    /// <summary>
    /// In music, a single or record single is a type of release, typically a recording of fewer tracks than an LP or a CD.
    /// <see href="http://dbpedia.org/ontology/Single"></see></summary>
    let Single = _prefix "Single"
    /// <summary>
    /// A Site of Special Scientific Interest (SSSI) is a conservation designation denoting a protected area in the United Kingdom. SSSIs are the basic building block of site-based nature conservation legislation and most other legal nature/geological conservation designations in Great Britain are based upon them, including National Nature Reserves, Ramsar Sites, Special Protection Areas, and Special Areas of Conservation.
    /// <see href="http://dbpedia.org/ontology/SiteOfSpecialScientificInterest"></see></summary>
    let SiteOfSpecialScientificInterest = _prefix "SiteOfSpecialScientificInterest"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Skater"></see>
    /// </summary>
    let Skater = _prefix "Skater"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SkiArea"></see>
    /// </summary>
    let SkiArea = _prefix "SkiArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SkiResort"></see>
    /// </summary>
    let SkiResort = _prefix "SkiResort"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Ski_jumper"></see>
    /// </summary>
    let Ski_jumper = _prefix "Ski_jumper"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Skier"></see>
    /// </summary>
    let Skier = _prefix "Skier"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Skyscraper"></see>
    /// </summary>
    let Skyscraper = _prefix "Skyscraper"
    /// <summary>
    /// An athlete that plays snooker and won the world championship at least once
    /// <see href="http://dbpedia.org/ontology/SnookerChamp"></see></summary>
    let SnookerChamp = _prefix "SnookerChamp"
    /// <summary>
    /// An athlete that plays snooker, which is a billard derivate
    /// <see href="http://dbpedia.org/ontology/SnookerPlayer"></see></summary>
    let SnookerPlayer = _prefix "SnookerPlayer"
    /// <summary>
    /// The official world ranking in snooker for a certain year/season
    /// <see href="http://dbpedia.org/ontology/SnookerWorldRanking"></see></summary>
    let SnookerWorldRanking = _prefix "SnookerWorldRanking"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoapCharacter"></see>
    /// </summary>
    let SoapCharacter = _prefix "SoapCharacter"
    /// <summary>
    /// A sports game in which the ball must be played by foot
    /// <see href="http://dbpedia.org/ontology/Soccer"></see></summary>
    let Soccer = _prefix "Soccer"
    /// <summary>
    /// A team sport is commonly defined as a sport that is being played by competing teams
    /// <see href="http://dbpedia.org/ontology/TeamSport"></see></summary>
    let TeamSport = _prefix "TeamSport"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoccerClubSeason"></see>
    /// </summary>
    let SoccerClubSeason = _prefix "SoccerClubSeason"
    /// <summary>
    /// A group of sports teams that compete against each other in soccer.
    /// <see href="http://dbpedia.org/ontology/SoccerLeague"></see></summary>
    let SoccerLeague = _prefix "SoccerLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoccerLeagueSeason"></see>
    /// </summary>
    let SoccerLeagueSeason = _prefix "SoccerLeagueSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoccerManager"></see>
    /// </summary>
    let SoccerManager = _prefix "SoccerManager"
    /// <summary>
    /// According to the french label sub Soccer, trainership could be meant. However, here a Sportsmanager is interpreted as a member of the board of a sporting club.
    /// <see href="http://dbpedia.org/ontology/SportsManager"></see></summary>
    let SportsManager = _prefix "SportsManager"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoccerPlayer"></see>
    /// </summary>
    let SoccerPlayer = _prefix "SoccerPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoccerTournament"></see>
    /// </summary>
    let SoccerTournament = _prefix "SoccerTournament"
    /// <summary>
    /// A group of sports teams that compete against each other in softball.
    /// <see href="http://dbpedia.org/ontology/SoftballLeague"></see></summary>
    let SoftballLeague = _prefix "SoftballLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Software"></see>
    /// </summary>
    let Software = _prefix "Software"
    /// <summary>
    /// size of a file or software
    /// <see href="http://dbpedia.org/ontology/Software/fileSize"></see></summary>
    let ``Software/fileSize`` = _prefix "Software/fileSize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SolarEclipse"></see>
    /// </summary>
    let SolarEclipse = _prefix "SolarEclipse"
    /// <summary>
    /// a person who writes songs.
    /// <see href="http://dbpedia.org/ontology/SongWriter"></see></summary>
    let SongWriter = _prefix "SongWriter"
    /// <summary>
    /// An audio document intended to be listened to; equivalent to http://purl.org/dc/dcmitype/Sound
    /// <see href="http://dbpedia.org/ontology/Sound"></see></summary>
    let Sound = _prefix "Sound"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission"></see>
    /// </summary>
    let SpaceMission = _prefix "SpaceMission"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/cmpEvaDuration"></see>
    /// </summary>
    let ``SpaceMission/cmpEvaDuration`` = _prefix "SpaceMission/cmpEvaDuration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/distanceTraveled"></see>
    /// </summary>
    let ``SpaceMission/distanceTraveled`` = _prefix "SpaceMission/distanceTraveled"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/lunarEvaTime"></see>
    /// </summary>
    let ``SpaceMission/lunarEvaTime`` = _prefix "SpaceMission/lunarEvaTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/lunarOrbitTime"></see>
    /// </summary>
    let ``SpaceMission/lunarOrbitTime`` = _prefix "SpaceMission/lunarOrbitTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/lunarSampleMass"></see>
    /// </summary>
    let ``SpaceMission/lunarSampleMass`` = _prefix "SpaceMission/lunarSampleMass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/lunarSurfaceTime"></see>
    /// </summary>
    let ``SpaceMission/lunarSurfaceTime`` = _prefix "SpaceMission/lunarSurfaceTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/mass"></see>
    /// </summary>
    let ``SpaceMission/mass`` = _prefix "SpaceMission/mass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/missionDuration"></see>
    /// </summary>
    let ``SpaceMission/missionDuration`` = _prefix "SpaceMission/missionDuration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/stationEvaDuration"></see>
    /// </summary>
    let ``SpaceMission/stationEvaDuration`` = _prefix "SpaceMission/stationEvaDuration"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/stationVisitDuration"></see>
    /// </summary>
    let ``SpaceMission/stationVisitDuration`` =
        _prefix "SpaceMission/stationVisitDuration"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceShuttle"></see>
    /// </summary>
    let SpaceShuttle = _prefix "SpaceShuttle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceShuttle/distance"></see>
    /// </summary>
    let ``SpaceShuttle/distance`` = _prefix "SpaceShuttle/distance"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceShuttle/timeInSpace"></see>
    /// </summary>
    let ``SpaceShuttle/timeInSpace`` = _prefix "SpaceShuttle/timeInSpace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceStation"></see>
    /// </summary>
    let SpaceStation = _prefix "SpaceStation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceStation/volume"></see>
    /// </summary>
    let ``SpaceStation/volume`` = _prefix "SpaceStation/volume"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft"></see>
    /// </summary>
    let Spacecraft = _prefix "Spacecraft"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/apoapsis"></see>
    /// </summary>
    let ``Spacecraft/apoapsis`` = _prefix "Spacecraft/apoapsis"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/cargoFuel"></see>
    /// </summary>
    let ``Spacecraft/cargoFuel`` = _prefix "Spacecraft/cargoFuel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/cargoGas"></see>
    /// </summary>
    let ``Spacecraft/cargoGas`` = _prefix "Spacecraft/cargoGas"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/cargoWater"></see>
    /// </summary>
    let ``Spacecraft/cargoWater`` = _prefix "Spacecraft/cargoWater"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/dockedTime"></see>
    /// </summary>
    let ``Spacecraft/dockedTime`` = _prefix "Spacecraft/dockedTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/dryCargo"></see>
    /// </summary>
    let ``Spacecraft/dryCargo`` = _prefix "Spacecraft/dryCargo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/freeFlightTime"></see>
    /// </summary>
    let ``Spacecraft/freeFlightTime`` = _prefix "Spacecraft/freeFlightTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/periapsis"></see>
    /// </summary>
    let ``Spacecraft/periapsis`` = _prefix "Spacecraft/periapsis"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/totalCargo"></see>
    /// </summary>
    let ``Spacecraft/totalCargo`` = _prefix "Spacecraft/totalCargo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/totalMass"></see>
    /// </summary>
    let ``Spacecraft/totalMass`` = _prefix "Spacecraft/totalMass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpeedSkater"></see>
    /// </summary>
    let SpeedSkater = _prefix "SpeedSkater"
    /// <summary>
    /// A group of sports teams that compete against each other in motorcycle speedway racing.
    /// <see href="http://dbpedia.org/ontology/SpeedwayLeague"></see></summary>
    let SpeedwayLeague = _prefix "SpeedwayLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpeedwayRider"></see>
    /// </summary>
    let SpeedwayRider = _prefix "SpeedwayRider"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpeedwayTeam"></see>
    /// </summary>
    let SpeedwayTeam = _prefix "SpeedwayTeam"
    /// <summary>
    /// A member of an athletic team.
    /// <see href="http://dbpedia.org/ontology/SportsTeamMember"></see></summary>
    let SportsTeamMember = _prefix "SportsTeamMember"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Square"></see>
    /// </summary>
    let Square = _prefix "Square"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SquashPlayer"></see>
    /// </summary>
    let SquashPlayer = _prefix "SquashPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Stadium"></see>
    /// </summary>
    let Stadium = _prefix "Stadium"
    /// <summary>
    /// a common specification
    /// <see href="http://dbpedia.org/ontology/Standard"></see></summary>
    let Standard = _prefix "Standard"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/State"></see>
    /// </summary>
    let State = _prefix "State"
    /// <summary>
    /// A Resolution describes a formal statement adopted by a meeting or convention.
    /// <see href="http://dbpedia.org/ontology/StatedResolution"></see></summary>
    let StatedResolution = _prefix "StatedResolution"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Statistic"></see>
    /// </summary>
    let Statistic = _prefix "Statistic"
    /// <summary>
    /// A visual document that is not intended to be animated; equivalent to http://purl.org/dc/dcmitype/StillImage
    /// <see href="http://dbpedia.org/ontology/StillImage"></see></summary>
    let StillImage = _prefix "StillImage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/StormSurge"></see>
    /// </summary>
    let StormSurge = _prefix "StormSurge"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Stream/discharge"></see>
    /// </summary>
    let ``Stream/discharge`` = _prefix "Stream/discharge"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Stream/dischargeAverage"></see>
    /// </summary>
    let ``Stream/dischargeAverage`` = _prefix "Stream/dischargeAverage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Stream/maximumDischarge"></see>
    /// </summary>
    let ``Stream/maximumDischarge`` = _prefix "Stream/maximumDischarge"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Stream/minimumDischarge"></see>
    /// </summary>
    let ``Stream/minimumDischarge`` = _prefix "Stream/minimumDischarge"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Stream/watershed"></see>
    /// </summary>
    let ``Stream/watershed`` = _prefix "Stream/watershed"
    /// <summary>
    /// A Street is different from a Road in as far as the infrastructure aspect is much less important here. A Street is a social and architectural ensemble much more than the connection between two geographic points.
    /// <see href="http://dbpedia.org/ontology/Street"></see></summary>
    let Street = _prefix "Street"
    /// <summary>
    /// An administrative body governing a territorial unity on the lowest level, administering part of a municipality
    /// <see href="http://dbpedia.org/ontology/SubMunicipality"></see></summary>
    let SubMunicipality = _prefix "SubMunicipality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SumoWrestler"></see>
    /// </summary>
    let SumoWrestler = _prefix "SumoWrestler"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Wrestler"></see>
    /// </summary>
    let Wrestler = _prefix "Wrestler"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SupremeCourtOfTheUnitedStatesCase"></see>
    /// </summary>
    let SupremeCourtOfTheUnitedStatesCase = _prefix "SupremeCourtOfTheUnitedStatesCase"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Surfer"></see>
    /// </summary>
    let Surfer = _prefix "Surfer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Surname"></see>
    /// </summary>
    let Surname = _prefix "Surname"
    /// <summary>
    /// a trained athlete who participates in swimming meets
    /// <see href="http://dbpedia.org/ontology/Swimmer"></see></summary>
    let Swimmer = _prefix "Swimmer"
    /// <summary>
    /// A synagogue, sometimes spelt synagog, is a Jewish or Samaritan house of prayer.
    /// <see href="http://dbpedia.org/ontology/Synagogue"></see></summary>
    let Synagogue = _prefix "Synagogue"
    /// <summary>
    /// a system of legislation, either national or international
    /// <see href="http://dbpedia.org/ontology/SystemOfLaw"></see></summary>
    let SystemOfLaw = _prefix "SystemOfLaw"
    /// <summary>
    /// Athlete who plays table tennis
    /// <see href="http://dbpedia.org/ontology/TableTennisPlayer"></see></summary>
    let TableTennisPlayer = _prefix "TableTennisPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Tax"></see>
    /// </summary>
    let Tax = _prefix "Tax"
    /// <summary>
    /// a category within a classification system for Species
    /// <see href="http://dbpedia.org/ontology/Taxon"></see></summary>
    let Taxon = _prefix "Taxon"
    /// <summary>
    /// A member of an athletic team.
    /// <see href="http://dbpedia.org/ontology/TeamMember"></see></summary>
    let TeamMember = _prefix "TeamMember"
    /// <summary>
    /// a person who directs the activities involved in making a television program.
    /// <see href="http://dbpedia.org/ontology/TelevisionDirector"></see></summary>
    let TelevisionDirector = _prefix "TelevisionDirector"
    /// <summary>
    /// A television episode is a part of serial television program.
    /// <see href="http://dbpedia.org/ontology/TelevisionEpisode"></see></summary>
    let TelevisionEpisode = _prefix "TelevisionEpisode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TelevisionHost"></see>
    /// </summary>
    let TelevisionHost = _prefix "TelevisionHost"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TelevisionSeason"></see>
    /// </summary>
    let TelevisionSeason = _prefix "TelevisionSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TelevisionShow"></see>
    /// </summary>
    let TelevisionShow = _prefix "TelevisionShow"
    /// <summary>
    /// A television station has usually one line up. For instance the television station WABC-TV (or ABC 7, Channel 7). Not to be confused with the broadcasting network ABC, which has many television stations.
    /// <see href="http://dbpedia.org/ontology/TelevisionStation"></see></summary>
    let TelevisionStation = _prefix "TelevisionStation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Temple"></see>
    /// </summary>
    let Temple = _prefix "Temple"
    /// <summary>
    /// A group of sports teams or person that compete against each other in tennis.
    /// <see href="http://dbpedia.org/ontology/TennisLeague"></see></summary>
    let TennisLeague = _prefix "TennisLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TennisPlayer"></see>
    /// </summary>
    let TennisPlayer = _prefix "TennisPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TennisTournament"></see>
    /// </summary>
    let TennisTournament = _prefix "TennisTournament"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TermOfOffice"></see>
    /// </summary>
    let TermOfOffice = _prefix "TermOfOffice"
    /// <summary>
    /// A theater or theatre (also a playhouse) is a structure where theatrical works or plays are performed or other performances such as musical concerts may be produced.
    /// <see href="http://dbpedia.org/ontology/Theatre"></see></summary>
    let Theatre = _prefix "Theatre"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Venue"></see>
    /// </summary>
    let Venue = _prefix "Venue"
    /// <summary>
    /// A director in the theatre field who oversees and orchestrates the mounting of a theatre production.
    /// <see href="http://dbpedia.org/ontology/TheatreDirector"></see></summary>
    let TheatreDirector = _prefix "TheatreDirector"
    /// <summary>
    /// a settlement ranging from a few hundred to several thousand (occasionally hundreds of thousands). The precise meaning varies between countries and is not always a matter of legal definition. Usually, a town is thought of as larger than a village but smaller than a city, though there are exceptions to this rule.
    /// <see href="http://dbpedia.org/ontology/Town"></see></summary>
    let Town = _prefix "Town"
    /// <summary>
    /// A list of music tracks, like on a CD
    /// <see href="http://dbpedia.org/ontology/TrackList"></see></summary>
    let TrackList = _prefix "TrackList"
    /// <summary>
    /// A trade union or labor union is an organization of workers who have banded together to achieve common goals such as better working conditions.
    /// <see href="http://dbpedia.org/ontology/TradeUnion"></see></summary>
    let TradeUnion = _prefix "TradeUnion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Train"></see>
    /// </summary>
    let Train = _prefix "Train"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TrainCarriage"></see>
    /// </summary>
    let TrainCarriage = _prefix "TrainCarriage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Tram"></see>
    /// </summary>
    let Tram = _prefix "Tram"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TramStation"></see>
    /// </summary>
    let TramStation = _prefix "TramStation"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/%3Chttp://vocab.org/transit/terms/stop%3E"></see>
    /// </summary>
    let ``_%3Chttp://vocab.org/transit/terms/stop%3E`` =
        _prefix "%3Chttp://vocab.org/transit/terms/stop%3E"

    /// <summary>
    /// A mill driven by the tractive power of horses, donkeys or even people
    /// <see href="http://dbpedia.org/ontology/Treadmill"></see></summary>
    let Treadmill = _prefix "Treadmill"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Treaty"></see>
    /// </summary>
    let Treaty = _prefix "Treaty"
    /// <summary>
    /// A tunnel may be for foot or vehicular road traffic, for rail traffic, or for a canal. Some tunnels are aqueducts to supply water for consumption or for hydroelectric stations or are sewers (http://en.wikipedia.org/wiki/Tunnel).
    /// <see href="http://dbpedia.org/ontology/Tunnel"></see></summary>
    let Tunnel = _prefix "Tunnel"
    /// <summary>
    /// An underground journal is, although over time there have always been publications forbidden by law, a phenomenon typical of countries occupied by the Germans during the Second World War. The writing in the underground press aims at stiffening a spirit of resistance against Nazi occupation. The distribution of underground journals had to be very secretive and was, therefore, very much dependant on illegal distribution circuits and the hazards of persecution by the occupant.
    /// <see href="http://dbpedia.org/ontology/UndergroundJournal"></see></summary>
    let UndergroundJournal = _prefix "UndergroundJournal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/University"></see>
    /// </summary>
    let University = _prefix "University"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Unknown"></see>
    /// </summary>
    let Unknown = _prefix "Unknown"
    /// <summary>
    /// a depression with predominant extent in one direction
    /// <see href="http://dbpedia.org/ontology/Valley"></see></summary>
    let Valley = _prefix "Valley"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Vein"></see>
    /// </summary>
    let Vein = _prefix "Vein"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Vicar"></see>
    /// </summary>
    let Vicar = _prefix "Vicar"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/VicePresident"></see>
    /// </summary>
    let VicePresident = _prefix "VicePresident"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/VicePrimeMinister"></see>
    /// </summary>
    let VicePrimeMinister = _prefix "VicePrimeMinister"
    /// <summary>
    /// A video game is an electronic game that involves interaction with a user interface to generate visual feedback on a video device.
    /// <see href="http://dbpedia.org/ontology/VideoGame"></see></summary>
    let VideoGame = _prefix "VideoGame"
    /// <summary>
    /// A group of sports teams or person that compete against each other in videogames.
    /// <see href="http://dbpedia.org/ontology/VideogamesLeague"></see></summary>
    let VideogamesLeague = _prefix "VideogamesLeague"
    /// <summary>
    /// a clustered human settlement or community, usually smaller a town
    /// <see href="http://dbpedia.org/ontology/Village"></see></summary>
    let Village = _prefix "Village"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Vodka"></see>
    /// </summary>
    let Vodka = _prefix "Vodka"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/VoiceActor"></see>
    /// </summary>
    let VoiceActor = _prefix "VoiceActor"
    /// <summary>
    /// A volcano is currently subclass of naturalplace, but it might also be considered a mountain.
    /// <see href="http://dbpedia.org/ontology/Volcano"></see></summary>
    let Volcano = _prefix "Volcano"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/VolleyballCoach"></see>
    /// </summary>
    let VolleyballCoach = _prefix "VolleyballCoach"
    /// <summary>
    /// A group of sports teams that compete against each other in volleyball.
    /// <see href="http://dbpedia.org/ontology/VolleyballLeague"></see></summary>
    let VolleyballLeague = _prefix "VolleyballLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WaterPoloPlayer"></see>
    /// </summary>
    let WaterPoloPlayer = _prefix "WaterPoloPlayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WaterRide"></see>
    /// </summary>
    let WaterRide = _prefix "WaterRide"
    /// <summary>
    /// a construction designed to store larger quantities of water at a place of some elevation in order to keep pressure on the water provision system
    /// <see href="http://dbpedia.org/ontology/WaterTower"></see></summary>
    let WaterTower = _prefix "WaterTower"
    /// <summary>
    /// A watermill is a structure that uses a water wheel or turbine to drive a mechanical process such as flour, lumber or textile production, or metal shaping (rolling, grinding or wire drawing)
    /// <see href="http://dbpedia.org/ontology/Watermill"></see></summary>
    let Watermill = _prefix "Watermill"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WaterwayTunnel"></see>
    /// </summary>
    let WaterwayTunnel = _prefix "WaterwayTunnel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Weapon"></see>
    /// </summary>
    let Weapon = _prefix "Weapon"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Weapon/diameter"></see>
    /// </summary>
    let ``Weapon/diameter`` = _prefix "Weapon/diameter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Weapon/height"></see>
    /// </summary>
    let ``Weapon/height`` = _prefix "Weapon/height"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Weapon/length"></see>
    /// </summary>
    let ``Weapon/length`` = _prefix "Weapon/length"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Weapon/weight"></see>
    /// </summary>
    let ``Weapon/weight`` = _prefix "Weapon/weight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Weapon/width"></see>
    /// </summary>
    let ``Weapon/width`` = _prefix "Weapon/width"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Website"></see>
    /// </summary>
    let Website = _prefix "Website"
    /// <summary>
    /// A wind-driven turbine that adapts itself to wind direction and to wind-force. Is considered to be a class in its own, despite the wind as common factor with Windmill.
    /// <see href="http://dbpedia.org/ontology/WindMotor"></see></summary>
    let WindMotor = _prefix "WindMotor"
    /// <summary>
    /// A windmill is a machine that converts the energy of wind into rotational energy by means of vanes called sails
    /// <see href="http://dbpedia.org/ontology/Windmill"></see></summary>
    let Windmill = _prefix "Windmill"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WineRegion"></see>
    /// </summary>
    let WineRegion = _prefix "WineRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Winery"></see>
    /// </summary>
    let Winery = _prefix "Winery"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WomensTennisAssociationTournament"></see>
    /// </summary>
    let WomensTennisAssociationTournament = _prefix "WomensTennisAssociationTournament"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Work/runtime"></see>
    /// </summary>
    let ``Work/runtime`` = _prefix "Work/runtime"
    /// <summary>
    /// A UNESCO World Heritage Site is a site (such as a forest, mountain, lake, desert, monument, building, complex, or city) that is on the list that is maintained by the international World Heritage Programme administered by the UNESCO World Heritage Committee, composed of 21 state parties which are elected by their General Assembly for a four-year term. A World Heritage Site is a place of either cultural or physical significance.
    /// <see href="http://dbpedia.org/ontology/WorldHeritageSite"></see></summary>
    let WorldHeritageSite = _prefix "WorldHeritageSite"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WrestlingEvent"></see>
    /// </summary>
    let WrestlingEvent = _prefix "WrestlingEvent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Year"></see>
    /// </summary>
    let Year = _prefix "Year"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/YearInSpaceflight"></see>
    /// </summary>
    let YearInSpaceflight = _prefix "YearInSpaceflight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Zoo"></see>
    /// </summary>
    let Zoo = _prefix "Zoo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aSide"></see>
    /// </summary>
    let aSide = _prefix "aSide"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/abbeychurchBlessing"></see>
    /// </summary>
    let abbeychurchBlessing = _prefix "abbeychurchBlessing"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/abbeychurchBlessingCharge"></see>
    /// </summary>
    let abbeychurchBlessingCharge = _prefix "abbeychurchBlessingCharge"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/abbreviation"></see>
    /// </summary>
    let abbreviation = _prefix "abbreviation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ableToGrind"></see>
    /// </summary>
    let ableToGrind = _prefix "ableToGrind"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/absoluteMagnitude"></see>
    /// </summary>
    let absoluteMagnitude = _prefix "absoluteMagnitude"
    /// <summary>
    /// Number of abstentions from the vote
    /// <see href="http://dbpedia.org/ontology/abstentions"></see></summary>
    let abstentions = _prefix "abstentions"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/abstract"></see></summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/academicAdvisor"></see>
    /// </summary>
    let academicAdvisor = _prefix "academicAdvisor"
    /// <summary>
    /// An academic discipline, or field of study, is a branch of knowledge that is taught and researched at the college or university level. Disciplines are defined (in part), and recognized by the academic journals in which research is published, and the learned societies and academic departments or faculties to which their practitioners belong.
    /// <see href="http://dbpedia.org/ontology/academicDiscipline"></see></summary>
    let academicDiscipline = _prefix "academicDiscipline"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/academyAward"></see>
    /// </summary>
    let academyAward = _prefix "academyAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/acceleration"></see>
    /// </summary>
    let acceleration = _prefix "acceleration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/access"></see>
    /// </summary>
    let access = _prefix "access"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/accessDate"></see>
    /// </summary>
    let accessDate = _prefix "accessDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/achievement"></see>
    /// </summary>
    let achievement = _prefix "achievement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/acquirementDate"></see>
    /// </summary>
    let acquirementDate = _prefix "acquirementDate"
    /// <summary>
    /// most recent average ACT scores
    /// <see href="http://dbpedia.org/ontology/actScore"></see></summary>
    let actScore = _prefix "actScore"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/actingHeadteacher"></see>
    /// </summary>
    let actingHeadteacher = _prefix "actingHeadteacher"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYear"></see>
    /// </summary>
    let activeYear = _prefix "activeYear"
    /// <summary>
    /// Also called "floruit". Use this if the active years are in one field that can't be split. Else use activeYearsStartYear and activeYearsEndYear
    /// <see href="http://dbpedia.org/ontology/activeYears"></see></summary>
    let activeYears = _prefix "activeYears"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsEndDate"></see>
    /// </summary>
    let activeYearsEndDate = _prefix "activeYearsEndDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsEndDateMgr"></see>
    /// </summary>
    let activeYearsEndDateMgr = _prefix "activeYearsEndDateMgr"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsEndYear"></see>
    /// </summary>
    let activeYearsEndYear = _prefix "activeYearsEndYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsEndYearMgr"></see>
    /// </summary>
    let activeYearsEndYearMgr = _prefix "activeYearsEndYearMgr"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsStartDate"></see>
    /// </summary>
    let activeYearsStartDate = _prefix "activeYearsStartDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsStartDateMgr"></see>
    /// </summary>
    let activeYearsStartDateMgr = _prefix "activeYearsStartDateMgr"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsStartYear"></see>
    /// </summary>
    let activeYearsStartYear = _prefix "activeYearsStartYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsStartYearMgr"></see>
    /// </summary>
    let activeYearsStartYearMgr = _prefix "activeYearsStartYearMgr"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activity"></see>
    /// </summary>
    let activity = _prefix "activity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/added"></see>
    /// </summary>
    let added = _prefix "added"
    /// <summary>
    /// Address of something as literal. Usually Building, but we also use it for the address of a Region's or Settlement's government
    /// <see href="http://dbpedia.org/ontology/address"></see></summary>
    let address = _prefix "address"
    /// <summary>
    /// A building, organisation or other thing that is located in the road.
    /// <see href="http://dbpedia.org/ontology/addressInRoad"></see></summary>
    let addressInRoad = _prefix "addressInRoad"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/adjacentSettlement"></see>
    /// </summary>
    let adjacentSettlement = _prefix "adjacentSettlement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/administrativeCenter"></see>
    /// </summary>
    let administrativeCenter = _prefix "administrativeCenter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/administrativeCollectivity"></see>
    /// </summary>
    let administrativeCollectivity = _prefix "administrativeCollectivity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/administrativeDistrict"></see>
    /// </summary>
    let administrativeDistrict = _prefix "administrativeDistrict"
    /// <summary>
    /// city where stand the administrative power
    /// <see href="http://dbpedia.org/ontology/administrativeHeadCity"></see></summary>
    let administrativeHeadCity = _prefix "administrativeHeadCity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/administrativeStatus"></see>
    /// </summary>
    let administrativeStatus = _prefix "administrativeStatus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/administrator"></see>
    /// </summary>
    let administrator = _prefix "administrator"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/afdbId"></see>
    /// </summary>
    let afdbId = _prefix "afdbId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/affair"></see>
    /// </summary>
    let affair = _prefix "affair"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/affiliate"></see>
    /// </summary>
    let affiliate = _prefix "affiliate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/affiliation"></see>
    /// </summary>
    let affiliation = _prefix "affiliation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/afiAward"></see>
    /// </summary>
    let afiAward = _prefix "afiAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/age"></see>
    /// </summary>
    let age = _prefix "age"
    /// <summary>
    /// Age range of students admitted in a School, MilitaryUnit, etc
    /// <see href="http://dbpedia.org/ontology/ageRange"></see></summary>
    let ageRange = _prefix "ageRange"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agency"></see>
    /// </summary>
    let agency = _prefix "agency"
    /// <summary>
    /// Agency station code (used on tickets/reservations, etc.).
    /// <see href="http://dbpedia.org/ontology/agencyStationCode"></see></summary>
    let agencyStationCode = _prefix "agencyStationCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agglomeration"></see>
    /// </summary>
    let agglomeration = _prefix "agglomeration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agglomerationArea"></see>
    /// </summary>
    let agglomerationArea = _prefix "agglomerationArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agglomerationDemographics"></see>
    /// </summary>
    let agglomerationDemographics = _prefix "agglomerationDemographics"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agglomerationPopulation"></see>
    /// </summary>
    let agglomerationPopulation = _prefix "agglomerationPopulation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agglomerationPopulationTotal"></see>
    /// </summary>
    let agglomerationPopulationTotal = _prefix "agglomerationPopulationTotal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agglomerationPopulationYear"></see>
    /// </summary>
    let agglomerationPopulationYear = _prefix "agglomerationPopulationYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aggregation"></see>
    /// </summary>
    let aggregation = _prefix "aggregation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/airDate"></see>
    /// </summary>
    let airDate = _prefix "airDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftAttack"></see>
    /// </summary>
    let aircraftAttack = _prefix "aircraftAttack"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftBomber"></see>
    /// </summary>
    let aircraftBomber = _prefix "aircraftBomber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftElectronic"></see>
    /// </summary>
    let aircraftElectronic = _prefix "aircraftElectronic"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftFighter"></see>
    /// </summary>
    let aircraftFighter = _prefix "aircraftFighter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopter"></see>
    /// </summary>
    let aircraftHelicopter = _prefix "aircraftHelicopter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopterAttack"></see>
    /// </summary>
    let aircraftHelicopterAttack = _prefix "aircraftHelicopterAttack"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopterCargo"></see>
    /// </summary>
    let aircraftHelicopterCargo = _prefix "aircraftHelicopterCargo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopterMultirole"></see>
    /// </summary>
    let aircraftHelicopterMultirole = _prefix "aircraftHelicopterMultirole"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopterObservation"></see>
    /// </summary>
    let aircraftHelicopterObservation = _prefix "aircraftHelicopterObservation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopterTransport"></see>
    /// </summary>
    let aircraftHelicopterTransport = _prefix "aircraftHelicopterTransport"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopterUtility"></see>
    /// </summary>
    let aircraftHelicopterUtility = _prefix "aircraftHelicopterUtility"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftInterceptor"></see>
    /// </summary>
    let aircraftInterceptor = _prefix "aircraftInterceptor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftPatrol"></see>
    /// </summary>
    let aircraftPatrol = _prefix "aircraftPatrol"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftRecon"></see>
    /// </summary>
    let aircraftRecon = _prefix "aircraftRecon"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftTrainer"></see>
    /// </summary>
    let aircraftTrainer = _prefix "aircraftTrainer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftTransport"></see>
    /// </summary>
    let aircraftTransport = _prefix "aircraftTransport"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftType"></see>
    /// </summary>
    let aircraftType = _prefix "aircraftType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftUser"></see>
    /// </summary>
    let aircraftUser = _prefix "aircraftUser"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/airportUsing"></see>
    /// </summary>
    let airportUsing = _prefix "airportUsing"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aitaCode"></see>
    /// </summary>
    let aitaCode = _prefix "aitaCode"
    /// <summary>
    /// reflection coefficient
    /// <see href="http://dbpedia.org/ontology/albedo"></see></summary>
    let albedo = _prefix "albedo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/album"></see>
    /// </summary>
    let album = _prefix "album"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/albumRuntime"></see>
    /// </summary>
    let albumRuntime = _prefix "albumRuntime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/alias"></see>
    /// </summary>
    let alias = _prefix "alias"
    /// <summary>
    /// Alternative naming of anything not being a Person (for which case foaf:nick should be used).
    /// <see href="http://dbpedia.org/ontology/alternativeName"></see></summary>
    let alternativeName = _prefix "alternativeName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/allcinemaId"></see>
    /// </summary>
    let allcinemaId = _prefix "allcinemaId"
    /// <summary>
    /// The country or other power the person served. Multiple countries may be indicated together with the corresponding dates. This field should not be used to indicate a particular service branch, which is better indicated by the branch field.
    /// <see href="http://dbpedia.org/ontology/allegiance"></see></summary>
    let allegiance = _prefix "allegiance"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/alliance"></see>
    /// </summary>
    let alliance = _prefix "alliance"
    /// <summary>
    /// schools that they attended
    /// <see href="http://dbpedia.org/ontology/almaMater"></see></summary>
    let almaMater = _prefix "almaMater"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/alongside"></see>
    /// </summary>
    let alongside = _prefix "alongside"
    /// <summary>
    /// the Alps group to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsGroup"></see></summary>
    let alpsGroup = _prefix "alpsGroup"
    /// <summary>
    /// the Alps main part to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsMainPart"></see></summary>
    let alpsMainPart = _prefix "alpsMainPart"
    /// <summary>
    /// the Alps major sector to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsMajorSector"></see></summary>
    let alpsMajorSector = _prefix "alpsMajorSector"
    /// <summary>
    /// the Alps section to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsSection"></see></summary>
    let alpsSection = _prefix "alpsSection"
    /// <summary>
    /// the Alps SOIUSA code corresponding to the mountain, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsSoiusaCode"></see></summary>
    let alpsSoiusaCode = _prefix "alpsSoiusaCode"
    /// <summary>
    /// the Alps subgroup to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsSubgroup"></see></summary>
    let alpsSubgroup = _prefix "alpsSubgroup"
    /// <summary>
    /// the Alps subsection to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsSubsection"></see></summary>
    let alpsSubsection = _prefix "alpsSubsection"
    /// <summary>
    /// the Alps supergroup to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsSupergroup"></see></summary>
    let alpsSupergroup = _prefix "alpsSupergroup"
    /// <summary>
    /// The alternative title attributed to a work
    /// <see href="http://dbpedia.org/ontology/alternativeTitle"></see></summary>
    let alternativeTitle = _prefix "alternativeTitle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/altitude"></see>
    /// </summary>
    let altitude = _prefix "altitude"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/alumni"></see>
    /// </summary>
    let alumni = _prefix "alumni"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurDefeat"></see>
    /// </summary>
    let amateurDefeat = _prefix "amateurDefeat"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurFight"></see>
    /// </summary>
    let amateurFight = _prefix "amateurFight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurKo"></see>
    /// </summary>
    let amateurKo = _prefix "amateurKo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurNoContest"></see>
    /// </summary>
    let amateurNoContest = _prefix "amateurNoContest"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurTeam"></see>
    /// </summary>
    let amateurTeam = _prefix "amateurTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Athlete,_CareerStation"></see>
    /// </summary>
    let ``Athlete,_CareerStation`` = _prefix "Athlete,_CareerStation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurTie"></see>
    /// </summary>
    let amateurTie = _prefix "amateurTie"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurTitle"></see>
    /// </summary>
    let amateurTitle = _prefix "amateurTitle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurVictory"></see>
    /// </summary>
    let amateurVictory = _prefix "amateurVictory"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurYear"></see>
    /// </summary>
    let amateurYear = _prefix "amateurYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/americanComedyAward"></see>
    /// </summary>
    let americanComedyAward = _prefix "americanComedyAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amgid"></see>
    /// </summary>
    let amgid = _prefix "amgid"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amsterdamCode"></see>
    /// </summary>
    let amsterdamCode = _prefix "amsterdamCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/analogChannel"></see>
    /// </summary>
    let analogChannel = _prefix "analogChannel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/animal"></see>
    /// </summary>
    let animal = _prefix "animal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/animator"></see>
    /// </summary>
    let animator = _prefix "animator"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/anniversary"></see>
    /// </summary>
    let anniversary = _prefix "anniversary"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/announcedFrom"></see>
    /// </summary>
    let announcedFrom = _prefix "announcedFrom"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/annualTemperature"></see>
    /// </summary>
    let annualTemperature = _prefix "annualTemperature"
    /// <summary>
    /// Official song (anthem) of a PopulatedPlace, SportsTeam, School or other
    /// <see href="http://dbpedia.org/ontology/anthem"></see></summary>
    let anthem = _prefix "anthem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/apcPresident"></see>
    /// </summary>
    let apcPresident = _prefix "apcPresident"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/apoapsis"></see>
    /// </summary>
    let apoapsis = _prefix "apoapsis"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/apofocus"></see>
    /// </summary>
    let apofocus = _prefix "apofocus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/apparentMagnitude"></see>
    /// </summary>
    let apparentMagnitude = _prefix "apparentMagnitude"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/appearancesInLeague"></see>
    /// </summary>
    let appearancesInLeague = _prefix "appearancesInLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/appearancesInNationalTeam"></see>
    /// </summary>
    let appearancesInNationalTeam = _prefix "appearancesInNationalTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/appointer"></see>
    /// </summary>
    let appointer = _prefix "appointer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/approach"></see>
    /// </summary>
    let approach = _prefix "approach"
    /// <summary>
    /// Date of approval by lower parliament (House of Commons, Chambre des Députés, Bundestag, Tweede Kamer etc.).
    /// <see href="http://dbpedia.org/ontology/approvedByLowerParliament"></see></summary>
    let approvedByLowerParliament = _prefix "approvedByLowerParliament"
    /// <summary>
    /// Date of approval by upper parliament (House of Lords, Sénat, Eerste Kamer etc.).
    /// <see href="http://dbpedia.org/ontology/approvedByUpperParliament"></see></summary>
    let approvedByUpperParliament = _prefix "approvedByUpperParliament"
    /// <summary>
    /// Approximate calories per serving.
    /// <see href="http://dbpedia.org/ontology/approximateCalories"></see></summary>
    let approximateCalories = _prefix "approximateCalories"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/apskritis"></see>
    /// </summary>
    let apskritis = _prefix "apskritis"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/archipelago"></see>
    /// </summary>
    let archipelago = _prefix "archipelago"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/architect"></see>
    /// </summary>
    let architect = _prefix "architect"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/architectualBureau"></see>
    /// </summary>
    let architectualBureau = _prefix "architectualBureau"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/architecturalMovement"></see>
    /// </summary>
    let architecturalMovement = _prefix "architecturalMovement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/architecturalStyle"></see>
    /// </summary>
    let architecturalStyle = _prefix "architecturalStyle"
    /// <summary>
    /// The area of the thing in square meters.
    /// <see href="http://dbpedia.org/ontology/area"></see></summary>
    let area = _prefix "area"
    /// <summary>
    /// Area code for telephone numbers. Use this not phonePrefix
    /// <see href="http://dbpedia.org/ontology/areaCode"></see></summary>
    let areaCode = _prefix "areaCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaDate"></see>
    /// </summary>
    let areaDate = _prefix "areaDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaLand"></see>
    /// </summary>
    let areaLand = _prefix "areaLand"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaMetro"></see>
    /// </summary>
    let areaMetro = _prefix "areaMetro"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaOfCatchment"></see>
    /// </summary>
    let areaOfCatchment = _prefix "areaOfCatchment"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaOfCatchmentQuote"></see>
    /// </summary>
    let areaOfCatchmentQuote = _prefix "areaOfCatchmentQuote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaOfSearch"></see>
    /// </summary>
    let areaOfSearch = _prefix "areaOfSearch"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaQuote"></see>
    /// </summary>
    let areaQuote = _prefix "areaQuote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaRank"></see>
    /// </summary>
    let areaRank = _prefix "areaRank"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaRural"></see>
    /// </summary>
    let areaRural = _prefix "areaRural"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaTotal"></see>
    /// </summary>
    let areaTotal = _prefix "areaTotal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaTotalRanking"></see>
    /// </summary>
    let areaTotalRanking = _prefix "areaTotalRanking"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaUrban"></see>
    /// </summary>
    let areaUrban = _prefix "areaUrban"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaWater"></see>
    /// </summary>
    let areaWater = _prefix "areaWater"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/argueDate"></see>
    /// </summary>
    let argueDate = _prefix "argueDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/arielAward"></see>
    /// </summary>
    let arielAward = _prefix "arielAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/arm"></see>
    /// </summary>
    let arm = _prefix "arm"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/army"></see>
    /// </summary>
    let army = _prefix "army"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/arrestDate"></see>
    /// </summary>
    let arrestDate = _prefix "arrestDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/arrondissement"></see>
    /// </summary>
    let arrondissement = _prefix "arrondissement"
    /// <summary>
    /// An influential, wealthy person who supported an artist, craftsman, a scholar or a noble.. See also
    /// <see href="http://dbpedia.org/ontology/artPatron"></see></summary>
    let artPatron = _prefix "artPatron"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/artery"></see>
    /// </summary>
    let artery = _prefix "artery"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/artificialSnowArea"></see>
    /// </summary>
    let artificialSnowArea = _prefix "artificialSnowArea"
    /// <summary>
    /// The performer or creator of the musical work.
    /// <see href="http://dbpedia.org/ontology/artist"></see></summary>
    let artist = _prefix "artist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/artisticFunction"></see>
    /// </summary>
    let artisticFunction = _prefix "artisticFunction"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/asWikiText"></see>
    /// </summary>
    let asWikiText = _prefix "asWikiText"
    /// <summary>
    /// Ascent of a celestial body, aircraft, etc. For person who ascended a mountain, use firstAscent
    /// <see href="http://dbpedia.org/ontology/ascent"></see></summary>
    let ascent = _prefix "ascent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/asiaChampionship"></see>
    /// </summary>
    let asiaChampionship = _prefix "asiaChampionship"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aspectRatio"></see>
    /// </summary>
    let aspectRatio = _prefix "aspectRatio"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/assembly"></see>
    /// </summary>
    let assembly = _prefix "assembly"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/assetUnderManagement"></see>
    /// </summary>
    let assetUnderManagement = _prefix "assetUnderManagement"
    /// <summary>
    /// Assets and liabilities are part of a companis balance sheet. In financial accounting, assets are economic resources. Anything tangible or intangible that is capable of being owned or controlled to produce value and that is held to have positive economic value is considered an asset.
    /// <see href="http://dbpedia.org/ontology/assets"></see></summary>
    let assets = _prefix "assets"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/assistantPrincipal"></see>
    /// </summary>
    let assistantPrincipal = _prefix "assistantPrincipal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associate"></see>
    /// </summary>
    let associate = _prefix "associate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associateEditor"></see>
    /// </summary>
    let associateEditor = _prefix "associateEditor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associateStar"></see>
    /// </summary>
    let associateStar = _prefix "associateStar"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associatedAct"></see>
    /// </summary>
    let associatedAct = _prefix "associatedAct"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associatedBand"></see>
    /// </summary>
    let associatedBand = _prefix "associatedBand"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associatedMusicalArtist"></see>
    /// </summary>
    let associatedMusicalArtist = _prefix "associatedMusicalArtist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associatedRocket"></see>
    /// </summary>
    let associatedRocket = _prefix "associatedRocket"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associationOfLocalGovernment"></see>
    /// </summary>
    let associationOfLocalGovernment = _prefix "associationOfLocalGovernment"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/astrologicalSign"></see>
    /// </summary>
    let astrologicalSign = _prefix "astrologicalSign"
    /// <summary>
    /// Page # where the referenced resource is to be found in the source document
    /// <see href="http://dbpedia.org/ontology/atPage"></see></summary>
    let atPage = _prefix "atPage"
    /// <summary>
    /// Row # where the referenced resource is to be found in the source file
    /// <see href="http://dbpedia.org/ontology/atRowNumber"></see></summary>
    let atRowNumber = _prefix "atRowNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/atcPrefix"></see>
    /// </summary>
    let atcPrefix = _prefix "atcPrefix"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/atcSuffix"></see>
    /// </summary>
    let atcSuffix = _prefix "atcSuffix"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/atcSupplemental"></see>
    /// </summary>
    let atcSupplemental = _prefix "atcSupplemental"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/athletics"></see>
    /// </summary>
    let athletics = _prefix "athletics"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/athleticsDiscipline"></see>
    /// </summary>
    let athleticsDiscipline = _prefix "athleticsDiscipline"
    /// <summary>
    /// the ratio of the average mass of atoms of an element (from a single given sample or source) to 1⁄12 of the mass of an atom of carbon-12
    /// <see href="http://dbpedia.org/ontology/atomicNumber"></see></summary>
    let atomicNumber = _prefix "atomicNumber"
    /// <summary>
    /// Public attorney
    /// <see href="http://dbpedia.org/ontology/attorneyGeneral"></see></summary>
    let attorneyGeneral = _prefix "attorneyGeneral"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/australiaOpenDouble"></see>
    /// </summary>
    let australiaOpenDouble = _prefix "australiaOpenDouble"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/australiaOpenMixed"></see>
    /// </summary>
    let australiaOpenMixed = _prefix "australiaOpenMixed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/australiaOpenSingle"></see>
    /// </summary>
    let australiaOpenSingle = _prefix "australiaOpenSingle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/author"></see>
    /// </summary>
    let author = _prefix "author"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/authority"></see>
    /// </summary>
    let authority = _prefix "authority"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/authorityMandate"></see>
    /// </summary>
    let authorityMandate = _prefix "authorityMandate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/authorityTitle"></see>
    /// </summary>
    let authorityTitle = _prefix "authorityTitle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RomaniaSettlement"></see>
    /// </summary>
    let RomaniaSettlement = _prefix "RomaniaSettlement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/automobileModel"></see>
    /// </summary>
    let automobileModel = _prefix "automobileModel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/automobilePlatform"></see>
    /// </summary>
    let automobilePlatform = _prefix "automobilePlatform"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/autonomy"></see>
    /// </summary>
    let autonomy = _prefix "autonomy"
    /// <summary>
    /// Smartcard for fare payment system for public transit systems that are or will be available at the station.
    /// <see href="http://dbpedia.org/ontology/availableSmartCard"></see></summary>
    let availableSmartCard = _prefix "availableSmartCard"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/average"></see>
    /// </summary>
    let average = _prefix "average"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/averageAnnualGeneration"></see>
    /// </summary>
    let averageAnnualGeneration = _prefix "averageAnnualGeneration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/averageClassSize"></see>
    /// </summary>
    let averageClassSize = _prefix "averageClassSize"
    /// <summary>
    /// Source of the value can be declare by .
    /// <see href="http://dbpedia.org/ontology/averageDepth"></see></summary>
    let averageDepth = _prefix "averageDepth"
    /// <summary>
    /// Is a measure of the distance between a reference height and a point underneath. The exact meaning for a place is unclear. If possible, use  or  to be unambiguous.
    /// <see href="http://dbpedia.org/ontology/depth"></see></summary>
    let depth = _prefix "depth"
    /// <summary>
    /// Source of the  value.
    /// <see href="http://dbpedia.org/ontology/averageDepthQuote"></see></summary>
    let averageDepthQuote = _prefix "averageDepthQuote"
    /// <summary>
    /// The average speed of a thing.
    /// <see href="http://dbpedia.org/ontology/averageSpeed"></see></summary>
    let averageSpeed = _prefix "averageSpeed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/avifaunaPopulation"></see>
    /// </summary>
    let avifaunaPopulation = _prefix "avifaunaPopulation"
    /// <summary>
    /// Award won by a Person, Musical or other Work, RaceHorse, Building, etc
    /// <see href="http://dbpedia.org/ontology/award"></see></summary>
    let award = _prefix "award"
    /// <summary>
    /// Award a person has received (literal). Compare to award (ObjectProperty)
    /// <see href="http://dbpedia.org/ontology/awardName"></see></summary>
    let awardName = _prefix "awardName"
    /// <summary>
    /// A colour represented by its hex code (e.g.: #FF0000 or #40E0D0).
    /// <see href="http://dbpedia.org/ontology/awayColourHexCode"></see></summary>
    let awayColourHexCode = _prefix "awayColourHexCode"
    /// <summary>
    /// A colour represented by its hex code (e.g.: #FF0000 or #40E0D0).
    /// <see href="http://dbpedia.org/ontology/colourHexCode"></see></summary>
    let colourHexCode = _prefix "colourHexCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bSide"></see>
    /// </summary>
    let bSide = _prefix "bSide"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/background"></see>
    /// </summary>
    let background = _prefix "background"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/backhand"></see>
    /// </summary>
    let backhand = _prefix "backhand"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/badGuy"></see>
    /// </summary>
    let badGuy = _prefix "badGuy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/baftaAward"></see>
    /// </summary>
    let baftaAward = _prefix "baftaAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/band"></see>
    /// </summary>
    let band = _prefix "band"
    /// <summary>
    /// A member of the band.
    /// <see href="http://dbpedia.org/ontology/bandMember"></see></summary>
    let bandMember = _prefix "bandMember"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/barPassRate"></see>
    /// </summary>
    let barPassRate = _prefix "barPassRate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/barangays"></see>
    /// </summary>
    let barangays = _prefix "barangays"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/basedOn"></see>
    /// </summary>
    let basedOn = _prefix "basedOn"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/battingSide"></see>
    /// </summary>
    let battingSide = _prefix "battingSide"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/battle"></see>
    /// </summary>
    let battle = _prefix "battle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/battleHonours"></see>
    /// </summary>
    let battleHonours = _prefix "battleHonours"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/beatifiedBy"></see>
    /// </summary>
    let beatifiedBy = _prefix "beatifiedBy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/beatifiedDate"></see>
    /// </summary>
    let beatifiedDate = _prefix "beatifiedDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/beatifiedPlace"></see>
    /// </summary>
    let beatifiedPlace = _prefix "beatifiedPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bedCount"></see>
    /// </summary>
    let bedCount = _prefix "bedCount"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/believers"></see>
    /// </summary>
    let believers = _prefix "believers"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/beltwayCity"></see>
    /// </summary>
    let beltwayCity = _prefix "beltwayCity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bestFinish"></see>
    /// </summary>
    let bestFinish = _prefix "bestFinish"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bestLap"></see>
    /// </summary>
    let bestLap = _prefix "bestLap"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bestRankDouble"></see>
    /// </summary>
    let bestRankDouble = _prefix "bestRankDouble"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bestRankSingle"></see>
    /// </summary>
    let bestRankSingle = _prefix "bestRankSingle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bestWsopRank"></see>
    /// </summary>
    let bestWsopRank = _prefix "bestWsopRank"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bestYearWsop"></see>
    /// </summary>
    let bestYearWsop = _prefix "bestYearWsop"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bgafdId"></see>
    /// </summary>
    let bgafdId = _prefix "bgafdId"
    /// <summary>
    /// BIBSYS is a supplier of library and information systems for all Norwegian university Libraries, the National Library of Norway, college libraries, and a number of research libraries and institutions.
    /// <see href="http://dbpedia.org/ontology/bibsysId"></see></summary>
    let bibsysId = _prefix "bibsysId"
    /// <summary>
    /// Information on station's bicycle facilities.
    /// <see href="http://dbpedia.org/ontology/bicycleInformation"></see></summary>
    let bicycleInformation = _prefix "bicycleInformation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bigPoolRecord"></see>
    /// </summary>
    let bigPoolRecord = _prefix "bigPoolRecord"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/biggestCity"></see>
    /// </summary>
    let biggestCity = _prefix "biggestCity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/billed"></see>
    /// </summary>
    let billed = _prefix "billed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/binomial"></see>
    /// </summary>
    let binomial = _prefix "binomial"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/binomialAuthority"></see>
    /// </summary>
    let binomialAuthority = _prefix "binomialAuthority"
    /// <summary>
    /// "The rate and extent to which the active ingredient or active moiety is absorbed from a drug product and becomes available at the site of action. For drug products that are not intended to be absorbed into the bloodstream, bioavailability may be assessed by measurements intended to reflect the rate and extent to which the active ingredient or active moiety becomes available at the site of action (21CFR320.1)."
    /// <see href="http://dbpedia.org/ontology/bioavailability"></see></summary>
    let bioavailability = _prefix "bioavailability"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bioclimate"></see>
    /// </summary>
    let bioclimate = _prefix "bioclimate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/biome"></see>
    /// </summary>
    let biome = _prefix "biome"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bird"></see>
    /// </summary>
    let bird = _prefix "bird"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/birthDate"></see>
    /// </summary>
    let birthDate = _prefix "birthDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/birthName"></see>
    /// </summary>
    let birthName = _prefix "birthName"
    /// <summary>
    /// where the person was born
    /// <see href="http://dbpedia.org/ontology/birthPlace"></see></summary>
    let birthPlace = _prefix "birthPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/birthSign"></see>
    /// </summary>
    let birthSign = _prefix "birthSign"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/birthYear"></see>
    /// </summary>
    let birthYear = _prefix "birthYear"
    /// <summary>
    /// A bishopric (diocese or episcopal see) is a district under the supervision of a bishop. It is divided into parishes. Compare with eparchy
    /// <see href="http://dbpedia.org/ontology/bishopric"></see></summary>
    let bishopric = _prefix "bishopric"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blackLongDistancePisteNumber"></see>
    /// </summary>
    let blackLongDistancePisteNumber = _prefix "blackLongDistancePisteNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blackSkiPisteNumber"></see>
    /// </summary>
    let blackSkiPisteNumber = _prefix "blackSkiPisteNumber"
    /// <summary>
    /// Coat of arms (heraldic image) or emblem
    /// <see href="http://dbpedia.org/ontology/blazon"></see></summary>
    let blazon = _prefix "blazon"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blazonCaption"></see>
    /// </summary>
    let blazonCaption = _prefix "blazonCaption"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blazonLink"></see>
    /// </summary>
    let blazonLink = _prefix "blazonLink"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blazonRatio"></see>
    /// </summary>
    let blazonRatio = _prefix "blazonRatio"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/block"></see>
    /// </summary>
    let block = _prefix "block"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blockAlloy"></see>
    /// </summary>
    let blockAlloy = _prefix "blockAlloy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bloodGroup"></see>
    /// </summary>
    let bloodGroup = _prefix "bloodGroup"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bloodType"></see>
    /// </summary>
    let bloodType = _prefix "bloodType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blueLongDistancePisteNumber"></see>
    /// </summary>
    let blueLongDistancePisteNumber = _prefix "blueLongDistancePisteNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blueSkiPisteNumber"></see>
    /// </summary>
    let blueSkiPisteNumber = _prefix "blueSkiPisteNumber"
    /// <summary>
    /// Authority data of people listed in the general catalogue of the National Library of France
    /// <see href="http://dbpedia.org/ontology/bnfId"></see></summary>
    let bnfId = _prefix "bnfId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/board"></see>
    /// </summary>
    let board = _prefix "board"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bodyDiscovered"></see>
    /// </summary>
    let bodyDiscovered = _prefix "bodyDiscovered"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bodyStyle"></see>
    /// </summary>
    let bodyStyle = _prefix "bodyStyle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/boiler"></see>
    /// </summary>
    let boiler = _prefix "boiler"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/boilerPressure"></see>
    /// </summary>
    let boilerPressure = _prefix "boilerPressure"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/boilingPoint"></see>
    /// </summary>
    let boilingPoint = _prefix "boilingPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/booster"></see>
    /// </summary>
    let booster = _prefix "booster"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/border"></see>
    /// </summary>
    let border = _prefix "border"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/borough"></see>
    /// </summary>
    let borough = _prefix "borough"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bourgmestre"></see>
    /// </summary>
    let bourgmestre = _prefix "bourgmestre"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bowlRecord"></see>
    /// </summary>
    let bowlRecord = _prefix "bowlRecord"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/boxerCategory"></see>
    /// </summary>
    let boxerCategory = _prefix "boxerCategory"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/boxerStyle"></see>
    /// </summary>
    let boxerStyle = _prefix "boxerStyle"
    /// <summary>
    /// Dutch project with material for 40,000 digitized biographies, including former colonies of the Netherlands.
    /// <see href="http://dbpedia.org/ontology/bpnId"></see></summary>
    let bpnId = _prefix "bpnId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/brainInfoNumber"></see>
    /// </summary>
    let brainInfoNumber = _prefix "brainInfoNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/brainInfoType"></see>
    /// </summary>
    let brainInfoType = _prefix "brainInfoType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/branchFrom"></see>
    /// </summary>
    let branchFrom = _prefix "branchFrom"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/branchTo"></see>
    /// </summary>
    let branchTo = _prefix "branchTo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/brand"></see>
    /// </summary>
    let brand = _prefix "brand"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/breeder"></see>
    /// </summary>
    let breeder = _prefix "breeder"
    /// <summary>
    /// Type of vehicles the bridge carries.
    /// <see href="http://dbpedia.org/ontology/bridgeCarries"></see></summary>
    let bridgeCarries = _prefix "bridgeCarries"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/britishComedyAwards"></see>
    /// </summary>
    let britishComedyAwards = _prefix "britishComedyAwards"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/britishOpen"></see>
    /// </summary>
    let britishOpen = _prefix "britishOpen"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/britishWins"></see>
    /// </summary>
    let britishWins = _prefix "britishWins"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/broadcastArea"></see>
    /// </summary>
    let broadcastArea = _prefix "broadcastArea"
    /// <summary>
    /// The parent broadcast network to which the broadcaster belongs.
    /// <see href="http://dbpedia.org/ontology/broadcastNetwork"></see></summary>
    let broadcastNetwork = _prefix "broadcastNetwork"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/broadcastRepeater"></see>
    /// </summary>
    let broadcastRepeater = _prefix "broadcastRepeater"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/broadcastStationClass"></see>
    /// </summary>
    let broadcastStationClass = _prefix "broadcastStationClass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/broadcastTranslator"></see>
    /// </summary>
    let broadcastTranslator = _prefix "broadcastTranslator"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bronzeMedalDouble"></see>
    /// </summary>
    let bronzeMedalDouble = _prefix "bronzeMedalDouble"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bronzeMedalMixed"></see>
    /// </summary>
    let bronzeMedalMixed = _prefix "bronzeMedalMixed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bronzeMedalSingle"></see>
    /// </summary>
    let bronzeMedalSingle = _prefix "bronzeMedalSingle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bronzeMedalist"></see>
    /// </summary>
    let bronzeMedalist = _prefix "bronzeMedalist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Medalist"></see>
    /// </summary>
    let Medalist = _prefix "Medalist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/budget"></see>
    /// </summary>
    let budget = _prefix "budget"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/budgetYear"></see>
    /// </summary>
    let budgetYear = _prefix "budgetYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/builder"></see>
    /// </summary>
    let builder = _prefix "builder"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/building"></see>
    /// </summary>
    let building = _prefix "building"
    /// <summary>
    /// Building end date of an ArchitecturalStructure, man-made Lake, etc. For older structures this can be just a year or century, for newer structures an exact date is preferred
    /// <see href="http://dbpedia.org/ontology/buildingEndDate"></see></summary>
    let buildingEndDate = _prefix "buildingEndDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/buildingEndYear"></see>
    /// </summary>
    let buildingEndYear = _prefix "buildingEndYear"
    /// <summary>
    /// Building start date of an ArchitecturalStructure, man-made Lake, etc. For older structures this can be just a year or century, for newer structures an exact date is preferred
    /// <see href="http://dbpedia.org/ontology/buildingStartDate"></see></summary>
    let buildingStartDate = _prefix "buildingStartDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/buildingStartYear"></see>
    /// </summary>
    let buildingStartYear = _prefix "buildingStartYear"
    /// <summary>
    /// Type is too general. We should be able to distinguish types of music from types of architecture
    /// <see href="http://dbpedia.org/ontology/buildingType"></see></summary>
    let buildingType = _prefix "buildingType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bustSize"></see>
    /// </summary>
    let bustSize = _prefix "bustSize"
    /// <summary>
    /// Use this property if all 3 sizes are given together (DBpedia cannot currently extract 3 Lengths out of a field). Otherwise use separate fields bustSize, waistSize, hipSize
    /// <see href="http://dbpedia.org/ontology/bustWaistHipSize"></see></summary>
    let bustWaistHipSize = _prefix "bustWaistHipSize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cableCar"></see>
    /// </summary>
    let cableCar = _prefix "cableCar"
    /// <summary>
    /// A call sign is not the name of a broadcaster! In broadcasting and radio communications, a call sign (also known as a call name or call letters, or abbreviated as a call) is a unique designation for a transmitting station.
    /// <see href="http://dbpedia.org/ontology/callSign"></see></summary>
    let callSign = _prefix "callSign"
    /// <summary>
    /// The out written call sign.
    /// <see href="http://dbpedia.org/ontology/callsignMeaning"></see></summary>
    let callsignMeaning = _prefix "callsignMeaning"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/campus"></see>
    /// </summary>
    let campus = _prefix "campus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/campusSize"></see>
    /// </summary>
    let campusSize = _prefix "campusSize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/campusType"></see>
    /// </summary>
    let campusType = _prefix "campusType"
    /// <summary>
    /// Whether bags can be checked.
    /// <see href="http://dbpedia.org/ontology/canBaggageChecked"></see></summary>
    let canBaggageChecked = _prefix "canBaggageChecked"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cannonNumber"></see>
    /// </summary>
    let cannonNumber = _prefix "cannonNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/canonizedBy"></see>
    /// </summary>
    let canonizedBy = _prefix "canonizedBy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/canonizedDate"></see>
    /// </summary>
    let canonizedDate = _prefix "canonizedDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/canonizedPlace"></see>
    /// </summary>
    let canonizedPlace = _prefix "canonizedPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/canton"></see>
    /// </summary>
    let canton = _prefix "canton"
    /// <summary>
    /// Number of people who can be served by a Train or other service; or participate in a SoccerClub, CricketTeam, etc
    /// <see href="http://dbpedia.org/ontology/capacity"></see></summary>
    let capacity = _prefix "capacity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capacityFactor"></see>
    /// </summary>
    let capacityFactor = _prefix "capacityFactor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capital"></see>
    /// </summary>
    let capital = _prefix "capital"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalCoordinates"></see>
    /// </summary>
    let capitalCoordinates = _prefix "capitalCoordinates"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalCountry"></see>
    /// </summary>
    let capitalCountry = _prefix "capitalCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalDistrict"></see>
    /// </summary>
    let capitalDistrict = _prefix "capitalDistrict"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalElevation"></see>
    /// </summary>
    let capitalElevation = _prefix "capitalElevation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalMountain"></see>
    /// </summary>
    let capitalMountain = _prefix "capitalMountain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalPlace"></see>
    /// </summary>
    let capitalPlace = _prefix "capitalPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalPosition"></see>
    /// </summary>
    let capitalPosition = _prefix "capitalPosition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalRegion"></see>
    /// </summary>
    let capitalRegion = _prefix "capitalRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/captureDate"></see>
    /// </summary>
    let captureDate = _prefix "captureDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/carNumber"></see>
    /// </summary>
    let carNumber = _prefix "carNumber"
    /// <summary>
    /// Amount of carbohydrates per servingSize of a Food
    /// <see href="http://dbpedia.org/ontology/carbohydrate"></see></summary>
    let carbohydrate = _prefix "carbohydrate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/carcinogen"></see>
    /// </summary>
    let carcinogen = _prefix "carcinogen"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/careerPoints"></see>
    /// </summary>
    let careerPoints = _prefix "careerPoints"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/careerPrizeMoney"></see>
    /// </summary>
    let careerPrizeMoney = _prefix "careerPrizeMoney"
    /// <summary>
    /// this property links to a step in the career of a person, e.g. a soccer player, holding information on the time span, matches and goals he or she achieved at a club.
    /// <see href="http://dbpedia.org/ontology/careerStation"></see></summary>
    let careerStation = _prefix "careerStation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cargoFuel"></see>
    /// </summary>
    let cargoFuel = _prefix "cargoFuel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cargoGas"></see>
    /// </summary>
    let cargoGas = _prefix "cargoGas"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cargoWater"></see>
    /// </summary>
    let cargoWater = _prefix "cargoWater"
    /// <summary>
    /// Chemical Abstracts Service number. Applicable to ChemicalCompound or Biomolecule (eg Protein)
    /// <see href="http://dbpedia.org/ontology/casNumber"></see></summary>
    let casNumber = _prefix "casNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/casSupplemental"></see>
    /// </summary>
    let casSupplemental = _prefix "casSupplemental"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/case"></see>
    /// </summary>
    let case = _prefix "case"
    /// <summary>
    /// Number of casualties of a MilitaryConflict or natural disaster such as an Earthquake
    /// <see href="http://dbpedia.org/ontology/casualties"></see></summary>
    let casualties = _prefix "casualties"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryConflict_,_NaturalEvent"></see>
    /// </summary>
    let ``MilitaryConflict_,_NaturalEvent`` = _prefix "MilitaryConflict_,_NaturalEvent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/catch"></see>
    /// </summary>
    let catch = _prefix "catch"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/category"></see>
    /// </summary>
    let category = _prefix "category"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/caterer"></see>
    /// </summary>
    let caterer = _prefix "caterer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/catholicPercentage"></see>
    /// </summary>
    let catholicPercentage = _prefix "catholicPercentage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/causalties"></see>
    /// </summary>
    let causalties = _prefix "causalties"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/causeOfDeath"></see>
    /// </summary>
    let causeOfDeath = _prefix "causeOfDeath"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/causedBy"></see>
    /// </summary>
    let causedBy = _prefix "causedBy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ccaState"></see>
    /// </summary>
    let ccaState = _prefix "ccaState"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ceeb"></see>
    /// </summary>
    let ceeb = _prefix "ceeb"
    /// <summary>
    /// Maximum distance to the earth surface, to be expressed in kilometers
    /// <see href="http://dbpedia.org/ontology/ceiling"></see></summary>
    let ceiling = _prefix "ceiling"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cemetery"></see>
    /// </summary>
    let cemetery = _prefix "cemetery"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/censusYear"></see>
    /// </summary>
    let censusYear = _prefix "censusYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/center"></see>
    /// </summary>
    let center = _prefix "center"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NorwaySettlement"></see>
    /// </summary>
    let NorwaySettlement = _prefix "NorwaySettlement"
    /// <summary>
    /// number of breaks with 100 points and more
    /// <see href="http://dbpedia.org/ontology/centuryBreaks"></see></summary>
    let centuryBreaks = _prefix "centuryBreaks"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ceo"></see>
    /// </summary>
    let ceo = _prefix "ceo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ceremonialCounty"></see>
    /// </summary>
    let ceremonialCounty = _prefix "ceremonialCounty"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/certification"></see>
    /// </summary>
    let certification = _prefix "certification"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/certificationDate"></see>
    /// </summary>
    let certificationDate = _prefix "certificationDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cesarAward"></see>
    /// </summary>
    let cesarAward = _prefix "cesarAward"
    /// <summary>
    /// A unique identifier for the drug in the Chemical Entities of Biological Interest (ChEBI) ontology
    /// <see href="http://dbpedia.org/ontology/chEBI"></see></summary>
    let chEBI = _prefix "chEBI"
    /// <summary>
    /// The chain of Hotels this instance is associated with.
    /// <see href="http://dbpedia.org/ontology/chain"></see></summary>
    let chain = _prefix "chain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chairLabel"></see>
    /// </summary>
    let chairLabel = _prefix "chairLabel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chairman"></see>
    /// </summary>
    let chairman = _prefix "chairman"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chairmanTitle"></see>
    /// </summary>
    let chairmanTitle = _prefix "chairmanTitle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chairperson"></see>
    /// </summary>
    let chairperson = _prefix "chairperson"
    /// <summary>
    /// winner of a competition
    /// <see href="http://dbpedia.org/ontology/champion"></see></summary>
    let champion = _prefix "champion"
    /// <summary>
    /// winner of a competition in the double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInDouble"></see></summary>
    let championInDouble = _prefix "championInDouble"
    /// <summary>
    /// winner of a competition in the female double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInDoubleFemale"></see></summary>
    let championInDoubleFemale = _prefix "championInDoubleFemale"
    /// <summary>
    /// winner of a competition in the male double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInDoubleMale"></see></summary>
    let championInDoubleMale = _prefix "championInDoubleMale"
    /// <summary>
    /// winner of a competition in the mixed double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInMixedDouble"></see></summary>
    let championInMixedDouble = _prefix "championInMixedDouble"
    /// <summary>
    /// winner of a competition in the single session, to distinguish from the double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInSingle"></see></summary>
    let championInSingle = _prefix "championInSingle"
    /// <summary>
    /// winner of a competition in the single female session, to distinguish from the double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInSingleFemale"></see></summary>
    let championInSingleFemale = _prefix "championInSingleFemale"
    /// <summary>
    /// winner of a competition in the single male session, to distinguish from the double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInSingleMale"></see></summary>
    let championInSingleMale = _prefix "championInSingleMale"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/championships"></see>
    /// </summary>
    let championships = _prefix "championships"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chancellor"></see>
    /// </summary>
    let chancellor = _prefix "chancellor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/channel"></see>
    /// </summary>
    let channel = _prefix "channel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chaplain"></see>
    /// </summary>
    let chaplain = _prefix "chaplain"
    /// <summary>
    /// Name of a character in play.
    /// <see href="http://dbpedia.org/ontology/characterInPlay"></see></summary>
    let characterInPlay = _prefix "characterInPlay"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chef"></see>
    /// </summary>
    let chef = _prefix "chef"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chiefEditor"></see>
    /// </summary>
    let chiefEditor = _prefix "chiefEditor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chiefPlace"></see>
    /// </summary>
    let chiefPlace = _prefix "chiefPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/child"></see>
    /// </summary>
    let child = _prefix "child"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/childOrganisation"></see>
    /// </summary>
    let childOrganisation = _prefix "childOrganisation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/choreographer"></see>
    /// </summary>
    let choreographer = _prefix "choreographer"
    /// <summary>
    /// The name of the (Greek) chorus character in play.
    /// <see href="http://dbpedia.org/ontology/chorusCharacterInPlay"></see></summary>
    let chorusCharacterInPlay = _prefix "chorusCharacterInPlay"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/christeningDate"></see>
    /// </summary>
    let christeningDate = _prefix "christeningDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chromosome"></see>
    /// </summary>
    let chromosome = _prefix "chromosome"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cinematography"></see>
    /// </summary>
    let cinematography = _prefix "cinematography"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/circle"></see>
    /// </summary>
    let circle = _prefix "circle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/circuitLength"></see>
    /// </summary>
    let circuitLength = _prefix "circuitLength"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/circuitName"></see>
    /// </summary>
    let circuitName = _prefix "circuitName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/circulation"></see>
    /// </summary>
    let circulation = _prefix "circulation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/circumcised"></see>
    /// </summary>
    let circumcised = _prefix "circumcised"
    /// <summary>
    /// A document cited by this work. Like OntologyProperty:dct:references, but as a datatype property.
    /// <see href="http://dbpedia.org/ontology/cites"></see></summary>
    let cites = _prefix "cites"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/citizenship"></see>
    /// </summary>
    let citizenship = _prefix "citizenship"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/city"></see>
    /// </summary>
    let city = _prefix "city"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cityLink"></see>
    /// </summary>
    let cityLink = _prefix "cityLink"
    /// <summary>
    /// Place of the building in the list of the highest buildings in the city
    /// <see href="http://dbpedia.org/ontology/cityRank"></see></summary>
    let cityRank = _prefix "cityRank"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/citySince"></see>
    /// </summary>
    let citySince = _prefix "citySince"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cityType"></see>
    /// </summary>
    let cityType = _prefix "cityType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/class"></see>
    /// </summary>
    let class_ = _prefix "class"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/classes"></see>
    /// </summary>
    let classes = _prefix "classes"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/classification"></see>
    /// </summary>
    let classification = _prefix "classification"
    /// <summary>
    /// the living thing class (from the Latin "classis"), according to the biological taxonomy
    /// <see href="http://dbpedia.org/ontology/classis"></see></summary>
    let classis = _prefix "classis"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/climate"></see>
    /// </summary>
    let climate = _prefix "climate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/climbUpNumber"></see>
    /// </summary>
    let climbUpNumber = _prefix "climbUpNumber"
    /// <summary>
    /// place close to another place
    /// <see href="http://dbpedia.org/ontology/closeTo"></see></summary>
    let closeTo = _prefix "closeTo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/closed"></see>
    /// </summary>
    let closed = _prefix "closed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/closingDate"></see>
    /// </summary>
    let closingDate = _prefix "closingDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/closingFilm"></see>
    /// </summary>
    let closingFilm = _prefix "closingFilm"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/closingYear"></see>
    /// </summary>
    let closingYear = _prefix "closingYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/clothSize"></see>
    /// </summary>
    let clothSize = _prefix "clothSize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/clothingSize"></see>
    /// </summary>
    let clothingSize = _prefix "clothingSize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/club"></see>
    /// </summary>
    let club = _prefix "club"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/team"></see>
    /// </summary>
    let team = _prefix "team"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/clubsRecordGoalscorer"></see>
    /// </summary>
    let clubsRecordGoalscorer = _prefix "clubsRecordGoalscorer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cluster"></see>
    /// </summary>
    let cluster = _prefix "cluster"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cmpEvaDuration"></see>
    /// </summary>
    let cmpEvaDuration = _prefix "cmpEvaDuration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cmykCoordinateBlack"></see>
    /// </summary>
    let cmykCoordinateBlack = _prefix "cmykCoordinateBlack"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cmykCoordinateCyanic"></see>
    /// </summary>
    let cmykCoordinateCyanic = _prefix "cmykCoordinateCyanic"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cmykCoordinateMagenta"></see>
    /// </summary>
    let cmykCoordinateMagenta = _prefix "cmykCoordinateMagenta"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cmykCoordinateYellow"></see>
    /// </summary>
    let cmykCoordinateYellow = _prefix "cmykCoordinateYellow"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/co2Emission"></see>
    /// </summary>
    let co2Emission = _prefix "co2Emission"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coExecutiveProducer"></see>
    /// </summary>
    let coExecutiveProducer = _prefix "coExecutiveProducer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coProducer"></see>
    /// </summary>
    let coProducer = _prefix "coProducer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coach"></see>
    /// </summary>
    let coach = _prefix "coach"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coachClub"></see>
    /// </summary>
    let coachClub = _prefix "coachClub"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coachSeason"></see>
    /// </summary>
    let coachSeason = _prefix "coachSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coachedTeam"></see>
    /// </summary>
    let coachedTeam = _prefix "coachedTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coachingRecord"></see>
    /// </summary>
    let coachingRecord = _prefix "coachingRecord"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coalition"></see>
    /// </summary>
    let coalition = _prefix "coalition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coastLength"></see>
    /// </summary>
    let coastLength = _prefix "coastLength"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coastLine"></see>
    /// </summary>
    let coastLine = _prefix "coastLine"
    /// <summary>
    /// image of the coat of arms (heraldic symbol)
    /// <see href="http://dbpedia.org/ontology/coatOfArms"></see></summary>
    let coatOfArms = _prefix "coatOfArms"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/code"></see>
    /// </summary>
    let code = _prefix "code"
    /// <summary>
    /// code book or statute book referred to in this legal case
    /// <see href="http://dbpedia.org/ontology/codeBook"></see></summary>
    let codeBook = _prefix "codeBook"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/codeDistrict"></see>
    /// </summary>
    let codeDistrict = _prefix "codeDistrict"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/codeIndex"></see>
    /// </summary>
    let codeIndex = _prefix "codeIndex"
    /// <summary>
    /// Land Registry code designating a parcel of land
    /// <see href="http://dbpedia.org/ontology/codeLandRegistry"></see></summary>
    let codeLandRegistry = _prefix "codeLandRegistry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Code"></see>
    /// </summary>
    let Code = _prefix "Code"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/codeListOfHonour"></see>
    /// </summary>
    let codeListOfHonour = _prefix "codeListOfHonour"
    /// <summary>
    /// Identifier for monuments of the Memorial type
    /// <see href="http://dbpedia.org/ontology/codeMemorial"></see></summary>
    let codeMemorial = _prefix "codeMemorial"
    /// <summary>
    /// Code assigned to (Dutch) monuments at the municipal level, deemed to be of local value
    /// <see href="http://dbpedia.org/ontology/codeMunicipalMonument"></see></summary>
    let codeMunicipalMonument = _prefix "codeMunicipalMonument"
    /// <summary>
    /// Code assigned to (Dutch) monuments at the national level, deemed to be of national value
    /// <see href="http://dbpedia.org/ontology/codeNationalMonument"></see></summary>
    let codeNationalMonument = _prefix "codeNationalMonument"
    /// <summary>
    /// Code assigned to (Dutch) monuments at the provincial level, mostly for monuments in the countryside, or for waterworks
    /// <see href="http://dbpedia.org/ontology/codeProvincialMonument"></see></summary>
    let codeProvincialMonument = _prefix "codeProvincialMonument"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/codeSettlement"></see>
    /// </summary>
    let codeSettlement = _prefix "codeSettlement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/codeStockExchange"></see>
    /// </summary>
    let codeStockExchange = _prefix "codeStockExchange"
    /// <summary>
    /// CODEN is a six character, alphanumeric bibliographic code, that provides concise, unique and unambiguous identification of the titles of serials and non-serial publications from all subject areas.
    /// <see href="http://dbpedia.org/ontology/coden"></see></summary>
    let coden = _prefix "coden"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coemperor"></see>
    /// </summary>
    let coemperor = _prefix "coemperor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/collaboration"></see>
    /// </summary>
    let collaboration = _prefix "collaboration"
    /// <summary>
    /// Colleague of a Person or OfficeHolder (not PersonFunction nor CareerStation). Sub-properties include: president, vicePresident, chancellor, viceChancellor, governor, lieutenant. Points to a Person who may have a general "position" (resource) or "title" (literal).
    /// <see href="http://dbpedia.org/ontology/colleague"></see></summary>
    let colleague = _prefix "colleague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/collection"></see>
    /// </summary>
    let collection = _prefix "collection"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/collectionSize"></see>
    /// </summary>
    let collectionSize = _prefix "collectionSize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/collectivityMinority"></see>
    /// </summary>
    let collectivityMinority = _prefix "collectivityMinority"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/college"></see>
    /// </summary>
    let college = _prefix "college"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/collegeHof"></see>
    /// </summary>
    let collegeHof = _prefix "collegeHof"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/colonialName"></see>
    /// </summary>
    let colonialName = _prefix "colonialName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/colorChart"></see>
    /// </summary>
    let colorChart = _prefix "colorChart"
    /// <summary>
    /// A colour represented by its entity.
    /// <see href="http://dbpedia.org/ontology/colour"></see></summary>
    let colour = _prefix "colour"
    /// <summary>
    /// A colour represented by a string holding its name (e.g.: red or green).
    /// <see href="http://dbpedia.org/ontology/colourName"></see></summary>
    let colourName = _prefix "colourName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/combatant"></see>
    /// </summary>
    let combatant = _prefix "combatant"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/comic"></see>
    /// </summary>
    let comic = _prefix "comic"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/comitat"></see>
    /// </summary>
    let comitat = _prefix "comitat"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HungarySettlement"></see>
    /// </summary>
    let HungarySettlement = _prefix "HungarySettlement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/command"></see>
    /// </summary>
    let command = _prefix "command"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commandModule"></see>
    /// </summary>
    let commandModule = _prefix "commandModule"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commandStructure"></see>
    /// </summary>
    let commandStructure = _prefix "commandStructure"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commandant"></see>
    /// </summary>
    let commandant = _prefix "commandant"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/keyPerson"></see>
    /// </summary>
    let keyPerson = _prefix "keyPerson"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commander"></see>
    /// </summary>
    let commander = _prefix "commander"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/comment"></see>
    /// </summary>
    let comment = _prefix "comment"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commissioner"></see>
    /// </summary>
    let commissioner = _prefix "commissioner"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commissionerDate"></see>
    /// </summary>
    let commissionerDate = _prefix "commissionerDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commissioningDate"></see>
    /// </summary>
    let commissioningDate = _prefix "commissioningDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/committee"></see>
    /// </summary>
    let committee = _prefix "committee"
    /// <summary>
    /// Committee in the legislature (eg.: Committee on Economic and Monetary Affairs of the European Parliament).
    /// <see href="http://dbpedia.org/ontology/committeeInLegislature"></see></summary>
    let committeeInLegislature = _prefix "committeeInLegislature"
    /// <summary>
    /// The common name of an entity. Frequently, foaf:name is used for all of the different names of a person; this property just defines the most commonly used name.
    /// <see href="http://dbpedia.org/ontology/commonName"></see></summary>
    let commonName = _prefix "commonName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commune"></see>
    /// </summary>
    let commune = _prefix "commune"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/communityIsoCode"></see>
    /// </summary>
    let communityIsoCode = _prefix "communityIsoCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isoCode"></see>
    /// </summary>
    let isoCode = _prefix "isoCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/company"></see>
    /// </summary>
    let company = _prefix "company"
    /// <summary>
    /// similar, unrelated rockets
    /// <see href="http://dbpedia.org/ontology/comparable"></see></summary>
    let comparable = _prefix "comparable"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/competition"></see>
    /// </summary>
    let competition = _prefix "competition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/competitionTitle"></see>
    /// </summary>
    let competitionTitle = _prefix "competitionTitle"
    /// <summary>
    /// For compilation albums: the person or entity responsible for selecting the album's track listing.
    /// <see href="http://dbpedia.org/ontology/compiler"></see></summary>
    let compiler = _prefix "compiler"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/completionDate"></see>
    /// </summary>
    let completionDate = _prefix "completionDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/complexion"></see>
    /// </summary>
    let complexion = _prefix "complexion"
    /// <summary>
    /// Complexity of preparing a Food (recipe)
    /// <see href="http://dbpedia.org/ontology/complexity"></see></summary>
    let complexity = _prefix "complexity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/component"></see>
    /// </summary>
    let component_ = _prefix "component"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/composer"></see>
    /// </summary>
    let composer = _prefix "composer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/compressionRatio"></see>
    /// </summary>
    let compressionRatio = _prefix "compressionRatio"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/computingInput"></see>
    /// </summary>
    let computingInput = _prefix "computingInput"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/computingMedia"></see>
    /// </summary>
    let computingMedia = _prefix "computingMedia"
    /// <summary>
    /// some sort of hardware architecture or software framework, that allows this software to run
    /// <see href="http://dbpedia.org/ontology/computingPlatform"></see></summary>
    let computingPlatform = _prefix "computingPlatform"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/configuration"></see>
    /// </summary>
    let configuration = _prefix "configuration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/conflict"></see>
    /// </summary>
    let conflict = _prefix "conflict"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/congressionalDistrict"></see>
    /// </summary>
    let congressionalDistrict = _prefix "congressionalDistrict"
    /// <summary>
    /// connects a referenced resource to another resource. This property is important to connect non-extracted resources to extracted ones
    /// <see href="http://dbpedia.org/ontology/connectsReferencedTo"></see></summary>
    let connectsReferencedTo = _prefix "connectsReferencedTo"
    /// <summary>
    /// A meaning of a word or phrase that is suggested or implied, as opposed to a denotation, or literal meaning.
    /// <see href="http://dbpedia.org/ontology/connotation"></see></summary>
    let connotation = _prefix "connotation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/consecration"></see>
    /// </summary>
    let consecration = _prefix "consecration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/conservationStatus"></see>
    /// </summary>
    let conservationStatus = _prefix "conservationStatus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/conservationStatusSystem"></see>
    /// </summary>
    let conservationStatusSystem = _prefix "conservationStatusSystem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/constellation"></see>
    /// </summary>
    let constellation = _prefix "constellation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/construction"></see>
    /// </summary>
    let construction = _prefix "construction"
    /// <summary>
    /// Construction material (eg. concrete, steel, iron, stone, brick, wood).
    /// <see href="http://dbpedia.org/ontology/constructionMaterial"></see></summary>
    let constructionMaterial = _prefix "constructionMaterial"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/contest"></see>
    /// </summary>
    let contest = _prefix "contest"
    /// <summary>
    /// links a country to the continent it belongs
    /// <see href="http://dbpedia.org/ontology/continent"></see></summary>
    let continent = _prefix "continent"
    /// <summary>
    /// Place of the building in the list of the highest buildings in the continent
    /// <see href="http://dbpedia.org/ontology/continentRank"></see></summary>
    let continentRank = _prefix "continentRank"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/continentalTournament"></see>
    /// </summary>
    let continentalTournament = _prefix "continentalTournament"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/continentalTournamentBronze"></see>
    /// </summary>
    let continentalTournamentBronze = _prefix "continentalTournamentBronze"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/continentalTournamentGold"></see>
    /// </summary>
    let continentalTournamentGold = _prefix "continentalTournamentGold"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/continentalTournamentSilver"></see>
    /// </summary>
    let continentalTournamentSilver = _prefix "continentalTournamentSilver"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/contractAward"></see>
    /// </summary>
    let contractAward = _prefix "contractAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/contractor"></see>
    /// </summary>
    let contractor = _prefix "contractor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/convictionDate"></see>
    /// </summary>
    let convictionDate = _prefix "convictionDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coolingSystem"></see>
    /// </summary>
    let coolingSystem = _prefix "coolingSystem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/copilote"></see>
    /// </summary>
    let copilote = _prefix "copilote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coronationDate"></see>
    /// </summary>
    let coronationDate = _prefix "coronationDate"
    /// <summary>
    /// Described at http://en.wikipedia.org/wiki/International_Designator
    /// <see href="http://dbpedia.org/ontology/cosparId"></see></summary>
    let cosparId = _prefix "cosparId"
    /// <summary>
    /// Cost of building an ArchitecturalStructure, Ship, etc
    /// <see href="http://dbpedia.org/ontology/cost"></see></summary>
    let cost = _prefix "cost"
    /// <summary>
    /// the person who is responsible for the film costume design
    /// <see href="http://dbpedia.org/ontology/costumeDesigner"></see></summary>
    let costumeDesigner = _prefix "costumeDesigner"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/council"></see>
    /// </summary>
    let council = _prefix "council"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LiechtensteinSettlement"></see>
    /// </summary>
    let LiechtensteinSettlement = _prefix "LiechtensteinSettlement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/councilArea"></see>
    /// </summary>
    let councilArea = _prefix "councilArea"
    /// <summary>
    /// The country where the thing is located.
    /// <see href="http://dbpedia.org/ontology/country"></see></summary>
    let country = _prefix "country"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/countryOrigin"></see>
    /// </summary>
    let countryOrigin = _prefix "countryOrigin"
    /// <summary>
    /// Place of the building in the list of the highest buildings in the country
    /// <see href="http://dbpedia.org/ontology/countryRank"></see></summary>
    let countryRank = _prefix "countryRank"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/countryWithFirstAstronaut"></see>
    /// </summary>
    let countryWithFirstAstronaut = _prefix "countryWithFirstAstronaut"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/countryWithFirstSatellite"></see>
    /// </summary>
    let countryWithFirstSatellite = _prefix "countryWithFirstSatellite"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/countryWithFirstSatelliteLaunched"></see>
    /// </summary>
    let countryWithFirstSatelliteLaunched = _prefix "countryWithFirstSatelliteLaunched"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/countryWithFirstSpaceflight"></see>
    /// </summary>
    let countryWithFirstSpaceflight = _prefix "countryWithFirstSpaceflight"
    /// <summary>
    /// The county where the thing is located.
    /// <see href="http://dbpedia.org/ontology/county"></see></summary>
    let county = _prefix "county"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/countySeat"></see>
    /// </summary>
    let countySeat = _prefix "countySeat"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/course"></see>
    /// </summary>
    let course = _prefix "course"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cousurper"></see>
    /// </summary>
    let cousurper = _prefix "cousurper"
    /// <summary>
    /// Cover artist
    /// <see href="http://dbpedia.org/ontology/coverArtist"></see></summary>
    let coverArtist = _prefix "coverArtist"
    /// <summary>
    /// CPU of an InformationAppliance or VideoGame (which unfortunately is currently under Software)
    /// <see href="http://dbpedia.org/ontology/cpu"></see></summary>
    let cpu = _prefix "cpu"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/created"></see>
    /// </summary>
    let created = _prefix "created"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/creationChristianBishop"></see>
    /// </summary>
    let creationChristianBishop = _prefix "creationChristianBishop"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Bishop"></see>
    /// </summary>
    let Bishop = _prefix "Bishop"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/creationYear"></see>
    /// </summary>
    let creationYear = _prefix "creationYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/creativeDirector"></see>
    /// </summary>
    let creativeDirector = _prefix "creativeDirector"
    /// <summary>
    /// Creator/author of a work. For literal (string) use dc:creator; for object (URL) use creator
    /// <see href="http://dbpedia.org/ontology/creator"></see></summary>
    let creator = _prefix "creator"
    /// <summary>
    /// The person that creates (invents) the food (eg. Caesar Cardini is the creator of the Caesar salad).
    /// <see href="http://dbpedia.org/ontology/creatorOfDish"></see></summary>
    let creatorOfDish = _prefix "creatorOfDish"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/credit"></see>
    /// </summary>
    let credit = _prefix "credit"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crest"></see>
    /// </summary>
    let crest = _prefix "crest"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crew"></see>
    /// </summary>
    let crew = _prefix "crew"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crewMember"></see>
    /// </summary>
    let crewMember = _prefix "crewMember"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crewSize"></see>
    /// </summary>
    let crewSize = _prefix "crewSize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crews"></see>
    /// </summary>
    let crews = _prefix "crews"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/criteria"></see>
    /// </summary>
    let criteria = _prefix "criteria"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crosses"></see>
    /// </summary>
    let crosses = _prefix "crosses"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crownDependency"></see>
    /// </summary>
    let crownDependency = _prefix "crownDependency"
    /// <summary>
    /// National cuisine of a Food or Restaurant
    /// <see href="http://dbpedia.org/ontology/cuisine"></see></summary>
    let cuisine = _prefix "cuisine"
    /// <summary>
    /// Name of the cultivar (cultivated variety)
    /// <see href="http://dbpedia.org/ontology/cultivatedVariety"></see></summary>
    let cultivatedVariety = _prefix "cultivatedVariety"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/curator"></see>
    /// </summary>
    let curator = _prefix "curator"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currency"></see>
    /// </summary>
    let currency = _prefix "currency"
    /// <summary>
    /// ISO 4217 currency designators.
    /// <see href="http://dbpedia.org/ontology/currencyCode"></see></summary>
    let currencyCode = _prefix "currencyCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentCity"></see>
    /// </summary>
    let currentCity = _prefix "currentCity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentLeague"></see>
    /// </summary>
    let currentLeague = _prefix "currentLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentMember"></see>
    /// </summary>
    let currentMember = _prefix "currentMember"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentPartner"></see>
    /// </summary>
    let currentPartner = _prefix "currentPartner"
    /// <summary>
    /// The current production running in the theatre.
    /// <see href="http://dbpedia.org/ontology/currentProduction"></see></summary>
    let currentProduction = _prefix "currentProduction"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentRank"></see>
    /// </summary>
    let currentRank = _prefix "currentRank"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentRecord"></see>
    /// </summary>
    let currentRecord = _prefix "currentRecord"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentSeason"></see>
    /// </summary>
    let currentSeason = _prefix "currentSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentStatus"></see>
    /// </summary>
    let currentStatus = _prefix "currentStatus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentTeam"></see>
    /// </summary>
    let currentTeam = _prefix "currentTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentTeamManager"></see>
    /// </summary>
    let currentTeamManager = _prefix "currentTeamManager"
    /// <summary>
    /// A current member of an athletic team.
    /// <see href="http://dbpedia.org/ontology/currentTeamMember"></see></summary>
    let currentTeamMember = _prefix "currentTeamMember"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentWorldChampion"></see>
    /// </summary>
    let currentWorldChampion = _prefix "currentWorldChampion"
    /// <summary>
    /// Current use of the architectural structure, if it is currently being used as anything other than its original purpose.
    /// <see href="http://dbpedia.org/ontology/currentlyUsedFor"></see></summary>
    let currentlyUsedFor = _prefix "currentlyUsedFor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/custodian"></see>
    /// </summary>
    let custodian = _prefix "custodian"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cyclistGenre"></see>
    /// </summary>
    let cyclistGenre = _prefix "cyclistGenre"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cylinderBore"></see>
    /// </summary>
    let cylinderBore = _prefix "cylinderBore"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cylinderCount"></see>
    /// </summary>
    let cylinderCount = _prefix "cylinderCount"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/daira"></see>
    /// </summary>
    let daira = _prefix "daira"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dam"></see>
    /// </summary>
    let dam = _prefix "dam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/damage"></see>
    /// </summary>
    let damage = _prefix "damage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/damsire"></see>
    /// </summary>
    let damsire = _prefix "damsire"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/danseCompetition"></see>
    /// </summary>
    let danseCompetition = _prefix "danseCompetition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/danseScore"></see>
    /// </summary>
    let danseScore = _prefix "danseScore"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateAct"></see>
    /// </summary>
    let dateAct = _prefix "dateAct"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateAgreement"></see>
    /// </summary>
    let dateAgreement = _prefix "dateAgreement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateBudget"></see>
    /// </summary>
    let dateBudget = _prefix "dateBudget"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateClosed"></see>
    /// </summary>
    let dateClosed = _prefix "dateClosed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateCompleted"></see>
    /// </summary>
    let dateCompleted = _prefix "dateCompleted"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateConstruction"></see>
    /// </summary>
    let dateConstruction = _prefix "dateConstruction"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateExtended"></see>
    /// </summary>
    let dateExtended = _prefix "dateExtended"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateLastUpdated"></see>
    /// </summary>
    let dateLastUpdated = _prefix "dateLastUpdated"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateOfAbandonment"></see>
    /// </summary>
    let dateOfAbandonment = _prefix "dateOfAbandonment"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateOfBurial"></see>
    /// </summary>
    let dateOfBurial = _prefix "dateOfBurial"
    /// <summary>
    /// Designates the unveiling date
    /// <see href="http://dbpedia.org/ontology/dateUnveiled"></see></summary>
    let dateUnveiled = _prefix "dateUnveiled"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateUse"></see>
    /// </summary>
    let dateUse = _prefix "dateUse"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/davisCup"></see>
    /// </summary>
    let davisCup = _prefix "davisCup"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/day"></see>
    /// </summary>
    let day = _prefix "day"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/daylightSavingTimeZone"></see>
    /// </summary>
    let daylightSavingTimeZone = _prefix "daylightSavingTimeZone"
    /// <summary>
    /// identifier in Dutch digital library (dbnl)
    /// <see href="http://dbpedia.org/ontology/dbnlCodeDutch"></see></summary>
    let dbnlCodeDutch = _prefix "dbnlCodeDutch"
    /// <summary>
    /// The Dewey Decimal Classification is a proprietary system of library classification developed by Melvil Dewey in 1876.
    /// <see href="http://dbpedia.org/ontology/dcc"></see></summary>
    let dcc = _prefix "dcc"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deFactoLanguage"></see>
    /// </summary>
    let deFactoLanguage = _prefix "deFactoLanguage"
    /// <summary>
    /// Use dc:language for literal, language for object
    /// <see href="http://dbpedia.org/ontology/language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deadInFightDate"></see>
    /// </summary>
    let deadInFightDate = _prefix "deadInFightDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deadInFightPlace"></see>
    /// </summary>
    let deadInFightPlace = _prefix "deadInFightPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dean"></see>
    /// </summary>
    let dean = _prefix "dean"
    /// <summary>
    /// Dioceses and parishes should know which deaneries there are
    /// <see href="http://dbpedia.org/ontology/deanery"></see></summary>
    let deanery = _prefix "deanery"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Diocese,_Parish"></see>
    /// </summary>
    let ``Diocese,_Parish`` = _prefix "Diocese,_Parish"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deathAge"></see>
    /// </summary>
    let deathAge = _prefix "deathAge"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deathCause"></see>
    /// </summary>
    let deathCause = _prefix "deathCause"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deathDate"></see>
    /// </summary>
    let deathDate = _prefix "deathDate"
    /// <summary>
    /// The place where the person died.
    /// <see href="http://dbpedia.org/ontology/deathPlace"></see></summary>
    let deathPlace = _prefix "deathPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deathYear"></see>
    /// </summary>
    let deathYear = _prefix "deathYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/debut"></see>
    /// </summary>
    let debut = _prefix "debut"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/debutTeam"></see>
    /// </summary>
    let debutTeam = _prefix "debutTeam"
    /// <summary>
    /// First work of a person (may be notableWork or not)
    /// <see href="http://dbpedia.org/ontology/debutWork"></see></summary>
    let debutWork = _prefix "debutWork"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dec"></see>
    /// </summary>
    let dec = _prefix "dec"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/decay"></see>
    /// </summary>
    let decay = _prefix "decay"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/decideDate"></see>
    /// </summary>
    let decideDate = _prefix "decideDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/declination"></see>
    /// </summary>
    let declination = _prefix "declination"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/decommissioningDate"></see>
    /// </summary>
    let decommissioningDate = _prefix "decommissioningDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/decoration"></see>
    /// </summary>
    let decoration = _prefix "decoration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/defeat"></see>
    /// </summary>
    let defeat = _prefix "defeat"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/defeatAsMgr"></see>
    /// </summary>
    let defeatAsMgr = _prefix "defeatAsMgr"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/definition"></see>
    /// </summary>
    let definition = _prefix "definition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/delegateMayor"></see>
    /// </summary>
    let delegateMayor = _prefix "delegateMayor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/delegation"></see>
    /// </summary>
    let delegation = _prefix "delegation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deliveryDate"></see>
    /// </summary>
    let deliveryDate = _prefix "deliveryDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deme"></see>
    /// </summary>
    let deme = _prefix "deme"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/demographics"></see>
    /// </summary>
    let demographics = _prefix "demographics"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/demographicsAsOf"></see>
    /// </summary>
    let demographicsAsOf = _prefix "demographicsAsOf"
    /// <summary>
    /// The date the building was demolished.
    /// <see href="http://dbpedia.org/ontology/demolitionDate"></see></summary>
    let demolitionDate = _prefix "demolitionDate"
    /// <summary>
    /// The year the building was demolished.
    /// <see href="http://dbpedia.org/ontology/demolitionYear"></see></summary>
    let demolitionYear = _prefix "demolitionYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/demonym"></see>
    /// </summary>
    let demonym = _prefix "demonym"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/denomination"></see>
    /// </summary>
    let denomination = _prefix "denomination"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/density"></see>
    /// </summary>
    let density = _prefix "density"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/department"></see>
    /// </summary>
    let department = _prefix "department"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/departmentCode"></see>
    /// </summary>
    let departmentCode = _prefix "departmentCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/departmentPosition"></see>
    /// </summary>
    let departmentPosition = _prefix "departmentPosition"
    /// <summary>
    /// This property can be used to map image captions from Infoboxes
    /// <see href="http://dbpedia.org/ontology/depictionDescription"></see></summary>
    let depictionDescription = _prefix "depictionDescription"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/depthQuote"></see>
    /// </summary>
    let depthQuote = _prefix "depthQuote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/depths"></see>
    /// </summary>
    let depths = _prefix "depths"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deputy"></see>
    /// </summary>
    let deputy = _prefix "deputy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/derivative"></see>
    /// </summary>
    let derivative = _prefix "derivative"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/derivedWord"></see>
    /// </summary>
    let derivedWord = _prefix "derivedWord"
    /// <summary>
    /// Short description of a person
    /// <see href="http://dbpedia.org/ontology/description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/designCompany"></see>
    /// </summary>
    let designCompany = _prefix "designCompany"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/designer"></see>
    /// </summary>
    let designer = _prefix "designer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/destination"></see>
    /// </summary>
    let destination = _prefix "destination"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/destructionDate"></see>
    /// </summary>
    let destructionDate = _prefix "destructionDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/detectionMethod"></see>
    /// </summary>
    let detectionMethod = _prefix "detectionMethod"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/detractor"></see>
    /// </summary>
    let detractor = _prefix "detractor"
    /// <summary>
    /// Developer of a Work (Artwork, Book, Software) or Building (Hotel, Skyscraper)
    /// <see href="http://dbpedia.org/ontology/developer"></see></summary>
    let developer = _prefix "developer"
    /// <summary>
    /// Department for Education (UK) number of a school in England or Wales
    /// <see href="http://dbpedia.org/ontology/dfE"></see></summary>
    let dfE = _prefix "dfE"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/diameter"></see>
    /// </summary>
    let diameter = _prefix "diameter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/different"></see>
    /// </summary>
    let different = _prefix "different"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/digitalChannel"></see>
    /// </summary>
    let digitalChannel = _prefix "digitalChannel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/digitalSubChannel"></see>
    /// </summary>
    let digitalSubChannel = _prefix "digitalSubChannel"
    /// <summary>
    /// A religious administrative body above the parish level
    /// <see href="http://dbpedia.org/ontology/diocese"></see></summary>
    let diocese = _prefix "diocese"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Parish,_Deanery"></see>
    /// </summary>
    let ``Parish,_Deanery`` = _prefix "Parish,_Deanery"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/diploma"></see>
    /// </summary>
    let diploma = _prefix "diploma"
    /// <summary>
    /// A film director is a person who directs the making of a film.
    /// <see href="http://dbpedia.org/ontology/director"></see></summary>
    let director = _prefix "director"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/disappearanceDate"></see>
    /// </summary>
    let disappearanceDate = _prefix "disappearanceDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/disbanded"></see>
    /// </summary>
    let disbanded = _prefix "disbanded"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/discharge"></see>
    /// </summary>
    let discharge = _prefix "discharge"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dischargeAverage"></see>
    /// </summary>
    let dischargeAverage = _prefix "dischargeAverage"
    /// <summary>
    /// A person who learns from another, especially one who then teaches others..
    /// <see href="http://dbpedia.org/ontology/disciple"></see></summary>
    let disciple = _prefix "disciple"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/discipline"></see>
    /// </summary>
    let discipline = _prefix "discipline"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/discontinued"></see>
    /// </summary>
    let discontinued = _prefix "discontinued"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/discovered"></see>
    /// </summary>
    let discovered = _prefix "discovered"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/discoverer"></see>
    /// </summary>
    let discoverer = _prefix "discoverer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/discovery"></see>
    /// </summary>
    let discovery = _prefix "discovery"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/diseasesDb"></see>
    /// </summary>
    let diseasesDb = _prefix "diseasesDb"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/displacement"></see>
    /// </summary>
    let displacement = _prefix "displacement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dissolutionDate"></see>
    /// </summary>
    let dissolutionDate = _prefix "dissolutionDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dissolutionYear"></see>
    /// </summary>
    let dissolutionYear = _prefix "dissolutionYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Organisation,_PopulatedPlace"></see>
    /// </summary>
    let ``Organisation,_PopulatedPlace`` = _prefix "Organisation,_PopulatedPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dissolved"></see>
    /// </summary>
    let dissolved = _prefix "dissolved"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dist_ly"></see>
    /// </summary>
    let dist_ly = _prefix "dist_ly"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dist_pc"></see>
    /// </summary>
    let dist_pc = _prefix "dist_pc"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distance"></see>
    /// </summary>
    let distance = _prefix "distance"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceLaps"></see>
    /// </summary>
    let distanceLaps = _prefix "distanceLaps"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToBelfast"></see>
    /// </summary>
    let distanceToBelfast = _prefix "distanceToBelfast"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToCapital"></see>
    /// </summary>
    let distanceToCapital = _prefix "distanceToCapital"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Distance"></see>
    /// </summary>
    let Distance = _prefix "Distance"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToCardiff"></see>
    /// </summary>
    let distanceToCardiff = _prefix "distanceToCardiff"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToCharingCross"></see>
    /// </summary>
    let distanceToCharingCross = _prefix "distanceToCharingCross"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToDouglas"></see>
    /// </summary>
    let distanceToDouglas = _prefix "distanceToDouglas"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToDublin"></see>
    /// </summary>
    let distanceToDublin = _prefix "distanceToDublin"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToEdinburgh"></see>
    /// </summary>
    let distanceToEdinburgh = _prefix "distanceToEdinburgh"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToLondon"></see>
    /// </summary>
    let distanceToLondon = _prefix "distanceToLondon"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceTraveled"></see>
    /// </summary>
    let distanceTraveled = _prefix "distanceTraveled"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distributingCompany"></see>
    /// </summary>
    let distributingCompany = _prefix "distributingCompany"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distributingLabel"></see>
    /// </summary>
    let distributingLabel = _prefix "distributingLabel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distributor"></see>
    /// </summary>
    let distributor = _prefix "distributor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/district"></see>
    /// </summary>
    let district = _prefix "district"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/division"></see>
    /// </summary>
    let division = _prefix "division"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dockedTime"></see>
    /// </summary>
    let dockedTime = _prefix "dockedTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/doctoralAdvisor"></see>
    /// </summary>
    let doctoralAdvisor = _prefix "doctoralAdvisor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/doctoralStudent"></see>
    /// </summary>
    let doctoralStudent = _prefix "doctoralStudent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/documentDesignation"></see>
    /// </summary>
    let documentDesignation = _prefix "documentDesignation"
    /// <summary>
    /// Identification a document within a particular registry
    /// <see href="http://dbpedia.org/ontology/documentNumber"></see></summary>
    let documentNumber = _prefix "documentNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/domain"></see>
    /// </summary>
    let domain = _prefix "domain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dorlandsPrefix"></see>
    /// </summary>
    let dorlandsPrefix = _prefix "dorlandsPrefix"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dorlandsSuffix"></see>
    /// </summary>
    let dorlandsSuffix = _prefix "dorlandsSuffix"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draft"></see>
    /// </summary>
    let draft = _prefix "draft"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draftLeague"></see>
    /// </summary>
    let draftLeague = _prefix "draftLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draftPick"></see>
    /// </summary>
    let draftPick = _prefix "draftPick"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draftPosition"></see>
    /// </summary>
    let draftPosition = _prefix "draftPosition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draftRound"></see>
    /// </summary>
    let draftRound = _prefix "draftRound"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draftTeam"></see>
    /// </summary>
    let draftTeam = _prefix "draftTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draftYear"></see>
    /// </summary>
    let draftYear = _prefix "draftYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/drainsFrom"></see>
    /// </summary>
    let drainsFrom = _prefix "drainsFrom"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/drainsTo"></see>
    /// </summary>
    let drainsTo = _prefix "drainsTo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/drama"></see>
    /// </summary>
    let drama = _prefix "drama"
    /// <summary>
    /// The recommended dress code for an establishment or event.
    /// <see href="http://dbpedia.org/ontology/dressCode"></see></summary>
    let dressCode = _prefix "dressCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/drugbank"></see>
    /// </summary>
    let drugbank = _prefix "drugbank"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dryCargo"></see>
    /// </summary>
    let dryCargo = _prefix "dryCargo"
    /// <summary>
    /// the person who dubs another person e.g. an actor or a fictional character in movies
    /// <see href="http://dbpedia.org/ontology/dubber"></see></summary>
    let dubber = _prefix "dubber"
    /// <summary>
    /// The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format
    /// <see href="http://dbpedia.org/ontology/duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dutchCOROPCode"></see>
    /// </summary>
    let dutchCOROPCode = _prefix "dutchCOROPCode"
    /// <summary>
    /// The Dutch MIP project was meant to take stock of all kinds of monuments
    /// <see href="http://dbpedia.org/ontology/dutchMIPCode"></see></summary>
    let dutchMIPCode = _prefix "dutchMIPCode"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ArchitecturalStructure,_Monument"></see>
    /// </summary>
    let ``ArchitecturalStructure,_Monument`` =
        _prefix "ArchitecturalStructure,_Monument"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dutchNAIdentifier"></see>
    /// </summary>
    let dutchNAIdentifier = _prefix "dutchNAIdentifier"
    /// <summary>
    /// Dutch PPN code is a library cataloguing code for collection items (books, journals and the like).
    /// <see href="http://dbpedia.org/ontology/dutchPPNCode"></see></summary>
    let dutchPPNCode = _prefix "dutchPPNCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dutchRKDCode"></see>
    /// </summary>
    let dutchRKDCode = _prefix "dutchRKDCode"
    /// <summary>
    /// Dutch Winkel ID is a code for an underground publication, as attributed by Lydia Winkel's work on the underground WW II press in the Netherlands.
    /// <see href="http://dbpedia.org/ontology/dutchWinkelID"></see></summary>
    let dutchWinkelID = _prefix "dutchWinkelID"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dynasty"></see>
    /// </summary>
    let dynasty = _prefix "dynasty"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eMedicineSubject"></see>
    /// </summary>
    let eMedicineSubject = _prefix "eMedicineSubject"
    /// <summary>
    /// Different from eMedicineSubject, which see
    /// <see href="http://dbpedia.org/ontology/eMedicineTopic"></see></summary>
    let eMedicineTopic = _prefix "eMedicineTopic"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eTeatrId"></see>
    /// </summary>
    let eTeatrId = _prefix "eTeatrId"
    /// <summary>
    /// indicates another place situated east.
    /// <see href="http://dbpedia.org/ontology/eastPlace"></see></summary>
    let eastPlace = _prefix "eastPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ecNumber"></see>
    /// </summary>
    let ecNumber = _prefix "ecNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/editing"></see>
    /// </summary>
    let editing = _prefix "editing"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/editor"></see>
    /// </summary>
    let editor = _prefix "editor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/editorTitle"></see>
    /// </summary>
    let editorTitle = _prefix "editorTitle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/education"></see>
    /// </summary>
    let education = _prefix "education"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/educationPlace"></see>
    /// </summary>
    let educationPlace = _prefix "educationPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/educationSystem"></see>
    /// </summary>
    let educationSystem = _prefix "educationSystem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/effectiveRadiatedPower"></see>
    /// </summary>
    let effectiveRadiatedPower = _prefix "effectiveRadiatedPower"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/egafdId"></see>
    /// </summary>
    let egafdId = _prefix "egafdId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/einecsNumber"></see>
    /// </summary>
    let einecsNumber = _prefix "einecsNumber"
    /// <summary>
    /// Indexing code used by the Bulgarian National Statistical Institute to identify populated places
    /// <see href="http://dbpedia.org/ontology/ekatteCode"></see></summary>
    let ekatteCode = _prefix "ekatteCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/electionDate"></see>
    /// </summary>
    let electionDate = _prefix "electionDate"
    /// <summary>
    /// The date that leader was elected.
    /// <see href="http://dbpedia.org/ontology/electionDateLeader"></see></summary>
    let electionDateLeader = _prefix "electionDateLeader"
    /// <summary>
    /// number of votes the office holder attained
    /// <see href="http://dbpedia.org/ontology/electionMajority"></see></summary>
    let electionMajority = _prefix "electionMajority"
    /// <summary>
    /// element placed above current element in D.I.Mendeleev's table
    /// <see href="http://dbpedia.org/ontology/elementAbove"></see></summary>
    let elementAbove = _prefix "elementAbove"
    /// <summary>
    /// A block of the periodic table of elements is a set of adjacent groups.
    /// <see href="http://dbpedia.org/ontology/elementBlock"></see></summary>
    let elementBlock = _prefix "elementBlock"
    /// <summary>
    /// In chemistry, a group (also known as a family) is a column of elements in the periodic table of the chemical elements.
    /// <see href="http://dbpedia.org/ontology/elementGroup"></see></summary>
    let elementGroup = _prefix "elementGroup"
    /// <summary>
    /// In the periodic table of the elements, elements are arranged in a series of rows (or periods) so that those with similar properties appear in a column.
    /// <see href="http://dbpedia.org/ontology/elementPeriod"></see></summary>
    let elementPeriod = _prefix "elementPeriod"
    /// <summary>
    /// average elevation above the sea level
    /// <see href="http://dbpedia.org/ontology/elevation"></see></summary>
    let elevation = _prefix "elevation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/elevationQuote"></see>
    /// </summary>
    let elevationQuote = _prefix "elevationQuote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/elevatorCount"></see>
    /// </summary>
    let elevatorCount = _prefix "elevatorCount"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/elo"></see>
    /// </summary>
    let elo = _prefix "elo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eloRecord"></see>
    /// </summary>
    let eloRecord = _prefix "eloRecord"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/emblem"></see>
    /// </summary>
    let emblem = _prefix "emblem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/emmyAward"></see>
    /// </summary>
    let emmyAward = _prefix "emmyAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/employer"></see>
    /// </summary>
    let employer = _prefix "employer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/employersCelebration"></see>
    /// </summary>
    let employersCelebration = _prefix "employersCelebration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endCareer"></see>
    /// </summary>
    let endCareer = _prefix "endCareer"
    /// <summary>
    /// The end date of the event.
    /// <see href="http://dbpedia.org/ontology/endDate"></see></summary>
    let endDate = _prefix "endDate"
    /// <summary>
    /// The end date and time of the event.
    /// <see href="http://dbpedia.org/ontology/endDateTime"></see></summary>
    let endDateTime = _prefix "endDateTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endOccupation"></see>
    /// </summary>
    let endOccupation = _prefix "endOccupation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endPoint"></see>
    /// </summary>
    let endPoint = _prefix "endPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endReign"></see>
    /// </summary>
    let endReign = _prefix "endReign"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endYear"></see>
    /// </summary>
    let endYear = _prefix "endYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endYearOfInsertion"></see>
    /// </summary>
    let endYearOfInsertion = _prefix "endYearOfInsertion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endYearOfSales"></see>
    /// </summary>
    let endYearOfSales = _prefix "endYearOfSales"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endangeredSince"></see>
    /// </summary>
    let endangeredSince = _prefix "endangeredSince"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endingTheme"></see>
    /// </summary>
    let endingTheme = _prefix "endingTheme"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endowment"></see>
    /// </summary>
    let endowment = _prefix "endowment"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/enemy"></see>
    /// </summary>
    let enemy = _prefix "enemy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/engine"></see>
    /// </summary>
    let engine = _prefix "engine"
    /// <summary>
    /// Power to be expressed in Watts (kiloWatt, megaWatt)
    /// <see href="http://dbpedia.org/ontology/enginePower"></see></summary>
    let enginePower = _prefix "enginePower"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/engineType"></see>
    /// </summary>
    let engineType = _prefix "engineType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/engineer"></see>
    /// </summary>
    let engineer = _prefix "engineer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ensembl"></see>
    /// </summary>
    let ensembl = _prefix "ensembl"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/enshrinedDeity"></see>
    /// </summary>
    let enshrinedDeity = _prefix "enshrinedDeity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/entourage"></see>
    /// </summary>
    let entourage = _prefix "entourage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/entrezgene"></see>
    /// </summary>
    let entrezgene = _prefix "entrezgene"
    /// <summary>
    /// Compare with bishopric
    /// <see href="http://dbpedia.org/ontology/eparchy"></see></summary>
    let eparchy = _prefix "eparchy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/episode"></see>
    /// </summary>
    let episode = _prefix "episode"
    /// <summary>
    /// The episode number of the TelevisionEpisode.
    /// <see href="http://dbpedia.org/ontology/episodeNumber"></see></summary>
    let episodeNumber = _prefix "episodeNumber"
    /// <summary>
    /// moment in time used as a referrence point for some time-vaying astronomical quantity
    /// <see href="http://dbpedia.org/ontology/epoch"></see></summary>
    let epoch = _prefix "epoch"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eptFinalTable"></see>
    /// </summary>
    let eptFinalTable = _prefix "eptFinalTable"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eptItm"></see>
    /// </summary>
    let eptItm = _prefix "eptItm"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eptTitle"></see>
    /// </summary>
    let eptTitle = _prefix "eptTitle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/equipment"></see>
    /// </summary>
    let equipment = _prefix "equipment"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/equity"></see>
    /// </summary>
    let equity = _prefix "equity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/era"></see>
    /// </summary>
    let era = _prefix "era"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eruption"></see>
    /// </summary>
    let eruption = _prefix "eruption"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eruptionYear"></see>
    /// </summary>
    let eruptionYear = _prefix "eruptionYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/escalafon"></see>
    /// </summary>
    let escalafon = _prefix "escalafon"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/escapeVelocity"></see>
    /// </summary>
    let escapeVelocity = _prefix "escapeVelocity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/espnId"></see>
    /// </summary>
    let espnId = _prefix "espnId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/established"></see>
    /// </summary>
    let established = _prefix "established"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/establishment"></see>
    /// </summary>
    let establishment = _prefix "establishment"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ethnicGroup"></see>
    /// </summary>
    let ethnicGroup = _prefix "ethnicGroup"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ethnicGroupsInYear"></see>
    /// </summary>
    let ethnicGroupsInYear = _prefix "ethnicGroupsInYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ethnicity"></see>
    /// </summary>
    let ethnicity = _prefix "ethnicity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eurobabeIndexId"></see>
    /// </summary>
    let eurobabeIndexId = _prefix "eurobabeIndexId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/europeanAffiliation"></see>
    /// </summary>
    let europeanAffiliation = _prefix "europeanAffiliation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/europeanChampionship"></see>
    /// </summary>
    let europeanChampionship = _prefix "europeanChampionship"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/europeanParliamentGroup"></see>
    /// </summary>
    let europeanParliamentGroup = _prefix "europeanParliamentGroup"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/europeanUnionEntranceDate"></see>
    /// </summary>
    let europeanUnionEntranceDate = _prefix "europeanUnionEntranceDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/event"></see>
    /// </summary>
    let event_ = _prefix "event"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eventDate"></see>
    /// </summary>
    let eventDate = _prefix "eventDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eventDescription"></see>
    /// </summary>
    let eventDescription = _prefix "eventDescription"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/executiveHeadteacher"></see>
    /// </summary>
    let executiveHeadteacher = _prefix "executiveHeadteacher"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/executiveProducer"></see>
    /// </summary>
    let executiveProducer = _prefix "executiveProducer"
    /// <summary>
    /// Notes about an exhibition the object has been to
    /// <see href="http://dbpedia.org/ontology/exhibition"></see></summary>
    let exhibition = _prefix "exhibition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/existence"></see>
    /// </summary>
    let existence = _prefix "existence"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/expedition"></see>
    /// </summary>
    let expedition = _prefix "expedition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/explorer"></see>
    /// </summary>
    let explorer = _prefix "explorer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/externalOrnament"></see>
    /// </summary>
    let externalOrnament = _prefix "externalOrnament"
    /// <summary>
    /// Date when an Organization (eg PoliticalParty, Company) or Species ceased to exist
    /// <see href="http://dbpedia.org/ontology/extinctionDate"></see></summary>
    let extinctionDate = _prefix "extinctionDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/extinctionYear"></see>
    /// </summary>
    let extinctionYear = _prefix "extinctionYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eyeColor"></see>
    /// </summary>
    let eyeColor = _prefix "eyeColor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eyeColour"></see>
    /// </summary>
    let eyeColour = _prefix "eyeColour"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eyes"></see>
    /// </summary>
    let eyes = _prefix "eyes"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/faaLocationIdentifier"></see>
    /// </summary>
    let faaLocationIdentifier = _prefix "faaLocationIdentifier"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/facilityId"></see>
    /// </summary>
    let facilityId = _prefix "facilityId"
    /// <summary>
    /// number of faculty members
    /// <see href="http://dbpedia.org/ontology/facultySize"></see></summary>
    let facultySize = _prefix "facultySize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/failedLaunches"></see>
    /// </summary>
    let failedLaunches = _prefix "failedLaunches"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/family"></see>
    /// </summary>
    let family = _prefix "family"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/familyMember"></see>
    /// </summary>
    let familyMember = _prefix "familyMember"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fansgroup"></see>
    /// </summary>
    let fansgroup = _prefix "fansgroup"
    /// <summary>
    /// The fare zone in which station is located.
    /// <see href="http://dbpedia.org/ontology/fareZone"></see></summary>
    let fareZone = _prefix "fareZone"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fastestDriver"></see>
    /// </summary>
    let fastestDriver = _prefix "fastestDriver"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fastestDriverCountry"></see>
    /// </summary>
    let fastestDriverCountry = _prefix "fastestDriverCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fastestDriverTeam"></see>
    /// </summary>
    let fastestDriverTeam = _prefix "fastestDriverTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fastestLap"></see>
    /// </summary>
    let fastestLap = _prefix "fastestLap"
    /// <summary>
    /// Amount of fat per servingSize of a Food
    /// <see href="http://dbpedia.org/ontology/fat"></see></summary>
    let fat = _prefix "fat"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fate"></see>
    /// </summary>
    let fate = _prefix "fate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/father"></see>
    /// </summary>
    let father = _prefix "father"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fauna"></see>
    /// </summary>
    let fauna = _prefix "fauna"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fc"></see>
    /// </summary>
    let fc = _prefix "fc"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fcRuns"></see>
    /// </summary>
    let fcRuns = _prefix "fcRuns"
    /// <summary>
    /// FDA Unique Ingredient Identifier (UNII) code for a DBpedia Drug
    /// <see href="http://dbpedia.org/ontology/fdaUniiCode"></see></summary>
    let fdaUniiCode = _prefix "fdaUniiCode"
    /// <summary>
    /// A day of celebration associated with the entity. Applies to Saint, School etc
    /// <see href="http://dbpedia.org/ontology/feastDay"></see></summary>
    let feastDay = _prefix "feastDay"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/feat"></see>
    /// </summary>
    let feat = _prefix "feat"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/feature"></see>
    /// </summary>
    let feature = _prefix "feature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/features"></see>
    /// </summary>
    let features = _prefix "features"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fedCup"></see>
    /// </summary>
    let fedCup = _prefix "fedCup"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/federalState"></see>
    /// </summary>
    let federalState = _prefix "federalState"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/federation"></see>
    /// </summary>
    let federation = _prefix "federation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fees"></see>
    /// </summary>
    let fees = _prefix "fees"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fibahof"></see>
    /// </summary>
    let fibahof = _prefix "fibahof"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/field"></see>
    /// </summary>
    let field = _prefix "field"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fight"></see>
    /// </summary>
    let fight = _prefix "fight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fighter"></see>
    /// </summary>
    let fighter = _prefix "fighter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fileExtension"></see>
    /// </summary>
    let fileExtension = _prefix "fileExtension"
    /// <summary>
    /// size of a file or software
    /// <see href="http://dbpedia.org/ontology/fileSize"></see></summary>
    let fileSize = _prefix "fileSize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fileURL"></see>
    /// </summary>
    let fileURL = _prefix "fileURL"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/filename"></see>
    /// </summary>
    let filename = _prefix "filename"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fillingStation"></see>
    /// </summary>
    let fillingStation = _prefix "fillingStation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/film"></see>
    /// </summary>
    let film = _prefix "film"
    /// <summary>
    /// specifies the audio type of the film i.e. 'sound' or 'silent'
    /// <see href="http://dbpedia.org/ontology/filmAudioType"></see></summary>
    let filmAudioType = _prefix "filmAudioType"
    /// <summary>
    /// specifies the colour type of the film i.e. 'colour' or 'b/w'
    /// <see href="http://dbpedia.org/ontology/filmColourType"></see></summary>
    let filmColourType = _prefix "filmColourType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/filmFareAward"></see>
    /// </summary>
    let filmFareAward = _prefix "filmFareAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/filmNumber"></see>
    /// </summary>
    let filmNumber = _prefix "filmNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/filmPolskiId"></see>
    /// </summary>
    let filmPolskiId = _prefix "filmPolskiId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/filmRuntime"></see>
    /// </summary>
    let filmRuntime = _prefix "filmRuntime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/filmVersion"></see>
    /// </summary>
    let filmVersion = _prefix "filmVersion"
    /// <summary>
    /// date of final flight
    /// <see href="http://dbpedia.org/ontology/finalFlight"></see></summary>
    let finalFlight = _prefix "finalFlight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/finalLost"></see>
    /// </summary>
    let finalLost = _prefix "finalLost"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/finalLostDouble"></see>
    /// </summary>
    let finalLostDouble = _prefix "finalLostDouble"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/finalLostSingle"></see>
    /// </summary>
    let finalLostSingle = _prefix "finalLostSingle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/finalLostTeam"></see>
    /// </summary>
    let finalLostTeam = _prefix "finalLostTeam"
    /// <summary>
    /// Date of the final publication.
    /// <see href="http://dbpedia.org/ontology/finalPublicationDate"></see></summary>
    let finalPublicationDate = _prefix "finalPublicationDate"
    /// <summary>
    /// Year of the final publication.
    /// <see href="http://dbpedia.org/ontology/finalPublicationYear"></see></summary>
    let finalPublicationYear = _prefix "finalPublicationYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fipsCode"></see>
    /// </summary>
    let fipsCode = _prefix "fipsCode"
    /// <summary>
    /// The date on which regular broadcasts began.
    /// <see href="http://dbpedia.org/ontology/firstAirDate"></see></summary>
    let firstAirDate = _prefix "firstAirDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstAppearance"></see>
    /// </summary>
    let firstAppearance = _prefix "firstAppearance"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstAscent"></see>
    /// </summary>
    let firstAscent = _prefix "firstAscent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Mountain,Volcano"></see>
    /// </summary>
    let ``Mountain,Volcano`` = _prefix "Mountain,Volcano"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstAscentPerson"></see>
    /// </summary>
    let firstAscentPerson = _prefix "firstAscentPerson"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstAscentYear"></see>
    /// </summary>
    let firstAscentYear = _prefix "firstAscentYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstBroadcast"></see>
    /// </summary>
    let firstBroadcast = _prefix "firstBroadcast"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstDriver"></see>
    /// </summary>
    let firstDriver = _prefix "firstDriver"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstDriverCountry"></see>
    /// </summary>
    let firstDriverCountry = _prefix "firstDriverCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstDriverTeam"></see>
    /// </summary>
    let firstDriverTeam = _prefix "firstDriverTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstFlight"></see>
    /// </summary>
    let firstFlight = _prefix "firstFlight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstFlightEndDate"></see>
    /// </summary>
    let firstFlightEndDate = _prefix "firstFlightEndDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstFlightStartDate"></see>
    /// </summary>
    let firstFlightStartDate = _prefix "firstFlightStartDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstGame"></see>
    /// </summary>
    let firstGame = _prefix "firstGame"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstLaunch"></see>
    /// </summary>
    let firstLaunch = _prefix "firstLaunch"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstLaunchDate"></see>
    /// </summary>
    let firstLaunchDate = _prefix "firstLaunchDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstLaunchRocket"></see>
    /// </summary>
    let firstLaunchRocket = _prefix "firstLaunchRocket"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstLeader"></see>
    /// </summary>
    let firstLeader = _prefix "firstLeader"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstMention"></see>
    /// </summary>
    let firstMention = _prefix "firstMention"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstOlympicEvent"></see>
    /// </summary>
    let firstOlympicEvent = _prefix "firstOlympicEvent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstOwner"></see>
    /// </summary>
    let firstOwner = _prefix "firstOwner"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstPlace"></see>
    /// </summary>
    let firstPlace = _prefix "firstPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstPopularVote"></see>
    /// </summary>
    let firstPopularVote = _prefix "firstPopularVote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstProMatch"></see>
    /// </summary>
    let firstProMatch = _prefix "firstProMatch"
    /// <summary>
    /// Date of the first publication.
    /// <see href="http://dbpedia.org/ontology/firstPublicationDate"></see></summary>
    let firstPublicationDate = _prefix "firstPublicationDate"
    /// <summary>
    /// Year of the first publication.
    /// <see href="http://dbpedia.org/ontology/firstPublicationYear"></see></summary>
    let firstPublicationYear = _prefix "firstPublicationYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstPublisher"></see>
    /// </summary>
    let firstPublisher = _prefix "firstPublisher"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstRace"></see>
    /// </summary>
    let firstRace = _prefix "firstRace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstWin"></see>
    /// </summary>
    let firstWin = _prefix "firstWin"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstWinner"></see>
    /// </summary>
    let firstWinner = _prefix "firstWinner"
    /// <summary>
    /// Wikimedia Commons file name representing the subject's flag
    /// <see href="http://dbpedia.org/ontology/flag"></see></summary>
    let flag = _prefix "flag"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flagBearer"></see>
    /// </summary>
    let flagBearer = _prefix "flagBearer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flagBorder"></see>
    /// </summary>
    let flagBorder = _prefix "flagBorder"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flagCaption"></see>
    /// </summary>
    let flagCaption = _prefix "flagCaption"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flagLink"></see>
    /// </summary>
    let flagLink = _prefix "flagLink"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flagSize"></see>
    /// </summary>
    let flagSize = _prefix "flagSize"
    /// <summary>
    /// lowest temperature at which a substance can vaporize and start burning
    /// <see href="http://dbpedia.org/ontology/flashPoint"></see></summary>
    let flashPoint = _prefix "flashPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/floodingDate"></see>
    /// </summary>
    let floodingDate = _prefix "floodingDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/floorArea"></see>
    /// </summary>
    let floorArea = _prefix "floorArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/floorCount"></see>
    /// </summary>
    let floorCount = _prefix "floorCount"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flora"></see>
    /// </summary>
    let flora = _prefix "flora"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flower"></see>
    /// </summary>
    let flower = _prefix "flower"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flyingHours"></see>
    /// </summary>
    let flyingHours = _prefix "flyingHours"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foalDate"></see>
    /// </summary>
    let foalDate = _prefix "foalDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/followedBy"></see>
    /// </summary>
    let followedBy = _prefix "followedBy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/followingEvent"></see>
    /// </summary>
    let followingEvent = _prefix "followingEvent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/follows"></see>
    /// </summary>
    let follows = _prefix "follows"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foot"></see>
    /// </summary>
    let foot = _prefix "foot"
    /// <summary>
    /// a preference to put one's left or right foot forward in surfing, wakeboarding, skateboarding, wakeskating, snowboarding and mountainboarding. The term is sometimes applied to the foot a footballer uses to kick.
    /// <see href="http://dbpedia.org/ontology/footedness"></see></summary>
    let footedness = _prefix "footedness"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/forces"></see>
    /// </summary>
    let forces = _prefix "forces"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foresterDistrict"></see>
    /// </summary>
    let foresterDistrict = _prefix "foresterDistrict"
    /// <summary>
    /// Format of the resource (as object). Use dct:format for literal, format for object
    /// <see href="http://dbpedia.org/ontology/format"></see></summary>
    let format = _prefix "format"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formationDate"></see>
    /// </summary>
    let formationDate = _prefix "formationDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formationYear"></see>
    /// </summary>
    let formationYear = _prefix "formationYear"
    /// <summary>
    /// A former member of the band.
    /// <see href="http://dbpedia.org/ontology/formerBandMember"></see></summary>
    let formerBandMember = _prefix "formerBandMember"
    /// <summary>
    /// A former parent broadcast network to which the broadcaster once belonged.
    /// <see href="http://dbpedia.org/ontology/formerBroadcastNetwork"></see></summary>
    let formerBroadcastNetwork = _prefix "formerBroadcastNetwork"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerCallsign"></see>
    /// </summary>
    let formerCallsign = _prefix "formerCallsign"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerChannel"></see>
    /// </summary>
    let formerChannel = _prefix "formerChannel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerChoreographer"></see>
    /// </summary>
    let formerChoreographer = _prefix "formerChoreographer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerCoach"></see>
    /// </summary>
    let formerCoach = _prefix "formerCoach"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerHighschool"></see>
    /// </summary>
    let formerHighschool = _prefix "formerHighschool"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerName"></see>
    /// </summary>
    let formerName = _prefix "formerName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerPartner"></see>
    /// </summary>
    let formerPartner = _prefix "formerPartner"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerTeam"></see>
    /// </summary>
    let formerTeam = _prefix "formerTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formula"></see>
    /// </summary>
    let formula = _prefix "formula"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fossil"></see>
    /// </summary>
    let fossil = _prefix "fossil"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foundation"></see>
    /// </summary>
    let foundation = _prefix "foundation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foundationPlace"></see>
    /// </summary>
    let foundationPlace = _prefix "foundationPlace"
    /// <summary>
    /// Identifies the founder of the described entity. This can be a person or a organisation for instance.
    /// <see href="http://dbpedia.org/ontology/foundedBy"></see></summary>
    let foundedBy = _prefix "foundedBy"
    /// <summary>
    /// Ein Gründer oder Gründungsmitglied einer Organisation, Religion oder eines Ortes.
    /// <see href="http://dbpedia.org/ontology/founder"></see></summary>
    let founder = _prefix "founder"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foundingDate"></see>
    /// </summary>
    let foundingDate = _prefix "foundingDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foundingYear"></see>
    /// </summary>
    let foundingYear = _prefix "foundingYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fourthCommander"></see>
    /// </summary>
    let fourthCommander = _prefix "fourthCommander"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/frazioni"></see>
    /// </summary>
    let frazioni = _prefix "frazioni"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/free"></see>
    /// </summary>
    let free = _prefix "free"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/freeDanseScore"></see>
    /// </summary>
    let freeDanseScore = _prefix "freeDanseScore"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/freeFlightTime"></see>
    /// </summary>
    let freeFlightTime = _prefix "freeFlightTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/freeLabel"></see>
    /// </summary>
    let freeLabel = _prefix "freeLabel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/freeProgCompetition"></see>
    /// </summary>
    let freeProgCompetition = _prefix "freeProgCompetition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/freeProgScore"></see>
    /// </summary>
    let freeProgScore = _prefix "freeProgScore"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/freeScoreCompetition"></see>
    /// </summary>
    let freeScoreCompetition = _prefix "freeScoreCompetition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/frequency"></see>
    /// </summary>
    let frequency = _prefix "frequency"
    /// <summary>
    /// The frequency of periodical publication (eg. Weekly, Bimonthly).
    /// <see href="http://dbpedia.org/ontology/frequencyOfPublication"></see></summary>
    let frequencyOfPublication = _prefix "frequencyOfPublication"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/frequentlyUpdated"></see>
    /// </summary>
    let frequentlyUpdated = _prefix "frequentlyUpdated"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/friend"></see>
    /// </summary>
    let friend = _prefix "friend"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/frontierLength"></see>
    /// </summary>
    let frontierLength = _prefix "frontierLength"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/frozen"></see>
    /// </summary>
    let frozen = _prefix "frozen"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fuel"></see>
    /// </summary>
    let fuel = _prefix "fuel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fuelCapacity"></see>
    /// </summary>
    let fuelCapacity = _prefix "fuelCapacity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fuelConsumption"></see>
    /// </summary>
    let fuelConsumption = _prefix "fuelConsumption"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fuelSystem"></see>
    /// </summary>
    let fuelSystem = _prefix "fuelSystem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fuelType"></see>
    /// </summary>
    let fuelType = _prefix "fuelType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fuelTypeName"></see>
    /// </summary>
    let fuelTypeName = _prefix "fuelTypeName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fullCompetition"></see>
    /// </summary>
    let fullCompetition = _prefix "fullCompetition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fullScore"></see>
    /// </summary>
    let fullScore = _prefix "fullScore"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/functionEndDate"></see>
    /// </summary>
    let functionEndDate = _prefix "functionEndDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/functionEndYear"></see>
    /// </summary>
    let functionEndYear = _prefix "functionEndYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/functionStartDate"></see>
    /// </summary>
    let functionStartDate = _prefix "functionStartDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/functionStartYear"></see>
    /// </summary>
    let functionStartYear = _prefix "functionStartYear"
    /// <summary>
    /// A organisation financing the research project.
    /// <see href="http://dbpedia.org/ontology/fundedBy"></see></summary>
    let fundedBy = _prefix "fundedBy"
    /// <summary>
    /// The last inquiry date about linguistics uses.
    /// <see href="http://dbpedia.org/ontology/galicianSpeakersDate"></see></summary>
    let galicianSpeakersDate = _prefix "galicianSpeakersDate"
    /// <summary>
    /// Percentage of Galician speakers.
    /// <see href="http://dbpedia.org/ontology/galicianSpeakersPercentage"></see></summary>
    let galicianSpeakersPercentage = _prefix "galicianSpeakersPercentage"
    /// <summary>
    /// A file contained in a gallery
    /// <see href="http://dbpedia.org/ontology/galleryItem"></see></summary>
    let galleryItem = _prefix "galleryItem"
    /// <summary>
    /// A game artist is an artist who creates art for one or more types of games. Game artists are responsible for all of the aspects of game development that call for visual art.
    /// <see href="http://dbpedia.org/ontology/gameArtist"></see></summary>
    let gameArtist = _prefix "gameArtist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gameEngine"></see>
    /// </summary>
    let gameEngine = _prefix "gameEngine"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gameModus"></see>
    /// </summary>
    let gameModus = _prefix "gameModus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/games"></see>
    /// </summary>
    let games = _prefix "games"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/garrison"></see>
    /// </summary>
    let garrison = _prefix "garrison"
    /// <summary>
    /// Awards of the Catalan Academy of Cinema
    /// <see href="http://dbpedia.org/ontology/gaudiAward"></see></summary>
    let gaudiAward = _prefix "gaudiAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geminiAward"></see>
    /// </summary>
    let geminiAward = _prefix "geminiAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gender"></see>
    /// </summary>
    let gender = _prefix "gender"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geneLocation"></see>
    /// </summary>
    let geneLocation = _prefix "geneLocation"
    /// <summary>
    /// the end of the gene
    /// <see href="http://dbpedia.org/ontology/geneLocationEnd"></see></summary>
    let geneLocationEnd = _prefix "geneLocationEnd"
    /// <summary>
    /// the start of the gene coordinates
    /// <see href="http://dbpedia.org/ontology/geneLocationStart"></see></summary>
    let geneLocationStart = _prefix "geneLocationStart"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geneReviewsId"></see>
    /// </summary>
    let geneReviewsId = _prefix "geneReviewsId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geneReviewsName"></see>
    /// </summary>
    let geneReviewsName = _prefix "geneReviewsName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/generalCouncil"></see>
    /// </summary>
    let generalCouncil = _prefix "generalCouncil"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/generalManager"></see>
    /// </summary>
    let generalManager = _prefix "generalManager"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/generationUnits"></see>
    /// </summary>
    let generationUnits = _prefix "generationUnits"
    /// <summary>
    /// the edition of the database used (i.e. hg19)
    /// <see href="http://dbpedia.org/ontology/genomeDB"></see></summary>
    let genomeDB = _prefix "genomeDB"
    /// <summary>
    /// The genre of the thing (music group, film, etc.)
    /// <see href="http://dbpedia.org/ontology/genre"></see></summary>
    let genre = _prefix "genre"
    /// <summary>
    /// A rank in the classification of organisms, below family and above species; a taxon at that rank
    /// <see href="http://dbpedia.org/ontology/genus"></see></summary>
    let genus = _prefix "genus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geolocDepartment"></see>
    /// </summary>
    let geolocDepartment = _prefix "geolocDepartment"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geolocDual"></see>
    /// </summary>
    let geolocDual = _prefix "geolocDual"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geologicPeriod"></see>
    /// </summary>
    let geologicPeriod = _prefix "geologicPeriod"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geology"></see>
    /// </summary>
    let geology = _prefix "geology"
    /// <summary>
    /// is a measure of the inequality of a distribution. It is commonly used as a measure of inequality of income or wealth.
    /// <see href="http://dbpedia.org/ontology/giniCoefficient"></see></summary>
    let giniCoefficient = _prefix "giniCoefficient"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/giniCoefficientAsOf"></see>
    /// </summary>
    let giniCoefficientAsOf = _prefix "giniCoefficientAsOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/giniCoefficientCategory"></see>
    /// </summary>
    let giniCoefficientCategory = _prefix "giniCoefficientCategory"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/giniCoefficientRanking"></see>
    /// </summary>
    let giniCoefficientRanking = _prefix "giniCoefficientRanking"
    /// <summary>
    /// Indicates a Food's effect on a person's blood glucose (blood sugar) level. Typically ranges between 50 and 100, where 100 represents the standard, an equivalent amount of pure glucose
    /// <see href="http://dbpedia.org/ontology/glycemicIndex"></see></summary>
    let glycemicIndex = _prefix "glycemicIndex"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gnisCode"></see>
    /// </summary>
    let gnisCode = _prefix "gnisCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gnl"></see>
    /// </summary>
    let gnl = _prefix "gnl"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goalsInLeague"></see>
    /// </summary>
    let goalsInLeague = _prefix "goalsInLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goalsInNationalTeam"></see>
    /// </summary>
    let goalsInNationalTeam = _prefix "goalsInNationalTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldMedalDouble"></see>
    /// </summary>
    let goldMedalDouble = _prefix "goldMedalDouble"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldMedalMixed"></see>
    /// </summary>
    let goldMedalMixed = _prefix "goldMedalMixed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldMedalSingle"></see>
    /// </summary>
    let goldMedalSingle = _prefix "goldMedalSingle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldMedalist"></see>
    /// </summary>
    let goldMedalist = _prefix "goldMedalist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldenCalfAward"></see>
    /// </summary>
    let goldenCalfAward = _prefix "goldenCalfAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldenGlobeAward"></see>
    /// </summary>
    let goldenGlobeAward = _prefix "goldenGlobeAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldenRaspberryAward"></see>
    /// </summary>
    let goldenRaspberryAward = _prefix "goldenRaspberryAward"
    /// <summary>
    /// Body that owns/operates the Place.
    /// <see href="http://dbpedia.org/ontology/governingBody"></see></summary>
    let governingBody = _prefix "governingBody"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/government"></see>
    /// </summary>
    let government = _prefix "government"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governmentCountry"></see>
    /// </summary>
    let governmentCountry = _prefix "governmentCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governmentElevation"></see>
    /// </summary>
    let governmentElevation = _prefix "governmentElevation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governmentMountain"></see>
    /// </summary>
    let governmentMountain = _prefix "governmentMountain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governmentPlace"></see>
    /// </summary>
    let governmentPlace = _prefix "governmentPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governmentPosition"></see>
    /// </summary>
    let governmentPosition = _prefix "governmentPosition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governmentRegion"></see>
    /// </summary>
    let governmentRegion = _prefix "governmentRegion"
    /// <summary>
    /// broadly, the type of structure of its government
    /// <see href="http://dbpedia.org/ontology/governmentType"></see></summary>
    let governmentType = _prefix "governmentType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governor"></see>
    /// </summary>
    let governor = _prefix "governor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governorGeneral"></see>
    /// </summary>
    let governorGeneral = _prefix "governorGeneral"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governorate"></see>
    /// </summary>
    let governorate = _prefix "governorate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goyaAward"></see>
    /// </summary>
    let goyaAward = _prefix "goyaAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grades"></see>
    /// </summary>
    let grades = _prefix "grades"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grammyAward"></see>
    /// </summary>
    let grammyAward = _prefix "grammyAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grandsire"></see>
    /// </summary>
    let grandsire = _prefix "grandsire"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grave"></see>
    /// </summary>
    let grave = _prefix "grave"
    /// <summary>
    /// Refers to the famous 1918 edition of Gray's Anatomy.
    /// <see href="http://dbpedia.org/ontology/grayPage"></see></summary>
    let grayPage = _prefix "grayPage"
    /// <summary>
    /// Refers to the famous 1918 edition of Gray's Anatomy.
    /// <see href="http://dbpedia.org/ontology/graySubject"></see></summary>
    let graySubject = _prefix "graySubject"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/greekName"></see>
    /// </summary>
    let greekName = _prefix "greekName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/greenLongDistancePisteNumber"></see>
    /// </summary>
    let greenLongDistancePisteNumber = _prefix "greenLongDistancePisteNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/greenSkiPisteNumber"></see>
    /// </summary>
    let greenSkiPisteNumber = _prefix "greenSkiPisteNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gridReference"></see>
    /// </summary>
    let gridReference = _prefix "gridReference"
    /// <summary>
    /// grinding capability for Mills
    /// <see href="http://dbpedia.org/ontology/grindingCapability"></see></summary>
    let grindingCapability = _prefix "grindingCapability"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gross"></see>
    /// </summary>
    let gross = _prefix "gross"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grossDomesticProduct"></see>
    /// </summary>
    let grossDomesticProduct = _prefix "grossDomesticProduct"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grossDomesticProductAsOf"></see>
    /// </summary>
    let grossDomesticProductAsOf = _prefix "grossDomesticProductAsOf"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grossDomesticProductNominalPerCapita"></see>
    /// </summary>
    let grossDomesticProductNominalPerCapita =
        _prefix "grossDomesticProductNominalPerCapita"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grossDomesticProductPerPeople"></see>
    /// </summary>
    let grossDomesticProductPerPeople = _prefix "grossDomesticProductPerPeople"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grossDomesticProductPurchasingPowerParityPerCapita"></see>
    /// </summary>
    let grossDomesticProductPurchasingPowerParityPerCapita =
        _prefix "grossDomesticProductPurchasingPowerParityPerCapita"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grossDomesticProductRank"></see>
    /// </summary>
    let grossDomesticProductRank = _prefix "grossDomesticProductRank"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ground"></see>
    /// </summary>
    let ground = _prefix "ground"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/groundsForLiquidation"></see>
    /// </summary>
    let groundsForLiquidation = _prefix "groundsForLiquidation"
    /// <summary>
    /// Designates the category of people commemorated by a monument
    /// <see href="http://dbpedia.org/ontology/groupCommemorated"></see></summary>
    let groupCommemorated = _prefix "groupCommemorated"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/growingGrape"></see>
    /// </summary>
    let growingGrape = _prefix "growingGrape"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/guest"></see>
    /// </summary>
    let guest = _prefix "guest"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gun"></see>
    /// </summary>
    let gun = _prefix "gun"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gymApparatus"></see>
    /// </summary>
    let gymApparatus = _prefix "gymApparatus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hairColor"></see>
    /// </summary>
    let hairColor = _prefix "hairColor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hairColour"></see>
    /// </summary>
    let hairColour = _prefix "hairColour"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hairs"></see>
    /// </summary>
    let hairs = _prefix "hairs"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hallOfFame"></see>
    /// </summary>
    let hallOfFame = _prefix "hallOfFame"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hand"></see>
    /// </summary>
    let hand = _prefix "hand"
    /// <summary>
    /// an attribute of humans defined by their unequal distribution of fine motor skill between the left and right hands.
    /// <see href="http://dbpedia.org/ontology/handedness"></see></summary>
    let handedness = _prefix "handedness"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/handisport"></see>
    /// </summary>
    let handisport = _prefix "handisport"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasAbsorbedMunicipality"></see>
    /// </summary>
    let hasAbsorbedMunicipality = _prefix "hasAbsorbedMunicipality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasAnnotation"></see>
    /// </summary>
    let hasAnnotation = _prefix "hasAnnotation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasChannel"></see>
    /// </summary>
    let hasChannel = _prefix "hasChannel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasInput"></see>
    /// </summary>
    let hasInput = _prefix "hasInput"
    /// <summary>
    /// indicates another place situated inside.
    /// <see href="http://dbpedia.org/ontology/hasInsidePlace"></see></summary>
    let hasInsidePlace = _prefix "hasInsidePlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasJunctionWith"></see>
    /// </summary>
    let hasJunctionWith = _prefix "hasJunctionWith"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasKMLData"></see>
    /// </summary>
    let hasKMLData = _prefix "hasKMLData"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasNaturalBust"></see>
    /// </summary>
    let hasNaturalBust = _prefix "hasNaturalBust"
    /// <summary>
    /// indicates another place situated around outside.
    /// <see href="http://dbpedia.org/ontology/hasOutsidePlace"></see></summary>
    let hasOutsidePlace = _prefix "hasOutsidePlace"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/hasSurfaceForm"></see></summary>
    let hasSurfaceForm = _prefix "hasSurfaceForm"
    /// <summary>
    /// variant or variation, for example all variations of a color
    /// <see href="http://dbpedia.org/ontology/hasVariant"></see></summary>
    let hasVariant = _prefix "hasVariant"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/head"></see>
    /// </summary>
    let head = _prefix "head"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/headAlloy"></see>
    /// </summary>
    let headAlloy = _prefix "headAlloy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/headChef"></see>
    /// </summary>
    let headChef = _prefix "headChef"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/headLabel"></see>
    /// </summary>
    let headLabel = _prefix "headLabel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/headOfFamily"></see>
    /// </summary>
    let headOfFamily = _prefix "headOfFamily"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/headquarter"></see>
    /// </summary>
    let headquarter = _prefix "headquarter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/headteacher"></see>
    /// </summary>
    let headteacher = _prefix "headteacher"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/height"></see>
    /// </summary>
    let height = _prefix "height"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/heightAboveAverageTerrain"></see>
    /// </summary>
    let heightAboveAverageTerrain = _prefix "heightAboveAverageTerrain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/heightAgainst"></see>
    /// </summary>
    let heightAgainst = _prefix "heightAgainst"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/heightAttack"></see>
    /// </summary>
    let heightAttack = _prefix "heightAttack"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/heir"></see>
    /// </summary>
    let heir = _prefix "heir"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/heisman"></see>
    /// </summary>
    let heisman = _prefix "heisman"
    /// <summary>
    /// registered in a heritage register : inventory of cultural properties, natural and man-made, tangible and intangible, movable and immovable, that are deemed to be of sufficient heritage value to be separately identified and recorded.
    /// <see href="http://dbpedia.org/ontology/heritageRegister"></see></summary>
    let heritageRegister = _prefix "heritageRegister"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hgncid"></see>
    /// </summary>
    let hgncid = _prefix "hgncid"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestBreak"></see>
    /// </summary>
    let highestBreak = _prefix "highestBreak"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestBuildingInYear"></see>
    /// </summary>
    let highestBuildingInYear = _prefix "highestBuildingInYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestMountain"></see>
    /// </summary>
    let highestMountain = _prefix "highestMountain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestPlace"></see>
    /// </summary>
    let highestPlace = _prefix "highestPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestPoint"></see>
    /// </summary>
    let highestPoint = _prefix "highestPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestPointIsland"></see>
    /// </summary>
    let highestPointIsland = _prefix "highestPointIsland"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestPosition"></see>
    /// </summary>
    let highestPosition = _prefix "highestPosition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestRank"></see>
    /// </summary>
    let highestRank = _prefix "highestRank"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestRegion"></see>
    /// </summary>
    let highestRegion = _prefix "highestRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestState"></see>
    /// </summary>
    let highestState = _prefix "highestState"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highschool"></see>
    /// </summary>
    let highschool = _prefix "highschool"
    /// <summary>
    /// the highway system that a route is part of
    /// <see href="http://dbpedia.org/ontology/highwaySystem"></see></summary>
    let highwaySystem = _prefix "highwaySystem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hipSize"></see>
    /// </summary>
    let hipSize = _prefix "hipSize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/historicalMap"></see>
    /// </summary>
    let historicalMap = _prefix "historicalMap"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/historicalName"></see>
    /// </summary>
    let historicalName = _prefix "historicalName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/historicalRegion"></see>
    /// </summary>
    let historicalRegion = _prefix "historicalRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hof"></see>
    /// </summary>
    let hof = _prefix "hof"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/homage"></see>
    /// </summary>
    let homage = _prefix "homage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/homeArena"></see>
    /// </summary>
    let homeArena = _prefix "homeArena"
    /// <summary>
    /// A colour represented by its hex code (e.g.: #FF0000 or #40E0D0).
    /// <see href="http://dbpedia.org/ontology/homeColourHexCode"></see></summary>
    let homeColourHexCode = _prefix "homeColourHexCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/homeStadium"></see>
    /// </summary>
    let homeStadium = _prefix "homeStadium"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/homeport"></see>
    /// </summary>
    let homeport = _prefix "homeport"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hometown"></see>
    /// </summary>
    let hometown = _prefix "hometown"
    /// <summary>
    /// Honours bestowed upon a Person, Organization, RaceHorse, etc
    /// <see href="http://dbpedia.org/ontology/honours"></see></summary>
    let honours = _prefix "honours"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hopmanCup"></see>
    /// </summary>
    let hopmanCup = _prefix "hopmanCup"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/horseRidingDiscipline"></see>
    /// </summary>
    let horseRidingDiscipline = _prefix "horseRidingDiscipline"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/house"></see>
    /// </summary>
    let house = _prefix "house"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hraState"></see>
    /// </summary>
    let hraState = _prefix "hraState"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hsvCoordinateHue"></see>
    /// </summary>
    let hsvCoordinateHue = _prefix "hsvCoordinateHue"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hsvCoordinateSaturation"></see>
    /// </summary>
    let hsvCoordinateSaturation = _prefix "hsvCoordinateSaturation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hsvCoordinateValue"></see>
    /// </summary>
    let hsvCoordinateValue = _prefix "hsvCoordinateValue"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hubAirport"></see>
    /// </summary>
    let hubAirport = _prefix "hubAirport"
    /// <summary>
    /// a composite statistic used to rank countries by level of "human development"
    /// <see href="http://dbpedia.org/ontology/humanDevelopmentIndex"></see></summary>
    let humanDevelopmentIndex = _prefix "humanDevelopmentIndex"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/humanDevelopmentIndexAsOf"></see>
    /// </summary>
    let humanDevelopmentIndexAsOf = _prefix "humanDevelopmentIndexAsOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/humanDevelopmentIndexRank"></see>
    /// </summary>
    let humanDevelopmentIndexRank = _prefix "humanDevelopmentIndexRank"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/humanDevelopmentIndexRankingCategory"></see>
    /// </summary>
    let humanDevelopmentIndexRankingCategory =
        _prefix "humanDevelopmentIndexRankingCategory"

    /// <summary>
    /// Plants from which another plant (or cultivar) has been developed from
    /// <see href="http://dbpedia.org/ontology/hybrid"></see></summary>
    let hybrid = _prefix "hybrid"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iafdId"></see>
    /// </summary>
    let iafdId = _prefix "iafdId"
    /// <summary>
    /// IATA designation for airline companies
    /// <see href="http://dbpedia.org/ontology/iataAirlineCode"></see></summary>
    let iataAirlineCode = _prefix "iataAirlineCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iataLocationIdentifier"></see>
    /// </summary>
    let iataLocationIdentifier = _prefix "iataLocationIdentifier"
    /// <summary>
    /// The Internet Broadway Database ID (IBDB ID) from ibdb.com.
    /// <see href="http://dbpedia.org/ontology/ibdbId"></see></summary>
    let ibdbId = _prefix "ibdbId"
    /// <summary>
    /// ICAO designation for airline companies
    /// <see href="http://dbpedia.org/ontology/icaoAirlineCode"></see></summary>
    let icaoAirlineCode = _prefix "icaoAirlineCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/icaoLocationIdentifier"></see>
    /// </summary>
    let icaoLocationIdentifier = _prefix "icaoLocationIdentifier"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/icd1"></see>
    /// </summary>
    let icd1 = _prefix "icd1"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/icd10"></see>
    /// </summary>
    let icd10 = _prefix "icd10"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/icd9"></see>
    /// </summary>
    let icd9 = _prefix "icd9"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/icdo"></see>
    /// </summary>
    let icdo = _prefix "icdo"
    /// <summary>
    /// Standard iconographic elements used when depicting a Saint: pontifical, episcopal, insignia, martyrdom instruments
    /// <see href="http://dbpedia.org/ontology/iconographicAttributes"></see></summary>
    let iconographicAttributes = _prefix "iconographicAttributes"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/id"></see>
    /// </summary>
    let id = _prefix "id"
    /// <summary>
    /// ID of a film on Allocine
    /// <see href="http://dbpedia.org/ontology/idAllocine"></see></summary>
    let idAllocine = _prefix "idAllocine"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/idNumber"></see>
    /// </summary>
    let idNumber = _prefix "idNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/identificationSymbol"></see>
    /// </summary>
    let identificationSymbol = _prefix "identificationSymbol"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ideology"></see>
    /// </summary>
    let ideology = _prefix "ideology"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iftaAward"></see>
    /// </summary>
    let iftaAward = _prefix "iftaAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iihfHof"></see>
    /// </summary>
    let iihfHof = _prefix "iihfHof"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/illiteracy"></see>
    /// </summary>
    let illiteracy = _prefix "illiteracy"
    /// <summary>
    /// Illustrator (where used throughout and a major feature)
    /// <see href="http://dbpedia.org/ontology/illustrator"></see></summary>
    let illustrator = _prefix "illustrator"
    /// <summary>
    /// the image size expressed in pixels
    /// <see href="http://dbpedia.org/ontology/imageSize"></see></summary>
    let imageSize = _prefix "imageSize"
    /// <summary>
    /// International Movie Database ID. Applies to Films, Actors, etc
    /// <see href="http://dbpedia.org/ontology/imdbId"></see></summary>
    let imdbId = _prefix "imdbId"
    /// <summary>
    /// The impact factor, often abbreviated IF, is a measure reflecting the average number of citations to articles published in science and social science journals.
    /// <see href="http://dbpedia.org/ontology/impactFactor"></see></summary>
    let impactFactor = _prefix "impactFactor"
    /// <summary>
    /// Census year of the imapct factor.
    /// <see href="http://dbpedia.org/ontology/impactFactorAsOf"></see></summary>
    let impactFactorAsOf = _prefix "impactFactorAsOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/imposedDanseCompetition"></see>
    /// </summary>
    let imposedDanseCompetition = _prefix "imposedDanseCompetition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/imposedDanseScore"></see>
    /// </summary>
    let imposedDanseScore = _prefix "imposedDanseScore"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/inCemetery"></see>
    /// </summary>
    let inCemetery = _prefix "inCemetery"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/inchi"></see>
    /// </summary>
    let inchi = _prefix "inchi"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/inclination"></see>
    /// </summary>
    let inclination = _prefix "inclination"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/income"></see>
    /// </summary>
    let income = _prefix "income"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/incumbent"></see>
    /// </summary>
    let incumbent = _prefix "incumbent"
    /// <summary>
    /// GND (Gemeinsame Normdatei) is an international authority file for the organisation of personal names, subject headings and corporate bodies from catalogues. It is used mainly for documentation in libraries and archives. The GND is managed by the German National Library in cooperation with various library networks. The GND falls under the Creative Commons Zero(CC0) license.
    /// <see href="http://dbpedia.org/ontology/individualisedGnd"></see></summary>
    let individualisedGnd = _prefix "individualisedGnd"
    /// <summary>
    /// PND (Personennamendatei) data about a person. PND is published by the German National Library. For each person there is a record with her/his name, birth and occupation connected with a unique identifier, the PND number.
    /// <see href="http://dbpedia.org/ontology/individualisedPnd"></see></summary>
    let individualisedPnd = _prefix "individualisedPnd"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/industry"></see>
    /// </summary>
    let industry = _prefix "industry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/infantMortality"></see>
    /// </summary>
    let infantMortality = _prefix "infantMortality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/inflow"></see>
    /// </summary>
    let inflow = _prefix "inflow"
    /// <summary>
    /// The subject influenced the object. inverseOf influencedBy. Subject and object can be Persons or Works (eg ProgrammingLanguage)
    /// <see href="http://dbpedia.org/ontology/influenced"></see></summary>
    let influenced = _prefix "influenced"
    /// <summary>
    /// The subject was influenced by the object. inverseOf influenced. Subject and object can be Persons or Works (eg ProgrammingLanguage)
    /// <see href="http://dbpedia.org/ontology/influencedBy"></see></summary>
    let influencedBy = _prefix "influencedBy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/information"></see>
    /// </summary>
    let information = _prefix "information"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/informationName"></see>
    /// </summary>
    let informationName = _prefix "informationName"
    /// <summary>
    /// Main ingredient used to prepare a specific Food or Beverage. For strings use ingredientName, for objects use ingredient.
    /// <see href="http://dbpedia.org/ontology/ingredient"></see></summary>
    let ingredient = _prefix "ingredient"
    /// <summary>
    /// Main ingredient used to prepare a specific Food or Beverage. For strings use ingredientName, for objects use ingredient.
    /// <see href="http://dbpedia.org/ontology/ingredientName"></see></summary>
    let ingredientName = _prefix "ingredientName"
    /// <summary>
    /// Initial use of the architectural structure.
    /// <see href="http://dbpedia.org/ontology/initiallyUsedFor"></see></summary>
    let initiallyUsedFor = _prefix "initiallyUsedFor"
    /// <summary>
    /// International Nonproprietary Name given to a pharmaceutical substance
    /// <see href="http://dbpedia.org/ontology/inn"></see></summary>
    let inn = _prefix "inn"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/innervates"></see>
    /// </summary>
    let innervates = _prefix "innervates"
    /// <summary>
    /// Text of an inscription on the object
    /// <see href="http://dbpedia.org/ontology/inscription"></see></summary>
    let inscription = _prefix "inscription"
    /// <summary>
    /// numerical indexing code used by the French National Institute for Statistics and Economic Studies (INSEE) to identify various entities
    /// <see href="http://dbpedia.org/ontology/inseeCode"></see></summary>
    let inseeCode = _prefix "inseeCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/installedCapacity"></see>
    /// </summary>
    let installedCapacity = _prefix "installedCapacity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/institution"></see>
    /// </summary>
    let institution = _prefix "institution"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/instrument"></see>
    /// </summary>
    let instrument = _prefix "instrument"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/intercommunality"></see>
    /// </summary>
    let intercommunality = _prefix "intercommunality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/interest"></see>
    /// </summary>
    let interest = _prefix "interest"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/internationalAffiliation"></see>
    /// </summary>
    let internationalAffiliation = _prefix "internationalAffiliation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/internationalPhonePrefix"></see>
    /// </summary>
    let internationalPhonePrefix = _prefix "internationalPhonePrefix"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/internationalPhonePrefixLabel"></see>
    /// </summary>
    let internationalPhonePrefixLabel = _prefix "internationalPhonePrefixLabel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/internationally"></see>
    /// </summary>
    let internationally = _prefix "internationally"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/introduced"></see>
    /// </summary>
    let introduced = _prefix "introduced"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/introductionDate"></see>
    /// </summary>
    let introductionDate = _prefix "introductionDate"
    /// <summary>
    /// Lortel Archives Internet Off-Broadway database "show id" from lortel.org.
    /// <see href="http://dbpedia.org/ontology/iobdbId"></see></summary>
    let iobdbId = _prefix "iobdbId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isCityState"></see>
    /// </summary>
    let isCityState = _prefix "isCityState"
    /// <summary>
    /// True if the station is handicapped accessible.
    /// <see href="http://dbpedia.org/ontology/isHandicappedAccessible"></see></summary>
    let isHandicappedAccessible = _prefix "isHandicappedAccessible"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isPartOf"></see>
    /// </summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isPartOfAnatomicalStructure"></see>
    /// </summary>
    let isPartOfAnatomicalStructure = _prefix "isPartOfAnatomicalStructure"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isPartOfMilitaryConflict"></see>
    /// </summary>
    let isPartOfMilitaryConflict = _prefix "isPartOfMilitaryConflict"
    /// <summary>
    /// Name of another thing that this thing is part of. Use for infobox "part of" properties given as text; for objects use isPartOf
    /// <see href="http://dbpedia.org/ontology/isPartOfName"></see></summary>
    let isPartOfName = _prefix "isPartOfName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isPartOfWineRegion"></see>
    /// </summary>
    let isPartOfWineRegion = _prefix "isPartOfWineRegion"
    /// <summary>
    /// In academia peer review is often used to determine an academic papers suitability for publication.
    /// <see href="http://dbpedia.org/ontology/isPeerReviewed"></see></summary>
    let isPeerReviewed = _prefix "isPeerReviewed"
    /// <summary>
    /// indicate a place is a stop on a road.
    /// <see href="http://dbpedia.org/ontology/isRouteStop"></see></summary>
    let isRouteStop = _prefix "isRouteStop"
    /// <summary>
    /// The International Standard Book Number (ISBN) is a unique numeric commercial book identifier based upon the 9-digit Standard Book Numbering (SBN) code.
    /// <see href="http://dbpedia.org/ontology/isbn"></see></summary>
    let isbn = _prefix "isbn"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isil"></see>
    /// </summary>
    let isil = _prefix "isil"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/island"></see>
    /// </summary>
    let island = _prefix "island"
    /// <summary>
    /// ISNI is a method for uniquely identifying the public identities of contributors to media content such as books, TV programmes, and newspaper articles.
    /// <see href="http://dbpedia.org/ontology/isniId"></see></summary>
    let isniId = _prefix "isniId"
    /// <summary>
    /// defines codes for the names of countries, dependent territories, and special areas of geographical interest
    /// <see href="http://dbpedia.org/ontology/iso31661Code"></see></summary>
    let iso31661Code = _prefix "iso31661Code"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iso6391Code"></see>
    /// </summary>
    let iso6391Code = _prefix "iso6391Code"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LanguageCode"></see>
    /// </summary>
    let LanguageCode = _prefix "LanguageCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iso6392Code"></see>
    /// </summary>
    let iso6392Code = _prefix "iso6392Code"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iso6393Code"></see>
    /// </summary>
    let iso6393Code = _prefix "iso6393Code"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isoCodeRegion"></see>
    /// </summary>
    let isoCodeRegion = _prefix "isoCodeRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/issDockings"></see>
    /// </summary>
    let issDockings = _prefix "issDockings"
    /// <summary>
    /// International Standard Serial Number (ISSN)
    /// <see href="http://dbpedia.org/ontology/issn"></see></summary>
    let issn = _prefix "issn"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ist"></see>
    /// </summary>
    let ist = _prefix "ist"
    /// <summary>
    /// Indexing code used for Italian municipalities
    /// <see href="http://dbpedia.org/ontology/istat"></see></summary>
    let istat = _prefix "istat"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ithfDate"></see>
    /// </summary>
    let ithfDate = _prefix "ithfDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iucnCategory"></see>
    /// </summary>
    let iucnCategory = _prefix "iucnCategory"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iupacName"></see>
    /// </summary>
    let iupacName = _prefix "iupacName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/jockey"></see>
    /// </summary>
    let jockey = _prefix "jockey"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/jointCommunity"></see>
    /// </summary>
    let jointCommunity = _prefix "jointCommunity"
    /// <summary>
    /// JSTOR number (short for Journal Storage) is a United States-based online system number for archiving academic journals.
    /// <see href="http://dbpedia.org/ontology/jstor"></see></summary>
    let jstor = _prefix "jstor"
    /// <summary>
    /// leading judge
    /// <see href="http://dbpedia.org/ontology/judge"></see></summary>
    let judge = _prefix "judge"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/juniorSeason"></see>
    /// </summary>
    let juniorSeason = _prefix "juniorSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/juniorTeam"></see>
    /// </summary>
    let juniorTeam = _prefix "juniorTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/juniorYearsEndYear"></see>
    /// </summary>
    let juniorYearsEndYear = _prefix "juniorYearsEndYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/juniorYearsStartYear"></see>
    /// </summary>
    let juniorYearsStartYear = _prefix "juniorYearsStartYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/jureLanguage"></see>
    /// </summary>
    let jureLanguage = _prefix "jureLanguage"
    /// <summary>
    /// Jurisdiction is the practical authority granted to a formally constituted legal body or to a political leader to deal with and make pronouncements on legal matters and, by implication, to administer justice within a defined area of responsibility.
    /// <see href="http://dbpedia.org/ontology/jurisdiction"></see></summary>
    let jurisdiction = _prefix "jurisdiction"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/jutsu"></see>
    /// </summary>
    let jutsu = _prefix "jutsu"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/khlDraft"></see>
    /// </summary>
    let khlDraft = _prefix "khlDraft"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/khlDraftTeam"></see>
    /// </summary>
    let khlDraftTeam = _prefix "khlDraftTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/khlDraftYear"></see>
    /// </summary>
    let khlDraftYear = _prefix "khlDraftYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/killedBy"></see>
    /// </summary>
    let killedBy = _prefix "killedBy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/kinOfLanguage"></see>
    /// </summary>
    let kinOfLanguage = _prefix "kinOfLanguage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/kindOfCoordinate"></see>
    /// </summary>
    let kindOfCoordinate = _prefix "kindOfCoordinate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/kindOfCriminal"></see>
    /// </summary>
    let kindOfCriminal = _prefix "kindOfCriminal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/kindOfCriminalAction"></see>
    /// </summary>
    let kindOfCriminalAction = _prefix "kindOfCriminalAction"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/kindOfRock"></see>
    /// </summary>
    let kindOfRock = _prefix "kindOfRock"
    /// <summary>
    /// In biology, kingdom (Latin: regnum, pl. regna) is a taxonomic rank, which is either the highest rank or in the more recent three-domain system, the rank below domain.
    /// <see href="http://dbpedia.org/ontology/kingdom"></see></summary>
    let kingdom = _prefix "kingdom"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/knownFor"></see>
    /// </summary>
    let knownFor = _prefix "knownFor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ko"></see>
    /// </summary>
    let ko = _prefix "ko"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lahHof"></see>
    /// </summary>
    let lahHof = _prefix "lahHof"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lake"></see>
    /// </summary>
    let lake = _prefix "lake"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/land"></see>
    /// </summary>
    let land_ = _prefix "land"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landArea"></see>
    /// </summary>
    let landArea = _prefix "landArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landPercentage"></see>
    /// </summary>
    let landPercentage = _prefix "landPercentage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landRegistryCode"></see>
    /// </summary>
    let landRegistryCode = _prefix "landRegistryCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landeshauptmann"></see>
    /// </summary>
    let landeshauptmann = _prefix "landeshauptmann"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landingDate"></see>
    /// </summary>
    let landingDate = _prefix "landingDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landingSite"></see>
    /// </summary>
    let landingSite = _prefix "landingSite"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landingVehicle"></see>
    /// </summary>
    let landingVehicle = _prefix "landingVehicle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landskap"></see>
    /// </summary>
    let landskap = _prefix "landskap"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landtag"></see>
    /// </summary>
    let landtag = _prefix "landtag"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landtagMandate"></see>
    /// </summary>
    let landtagMandate = _prefix "landtagMandate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/languageCode"></see>
    /// </summary>
    let languageCode = _prefix "languageCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/languageFamily"></see>
    /// </summary>
    let languageFamily = _prefix "languageFamily"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/languageRegulator"></see>
    /// </summary>
    let languageRegulator = _prefix "languageRegulator"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/largestCity"></see>
    /// </summary>
    let largestCity = _prefix "largestCity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/largestMetro"></see>
    /// </summary>
    let largestMetro = _prefix "largestMetro"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/largestSettlement"></see>
    /// </summary>
    let largestSettlement = _prefix "largestSettlement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/largestWin"></see>
    /// </summary>
    let largestWin = _prefix "largestWin"
    /// <summary>
    /// The date on which the broadcaster made its last broadcast.
    /// <see href="http://dbpedia.org/ontology/lastAirDate"></see></summary>
    let lastAirDate = _prefix "lastAirDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastAppearance"></see>
    /// </summary>
    let lastAppearance = _prefix "lastAppearance"
    /// <summary>
    /// The last election date for the house.
    /// <see href="http://dbpedia.org/ontology/lastElectionDate"></see></summary>
    let lastElectionDate = _prefix "lastElectionDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastFamilyMember"></see>
    /// </summary>
    let lastFamilyMember = _prefix "lastFamilyMember"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastFlight"></see>
    /// </summary>
    let lastFlight = _prefix "lastFlight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastFlightEndDate"></see>
    /// </summary>
    let lastFlightEndDate = _prefix "lastFlightEndDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastFlightStartDate"></see>
    /// </summary>
    let lastFlightStartDate = _prefix "lastFlightStartDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastLaunch"></see>
    /// </summary>
    let lastLaunch = _prefix "lastLaunch"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastLaunchDate"></see>
    /// </summary>
    let lastLaunchDate = _prefix "lastLaunchDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastLaunchRocket"></see>
    /// </summary>
    let lastLaunchRocket = _prefix "lastLaunchRocket"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastPosition"></see>
    /// </summary>
    let lastPosition = _prefix "lastPosition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastProMatch"></see>
    /// </summary>
    let lastProMatch = _prefix "lastProMatch"
    /// <summary>
    /// Date of the last publication.
    /// <see href="http://dbpedia.org/ontology/lastPublicationDate"></see></summary>
    let lastPublicationDate = _prefix "lastPublicationDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastRace"></see>
    /// </summary>
    let lastRace = _prefix "lastRace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastSeason"></see>
    /// </summary>
    let lastSeason = _prefix "lastSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastWin"></see>
    /// </summary>
    let lastWin = _prefix "lastWin"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/laterality"></see>
    /// </summary>
    let laterality = _prefix "laterality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/latestElection"></see>
    /// </summary>
    let latestElection = _prefix "latestElection"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/latestPreviewDate"></see>
    /// </summary>
    let latestPreviewDate = _prefix "latestPreviewDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/latestPreviewVersion"></see>
    /// </summary>
    let latestPreviewVersion = _prefix "latestPreviewVersion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/latestReleaseDate"></see>
    /// </summary>
    let latestReleaseDate = _prefix "latestReleaseDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/latestReleaseVersion"></see>
    /// </summary>
    let latestReleaseVersion = _prefix "latestReleaseVersion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/latinName"></see>
    /// </summary>
    let latinName = _prefix "latinName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/launch"></see>
    /// </summary>
    let launch = _prefix "launch"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/launchDate"></see>
    /// </summary>
    let launchDate = _prefix "launchDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/launchPad"></see>
    /// </summary>
    let launchPad = _prefix "launchPad"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/launchSite"></see>
    /// </summary>
    let launchSite = _prefix "launchSite"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/launchVehicle"></see>
    /// </summary>
    let launchVehicle = _prefix "launchVehicle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/launches"></see>
    /// </summary>
    let launches = _prefix "launches"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/laurenceOlivierAward"></see>
    /// </summary>
    let laurenceOlivierAward = _prefix "laurenceOlivierAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lawCountry"></see>
    /// </summary>
    let lawCountry = _prefix "lawCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/layingDown"></see>
    /// </summary>
    let layingDown = _prefix "layingDown"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/layout"></see>
    /// </summary>
    let layout = _prefix "layout"
    /// <summary>
    /// The Library of Congress Classification (LCC) is a system of library classification developed by the Library of Congress.
    /// <see href="http://dbpedia.org/ontology/lcc"></see></summary>
    let lcc = _prefix "lcc"
    /// <summary>
    /// The Library of Congress Control Number or LCCN is a serially based system of numbering cataloging records in the Library of Congress in the United States. It has nothing to do with the contents of any book, and should not be confused with Library of Congress Classification.
    /// <see href="http://dbpedia.org/ontology/lccn"></see></summary>
    let lccn = _prefix "lccn"
    /// <summary>
    /// Library of Congress Control Number
    /// <see href="http://dbpedia.org/ontology/lccnId"></see></summary>
    let lccnId = _prefix "lccnId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lchfDraft"></see>
    /// </summary>
    let lchfDraft = _prefix "lchfDraft"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lchfDraftTeam"></see>
    /// </summary>
    let lchfDraftTeam = _prefix "lchfDraftTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lchfDraftYear"></see>
    /// </summary>
    let lchfDraftYear = _prefix "lchfDraftYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leadTeam"></see>
    /// </summary>
    let leadTeam = _prefix "leadTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leadYear"></see>
    /// </summary>
    let leadYear = _prefix "leadYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leader"></see>
    /// </summary>
    let leader = _prefix "leader"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leaderFunction"></see>
    /// </summary>
    let leaderFunction = _prefix "leaderFunction"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leaderName"></see>
    /// </summary>
    let leaderName = _prefix "leaderName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leaderParty"></see>
    /// </summary>
    let leaderParty = _prefix "leaderParty"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leaderTitle"></see>
    /// </summary>
    let leaderTitle = _prefix "leaderTitle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leadership"></see>
    /// </summary>
    let leadership = _prefix "leadership"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/league"></see>
    /// </summary>
    let league = _prefix "league"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leagueManager"></see>
    /// </summary>
    let leagueManager = _prefix "leagueManager"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leftChild"></see>
    /// </summary>
    let leftChild = _prefix "leftChild"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leftTributary"></see>
    /// </summary>
    let leftTributary = _prefix "leftTributary"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/legalArrondissement"></see>
    /// </summary>
    let legalArrondissement = _prefix "legalArrondissement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BelgiumSettlement"></see>
    /// </summary>
    let BelgiumSettlement = _prefix "BelgiumSettlement"
    /// <summary>
    /// article in code book or statute book referred to in this legal case
    /// <see href="http://dbpedia.org/ontology/legalArticle"></see></summary>
    let legalArticle = _prefix "legalArticle"
    /// <summary>
    /// There are many types of business entity defined in the legal systems of various countries. These include corporations, cooperatives, partnerships, sole traders, limited liability company and other specialized types of organization.
    /// <see href="http://dbpedia.org/ontology/legalForm"></see></summary>
    let legalForm = _prefix "legalForm"
    /// <summary>
    /// The term of the on-going session (e.g.: "40th Canadian Parliament").
    /// <see href="http://dbpedia.org/ontology/legislativePeriodName"></see></summary>
    let legislativePeriodName = _prefix "legislativePeriodName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/length"></see>
    /// </summary>
    let length = _prefix "length"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lengthQuote"></see>
    /// </summary>
    let lengthQuote = _prefix "lengthQuote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lengthReference"></see>
    /// </summary>
    let lengthReference = _prefix "lengthReference"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lethalOnChickens"></see>
    /// </summary>
    let lethalOnChickens = _prefix "lethalOnChickens"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lethalOnMice"></see>
    /// </summary>
    let lethalOnMice = _prefix "lethalOnMice"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lethalOnRabbits"></see>
    /// </summary>
    let lethalOnRabbits = _prefix "lethalOnRabbits"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lethalOnRats"></see>
    /// </summary>
    let lethalOnRats = _prefix "lethalOnRats"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/liberationDate"></see>
    /// </summary>
    let liberationDate = _prefix "liberationDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/libretto"></see>
    /// </summary>
    let libretto = _prefix "libretto"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/licenceLetter"></see>
    /// </summary>
    let licenceLetter = _prefix "licenceLetter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GermanSettlement"></see>
    /// </summary>
    let GermanSettlement = _prefix "GermanSettlement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/licenceNumber"></see>
    /// </summary>
    let licenceNumber = _prefix "licenceNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/licenceNumberLabel"></see>
    /// </summary>
    let licenceNumberLabel = _prefix "licenceNumberLabel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/license"></see>
    /// </summary>
    let license = _prefix "license"
    /// <summary>
    /// Identify which company or entity holds the licence (mostly string are used in Wikipedia, therefore range is xsd:sting).
    /// <see href="http://dbpedia.org/ontology/licensee"></see></summary>
    let licensee = _prefix "licensee"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lieutenancy"></see>
    /// </summary>
    let lieutenancy = _prefix "lieutenancy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lieutenancyArea"></see>
    /// </summary>
    let lieutenancyArea = _prefix "lieutenancyArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lieutenant"></see>
    /// </summary>
    let lieutenant = _prefix "lieutenant"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lifeExpectancy"></see>
    /// </summary>
    let lifeExpectancy = _prefix "lifeExpectancy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/limit"></see>
    /// </summary>
    let limit = _prefix "limit"
    /// <summary>
    /// Length of the line. Wikipedians usually do not differentiate between track length and line lenght.
    /// <see href="http://dbpedia.org/ontology/lineLength"></see></summary>
    let lineLength = _prefix "lineLength"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/linguisticsTradition"></see>
    /// </summary>
    let linguisticsTradition = _prefix "linguisticsTradition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/linkedSpace"></see>
    /// </summary>
    let linkedSpace = _prefix "linkedSpace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/linkedTo"></see>
    /// </summary>
    let linkedTo = _prefix "linkedTo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/listItemOf"></see>
    /// </summary>
    let listItemOf = _prefix "listItemOf"
    /// <summary>
    /// A literary genre is a category of literary composition. Genres may be determined by literary technique, tone, content, or even (as in the case of fiction) length.
    /// <see href="http://dbpedia.org/ontology/literaryGenre"></see></summary>
    let literaryGenre = _prefix "literaryGenre"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/littlePoolRecord"></see>
    /// </summary>
    let littlePoolRecord = _prefix "littlePoolRecord"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/livingPlace"></see>
    /// </summary>
    let livingPlace = _prefix "livingPlace"
    /// <summary>
    /// Load limit of the bridge.
    /// <see href="http://dbpedia.org/ontology/loadLimit"></see></summary>
    let loadLimit = _prefix "loadLimit"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/localAuthority"></see>
    /// </summary>
    let localAuthority = _prefix "localAuthority"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/localPhonePrefix"></see>
    /// </summary>
    let localPhonePrefix = _prefix "localPhonePrefix"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/locality"></see>
    /// </summary>
    let locality = _prefix "locality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/localization"></see>
    /// </summary>
    let localization = _prefix "localization"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/localizationThumbnail"></see>
    /// </summary>
    let localizationThumbnail = _prefix "localizationThumbnail"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/localizationThumbnailCaption"></see>
    /// </summary>
    let localizationThumbnailCaption = _prefix "localizationThumbnailCaption"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/locatedInArea"></see>
    /// </summary>
    let locatedInArea = _prefix "locatedInArea"
    /// <summary>
    /// The location of the thing.
    /// <see href="http://dbpedia.org/ontology/location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// City the thing is located.
    /// <see href="http://dbpedia.org/ontology/locationCity"></see></summary>
    let locationCity = _prefix "locationCity"
    /// <summary>
    /// Country the thing is located.
    /// <see href="http://dbpedia.org/ontology/locationCountry"></see></summary>
    let locationCountry = _prefix "locationCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/locationIdentifier"></see>
    /// </summary>
    let locationIdentifier = _prefix "locationIdentifier"
    /// <summary>
    /// Location of the thing as string. Use "location" if the location is a resource
    /// <see href="http://dbpedia.org/ontology/locationName"></see></summary>
    let locationName = _prefix "locationName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/locomotive"></see>
    /// </summary>
    let locomotive = _prefix "locomotive"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/locusSupplementaryData"></see>
    /// </summary>
    let locusSupplementaryData = _prefix "locusSupplementaryData"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/logo"></see>
    /// </summary>
    let logo = _prefix "logo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/longDistancePisteKilometre"></see>
    /// </summary>
    let longDistancePisteKilometre = _prefix "longDistancePisteKilometre"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/longDistancePisteNumber"></see>
    /// </summary>
    let longDistancePisteNumber = _prefix "longDistancePisteNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/longName"></see>
    /// </summary>
    let longName = _prefix "longName"
    /// <summary>
    /// can be used to include more informations e.g. the name of the artist that a tribute album is in honor of
    /// <see href="http://dbpedia.org/ontology/longtype"></see></summary>
    let longtype = _prefix "longtype"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lounge"></see>
    /// </summary>
    let lounge = _prefix "lounge"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowerAge"></see>
    /// </summary>
    let lowerAge = _prefix "lowerAge"
    /// <summary>
    /// Payload mass in a typical Low Earth orbit
    /// <see href="http://dbpedia.org/ontology/lowerEarthOrbitPayload"></see></summary>
    let lowerEarthOrbitPayload = _prefix "lowerEarthOrbitPayload"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowest"></see>
    /// </summary>
    let lowest = _prefix "lowest"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowestMountain"></see>
    /// </summary>
    let lowestMountain = _prefix "lowestMountain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowestPlace"></see>
    /// </summary>
    let lowestPlace = _prefix "lowestPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowestPoint"></see>
    /// </summary>
    let lowestPoint = _prefix "lowestPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowestPosition"></see>
    /// </summary>
    let lowestPosition = _prefix "lowestPosition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowestRegion"></see>
    /// </summary>
    let lowestRegion = _prefix "lowestRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowestState"></see>
    /// </summary>
    let lowestState = _prefix "lowestState"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarEvaTime"></see>
    /// </summary>
    let lunarEvaTime = _prefix "lunarEvaTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarLandingSite"></see>
    /// </summary>
    let lunarLandingSite = _prefix "lunarLandingSite"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarModule"></see>
    /// </summary>
    let lunarModule = _prefix "lunarModule"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarOrbitTime"></see>
    /// </summary>
    let lunarOrbitTime = _prefix "lunarOrbitTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarRover"></see>
    /// </summary>
    let lunarRover = _prefix "lunarRover"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarSampleMass"></see>
    /// </summary>
    let lunarSampleMass = _prefix "lunarSampleMass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarSurfaceTime"></see>
    /// </summary>
    let lunarSurfaceTime = _prefix "lunarSurfaceTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lymph"></see>
    /// </summary>
    let lymph = _prefix "lymph"
    /// <summary>
    /// Creator of the text of a MusicalWork, eg Musical, Opera or Song
    /// <see href="http://dbpedia.org/ontology/lyrics"></see></summary>
    let lyrics = _prefix "lyrics"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/magazine"></see>
    /// </summary>
    let magazine = _prefix "magazine"
    /// <summary>
    /// date of maiden flight
    /// <see href="http://dbpedia.org/ontology/maidenFlight"></see></summary>
    let maidenFlight = _prefix "maidenFlight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maidenFlightRocket"></see>
    /// </summary>
    let maidenFlightRocket = _prefix "maidenFlightRocket"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maidenVoyage"></see>
    /// </summary>
    let maidenVoyage = _prefix "maidenVoyage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainBuilding"></see>
    /// </summary>
    let mainBuilding = _prefix "mainBuilding"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainCharacter"></see>
    /// </summary>
    let mainCharacter = _prefix "mainCharacter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainDomain"></see>
    /// </summary>
    let mainDomain = _prefix "mainDomain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainFamilyBranch"></see>
    /// </summary>
    let mainFamilyBranch = _prefix "mainFamilyBranch"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainInterest"></see>
    /// </summary>
    let mainInterest = _prefix "mainInterest"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainIsland"></see>
    /// </summary>
    let mainIsland = _prefix "mainIsland"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainIslands"></see>
    /// </summary>
    let mainIslands = _prefix "mainIslands"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainOrgan"></see>
    /// </summary>
    let mainOrgan = _prefix "mainOrgan"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainspan"></see>
    /// </summary>
    let mainspan = _prefix "mainspan"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maintainedBy"></see>
    /// </summary>
    let maintainedBy = _prefix "maintainedBy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/majorIsland"></see>
    /// </summary>
    let majorIsland = _prefix "majorIsland"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/majorShrine"></see>
    /// </summary>
    let majorShrine = _prefix "majorShrine"
    /// <summary>
    /// number of office holder
    /// <see href="http://dbpedia.org/ontology/majorityFloorLeader"></see></summary>
    let majorityFloorLeader = _prefix "majorityFloorLeader"
    /// <summary>
    /// number of office holder
    /// <see href="http://dbpedia.org/ontology/majorityLeader"></see></summary>
    let majorityLeader = _prefix "majorityLeader"
    /// <summary>
    /// the person who is responsible for the actors makeup
    /// <see href="http://dbpedia.org/ontology/makeupArtist"></see></summary>
    let makeupArtist = _prefix "makeupArtist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/management"></see>
    /// </summary>
    let management = _prefix "management"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managementCountry"></see>
    /// </summary>
    let managementCountry = _prefix "managementCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managementElevation"></see>
    /// </summary>
    let managementElevation = _prefix "managementElevation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managementMountain"></see>
    /// </summary>
    let managementMountain = _prefix "managementMountain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managementPlace"></see>
    /// </summary>
    let managementPlace = _prefix "managementPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managementPosition"></see>
    /// </summary>
    let managementPosition = _prefix "managementPosition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managementRegion"></see>
    /// </summary>
    let managementRegion = _prefix "managementRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/manager"></see>
    /// </summary>
    let manager = _prefix "manager"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managerClub"></see>
    /// </summary>
    let managerClub = _prefix "managerClub"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managerSeason"></see>
    /// </summary>
    let managerSeason = _prefix "managerSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managerTitle"></see>
    /// </summary>
    let managerTitle = _prefix "managerTitle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managerYears"></see>
    /// </summary>
    let managerYears = _prefix "managerYears"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managerYearsEndYear"></see>
    /// </summary>
    let managerYearsEndYear = _prefix "managerYearsEndYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managerYearsStartYear"></see>
    /// </summary>
    let managerYearsStartYear = _prefix "managerYearsStartYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managingEditor"></see>
    /// </summary>
    let managingEditor = _prefix "managingEditor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mandate"></see>
    /// </summary>
    let mandate = _prefix "mandate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/manufacturer"></see>
    /// </summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    /// A map of the place.
    /// <see href="http://dbpedia.org/ontology/map"></see></summary>
    let map = _prefix "map"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mapCaption"></see>
    /// </summary>
    let mapCaption = _prefix "mapCaption"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mapDescription"></see>
    /// </summary>
    let mapDescription = _prefix "mapDescription"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/march"></see>
    /// </summary>
    let march = _prefix "march"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/marketCapitalisation"></see>
    /// </summary>
    let marketCapitalisation = _prefix "marketCapitalisation"
    /// <summary>
    /// something, especially a person or animal, used to symbolize a sports team, company, organization or other group.
    /// <see href="http://dbpedia.org/ontology/mascot"></see></summary>
    let mascot = _prefix "mascot"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mass"></see>
    /// </summary>
    let mass = _prefix "mass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/massif"></see>
    /// </summary>
    let massif = _prefix "massif"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mastersWins"></see>
    /// </summary>
    let mastersWins = _prefix "mastersWins"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/matchPoint"></see>
    /// </summary>
    let matchPoint = _prefix "matchPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/material"></see>
    /// </summary>
    let material = _prefix "material"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/max"></see>
    /// </summary>
    let max = _prefix "max"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maxAbsoluteMagnitude"></see>
    /// </summary>
    let maxAbsoluteMagnitude = _prefix "maxAbsoluteMagnitude"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maxApparentMagnitude"></see>
    /// </summary>
    let maxApparentMagnitude = _prefix "maxApparentMagnitude"
    /// <summary>
    /// Maximum preparation time of a recipe / Food
    /// <see href="http://dbpedia.org/ontology/maxTime"></see></summary>
    let maxTime = _prefix "maxTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumArea"></see>
    /// </summary>
    let maximumArea = _prefix "maximumArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumAreaQuote"></see>
    /// </summary>
    let maximumAreaQuote = _prefix "maximumAreaQuote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumBoatBeam"></see>
    /// </summary>
    let maximumBoatBeam = _prefix "maximumBoatBeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumBoatLength"></see>
    /// </summary>
    let maximumBoatLength = _prefix "maximumBoatLength"
    /// <summary>
    /// Source of the value can be declare by .
    /// <see href="http://dbpedia.org/ontology/maximumDepth"></see></summary>
    let maximumDepth = _prefix "maximumDepth"
    /// <summary>
    /// Source of the  value.
    /// <see href="http://dbpedia.org/ontology/maximumDepthQuote"></see></summary>
    let maximumDepthQuote = _prefix "maximumDepthQuote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumDischarge"></see>
    /// </summary>
    let maximumDischarge = _prefix "maximumDischarge"
    /// <summary>
    /// maximum elevation above the sea level
    /// <see href="http://dbpedia.org/ontology/maximumElevation"></see></summary>
    let maximumElevation = _prefix "maximumElevation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumInclination"></see>
    /// </summary>
    let maximumInclination = _prefix "maximumInclination"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumTemperature"></see>
    /// </summary>
    let maximumTemperature = _prefix "maximumTemperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mayor"></see>
    /// </summary>
    let mayor = _prefix "mayor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mayorArticle"></see>
    /// </summary>
    let mayorArticle = _prefix "mayorArticle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mayorCouncillor"></see>
    /// </summary>
    let mayorCouncillor = _prefix "mayorCouncillor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mayorFunction"></see>
    /// </summary>
    let mayorFunction = _prefix "mayorFunction"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SwitzerlandSettlement"></see>
    /// </summary>
    let SwitzerlandSettlement = _prefix "SwitzerlandSettlement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mayorMandate"></see>
    /// </summary>
    let mayorMandate = _prefix "mayorMandate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mayorTitle"></see>
    /// </summary>
    let mayorTitle = _prefix "mayorTitle"
    /// <summary>
    /// MusicBrainz is an open music encyclopedia that collects music metadata and makes it available to the public.
    /// <see href="http://dbpedia.org/ontology/mbaId"></see></summary>
    let mbaId = _prefix "mbaId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meanRadius"></see>
    /// </summary>
    let meanRadius = _prefix "meanRadius"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meanTemperature"></see>
    /// </summary>
    let meanTemperature = _prefix "meanTemperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meaning"></see>
    /// </summary>
    let meaning = _prefix "meaning"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/measurements"></see>
    /// </summary>
    let measurements = _prefix "measurements"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/medalist"></see>
    /// </summary>
    let medalist = _prefix "medalist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/media"></see>
    /// </summary>
    let media = _prefix "media"
    /// <summary>
    /// Print / On-line (then binding types etc. if relevant)
    /// <see href="http://dbpedia.org/ontology/mediaType"></see></summary>
    let mediaType = _prefix "mediaType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/medlinePlus"></see>
    /// </summary>
    let medlinePlus = _prefix "medlinePlus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meetingBuilding"></see>
    /// </summary>
    let meetingBuilding = _prefix "meetingBuilding"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meetingCity"></see>
    /// </summary>
    let meetingCity = _prefix "meetingCity"
    /// <summary>
    /// A road that crosses another road at the junction.
    /// <see href="http://dbpedia.org/ontology/meetingRoad"></see></summary>
    let meetingRoad = _prefix "meetingRoad"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meltingPoint"></see>
    /// </summary>
    let meltingPoint = _prefix "meltingPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/member"></see>
    /// </summary>
    let member_ = _prefix "member"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/memberOfParliament"></see>
    /// </summary>
    let memberOfParliament = _prefix "memberOfParliament"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/membership"></see>
    /// </summary>
    let membership = _prefix "membership"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/membershipAsOf"></see>
    /// </summary>
    let membershipAsOf = _prefix "membershipAsOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Organisation,_Parish"></see>
    /// </summary>
    let ``Organisation,_Parish`` = _prefix "Organisation,_Parish"
    /// <summary>
    /// A wise and trusted counselor or teacher
    /// <see href="http://dbpedia.org/ontology/mentor"></see></summary>
    let mentor = _prefix "mentor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mergedIntoParty"></see>
    /// </summary>
    let mergedIntoParty = _prefix "mergedIntoParty"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mergedSettlement"></see>
    /// </summary>
    let mergedSettlement = _prefix "mergedSettlement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mergerDate"></see>
    /// </summary>
    let mergerDate = _prefix "mergerDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meshId"></see>
    /// </summary>
    let meshId = _prefix "meshId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meshName"></see>
    /// </summary>
    let meshName = _prefix "meshName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meshNumber"></see>
    /// </summary>
    let meshNumber = _prefix "meshNumber"
    /// <summary>
    /// Name for Messier objects
    /// <see href="http://dbpedia.org/ontology/messierName"></see></summary>
    let messierName = _prefix "messierName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/metropolitanBorough"></see>
    /// </summary>
    let metropolitanBorough = _prefix "metropolitanBorough"
    /// <summary>
    /// Mouse Genomic Informatics ID
    /// <see href="http://dbpedia.org/ontology/mgiid"></see></summary>
    let mgiid = _prefix "mgiid"
    /// <summary>
    /// The service branch (Army, Navy, etc.) a person is part of.
    /// <see href="http://dbpedia.org/ontology/militaryBranch"></see></summary>
    let militaryBranch = _prefix "militaryBranch"
    /// <summary>
    /// For persons who are notable as commanding officers, the units they commanded. Dates should be given if multiple notable commands were held.
    /// <see href="http://dbpedia.org/ontology/militaryCommand"></see></summary>
    let militaryCommand = _prefix "militaryCommand"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/militaryFunction"></see>
    /// </summary>
    let militaryFunction = _prefix "militaryFunction"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/militaryGovernment"></see>
    /// </summary>
    let militaryGovernment = _prefix "militaryGovernment"
    /// <summary>
    /// The highest rank achieved by a person.
    /// <see href="http://dbpedia.org/ontology/militaryRank"></see></summary>
    let militaryRank = _prefix "militaryRank"
    /// <summary>
    /// For persons who are not notable as commanding officers, the unit (company, battalion, regiment, etc.) in which they served.
    /// <see href="http://dbpedia.org/ontology/militaryUnit"></see></summary>
    let militaryUnit = _prefix "militaryUnit"
    /// <summary>
    /// the size of the military unit
    /// <see href="http://dbpedia.org/ontology/militaryUnitSize"></see></summary>
    let militaryUnitSize = _prefix "militaryUnitSize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/millSpan"></see>
    /// </summary>
    let millSpan = _prefix "millSpan"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/millType"></see>
    /// </summary>
    let millType = _prefix "millType"
    /// <summary>
    /// mills code from the Belgian database on mills
    /// <see href="http://dbpedia.org/ontology/millsCodeBE"></see></summary>
    let millsCodeBE = _prefix "millsCodeBE"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/millsCodeDutch"></see>
    /// </summary>
    let millsCodeDutch = _prefix "millsCodeDutch"
    /// <summary>
    /// mills code from the central Dutch database on mills
    /// <see href="http://dbpedia.org/ontology/millsCodeNL"></see></summary>
    let millsCodeNL = _prefix "millsCodeNL"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/millsCodeNLVerdwenen"></see>
    /// </summary>
    let millsCodeNLVerdwenen = _prefix "millsCodeNLVerdwenen"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/millsCodeNLWindmotoren"></see>
    /// </summary>
    let millsCodeNLWindmotoren = _prefix "millsCodeNLWindmotoren"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/min"></see>
    /// </summary>
    let min = _prefix "min"
    /// <summary>
    /// Minimum preparation time of a recipe / Food
    /// <see href="http://dbpedia.org/ontology/minTime"></see></summary>
    let minTime = _prefix "minTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/minimumArea"></see>
    /// </summary>
    let minimumArea = _prefix "minimumArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/minimumAreaQuote"></see>
    /// </summary>
    let minimumAreaQuote = _prefix "minimumAreaQuote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/minimumDischarge"></see>
    /// </summary>
    let minimumDischarge = _prefix "minimumDischarge"
    /// <summary>
    /// minimum elevation above the sea level
    /// <see href="http://dbpedia.org/ontology/minimumElevation"></see></summary>
    let minimumElevation = _prefix "minimumElevation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/minimumInclination"></see>
    /// </summary>
    let minimumInclination = _prefix "minimumInclination"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/minimumTemperature"></see>
    /// </summary>
    let minimumTemperature = _prefix "minimumTemperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/minority"></see>
    /// </summary>
    let minority = _prefix "minority"
    /// <summary>
    /// number of office holder
    /// <see href="http://dbpedia.org/ontology/minorityFloorLeader"></see></summary>
    let minorityFloorLeader = _prefix "minorityFloorLeader"
    /// <summary>
    /// number of office holder
    /// <see href="http://dbpedia.org/ontology/minorityLeader"></see></summary>
    let minorityLeader = _prefix "minorityLeader"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mirDockings"></see>
    /// </summary>
    let mirDockings = _prefix "mirDockings"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mission"></see>
    /// </summary>
    let mission = _prefix "mission"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/missionDuration"></see>
    /// </summary>
    let missionDuration = _prefix "missionDuration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/missions"></see>
    /// </summary>
    let missions = _prefix "missions"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/model"></see>
    /// </summary>
    let model = _prefix "model"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/modelEndDate"></see>
    /// </summary>
    let modelEndDate = _prefix "modelEndDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/modelEndYear"></see>
    /// </summary>
    let modelEndYear = _prefix "modelEndYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/modelLineVehicle"></see>
    /// </summary>
    let modelLineVehicle = _prefix "modelLineVehicle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/modelStartDate"></see>
    /// </summary>
    let modelStartDate = _prefix "modelStartDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/modelStartYear"></see>
    /// </summary>
    let modelStartYear = _prefix "modelStartYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/molecularWeight"></see>
    /// </summary>
    let molecularWeight = _prefix "molecularWeight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/monarch"></see>
    /// </summary>
    let monarch = _prefix "monarch"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/month"></see>
    /// </summary>
    let month = _prefix "month"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mood"></see>
    /// </summary>
    let mood = _prefix "mood"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mostDownPoint"></see>
    /// </summary>
    let mostDownPoint = _prefix "mostDownPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mostWins"></see>
    /// </summary>
    let mostWins = _prefix "mostWins"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mother"></see>
    /// </summary>
    let mother = _prefix "mother"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/motto"></see>
    /// </summary>
    let motto = _prefix "motto"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mount"></see>
    /// </summary>
    let mount = _prefix "mount"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mountainRange"></see>
    /// </summary>
    let mountainRange = _prefix "mountainRange"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthCountry"></see>
    /// </summary>
    let mouthCountry = _prefix "mouthCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthDistrict"></see>
    /// </summary>
    let mouthDistrict = _prefix "mouthDistrict"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthElevation"></see>
    /// </summary>
    let mouthElevation = _prefix "mouthElevation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthMountain"></see>
    /// </summary>
    let mouthMountain = _prefix "mouthMountain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthPlace"></see>
    /// </summary>
    let mouthPlace = _prefix "mouthPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthPosition"></see>
    /// </summary>
    let mouthPosition = _prefix "mouthPosition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthRegion"></see>
    /// </summary>
    let mouthRegion = _prefix "mouthRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthState"></see>
    /// </summary>
    let mouthState = _prefix "mouthState"
    /// <summary>
    /// artistic movement or school with which artist is associated
    /// <see href="http://dbpedia.org/ontology/movement"></see></summary>
    let movement = _prefix "movement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/movie"></see>
    /// </summary>
    let movie = _prefix "movie"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mukhtar"></see>
    /// </summary>
    let mukhtar = _prefix "mukhtar"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LebanonSettlement"></see>
    /// </summary>
    let LebanonSettlement = _prefix "LebanonSettlement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/municipality"></see>
    /// </summary>
    let municipality = _prefix "municipality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/municipalityAbsorbedBy"></see>
    /// </summary>
    let municipalityAbsorbedBy = _prefix "municipalityAbsorbedBy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/municipalityCode"></see>
    /// </summary>
    let municipalityCode = _prefix "municipalityCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/municipalityRenamedTo"></see>
    /// </summary>
    let municipalityRenamedTo = _prefix "municipalityRenamedTo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/municipalityType"></see>
    /// </summary>
    let municipalityType = _prefix "municipalityType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/museum"></see>
    /// </summary>
    let museum = _prefix "museum"
    /// <summary>
    /// This property has been added  because 'buildingType' is much more about the place, whereas 'museumType' is about the way the place is being (or:was) used
    /// <see href="http://dbpedia.org/ontology/museumType"></see></summary>
    let museumType = _prefix "museumType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicBand"></see>
    /// </summary>
    let musicBand = _prefix "musicBand"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicBy"></see>
    /// </summary>
    let musicBy = _prefix "musicBy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicComposer"></see>
    /// </summary>
    let musicComposer = _prefix "musicComposer"
    /// <summary>
    /// The format of the album: EP, Single etc.
    /// <see href="http://dbpedia.org/ontology/musicFormat"></see></summary>
    let musicFormat = _prefix "musicFormat"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicFusionGenre"></see>
    /// </summary>
    let musicFusionGenre = _prefix "musicFusionGenre"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicSubgenre"></see>
    /// </summary>
    let musicSubgenre = _prefix "musicSubgenre"
    /// <summary>
    /// Type is too general. We should be able to distinguish types of music from types of architecture
    /// <see href="http://dbpedia.org/ontology/musicType"></see></summary>
    let musicType = _prefix "musicType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicalArtist"></see>
    /// </summary>
    let musicalArtist = _prefix "musicalArtist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicalBand"></see>
    /// </summary>
    let musicalBand = _prefix "musicalBand"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicalKey"></see>
    /// </summary>
    let musicalKey = _prefix "musicalKey"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicians"></see>
    /// </summary>
    let musicians = _prefix "musicians"
    /// <summary>
    /// Name of a mute character in play.
    /// <see href="http://dbpedia.org/ontology/muteCharacterInPlay"></see></summary>
    let muteCharacterInPlay = _prefix "muteCharacterInPlay"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mvp"></see>
    /// </summary>
    let mvp = _prefix "mvp"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mythology"></see>
    /// </summary>
    let mythology = _prefix "mythology"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/naacpImageAward"></see>
    /// </summary>
    let naacpImageAward = _prefix "naacpImageAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nameAsOf"></see>
    /// </summary>
    let nameAsOf = _prefix "nameAsOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nameDay"></see>
    /// </summary>
    let nameDay = _prefix "nameDay"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/namedAfter"></see>
    /// </summary>
    let namedAfter = _prefix "namedAfter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/namedByLanguage"></see>
    /// </summary>
    let namedByLanguage = _prefix "namedByLanguage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/names"></see>
    /// </summary>
    let names = _prefix "names"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/narrator"></see>
    /// </summary>
    let narrator = _prefix "narrator"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nation"></see>
    /// </summary>
    let nation = _prefix "nation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalAffiliation"></see>
    /// </summary>
    let nationalAffiliation = _prefix "nationalAffiliation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalChampionship"></see>
    /// </summary>
    let nationalChampionship = _prefix "nationalChampionship"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalFilmAward"></see>
    /// </summary>
    let nationalFilmAward = _prefix "nationalFilmAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalOlympicCommittee"></see>
    /// </summary>
    let nationalOlympicCommittee = _prefix "nationalOlympicCommittee"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalRanking"></see>
    /// </summary>
    let nationalRanking = _prefix "nationalRanking"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalSelection"></see>
    /// </summary>
    let nationalSelection = _prefix "nationalSelection"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTeam"></see>
    /// </summary>
    let nationalTeam = _prefix "nationalTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTeamMatchPoint"></see>
    /// </summary>
    let nationalTeamMatchPoint = _prefix "nationalTeamMatchPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTeamYear"></see>
    /// </summary>
    let nationalTeamYear = _prefix "nationalTeamYear"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTopographicSystemMapNumber"></see>
    /// </summary>
    let nationalTopographicSystemMapNumber =
        _prefix "nationalTopographicSystemMapNumber"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTournament"></see>
    /// </summary>
    let nationalTournament = _prefix "nationalTournament"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTournamentBronze"></see>
    /// </summary>
    let nationalTournamentBronze = _prefix "nationalTournamentBronze"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTournamentGold"></see>
    /// </summary>
    let nationalTournamentGold = _prefix "nationalTournamentGold"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTournamentSilver"></see>
    /// </summary>
    let nationalTournamentSilver = _prefix "nationalTournamentSilver"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalYears"></see>
    /// </summary>
    let nationalYears = _prefix "nationalYears"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationality"></see>
    /// </summary>
    let nationality = _prefix "nationality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ncaaSeason"></see>
    /// </summary>
    let ncaaSeason = _prefix "ncaaSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ncaaTeam"></see>
    /// </summary>
    let ncaaTeam = _prefix "ncaaTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ncbhof"></see>
    /// </summary>
    let ncbhof = _prefix "ncbhof"
    /// <summary>
    /// National Diet Library of Japan identificator. http://id.ndl.go.jp/auth/ndlna/$1
    /// <see href="http://dbpedia.org/ontology/ndlId"></see></summary>
    let ndlId = _prefix "ndlId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nearestCity"></see>
    /// </summary>
    let nearestCity = _prefix "nearestCity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/neighboringMunicipality"></see>
    /// </summary>
    let neighboringMunicipality = _prefix "neighboringMunicipality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/neighbourConstellations"></see>
    /// </summary>
    let neighbourConstellations = _prefix "neighbourConstellations"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/neighbourRegion"></see>
    /// </summary>
    let neighbourRegion = _prefix "neighbourRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/neighbourhood"></see>
    /// </summary>
    let neighbourhood = _prefix "neighbourhood"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nerve"></see>
    /// </summary>
    let nerve = _prefix "nerve"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/netIncome"></see>
    /// </summary>
    let netIncome = _prefix "netIncome"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/network"></see>
    /// </summary>
    let network = _prefix "network"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/networth"></see>
    /// </summary>
    let networth = _prefix "networth"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/newspaper"></see>
    /// </summary>
    let newspaper = _prefix "newspaper"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nextEntity"></see>
    /// </summary>
    let nextEntity = _prefix "nextEntity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nextEvent"></see>
    /// </summary>
    let nextEvent = _prefix "nextEvent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nextMission"></see>
    /// </summary>
    let nextMission = _prefix "nextMission"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nflCode"></see>
    /// </summary>
    let nflCode = _prefix "nflCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nflSeason"></see>
    /// </summary>
    let nflSeason = _prefix "nflSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nflTeam"></see>
    /// </summary>
    let nflTeam = _prefix "nflTeam"
    /// <summary>
    /// Name for NGC objects
    /// <see href="http://dbpedia.org/ontology/ngcName"></see></summary>
    let ngcName = _prefix "ngcName"
    /// <summary>
    /// Indexing code used by the Belgium National Statistical Institute to identify populated places.
    /// <see href="http://dbpedia.org/ontology/nisCode"></see></summary>
    let nisCode = _prefix "nisCode"
    /// <summary>
    /// NLA Trove’s People and Organisation view allows the discovery of biographical and other contextual information about people and organisations. Search also available via VIAF.
    /// <see href="http://dbpedia.org/ontology/nlaId"></see></summary>
    let nlaId = _prefix "nlaId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nndbId"></see>
    /// </summary>
    let nndbId = _prefix "nndbId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/noContest"></see>
    /// </summary>
    let noContest = _prefix "noContest"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nobelLaureates"></see>
    /// </summary>
    let nobelLaureates = _prefix "nobelLaureates"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nominee"></see>
    /// </summary>
    let nominee = _prefix "nominee"
    /// <summary>
    /// The subject of a non-fiction book (e.g.: History, Biography, Cookbook, Climate change, ...).
    /// <see href="http://dbpedia.org/ontology/nonFictionSubject"></see></summary>
    let nonFictionSubject = _prefix "nonFictionSubject"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nonProfessionalCareer"></see>
    /// </summary>
    let nonProfessionalCareer = _prefix "nonProfessionalCareer"
    /// <summary>
    /// indicates another place situated north-east.
    /// <see href="http://dbpedia.org/ontology/northEastPlace"></see></summary>
    let northEastPlace = _prefix "northEastPlace"
    /// <summary>
    /// indicates another place situated north.
    /// <see href="http://dbpedia.org/ontology/northPlace"></see></summary>
    let northPlace = _prefix "northPlace"
    /// <summary>
    /// indicates another place situated north-west.
    /// <see href="http://dbpedia.org/ontology/northWestPlace"></see></summary>
    let northWestPlace = _prefix "northWestPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notSolubleIn"></see>
    /// </summary>
    let notSolubleIn = _prefix "notSolubleIn"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notableCommander"></see>
    /// </summary>
    let notableCommander = _prefix "notableCommander"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notableFeatures"></see>
    /// </summary>
    let notableFeatures = _prefix "notableFeatures"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notableIdea"></see>
    /// </summary>
    let notableIdea = _prefix "notableIdea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notableStudent"></see>
    /// </summary>
    let notableStudent = _prefix "notableStudent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notableWine"></see>
    /// </summary>
    let notableWine = _prefix "notableWine"
    /// <summary>
    /// Notable work of a person (eg Artist, Engineer, etc)
    /// <see href="http://dbpedia.org/ontology/notableWork"></see></summary>
    let notableWork = _prefix "notableWork"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/note"></see>
    /// </summary>
    let note = _prefix "note"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/noteOnPlaceOfBurial"></see>
    /// </summary>
    let noteOnPlaceOfBurial = _prefix "noteOnPlaceOfBurial"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/noteOnRestingPlace"></see>
    /// </summary>
    let noteOnRestingPlace = _prefix "noteOnRestingPlace"
    /// <summary>
    /// additional notes that better describe the entity.
    /// <see href="http://dbpedia.org/ontology/notes"></see></summary>
    let notes = _prefix "notes"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notifyDate"></see>
    /// </summary>
    let notifyDate = _prefix "notifyDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/novel"></see>
    /// </summary>
    let novel = _prefix "novel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nrhpReferenceNumber"></see>
    /// </summary>
    let nrhpReferenceNumber = _prefix "nrhpReferenceNumber"
    /// <summary>
    /// Type of historic place as defined by the US National Park Service. For instance National Historic Landmark, National Monument or National Battlefield.
    /// <see href="http://dbpedia.org/ontology/nrhpType"></see></summary>
    let nrhpType = _prefix "nrhpType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nssdcId"></see>
    /// </summary>
    let nssdcId = _prefix "nssdcId"
    /// <summary>
    /// Jersey number of an Athlete (sports player, eg "99") or sequential number of an Album (eg "Third studio album")
    /// <see href="http://dbpedia.org/ontology/number"></see></summary>
    let number = _prefix "number"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberBuilt"></see>
    /// </summary>
    let numberBuilt = _prefix "numberBuilt"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfAcademicStaff"></see>
    /// </summary>
    let numberOfAcademicStaff = _prefix "numberOfAcademicStaff"
    /// <summary>
    /// the total number of albums released by the musical artist
    /// <see href="http://dbpedia.org/ontology/numberOfAlbums"></see></summary>
    let numberOfAlbums = _prefix "numberOfAlbums"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfArrondissement"></see>
    /// </summary>
    let numberOfArrondissement = _prefix "numberOfArrondissement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfBombs"></see>
    /// </summary>
    let numberOfBombs = _prefix "numberOfBombs"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfBronzeMedalsWon"></see>
    /// </summary>
    let numberOfBronzeMedalsWon = _prefix "numberOfBronzeMedalsWon"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCanton"></see>
    /// </summary>
    let numberOfCanton = _prefix "numberOfCanton"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCantons"></see>
    /// </summary>
    let numberOfCantons = _prefix "numberOfCantons"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCapitalDeputies"></see>
    /// </summary>
    let numberOfCapitalDeputies = _prefix "numberOfCapitalDeputies"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCity"></see>
    /// </summary>
    let numberOfCity = _prefix "numberOfCity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfClassrooms"></see>
    /// </summary>
    let numberOfClassrooms = _prefix "numberOfClassrooms"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfClubs"></see>
    /// </summary>
    let numberOfClubs = _prefix "numberOfClubs"
    /// <summary>
    /// Indication as to the size of the collection of this library
    /// <see href="http://dbpedia.org/ontology/numberOfCollectionItems"></see></summary>
    let numberOfCollectionItems = _prefix "numberOfCollectionItems"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCompetitors"></see>
    /// </summary>
    let numberOfCompetitors = _prefix "numberOfCompetitors"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCounties"></see>
    /// </summary>
    let numberOfCounties = _prefix "numberOfCounties"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCountries"></see>
    /// </summary>
    let numberOfCountries = _prefix "numberOfCountries"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCrew"></see>
    /// </summary>
    let numberOfCrew = _prefix "numberOfCrew"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfDeaths"></see>
    /// </summary>
    let numberOfDeaths = _prefix "numberOfDeaths"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfDependency"></see>
    /// </summary>
    let numberOfDependency = _prefix "numberOfDependency"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfDistrict"></see>
    /// </summary>
    let numberOfDistrict = _prefix "numberOfDistrict"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfDistricts"></see>
    /// </summary>
    let numberOfDistricts = _prefix "numberOfDistricts"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfDoctoralStudents"></see>
    /// </summary>
    let numberOfDoctoralStudents = _prefix "numberOfDoctoralStudents"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfEmployees"></see>
    /// </summary>
    let numberOfEmployees = _prefix "numberOfEmployees"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfEntrances"></see>
    /// </summary>
    let numberOfEntrances = _prefix "numberOfEntrances"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfEpisodes"></see>
    /// </summary>
    let numberOfEpisodes = _prefix "numberOfEpisodes"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfFederalDeputies"></see>
    /// </summary>
    let numberOfFederalDeputies = _prefix "numberOfFederalDeputies"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfFilms"></see>
    /// </summary>
    let numberOfFilms = _prefix "numberOfFilms"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfGoals"></see>
    /// </summary>
    let numberOfGoals = _prefix "numberOfGoals"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfGoldMedalsWon"></see>
    /// </summary>
    let numberOfGoldMedalsWon = _prefix "numberOfGoldMedalsWon"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfGraduateStudents"></see>
    /// </summary>
    let numberOfGraduateStudents = _prefix "numberOfGraduateStudents"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfGraves"></see>
    /// </summary>
    let numberOfGraves = _prefix "numberOfGraves"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfHoles"></see>
    /// </summary>
    let numberOfHoles = _prefix "numberOfHoles"
    /// <summary>
    /// Count of the houses in the Protected Area
    /// <see href="http://dbpedia.org/ontology/numberOfHouses"></see></summary>
    let numberOfHouses = _prefix "numberOfHouses"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfIntercommunality"></see>
    /// </summary>
    let numberOfIntercommunality = _prefix "numberOfIntercommunality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfIsland"></see>
    /// </summary>
    let numberOfIsland = _prefix "numberOfIsland"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfIslands"></see>
    /// </summary>
    let numberOfIslands = _prefix "numberOfIslands"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfLanes"></see>
    /// </summary>
    let numberOfLanes = _prefix "numberOfLanes"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfLaps"></see>
    /// </summary>
    let numberOfLaps = _prefix "numberOfLaps"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfLaunches"></see>
    /// </summary>
    let numberOfLaunches = _prefix "numberOfLaunches"
    /// <summary>
    /// Number of lawyers or attorneys in the company.
    /// <see href="http://dbpedia.org/ontology/numberOfLawyers"></see></summary>
    let numberOfLawyers = _prefix "numberOfLawyers"
    /// <summary>
    /// Number of lines in the transit system.
    /// <see href="http://dbpedia.org/ontology/numberOfLines"></see></summary>
    let numberOfLines = _prefix "numberOfLines"
    /// <summary>
    /// the number of live albums released by the musical artist
    /// <see href="http://dbpedia.org/ontology/numberOfLiveAlbums"></see></summary>
    let numberOfLiveAlbums = _prefix "numberOfLiveAlbums"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfLocations"></see>
    /// </summary>
    let numberOfLocations = _prefix "numberOfLocations"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfMatches"></see>
    /// </summary>
    let numberOfMatches = _prefix "numberOfMatches"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfMembers"></see>
    /// </summary>
    let numberOfMembers = _prefix "numberOfMembers"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfMembersAsOf"></see>
    /// </summary>
    let numberOfMembersAsOf = _prefix "numberOfMembersAsOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfMinistries"></see>
    /// </summary>
    let numberOfMinistries = _prefix "numberOfMinistries"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfMunicipalities"></see>
    /// </summary>
    let numberOfMunicipalities = _prefix "numberOfMunicipalities"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfNeighbourhood"></see>
    /// </summary>
    let numberOfNeighbourhood = _prefix "numberOfNeighbourhood"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfNewlyIntroducedSports"></see>
    /// </summary>
    let numberOfNewlyIntroducedSports = _prefix "numberOfNewlyIntroducedSports"
    /// <summary>
    /// Number of the company's offices.
    /// <see href="http://dbpedia.org/ontology/numberOfOffices"></see></summary>
    let numberOfOffices = _prefix "numberOfOffices"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfOfficials"></see>
    /// </summary>
    let numberOfOfficials = _prefix "numberOfOfficials"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfOrbits"></see>
    /// </summary>
    let numberOfOrbits = _prefix "numberOfOrbits"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfPads"></see>
    /// </summary>
    let numberOfPads = _prefix "numberOfPads"
    /// <summary>
    /// The books number of pages.
    /// <see href="http://dbpedia.org/ontology/numberOfPages"></see></summary>
    let numberOfPages = _prefix "numberOfPages"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfParkingSpaces"></see>
    /// </summary>
    let numberOfParkingSpaces = _prefix "numberOfParkingSpaces"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfParticipatingAthletes"></see>
    /// </summary>
    let numberOfParticipatingAthletes = _prefix "numberOfParticipatingAthletes"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfParticipatingFemaleAthletes"></see>
    /// </summary>
    let numberOfParticipatingFemaleAthletes =
        _prefix "numberOfParticipatingFemaleAthletes"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfParticipatingMaleAthletes"></see>
    /// </summary>
    let numberOfParticipatingMaleAthletes = _prefix "numberOfParticipatingMaleAthletes"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfParticipatingNations"></see>
    /// </summary>
    let numberOfParticipatingNations = _prefix "numberOfParticipatingNations"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfPeopleAttending"></see>
    /// </summary>
    let numberOfPeopleAttending = _prefix "numberOfPeopleAttending"
    /// <summary>
    /// nombre de personnes ayant une license pour pratiquer cette activité
    /// <see href="http://dbpedia.org/ontology/numberOfPeopleLicensed"></see></summary>
    let numberOfPeopleLicensed = _prefix "numberOfPeopleLicensed"
    /// <summary>
    /// Number of piers standing in a river or other water in normal conditions.
    /// <see href="http://dbpedia.org/ontology/numberOfPiersInWater"></see></summary>
    let numberOfPiersInWater = _prefix "numberOfPiersInWater"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfPixels"></see>
    /// </summary>
    let numberOfPixels = _prefix "numberOfPixels"
    /// <summary>
    /// Number of levels of platforms at the station.
    /// <see href="http://dbpedia.org/ontology/numberOfPlatformLevels"></see></summary>
    let numberOfPlatformLevels = _prefix "numberOfPlatformLevels"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfPlayers"></see>
    /// </summary>
    let numberOfPlayers = _prefix "numberOfPlayers"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfPostgraduateStudents"></see>
    /// </summary>
    let numberOfPostgraduateStudents = _prefix "numberOfPostgraduateStudents"
    /// <summary>
    /// number of people who earns his living from a specified activity.
    /// <see href="http://dbpedia.org/ontology/numberOfProfessionals"></see></summary>
    let numberOfProfessionals = _prefix "numberOfProfessionals"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfReactors"></see>
    /// </summary>
    let numberOfReactors = _prefix "numberOfReactors"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfRestaurants"></see>
    /// </summary>
    let numberOfRestaurants = _prefix "numberOfRestaurants"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfRockets"></see>
    /// </summary>
    let numberOfRockets = _prefix "numberOfRockets"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfRooms"></see>
    /// </summary>
    let numberOfRooms = _prefix "numberOfRooms"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfRun"></see>
    /// </summary>
    let numberOfRun = _prefix "numberOfRun"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSeasons"></see>
    /// </summary>
    let numberOfSeasons = _prefix "numberOfSeasons"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSeats"></see>
    /// </summary>
    let numberOfSeats = _prefix "numberOfSeats"
    /// <summary>
    /// number of seats in House of Commons-like parliaments
    /// <see href="http://dbpedia.org/ontology/numberOfSeatsInParliament"></see></summary>
    let numberOfSeatsInParliament = _prefix "numberOfSeatsInParliament"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSettlement"></see>
    /// </summary>
    let numberOfSettlement = _prefix "numberOfSettlement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSilverMedalsWon"></see>
    /// </summary>
    let numberOfSilverMedalsWon = _prefix "numberOfSilverMedalsWon"
    /// <summary>
    /// Number of spans or arches.
    /// <see href="http://dbpedia.org/ontology/numberOfSpans"></see></summary>
    let numberOfSpans = _prefix "numberOfSpans"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSpeakers"></see>
    /// </summary>
    let numberOfSpeakers = _prefix "numberOfSpeakers"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSports"></see>
    /// </summary>
    let numberOfSports = _prefix "numberOfSports"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSportsEvents"></see>
    /// </summary>
    let numberOfSportsEvents = _prefix "numberOfSportsEvents"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfStaff"></see>
    /// </summary>
    let numberOfStaff = _prefix "numberOfStaff"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfStars"></see>
    /// </summary>
    let numberOfStars = _prefix "numberOfStars"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfStateDeputies"></see>
    /// </summary>
    let numberOfStateDeputies = _prefix "numberOfStateDeputies"
    /// <summary>
    /// Number of stations or stops.
    /// <see href="http://dbpedia.org/ontology/numberOfStations"></see></summary>
    let numberOfStations = _prefix "numberOfStations"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfStudents"></see>
    /// </summary>
    let numberOfStudents = _prefix "numberOfStudents"
    /// <summary>
    /// the number of studio albums released by the musical artist
    /// <see href="http://dbpedia.org/ontology/numberOfStudioAlbums"></see></summary>
    let numberOfStudioAlbums = _prefix "numberOfStudioAlbums"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSuites"></see>
    /// </summary>
    let numberOfSuites = _prefix "numberOfSuites"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfTeams"></see>
    /// </summary>
    let numberOfTeams = _prefix "numberOfTeams"
    /// <summary>
    /// Number of tracks of a railway or railway station.
    /// <see href="http://dbpedia.org/ontology/numberOfTracks"></see></summary>
    let numberOfTracks = _prefix "numberOfTracks"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfTurns"></see>
    /// </summary>
    let numberOfTurns = _prefix "numberOfTurns"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfUndergraduateStudents"></see>
    /// </summary>
    let numberOfUndergraduateStudents = _prefix "numberOfUndergraduateStudents"
    /// <summary>
    /// Number of vehicles used in the transit system.
    /// <see href="http://dbpedia.org/ontology/numberOfVehicles"></see></summary>
    let numberOfVehicles = _prefix "numberOfVehicles"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfVillages"></see>
    /// </summary>
    let numberOfVillages = _prefix "numberOfVillages"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfVineyards"></see>
    /// </summary>
    let numberOfVineyards = _prefix "numberOfVineyards"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfVisitors"></see>
    /// </summary>
    let numberOfVisitors = _prefix "numberOfVisitors"
    /// <summary>
    /// The year in which number of visitors occurred.
    /// <see href="http://dbpedia.org/ontology/numberOfVisitorsAsOf"></see></summary>
    let numberOfVisitorsAsOf = _prefix "numberOfVisitorsAsOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfVolumes"></see>
    /// </summary>
    let numberOfVolumes = _prefix "numberOfVolumes"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfVolunteers"></see>
    /// </summary>
    let numberOfVolunteers = _prefix "numberOfVolunteers"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfWineries"></see>
    /// </summary>
    let numberOfWineries = _prefix "numberOfWineries"
    /// <summary>
    /// Number of things (eg vehicles) sold
    /// <see href="http://dbpedia.org/ontology/numberSold"></see></summary>
    let numberSold = _prefix "numberSold"
    /// <summary>
    /// Nomenclature of Territorial Units for Statistics (NUTS) is a geocode  standard for referencing the subdivisions of countries  for statistical purposes. The standard is developed and regulated by the European Union, and thus only covers the member states of the EU in detail.
    /// <see href="http://dbpedia.org/ontology/nutsCode"></see></summary>
    let nutsCode = _prefix "nutsCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/observatory"></see>
    /// </summary>
    let observatory = _prefix "observatory"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/occupation"></see>
    /// </summary>
    let occupation = _prefix "occupation"
    /// <summary>
    /// Online Computer Library Center number
    /// <see href="http://dbpedia.org/ontology/oclc"></see></summary>
    let oclc = _prefix "oclc"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/offeredClasses"></see>
    /// </summary>
    let offeredClasses = _prefix "offeredClasses"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/office"></see>
    /// </summary>
    let office = _prefix "office"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/officerInCharge"></see>
    /// </summary>
    let officerInCharge = _prefix "officerInCharge"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/officialLanguage"></see>
    /// </summary>
    let officialLanguage = _prefix "officialLanguage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/officialName"></see>
    /// </summary>
    let officialName = _prefix "officialName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/officialOpenedBy"></see>
    /// </summary>
    let officialOpenedBy = _prefix "officialOpenedBy"
    /// <summary>
    /// The official colour of the EducationalInstitution represented by the colour name (e.g.: red or green).
    /// <see href="http://dbpedia.org/ontology/officialSchoolColour"></see></summary>
    let officialSchoolColour = _prefix "officialSchoolColour"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ColourName"></see>
    /// </summary>
    let ColourName = _prefix "ColourName"
    /// <summary>
    /// Identifier used by the Swiss Federal Institute for Statistics
    /// <see href="http://dbpedia.org/ontology/ofsCode"></see></summary>
    let ofsCode = _prefix "ofsCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oilSystem"></see>
    /// </summary>
    let oilSystem = _prefix "oilSystem"
    /// <summary>
    /// Code used to indentify populated places in Russia
    /// <see href="http://dbpedia.org/ontology/okatoCode"></see></summary>
    let okatoCode = _prefix "okatoCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oldDistrict"></see>
    /// </summary>
    let oldDistrict = _prefix "oldDistrict"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oldName"></see>
    /// </summary>
    let oldName = _prefix "oldName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oldProvince"></see>
    /// </summary>
    let oldProvince = _prefix "oldProvince"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oldTeamCoached"></see>
    /// </summary>
    let oldTeamCoached = _prefix "oldTeamCoached"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oldcode"></see>
    /// </summary>
    let oldcode = _prefix "oldcode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olivierAward"></see>
    /// </summary>
    let olivierAward = _prefix "olivierAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicGames"></see>
    /// </summary>
    let olympicGames = _prefix "olympicGames"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicGamesBronze"></see>
    /// </summary>
    let olympicGamesBronze = _prefix "olympicGamesBronze"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicGamesGold"></see>
    /// </summary>
    let olympicGamesGold = _prefix "olympicGamesGold"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicGamesSilver"></see>
    /// </summary>
    let olympicGamesSilver = _prefix "olympicGamesSilver"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicGamesWins"></see>
    /// </summary>
    let olympicGamesWins = _prefix "olympicGamesWins"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicOathSwornBy"></see>
    /// </summary>
    let olympicOathSwornBy = _prefix "olympicOathSwornBy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicOathSwornByAthlete"></see>
    /// </summary>
    let olympicOathSwornByAthlete = _prefix "olympicOathSwornByAthlete"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicOathSwornByJudge"></see>
    /// </summary>
    let olympicOathSwornByJudge = _prefix "olympicOathSwornByJudge"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/omim"></see>
    /// </summary>
    let omim = _prefix "omim"
    /// <summary>
    /// the number corresponding to the chromosome on which the gene is located
    /// <see href="http://dbpedia.org/ontology/onChromosome"></see></summary>
    let onChromosome = _prefix "onChromosome"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ons"></see>
    /// </summary>
    let ons = _prefix "ons"
    /// <summary>
    /// Availability of open access content.
    /// <see href="http://dbpedia.org/ontology/openAccessContent"></see></summary>
    let openAccessContent = _prefix "openAccessContent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/openingDate"></see>
    /// </summary>
    let openingDate = _prefix "openingDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/openingFilm"></see>
    /// </summary>
    let openingFilm = _prefix "openingFilm"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/openingTheme"></see>
    /// </summary>
    let openingTheme = _prefix "openingTheme"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/openingYear"></see>
    /// </summary>
    let openingYear = _prefix "openingYear"
    /// <summary>
    /// Organisation or city who is the operator of an ArchitecturalStructure, PublicTransitSystem, etc. Not to confuse with maintainer or the owner.
    /// <see href="http://dbpedia.org/ontology/operatedBy"></see></summary>
    let operatedBy = _prefix "operatedBy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/operatingIncome"></see>
    /// </summary>
    let operatingIncome = _prefix "operatingIncome"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/operatingSystem"></see>
    /// </summary>
    let operatingSystem = _prefix "operatingSystem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/operator"></see>
    /// </summary>
    let operator = _prefix "operator"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/opponent"></see>
    /// </summary>
    let opponent = _prefix "opponent"
    /// <summary>
    /// "opponent in a military conflict, an organisation, country, or group of countries. "
    /// <see href="http://dbpedia.org/ontology/opponents"></see></summary>
    let opponents = _prefix "opponents"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orbitalEccentricity"></see>
    /// </summary>
    let orbitalEccentricity = _prefix "orbitalEccentricity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orbitalFlights"></see>
    /// </summary>
    let orbitalFlights = _prefix "orbitalFlights"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orbitalInclination"></see>
    /// </summary>
    let orbitalInclination = _prefix "orbitalInclination"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orbitalPeriod"></see>
    /// </summary>
    let orbitalPeriod = _prefix "orbitalPeriod"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orbits"></see>
    /// </summary>
    let orbits = _prefix "orbits"
    /// <summary>
    /// Authority data on researchers, academics, etc. The ID range has been defined as a subset of the forthcoming ISNI range.
    /// <see href="http://dbpedia.org/ontology/orcidId"></see></summary>
    let orcidId = _prefix "orcidId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/order"></see>
    /// </summary>
    let order = _prefix "order"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orderDate"></see>
    /// </summary>
    let orderDate = _prefix "orderDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orderInOffice"></see>
    /// </summary>
    let orderInOffice = _prefix "orderInOffice"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ordination"></see>
    /// </summary>
    let ordination = _prefix "ordination"
    /// <summary>
    /// Name and/or description of the organ
    /// <see href="http://dbpedia.org/ontology/organ"></see></summary>
    let organ = _prefix "organ"
    /// <summary>
    /// the organ system that a anatomical structure belongs to
    /// <see href="http://dbpedia.org/ontology/organSystem"></see></summary>
    let organSystem = _prefix "organSystem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/organisation"></see>
    /// </summary>
    let organisation = _prefix "organisation"
    /// <summary>
    /// Identify the members of an organisation.
    /// <see href="http://dbpedia.org/ontology/organisationMember"></see></summary>
    let organisationMember = _prefix "organisationMember"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orientation"></see>
    /// </summary>
    let orientation = _prefix "orientation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/origin"></see>
    /// </summary>
    let origin = _prefix "origin"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/originalDanseCompetition"></see>
    /// </summary>
    let originalDanseCompetition = _prefix "originalDanseCompetition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/originalDanseScore"></see>
    /// </summary>
    let originalDanseScore = _prefix "originalDanseScore"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/originalEndPoint"></see>
    /// </summary>
    let originalEndPoint = _prefix "originalEndPoint"
    /// <summary>
    /// The original language of the work.
    /// <see href="http://dbpedia.org/ontology/originalLanguage"></see></summary>
    let originalLanguage = _prefix "originalLanguage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/originalMaximumBoatBeam"></see>
    /// </summary>
    let originalMaximumBoatBeam = _prefix "originalMaximumBoatBeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/originalMaximumBoatLength"></see>
    /// </summary>
    let originalMaximumBoatLength = _prefix "originalMaximumBoatLength"
    /// <summary>
    /// The original name of the entity, e.g. film, settlement, etc.
    /// <see href="http://dbpedia.org/ontology/originalName"></see></summary>
    let originalName = _prefix "originalName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/originalStartPoint"></see>
    /// </summary>
    let originalStartPoint = _prefix "originalStartPoint"
    /// <summary>
    /// The original title of the work, most of the time in the original language as well
    /// <see href="http://dbpedia.org/ontology/originalTitle"></see></summary>
    let originalTitle = _prefix "originalTitle"
    /// <summary>
    /// Original use of the architectural structure, if it is currently being used as anything other than its original purpose.
    /// <see href="http://dbpedia.org/ontology/originallyUsedFor"></see></summary>
    let originallyUsedFor = _prefix "originallyUsedFor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/origo"></see>
    /// </summary>
    let origo = _prefix "origo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orogeny"></see>
    /// </summary>
    let orogeny = _prefix "orogeny"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orthologousGene"></see>
    /// </summary>
    let orthologousGene = _prefix "orthologousGene"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/other"></see>
    /// </summary>
    let other = _prefix "other"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherActivity"></see>
    /// </summary>
    let otherActivity = _prefix "otherActivity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherAppearances"></see>
    /// </summary>
    let otherAppearances = _prefix "otherAppearances"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherChannel"></see>
    /// </summary>
    let otherChannel = _prefix "otherChannel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherFamilyBranch"></see>
    /// </summary>
    let otherFamilyBranch = _prefix "otherFamilyBranch"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherFuelType"></see>
    /// </summary>
    let otherFuelType = _prefix "otherFuelType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherFunction"></see>
    /// </summary>
    let otherFunction = _prefix "otherFunction"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherInformation"></see>
    /// </summary>
    let otherInformation = _prefix "otherInformation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherLanguage"></see>
    /// </summary>
    let otherLanguage = _prefix "otherLanguage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherMedia"></see>
    /// </summary>
    let otherMedia = _prefix "otherMedia"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherName"></see>
    /// </summary>
    let otherName = _prefix "otherName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherOccupation"></see>
    /// </summary>
    let otherOccupation = _prefix "otherOccupation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherParty"></see>
    /// </summary>
    let otherParty = _prefix "otherParty"
    /// <summary>
    /// Connecting services that serve the station such as bus, etc.
    /// <see href="http://dbpedia.org/ontology/otherServingLines"></see></summary>
    let otherServingLines = _prefix "otherServingLines"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherSportsExperience"></see>
    /// </summary>
    let otherSportsExperience = _prefix "otherSportsExperience"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherWins"></see>
    /// </summary>
    let otherWins = _prefix "otherWins"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Wins"></see>
    /// </summary>
    let Wins = _prefix "Wins"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/outflow"></see>
    /// </summary>
    let outflow = _prefix "outflow"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/output"></see>
    /// </summary>
    let output = _prefix "output"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/outskirts"></see>
    /// </summary>
    let outskirts = _prefix "outskirts"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/overallRecord"></see>
    /// </summary>
    let overallRecord = _prefix "overallRecord"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oversight"></see>
    /// </summary>
    let oversight = _prefix "oversight"
    /// <summary>
    /// Used as if meaning: owned by, has as its owner
    /// <see href="http://dbpedia.org/ontology/owner"></see></summary>
    let owner = _prefix "owner"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/owningCompany"></see>
    /// </summary>
    let owningCompany = _prefix "owningCompany"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/owningOrganisation"></see>
    /// </summary>
    let owningOrganisation = _prefix "owningOrganisation"
    /// <summary>
    /// Used as if meaning: has property rights over
    /// <see href="http://dbpedia.org/ontology/owns"></see></summary>
    let owns = _prefix "owns"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Thing"></see>
    /// </summary>
    let Thing = _prefix "Thing"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/painter"></see>
    /// </summary>
    let painter = _prefix "painter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parent"></see>
    /// </summary>
    let parent = _prefix "parent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parentCompany"></see>
    /// </summary>
    let parentCompany = _prefix "parentCompany"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parentMountainPeak"></see>
    /// </summary>
    let parentMountainPeak = _prefix "parentMountainPeak"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parentOrganisation"></see>
    /// </summary>
    let parentOrganisation = _prefix "parentOrganisation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parish"></see>
    /// </summary>
    let parish = _prefix "parish"
    /// <summary>
    /// Information on station's parking facilities.
    /// <see href="http://dbpedia.org/ontology/parkingInformation"></see></summary>
    let parkingInformation = _prefix "parkingInformation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parkingLotsCars"></see>
    /// </summary>
    let parkingLotsCars = _prefix "parkingLotsCars"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parkingLotsTrucks"></see>
    /// </summary>
    let parkingLotsTrucks = _prefix "parkingLotsTrucks"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parliament"></see>
    /// </summary>
    let parliament = _prefix "parliament"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parliamentType"></see>
    /// </summary>
    let parliamentType = _prefix "parliamentType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parliamentaryGroup"></see>
    /// </summary>
    let parliamentaryGroup = _prefix "parliamentaryGroup"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/part"></see>
    /// </summary>
    let part = _prefix "part"
    /// <summary>
    /// total number of launches resulting in partial failure
    /// <see href="http://dbpedia.org/ontology/partialFailedLaunches"></see></summary>
    let partialFailedLaunches = _prefix "partialFailedLaunches"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/participant"></see>
    /// </summary>
    let participant = _prefix "participant"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/participatingIn"></see>
    /// </summary>
    let participatingIn = _prefix "participatingIn"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/particularSign"></see>
    /// </summary>
    let particularSign = _prefix "particularSign"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/partner"></see>
    /// </summary>
    let partner = _prefix "partner"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/party"></see>
    /// </summary>
    let party = _prefix "party"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/partyNumber"></see>
    /// </summary>
    let partyNumber = _prefix "partyNumber"
    /// <summary>
    /// Number of passengers per day.
    /// <see href="http://dbpedia.org/ontology/passengersPerDay"></see></summary>
    let passengersPerDay = _prefix "passengersPerDay"
    /// <summary>
    /// Number of passengers per year.
    /// <see href="http://dbpedia.org/ontology/passengersPerYear"></see></summary>
    let passengersPerYear = _prefix "passengersPerYear"
    /// <summary>
    /// System the passengers are using (from which the passenger statistics are).
    /// <see href="http://dbpedia.org/ontology/passengersUsedSystem"></see></summary>
    let passengersUsedSystem = _prefix "passengersUsedSystem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pastMember"></see>
    /// </summary>
    let pastMember = _prefix "pastMember"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pastor"></see>
    /// </summary>
    let pastor = _prefix "pastor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/patent"></see>
    /// </summary>
    let patent = _prefix "patent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/patron"></see>
    /// </summary>
    let patron = _prefix "patron"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/patronSaint"></see>
    /// </summary>
    let patronSaint = _prefix "patronSaint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pccSecretary"></see>
    /// </summary>
    let pccSecretary = _prefix "pccSecretary"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pdb"></see>
    /// </summary>
    let pdb = _prefix "pdb"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/peabodyAward"></see>
    /// </summary>
    let peabodyAward = _prefix "peabodyAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/penaltiesTeamA"></see>
    /// </summary>
    let penaltiesTeamA = _prefix "penaltiesTeamA"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/penaltiesTeamB"></see>
    /// </summary>
    let penaltiesTeamB = _prefix "penaltiesTeamB"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/penaltyScore"></see>
    /// </summary>
    let penaltyScore = _prefix "penaltyScore"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/penisLength"></see>
    /// </summary>
    let penisLength = _prefix "penisLength"
    /// <summary>
    /// Name for the people inhabiting a place, eg Ankara-&gt;Ankariotes, Bulgaria-&gt;Bulgarians
    /// <see href="http://dbpedia.org/ontology/peopleName"></see></summary>
    let peopleName = _prefix "peopleName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/perCapitaIncome"></see>
    /// </summary>
    let perCapitaIncome = _prefix "perCapitaIncome"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/perCapitaIncomeAsOf"></see>
    /// </summary>
    let perCapitaIncomeAsOf = _prefix "perCapitaIncomeAsOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/perCapitaIncomeRank"></see>
    /// </summary>
    let perCapitaIncomeRank = _prefix "perCapitaIncomeRank"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/percentage"></see>
    /// </summary>
    let percentage = _prefix "percentage"
    /// <summary>
    /// percentage of alcohol present in a beverage
    /// <see href="http://dbpedia.org/ontology/percentageAlcohol"></see></summary>
    let percentageAlcohol = _prefix "percentageAlcohol"
    /// <summary>
    /// how much fat (as a percentage) does this food contain. Mostly applies to Cheese
    /// <see href="http://dbpedia.org/ontology/percentageFat"></see></summary>
    let percentageFat = _prefix "percentageFat"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/percentageLiteracyMen"></see>
    /// </summary>
    let percentageLiteracyMen = _prefix "percentageLiteracyMen"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/percentageLiterate"></see>
    /// </summary>
    let percentageLiterate = _prefix "percentageLiterate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/percentageLiteracyWomen"></see>
    /// </summary>
    let percentageLiteracyWomen = _prefix "percentageLiteracyWomen"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/percentageOfAreaWater"></see>
    /// </summary>
    let percentageOfAreaWater = _prefix "percentageOfAreaWater"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/performer"></see>
    /// </summary>
    let performer = _prefix "performer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/periapsis"></see>
    /// </summary>
    let periapsis = _prefix "periapsis"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/perifocus"></see>
    /// </summary>
    let perifocus = _prefix "perifocus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/perimeter"></see>
    /// </summary>
    let perimeter = _prefix "perimeter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/period"></see>
    /// </summary>
    let period = _prefix "period"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/person"></see>
    /// </summary>
    let person = _prefix "person"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/personFunction"></see>
    /// </summary>
    let personFunction = _prefix "personFunction"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/personName"></see>
    /// </summary>
    let personName = _prefix "personName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pgaWins"></see>
    /// </summary>
    let pgaWins = _prefix "pgaWins"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/philosophicalSchool"></see>
    /// </summary>
    let philosophicalSchool = _prefix "philosophicalSchool"
    /// <summary>
    /// Don't use this, use areaCode
    /// <see href="http://dbpedia.org/ontology/phonePrefix"></see></summary>
    let phonePrefix = _prefix "phonePrefix"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/phonePrefixLabel"></see>
    /// </summary>
    let phonePrefixLabel = _prefix "phonePrefixLabel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/photographer"></see>
    /// </summary>
    let photographer = _prefix "photographer"
    /// <summary>
    /// A rank in the classification of organisms, below kingdom and above class; also called a division, especially in describing plants; a taxon at that rank.
    /// <see href="http://dbpedia.org/ontology/phylum"></see></summary>
    let phylum = _prefix "phylum"
    /// <summary>
    /// A picture of a thing.
    /// <see href="http://dbpedia.org/ontology/picture"></see></summary>
    let picture = _prefix "picture"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pictureDescription"></see>
    /// </summary>
    let pictureDescription = _prefix "pictureDescription"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pictureFormat"></see>
    /// </summary>
    let pictureFormat = _prefix "pictureFormat"
    /// <summary>
    /// Wikimedia CommonsCategory for pictures of this resource
    /// <see href="http://dbpedia.org/ontology/picturesCommonsCategory"></see></summary>
    let picturesCommonsCategory = _prefix "picturesCommonsCategory"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/piercing"></see>
    /// </summary>
    let piercing = _prefix "piercing"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pisciculturalPopulation"></see>
    /// </summary>
    let pisciculturalPopulation = _prefix "pisciculturalPopulation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pistonStroke"></see>
    /// </summary>
    let pistonStroke = _prefix "pistonStroke"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/place"></see>
    /// </summary>
    let place = _prefix "place"
    /// <summary>
    /// The place where the person has been buried.
    /// <see href="http://dbpedia.org/ontology/placeOfBurial"></see></summary>
    let placeOfBurial = _prefix "placeOfBurial"
    /// <summary>
    /// A religious administrative body needs to know which places of worship it
    /// <see href="http://dbpedia.org/ontology/placeOfWorship"></see></summary>
    let placeOfWorship = _prefix "placeOfWorship"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/plant"></see>
    /// </summary>
    let plant = _prefix "plant"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/playRole"></see>
    /// </summary>
    let playRole = _prefix "playRole"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/uses"></see>
    /// </summary>
    let uses = _prefix "uses"
    /// <summary>
    /// A person playing for a sports team. inverseOf team
    /// <see href="http://dbpedia.org/ontology/playerInTeam"></see></summary>
    let playerInTeam = _prefix "playerInTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/playerSeason"></see>
    /// </summary>
    let playerSeason = _prefix "playerSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/playerStatus"></see>
    /// </summary>
    let playerStatus = _prefix "playerStatus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/playingTime"></see>
    /// </summary>
    let playingTime = _prefix "playingTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/plays"></see>
    /// </summary>
    let plays = _prefix "plays"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pluviometry"></see>
    /// </summary>
    let pluviometry = _prefix "pluviometry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/podium"></see>
    /// </summary>
    let podium = _prefix "podium"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/podiums"></see>
    /// </summary>
    let podiums = _prefix "podiums"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pole"></see>
    /// </summary>
    let pole = _prefix "pole"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/poleDriver"></see>
    /// </summary>
    let poleDriver = _prefix "poleDriver"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/poleDriverCountry"></see>
    /// </summary>
    let poleDriverCountry = _prefix "poleDriverCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/poleDriverTeam"></see>
    /// </summary>
    let poleDriverTeam = _prefix "poleDriverTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/polePosition"></see>
    /// </summary>
    let polePosition = _prefix "polePosition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/poles"></see>
    /// </summary>
    let poles = _prefix "poles"
    /// <summary>
    /// The police detachment serving a UK place, eg Wakefield -&gt; "West Yorkshire Police"
    /// <see href="http://dbpedia.org/ontology/policeName"></see></summary>
    let policeName = _prefix "policeName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/polishFilmAward"></see>
    /// </summary>
    let polishFilmAward = _prefix "polishFilmAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/politicGovernmentDepartment"></see>
    /// </summary>
    let politicGovernmentDepartment = _prefix "politicGovernmentDepartment"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/politicalFunction"></see>
    /// </summary>
    let politicalFunction = _prefix "politicalFunction"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/politicalLeader"></see>
    /// </summary>
    let politicalLeader = _prefix "politicalLeader"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/politicalMajority"></see>
    /// </summary>
    let politicalMajority = _prefix "politicalMajority"
    /// <summary>
    /// Political party in the legislature (eg.: European People's Party in the European Parliament).
    /// <see href="http://dbpedia.org/ontology/politicalPartyInLegislature"></see></summary>
    let politicalPartyInLegislature = _prefix "politicalPartyInLegislature"
    /// <summary>
    /// The Political party of leader.
    /// <see href="http://dbpedia.org/ontology/politicalPartyOfLeader"></see></summary>
    let politicalPartyOfLeader = _prefix "politicalPartyOfLeader"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/politicalSeats"></see>
    /// </summary>
    let politicalSeats = _prefix "politicalSeats"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/popularVote"></see>
    /// </summary>
    let popularVote = _prefix "popularVote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/population"></see>
    /// </summary>
    let population = _prefix "population"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationAsOf"></see>
    /// </summary>
    let populationAsOf = _prefix "populationAsOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationDate"></see>
    /// </summary>
    let populationDate = _prefix "populationDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationDensity"></see>
    /// </summary>
    let populationDensity = _prefix "populationDensity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationMetro"></see>
    /// </summary>
    let populationMetro = _prefix "populationMetro"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationMetroDensity"></see>
    /// </summary>
    let populationMetroDensity = _prefix "populationMetroDensity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationPctChildren"></see>
    /// </summary>
    let populationPctChildren = _prefix "populationPctChildren"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationPctMen"></see>
    /// </summary>
    let populationPctMen = _prefix "populationPctMen"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationPctWomen"></see>
    /// </summary>
    let populationPctWomen = _prefix "populationPctWomen"
    /// <summary>
    /// a place were members of an ethnic group are living
    /// <see href="http://dbpedia.org/ontology/populationPlace"></see></summary>
    let populationPlace = _prefix "populationPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationQuote"></see>
    /// </summary>
    let populationQuote = _prefix "populationQuote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationRural"></see>
    /// </summary>
    let populationRural = _prefix "populationRural"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationRuralDensity"></see>
    /// </summary>
    let populationRuralDensity = _prefix "populationRuralDensity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationTotal"></see>
    /// </summary>
    let populationTotal = _prefix "populationTotal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationTotalRanking"></see>
    /// </summary>
    let populationTotalRanking = _prefix "populationTotalRanking"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationTotalReference"></see>
    /// </summary>
    let populationTotalReference = _prefix "populationTotalReference"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationUrban"></see>
    /// </summary>
    let populationUrban = _prefix "populationUrban"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationUrbanDensity"></see>
    /// </summary>
    let populationUrbanDensity = _prefix "populationUrbanDensity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationYear"></see>
    /// </summary>
    let populationYear = _prefix "populationYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/portfolio"></see>
    /// </summary>
    let portfolio = _prefix "portfolio"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/portrayer"></see>
    /// </summary>
    let portrayer = _prefix "portrayer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/position"></see>
    /// </summary>
    let position = _prefix "position"
    /// <summary>
    /// A postal code (known in various countries as a post code, postcode, or ZIP code) is a series of letters and/or digits appended to a postal address for the purpose of sorting mail.
    /// <see href="http://dbpedia.org/ontology/postalCode"></see></summary>
    let postalCode = _prefix "postalCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/power"></see>
    /// </summary>
    let power = _prefix "power"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/powerOutput"></see>
    /// </summary>
    let powerOutput = _prefix "powerOutput"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/powerType"></see>
    /// </summary>
    let powerType = _prefix "powerType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/precursor"></see>
    /// </summary>
    let precursor = _prefix "precursor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/predecessor"></see>
    /// </summary>
    let predecessor = _prefix "predecessor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prefaceBy"></see>
    /// </summary>
    let prefaceBy = _prefix "prefaceBy"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prefect"></see>
    /// </summary>
    let prefect = _prefix "prefect"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prefectMandate"></see>
    /// </summary>
    let prefectMandate = _prefix "prefectMandate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prefecture"></see>
    /// </summary>
    let prefecture = _prefix "prefecture"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prefix"></see>
    /// </summary>
    let prefix = _prefix "prefix"
    /// <summary>
    /// Date the play was first performed.
    /// <see href="http://dbpedia.org/ontology/premiereDate"></see></summary>
    let premiereDate = _prefix "premiereDate"
    /// <summary>
    /// Release date of a Work or another product (eg Aircraft or other MeansOfTransportation
    /// <see href="http://dbpedia.org/ontology/releaseDate"></see></summary>
    let releaseDate = _prefix "releaseDate"
    /// <summary>
    /// The theatre and/or city the play was first performed in.
    /// <see href="http://dbpedia.org/ontology/premierePlace"></see></summary>
    let premierePlace = _prefix "premierePlace"
    /// <summary>
    /// Year the play was first performed.
    /// <see href="http://dbpedia.org/ontology/premiereYear"></see></summary>
    let premiereYear = _prefix "premiereYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/releaseYear"></see>
    /// </summary>
    let releaseYear = _prefix "releaseYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presentMunicipality"></see>
    /// </summary>
    let presentMunicipality = _prefix "presentMunicipality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presentName"></see>
    /// </summary>
    let presentName = _prefix "presentName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presenter"></see>
    /// </summary>
    let presenter = _prefix "presenter"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/president"></see>
    /// </summary>
    let president = _prefix "president"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presidentGeneralCouncil"></see>
    /// </summary>
    let presidentGeneralCouncil = _prefix "presidentGeneralCouncil"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presidentGeneralCouncilMandate"></see>
    /// </summary>
    let presidentGeneralCouncilMandate = _prefix "presidentGeneralCouncilMandate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presidentRegionalCouncil"></see>
    /// </summary>
    let presidentRegionalCouncil = _prefix "presidentRegionalCouncil"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presidentRegionalCouncilMandate"></see>
    /// </summary>
    let presidentRegionalCouncilMandate = _prefix "presidentRegionalCouncilMandate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousDemographics"></see>
    /// </summary>
    let previousDemographics = _prefix "previousDemographics"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousEditor"></see>
    /// </summary>
    let previousEditor = _prefix "previousEditor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousEntity"></see>
    /// </summary>
    let previousEntity = _prefix "previousEntity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousEvent"></see>
    /// </summary>
    let previousEvent = _prefix "previousEvent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousInfrastructure"></see>
    /// </summary>
    let previousInfrastructure = _prefix "previousInfrastructure"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousMission"></see>
    /// </summary>
    let previousMission = _prefix "previousMission"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousName"></see>
    /// </summary>
    let previousName = _prefix "previousName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousPopulation"></see>
    /// </summary>
    let previousPopulation = _prefix "previousPopulation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousPopulationTotal"></see>
    /// </summary>
    let previousPopulationTotal = _prefix "previousPopulationTotal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousWork"></see>
    /// </summary>
    let previousWork = _prefix "previousWork"
    /// <summary>
    /// The price of something, eg a journal. For "total money earned by an Athlete" use gross
    /// <see href="http://dbpedia.org/ontology/price"></see></summary>
    let price = _prefix "price"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/primaryFuelType"></see>
    /// </summary>
    let primaryFuelType = _prefix "primaryFuelType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/primate"></see>
    /// </summary>
    let primate = _prefix "primate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/primeMinister"></see>
    /// </summary>
    let primeMinister = _prefix "primeMinister"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/primogenitor"></see>
    /// </summary>
    let primogenitor = _prefix "primogenitor"
    /// <summary>
    /// Principal of an educational institution (school)
    /// <see href="http://dbpedia.org/ontology/principal"></see></summary>
    let principal = _prefix "principal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/principalArea"></see>
    /// </summary>
    let principalArea = _prefix "principalArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/principalEngineer"></see>
    /// </summary>
    let principalEngineer = _prefix "principalEngineer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/proPeriod"></see>
    /// </summary>
    let proPeriod = _prefix "proPeriod"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/proSince"></see>
    /// </summary>
    let proSince = _prefix "proSince"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/proTeam"></see>
    /// </summary>
    let proTeam = _prefix "proTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/proYear"></see>
    /// </summary>
    let proYear = _prefix "proYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/probowlPick"></see>
    /// </summary>
    let probowlPick = _prefix "probowlPick"
    /// <summary>
    /// The name designating a formal collection of steps to be taken to complete the case
    /// <see href="http://dbpedia.org/ontology/procedure"></see></summary>
    let procedure = _prefix "procedure"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/producedBy"></see>
    /// </summary>
    let producedBy = _prefix "producedBy"
    /// <summary>
    /// The producer of the creative work.
    /// <see href="http://dbpedia.org/ontology/producer"></see></summary>
    let producer = _prefix "producer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/produces"></see>
    /// </summary>
    let produces = _prefix "produces"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/product"></see>
    /// </summary>
    let product = _prefix "product"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/productShape"></see>
    /// </summary>
    let productShape = _prefix "productShape"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/production"></see>
    /// </summary>
    let production = _prefix "production"
    /// <summary>
    /// the company that produced the work e.g. Film, MusicalWork, Software
    /// <see href="http://dbpedia.org/ontology/productionCompany"></see></summary>
    let productionCompany = _prefix "productionCompany"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/productionEndDate"></see>
    /// </summary>
    let productionEndDate = _prefix "productionEndDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/productionEndYear"></see>
    /// </summary>
    let productionEndYear = _prefix "productionEndYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/productionStartDate"></see>
    /// </summary>
    let productionStartDate = _prefix "productionStartDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/productionStartYear"></see>
    /// </summary>
    let productionStartYear = _prefix "productionStartYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/productionYears"></see>
    /// </summary>
    let productionYears = _prefix "productionYears"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/profession"></see>
    /// </summary>
    let profession = _prefix "profession"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/programCost"></see>
    /// </summary>
    let programCost = _prefix "programCost"
    /// <summary>
    /// The programming format describes the overall content broadcast on a radio or television station.
    /// <see href="http://dbpedia.org/ontology/programmeFormat"></see></summary>
    let programmeFormat = _prefix "programmeFormat"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/programmingLanguage"></see>
    /// </summary>
    let programmingLanguage = _prefix "programmingLanguage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/project"></see>
    /// </summary>
    let project = _prefix "project"
    /// <summary>
    /// The part of the project budget that is funded by the Organistaions given in the "FundedBy" property.
    /// <see href="http://dbpedia.org/ontology/projectBudgetFunding"></see></summary>
    let projectBudgetFunding = _prefix "projectBudgetFunding"
    /// <summary>
    /// The total budget of the research project.
    /// <see href="http://dbpedia.org/ontology/projectBudgetTotal"></see></summary>
    let projectBudgetTotal = _prefix "projectBudgetTotal"
    /// <summary>
    /// The coordinating organisation of the project.
    /// <see href="http://dbpedia.org/ontology/projectCoordinator"></see></summary>
    let projectCoordinator = _prefix "projectCoordinator"
    /// <summary>
    /// The end date of the project.
    /// <see href="http://dbpedia.org/ontology/projectEndDate"></see></summary>
    let projectEndDate = _prefix "projectEndDate"
    /// <summary>
    /// A key word of the project.
    /// <see href="http://dbpedia.org/ontology/projectKeyword"></see></summary>
    let projectKeyword = _prefix "projectKeyword"
    /// <summary>
    /// A defined objective of the project.
    /// <see href="http://dbpedia.org/ontology/projectObjective"></see></summary>
    let projectObjective = _prefix "projectObjective"
    /// <summary>
    /// A participating organisation of the project.
    /// <see href="http://dbpedia.org/ontology/projectParticipant"></see></summary>
    let projectParticipant = _prefix "projectParticipant"
    /// <summary>
    /// The reference identification of the project.
    /// <see href="http://dbpedia.org/ontology/projectReferenceID"></see></summary>
    let projectReferenceID = _prefix "projectReferenceID"
    /// <summary>
    /// The start date of the project.
    /// <see href="http://dbpedia.org/ontology/projectStartDate"></see></summary>
    let projectStartDate = _prefix "projectStartDate"
    /// <summary>
    /// The type of the research project. Mostly used for the funding schemes of the European Union, for instance: Specific Targeted Research Projects (STREP), Network of Excellence (NoE) or Integrated Project.
    /// <see href="http://dbpedia.org/ontology/projectType"></see></summary>
    let projectType = _prefix "projectType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prominence"></see>
    /// </summary>
    let prominence = _prefix "prominence"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/promotion"></see>
    /// </summary>
    let promotion = _prefix "promotion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pronunciation"></see>
    /// </summary>
    let pronunciation = _prefix "pronunciation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prospectLeague"></see>
    /// </summary>
    let prospectLeague = _prefix "prospectLeague"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prospectTeam"></see>
    /// </summary>
    let prospectTeam = _prefix "prospectTeam"
    /// <summary>
    /// The sort of status that is granted to a protected Building or Monument. This is not about being protected or not, this is about the nature of the protection regime. E.g., in the Netherlands the protection status 'rijksmonument' points to more elaborate protection than other statuses.
    /// <see href="http://dbpedia.org/ontology/protectionStatus"></see></summary>
    let protectionStatus = _prefix "protectionStatus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Status"></see>
    /// </summary>
    let Status = _prefix "Status"
    /// <summary>
    /// Amount of proteins per servingSize of a Food
    /// <see href="http://dbpedia.org/ontology/protein"></see></summary>
    let protein = _prefix "protein"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/protestantPercentage"></see>
    /// </summary>
    let protestantPercentage = _prefix "protestantPercentage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/provCode"></see>
    /// </summary>
    let provCode = _prefix "provCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/provides"></see>
    /// </summary>
    let provides = _prefix "provides"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/province"></see>
    /// </summary>
    let province = _prefix "province"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/provinceIsoCode"></see>
    /// </summary>
    let provinceIsoCode = _prefix "provinceIsoCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/provinceLink"></see>
    /// </summary>
    let provinceLink = _prefix "provinceLink"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/provost"></see>
    /// </summary>
    let provost = _prefix "provost"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pseudonym"></see>
    /// </summary>
    let pseudonym = _prefix "pseudonym"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pubchem"></see>
    /// </summary>
    let pubchem = _prefix "pubchem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/publication"></see>
    /// </summary>
    let publication = _prefix "publication"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/publicationDate"></see>
    /// </summary>
    let publicationDate = _prefix "publicationDate"
    /// <summary>
    /// describes in what way this site is accessible for public
    /// <see href="http://dbpedia.org/ontology/publiclyAccessible"></see></summary>
    let publiclyAccessible = _prefix "publiclyAccessible"
    /// <summary>
    /// Publisher of a work. For literal (string) use dc:publisher; for object (URL) use publisher
    /// <see href="http://dbpedia.org/ontology/publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/purchasingPowerParity"></see>
    /// </summary>
    let purchasingPowerParity = _prefix "purchasingPowerParity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/purchasingPowerParityRank"></see>
    /// </summary>
    let purchasingPowerParityRank = _prefix "purchasingPowerParityRank"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/purchasingPowerParityYear"></see>
    /// </summary>
    let purchasingPowerParityYear = _prefix "purchasingPowerParityYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/purpose"></see>
    /// </summary>
    let purpose = _prefix "purpose"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/qatarClassic"></see>
    /// </summary>
    let qatarClassic = _prefix "qatarClassic"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/quebecerTitle"></see>
    /// </summary>
    let quebecerTitle = _prefix "quebecerTitle"
    /// <summary>
    /// A quotation is the repetition of one expression as part of another one, particularly when the quoted expression is well-known or explicitly attributed by citation to its original source.
    /// <see href="http://dbpedia.org/ontology/quotation"></see></summary>
    let quotation = _prefix "quotation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/quote"></see>
    /// </summary>
    let quote = _prefix "quote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ra"></see>
    /// </summary>
    let ra = _prefix "ra"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/race"></see>
    /// </summary>
    let race = _prefix "race"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/raceHorse"></see>
    /// </summary>
    let raceHorse = _prefix "raceHorse"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/raceLength"></see>
    /// </summary>
    let raceLength = _prefix "raceLength"
    /// <summary>
    /// Result of one racer in a sport competition
    /// <see href="http://dbpedia.org/ontology/raceResult"></see></summary>
    let raceResult = _prefix "raceResult"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/raceTrack"></see>
    /// </summary>
    let raceTrack = _prefix "raceTrack"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/raceWins"></see>
    /// </summary>
    let raceWins = _prefix "raceWins"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/races"></see>
    /// </summary>
    let races = _prefix "races"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/racketCatching"></see>
    /// </summary>
    let racketCatching = _prefix "racketCatching"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/radio"></see>
    /// </summary>
    let radio = _prefix "radio"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/radioStation"></see>
    /// </summary>
    let radioStation = _prefix "radioStation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/radius_ly"></see>
    /// </summary>
    let radius_ly = _prefix "radius_ly"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/railGauge"></see>
    /// </summary>
    let railGauge = _prefix "railGauge"
    /// <summary>
    /// Railway line that is using the tunnel.
    /// <see href="http://dbpedia.org/ontology/railwayLineUsingTunnel"></see></summary>
    let railwayLineUsingTunnel = _prefix "railwayLineUsingTunnel"
    /// <summary>
    /// Information on the type of platform(s) at the station.
    /// <see href="http://dbpedia.org/ontology/railwayPlatforms"></see></summary>
    let railwayPlatforms = _prefix "railwayPlatforms"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/railwayRollingStock"></see>
    /// </summary>
    let railwayRollingStock = _prefix "railwayRollingStock"
    /// <summary>
    /// Maximum distance without refueling
    /// <see href="http://dbpedia.org/ontology/range"></see></summary>
    let range = _prefix "range"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation_,_Instrument"></see>
    /// </summary>
    let ``MeanOfTransportation_,_Instrument`` =
        _prefix "MeanOfTransportation_,_Instrument"

    /// <summary>
    /// Rank of something among other things of the same kind, eg Constellations by Area; MusicalAlbums by popularity, etc
    /// <see href="http://dbpedia.org/ontology/rank"></see></summary>
    let rank = _prefix "rank"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankAgreement"></see>
    /// </summary>
    let rankAgreement = _prefix "rankAgreement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankArea"></see>
    /// </summary>
    let rankArea = _prefix "rankArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankInFinalMedalCount"></see>
    /// </summary>
    let rankInFinalMedalCount = _prefix "rankInFinalMedalCount"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankPopulation"></see>
    /// </summary>
    let rankPopulation = _prefix "rankPopulation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ranking"></see>
    /// </summary>
    let ranking = _prefix "ranking"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankingWins"></see>
    /// </summary>
    let rankingWins = _prefix "rankingWins"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankingsDoubles"></see>
    /// </summary>
    let rankingsDoubles = _prefix "rankingsDoubles"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankingsSingles"></see>
    /// </summary>
    let rankingsSingles = _prefix "rankingsSingles"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rating"></see>
    /// </summary>
    let rating = _prefix "rating"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ratio"></see>
    /// </summary>
    let ratio = _prefix "ratio"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rebuildDate"></see>
    /// </summary>
    let rebuildDate = _prefix "rebuildDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rebuilder"></see>
    /// </summary>
    let rebuilder = _prefix "rebuilder"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rebuildingDate"></see>
    /// </summary>
    let rebuildingDate = _prefix "rebuildingDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rebuildingYear"></see>
    /// </summary>
    let rebuildingYear = _prefix "rebuildingYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/recentWinner"></see>
    /// </summary>
    let recentWinner = _prefix "recentWinner"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/recommissioningDate"></see>
    /// </summary>
    let recommissioningDate = _prefix "recommissioningDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/recordDate"></see>
    /// </summary>
    let recordDate = _prefix "recordDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/recordLabel"></see>
    /// </summary>
    let recordLabel = _prefix "recordLabel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/recordedIn"></see>
    /// </summary>
    let recordedIn = _prefix "recordedIn"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rector"></see>
    /// </summary>
    let rector = _prefix "rector"
    /// <summary>
    /// red list code for treatened species NL (different from IUCN)
    /// <see href="http://dbpedia.org/ontology/redListIdNL"></see></summary>
    let redListIdNL = _prefix "redListIdNL"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/redLongDistancePisteNumber"></see>
    /// </summary>
    let redLongDistancePisteNumber = _prefix "redLongDistancePisteNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/redSkiPisteNumber"></see>
    /// </summary>
    let redSkiPisteNumber = _prefix "redSkiPisteNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/redline"></see>
    /// </summary>
    let redline = _prefix "redline"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refcul"></see>
    /// </summary>
    let refcul = _prefix "refcul"
    /// <summary>
    /// Structured reference providing info about the subject
    /// <see href="http://dbpedia.org/ontology/reference"></see></summary>
    let reference = _prefix "reference"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/reffBourgmestre"></see>
    /// </summary>
    let reffBourgmestre = _prefix "reffBourgmestre"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refgen"></see>
    /// </summary>
    let refgen = _prefix "refgen"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refgeo"></see>
    /// </summary>
    let refgeo = _prefix "refgeo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refpol"></see>
    /// </summary>
    let refpol = _prefix "refpol"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refseq"></see>
    /// </summary>
    let refseq = _prefix "refseq"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refseqmrna"></see>
    /// </summary>
    let refseqmrna = _prefix "refseqmrna"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refseqprotein"></see>
    /// </summary>
    let refseqprotein = _prefix "refseqprotein"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regency"></see>
    /// </summary>
    let regency = _prefix "regency"
    /// <summary>
    /// Subject has served as the regent of another monarch
    /// <see href="http://dbpedia.org/ontology/regentOf"></see></summary>
    let regentOf = _prefix "regentOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regime"></see>
    /// </summary>
    let regime = _prefix "regime"
    /// <summary>
    /// The regin where the thing is located or is connected to.
    /// <see href="http://dbpedia.org/ontology/region"></see></summary>
    let region = _prefix "region"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regionLink"></see>
    /// </summary>
    let regionLink = _prefix "regionLink"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regionServed"></see>
    /// </summary>
    let regionServed = _prefix "regionServed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regionType"></see>
    /// </summary>
    let regionType = _prefix "regionType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regionalCouncil"></see>
    /// </summary>
    let regionalCouncil = _prefix "regionalCouncil"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regionalLanguage"></see>
    /// </summary>
    let regionalLanguage = _prefix "regionalLanguage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regionalPrefecture"></see>
    /// </summary>
    let regionalPrefecture = _prefix "regionalPrefecture"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/registration"></see>
    /// </summary>
    let registration = _prefix "registration"
    /// <summary>
    /// Identification of the registry a document is in
    /// <see href="http://dbpedia.org/ontology/registryNumber"></see></summary>
    let registryNumber = _prefix "registryNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/reign"></see>
    /// </summary>
    let reign = _prefix "reign"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/reignName"></see>
    /// </summary>
    let reignName = _prefix "reignName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/reigningPope"></see>
    /// </summary>
    let reigningPope = _prefix "reigningPope"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/related"></see>
    /// </summary>
    let related = _prefix "related"
    /// <summary>
    /// This property is to accommodate the list field that contains a list of related personFunctions a person holds or has held
    /// <see href="http://dbpedia.org/ontology/relatedFunctions"></see></summary>
    let relatedFunctions = _prefix "relatedFunctions"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/relatedMeanOfTransportation"></see>
    /// </summary>
    let relatedMeanOfTransportation = _prefix "relatedMeanOfTransportation"
    /// <summary>
    /// This property is to accommodate the list field that contains a list of, e.g., monuments in the same town
    /// <see href="http://dbpedia.org/ontology/relatedPlaces"></see></summary>
    let relatedPlaces = _prefix "relatedPlaces"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/relation"></see>
    /// </summary>
    let relation = _prefix "relation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/relative"></see>
    /// </summary>
    let relative = _prefix "relative"
    /// <summary>
    /// the ratio of the average mass of atoms of an element (from a single given sample or source) to 1⁄12 of the mass of an atom of carbon-12
    /// <see href="http://dbpedia.org/ontology/relativeAtomicMass"></see></summary>
    let relativeAtomicMass = _prefix "relativeAtomicMass"
    /// <summary>
    /// Usually used with releaseDate, particularly for Films. Often there can be several pairs so our modeling is not precise here...
    /// <see href="http://dbpedia.org/ontology/releaseLocation"></see></summary>
    let releaseLocation = _prefix "releaseLocation"
    /// <summary>
    /// Physical remains or personal effects of a saint or venerated person, preserved in a religious building
    /// <see href="http://dbpedia.org/ontology/relics"></see></summary>
    let relics = _prefix "relics"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/relief"></see>
    /// </summary>
    let relief = _prefix "relief"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/religion"></see>
    /// </summary>
    let religion = _prefix "religion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/religiousHead"></see>
    /// </summary>
    let religiousHead = _prefix "religiousHead"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/religiousHeadLabel"></see>
    /// </summary>
    let religiousHeadLabel = _prefix "religiousHeadLabel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/religiousOrder"></see>
    /// </summary>
    let religiousOrder = _prefix "religiousOrder"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Monastry"></see>
    /// </summary>
    let Monastry = _prefix "Monastry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/reopened"></see>
    /// </summary>
    let reopened = _prefix "reopened"
    /// <summary>
    /// Date of reopening the architectural structure.
    /// <see href="http://dbpedia.org/ontology/reopeningDate"></see></summary>
    let reopeningDate = _prefix "reopeningDate"
    /// <summary>
    /// Year of reopening the architectural structure.
    /// <see href="http://dbpedia.org/ontology/reopeningYear"></see></summary>
    let reopeningYear = _prefix "reopeningYear"
    /// <summary>
    /// A reporting mark is a two-, three-, or four-letter alphabetic code used to identify owners or lessees of rolling stock and other equipment used on the North American railroad network.
    /// <see href="http://dbpedia.org/ontology/reportingMark"></see></summary>
    let reportingMark = _prefix "reportingMark"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/representative"></see>
    /// </summary>
    let representative = _prefix "representative"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/requirement"></see>
    /// </summary>
    let requirement = _prefix "requirement"
    /// <summary>
    /// Are reservations required for the establishment or event?
    /// <see href="http://dbpedia.org/ontology/reservations"></see></summary>
    let reservations = _prefix "reservations"
    /// <summary>
    /// Place of residence of a person.
    /// <see href="http://dbpedia.org/ontology/residence"></see></summary>
    let residence = _prefix "residence"
    /// <summary>
    /// Native Resolution
    /// <see href="http://dbpedia.org/ontology/resolution"></see></summary>
    let resolution = _prefix "resolution"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/restingDate"></see>
    /// </summary>
    let restingDate = _prefix "restingDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/restingPlace"></see>
    /// </summary>
    let restingPlace = _prefix "restingPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/restingPlacePosition"></see>
    /// </summary>
    let restingPlacePosition = _prefix "restingPlacePosition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/restoreDate"></see>
    /// </summary>
    let restoreDate = _prefix "restoreDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/result"></see>
    /// </summary>
    let result = _prefix "result"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/retentionTime"></see>
    /// </summary>
    let retentionTime = _prefix "retentionTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/retired"></see>
    /// </summary>
    let retired = _prefix "retired"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/retiredRocket"></see>
    /// </summary>
    let retiredRocket = _prefix "retiredRocket"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/retirementDate"></see>
    /// </summary>
    let retirementDate = _prefix "retirementDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/revenue"></see>
    /// </summary>
    let revenue = _prefix "revenue"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/review"></see>
    /// </summary>
    let review = _prefix "review"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rgbCoordinateBlue"></see>
    /// </summary>
    let rgbCoordinateBlue = _prefix "rgbCoordinateBlue"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rgbCoordinateGreen"></see>
    /// </summary>
    let rgbCoordinateGreen = _prefix "rgbCoordinateGreen"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rgbCoordinateRed"></see>
    /// </summary>
    let rgbCoordinateRed = _prefix "rgbCoordinateRed"
    /// <summary>
    /// An identifying system for scientific authors. The system was introduced in January 2008 by Thomson Reuters. The combined use of the Digital Object Identifier with the ResearcherID allows for a unique association of authors and scientific articles.
    /// <see href="http://dbpedia.org/ontology/ridId"></see></summary>
    let ridId = _prefix "ridId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rightAscension"></see>
    /// </summary>
    let rightAscension = _prefix "rightAscension"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rightChild"></see>
    /// </summary>
    let rightChild = _prefix "rightChild"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rightTributary"></see>
    /// </summary>
    let rightTributary = _prefix "rightTributary"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rival"></see>
    /// </summary>
    let rival = _prefix "rival"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/river"></see>
    /// </summary>
    let river = _prefix "river"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/riverBranch"></see>
    /// </summary>
    let riverBranch = _prefix "riverBranch"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/riverBranchOf"></see>
    /// </summary>
    let riverBranchOf = _prefix "riverBranchOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/riverMouth"></see>
    /// </summary>
    let riverMouth = _prefix "riverMouth"
    /// <summary>
    /// Rijksbureau voor Kunsthistorische Documentatie (RKD) artists database id.
    /// http://rkd.nl/explore/artists/$1
    /// <see href="http://dbpedia.org/ontology/rkdArtistsId"></see></summary>
    let rkdArtistsId = _prefix "rkdArtistsId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/road"></see>
    /// </summary>
    let road = _prefix "road"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rocket"></see>
    /// </summary>
    let rocket = _prefix "rocket"
    /// <summary>
    /// purpose of the rocket
    /// <see href="http://dbpedia.org/ontology/rocketFunction"></see></summary>
    let rocketFunction = _prefix "rocketFunction"
    /// <summary>
    /// number of stages, not including boosters
    /// <see href="http://dbpedia.org/ontology/rocketStages"></see></summary>
    let rocketStages = _prefix "rocketStages"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rolandGarrosDouble"></see>
    /// </summary>
    let rolandGarrosDouble = _prefix "rolandGarrosDouble"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rolandGarrosMixed"></see>
    /// </summary>
    let rolandGarrosMixed = _prefix "rolandGarrosMixed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rolandGarrosSingle"></see>
    /// </summary>
    let rolandGarrosSingle = _prefix "rolandGarrosSingle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/role"></see>
    /// </summary>
    let role = _prefix "role"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/roleInEvent"></see>
    /// </summary>
    let roleInEvent = _prefix "roleInEvent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/roofHeight"></see>
    /// </summary>
    let roofHeight = _prefix "roofHeight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rotationPeriod"></see>
    /// </summary>
    let rotationPeriod = _prefix "rotationPeriod"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/route"></see>
    /// </summary>
    let route = _prefix "route"
    /// <summary>
    /// details of the activity for a road.
    /// <see href="http://dbpedia.org/ontology/routeActivity"></see></summary>
    let routeActivity = _prefix "routeActivity"
    /// <summary>
    /// The general direction of the route (eg. North-South).
    /// <see href="http://dbpedia.org/ontology/routeDirection"></see></summary>
    let routeDirection = _prefix "routeDirection"
    /// <summary>
    /// End of the route. This is where the route ends and, for U.S. roads, is either at the northern terminus or eastern terminus.
    /// <see href="http://dbpedia.org/ontology/routeEnd"></see></summary>
    let routeEnd = _prefix "routeEnd"
    /// <summary>
    /// End of the route. The opposite of OntologyProperty:routeStartDirection.
    /// <see href="http://dbpedia.org/ontology/routeEndDirection"></see></summary>
    let routeEndDirection = _prefix "routeEndDirection"
    /// <summary>
    /// The end location of the route.
    /// <see href="http://dbpedia.org/ontology/routeEndLocation"></see></summary>
    let routeEndLocation = _prefix "routeEndLocation"
    /// <summary>
    /// A junction or cross to another route.
    /// <see href="http://dbpedia.org/ontology/routeJunction"></see></summary>
    let routeJunction = _prefix "routeJunction"
    /// <summary>
    /// line of a stop on a route.
    /// <see href="http://dbpedia.org/ontology/routeLine"></see></summary>
    let routeLine = _prefix "routeLine"
    /// <summary>
    /// next stop on a route.
    /// <see href="http://dbpedia.org/ontology/routeNext"></see></summary>
    let routeNext = _prefix "routeNext"
    /// <summary>
    /// The number of the route.
    /// <see href="http://dbpedia.org/ontology/routeNumber"></see></summary>
    let routeNumber = _prefix "routeNumber"
    /// <summary>
    /// previous stop on a route.
    /// <see href="http://dbpedia.org/ontology/routePrevious"></see></summary>
    let routePrevious = _prefix "routePrevious"
    /// <summary>
    /// Start of the route. This is where the route begins and, for U.S. roads, is either at the southern terminus or western terminus.
    /// <see href="http://dbpedia.org/ontology/routeStart"></see></summary>
    let routeStart = _prefix "routeStart"
    /// <summary>
    /// End of the route. For U.S. roads, this should be either "South" or "West" per the standards set by the U.S. Roads project.
    /// <see href="http://dbpedia.org/ontology/routeStartDirection"></see></summary>
    let routeStartDirection = _prefix "routeStartDirection"
    /// <summary>
    /// The start location of the route.
    /// <see href="http://dbpedia.org/ontology/routeStartLocation"></see></summary>
    let routeStartLocation = _prefix "routeStartLocation"
    /// <summary>
    /// The route type abbreviation (eg.: I for Interstate, M for Motorway or NJ for New Jersey Route).
    /// <see href="http://dbpedia.org/ontology/routeTypeAbbreviation"></see></summary>
    let routeTypeAbbreviation = _prefix "routeTypeAbbreviation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/royalAnthem"></see>
    /// </summary>
    let royalAnthem = _prefix "royalAnthem"
    /// <summary>
    /// Ruling referred to in this legal case
    /// <see href="http://dbpedia.org/ontology/ruling"></see></summary>
    let ruling = _prefix "ruling"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/runningMate"></see>
    /// </summary>
    let runningMate = _prefix "runningMate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/runtime"></see>
    /// </summary>
    let runtime = _prefix "runtime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/runwayDesignation"></see>
    /// </summary>
    let runwayDesignation = _prefix "runwayDesignation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/runwayLength"></see>
    /// </summary>
    let runwayLength = _prefix "runwayLength"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/runwaySurface"></see>
    /// </summary>
    let runwaySurface = _prefix "runwaySurface"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/runwayWidth"></see>
    /// </summary>
    let runwayWidth = _prefix "runwayWidth"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ruralMunicipality"></see>
    /// </summary>
    let ruralMunicipality = _prefix "ruralMunicipality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/saint"></see>
    /// </summary>
    let saint = _prefix "saint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/salary"></see>
    /// </summary>
    let salary = _prefix "salary"
    /// <summary>
    /// This property holds an intermediate node of the type Sales.
    /// <see href="http://dbpedia.org/ontology/sales"></see></summary>
    let sales = _prefix "sales"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sameName"></see>
    /// </summary>
    let sameName = _prefix "sameName"
    /// <summary>
    /// most recent average SAT scores
    /// <see href="http://dbpedia.org/ontology/satScore"></see></summary>
    let satScore = _prefix "satScore"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/satellite"></see>
    /// </summary>
    let satellite = _prefix "satellite"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/satellitesDeployed"></see>
    /// </summary>
    let satellitesDeployed = _prefix "satellitesDeployed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/scale"></see>
    /// </summary>
    let scale = _prefix "scale"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/scene"></see>
    /// </summary>
    let scene = _prefix "scene"
    /// <summary>
    /// school a person goes or went to
    /// <see href="http://dbpedia.org/ontology/school"></see></summary>
    let school = _prefix "school"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/schoolBoard"></see>
    /// </summary>
    let schoolBoard = _prefix "schoolBoard"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/schoolCode"></see>
    /// </summary>
    let schoolCode = _prefix "schoolCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/schoolNumber"></see>
    /// </summary>
    let schoolNumber = _prefix "schoolNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/schoolPatron"></see>
    /// </summary>
    let schoolPatron = _prefix "schoolPatron"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/scientificName"></see>
    /// </summary>
    let scientificName = _prefix "scientificName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/screenActorsGuildAward"></see>
    /// </summary>
    let screenActorsGuildAward = _prefix "screenActorsGuildAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sea"></see>
    /// </summary>
    let sea = _prefix "sea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/season"></see>
    /// </summary>
    let season = _prefix "season"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/seasonManager"></see>
    /// </summary>
    let seasonManager = _prefix "seasonManager"
    /// <summary>
    /// The season number to which the TelevisionEpisode belongs.
    /// <see href="http://dbpedia.org/ontology/seasonNumber"></see></summary>
    let seasonNumber = _prefix "seasonNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/seatNumber"></see>
    /// </summary>
    let seatNumber = _prefix "seatNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/seatingCapacity"></see>
    /// </summary>
    let seatingCapacity = _prefix "seatingCapacity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/second"></see>
    /// </summary>
    let second = _prefix "second"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondCommander"></see>
    /// </summary>
    let secondCommander = _prefix "secondCommander"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondDriver"></see>
    /// </summary>
    let secondDriver = _prefix "secondDriver"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondDriverCountry"></see>
    /// </summary>
    let secondDriverCountry = _prefix "secondDriverCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondLeader"></see>
    /// </summary>
    let secondLeader = _prefix "secondLeader"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondPlace"></see>
    /// </summary>
    let secondPlace = _prefix "secondPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondPopularVote"></see>
    /// </summary>
    let secondPopularVote = _prefix "secondPopularVote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondTeam"></see>
    /// </summary>
    let secondTeam = _prefix "secondTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secretaryGeneral"></see>
    /// </summary>
    let secretaryGeneral = _prefix "secretaryGeneral"
    /// <summary>
    /// Safety precautions that are used in the building.
    /// <see href="http://dbpedia.org/ontology/security"></see></summary>
    let security = _prefix "security"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/seiyu"></see>
    /// </summary>
    let seiyu = _prefix "seiyu"
    /// <summary>
    /// when (or in which project) the person was selected to train as an astronaut
    /// <see href="http://dbpedia.org/ontology/selection"></see></summary>
    let selection = _prefix "selection"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/selectionPoint"></see>
    /// </summary>
    let selectionPoint = _prefix "selectionPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/selectionYear"></see>
    /// </summary>
    let selectionYear = _prefix "selectionYear"
    /// <summary>
    /// Authority data from the National Library of Sweden
    /// <see href="http://dbpedia.org/ontology/selibrId"></see></summary>
    let selibrId = _prefix "selibrId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/senator"></see>
    /// </summary>
    let senator = _prefix "senator"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/senior"></see>
    /// </summary>
    let senior = _prefix "senior"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/seniority"></see>
    /// </summary>
    let seniority = _prefix "seniority"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/seniunija"></see>
    /// </summary>
    let seniunija = _prefix "seniunija"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sentence"></see>
    /// </summary>
    let sentence = _prefix "sentence"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/series"></see>
    /// </summary>
    let series = _prefix "series"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/service"></see>
    /// </summary>
    let service = _prefix "service"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/serviceEndDate"></see>
    /// </summary>
    let serviceEndDate = _prefix "serviceEndDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/serviceEndYear"></see>
    /// </summary>
    let serviceEndYear = _prefix "serviceEndYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/serviceModule"></see>
    /// </summary>
    let serviceModule = _prefix "serviceModule"
    /// <summary>
    /// The service number held by the individual during military service.
    /// <see href="http://dbpedia.org/ontology/serviceNumber"></see></summary>
    let serviceNumber = _prefix "serviceNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/serviceStartDate"></see>
    /// </summary>
    let serviceStartDate = _prefix "serviceStartDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/serviceStartYear"></see>
    /// </summary>
    let serviceStartYear = _prefix "serviceStartYear"
    /// <summary>
    /// Railway services that serve the station.
    /// <see href="http://dbpedia.org/ontology/servingRailwayLine"></see></summary>
    let servingRailwayLine = _prefix "servingRailwayLine"
    /// <summary>
    /// Default serving size (eg "100 g" for the standard 100 g serving size). approximateCalories apply to this serving size
    /// <see href="http://dbpedia.org/ontology/servingSize"></see></summary>
    let servingSize = _prefix "servingSize"
    /// <summary>
    /// Serving temperature for the food (e.g.: hot, cold, warm or room temperature).
    /// <see href="http://dbpedia.org/ontology/servingTemperature"></see></summary>
    let servingTemperature = _prefix "servingTemperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sessionNumber"></see>
    /// </summary>
    let sessionNumber = _prefix "sessionNumber"
    /// <summary>
    /// the person who is responsible for the film set design
    /// <see href="http://dbpedia.org/ontology/setDesigner"></see></summary>
    let setDesigner = _prefix "setDesigner"
    /// <summary>
    /// The places and time where the play takes place.
    /// <see href="http://dbpedia.org/ontology/settingOfPlay"></see></summary>
    let settingOfPlay = _prefix "settingOfPlay"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/settlement"></see>
    /// </summary>
    let settlement = _prefix "settlement"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/settlementAttached"></see>
    /// </summary>
    let settlementAttached = _prefix "settlementAttached"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/setupTime"></see>
    /// </summary>
    let setupTime = _prefix "setupTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sex"></see>
    /// </summary>
    let sex = _prefix "sex"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sexualOrientation"></see>
    /// </summary>
    let sexualOrientation = _prefix "sexualOrientation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shape"></see>
    /// </summary>
    let shape = _prefix "shape"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shareDate"></see>
    /// </summary>
    let shareDate = _prefix "shareDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shareOfAudience"></see>
    /// </summary>
    let shareOfAudience = _prefix "shareOfAudience"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shareSource"></see>
    /// </summary>
    let shareSource = _prefix "shareSource"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sharingOutPopulation"></see>
    /// </summary>
    let sharingOutPopulation = _prefix "sharingOutPopulation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sharingOutPopulationYear"></see>
    /// </summary>
    let sharingOutPopulationYear = _prefix "sharingOutPopulationYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sheading"></see>
    /// </summary>
    let sheading = _prefix "sheading"
    /// <summary>
    /// The beam of a ship is its width at the widest point.
    /// <see href="http://dbpedia.org/ontology/shipBeam"></see></summary>
    let shipBeam = _prefix "shipBeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shipCrew"></see>
    /// </summary>
    let shipCrew = _prefix "shipCrew"
    /// <summary>
    /// A ship's displacement is its mass at any given time.
    /// <see href="http://dbpedia.org/ontology/shipDisplacement"></see></summary>
    let shipDisplacement = _prefix "shipDisplacement"
    /// <summary>
    /// The draft (or draught) of a ship's hull is the vertical distance between the waterline and the bottom of the hull (keel), with the thickness of the hull included; in the case of not being included the draft outline would be obtained.
    /// <see href="http://dbpedia.org/ontology/shipDraft"></see></summary>
    let shipDraft = _prefix "shipDraft"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shipLaunch"></see>
    /// </summary>
    let shipLaunch = _prefix "shipLaunch"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shoeNumber"></see>
    /// </summary>
    let shoeNumber = _prefix "shoeNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shoeSize"></see>
    /// </summary>
    let shoeSize = _prefix "shoeSize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shoot"></see>
    /// </summary>
    let shoot = _prefix "shoot"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shoots"></see>
    /// </summary>
    let shoots = _prefix "shoots"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shoreLength"></see>
    /// </summary>
    let shoreLength = _prefix "shoreLength"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shortProgCompetition"></see>
    /// </summary>
    let shortProgCompetition = _prefix "shortProgCompetition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shortProgScore"></see>
    /// </summary>
    let shortProgScore = _prefix "shortProgScore"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/show"></see>
    /// </summary>
    let show = _prefix "show"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/showJudge"></see>
    /// </summary>
    let showJudge = _prefix "showJudge"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shuttle"></see>
    /// </summary>
    let shuttle = _prefix "shuttle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sibling"></see>
    /// </summary>
    let sibling = _prefix "sibling"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/signName"></see>
    /// </summary>
    let signName = _prefix "signName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/signature"></see>
    /// </summary>
    let signature = _prefix "signature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/significantBuilding"></see>
    /// </summary>
    let significantBuilding = _prefix "significantBuilding"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/significantDesign"></see>
    /// </summary>
    let significantDesign = _prefix "significantDesign"
    /// <summary>
    /// A siginificant artifact constructed by the person.
    /// <see href="http://dbpedia.org/ontology/significantProject"></see></summary>
    let significantProject = _prefix "significantProject"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/silCode"></see>
    /// </summary>
    let silCode = _prefix "silCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/silverMedalDouble"></see>
    /// </summary>
    let silverMedalDouble = _prefix "silverMedalDouble"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/silverMedalMixed"></see>
    /// </summary>
    let silverMedalMixed = _prefix "silverMedalMixed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/silverMedalSingle"></see>
    /// </summary>
    let silverMedalSingle = _prefix "silverMedalSingle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/silverMedalist"></see>
    /// </summary>
    let silverMedalist = _prefix "silverMedalist"
    /// <summary>
    /// indexing code used by the Polish National Official Register of the Territorial Division of the Country (TERYT) to identify various entities
    /// <see href="http://dbpedia.org/ontology/simcCode"></see></summary>
    let simcCode = _prefix "simcCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/similar"></see>
    /// </summary>
    let similar = _prefix "similar"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sire"></see>
    /// </summary>
    let sire = _prefix "sire"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/siren"></see>
    /// </summary>
    let siren = _prefix "siren"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sisterCollege"></see>
    /// </summary>
    let sisterCollege = _prefix "sisterCollege"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sisterNewspaper"></see>
    /// </summary>
    let sisterNewspaper = _prefix "sisterNewspaper"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sisterStation"></see>
    /// </summary>
    let sisterStation = _prefix "sisterStation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sixthFormStudents"></see>
    /// </summary>
    let sixthFormStudents = _prefix "sixthFormStudents"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sizeBlazon"></see>
    /// </summary>
    let sizeBlazon = _prefix "sizeBlazon"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sizeLogo"></see>
    /// </summary>
    let sizeLogo = _prefix "sizeLogo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sizeMap"></see>
    /// </summary>
    let sizeMap = _prefix "sizeMap"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sizeThumbnail"></see>
    /// </summary>
    let sizeThumbnail = _prefix "sizeThumbnail"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/size_v"></see>
    /// </summary>
    let size_v = _prefix "size_v"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/skiLift"></see>
    /// </summary>
    let skiLift = _prefix "skiLift"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/skiPisteKilometre"></see>
    /// </summary>
    let skiPisteKilometre = _prefix "skiPisteKilometre"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/skiPisteNumber"></see>
    /// </summary>
    let skiPisteNumber = _prefix "skiPisteNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/skiTow"></see>
    /// </summary>
    let skiTow = _prefix "skiTow"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/skills"></see>
    /// </summary>
    let skills = _prefix "skills"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/skinColor"></see>
    /// </summary>
    let skinColor = _prefix "skinColor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/slogan"></see>
    /// </summary>
    let slogan = _prefix "slogan"
    /// <summary>
    /// The Simplified Molecular-Input Line-Entry System or SMILES is a specification in form of a line notation for describing the structure of chemical molecules using short ASCII strings.
    /// <see href="http://dbpedia.org/ontology/smiles"></see></summary>
    let smiles = _prefix "smiles"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/snowParkNumber"></see>
    /// </summary>
    let snowParkNumber = _prefix "snowParkNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerLeaguePromoted"></see>
    /// </summary>
    let soccerLeaguePromoted = _prefix "soccerLeaguePromoted"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerLeagueRelegated"></see>
    /// </summary>
    let soccerLeagueRelegated = _prefix "soccerLeagueRelegated"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerLeagueSeason"></see>
    /// </summary>
    let soccerLeagueSeason = _prefix "soccerLeagueSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerLeagueWinner"></see>
    /// </summary>
    let soccerLeagueWinner = _prefix "soccerLeagueWinner"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentClosingSeason"></see>
    /// </summary>
    let soccerTournamentClosingSeason = _prefix "soccerTournamentClosingSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentLastChampion"></see>
    /// </summary>
    let soccerTournamentLastChampion = _prefix "soccerTournamentLastChampion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentMostSteady"></see>
    /// </summary>
    let soccerTournamentMostSteady = _prefix "soccerTournamentMostSteady"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentMostSuccesfull"></see>
    /// </summary>
    let soccerTournamentMostSuccesfull = _prefix "soccerTournamentMostSuccesfull"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentOpeningSeason"></see>
    /// </summary>
    let soccerTournamentOpeningSeason = _prefix "soccerTournamentOpeningSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentThisSeason"></see>
    /// </summary>
    let soccerTournamentThisSeason = _prefix "soccerTournamentThisSeason"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentTopScorer"></see>
    /// </summary>
    let soccerTournamentTopScorer = _prefix "soccerTournamentTopScorer"
    /// <summary>
    /// high-ranking solicitor
    /// <see href="http://dbpedia.org/ontology/solicitorGeneral"></see></summary>
    let solicitorGeneral = _prefix "solicitorGeneral"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/solubility"></see>
    /// </summary>
    let solubility = _prefix "solubility"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/solventWithBadSolubility"></see>
    /// </summary>
    let solventWithBadSolubility = _prefix "solventWithBadSolubility"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/solventWithGoodSolubility"></see>
    /// </summary>
    let solventWithGoodSolubility = _prefix "solventWithGoodSolubility"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/solventWithMediocreSolubility"></see>
    /// </summary>
    let solventWithMediocreSolubility = _prefix "solventWithMediocreSolubility"
    /// <summary>
    /// Sound recording somehow related to the subject
    /// <see href="http://dbpedia.org/ontology/soundRecording"></see></summary>
    let soundRecording = _prefix "soundRecording"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/source"></see>
    /// </summary>
    let source = _prefix "source"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluence"></see>
    /// </summary>
    let sourceConfluence = _prefix "sourceConfluence"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluenceCountry"></see>
    /// </summary>
    let sourceConfluenceCountry = _prefix "sourceConfluenceCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluenceElevation"></see>
    /// </summary>
    let sourceConfluenceElevation = _prefix "sourceConfluenceElevation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluenceMountain"></see>
    /// </summary>
    let sourceConfluenceMountain = _prefix "sourceConfluenceMountain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluencePlace"></see>
    /// </summary>
    let sourceConfluencePlace = _prefix "sourceConfluencePlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluencePosition"></see>
    /// </summary>
    let sourceConfluencePosition = _prefix "sourceConfluencePosition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluenceRegion"></see>
    /// </summary>
    let sourceConfluenceRegion = _prefix "sourceConfluenceRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluenceState"></see>
    /// </summary>
    let sourceConfluenceState = _prefix "sourceConfluenceState"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceCountry"></see>
    /// </summary>
    let sourceCountry = _prefix "sourceCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceDistrict"></see>
    /// </summary>
    let sourceDistrict = _prefix "sourceDistrict"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceElevation"></see>
    /// </summary>
    let sourceElevation = _prefix "sourceElevation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceMountain"></see>
    /// </summary>
    let sourceMountain = _prefix "sourceMountain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourcePlace"></see>
    /// </summary>
    let sourcePlace = _prefix "sourcePlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourcePosition"></see>
    /// </summary>
    let sourcePosition = _prefix "sourcePosition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceRegion"></see>
    /// </summary>
    let sourceRegion = _prefix "sourceRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceState"></see>
    /// </summary>
    let sourceState = _prefix "sourceState"
    /// <summary>
    /// Source of something (eg an image) as text. Use dct:source if the source is described using a resource
    /// <see href="http://dbpedia.org/ontology/sourceText"></see></summary>
    let sourceText = _prefix "sourceText"
    /// <summary>
    /// indicates another place situated south-east.
    /// <see href="http://dbpedia.org/ontology/southEastPlace"></see></summary>
    let southEastPlace = _prefix "southEastPlace"
    /// <summary>
    /// indicates another place situated south.
    /// <see href="http://dbpedia.org/ontology/southPlace"></see></summary>
    let southPlace = _prefix "southPlace"
    /// <summary>
    /// indicates another place situated south-west.
    /// <see href="http://dbpedia.org/ontology/southWestPlace"></see></summary>
    let southWestPlace = _prefix "southWestPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sovereignCountry"></see>
    /// </summary>
    let sovereignCountry = _prefix "sovereignCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/space"></see>
    /// </summary>
    let space = _prefix "space"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spacecraft"></see>
    /// </summary>
    let spacecraft = _prefix "spacecraft"
    /// <summary>
    /// space station that has been visited during a space mission
    /// <see href="http://dbpedia.org/ontology/spacestation"></see></summary>
    let spacestation = _prefix "spacestation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spacewalkBegin"></see>
    /// </summary>
    let spacewalkBegin = _prefix "spacewalkBegin"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spacewalkEnd"></see>
    /// </summary>
    let spacewalkEnd = _prefix "spacewalkEnd"
    /// <summary>
    /// number of office holder
    /// <see href="http://dbpedia.org/ontology/speaker"></see></summary>
    let speaker = _prefix "speaker"
    /// <summary>
    /// the person who is responsible for the film special effects
    /// <see href="http://dbpedia.org/ontology/specialEffects"></see></summary>
    let specialEffects = _prefix "specialEffects"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/specialTrial"></see>
    /// </summary>
    let specialTrial = _prefix "specialTrial"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/specialist"></see>
    /// </summary>
    let specialist = _prefix "specialist"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/speciality"></see>
    /// </summary>
    let speciality = _prefix "speciality"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/species"></see>
    /// </summary>
    let species = _prefix "species"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/speedLimit"></see>
    /// </summary>
    let speedLimit = _prefix "speedLimit"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spike"></see>
    /// </summary>
    let spike = _prefix "spike"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/splitFromParty"></see>
    /// </summary>
    let splitFromParty = _prefix "splitFromParty"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spokenIn"></see>
    /// </summary>
    let spokenIn = _prefix "spokenIn"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spokesperson"></see>
    /// </summary>
    let spokesperson = _prefix "spokesperson"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sport"></see>
    /// </summary>
    let sport = _prefix "sport"
    /// <summary>
    /// The country, for which the athlete is participating in championships
    /// <see href="http://dbpedia.org/ontology/sportCountry"></see></summary>
    let sportCountry = _prefix "sportCountry"
    /// <summary>
    /// the sport discipline the athlete practices, e.g. Diving, or that a board member of a sporting club is focussing at
    /// <see href="http://dbpedia.org/ontology/sportDiscipline"></see></summary>
    let sportDiscipline = _prefix "sportDiscipline"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sportGoverningBody"></see>
    /// </summary>
    let sportGoverningBody = _prefix "sportGoverningBody"
    /// <summary>
    /// the sport specialty the athlete practices, e.g. 'Ring' for a men's artistic gymnastics athlete
    /// <see href="http://dbpedia.org/ontology/sportSpecialty"></see></summary>
    let sportSpecialty = _prefix "sportSpecialty"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sportsFunction"></see>
    /// </summary>
    let sportsFunction = _prefix "sportsFunction"
    /// <summary>
    /// the person they are married to
    /// <see href="http://dbpedia.org/ontology/spouse"></see></summary>
    let spouse = _prefix "spouse"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spouseName"></see>
    /// </summary>
    let spouseName = _prefix "spouseName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spurOf"></see>
    /// </summary>
    let spurOf = _prefix "spurOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spurType"></see>
    /// </summary>
    let spurType = _prefix "spurType"
    /// <summary>
    /// The number that an athlete wears in a team sport.
    /// <see href="http://dbpedia.org/ontology/squadNumber"></see></summary>
    let squadNumber = _prefix "squadNumber"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stadium"></see>
    /// </summary>
    let stadium = _prefix "stadium"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/staff"></see>
    /// </summary>
    let staff = _prefix "staff"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/starRating"></see>
    /// </summary>
    let starRating = _prefix "starRating"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/starring"></see>
    /// </summary>
    let starring = _prefix "starring"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/start"></see>
    /// </summary>
    let start = _prefix "start"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startCareer"></see>
    /// </summary>
    let startCareer = _prefix "startCareer"
    /// <summary>
    /// The start date of the event.
    /// <see href="http://dbpedia.org/ontology/startDate"></see></summary>
    let startDate = _prefix "startDate"
    /// <summary>
    /// The start date and time of the event.
    /// <see href="http://dbpedia.org/ontology/startDateTime"></see></summary>
    let startDateTime = _prefix "startDateTime"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startOccupation"></see>
    /// </summary>
    let startOccupation = _prefix "startOccupation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startPoint"></see>
    /// </summary>
    let startPoint = _prefix "startPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startReign"></see>
    /// </summary>
    let startReign = _prefix "startReign"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startWct"></see>
    /// </summary>
    let startWct = _prefix "startWct"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startWqs"></see>
    /// </summary>
    let startWqs = _prefix "startWqs"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startYear"></see>
    /// </summary>
    let startYear = _prefix "startYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startYearOfInsertion"></see>
    /// </summary>
    let startYearOfInsertion = _prefix "startYearOfInsertion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startYearOfSales"></see>
    /// </summary>
    let startYearOfSales = _prefix "startYearOfSales"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statName"></see>
    /// </summary>
    let statName = _prefix "statName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statValue"></see>
    /// </summary>
    let statValue = _prefix "statValue"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/state"></see>
    /// </summary>
    let state = _prefix "state"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stateDelegate"></see>
    /// </summary>
    let stateDelegate = _prefix "stateDelegate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stateOfOrigin"></see>
    /// </summary>
    let stateOfOrigin = _prefix "stateOfOrigin"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stateOfOriginPoint"></see>
    /// </summary>
    let stateOfOriginPoint = _prefix "stateOfOriginPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stateOfOriginTeam"></see>
    /// </summary>
    let stateOfOriginTeam = _prefix "stateOfOriginTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stateOfOriginYear"></see>
    /// </summary>
    let stateOfOriginYear = _prefix "stateOfOriginYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stationEvaDuration"></see>
    /// </summary>
    let stationEvaDuration = _prefix "stationEvaDuration"
    /// <summary>
    /// Type of station structure (underground, at-grade, or elevated).
    /// <see href="http://dbpedia.org/ontology/stationStructure"></see></summary>
    let stationStructure = _prefix "stationStructure"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stationVisitDuration"></see>
    /// </summary>
    let stationVisitDuration = _prefix "stationVisitDuration"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statistic"></see>
    /// </summary>
    let statistic = _prefix "statistic"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statisticLabel"></see>
    /// </summary>
    let statisticLabel = _prefix "statisticLabel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statisticValue"></see>
    /// </summary>
    let statisticValue = _prefix "statisticValue"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statisticYear"></see>
    /// </summary>
    let statisticYear = _prefix "statisticYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/status"></see>
    /// </summary>
    let status = _prefix "status"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statusManager"></see>
    /// </summary>
    let statusManager = _prefix "statusManager"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statusYear"></see>
    /// </summary>
    let statusYear = _prefix "statusYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stellarClassification"></see>
    /// </summary>
    let stellarClassification = _prefix "stellarClassification"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stockExchange"></see>
    /// </summary>
    let stockExchange = _prefix "stockExchange"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/storyEditor"></see>
    /// </summary>
    let storyEditor = _prefix "storyEditor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/strength"></see>
    /// </summary>
    let strength = _prefix "strength"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/structuralSystem"></see>
    /// </summary>
    let structuralSystem = _prefix "structuralSystem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/student"></see>
    /// </summary>
    let student = _prefix "student"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/style"></see>
    /// </summary>
    let style = _prefix "style"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stylisticOrigin"></see>
    /// </summary>
    let stylisticOrigin = _prefix "stylisticOrigin"
    /// <summary>
    /// a subdivision within a Species classis
    /// <see href="http://dbpedia.org/ontology/subClassis"></see></summary>
    let subClassis = _prefix "subClassis"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subFamily"></see>
    /// </summary>
    let subFamily = _prefix "subFamily"
    /// <summary>
    /// A rank in the classification of organisms, below genus ; a taxon at that rank
    /// <see href="http://dbpedia.org/ontology/subGenus"></see></summary>
    let subGenus = _prefix "subGenus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subMunicipalityType"></see>
    /// </summary>
    let subMunicipalityType = _prefix "subMunicipalityType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subOrder"></see>
    /// </summary>
    let subOrder = _prefix "subOrder"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subPrefecture"></see>
    /// </summary>
    let subPrefecture = _prefix "subPrefecture"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subTribus"></see>
    /// </summary>
    let subTribus = _prefix "subTribus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Tribus"></see>
    /// </summary>
    let Tribus = _prefix "Tribus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subdivision"></see>
    /// </summary>
    let subdivision = _prefix "subdivision"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subdivisionLink"></see>
    /// </summary>
    let subdivisionLink = _prefix "subdivisionLink"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subdivisionName"></see>
    /// </summary>
    let subdivisionName = _prefix "subdivisionName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subdivisions"></see>
    /// </summary>
    let subdivisions = _prefix "subdivisions"
    /// <summary>
    /// The overall subject matter dealt with by the play.
    /// <see href="http://dbpedia.org/ontology/subjectOfPlay"></see></summary>
    let subjectOfPlay = _prefix "subjectOfPlay"
    /// <summary>
    /// The subject as a term, possibly a term from a formal classification
    /// <see href="http://dbpedia.org/ontology/subjectTerm"></see></summary>
    let subjectTerm = _prefix "subjectTerm"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sublimationPoint"></see>
    /// </summary>
    let sublimationPoint = _prefix "sublimationPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/suborbitalFlights"></see>
    /// </summary>
    let suborbitalFlights = _prefix "suborbitalFlights"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subprefecture"></see>
    /// </summary>
    let subprefecture = _prefix "subprefecture"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subregion"></see>
    /// </summary>
    let subregion = _prefix "subregion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subsequentInfrastructure"></see>
    /// </summary>
    let subsequentInfrastructure = _prefix "subsequentInfrastructure"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subsequentWork"></see>
    /// </summary>
    let subsequentWork = _prefix "subsequentWork"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subsidiary"></see>
    /// </summary>
    let subsidiary = _prefix "subsidiary"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subsystem"></see>
    /// </summary>
    let subsystem = _prefix "subsystem"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subsystemLink"></see>
    /// </summary>
    let subsystemLink = _prefix "subsystemLink"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subtitle"></see>
    /// </summary>
    let subtitle = _prefix "subtitle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/successfulLaunches"></see>
    /// </summary>
    let successfulLaunches = _prefix "successfulLaunches"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/successor"></see>
    /// </summary>
    let successor = _prefix "successor"
    /// <summary>
    /// Système universitaire de documentation id (French collaborative library catalog).
    /// http://www.idref.fr/$1
    /// <see href="http://dbpedia.org/ontology/sudocId"></see></summary>
    let sudocId = _prefix "sudocId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/summerAppearances"></see>
    /// </summary>
    let summerAppearances = _prefix "summerAppearances"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/summerTemperature"></see>
    /// </summary>
    let summerTemperature = _prefix "summerTemperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/superFamily"></see>
    /// </summary>
    let superFamily = _prefix "superFamily"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/superOrder"></see>
    /// </summary>
    let superOrder = _prefix "superOrder"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/superTribus"></see>
    /// </summary>
    let superTribus = _prefix "superTribus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/superbowlWin"></see>
    /// </summary>
    let superbowlWin = _prefix "superbowlWin"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/superintendent"></see>
    /// </summary>
    let superintendent = _prefix "superintendent"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/supplementalDraftRound"></see>
    /// </summary>
    let supplementalDraftRound = _prefix "supplementalDraftRound"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/supplementalDraftYear"></see>
    /// </summary>
    let supplementalDraftYear = _prefix "supplementalDraftYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/supplies"></see>
    /// </summary>
    let supplies = _prefix "supplies"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/supply"></see>
    /// </summary>
    let supply = _prefix "supply"
    /// <summary>
    /// Date when the Church forbade the veneration of this saint.
    /// (I hope that's what it means, I don't know why the original author didn't document it)
    /// <see href="http://dbpedia.org/ontology/suppreddedDate"></see></summary>
    let suppreddedDate = _prefix "suppreddedDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/surfaceArea"></see>
    /// </summary>
    let surfaceArea = _prefix "surfaceArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/surfaceFormOccurrenceOffset"></see>
    /// </summary>
    let surfaceFormOccurrenceOffset = _prefix "surfaceFormOccurrenceOffset"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/surfaceGravity"></see>
    /// </summary>
    let surfaceGravity = _prefix "surfaceGravity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/swimmingStyle"></see>
    /// </summary>
    let swimmingStyle = _prefix "swimmingStyle"
    /// <summary>
    /// HUGO Gene Symbol
    /// <see href="http://dbpedia.org/ontology/symbol"></see></summary>
    let symbol = _prefix "symbol"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/synonym"></see>
    /// </summary>
    let synonym = _prefix "synonym"
    /// <summary>
    /// A referral to the relevant system of law
    /// <see href="http://dbpedia.org/ontology/systemOfLaw"></see></summary>
    let systemOfLaw = _prefix "systemOfLaw"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/systemRequirements"></see>
    /// </summary>
    let systemRequirements = _prefix "systemRequirements"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tag"></see>
    /// </summary>
    let tag = _prefix "tag"
    /// <summary>
    /// head of government of Ireland
    /// <see href="http://dbpedia.org/ontology/taoiseach"></see></summary>
    let taoiseach = _prefix "taoiseach"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/targetAirport"></see>
    /// </summary>
    let targetAirport = _prefix "targetAirport"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/targetSpaceStation"></see>
    /// </summary>
    let targetSpaceStation = _prefix "targetSpaceStation"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/taste"></see>
    /// </summary>
    let taste = _prefix "taste"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tattoo"></see>
    /// </summary>
    let tattoo = _prefix "tattoo"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/taxon"></see>
    /// </summary>
    let taxon = _prefix "taxon"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teachingStaff"></see>
    /// </summary>
    let teachingStaff = _prefix "teachingStaff"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teamCoached"></see>
    /// </summary>
    let teamCoached = _prefix "teamCoached"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teamManager"></see>
    /// </summary>
    let teamManager = _prefix "teamManager"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teamName"></see>
    /// </summary>
    let teamName = _prefix "teamName"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teamPoint"></see>
    /// </summary>
    let teamPoint = _prefix "teamPoint"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teamSize"></see>
    /// </summary>
    let teamSize = _prefix "teamSize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teamTitle"></see>
    /// </summary>
    let teamTitle = _prefix "teamTitle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/technique"></see>
    /// </summary>
    let technique = _prefix "technique"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/televisionSeries"></see>
    /// </summary>
    let televisionSeries = _prefix "televisionSeries"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tempPlace"></see>
    /// </summary>
    let tempPlace = _prefix "tempPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/temperature"></see>
    /// </summary>
    let temperature = _prefix "temperature"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/temple"></see>
    /// </summary>
    let temple = _prefix "temple"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/templeYear"></see>
    /// </summary>
    let templeYear = _prefix "templeYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tenant"></see>
    /// </summary>
    let tenant = _prefix "tenant"
    /// <summary>
    /// There are five types of court surface used in professional play. Each surface is different in the speed and height of the bounce of the ball.
    /// <see href="http://dbpedia.org/ontology/tennisSurfaceType"></see></summary>
    let tennisSurfaceType = _prefix "tennisSurfaceType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/termOfOffice"></see>
    /// </summary>
    let termOfOffice = _prefix "termOfOffice"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/termPeriod"></see>
    /// </summary>
    let termPeriod = _prefix "termPeriod"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/territory"></see>
    /// </summary>
    let territory = _prefix "territory"

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryConflict,_AdministrativeRegion"></see>
    /// </summary>
    let ``MilitaryConflict,_AdministrativeRegion`` =
        _prefix "MilitaryConflict,_AdministrativeRegion"

    /// <summary>
    /// indexing code used by the Polish National Official Register of the Territorial Division of the Country (TERYT) to identify various entities
    /// <see href="http://dbpedia.org/ontology/terytCode"></see></summary>
    let terytCode = _prefix "terytCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tessitura"></see>
    /// </summary>
    let tessitura = _prefix "tessitura"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/testaverage"></see>
    /// </summary>
    let testaverage = _prefix "testaverage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/theology"></see>
    /// </summary>
    let theology = _prefix "theology"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/third"></see>
    /// </summary>
    let third = _prefix "third"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/thirdCommander"></see>
    /// </summary>
    let thirdCommander = _prefix "thirdCommander"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/thirdDriver"></see>
    /// </summary>
    let thirdDriver = _prefix "thirdDriver"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/thirdDriverCountry"></see>
    /// </summary>
    let thirdDriverCountry = _prefix "thirdDriverCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/thirdPlace"></see>
    /// </summary>
    let thirdPlace = _prefix "thirdPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/thirdTeam"></see>
    /// </summary>
    let thirdTeam = _prefix "thirdTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/throwingSide"></see>
    /// </summary>
    let throwingSide = _prefix "throwingSide"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/thumbnail"></see></summary>
    let thumbnail = _prefix "thumbnail"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/thumbnailCaption"></see>
    /// </summary>
    let thumbnailCaption = _prefix "thumbnailCaption"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tie"></see>
    /// </summary>
    let tie = _prefix "tie"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/time"></see>
    /// </summary>
    let time = _prefix "time"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/timeInSpace"></see>
    /// </summary>
    let timeInSpace = _prefix "timeInSpace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/timeZone"></see>
    /// </summary>
    let timeZone = _prefix "timeZone"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/timeshiftChannel"></see>
    /// </summary>
    let timeshiftChannel = _prefix "timeshiftChannel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/title"></see>
    /// </summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/titleDate"></see>
    /// </summary>
    let titleDate = _prefix "titleDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/titleDouble"></see>
    /// </summary>
    let titleDouble = _prefix "titleDouble"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/titleLanguage"></see>
    /// </summary>
    let titleLanguage = _prefix "titleLanguage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/titleSingle"></see>
    /// </summary>
    let titleSingle = _prefix "titleSingle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/toll"></see>
    /// </summary>
    let toll = _prefix "toll"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tonyAward"></see>
    /// </summary>
    let tonyAward = _prefix "tonyAward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/topFloorHeight"></see>
    /// </summary>
    let topFloorHeight = _prefix "topFloorHeight"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/topLevelDomain"></see>
    /// </summary>
    let topLevelDomain = _prefix "topLevelDomain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/topSpeed"></see>
    /// </summary>
    let topSpeed = _prefix "topSpeed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/topic"></see>
    /// </summary>
    let topic = _prefix "topic"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/torchBearer"></see>
    /// </summary>
    let torchBearer = _prefix "torchBearer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/torqueOutput"></see>
    /// </summary>
    let torqueOutput = _prefix "torqueOutput"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/totalCargo"></see>
    /// </summary>
    let totalCargo = _prefix "totalCargo"
    /// <summary>
    /// the total number of discs contained in the album
    /// <see href="http://dbpedia.org/ontology/totalDiscs"></see></summary>
    let totalDiscs = _prefix "totalDiscs"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/totalLaunches"></see>
    /// </summary>
    let totalLaunches = _prefix "totalLaunches"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/totalMass"></see>
    /// </summary>
    let totalMass = _prefix "totalMass"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/totalPopulation"></see>
    /// </summary>
    let totalPopulation = _prefix "totalPopulation"
    /// <summary>
    /// the total number of tracks contained in the album
    /// <see href="http://dbpedia.org/ontology/totalTracks"></see></summary>
    let totalTracks = _prefix "totalTracks"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/totalTravellers"></see>
    /// </summary>
    let totalTravellers = _prefix "totalTravellers"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/touristicSite"></see>
    /// </summary>
    let touristicSite = _prefix "touristicSite"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tournamentOfChampions"></see>
    /// </summary>
    let tournamentOfChampions = _prefix "tournamentOfChampions"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tournamentRecord"></see>
    /// </summary>
    let tournamentRecord = _prefix "tournamentRecord"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/towerHeight"></see>
    /// </summary>
    let towerHeight = _prefix "towerHeight"
    /// <summary>
    /// Length of the track. Wikipedians usually do not differentiate between track length and line lenght.
    /// <see href="http://dbpedia.org/ontology/trackLength"></see></summary>
    let trackLength = _prefix "trackLength"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/trackNumber"></see>
    /// </summary>
    let trackNumber = _prefix "trackNumber"
    /// <summary>
    /// Width of the track, e.g., the track width differing in Russia from (Western and Middle) European track width
    /// <see href="http://dbpedia.org/ontology/trackWidth"></see></summary>
    let trackWidth = _prefix "trackWidth"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tradeMark"></see>
    /// </summary>
    let tradeMark = _prefix "tradeMark"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/trainer"></see>
    /// </summary>
    let trainer = _prefix "trainer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/trainerClub"></see>
    /// </summary>
    let trainerClub = _prefix "trainerClub"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/trainerYears"></see>
    /// </summary>
    let trainerYears = _prefix "trainerYears"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/training"></see>
    /// </summary>
    let training = _prefix "training"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/translatedMotto"></see>
    /// </summary>
    let translatedMotto = _prefix "translatedMotto"
    /// <summary>
    /// Translator(s), if original not in English
    /// <see href="http://dbpedia.org/ontology/translator"></see></summary>
    let translator = _prefix "translator"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/transmission"></see>
    /// </summary>
    let transmission = _prefix "transmission"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tree"></see>
    /// </summary>
    let tree = _prefix "tree"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tribus"></see>
    /// </summary>
    let tribus = _prefix "tribus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/trustee"></see>
    /// </summary>
    let trustee = _prefix "trustee"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tu"></see>
    /// </summary>
    let tu = _prefix "tu"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tuition"></see>
    /// </summary>
    let tuition = _prefix "tuition"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tvComId"></see>
    /// </summary>
    let tvComId = _prefix "tvComId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tvShow"></see>
    /// </summary>
    let tvShow = _prefix "tvShow"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/twinCountry"></see>
    /// </summary>
    let twinCountry = _prefix "twinCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/twinTown"></see>
    /// </summary>
    let twinTown = _prefix "twinTown"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/type"></see>
    /// </summary>
    let type_ = _prefix "type"
    /// <summary>
    /// Scale parameters that can be understood by Geohack, eg "type:", "scale:", "region:" "altitude:". Use "_" for several (eg "type:landmark_scale:50000"). See https://fr.wikipedia.org/wiki/Modèle:Infobox_Subdivision_administrative for examples, and https://fr.wikipedia.org/wiki/Modèle:GeoTemplate/Utilisation#La_mention_Type:... for a complete list
    /// <see href="http://dbpedia.org/ontology/typeCoordinate"></see></summary>
    let typeCoordinate = _prefix "typeCoordinate"
    /// <summary>
    /// Electrification system (e.g. Third rail, Overhead catenary).
    /// <see href="http://dbpedia.org/ontology/typeOfElectrification"></see></summary>
    let typeOfElectrification = _prefix "typeOfElectrification"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/typeOfGrain"></see>
    /// </summary>
    let typeOfGrain = _prefix "typeOfGrain"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/typeOfStorage"></see>
    /// </summary>
    let typeOfStorage = _prefix "typeOfStorage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/typeOfYeast"></see>
    /// </summary>
    let typeOfYeast = _prefix "typeOfYeast"
    /// <summary>
    /// DfE unique reference number of a school in England or Wales
    /// <see href="http://dbpedia.org/ontology/uRN"></see></summary>
    let uRN = _prefix "uRN"
    /// <summary>
    /// Official UCI code for cycling teams
    /// <see href="http://dbpedia.org/ontology/uciCode"></see></summary>
    let uciCode = _prefix "uciCode"
    /// <summary>
    /// Union List of Artist Names id (Getty Research Institute). ULAN has 293,000 names and other information about artists. Names in ULAN may include given names, pseudonyms, variant spellings, names in multiple languages, and names that have changed over time (e.g., married names).
    /// http://vocab.getty.edu/ulan/$1
    /// <see href="http://dbpedia.org/ontology/ulanId"></see></summary>
    let ulanId = _prefix "ulanId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/umbrellaTitle"></see>
    /// </summary>
    let umbrellaTitle = _prefix "umbrellaTitle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/undraftedYear"></see>
    /// </summary>
    let undraftedYear = _prefix "undraftedYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/unesco"></see>
    /// </summary>
    let unesco = _prefix "unesco"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/unicode"></see>
    /// </summary>
    let unicode = _prefix "unicode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/uniprot"></see>
    /// </summary>
    let uniprot = _prefix "uniprot"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/unitCost"></see>
    /// </summary>
    let unitCost = _prefix "unitCost"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/unitaryAuthority"></see>
    /// </summary>
    let unitaryAuthority = _prefix "unitaryAuthority"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/unitedStatesNationalBridgeId"></see>
    /// </summary>
    let unitedStatesNationalBridgeId = _prefix "unitedStatesNationalBridgeId"
    /// <summary>
    /// university a person goes or went to.
    /// <see href="http://dbpedia.org/ontology/university"></see></summary>
    let university = _prefix "university"
    /// <summary>
    /// number of launches with unknown outcomes (or in progress)
    /// <see href="http://dbpedia.org/ontology/unknownOutcomes"></see></summary>
    let unknownOutcomes = _prefix "unknownOutcomes"
    /// <summary>
    /// UN/LOCODE, the United Nations Code for Trade and Transport Locations, is a geographic coding scheme developed and maintained by United Nations Economic Commission for Europe (UNECE), a unit of the United Nations. UN/LOCODE assigns codes to locations used in trade and transport  with functions such as seaports, rail and road terminals, airports, post offices and border crossing points.
    /// <see href="http://dbpedia.org/ontology/unloCode"></see></summary>
    let unloCode = _prefix "unloCode"
    /// <summary>
    /// The last update date of a resource
    /// <see href="http://dbpedia.org/ontology/updated"></see></summary>
    let updated = _prefix "updated"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/upperAge"></see>
    /// </summary>
    let upperAge = _prefix "upperAge"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/urbanArea"></see>
    /// </summary>
    let urbanArea = _prefix "urbanArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usOpenDouble"></see>
    /// </summary>
    let usOpenDouble = _prefix "usOpenDouble"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usOpenMixed"></see>
    /// </summary>
    let usOpenMixed = _prefix "usOpenMixed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usOpenSingle"></see>
    /// </summary>
    let usOpenSingle = _prefix "usOpenSingle"
    /// <summary>
    /// Number of things (eg vehicles) sold in the US
    /// <see href="http://dbpedia.org/ontology/usSales"></see></summary>
    let usSales = _prefix "usSales"
    /// <summary>
    /// wars that were typical for the usage of a weapon
    /// <see href="http://dbpedia.org/ontology/usedInWar"></see></summary>
    let usedInWar = _prefix "usedInWar"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usingCountry"></see>
    /// </summary>
    let usingCountry = _prefix "usingCountry"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usk"></see>
    /// </summary>
    let usk = _prefix "usk"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usopenWins"></see>
    /// </summary>
    let usopenWins = _prefix "usopenWins"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usurper"></see>
    /// </summary>
    let usurper = _prefix "usurper"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/utcOffset"></see>
    /// </summary>
    let utcOffset = _prefix "utcOffset"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/v_hb"></see>
    /// </summary>
    let v_hb = _prefix "v_hb"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/valvetrain"></see>
    /// </summary>
    let valvetrain = _prefix "valvetrain"
    /// <summary>
    /// variant or variation of something, for example the variant of a car
    /// <see href="http://dbpedia.org/ontology/variantOf"></see></summary>
    let variantOf = _prefix "variantOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/varietals"></see>
    /// </summary>
    let varietals = _prefix "varietals"
    /// <summary>
    /// vehicle that uses a specific automobile platform
    /// <see href="http://dbpedia.org/ontology/vehicle"></see></summary>
    let vehicle = _prefix "vehicle"
    /// <summary>
    /// Region related vehicle code on the vehicle plates.
    /// <see href="http://dbpedia.org/ontology/vehicleCode"></see></summary>
    let vehicleCode = _prefix "vehicleCode"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vehiclesPerDay"></see>
    /// </summary>
    let vehiclesPerDay = _prefix "vehiclesPerDay"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vein"></see>
    /// </summary>
    let vein = _prefix "vein"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/veneratedIn"></see>
    /// </summary>
    let veneratedIn = _prefix "veneratedIn"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/version"></see>
    /// </summary>
    let version = _prefix "version"
    /// <summary>
    /// Virtual International Authority File ID (operated by Online Computer Library Center, OCLC). Property range set to Agent because of corporate authors
    /// <see href="http://dbpedia.org/ontology/viafId"></see></summary>
    let viafId = _prefix "viafId"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/viceChancellor"></see>
    /// </summary>
    let viceChancellor = _prefix "viceChancellor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/viceLeader"></see>
    /// </summary>
    let viceLeader = _prefix "viceLeader"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/viceLeaderParty"></see>
    /// </summary>
    let viceLeaderParty = _prefix "viceLeaderParty"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vicePresident"></see>
    /// </summary>
    let vicePresident = _prefix "vicePresident"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vicePrimeMinister"></see>
    /// </summary>
    let vicePrimeMinister = _prefix "vicePrimeMinister"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vicePrincipal"></see>
    /// </summary>
    let vicePrincipal = _prefix "vicePrincipal"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vicePrincipalLabel"></see>
    /// </summary>
    let vicePrincipalLabel = _prefix "vicePrincipalLabel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/victim"></see>
    /// </summary>
    let victim = _prefix "victim"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/victory"></see>
    /// </summary>
    let victory = _prefix "victory"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/victoryAsMgr"></see>
    /// </summary>
    let victoryAsMgr = _prefix "victoryAsMgr"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/victoryPercentageAsMgr"></see>
    /// </summary>
    let victoryPercentageAsMgr = _prefix "victoryPercentageAsMgr"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/virtualChannel"></see>
    /// </summary>
    let virtualChannel = _prefix "virtualChannel"
    /// <summary>
    /// Year visitor information was gathered.
    /// <see href="http://dbpedia.org/ontology/visitorStatisticsAsOf"></see></summary>
    let visitorStatisticsAsOf = _prefix "visitorStatisticsAsOf"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/visitorsPerDay"></see>
    /// </summary>
    let visitorsPerDay = _prefix "visitorsPerDay"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/visitorsPerYear"></see>
    /// </summary>
    let visitorsPerYear = _prefix "visitorsPerYear"
    /// <summary>
    /// Percentage increase or decrease.
    /// <see href="http://dbpedia.org/ontology/visitorsPercentageChange"></see></summary>
    let visitorsPercentageChange = _prefix "visitorsPercentageChange"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/visitorsTotal"></see>
    /// </summary>
    let visitorsTotal = _prefix "visitorsTotal"
    /// <summary>
    /// Voice artist used in a TelevisionShow, Movie, or to sound the voice of a FictionalCharacter
    /// <see href="http://dbpedia.org/ontology/voice"></see></summary>
    let voice = _prefix "voice"
    /// <summary>
    /// voice type of a singer or an actor
    /// <see href="http://dbpedia.org/ontology/voiceType"></see></summary>
    let voiceType = _prefix "voiceType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/volcanicActivity"></see>
    /// </summary>
    let volcanicActivity = _prefix "volcanicActivity"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/volcanicType"></see>
    /// </summary>
    let volcanicType = _prefix "volcanicType"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/volcanoId"></see>
    /// </summary>
    let volcanoId = _prefix "volcanoId"
    /// <summary>
    /// Voltage of the electrification system.
    /// <see href="http://dbpedia.org/ontology/voltageOfElectrification"></see></summary>
    let voltageOfElectrification = _prefix "voltageOfElectrification"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/volume"></see>
    /// </summary>
    let volume = _prefix "volume"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/volumeQuote"></see>
    /// </summary>
    let volumeQuote = _prefix "volumeQuote"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/volumes"></see>
    /// </summary>
    let volumes = _prefix "volumes"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vonKlitzingConstant"></see>
    /// </summary>
    let vonKlitzingConstant = _prefix "vonKlitzingConstant"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/votesAgainst"></see>
    /// </summary>
    let votesAgainst = _prefix "votesAgainst"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/votesFor"></see>
    /// </summary>
    let votesFor = _prefix "votesFor"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wagon"></see>
    /// </summary>
    let wagon = _prefix "wagon"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/waistSize"></see>
    /// </summary>
    let waistSize = _prefix "waistSize"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/war"></see>
    /// </summary>
    let war = _prefix "war"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ward"></see>
    /// </summary>
    let ward = _prefix "ward"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/water"></see>
    /// </summary>
    let water = _prefix "water"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/waterArea"></see>
    /// </summary>
    let waterArea = _prefix "waterArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/waterPercentage"></see>
    /// </summary>
    let waterPercentage = _prefix "waterPercentage"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/watercourse"></see>
    /// </summary>
    let watercourse = _prefix "watercourse"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/watershed"></see>
    /// </summary>
    let watershed = _prefix "watershed"
    /// <summary>
    /// Waterway that goes through the tunnel.
    /// <see href="http://dbpedia.org/ontology/waterwayThroughTunnel"></see></summary>
    let waterwayThroughTunnel = _prefix "waterwayThroughTunnel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wavelength"></see>
    /// </summary>
    let wavelength = _prefix "wavelength"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/weapon"></see>
    /// </summary>
    let weapon = _prefix "weapon"
    /// <summary>
    /// The URL to the webcast of the Thing.
    /// <see href="http://dbpedia.org/ontology/webcast"></see></summary>
    let webcast = _prefix "webcast"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/websiteLabel"></see>
    /// </summary>
    let websiteLabel = _prefix "websiteLabel"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/weddingParentsDate"></see>
    /// </summary>
    let weddingParentsDate = _prefix "weddingParentsDate"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/weight"></see>
    /// </summary>
    let weight = _prefix "weight"
    /// <summary>
    /// indicates another place situated west.
    /// <see href="http://dbpedia.org/ontology/westPlace"></see></summary>
    let westPlace = _prefix "westPlace"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/whaDraft"></see>
    /// </summary>
    let whaDraft = _prefix "whaDraft"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/whaDraftTeam"></see>
    /// </summary>
    let whaDraftTeam = _prefix "whaDraftTeam"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/whaDraftYear"></see>
    /// </summary>
    let whaDraftYear = _prefix "whaDraftYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wheelbase"></see>
    /// </summary>
    let wheelbase = _prefix "wheelbase"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wholeArea"></see>
    /// </summary>
    let wholeArea = _prefix "wholeArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/width"></see>
    /// </summary>
    let width = _prefix "width"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/widthQuote"></see>
    /// </summary>
    let widthQuote = _prefix "widthQuote"
    /// <summary>
    /// Needs to be removed, left at the moment to not break DBpedia Live
    /// <see href="http://dbpedia.org/ontology/wikiPageCharacterSize"></see></summary>
    let wikiPageCharacterSize = _prefix "wikiPageCharacterSize"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageDisambiguates"></see></summary>
    let wikiPageDisambiguates = _prefix "wikiPageDisambiguates"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageEditLink"></see></summary>
    let wikiPageEditLink = _prefix "wikiPageEditLink"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageExternalLink"></see></summary>
    let wikiPageExternalLink = _prefix "wikiPageExternalLink"
    /// <summary>
    /// Date a page was extracted ''''''
    /// <see href="http://dbpedia.org/ontology/wikiPageExtracted"></see></summary>
    let wikiPageExtracted = _prefix "wikiPageExtracted"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageHistoryLink"></see></summary>
    let wikiPageHistoryLink = _prefix "wikiPageHistoryLink"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageID"></see></summary>
    let wikiPageID = _prefix "wikiPageID"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageInDegree"></see></summary>
    let wikiPageInDegree = _prefix "wikiPageInDegree"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageInterLanguageLink"></see></summary>
    let wikiPageInterLanguageLink = _prefix "wikiPageInterLanguageLink"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageLength"></see></summary>
    let wikiPageLength = _prefix "wikiPageLength"
    /// <summary>
    /// Reserved for DBpedia ''''''
    /// <see href="http://dbpedia.org/ontology/wikiPageModified"></see></summary>
    let wikiPageModified = _prefix "wikiPageModified"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageOutDegree"></see></summary>
    let wikiPageOutDegree = _prefix "wikiPageOutDegree"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageRedirects"></see></summary>
    let wikiPageRedirects = _prefix "wikiPageRedirects"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageRevisionID"></see></summary>
    let wikiPageRevisionID = _prefix "wikiPageRevisionID"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageRevisionLink"></see></summary>
    let wikiPageRevisionLink = _prefix "wikiPageRevisionLink"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageWikiLink"></see></summary>
    let wikiPageWikiLink = _prefix "wikiPageWikiLink"
    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageWikiLinkText"></see></summary>
    let wikiPageWikiLinkText = _prefix "wikiPageWikiLinkText"
    /// <summary>
    /// is used to denote splitting of a Wikidata IRI to one or more IRIs
    /// <see href="http://dbpedia.org/ontology/wikidataSplitIri"></see></summary>
    let wikidataSplitIri = _prefix "wikidataSplitIri"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wilaya"></see>
    /// </summary>
    let wilaya = _prefix "wilaya"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wimbledonDouble"></see>
    /// </summary>
    let wimbledonDouble = _prefix "wimbledonDouble"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wimbledonMixed"></see>
    /// </summary>
    let wimbledonMixed = _prefix "wimbledonMixed"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wimbledonSingle"></see>
    /// </summary>
    let wimbledonSingle = _prefix "wimbledonSingle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wineProduced"></see>
    /// </summary>
    let wineProduced = _prefix "wineProduced"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wineRegion"></see>
    /// </summary>
    let wineRegion = _prefix "wineRegion"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wineYear"></see>
    /// </summary>
    let wineYear = _prefix "wineYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wingArea"></see>
    /// </summary>
    let wingArea = _prefix "wingArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wingspan"></see>
    /// </summary>
    let wingspan = _prefix "wingspan"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wins"></see>
    /// </summary>
    let wins = _prefix "wins"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtAlpg"></see>
    /// </summary>
    let winsAtAlpg = _prefix "winsAtAlpg"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtAsia"></see>
    /// </summary>
    let winsAtAsia = _prefix "winsAtAsia"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtAus"></see>
    /// </summary>
    let winsAtAus = _prefix "winsAtAus"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtChallenges"></see>
    /// </summary>
    let winsAtChallenges = _prefix "winsAtChallenges"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtChampionships"></see>
    /// </summary>
    let winsAtChampionships = _prefix "winsAtChampionships"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtJLPGA"></see>
    /// </summary>
    let winsAtJLPGA = _prefix "winsAtJLPGA"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtJapan"></see>
    /// </summary>
    let winsAtJapan = _prefix "winsAtJapan"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtKLPGA"></see>
    /// </summary>
    let winsAtKLPGA = _prefix "winsAtKLPGA"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtLAGT"></see>
    /// </summary>
    let winsAtLAGT = _prefix "winsAtLAGT"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtLET"></see>
    /// </summary>
    let winsAtLET = _prefix "winsAtLET"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtLPGA"></see>
    /// </summary>
    let winsAtLPGA = _prefix "winsAtLPGA"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtMajors"></see>
    /// </summary>
    let winsAtMajors = _prefix "winsAtMajors"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtNWIDE"></see>
    /// </summary>
    let winsAtNWIDE = _prefix "winsAtNWIDE"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtOtherTournaments"></see>
    /// </summary>
    let winsAtOtherTournaments = _prefix "winsAtOtherTournaments"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtPGA"></see>
    /// </summary>
    let winsAtPGA = _prefix "winsAtPGA"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtProTournaments"></see>
    /// </summary>
    let winsAtProTournaments = _prefix "winsAtProTournaments"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtSenEuro"></see>
    /// </summary>
    let winsAtSenEuro = _prefix "winsAtSenEuro"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtSun"></see>
    /// </summary>
    let winsAtSun = _prefix "winsAtSun"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsInEurope"></see>
    /// </summary>
    let winsInEurope = _prefix "winsInEurope"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winterAppearances"></see>
    /// </summary>
    let winterAppearances = _prefix "winterAppearances"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winterTemperature"></see>
    /// </summary>
    let winterTemperature = _prefix "winterTemperature"
    /// <summary>
    /// World Register of Marine Species
    /// <see href="http://dbpedia.org/ontology/woRMS"></see></summary>
    let woRMS = _prefix "woRMS"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wordBefore"></see>
    /// </summary>
    let wordBefore = _prefix "wordBefore"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/work"></see>
    /// </summary>
    let work = _prefix "work"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/workArea"></see>
    /// </summary>
    let workArea = _prefix "workArea"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/world"></see>
    /// </summary>
    let world = _prefix "world"
    /// <summary>
    /// can be one or several years
    /// <see href="http://dbpedia.org/ontology/worldChampionTitleYear"></see></summary>
    let worldChampionTitleYear = _prefix "worldChampionTitleYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worldOpen"></see>
    /// </summary>
    let worldOpen = _prefix "worldOpen"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worldTeamCup"></see>
    /// </summary>
    let worldTeamCup = _prefix "worldTeamCup"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worldTournament"></see>
    /// </summary>
    let worldTournament = _prefix "worldTournament"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worldTournamentBronze"></see>
    /// </summary>
    let worldTournamentBronze = _prefix "worldTournamentBronze"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worldTournamentGold"></see>
    /// </summary>
    let worldTournamentGold = _prefix "worldTournamentGold"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worldTournamentSilver"></see>
    /// </summary>
    let worldTournamentSilver = _prefix "worldTournamentSilver"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worstDefeat"></see>
    /// </summary>
    let worstDefeat = _prefix "worstDefeat"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wptFinalTable"></see>
    /// </summary>
    let wptFinalTable = _prefix "wptFinalTable"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wptItm"></see>
    /// </summary>
    let wptItm = _prefix "wptItm"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wptTitle"></see>
    /// </summary>
    let wptTitle = _prefix "wptTitle"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/writer"></see>
    /// </summary>
    let writer = _prefix "writer"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wsopItm"></see>
    /// </summary>
    let wsopItm = _prefix "wsopItm"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wsopWinYear"></see>
    /// </summary>
    let wsopWinYear = _prefix "wsopWinYear"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wsopWristband"></see>
    /// </summary>
    let wsopWristband = _prefix "wsopWristband"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/year"></see>
    /// </summary>
    let year = _prefix "year"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/yearElevationIntoNobility"></see>
    /// </summary>
    let yearElevationIntoNobility = _prefix "yearElevationIntoNobility"
    /// <summary>
    /// The year in which construction of the Place was finished.
    /// <see href="http://dbpedia.org/ontology/yearOfConstruction"></see></summary>
    let yearOfConstruction = _prefix "yearOfConstruction"
    /// <summary>
    /// Year station was electrified, if not previously at date of opening.
    /// <see href="http://dbpedia.org/ontology/yearOfElectrification"></see></summary>
    let yearOfElectrification = _prefix "yearOfElectrification"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/years"></see>
    /// </summary>
    let years = _prefix "years"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/youthClub"></see>
    /// </summary>
    let youthClub = _prefix "youthClub"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/youthWing"></see>
    /// </summary>
    let youthWing = _prefix "youthWing"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/youthYears"></see>
    /// </summary>
    let youthYears = _prefix "youthYears"
    /// <summary>
    /// Identifier for serial titles. More precise than issn
    /// <see href="http://dbpedia.org/ontology/zdb"></see></summary>
    let zdb = _prefix "zdb"
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/zipCode"></see>
    /// </summary>
    let zipCode = _prefix "zipCode"
    /// <summary>
    /// Zodiac Sign. Applies to persons, planets, etc
    /// <see href="http://dbpedia.org/ontology/zodiacSign"></see></summary>
    let zodiacSign = _prefix "zodiacSign"
