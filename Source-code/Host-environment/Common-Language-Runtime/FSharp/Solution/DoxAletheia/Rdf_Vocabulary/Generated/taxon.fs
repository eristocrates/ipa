namespace http.purl.org.biodiversity.taxon.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module taxon =
    let _namespace_iri = Namespace_Iri taxon |> NamespaceIRI
    /// <summary>
    ///   <para>taxon:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Version 0.18 Added those taxon classes I know about, and data type properties for scientific name and authority</para>
    /// labels<para>TaxonMap Ontology</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/">http://purl.org/biodiversity/taxon/</seealso>
    let _prefix_iri = Prefixed_Name(taxon, "") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Tetrapod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Tetrapod</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Tetrapod">http://purl.org/biodiversity/taxon/Tetrapod</seealso>
    let Tetrapod = Prefixed_Name(taxon, "Tetrapod") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Arachnid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Arachnid</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Arachnid">http://purl.org/biodiversity/taxon/Arachnid</seealso>
    let Arachnid = Prefixed_Name(taxon, "Arachnid") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Arthropod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Arthropod</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Arthropod">http://purl.org/biodiversity/taxon/Arthropod</seealso>
    let Arthropod = Prefixed_Name(taxon, "Arthropod") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Fish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fish</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Fish">http://purl.org/biodiversity/taxon/Fish</seealso>
    let Fish = Prefixed_Name(taxon, "Fish") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Bacteria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bacteria</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Bacteria">http://purl.org/biodiversity/taxon/Bacteria</seealso>
    let Bacteria = Prefixed_Name(taxon, "Bacteria") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Cartilaginous_fish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cartilaginous Fish</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Cartilaginous_fish">http://purl.org/biodiversity/taxon/Cartilaginous_fish</seealso>
    let Cartilaginous_fish = Prefixed_Name(taxon, "Cartilaginous_fish") |> PrefixedName
    /// <summary>
    ///   <para>taxon:ClubMoss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ClubMoss</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/ClubMoss">http://purl.org/biodiversity/taxon/ClubMoss</seealso>
    let ClubMoss = Prefixed_Name(taxon, "ClubMoss") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Cycad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cycad</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Cycad">http://purl.org/biodiversity/taxon/Cycad</seealso>
    let Cycad = Prefixed_Name(taxon, "Cycad") |> PrefixedName
    /// <summary>
    ///   <para>taxon:DataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>DataObject</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/DataObject">http://purl.org/biodiversity/taxon/DataObject</seealso>
    let DataObject = Prefixed_Name(taxon, "DataObject") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Fern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fern</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Fern">http://purl.org/biodiversity/taxon/Fern</seealso>
    let Fern = Prefixed_Name(taxon, "Fern") |> PrefixedName
    /// <summary>
    ///   <para>taxon:GreenAlga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>GreenAlga</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/GreenAlga">http://purl.org/biodiversity/taxon/GreenAlga</seealso>
    let GreenAlga = Prefixed_Name(taxon, "GreenAlga") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Image</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Image">http://purl.org/biodiversity/taxon/Image</seealso>
    let Image = Prefixed_Name(taxon, "Image") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Ray_Fined_fish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ray Fined Fish</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Ray_Fined_fish">http://purl.org/biodiversity/taxon/Ray_Fined_fish</seealso>
    let Ray_Fined_fish = Prefixed_Name(taxon, "Ray_Fined_fish") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Red_algae</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Red algae</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Red_algae">http://purl.org/biodiversity/taxon/Red_algae</seealso>
    let Red_algae = Prefixed_Name(taxon, "Red_algae") |> PrefixedName
    /// <summary>
    ///   <para>taxon:TaxonRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A proposed superclass for all the known LOD classes of a Taxon Rank</para>
    /// labels<para>TaxonRank</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/TaxonRank">http://purl.org/biodiversity/taxon/TaxonRank</seealso>
    let TaxonRank = Prefixed_Name(taxon, "TaxonRank") |> PrefixedName
    /// <summary>
    ///   <para>taxon:binomial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>a scientific name consisting of genus, epithet i.e. Felis silvestris</para>
    /// labels<para>binomial</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/binomial">http://purl.org/biodiversity/taxon/binomial</seealso>
    let binomial = Prefixed_Name(taxon, "binomial") |> PrefixedName
    /// <summary>
    ///   <para>taxon:scientificName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The scientific name without the authority string i.e. Felidae or Puma concolor</para>
    /// labels<para>scientificName</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/scientificName">http://purl.org/biodiversity/taxon/scientificName</seealso>
    let scientificName = Prefixed_Name(taxon, "scientificName") |> PrefixedName
    /// <summary>
    ///   <para>taxon:canonicalFormID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI ID for the canonical form of the name i.e. Puma concolor or Felidae, for name to name mapping</para>
    /// labels<para>canonicalFormID</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/canonicalFormID">http://purl.org/biodiversity/taxon/canonicalFormID</seealso>
    let canonicalFormID = Prefixed_Name(taxon, "canonicalFormID") |> PrefixedName
    /// <summary>
    ///   <para>taxon:dbKingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dbKingdom</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/dbKingdom">http://purl.org/biodiversity/taxon/dbKingdom</seealso>
    let dbKingdom = Prefixed_Name(taxon, "dbKingdom") |> PrefixedName
    /// <summary>
    ///   <para>taxon:dbOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dbOrder</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/dbOrder">http://purl.org/biodiversity/taxon/dbOrder</seealso>
    let dbOrder = Prefixed_Name(taxon, "dbOrder") |> PrefixedName
    /// <summary>
    ///   <para>taxon:dbPhylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dbPhylum</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/dbPhylum">http://purl.org/biodiversity/taxon/dbPhylum</seealso>
    let dbPhylum = Prefixed_Name(taxon, "dbPhylum") |> PrefixedName
    /// <summary>
    ///   <para>taxon:dbSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dbSpecies</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/dbSpecies">http://purl.org/biodiversity/taxon/dbSpecies</seealso>
    let dbSpecies = Prefixed_Name(taxon, "dbSpecies") |> PrefixedName
    /// <summary>
    ///   <para>taxon:monomial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>a one word scientific name i.e. Felidae, Mammalia, Metazoa</para>
    /// labels<para>monomial</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/monomial">http://purl.org/biodiversity/taxon/monomial</seealso>
    let monomial = Prefixed_Name(taxon, "monomial") |> PrefixedName
    /// <summary>
    ///   <para>taxon:uniprotKingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotKingdom</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/uniprotKingdom">http://purl.org/biodiversity/taxon/uniprotKingdom</seealso>
    let uniprotKingdom = Prefixed_Name(taxon, "uniprotKingdom") |> PrefixedName
    /// <summary>
    ///   <para>taxon:uniprotOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotOrder</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/uniprotOrder">http://purl.org/biodiversity/taxon/uniprotOrder</seealso>
    let uniprotOrder = Prefixed_Name(taxon, "uniprotOrder") |> PrefixedName
    /// <summary>
    ///   <para>taxon:uniprotPhylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotPhylum</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/uniprotPhylum">http://purl.org/biodiversity/taxon/uniprotPhylum</seealso>
    let uniprotPhylum = Prefixed_Name(taxon, "uniprotPhylum") |> PrefixedName
    /// <summary>
    ///   <para>taxon:uniprotSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotSpecies</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/uniprotSpecies">http://purl.org/biodiversity/taxon/uniprotSpecies</seealso>
    let uniprotSpecies = Prefixed_Name(taxon, "uniprotSpecies") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Amphibian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Amphibian</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Amphibian">http://purl.org/biodiversity/taxon/Amphibian</seealso>
    let Amphibian = Prefixed_Name(taxon, "Amphibian") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Animal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Animal</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Animal">http://purl.org/biodiversity/taxon/Animal</seealso>
    let Animal = Prefixed_Name(taxon, "Animal") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Eukaryote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Eukaryote</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Eukaryote">http://purl.org/biodiversity/taxon/Eukaryote</seealso>
    let Eukaryote = Prefixed_Name(taxon, "Eukaryote") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Archaea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Archaea</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Archaea">http://purl.org/biodiversity/taxon/Archaea</seealso>
    let Archaea = Prefixed_Name(taxon, "Archaea") |> PrefixedName
    /// <summary>
    ///   <para>taxon:BiologicalOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>BiologicalOrganism</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/BiologicalOrganism">http://purl.org/biodiversity/taxon/BiologicalOrganism</seealso>
    let BiologicalOrganism = Prefixed_Name(taxon, "BiologicalOrganism") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Armoured_fish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Armoured_fish</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Armoured_fish">http://purl.org/biodiversity/taxon/Armoured_fish</seealso>
    let Armoured_fish = Prefixed_Name(taxon, "Armoured_fish") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Bird</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bird</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Bird">http://purl.org/biodiversity/taxon/Bird</seealso>
    let Bird = Prefixed_Name(taxon, "Bird") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Cephalochordate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cephalochordate</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Cephalochordate">http://purl.org/biodiversity/taxon/Cephalochordate</seealso>
    let Cephalochordate = Prefixed_Name(taxon, "Cephalochordate") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Chordate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Chordate</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Chordate">http://purl.org/biodiversity/taxon/Chordate</seealso>
    let Chordate = Prefixed_Name(taxon, "Chordate") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Plant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Viridiplantae</para><para>Plant</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Plant">http://purl.org/biodiversity/taxon/Plant</seealso>
    let Plant = Prefixed_Name(taxon, "Plant") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Conifer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Conifer</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Conifer">http://purl.org/biodiversity/taxon/Conifer</seealso>
    let Conifer = Prefixed_Name(taxon, "Conifer") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Crustacean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Crustacean</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Crustacean">http://purl.org/biodiversity/taxon/Crustacean</seealso>
    let Crustacean = Prefixed_Name(taxon, "Crustacean") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Dinosauria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dinosaurs</para>
    /// labels<para>Dinosauria</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Dinosauria">http://purl.org/biodiversity/taxon/Dinosauria</seealso>
    let Dinosauria = Prefixed_Name(taxon, "Dinosauria") |> PrefixedName
    /// <summary>
    ///   <para>taxon:FloweringPlant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>FloweringPlant</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/FloweringPlant">http://purl.org/biodiversity/taxon/FloweringPlant</seealso>
    let FloweringPlant = Prefixed_Name(taxon, "FloweringPlant") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Fungus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fungus</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Fungus">http://purl.org/biodiversity/taxon/Fungus</seealso>
    let Fungus = Prefixed_Name(taxon, "Fungus") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Ginkgo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ginkgo</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Ginkgo">http://purl.org/biodiversity/taxon/Ginkgo</seealso>
    let Ginkgo = Prefixed_Name(taxon, "Ginkgo") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Gnetophytes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gnetophytes</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Gnetophytes">http://purl.org/biodiversity/taxon/Gnetophytes</seealso>
    let Gnetophytes = Prefixed_Name(taxon, "Gnetophytes") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Insect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Insect</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Insect">http://purl.org/biodiversity/taxon/Insect</seealso>
    let Insect = Prefixed_Name(taxon, "Insect") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Jawless_fish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Jawless fish</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Jawless_fish">http://purl.org/biodiversity/taxon/Jawless_fish</seealso>
    let Jawless_fish = Prefixed_Name(taxon, "Jawless_fish") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Lobe_Finned_fish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Lobe Finned Fish</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Lobe_Finned_fish">http://purl.org/biodiversity/taxon/Lobe_Finned_fish</seealso>
    let Lobe_Finned_fish = Prefixed_Name(taxon, "Lobe_Finned_fish") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Lungfish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Lungfish</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Lungfish">http://purl.org/biodiversity/taxon/Lungfish</seealso>
    let Lungfish = Prefixed_Name(taxon, "Lungfish") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Mammal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mammal</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Mammal">http://purl.org/biodiversity/taxon/Mammal</seealso>
    let Mammal = Prefixed_Name(taxon, "Mammal") |> PrefixedName
    /// <summary>
    ///   <para>taxon:MapImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>MapImage</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/MapImage">http://purl.org/biodiversity/taxon/MapImage</seealso>
    let MapImage = Prefixed_Name(taxon, "MapImage") |> PrefixedName

    /// <summary>
    ///   <para>taxon:Microbial_Eukaryote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a polyphyletic group</para>
    /// labels<para>Microbial Eukaryote</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Microbial_Eukaryote">http://purl.org/biodiversity/taxon/Microbial_Eukaryote</seealso>
    let Microbial_Eukaryote =
        Prefixed_Name(taxon, "Microbial_Eukaryote") |> PrefixedName

    /// <summary>
    ///   <para>taxon:ModernReptile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of recently extant reptiles including Crocodiles, Turtles, Snakes and Lizards</para>
    /// labels<para>Modern Reptile</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/ModernReptile">http://purl.org/biodiversity/taxon/ModernReptile</seealso>
    let ModernReptile = Prefixed_Name(taxon, "ModernReptile") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Mollusca</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mollusca</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Mollusca">http://purl.org/biodiversity/taxon/Mollusca</seealso>
    let Mollusca = Prefixed_Name(taxon, "Mollusca") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Moss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Moss</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Moss">http://purl.org/biodiversity/taxon/Moss</seealso>
    let Moss = Prefixed_Name(taxon, "Moss") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Taxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A proposed superclass for all the known LOD classes for a "taxon"</para>
    /// labels<para>Taxon</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Taxon">http://purl.org/biodiversity/taxon/Taxon</seealso>
    let Taxon = Prefixed_Name(taxon, "Taxon") |> PrefixedName
    /// <summary>
    ///   <para>taxon:TaxonConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/TaxonConcept">http://purl.org/biodiversity/taxon/TaxonConcept</seealso>
    let TaxonConcept = Prefixed_Name(taxon, "TaxonConcept") |> PrefixedName
    /// <summary>
    ///   <para>taxon:TaxonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A proposed superclass for all the known LOD classes a taxon name</para>
    /// labels<para>TaxonName</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/TaxonName">http://purl.org/biodiversity/taxon/TaxonName</seealso>
    let TaxonName = Prefixed_Name(taxon, "TaxonName") |> PrefixedName
    /// <summary>
    ///   <para>taxon:TaxonNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>TaxonNameID</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/TaxonNameID">http://purl.org/biodiversity/taxon/TaxonNameID</seealso>
    let TaxonNameID = Prefixed_Name(taxon, "TaxonNameID") |> PrefixedName
    /// <summary>
    ///   <para>taxon:Tunicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Tunicate</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Tunicate">http://purl.org/biodiversity/taxon/Tunicate</seealso>
    let Tunicate = Prefixed_Name(taxon, "Tunicate") |> PrefixedName

    /// <summary>
    ///   <para>taxon:Unclassified_Chordate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a polyphyletic group</para>
    /// labels<para>Unclassified Chordate</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/Unclassified_Chordate">http://purl.org/biodiversity/taxon/Unclassified_Chordate</seealso>
    let Unclassified_Chordate =
        Prefixed_Name(taxon, "Unclassified_Chordate") |> PrefixedName

    /// <summary>
    ///   <para>taxon:authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The author and year of the species description publication i.e (Baker 1899)</para>
    /// labels<para>authority</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/authority">http://purl.org/biodiversity/taxon/authority</seealso>
    let authority = Prefixed_Name(taxon, "authority") |> PrefixedName
    /// <summary>
    ///   <para>taxon:relatedTaxonNameID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to a URI of a related name</para>
    /// labels<para>relatedTaxonNameID</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/relatedTaxonNameID">http://purl.org/biodiversity/taxon/relatedTaxonNameID</seealso>
    let relatedTaxonNameID = Prefixed_Name(taxon, "relatedTaxonNameID") |> PrefixedName
    /// <summary>
    ///   <para>taxon:canonicalFormID_Of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI ID for the scientific name with authorship form of the name i.e. Puma concolor Linnaeus 1758, for name to name mapping</para>
    /// labels<para>canonicalFormID Of</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/canonicalFormID_Of">http://purl.org/biodiversity/taxon/canonicalFormID_Of</seealso>
    let canonicalFormID_Of = Prefixed_Name(taxon, "canonicalFormID_Of") |> PrefixedName

    /// <summary>
    ///   <para>taxon:relatedTaxonNameID_Of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI to a URI of a related name</para>
    /// labels<para>relatedTaxonNameID_ Of</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/relatedTaxonNameID_Of">http://purl.org/biodiversity/taxon/relatedTaxonNameID_Of</seealso>
    let relatedTaxonNameID_Of =
        Prefixed_Name(taxon, "relatedTaxonNameID_Of") |> PrefixedName

    /// <summary>
    ///   <para>taxon:commonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The common name for a taxon i.e. "Wolf"</para>
    /// labels<para>commonName</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/commonName">http://purl.org/biodiversity/taxon/commonName</seealso>
    let commonName = Prefixed_Name(taxon, "commonName") |> PrefixedName
    /// <summary>
    ///   <para>taxon:dbClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dbClass</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/dbClass">http://purl.org/biodiversity/taxon/dbClass</seealso>
    let dbClass = Prefixed_Name(taxon, "dbClass") |> PrefixedName
    /// <summary>
    ///   <para>taxon:dbFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dbFamily</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/dbFamily">http://purl.org/biodiversity/taxon/dbFamily</seealso>
    let dbFamily = Prefixed_Name(taxon, "dbFamily") |> PrefixedName
    /// <summary>
    ///   <para>taxon:dbGenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dbGenus</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/dbGenus">http://purl.org/biodiversity/taxon/dbGenus</seealso>
    let dbGenus = Prefixed_Name(taxon, "dbGenus") |> PrefixedName
    /// <summary>
    ///   <para>taxon:relatedName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/relatedName">http://purl.org/biodiversity/taxon/relatedName</seealso>
    let relatedName = Prefixed_Name(taxon, "relatedName") |> PrefixedName
    /// <summary>
    ///   <para>taxon:trinomial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>a scientific name consisting of genus epithet and subepithet i.e. Felis silvestris lybica</para>
    /// labels<para>trinomial</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/trinomial">http://purl.org/biodiversity/taxon/trinomial</seealso>
    let trinomial = Prefixed_Name(taxon, "trinomial") |> PrefixedName
    /// <summary>
    ///   <para>taxon:uniprotClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotClass</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/uniprotClass">http://purl.org/biodiversity/taxon/uniprotClass</seealso>
    let uniprotClass = Prefixed_Name(taxon, "uniprotClass") |> PrefixedName
    /// <summary>
    ///   <para>taxon:uniprotFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotFamily</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/uniprotFamily">http://purl.org/biodiversity/taxon/uniprotFamily</seealso>
    let uniprotFamily = Prefixed_Name(taxon, "uniprotFamily") |> PrefixedName
    /// <summary>
    ///   <para>taxon:uniprotGenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uniprotGenus</para></remarks>
    /// <seealso href="http://purl.org/biodiversity/taxon/uniprotGenus">http://purl.org/biodiversity/taxon/uniprotGenus</seealso>
    let uniprotGenus = Prefixed_Name(taxon, "uniprotGenus") |> PrefixedName
