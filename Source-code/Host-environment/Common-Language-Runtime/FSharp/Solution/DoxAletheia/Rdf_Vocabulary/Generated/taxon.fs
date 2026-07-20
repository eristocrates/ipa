namespace http.purl.org.biodiversity.taxon.slash

open DoxAletheia

module taxon =
    let _namespace_name = "http://purl.org/biodiversity/taxon/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Amphibian"></see>
    /// </summary>
    let Amphibian = _prefix "Amphibian"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Tetrapod"></see>
    /// </summary>
    let Tetrapod = _prefix "Tetrapod"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Animal"></see>
    /// </summary>
    let Animal = _prefix "Animal"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Eukaryote"></see>
    /// </summary>
    let Eukaryote = _prefix "Eukaryote"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Arachnid"></see>
    /// </summary>
    let Arachnid = _prefix "Arachnid"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Arthropod"></see>
    /// </summary>
    let Arthropod = _prefix "Arthropod"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Archaea"></see>
    /// </summary>
    let Archaea = _prefix "Archaea"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/BiologicalOrganism"></see>
    /// </summary>
    let BiologicalOrganism = _prefix "BiologicalOrganism"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Armoured_fish"></see>
    /// </summary>
    let Armoured_fish = _prefix "Armoured_fish"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Fish"></see>
    /// </summary>
    let Fish = _prefix "Fish"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Bacteria"></see>
    /// </summary>
    let Bacteria = _prefix "Bacteria"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Bird"></see>
    /// </summary>
    let Bird = _prefix "Bird"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Cartilaginous_fish"></see>
    /// </summary>
    let Cartilaginous_fish = _prefix "Cartilaginous_fish"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Cephalochordate"></see>
    /// </summary>
    let Cephalochordate = _prefix "Cephalochordate"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Chordate"></see>
    /// </summary>
    let Chordate = _prefix "Chordate"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/ClubMoss"></see>
    /// </summary>
    let ClubMoss = _prefix "ClubMoss"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Plant"></see>
    /// </summary>
    let Plant = _prefix "Plant"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Conifer"></see>
    /// </summary>
    let Conifer = _prefix "Conifer"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Crustacean"></see>
    /// </summary>
    let Crustacean = _prefix "Crustacean"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Cycad"></see>
    /// </summary>
    let Cycad = _prefix "Cycad"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/DataObject"></see>
    /// </summary>
    let DataObject = _prefix "DataObject"
    /// <summary>
    /// Dinosaurs
    /// <see href="http://purl.org/biodiversity/taxon/Dinosauria"></see></summary>
    let Dinosauria = _prefix "Dinosauria"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Fern"></see>
    /// </summary>
    let Fern = _prefix "Fern"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/FloweringPlant"></see>
    /// </summary>
    let FloweringPlant = _prefix "FloweringPlant"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Fungus"></see>
    /// </summary>
    let Fungus = _prefix "Fungus"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Ginkgo"></see>
    /// </summary>
    let Ginkgo = _prefix "Ginkgo"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Gnetophytes"></see>
    /// </summary>
    let Gnetophytes = _prefix "Gnetophytes"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/GreenAlga"></see>
    /// </summary>
    let GreenAlga = _prefix "GreenAlga"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Image"></see>
    /// </summary>
    let Image = _prefix "Image"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Insect"></see>
    /// </summary>
    let Insect = _prefix "Insect"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Jawless_fish"></see>
    /// </summary>
    let Jawless_fish = _prefix "Jawless_fish"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Lobe_Finned_fish"></see>
    /// </summary>
    let Lobe_Finned_fish = _prefix "Lobe_Finned_fish"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Lungfish"></see>
    /// </summary>
    let Lungfish = _prefix "Lungfish"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Mammal"></see>
    /// </summary>
    let Mammal = _prefix "Mammal"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/MapImage"></see>
    /// </summary>
    let MapImage = _prefix "MapImage"
    /// <summary>
    /// a polyphyletic group
    /// <see href="http://purl.org/biodiversity/taxon/Microbial_Eukaryote"></see></summary>
    let Microbial_Eukaryote = _prefix "Microbial_Eukaryote"
    /// <summary>
    /// The class of recently extant reptiles including Crocodiles, Turtles, Snakes and Lizards
    /// <see href="http://purl.org/biodiversity/taxon/ModernReptile"></see></summary>
    let ModernReptile = _prefix "ModernReptile"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Mollusca"></see>
    /// </summary>
    let Mollusca = _prefix "Mollusca"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Moss"></see>
    /// </summary>
    let Moss = _prefix "Moss"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Ray_Fined_fish"></see>
    /// </summary>
    let Ray_Fined_fish = _prefix "Ray_Fined_fish"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Red_algae"></see>
    /// </summary>
    let Red_algae = _prefix "Red_algae"
    /// <summary>
    /// A proposed superclass for all the known LOD classes for a "taxon"
    /// <see href="http://purl.org/biodiversity/taxon/Taxon"></see></summary>
    let Taxon = _prefix "Taxon"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/TaxonConcept"></see>
    /// </summary>
    let TaxonConcept = _prefix "TaxonConcept"
    /// <summary>
    /// A proposed superclass for all the known LOD classes a taxon name
    /// <see href="http://purl.org/biodiversity/taxon/TaxonName"></see></summary>
    let TaxonName = _prefix "TaxonName"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/TaxonNameID"></see>
    /// </summary>
    let TaxonNameID = _prefix "TaxonNameID"
    /// <summary>
    /// A proposed superclass for all the known LOD classes of a Taxon Rank
    /// <see href="http://purl.org/biodiversity/taxon/TaxonRank"></see></summary>
    let TaxonRank = _prefix "TaxonRank"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Tunicate"></see>
    /// </summary>
    let Tunicate = _prefix "Tunicate"
    /// <summary>
    /// a polyphyletic group
    /// <see href="http://purl.org/biodiversity/taxon/Unclassified_Chordate"></see></summary>
    let Unclassified_Chordate = _prefix "Unclassified_Chordate"
    /// <summary>
    /// The author and year of the species description publication i.e (Baker 1899)
    /// <see href="http://purl.org/biodiversity/taxon/authority"></see></summary>
    let authority = _prefix "authority"
    /// <summary>
    /// a scientific name consisting of genus, epithet i.e. Felis silvestris
    /// <see href="http://purl.org/biodiversity/taxon/binomial"></see></summary>
    let binomial = _prefix "binomial"
    /// <summary>
    /// The scientific name without the authority string i.e. Felidae or Puma concolor
    /// <see href="http://purl.org/biodiversity/taxon/scientificName"></see></summary>
    let scientificName = _prefix "scientificName"
    /// <summary>
    /// The URI ID for the canonical form of the name i.e. Puma concolor or Felidae, for name to name mapping
    /// <see href="http://purl.org/biodiversity/taxon/canonicalFormID"></see></summary>
    let canonicalFormID = _prefix "canonicalFormID"
    /// <summary>
    /// The URI to a URI of a related name
    /// <see href="http://purl.org/biodiversity/taxon/relatedTaxonNameID"></see></summary>
    let relatedTaxonNameID = _prefix "relatedTaxonNameID"
    /// <summary>
    /// The URI ID for the scientific name with authorship form of the name i.e. Puma concolor Linnaeus 1758, for name to name mapping
    /// <see href="http://purl.org/biodiversity/taxon/canonicalFormID_Of"></see></summary>
    let canonicalFormID_Of = _prefix "canonicalFormID_Of"
    /// <summary>
    /// The URI to a URI of a related name
    /// <see href="http://purl.org/biodiversity/taxon/relatedTaxonNameID_Of"></see></summary>
    let relatedTaxonNameID_Of = _prefix "relatedTaxonNameID_Of"
    /// <summary>
    /// The common name for a taxon i.e. "Wolf"
    /// <see href="http://purl.org/biodiversity/taxon/commonName"></see></summary>
    let commonName = _prefix "commonName"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbClass"></see>
    /// </summary>
    let dbClass = _prefix "dbClass"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbFamily"></see>
    /// </summary>
    let dbFamily = _prefix "dbFamily"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbGenus"></see>
    /// </summary>
    let dbGenus = _prefix "dbGenus"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbKingdom"></see>
    /// </summary>
    let dbKingdom = _prefix "dbKingdom"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbOrder"></see>
    /// </summary>
    let dbOrder = _prefix "dbOrder"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbPhylum"></see>
    /// </summary>
    let dbPhylum = _prefix "dbPhylum"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbSpecies"></see>
    /// </summary>
    let dbSpecies = _prefix "dbSpecies"
    /// <summary>
    /// a one word scientific name i.e. Felidae, Mammalia, Metazoa
    /// <see href="http://purl.org/biodiversity/taxon/monomial"></see></summary>
    let monomial = _prefix "monomial"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/relatedName"></see>
    /// </summary>
    let relatedName = _prefix "relatedName"
    /// <summary>
    /// a scientific name consisting of genus epithet and subepithet i.e. Felis silvestris lybica
    /// <see href="http://purl.org/biodiversity/taxon/trinomial"></see></summary>
    let trinomial = _prefix "trinomial"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotClass"></see>
    /// </summary>
    let uniprotClass = _prefix "uniprotClass"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotFamily"></see>
    /// </summary>
    let uniprotFamily = _prefix "uniprotFamily"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotGenus"></see>
    /// </summary>
    let uniprotGenus = _prefix "uniprotGenus"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotKingdom"></see>
    /// </summary>
    let uniprotKingdom = _prefix "uniprotKingdom"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotOrder"></see>
    /// </summary>
    let uniprotOrder = _prefix "uniprotOrder"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotPhylum"></see>
    /// </summary>
    let uniprotPhylum = _prefix "uniprotPhylum"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotSpecies"></see>
    /// </summary>
    let uniprotSpecies = _prefix "uniprotSpecies"
