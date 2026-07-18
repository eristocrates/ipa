namespace http.purl.org.NET.biol.ns.hash

open DoxAletheia.Rdf_Vocabulary

module biol =
    let _namespace_name = "http://purl.org/NET/biol/ns#"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#order"></see>
    /// </summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#seeAlso"></see>
    /// </summary>
    let seeAlso = Namespaced_IRI.parse _namespace_name "seeAlso" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#authority"></see>
    /// </summary>
    let authority = Namespaced_IRI.parse _namespace_name "authority" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#species"></see>
    /// </summary>
    let species = Namespaced_IRI.parse _namespace_name "species" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#family"></see>
    /// </summary>
    let family = Namespaced_IRI.parse _namespace_name "family" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#class"></see>
    /// </summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#kingdom"></see>
    /// </summary>
    let kingdom = Namespaced_IRI.parse _namespace_name "kingdom" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#phylum"></see>
    /// </summary>
    let phylum = Namespaced_IRI.parse _namespace_name "phylum" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#genus"></see>
    /// </summary>
    let genus = Namespaced_IRI.parse _namespace_name "genus" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#hasTaxonomy"></see>
    /// </summary>
    let hasTaxonomy =
        Namespaced_IRI.parse _namespace_name "hasTaxonomy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#BotTaxonomy"></see>
    /// </summary>
    let BotTaxonomy =
        Namespaced_IRI.parse _namespace_name "BotTaxonomy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#Taxonomy"></see>
    /// </summary>
    let Taxonomy = Namespaced_IRI.parse _namespace_name "Taxonomy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#ZooTaxonomy"></see>
    /// </summary>
    let ZooTaxonomy =
        Namespaced_IRI.parse _namespace_name "ZooTaxonomy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#rank"></see>
    /// </summary>
    let rank = Namespaced_IRI.parse _namespace_name "rank" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#commonName"></see>
    /// </summary>
    let commonName = Namespaced_IRI.parse _namespace_name "commonName" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#division"></see>
    /// </summary>
    let division = Namespaced_IRI.parse _namespace_name "division" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#secondLevelClassification"></see>
    /// </summary>
    let secondLevelClassification =
        Namespaced_IRI.parse _namespace_name "secondLevelClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#morePrecise"></see>
    /// </summary>
    let morePrecise =
        Namespaced_IRI.parse _namespace_name "morePrecise" |> NamespacedName
