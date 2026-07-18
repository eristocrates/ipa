namespace http.lod.taxonconcept.org.ontology.txn.owl.hash

open DoxAletheia.Rdf_Vocabulary

module txn =
    let _namespace_name = "http://lod.taxonconcept.org/ontology/txn.owl#"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_female"></see>
    /// </summary>
    let Sex_female = Namespaced_IRI.parse _namespace_name "Sex_female" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_hermaphrodite"></see>
    /// </summary>
    let Sex_hermaphrodite =
        Namespaced_IRI.parse _namespace_name "Sex_hermaphrodite" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_male"></see>
    /// </summary>
    let Sex_male = Namespaced_IRI.parse _namespace_name "Sex_male" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_undetermined"></see>
    /// </summary>
    let Sex_undetermined =
        Namespaced_IRI.parse _namespace_name "Sex_undetermined" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_unknowable"></see>
    /// </summary>
    let Sex_unknowable =
        Namespaced_IRI.parse _namespace_name "Sex_unknowable" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonConcept_Knowledge_Base_Project"></see>
    /// </summary>
    let TaxonConcept_Knowledge_Base_Project =
        Namespaced_IRI.parse _namespace_name "TaxonConcept_Knowledge_Base_Project" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Area"></see>
    /// </summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#BinomialNameID"></see>
    /// </summary>
    let BinomialNameID =
        Namespaced_IRI.parse _namespace_name "BinomialNameID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificNameID"></see>
    /// </summary>
    let ScientificNameID =
        Namespaced_IRI.parse _namespace_name "ScientificNameID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#CommonNameID"></see>
    /// </summary>
    let CommonNameID =
        Namespaced_IRI.parse _namespace_name "CommonNameID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonNameID"></see>
    /// </summary>
    let TaxonNameID =
        Namespaced_IRI.parse _namespace_name "TaxonNameID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#DataObject"></see>
    /// </summary>
    let DataObject = Namespaced_IRI.parse _namespace_name "DataObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#FamilyNameID"></see>
    /// </summary>
    let FamilyNameID =
        Namespaced_IRI.parse _namespace_name "FamilyNameID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#MonomialNameID"></see>
    /// </summary>
    let MonomialNameID =
        Namespaced_IRI.parse _namespace_name "MonomialNameID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#FreshwaterHabitat"></see>
    /// </summary>
    let FreshwaterHabitat =
        Namespaced_IRI.parse _namespace_name "FreshwaterHabitat" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Habitat"></see>
    /// </summary>
    let Habitat = Namespaced_IRI.parse _namespace_name "Habitat" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Gallery"></see>
    /// </summary>
    let Gallery = Namespaced_IRI.parse _namespace_name "Gallery" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#GenusNameID"></see>
    /// </summary>
    let GenusNameID =
        Namespaced_IRI.parse _namespace_name "GenusNameID" |> NamespacedName

    /// <summary>
    /// An identification action. The identification of a specimen.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#Identification"></see></summary>
    let Identification =
        Namespaced_IRI.parse _namespace_name "Identification" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Image"></see>
    /// </summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#MapImage"></see>
    /// </summary>
    let MapImage = Namespaced_IRI.parse _namespace_name "MapImage" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#MarineHabitat"></see>
    /// </summary>
    let MarineHabitat =
        Namespaced_IRI.parse _namespace_name "MarineHabitat" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Occurrence"></see>
    /// </summary>
    let Occurrence = Namespaced_IRI.parse _namespace_name "Occurrence" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#OccurrenceSpecimenTag"></see>
    /// </summary>
    let OccurrenceSpecimenTag =
        Namespaced_IRI.parse _namespace_name "OccurrenceSpecimenTag" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#OccurrenceTaxonTag"></see>
    /// </summary>
    let OccurrenceTaxonTag =
        Namespaced_IRI.parse _namespace_name "OccurrenceTaxonTag" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#OpenCycTaxon"></see>
    /// </summary>
    let OpenCycTaxon =
        Namespaced_IRI.parse _namespace_name "OpenCycTaxon" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankClass"></see>
    /// </summary>
    let RankClass = Namespaced_IRI.parse _namespace_name "RankClass" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonRank"></see>
    /// </summary>
    let TaxonRank = Namespaced_IRI.parse _namespace_name "TaxonRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperclass"></see>
    /// </summary>
    let RankSuperclass =
        Namespaced_IRI.parse _namespace_name "RankSuperclass" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubclass"></see>
    /// </summary>
    let RankSubclass =
        Namespaced_IRI.parse _namespace_name "RankSubclass" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankDivision"></see>
    /// </summary>
    let RankDivision =
        Namespaced_IRI.parse _namespace_name "RankDivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankDomain"></see>
    /// </summary>
    let RankDomain = Namespaced_IRI.parse _namespace_name "RankDomain" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubdomain"></see>
    /// </summary>
    let RankSubdomain =
        Namespaced_IRI.parse _namespace_name "RankSubdomain" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankFamily"></see>
    /// </summary>
    let RankFamily = Namespaced_IRI.parse _namespace_name "RankFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperfamily"></see>
    /// </summary>
    let RankSuperfamily =
        Namespaced_IRI.parse _namespace_name "RankSuperfamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubfamily"></see>
    /// </summary>
    let RankSubfamily =
        Namespaced_IRI.parse _namespace_name "RankSubfamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankGenus"></see>
    /// </summary>
    let RankGenus = Namespaced_IRI.parse _namespace_name "RankGenus" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankTribe"></see>
    /// </summary>
    let RankTribe = Namespaced_IRI.parse _namespace_name "RankTribe" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubgenus"></see>
    /// </summary>
    let RankSubgenus =
        Namespaced_IRI.parse _namespace_name "RankSubgenus" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankInfraclass"></see>
    /// </summary>
    let RankInfraclass =
        Namespaced_IRI.parse _namespace_name "RankInfraclass" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperorder"></see>
    /// </summary>
    let RankSuperorder =
        Namespaced_IRI.parse _namespace_name "RankSuperorder" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankInfrakingdom"></see>
    /// </summary>
    let RankInfrakingdom =
        Namespaced_IRI.parse _namespace_name "RankInfrakingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubkingdom"></see>
    /// </summary>
    let RankSubkingdom =
        Namespaced_IRI.parse _namespace_name "RankSubkingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperphylum"></see>
    /// </summary>
    let RankSuperphylum =
        Namespaced_IRI.parse _namespace_name "RankSuperphylum" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankInfraorder"></see>
    /// </summary>
    let RankInfraorder =
        Namespaced_IRI.parse _namespace_name "RankInfraorder" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuborder"></see>
    /// </summary>
    let RankSuborder =
        Namespaced_IRI.parse _namespace_name "RankSuborder" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankParvorder"></see>
    /// </summary>
    let RankParvorder =
        Namespaced_IRI.parse _namespace_name "RankParvorder" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankKingdom"></see>
    /// </summary>
    let RankKingdom =
        Namespaced_IRI.parse _namespace_name "RankKingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperkingdom"></see>
    /// </summary>
    let RankSuperkingdom =
        Namespaced_IRI.parse _namespace_name "RankSuperkingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankOrder"></see>
    /// </summary>
    let RankOrder = Namespaced_IRI.parse _namespace_name "RankOrder" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankPhylum"></see>
    /// </summary>
    let RankPhylum = Namespaced_IRI.parse _namespace_name "RankPhylum" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubphylum"></see>
    /// </summary>
    let RankSubphylum =
        Namespaced_IRI.parse _namespace_name "RankSubphylum" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSpecies"></see>
    /// </summary>
    let RankSpecies =
        Namespaced_IRI.parse _namespace_name "RankSpecies" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubpecies"></see>
    /// </summary>
    let RankSubpecies =
        Namespaced_IRI.parse _namespace_name "RankSubpecies" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubdivision"></see>
    /// </summary>
    let RankSubdivision =
        Namespaced_IRI.parse _namespace_name "RankSubdivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubspecificAggregate"></see>
    /// </summary>
    let RankSubspecificAggregate =
        Namespaced_IRI.parse _namespace_name "RankSubspecificAggregate" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperdivision"></see>
    /// </summary>
    let RankSuperdivision =
        Namespaced_IRI.parse _namespace_name "RankSuperdivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankVariety"></see>
    /// </summary>
    let RankVariety =
        Namespaced_IRI.parse _namespace_name "RankVariety" |> NamespacedName

    /// <summary>
    /// Someone who has authored a scientific article.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificAuthorPerson"></see></summary>
    let ScientificAuthorPerson =
        Namespaced_IRI.parse _namespace_name "ScientificAuthorPerson" |> NamespacedName

    /// <summary>
    /// Class for Scientist a foaf:Person
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#Scientist"></see></summary>
    let Scientist = Namespaced_IRI.parse _namespace_name "Scientist" |> NamespacedName

    /// <summary>
    /// Someone who has collected a scientific sample or specimen.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificCollectorPerson"></see></summary>
    let ScientificCollectorPerson =
        Namespaced_IRI.parse _namespace_name "ScientificCollectorPerson" |> NamespacedName

    /// <summary>
    /// Someone who has curated or entered data into a scientific data set.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificDataCuratorPerson"></see></summary>
    let ScientificDataCuratorPerson =
        Namespaced_IRI.parse _namespace_name "ScientificDataCuratorPerson" |> NamespacedName

    /// <summary>
    /// Someone who has identified a specimen.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificIdentifierPerson"></see></summary>
    let ScientificIdentifierPerson =
        Namespaced_IRI.parse _namespace_name "ScientificIdentifierPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificNameWithAuthorID"></see>
    /// </summary>
    let ScientificNameWithAuthorID =
        Namespaced_IRI.parse _namespace_name "ScientificNameWithAuthorID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Sex"></see>
    /// </summary>
    let Sex = Namespaced_IRI.parse _namespace_name "Sex" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesConcept"></see>
    /// </summary>
    let SpeciesConcept =
        Namespaced_IRI.parse _namespace_name "SpeciesConcept" |> NamespacedName

    /// <summary>
    /// A particular taxonomic concept. Currently only species concepts are implemented, however theoretically there could be additional subclasses of GenusConcepts, FamilyConcepts etc. A SubspeciesConcept and lower are considered to be subclasses of SpeciesConcepts, but one persons subspecies is often anothers species. My current thinking is to represent individuals and observations of subspecies as individuals and observations of the larger species concept. It has yet to be implemented but I am considering recording these as observations and individuals of a given species "in the form of" their subspecies indentifier or name.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonConcept"></see></summary>
    let TaxonConcept =
        Namespaced_IRI.parse _namespace_name "TaxonConcept" |> NamespacedName

    /// <summary>
    /// A tag like entity that can be used to indicate that an image is associated with a specific species concept. Instances of SpeciesImageTag take the form of the species concept URI with the fragment of #Image rather than #Species.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesImageTag"></see></summary>
    let SpeciesImageTag =
        Namespaced_IRI.parse _namespace_name "SpeciesImageTag" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesIndividual"></see>
    /// </summary>
    let SpeciesIndividual =
        Namespaced_IRI.parse _namespace_name "SpeciesIndividual" |> NamespacedName

    /// <summary>
    /// A tag like entity that can be used to indicate that an individual organism is an associated with a particular species concept. Instances of SpeciesIndividualTag take the form of the species concept URI with the fragment of #Individual rather than #Species.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesIndividualTag"></see></summary>
    let SpeciesIndividualTag =
        Namespaced_IRI.parse _namespace_name "SpeciesIndividualTag" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesModel"></see>
    /// </summary>
    let SpeciesModel =
        Namespaced_IRI.parse _namespace_name "SpeciesModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesOriginalDescription"></see>
    /// </summary>
    let SpeciesOriginalDescription =
        Namespaced_IRI.parse _namespace_name "SpeciesOriginalDescription" |> NamespacedName

    /// <summary>
    /// A tag like entity for the NCBI Taxonomic Classification.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesTaxonomyNCBI"></see></summary>
    let SpeciesTaxonomyNCBI =
        Namespaced_IRI.parse _namespace_name "SpeciesTaxonomyNCBI" |> NamespacedName

    /// <summary>
    /// A organismal specimen that is related to a specific organism, parts of an individual organism, or a collection of these from several organisms. It should be used for the smallest entity in a specimen database. Ideally there should be at least one specimen per individual organism. Specimens consisting of multiple individuals or multiple species often complicate analysis. If one photo contains multiple entities, document these as separate specimens all linked to the same photo.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#Specimen"></see></summary>
    let Specimen = Namespaced_IRI.parse _namespace_name "Specimen" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Status_Preliminary"></see>
    /// </summary>
    let Status_Preliminary =
        Namespaced_IRI.parse _namespace_name "Status_Preliminary" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Status_Testing"></see>
    /// </summary>
    let Status_Testing =
        Namespaced_IRI.parse _namespace_name "Status_Testing" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#SubfamilyNameID"></see>
    /// </summary>
    let SubfamilyNameID =
        Namespaced_IRI.parse _namespace_name "SubfamilyNameID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#SurrogateNameID"></see>
    /// </summary>
    let SurrogateNameID =
        Namespaced_IRI.parse _namespace_name "SurrogateNameID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TDWG2010_BioBlitz_Project"></see>
    /// </summary>
    let TDWG2010_BioBlitz_Project =
        Namespaced_IRI.parse _namespace_name "TDWG2010_BioBlitz_Project" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonConcept_Scheme"></see>
    /// </summary>
    let TaxonConcept_Scheme =
        Namespaced_IRI.parse _namespace_name "TaxonConcept_Scheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonNameGroupID"></see>
    /// </summary>
    let TaxonNameGroupID =
        Namespaced_IRI.parse _namespace_name "TaxonNameGroupID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonOntology"></see>
    /// </summary>
    let TaxonOntology =
        Namespaced_IRI.parse _namespace_name "TaxonOntology" |> NamespacedName

    /// <summary>
    /// Class for a Taxonomist a subclass of dbpedia-owl:Scientist
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#Taxonomist"></see></summary>
    let Taxonomist = Namespaced_IRI.parse _namespace_name "Taxonomist" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TerrestrialHabitat"></see>
    /// </summary>
    let TerrestrialHabitat =
        Namespaced_IRI.parse _namespace_name "TerrestrialHabitat" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TrinomialNameID"></see>
    /// </summary>
    let TrinomialNameID =
        Namespaced_IRI.parse _namespace_name "TrinomialNameID" |> NamespacedName

    /// <summary>
    /// Class for the Concept Year
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#Year"></see></summary>
    let Year = Namespaced_IRI.parse _namespace_name "Year" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#acceptedName"></see>
    /// </summary>
    let acceptedName =
        Namespaced_IRI.parse _namespace_name "acceptedName" |> NamespacedName

    /// <summary>
    /// The URI to the Accepted Name String, should only be one.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#acceptedNameID"></see></summary>
    let acceptedNameID =
        Namespaced_IRI.parse _namespace_name "acceptedNameID" |> NamespacedName

    /// <summary>
    /// The URI to the Taxon Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameID"></see></summary>
    let taxonNameID =
        Namespaced_IRI.parse _namespace_name "taxonNameID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#acceptedTaxonNameID_Of"></see>
    /// </summary>
    let acceptedTaxonNameID_Of =
        Namespaced_IRI.parse _namespace_name "acceptedTaxonNameID_Of" |> NamespacedName

    /// <summary>
    /// The URI to the Taxon Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameID_Of"></see></summary>
    let taxonNameID_Of =
        Namespaced_IRI.parse _namespace_name "taxonNameID_Of" |> NamespacedName

    /// <summary>
    /// The URI to an Alternative Accepted Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#altAcceptedNameID"></see></summary>
    let altAcceptedNameID =
        Namespaced_IRI.parse _namespace_name "altAcceptedNameID" |> NamespacedName

    /// <summary>
    /// The URI to an Alternative Accepted Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#altAcceptedNameID_Of"></see></summary>
    let altAcceptedNameID_Of =
        Namespaced_IRI.parse _namespace_name "altAcceptedNameID_Of" |> NamespacedName

    /// <summary>
    /// The URI to the Original Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#originalNameID"></see></summary>
    let originalNameID =
        Namespaced_IRI.parse _namespace_name "originalNameID" |> NamespacedName

    /// <summary>
    /// Links an Area to an Individual
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#areaHasIndividual"></see></summary>
    let areaHasIndividual =
        Namespaced_IRI.parse _namespace_name "areaHasIndividual" |> NamespacedName

    /// <summary>
    /// Links an Area to a Species Concept
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#areaHasObservedSpeciesConcept"></see></summary>
    let areaHasObservedSpeciesConcept =
        Namespaced_IRI.parse _namespace_name "areaHasObservedSpeciesConcept" |> NamespacedName

    /// <summary>
    /// Links an Area to an Occurrence
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#areaHasOccurrence"></see></summary>
    let areaHasOccurrence =
        Namespaced_IRI.parse _namespace_name "areaHasOccurrence" |> NamespacedName

    /// <summary>
    /// Links an Area to Geonames County URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#areaInCounty"></see></summary>
    let areaInCounty =
        Namespaced_IRI.parse _namespace_name "areaInCounty" |> NamespacedName

    /// <summary>
    /// Links an Area to Geonames State/Province URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#areaInStateProvince"></see></summary>
    let areaInStateProvince =
        Namespaced_IRI.parse _namespace_name "areaInStateProvince" |> NamespacedName

    /// <summary>
    /// This is used to connect geo areas to geoname features
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#areaWithInFeature"></see></summary>
    let areaWithInFeature =
        Namespaced_IRI.parse _namespace_name "areaWithInFeature" |> NamespacedName

    /// <summary>
    /// The author and year of the species description publication i.e (Baker, 1899)
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#authority"></see></summary>
    let authority = Namespaced_IRI.parse _namespace_name "authority" |> NamespacedName

    /// <summary>
    /// Assumed to be equivalent to TDWG Basis of Record
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#basisOfRecord"></see></summary>
    let basisOfRecord =
        Namespaced_IRI.parse _namespace_name "basisOfRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#behavioralNote"></see>
    /// </summary>
    let behavioralNote =
        Namespaced_IRI.parse _namespace_name "behavioralNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#binomial"></see>
    /// </summary>
    let binomial = Namespaced_IRI.parse _namespace_name "binomial" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#botanyAuthorName"></see>
    /// </summary>
    let botanyAuthorName =
        Namespaced_IRI.parse _namespace_name "botanyAuthorName" |> NamespacedName

    /// <summary>
    /// The URI ID for the canonical form of the name i.e. Puma concolor or Felidae, for name to name mapping
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#canonicalFormID"></see></summary>
    let canonicalFormID =
        Namespaced_IRI.parse _namespace_name "canonicalFormID" |> NamespacedName

    /// <summary>
    /// The URI to the Taxon Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#relatedTaxonNameID"></see></summary>
    let relatedTaxonNameID =
        Namespaced_IRI.parse _namespace_name "relatedTaxonNameID" |> NamespacedName

    /// <summary>
    /// The URI ID for the scientific name with authorship form of the name i.e. Puma concolor Linnaeus 1758, for name to name mapping
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#canonicalFormID_Of"></see></summary>
    let canonicalFormID_Of =
        Namespaced_IRI.parse _namespace_name "canonicalFormID_Of" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#catalogCode"></see>
    /// </summary>
    let catalogCode =
        Namespaced_IRI.parse _namespace_name "catalogCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#class"></see>
    /// </summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#scientificName"></see>
    /// </summary>
    let scientificName =
        Namespaced_IRI.parse _namespace_name "scientificName" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#collectionCode"></see>
    /// </summary>
    let collectionCode =
        Namespaced_IRI.parse _namespace_name "collectionCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#commonName"></see>
    /// </summary>
    let commonName = Namespaced_IRI.parse _namespace_name "commonName" |> NamespacedName

    /// <summary>
    /// The Links to the Status of the TaxonConcept
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#conceptStatus"></see></summary>
    let conceptStatus =
        Namespaced_IRI.parse _namespace_name "conceptStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#continent"></see>
    /// </summary>
    let continent = Namespaced_IRI.parse _namespace_name "continent" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#country"></see>
    /// </summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#countryCode"></see>
    /// </summary>
    let countryCode =
        Namespaced_IRI.parse _namespace_name "countryCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#county"></see>
    /// </summary>
    let county = Namespaced_IRI.parse _namespace_name "county" |> NamespacedName
    /// <summary>
    /// This is the year of the description
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#descYear"></see></summary>
    let descYear = Namespaced_IRI.parse _namespace_name "descYear" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#descYearOf"></see>
    /// </summary>
    let descYearOf = Namespaced_IRI.parse _namespace_name "descYearOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#endDate"></see>
    /// </summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#family"></see>
    /// </summary>
    let family = Namespaced_IRI.parse _namespace_name "family" |> NamespacedName

    /// <summary>
    /// This is used to link a geonames feature to a geo area. For example geo:44.86528100,-87.23147800;u=10
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#featureContainsArea"></see></summary>
    let featureContainsArea =
        Namespaced_IRI.parse _namespace_name "featureContainsArea" |> NamespacedName

    /// <summary>
    /// The URI to the First Author
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#firstAuthorID"></see></summary>
    let firstAuthorID =
        Namespaced_IRI.parse _namespace_name "firstAuthorID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#genus"></see>
    /// </summary>
    let genus = Namespaced_IRI.parse _namespace_name "genus" |> NamespacedName

    /// <summary>
    /// The method used to determine the latitude, longitude as a URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#georeferenceProtocol"></see></summary>
    let georeferenceProtocol =
        Namespaced_IRI.parse _namespace_name "georeferenceProtocol" |> NamespacedName

    /// <summary>
    /// Was this location verified, controlled choices URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#georeferenceVerificationStatus"></see></summary>
    let georeferenceVerificationStatus =
        Namespaced_IRI.parse _namespace_name "georeferenceVerificationStatus" |> NamespacedName

    /// <summary>
    /// associates a taxon with a habitat in which it may typically be found
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#habitat"></see></summary>
    let habitat = Namespaced_IRI.parse _namespace_name "habitat" |> NamespacedName
    /// <summary>
    /// The range is a page on the Animal Diversity Web site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasADWPage"></see></summary>
    let hasADWPage = Namespaced_IRI.parse _namespace_name "hasADWPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasAcceptedName"></see>
    /// </summary>
    let hasAcceptedName =
        Namespaced_IRI.parse _namespace_name "hasAcceptedName" |> NamespacedName

    /// <summary>
    /// The range is a page on the BBC site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasBBCPage"></see></summary>
    let hasBBCPage = Namespaced_IRI.parse _namespace_name "hasBBCPage" |> NamespacedName
    /// <summary>
    /// The Barcode of Life Integer ID
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasBOLD"></see></summary>
    let hasBOLD = Namespaced_IRI.parse _namespace_name "hasBOLD" |> NamespacedName

    /// <summary>
    /// A page at boldsystems.org
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasBOLDPage"></see></summary>
    let hasBOLDPage =
        Namespaced_IRI.parse _namespace_name "hasBOLDPage" |> NamespacedName

    /// <summary>
    /// The range is a page on the Bioimages site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasBioimagesPage"></see></summary>
    let hasBioimagesPage =
        Namespaced_IRI.parse _namespace_name "hasBioimagesPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasBugGuidePage"></see>
    /// </summary>
    let hasBugGuidePage =
        Namespaced_IRI.parse _namespace_name "hasBugGuidePage" |> NamespacedName

    /// <summary>
    /// The range is a uniprot pubmed uri for example http://purl.uniprot.org/pubmed/1083304
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasCitation"></see></summary>
    let hasCitation =
        Namespaced_IRI.parse _namespace_name "hasCitation" |> NamespacedName

    /// <summary>
    /// The occurrence observer or specimen collector, hasCollector?
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasCollector"></see></summary>
    let hasCollector =
        Namespaced_IRI.parse _namespace_name "hasCollector" |> NamespacedName

    /// <summary>
    /// The range is a page on the DiscoverLife.org site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasDLPage"></see></summary>
    let hasDLPage = Namespaced_IRI.parse _namespace_name "hasDLPage" |> NamespacedName

    /// <summary>
    /// The range is a page on the Discover Life Web site.
    /// The range is a page on the http://www.discoverlife.org/ site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasDiscoverLifePage"></see></summary>
    let hasDiscoverLifePage =
        Namespaced_IRI.parse _namespace_name "hasDiscoverLifePage" |> NamespacedName

    /// <summary>
    /// The Encyclopedia of Life Integer ID
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasEOL"></see></summary>
    let hasEOL = Namespaced_IRI.parse _namespace_name "hasEOL" |> NamespacedName
    /// <summary>
    /// The range is a page on the Encyclopedia of Life site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasEOLPage"></see></summary>
    let hasEOLPage = Namespaced_IRI.parse _namespace_name "hasEOLPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasEUNISPage"></see>
    /// </summary>
    let hasEUNISPage =
        Namespaced_IRI.parse _namespace_name "hasEUNISPage" |> NamespacedName

    /// <summary>
    /// eBird Species Code
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasEbird"></see></summary>
    let hasEbird = Namespaced_IRI.parse _namespace_name "hasEbird" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasEtypePage"></see>
    /// </summary>
    let hasEtypePage =
        Namespaced_IRI.parse _namespace_name "hasEtypePage" |> NamespacedName

    /// <summary>
    /// This is to link between a geographical area and a taxon-like entity. The doman and range are left blank so this can be used with different kinds of geographic vocabularies and different kinds of taxon concept vocabularies. It should not be used to indicate that a location has the expectation of a specific individual specimen, but to indicate that the location has an expectation of a specific class of organisms. For instance, it would be used to indicate that a geographic location has an expectation of a particular species. The use should approximate assertions similar to what one might find in a state or country checklist.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasExpectationOf"></see></summary>
    let hasExpectationOf =
        Namespaced_IRI.parse _namespace_name "hasExpectationOf" |> NamespacedName

    /// <summary>
    /// The Global Biodiversity Information Facility integer ID
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasGBIF"></see></summary>
    let hasGBIF = Namespaced_IRI.parse _namespace_name "hasGBIF" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasGBIFMap"></see>
    /// </summary>
    let hasGBIFMap = Namespaced_IRI.parse _namespace_name "hasGBIFMap" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasMapImage"></see>
    /// </summary>
    let hasMapImage =
        Namespaced_IRI.parse _namespace_name "hasMapImage" |> NamespacedName

    /// <summary>
    /// A page at GBIF.org
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasGBIFPage"></see></summary>
    let hasGBIFPage =
        Namespaced_IRI.parse _namespace_name "hasGBIFPage" |> NamespacedName

    /// <summary>
    /// The ITIS ID
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasITIS"></see></summary>
    let hasITIS = Namespaced_IRI.parse _namespace_name "hasITIS" |> NamespacedName

    /// <summary>
    /// The range is a page on the ITIS.gov site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasITISPage"></see></summary>
    let hasITISPage =
        Namespaced_IRI.parse _namespace_name "hasITISPage" |> NamespacedName

    /// <summary>
    /// Superproperty of all the links to images
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasImage"></see></summary>
    let hasImage = Namespaced_IRI.parse _namespace_name "hasImage" |> NamespacedName
    /// <summary>
    /// The NCBI Taxonomy ID
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasNCBI"></see></summary>
    let hasNCBI = Namespaced_IRI.parse _namespace_name "hasNCBI" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasOriginalName"></see>
    /// </summary>
    let hasOriginalName =
        Namespaced_IRI.parse _namespace_name "hasOriginalName" |> NamespacedName

    /// <summary>
    /// This is for a string urn type identifier
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasSpeciesConceptID"></see></summary>
    let hasSpeciesConceptID =
        Namespaced_IRI.parse _namespace_name "hasSpeciesConceptID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasUSDAPlantsPage"></see>
    /// </summary>
    let hasUSDAPlantsPage =
        Namespaced_IRI.parse _namespace_name "hasUSDAPlantsPage" |> NamespacedName

    /// <summary>
    /// This is to link between a geographical area and a taxon-like entity. Where the association is not known. The doman and range are left blank so this can be used with different kinds of geographic vocabularies and different kinds of taxon concept vocabularies. It should not be used to indicate that a location has the expectation of a specific individual specimen, but to indicate that the location has an expectation of a specific class of organisms. For instance, it would be used to indicate that a geographic location has an expectation of a particular species. The use should approximate assertions similar to what one might find in a state or country checklist.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasUnknownExpectationOf"></see></summary>
    let hasUnknownExpectationOf =
        Namespaced_IRI.parse _namespace_name "hasUnknownExpectationOf" |> NamespacedName

    /// <summary>
    /// Links a species concept to a Geonames URI where the relationship is unknown
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#isUnknownAboutIn"></see></summary>
    let isUnknownAboutIn =
        Namespaced_IRI.parse _namespace_name "isUnknownAboutIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasWikipediaArticle"></see>
    /// </summary>
    let hasWikipediaArticle =
        Namespaced_IRI.parse _namespace_name "hasWikipediaArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasWikipediaMap"></see>
    /// </summary>
    let hasWikipediaMap =
        Namespaced_IRI.parse _namespace_name "hasWikipediaMap" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasWikispeciesArticle"></see>
    /// </summary>
    let hasWikispeciesArticle =
        Namespaced_IRI.parse _namespace_name "hasWikispeciesArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasWildObsPage"></see>
    /// </summary>
    let hasWildObsPage =
        Namespaced_IRI.parse _namespace_name "hasWildObsPage" |> NamespacedName

    /// <summary>
    /// The URI to the Heterochresonym Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#heterochresonymID"></see></summary>
    let heterochresonymID =
        Namespaced_IRI.parse _namespace_name "heterochresonymID" |> NamespacedName

    /// <summary>
    /// The URI to a synonymID of the TaxonNameID
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#synonymID"></see></summary>
    let synonymID = Namespaced_IRI.parse _namespace_name "synonymID" |> NamespacedName

    /// <summary>
    /// The URI to the HeterotypicName Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#heterotypicNameID"></see></summary>
    let heterotypicNameID =
        Namespaced_IRI.parse _namespace_name "heterotypicNameID" |> NamespacedName

    /// <summary>
    /// The URI to the HomotypicName Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#homotypicNameID"></see></summary>
    let homotypicNameID =
        Namespaced_IRI.parse _namespace_name "homotypicNameID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hybrid"></see>
    /// </summary>
    let hybrid = Namespaced_IRI.parse _namespace_name "hybrid" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationDate"></see>
    /// </summary>
    let identificationDate =
        Namespaced_IRI.parse _namespace_name "identificationDate" |> NamespacedName

    /// <summary>
    /// The image of the identification label on a specimen
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationHasLabelImage"></see></summary>
    let identificationHasLabelImage =
        Namespaced_IRI.parse _namespace_name "identificationHasLabelImage" |> NamespacedName

    /// <summary>
    /// The link between an Identification and an Occurrence
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationHasOcccurrence"></see></summary>
    let identificationHasOcccurrence =
        Namespaced_IRI.parse _namespace_name "identificationHasOcccurrence" |> NamespacedName

    /// <summary>
    /// The link between an Identification and Species Concept, redundant with identifiedAs
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationHasSpeciesConcept"></see></summary>
    let identificationHasSpeciesConcept =
        Namespaced_IRI.parse _namespace_name "identificationHasSpeciesConcept" |> NamespacedName

    /// <summary>
    /// Method used to identify the individual, as a URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationMethod"></see></summary>
    let identificationMethod =
        Namespaced_IRI.parse _namespace_name "identificationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationNote"></see>
    /// </summary>
    let identificationNote =
        Namespaced_IRI.parse _namespace_name "identificationNote" |> NamespacedName

    /// <summary>
    /// Links an identification to an individual
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationOfIndividual"></see></summary>
    let identificationOfIndividual =
        Namespaced_IRI.parse _namespace_name "identificationOfIndividual" |> NamespacedName

    /// <summary>
    /// Links an identification to the URI for the reference used.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationReference"></see></summary>
    let identificationReference =
        Namespaced_IRI.parse _namespace_name "identificationReference" |> NamespacedName

    /// <summary>
    /// Links an identification to the URI a human that made the identification as URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identifiedBy"></see></summary>
    let identifiedBy =
        Namespaced_IRI.parse _namespace_name "identifiedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inClass"></see>
    /// </summary>
    let inClass = Namespaced_IRI.parse _namespace_name "inClass" |> NamespacedName
    /// <summary>
    /// Links a species concept to a Catalog of Life Class in an ontology
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLClass"></see></summary>
    let inCoLClass = Namespaced_IRI.parse _namespace_name "inCoLClass" |> NamespacedName

    /// <summary>
    /// Links a species concept to a Catalog of Life Family in an ontology
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLFamily"></see></summary>
    let inCoLFamily =
        Namespaced_IRI.parse _namespace_name "inCoLFamily" |> NamespacedName

    /// <summary>
    /// Links a species concept to a Catalog of Life Kingdom in an ontology
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLKingdom"></see></summary>
    let inCoLKingdom =
        Namespaced_IRI.parse _namespace_name "inCoLKingdom" |> NamespacedName

    /// <summary>
    /// Links a species concept to a Catalog of Life Order in an ontology
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLOrder"></see></summary>
    let inCoLOrder = Namespaced_IRI.parse _namespace_name "inCoLOrder" |> NamespacedName

    /// <summary>
    /// Links a species concept to a Catalog of Life Phylum in an ontology
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLPhylum"></see></summary>
    let inCoLPhylum =
        Namespaced_IRI.parse _namespace_name "inCoLPhylum" |> NamespacedName

    /// <summary>
    /// Links a species concept to a clade in the DBpedia ontology
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#inDBpediaClade"></see></summary>
    let inDBpediaClade =
        Namespaced_IRI.parse _namespace_name "inDBpediaClade" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inFamily"></see>
    /// </summary>
    let inFamily = Namespaced_IRI.parse _namespace_name "inFamily" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inGenus"></see>
    /// </summary>
    let inGenus = Namespaced_IRI.parse _namespace_name "inGenus" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inInfraclass"></see>
    /// </summary>
    let inInfraclass =
        Namespaced_IRI.parse _namespace_name "inInfraclass" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inKingdom"></see>
    /// </summary>
    let inKingdom = Namespaced_IRI.parse _namespace_name "inKingdom" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inOrder"></see>
    /// </summary>
    let inOrder = Namespaced_IRI.parse _namespace_name "inOrder" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inPhylum"></see>
    /// </summary>
    let inPhylum = Namespaced_IRI.parse _namespace_name "inPhylum" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inSubclass"></see>
    /// </summary>
    let inSubclass = Namespaced_IRI.parse _namespace_name "inSubclass" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inSubfamily"></see>
    /// </summary>
    let inSubfamily =
        Namespaced_IRI.parse _namespace_name "inSubfamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inSuborder"></see>
    /// </summary>
    let inSuborder = Namespaced_IRI.parse _namespace_name "inSuborder" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inSuperfamily"></see>
    /// </summary>
    let inSuperfamily =
        Namespaced_IRI.parse _namespace_name "inSuperfamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inSuperorder"></see>
    /// </summary>
    let inSuperorder =
        Namespaced_IRI.parse _namespace_name "inSuperorder" |> NamespacedName

    /// <summary>
    /// Links an individual to the most appropriate identification. Should be one.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasCurrrentIdentificationAssertion"></see></summary>
    let individualHasCurrrentIdentificationAssertion =
        Namespaced_IRI.parse _namespace_name "individualHasCurrrentIdentificationAssertion" |> NamespacedName

    /// <summary>
    /// Links an individual to an Area
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasObservedArea"></see></summary>
    let individualHasObservedArea =
        Namespaced_IRI.parse _namespace_name "individualHasObservedArea" |> NamespacedName

    /// <summary>
    /// Links an individual to an Occurrence, correct
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasOccurrence"></see></summary>
    let individualHasOccurrence =
        Namespaced_IRI.parse _namespace_name "individualHasOccurrence" |> NamespacedName

    /// <summary>
    /// Links an individual to the most appropriate identification. Zero to many
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasPreviousIdentificationAssertion"></see></summary>
    let individualHasPreviousIdentificationAssertion =
        Namespaced_IRI.parse _namespace_name "individualHasPreviousIdentificationAssertion" |> NamespacedName

    /// <summary>
    /// Links an individual a Species Concept
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasSpeciesConcept"></see></summary>
    let individualHasSpeciesConcept =
        Namespaced_IRI.parse _namespace_name "individualHasSpeciesConcept" |> NamespacedName

    /// <summary>
    /// Links from an individual to a controlled vocabulary of URI's for the current status of that individual
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualStatus"></see></summary>
    let individualStatus =
        Namespaced_IRI.parse _namespace_name "individualStatus" |> NamespacedName

    /// <summary>
    /// Intended to link an individual to a image. Should be subproperty of foaf:depiction
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualhasImage"></see></summary>
    let individualhasImage =
        Namespaced_IRI.parse _namespace_name "individualhasImage" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#infraspecificEpithet"></see>
    /// </summary>
    let infraspecificEpithet =
        Namespaced_IRI.parse _namespace_name "infraspecificEpithet" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#institutionCode"></see>
    /// </summary>
    let institutionCode =
        Namespaced_IRI.parse _namespace_name "institutionCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#isBioimagesPageOf"></see>
    /// </summary>
    let isBioimagesPageOf =
        Namespaced_IRI.parse _namespace_name "isBioimagesPageOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#isBugGuidePageOf"></see>
    /// </summary>
    let isBugGuidePageOf =
        Namespaced_IRI.parse _namespace_name "isBugGuidePageOf" |> NamespacedName

    /// <summary>
    /// The range is a page on the Encyclopedia of Life site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#isEOLPageOf"></see></summary>
    let isEOLPageOf =
        Namespaced_IRI.parse _namespace_name "isEOLPageOf" |> NamespacedName

    /// <summary>
    /// This is to link between a taxon-like entity and a geographical area. The doman and range are left blank so this can be used with different kinds of geographic vocabularies and different kinds of taxon concept vocabularies. It should not be used to indicate that a particular individual organism is expecten in a geographical area, but to indicate that the species etc. is expected in a particular geographical area. For instance, it would be used to indicate that a species is expected in a particular state or province. The use should approximate assertions similar to what one might find in a state or country checklist.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#isExpectedIn"></see></summary>
    let isExpectedIn =
        Namespaced_IRI.parse _namespace_name "isExpectedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#isTaxonNameID_Of"></see>
    /// </summary>
    let isTaxonNameID_Of =
        Namespaced_IRI.parse _namespace_name "isTaxonNameID_Of" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#isWikipediaArticleOf"></see>
    /// </summary>
    let isWikipediaArticleOf =
        Namespaced_IRI.parse _namespace_name "isWikipediaArticleOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#isWikispeciesArticleOf"></see>
    /// </summary>
    let isWikispeciesArticleOf =
        Namespaced_IRI.parse _namespace_name "isWikispeciesArticleOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#kingdom"></see>
    /// </summary>
    let kingdom = Namespaced_IRI.parse _namespace_name "kingdom" |> NamespacedName

    /// <summary>
    /// The URI to the Last Author
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#lastAuthorID"></see></summary>
    let lastAuthorID =
        Namespaced_IRI.parse _namespace_name "lastAuthorID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#localityText"></see>
    /// </summary>
    let localityText =
        Namespaced_IRI.parse _namespace_name "localityText" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#locationName"></see>
    /// </summary>
    let locationName =
        Namespaced_IRI.parse _namespace_name "locationName" |> NamespacedName

    /// <summary>
    /// The year that a name was published
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#nameYear"></see></summary>
    let nameYear = Namespaced_IRI.parse _namespace_name "nameYear" |> NamespacedName
    /// <summary>
    /// Inverse of The year that a name was published
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#nameYearOf"></see></summary>
    let nameYearOf = Namespaced_IRI.parse _namespace_name "nameYearOf" |> NamespacedName
    /// <summary>
    /// Links to the most appropriate NCBI Genus
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#ncbiGenus"></see></summary>
    let ncbiGenus = Namespaced_IRI.parse _namespace_name "ncbiGenus" |> NamespacedName

    /// <summary>
    /// Links to the most appropriate NCBI Species
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#ncbiSpecies"></see></summary>
    let ncbiSpecies =
        Namespaced_IRI.parse _namespace_name "ncbiSpecies" |> NamespacedName

    /// <summary>
    /// Links an occurrence to an area
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasArea"></see></summary>
    let occurrenceHasArea =
        Namespaced_IRI.parse _namespace_name "occurrenceHasArea" |> NamespacedName

    /// <summary>
    /// Links an occurrence to an individual
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasIndividual"></see></summary>
    let occurrenceHasIndividual =
        Namespaced_IRI.parse _namespace_name "occurrenceHasIndividual" |> NamespacedName

    /// <summary>
    /// The image of the occurrence label on a specimen
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasLabelImage"></see></summary>
    let occurrenceHasLabelImage =
        Namespaced_IRI.parse _namespace_name "occurrenceHasLabelImage" |> NamespacedName

    /// <summary>
    /// Links an occurrence to a species concept
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasSpeciesConcept"></see></summary>
    let occurrenceHasSpeciesConcept =
        Namespaced_IRI.parse _namespace_name "occurrenceHasSpeciesConcept" |> NamespacedName

    /// <summary>
    /// Links an Occurrence to Geonames Continent URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInContinent"></see></summary>
    let occurrenceInContinent =
        Namespaced_IRI.parse _namespace_name "occurrenceInContinent" |> NamespacedName

    /// <summary>
    /// Links an Occurrence to Geonames County URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInCounty"></see></summary>
    let occurrenceInCounty =
        Namespaced_IRI.parse _namespace_name "occurrenceInCounty" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInFeature"></see>
    /// </summary>
    let occurrenceInFeature =
        Namespaced_IRI.parse _namespace_name "occurrenceInFeature" |> NamespacedName

    /// <summary>
    /// Links an Occurrence to Geonames StateProvince URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInStateProvince"></see></summary>
    let occurrenceInStateProvince =
        Namespaced_IRI.parse _namespace_name "occurrenceInStateProvince" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#order"></see>
    /// </summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#originalName"></see>
    /// </summary>
    let originalName =
        Namespaced_IRI.parse _namespace_name "originalName" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#originalNameID_Of"></see>
    /// </summary>
    let originalNameID_Of =
        Namespaced_IRI.parse _namespace_name "originalNameID_Of" |> NamespacedName

    /// <summary>
    /// The URI to the Orthochresonym Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#orthochresonymID"></see></summary>
    let orthochresonymID =
        Namespaced_IRI.parse _namespace_name "orthochresonymID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#phylum"></see>
    /// </summary>
    let phylum = Namespaced_IRI.parse _namespace_name "phylum" |> NamespacedName
    /// <summary>
    /// The year that document was pub
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#pubYearOf"></see></summary>
    let pubYearOf = Namespaced_IRI.parse _namespace_name "pubYearOf" |> NamespacedName
    /// <summary>
    /// The year that document was pub
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#yearPub"></see></summary>
    let yearPub = Namespaced_IRI.parse _namespace_name "yearPub" |> NamespacedName
    /// <summary>
    /// The radius in meters from a particular latitude, longitude point from within which a thing was observed or collected.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#radius"></see></summary>
    let radius = Namespaced_IRI.parse _namespace_name "radius" |> NamespacedName

    /// <summary>
    /// Links an Occurrence to a standard vocabulary of sampling protocols as URI's
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#samplingProtocol"></see></summary>
    let samplingProtocol =
        Namespaced_IRI.parse _namespace_name "samplingProtocol" |> NamespacedName

    /// <summary>
    /// The author and year of the species description publication i.e (Baker, 1899)
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#scientificNameAuthorship"></see></summary>
    let scientificNameAuthorship =
        Namespaced_IRI.parse _namespace_name "scientificNameAuthorship" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#scientificNameWithAuthor"></see>
    /// </summary>
    let scientificNameWithAuthor =
        Namespaced_IRI.parse _namespace_name "scientificNameWithAuthor" |> NamespacedName

    /// <summary>
    /// Links an original description to a species type specimen
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#sodHasTypeSpecimen"></see></summary>
    let sodHasTypeSpecimen =
        Namespaced_IRI.parse _namespace_name "sodHasTypeSpecimen" |> NamespacedName

    /// <summary>
    /// Links specimen to an original species description
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#typeSpecimenHasSod"></see></summary>
    let typeSpecimenHasSod =
        Namespaced_IRI.parse _namespace_name "typeSpecimenHasSod" |> NamespacedName

    /// <summary>
    /// This describes the theoretical models behind the species concept. All species concepts are at least based on an Objective Model. In addition the may also be based on a Biological Species Model and or a Phylogenetic Species Model. A species concept could be based on all three of these. This is to reflect that there are several criteria used to support a species concept. It also allows one to create a species concept for the domestic cat that is separate from its wild relative. If one followed a strict phylogentic species model, than the domestic cat would be considered to be a subclass of the species Felis sylvestris. This would result in observations or references about the domestic cat being interpreted as observations or references of the African Wildcat Felis sylvestris.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptBasedOn"></see></summary>
    let speciesConceptBasedOn =
        Namespaced_IRI.parse _namespace_name "speciesConceptBasedOn" |> NamespacedName

    /// <summary>
    /// Links a species to an area. Should be speciesConcept?
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptHasObservedArea"></see></summary>
    let speciesConceptHasObservedArea =
        Namespaced_IRI.parse _namespace_name "speciesConceptHasObservedArea" |> NamespacedName

    /// <summary>
    /// Links a species to an occurrence. Should be speciesConcept?
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptHasOcccurrence"></see></summary>
    let speciesConceptHasOcccurrence =
        Namespaced_IRI.parse _namespace_name "speciesConceptHasOcccurrence" |> NamespacedName

    /// <summary>
    /// Links a species concept to a varitype specimen
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConcepthasVaritypeSpecimen"></see></summary>
    let speciesConcepthasVaritypeSpecimen =
        Namespaced_IRI.parse _namespace_name "speciesConcepthasVaritypeSpecimen" |> NamespacedName

    /// <summary>
    /// Links a varitype specimen to a  species concept
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#varitypeSpecimenHasSpeciesConcept"></see></summary>
    let varitypeSpecimenHasSpeciesConcept =
        Namespaced_IRI.parse _namespace_name "varitypeSpecimenHasSpeciesConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#specificEpithet"></see>
    /// </summary>
    let specificEpithet =
        Namespaced_IRI.parse _namespace_name "specificEpithet" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#startDate"></see>
    /// </summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#stateProvince"></see>
    /// </summary>
    let stateProvince =
        Namespaced_IRI.parse _namespace_name "stateProvince" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#surrogateName"></see>
    /// </summary>
    let surrogateName =
        Namespaced_IRI.parse _namespace_name "surrogateName" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#synonymName"></see>
    /// </summary>
    let synonymName =
        Namespaced_IRI.parse _namespace_name "synonymName" |> NamespacedName

    /// <summary>
    /// The URI to the Taxon Name Group String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameGroupID"></see></summary>
    let taxonNameGroupID =
        Namespaced_IRI.parse _namespace_name "taxonNameGroupID" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameGroupID_Of"></see>
    /// </summary>
    let taxonNameGroupID_Of =
        Namespaced_IRI.parse _namespace_name "taxonNameGroupID_Of" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#taxonRank"></see>
    /// </summary>
    let taxonRank = Namespaced_IRI.parse _namespace_name "taxonRank" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#thumbnail"></see>
    /// </summary>
    let thumbnail = Namespaced_IRI.parse _namespace_name "thumbnail" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#thumbnailOf"></see>
    /// </summary>
    let thumbnailOf =
        Namespaced_IRI.parse _namespace_name "thumbnailOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#trinomial"></see>
    /// </summary>
    let trinomial = Namespaced_IRI.parse _namespace_name "trinomial" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotClass"></see>
    /// </summary>
    let uniprotClass =
        Namespaced_IRI.parse _namespace_name "uniprotClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotFamily"></see>
    /// </summary>
    let uniprotFamily =
        Namespaced_IRI.parse _namespace_name "uniprotFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotGenus"></see>
    /// </summary>
    let uniprotGenus =
        Namespaced_IRI.parse _namespace_name "uniprotGenus" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotKingdom"></see>
    /// </summary>
    let uniprotKingdom =
        Namespaced_IRI.parse _namespace_name "uniprotKingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotOrder"></see>
    /// </summary>
    let uniprotOrder =
        Namespaced_IRI.parse _namespace_name "uniprotOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotPhylum"></see>
    /// </summary>
    let uniprotPhylum =
        Namespaced_IRI.parse _namespace_name "uniprotPhylum" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotSpecies"></see>
    /// </summary>
    let uniprotSpecies =
        Namespaced_IRI.parse _namespace_name "uniprotSpecies" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#yearBorn"></see>
    /// </summary>
    let yearBorn = Namespaced_IRI.parse _namespace_name "yearBorn" |> NamespacedName

    /// <summary>
    /// The year that the species was originally described
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#yearDescribed"></see></summary>
    let yearDescribed =
        Namespaced_IRI.parse _namespace_name "yearDescribed" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#yearDied"></see>
    /// </summary>
    let yearDied = Namespaced_IRI.parse _namespace_name "yearDied" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#zoologyAuthorName"></see>
    /// </summary>
    let zoologyAuthorName =
        Namespaced_IRI.parse _namespace_name "zoologyAuthorName" |> NamespacedName
