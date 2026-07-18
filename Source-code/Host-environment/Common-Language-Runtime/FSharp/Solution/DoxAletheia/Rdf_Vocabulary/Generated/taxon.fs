namespace http.purl.org.biodiversity.taxon.slash

open DoxAletheia.Rdf_Vocabulary

module taxon =
    let _namespace_name = "http://purl.org/biodiversity/taxon/"
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Amphibian"></see>
    /// </summary>
    let Amphibian = Namespaced_IRI.parse _namespace_name "Amphibian" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Tetrapod"></see>
    /// </summary>
    let Tetrapod = Namespaced_IRI.parse _namespace_name "Tetrapod" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Animal"></see>
    /// </summary>
    let Animal = Namespaced_IRI.parse _namespace_name "Animal" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Eukaryote"></see>
    /// </summary>
    let Eukaryote = Namespaced_IRI.parse _namespace_name "Eukaryote" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Arachnid"></see>
    /// </summary>
    let Arachnid = Namespaced_IRI.parse _namespace_name "Arachnid" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Arthropod"></see>
    /// </summary>
    let Arthropod = Namespaced_IRI.parse _namespace_name "Arthropod" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Archaea"></see>
    /// </summary>
    let Archaea = Namespaced_IRI.parse _namespace_name "Archaea" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/BiologicalOrganism"></see>
    /// </summary>
    let BiologicalOrganism =
        Namespaced_IRI.parse _namespace_name "BiologicalOrganism" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Armoured_fish"></see>
    /// </summary>
    let Armoured_fish =
        Namespaced_IRI.parse _namespace_name "Armoured_fish" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Fish"></see>
    /// </summary>
    let Fish = Namespaced_IRI.parse _namespace_name "Fish" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Bacteria"></see>
    /// </summary>
    let Bacteria = Namespaced_IRI.parse _namespace_name "Bacteria" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Bird"></see>
    /// </summary>
    let Bird = Namespaced_IRI.parse _namespace_name "Bird" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Cartilaginous_fish"></see>
    /// </summary>
    let Cartilaginous_fish =
        Namespaced_IRI.parse _namespace_name "Cartilaginous_fish" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Cephalochordate"></see>
    /// </summary>
    let Cephalochordate =
        Namespaced_IRI.parse _namespace_name "Cephalochordate" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Chordate"></see>
    /// </summary>
    let Chordate = Namespaced_IRI.parse _namespace_name "Chordate" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/ClubMoss"></see>
    /// </summary>
    let ClubMoss = Namespaced_IRI.parse _namespace_name "ClubMoss" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Plant"></see>
    /// </summary>
    let Plant = Namespaced_IRI.parse _namespace_name "Plant" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Conifer"></see>
    /// </summary>
    let Conifer = Namespaced_IRI.parse _namespace_name "Conifer" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Crustacean"></see>
    /// </summary>
    let Crustacean = Namespaced_IRI.parse _namespace_name "Crustacean" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Cycad"></see>
    /// </summary>
    let Cycad = Namespaced_IRI.parse _namespace_name "Cycad" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/DataObject"></see>
    /// </summary>
    let DataObject = Namespaced_IRI.parse _namespace_name "DataObject" |> NamespacedName
    /// <summary>
    /// Dinosaurs
    /// <see href="http://purl.org/biodiversity/taxon/Dinosauria"></see></summary>
    let Dinosauria = Namespaced_IRI.parse _namespace_name "Dinosauria" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Fern"></see>
    /// </summary>
    let Fern = Namespaced_IRI.parse _namespace_name "Fern" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/FloweringPlant"></see>
    /// </summary>
    let FloweringPlant =
        Namespaced_IRI.parse _namespace_name "FloweringPlant" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Fungus"></see>
    /// </summary>
    let Fungus = Namespaced_IRI.parse _namespace_name "Fungus" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Ginkgo"></see>
    /// </summary>
    let Ginkgo = Namespaced_IRI.parse _namespace_name "Ginkgo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Gnetophytes"></see>
    /// </summary>
    let Gnetophytes =
        Namespaced_IRI.parse _namespace_name "Gnetophytes" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/GreenAlga"></see>
    /// </summary>
    let GreenAlga = Namespaced_IRI.parse _namespace_name "GreenAlga" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Image"></see>
    /// </summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Insect"></see>
    /// </summary>
    let Insect = Namespaced_IRI.parse _namespace_name "Insect" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Jawless_fish"></see>
    /// </summary>
    let Jawless_fish =
        Namespaced_IRI.parse _namespace_name "Jawless_fish" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Lobe_Finned_fish"></see>
    /// </summary>
    let Lobe_Finned_fish =
        Namespaced_IRI.parse _namespace_name "Lobe_Finned_fish" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Lungfish"></see>
    /// </summary>
    let Lungfish = Namespaced_IRI.parse _namespace_name "Lungfish" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Mammal"></see>
    /// </summary>
    let Mammal = Namespaced_IRI.parse _namespace_name "Mammal" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/MapImage"></see>
    /// </summary>
    let MapImage = Namespaced_IRI.parse _namespace_name "MapImage" |> NamespacedName

    /// <summary>
    /// a polyphyletic group
    /// <see href="http://purl.org/biodiversity/taxon/Microbial_Eukaryote"></see></summary>
    let Microbial_Eukaryote =
        Namespaced_IRI.parse _namespace_name "Microbial_Eukaryote" |> NamespacedName

    /// <summary>
    /// The class of recently extant reptiles including Crocodiles, Turtles, Snakes and Lizards
    /// <see href="http://purl.org/biodiversity/taxon/ModernReptile"></see></summary>
    let ModernReptile =
        Namespaced_IRI.parse _namespace_name "ModernReptile" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Mollusca"></see>
    /// </summary>
    let Mollusca = Namespaced_IRI.parse _namespace_name "Mollusca" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Moss"></see>
    /// </summary>
    let Moss = Namespaced_IRI.parse _namespace_name "Moss" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Ray_Fined_fish"></see>
    /// </summary>
    let Ray_Fined_fish =
        Namespaced_IRI.parse _namespace_name "Ray_Fined_fish" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Red_algae"></see>
    /// </summary>
    let Red_algae = Namespaced_IRI.parse _namespace_name "Red_algae" |> NamespacedName
    /// <summary>
    /// A proposed superclass for all the known LOD classes for a "taxon"
    /// <see href="http://purl.org/biodiversity/taxon/Taxon"></see></summary>
    let Taxon = Namespaced_IRI.parse _namespace_name "Taxon" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/TaxonConcept"></see>
    /// </summary>
    let TaxonConcept =
        Namespaced_IRI.parse _namespace_name "TaxonConcept" |> NamespacedName

    /// <summary>
    /// A proposed superclass for all the known LOD classes a taxon name
    /// <see href="http://purl.org/biodiversity/taxon/TaxonName"></see></summary>
    let TaxonName = Namespaced_IRI.parse _namespace_name "TaxonName" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/TaxonNameID"></see>
    /// </summary>
    let TaxonNameID =
        Namespaced_IRI.parse _namespace_name "TaxonNameID" |> NamespacedName

    /// <summary>
    /// A proposed superclass for all the known LOD classes of a Taxon Rank
    /// <see href="http://purl.org/biodiversity/taxon/TaxonRank"></see></summary>
    let TaxonRank = Namespaced_IRI.parse _namespace_name "TaxonRank" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/Tunicate"></see>
    /// </summary>
    let Tunicate = Namespaced_IRI.parse _namespace_name "Tunicate" |> NamespacedName

    /// <summary>
    /// a polyphyletic group
    /// <see href="http://purl.org/biodiversity/taxon/Unclassified_Chordate"></see></summary>
    let Unclassified_Chordate =
        Namespaced_IRI.parse _namespace_name "Unclassified_Chordate" |> NamespacedName

    /// <summary>
    /// The author and year of the species description publication i.e (Baker 1899)
    /// <see href="http://purl.org/biodiversity/taxon/authority"></see></summary>
    let authority = Namespaced_IRI.parse _namespace_name "authority" |> NamespacedName
    /// <summary>
    /// a scientific name consisting of genus, epithet i.e. Felis silvestris
    /// <see href="http://purl.org/biodiversity/taxon/binomial"></see></summary>
    let binomial = Namespaced_IRI.parse _namespace_name "binomial" |> NamespacedName

    /// <summary>
    /// The scientific name without the authority string i.e. Felidae or Puma concolor
    /// <see href="http://purl.org/biodiversity/taxon/scientificName"></see></summary>
    let scientificName =
        Namespaced_IRI.parse _namespace_name "scientificName" |> NamespacedName

    /// <summary>
    /// The URI ID for the canonical form of the name i.e. Puma concolor or Felidae, for name to name mapping
    /// <see href="http://purl.org/biodiversity/taxon/canonicalFormID"></see></summary>
    let canonicalFormID =
        Namespaced_IRI.parse _namespace_name "canonicalFormID" |> NamespacedName

    /// <summary>
    /// The URI to a URI of a related name
    /// <see href="http://purl.org/biodiversity/taxon/relatedTaxonNameID"></see></summary>
    let relatedTaxonNameID =
        Namespaced_IRI.parse _namespace_name "relatedTaxonNameID" |> NamespacedName

    /// <summary>
    /// The URI ID for the scientific name with authorship form of the name i.e. Puma concolor Linnaeus 1758, for name to name mapping
    /// <see href="http://purl.org/biodiversity/taxon/canonicalFormID_Of"></see></summary>
    let canonicalFormID_Of =
        Namespaced_IRI.parse _namespace_name "canonicalFormID_Of" |> NamespacedName

    /// <summary>
    /// The URI to a URI of a related name
    /// <see href="http://purl.org/biodiversity/taxon/relatedTaxonNameID_Of"></see></summary>
    let relatedTaxonNameID_Of =
        Namespaced_IRI.parse _namespace_name "relatedTaxonNameID_Of" |> NamespacedName

    /// <summary>
    /// The common name for a taxon i.e. "Wolf"
    /// <see href="http://purl.org/biodiversity/taxon/commonName"></see></summary>
    let commonName = Namespaced_IRI.parse _namespace_name "commonName" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbClass"></see>
    /// </summary>
    let dbClass = Namespaced_IRI.parse _namespace_name "dbClass" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbFamily"></see>
    /// </summary>
    let dbFamily = Namespaced_IRI.parse _namespace_name "dbFamily" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbGenus"></see>
    /// </summary>
    let dbGenus = Namespaced_IRI.parse _namespace_name "dbGenus" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbKingdom"></see>
    /// </summary>
    let dbKingdom = Namespaced_IRI.parse _namespace_name "dbKingdom" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbOrder"></see>
    /// </summary>
    let dbOrder = Namespaced_IRI.parse _namespace_name "dbOrder" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbPhylum"></see>
    /// </summary>
    let dbPhylum = Namespaced_IRI.parse _namespace_name "dbPhylum" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/dbSpecies"></see>
    /// </summary>
    let dbSpecies = Namespaced_IRI.parse _namespace_name "dbSpecies" |> NamespacedName
    /// <summary>
    /// a one word scientific name i.e. Felidae, Mammalia, Metazoa
    /// <see href="http://purl.org/biodiversity/taxon/monomial"></see></summary>
    let monomial = Namespaced_IRI.parse _namespace_name "monomial" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/relatedName"></see>
    /// </summary>
    let relatedName =
        Namespaced_IRI.parse _namespace_name "relatedName" |> NamespacedName

    /// <summary>
    /// a scientific name consisting of genus epithet and subepithet i.e. Felis silvestris lybica
    /// <see href="http://purl.org/biodiversity/taxon/trinomial"></see></summary>
    let trinomial = Namespaced_IRI.parse _namespace_name "trinomial" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotClass"></see>
    /// </summary>
    let uniprotClass =
        Namespaced_IRI.parse _namespace_name "uniprotClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotFamily"></see>
    /// </summary>
    let uniprotFamily =
        Namespaced_IRI.parse _namespace_name "uniprotFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotGenus"></see>
    /// </summary>
    let uniprotGenus =
        Namespaced_IRI.parse _namespace_name "uniprotGenus" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotKingdom"></see>
    /// </summary>
    let uniprotKingdom =
        Namespaced_IRI.parse _namespace_name "uniprotKingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotOrder"></see>
    /// </summary>
    let uniprotOrder =
        Namespaced_IRI.parse _namespace_name "uniprotOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotPhylum"></see>
    /// </summary>
    let uniprotPhylum =
        Namespaced_IRI.parse _namespace_name "uniprotPhylum" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biodiversity/taxon/uniprotSpecies"></see>
    /// </summary>
    let uniprotSpecies =
        Namespaced_IRI.parse _namespace_name "uniprotSpecies" |> NamespacedName
