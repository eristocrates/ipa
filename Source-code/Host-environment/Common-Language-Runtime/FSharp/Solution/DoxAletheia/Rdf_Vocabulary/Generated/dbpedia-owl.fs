namespace http.dbpedia.org.ontology.slash

open DoxAletheia.Rdf_Vocabulary

module dbpedia_owl =
    let _namespace_name = "http://dbpedia.org/ontology/"
    /// <summary>
    /// An abbey is a Catholic monastery or convent, under the authority of an Abbot or an Abbess, who serves as the spiritual father or mother of the community.
    /// <see href="http://dbpedia.org/ontology/Abbey"></see></summary>
    let Abbey = Namespaced_IRI.parse _namespace_name "Abbey" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ReligiousBuilding"></see>
    /// </summary>
    let ReligiousBuilding =
        Namespaced_IRI.parse _namespace_name "ReligiousBuilding" |> NamespacedName

    /// <summary>
    /// Monastery denotes the building, or complex of buildings, comprising the domestic quarters and workplace(s) of monastics, whether monks or nuns, and whether living in community or alone (hermits). The monastery generally includes a place reserved for prayer which may be a chapel, church or temple, and may also serve as an oratory.
    /// <see href="http://dbpedia.org/ontology/Monastery"></see></summary>
    let Monastery = Namespaced_IRI.parse _namespace_name "Monastery" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AcademicConference"></see>
    /// </summary>
    let AcademicConference =
        Namespaced_IRI.parse _namespace_name "AcademicConference" |> NamespacedName

    /// <summary>
    /// an event that is clearly different from strictly personal events
    /// <see href="http://dbpedia.org/ontology/SocietalEvent"></see></summary>
    let SocietalEvent =
        Namespaced_IRI.parse _namespace_name "SocietalEvent" |> NamespacedName

    /// <summary>
    /// An academic journal is a mostly peer-reviewed periodical in which scholarship relating to a particular academic discipline is published. Academic journals serve as forums for the introduction and presentation for scrutiny of new research, and the critique of existing research. Content typically takes the form of articles presenting original research, review articles, and book reviews.
    /// <see href="http://dbpedia.org/ontology/AcademicJournal"></see></summary>
    let AcademicJournal =
        Namespaced_IRI.parse _namespace_name "AcademicJournal" |> NamespacedName

    /// <summary>
    /// Periodical literature (also called a periodical publication or simply a periodical) is a published work that appears in a new edition on a regular schedule. The most familiar examples are the newspaper, often published daily, or weekly; or the magazine, typically published weekly, monthly or as a quarterly. Other examples would be a newsletter, a literary journal or learned journal, or a yearbook.
    /// <see href="http://dbpedia.org/ontology/PeriodicalLiterature"></see></summary>
    let PeriodicalLiterature =
        Namespaced_IRI.parse _namespace_name "PeriodicalLiterature" |> NamespacedName

    /// <summary>
    /// Genres of art, e.g. Mathematics, History, Philosophy, Medicine
    /// <see href="http://dbpedia.org/ontology/AcademicSubject"></see></summary>
    let AcademicSubject =
        Namespaced_IRI.parse _namespace_name "AcademicSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TopicalConcept"></see>
    /// </summary>
    let TopicalConcept =
        Namespaced_IRI.parse _namespace_name "TopicalConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Activity"></see>
    /// </summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    /// An actor or actress is a person who acts in a dramatic production and who works in film, television, theatre, or radio in that capacity.
    /// <see href="http://dbpedia.org/ontology/Actor"></see></summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Artist"></see>
    /// </summary>
    let Artist = Namespaced_IRI.parse _namespace_name "Artist" |> NamespacedName

    /// <summary>
    /// A PopulatedPlace under the jurisdiction of an administrative body. This body may administer either a whole region or one or more adjacent Settlements (town administration)
    /// <see href="http://dbpedia.org/ontology/AdministrativeRegion"></see></summary>
    let AdministrativeRegion =
        Namespaced_IRI.parse _namespace_name "AdministrativeRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Region"></see>
    /// </summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/%3Chttp://purl.org/dc/terms/Jurisdiction%3E"></see>
    /// </summary>
    let ``_%3Chttp://purl.org/dc/terms/Jurisdiction%3E`` =
        Namespaced_IRI.parse _namespace_name "%3Chttp://purl.org/dc/terms/Jurisdiction%3E" |> NamespacedName

    /// <summary>
    /// A pornographic actor or actress or a porn star is a person who performs sex acts in film, normally characterised as a pornographic film.
    /// <see href="http://dbpedia.org/ontology/AdultActor"></see></summary>
    let AdultActor = Namespaced_IRI.parse _namespace_name "AdultActor" |> NamespacedName
    /// <summary>
    /// Analogous to a foaf:Agent, an agent is an entity that acts. This is intended to be the super class of Person and Organisation.
    /// <see href="http://dbpedia.org/ontology/Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    /// Immobile things or locations.
    /// <see href="http://dbpedia.org/ontology/Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Agglomeration"></see>
    /// </summary>
    let Agglomeration =
        Namespaced_IRI.parse _namespace_name "Agglomeration" |> NamespacedName

    /// <summary>
    /// As defined by the United States Geological Survey, a populated place is a place or area with clustered or scattered buildings and a permanent human population (city, settlement, town, or village) referenced with geographic coordinates (http://en.wikipedia.org/wiki/Populated_place).
    /// <see href="http://dbpedia.org/ontology/PopulatedPlace"></see></summary>
    let PopulatedPlace =
        Namespaced_IRI.parse _namespace_name "PopulatedPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Aircraft"></see>
    /// </summary>
    let Aircraft = Namespaced_IRI.parse _namespace_name "Aircraft" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation"></see>
    /// </summary>
    let MeanOfTransportation =
        Namespaced_IRI.parse _namespace_name "MeanOfTransportation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Airline"></see>
    /// </summary>
    let Airline = Namespaced_IRI.parse _namespace_name "Airline" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Company"></see>
    /// </summary>
    let Company = Namespaced_IRI.parse _namespace_name "Company" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Airport"></see>
    /// </summary>
    let Airport = Namespaced_IRI.parse _namespace_name "Airport" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Infrastructure"></see>
    /// </summary>
    let Infrastructure =
        Namespaced_IRI.parse _namespace_name "Infrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Album"></see>
    /// </summary>
    let Album = Namespaced_IRI.parse _namespace_name "Album" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MusicalWork"></see>
    /// </summary>
    let MusicalWork =
        Namespaced_IRI.parse _namespace_name "MusicalWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Altitude"></see>
    /// </summary>
    let Altitude = Namespaced_IRI.parse _namespace_name "Altitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AmateurBoxer"></see>
    /// </summary>
    let AmateurBoxer =
        Namespaced_IRI.parse _namespace_name "AmateurBoxer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Boxer"></see>
    /// </summary>
    let Boxer = Namespaced_IRI.parse _namespace_name "Boxer" |> NamespacedName
    /// <summary>
    /// An ambassador is the highest ranking diplomat that represents a nation and is usually accredited to a foreign sovereign or government, or to an international organization.
    /// <see href="http://dbpedia.org/ontology/Ambassador"></see></summary>
    let Ambassador = Namespaced_IRI.parse _namespace_name "Ambassador" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AmericanFootballCoach"></see>
    /// </summary>
    let AmericanFootballCoach =
        Namespaced_IRI.parse _namespace_name "AmericanFootballCoach" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Coach"></see>
    /// </summary>
    let Coach = Namespaced_IRI.parse _namespace_name "Coach" |> NamespacedName

    /// <summary>
    /// A group of sports teams that compete against each other in american football.
    /// <see href="http://dbpedia.org/ontology/AmericanFootballLeague"></see></summary>
    let AmericanFootballLeague =
        Namespaced_IRI.parse _namespace_name "AmericanFootballLeague" |> NamespacedName

    /// <summary>
    /// A group of sports teams or individual athletes that compete against each other in a specific sport.
    /// <see href="http://dbpedia.org/ontology/SportsLeague"></see></summary>
    let SportsLeague =
        Namespaced_IRI.parse _namespace_name "SportsLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AmericanFootballPlayer"></see>
    /// </summary>
    let AmericanFootballPlayer =
        Namespaced_IRI.parse _namespace_name "AmericanFootballPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GridironFootballPlayer"></see>
    /// </summary>
    let GridironFootballPlayer =
        Namespaced_IRI.parse _namespace_name "GridironFootballPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AmericanFootballTeam"></see>
    /// </summary>
    let AmericanFootballTeam =
        Namespaced_IRI.parse _namespace_name "AmericanFootballTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SportsTeam"></see>
    /// </summary>
    let SportsTeam = Namespaced_IRI.parse _namespace_name "SportsTeam" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Amphibian"></see>
    /// </summary>
    let Amphibian = Namespaced_IRI.parse _namespace_name "Amphibian" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Animal"></see>
    /// </summary>
    let Animal = Namespaced_IRI.parse _namespace_name "Animal" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AmusementParkAttraction"></see>
    /// </summary>
    let AmusementParkAttraction =
        Namespaced_IRI.parse _namespace_name "AmusementParkAttraction" |> NamespacedName

    /// <summary>
    /// An architectural structure is a human-made, free-standing, immobile outdoor construction (http://en.wikipedia.org/wiki/Architectural_structure).
    /// <see href="http://dbpedia.org/ontology/ArchitecturalStructure"></see></summary>
    let ArchitecturalStructure =
        Namespaced_IRI.parse _namespace_name "ArchitecturalStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AnatomicalStructure"></see>
    /// </summary>
    let AnatomicalStructure =
        Namespaced_IRI.parse _namespace_name "AnatomicalStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Eukaryote"></see>
    /// </summary>
    let Eukaryote = Namespaced_IRI.parse _namespace_name "Eukaryote" |> NamespacedName

    /// <summary>
    /// Anime/Manga character
    /// <see href="http://dbpedia.org/ontology/AnimangaCharacter"></see></summary>
    let AnimangaCharacter =
        Namespaced_IRI.parse _namespace_name "AnimangaCharacter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ComicsCharacter"></see>
    /// </summary>
    let ComicsCharacter =
        Namespaced_IRI.parse _namespace_name "ComicsCharacter" |> NamespacedName

    /// <summary>
    /// A style of animation originating in Japan
    /// <see href="http://dbpedia.org/ontology/Anime"></see></summary>
    let Anime = Namespaced_IRI.parse _namespace_name "Anime" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cartoon"></see>
    /// </summary>
    let Cartoon = Namespaced_IRI.parse _namespace_name "Cartoon" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Annotation"></see>
    /// </summary>
    let Annotation = Namespaced_IRI.parse _namespace_name "Annotation" |> NamespacedName

    /// <summary>
    /// Written work is any text written to read it (e.g.: books, newspaper, articles)
    /// <see href="http://dbpedia.org/ontology/WrittenWork"></see></summary>
    let WrittenWork =
        Namespaced_IRI.parse _namespace_name "WrittenWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Arachnid"></see>
    /// </summary>
    let Arachnid = Namespaced_IRI.parse _namespace_name "Arachnid" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Archaea"></see>
    /// </summary>
    let Archaea = Namespaced_IRI.parse _namespace_name "Archaea" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Species"></see>
    /// </summary>
    let Species = Namespaced_IRI.parse _namespace_name "Species" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Archeologist"></see>
    /// </summary>
    let Archeologist =
        Namespaced_IRI.parse _namespace_name "Archeologist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ArcherPlayer"></see>
    /// </summary>
    let ArcherPlayer =
        Namespaced_IRI.parse _namespace_name "ArcherPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Athlete"></see>
    /// </summary>
    let Athlete = Namespaced_IRI.parse _namespace_name "Athlete" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Archipelago"></see>
    /// </summary>
    let Archipelago =
        Namespaced_IRI.parse _namespace_name "Archipelago" |> NamespacedName

    /// <summary>
    /// The natural place encompasses all places occurring naturally in universe.
    /// <see href="http://dbpedia.org/ontology/NaturalPlace"></see></summary>
    let NaturalPlace =
        Namespaced_IRI.parse _namespace_name "NaturalPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Architect"></see>
    /// </summary>
    let Architect = Namespaced_IRI.parse _namespace_name "Architect" |> NamespacedName
    /// <summary>
    /// Collection of documents pertaining to a person or organisation.
    /// <see href="http://dbpedia.org/ontology/Archive"></see></summary>
    let Archive = Namespaced_IRI.parse _namespace_name "Archive" |> NamespacedName

    /// <summary>
    /// Collection of valuables is a collection considered to be a work in itself)
    /// <see href="http://dbpedia.org/ontology/CollectionOfValuables"></see></summary>
    let CollectionOfValuables =
        Namespaced_IRI.parse _namespace_name "CollectionOfValuables" |> NamespacedName

    /// <summary>
    /// Area of something. Use "value" for the value, "min" &amp; "max" for a range (if uncertain) and "rank" (integer) for the rank of that thing amongst its siblings (eg regions ordered by area)
    /// <see href="http://dbpedia.org/ontology/Area"></see></summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName
    /// <summary>
    /// An arena is an enclosed area, often circular or oval-shaped, designed to showcase theater, musical performances, or sporting events. (http://en.wikipedia.org/wiki/Arena)
    /// <see href="http://dbpedia.org/ontology/Arena"></see></summary>
    let Arena = Namespaced_IRI.parse _namespace_name "Arena" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Aristocrat"></see>
    /// </summary>
    let Aristocrat = Namespaced_IRI.parse _namespace_name "Aristocrat" |> NamespacedName

    /// <summary>
    /// An administrative (France) or lawcourts (Netherlands) body governing a territorial unity on the intermediate level, between local and national level
    /// <see href="http://dbpedia.org/ontology/Arrondissement"></see></summary>
    let Arrondissement =
        Namespaced_IRI.parse _namespace_name "Arrondissement" |> NamespacedName

    /// <summary>
    /// An administrative body governing some territorial unity, in this case a governmental administrative body
    /// <see href="http://dbpedia.org/ontology/GovernmentalAdministrativeRegion"></see></summary>
    let GovernmentalAdministrativeRegion =
        Namespaced_IRI.parse _namespace_name "GovernmentalAdministrativeRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Artery"></see>
    /// </summary>
    let Artery = Namespaced_IRI.parse _namespace_name "Artery" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Article"></see>
    /// </summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName

    /// <summary>
    /// In the context of spaceflight, an artificial satellite is an artificial object which has been intentionally placed into orbit.
    /// <see href="http://dbpedia.org/ontology/ArtificialSatellite"></see></summary>
    let ArtificialSatellite =
        Namespaced_IRI.parse _namespace_name "ArtificialSatellite" |> NamespacedName

    /// <summary>
    /// An astronomic object orbiting around a planet or star. Definition partly derived from http://www.ontotext.com/proton/protonext# (and thus WordNet 1.7).
    /// <see href="http://dbpedia.org/ontology/Satellite"></see></summary>
    let Satellite = Namespaced_IRI.parse _namespace_name "Satellite" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ArtistDiscography"></see>
    /// </summary>
    let ArtistDiscography =
        Namespaced_IRI.parse _namespace_name "ArtistDiscography" |> NamespacedName

    /// <summary>
    /// Genres of art, e.g. Pointillist, Modernist
    /// <see href="http://dbpedia.org/ontology/ArtisticGenre"></see></summary>
    let ArtisticGenre =
        Namespaced_IRI.parse _namespace_name "ArtisticGenre" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Genre"></see>
    /// </summary>
    let Genre = Namespaced_IRI.parse _namespace_name "Genre" |> NamespacedName
    /// <summary>
    /// A work of art, artwork, art piece, or art object is an aesthetic item or artistic creation.
    /// <see href="http://dbpedia.org/ontology/Artwork"></see></summary>
    let Artwork = Namespaced_IRI.parse _namespace_name "Artwork" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Work"></see>
    /// </summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Asteroid"></see>
    /// </summary>
    let Asteroid = Namespaced_IRI.parse _namespace_name "Asteroid" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CelestialBody"></see>
    /// </summary>
    let CelestialBody =
        Namespaced_IRI.parse _namespace_name "CelestialBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Astronaut"></see>
    /// </summary>
    let Astronaut = Namespaced_IRI.parse _namespace_name "Astronaut" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Astronaut/timeInSpace"></see>
    /// </summary>
    let ``Astronaut/timeInSpace`` =
        Namespaced_IRI.parse _namespace_name "Astronaut/timeInSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Athletics"></see>
    /// </summary>
    let Athletics = Namespaced_IRI.parse _namespace_name "Athletics" |> NamespacedName
    /// <summary>
    /// A sport is commonly defined as an organized, competitive, and skillful physical activity.
    /// <see href="http://dbpedia.org/ontology/Sport"></see></summary>
    let Sport = Namespaced_IRI.parse _namespace_name "Sport" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AthleticsPlayer"></see>
    /// </summary>
    let AthleticsPlayer =
        Namespaced_IRI.parse _namespace_name "AthleticsPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Atoll"></see>
    /// </summary>
    let Atoll = Namespaced_IRI.parse _namespace_name "Atoll" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Island"></see>
    /// </summary>
    let Island = Namespaced_IRI.parse _namespace_name "Island" |> NamespacedName
    /// <summary>
    /// An Attack is not necessarily part of a Military Conflict
    /// <see href="http://dbpedia.org/ontology/Attack"></see></summary>
    let Attack = Namespaced_IRI.parse _namespace_name "Attack" |> NamespacedName

    /// <summary>
    /// A group of sports teams that compete against each other in australian football.
    /// <see href="http://dbpedia.org/ontology/AustralianFootballLeague"></see></summary>
    let AustralianFootballLeague =
        Namespaced_IRI.parse _namespace_name "AustralianFootballLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AustralianFootballTeam"></see>
    /// </summary>
    let AustralianFootballTeam =
        Namespaced_IRI.parse _namespace_name "AustralianFootballTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AustralianRulesFootballPlayer"></see>
    /// </summary>
    let AustralianRulesFootballPlayer =
        Namespaced_IRI.parse _namespace_name "AustralianRulesFootballPlayer" |> NamespacedName

    /// <summary>
    /// a group of sports teams or individual athletes that compete against each other in auto racing
    /// <see href="http://dbpedia.org/ontology/AutoRacingLeague"></see></summary>
    let AutoRacingLeague =
        Namespaced_IRI.parse _namespace_name "AutoRacingLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Automobile"></see>
    /// </summary>
    let Automobile = Namespaced_IRI.parse _namespace_name "Automobile" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Automobile/fuelCapacity"></see>
    /// </summary>
    let ``Automobile/fuelCapacity`` =
        Namespaced_IRI.parse _namespace_name "Automobile/fuelCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Automobile/wheelbase"></see>
    /// </summary>
    let ``Automobile/wheelbase`` =
        Namespaced_IRI.parse _namespace_name "Automobile/wheelbase" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/AutomobileEngine"></see>
    /// </summary>
    let AutomobileEngine =
        Namespaced_IRI.parse _namespace_name "AutomobileEngine" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine"></see>
    /// </summary>
    let Engine = Namespaced_IRI.parse _namespace_name "Engine" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Award"></see>
    /// </summary>
    let Award = Namespaced_IRI.parse _namespace_name "Award" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BackScene"></see>
    /// </summary>
    let BackScene = Namespaced_IRI.parse _namespace_name "BackScene" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MusicalArtist"></see>
    /// </summary>
    let MusicalArtist =
        Namespaced_IRI.parse _namespace_name "MusicalArtist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Bacteria"></see>
    /// </summary>
    let Bacteria = Namespaced_IRI.parse _namespace_name "Bacteria" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BadmintonPlayer"></see>
    /// </summary>
    let BadmintonPlayer =
        Namespaced_IRI.parse _namespace_name "BadmintonPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Band"></see>
    /// </summary>
    let Band = Namespaced_IRI.parse _namespace_name "Band" |> NamespacedName
    /// <summary>
    /// An (informal) group of people.
    /// <see href="http://dbpedia.org/ontology/Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// a company which main services are banking or financial services.
    /// <see href="http://dbpedia.org/ontology/Bank"></see></summary>
    let Bank = Namespaced_IRI.parse _namespace_name "Bank" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Baronet"></see>
    /// </summary>
    let Baronet = Namespaced_IRI.parse _namespace_name "Baronet" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BritishRoyalty"></see>
    /// </summary>
    let BritishRoyalty =
        Namespaced_IRI.parse _namespace_name "BritishRoyalty" |> NamespacedName

    /// <summary>
    /// a group of sports teams that compete against each other in Baseball.
    /// <see href="http://dbpedia.org/ontology/BaseballLeague"></see></summary>
    let BaseballLeague =
        Namespaced_IRI.parse _namespace_name "BaseballLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BaseballPlayer"></see>
    /// </summary>
    let BaseballPlayer =
        Namespaced_IRI.parse _namespace_name "BaseballPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BaseballSeason"></see>
    /// </summary>
    let BaseballSeason =
        Namespaced_IRI.parse _namespace_name "BaseballSeason" |> NamespacedName

    /// <summary>
    /// A season for a particular sports team (as opposed to the season for the entire league that the team is in)
    /// <see href="http://dbpedia.org/ontology/SportsTeamSeason"></see></summary>
    let SportsTeamSeason =
        Namespaced_IRI.parse _namespace_name "SportsTeamSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BaseballTeam"></see>
    /// </summary>
    let BaseballTeam =
        Namespaced_IRI.parse _namespace_name "BaseballTeam" |> NamespacedName

    /// <summary>
    /// a group of sports teams that compete against each other in Basketball
    /// <see href="http://dbpedia.org/ontology/BasketballLeague"></see></summary>
    let BasketballLeague =
        Namespaced_IRI.parse _namespace_name "BasketballLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BasketballPlayer"></see>
    /// </summary>
    let BasketballPlayer =
        Namespaced_IRI.parse _namespace_name "BasketballPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BasketballTeam"></see>
    /// </summary>
    let BasketballTeam =
        Namespaced_IRI.parse _namespace_name "BasketballTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Bay"></see>
    /// </summary>
    let Bay = Namespaced_IRI.parse _namespace_name "Bay" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BodyOfWater"></see>
    /// </summary>
    let BodyOfWater =
        Namespaced_IRI.parse _namespace_name "BodyOfWater" |> NamespacedName

    /// <summary>
    /// The shore of a body of water, especially when sandy or pebbly.
    /// <see href="http://dbpedia.org/ontology/Beach"></see></summary>
    let Beach = Namespaced_IRI.parse _namespace_name "Beach" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BeachVolleyballPlayer"></see>
    /// </summary>
    let BeachVolleyballPlayer =
        Namespaced_IRI.parse _namespace_name "BeachVolleyballPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/VolleyballPlayer"></see>
    /// </summary>
    let VolleyballPlayer =
        Namespaced_IRI.parse _namespace_name "VolleyballPlayer" |> NamespacedName

    /// <summary>
    /// A beauty pageant titleholder
    /// <see href="http://dbpedia.org/ontology/BeautyQueen"></see></summary>
    let BeautyQueen =
        Namespaced_IRI.parse _namespace_name "BeautyQueen" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Beer"></see>
    /// </summary>
    let Beer = Namespaced_IRI.parse _namespace_name "Beer" |> NamespacedName
    /// <summary>
    /// A drink, or beverage, is a liquid which is specifically prepared for human consumption.
    /// <see href="http://dbpedia.org/ontology/Beverage"></see></summary>
    let Beverage = Namespaced_IRI.parse _namespace_name "Beverage" |> NamespacedName
    /// <summary>
    /// Food is any eatable or drinkable substance that is normally consumed by humans.
    /// <see href="http://dbpedia.org/ontology/Food"></see></summary>
    let Food = Namespaced_IRI.parse _namespace_name "Food" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Biathlete"></see>
    /// </summary>
    let Biathlete = Namespaced_IRI.parse _namespace_name "Biathlete" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WinterSportPlayer"></see>
    /// </summary>
    let WinterSportPlayer =
        Namespaced_IRI.parse _namespace_name "WinterSportPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BiologicalDatabase"></see>
    /// </summary>
    let BiologicalDatabase =
        Namespaced_IRI.parse _namespace_name "BiologicalDatabase" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Database"></see>
    /// </summary>
    let Database = Namespaced_IRI.parse _namespace_name "Database" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Biologist"></see>
    /// </summary>
    let Biologist = Namespaced_IRI.parse _namespace_name "Biologist" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Scientist"></see>
    /// </summary>
    let Scientist = Namespaced_IRI.parse _namespace_name "Scientist" |> NamespacedName

    /// <summary>
    /// equivalent to http://ccdb.ucsd.edu/NIF/BIRNLex-OBO-UBO.owl#birnlex_22.
    /// <see href="http://dbpedia.org/ontology/Biomolecule"></see></summary>
    let Biomolecule =
        Namespaced_IRI.parse _namespace_name "Biomolecule" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Bird"></see>
    /// </summary>
    let Bird = Namespaced_IRI.parse _namespace_name "Bird" |> NamespacedName
    /// <summary>
    /// someone's birth as a type of personal event
    /// <see href="http://dbpedia.org/ontology/Birth"></see></summary>
    let Birth = Namespaced_IRI.parse _namespace_name "Birth" |> NamespacedName

    /// <summary>
    /// an event that occurs in someone's personal life
    /// <see href="http://dbpedia.org/ontology/PersonalEvent"></see></summary>
    let PersonalEvent =
        Namespaced_IRI.parse _namespace_name "PersonalEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Blazon"></see>
    /// </summary>
    let Blazon = Namespaced_IRI.parse _namespace_name "Blazon" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BloodVessel"></see>
    /// </summary>
    let BloodVessel =
        Namespaced_IRI.parse _namespace_name "BloodVessel" |> NamespacedName

    /// <summary>
    /// come from http://en.wikipedia.org/wiki/Category:Board_games
    /// <see href="http://dbpedia.org/ontology/BoardGame"></see></summary>
    let BoardGame = Namespaced_IRI.parse _namespace_name "BoardGame" |> NamespacedName
    /// <summary>
    /// a structured activity, usually undertaken for enjoyment and sometimes used as an educational tool
    /// <see href="http://dbpedia.org/ontology/Game"></see></summary>
    let Game = Namespaced_IRI.parse _namespace_name "Game" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BobsleighAthlete"></see>
    /// </summary>
    let BobsleighAthlete =
        Namespaced_IRI.parse _namespace_name "BobsleighAthlete" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Bodybuilder"></see>
    /// </summary>
    let Bodybuilder =
        Namespaced_IRI.parse _namespace_name "Bodybuilder" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Bone"></see>
    /// </summary>
    let Bone = Namespaced_IRI.parse _namespace_name "Bone" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Book"></see>
    /// </summary>
    let Book = Namespaced_IRI.parse _namespace_name "Book" |> NamespacedName

    /// <summary>
    /// a group of sports teams or players that compete against each other in Bowling
    /// <see href="http://dbpedia.org/ontology/BowlingLeague"></see></summary>
    let BowlingLeague =
        Namespaced_IRI.parse _namespace_name "BowlingLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Boxing"></see>
    /// </summary>
    let Boxing = Namespaced_IRI.parse _namespace_name "Boxing" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BoxingCategory"></see>
    /// </summary>
    let BoxingCategory =
        Namespaced_IRI.parse _namespace_name "BoxingCategory" |> NamespacedName

    /// <summary>
    /// A group of sports teams or fighters that compete against each other in Boxing
    /// <see href="http://dbpedia.org/ontology/BoxingLeague"></see></summary>
    let BoxingLeague =
        Namespaced_IRI.parse _namespace_name "BoxingLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BoxingStyle"></see>
    /// </summary>
    let BoxingStyle =
        Namespaced_IRI.parse _namespace_name "BoxingStyle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Brain"></see>
    /// </summary>
    let Brain = Namespaced_IRI.parse _namespace_name "Brain" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Brewery"></see>
    /// </summary>
    let Brewery = Namespaced_IRI.parse _namespace_name "Brewery" |> NamespacedName
    /// <summary>
    /// A bridge is a structure built to span physical obstacles such as a body of water, valley, or road, for the purpose of providing passage over the obstacle (http://en.wikipedia.org/wiki/Bridge).
    /// <see href="http://dbpedia.org/ontology/Bridge"></see></summary>
    let Bridge = Namespaced_IRI.parse _namespace_name "Bridge" |> NamespacedName

    /// <summary>
    /// A route of transportation (thoroughfare) may refer to a public road, highway, path or trail or a route on water from one place to another for use by a variety of general traffic (http://en.wikipedia.org/wiki/Thoroughfare).
    /// <see href="http://dbpedia.org/ontology/RouteOfTransportation"></see></summary>
    let RouteOfTransportation =
        Namespaced_IRI.parse _namespace_name "RouteOfTransportation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Royalty"></see>
    /// </summary>
    let Royalty = Namespaced_IRI.parse _namespace_name "Royalty" |> NamespacedName

    /// <summary>
    /// A broadcast network is an organization, such as a corporation or other association, that provides live or recorded content, such as movies, newscasts, sports, and public affairs programs for broadcast over a group of radio or television stations. (http://en.wikipedia.org/wiki/Broadcast_network - 28/03/2011)
    /// <see href="http://dbpedia.org/ontology/BroadcastNetwork"></see></summary>
    let BroadcastNetwork =
        Namespaced_IRI.parse _namespace_name "BroadcastNetwork" |> NamespacedName

    /// <summary>
    /// A broadcaster is an organisation responsible for the production of radio or television programs and/or their transmission. (http://en.wikipedia.org/wiki/Broadcaster - 28/03/2011)
    /// <see href="http://dbpedia.org/ontology/Broadcaster"></see></summary>
    let Broadcaster =
        Namespaced_IRI.parse _namespace_name "Broadcaster" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Organisation"></see>
    /// </summary>
    let Organisation =
        Namespaced_IRI.parse _namespace_name "Organisation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BrownDwarf"></see>
    /// </summary>
    let BrownDwarf = Namespaced_IRI.parse _namespace_name "BrownDwarf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Star"></see>
    /// </summary>
    let Star = Namespaced_IRI.parse _namespace_name "Star" |> NamespacedName
    /// <summary>
    /// Building is defined as a Civil Engineering structure such as a house, worship center, factory etc. that has a foundation, wall, roof etc. that protect human being and their properties from direct harsh effect of weather like rain, wind, sun etc. (http://en.wikipedia.org/wiki/Building).
    /// <see href="http://dbpedia.org/ontology/Building"></see></summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Building/floorArea"></see>
    /// </summary>
    let ``Building/floorArea`` =
        Namespaced_IRI.parse _namespace_name "Building/floorArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BullFighter"></see>
    /// </summary>
    let BullFighter =
        Namespaced_IRI.parse _namespace_name "BullFighter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BusCompany"></see>
    /// </summary>
    let BusCompany = Namespaced_IRI.parse _namespace_name "BusCompany" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BusinessPerson"></see>
    /// </summary>
    let BusinessPerson =
        Namespaced_IRI.parse _namespace_name "BusinessPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Camera"></see>
    /// </summary>
    let Camera = Namespaced_IRI.parse _namespace_name "Camera" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Device"></see>
    /// </summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName

    /// <summary>
    /// A group of sports teams that compete against each other in canadian football league.
    /// <see href="http://dbpedia.org/ontology/CanadianFootballLeague"></see></summary>
    let CanadianFootballLeague =
        Namespaced_IRI.parse _namespace_name "CanadianFootballLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CanadianFootballPlayer"></see>
    /// </summary>
    let CanadianFootballPlayer =
        Namespaced_IRI.parse _namespace_name "CanadianFootballPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CanadianFootballTeam"></see>
    /// </summary>
    let CanadianFootballTeam =
        Namespaced_IRI.parse _namespace_name "CanadianFootballTeam" |> NamespacedName

    /// <summary>
    /// a man-made channel for water
    /// <see href="http://dbpedia.org/ontology/Canal"></see></summary>
    let Canal = Namespaced_IRI.parse _namespace_name "Canal" |> NamespacedName
    /// <summary>
    /// a flowing body of water with a current, confined within a bed and stream banks
    /// <see href="http://dbpedia.org/ontology/Stream"></see></summary>
    let Stream = Namespaced_IRI.parse _namespace_name "Stream" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Canal/maximumBoatBeam"></see>
    /// </summary>
    let ``Canal/maximumBoatBeam`` =
        Namespaced_IRI.parse _namespace_name "Canal/maximumBoatBeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Canal/maximumBoatLength"></see>
    /// </summary>
    let ``Canal/maximumBoatLength`` =
        Namespaced_IRI.parse _namespace_name "Canal/maximumBoatLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Canal/originalMaximumBoatBeam"></see>
    /// </summary>
    let ``Canal/originalMaximumBoatBeam`` =
        Namespaced_IRI.parse _namespace_name "Canal/originalMaximumBoatBeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Canal/originalMaximumBoatLength"></see>
    /// </summary>
    let ``Canal/originalMaximumBoatLength`` =
        Namespaced_IRI.parse _namespace_name "Canal/originalMaximumBoatLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Canoeist"></see>
    /// </summary>
    let Canoeist = Namespaced_IRI.parse _namespace_name "Canoeist" |> NamespacedName
    /// <summary>
    /// An administrative (France) or lawcourts (Netherlands) body governing a territorial unity on the municipal level or somewhat above
    /// <see href="http://dbpedia.org/ontology/Canton"></see></summary>
    let Canton = Namespaced_IRI.parse _namespace_name "Canton" |> NamespacedName
    /// <summary>
    /// A municipality enjoying primary status in a state, country, province, or other region as its seat of government.
    /// <see href="http://dbpedia.org/ontology/Capital"></see></summary>
    let Capital = Namespaced_IRI.parse _namespace_name "Capital" |> NamespacedName
    /// <summary>
    /// a relatively large and permanent settlement, particularly a large urban settlement
    /// <see href="http://dbpedia.org/ontology/City"></see></summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName

    /// <summary>
    /// seat of a first order administration division.
    /// <see href="http://dbpedia.org/ontology/CapitalOfRegion"></see></summary>
    let CapitalOfRegion =
        Namespaced_IRI.parse _namespace_name "CapitalOfRegion" |> NamespacedName

    /// <summary>
    /// come from http://en.wikipedia.org/wiki/Category:Card_games
    /// <see href="http://dbpedia.org/ontology/CardGame"></see></summary>
    let CardGame = Namespaced_IRI.parse _namespace_name "CardGame" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cardinal"></see>
    /// </summary>
    let Cardinal = Namespaced_IRI.parse _namespace_name "Cardinal" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cleric"></see>
    /// </summary>
    let Cleric = Namespaced_IRI.parse _namespace_name "Cleric" |> NamespacedName

    /// <summary>
    /// One of the four main directions on a compass or any other system to determine a geographical position
    /// <see href="http://dbpedia.org/ontology/CardinalDirection"></see></summary>
    let CardinalDirection =
        Namespaced_IRI.parse _namespace_name "CardinalDirection" |> NamespacedName

    /// <summary>
    /// this class marks a career step in the life of a person, e.g. a soccer player, holding information on the time span, matches and goals he or she achieved at a certain club
    /// <see href="http://dbpedia.org/ontology/CareerStation"></see></summary>
    let CareerStation =
        Namespaced_IRI.parse _namespace_name "CareerStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TimePeriod"></see>
    /// </summary>
    let TimePeriod = Namespaced_IRI.parse _namespace_name "TimePeriod" |> NamespacedName
    /// <summary>
    /// A case is the total of work done to prepare for an administrative or business decision. As a rule, a case is reflected in a set of documents.
    /// <see href="http://dbpedia.org/ontology/Case"></see></summary>
    let Case = Namespaced_IRI.parse _namespace_name "Case" |> NamespacedName
    /// <summary>
    /// This class is meant to convey the notion of an amount work to be done. It is different from Activity in that it has a definite end and is being measured.
    /// <see href="http://dbpedia.org/ontology/UnitOfWork"></see></summary>
    let UnitOfWork = Namespaced_IRI.parse _namespace_name "UnitOfWork" |> NamespacedName
    /// <summary>
    /// In modern English, a casino is a facility which houses and accommodates certain types of gambling activities.
    /// <see href="http://dbpedia.org/ontology/Casino"></see></summary>
    let Casino = Namespaced_IRI.parse _namespace_name "Casino" |> NamespacedName
    /// <summary>
    /// Castles often are, but need not be a military structure. They can serve for status, pleasure and hunt as well.
    /// <see href="http://dbpedia.org/ontology/Castle"></see></summary>
    let Castle = Namespaced_IRI.parse _namespace_name "Castle" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cat"></see>
    /// </summary>
    let Cat = Namespaced_IRI.parse _namespace_name "Cat" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Mammal"></see>
    /// </summary>
    let Mammal = Namespaced_IRI.parse _namespace_name "Mammal" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Caterer"></see>
    /// </summary>
    let Caterer = Namespaced_IRI.parse _namespace_name "Caterer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cave"></see>
    /// </summary>
    let Cave = Namespaced_IRI.parse _namespace_name "Cave" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Celebrity"></see>
    /// </summary>
    let Celebrity = Namespaced_IRI.parse _namespace_name "Celebrity" |> NamespacedName
    /// <summary>
    /// A burial place
    /// <see href="http://dbpedia.org/ontology/Cemetery"></see></summary>
    let Cemetery = Namespaced_IRI.parse _namespace_name "Cemetery" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Chancellor"></see>
    /// </summary>
    let Chancellor = Namespaced_IRI.parse _namespace_name "Chancellor" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Politician"></see>
    /// </summary>
    let Politician = Namespaced_IRI.parse _namespace_name "Politician" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChartsPlacements"></see>
    /// </summary>
    let ChartsPlacements =
        Namespaced_IRI.parse _namespace_name "ChartsPlacements" |> NamespacedName

    /// <summary>
    /// A milk product prepared for human consumption
    /// <see href="http://dbpedia.org/ontology/Cheese"></see></summary>
    let Cheese = Namespaced_IRI.parse _namespace_name "Cheese" |> NamespacedName
    /// <summary>
    /// a person who cooks professionally for other people
    /// <see href="http://dbpedia.org/ontology/Chef"></see></summary>
    let Chef = Namespaced_IRI.parse _namespace_name "Chef" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChemicalCompound"></see>
    /// </summary>
    let ChemicalCompound =
        Namespaced_IRI.parse _namespace_name "ChemicalCompound" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChemicalSubstance"></see>
    /// </summary>
    let ChemicalSubstance =
        Namespaced_IRI.parse _namespace_name "ChemicalSubstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChemicalElement"></see>
    /// </summary>
    let ChemicalElement =
        Namespaced_IRI.parse _namespace_name "ChemicalElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChemicalSubstance/boilingPoint"></see>
    /// </summary>
    let ``ChemicalSubstance/boilingPoint`` =
        Namespaced_IRI.parse _namespace_name "ChemicalSubstance/boilingPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChemicalSubstance/density"></see>
    /// </summary>
    let ``ChemicalSubstance/density`` =
        Namespaced_IRI.parse _namespace_name "ChemicalSubstance/density" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChemicalSubstance/meltingPoint"></see>
    /// </summary>
    let ``ChemicalSubstance/meltingPoint`` =
        Namespaced_IRI.parse _namespace_name "ChemicalSubstance/meltingPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChessPlayer"></see>
    /// </summary>
    let ChessPlayer =
        Namespaced_IRI.parse _namespace_name "ChessPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChristianBishop"></see>
    /// </summary>
    let ChristianBishop =
        Namespaced_IRI.parse _namespace_name "ChristianBishop" |> NamespacedName

    /// <summary>
    /// Tenets of the Christian faith, e.g. Trinity, Nicene Creed
    /// <see href="http://dbpedia.org/ontology/ChristianDoctrine"></see></summary>
    let ChristianDoctrine =
        Namespaced_IRI.parse _namespace_name "ChristianDoctrine" |> NamespacedName

    /// <summary>
    /// Theological concepts, e.g. The apocalypse, Trinty, Stoicism
    /// <see href="http://dbpedia.org/ontology/TheologicalConcept"></see></summary>
    let TheologicalConcept =
        Namespaced_IRI.parse _namespace_name "TheologicalConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ChristianPatriarch"></see>
    /// </summary>
    let ChristianPatriarch =
        Namespaced_IRI.parse _namespace_name "ChristianPatriarch" |> NamespacedName

    /// <summary>
    /// This is used for church buildings, not any other meaning of church.
    /// <see href="http://dbpedia.org/ontology/Church"></see></summary>
    let Church = Namespaced_IRI.parse _namespace_name "Church" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Settlement"></see>
    /// </summary>
    let Settlement = Namespaced_IRI.parse _namespace_name "Settlement" |> NamespacedName

    /// <summary>
    /// District, borough, area or neighbourhood in a city or town
    /// <see href="http://dbpedia.org/ontology/CityDistrict"></see></summary>
    let CityDistrict =
        Namespaced_IRI.parse _namespace_name "CityDistrict" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ClassicalMusicArtist"></see>
    /// </summary>
    let ClassicalMusicArtist =
        Namespaced_IRI.parse _namespace_name "ClassicalMusicArtist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ClassicalMusicComposition"></see>
    /// </summary>
    let ClassicalMusicComposition =
        Namespaced_IRI.parse _namespace_name "ClassicalMusicComposition" |> NamespacedName

    /// <summary>
    /// An administrative body governing some territorial unity, in this case a clerical administrative body
    /// <see href="http://dbpedia.org/ontology/ClericalAdministrativeRegion"></see></summary>
    let ClericalAdministrativeRegion =
        Namespaced_IRI.parse _namespace_name "ClericalAdministrativeRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ClericalOrder"></see>
    /// </summary>
    let ClericalOrder =
        Namespaced_IRI.parse _namespace_name "ClericalOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ReligiousOrganisation"></see>
    /// </summary>
    let ReligiousOrganisation =
        Namespaced_IRI.parse _namespace_name "ReligiousOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ClubMoss"></see>
    /// </summary>
    let ClubMoss = Namespaced_IRI.parse _namespace_name "ClubMoss" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Plant"></see>
    /// </summary>
    let Plant = Namespaced_IRI.parse _namespace_name "Plant" |> NamespacedName
    /// <summary>
    /// A coal pit is a place where charcoal is or was extracted
    /// <see href="http://dbpedia.org/ontology/CoalPit"></see></summary>
    let CoalPit = Namespaced_IRI.parse _namespace_name "CoalPit" |> NamespacedName
    /// <summary>
    /// A mine is a place where mineral resources are or were extracted
    /// <see href="http://dbpedia.org/ontology/Mine"></see></summary>
    let Mine = Namespaced_IRI.parse _namespace_name "Mine" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/College"></see>
    /// </summary>
    let College = Namespaced_IRI.parse _namespace_name "College" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/EducationalInstitution"></see>
    /// </summary>
    let EducationalInstitution =
        Namespaced_IRI.parse _namespace_name "EducationalInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CollegeCoach"></see>
    /// </summary>
    let CollegeCoach =
        Namespaced_IRI.parse _namespace_name "CollegeCoach" |> NamespacedName

    /// <summary>
    /// Color or colour is the visual perceptual property corresponding in humans to the categories called red, yellow, blue and others. Color derives from the spectrum of light (distribution of light energy versus wavelength) interacting in the eye with the spectral sensitivities of the light receptors.
    /// <see href="http://dbpedia.org/ontology/Colour"></see></summary>
    let Colour = Namespaced_IRI.parse _namespace_name "Colour" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Comedian"></see>
    /// </summary>
    let Comedian = Namespaced_IRI.parse _namespace_name "Comedian" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ComedyGroup"></see>
    /// </summary>
    let ComedyGroup =
        Namespaced_IRI.parse _namespace_name "ComedyGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Comic"></see>
    /// </summary>
    let Comic = Namespaced_IRI.parse _namespace_name "Comic" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ComicStrip"></see>
    /// </summary>
    let ComicStrip = Namespaced_IRI.parse _namespace_name "ComicStrip" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FictionalCharacter"></see>
    /// </summary>
    let FictionalCharacter =
        Namespaced_IRI.parse _namespace_name "FictionalCharacter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ComicsCreator"></see>
    /// </summary>
    let ComicsCreator =
        Namespaced_IRI.parse _namespace_name "ComicsCreator" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Community"></see>
    /// </summary>
    let Community = Namespaced_IRI.parse _namespace_name "Community" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Competition"></see>
    /// </summary>
    let Competition =
        Namespaced_IRI.parse _namespace_name "Competition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConcentrationCamp"></see>
    /// </summary>
    let ConcentrationCamp =
        Namespaced_IRI.parse _namespace_name "ConcentrationCamp" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Congressman"></see>
    /// </summary>
    let Congressman =
        Namespaced_IRI.parse _namespace_name "Congressman" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Conifer"></see>
    /// </summary>
    let Conifer = Namespaced_IRI.parse _namespace_name "Conifer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Constellation"></see>
    /// </summary>
    let Constellation =
        Namespaced_IRI.parse _namespace_name "Constellation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Contest"></see>
    /// </summary>
    let Contest = Namespaced_IRI.parse _namespace_name "Contest" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Continent"></see>
    /// </summary>
    let Continent = Namespaced_IRI.parse _namespace_name "Continent" |> NamespacedName

    /// <summary>
    /// A quality assurance label for wines
    /// <see href="http://dbpedia.org/ontology/ControlledDesignationOfOriginWine"></see></summary>
    let ControlledDesignationOfOriginWine =
        Namespaced_IRI.parse _namespace_name "ControlledDesignationOfOriginWine" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Wine"></see>
    /// </summary>
    let Wine = Namespaced_IRI.parse _namespace_name "Wine" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Convention"></see>
    /// </summary>
    let Convention = Namespaced_IRI.parse _namespace_name "Convention" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem"></see>
    /// </summary>
    let ConveyorSystem =
        Namespaced_IRI.parse _namespace_name "ConveyorSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation"></see>
    /// </summary>
    let ``On-SiteTransportation`` =
        Namespaced_IRI.parse _namespace_name "On-SiteTransportation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem/diameter"></see>
    /// </summary>
    let ``ConveyorSystem/diameter`` =
        Namespaced_IRI.parse _namespace_name "ConveyorSystem/diameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem/height"></see>
    /// </summary>
    let ``ConveyorSystem/height`` =
        Namespaced_IRI.parse _namespace_name "ConveyorSystem/height" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem/length"></see>
    /// </summary>
    let ``ConveyorSystem/length`` =
        Namespaced_IRI.parse _namespace_name "ConveyorSystem/length" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem/mass"></see>
    /// </summary>
    let ``ConveyorSystem/mass`` =
        Namespaced_IRI.parse _namespace_name "ConveyorSystem/mass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem/weight"></see>
    /// </summary>
    let ``ConveyorSystem/weight`` =
        Namespaced_IRI.parse _namespace_name "ConveyorSystem/weight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ConveyorSystem/width"></see>
    /// </summary>
    let ``ConveyorSystem/width`` =
        Namespaced_IRI.parse _namespace_name "ConveyorSystem/width" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Country"></see>
    /// </summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName

    /// <summary>
    /// A country seat is a rural patch of land owned by a land owner.
    /// <see href="http://dbpedia.org/ontology/CountrySeat"></see></summary>
    let CountrySeat =
        Namespaced_IRI.parse _namespace_name "CountrySeat" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Crater"></see>
    /// </summary>
    let Crater = Namespaced_IRI.parse _namespace_name "Crater" |> NamespacedName
    /// <summary>
    /// the portion of a stream that is affected by ebb and flow of ocean tides
    /// <see href="http://dbpedia.org/ontology/Creek"></see></summary>
    let Creek = Namespaced_IRI.parse _namespace_name "Creek" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CricketGround"></see>
    /// </summary>
    let CricketGround =
        Namespaced_IRI.parse _namespace_name "CricketGround" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SportFacility"></see>
    /// </summary>
    let SportFacility =
        Namespaced_IRI.parse _namespace_name "SportFacility" |> NamespacedName

    /// <summary>
    /// a group of sports teams that compete against each other in Cricket
    /// <see href="http://dbpedia.org/ontology/CricketLeague"></see></summary>
    let CricketLeague =
        Namespaced_IRI.parse _namespace_name "CricketLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CricketTeam"></see>
    /// </summary>
    let CricketTeam =
        Namespaced_IRI.parse _namespace_name "CricketTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cricketer"></see>
    /// </summary>
    let Cricketer = Namespaced_IRI.parse _namespace_name "Cricketer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Criminal"></see>
    /// </summary>
    let Criminal = Namespaced_IRI.parse _namespace_name "Criminal" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CrossCountrySkier"></see>
    /// </summary>
    let CrossCountrySkier =
        Namespaced_IRI.parse _namespace_name "CrossCountrySkier" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Crustacean"></see>
    /// </summary>
    let Crustacean = Namespaced_IRI.parse _namespace_name "Crustacean" |> NamespacedName

    /// <summary>
    /// A cultivar is a plant or grouping of plants selected for desirable characteristics that can be maintained by propagation. A plant whose origin or selection is primarily due to intentional human activity.
    /// <see href="http://dbpedia.org/ontology/CultivatedVariety"></see></summary>
    let CultivatedVariety =
        Namespaced_IRI.parse _namespace_name "CultivatedVariety" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Curler"></see>
    /// </summary>
    let Curler = Namespaced_IRI.parse _namespace_name "Curler" |> NamespacedName

    /// <summary>
    /// a group of sports teams that compete against each other in Curling
    /// <see href="http://dbpedia.org/ontology/CurlingLeague"></see></summary>
    let CurlingLeague =
        Namespaced_IRI.parse _namespace_name "CurlingLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Currency"></see>
    /// </summary>
    let Currency = Namespaced_IRI.parse _namespace_name "Currency" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cycad"></see>
    /// </summary>
    let Cycad = Namespaced_IRI.parse _namespace_name "Cycad" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CyclingCompetition"></see>
    /// </summary>
    let CyclingCompetition =
        Namespaced_IRI.parse _namespace_name "CyclingCompetition" |> NamespacedName

    /// <summary>
    /// a event of competitive physical activity
    /// <see href="http://dbpedia.org/ontology/SportsEvent"></see></summary>
    let SportsEvent =
        Namespaced_IRI.parse _namespace_name "SportsEvent" |> NamespacedName

    /// <summary>
    /// a group of sports teams that compete against each other in Cycling
    /// <see href="http://dbpedia.org/ontology/CyclingLeague"></see></summary>
    let CyclingLeague =
        Namespaced_IRI.parse _namespace_name "CyclingLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CyclingRace"></see>
    /// </summary>
    let CyclingRace =
        Namespaced_IRI.parse _namespace_name "CyclingRace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Race"></see>
    /// </summary>
    let Race = Namespaced_IRI.parse _namespace_name "Race" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/CyclingTeam"></see>
    /// </summary>
    let CyclingTeam =
        Namespaced_IRI.parse _namespace_name "CyclingTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Cyclist"></see>
    /// </summary>
    let Cyclist = Namespaced_IRI.parse _namespace_name "Cyclist" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/DTMRacer"></see>
    /// </summary>
    let DTMRacer = Namespaced_IRI.parse _namespace_name "DTMRacer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RacingDriver"></see>
    /// </summary>
    let RacingDriver =
        Namespaced_IRI.parse _namespace_name "RacingDriver" |> NamespacedName

    /// <summary>
    /// A dam is part of a landscape infrastructure, like waterworks (canals) or roads, much more than a building, though, of course, it has been built, too.
    /// <see href="http://dbpedia.org/ontology/Dam"></see></summary>
    let Dam = Namespaced_IRI.parse _namespace_name "Dam" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Dancer"></see>
    /// </summary>
    let Dancer = Namespaced_IRI.parse _namespace_name "Dancer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/DartsPlayer"></see>
    /// </summary>
    let DartsPlayer =
        Namespaced_IRI.parse _namespace_name "DartsPlayer" |> NamespacedName

    /// <summary>
    /// The intermediate level of a clerical administrative body between parish and diocese
    /// <see href="http://dbpedia.org/ontology/Deanery"></see></summary>
    let Deanery = Namespaced_IRI.parse _namespace_name "Deanery" |> NamespacedName
    /// <summary>
    /// someone's death as a type of personal event
    /// <see href="http://dbpedia.org/ontology/Death"></see></summary>
    let Death = Namespaced_IRI.parse _namespace_name "Death" |> NamespacedName
    /// <summary>
    /// An object, such as a medal or an order, that is awarded to honor the recipient ostentatiously.
    /// <see href="http://dbpedia.org/ontology/Decoration"></see></summary>
    let Decoration = Namespaced_IRI.parse _namespace_name "Decoration" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Deity"></see>
    /// </summary>
    let Deity = Namespaced_IRI.parse _namespace_name "Deity" |> NamespacedName

    /// <summary>
    /// Population of a place. Uses these properties: populationTotal, year (when measured, populationYear), rank (sortOrder of this place amongst its siblings at the same level), name (areal measured by the population, eg: "locality", "municipality" or "comitat")
    /// <see href="http://dbpedia.org/ontology/Demographics"></see></summary>
    let Demographics =
        Namespaced_IRI.parse _namespace_name "Demographics" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Department"></see>
    /// </summary>
    let Department = Namespaced_IRI.parse _namespace_name "Department" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Depth"></see>
    /// </summary>
    let Depth = Namespaced_IRI.parse _namespace_name "Depth" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Deputy"></see>
    /// </summary>
    let Deputy = Namespaced_IRI.parse _namespace_name "Deputy" |> NamespacedName
    /// <summary>
    /// A barren area of land where little precipitation occurs.
    /// <see href="http://dbpedia.org/ontology/Desert"></see></summary>
    let Desert = Namespaced_IRI.parse _namespace_name "Desert" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/DigitalCamera"></see>
    /// </summary>
    let DigitalCamera =
        Namespaced_IRI.parse _namespace_name "DigitalCamera" |> NamespacedName

    /// <summary>
    /// A dike is an elongated naturally occurring ridge or artificially constructed fill or wall, which regulates water levels
    /// <see href="http://dbpedia.org/ontology/Dike"></see></summary>
    let Dike = Namespaced_IRI.parse _namespace_name "Dike" |> NamespacedName
    /// <summary>
    /// District or see under the supervision of a bishop.
    /// <see href="http://dbpedia.org/ontology/Diocese"></see></summary>
    let Diocese = Namespaced_IRI.parse _namespace_name "Diocese" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Diploma"></see>
    /// </summary>
    let Diploma = Namespaced_IRI.parse _namespace_name "Diploma" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Disease"></see>
    /// </summary>
    let Disease = Namespaced_IRI.parse _namespace_name "Disease" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/DisneyCharacter"></see>
    /// </summary>
    let DisneyCharacter =
        Namespaced_IRI.parse _namespace_name "DisneyCharacter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/District"></see>
    /// </summary>
    let District = Namespaced_IRI.parse _namespace_name "District" |> NamespacedName

    /// <summary>
    /// Conservancy, governmental agency dedicated to surface water management
    /// <see href="http://dbpedia.org/ontology/DistrictWaterBoard"></see></summary>
    let DistrictWaterBoard =
        Namespaced_IRI.parse _namespace_name "DistrictWaterBoard" |> NamespacedName

    /// <summary>
    /// two people's divorce as a type of personal event
    /// <see href="http://dbpedia.org/ontology/Divorce"></see></summary>
    let Divorce = Namespaced_IRI.parse _namespace_name "Divorce" |> NamespacedName
    /// <summary>
    /// Any document
    /// <see href="http://dbpedia.org/ontology/Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName

    /// <summary>
    /// type of document (official, informal etc.)
    /// <see href="http://dbpedia.org/ontology/DocumentType"></see></summary>
    let DocumentType =
        Namespaced_IRI.parse _namespace_name "DocumentType" |> NamespacedName

    /// <summary>
    /// a category within a classification system
    /// <see href="http://dbpedia.org/ontology/Type"></see></summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Dog"></see>
    /// </summary>
    let Dog = Namespaced_IRI.parse _namespace_name "Dog" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Drama"></see>
    /// </summary>
    let Drama = Namespaced_IRI.parse _namespace_name "Drama" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Drug"></see>
    /// </summary>
    let Drug = Namespaced_IRI.parse _namespace_name "Drug" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Drug/boilingPoint"></see>
    /// </summary>
    let ``Drug/boilingPoint`` =
        Namespaced_IRI.parse _namespace_name "Drug/boilingPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Drug/meltingPoint"></see>
    /// </summary>
    let ``Drug/meltingPoint`` =
        Namespaced_IRI.parse _namespace_name "Drug/meltingPoint" |> NamespacedName

    /// <summary>
    /// the result of a sudden release of energy in the Earth's crust that creates seismic waves
    /// <see href="http://dbpedia.org/ontology/Earthquake"></see></summary>
    let Earthquake = Namespaced_IRI.parse _namespace_name "Earthquake" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NaturalEvent"></see>
    /// </summary>
    let NaturalEvent =
        Namespaced_IRI.parse _namespace_name "NaturalEvent" |> NamespacedName

    /// <summary>
    /// An economist is a professional in the social science discipline of economics.
    /// <see href="http://dbpedia.org/ontology/Economist"></see></summary>
    let Economist = Namespaced_IRI.parse _namespace_name "Economist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Egyptologist"></see>
    /// </summary>
    let Egyptologist =
        Namespaced_IRI.parse _namespace_name "Egyptologist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Election"></see>
    /// </summary>
    let Election = Namespaced_IRI.parse _namespace_name "Election" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ElectionDiagram"></see>
    /// </summary>
    let ElectionDiagram =
        Namespaced_IRI.parse _namespace_name "ElectionDiagram" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ElectricalSubstation"></see>
    /// </summary>
    let ElectricalSubstation =
        Namespaced_IRI.parse _namespace_name "ElectricalSubstation" |> NamespacedName

    /// <summary>
    /// Public transport station (eg. railway station, metro station, bus station).
    /// <see href="http://dbpedia.org/ontology/Station"></see></summary>
    let Station = Namespaced_IRI.parse _namespace_name "Station" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Embryology"></see>
    /// </summary>
    let Embryology = Namespaced_IRI.parse _namespace_name "Embryology" |> NamespacedName
    /// <summary>
    /// a person, business, firm, etc, that employs workers.
    /// <see href="http://dbpedia.org/ontology/Employer"></see></summary>
    let Employer = Namespaced_IRI.parse _namespace_name "Employer" |> NamespacedName

    /// <summary>
    /// An employers' organisation is an organisation of entrepreneurs who work together to coordinate their actions in the field of labour relations
    /// <see href="http://dbpedia.org/ontology/EmployersOrganisation"></see></summary>
    let EmployersOrganisation =
        Namespaced_IRI.parse _namespace_name "EmployersOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/acceleration"></see>
    /// </summary>
    let ``Engine/acceleration`` =
        Namespaced_IRI.parse _namespace_name "Engine/acceleration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/co2Emission"></see>
    /// </summary>
    let ``Engine/co2Emission`` =
        Namespaced_IRI.parse _namespace_name "Engine/co2Emission" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/cylinderBore"></see>
    /// </summary>
    let ``Engine/cylinderBore`` =
        Namespaced_IRI.parse _namespace_name "Engine/cylinderBore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/diameter"></see>
    /// </summary>
    let ``Engine/diameter`` =
        Namespaced_IRI.parse _namespace_name "Engine/diameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/displacement"></see>
    /// </summary>
    let ``Engine/displacement`` =
        Namespaced_IRI.parse _namespace_name "Engine/displacement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/height"></see>
    /// </summary>
    let ``Engine/height`` =
        Namespaced_IRI.parse _namespace_name "Engine/height" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/length"></see>
    /// </summary>
    let ``Engine/length`` =
        Namespaced_IRI.parse _namespace_name "Engine/length" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/pistonStroke"></see>
    /// </summary>
    let ``Engine/pistonStroke`` =
        Namespaced_IRI.parse _namespace_name "Engine/pistonStroke" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/powerOutput"></see>
    /// </summary>
    let ``Engine/powerOutput`` =
        Namespaced_IRI.parse _namespace_name "Engine/powerOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/topSpeed"></see>
    /// </summary>
    let ``Engine/topSpeed`` =
        Namespaced_IRI.parse _namespace_name "Engine/topSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/torqueOutput"></see>
    /// </summary>
    let ``Engine/torqueOutput`` =
        Namespaced_IRI.parse _namespace_name "Engine/torqueOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/weight"></see>
    /// </summary>
    let ``Engine/weight`` =
        Namespaced_IRI.parse _namespace_name "Engine/weight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engine/width"></see>
    /// </summary>
    let ``Engine/width`` =
        Namespaced_IRI.parse _namespace_name "Engine/width" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Engineer"></see>
    /// </summary>
    let Engineer = Namespaced_IRI.parse _namespace_name "Engineer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Entomologist"></see>
    /// </summary>
    let Entomologist =
        Namespaced_IRI.parse _namespace_name "Entomologist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Enzyme"></see>
    /// </summary>
    let Enzyme = Namespaced_IRI.parse _namespace_name "Enzyme" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator"></see>
    /// </summary>
    let Escalator = Namespaced_IRI.parse _namespace_name "Escalator" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator/diameter"></see>
    /// </summary>
    let ``Escalator/diameter`` =
        Namespaced_IRI.parse _namespace_name "Escalator/diameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator/height"></see>
    /// </summary>
    let ``Escalator/height`` =
        Namespaced_IRI.parse _namespace_name "Escalator/height" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator/length"></see>
    /// </summary>
    let ``Escalator/length`` =
        Namespaced_IRI.parse _namespace_name "Escalator/length" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator/mass"></see>
    /// </summary>
    let ``Escalator/mass`` =
        Namespaced_IRI.parse _namespace_name "Escalator/mass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator/weight"></see>
    /// </summary>
    let ``Escalator/weight`` =
        Namespaced_IRI.parse _namespace_name "Escalator/weight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Escalator/width"></see>
    /// </summary>
    let ``Escalator/width`` =
        Namespaced_IRI.parse _namespace_name "Escalator/width" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/EthnicGroup"></see>
    /// </summary>
    let EthnicGroup =
        Namespaced_IRI.parse _namespace_name "EthnicGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/EurovisionSongContestEntry"></see>
    /// </summary>
    let EurovisionSongContestEntry =
        Namespaced_IRI.parse _namespace_name "EurovisionSongContestEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Song"></see>
    /// </summary>
    let Song = Namespaced_IRI.parse _namespace_name "Song" |> NamespacedName
    /// <summary>
    /// A factory (previously manufactory) or manufacturing plant is an industrial site, usually consisting of buildings and machinery, or more commonly a complex having several buildings, where workers manufacture goods or operate machines processing one product into another.
    /// <see href="http://dbpedia.org/ontology/Factory"></see></summary>
    let Factory = Namespaced_IRI.parse _namespace_name "Factory" |> NamespacedName
    /// <summary>
    /// A group of people related by common descent, a lineage.
    /// <see href="http://dbpedia.org/ontology/Family"></see></summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Farmer"></see>
    /// </summary>
    let Farmer = Namespaced_IRI.parse _namespace_name "Farmer" |> NamespacedName
    /// <summary>
    /// type or code of dressing, according to the standards of the time or individual design.
    /// <see href="http://dbpedia.org/ontology/Fashion"></see></summary>
    let Fashion = Namespaced_IRI.parse _namespace_name "Fashion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FashionDesigner"></see>
    /// </summary>
    let FashionDesigner =
        Namespaced_IRI.parse _namespace_name "FashionDesigner" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Fencer"></see>
    /// </summary>
    let Fencer = Namespaced_IRI.parse _namespace_name "Fencer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Fern"></see>
    /// </summary>
    let Fern = Namespaced_IRI.parse _namespace_name "Fern" |> NamespacedName
    /// <summary>
    /// The territory under the authority of a feudal lord
    /// <see href="http://dbpedia.org/ontology/Fiefdom"></see></summary>
    let Fiefdom = Namespaced_IRI.parse _namespace_name "Fiefdom" |> NamespacedName

    /// <summary>
    /// Mostly for feudal forms of authority, but can also serve for historical forms of centralised authority
    /// <see href="http://dbpedia.org/ontology/HistoricalAreaOfAuthority"></see></summary>
    let HistoricalAreaOfAuthority =
        Namespaced_IRI.parse _namespace_name "HistoricalAreaOfAuthority" |> NamespacedName

    /// <summary>
    /// a group of sports teams that compete against each other in Field Hockey
    /// <see href="http://dbpedia.org/ontology/FieldHockeyLeague"></see></summary>
    let FieldHockeyLeague =
        Namespaced_IRI.parse _namespace_name "FieldHockeyLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FigureSkater"></see>
    /// </summary>
    let FigureSkater =
        Namespaced_IRI.parse _namespace_name "FigureSkater" |> NamespacedName

    /// <summary>
    /// A document with a filename
    /// <see href="http://dbpedia.org/ontology/File"></see></summary>
    let File = Namespaced_IRI.parse _namespace_name "File" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FillingStation"></see>
    /// </summary>
    let FillingStation =
        Namespaced_IRI.parse _namespace_name "FillingStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Film"></see>
    /// </summary>
    let Film = Namespaced_IRI.parse _namespace_name "Film" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Wikidata:Q11424"></see>
    /// </summary>
    let ``Wikidata:Q11424`` =
        Namespaced_IRI.parse _namespace_name "Wikidata:Q11424" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FilmFestival"></see>
    /// </summary>
    let FilmFestival =
        Namespaced_IRI.parse _namespace_name "FilmFestival" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Fish"></see>
    /// </summary>
    let Fish = Namespaced_IRI.parse _namespace_name "Fish" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Flag"></see>
    /// </summary>
    let Flag = Namespaced_IRI.parse _namespace_name "Flag" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FloweringPlant"></see>
    /// </summary>
    let FloweringPlant =
        Namespaced_IRI.parse _namespace_name "FloweringPlant" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FootballLeagueSeason"></see>
    /// </summary>
    let FootballLeagueSeason =
        Namespaced_IRI.parse _namespace_name "FootballLeagueSeason" |> NamespacedName

    /// <summary>
    /// a competition between two football teams
    /// <see href="http://dbpedia.org/ontology/FootballMatch"></see></summary>
    let FootballMatch =
        Namespaced_IRI.parse _namespace_name "FootballMatch" |> NamespacedName

    /// <summary>
    /// A municipality that has ceased to exist, and most of the time got incorporated (wholesale or partly) into another municipality
    /// <see href="http://dbpedia.org/ontology/FormerMunicipality"></see></summary>
    let FormerMunicipality =
        Namespaced_IRI.parse _namespace_name "FormerMunicipality" |> NamespacedName

    /// <summary>
    /// An administrative body governing a territorial unity on the lower level, administering one or a few more settlements
    /// <see href="http://dbpedia.org/ontology/Municipality"></see></summary>
    let Municipality =
        Namespaced_IRI.parse _namespace_name "Municipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FormulaOneRacer"></see>
    /// </summary>
    let FormulaOneRacer =
        Namespaced_IRI.parse _namespace_name "FormulaOneRacer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FormulaOneRacing"></see>
    /// </summary>
    let FormulaOneRacing =
        Namespaced_IRI.parse _namespace_name "FormulaOneRacing" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/FormulaOneTeam"></see>
    /// </summary>
    let FormulaOneTeam =
        Namespaced_IRI.parse _namespace_name "FormulaOneTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Fungus"></see>
    /// </summary>
    let Fungus = Namespaced_IRI.parse _namespace_name "Fungus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GaelicGamesPlayer"></see>
    /// </summary>
    let GaelicGamesPlayer =
        Namespaced_IRI.parse _namespace_name "GaelicGamesPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy"></see>
    /// </summary>
    let Galaxy = Namespaced_IRI.parse _namespace_name "Galaxy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/apoapsis"></see>
    /// </summary>
    let ``Galaxy/apoapsis`` =
        Namespaced_IRI.parse _namespace_name "Galaxy/apoapsis" |> NamespacedName

    /// <summary>
    /// The average speed of a thing.
    /// <see href="http://dbpedia.org/ontology/Galaxy/averageSpeed"></see></summary>
    let ``Galaxy/averageSpeed`` =
        Namespaced_IRI.parse _namespace_name "Galaxy/averageSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/density"></see>
    /// </summary>
    let ``Galaxy/density`` =
        Namespaced_IRI.parse _namespace_name "Galaxy/density" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/mass"></see>
    /// </summary>
    let ``Galaxy/mass`` =
        Namespaced_IRI.parse _namespace_name "Galaxy/mass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/maximumTemperature"></see>
    /// </summary>
    let ``Galaxy/maximumTemperature`` =
        Namespaced_IRI.parse _namespace_name "Galaxy/maximumTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/meanRadius"></see>
    /// </summary>
    let ``Galaxy/meanRadius`` =
        Namespaced_IRI.parse _namespace_name "Galaxy/meanRadius" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/meanTemperature"></see>
    /// </summary>
    let ``Galaxy/meanTemperature`` =
        Namespaced_IRI.parse _namespace_name "Galaxy/meanTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/minimumTemperature"></see>
    /// </summary>
    let ``Galaxy/minimumTemperature`` =
        Namespaced_IRI.parse _namespace_name "Galaxy/minimumTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/orbitalPeriod"></see>
    /// </summary>
    let ``Galaxy/orbitalPeriod`` =
        Namespaced_IRI.parse _namespace_name "Galaxy/orbitalPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/periapsis"></see>
    /// </summary>
    let ``Galaxy/periapsis`` =
        Namespaced_IRI.parse _namespace_name "Galaxy/periapsis" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/surfaceArea"></see>
    /// </summary>
    let ``Galaxy/surfaceArea`` =
        Namespaced_IRI.parse _namespace_name "Galaxy/surfaceArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/temperature"></see>
    /// </summary>
    let ``Galaxy/temperature`` =
        Namespaced_IRI.parse _namespace_name "Galaxy/temperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Galaxy/volume"></see>
    /// </summary>
    let ``Galaxy/volume`` =
        Namespaced_IRI.parse _namespace_name "Galaxy/volume" |> NamespacedName

    /// <summary>
    /// A garden is a planned space, usually outdoors, set aside for the display, cultivation, and enjoyment of plants and other forms of nature. (http://en.wikipedia.org/wiki/Garden)
    /// <see href="http://dbpedia.org/ontology/Garden"></see></summary>
    let Garden = Namespaced_IRI.parse _namespace_name "Garden" |> NamespacedName
    /// <summary>
    /// Gate is defined as a built structure marking the entrance to a building or an estate.
    /// <see href="http://dbpedia.org/ontology/Gate"></see></summary>
    let Gate = Namespaced_IRI.parse _namespace_name "Gate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GatedCommunity"></see>
    /// </summary>
    let GatedCommunity =
        Namespaced_IRI.parse _namespace_name "GatedCommunity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Gene"></see>
    /// </summary>
    let Gene = Namespaced_IRI.parse _namespace_name "Gene" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GeneLocation"></see>
    /// </summary>
    let GeneLocation =
        Namespaced_IRI.parse _namespace_name "GeneLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GeologicalPeriod"></see>
    /// </summary>
    let GeologicalPeriod =
        Namespaced_IRI.parse _namespace_name "GeologicalPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GeopoliticalOrganisation"></see>
    /// </summary>
    let GeopoliticalOrganisation =
        Namespaced_IRI.parse _namespace_name "GeopoliticalOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GeopoliticalOrganisation/areaMetro"></see>
    /// </summary>
    let ``GeopoliticalOrganisation/areaMetro`` =
        Namespaced_IRI.parse _namespace_name "GeopoliticalOrganisation/areaMetro" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GeopoliticalOrganisation/populationDensity"></see>
    /// </summary>
    let ``GeopoliticalOrganisation/populationDensity`` =
        Namespaced_IRI.parse _namespace_name "GeopoliticalOrganisation/populationDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Ginkgo"></see>
    /// </summary>
    let Ginkgo = Namespaced_IRI.parse _namespace_name "Ginkgo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GivenName"></see>
    /// </summary>
    let GivenName = Namespaced_IRI.parse _namespace_name "GivenName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Name"></see>
    /// </summary>
    let Name = Namespaced_IRI.parse _namespace_name "Name" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Glacier"></see>
    /// </summary>
    let Glacier = Namespaced_IRI.parse _namespace_name "Glacier" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Globularswarm"></see>
    /// </summary>
    let Globularswarm =
        Namespaced_IRI.parse _namespace_name "Globularswarm" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Swarm"></see>
    /// </summary>
    let Swarm = Namespaced_IRI.parse _namespace_name "Swarm" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Gnetophytes"></see>
    /// </summary>
    let Gnetophytes =
        Namespaced_IRI.parse _namespace_name "Gnetophytes" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GolfCourse"></see>
    /// </summary>
    let GolfCourse = Namespaced_IRI.parse _namespace_name "GolfCourse" |> NamespacedName
    /// <summary>
    /// Golfplayer that compete against each other in Golf
    /// <see href="http://dbpedia.org/ontology/GolfLeague"></see></summary>
    let GolfLeague = Namespaced_IRI.parse _namespace_name "GolfLeague" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GolfPlayer"></see>
    /// </summary>
    let GolfPlayer = Namespaced_IRI.parse _namespace_name "GolfPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GolfTournament"></see>
    /// </summary>
    let GolfTournament =
        Namespaced_IRI.parse _namespace_name "GolfTournament" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Tournament"></see>
    /// </summary>
    let Tournament = Namespaced_IRI.parse _namespace_name "Tournament" |> NamespacedName

    /// <summary>
    /// A government agency is a permanent or semi-permanent organization in the machinery of government that is responsible for the oversight and administration of specific functions, such as an intelligence agency.
    /// <see href="http://dbpedia.org/ontology/GovernmentAgency"></see></summary>
    let GovernmentAgency =
        Namespaced_IRI.parse _namespace_name "GovernmentAgency" |> NamespacedName

    /// <summary>
    /// A cabinet is a body of high-ranking state officials, typically consisting of the top leaders of the executive branch.
    /// <see href="http://dbpedia.org/ontology/GovernmentCabinet"></see></summary>
    let GovernmentCabinet =
        Namespaced_IRI.parse _namespace_name "GovernmentCabinet" |> NamespacedName

    /// <summary>
    /// a form of government
    /// <see href="http://dbpedia.org/ontology/GovernmentType"></see></summary>
    let GovernmentType =
        Namespaced_IRI.parse _namespace_name "GovernmentType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Governor"></see>
    /// </summary>
    let Governor = Namespaced_IRI.parse _namespace_name "Governor" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GrandPrix"></see>
    /// </summary>
    let GrandPrix = Namespaced_IRI.parse _namespace_name "GrandPrix" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GrandPrix/course"></see>
    /// </summary>
    let ``GrandPrix/course`` =
        Namespaced_IRI.parse _namespace_name "GrandPrix/course" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GrandPrix/distance"></see>
    /// </summary>
    let ``GrandPrix/distance`` =
        Namespaced_IRI.parse _namespace_name "GrandPrix/distance" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Grape"></see>
    /// </summary>
    let Grape = Namespaced_IRI.parse _namespace_name "Grape" |> NamespacedName

    /// <summary>
    /// A monument erected on a tomb, or a memorial stone.
    /// <see href="http://dbpedia.org/ontology/GraveMonument"></see></summary>
    let GraveMonument =
        Namespaced_IRI.parse _namespace_name "GraveMonument" |> NamespacedName

    /// <summary>
    /// A type of structure (a statue or an art object) created to commemorate a person or important event, not necessarily of a catastrophic nature.
    /// <see href="http://dbpedia.org/ontology/Monument"></see></summary>
    let Monument = Namespaced_IRI.parse _namespace_name "Monument" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GreenAlga"></see>
    /// </summary>
    let GreenAlga = Namespaced_IRI.parse _namespace_name "GreenAlga" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GrossDomesticProduct"></see>
    /// </summary>
    let GrossDomesticProduct =
        Namespaced_IRI.parse _namespace_name "GrossDomesticProduct" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GrossDomesticProductPerCapita"></see>
    /// </summary>
    let GrossDomesticProductPerCapita =
        Namespaced_IRI.parse _namespace_name "GrossDomesticProductPerCapita" |> NamespacedName

    /// <summary>
    /// Describes the guitar
    /// <see href="http://dbpedia.org/ontology/Guitar"></see></summary>
    let Guitar = Namespaced_IRI.parse _namespace_name "Guitar" |> NamespacedName
    /// <summary>
    /// Describes all musical instrument
    /// <see href="http://dbpedia.org/ontology/Instrument"></see></summary>
    let Instrument = Namespaced_IRI.parse _namespace_name "Instrument" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Guitarist"></see>
    /// </summary>
    let Guitarist = Namespaced_IRI.parse _namespace_name "Guitarist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Instrumentalist"></see>
    /// </summary>
    let Instrumentalist =
        Namespaced_IRI.parse _namespace_name "Instrumentalist" |> NamespacedName

    /// <summary>
    /// A gymnast is one who performs gymnastics
    /// <see href="http://dbpedia.org/ontology/Gymnast"></see></summary>
    let Gymnast = Namespaced_IRI.parse _namespace_name "Gymnast" |> NamespacedName

    /// <summary>
    /// a group of sports teams that compete against each other in Handball
    /// <see href="http://dbpedia.org/ontology/HandballLeague"></see></summary>
    let HandballLeague =
        Namespaced_IRI.parse _namespace_name "HandballLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HandballPlayer"></see>
    /// </summary>
    let HandballPlayer =
        Namespaced_IRI.parse _namespace_name "HandballPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HandballTeam"></see>
    /// </summary>
    let HandballTeam =
        Namespaced_IRI.parse _namespace_name "HandballTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HighDiver"></see>
    /// </summary>
    let HighDiver = Namespaced_IRI.parse _namespace_name "HighDiver" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Historian"></see>
    /// </summary>
    let Historian = Namespaced_IRI.parse _namespace_name "Historian" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Writer"></see>
    /// </summary>
    let Writer = Namespaced_IRI.parse _namespace_name "Writer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HistoricBuilding"></see>
    /// </summary>
    let HistoricBuilding =
        Namespaced_IRI.parse _namespace_name "HistoricBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HistoricPlace"></see>
    /// </summary>
    let HistoricPlace =
        Namespaced_IRI.parse _namespace_name "HistoricPlace" |> NamespacedName

    /// <summary>
    /// A place which used to be a country.
    /// <see href="http://dbpedia.org/ontology/HistoricalCountry"></see></summary>
    let HistoricalCountry =
        Namespaced_IRI.parse _namespace_name "HistoricalCountry" |> NamespacedName

    /// <summary>
    /// a place which used to be a district.
    /// <see href="http://dbpedia.org/ontology/HistoricalDistrict"></see></summary>
    let HistoricalDistrict =
        Namespaced_IRI.parse _namespace_name "HistoricalDistrict" |> NamespacedName

    /// <summary>
    /// A historical Period should be linked to a Place by way of the property dct:spatial (already defined)
    /// <see href="http://dbpedia.org/ontology/HistoricalPeriod"></see></summary>
    let HistoricalPeriod =
        Namespaced_IRI.parse _namespace_name "HistoricalPeriod" |> NamespacedName

    /// <summary>
    /// A place which used to be a province.
    /// <see href="http://dbpedia.org/ontology/HistoricalProvince"></see></summary>
    let HistoricalProvince =
        Namespaced_IRI.parse _namespace_name "HistoricalProvince" |> NamespacedName

    /// <summary>
    /// An administrative body governing a territorial unity on the intermediate level, between local and national level
    /// <see href="http://dbpedia.org/ontology/Province"></see></summary>
    let Province = Namespaced_IRI.parse _namespace_name "Province" |> NamespacedName

    /// <summary>
    /// a place which used to be a region.
    /// <see href="http://dbpedia.org/ontology/HistoricalRegion"></see></summary>
    let HistoricalRegion =
        Namespaced_IRI.parse _namespace_name "HistoricalRegion" |> NamespacedName

    /// <summary>
    /// A place which used to be a city or town or village.
    /// <see href="http://dbpedia.org/ontology/HistoricalSettlement"></see></summary>
    let HistoricalSettlement =
        Namespaced_IRI.parse _namespace_name "HistoricalSettlement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HockeyClub"></see>
    /// </summary>
    let HockeyClub = Namespaced_IRI.parse _namespace_name "HockeyClub" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SportsClub"></see>
    /// </summary>
    let SportsClub = Namespaced_IRI.parse _namespace_name "SportsClub" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HockeyTeam"></see>
    /// </summary>
    let HockeyTeam = Namespaced_IRI.parse _namespace_name "HockeyTeam" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Holiday"></see>
    /// </summary>
    let Holiday = Namespaced_IRI.parse _namespace_name "Holiday" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HollywoodCartoon"></see>
    /// </summary>
    let HollywoodCartoon =
        Namespaced_IRI.parse _namespace_name "HollywoodCartoon" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Horse"></see>
    /// </summary>
    let Horse = Namespaced_IRI.parse _namespace_name "Horse" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HorseRace"></see>
    /// </summary>
    let HorseRace = Namespaced_IRI.parse _namespace_name "HorseRace" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HorseRider"></see>
    /// </summary>
    let HorseRider = Namespaced_IRI.parse _namespace_name "HorseRider" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HorseRiding"></see>
    /// </summary>
    let HorseRiding =
        Namespaced_IRI.parse _namespace_name "HorseRiding" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HorseTrainer"></see>
    /// </summary>
    let HorseTrainer =
        Namespaced_IRI.parse _namespace_name "HorseTrainer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Hospital"></see>
    /// </summary>
    let Hospital = Namespaced_IRI.parse _namespace_name "Hospital" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Host"></see>
    /// </summary>
    let Host = Namespaced_IRI.parse _namespace_name "Host" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TelevisionPersonality"></see>
    /// </summary>
    let TelevisionPersonality =
        Namespaced_IRI.parse _namespace_name "TelevisionPersonality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HotSpring"></see>
    /// </summary>
    let HotSpring = Namespaced_IRI.parse _namespace_name "HotSpring" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Hotel"></see>
    /// </summary>
    let Hotel = Namespaced_IRI.parse _namespace_name "Hotel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HumanDevelopmentIndex"></see>
    /// </summary>
    let HumanDevelopmentIndex =
        Namespaced_IRI.parse _namespace_name "HumanDevelopmentIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HumanGene"></see>
    /// </summary>
    let HumanGene = Namespaced_IRI.parse _namespace_name "HumanGene" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HumanGeneLocation"></see>
    /// </summary>
    let HumanGeneLocation =
        Namespaced_IRI.parse _namespace_name "HumanGeneLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Humorist"></see>
    /// </summary>
    let Humorist = Namespaced_IRI.parse _namespace_name "Humorist" |> NamespacedName

    /// <summary>
    /// a group of sports teams that compete against each other in Ice Hockey.
    /// <see href="http://dbpedia.org/ontology/IceHockeyLeague"></see></summary>
    let IceHockeyLeague =
        Namespaced_IRI.parse _namespace_name "IceHockeyLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/IceHockeyPlayer"></see>
    /// </summary>
    let IceHockeyPlayer =
        Namespaced_IRI.parse _namespace_name "IceHockeyPlayer" |> NamespacedName

    /// <summary>
    /// for example: Progressivism_in_the_United_States, Classical_liberalism
    /// <see href="http://dbpedia.org/ontology/Ideology"></see></summary>
    let Ideology = Namespaced_IRI.parse _namespace_name "Ideology" |> NamespacedName
    /// <summary>
    /// A document that contains a visual image
    /// <see href="http://dbpedia.org/ontology/Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName

    /// <summary>
    /// An information device such as PDAs or Video game consoles, etc.
    /// <see href="http://dbpedia.org/ontology/InformationAppliance"></see></summary>
    let InformationAppliance =
        Namespaced_IRI.parse _namespace_name "InformationAppliance" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Infrastructure/length"></see>
    /// </summary>
    let ``Infrastructure/length`` =
        Namespaced_IRI.parse _namespace_name "Infrastructure/length" |> NamespacedName

    /// <summary>
    /// group of sports teams that compete against each other in Inline Hockey.
    /// <see href="http://dbpedia.org/ontology/InlineHockeyLeague"></see></summary>
    let InlineHockeyLeague =
        Namespaced_IRI.parse _namespace_name "InlineHockeyLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Insect"></see>
    /// </summary>
    let Insect = Namespaced_IRI.parse _namespace_name "Insect" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Intercommunality"></see>
    /// </summary>
    let Intercommunality =
        Namespaced_IRI.parse _namespace_name "Intercommunality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/InternationalFootballLeagueEvent"></see>
    /// </summary>
    let InternationalFootballLeagueEvent =
        Namespaced_IRI.parse _namespace_name "InternationalFootballLeagueEvent" |> NamespacedName

    /// <summary>
    /// An international organisation is either a private or a public organisation seeking to accomplish goals across country borders
    /// <see href="http://dbpedia.org/ontology/InternationalOrganisation"></see></summary>
    let InternationalOrganisation =
        Namespaced_IRI.parse _namespace_name "InternationalOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Jockey"></see>
    /// </summary>
    let Jockey = Namespaced_IRI.parse _namespace_name "Jockey" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Journalist"></see>
    /// </summary>
    let Journalist = Namespaced_IRI.parse _namespace_name "Journalist" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Judge"></see>
    /// </summary>
    let Judge = Namespaced_IRI.parse _namespace_name "Judge" |> NamespacedName

    /// <summary>
    /// a group of sports teams that compete against each other in Lacrosse.
    /// <see href="http://dbpedia.org/ontology/LacrosseLeague"></see></summary>
    let LacrosseLeague =
        Namespaced_IRI.parse _namespace_name "LacrosseLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LacrossePlayer"></see>
    /// </summary>
    let LacrossePlayer =
        Namespaced_IRI.parse _namespace_name "LacrossePlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lake"></see>
    /// </summary>
    let Lake = Namespaced_IRI.parse _namespace_name "Lake" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lake/areaOfCatchment"></see>
    /// </summary>
    let ``Lake/areaOfCatchment`` =
        Namespaced_IRI.parse _namespace_name "Lake/areaOfCatchment" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lake/shoreLength"></see>
    /// </summary>
    let ``Lake/shoreLength`` =
        Namespaced_IRI.parse _namespace_name "Lake/shoreLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lake/volume"></see>
    /// </summary>
    let ``Lake/volume`` =
        Namespaced_IRI.parse _namespace_name "Lake/volume" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Language"></see>
    /// </summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LaunchPad"></see>
    /// </summary>
    let LaunchPad = Namespaced_IRI.parse _namespace_name "LaunchPad" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Law"></see>
    /// </summary>
    let Law = Namespaced_IRI.parse _namespace_name "Law" |> NamespacedName
    /// <summary>
    /// A law firm is a business entity formed by one or more lawyers to engage in the practice of law. The primary service provided by a law firm is to advise clients (individuals or corporations) about their legal rights and responsibilities, and to represent their clients in civil or criminal cases, business transactions, and other matters in which legal advice and other assistance are sought.
    /// <see href="http://dbpedia.org/ontology/LawFirm"></see></summary>
    let LawFirm = Namespaced_IRI.parse _namespace_name "LawFirm" |> NamespacedName
    /// <summary>
    /// a person who is practicing law.
    /// <see href="http://dbpedia.org/ontology/Lawyer"></see></summary>
    let Lawyer = Namespaced_IRI.parse _namespace_name "Lawyer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LegalCase"></see>
    /// </summary>
    let LegalCase = Namespaced_IRI.parse _namespace_name "LegalCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Legislature"></see>
    /// </summary>
    let Legislature =
        Namespaced_IRI.parse _namespace_name "Legislature" |> NamespacedName

    /// <summary>
    /// A letter from the alphabet.
    /// <see href="http://dbpedia.org/ontology/Letter"></see></summary>
    let Letter = Namespaced_IRI.parse _namespace_name "Letter" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Library"></see>
    /// </summary>
    let Library = Namespaced_IRI.parse _namespace_name "Library" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lieutenant"></see>
    /// </summary>
    let Lieutenant = Namespaced_IRI.parse _namespace_name "Lieutenant" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LifeCycleEvent"></see>
    /// </summary>
    let LifeCycleEvent =
        Namespaced_IRI.parse _namespace_name "LifeCycleEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Ligament"></see>
    /// </summary>
    let Ligament = Namespaced_IRI.parse _namespace_name "Ligament" |> NamespacedName
    /// <summary>
    /// A style of Japanese novel
    /// <see href="http://dbpedia.org/ontology/LightNovel"></see></summary>
    let LightNovel = Namespaced_IRI.parse _namespace_name "LightNovel" |> NamespacedName
    /// <summary>
    /// A book of long narrative in literary prose
    /// <see href="http://dbpedia.org/ontology/Novel"></see></summary>
    let Novel = Namespaced_IRI.parse _namespace_name "Novel" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lighthouse"></see>
    /// </summary>
    let Lighthouse = Namespaced_IRI.parse _namespace_name "Lighthouse" |> NamespacedName
    /// <summary>
    /// A Tower is a kind of structure (not necessarily a building) that is higher than the rest
    /// <see href="http://dbpedia.org/ontology/Tower"></see></summary>
    let Tower = Namespaced_IRI.parse _namespace_name "Tower" |> NamespacedName

    /// <summary>
    /// A coherent type of clothing or dressing following a particular fashion
    /// <see href="http://dbpedia.org/ontology/LineOfFashion"></see></summary>
    let LineOfFashion =
        Namespaced_IRI.parse _namespace_name "LineOfFashion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Linguist"></see>
    /// </summary>
    let Linguist = Namespaced_IRI.parse _namespace_name "Linguist" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lipid"></see>
    /// </summary>
    let Lipid = Namespaced_IRI.parse _namespace_name "Lipid" |> NamespacedName
    /// <summary>
    /// A general list of items.
    /// <see href="http://dbpedia.org/ontology/List"></see></summary>
    let List = Namespaced_IRI.parse _namespace_name "List" |> NamespacedName

    /// <summary>
    /// Genres of literature, e.g. Satire, Gothic
    /// <see href="http://dbpedia.org/ontology/LiteraryGenre"></see></summary>
    let LiteraryGenre =
        Namespaced_IRI.parse _namespace_name "LiteraryGenre" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Locality"></see>
    /// </summary>
    let Locality = Namespaced_IRI.parse _namespace_name "Locality" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lock"></see>
    /// </summary>
    let Lock = Namespaced_IRI.parse _namespace_name "Lock" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Locomotive"></see>
    /// </summary>
    let Locomotive = Namespaced_IRI.parse _namespace_name "Locomotive" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LunarCrater"></see>
    /// </summary>
    let LunarCrater =
        Namespaced_IRI.parse _namespace_name "LunarCrater" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LunarCrater/diameter"></see>
    /// </summary>
    let ``LunarCrater/diameter`` =
        Namespaced_IRI.parse _namespace_name "LunarCrater/diameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Lymph"></see>
    /// </summary>
    let Lymph = Namespaced_IRI.parse _namespace_name "Lymph" |> NamespacedName
    /// <summary>
    /// Magazines, periodicals, glossies or serials are publications, generally published on a regular schedule, containing a variety of articles. They are generally financed by advertising, by a purchase price, by pre-paid magazine subscriptions, or all three.
    /// <see href="http://dbpedia.org/ontology/Magazine"></see></summary>
    let Magazine = Namespaced_IRI.parse _namespace_name "Magazine" |> NamespacedName
    /// <summary>
    /// Manga are comics created in Japan
    /// <see href="http://dbpedia.org/ontology/Manga"></see></summary>
    let Manga = Namespaced_IRI.parse _namespace_name "Manga" |> NamespacedName
    /// <summary>
    /// Comics originally produced in China
    /// <see href="http://dbpedia.org/ontology/Manhua"></see></summary>
    let Manhua = Namespaced_IRI.parse _namespace_name "Manhua" |> NamespacedName
    /// <summary>
    /// Korean term for comics and print cartoons
    /// <see href="http://dbpedia.org/ontology/Manhwa"></see></summary>
    let Manhwa = Namespaced_IRI.parse _namespace_name "Manhwa" |> NamespacedName
    /// <summary>
    /// someone's marriage as a type of personal event
    /// <see href="http://dbpedia.org/ontology/Marriage"></see></summary>
    let Marriage = Namespaced_IRI.parse _namespace_name "Marriage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MartialArtist"></see>
    /// </summary>
    let MartialArtist =
        Namespaced_IRI.parse _namespace_name "MartialArtist" |> NamespacedName

    /// <summary>
    /// Mathematical concepts, e.g. Fibonacci numbers, Imaginary numbers, Symmetry
    /// <see href="http://dbpedia.org/ontology/MathematicalConcept"></see></summary>
    let MathematicalConcept =
        Namespaced_IRI.parse _namespace_name "MathematicalConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Mayor"></see>
    /// </summary>
    let Mayor = Namespaced_IRI.parse _namespace_name "Mayor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation/diameter"></see>
    /// </summary>
    let ``MeanOfTransportation/diameter`` =
        Namespaced_IRI.parse _namespace_name "MeanOfTransportation/diameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation/height"></see>
    /// </summary>
    let ``MeanOfTransportation/height`` =
        Namespaced_IRI.parse _namespace_name "MeanOfTransportation/height" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation/length"></see>
    /// </summary>
    let ``MeanOfTransportation/length`` =
        Namespaced_IRI.parse _namespace_name "MeanOfTransportation/length" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation/mass"></see>
    /// </summary>
    let ``MeanOfTransportation/mass`` =
        Namespaced_IRI.parse _namespace_name "MeanOfTransportation/mass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation/weight"></see>
    /// </summary>
    let ``MeanOfTransportation/weight`` =
        Namespaced_IRI.parse _namespace_name "MeanOfTransportation/weight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation/width"></see>
    /// </summary>
    let ``MeanOfTransportation/width`` =
        Namespaced_IRI.parse _namespace_name "MeanOfTransportation/width" |> NamespacedName

    /// <summary>
    /// storage and transmission channels or tools used to store and deliver information or data
    /// <see href="http://dbpedia.org/ontology/Media"></see></summary>
    let Media = Namespaced_IRI.parse _namespace_name "Media" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Medician"></see>
    /// </summary>
    let Medician = Namespaced_IRI.parse _namespace_name "Medician" |> NamespacedName
    /// <summary>
    /// The science and art of healing the human body and identifying the causes of disease
    /// <see href="http://dbpedia.org/ontology/Medicine"></see></summary>
    let Medicine = Namespaced_IRI.parse _namespace_name "Medicine" |> NamespacedName
    /// <summary>
    /// A regular or irregular meeting of people as an event to keep record of
    /// <see href="http://dbpedia.org/ontology/Meeting"></see></summary>
    let Meeting = Namespaced_IRI.parse _namespace_name "Meeting" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MemberOfParliament"></see>
    /// </summary>
    let MemberOfParliament =
        Namespaced_IRI.parse _namespace_name "MemberOfParliament" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MemberResistanceMovement"></see>
    /// </summary>
    let MemberResistanceMovement =
        Namespaced_IRI.parse _namespace_name "MemberResistanceMovement" |> NamespacedName

    /// <summary>
    /// A monument erected to commemorate a person, an event and/or group. In the case of a person, this might be a grave or tomb.
    /// <see href="http://dbpedia.org/ontology/Memorial"></see></summary>
    let Memorial = Namespaced_IRI.parse _namespace_name "Memorial" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MetroStation"></see>
    /// </summary>
    let MetroStation =
        Namespaced_IRI.parse _namespace_name "MetroStation" |> NamespacedName

    /// <summary>
    /// A microregion is a - mainy statistical - region in Brazil, at an administrative level between a meso-region and a community
    /// <see href="http://dbpedia.org/ontology/MicroRegion"></see></summary>
    let MicroRegion =
        Namespaced_IRI.parse _namespace_name "MicroRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryAircraft"></see>
    /// </summary>
    let MilitaryAircraft =
        Namespaced_IRI.parse _namespace_name "MilitaryAircraft" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryConflict"></see>
    /// </summary>
    let MilitaryConflict =
        Namespaced_IRI.parse _namespace_name "MilitaryConflict" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryPerson"></see>
    /// </summary>
    let MilitaryPerson =
        Namespaced_IRI.parse _namespace_name "MilitaryPerson" |> NamespacedName

    /// <summary>
    /// A military structure such as a Castle, Fortress, Wall, etc.
    /// <see href="http://dbpedia.org/ontology/MilitaryStructure"></see></summary>
    let MilitaryStructure =
        Namespaced_IRI.parse _namespace_name "MilitaryStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryUnit"></see>
    /// </summary>
    let MilitaryUnit =
        Namespaced_IRI.parse _namespace_name "MilitaryUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryVehicle"></see>
    /// </summary>
    let MilitaryVehicle =
        Namespaced_IRI.parse _namespace_name "MilitaryVehicle" |> NamespacedName

    /// <summary>
    /// a unit operation designed to break a solid material into smaller pieces
    /// <see href="http://dbpedia.org/ontology/Mill"></see></summary>
    let Mill = Namespaced_IRI.parse _namespace_name "Mill" |> NamespacedName
    /// <summary>
    /// A naturally occurring solid chemical substance.
    /// <see href="http://dbpedia.org/ontology/Mineral"></see></summary>
    let Mineral = Namespaced_IRI.parse _namespace_name "Mineral" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MixedMartialArtsEvent"></see>
    /// </summary>
    let MixedMartialArtsEvent =
        Namespaced_IRI.parse _namespace_name "MixedMartialArtsEvent" |> NamespacedName

    /// <summary>
    /// a group of sports teams that compete against each other in Mixed Martial Arts
    /// <see href="http://dbpedia.org/ontology/MixedMartialArtsLeague"></see></summary>
    let MixedMartialArtsLeague =
        Namespaced_IRI.parse _namespace_name "MixedMartialArtsLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MobilePhone"></see>
    /// </summary>
    let MobilePhone =
        Namespaced_IRI.parse _namespace_name "MobilePhone" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Model"></see>
    /// </summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Mollusca"></see>
    /// </summary>
    let Mollusca = Namespaced_IRI.parse _namespace_name "Mollusca" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Monarch"></see>
    /// </summary>
    let Monarch = Namespaced_IRI.parse _namespace_name "Monarch" |> NamespacedName
    /// <summary>
    /// A mosque, sometimes spelt mosk, is a place of worship for followers of Islam.
    /// <see href="http://dbpedia.org/ontology/Mosque"></see></summary>
    let Mosque = Namespaced_IRI.parse _namespace_name "Mosque" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Moss"></see>
    /// </summary>
    let Moss = Namespaced_IRI.parse _namespace_name "Moss" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MotocycleRacer"></see>
    /// </summary>
    let MotocycleRacer =
        Namespaced_IRI.parse _namespace_name "MotocycleRacer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MotorcycleRider"></see>
    /// </summary>
    let MotorcycleRider =
        Namespaced_IRI.parse _namespace_name "MotorcycleRider" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MotorRace"></see>
    /// </summary>
    let MotorRace = Namespaced_IRI.parse _namespace_name "MotorRace" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Motorcycle"></see>
    /// </summary>
    let Motorcycle = Namespaced_IRI.parse _namespace_name "Motorcycle" |> NamespacedName

    /// <summary>
    /// a group of sports teams or bikerider that compete against each other in Motorcycle Racing
    /// <see href="http://dbpedia.org/ontology/MotorcycleRacingLeague"></see></summary>
    let MotorcycleRacingLeague =
        Namespaced_IRI.parse _namespace_name "MotorcycleRacingLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MotorsportRacer"></see>
    /// </summary>
    let MotorsportRacer =
        Namespaced_IRI.parse _namespace_name "MotorsportRacer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MotorsportSeason"></see>
    /// </summary>
    let MotorsportSeason =
        Namespaced_IRI.parse _namespace_name "MotorsportSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SportsSeason"></see>
    /// </summary>
    let SportsSeason =
        Namespaced_IRI.parse _namespace_name "SportsSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Mountain"></see>
    /// </summary>
    let Mountain = Namespaced_IRI.parse _namespace_name "Mountain" |> NamespacedName

    /// <summary>
    /// a path that allows the crossing of a mountain chain. It is usually a saddle point in between two areas of higher elevation
    /// <see href="http://dbpedia.org/ontology/MountainPass"></see></summary>
    let MountainPass =
        Namespaced_IRI.parse _namespace_name "MountainPass" |> NamespacedName

    /// <summary>
    /// a chain of mountains bordered by highlands or separated from other mountains by passes or valleys.
    /// <see href="http://dbpedia.org/ontology/MountainRange"></see></summary>
    let MountainRange =
        Namespaced_IRI.parse _namespace_name "MountainRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MouseGene"></see>
    /// </summary>
    let MouseGene = Namespaced_IRI.parse _namespace_name "MouseGene" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MouseGeneLocation"></see>
    /// </summary>
    let MouseGeneLocation =
        Namespaced_IRI.parse _namespace_name "MouseGeneLocation" |> NamespacedName

    /// <summary>
    /// a person who oversees making of film.
    /// <see href="http://dbpedia.org/ontology/MovieDirector"></see></summary>
    let MovieDirector =
        Namespaced_IRI.parse _namespace_name "MovieDirector" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovieGenre"></see>
    /// </summary>
    let MovieGenre = Namespaced_IRI.parse _namespace_name "MovieGenre" |> NamespacedName

    /// <summary>
    /// A visual document that is intended to be animated; equivalent to http://purl.org/dc/dcmitype/MovingImage
    /// <see href="http://dbpedia.org/ontology/MovingImage"></see></summary>
    let MovingImage =
        Namespaced_IRI.parse _namespace_name "MovingImage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway"></see>
    /// </summary>
    let MovingWalkway =
        Namespaced_IRI.parse _namespace_name "MovingWalkway" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway/diameter"></see>
    /// </summary>
    let ``MovingWalkway/diameter`` =
        Namespaced_IRI.parse _namespace_name "MovingWalkway/diameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway/height"></see>
    /// </summary>
    let ``MovingWalkway/height`` =
        Namespaced_IRI.parse _namespace_name "MovingWalkway/height" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway/length"></see>
    /// </summary>
    let ``MovingWalkway/length`` =
        Namespaced_IRI.parse _namespace_name "MovingWalkway/length" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway/mass"></see>
    /// </summary>
    let ``MovingWalkway/mass`` =
        Namespaced_IRI.parse _namespace_name "MovingWalkway/mass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway/weight"></see>
    /// </summary>
    let ``MovingWalkway/weight`` =
        Namespaced_IRI.parse _namespace_name "MovingWalkway/weight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MovingWalkway/width"></see>
    /// </summary>
    let ``MovingWalkway/width`` =
        Namespaced_IRI.parse _namespace_name "MovingWalkway/width" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MultiVolumePublication"></see>
    /// </summary>
    let MultiVolumePublication =
        Namespaced_IRI.parse _namespace_name "MultiVolumePublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Murderer"></see>
    /// </summary>
    let Murderer = Namespaced_IRI.parse _namespace_name "Murderer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Muscle"></see>
    /// </summary>
    let Muscle = Namespaced_IRI.parse _namespace_name "Muscle" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Museum"></see>
    /// </summary>
    let Museum = Namespaced_IRI.parse _namespace_name "Museum" |> NamespacedName

    /// <summary>
    /// a person who creates music.
    /// <see href="http://dbpedia.org/ontology/MusicComposer"></see></summary>
    let MusicComposer =
        Namespaced_IRI.parse _namespace_name "MusicComposer" |> NamespacedName

    /// <summary>
    /// A person who is the director of an orchestra or concert band.
    /// <see href="http://dbpedia.org/ontology/MusicDirector"></see></summary>
    let MusicDirector =
        Namespaced_IRI.parse _namespace_name "MusicDirector" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MusicFestival"></see>
    /// </summary>
    let MusicFestival =
        Namespaced_IRI.parse _namespace_name "MusicFestival" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MusicGenre"></see>
    /// </summary>
    let MusicGenre = Namespaced_IRI.parse _namespace_name "MusicGenre" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Musical"></see>
    /// </summary>
    let Musical = Namespaced_IRI.parse _namespace_name "Musical" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MythologicalFigure"></see>
    /// </summary>
    let MythologicalFigure =
        Namespaced_IRI.parse _namespace_name "MythologicalFigure" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NCAATeamSeason"></see>
    /// </summary>
    let NCAATeamSeason =
        Namespaced_IRI.parse _namespace_name "NCAATeamSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NarutoCharacter"></see>
    /// </summary>
    let NarutoCharacter =
        Namespaced_IRI.parse _namespace_name "NarutoCharacter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NascarDriver"></see>
    /// </summary>
    let NascarDriver =
        Namespaced_IRI.parse _namespace_name "NascarDriver" |> NamespacedName

    /// <summary>
    /// Patriotic musical composition which is the offcial national song.
    /// <see href="http://dbpedia.org/ontology/NationalAnthem"></see></summary>
    let NationalAnthem =
        Namespaced_IRI.parse _namespace_name "NationalAnthem" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NationalCollegiateAthleticAssociationAthlete"></see>
    /// </summary>
    let NationalCollegiateAthleticAssociationAthlete =
        Namespaced_IRI.parse _namespace_name "NationalCollegiateAthleticAssociationAthlete" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NationalFootballLeagueEvent"></see>
    /// </summary>
    let NationalFootballLeagueEvent =
        Namespaced_IRI.parse _namespace_name "NationalFootballLeagueEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NationalFootballLeagueSeason"></see>
    /// </summary>
    let NationalFootballLeagueSeason =
        Namespaced_IRI.parse _namespace_name "NationalFootballLeagueSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NationalSoccerClub"></see>
    /// </summary>
    let NationalSoccerClub =
        Namespaced_IRI.parse _namespace_name "NationalSoccerClub" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoccerClub"></see>
    /// </summary>
    let SoccerClub = Namespaced_IRI.parse _namespace_name "SoccerClub" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NaturalRegion"></see>
    /// </summary>
    let NaturalRegion =
        Namespaced_IRI.parse _namespace_name "NaturalRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Nerve"></see>
    /// </summary>
    let Nerve = Namespaced_IRI.parse _namespace_name "Nerve" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NetballPlayer"></see>
    /// </summary>
    let NetballPlayer =
        Namespaced_IRI.parse _namespace_name "NetballPlayer" |> NamespacedName

    /// <summary>
    /// A newspaper is a regularly scheduled publication containing news of current events, informative articles, diverse features and advertising. It usually is printed on relatively inexpensive, low-grade paper such as newsprint.
    /// <see href="http://dbpedia.org/ontology/Newspaper"></see></summary>
    let Newspaper = Namespaced_IRI.parse _namespace_name "Newspaper" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NobelPrize"></see>
    /// </summary>
    let NobelPrize = Namespaced_IRI.parse _namespace_name "NobelPrize" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Noble"></see>
    /// </summary>
    let Noble = Namespaced_IRI.parse _namespace_name "Noble" |> NamespacedName

    /// <summary>
    /// Family deemed to be of noble descent
    /// <see href="http://dbpedia.org/ontology/NobleFamily"></see></summary>
    let NobleFamily =
        Namespaced_IRI.parse _namespace_name "NobleFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Non-ProfitOrganisation"></see>
    /// </summary>
    let ``Non-ProfitOrganisation`` =
        Namespaced_IRI.parse _namespace_name "Non-ProfitOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NordicCombined"></see>
    /// </summary>
    let NordicCombined =
        Namespaced_IRI.parse _namespace_name "NordicCombined" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NuclearPowerStation"></see>
    /// </summary>
    let NuclearPowerStation =
        Namespaced_IRI.parse _namespace_name "NuclearPowerStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PowerStation"></see>
    /// </summary>
    let PowerStation =
        Namespaced_IRI.parse _namespace_name "PowerStation" |> NamespacedName

    /// <summary>
    /// A body of saline water that composes much of a planet's hydrosphere.
    /// <see href="http://dbpedia.org/ontology/Ocean"></see></summary>
    let Ocean = Namespaced_IRI.parse _namespace_name "Ocean" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/OfficeHolder"></see>
    /// </summary>
    let OfficeHolder =
        Namespaced_IRI.parse _namespace_name "OfficeHolder" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/OldTerritory"></see>
    /// </summary>
    let OldTerritory =
        Namespaced_IRI.parse _namespace_name "OldTerritory" |> NamespacedName

    /// <summary>
    /// A territory may refer to a country subdivision, a non-sovereign geographic region.
    /// <see href="http://dbpedia.org/ontology/Territory"></see></summary>
    let Territory = Namespaced_IRI.parse _namespace_name "Territory" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/OlympicEvent"></see>
    /// </summary>
    let OlympicEvent =
        Namespaced_IRI.parse _namespace_name "OlympicEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Olympics"></see>
    /// </summary>
    let Olympics = Namespaced_IRI.parse _namespace_name "Olympics" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/OlympicResult"></see>
    /// </summary>
    let OlympicResult =
        Namespaced_IRI.parse _namespace_name "OlympicResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SportCompetitionResult"></see>
    /// </summary>
    let SportCompetitionResult =
        Namespaced_IRI.parse _namespace_name "SportCompetitionResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation/diameter"></see>
    /// </summary>
    let ``On-SiteTransportation/diameter`` =
        Namespaced_IRI.parse _namespace_name "On-SiteTransportation/diameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation/height"></see>
    /// </summary>
    let ``On-SiteTransportation/height`` =
        Namespaced_IRI.parse _namespace_name "On-SiteTransportation/height" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation/length"></see>
    /// </summary>
    let ``On-SiteTransportation/length`` =
        Namespaced_IRI.parse _namespace_name "On-SiteTransportation/length" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation/mass"></see>
    /// </summary>
    let ``On-SiteTransportation/mass`` =
        Namespaced_IRI.parse _namespace_name "On-SiteTransportation/mass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation/weight"></see>
    /// </summary>
    let ``On-SiteTransportation/weight`` =
        Namespaced_IRI.parse _namespace_name "On-SiteTransportation/weight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/On-SiteTransportation/width"></see>
    /// </summary>
    let ``On-SiteTransportation/width`` =
        Namespaced_IRI.parse _namespace_name "On-SiteTransportation/width" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Openswarm"></see>
    /// </summary>
    let Openswarm = Namespaced_IRI.parse _namespace_name "Openswarm" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Opera"></see>
    /// </summary>
    let Opera = Namespaced_IRI.parse _namespace_name "Opera" |> NamespacedName
    /// <summary>
    /// All types and sizes of organs
    /// <see href="http://dbpedia.org/ontology/Organ"></see></summary>
    let Organ = Namespaced_IRI.parse _namespace_name "Organ" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wgs84_pos:SpatialThing"></see>
    /// </summary>
    let ``wgs84_pos:SpatialThing`` =
        Namespaced_IRI.parse _namespace_name "wgs84_pos:SpatialThing" |> NamespacedName

    /// <summary>
    /// A member of an organisation.
    /// <see href="http://dbpedia.org/ontology/OrganisationMember"></see></summary>
    let OrganisationMember =
        Namespaced_IRI.parse _namespace_name "OrganisationMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Orphan"></see>
    /// </summary>
    let Orphan = Namespaced_IRI.parse _namespace_name "Orphan" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/OverseasDepartment"></see>
    /// </summary>
    let OverseasDepartment =
        Namespaced_IRI.parse _namespace_name "OverseasDepartment" |> NamespacedName

    /// <summary>
    /// a group of sports teams that compete against each other in Paintball
    /// <see href="http://dbpedia.org/ontology/PaintballLeague"></see></summary>
    let PaintballLeague =
        Namespaced_IRI.parse _namespace_name "PaintballLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Painter"></see>
    /// </summary>
    let Painter = Namespaced_IRI.parse _namespace_name "Painter" |> NamespacedName
    /// <summary>
    /// Describes a painting to assign picture entries in wikipedia to artists.
    /// <see href="http://dbpedia.org/ontology/Painting"></see></summary>
    let Painting = Namespaced_IRI.parse _namespace_name "Painting" |> NamespacedName
    /// <summary>
    /// The smallest unit of a clerical administrative body
    /// <see href="http://dbpedia.org/ontology/Parish"></see></summary>
    let Parish = Namespaced_IRI.parse _namespace_name "Parish" |> NamespacedName
    /// <summary>
    /// A park is an area of open space provided for recreational use. http://en.wikipedia.org/wiki/Park
    /// <see href="http://dbpedia.org/ontology/Park"></see></summary>
    let Park = Namespaced_IRI.parse _namespace_name "Park" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Parliament"></see>
    /// </summary>
    let Parliament = Namespaced_IRI.parse _namespace_name "Parliament" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PenaltyShootOut"></see>
    /// </summary>
    let PenaltyShootOut =
        Namespaced_IRI.parse _namespace_name "PenaltyShootOut" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PeriodOfArtisticStyle"></see>
    /// </summary>
    let PeriodOfArtisticStyle =
        Namespaced_IRI.parse _namespace_name "PeriodOfArtisticStyle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Person/height"></see>
    /// </summary>
    let ``Person/height`` =
        Namespaced_IRI.parse _namespace_name "Person/height" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Person/weight"></see>
    /// </summary>
    let ``Person/weight`` =
        Namespaced_IRI.parse _namespace_name "Person/weight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PersonFunction"></see>
    /// </summary>
    let PersonFunction =
        Namespaced_IRI.parse _namespace_name "PersonFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Philosopher"></see>
    /// </summary>
    let Philosopher =
        Namespaced_IRI.parse _namespace_name "Philosopher" |> NamespacedName

    /// <summary>
    /// Philosophical concepts, e.g. Existentialism, Cogito Ergo Sum
    /// <see href="http://dbpedia.org/ontology/PhilosophicalConcept"></see></summary>
    let PhilosophicalConcept =
        Namespaced_IRI.parse _namespace_name "PhilosophicalConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Photographer"></see>
    /// </summary>
    let Photographer =
        Namespaced_IRI.parse _namespace_name "Photographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Location"></see>
    /// </summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet"></see>
    /// </summary>
    let Planet = Namespaced_IRI.parse _namespace_name "Planet" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/apoapsis"></see>
    /// </summary>
    let ``Planet/apoapsis`` =
        Namespaced_IRI.parse _namespace_name "Planet/apoapsis" |> NamespacedName

    /// <summary>
    /// The average speed of a thing.
    /// <see href="http://dbpedia.org/ontology/Planet/averageSpeed"></see></summary>
    let ``Planet/averageSpeed`` =
        Namespaced_IRI.parse _namespace_name "Planet/averageSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/density"></see>
    /// </summary>
    let ``Planet/density`` =
        Namespaced_IRI.parse _namespace_name "Planet/density" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/mass"></see>
    /// </summary>
    let ``Planet/mass`` =
        Namespaced_IRI.parse _namespace_name "Planet/mass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/maximumTemperature"></see>
    /// </summary>
    let ``Planet/maximumTemperature`` =
        Namespaced_IRI.parse _namespace_name "Planet/maximumTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/meanRadius"></see>
    /// </summary>
    let ``Planet/meanRadius`` =
        Namespaced_IRI.parse _namespace_name "Planet/meanRadius" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/meanTemperature"></see>
    /// </summary>
    let ``Planet/meanTemperature`` =
        Namespaced_IRI.parse _namespace_name "Planet/meanTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/minimumTemperature"></see>
    /// </summary>
    let ``Planet/minimumTemperature`` =
        Namespaced_IRI.parse _namespace_name "Planet/minimumTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/orbitalPeriod"></see>
    /// </summary>
    let ``Planet/orbitalPeriod`` =
        Namespaced_IRI.parse _namespace_name "Planet/orbitalPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/periapsis"></see>
    /// </summary>
    let ``Planet/periapsis`` =
        Namespaced_IRI.parse _namespace_name "Planet/periapsis" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/surfaceArea"></see>
    /// </summary>
    let ``Planet/surfaceArea`` =
        Namespaced_IRI.parse _namespace_name "Planet/surfaceArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/temperature"></see>
    /// </summary>
    let ``Planet/temperature`` =
        Namespaced_IRI.parse _namespace_name "Planet/temperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Planet/volume"></see>
    /// </summary>
    let ``Planet/volume`` =
        Namespaced_IRI.parse _namespace_name "Planet/volume" |> NamespacedName

    /// <summary>
    /// A play is a form of literature written by a playwright, usually consisting of scripted dialogue between characters, intended for theatrical performance rather than just reading.
    /// <see href="http://dbpedia.org/ontology/Play"></see></summary>
    let Play = Namespaced_IRI.parse _namespace_name "Play" |> NamespacedName
    /// <summary>
    /// A person who writes dramatic literature or drama.
    /// <see href="http://dbpedia.org/ontology/PlayWright"></see></summary>
    let PlayWright = Namespaced_IRI.parse _namespace_name "PlayWright" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PlayboyPlaymate"></see>
    /// </summary>
    let PlayboyPlaymate =
        Namespaced_IRI.parse _namespace_name "PlayboyPlaymate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Poem"></see>
    /// </summary>
    let Poem = Namespaced_IRI.parse _namespace_name "Poem" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Poet"></see>
    /// </summary>
    let Poet = Namespaced_IRI.parse _namespace_name "Poet" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PokerPlayer"></see>
    /// </summary>
    let PokerPlayer =
        Namespaced_IRI.parse _namespace_name "PokerPlayer" |> NamespacedName

    /// <summary>
    /// Political concepts, e.g. Capitalism, Democracy
    /// <see href="http://dbpedia.org/ontology/PoliticalConcept"></see></summary>
    let PoliticalConcept =
        Namespaced_IRI.parse _namespace_name "PoliticalConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PoliticalFunction"></see>
    /// </summary>
    let PoliticalFunction =
        Namespaced_IRI.parse _namespace_name "PoliticalFunction" |> NamespacedName

    /// <summary>
    /// for example: Democratic_Party_(United_States)
    /// <see href="http://dbpedia.org/ontology/PoliticalParty"></see></summary>
    let PoliticalParty =
        Namespaced_IRI.parse _namespace_name "PoliticalParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PoliticianSpouse"></see>
    /// </summary>
    let PoliticianSpouse =
        Namespaced_IRI.parse _namespace_name "PoliticianSpouse" |> NamespacedName

    /// <summary>
    /// A group of sports teams that compete against each other in Polo.
    /// <see href="http://dbpedia.org/ontology/PoloLeague"></see></summary>
    let PoloLeague = Namespaced_IRI.parse _namespace_name "PoloLeague" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Polyhedron"></see>
    /// </summary>
    let Polyhedron = Namespaced_IRI.parse _namespace_name "Polyhedron" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Polysaccharide"></see>
    /// </summary>
    let Polysaccharide =
        Namespaced_IRI.parse _namespace_name "Polysaccharide" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Pope"></see>
    /// </summary>
    let Pope = Namespaced_IRI.parse _namespace_name "Pope" |> NamespacedName

    /// <summary>
    /// The area of the thing in square meters.
    /// <see href="http://dbpedia.org/ontology/PopulatedPlace/area"></see></summary>
    let ``PopulatedPlace/area`` =
        Namespaced_IRI.parse _namespace_name "PopulatedPlace/area" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PopulatedPlace/areaMetro"></see>
    /// </summary>
    let ``PopulatedPlace/areaMetro`` =
        Namespaced_IRI.parse _namespace_name "PopulatedPlace/areaMetro" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PopulatedPlace/areaTotal"></see>
    /// </summary>
    let ``PopulatedPlace/areaTotal`` =
        Namespaced_IRI.parse _namespace_name "PopulatedPlace/areaTotal" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PopulatedPlace/areaUrban"></see>
    /// </summary>
    let ``PopulatedPlace/areaUrban`` =
        Namespaced_IRI.parse _namespace_name "PopulatedPlace/areaUrban" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PopulatedPlace/populationDensity"></see>
    /// </summary>
    let ``PopulatedPlace/populationDensity`` =
        Namespaced_IRI.parse _namespace_name "PopulatedPlace/populationDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PopulatedPlace/populationMetroDensity"></see>
    /// </summary>
    let ``PopulatedPlace/populationMetroDensity`` =
        Namespaced_IRI.parse _namespace_name "PopulatedPlace/populationMetroDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PopulatedPlace/populationUrbanDensity"></see>
    /// </summary>
    let ``PopulatedPlace/populationUrbanDensity`` =
        Namespaced_IRI.parse _namespace_name "PopulatedPlace/populationUrbanDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Population"></see>
    /// </summary>
    let Population = Namespaced_IRI.parse _namespace_name "Population" |> NamespacedName
    /// <summary>
    /// a location on a coast or shore containing one or more harbors where ships can dock and transfer people or cargo to or from land.
    /// <see href="http://dbpedia.org/ontology/Port"></see></summary>
    let Port = Namespaced_IRI.parse _namespace_name "Port" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Prefecture"></see>
    /// </summary>
    let Prefecture = Namespaced_IRI.parse _namespace_name "Prefecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PrehistoricalPeriod"></see>
    /// </summary>
    let PrehistoricalPeriod =
        Namespaced_IRI.parse _namespace_name "PrehistoricalPeriod" |> NamespacedName

    /// <summary>
    /// TV or radio show presenter
    /// <see href="http://dbpedia.org/ontology/Presenter"></see></summary>
    let Presenter = Namespaced_IRI.parse _namespace_name "Presenter" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/President"></see>
    /// </summary>
    let President = Namespaced_IRI.parse _namespace_name "President" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Priest"></see>
    /// </summary>
    let Priest = Namespaced_IRI.parse _namespace_name "Priest" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PrimeMinister"></see>
    /// </summary>
    let PrimeMinister =
        Namespaced_IRI.parse _namespace_name "PrimeMinister" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Prison"></see>
    /// </summary>
    let Prison = Namespaced_IRI.parse _namespace_name "Prison" |> NamespacedName
    /// <summary>
    /// a person who manages movies or music recordings.
    /// <see href="http://dbpedia.org/ontology/Producer"></see></summary>
    let Producer = Namespaced_IRI.parse _namespace_name "Producer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Profession"></see>
    /// </summary>
    let Profession = Namespaced_IRI.parse _namespace_name "Profession" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Professor"></see>
    /// </summary>
    let Professor = Namespaced_IRI.parse _namespace_name "Professor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ProgrammingLanguage"></see>
    /// </summary>
    let ProgrammingLanguage =
        Namespaced_IRI.parse _namespace_name "ProgrammingLanguage" |> NamespacedName

    /// <summary>
    /// A project is a temporary endeavor undertaken to achieve defined objectives.
    /// <see href="http://dbpedia.org/ontology/Project"></see></summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName

    /// <summary>
    /// This class should be used for protected nature. For enclosed neighbourhoods there is now class GatedCommunity
    /// <see href="http://dbpedia.org/ontology/ProtectedArea"></see></summary>
    let ProtectedArea =
        Namespaced_IRI.parse _namespace_name "ProtectedArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Protein"></see>
    /// </summary>
    let Protein = Namespaced_IRI.parse _namespace_name "Protein" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ProtohistoricalPeriod"></see>
    /// </summary>
    let ProtohistoricalPeriod =
        Namespaced_IRI.parse _namespace_name "ProtohistoricalPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Psychologist"></see>
    /// </summary>
    let Psychologist =
        Namespaced_IRI.parse _namespace_name "Psychologist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/PublicService"></see>
    /// </summary>
    let PublicService =
        Namespaced_IRI.parse _namespace_name "PublicService" |> NamespacedName

    /// <summary>
    /// A public transit system is a shared passenger transportation service which is available for use by the general public. Public transport modes include buses, trolleybuses, trams and trains, 'rapid transit' (metro/subways/undergrounds etc) and ferries. Intercity public transport is dominated by airlines, coaches, and intercity rail. (http://en.wikipedia.org/wiki/Public_transit).
    /// <see href="http://dbpedia.org/ontology/PublicTransitSystem"></see></summary>
    let PublicTransitSystem =
        Namespaced_IRI.parse _namespace_name "PublicTransitSystem" |> NamespacedName

    /// <summary>
    /// Publishing company
    /// <see href="http://dbpedia.org/ontology/Publisher"></see></summary>
    let Publisher = Namespaced_IRI.parse _namespace_name "Publisher" |> NamespacedName
    /// <summary>
    /// a structure whose shape is roughly that of a pyramid in the geometric sense.
    /// <see href="http://dbpedia.org/ontology/Pyramid"></see></summary>
    let Pyramid = Namespaced_IRI.parse _namespace_name "Pyramid" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Quote"></see>
    /// </summary>
    let Quote = Namespaced_IRI.parse _namespace_name "Quote" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RaceHorse"></see>
    /// </summary>
    let RaceHorse = Namespaced_IRI.parse _namespace_name "RaceHorse" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RaceTrack"></see>
    /// </summary>
    let RaceTrack = Namespaced_IRI.parse _namespace_name "RaceTrack" |> NamespacedName
    /// <summary>
    /// A racecourse is an alternate term for a horse racing track, found in countries such as the United Kingdom, Australia, Hong Kong, and the United Arab Emirates.
    /// <see href="http://dbpedia.org/ontology/Racecourse"></see></summary>
    let Racecourse = Namespaced_IRI.parse _namespace_name "Racecourse" |> NamespacedName

    /// <summary>
    /// A group of sports teams or person that compete against each other in radio-controlled racing.
    /// <see href="http://dbpedia.org/ontology/RadioControlledRacingLeague"></see></summary>
    let RadioControlledRacingLeague =
        Namespaced_IRI.parse _namespace_name "RadioControlledRacingLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RadioHost"></see>
    /// </summary>
    let RadioHost = Namespaced_IRI.parse _namespace_name "RadioHost" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RadioProgram"></see>
    /// </summary>
    let RadioProgram =
        Namespaced_IRI.parse _namespace_name "RadioProgram" |> NamespacedName

    /// <summary>
    /// A radio station has one line up. For instance the radio station BBC Radio 1. Not to be confused with the broadcasting network BBC, which has many radio stations.
    /// <see href="http://dbpedia.org/ontology/RadioStation"></see></summary>
    let RadioStation =
        Namespaced_IRI.parse _namespace_name "RadioStation" |> NamespacedName

    /// <summary>
    /// A railway line is a transport service by trains that pull passengers or freight provided by an organization. Not to be mistaken for railway track, which is the structure consisting of the rails. Wikipedia do not clearly differentiate between both, so there is one infobox describing tracks and lines.
    /// <see href="http://dbpedia.org/ontology/RailwayLine"></see></summary>
    let RailwayLine =
        Namespaced_IRI.parse _namespace_name "RailwayLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RailwayStation"></see>
    /// </summary>
    let RailwayStation =
        Namespaced_IRI.parse _namespace_name "RailwayStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RailwayTunnel"></see>
    /// </summary>
    let RailwayTunnel =
        Namespaced_IRI.parse _namespace_name "RailwayTunnel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RallyDriver"></see>
    /// </summary>
    let RallyDriver =
        Namespaced_IRI.parse _namespace_name "RallyDriver" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Rebellion"></see>
    /// </summary>
    let Rebellion = Namespaced_IRI.parse _namespace_name "Rebellion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RecordLabel"></see>
    /// </summary>
    let RecordLabel =
        Namespaced_IRI.parse _namespace_name "RecordLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RecordOffice"></see>
    /// </summary>
    let RecordOffice =
        Namespaced_IRI.parse _namespace_name "RecordOffice" |> NamespacedName

    /// <summary>
    /// An official who watches a game or match closely to ensure that the rules are adhered to.
    /// <see href="http://dbpedia.org/ontology/Referee"></see></summary>
    let Referee = Namespaced_IRI.parse _namespace_name "Referee" |> NamespacedName
    /// <summary>
    /// Reference to a work (book, movie, website)  providing info about the subject
    /// <see href="http://dbpedia.org/ontology/Reference"></see></summary>
    let Reference = Namespaced_IRI.parse _namespace_name "Reference" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Regency"></see>
    /// </summary>
    let Regency = Namespaced_IRI.parse _namespace_name "Regency" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Religious"></see>
    /// </summary>
    let Religious = Namespaced_IRI.parse _namespace_name "Religious" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Reptile"></see>
    /// </summary>
    let Reptile = Namespaced_IRI.parse _namespace_name "Reptile" |> NamespacedName

    /// <summary>
    /// A research project is a scientific investigation, usually using scientific methods, to achieve defined objectives.
    /// <see href="http://dbpedia.org/ontology/ResearchProject"></see></summary>
    let ResearchProject =
        Namespaced_IRI.parse _namespace_name "ResearchProject" |> NamespacedName

    /// <summary>
    /// A rest area is part of a Road, meant to stop and rest. More often than not, there is a filling station
    /// <see href="http://dbpedia.org/ontology/RestArea"></see></summary>
    let RestArea = Namespaced_IRI.parse _namespace_name "RestArea" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Restaurant"></see>
    /// </summary>
    let Restaurant = Namespaced_IRI.parse _namespace_name "Restaurant" |> NamespacedName
    /// <summary>
    /// A Resume describes a persons work experience and skill set.
    /// <see href="http://dbpedia.org/ontology/Resume"></see></summary>
    let Resume = Namespaced_IRI.parse _namespace_name "Resume" |> NamespacedName
    /// <summary>
    /// a large natural stream
    /// <see href="http://dbpedia.org/ontology/River"></see></summary>
    let River = Namespaced_IRI.parse _namespace_name "River" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Road"></see>
    /// </summary>
    let Road = Namespaced_IRI.parse _namespace_name "Road" |> NamespacedName

    /// <summary>
    /// A road junction is a location where vehicular traffic going in different directions can proceed in a controlled manner designed to minimize accidents. In some cases, vehicles can change between different routes or directions of travel (http://en.wikipedia.org/wiki/Junction_%28road%29).
    /// <see href="http://dbpedia.org/ontology/RoadJunction"></see></summary>
    let RoadJunction =
        Namespaced_IRI.parse _namespace_name "RoadJunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RoadTunnel"></see>
    /// </summary>
    let RoadTunnel = Namespaced_IRI.parse _namespace_name "RoadTunnel" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Rocket"></see>
    /// </summary>
    let Rocket = Namespaced_IRI.parse _namespace_name "Rocket" |> NamespacedName

    /// <summary>
    /// Payload mass in a typical Low Earth orbit
    /// <see href="http://dbpedia.org/ontology/Rocket/lowerEarthOrbitPayload"></see></summary>
    let ``Rocket/lowerEarthOrbitPayload`` =
        Namespaced_IRI.parse _namespace_name "Rocket/lowerEarthOrbitPayload" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Rocket/mass"></see>
    /// </summary>
    let ``Rocket/mass`` =
        Namespaced_IRI.parse _namespace_name "Rocket/mass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RocketEngine"></see>
    /// </summary>
    let RocketEngine =
        Namespaced_IRI.parse _namespace_name "RocketEngine" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RollerCoaster"></see>
    /// </summary>
    let RollerCoaster =
        Namespaced_IRI.parse _namespace_name "RollerCoaster" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RomanEmperor"></see>
    /// </summary>
    let RomanEmperor =
        Namespaced_IRI.parse _namespace_name "RomanEmperor" |> NamespacedName

    /// <summary>
    /// one stage or stop on a road.
    /// <see href="http://dbpedia.org/ontology/RouteStop"></see></summary>
    let RouteStop = Namespaced_IRI.parse _namespace_name "RouteStop" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Rower"></see>
    /// </summary>
    let Rower = Namespaced_IRI.parse _namespace_name "Rower" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RugbyClub"></see>
    /// </summary>
    let RugbyClub = Namespaced_IRI.parse _namespace_name "RugbyClub" |> NamespacedName

    /// <summary>
    /// A group of sports teams that compete against each other in rugby.
    /// <see href="http://dbpedia.org/ontology/RugbyLeague"></see></summary>
    let RugbyLeague =
        Namespaced_IRI.parse _namespace_name "RugbyLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RugbyPlayer"></see>
    /// </summary>
    let RugbyPlayer =
        Namespaced_IRI.parse _namespace_name "RugbyPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Saint"></see>
    /// </summary>
    let Saint = Namespaced_IRI.parse _namespace_name "Saint" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Sales"></see>
    /// </summary>
    let Sales = Namespaced_IRI.parse _namespace_name "Sales" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SambaSchool"></see>
    /// </summary>
    let SambaSchool =
        Namespaced_IRI.parse _namespace_name "SambaSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/School"></see>
    /// </summary>
    let School = Namespaced_IRI.parse _namespace_name "School" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/School/campusSize"></see>
    /// </summary>
    let ``School/campusSize`` =
        Namespaced_IRI.parse _namespace_name "School/campusSize" |> NamespacedName

    /// <summary>
    /// Scientific concepts, e.g. Theory of relativity, Quantum gravity
    /// <see href="http://dbpedia.org/ontology/ScientificConcept"></see></summary>
    let ScientificConcept =
        Namespaced_IRI.parse _namespace_name "ScientificConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ScreenWriter"></see>
    /// </summary>
    let ScreenWriter =
        Namespaced_IRI.parse _namespace_name "ScreenWriter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Sculptor"></see>
    /// </summary>
    let Sculptor = Namespaced_IRI.parse _namespace_name "Sculptor" |> NamespacedName
    /// <summary>
    /// Sculpture is three-dimensional artwork created by shaping or combining hard materials, typically stone such as marble, metal, glass, or wood, or plastic materials such as clay, textiles, polymers and softer metals.
    /// <see href="http://dbpedia.org/ontology/Sculpture"></see></summary>
    let Sculpture = Namespaced_IRI.parse _namespace_name "Sculpture" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Sea"></see>
    /// </summary>
    let Sea = Namespaced_IRI.parse _namespace_name "Sea" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Senator"></see>
    /// </summary>
    let Senator = Namespaced_IRI.parse _namespace_name "Senator" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SerialKiller"></see>
    /// </summary>
    let SerialKiller =
        Namespaced_IRI.parse _namespace_name "SerialKiller" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Ship"></see>
    /// </summary>
    let Ship = Namespaced_IRI.parse _namespace_name "Ship" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ShoppingMall"></see>
    /// </summary>
    let ShoppingMall =
        Namespaced_IRI.parse _namespace_name "ShoppingMall" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Shrine"></see>
    /// </summary>
    let Shrine = Namespaced_IRI.parse _namespace_name "Shrine" |> NamespacedName
    /// <summary>
    /// a person who sings.
    /// <see href="http://dbpedia.org/ontology/Singer"></see></summary>
    let Singer = Namespaced_IRI.parse _namespace_name "Singer" |> NamespacedName
    /// <summary>
    /// In music, a single or record single is a type of release, typically a recording of fewer tracks than an LP or a CD.
    /// <see href="http://dbpedia.org/ontology/Single"></see></summary>
    let Single = Namespaced_IRI.parse _namespace_name "Single" |> NamespacedName

    /// <summary>
    /// A Site of Special Scientific Interest (SSSI) is a conservation designation denoting a protected area in the United Kingdom. SSSIs are the basic building block of site-based nature conservation legislation and most other legal nature/geological conservation designations in Great Britain are based upon them, including National Nature Reserves, Ramsar Sites, Special Protection Areas, and Special Areas of Conservation.
    /// <see href="http://dbpedia.org/ontology/SiteOfSpecialScientificInterest"></see></summary>
    let SiteOfSpecialScientificInterest =
        Namespaced_IRI.parse _namespace_name "SiteOfSpecialScientificInterest" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Skater"></see>
    /// </summary>
    let Skater = Namespaced_IRI.parse _namespace_name "Skater" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SkiArea"></see>
    /// </summary>
    let SkiArea = Namespaced_IRI.parse _namespace_name "SkiArea" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SkiResort"></see>
    /// </summary>
    let SkiResort = Namespaced_IRI.parse _namespace_name "SkiResort" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Ski_jumper"></see>
    /// </summary>
    let Ski_jumper = Namespaced_IRI.parse _namespace_name "Ski_jumper" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Skier"></see>
    /// </summary>
    let Skier = Namespaced_IRI.parse _namespace_name "Skier" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Skyscraper"></see>
    /// </summary>
    let Skyscraper = Namespaced_IRI.parse _namespace_name "Skyscraper" |> NamespacedName

    /// <summary>
    /// An athlete that plays snooker and won the world championship at least once
    /// <see href="http://dbpedia.org/ontology/SnookerChamp"></see></summary>
    let SnookerChamp =
        Namespaced_IRI.parse _namespace_name "SnookerChamp" |> NamespacedName

    /// <summary>
    /// An athlete that plays snooker, which is a billard derivate
    /// <see href="http://dbpedia.org/ontology/SnookerPlayer"></see></summary>
    let SnookerPlayer =
        Namespaced_IRI.parse _namespace_name "SnookerPlayer" |> NamespacedName

    /// <summary>
    /// The official world ranking in snooker for a certain year/season
    /// <see href="http://dbpedia.org/ontology/SnookerWorldRanking"></see></summary>
    let SnookerWorldRanking =
        Namespaced_IRI.parse _namespace_name "SnookerWorldRanking" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoapCharacter"></see>
    /// </summary>
    let SoapCharacter =
        Namespaced_IRI.parse _namespace_name "SoapCharacter" |> NamespacedName

    /// <summary>
    /// A sports game in which the ball must be played by foot
    /// <see href="http://dbpedia.org/ontology/Soccer"></see></summary>
    let Soccer = Namespaced_IRI.parse _namespace_name "Soccer" |> NamespacedName
    /// <summary>
    /// A team sport is commonly defined as a sport that is being played by competing teams
    /// <see href="http://dbpedia.org/ontology/TeamSport"></see></summary>
    let TeamSport = Namespaced_IRI.parse _namespace_name "TeamSport" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoccerClubSeason"></see>
    /// </summary>
    let SoccerClubSeason =
        Namespaced_IRI.parse _namespace_name "SoccerClubSeason" |> NamespacedName

    /// <summary>
    /// A group of sports teams that compete against each other in soccer.
    /// <see href="http://dbpedia.org/ontology/SoccerLeague"></see></summary>
    let SoccerLeague =
        Namespaced_IRI.parse _namespace_name "SoccerLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoccerLeagueSeason"></see>
    /// </summary>
    let SoccerLeagueSeason =
        Namespaced_IRI.parse _namespace_name "SoccerLeagueSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoccerManager"></see>
    /// </summary>
    let SoccerManager =
        Namespaced_IRI.parse _namespace_name "SoccerManager" |> NamespacedName

    /// <summary>
    /// According to the french label sub Soccer, trainership could be meant. However, here a Sportsmanager is interpreted as a member of the board of a sporting club.
    /// <see href="http://dbpedia.org/ontology/SportsManager"></see></summary>
    let SportsManager =
        Namespaced_IRI.parse _namespace_name "SportsManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoccerPlayer"></see>
    /// </summary>
    let SoccerPlayer =
        Namespaced_IRI.parse _namespace_name "SoccerPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SoccerTournament"></see>
    /// </summary>
    let SoccerTournament =
        Namespaced_IRI.parse _namespace_name "SoccerTournament" |> NamespacedName

    /// <summary>
    /// A group of sports teams that compete against each other in softball.
    /// <see href="http://dbpedia.org/ontology/SoftballLeague"></see></summary>
    let SoftballLeague =
        Namespaced_IRI.parse _namespace_name "SoftballLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Software"></see>
    /// </summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName

    /// <summary>
    /// size of a file or software
    /// <see href="http://dbpedia.org/ontology/Software/fileSize"></see></summary>
    let ``Software/fileSize`` =
        Namespaced_IRI.parse _namespace_name "Software/fileSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SolarEclipse"></see>
    /// </summary>
    let SolarEclipse =
        Namespaced_IRI.parse _namespace_name "SolarEclipse" |> NamespacedName

    /// <summary>
    /// a person who writes songs.
    /// <see href="http://dbpedia.org/ontology/SongWriter"></see></summary>
    let SongWriter = Namespaced_IRI.parse _namespace_name "SongWriter" |> NamespacedName
    /// <summary>
    /// An audio document intended to be listened to; equivalent to http://purl.org/dc/dcmitype/Sound
    /// <see href="http://dbpedia.org/ontology/Sound"></see></summary>
    let Sound = Namespaced_IRI.parse _namespace_name "Sound" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission"></see>
    /// </summary>
    let SpaceMission =
        Namespaced_IRI.parse _namespace_name "SpaceMission" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/cmpEvaDuration"></see>
    /// </summary>
    let ``SpaceMission/cmpEvaDuration`` =
        Namespaced_IRI.parse _namespace_name "SpaceMission/cmpEvaDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/distanceTraveled"></see>
    /// </summary>
    let ``SpaceMission/distanceTraveled`` =
        Namespaced_IRI.parse _namespace_name "SpaceMission/distanceTraveled" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/lunarEvaTime"></see>
    /// </summary>
    let ``SpaceMission/lunarEvaTime`` =
        Namespaced_IRI.parse _namespace_name "SpaceMission/lunarEvaTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/lunarOrbitTime"></see>
    /// </summary>
    let ``SpaceMission/lunarOrbitTime`` =
        Namespaced_IRI.parse _namespace_name "SpaceMission/lunarOrbitTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/lunarSampleMass"></see>
    /// </summary>
    let ``SpaceMission/lunarSampleMass`` =
        Namespaced_IRI.parse _namespace_name "SpaceMission/lunarSampleMass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/lunarSurfaceTime"></see>
    /// </summary>
    let ``SpaceMission/lunarSurfaceTime`` =
        Namespaced_IRI.parse _namespace_name "SpaceMission/lunarSurfaceTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/mass"></see>
    /// </summary>
    let ``SpaceMission/mass`` =
        Namespaced_IRI.parse _namespace_name "SpaceMission/mass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/missionDuration"></see>
    /// </summary>
    let ``SpaceMission/missionDuration`` =
        Namespaced_IRI.parse _namespace_name "SpaceMission/missionDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/stationEvaDuration"></see>
    /// </summary>
    let ``SpaceMission/stationEvaDuration`` =
        Namespaced_IRI.parse _namespace_name "SpaceMission/stationEvaDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceMission/stationVisitDuration"></see>
    /// </summary>
    let ``SpaceMission/stationVisitDuration`` =
        Namespaced_IRI.parse _namespace_name "SpaceMission/stationVisitDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceShuttle"></see>
    /// </summary>
    let SpaceShuttle =
        Namespaced_IRI.parse _namespace_name "SpaceShuttle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceShuttle/distance"></see>
    /// </summary>
    let ``SpaceShuttle/distance`` =
        Namespaced_IRI.parse _namespace_name "SpaceShuttle/distance" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceShuttle/timeInSpace"></see>
    /// </summary>
    let ``SpaceShuttle/timeInSpace`` =
        Namespaced_IRI.parse _namespace_name "SpaceShuttle/timeInSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceStation"></see>
    /// </summary>
    let SpaceStation =
        Namespaced_IRI.parse _namespace_name "SpaceStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpaceStation/volume"></see>
    /// </summary>
    let ``SpaceStation/volume`` =
        Namespaced_IRI.parse _namespace_name "SpaceStation/volume" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft"></see>
    /// </summary>
    let Spacecraft = Namespaced_IRI.parse _namespace_name "Spacecraft" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/apoapsis"></see>
    /// </summary>
    let ``Spacecraft/apoapsis`` =
        Namespaced_IRI.parse _namespace_name "Spacecraft/apoapsis" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/cargoFuel"></see>
    /// </summary>
    let ``Spacecraft/cargoFuel`` =
        Namespaced_IRI.parse _namespace_name "Spacecraft/cargoFuel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/cargoGas"></see>
    /// </summary>
    let ``Spacecraft/cargoGas`` =
        Namespaced_IRI.parse _namespace_name "Spacecraft/cargoGas" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/cargoWater"></see>
    /// </summary>
    let ``Spacecraft/cargoWater`` =
        Namespaced_IRI.parse _namespace_name "Spacecraft/cargoWater" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/dockedTime"></see>
    /// </summary>
    let ``Spacecraft/dockedTime`` =
        Namespaced_IRI.parse _namespace_name "Spacecraft/dockedTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/dryCargo"></see>
    /// </summary>
    let ``Spacecraft/dryCargo`` =
        Namespaced_IRI.parse _namespace_name "Spacecraft/dryCargo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/freeFlightTime"></see>
    /// </summary>
    let ``Spacecraft/freeFlightTime`` =
        Namespaced_IRI.parse _namespace_name "Spacecraft/freeFlightTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/periapsis"></see>
    /// </summary>
    let ``Spacecraft/periapsis`` =
        Namespaced_IRI.parse _namespace_name "Spacecraft/periapsis" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/totalCargo"></see>
    /// </summary>
    let ``Spacecraft/totalCargo`` =
        Namespaced_IRI.parse _namespace_name "Spacecraft/totalCargo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Spacecraft/totalMass"></see>
    /// </summary>
    let ``Spacecraft/totalMass`` =
        Namespaced_IRI.parse _namespace_name "Spacecraft/totalMass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpeedSkater"></see>
    /// </summary>
    let SpeedSkater =
        Namespaced_IRI.parse _namespace_name "SpeedSkater" |> NamespacedName

    /// <summary>
    /// A group of sports teams that compete against each other in motorcycle speedway racing.
    /// <see href="http://dbpedia.org/ontology/SpeedwayLeague"></see></summary>
    let SpeedwayLeague =
        Namespaced_IRI.parse _namespace_name "SpeedwayLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpeedwayRider"></see>
    /// </summary>
    let SpeedwayRider =
        Namespaced_IRI.parse _namespace_name "SpeedwayRider" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SpeedwayTeam"></see>
    /// </summary>
    let SpeedwayTeam =
        Namespaced_IRI.parse _namespace_name "SpeedwayTeam" |> NamespacedName

    /// <summary>
    /// A member of an athletic team.
    /// <see href="http://dbpedia.org/ontology/SportsTeamMember"></see></summary>
    let SportsTeamMember =
        Namespaced_IRI.parse _namespace_name "SportsTeamMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Square"></see>
    /// </summary>
    let Square = Namespaced_IRI.parse _namespace_name "Square" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SquashPlayer"></see>
    /// </summary>
    let SquashPlayer =
        Namespaced_IRI.parse _namespace_name "SquashPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Stadium"></see>
    /// </summary>
    let Stadium = Namespaced_IRI.parse _namespace_name "Stadium" |> NamespacedName
    /// <summary>
    /// a common specification
    /// <see href="http://dbpedia.org/ontology/Standard"></see></summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/State"></see>
    /// </summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName

    /// <summary>
    /// A Resolution describes a formal statement adopted by a meeting or convention.
    /// <see href="http://dbpedia.org/ontology/StatedResolution"></see></summary>
    let StatedResolution =
        Namespaced_IRI.parse _namespace_name "StatedResolution" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Statistic"></see>
    /// </summary>
    let Statistic = Namespaced_IRI.parse _namespace_name "Statistic" |> NamespacedName
    /// <summary>
    /// A visual document that is not intended to be animated; equivalent to http://purl.org/dc/dcmitype/StillImage
    /// <see href="http://dbpedia.org/ontology/StillImage"></see></summary>
    let StillImage = Namespaced_IRI.parse _namespace_name "StillImage" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/StormSurge"></see>
    /// </summary>
    let StormSurge = Namespaced_IRI.parse _namespace_name "StormSurge" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Stream/discharge"></see>
    /// </summary>
    let ``Stream/discharge`` =
        Namespaced_IRI.parse _namespace_name "Stream/discharge" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Stream/dischargeAverage"></see>
    /// </summary>
    let ``Stream/dischargeAverage`` =
        Namespaced_IRI.parse _namespace_name "Stream/dischargeAverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Stream/maximumDischarge"></see>
    /// </summary>
    let ``Stream/maximumDischarge`` =
        Namespaced_IRI.parse _namespace_name "Stream/maximumDischarge" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Stream/minimumDischarge"></see>
    /// </summary>
    let ``Stream/minimumDischarge`` =
        Namespaced_IRI.parse _namespace_name "Stream/minimumDischarge" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Stream/watershed"></see>
    /// </summary>
    let ``Stream/watershed`` =
        Namespaced_IRI.parse _namespace_name "Stream/watershed" |> NamespacedName

    /// <summary>
    /// A Street is different from a Road in as far as the infrastructure aspect is much less important here. A Street is a social and architectural ensemble much more than the connection between two geographic points.
    /// <see href="http://dbpedia.org/ontology/Street"></see></summary>
    let Street = Namespaced_IRI.parse _namespace_name "Street" |> NamespacedName

    /// <summary>
    /// An administrative body governing a territorial unity on the lowest level, administering part of a municipality
    /// <see href="http://dbpedia.org/ontology/SubMunicipality"></see></summary>
    let SubMunicipality =
        Namespaced_IRI.parse _namespace_name "SubMunicipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SumoWrestler"></see>
    /// </summary>
    let SumoWrestler =
        Namespaced_IRI.parse _namespace_name "SumoWrestler" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Wrestler"></see>
    /// </summary>
    let Wrestler = Namespaced_IRI.parse _namespace_name "Wrestler" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SupremeCourtOfTheUnitedStatesCase"></see>
    /// </summary>
    let SupremeCourtOfTheUnitedStatesCase =
        Namespaced_IRI.parse _namespace_name "SupremeCourtOfTheUnitedStatesCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Surfer"></see>
    /// </summary>
    let Surfer = Namespaced_IRI.parse _namespace_name "Surfer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Surname"></see>
    /// </summary>
    let Surname = Namespaced_IRI.parse _namespace_name "Surname" |> NamespacedName
    /// <summary>
    /// a trained athlete who participates in swimming meets
    /// <see href="http://dbpedia.org/ontology/Swimmer"></see></summary>
    let Swimmer = Namespaced_IRI.parse _namespace_name "Swimmer" |> NamespacedName
    /// <summary>
    /// A synagogue, sometimes spelt synagog, is a Jewish or Samaritan house of prayer.
    /// <see href="http://dbpedia.org/ontology/Synagogue"></see></summary>
    let Synagogue = Namespaced_IRI.parse _namespace_name "Synagogue" |> NamespacedName

    /// <summary>
    /// a system of legislation, either national or international
    /// <see href="http://dbpedia.org/ontology/SystemOfLaw"></see></summary>
    let SystemOfLaw =
        Namespaced_IRI.parse _namespace_name "SystemOfLaw" |> NamespacedName

    /// <summary>
    /// Athlete who plays table tennis
    /// <see href="http://dbpedia.org/ontology/TableTennisPlayer"></see></summary>
    let TableTennisPlayer =
        Namespaced_IRI.parse _namespace_name "TableTennisPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Tax"></see>
    /// </summary>
    let Tax = Namespaced_IRI.parse _namespace_name "Tax" |> NamespacedName
    /// <summary>
    /// a category within a classification system for Species
    /// <see href="http://dbpedia.org/ontology/Taxon"></see></summary>
    let Taxon = Namespaced_IRI.parse _namespace_name "Taxon" |> NamespacedName
    /// <summary>
    /// A member of an athletic team.
    /// <see href="http://dbpedia.org/ontology/TeamMember"></see></summary>
    let TeamMember = Namespaced_IRI.parse _namespace_name "TeamMember" |> NamespacedName

    /// <summary>
    /// a person who directs the activities involved in making a television program.
    /// <see href="http://dbpedia.org/ontology/TelevisionDirector"></see></summary>
    let TelevisionDirector =
        Namespaced_IRI.parse _namespace_name "TelevisionDirector" |> NamespacedName

    /// <summary>
    /// A television episode is a part of serial television program.
    /// <see href="http://dbpedia.org/ontology/TelevisionEpisode"></see></summary>
    let TelevisionEpisode =
        Namespaced_IRI.parse _namespace_name "TelevisionEpisode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TelevisionHost"></see>
    /// </summary>
    let TelevisionHost =
        Namespaced_IRI.parse _namespace_name "TelevisionHost" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TelevisionSeason"></see>
    /// </summary>
    let TelevisionSeason =
        Namespaced_IRI.parse _namespace_name "TelevisionSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TelevisionShow"></see>
    /// </summary>
    let TelevisionShow =
        Namespaced_IRI.parse _namespace_name "TelevisionShow" |> NamespacedName

    /// <summary>
    /// A television station has usually one line up. For instance the television station WABC-TV (or ABC 7, Channel 7). Not to be confused with the broadcasting network ABC, which has many television stations.
    /// <see href="http://dbpedia.org/ontology/TelevisionStation"></see></summary>
    let TelevisionStation =
        Namespaced_IRI.parse _namespace_name "TelevisionStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Temple"></see>
    /// </summary>
    let Temple = Namespaced_IRI.parse _namespace_name "Temple" |> NamespacedName

    /// <summary>
    /// A group of sports teams or person that compete against each other in tennis.
    /// <see href="http://dbpedia.org/ontology/TennisLeague"></see></summary>
    let TennisLeague =
        Namespaced_IRI.parse _namespace_name "TennisLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TennisPlayer"></see>
    /// </summary>
    let TennisPlayer =
        Namespaced_IRI.parse _namespace_name "TennisPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TennisTournament"></see>
    /// </summary>
    let TennisTournament =
        Namespaced_IRI.parse _namespace_name "TennisTournament" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TermOfOffice"></see>
    /// </summary>
    let TermOfOffice =
        Namespaced_IRI.parse _namespace_name "TermOfOffice" |> NamespacedName

    /// <summary>
    /// A theater or theatre (also a playhouse) is a structure where theatrical works or plays are performed or other performances such as musical concerts may be produced.
    /// <see href="http://dbpedia.org/ontology/Theatre"></see></summary>
    let Theatre = Namespaced_IRI.parse _namespace_name "Theatre" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Venue"></see>
    /// </summary>
    let Venue = Namespaced_IRI.parse _namespace_name "Venue" |> NamespacedName

    /// <summary>
    /// A director in the theatre field who oversees and orchestrates the mounting of a theatre production.
    /// <see href="http://dbpedia.org/ontology/TheatreDirector"></see></summary>
    let TheatreDirector =
        Namespaced_IRI.parse _namespace_name "TheatreDirector" |> NamespacedName

    /// <summary>
    /// a settlement ranging from a few hundred to several thousand (occasionally hundreds of thousands). The precise meaning varies between countries and is not always a matter of legal definition. Usually, a town is thought of as larger than a village but smaller than a city, though there are exceptions to this rule.
    /// <see href="http://dbpedia.org/ontology/Town"></see></summary>
    let Town = Namespaced_IRI.parse _namespace_name "Town" |> NamespacedName
    /// <summary>
    /// A list of music tracks, like on a CD
    /// <see href="http://dbpedia.org/ontology/TrackList"></see></summary>
    let TrackList = Namespaced_IRI.parse _namespace_name "TrackList" |> NamespacedName
    /// <summary>
    /// A trade union or labor union is an organization of workers who have banded together to achieve common goals such as better working conditions.
    /// <see href="http://dbpedia.org/ontology/TradeUnion"></see></summary>
    let TradeUnion = Namespaced_IRI.parse _namespace_name "TradeUnion" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Train"></see>
    /// </summary>
    let Train = Namespaced_IRI.parse _namespace_name "Train" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TrainCarriage"></see>
    /// </summary>
    let TrainCarriage =
        Namespaced_IRI.parse _namespace_name "TrainCarriage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Tram"></see>
    /// </summary>
    let Tram = Namespaced_IRI.parse _namespace_name "Tram" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/TramStation"></see>
    /// </summary>
    let TramStation =
        Namespaced_IRI.parse _namespace_name "TramStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/%3Chttp://vocab.org/transit/terms/stop%3E"></see>
    /// </summary>
    let ``_%3Chttp://vocab.org/transit/terms/stop%3E`` =
        Namespaced_IRI.parse _namespace_name "%3Chttp://vocab.org/transit/terms/stop%3E" |> NamespacedName

    /// <summary>
    /// A mill driven by the tractive power of horses, donkeys or even people
    /// <see href="http://dbpedia.org/ontology/Treadmill"></see></summary>
    let Treadmill = Namespaced_IRI.parse _namespace_name "Treadmill" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Treaty"></see>
    /// </summary>
    let Treaty = Namespaced_IRI.parse _namespace_name "Treaty" |> NamespacedName
    /// <summary>
    /// A tunnel may be for foot or vehicular road traffic, for rail traffic, or for a canal. Some tunnels are aqueducts to supply water for consumption or for hydroelectric stations or are sewers (http://en.wikipedia.org/wiki/Tunnel).
    /// <see href="http://dbpedia.org/ontology/Tunnel"></see></summary>
    let Tunnel = Namespaced_IRI.parse _namespace_name "Tunnel" |> NamespacedName

    /// <summary>
    /// An underground journal is, although over time there have always been publications forbidden by law, a phenomenon typical of countries occupied by the Germans during the Second World War. The writing in the underground press aims at stiffening a spirit of resistance against Nazi occupation. The distribution of underground journals had to be very secretive and was, therefore, very much dependant on illegal distribution circuits and the hazards of persecution by the occupant.
    /// <see href="http://dbpedia.org/ontology/UndergroundJournal"></see></summary>
    let UndergroundJournal =
        Namespaced_IRI.parse _namespace_name "UndergroundJournal" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/University"></see>
    /// </summary>
    let University = Namespaced_IRI.parse _namespace_name "University" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Unknown"></see>
    /// </summary>
    let Unknown = Namespaced_IRI.parse _namespace_name "Unknown" |> NamespacedName
    /// <summary>
    /// a depression with predominant extent in one direction
    /// <see href="http://dbpedia.org/ontology/Valley"></see></summary>
    let Valley = Namespaced_IRI.parse _namespace_name "Valley" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Vein"></see>
    /// </summary>
    let Vein = Namespaced_IRI.parse _namespace_name "Vein" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Vicar"></see>
    /// </summary>
    let Vicar = Namespaced_IRI.parse _namespace_name "Vicar" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/VicePresident"></see>
    /// </summary>
    let VicePresident =
        Namespaced_IRI.parse _namespace_name "VicePresident" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/VicePrimeMinister"></see>
    /// </summary>
    let VicePrimeMinister =
        Namespaced_IRI.parse _namespace_name "VicePrimeMinister" |> NamespacedName

    /// <summary>
    /// A video game is an electronic game that involves interaction with a user interface to generate visual feedback on a video device.
    /// <see href="http://dbpedia.org/ontology/VideoGame"></see></summary>
    let VideoGame = Namespaced_IRI.parse _namespace_name "VideoGame" |> NamespacedName

    /// <summary>
    /// A group of sports teams or person that compete against each other in videogames.
    /// <see href="http://dbpedia.org/ontology/VideogamesLeague"></see></summary>
    let VideogamesLeague =
        Namespaced_IRI.parse _namespace_name "VideogamesLeague" |> NamespacedName

    /// <summary>
    /// a clustered human settlement or community, usually smaller a town
    /// <see href="http://dbpedia.org/ontology/Village"></see></summary>
    let Village = Namespaced_IRI.parse _namespace_name "Village" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Vodka"></see>
    /// </summary>
    let Vodka = Namespaced_IRI.parse _namespace_name "Vodka" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/VoiceActor"></see>
    /// </summary>
    let VoiceActor = Namespaced_IRI.parse _namespace_name "VoiceActor" |> NamespacedName
    /// <summary>
    /// A volcano is currently subclass of naturalplace, but it might also be considered a mountain.
    /// <see href="http://dbpedia.org/ontology/Volcano"></see></summary>
    let Volcano = Namespaced_IRI.parse _namespace_name "Volcano" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/VolleyballCoach"></see>
    /// </summary>
    let VolleyballCoach =
        Namespaced_IRI.parse _namespace_name "VolleyballCoach" |> NamespacedName

    /// <summary>
    /// A group of sports teams that compete against each other in volleyball.
    /// <see href="http://dbpedia.org/ontology/VolleyballLeague"></see></summary>
    let VolleyballLeague =
        Namespaced_IRI.parse _namespace_name "VolleyballLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WaterPoloPlayer"></see>
    /// </summary>
    let WaterPoloPlayer =
        Namespaced_IRI.parse _namespace_name "WaterPoloPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WaterRide"></see>
    /// </summary>
    let WaterRide = Namespaced_IRI.parse _namespace_name "WaterRide" |> NamespacedName
    /// <summary>
    /// a construction designed to store larger quantities of water at a place of some elevation in order to keep pressure on the water provision system
    /// <see href="http://dbpedia.org/ontology/WaterTower"></see></summary>
    let WaterTower = Namespaced_IRI.parse _namespace_name "WaterTower" |> NamespacedName
    /// <summary>
    /// A watermill is a structure that uses a water wheel or turbine to drive a mechanical process such as flour, lumber or textile production, or metal shaping (rolling, grinding or wire drawing)
    /// <see href="http://dbpedia.org/ontology/Watermill"></see></summary>
    let Watermill = Namespaced_IRI.parse _namespace_name "Watermill" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WaterwayTunnel"></see>
    /// </summary>
    let WaterwayTunnel =
        Namespaced_IRI.parse _namespace_name "WaterwayTunnel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Weapon"></see>
    /// </summary>
    let Weapon = Namespaced_IRI.parse _namespace_name "Weapon" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Weapon/diameter"></see>
    /// </summary>
    let ``Weapon/diameter`` =
        Namespaced_IRI.parse _namespace_name "Weapon/diameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Weapon/height"></see>
    /// </summary>
    let ``Weapon/height`` =
        Namespaced_IRI.parse _namespace_name "Weapon/height" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Weapon/length"></see>
    /// </summary>
    let ``Weapon/length`` =
        Namespaced_IRI.parse _namespace_name "Weapon/length" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Weapon/weight"></see>
    /// </summary>
    let ``Weapon/weight`` =
        Namespaced_IRI.parse _namespace_name "Weapon/weight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Weapon/width"></see>
    /// </summary>
    let ``Weapon/width`` =
        Namespaced_IRI.parse _namespace_name "Weapon/width" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Website"></see>
    /// </summary>
    let Website = Namespaced_IRI.parse _namespace_name "Website" |> NamespacedName
    /// <summary>
    /// A wind-driven turbine that adapts itself to wind direction and to wind-force. Is considered to be a class in its own, despite the wind as common factor with Windmill.
    /// <see href="http://dbpedia.org/ontology/WindMotor"></see></summary>
    let WindMotor = Namespaced_IRI.parse _namespace_name "WindMotor" |> NamespacedName
    /// <summary>
    /// A windmill is a machine that converts the energy of wind into rotational energy by means of vanes called sails
    /// <see href="http://dbpedia.org/ontology/Windmill"></see></summary>
    let Windmill = Namespaced_IRI.parse _namespace_name "Windmill" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WineRegion"></see>
    /// </summary>
    let WineRegion = Namespaced_IRI.parse _namespace_name "WineRegion" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Winery"></see>
    /// </summary>
    let Winery = Namespaced_IRI.parse _namespace_name "Winery" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WomensTennisAssociationTournament"></see>
    /// </summary>
    let WomensTennisAssociationTournament =
        Namespaced_IRI.parse _namespace_name "WomensTennisAssociationTournament" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Work/runtime"></see>
    /// </summary>
    let ``Work/runtime`` =
        Namespaced_IRI.parse _namespace_name "Work/runtime" |> NamespacedName

    /// <summary>
    /// A UNESCO World Heritage Site is a site (such as a forest, mountain, lake, desert, monument, building, complex, or city) that is on the list that is maintained by the international World Heritage Programme administered by the UNESCO World Heritage Committee, composed of 21 state parties which are elected by their General Assembly for a four-year term. A World Heritage Site is a place of either cultural or physical significance.
    /// <see href="http://dbpedia.org/ontology/WorldHeritageSite"></see></summary>
    let WorldHeritageSite =
        Namespaced_IRI.parse _namespace_name "WorldHeritageSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/WrestlingEvent"></see>
    /// </summary>
    let WrestlingEvent =
        Namespaced_IRI.parse _namespace_name "WrestlingEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Year"></see>
    /// </summary>
    let Year = Namespaced_IRI.parse _namespace_name "Year" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/YearInSpaceflight"></see>
    /// </summary>
    let YearInSpaceflight =
        Namespaced_IRI.parse _namespace_name "YearInSpaceflight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Zoo"></see>
    /// </summary>
    let Zoo = Namespaced_IRI.parse _namespace_name "Zoo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aSide"></see>
    /// </summary>
    let aSide = Namespaced_IRI.parse _namespace_name "aSide" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/abbeychurchBlessing"></see>
    /// </summary>
    let abbeychurchBlessing =
        Namespaced_IRI.parse _namespace_name "abbeychurchBlessing" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/abbeychurchBlessingCharge"></see>
    /// </summary>
    let abbeychurchBlessingCharge =
        Namespaced_IRI.parse _namespace_name "abbeychurchBlessingCharge" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/abbreviation"></see>
    /// </summary>
    let abbreviation =
        Namespaced_IRI.parse _namespace_name "abbreviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ableToGrind"></see>
    /// </summary>
    let ableToGrind =
        Namespaced_IRI.parse _namespace_name "ableToGrind" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/absoluteMagnitude"></see>
    /// </summary>
    let absoluteMagnitude =
        Namespaced_IRI.parse _namespace_name "absoluteMagnitude" |> NamespacedName

    /// <summary>
    /// Number of abstentions from the vote
    /// <see href="http://dbpedia.org/ontology/abstentions"></see></summary>
    let abstentions =
        Namespaced_IRI.parse _namespace_name "abstentions" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/abstract"></see></summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/academicAdvisor"></see>
    /// </summary>
    let academicAdvisor =
        Namespaced_IRI.parse _namespace_name "academicAdvisor" |> NamespacedName

    /// <summary>
    /// An academic discipline, or field of study, is a branch of knowledge that is taught and researched at the college or university level. Disciplines are defined (in part), and recognized by the academic journals in which research is published, and the learned societies and academic departments or faculties to which their practitioners belong.
    /// <see href="http://dbpedia.org/ontology/academicDiscipline"></see></summary>
    let academicDiscipline =
        Namespaced_IRI.parse _namespace_name "academicDiscipline" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/academyAward"></see>
    /// </summary>
    let academyAward =
        Namespaced_IRI.parse _namespace_name "academyAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/acceleration"></see>
    /// </summary>
    let acceleration =
        Namespaced_IRI.parse _namespace_name "acceleration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/access"></see>
    /// </summary>
    let access = Namespaced_IRI.parse _namespace_name "access" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/accessDate"></see>
    /// </summary>
    let accessDate = Namespaced_IRI.parse _namespace_name "accessDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/achievement"></see>
    /// </summary>
    let achievement =
        Namespaced_IRI.parse _namespace_name "achievement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/acquirementDate"></see>
    /// </summary>
    let acquirementDate =
        Namespaced_IRI.parse _namespace_name "acquirementDate" |> NamespacedName

    /// <summary>
    /// most recent average ACT scores
    /// <see href="http://dbpedia.org/ontology/actScore"></see></summary>
    let actScore = Namespaced_IRI.parse _namespace_name "actScore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/actingHeadteacher"></see>
    /// </summary>
    let actingHeadteacher =
        Namespaced_IRI.parse _namespace_name "actingHeadteacher" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYear"></see>
    /// </summary>
    let activeYear = Namespaced_IRI.parse _namespace_name "activeYear" |> NamespacedName

    /// <summary>
    /// Also called "floruit". Use this if the active years are in one field that can't be split. Else use activeYearsStartYear and activeYearsEndYear
    /// <see href="http://dbpedia.org/ontology/activeYears"></see></summary>
    let activeYears =
        Namespaced_IRI.parse _namespace_name "activeYears" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsEndDate"></see>
    /// </summary>
    let activeYearsEndDate =
        Namespaced_IRI.parse _namespace_name "activeYearsEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsEndDateMgr"></see>
    /// </summary>
    let activeYearsEndDateMgr =
        Namespaced_IRI.parse _namespace_name "activeYearsEndDateMgr" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsEndYear"></see>
    /// </summary>
    let activeYearsEndYear =
        Namespaced_IRI.parse _namespace_name "activeYearsEndYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsEndYearMgr"></see>
    /// </summary>
    let activeYearsEndYearMgr =
        Namespaced_IRI.parse _namespace_name "activeYearsEndYearMgr" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsStartDate"></see>
    /// </summary>
    let activeYearsStartDate =
        Namespaced_IRI.parse _namespace_name "activeYearsStartDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsStartDateMgr"></see>
    /// </summary>
    let activeYearsStartDateMgr =
        Namespaced_IRI.parse _namespace_name "activeYearsStartDateMgr" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsStartYear"></see>
    /// </summary>
    let activeYearsStartYear =
        Namespaced_IRI.parse _namespace_name "activeYearsStartYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activeYearsStartYearMgr"></see>
    /// </summary>
    let activeYearsStartYearMgr =
        Namespaced_IRI.parse _namespace_name "activeYearsStartYearMgr" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/activity"></see>
    /// </summary>
    let activity = Namespaced_IRI.parse _namespace_name "activity" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/added"></see>
    /// </summary>
    let added = Namespaced_IRI.parse _namespace_name "added" |> NamespacedName
    /// <summary>
    /// Address of something as literal. Usually Building, but we also use it for the address of a Region's or Settlement's government
    /// <see href="http://dbpedia.org/ontology/address"></see></summary>
    let address = Namespaced_IRI.parse _namespace_name "address" |> NamespacedName

    /// <summary>
    /// A building, organisation or other thing that is located in the road.
    /// <see href="http://dbpedia.org/ontology/addressInRoad"></see></summary>
    let addressInRoad =
        Namespaced_IRI.parse _namespace_name "addressInRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/adjacentSettlement"></see>
    /// </summary>
    let adjacentSettlement =
        Namespaced_IRI.parse _namespace_name "adjacentSettlement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/administrativeCenter"></see>
    /// </summary>
    let administrativeCenter =
        Namespaced_IRI.parse _namespace_name "administrativeCenter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/administrativeCollectivity"></see>
    /// </summary>
    let administrativeCollectivity =
        Namespaced_IRI.parse _namespace_name "administrativeCollectivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/administrativeDistrict"></see>
    /// </summary>
    let administrativeDistrict =
        Namespaced_IRI.parse _namespace_name "administrativeDistrict" |> NamespacedName

    /// <summary>
    /// city where stand the administrative power
    /// <see href="http://dbpedia.org/ontology/administrativeHeadCity"></see></summary>
    let administrativeHeadCity =
        Namespaced_IRI.parse _namespace_name "administrativeHeadCity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/administrativeStatus"></see>
    /// </summary>
    let administrativeStatus =
        Namespaced_IRI.parse _namespace_name "administrativeStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/administrator"></see>
    /// </summary>
    let administrator =
        Namespaced_IRI.parse _namespace_name "administrator" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/afdbId"></see>
    /// </summary>
    let afdbId = Namespaced_IRI.parse _namespace_name "afdbId" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/affair"></see>
    /// </summary>
    let affair = Namespaced_IRI.parse _namespace_name "affair" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/affiliate"></see>
    /// </summary>
    let affiliate = Namespaced_IRI.parse _namespace_name "affiliate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/affiliation"></see>
    /// </summary>
    let affiliation =
        Namespaced_IRI.parse _namespace_name "affiliation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/afiAward"></see>
    /// </summary>
    let afiAward = Namespaced_IRI.parse _namespace_name "afiAward" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/age"></see>
    /// </summary>
    let age = Namespaced_IRI.parse _namespace_name "age" |> NamespacedName
    /// <summary>
    /// Age range of students admitted in a School, MilitaryUnit, etc
    /// <see href="http://dbpedia.org/ontology/ageRange"></see></summary>
    let ageRange = Namespaced_IRI.parse _namespace_name "ageRange" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agency"></see>
    /// </summary>
    let agency = Namespaced_IRI.parse _namespace_name "agency" |> NamespacedName

    /// <summary>
    /// Agency station code (used on tickets/reservations, etc.).
    /// <see href="http://dbpedia.org/ontology/agencyStationCode"></see></summary>
    let agencyStationCode =
        Namespaced_IRI.parse _namespace_name "agencyStationCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agglomeration"></see>
    /// </summary>
    let agglomeration =
        Namespaced_IRI.parse _namespace_name "agglomeration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agglomerationArea"></see>
    /// </summary>
    let agglomerationArea =
        Namespaced_IRI.parse _namespace_name "agglomerationArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agglomerationDemographics"></see>
    /// </summary>
    let agglomerationDemographics =
        Namespaced_IRI.parse _namespace_name "agglomerationDemographics" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agglomerationPopulation"></see>
    /// </summary>
    let agglomerationPopulation =
        Namespaced_IRI.parse _namespace_name "agglomerationPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agglomerationPopulationTotal"></see>
    /// </summary>
    let agglomerationPopulationTotal =
        Namespaced_IRI.parse _namespace_name "agglomerationPopulationTotal" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/agglomerationPopulationYear"></see>
    /// </summary>
    let agglomerationPopulationYear =
        Namespaced_IRI.parse _namespace_name "agglomerationPopulationYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aggregation"></see>
    /// </summary>
    let aggregation =
        Namespaced_IRI.parse _namespace_name "aggregation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/airDate"></see>
    /// </summary>
    let airDate = Namespaced_IRI.parse _namespace_name "airDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftAttack"></see>
    /// </summary>
    let aircraftAttack =
        Namespaced_IRI.parse _namespace_name "aircraftAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftBomber"></see>
    /// </summary>
    let aircraftBomber =
        Namespaced_IRI.parse _namespace_name "aircraftBomber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftElectronic"></see>
    /// </summary>
    let aircraftElectronic =
        Namespaced_IRI.parse _namespace_name "aircraftElectronic" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftFighter"></see>
    /// </summary>
    let aircraftFighter =
        Namespaced_IRI.parse _namespace_name "aircraftFighter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopter"></see>
    /// </summary>
    let aircraftHelicopter =
        Namespaced_IRI.parse _namespace_name "aircraftHelicopter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopterAttack"></see>
    /// </summary>
    let aircraftHelicopterAttack =
        Namespaced_IRI.parse _namespace_name "aircraftHelicopterAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopterCargo"></see>
    /// </summary>
    let aircraftHelicopterCargo =
        Namespaced_IRI.parse _namespace_name "aircraftHelicopterCargo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopterMultirole"></see>
    /// </summary>
    let aircraftHelicopterMultirole =
        Namespaced_IRI.parse _namespace_name "aircraftHelicopterMultirole" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopterObservation"></see>
    /// </summary>
    let aircraftHelicopterObservation =
        Namespaced_IRI.parse _namespace_name "aircraftHelicopterObservation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopterTransport"></see>
    /// </summary>
    let aircraftHelicopterTransport =
        Namespaced_IRI.parse _namespace_name "aircraftHelicopterTransport" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftHelicopterUtility"></see>
    /// </summary>
    let aircraftHelicopterUtility =
        Namespaced_IRI.parse _namespace_name "aircraftHelicopterUtility" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftInterceptor"></see>
    /// </summary>
    let aircraftInterceptor =
        Namespaced_IRI.parse _namespace_name "aircraftInterceptor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftPatrol"></see>
    /// </summary>
    let aircraftPatrol =
        Namespaced_IRI.parse _namespace_name "aircraftPatrol" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftRecon"></see>
    /// </summary>
    let aircraftRecon =
        Namespaced_IRI.parse _namespace_name "aircraftRecon" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftTrainer"></see>
    /// </summary>
    let aircraftTrainer =
        Namespaced_IRI.parse _namespace_name "aircraftTrainer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftTransport"></see>
    /// </summary>
    let aircraftTransport =
        Namespaced_IRI.parse _namespace_name "aircraftTransport" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftType"></see>
    /// </summary>
    let aircraftType =
        Namespaced_IRI.parse _namespace_name "aircraftType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aircraftUser"></see>
    /// </summary>
    let aircraftUser =
        Namespaced_IRI.parse _namespace_name "aircraftUser" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/airportUsing"></see>
    /// </summary>
    let airportUsing =
        Namespaced_IRI.parse _namespace_name "airportUsing" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aitaCode"></see>
    /// </summary>
    let aitaCode = Namespaced_IRI.parse _namespace_name "aitaCode" |> NamespacedName
    /// <summary>
    /// reflection coefficient
    /// <see href="http://dbpedia.org/ontology/albedo"></see></summary>
    let albedo = Namespaced_IRI.parse _namespace_name "albedo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/album"></see>
    /// </summary>
    let album = Namespaced_IRI.parse _namespace_name "album" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/albumRuntime"></see>
    /// </summary>
    let albumRuntime =
        Namespaced_IRI.parse _namespace_name "albumRuntime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/alias"></see>
    /// </summary>
    let alias = Namespaced_IRI.parse _namespace_name "alias" |> NamespacedName

    /// <summary>
    /// Alternative naming of anything not being a Person (for which case foaf:nick should be used).
    /// <see href="http://dbpedia.org/ontology/alternativeName"></see></summary>
    let alternativeName =
        Namespaced_IRI.parse _namespace_name "alternativeName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/allcinemaId"></see>
    /// </summary>
    let allcinemaId =
        Namespaced_IRI.parse _namespace_name "allcinemaId" |> NamespacedName

    /// <summary>
    /// The country or other power the person served. Multiple countries may be indicated together with the corresponding dates. This field should not be used to indicate a particular service branch, which is better indicated by the branch field.
    /// <see href="http://dbpedia.org/ontology/allegiance"></see></summary>
    let allegiance = Namespaced_IRI.parse _namespace_name "allegiance" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/alliance"></see>
    /// </summary>
    let alliance = Namespaced_IRI.parse _namespace_name "alliance" |> NamespacedName
    /// <summary>
    /// schools that they attended
    /// <see href="http://dbpedia.org/ontology/almaMater"></see></summary>
    let almaMater = Namespaced_IRI.parse _namespace_name "almaMater" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/alongside"></see>
    /// </summary>
    let alongside = Namespaced_IRI.parse _namespace_name "alongside" |> NamespacedName
    /// <summary>
    /// the Alps group to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsGroup"></see></summary>
    let alpsGroup = Namespaced_IRI.parse _namespace_name "alpsGroup" |> NamespacedName

    /// <summary>
    /// the Alps main part to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsMainPart"></see></summary>
    let alpsMainPart =
        Namespaced_IRI.parse _namespace_name "alpsMainPart" |> NamespacedName

    /// <summary>
    /// the Alps major sector to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsMajorSector"></see></summary>
    let alpsMajorSector =
        Namespaced_IRI.parse _namespace_name "alpsMajorSector" |> NamespacedName

    /// <summary>
    /// the Alps section to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsSection"></see></summary>
    let alpsSection =
        Namespaced_IRI.parse _namespace_name "alpsSection" |> NamespacedName

    /// <summary>
    /// the Alps SOIUSA code corresponding to the mountain, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsSoiusaCode"></see></summary>
    let alpsSoiusaCode =
        Namespaced_IRI.parse _namespace_name "alpsSoiusaCode" |> NamespacedName

    /// <summary>
    /// the Alps subgroup to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsSubgroup"></see></summary>
    let alpsSubgroup =
        Namespaced_IRI.parse _namespace_name "alpsSubgroup" |> NamespacedName

    /// <summary>
    /// the Alps subsection to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsSubsection"></see></summary>
    let alpsSubsection =
        Namespaced_IRI.parse _namespace_name "alpsSubsection" |> NamespacedName

    /// <summary>
    /// the Alps supergroup to which the mountain belongs, according to the SOIUSA classification
    /// <see href="http://dbpedia.org/ontology/alpsSupergroup"></see></summary>
    let alpsSupergroup =
        Namespaced_IRI.parse _namespace_name "alpsSupergroup" |> NamespacedName

    /// <summary>
    /// The alternative title attributed to a work
    /// <see href="http://dbpedia.org/ontology/alternativeTitle"></see></summary>
    let alternativeTitle =
        Namespaced_IRI.parse _namespace_name "alternativeTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/altitude"></see>
    /// </summary>
    let altitude = Namespaced_IRI.parse _namespace_name "altitude" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/alumni"></see>
    /// </summary>
    let alumni = Namespaced_IRI.parse _namespace_name "alumni" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurDefeat"></see>
    /// </summary>
    let amateurDefeat =
        Namespaced_IRI.parse _namespace_name "amateurDefeat" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurFight"></see>
    /// </summary>
    let amateurFight =
        Namespaced_IRI.parse _namespace_name "amateurFight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurKo"></see>
    /// </summary>
    let amateurKo = Namespaced_IRI.parse _namespace_name "amateurKo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurNoContest"></see>
    /// </summary>
    let amateurNoContest =
        Namespaced_IRI.parse _namespace_name "amateurNoContest" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurTeam"></see>
    /// </summary>
    let amateurTeam =
        Namespaced_IRI.parse _namespace_name "amateurTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Athlete,_CareerStation"></see>
    /// </summary>
    let ``Athlete,_CareerStation`` =
        Namespaced_IRI.parse _namespace_name "Athlete,_CareerStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurTie"></see>
    /// </summary>
    let amateurTie = Namespaced_IRI.parse _namespace_name "amateurTie" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurTitle"></see>
    /// </summary>
    let amateurTitle =
        Namespaced_IRI.parse _namespace_name "amateurTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurVictory"></see>
    /// </summary>
    let amateurVictory =
        Namespaced_IRI.parse _namespace_name "amateurVictory" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amateurYear"></see>
    /// </summary>
    let amateurYear =
        Namespaced_IRI.parse _namespace_name "amateurYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/americanComedyAward"></see>
    /// </summary>
    let americanComedyAward =
        Namespaced_IRI.parse _namespace_name "americanComedyAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amgid"></see>
    /// </summary>
    let amgid = Namespaced_IRI.parse _namespace_name "amgid" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/amsterdamCode"></see>
    /// </summary>
    let amsterdamCode =
        Namespaced_IRI.parse _namespace_name "amsterdamCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/analogChannel"></see>
    /// </summary>
    let analogChannel =
        Namespaced_IRI.parse _namespace_name "analogChannel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/animal"></see>
    /// </summary>
    let animal = Namespaced_IRI.parse _namespace_name "animal" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/animator"></see>
    /// </summary>
    let animator = Namespaced_IRI.parse _namespace_name "animator" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/anniversary"></see>
    /// </summary>
    let anniversary =
        Namespaced_IRI.parse _namespace_name "anniversary" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/announcedFrom"></see>
    /// </summary>
    let announcedFrom =
        Namespaced_IRI.parse _namespace_name "announcedFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/annualTemperature"></see>
    /// </summary>
    let annualTemperature =
        Namespaced_IRI.parse _namespace_name "annualTemperature" |> NamespacedName

    /// <summary>
    /// Official song (anthem) of a PopulatedPlace, SportsTeam, School or other
    /// <see href="http://dbpedia.org/ontology/anthem"></see></summary>
    let anthem = Namespaced_IRI.parse _namespace_name "anthem" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/apcPresident"></see>
    /// </summary>
    let apcPresident =
        Namespaced_IRI.parse _namespace_name "apcPresident" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/apoapsis"></see>
    /// </summary>
    let apoapsis = Namespaced_IRI.parse _namespace_name "apoapsis" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/apofocus"></see>
    /// </summary>
    let apofocus = Namespaced_IRI.parse _namespace_name "apofocus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/apparentMagnitude"></see>
    /// </summary>
    let apparentMagnitude =
        Namespaced_IRI.parse _namespace_name "apparentMagnitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/appearancesInLeague"></see>
    /// </summary>
    let appearancesInLeague =
        Namespaced_IRI.parse _namespace_name "appearancesInLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/appearancesInNationalTeam"></see>
    /// </summary>
    let appearancesInNationalTeam =
        Namespaced_IRI.parse _namespace_name "appearancesInNationalTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/appointer"></see>
    /// </summary>
    let appointer = Namespaced_IRI.parse _namespace_name "appointer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/approach"></see>
    /// </summary>
    let approach = Namespaced_IRI.parse _namespace_name "approach" |> NamespacedName

    /// <summary>
    /// Date of approval by lower parliament (House of Commons, Chambre des Députés, Bundestag, Tweede Kamer etc.).
    /// <see href="http://dbpedia.org/ontology/approvedByLowerParliament"></see></summary>
    let approvedByLowerParliament =
        Namespaced_IRI.parse _namespace_name "approvedByLowerParliament" |> NamespacedName

    /// <summary>
    /// Date of approval by upper parliament (House of Lords, Sénat, Eerste Kamer etc.).
    /// <see href="http://dbpedia.org/ontology/approvedByUpperParliament"></see></summary>
    let approvedByUpperParliament =
        Namespaced_IRI.parse _namespace_name "approvedByUpperParliament" |> NamespacedName

    /// <summary>
    /// Approximate calories per serving.
    /// <see href="http://dbpedia.org/ontology/approximateCalories"></see></summary>
    let approximateCalories =
        Namespaced_IRI.parse _namespace_name "approximateCalories" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/apskritis"></see>
    /// </summary>
    let apskritis = Namespaced_IRI.parse _namespace_name "apskritis" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/archipelago"></see>
    /// </summary>
    let archipelago =
        Namespaced_IRI.parse _namespace_name "archipelago" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/architect"></see>
    /// </summary>
    let architect = Namespaced_IRI.parse _namespace_name "architect" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/architectualBureau"></see>
    /// </summary>
    let architectualBureau =
        Namespaced_IRI.parse _namespace_name "architectualBureau" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/architecturalMovement"></see>
    /// </summary>
    let architecturalMovement =
        Namespaced_IRI.parse _namespace_name "architecturalMovement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/architecturalStyle"></see>
    /// </summary>
    let architecturalStyle =
        Namespaced_IRI.parse _namespace_name "architecturalStyle" |> NamespacedName

    /// <summary>
    /// The area of the thing in square meters.
    /// <see href="http://dbpedia.org/ontology/area"></see></summary>
    let area = Namespaced_IRI.parse _namespace_name "area" |> NamespacedName
    /// <summary>
    /// Area code for telephone numbers. Use this not phonePrefix
    /// <see href="http://dbpedia.org/ontology/areaCode"></see></summary>
    let areaCode = Namespaced_IRI.parse _namespace_name "areaCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaDate"></see>
    /// </summary>
    let areaDate = Namespaced_IRI.parse _namespace_name "areaDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaLand"></see>
    /// </summary>
    let areaLand = Namespaced_IRI.parse _namespace_name "areaLand" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaMetro"></see>
    /// </summary>
    let areaMetro = Namespaced_IRI.parse _namespace_name "areaMetro" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaOfCatchment"></see>
    /// </summary>
    let areaOfCatchment =
        Namespaced_IRI.parse _namespace_name "areaOfCatchment" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaOfCatchmentQuote"></see>
    /// </summary>
    let areaOfCatchmentQuote =
        Namespaced_IRI.parse _namespace_name "areaOfCatchmentQuote" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaOfSearch"></see>
    /// </summary>
    let areaOfSearch =
        Namespaced_IRI.parse _namespace_name "areaOfSearch" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaQuote"></see>
    /// </summary>
    let areaQuote = Namespaced_IRI.parse _namespace_name "areaQuote" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaRank"></see>
    /// </summary>
    let areaRank = Namespaced_IRI.parse _namespace_name "areaRank" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaRural"></see>
    /// </summary>
    let areaRural = Namespaced_IRI.parse _namespace_name "areaRural" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaTotal"></see>
    /// </summary>
    let areaTotal = Namespaced_IRI.parse _namespace_name "areaTotal" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaTotalRanking"></see>
    /// </summary>
    let areaTotalRanking =
        Namespaced_IRI.parse _namespace_name "areaTotalRanking" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaUrban"></see>
    /// </summary>
    let areaUrban = Namespaced_IRI.parse _namespace_name "areaUrban" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/areaWater"></see>
    /// </summary>
    let areaWater = Namespaced_IRI.parse _namespace_name "areaWater" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/argueDate"></see>
    /// </summary>
    let argueDate = Namespaced_IRI.parse _namespace_name "argueDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/arielAward"></see>
    /// </summary>
    let arielAward = Namespaced_IRI.parse _namespace_name "arielAward" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/arm"></see>
    /// </summary>
    let arm = Namespaced_IRI.parse _namespace_name "arm" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/army"></see>
    /// </summary>
    let army = Namespaced_IRI.parse _namespace_name "army" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/arrestDate"></see>
    /// </summary>
    let arrestDate = Namespaced_IRI.parse _namespace_name "arrestDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/arrondissement"></see>
    /// </summary>
    let arrondissement =
        Namespaced_IRI.parse _namespace_name "arrondissement" |> NamespacedName

    /// <summary>
    /// An influential, wealthy person who supported an artist, craftsman, a scholar or a noble.. See also
    /// <see href="http://dbpedia.org/ontology/artPatron"></see></summary>
    let artPatron = Namespaced_IRI.parse _namespace_name "artPatron" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/artery"></see>
    /// </summary>
    let artery = Namespaced_IRI.parse _namespace_name "artery" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/artificialSnowArea"></see>
    /// </summary>
    let artificialSnowArea =
        Namespaced_IRI.parse _namespace_name "artificialSnowArea" |> NamespacedName

    /// <summary>
    /// The performer or creator of the musical work.
    /// <see href="http://dbpedia.org/ontology/artist"></see></summary>
    let artist = Namespaced_IRI.parse _namespace_name "artist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/artisticFunction"></see>
    /// </summary>
    let artisticFunction =
        Namespaced_IRI.parse _namespace_name "artisticFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/asWikiText"></see>
    /// </summary>
    let asWikiText = Namespaced_IRI.parse _namespace_name "asWikiText" |> NamespacedName
    /// <summary>
    /// Ascent of a celestial body, aircraft, etc. For person who ascended a mountain, use firstAscent
    /// <see href="http://dbpedia.org/ontology/ascent"></see></summary>
    let ascent = Namespaced_IRI.parse _namespace_name "ascent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/asiaChampionship"></see>
    /// </summary>
    let asiaChampionship =
        Namespaced_IRI.parse _namespace_name "asiaChampionship" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/aspectRatio"></see>
    /// </summary>
    let aspectRatio =
        Namespaced_IRI.parse _namespace_name "aspectRatio" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/assembly"></see>
    /// </summary>
    let assembly = Namespaced_IRI.parse _namespace_name "assembly" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/assetUnderManagement"></see>
    /// </summary>
    let assetUnderManagement =
        Namespaced_IRI.parse _namespace_name "assetUnderManagement" |> NamespacedName

    /// <summary>
    /// Assets and liabilities are part of a companis balance sheet. In financial accounting, assets are economic resources. Anything tangible or intangible that is capable of being owned or controlled to produce value and that is held to have positive economic value is considered an asset.
    /// <see href="http://dbpedia.org/ontology/assets"></see></summary>
    let assets = Namespaced_IRI.parse _namespace_name "assets" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/assistantPrincipal"></see>
    /// </summary>
    let assistantPrincipal =
        Namespaced_IRI.parse _namespace_name "assistantPrincipal" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associate"></see>
    /// </summary>
    let associate = Namespaced_IRI.parse _namespace_name "associate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associateEditor"></see>
    /// </summary>
    let associateEditor =
        Namespaced_IRI.parse _namespace_name "associateEditor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associateStar"></see>
    /// </summary>
    let associateStar =
        Namespaced_IRI.parse _namespace_name "associateStar" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associatedAct"></see>
    /// </summary>
    let associatedAct =
        Namespaced_IRI.parse _namespace_name "associatedAct" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associatedBand"></see>
    /// </summary>
    let associatedBand =
        Namespaced_IRI.parse _namespace_name "associatedBand" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associatedMusicalArtist"></see>
    /// </summary>
    let associatedMusicalArtist =
        Namespaced_IRI.parse _namespace_name "associatedMusicalArtist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associatedRocket"></see>
    /// </summary>
    let associatedRocket =
        Namespaced_IRI.parse _namespace_name "associatedRocket" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/associationOfLocalGovernment"></see>
    /// </summary>
    let associationOfLocalGovernment =
        Namespaced_IRI.parse _namespace_name "associationOfLocalGovernment" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/astrologicalSign"></see>
    /// </summary>
    let astrologicalSign =
        Namespaced_IRI.parse _namespace_name "astrologicalSign" |> NamespacedName

    /// <summary>
    /// Page # where the referenced resource is to be found in the source document
    /// <see href="http://dbpedia.org/ontology/atPage"></see></summary>
    let atPage = Namespaced_IRI.parse _namespace_name "atPage" |> NamespacedName

    /// <summary>
    /// Row # where the referenced resource is to be found in the source file
    /// <see href="http://dbpedia.org/ontology/atRowNumber"></see></summary>
    let atRowNumber =
        Namespaced_IRI.parse _namespace_name "atRowNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/atcPrefix"></see>
    /// </summary>
    let atcPrefix = Namespaced_IRI.parse _namespace_name "atcPrefix" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/atcSuffix"></see>
    /// </summary>
    let atcSuffix = Namespaced_IRI.parse _namespace_name "atcSuffix" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/atcSupplemental"></see>
    /// </summary>
    let atcSupplemental =
        Namespaced_IRI.parse _namespace_name "atcSupplemental" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/athletics"></see>
    /// </summary>
    let athletics = Namespaced_IRI.parse _namespace_name "athletics" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/athleticsDiscipline"></see>
    /// </summary>
    let athleticsDiscipline =
        Namespaced_IRI.parse _namespace_name "athleticsDiscipline" |> NamespacedName

    /// <summary>
    /// the ratio of the average mass of atoms of an element (from a single given sample or source) to 1⁄12 of the mass of an atom of carbon-12
    /// <see href="http://dbpedia.org/ontology/atomicNumber"></see></summary>
    let atomicNumber =
        Namespaced_IRI.parse _namespace_name "atomicNumber" |> NamespacedName

    /// <summary>
    /// Public attorney
    /// <see href="http://dbpedia.org/ontology/attorneyGeneral"></see></summary>
    let attorneyGeneral =
        Namespaced_IRI.parse _namespace_name "attorneyGeneral" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/australiaOpenDouble"></see>
    /// </summary>
    let australiaOpenDouble =
        Namespaced_IRI.parse _namespace_name "australiaOpenDouble" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/australiaOpenMixed"></see>
    /// </summary>
    let australiaOpenMixed =
        Namespaced_IRI.parse _namespace_name "australiaOpenMixed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/australiaOpenSingle"></see>
    /// </summary>
    let australiaOpenSingle =
        Namespaced_IRI.parse _namespace_name "australiaOpenSingle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/author"></see>
    /// </summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/authority"></see>
    /// </summary>
    let authority = Namespaced_IRI.parse _namespace_name "authority" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/authorityMandate"></see>
    /// </summary>
    let authorityMandate =
        Namespaced_IRI.parse _namespace_name "authorityMandate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/authorityTitle"></see>
    /// </summary>
    let authorityTitle =
        Namespaced_IRI.parse _namespace_name "authorityTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/RomaniaSettlement"></see>
    /// </summary>
    let RomaniaSettlement =
        Namespaced_IRI.parse _namespace_name "RomaniaSettlement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/automobileModel"></see>
    /// </summary>
    let automobileModel =
        Namespaced_IRI.parse _namespace_name "automobileModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/automobilePlatform"></see>
    /// </summary>
    let automobilePlatform =
        Namespaced_IRI.parse _namespace_name "automobilePlatform" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/autonomy"></see>
    /// </summary>
    let autonomy = Namespaced_IRI.parse _namespace_name "autonomy" |> NamespacedName

    /// <summary>
    /// Smartcard for fare payment system for public transit systems that are or will be available at the station.
    /// <see href="http://dbpedia.org/ontology/availableSmartCard"></see></summary>
    let availableSmartCard =
        Namespaced_IRI.parse _namespace_name "availableSmartCard" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/average"></see>
    /// </summary>
    let average = Namespaced_IRI.parse _namespace_name "average" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/averageAnnualGeneration"></see>
    /// </summary>
    let averageAnnualGeneration =
        Namespaced_IRI.parse _namespace_name "averageAnnualGeneration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/averageClassSize"></see>
    /// </summary>
    let averageClassSize =
        Namespaced_IRI.parse _namespace_name "averageClassSize" |> NamespacedName

    /// <summary>
    /// Source of the value can be declare by .
    /// <see href="http://dbpedia.org/ontology/averageDepth"></see></summary>
    let averageDepth =
        Namespaced_IRI.parse _namespace_name "averageDepth" |> NamespacedName

    /// <summary>
    /// Is a measure of the distance between a reference height and a point underneath. The exact meaning for a place is unclear. If possible, use  or  to be unambiguous.
    /// <see href="http://dbpedia.org/ontology/depth"></see></summary>
    let depth = Namespaced_IRI.parse _namespace_name "depth" |> NamespacedName

    /// <summary>
    /// Source of the  value.
    /// <see href="http://dbpedia.org/ontology/averageDepthQuote"></see></summary>
    let averageDepthQuote =
        Namespaced_IRI.parse _namespace_name "averageDepthQuote" |> NamespacedName

    /// <summary>
    /// The average speed of a thing.
    /// <see href="http://dbpedia.org/ontology/averageSpeed"></see></summary>
    let averageSpeed =
        Namespaced_IRI.parse _namespace_name "averageSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/avifaunaPopulation"></see>
    /// </summary>
    let avifaunaPopulation =
        Namespaced_IRI.parse _namespace_name "avifaunaPopulation" |> NamespacedName

    /// <summary>
    /// Award won by a Person, Musical or other Work, RaceHorse, Building, etc
    /// <see href="http://dbpedia.org/ontology/award"></see></summary>
    let award = Namespaced_IRI.parse _namespace_name "award" |> NamespacedName
    /// <summary>
    /// Award a person has received (literal). Compare to award (ObjectProperty)
    /// <see href="http://dbpedia.org/ontology/awardName"></see></summary>
    let awardName = Namespaced_IRI.parse _namespace_name "awardName" |> NamespacedName

    /// <summary>
    /// A colour represented by its hex code (e.g.: #FF0000 or #40E0D0).
    /// <see href="http://dbpedia.org/ontology/awayColourHexCode"></see></summary>
    let awayColourHexCode =
        Namespaced_IRI.parse _namespace_name "awayColourHexCode" |> NamespacedName

    /// <summary>
    /// A colour represented by its hex code (e.g.: #FF0000 or #40E0D0).
    /// <see href="http://dbpedia.org/ontology/colourHexCode"></see></summary>
    let colourHexCode =
        Namespaced_IRI.parse _namespace_name "colourHexCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bSide"></see>
    /// </summary>
    let bSide = Namespaced_IRI.parse _namespace_name "bSide" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/background"></see>
    /// </summary>
    let background = Namespaced_IRI.parse _namespace_name "background" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/backhand"></see>
    /// </summary>
    let backhand = Namespaced_IRI.parse _namespace_name "backhand" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/badGuy"></see>
    /// </summary>
    let badGuy = Namespaced_IRI.parse _namespace_name "badGuy" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/baftaAward"></see>
    /// </summary>
    let baftaAward = Namespaced_IRI.parse _namespace_name "baftaAward" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/band"></see>
    /// </summary>
    let band = Namespaced_IRI.parse _namespace_name "band" |> NamespacedName
    /// <summary>
    /// A member of the band.
    /// <see href="http://dbpedia.org/ontology/bandMember"></see></summary>
    let bandMember = Namespaced_IRI.parse _namespace_name "bandMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/barPassRate"></see>
    /// </summary>
    let barPassRate =
        Namespaced_IRI.parse _namespace_name "barPassRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/barangays"></see>
    /// </summary>
    let barangays = Namespaced_IRI.parse _namespace_name "barangays" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/basedOn"></see>
    /// </summary>
    let basedOn = Namespaced_IRI.parse _namespace_name "basedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/battingSide"></see>
    /// </summary>
    let battingSide =
        Namespaced_IRI.parse _namespace_name "battingSide" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/battle"></see>
    /// </summary>
    let battle = Namespaced_IRI.parse _namespace_name "battle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/battleHonours"></see>
    /// </summary>
    let battleHonours =
        Namespaced_IRI.parse _namespace_name "battleHonours" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/beatifiedBy"></see>
    /// </summary>
    let beatifiedBy =
        Namespaced_IRI.parse _namespace_name "beatifiedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/beatifiedDate"></see>
    /// </summary>
    let beatifiedDate =
        Namespaced_IRI.parse _namespace_name "beatifiedDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/beatifiedPlace"></see>
    /// </summary>
    let beatifiedPlace =
        Namespaced_IRI.parse _namespace_name "beatifiedPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bedCount"></see>
    /// </summary>
    let bedCount = Namespaced_IRI.parse _namespace_name "bedCount" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/believers"></see>
    /// </summary>
    let believers = Namespaced_IRI.parse _namespace_name "believers" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/beltwayCity"></see>
    /// </summary>
    let beltwayCity =
        Namespaced_IRI.parse _namespace_name "beltwayCity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bestFinish"></see>
    /// </summary>
    let bestFinish = Namespaced_IRI.parse _namespace_name "bestFinish" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bestLap"></see>
    /// </summary>
    let bestLap = Namespaced_IRI.parse _namespace_name "bestLap" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bestRankDouble"></see>
    /// </summary>
    let bestRankDouble =
        Namespaced_IRI.parse _namespace_name "bestRankDouble" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bestRankSingle"></see>
    /// </summary>
    let bestRankSingle =
        Namespaced_IRI.parse _namespace_name "bestRankSingle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bestWsopRank"></see>
    /// </summary>
    let bestWsopRank =
        Namespaced_IRI.parse _namespace_name "bestWsopRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bestYearWsop"></see>
    /// </summary>
    let bestYearWsop =
        Namespaced_IRI.parse _namespace_name "bestYearWsop" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bgafdId"></see>
    /// </summary>
    let bgafdId = Namespaced_IRI.parse _namespace_name "bgafdId" |> NamespacedName
    /// <summary>
    /// BIBSYS is a supplier of library and information systems for all Norwegian university Libraries, the National Library of Norway, college libraries, and a number of research libraries and institutions.
    /// <see href="http://dbpedia.org/ontology/bibsysId"></see></summary>
    let bibsysId = Namespaced_IRI.parse _namespace_name "bibsysId" |> NamespacedName

    /// <summary>
    /// Information on station's bicycle facilities.
    /// <see href="http://dbpedia.org/ontology/bicycleInformation"></see></summary>
    let bicycleInformation =
        Namespaced_IRI.parse _namespace_name "bicycleInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bigPoolRecord"></see>
    /// </summary>
    let bigPoolRecord =
        Namespaced_IRI.parse _namespace_name "bigPoolRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/biggestCity"></see>
    /// </summary>
    let biggestCity =
        Namespaced_IRI.parse _namespace_name "biggestCity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/billed"></see>
    /// </summary>
    let billed = Namespaced_IRI.parse _namespace_name "billed" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/binomial"></see>
    /// </summary>
    let binomial = Namespaced_IRI.parse _namespace_name "binomial" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/binomialAuthority"></see>
    /// </summary>
    let binomialAuthority =
        Namespaced_IRI.parse _namespace_name "binomialAuthority" |> NamespacedName

    /// <summary>
    /// "The rate and extent to which the active ingredient or active moiety is absorbed from a drug product and becomes available at the site of action. For drug products that are not intended to be absorbed into the bloodstream, bioavailability may be assessed by measurements intended to reflect the rate and extent to which the active ingredient or active moiety becomes available at the site of action (21CFR320.1)."
    /// <see href="http://dbpedia.org/ontology/bioavailability"></see></summary>
    let bioavailability =
        Namespaced_IRI.parse _namespace_name "bioavailability" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bioclimate"></see>
    /// </summary>
    let bioclimate = Namespaced_IRI.parse _namespace_name "bioclimate" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/biome"></see>
    /// </summary>
    let biome = Namespaced_IRI.parse _namespace_name "biome" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bird"></see>
    /// </summary>
    let bird = Namespaced_IRI.parse _namespace_name "bird" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/birthDate"></see>
    /// </summary>
    let birthDate = Namespaced_IRI.parse _namespace_name "birthDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/birthName"></see>
    /// </summary>
    let birthName = Namespaced_IRI.parse _namespace_name "birthName" |> NamespacedName
    /// <summary>
    /// where the person was born
    /// <see href="http://dbpedia.org/ontology/birthPlace"></see></summary>
    let birthPlace = Namespaced_IRI.parse _namespace_name "birthPlace" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/birthSign"></see>
    /// </summary>
    let birthSign = Namespaced_IRI.parse _namespace_name "birthSign" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/birthYear"></see>
    /// </summary>
    let birthYear = Namespaced_IRI.parse _namespace_name "birthYear" |> NamespacedName
    /// <summary>
    /// A bishopric (diocese or episcopal see) is a district under the supervision of a bishop. It is divided into parishes. Compare with eparchy
    /// <see href="http://dbpedia.org/ontology/bishopric"></see></summary>
    let bishopric = Namespaced_IRI.parse _namespace_name "bishopric" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blackLongDistancePisteNumber"></see>
    /// </summary>
    let blackLongDistancePisteNumber =
        Namespaced_IRI.parse _namespace_name "blackLongDistancePisteNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blackSkiPisteNumber"></see>
    /// </summary>
    let blackSkiPisteNumber =
        Namespaced_IRI.parse _namespace_name "blackSkiPisteNumber" |> NamespacedName

    /// <summary>
    /// Coat of arms (heraldic image) or emblem
    /// <see href="http://dbpedia.org/ontology/blazon"></see></summary>
    let blazon = Namespaced_IRI.parse _namespace_name "blazon" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blazonCaption"></see>
    /// </summary>
    let blazonCaption =
        Namespaced_IRI.parse _namespace_name "blazonCaption" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blazonLink"></see>
    /// </summary>
    let blazonLink = Namespaced_IRI.parse _namespace_name "blazonLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blazonRatio"></see>
    /// </summary>
    let blazonRatio =
        Namespaced_IRI.parse _namespace_name "blazonRatio" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/block"></see>
    /// </summary>
    let block = Namespaced_IRI.parse _namespace_name "block" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blockAlloy"></see>
    /// </summary>
    let blockAlloy = Namespaced_IRI.parse _namespace_name "blockAlloy" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bloodGroup"></see>
    /// </summary>
    let bloodGroup = Namespaced_IRI.parse _namespace_name "bloodGroup" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bloodType"></see>
    /// </summary>
    let bloodType = Namespaced_IRI.parse _namespace_name "bloodType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blueLongDistancePisteNumber"></see>
    /// </summary>
    let blueLongDistancePisteNumber =
        Namespaced_IRI.parse _namespace_name "blueLongDistancePisteNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/blueSkiPisteNumber"></see>
    /// </summary>
    let blueSkiPisteNumber =
        Namespaced_IRI.parse _namespace_name "blueSkiPisteNumber" |> NamespacedName

    /// <summary>
    /// Authority data of people listed in the general catalogue of the National Library of France
    /// <see href="http://dbpedia.org/ontology/bnfId"></see></summary>
    let bnfId = Namespaced_IRI.parse _namespace_name "bnfId" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/board"></see>
    /// </summary>
    let board = Namespaced_IRI.parse _namespace_name "board" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bodyDiscovered"></see>
    /// </summary>
    let bodyDiscovered =
        Namespaced_IRI.parse _namespace_name "bodyDiscovered" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bodyStyle"></see>
    /// </summary>
    let bodyStyle = Namespaced_IRI.parse _namespace_name "bodyStyle" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/boiler"></see>
    /// </summary>
    let boiler = Namespaced_IRI.parse _namespace_name "boiler" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/boilerPressure"></see>
    /// </summary>
    let boilerPressure =
        Namespaced_IRI.parse _namespace_name "boilerPressure" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/boilingPoint"></see>
    /// </summary>
    let boilingPoint =
        Namespaced_IRI.parse _namespace_name "boilingPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/booster"></see>
    /// </summary>
    let booster = Namespaced_IRI.parse _namespace_name "booster" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/border"></see>
    /// </summary>
    let border = Namespaced_IRI.parse _namespace_name "border" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/borough"></see>
    /// </summary>
    let borough = Namespaced_IRI.parse _namespace_name "borough" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bourgmestre"></see>
    /// </summary>
    let bourgmestre =
        Namespaced_IRI.parse _namespace_name "bourgmestre" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bowlRecord"></see>
    /// </summary>
    let bowlRecord = Namespaced_IRI.parse _namespace_name "bowlRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/boxerCategory"></see>
    /// </summary>
    let boxerCategory =
        Namespaced_IRI.parse _namespace_name "boxerCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/boxerStyle"></see>
    /// </summary>
    let boxerStyle = Namespaced_IRI.parse _namespace_name "boxerStyle" |> NamespacedName
    /// <summary>
    /// Dutch project with material for 40,000 digitized biographies, including former colonies of the Netherlands.
    /// <see href="http://dbpedia.org/ontology/bpnId"></see></summary>
    let bpnId = Namespaced_IRI.parse _namespace_name "bpnId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/brainInfoNumber"></see>
    /// </summary>
    let brainInfoNumber =
        Namespaced_IRI.parse _namespace_name "brainInfoNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/brainInfoType"></see>
    /// </summary>
    let brainInfoType =
        Namespaced_IRI.parse _namespace_name "brainInfoType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/branchFrom"></see>
    /// </summary>
    let branchFrom = Namespaced_IRI.parse _namespace_name "branchFrom" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/branchTo"></see>
    /// </summary>
    let branchTo = Namespaced_IRI.parse _namespace_name "branchTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/brand"></see>
    /// </summary>
    let brand = Namespaced_IRI.parse _namespace_name "brand" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/breeder"></see>
    /// </summary>
    let breeder = Namespaced_IRI.parse _namespace_name "breeder" |> NamespacedName

    /// <summary>
    /// Type of vehicles the bridge carries.
    /// <see href="http://dbpedia.org/ontology/bridgeCarries"></see></summary>
    let bridgeCarries =
        Namespaced_IRI.parse _namespace_name "bridgeCarries" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/britishComedyAwards"></see>
    /// </summary>
    let britishComedyAwards =
        Namespaced_IRI.parse _namespace_name "britishComedyAwards" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/britishOpen"></see>
    /// </summary>
    let britishOpen =
        Namespaced_IRI.parse _namespace_name "britishOpen" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/britishWins"></see>
    /// </summary>
    let britishWins =
        Namespaced_IRI.parse _namespace_name "britishWins" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/broadcastArea"></see>
    /// </summary>
    let broadcastArea =
        Namespaced_IRI.parse _namespace_name "broadcastArea" |> NamespacedName

    /// <summary>
    /// The parent broadcast network to which the broadcaster belongs.
    /// <see href="http://dbpedia.org/ontology/broadcastNetwork"></see></summary>
    let broadcastNetwork =
        Namespaced_IRI.parse _namespace_name "broadcastNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/broadcastRepeater"></see>
    /// </summary>
    let broadcastRepeater =
        Namespaced_IRI.parse _namespace_name "broadcastRepeater" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/broadcastStationClass"></see>
    /// </summary>
    let broadcastStationClass =
        Namespaced_IRI.parse _namespace_name "broadcastStationClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/broadcastTranslator"></see>
    /// </summary>
    let broadcastTranslator =
        Namespaced_IRI.parse _namespace_name "broadcastTranslator" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bronzeMedalDouble"></see>
    /// </summary>
    let bronzeMedalDouble =
        Namespaced_IRI.parse _namespace_name "bronzeMedalDouble" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bronzeMedalMixed"></see>
    /// </summary>
    let bronzeMedalMixed =
        Namespaced_IRI.parse _namespace_name "bronzeMedalMixed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bronzeMedalSingle"></see>
    /// </summary>
    let bronzeMedalSingle =
        Namespaced_IRI.parse _namespace_name "bronzeMedalSingle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bronzeMedalist"></see>
    /// </summary>
    let bronzeMedalist =
        Namespaced_IRI.parse _namespace_name "bronzeMedalist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Medalist"></see>
    /// </summary>
    let Medalist = Namespaced_IRI.parse _namespace_name "Medalist" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/budget"></see>
    /// </summary>
    let budget = Namespaced_IRI.parse _namespace_name "budget" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/budgetYear"></see>
    /// </summary>
    let budgetYear = Namespaced_IRI.parse _namespace_name "budgetYear" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/builder"></see>
    /// </summary>
    let builder = Namespaced_IRI.parse _namespace_name "builder" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/building"></see>
    /// </summary>
    let building = Namespaced_IRI.parse _namespace_name "building" |> NamespacedName

    /// <summary>
    /// Building end date of an ArchitecturalStructure, man-made Lake, etc. For older structures this can be just a year or century, for newer structures an exact date is preferred
    /// <see href="http://dbpedia.org/ontology/buildingEndDate"></see></summary>
    let buildingEndDate =
        Namespaced_IRI.parse _namespace_name "buildingEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/buildingEndYear"></see>
    /// </summary>
    let buildingEndYear =
        Namespaced_IRI.parse _namespace_name "buildingEndYear" |> NamespacedName

    /// <summary>
    /// Building start date of an ArchitecturalStructure, man-made Lake, etc. For older structures this can be just a year or century, for newer structures an exact date is preferred
    /// <see href="http://dbpedia.org/ontology/buildingStartDate"></see></summary>
    let buildingStartDate =
        Namespaced_IRI.parse _namespace_name "buildingStartDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/buildingStartYear"></see>
    /// </summary>
    let buildingStartYear =
        Namespaced_IRI.parse _namespace_name "buildingStartYear" |> NamespacedName

    /// <summary>
    /// Type is too general. We should be able to distinguish types of music from types of architecture
    /// <see href="http://dbpedia.org/ontology/buildingType"></see></summary>
    let buildingType =
        Namespaced_IRI.parse _namespace_name "buildingType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/bustSize"></see>
    /// </summary>
    let bustSize = Namespaced_IRI.parse _namespace_name "bustSize" |> NamespacedName

    /// <summary>
    /// Use this property if all 3 sizes are given together (DBpedia cannot currently extract 3 Lengths out of a field). Otherwise use separate fields bustSize, waistSize, hipSize
    /// <see href="http://dbpedia.org/ontology/bustWaistHipSize"></see></summary>
    let bustWaistHipSize =
        Namespaced_IRI.parse _namespace_name "bustWaistHipSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cableCar"></see>
    /// </summary>
    let cableCar = Namespaced_IRI.parse _namespace_name "cableCar" |> NamespacedName
    /// <summary>
    /// A call sign is not the name of a broadcaster! In broadcasting and radio communications, a call sign (also known as a call name or call letters, or abbreviated as a call) is a unique designation for a transmitting station.
    /// <see href="http://dbpedia.org/ontology/callSign"></see></summary>
    let callSign = Namespaced_IRI.parse _namespace_name "callSign" |> NamespacedName

    /// <summary>
    /// The out written call sign.
    /// <see href="http://dbpedia.org/ontology/callsignMeaning"></see></summary>
    let callsignMeaning =
        Namespaced_IRI.parse _namespace_name "callsignMeaning" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/campus"></see>
    /// </summary>
    let campus = Namespaced_IRI.parse _namespace_name "campus" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/campusSize"></see>
    /// </summary>
    let campusSize = Namespaced_IRI.parse _namespace_name "campusSize" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/campusType"></see>
    /// </summary>
    let campusType = Namespaced_IRI.parse _namespace_name "campusType" |> NamespacedName

    /// <summary>
    /// Whether bags can be checked.
    /// <see href="http://dbpedia.org/ontology/canBaggageChecked"></see></summary>
    let canBaggageChecked =
        Namespaced_IRI.parse _namespace_name "canBaggageChecked" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cannonNumber"></see>
    /// </summary>
    let cannonNumber =
        Namespaced_IRI.parse _namespace_name "cannonNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/canonizedBy"></see>
    /// </summary>
    let canonizedBy =
        Namespaced_IRI.parse _namespace_name "canonizedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/canonizedDate"></see>
    /// </summary>
    let canonizedDate =
        Namespaced_IRI.parse _namespace_name "canonizedDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/canonizedPlace"></see>
    /// </summary>
    let canonizedPlace =
        Namespaced_IRI.parse _namespace_name "canonizedPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/canton"></see>
    /// </summary>
    let canton = Namespaced_IRI.parse _namespace_name "canton" |> NamespacedName
    /// <summary>
    /// Number of people who can be served by a Train or other service; or participate in a SoccerClub, CricketTeam, etc
    /// <see href="http://dbpedia.org/ontology/capacity"></see></summary>
    let capacity = Namespaced_IRI.parse _namespace_name "capacity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capacityFactor"></see>
    /// </summary>
    let capacityFactor =
        Namespaced_IRI.parse _namespace_name "capacityFactor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capital"></see>
    /// </summary>
    let capital = Namespaced_IRI.parse _namespace_name "capital" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalCoordinates"></see>
    /// </summary>
    let capitalCoordinates =
        Namespaced_IRI.parse _namespace_name "capitalCoordinates" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalCountry"></see>
    /// </summary>
    let capitalCountry =
        Namespaced_IRI.parse _namespace_name "capitalCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalDistrict"></see>
    /// </summary>
    let capitalDistrict =
        Namespaced_IRI.parse _namespace_name "capitalDistrict" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalElevation"></see>
    /// </summary>
    let capitalElevation =
        Namespaced_IRI.parse _namespace_name "capitalElevation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalMountain"></see>
    /// </summary>
    let capitalMountain =
        Namespaced_IRI.parse _namespace_name "capitalMountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalPlace"></see>
    /// </summary>
    let capitalPlace =
        Namespaced_IRI.parse _namespace_name "capitalPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalPosition"></see>
    /// </summary>
    let capitalPosition =
        Namespaced_IRI.parse _namespace_name "capitalPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/capitalRegion"></see>
    /// </summary>
    let capitalRegion =
        Namespaced_IRI.parse _namespace_name "capitalRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/captureDate"></see>
    /// </summary>
    let captureDate =
        Namespaced_IRI.parse _namespace_name "captureDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/carNumber"></see>
    /// </summary>
    let carNumber = Namespaced_IRI.parse _namespace_name "carNumber" |> NamespacedName

    /// <summary>
    /// Amount of carbohydrates per servingSize of a Food
    /// <see href="http://dbpedia.org/ontology/carbohydrate"></see></summary>
    let carbohydrate =
        Namespaced_IRI.parse _namespace_name "carbohydrate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/carcinogen"></see>
    /// </summary>
    let carcinogen = Namespaced_IRI.parse _namespace_name "carcinogen" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/careerPoints"></see>
    /// </summary>
    let careerPoints =
        Namespaced_IRI.parse _namespace_name "careerPoints" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/careerPrizeMoney"></see>
    /// </summary>
    let careerPrizeMoney =
        Namespaced_IRI.parse _namespace_name "careerPrizeMoney" |> NamespacedName

    /// <summary>
    /// this property links to a step in the career of a person, e.g. a soccer player, holding information on the time span, matches and goals he or she achieved at a club.
    /// <see href="http://dbpedia.org/ontology/careerStation"></see></summary>
    let careerStation =
        Namespaced_IRI.parse _namespace_name "careerStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cargoFuel"></see>
    /// </summary>
    let cargoFuel = Namespaced_IRI.parse _namespace_name "cargoFuel" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cargoGas"></see>
    /// </summary>
    let cargoGas = Namespaced_IRI.parse _namespace_name "cargoGas" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cargoWater"></see>
    /// </summary>
    let cargoWater = Namespaced_IRI.parse _namespace_name "cargoWater" |> NamespacedName
    /// <summary>
    /// Chemical Abstracts Service number. Applicable to ChemicalCompound or Biomolecule (eg Protein)
    /// <see href="http://dbpedia.org/ontology/casNumber"></see></summary>
    let casNumber = Namespaced_IRI.parse _namespace_name "casNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/casSupplemental"></see>
    /// </summary>
    let casSupplemental =
        Namespaced_IRI.parse _namespace_name "casSupplemental" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/case"></see>
    /// </summary>
    let case = Namespaced_IRI.parse _namespace_name "case" |> NamespacedName
    /// <summary>
    /// Number of casualties of a MilitaryConflict or natural disaster such as an Earthquake
    /// <see href="http://dbpedia.org/ontology/casualties"></see></summary>
    let casualties = Namespaced_IRI.parse _namespace_name "casualties" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryConflict_,_NaturalEvent"></see>
    /// </summary>
    let ``MilitaryConflict_,_NaturalEvent`` =
        Namespaced_IRI.parse _namespace_name "MilitaryConflict_,_NaturalEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/catch"></see>
    /// </summary>
    let catch = Namespaced_IRI.parse _namespace_name "catch" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/category"></see>
    /// </summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/caterer"></see>
    /// </summary>
    let caterer = Namespaced_IRI.parse _namespace_name "caterer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/catholicPercentage"></see>
    /// </summary>
    let catholicPercentage =
        Namespaced_IRI.parse _namespace_name "catholicPercentage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/causalties"></see>
    /// </summary>
    let causalties = Namespaced_IRI.parse _namespace_name "causalties" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/causeOfDeath"></see>
    /// </summary>
    let causeOfDeath =
        Namespaced_IRI.parse _namespace_name "causeOfDeath" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/causedBy"></see>
    /// </summary>
    let causedBy = Namespaced_IRI.parse _namespace_name "causedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ccaState"></see>
    /// </summary>
    let ccaState = Namespaced_IRI.parse _namespace_name "ccaState" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ceeb"></see>
    /// </summary>
    let ceeb = Namespaced_IRI.parse _namespace_name "ceeb" |> NamespacedName
    /// <summary>
    /// Maximum distance to the earth surface, to be expressed in kilometers
    /// <see href="http://dbpedia.org/ontology/ceiling"></see></summary>
    let ceiling = Namespaced_IRI.parse _namespace_name "ceiling" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cemetery"></see>
    /// </summary>
    let cemetery = Namespaced_IRI.parse _namespace_name "cemetery" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/censusYear"></see>
    /// </summary>
    let censusYear = Namespaced_IRI.parse _namespace_name "censusYear" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/center"></see>
    /// </summary>
    let center = Namespaced_IRI.parse _namespace_name "center" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/NorwaySettlement"></see>
    /// </summary>
    let NorwaySettlement =
        Namespaced_IRI.parse _namespace_name "NorwaySettlement" |> NamespacedName

    /// <summary>
    /// number of breaks with 100 points and more
    /// <see href="http://dbpedia.org/ontology/centuryBreaks"></see></summary>
    let centuryBreaks =
        Namespaced_IRI.parse _namespace_name "centuryBreaks" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ceo"></see>
    /// </summary>
    let ceo = Namespaced_IRI.parse _namespace_name "ceo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ceremonialCounty"></see>
    /// </summary>
    let ceremonialCounty =
        Namespaced_IRI.parse _namespace_name "ceremonialCounty" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/certification"></see>
    /// </summary>
    let certification =
        Namespaced_IRI.parse _namespace_name "certification" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/certificationDate"></see>
    /// </summary>
    let certificationDate =
        Namespaced_IRI.parse _namespace_name "certificationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cesarAward"></see>
    /// </summary>
    let cesarAward = Namespaced_IRI.parse _namespace_name "cesarAward" |> NamespacedName
    /// <summary>
    /// A unique identifier for the drug in the Chemical Entities of Biological Interest (ChEBI) ontology
    /// <see href="http://dbpedia.org/ontology/chEBI"></see></summary>
    let chEBI = Namespaced_IRI.parse _namespace_name "chEBI" |> NamespacedName
    /// <summary>
    /// The chain of Hotels this instance is associated with.
    /// <see href="http://dbpedia.org/ontology/chain"></see></summary>
    let chain = Namespaced_IRI.parse _namespace_name "chain" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chairLabel"></see>
    /// </summary>
    let chairLabel = Namespaced_IRI.parse _namespace_name "chairLabel" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chairman"></see>
    /// </summary>
    let chairman = Namespaced_IRI.parse _namespace_name "chairman" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chairmanTitle"></see>
    /// </summary>
    let chairmanTitle =
        Namespaced_IRI.parse _namespace_name "chairmanTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chairperson"></see>
    /// </summary>
    let chairperson =
        Namespaced_IRI.parse _namespace_name "chairperson" |> NamespacedName

    /// <summary>
    /// winner of a competition
    /// <see href="http://dbpedia.org/ontology/champion"></see></summary>
    let champion = Namespaced_IRI.parse _namespace_name "champion" |> NamespacedName

    /// <summary>
    /// winner of a competition in the double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInDouble"></see></summary>
    let championInDouble =
        Namespaced_IRI.parse _namespace_name "championInDouble" |> NamespacedName

    /// <summary>
    /// winner of a competition in the female double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInDoubleFemale"></see></summary>
    let championInDoubleFemale =
        Namespaced_IRI.parse _namespace_name "championInDoubleFemale" |> NamespacedName

    /// <summary>
    /// winner of a competition in the male double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInDoubleMale"></see></summary>
    let championInDoubleMale =
        Namespaced_IRI.parse _namespace_name "championInDoubleMale" |> NamespacedName

    /// <summary>
    /// winner of a competition in the mixed double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInMixedDouble"></see></summary>
    let championInMixedDouble =
        Namespaced_IRI.parse _namespace_name "championInMixedDouble" |> NamespacedName

    /// <summary>
    /// winner of a competition in the single session, to distinguish from the double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInSingle"></see></summary>
    let championInSingle =
        Namespaced_IRI.parse _namespace_name "championInSingle" |> NamespacedName

    /// <summary>
    /// winner of a competition in the single female session, to distinguish from the double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInSingleFemale"></see></summary>
    let championInSingleFemale =
        Namespaced_IRI.parse _namespace_name "championInSingleFemale" |> NamespacedName

    /// <summary>
    /// winner of a competition in the single male session, to distinguish from the double session (as in tennis)
    /// <see href="http://dbpedia.org/ontology/championInSingleMale"></see></summary>
    let championInSingleMale =
        Namespaced_IRI.parse _namespace_name "championInSingleMale" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/championships"></see>
    /// </summary>
    let championships =
        Namespaced_IRI.parse _namespace_name "championships" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chancellor"></see>
    /// </summary>
    let chancellor = Namespaced_IRI.parse _namespace_name "chancellor" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/channel"></see>
    /// </summary>
    let channel = Namespaced_IRI.parse _namespace_name "channel" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chaplain"></see>
    /// </summary>
    let chaplain = Namespaced_IRI.parse _namespace_name "chaplain" |> NamespacedName

    /// <summary>
    /// Name of a character in play.
    /// <see href="http://dbpedia.org/ontology/characterInPlay"></see></summary>
    let characterInPlay =
        Namespaced_IRI.parse _namespace_name "characterInPlay" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chef"></see>
    /// </summary>
    let chef = Namespaced_IRI.parse _namespace_name "chef" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chiefEditor"></see>
    /// </summary>
    let chiefEditor =
        Namespaced_IRI.parse _namespace_name "chiefEditor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chiefPlace"></see>
    /// </summary>
    let chiefPlace = Namespaced_IRI.parse _namespace_name "chiefPlace" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/child"></see>
    /// </summary>
    let child = Namespaced_IRI.parse _namespace_name "child" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/childOrganisation"></see>
    /// </summary>
    let childOrganisation =
        Namespaced_IRI.parse _namespace_name "childOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/choreographer"></see>
    /// </summary>
    let choreographer =
        Namespaced_IRI.parse _namespace_name "choreographer" |> NamespacedName

    /// <summary>
    /// The name of the (Greek) chorus character in play.
    /// <see href="http://dbpedia.org/ontology/chorusCharacterInPlay"></see></summary>
    let chorusCharacterInPlay =
        Namespaced_IRI.parse _namespace_name "chorusCharacterInPlay" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/christeningDate"></see>
    /// </summary>
    let christeningDate =
        Namespaced_IRI.parse _namespace_name "christeningDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/chromosome"></see>
    /// </summary>
    let chromosome = Namespaced_IRI.parse _namespace_name "chromosome" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cinematography"></see>
    /// </summary>
    let cinematography =
        Namespaced_IRI.parse _namespace_name "cinematography" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/circle"></see>
    /// </summary>
    let circle = Namespaced_IRI.parse _namespace_name "circle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/circuitLength"></see>
    /// </summary>
    let circuitLength =
        Namespaced_IRI.parse _namespace_name "circuitLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/circuitName"></see>
    /// </summary>
    let circuitName =
        Namespaced_IRI.parse _namespace_name "circuitName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/circulation"></see>
    /// </summary>
    let circulation =
        Namespaced_IRI.parse _namespace_name "circulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/circumcised"></see>
    /// </summary>
    let circumcised =
        Namespaced_IRI.parse _namespace_name "circumcised" |> NamespacedName

    /// <summary>
    /// A document cited by this work. Like OntologyProperty:dct:references, but as a datatype property.
    /// <see href="http://dbpedia.org/ontology/cites"></see></summary>
    let cites = Namespaced_IRI.parse _namespace_name "cites" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/citizenship"></see>
    /// </summary>
    let citizenship =
        Namespaced_IRI.parse _namespace_name "citizenship" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/city"></see>
    /// </summary>
    let city = Namespaced_IRI.parse _namespace_name "city" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cityLink"></see>
    /// </summary>
    let cityLink = Namespaced_IRI.parse _namespace_name "cityLink" |> NamespacedName
    /// <summary>
    /// Place of the building in the list of the highest buildings in the city
    /// <see href="http://dbpedia.org/ontology/cityRank"></see></summary>
    let cityRank = Namespaced_IRI.parse _namespace_name "cityRank" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/citySince"></see>
    /// </summary>
    let citySince = Namespaced_IRI.parse _namespace_name "citySince" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cityType"></see>
    /// </summary>
    let cityType = Namespaced_IRI.parse _namespace_name "cityType" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/class"></see>
    /// </summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/classes"></see>
    /// </summary>
    let classes = Namespaced_IRI.parse _namespace_name "classes" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/classification"></see>
    /// </summary>
    let classification =
        Namespaced_IRI.parse _namespace_name "classification" |> NamespacedName

    /// <summary>
    /// the living thing class (from the Latin "classis"), according to the biological taxonomy
    /// <see href="http://dbpedia.org/ontology/classis"></see></summary>
    let classis = Namespaced_IRI.parse _namespace_name "classis" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/climate"></see>
    /// </summary>
    let climate = Namespaced_IRI.parse _namespace_name "climate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/climbUpNumber"></see>
    /// </summary>
    let climbUpNumber =
        Namespaced_IRI.parse _namespace_name "climbUpNumber" |> NamespacedName

    /// <summary>
    /// place close to another place
    /// <see href="http://dbpedia.org/ontology/closeTo"></see></summary>
    let closeTo = Namespaced_IRI.parse _namespace_name "closeTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/closed"></see>
    /// </summary>
    let closed = Namespaced_IRI.parse _namespace_name "closed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/closingDate"></see>
    /// </summary>
    let closingDate =
        Namespaced_IRI.parse _namespace_name "closingDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/closingFilm"></see>
    /// </summary>
    let closingFilm =
        Namespaced_IRI.parse _namespace_name "closingFilm" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/closingYear"></see>
    /// </summary>
    let closingYear =
        Namespaced_IRI.parse _namespace_name "closingYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/clothSize"></see>
    /// </summary>
    let clothSize = Namespaced_IRI.parse _namespace_name "clothSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/clothingSize"></see>
    /// </summary>
    let clothingSize =
        Namespaced_IRI.parse _namespace_name "clothingSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/club"></see>
    /// </summary>
    let club = Namespaced_IRI.parse _namespace_name "club" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/team"></see>
    /// </summary>
    let team = Namespaced_IRI.parse _namespace_name "team" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/clubsRecordGoalscorer"></see>
    /// </summary>
    let clubsRecordGoalscorer =
        Namespaced_IRI.parse _namespace_name "clubsRecordGoalscorer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cluster"></see>
    /// </summary>
    let cluster = Namespaced_IRI.parse _namespace_name "cluster" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cmpEvaDuration"></see>
    /// </summary>
    let cmpEvaDuration =
        Namespaced_IRI.parse _namespace_name "cmpEvaDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cmykCoordinateBlack"></see>
    /// </summary>
    let cmykCoordinateBlack =
        Namespaced_IRI.parse _namespace_name "cmykCoordinateBlack" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cmykCoordinateCyanic"></see>
    /// </summary>
    let cmykCoordinateCyanic =
        Namespaced_IRI.parse _namespace_name "cmykCoordinateCyanic" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cmykCoordinateMagenta"></see>
    /// </summary>
    let cmykCoordinateMagenta =
        Namespaced_IRI.parse _namespace_name "cmykCoordinateMagenta" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cmykCoordinateYellow"></see>
    /// </summary>
    let cmykCoordinateYellow =
        Namespaced_IRI.parse _namespace_name "cmykCoordinateYellow" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/co2Emission"></see>
    /// </summary>
    let co2Emission =
        Namespaced_IRI.parse _namespace_name "co2Emission" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coExecutiveProducer"></see>
    /// </summary>
    let coExecutiveProducer =
        Namespaced_IRI.parse _namespace_name "coExecutiveProducer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coProducer"></see>
    /// </summary>
    let coProducer = Namespaced_IRI.parse _namespace_name "coProducer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coach"></see>
    /// </summary>
    let coach = Namespaced_IRI.parse _namespace_name "coach" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coachClub"></see>
    /// </summary>
    let coachClub = Namespaced_IRI.parse _namespace_name "coachClub" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coachSeason"></see>
    /// </summary>
    let coachSeason =
        Namespaced_IRI.parse _namespace_name "coachSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coachedTeam"></see>
    /// </summary>
    let coachedTeam =
        Namespaced_IRI.parse _namespace_name "coachedTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coachingRecord"></see>
    /// </summary>
    let coachingRecord =
        Namespaced_IRI.parse _namespace_name "coachingRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coalition"></see>
    /// </summary>
    let coalition = Namespaced_IRI.parse _namespace_name "coalition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coastLength"></see>
    /// </summary>
    let coastLength =
        Namespaced_IRI.parse _namespace_name "coastLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coastLine"></see>
    /// </summary>
    let coastLine = Namespaced_IRI.parse _namespace_name "coastLine" |> NamespacedName
    /// <summary>
    /// image of the coat of arms (heraldic symbol)
    /// <see href="http://dbpedia.org/ontology/coatOfArms"></see></summary>
    let coatOfArms = Namespaced_IRI.parse _namespace_name "coatOfArms" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/code"></see>
    /// </summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName
    /// <summary>
    /// code book or statute book referred to in this legal case
    /// <see href="http://dbpedia.org/ontology/codeBook"></see></summary>
    let codeBook = Namespaced_IRI.parse _namespace_name "codeBook" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/codeDistrict"></see>
    /// </summary>
    let codeDistrict =
        Namespaced_IRI.parse _namespace_name "codeDistrict" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/codeIndex"></see>
    /// </summary>
    let codeIndex = Namespaced_IRI.parse _namespace_name "codeIndex" |> NamespacedName

    /// <summary>
    /// Land Registry code designating a parcel of land
    /// <see href="http://dbpedia.org/ontology/codeLandRegistry"></see></summary>
    let codeLandRegistry =
        Namespaced_IRI.parse _namespace_name "codeLandRegistry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Code"></see>
    /// </summary>
    let Code = Namespaced_IRI.parse _namespace_name "Code" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/codeListOfHonour"></see>
    /// </summary>
    let codeListOfHonour =
        Namespaced_IRI.parse _namespace_name "codeListOfHonour" |> NamespacedName

    /// <summary>
    /// Identifier for monuments of the Memorial type
    /// <see href="http://dbpedia.org/ontology/codeMemorial"></see></summary>
    let codeMemorial =
        Namespaced_IRI.parse _namespace_name "codeMemorial" |> NamespacedName

    /// <summary>
    /// Code assigned to (Dutch) monuments at the municipal level, deemed to be of local value
    /// <see href="http://dbpedia.org/ontology/codeMunicipalMonument"></see></summary>
    let codeMunicipalMonument =
        Namespaced_IRI.parse _namespace_name "codeMunicipalMonument" |> NamespacedName

    /// <summary>
    /// Code assigned to (Dutch) monuments at the national level, deemed to be of national value
    /// <see href="http://dbpedia.org/ontology/codeNationalMonument"></see></summary>
    let codeNationalMonument =
        Namespaced_IRI.parse _namespace_name "codeNationalMonument" |> NamespacedName

    /// <summary>
    /// Code assigned to (Dutch) monuments at the provincial level, mostly for monuments in the countryside, or for waterworks
    /// <see href="http://dbpedia.org/ontology/codeProvincialMonument"></see></summary>
    let codeProvincialMonument =
        Namespaced_IRI.parse _namespace_name "codeProvincialMonument" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/codeSettlement"></see>
    /// </summary>
    let codeSettlement =
        Namespaced_IRI.parse _namespace_name "codeSettlement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/codeStockExchange"></see>
    /// </summary>
    let codeStockExchange =
        Namespaced_IRI.parse _namespace_name "codeStockExchange" |> NamespacedName

    /// <summary>
    /// CODEN is a six character, alphanumeric bibliographic code, that provides concise, unique and unambiguous identification of the titles of serials and non-serial publications from all subject areas.
    /// <see href="http://dbpedia.org/ontology/coden"></see></summary>
    let coden = Namespaced_IRI.parse _namespace_name "coden" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coemperor"></see>
    /// </summary>
    let coemperor = Namespaced_IRI.parse _namespace_name "coemperor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/collaboration"></see>
    /// </summary>
    let collaboration =
        Namespaced_IRI.parse _namespace_name "collaboration" |> NamespacedName

    /// <summary>
    /// Colleague of a Person or OfficeHolder (not PersonFunction nor CareerStation). Sub-properties include: president, vicePresident, chancellor, viceChancellor, governor, lieutenant. Points to a Person who may have a general "position" (resource) or "title" (literal).
    /// <see href="http://dbpedia.org/ontology/colleague"></see></summary>
    let colleague = Namespaced_IRI.parse _namespace_name "colleague" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/collection"></see>
    /// </summary>
    let collection = Namespaced_IRI.parse _namespace_name "collection" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/collectionSize"></see>
    /// </summary>
    let collectionSize =
        Namespaced_IRI.parse _namespace_name "collectionSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/collectivityMinority"></see>
    /// </summary>
    let collectivityMinority =
        Namespaced_IRI.parse _namespace_name "collectivityMinority" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/college"></see>
    /// </summary>
    let college = Namespaced_IRI.parse _namespace_name "college" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/collegeHof"></see>
    /// </summary>
    let collegeHof = Namespaced_IRI.parse _namespace_name "collegeHof" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/colonialName"></see>
    /// </summary>
    let colonialName =
        Namespaced_IRI.parse _namespace_name "colonialName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/colorChart"></see>
    /// </summary>
    let colorChart = Namespaced_IRI.parse _namespace_name "colorChart" |> NamespacedName
    /// <summary>
    /// A colour represented by its entity.
    /// <see href="http://dbpedia.org/ontology/colour"></see></summary>
    let colour = Namespaced_IRI.parse _namespace_name "colour" |> NamespacedName
    /// <summary>
    /// A colour represented by a string holding its name (e.g.: red or green).
    /// <see href="http://dbpedia.org/ontology/colourName"></see></summary>
    let colourName = Namespaced_IRI.parse _namespace_name "colourName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/combatant"></see>
    /// </summary>
    let combatant = Namespaced_IRI.parse _namespace_name "combatant" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/comic"></see>
    /// </summary>
    let comic = Namespaced_IRI.parse _namespace_name "comic" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/comitat"></see>
    /// </summary>
    let comitat = Namespaced_IRI.parse _namespace_name "comitat" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/HungarySettlement"></see>
    /// </summary>
    let HungarySettlement =
        Namespaced_IRI.parse _namespace_name "HungarySettlement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/command"></see>
    /// </summary>
    let command = Namespaced_IRI.parse _namespace_name "command" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commandModule"></see>
    /// </summary>
    let commandModule =
        Namespaced_IRI.parse _namespace_name "commandModule" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commandStructure"></see>
    /// </summary>
    let commandStructure =
        Namespaced_IRI.parse _namespace_name "commandStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commandant"></see>
    /// </summary>
    let commandant = Namespaced_IRI.parse _namespace_name "commandant" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/keyPerson"></see>
    /// </summary>
    let keyPerson = Namespaced_IRI.parse _namespace_name "keyPerson" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commander"></see>
    /// </summary>
    let commander = Namespaced_IRI.parse _namespace_name "commander" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/comment"></see>
    /// </summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commissioner"></see>
    /// </summary>
    let commissioner =
        Namespaced_IRI.parse _namespace_name "commissioner" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commissionerDate"></see>
    /// </summary>
    let commissionerDate =
        Namespaced_IRI.parse _namespace_name "commissionerDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commissioningDate"></see>
    /// </summary>
    let commissioningDate =
        Namespaced_IRI.parse _namespace_name "commissioningDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/committee"></see>
    /// </summary>
    let committee = Namespaced_IRI.parse _namespace_name "committee" |> NamespacedName

    /// <summary>
    /// Committee in the legislature (eg.: Committee on Economic and Monetary Affairs of the European Parliament).
    /// <see href="http://dbpedia.org/ontology/committeeInLegislature"></see></summary>
    let committeeInLegislature =
        Namespaced_IRI.parse _namespace_name "committeeInLegislature" |> NamespacedName

    /// <summary>
    /// The common name of an entity. Frequently, foaf:name is used for all of the different names of a person; this property just defines the most commonly used name.
    /// <see href="http://dbpedia.org/ontology/commonName"></see></summary>
    let commonName = Namespaced_IRI.parse _namespace_name "commonName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/commune"></see>
    /// </summary>
    let commune = Namespaced_IRI.parse _namespace_name "commune" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/communityIsoCode"></see>
    /// </summary>
    let communityIsoCode =
        Namespaced_IRI.parse _namespace_name "communityIsoCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isoCode"></see>
    /// </summary>
    let isoCode = Namespaced_IRI.parse _namespace_name "isoCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/company"></see>
    /// </summary>
    let company = Namespaced_IRI.parse _namespace_name "company" |> NamespacedName
    /// <summary>
    /// similar, unrelated rockets
    /// <see href="http://dbpedia.org/ontology/comparable"></see></summary>
    let comparable = Namespaced_IRI.parse _namespace_name "comparable" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/competition"></see>
    /// </summary>
    let competition =
        Namespaced_IRI.parse _namespace_name "competition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/competitionTitle"></see>
    /// </summary>
    let competitionTitle =
        Namespaced_IRI.parse _namespace_name "competitionTitle" |> NamespacedName

    /// <summary>
    /// For compilation albums: the person or entity responsible for selecting the album's track listing.
    /// <see href="http://dbpedia.org/ontology/compiler"></see></summary>
    let compiler = Namespaced_IRI.parse _namespace_name "compiler" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/completionDate"></see>
    /// </summary>
    let completionDate =
        Namespaced_IRI.parse _namespace_name "completionDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/complexion"></see>
    /// </summary>
    let complexion = Namespaced_IRI.parse _namespace_name "complexion" |> NamespacedName
    /// <summary>
    /// Complexity of preparing a Food (recipe)
    /// <see href="http://dbpedia.org/ontology/complexity"></see></summary>
    let complexity = Namespaced_IRI.parse _namespace_name "complexity" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/component"></see>
    /// </summary>
    let component_ = Namespaced_IRI.parse _namespace_name "component" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/composer"></see>
    /// </summary>
    let composer = Namespaced_IRI.parse _namespace_name "composer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/compressionRatio"></see>
    /// </summary>
    let compressionRatio =
        Namespaced_IRI.parse _namespace_name "compressionRatio" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/computingInput"></see>
    /// </summary>
    let computingInput =
        Namespaced_IRI.parse _namespace_name "computingInput" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/computingMedia"></see>
    /// </summary>
    let computingMedia =
        Namespaced_IRI.parse _namespace_name "computingMedia" |> NamespacedName

    /// <summary>
    /// some sort of hardware architecture or software framework, that allows this software to run
    /// <see href="http://dbpedia.org/ontology/computingPlatform"></see></summary>
    let computingPlatform =
        Namespaced_IRI.parse _namespace_name "computingPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/configuration"></see>
    /// </summary>
    let configuration =
        Namespaced_IRI.parse _namespace_name "configuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/conflict"></see>
    /// </summary>
    let conflict = Namespaced_IRI.parse _namespace_name "conflict" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/congressionalDistrict"></see>
    /// </summary>
    let congressionalDistrict =
        Namespaced_IRI.parse _namespace_name "congressionalDistrict" |> NamespacedName

    /// <summary>
    /// connects a referenced resource to another resource. This property is important to connect non-extracted resources to extracted ones
    /// <see href="http://dbpedia.org/ontology/connectsReferencedTo"></see></summary>
    let connectsReferencedTo =
        Namespaced_IRI.parse _namespace_name "connectsReferencedTo" |> NamespacedName

    /// <summary>
    /// A meaning of a word or phrase that is suggested or implied, as opposed to a denotation, or literal meaning.
    /// <see href="http://dbpedia.org/ontology/connotation"></see></summary>
    let connotation =
        Namespaced_IRI.parse _namespace_name "connotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/consecration"></see>
    /// </summary>
    let consecration =
        Namespaced_IRI.parse _namespace_name "consecration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/conservationStatus"></see>
    /// </summary>
    let conservationStatus =
        Namespaced_IRI.parse _namespace_name "conservationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/conservationStatusSystem"></see>
    /// </summary>
    let conservationStatusSystem =
        Namespaced_IRI.parse _namespace_name "conservationStatusSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/constellation"></see>
    /// </summary>
    let constellation =
        Namespaced_IRI.parse _namespace_name "constellation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/construction"></see>
    /// </summary>
    let construction =
        Namespaced_IRI.parse _namespace_name "construction" |> NamespacedName

    /// <summary>
    /// Construction material (eg. concrete, steel, iron, stone, brick, wood).
    /// <see href="http://dbpedia.org/ontology/constructionMaterial"></see></summary>
    let constructionMaterial =
        Namespaced_IRI.parse _namespace_name "constructionMaterial" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/contest"></see>
    /// </summary>
    let contest = Namespaced_IRI.parse _namespace_name "contest" |> NamespacedName
    /// <summary>
    /// links a country to the continent it belongs
    /// <see href="http://dbpedia.org/ontology/continent"></see></summary>
    let continent = Namespaced_IRI.parse _namespace_name "continent" |> NamespacedName

    /// <summary>
    /// Place of the building in the list of the highest buildings in the continent
    /// <see href="http://dbpedia.org/ontology/continentRank"></see></summary>
    let continentRank =
        Namespaced_IRI.parse _namespace_name "continentRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/continentalTournament"></see>
    /// </summary>
    let continentalTournament =
        Namespaced_IRI.parse _namespace_name "continentalTournament" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/continentalTournamentBronze"></see>
    /// </summary>
    let continentalTournamentBronze =
        Namespaced_IRI.parse _namespace_name "continentalTournamentBronze" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/continentalTournamentGold"></see>
    /// </summary>
    let continentalTournamentGold =
        Namespaced_IRI.parse _namespace_name "continentalTournamentGold" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/continentalTournamentSilver"></see>
    /// </summary>
    let continentalTournamentSilver =
        Namespaced_IRI.parse _namespace_name "continentalTournamentSilver" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/contractAward"></see>
    /// </summary>
    let contractAward =
        Namespaced_IRI.parse _namespace_name "contractAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/contractor"></see>
    /// </summary>
    let contractor = Namespaced_IRI.parse _namespace_name "contractor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/convictionDate"></see>
    /// </summary>
    let convictionDate =
        Namespaced_IRI.parse _namespace_name "convictionDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coolingSystem"></see>
    /// </summary>
    let coolingSystem =
        Namespaced_IRI.parse _namespace_name "coolingSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/copilote"></see>
    /// </summary>
    let copilote = Namespaced_IRI.parse _namespace_name "copilote" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/coronationDate"></see>
    /// </summary>
    let coronationDate =
        Namespaced_IRI.parse _namespace_name "coronationDate" |> NamespacedName

    /// <summary>
    /// Described at http://en.wikipedia.org/wiki/International_Designator
    /// <see href="http://dbpedia.org/ontology/cosparId"></see></summary>
    let cosparId = Namespaced_IRI.parse _namespace_name "cosparId" |> NamespacedName
    /// <summary>
    /// Cost of building an ArchitecturalStructure, Ship, etc
    /// <see href="http://dbpedia.org/ontology/cost"></see></summary>
    let cost = Namespaced_IRI.parse _namespace_name "cost" |> NamespacedName

    /// <summary>
    /// the person who is responsible for the film costume design
    /// <see href="http://dbpedia.org/ontology/costumeDesigner"></see></summary>
    let costumeDesigner =
        Namespaced_IRI.parse _namespace_name "costumeDesigner" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/council"></see>
    /// </summary>
    let council = Namespaced_IRI.parse _namespace_name "council" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LiechtensteinSettlement"></see>
    /// </summary>
    let LiechtensteinSettlement =
        Namespaced_IRI.parse _namespace_name "LiechtensteinSettlement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/councilArea"></see>
    /// </summary>
    let councilArea =
        Namespaced_IRI.parse _namespace_name "councilArea" |> NamespacedName

    /// <summary>
    /// The country where the thing is located.
    /// <see href="http://dbpedia.org/ontology/country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/countryOrigin"></see>
    /// </summary>
    let countryOrigin =
        Namespaced_IRI.parse _namespace_name "countryOrigin" |> NamespacedName

    /// <summary>
    /// Place of the building in the list of the highest buildings in the country
    /// <see href="http://dbpedia.org/ontology/countryRank"></see></summary>
    let countryRank =
        Namespaced_IRI.parse _namespace_name "countryRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/countryWithFirstAstronaut"></see>
    /// </summary>
    let countryWithFirstAstronaut =
        Namespaced_IRI.parse _namespace_name "countryWithFirstAstronaut" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/countryWithFirstSatellite"></see>
    /// </summary>
    let countryWithFirstSatellite =
        Namespaced_IRI.parse _namespace_name "countryWithFirstSatellite" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/countryWithFirstSatelliteLaunched"></see>
    /// </summary>
    let countryWithFirstSatelliteLaunched =
        Namespaced_IRI.parse _namespace_name "countryWithFirstSatelliteLaunched" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/countryWithFirstSpaceflight"></see>
    /// </summary>
    let countryWithFirstSpaceflight =
        Namespaced_IRI.parse _namespace_name "countryWithFirstSpaceflight" |> NamespacedName

    /// <summary>
    /// The county where the thing is located.
    /// <see href="http://dbpedia.org/ontology/county"></see></summary>
    let county = Namespaced_IRI.parse _namespace_name "county" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/countySeat"></see>
    /// </summary>
    let countySeat = Namespaced_IRI.parse _namespace_name "countySeat" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/course"></see>
    /// </summary>
    let course = Namespaced_IRI.parse _namespace_name "course" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cousurper"></see>
    /// </summary>
    let cousurper = Namespaced_IRI.parse _namespace_name "cousurper" |> NamespacedName

    /// <summary>
    /// Cover artist
    /// <see href="http://dbpedia.org/ontology/coverArtist"></see></summary>
    let coverArtist =
        Namespaced_IRI.parse _namespace_name "coverArtist" |> NamespacedName

    /// <summary>
    /// CPU of an InformationAppliance or VideoGame (which unfortunately is currently under Software)
    /// <see href="http://dbpedia.org/ontology/cpu"></see></summary>
    let cpu = Namespaced_IRI.parse _namespace_name "cpu" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/created"></see>
    /// </summary>
    let created = Namespaced_IRI.parse _namespace_name "created" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/creationChristianBishop"></see>
    /// </summary>
    let creationChristianBishop =
        Namespaced_IRI.parse _namespace_name "creationChristianBishop" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Bishop"></see>
    /// </summary>
    let Bishop = Namespaced_IRI.parse _namespace_name "Bishop" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/creationYear"></see>
    /// </summary>
    let creationYear =
        Namespaced_IRI.parse _namespace_name "creationYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/creativeDirector"></see>
    /// </summary>
    let creativeDirector =
        Namespaced_IRI.parse _namespace_name "creativeDirector" |> NamespacedName

    /// <summary>
    /// Creator/author of a work. For literal (string) use dc:creator; for object (URL) use creator
    /// <see href="http://dbpedia.org/ontology/creator"></see></summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName

    /// <summary>
    /// The person that creates (invents) the food (eg. Caesar Cardini is the creator of the Caesar salad).
    /// <see href="http://dbpedia.org/ontology/creatorOfDish"></see></summary>
    let creatorOfDish =
        Namespaced_IRI.parse _namespace_name "creatorOfDish" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/credit"></see>
    /// </summary>
    let credit = Namespaced_IRI.parse _namespace_name "credit" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crest"></see>
    /// </summary>
    let crest = Namespaced_IRI.parse _namespace_name "crest" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crew"></see>
    /// </summary>
    let crew = Namespaced_IRI.parse _namespace_name "crew" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crewMember"></see>
    /// </summary>
    let crewMember = Namespaced_IRI.parse _namespace_name "crewMember" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crewSize"></see>
    /// </summary>
    let crewSize = Namespaced_IRI.parse _namespace_name "crewSize" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crews"></see>
    /// </summary>
    let crews = Namespaced_IRI.parse _namespace_name "crews" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/criteria"></see>
    /// </summary>
    let criteria = Namespaced_IRI.parse _namespace_name "criteria" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crosses"></see>
    /// </summary>
    let crosses = Namespaced_IRI.parse _namespace_name "crosses" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/crownDependency"></see>
    /// </summary>
    let crownDependency =
        Namespaced_IRI.parse _namespace_name "crownDependency" |> NamespacedName

    /// <summary>
    /// National cuisine of a Food or Restaurant
    /// <see href="http://dbpedia.org/ontology/cuisine"></see></summary>
    let cuisine = Namespaced_IRI.parse _namespace_name "cuisine" |> NamespacedName

    /// <summary>
    /// Name of the cultivar (cultivated variety)
    /// <see href="http://dbpedia.org/ontology/cultivatedVariety"></see></summary>
    let cultivatedVariety =
        Namespaced_IRI.parse _namespace_name "cultivatedVariety" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/curator"></see>
    /// </summary>
    let curator = Namespaced_IRI.parse _namespace_name "curator" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currency"></see>
    /// </summary>
    let currency = Namespaced_IRI.parse _namespace_name "currency" |> NamespacedName

    /// <summary>
    /// ISO 4217 currency designators.
    /// <see href="http://dbpedia.org/ontology/currencyCode"></see></summary>
    let currencyCode =
        Namespaced_IRI.parse _namespace_name "currencyCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentCity"></see>
    /// </summary>
    let currentCity =
        Namespaced_IRI.parse _namespace_name "currentCity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentLeague"></see>
    /// </summary>
    let currentLeague =
        Namespaced_IRI.parse _namespace_name "currentLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentMember"></see>
    /// </summary>
    let currentMember =
        Namespaced_IRI.parse _namespace_name "currentMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentPartner"></see>
    /// </summary>
    let currentPartner =
        Namespaced_IRI.parse _namespace_name "currentPartner" |> NamespacedName

    /// <summary>
    /// The current production running in the theatre.
    /// <see href="http://dbpedia.org/ontology/currentProduction"></see></summary>
    let currentProduction =
        Namespaced_IRI.parse _namespace_name "currentProduction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentRank"></see>
    /// </summary>
    let currentRank =
        Namespaced_IRI.parse _namespace_name "currentRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentRecord"></see>
    /// </summary>
    let currentRecord =
        Namespaced_IRI.parse _namespace_name "currentRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentSeason"></see>
    /// </summary>
    let currentSeason =
        Namespaced_IRI.parse _namespace_name "currentSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentStatus"></see>
    /// </summary>
    let currentStatus =
        Namespaced_IRI.parse _namespace_name "currentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentTeam"></see>
    /// </summary>
    let currentTeam =
        Namespaced_IRI.parse _namespace_name "currentTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentTeamManager"></see>
    /// </summary>
    let currentTeamManager =
        Namespaced_IRI.parse _namespace_name "currentTeamManager" |> NamespacedName

    /// <summary>
    /// A current member of an athletic team.
    /// <see href="http://dbpedia.org/ontology/currentTeamMember"></see></summary>
    let currentTeamMember =
        Namespaced_IRI.parse _namespace_name "currentTeamMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/currentWorldChampion"></see>
    /// </summary>
    let currentWorldChampion =
        Namespaced_IRI.parse _namespace_name "currentWorldChampion" |> NamespacedName

    /// <summary>
    /// Current use of the architectural structure, if it is currently being used as anything other than its original purpose.
    /// <see href="http://dbpedia.org/ontology/currentlyUsedFor"></see></summary>
    let currentlyUsedFor =
        Namespaced_IRI.parse _namespace_name "currentlyUsedFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/custodian"></see>
    /// </summary>
    let custodian = Namespaced_IRI.parse _namespace_name "custodian" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cyclistGenre"></see>
    /// </summary>
    let cyclistGenre =
        Namespaced_IRI.parse _namespace_name "cyclistGenre" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cylinderBore"></see>
    /// </summary>
    let cylinderBore =
        Namespaced_IRI.parse _namespace_name "cylinderBore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/cylinderCount"></see>
    /// </summary>
    let cylinderCount =
        Namespaced_IRI.parse _namespace_name "cylinderCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/daira"></see>
    /// </summary>
    let daira = Namespaced_IRI.parse _namespace_name "daira" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dam"></see>
    /// </summary>
    let dam = Namespaced_IRI.parse _namespace_name "dam" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/damage"></see>
    /// </summary>
    let damage = Namespaced_IRI.parse _namespace_name "damage" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/damsire"></see>
    /// </summary>
    let damsire = Namespaced_IRI.parse _namespace_name "damsire" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/danseCompetition"></see>
    /// </summary>
    let danseCompetition =
        Namespaced_IRI.parse _namespace_name "danseCompetition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/danseScore"></see>
    /// </summary>
    let danseScore = Namespaced_IRI.parse _namespace_name "danseScore" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateAct"></see>
    /// </summary>
    let dateAct = Namespaced_IRI.parse _namespace_name "dateAct" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateAgreement"></see>
    /// </summary>
    let dateAgreement =
        Namespaced_IRI.parse _namespace_name "dateAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateBudget"></see>
    /// </summary>
    let dateBudget = Namespaced_IRI.parse _namespace_name "dateBudget" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateClosed"></see>
    /// </summary>
    let dateClosed = Namespaced_IRI.parse _namespace_name "dateClosed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateCompleted"></see>
    /// </summary>
    let dateCompleted =
        Namespaced_IRI.parse _namespace_name "dateCompleted" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateConstruction"></see>
    /// </summary>
    let dateConstruction =
        Namespaced_IRI.parse _namespace_name "dateConstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateExtended"></see>
    /// </summary>
    let dateExtended =
        Namespaced_IRI.parse _namespace_name "dateExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateLastUpdated"></see>
    /// </summary>
    let dateLastUpdated =
        Namespaced_IRI.parse _namespace_name "dateLastUpdated" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateOfAbandonment"></see>
    /// </summary>
    let dateOfAbandonment =
        Namespaced_IRI.parse _namespace_name "dateOfAbandonment" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateOfBurial"></see>
    /// </summary>
    let dateOfBurial =
        Namespaced_IRI.parse _namespace_name "dateOfBurial" |> NamespacedName

    /// <summary>
    /// Designates the unveiling date
    /// <see href="http://dbpedia.org/ontology/dateUnveiled"></see></summary>
    let dateUnveiled =
        Namespaced_IRI.parse _namespace_name "dateUnveiled" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dateUse"></see>
    /// </summary>
    let dateUse = Namespaced_IRI.parse _namespace_name "dateUse" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/davisCup"></see>
    /// </summary>
    let davisCup = Namespaced_IRI.parse _namespace_name "davisCup" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/day"></see>
    /// </summary>
    let day = Namespaced_IRI.parse _namespace_name "day" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/daylightSavingTimeZone"></see>
    /// </summary>
    let daylightSavingTimeZone =
        Namespaced_IRI.parse _namespace_name "daylightSavingTimeZone" |> NamespacedName

    /// <summary>
    /// identifier in Dutch digital library (dbnl)
    /// <see href="http://dbpedia.org/ontology/dbnlCodeDutch"></see></summary>
    let dbnlCodeDutch =
        Namespaced_IRI.parse _namespace_name "dbnlCodeDutch" |> NamespacedName

    /// <summary>
    /// The Dewey Decimal Classification is a proprietary system of library classification developed by Melvil Dewey in 1876.
    /// <see href="http://dbpedia.org/ontology/dcc"></see></summary>
    let dcc = Namespaced_IRI.parse _namespace_name "dcc" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deFactoLanguage"></see>
    /// </summary>
    let deFactoLanguage =
        Namespaced_IRI.parse _namespace_name "deFactoLanguage" |> NamespacedName

    /// <summary>
    /// Use dc:language for literal, language for object
    /// <see href="http://dbpedia.org/ontology/language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deadInFightDate"></see>
    /// </summary>
    let deadInFightDate =
        Namespaced_IRI.parse _namespace_name "deadInFightDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deadInFightPlace"></see>
    /// </summary>
    let deadInFightPlace =
        Namespaced_IRI.parse _namespace_name "deadInFightPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dean"></see>
    /// </summary>
    let dean = Namespaced_IRI.parse _namespace_name "dean" |> NamespacedName
    /// <summary>
    /// Dioceses and parishes should know which deaneries there are
    /// <see href="http://dbpedia.org/ontology/deanery"></see></summary>
    let deanery = Namespaced_IRI.parse _namespace_name "deanery" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Diocese,_Parish"></see>
    /// </summary>
    let ``Diocese,_Parish`` =
        Namespaced_IRI.parse _namespace_name "Diocese,_Parish" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deathAge"></see>
    /// </summary>
    let deathAge = Namespaced_IRI.parse _namespace_name "deathAge" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deathCause"></see>
    /// </summary>
    let deathCause = Namespaced_IRI.parse _namespace_name "deathCause" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deathDate"></see>
    /// </summary>
    let deathDate = Namespaced_IRI.parse _namespace_name "deathDate" |> NamespacedName
    /// <summary>
    /// The place where the person died.
    /// <see href="http://dbpedia.org/ontology/deathPlace"></see></summary>
    let deathPlace = Namespaced_IRI.parse _namespace_name "deathPlace" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deathYear"></see>
    /// </summary>
    let deathYear = Namespaced_IRI.parse _namespace_name "deathYear" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/debut"></see>
    /// </summary>
    let debut = Namespaced_IRI.parse _namespace_name "debut" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/debutTeam"></see>
    /// </summary>
    let debutTeam = Namespaced_IRI.parse _namespace_name "debutTeam" |> NamespacedName
    /// <summary>
    /// First work of a person (may be notableWork or not)
    /// <see href="http://dbpedia.org/ontology/debutWork"></see></summary>
    let debutWork = Namespaced_IRI.parse _namespace_name "debutWork" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dec"></see>
    /// </summary>
    let dec = Namespaced_IRI.parse _namespace_name "dec" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/decay"></see>
    /// </summary>
    let decay = Namespaced_IRI.parse _namespace_name "decay" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/decideDate"></see>
    /// </summary>
    let decideDate = Namespaced_IRI.parse _namespace_name "decideDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/declination"></see>
    /// </summary>
    let declination =
        Namespaced_IRI.parse _namespace_name "declination" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/decommissioningDate"></see>
    /// </summary>
    let decommissioningDate =
        Namespaced_IRI.parse _namespace_name "decommissioningDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/decoration"></see>
    /// </summary>
    let decoration = Namespaced_IRI.parse _namespace_name "decoration" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/defeat"></see>
    /// </summary>
    let defeat = Namespaced_IRI.parse _namespace_name "defeat" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/defeatAsMgr"></see>
    /// </summary>
    let defeatAsMgr =
        Namespaced_IRI.parse _namespace_name "defeatAsMgr" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/definition"></see>
    /// </summary>
    let definition = Namespaced_IRI.parse _namespace_name "definition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/delegateMayor"></see>
    /// </summary>
    let delegateMayor =
        Namespaced_IRI.parse _namespace_name "delegateMayor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/delegation"></see>
    /// </summary>
    let delegation = Namespaced_IRI.parse _namespace_name "delegation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deliveryDate"></see>
    /// </summary>
    let deliveryDate =
        Namespaced_IRI.parse _namespace_name "deliveryDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deme"></see>
    /// </summary>
    let deme = Namespaced_IRI.parse _namespace_name "deme" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/demographics"></see>
    /// </summary>
    let demographics =
        Namespaced_IRI.parse _namespace_name "demographics" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/demographicsAsOf"></see>
    /// </summary>
    let demographicsAsOf =
        Namespaced_IRI.parse _namespace_name "demographicsAsOf" |> NamespacedName

    /// <summary>
    /// The date the building was demolished.
    /// <see href="http://dbpedia.org/ontology/demolitionDate"></see></summary>
    let demolitionDate =
        Namespaced_IRI.parse _namespace_name "demolitionDate" |> NamespacedName

    /// <summary>
    /// The year the building was demolished.
    /// <see href="http://dbpedia.org/ontology/demolitionYear"></see></summary>
    let demolitionYear =
        Namespaced_IRI.parse _namespace_name "demolitionYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/demonym"></see>
    /// </summary>
    let demonym = Namespaced_IRI.parse _namespace_name "demonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/denomination"></see>
    /// </summary>
    let denomination =
        Namespaced_IRI.parse _namespace_name "denomination" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/density"></see>
    /// </summary>
    let density = Namespaced_IRI.parse _namespace_name "density" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/department"></see>
    /// </summary>
    let department = Namespaced_IRI.parse _namespace_name "department" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/departmentCode"></see>
    /// </summary>
    let departmentCode =
        Namespaced_IRI.parse _namespace_name "departmentCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/departmentPosition"></see>
    /// </summary>
    let departmentPosition =
        Namespaced_IRI.parse _namespace_name "departmentPosition" |> NamespacedName

    /// <summary>
    /// This property can be used to map image captions from Infoboxes
    /// <see href="http://dbpedia.org/ontology/depictionDescription"></see></summary>
    let depictionDescription =
        Namespaced_IRI.parse _namespace_name "depictionDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/depthQuote"></see>
    /// </summary>
    let depthQuote = Namespaced_IRI.parse _namespace_name "depthQuote" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/depths"></see>
    /// </summary>
    let depths = Namespaced_IRI.parse _namespace_name "depths" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/deputy"></see>
    /// </summary>
    let deputy = Namespaced_IRI.parse _namespace_name "deputy" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/derivative"></see>
    /// </summary>
    let derivative = Namespaced_IRI.parse _namespace_name "derivative" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/derivedWord"></see>
    /// </summary>
    let derivedWord =
        Namespaced_IRI.parse _namespace_name "derivedWord" |> NamespacedName

    /// <summary>
    /// Short description of a person
    /// <see href="http://dbpedia.org/ontology/description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/designCompany"></see>
    /// </summary>
    let designCompany =
        Namespaced_IRI.parse _namespace_name "designCompany" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/designer"></see>
    /// </summary>
    let designer = Namespaced_IRI.parse _namespace_name "designer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/destination"></see>
    /// </summary>
    let destination =
        Namespaced_IRI.parse _namespace_name "destination" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/destructionDate"></see>
    /// </summary>
    let destructionDate =
        Namespaced_IRI.parse _namespace_name "destructionDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/detectionMethod"></see>
    /// </summary>
    let detectionMethod =
        Namespaced_IRI.parse _namespace_name "detectionMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/detractor"></see>
    /// </summary>
    let detractor = Namespaced_IRI.parse _namespace_name "detractor" |> NamespacedName
    /// <summary>
    /// Developer of a Work (Artwork, Book, Software) or Building (Hotel, Skyscraper)
    /// <see href="http://dbpedia.org/ontology/developer"></see></summary>
    let developer = Namespaced_IRI.parse _namespace_name "developer" |> NamespacedName
    /// <summary>
    /// Department for Education (UK) number of a school in England or Wales
    /// <see href="http://dbpedia.org/ontology/dfE"></see></summary>
    let dfE = Namespaced_IRI.parse _namespace_name "dfE" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/diameter"></see>
    /// </summary>
    let diameter = Namespaced_IRI.parse _namespace_name "diameter" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/different"></see>
    /// </summary>
    let different = Namespaced_IRI.parse _namespace_name "different" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/digitalChannel"></see>
    /// </summary>
    let digitalChannel =
        Namespaced_IRI.parse _namespace_name "digitalChannel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/digitalSubChannel"></see>
    /// </summary>
    let digitalSubChannel =
        Namespaced_IRI.parse _namespace_name "digitalSubChannel" |> NamespacedName

    /// <summary>
    /// A religious administrative body above the parish level
    /// <see href="http://dbpedia.org/ontology/diocese"></see></summary>
    let diocese = Namespaced_IRI.parse _namespace_name "diocese" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Parish,_Deanery"></see>
    /// </summary>
    let ``Parish,_Deanery`` =
        Namespaced_IRI.parse _namespace_name "Parish,_Deanery" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/diploma"></see>
    /// </summary>
    let diploma = Namespaced_IRI.parse _namespace_name "diploma" |> NamespacedName
    /// <summary>
    /// A film director is a person who directs the making of a film.
    /// <see href="http://dbpedia.org/ontology/director"></see></summary>
    let director = Namespaced_IRI.parse _namespace_name "director" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/disappearanceDate"></see>
    /// </summary>
    let disappearanceDate =
        Namespaced_IRI.parse _namespace_name "disappearanceDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/disbanded"></see>
    /// </summary>
    let disbanded = Namespaced_IRI.parse _namespace_name "disbanded" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/discharge"></see>
    /// </summary>
    let discharge = Namespaced_IRI.parse _namespace_name "discharge" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dischargeAverage"></see>
    /// </summary>
    let dischargeAverage =
        Namespaced_IRI.parse _namespace_name "dischargeAverage" |> NamespacedName

    /// <summary>
    /// A person who learns from another, especially one who then teaches others..
    /// <see href="http://dbpedia.org/ontology/disciple"></see></summary>
    let disciple = Namespaced_IRI.parse _namespace_name "disciple" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/discipline"></see>
    /// </summary>
    let discipline = Namespaced_IRI.parse _namespace_name "discipline" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/discontinued"></see>
    /// </summary>
    let discontinued =
        Namespaced_IRI.parse _namespace_name "discontinued" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/discovered"></see>
    /// </summary>
    let discovered = Namespaced_IRI.parse _namespace_name "discovered" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/discoverer"></see>
    /// </summary>
    let discoverer = Namespaced_IRI.parse _namespace_name "discoverer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/discovery"></see>
    /// </summary>
    let discovery = Namespaced_IRI.parse _namespace_name "discovery" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/diseasesDb"></see>
    /// </summary>
    let diseasesDb = Namespaced_IRI.parse _namespace_name "diseasesDb" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/displacement"></see>
    /// </summary>
    let displacement =
        Namespaced_IRI.parse _namespace_name "displacement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dissolutionDate"></see>
    /// </summary>
    let dissolutionDate =
        Namespaced_IRI.parse _namespace_name "dissolutionDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dissolutionYear"></see>
    /// </summary>
    let dissolutionYear =
        Namespaced_IRI.parse _namespace_name "dissolutionYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Organisation,_PopulatedPlace"></see>
    /// </summary>
    let ``Organisation,_PopulatedPlace`` =
        Namespaced_IRI.parse _namespace_name "Organisation,_PopulatedPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dissolved"></see>
    /// </summary>
    let dissolved = Namespaced_IRI.parse _namespace_name "dissolved" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dist_ly"></see>
    /// </summary>
    let dist_ly = Namespaced_IRI.parse _namespace_name "dist_ly" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dist_pc"></see>
    /// </summary>
    let dist_pc = Namespaced_IRI.parse _namespace_name "dist_pc" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distance"></see>
    /// </summary>
    let distance = Namespaced_IRI.parse _namespace_name "distance" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceLaps"></see>
    /// </summary>
    let distanceLaps =
        Namespaced_IRI.parse _namespace_name "distanceLaps" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToBelfast"></see>
    /// </summary>
    let distanceToBelfast =
        Namespaced_IRI.parse _namespace_name "distanceToBelfast" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToCapital"></see>
    /// </summary>
    let distanceToCapital =
        Namespaced_IRI.parse _namespace_name "distanceToCapital" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Distance"></see>
    /// </summary>
    let Distance = Namespaced_IRI.parse _namespace_name "Distance" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToCardiff"></see>
    /// </summary>
    let distanceToCardiff =
        Namespaced_IRI.parse _namespace_name "distanceToCardiff" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToCharingCross"></see>
    /// </summary>
    let distanceToCharingCross =
        Namespaced_IRI.parse _namespace_name "distanceToCharingCross" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToDouglas"></see>
    /// </summary>
    let distanceToDouglas =
        Namespaced_IRI.parse _namespace_name "distanceToDouglas" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToDublin"></see>
    /// </summary>
    let distanceToDublin =
        Namespaced_IRI.parse _namespace_name "distanceToDublin" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToEdinburgh"></see>
    /// </summary>
    let distanceToEdinburgh =
        Namespaced_IRI.parse _namespace_name "distanceToEdinburgh" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceToLondon"></see>
    /// </summary>
    let distanceToLondon =
        Namespaced_IRI.parse _namespace_name "distanceToLondon" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distanceTraveled"></see>
    /// </summary>
    let distanceTraveled =
        Namespaced_IRI.parse _namespace_name "distanceTraveled" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distributingCompany"></see>
    /// </summary>
    let distributingCompany =
        Namespaced_IRI.parse _namespace_name "distributingCompany" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distributingLabel"></see>
    /// </summary>
    let distributingLabel =
        Namespaced_IRI.parse _namespace_name "distributingLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/distributor"></see>
    /// </summary>
    let distributor =
        Namespaced_IRI.parse _namespace_name "distributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/district"></see>
    /// </summary>
    let district = Namespaced_IRI.parse _namespace_name "district" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/division"></see>
    /// </summary>
    let division = Namespaced_IRI.parse _namespace_name "division" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dockedTime"></see>
    /// </summary>
    let dockedTime = Namespaced_IRI.parse _namespace_name "dockedTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/doctoralAdvisor"></see>
    /// </summary>
    let doctoralAdvisor =
        Namespaced_IRI.parse _namespace_name "doctoralAdvisor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/doctoralStudent"></see>
    /// </summary>
    let doctoralStudent =
        Namespaced_IRI.parse _namespace_name "doctoralStudent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/documentDesignation"></see>
    /// </summary>
    let documentDesignation =
        Namespaced_IRI.parse _namespace_name "documentDesignation" |> NamespacedName

    /// <summary>
    /// Identification a document within a particular registry
    /// <see href="http://dbpedia.org/ontology/documentNumber"></see></summary>
    let documentNumber =
        Namespaced_IRI.parse _namespace_name "documentNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/domain"></see>
    /// </summary>
    let domain = Namespaced_IRI.parse _namespace_name "domain" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dorlandsPrefix"></see>
    /// </summary>
    let dorlandsPrefix =
        Namespaced_IRI.parse _namespace_name "dorlandsPrefix" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dorlandsSuffix"></see>
    /// </summary>
    let dorlandsSuffix =
        Namespaced_IRI.parse _namespace_name "dorlandsSuffix" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draft"></see>
    /// </summary>
    let draft = Namespaced_IRI.parse _namespace_name "draft" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draftLeague"></see>
    /// </summary>
    let draftLeague =
        Namespaced_IRI.parse _namespace_name "draftLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draftPick"></see>
    /// </summary>
    let draftPick = Namespaced_IRI.parse _namespace_name "draftPick" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draftPosition"></see>
    /// </summary>
    let draftPosition =
        Namespaced_IRI.parse _namespace_name "draftPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draftRound"></see>
    /// </summary>
    let draftRound = Namespaced_IRI.parse _namespace_name "draftRound" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draftTeam"></see>
    /// </summary>
    let draftTeam = Namespaced_IRI.parse _namespace_name "draftTeam" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/draftYear"></see>
    /// </summary>
    let draftYear = Namespaced_IRI.parse _namespace_name "draftYear" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/drainsFrom"></see>
    /// </summary>
    let drainsFrom = Namespaced_IRI.parse _namespace_name "drainsFrom" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/drainsTo"></see>
    /// </summary>
    let drainsTo = Namespaced_IRI.parse _namespace_name "drainsTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/drama"></see>
    /// </summary>
    let drama = Namespaced_IRI.parse _namespace_name "drama" |> NamespacedName
    /// <summary>
    /// The recommended dress code for an establishment or event.
    /// <see href="http://dbpedia.org/ontology/dressCode"></see></summary>
    let dressCode = Namespaced_IRI.parse _namespace_name "dressCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/drugbank"></see>
    /// </summary>
    let drugbank = Namespaced_IRI.parse _namespace_name "drugbank" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dryCargo"></see>
    /// </summary>
    let dryCargo = Namespaced_IRI.parse _namespace_name "dryCargo" |> NamespacedName
    /// <summary>
    /// the person who dubs another person e.g. an actor or a fictional character in movies
    /// <see href="http://dbpedia.org/ontology/dubber"></see></summary>
    let dubber = Namespaced_IRI.parse _namespace_name "dubber" |> NamespacedName
    /// <summary>
    /// The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format
    /// <see href="http://dbpedia.org/ontology/duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dutchCOROPCode"></see>
    /// </summary>
    let dutchCOROPCode =
        Namespaced_IRI.parse _namespace_name "dutchCOROPCode" |> NamespacedName

    /// <summary>
    /// The Dutch MIP project was meant to take stock of all kinds of monuments
    /// <see href="http://dbpedia.org/ontology/dutchMIPCode"></see></summary>
    let dutchMIPCode =
        Namespaced_IRI.parse _namespace_name "dutchMIPCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ArchitecturalStructure,_Monument"></see>
    /// </summary>
    let ``ArchitecturalStructure,_Monument`` =
        Namespaced_IRI.parse _namespace_name "ArchitecturalStructure,_Monument" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dutchNAIdentifier"></see>
    /// </summary>
    let dutchNAIdentifier =
        Namespaced_IRI.parse _namespace_name "dutchNAIdentifier" |> NamespacedName

    /// <summary>
    /// Dutch PPN code is a library cataloguing code for collection items (books, journals and the like).
    /// <see href="http://dbpedia.org/ontology/dutchPPNCode"></see></summary>
    let dutchPPNCode =
        Namespaced_IRI.parse _namespace_name "dutchPPNCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dutchRKDCode"></see>
    /// </summary>
    let dutchRKDCode =
        Namespaced_IRI.parse _namespace_name "dutchRKDCode" |> NamespacedName

    /// <summary>
    /// Dutch Winkel ID is a code for an underground publication, as attributed by Lydia Winkel's work on the underground WW II press in the Netherlands.
    /// <see href="http://dbpedia.org/ontology/dutchWinkelID"></see></summary>
    let dutchWinkelID =
        Namespaced_IRI.parse _namespace_name "dutchWinkelID" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/dynasty"></see>
    /// </summary>
    let dynasty = Namespaced_IRI.parse _namespace_name "dynasty" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eMedicineSubject"></see>
    /// </summary>
    let eMedicineSubject =
        Namespaced_IRI.parse _namespace_name "eMedicineSubject" |> NamespacedName

    /// <summary>
    /// Different from eMedicineSubject, which see
    /// <see href="http://dbpedia.org/ontology/eMedicineTopic"></see></summary>
    let eMedicineTopic =
        Namespaced_IRI.parse _namespace_name "eMedicineTopic" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eTeatrId"></see>
    /// </summary>
    let eTeatrId = Namespaced_IRI.parse _namespace_name "eTeatrId" |> NamespacedName
    /// <summary>
    /// indicates another place situated east.
    /// <see href="http://dbpedia.org/ontology/eastPlace"></see></summary>
    let eastPlace = Namespaced_IRI.parse _namespace_name "eastPlace" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ecNumber"></see>
    /// </summary>
    let ecNumber = Namespaced_IRI.parse _namespace_name "ecNumber" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/editing"></see>
    /// </summary>
    let editing = Namespaced_IRI.parse _namespace_name "editing" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/editor"></see>
    /// </summary>
    let editor = Namespaced_IRI.parse _namespace_name "editor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/editorTitle"></see>
    /// </summary>
    let editorTitle =
        Namespaced_IRI.parse _namespace_name "editorTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/education"></see>
    /// </summary>
    let education = Namespaced_IRI.parse _namespace_name "education" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/educationPlace"></see>
    /// </summary>
    let educationPlace =
        Namespaced_IRI.parse _namespace_name "educationPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/educationSystem"></see>
    /// </summary>
    let educationSystem =
        Namespaced_IRI.parse _namespace_name "educationSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/effectiveRadiatedPower"></see>
    /// </summary>
    let effectiveRadiatedPower =
        Namespaced_IRI.parse _namespace_name "effectiveRadiatedPower" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/egafdId"></see>
    /// </summary>
    let egafdId = Namespaced_IRI.parse _namespace_name "egafdId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/einecsNumber"></see>
    /// </summary>
    let einecsNumber =
        Namespaced_IRI.parse _namespace_name "einecsNumber" |> NamespacedName

    /// <summary>
    /// Indexing code used by the Bulgarian National Statistical Institute to identify populated places
    /// <see href="http://dbpedia.org/ontology/ekatteCode"></see></summary>
    let ekatteCode = Namespaced_IRI.parse _namespace_name "ekatteCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/electionDate"></see>
    /// </summary>
    let electionDate =
        Namespaced_IRI.parse _namespace_name "electionDate" |> NamespacedName

    /// <summary>
    /// The date that leader was elected.
    /// <see href="http://dbpedia.org/ontology/electionDateLeader"></see></summary>
    let electionDateLeader =
        Namespaced_IRI.parse _namespace_name "electionDateLeader" |> NamespacedName

    /// <summary>
    /// number of votes the office holder attained
    /// <see href="http://dbpedia.org/ontology/electionMajority"></see></summary>
    let electionMajority =
        Namespaced_IRI.parse _namespace_name "electionMajority" |> NamespacedName

    /// <summary>
    /// element placed above current element in D.I.Mendeleev's table
    /// <see href="http://dbpedia.org/ontology/elementAbove"></see></summary>
    let elementAbove =
        Namespaced_IRI.parse _namespace_name "elementAbove" |> NamespacedName

    /// <summary>
    /// A block of the periodic table of elements is a set of adjacent groups.
    /// <see href="http://dbpedia.org/ontology/elementBlock"></see></summary>
    let elementBlock =
        Namespaced_IRI.parse _namespace_name "elementBlock" |> NamespacedName

    /// <summary>
    /// In chemistry, a group (also known as a family) is a column of elements in the periodic table of the chemical elements.
    /// <see href="http://dbpedia.org/ontology/elementGroup"></see></summary>
    let elementGroup =
        Namespaced_IRI.parse _namespace_name "elementGroup" |> NamespacedName

    /// <summary>
    /// In the periodic table of the elements, elements are arranged in a series of rows (or periods) so that those with similar properties appear in a column.
    /// <see href="http://dbpedia.org/ontology/elementPeriod"></see></summary>
    let elementPeriod =
        Namespaced_IRI.parse _namespace_name "elementPeriod" |> NamespacedName

    /// <summary>
    /// average elevation above the sea level
    /// <see href="http://dbpedia.org/ontology/elevation"></see></summary>
    let elevation = Namespaced_IRI.parse _namespace_name "elevation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/elevationQuote"></see>
    /// </summary>
    let elevationQuote =
        Namespaced_IRI.parse _namespace_name "elevationQuote" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/elevatorCount"></see>
    /// </summary>
    let elevatorCount =
        Namespaced_IRI.parse _namespace_name "elevatorCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/elo"></see>
    /// </summary>
    let elo = Namespaced_IRI.parse _namespace_name "elo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eloRecord"></see>
    /// </summary>
    let eloRecord = Namespaced_IRI.parse _namespace_name "eloRecord" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/emblem"></see>
    /// </summary>
    let emblem = Namespaced_IRI.parse _namespace_name "emblem" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/emmyAward"></see>
    /// </summary>
    let emmyAward = Namespaced_IRI.parse _namespace_name "emmyAward" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/employer"></see>
    /// </summary>
    let employer = Namespaced_IRI.parse _namespace_name "employer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/employersCelebration"></see>
    /// </summary>
    let employersCelebration =
        Namespaced_IRI.parse _namespace_name "employersCelebration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endCareer"></see>
    /// </summary>
    let endCareer = Namespaced_IRI.parse _namespace_name "endCareer" |> NamespacedName
    /// <summary>
    /// The end date of the event.
    /// <see href="http://dbpedia.org/ontology/endDate"></see></summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName

    /// <summary>
    /// The end date and time of the event.
    /// <see href="http://dbpedia.org/ontology/endDateTime"></see></summary>
    let endDateTime =
        Namespaced_IRI.parse _namespace_name "endDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endOccupation"></see>
    /// </summary>
    let endOccupation =
        Namespaced_IRI.parse _namespace_name "endOccupation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endPoint"></see>
    /// </summary>
    let endPoint = Namespaced_IRI.parse _namespace_name "endPoint" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endReign"></see>
    /// </summary>
    let endReign = Namespaced_IRI.parse _namespace_name "endReign" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endYear"></see>
    /// </summary>
    let endYear = Namespaced_IRI.parse _namespace_name "endYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endYearOfInsertion"></see>
    /// </summary>
    let endYearOfInsertion =
        Namespaced_IRI.parse _namespace_name "endYearOfInsertion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endYearOfSales"></see>
    /// </summary>
    let endYearOfSales =
        Namespaced_IRI.parse _namespace_name "endYearOfSales" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endangeredSince"></see>
    /// </summary>
    let endangeredSince =
        Namespaced_IRI.parse _namespace_name "endangeredSince" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endingTheme"></see>
    /// </summary>
    let endingTheme =
        Namespaced_IRI.parse _namespace_name "endingTheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/endowment"></see>
    /// </summary>
    let endowment = Namespaced_IRI.parse _namespace_name "endowment" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/enemy"></see>
    /// </summary>
    let enemy = Namespaced_IRI.parse _namespace_name "enemy" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/engine"></see>
    /// </summary>
    let engine = Namespaced_IRI.parse _namespace_name "engine" |> NamespacedName

    /// <summary>
    /// Power to be expressed in Watts (kiloWatt, megaWatt)
    /// <see href="http://dbpedia.org/ontology/enginePower"></see></summary>
    let enginePower =
        Namespaced_IRI.parse _namespace_name "enginePower" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/engineType"></see>
    /// </summary>
    let engineType = Namespaced_IRI.parse _namespace_name "engineType" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/engineer"></see>
    /// </summary>
    let engineer = Namespaced_IRI.parse _namespace_name "engineer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ensembl"></see>
    /// </summary>
    let ensembl = Namespaced_IRI.parse _namespace_name "ensembl" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/enshrinedDeity"></see>
    /// </summary>
    let enshrinedDeity =
        Namespaced_IRI.parse _namespace_name "enshrinedDeity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/entourage"></see>
    /// </summary>
    let entourage = Namespaced_IRI.parse _namespace_name "entourage" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/entrezgene"></see>
    /// </summary>
    let entrezgene = Namespaced_IRI.parse _namespace_name "entrezgene" |> NamespacedName
    /// <summary>
    /// Compare with bishopric
    /// <see href="http://dbpedia.org/ontology/eparchy"></see></summary>
    let eparchy = Namespaced_IRI.parse _namespace_name "eparchy" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/episode"></see>
    /// </summary>
    let episode = Namespaced_IRI.parse _namespace_name "episode" |> NamespacedName

    /// <summary>
    /// The episode number of the TelevisionEpisode.
    /// <see href="http://dbpedia.org/ontology/episodeNumber"></see></summary>
    let episodeNumber =
        Namespaced_IRI.parse _namespace_name "episodeNumber" |> NamespacedName

    /// <summary>
    /// moment in time used as a referrence point for some time-vaying astronomical quantity
    /// <see href="http://dbpedia.org/ontology/epoch"></see></summary>
    let epoch = Namespaced_IRI.parse _namespace_name "epoch" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eptFinalTable"></see>
    /// </summary>
    let eptFinalTable =
        Namespaced_IRI.parse _namespace_name "eptFinalTable" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eptItm"></see>
    /// </summary>
    let eptItm = Namespaced_IRI.parse _namespace_name "eptItm" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eptTitle"></see>
    /// </summary>
    let eptTitle = Namespaced_IRI.parse _namespace_name "eptTitle" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/equipment"></see>
    /// </summary>
    let equipment = Namespaced_IRI.parse _namespace_name "equipment" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/equity"></see>
    /// </summary>
    let equity = Namespaced_IRI.parse _namespace_name "equity" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/era"></see>
    /// </summary>
    let era = Namespaced_IRI.parse _namespace_name "era" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eruption"></see>
    /// </summary>
    let eruption = Namespaced_IRI.parse _namespace_name "eruption" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eruptionYear"></see>
    /// </summary>
    let eruptionYear =
        Namespaced_IRI.parse _namespace_name "eruptionYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/escalafon"></see>
    /// </summary>
    let escalafon = Namespaced_IRI.parse _namespace_name "escalafon" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/escapeVelocity"></see>
    /// </summary>
    let escapeVelocity =
        Namespaced_IRI.parse _namespace_name "escapeVelocity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/espnId"></see>
    /// </summary>
    let espnId = Namespaced_IRI.parse _namespace_name "espnId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/established"></see>
    /// </summary>
    let established =
        Namespaced_IRI.parse _namespace_name "established" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/establishment"></see>
    /// </summary>
    let establishment =
        Namespaced_IRI.parse _namespace_name "establishment" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ethnicGroup"></see>
    /// </summary>
    let ethnicGroup =
        Namespaced_IRI.parse _namespace_name "ethnicGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ethnicGroupsInYear"></see>
    /// </summary>
    let ethnicGroupsInYear =
        Namespaced_IRI.parse _namespace_name "ethnicGroupsInYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ethnicity"></see>
    /// </summary>
    let ethnicity = Namespaced_IRI.parse _namespace_name "ethnicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eurobabeIndexId"></see>
    /// </summary>
    let eurobabeIndexId =
        Namespaced_IRI.parse _namespace_name "eurobabeIndexId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/europeanAffiliation"></see>
    /// </summary>
    let europeanAffiliation =
        Namespaced_IRI.parse _namespace_name "europeanAffiliation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/europeanChampionship"></see>
    /// </summary>
    let europeanChampionship =
        Namespaced_IRI.parse _namespace_name "europeanChampionship" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/europeanParliamentGroup"></see>
    /// </summary>
    let europeanParliamentGroup =
        Namespaced_IRI.parse _namespace_name "europeanParliamentGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/europeanUnionEntranceDate"></see>
    /// </summary>
    let europeanUnionEntranceDate =
        Namespaced_IRI.parse _namespace_name "europeanUnionEntranceDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/event"></see>
    /// </summary>
    let event_ = Namespaced_IRI.parse _namespace_name "event" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eventDate"></see>
    /// </summary>
    let eventDate = Namespaced_IRI.parse _namespace_name "eventDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eventDescription"></see>
    /// </summary>
    let eventDescription =
        Namespaced_IRI.parse _namespace_name "eventDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/executiveHeadteacher"></see>
    /// </summary>
    let executiveHeadteacher =
        Namespaced_IRI.parse _namespace_name "executiveHeadteacher" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/executiveProducer"></see>
    /// </summary>
    let executiveProducer =
        Namespaced_IRI.parse _namespace_name "executiveProducer" |> NamespacedName

    /// <summary>
    /// Notes about an exhibition the object has been to
    /// <see href="http://dbpedia.org/ontology/exhibition"></see></summary>
    let exhibition = Namespaced_IRI.parse _namespace_name "exhibition" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/existence"></see>
    /// </summary>
    let existence = Namespaced_IRI.parse _namespace_name "existence" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/expedition"></see>
    /// </summary>
    let expedition = Namespaced_IRI.parse _namespace_name "expedition" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/explorer"></see>
    /// </summary>
    let explorer = Namespaced_IRI.parse _namespace_name "explorer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/externalOrnament"></see>
    /// </summary>
    let externalOrnament =
        Namespaced_IRI.parse _namespace_name "externalOrnament" |> NamespacedName

    /// <summary>
    /// Date when an Organization (eg PoliticalParty, Company) or Species ceased to exist
    /// <see href="http://dbpedia.org/ontology/extinctionDate"></see></summary>
    let extinctionDate =
        Namespaced_IRI.parse _namespace_name "extinctionDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/extinctionYear"></see>
    /// </summary>
    let extinctionYear =
        Namespaced_IRI.parse _namespace_name "extinctionYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eyeColor"></see>
    /// </summary>
    let eyeColor = Namespaced_IRI.parse _namespace_name "eyeColor" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eyeColour"></see>
    /// </summary>
    let eyeColour = Namespaced_IRI.parse _namespace_name "eyeColour" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/eyes"></see>
    /// </summary>
    let eyes = Namespaced_IRI.parse _namespace_name "eyes" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/faaLocationIdentifier"></see>
    /// </summary>
    let faaLocationIdentifier =
        Namespaced_IRI.parse _namespace_name "faaLocationIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/facilityId"></see>
    /// </summary>
    let facilityId = Namespaced_IRI.parse _namespace_name "facilityId" |> NamespacedName

    /// <summary>
    /// number of faculty members
    /// <see href="http://dbpedia.org/ontology/facultySize"></see></summary>
    let facultySize =
        Namespaced_IRI.parse _namespace_name "facultySize" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/failedLaunches"></see>
    /// </summary>
    let failedLaunches =
        Namespaced_IRI.parse _namespace_name "failedLaunches" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/family"></see>
    /// </summary>
    let family = Namespaced_IRI.parse _namespace_name "family" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/familyMember"></see>
    /// </summary>
    let familyMember =
        Namespaced_IRI.parse _namespace_name "familyMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fansgroup"></see>
    /// </summary>
    let fansgroup = Namespaced_IRI.parse _namespace_name "fansgroup" |> NamespacedName
    /// <summary>
    /// The fare zone in which station is located.
    /// <see href="http://dbpedia.org/ontology/fareZone"></see></summary>
    let fareZone = Namespaced_IRI.parse _namespace_name "fareZone" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fastestDriver"></see>
    /// </summary>
    let fastestDriver =
        Namespaced_IRI.parse _namespace_name "fastestDriver" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fastestDriverCountry"></see>
    /// </summary>
    let fastestDriverCountry =
        Namespaced_IRI.parse _namespace_name "fastestDriverCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fastestDriverTeam"></see>
    /// </summary>
    let fastestDriverTeam =
        Namespaced_IRI.parse _namespace_name "fastestDriverTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fastestLap"></see>
    /// </summary>
    let fastestLap = Namespaced_IRI.parse _namespace_name "fastestLap" |> NamespacedName
    /// <summary>
    /// Amount of fat per servingSize of a Food
    /// <see href="http://dbpedia.org/ontology/fat"></see></summary>
    let fat = Namespaced_IRI.parse _namespace_name "fat" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fate"></see>
    /// </summary>
    let fate = Namespaced_IRI.parse _namespace_name "fate" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/father"></see>
    /// </summary>
    let father = Namespaced_IRI.parse _namespace_name "father" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fauna"></see>
    /// </summary>
    let fauna = Namespaced_IRI.parse _namespace_name "fauna" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fc"></see>
    /// </summary>
    let fc = Namespaced_IRI.parse _namespace_name "fc" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fcRuns"></see>
    /// </summary>
    let fcRuns = Namespaced_IRI.parse _namespace_name "fcRuns" |> NamespacedName

    /// <summary>
    /// FDA Unique Ingredient Identifier (UNII) code for a DBpedia Drug
    /// <see href="http://dbpedia.org/ontology/fdaUniiCode"></see></summary>
    let fdaUniiCode =
        Namespaced_IRI.parse _namespace_name "fdaUniiCode" |> NamespacedName

    /// <summary>
    /// A day of celebration associated with the entity. Applies to Saint, School etc
    /// <see href="http://dbpedia.org/ontology/feastDay"></see></summary>
    let feastDay = Namespaced_IRI.parse _namespace_name "feastDay" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/feat"></see>
    /// </summary>
    let feat = Namespaced_IRI.parse _namespace_name "feat" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/feature"></see>
    /// </summary>
    let feature = Namespaced_IRI.parse _namespace_name "feature" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/features"></see>
    /// </summary>
    let features = Namespaced_IRI.parse _namespace_name "features" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fedCup"></see>
    /// </summary>
    let fedCup = Namespaced_IRI.parse _namespace_name "fedCup" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/federalState"></see>
    /// </summary>
    let federalState =
        Namespaced_IRI.parse _namespace_name "federalState" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/federation"></see>
    /// </summary>
    let federation = Namespaced_IRI.parse _namespace_name "federation" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fees"></see>
    /// </summary>
    let fees = Namespaced_IRI.parse _namespace_name "fees" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fibahof"></see>
    /// </summary>
    let fibahof = Namespaced_IRI.parse _namespace_name "fibahof" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/field"></see>
    /// </summary>
    let field = Namespaced_IRI.parse _namespace_name "field" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fight"></see>
    /// </summary>
    let fight = Namespaced_IRI.parse _namespace_name "fight" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fighter"></see>
    /// </summary>
    let fighter = Namespaced_IRI.parse _namespace_name "fighter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fileExtension"></see>
    /// </summary>
    let fileExtension =
        Namespaced_IRI.parse _namespace_name "fileExtension" |> NamespacedName

    /// <summary>
    /// size of a file or software
    /// <see href="http://dbpedia.org/ontology/fileSize"></see></summary>
    let fileSize = Namespaced_IRI.parse _namespace_name "fileSize" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fileURL"></see>
    /// </summary>
    let fileURL = Namespaced_IRI.parse _namespace_name "fileURL" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/filename"></see>
    /// </summary>
    let filename = Namespaced_IRI.parse _namespace_name "filename" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fillingStation"></see>
    /// </summary>
    let fillingStation =
        Namespaced_IRI.parse _namespace_name "fillingStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/film"></see>
    /// </summary>
    let film = Namespaced_IRI.parse _namespace_name "film" |> NamespacedName

    /// <summary>
    /// specifies the audio type of the film i.e. 'sound' or 'silent'
    /// <see href="http://dbpedia.org/ontology/filmAudioType"></see></summary>
    let filmAudioType =
        Namespaced_IRI.parse _namespace_name "filmAudioType" |> NamespacedName

    /// <summary>
    /// specifies the colour type of the film i.e. 'colour' or 'b/w'
    /// <see href="http://dbpedia.org/ontology/filmColourType"></see></summary>
    let filmColourType =
        Namespaced_IRI.parse _namespace_name "filmColourType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/filmFareAward"></see>
    /// </summary>
    let filmFareAward =
        Namespaced_IRI.parse _namespace_name "filmFareAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/filmNumber"></see>
    /// </summary>
    let filmNumber = Namespaced_IRI.parse _namespace_name "filmNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/filmPolskiId"></see>
    /// </summary>
    let filmPolskiId =
        Namespaced_IRI.parse _namespace_name "filmPolskiId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/filmRuntime"></see>
    /// </summary>
    let filmRuntime =
        Namespaced_IRI.parse _namespace_name "filmRuntime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/filmVersion"></see>
    /// </summary>
    let filmVersion =
        Namespaced_IRI.parse _namespace_name "filmVersion" |> NamespacedName

    /// <summary>
    /// date of final flight
    /// <see href="http://dbpedia.org/ontology/finalFlight"></see></summary>
    let finalFlight =
        Namespaced_IRI.parse _namespace_name "finalFlight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/finalLost"></see>
    /// </summary>
    let finalLost = Namespaced_IRI.parse _namespace_name "finalLost" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/finalLostDouble"></see>
    /// </summary>
    let finalLostDouble =
        Namespaced_IRI.parse _namespace_name "finalLostDouble" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/finalLostSingle"></see>
    /// </summary>
    let finalLostSingle =
        Namespaced_IRI.parse _namespace_name "finalLostSingle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/finalLostTeam"></see>
    /// </summary>
    let finalLostTeam =
        Namespaced_IRI.parse _namespace_name "finalLostTeam" |> NamespacedName

    /// <summary>
    /// Date of the final publication.
    /// <see href="http://dbpedia.org/ontology/finalPublicationDate"></see></summary>
    let finalPublicationDate =
        Namespaced_IRI.parse _namespace_name "finalPublicationDate" |> NamespacedName

    /// <summary>
    /// Year of the final publication.
    /// <see href="http://dbpedia.org/ontology/finalPublicationYear"></see></summary>
    let finalPublicationYear =
        Namespaced_IRI.parse _namespace_name "finalPublicationYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fipsCode"></see>
    /// </summary>
    let fipsCode = Namespaced_IRI.parse _namespace_name "fipsCode" |> NamespacedName

    /// <summary>
    /// The date on which regular broadcasts began.
    /// <see href="http://dbpedia.org/ontology/firstAirDate"></see></summary>
    let firstAirDate =
        Namespaced_IRI.parse _namespace_name "firstAirDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstAppearance"></see>
    /// </summary>
    let firstAppearance =
        Namespaced_IRI.parse _namespace_name "firstAppearance" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstAscent"></see>
    /// </summary>
    let firstAscent =
        Namespaced_IRI.parse _namespace_name "firstAscent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Mountain,Volcano"></see>
    /// </summary>
    let ``Mountain,Volcano`` =
        Namespaced_IRI.parse _namespace_name "Mountain,Volcano" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstAscentPerson"></see>
    /// </summary>
    let firstAscentPerson =
        Namespaced_IRI.parse _namespace_name "firstAscentPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstAscentYear"></see>
    /// </summary>
    let firstAscentYear =
        Namespaced_IRI.parse _namespace_name "firstAscentYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstBroadcast"></see>
    /// </summary>
    let firstBroadcast =
        Namespaced_IRI.parse _namespace_name "firstBroadcast" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstDriver"></see>
    /// </summary>
    let firstDriver =
        Namespaced_IRI.parse _namespace_name "firstDriver" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstDriverCountry"></see>
    /// </summary>
    let firstDriverCountry =
        Namespaced_IRI.parse _namespace_name "firstDriverCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstDriverTeam"></see>
    /// </summary>
    let firstDriverTeam =
        Namespaced_IRI.parse _namespace_name "firstDriverTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstFlight"></see>
    /// </summary>
    let firstFlight =
        Namespaced_IRI.parse _namespace_name "firstFlight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstFlightEndDate"></see>
    /// </summary>
    let firstFlightEndDate =
        Namespaced_IRI.parse _namespace_name "firstFlightEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstFlightStartDate"></see>
    /// </summary>
    let firstFlightStartDate =
        Namespaced_IRI.parse _namespace_name "firstFlightStartDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstGame"></see>
    /// </summary>
    let firstGame = Namespaced_IRI.parse _namespace_name "firstGame" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstLaunch"></see>
    /// </summary>
    let firstLaunch =
        Namespaced_IRI.parse _namespace_name "firstLaunch" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstLaunchDate"></see>
    /// </summary>
    let firstLaunchDate =
        Namespaced_IRI.parse _namespace_name "firstLaunchDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstLaunchRocket"></see>
    /// </summary>
    let firstLaunchRocket =
        Namespaced_IRI.parse _namespace_name "firstLaunchRocket" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstLeader"></see>
    /// </summary>
    let firstLeader =
        Namespaced_IRI.parse _namespace_name "firstLeader" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstMention"></see>
    /// </summary>
    let firstMention =
        Namespaced_IRI.parse _namespace_name "firstMention" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstOlympicEvent"></see>
    /// </summary>
    let firstOlympicEvent =
        Namespaced_IRI.parse _namespace_name "firstOlympicEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstOwner"></see>
    /// </summary>
    let firstOwner = Namespaced_IRI.parse _namespace_name "firstOwner" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstPlace"></see>
    /// </summary>
    let firstPlace = Namespaced_IRI.parse _namespace_name "firstPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstPopularVote"></see>
    /// </summary>
    let firstPopularVote =
        Namespaced_IRI.parse _namespace_name "firstPopularVote" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstProMatch"></see>
    /// </summary>
    let firstProMatch =
        Namespaced_IRI.parse _namespace_name "firstProMatch" |> NamespacedName

    /// <summary>
    /// Date of the first publication.
    /// <see href="http://dbpedia.org/ontology/firstPublicationDate"></see></summary>
    let firstPublicationDate =
        Namespaced_IRI.parse _namespace_name "firstPublicationDate" |> NamespacedName

    /// <summary>
    /// Year of the first publication.
    /// <see href="http://dbpedia.org/ontology/firstPublicationYear"></see></summary>
    let firstPublicationYear =
        Namespaced_IRI.parse _namespace_name "firstPublicationYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstPublisher"></see>
    /// </summary>
    let firstPublisher =
        Namespaced_IRI.parse _namespace_name "firstPublisher" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstRace"></see>
    /// </summary>
    let firstRace = Namespaced_IRI.parse _namespace_name "firstRace" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstWin"></see>
    /// </summary>
    let firstWin = Namespaced_IRI.parse _namespace_name "firstWin" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/firstWinner"></see>
    /// </summary>
    let firstWinner =
        Namespaced_IRI.parse _namespace_name "firstWinner" |> NamespacedName

    /// <summary>
    /// Wikimedia Commons file name representing the subject's flag
    /// <see href="http://dbpedia.org/ontology/flag"></see></summary>
    let flag = Namespaced_IRI.parse _namespace_name "flag" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flagBearer"></see>
    /// </summary>
    let flagBearer = Namespaced_IRI.parse _namespace_name "flagBearer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flagBorder"></see>
    /// </summary>
    let flagBorder = Namespaced_IRI.parse _namespace_name "flagBorder" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flagCaption"></see>
    /// </summary>
    let flagCaption =
        Namespaced_IRI.parse _namespace_name "flagCaption" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flagLink"></see>
    /// </summary>
    let flagLink = Namespaced_IRI.parse _namespace_name "flagLink" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flagSize"></see>
    /// </summary>
    let flagSize = Namespaced_IRI.parse _namespace_name "flagSize" |> NamespacedName
    /// <summary>
    /// lowest temperature at which a substance can vaporize and start burning
    /// <see href="http://dbpedia.org/ontology/flashPoint"></see></summary>
    let flashPoint = Namespaced_IRI.parse _namespace_name "flashPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/floodingDate"></see>
    /// </summary>
    let floodingDate =
        Namespaced_IRI.parse _namespace_name "floodingDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/floorArea"></see>
    /// </summary>
    let floorArea = Namespaced_IRI.parse _namespace_name "floorArea" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/floorCount"></see>
    /// </summary>
    let floorCount = Namespaced_IRI.parse _namespace_name "floorCount" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flora"></see>
    /// </summary>
    let flora = Namespaced_IRI.parse _namespace_name "flora" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flower"></see>
    /// </summary>
    let flower = Namespaced_IRI.parse _namespace_name "flower" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/flyingHours"></see>
    /// </summary>
    let flyingHours =
        Namespaced_IRI.parse _namespace_name "flyingHours" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foalDate"></see>
    /// </summary>
    let foalDate = Namespaced_IRI.parse _namespace_name "foalDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/followedBy"></see>
    /// </summary>
    let followedBy = Namespaced_IRI.parse _namespace_name "followedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/followingEvent"></see>
    /// </summary>
    let followingEvent =
        Namespaced_IRI.parse _namespace_name "followingEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/follows"></see>
    /// </summary>
    let follows = Namespaced_IRI.parse _namespace_name "follows" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foot"></see>
    /// </summary>
    let foot = Namespaced_IRI.parse _namespace_name "foot" |> NamespacedName
    /// <summary>
    /// a preference to put one's left or right foot forward in surfing, wakeboarding, skateboarding, wakeskating, snowboarding and mountainboarding. The term is sometimes applied to the foot a footballer uses to kick.
    /// <see href="http://dbpedia.org/ontology/footedness"></see></summary>
    let footedness = Namespaced_IRI.parse _namespace_name "footedness" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/forces"></see>
    /// </summary>
    let forces = Namespaced_IRI.parse _namespace_name "forces" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foresterDistrict"></see>
    /// </summary>
    let foresterDistrict =
        Namespaced_IRI.parse _namespace_name "foresterDistrict" |> NamespacedName

    /// <summary>
    /// Format of the resource (as object). Use dct:format for literal, format for object
    /// <see href="http://dbpedia.org/ontology/format"></see></summary>
    let format = Namespaced_IRI.parse _namespace_name "format" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formationDate"></see>
    /// </summary>
    let formationDate =
        Namespaced_IRI.parse _namespace_name "formationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formationYear"></see>
    /// </summary>
    let formationYear =
        Namespaced_IRI.parse _namespace_name "formationYear" |> NamespacedName

    /// <summary>
    /// A former member of the band.
    /// <see href="http://dbpedia.org/ontology/formerBandMember"></see></summary>
    let formerBandMember =
        Namespaced_IRI.parse _namespace_name "formerBandMember" |> NamespacedName

    /// <summary>
    /// A former parent broadcast network to which the broadcaster once belonged.
    /// <see href="http://dbpedia.org/ontology/formerBroadcastNetwork"></see></summary>
    let formerBroadcastNetwork =
        Namespaced_IRI.parse _namespace_name "formerBroadcastNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerCallsign"></see>
    /// </summary>
    let formerCallsign =
        Namespaced_IRI.parse _namespace_name "formerCallsign" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerChannel"></see>
    /// </summary>
    let formerChannel =
        Namespaced_IRI.parse _namespace_name "formerChannel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerChoreographer"></see>
    /// </summary>
    let formerChoreographer =
        Namespaced_IRI.parse _namespace_name "formerChoreographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerCoach"></see>
    /// </summary>
    let formerCoach =
        Namespaced_IRI.parse _namespace_name "formerCoach" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerHighschool"></see>
    /// </summary>
    let formerHighschool =
        Namespaced_IRI.parse _namespace_name "formerHighschool" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerName"></see>
    /// </summary>
    let formerName = Namespaced_IRI.parse _namespace_name "formerName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerPartner"></see>
    /// </summary>
    let formerPartner =
        Namespaced_IRI.parse _namespace_name "formerPartner" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formerTeam"></see>
    /// </summary>
    let formerTeam = Namespaced_IRI.parse _namespace_name "formerTeam" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/formula"></see>
    /// </summary>
    let formula = Namespaced_IRI.parse _namespace_name "formula" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fossil"></see>
    /// </summary>
    let fossil = Namespaced_IRI.parse _namespace_name "fossil" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foundation"></see>
    /// </summary>
    let foundation = Namespaced_IRI.parse _namespace_name "foundation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foundationPlace"></see>
    /// </summary>
    let foundationPlace =
        Namespaced_IRI.parse _namespace_name "foundationPlace" |> NamespacedName

    /// <summary>
    /// Identifies the founder of the described entity. This can be a person or a organisation for instance.
    /// <see href="http://dbpedia.org/ontology/foundedBy"></see></summary>
    let foundedBy = Namespaced_IRI.parse _namespace_name "foundedBy" |> NamespacedName
    /// <summary>
    /// Ein Gründer oder Gründungsmitglied einer Organisation, Religion oder eines Ortes.
    /// <see href="http://dbpedia.org/ontology/founder"></see></summary>
    let founder = Namespaced_IRI.parse _namespace_name "founder" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foundingDate"></see>
    /// </summary>
    let foundingDate =
        Namespaced_IRI.parse _namespace_name "foundingDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/foundingYear"></see>
    /// </summary>
    let foundingYear =
        Namespaced_IRI.parse _namespace_name "foundingYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fourthCommander"></see>
    /// </summary>
    let fourthCommander =
        Namespaced_IRI.parse _namespace_name "fourthCommander" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/frazioni"></see>
    /// </summary>
    let frazioni = Namespaced_IRI.parse _namespace_name "frazioni" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/free"></see>
    /// </summary>
    let free = Namespaced_IRI.parse _namespace_name "free" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/freeDanseScore"></see>
    /// </summary>
    let freeDanseScore =
        Namespaced_IRI.parse _namespace_name "freeDanseScore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/freeFlightTime"></see>
    /// </summary>
    let freeFlightTime =
        Namespaced_IRI.parse _namespace_name "freeFlightTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/freeLabel"></see>
    /// </summary>
    let freeLabel = Namespaced_IRI.parse _namespace_name "freeLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/freeProgCompetition"></see>
    /// </summary>
    let freeProgCompetition =
        Namespaced_IRI.parse _namespace_name "freeProgCompetition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/freeProgScore"></see>
    /// </summary>
    let freeProgScore =
        Namespaced_IRI.parse _namespace_name "freeProgScore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/freeScoreCompetition"></see>
    /// </summary>
    let freeScoreCompetition =
        Namespaced_IRI.parse _namespace_name "freeScoreCompetition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/frequency"></see>
    /// </summary>
    let frequency = Namespaced_IRI.parse _namespace_name "frequency" |> NamespacedName

    /// <summary>
    /// The frequency of periodical publication (eg. Weekly, Bimonthly).
    /// <see href="http://dbpedia.org/ontology/frequencyOfPublication"></see></summary>
    let frequencyOfPublication =
        Namespaced_IRI.parse _namespace_name "frequencyOfPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/frequentlyUpdated"></see>
    /// </summary>
    let frequentlyUpdated =
        Namespaced_IRI.parse _namespace_name "frequentlyUpdated" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/friend"></see>
    /// </summary>
    let friend = Namespaced_IRI.parse _namespace_name "friend" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/frontierLength"></see>
    /// </summary>
    let frontierLength =
        Namespaced_IRI.parse _namespace_name "frontierLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/frozen"></see>
    /// </summary>
    let frozen = Namespaced_IRI.parse _namespace_name "frozen" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fuel"></see>
    /// </summary>
    let fuel = Namespaced_IRI.parse _namespace_name "fuel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fuelCapacity"></see>
    /// </summary>
    let fuelCapacity =
        Namespaced_IRI.parse _namespace_name "fuelCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fuelConsumption"></see>
    /// </summary>
    let fuelConsumption =
        Namespaced_IRI.parse _namespace_name "fuelConsumption" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fuelSystem"></see>
    /// </summary>
    let fuelSystem = Namespaced_IRI.parse _namespace_name "fuelSystem" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fuelType"></see>
    /// </summary>
    let fuelType = Namespaced_IRI.parse _namespace_name "fuelType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fuelTypeName"></see>
    /// </summary>
    let fuelTypeName =
        Namespaced_IRI.parse _namespace_name "fuelTypeName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fullCompetition"></see>
    /// </summary>
    let fullCompetition =
        Namespaced_IRI.parse _namespace_name "fullCompetition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/fullScore"></see>
    /// </summary>
    let fullScore = Namespaced_IRI.parse _namespace_name "fullScore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/functionEndDate"></see>
    /// </summary>
    let functionEndDate =
        Namespaced_IRI.parse _namespace_name "functionEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/functionEndYear"></see>
    /// </summary>
    let functionEndYear =
        Namespaced_IRI.parse _namespace_name "functionEndYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/functionStartDate"></see>
    /// </summary>
    let functionStartDate =
        Namespaced_IRI.parse _namespace_name "functionStartDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/functionStartYear"></see>
    /// </summary>
    let functionStartYear =
        Namespaced_IRI.parse _namespace_name "functionStartYear" |> NamespacedName

    /// <summary>
    /// A organisation financing the research project.
    /// <see href="http://dbpedia.org/ontology/fundedBy"></see></summary>
    let fundedBy = Namespaced_IRI.parse _namespace_name "fundedBy" |> NamespacedName

    /// <summary>
    /// The last inquiry date about linguistics uses.
    /// <see href="http://dbpedia.org/ontology/galicianSpeakersDate"></see></summary>
    let galicianSpeakersDate =
        Namespaced_IRI.parse _namespace_name "galicianSpeakersDate" |> NamespacedName

    /// <summary>
    /// Percentage of Galician speakers.
    /// <see href="http://dbpedia.org/ontology/galicianSpeakersPercentage"></see></summary>
    let galicianSpeakersPercentage =
        Namespaced_IRI.parse _namespace_name "galicianSpeakersPercentage" |> NamespacedName

    /// <summary>
    /// A file contained in a gallery
    /// <see href="http://dbpedia.org/ontology/galleryItem"></see></summary>
    let galleryItem =
        Namespaced_IRI.parse _namespace_name "galleryItem" |> NamespacedName

    /// <summary>
    /// A game artist is an artist who creates art for one or more types of games. Game artists are responsible for all of the aspects of game development that call for visual art.
    /// <see href="http://dbpedia.org/ontology/gameArtist"></see></summary>
    let gameArtist = Namespaced_IRI.parse _namespace_name "gameArtist" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gameEngine"></see>
    /// </summary>
    let gameEngine = Namespaced_IRI.parse _namespace_name "gameEngine" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gameModus"></see>
    /// </summary>
    let gameModus = Namespaced_IRI.parse _namespace_name "gameModus" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/games"></see>
    /// </summary>
    let games = Namespaced_IRI.parse _namespace_name "games" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/garrison"></see>
    /// </summary>
    let garrison = Namespaced_IRI.parse _namespace_name "garrison" |> NamespacedName
    /// <summary>
    /// Awards of the Catalan Academy of Cinema
    /// <see href="http://dbpedia.org/ontology/gaudiAward"></see></summary>
    let gaudiAward = Namespaced_IRI.parse _namespace_name "gaudiAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geminiAward"></see>
    /// </summary>
    let geminiAward =
        Namespaced_IRI.parse _namespace_name "geminiAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gender"></see>
    /// </summary>
    let gender = Namespaced_IRI.parse _namespace_name "gender" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geneLocation"></see>
    /// </summary>
    let geneLocation =
        Namespaced_IRI.parse _namespace_name "geneLocation" |> NamespacedName

    /// <summary>
    /// the end of the gene
    /// <see href="http://dbpedia.org/ontology/geneLocationEnd"></see></summary>
    let geneLocationEnd =
        Namespaced_IRI.parse _namespace_name "geneLocationEnd" |> NamespacedName

    /// <summary>
    /// the start of the gene coordinates
    /// <see href="http://dbpedia.org/ontology/geneLocationStart"></see></summary>
    let geneLocationStart =
        Namespaced_IRI.parse _namespace_name "geneLocationStart" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geneReviewsId"></see>
    /// </summary>
    let geneReviewsId =
        Namespaced_IRI.parse _namespace_name "geneReviewsId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geneReviewsName"></see>
    /// </summary>
    let geneReviewsName =
        Namespaced_IRI.parse _namespace_name "geneReviewsName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/generalCouncil"></see>
    /// </summary>
    let generalCouncil =
        Namespaced_IRI.parse _namespace_name "generalCouncil" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/generalManager"></see>
    /// </summary>
    let generalManager =
        Namespaced_IRI.parse _namespace_name "generalManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/generationUnits"></see>
    /// </summary>
    let generationUnits =
        Namespaced_IRI.parse _namespace_name "generationUnits" |> NamespacedName

    /// <summary>
    /// the edition of the database used (i.e. hg19)
    /// <see href="http://dbpedia.org/ontology/genomeDB"></see></summary>
    let genomeDB = Namespaced_IRI.parse _namespace_name "genomeDB" |> NamespacedName
    /// <summary>
    /// The genre of the thing (music group, film, etc.)
    /// <see href="http://dbpedia.org/ontology/genre"></see></summary>
    let genre = Namespaced_IRI.parse _namespace_name "genre" |> NamespacedName
    /// <summary>
    /// A rank in the classification of organisms, below family and above species; a taxon at that rank
    /// <see href="http://dbpedia.org/ontology/genus"></see></summary>
    let genus = Namespaced_IRI.parse _namespace_name "genus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geolocDepartment"></see>
    /// </summary>
    let geolocDepartment =
        Namespaced_IRI.parse _namespace_name "geolocDepartment" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geolocDual"></see>
    /// </summary>
    let geolocDual = Namespaced_IRI.parse _namespace_name "geolocDual" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geologicPeriod"></see>
    /// </summary>
    let geologicPeriod =
        Namespaced_IRI.parse _namespace_name "geologicPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/geology"></see>
    /// </summary>
    let geology = Namespaced_IRI.parse _namespace_name "geology" |> NamespacedName

    /// <summary>
    /// is a measure of the inequality of a distribution. It is commonly used as a measure of inequality of income or wealth.
    /// <see href="http://dbpedia.org/ontology/giniCoefficient"></see></summary>
    let giniCoefficient =
        Namespaced_IRI.parse _namespace_name "giniCoefficient" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/giniCoefficientAsOf"></see>
    /// </summary>
    let giniCoefficientAsOf =
        Namespaced_IRI.parse _namespace_name "giniCoefficientAsOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/giniCoefficientCategory"></see>
    /// </summary>
    let giniCoefficientCategory =
        Namespaced_IRI.parse _namespace_name "giniCoefficientCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/giniCoefficientRanking"></see>
    /// </summary>
    let giniCoefficientRanking =
        Namespaced_IRI.parse _namespace_name "giniCoefficientRanking" |> NamespacedName

    /// <summary>
    /// Indicates a Food's effect on a person's blood glucose (blood sugar) level. Typically ranges between 50 and 100, where 100 represents the standard, an equivalent amount of pure glucose
    /// <see href="http://dbpedia.org/ontology/glycemicIndex"></see></summary>
    let glycemicIndex =
        Namespaced_IRI.parse _namespace_name "glycemicIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gnisCode"></see>
    /// </summary>
    let gnisCode = Namespaced_IRI.parse _namespace_name "gnisCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gnl"></see>
    /// </summary>
    let gnl = Namespaced_IRI.parse _namespace_name "gnl" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goalsInLeague"></see>
    /// </summary>
    let goalsInLeague =
        Namespaced_IRI.parse _namespace_name "goalsInLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goalsInNationalTeam"></see>
    /// </summary>
    let goalsInNationalTeam =
        Namespaced_IRI.parse _namespace_name "goalsInNationalTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldMedalDouble"></see>
    /// </summary>
    let goldMedalDouble =
        Namespaced_IRI.parse _namespace_name "goldMedalDouble" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldMedalMixed"></see>
    /// </summary>
    let goldMedalMixed =
        Namespaced_IRI.parse _namespace_name "goldMedalMixed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldMedalSingle"></see>
    /// </summary>
    let goldMedalSingle =
        Namespaced_IRI.parse _namespace_name "goldMedalSingle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldMedalist"></see>
    /// </summary>
    let goldMedalist =
        Namespaced_IRI.parse _namespace_name "goldMedalist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldenCalfAward"></see>
    /// </summary>
    let goldenCalfAward =
        Namespaced_IRI.parse _namespace_name "goldenCalfAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldenGlobeAward"></see>
    /// </summary>
    let goldenGlobeAward =
        Namespaced_IRI.parse _namespace_name "goldenGlobeAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goldenRaspberryAward"></see>
    /// </summary>
    let goldenRaspberryAward =
        Namespaced_IRI.parse _namespace_name "goldenRaspberryAward" |> NamespacedName

    /// <summary>
    /// Body that owns/operates the Place.
    /// <see href="http://dbpedia.org/ontology/governingBody"></see></summary>
    let governingBody =
        Namespaced_IRI.parse _namespace_name "governingBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/government"></see>
    /// </summary>
    let government = Namespaced_IRI.parse _namespace_name "government" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governmentCountry"></see>
    /// </summary>
    let governmentCountry =
        Namespaced_IRI.parse _namespace_name "governmentCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governmentElevation"></see>
    /// </summary>
    let governmentElevation =
        Namespaced_IRI.parse _namespace_name "governmentElevation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governmentMountain"></see>
    /// </summary>
    let governmentMountain =
        Namespaced_IRI.parse _namespace_name "governmentMountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governmentPlace"></see>
    /// </summary>
    let governmentPlace =
        Namespaced_IRI.parse _namespace_name "governmentPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governmentPosition"></see>
    /// </summary>
    let governmentPosition =
        Namespaced_IRI.parse _namespace_name "governmentPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governmentRegion"></see>
    /// </summary>
    let governmentRegion =
        Namespaced_IRI.parse _namespace_name "governmentRegion" |> NamespacedName

    /// <summary>
    /// broadly, the type of structure of its government
    /// <see href="http://dbpedia.org/ontology/governmentType"></see></summary>
    let governmentType =
        Namespaced_IRI.parse _namespace_name "governmentType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governor"></see>
    /// </summary>
    let governor = Namespaced_IRI.parse _namespace_name "governor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governorGeneral"></see>
    /// </summary>
    let governorGeneral =
        Namespaced_IRI.parse _namespace_name "governorGeneral" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/governorate"></see>
    /// </summary>
    let governorate =
        Namespaced_IRI.parse _namespace_name "governorate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/goyaAward"></see>
    /// </summary>
    let goyaAward = Namespaced_IRI.parse _namespace_name "goyaAward" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grades"></see>
    /// </summary>
    let grades = Namespaced_IRI.parse _namespace_name "grades" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grammyAward"></see>
    /// </summary>
    let grammyAward =
        Namespaced_IRI.parse _namespace_name "grammyAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grandsire"></see>
    /// </summary>
    let grandsire = Namespaced_IRI.parse _namespace_name "grandsire" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grave"></see>
    /// </summary>
    let grave = Namespaced_IRI.parse _namespace_name "grave" |> NamespacedName
    /// <summary>
    /// Refers to the famous 1918 edition of Gray's Anatomy.
    /// <see href="http://dbpedia.org/ontology/grayPage"></see></summary>
    let grayPage = Namespaced_IRI.parse _namespace_name "grayPage" |> NamespacedName

    /// <summary>
    /// Refers to the famous 1918 edition of Gray's Anatomy.
    /// <see href="http://dbpedia.org/ontology/graySubject"></see></summary>
    let graySubject =
        Namespaced_IRI.parse _namespace_name "graySubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/greekName"></see>
    /// </summary>
    let greekName = Namespaced_IRI.parse _namespace_name "greekName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/greenLongDistancePisteNumber"></see>
    /// </summary>
    let greenLongDistancePisteNumber =
        Namespaced_IRI.parse _namespace_name "greenLongDistancePisteNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/greenSkiPisteNumber"></see>
    /// </summary>
    let greenSkiPisteNumber =
        Namespaced_IRI.parse _namespace_name "greenSkiPisteNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gridReference"></see>
    /// </summary>
    let gridReference =
        Namespaced_IRI.parse _namespace_name "gridReference" |> NamespacedName

    /// <summary>
    /// grinding capability for Mills
    /// <see href="http://dbpedia.org/ontology/grindingCapability"></see></summary>
    let grindingCapability =
        Namespaced_IRI.parse _namespace_name "grindingCapability" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gross"></see>
    /// </summary>
    let gross = Namespaced_IRI.parse _namespace_name "gross" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grossDomesticProduct"></see>
    /// </summary>
    let grossDomesticProduct =
        Namespaced_IRI.parse _namespace_name "grossDomesticProduct" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grossDomesticProductAsOf"></see>
    /// </summary>
    let grossDomesticProductAsOf =
        Namespaced_IRI.parse _namespace_name "grossDomesticProductAsOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grossDomesticProductNominalPerCapita"></see>
    /// </summary>
    let grossDomesticProductNominalPerCapita =
        Namespaced_IRI.parse _namespace_name "grossDomesticProductNominalPerCapita" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grossDomesticProductPerPeople"></see>
    /// </summary>
    let grossDomesticProductPerPeople =
        Namespaced_IRI.parse _namespace_name "grossDomesticProductPerPeople" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grossDomesticProductPurchasingPowerParityPerCapita"></see>
    /// </summary>
    let grossDomesticProductPurchasingPowerParityPerCapita =
        Namespaced_IRI.parse _namespace_name "grossDomesticProductPurchasingPowerParityPerCapita" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/grossDomesticProductRank"></see>
    /// </summary>
    let grossDomesticProductRank =
        Namespaced_IRI.parse _namespace_name "grossDomesticProductRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ground"></see>
    /// </summary>
    let ground = Namespaced_IRI.parse _namespace_name "ground" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/groundsForLiquidation"></see>
    /// </summary>
    let groundsForLiquidation =
        Namespaced_IRI.parse _namespace_name "groundsForLiquidation" |> NamespacedName

    /// <summary>
    /// Designates the category of people commemorated by a monument
    /// <see href="http://dbpedia.org/ontology/groupCommemorated"></see></summary>
    let groupCommemorated =
        Namespaced_IRI.parse _namespace_name "groupCommemorated" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/growingGrape"></see>
    /// </summary>
    let growingGrape =
        Namespaced_IRI.parse _namespace_name "growingGrape" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/guest"></see>
    /// </summary>
    let guest = Namespaced_IRI.parse _namespace_name "guest" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gun"></see>
    /// </summary>
    let gun = Namespaced_IRI.parse _namespace_name "gun" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/gymApparatus"></see>
    /// </summary>
    let gymApparatus =
        Namespaced_IRI.parse _namespace_name "gymApparatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hairColor"></see>
    /// </summary>
    let hairColor = Namespaced_IRI.parse _namespace_name "hairColor" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hairColour"></see>
    /// </summary>
    let hairColour = Namespaced_IRI.parse _namespace_name "hairColour" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hairs"></see>
    /// </summary>
    let hairs = Namespaced_IRI.parse _namespace_name "hairs" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hallOfFame"></see>
    /// </summary>
    let hallOfFame = Namespaced_IRI.parse _namespace_name "hallOfFame" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hand"></see>
    /// </summary>
    let hand = Namespaced_IRI.parse _namespace_name "hand" |> NamespacedName
    /// <summary>
    /// an attribute of humans defined by their unequal distribution of fine motor skill between the left and right hands.
    /// <see href="http://dbpedia.org/ontology/handedness"></see></summary>
    let handedness = Namespaced_IRI.parse _namespace_name "handedness" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/handisport"></see>
    /// </summary>
    let handisport = Namespaced_IRI.parse _namespace_name "handisport" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasAbsorbedMunicipality"></see>
    /// </summary>
    let hasAbsorbedMunicipality =
        Namespaced_IRI.parse _namespace_name "hasAbsorbedMunicipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasAnnotation"></see>
    /// </summary>
    let hasAnnotation =
        Namespaced_IRI.parse _namespace_name "hasAnnotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasChannel"></see>
    /// </summary>
    let hasChannel = Namespaced_IRI.parse _namespace_name "hasChannel" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasInput"></see>
    /// </summary>
    let hasInput = Namespaced_IRI.parse _namespace_name "hasInput" |> NamespacedName

    /// <summary>
    /// indicates another place situated inside.
    /// <see href="http://dbpedia.org/ontology/hasInsidePlace"></see></summary>
    let hasInsidePlace =
        Namespaced_IRI.parse _namespace_name "hasInsidePlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasJunctionWith"></see>
    /// </summary>
    let hasJunctionWith =
        Namespaced_IRI.parse _namespace_name "hasJunctionWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasKMLData"></see>
    /// </summary>
    let hasKMLData = Namespaced_IRI.parse _namespace_name "hasKMLData" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hasNaturalBust"></see>
    /// </summary>
    let hasNaturalBust =
        Namespaced_IRI.parse _namespace_name "hasNaturalBust" |> NamespacedName

    /// <summary>
    /// indicates another place situated around outside.
    /// <see href="http://dbpedia.org/ontology/hasOutsidePlace"></see></summary>
    let hasOutsidePlace =
        Namespaced_IRI.parse _namespace_name "hasOutsidePlace" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/hasSurfaceForm"></see></summary>
    let hasSurfaceForm =
        Namespaced_IRI.parse _namespace_name "hasSurfaceForm" |> NamespacedName

    /// <summary>
    /// variant or variation, for example all variations of a color
    /// <see href="http://dbpedia.org/ontology/hasVariant"></see></summary>
    let hasVariant = Namespaced_IRI.parse _namespace_name "hasVariant" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/head"></see>
    /// </summary>
    let head = Namespaced_IRI.parse _namespace_name "head" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/headAlloy"></see>
    /// </summary>
    let headAlloy = Namespaced_IRI.parse _namespace_name "headAlloy" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/headChef"></see>
    /// </summary>
    let headChef = Namespaced_IRI.parse _namespace_name "headChef" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/headLabel"></see>
    /// </summary>
    let headLabel = Namespaced_IRI.parse _namespace_name "headLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/headOfFamily"></see>
    /// </summary>
    let headOfFamily =
        Namespaced_IRI.parse _namespace_name "headOfFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/headquarter"></see>
    /// </summary>
    let headquarter =
        Namespaced_IRI.parse _namespace_name "headquarter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/headteacher"></see>
    /// </summary>
    let headteacher =
        Namespaced_IRI.parse _namespace_name "headteacher" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/height"></see>
    /// </summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/heightAboveAverageTerrain"></see>
    /// </summary>
    let heightAboveAverageTerrain =
        Namespaced_IRI.parse _namespace_name "heightAboveAverageTerrain" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/heightAgainst"></see>
    /// </summary>
    let heightAgainst =
        Namespaced_IRI.parse _namespace_name "heightAgainst" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/heightAttack"></see>
    /// </summary>
    let heightAttack =
        Namespaced_IRI.parse _namespace_name "heightAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/heir"></see>
    /// </summary>
    let heir = Namespaced_IRI.parse _namespace_name "heir" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/heisman"></see>
    /// </summary>
    let heisman = Namespaced_IRI.parse _namespace_name "heisman" |> NamespacedName

    /// <summary>
    /// registered in a heritage register : inventory of cultural properties, natural and man-made, tangible and intangible, movable and immovable, that are deemed to be of sufficient heritage value to be separately identified and recorded.
    /// <see href="http://dbpedia.org/ontology/heritageRegister"></see></summary>
    let heritageRegister =
        Namespaced_IRI.parse _namespace_name "heritageRegister" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hgncid"></see>
    /// </summary>
    let hgncid = Namespaced_IRI.parse _namespace_name "hgncid" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestBreak"></see>
    /// </summary>
    let highestBreak =
        Namespaced_IRI.parse _namespace_name "highestBreak" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestBuildingInYear"></see>
    /// </summary>
    let highestBuildingInYear =
        Namespaced_IRI.parse _namespace_name "highestBuildingInYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestMountain"></see>
    /// </summary>
    let highestMountain =
        Namespaced_IRI.parse _namespace_name "highestMountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestPlace"></see>
    /// </summary>
    let highestPlace =
        Namespaced_IRI.parse _namespace_name "highestPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestPoint"></see>
    /// </summary>
    let highestPoint =
        Namespaced_IRI.parse _namespace_name "highestPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestPointIsland"></see>
    /// </summary>
    let highestPointIsland =
        Namespaced_IRI.parse _namespace_name "highestPointIsland" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestPosition"></see>
    /// </summary>
    let highestPosition =
        Namespaced_IRI.parse _namespace_name "highestPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestRank"></see>
    /// </summary>
    let highestRank =
        Namespaced_IRI.parse _namespace_name "highestRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestRegion"></see>
    /// </summary>
    let highestRegion =
        Namespaced_IRI.parse _namespace_name "highestRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highestState"></see>
    /// </summary>
    let highestState =
        Namespaced_IRI.parse _namespace_name "highestState" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/highschool"></see>
    /// </summary>
    let highschool = Namespaced_IRI.parse _namespace_name "highschool" |> NamespacedName

    /// <summary>
    /// the highway system that a route is part of
    /// <see href="http://dbpedia.org/ontology/highwaySystem"></see></summary>
    let highwaySystem =
        Namespaced_IRI.parse _namespace_name "highwaySystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hipSize"></see>
    /// </summary>
    let hipSize = Namespaced_IRI.parse _namespace_name "hipSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/historicalMap"></see>
    /// </summary>
    let historicalMap =
        Namespaced_IRI.parse _namespace_name "historicalMap" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/historicalName"></see>
    /// </summary>
    let historicalName =
        Namespaced_IRI.parse _namespace_name "historicalName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/historicalRegion"></see>
    /// </summary>
    let historicalRegion =
        Namespaced_IRI.parse _namespace_name "historicalRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hof"></see>
    /// </summary>
    let hof = Namespaced_IRI.parse _namespace_name "hof" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/homage"></see>
    /// </summary>
    let homage = Namespaced_IRI.parse _namespace_name "homage" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/homeArena"></see>
    /// </summary>
    let homeArena = Namespaced_IRI.parse _namespace_name "homeArena" |> NamespacedName

    /// <summary>
    /// A colour represented by its hex code (e.g.: #FF0000 or #40E0D0).
    /// <see href="http://dbpedia.org/ontology/homeColourHexCode"></see></summary>
    let homeColourHexCode =
        Namespaced_IRI.parse _namespace_name "homeColourHexCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/homeStadium"></see>
    /// </summary>
    let homeStadium =
        Namespaced_IRI.parse _namespace_name "homeStadium" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/homeport"></see>
    /// </summary>
    let homeport = Namespaced_IRI.parse _namespace_name "homeport" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hometown"></see>
    /// </summary>
    let hometown = Namespaced_IRI.parse _namespace_name "hometown" |> NamespacedName
    /// <summary>
    /// Honours bestowed upon a Person, Organization, RaceHorse, etc
    /// <see href="http://dbpedia.org/ontology/honours"></see></summary>
    let honours = Namespaced_IRI.parse _namespace_name "honours" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hopmanCup"></see>
    /// </summary>
    let hopmanCup = Namespaced_IRI.parse _namespace_name "hopmanCup" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/horseRidingDiscipline"></see>
    /// </summary>
    let horseRidingDiscipline =
        Namespaced_IRI.parse _namespace_name "horseRidingDiscipline" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/house"></see>
    /// </summary>
    let house = Namespaced_IRI.parse _namespace_name "house" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hraState"></see>
    /// </summary>
    let hraState = Namespaced_IRI.parse _namespace_name "hraState" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hsvCoordinateHue"></see>
    /// </summary>
    let hsvCoordinateHue =
        Namespaced_IRI.parse _namespace_name "hsvCoordinateHue" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hsvCoordinateSaturation"></see>
    /// </summary>
    let hsvCoordinateSaturation =
        Namespaced_IRI.parse _namespace_name "hsvCoordinateSaturation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hsvCoordinateValue"></see>
    /// </summary>
    let hsvCoordinateValue =
        Namespaced_IRI.parse _namespace_name "hsvCoordinateValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/hubAirport"></see>
    /// </summary>
    let hubAirport = Namespaced_IRI.parse _namespace_name "hubAirport" |> NamespacedName

    /// <summary>
    /// a composite statistic used to rank countries by level of "human development"
    /// <see href="http://dbpedia.org/ontology/humanDevelopmentIndex"></see></summary>
    let humanDevelopmentIndex =
        Namespaced_IRI.parse _namespace_name "humanDevelopmentIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/humanDevelopmentIndexAsOf"></see>
    /// </summary>
    let humanDevelopmentIndexAsOf =
        Namespaced_IRI.parse _namespace_name "humanDevelopmentIndexAsOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/humanDevelopmentIndexRank"></see>
    /// </summary>
    let humanDevelopmentIndexRank =
        Namespaced_IRI.parse _namespace_name "humanDevelopmentIndexRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/humanDevelopmentIndexRankingCategory"></see>
    /// </summary>
    let humanDevelopmentIndexRankingCategory =
        Namespaced_IRI.parse _namespace_name "humanDevelopmentIndexRankingCategory" |> NamespacedName

    /// <summary>
    /// Plants from which another plant (or cultivar) has been developed from
    /// <see href="http://dbpedia.org/ontology/hybrid"></see></summary>
    let hybrid = Namespaced_IRI.parse _namespace_name "hybrid" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iafdId"></see>
    /// </summary>
    let iafdId = Namespaced_IRI.parse _namespace_name "iafdId" |> NamespacedName

    /// <summary>
    /// IATA designation for airline companies
    /// <see href="http://dbpedia.org/ontology/iataAirlineCode"></see></summary>
    let iataAirlineCode =
        Namespaced_IRI.parse _namespace_name "iataAirlineCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iataLocationIdentifier"></see>
    /// </summary>
    let iataLocationIdentifier =
        Namespaced_IRI.parse _namespace_name "iataLocationIdentifier" |> NamespacedName

    /// <summary>
    /// The Internet Broadway Database ID (IBDB ID) from ibdb.com.
    /// <see href="http://dbpedia.org/ontology/ibdbId"></see></summary>
    let ibdbId = Namespaced_IRI.parse _namespace_name "ibdbId" |> NamespacedName

    /// <summary>
    /// ICAO designation for airline companies
    /// <see href="http://dbpedia.org/ontology/icaoAirlineCode"></see></summary>
    let icaoAirlineCode =
        Namespaced_IRI.parse _namespace_name "icaoAirlineCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/icaoLocationIdentifier"></see>
    /// </summary>
    let icaoLocationIdentifier =
        Namespaced_IRI.parse _namespace_name "icaoLocationIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/icd1"></see>
    /// </summary>
    let icd1 = Namespaced_IRI.parse _namespace_name "icd1" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/icd10"></see>
    /// </summary>
    let icd10 = Namespaced_IRI.parse _namespace_name "icd10" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/icd9"></see>
    /// </summary>
    let icd9 = Namespaced_IRI.parse _namespace_name "icd9" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/icdo"></see>
    /// </summary>
    let icdo = Namespaced_IRI.parse _namespace_name "icdo" |> NamespacedName

    /// <summary>
    /// Standard iconographic elements used when depicting a Saint: pontifical, episcopal, insignia, martyrdom instruments
    /// <see href="http://dbpedia.org/ontology/iconographicAttributes"></see></summary>
    let iconographicAttributes =
        Namespaced_IRI.parse _namespace_name "iconographicAttributes" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/id"></see>
    /// </summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName
    /// <summary>
    /// ID of a film on Allocine
    /// <see href="http://dbpedia.org/ontology/idAllocine"></see></summary>
    let idAllocine = Namespaced_IRI.parse _namespace_name "idAllocine" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/idNumber"></see>
    /// </summary>
    let idNumber = Namespaced_IRI.parse _namespace_name "idNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/identificationSymbol"></see>
    /// </summary>
    let identificationSymbol =
        Namespaced_IRI.parse _namespace_name "identificationSymbol" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ideology"></see>
    /// </summary>
    let ideology = Namespaced_IRI.parse _namespace_name "ideology" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iftaAward"></see>
    /// </summary>
    let iftaAward = Namespaced_IRI.parse _namespace_name "iftaAward" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iihfHof"></see>
    /// </summary>
    let iihfHof = Namespaced_IRI.parse _namespace_name "iihfHof" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/illiteracy"></see>
    /// </summary>
    let illiteracy = Namespaced_IRI.parse _namespace_name "illiteracy" |> NamespacedName

    /// <summary>
    /// Illustrator (where used throughout and a major feature)
    /// <see href="http://dbpedia.org/ontology/illustrator"></see></summary>
    let illustrator =
        Namespaced_IRI.parse _namespace_name "illustrator" |> NamespacedName

    /// <summary>
    /// the image size expressed in pixels
    /// <see href="http://dbpedia.org/ontology/imageSize"></see></summary>
    let imageSize = Namespaced_IRI.parse _namespace_name "imageSize" |> NamespacedName
    /// <summary>
    /// International Movie Database ID. Applies to Films, Actors, etc
    /// <see href="http://dbpedia.org/ontology/imdbId"></see></summary>
    let imdbId = Namespaced_IRI.parse _namespace_name "imdbId" |> NamespacedName

    /// <summary>
    /// The impact factor, often abbreviated IF, is a measure reflecting the average number of citations to articles published in science and social science journals.
    /// <see href="http://dbpedia.org/ontology/impactFactor"></see></summary>
    let impactFactor =
        Namespaced_IRI.parse _namespace_name "impactFactor" |> NamespacedName

    /// <summary>
    /// Census year of the imapct factor.
    /// <see href="http://dbpedia.org/ontology/impactFactorAsOf"></see></summary>
    let impactFactorAsOf =
        Namespaced_IRI.parse _namespace_name "impactFactorAsOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/imposedDanseCompetition"></see>
    /// </summary>
    let imposedDanseCompetition =
        Namespaced_IRI.parse _namespace_name "imposedDanseCompetition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/imposedDanseScore"></see>
    /// </summary>
    let imposedDanseScore =
        Namespaced_IRI.parse _namespace_name "imposedDanseScore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/inCemetery"></see>
    /// </summary>
    let inCemetery = Namespaced_IRI.parse _namespace_name "inCemetery" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/inchi"></see>
    /// </summary>
    let inchi = Namespaced_IRI.parse _namespace_name "inchi" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/inclination"></see>
    /// </summary>
    let inclination =
        Namespaced_IRI.parse _namespace_name "inclination" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/income"></see>
    /// </summary>
    let income = Namespaced_IRI.parse _namespace_name "income" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/incumbent"></see>
    /// </summary>
    let incumbent = Namespaced_IRI.parse _namespace_name "incumbent" |> NamespacedName

    /// <summary>
    /// GND (Gemeinsame Normdatei) is an international authority file for the organisation of personal names, subject headings and corporate bodies from catalogues. It is used mainly for documentation in libraries and archives. The GND is managed by the German National Library in cooperation with various library networks. The GND falls under the Creative Commons Zero(CC0) license.
    /// <see href="http://dbpedia.org/ontology/individualisedGnd"></see></summary>
    let individualisedGnd =
        Namespaced_IRI.parse _namespace_name "individualisedGnd" |> NamespacedName

    /// <summary>
    /// PND (Personennamendatei) data about a person. PND is published by the German National Library. For each person there is a record with her/his name, birth and occupation connected with a unique identifier, the PND number.
    /// <see href="http://dbpedia.org/ontology/individualisedPnd"></see></summary>
    let individualisedPnd =
        Namespaced_IRI.parse _namespace_name "individualisedPnd" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/industry"></see>
    /// </summary>
    let industry = Namespaced_IRI.parse _namespace_name "industry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/infantMortality"></see>
    /// </summary>
    let infantMortality =
        Namespaced_IRI.parse _namespace_name "infantMortality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/inflow"></see>
    /// </summary>
    let inflow = Namespaced_IRI.parse _namespace_name "inflow" |> NamespacedName
    /// <summary>
    /// The subject influenced the object. inverseOf influencedBy. Subject and object can be Persons or Works (eg ProgrammingLanguage)
    /// <see href="http://dbpedia.org/ontology/influenced"></see></summary>
    let influenced = Namespaced_IRI.parse _namespace_name "influenced" |> NamespacedName

    /// <summary>
    /// The subject was influenced by the object. inverseOf influenced. Subject and object can be Persons or Works (eg ProgrammingLanguage)
    /// <see href="http://dbpedia.org/ontology/influencedBy"></see></summary>
    let influencedBy =
        Namespaced_IRI.parse _namespace_name "influencedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/information"></see>
    /// </summary>
    let information =
        Namespaced_IRI.parse _namespace_name "information" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/informationName"></see>
    /// </summary>
    let informationName =
        Namespaced_IRI.parse _namespace_name "informationName" |> NamespacedName

    /// <summary>
    /// Main ingredient used to prepare a specific Food or Beverage. For strings use ingredientName, for objects use ingredient.
    /// <see href="http://dbpedia.org/ontology/ingredient"></see></summary>
    let ingredient = Namespaced_IRI.parse _namespace_name "ingredient" |> NamespacedName

    /// <summary>
    /// Main ingredient used to prepare a specific Food or Beverage. For strings use ingredientName, for objects use ingredient.
    /// <see href="http://dbpedia.org/ontology/ingredientName"></see></summary>
    let ingredientName =
        Namespaced_IRI.parse _namespace_name "ingredientName" |> NamespacedName

    /// <summary>
    /// Initial use of the architectural structure.
    /// <see href="http://dbpedia.org/ontology/initiallyUsedFor"></see></summary>
    let initiallyUsedFor =
        Namespaced_IRI.parse _namespace_name "initiallyUsedFor" |> NamespacedName

    /// <summary>
    /// International Nonproprietary Name given to a pharmaceutical substance
    /// <see href="http://dbpedia.org/ontology/inn"></see></summary>
    let inn = Namespaced_IRI.parse _namespace_name "inn" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/innervates"></see>
    /// </summary>
    let innervates = Namespaced_IRI.parse _namespace_name "innervates" |> NamespacedName

    /// <summary>
    /// Text of an inscription on the object
    /// <see href="http://dbpedia.org/ontology/inscription"></see></summary>
    let inscription =
        Namespaced_IRI.parse _namespace_name "inscription" |> NamespacedName

    /// <summary>
    /// numerical indexing code used by the French National Institute for Statistics and Economic Studies (INSEE) to identify various entities
    /// <see href="http://dbpedia.org/ontology/inseeCode"></see></summary>
    let inseeCode = Namespaced_IRI.parse _namespace_name "inseeCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/installedCapacity"></see>
    /// </summary>
    let installedCapacity =
        Namespaced_IRI.parse _namespace_name "installedCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/institution"></see>
    /// </summary>
    let institution =
        Namespaced_IRI.parse _namespace_name "institution" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/instrument"></see>
    /// </summary>
    let instrument = Namespaced_IRI.parse _namespace_name "instrument" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/intercommunality"></see>
    /// </summary>
    let intercommunality =
        Namespaced_IRI.parse _namespace_name "intercommunality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/interest"></see>
    /// </summary>
    let interest = Namespaced_IRI.parse _namespace_name "interest" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/internationalAffiliation"></see>
    /// </summary>
    let internationalAffiliation =
        Namespaced_IRI.parse _namespace_name "internationalAffiliation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/internationalPhonePrefix"></see>
    /// </summary>
    let internationalPhonePrefix =
        Namespaced_IRI.parse _namespace_name "internationalPhonePrefix" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/internationalPhonePrefixLabel"></see>
    /// </summary>
    let internationalPhonePrefixLabel =
        Namespaced_IRI.parse _namespace_name "internationalPhonePrefixLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/internationally"></see>
    /// </summary>
    let internationally =
        Namespaced_IRI.parse _namespace_name "internationally" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/introduced"></see>
    /// </summary>
    let introduced = Namespaced_IRI.parse _namespace_name "introduced" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/introductionDate"></see>
    /// </summary>
    let introductionDate =
        Namespaced_IRI.parse _namespace_name "introductionDate" |> NamespacedName

    /// <summary>
    /// Lortel Archives Internet Off-Broadway database "show id" from lortel.org.
    /// <see href="http://dbpedia.org/ontology/iobdbId"></see></summary>
    let iobdbId = Namespaced_IRI.parse _namespace_name "iobdbId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isCityState"></see>
    /// </summary>
    let isCityState =
        Namespaced_IRI.parse _namespace_name "isCityState" |> NamespacedName

    /// <summary>
    /// True if the station is handicapped accessible.
    /// <see href="http://dbpedia.org/ontology/isHandicappedAccessible"></see></summary>
    let isHandicappedAccessible =
        Namespaced_IRI.parse _namespace_name "isHandicappedAccessible" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isPartOf"></see>
    /// </summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isPartOfAnatomicalStructure"></see>
    /// </summary>
    let isPartOfAnatomicalStructure =
        Namespaced_IRI.parse _namespace_name "isPartOfAnatomicalStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isPartOfMilitaryConflict"></see>
    /// </summary>
    let isPartOfMilitaryConflict =
        Namespaced_IRI.parse _namespace_name "isPartOfMilitaryConflict" |> NamespacedName

    /// <summary>
    /// Name of another thing that this thing is part of. Use for infobox "part of" properties given as text; for objects use isPartOf
    /// <see href="http://dbpedia.org/ontology/isPartOfName"></see></summary>
    let isPartOfName =
        Namespaced_IRI.parse _namespace_name "isPartOfName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isPartOfWineRegion"></see>
    /// </summary>
    let isPartOfWineRegion =
        Namespaced_IRI.parse _namespace_name "isPartOfWineRegion" |> NamespacedName

    /// <summary>
    /// In academia peer review is often used to determine an academic papers suitability for publication.
    /// <see href="http://dbpedia.org/ontology/isPeerReviewed"></see></summary>
    let isPeerReviewed =
        Namespaced_IRI.parse _namespace_name "isPeerReviewed" |> NamespacedName

    /// <summary>
    /// indicate a place is a stop on a road.
    /// <see href="http://dbpedia.org/ontology/isRouteStop"></see></summary>
    let isRouteStop =
        Namespaced_IRI.parse _namespace_name "isRouteStop" |> NamespacedName

    /// <summary>
    /// The International Standard Book Number (ISBN) is a unique numeric commercial book identifier based upon the 9-digit Standard Book Numbering (SBN) code.
    /// <see href="http://dbpedia.org/ontology/isbn"></see></summary>
    let isbn = Namespaced_IRI.parse _namespace_name "isbn" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isil"></see>
    /// </summary>
    let isil = Namespaced_IRI.parse _namespace_name "isil" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/island"></see>
    /// </summary>
    let island = Namespaced_IRI.parse _namespace_name "island" |> NamespacedName
    /// <summary>
    /// ISNI is a method for uniquely identifying the public identities of contributors to media content such as books, TV programmes, and newspaper articles.
    /// <see href="http://dbpedia.org/ontology/isniId"></see></summary>
    let isniId = Namespaced_IRI.parse _namespace_name "isniId" |> NamespacedName

    /// <summary>
    /// defines codes for the names of countries, dependent territories, and special areas of geographical interest
    /// <see href="http://dbpedia.org/ontology/iso31661Code"></see></summary>
    let iso31661Code =
        Namespaced_IRI.parse _namespace_name "iso31661Code" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iso6391Code"></see>
    /// </summary>
    let iso6391Code =
        Namespaced_IRI.parse _namespace_name "iso6391Code" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LanguageCode"></see>
    /// </summary>
    let LanguageCode =
        Namespaced_IRI.parse _namespace_name "LanguageCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iso6392Code"></see>
    /// </summary>
    let iso6392Code =
        Namespaced_IRI.parse _namespace_name "iso6392Code" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iso6393Code"></see>
    /// </summary>
    let iso6393Code =
        Namespaced_IRI.parse _namespace_name "iso6393Code" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/isoCodeRegion"></see>
    /// </summary>
    let isoCodeRegion =
        Namespaced_IRI.parse _namespace_name "isoCodeRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/issDockings"></see>
    /// </summary>
    let issDockings =
        Namespaced_IRI.parse _namespace_name "issDockings" |> NamespacedName

    /// <summary>
    /// International Standard Serial Number (ISSN)
    /// <see href="http://dbpedia.org/ontology/issn"></see></summary>
    let issn = Namespaced_IRI.parse _namespace_name "issn" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ist"></see>
    /// </summary>
    let ist = Namespaced_IRI.parse _namespace_name "ist" |> NamespacedName
    /// <summary>
    /// Indexing code used for Italian municipalities
    /// <see href="http://dbpedia.org/ontology/istat"></see></summary>
    let istat = Namespaced_IRI.parse _namespace_name "istat" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ithfDate"></see>
    /// </summary>
    let ithfDate = Namespaced_IRI.parse _namespace_name "ithfDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iucnCategory"></see>
    /// </summary>
    let iucnCategory =
        Namespaced_IRI.parse _namespace_name "iucnCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/iupacName"></see>
    /// </summary>
    let iupacName = Namespaced_IRI.parse _namespace_name "iupacName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/jockey"></see>
    /// </summary>
    let jockey = Namespaced_IRI.parse _namespace_name "jockey" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/jointCommunity"></see>
    /// </summary>
    let jointCommunity =
        Namespaced_IRI.parse _namespace_name "jointCommunity" |> NamespacedName

    /// <summary>
    /// JSTOR number (short for Journal Storage) is a United States-based online system number for archiving academic journals.
    /// <see href="http://dbpedia.org/ontology/jstor"></see></summary>
    let jstor = Namespaced_IRI.parse _namespace_name "jstor" |> NamespacedName
    /// <summary>
    /// leading judge
    /// <see href="http://dbpedia.org/ontology/judge"></see></summary>
    let judge = Namespaced_IRI.parse _namespace_name "judge" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/juniorSeason"></see>
    /// </summary>
    let juniorSeason =
        Namespaced_IRI.parse _namespace_name "juniorSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/juniorTeam"></see>
    /// </summary>
    let juniorTeam = Namespaced_IRI.parse _namespace_name "juniorTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/juniorYearsEndYear"></see>
    /// </summary>
    let juniorYearsEndYear =
        Namespaced_IRI.parse _namespace_name "juniorYearsEndYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/juniorYearsStartYear"></see>
    /// </summary>
    let juniorYearsStartYear =
        Namespaced_IRI.parse _namespace_name "juniorYearsStartYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/jureLanguage"></see>
    /// </summary>
    let jureLanguage =
        Namespaced_IRI.parse _namespace_name "jureLanguage" |> NamespacedName

    /// <summary>
    /// Jurisdiction is the practical authority granted to a formally constituted legal body or to a political leader to deal with and make pronouncements on legal matters and, by implication, to administer justice within a defined area of responsibility.
    /// <see href="http://dbpedia.org/ontology/jurisdiction"></see></summary>
    let jurisdiction =
        Namespaced_IRI.parse _namespace_name "jurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/jutsu"></see>
    /// </summary>
    let jutsu = Namespaced_IRI.parse _namespace_name "jutsu" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/khlDraft"></see>
    /// </summary>
    let khlDraft = Namespaced_IRI.parse _namespace_name "khlDraft" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/khlDraftTeam"></see>
    /// </summary>
    let khlDraftTeam =
        Namespaced_IRI.parse _namespace_name "khlDraftTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/khlDraftYear"></see>
    /// </summary>
    let khlDraftYear =
        Namespaced_IRI.parse _namespace_name "khlDraftYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/killedBy"></see>
    /// </summary>
    let killedBy = Namespaced_IRI.parse _namespace_name "killedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/kinOfLanguage"></see>
    /// </summary>
    let kinOfLanguage =
        Namespaced_IRI.parse _namespace_name "kinOfLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/kindOfCoordinate"></see>
    /// </summary>
    let kindOfCoordinate =
        Namespaced_IRI.parse _namespace_name "kindOfCoordinate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/kindOfCriminal"></see>
    /// </summary>
    let kindOfCriminal =
        Namespaced_IRI.parse _namespace_name "kindOfCriminal" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/kindOfCriminalAction"></see>
    /// </summary>
    let kindOfCriminalAction =
        Namespaced_IRI.parse _namespace_name "kindOfCriminalAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/kindOfRock"></see>
    /// </summary>
    let kindOfRock = Namespaced_IRI.parse _namespace_name "kindOfRock" |> NamespacedName
    /// <summary>
    /// In biology, kingdom (Latin: regnum, pl. regna) is a taxonomic rank, which is either the highest rank or in the more recent three-domain system, the rank below domain.
    /// <see href="http://dbpedia.org/ontology/kingdom"></see></summary>
    let kingdom = Namespaced_IRI.parse _namespace_name "kingdom" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/knownFor"></see>
    /// </summary>
    let knownFor = Namespaced_IRI.parse _namespace_name "knownFor" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ko"></see>
    /// </summary>
    let ko = Namespaced_IRI.parse _namespace_name "ko" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lahHof"></see>
    /// </summary>
    let lahHof = Namespaced_IRI.parse _namespace_name "lahHof" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lake"></see>
    /// </summary>
    let lake = Namespaced_IRI.parse _namespace_name "lake" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/land"></see>
    /// </summary>
    let land_ = Namespaced_IRI.parse _namespace_name "land" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landArea"></see>
    /// </summary>
    let landArea = Namespaced_IRI.parse _namespace_name "landArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landPercentage"></see>
    /// </summary>
    let landPercentage =
        Namespaced_IRI.parse _namespace_name "landPercentage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landRegistryCode"></see>
    /// </summary>
    let landRegistryCode =
        Namespaced_IRI.parse _namespace_name "landRegistryCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landeshauptmann"></see>
    /// </summary>
    let landeshauptmann =
        Namespaced_IRI.parse _namespace_name "landeshauptmann" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landingDate"></see>
    /// </summary>
    let landingDate =
        Namespaced_IRI.parse _namespace_name "landingDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landingSite"></see>
    /// </summary>
    let landingSite =
        Namespaced_IRI.parse _namespace_name "landingSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landingVehicle"></see>
    /// </summary>
    let landingVehicle =
        Namespaced_IRI.parse _namespace_name "landingVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landskap"></see>
    /// </summary>
    let landskap = Namespaced_IRI.parse _namespace_name "landskap" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landtag"></see>
    /// </summary>
    let landtag = Namespaced_IRI.parse _namespace_name "landtag" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/landtagMandate"></see>
    /// </summary>
    let landtagMandate =
        Namespaced_IRI.parse _namespace_name "landtagMandate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/languageCode"></see>
    /// </summary>
    let languageCode =
        Namespaced_IRI.parse _namespace_name "languageCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/languageFamily"></see>
    /// </summary>
    let languageFamily =
        Namespaced_IRI.parse _namespace_name "languageFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/languageRegulator"></see>
    /// </summary>
    let languageRegulator =
        Namespaced_IRI.parse _namespace_name "languageRegulator" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/largestCity"></see>
    /// </summary>
    let largestCity =
        Namespaced_IRI.parse _namespace_name "largestCity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/largestMetro"></see>
    /// </summary>
    let largestMetro =
        Namespaced_IRI.parse _namespace_name "largestMetro" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/largestSettlement"></see>
    /// </summary>
    let largestSettlement =
        Namespaced_IRI.parse _namespace_name "largestSettlement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/largestWin"></see>
    /// </summary>
    let largestWin = Namespaced_IRI.parse _namespace_name "largestWin" |> NamespacedName

    /// <summary>
    /// The date on which the broadcaster made its last broadcast.
    /// <see href="http://dbpedia.org/ontology/lastAirDate"></see></summary>
    let lastAirDate =
        Namespaced_IRI.parse _namespace_name "lastAirDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastAppearance"></see>
    /// </summary>
    let lastAppearance =
        Namespaced_IRI.parse _namespace_name "lastAppearance" |> NamespacedName

    /// <summary>
    /// The last election date for the house.
    /// <see href="http://dbpedia.org/ontology/lastElectionDate"></see></summary>
    let lastElectionDate =
        Namespaced_IRI.parse _namespace_name "lastElectionDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastFamilyMember"></see>
    /// </summary>
    let lastFamilyMember =
        Namespaced_IRI.parse _namespace_name "lastFamilyMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastFlight"></see>
    /// </summary>
    let lastFlight = Namespaced_IRI.parse _namespace_name "lastFlight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastFlightEndDate"></see>
    /// </summary>
    let lastFlightEndDate =
        Namespaced_IRI.parse _namespace_name "lastFlightEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastFlightStartDate"></see>
    /// </summary>
    let lastFlightStartDate =
        Namespaced_IRI.parse _namespace_name "lastFlightStartDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastLaunch"></see>
    /// </summary>
    let lastLaunch = Namespaced_IRI.parse _namespace_name "lastLaunch" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastLaunchDate"></see>
    /// </summary>
    let lastLaunchDate =
        Namespaced_IRI.parse _namespace_name "lastLaunchDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastLaunchRocket"></see>
    /// </summary>
    let lastLaunchRocket =
        Namespaced_IRI.parse _namespace_name "lastLaunchRocket" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastPosition"></see>
    /// </summary>
    let lastPosition =
        Namespaced_IRI.parse _namespace_name "lastPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastProMatch"></see>
    /// </summary>
    let lastProMatch =
        Namespaced_IRI.parse _namespace_name "lastProMatch" |> NamespacedName

    /// <summary>
    /// Date of the last publication.
    /// <see href="http://dbpedia.org/ontology/lastPublicationDate"></see></summary>
    let lastPublicationDate =
        Namespaced_IRI.parse _namespace_name "lastPublicationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastRace"></see>
    /// </summary>
    let lastRace = Namespaced_IRI.parse _namespace_name "lastRace" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastSeason"></see>
    /// </summary>
    let lastSeason = Namespaced_IRI.parse _namespace_name "lastSeason" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lastWin"></see>
    /// </summary>
    let lastWin = Namespaced_IRI.parse _namespace_name "lastWin" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/laterality"></see>
    /// </summary>
    let laterality = Namespaced_IRI.parse _namespace_name "laterality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/latestElection"></see>
    /// </summary>
    let latestElection =
        Namespaced_IRI.parse _namespace_name "latestElection" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/latestPreviewDate"></see>
    /// </summary>
    let latestPreviewDate =
        Namespaced_IRI.parse _namespace_name "latestPreviewDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/latestPreviewVersion"></see>
    /// </summary>
    let latestPreviewVersion =
        Namespaced_IRI.parse _namespace_name "latestPreviewVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/latestReleaseDate"></see>
    /// </summary>
    let latestReleaseDate =
        Namespaced_IRI.parse _namespace_name "latestReleaseDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/latestReleaseVersion"></see>
    /// </summary>
    let latestReleaseVersion =
        Namespaced_IRI.parse _namespace_name "latestReleaseVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/latinName"></see>
    /// </summary>
    let latinName = Namespaced_IRI.parse _namespace_name "latinName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/launch"></see>
    /// </summary>
    let launch = Namespaced_IRI.parse _namespace_name "launch" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/launchDate"></see>
    /// </summary>
    let launchDate = Namespaced_IRI.parse _namespace_name "launchDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/launchPad"></see>
    /// </summary>
    let launchPad = Namespaced_IRI.parse _namespace_name "launchPad" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/launchSite"></see>
    /// </summary>
    let launchSite = Namespaced_IRI.parse _namespace_name "launchSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/launchVehicle"></see>
    /// </summary>
    let launchVehicle =
        Namespaced_IRI.parse _namespace_name "launchVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/launches"></see>
    /// </summary>
    let launches = Namespaced_IRI.parse _namespace_name "launches" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/laurenceOlivierAward"></see>
    /// </summary>
    let laurenceOlivierAward =
        Namespaced_IRI.parse _namespace_name "laurenceOlivierAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lawCountry"></see>
    /// </summary>
    let lawCountry = Namespaced_IRI.parse _namespace_name "lawCountry" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/layingDown"></see>
    /// </summary>
    let layingDown = Namespaced_IRI.parse _namespace_name "layingDown" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/layout"></see>
    /// </summary>
    let layout = Namespaced_IRI.parse _namespace_name "layout" |> NamespacedName
    /// <summary>
    /// The Library of Congress Classification (LCC) is a system of library classification developed by the Library of Congress.
    /// <see href="http://dbpedia.org/ontology/lcc"></see></summary>
    let lcc = Namespaced_IRI.parse _namespace_name "lcc" |> NamespacedName
    /// <summary>
    /// The Library of Congress Control Number or LCCN is a serially based system of numbering cataloging records in the Library of Congress in the United States. It has nothing to do with the contents of any book, and should not be confused with Library of Congress Classification.
    /// <see href="http://dbpedia.org/ontology/lccn"></see></summary>
    let lccn = Namespaced_IRI.parse _namespace_name "lccn" |> NamespacedName
    /// <summary>
    /// Library of Congress Control Number
    /// <see href="http://dbpedia.org/ontology/lccnId"></see></summary>
    let lccnId = Namespaced_IRI.parse _namespace_name "lccnId" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lchfDraft"></see>
    /// </summary>
    let lchfDraft = Namespaced_IRI.parse _namespace_name "lchfDraft" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lchfDraftTeam"></see>
    /// </summary>
    let lchfDraftTeam =
        Namespaced_IRI.parse _namespace_name "lchfDraftTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lchfDraftYear"></see>
    /// </summary>
    let lchfDraftYear =
        Namespaced_IRI.parse _namespace_name "lchfDraftYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leadTeam"></see>
    /// </summary>
    let leadTeam = Namespaced_IRI.parse _namespace_name "leadTeam" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leadYear"></see>
    /// </summary>
    let leadYear = Namespaced_IRI.parse _namespace_name "leadYear" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leader"></see>
    /// </summary>
    let leader = Namespaced_IRI.parse _namespace_name "leader" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leaderFunction"></see>
    /// </summary>
    let leaderFunction =
        Namespaced_IRI.parse _namespace_name "leaderFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leaderName"></see>
    /// </summary>
    let leaderName = Namespaced_IRI.parse _namespace_name "leaderName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leaderParty"></see>
    /// </summary>
    let leaderParty =
        Namespaced_IRI.parse _namespace_name "leaderParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leaderTitle"></see>
    /// </summary>
    let leaderTitle =
        Namespaced_IRI.parse _namespace_name "leaderTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leadership"></see>
    /// </summary>
    let leadership = Namespaced_IRI.parse _namespace_name "leadership" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/league"></see>
    /// </summary>
    let league = Namespaced_IRI.parse _namespace_name "league" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leagueManager"></see>
    /// </summary>
    let leagueManager =
        Namespaced_IRI.parse _namespace_name "leagueManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leftChild"></see>
    /// </summary>
    let leftChild = Namespaced_IRI.parse _namespace_name "leftChild" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/leftTributary"></see>
    /// </summary>
    let leftTributary =
        Namespaced_IRI.parse _namespace_name "leftTributary" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/legalArrondissement"></see>
    /// </summary>
    let legalArrondissement =
        Namespaced_IRI.parse _namespace_name "legalArrondissement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/BelgiumSettlement"></see>
    /// </summary>
    let BelgiumSettlement =
        Namespaced_IRI.parse _namespace_name "BelgiumSettlement" |> NamespacedName

    /// <summary>
    /// article in code book or statute book referred to in this legal case
    /// <see href="http://dbpedia.org/ontology/legalArticle"></see></summary>
    let legalArticle =
        Namespaced_IRI.parse _namespace_name "legalArticle" |> NamespacedName

    /// <summary>
    /// There are many types of business entity defined in the legal systems of various countries. These include corporations, cooperatives, partnerships, sole traders, limited liability company and other specialized types of organization.
    /// <see href="http://dbpedia.org/ontology/legalForm"></see></summary>
    let legalForm = Namespaced_IRI.parse _namespace_name "legalForm" |> NamespacedName

    /// <summary>
    /// The term of the on-going session (e.g.: "40th Canadian Parliament").
    /// <see href="http://dbpedia.org/ontology/legislativePeriodName"></see></summary>
    let legislativePeriodName =
        Namespaced_IRI.parse _namespace_name "legislativePeriodName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/length"></see>
    /// </summary>
    let length = Namespaced_IRI.parse _namespace_name "length" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lengthQuote"></see>
    /// </summary>
    let lengthQuote =
        Namespaced_IRI.parse _namespace_name "lengthQuote" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lengthReference"></see>
    /// </summary>
    let lengthReference =
        Namespaced_IRI.parse _namespace_name "lengthReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lethalOnChickens"></see>
    /// </summary>
    let lethalOnChickens =
        Namespaced_IRI.parse _namespace_name "lethalOnChickens" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lethalOnMice"></see>
    /// </summary>
    let lethalOnMice =
        Namespaced_IRI.parse _namespace_name "lethalOnMice" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lethalOnRabbits"></see>
    /// </summary>
    let lethalOnRabbits =
        Namespaced_IRI.parse _namespace_name "lethalOnRabbits" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lethalOnRats"></see>
    /// </summary>
    let lethalOnRats =
        Namespaced_IRI.parse _namespace_name "lethalOnRats" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/liberationDate"></see>
    /// </summary>
    let liberationDate =
        Namespaced_IRI.parse _namespace_name "liberationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/libretto"></see>
    /// </summary>
    let libretto = Namespaced_IRI.parse _namespace_name "libretto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/licenceLetter"></see>
    /// </summary>
    let licenceLetter =
        Namespaced_IRI.parse _namespace_name "licenceLetter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/GermanSettlement"></see>
    /// </summary>
    let GermanSettlement =
        Namespaced_IRI.parse _namespace_name "GermanSettlement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/licenceNumber"></see>
    /// </summary>
    let licenceNumber =
        Namespaced_IRI.parse _namespace_name "licenceNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/licenceNumberLabel"></see>
    /// </summary>
    let licenceNumberLabel =
        Namespaced_IRI.parse _namespace_name "licenceNumberLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/license"></see>
    /// </summary>
    let license = Namespaced_IRI.parse _namespace_name "license" |> NamespacedName
    /// <summary>
    /// Identify which company or entity holds the licence (mostly string are used in Wikipedia, therefore range is xsd:sting).
    /// <see href="http://dbpedia.org/ontology/licensee"></see></summary>
    let licensee = Namespaced_IRI.parse _namespace_name "licensee" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lieutenancy"></see>
    /// </summary>
    let lieutenancy =
        Namespaced_IRI.parse _namespace_name "lieutenancy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lieutenancyArea"></see>
    /// </summary>
    let lieutenancyArea =
        Namespaced_IRI.parse _namespace_name "lieutenancyArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lieutenant"></see>
    /// </summary>
    let lieutenant = Namespaced_IRI.parse _namespace_name "lieutenant" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lifeExpectancy"></see>
    /// </summary>
    let lifeExpectancy =
        Namespaced_IRI.parse _namespace_name "lifeExpectancy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/limit"></see>
    /// </summary>
    let limit = Namespaced_IRI.parse _namespace_name "limit" |> NamespacedName
    /// <summary>
    /// Length of the line. Wikipedians usually do not differentiate between track length and line lenght.
    /// <see href="http://dbpedia.org/ontology/lineLength"></see></summary>
    let lineLength = Namespaced_IRI.parse _namespace_name "lineLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/linguisticsTradition"></see>
    /// </summary>
    let linguisticsTradition =
        Namespaced_IRI.parse _namespace_name "linguisticsTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/linkedSpace"></see>
    /// </summary>
    let linkedSpace =
        Namespaced_IRI.parse _namespace_name "linkedSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/linkedTo"></see>
    /// </summary>
    let linkedTo = Namespaced_IRI.parse _namespace_name "linkedTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/listItemOf"></see>
    /// </summary>
    let listItemOf = Namespaced_IRI.parse _namespace_name "listItemOf" |> NamespacedName

    /// <summary>
    /// A literary genre is a category of literary composition. Genres may be determined by literary technique, tone, content, or even (as in the case of fiction) length.
    /// <see href="http://dbpedia.org/ontology/literaryGenre"></see></summary>
    let literaryGenre =
        Namespaced_IRI.parse _namespace_name "literaryGenre" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/littlePoolRecord"></see>
    /// </summary>
    let littlePoolRecord =
        Namespaced_IRI.parse _namespace_name "littlePoolRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/livingPlace"></see>
    /// </summary>
    let livingPlace =
        Namespaced_IRI.parse _namespace_name "livingPlace" |> NamespacedName

    /// <summary>
    /// Load limit of the bridge.
    /// <see href="http://dbpedia.org/ontology/loadLimit"></see></summary>
    let loadLimit = Namespaced_IRI.parse _namespace_name "loadLimit" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/localAuthority"></see>
    /// </summary>
    let localAuthority =
        Namespaced_IRI.parse _namespace_name "localAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/localPhonePrefix"></see>
    /// </summary>
    let localPhonePrefix =
        Namespaced_IRI.parse _namespace_name "localPhonePrefix" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/locality"></see>
    /// </summary>
    let locality = Namespaced_IRI.parse _namespace_name "locality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/localization"></see>
    /// </summary>
    let localization =
        Namespaced_IRI.parse _namespace_name "localization" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/localizationThumbnail"></see>
    /// </summary>
    let localizationThumbnail =
        Namespaced_IRI.parse _namespace_name "localizationThumbnail" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/localizationThumbnailCaption"></see>
    /// </summary>
    let localizationThumbnailCaption =
        Namespaced_IRI.parse _namespace_name "localizationThumbnailCaption" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/locatedInArea"></see>
    /// </summary>
    let locatedInArea =
        Namespaced_IRI.parse _namespace_name "locatedInArea" |> NamespacedName

    /// <summary>
    /// The location of the thing.
    /// <see href="http://dbpedia.org/ontology/location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName

    /// <summary>
    /// City the thing is located.
    /// <see href="http://dbpedia.org/ontology/locationCity"></see></summary>
    let locationCity =
        Namespaced_IRI.parse _namespace_name "locationCity" |> NamespacedName

    /// <summary>
    /// Country the thing is located.
    /// <see href="http://dbpedia.org/ontology/locationCountry"></see></summary>
    let locationCountry =
        Namespaced_IRI.parse _namespace_name "locationCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/locationIdentifier"></see>
    /// </summary>
    let locationIdentifier =
        Namespaced_IRI.parse _namespace_name "locationIdentifier" |> NamespacedName

    /// <summary>
    /// Location of the thing as string. Use "location" if the location is a resource
    /// <see href="http://dbpedia.org/ontology/locationName"></see></summary>
    let locationName =
        Namespaced_IRI.parse _namespace_name "locationName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/locomotive"></see>
    /// </summary>
    let locomotive = Namespaced_IRI.parse _namespace_name "locomotive" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/locusSupplementaryData"></see>
    /// </summary>
    let locusSupplementaryData =
        Namespaced_IRI.parse _namespace_name "locusSupplementaryData" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/logo"></see>
    /// </summary>
    let logo = Namespaced_IRI.parse _namespace_name "logo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/longDistancePisteKilometre"></see>
    /// </summary>
    let longDistancePisteKilometre =
        Namespaced_IRI.parse _namespace_name "longDistancePisteKilometre" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/longDistancePisteNumber"></see>
    /// </summary>
    let longDistancePisteNumber =
        Namespaced_IRI.parse _namespace_name "longDistancePisteNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/longName"></see>
    /// </summary>
    let longName = Namespaced_IRI.parse _namespace_name "longName" |> NamespacedName
    /// <summary>
    /// can be used to include more informations e.g. the name of the artist that a tribute album is in honor of
    /// <see href="http://dbpedia.org/ontology/longtype"></see></summary>
    let longtype = Namespaced_IRI.parse _namespace_name "longtype" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lounge"></see>
    /// </summary>
    let lounge = Namespaced_IRI.parse _namespace_name "lounge" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowerAge"></see>
    /// </summary>
    let lowerAge = Namespaced_IRI.parse _namespace_name "lowerAge" |> NamespacedName

    /// <summary>
    /// Payload mass in a typical Low Earth orbit
    /// <see href="http://dbpedia.org/ontology/lowerEarthOrbitPayload"></see></summary>
    let lowerEarthOrbitPayload =
        Namespaced_IRI.parse _namespace_name "lowerEarthOrbitPayload" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowest"></see>
    /// </summary>
    let lowest = Namespaced_IRI.parse _namespace_name "lowest" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowestMountain"></see>
    /// </summary>
    let lowestMountain =
        Namespaced_IRI.parse _namespace_name "lowestMountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowestPlace"></see>
    /// </summary>
    let lowestPlace =
        Namespaced_IRI.parse _namespace_name "lowestPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowestPoint"></see>
    /// </summary>
    let lowestPoint =
        Namespaced_IRI.parse _namespace_name "lowestPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowestPosition"></see>
    /// </summary>
    let lowestPosition =
        Namespaced_IRI.parse _namespace_name "lowestPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowestRegion"></see>
    /// </summary>
    let lowestRegion =
        Namespaced_IRI.parse _namespace_name "lowestRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lowestState"></see>
    /// </summary>
    let lowestState =
        Namespaced_IRI.parse _namespace_name "lowestState" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarEvaTime"></see>
    /// </summary>
    let lunarEvaTime =
        Namespaced_IRI.parse _namespace_name "lunarEvaTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarLandingSite"></see>
    /// </summary>
    let lunarLandingSite =
        Namespaced_IRI.parse _namespace_name "lunarLandingSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarModule"></see>
    /// </summary>
    let lunarModule =
        Namespaced_IRI.parse _namespace_name "lunarModule" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarOrbitTime"></see>
    /// </summary>
    let lunarOrbitTime =
        Namespaced_IRI.parse _namespace_name "lunarOrbitTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarRover"></see>
    /// </summary>
    let lunarRover = Namespaced_IRI.parse _namespace_name "lunarRover" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarSampleMass"></see>
    /// </summary>
    let lunarSampleMass =
        Namespaced_IRI.parse _namespace_name "lunarSampleMass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lunarSurfaceTime"></see>
    /// </summary>
    let lunarSurfaceTime =
        Namespaced_IRI.parse _namespace_name "lunarSurfaceTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/lymph"></see>
    /// </summary>
    let lymph = Namespaced_IRI.parse _namespace_name "lymph" |> NamespacedName
    /// <summary>
    /// Creator of the text of a MusicalWork, eg Musical, Opera or Song
    /// <see href="http://dbpedia.org/ontology/lyrics"></see></summary>
    let lyrics = Namespaced_IRI.parse _namespace_name "lyrics" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/magazine"></see>
    /// </summary>
    let magazine = Namespaced_IRI.parse _namespace_name "magazine" |> NamespacedName

    /// <summary>
    /// date of maiden flight
    /// <see href="http://dbpedia.org/ontology/maidenFlight"></see></summary>
    let maidenFlight =
        Namespaced_IRI.parse _namespace_name "maidenFlight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maidenFlightRocket"></see>
    /// </summary>
    let maidenFlightRocket =
        Namespaced_IRI.parse _namespace_name "maidenFlightRocket" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maidenVoyage"></see>
    /// </summary>
    let maidenVoyage =
        Namespaced_IRI.parse _namespace_name "maidenVoyage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainBuilding"></see>
    /// </summary>
    let mainBuilding =
        Namespaced_IRI.parse _namespace_name "mainBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainCharacter"></see>
    /// </summary>
    let mainCharacter =
        Namespaced_IRI.parse _namespace_name "mainCharacter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainDomain"></see>
    /// </summary>
    let mainDomain = Namespaced_IRI.parse _namespace_name "mainDomain" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainFamilyBranch"></see>
    /// </summary>
    let mainFamilyBranch =
        Namespaced_IRI.parse _namespace_name "mainFamilyBranch" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainInterest"></see>
    /// </summary>
    let mainInterest =
        Namespaced_IRI.parse _namespace_name "mainInterest" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainIsland"></see>
    /// </summary>
    let mainIsland = Namespaced_IRI.parse _namespace_name "mainIsland" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainIslands"></see>
    /// </summary>
    let mainIslands =
        Namespaced_IRI.parse _namespace_name "mainIslands" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainOrgan"></see>
    /// </summary>
    let mainOrgan = Namespaced_IRI.parse _namespace_name "mainOrgan" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mainspan"></see>
    /// </summary>
    let mainspan = Namespaced_IRI.parse _namespace_name "mainspan" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maintainedBy"></see>
    /// </summary>
    let maintainedBy =
        Namespaced_IRI.parse _namespace_name "maintainedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/majorIsland"></see>
    /// </summary>
    let majorIsland =
        Namespaced_IRI.parse _namespace_name "majorIsland" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/majorShrine"></see>
    /// </summary>
    let majorShrine =
        Namespaced_IRI.parse _namespace_name "majorShrine" |> NamespacedName

    /// <summary>
    /// number of office holder
    /// <see href="http://dbpedia.org/ontology/majorityFloorLeader"></see></summary>
    let majorityFloorLeader =
        Namespaced_IRI.parse _namespace_name "majorityFloorLeader" |> NamespacedName

    /// <summary>
    /// number of office holder
    /// <see href="http://dbpedia.org/ontology/majorityLeader"></see></summary>
    let majorityLeader =
        Namespaced_IRI.parse _namespace_name "majorityLeader" |> NamespacedName

    /// <summary>
    /// the person who is responsible for the actors makeup
    /// <see href="http://dbpedia.org/ontology/makeupArtist"></see></summary>
    let makeupArtist =
        Namespaced_IRI.parse _namespace_name "makeupArtist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/management"></see>
    /// </summary>
    let management = Namespaced_IRI.parse _namespace_name "management" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managementCountry"></see>
    /// </summary>
    let managementCountry =
        Namespaced_IRI.parse _namespace_name "managementCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managementElevation"></see>
    /// </summary>
    let managementElevation =
        Namespaced_IRI.parse _namespace_name "managementElevation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managementMountain"></see>
    /// </summary>
    let managementMountain =
        Namespaced_IRI.parse _namespace_name "managementMountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managementPlace"></see>
    /// </summary>
    let managementPlace =
        Namespaced_IRI.parse _namespace_name "managementPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managementPosition"></see>
    /// </summary>
    let managementPosition =
        Namespaced_IRI.parse _namespace_name "managementPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managementRegion"></see>
    /// </summary>
    let managementRegion =
        Namespaced_IRI.parse _namespace_name "managementRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/manager"></see>
    /// </summary>
    let manager = Namespaced_IRI.parse _namespace_name "manager" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managerClub"></see>
    /// </summary>
    let managerClub =
        Namespaced_IRI.parse _namespace_name "managerClub" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managerSeason"></see>
    /// </summary>
    let managerSeason =
        Namespaced_IRI.parse _namespace_name "managerSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managerTitle"></see>
    /// </summary>
    let managerTitle =
        Namespaced_IRI.parse _namespace_name "managerTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managerYears"></see>
    /// </summary>
    let managerYears =
        Namespaced_IRI.parse _namespace_name "managerYears" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managerYearsEndYear"></see>
    /// </summary>
    let managerYearsEndYear =
        Namespaced_IRI.parse _namespace_name "managerYearsEndYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managerYearsStartYear"></see>
    /// </summary>
    let managerYearsStartYear =
        Namespaced_IRI.parse _namespace_name "managerYearsStartYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/managingEditor"></see>
    /// </summary>
    let managingEditor =
        Namespaced_IRI.parse _namespace_name "managingEditor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mandate"></see>
    /// </summary>
    let mandate = Namespaced_IRI.parse _namespace_name "mandate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/manufacturer"></see>
    /// </summary>
    let manufacturer =
        Namespaced_IRI.parse _namespace_name "manufacturer" |> NamespacedName

    /// <summary>
    /// A map of the place.
    /// <see href="http://dbpedia.org/ontology/map"></see></summary>
    let map = Namespaced_IRI.parse _namespace_name "map" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mapCaption"></see>
    /// </summary>
    let mapCaption = Namespaced_IRI.parse _namespace_name "mapCaption" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mapDescription"></see>
    /// </summary>
    let mapDescription =
        Namespaced_IRI.parse _namespace_name "mapDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/march"></see>
    /// </summary>
    let march = Namespaced_IRI.parse _namespace_name "march" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/marketCapitalisation"></see>
    /// </summary>
    let marketCapitalisation =
        Namespaced_IRI.parse _namespace_name "marketCapitalisation" |> NamespacedName

    /// <summary>
    /// something, especially a person or animal, used to symbolize a sports team, company, organization or other group.
    /// <see href="http://dbpedia.org/ontology/mascot"></see></summary>
    let mascot = Namespaced_IRI.parse _namespace_name "mascot" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mass"></see>
    /// </summary>
    let mass = Namespaced_IRI.parse _namespace_name "mass" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/massif"></see>
    /// </summary>
    let massif = Namespaced_IRI.parse _namespace_name "massif" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mastersWins"></see>
    /// </summary>
    let mastersWins =
        Namespaced_IRI.parse _namespace_name "mastersWins" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/matchPoint"></see>
    /// </summary>
    let matchPoint = Namespaced_IRI.parse _namespace_name "matchPoint" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/material"></see>
    /// </summary>
    let material = Namespaced_IRI.parse _namespace_name "material" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/max"></see>
    /// </summary>
    let max = Namespaced_IRI.parse _namespace_name "max" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maxAbsoluteMagnitude"></see>
    /// </summary>
    let maxAbsoluteMagnitude =
        Namespaced_IRI.parse _namespace_name "maxAbsoluteMagnitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maxApparentMagnitude"></see>
    /// </summary>
    let maxApparentMagnitude =
        Namespaced_IRI.parse _namespace_name "maxApparentMagnitude" |> NamespacedName

    /// <summary>
    /// Maximum preparation time of a recipe / Food
    /// <see href="http://dbpedia.org/ontology/maxTime"></see></summary>
    let maxTime = Namespaced_IRI.parse _namespace_name "maxTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumArea"></see>
    /// </summary>
    let maximumArea =
        Namespaced_IRI.parse _namespace_name "maximumArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumAreaQuote"></see>
    /// </summary>
    let maximumAreaQuote =
        Namespaced_IRI.parse _namespace_name "maximumAreaQuote" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumBoatBeam"></see>
    /// </summary>
    let maximumBoatBeam =
        Namespaced_IRI.parse _namespace_name "maximumBoatBeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumBoatLength"></see>
    /// </summary>
    let maximumBoatLength =
        Namespaced_IRI.parse _namespace_name "maximumBoatLength" |> NamespacedName

    /// <summary>
    /// Source of the value can be declare by .
    /// <see href="http://dbpedia.org/ontology/maximumDepth"></see></summary>
    let maximumDepth =
        Namespaced_IRI.parse _namespace_name "maximumDepth" |> NamespacedName

    /// <summary>
    /// Source of the  value.
    /// <see href="http://dbpedia.org/ontology/maximumDepthQuote"></see></summary>
    let maximumDepthQuote =
        Namespaced_IRI.parse _namespace_name "maximumDepthQuote" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumDischarge"></see>
    /// </summary>
    let maximumDischarge =
        Namespaced_IRI.parse _namespace_name "maximumDischarge" |> NamespacedName

    /// <summary>
    /// maximum elevation above the sea level
    /// <see href="http://dbpedia.org/ontology/maximumElevation"></see></summary>
    let maximumElevation =
        Namespaced_IRI.parse _namespace_name "maximumElevation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumInclination"></see>
    /// </summary>
    let maximumInclination =
        Namespaced_IRI.parse _namespace_name "maximumInclination" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/maximumTemperature"></see>
    /// </summary>
    let maximumTemperature =
        Namespaced_IRI.parse _namespace_name "maximumTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mayor"></see>
    /// </summary>
    let mayor = Namespaced_IRI.parse _namespace_name "mayor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mayorArticle"></see>
    /// </summary>
    let mayorArticle =
        Namespaced_IRI.parse _namespace_name "mayorArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mayorCouncillor"></see>
    /// </summary>
    let mayorCouncillor =
        Namespaced_IRI.parse _namespace_name "mayorCouncillor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mayorFunction"></see>
    /// </summary>
    let mayorFunction =
        Namespaced_IRI.parse _namespace_name "mayorFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/SwitzerlandSettlement"></see>
    /// </summary>
    let SwitzerlandSettlement =
        Namespaced_IRI.parse _namespace_name "SwitzerlandSettlement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mayorMandate"></see>
    /// </summary>
    let mayorMandate =
        Namespaced_IRI.parse _namespace_name "mayorMandate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mayorTitle"></see>
    /// </summary>
    let mayorTitle = Namespaced_IRI.parse _namespace_name "mayorTitle" |> NamespacedName
    /// <summary>
    /// MusicBrainz is an open music encyclopedia that collects music metadata and makes it available to the public.
    /// <see href="http://dbpedia.org/ontology/mbaId"></see></summary>
    let mbaId = Namespaced_IRI.parse _namespace_name "mbaId" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meanRadius"></see>
    /// </summary>
    let meanRadius = Namespaced_IRI.parse _namespace_name "meanRadius" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meanTemperature"></see>
    /// </summary>
    let meanTemperature =
        Namespaced_IRI.parse _namespace_name "meanTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meaning"></see>
    /// </summary>
    let meaning = Namespaced_IRI.parse _namespace_name "meaning" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/measurements"></see>
    /// </summary>
    let measurements =
        Namespaced_IRI.parse _namespace_name "measurements" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/medalist"></see>
    /// </summary>
    let medalist = Namespaced_IRI.parse _namespace_name "medalist" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/media"></see>
    /// </summary>
    let media = Namespaced_IRI.parse _namespace_name "media" |> NamespacedName
    /// <summary>
    /// Print / On-line (then binding types etc. if relevant)
    /// <see href="http://dbpedia.org/ontology/mediaType"></see></summary>
    let mediaType = Namespaced_IRI.parse _namespace_name "mediaType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/medlinePlus"></see>
    /// </summary>
    let medlinePlus =
        Namespaced_IRI.parse _namespace_name "medlinePlus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meetingBuilding"></see>
    /// </summary>
    let meetingBuilding =
        Namespaced_IRI.parse _namespace_name "meetingBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meetingCity"></see>
    /// </summary>
    let meetingCity =
        Namespaced_IRI.parse _namespace_name "meetingCity" |> NamespacedName

    /// <summary>
    /// A road that crosses another road at the junction.
    /// <see href="http://dbpedia.org/ontology/meetingRoad"></see></summary>
    let meetingRoad =
        Namespaced_IRI.parse _namespace_name "meetingRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meltingPoint"></see>
    /// </summary>
    let meltingPoint =
        Namespaced_IRI.parse _namespace_name "meltingPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/member"></see>
    /// </summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/memberOfParliament"></see>
    /// </summary>
    let memberOfParliament =
        Namespaced_IRI.parse _namespace_name "memberOfParliament" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/membership"></see>
    /// </summary>
    let membership = Namespaced_IRI.parse _namespace_name "membership" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/membershipAsOf"></see>
    /// </summary>
    let membershipAsOf =
        Namespaced_IRI.parse _namespace_name "membershipAsOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Organisation,_Parish"></see>
    /// </summary>
    let ``Organisation,_Parish`` =
        Namespaced_IRI.parse _namespace_name "Organisation,_Parish" |> NamespacedName

    /// <summary>
    /// A wise and trusted counselor or teacher
    /// <see href="http://dbpedia.org/ontology/mentor"></see></summary>
    let mentor = Namespaced_IRI.parse _namespace_name "mentor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mergedIntoParty"></see>
    /// </summary>
    let mergedIntoParty =
        Namespaced_IRI.parse _namespace_name "mergedIntoParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mergedSettlement"></see>
    /// </summary>
    let mergedSettlement =
        Namespaced_IRI.parse _namespace_name "mergedSettlement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mergerDate"></see>
    /// </summary>
    let mergerDate = Namespaced_IRI.parse _namespace_name "mergerDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meshId"></see>
    /// </summary>
    let meshId = Namespaced_IRI.parse _namespace_name "meshId" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meshName"></see>
    /// </summary>
    let meshName = Namespaced_IRI.parse _namespace_name "meshName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/meshNumber"></see>
    /// </summary>
    let meshNumber = Namespaced_IRI.parse _namespace_name "meshNumber" |> NamespacedName

    /// <summary>
    /// Name for Messier objects
    /// <see href="http://dbpedia.org/ontology/messierName"></see></summary>
    let messierName =
        Namespaced_IRI.parse _namespace_name "messierName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/metropolitanBorough"></see>
    /// </summary>
    let metropolitanBorough =
        Namespaced_IRI.parse _namespace_name "metropolitanBorough" |> NamespacedName

    /// <summary>
    /// Mouse Genomic Informatics ID
    /// <see href="http://dbpedia.org/ontology/mgiid"></see></summary>
    let mgiid = Namespaced_IRI.parse _namespace_name "mgiid" |> NamespacedName

    /// <summary>
    /// The service branch (Army, Navy, etc.) a person is part of.
    /// <see href="http://dbpedia.org/ontology/militaryBranch"></see></summary>
    let militaryBranch =
        Namespaced_IRI.parse _namespace_name "militaryBranch" |> NamespacedName

    /// <summary>
    /// For persons who are notable as commanding officers, the units they commanded. Dates should be given if multiple notable commands were held.
    /// <see href="http://dbpedia.org/ontology/militaryCommand"></see></summary>
    let militaryCommand =
        Namespaced_IRI.parse _namespace_name "militaryCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/militaryFunction"></see>
    /// </summary>
    let militaryFunction =
        Namespaced_IRI.parse _namespace_name "militaryFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/militaryGovernment"></see>
    /// </summary>
    let militaryGovernment =
        Namespaced_IRI.parse _namespace_name "militaryGovernment" |> NamespacedName

    /// <summary>
    /// The highest rank achieved by a person.
    /// <see href="http://dbpedia.org/ontology/militaryRank"></see></summary>
    let militaryRank =
        Namespaced_IRI.parse _namespace_name "militaryRank" |> NamespacedName

    /// <summary>
    /// For persons who are not notable as commanding officers, the unit (company, battalion, regiment, etc.) in which they served.
    /// <see href="http://dbpedia.org/ontology/militaryUnit"></see></summary>
    let militaryUnit =
        Namespaced_IRI.parse _namespace_name "militaryUnit" |> NamespacedName

    /// <summary>
    /// the size of the military unit
    /// <see href="http://dbpedia.org/ontology/militaryUnitSize"></see></summary>
    let militaryUnitSize =
        Namespaced_IRI.parse _namespace_name "militaryUnitSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/millSpan"></see>
    /// </summary>
    let millSpan = Namespaced_IRI.parse _namespace_name "millSpan" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/millType"></see>
    /// </summary>
    let millType = Namespaced_IRI.parse _namespace_name "millType" |> NamespacedName

    /// <summary>
    /// mills code from the Belgian database on mills
    /// <see href="http://dbpedia.org/ontology/millsCodeBE"></see></summary>
    let millsCodeBE =
        Namespaced_IRI.parse _namespace_name "millsCodeBE" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/millsCodeDutch"></see>
    /// </summary>
    let millsCodeDutch =
        Namespaced_IRI.parse _namespace_name "millsCodeDutch" |> NamespacedName

    /// <summary>
    /// mills code from the central Dutch database on mills
    /// <see href="http://dbpedia.org/ontology/millsCodeNL"></see></summary>
    let millsCodeNL =
        Namespaced_IRI.parse _namespace_name "millsCodeNL" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/millsCodeNLVerdwenen"></see>
    /// </summary>
    let millsCodeNLVerdwenen =
        Namespaced_IRI.parse _namespace_name "millsCodeNLVerdwenen" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/millsCodeNLWindmotoren"></see>
    /// </summary>
    let millsCodeNLWindmotoren =
        Namespaced_IRI.parse _namespace_name "millsCodeNLWindmotoren" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/min"></see>
    /// </summary>
    let min = Namespaced_IRI.parse _namespace_name "min" |> NamespacedName
    /// <summary>
    /// Minimum preparation time of a recipe / Food
    /// <see href="http://dbpedia.org/ontology/minTime"></see></summary>
    let minTime = Namespaced_IRI.parse _namespace_name "minTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/minimumArea"></see>
    /// </summary>
    let minimumArea =
        Namespaced_IRI.parse _namespace_name "minimumArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/minimumAreaQuote"></see>
    /// </summary>
    let minimumAreaQuote =
        Namespaced_IRI.parse _namespace_name "minimumAreaQuote" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/minimumDischarge"></see>
    /// </summary>
    let minimumDischarge =
        Namespaced_IRI.parse _namespace_name "minimumDischarge" |> NamespacedName

    /// <summary>
    /// minimum elevation above the sea level
    /// <see href="http://dbpedia.org/ontology/minimumElevation"></see></summary>
    let minimumElevation =
        Namespaced_IRI.parse _namespace_name "minimumElevation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/minimumInclination"></see>
    /// </summary>
    let minimumInclination =
        Namespaced_IRI.parse _namespace_name "minimumInclination" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/minimumTemperature"></see>
    /// </summary>
    let minimumTemperature =
        Namespaced_IRI.parse _namespace_name "minimumTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/minority"></see>
    /// </summary>
    let minority = Namespaced_IRI.parse _namespace_name "minority" |> NamespacedName

    /// <summary>
    /// number of office holder
    /// <see href="http://dbpedia.org/ontology/minorityFloorLeader"></see></summary>
    let minorityFloorLeader =
        Namespaced_IRI.parse _namespace_name "minorityFloorLeader" |> NamespacedName

    /// <summary>
    /// number of office holder
    /// <see href="http://dbpedia.org/ontology/minorityLeader"></see></summary>
    let minorityLeader =
        Namespaced_IRI.parse _namespace_name "minorityLeader" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mirDockings"></see>
    /// </summary>
    let mirDockings =
        Namespaced_IRI.parse _namespace_name "mirDockings" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mission"></see>
    /// </summary>
    let mission = Namespaced_IRI.parse _namespace_name "mission" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/missionDuration"></see>
    /// </summary>
    let missionDuration =
        Namespaced_IRI.parse _namespace_name "missionDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/missions"></see>
    /// </summary>
    let missions = Namespaced_IRI.parse _namespace_name "missions" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/model"></see>
    /// </summary>
    let model = Namespaced_IRI.parse _namespace_name "model" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/modelEndDate"></see>
    /// </summary>
    let modelEndDate =
        Namespaced_IRI.parse _namespace_name "modelEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/modelEndYear"></see>
    /// </summary>
    let modelEndYear =
        Namespaced_IRI.parse _namespace_name "modelEndYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/modelLineVehicle"></see>
    /// </summary>
    let modelLineVehicle =
        Namespaced_IRI.parse _namespace_name "modelLineVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/modelStartDate"></see>
    /// </summary>
    let modelStartDate =
        Namespaced_IRI.parse _namespace_name "modelStartDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/modelStartYear"></see>
    /// </summary>
    let modelStartYear =
        Namespaced_IRI.parse _namespace_name "modelStartYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/molecularWeight"></see>
    /// </summary>
    let molecularWeight =
        Namespaced_IRI.parse _namespace_name "molecularWeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/monarch"></see>
    /// </summary>
    let monarch = Namespaced_IRI.parse _namespace_name "monarch" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/month"></see>
    /// </summary>
    let month = Namespaced_IRI.parse _namespace_name "month" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mood"></see>
    /// </summary>
    let mood = Namespaced_IRI.parse _namespace_name "mood" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mostDownPoint"></see>
    /// </summary>
    let mostDownPoint =
        Namespaced_IRI.parse _namespace_name "mostDownPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mostWins"></see>
    /// </summary>
    let mostWins = Namespaced_IRI.parse _namespace_name "mostWins" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mother"></see>
    /// </summary>
    let mother = Namespaced_IRI.parse _namespace_name "mother" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/motto"></see>
    /// </summary>
    let motto = Namespaced_IRI.parse _namespace_name "motto" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mount"></see>
    /// </summary>
    let mount = Namespaced_IRI.parse _namespace_name "mount" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mountainRange"></see>
    /// </summary>
    let mountainRange =
        Namespaced_IRI.parse _namespace_name "mountainRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthCountry"></see>
    /// </summary>
    let mouthCountry =
        Namespaced_IRI.parse _namespace_name "mouthCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthDistrict"></see>
    /// </summary>
    let mouthDistrict =
        Namespaced_IRI.parse _namespace_name "mouthDistrict" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthElevation"></see>
    /// </summary>
    let mouthElevation =
        Namespaced_IRI.parse _namespace_name "mouthElevation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthMountain"></see>
    /// </summary>
    let mouthMountain =
        Namespaced_IRI.parse _namespace_name "mouthMountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthPlace"></see>
    /// </summary>
    let mouthPlace = Namespaced_IRI.parse _namespace_name "mouthPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthPosition"></see>
    /// </summary>
    let mouthPosition =
        Namespaced_IRI.parse _namespace_name "mouthPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthRegion"></see>
    /// </summary>
    let mouthRegion =
        Namespaced_IRI.parse _namespace_name "mouthRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mouthState"></see>
    /// </summary>
    let mouthState = Namespaced_IRI.parse _namespace_name "mouthState" |> NamespacedName
    /// <summary>
    /// artistic movement or school with which artist is associated
    /// <see href="http://dbpedia.org/ontology/movement"></see></summary>
    let movement = Namespaced_IRI.parse _namespace_name "movement" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/movie"></see>
    /// </summary>
    let movie = Namespaced_IRI.parse _namespace_name "movie" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mukhtar"></see>
    /// </summary>
    let mukhtar = Namespaced_IRI.parse _namespace_name "mukhtar" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/LebanonSettlement"></see>
    /// </summary>
    let LebanonSettlement =
        Namespaced_IRI.parse _namespace_name "LebanonSettlement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/municipality"></see>
    /// </summary>
    let municipality =
        Namespaced_IRI.parse _namespace_name "municipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/municipalityAbsorbedBy"></see>
    /// </summary>
    let municipalityAbsorbedBy =
        Namespaced_IRI.parse _namespace_name "municipalityAbsorbedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/municipalityCode"></see>
    /// </summary>
    let municipalityCode =
        Namespaced_IRI.parse _namespace_name "municipalityCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/municipalityRenamedTo"></see>
    /// </summary>
    let municipalityRenamedTo =
        Namespaced_IRI.parse _namespace_name "municipalityRenamedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/municipalityType"></see>
    /// </summary>
    let municipalityType =
        Namespaced_IRI.parse _namespace_name "municipalityType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/museum"></see>
    /// </summary>
    let museum = Namespaced_IRI.parse _namespace_name "museum" |> NamespacedName
    /// <summary>
    /// This property has been added  because 'buildingType' is much more about the place, whereas 'museumType' is about the way the place is being (or:was) used
    /// <see href="http://dbpedia.org/ontology/museumType"></see></summary>
    let museumType = Namespaced_IRI.parse _namespace_name "museumType" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicBand"></see>
    /// </summary>
    let musicBand = Namespaced_IRI.parse _namespace_name "musicBand" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicBy"></see>
    /// </summary>
    let musicBy = Namespaced_IRI.parse _namespace_name "musicBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicComposer"></see>
    /// </summary>
    let musicComposer =
        Namespaced_IRI.parse _namespace_name "musicComposer" |> NamespacedName

    /// <summary>
    /// The format of the album: EP, Single etc.
    /// <see href="http://dbpedia.org/ontology/musicFormat"></see></summary>
    let musicFormat =
        Namespaced_IRI.parse _namespace_name "musicFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicFusionGenre"></see>
    /// </summary>
    let musicFusionGenre =
        Namespaced_IRI.parse _namespace_name "musicFusionGenre" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicSubgenre"></see>
    /// </summary>
    let musicSubgenre =
        Namespaced_IRI.parse _namespace_name "musicSubgenre" |> NamespacedName

    /// <summary>
    /// Type is too general. We should be able to distinguish types of music from types of architecture
    /// <see href="http://dbpedia.org/ontology/musicType"></see></summary>
    let musicType = Namespaced_IRI.parse _namespace_name "musicType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicalArtist"></see>
    /// </summary>
    let musicalArtist =
        Namespaced_IRI.parse _namespace_name "musicalArtist" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicalBand"></see>
    /// </summary>
    let musicalBand =
        Namespaced_IRI.parse _namespace_name "musicalBand" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicalKey"></see>
    /// </summary>
    let musicalKey = Namespaced_IRI.parse _namespace_name "musicalKey" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/musicians"></see>
    /// </summary>
    let musicians = Namespaced_IRI.parse _namespace_name "musicians" |> NamespacedName

    /// <summary>
    /// Name of a mute character in play.
    /// <see href="http://dbpedia.org/ontology/muteCharacterInPlay"></see></summary>
    let muteCharacterInPlay =
        Namespaced_IRI.parse _namespace_name "muteCharacterInPlay" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mvp"></see>
    /// </summary>
    let mvp = Namespaced_IRI.parse _namespace_name "mvp" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/mythology"></see>
    /// </summary>
    let mythology = Namespaced_IRI.parse _namespace_name "mythology" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/naacpImageAward"></see>
    /// </summary>
    let naacpImageAward =
        Namespaced_IRI.parse _namespace_name "naacpImageAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nameAsOf"></see>
    /// </summary>
    let nameAsOf = Namespaced_IRI.parse _namespace_name "nameAsOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nameDay"></see>
    /// </summary>
    let nameDay = Namespaced_IRI.parse _namespace_name "nameDay" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/namedAfter"></see>
    /// </summary>
    let namedAfter = Namespaced_IRI.parse _namespace_name "namedAfter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/namedByLanguage"></see>
    /// </summary>
    let namedByLanguage =
        Namespaced_IRI.parse _namespace_name "namedByLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/names"></see>
    /// </summary>
    let names = Namespaced_IRI.parse _namespace_name "names" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/narrator"></see>
    /// </summary>
    let narrator = Namespaced_IRI.parse _namespace_name "narrator" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nation"></see>
    /// </summary>
    let nation = Namespaced_IRI.parse _namespace_name "nation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalAffiliation"></see>
    /// </summary>
    let nationalAffiliation =
        Namespaced_IRI.parse _namespace_name "nationalAffiliation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalChampionship"></see>
    /// </summary>
    let nationalChampionship =
        Namespaced_IRI.parse _namespace_name "nationalChampionship" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalFilmAward"></see>
    /// </summary>
    let nationalFilmAward =
        Namespaced_IRI.parse _namespace_name "nationalFilmAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalOlympicCommittee"></see>
    /// </summary>
    let nationalOlympicCommittee =
        Namespaced_IRI.parse _namespace_name "nationalOlympicCommittee" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalRanking"></see>
    /// </summary>
    let nationalRanking =
        Namespaced_IRI.parse _namespace_name "nationalRanking" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalSelection"></see>
    /// </summary>
    let nationalSelection =
        Namespaced_IRI.parse _namespace_name "nationalSelection" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTeam"></see>
    /// </summary>
    let nationalTeam =
        Namespaced_IRI.parse _namespace_name "nationalTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTeamMatchPoint"></see>
    /// </summary>
    let nationalTeamMatchPoint =
        Namespaced_IRI.parse _namespace_name "nationalTeamMatchPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTeamYear"></see>
    /// </summary>
    let nationalTeamYear =
        Namespaced_IRI.parse _namespace_name "nationalTeamYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTopographicSystemMapNumber"></see>
    /// </summary>
    let nationalTopographicSystemMapNumber =
        Namespaced_IRI.parse _namespace_name "nationalTopographicSystemMapNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTournament"></see>
    /// </summary>
    let nationalTournament =
        Namespaced_IRI.parse _namespace_name "nationalTournament" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTournamentBronze"></see>
    /// </summary>
    let nationalTournamentBronze =
        Namespaced_IRI.parse _namespace_name "nationalTournamentBronze" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTournamentGold"></see>
    /// </summary>
    let nationalTournamentGold =
        Namespaced_IRI.parse _namespace_name "nationalTournamentGold" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalTournamentSilver"></see>
    /// </summary>
    let nationalTournamentSilver =
        Namespaced_IRI.parse _namespace_name "nationalTournamentSilver" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationalYears"></see>
    /// </summary>
    let nationalYears =
        Namespaced_IRI.parse _namespace_name "nationalYears" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nationality"></see>
    /// </summary>
    let nationality =
        Namespaced_IRI.parse _namespace_name "nationality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ncaaSeason"></see>
    /// </summary>
    let ncaaSeason = Namespaced_IRI.parse _namespace_name "ncaaSeason" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ncaaTeam"></see>
    /// </summary>
    let ncaaTeam = Namespaced_IRI.parse _namespace_name "ncaaTeam" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ncbhof"></see>
    /// </summary>
    let ncbhof = Namespaced_IRI.parse _namespace_name "ncbhof" |> NamespacedName
    /// <summary>
    /// National Diet Library of Japan identificator. http://id.ndl.go.jp/auth/ndlna/$1
    /// <see href="http://dbpedia.org/ontology/ndlId"></see></summary>
    let ndlId = Namespaced_IRI.parse _namespace_name "ndlId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nearestCity"></see>
    /// </summary>
    let nearestCity =
        Namespaced_IRI.parse _namespace_name "nearestCity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/neighboringMunicipality"></see>
    /// </summary>
    let neighboringMunicipality =
        Namespaced_IRI.parse _namespace_name "neighboringMunicipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/neighbourConstellations"></see>
    /// </summary>
    let neighbourConstellations =
        Namespaced_IRI.parse _namespace_name "neighbourConstellations" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/neighbourRegion"></see>
    /// </summary>
    let neighbourRegion =
        Namespaced_IRI.parse _namespace_name "neighbourRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/neighbourhood"></see>
    /// </summary>
    let neighbourhood =
        Namespaced_IRI.parse _namespace_name "neighbourhood" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nerve"></see>
    /// </summary>
    let nerve = Namespaced_IRI.parse _namespace_name "nerve" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/netIncome"></see>
    /// </summary>
    let netIncome = Namespaced_IRI.parse _namespace_name "netIncome" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/network"></see>
    /// </summary>
    let network = Namespaced_IRI.parse _namespace_name "network" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/networth"></see>
    /// </summary>
    let networth = Namespaced_IRI.parse _namespace_name "networth" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/newspaper"></see>
    /// </summary>
    let newspaper = Namespaced_IRI.parse _namespace_name "newspaper" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nextEntity"></see>
    /// </summary>
    let nextEntity = Namespaced_IRI.parse _namespace_name "nextEntity" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nextEvent"></see>
    /// </summary>
    let nextEvent = Namespaced_IRI.parse _namespace_name "nextEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nextMission"></see>
    /// </summary>
    let nextMission =
        Namespaced_IRI.parse _namespace_name "nextMission" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nflCode"></see>
    /// </summary>
    let nflCode = Namespaced_IRI.parse _namespace_name "nflCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nflSeason"></see>
    /// </summary>
    let nflSeason = Namespaced_IRI.parse _namespace_name "nflSeason" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nflTeam"></see>
    /// </summary>
    let nflTeam = Namespaced_IRI.parse _namespace_name "nflTeam" |> NamespacedName
    /// <summary>
    /// Name for NGC objects
    /// <see href="http://dbpedia.org/ontology/ngcName"></see></summary>
    let ngcName = Namespaced_IRI.parse _namespace_name "ngcName" |> NamespacedName
    /// <summary>
    /// Indexing code used by the Belgium National Statistical Institute to identify populated places.
    /// <see href="http://dbpedia.org/ontology/nisCode"></see></summary>
    let nisCode = Namespaced_IRI.parse _namespace_name "nisCode" |> NamespacedName
    /// <summary>
    /// NLA Trove’s People and Organisation view allows the discovery of biographical and other contextual information about people and organisations. Search also available via VIAF.
    /// <see href="http://dbpedia.org/ontology/nlaId"></see></summary>
    let nlaId = Namespaced_IRI.parse _namespace_name "nlaId" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nndbId"></see>
    /// </summary>
    let nndbId = Namespaced_IRI.parse _namespace_name "nndbId" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/noContest"></see>
    /// </summary>
    let noContest = Namespaced_IRI.parse _namespace_name "noContest" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nobelLaureates"></see>
    /// </summary>
    let nobelLaureates =
        Namespaced_IRI.parse _namespace_name "nobelLaureates" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nominee"></see>
    /// </summary>
    let nominee = Namespaced_IRI.parse _namespace_name "nominee" |> NamespacedName

    /// <summary>
    /// The subject of a non-fiction book (e.g.: History, Biography, Cookbook, Climate change, ...).
    /// <see href="http://dbpedia.org/ontology/nonFictionSubject"></see></summary>
    let nonFictionSubject =
        Namespaced_IRI.parse _namespace_name "nonFictionSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nonProfessionalCareer"></see>
    /// </summary>
    let nonProfessionalCareer =
        Namespaced_IRI.parse _namespace_name "nonProfessionalCareer" |> NamespacedName

    /// <summary>
    /// indicates another place situated north-east.
    /// <see href="http://dbpedia.org/ontology/northEastPlace"></see></summary>
    let northEastPlace =
        Namespaced_IRI.parse _namespace_name "northEastPlace" |> NamespacedName

    /// <summary>
    /// indicates another place situated north.
    /// <see href="http://dbpedia.org/ontology/northPlace"></see></summary>
    let northPlace = Namespaced_IRI.parse _namespace_name "northPlace" |> NamespacedName

    /// <summary>
    /// indicates another place situated north-west.
    /// <see href="http://dbpedia.org/ontology/northWestPlace"></see></summary>
    let northWestPlace =
        Namespaced_IRI.parse _namespace_name "northWestPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notSolubleIn"></see>
    /// </summary>
    let notSolubleIn =
        Namespaced_IRI.parse _namespace_name "notSolubleIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notableCommander"></see>
    /// </summary>
    let notableCommander =
        Namespaced_IRI.parse _namespace_name "notableCommander" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notableFeatures"></see>
    /// </summary>
    let notableFeatures =
        Namespaced_IRI.parse _namespace_name "notableFeatures" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notableIdea"></see>
    /// </summary>
    let notableIdea =
        Namespaced_IRI.parse _namespace_name "notableIdea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notableStudent"></see>
    /// </summary>
    let notableStudent =
        Namespaced_IRI.parse _namespace_name "notableStudent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notableWine"></see>
    /// </summary>
    let notableWine =
        Namespaced_IRI.parse _namespace_name "notableWine" |> NamespacedName

    /// <summary>
    /// Notable work of a person (eg Artist, Engineer, etc)
    /// <see href="http://dbpedia.org/ontology/notableWork"></see></summary>
    let notableWork =
        Namespaced_IRI.parse _namespace_name "notableWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/note"></see>
    /// </summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/noteOnPlaceOfBurial"></see>
    /// </summary>
    let noteOnPlaceOfBurial =
        Namespaced_IRI.parse _namespace_name "noteOnPlaceOfBurial" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/noteOnRestingPlace"></see>
    /// </summary>
    let noteOnRestingPlace =
        Namespaced_IRI.parse _namespace_name "noteOnRestingPlace" |> NamespacedName

    /// <summary>
    /// additional notes that better describe the entity.
    /// <see href="http://dbpedia.org/ontology/notes"></see></summary>
    let notes = Namespaced_IRI.parse _namespace_name "notes" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/notifyDate"></see>
    /// </summary>
    let notifyDate = Namespaced_IRI.parse _namespace_name "notifyDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/novel"></see>
    /// </summary>
    let novel = Namespaced_IRI.parse _namespace_name "novel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nrhpReferenceNumber"></see>
    /// </summary>
    let nrhpReferenceNumber =
        Namespaced_IRI.parse _namespace_name "nrhpReferenceNumber" |> NamespacedName

    /// <summary>
    /// Type of historic place as defined by the US National Park Service. For instance National Historic Landmark, National Monument or National Battlefield.
    /// <see href="http://dbpedia.org/ontology/nrhpType"></see></summary>
    let nrhpType = Namespaced_IRI.parse _namespace_name "nrhpType" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/nssdcId"></see>
    /// </summary>
    let nssdcId = Namespaced_IRI.parse _namespace_name "nssdcId" |> NamespacedName
    /// <summary>
    /// Jersey number of an Athlete (sports player, eg "99") or sequential number of an Album (eg "Third studio album")
    /// <see href="http://dbpedia.org/ontology/number"></see></summary>
    let number = Namespaced_IRI.parse _namespace_name "number" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberBuilt"></see>
    /// </summary>
    let numberBuilt =
        Namespaced_IRI.parse _namespace_name "numberBuilt" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfAcademicStaff"></see>
    /// </summary>
    let numberOfAcademicStaff =
        Namespaced_IRI.parse _namespace_name "numberOfAcademicStaff" |> NamespacedName

    /// <summary>
    /// the total number of albums released by the musical artist
    /// <see href="http://dbpedia.org/ontology/numberOfAlbums"></see></summary>
    let numberOfAlbums =
        Namespaced_IRI.parse _namespace_name "numberOfAlbums" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfArrondissement"></see>
    /// </summary>
    let numberOfArrondissement =
        Namespaced_IRI.parse _namespace_name "numberOfArrondissement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfBombs"></see>
    /// </summary>
    let numberOfBombs =
        Namespaced_IRI.parse _namespace_name "numberOfBombs" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfBronzeMedalsWon"></see>
    /// </summary>
    let numberOfBronzeMedalsWon =
        Namespaced_IRI.parse _namespace_name "numberOfBronzeMedalsWon" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCanton"></see>
    /// </summary>
    let numberOfCanton =
        Namespaced_IRI.parse _namespace_name "numberOfCanton" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCantons"></see>
    /// </summary>
    let numberOfCantons =
        Namespaced_IRI.parse _namespace_name "numberOfCantons" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCapitalDeputies"></see>
    /// </summary>
    let numberOfCapitalDeputies =
        Namespaced_IRI.parse _namespace_name "numberOfCapitalDeputies" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCity"></see>
    /// </summary>
    let numberOfCity =
        Namespaced_IRI.parse _namespace_name "numberOfCity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfClassrooms"></see>
    /// </summary>
    let numberOfClassrooms =
        Namespaced_IRI.parse _namespace_name "numberOfClassrooms" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfClubs"></see>
    /// </summary>
    let numberOfClubs =
        Namespaced_IRI.parse _namespace_name "numberOfClubs" |> NamespacedName

    /// <summary>
    /// Indication as to the size of the collection of this library
    /// <see href="http://dbpedia.org/ontology/numberOfCollectionItems"></see></summary>
    let numberOfCollectionItems =
        Namespaced_IRI.parse _namespace_name "numberOfCollectionItems" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCompetitors"></see>
    /// </summary>
    let numberOfCompetitors =
        Namespaced_IRI.parse _namespace_name "numberOfCompetitors" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCounties"></see>
    /// </summary>
    let numberOfCounties =
        Namespaced_IRI.parse _namespace_name "numberOfCounties" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCountries"></see>
    /// </summary>
    let numberOfCountries =
        Namespaced_IRI.parse _namespace_name "numberOfCountries" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfCrew"></see>
    /// </summary>
    let numberOfCrew =
        Namespaced_IRI.parse _namespace_name "numberOfCrew" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfDeaths"></see>
    /// </summary>
    let numberOfDeaths =
        Namespaced_IRI.parse _namespace_name "numberOfDeaths" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfDependency"></see>
    /// </summary>
    let numberOfDependency =
        Namespaced_IRI.parse _namespace_name "numberOfDependency" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfDistrict"></see>
    /// </summary>
    let numberOfDistrict =
        Namespaced_IRI.parse _namespace_name "numberOfDistrict" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfDistricts"></see>
    /// </summary>
    let numberOfDistricts =
        Namespaced_IRI.parse _namespace_name "numberOfDistricts" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfDoctoralStudents"></see>
    /// </summary>
    let numberOfDoctoralStudents =
        Namespaced_IRI.parse _namespace_name "numberOfDoctoralStudents" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfEmployees"></see>
    /// </summary>
    let numberOfEmployees =
        Namespaced_IRI.parse _namespace_name "numberOfEmployees" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfEntrances"></see>
    /// </summary>
    let numberOfEntrances =
        Namespaced_IRI.parse _namespace_name "numberOfEntrances" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfEpisodes"></see>
    /// </summary>
    let numberOfEpisodes =
        Namespaced_IRI.parse _namespace_name "numberOfEpisodes" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfFederalDeputies"></see>
    /// </summary>
    let numberOfFederalDeputies =
        Namespaced_IRI.parse _namespace_name "numberOfFederalDeputies" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfFilms"></see>
    /// </summary>
    let numberOfFilms =
        Namespaced_IRI.parse _namespace_name "numberOfFilms" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfGoals"></see>
    /// </summary>
    let numberOfGoals =
        Namespaced_IRI.parse _namespace_name "numberOfGoals" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfGoldMedalsWon"></see>
    /// </summary>
    let numberOfGoldMedalsWon =
        Namespaced_IRI.parse _namespace_name "numberOfGoldMedalsWon" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfGraduateStudents"></see>
    /// </summary>
    let numberOfGraduateStudents =
        Namespaced_IRI.parse _namespace_name "numberOfGraduateStudents" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfGraves"></see>
    /// </summary>
    let numberOfGraves =
        Namespaced_IRI.parse _namespace_name "numberOfGraves" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfHoles"></see>
    /// </summary>
    let numberOfHoles =
        Namespaced_IRI.parse _namespace_name "numberOfHoles" |> NamespacedName

    /// <summary>
    /// Count of the houses in the Protected Area
    /// <see href="http://dbpedia.org/ontology/numberOfHouses"></see></summary>
    let numberOfHouses =
        Namespaced_IRI.parse _namespace_name "numberOfHouses" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfIntercommunality"></see>
    /// </summary>
    let numberOfIntercommunality =
        Namespaced_IRI.parse _namespace_name "numberOfIntercommunality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfIsland"></see>
    /// </summary>
    let numberOfIsland =
        Namespaced_IRI.parse _namespace_name "numberOfIsland" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfIslands"></see>
    /// </summary>
    let numberOfIslands =
        Namespaced_IRI.parse _namespace_name "numberOfIslands" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfLanes"></see>
    /// </summary>
    let numberOfLanes =
        Namespaced_IRI.parse _namespace_name "numberOfLanes" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfLaps"></see>
    /// </summary>
    let numberOfLaps =
        Namespaced_IRI.parse _namespace_name "numberOfLaps" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfLaunches"></see>
    /// </summary>
    let numberOfLaunches =
        Namespaced_IRI.parse _namespace_name "numberOfLaunches" |> NamespacedName

    /// <summary>
    /// Number of lawyers or attorneys in the company.
    /// <see href="http://dbpedia.org/ontology/numberOfLawyers"></see></summary>
    let numberOfLawyers =
        Namespaced_IRI.parse _namespace_name "numberOfLawyers" |> NamespacedName

    /// <summary>
    /// Number of lines in the transit system.
    /// <see href="http://dbpedia.org/ontology/numberOfLines"></see></summary>
    let numberOfLines =
        Namespaced_IRI.parse _namespace_name "numberOfLines" |> NamespacedName

    /// <summary>
    /// the number of live albums released by the musical artist
    /// <see href="http://dbpedia.org/ontology/numberOfLiveAlbums"></see></summary>
    let numberOfLiveAlbums =
        Namespaced_IRI.parse _namespace_name "numberOfLiveAlbums" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfLocations"></see>
    /// </summary>
    let numberOfLocations =
        Namespaced_IRI.parse _namespace_name "numberOfLocations" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfMatches"></see>
    /// </summary>
    let numberOfMatches =
        Namespaced_IRI.parse _namespace_name "numberOfMatches" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfMembers"></see>
    /// </summary>
    let numberOfMembers =
        Namespaced_IRI.parse _namespace_name "numberOfMembers" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfMembersAsOf"></see>
    /// </summary>
    let numberOfMembersAsOf =
        Namespaced_IRI.parse _namespace_name "numberOfMembersAsOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfMinistries"></see>
    /// </summary>
    let numberOfMinistries =
        Namespaced_IRI.parse _namespace_name "numberOfMinistries" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfMunicipalities"></see>
    /// </summary>
    let numberOfMunicipalities =
        Namespaced_IRI.parse _namespace_name "numberOfMunicipalities" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfNeighbourhood"></see>
    /// </summary>
    let numberOfNeighbourhood =
        Namespaced_IRI.parse _namespace_name "numberOfNeighbourhood" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfNewlyIntroducedSports"></see>
    /// </summary>
    let numberOfNewlyIntroducedSports =
        Namespaced_IRI.parse _namespace_name "numberOfNewlyIntroducedSports" |> NamespacedName

    /// <summary>
    /// Number of the company's offices.
    /// <see href="http://dbpedia.org/ontology/numberOfOffices"></see></summary>
    let numberOfOffices =
        Namespaced_IRI.parse _namespace_name "numberOfOffices" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfOfficials"></see>
    /// </summary>
    let numberOfOfficials =
        Namespaced_IRI.parse _namespace_name "numberOfOfficials" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfOrbits"></see>
    /// </summary>
    let numberOfOrbits =
        Namespaced_IRI.parse _namespace_name "numberOfOrbits" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfPads"></see>
    /// </summary>
    let numberOfPads =
        Namespaced_IRI.parse _namespace_name "numberOfPads" |> NamespacedName

    /// <summary>
    /// The books number of pages.
    /// <see href="http://dbpedia.org/ontology/numberOfPages"></see></summary>
    let numberOfPages =
        Namespaced_IRI.parse _namespace_name "numberOfPages" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfParkingSpaces"></see>
    /// </summary>
    let numberOfParkingSpaces =
        Namespaced_IRI.parse _namespace_name "numberOfParkingSpaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfParticipatingAthletes"></see>
    /// </summary>
    let numberOfParticipatingAthletes =
        Namespaced_IRI.parse _namespace_name "numberOfParticipatingAthletes" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfParticipatingFemaleAthletes"></see>
    /// </summary>
    let numberOfParticipatingFemaleAthletes =
        Namespaced_IRI.parse _namespace_name "numberOfParticipatingFemaleAthletes" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfParticipatingMaleAthletes"></see>
    /// </summary>
    let numberOfParticipatingMaleAthletes =
        Namespaced_IRI.parse _namespace_name "numberOfParticipatingMaleAthletes" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfParticipatingNations"></see>
    /// </summary>
    let numberOfParticipatingNations =
        Namespaced_IRI.parse _namespace_name "numberOfParticipatingNations" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfPeopleAttending"></see>
    /// </summary>
    let numberOfPeopleAttending =
        Namespaced_IRI.parse _namespace_name "numberOfPeopleAttending" |> NamespacedName

    /// <summary>
    /// nombre de personnes ayant une license pour pratiquer cette activité
    /// <see href="http://dbpedia.org/ontology/numberOfPeopleLicensed"></see></summary>
    let numberOfPeopleLicensed =
        Namespaced_IRI.parse _namespace_name "numberOfPeopleLicensed" |> NamespacedName

    /// <summary>
    /// Number of piers standing in a river or other water in normal conditions.
    /// <see href="http://dbpedia.org/ontology/numberOfPiersInWater"></see></summary>
    let numberOfPiersInWater =
        Namespaced_IRI.parse _namespace_name "numberOfPiersInWater" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfPixels"></see>
    /// </summary>
    let numberOfPixels =
        Namespaced_IRI.parse _namespace_name "numberOfPixels" |> NamespacedName

    /// <summary>
    /// Number of levels of platforms at the station.
    /// <see href="http://dbpedia.org/ontology/numberOfPlatformLevels"></see></summary>
    let numberOfPlatformLevels =
        Namespaced_IRI.parse _namespace_name "numberOfPlatformLevels" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfPlayers"></see>
    /// </summary>
    let numberOfPlayers =
        Namespaced_IRI.parse _namespace_name "numberOfPlayers" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfPostgraduateStudents"></see>
    /// </summary>
    let numberOfPostgraduateStudents =
        Namespaced_IRI.parse _namespace_name "numberOfPostgraduateStudents" |> NamespacedName

    /// <summary>
    /// number of people who earns his living from a specified activity.
    /// <see href="http://dbpedia.org/ontology/numberOfProfessionals"></see></summary>
    let numberOfProfessionals =
        Namespaced_IRI.parse _namespace_name "numberOfProfessionals" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfReactors"></see>
    /// </summary>
    let numberOfReactors =
        Namespaced_IRI.parse _namespace_name "numberOfReactors" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfRestaurants"></see>
    /// </summary>
    let numberOfRestaurants =
        Namespaced_IRI.parse _namespace_name "numberOfRestaurants" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfRockets"></see>
    /// </summary>
    let numberOfRockets =
        Namespaced_IRI.parse _namespace_name "numberOfRockets" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfRooms"></see>
    /// </summary>
    let numberOfRooms =
        Namespaced_IRI.parse _namespace_name "numberOfRooms" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfRun"></see>
    /// </summary>
    let numberOfRun =
        Namespaced_IRI.parse _namespace_name "numberOfRun" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSeasons"></see>
    /// </summary>
    let numberOfSeasons =
        Namespaced_IRI.parse _namespace_name "numberOfSeasons" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSeats"></see>
    /// </summary>
    let numberOfSeats =
        Namespaced_IRI.parse _namespace_name "numberOfSeats" |> NamespacedName

    /// <summary>
    /// number of seats in House of Commons-like parliaments
    /// <see href="http://dbpedia.org/ontology/numberOfSeatsInParliament"></see></summary>
    let numberOfSeatsInParliament =
        Namespaced_IRI.parse _namespace_name "numberOfSeatsInParliament" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSettlement"></see>
    /// </summary>
    let numberOfSettlement =
        Namespaced_IRI.parse _namespace_name "numberOfSettlement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSilverMedalsWon"></see>
    /// </summary>
    let numberOfSilverMedalsWon =
        Namespaced_IRI.parse _namespace_name "numberOfSilverMedalsWon" |> NamespacedName

    /// <summary>
    /// Number of spans or arches.
    /// <see href="http://dbpedia.org/ontology/numberOfSpans"></see></summary>
    let numberOfSpans =
        Namespaced_IRI.parse _namespace_name "numberOfSpans" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSpeakers"></see>
    /// </summary>
    let numberOfSpeakers =
        Namespaced_IRI.parse _namespace_name "numberOfSpeakers" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSports"></see>
    /// </summary>
    let numberOfSports =
        Namespaced_IRI.parse _namespace_name "numberOfSports" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSportsEvents"></see>
    /// </summary>
    let numberOfSportsEvents =
        Namespaced_IRI.parse _namespace_name "numberOfSportsEvents" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfStaff"></see>
    /// </summary>
    let numberOfStaff =
        Namespaced_IRI.parse _namespace_name "numberOfStaff" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfStars"></see>
    /// </summary>
    let numberOfStars =
        Namespaced_IRI.parse _namespace_name "numberOfStars" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfStateDeputies"></see>
    /// </summary>
    let numberOfStateDeputies =
        Namespaced_IRI.parse _namespace_name "numberOfStateDeputies" |> NamespacedName

    /// <summary>
    /// Number of stations or stops.
    /// <see href="http://dbpedia.org/ontology/numberOfStations"></see></summary>
    let numberOfStations =
        Namespaced_IRI.parse _namespace_name "numberOfStations" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfStudents"></see>
    /// </summary>
    let numberOfStudents =
        Namespaced_IRI.parse _namespace_name "numberOfStudents" |> NamespacedName

    /// <summary>
    /// the number of studio albums released by the musical artist
    /// <see href="http://dbpedia.org/ontology/numberOfStudioAlbums"></see></summary>
    let numberOfStudioAlbums =
        Namespaced_IRI.parse _namespace_name "numberOfStudioAlbums" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfSuites"></see>
    /// </summary>
    let numberOfSuites =
        Namespaced_IRI.parse _namespace_name "numberOfSuites" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfTeams"></see>
    /// </summary>
    let numberOfTeams =
        Namespaced_IRI.parse _namespace_name "numberOfTeams" |> NamespacedName

    /// <summary>
    /// Number of tracks of a railway or railway station.
    /// <see href="http://dbpedia.org/ontology/numberOfTracks"></see></summary>
    let numberOfTracks =
        Namespaced_IRI.parse _namespace_name "numberOfTracks" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfTurns"></see>
    /// </summary>
    let numberOfTurns =
        Namespaced_IRI.parse _namespace_name "numberOfTurns" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfUndergraduateStudents"></see>
    /// </summary>
    let numberOfUndergraduateStudents =
        Namespaced_IRI.parse _namespace_name "numberOfUndergraduateStudents" |> NamespacedName

    /// <summary>
    /// Number of vehicles used in the transit system.
    /// <see href="http://dbpedia.org/ontology/numberOfVehicles"></see></summary>
    let numberOfVehicles =
        Namespaced_IRI.parse _namespace_name "numberOfVehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfVillages"></see>
    /// </summary>
    let numberOfVillages =
        Namespaced_IRI.parse _namespace_name "numberOfVillages" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfVineyards"></see>
    /// </summary>
    let numberOfVineyards =
        Namespaced_IRI.parse _namespace_name "numberOfVineyards" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfVisitors"></see>
    /// </summary>
    let numberOfVisitors =
        Namespaced_IRI.parse _namespace_name "numberOfVisitors" |> NamespacedName

    /// <summary>
    /// The year in which number of visitors occurred.
    /// <see href="http://dbpedia.org/ontology/numberOfVisitorsAsOf"></see></summary>
    let numberOfVisitorsAsOf =
        Namespaced_IRI.parse _namespace_name "numberOfVisitorsAsOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfVolumes"></see>
    /// </summary>
    let numberOfVolumes =
        Namespaced_IRI.parse _namespace_name "numberOfVolumes" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfVolunteers"></see>
    /// </summary>
    let numberOfVolunteers =
        Namespaced_IRI.parse _namespace_name "numberOfVolunteers" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/numberOfWineries"></see>
    /// </summary>
    let numberOfWineries =
        Namespaced_IRI.parse _namespace_name "numberOfWineries" |> NamespacedName

    /// <summary>
    /// Number of things (eg vehicles) sold
    /// <see href="http://dbpedia.org/ontology/numberSold"></see></summary>
    let numberSold = Namespaced_IRI.parse _namespace_name "numberSold" |> NamespacedName
    /// <summary>
    /// Nomenclature of Territorial Units for Statistics (NUTS) is a geocode  standard for referencing the subdivisions of countries  for statistical purposes. The standard is developed and regulated by the European Union, and thus only covers the member states of the EU in detail.
    /// <see href="http://dbpedia.org/ontology/nutsCode"></see></summary>
    let nutsCode = Namespaced_IRI.parse _namespace_name "nutsCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/observatory"></see>
    /// </summary>
    let observatory =
        Namespaced_IRI.parse _namespace_name "observatory" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/occupation"></see>
    /// </summary>
    let occupation = Namespaced_IRI.parse _namespace_name "occupation" |> NamespacedName
    /// <summary>
    /// Online Computer Library Center number
    /// <see href="http://dbpedia.org/ontology/oclc"></see></summary>
    let oclc = Namespaced_IRI.parse _namespace_name "oclc" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/offeredClasses"></see>
    /// </summary>
    let offeredClasses =
        Namespaced_IRI.parse _namespace_name "offeredClasses" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/office"></see>
    /// </summary>
    let office = Namespaced_IRI.parse _namespace_name "office" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/officerInCharge"></see>
    /// </summary>
    let officerInCharge =
        Namespaced_IRI.parse _namespace_name "officerInCharge" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/officialLanguage"></see>
    /// </summary>
    let officialLanguage =
        Namespaced_IRI.parse _namespace_name "officialLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/officialName"></see>
    /// </summary>
    let officialName =
        Namespaced_IRI.parse _namespace_name "officialName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/officialOpenedBy"></see>
    /// </summary>
    let officialOpenedBy =
        Namespaced_IRI.parse _namespace_name "officialOpenedBy" |> NamespacedName

    /// <summary>
    /// The official colour of the EducationalInstitution represented by the colour name (e.g.: red or green).
    /// <see href="http://dbpedia.org/ontology/officialSchoolColour"></see></summary>
    let officialSchoolColour =
        Namespaced_IRI.parse _namespace_name "officialSchoolColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ColourName"></see>
    /// </summary>
    let ColourName = Namespaced_IRI.parse _namespace_name "ColourName" |> NamespacedName
    /// <summary>
    /// Identifier used by the Swiss Federal Institute for Statistics
    /// <see href="http://dbpedia.org/ontology/ofsCode"></see></summary>
    let ofsCode = Namespaced_IRI.parse _namespace_name "ofsCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oilSystem"></see>
    /// </summary>
    let oilSystem = Namespaced_IRI.parse _namespace_name "oilSystem" |> NamespacedName
    /// <summary>
    /// Code used to indentify populated places in Russia
    /// <see href="http://dbpedia.org/ontology/okatoCode"></see></summary>
    let okatoCode = Namespaced_IRI.parse _namespace_name "okatoCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oldDistrict"></see>
    /// </summary>
    let oldDistrict =
        Namespaced_IRI.parse _namespace_name "oldDistrict" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oldName"></see>
    /// </summary>
    let oldName = Namespaced_IRI.parse _namespace_name "oldName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oldProvince"></see>
    /// </summary>
    let oldProvince =
        Namespaced_IRI.parse _namespace_name "oldProvince" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oldTeamCoached"></see>
    /// </summary>
    let oldTeamCoached =
        Namespaced_IRI.parse _namespace_name "oldTeamCoached" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oldcode"></see>
    /// </summary>
    let oldcode = Namespaced_IRI.parse _namespace_name "oldcode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olivierAward"></see>
    /// </summary>
    let olivierAward =
        Namespaced_IRI.parse _namespace_name "olivierAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicGames"></see>
    /// </summary>
    let olympicGames =
        Namespaced_IRI.parse _namespace_name "olympicGames" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicGamesBronze"></see>
    /// </summary>
    let olympicGamesBronze =
        Namespaced_IRI.parse _namespace_name "olympicGamesBronze" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicGamesGold"></see>
    /// </summary>
    let olympicGamesGold =
        Namespaced_IRI.parse _namespace_name "olympicGamesGold" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicGamesSilver"></see>
    /// </summary>
    let olympicGamesSilver =
        Namespaced_IRI.parse _namespace_name "olympicGamesSilver" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicGamesWins"></see>
    /// </summary>
    let olympicGamesWins =
        Namespaced_IRI.parse _namespace_name "olympicGamesWins" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicOathSwornBy"></see>
    /// </summary>
    let olympicOathSwornBy =
        Namespaced_IRI.parse _namespace_name "olympicOathSwornBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicOathSwornByAthlete"></see>
    /// </summary>
    let olympicOathSwornByAthlete =
        Namespaced_IRI.parse _namespace_name "olympicOathSwornByAthlete" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/olympicOathSwornByJudge"></see>
    /// </summary>
    let olympicOathSwornByJudge =
        Namespaced_IRI.parse _namespace_name "olympicOathSwornByJudge" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/omim"></see>
    /// </summary>
    let omim = Namespaced_IRI.parse _namespace_name "omim" |> NamespacedName

    /// <summary>
    /// the number corresponding to the chromosome on which the gene is located
    /// <see href="http://dbpedia.org/ontology/onChromosome"></see></summary>
    let onChromosome =
        Namespaced_IRI.parse _namespace_name "onChromosome" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ons"></see>
    /// </summary>
    let ons = Namespaced_IRI.parse _namespace_name "ons" |> NamespacedName

    /// <summary>
    /// Availability of open access content.
    /// <see href="http://dbpedia.org/ontology/openAccessContent"></see></summary>
    let openAccessContent =
        Namespaced_IRI.parse _namespace_name "openAccessContent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/openingDate"></see>
    /// </summary>
    let openingDate =
        Namespaced_IRI.parse _namespace_name "openingDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/openingFilm"></see>
    /// </summary>
    let openingFilm =
        Namespaced_IRI.parse _namespace_name "openingFilm" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/openingTheme"></see>
    /// </summary>
    let openingTheme =
        Namespaced_IRI.parse _namespace_name "openingTheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/openingYear"></see>
    /// </summary>
    let openingYear =
        Namespaced_IRI.parse _namespace_name "openingYear" |> NamespacedName

    /// <summary>
    /// Organisation or city who is the operator of an ArchitecturalStructure, PublicTransitSystem, etc. Not to confuse with maintainer or the owner.
    /// <see href="http://dbpedia.org/ontology/operatedBy"></see></summary>
    let operatedBy = Namespaced_IRI.parse _namespace_name "operatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/operatingIncome"></see>
    /// </summary>
    let operatingIncome =
        Namespaced_IRI.parse _namespace_name "operatingIncome" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/operatingSystem"></see>
    /// </summary>
    let operatingSystem =
        Namespaced_IRI.parse _namespace_name "operatingSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/operator"></see>
    /// </summary>
    let operator = Namespaced_IRI.parse _namespace_name "operator" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/opponent"></see>
    /// </summary>
    let opponent = Namespaced_IRI.parse _namespace_name "opponent" |> NamespacedName
    /// <summary>
    /// "opponent in a military conflict, an organisation, country, or group of countries. "
    /// <see href="http://dbpedia.org/ontology/opponents"></see></summary>
    let opponents = Namespaced_IRI.parse _namespace_name "opponents" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orbitalEccentricity"></see>
    /// </summary>
    let orbitalEccentricity =
        Namespaced_IRI.parse _namespace_name "orbitalEccentricity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orbitalFlights"></see>
    /// </summary>
    let orbitalFlights =
        Namespaced_IRI.parse _namespace_name "orbitalFlights" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orbitalInclination"></see>
    /// </summary>
    let orbitalInclination =
        Namespaced_IRI.parse _namespace_name "orbitalInclination" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orbitalPeriod"></see>
    /// </summary>
    let orbitalPeriod =
        Namespaced_IRI.parse _namespace_name "orbitalPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orbits"></see>
    /// </summary>
    let orbits = Namespaced_IRI.parse _namespace_name "orbits" |> NamespacedName
    /// <summary>
    /// Authority data on researchers, academics, etc. The ID range has been defined as a subset of the forthcoming ISNI range.
    /// <see href="http://dbpedia.org/ontology/orcidId"></see></summary>
    let orcidId = Namespaced_IRI.parse _namespace_name "orcidId" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/order"></see>
    /// </summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orderDate"></see>
    /// </summary>
    let orderDate = Namespaced_IRI.parse _namespace_name "orderDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orderInOffice"></see>
    /// </summary>
    let orderInOffice =
        Namespaced_IRI.parse _namespace_name "orderInOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ordination"></see>
    /// </summary>
    let ordination = Namespaced_IRI.parse _namespace_name "ordination" |> NamespacedName
    /// <summary>
    /// Name and/or description of the organ
    /// <see href="http://dbpedia.org/ontology/organ"></see></summary>
    let organ = Namespaced_IRI.parse _namespace_name "organ" |> NamespacedName

    /// <summary>
    /// the organ system that a anatomical structure belongs to
    /// <see href="http://dbpedia.org/ontology/organSystem"></see></summary>
    let organSystem =
        Namespaced_IRI.parse _namespace_name "organSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/organisation"></see>
    /// </summary>
    let organisation =
        Namespaced_IRI.parse _namespace_name "organisation" |> NamespacedName

    /// <summary>
    /// Identify the members of an organisation.
    /// <see href="http://dbpedia.org/ontology/organisationMember"></see></summary>
    let organisationMember =
        Namespaced_IRI.parse _namespace_name "organisationMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orientation"></see>
    /// </summary>
    let orientation =
        Namespaced_IRI.parse _namespace_name "orientation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/origin"></see>
    /// </summary>
    let origin = Namespaced_IRI.parse _namespace_name "origin" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/originalDanseCompetition"></see>
    /// </summary>
    let originalDanseCompetition =
        Namespaced_IRI.parse _namespace_name "originalDanseCompetition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/originalDanseScore"></see>
    /// </summary>
    let originalDanseScore =
        Namespaced_IRI.parse _namespace_name "originalDanseScore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/originalEndPoint"></see>
    /// </summary>
    let originalEndPoint =
        Namespaced_IRI.parse _namespace_name "originalEndPoint" |> NamespacedName

    /// <summary>
    /// The original language of the work.
    /// <see href="http://dbpedia.org/ontology/originalLanguage"></see></summary>
    let originalLanguage =
        Namespaced_IRI.parse _namespace_name "originalLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/originalMaximumBoatBeam"></see>
    /// </summary>
    let originalMaximumBoatBeam =
        Namespaced_IRI.parse _namespace_name "originalMaximumBoatBeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/originalMaximumBoatLength"></see>
    /// </summary>
    let originalMaximumBoatLength =
        Namespaced_IRI.parse _namespace_name "originalMaximumBoatLength" |> NamespacedName

    /// <summary>
    /// The original name of the entity, e.g. film, settlement, etc.
    /// <see href="http://dbpedia.org/ontology/originalName"></see></summary>
    let originalName =
        Namespaced_IRI.parse _namespace_name "originalName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/originalStartPoint"></see>
    /// </summary>
    let originalStartPoint =
        Namespaced_IRI.parse _namespace_name "originalStartPoint" |> NamespacedName

    /// <summary>
    /// The original title of the work, most of the time in the original language as well
    /// <see href="http://dbpedia.org/ontology/originalTitle"></see></summary>
    let originalTitle =
        Namespaced_IRI.parse _namespace_name "originalTitle" |> NamespacedName

    /// <summary>
    /// Original use of the architectural structure, if it is currently being used as anything other than its original purpose.
    /// <see href="http://dbpedia.org/ontology/originallyUsedFor"></see></summary>
    let originallyUsedFor =
        Namespaced_IRI.parse _namespace_name "originallyUsedFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/origo"></see>
    /// </summary>
    let origo = Namespaced_IRI.parse _namespace_name "origo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orogeny"></see>
    /// </summary>
    let orogeny = Namespaced_IRI.parse _namespace_name "orogeny" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/orthologousGene"></see>
    /// </summary>
    let orthologousGene =
        Namespaced_IRI.parse _namespace_name "orthologousGene" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/other"></see>
    /// </summary>
    let other = Namespaced_IRI.parse _namespace_name "other" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherActivity"></see>
    /// </summary>
    let otherActivity =
        Namespaced_IRI.parse _namespace_name "otherActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherAppearances"></see>
    /// </summary>
    let otherAppearances =
        Namespaced_IRI.parse _namespace_name "otherAppearances" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherChannel"></see>
    /// </summary>
    let otherChannel =
        Namespaced_IRI.parse _namespace_name "otherChannel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherFamilyBranch"></see>
    /// </summary>
    let otherFamilyBranch =
        Namespaced_IRI.parse _namespace_name "otherFamilyBranch" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherFuelType"></see>
    /// </summary>
    let otherFuelType =
        Namespaced_IRI.parse _namespace_name "otherFuelType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherFunction"></see>
    /// </summary>
    let otherFunction =
        Namespaced_IRI.parse _namespace_name "otherFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherInformation"></see>
    /// </summary>
    let otherInformation =
        Namespaced_IRI.parse _namespace_name "otherInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherLanguage"></see>
    /// </summary>
    let otherLanguage =
        Namespaced_IRI.parse _namespace_name "otherLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherMedia"></see>
    /// </summary>
    let otherMedia = Namespaced_IRI.parse _namespace_name "otherMedia" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherName"></see>
    /// </summary>
    let otherName = Namespaced_IRI.parse _namespace_name "otherName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherOccupation"></see>
    /// </summary>
    let otherOccupation =
        Namespaced_IRI.parse _namespace_name "otherOccupation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherParty"></see>
    /// </summary>
    let otherParty = Namespaced_IRI.parse _namespace_name "otherParty" |> NamespacedName

    /// <summary>
    /// Connecting services that serve the station such as bus, etc.
    /// <see href="http://dbpedia.org/ontology/otherServingLines"></see></summary>
    let otherServingLines =
        Namespaced_IRI.parse _namespace_name "otherServingLines" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherSportsExperience"></see>
    /// </summary>
    let otherSportsExperience =
        Namespaced_IRI.parse _namespace_name "otherSportsExperience" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/otherWins"></see>
    /// </summary>
    let otherWins = Namespaced_IRI.parse _namespace_name "otherWins" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Wins"></see>
    /// </summary>
    let Wins = Namespaced_IRI.parse _namespace_name "Wins" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/outflow"></see>
    /// </summary>
    let outflow = Namespaced_IRI.parse _namespace_name "outflow" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/output"></see>
    /// </summary>
    let output = Namespaced_IRI.parse _namespace_name "output" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/outskirts"></see>
    /// </summary>
    let outskirts = Namespaced_IRI.parse _namespace_name "outskirts" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/overallRecord"></see>
    /// </summary>
    let overallRecord =
        Namespaced_IRI.parse _namespace_name "overallRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/oversight"></see>
    /// </summary>
    let oversight = Namespaced_IRI.parse _namespace_name "oversight" |> NamespacedName
    /// <summary>
    /// Used as if meaning: owned by, has as its owner
    /// <see href="http://dbpedia.org/ontology/owner"></see></summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/owningCompany"></see>
    /// </summary>
    let owningCompany =
        Namespaced_IRI.parse _namespace_name "owningCompany" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/owningOrganisation"></see>
    /// </summary>
    let owningOrganisation =
        Namespaced_IRI.parse _namespace_name "owningOrganisation" |> NamespacedName

    /// <summary>
    /// Used as if meaning: has property rights over
    /// <see href="http://dbpedia.org/ontology/owns"></see></summary>
    let owns = Namespaced_IRI.parse _namespace_name "owns" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Thing"></see>
    /// </summary>
    let Thing = Namespaced_IRI.parse _namespace_name "Thing" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/painter"></see>
    /// </summary>
    let painter = Namespaced_IRI.parse _namespace_name "painter" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parent"></see>
    /// </summary>
    let parent = Namespaced_IRI.parse _namespace_name "parent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parentCompany"></see>
    /// </summary>
    let parentCompany =
        Namespaced_IRI.parse _namespace_name "parentCompany" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parentMountainPeak"></see>
    /// </summary>
    let parentMountainPeak =
        Namespaced_IRI.parse _namespace_name "parentMountainPeak" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parentOrganisation"></see>
    /// </summary>
    let parentOrganisation =
        Namespaced_IRI.parse _namespace_name "parentOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parish"></see>
    /// </summary>
    let parish = Namespaced_IRI.parse _namespace_name "parish" |> NamespacedName

    /// <summary>
    /// Information on station's parking facilities.
    /// <see href="http://dbpedia.org/ontology/parkingInformation"></see></summary>
    let parkingInformation =
        Namespaced_IRI.parse _namespace_name "parkingInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parkingLotsCars"></see>
    /// </summary>
    let parkingLotsCars =
        Namespaced_IRI.parse _namespace_name "parkingLotsCars" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parkingLotsTrucks"></see>
    /// </summary>
    let parkingLotsTrucks =
        Namespaced_IRI.parse _namespace_name "parkingLotsTrucks" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parliament"></see>
    /// </summary>
    let parliament = Namespaced_IRI.parse _namespace_name "parliament" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parliamentType"></see>
    /// </summary>
    let parliamentType =
        Namespaced_IRI.parse _namespace_name "parliamentType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/parliamentaryGroup"></see>
    /// </summary>
    let parliamentaryGroup =
        Namespaced_IRI.parse _namespace_name "parliamentaryGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/part"></see>
    /// </summary>
    let part = Namespaced_IRI.parse _namespace_name "part" |> NamespacedName

    /// <summary>
    /// total number of launches resulting in partial failure
    /// <see href="http://dbpedia.org/ontology/partialFailedLaunches"></see></summary>
    let partialFailedLaunches =
        Namespaced_IRI.parse _namespace_name "partialFailedLaunches" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/participant"></see>
    /// </summary>
    let participant =
        Namespaced_IRI.parse _namespace_name "participant" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/participatingIn"></see>
    /// </summary>
    let participatingIn =
        Namespaced_IRI.parse _namespace_name "participatingIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/particularSign"></see>
    /// </summary>
    let particularSign =
        Namespaced_IRI.parse _namespace_name "particularSign" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/partner"></see>
    /// </summary>
    let partner = Namespaced_IRI.parse _namespace_name "partner" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/party"></see>
    /// </summary>
    let party = Namespaced_IRI.parse _namespace_name "party" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/partyNumber"></see>
    /// </summary>
    let partyNumber =
        Namespaced_IRI.parse _namespace_name "partyNumber" |> NamespacedName

    /// <summary>
    /// Number of passengers per day.
    /// <see href="http://dbpedia.org/ontology/passengersPerDay"></see></summary>
    let passengersPerDay =
        Namespaced_IRI.parse _namespace_name "passengersPerDay" |> NamespacedName

    /// <summary>
    /// Number of passengers per year.
    /// <see href="http://dbpedia.org/ontology/passengersPerYear"></see></summary>
    let passengersPerYear =
        Namespaced_IRI.parse _namespace_name "passengersPerYear" |> NamespacedName

    /// <summary>
    /// System the passengers are using (from which the passenger statistics are).
    /// <see href="http://dbpedia.org/ontology/passengersUsedSystem"></see></summary>
    let passengersUsedSystem =
        Namespaced_IRI.parse _namespace_name "passengersUsedSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pastMember"></see>
    /// </summary>
    let pastMember = Namespaced_IRI.parse _namespace_name "pastMember" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pastor"></see>
    /// </summary>
    let pastor = Namespaced_IRI.parse _namespace_name "pastor" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/patent"></see>
    /// </summary>
    let patent = Namespaced_IRI.parse _namespace_name "patent" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/patron"></see>
    /// </summary>
    let patron = Namespaced_IRI.parse _namespace_name "patron" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/patronSaint"></see>
    /// </summary>
    let patronSaint =
        Namespaced_IRI.parse _namespace_name "patronSaint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pccSecretary"></see>
    /// </summary>
    let pccSecretary =
        Namespaced_IRI.parse _namespace_name "pccSecretary" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pdb"></see>
    /// </summary>
    let pdb = Namespaced_IRI.parse _namespace_name "pdb" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/peabodyAward"></see>
    /// </summary>
    let peabodyAward =
        Namespaced_IRI.parse _namespace_name "peabodyAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/penaltiesTeamA"></see>
    /// </summary>
    let penaltiesTeamA =
        Namespaced_IRI.parse _namespace_name "penaltiesTeamA" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/penaltiesTeamB"></see>
    /// </summary>
    let penaltiesTeamB =
        Namespaced_IRI.parse _namespace_name "penaltiesTeamB" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/penaltyScore"></see>
    /// </summary>
    let penaltyScore =
        Namespaced_IRI.parse _namespace_name "penaltyScore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/penisLength"></see>
    /// </summary>
    let penisLength =
        Namespaced_IRI.parse _namespace_name "penisLength" |> NamespacedName

    /// <summary>
    /// Name for the people inhabiting a place, eg Ankara-&gt;Ankariotes, Bulgaria-&gt;Bulgarians
    /// <see href="http://dbpedia.org/ontology/peopleName"></see></summary>
    let peopleName = Namespaced_IRI.parse _namespace_name "peopleName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/perCapitaIncome"></see>
    /// </summary>
    let perCapitaIncome =
        Namespaced_IRI.parse _namespace_name "perCapitaIncome" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/perCapitaIncomeAsOf"></see>
    /// </summary>
    let perCapitaIncomeAsOf =
        Namespaced_IRI.parse _namespace_name "perCapitaIncomeAsOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/perCapitaIncomeRank"></see>
    /// </summary>
    let perCapitaIncomeRank =
        Namespaced_IRI.parse _namespace_name "perCapitaIncomeRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/percentage"></see>
    /// </summary>
    let percentage = Namespaced_IRI.parse _namespace_name "percentage" |> NamespacedName

    /// <summary>
    /// percentage of alcohol present in a beverage
    /// <see href="http://dbpedia.org/ontology/percentageAlcohol"></see></summary>
    let percentageAlcohol =
        Namespaced_IRI.parse _namespace_name "percentageAlcohol" |> NamespacedName

    /// <summary>
    /// how much fat (as a percentage) does this food contain. Mostly applies to Cheese
    /// <see href="http://dbpedia.org/ontology/percentageFat"></see></summary>
    let percentageFat =
        Namespaced_IRI.parse _namespace_name "percentageFat" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/percentageLiteracyMen"></see>
    /// </summary>
    let percentageLiteracyMen =
        Namespaced_IRI.parse _namespace_name "percentageLiteracyMen" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/percentageLiterate"></see>
    /// </summary>
    let percentageLiterate =
        Namespaced_IRI.parse _namespace_name "percentageLiterate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/percentageLiteracyWomen"></see>
    /// </summary>
    let percentageLiteracyWomen =
        Namespaced_IRI.parse _namespace_name "percentageLiteracyWomen" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/percentageOfAreaWater"></see>
    /// </summary>
    let percentageOfAreaWater =
        Namespaced_IRI.parse _namespace_name "percentageOfAreaWater" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/performer"></see>
    /// </summary>
    let performer = Namespaced_IRI.parse _namespace_name "performer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/periapsis"></see>
    /// </summary>
    let periapsis = Namespaced_IRI.parse _namespace_name "periapsis" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/perifocus"></see>
    /// </summary>
    let perifocus = Namespaced_IRI.parse _namespace_name "perifocus" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/perimeter"></see>
    /// </summary>
    let perimeter = Namespaced_IRI.parse _namespace_name "perimeter" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/period"></see>
    /// </summary>
    let period = Namespaced_IRI.parse _namespace_name "period" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/person"></see>
    /// </summary>
    let person = Namespaced_IRI.parse _namespace_name "person" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/personFunction"></see>
    /// </summary>
    let personFunction =
        Namespaced_IRI.parse _namespace_name "personFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/personName"></see>
    /// </summary>
    let personName = Namespaced_IRI.parse _namespace_name "personName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pgaWins"></see>
    /// </summary>
    let pgaWins = Namespaced_IRI.parse _namespace_name "pgaWins" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/philosophicalSchool"></see>
    /// </summary>
    let philosophicalSchool =
        Namespaced_IRI.parse _namespace_name "philosophicalSchool" |> NamespacedName

    /// <summary>
    /// Don't use this, use areaCode
    /// <see href="http://dbpedia.org/ontology/phonePrefix"></see></summary>
    let phonePrefix =
        Namespaced_IRI.parse _namespace_name "phonePrefix" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/phonePrefixLabel"></see>
    /// </summary>
    let phonePrefixLabel =
        Namespaced_IRI.parse _namespace_name "phonePrefixLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/photographer"></see>
    /// </summary>
    let photographer =
        Namespaced_IRI.parse _namespace_name "photographer" |> NamespacedName

    /// <summary>
    /// A rank in the classification of organisms, below kingdom and above class; also called a division, especially in describing plants; a taxon at that rank.
    /// <see href="http://dbpedia.org/ontology/phylum"></see></summary>
    let phylum = Namespaced_IRI.parse _namespace_name "phylum" |> NamespacedName
    /// <summary>
    /// A picture of a thing.
    /// <see href="http://dbpedia.org/ontology/picture"></see></summary>
    let picture = Namespaced_IRI.parse _namespace_name "picture" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pictureDescription"></see>
    /// </summary>
    let pictureDescription =
        Namespaced_IRI.parse _namespace_name "pictureDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pictureFormat"></see>
    /// </summary>
    let pictureFormat =
        Namespaced_IRI.parse _namespace_name "pictureFormat" |> NamespacedName

    /// <summary>
    /// Wikimedia CommonsCategory for pictures of this resource
    /// <see href="http://dbpedia.org/ontology/picturesCommonsCategory"></see></summary>
    let picturesCommonsCategory =
        Namespaced_IRI.parse _namespace_name "picturesCommonsCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/piercing"></see>
    /// </summary>
    let piercing = Namespaced_IRI.parse _namespace_name "piercing" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pisciculturalPopulation"></see>
    /// </summary>
    let pisciculturalPopulation =
        Namespaced_IRI.parse _namespace_name "pisciculturalPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pistonStroke"></see>
    /// </summary>
    let pistonStroke =
        Namespaced_IRI.parse _namespace_name "pistonStroke" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/place"></see>
    /// </summary>
    let place = Namespaced_IRI.parse _namespace_name "place" |> NamespacedName

    /// <summary>
    /// The place where the person has been buried.
    /// <see href="http://dbpedia.org/ontology/placeOfBurial"></see></summary>
    let placeOfBurial =
        Namespaced_IRI.parse _namespace_name "placeOfBurial" |> NamespacedName

    /// <summary>
    /// A religious administrative body needs to know which places of worship it
    /// <see href="http://dbpedia.org/ontology/placeOfWorship"></see></summary>
    let placeOfWorship =
        Namespaced_IRI.parse _namespace_name "placeOfWorship" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/plant"></see>
    /// </summary>
    let plant = Namespaced_IRI.parse _namespace_name "plant" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/playRole"></see>
    /// </summary>
    let playRole = Namespaced_IRI.parse _namespace_name "playRole" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/uses"></see>
    /// </summary>
    let uses = Namespaced_IRI.parse _namespace_name "uses" |> NamespacedName

    /// <summary>
    /// A person playing for a sports team. inverseOf team
    /// <see href="http://dbpedia.org/ontology/playerInTeam"></see></summary>
    let playerInTeam =
        Namespaced_IRI.parse _namespace_name "playerInTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/playerSeason"></see>
    /// </summary>
    let playerSeason =
        Namespaced_IRI.parse _namespace_name "playerSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/playerStatus"></see>
    /// </summary>
    let playerStatus =
        Namespaced_IRI.parse _namespace_name "playerStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/playingTime"></see>
    /// </summary>
    let playingTime =
        Namespaced_IRI.parse _namespace_name "playingTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/plays"></see>
    /// </summary>
    let plays = Namespaced_IRI.parse _namespace_name "plays" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pluviometry"></see>
    /// </summary>
    let pluviometry =
        Namespaced_IRI.parse _namespace_name "pluviometry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/podium"></see>
    /// </summary>
    let podium = Namespaced_IRI.parse _namespace_name "podium" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/podiums"></see>
    /// </summary>
    let podiums = Namespaced_IRI.parse _namespace_name "podiums" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pole"></see>
    /// </summary>
    let pole = Namespaced_IRI.parse _namespace_name "pole" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/poleDriver"></see>
    /// </summary>
    let poleDriver = Namespaced_IRI.parse _namespace_name "poleDriver" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/poleDriverCountry"></see>
    /// </summary>
    let poleDriverCountry =
        Namespaced_IRI.parse _namespace_name "poleDriverCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/poleDriverTeam"></see>
    /// </summary>
    let poleDriverTeam =
        Namespaced_IRI.parse _namespace_name "poleDriverTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/polePosition"></see>
    /// </summary>
    let polePosition =
        Namespaced_IRI.parse _namespace_name "polePosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/poles"></see>
    /// </summary>
    let poles = Namespaced_IRI.parse _namespace_name "poles" |> NamespacedName
    /// <summary>
    /// The police detachment serving a UK place, eg Wakefield -&gt; "West Yorkshire Police"
    /// <see href="http://dbpedia.org/ontology/policeName"></see></summary>
    let policeName = Namespaced_IRI.parse _namespace_name "policeName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/polishFilmAward"></see>
    /// </summary>
    let polishFilmAward =
        Namespaced_IRI.parse _namespace_name "polishFilmAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/politicGovernmentDepartment"></see>
    /// </summary>
    let politicGovernmentDepartment =
        Namespaced_IRI.parse _namespace_name "politicGovernmentDepartment" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/politicalFunction"></see>
    /// </summary>
    let politicalFunction =
        Namespaced_IRI.parse _namespace_name "politicalFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/politicalLeader"></see>
    /// </summary>
    let politicalLeader =
        Namespaced_IRI.parse _namespace_name "politicalLeader" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/politicalMajority"></see>
    /// </summary>
    let politicalMajority =
        Namespaced_IRI.parse _namespace_name "politicalMajority" |> NamespacedName

    /// <summary>
    /// Political party in the legislature (eg.: European People's Party in the European Parliament).
    /// <see href="http://dbpedia.org/ontology/politicalPartyInLegislature"></see></summary>
    let politicalPartyInLegislature =
        Namespaced_IRI.parse _namespace_name "politicalPartyInLegislature" |> NamespacedName

    /// <summary>
    /// The Political party of leader.
    /// <see href="http://dbpedia.org/ontology/politicalPartyOfLeader"></see></summary>
    let politicalPartyOfLeader =
        Namespaced_IRI.parse _namespace_name "politicalPartyOfLeader" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/politicalSeats"></see>
    /// </summary>
    let politicalSeats =
        Namespaced_IRI.parse _namespace_name "politicalSeats" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/popularVote"></see>
    /// </summary>
    let popularVote =
        Namespaced_IRI.parse _namespace_name "popularVote" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/population"></see>
    /// </summary>
    let population = Namespaced_IRI.parse _namespace_name "population" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationAsOf"></see>
    /// </summary>
    let populationAsOf =
        Namespaced_IRI.parse _namespace_name "populationAsOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationDate"></see>
    /// </summary>
    let populationDate =
        Namespaced_IRI.parse _namespace_name "populationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationDensity"></see>
    /// </summary>
    let populationDensity =
        Namespaced_IRI.parse _namespace_name "populationDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationMetro"></see>
    /// </summary>
    let populationMetro =
        Namespaced_IRI.parse _namespace_name "populationMetro" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationMetroDensity"></see>
    /// </summary>
    let populationMetroDensity =
        Namespaced_IRI.parse _namespace_name "populationMetroDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationPctChildren"></see>
    /// </summary>
    let populationPctChildren =
        Namespaced_IRI.parse _namespace_name "populationPctChildren" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationPctMen"></see>
    /// </summary>
    let populationPctMen =
        Namespaced_IRI.parse _namespace_name "populationPctMen" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationPctWomen"></see>
    /// </summary>
    let populationPctWomen =
        Namespaced_IRI.parse _namespace_name "populationPctWomen" |> NamespacedName

    /// <summary>
    /// a place were members of an ethnic group are living
    /// <see href="http://dbpedia.org/ontology/populationPlace"></see></summary>
    let populationPlace =
        Namespaced_IRI.parse _namespace_name "populationPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationQuote"></see>
    /// </summary>
    let populationQuote =
        Namespaced_IRI.parse _namespace_name "populationQuote" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationRural"></see>
    /// </summary>
    let populationRural =
        Namespaced_IRI.parse _namespace_name "populationRural" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationRuralDensity"></see>
    /// </summary>
    let populationRuralDensity =
        Namespaced_IRI.parse _namespace_name "populationRuralDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationTotal"></see>
    /// </summary>
    let populationTotal =
        Namespaced_IRI.parse _namespace_name "populationTotal" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationTotalRanking"></see>
    /// </summary>
    let populationTotalRanking =
        Namespaced_IRI.parse _namespace_name "populationTotalRanking" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationTotalReference"></see>
    /// </summary>
    let populationTotalReference =
        Namespaced_IRI.parse _namespace_name "populationTotalReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationUrban"></see>
    /// </summary>
    let populationUrban =
        Namespaced_IRI.parse _namespace_name "populationUrban" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationUrbanDensity"></see>
    /// </summary>
    let populationUrbanDensity =
        Namespaced_IRI.parse _namespace_name "populationUrbanDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/populationYear"></see>
    /// </summary>
    let populationYear =
        Namespaced_IRI.parse _namespace_name "populationYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/portfolio"></see>
    /// </summary>
    let portfolio = Namespaced_IRI.parse _namespace_name "portfolio" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/portrayer"></see>
    /// </summary>
    let portrayer = Namespaced_IRI.parse _namespace_name "portrayer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/position"></see>
    /// </summary>
    let position = Namespaced_IRI.parse _namespace_name "position" |> NamespacedName
    /// <summary>
    /// A postal code (known in various countries as a post code, postcode, or ZIP code) is a series of letters and/or digits appended to a postal address for the purpose of sorting mail.
    /// <see href="http://dbpedia.org/ontology/postalCode"></see></summary>
    let postalCode = Namespaced_IRI.parse _namespace_name "postalCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/power"></see>
    /// </summary>
    let power = Namespaced_IRI.parse _namespace_name "power" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/powerOutput"></see>
    /// </summary>
    let powerOutput =
        Namespaced_IRI.parse _namespace_name "powerOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/powerType"></see>
    /// </summary>
    let powerType = Namespaced_IRI.parse _namespace_name "powerType" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/precursor"></see>
    /// </summary>
    let precursor = Namespaced_IRI.parse _namespace_name "precursor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/predecessor"></see>
    /// </summary>
    let predecessor =
        Namespaced_IRI.parse _namespace_name "predecessor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prefaceBy"></see>
    /// </summary>
    let prefaceBy = Namespaced_IRI.parse _namespace_name "prefaceBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prefect"></see>
    /// </summary>
    let prefect = Namespaced_IRI.parse _namespace_name "prefect" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prefectMandate"></see>
    /// </summary>
    let prefectMandate =
        Namespaced_IRI.parse _namespace_name "prefectMandate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prefecture"></see>
    /// </summary>
    let prefecture = Namespaced_IRI.parse _namespace_name "prefecture" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prefix"></see>
    /// </summary>
    let prefix = Namespaced_IRI.parse _namespace_name "prefix" |> NamespacedName

    /// <summary>
    /// Date the play was first performed.
    /// <see href="http://dbpedia.org/ontology/premiereDate"></see></summary>
    let premiereDate =
        Namespaced_IRI.parse _namespace_name "premiereDate" |> NamespacedName

    /// <summary>
    /// Release date of a Work or another product (eg Aircraft or other MeansOfTransportation
    /// <see href="http://dbpedia.org/ontology/releaseDate"></see></summary>
    let releaseDate =
        Namespaced_IRI.parse _namespace_name "releaseDate" |> NamespacedName

    /// <summary>
    /// The theatre and/or city the play was first performed in.
    /// <see href="http://dbpedia.org/ontology/premierePlace"></see></summary>
    let premierePlace =
        Namespaced_IRI.parse _namespace_name "premierePlace" |> NamespacedName

    /// <summary>
    /// Year the play was first performed.
    /// <see href="http://dbpedia.org/ontology/premiereYear"></see></summary>
    let premiereYear =
        Namespaced_IRI.parse _namespace_name "premiereYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/releaseYear"></see>
    /// </summary>
    let releaseYear =
        Namespaced_IRI.parse _namespace_name "releaseYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presentMunicipality"></see>
    /// </summary>
    let presentMunicipality =
        Namespaced_IRI.parse _namespace_name "presentMunicipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presentName"></see>
    /// </summary>
    let presentName =
        Namespaced_IRI.parse _namespace_name "presentName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presenter"></see>
    /// </summary>
    let presenter = Namespaced_IRI.parse _namespace_name "presenter" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/president"></see>
    /// </summary>
    let president = Namespaced_IRI.parse _namespace_name "president" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presidentGeneralCouncil"></see>
    /// </summary>
    let presidentGeneralCouncil =
        Namespaced_IRI.parse _namespace_name "presidentGeneralCouncil" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presidentGeneralCouncilMandate"></see>
    /// </summary>
    let presidentGeneralCouncilMandate =
        Namespaced_IRI.parse _namespace_name "presidentGeneralCouncilMandate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presidentRegionalCouncil"></see>
    /// </summary>
    let presidentRegionalCouncil =
        Namespaced_IRI.parse _namespace_name "presidentRegionalCouncil" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/presidentRegionalCouncilMandate"></see>
    /// </summary>
    let presidentRegionalCouncilMandate =
        Namespaced_IRI.parse _namespace_name "presidentRegionalCouncilMandate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousDemographics"></see>
    /// </summary>
    let previousDemographics =
        Namespaced_IRI.parse _namespace_name "previousDemographics" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousEditor"></see>
    /// </summary>
    let previousEditor =
        Namespaced_IRI.parse _namespace_name "previousEditor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousEntity"></see>
    /// </summary>
    let previousEntity =
        Namespaced_IRI.parse _namespace_name "previousEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousEvent"></see>
    /// </summary>
    let previousEvent =
        Namespaced_IRI.parse _namespace_name "previousEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousInfrastructure"></see>
    /// </summary>
    let previousInfrastructure =
        Namespaced_IRI.parse _namespace_name "previousInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousMission"></see>
    /// </summary>
    let previousMission =
        Namespaced_IRI.parse _namespace_name "previousMission" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousName"></see>
    /// </summary>
    let previousName =
        Namespaced_IRI.parse _namespace_name "previousName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousPopulation"></see>
    /// </summary>
    let previousPopulation =
        Namespaced_IRI.parse _namespace_name "previousPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousPopulationTotal"></see>
    /// </summary>
    let previousPopulationTotal =
        Namespaced_IRI.parse _namespace_name "previousPopulationTotal" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/previousWork"></see>
    /// </summary>
    let previousWork =
        Namespaced_IRI.parse _namespace_name "previousWork" |> NamespacedName

    /// <summary>
    /// The price of something, eg a journal. For "total money earned by an Athlete" use gross
    /// <see href="http://dbpedia.org/ontology/price"></see></summary>
    let price = Namespaced_IRI.parse _namespace_name "price" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/primaryFuelType"></see>
    /// </summary>
    let primaryFuelType =
        Namespaced_IRI.parse _namespace_name "primaryFuelType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/primate"></see>
    /// </summary>
    let primate = Namespaced_IRI.parse _namespace_name "primate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/primeMinister"></see>
    /// </summary>
    let primeMinister =
        Namespaced_IRI.parse _namespace_name "primeMinister" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/primogenitor"></see>
    /// </summary>
    let primogenitor =
        Namespaced_IRI.parse _namespace_name "primogenitor" |> NamespacedName

    /// <summary>
    /// Principal of an educational institution (school)
    /// <see href="http://dbpedia.org/ontology/principal"></see></summary>
    let principal = Namespaced_IRI.parse _namespace_name "principal" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/principalArea"></see>
    /// </summary>
    let principalArea =
        Namespaced_IRI.parse _namespace_name "principalArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/principalEngineer"></see>
    /// </summary>
    let principalEngineer =
        Namespaced_IRI.parse _namespace_name "principalEngineer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/proPeriod"></see>
    /// </summary>
    let proPeriod = Namespaced_IRI.parse _namespace_name "proPeriod" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/proSince"></see>
    /// </summary>
    let proSince = Namespaced_IRI.parse _namespace_name "proSince" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/proTeam"></see>
    /// </summary>
    let proTeam = Namespaced_IRI.parse _namespace_name "proTeam" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/proYear"></see>
    /// </summary>
    let proYear = Namespaced_IRI.parse _namespace_name "proYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/probowlPick"></see>
    /// </summary>
    let probowlPick =
        Namespaced_IRI.parse _namespace_name "probowlPick" |> NamespacedName

    /// <summary>
    /// The name designating a formal collection of steps to be taken to complete the case
    /// <see href="http://dbpedia.org/ontology/procedure"></see></summary>
    let procedure = Namespaced_IRI.parse _namespace_name "procedure" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/producedBy"></see>
    /// </summary>
    let producedBy = Namespaced_IRI.parse _namespace_name "producedBy" |> NamespacedName
    /// <summary>
    /// The producer of the creative work.
    /// <see href="http://dbpedia.org/ontology/producer"></see></summary>
    let producer = Namespaced_IRI.parse _namespace_name "producer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/produces"></see>
    /// </summary>
    let produces = Namespaced_IRI.parse _namespace_name "produces" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/product"></see>
    /// </summary>
    let product = Namespaced_IRI.parse _namespace_name "product" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/productShape"></see>
    /// </summary>
    let productShape =
        Namespaced_IRI.parse _namespace_name "productShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/production"></see>
    /// </summary>
    let production = Namespaced_IRI.parse _namespace_name "production" |> NamespacedName

    /// <summary>
    /// the company that produced the work e.g. Film, MusicalWork, Software
    /// <see href="http://dbpedia.org/ontology/productionCompany"></see></summary>
    let productionCompany =
        Namespaced_IRI.parse _namespace_name "productionCompany" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/productionEndDate"></see>
    /// </summary>
    let productionEndDate =
        Namespaced_IRI.parse _namespace_name "productionEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/productionEndYear"></see>
    /// </summary>
    let productionEndYear =
        Namespaced_IRI.parse _namespace_name "productionEndYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/productionStartDate"></see>
    /// </summary>
    let productionStartDate =
        Namespaced_IRI.parse _namespace_name "productionStartDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/productionStartYear"></see>
    /// </summary>
    let productionStartYear =
        Namespaced_IRI.parse _namespace_name "productionStartYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/productionYears"></see>
    /// </summary>
    let productionYears =
        Namespaced_IRI.parse _namespace_name "productionYears" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/profession"></see>
    /// </summary>
    let profession = Namespaced_IRI.parse _namespace_name "profession" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/programCost"></see>
    /// </summary>
    let programCost =
        Namespaced_IRI.parse _namespace_name "programCost" |> NamespacedName

    /// <summary>
    /// The programming format describes the overall content broadcast on a radio or television station.
    /// <see href="http://dbpedia.org/ontology/programmeFormat"></see></summary>
    let programmeFormat =
        Namespaced_IRI.parse _namespace_name "programmeFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/programmingLanguage"></see>
    /// </summary>
    let programmingLanguage =
        Namespaced_IRI.parse _namespace_name "programmingLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/project"></see>
    /// </summary>
    let project = Namespaced_IRI.parse _namespace_name "project" |> NamespacedName

    /// <summary>
    /// The part of the project budget that is funded by the Organistaions given in the "FundedBy" property.
    /// <see href="http://dbpedia.org/ontology/projectBudgetFunding"></see></summary>
    let projectBudgetFunding =
        Namespaced_IRI.parse _namespace_name "projectBudgetFunding" |> NamespacedName

    /// <summary>
    /// The total budget of the research project.
    /// <see href="http://dbpedia.org/ontology/projectBudgetTotal"></see></summary>
    let projectBudgetTotal =
        Namespaced_IRI.parse _namespace_name "projectBudgetTotal" |> NamespacedName

    /// <summary>
    /// The coordinating organisation of the project.
    /// <see href="http://dbpedia.org/ontology/projectCoordinator"></see></summary>
    let projectCoordinator =
        Namespaced_IRI.parse _namespace_name "projectCoordinator" |> NamespacedName

    /// <summary>
    /// The end date of the project.
    /// <see href="http://dbpedia.org/ontology/projectEndDate"></see></summary>
    let projectEndDate =
        Namespaced_IRI.parse _namespace_name "projectEndDate" |> NamespacedName

    /// <summary>
    /// A key word of the project.
    /// <see href="http://dbpedia.org/ontology/projectKeyword"></see></summary>
    let projectKeyword =
        Namespaced_IRI.parse _namespace_name "projectKeyword" |> NamespacedName

    /// <summary>
    /// A defined objective of the project.
    /// <see href="http://dbpedia.org/ontology/projectObjective"></see></summary>
    let projectObjective =
        Namespaced_IRI.parse _namespace_name "projectObjective" |> NamespacedName

    /// <summary>
    /// A participating organisation of the project.
    /// <see href="http://dbpedia.org/ontology/projectParticipant"></see></summary>
    let projectParticipant =
        Namespaced_IRI.parse _namespace_name "projectParticipant" |> NamespacedName

    /// <summary>
    /// The reference identification of the project.
    /// <see href="http://dbpedia.org/ontology/projectReferenceID"></see></summary>
    let projectReferenceID =
        Namespaced_IRI.parse _namespace_name "projectReferenceID" |> NamespacedName

    /// <summary>
    /// The start date of the project.
    /// <see href="http://dbpedia.org/ontology/projectStartDate"></see></summary>
    let projectStartDate =
        Namespaced_IRI.parse _namespace_name "projectStartDate" |> NamespacedName

    /// <summary>
    /// The type of the research project. Mostly used for the funding schemes of the European Union, for instance: Specific Targeted Research Projects (STREP), Network of Excellence (NoE) or Integrated Project.
    /// <see href="http://dbpedia.org/ontology/projectType"></see></summary>
    let projectType =
        Namespaced_IRI.parse _namespace_name "projectType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prominence"></see>
    /// </summary>
    let prominence = Namespaced_IRI.parse _namespace_name "prominence" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/promotion"></see>
    /// </summary>
    let promotion = Namespaced_IRI.parse _namespace_name "promotion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pronunciation"></see>
    /// </summary>
    let pronunciation =
        Namespaced_IRI.parse _namespace_name "pronunciation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prospectLeague"></see>
    /// </summary>
    let prospectLeague =
        Namespaced_IRI.parse _namespace_name "prospectLeague" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/prospectTeam"></see>
    /// </summary>
    let prospectTeam =
        Namespaced_IRI.parse _namespace_name "prospectTeam" |> NamespacedName

    /// <summary>
    /// The sort of status that is granted to a protected Building or Monument. This is not about being protected or not, this is about the nature of the protection regime. E.g., in the Netherlands the protection status 'rijksmonument' points to more elaborate protection than other statuses.
    /// <see href="http://dbpedia.org/ontology/protectionStatus"></see></summary>
    let protectionStatus =
        Namespaced_IRI.parse _namespace_name "protectionStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Status"></see>
    /// </summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName
    /// <summary>
    /// Amount of proteins per servingSize of a Food
    /// <see href="http://dbpedia.org/ontology/protein"></see></summary>
    let protein = Namespaced_IRI.parse _namespace_name "protein" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/protestantPercentage"></see>
    /// </summary>
    let protestantPercentage =
        Namespaced_IRI.parse _namespace_name "protestantPercentage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/provCode"></see>
    /// </summary>
    let provCode = Namespaced_IRI.parse _namespace_name "provCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/provides"></see>
    /// </summary>
    let provides = Namespaced_IRI.parse _namespace_name "provides" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/province"></see>
    /// </summary>
    let province = Namespaced_IRI.parse _namespace_name "province" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/provinceIsoCode"></see>
    /// </summary>
    let provinceIsoCode =
        Namespaced_IRI.parse _namespace_name "provinceIsoCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/provinceLink"></see>
    /// </summary>
    let provinceLink =
        Namespaced_IRI.parse _namespace_name "provinceLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/provost"></see>
    /// </summary>
    let provost = Namespaced_IRI.parse _namespace_name "provost" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pseudonym"></see>
    /// </summary>
    let pseudonym = Namespaced_IRI.parse _namespace_name "pseudonym" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/pubchem"></see>
    /// </summary>
    let pubchem = Namespaced_IRI.parse _namespace_name "pubchem" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/publication"></see>
    /// </summary>
    let publication =
        Namespaced_IRI.parse _namespace_name "publication" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/publicationDate"></see>
    /// </summary>
    let publicationDate =
        Namespaced_IRI.parse _namespace_name "publicationDate" |> NamespacedName

    /// <summary>
    /// describes in what way this site is accessible for public
    /// <see href="http://dbpedia.org/ontology/publiclyAccessible"></see></summary>
    let publiclyAccessible =
        Namespaced_IRI.parse _namespace_name "publiclyAccessible" |> NamespacedName

    /// <summary>
    /// Publisher of a work. For literal (string) use dc:publisher; for object (URL) use publisher
    /// <see href="http://dbpedia.org/ontology/publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/purchasingPowerParity"></see>
    /// </summary>
    let purchasingPowerParity =
        Namespaced_IRI.parse _namespace_name "purchasingPowerParity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/purchasingPowerParityRank"></see>
    /// </summary>
    let purchasingPowerParityRank =
        Namespaced_IRI.parse _namespace_name "purchasingPowerParityRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/purchasingPowerParityYear"></see>
    /// </summary>
    let purchasingPowerParityYear =
        Namespaced_IRI.parse _namespace_name "purchasingPowerParityYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/purpose"></see>
    /// </summary>
    let purpose = Namespaced_IRI.parse _namespace_name "purpose" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/qatarClassic"></see>
    /// </summary>
    let qatarClassic =
        Namespaced_IRI.parse _namespace_name "qatarClassic" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/quebecerTitle"></see>
    /// </summary>
    let quebecerTitle =
        Namespaced_IRI.parse _namespace_name "quebecerTitle" |> NamespacedName

    /// <summary>
    /// A quotation is the repetition of one expression as part of another one, particularly when the quoted expression is well-known or explicitly attributed by citation to its original source.
    /// <see href="http://dbpedia.org/ontology/quotation"></see></summary>
    let quotation = Namespaced_IRI.parse _namespace_name "quotation" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/quote"></see>
    /// </summary>
    let quote = Namespaced_IRI.parse _namespace_name "quote" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ra"></see>
    /// </summary>
    let ra = Namespaced_IRI.parse _namespace_name "ra" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/race"></see>
    /// </summary>
    let race = Namespaced_IRI.parse _namespace_name "race" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/raceHorse"></see>
    /// </summary>
    let raceHorse = Namespaced_IRI.parse _namespace_name "raceHorse" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/raceLength"></see>
    /// </summary>
    let raceLength = Namespaced_IRI.parse _namespace_name "raceLength" |> NamespacedName
    /// <summary>
    /// Result of one racer in a sport competition
    /// <see href="http://dbpedia.org/ontology/raceResult"></see></summary>
    let raceResult = Namespaced_IRI.parse _namespace_name "raceResult" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/raceTrack"></see>
    /// </summary>
    let raceTrack = Namespaced_IRI.parse _namespace_name "raceTrack" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/raceWins"></see>
    /// </summary>
    let raceWins = Namespaced_IRI.parse _namespace_name "raceWins" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/races"></see>
    /// </summary>
    let races = Namespaced_IRI.parse _namespace_name "races" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/racketCatching"></see>
    /// </summary>
    let racketCatching =
        Namespaced_IRI.parse _namespace_name "racketCatching" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/radio"></see>
    /// </summary>
    let radio = Namespaced_IRI.parse _namespace_name "radio" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/radioStation"></see>
    /// </summary>
    let radioStation =
        Namespaced_IRI.parse _namespace_name "radioStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/radius_ly"></see>
    /// </summary>
    let radius_ly = Namespaced_IRI.parse _namespace_name "radius_ly" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/railGauge"></see>
    /// </summary>
    let railGauge = Namespaced_IRI.parse _namespace_name "railGauge" |> NamespacedName

    /// <summary>
    /// Railway line that is using the tunnel.
    /// <see href="http://dbpedia.org/ontology/railwayLineUsingTunnel"></see></summary>
    let railwayLineUsingTunnel =
        Namespaced_IRI.parse _namespace_name "railwayLineUsingTunnel" |> NamespacedName

    /// <summary>
    /// Information on the type of platform(s) at the station.
    /// <see href="http://dbpedia.org/ontology/railwayPlatforms"></see></summary>
    let railwayPlatforms =
        Namespaced_IRI.parse _namespace_name "railwayPlatforms" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/railwayRollingStock"></see>
    /// </summary>
    let railwayRollingStock =
        Namespaced_IRI.parse _namespace_name "railwayRollingStock" |> NamespacedName

    /// <summary>
    /// Maximum distance without refueling
    /// <see href="http://dbpedia.org/ontology/range"></see></summary>
    let range = Namespaced_IRI.parse _namespace_name "range" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MeanOfTransportation_,_Instrument"></see>
    /// </summary>
    let ``MeanOfTransportation_,_Instrument`` =
        Namespaced_IRI.parse _namespace_name "MeanOfTransportation_,_Instrument" |> NamespacedName

    /// <summary>
    /// Rank of something among other things of the same kind, eg Constellations by Area; MusicalAlbums by popularity, etc
    /// <see href="http://dbpedia.org/ontology/rank"></see></summary>
    let rank = Namespaced_IRI.parse _namespace_name "rank" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankAgreement"></see>
    /// </summary>
    let rankAgreement =
        Namespaced_IRI.parse _namespace_name "rankAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankArea"></see>
    /// </summary>
    let rankArea = Namespaced_IRI.parse _namespace_name "rankArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankInFinalMedalCount"></see>
    /// </summary>
    let rankInFinalMedalCount =
        Namespaced_IRI.parse _namespace_name "rankInFinalMedalCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankPopulation"></see>
    /// </summary>
    let rankPopulation =
        Namespaced_IRI.parse _namespace_name "rankPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ranking"></see>
    /// </summary>
    let ranking = Namespaced_IRI.parse _namespace_name "ranking" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankingWins"></see>
    /// </summary>
    let rankingWins =
        Namespaced_IRI.parse _namespace_name "rankingWins" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankingsDoubles"></see>
    /// </summary>
    let rankingsDoubles =
        Namespaced_IRI.parse _namespace_name "rankingsDoubles" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rankingsSingles"></see>
    /// </summary>
    let rankingsSingles =
        Namespaced_IRI.parse _namespace_name "rankingsSingles" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rating"></see>
    /// </summary>
    let rating = Namespaced_IRI.parse _namespace_name "rating" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ratio"></see>
    /// </summary>
    let ratio = Namespaced_IRI.parse _namespace_name "ratio" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rebuildDate"></see>
    /// </summary>
    let rebuildDate =
        Namespaced_IRI.parse _namespace_name "rebuildDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rebuilder"></see>
    /// </summary>
    let rebuilder = Namespaced_IRI.parse _namespace_name "rebuilder" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rebuildingDate"></see>
    /// </summary>
    let rebuildingDate =
        Namespaced_IRI.parse _namespace_name "rebuildingDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rebuildingYear"></see>
    /// </summary>
    let rebuildingYear =
        Namespaced_IRI.parse _namespace_name "rebuildingYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/recentWinner"></see>
    /// </summary>
    let recentWinner =
        Namespaced_IRI.parse _namespace_name "recentWinner" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/recommissioningDate"></see>
    /// </summary>
    let recommissioningDate =
        Namespaced_IRI.parse _namespace_name "recommissioningDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/recordDate"></see>
    /// </summary>
    let recordDate = Namespaced_IRI.parse _namespace_name "recordDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/recordLabel"></see>
    /// </summary>
    let recordLabel =
        Namespaced_IRI.parse _namespace_name "recordLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/recordedIn"></see>
    /// </summary>
    let recordedIn = Namespaced_IRI.parse _namespace_name "recordedIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rector"></see>
    /// </summary>
    let rector = Namespaced_IRI.parse _namespace_name "rector" |> NamespacedName

    /// <summary>
    /// red list code for treatened species NL (different from IUCN)
    /// <see href="http://dbpedia.org/ontology/redListIdNL"></see></summary>
    let redListIdNL =
        Namespaced_IRI.parse _namespace_name "redListIdNL" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/redLongDistancePisteNumber"></see>
    /// </summary>
    let redLongDistancePisteNumber =
        Namespaced_IRI.parse _namespace_name "redLongDistancePisteNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/redSkiPisteNumber"></see>
    /// </summary>
    let redSkiPisteNumber =
        Namespaced_IRI.parse _namespace_name "redSkiPisteNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/redline"></see>
    /// </summary>
    let redline = Namespaced_IRI.parse _namespace_name "redline" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refcul"></see>
    /// </summary>
    let refcul = Namespaced_IRI.parse _namespace_name "refcul" |> NamespacedName
    /// <summary>
    /// Structured reference providing info about the subject
    /// <see href="http://dbpedia.org/ontology/reference"></see></summary>
    let reference = Namespaced_IRI.parse _namespace_name "reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/reffBourgmestre"></see>
    /// </summary>
    let reffBourgmestre =
        Namespaced_IRI.parse _namespace_name "reffBourgmestre" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refgen"></see>
    /// </summary>
    let refgen = Namespaced_IRI.parse _namespace_name "refgen" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refgeo"></see>
    /// </summary>
    let refgeo = Namespaced_IRI.parse _namespace_name "refgeo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refpol"></see>
    /// </summary>
    let refpol = Namespaced_IRI.parse _namespace_name "refpol" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refseq"></see>
    /// </summary>
    let refseq = Namespaced_IRI.parse _namespace_name "refseq" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refseqmrna"></see>
    /// </summary>
    let refseqmrna = Namespaced_IRI.parse _namespace_name "refseqmrna" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/refseqprotein"></see>
    /// </summary>
    let refseqprotein =
        Namespaced_IRI.parse _namespace_name "refseqprotein" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regency"></see>
    /// </summary>
    let regency = Namespaced_IRI.parse _namespace_name "regency" |> NamespacedName
    /// <summary>
    /// Subject has served as the regent of another monarch
    /// <see href="http://dbpedia.org/ontology/regentOf"></see></summary>
    let regentOf = Namespaced_IRI.parse _namespace_name "regentOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regime"></see>
    /// </summary>
    let regime = Namespaced_IRI.parse _namespace_name "regime" |> NamespacedName
    /// <summary>
    /// The regin where the thing is located or is connected to.
    /// <see href="http://dbpedia.org/ontology/region"></see></summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regionLink"></see>
    /// </summary>
    let regionLink = Namespaced_IRI.parse _namespace_name "regionLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regionServed"></see>
    /// </summary>
    let regionServed =
        Namespaced_IRI.parse _namespace_name "regionServed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regionType"></see>
    /// </summary>
    let regionType = Namespaced_IRI.parse _namespace_name "regionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regionalCouncil"></see>
    /// </summary>
    let regionalCouncil =
        Namespaced_IRI.parse _namespace_name "regionalCouncil" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regionalLanguage"></see>
    /// </summary>
    let regionalLanguage =
        Namespaced_IRI.parse _namespace_name "regionalLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/regionalPrefecture"></see>
    /// </summary>
    let regionalPrefecture =
        Namespaced_IRI.parse _namespace_name "regionalPrefecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/registration"></see>
    /// </summary>
    let registration =
        Namespaced_IRI.parse _namespace_name "registration" |> NamespacedName

    /// <summary>
    /// Identification of the registry a document is in
    /// <see href="http://dbpedia.org/ontology/registryNumber"></see></summary>
    let registryNumber =
        Namespaced_IRI.parse _namespace_name "registryNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/reign"></see>
    /// </summary>
    let reign = Namespaced_IRI.parse _namespace_name "reign" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/reignName"></see>
    /// </summary>
    let reignName = Namespaced_IRI.parse _namespace_name "reignName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/reigningPope"></see>
    /// </summary>
    let reigningPope =
        Namespaced_IRI.parse _namespace_name "reigningPope" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/related"></see>
    /// </summary>
    let related = Namespaced_IRI.parse _namespace_name "related" |> NamespacedName

    /// <summary>
    /// This property is to accommodate the list field that contains a list of related personFunctions a person holds or has held
    /// <see href="http://dbpedia.org/ontology/relatedFunctions"></see></summary>
    let relatedFunctions =
        Namespaced_IRI.parse _namespace_name "relatedFunctions" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/relatedMeanOfTransportation"></see>
    /// </summary>
    let relatedMeanOfTransportation =
        Namespaced_IRI.parse _namespace_name "relatedMeanOfTransportation" |> NamespacedName

    /// <summary>
    /// This property is to accommodate the list field that contains a list of, e.g., monuments in the same town
    /// <see href="http://dbpedia.org/ontology/relatedPlaces"></see></summary>
    let relatedPlaces =
        Namespaced_IRI.parse _namespace_name "relatedPlaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/relation"></see>
    /// </summary>
    let relation = Namespaced_IRI.parse _namespace_name "relation" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/relative"></see>
    /// </summary>
    let relative = Namespaced_IRI.parse _namespace_name "relative" |> NamespacedName

    /// <summary>
    /// the ratio of the average mass of atoms of an element (from a single given sample or source) to 1⁄12 of the mass of an atom of carbon-12
    /// <see href="http://dbpedia.org/ontology/relativeAtomicMass"></see></summary>
    let relativeAtomicMass =
        Namespaced_IRI.parse _namespace_name "relativeAtomicMass" |> NamespacedName

    /// <summary>
    /// Usually used with releaseDate, particularly for Films. Often there can be several pairs so our modeling is not precise here...
    /// <see href="http://dbpedia.org/ontology/releaseLocation"></see></summary>
    let releaseLocation =
        Namespaced_IRI.parse _namespace_name "releaseLocation" |> NamespacedName

    /// <summary>
    /// Physical remains or personal effects of a saint or venerated person, preserved in a religious building
    /// <see href="http://dbpedia.org/ontology/relics"></see></summary>
    let relics = Namespaced_IRI.parse _namespace_name "relics" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/relief"></see>
    /// </summary>
    let relief = Namespaced_IRI.parse _namespace_name "relief" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/religion"></see>
    /// </summary>
    let religion = Namespaced_IRI.parse _namespace_name "religion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/religiousHead"></see>
    /// </summary>
    let religiousHead =
        Namespaced_IRI.parse _namespace_name "religiousHead" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/religiousHeadLabel"></see>
    /// </summary>
    let religiousHeadLabel =
        Namespaced_IRI.parse _namespace_name "religiousHeadLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/religiousOrder"></see>
    /// </summary>
    let religiousOrder =
        Namespaced_IRI.parse _namespace_name "religiousOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Monastry"></see>
    /// </summary>
    let Monastry = Namespaced_IRI.parse _namespace_name "Monastry" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/reopened"></see>
    /// </summary>
    let reopened = Namespaced_IRI.parse _namespace_name "reopened" |> NamespacedName

    /// <summary>
    /// Date of reopening the architectural structure.
    /// <see href="http://dbpedia.org/ontology/reopeningDate"></see></summary>
    let reopeningDate =
        Namespaced_IRI.parse _namespace_name "reopeningDate" |> NamespacedName

    /// <summary>
    /// Year of reopening the architectural structure.
    /// <see href="http://dbpedia.org/ontology/reopeningYear"></see></summary>
    let reopeningYear =
        Namespaced_IRI.parse _namespace_name "reopeningYear" |> NamespacedName

    /// <summary>
    /// A reporting mark is a two-, three-, or four-letter alphabetic code used to identify owners or lessees of rolling stock and other equipment used on the North American railroad network.
    /// <see href="http://dbpedia.org/ontology/reportingMark"></see></summary>
    let reportingMark =
        Namespaced_IRI.parse _namespace_name "reportingMark" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/representative"></see>
    /// </summary>
    let representative =
        Namespaced_IRI.parse _namespace_name "representative" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/requirement"></see>
    /// </summary>
    let requirement =
        Namespaced_IRI.parse _namespace_name "requirement" |> NamespacedName

    /// <summary>
    /// Are reservations required for the establishment or event?
    /// <see href="http://dbpedia.org/ontology/reservations"></see></summary>
    let reservations =
        Namespaced_IRI.parse _namespace_name "reservations" |> NamespacedName

    /// <summary>
    /// Place of residence of a person.
    /// <see href="http://dbpedia.org/ontology/residence"></see></summary>
    let residence = Namespaced_IRI.parse _namespace_name "residence" |> NamespacedName
    /// <summary>
    /// Native Resolution
    /// <see href="http://dbpedia.org/ontology/resolution"></see></summary>
    let resolution = Namespaced_IRI.parse _namespace_name "resolution" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/restingDate"></see>
    /// </summary>
    let restingDate =
        Namespaced_IRI.parse _namespace_name "restingDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/restingPlace"></see>
    /// </summary>
    let restingPlace =
        Namespaced_IRI.parse _namespace_name "restingPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/restingPlacePosition"></see>
    /// </summary>
    let restingPlacePosition =
        Namespaced_IRI.parse _namespace_name "restingPlacePosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/restoreDate"></see>
    /// </summary>
    let restoreDate =
        Namespaced_IRI.parse _namespace_name "restoreDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/result"></see>
    /// </summary>
    let result = Namespaced_IRI.parse _namespace_name "result" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/retentionTime"></see>
    /// </summary>
    let retentionTime =
        Namespaced_IRI.parse _namespace_name "retentionTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/retired"></see>
    /// </summary>
    let retired = Namespaced_IRI.parse _namespace_name "retired" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/retiredRocket"></see>
    /// </summary>
    let retiredRocket =
        Namespaced_IRI.parse _namespace_name "retiredRocket" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/retirementDate"></see>
    /// </summary>
    let retirementDate =
        Namespaced_IRI.parse _namespace_name "retirementDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/revenue"></see>
    /// </summary>
    let revenue = Namespaced_IRI.parse _namespace_name "revenue" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/review"></see>
    /// </summary>
    let review = Namespaced_IRI.parse _namespace_name "review" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rgbCoordinateBlue"></see>
    /// </summary>
    let rgbCoordinateBlue =
        Namespaced_IRI.parse _namespace_name "rgbCoordinateBlue" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rgbCoordinateGreen"></see>
    /// </summary>
    let rgbCoordinateGreen =
        Namespaced_IRI.parse _namespace_name "rgbCoordinateGreen" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rgbCoordinateRed"></see>
    /// </summary>
    let rgbCoordinateRed =
        Namespaced_IRI.parse _namespace_name "rgbCoordinateRed" |> NamespacedName

    /// <summary>
    /// An identifying system for scientific authors. The system was introduced in January 2008 by Thomson Reuters. The combined use of the Digital Object Identifier with the ResearcherID allows for a unique association of authors and scientific articles.
    /// <see href="http://dbpedia.org/ontology/ridId"></see></summary>
    let ridId = Namespaced_IRI.parse _namespace_name "ridId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rightAscension"></see>
    /// </summary>
    let rightAscension =
        Namespaced_IRI.parse _namespace_name "rightAscension" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rightChild"></see>
    /// </summary>
    let rightChild = Namespaced_IRI.parse _namespace_name "rightChild" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rightTributary"></see>
    /// </summary>
    let rightTributary =
        Namespaced_IRI.parse _namespace_name "rightTributary" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rival"></see>
    /// </summary>
    let rival = Namespaced_IRI.parse _namespace_name "rival" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/river"></see>
    /// </summary>
    let river = Namespaced_IRI.parse _namespace_name "river" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/riverBranch"></see>
    /// </summary>
    let riverBranch =
        Namespaced_IRI.parse _namespace_name "riverBranch" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/riverBranchOf"></see>
    /// </summary>
    let riverBranchOf =
        Namespaced_IRI.parse _namespace_name "riverBranchOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/riverMouth"></see>
    /// </summary>
    let riverMouth = Namespaced_IRI.parse _namespace_name "riverMouth" |> NamespacedName

    /// <summary>
    /// Rijksbureau voor Kunsthistorische Documentatie (RKD) artists database id.
    /// http://rkd.nl/explore/artists/$1
    /// <see href="http://dbpedia.org/ontology/rkdArtistsId"></see></summary>
    let rkdArtistsId =
        Namespaced_IRI.parse _namespace_name "rkdArtistsId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/road"></see>
    /// </summary>
    let road = Namespaced_IRI.parse _namespace_name "road" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rocket"></see>
    /// </summary>
    let rocket = Namespaced_IRI.parse _namespace_name "rocket" |> NamespacedName

    /// <summary>
    /// purpose of the rocket
    /// <see href="http://dbpedia.org/ontology/rocketFunction"></see></summary>
    let rocketFunction =
        Namespaced_IRI.parse _namespace_name "rocketFunction" |> NamespacedName

    /// <summary>
    /// number of stages, not including boosters
    /// <see href="http://dbpedia.org/ontology/rocketStages"></see></summary>
    let rocketStages =
        Namespaced_IRI.parse _namespace_name "rocketStages" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rolandGarrosDouble"></see>
    /// </summary>
    let rolandGarrosDouble =
        Namespaced_IRI.parse _namespace_name "rolandGarrosDouble" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rolandGarrosMixed"></see>
    /// </summary>
    let rolandGarrosMixed =
        Namespaced_IRI.parse _namespace_name "rolandGarrosMixed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rolandGarrosSingle"></see>
    /// </summary>
    let rolandGarrosSingle =
        Namespaced_IRI.parse _namespace_name "rolandGarrosSingle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/role"></see>
    /// </summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/roleInEvent"></see>
    /// </summary>
    let roleInEvent =
        Namespaced_IRI.parse _namespace_name "roleInEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/roofHeight"></see>
    /// </summary>
    let roofHeight = Namespaced_IRI.parse _namespace_name "roofHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/rotationPeriod"></see>
    /// </summary>
    let rotationPeriod =
        Namespaced_IRI.parse _namespace_name "rotationPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/route"></see>
    /// </summary>
    let route = Namespaced_IRI.parse _namespace_name "route" |> NamespacedName

    /// <summary>
    /// details of the activity for a road.
    /// <see href="http://dbpedia.org/ontology/routeActivity"></see></summary>
    let routeActivity =
        Namespaced_IRI.parse _namespace_name "routeActivity" |> NamespacedName

    /// <summary>
    /// The general direction of the route (eg. North-South).
    /// <see href="http://dbpedia.org/ontology/routeDirection"></see></summary>
    let routeDirection =
        Namespaced_IRI.parse _namespace_name "routeDirection" |> NamespacedName

    /// <summary>
    /// End of the route. This is where the route ends and, for U.S. roads, is either at the northern terminus or eastern terminus.
    /// <see href="http://dbpedia.org/ontology/routeEnd"></see></summary>
    let routeEnd = Namespaced_IRI.parse _namespace_name "routeEnd" |> NamespacedName

    /// <summary>
    /// End of the route. The opposite of OntologyProperty:routeStartDirection.
    /// <see href="http://dbpedia.org/ontology/routeEndDirection"></see></summary>
    let routeEndDirection =
        Namespaced_IRI.parse _namespace_name "routeEndDirection" |> NamespacedName

    /// <summary>
    /// The end location of the route.
    /// <see href="http://dbpedia.org/ontology/routeEndLocation"></see></summary>
    let routeEndLocation =
        Namespaced_IRI.parse _namespace_name "routeEndLocation" |> NamespacedName

    /// <summary>
    /// A junction or cross to another route.
    /// <see href="http://dbpedia.org/ontology/routeJunction"></see></summary>
    let routeJunction =
        Namespaced_IRI.parse _namespace_name "routeJunction" |> NamespacedName

    /// <summary>
    /// line of a stop on a route.
    /// <see href="http://dbpedia.org/ontology/routeLine"></see></summary>
    let routeLine = Namespaced_IRI.parse _namespace_name "routeLine" |> NamespacedName
    /// <summary>
    /// next stop on a route.
    /// <see href="http://dbpedia.org/ontology/routeNext"></see></summary>
    let routeNext = Namespaced_IRI.parse _namespace_name "routeNext" |> NamespacedName

    /// <summary>
    /// The number of the route.
    /// <see href="http://dbpedia.org/ontology/routeNumber"></see></summary>
    let routeNumber =
        Namespaced_IRI.parse _namespace_name "routeNumber" |> NamespacedName

    /// <summary>
    /// previous stop on a route.
    /// <see href="http://dbpedia.org/ontology/routePrevious"></see></summary>
    let routePrevious =
        Namespaced_IRI.parse _namespace_name "routePrevious" |> NamespacedName

    /// <summary>
    /// Start of the route. This is where the route begins and, for U.S. roads, is either at the southern terminus or western terminus.
    /// <see href="http://dbpedia.org/ontology/routeStart"></see></summary>
    let routeStart = Namespaced_IRI.parse _namespace_name "routeStart" |> NamespacedName

    /// <summary>
    /// End of the route. For U.S. roads, this should be either "South" or "West" per the standards set by the U.S. Roads project.
    /// <see href="http://dbpedia.org/ontology/routeStartDirection"></see></summary>
    let routeStartDirection =
        Namespaced_IRI.parse _namespace_name "routeStartDirection" |> NamespacedName

    /// <summary>
    /// The start location of the route.
    /// <see href="http://dbpedia.org/ontology/routeStartLocation"></see></summary>
    let routeStartLocation =
        Namespaced_IRI.parse _namespace_name "routeStartLocation" |> NamespacedName

    /// <summary>
    /// The route type abbreviation (eg.: I for Interstate, M for Motorway or NJ for New Jersey Route).
    /// <see href="http://dbpedia.org/ontology/routeTypeAbbreviation"></see></summary>
    let routeTypeAbbreviation =
        Namespaced_IRI.parse _namespace_name "routeTypeAbbreviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/royalAnthem"></see>
    /// </summary>
    let royalAnthem =
        Namespaced_IRI.parse _namespace_name "royalAnthem" |> NamespacedName

    /// <summary>
    /// Ruling referred to in this legal case
    /// <see href="http://dbpedia.org/ontology/ruling"></see></summary>
    let ruling = Namespaced_IRI.parse _namespace_name "ruling" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/runningMate"></see>
    /// </summary>
    let runningMate =
        Namespaced_IRI.parse _namespace_name "runningMate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/runtime"></see>
    /// </summary>
    let runtime = Namespaced_IRI.parse _namespace_name "runtime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/runwayDesignation"></see>
    /// </summary>
    let runwayDesignation =
        Namespaced_IRI.parse _namespace_name "runwayDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/runwayLength"></see>
    /// </summary>
    let runwayLength =
        Namespaced_IRI.parse _namespace_name "runwayLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/runwaySurface"></see>
    /// </summary>
    let runwaySurface =
        Namespaced_IRI.parse _namespace_name "runwaySurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/runwayWidth"></see>
    /// </summary>
    let runwayWidth =
        Namespaced_IRI.parse _namespace_name "runwayWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ruralMunicipality"></see>
    /// </summary>
    let ruralMunicipality =
        Namespaced_IRI.parse _namespace_name "ruralMunicipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/saint"></see>
    /// </summary>
    let saint = Namespaced_IRI.parse _namespace_name "saint" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/salary"></see>
    /// </summary>
    let salary = Namespaced_IRI.parse _namespace_name "salary" |> NamespacedName
    /// <summary>
    /// This property holds an intermediate node of the type Sales.
    /// <see href="http://dbpedia.org/ontology/sales"></see></summary>
    let sales = Namespaced_IRI.parse _namespace_name "sales" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sameName"></see>
    /// </summary>
    let sameName = Namespaced_IRI.parse _namespace_name "sameName" |> NamespacedName
    /// <summary>
    /// most recent average SAT scores
    /// <see href="http://dbpedia.org/ontology/satScore"></see></summary>
    let satScore = Namespaced_IRI.parse _namespace_name "satScore" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/satellite"></see>
    /// </summary>
    let satellite = Namespaced_IRI.parse _namespace_name "satellite" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/satellitesDeployed"></see>
    /// </summary>
    let satellitesDeployed =
        Namespaced_IRI.parse _namespace_name "satellitesDeployed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/scale"></see>
    /// </summary>
    let scale = Namespaced_IRI.parse _namespace_name "scale" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/scene"></see>
    /// </summary>
    let scene = Namespaced_IRI.parse _namespace_name "scene" |> NamespacedName
    /// <summary>
    /// school a person goes or went to
    /// <see href="http://dbpedia.org/ontology/school"></see></summary>
    let school = Namespaced_IRI.parse _namespace_name "school" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/schoolBoard"></see>
    /// </summary>
    let schoolBoard =
        Namespaced_IRI.parse _namespace_name "schoolBoard" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/schoolCode"></see>
    /// </summary>
    let schoolCode = Namespaced_IRI.parse _namespace_name "schoolCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/schoolNumber"></see>
    /// </summary>
    let schoolNumber =
        Namespaced_IRI.parse _namespace_name "schoolNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/schoolPatron"></see>
    /// </summary>
    let schoolPatron =
        Namespaced_IRI.parse _namespace_name "schoolPatron" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/scientificName"></see>
    /// </summary>
    let scientificName =
        Namespaced_IRI.parse _namespace_name "scientificName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/screenActorsGuildAward"></see>
    /// </summary>
    let screenActorsGuildAward =
        Namespaced_IRI.parse _namespace_name "screenActorsGuildAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sea"></see>
    /// </summary>
    let sea = Namespaced_IRI.parse _namespace_name "sea" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/season"></see>
    /// </summary>
    let season = Namespaced_IRI.parse _namespace_name "season" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/seasonManager"></see>
    /// </summary>
    let seasonManager =
        Namespaced_IRI.parse _namespace_name "seasonManager" |> NamespacedName

    /// <summary>
    /// The season number to which the TelevisionEpisode belongs.
    /// <see href="http://dbpedia.org/ontology/seasonNumber"></see></summary>
    let seasonNumber =
        Namespaced_IRI.parse _namespace_name "seasonNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/seatNumber"></see>
    /// </summary>
    let seatNumber = Namespaced_IRI.parse _namespace_name "seatNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/seatingCapacity"></see>
    /// </summary>
    let seatingCapacity =
        Namespaced_IRI.parse _namespace_name "seatingCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/second"></see>
    /// </summary>
    let second = Namespaced_IRI.parse _namespace_name "second" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondCommander"></see>
    /// </summary>
    let secondCommander =
        Namespaced_IRI.parse _namespace_name "secondCommander" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondDriver"></see>
    /// </summary>
    let secondDriver =
        Namespaced_IRI.parse _namespace_name "secondDriver" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondDriverCountry"></see>
    /// </summary>
    let secondDriverCountry =
        Namespaced_IRI.parse _namespace_name "secondDriverCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondLeader"></see>
    /// </summary>
    let secondLeader =
        Namespaced_IRI.parse _namespace_name "secondLeader" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondPlace"></see>
    /// </summary>
    let secondPlace =
        Namespaced_IRI.parse _namespace_name "secondPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondPopularVote"></see>
    /// </summary>
    let secondPopularVote =
        Namespaced_IRI.parse _namespace_name "secondPopularVote" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secondTeam"></see>
    /// </summary>
    let secondTeam = Namespaced_IRI.parse _namespace_name "secondTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/secretaryGeneral"></see>
    /// </summary>
    let secretaryGeneral =
        Namespaced_IRI.parse _namespace_name "secretaryGeneral" |> NamespacedName

    /// <summary>
    /// Safety precautions that are used in the building.
    /// <see href="http://dbpedia.org/ontology/security"></see></summary>
    let security = Namespaced_IRI.parse _namespace_name "security" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/seiyu"></see>
    /// </summary>
    let seiyu = Namespaced_IRI.parse _namespace_name "seiyu" |> NamespacedName
    /// <summary>
    /// when (or in which project) the person was selected to train as an astronaut
    /// <see href="http://dbpedia.org/ontology/selection"></see></summary>
    let selection = Namespaced_IRI.parse _namespace_name "selection" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/selectionPoint"></see>
    /// </summary>
    let selectionPoint =
        Namespaced_IRI.parse _namespace_name "selectionPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/selectionYear"></see>
    /// </summary>
    let selectionYear =
        Namespaced_IRI.parse _namespace_name "selectionYear" |> NamespacedName

    /// <summary>
    /// Authority data from the National Library of Sweden
    /// <see href="http://dbpedia.org/ontology/selibrId"></see></summary>
    let selibrId = Namespaced_IRI.parse _namespace_name "selibrId" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/senator"></see>
    /// </summary>
    let senator = Namespaced_IRI.parse _namespace_name "senator" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/senior"></see>
    /// </summary>
    let senior = Namespaced_IRI.parse _namespace_name "senior" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/seniority"></see>
    /// </summary>
    let seniority = Namespaced_IRI.parse _namespace_name "seniority" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/seniunija"></see>
    /// </summary>
    let seniunija = Namespaced_IRI.parse _namespace_name "seniunija" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sentence"></see>
    /// </summary>
    let sentence = Namespaced_IRI.parse _namespace_name "sentence" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/series"></see>
    /// </summary>
    let series = Namespaced_IRI.parse _namespace_name "series" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/service"></see>
    /// </summary>
    let service = Namespaced_IRI.parse _namespace_name "service" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/serviceEndDate"></see>
    /// </summary>
    let serviceEndDate =
        Namespaced_IRI.parse _namespace_name "serviceEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/serviceEndYear"></see>
    /// </summary>
    let serviceEndYear =
        Namespaced_IRI.parse _namespace_name "serviceEndYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/serviceModule"></see>
    /// </summary>
    let serviceModule =
        Namespaced_IRI.parse _namespace_name "serviceModule" |> NamespacedName

    /// <summary>
    /// The service number held by the individual during military service.
    /// <see href="http://dbpedia.org/ontology/serviceNumber"></see></summary>
    let serviceNumber =
        Namespaced_IRI.parse _namespace_name "serviceNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/serviceStartDate"></see>
    /// </summary>
    let serviceStartDate =
        Namespaced_IRI.parse _namespace_name "serviceStartDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/serviceStartYear"></see>
    /// </summary>
    let serviceStartYear =
        Namespaced_IRI.parse _namespace_name "serviceStartYear" |> NamespacedName

    /// <summary>
    /// Railway services that serve the station.
    /// <see href="http://dbpedia.org/ontology/servingRailwayLine"></see></summary>
    let servingRailwayLine =
        Namespaced_IRI.parse _namespace_name "servingRailwayLine" |> NamespacedName

    /// <summary>
    /// Default serving size (eg "100 g" for the standard 100 g serving size). approximateCalories apply to this serving size
    /// <see href="http://dbpedia.org/ontology/servingSize"></see></summary>
    let servingSize =
        Namespaced_IRI.parse _namespace_name "servingSize" |> NamespacedName

    /// <summary>
    /// Serving temperature for the food (e.g.: hot, cold, warm or room temperature).
    /// <see href="http://dbpedia.org/ontology/servingTemperature"></see></summary>
    let servingTemperature =
        Namespaced_IRI.parse _namespace_name "servingTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sessionNumber"></see>
    /// </summary>
    let sessionNumber =
        Namespaced_IRI.parse _namespace_name "sessionNumber" |> NamespacedName

    /// <summary>
    /// the person who is responsible for the film set design
    /// <see href="http://dbpedia.org/ontology/setDesigner"></see></summary>
    let setDesigner =
        Namespaced_IRI.parse _namespace_name "setDesigner" |> NamespacedName

    /// <summary>
    /// The places and time where the play takes place.
    /// <see href="http://dbpedia.org/ontology/settingOfPlay"></see></summary>
    let settingOfPlay =
        Namespaced_IRI.parse _namespace_name "settingOfPlay" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/settlement"></see>
    /// </summary>
    let settlement = Namespaced_IRI.parse _namespace_name "settlement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/settlementAttached"></see>
    /// </summary>
    let settlementAttached =
        Namespaced_IRI.parse _namespace_name "settlementAttached" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/setupTime"></see>
    /// </summary>
    let setupTime = Namespaced_IRI.parse _namespace_name "setupTime" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sex"></see>
    /// </summary>
    let sex = Namespaced_IRI.parse _namespace_name "sex" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sexualOrientation"></see>
    /// </summary>
    let sexualOrientation =
        Namespaced_IRI.parse _namespace_name "sexualOrientation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shape"></see>
    /// </summary>
    let shape = Namespaced_IRI.parse _namespace_name "shape" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shareDate"></see>
    /// </summary>
    let shareDate = Namespaced_IRI.parse _namespace_name "shareDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shareOfAudience"></see>
    /// </summary>
    let shareOfAudience =
        Namespaced_IRI.parse _namespace_name "shareOfAudience" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shareSource"></see>
    /// </summary>
    let shareSource =
        Namespaced_IRI.parse _namespace_name "shareSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sharingOutPopulation"></see>
    /// </summary>
    let sharingOutPopulation =
        Namespaced_IRI.parse _namespace_name "sharingOutPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sharingOutPopulationYear"></see>
    /// </summary>
    let sharingOutPopulationYear =
        Namespaced_IRI.parse _namespace_name "sharingOutPopulationYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sheading"></see>
    /// </summary>
    let sheading = Namespaced_IRI.parse _namespace_name "sheading" |> NamespacedName
    /// <summary>
    /// The beam of a ship is its width at the widest point.
    /// <see href="http://dbpedia.org/ontology/shipBeam"></see></summary>
    let shipBeam = Namespaced_IRI.parse _namespace_name "shipBeam" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shipCrew"></see>
    /// </summary>
    let shipCrew = Namespaced_IRI.parse _namespace_name "shipCrew" |> NamespacedName

    /// <summary>
    /// A ship's displacement is its mass at any given time.
    /// <see href="http://dbpedia.org/ontology/shipDisplacement"></see></summary>
    let shipDisplacement =
        Namespaced_IRI.parse _namespace_name "shipDisplacement" |> NamespacedName

    /// <summary>
    /// The draft (or draught) of a ship's hull is the vertical distance between the waterline and the bottom of the hull (keel), with the thickness of the hull included; in the case of not being included the draft outline would be obtained.
    /// <see href="http://dbpedia.org/ontology/shipDraft"></see></summary>
    let shipDraft = Namespaced_IRI.parse _namespace_name "shipDraft" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shipLaunch"></see>
    /// </summary>
    let shipLaunch = Namespaced_IRI.parse _namespace_name "shipLaunch" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shoeNumber"></see>
    /// </summary>
    let shoeNumber = Namespaced_IRI.parse _namespace_name "shoeNumber" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shoeSize"></see>
    /// </summary>
    let shoeSize = Namespaced_IRI.parse _namespace_name "shoeSize" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shoot"></see>
    /// </summary>
    let shoot = Namespaced_IRI.parse _namespace_name "shoot" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shoots"></see>
    /// </summary>
    let shoots = Namespaced_IRI.parse _namespace_name "shoots" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shoreLength"></see>
    /// </summary>
    let shoreLength =
        Namespaced_IRI.parse _namespace_name "shoreLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shortProgCompetition"></see>
    /// </summary>
    let shortProgCompetition =
        Namespaced_IRI.parse _namespace_name "shortProgCompetition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shortProgScore"></see>
    /// </summary>
    let shortProgScore =
        Namespaced_IRI.parse _namespace_name "shortProgScore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/show"></see>
    /// </summary>
    let show = Namespaced_IRI.parse _namespace_name "show" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/showJudge"></see>
    /// </summary>
    let showJudge = Namespaced_IRI.parse _namespace_name "showJudge" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/shuttle"></see>
    /// </summary>
    let shuttle = Namespaced_IRI.parse _namespace_name "shuttle" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sibling"></see>
    /// </summary>
    let sibling = Namespaced_IRI.parse _namespace_name "sibling" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/signName"></see>
    /// </summary>
    let signName = Namespaced_IRI.parse _namespace_name "signName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/signature"></see>
    /// </summary>
    let signature = Namespaced_IRI.parse _namespace_name "signature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/significantBuilding"></see>
    /// </summary>
    let significantBuilding =
        Namespaced_IRI.parse _namespace_name "significantBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/significantDesign"></see>
    /// </summary>
    let significantDesign =
        Namespaced_IRI.parse _namespace_name "significantDesign" |> NamespacedName

    /// <summary>
    /// A siginificant artifact constructed by the person.
    /// <see href="http://dbpedia.org/ontology/significantProject"></see></summary>
    let significantProject =
        Namespaced_IRI.parse _namespace_name "significantProject" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/silCode"></see>
    /// </summary>
    let silCode = Namespaced_IRI.parse _namespace_name "silCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/silverMedalDouble"></see>
    /// </summary>
    let silverMedalDouble =
        Namespaced_IRI.parse _namespace_name "silverMedalDouble" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/silverMedalMixed"></see>
    /// </summary>
    let silverMedalMixed =
        Namespaced_IRI.parse _namespace_name "silverMedalMixed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/silverMedalSingle"></see>
    /// </summary>
    let silverMedalSingle =
        Namespaced_IRI.parse _namespace_name "silverMedalSingle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/silverMedalist"></see>
    /// </summary>
    let silverMedalist =
        Namespaced_IRI.parse _namespace_name "silverMedalist" |> NamespacedName

    /// <summary>
    /// indexing code used by the Polish National Official Register of the Territorial Division of the Country (TERYT) to identify various entities
    /// <see href="http://dbpedia.org/ontology/simcCode"></see></summary>
    let simcCode = Namespaced_IRI.parse _namespace_name "simcCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/similar"></see>
    /// </summary>
    let similar = Namespaced_IRI.parse _namespace_name "similar" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sire"></see>
    /// </summary>
    let sire = Namespaced_IRI.parse _namespace_name "sire" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/siren"></see>
    /// </summary>
    let siren = Namespaced_IRI.parse _namespace_name "siren" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sisterCollege"></see>
    /// </summary>
    let sisterCollege =
        Namespaced_IRI.parse _namespace_name "sisterCollege" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sisterNewspaper"></see>
    /// </summary>
    let sisterNewspaper =
        Namespaced_IRI.parse _namespace_name "sisterNewspaper" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sisterStation"></see>
    /// </summary>
    let sisterStation =
        Namespaced_IRI.parse _namespace_name "sisterStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sixthFormStudents"></see>
    /// </summary>
    let sixthFormStudents =
        Namespaced_IRI.parse _namespace_name "sixthFormStudents" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sizeBlazon"></see>
    /// </summary>
    let sizeBlazon = Namespaced_IRI.parse _namespace_name "sizeBlazon" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sizeLogo"></see>
    /// </summary>
    let sizeLogo = Namespaced_IRI.parse _namespace_name "sizeLogo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sizeMap"></see>
    /// </summary>
    let sizeMap = Namespaced_IRI.parse _namespace_name "sizeMap" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sizeThumbnail"></see>
    /// </summary>
    let sizeThumbnail =
        Namespaced_IRI.parse _namespace_name "sizeThumbnail" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/size_v"></see>
    /// </summary>
    let size_v = Namespaced_IRI.parse _namespace_name "size_v" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/skiLift"></see>
    /// </summary>
    let skiLift = Namespaced_IRI.parse _namespace_name "skiLift" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/skiPisteKilometre"></see>
    /// </summary>
    let skiPisteKilometre =
        Namespaced_IRI.parse _namespace_name "skiPisteKilometre" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/skiPisteNumber"></see>
    /// </summary>
    let skiPisteNumber =
        Namespaced_IRI.parse _namespace_name "skiPisteNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/skiTow"></see>
    /// </summary>
    let skiTow = Namespaced_IRI.parse _namespace_name "skiTow" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/skills"></see>
    /// </summary>
    let skills = Namespaced_IRI.parse _namespace_name "skills" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/skinColor"></see>
    /// </summary>
    let skinColor = Namespaced_IRI.parse _namespace_name "skinColor" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/slogan"></see>
    /// </summary>
    let slogan = Namespaced_IRI.parse _namespace_name "slogan" |> NamespacedName
    /// <summary>
    /// The Simplified Molecular-Input Line-Entry System or SMILES is a specification in form of a line notation for describing the structure of chemical molecules using short ASCII strings.
    /// <see href="http://dbpedia.org/ontology/smiles"></see></summary>
    let smiles = Namespaced_IRI.parse _namespace_name "smiles" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/snowParkNumber"></see>
    /// </summary>
    let snowParkNumber =
        Namespaced_IRI.parse _namespace_name "snowParkNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerLeaguePromoted"></see>
    /// </summary>
    let soccerLeaguePromoted =
        Namespaced_IRI.parse _namespace_name "soccerLeaguePromoted" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerLeagueRelegated"></see>
    /// </summary>
    let soccerLeagueRelegated =
        Namespaced_IRI.parse _namespace_name "soccerLeagueRelegated" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerLeagueSeason"></see>
    /// </summary>
    let soccerLeagueSeason =
        Namespaced_IRI.parse _namespace_name "soccerLeagueSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerLeagueWinner"></see>
    /// </summary>
    let soccerLeagueWinner =
        Namespaced_IRI.parse _namespace_name "soccerLeagueWinner" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentClosingSeason"></see>
    /// </summary>
    let soccerTournamentClosingSeason =
        Namespaced_IRI.parse _namespace_name "soccerTournamentClosingSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentLastChampion"></see>
    /// </summary>
    let soccerTournamentLastChampion =
        Namespaced_IRI.parse _namespace_name "soccerTournamentLastChampion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentMostSteady"></see>
    /// </summary>
    let soccerTournamentMostSteady =
        Namespaced_IRI.parse _namespace_name "soccerTournamentMostSteady" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentMostSuccesfull"></see>
    /// </summary>
    let soccerTournamentMostSuccesfull =
        Namespaced_IRI.parse _namespace_name "soccerTournamentMostSuccesfull" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentOpeningSeason"></see>
    /// </summary>
    let soccerTournamentOpeningSeason =
        Namespaced_IRI.parse _namespace_name "soccerTournamentOpeningSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentThisSeason"></see>
    /// </summary>
    let soccerTournamentThisSeason =
        Namespaced_IRI.parse _namespace_name "soccerTournamentThisSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/soccerTournamentTopScorer"></see>
    /// </summary>
    let soccerTournamentTopScorer =
        Namespaced_IRI.parse _namespace_name "soccerTournamentTopScorer" |> NamespacedName

    /// <summary>
    /// high-ranking solicitor
    /// <see href="http://dbpedia.org/ontology/solicitorGeneral"></see></summary>
    let solicitorGeneral =
        Namespaced_IRI.parse _namespace_name "solicitorGeneral" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/solubility"></see>
    /// </summary>
    let solubility = Namespaced_IRI.parse _namespace_name "solubility" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/solventWithBadSolubility"></see>
    /// </summary>
    let solventWithBadSolubility =
        Namespaced_IRI.parse _namespace_name "solventWithBadSolubility" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/solventWithGoodSolubility"></see>
    /// </summary>
    let solventWithGoodSolubility =
        Namespaced_IRI.parse _namespace_name "solventWithGoodSolubility" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/solventWithMediocreSolubility"></see>
    /// </summary>
    let solventWithMediocreSolubility =
        Namespaced_IRI.parse _namespace_name "solventWithMediocreSolubility" |> NamespacedName

    /// <summary>
    /// Sound recording somehow related to the subject
    /// <see href="http://dbpedia.org/ontology/soundRecording"></see></summary>
    let soundRecording =
        Namespaced_IRI.parse _namespace_name "soundRecording" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/source"></see>
    /// </summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluence"></see>
    /// </summary>
    let sourceConfluence =
        Namespaced_IRI.parse _namespace_name "sourceConfluence" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluenceCountry"></see>
    /// </summary>
    let sourceConfluenceCountry =
        Namespaced_IRI.parse _namespace_name "sourceConfluenceCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluenceElevation"></see>
    /// </summary>
    let sourceConfluenceElevation =
        Namespaced_IRI.parse _namespace_name "sourceConfluenceElevation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluenceMountain"></see>
    /// </summary>
    let sourceConfluenceMountain =
        Namespaced_IRI.parse _namespace_name "sourceConfluenceMountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluencePlace"></see>
    /// </summary>
    let sourceConfluencePlace =
        Namespaced_IRI.parse _namespace_name "sourceConfluencePlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluencePosition"></see>
    /// </summary>
    let sourceConfluencePosition =
        Namespaced_IRI.parse _namespace_name "sourceConfluencePosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluenceRegion"></see>
    /// </summary>
    let sourceConfluenceRegion =
        Namespaced_IRI.parse _namespace_name "sourceConfluenceRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceConfluenceState"></see>
    /// </summary>
    let sourceConfluenceState =
        Namespaced_IRI.parse _namespace_name "sourceConfluenceState" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceCountry"></see>
    /// </summary>
    let sourceCountry =
        Namespaced_IRI.parse _namespace_name "sourceCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceDistrict"></see>
    /// </summary>
    let sourceDistrict =
        Namespaced_IRI.parse _namespace_name "sourceDistrict" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceElevation"></see>
    /// </summary>
    let sourceElevation =
        Namespaced_IRI.parse _namespace_name "sourceElevation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceMountain"></see>
    /// </summary>
    let sourceMountain =
        Namespaced_IRI.parse _namespace_name "sourceMountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourcePlace"></see>
    /// </summary>
    let sourcePlace =
        Namespaced_IRI.parse _namespace_name "sourcePlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourcePosition"></see>
    /// </summary>
    let sourcePosition =
        Namespaced_IRI.parse _namespace_name "sourcePosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceRegion"></see>
    /// </summary>
    let sourceRegion =
        Namespaced_IRI.parse _namespace_name "sourceRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sourceState"></see>
    /// </summary>
    let sourceState =
        Namespaced_IRI.parse _namespace_name "sourceState" |> NamespacedName

    /// <summary>
    /// Source of something (eg an image) as text. Use dct:source if the source is described using a resource
    /// <see href="http://dbpedia.org/ontology/sourceText"></see></summary>
    let sourceText = Namespaced_IRI.parse _namespace_name "sourceText" |> NamespacedName

    /// <summary>
    /// indicates another place situated south-east.
    /// <see href="http://dbpedia.org/ontology/southEastPlace"></see></summary>
    let southEastPlace =
        Namespaced_IRI.parse _namespace_name "southEastPlace" |> NamespacedName

    /// <summary>
    /// indicates another place situated south.
    /// <see href="http://dbpedia.org/ontology/southPlace"></see></summary>
    let southPlace = Namespaced_IRI.parse _namespace_name "southPlace" |> NamespacedName

    /// <summary>
    /// indicates another place situated south-west.
    /// <see href="http://dbpedia.org/ontology/southWestPlace"></see></summary>
    let southWestPlace =
        Namespaced_IRI.parse _namespace_name "southWestPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sovereignCountry"></see>
    /// </summary>
    let sovereignCountry =
        Namespaced_IRI.parse _namespace_name "sovereignCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/space"></see>
    /// </summary>
    let space = Namespaced_IRI.parse _namespace_name "space" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spacecraft"></see>
    /// </summary>
    let spacecraft = Namespaced_IRI.parse _namespace_name "spacecraft" |> NamespacedName

    /// <summary>
    /// space station that has been visited during a space mission
    /// <see href="http://dbpedia.org/ontology/spacestation"></see></summary>
    let spacestation =
        Namespaced_IRI.parse _namespace_name "spacestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spacewalkBegin"></see>
    /// </summary>
    let spacewalkBegin =
        Namespaced_IRI.parse _namespace_name "spacewalkBegin" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spacewalkEnd"></see>
    /// </summary>
    let spacewalkEnd =
        Namespaced_IRI.parse _namespace_name "spacewalkEnd" |> NamespacedName

    /// <summary>
    /// number of office holder
    /// <see href="http://dbpedia.org/ontology/speaker"></see></summary>
    let speaker = Namespaced_IRI.parse _namespace_name "speaker" |> NamespacedName

    /// <summary>
    /// the person who is responsible for the film special effects
    /// <see href="http://dbpedia.org/ontology/specialEffects"></see></summary>
    let specialEffects =
        Namespaced_IRI.parse _namespace_name "specialEffects" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/specialTrial"></see>
    /// </summary>
    let specialTrial =
        Namespaced_IRI.parse _namespace_name "specialTrial" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/specialist"></see>
    /// </summary>
    let specialist = Namespaced_IRI.parse _namespace_name "specialist" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/speciality"></see>
    /// </summary>
    let speciality = Namespaced_IRI.parse _namespace_name "speciality" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/species"></see>
    /// </summary>
    let species = Namespaced_IRI.parse _namespace_name "species" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/speedLimit"></see>
    /// </summary>
    let speedLimit = Namespaced_IRI.parse _namespace_name "speedLimit" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spike"></see>
    /// </summary>
    let spike = Namespaced_IRI.parse _namespace_name "spike" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/splitFromParty"></see>
    /// </summary>
    let splitFromParty =
        Namespaced_IRI.parse _namespace_name "splitFromParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spokenIn"></see>
    /// </summary>
    let spokenIn = Namespaced_IRI.parse _namespace_name "spokenIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spokesperson"></see>
    /// </summary>
    let spokesperson =
        Namespaced_IRI.parse _namespace_name "spokesperson" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sport"></see>
    /// </summary>
    let sport = Namespaced_IRI.parse _namespace_name "sport" |> NamespacedName

    /// <summary>
    /// The country, for which the athlete is participating in championships
    /// <see href="http://dbpedia.org/ontology/sportCountry"></see></summary>
    let sportCountry =
        Namespaced_IRI.parse _namespace_name "sportCountry" |> NamespacedName

    /// <summary>
    /// the sport discipline the athlete practices, e.g. Diving, or that a board member of a sporting club is focussing at
    /// <see href="http://dbpedia.org/ontology/sportDiscipline"></see></summary>
    let sportDiscipline =
        Namespaced_IRI.parse _namespace_name "sportDiscipline" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sportGoverningBody"></see>
    /// </summary>
    let sportGoverningBody =
        Namespaced_IRI.parse _namespace_name "sportGoverningBody" |> NamespacedName

    /// <summary>
    /// the sport specialty the athlete practices, e.g. 'Ring' for a men's artistic gymnastics athlete
    /// <see href="http://dbpedia.org/ontology/sportSpecialty"></see></summary>
    let sportSpecialty =
        Namespaced_IRI.parse _namespace_name "sportSpecialty" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sportsFunction"></see>
    /// </summary>
    let sportsFunction =
        Namespaced_IRI.parse _namespace_name "sportsFunction" |> NamespacedName

    /// <summary>
    /// the person they are married to
    /// <see href="http://dbpedia.org/ontology/spouse"></see></summary>
    let spouse = Namespaced_IRI.parse _namespace_name "spouse" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spouseName"></see>
    /// </summary>
    let spouseName = Namespaced_IRI.parse _namespace_name "spouseName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spurOf"></see>
    /// </summary>
    let spurOf = Namespaced_IRI.parse _namespace_name "spurOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/spurType"></see>
    /// </summary>
    let spurType = Namespaced_IRI.parse _namespace_name "spurType" |> NamespacedName

    /// <summary>
    /// The number that an athlete wears in a team sport.
    /// <see href="http://dbpedia.org/ontology/squadNumber"></see></summary>
    let squadNumber =
        Namespaced_IRI.parse _namespace_name "squadNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stadium"></see>
    /// </summary>
    let stadium = Namespaced_IRI.parse _namespace_name "stadium" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/staff"></see>
    /// </summary>
    let staff = Namespaced_IRI.parse _namespace_name "staff" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/starRating"></see>
    /// </summary>
    let starRating = Namespaced_IRI.parse _namespace_name "starRating" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/starring"></see>
    /// </summary>
    let starring = Namespaced_IRI.parse _namespace_name "starring" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/start"></see>
    /// </summary>
    let start = Namespaced_IRI.parse _namespace_name "start" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startCareer"></see>
    /// </summary>
    let startCareer =
        Namespaced_IRI.parse _namespace_name "startCareer" |> NamespacedName

    /// <summary>
    /// The start date of the event.
    /// <see href="http://dbpedia.org/ontology/startDate"></see></summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName

    /// <summary>
    /// The start date and time of the event.
    /// <see href="http://dbpedia.org/ontology/startDateTime"></see></summary>
    let startDateTime =
        Namespaced_IRI.parse _namespace_name "startDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startOccupation"></see>
    /// </summary>
    let startOccupation =
        Namespaced_IRI.parse _namespace_name "startOccupation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startPoint"></see>
    /// </summary>
    let startPoint = Namespaced_IRI.parse _namespace_name "startPoint" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startReign"></see>
    /// </summary>
    let startReign = Namespaced_IRI.parse _namespace_name "startReign" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startWct"></see>
    /// </summary>
    let startWct = Namespaced_IRI.parse _namespace_name "startWct" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startWqs"></see>
    /// </summary>
    let startWqs = Namespaced_IRI.parse _namespace_name "startWqs" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startYear"></see>
    /// </summary>
    let startYear = Namespaced_IRI.parse _namespace_name "startYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startYearOfInsertion"></see>
    /// </summary>
    let startYearOfInsertion =
        Namespaced_IRI.parse _namespace_name "startYearOfInsertion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/startYearOfSales"></see>
    /// </summary>
    let startYearOfSales =
        Namespaced_IRI.parse _namespace_name "startYearOfSales" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statName"></see>
    /// </summary>
    let statName = Namespaced_IRI.parse _namespace_name "statName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statValue"></see>
    /// </summary>
    let statValue = Namespaced_IRI.parse _namespace_name "statValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/state"></see>
    /// </summary>
    let state = Namespaced_IRI.parse _namespace_name "state" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stateDelegate"></see>
    /// </summary>
    let stateDelegate =
        Namespaced_IRI.parse _namespace_name "stateDelegate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stateOfOrigin"></see>
    /// </summary>
    let stateOfOrigin =
        Namespaced_IRI.parse _namespace_name "stateOfOrigin" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stateOfOriginPoint"></see>
    /// </summary>
    let stateOfOriginPoint =
        Namespaced_IRI.parse _namespace_name "stateOfOriginPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stateOfOriginTeam"></see>
    /// </summary>
    let stateOfOriginTeam =
        Namespaced_IRI.parse _namespace_name "stateOfOriginTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stateOfOriginYear"></see>
    /// </summary>
    let stateOfOriginYear =
        Namespaced_IRI.parse _namespace_name "stateOfOriginYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stationEvaDuration"></see>
    /// </summary>
    let stationEvaDuration =
        Namespaced_IRI.parse _namespace_name "stationEvaDuration" |> NamespacedName

    /// <summary>
    /// Type of station structure (underground, at-grade, or elevated).
    /// <see href="http://dbpedia.org/ontology/stationStructure"></see></summary>
    let stationStructure =
        Namespaced_IRI.parse _namespace_name "stationStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stationVisitDuration"></see>
    /// </summary>
    let stationVisitDuration =
        Namespaced_IRI.parse _namespace_name "stationVisitDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statistic"></see>
    /// </summary>
    let statistic = Namespaced_IRI.parse _namespace_name "statistic" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statisticLabel"></see>
    /// </summary>
    let statisticLabel =
        Namespaced_IRI.parse _namespace_name "statisticLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statisticValue"></see>
    /// </summary>
    let statisticValue =
        Namespaced_IRI.parse _namespace_name "statisticValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statisticYear"></see>
    /// </summary>
    let statisticYear =
        Namespaced_IRI.parse _namespace_name "statisticYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/status"></see>
    /// </summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statusManager"></see>
    /// </summary>
    let statusManager =
        Namespaced_IRI.parse _namespace_name "statusManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/statusYear"></see>
    /// </summary>
    let statusYear = Namespaced_IRI.parse _namespace_name "statusYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stellarClassification"></see>
    /// </summary>
    let stellarClassification =
        Namespaced_IRI.parse _namespace_name "stellarClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stockExchange"></see>
    /// </summary>
    let stockExchange =
        Namespaced_IRI.parse _namespace_name "stockExchange" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/storyEditor"></see>
    /// </summary>
    let storyEditor =
        Namespaced_IRI.parse _namespace_name "storyEditor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/strength"></see>
    /// </summary>
    let strength = Namespaced_IRI.parse _namespace_name "strength" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/structuralSystem"></see>
    /// </summary>
    let structuralSystem =
        Namespaced_IRI.parse _namespace_name "structuralSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/student"></see>
    /// </summary>
    let student = Namespaced_IRI.parse _namespace_name "student" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/style"></see>
    /// </summary>
    let style = Namespaced_IRI.parse _namespace_name "style" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/stylisticOrigin"></see>
    /// </summary>
    let stylisticOrigin =
        Namespaced_IRI.parse _namespace_name "stylisticOrigin" |> NamespacedName

    /// <summary>
    /// a subdivision within a Species classis
    /// <see href="http://dbpedia.org/ontology/subClassis"></see></summary>
    let subClassis = Namespaced_IRI.parse _namespace_name "subClassis" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subFamily"></see>
    /// </summary>
    let subFamily = Namespaced_IRI.parse _namespace_name "subFamily" |> NamespacedName
    /// <summary>
    /// A rank in the classification of organisms, below genus ; a taxon at that rank
    /// <see href="http://dbpedia.org/ontology/subGenus"></see></summary>
    let subGenus = Namespaced_IRI.parse _namespace_name "subGenus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subMunicipalityType"></see>
    /// </summary>
    let subMunicipalityType =
        Namespaced_IRI.parse _namespace_name "subMunicipalityType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subOrder"></see>
    /// </summary>
    let subOrder = Namespaced_IRI.parse _namespace_name "subOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subPrefecture"></see>
    /// </summary>
    let subPrefecture =
        Namespaced_IRI.parse _namespace_name "subPrefecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subTribus"></see>
    /// </summary>
    let subTribus = Namespaced_IRI.parse _namespace_name "subTribus" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/Tribus"></see>
    /// </summary>
    let Tribus = Namespaced_IRI.parse _namespace_name "Tribus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subdivision"></see>
    /// </summary>
    let subdivision =
        Namespaced_IRI.parse _namespace_name "subdivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subdivisionLink"></see>
    /// </summary>
    let subdivisionLink =
        Namespaced_IRI.parse _namespace_name "subdivisionLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subdivisionName"></see>
    /// </summary>
    let subdivisionName =
        Namespaced_IRI.parse _namespace_name "subdivisionName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subdivisions"></see>
    /// </summary>
    let subdivisions =
        Namespaced_IRI.parse _namespace_name "subdivisions" |> NamespacedName

    /// <summary>
    /// The overall subject matter dealt with by the play.
    /// <see href="http://dbpedia.org/ontology/subjectOfPlay"></see></summary>
    let subjectOfPlay =
        Namespaced_IRI.parse _namespace_name "subjectOfPlay" |> NamespacedName

    /// <summary>
    /// The subject as a term, possibly a term from a formal classification
    /// <see href="http://dbpedia.org/ontology/subjectTerm"></see></summary>
    let subjectTerm =
        Namespaced_IRI.parse _namespace_name "subjectTerm" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/sublimationPoint"></see>
    /// </summary>
    let sublimationPoint =
        Namespaced_IRI.parse _namespace_name "sublimationPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/suborbitalFlights"></see>
    /// </summary>
    let suborbitalFlights =
        Namespaced_IRI.parse _namespace_name "suborbitalFlights" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subprefecture"></see>
    /// </summary>
    let subprefecture =
        Namespaced_IRI.parse _namespace_name "subprefecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subregion"></see>
    /// </summary>
    let subregion = Namespaced_IRI.parse _namespace_name "subregion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subsequentInfrastructure"></see>
    /// </summary>
    let subsequentInfrastructure =
        Namespaced_IRI.parse _namespace_name "subsequentInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subsequentWork"></see>
    /// </summary>
    let subsequentWork =
        Namespaced_IRI.parse _namespace_name "subsequentWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subsidiary"></see>
    /// </summary>
    let subsidiary = Namespaced_IRI.parse _namespace_name "subsidiary" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subsystem"></see>
    /// </summary>
    let subsystem = Namespaced_IRI.parse _namespace_name "subsystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subsystemLink"></see>
    /// </summary>
    let subsystemLink =
        Namespaced_IRI.parse _namespace_name "subsystemLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/subtitle"></see>
    /// </summary>
    let subtitle = Namespaced_IRI.parse _namespace_name "subtitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/successfulLaunches"></see>
    /// </summary>
    let successfulLaunches =
        Namespaced_IRI.parse _namespace_name "successfulLaunches" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/successor"></see>
    /// </summary>
    let successor = Namespaced_IRI.parse _namespace_name "successor" |> NamespacedName
    /// <summary>
    /// Système universitaire de documentation id (French collaborative library catalog).
    /// http://www.idref.fr/$1
    /// <see href="http://dbpedia.org/ontology/sudocId"></see></summary>
    let sudocId = Namespaced_IRI.parse _namespace_name "sudocId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/summerAppearances"></see>
    /// </summary>
    let summerAppearances =
        Namespaced_IRI.parse _namespace_name "summerAppearances" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/summerTemperature"></see>
    /// </summary>
    let summerTemperature =
        Namespaced_IRI.parse _namespace_name "summerTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/superFamily"></see>
    /// </summary>
    let superFamily =
        Namespaced_IRI.parse _namespace_name "superFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/superOrder"></see>
    /// </summary>
    let superOrder = Namespaced_IRI.parse _namespace_name "superOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/superTribus"></see>
    /// </summary>
    let superTribus =
        Namespaced_IRI.parse _namespace_name "superTribus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/superbowlWin"></see>
    /// </summary>
    let superbowlWin =
        Namespaced_IRI.parse _namespace_name "superbowlWin" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/superintendent"></see>
    /// </summary>
    let superintendent =
        Namespaced_IRI.parse _namespace_name "superintendent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/supplementalDraftRound"></see>
    /// </summary>
    let supplementalDraftRound =
        Namespaced_IRI.parse _namespace_name "supplementalDraftRound" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/supplementalDraftYear"></see>
    /// </summary>
    let supplementalDraftYear =
        Namespaced_IRI.parse _namespace_name "supplementalDraftYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/supplies"></see>
    /// </summary>
    let supplies = Namespaced_IRI.parse _namespace_name "supplies" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/supply"></see>
    /// </summary>
    let supply = Namespaced_IRI.parse _namespace_name "supply" |> NamespacedName

    /// <summary>
    /// Date when the Church forbade the veneration of this saint.
    /// (I hope that's what it means, I don't know why the original author didn't document it)
    /// <see href="http://dbpedia.org/ontology/suppreddedDate"></see></summary>
    let suppreddedDate =
        Namespaced_IRI.parse _namespace_name "suppreddedDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/surfaceArea"></see>
    /// </summary>
    let surfaceArea =
        Namespaced_IRI.parse _namespace_name "surfaceArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/surfaceFormOccurrenceOffset"></see>
    /// </summary>
    let surfaceFormOccurrenceOffset =
        Namespaced_IRI.parse _namespace_name "surfaceFormOccurrenceOffset" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/surfaceGravity"></see>
    /// </summary>
    let surfaceGravity =
        Namespaced_IRI.parse _namespace_name "surfaceGravity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/swimmingStyle"></see>
    /// </summary>
    let swimmingStyle =
        Namespaced_IRI.parse _namespace_name "swimmingStyle" |> NamespacedName

    /// <summary>
    /// HUGO Gene Symbol
    /// <see href="http://dbpedia.org/ontology/symbol"></see></summary>
    let symbol = Namespaced_IRI.parse _namespace_name "symbol" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/synonym"></see>
    /// </summary>
    let synonym = Namespaced_IRI.parse _namespace_name "synonym" |> NamespacedName

    /// <summary>
    /// A referral to the relevant system of law
    /// <see href="http://dbpedia.org/ontology/systemOfLaw"></see></summary>
    let systemOfLaw =
        Namespaced_IRI.parse _namespace_name "systemOfLaw" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/systemRequirements"></see>
    /// </summary>
    let systemRequirements =
        Namespaced_IRI.parse _namespace_name "systemRequirements" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tag"></see>
    /// </summary>
    let tag = Namespaced_IRI.parse _namespace_name "tag" |> NamespacedName
    /// <summary>
    /// head of government of Ireland
    /// <see href="http://dbpedia.org/ontology/taoiseach"></see></summary>
    let taoiseach = Namespaced_IRI.parse _namespace_name "taoiseach" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/targetAirport"></see>
    /// </summary>
    let targetAirport =
        Namespaced_IRI.parse _namespace_name "targetAirport" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/targetSpaceStation"></see>
    /// </summary>
    let targetSpaceStation =
        Namespaced_IRI.parse _namespace_name "targetSpaceStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/taste"></see>
    /// </summary>
    let taste = Namespaced_IRI.parse _namespace_name "taste" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tattoo"></see>
    /// </summary>
    let tattoo = Namespaced_IRI.parse _namespace_name "tattoo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/taxon"></see>
    /// </summary>
    let taxon = Namespaced_IRI.parse _namespace_name "taxon" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teachingStaff"></see>
    /// </summary>
    let teachingStaff =
        Namespaced_IRI.parse _namespace_name "teachingStaff" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teamCoached"></see>
    /// </summary>
    let teamCoached =
        Namespaced_IRI.parse _namespace_name "teamCoached" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teamManager"></see>
    /// </summary>
    let teamManager =
        Namespaced_IRI.parse _namespace_name "teamManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teamName"></see>
    /// </summary>
    let teamName = Namespaced_IRI.parse _namespace_name "teamName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teamPoint"></see>
    /// </summary>
    let teamPoint = Namespaced_IRI.parse _namespace_name "teamPoint" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teamSize"></see>
    /// </summary>
    let teamSize = Namespaced_IRI.parse _namespace_name "teamSize" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/teamTitle"></see>
    /// </summary>
    let teamTitle = Namespaced_IRI.parse _namespace_name "teamTitle" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/technique"></see>
    /// </summary>
    let technique = Namespaced_IRI.parse _namespace_name "technique" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/televisionSeries"></see>
    /// </summary>
    let televisionSeries =
        Namespaced_IRI.parse _namespace_name "televisionSeries" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tempPlace"></see>
    /// </summary>
    let tempPlace = Namespaced_IRI.parse _namespace_name "tempPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/temperature"></see>
    /// </summary>
    let temperature =
        Namespaced_IRI.parse _namespace_name "temperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/temple"></see>
    /// </summary>
    let temple = Namespaced_IRI.parse _namespace_name "temple" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/templeYear"></see>
    /// </summary>
    let templeYear = Namespaced_IRI.parse _namespace_name "templeYear" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tenant"></see>
    /// </summary>
    let tenant = Namespaced_IRI.parse _namespace_name "tenant" |> NamespacedName

    /// <summary>
    /// There are five types of court surface used in professional play. Each surface is different in the speed and height of the bounce of the ball.
    /// <see href="http://dbpedia.org/ontology/tennisSurfaceType"></see></summary>
    let tennisSurfaceType =
        Namespaced_IRI.parse _namespace_name "tennisSurfaceType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/termOfOffice"></see>
    /// </summary>
    let termOfOffice =
        Namespaced_IRI.parse _namespace_name "termOfOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/termPeriod"></see>
    /// </summary>
    let termPeriod = Namespaced_IRI.parse _namespace_name "termPeriod" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/territory"></see>
    /// </summary>
    let territory = Namespaced_IRI.parse _namespace_name "territory" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/MilitaryConflict,_AdministrativeRegion"></see>
    /// </summary>
    let ``MilitaryConflict,_AdministrativeRegion`` =
        Namespaced_IRI.parse _namespace_name "MilitaryConflict,_AdministrativeRegion" |> NamespacedName

    /// <summary>
    /// indexing code used by the Polish National Official Register of the Territorial Division of the Country (TERYT) to identify various entities
    /// <see href="http://dbpedia.org/ontology/terytCode"></see></summary>
    let terytCode = Namespaced_IRI.parse _namespace_name "terytCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tessitura"></see>
    /// </summary>
    let tessitura = Namespaced_IRI.parse _namespace_name "tessitura" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/testaverage"></see>
    /// </summary>
    let testaverage =
        Namespaced_IRI.parse _namespace_name "testaverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/theology"></see>
    /// </summary>
    let theology = Namespaced_IRI.parse _namespace_name "theology" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/third"></see>
    /// </summary>
    let third = Namespaced_IRI.parse _namespace_name "third" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/thirdCommander"></see>
    /// </summary>
    let thirdCommander =
        Namespaced_IRI.parse _namespace_name "thirdCommander" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/thirdDriver"></see>
    /// </summary>
    let thirdDriver =
        Namespaced_IRI.parse _namespace_name "thirdDriver" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/thirdDriverCountry"></see>
    /// </summary>
    let thirdDriverCountry =
        Namespaced_IRI.parse _namespace_name "thirdDriverCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/thirdPlace"></see>
    /// </summary>
    let thirdPlace = Namespaced_IRI.parse _namespace_name "thirdPlace" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/thirdTeam"></see>
    /// </summary>
    let thirdTeam = Namespaced_IRI.parse _namespace_name "thirdTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/throwingSide"></see>
    /// </summary>
    let throwingSide =
        Namespaced_IRI.parse _namespace_name "throwingSide" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/thumbnail"></see></summary>
    let thumbnail = Namespaced_IRI.parse _namespace_name "thumbnail" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/thumbnailCaption"></see>
    /// </summary>
    let thumbnailCaption =
        Namespaced_IRI.parse _namespace_name "thumbnailCaption" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tie"></see>
    /// </summary>
    let tie = Namespaced_IRI.parse _namespace_name "tie" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/time"></see>
    /// </summary>
    let time = Namespaced_IRI.parse _namespace_name "time" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/timeInSpace"></see>
    /// </summary>
    let timeInSpace =
        Namespaced_IRI.parse _namespace_name "timeInSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/timeZone"></see>
    /// </summary>
    let timeZone = Namespaced_IRI.parse _namespace_name "timeZone" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/timeshiftChannel"></see>
    /// </summary>
    let timeshiftChannel =
        Namespaced_IRI.parse _namespace_name "timeshiftChannel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/titleDate"></see>
    /// </summary>
    let titleDate = Namespaced_IRI.parse _namespace_name "titleDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/titleDouble"></see>
    /// </summary>
    let titleDouble =
        Namespaced_IRI.parse _namespace_name "titleDouble" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/titleLanguage"></see>
    /// </summary>
    let titleLanguage =
        Namespaced_IRI.parse _namespace_name "titleLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/titleSingle"></see>
    /// </summary>
    let titleSingle =
        Namespaced_IRI.parse _namespace_name "titleSingle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/toll"></see>
    /// </summary>
    let toll = Namespaced_IRI.parse _namespace_name "toll" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tonyAward"></see>
    /// </summary>
    let tonyAward = Namespaced_IRI.parse _namespace_name "tonyAward" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/topFloorHeight"></see>
    /// </summary>
    let topFloorHeight =
        Namespaced_IRI.parse _namespace_name "topFloorHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/topLevelDomain"></see>
    /// </summary>
    let topLevelDomain =
        Namespaced_IRI.parse _namespace_name "topLevelDomain" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/topSpeed"></see>
    /// </summary>
    let topSpeed = Namespaced_IRI.parse _namespace_name "topSpeed" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/topic"></see>
    /// </summary>
    let topic = Namespaced_IRI.parse _namespace_name "topic" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/torchBearer"></see>
    /// </summary>
    let torchBearer =
        Namespaced_IRI.parse _namespace_name "torchBearer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/torqueOutput"></see>
    /// </summary>
    let torqueOutput =
        Namespaced_IRI.parse _namespace_name "torqueOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/totalCargo"></see>
    /// </summary>
    let totalCargo = Namespaced_IRI.parse _namespace_name "totalCargo" |> NamespacedName
    /// <summary>
    /// the total number of discs contained in the album
    /// <see href="http://dbpedia.org/ontology/totalDiscs"></see></summary>
    let totalDiscs = Namespaced_IRI.parse _namespace_name "totalDiscs" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/totalLaunches"></see>
    /// </summary>
    let totalLaunches =
        Namespaced_IRI.parse _namespace_name "totalLaunches" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/totalMass"></see>
    /// </summary>
    let totalMass = Namespaced_IRI.parse _namespace_name "totalMass" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/totalPopulation"></see>
    /// </summary>
    let totalPopulation =
        Namespaced_IRI.parse _namespace_name "totalPopulation" |> NamespacedName

    /// <summary>
    /// the total number of tracks contained in the album
    /// <see href="http://dbpedia.org/ontology/totalTracks"></see></summary>
    let totalTracks =
        Namespaced_IRI.parse _namespace_name "totalTracks" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/totalTravellers"></see>
    /// </summary>
    let totalTravellers =
        Namespaced_IRI.parse _namespace_name "totalTravellers" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/touristicSite"></see>
    /// </summary>
    let touristicSite =
        Namespaced_IRI.parse _namespace_name "touristicSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tournamentOfChampions"></see>
    /// </summary>
    let tournamentOfChampions =
        Namespaced_IRI.parse _namespace_name "tournamentOfChampions" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tournamentRecord"></see>
    /// </summary>
    let tournamentRecord =
        Namespaced_IRI.parse _namespace_name "tournamentRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/towerHeight"></see>
    /// </summary>
    let towerHeight =
        Namespaced_IRI.parse _namespace_name "towerHeight" |> NamespacedName

    /// <summary>
    /// Length of the track. Wikipedians usually do not differentiate between track length and line lenght.
    /// <see href="http://dbpedia.org/ontology/trackLength"></see></summary>
    let trackLength =
        Namespaced_IRI.parse _namespace_name "trackLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/trackNumber"></see>
    /// </summary>
    let trackNumber =
        Namespaced_IRI.parse _namespace_name "trackNumber" |> NamespacedName

    /// <summary>
    /// Width of the track, e.g., the track width differing in Russia from (Western and Middle) European track width
    /// <see href="http://dbpedia.org/ontology/trackWidth"></see></summary>
    let trackWidth = Namespaced_IRI.parse _namespace_name "trackWidth" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tradeMark"></see>
    /// </summary>
    let tradeMark = Namespaced_IRI.parse _namespace_name "tradeMark" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/trainer"></see>
    /// </summary>
    let trainer = Namespaced_IRI.parse _namespace_name "trainer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/trainerClub"></see>
    /// </summary>
    let trainerClub =
        Namespaced_IRI.parse _namespace_name "trainerClub" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/trainerYears"></see>
    /// </summary>
    let trainerYears =
        Namespaced_IRI.parse _namespace_name "trainerYears" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/training"></see>
    /// </summary>
    let training = Namespaced_IRI.parse _namespace_name "training" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/translatedMotto"></see>
    /// </summary>
    let translatedMotto =
        Namespaced_IRI.parse _namespace_name "translatedMotto" |> NamespacedName

    /// <summary>
    /// Translator(s), if original not in English
    /// <see href="http://dbpedia.org/ontology/translator"></see></summary>
    let translator = Namespaced_IRI.parse _namespace_name "translator" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/transmission"></see>
    /// </summary>
    let transmission =
        Namespaced_IRI.parse _namespace_name "transmission" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tree"></see>
    /// </summary>
    let tree = Namespaced_IRI.parse _namespace_name "tree" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tribus"></see>
    /// </summary>
    let tribus = Namespaced_IRI.parse _namespace_name "tribus" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/trustee"></see>
    /// </summary>
    let trustee = Namespaced_IRI.parse _namespace_name "trustee" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tu"></see>
    /// </summary>
    let tu = Namespaced_IRI.parse _namespace_name "tu" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tuition"></see>
    /// </summary>
    let tuition = Namespaced_IRI.parse _namespace_name "tuition" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tvComId"></see>
    /// </summary>
    let tvComId = Namespaced_IRI.parse _namespace_name "tvComId" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/tvShow"></see>
    /// </summary>
    let tvShow = Namespaced_IRI.parse _namespace_name "tvShow" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/twinCountry"></see>
    /// </summary>
    let twinCountry =
        Namespaced_IRI.parse _namespace_name "twinCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/twinTown"></see>
    /// </summary>
    let twinTown = Namespaced_IRI.parse _namespace_name "twinTown" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/type"></see>
    /// </summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName

    /// <summary>
    /// Scale parameters that can be understood by Geohack, eg "type:", "scale:", "region:" "altitude:". Use "_" for several (eg "type:landmark_scale:50000"). See https://fr.wikipedia.org/wiki/Modèle:Infobox_Subdivision_administrative for examples, and https://fr.wikipedia.org/wiki/Modèle:GeoTemplate/Utilisation#La_mention_Type:... for a complete list
    /// <see href="http://dbpedia.org/ontology/typeCoordinate"></see></summary>
    let typeCoordinate =
        Namespaced_IRI.parse _namespace_name "typeCoordinate" |> NamespacedName

    /// <summary>
    /// Electrification system (e.g. Third rail, Overhead catenary).
    /// <see href="http://dbpedia.org/ontology/typeOfElectrification"></see></summary>
    let typeOfElectrification =
        Namespaced_IRI.parse _namespace_name "typeOfElectrification" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/typeOfGrain"></see>
    /// </summary>
    let typeOfGrain =
        Namespaced_IRI.parse _namespace_name "typeOfGrain" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/typeOfStorage"></see>
    /// </summary>
    let typeOfStorage =
        Namespaced_IRI.parse _namespace_name "typeOfStorage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/typeOfYeast"></see>
    /// </summary>
    let typeOfYeast =
        Namespaced_IRI.parse _namespace_name "typeOfYeast" |> NamespacedName

    /// <summary>
    /// DfE unique reference number of a school in England or Wales
    /// <see href="http://dbpedia.org/ontology/uRN"></see></summary>
    let uRN = Namespaced_IRI.parse _namespace_name "uRN" |> NamespacedName
    /// <summary>
    /// Official UCI code for cycling teams
    /// <see href="http://dbpedia.org/ontology/uciCode"></see></summary>
    let uciCode = Namespaced_IRI.parse _namespace_name "uciCode" |> NamespacedName
    /// <summary>
    /// Union List of Artist Names id (Getty Research Institute). ULAN has 293,000 names and other information about artists. Names in ULAN may include given names, pseudonyms, variant spellings, names in multiple languages, and names that have changed over time (e.g., married names).
    /// http://vocab.getty.edu/ulan/$1
    /// <see href="http://dbpedia.org/ontology/ulanId"></see></summary>
    let ulanId = Namespaced_IRI.parse _namespace_name "ulanId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/umbrellaTitle"></see>
    /// </summary>
    let umbrellaTitle =
        Namespaced_IRI.parse _namespace_name "umbrellaTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/undraftedYear"></see>
    /// </summary>
    let undraftedYear =
        Namespaced_IRI.parse _namespace_name "undraftedYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/unesco"></see>
    /// </summary>
    let unesco = Namespaced_IRI.parse _namespace_name "unesco" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/unicode"></see>
    /// </summary>
    let unicode = Namespaced_IRI.parse _namespace_name "unicode" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/uniprot"></see>
    /// </summary>
    let uniprot = Namespaced_IRI.parse _namespace_name "uniprot" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/unitCost"></see>
    /// </summary>
    let unitCost = Namespaced_IRI.parse _namespace_name "unitCost" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/unitaryAuthority"></see>
    /// </summary>
    let unitaryAuthority =
        Namespaced_IRI.parse _namespace_name "unitaryAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/unitedStatesNationalBridgeId"></see>
    /// </summary>
    let unitedStatesNationalBridgeId =
        Namespaced_IRI.parse _namespace_name "unitedStatesNationalBridgeId" |> NamespacedName

    /// <summary>
    /// university a person goes or went to.
    /// <see href="http://dbpedia.org/ontology/university"></see></summary>
    let university = Namespaced_IRI.parse _namespace_name "university" |> NamespacedName

    /// <summary>
    /// number of launches with unknown outcomes (or in progress)
    /// <see href="http://dbpedia.org/ontology/unknownOutcomes"></see></summary>
    let unknownOutcomes =
        Namespaced_IRI.parse _namespace_name "unknownOutcomes" |> NamespacedName

    /// <summary>
    /// UN/LOCODE, the United Nations Code for Trade and Transport Locations, is a geographic coding scheme developed and maintained by United Nations Economic Commission for Europe (UNECE), a unit of the United Nations. UN/LOCODE assigns codes to locations used in trade and transport  with functions such as seaports, rail and road terminals, airports, post offices and border crossing points.
    /// <see href="http://dbpedia.org/ontology/unloCode"></see></summary>
    let unloCode = Namespaced_IRI.parse _namespace_name "unloCode" |> NamespacedName
    /// <summary>
    /// The last update date of a resource
    /// <see href="http://dbpedia.org/ontology/updated"></see></summary>
    let updated = Namespaced_IRI.parse _namespace_name "updated" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/upperAge"></see>
    /// </summary>
    let upperAge = Namespaced_IRI.parse _namespace_name "upperAge" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/urbanArea"></see>
    /// </summary>
    let urbanArea = Namespaced_IRI.parse _namespace_name "urbanArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usOpenDouble"></see>
    /// </summary>
    let usOpenDouble =
        Namespaced_IRI.parse _namespace_name "usOpenDouble" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usOpenMixed"></see>
    /// </summary>
    let usOpenMixed =
        Namespaced_IRI.parse _namespace_name "usOpenMixed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usOpenSingle"></see>
    /// </summary>
    let usOpenSingle =
        Namespaced_IRI.parse _namespace_name "usOpenSingle" |> NamespacedName

    /// <summary>
    /// Number of things (eg vehicles) sold in the US
    /// <see href="http://dbpedia.org/ontology/usSales"></see></summary>
    let usSales = Namespaced_IRI.parse _namespace_name "usSales" |> NamespacedName
    /// <summary>
    /// wars that were typical for the usage of a weapon
    /// <see href="http://dbpedia.org/ontology/usedInWar"></see></summary>
    let usedInWar = Namespaced_IRI.parse _namespace_name "usedInWar" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usingCountry"></see>
    /// </summary>
    let usingCountry =
        Namespaced_IRI.parse _namespace_name "usingCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usk"></see>
    /// </summary>
    let usk = Namespaced_IRI.parse _namespace_name "usk" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usopenWins"></see>
    /// </summary>
    let usopenWins = Namespaced_IRI.parse _namespace_name "usopenWins" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/usurper"></see>
    /// </summary>
    let usurper = Namespaced_IRI.parse _namespace_name "usurper" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/utcOffset"></see>
    /// </summary>
    let utcOffset = Namespaced_IRI.parse _namespace_name "utcOffset" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/v_hb"></see>
    /// </summary>
    let v_hb = Namespaced_IRI.parse _namespace_name "v_hb" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/valvetrain"></see>
    /// </summary>
    let valvetrain = Namespaced_IRI.parse _namespace_name "valvetrain" |> NamespacedName
    /// <summary>
    /// variant or variation of something, for example the variant of a car
    /// <see href="http://dbpedia.org/ontology/variantOf"></see></summary>
    let variantOf = Namespaced_IRI.parse _namespace_name "variantOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/varietals"></see>
    /// </summary>
    let varietals = Namespaced_IRI.parse _namespace_name "varietals" |> NamespacedName
    /// <summary>
    /// vehicle that uses a specific automobile platform
    /// <see href="http://dbpedia.org/ontology/vehicle"></see></summary>
    let vehicle = Namespaced_IRI.parse _namespace_name "vehicle" |> NamespacedName

    /// <summary>
    /// Region related vehicle code on the vehicle plates.
    /// <see href="http://dbpedia.org/ontology/vehicleCode"></see></summary>
    let vehicleCode =
        Namespaced_IRI.parse _namespace_name "vehicleCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vehiclesPerDay"></see>
    /// </summary>
    let vehiclesPerDay =
        Namespaced_IRI.parse _namespace_name "vehiclesPerDay" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vein"></see>
    /// </summary>
    let vein = Namespaced_IRI.parse _namespace_name "vein" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/veneratedIn"></see>
    /// </summary>
    let veneratedIn =
        Namespaced_IRI.parse _namespace_name "veneratedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/version"></see>
    /// </summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
    /// <summary>
    /// Virtual International Authority File ID (operated by Online Computer Library Center, OCLC). Property range set to Agent because of corporate authors
    /// <see href="http://dbpedia.org/ontology/viafId"></see></summary>
    let viafId = Namespaced_IRI.parse _namespace_name "viafId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/viceChancellor"></see>
    /// </summary>
    let viceChancellor =
        Namespaced_IRI.parse _namespace_name "viceChancellor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/viceLeader"></see>
    /// </summary>
    let viceLeader = Namespaced_IRI.parse _namespace_name "viceLeader" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/viceLeaderParty"></see>
    /// </summary>
    let viceLeaderParty =
        Namespaced_IRI.parse _namespace_name "viceLeaderParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vicePresident"></see>
    /// </summary>
    let vicePresident =
        Namespaced_IRI.parse _namespace_name "vicePresident" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vicePrimeMinister"></see>
    /// </summary>
    let vicePrimeMinister =
        Namespaced_IRI.parse _namespace_name "vicePrimeMinister" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vicePrincipal"></see>
    /// </summary>
    let vicePrincipal =
        Namespaced_IRI.parse _namespace_name "vicePrincipal" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vicePrincipalLabel"></see>
    /// </summary>
    let vicePrincipalLabel =
        Namespaced_IRI.parse _namespace_name "vicePrincipalLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/victim"></see>
    /// </summary>
    let victim = Namespaced_IRI.parse _namespace_name "victim" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/victory"></see>
    /// </summary>
    let victory = Namespaced_IRI.parse _namespace_name "victory" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/victoryAsMgr"></see>
    /// </summary>
    let victoryAsMgr =
        Namespaced_IRI.parse _namespace_name "victoryAsMgr" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/victoryPercentageAsMgr"></see>
    /// </summary>
    let victoryPercentageAsMgr =
        Namespaced_IRI.parse _namespace_name "victoryPercentageAsMgr" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/virtualChannel"></see>
    /// </summary>
    let virtualChannel =
        Namespaced_IRI.parse _namespace_name "virtualChannel" |> NamespacedName

    /// <summary>
    /// Year visitor information was gathered.
    /// <see href="http://dbpedia.org/ontology/visitorStatisticsAsOf"></see></summary>
    let visitorStatisticsAsOf =
        Namespaced_IRI.parse _namespace_name "visitorStatisticsAsOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/visitorsPerDay"></see>
    /// </summary>
    let visitorsPerDay =
        Namespaced_IRI.parse _namespace_name "visitorsPerDay" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/visitorsPerYear"></see>
    /// </summary>
    let visitorsPerYear =
        Namespaced_IRI.parse _namespace_name "visitorsPerYear" |> NamespacedName

    /// <summary>
    /// Percentage increase or decrease.
    /// <see href="http://dbpedia.org/ontology/visitorsPercentageChange"></see></summary>
    let visitorsPercentageChange =
        Namespaced_IRI.parse _namespace_name "visitorsPercentageChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/visitorsTotal"></see>
    /// </summary>
    let visitorsTotal =
        Namespaced_IRI.parse _namespace_name "visitorsTotal" |> NamespacedName

    /// <summary>
    /// Voice artist used in a TelevisionShow, Movie, or to sound the voice of a FictionalCharacter
    /// <see href="http://dbpedia.org/ontology/voice"></see></summary>
    let voice = Namespaced_IRI.parse _namespace_name "voice" |> NamespacedName
    /// <summary>
    /// voice type of a singer or an actor
    /// <see href="http://dbpedia.org/ontology/voiceType"></see></summary>
    let voiceType = Namespaced_IRI.parse _namespace_name "voiceType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/volcanicActivity"></see>
    /// </summary>
    let volcanicActivity =
        Namespaced_IRI.parse _namespace_name "volcanicActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/volcanicType"></see>
    /// </summary>
    let volcanicType =
        Namespaced_IRI.parse _namespace_name "volcanicType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/volcanoId"></see>
    /// </summary>
    let volcanoId = Namespaced_IRI.parse _namespace_name "volcanoId" |> NamespacedName

    /// <summary>
    /// Voltage of the electrification system.
    /// <see href="http://dbpedia.org/ontology/voltageOfElectrification"></see></summary>
    let voltageOfElectrification =
        Namespaced_IRI.parse _namespace_name "voltageOfElectrification" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/volume"></see>
    /// </summary>
    let volume = Namespaced_IRI.parse _namespace_name "volume" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/volumeQuote"></see>
    /// </summary>
    let volumeQuote =
        Namespaced_IRI.parse _namespace_name "volumeQuote" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/volumes"></see>
    /// </summary>
    let volumes = Namespaced_IRI.parse _namespace_name "volumes" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/vonKlitzingConstant"></see>
    /// </summary>
    let vonKlitzingConstant =
        Namespaced_IRI.parse _namespace_name "vonKlitzingConstant" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/votesAgainst"></see>
    /// </summary>
    let votesAgainst =
        Namespaced_IRI.parse _namespace_name "votesAgainst" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/votesFor"></see>
    /// </summary>
    let votesFor = Namespaced_IRI.parse _namespace_name "votesFor" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wagon"></see>
    /// </summary>
    let wagon = Namespaced_IRI.parse _namespace_name "wagon" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/waistSize"></see>
    /// </summary>
    let waistSize = Namespaced_IRI.parse _namespace_name "waistSize" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/war"></see>
    /// </summary>
    let war = Namespaced_IRI.parse _namespace_name "war" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/ward"></see>
    /// </summary>
    let ward = Namespaced_IRI.parse _namespace_name "ward" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/water"></see>
    /// </summary>
    let water = Namespaced_IRI.parse _namespace_name "water" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/waterArea"></see>
    /// </summary>
    let waterArea = Namespaced_IRI.parse _namespace_name "waterArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/waterPercentage"></see>
    /// </summary>
    let waterPercentage =
        Namespaced_IRI.parse _namespace_name "waterPercentage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/watercourse"></see>
    /// </summary>
    let watercourse =
        Namespaced_IRI.parse _namespace_name "watercourse" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/watershed"></see>
    /// </summary>
    let watershed = Namespaced_IRI.parse _namespace_name "watershed" |> NamespacedName

    /// <summary>
    /// Waterway that goes through the tunnel.
    /// <see href="http://dbpedia.org/ontology/waterwayThroughTunnel"></see></summary>
    let waterwayThroughTunnel =
        Namespaced_IRI.parse _namespace_name "waterwayThroughTunnel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wavelength"></see>
    /// </summary>
    let wavelength = Namespaced_IRI.parse _namespace_name "wavelength" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/weapon"></see>
    /// </summary>
    let weapon = Namespaced_IRI.parse _namespace_name "weapon" |> NamespacedName
    /// <summary>
    /// The URL to the webcast of the Thing.
    /// <see href="http://dbpedia.org/ontology/webcast"></see></summary>
    let webcast = Namespaced_IRI.parse _namespace_name "webcast" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/websiteLabel"></see>
    /// </summary>
    let websiteLabel =
        Namespaced_IRI.parse _namespace_name "websiteLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/weddingParentsDate"></see>
    /// </summary>
    let weddingParentsDate =
        Namespaced_IRI.parse _namespace_name "weddingParentsDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/weight"></see>
    /// </summary>
    let weight = Namespaced_IRI.parse _namespace_name "weight" |> NamespacedName
    /// <summary>
    /// indicates another place situated west.
    /// <see href="http://dbpedia.org/ontology/westPlace"></see></summary>
    let westPlace = Namespaced_IRI.parse _namespace_name "westPlace" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/whaDraft"></see>
    /// </summary>
    let whaDraft = Namespaced_IRI.parse _namespace_name "whaDraft" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/whaDraftTeam"></see>
    /// </summary>
    let whaDraftTeam =
        Namespaced_IRI.parse _namespace_name "whaDraftTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/whaDraftYear"></see>
    /// </summary>
    let whaDraftYear =
        Namespaced_IRI.parse _namespace_name "whaDraftYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wheelbase"></see>
    /// </summary>
    let wheelbase = Namespaced_IRI.parse _namespace_name "wheelbase" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wholeArea"></see>
    /// </summary>
    let wholeArea = Namespaced_IRI.parse _namespace_name "wholeArea" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/width"></see>
    /// </summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/widthQuote"></see>
    /// </summary>
    let widthQuote = Namespaced_IRI.parse _namespace_name "widthQuote" |> NamespacedName

    /// <summary>
    /// Needs to be removed, left at the moment to not break DBpedia Live
    /// <see href="http://dbpedia.org/ontology/wikiPageCharacterSize"></see></summary>
    let wikiPageCharacterSize =
        Namespaced_IRI.parse _namespace_name "wikiPageCharacterSize" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageDisambiguates"></see></summary>
    let wikiPageDisambiguates =
        Namespaced_IRI.parse _namespace_name "wikiPageDisambiguates" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageEditLink"></see></summary>
    let wikiPageEditLink =
        Namespaced_IRI.parse _namespace_name "wikiPageEditLink" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageExternalLink"></see></summary>
    let wikiPageExternalLink =
        Namespaced_IRI.parse _namespace_name "wikiPageExternalLink" |> NamespacedName

    /// <summary>
    /// Date a page was extracted ''''''
    /// <see href="http://dbpedia.org/ontology/wikiPageExtracted"></see></summary>
    let wikiPageExtracted =
        Namespaced_IRI.parse _namespace_name "wikiPageExtracted" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageHistoryLink"></see></summary>
    let wikiPageHistoryLink =
        Namespaced_IRI.parse _namespace_name "wikiPageHistoryLink" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageID"></see></summary>
    let wikiPageID = Namespaced_IRI.parse _namespace_name "wikiPageID" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageInDegree"></see></summary>
    let wikiPageInDegree =
        Namespaced_IRI.parse _namespace_name "wikiPageInDegree" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageInterLanguageLink"></see></summary>
    let wikiPageInterLanguageLink =
        Namespaced_IRI.parse _namespace_name "wikiPageInterLanguageLink" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageLength"></see></summary>
    let wikiPageLength =
        Namespaced_IRI.parse _namespace_name "wikiPageLength" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia ''''''
    /// <see href="http://dbpedia.org/ontology/wikiPageModified"></see></summary>
    let wikiPageModified =
        Namespaced_IRI.parse _namespace_name "wikiPageModified" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageOutDegree"></see></summary>
    let wikiPageOutDegree =
        Namespaced_IRI.parse _namespace_name "wikiPageOutDegree" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageRedirects"></see></summary>
    let wikiPageRedirects =
        Namespaced_IRI.parse _namespace_name "wikiPageRedirects" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageRevisionID"></see></summary>
    let wikiPageRevisionID =
        Namespaced_IRI.parse _namespace_name "wikiPageRevisionID" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageRevisionLink"></see></summary>
    let wikiPageRevisionLink =
        Namespaced_IRI.parse _namespace_name "wikiPageRevisionLink" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageWikiLink"></see></summary>
    let wikiPageWikiLink =
        Namespaced_IRI.parse _namespace_name "wikiPageWikiLink" |> NamespacedName

    /// <summary>
    /// Reserved for DBpedia.
    /// <see href="http://dbpedia.org/ontology/wikiPageWikiLinkText"></see></summary>
    let wikiPageWikiLinkText =
        Namespaced_IRI.parse _namespace_name "wikiPageWikiLinkText" |> NamespacedName

    /// <summary>
    /// is used to denote splitting of a Wikidata IRI to one or more IRIs
    /// <see href="http://dbpedia.org/ontology/wikidataSplitIri"></see></summary>
    let wikidataSplitIri =
        Namespaced_IRI.parse _namespace_name "wikidataSplitIri" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wilaya"></see>
    /// </summary>
    let wilaya = Namespaced_IRI.parse _namespace_name "wilaya" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wimbledonDouble"></see>
    /// </summary>
    let wimbledonDouble =
        Namespaced_IRI.parse _namespace_name "wimbledonDouble" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wimbledonMixed"></see>
    /// </summary>
    let wimbledonMixed =
        Namespaced_IRI.parse _namespace_name "wimbledonMixed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wimbledonSingle"></see>
    /// </summary>
    let wimbledonSingle =
        Namespaced_IRI.parse _namespace_name "wimbledonSingle" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wineProduced"></see>
    /// </summary>
    let wineProduced =
        Namespaced_IRI.parse _namespace_name "wineProduced" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wineRegion"></see>
    /// </summary>
    let wineRegion = Namespaced_IRI.parse _namespace_name "wineRegion" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wineYear"></see>
    /// </summary>
    let wineYear = Namespaced_IRI.parse _namespace_name "wineYear" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wingArea"></see>
    /// </summary>
    let wingArea = Namespaced_IRI.parse _namespace_name "wingArea" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wingspan"></see>
    /// </summary>
    let wingspan = Namespaced_IRI.parse _namespace_name "wingspan" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wins"></see>
    /// </summary>
    let wins = Namespaced_IRI.parse _namespace_name "wins" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtAlpg"></see>
    /// </summary>
    let winsAtAlpg = Namespaced_IRI.parse _namespace_name "winsAtAlpg" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtAsia"></see>
    /// </summary>
    let winsAtAsia = Namespaced_IRI.parse _namespace_name "winsAtAsia" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtAus"></see>
    /// </summary>
    let winsAtAus = Namespaced_IRI.parse _namespace_name "winsAtAus" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtChallenges"></see>
    /// </summary>
    let winsAtChallenges =
        Namespaced_IRI.parse _namespace_name "winsAtChallenges" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtChampionships"></see>
    /// </summary>
    let winsAtChampionships =
        Namespaced_IRI.parse _namespace_name "winsAtChampionships" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtJLPGA"></see>
    /// </summary>
    let winsAtJLPGA =
        Namespaced_IRI.parse _namespace_name "winsAtJLPGA" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtJapan"></see>
    /// </summary>
    let winsAtJapan =
        Namespaced_IRI.parse _namespace_name "winsAtJapan" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtKLPGA"></see>
    /// </summary>
    let winsAtKLPGA =
        Namespaced_IRI.parse _namespace_name "winsAtKLPGA" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtLAGT"></see>
    /// </summary>
    let winsAtLAGT = Namespaced_IRI.parse _namespace_name "winsAtLAGT" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtLET"></see>
    /// </summary>
    let winsAtLET = Namespaced_IRI.parse _namespace_name "winsAtLET" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtLPGA"></see>
    /// </summary>
    let winsAtLPGA = Namespaced_IRI.parse _namespace_name "winsAtLPGA" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtMajors"></see>
    /// </summary>
    let winsAtMajors =
        Namespaced_IRI.parse _namespace_name "winsAtMajors" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtNWIDE"></see>
    /// </summary>
    let winsAtNWIDE =
        Namespaced_IRI.parse _namespace_name "winsAtNWIDE" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtOtherTournaments"></see>
    /// </summary>
    let winsAtOtherTournaments =
        Namespaced_IRI.parse _namespace_name "winsAtOtherTournaments" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtPGA"></see>
    /// </summary>
    let winsAtPGA = Namespaced_IRI.parse _namespace_name "winsAtPGA" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtProTournaments"></see>
    /// </summary>
    let winsAtProTournaments =
        Namespaced_IRI.parse _namespace_name "winsAtProTournaments" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtSenEuro"></see>
    /// </summary>
    let winsAtSenEuro =
        Namespaced_IRI.parse _namespace_name "winsAtSenEuro" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsAtSun"></see>
    /// </summary>
    let winsAtSun = Namespaced_IRI.parse _namespace_name "winsAtSun" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winsInEurope"></see>
    /// </summary>
    let winsInEurope =
        Namespaced_IRI.parse _namespace_name "winsInEurope" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winterAppearances"></see>
    /// </summary>
    let winterAppearances =
        Namespaced_IRI.parse _namespace_name "winterAppearances" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/winterTemperature"></see>
    /// </summary>
    let winterTemperature =
        Namespaced_IRI.parse _namespace_name "winterTemperature" |> NamespacedName

    /// <summary>
    /// World Register of Marine Species
    /// <see href="http://dbpedia.org/ontology/woRMS"></see></summary>
    let woRMS = Namespaced_IRI.parse _namespace_name "woRMS" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wordBefore"></see>
    /// </summary>
    let wordBefore = Namespaced_IRI.parse _namespace_name "wordBefore" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/work"></see>
    /// </summary>
    let work = Namespaced_IRI.parse _namespace_name "work" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/workArea"></see>
    /// </summary>
    let workArea = Namespaced_IRI.parse _namespace_name "workArea" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/world"></see>
    /// </summary>
    let world = Namespaced_IRI.parse _namespace_name "world" |> NamespacedName

    /// <summary>
    /// can be one or several years
    /// <see href="http://dbpedia.org/ontology/worldChampionTitleYear"></see></summary>
    let worldChampionTitleYear =
        Namespaced_IRI.parse _namespace_name "worldChampionTitleYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worldOpen"></see>
    /// </summary>
    let worldOpen = Namespaced_IRI.parse _namespace_name "worldOpen" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worldTeamCup"></see>
    /// </summary>
    let worldTeamCup =
        Namespaced_IRI.parse _namespace_name "worldTeamCup" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worldTournament"></see>
    /// </summary>
    let worldTournament =
        Namespaced_IRI.parse _namespace_name "worldTournament" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worldTournamentBronze"></see>
    /// </summary>
    let worldTournamentBronze =
        Namespaced_IRI.parse _namespace_name "worldTournamentBronze" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worldTournamentGold"></see>
    /// </summary>
    let worldTournamentGold =
        Namespaced_IRI.parse _namespace_name "worldTournamentGold" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worldTournamentSilver"></see>
    /// </summary>
    let worldTournamentSilver =
        Namespaced_IRI.parse _namespace_name "worldTournamentSilver" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/worstDefeat"></see>
    /// </summary>
    let worstDefeat =
        Namespaced_IRI.parse _namespace_name "worstDefeat" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wptFinalTable"></see>
    /// </summary>
    let wptFinalTable =
        Namespaced_IRI.parse _namespace_name "wptFinalTable" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wptItm"></see>
    /// </summary>
    let wptItm = Namespaced_IRI.parse _namespace_name "wptItm" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wptTitle"></see>
    /// </summary>
    let wptTitle = Namespaced_IRI.parse _namespace_name "wptTitle" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/writer"></see>
    /// </summary>
    let writer = Namespaced_IRI.parse _namespace_name "writer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wsopItm"></see>
    /// </summary>
    let wsopItm = Namespaced_IRI.parse _namespace_name "wsopItm" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wsopWinYear"></see>
    /// </summary>
    let wsopWinYear =
        Namespaced_IRI.parse _namespace_name "wsopWinYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/wsopWristband"></see>
    /// </summary>
    let wsopWristband =
        Namespaced_IRI.parse _namespace_name "wsopWristband" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/year"></see>
    /// </summary>
    let year = Namespaced_IRI.parse _namespace_name "year" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/yearElevationIntoNobility"></see>
    /// </summary>
    let yearElevationIntoNobility =
        Namespaced_IRI.parse _namespace_name "yearElevationIntoNobility" |> NamespacedName

    /// <summary>
    /// The year in which construction of the Place was finished.
    /// <see href="http://dbpedia.org/ontology/yearOfConstruction"></see></summary>
    let yearOfConstruction =
        Namespaced_IRI.parse _namespace_name "yearOfConstruction" |> NamespacedName

    /// <summary>
    /// Year station was electrified, if not previously at date of opening.
    /// <see href="http://dbpedia.org/ontology/yearOfElectrification"></see></summary>
    let yearOfElectrification =
        Namespaced_IRI.parse _namespace_name "yearOfElectrification" |> NamespacedName

    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/years"></see>
    /// </summary>
    let years = Namespaced_IRI.parse _namespace_name "years" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/youthClub"></see>
    /// </summary>
    let youthClub = Namespaced_IRI.parse _namespace_name "youthClub" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/youthWing"></see>
    /// </summary>
    let youthWing = Namespaced_IRI.parse _namespace_name "youthWing" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/youthYears"></see>
    /// </summary>
    let youthYears = Namespaced_IRI.parse _namespace_name "youthYears" |> NamespacedName
    /// <summary>
    /// Identifier for serial titles. More precise than issn
    /// <see href="http://dbpedia.org/ontology/zdb"></see></summary>
    let zdb = Namespaced_IRI.parse _namespace_name "zdb" |> NamespacedName
    /// <summary>
    ///   <see href="http://dbpedia.org/ontology/zipCode"></see>
    /// </summary>
    let zipCode = Namespaced_IRI.parse _namespace_name "zipCode" |> NamespacedName
    /// <summary>
    /// Zodiac Sign. Applies to persons, planets, etc
    /// <see href="http://dbpedia.org/ontology/zodiacSign"></see></summary>
    let zodiacSign = Namespaced_IRI.parse _namespace_name "zodiacSign" |> NamespacedName
