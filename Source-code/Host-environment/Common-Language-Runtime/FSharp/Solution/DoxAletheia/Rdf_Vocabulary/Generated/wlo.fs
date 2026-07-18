namespace http.purl.org.ontology.wo.slash

open DoxAletheia.Rdf_Vocabulary

module wlo =
    let _namespace_name = "http://purl.org/ontology/wo/"
    /// <summary>
    ///   <see href="http://purl.org/ontology/wo/0.1"></see>
    /// </summary>
    let ``_0.1`` = Namespaced_IRI.parse _namespace_name "0.1" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/wo/1.0"></see>
    /// </summary>
    let ``_1.0`` = Namespaced_IRI.parse _namespace_name "1.0" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/wo/#tom"></see>
    /// </summary>
    let ``_#tom`` = Namespaced_IRI.parse _namespace_name "#tom" |> NamespacedName
    /// <summary>
    /// An adaptation is any feature of an animal or plant which makes it better suited for a particular habitat or to do a particular task. For instance, being streamlined is an adaptation to swimming fast and being able to survive on very little water is an adaptation to life in the desert.
    /// <see href="http://purl.org/ontology/wo/Adaptation"></see></summary>
    let Adaptation = Namespaced_IRI.parse _namespace_name "Adaptation" |> NamespacedName

    /// <summary>
    /// Animal Intelligence or animal cognition is the title given to a modern approach to the mental capacities of non-human animals. It has developed out of comparative psychology, but has also been strongly influenced by the approach of ethology, behavioral ecology, and evolutionary psychology.
    /// <see href="http://purl.org/ontology/wo/AnimalIntelligence"></see></summary>
    let AnimalIntelligence =
        Namespaced_IRI.parse _namespace_name "AnimalIntelligence" |> NamespacedName

    /// <summary>
    /// Behavioural pattern describes an animal's dominant way of life. Arboreal animals, for example, live in trees and nocturnal animals are active at night.
    /// <see href="http://purl.org/ontology/wo/BehaviouralPattern"></see></summary>
    let BehaviouralPattern =
        Namespaced_IRI.parse _namespace_name "BehaviouralPattern" |> NamespacedName

    /// <summary>
    /// A class is a scientific way to group related organisms together, some examples of classes being jellyfish, reptiles and sea urchins. Classes are big groups and contain within them smaller groupings called orders, families, genera and species.
    /// <see href="http://purl.org/ontology/wo/Class"></see></summary>
    let Class = Namespaced_IRI.parse _namespace_name "Class" |> NamespacedName
    /// <summary>
    /// Generic concept for a taxonomic rank such as a Genus or Species.
    /// <see href="http://purl.org/ontology/wo/TaxonRank"></see></summary>
    let TaxonRank = Namespaced_IRI.parse _namespace_name "TaxonRank" |> NamespacedName
    /// <summary>
    /// A collection of resources, including documents, multimedia files, programme clips and their associated taxa, which aims to showcase a particular aspect of natural history film-making, or illustrate aspects of the natural world. A collection provides an alternate way to organize content over and above the basic taxonomic hierarchy.
    /// <see href="http://purl.org/ontology/wo/Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName

    /// <summary>
    /// Communication and senses are how an organism perceives the world - for instance through scent or sight - and how it sends messages or warnings to others.
    /// <see href="http://purl.org/ontology/wo/CommunicationAdaptation"></see></summary>
    let CommunicationAdaptation =
        Namespaced_IRI.parse _namespace_name "CommunicationAdaptation" |> NamespacedName

    /// <summary>
    /// Conservation status as described by the IUCN Red List. Will typically have a number of properties including an official IUCN status, population trend, and a year of assessment.
    /// <see href="http://purl.org/ontology/wo/ConservationStatus"></see></summary>
    let ConservationStatus =
        Namespaced_IRI.parse _namespace_name "ConservationStatus" |> NamespacedName

    /// <summary>
    /// Ecosystem roles are about the part an animal or plant plays in sustaining or maintaining the habitat around them. Bees, for example, pollinate flowers, without which those plants would not produce fruits or seeds. Other species, such as dung beetles, play a vital role in keeping grasslands clear of animal waste and recycling valuable resources.
    /// <see href="http://purl.org/ontology/wo/EcosystemRole"></see></summary>
    let EcosystemRole =
        Namespaced_IRI.parse _namespace_name "EcosystemRole" |> NamespacedName

    /// <summary>
    /// Ecozones are a method of dividing up the Earth's surface. Each ecozone is a large area that contains a number of habitats, which are linked by the evolutionary history of the animals and plants within them. For instance one ecozone is Australasia, because its marsupials evolved in isolation to mammals in the rest of the world.
    /// <see href="http://purl.org/ontology/wo/Ecozone"></see></summary>
    let Ecozone = Namespaced_IRI.parse _namespace_name "Ecozone" |> NamespacedName

    /// <summary>
    /// Organisms that are adapted to extremes (known as Extremophiles) are organisms that thrives in and even may require physically or geochemically extreme conditions that are detrimental to the majority of life on Earth.
    /// <see href="http://purl.org/ontology/wo/ExtremesAdaptation"></see></summary>
    let ExtremesAdaptation =
        Namespaced_IRI.parse _namespace_name "ExtremesAdaptation" |> NamespacedName

    /// <summary>
    /// A family is a scientific grouping of closely related organisms. It has smaller groups, called genera and species, within it. A family can have a lot of members or only a few. Examples of families include the cats (Felidae), the gulls (Laridae) and the grasses (Poaceae).
    /// <see href="http://purl.org/ontology/wo/Family"></see></summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName

    /// <summary>
    /// Feeding habits describe the dominant diet of a particular species or group of species, and how they go about obtaining it.
    /// <see href="http://purl.org/ontology/wo/FeedingHabit"></see></summary>
    let FeedingHabit =
        Namespaced_IRI.parse _namespace_name "FeedingHabit" |> NamespacedName

    /// <summary>
    /// Freshwater habitats include bogs, ponds, lakes, rivers and streams. About 3% of Earth's water is freshwater, but this includes the water locked up in the ice caps and trapped in rocks and soil as groundwater. Only a tiny fraction (0.014%) is surface water in the form of rivers, lakes and swamps.
    /// <see href="http://purl.org/ontology/wo/FreshwaterHabitat"></see></summary>
    let FreshwaterHabitat =
        Namespaced_IRI.parse _namespace_name "FreshwaterHabitat" |> NamespacedName

    /// <summary>
    /// A habitat, or biome, is the type of environment in which plant and animals live. Habitat is dictated by what kinds of plants grow there, the climate and the geography. Rainforest, coral reefs and the tundra are all habitats where particular kinds of plants and animals might be found.
    /// <see href="http://purl.org/ontology/wo/Habitat"></see></summary>
    let Habitat = Namespaced_IRI.parse _namespace_name "Habitat" |> NamespacedName
    /// <summary>
    /// A genus is a scientific way of showing that species are very closed related to each other. In fact the first word of the species' scientific name is its genus. So for lions (Panthera leo), Panthera is the genus and tells us that they are closely related to tigers (Panthera tigris), because they share the name
    /// <see href="http://purl.org/ontology/wo/Genus"></see></summary>
    let Genus = Namespaced_IRI.parse _namespace_name "Genus" |> NamespacedName
    /// <summary>
    /// Kingdoms are the major categories into which scientists divide up all living things. The main kingdoms are animals, plants, fungi and bacteria, although there are others. Each kingdom has its own suite of defining characteristics - for instance plants have rigid cell walls, whilst animals do not.
    /// <see href="http://purl.org/ontology/wo/Kingdom"></see></summary>
    let Kingdom = Namespaced_IRI.parse _namespace_name "Kingdom" |> NamespacedName
    /// <summary>
    /// An organism's Life Cycle describes the stages in an organisms development including metamorphosis, courtship displays and parental care..
    /// <see href="http://purl.org/ontology/wo/LifeCycle"></see></summary>
    let LifeCycle = Namespaced_IRI.parse _namespace_name "LifeCycle" |> NamespacedName

    /// <summary>
    /// Locomotion is how an animal gets around - for instance by swimming, flying or climbing.
    /// <see href="http://purl.org/ontology/wo/LocomotionAdaptation"></see></summary>
    let LocomotionAdaptation =
        Namespaced_IRI.parse _namespace_name "LocomotionAdaptation" |> NamespacedName

    /// <summary>
    /// Approximately 71% of the Earth's surface is covered by the oceans, an area of some 223698816km/sq. Although marine life evolved around three billion years before life on land, marine habitats are relatively poorly studied and much of the ocean's depths remains unexplored.
    /// <see href="http://purl.org/ontology/wo/MarineHabitat"></see></summary>
    let MarineHabitat =
        Namespaced_IRI.parse _namespace_name "MarineHabitat" |> NamespacedName

    /// <summary>
    /// Morphology is anything to do with what a plant or animal looks like - its size, shape, colour or structure.
    /// <see href="http://purl.org/ontology/wo/MorphologyAdaptation"></see></summary>
    let MorphologyAdaptation =
        Namespaced_IRI.parse _namespace_name "MorphologyAdaptation" |> NamespacedName

    /// <summary>
    /// An order is a scientific way to categorise related organisms. An order is a smaller grouping than a class, but bigger than a family or genus. Examples of orders are willows, cockroaches and primates.
    /// <see href="http://purl.org/ontology/wo/Order"></see></summary>
    let Order = Namespaced_IRI.parse _namespace_name "Order" |> NamespacedName
    /// <summary>
    /// A phylum - also known as a division when referring to plants - is a scientfic way of grouping together related organisms. All the members of a phylum have a common ancestor and anatomical similarities. For instance, all the arthropods have external skeletons. Phlya are large groups and are further subdivided into classes, orders, families and so on.
    /// <see href="http://purl.org/ontology/wo/Phylum"></see></summary>
    let Phylum = Namespaced_IRI.parse _namespace_name "Phylum" |> NamespacedName

    /// <summary>
    /// Predation is catching and killing an animal in order to eat it. The prey can be chased, ambushed or caught in a trap such as a spider's web.
    /// <see href="http://purl.org/ontology/wo/PredationStrategy"></see></summary>
    let PredationStrategy =
        Namespaced_IRI.parse _namespace_name "PredationStrategy" |> NamespacedName

    /// <summary>
    /// A category in the IUCN red list, 2001.
    /// <see href="http://purl.org/ontology/wo/RedListStatus"></see></summary>
    let RedListStatus =
        Namespaced_IRI.parse _namespace_name "RedListStatus" |> NamespacedName

    /// <summary>
    /// Reproduction covers all the tactics and behaviours involved in obtaining a mate, conceiving the next generation and successfully raising them. It includes everything from plants being pollinated, to stags fighting over hinds, to lionesses babysitting their sisters' cubs.
    /// <see href="http://purl.org/ontology/wo/ReproductionStrategy"></see></summary>
    let ReproductionStrategy =
        Namespaced_IRI.parse _namespace_name "ReproductionStrategy" |> NamespacedName

    /// <summary>
    /// Social behaviour is all about how an animal interacts with members of its own species. For instance, does it live in a colony or on its own, does it fight to be top of the pecking order, or does it try to keep strangers away from its home?
    /// <see href="http://purl.org/ontology/wo/SocialBehaviour"></see></summary>
    let SocialBehaviour =
        Namespaced_IRI.parse _namespace_name "SocialBehaviour" |> NamespacedName

    /// <summary>
    /// Generic class defining a biological species
    /// <see href="http://purl.org/ontology/wo/Species"></see></summary>
    let Species = Namespaced_IRI.parse _namespace_name "Species" |> NamespacedName

    /// <summary>
    /// Survival strategies include adaptations to changes in the organisms environment, including: hibernation, abscission and migration.
    /// <see href="http://purl.org/ontology/wo/SurvivalStrategy"></see></summary>
    let SurvivalStrategy =
        Namespaced_IRI.parse _namespace_name "SurvivalStrategy" |> NamespacedName

    /// <summary>
    /// A taxonomic name, describing the structure and provenance of a taxonomic name.
    /// <see href="http://purl.org/ontology/wo/TaxonName"></see></summary>
    let TaxonName = Namespaced_IRI.parse _namespace_name "TaxonName" |> NamespacedName

    /// <summary>
    /// Terrestrial habitats include forests, grasslands, deserts and rainforests. They are typically defined by factors such as plant structure (trees and grasses), leaf types (eg broadleaf and needleleaf), plant spacing (forest, woodland, savanna) and climate.
    /// <see href="http://purl.org/ontology/wo/TerrestrialHabitat"></see></summary>
    let TerrestrialHabitat =
        Namespaced_IRI.parse _namespace_name "TerrestrialHabitat" |> NamespacedName

    /// <summary>
    /// associates a taxon rank with an adaptation which it displays
    /// <see href="http://purl.org/ontology/wo/adaptation"></see></summary>
    let adaptation = Namespaced_IRI.parse _namespace_name "adaptation" |> NamespacedName
    /// <summary>
    /// associates a taxon rank with a class
    /// <see href="http://purl.org/ontology/wo/class"></see></summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName
    /// <summary>
    /// Used to specify the name of a class as part of a Taxon Name
    /// <see href="http://purl.org/ontology/wo/className"></see></summary>
    let className = Namespaced_IRI.parse _namespace_name "className" |> NamespacedName

    /// <summary>
    /// a naming property, associating a formal taxonomic name with a Taxon Name instance. This property is a parent of a number of sub-properties that provide more specific terms for denoting names of families, phyla, species, etc.
    /// <see href="http://purl.org/ontology/wo/taxonomicName"></see></summary>
    let taxonomicName =
        Namespaced_IRI.parse _namespace_name "taxonomicName" |> NamespacedName

    /// <summary>
    /// associates a taxon rank, habitat, species, clip with a collection of which it is a member
    /// <see href="http://purl.org/ontology/wo/collection"></see></summary>
    let collection = Namespaced_IRI.parse _namespace_name "collection" |> NamespacedName
    /// <summary>
    /// associates a formal taxon name with a common version. E.g. Panthera leo might be associated with a common name of 'Lion'. A given taxon name may have several common names
    /// <see href="http://purl.org/ontology/wo/commonName"></see></summary>
    let commonName = Namespaced_IRI.parse _namespace_name "commonName" |> NamespacedName

    /// <summary>
    /// associates a taxon rank with a description of a recent assessment of its conservation status
    /// <see href="http://purl.org/ontology/wo/conservationStatus"></see></summary>
    let conservationStatus =
        Namespaced_IRI.parse _namespace_name "conservationStatus" |> NamespacedName

    /// <summary>
    /// associates a habitat, ecozone, or taxon rank with a map depicting its distribution or location
    /// <see href="http://purl.org/ontology/wo/distributionMap"></see></summary>
    let distributionMap =
        Namespaced_IRI.parse _namespace_name "distributionMap" |> NamespacedName

    /// <summary>
    /// indicates that a habitat or a taxon rank can be found within an ecozone
    /// <see href="http://purl.org/ontology/wo/ecozone"></see></summary>
    let ecozone = Namespaced_IRI.parse _namespace_name "ecozone" |> NamespacedName
    /// <summary>
    /// associates a taxon rank with a family
    /// <see href="http://purl.org/ontology/wo/family"></see></summary>
    let family = Namespaced_IRI.parse _namespace_name "family" |> NamespacedName
    /// <summary>
    /// Used to specify the name of a family as part of a Taxon Name
    /// <see href="http://purl.org/ontology/wo/familyName"></see></summary>
    let familyName = Namespaced_IRI.parse _namespace_name "familyName" |> NamespacedName
    /// <summary>
    /// associates a taxon rank with a genus
    /// <see href="http://purl.org/ontology/wo/genus"></see></summary>
    let genus = Namespaced_IRI.parse _namespace_name "genus" |> NamespacedName
    /// <summary>
    /// specifies the genus part of a binomial name, allowing this portion of the name to be explicitly described. Therefore this property will typically only be used in TaxonNames associated with species. The property is largely provided as a convenience to avoid applications having to parse the binomial name.
    /// <see href="http://purl.org/ontology/wo/genusName"></see></summary>
    let genusName = Namespaced_IRI.parse _namespace_name "genusName" |> NamespacedName
    /// <summary>
    /// associates a taxon rank with a habitat in which it grows. Sub-property of wo:habitat to be used for plants, fungi, etc
    /// <see href="http://purl.org/ontology/wo/growsIn"></see></summary>
    let growsIn = Namespaced_IRI.parse _namespace_name "growsIn" |> NamespacedName
    /// <summary>
    /// associates a taxon rank with a habitat in which it may typically be found
    /// <see href="http://purl.org/ontology/wo/habitat"></see></summary>
    let habitat = Namespaced_IRI.parse _namespace_name "habitat" |> NamespacedName
    /// <summary>
    /// associates a taxon rank with a kingdom
    /// <see href="http://purl.org/ontology/wo/kingdom"></see></summary>
    let kingdom = Namespaced_IRI.parse _namespace_name "kingdom" |> NamespacedName

    /// <summary>
    /// Used to specify the name of a kingdom as part of a Taxon Name
    /// <see href="http://purl.org/ontology/wo/kingdomName"></see></summary>
    let kingdomName =
        Namespaced_IRI.parse _namespace_name "kingdomName" |> NamespacedName

    /// <summary>
    /// associates a taxon rank with a habitat in which it lives. Sub-property of wo:habitat to be used for members of the animal kingdom
    /// <see href="http://purl.org/ontology/wo/livesIn"></see></summary>
    let livesIn = Namespaced_IRI.parse _namespace_name "livesIn" |> NamespacedName
    /// <summary>
    /// associates a taxon rank with a taxon name
    /// <see href="http://purl.org/ontology/wo/name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// associates a taxon rank with an order
    /// <see href="http://purl.org/ontology/wo/order"></see></summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName
    /// <summary>
    /// Used to specify the name of an order as part of a Taxon Name
    /// <see href="http://purl.org/ontology/wo/orderName"></see></summary>
    let orderName = Namespaced_IRI.parse _namespace_name "orderName" |> NamespacedName
    /// <summary>
    /// associates a taxon rank with a phylum
    /// <see href="http://purl.org/ontology/wo/phylum"></see></summary>
    let phylum = Namespaced_IRI.parse _namespace_name "phylum" |> NamespacedName
    /// <summary>
    /// Used to specify the name of a phylum as part of a Taxon Name
    /// <see href="http://purl.org/ontology/wo/phylumName"></see></summary>
    let phylumName = Namespaced_IRI.parse _namespace_name "phylumName" |> NamespacedName

    /// <summary>
    /// provides some indication of the population trend associated with an assessment of a taxon's conversation status. The value of this property is a simple literal, and is recommended to be one of: Decreasing, Increasing, Stable, Unknown.
    /// <see href="http://purl.org/ontology/wo/populationTrend"></see></summary>
    let populationTrend =
        Namespaced_IRI.parse _namespace_name "populationTrend" |> NamespacedName

    /// <summary>
    /// associates a Conservation Status with a category in the IUCN Red List
    /// <see href="http://purl.org/ontology/wo/redListStatus"></see></summary>
    let redListStatus =
        Namespaced_IRI.parse _namespace_name "redListStatus" |> NamespacedName

    /// <summary>
    /// associates a taxon name with its formal scientific name. This may be a binomial name (e.g. Panthera leo) in the case of a species name, or a uninomial (e.g. Panthera) name in the case of a name associated with another taxon rank. In formal taxonomic naming conventions, the scientific name is often qualified with the source of the name, e.g. Panthera leo (Linnaeus, 1758).
    /// <see href="http://purl.org/ontology/wo/scientificName"></see></summary>
    let scientificName =
        Namespaced_IRI.parse _namespace_name "scientificName" |> NamespacedName

    /// <summary>
    /// associates a short description with a Collection.
    /// <see href="http://purl.org/ontology/wo/shortDescription"></see></summary>
    let shortDescription =
        Namespaced_IRI.parse _namespace_name "shortDescription" |> NamespacedName

    /// <summary>
    /// associates a taxon rank with a species
    /// <see href="http://purl.org/ontology/wo/species"></see></summary>
    let species = Namespaced_IRI.parse _namespace_name "species" |> NamespacedName

    /// <summary>
    /// specifies the species part of a binomial name, allowing this portion of the name to be explicitly described. Therefore this property will typically only be used in TaxonNames associated with species. The property is largely provided as a convenience to avoid applications having to parse the binomial name.
    /// <see href="http://purl.org/ontology/wo/speciesName"></see></summary>
    let speciesName =
        Namespaced_IRI.parse _namespace_name "speciesName" |> NamespacedName

    /// <summary>
    /// description of the threat(s) that have been identified as part of the assessment of the Conservation Status of a taxon
    /// <see href="http://purl.org/ontology/wo/threatDescription"></see></summary>
    let threatDescription =
        Namespaced_IRI.parse _namespace_name "threatDescription" |> NamespacedName

    /// <summary>
    /// the year in which the conservation status was assessed.
    /// <see href="http://purl.org/ontology/wo/yearAssessed"></see></summary>
    let yearAssessed =
        Namespaced_IRI.parse _namespace_name "yearAssessed" |> NamespacedName
