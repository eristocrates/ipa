namespace http.purl.org.NET.biol.ns.hash

open DoxAletheia

module biol =
    let _namespace_name = "http://purl.org/NET/biol/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#order"></see>
    /// </summary>
    let order = _prefix "order"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#seeAlso"></see>
    /// </summary>
    let seeAlso = _prefix "seeAlso"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#authority"></see>
    /// </summary>
    let authority = _prefix "authority"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#species"></see>
    /// </summary>
    let species = _prefix "species"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#family"></see>
    /// </summary>
    let family = _prefix "family"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#class"></see>
    /// </summary>
    let class_ = _prefix "class"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#kingdom"></see>
    /// </summary>
    let kingdom = _prefix "kingdom"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#phylum"></see>
    /// </summary>
    let phylum = _prefix "phylum"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#genus"></see>
    /// </summary>
    let genus = _prefix "genus"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#hasTaxonomy"></see>
    /// </summary>
    let hasTaxonomy = _prefix "hasTaxonomy"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#BotTaxonomy"></see>
    /// </summary>
    let BotTaxonomy = _prefix "BotTaxonomy"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#Taxonomy"></see>
    /// </summary>
    let Taxonomy = _prefix "Taxonomy"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#ZooTaxonomy"></see>
    /// </summary>
    let ZooTaxonomy = _prefix "ZooTaxonomy"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#rank"></see>
    /// </summary>
    let rank = _prefix "rank"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#commonName"></see>
    /// </summary>
    let commonName = _prefix "commonName"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#division"></see>
    /// </summary>
    let division = _prefix "division"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#secondLevelClassification"></see>
    /// </summary>
    let secondLevelClassification = _prefix "secondLevelClassification"
    /// <summary>
    ///   <see href="http://purl.org/NET/biol/ns#morePrecise"></see>
    /// </summary>
    let morePrecise = _prefix "morePrecise"
