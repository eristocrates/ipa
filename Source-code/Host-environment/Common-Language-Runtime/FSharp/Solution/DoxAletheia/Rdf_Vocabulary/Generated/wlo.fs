namespace http.purl.org.ontology.wo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wlo =
    let _namespace_iri = Namespace_Iri wlo |> NamespaceIRI
    /// <summary>
    ///   <para>wlo:0.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/wo/0.1">http://purl.org/ontology/wo/0.1</seealso>
    let ``_0.1`` = Prefixed_Name(wlo, "0.1") |> PrefixedName
    /// <summary>
    ///   <para>wlo:1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/wo/1.0">http://purl.org/ontology/wo/1.0</seealso>
    let ``_1.0`` = Prefixed_Name(wlo, "1.0") |> PrefixedName
    /// <summary>
    ///   <para>wlo:BehaviouralPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Behavioural pattern describes an animal's dominant way of life. Arboreal animals, for example, live in trees and nocturnal animals are active at night.</para>
    /// labels<para>Behavioural Pattern</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/BehaviouralPattern">http://purl.org/ontology/wo/BehaviouralPattern</seealso>
    let BehaviouralPattern = Prefixed_Name(wlo, "BehaviouralPattern") |> PrefixedName
    /// <summary>
    ///   <para>wlo:Kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Kingdoms are the major categories into which scientists divide up all living things. The main kingdoms are animals, plants, fungi and bacteria, although there are others. Each kingdom has its own suite of defining characteristics - for instance plants have rigid cell walls, whilst animals do not.</para>
    /// labels<para>Kingdom</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/Kingdom">http://purl.org/ontology/wo/Kingdom</seealso>
    let Kingdom = Prefixed_Name(wlo, "Kingdom") |> PrefixedName

    /// <summary>
    ///   <para>wlo:LocomotionAdaptation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Locomotion is how an animal gets around - for instance by swimming, flying or climbing.</para>
    /// labels<para>Locomotion</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/LocomotionAdaptation">http://purl.org/ontology/wo/LocomotionAdaptation</seealso>
    let LocomotionAdaptation =
        Prefixed_Name(wlo, "LocomotionAdaptation") |> PrefixedName

    /// <summary>
    ///   <para>wlo:MorphologyAdaptation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Morphology is anything to do with what a plant or animal looks like - its size, shape, colour or structure.</para>
    /// labels<para>Morphology</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/MorphologyAdaptation">http://purl.org/ontology/wo/MorphologyAdaptation</seealso>
    let MorphologyAdaptation =
        Prefixed_Name(wlo, "MorphologyAdaptation") |> PrefixedName

    /// <summary>
    ///   <para>wlo:PredationStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Predation is catching and killing an animal in order to eat it. The prey can be chased, ambushed or caught in a trap such as a spider's web.</para>
    /// labels<para>Predation Strategy</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/PredationStrategy">http://purl.org/ontology/wo/PredationStrategy</seealso>
    let PredationStrategy = Prefixed_Name(wlo, "PredationStrategy") |> PrefixedName
    /// <summary>
    ///   <para>wlo:RedListStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A category in the IUCN red list, 2001.</para>
    /// labels<para>Red List Status</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/RedListStatus">http://purl.org/ontology/wo/RedListStatus</seealso>
    let RedListStatus = Prefixed_Name(wlo, "RedListStatus") |> PrefixedName
    /// <summary>
    ///   <para>wlo:SocialBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Social behaviour is all about how an animal interacts with members of its own species. For instance, does it live in a colony or on its own, does it fight to be top of the pecking order, or does it try to keep strangers away from its home?</para>
    /// labels<para>Social Behaviour</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/SocialBehaviour">http://purl.org/ontology/wo/SocialBehaviour</seealso>
    let SocialBehaviour = Prefixed_Name(wlo, "SocialBehaviour") |> PrefixedName
    /// <summary>
    ///   <para>wlo:Species</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Generic class defining a biological species</para>
    /// labels<para>species</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/Species">http://purl.org/ontology/wo/Species</seealso>
    let Species = Prefixed_Name(wlo, "Species") |> PrefixedName
    /// <summary>
    ///   <para>wlo:TerrestrialHabitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Terrestrial habitats include forests, grasslands, deserts and rainforests. They are typically defined by factors such as plant structure (trees and grasses), leaf types (eg broadleaf and needleleaf), plant spacing (forest, woodland, savanna) and climate.</para>
    /// labels<para>Terrestrial Habitat</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/TerrestrialHabitat">http://purl.org/ontology/wo/TerrestrialHabitat</seealso>
    let TerrestrialHabitat = Prefixed_Name(wlo, "TerrestrialHabitat") |> PrefixedName
    /// <summary>
    ///   <para>wlo:adaptation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank with an adaptation which it displays</para>
    /// labels<para>adaptation</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/adaptation">http://purl.org/ontology/wo/adaptation</seealso>
    let adaptation = Prefixed_Name(wlo, "adaptation") |> PrefixedName
    /// <summary>
    ///   <para>wlo:taxonomicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>a naming property, associating a formal taxonomic name with a Taxon Name instance. This property is a parent of a number of sub-properties that provide more specific terms for denoting names of families, phyla, species, etc.</para>
    /// labels<para>taxonomic name</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/taxonomicName">http://purl.org/ontology/wo/taxonomicName</seealso>
    let taxonomicName = Prefixed_Name(wlo, "taxonomicName") |> PrefixedName
    /// <summary>
    ///   <para>wlo:collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank, habitat, species, clip with a collection of which it is a member</para>
    /// labels<para>collection</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/collection">http://purl.org/ontology/wo/collection</seealso>
    let collection = Prefixed_Name(wlo, "collection") |> PrefixedName
    /// <summary>
    ///   <para>wlo:conservationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank with a description of a recent assessment of its conservation status</para>
    /// labels<para>conservation status</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/conservationStatus">http://purl.org/ontology/wo/conservationStatus</seealso>
    let conservationStatus = Prefixed_Name(wlo, "conservationStatus") |> PrefixedName
    /// <summary>
    ///   <para>wlo:distributionMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a habitat, ecozone, or taxon rank with a map depicting its distribution or location</para>
    /// labels<para>distribution map</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/distributionMap">http://purl.org/ontology/wo/distributionMap</seealso>
    let distributionMap = Prefixed_Name(wlo, "distributionMap") |> PrefixedName
    /// <summary>
    ///   <para>wlo:genus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank with a genus</para>
    /// labels<para>genus</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/genus">http://purl.org/ontology/wo/genus</seealso>
    let genus = Prefixed_Name(wlo, "genus") |> PrefixedName
    /// <summary>
    ///   <para>wlo:genusName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>specifies the genus part of a binomial name, allowing this portion of the name to be explicitly described. Therefore this property will typically only be used in TaxonNames associated with species. The property is largely provided as a convenience to avoid applications having to parse the binomial name.</para>
    /// labels<para>genus name</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/genusName">http://purl.org/ontology/wo/genusName</seealso>
    let genusName = Prefixed_Name(wlo, "genusName") |> PrefixedName
    /// <summary>
    ///   <para>wlo:habitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank with a habitat in which it may typically be found</para>
    /// labels<para>habitat</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/habitat">http://purl.org/ontology/wo/habitat</seealso>
    let habitat = Prefixed_Name(wlo, "habitat") |> PrefixedName
    /// <summary>
    ///   <para>wlo:kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank with a kingdom</para>
    /// labels<para>kingdom</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/kingdom">http://purl.org/ontology/wo/kingdom</seealso>
    let kingdom = Prefixed_Name(wlo, "kingdom") |> PrefixedName
    /// <summary>
    ///   <para>wlo:livesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank with a habitat in which it lives. Sub-property of wo:habitat to be used for members of the animal kingdom</para>
    /// labels<para>lives in</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/livesIn">http://purl.org/ontology/wo/livesIn</seealso>
    let livesIn = Prefixed_Name(wlo, "livesIn") |> PrefixedName
    /// <summary>
    ///   <para>wlo:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank with a taxon name</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/name">http://purl.org/ontology/wo/name</seealso>
    let name = Prefixed_Name(wlo, "name") |> PrefixedName
    /// <summary>
    ///   <para>wlo:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank with an order</para>
    /// labels<para>order</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/order">http://purl.org/ontology/wo/order</seealso>
    let order = Prefixed_Name(wlo, "order") |> PrefixedName
    /// <summary>
    ///   <para>wlo:phylumName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Used to specify the name of a phylum as part of a Taxon Name</para>
    /// labels<para>phylum name</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/phylumName">http://purl.org/ontology/wo/phylumName</seealso>
    let phylumName = Prefixed_Name(wlo, "phylumName") |> PrefixedName
    /// <summary>
    ///   <para>wlo:populationTrend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>provides some indication of the population trend associated with an assessment of a taxon's conversation status. The value of this property is a simple literal, and is recommended to be one of: Decreasing, Increasing, Stable, Unknown.</para>
    /// labels<para>population trend</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/populationTrend">http://purl.org/ontology/wo/populationTrend</seealso>
    let populationTrend = Prefixed_Name(wlo, "populationTrend") |> PrefixedName
    /// <summary>
    ///   <para>wlo:redListStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a Conservation Status with a category in the IUCN Red List</para>
    /// labels<para>red list status</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/redListStatus">http://purl.org/ontology/wo/redListStatus</seealso>
    let redListStatus = Prefixed_Name(wlo, "redListStatus") |> PrefixedName
    /// <summary>
    ///   <para>wlo:scientificName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>associates a taxon name with its formal scientific name. This may be a binomial name (e.g. Panthera leo) in the case of a species name, or a uninomial (e.g. Panthera) name in the case of a name associated with another taxon rank. In formal taxonomic naming conventions, the scientific name is often qualified with the source of the name, e.g. Panthera leo (Linnaeus, 1758).</para>
    /// labels<para>scientific name</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/scientificName">http://purl.org/ontology/wo/scientificName</seealso>
    let scientificName = Prefixed_Name(wlo, "scientificName") |> PrefixedName
    /// <summary>
    ///   <para>wlo:shortDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>associates a short description with a Collection.</para>
    /// labels<para>short description</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/shortDescription">http://purl.org/ontology/wo/shortDescription</seealso>
    let shortDescription = Prefixed_Name(wlo, "shortDescription") |> PrefixedName
    /// <summary>
    ///   <para>wlo:speciesName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>specifies the species part of a binomial name, allowing this portion of the name to be explicitly described. Therefore this property will typically only be used in TaxonNames associated with species. The property is largely provided as a convenience to avoid applications having to parse the binomial name.</para>
    /// labels<para>species name</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/speciesName">http://purl.org/ontology/wo/speciesName</seealso>
    let speciesName = Prefixed_Name(wlo, "speciesName") |> PrefixedName
    /// <summary>
    ///   <para>wlo:threatDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>description of the threat(s) that have been identified as part of the assessment of the Conservation Status of a taxon</para>
    /// labels<para>threatDescription</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/threatDescription">http://purl.org/ontology/wo/threatDescription</seealso>
    let threatDescription = Prefixed_Name(wlo, "threatDescription") |> PrefixedName
    /// <summary>
    ///   <para>wlo:yearAssessed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>the year in which the conservation status was assessed.</para>
    /// labels<para>year assessed</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/yearAssessed">http://purl.org/ontology/wo/yearAssessed</seealso>
    let yearAssessed = Prefixed_Name(wlo, "yearAssessed") |> PrefixedName
    /// <summary>
    ///   <para>wlo:#tom</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/wo/#tom">http://purl.org/ontology/wo/#tom</seealso>
    let ``_#tom`` = Prefixed_Name(wlo, "#tom") |> PrefixedName
    /// <summary>
    ///   <para>wlo:AnimalIntelligence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Animal Intelligence or animal cognition is the title given to a modern approach to the mental capacities of non-human animals. It has developed out of comparative psychology, but has also been strongly influenced by the approach of ethology, behavioral ecology, and evolutionary psychology.</para>
    /// labels<para>Animal Intelligence</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/AnimalIntelligence">http://purl.org/ontology/wo/AnimalIntelligence</seealso>
    let AnimalIntelligence = Prefixed_Name(wlo, "AnimalIntelligence") |> PrefixedName
    /// <summary>
    ///   <para>wlo:Adaptation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An adaptation is any feature of an animal or plant which makes it better suited for a particular habitat or to do a particular task. For instance, being streamlined is an adaptation to swimming fast and being able to survive on very little water is an adaptation to life in the desert.</para>
    /// labels<para>Adaptation</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/Adaptation">http://purl.org/ontology/wo/Adaptation</seealso>
    let Adaptation = Prefixed_Name(wlo, "Adaptation") |> PrefixedName
    /// <summary>
    ///   <para>wlo:ConservationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Conservation status as described by the IUCN Red List. Will typically have a number of properties including an official IUCN status, population trend, and a year of assessment.</para>
    /// labels<para>Conservation Status</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/ConservationStatus">http://purl.org/ontology/wo/ConservationStatus</seealso>
    let ConservationStatus = Prefixed_Name(wlo, "ConservationStatus") |> PrefixedName
    /// <summary>
    ///   <para>wlo:Ecozone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ecozones are a method of dividing up the Earth's surface. Each ecozone is a large area that contains a number of habitats, which are linked by the evolutionary history of the animals and plants within them. For instance one ecozone is Australasia, because its marsupials evolved in isolation to mammals in the rest of the world.</para>
    /// labels<para>Ecozone</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/Ecozone">http://purl.org/ontology/wo/Ecozone</seealso>
    let Ecozone = Prefixed_Name(wlo, "Ecozone") |> PrefixedName
    /// <summary>
    ///   <para>wlo:FreshwaterHabitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Freshwater habitats include bogs, ponds, lakes, rivers and streams. About 3% of Earth's water is freshwater, but this includes the water locked up in the ice caps and trapped in rocks and soil as groundwater. Only a tiny fraction (0.014%) is surface water in the form of rivers, lakes and swamps.</para>
    /// labels<para>Freshwater Habitat</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/FreshwaterHabitat">http://purl.org/ontology/wo/FreshwaterHabitat</seealso>
    let FreshwaterHabitat = Prefixed_Name(wlo, "FreshwaterHabitat") |> PrefixedName
    /// <summary>
    ///   <para>wlo:Habitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A habitat, or biome, is the type of environment in which plant and animals live. Habitat is dictated by what kinds of plants grow there, the climate and the geography. Rainforest, coral reefs and the tundra are all habitats where particular kinds of plants and animals might be found.</para>
    /// labels<para>Habitat</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/Habitat">http://purl.org/ontology/wo/Habitat</seealso>
    let Habitat = Prefixed_Name(wlo, "Habitat") |> PrefixedName
    /// <summary>
    ///   <para>wlo:Genus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A genus is a scientific way of showing that species are very closed related to each other. In fact the first word of the species' scientific name is its genus. So for lions (Panthera leo), Panthera is the genus and tells us that they are closely related to tigers (Panthera tigris), because they share the name</para>
    /// labels<para>Genus</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/Genus">http://purl.org/ontology/wo/Genus</seealso>
    let Genus = Prefixed_Name(wlo, "Genus") |> PrefixedName
    /// <summary>
    ///   <para>wlo:species</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank with a species</para>
    /// labels<para>species</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/species">http://purl.org/ontology/wo/species</seealso>
    let species = Prefixed_Name(wlo, "species") |> PrefixedName
    /// <summary>
    ///   <para>wlo:TaxonRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Generic concept for a taxonomic rank such as a Genus or Species.</para>
    /// labels<para>Taxonomic Rank</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/TaxonRank">http://purl.org/ontology/wo/TaxonRank</seealso>
    let TaxonRank = Prefixed_Name(wlo, "TaxonRank") |> PrefixedName
    /// <summary>
    ///   <para>wlo:ecozone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>indicates that a habitat or a taxon rank can be found within an ecozone</para>
    /// labels<para>ecozone</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/ecozone">http://purl.org/ontology/wo/ecozone</seealso>
    let ecozone = Prefixed_Name(wlo, "ecozone") |> PrefixedName
    /// <summary>
    ///   <para>wlo:familyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Used to specify the name of a family as part of a Taxon Name</para>
    /// labels<para>family name</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/familyName">http://purl.org/ontology/wo/familyName</seealso>
    let familyName = Prefixed_Name(wlo, "familyName") |> PrefixedName
    /// <summary>
    ///   <para>wlo:growsIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank with a habitat in which it grows. Sub-property of wo:habitat to be used for plants, fungi, etc</para>
    /// labels<para>grows in</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/growsIn">http://purl.org/ontology/wo/growsIn</seealso>
    let growsIn = Prefixed_Name(wlo, "growsIn") |> PrefixedName
    /// <summary>
    ///   <para>wlo:kingdomName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Used to specify the name of a kingdom as part of a Taxon Name</para>
    /// labels<para>kingdom name</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/kingdomName">http://purl.org/ontology/wo/kingdomName</seealso>
    let kingdomName = Prefixed_Name(wlo, "kingdomName") |> PrefixedName
    /// <summary>
    ///   <para>wlo:orderName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Used to specify the name of an order as part of a Taxon Name</para>
    /// labels<para>order name</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/orderName">http://purl.org/ontology/wo/orderName</seealso>
    let orderName = Prefixed_Name(wlo, "orderName") |> PrefixedName
    /// <summary>
    ///   <para>wlo:EcosystemRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ecosystem roles are about the part an animal or plant plays in sustaining or maintaining the habitat around them. Bees, for example, pollinate flowers, without which those plants would not produce fruits or seeds. Other species, such as dung beetles, play a vital role in keeping grasslands clear of animal waste and recycling valuable resources.</para>
    /// labels<para>Ecosystem Role</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/EcosystemRole">http://purl.org/ontology/wo/EcosystemRole</seealso>
    let EcosystemRole = Prefixed_Name(wlo, "EcosystemRole") |> PrefixedName
    /// <summary>
    ///   <para>wlo:Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A family is a scientific grouping of closely related organisms. It has smaller groups, called genera and species, within it. A family can have a lot of members or only a few. Examples of families include the cats (Felidae), the gulls (Laridae) and the grasses (Poaceae).</para>
    /// labels<para>Family</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/Family">http://purl.org/ontology/wo/Family</seealso>
    let Family = Prefixed_Name(wlo, "Family") |> PrefixedName
    /// <summary>
    ///   <para>wlo:FeedingHabit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Feeding habits describe the dominant diet of a particular species or group of species, and how they go about obtaining it.</para>
    /// labels<para>Feeding Habit</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/FeedingHabit">http://purl.org/ontology/wo/FeedingHabit</seealso>
    let FeedingHabit = Prefixed_Name(wlo, "FeedingHabit") |> PrefixedName
    /// <summary>
    ///   <para>wlo:LifeCycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organism's Life Cycle describes the stages in an organisms development including metamorphosis, courtship displays and parental care..</para>
    /// labels<para>Life Cycle</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/LifeCycle">http://purl.org/ontology/wo/LifeCycle</seealso>
    let LifeCycle = Prefixed_Name(wlo, "LifeCycle") |> PrefixedName
    /// <summary>
    ///   <para>wlo:MarineHabitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Approximately 71% of the Earth's surface is covered by the oceans, an area of some 223698816km/sq. Although marine life evolved around three billion years before life on land, marine habitats are relatively poorly studied and much of the ocean's depths remains unexplored.</para>
    /// labels<para>Marine Habitat</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/MarineHabitat">http://purl.org/ontology/wo/MarineHabitat</seealso>
    let MarineHabitat = Prefixed_Name(wlo, "MarineHabitat") |> PrefixedName
    /// <summary>
    ///   <para>wlo:Order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An order is a scientific way to categorise related organisms. An order is a smaller grouping than a class, but bigger than a family or genus. Examples of orders are willows, cockroaches and primates.</para>
    /// labels<para>Order</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/Order">http://purl.org/ontology/wo/Order</seealso>
    let Order = Prefixed_Name(wlo, "Order") |> PrefixedName
    /// <summary>
    ///   <para>wlo:Phylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A phylum - also known as a division when referring to plants - is a scientfic way of grouping together related organisms. All the members of a phylum have a common ancestor and anatomical similarities. For instance, all the arthropods have external skeletons. Phlya are large groups and are further subdivided into classes, orders, families and so on.</para>
    /// labels<para>Phylum</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/Phylum">http://purl.org/ontology/wo/Phylum</seealso>
    let Phylum = Prefixed_Name(wlo, "Phylum") |> PrefixedName

    /// <summary>
    ///   <para>wlo:ReproductionStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reproduction covers all the tactics and behaviours involved in obtaining a mate, conceiving the next generation and successfully raising them. It includes everything from plants being pollinated, to stags fighting over hinds, to lionesses babysitting their sisters' cubs.</para>
    /// labels<para>Reproduction Strategy</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/ReproductionStrategy">http://purl.org/ontology/wo/ReproductionStrategy</seealso>
    let ReproductionStrategy =
        Prefixed_Name(wlo, "ReproductionStrategy") |> PrefixedName

    /// <summary>
    ///   <para>wlo:TaxonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A taxonomic name, describing the structure and provenance of a taxonomic name.</para>
    /// labels<para>Taxon Name</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/TaxonName">http://purl.org/ontology/wo/TaxonName</seealso>
    let TaxonName = Prefixed_Name(wlo, "TaxonName") |> PrefixedName
    /// <summary>
    ///   <para>wlo:className</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Used to specify the name of a class as part of a Taxon Name</para>
    /// labels<para>class name</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/className">http://purl.org/ontology/wo/className</seealso>
    let className = Prefixed_Name(wlo, "className") |> PrefixedName
    /// <summary>
    ///   <para>wlo:commonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>associates a formal taxon name with a common version. E.g. Panthera leo might be associated with a common name of 'Lion'. A given taxon name may have several common names</para>
    /// labels<para>common name</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/commonName">http://purl.org/ontology/wo/commonName</seealso>
    let commonName = Prefixed_Name(wlo, "commonName") |> PrefixedName
    /// <summary>
    ///   <para>wlo:family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank with a family</para>
    /// labels<para>family</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/family">http://purl.org/ontology/wo/family</seealso>
    let family = Prefixed_Name(wlo, "family") |> PrefixedName
    /// <summary>
    ///   <para>wlo:ExtremesAdaptation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Organisms that are adapted to extremes (known as Extremophiles) are organisms that thrives in and even may require physically or geochemically extreme conditions that are detrimental to the majority of life on Earth.</para>
    /// labels<para>Adapted to Extremes</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/ExtremesAdaptation">http://purl.org/ontology/wo/ExtremesAdaptation</seealso>
    let ExtremesAdaptation = Prefixed_Name(wlo, "ExtremesAdaptation") |> PrefixedName
    /// <summary>
    ///   <para>wlo:phylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank with a phylum</para>
    /// labels<para>phylum</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/phylum">http://purl.org/ontology/wo/phylum</seealso>
    let phylum = Prefixed_Name(wlo, "phylum") |> PrefixedName
    /// <summary>
    ///   <para>wlo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbcprov:Ontology</para>
    ///   <para>owl:Ontology</para>
    ///   <para>A simple vocabulary for describing biological species and related taxa. The vocabulary defines terms for describing the names and ranking of taxa, as well as providing support for describing their habitats, conservation status, and behavioural characteristics, etc</para>
    /// labels<para>Wildlife Ontology</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/">http://purl.org/ontology/wo/</seealso>
    let _prefix_iri = Prefixed_Name(wlo, "") |> PrefixedName
    /// <summary>
    ///   <para>wlo:Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class is a scientific way to group related organisms together, some examples of classes being jellyfish, reptiles and sea urchins. Classes are big groups and contain within them smaller groupings called orders, families, genera and species.</para>
    /// labels<para>Class</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/Class">http://purl.org/ontology/wo/Class</seealso>
    let Class = Prefixed_Name(wlo, "Class") |> PrefixedName
    /// <summary>
    ///   <para>wlo:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of resources, including documents, multimedia files, programme clips and their associated taxa, which aims to showcase a particular aspect of natural history film-making, or illustrate aspects of the natural world. A collection provides an alternate way to organize content over and above the basic taxonomic hierarchy.</para>
    /// labels<para>Collection</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/Collection">http://purl.org/ontology/wo/Collection</seealso>
    let Collection = Prefixed_Name(wlo, "Collection") |> PrefixedName

    /// <summary>
    ///   <para>wlo:CommunicationAdaptation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Communication and senses are how an organism perceives the world - for instance through scent or sight - and how it sends messages or warnings to others.</para>
    /// labels<para>Communication Adaptation</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/CommunicationAdaptation">http://purl.org/ontology/wo/CommunicationAdaptation</seealso>
    let CommunicationAdaptation =
        Prefixed_Name(wlo, "CommunicationAdaptation") |> PrefixedName

    /// <summary>
    ///   <para>wlo:SurvivalStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Survival strategies include adaptations to changes in the organisms environment, including: hibernation, abscission and migration.</para>
    /// labels<para>Survival Strategy</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/SurvivalStrategy">http://purl.org/ontology/wo/SurvivalStrategy</seealso>
    let SurvivalStrategy = Prefixed_Name(wlo, "SurvivalStrategy") |> PrefixedName
    /// <summary>
    ///   <para>wlo:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a taxon rank with a class</para>
    /// labels<para>class</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/class">http://purl.org/ontology/wo/class</seealso>
    let class_ = Prefixed_Name(wlo, "class") |> PrefixedName
