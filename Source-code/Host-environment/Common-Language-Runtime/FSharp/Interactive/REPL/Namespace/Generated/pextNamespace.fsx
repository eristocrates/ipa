#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pext =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontotext.com/proton/protonext#" "pext"

    /// <summary>
    ///   <para>rdfs:label : Automatic Teller Machine (ATM)</para>
    ///   <para>rdfs:comment : An unattended electronic machine in a public place, connected to a data system and related equipment and activated by a bank customer to obtain cash withdrawals and other banking services.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ATM">pext:ATM</a>
    /// </summary>
    let ATM = _prefixId.prefix "ATM"
    /// <summary>
    ///   <para>rdfs:label : Academic journal</para>
    ///   <para>rdfs:comment : A journal publishing scientific articles</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AcademicJournal">pext:AcademicJournal</a>
    /// </summary>
    let AcademicJournal = _prefixId.prefix "AcademicJournal"
    /// <summary>
    ///   <para>rdfs:label : Accident</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Accident">pext:Accident</a>
    /// </summary>
    let Accident = _prefixId.prefix "Accident"
    /// <summary>
    ///   <para>rdfs:label : Account</para>
    ///   <para>rdfs:comment : An explicit agreement between agents. Typically, service providers (e.g. banks or ISPs) provide accounts to their customers or users, which are considered account owners. The existence of the account depends on the provider, even though the user owns it in some metaphoric sense. Examples could be bank, ISP, e-Commerce, ICQ, email accounts. The accounts are usually aligned with a sort of contract.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Account">pext:Account</a>
    /// </summary>
    let Account = _prefixId.prefix "Account"
    /// <summary>
    ///   <para>rdfs:label : Acquirement</para>
    ///   <para>rdfs:comment : The event of the acquiring of one organization by another.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Acquirement">pext:Acquirement</a>
    /// </summary>
    let Acquirement = _prefixId.prefix "Acquirement"
    /// <summary>
    ///   <para>rdfs:label : Activity</para>
    ///   <para>rdfs:comment : Each activity is a Happening which involves volition and participants. It has temporal dimension. It is distinguished from Events by the fact that the activity does not trigger change of state and does not have a conceptual end point.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Activity">pext:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    let Actor = _prefixId.prefix "Actor"
    /// <summary>
    ///   <para>rdfs:label : Address</para>
    ///   <para>rdfs:comment : Any sort of address, specifying how to locate something somewhere.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Address">pext:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    /// <summary>
    ///   <para>rdfs:label : Administrative Region</para>
    ///   <para>rdfs:comment : Any administrative region. NIMA GNS designators - PCLIX</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AdministrativeRegion">pext:AdministrativeRegion</a>
    /// </summary>
    let AdministrativeRegion = _prefixId.prefix "AdministrativeRegion"
    /// <summary>
    ///   <para>rdfs:label : Agricultural Colony</para>
    ///   <para>rdfs:comment : A tract of land set aside for agricultural settlement. NIMA GNS designator L.AGRC.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AgriculturalColony">pext:AgriculturalColony</a>
    /// </summary>
    let AgriculturalColony = _prefixId.prefix "AgriculturalColony"
    /// <summary>
    ///   <para>rdfs:label : Agricultural Facility</para>
    ///   <para>rdfs:comment : An agricultural facility; a building and/or tract of land used for improving agriculture</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AgriculturalFacility">pext:AgriculturalFacility</a>
    /// </summary>
    let AgriculturalFacility = _prefixId.prefix "AgriculturalFacility"
    /// <summary>
    ///   <para>rdfs:label : Airbase</para>
    ///   <para>rdfs:comment : An area used to store supplies, provide barracks for air force personnel, hangars and runways for aircraft, and from which operations are initiated</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Airbase">pext:Airbase</a>
    /// </summary>
    let Airbase = _prefixId.prefix "Airbase"
    /// <summary>
    ///   <para>rdfs:label : Airline</para>
    ///   <para>rdfs:comment : A company providing air transport services.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Airline">pext:Airline</a>
    /// </summary>
    let Airline = _prefixId.prefix "Airline"
    /// <summary>
    ///   <para>rdfs:label : Airplane Engine</para>
    ///   <para>rdfs:comment : Engines of airplanes</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AirplaneEngine">pext:AirplaneEngine</a>
    /// </summary>
    let AirplaneEngine = _prefixId.prefix "AirplaneEngine"
    /// <summary>
    ///   <para>rdfs:label : Airplane Model</para>
    ///   <para>rdfs:comment : A concrete model of an airplane which determines the main features of any airplane of this model. For example, Boeing 737, Airbus A330, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AirplaneModel">pext:AirplaneModel</a>
    /// </summary>
    let AirplaneModel = _prefixId.prefix "AirplaneModel"
    /// <summary>
    ///   <para>rdfs:label : Airport</para>
    ///   <para>rdfs:comment : An airport, including heliports. NIMA GNS designators AIRP, AIRH.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Airport">pext:Airport</a>
    /// </summary>
    let Airport = _prefixId.prefix "Airport"
    /// <summary>
    ///   <para>rdfs:label : Album</para>
    ///   <para>rdfs:comment : An recording of a several songs. Usually from the same singer.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Album">pext:Album</a>
    /// </summary>
    let Album = _prefixId.prefix "Album"
    /// <summary>
    ///   <para>rdfs:label : Alcoholic Beverage</para>
    ///   <para>rdfs:comment : A type (specific receipe) for a beverage. For instance: Guiness Beer, Absolut Currant, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AlcoholicBeverage">pext:AlcoholicBeverage</a>
    /// </summary>
    let AlcoholicBeverage = _prefixId.prefix "AlcoholicBeverage"
    let Ambassador = _prefixId.prefix "Ambassador"
    /// <summary>
    ///   <para>rdfs:label : American Football League</para>
    ///   <para>rdfs:comment : Any American football league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AmericanFootballLeague">pext:AmericanFootballLeague</a>
    /// </summary>
    let AmericanFootballLeague = _prefixId.prefix "AmericanFootballLeague"
    let AmericanFootballPlayer = _prefixId.prefix "AmericanFootballPlayer"
    /// <summary>
    ///   <para>rdfs:label : American Football Team</para>
    ///   <para>rdfs:comment : Any American Football Team</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AmericanFootballTeam">pext:AmericanFootballTeam</a>
    /// </summary>
    let AmericanFootballTeam = _prefixId.prefix "AmericanFootballTeam"
    /// <summary>
    ///   <para>rdfs:label : Amphibian</para>
    ///   <para>rdfs:comment : Amphibian denotes animals such as frogs, salamanders, and caecilians, that are ectothermic (or cold-blooded) animals and metamorphose from a juvenile water-breathing form, either to an adult air-breathing form, or to a paedomorph that retains some juvenile characteristics. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Amphibian">pext:Amphibian</a>
    /// </summary>
    let Amphibian = _prefixId.prefix "Amphibian"
    /// <summary>
    ///   <para>rdfs:label : Amusement Park</para>
    ///   <para>rdfs:comment : (ADL FT) Commercially operated enterprises that offer rides, games, and other forms of entertainment. NIMA GNS designator - no equivalents.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AmusementPark">pext:AmusementPark</a>
    /// </summary>
    let AmusementPark = _prefixId.prefix "AmusementPark"
    /// <summary>
    ///   <para>rdfs:label : Animal</para>
    ///   <para>rdfs:comment : Animals are a major group of multicellular, eukaryotic organisms. Their body plan eventually becomes fixed as they develop. Most animals are motile. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Animal">pext:Animal</a>
    /// </summary>
    let Animal = _prefixId.prefix "Animal"
    /// <summary>
    ///   <para>rdfs:label : Announcement</para>
    ///   <para>rdfs:comment : A formal public statement; "the government made an announcement about the changes in the drug war" ; "a declaration of independence".) WordNet 1.7.1</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Announcement">pext:Announcement</a>
    /// </summary>
    let Announcement = _prefixId.prefix "Announcement"
    /// <summary>
    ///   <para>rdfs:label : Arachnid</para>
    ///   <para>rdfs:comment : Arachnid denotes a class of joint-legged invertebrate animals in the subphylum Chelicerata. All arachnids have eight legs, although in some species the front pair may convert to a sensory function. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Arachnid">pext:Arachnid</a>
    /// </summary>
    let Arachnid = _prefixId.prefix "Arachnid"
    /// <summary>
    ///   <para>rdfs:label : Arch</para>
    ///   <para>rdfs:comment : A natural or man-made structure in the form of an arch</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Arch">pext:Arch</a>
    /// </summary>
    let Arch = _prefixId.prefix "Arch"
    /// <summary>
    ///   <para>rdfs:label : Archaea</para>
    ///   <para>rdfs:comment : Archaea (archeon) are a group of single-celled microorganisms without a cell nucleus or any other membrane-bound organelles (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Archaea">pext:Archaea</a>
    /// </summary>
    let Archaea = _prefixId.prefix "Archaea"
    /// <summary>
    ///   <para>rdfs:label : Archipelago</para>
    ///   <para>rdfs:comment : (ADL FT) Seas or areas in a sea that contain numerous islands; also, the island groups themselves. NIMA GNS designator - no equivalent.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Archipelago">pext:Archipelago</a>
    /// </summary>
    let Archipelago = _prefixId.prefix "Archipelago"
    let Architect = _prefixId.prefix "Architect"
    /// <summary>
    ///   <para>rdfs:label : Arena</para>
    ///   <para>rdfs:comment : Any arena</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Arena">pext:Arena</a>
    /// </summary>
    let Arena = _prefixId.prefix "Arena"
    /// <summary>
    ///   <para>rdfs:label : Art</para>
    ///   <para>rdfs:comment : Art is the product or process of deliberately arranging items (often with symbolic significance) in a way that influences and affects one or more of the senses, emotions, and intellect. Wikipedia.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Art">pext:Art</a>
    /// </summary>
    let Art = _prefixId.prefix "Art"
    /// <summary>
    ///   <para>rdfs:label : Art Performance</para>
    ///   <para>rdfs:comment : A specific performance taking place at some moment, somewhere. Quite often starting at 19:00 in the theatre, stadium, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ArtPerformance">pext:ArtPerformance</a>
    /// </summary>
    let ArtPerformance = _prefixId.prefix "ArtPerformance"
    /// <summary>
    ///   <para>rdfs:label : Sportsman</para>
    ///   <para>rdfs:comment : A profession in the area of art.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ArtProfession">pext:ArtProfession</a>
    /// </summary>
    let ArtProfession = _prefixId.prefix "ArtProfession"
    /// <summary>
    ///   <para>rdfs:label : Artery</para>
    ///   <para>rdfs:comment : Any artery as a part of the body.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Artery">pext:Artery</a>
    /// </summary>
    let Artery = _prefixId.prefix "Artery"
    /// <summary>
    ///   <para>rdfs:label : Article</para>
    ///   <para>rdfs:comment : A relatively short document published as a part of Resource Collection.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Article">pext:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>rdfs:label : Artificial Satellite</para>
    ///   <para>rdfs:comment : A satellite created by humans</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ArtificialSatellite">pext:ArtificialSatellite</a>
    /// </summary>
    let ArtificialSatellite = _prefixId.prefix "ArtificialSatellite"
    let Artist = _prefixId.prefix "Artist"
    /// <summary>
    ///   <para>rdfs:label : Asteroid</para>
    ///   <para>rdfs:comment : Asteroids are a class of small Solar System bodies in orbit around the Sun. Wikipedia</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Asteroid">pext:Asteroid</a>
    /// </summary>
    let Asteroid = _prefixId.prefix "Asteroid"
    let Astronaut = _prefixId.prefix "Astronaut"
    /// <summary>
    ///   <para>rdfs:label : Astronomical Object</para>
    ///   <para>rdfs:comment : Any object studied by astronomers, (usually quite large natural and inanimate) object that is located in the physical universe and is not on the surface of the Earth. Definition partly derived from OpenCyc 0.7</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AstronomicalObject">pext:AstronomicalObject</a>
    /// </summary>
    let AstronomicalObject = _prefixId.prefix "AstronomicalObject"
    let Athlete = _prefixId.prefix "Athlete"
    /// <summary>
    ///   <para>rdfs:label : Atoll</para>
    ///   <para>rdfs:comment : Any atoll</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Atoll">pext:Atoll</a>
    /// </summary>
    let Atoll = _prefixId.prefix "Atoll"
    /// <summary>
    ///   <para>rdfs:label : Audio Recording</para>
    ///   <para>rdfs:comment : An recording of a piece of music.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AudioRecording">pext:AudioRecording</a>
    /// </summary>
    let AudioRecording = _prefixId.prefix "AudioRecording"
    /// <summary>
    ///   <para>rdfs:label : Australian Football League</para>
    ///   <para>rdfs:comment : Any Australian football league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AustralianFootballLeague">pext:AustralianFootballLeague</a>
    /// </summary>
    let AustralianFootballLeague = _prefixId.prefix "AustralianFootballLeague"
    let AustralianRulesFootballPlayer = _prefixId.prefix "AustralianRulesFootballPlayer"
    /// <summary>
    ///   <para>rdfs:label : Auto Racing League</para>
    ///   <para>rdfs:comment : Any Auto Racing league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AutoRacingLeague">pext:AutoRacingLeague</a>
    /// </summary>
    let AutoRacingLeague = _prefixId.prefix "AutoRacingLeague"
    /// <summary>
    ///   <para>rdfs:label : Automobile Engine</para>
    ///   <para>rdfs:comment : Engines of automobiles</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#AutomobileEngine">pext:AutomobileEngine</a>
    /// </summary>
    let AutomobileEngine = _prefixId.prefix "AutomobileEngine"
    /// <summary>
    ///   <para>rdfs:label : Award</para>
    ///   <para>rdfs:comment : Any award. An award is something given to a person or a group of people to recognize excellence in a certain field; a certificate of excellence, for example trophies, titles, medals, badges, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Award">pext:Award</a>
    /// </summary>
    let Award = _prefixId.prefix "Award"
    /// <summary>
    ///   <para>rdfs:label : Bacteria</para>
    ///   <para>rdfs:comment : Bacteria is a single-celled, prokaryote microorganisms, typically a few micrometres in length (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Bacteria">pext:Bacteria</a>
    /// </summary>
    let Bacteria = _prefixId.prefix "Bacteria"
    let BadmintonPlayer = _prefixId.prefix "BadmintonPlayer"
    /// <summary>
    ///   <para>rdfs:label : Band</para>
    ///   <para>rdfs:comment : Any band, a group performing music or other activity together.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Band">pext:Band</a>
    /// </summary>
    let Band = _prefixId.prefix "Band"
    /// <summary>
    ///   <para>rdfs:label : Bank</para>
    ///   <para>rdfs:comment : A business establishment in which money is kept for saving or commercial purposes or is invested, supplied for loans, or exchanged.rdfs:comment : A company providing financial services like credits, deposits, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Bank">pext:Bank</a>
    /// </summary>
    let Bank = _prefixId.prefix "Bank"
    /// <summary>
    ///   <para>rdfs:label : Barracks</para>
    ///   <para>rdfs:comment : A building for lodging military personnel</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Barracks">pext:Barracks</a>
    /// </summary>
    let Barracks = _prefixId.prefix "Barracks"
    /// <summary>
    ///   <para>rdfs:label : Baseball League</para>
    ///   <para>rdfs:comment : Any Baseball league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#BaseballLeague">pext:BaseballLeague</a>
    /// </summary>
    let BaseballLeague = _prefixId.prefix "BaseballLeague"
    let BaseballPlayer = _prefixId.prefix "BaseballPlayer"
    /// <summary>
    ///   <para>rdfs:label : Baseball Team</para>
    ///   <para>rdfs:comment : Any Baseball team</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#BaseballTeam">pext:BaseballTeam</a>
    /// </summary>
    let BaseballTeam = _prefixId.prefix "BaseballTeam"
    /// <summary>
    ///   <para>rdfs:label : Basketball League</para>
    ///   <para>rdfs:comment : Any Basketball league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#BasketballLeague">pext:BasketballLeague</a>
    /// </summary>
    let BasketballLeague = _prefixId.prefix "BasketballLeague"
    let BasketballPlayer = _prefixId.prefix "BasketballPlayer"
    /// <summary>
    ///   <para>rdfs:label : Basketball Team</para>
    ///   <para>rdfs:comment : Any basketball team</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#BasketballTeam">pext:BasketballTeam</a>
    /// </summary>
    let BasketballTeam = _prefixId.prefix "BasketballTeam"
    /// <summary>
    ///   <para>rdfs:label : Battlefield</para>
    ///   <para>rdfs:comment : A site of a land battle of historical importance. NIMA GNS designator L.BTL.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Battlefield">pext:Battlefield</a>
    /// </summary>
    let Battlefield = _prefixId.prefix "Battlefield"
    /// <summary>
    ///   <para>rdfs:label : Bay</para>
    ///   <para>rdfs:comment : (ADL FT) Indentations of a coastline or shoreline enclosing a part of a body of water; bodies of water partly surrounded by land. We use this category for bahias; for coves; and for embayments. NIMA GNS designators BAY, BAYS.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Bay">pext:Bay</a>
    /// </summary>
    let Bay = _prefixId.prefix "Bay"
    /// <summary>
    ///   <para>rdfs:label : Beach</para>
    ///   <para>rdfs:comment : (ADL FT) Sloping shores along a body of water that is washed by waves or tides and is usually covered by sand or gravel. ... We use this category for sandy areas; and for strands. NIMA GNS designator BCH, BCHS.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Beach">pext:Beach</a>
    /// </summary>
    let Beach = _prefixId.prefix "Beach"
    /// <summary>
    ///   <para>rdfs:label : Beacon</para>
    ///   <para>rdfs:comment : A fixed artificial navigation mark</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Beacon">pext:Beacon</a>
    /// </summary>
    let Beacon = _prefixId.prefix "Beacon"
    /// <summary>
    ///   <para>rdfs:label : Beverage</para>
    ///   <para>rdfs:comment : Any liquid suitable for drinking (WordNet, 1.7). The instances of this class are types of drinks, specific receipts. For instance: Diet Coke, Bacardi Spice.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Beverage">pext:Beverage</a>
    /// </summary>
    let Beverage = _prefixId.prefix "Beverage"
    /// <summary>
    ///   <para>rdfs:label : Bight</para>
    ///   <para>rdfs:comment : An open body of water forming a slight recession in a coastline</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Bight">pext:Bight</a>
    /// </summary>
    let Bight = _prefixId.prefix "Bight"
    /// <summary>
    ///   <para>rdfs:label : Biogeographic Region</para>
    ///   <para>rdfs:comment : (ADL FT) Geographic regions characterized chiefly by the dominant forms of plant life and the prevailing climate. [Adapted from American Heritage Dict. of the English Language, 4th ed.] We use this category for biomes; for ecoregions; and for vegetation. Omitted ADL sub-classes: Barren lands, Grasslands, Habitats, Snow Regions, Wetlands. NIMA GNS designator - no equivalent. Some correspondence to class Hypsographic Features.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#BiogeographicRegion">pext:BiogeographicRegion</a>
    /// </summary>
    let BiogeographicRegion = _prefixId.prefix "BiogeographicRegion"
    /// <summary>
    ///   <para>rdfs:label : Biological Database</para>
    ///   <para>rdfs:comment : A database containing information about biological entities.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#BiologicalDatabase">pext:BiologicalDatabase</a>
    /// </summary>
    let BiologicalDatabase = _prefixId.prefix "BiologicalDatabase"
    /// <summary>
    ///   <para>rdfs:label : Biological Substance</para>
    ///   <para>rdfs:comment : Any substance or element that has biological nature or origine.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#BiologicalSubstance">pext:BiologicalSubstance</a>
    /// </summary>
    let BiologicalSubstance = _prefixId.prefix "BiologicalSubstance"
    /// <summary>
    ///   <para>rdfs:label : Bird</para>
    ///   <para>rdfs:comment : Bird denotes feathered, winged, bipedal, endothermic (warm-blooded), egg-laying, vertebrate animals. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Bird">pext:Bird</a>
    /// </summary>
    let Bird = _prefixId.prefix "Bird"
    let Bishop = _prefixId.prefix "Bishop"
    /// <summary>
    ///   <para>rdfs:label : Board Meeting</para>
    ///   <para>rdfs:comment : A meeting whose main participants are members of a board.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#BoardMeeting">pext:BoardMeeting</a>
    /// </summary>
    let BoardMeeting = _prefixId.prefix "BoardMeeting"
    let BoardMember = _prefixId.prefix "BoardMember"
    /// <summary>
    ///   <para>rdfs:label : Body Part</para>
    ///   <para>rdfs:comment : Any part of the body of any living entity</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#BodyPart">pext:BodyPart</a>
    /// </summary>
    let BodyPart = _prefixId.prefix "BodyPart"
    /// <summary>
    ///   <para>rdfs:label : Bog</para>
    ///   <para>rdfs:comment : http://www.eionet.europa.eu/gemet/concept?ns=1&amp;cp=12161. NIMA GNS designator H.BOG.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Bog">pext:Bog</a>
    /// </summary>
    let Bog = _prefixId.prefix "Bog"
    /// <summary>
    ///   <para>rdfs:label : Bone</para>
    ///   <para>rdfs:comment : Any bone as a part of the body.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Bone">pext:Bone</a>
    /// </summary>
    let Bone = _prefixId.prefix "Bone"
    /// <summary>
    ///   <para>rdfs:label : Book</para>
    ///   <para>rdfs:comment : A relatively large published document. It may or may not have chapters. There could be series of books considered as volumes of a single one.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Book">pext:Book</a>
    /// </summary>
    let Book = _prefixId.prefix "Book"
    let Boxer = _prefixId.prefix "Boxer"
    /// <summary>
    ///   <para>rdfs:label : Boxing League</para>
    ///   <para>rdfs:comment : Any Boxing league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#BoxingLeague">pext:BoxingLeague</a>
    /// </summary>
    let BoxingLeague = _prefixId.prefix "BoxingLeague"
    /// <summary>
    ///   <para>rdfs:label : Brain</para>
    ///   <para>rdfs:comment : Any brain as a part of the body.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Brain">pext:Brain</a>
    /// </summary>
    let Brain = _prefixId.prefix "Brain"
    /// <summary>
    ///   <para>rdfs:label : Brand</para>
    ///   <para>rdfs:comment : The American Marketing Association defines a brand as a "Name, term, design, symbol, or any other feature that identifies one seller's good or service as distinct from those of other sellers." Wikipedia. Examples: Dodge and Milka</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Brand">pext:Brand</a>
    /// </summary>
    let Brand = _prefixId.prefix "Brand"
    /// <summary>
    ///   <para>rdfs:label : Breakwater</para>
    ///   <para>rdfs:comment : A structure erected to break the force of waves at the entrance to a harbor or port</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Breakwater">pext:Breakwater</a>
    /// </summary>
    let Breakwater = _prefixId.prefix "Breakwater"
    /// <summary>
    ///   <para>rdfs:label : Bridge</para>
    ///   <para>rdfs:comment : (ADL FT) Structures erected over a depression or obstacle to carry traffic. [USGS Circ 1048] We use this category for covered bridges; for drawbridges; for overpasses; for trestles; and for viaducts. NIMA GNS designator BDG, BDGQ.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Bridge">pext:Bridge</a>
    /// </summary>
    let Bridge = _prefixId.prefix "Bridge"
    let BritishRoyalty = _prefixId.prefix "BritishRoyalty"
    /// <summary>
    ///   <para>rdfs:label : Broadcast network</para>
    ///   <para>rdfs:comment : A broadcast network is an organization, such as a corporation or other voluntary association, that provides live television or recorded content, such as movies, newscasts, sports, Public affairs programming, and other television programs for broadcast over a group of radio stations or television stations. Wikipedia</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#BroadcastNetwork">pext:BroadcastNetwork</a>
    /// </summary>
    let BroadcastNetwork = _prefixId.prefix "BroadcastNetwork"
    /// <summary>
    ///   <para>rdfs:label : Broadcaster</para>
    ///   <para>rdfs:comment : A company that broadcasts audio or video content to a dispersed audience via any audio visual medium. Wikipedia</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Broadcaster">pext:Broadcaster</a>
    /// </summary>
    let Broadcaster = _prefixId.prefix "Broadcaster"
    /// <summary>
    ///   <para>rdfs:label : Building</para>
    ///   <para>rdfs:comment : (ADL FT) Permanent constructions that are roofed and usually walled. [USGS Circ 1048] We use this category for administrative facilities; for administrative facilities; for animal pounds; for animal shelters; for aquariums; for barns; for border posts; for cabins; for castles; for city halls; for civic centers; for civil buildings; for club houses; for coast guard stations; for commissaries; for community centers; for community houses; for conference facilities; for consulates; for convention centers; for customs houses; for customs posts; for depots; for embassy buildings; for exhibition buildings; for facilities; for facility centers; for fire stations; for firehouses; for forest stations; for government buildings; for guard stations; for halls; for headquarters; for hostels; for hotels; for houses; for inns; for inspection stations; for legation buildings; for lodges; for missions; for motels; for neighborhood centers; for offices; for park headquarters; for patrol posts; for pavilions; for planetariums; for plazas; for police posts; for public buildings; for ranger stations; for restaurants; for shelters; for shops; for stations; for structures; for student unions; for studios; for substations; for taverns; for town halls; for trading posts; for treatment plants; for United States Government establishments; for visitor centers; for walls; and for warehouses NIMA GNS designator BLDG.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Building">pext:Building</a>
    /// </summary>
    let Building = _prefixId.prefix "Building"
    let BullFighter = _prefixId.prefix "BullFighter"
    /// <summary>
    ///   <para>rdfs:label : Bush</para>
    ///   <para>rdfs:comment : A small clump of conspicuous bushes in an otherwise bare area</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#BushLand">pext:BushLand</a>
    /// </summary>
    let BushLand = _prefixId.prefix "BushLand"
    /// <summary>
    ///   <para>rdfs:label : Business Abstraction</para>
    ///   <para>rdfs:comment : An abstraction related to business.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#BusinessAbstraction">pext:BusinessAbstraction</a>
    /// </summary>
    let BusinessAbstraction = _prefixId.prefix "BusinessAbstraction"
    let CEO = _prefixId.prefix "CEO"
    /// <summary>
    ///   <para>rdfs:label : Calendar Month</para>
    ///   <para>rdfs:comment : A specific month of the year, such as: Jan., Feb., etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#CalendarMonth">pext:CalendarMonth</a>
    /// </summary>
    let CalendarMonth = _prefixId.prefix "CalendarMonth"
    /// <summary>
    ///   <para>rdfs:label : Calendar Year</para>
    ///   <para>rdfs:comment : A specific year, such as 2000, taken as a time interval</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#CalendarYear">pext:CalendarYear</a>
    /// </summary>
    let CalendarYear = _prefixId.prefix "CalendarYear"
    /// <summary>
    ///   <para>rdfs:label : Camp</para>
    ///   <para>rdfs:comment : (ADL FT) Designated areas on which primitive structure(s) are erected for temporary shelter or where recreational vehicles are temporarily parked. [USGS Circ 1048] We use this category for campgrounds; for camping sites; for logging camps; for oil camps; for refugee camps; for RV parks; and for trailer parks (recreational). NIMA GNS designators CMP, CMPL, CMPLA, CMPO, CMPQ, CMPRF.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Camp">pext:Camp</a>
    /// </summary>
    let Camp = _prefixId.prefix "Camp"
    /// <summary>
    ///   <para>rdfs:label : Canadian Football League</para>
    ///   <para>rdfs:comment : Any Canadian Football league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#CanadianFootballLeague">pext:CanadianFootballLeague</a>
    /// </summary>
    let CanadianFootballLeague = _prefixId.prefix "CanadianFootballLeague"
    let CanadianFootballPlayer = _prefixId.prefix "CanadianFootballPlayer"
    /// <summary>
    ///   <para>rdfs:label : Canadian Football Team</para>
    ///   <para>rdfs:comment : Any Canadian Football Team</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#CanadianFootballTeam">pext:CanadianFootballTeam</a>
    /// </summary>
    let CanadianFootballTeam = _prefixId.prefix "CanadianFootballTeam"
    /// <summary>
    ///   <para>rdfs:label : Canal</para>
    ///   <para>rdfs:comment : (ADL FT) Artificial waterways with no flow or a controlled flow used for navigation (canal), or for draining or irrigating land (ditch). We use this category for canal bends; for canalized streams; for ditch mouths; for ditches; for drainage canals; for drainage ditches; for drains (channels); for flumes (manmade); for irrigation canals; for irrigation ditches; for irrigation systems; for laterals; for navigation canals; and for underground irrigation canals. NIMA GNS designators CNL,CNLA, CNLB, CNLD, CNLI, CNLN, CNLQ, CNLSB, CNLX.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Canal">pext:Canal</a>
    /// </summary>
    let Canal = _prefixId.prefix "Canal"
    /// <summary>
    ///   <para>rdfs:label : Canyon</para>
    ///   <para>rdfs:comment : (ADL FT) Relatively narrow, deep depressions with steep sides, the bottom of which generally has a continuous slope ... We use this category for barrancas; for chasms; for flumes (natural); for gorges; for gulches; for quebradas; and for ravines. NIMA GNS designator CNSU, CNYN, CNYU, GRGE, RAVU, RVN.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Canyon">pext:Canyon</a>
    /// </summary>
    let Canyon = _prefixId.prefix "Canyon"
    /// <summary>
    ///   <para>rdfs:label : Cape</para>
    ///   <para>rdfs:comment : (ADL FT) Projection of land extending into a body of water that prominently marks a change in or interrupts the coastal trend of that water body. We use this category for headlands; for peninsulas; for points (physiographic); and for promontories. NIMA GNS designator CAPE, HDLD, PROM.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Cape">pext:Cape</a>
    /// </summary>
    let Cape = _prefixId.prefix "Cape"
    /// <summary>
    ///   <para>rdfs:label : Capital</para>
    ///   <para>rdfs:comment : (ADL FT) Towns or cities that are the official seats of government in a political entity, such as a state or nation. [American Heritage Dic. of the English Language, 4th ed.] We use this category for county seats; for national capitals; and for state capitals. NIMA GNS designators PPLC, PPLA</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Capital">pext:Capital</a>
    /// </summary>
    let Capital = _prefixId.prefix "Capital"
    /// <summary>
    ///   <para>rdfs:label : Car</para>
    ///   <para>rdfs:comment : Any automoabile car.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Car">pext:Car</a>
    /// </summary>
    let Car = _prefixId.prefix "Car"
    /// <summary>
    ///   <para>rdfs:label : Car Model</para>
    ///   <para>rdfs:comment : A concrete model of a car which determines the main features of any car of this model. For example, Ford-T or BMW Z3.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#CarModel">pext:CarModel</a>
    /// </summary>
    let CarModel = _prefixId.prefix "CarModel"
    let Cardinal = _prefixId.prefix "Cardinal"
    /// <summary>
    ///   <para>rdfs:label : Cave</para>
    ///   <para>rdfs:comment : (ADL FT) Natural underground passageways or chambers, or hollowed out cavities in the side of a cliff. ... We use this category for cave entrances; for caverns; for grottoes; for natural tunnels; and for underground lakes. NIMA GNS designator CAVE.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Cave">pext:Cave</a>
    /// </summary>
    let Cave = _prefixId.prefix "Cave"
    /// <summary>
    ///   <para>rdfs:label : Celebrity</para>
    ///   <para>rdfs:comment : The situation of holding a position in a society as celebrity.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Celebrity">pext:Celebrity</a>
    /// </summary>
    let Celebrity = _prefixId.prefix "Celebrity"
    /// <summary>
    ///   <para>rdfs:label : Celebrity</para>
    ///   <para>rdfs:comment : The social function of celebrity, a status of notoriety in the society.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#CelebrityTitle">pext:CelebrityTitle</a>
    /// </summary>
    let CelebrityTitle = _prefixId.prefix "CelebrityTitle"
    let Chancellor = _prefixId.prefix "Chancellor"
    /// <summary>
    ///   <para>rdfs:label : Channel</para>
    ///   <para>rdfs:comment : (ADL FT) (a) Relatively narrow seas or stretches of water between two close landmasses and connecting two larger bodies of water; (b) Deeper parts of a moving body of water (as bays, estuaries, or straits) through which the main current flows or which affords the best passage through an area otherwise too shallow to navigate. ... We use this category for chutes (hydrographic); for cutoffs (hydrographic); for inlets; for lake channels; for marine channels; for narrows (hydrographic); for navigation channels; for reaches (hydrographic); for sounds (bodies of water); and for straits. NIMA GNS designators CHN, CHNL, CHNM, CHNN, STRT.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Channel">pext:Channel</a>
    /// </summary>
    let Channel = _prefixId.prefix "Channel"
    /// <summary>
    ///   <para>rdfs:label : Charity</para>
    ///   <para>rdfs:comment : Any Charity, an organization involved in the practice of benevolent giving and caring. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Charity">pext:Charity</a>
    /// </summary>
    let Charity = _prefixId.prefix "Charity"
    /// <summary>
    ///   <para>rdfs:label : Chemical Compound</para>
    ///   <para>rdfs:comment : A specific chemical compound, such as H2O or Zarin.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ChemicalCompound">pext:ChemicalCompound</a>
    /// </summary>
    let ChemicalCompound = _prefixId.prefix "ChemicalCompound"
    /// <summary>
    ///   <para>rdfs:label : Chemical element</para>
    ///   <para>rdfs:comment : A chemical element is a pure chemical substance consisting of one type of atom distinguished by its atomic number, which is the number of protons in its nucleus. Wikipedia</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ChemicalElement">pext:ChemicalElement</a>
    /// </summary>
    let ChemicalElement = _prefixId.prefix "ChemicalElement"
    /// <summary>
    ///   <para>rdfs:label : Chemical substance</para>
    ///   <para>rdfs:comment : Any substance or element that has chemical nature.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ChemicalSubstance">pext:ChemicalSubstance</a>
    /// </summary>
    let ChemicalSubstance = _prefixId.prefix "ChemicalSubstance"
    let ChessPlayer = _prefixId.prefix "ChessPlayer"
    let ChristianPatriarch = _prefixId.prefix "ChristianPatriarch"
    /// <summary>
    ///   <para>rdfs:label : City</para>
    ///   <para>rdfs:comment : (ADL FT) For smaller, less formally established communities, use 'populated places'. For independent cities, use 'countries, 2nd order divisions. Incorporated populated places. [Adapted from USGS Circ 1048] We use this category for municipalities; for towns; and for urban areas. NIMA GNS designator PPL.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#City">pext:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    /// <summary>
    ///   <para>rdfs:label : Cleric</para>
    ///   <para>rdfs:comment : The situation of holding a position in society as cleric.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Cleric">pext:Cleric</a>
    /// </summary>
    let Cleric = _prefixId.prefix "Cleric"
    /// <summary>
    ///   <para>rdfs:label : Cleric</para>
    ///   <para>rdfs:comment : The social function of a cleric, involving the church.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ClericTitle">pext:ClericTitle</a>
    /// </summary>
    let ClericTitle = _prefixId.prefix "ClericTitle"
    /// <summary>
    ///   <para>rdfs:label : Coast</para>
    ///   <para>rdfs:comment : (ADL FT: Coastal Zones) Strips of land (of indefinite width) that extend from the low-tide line inland to the first major change in landform features. [Adapted from Glossary of Geology, 4th ed.] We use this category for coastal plains; for coasts; for intertidal zones; for offshore areas; for shorelines; and for shores. NIMA GNS designators CST, SHOR.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Coast">pext:Coast</a>
    /// </summary>
    let Coast = _prefixId.prefix "Coast"
    /// <summary>
    ///   <para>rdfs:label : Coconut grove</para>
    ///   <para>rdfs:comment : A planting of coconut trees</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#CoconutGrove">pext:CoconutGrove</a>
    /// </summary>
    let CoconutGrove = _prefixId.prefix "CoconutGrove"
    /// <summary>
    ///   <para>rdfs:label : College</para>
    ///   <para>rdfs:comment : An education organization between the school and the university. In some cases it is a part of university.rdfs:comment : College</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#College">pext:College</a>
    /// </summary>
    let College = _prefixId.prefix "College"
    /// <summary>
    ///   <para>rdfs:label : Colour</para>
    ///   <para>rdfs:comment : Any colour, a visual perceptual property, e.g. red, blue, yellow, etc. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Colour">pext:Colour</a>
    /// </summary>
    let Colour = _prefixId.prefix "Colour"
    let Comedian = _prefixId.prefix "Comedian"
    /// <summary>
    ///   <para>rdfs:label : Comics character</para>
    ///   <para>rdfs:comment : A character from a comics.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ComicsCharacter">pext:ComicsCharacter</a>
    /// </summary>
    let ComicsCharacter = _prefixId.prefix "ComicsCharacter"
    let ComicsCreator = _prefixId.prefix "ComicsCreator"
    let Commander = _prefixId.prefix "Commander"
    /// <summary>
    ///   <para>rdfs:label : Commercial Organization</para>
    ///   <para>rdfs:comment : Organization that buys or sells goods or services for a profit. It may also be a Business or it may merely be a sub-organization of a Business entity.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#CommercialOrganization">pext:CommercialOrganization</a>
    /// </summary>
    let CommercialOrganization = _prefixId.prefix "CommercialOrganization"
    /// <summary>
    ///   <para>rdfs:label : Company</para>
    ///   <para>rdfs:comment : A private, legal, corporate entity with the legal rights to own property, manage itself, and sue or be sued. It is established by a charter or registration granted by the government.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Company">pext:Company</a>
    /// </summary>
    let Company = _prefixId.prefix "Company"
    /// <summary>
    ///   <para>rdfs:label : Concert</para>
    ///   <para>rdfs:comment : An art performance consisting of playing music.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Concert">pext:Concert</a>
    /// </summary>
    let Concert = _prefixId.prefix "Concert"
    /// <summary>
    ///   <para>rdfs:label : Confluence</para>
    ///   <para>rdfs:comment : in geography, describes the meeting of two or more bodies of water. The opposite of a watershed. NIMA GNS designator H.CNFL.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Confluence">pext:Confluence</a>
    /// </summary>
    let Confluence = _prefixId.prefix "Confluence"
    let Congressman = _prefixId.prefix "Congressman"
    /// <summary>
    ///   <para>rdfs:label : Continent</para>
    ///   <para>rdfs:comment : (ADL FT) Earth's major land masses, including both dry land and continental shelves. NIMA GNS designator - no equivalent.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Continent">pext:Continent</a>
    /// </summary>
    let Continent = _prefixId.prefix "Continent"
    /// <summary>
    ///   <para>rdfs:label : Shelf</para>
    ///   <para>rdfs:comment : A zone adjacent to a continent (or around an island) that extends from the low water line to a depth at which there is usually a marked increase of slope towards oceanic depths</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ContinentalShelf">pext:ContinentalShelf</a>
    /// </summary>
    let ContinentalShelf = _prefixId.prefix "ContinentalShelf"
    /// <summary>
    ///   <para>rdfs:label : Contract</para>
    ///   <para>rdfs:comment : Any sort of contract or treaty, as well, as other documents signed or otherwise accepted by more than one agent.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Contract">pext:Contract</a>
    /// </summary>
    let Contract = _prefixId.prefix "Contract"
    /// <summary>
    ///   <para>rdfs:label : Country</para>
    ///   <para>rdfs:comment : (ADL FTT) Territory occupied by a large group of people organized under a single, usually independent government, and recognized internationally as a country. [Adapted from American Heritage Dic. of the English Language, 4th ed.] We use this category for nations; and for republics. NIMA GNS designators PCL, PCLD, PCLF, PCLI, PCLS. FIPS 10-4 is applicable, difining: Basic geopolitical entities assigned country codes include the following categories: (a) independent states; (b) dependent areas; (c) areas of quasi-independence, non-contiguous territories, possessions without populations, areas with special sovereignty associations, areas without sovereignty; (d) political regimes not recognized by the United States; and (e) outlying areas of the United States. The list of basic entities provides complete coverage of the land areas of the world without overlap or duplication.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Country">pext:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : Country Capital</para>
    ///   <para>rdfs:comment : A capital of a Country. NIMA GNS designator PPLC.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#CountryCapital">pext:CountryCapital</a>
    /// </summary>
    let CountryCapital = _prefixId.prefix "CountryCapital"
    /// <summary>
    ///   <para>rdfs:label : County</para>
    ///   <para>rdfs:comment : (ADL FT: Countries, 2nd order divisions) Second-order divisions of a nation such as parishes, boroughs, counties, municipios, or judicial divisions, and independent cities such as those in Maryland, Missouri, Nevada, and Virginia. [Adapted from USGS Circ 1048] We use this category for boroughs; for counties; for judicial divisions; for municipios; for parishes; and for second-order administrative divisions. NIMA GNS designator ADM2.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#County">pext:County</a>
    /// </summary>
    let County = _prefixId.prefix "County"
    /// <summary>
    ///   <para>rdfs:label : Cove</para>
    ///   <para>rdfs:comment : a small type of bay or coastal inlet. http://www.eionet.europa.eu/gemet/concept/10142 NIMA GNS designator H.COVE.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Cove">pext:Cove</a>
    /// </summary>
    let Cove = _prefixId.prefix "Cove"
    /// <summary>
    ///   <para>rdfs:label : Crater</para>
    ///   <para>rdfs:comment : (ADL FT) Circular-shaped depressions at the summit of a volcanic core or on the surface of the land caused by the impact of a meteorite; man-made depressions caused by an explosion. ... We use this category for calderas. NIMA GNS designator CRTR, CLDA.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Crater">pext:Crater</a>
    /// </summary>
    let Crater = _prefixId.prefix "Crater"
    /// <summary>
    ///   <para>rdfs:label : Creek</para>
    ///   <para>rdfs:comment : (ADL FT: Guts) Relatively small coastal waterways connecting larger bodies of water or other waterways. NIMA GNS designator CRKT, INLT.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Creek">pext:Creek</a>
    /// </summary>
    let Creek = _prefixId.prefix "Creek"
    /// <summary>
    ///   <para>rdfs:label : Cricket League</para>
    ///   <para>rdfs:comment : Any Cricket league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#CricketLeague">pext:CricketLeague</a>
    /// </summary>
    let CricketLeague = _prefixId.prefix "CricketLeague"
    let Cricketer = _prefixId.prefix "Cricketer"
    /// <summary>
    ///   <para>rdfs:label : Crustacean</para>
    ///   <para>rdfs:comment : Crustaceans denotes a group of arthropods animals, which includes crabs, lobsters, crayfish, shrimp, krill and barnacles. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Crustacean">pext:Crustacean</a>
    /// </summary>
    let Crustacean = _prefixId.prefix "Crustacean"
    /// <summary>
    ///   <para>rdfs:label : Cultivated area</para>
    ///   <para>rdfs:comment : An area under cultivation</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#CultivatedArea">pext:CultivatedArea</a>
    /// </summary>
    let CultivatedArea = _prefixId.prefix "CultivatedArea"
    /// <summary>
    ///   <para>rdfs:label : Curling League</para>
    ///   <para>rdfs:comment : Any Curling league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#CurlingLeague">pext:CurlingLeague</a>
    /// </summary>
    let CurlingLeague = _prefixId.prefix "CurlingLeague"
    /// <summary>
    ///   <para>rdfs:label : Currency</para>
    ///   <para>rdfs:comment : Specific currency, usually national</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Currency">pext:Currency</a>
    /// </summary>
    let Currency = _prefixId.prefix "Currency"
    /// <summary>
    ///   <para>rdfs:label : Data Schema</para>
    ///   <para>rdfs:comment : A particular notation for representation, standardization, and/or structuring of infomation. It can range from db schema, through ontology, to any sort of taxonomies, nomenclatures and subject hierarchies. Examples are Dublin Core, KIMO, SIC, XML, RDFS</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#DataSchema">pext:DataSchema</a>
    /// </summary>
    let DataSchema = _prefixId.prefix "DataSchema"
    /// <summary>
    ///   <para>rdfs:label : Database</para>
    ///   <para>rdfs:comment : A dataset loaded in a system supporting search, update and other operations over the information in the dataset.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Database">pext:Database</a>
    /// </summary>
    let Database = _prefixId.prefix "Database"
    /// <summary>
    ///   <para>rdfs:label : Dataset</para>
    ///   <para>rdfs:comment : A dataset is information encoded in a defined structure (for example, lists, tables, and databases), intended to be useful for direct machine processing (DCMI Type.) Somehow structured and interrelated body of information, data, or knowledge. This includes databases, knowledge bases, catalogues, registries, specific lists, etc. All tangible aspects (like media or host) are irrelevant for this class - it only considers the abstract information. What can be considered as a single document is outside the scope of this class, although it can be comprehensive in terms of size and structure.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Dataset">pext:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:label : Date</para>
    ///   <para>rdfs:comment : A specific date, as 12th of April, 1956, as the time period (the 24 hours of the day)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Date">pext:Date</a>
    /// </summary>
    let Date = _prefixId.prefix "Date"
    /// <summary>
    ///   <para>rdfs:label : Day of Month</para>
    ///   <para>rdfs:comment : A specific day of a given month. The days are numbered from 1 to 28, 29, 30, or 31 depending on the month and the year.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#DayOfMonth">pext:DayOfMonth</a>
    /// </summary>
    let DayOfMonth = _prefixId.prefix "DayOfMonth"
    /// <summary>
    ///   <para>rdfs:label : Day of Week</para>
    ///   <para>rdfs:comment : A specific day of the week. The week has seven days: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#DayOfWeek">pext:DayOfWeek</a>
    /// </summary>
    let DayOfWeek = _prefixId.prefix "DayOfWeek"
    /// <summary>
    ///   <para>rdfs:label : Daytime</para>
    ///   <para>rdfs:comment : Specific time (point) during the day, when the day is not specified. Like in "the supermarket is closing 20:30 p.m."</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#DayTime">pext:DayTime</a>
    /// </summary>
    let DayTime = _prefixId.prefix "DayTime"
    /// <summary>
    ///   <para>rdfs:label : Death</para>
    ///   <para>rdfs:comment : The event to die.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Death">pext:Death</a>
    /// </summary>
    let Death = _prefixId.prefix "Death"
    /// <summary>
    ///   <para>rdfs:label : Deltardfs:label : Delta of a River</para>
    ///   <para>rdfs:comment : (ADL FT) Flat plains formed by alluvial deposits at the mouth of a stream. NIMA GNS designator DLTA.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Delta">pext:Delta</a>
    /// </summary>
    let Delta = _prefixId.prefix "Delta"
    let Deputy = _prefixId.prefix "Deputy"
    /// <summary>
    ///   <para>rdfs:label : Desert</para>
    ///   <para>rdfs:comment : (ADL FT) Regions rendered barren or partially barren by environmental extremes, especially by low rainfall. [USGS Circ 1048] We use this category for arid regions; for bajadas; for rock deserts; for sandy areas; for sandy deserts; and for stony deserts. NIMA GNS designators DSRT, ERG, HMDA, REG.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Desert">pext:Desert</a>
    /// </summary>
    let Desert = _prefixId.prefix "Desert"
    /// <summary>
    ///   <para>rdfs:label : Device^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Device">pext:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    /// <summary>
    ///   <para>rdfs:label : Disease</para>
    ///   <para>rdfs:comment : A specific sort of desease, such as AIDS, SARS, Parcinson, etc. The instances of those class can often by considered as terms instead of entities, but in all cases, those are the general phenomena, not the particular situations when somebody is suffering the disease.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Disease">pext:Disease</a>
    /// </summary>
    let Disease = _prefixId.prefix "Disease"
    /// <summary>
    ///   <para>rdfs:label : Ditch</para>
    ///   <para>rdfs:comment : A ditch is usually defined as a small to moderate depression created to channel water.(Wikipedia). http://www.eionet.europa.eu/gemet/concept/2276. NIMA GNS designators H.DTCH, H.DTCHD, H.DTCHI, H.DTCHM.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Ditch">pext:Ditch</a>
    /// </summary>
    let Ditch = _prefixId.prefix "Ditch"
    /// <summary>
    ///   <para>rdfs:label : Division</para>
    ///   <para>rdfs:comment : Branch, division, department, laboratory, etc. within an organisation. Usually, not a legal agent and not independent.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Division">pext:Division</a>
    /// </summary>
    let Division = _prefixId.prefix "Division"
    /// <summary>
    ///   <para>rdfs:label : Drainage Basin</para>
    ///   <para>rdfs:comment : An area drained by a stream. NIMA GNS designator L.BSND.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#DrainageBasin">pext:DrainageBasin</a>
    /// </summary>
    let DrainageBasin = _prefixId.prefix "DrainageBasin"
    /// <summary>
    ///   <para>rdfs:label : Drug</para>
    ///   <para>rdfs:comment : A chemical substance used to improve the health condition of a person, animal, etc. For example, Aspirin, Viagra, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Drug">pext:Drug</a>
    /// </summary>
    let Drug = _prefixId.prefix "Drug"
    /// <summary>
    ///   <para>rdfs:label : E-mail</para>
    ///   <para>rdfs:comment : An identifier that determines a electronic mail box.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#EMail">pext:EMail</a>
    /// </summary>
    let EMail = _prefixId.prefix "EMail"
    /// <summary>
    ///   <para>rdfs:label : Educational Organization</para>
    ///   <para>rdfs:comment : An organization devoted to teaching activities.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#EducationalOrganization">pext:EducationalOrganization</a>
    /// </summary>
    let EducationalOrganization = _prefixId.prefix "EducationalOrganization"
    /// <summary>
    ///   <para>rdfs:label : Election</para>
    ///   <para>rdfs:comment : Generic concept of Election which is normally held at regular periods of time, president elections of the US, municipal elections, etc..</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Election">pext:Election</a>
    /// </summary>
    let Election = _prefixId.prefix "Election"
    /// <summary>
    ///   <para>rdfs:label : Election</para>
    ///   <para>rdfs:comment : Election happening at a particular date.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ElectionOccurrence">pext:ElectionOccurrence</a>
    /// </summary>
    let ElectionOccurrence = _prefixId.prefix "ElectionOccurrence"
    /// <summary>
    ///   <para>rdfs:label : Map</para>
    ///   <para>rdfs:comment : A webpage of a map</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ElectronicMap">pext:ElectronicMap</a>
    /// </summary>
    let ElectronicMap = _prefixId.prefix "ElectronicMap"
    /// <summary>
    ///   <para>rdfs:label : Embryo Body Part</para>
    ///   <para>rdfs:comment : Embryology is a science that studies the development of the embryo. This class denotes different composing substances/elements of the embryo and related body parts, and hence is referred to as a body part. It is inspired form DBPedia Embryology/AnatomicalStructure, which has instances as Blastocyst, Amniotic cavity, Vitelline membrane, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#EmbryoBodyPart">pext:EmbryoBodyPart</a>
    /// </summary>
    let EmbryoBodyPart = _prefixId.prefix "EmbryoBodyPart"
    /// <summary>
    ///   <para>rdfs:label : Entertainment Company</para>
    ///   <para>rdfs:comment : Any Entertainment Company, a company involved in the entertainment business, e.g. Warner Brothers, MTV, Lido, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#EntertainmentCompany">pext:EntertainmentCompany</a>
    /// </summary>
    let EntertainmentCompany = _prefixId.prefix "EntertainmentCompany"
    /// <summary>
    ///   <para>rdfs:label : Estuary</para>
    ///   <para>rdfs:comment : A partly enclosed coastal body of water with one or more rivers or streams flowing into it, and with a free connection to the open sea. NIMA GNS designator H.ESTY.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Estuary">pext:Estuary</a>
    /// </summary>
    let Estuary = _prefixId.prefix "Estuary"
    /// <summary>
    ///   <para>rdfs:label : Ethnic Group</para>
    ///   <para>rdfs:comment : Any ethnic group. A group of people whose members identify with each other, through a common heritage, often consisting of a common language, a common culture (often including a shared religion) and an ideology that stresses common ancestry or endogamy. (Wikipedia).</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#EthnicGroup">pext:EthnicGroup</a>
    /// </summary>
    let EthnicGroup = _prefixId.prefix "EthnicGroup"
    /// <summary>
    ///   <para>rdfs:label : Former Inlet</para>
    ///   <para>rdfs:comment : An inlet which has been filled in, or blocked by deposits</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#FInlet">pext:FInlet</a>
    /// </summary>
    let FInlet = _prefixId.prefix "FInlet"
    /// <summary>
    ///   <para>rdfs:label : Facility</para>
    ///   <para>rdfs:comment : (ADL FT: Manmade Features, no def) Any regions and locations determined artificially, as a result of human activity. Many of the ADL sub-classes are omitted. NIMA GNS - no direct equivalent, although many sub-types are defined as classes (S, R) and designators.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Facility">pext:Facility</a>
    /// </summary>
    let Facility = _prefixId.prefix "Facility"
    let FashionModel = _prefixId.prefix "FashionModel"
    /// <summary>
    ///   <para>rdfs:label : Fax Number</para>
    ///   <para>rdfs:comment : A phone number connected to a fax machine.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#FaxNumber">pext:FaxNumber</a>
    /// </summary>
    let FaxNumber = _prefixId.prefix "FaxNumber"
    /// <summary>
    ///   <para>rdfs:label : Festival</para>
    ///   <para>rdfs:comment : Any widely recognized festival or holiday, such as, Christmas or St. Valentine's Day.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Festival">pext:Festival</a>
    /// </summary>
    let Festival = _prefixId.prefix "Festival"
    /// <summary>
    ///   <para>rdfs:label : Festival Held at a Particular Time</para>
    ///   <para>rdfs:comment : An occurrence of a Festival or holiday, Sofia Film Festival 2011, Christmas of 2010 or St. Valentine's Day of 2011.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#FestivalOccurrence">pext:FestivalOccurrence</a>
    /// </summary>
    let FestivalOccurrence = _prefixId.prefix "FestivalOccurrence"
    /// <summary>
    ///   <para>rdfs:label : Fictional Character</para>
    ///   <para>rdfs:comment : The characters in fictional artwork like movies, books, etc</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#FictionalCharacter">pext:FictionalCharacter</a>
    /// </summary>
    let FictionalCharacter = _prefixId.prefix "FictionalCharacter"
    /// <summary>
    ///   <para>rdfs:label : Field Hockey League</para>
    ///   <para>rdfs:comment : Any Field Hockey league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#FieldHockeyLeague">pext:FieldHockeyLeague</a>
    /// </summary>
    let FieldHockeyLeague = _prefixId.prefix "FieldHockeyLeague"
    let FigureSkater = _prefixId.prefix "FigureSkater"
    /// <summary>
    ///   <para>rdfs:label : Film Festival</para>
    ///   <para>rdfs:comment : Any festival involving showing a film.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#FilmFestival">pext:FilmFestival</a>
    /// </summary>
    let FilmFestival = _prefixId.prefix "FilmFestival"
    /// <summary>
    ///   <para>rdfs:label : Fish</para>
    ///   <para>rdfs:comment : A fish is any gill-bearing aquatic vertebrate (or craniate) animal that lacks limbs with digits. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Fish">pext:Fish</a>
    /// </summary>
    let Fish = _prefixId.prefix "Fish"
    /// <summary>
    ///   <para>rdfs:label : Fishing Area</para>
    ///   <para>rdfs:comment : A bank or area where fishermen go to catch fish. NIMA GNS designator H.FISH.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#FishingArea">pext:FishingArea</a>
    /// </summary>
    let FishingArea = _prefixId.prefix "FishingArea"
    /// <summary>
    ///   <para>rdfs:label : Fjord</para>
    ///   <para>rdfs:comment : (ADL FT) Long narrow glacially-eroded inlets of the sea, U-shaped and steep-walled, generally several hundred meters deep, between high rocky cliffs or slopes along a mountainous coast. ... We use this category for fiords; and for lochs. NIMA GNS designator FJD, FJDS.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Fjord">pext:Fjord</a>
    /// </summary>
    let Fjord = _prefixId.prefix "Fjord"
    /// <summary>
    ///   <para>rdfs:label : Flowering plant</para>
    ///   <para>rdfs:comment : Any flowering plant</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#FloweringPlant">pext:FloweringPlant</a>
    /// </summary>
    let FloweringPlant = _prefixId.prefix "FloweringPlant"
    /// <summary>
    ///   <para>rdfs:label : Food</para>
    ///   <para>rdfs:comment : Food is any eatable or drinkable substance that is normally consumed by humans. DBPedia</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Food">pext:Food</a>
    /// </summary>
    let Food = _prefixId.prefix "Food"
    /// <summary>
    ///   <para>rdfs:label : Football match</para>
    ///   <para>rdfs:comment : Any instance of a soccer match.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#FootballMatch">pext:FootballMatch</a>
    /// </summary>
    let FootballMatch = _prefixId.prefix "FootballMatch"
    /// <summary>
    ///   <para>rdfs:label : Forest</para>
    ///   <para>rdfs:comment : (ADL FT) Dense growths of trees, plants, and underbrush covering a large area. [American Heritage Dic. of the English Language, 4th ed.] We use this category for forest reserves; and for national forests. Omitted ADL sub-classes: Petrified forests, Rain forests, Woods (the sub-classes collapsed here). NIMA GNS designator FRST, FRSTF, GDVC, GRVO, GRVP, GRVPN, TREE.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Forest">pext:Forest</a>
    /// </summary>
    let Forest = _prefixId.prefix "Forest"
    /// <summary>
    ///   <para>rdfs:label : Clearing</para>
    ///   <para>rdfs:comment : An area in a forest with trees removed. NIMA GNS designator L.CLG.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ForestClearing">pext:ForestClearing</a>
    /// </summary>
    let ForestClearing = _prefixId.prefix "ForestClearing"
    let FormulaOneRacer = _prefixId.prefix "FormulaOneRacer"
    /// <summary>
    ///   <para>rdfs:label : Fungus</para>
    ///   <para>rdfs:comment : Fungus is a member of a large group of eukaryotic organisms that includes microorganisms such as yeasts and molds (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Fungus">pext:Fungus</a>
    /// </summary>
    let Fungus = _prefixId.prefix "Fungus"
    let GaelicGamesPlayer = _prefixId.prefix "GaelicGamesPlayer"
    /// <summary>
    ///   <para>rdfs:label : Galaxy</para>
    ///   <para>rdfs:comment : A galaxy is a massive, gravitationally bound system that consists of stars and stellar remnants, an interstellar medium of gas and dust, and an important but poorly understood component tentatively dubbed dark matter. Wikipedia</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Galaxy">pext:Galaxy</a>
    /// </summary>
    let Galaxy = _prefixId.prefix "Galaxy"
    /// <summary>
    ///   <para>rdfs:label : Game</para>
    ///   <para>rdfs:comment : Game. Activity involving participants usually divided in teams, which obeys particualr rules, and has often a winner.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Game">pext:Game</a>
    /// </summary>
    let Game = _prefixId.prefix "Game"
    /// <summary>
    ///   <para>rdfs:label : Gap</para>
    ///   <para>rdfs:comment : (ADL FT) Ravines or gorges cut deeply through mountain ridges, or between hills or mountains. We use this category for cols; for defiles; for passes; for saddles (physiographic); and for sills (physiographic). NIMA GNS designator GAP, GAPU, GAPF, PASS, SILL, SILU.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Gap">pext:Gap</a>
    /// </summary>
    let Gap = _prefixId.prefix "Gap"
    /// <summary>
    ///   <para>rdfs:label : Gene</para>
    ///   <para>rdfs:comment : A gene is a molecular unit of heredity of a living organism. Wikipedia</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Gene">pext:Gene</a>
    /// </summary>
    let Gene = _prefixId.prefix "Gene"
    /// <summary>
    ///   <para>rdfs:label : Genre</para>
    ///   <para>rdfs:comment : Any Genre. Denotes any category of literature as well as various other forms of art or culture, e.g., music, based on some loose set of stylistic criteria. Genres are formed by conventions that change over time as new genres are invented and the use of old ones are discontinued. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Genre">pext:Genre</a>
    /// </summary>
    let Genre = _prefixId.prefix "Genre"
    /// <summary>
    ///   <para>rdfs:label : Geographic Region</para>
    ///   <para>rdfs:comment : Any Geographic Region with lattitude and longitude coordinates</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#GeographicLocation">pext:GeographicLocation</a>
    /// </summary>
    let GeographicLocation = _prefixId.prefix "GeographicLocation"
    /// <summary>
    ///   <para>rdfs:label : Geopolitical Organisation</para>
    ///   <para>rdfs:comment : Any geopolitical organization, an organization based on geo-political principles.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#GeopoliticalOrganization">pext:GeopoliticalOrganization</a>
    /// </summary>
    let GeopoliticalOrganization = _prefixId.prefix "GeopoliticalOrganization"
    /// <summary>
    ///   <para>rdfs:label : Geyser</para>
    ///   <para>rdfs:comment : A spring characterized by intermittent discharge of water ejected turbulently and accompanied by a vapour phase (steam). NIMA GNS designator H.GYSR.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Geyser">pext:Geyser</a>
    /// </summary>
    let Geyser = _prefixId.prefix "Geyser"
    /// <summary>
    ///   <para>rdfs:label : Glacier</para>
    ///   <para>rdfs:comment : A mass of ice, usually at high latitudes or high elevations, with sufficient thickness to flow away from the source area in lobes, tongues, or masses</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Glacier">pext:Glacier</a>
    /// </summary>
    let Glacier = _prefixId.prefix "Glacier"
    /// <summary>
    ///   <para>rdfs:label : Global Region</para>
    ///   <para>rdfs:comment : Things like Southeastern Europe, Middle East, Oceania are global regions</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#GlobalRegion">pext:GlobalRegion</a>
    /// </summary>
    let GlobalRegion = _prefixId.prefix "GlobalRegion"
    /// <summary>
    ///   <para>rdfs:label : Golf League</para>
    ///   <para>rdfs:comment : Any Golf league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#GolfLeague">pext:GolfLeague</a>
    /// </summary>
    let GolfLeague = _prefixId.prefix "GolfLeague"
    let GolfPlayer = _prefixId.prefix "GolfPlayer"
    /// <summary>
    ///   <para>rdfs:label : Government</para>
    ///   <para>rdfs:comment : The government of a country.rdfs:comment : The governmental cabinet</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Government">pext:Government</a>
    /// </summary>
    let Government = _prefixId.prefix "Government"
    /// <summary>
    ///   <para>rdfs:label : Government</para>
    ///   <para>rdfs:comment : A government agency is a permanent or semi-permanent organization in the machinery of government that is responsible for the oversight and administration of specific functions, such as an intelligence agency. DBPediardfs:comment : The governmental cabinet</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#GovernmentAgency">pext:GovernmentAgency</a>
    /// </summary>
    let GovernmentAgency = _prefixId.prefix "GovernmentAgency"
    /// <summary>
    ///   <para>rdfs:label : Government Building</para>
    ///   <para>rdfs:comment : A government building, a building which serves the government, or where government officials work.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#GovernmentBuilding">pext:GovernmentBuilding</a>
    /// </summary>
    let GovernmentBuilding = _prefixId.prefix "GovernmentBuilding"
    /// <summary>
    ///   <para>rdfs:label : Government Organization</para>
    ///   <para>rdfs:comment : The government of a country, i.e. the authorized country administration, without account for a specific government elected and being in power for some period. This notion of government groups all the administration, including any sort of ministries, agencies, commissions, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#GovernmentOrganization">pext:GovernmentOrganization</a>
    /// </summary>
    let GovernmentOrganization = _prefixId.prefix "GovernmentOrganization"
    let Governor = _prefixId.prefix "Governor"
    /// <summary>
    ///   <para>rdfs:label : Grape</para>
    ///   <para>rdfs:comment : Any grape</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Grape">pext:Grape</a>
    /// </summary>
    let Grape = _prefixId.prefix "Grape"
    /// <summary>
    ///   <para>rdfs:label : Grassland</para>
    ///   <para>rdfs:comment : An area dominated by grass vegetation</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Grassland">pext:Grassland</a>
    /// </summary>
    let Grassland = _prefixId.prefix "Grassland"
    let GridironFootballPlayer = _prefixId.prefix "GridironFootballPlayer"
    /// <summary>
    ///   <para>rdfs:label : Gulf</para>
    ///   <para>rdfs:comment : (ADL FT) Largest of various forms of inlets of the sea; usually larger, more enclosed, and more deeply indented than bays. NIMA GNS designator GULF.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Gulf">pext:Gulf</a>
    /// </summary>
    let Gulf = _prefixId.prefix "Gulf"
    /// <summary>
    ///   <para>rdfs:label : Guyotrdfs:label : Tablemount</para>
    ///   <para>rdfs:comment : A seamount having a comparatively smooth, flat top</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Guyot">pext:Guyot</a>
    /// </summary>
    let Guyot = _prefixId.prefix "Guyot"
    /// <summary>
    ///   <para>rdfs:label : Handball League</para>
    ///   <para>rdfs:comment : Any Handball league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#HandballLeague">pext:HandballLeague</a>
    /// </summary>
    let HandballLeague = _prefixId.prefix "HandballLeague"
    /// <summary>
    ///   <para>rdfs:label : Harbor</para>
    ///   <para>rdfs:comment : (ADL FT) Sheltered areas of water where ships or other watercraft can anchor or dock. We use this category for anchorages; for anclajes; for boat yards; for boatyards; for dock yards; for docking basins; for dockyards; for dry docks; for harbors; for marine terminals; for moorings; for ports; for roadsteads (anchorages); and for turning basins. The following sub-classes included (i.e. not-distinguishable): Marinas, Piers. NIMA GNS designators HBR, HBRX, MAR, BTYD, PIER, DCK, DCKB, DCKY, PRT, AIRS.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Harbor">pext:Harbor</a>
    /// </summary>
    let Harbor = _prefixId.prefix "Harbor"
    /// <summary>
    ///   <para>rdfs:label : Heath</para>
    ///   <para>rdfs:comment : An upland moor or sandy area dominated by low shrubby vegetation including heather</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Heath">pext:Heath</a>
    /// </summary>
    let Heath = _prefixId.prefix "Heath"
    /// <summary>
    ///   <para>rdfs:label : Historic Building</para>
    ///   <para>rdfs:comment : Any Historic Building, an old building with historic value.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#HistoricBuilding">pext:HistoricBuilding</a>
    /// </summary>
    let HistoricBuilding = _prefixId.prefix "HistoricBuilding"
    /// <summary>
    ///   <para>rdfs:label : Historic Place</para>
    ///   <para>rdfs:comment : Any Historic Place, an old place with historic value.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#HistoricPlace">pext:HistoricPlace</a>
    /// </summary>
    let HistoricPlace = _prefixId.prefix "HistoricPlace"
    /// <summary>
    ///   <para>rdfs:label : Hockey Team</para>
    ///   <para>rdfs:comment : Any Hockey team</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#HockeyTeam">pext:HockeyTeam</a>
    /// </summary>
    let HockeyTeam = _prefixId.prefix "HockeyTeam"
    /// <summary>
    ///   <para>rdfs:label : Holiday</para>
    ///   <para>rdfs:comment : A Holiday is a day designated as having special significance for which individuals, a government, or a religious group have deemed that observance is warranted. Wikipedia</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Holiday">pext:Holiday</a>
    /// </summary>
    let Holiday = _prefixId.prefix "Holiday"
    /// <summary>
    ///   <para>rdfs:label : Home Page</para>
    ///   <para>rdfs:comment : The web page address of a page that is considered main for a web cite.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#HomePage">pext:HomePage</a>
    /// </summary>
    let HomePage = _prefixId.prefix "HomePage"
    /// <summary>
    ///   <para>rdfs:label : Hospital</para>
    ///   <para>rdfs:comment : Any Hospital, a building which is a hospital.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Hospital">pext:Hospital</a>
    /// </summary>
    let Hospital = _prefixId.prefix "Hospital"
    /// <summary>
    ///   <para>rdfs:label : Hotel</para>
    ///   <para>rdfs:comment : A hotel is an establishment that provides paid lodging on a short-term basis. Wikipedia</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Hotel">pext:Hotel</a>
    /// </summary>
    let Hotel = _prefixId.prefix "Hotel"
    /// <summary>
    ///   <para>rdfs:label : Human</para>
    ///   <para>rdfs:comment : Human is a mammal referred to Primate. Also of the sort of hommo sapiens. It has two subClasses: Man and Woman.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Human">pext:Human</a>
    /// </summary>
    let Human = _prefixId.prefix "Human"
    /// <summary>
    ///   <para>rdfs:label : Hydrographic Structure</para>
    ///   <para>rdfs:comment : (ADL FT) For constructed bodies of water. For natural water bodies, use 'hydrographic features'. We use this category for boat landings; for boat launches; for boat ramps; for sluices; and for water mills. Many sub-classes omitted; those considered are also made sub-classes of WaterRegion. NIMA GNS ... no direct equivalent.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#HydrographicStructure">pext:HydrographicStructure</a>
    /// </summary>
    let HydrographicStructure = _prefixId.prefix "HydrographicStructure"
    /// <summary>
    ///   <para>rdfs:label : IP Address</para>
    ///   <para>rdfs:comment : An Internet Protocol address (IP address) is a numerical label assigned to each device (e.g., computer, printer) participating in a computer network that uses the Internet Protocol for communication. Wikipedia</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#IPAddress">pext:IPAddress</a>
    /// </summary>
    let IPAddress = _prefixId.prefix "IPAddress"
    /// <summary>
    ///   <para>rdfs:label : ISBN</para>
    ///   <para>rdfs:comment : The ISBN (International Standard Book Number) is a unique machine-readable identification number, which marks any book unmistakably.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ISBN">pext:ISBN</a>
    /// </summary>
    let ISBN = _prefixId.prefix "ISBN"
    /// <summary>
    ///   <para>rdfs:label : ISSN</para>
    ///   <para>rdfs:comment : The ISSN (International Standard Serial Number) is an eight-digit number which identifies periodical publications as such, including electronic serials. More than one million ISSN numbers have so far been assigned.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ISSN">pext:ISSN</a>
    /// </summary>
    let ISSN = _prefixId.prefix "ISSN"
    /// <summary>
    ///   <para>rdfs:label : Ice Hockey League</para>
    ///   <para>rdfs:comment : Any Ice Hockey league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#IceHockeyLeague">pext:IceHockeyLeague</a>
    /// </summary>
    let IceHockeyLeague = _prefixId.prefix "IceHockeyLeague"
    let IceHockeyPlayer = _prefixId.prefix "IceHockeyPlayer"
    /// <summary>
    ///   <para>rdfs:label : Icecap</para>
    ///   <para>rdfs:comment : A dome-shaped mass of glacial ice covering an area of mountain summits or other high lands; smaller than an ice sheet</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Icecap">pext:Icecap</a>
    /// </summary>
    let Icecap = _prefixId.prefix "Icecap"
    /// <summary>
    ///   <para>rdfs:label : Ideology</para>
    ///   <para>rdfs:comment : An ideology is a set of ideas that constitute one's goals, expectations, and actions. Wikipedia.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Ideology">pext:Ideology</a>
    /// </summary>
    let Ideology = _prefixId.prefix "Ideology"
    /// <summary>
    ///   <para>rdfs:label : Image^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ImageDocument">pext:ImageDocument</a>
    /// </summary>
    let ImageDocument = _prefixId.prefix "ImageDocument"
    /// <summary>
    ///   <para>rdfs:label : Industry Sector</para>
    ///   <para>rdfs:comment : A classification of companies that have similar production processes, similar products, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#IndustrySector">pext:IndustrySector</a>
    /// </summary>
    let IndustrySector = _prefixId.prefix "IndustrySector"
    /// <summary>
    ///   <para>rdfs:label : Information Space^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#InformationSpace">pext:InformationSpace</a>
    /// </summary>
    let InformationSpace = _prefixId.prefix "InformationSpace"
    /// <summary>
    ///   <para>rdfs:label : Information Space Profile^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#InformationSpaceProfile">pext:InformationSpaceProfile</a>
    /// </summary>
    let InformationSpaceProfile = _prefixId.prefix "InformationSpaceProfile"
    /// <summary>
    ///   <para>rdfs:label : Inline Hockey League</para>
    ///   <para>rdfs:comment : Any Inline Hockey league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#InlineHockeyLeague">pext:InlineHockeyLeague</a>
    /// </summary>
    let InlineHockeyLeague = _prefixId.prefix "InlineHockeyLeague"
    /// <summary>
    ///   <para>rdfs:label : Insect</para>
    ///   <para>rdfs:comment : Insects are a class within the arthropods that have a chitinous exoskeleton, a three-part body (head, thorax, and abdomen), three pairs of jointed legs, compound eyes, and two antennae. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Insect">pext:Insect</a>
    /// </summary>
    let Insect = _prefixId.prefix "Insect"
    /// <summary>
    ///   <para>rdfs:label : Institute</para>
    ///   <para>rdfs:comment : A research organization devoted primarily on search in some scientific research.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Institute">pext:Institute</a>
    /// </summary>
    let Institute = _prefixId.prefix "Institute"
    /// <summary>
    ///   <para>rdfs:label : Insurance Company</para>
    ///   <para>rdfs:comment : A company providing insurance services agains different dangerous or risky events.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#InsuranceCompany">pext:InsuranceCompany</a>
    /// </summary>
    let InsuranceCompany = _prefixId.prefix "InsuranceCompany"
    /// <summary>
    ///   <para>rdfs:label : International Organization</para>
    ///   <para>rdfs:comment : Legal international organization. Legal in this case means officially recognized by more than one government.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#InternationalOrganization">pext:InternationalOrganization</a>
    /// </summary>
    let InternationalOrganization = _prefixId.prefix "InternationalOrganization"
    /// <summary>
    ///   <para>rdfs:label : Internet Address</para>
    ///   <para>rdfs:comment : An identifier that determines a resource on the Internet.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#InternetAddress">pext:InternetAddress</a>
    /// </summary>
    let InternetAddress = _prefixId.prefix "InternetAddress"
    /// <summary>
    ///   <para>rdfs:label : Internet Domain</para>
    ///   <para>rdfs:comment : A domain name is an identification string that defines the area of administrative autonomy, authority, or control in the Internet. Wikipedia.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#InternetDomain">pext:InternetDomain</a>
    /// </summary>
    let InternetDomain = _prefixId.prefix "InternetDomain"
    /// <summary>
    ///   <para>rdfs:label : Irrigation System</para>
    ///   <para>rdfs:comment : A network of ditches and one or more of the following elements: water supply, reservoir, canal, pump, well, drain, etc. NIMA GNS designator H.SYSI.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#IrrigationSystem">pext:IrrigationSystem</a>
    /// </summary>
    let IrrigationSystem = _prefixId.prefix "IrrigationSystem"
    /// <summary>
    ///   <para>rdfs:label : Island</para>
    ///   <para>rdfs:comment : (ADL FT) Tracts of land smaller than a continent, surrounded by the water of an ocean, sea, lake or stream. [Glossary of Geology, 4th ed.] We use this category for atolls; for cays; for island arcs; for isles; for islets; for keys (islands); for land-tied islands; and for mangrove islands. NIMA GNS designator ISL, ISLF, ISLM, ISLS, ISLT, ISLX</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Island">pext:Island</a>
    /// </summary>
    let Island = _prefixId.prefix "Island"
    /// <summary>
    ///   <para>rdfs:label : Issue of Periodical</para>
    ///   <para>rdfs:comment : A specific issue, number, and/or volume of periodical publication such as magazine.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#IssueOfPeriodical">pext:IssueOfPeriodical</a>
    /// </summary>
    let IssueOfPeriodical = _prefixId.prefix "IssueOfPeriodical"
    /// <summary>
    ///   <para>rdfs:label : Isthmus</para>
    ///   <para>rdfs:comment : (ADL FT) Narrow sections of land in a body of water connecting two larger land areas. NIMA GNS designator ISTH.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Isthmus">pext:Isthmus</a>
    /// </summary>
    let Isthmus = _prefixId.prefix "Isthmus"
    /// <summary>
    ///   <para>rdfs:label : Job Title</para>
    ///   <para>rdfs:comment : The name of a position a person holds within an organization.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#JobTitle">pext:JobTitle</a>
    /// </summary>
    let JobTitle = _prefixId.prefix "JobTitle"
    let Journalist = _prefixId.prefix "Journalist"
    let Judge = _prefixId.prefix "Judge"
    /// <summary>
    ///   <para>rdfs:label : Jungle</para>
    ///   <para>rdfs:comment : (ADL FT) Tropical regions of wild, tangled, dense vegetation. NIMA GNS designator - no equivalent.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Jungle">pext:Jungle</a>
    /// </summary>
    let Jungle = _prefixId.prefix "Jungle"
    /// <summary>
    ///   <para>rdfs:label : Lacrosse League</para>
    ///   <para>rdfs:comment : Any Lacrosse league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#LacrosseLeague">pext:LacrosseLeague</a>
    /// </summary>
    let LacrosseLeague = _prefixId.prefix "LacrosseLeague"
    /// <summary>
    ///   <para>rdfs:label : Lagoon</para>
    ///   <para>rdfs:comment : A body of water cut off from the open sea by coral reefs or sand bars. http://www.eionet.europa.eu/gemet/concept/4589. NIMA GNS designator H.LGN, H.LGNS, H.LGNX.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Lagoon">pext:Lagoon</a>
    /// </summary>
    let Lagoon = _prefixId.prefix "Lagoon"
    /// <summary>
    ///   <para>rdfs:label : Lake</para>
    ///   <para>rdfs:comment : (ADL FT) Use 'reservoirs' for human engineered lakes. Natural inland bodies of standing water, generally of appreciable size, occupying a depression in the Earth's surface. [Adapted from Glossary of Geology, 4th ed.] We use this category for beaver ponds; for crater lakes; for dry lakes; for fish ponds; for fishponds; for inland seas; for intermittent lakes; for intermittent oxbow lakes; for intermittent ponds; for intermittent pools; for intermittent salt lakes; for intermittent salt ponds; for lagoons; for laguna; for lake beds; for lochs; for millponds; for oxbow lakes; for ponds; for pools (water bodies); for salt evaporation ponds; for salt lakes; for salt ponds; and for tarns. NIMA GNS designators LBED, LK, LKC, LKI, LKN, LKNI, LKO, LKOI, LKS, LKSB, LKSC, LKSI, LKSN, LKSNI, LKX</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Lake">pext:Lake</a>
    /// </summary>
    let Lake = _prefixId.prefix "Lake"
    /// <summary>
    ///   <para>rdfs:label : Area</para>
    ///   <para>rdfs:comment : A tract of land without homogeneous character or boundaries. NIMA GNS designator L.AREA.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#LandArea">pext:LandArea</a>
    /// </summary>
    let LandArea = _prefixId.prefix "LandArea"
    /// <summary>
    ///   <para>rdfs:label : Land Region</para>
    ///   <para>rdfs:comment : Any sort of land regions which are sort of natural, i.e. excluding urban areas, political and administrative regions. It combines number of ADL feature types under Physiographic features and Regions. Omitted ADL sub-classes: Badlands, Bars, Basins, Bight, Cirques, Cliffs, Dunes, Flats, Karst areas. Ledges, Massifs, Mineral deposit areas, Moraines, Natural rock formations, Arches, Playas, Seafloor Features, Tectonic features, Volcanic features (Volcano put under Mountain), Subcontinents. NIMA GNS designators FSR, FURU, HMCK, PLDR, RKFL, SINK, SLID, SLP, SLPU, TERU, TRR.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#LandRegion">pext:LandRegion</a>
    /// </summary>
    let LandRegion = _prefixId.prefix "LandRegion"
    /// <summary>
    ///   <para>rdfs:label : Launch Facility</para>
    ///   <para>rdfs:comment : (ADL FT) Areas from which rockets/missiles may be housed and projected, usually equipped with associated buildings and facilities. [USGS Circ 1048] We use this category for missile sites. NIMA GNS designator - no equivalent.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#LaunchFacility">pext:LaunchFacility</a>
    /// </summary>
    let LaunchFacility = _prefixId.prefix "LaunchFacility"
    /// <summary>
    ///   <para>rdfs:label : Law firm</para>
    ///   <para>rdfs:comment : A law firm is a business entity formed by one or more lawyers to engage in the practice of law. The primary service provided by a law firm is to advise clients (individuals or corporations) about their legal rights and responsibilities, and to represent their clients in civil or criminal cases, business transactions, and other matters in which legal advice and other assistance are sought. DBPedia</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#LawFirm">pext:LawFirm</a>
    /// </summary>
    let LawFirm = _prefixId.prefix "LawFirm"
    let Lawyer = _prefixId.prefix "Lawyer"
    /// <summary>
    ///   <para>rdfs:label : Legal Cases</para>
    ///   <para>rdfs:comment : Denotes concrete legal cases, such as Dennis v. United States, Francis v. Resweber, United_States v. Virginia, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#LegalCases">pext:LegalCases</a>
    /// </summary>
    let LegalCases = _prefixId.prefix "LegalCases"
    /// <summary>
    ///   <para>rdfs:label : Legislation</para>
    ///   <para>rdfs:comment : Various sorts of legislative documents, including consitutions, laws, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Legislation">pext:Legislation</a>
    /// </summary>
    let Legislation = _prefixId.prefix "Legislation"
    /// <summary>
    ///   <para>rdfs:label : Library</para>
    ///   <para>rdfs:comment : A collection of books, journals, audio and video materials, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Library">pext:Library</a>
    /// </summary>
    let Library = _prefixId.prefix "Library"
    /// <summary>
    ///   <para>rdfs:label : Library</para>
    ///   <para>rdfs:comment : A building in which library organization is housed.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#LibraryBuilding">pext:LibraryBuilding</a>
    /// </summary>
    let LibraryBuilding = _prefixId.prefix "LibraryBuilding"
    /// <summary>
    ///   <para>rdfs:label : Library</para>
    ///   <para>rdfs:comment : An education organization teaching pupils from first grade to tenth/eleventh/twelfth grade. It could be a primary school, or a secondary school.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#LibraryOrganization">pext:LibraryOrganization</a>
    /// </summary>
    let LibraryOrganization = _prefixId.prefix "LibraryOrganization"
    let Lieutenant = _prefixId.prefix "Lieutenant"
    /// <summary>
    ///   <para>rdfs:label : Lighthouse</para>
    ///   <para>rdfs:comment : A tower, building, or other type of structure designed to emit light from a system of lamps and lenses and used as an aid to navigation for maritime pilots at sea or on inland waterways</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#LightHouse">pext:LightHouse</a>
    /// </summary>
    let LightHouse = _prefixId.prefix "LightHouse"
    /// <summary>
    ///   <para>rdfs:label : Living Object</para>
    ///   <para>rdfs:comment : Living object is any organism which is living, e.g. breathing and regular lifecycle.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#LivingObject">pext:LivingObject</a>
    /// </summary>
    let LivingObject = _prefixId.prefix "LivingObject"
    /// <summary>
    ///   <para>rdfs:label : Local Capital</para>
    ///   <para>rdfs:comment : A capital of a Province or smaller administrative region. NIMA GNS designator PPLA.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#LocalCapital">pext:LocalCapital</a>
    /// </summary>
    let LocalCapital = _prefixId.prefix "LocalCapital"
    /// <summary>
    ///   <para>rdfs:label : Location of Special Interest</para>
    ///   <para>rdfs:comment : Any place with some particular value, which triggers interest.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#LocationOfSpecialInterest">pext:LocationOfSpecialInterest</a>
    /// </summary>
    let LocationOfSpecialInterest = _prefixId.prefix "LocationOfSpecialInterest"
    /// <summary>
    ///   <para>rdfs:label : Lock</para>
    ///   <para>rdfs:comment : (ADL FT) Stretches of water in canals, streams, or docks, enclosed by gates at each end, and used in raising and lowering boats as they pass from one water level to another. NIMA GNS designator LOCK.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Lock">pext:Lock</a>
    /// </summary>
    let Lock = _prefixId.prefix "Lock"
    /// <summary>
    ///   <para>rdfs:label : Locomotive</para>
    ///   <para>rdfs:comment : Locomotive, a railway vehicle that provides the motive power for a train. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Locomotive">pext:Locomotive</a>
    /// </summary>
    let Locomotive = _prefixId.prefix "Locomotive"
    /// <summary>
    ///   <para>rdfs:label : Lymphatic Node</para>
    ///   <para>rdfs:comment : Lymph is a general concept gathering all lymph nodes of the body.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#LymphNode">pext:LymphNode</a>
    /// </summary>
    let LymphNode = _prefixId.prefix "LymphNode"
    /// <summary>
    ///   <para>rdfs:label : Devicerdfs:label : Machine</para>
    ///   <para>rdfs:comment : Any produced device with particular purpose that uses energy to perform some activity. The device has parts that perform or assist in performing any type of work. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Machine">pext:Machine</a>
    /// </summary>
    let Machine = _prefixId.prefix "Machine"
    /// <summary>
    ///   <para>rdfs:label : Magazine</para>
    ///   <para>rdfs:comment : A periodic paperback publication; "it takes several years before a magazine starts to break even or make money"), WordNet 1.7.1. This includes also journals and digests. The specific issues typically contain a number of different articles.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Magazine">pext:Magazine</a>
    /// </summary>
    let Magazine = _prefixId.prefix "Magazine"
    /// <summary>
    ///   <para>rdfs:label : Magazine Issue</para>
    ///   <para>rdfs:comment : A specific issue of a magazine, journal or digest.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MagazineIssue">pext:MagazineIssue</a>
    /// </summary>
    let MagazineIssue = _prefixId.prefix "MagazineIssue"
    /// <summary>
    ///   <para>rdfs:label : Mammal</para>
    ///   <para>rdfs:comment : Mammals are members of a class of air-breathing vertebrate animals characterized by the possession of hair, three middle ear bones, and mammary glands functional in mothers with young. Most mammals also possess sweat glands and specialized teeth, and the largest group of mammals, the placentals, have a placenta which feeds the offspring during gestation. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Mammal">pext:Mammal</a>
    /// </summary>
    let Mammal = _prefixId.prefix "Mammal"
    /// <summary>
    ///   <para>rdfs:label : Man</para>
    ///   <para>rdfs:comment : A male human.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Man">pext:Man</a>
    /// </summary>
    let Man = _prefixId.prefix "Man"
    let Manager = _prefixId.prefix "Manager"
    /// <summary>
    ///   <para>rdfs:label : Market</para>
    ///   <para>rdfs:comment : In contrast to IndustrySector, the market is determined by the customers instead of the business or the manifacturers. The market can be defined in terms of types of goods/services, geographic region, price levels and typical customer behaviours. Corresponding to the third sense in WordNet 1.7.1 "the customers for a particular product or service".</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Market">pext:Market</a>
    /// </summary>
    let Market = _prefixId.prefix "Market"
    /// <summary>
    ///   <para>rdfs:label : Marsh</para>
    ///   <para>rdfs:comment : An area of open ground overlaid with wet peaty soils; a wetland dominated by grass-like vegetation; a flat area, subject to periodic salt water inundation, dominated by grassy salt-tolerant plants; a salt flat or salt encrusted plain subject to periodic inundation from flooding or high tides</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Marsh">pext:Marsh</a>
    /// </summary>
    let Marsh = _prefixId.prefix "Marsh"
    let MartialArtist = _prefixId.prefix "MartialArtist"
    let Mayor = _prefixId.prefix "Mayor"
    /// <summary>
    ///   <para>rdfs:label : Meadow</para>
    ///   <para>rdfs:comment : A small, poorly drained area dominated by grassy vegetation</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Meadow">pext:Meadow</a>
    /// </summary>
    let Meadow = _prefixId.prefix "Meadow"
    /// <summary>
    ///   <para>rdfs:label : Media Brand</para>
    ///   <para>rdfs:comment : A brand of a media company.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MediaBrand">pext:MediaBrand</a>
    /// </summary>
    let MediaBrand = _prefixId.prefix "MediaBrand"
    /// <summary>
    ///   <para>rdfs:label : Media Company</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MediaCompany">pext:MediaCompany</a>
    /// </summary>
    let MediaCompany = _prefixId.prefix "MediaCompany"
    /// <summary>
    ///   <para>rdfs:label : Media Product</para>
    ///   <para>rdfs:comment : A mass media product (for instance a newspaper) abstracted from its organizational and ownership aspects (i.e. from its publisher) and considered more as a social phenomenon, partly a brand.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MediaProduct">pext:MediaProduct</a>
    /// </summary>
    let MediaProduct = _prefixId.prefix "MediaProduct"
    /// <summary>
    ///   <para>rdfs:label : Meeting</para>
    ///   <para>rdfs:comment : A meeting is a gathering of two or more people that has been convened for the purpose of achieving a common goal through verbal interaction, such as sharing information or reaching an agreement. Wikipedia.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Meeting">pext:Meeting</a>
    /// </summary>
    let Meeting = _prefixId.prefix "Meeting"
    /// <summary>
    ///   <para>rdfs:label : Meeting Proceedings</para>
    ///   <para>rdfs:comment : A collection of articles or presentations published as a book.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MeetingProceedings">pext:MeetingProceedings</a>
    /// </summary>
    let MeetingProceedings = _prefixId.prefix "MeetingProceedings"
    let MemberOfParliament = _prefixId.prefix "MemberOfParliament"
    /// <summary>
    ///   <para>rdfs:label : Section^^xsd:string</para>
    ///   <para>rdfs:comment : An area of a document that can be considered a mention of something.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Mention">pext:Mention</a>
    /// </summary>
    let Mention = _prefixId.prefix "Mention"
    /// <summary>
    ///   <para>rdfs:label : Message</para>
    ///   <para>rdfs:comment : A written message, including various postings in newspapers or public sources, job position adverts, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Message">pext:Message</a>
    /// </summary>
    let Message = _prefixId.prefix "Message"
    /// <summary>
    ///   <para>rdfs:label : Military Areas</para>
    ///   <para>rdfs:comment : (ADL FTT) We use this category for air force bases; for army facilities; for arsenals; for artillery ranges; for barracks; for bases (military); for camps (military); for forts; for infantry camps; for maneuver areas; for military bases; for military installations; for national guard facilities; and for naval bases. The following NIMA designators fit here: MILB, INSM, SCHM. The following ADL types are skipped as irrelevant: Cadastral areas,</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MilitaryAreas">pext:MilitaryAreas</a>
    /// </summary>
    let MilitaryAreas = _prefixId.prefix "MilitaryAreas"
    /// <summary>
    ///   <para>rdfs:label : Military Command</para>
    ///   <para>rdfs:comment : Any military command, the organization which has a commanding role in a military organization.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MilitaryCommand">pext:MilitaryCommand</a>
    /// </summary>
    let MilitaryCommand = _prefixId.prefix "MilitaryCommand"
    /// <summary>
    ///   <para>rdfs:label : Military Conflict</para>
    ///   <para>rdfs:comment : An event of organized, armed, and often prolonged conflict carried on between states, nations, or other parties. Wikipedia.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MilitaryConflict">pext:MilitaryConflict</a>
    /// </summary>
    let MilitaryConflict = _prefixId.prefix "MilitaryConflict"
    /// <summary>
    ///   <para>rdfs:label : Military Organisation</para>
    ///   <para>rdfs:comment : Any military organisation, the structuring of the armed forces of a state so as to offer military capability required by the national defence policy. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MilitaryOrganization">pext:MilitaryOrganization</a>
    /// </summary>
    let MilitaryOrganization = _prefixId.prefix "MilitaryOrganization"
    let MilitaryPerson = _prefixId.prefix "MilitaryPerson"
    /// <summary>
    ///   <para>rdfs:label : Military Unit</para>
    ///   <para>rdfs:comment : Any military unit, a smaller military organization.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MilitaryUnit">pext:MilitaryUnit</a>
    /// </summary>
    let MilitaryUnit = _prefixId.prefix "MilitaryUnit"
    /// <summary>
    ///   <para>rdfs:label : Mine Site</para>
    ///   <para>rdfs:comment : (ADL FT) Places or areas from which commercial minerals are or were removed by excavation from the Earth. [Adapted from USGS Feature Class Definitions &lt;http://mapping.usgs.gov/www/ti/GNIS/gnis_users_guide_appendixc.html&gt;] We use this category for adits (mine sites); for chrome mines; for coal mines; for collieries; for copper mines; for diatomite mines; for gold mines; for gravel pits; for iron mines; for lead mines; for mine entrances; for mine shafts; for mines; for mining areas; for mining camps; for nickel mines; for open pit mines; for placer mines; for quarries; for salt mines; for strip mines; and for tin mines. NIMA GNS designators MN, MNA, MNAU, MNC, MNCR, MNDT, MNCU, MNFE, MNN, MNNI, MNPB, MNPL. MNQ, MNSN.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MineSite">pext:MineSite</a>
    /// </summary>
    let MineSite = _prefixId.prefix "MineSite"
    /// <summary>
    ///   <para>rdfs:label : Ministry</para>
    ///   <para>rdfs:comment : (Department) A specific ministry or department, structural unit of the government of specific country with focus and authority on specific problems of the country.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Ministry">pext:Ministry</a>
    /// </summary>
    let Ministry = _prefixId.prefix "Ministry"
    /// <summary>
    ///   <para>rdfs:label : Mixed Martial Arts League</para>
    ///   <para>rdfs:comment : Any Mixed Martial Arts league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MixedMartialArtsLeague">pext:MixedMartialArtsLeague</a>
    /// </summary>
    let MixedMartialArtsLeague = _prefixId.prefix "MixedMartialArtsLeague"
    /// <summary>
    ///   <para>rdfs:label : Mollusca</para>
    ///   <para>rdfs:comment : Mollusca is a large phylum of invertebrate animals. This is the largest marine phylum, comprising about 23% of all the named marine organisms. Numerous molluscs also live in freshwater and terrestrial habitats. Molluscs are highly diverse, not only in size and in anatomical structure, but also in behaviour and in habitat. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Mollusca">pext:Mollusca</a>
    /// </summary>
    let Mollusca = _prefixId.prefix "Mollusca"
    let Monarch = _prefixId.prefix "Monarch"
    /// <summary>
    ///   <para>rdfs:label : Money</para>
    ///   <para>rdfs:comment : A specific amount of money in specific currency</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Money">pext:Money</a>
    /// </summary>
    let Money = _prefixId.prefix "Money"
    /// <summary>
    ///   <para>rdfs:label : Month</para>
    ///   <para>rdfs:comment : A specific month, like Dec 2000, as a time period.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Month">pext:Month</a>
    /// </summary>
    let Month = _prefixId.prefix "Month"
    /// <summary>
    ///   <para>rdfs:label : Monument</para>
    ///   <para>rdfs:comment : (ADL FT) Structures erected as memorials. [Adapted from American Heritage Dic. of the English Language, 4th ed.] We use this category for cairns; for landmarks (monuments); for memorials; for national monuments; for pyramids; for shrines; for statues; and for tombs. NIMA GNS designators MNMT, PYR, PYRS, CARN.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Monument">pext:Monument</a>
    /// </summary>
    let Monument = _prefixId.prefix "Monument"
    /// <summary>
    ///   <para>rdfs:label : Motorcycle Racing League</para>
    ///   <para>rdfs:comment : Any Motorcycle Racing league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MotorcycleRacingLeague">pext:MotorcycleRacingLeague</a>
    /// </summary>
    let MotorcycleRacingLeague = _prefixId.prefix "MotorcycleRacingLeague"
    /// <summary>
    ///   <para>rdfs:label : Mountain</para>
    ///   <para>rdfs:comment : (ADL FT) Landmasses that project conspicuously above their surroundings. [USGS Circ 1048] We use this category for cerros; for cordilleras; for foothills; for hills; for knolls; for mounds; and for mounts. Omitted ADL sub-classes: Continental divides. NIMA GNS designator MT, MTS, MTSU, MTU, MND, KNLU, KNSU, CDAU, HLL, HLLS, HLLU, HLSU.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Mountain">pext:Mountain</a>
    /// </summary>
    let Mountain = _prefixId.prefix "Mountain"
    /// <summary>
    ///   <para>rdfs:label : Mountain Pass</para>
    ///   <para>rdfs:comment : Any mountain pass. NIMA GNS designators - no direct equivalents</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MountainPass">pext:MountainPass</a>
    /// </summary>
    let MountainPass = _prefixId.prefix "MountainPass"
    /// <summary>
    ///   <para>rdfs:label : Mountain Range</para>
    ///   <para>rdfs:comment : (ADL FT) (a) Chains of hills or mountains; (b) somewhat linear, complex mountainous or hilly areas. ... We use this category for ranges (physiographic); and for sierra. NIMA GNS designator RNGU.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MountainRange">pext:MountainRange</a>
    /// </summary>
    let MountainRange = _prefixId.prefix "MountainRange"
    /// <summary>
    ///   <para>rdfs:label : Mountain Summit</para>
    ///   <para>rdfs:comment : (ADL FT) Peaks of mountains. [USGS Circ 1048] We use this category for ahus; for mountain crests; for nunataks; for peaks; and for summits. NIMA GNS designators PK, PKS, PKSU, PKU.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MountainSummit">pext:MountainSummit</a>
    /// </summary>
    let MountainSummit = _prefixId.prefix "MountainSummit"
    /// <summary>
    ///   <para>rdfs:label : Movie</para>
    ///   <para>rdfs:comment : A film, also called a movie or motion picture, is a series of still or moving images. Wikipedia.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Movie">pext:Movie</a>
    /// </summary>
    let Movie = _prefixId.prefix "Movie"
    /// <summary>
    ///   <para>rdfs:label : Mud Flat</para>
    ///   <para>rdfs:comment : A relatively level area of mud either between high and low tide lines, or subject to flooding; a large flat area of mud or sand attached to the shore and alternately covered and uncovered by the tide; a tropical tidal mud flat characterized by mangrove vegetation</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MudFlat">pext:MudFlat</a>
    /// </summary>
    let MudFlat = _prefixId.prefix "MudFlat"
    /// <summary>
    ///   <para>rdfs:label : Muscle</para>
    ///   <para>rdfs:comment : Any muscle of a body.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Muscle">pext:Muscle</a>
    /// </summary>
    let Muscle = _prefixId.prefix "Muscle"
    /// <summary>
    ///   <para>rdfs:label : Museum</para>
    ///   <para>rdfs:comment : Any museum, an institution that houses and cares for a collection of artifacts and other objects of scientific, artistic, or historical importance and makes them available for public viewing through exhibits that may be permanent or temporary. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Museum">pext:Museum</a>
    /// </summary>
    let Museum = _prefixId.prefix "Museum"
    /// <summary>
    ///   <para>rdfs:label : Musical Company</para>
    ///   <para>rdfs:comment : Any Musical company, a company involved in the music business, e.g. sells compositions, recordings and performances of music, like Soni Music Entertainment.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MusicCompany">pext:MusicCompany</a>
    /// </summary>
    let MusicCompany = _prefixId.prefix "MusicCompany"
    /// <summary>
    ///   <para>rdfs:label : Music Festival</para>
    ///   <para>rdfs:comment : Any festival involving playing music.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MusicFestival">pext:MusicFestival</a>
    /// </summary>
    let MusicFestival = _prefixId.prefix "MusicFestival"
    /// <summary>
    ///   <para>rdfs:label : Music Genre</para>
    ///   <para>rdfs:comment : Any genre which pertians to music, e.g. classical, folk, pop, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MusicGenre">pext:MusicGenre</a>
    /// </summary>
    let MusicGenre = _prefixId.prefix "MusicGenre"
    /// <summary>
    ///   <para>rdfs:label : Musical</para>
    ///   <para>rdfs:comment : Musical is a form of theatre or movie combining music, songs, spoken dialogue and dance. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Musical">pext:Musical</a>
    /// </summary>
    let Musical = _prefixId.prefix "Musical"
    /// <summary>
    ///   <para>rdfs:label : Musical Composition</para>
    ///   <para>rdfs:comment : An original piece of music.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MusicalComposition">pext:MusicalComposition</a>
    /// </summary>
    let MusicalComposition = _prefixId.prefix "MusicalComposition"
    /// <summary>
    ///   <para>rdfs:label : Musical Instrument</para>
    ///   <para>rdfs:comment : Musical Instrument, a device created or adapted for the purpose of making musical sounds. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#MusicalInstrument">pext:MusicalInstrument</a>
    /// </summary>
    let MusicalInstrument = _prefixId.prefix "MusicalInstrument"
    let Musician = _prefixId.prefix "Musician"
    /// <summary>
    ///   <para>rdfs:label : Narrows</para>
    ///   <para>rdfs:comment : A tidal strait. NIMA GNS designator H.NRWS.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Narrows">pext:Narrows</a>
    /// </summary>
    let Narrows = _prefixId.prefix "Narrows"
    let NascarDriver = _prefixId.prefix "NascarDriver"

    let NationalCollegiateAthleticAssociationAthlete =
        _prefixId.prefix "NationalCollegiateAthleticAssociationAthlete"

    /// <summary>
    ///   <para>rdfs:label : Nationality^^xsd:string</para>
    ///   <para>rdfs:comment : Any nationality. In most cases it is connected with a country name, but there are notionalities without countries - Kurd, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Nationality">pext:Nationality</a>
    /// </summary>
    let Nationality = _prefixId.prefix "Nationality"
    /// <summary>
    ///   <para>rdfs:label : Natural Phenomenon</para>
    ///   <para>rdfs:comment : Such as particular disease, the Gulfstream and other similar natural abstractions. The particular events or objects which could instantiate an abstract natural phenomena (i.e. specific sickness event caused by a disease) are not instances of this class.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#NaturalPhenomenon">pext:NaturalPhenomenon</a>
    /// </summary>
    let NaturalPhenomenon = _prefixId.prefix "NaturalPhenomenon"
    /// <summary>
    ///   <para>rdfs:label : Natural Satellite</para>
    ///   <para>rdfs:comment : A satellite which is not a direct result of human activity</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#NaturalSatellite">pext:NaturalSatellite</a>
    /// </summary>
    let NaturalSatellite = _prefixId.prefix "NaturalSatellite"
    /// <summary>
    ///   <para>rdfs:label : Nerve</para>
    ///   <para>rdfs:comment : Nerve is a general concept gathering all nerves of a body.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Nerve">pext:Nerve</a>
    /// </summary>
    let Nerve = _prefixId.prefix "Nerve"
    /// <summary>
    ///   <para>rdfs:label : News agency</para>
    ///   <para>rdfs:comment : A news agency is an organization of journalists established to supply news reports to news organizations: newspapers, magazines, and radio and television broadcasters. Wikipedia</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#NewsAgency">pext:NewsAgency</a>
    /// </summary>
    let NewsAgency = _prefixId.prefix "NewsAgency"
    /// <summary>
    ///   <para>rdfs:label : Newspaper</para>
    ///   <para>rdfs:comment : A newspaper abstracted from its organizational and ownership aspects as well as from a specific issue or paper body.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Newspaper">pext:Newspaper</a>
    /// </summary>
    let Newspaper = _prefixId.prefix "Newspaper"
    /// <summary>
    ///   <para>rdfs:label : Newspaper Issue</para>
    ///   <para>rdfs:comment : A specific issue of a newspaper.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#NewspaperIssue">pext:NewspaperIssue</a>
    /// </summary>
    let NewspaperIssue = _prefixId.prefix "NewspaperIssue"
    /// <summary>
    ///   <para>rdfs:label : Nobelty</para>
    ///   <para>rdfs:comment : The situation of holding a position in society as nobelty.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Nobelty">pext:Nobelty</a>
    /// </summary>
    let Nobelty = _prefixId.prefix "Nobelty"
    /// <summary>
    ///   <para>rdfs:label : Nobelty</para>
    ///   <para>rdfs:comment : The social function of a nobelty.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#NobeltyTitle">pext:NobeltyTitle</a>
    /// </summary>
    let NobeltyTitle = _prefixId.prefix "NobeltyTitle"
    /// <summary>
    ///   <para>rdfs:label : Non-Orofit Organisation</para>
    ///   <para>rdfs:comment : Any Non-Profit Organization, an organization that does not distribute its surplus funds to owners or shareholders, but instead uses them to help pursue its goals. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Non-ProfitOrganisation">pext:Non-ProfitOrganisation</a>
    /// </summary>
    let Non_ProfitOrganisation = _prefixId.prefix "Non-ProfitOrganisation"
    /// <summary>
    ///   <para>rdfs:label : Non Alcoholic Beverage</para>
    ///   <para>rdfs:comment : A type (specific receipe) for a beverage. For instance: Coca Cola, Schweppes, Apple Juice, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#NonAlcoholicBeverage">pext:NonAlcoholicBeverage</a>
    /// </summary>
    let NonAlcoholicBeverage = _prefixId.prefix "NonAlcoholicBeverage"
    /// <summary>
    ///   <para>rdfs:label : Non-Geographic Location</para>
    ///   <para>rdfs:comment : A non-geographic region in some 3D space. The Longitude and Latitude properties for such objects could be void.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#NonGeographicLocation">pext:NonGeographicLocation</a>
    /// </summary>
    let NonGeographicLocation = _prefixId.prefix "NonGeographicLocation"
    /// <summary>
    ///   <para>rdfs:label : Oasis</para>
    ///   <para>rdfs:comment : (ADL FT) Fertile, vegetated areas in the midst of a desert, where the water table has come close enough to the surface for wells and springs or seepages to exist, thus making them suitable for human habitation. NIMA GNS designator OAS.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Oasis">pext:Oasis</a>
    /// </summary>
    let Oasis = _prefixId.prefix "Oasis"
    /// <summary>
    ///   <para>rdfs:label : Ocean</para>
    ///   <para>rdfs:comment : (ADL FT) Continuous salt-water bodies that surround the continents and fill the Earth's great depressions. NIMA GNS designator OCN</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Ocean">pext:Ocean</a>
    /// </summary>
    let Ocean = _prefixId.prefix "Ocean"
    /// <summary>
    ///   <para>rdfs:label : Offer</para>
    ///   <para>rdfs:comment : Something offered (as a proposal or bid), WordNet 1.7.1. An offer is a statement made by the offerer to a specific agent or without recepient.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Offer">pext:Offer</a>
    /// </summary>
    let Offer = _prefixId.prefix "Offer"
    /// <summary>
    ///   <para>rdfs:label : Official Political Meeting</para>
    ///   <para>rdfs:comment : A meeting whose main participants are political entities playing official roles within it.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#OfficialPoliticalMeeting">pext:OfficialPoliticalMeeting</a>
    /// </summary>
    let OfficialPoliticalMeeting = _prefixId.prefix "OfficialPoliticalMeeting"
    /// <summary>
    ///   <para>rdfs:label : Official Position</para>
    ///   <para>rdfs:comment : A job position having a representative function with respect to an organization. Usually this is a position within a governmental organization.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#OfficialPosition">pext:OfficialPosition</a>
    /// </summary>
    let OfficialPosition = _prefixId.prefix "OfficialPosition"
    /// <summary>
    ///   <para>rdfs:label : Oil Field</para>
    ///   <para>rdfs:comment : (ADL FT) Areas with reserves of recoverable petroleum or where petroleum has been removed from the Earth. ... We use this category for gas fields; for gasfields; for oilfields; for petroleum fields; and for storage fields (petroleum). NIMA GNS designator CMPO, OILF, OILQ, OILW, PMPO, GASF.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#OilField">pext:OilField</a>
    /// </summary>
    let OilField = _prefixId.prefix "OilField"
    /// <summary>
    ///   <para>rdfs:label : Olympic Games</para>
    ///   <para>rdfs:comment : The institution of Olympic Games held every 4 years</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#OlympicGames">pext:OlympicGames</a>
    /// </summary>
    let OlympicGames = _prefixId.prefix "OlympicGames"
    /// <summary>
    ///   <para>rdfs:label : Olympic Games</para>
    ///   <para>rdfs:comment : A specific issue of the games, like Athens 2004</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#OlympicGamesOccurrence">pext:OlympicGamesOccurrence</a>
    /// </summary>
    let OlympicGamesOccurrence = _prefixId.prefix "OlympicGamesOccurrence"
    /// <summary>
    ///   <para>rdfs:label : Opera Performance</para>
    ///   <para>rdfs:comment : An art performance following an opera music and script.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#OperaPerformance">pext:OperaPerformance</a>
    /// </summary>
    let OperaPerformance = _prefixId.prefix "OperaPerformance"
    /// <summary>
    ///   <para>rdfs:label : Orchard</para>
    ///   <para>rdfs:comment : A planting of fruit or nut trees</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Orchard">pext:Orchard</a>
    /// </summary>
    let Orchard = _prefixId.prefix "Orchard"
    /// <summary>
    ///   <para>rdfs:label : Order</para>
    ///   <para>rdfs:comment : A statement used to request someone to supply something in return for payment and providing specifications and quantities. WordNet 2.1.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Order">pext:Order</a>
    /// </summary>
    let Order = _prefixId.prefix "Order"
    /// <summary>
    ///   <para>rdfs:label : OutOfLaws</para>
    ///   <para>rdfs:comment : The situation of holding a position in a society as out of law.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#OutOfLaws">pext:OutOfLaws</a>
    /// </summary>
    let OutOfLaws = _prefixId.prefix "OutOfLaws"
    /// <summary>
    ///   <para>rdfs:label : Criminal</para>
    ///   <para>rdfs:comment : Criminal, the social function of a person who has committed a crime and is out of the law.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#OutOfLawsTitle">pext:OutOfLawsTitle</a>
    /// </summary>
    let OutOfLawsTitle = _prefixId.prefix "OutOfLawsTitle"
    /// <summary>
    ///   <para>rdfs:label : Overfalls</para>
    ///   <para>rdfs:comment : An area of breaking waves caused by the meeting of currents or by waves moving against the current. NIMA GNS designator H.OVF.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Overfalls">pext:Overfalls</a>
    /// </summary>
    let Overfalls = _prefixId.prefix "Overfalls"
    /// <summary>
    ///   <para>rdfs:label : Paintball League</para>
    ///   <para>rdfs:comment : Any Paintball league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PaintballLeague">pext:PaintballLeague</a>
    /// </summary>
    let PaintballLeague = _prefixId.prefix "PaintballLeague"
    /// <summary>
    ///   <para>rdfs:label : painting</para>
    ///   <para>rdfs:comment : Any painting, the results of a practice of applying paint, pigment, color or other medium[1] to a surface (support base). (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Painting">pext:Painting</a>
    /// </summary>
    let Painting = _prefixId.prefix "Painting"
    /// <summary>
    ///   <para>rdfs:label : Parish</para>
    ///   <para>rdfs:comment : A district of religious land. NIMA GNS designator A.PRSH.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Parish">pext:Parish</a>
    /// </summary>
    let Parish = _prefixId.prefix "Parish"
    /// <summary>
    ///   <para>rdfs:label : Park</para>
    ///   <para>rdfs:comment : (ADL FT) Places or areas developed for public use or recreation. [USGS Circ 1048] We use this category for arboretums; for botanical gardens; for commemorative areas; for commons; for gardens; for marine parks; for national forests; for national parks; for national seashores; for park gates; for picnic areas; for playgrounds; for provincial parks; for public use areas; for recreation areas; for rest areas; for scenic areas; for state forests; for state parks; for urban parks; for village squares; for wilderness areas; for zoological gardens; and for zoos. Omitted sub-classes: Viewing locations. NIMA GNS designators PRK, PRKHQ, PRKGT</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Park">pext:Park</a>
    /// </summary>
    let Park = _prefixId.prefix "Park"
    /// <summary>
    ///   <para>rdfs:label : Parliament</para>
    ///   <para>rdfs:comment : A legislative assembly representative at national or regional level. It can also be called Senate, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Parliament">pext:Parliament</a>
    /// </summary>
    let Parliament = _prefixId.prefix "Parliament"
    /// <summary>
    ///   <para>rdfs:label : Patent</para>
    ///   <para>rdfs:comment : A registered (or awaiting registration) patent for specific invention or design.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Patent">pext:Patent</a>
    /// </summary>
    let Patent = _prefixId.prefix "Patent"
    /// <summary>
    ///   <para>rdfs:label : Peninsula</para>
    ///   <para>rdfs:comment : A land region surrounded by water from most sides, but having land connect to bigger land region. NIMA GNS designator PEN, PENX.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Peninsula">pext:Peninsula</a>
    /// </summary>
    let Peninsula = _prefixId.prefix "Peninsula"
    /// <summary>
    ///   <para>rdfs:label : Percent</para>
    ///   <para>rdfs:comment : A specific percent value</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Percent">pext:Percent</a>
    /// </summary>
    let Percent = _prefixId.prefix "Percent"
    /// <summary>
    ///   <para>rdfs:label : Performance Site</para>
    ///   <para>rdfs:comment : Buildings where cultural events are presented before an audience. We use this category for amphitheaters; for amphitheatres; for auditoriums; for bowls (performance); for coliseums; for concert halls; for opera houses; for playhouses; for recital halls; for stages (performance); for symphony halls; for theaters; and for theatres. NIMA GNS designator AMTH.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PerformanceSite">pext:PerformanceSite</a>
    /// </summary>
    let PerformanceSite = _prefixId.prefix "PerformanceSite"
    /// <summary>
    ///   <para>rdfs:label : Periodical Publication</para>
    ///   <para>rdfs:comment : A periodical publication, disregarding its specific issues, numbers, volumes, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PeriodicalPublication">pext:PeriodicalPublication</a>
    /// </summary>
    let PeriodicalPublication = _prefixId.prefix "PeriodicalPublication"
    /// <summary>
    ///   <para>rdfs:label : Petroleum Basin</para>
    ///   <para>rdfs:comment : An area underlain by an oil-rich structural basin. NIMA GNS designator L.BSNP.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PetroleumBasin">pext:PetroleumBasin</a>
    /// </summary>
    let PetroleumBasin = _prefixId.prefix "PetroleumBasin"
    let Philosopher = _prefixId.prefix "Philosopher"
    /// <summary>
    ///   <para>rdfs:label : Phone Number</para>
    ///   <para>rdfs:comment : A sequence of digits which represents an address of a telephone device within a telephone net.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PhoneNumber">pext:PhoneNumber</a>
    /// </summary>
    let PhoneNumber = _prefixId.prefix "PhoneNumber"
    /// <summary>
    ///   <para>rdfs:label : Piece of Art</para>
    ///   <para>rdfs:comment : An artifact, namely a piece of art, usually, matterial object. Typical instances are paintings and sculptures. Corresponds to the Wordnet 1.7.1 synset "art, fine art - the products of human creativity; works of art collectively; "an art exhibition"@en ; "a fine collection of art")"</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PieceOfArt">pext:PieceOfArt</a>
    /// </summary>
    let PieceOfArt = _prefixId.prefix "PieceOfArt"
    /// <summary>
    ///   <para>rdfs:label : Pipeline</para>
    ///   <para>rdfs:comment : (ADL FT) Tubular conduits of substantial length, with pumps, valves, and control devices, for conveying fluids, gases, or finely divided solids. [USGS Circ 1048] We use this category for compressor stations; for gas pipelines; for oil pipeline junctions; for oil pipeline terminals; for oil pipelines; for oil pumping stations; for pump houses; for pumphouses; for pumping stations; and for water pumping stations. NIMA GNS designators OILP, OILJ, TRMO, PMPO, PMPW.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Pipeline">pext:Pipeline</a>
    /// </summary>
    let Pipeline = _prefixId.prefix "Pipeline"
    /// <summary>
    ///   <para>rdfs:label : Plain</para>
    ///   <para>rdfs:comment : (ADL FT) Regions of general uniform slope, comparatively level and of considerable extent. [USGS Circ 1048] We use this category for interfluves; and for llanos. NIMA GNS designators PLN, PLNU, PLNX, INTF.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Plain">pext:Plain</a>
    /// </summary>
    let Plain = _prefixId.prefix "Plain"
    /// <summary>
    ///   <para>rdfs:label : Planet</para>
    ///   <para>rdfs:comment : Any of the celestial bodies (other than comets or satellites) that revolve around the sun in the solar system. Definition partly derived from WordNet 1.7</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Planet">pext:Planet</a>
    /// </summary>
    let Planet = _prefixId.prefix "Planet"
    /// <summary>
    ///   <para>rdfs:label : Plant</para>
    ///   <para>rdfs:comment : Plants are living organisms. They include familiar organisms such as trees, flowers, herbs, bushes, grasses, vines, ferns, mosses, and green algae. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Plant">pext:Plant</a>
    /// </summary>
    let Plant = _prefixId.prefix "Plant"
    /// <summary>
    ///   <para>rdfs:label : Plateau</para>
    ///   <para>rdfs:comment : (ADL FT) Comparatively flat areas of great extent and elevation; specif. extensive land regions considerably above the adjacent country or above sea level; commonly limited on at least one side by an abrupt descent, have flat or nearly smooth surfaces but are often dissected by deep valleys and surmounted by high hills or mountains, and have a large part of their total surface at or near the summit level. We use this category for table mountains; and for tablelands. The ADL type Mesas, collapsed here. NIMA GNS designators PLAT, PLTX, PLTU, MESA, MESU, TMSU, TMST.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Plateau">pext:Plateau</a>
    /// </summary>
    let Plateau = _prefixId.prefix "Plateau"
    /// <summary>
    ///   <para>rdfs:label : Play</para>
    ///   <para>rdfs:comment : A play is a form of literature written by a playwright, usually consisting of scripted dialogue between characters, intended for theatrical performance rather than just reading. DBPedia</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Play">pext:Play</a>
    /// </summary>
    let Play = _prefixId.prefix "Play"
    let PlayboyPlaymate = _prefixId.prefix "PlayboyPlaymate"
    let PokerPlayer = _prefixId.prefix "PokerPlayer"
    let PolishKing = _prefixId.prefix "PolishKing"
    /// <summary>
    ///   <para>rdfs:label : Political Entity</para>
    ///   <para>rdfs:comment : Any organization which has a political functions.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PoliticalEntity">pext:PoliticalEntity</a>
    /// </summary>
    let PoliticalEntity = _prefixId.prefix "PoliticalEntity"
    /// <summary>
    ///   <para>rdfs:label : Political Party</para>
    ///   <para>rdfs:comment : An organization to gain political power. Definition taken from WordNet 1.7</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PoliticalParty">pext:PoliticalParty</a>
    /// </summary>
    let PoliticalParty = _prefixId.prefix "PoliticalParty"
    /// <summary>
    ///   <para>rdfs:label : Political Region</para>
    ///   <para>rdfs:comment : (ADL, Political Entity) We use this category for commonwealths; for dependent political entities; for freely associated states; for independent political entities; for oblasts; for political entities; and for semi-independent political entities. Sub-classes omitted: Countries, 4th order divisions. NIMA GNS class: A, Administrative Boundary Features.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PoliticalRegion">pext:PoliticalRegion</a>
    /// </summary>
    let PoliticalRegion = _prefixId.prefix "PoliticalRegion"
    let Politician = _prefixId.prefix "Politician"
    /// <summary>
    ///   <para>rdfs:label : Polo League</para>
    ///   <para>rdfs:comment : Any Polo league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PoloLeague">pext:PoloLeague</a>
    /// </summary>
    let PoloLeague = _prefixId.prefix "PoloLeague"
    /// <summary>
    ///   <para>rdfs:label : Pond</para>
    ///   <para>rdfs:comment : A pond is a body of standing water, either natural or man-made, that is usually smaller than a lake. (Wikipedia). http://www.eionet.europa.eu/gemet/concept/6507. NIMA GNS designator H.PND, H.PNDI, H.PNDN, H.PNDNI, H.PNDS, H.PNDSF, H.PNDSI, H.PNDSN, H.MFGN.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Pond">pext:Pond</a>
    /// </summary>
    let Pond = _prefixId.prefix "Pond"
    /// <summary>
    ///   <para>rdfs:label : Pool</para>
    ///   <para>rdfs:comment : A small and comparatively still, deep part of a larger body of water. NIMA GNS designator H.POOL, H.POOLI.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Pool">pext:Pool</a>
    /// </summary>
    let Pool = _prefixId.prefix "Pool"
    let Pope = _prefixId.prefix "Pope"
    /// <summary>
    ///   <para>rdfs:label : Populated Place</para>
    ///   <para>rdfs:comment : (ADL FT) Places or areas with clustered or scattered buildings and a permanent human population. ... We use this category for agricultural colonies; for communes; for communities; for hamlets; for homesteads; for locales; for localities; for metropolitan areas; for populated localities; for ppl; for pueblos; for settlements; for suburbs; for villages; and with religious facilities for religious populated places. NIMA GNS designator PPL, PPL(x)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PopulatedPlace">pext:PopulatedPlace</a>
    /// </summary>
    let PopulatedPlace = _prefixId.prefix "PopulatedPlace"
    /// <summary>
    ///   <para>rdfs:label : City Namerdfs:label : Country Namerdfs:label : Name of a Populated Placerdfs:label : Town Namerdfs:label : Village Name</para>
    ///   <para>rdfs:comment : Part of a postal address denoting the name of a village, town, city, country, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PopulatedPlaceName">pext:PopulatedPlaceName</a>
    /// </summary>
    let PopulatedPlaceName = _prefixId.prefix "PopulatedPlaceName"
    /// <summary>
    ///   <para>rdfs:label : Position in an organization</para>
    ///   <para>rdfs:comment : The situation of a job position which is available in a particular organization, such as CEO, CTO, executive assistant, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PositionOrganization">pext:PositionOrganization</a>
    /// </summary>
    let PositionOrganization = _prefixId.prefix "PositionOrganization"
    /// <summary>
    ///   <para>rdfs:label : Possessions</para>
    ///   <para>rdfs:comment : Any property, e.g. possessions, the situation of owning an object.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Possession">pext:Possession</a>
    /// </summary>
    let Possession = _prefixId.prefix "Possession"
    /// <summary>
    ///   <para>rdfs:label : Postal Address</para>
    ///   <para>rdfs:comment : An address of a geographical place - usually a building. A postal address consists, usually, of a country name, zip code, city/village name, street name and number, a person name.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PostalAddress">pext:PostalAddress</a>
    /// </summary>
    let PostalAddress = _prefixId.prefix "PostalAddress"
    /// <summary>
    ///   <para>rdfs:label : Power station</para>
    ///   <para>rdfs:comment : Any power station</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PowerStation">pext:PowerStation</a>
    /// </summary>
    let PowerStation = _prefixId.prefix "PowerStation"
    let President = _prefixId.prefix "President"
    let Priest = _prefixId.prefix "Priest"
    let PrimeMinister = _prefixId.prefix "PrimeMinister"
    /// <summary>
    ///   <para>rdfs:label : Profession</para>
    ///   <para>rdfs:comment : A profession is a vocation founded upon specialized educational training. Wikipedia.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Profession">pext:Profession</a>
    /// </summary>
    let Profession = _prefixId.prefix "Profession"
    /// <summary>
    ///   <para>rdfs:label : Profile^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Profile">pext:Profile</a>
    /// </summary>
    let Profile = _prefixId.prefix "Profile"
    /// <summary>
    ///   <para>rdfs:label : Programming language</para>
    ///   <para>rdfs:comment : A formal language for encoding of computer programs.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ProgrammingLanguage">pext:ProgrammingLanguage</a>
    /// </summary>
    let ProgrammingLanguage = _prefixId.prefix "ProgrammingLanguage"
    /// <summary>
    ///   <para>rdfs:label : Project</para>
    ///   <para>rdfs:comment : A project is carefully planned event to achieve a particular aim. Based on Wikipedia.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Project">pext:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:label : Protected Area</para>
    ///   <para>rdfs:comment : Any Protected Area, an area which benefits of special attention and is with limited access or protected in other ways.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ProtectedArea">pext:ProtectedArea</a>
    /// </summary>
    let ProtectedArea = _prefixId.prefix "ProtectedArea"
    /// <summary>
    ///   <para>rdfs:label : Protein</para>
    ///   <para>rdfs:comment : Denotes any protein as a biological substance.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Protein">pext:Protein</a>
    /// </summary>
    let Protein = _prefixId.prefix "Protein"
    /// <summary>
    ///   <para>rdfs:label : Province</para>
    ///   <para>rdfs:comment : (ADL FT: Countries, 1st Order Divisions) First-order divisions of a nation. [USGS Circ 1048] We use this category for cantons; for first-order administrative divisions; for provinces; for states; and for territories. NIMA GNS designator ADM1. Also corresponds to the FIPS 10-4 principal administrative division defined as "an administrative area directly subordinate to the pertinent governing authority " NIMA GNS designator ADM1.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Province">pext:Province</a>
    /// </summary>
    let Province = _prefixId.prefix "Province"
    /// <summary>
    ///   <para>rdfs:label : Public Company</para>
    ///   <para>rdfs:comment : Company which is publicly traded on a Stock Exchange.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PublicCompany">pext:PublicCompany</a>
    /// </summary>
    let PublicCompany = _prefixId.prefix "PublicCompany"
    /// <summary>
    ///   <para>rdfs:label : Published Material</para>
    ///   <para>rdfs:comment : A document that is published or intended for publishing</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PublishedMaterial">pext:PublishedMaterial</a>
    /// </summary>
    let PublishedMaterial = _prefixId.prefix "PublishedMaterial"
    /// <summary>
    ///   <para>rdfs:label : Publishing Company</para>
    ///   <para>rdfs:comment : An organization which main activity is mass publishing of information. Often, the publishers issue periodic and/or non-periodic documents on paper media. While on-line publishing is considered a typical activity for publishers, the streaming electronic media such as TV and Radio Stations are not.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#PublishingCompany">pext:PublishingCompany</a>
    /// </summary>
    let PublishingCompany = _prefixId.prefix "PublishingCompany"
    /// <summary>
    ///   <para>rdfs:label : Quarter</para>
    ///   <para>rdfs:comment : A specific quarter of a specific year, such as Q4 1999</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Quarter">pext:Quarter</a>
    /// </summary>
    let Quarter = _prefixId.prefix "Quarter"
    /// <summary>
    ///   <para>rdfs:label : Race Course</para>
    ///   <para>rdfs:comment : A racecourse is a horse racing track.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#RaceCourse">pext:RaceCourse</a>
    /// </summary>
    let RaceCourse = _prefixId.prefix "RaceCourse"
    /// <summary>
    ///   <para>rdfs:label : Radio company</para>
    ///   <para>rdfs:comment : A company that broadcasts audio content.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#RadioCompany">pext:RadioCompany</a>
    /// </summary>
    let RadioCompany = _prefixId.prefix "RadioCompany"
    /// <summary>
    ///   <para>rdfs:label : Radio Controlled Racing League</para>
    ///   <para>rdfs:comment : Any Radio Controlled Racing league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#RadioControlledRacingLeague">pext:RadioControlledRacingLeague</a>
    /// </summary>
    let RadioControlledRacingLeague = _prefixId.prefix "RadioControlledRacingLeague"
    /// <summary>
    ///   <para>rdfs:label : Radio Station</para>
    ///   <para>rdfs:comment : A brand of a radio station.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#RadioStation">pext:RadioStation</a>
    /// </summary>
    let RadioStation = _prefixId.prefix "RadioStation"
    /// <summary>
    ///   <para>rdfs:label : Railroad Facility</para>
    ///   <para>rdfs:comment : (ADL FT: Railroad Features) We use this category for metro rail stations; for railroad junctions; for railroad sidings; for railroad spurs; for railroad stations; for railroad stops; for railroad switches; for railroad yards; for railways; for subway stations; for switches (railroad); and for tramways. NIMA GNS designator RJCT, RR, RRQ, RSD, RSGNL, RSTN, RSTNQ, RSTP, RSTPQ, RYD.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#RailroadFacility">pext:RailroadFacility</a>
    /// </summary>
    let RailroadFacility = _prefixId.prefix "RailroadFacility"
    /// <summary>
    ///   <para>rdfs:label : Railroad Tunnel</para>
    ///   <para>rdfs:comment : A tunnel for trains. NIMA GNS designator RTNL.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#RailroadTunnel">pext:RailroadTunnel</a>
    /// </summary>
    let RailroadTunnel = _prefixId.prefix "RailroadTunnel"
    /// <summary>
    ///   <para>rdfs:label : Ramp</para>
    ///   <para>rdfs:comment : A gentle slope connecting areas of different elevations</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Ramp">pext:Ramp</a>
    /// </summary>
    let Ramp = _prefixId.prefix "Ramp"
    /// <summary>
    ///   <para>rdfs:label : Rapids</para>
    ///   <para>rdfs:comment : A turbulent section of a stream associated with a steep, irregular stream bed. NIMA GNS designator H.RPDS.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Rapids">pext:Rapids</a>
    /// </summary>
    let Rapids = _prefixId.prefix "Rapids"
    /// <summary>
    ///   <para>rdfs:label : Recreational Facility</para>
    ///   <para>rdfs:comment : (ADL FT) We use this category for access areas; for access sites; for boardwalks; for casinos; for clubs (recreational); for country clubs; for fairgrounds; for fishing areas; for fishing lodges; for fitness centers; for gun clubs; for hunt posts; for hunting lodges; for ice skating rinks; for playgrounds; for recreation sites; for resorts; for riding stables; for spas; for sportsman lodges; for stables; for yacht clubs; for youth centers; and for youth facilities. NIMA GNS designators - no direct equivalents.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#RecreationalFacility">pext:RecreationalFacility</a>
    /// </summary>
    let RecreationalFacility = _prefixId.prefix "RecreationalFacility"
    /// <summary>
    ///   <para>rdfs:label : Recurring Event</para>
    ///   <para>rdfs:comment : Recurring sequence of events, such as Olympic Games, etc..</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#RecurringEvent">pext:RecurringEvent</a>
    /// </summary>
    let RecurringEvent = _prefixId.prefix "RecurringEvent"
    /// <summary>
    ///   <para>rdfs:label : Reef</para>
    ///   <para>rdfs:comment : (ADL FT) Chains of rocks or coral at or near the surface of water. [USGS Circ 1048] We use this category for barrier reefs; and for fringing reefs. Collapsed ADL sub-class: Coral Reefs. NIMA GNS designator RF, RFSU, RFU, RFC, H.RFX.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Reef">pext:Reef</a>
    /// </summary>
    let Reef = _prefixId.prefix "Reef"
    let Referee = _prefixId.prefix "Referee"
    /// <summary>
    ///   <para>rdfs:label : Reference Location</para>
    ///   <para>rdfs:comment : (ADL FT) We use this category for astronomical stations; for beacons; for bench marks; for boundaries; for boundary markers; for buoys; for control points; for geodectic stations; for geographic centers; for landmarks (reference locations); for light houses; for light stations; for lighthouses; for markers; for milestones; for plaques; for poles (sphere); for triangulation stations; and for walls. NIMNA GNS designators LTHSE, BP, TRIG.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ReferenceLocation">pext:ReferenceLocation</a>
    /// </summary>
    let ReferenceLocation = _prefixId.prefix "ReferenceLocation"
    /// <summary>
    ///   <para>rdfs:label : Region Mention^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#RegionMention">pext:RegionMention</a>
    /// </summary>
    let RegionMention = _prefixId.prefix "RegionMention"
    /// <summary>
    ///   <para>rdfs:label : Religious Location</para>
    ///   <para>rdfs:comment : Things like Monastery, Church</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ReligiousLocation">pext:ReligiousLocation</a>
    /// </summary>
    let ReligiousLocation = _prefixId.prefix "ReligiousLocation"
    /// <summary>
    ///   <para>rdfs:label : Religious Organization</para>
    ///   <para>rdfs:comment : Organization which offers ideas and opinions about life. Just joking.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ReligiousOrganization">pext:ReligiousOrganization</a>
    /// </summary>
    let ReligiousOrganization = _prefixId.prefix "ReligiousOrganization"
    /// <summary>
    ///   <para>rdfs:label : Report</para>
    ///   <para>rdfs:comment : A document describing the result of some event.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Report">pext:Report</a>
    /// </summary>
    let Report = _prefixId.prefix "Report"
    /// <summary>
    ///   <para>rdfs:label : Reptile</para>
    ///   <para>rdfs:comment : Reptiles are animals in the class Reptilia. They are characterized by breathing air, laying shelled eggs, and having skin covered in scales and/or scutes. Reptiles are classically viewed as having a "cold-blooded" metabolism. They are tetrapods. Modern reptiles inhabit every continent with the exception of Antarctica. Example of an reptile is the crocodile. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Reptile">pext:Reptile</a>
    /// </summary>
    let Reptile = _prefixId.prefix "Reptile"
    /// <summary>
    ///   <para>rdfs:label : Research Area</para>
    ///   <para>rdfs:comment : Specific research area, topic or field.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ResearchArea">pext:ResearchArea</a>
    /// </summary>
    let ResearchArea = _prefixId.prefix "ResearchArea"
    /// <summary>
    ///   <para>rdfs:label : Research Organization</para>
    ///   <para>rdfs:comment : An organization performing scientific research.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ResearchOrganization">pext:ResearchOrganization</a>
    /// </summary>
    let ResearchOrganization = _prefixId.prefix "ResearchOrganization"
    /// <summary>
    ///   <para>rdfs:label : Reserve</para>
    ///   <para>rdfs:comment : (ADL FT) Areas set aside for the preservation of fauna, flora, and their natural habitats. [Macmillan Encyc., 2001] We use this category for agricultural reserves; for conservation areas; for demonstration areas; for environmental areas; for forest reserves; for game management areas; for hunting reserves; for management areas (reserves); for natural areas; for nature reserves; for palm tree reserves; for preserves; for primitive areas; for protected areas; for reservations (nature sites); for road less areas; for sanctuaries (wildlife); for wildlife areas; for wildlife refuges; and for wildlife reserves. NIMA GNS designators RES, RESA, RESF, RESH, RESN, RESP, RESV, RESW.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Reserve">pext:Reserve</a>
    /// </summary>
    let Reserve = _prefixId.prefix "Reserve"
    /// <summary>
    ///   <para>rdfs:label : Reservoir</para>
    ///   <para>rdfs:comment : (ADL FT) Artificially impounded bodies of water. We use this category for covered reservoirs; and for intermittent reservoirs. (incl. dams) NIMA GNS designator RSV, RSVI.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Reservoir">pext:Reservoir</a>
    /// </summary>
    let Reservoir = _prefixId.prefix "Reservoir"
    /// <summary>
    ///   <para>rdfs:label : Resource Collection</para>
    ///   <para>rdfs:comment : A collection is an aggregation of information resources. The term collection means that the resource is described as a group; its parts may be separately described and navigated. (DCMI type Collection)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ResourceCollection">pext:ResourceCollection</a>
    /// </summary>
    let ResourceCollection = _prefixId.prefix "ResourceCollection"
    /// <summary>
    ///   <para>rdfs:label : Restaurant</para>
    ///   <para>rdfs:comment : Any restaurant, a place where food, drink and dessert to customers is prepared and served in return for money. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Restaurant">pext:Restaurant</a>
    /// </summary>
    let Restaurant = _prefixId.prefix "Restaurant"
    /// <summary>
    ///   <para>rdfs:label : Ridge</para>
    ///   <para>rdfs:comment : (ADL FT) Elevations with a narrow, elongated crest which can be part of a hill or mountain. ... We use this category for aretes; for beach ridges; for cuestas; for eskers; for hogbacks; for icecap ridges; for rises (seafloor); and for spurs (physiographic). Omitted ADL sub-classes: Drumlin. NIMA GNS designators RDGB, RDGE, RDGG, RDGU, RISU, SPRU, SPUR.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Ridge">pext:Ridge</a>
    /// </summary>
    let Ridge = _prefixId.prefix "Ridge"
    /// <summary>
    ///   <para>rdfs:label : River</para>
    ///   <para>rdfs:comment : (ADL FT) Natural freshwater surface streams of considerable volume and a permanent or seasonal flow, moving in a definite channel toward a sea, lake, or another river; any large streams, or ones larger than brooks or creeks, such as the trunk stream and larger branches of a drainage system. We use this category for rios. NIM GNS designators ... no direct equivalents!</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#River">pext:River</a>
    /// </summary>
    let River = _prefixId.prefix "River"
    /// <summary>
    ///   <para>rdfs:label : Cutoff</para>
    ///   <para>rdfs:comment : A new channel cut by a river across the neck of an oxbow. NIMA GNS designator H.CUTF.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#RiverCutoff">pext:RiverCutoff</a>
    /// </summary>
    let RiverCutoff = _prefixId.prefix "RiverCutoff"
    /// <summary>
    ///   <para>rdfs:label : Roadway</para>
    ///   <para>rdfs:comment : (ADL FT) Open ways for passage of vehicles. [USGS Circ 1048] We use this category for caravan routes; for causeways; for drives; for highways; for intersections; for parkways; for road bends; for road cuts; for road junctions; for roads; for streets; and for traffic circles. NIMA GNS designators CSWY, CSWYQ, RD, RDA, RDB, RDCUT, RDJCT, RDST, RTE, STKR.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Roadway">pext:Roadway</a>
    /// </summary>
    let Roadway = _prefixId.prefix "Roadway"
    /// <summary>
    ///   <para>rdfs:label : Rugby Club</para>
    ///   <para>rdfs:comment : A rugby teamrdfs:comment : A sport club that organizes the playing of rugby.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#RugbyClub">pext:RugbyClub</a>
    /// </summary>
    let RugbyClub = _prefixId.prefix "RugbyClub"
    /// <summary>
    ///   <para>rdfs:label : Rugby League</para>
    ///   <para>rdfs:comment : Any Rugby League</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#RugbyLeague">pext:RugbyLeague</a>
    /// </summary>
    let RugbyLeague = _prefixId.prefix "RugbyLeague"
    let RugbyPlayer = _prefixId.prefix "RugbyPlayer"
    /// <summary>
    ///   <para>rdfs:label : Saddle</para>
    ///   <para>rdfs:comment : A low part, resembling in shape a saddle, in a ridge or between contiguous seamounts</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Saddleback">pext:Saddleback</a>
    /// </summary>
    let Saddleback = _prefixId.prefix "Saddleback"
    /// <summary>
    ///   <para>rdfs:label : Saint</para>
    ///   <para>rdfs:comment : Any saint, a holy person, in whom Christ dwells, whether in heaven or in earth.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Saint">pext:Saint</a>
    /// </summary>
    let Saint = _prefixId.prefix "Saint"
    /// <summary>
    ///   <para>rdfs:label : Sale</para>
    ///   <para>rdfs:comment : Any event in which a participant is receiving a good from another participant of the event on the basis of some payment.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Sale">pext:Sale</a>
    /// </summary>
    let Sale = _prefixId.prefix "Sale"
    /// <summary>
    ///   <para>rdfs:label : Satellite</para>
    ///   <para>rdfs:comment : An astronomic object orbiting around a planet or star. Definition partly derived from WordNet 1.7</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Satellite">pext:Satellite</a>
    /// </summary>
    let Satellite = _prefixId.prefix "Satellite"
    /// <summary>
    ///   <para>rdfs:label : School</para>
    ///   <para>rdfs:comment : An education organization teaching pupils from first grade to tenth/eleventh/twelfth grade. It could be a primary school, or a secondary school.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#School">pext:School</a>
    /// </summary>
    let School = _prefixId.prefix "School"
    /// <summary>
    ///   <para>rdfs:label : Science</para>
    ///   <para>rdfs:comment : A well established, big research area</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Science">pext:Science</a>
    /// </summary>
    let Science = _prefixId.prefix "Science"
    let Scientist = _prefixId.prefix "Scientist"
    /// <summary>
    ///   <para>rdfs:label : Scrubland</para>
    ///   <para>rdfs:comment : An area of low trees, bushes, and shrubs stunted by some environmental limitation</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Scrubland">pext:Scrubland</a>
    /// </summary>
    let Scrubland = _prefixId.prefix "Scrubland"
    /// <summary>
    ///   <para>rdfs:label : Sculpture</para>
    ///   <para>rdfs:comment : Any sculpture, three-dimensional artwork created by shaping or combining hard materials. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Sculpture">pext:Sculpture</a>
    /// </summary>
    let Sculpture = _prefixId.prefix "Sculpture"
    /// <summary>
    ///   <para>rdfs:label : Sea</para>
    ///   <para>rdfs:comment : (ADL FT) Large bodies of salt water. NIMA GNS designator SEA</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Sea">pext:Sea</a>
    /// </summary>
    let Sea = _prefixId.prefix "Sea"
    /// <summary>
    ///   <para>rdfs:label : Sound</para>
    ///   <para>rdfs:comment : A long arm of the sea forming a channel between the mainland and an island or islands; or connecting two larger bodies of water. NIMA GNS designator H.SD.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SeaSound">pext:SeaSound</a>
    /// </summary>
    let SeaSound = _prefixId.prefix "SeaSound"
    /// <summary>
    ///   <para>rdfs:label : Tongue</para>
    ///   <para>rdfs:comment : An elongate (tongue-like) extension of a flat sea floor into an adjacent higher feature</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SeaTongue">pext:SeaTongue</a>
    /// </summary>
    let SeaTongue = _prefixId.prefix "SeaTongue"
    /// <summary>
    ///   <para>rdfs:label : Trench</para>
    ///   <para>rdfs:comment : A long, narrow, characteristically very deep and asymmetrical depression of the sea floor, with relatively steep sides</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SeaTrench">pext:SeaTrench</a>
    /// </summary>
    let SeaTrench = _prefixId.prefix "SeaTrench"
    /// <summary>
    ///   <para>rdfs:label : Trough</para>
    ///   <para>rdfs:comment : A long depression of the sea floor characteristically flat bottomed and steep sided, and normally shallower than a trench</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SeaTrough">pext:SeaTrough</a>
    /// </summary>
    let SeaTrough = _prefixId.prefix "SeaTrough"
    /// <summary>
    ///   <para>rdfs:label : Seachannels</para>
    ///   <para>rdfs:comment : Continuously sloping, elongated depressions commonly found in fans or plains and customarily bordered by levees on one or two sides (U.SCSU; U.SCSU)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Seachannels">pext:Seachannels</a>
    /// </summary>
    let Seachannels = _prefixId.prefix "Seachannels"
    /// <summary>
    ///   <para>rdfs:label : Seamount</para>
    ///   <para>rdfs:comment : An elevation rising generally more than 1,000 meters and of limited extent across the summit. (U.SMSU; U.SMU)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Seamount">pext:Seamount</a>
    /// </summary>
    let Seamount = _prefixId.prefix "Seamount"
    /// <summary>
    ///   <para>rdfs:label : Season</para>
    ///   <para>rdfs:comment : One of the seasons of the year. In the places with a temperate climate there are four seasons: spring, summer, autumn, and winter.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Season">pext:Season</a>
    /// </summary>
    let Season = _prefixId.prefix "Season"
    /// <summary>
    ///   <para>rdfs:label : Section^^xsd:string</para>
    ///   <para>rdfs:comment : An area of a document that can be considered a document in itself. Compare with pext:Mention, which is also an area of a document. Imported from the iSIM ontology.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Section">pext:Section</a>
    /// </summary>
    let Section = _prefixId.prefix "Section"
    let Senator = _prefixId.prefix "Senator"
    /// <summary>
    ///   <para>rdfs:label : Settlement</para>
    ///   <para>rdfs:comment : Describes a populated place with organisation, like city, village, town</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Settlement">pext:Settlement</a>
    /// </summary>
    let Settlement = _prefixId.prefix "Settlement"
    /// <summary>
    ///   <para>rdfs:label : Ship</para>
    ///   <para>rdfs:comment : A vehicle which moves on water.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Ship">pext:Ship</a>
    /// </summary>
    let Ship = _prefixId.prefix "Ship"
    /// <summary>
    ///   <para>rdfs:label : Shoal</para>
    ///   <para>rdfs:comment : Hazards to surface navigation composed of unconsolidated material. (U.SHSU; U.SHLU)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Shoal">pext:Shoal</a>
    /// </summary>
    let Shoal = _prefixId.prefix "Shoal"
    /// <summary>
    ///   <para>rdfs:label : Shopping Mall</para>
    ///   <para>rdfs:comment : Any Shopping Mall, a building which is a shopping mall</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ShoppingMall">pext:ShoppingMall</a>
    /// </summary>
    let ShoppingMall = _prefixId.prefix "ShoppingMall"
    /// <summary>
    ///   <para>rdfs:label : Single</para>
    ///   <para>rdfs:comment : A representative for a musician album.rdfs:comment : Any Single Album</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SingleAlbum">pext:SingleAlbum</a>
    /// </summary>
    let SingleAlbum = _prefixId.prefix "SingleAlbum"
    /// <summary>
    ///   <para>rdfs:label : Single</para>
    ///   <para>rdfs:comment : A representative for an album or a musician song.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SingleSong">pext:SingleSong</a>
    /// </summary>
    let SingleSong = _prefixId.prefix "SingleSong"
    /// <summary>
    ///   <para>rdfs:label : Single</para>
    ///   <para>rdfs:comment : Any Single Song and Album</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SingleSongOrAlbum">pext:SingleSongOrAlbum</a>
    /// </summary>
    let SingleSongOrAlbum = _prefixId.prefix "SingleSongOrAlbum"

    /// <summary>
    ///   <para>rdfs:label : Site of Special Scientific Interest</para>
    ///   <para>rdfs:comment : Any sites of special scientific interest, a place with scientific value, where some scientific activities or experiments are carried out, or which is observed for scientific reasons.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SiteOfSpecialScientificInterest">pext:SiteOfSpecialScientificInterest</a>
    /// </summary>
    let SiteOfSpecialScientificInterest =
        _prefixId.prefix "SiteOfSpecialScientificInterest"

    /// <summary>
    ///   <para>rdfs:label : Ski Area</para>
    ///   <para>rdfs:comment : Any Ski Area, a mounatain area (usually) where there re ski resorts or one can ski.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SkiArea">pext:SkiArea</a>
    /// </summary>
    let SkiArea = _prefixId.prefix "SkiArea"
    /// <summary>
    ///   <para>rdfs:label : Skyscraper</para>
    ///   <para>rdfs:comment : Any Skyscraper, a highrise building, usually in downtown city areas.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Skyscraper">pext:Skyscraper</a>
    /// </summary>
    let Skyscraper = _prefixId.prefix "Skyscraper"
    let SnookerPlayer = _prefixId.prefix "SnookerPlayer"
    /// <summary>
    ///   <para>rdfs:label : Soccer Club</para>
    ///   <para>rdfs:comment : A soccer (football) teamrdfs:comment : A sport club that organizes the playing of soccer.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SoccerClub">pext:SoccerClub</a>
    /// </summary>
    let SoccerClub = _prefixId.prefix "SoccerClub"
    /// <summary>
    ///   <para>rdfs:label : Soccer League</para>
    ///   <para>rdfs:comment : Any Soccer league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SoccerLeague">pext:SoccerLeague</a>
    /// </summary>
    let SoccerLeague = _prefixId.prefix "SoccerLeague"
    let SoccerManager = _prefixId.prefix "SoccerManager"
    let SoccerPlayer = _prefixId.prefix "SoccerPlayer"
    /// <summary>
    ///   <para>rdfs:label : Social Abstraction</para>
    ///   <para>rdfs:comment : Any sort of general social phenomenon, such as particular sort of art or science</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SocialAbstraction">pext:SocialAbstraction</a>
    /// </summary>
    let SocialAbstraction = _prefixId.prefix "SocialAbstraction"
    /// <summary>
    ///   <para>rdfs:label : Social Function</para>
    ///   <para>rdfs:comment : The name of a function a person has in the society like nobely, job title, celebrity, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SocialFunction">pext:SocialFunction</a>
    /// </summary>
    let SocialFunction = _prefixId.prefix "SocialFunction"
    /// <summary>
    ///   <para>rdfs:label : Softball League</para>
    ///   <para>rdfs:comment : Any Softball league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SoftballLeague">pext:SoftballLeague</a>
    /// </summary>
    let SoftballLeague = _prefixId.prefix "SoftballLeague"
    /// <summary>
    ///   <para>rdfs:label : Software</para>
    ///   <para>rdfs:comment : Software is a collection of computer programs and related data that provide the instructions telling a computer what to do. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Software">pext:Software</a>
    /// </summary>
    let Software = _prefixId.prefix "Software"
    /// <summary>
    ///   <para>rdfs:label : Software Agent^^xsd:string</para>
    ///   <para>rdfs:comment : An artificial agent which operates in a software environment.^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SoftwareAgent">pext:SoftwareAgent</a>
    /// </summary>
    let SoftwareAgent = _prefixId.prefix "SoftwareAgent"
    /// <summary>
    ///   <para>rdfs:label : Song</para>
    ///   <para>rdfs:comment : An recording of a song.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Song">pext:Song</a>
    /// </summary>
    let Song = _prefixId.prefix "Song"
    /// <summary>
    ///   <para>rdfs:label : Space Mission</para>
    ///   <para>rdfs:comment : Any Mission in space in which space shuttles or space crafts are involved.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SpaceMission">pext:SpaceMission</a>
    /// </summary>
    let SpaceMission = _prefixId.prefix "SpaceMission"
    /// <summary>
    ///   <para>rdfs:label : Space Shuttle</para>
    ///   <para>rdfs:comment : A Spaceshuttle is a reusable launch system and orbital spacecraft operated by the U.S. National Aeronautics and Space Administration (NASA) (Wikipedia).</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SpaceShuttle">pext:SpaceShuttle</a>
    /// </summary>
    let SpaceShuttle = _prefixId.prefix "SpaceShuttle"
    /// <summary>
    ///   <para>rdfs:label : Space Station</para>
    ///   <para>rdfs:comment : Any Spacestation. A space station (also called an orbital station) is a manned satellite designed to remain in space. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SpaceStation">pext:SpaceStation</a>
    /// </summary>
    let SpaceStation = _prefixId.prefix "SpaceStation"
    /// <summary>
    ///   <para>rdfs:label : Spacecraft</para>
    ///   <para>rdfs:comment : [WN1.7] Space vehicle - a craft capable of traveling in outer space; technically a satellite around the sun.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Spacecraft">pext:Spacecraft</a>
    /// </summary>
    let Spacecraft = _prefixId.prefix "Spacecraft"
    /// <summary>
    ///   <para>rdfs:label : Speedway League</para>
    ///   <para>rdfs:comment : Any Speedway league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SpeedwayLeague">pext:SpeedwayLeague</a>
    /// </summary>
    let SpeedwayLeague = _prefixId.prefix "SpeedwayLeague"
    /// <summary>
    ///   <para>rdfs:label : Speedway team</para>
    ///   <para>rdfs:comment : Any speedway team</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SpeedwayTeam">pext:SpeedwayTeam</a>
    /// </summary>
    let SpeedwayTeam = _prefixId.prefix "SpeedwayTeam"
    /// <summary>
    ///   <para>rdfs:label : Sport</para>
    ///   <para>rdfs:comment : A specific type of sport game</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Sport">pext:Sport</a>
    /// </summary>
    let Sport = _prefixId.prefix "Sport"
    /// <summary>
    ///   <para>rdfs:label : Sport Building</para>
    ///   <para>rdfs:comment : A building providing facilities for practice of sport(s).</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SportBuilding">pext:SportBuilding</a>
    /// </summary>
    let SportBuilding = _prefixId.prefix "SportBuilding"
    /// <summary>
    ///   <para>rdfs:label : Sport Club</para>
    ///   <para>rdfs:comment : A sports club, football club or F1 team. Those should be considered commercial although in many cases they are not run for profit.rdfs:comment : An organization arranging the practice of some sports by teams or individuals.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SportClub">pext:SportClub</a>
    /// </summary>
    let SportClub = _prefixId.prefix "SportClub"
    /// <summary>
    ///   <para>rdfs:label : Sport Event</para>
    ///   <para>rdfs:comment : An event involving use, maintain or improve of physical fitness of its participants. Usually it is organized.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SportEvent">pext:SportEvent</a>
    /// </summary>
    let SportEvent = _prefixId.prefix "SportEvent"
    /// <summary>
    ///   <para>rdfs:label : Sport Facility</para>
    ///   <para>rdfs:comment : (ADL FT) Fields, centers, or open areas maintained for the purpose of holding sporting events and activities. [USGS Circ 1048] We use this category for aquatic centers; for arenas; for athletic complexes; for athletic fields; for ball parks; for baseball fields; for dragways; for equestrian centers; for fields; for football fields; for golf clubs; for golf courses; for gymnasiums; for natatoriums; for physical education facilities; for pistol ranges (sport); for polo fields; for pools, swimming; for race tracks; for racecourses; for racetracks; for raceways; for rifle ranges; for rodeo grounds; for shooting ranges (sport); for skeet shooting ranges; for ski areas; for ski facilities; for ski trails; for speedways; for stadiums; for swim clubs; for swimming pools; for tennis clubs; and for tennis courts. NIMA GNS designators RECG, RECR, STDM, ATHF.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SportFacility">pext:SportFacility</a>
    /// </summary>
    let SportFacility = _prefixId.prefix "SportFacility"
    /// <summary>
    ///   <para>rdfs:label : Sport Game</para>
    ///   <para>rdfs:comment : A sport game is any instance of a sport event, where teams or individuals gather to play according to particular predetermined rules, such as soccer match, tennis match, car race, etc. It can also denote the activity of playing a particular sport game.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SportGame">pext:SportGame</a>
    /// </summary>
    let SportGame = _prefixId.prefix "SportGame"
    /// <summary>
    ///   <para>rdfs:label : Sport Game Point</para>
    ///   <para>rdfs:comment : Denotes a point scored in a given sport game.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SportGamePoint">pext:SportGamePoint</a>
    /// </summary>
    let SportGamePoint = _prefixId.prefix "SportGamePoint"
    /// <summary>
    ///   <para>rdfs:label : Sport Organization</para>
    ///   <para>rdfs:comment : An organization (local, national or international) which main activity is related to one or more sports. Those could be clubs, as well, as all the sorts of federations.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SportOrganization">pext:SportOrganization</a>
    /// </summary>
    let SportOrganization = _prefixId.prefix "SportOrganization"
    /// <summary>
    ///   <para>rdfs:label : Sports Federation</para>
    ///   <para>rdfs:comment : An organization representing which controls the practice of some sport on national, regional or international level.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SportsFederation">pext:SportsFederation</a>
    /// </summary>
    let SportsFederation = _prefixId.prefix "SportsFederation"
    /// <summary>
    ///   <para>rdfs:label : Sports League</para>
    ///   <para>rdfs:comment : Any sports league, a group of sports teams or individual athletes that compete against each other in a specific sport. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#SportsLeague">pext:SportsLeague</a>
    /// </summary>
    let SportsLeague = _prefixId.prefix "SportsLeague"
    /// <summary>
    ///   <para>rdfs:label : Sportsman</para>
    ///   <para>rdfs:comment : A profession of a person involved in a sport.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Sportsman">pext:Sportsman</a>
    /// </summary>
    let Sportsman = _prefixId.prefix "Sportsman"
    /// <summary>
    ///   <para>rdfs:label : Spring</para>
    ///   <para>rdfs:comment : (ADL FT) Places where underground water flows naturally to the surface of the Earth. ... We use this category for mineral springs; and for sulfur springs. NIMA GNS designators SPNG, SPNS, SPNT.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Spring">pext:Spring</a>
    /// </summary>
    let Spring = _prefixId.prefix "Spring"
    /// <summary>
    ///   <para>rdfs:label : Stadium</para>
    ///   <para>rdfs:comment : A special sort of sport building, usually for open-air sports such as soccer.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Stadium">pext:Stadium</a>
    /// </summary>
    let Stadium = _prefixId.prefix "Stadium"
    /// <summary>
    ///   <para>rdfs:label : Star</para>
    ///   <para>rdfs:comment : An astronomic object of hot gases that radiates energy derived from thermonuclear reactions in the interior. Definition partly derived from WordNet 1.7</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Star">pext:Star</a>
    /// </summary>
    let Star = _prefixId.prefix "Star"
    /// <summary>
    ///   <para>rdfs:label : Station</para>
    ///   <para>rdfs:comment : Any station, a place where busses, trains, sheeps, boats, etc. stop, like railway station, bussstop, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Station">pext:Station</a>
    /// </summary>
    let Station = _prefixId.prefix "Station"
    /// <summary>
    ///   <para>rdfs:label : Stock Exchange</para>
    ///   <para>rdfs:comment : Stock Exchange where public companies are traded, e. g. Nasdaq, NYSE, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#StockExchange">pext:StockExchange</a>
    /// </summary>
    let StockExchange = _prefixId.prefix "StockExchange"
    /// <summary>
    ///   <para>rdfs:label : Stock Exchange Index</para>
    ///   <para>rdfs:comment : A stock exchange/market index is a method of measuring a section of the stock market. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#StockExchangeIndex">pext:StockExchangeIndex</a>
    /// </summary>
    let StockExchangeIndex = _prefixId.prefix "StockExchangeIndex"
    /// <summary>
    ///   <para>rdfs:label : Stream</para>
    ///   <para>rdfs:comment : (ADL FT) Linear bodies of water flowing on the Earth's surface. We use this category for anabranches; for brooks; for burns (hydrographic); for confluences; for creeks; for distributaries; for dry stream beds; for forks (physiographic features); for intermittent streams; for lost rivers; for meanders; for stream bends; for stream mouths; for tidal creeks; for tributaries; and for watercourses. NIMA GNS designators STM, STMA, STMB, STMC, STMD, STMH, STMI, STMIX, STMM, STMQ, STMS, STMSB, STMX</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Stream">pext:Stream</a>
    /// </summary>
    let Stream = _prefixId.prefix "Stream"
    /// <summary>
    ///   <para>rdfs:label : Street</para>
    ///   <para>rdfs:comment : The general notion for a roadway within a city or village, often, surrounded by buildings. We put here boulevards, streets, avenues, etc. NIMA GNS designator - missing.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Street">pext:Street</a>
    /// </summary>
    let Street = _prefixId.prefix "Street"
    /// <summary>
    ///   <para>rdfs:label : Street Name</para>
    ///   <para>rdfs:comment : Part of a postal address denoting the street name.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#StreetName">pext:StreetName</a>
    /// </summary>
    let StreetName = _prefixId.prefix "StreetName"
    /// <summary>
    ///   <para>rdfs:label : Street Number</para>
    ///   <para>rdfs:comment : Part of a postal address denoting the street number.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#StreetNumber">pext:StreetNumber</a>
    /// </summary>
    let StreetNumber = _prefixId.prefix "StreetNumber"
    let Swimmer = _prefixId.prefix "Swimmer"
    /// <summary>
    ///   <para>rdfs:label : TV Channel</para>
    ///   <para>rdfs:comment : A brand of a television channel.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#TVChannel">pext:TVChannel</a>
    /// </summary>
    let TVChannel = _prefixId.prefix "TVChannel"
    /// <summary>
    ///   <para>rdfs:label : TV company</para>
    ///   <para>rdfs:comment : A company that broadcasts audio and video content.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#TVCompany">pext:TVCompany</a>
    /// </summary>
    let TVCompany = _prefixId.prefix "TVCompany"
    /// <summary>
    ///   <para>rdfs:label : Team</para>
    ///   <para>rdfs:comment : A group of people gathered for some task, say a project. Teams are usually not formally established and not meant to perform as a single agent for purposes outside the scope of their task. Teams may "live" within organizations, spread between multiple organizations, or be independent form any organization.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Team">pext:Team</a>
    /// </summary>
    let Team = _prefixId.prefix "Team"
    /// <summary>
    ///   <para>rdfs:label : Telecom</para>
    ///   <para>rdfs:comment : A telecommunications company</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Telecom">pext:Telecom</a>
    /// </summary>
    let Telecom = _prefixId.prefix "Telecom"
    /// <summary>
    ///   <para>rdfs:label : Telecom Facility</para>
    ///   <para>rdfs:comment : (ADL FT: Telecommunication Features) We use this category for antenna field sites; for communication centers; for radio stations; for television stations; and for transmission lines. NIMA GNS designators COMC, STNR, STNS.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#TelecomFacility">pext:TelecomFacility</a>
    /// </summary>
    let TelecomFacility = _prefixId.prefix "TelecomFacility"
    /// <summary>
    ///   <para>rdfs:label : Television Episode</para>
    ///   <para>rdfs:comment : Denotes any episod of any television series.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#TelevisionEpisode">pext:TelevisionEpisode</a>
    /// </summary>
    let TelevisionEpisode = _prefixId.prefix "TelevisionEpisode"
    /// <summary>
    ///   <para>rdfs:label : Television Product</para>
    ///   <para>rdfs:comment : Denotes programms produced in the television and for television airing.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#TelevisionProduct">pext:TelevisionProduct</a>
    /// </summary>
    let TelevisionProduct = _prefixId.prefix "TelevisionProduct"
    /// <summary>
    ///   <para>rdfs:label : Television Show</para>
    ///   <para>rdfs:comment : Any television show</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#TelevisionShow">pext:TelevisionShow</a>
    /// </summary>
    let TelevisionShow = _prefixId.prefix "TelevisionShow"
    /// <summary>
    ///   <para>rdfs:label : Temporal Abstraction</para>
    ///   <para>rdfs:comment : Any sort of abstraction used to refer to specific periods of time. Thus, the month of September is an instance of this class, while Sept 1989 is not (it is a specific TimeInterval, and thus not abstract)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#TemporalAbstraction">pext:TemporalAbstraction</a>
    /// </summary>
    let TemporalAbstraction = _prefixId.prefix "TemporalAbstraction"
    /// <summary>
    ///   <para>rdfs:label : Tennis League</para>
    ///   <para>rdfs:comment : Any Tennis league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#TennisLeague">pext:TennisLeague</a>
    /// </summary>
    let TennisLeague = _prefixId.prefix "TennisLeague"
    let TennisPlayer = _prefixId.prefix "TennisPlayer"
    /// <summary>
    ///   <para>rdfs:label : Territory</para>
    ///   <para>rdfs:comment : Territory a region of land which can be a part of contry that is non-sovereign or a geographic region determined by some charateristics. (Wikipedia) (http://www.eionet.europa.eu/gemet/concept?ns=1&amp;cp=8401. NIMA GNS designator A.TERR.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Territory">pext:Territory</a>
    /// </summary>
    let Territory = _prefixId.prefix "Territory"
    /// <summary>
    ///   <para>rdfs:label : Theatre Performance</para>
    ///   <para>rdfs:comment : An art performance following a stage play.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#TheatrePerformance">pext:TheatrePerformance</a>
    /// </summary>
    let TheatrePerformance = _prefixId.prefix "TheatrePerformance"
    /// <summary>
    ///   <para>rdfs:label : Time Zone</para>
    ///   <para>rdfs:comment : A time zone is a region on Earth that has a uniform standard time for legal, commercial, and social purposes. Wikipedia.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#TimeZone">pext:TimeZone</a>
    /// </summary>
    let TimeZone = _prefixId.prefix "TimeZone"
    /// <summary>
    ///   <para>rdfs:label : Tournament</para>
    ///   <para>rdfs:comment : A Tournament which is held regularly at particular time intervals, every year, every week, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Tournament">pext:Tournament</a>
    /// </summary>
    let Tournament = _prefixId.prefix "Tournament"
    /// <summary>
    ///   <para>rdfs:label : Tournament</para>
    ///   <para>rdfs:comment : A Tournament held at a particular time</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#TournamentOccurrence">pext:TournamentOccurrence</a>
    /// </summary>
    let TournamentOccurrence = _prefixId.prefix "TournamentOccurrence"
    /// <summary>
    ///   <para>rdfs:label : Tower</para>
    ///   <para>rdfs:comment : (ADL FT) Manmade structures, higher than their diameter, generally used for observation, storage, or electronic transmission. We use this category for carillons; for fire lookouts; and for pagodas. NIMA GNS designator TOWR.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Tower">pext:Tower</a>
    /// </summary>
    let Tower = _prefixId.prefix "Tower"
    /// <summary>
    ///   <para>rdfs:label : Town</para>
    ///   <para>rdfs:comment : Any town</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Town">pext:Town</a>
    /// </summary>
    let Town = _prefixId.prefix "Town"
    /// <summary>
    ///   <para>rdfs:label : Trade Union</para>
    ///   <para>rdfs:comment : Any Trade Union, an organization of workers that have banded together to achieve common goals such as better working conditions. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#TradeUnion">pext:TradeUnion</a>
    /// </summary>
    let TradeUnion = _prefixId.prefix "TradeUnion"
    /// <summary>
    ///   <para>rdfs:label : Transport Facility</para>
    ///   <para>rdfs:comment : (ADL FT: Transportation Features) We use this category for air routes; for caravan routes; for corridors; for crossings; for depots; for ferries; for fords (crossings); for fuel depots; for gates (manmade); for halting places (transportation); for highway maintenance sites; for portages; for rest houses; for routes; for ship tracks; for stock routes; for terminals (transportation); and for transit facilities. Omitted sub-classes: Aqueducts, Cableways, Parking Sites. NIMA GNS designator - no direct equivalents.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#TransportFacility">pext:TransportFacility</a>
    /// </summary>
    let TransportFacility = _prefixId.prefix "TransportFacility"
    /// <summary>
    ///   <para>rdfs:label : Tundra</para>
    ///   <para>rdfs:comment : (ADL FT) Treeless, level, or gently rolling plains characteristic of arctic or subarctic regions, having a permanently frozen subsoil, and usually supporting low growing vegetation such as lichens, mosses, and stunted shrubs. [USGS Circ 1048] We use this category for Arctic land. NIMA GNS designator TUND, LAND.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Tundra">pext:Tundra</a>
    /// </summary>
    let Tundra = _prefixId.prefix "Tundra"
    /// <summary>
    ///   <para>rdfs:label : Tunnel</para>
    ///   <para>rdfs:comment : (ADL FT) Underground or underwater passages. [USGS Circ 1048] We use this category for canal tunnels; for railroad tunnels; and for road tunnels. NIMA GNS designator TNL, TNLC, TNLN, TNLRD, TNLS</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Tunnel">pext:Tunnel</a>
    /// </summary>
    let Tunnel = _prefixId.prefix "Tunnel"
    /// <summary>
    ///   <para>rdfs:label : University</para>
    ///   <para>rdfs:comment : An educational organization higher than school.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#University">pext:University</a>
    /// </summary>
    let University = _prefixId.prefix "University"
    /// <summary>
    ///   <para>rdfs:label : Urban District</para>
    ///   <para>rdfs:comment : (ADL FT: Countries, 3rd order divisions) Minor civil units. [USGS Circ 1048] We use this category for barrios; for precincts; for third-order administrative divisions; and for townships. NIMA GNS designator ADM3.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#UrbanDistrict">pext:UrbanDistrict</a>
    /// </summary>
    let UrbanDistrict = _prefixId.prefix "UrbanDistrict"
    /// <summary>
    ///   <para>rdfs:label : User^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#User">pext:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>rdfs:label : User Profile^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#UserProfile">pext:UserProfile</a>
    /// </summary>
    let UserProfile = _prefixId.prefix "UserProfile"
    /// <summary>
    ///   <para>rdfs:label : Valley</para>
    ///   <para>rdfs:comment : (ADL FT) Low-lying land bordered by higher ground; especially elongate, relatively large gently sloping depressions of the Earth's surface, commonly situated between two mountains or between ranges of hills or mountains, and often containing a stream with an outlet. [Glossary of Geology, 4th ed.] We use this category for forks (physiographic features); for glens; for hanging valleys; for hollows; for median valleys; and for shelf valleys (seafloor). NIMA GNS designators VAL, VALG, VALU, VALS, VALX, VLSU, FRKU, FRSU, MDVU, SHVU.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Valley">pext:Valley</a>
    /// </summary>
    let Valley = _prefixId.prefix "Valley"
    /// <summary>
    ///   <para>rdfs:label : Vehicle</para>
    ///   <para>rdfs:comment : Any sort of specific vehicle, mean of transportation.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Vehicle">pext:Vehicle</a>
    /// </summary>
    let Vehicle = _prefixId.prefix "Vehicle"
    /// <summary>
    ///   <para>rdfs:label : Vein</para>
    ///   <para>rdfs:comment : Vein is a general concept gathering all veins of a body.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Vein">pext:Vein</a>
    /// </summary>
    let Vein = _prefixId.prefix "Vein"
    let VicePresident = _prefixId.prefix "VicePresident"
    let VicePrimeMinister = _prefixId.prefix "VicePrimeMinister"
    /// <summary>
    ///   <para>rdfs:label : Video Game</para>
    ///   <para>rdfs:comment : Any electronic game that involves interaction with a user interface to generate visual feedback on a video device. (Wikipedia)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#VideoGame">pext:VideoGame</a>
    /// </summary>
    let VideoGame = _prefixId.prefix "VideoGame"
    /// <summary>
    ///   <para>rdfs:label : Videogames League</para>
    ///   <para>rdfs:comment : Any Videogames league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#VideogamesLeague">pext:VideogamesLeague</a>
    /// </summary>
    let VideogamesLeague = _prefixId.prefix "VideogamesLeague"
    /// <summary>
    ///   <para>rdfs:label : Village</para>
    ///   <para>rdfs:comment : Any village</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Village">pext:Village</a>
    /// </summary>
    let Village = _prefixId.prefix "Village"
    /// <summary>
    ///   <para>rdfs:label : Vineyard</para>
    ///   <para>rdfs:comment : Plantings of grapevines</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Vineyard">pext:Vineyard</a>
    /// </summary>
    let Vineyard = _prefixId.prefix "Vineyard"
    /// <summary>
    ///   <para>rdfs:label : Volcano</para>
    ///   <para>rdfs:comment : (ADL FT) Vents in the surface of the Earth through which magma and associated gases erupt; also, the forms or structures, usually conical, that are produced by the erupted material. NIMA GNS designator VLC.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Volcano">pext:Volcano</a>
    /// </summary>
    let Volcano = _prefixId.prefix "Volcano"
    /// <summary>
    ///   <para>rdfs:label : Volleyball League</para>
    ///   <para>rdfs:comment : Any Volleyball league</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#VolleyballLeague">pext:VolleyballLeague</a>
    /// </summary>
    let VolleyballLeague = _prefixId.prefix "VolleyballLeague"
    let VolleyballPlayer = _prefixId.prefix "VolleyballPlayer"
    /// <summary>
    ///   <para>rdfs:label : Wadi</para>
    ///   <para>rdfs:comment : A valley or ravine, bounded by relatively steep banks. NIMA GNS designator H.WAD, H.WADB, H.WADJ, H.WADM, H.WADS, H.WADX.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Wadi">pext:Wadi</a>
    /// </summary>
    let Wadi = _prefixId.prefix "Wadi"
    /// <summary>
    ///   <para>rdfs:label : Water Bank</para>
    ///   <para>rdfs:comment : (ADL FT: Banks) Sloping margins of, or the ground bordering, a stream, and serving to confine the water to the natural channel during the normal course of flow. [Glossary of Geology, 4th ed.] We use this category for stream banks. NIMA GNS designator BKSU, BNK, BNKR, BNKU, BNKX.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#WaterBank">pext:WaterBank</a>
    /// </summary>
    let WaterBank = _prefixId.prefix "WaterBank"
    /// <summary>
    ///   <para>rdfs:label : Current</para>
    ///   <para>rdfs:comment : A net transport of ocean water along a definable path. http://www.eionet.europa.eu/gemet/concept/5792 NIMA GNS designator H.CRNT.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#WaterCurrent">pext:WaterCurrent</a>
    /// </summary>
    let WaterCurrent = _prefixId.prefix "WaterCurrent"
    /// <summary>
    ///   <para>rdfs:label : Reach</para>
    ///   <para>rdfs:comment : A straight section of a navigable stream or channel between two bends. NIMA GNS designator H.RCH.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#WaterReach">pext:WaterReach</a>
    /// </summary>
    let WaterReach = _prefixId.prefix "WaterReach"
    /// <summary>
    ///   <para>rdfs:label : Water Region</para>
    ///   <para>rdfs:comment : (ADL FT: Hydrographic Features) For natural bodies of water. For constructed waterways, reservoirs, and such, use 'hydrographic structures'. We use this category for bodies of water; for eddies; for fluvial features; for marine features; for overfalls; for upwellings; for water bodies; for waterholes; and for whirlpools. Many of the ADL hydrographic features ignored. NIMA GNS class H.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#WaterRegion">pext:WaterRegion</a>
    /// </summary>
    let WaterRegion = _prefixId.prefix "WaterRegion"
    /// <summary>
    ///   <para>rdfs:label : Water Tank</para>
    ///   <para>rdfs:comment : A contained pool or tank of water at, below, or above ground level. NIMA GNS designator H.RSVT.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#WaterTank">pext:WaterTank</a>
    /// </summary>
    let WaterTank = _prefixId.prefix "WaterTank"
    /// <summary>
    ///   <para>rdfs:label : Watercourse</para>
    ///   <para>rdfs:comment : A natural, well-defined channel produced by flowing water, or an artificial channel designed to carry flowing water. NIMA GNS designator H.WTRC.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Watercourse">pext:Watercourse</a>
    /// </summary>
    let Watercourse = _prefixId.prefix "Watercourse"
    /// <summary>
    ///   <para>rdfs:label : Waterfalls</para>
    ///   <para>rdfs:comment : (ADL FT) Perpendicular or very steep falls of water in the course of a stream. ... We use this category for cascades; for cataracts; and for falls. NIMA GNS designator FLLS, FLLSX</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Waterfalls">pext:Waterfalls</a>
    /// </summary>
    let Waterfalls = _prefixId.prefix "Waterfalls"
    /// <summary>
    ///   <para>rdfs:label : Waterhole</para>
    ///   <para>rdfs:comment : A natural hole, hollow, or small depression that contains water, used by man and animals, especially in arid areas. NIMA GNS designator H.WTRH.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Waterhole">pext:Waterhole</a>
    /// </summary>
    let Waterhole = _prefixId.prefix "Waterhole"
    /// <summary>
    ///   <para>rdfs:label : Weapon Model or System</para>
    ///   <para>rdfs:comment : A concrete model of a weapon that determines its main features. For example, Patriot, SU-28, and Kalashnikov.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#WeaponModelOrSystem">pext:WeaponModelOrSystem</a>
    /// </summary>
    let WeaponModelOrSystem = _prefixId.prefix "WeaponModelOrSystem"
    /// <summary>
    ///   <para>rdfs:label : Web Page</para>
    ///   <para>rdfs:comment : The internet address of a web page on the net.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#WebPage">pext:WebPage</a>
    /// </summary>
    let WebPage = _prefixId.prefix "WebPage"
    /// <summary>
    ///   <para>rdfs:label : Week</para>
    ///   <para>rdfs:comment : A specific week of a specific year (say the 41st of 2001)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Week">pext:Week</a>
    /// </summary>
    let Week = _prefixId.prefix "Week"
    /// <summary>
    ///   <para>rdfs:label : Well</para>
    ///   <para>rdfs:comment : A cylindrical hole, pit, or tunnel drilled or dug down to a depth from which water, oil, or gas can be pumped or brought to the surface. NIMA GNS designator H.WLL, H.WLLQ, H.WLLS.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Well">pext:Well</a>
    /// </summary>
    let Well = _prefixId.prefix "Well"
    /// <summary>
    ///   <para>rdfs:label : Whirlpool</para>
    ///   <para>rdfs:comment : A turbulent, rotating movement of water in a stream. NIMA GNS designator H.WHRL.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Whirlpool">pext:Whirlpool</a>
    /// </summary>
    let Whirlpool = _prefixId.prefix "Whirlpool"
    /// <summary>
    ///   <para>rdfs:label : Wine Region</para>
    ///   <para>rdfs:comment : Any Wine Region, a region where wine is produced.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#WineRegion">pext:WineRegion</a>
    /// </summary>
    let WineRegion = _prefixId.prefix "WineRegion"
    /// <summary>
    ///   <para>rdfs:label : Woman</para>
    ///   <para>rdfs:comment : A female human.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Woman">pext:Woman</a>
    /// </summary>
    let Woman = _prefixId.prefix "Woman"
    /// <summary>
    ///   <para>rdfs:label : World Heritage Site</para>
    ///   <para>rdfs:comment : Any world heritage site, a old site with historic value of world magnitude to be preserved.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#WorldHeritageSite">pext:WorldHeritageSite</a>
    /// </summary>
    let WorldHeritageSite = _prefixId.prefix "WorldHeritageSite"
    let Wrestler = _prefixId.prefix "Wrestler"
    let Writer = _prefixId.prefix "Writer"
    /// <summary>
    ///   <para>rdfs:label : ZipCode</para>
    ///   <para>rdfs:comment : Part of a postal address denoting the zip code.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ZipCode">pext:ZipCode</a>
    /// </summary>
    let ZipCode = _prefixId.prefix "ZipCode"
    /// <summary>
    ///   <para>rdfs:label : Zone</para>
    ///   <para>rdfs:comment : A land region defined to play a role. For example, a buffer between two nations in which military presence is minimal or absent or zone around the site of the Chernobyl disaster to protect people from radiation. (NIMA GNS designator A.ZN, A.ZNB.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#Zone">pext:Zone</a>
    /// </summary>
    let Zone = _prefixId.prefix "Zone"
    /// <summary>
    ///   <para>rdfs:label : Account Provider</para>
    ///   <para>rdfs:comment : A relation between an account and an agent (usually organization) providing and managing it</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#accountProvider">pext:accountProvider</a>
    /// </summary>
    let accountProvider = _prefixId.prefix "accountProvider"
    /// <summary>
    ///   <para>rdfs:label : Acquired</para>
    ///   <para>rdfs:comment : The participant of an acquirement event which became a property of another participant in this event.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#acquired">pext:acquired</a>
    /// </summary>
    let acquired = _prefixId.prefix "acquired"
    /// <summary>
    ///   <para>rdfs:label : Acquirer</para>
    ///   <para>rdfs:comment : The participant of an acquirement event which became an owner of another participant in this event.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#acquirer">pext:acquirer</a>
    /// </summary>
    let acquirer = _prefixId.prefix "acquirer"
    /// <summary>
    ///   <para>rdfs:label : Active in Sector</para>
    ///   <para>rdfs:comment : Denotes that the organization is active within the industry sector</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#activeInSector">pext:activeInSector</a>
    /// </summary>
    let activeInSector = _prefixId.prefix "activeInSector"
    /// <summary>
    ///   <para>rdfs:label : Appointed by</para>
    ///   <para>rdfs:comment : A concrete job position appointed by a given person.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#appointedBy">pext:appointedBy</a>
    /// </summary>
    let appointedBy = _prefixId.prefix "appointedBy"
    /// <summary>
    ///   <para>rdfs:label : Posision</para>
    ///   <para>rdfs:comment : A concrete job position which is assigned to the position available in a given organization.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#appointmentFor">pext:appointmentFor</a>
    /// </summary>
    let appointmentFor = _prefixId.prefix "appointmentFor"
    /// <summary>
    ///   <para>rdfs:label : Architect</para>
    ///   <para>rdfs:comment : The relation between a facility and its architect.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#architect">pext:architect</a>
    /// </summary>
    let architect = _prefixId.prefix "architect"
    /// <summary>
    ///   <para>rdfs:label : Author</para>
    ///   <para>rdfs:comment : Any author of a product. Links any object to its author (producer).</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#authorOf">pext:authorOf</a>
    /// </summary>
    let authorOf = _prefixId.prefix "authorOf"
    /// <summary>
    ///   <para>rdfs:label : Birthday</para>
    ///   <para>rdfs:comment : The relation between a person and the date he/she is born.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#birthDate">pext:birthDate</a>
    /// </summary>
    let birthDate = _prefixId.prefix "birthDate"
    /// <summary>
    ///   <para>rdfs:label : Place of Birth</para>
    ///   <para>rdfs:comment : The relation between a person and the place he/she is born.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#birthPlace">pext:birthPlace</a>
    /// </summary>
    let birthPlace = _prefixId.prefix "birthPlace"
    /// <summary>
    ///   <para>rdfs:label : Car Assembly in</para>
    ///   <para>rdfs:comment : The relation between a car model and the country it is assembled in.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#carAssemblyIn">pext:carAssemblyIn</a>
    /// </summary>
    let carAssemblyIn = _prefixId.prefix "carAssemblyIn"
    /// <summary>
    ///   <para>rdfs:label : Cause of a Death</para>
    ///   <para>rdfs:comment : Any cause of death.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#causeOfDeath">pext:causeOfDeath</a>
    /// </summary>
    let causeOfDeath = _prefixId.prefix "causeOfDeath"
    /// <summary>
    ///   <para>rdfs:label : Combatant from</para>
    ///   <para>rdfs:comment : the relation between a military unit and the organization it represents in a military conflict.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#combatantFrom">pext:combatantFrom</a>
    /// </summary>
    let combatantFrom = _prefixId.prefix "combatantFrom"
    /// <summary>
    ///   <para>rdfs:label : Compliant with Schema</para>
    ///   <para>rdfs:comment : It links a dataset with a schema it complies to.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#compliantWithSchema">pext:compliantWithSchema</a>
    /// </summary>
    let compliantWithSchema = _prefixId.prefix "compliantWithSchema"
    /// <summary>
    ///   <para>rdfs:label : Combatant</para>
    ///   <para>rdfs:comment : The relation between a military organization, which participates as a combatant in a military conflict</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#conflictCombatant">pext:conflictCombatant</a>
    /// </summary>
    let conflictCombatant = _prefixId.prefix "conflictCombatant"
    /// <summary>
    ///   <para>rdfs:comment : Relation between two locations where the first contains the other.rdfs:comment : The relation between a location and another location that is contained by the first one.</para>
    ///   <para>rdfs:label : Contains a Location</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#containsLocation">pext:containsLocation</a>
    /// </summary>
    let containsLocation = _prefixId.prefix "containsLocation"
    /// <summary>
    ///   <para>rdfs:label : Current Frequency</para>
    ///   <para>rdfs:comment : The relation between a recurring event and its frequency.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#currentFrequency">pext:currentFrequency</a>
    /// </summary>
    let currentFrequency = _prefixId.prefix "currentFrequency"
    /// <summary>
    ///   <para>rdfs:label : Date Published</para>
    ///   <para>rdfs:comment : Typically, associated with the creation or availability of the resource. Recommended best practice for encoding the date value is defined in a profile of ISO 8601 [W3CDTF] and includes (among others) dates of the form YYYY-MM-DD. This date is related to an event of publishing which here is implicit. If necessary for the task it can be made explicit in an extension of the ontology.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#datePublished">pext:datePublished</a>
    /// </summary>
    let datePublished = _prefixId.prefix "datePublished"
    /// <summary>
    ///   <para>rdfs:label : Deathday</para>
    ///   <para>rdfs:comment : The relation between a person and the date he/she died.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#deathDate">pext:deathDate</a>
    /// </summary>
    let deathDate = _prefixId.prefix "deathDate"
    /// <summary>
    ///   <para>rdfs:label : Place of Death</para>
    ///   <para>rdfs:comment : The relation between a person and the place he/she died.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#deathPlace">pext:deathPlace</a>
    /// </summary>
    let deathPlace = _prefixId.prefix "deathPlace"
    /// <summary>
    ///   <para>rdfs:label : Designer</para>
    ///   <para>rdfs:comment : Any author of engineering and architecture designs. The relation between an author and the facility he has designed.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#designerOfFacility">pext:designerOfFacility</a>
    /// </summary>
    let designerOfFacility = _prefixId.prefix "designerOfFacility"
    /// <summary>
    ///   <para>rdfs:label : Represented District</para>
    ///   <para>rdfs:comment : the relation between an official position, usually political and the location it represents. The district represented by an official position, usually political.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#districtRepresented">pext:districtRepresented</a>
    /// </summary>
    let districtRepresented = _prefixId.prefix "districtRepresented"
    /// <summary>
    ///   <para>rdfs:label : Date of Last Occurance</para>
    ///   <para>rdfs:comment : The date of the last occurrence of a recurring event.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#finalOccuranceDate">pext:finalOccuranceDate</a>
    /// </summary>
    let finalOccuranceDate = _prefixId.prefix "finalOccuranceDate"
    /// <summary>
    ///   <para>rdfs:label : Date of First Occurance</para>
    ///   <para>rdfs:comment : The date of the first occurrence of a recurring event.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#firstOccuranceDate">pext:firstOccuranceDate</a>
    /// </summary>
    let firstOccuranceDate = _prefixId.prefix "firstOccuranceDate"
    /// <summary>
    ///   <para>rdfs:label : fiscal net income</para>
    ///   <para>rdfs:comment : Net Income last year.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#fiscalNetIncome">pext:fiscalNetIncome</a>
    /// </summary>
    let fiscalNetIncome = _prefixId.prefix "fiscalNetIncome"
    /// <summary>
    ///   <para>rdfs:label : fiscal sales</para>
    ///   <para>rdfs:comment : Sales last year.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#fiscalSales">pext:fiscalSales</a>
    /// </summary>
    let fiscalSales = _prefixId.prefix "fiscalSales"
    /// <summary>
    ///   <para>rdfs:label : Genre Of</para>
    ///   <para>rdfs:comment : The relation between an agent and the genre he is occupied in.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#genreOfAgent">pext:genreOfAgent</a>
    /// </summary>
    let genreOfAgent = _prefixId.prefix "genreOfAgent"
    /// <summary>
    ///   <para>rdfs:label : has Address</para>
    ///   <para>rdfs:comment : Relates address to an agent. Will be used for URL, email and other addresses.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasAddress">pext:hasAddress</a>
    /// </summary>
    let hasAddress = _prefixId.prefix "hasAddress"
    /// <summary>
    ///   <para>rdfs:label : has Airport</para>
    ///   <para>rdfs:comment : A relation between a city and an airport near to the city.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasAirport">pext:hasAirport</a>
    /// </summary>
    let hasAirport = _prefixId.prefix "hasAirport"
    /// <summary>
    ///   <para>rdfs:label : has Bottom Offset^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasBottomOffset">pext:hasBottomOffset</a>
    /// </summary>
    let hasBottomOffset = _prefixId.prefix "hasBottomOffset"
    /// <summary>
    ///   <para>rdfs:label : has Brother</para>
    ///   <para>rdfs:comment : Relates a person and his/her brother.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasBrother">pext:hasBrother</a>
    /// </summary>
    let hasBrother = _prefixId.prefix "hasBrother"
    /// <summary>
    ///   <para>rdfs:label : hasCapabilities^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasCapabilities">pext:hasCapabilities</a>
    /// </summary>
    let hasCapabilities = _prefixId.prefix "hasCapabilities"
    /// <summary>
    ///   <para>rdfs:label : has Capital</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasCapital">pext:hasCapital</a>
    /// </summary>
    let hasCapital = _prefixId.prefix "hasCapital"
    /// <summary>
    ///   <para>rdfs:label : has Celebrity Title</para>
    ///   <para>rdfs:comment : The relation between the status of celebrity and its celebrity title of notoriety in the society.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasCelebrityTitle">pext:hasCelebrityTitle</a>
    /// </summary>
    let hasCelebrityTitle = _prefixId.prefix "hasCelebrityTitle"
    /// <summary>
    ///   <para>rdfs:label : has Cleric Title</para>
    ///   <para>rdfs:comment : The relation between a Cleric and its cleric title, like Bishop, Pole, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasClericTitle">pext:hasClericTitle</a>
    /// </summary>
    let hasClericTitle = _prefixId.prefix "hasClericTitle"
    /// <summary>
    ///   <para>rdfs:label : has Code</para>
    ///   <para>rdfs:comment : Denotes that the Sector has the specified SIC code</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasCode">pext:hasCode</a>
    /// </summary>
    let hasCode = _prefixId.prefix "hasCode"
    /// <summary>
    ///   <para>rdfs:label : Commander</para>
    ///   <para>rdfs:comment : The relation between a military unit and the person who commands it.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasCommander">pext:hasCommander</a>
    /// </summary>
    let hasCommander = _prefixId.prefix "hasCommander"
    /// <summary>
    ///   <para>rdfs:label : has Currency</para>
    ///   <para>rdfs:comment : A relation between a country and the currency used within the country</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasCurrency">pext:hasCurrency</a>
    /// </summary>
    let hasCurrency = _prefixId.prefix "hasCurrency"
    /// <summary>
    ///   <para>rdfs:label : has Daughter</para>
    ///   <para>rdfs:comment : Relates a person and his/her daughter.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasDaughter">pext:hasDaughter</a>
    /// </summary>
    let hasDaughter = _prefixId.prefix "hasDaughter"
    /// <summary>
    ///   <para>rdfs:label : hasDevice^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasDevice">pext:hasDevice</a>
    /// </summary>
    let hasDevice = _prefixId.prefix "hasDevice"
    /// <summary>
    ///   <para>rdfs:label : has E-mail</para>
    ///   <para>rdfs:comment : Relates an object (usually a person) to its email.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasEMail">pext:hasEMail</a>
    /// </summary>
    let hasEMail = _prefixId.prefix "hasEMail"
    /// <summary>
    ///   <para>rdfs:label : hasEndOffset^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasEndOffset">pext:hasEndOffset</a>
    /// </summary>
    let hasEndOffset = _prefixId.prefix "hasEndOffset"
    /// <summary>
    ///   <para>rdfs:label : has Father</para>
    ///   <para>rdfs:comment : Relates a person and his/her father.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasFather">pext:hasFather</a>
    /// </summary>
    let hasFather = _prefixId.prefix "hasFather"
    /// <summary>
    ///   <para>rdfs:label : has Fax</para>
    ///   <para>rdfs:comment : Relates an object (usually an organization) to its fax number.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasFax">pext:hasFax</a>
    /// </summary>
    let hasFax = _prefixId.prefix "hasFax"
    /// <summary>
    ///   <para>rdfs:label : has Government</para>
    ///   <para>rdfs:comment : A relation between a country and its government</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasGovernment">pext:hasGovernment</a>
    /// </summary>
    let hasGovernment = _prefixId.prefix "hasGovernment"
    /// <summary>
    ///   <para>rdfs:label : has Husband</para>
    ///   <para>rdfs:comment : Relates a woman to her spouse.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasHusband">pext:hasHusband</a>
    /// </summary>
    let hasHusband = _prefixId.prefix "hasHusband"
    /// <summary>
    ///   <para>rdfs:label : hasISProfile^^xsd:string</para>
    ///   <para>rdfs:comment : a relation between an Information Space and its Profile^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasISProfile">pext:hasISProfile</a>
    /// </summary>
    let hasISProfile = _prefixId.prefix "hasISProfile"
    /// <summary>
    ///   <para>rdfs:label : has Internet Address</para>
    ///   <para>rdfs:comment : Relates an object to its internet address.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasInternetAddress">pext:hasInternetAddress</a>
    /// </summary>
    let hasInternetAddress = _prefixId.prefix "hasInternetAddress"
    /// <summary>
    ///   <para>rdfs:label : has Left Offset^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasLeftOffset">pext:hasLeftOffset</a>
    /// </summary>
    let hasLeftOffset = _prefixId.prefix "hasLeftOffset"
    /// <summary>
    ///   <para>rdfs:label : hasLocation^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasLocation">pext:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : has Minister</para>
    ///   <para>rdfs:comment : The relation between a minister and his/her ministry.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasMinister">pext:hasMinister</a>
    /// </summary>
    let hasMinister = _prefixId.prefix "hasMinister"
    /// <summary>
    ///   <para>rdfs:label : has Mobile Phone</para>
    ///   <para>rdfs:comment : Relates an object (usually a person) to its mobile phone number.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasMobilePhone">pext:hasMobilePhone</a>
    /// </summary>
    let hasMobilePhone = _prefixId.prefix "hasMobilePhone"
    /// <summary>
    ///   <para>rdfs:label : has Mother</para>
    ///   <para>rdfs:comment : Relates a person to his/her mother.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasMother">pext:hasMother</a>
    /// </summary>
    let hasMother = _prefixId.prefix "hasMother"
    /// <summary>
    ///   <para>rdfs:label : has Nobetlty Title</para>
    ///   <para>rdfs:comment : The relation between the social position and the social title of nobelty.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasNobeltyTitle">pext:hasNobeltyTitle</a>
    /// </summary>
    let hasNobeltyTitle = _prefixId.prefix "hasNobeltyTitle"
    /// <summary>
    ///   <para>rdfs:label : has OutOfLaws Title</para>
    ///   <para>rdfs:comment : The relation between the status of a criminal, and title, for instance a prisoner.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasOutOfLawsTitle">pext:hasOutOfLawsTitle</a>
    /// </summary>
    let hasOutOfLawsTitle = _prefixId.prefix "hasOutOfLawsTitle"
    /// <summary>
    ///   <para>rdfs:label : has Phone</para>
    ///   <para>rdfs:comment : Relates an object (usually a person or an organization) to its telephone number.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasPhone">pext:hasPhone</a>
    /// </summary>
    let hasPhone = _prefixId.prefix "hasPhone"
    /// <summary>
    ///   <para>rdfs:label : Point Scorred in a Sport Game</para>
    ///   <para>rdfs:comment : The relation between a given sport game event and a point scored in it.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasPoint">pext:hasPoint</a>
    /// </summary>
    let hasPoint = _prefixId.prefix "hasPoint"
    /// <summary>
    ///   <para>rdfs:label : has Prime Minister</para>
    ///   <para>rdfs:comment : The relation between a government and its head.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasPrimeMinister">pext:hasPrimeMinister</a>
    /// </summary>
    let hasPrimeMinister = _prefixId.prefix "hasPrimeMinister"
    /// <summary>
    ///   <para>rdfs:label : has Profession</para>
    ///   <para>rdfs:comment : A relation between a person and his/her profession.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasProfession">pext:hasProfession</a>
    /// </summary>
    let hasProfession = _prefixId.prefix "hasProfession"
    /// <summary>
    ///   <para>rdfs:label : has Publisher</para>
    ///   <para>rdfs:comment : An entity responsible for making the resource available. Examples of Publisher include a person, an organization, or a service. (DC2003ISO)</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasPublisher">pext:hasPublisher</a>
    /// </summary>
    let hasPublisher = _prefixId.prefix "hasPublisher"
    /// <summary>
    ///   <para>rdfs:label : Recurring Event Instance</para>
    ///   <para>rdfs:comment : The relation between a particular event as an element of a recurring event.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasRecurringEventInstance">pext:hasRecurringEventInstance</a>
    /// </summary>
    let hasRecurringEventInstance = _prefixId.prefix "hasRecurringEventInstance"
    /// <summary>
    ///   <para>rdfs:label : has Right Offset^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasRightOffset">pext:hasRightOffset</a>
    /// </summary>
    let hasRightOffset = _prefixId.prefix "hasRightOffset"
    /// <summary>
    ///   <para>rdfs:label : hasRole^^xsd:stringrdfs:label : has role</para>
    ///   <para>rdfs:comment : Relates a happening with some of the roles in it</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasRole">pext:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:label : has Section^^xsd:string</para>
    ///   <para>rdfs:comment : Natural relation between documents and sections. Imported from the iSIM ontology.^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasSection">pext:hasSection</a>
    /// </summary>
    let hasSection = _prefixId.prefix "hasSection"
    /// <summary>
    ///   <para>rdfs:label : has shareholder</para>
    ///   <para>rdfs:comment : A relation between a commercial organization and a person that owns shares of the organization.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasShareholder">pext:hasShareholder</a>
    /// </summary>
    let hasShareholder = _prefixId.prefix "hasShareholder"
    /// <summary>
    ///   <para>rdfs:label : has Sister</para>
    ///   <para>rdfs:comment : Relates a person to his/her sister.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasSister">pext:hasSister</a>
    /// </summary>
    let hasSister = _prefixId.prefix "hasSister"
    /// <summary>
    ///   <para>rdfs:label : has Title</para>
    ///   <para>rdfs:comment : Generic property relating a Social Position to its name defined as an instance of a sub-class of pext:SocialFunction</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasSocialFunctionTitle">pext:hasSocialFunctionTitle</a>
    /// </summary>
    let hasSocialFunctionTitle = _prefixId.prefix "hasSocialFunctionTitle"
    /// <summary>
    ///   <para>rdfs:label : has Social Position Celebrity</para>
    ///   <para>rdfs:comment : The relation between a person and the social position of Celebrity he has.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasSocialPositionCelebrity">pext:hasSocialPositionCelebrity</a>
    /// </summary>
    let hasSocialPositionCelebrity = _prefixId.prefix "hasSocialPositionCelebrity"
    /// <summary>
    ///   <para>rdfs:label : has Social Position Cleric</para>
    ///   <para>rdfs:comment : The relation between a person and the social position of Cleric he has.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasSocialPositionCleric">pext:hasSocialPositionCleric</a>
    /// </summary>
    let hasSocialPositionCleric = _prefixId.prefix "hasSocialPositionCleric"
    /// <summary>
    ///   <para>rdfs:label : has Social Position Nobelty</para>
    ///   <para>rdfs:comment : The relation between a person and the social position of Nobelty he has.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasSocialPositionNobelty">pext:hasSocialPositionNobelty</a>
    /// </summary>
    let hasSocialPositionNobelty = _prefixId.prefix "hasSocialPositionNobelty"
    /// <summary>
    ///   <para>rdfs:label : has Social Position OutOfLaws</para>
    ///   <para>rdfs:comment : The relation between a person and the social position of OutOfLaws he has.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasSocialPositionOutOfLaws">pext:hasSocialPositionOutOfLaws</a>
    /// </summary>
    let hasSocialPositionOutOfLaws = _prefixId.prefix "hasSocialPositionOutOfLaws"
    /// <summary>
    ///   <para>rdfs:label : has Son</para>
    ///   <para>rdfs:comment : Relates a person to his/her son.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasSon">pext:hasSon</a>
    /// </summary>
    let hasSon = _prefixId.prefix "hasSon"
    /// <summary>
    ///   <para>rdfs:label : hasStartOffset^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasStartOffset">pext:hasStartOffset</a>
    /// </summary>
    let hasStartOffset = _prefixId.prefix "hasStartOffset"
    /// <summary>
    ///   <para>rdfs:label : has Stationary Phone</para>
    ///   <para>rdfs:comment : Relates an object (usually a person) to its stationary phone number.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasStationaryPhone">pext:hasStationaryPhone</a>
    /// </summary>
    let hasStationaryPhone = _prefixId.prefix "hasStationaryPhone"
    /// <summary>
    ///   <para>rdfs:label : hasString^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasString">pext:hasString</a>
    /// </summary>
    let hasString = _prefixId.prefix "hasString"
    /// <summary>
    ///   <para>rdfs:label : has Title</para>
    ///   <para>rdfs:comment : Relates a job position to its title.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasTitle">pext:hasTitle</a>
    /// </summary>
    let hasTitle = _prefixId.prefix "hasTitle"
    /// <summary>
    ///   <para>rdfs:label : has Top Offset^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasTopOffset">pext:hasTopOffset</a>
    /// </summary>
    let hasTopOffset = _prefixId.prefix "hasTopOffset"
    /// <summary>
    ///   <para>rdfs:label : has Unit</para>
    ///   <para>rdfs:comment : Relates a currency to its unit. Examples: dollar, euro, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasUnit">pext:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    /// <summary>
    ///   <para>rdfs:label : hasUserProfile^^xsd:string</para>
    ///   <para>rdfs:comment : a relation between an User and its Profile^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasUserProfile">pext:hasUserProfile</a>
    /// </summary>
    let hasUserProfile = _prefixId.prefix "hasUserProfile"
    /// <summary>
    ///   <para>rdfs:label : has Web Page</para>
    ///   <para>rdfs:comment : Relates an object (usually a person or an organization) to its web page.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasWebPage">pext:hasWebPage</a>
    /// </summary>
    let hasWebPage = _prefixId.prefix "hasWebPage"
    /// <summary>
    ///   <para>rdfs:label : has Wife</para>
    ///   <para>rdfs:comment : Relates a man to his spouse.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#hasWife">pext:hasWife</a>
    /// </summary>
    let hasWife = _prefixId.prefix "hasWife"
    /// <summary>
    ///   <para>rdfs:label : Industry</para>
    ///   <para>rdfs:comment : The relation between an organization and the industry sector it is active in.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#industryOf">pext:industryOf</a>
    /// </summary>
    let industryOf = _prefixId.prefix "industryOf"
    /// <summary>
    ///   <para>rdfs:label : Author</para>
    ///   <para>rdfs:comment : Any author of a product. Links an author (producer) to its creation .</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#isAuthorOf">pext:isAuthorOf</a>
    /// </summary>
    let isAuthorOf = _prefixId.prefix "isAuthorOf"
    /// <summary>
    ///   <para>rdfs:label : is a Birth Place of</para>
    ///   <para>rdfs:comment : A place where a person is born. The relation between a location and a person who is born in this location.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#isBirthPlaceOf">pext:isBirthPlaceOf</a>
    /// </summary>
    let isBirthPlaceOf = _prefixId.prefix "isBirthPlaceOf"
    /// <summary>
    ///   <para>rdfs:label : isCurrentlyInterestedIn^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#isCurrentlyInterestedIn">pext:isCurrentlyInterestedIn</a>
    /// </summary>
    let isCurrentlyInterestedIn = _prefixId.prefix "isCurrentlyInterestedIn"
    /// <summary>
    ///   <para>rdfs:label : isInterestedIn^^xsd:string</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#isInterestedIn">pext:isInterestedIn</a>
    /// </summary>
    let isInterestedIn = _prefixId.prefix "isInterestedIn"
    /// <summary>
    ///   <para>rdfs:label : RDF document containing the descriptions of locations that share a common border</para>
    ///   <para>rdfs:comment : The relation between an RDF document containing the descriptions of locations that share a common border</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#isWrittenAbout">pext:isWrittenAbout</a>
    /// </summary>
    let isWrittenAbout = _prefixId.prefix "isWrittenAbout"
    /// <summary>
    ///   <para>rdfs:label : Issue of</para>
    ///   <para>rdfs:comment : A relation of a specific issue, number, and/or volume and a periodical publication.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#issueOf">pext:issueOf</a>
    /// </summary>
    let issueOf = _prefixId.prefix "issueOf"
    /// <summary>
    ///   <para>rdfs:label : Location Map</para>
    ///   <para>rdfs:comment : The relation between a geographic region and a map depicting its location</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#locationMap">pext:locationMap</a>
    /// </summary>
    let locationMap = _prefixId.prefix "locationMap"
    /// <summary>
    ///   <para>rdfs:label : Location Namerdfs:label : Name</para>
    ///   <para>rdfs:comment : The name of a georgaphic region.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#locationName">pext:locationName</a>
    /// </summary>
    let locationName = _prefixId.prefix "locationName"
    /// <summary>
    ///   <para>rdfs:label : Instrument of a Musician</para>
    ///   <para>rdfs:comment : The relation between a musician and the instrument he plays</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#musicInstrument">pext:musicInstrument</a>
    /// </summary>
    let musicInstrument = _prefixId.prefix "musicInstrument"
    /// <summary>
    ///   <para>rdfs:label : Nationality of a Person</para>
    ///   <para>rdfs:comment : The nationality of a person. The relation between a person and his nationality.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#nationalityOf">pext:nationalityOf</a>
    /// </summary>
    let nationalityOf = _prefixId.prefix "nationalityOf"
    /// <summary>
    ///   <para>rdfs:label : Location Nearby another Location</para>
    ///   <para>rdfs:comment : The relation of a location nearby another location</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#nearby">pext:nearby</a>
    /// </summary>
    let nearby = _prefixId.prefix "nearby"
    /// <summary>
    ///   <para>rdfs:label : Location Sharing a Common Location with Another Location</para>
    ///   <para>rdfs:comment : The relation of a location sharing a common location with another location</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#neighbour">pext:neighbour</a>
    /// </summary>
    let neighbour = _prefixId.prefix "neighbour"
    /// <summary>
    ///   <para>rdfs:label : of Country</para>
    ///   <para>rdfs:comment : The relation between a government organization and its country.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ofCountry">pext:ofCountry</a>
    /// </summary>
    let ofCountry = _prefixId.prefix "ofCountry"
    /// <summary>
    ///   <para>rdfs:label : Official Position in</para>
    ///   <para>rdfs:comment : This property models the Person-&gt;hasPosition-&gt;Location.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#officialPositionIn">pext:officialPositionIn</a>
    /// </summary>
    let officialPositionIn = _prefixId.prefix "officialPositionIn"
    /// <summary>
    ///   <para>rdfs:label : within Organization</para>
    ///   <para>rdfs:comment : The relation between an organization and a concrete job position in it.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#organizationPosition">pext:organizationPosition</a>
    /// </summary>
    let organizationPosition = _prefixId.prefix "organizationPosition"
    /// <summary>
    ///   <para>rdfs:label : Owner</para>
    ///   <para>rdfs:comment : The relationship between an object and an agent who owns it.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ownerOf">pext:ownerOf</a>
    /// </summary>
    let ownerOf = _prefixId.prefix "ownerOf"
    /// <summary>
    ///   <para>rdfs:label : Ownership</para>
    ///   <para>rdfs:comment : The relationship between an object being a property/possessions of somebody.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#ownershipOf">pext:ownershipOf</a>
    /// </summary>
    let ownershipOf = _prefixId.prefix "ownershipOf"
    /// <summary>
    ///   <para>rdfs:label : a Part of a Postal Address</para>
    ///   <para>rdfs:comment : Relation between the part of postal address and a given postal address.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#partOfPostalAddress">pext:partOfPostalAddress</a>
    /// </summary>
    let partOfPostalAddress = _prefixId.prefix "partOfPostalAddress"
    /// <summary>
    ///   <para>rdfs:label : Awarded Sport Club</para>
    ///   <para>rdfs:comment : The relation between the scored point in a sport game and the sport club who won it.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#pointAwardedTo">pext:pointAwardedTo</a>
    /// </summary>
    let pointAwardedTo = _prefixId.prefix "pointAwardedTo"
    /// <summary>
    ///   <para>rdfs:label : Contact Information for a Position within Organization</para>
    ///   <para>rdfs:comment : The relation between a position and the contact information for it. This contact information can be the postal address of the office for the position or an virtual address in the Internet.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#positionContactInformation">pext:positionContactInformation</a>
    /// </summary>
    let positionContactInformation = _prefixId.prefix "positionContactInformation"
    /// <summary>
    ///   <para>rdfs:label : Position within Organization</para>
    ///   <para>rdfs:comment : The relation between the job position and the organization it is available in. The organization where the job position is available.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#positionWithinOrganization">pext:positionWithinOrganization</a>
    /// </summary>
    let positionWithinOrganization = _prefixId.prefix "positionWithinOrganization"
    /// <summary>
    ///   <para>rdfs:label : Product</para>
    ///   <para>rdfs:comment : The relation between a producer and the product produced. The producer is restricted to an organization, like Microsoft, Ford, GM, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#productOf">pext:productOf</a>
    /// </summary>
    let productOf = _prefixId.prefix "productOf"
    /// <summary>
    ///   <para>rdfs:label : Published within</para>
    ///   <para>rdfs:comment : A relation between an article and the colelction within which the article is published.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#publishedWithin">pext:publishedWithin</a>
    /// </summary>
    let publishedWithin = _prefixId.prefix "publishedWithin"
    /// <summary>
    ///   <para>rdfs:label : Social Position Holder Celebrity</para>
    ///   <para>rdfs:comment : The relation between a social position of Celebrity and the person who has it.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#socialPositionCelebrity">pext:socialPositionCelebrity</a>
    /// </summary>
    let socialPositionCelebrity = _prefixId.prefix "socialPositionCelebrity"
    /// <summary>
    ///   <para>rdfs:label : Social Position Cleric</para>
    ///   <para>rdfs:comment : The relation between a social position of Cleric and the person who has it.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#socialPositionCleric">pext:socialPositionCleric</a>
    /// </summary>
    let socialPositionCleric = _prefixId.prefix "socialPositionCleric"
    /// <summary>
    ///   <para>rdfs:label : Social Position Holder Nobelty</para>
    ///   <para>rdfs:comment : The relation between a social position of Nobelty and the person who has it.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#socialPositionNobelty">pext:socialPositionNobelty</a>
    /// </summary>
    let socialPositionNobelty = _prefixId.prefix "socialPositionNobelty"
    /// <summary>
    ///   <para>rdfs:label : Social Position Holder OutOfLaws</para>
    ///   <para>rdfs:comment : The relation between a social position of OutOfLaws and the person who has it.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#socialPositionOutOfLaws">pext:socialPositionOutOfLaws</a>
    /// </summary>
    let socialPositionOutOfLaws = _prefixId.prefix "socialPositionOutOfLaws"
    /// <summary>
    ///   <para>rdfs:label : Stock Exchange Index</para>
    ///   <para>rdfs:comment : Name of the company on the Stock Exchange, where it is traded. At present, if a company is traded on two SEs with different indices, there is no way to encode which of them is applicable where.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#stockExchangeIndex">pext:stockExchangeIndex</a>
    /// </summary>
    let stockExchangeIndex = _prefixId.prefix "stockExchangeIndex"
    /// <summary>
    ///   <para>rdfs:label : Subsector of</para>
    ///   <para>rdfs:comment : The general part-of relation that takes place between a whole and each of its parts. It has number of specializations.</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#subSectorOf">pext:subSectorOf</a>
    /// </summary>
    let subSectorOf = _prefixId.prefix "subSectorOf"
    /// <summary>
    ///   <para>rdfs:label : Traded on</para>
    ///   <para>rdfs:comment : Relates the Public Company to the Stock Exchange where it is traded</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#tradedOn">pext:tradedOn</a>
    /// </summary>
    let tradedOn = _prefixId.prefix "tradedOn"
    /// <summary>
    ///   <para>rdfs:label : transmission</para>
    ///   <para>rdfs:comment : Describes the transmission type of a given car model</para>
    ///   <a href="http://www.ontotext.com/proton/protonext#transmission">pext:transmission</a>
    /// </summary>
    let transmission = _prefixId.prefix "transmission"
