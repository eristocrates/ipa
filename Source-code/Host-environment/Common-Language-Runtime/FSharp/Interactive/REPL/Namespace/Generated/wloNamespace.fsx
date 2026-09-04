#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wlo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/wo/" "wlo"
    let _namespaceIri = _prefixId.prefix ""
    let ``_0.1`` = _prefixId.prefix "0.1"
    let ``_1.0`` = _prefixId.prefix "1.0"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Adaptation</para>
    ///   <para>rdfs:comment : An adaptation is any feature of an animal or plant which makes it better suited for a particular habitat or to do a particular task. For instance, being streamlined is an adaptation to swimming fast and being able to survive on very little water is an adaptation to life in the desert.</para>
    ///   <a href="http://purl.org/ontology/wo/Adaptation">wlo:Adaptation</a>
    /// </summary>
    let Adaptation = _prefixId.prefix "Adaptation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Animal Intelligence</para>
    ///   <para>rdfs:comment : Animal Intelligence or animal cognition is the title given to a modern approach to the mental capacities of non-human animals. It has developed out of comparative psychology, but has also been strongly influenced by the approach of ethology, behavioral ecology, and evolutionary psychology.</para>
    ///   <a href="http://purl.org/ontology/wo/AnimalIntelligence">wlo:AnimalIntelligence</a>
    /// </summary>
    let AnimalIntelligence = _prefixId.prefix "AnimalIntelligence"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Behavioural Pattern</para>
    ///   <para>rdfs:comment : Behavioural pattern describes an animal's dominant way of life. Arboreal animals, for example, live in trees and nocturnal animals are active at night.</para>
    ///   <a href="http://purl.org/ontology/wo/BehaviouralPattern">wlo:BehaviouralPattern</a>
    /// </summary>
    let BehaviouralPattern = _prefixId.prefix "BehaviouralPattern"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Class</para>
    ///   <para>rdfs:comment : A class is a scientific way to group related organisms together, some examples of classes being jellyfish, reptiles and sea urchins. Classes are big groups and contain within them smaller groupings called orders, families, genera and species.</para>
    ///   <a href="http://purl.org/ontology/wo/Class">wlo:Class</a>
    /// </summary>
    let Class = _prefixId.prefix "Class"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Collection^^xsd:string</para>
    ///   <para>rdfs:comment : A collection of resources, including documents, multimedia files, programme clips and their associated taxa, which aims to showcase a particular aspect of natural history film-making, or illustrate aspects of the natural world. A collection provides an alternate way to organize content over and above the basic taxonomic hierarchy.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/wo/Collection">wlo:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Communication Adaptation</para>
    ///   <para>rdfs:comment : Communication and senses are how an organism perceives the world - for instance through scent or sight - and how it sends messages or warnings to others.</para>
    ///   <a href="http://purl.org/ontology/wo/CommunicationAdaptation">wlo:CommunicationAdaptation</a>
    /// </summary>
    let CommunicationAdaptation = _prefixId.prefix "CommunicationAdaptation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Conservation Status</para>
    ///   <para>rdfs:comment : Conservation status as described by the IUCN Red List. Will typically have a number of properties including an official IUCN status, population trend, and a year of assessment.</para>
    ///   <a href="http://purl.org/ontology/wo/ConservationStatus">wlo:ConservationStatus</a>
    /// </summary>
    let ConservationStatus = _prefixId.prefix "ConservationStatus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Ecosystem Role</para>
    ///   <para>rdfs:comment : Ecosystem roles are about the part an animal or plant plays in sustaining or maintaining the habitat around them. Bees, for example, pollinate flowers, without which those plants would not produce fruits or seeds. Other species, such as dung beetles, play a vital role in keeping grasslands clear of animal waste and recycling valuable resources.</para>
    ///   <a href="http://purl.org/ontology/wo/EcosystemRole">wlo:EcosystemRole</a>
    /// </summary>
    let EcosystemRole = _prefixId.prefix "EcosystemRole"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Ecozone</para>
    ///   <para>rdfs:comment : Ecozones are a method of dividing up the Earth's surface. Each ecozone is a large area that contains a number of habitats, which are linked by the evolutionary history of the animals and plants within them. For instance one ecozone is Australasia, because its marsupials evolved in isolation to mammals in the rest of the world.</para>
    ///   <a href="http://purl.org/ontology/wo/Ecozone">wlo:Ecozone</a>
    /// </summary>
    let Ecozone = _prefixId.prefix "Ecozone"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Adapted to Extremes</para>
    ///   <para>rdfs:comment : Organisms that are adapted to extremes (known as Extremophiles) are organisms that thrives in and even may require physically or geochemically extreme conditions that are detrimental to the majority of life on Earth.</para>
    ///   <a href="http://purl.org/ontology/wo/ExtremesAdaptation">wlo:ExtremesAdaptation</a>
    /// </summary>
    let ExtremesAdaptation = _prefixId.prefix "ExtremesAdaptation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Family</para>
    ///   <para>rdfs:comment : A family is a scientific grouping of closely related organisms. It has smaller groups, called genera and species, within it. A family can have a lot of members or only a few. Examples of families include the cats (Felidae), the gulls (Laridae) and the grasses (Poaceae).</para>
    ///   <a href="http://purl.org/ontology/wo/Family">wlo:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Feeding Habit</para>
    ///   <para>rdfs:comment : Feeding habits describe the dominant diet of a particular species or group of species, and how they go about obtaining it.</para>
    ///   <a href="http://purl.org/ontology/wo/FeedingHabit">wlo:FeedingHabit</a>
    /// </summary>
    let FeedingHabit = _prefixId.prefix "FeedingHabit"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Freshwater Habitat</para>
    ///   <para>rdfs:comment : Freshwater habitats include bogs, ponds, lakes, rivers and streams. About 3% of Earth's water is freshwater, but this includes the water locked up in the ice caps and trapped in rocks and soil as groundwater. Only a tiny fraction (0.014%) is surface water in the form of rivers, lakes and swamps.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/wo/FreshwaterHabitat">wlo:FreshwaterHabitat</a>
    /// </summary>
    let FreshwaterHabitat = _prefixId.prefix "FreshwaterHabitat"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Genus</para>
    ///   <para>rdfs:comment : A genus is a scientific way of showing that species are very closed related to each other. In fact the first word of the species' scientific name is its genus. So for lions (Panthera leo), Panthera is the genus and tells us that they are closely related to tigers (Panthera tigris), because they share the name</para>
    ///   <a href="http://purl.org/ontology/wo/Genus">wlo:Genus</a>
    /// </summary>
    let Genus = _prefixId.prefix "Genus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Habitat</para>
    ///   <para>rdfs:comment : A habitat, or biome, is the type of environment in which plant and animals live. Habitat is dictated by what kinds of plants grow there, the climate and the geography. Rainforest, coral reefs and the tundra are all habitats where particular kinds of plants and animals might be found.</para>
    ///   <a href="http://purl.org/ontology/wo/Habitat">wlo:Habitat</a>
    /// </summary>
    let Habitat = _prefixId.prefix "Habitat"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Kingdom</para>
    ///   <para>rdfs:comment : Kingdoms are the major categories into which scientists divide up all living things. The main kingdoms are animals, plants, fungi and bacteria, although there are others. Each kingdom has its own suite of defining characteristics - for instance plants have rigid cell walls, whilst animals do not.</para>
    ///   <a href="http://purl.org/ontology/wo/Kingdom">wlo:Kingdom</a>
    /// </summary>
    let Kingdom = _prefixId.prefix "Kingdom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Life Cycle</para>
    ///   <para>rdfs:comment : An organism's Life Cycle describes the stages in an organisms development including metamorphosis, courtship displays and parental care..</para>
    ///   <a href="http://purl.org/ontology/wo/LifeCycle">wlo:LifeCycle</a>
    /// </summary>
    let LifeCycle = _prefixId.prefix "LifeCycle"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Locomotion</para>
    ///   <para>rdfs:comment : Locomotion is how an animal gets around - for instance by swimming, flying or climbing.</para>
    ///   <a href="http://purl.org/ontology/wo/LocomotionAdaptation">wlo:LocomotionAdaptation</a>
    /// </summary>
    let LocomotionAdaptation = _prefixId.prefix "LocomotionAdaptation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Marine Habitat</para>
    ///   <para>rdfs:comment : Approximately 71% of the Earth's surface is covered by the oceans, an area of some 223698816km/sq. Although marine life evolved around three billion years before life on land, marine habitats are relatively poorly studied and much of the ocean's depths remains unexplored.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/wo/MarineHabitat">wlo:MarineHabitat</a>
    /// </summary>
    let MarineHabitat = _prefixId.prefix "MarineHabitat"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Morphology</para>
    ///   <para>rdfs:comment : Morphology is anything to do with what a plant or animal looks like - its size, shape, colour or structure.</para>
    ///   <a href="http://purl.org/ontology/wo/MorphologyAdaptation">wlo:MorphologyAdaptation</a>
    /// </summary>
    let MorphologyAdaptation = _prefixId.prefix "MorphologyAdaptation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Order</para>
    ///   <para>rdfs:comment : An order is a scientific way to categorise related organisms. An order is a smaller grouping than a class, but bigger than a family or genus. Examples of orders are willows, cockroaches and primates.</para>
    ///   <a href="http://purl.org/ontology/wo/Order">wlo:Order</a>
    /// </summary>
    let Order = _prefixId.prefix "Order"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Phylum</para>
    ///   <para>rdfs:comment : A phylum - also known as a division when referring to plants - is a scientfic way of grouping together related organisms. All the members of a phylum have a common ancestor and anatomical similarities. For instance, all the arthropods have external skeletons. Phlya are large groups and are further subdivided into classes, orders, families and so on.</para>
    ///   <a href="http://purl.org/ontology/wo/Phylum">wlo:Phylum</a>
    /// </summary>
    let Phylum = _prefixId.prefix "Phylum"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Predation Strategy</para>
    ///   <para>rdfs:comment : Predation is catching and killing an animal in order to eat it. The prey can be chased, ambushed or caught in a trap such as a spider's web.</para>
    ///   <a href="http://purl.org/ontology/wo/PredationStrategy">wlo:PredationStrategy</a>
    /// </summary>
    let PredationStrategy = _prefixId.prefix "PredationStrategy"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Red List Status</para>
    ///   <para>rdfs:comment : A category in the IUCN red list, 2001.</para>
    ///   <a href="http://purl.org/ontology/wo/RedListStatus">wlo:RedListStatus</a>
    /// </summary>
    let RedListStatus = _prefixId.prefix "RedListStatus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Reproduction Strategy</para>
    ///   <para>rdfs:comment : Reproduction covers all the tactics and behaviours involved in obtaining a mate, conceiving the next generation and successfully raising them. It includes everything from plants being pollinated, to stags fighting over hinds, to lionesses babysitting their sisters' cubs.</para>
    ///   <a href="http://purl.org/ontology/wo/ReproductionStrategy">wlo:ReproductionStrategy</a>
    /// </summary>
    let ReproductionStrategy = _prefixId.prefix "ReproductionStrategy"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Social Behaviour</para>
    ///   <para>rdfs:comment : Social behaviour is all about how an animal interacts with members of its own species. For instance, does it live in a colony or on its own, does it fight to be top of the pecking order, or does it try to keep strangers away from its home?</para>
    ///   <a href="http://purl.org/ontology/wo/SocialBehaviour">wlo:SocialBehaviour</a>
    /// </summary>
    let SocialBehaviour = _prefixId.prefix "SocialBehaviour"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : species</para>
    ///   <para>rdfs:comment : Generic class defining a biological species</para>
    ///   <a href="http://purl.org/ontology/wo/Species">wlo:Species</a>
    /// </summary>
    let Species = _prefixId.prefix "Species"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Survival Strategy</para>
    ///   <para>rdfs:comment : Survival strategies include adaptations to changes in the organisms environment, including: hibernation, abscission and migration.</para>
    ///   <a href="http://purl.org/ontology/wo/SurvivalStrategy">wlo:SurvivalStrategy</a>
    /// </summary>
    let SurvivalStrategy = _prefixId.prefix "SurvivalStrategy"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Taxon Name</para>
    ///   <para>rdfs:comment : A taxonomic name, describing the structure and provenance of a taxonomic name.</para>
    ///   <a href="http://purl.org/ontology/wo/TaxonName">wlo:TaxonName</a>
    /// </summary>
    let TaxonName = _prefixId.prefix "TaxonName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Taxonomic Rank</para>
    ///   <para>rdfs:comment : Generic concept for a taxonomic rank such as a Genus or Species.</para>
    ///   <a href="http://purl.org/ontology/wo/TaxonRank">wlo:TaxonRank</a>
    /// </summary>
    let TaxonRank = _prefixId.prefix "TaxonRank"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Terrestrial Habitat</para>
    ///   <para>rdfs:comment : Terrestrial habitats include forests, grasslands, deserts and rainforests. They are typically defined by factors such as plant structure (trees and grasses), leaf types (eg broadleaf and needleleaf), plant spacing (forest, woodland, savanna) and climate.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/wo/TerrestrialHabitat">wlo:TerrestrialHabitat</a>
    /// </summary>
    let TerrestrialHabitat = _prefixId.prefix "TerrestrialHabitat"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : adaptation</para>
    ///   <para>rdfs:comment : associates a taxon rank with an adaptation which it displays</para>
    ///   <a href="http://purl.org/ontology/wo/adaptation">wlo:adaptation</a>
    /// </summary>
    let adaptation = _prefixId.prefix "adaptation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : class</para>
    ///   <para>rdfs:comment : associates a taxon rank with a class</para>
    ///   <a href="http://purl.org/ontology/wo/class">wlo:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : class name</para>
    ///   <para>rdfs:comment : Used to specify the name of a class as part of a Taxon Name</para>
    ///   <a href="http://purl.org/ontology/wo/className">wlo:className</a>
    /// </summary>
    let className = _prefixId.prefix "className"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : collection</para>
    ///   <para>rdfs:comment : associates a taxon rank, habitat, species, clip with a collection of which it is a member</para>
    ///   <a href="http://purl.org/ontology/wo/collection">wlo:collection</a>
    /// </summary>
    let collection = _prefixId.prefix "collection"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : common name</para>
    ///   <para>rdfs:comment : associates a formal taxon name with a common version. E.g. Panthera leo might be associated with a common name of 'Lion'. A given taxon name may have several common names</para>
    ///   <a href="http://purl.org/ontology/wo/commonName">wlo:commonName</a>
    /// </summary>
    let commonName = _prefixId.prefix "commonName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : conservation status</para>
    ///   <para>rdfs:comment : associates a taxon rank with a description of a recent assessment of its conservation status</para>
    ///   <a href="http://purl.org/ontology/wo/conservationStatus">wlo:conservationStatus</a>
    /// </summary>
    let conservationStatus = _prefixId.prefix "conservationStatus"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : distribution map</para>
    ///   <para>rdfs:comment : associates a habitat, ecozone, or taxon rank with a map depicting its distribution or location</para>
    ///   <a href="http://purl.org/ontology/wo/distributionMap">wlo:distributionMap</a>
    /// </summary>
    let distributionMap = _prefixId.prefix "distributionMap"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : ecozone</para>
    ///   <para>rdfs:comment : indicates that a habitat or a taxon rank can be found within an ecozone</para>
    ///   <a href="http://purl.org/ontology/wo/ecozone">wlo:ecozone</a>
    /// </summary>
    let ecozone = _prefixId.prefix "ecozone"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : family</para>
    ///   <para>rdfs:comment : associates a taxon rank with a family</para>
    ///   <a href="http://purl.org/ontology/wo/family">wlo:family</a>
    /// </summary>
    let family = _prefixId.prefix "family"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : family name</para>
    ///   <para>rdfs:comment : Used to specify the name of a family as part of a Taxon Name</para>
    ///   <a href="http://purl.org/ontology/wo/familyName">wlo:familyName</a>
    /// </summary>
    let familyName = _prefixId.prefix "familyName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : genus</para>
    ///   <para>rdfs:comment : associates a taxon rank with a genus</para>
    ///   <a href="http://purl.org/ontology/wo/genus">wlo:genus</a>
    /// </summary>
    let genus = _prefixId.prefix "genus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : genus name</para>
    ///   <para>rdfs:comment : specifies the genus part of a binomial name, allowing this portion of the name to be explicitly described. Therefore this property will typically only be used in TaxonNames associated with species. The property is largely provided as a convenience to avoid applications having to parse the binomial name.</para>
    ///   <a href="http://purl.org/ontology/wo/genusName">wlo:genusName</a>
    /// </summary>
    let genusName = _prefixId.prefix "genusName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : grows in</para>
    ///   <para>rdfs:comment : associates a taxon rank with a habitat in which it grows. Sub-property of wo:habitat to be used for plants, fungi, etc</para>
    ///   <a href="http://purl.org/ontology/wo/growsIn">wlo:growsIn</a>
    /// </summary>
    let growsIn = _prefixId.prefix "growsIn"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : habitat</para>
    ///   <para>rdfs:comment : associates a taxon rank with a habitat in which it may typically be found</para>
    ///   <a href="http://purl.org/ontology/wo/habitat">wlo:habitat</a>
    /// </summary>
    let habitat = _prefixId.prefix "habitat"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : kingdom</para>
    ///   <para>rdfs:comment : associates a taxon rank with a kingdom</para>
    ///   <a href="http://purl.org/ontology/wo/kingdom">wlo:kingdom</a>
    /// </summary>
    let kingdom = _prefixId.prefix "kingdom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : kingdom name</para>
    ///   <para>rdfs:comment : Used to specify the name of a kingdom as part of a Taxon Name</para>
    ///   <a href="http://purl.org/ontology/wo/kingdomName">wlo:kingdomName</a>
    /// </summary>
    let kingdomName = _prefixId.prefix "kingdomName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : lives in</para>
    ///   <para>rdfs:comment : associates a taxon rank with a habitat in which it lives. Sub-property of wo:habitat to be used for members of the animal kingdom</para>
    ///   <a href="http://purl.org/ontology/wo/livesIn">wlo:livesIn</a>
    /// </summary>
    let livesIn = _prefixId.prefix "livesIn"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : name</para>
    ///   <para>rdfs:comment : associates a taxon rank with a taxon name</para>
    ///   <a href="http://purl.org/ontology/wo/name">wlo:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : order</para>
    ///   <para>rdfs:comment : associates a taxon rank with an order</para>
    ///   <a href="http://purl.org/ontology/wo/order">wlo:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : order name</para>
    ///   <para>rdfs:comment : Used to specify the name of an order as part of a Taxon Name</para>
    ///   <a href="http://purl.org/ontology/wo/orderName">wlo:orderName</a>
    /// </summary>
    let orderName = _prefixId.prefix "orderName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : phylum</para>
    ///   <para>rdfs:comment : associates a taxon rank with a phylum</para>
    ///   <a href="http://purl.org/ontology/wo/phylum">wlo:phylum</a>
    /// </summary>
    let phylum = _prefixId.prefix "phylum"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : phylum name</para>
    ///   <para>rdfs:comment : Used to specify the name of a phylum as part of a Taxon Name</para>
    ///   <a href="http://purl.org/ontology/wo/phylumName">wlo:phylumName</a>
    /// </summary>
    let phylumName = _prefixId.prefix "phylumName"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : population trend</para>
    ///   <para>rdfs:comment : provides some indication of the population trend associated with an assessment of a taxon's conversation status. The value of this property is a simple literal, and is recommended to be one of: Decreasing, Increasing, Stable, Unknown.</para>
    ///   <a href="http://purl.org/ontology/wo/populationTrend">wlo:populationTrend</a>
    /// </summary>
    let populationTrend = _prefixId.prefix "populationTrend"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : red list status</para>
    ///   <para>rdfs:comment : associates a Conservation Status with a category in the IUCN Red List</para>
    ///   <a href="http://purl.org/ontology/wo/redListStatus">wlo:redListStatus</a>
    /// </summary>
    let redListStatus = _prefixId.prefix "redListStatus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : scientific name</para>
    ///   <para>rdfs:comment : associates a taxon name with its formal scientific name. This may be a binomial name (e.g. Panthera leo) in the case of a species name, or a uninomial (e.g. Panthera) name in the case of a name associated with another taxon rank. In formal taxonomic naming conventions, the scientific name is often qualified with the source of the name, e.g. Panthera leo (Linnaeus, 1758).</para>
    ///   <a href="http://purl.org/ontology/wo/scientificName">wlo:scientificName</a>
    /// </summary>
    let scientificName = _prefixId.prefix "scientificName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : short description</para>
    ///   <para>rdfs:comment : associates a short description with a Collection.</para>
    ///   <a href="http://purl.org/ontology/wo/shortDescription">wlo:shortDescription</a>
    /// </summary>
    let shortDescription = _prefixId.prefix "shortDescription"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : species</para>
    ///   <para>rdfs:comment : associates a taxon rank with a species</para>
    ///   <a href="http://purl.org/ontology/wo/species">wlo:species</a>
    /// </summary>
    let species = _prefixId.prefix "species"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : species name</para>
    ///   <para>rdfs:comment : specifies the species part of a binomial name, allowing this portion of the name to be explicitly described. Therefore this property will typically only be used in TaxonNames associated with species. The property is largely provided as a convenience to avoid applications having to parse the binomial name.</para>
    ///   <a href="http://purl.org/ontology/wo/speciesName">wlo:speciesName</a>
    /// </summary>
    let speciesName = _prefixId.prefix "speciesName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : taxonomic name</para>
    ///   <para>rdfs:comment : a naming property, associating a formal taxonomic name with a Taxon Name instance. This property is a parent of a number of sub-properties that provide more specific terms for denoting names of families, phyla, species, etc.</para>
    ///   <a href="http://purl.org/ontology/wo/taxonomicName">wlo:taxonomicName</a>
    /// </summary>
    let taxonomicName = _prefixId.prefix "taxonomicName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : threatDescription</para>
    ///   <para>rdfs:comment : description of the threat(s) that have been identified as part of the assessment of the Conservation Status of a taxon</para>
    ///   <a href="http://purl.org/ontology/wo/threatDescription">wlo:threatDescription</a>
    /// </summary>
    let threatDescription = _prefixId.prefix "threatDescription"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : year assessed</para>
    ///   <para>rdfs:comment : the year in which the conservation status was assessed.</para>
    ///   <a href="http://purl.org/ontology/wo/yearAssessed">wlo:yearAssessed</a>
    /// </summary>
    let yearAssessed = _prefixId.prefix "yearAssessed"
