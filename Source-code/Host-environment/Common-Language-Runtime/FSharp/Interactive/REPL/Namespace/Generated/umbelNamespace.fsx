#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module umbel =
    let _prefixId = PrefixId.fromNamespaceLabel "http://umbel.org/umbel#" "umbel"
    /// <summary>
    ///   <para>skos:prefLabel : abstract level</para>
    ///   <para>skos:definition : This general SuperType category is largely composed of former AbstractConcepts, and represent some of the more abstract upper-level nodes for connecting the UMBEL structure together. This SuperType also includes theories or processes or methods for humans to do stuff or any human technology </para>
    ///   <a href="http://umbel.org/umbel#AbstractLevel">umbel:AbstractLevel</a>
    /// </summary>
    let AbstractLevel = _prefixId.prefix "AbstractLevel"
    /// <summary>
    ///   <para>skos:prefLabel : activities</para>
    ///   <para>skos:definition : These are ongoing activities that result (mostly) from human effort, often conducted by organizations to assist other organizations or individuals (in which case they are known as services, such as medicine, law, printing, consulting or teaching) or individual or group efforts for leisure, fun, sports, games or personal interests (activities) </para>
    ///   <a href="http://umbel.org/umbel#Activities">umbel:Activities</a>
    /// </summary>
    let Activities = _prefixId.prefix "Activities"
    /// <summary>
    ///   <para>skos:prefLabel : animals</para>
    ///   <para>skos:definition : This large SuperType includes all animal types, including specific animal types and vertebrates, invertebrates, insects, crustaceans, fish, reptiles, amphibia, birds, mammals, and animal body parts. Animal parts are specifically included. Also, groupings of such animals are included. Humans, as an animal, are included (versus as an individual Person). Diseases are specifically excluded. Animals have many of the similar overlaps to Plants. However, in addition, there are more terms for animal groups, animal parts, animal secretions, etc. Also Animals can include some human traits (posture, dead animal, etc) </para>
    ///   <a href="http://umbel.org/umbel#Animals">umbel:Animals</a>
    /// </summary>
    let Animals = _prefixId.prefix "Animals"
    /// <summary>
    ///   <para>skos:prefLabel : attributes</para>
    ///   <para>skos:definition : This general SuperType category is for descriptive attributes of all kinds. Think of the specific attributes in Wikipedia "infoboxes" to understand the purpose and coverage of this SuperType. It includes colors, shapes, sizes, or other descriptive characteristics about an object.</para>
    ///   <a href="http://umbel.org/umbel#Attributes">umbel:Attributes</a>
    /// </summary>
    let Attributes = _prefixId.prefix "Attributes"
    /// <summary>
    ///   <para>skos:prefLabel : audio information</para>
    ///   <para>skos:definition : This SuperType is for any audio-only human work. Examples include live music performances, record albums, or radion shows or individual radio broadcasts </para>
    ///   <a href="http://umbel.org/umbel#AudioInfo">umbel:AudioInfo</a>
    /// </summary>
    let AudioInfo = _prefixId.prefix "AudioInfo"
    let AutomaticInspectedSMatch = _prefixId.prefix "AutomaticInspectedSMatch"
    let AutomaticInspectedSV = _prefixId.prefix "AutomaticInspectedSV"
    let AutomaticNotSpecified = _prefixId.prefix "AutomaticNotSpecified"
    /// <summary>
    ///   <para>skos:prefLabel : chemistry</para>
    ///   <para>skos:definition : This SuperType is a residual category (n.o.c., not otherwise categorized) for chemical bonds, chemical composition groupings, and the like. It is formed by what is not a natural substance or living thing (organic) substance. </para>
    ///   <a href="http://umbel.org/umbel#Chemistry">umbel:Chemistry</a>
    /// </summary>
    let Chemistry = _prefixId.prefix "Chemistry"
    /// <summary>
    ///   <para>skos:prefLabel : diseases</para>
    ///   <para>skos:definition : Diseases are atypical or unusual or unhealthy conditions for (mostly human) living things, generally known as conditions, disorders, infections, diseases or syndromes. Diseases only affect living things and sometimes are caused by living things. This SuperType also includes impairments, disease vectors, wounds and injuries, and poisoning.</para>
    ///   <a href="http://umbel.org/umbel#Diseases">umbel:Diseases</a>
    /// </summary>
    let Diseases = _prefixId.prefix "Diseases"
    /// <summary>
    ///   <para>skos:prefLabel : drugs</para>
    ///   <para>skos:definition : This SuperType is an drug, medication or addictive substance </para>
    ///   <a href="http://umbel.org/umbel#Drugs">umbel:Drugs</a>
    /// </summary>
    let Drugs = _prefixId.prefix "Drugs"
    /// <summary>
    ///   <para>skos:prefLabel : earthscape</para>
    ///   <para>skos:definition : The Natural Feature SuperType is the collection of cartographic features that occur on the surface of the Earth. Positive examples include Mountain, Ocean, and Mesa. Artificial features such as canals are excluded. Most instances of these features have a fixed location in space.
    ///
    /// Underground and underwater are also explicitly contained.
    ///
    /// This SuperType is explicitly disjoint with Extraterrestrial (see below). </para>
    ///   <a href="http://umbel.org/umbel#Earthscape">umbel:Earthscape</a>
    /// </summary>
    let Earthscape = _prefixId.prefix "Earthscape"
    /// <summary>
    ///   <para>skos:prefLabel : events</para>
    ///   <para>skos:definition : These are nameable occasions, games, sports events, conferences, natural phenomena, natural disasters, wars, incidents, anniversaries, holidays, or notable moments or periods in time </para>
    ///   <a href="http://umbel.org/umbel#Events">umbel:Events</a>
    /// </summary>
    let Events = _prefixId.prefix "Events"
    let ExternalDBOntologyMapping = _prefixId.prefix "ExternalDBOntologyMapping"
    let ExternalGeoNamesMapping = _prefixId.prefix "ExternalGeoNamesMapping"
    let ExternalOpenCycMapping = _prefixId.prefix "ExternalOpenCycMapping"
    /// <summary>
    ///   <para>skos:definition : This SuperType includes all natural things not specifically terrestrial, including celestial bodies (planets, asteroids, stars, galaxies, etc., that can be located within a sky map).</para>
    ///   <para>skos:prefLabel : Extraterrestrial</para>
    ///   <a href="http://umbel.org/umbel#Extraterrestrial">umbel:Extraterrestrial</a>
    /// </summary>
    let Extraterrestrial = _prefixId.prefix "Extraterrestrial"
    /// <summary>
    ///   <para>skos:prefLabel : facilities</para>
    ///   <para>skos:definition : Facilities are physical places or buildings constructed by humans, such as schools, public institutions, markets, museums, amusement parks, worship places, stations, airports, ports, carstops, lines, railroads, roads, waterways, tunnels, bridges, parks, sport facilities, monuments. All can be geospatially located.
    ///
    /// Facilities also include animal pens and enclosures and general human "activity" areas (golf course, archeology sites, etc.). Iportantly Facilities include infrastructure systems such as roadways and physical networks.
    ///
    /// Facilities also include the component parts that go into making them (such as foundations, doors, windows, roofs, etc.) </para>
    ///   <a href="http://umbel.org/umbel#Facilities">umbel:Facilities</a>
    /// </summary>
    let Facilities = _prefixId.prefix "Facilities"
    /// <summary>
    ///   <para>skos:prefLabel : finance and economy</para>
    ///   <para>skos:definition : This SuperType pertains to all things financial and with respect to the economy, including chartable company performance, stock index entities, money, local currencies, taxes, incomes, accounts and accounting, mortgages and property. </para>
    ///   <a href="http://umbel.org/umbel#FinanceEconomy">umbel:FinanceEconomy</a>
    /// </summary>
    let FinanceEconomy = _prefixId.prefix "FinanceEconomy"
    /// <summary>
    ///   <para>skos:prefLabel : food or drink</para>
    ///   <para>skos:definition : This SuperType is any edible substance grown, made or harvested by humans. The category also specifically includes the concept of cuisines </para>
    ///   <a href="http://umbel.org/umbel#FoodDrink">umbel:FoodDrink</a>
    /// </summary>
    let FoodDrink = _prefixId.prefix "FoodDrink"
    /// <summary>
    ///   <para>skos:prefLabel : geopolitical</para>
    ///   <para>skos:definition : Named places that have some informal or formal political (authorized) component. Important subcollections include Country, IndependentCountry, State_Geopolitical, City, and Province. </para>
    ///   <a href="http://umbel.org/umbel#Geopolitical">umbel:Geopolitical</a>
    /// </summary>
    let Geopolitical = _prefixId.prefix "Geopolitical"
    let HeuristicListOfBasis = _prefixId.prefix "HeuristicListOfBasis"
    let HeuristicNotSpecified = _prefixId.prefix "HeuristicNotSpecified"
    let ManualNearlyEquivalent = _prefixId.prefix "ManualNearlyEquivalent"
    let ManualSimilarSense = _prefixId.prefix "ManualSimilarSense"
    /// <summary>
    ///   <para>skos:prefLabel : market industries</para>
    ///   <para>skos:definition : This SuperType is a specialized classificatory system for markets and industries. It could be combined with the SuperType above, but is kept separate in order to provide a separate, economy-oriented system. </para>
    ///   <a href="http://umbel.org/umbel#MarketsIndustries">umbel:MarketsIndustries</a>
    /// </summary>
    let MarketsIndustries = _prefixId.prefix "MarketsIndustries"
    /// <summary>
    ///   <para>skos:prefLabel : natural phenomena</para>
    ///   <para>skos:definition : This SuperType includes natural phenomena and natural processes such as weather, weathering, erosion, fires, lightning, earthquakes, tectonics, etc. Clouds and weather processes are specifically included. Also includes climate cycles, general natural events (such as hurricanes) that are not specifically named, and biochemical processes and pathways. </para>
    ///   <a href="http://umbel.org/umbel#NaturalPhenomena">umbel:NaturalPhenomena</a>
    /// </summary>
    let NaturalPhenomena = _prefixId.prefix "NaturalPhenomena"
    /// <summary>
    ///   <para>skos:prefLabel : natural substance</para>
    ///   <para>skos:definition : Notable inclusions are minerals, compounds, chemicals, or physical objects that are not the outcome of purposeful human effort, but are found naturally occurring. Other natural objects (such as rock, fossil, etc.) are also found under this SuperType. Natural Substances include subatomic particles. The contrast is with Earthscape, which covers natural "features" or living substances, which are covered under the appropriate SuperTypes. Chemicals can be Natural Substances, but only if they are naturally occurring, such as limestone or salt.</para>
    ///   <a href="http://umbel.org/umbel#NaturalSubstances">umbel:NaturalSubstances</a>
    /// </summary>
    let NaturalSubstances = _prefixId.prefix "NaturalSubstances"
    /// <summary>
    ///   <para>skos:prefLabel : notations</para>
    ///   <para>skos:definition : Akin to conceptual works, these are codified means of human expression. Examples range from human languages themselves, to more domain-specific cases such as chemical symbols, genetic code (A-G-C-T), protocols, and computer languages, mathematical and set notations, etc.
    ///
    /// Identifiers (numeric or alphanumeric identifiers for objects, often in a highly patterned way, such as phone numbers, URLs, zip and postal codes, SKUs, product codes, etc.), Units (any of the various ways in which measurement, space, volume, weight, speed, intensity, temperature, calories, siesmic intensity or other quantitative descriptions of phenomena can be made) and key reference types are also included in this SuperType </para>
    ///   <a href="http://umbel.org/umbel#Notations">umbel:Notations</a>
    /// </summary>
    let Notations = _prefixId.prefix "Notations"
    /// <summary>
    ///   <para>skos:prefLabel : numbers</para>
    ///   <para>skos:definition : This unique SuperType is for any abstract representation of numbers and numerics </para>
    ///   <a href="http://umbel.org/umbel#Numbers">umbel:Numbers</a>
    /// </summary>
    let Numbers = _prefixId.prefix "Numbers"
    /// <summary>
    ///   <para>skos:prefLabel : organizations</para>
    ///   <para>skos:definition : Organization is a broad SuperType and includes formal collections of humans, sometimes by legal means, charter, agreement or some mode of formal understanding. Examples include geoplotical entities such as nations, municipalities or countries; or companies, institutes, governments, universities, militaries, political parties, game groups, international organizations, trade associations, etc. All institutions, for example, are organizations.
    ///
    /// Also included are informal collections of humans. Informal or less defined groupings of humans may result from ethnicity or tribes or nationality or from shared interests (such as social networks or mailing lists) or expertise ("communities of practice"). This dimension also includes the notion of identifiable human groups with set members at any given point in time. Examples include music groups, cast members of a play, directors on a corporate Board, TV show members, gangs, mobs, juries, generations, minorities, etc.
    ///
    /// Finally, Organizations contain the concepts of Industries and Programs and Communities. </para>
    ///   <a href="http://umbel.org/umbel#Organizations">umbel:Organizations</a>
    /// </summary>
    let Organizations = _prefixId.prefix "Organizations"
    /// <summary>
    ///   <para>skos:prefLabel : person types</para>
    ///   <para>skos:definition : The appropriate SuperType for all named, individual human beings. This SuperType also includes the assignment of formal, honorific or cultural titles given to specific human individuals. It further includes names given to humans who conduct specific jobs or activities (the latter case is known as an avocation). Examples include steelworker, waitress, lawyer, plumber, artisan. Ethnic groups are specifically included.</para>
    ///   <a href="http://umbel.org/umbel#PersonTypes">umbel:PersonTypes</a>
    /// </summary>
    let PersonTypes = _prefixId.prefix "PersonTypes"
    /// <summary>
    ///   <para>skos:prefLabel : plants</para>
    ///   <para>skos:definition : This SuperType includes all plant types and flora, including flowering plants, algae, non-flowering plants, gymnosperms, cycads, and plant parts and body types. Note that all Plant Parts are also included.</para>
    ///   <a href="http://umbel.org/umbel#Plants">umbel:Plants</a>
    /// </summary>
    let Plants = _prefixId.prefix "Plants"
    /// <summary>
    ///   <para>skos:prefLabel : products</para>
    ///   <para>skos:definition : This is the largest SuperType and includes any instance offered for sale or performed as a commercial service. Often physical object made by humans that is not a conceptual work or a facility, such as vehicles, cars, trains, aircraft, spaceships, ships, foods, beverages, clothes, drugs, weapons. Products also include the concept of 'state' (e/g/., on/off) </para>
    ///   <a href="http://umbel.org/umbel#Products">umbel:Products</a>
    /// </summary>
    let Products = _prefixId.prefix "Products"
    /// <summary>
    ///   <para>skos:prefLabel : prokaryotes</para>
    ///   <para>skos:definition : The Prokaryotes include all prokaryotic organisms, including the Monera, Archaebacteria, Bacteria, and Blue-green algas. Also included in this SuperType are viruses and prions.</para>
    ///   <a href="http://umbel.org/umbel#Prokaryotes">umbel:Prokaryotes</a>
    /// </summary>
    let Prokaryotes = _prefixId.prefix "Prokaryotes"
    /// <summary>
    ///   <para>skos:prefLabel : protists fungus</para>
    ///   <para>skos:definition : This is the remaining cluster of eukaryotic organisms, specifically including the fungus and the protista (protozoans and slime molds).</para>
    ///   <a href="http://umbel.org/umbel#ProtistsFungus">umbel:ProtistsFungus</a>
    /// </summary>
    let ProtistsFungus = _prefixId.prefix "ProtistsFungus"
    /// <summary>
    ///   <para>skos:prefLabel : qualifier</para>
    ///   <para>skos:definition : The Qualifier class is a set of descriptions that indicate the method used in order to establish an isAbout relationship between an UMBEL reference concept (RC) and an external entity. This description should be complete enough to aid understanding of the nature and reliability of the "aboutness" assertion and to be usable for filtering or user interface information. The descriptions may be literal strings or may refer to literal numeric values resulting from an automated alignment technique.</para>
    ///   <a href="http://umbel.org/umbel#Qualifier">umbel:Qualifier</a>
    /// </summary>
    let Qualifier = _prefixId.prefix "Qualifier"
    /// <summary>
    ///   <para>skos:prefLabel : reference concept</para>
    ///   <para>skos:definition : Reference Concepts are a distinct subset of the more broadly understood concept such as used in the SKOS RDFS controlled vocabulary or formal concept analysis or the very general or abstract concepts common to some upper ontologies.
    ///
    /// Reference Concepts are selected for their use as concrete, subject-related or commonly used notions for describing tangible ideas and referents in human experience and language. Reference Concepts are classes, the members of which are nameable instances or named entities, which by definition are held as distinct from these concepts. The UMBEL ontology is a coherently organized structure (or reference "backbone") of these Reference Concepts. </para>
    ///   <a href="http://umbel.org/umbel#RefConcept">umbel:RefConcept</a>
    /// </summary>
    let RefConcept = _prefixId.prefix "RefConcept"
    /// <summary>
    ///   <para>skos:prefLabel : society</para>
    ///   <para>skos:definition : This category includes concepts related to political systems, laws, rules or cultural mores governing societal or community behavior, or doctrinal, faith or religious bases or entities (such as gods, angels, totems) governing spiritual human matters. Culture, Issues, beliefs and various activisms (most -isms) are included </para>
    ///   <a href="http://umbel.org/umbel#Society">umbel:Society</a>
    /// </summary>
    let Society = _prefixId.prefix "Society"
    /// <summary>
    ///   <para>skos:prefLabel : structured information</para>
    ///   <para>skos:definition : This information SuperType is for all kinds of structured information and datasets, including compute programs, databases, files, Web pages and structured data that can be presented in tabular form </para>
    ///   <a href="http://umbel.org/umbel#StructuredInfo">umbel:StructuredInfo</a>
    /// </summary>
    let StructuredInfo = _prefixId.prefix "StructuredInfo"
    /// <summary>
    ///   <para>skos:definition : SuperTypes are a collection of (mostly) similar Reference Concepts. Most of the SuperType classes have been designed to be (mostly) disjoint from the other SuperType classes. SuperTypes thus provide a higher-level of clustering and organization of Reference Concepts for use in user interfaces and for reasoning purposes.</para>
    ///   <para>skos:prefLabel : SuperType</para>
    ///   <a href="http://umbel.org/umbel#SuperType">umbel:SuperType</a>
    /// </summary>
    let SuperType = _prefixId.prefix "SuperType"
    /// <summary>
    ///   <para>skos:prefLabel : time</para>
    ///   <para>skos:definition : This SuperType is for specific time or date or period (such as eras, or days, weeks, months type intervals) references in various formats </para>
    ///   <a href="http://umbel.org/umbel#Time">umbel:Time</a>
    /// </summary>
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>skos:prefLabel : topics categories</para>
    ///   <para>skos:definition : This largely subject-oriented SuperType is a means for using controlled vocabularies and classification schemes for characterizing what content "is about". The key constituents of this category are Types, Classifications, Concepts, CCC, and controlled vocabularies </para>
    ///   <a href="http://umbel.org/umbel#TopicsCategories">umbel:TopicsCategories</a>
    /// </summary>
    let TopicsCategories = _prefixId.prefix "TopicsCategories"
    /// <summary>
    ///   <para>skos:prefLabel : visual information</para>
    ///   <para>skos:definition : any still image or picture or streaming video human work, with or without audio. Examples include graphics, pictures, movies, TV shows, individual shows from a TV show, etc. </para>
    ///   <a href="http://umbel.org/umbel#VisualInfo">umbel:VisualInfo</a>
    /// </summary>
    let VisualInfo = _prefixId.prefix "VisualInfo"
    /// <summary>
    ///   <para>skos:prefLabel : workplaces</para>
    ///   <para>skos:definition : These are various workplaces and areas of human activities, ranging from single person workstations to large aggregations of people (but which are not formal political entities) </para>
    ///   <a href="http://umbel.org/umbel#Workplaces">umbel:Workplaces</a>
    /// </summary>
    let Workplaces = _prefixId.prefix "Workplaces"
    /// <summary>
    ///   <para>skos:prefLabel : written information</para>
    ///   <para>skos:definition : This SuperType includes any general material written by humans including books, blogs, articles, manuscripts, but any written information conveyed via text.</para>
    ///   <a href="http://umbel.org/umbel#WrittenInfo">umbel:WrittenInfo</a>
    /// </summary>
    let WrittenInfo = _prefixId.prefix "WrittenInfo"
    /// <summary>
    ///   <para>rdfs:comment : The property umbel:correspondsTo is used to assert a close correspondence between an external class, named entity, individual or instance with a Reference Concept class. umbel:correspondsTo relates the external class, named entity, individual or instance to the class through the basis of both its subject matter and intended scope. This predicate should be used where the correspondence between the two entities is felt to be nearly equivalent to a sameAs assertion, and is reflexive, but without the full entailments of intensional class memberships. In these cases, both entities are understood to have the same type and intended scope, but without asserting a full class-level or sameAs individual relationship.
    ///
    /// This predicate is designed for the circumstance of aligning two different ontologies or knowledge bases based on node-level correspondences, but without entailing the actual ontological relationships and structure of the object source. For example, the umbel:correspondsTo predicate is used to assert close correspondence between UMBEL Reference Concepts and Wikipedia categories or pages, yet without entailing the actual Wikipedia category structure.
    ///
    /// This property asserts a different and stronger relationship than umbel:isAbout. One practical use is to guide specific instance member determinations when, say, the native structure of the external ontology or knowledge base is to be analyzed and replaced with an UMBEL-based structure.
    ///
    /// This property is therefore used to create a nearly equivalent assertion (however, with the degree of that equivalence being unknown or unknowable) between an external instance or class and a Reference Concept class</para>
    ///   <a href="http://umbel.org/umbel#correspondsTo">umbel:correspondsTo</a>
    /// </summary>
    let correspondsTo = _prefixId.prefix "correspondsTo"
    /// <summary>
    ///   <para>skos:prefLabel : has characteristic</para>
    ///   <para>skos:definition : The property umbel:hasCharacteristic is used to assert the relation between a Reference Concept and external properties that may be used in external ontologies to characterize, describe, or provide attributes for data records associated with that concept. It is via this property or its inverse, umbel:isCharacteristicOf, that external data characterizations may be incorporated and modeled within a domain ontology based on the UMBEL vocabulary.</para>
    ///   <a href="http://umbel.org/umbel#hasCharacteristic">umbel:hasCharacteristic</a>
    /// </summary>
    let hasCharacteristic = _prefixId.prefix "hasCharacteristic"
    /// <summary>
    ///   <para>skos:prefLabel : has mapping</para>
    ///   <para>skos:definition : This property is used to reify a umbel:isAbout or a umbel:isRelatedTo property to a mapping percentage value, some quantitative metric value, or a qualitative descriptor characterizing the linkage degree or overlap between the two classes, predicates, individuals or datatypes. This value might be calculated from some external utility. </para>
    ///   <a href="http://umbel.org/umbel#hasMapping">umbel:hasMapping</a>
    /// </summary>
    let hasMapping = _prefixId.prefix "hasMapping"
    /// <summary>
    ///   <para>skos:prefLabel : is about</para>
    ///   <para>skos:definition : The property umbel:isAbout is used to assert the relation between a named entity (individual) and a Reference Concept class. umbel:isAbout relates the named entity (individual) to the class through the basis of its subject matter. The relation acknowledges that the scope of the class can not be determined solely by the aggregation or extent of its associated individual entity members, and that the nature of the Reference Concept class may not alone bound or define the individual entity.
    ///
    /// This property is therefore used to create a topical assertion between an individual and a Reference Concept.</para>
    ///   <a href="http://umbel.org/umbel#isAbout">umbel:isAbout</a>
    /// </summary>
    let isAbout = _prefixId.prefix "isAbout"
    /// <summary>
    ///   <para>skos:prefLabel : is characteristic of</para>
    ///   <para>skos:definition : The property umbel:isCharacteristicOf is used to assert the relation between a property and a Reference Concept (or its punned individual) to which it applies. Such properties may be used in external ontologies to characterize, describe, or provide attributes for data records associated with that concept. It is via this property or its inverse, umbel:hasCharacteristic, that external data characterizations may be incorporated and modeled within a domain ontology based on the UMBEL vocabulary.</para>
    ///   <a href="http://umbel.org/umbel#isCharacteristicOf">umbel:isCharacteristicOf</a>
    /// </summary>
    let isCharacteristicOf = _prefixId.prefix "isCharacteristicOf"
    /// <summary>
    ///   <para>skos:prefLabel : is like</para>
    ///   <para>skos:definition : The property umbel:isLike is used to assert an associative link between similar individuals who may or may not be identical, but are believed to be so. This property is not intended as a general expression of similarity, but rather the likely but uncertain same identity of the two resources being related.
    ///
    /// This property can and should be changed if the certainty of the sameness of identity is subsequently determined.
    ///
    /// In general, we may not be able to assert that two individuals are the same based solely on current information on hand. However, there may be quite reasonable bases or methods that the two individuals are likely the same without being one hundred percent sure.
    ///
    /// umbel:isLike has the semantics of likely identity, but where there is some uncertainty that the two resources indeed refer to the exact same individual with the same identity. Such uncertainty can arise when, for example, common names may be used for different individuals (e.g., John Smith).
    ///
    /// It is appropriate to use this property when there is strong belief the two resources refer to the same individual with the same identity, but that association can not be asserted at the present time with certitude. </para>
    ///   <a href="http://umbel.org/umbel#isLike">umbel:isLike</a>
    /// </summary>
    let isLike = _prefixId.prefix "isLike"
    /// <summary>
    ///   <para>skos:prefLabel : links entity</para>
    ///   <para>skos:definition : Check the definition of umbel:isAbout for the definition of this property; isRelatedTo is the inverse property of isAbout. </para>
    ///   <a href="http://umbel.org/umbel#isRelatedTo">umbel:isRelatedTo</a>
    /// </summary>
    let isRelatedTo = _prefixId.prefix "isRelatedTo"
    /// <summary>
    ///   <para>skos:prefLabel : has abstraction</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToAbstraction">umbel:relatesToAbstraction</a>
    /// </summary>
    let relatesToAbstraction = _prefixId.prefix "relatesToAbstraction"
    /// <summary>
    ///   <para>skos:prefLabel : has activity</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToActivity">umbel:relatesToActivity</a>
    /// </summary>
    let relatesToActivity = _prefixId.prefix "relatesToActivity"
    /// <summary>
    ///   <para>skos:prefLabel : relates to animal</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToAnimal">umbel:relatesToAnimal</a>
    /// </summary>
    let relatesToAnimal = _prefixId.prefix "relatesToAnimal"
    /// <summary>
    ///   <para>skos:prefLabel : has attribute</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToAttribute">umbel:relatesToAttribute</a>
    /// </summary>
    let relatesToAttribute = _prefixId.prefix "relatesToAttribute"
    /// <summary>
    ///   <para>skos:prefLabel : relates to audio information</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToAudioInfo">umbel:relatesToAudioInfo</a>
    /// </summary>
    let relatesToAudioInfo = _prefixId.prefix "relatesToAudioInfo"
    /// <summary>
    ///   <para>skos:prefLabel : relates to chemistry</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToChemistry">umbel:relatesToChemistry</a>
    /// </summary>
    let relatesToChemistry = _prefixId.prefix "relatesToChemistry"
    /// <summary>
    ///   <para>skos:prefLabel : relates to disease</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToDisease">umbel:relatesToDisease</a>
    /// </summary>
    let relatesToDisease = _prefixId.prefix "relatesToDisease"
    /// <summary>
    ///   <para>skos:prefLabel : relates to drug</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToDrug">umbel:relatesToDrug</a>
    /// </summary>
    let relatesToDrug = _prefixId.prefix "relatesToDrug"
    /// <summary>
    ///   <para>skos:prefLabel : relates to earthscape</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToEarth">umbel:relatesToEarth</a>
    /// </summary>
    let relatesToEarth = _prefixId.prefix "relatesToEarth"
    /// <summary>
    ///   <para>skos:prefLabel : has event</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToEvent">umbel:relatesToEvent</a>
    /// </summary>
    let relatesToEvent = _prefixId.prefix "relatesToEvent"
    /// <summary>
    ///   <para>skos:prefLabel : relates to facility</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToFacility">umbel:relatesToFacility</a>
    /// </summary>
    let relatesToFacility = _prefixId.prefix "relatesToFacility"
    /// <summary>
    ///   <para>skos:prefLabel : relates to finance or economy</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToFinanceEconomy">umbel:relatesToFinanceEconomy</a>
    /// </summary>
    let relatesToFinanceEconomy = _prefixId.prefix "relatesToFinanceEconomy"
    /// <summary>
    ///   <para>skos:prefLabel : has food drink</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToFoodDrink">umbel:relatesToFoodDrink</a>
    /// </summary>
    let relatesToFoodDrink = _prefixId.prefix "relatesToFoodDrink"
    /// <summary>
    ///   <para>skos:prefLabel : relates to geopolitical entity</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToGeoEntity">umbel:relatesToGeoEntity</a>
    /// </summary>
    let relatesToGeoEntity = _prefixId.prefix "relatesToGeoEntity"
    /// <summary>
    ///   <para>skos:prefLabel : relates to extraterrestrial entity</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToHeavens">umbel:relatesToHeavens</a>
    /// </summary>
    let relatesToHeavens = _prefixId.prefix "relatesToHeavens"
    /// <summary>
    ///   <para>skos:prefLabel : relates to market or industry</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToMarketIndustry">umbel:relatesToMarketIndustry</a>
    /// </summary>
    let relatesToMarketIndustry = _prefixId.prefix "relatesToMarketIndustry"
    /// <summary>
    ///   <para>skos:prefLabel : has notation</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToNotation">umbel:relatesToNotation</a>
    /// </summary>
    let relatesToNotation = _prefixId.prefix "relatesToNotation"
    /// <summary>
    ///   <para>skos:prefLabel : relates to numbers</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToNumbers">umbel:relatesToNumbers</a>
    /// </summary>
    let relatesToNumbers = _prefixId.prefix "relatesToNumbers"
    /// <summary>
    ///   <para>skos:prefLabel : has organization type</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToOrganizationType">umbel:relatesToOrganizationType</a>
    /// </summary>
    let relatesToOrganizationType = _prefixId.prefix "relatesToOrganizationType"
    /// <summary>
    ///   <para>skos:prefLabel : relates to other organism</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToOtherOrganism">umbel:relatesToOtherOrganism</a>
    /// </summary>
    let relatesToOtherOrganism = _prefixId.prefix "relatesToOtherOrganism"
    /// <summary>
    ///   <para>skos:prefLabel : has person type</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToPersonType">umbel:relatesToPersonType</a>
    /// </summary>
    let relatesToPersonType = _prefixId.prefix "relatesToPersonType"
    /// <summary>
    ///   <para>skos:prefLabel : relates to natural phenomenon</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToPhenomenon">umbel:relatesToPhenomenon</a>
    /// </summary>
    let relatesToPhenomenon = _prefixId.prefix "relatesToPhenomenon"
    /// <summary>
    ///   <para>skos:prefLabel : relates to plant</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToPlant">umbel:relatesToPlant</a>
    /// </summary>
    let relatesToPlant = _prefixId.prefix "relatesToPlant"
    /// <summary>
    ///   <para>skos:prefLabel : has product type</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToProductType">umbel:relatesToProductType</a>
    /// </summary>
    let relatesToProductType = _prefixId.prefix "relatesToProductType"
    /// <summary>
    ///   <para>skos:prefLabel : relates to society</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToSociety">umbel:relatesToSociety</a>
    /// </summary>
    let relatesToSociety = _prefixId.prefix "relatesToSociety"
    /// <summary>
    ///   <para>skos:prefLabel : relates to structured information</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToStructuredInfo">umbel:relatesToStructuredInfo</a>
    /// </summary>
    let relatesToStructuredInfo = _prefixId.prefix "relatesToStructuredInfo"
    /// <summary>
    ///   <para>skos:prefLabel : relates to natural substance</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToSubstance">umbel:relatesToSubstance</a>
    /// </summary>
    let relatesToSubstance = _prefixId.prefix "relatesToSubstance"
    /// <summary>
    ///   <para>skos:prefLabel : has time</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToTime">umbel:relatesToTime</a>
    /// </summary>
    let relatesToTime = _prefixId.prefix "relatesToTime"
    /// <summary>
    ///   <para>skos:prefLabel : has topic</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToTopic">umbel:relatesToTopic</a>
    /// </summary>
    let relatesToTopic = _prefixId.prefix "relatesToTopic"
    /// <summary>
    ///   <para>skos:prefLabel : relates to visual information</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToVisualInfo">umbel:relatesToVisualInfo</a>
    /// </summary>
    let relatesToVisualInfo = _prefixId.prefix "relatesToVisualInfo"
    /// <summary>
    ///   <para>skos:prefLabel : has workplace</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship </para>
    ///   <a href="http://umbel.org/umbel#relatesToWorkplace">umbel:relatesToWorkplace</a>
    /// </summary>
    let relatesToWorkplace = _prefixId.prefix "relatesToWorkplace"
    /// <summary>
    ///   <para>skos:prefLabel : relates to written information</para>
    ///   <para>skos:definition : This predicate relates an external entity to the SuperType (ST) shown. It indicates there is a relationship to the ST of a verifiable nature, but which is undetermined as to strength or a full rdf:type relationship.</para>
    ///   <a href="http://umbel.org/umbel#relatesToWrittenInfo">umbel:relatesToWrittenInfo</a>
    /// </summary>
    let relatesToWrittenInfo = _prefixId.prefix "relatesToWrittenInfo"
    /// <summary>
    ///   <para>skos:prefLabel : super property of</para>
    ///   <para>skos:definition : Specifies that a property is a super property of another property. This is the inverse of rdfs:subPropertyOf</para>
    ///   <a href="http://umbel.org/umbel#superPropertyOf">umbel:superPropertyOf</a>
    /// </summary>
    let superPropertyOf = _prefixId.prefix "superPropertyOf"
