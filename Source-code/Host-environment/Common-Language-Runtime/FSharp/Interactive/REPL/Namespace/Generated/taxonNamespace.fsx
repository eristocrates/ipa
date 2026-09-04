#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module taxon =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/biodiversity/taxon/" "taxon"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Amphibian^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Amphibian">taxon:Amphibian</a>
    /// </summary>
    let Amphibian = _prefixId.prefix "Amphibian"
    /// <summary>
    ///   <para>rdfs:label : Animal^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Animal">taxon:Animal</a>
    /// </summary>
    let Animal = _prefixId.prefix "Animal"
    /// <summary>
    ///   <para>rdfs:label : Arachnid^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Arachnid">taxon:Arachnid</a>
    /// </summary>
    let Arachnid = _prefixId.prefix "Arachnid"
    /// <summary>
    ///   <para>rdfs:label : Archaea^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Archaea">taxon:Archaea</a>
    /// </summary>
    let Archaea = _prefixId.prefix "Archaea"
    /// <summary>
    ///   <para>rdfs:label : Armoured_fish^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Armoured_fish">taxon:Armoured_fish</a>
    /// </summary>
    let Armoured_fish = _prefixId.prefix "Armoured_fish"
    /// <summary>
    ///   <para>rdfs:label : Arthropod^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Arthropod">taxon:Arthropod</a>
    /// </summary>
    let Arthropod = _prefixId.prefix "Arthropod"
    /// <summary>
    ///   <para>rdfs:label : Bacteria^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Bacteria">taxon:Bacteria</a>
    /// </summary>
    let Bacteria = _prefixId.prefix "Bacteria"
    /// <summary>
    ///   <para>rdfs:label : BiologicalOrganism^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/BiologicalOrganism">taxon:BiologicalOrganism</a>
    /// </summary>
    let BiologicalOrganism = _prefixId.prefix "BiologicalOrganism"
    /// <summary>
    ///   <para>rdfs:label : Bird^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Bird">taxon:Bird</a>
    /// </summary>
    let Bird = _prefixId.prefix "Bird"
    /// <summary>
    ///   <para>rdfs:label : Cartilaginous Fish^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Cartilaginous_fish">taxon:Cartilaginous_fish</a>
    /// </summary>
    let Cartilaginous_fish = _prefixId.prefix "Cartilaginous_fish"
    /// <summary>
    ///   <para>rdfs:label : Cephalochordate^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Cephalochordate">taxon:Cephalochordate</a>
    /// </summary>
    let Cephalochordate = _prefixId.prefix "Cephalochordate"
    /// <summary>
    ///   <para>rdfs:label : Chordate^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Chordate">taxon:Chordate</a>
    /// </summary>
    let Chordate = _prefixId.prefix "Chordate"
    /// <summary>
    ///   <para>rdfs:label : ClubMoss^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/ClubMoss">taxon:ClubMoss</a>
    /// </summary>
    let ClubMoss = _prefixId.prefix "ClubMoss"
    /// <summary>
    ///   <para>rdfs:label : Conifer^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Conifer">taxon:Conifer</a>
    /// </summary>
    let Conifer = _prefixId.prefix "Conifer"
    /// <summary>
    ///   <para>rdfs:label : Crustacean^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Crustacean">taxon:Crustacean</a>
    /// </summary>
    let Crustacean = _prefixId.prefix "Crustacean"
    /// <summary>
    ///   <para>rdfs:label : Cycad^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Cycad">taxon:Cycad</a>
    /// </summary>
    let Cycad = _prefixId.prefix "Cycad"
    /// <summary>
    ///   <para>rdfs:label : DataObject</para>
    ///   <a href="http://purl.org/biodiversity/taxon/DataObject">taxon:DataObject</a>
    /// </summary>
    let DataObject = _prefixId.prefix "DataObject"
    /// <summary>
    ///   <para>rdfs:comment : Dinosaurs^^xsd:string</para>
    ///   <para>rdfs:label : Dinosauria^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Dinosauria">taxon:Dinosauria</a>
    /// </summary>
    let Dinosauria = _prefixId.prefix "Dinosauria"
    /// <summary>
    ///   <para>rdfs:label : Eukaryote^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Eukaryote">taxon:Eukaryote</a>
    /// </summary>
    let Eukaryote = _prefixId.prefix "Eukaryote"
    /// <summary>
    ///   <para>rdfs:label : Fern^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Fern">taxon:Fern</a>
    /// </summary>
    let Fern = _prefixId.prefix "Fern"
    /// <summary>
    ///   <para>rdfs:label : Fish^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Fish">taxon:Fish</a>
    /// </summary>
    let Fish = _prefixId.prefix "Fish"
    /// <summary>
    ///   <para>rdfs:label : FloweringPlant^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/FloweringPlant">taxon:FloweringPlant</a>
    /// </summary>
    let FloweringPlant = _prefixId.prefix "FloweringPlant"
    /// <summary>
    ///   <para>rdfs:label : Fungus^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Fungus">taxon:Fungus</a>
    /// </summary>
    let Fungus = _prefixId.prefix "Fungus"
    /// <summary>
    ///   <para>rdfs:label : Ginkgo^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Ginkgo">taxon:Ginkgo</a>
    /// </summary>
    let Ginkgo = _prefixId.prefix "Ginkgo"
    /// <summary>
    ///   <para>rdfs:label : Gnetophytes^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Gnetophytes">taxon:Gnetophytes</a>
    /// </summary>
    let Gnetophytes = _prefixId.prefix "Gnetophytes"
    /// <summary>
    ///   <para>rdfs:label : GreenAlga^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/GreenAlga">taxon:GreenAlga</a>
    /// </summary>
    let GreenAlga = _prefixId.prefix "GreenAlga"
    /// <summary>
    ///   <para>rdfs:label : Image^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Image">taxon:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:label : Insect^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Insect">taxon:Insect</a>
    /// </summary>
    let Insect = _prefixId.prefix "Insect"
    /// <summary>
    ///   <para>rdfs:label : Jawless fish^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Jawless_fish">taxon:Jawless_fish</a>
    /// </summary>
    let Jawless_fish = _prefixId.prefix "Jawless_fish"
    /// <summary>
    ///   <para>rdfs:label : Lobe Finned Fish^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Lobe_Finned_fish">taxon:Lobe_Finned_fish</a>
    /// </summary>
    let Lobe_Finned_fish = _prefixId.prefix "Lobe_Finned_fish"
    /// <summary>
    ///   <para>rdfs:label : Lungfish^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Lungfish">taxon:Lungfish</a>
    /// </summary>
    let Lungfish = _prefixId.prefix "Lungfish"
    /// <summary>
    ///   <para>rdfs:label : Mammal^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Mammal">taxon:Mammal</a>
    /// </summary>
    let Mammal = _prefixId.prefix "Mammal"
    /// <summary>
    ///   <para>rdfs:label : MapImage^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/MapImage">taxon:MapImage</a>
    /// </summary>
    let MapImage = _prefixId.prefix "MapImage"
    /// <summary>
    ///   <para>rdfs:comment : a polyphyletic group^^xsd:string</para>
    ///   <para>rdfs:label : Microbial Eukaryote^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Microbial_Eukaryote">taxon:Microbial_Eukaryote</a>
    /// </summary>
    let Microbial_Eukaryote = _prefixId.prefix "Microbial_Eukaryote"
    /// <summary>
    ///   <para>rdfs:comment : The class of recently extant reptiles including Crocodiles, Turtles, Snakes and Lizards^^xsd:string</para>
    ///   <para>rdfs:label : Modern Reptile^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/ModernReptile">taxon:ModernReptile</a>
    /// </summary>
    let ModernReptile = _prefixId.prefix "ModernReptile"
    /// <summary>
    ///   <para>rdfs:label : Mollusca^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Mollusca">taxon:Mollusca</a>
    /// </summary>
    let Mollusca = _prefixId.prefix "Mollusca"
    /// <summary>
    ///   <para>rdfs:label : Moss^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Moss">taxon:Moss</a>
    /// </summary>
    let Moss = _prefixId.prefix "Moss"
    /// <summary>
    ///   <para>rdfs:label : Viridiplantae^^xsd:stringrdfs:label : Plant^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Plant">taxon:Plant</a>
    /// </summary>
    let Plant = _prefixId.prefix "Plant"
    /// <summary>
    ///   <para>rdfs:label : Ray Fined Fish^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Ray_Fined_fish">taxon:Ray_Fined_fish</a>
    /// </summary>
    let Ray_Fined_fish = _prefixId.prefix "Ray_Fined_fish"
    /// <summary>
    ///   <para>rdfs:label : Red algae^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Red_algae">taxon:Red_algae</a>
    /// </summary>
    let Red_algae = _prefixId.prefix "Red_algae"
    /// <summary>
    ///   <para>rdfs:comment : A proposed superclass for all the known LOD classes for a "taxon"^^xsd:string</para>
    ///   <para>rdfs:label : Taxon^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Taxon">taxon:Taxon</a>
    /// </summary>
    let Taxon = _prefixId.prefix "Taxon"
    let TaxonConcept = _prefixId.prefix "TaxonConcept"
    /// <summary>
    ///   <para>rdfs:comment : A proposed superclass for all the known LOD classes a taxon name^^xsd:string</para>
    ///   <para>rdfs:label : TaxonName^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/TaxonName">taxon:TaxonName</a>
    /// </summary>
    let TaxonName = _prefixId.prefix "TaxonName"
    /// <summary>
    ///   <para>rdfs:label : TaxonNameID^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/TaxonNameID">taxon:TaxonNameID</a>
    /// </summary>
    let TaxonNameID = _prefixId.prefix "TaxonNameID"
    /// <summary>
    ///   <para>rdfs:comment : A proposed superclass for all the known LOD classes of a Taxon Rank^^xsd:string</para>
    ///   <para>rdfs:label : TaxonRank^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/TaxonRank">taxon:TaxonRank</a>
    /// </summary>
    let TaxonRank = _prefixId.prefix "TaxonRank"
    /// <summary>
    ///   <para>rdfs:label : Tetrapod^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Tetrapod">taxon:Tetrapod</a>
    /// </summary>
    let Tetrapod = _prefixId.prefix "Tetrapod"
    /// <summary>
    ///   <para>rdfs:label : Tunicate^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Tunicate">taxon:Tunicate</a>
    /// </summary>
    let Tunicate = _prefixId.prefix "Tunicate"
    /// <summary>
    ///   <para>rdfs:comment : a polyphyletic group^^xsd:string</para>
    ///   <para>rdfs:label : Unclassified Chordate^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/Unclassified_Chordate">taxon:Unclassified_Chordate</a>
    /// </summary>
    let Unclassified_Chordate = _prefixId.prefix "Unclassified_Chordate"
    /// <summary>
    ///   <para>rdfs:comment : The author and year of the species description publication i.e (Baker 1899)^^xsd:string</para>
    ///   <para>rdfs:label : authority^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/authority">taxon:authority</a>
    /// </summary>
    let authority = _prefixId.prefix "authority"
    /// <summary>
    ///   <para>rdfs:comment : a scientific name consisting of genus, epithet i.e. Felis silvestris^^xsd:string</para>
    ///   <para>rdfs:label : binomial^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/binomial">taxon:binomial</a>
    /// </summary>
    let binomial = _prefixId.prefix "binomial"
    /// <summary>
    ///   <para>rdfs:comment : The URI ID for the canonical form of the name i.e. Puma concolor or Felidae, for name to name mapping^^xsd:string</para>
    ///   <para>rdfs:label : canonicalFormID^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/canonicalFormID">taxon:canonicalFormID</a>
    /// </summary>
    let canonicalFormID = _prefixId.prefix "canonicalFormID"
    /// <summary>
    ///   <para>rdfs:comment : The URI ID for the scientific name with authorship form of the name i.e. Puma concolor Linnaeus 1758, for name to name mapping^^xsd:string</para>
    ///   <para>rdfs:label : canonicalFormID Of^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/canonicalFormID_Of">taxon:canonicalFormID_Of</a>
    /// </summary>
    let canonicalFormID_Of = _prefixId.prefix "canonicalFormID_Of"
    /// <summary>
    ///   <para>rdfs:comment : The common name for a taxon i.e. "Wolf"^^xsd:string</para>
    ///   <para>rdfs:label : commonName^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/commonName">taxon:commonName</a>
    /// </summary>
    let commonName = _prefixId.prefix "commonName"
    /// <summary>
    ///   <para>rdfs:label : dbClass</para>
    ///   <a href="http://purl.org/biodiversity/taxon/dbClass">taxon:dbClass</a>
    /// </summary>
    let dbClass = _prefixId.prefix "dbClass"
    /// <summary>
    ///   <para>rdfs:label : dbFamily</para>
    ///   <a href="http://purl.org/biodiversity/taxon/dbFamily">taxon:dbFamily</a>
    /// </summary>
    let dbFamily = _prefixId.prefix "dbFamily"
    /// <summary>
    ///   <para>rdfs:label : dbGenus</para>
    ///   <a href="http://purl.org/biodiversity/taxon/dbGenus">taxon:dbGenus</a>
    /// </summary>
    let dbGenus = _prefixId.prefix "dbGenus"
    /// <summary>
    ///   <para>rdfs:label : dbKingdom</para>
    ///   <a href="http://purl.org/biodiversity/taxon/dbKingdom">taxon:dbKingdom</a>
    /// </summary>
    let dbKingdom = _prefixId.prefix "dbKingdom"
    /// <summary>
    ///   <para>rdfs:label : dbOrder</para>
    ///   <a href="http://purl.org/biodiversity/taxon/dbOrder">taxon:dbOrder</a>
    /// </summary>
    let dbOrder = _prefixId.prefix "dbOrder"
    /// <summary>
    ///   <para>rdfs:label : dbPhylum</para>
    ///   <a href="http://purl.org/biodiversity/taxon/dbPhylum">taxon:dbPhylum</a>
    /// </summary>
    let dbPhylum = _prefixId.prefix "dbPhylum"
    /// <summary>
    ///   <para>rdfs:label : dbSpecies</para>
    ///   <a href="http://purl.org/biodiversity/taxon/dbSpecies">taxon:dbSpecies</a>
    /// </summary>
    let dbSpecies = _prefixId.prefix "dbSpecies"
    /// <summary>
    ///   <para>rdfs:comment : a one word scientific name i.e. Felidae, Mammalia, Metazoa^^xsd:string</para>
    ///   <para>rdfs:label : monomial^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/monomial">taxon:monomial</a>
    /// </summary>
    let monomial = _prefixId.prefix "monomial"
    let relatedName = _prefixId.prefix "relatedName"
    /// <summary>
    ///   <para>rdfs:comment : The URI to a URI of a related name^^xsd:string</para>
    ///   <para>rdfs:label : relatedTaxonNameID^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/relatedTaxonNameID">taxon:relatedTaxonNameID</a>
    /// </summary>
    let relatedTaxonNameID = _prefixId.prefix "relatedTaxonNameID"
    /// <summary>
    ///   <para>rdfs:comment : The URI to a URI of a related name^^xsd:string</para>
    ///   <para>rdfs:label : relatedTaxonNameID_ Of^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/relatedTaxonNameID_Of">taxon:relatedTaxonNameID_Of</a>
    /// </summary>
    let relatedTaxonNameID_Of = _prefixId.prefix "relatedTaxonNameID_Of"
    /// <summary>
    ///   <para>rdfs:comment : The scientific name without the authority string i.e. Felidae or Puma concolor^^xsd:string</para>
    ///   <para>rdfs:label : scientificName^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/scientificName">taxon:scientificName</a>
    /// </summary>
    let scientificName = _prefixId.prefix "scientificName"
    /// <summary>
    ///   <para>rdfs:comment : a scientific name consisting of genus epithet and subepithet i.e. Felis silvestris lybica^^xsd:string</para>
    ///   <para>rdfs:label : trinomial^^xsd:string</para>
    ///   <a href="http://purl.org/biodiversity/taxon/trinomial">taxon:trinomial</a>
    /// </summary>
    let trinomial = _prefixId.prefix "trinomial"
    /// <summary>
    ///   <para>rdfs:label : uniprotClass</para>
    ///   <a href="http://purl.org/biodiversity/taxon/uniprotClass">taxon:uniprotClass</a>
    /// </summary>
    let uniprotClass = _prefixId.prefix "uniprotClass"
    /// <summary>
    ///   <para>rdfs:label : uniprotFamily</para>
    ///   <a href="http://purl.org/biodiversity/taxon/uniprotFamily">taxon:uniprotFamily</a>
    /// </summary>
    let uniprotFamily = _prefixId.prefix "uniprotFamily"
    /// <summary>
    ///   <para>rdfs:label : uniprotGenus</para>
    ///   <a href="http://purl.org/biodiversity/taxon/uniprotGenus">taxon:uniprotGenus</a>
    /// </summary>
    let uniprotGenus = _prefixId.prefix "uniprotGenus"
    /// <summary>
    ///   <para>rdfs:label : uniprotKingdom</para>
    ///   <a href="http://purl.org/biodiversity/taxon/uniprotKingdom">taxon:uniprotKingdom</a>
    /// </summary>
    let uniprotKingdom = _prefixId.prefix "uniprotKingdom"
    /// <summary>
    ///   <para>rdfs:label : uniprotOrder</para>
    ///   <a href="http://purl.org/biodiversity/taxon/uniprotOrder">taxon:uniprotOrder</a>
    /// </summary>
    let uniprotOrder = _prefixId.prefix "uniprotOrder"
    /// <summary>
    ///   <para>rdfs:label : uniprotPhylum</para>
    ///   <a href="http://purl.org/biodiversity/taxon/uniprotPhylum">taxon:uniprotPhylum</a>
    /// </summary>
    let uniprotPhylum = _prefixId.prefix "uniprotPhylum"
    /// <summary>
    ///   <para>rdfs:label : uniprotSpecies</para>
    ///   <a href="http://purl.org/biodiversity/taxon/uniprotSpecies">taxon:uniprotSpecies</a>
    /// </summary>
    let uniprotSpecies = _prefixId.prefix "uniprotSpecies"
