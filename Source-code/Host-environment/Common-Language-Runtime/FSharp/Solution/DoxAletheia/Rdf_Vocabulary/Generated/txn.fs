namespace http.lod.taxonconcept.org.ontology.txn.owl.hash

open DoxAletheia

module txn =
    let _namespace_name = "http://lod.taxonconcept.org/ontology/txn.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_female"></see>
    /// </summary>
    let Sex_female = _prefix "Sex_female"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_hermaphrodite"></see>
    /// </summary>
    let Sex_hermaphrodite = _prefix "Sex_hermaphrodite"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_male"></see>
    /// </summary>
    let Sex_male = _prefix "Sex_male"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_undetermined"></see>
    /// </summary>
    let Sex_undetermined = _prefix "Sex_undetermined"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Sex_unknowable"></see>
    /// </summary>
    let Sex_unknowable = _prefix "Sex_unknowable"

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonConcept_Knowledge_Base_Project"></see>
    /// </summary>
    let TaxonConcept_Knowledge_Base_Project =
        _prefix "TaxonConcept_Knowledge_Base_Project"

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Area"></see>
    /// </summary>
    let Area = _prefix "Area"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#BinomialNameID"></see>
    /// </summary>
    let BinomialNameID = _prefix "BinomialNameID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificNameID"></see>
    /// </summary>
    let ScientificNameID = _prefix "ScientificNameID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#CommonNameID"></see>
    /// </summary>
    let CommonNameID = _prefix "CommonNameID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonNameID"></see>
    /// </summary>
    let TaxonNameID = _prefix "TaxonNameID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#DataObject"></see>
    /// </summary>
    let DataObject = _prefix "DataObject"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#FamilyNameID"></see>
    /// </summary>
    let FamilyNameID = _prefix "FamilyNameID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#MonomialNameID"></see>
    /// </summary>
    let MonomialNameID = _prefix "MonomialNameID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#FreshwaterHabitat"></see>
    /// </summary>
    let FreshwaterHabitat = _prefix "FreshwaterHabitat"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Habitat"></see>
    /// </summary>
    let Habitat = _prefix "Habitat"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Gallery"></see>
    /// </summary>
    let Gallery = _prefix "Gallery"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#GenusNameID"></see>
    /// </summary>
    let GenusNameID = _prefix "GenusNameID"
    /// <summary>
    /// An identification action. The identification of a specimen.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#Identification"></see></summary>
    let Identification = _prefix "Identification"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Image"></see>
    /// </summary>
    let Image = _prefix "Image"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#MapImage"></see>
    /// </summary>
    let MapImage = _prefix "MapImage"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#MarineHabitat"></see>
    /// </summary>
    let MarineHabitat = _prefix "MarineHabitat"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Occurrence"></see>
    /// </summary>
    let Occurrence = _prefix "Occurrence"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#OccurrenceSpecimenTag"></see>
    /// </summary>
    let OccurrenceSpecimenTag = _prefix "OccurrenceSpecimenTag"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#OccurrenceTaxonTag"></see>
    /// </summary>
    let OccurrenceTaxonTag = _prefix "OccurrenceTaxonTag"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#OpenCycTaxon"></see>
    /// </summary>
    let OpenCycTaxon = _prefix "OpenCycTaxon"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankClass"></see>
    /// </summary>
    let RankClass = _prefix "RankClass"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonRank"></see>
    /// </summary>
    let TaxonRank = _prefix "TaxonRank"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperclass"></see>
    /// </summary>
    let RankSuperclass = _prefix "RankSuperclass"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubclass"></see>
    /// </summary>
    let RankSubclass = _prefix "RankSubclass"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankDivision"></see>
    /// </summary>
    let RankDivision = _prefix "RankDivision"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankDomain"></see>
    /// </summary>
    let RankDomain = _prefix "RankDomain"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubdomain"></see>
    /// </summary>
    let RankSubdomain = _prefix "RankSubdomain"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankFamily"></see>
    /// </summary>
    let RankFamily = _prefix "RankFamily"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperfamily"></see>
    /// </summary>
    let RankSuperfamily = _prefix "RankSuperfamily"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubfamily"></see>
    /// </summary>
    let RankSubfamily = _prefix "RankSubfamily"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankGenus"></see>
    /// </summary>
    let RankGenus = _prefix "RankGenus"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankTribe"></see>
    /// </summary>
    let RankTribe = _prefix "RankTribe"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubgenus"></see>
    /// </summary>
    let RankSubgenus = _prefix "RankSubgenus"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankInfraclass"></see>
    /// </summary>
    let RankInfraclass = _prefix "RankInfraclass"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperorder"></see>
    /// </summary>
    let RankSuperorder = _prefix "RankSuperorder"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankInfrakingdom"></see>
    /// </summary>
    let RankInfrakingdom = _prefix "RankInfrakingdom"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubkingdom"></see>
    /// </summary>
    let RankSubkingdom = _prefix "RankSubkingdom"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperphylum"></see>
    /// </summary>
    let RankSuperphylum = _prefix "RankSuperphylum"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankInfraorder"></see>
    /// </summary>
    let RankInfraorder = _prefix "RankInfraorder"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuborder"></see>
    /// </summary>
    let RankSuborder = _prefix "RankSuborder"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankParvorder"></see>
    /// </summary>
    let RankParvorder = _prefix "RankParvorder"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankKingdom"></see>
    /// </summary>
    let RankKingdom = _prefix "RankKingdom"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperkingdom"></see>
    /// </summary>
    let RankSuperkingdom = _prefix "RankSuperkingdom"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankOrder"></see>
    /// </summary>
    let RankOrder = _prefix "RankOrder"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankPhylum"></see>
    /// </summary>
    let RankPhylum = _prefix "RankPhylum"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubphylum"></see>
    /// </summary>
    let RankSubphylum = _prefix "RankSubphylum"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSpecies"></see>
    /// </summary>
    let RankSpecies = _prefix "RankSpecies"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubpecies"></see>
    /// </summary>
    let RankSubpecies = _prefix "RankSubpecies"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubdivision"></see>
    /// </summary>
    let RankSubdivision = _prefix "RankSubdivision"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSubspecificAggregate"></see>
    /// </summary>
    let RankSubspecificAggregate = _prefix "RankSubspecificAggregate"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankSuperdivision"></see>
    /// </summary>
    let RankSuperdivision = _prefix "RankSuperdivision"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#RankVariety"></see>
    /// </summary>
    let RankVariety = _prefix "RankVariety"
    /// <summary>
    /// Someone who has authored a scientific article.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificAuthorPerson"></see></summary>
    let ScientificAuthorPerson = _prefix "ScientificAuthorPerson"
    /// <summary>
    /// Class for Scientist a foaf:Person
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#Scientist"></see></summary>
    let Scientist = _prefix "Scientist"
    /// <summary>
    /// Someone who has collected a scientific sample or specimen.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificCollectorPerson"></see></summary>
    let ScientificCollectorPerson = _prefix "ScientificCollectorPerson"
    /// <summary>
    /// Someone who has curated or entered data into a scientific data set.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificDataCuratorPerson"></see></summary>
    let ScientificDataCuratorPerson = _prefix "ScientificDataCuratorPerson"
    /// <summary>
    /// Someone who has identified a specimen.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificIdentifierPerson"></see></summary>
    let ScientificIdentifierPerson = _prefix "ScientificIdentifierPerson"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#ScientificNameWithAuthorID"></see>
    /// </summary>
    let ScientificNameWithAuthorID = _prefix "ScientificNameWithAuthorID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Sex"></see>
    /// </summary>
    let Sex = _prefix "Sex"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesConcept"></see>
    /// </summary>
    let SpeciesConcept = _prefix "SpeciesConcept"
    /// <summary>
    /// A particular taxonomic concept. Currently only species concepts are implemented, however theoretically there could be additional subclasses of GenusConcepts, FamilyConcepts etc. A SubspeciesConcept and lower are considered to be subclasses of SpeciesConcepts, but one persons subspecies is often anothers species. My current thinking is to represent individuals and observations of subspecies as individuals and observations of the larger species concept. It has yet to be implemented but I am considering recording these as observations and individuals of a given species "in the form of" their subspecies indentifier or name.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonConcept"></see></summary>
    let TaxonConcept = _prefix "TaxonConcept"
    /// <summary>
    /// A tag like entity that can be used to indicate that an image is associated with a specific species concept. Instances of SpeciesImageTag take the form of the species concept URI with the fragment of #Image rather than #Species.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesImageTag"></see></summary>
    let SpeciesImageTag = _prefix "SpeciesImageTag"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesIndividual"></see>
    /// </summary>
    let SpeciesIndividual = _prefix "SpeciesIndividual"
    /// <summary>
    /// A tag like entity that can be used to indicate that an individual organism is an associated with a particular species concept. Instances of SpeciesIndividualTag take the form of the species concept URI with the fragment of #Individual rather than #Species.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesIndividualTag"></see></summary>
    let SpeciesIndividualTag = _prefix "SpeciesIndividualTag"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesModel"></see>
    /// </summary>
    let SpeciesModel = _prefix "SpeciesModel"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesOriginalDescription"></see>
    /// </summary>
    let SpeciesOriginalDescription = _prefix "SpeciesOriginalDescription"
    /// <summary>
    /// A tag like entity for the NCBI Taxonomic Classification.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#SpeciesTaxonomyNCBI"></see></summary>
    let SpeciesTaxonomyNCBI = _prefix "SpeciesTaxonomyNCBI"
    /// <summary>
    /// A organismal specimen that is related to a specific organism, parts of an individual organism, or a collection of these from several organisms. It should be used for the smallest entity in a specimen database. Ideally there should be at least one specimen per individual organism. Specimens consisting of multiple individuals or multiple species often complicate analysis. If one photo contains multiple entities, document these as separate specimens all linked to the same photo.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#Specimen"></see></summary>
    let Specimen = _prefix "Specimen"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Status_Preliminary"></see>
    /// </summary>
    let Status_Preliminary = _prefix "Status_Preliminary"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#Status_Testing"></see>
    /// </summary>
    let Status_Testing = _prefix "Status_Testing"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#SubfamilyNameID"></see>
    /// </summary>
    let SubfamilyNameID = _prefix "SubfamilyNameID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#SurrogateNameID"></see>
    /// </summary>
    let SurrogateNameID = _prefix "SurrogateNameID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TDWG2010_BioBlitz_Project"></see>
    /// </summary>
    let TDWG2010_BioBlitz_Project = _prefix "TDWG2010_BioBlitz_Project"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonConcept_Scheme"></see>
    /// </summary>
    let TaxonConcept_Scheme = _prefix "TaxonConcept_Scheme"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonNameGroupID"></see>
    /// </summary>
    let TaxonNameGroupID = _prefix "TaxonNameGroupID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TaxonOntology"></see>
    /// </summary>
    let TaxonOntology = _prefix "TaxonOntology"
    /// <summary>
    /// Class for a Taxonomist a subclass of dbpedia-owl:Scientist
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#Taxonomist"></see></summary>
    let Taxonomist = _prefix "Taxonomist"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TerrestrialHabitat"></see>
    /// </summary>
    let TerrestrialHabitat = _prefix "TerrestrialHabitat"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#TrinomialNameID"></see>
    /// </summary>
    let TrinomialNameID = _prefix "TrinomialNameID"
    /// <summary>
    /// Class for the Concept Year
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#Year"></see></summary>
    let Year = _prefix "Year"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#acceptedName"></see>
    /// </summary>
    let acceptedName = _prefix "acceptedName"
    /// <summary>
    /// The URI to the Accepted Name String, should only be one.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#acceptedNameID"></see></summary>
    let acceptedNameID = _prefix "acceptedNameID"
    /// <summary>
    /// The URI to the Taxon Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameID"></see></summary>
    let taxonNameID = _prefix "taxonNameID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#acceptedTaxonNameID_Of"></see>
    /// </summary>
    let acceptedTaxonNameID_Of = _prefix "acceptedTaxonNameID_Of"
    /// <summary>
    /// The URI to the Taxon Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameID_Of"></see></summary>
    let taxonNameID_Of = _prefix "taxonNameID_Of"
    /// <summary>
    /// The URI to an Alternative Accepted Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#altAcceptedNameID"></see></summary>
    let altAcceptedNameID = _prefix "altAcceptedNameID"
    /// <summary>
    /// The URI to an Alternative Accepted Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#altAcceptedNameID_Of"></see></summary>
    let altAcceptedNameID_Of = _prefix "altAcceptedNameID_Of"
    /// <summary>
    /// The URI to the Original Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#originalNameID"></see></summary>
    let originalNameID = _prefix "originalNameID"
    /// <summary>
    /// Links an Area to an Individual
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#areaHasIndividual"></see></summary>
    let areaHasIndividual = _prefix "areaHasIndividual"
    /// <summary>
    /// Links an Area to a Species Concept
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#areaHasObservedSpeciesConcept"></see></summary>
    let areaHasObservedSpeciesConcept = _prefix "areaHasObservedSpeciesConcept"
    /// <summary>
    /// Links an Area to an Occurrence
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#areaHasOccurrence"></see></summary>
    let areaHasOccurrence = _prefix "areaHasOccurrence"
    /// <summary>
    /// Links an Area to Geonames County URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#areaInCounty"></see></summary>
    let areaInCounty = _prefix "areaInCounty"
    /// <summary>
    /// Links an Area to Geonames State/Province URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#areaInStateProvince"></see></summary>
    let areaInStateProvince = _prefix "areaInStateProvince"
    /// <summary>
    /// This is used to connect geo areas to geoname features
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#areaWithInFeature"></see></summary>
    let areaWithInFeature = _prefix "areaWithInFeature"
    /// <summary>
    /// The author and year of the species description publication i.e (Baker, 1899)
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#authority"></see></summary>
    let authority = _prefix "authority"
    /// <summary>
    /// Assumed to be equivalent to TDWG Basis of Record
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#basisOfRecord"></see></summary>
    let basisOfRecord = _prefix "basisOfRecord"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#behavioralNote"></see>
    /// </summary>
    let behavioralNote = _prefix "behavioralNote"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#binomial"></see>
    /// </summary>
    let binomial = _prefix "binomial"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#botanyAuthorName"></see>
    /// </summary>
    let botanyAuthorName = _prefix "botanyAuthorName"
    /// <summary>
    /// The URI ID for the canonical form of the name i.e. Puma concolor or Felidae, for name to name mapping
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#canonicalFormID"></see></summary>
    let canonicalFormID = _prefix "canonicalFormID"
    /// <summary>
    /// The URI to the Taxon Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#relatedTaxonNameID"></see></summary>
    let relatedTaxonNameID = _prefix "relatedTaxonNameID"
    /// <summary>
    /// The URI ID for the scientific name with authorship form of the name i.e. Puma concolor Linnaeus 1758, for name to name mapping
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#canonicalFormID_Of"></see></summary>
    let canonicalFormID_Of = _prefix "canonicalFormID_Of"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#catalogCode"></see>
    /// </summary>
    let catalogCode = _prefix "catalogCode"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#class"></see>
    /// </summary>
    let class_ = _prefix "class"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#scientificName"></see>
    /// </summary>
    let scientificName = _prefix "scientificName"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#collectionCode"></see>
    /// </summary>
    let collectionCode = _prefix "collectionCode"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#commonName"></see>
    /// </summary>
    let commonName = _prefix "commonName"
    /// <summary>
    /// The Links to the Status of the TaxonConcept
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#conceptStatus"></see></summary>
    let conceptStatus = _prefix "conceptStatus"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#continent"></see>
    /// </summary>
    let continent = _prefix "continent"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#country"></see>
    /// </summary>
    let country = _prefix "country"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#countryCode"></see>
    /// </summary>
    let countryCode = _prefix "countryCode"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#county"></see>
    /// </summary>
    let county = _prefix "county"
    /// <summary>
    /// This is the year of the description
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#descYear"></see></summary>
    let descYear = _prefix "descYear"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#descYearOf"></see>
    /// </summary>
    let descYearOf = _prefix "descYearOf"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#endDate"></see>
    /// </summary>
    let endDate = _prefix "endDate"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#family"></see>
    /// </summary>
    let family = _prefix "family"
    /// <summary>
    /// This is used to link a geonames feature to a geo area. For example geo:44.86528100,-87.23147800;u=10
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#featureContainsArea"></see></summary>
    let featureContainsArea = _prefix "featureContainsArea"
    /// <summary>
    /// The URI to the First Author
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#firstAuthorID"></see></summary>
    let firstAuthorID = _prefix "firstAuthorID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#genus"></see>
    /// </summary>
    let genus = _prefix "genus"
    /// <summary>
    /// The method used to determine the latitude, longitude as a URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#georeferenceProtocol"></see></summary>
    let georeferenceProtocol = _prefix "georeferenceProtocol"
    /// <summary>
    /// Was this location verified, controlled choices URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#georeferenceVerificationStatus"></see></summary>
    let georeferenceVerificationStatus = _prefix "georeferenceVerificationStatus"
    /// <summary>
    /// associates a taxon with a habitat in which it may typically be found
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#habitat"></see></summary>
    let habitat = _prefix "habitat"
    /// <summary>
    /// The range is a page on the Animal Diversity Web site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasADWPage"></see></summary>
    let hasADWPage = _prefix "hasADWPage"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasAcceptedName"></see>
    /// </summary>
    let hasAcceptedName = _prefix "hasAcceptedName"
    /// <summary>
    /// The range is a page on the BBC site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasBBCPage"></see></summary>
    let hasBBCPage = _prefix "hasBBCPage"
    /// <summary>
    /// The Barcode of Life Integer ID
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasBOLD"></see></summary>
    let hasBOLD = _prefix "hasBOLD"
    /// <summary>
    /// A page at boldsystems.org
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasBOLDPage"></see></summary>
    let hasBOLDPage = _prefix "hasBOLDPage"
    /// <summary>
    /// The range is a page on the Bioimages site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasBioimagesPage"></see></summary>
    let hasBioimagesPage = _prefix "hasBioimagesPage"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasBugGuidePage"></see>
    /// </summary>
    let hasBugGuidePage = _prefix "hasBugGuidePage"
    /// <summary>
    /// The range is a uniprot pubmed uri for example http://purl.uniprot.org/pubmed/1083304
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasCitation"></see></summary>
    let hasCitation = _prefix "hasCitation"
    /// <summary>
    /// The occurrence observer or specimen collector, hasCollector?
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasCollector"></see></summary>
    let hasCollector = _prefix "hasCollector"
    /// <summary>
    /// The range is a page on the DiscoverLife.org site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasDLPage"></see></summary>
    let hasDLPage = _prefix "hasDLPage"
    /// <summary>
    /// The range is a page on the Discover Life Web site.
    /// The range is a page on the http://www.discoverlife.org/ site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasDiscoverLifePage"></see></summary>
    let hasDiscoverLifePage = _prefix "hasDiscoverLifePage"
    /// <summary>
    /// The Encyclopedia of Life Integer ID
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasEOL"></see></summary>
    let hasEOL = _prefix "hasEOL"
    /// <summary>
    /// The range is a page on the Encyclopedia of Life site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasEOLPage"></see></summary>
    let hasEOLPage = _prefix "hasEOLPage"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasEUNISPage"></see>
    /// </summary>
    let hasEUNISPage = _prefix "hasEUNISPage"
    /// <summary>
    /// eBird Species Code
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasEbird"></see></summary>
    let hasEbird = _prefix "hasEbird"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasEtypePage"></see>
    /// </summary>
    let hasEtypePage = _prefix "hasEtypePage"
    /// <summary>
    /// This is to link between a geographical area and a taxon-like entity. The doman and range are left blank so this can be used with different kinds of geographic vocabularies and different kinds of taxon concept vocabularies. It should not be used to indicate that a location has the expectation of a specific individual specimen, but to indicate that the location has an expectation of a specific class of organisms. For instance, it would be used to indicate that a geographic location has an expectation of a particular species. The use should approximate assertions similar to what one might find in a state or country checklist.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasExpectationOf"></see></summary>
    let hasExpectationOf = _prefix "hasExpectationOf"
    /// <summary>
    /// The Global Biodiversity Information Facility integer ID
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasGBIF"></see></summary>
    let hasGBIF = _prefix "hasGBIF"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasGBIFMap"></see>
    /// </summary>
    let hasGBIFMap = _prefix "hasGBIFMap"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasMapImage"></see>
    /// </summary>
    let hasMapImage = _prefix "hasMapImage"
    /// <summary>
    /// A page at GBIF.org
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasGBIFPage"></see></summary>
    let hasGBIFPage = _prefix "hasGBIFPage"
    /// <summary>
    /// The ITIS ID
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasITIS"></see></summary>
    let hasITIS = _prefix "hasITIS"
    /// <summary>
    /// The range is a page on the ITIS.gov site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasITISPage"></see></summary>
    let hasITISPage = _prefix "hasITISPage"
    /// <summary>
    /// Superproperty of all the links to images
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasImage"></see></summary>
    let hasImage = _prefix "hasImage"
    /// <summary>
    /// The NCBI Taxonomy ID
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasNCBI"></see></summary>
    let hasNCBI = _prefix "hasNCBI"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasOriginalName"></see>
    /// </summary>
    let hasOriginalName = _prefix "hasOriginalName"
    /// <summary>
    /// This is for a string urn type identifier
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasSpeciesConceptID"></see></summary>
    let hasSpeciesConceptID = _prefix "hasSpeciesConceptID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasUSDAPlantsPage"></see>
    /// </summary>
    let hasUSDAPlantsPage = _prefix "hasUSDAPlantsPage"
    /// <summary>
    /// This is to link between a geographical area and a taxon-like entity. Where the association is not known. The doman and range are left blank so this can be used with different kinds of geographic vocabularies and different kinds of taxon concept vocabularies. It should not be used to indicate that a location has the expectation of a specific individual specimen, but to indicate that the location has an expectation of a specific class of organisms. For instance, it would be used to indicate that a geographic location has an expectation of a particular species. The use should approximate assertions similar to what one might find in a state or country checklist.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasUnknownExpectationOf"></see></summary>
    let hasUnknownExpectationOf = _prefix "hasUnknownExpectationOf"
    /// <summary>
    /// Links a species concept to a Geonames URI where the relationship is unknown
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#isUnknownAboutIn"></see></summary>
    let isUnknownAboutIn = _prefix "isUnknownAboutIn"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasWikipediaArticle"></see>
    /// </summary>
    let hasWikipediaArticle = _prefix "hasWikipediaArticle"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasWikipediaMap"></see>
    /// </summary>
    let hasWikipediaMap = _prefix "hasWikipediaMap"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasWikispeciesArticle"></see>
    /// </summary>
    let hasWikispeciesArticle = _prefix "hasWikispeciesArticle"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hasWildObsPage"></see>
    /// </summary>
    let hasWildObsPage = _prefix "hasWildObsPage"
    /// <summary>
    /// The URI to the Heterochresonym Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#heterochresonymID"></see></summary>
    let heterochresonymID = _prefix "heterochresonymID"
    /// <summary>
    /// The URI to a synonymID of the TaxonNameID
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#synonymID"></see></summary>
    let synonymID = _prefix "synonymID"
    /// <summary>
    /// The URI to the HeterotypicName Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#heterotypicNameID"></see></summary>
    let heterotypicNameID = _prefix "heterotypicNameID"
    /// <summary>
    /// The URI to the HomotypicName Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#homotypicNameID"></see></summary>
    let homotypicNameID = _prefix "homotypicNameID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#hybrid"></see>
    /// </summary>
    let hybrid = _prefix "hybrid"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationDate"></see>
    /// </summary>
    let identificationDate = _prefix "identificationDate"
    /// <summary>
    /// The image of the identification label on a specimen
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationHasLabelImage"></see></summary>
    let identificationHasLabelImage = _prefix "identificationHasLabelImage"
    /// <summary>
    /// The link between an Identification and an Occurrence
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationHasOcccurrence"></see></summary>
    let identificationHasOcccurrence = _prefix "identificationHasOcccurrence"
    /// <summary>
    /// The link between an Identification and Species Concept, redundant with identifiedAs
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationHasSpeciesConcept"></see></summary>
    let identificationHasSpeciesConcept = _prefix "identificationHasSpeciesConcept"
    /// <summary>
    /// Method used to identify the individual, as a URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationMethod"></see></summary>
    let identificationMethod = _prefix "identificationMethod"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationNote"></see>
    /// </summary>
    let identificationNote = _prefix "identificationNote"
    /// <summary>
    /// Links an identification to an individual
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationOfIndividual"></see></summary>
    let identificationOfIndividual = _prefix "identificationOfIndividual"
    /// <summary>
    /// Links an identification to the URI for the reference used.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identificationReference"></see></summary>
    let identificationReference = _prefix "identificationReference"
    /// <summary>
    /// Links an identification to the URI a human that made the identification as URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#identifiedBy"></see></summary>
    let identifiedBy = _prefix "identifiedBy"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inClass"></see>
    /// </summary>
    let inClass = _prefix "inClass"
    /// <summary>
    /// Links a species concept to a Catalog of Life Class in an ontology
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLClass"></see></summary>
    let inCoLClass = _prefix "inCoLClass"
    /// <summary>
    /// Links a species concept to a Catalog of Life Family in an ontology
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLFamily"></see></summary>
    let inCoLFamily = _prefix "inCoLFamily"
    /// <summary>
    /// Links a species concept to a Catalog of Life Kingdom in an ontology
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLKingdom"></see></summary>
    let inCoLKingdom = _prefix "inCoLKingdom"
    /// <summary>
    /// Links a species concept to a Catalog of Life Order in an ontology
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLOrder"></see></summary>
    let inCoLOrder = _prefix "inCoLOrder"
    /// <summary>
    /// Links a species concept to a Catalog of Life Phylum in an ontology
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#inCoLPhylum"></see></summary>
    let inCoLPhylum = _prefix "inCoLPhylum"
    /// <summary>
    /// Links a species concept to a clade in the DBpedia ontology
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#inDBpediaClade"></see></summary>
    let inDBpediaClade = _prefix "inDBpediaClade"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inFamily"></see>
    /// </summary>
    let inFamily = _prefix "inFamily"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inGenus"></see>
    /// </summary>
    let inGenus = _prefix "inGenus"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inInfraclass"></see>
    /// </summary>
    let inInfraclass = _prefix "inInfraclass"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inKingdom"></see>
    /// </summary>
    let inKingdom = _prefix "inKingdom"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inOrder"></see>
    /// </summary>
    let inOrder = _prefix "inOrder"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inPhylum"></see>
    /// </summary>
    let inPhylum = _prefix "inPhylum"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inSubclass"></see>
    /// </summary>
    let inSubclass = _prefix "inSubclass"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inSubfamily"></see>
    /// </summary>
    let inSubfamily = _prefix "inSubfamily"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inSuborder"></see>
    /// </summary>
    let inSuborder = _prefix "inSuborder"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inSuperfamily"></see>
    /// </summary>
    let inSuperfamily = _prefix "inSuperfamily"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#inSuperorder"></see>
    /// </summary>
    let inSuperorder = _prefix "inSuperorder"

    /// <summary>
    /// Links an individual to the most appropriate identification. Should be one.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasCurrrentIdentificationAssertion"></see></summary>
    let individualHasCurrrentIdentificationAssertion =
        _prefix "individualHasCurrrentIdentificationAssertion"

    /// <summary>
    /// Links an individual to an Area
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasObservedArea"></see></summary>
    let individualHasObservedArea = _prefix "individualHasObservedArea"
    /// <summary>
    /// Links an individual to an Occurrence, correct
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasOccurrence"></see></summary>
    let individualHasOccurrence = _prefix "individualHasOccurrence"

    /// <summary>
    /// Links an individual to the most appropriate identification. Zero to many
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasPreviousIdentificationAssertion"></see></summary>
    let individualHasPreviousIdentificationAssertion =
        _prefix "individualHasPreviousIdentificationAssertion"

    /// <summary>
    /// Links an individual a Species Concept
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualHasSpeciesConcept"></see></summary>
    let individualHasSpeciesConcept = _prefix "individualHasSpeciesConcept"
    /// <summary>
    /// Links from an individual to a controlled vocabulary of URI's for the current status of that individual
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualStatus"></see></summary>
    let individualStatus = _prefix "individualStatus"
    /// <summary>
    /// Intended to link an individual to a image. Should be subproperty of foaf:depiction
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#individualhasImage"></see></summary>
    let individualhasImage = _prefix "individualhasImage"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#infraspecificEpithet"></see>
    /// </summary>
    let infraspecificEpithet = _prefix "infraspecificEpithet"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#institutionCode"></see>
    /// </summary>
    let institutionCode = _prefix "institutionCode"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#isBioimagesPageOf"></see>
    /// </summary>
    let isBioimagesPageOf = _prefix "isBioimagesPageOf"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#isBugGuidePageOf"></see>
    /// </summary>
    let isBugGuidePageOf = _prefix "isBugGuidePageOf"
    /// <summary>
    /// The range is a page on the Encyclopedia of Life site.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#isEOLPageOf"></see></summary>
    let isEOLPageOf = _prefix "isEOLPageOf"
    /// <summary>
    /// This is to link between a taxon-like entity and a geographical area. The doman and range are left blank so this can be used with different kinds of geographic vocabularies and different kinds of taxon concept vocabularies. It should not be used to indicate that a particular individual organism is expecten in a geographical area, but to indicate that the species etc. is expected in a particular geographical area. For instance, it would be used to indicate that a species is expected in a particular state or province. The use should approximate assertions similar to what one might find in a state or country checklist.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#isExpectedIn"></see></summary>
    let isExpectedIn = _prefix "isExpectedIn"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#isTaxonNameID_Of"></see>
    /// </summary>
    let isTaxonNameID_Of = _prefix "isTaxonNameID_Of"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#isWikipediaArticleOf"></see>
    /// </summary>
    let isWikipediaArticleOf = _prefix "isWikipediaArticleOf"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#isWikispeciesArticleOf"></see>
    /// </summary>
    let isWikispeciesArticleOf = _prefix "isWikispeciesArticleOf"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#kingdom"></see>
    /// </summary>
    let kingdom = _prefix "kingdom"
    /// <summary>
    /// The URI to the Last Author
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#lastAuthorID"></see></summary>
    let lastAuthorID = _prefix "lastAuthorID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#localityText"></see>
    /// </summary>
    let localityText = _prefix "localityText"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#locationName"></see>
    /// </summary>
    let locationName = _prefix "locationName"
    /// <summary>
    /// The year that a name was published
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#nameYear"></see></summary>
    let nameYear = _prefix "nameYear"
    /// <summary>
    /// Inverse of The year that a name was published
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#nameYearOf"></see></summary>
    let nameYearOf = _prefix "nameYearOf"
    /// <summary>
    /// Links to the most appropriate NCBI Genus
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#ncbiGenus"></see></summary>
    let ncbiGenus = _prefix "ncbiGenus"
    /// <summary>
    /// Links to the most appropriate NCBI Species
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#ncbiSpecies"></see></summary>
    let ncbiSpecies = _prefix "ncbiSpecies"
    /// <summary>
    /// Links an occurrence to an area
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasArea"></see></summary>
    let occurrenceHasArea = _prefix "occurrenceHasArea"
    /// <summary>
    /// Links an occurrence to an individual
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasIndividual"></see></summary>
    let occurrenceHasIndividual = _prefix "occurrenceHasIndividual"
    /// <summary>
    /// The image of the occurrence label on a specimen
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasLabelImage"></see></summary>
    let occurrenceHasLabelImage = _prefix "occurrenceHasLabelImage"
    /// <summary>
    /// Links an occurrence to a species concept
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceHasSpeciesConcept"></see></summary>
    let occurrenceHasSpeciesConcept = _prefix "occurrenceHasSpeciesConcept"
    /// <summary>
    /// Links an Occurrence to Geonames Continent URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInContinent"></see></summary>
    let occurrenceInContinent = _prefix "occurrenceInContinent"
    /// <summary>
    /// Links an Occurrence to Geonames County URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInCounty"></see></summary>
    let occurrenceInCounty = _prefix "occurrenceInCounty"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInFeature"></see>
    /// </summary>
    let occurrenceInFeature = _prefix "occurrenceInFeature"
    /// <summary>
    /// Links an Occurrence to Geonames StateProvince URI
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#occurrenceInStateProvince"></see></summary>
    let occurrenceInStateProvince = _prefix "occurrenceInStateProvince"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#order"></see>
    /// </summary>
    let order = _prefix "order"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#originalName"></see>
    /// </summary>
    let originalName = _prefix "originalName"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#originalNameID_Of"></see>
    /// </summary>
    let originalNameID_Of = _prefix "originalNameID_Of"
    /// <summary>
    /// The URI to the Orthochresonym Name String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#orthochresonymID"></see></summary>
    let orthochresonymID = _prefix "orthochresonymID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#phylum"></see>
    /// </summary>
    let phylum = _prefix "phylum"
    /// <summary>
    /// The year that document was pub
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#pubYearOf"></see></summary>
    let pubYearOf = _prefix "pubYearOf"
    /// <summary>
    /// The year that document was pub
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#yearPub"></see></summary>
    let yearPub = _prefix "yearPub"
    /// <summary>
    /// The radius in meters from a particular latitude, longitude point from within which a thing was observed or collected.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#radius"></see></summary>
    let radius = _prefix "radius"
    /// <summary>
    /// Links an Occurrence to a standard vocabulary of sampling protocols as URI's
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#samplingProtocol"></see></summary>
    let samplingProtocol = _prefix "samplingProtocol"
    /// <summary>
    /// The author and year of the species description publication i.e (Baker, 1899)
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#scientificNameAuthorship"></see></summary>
    let scientificNameAuthorship = _prefix "scientificNameAuthorship"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#scientificNameWithAuthor"></see>
    /// </summary>
    let scientificNameWithAuthor = _prefix "scientificNameWithAuthor"
    /// <summary>
    /// Links an original description to a species type specimen
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#sodHasTypeSpecimen"></see></summary>
    let sodHasTypeSpecimen = _prefix "sodHasTypeSpecimen"
    /// <summary>
    /// Links specimen to an original species description
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#typeSpecimenHasSod"></see></summary>
    let typeSpecimenHasSod = _prefix "typeSpecimenHasSod"
    /// <summary>
    /// This describes the theoretical models behind the species concept. All species concepts are at least based on an Objective Model. In addition the may also be based on a Biological Species Model and or a Phylogenetic Species Model. A species concept could be based on all three of these. This is to reflect that there are several criteria used to support a species concept. It also allows one to create a species concept for the domestic cat that is separate from its wild relative. If one followed a strict phylogentic species model, than the domestic cat would be considered to be a subclass of the species Felis sylvestris. This would result in observations or references about the domestic cat being interpreted as observations or references of the African Wildcat Felis sylvestris.
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptBasedOn"></see></summary>
    let speciesConceptBasedOn = _prefix "speciesConceptBasedOn"
    /// <summary>
    /// Links a species to an area. Should be speciesConcept?
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptHasObservedArea"></see></summary>
    let speciesConceptHasObservedArea = _prefix "speciesConceptHasObservedArea"
    /// <summary>
    /// Links a species to an occurrence. Should be speciesConcept?
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConceptHasOcccurrence"></see></summary>
    let speciesConceptHasOcccurrence = _prefix "speciesConceptHasOcccurrence"
    /// <summary>
    /// Links a species concept to a varitype specimen
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#speciesConcepthasVaritypeSpecimen"></see></summary>
    let speciesConcepthasVaritypeSpecimen = _prefix "speciesConcepthasVaritypeSpecimen"
    /// <summary>
    /// Links a varitype specimen to a  species concept
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#varitypeSpecimenHasSpeciesConcept"></see></summary>
    let varitypeSpecimenHasSpeciesConcept = _prefix "varitypeSpecimenHasSpeciesConcept"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#specificEpithet"></see>
    /// </summary>
    let specificEpithet = _prefix "specificEpithet"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#startDate"></see>
    /// </summary>
    let startDate = _prefix "startDate"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#stateProvince"></see>
    /// </summary>
    let stateProvince = _prefix "stateProvince"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#surrogateName"></see>
    /// </summary>
    let surrogateName = _prefix "surrogateName"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#synonymName"></see>
    /// </summary>
    let synonymName = _prefix "synonymName"
    /// <summary>
    /// The URI to the Taxon Name Group String
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameGroupID"></see></summary>
    let taxonNameGroupID = _prefix "taxonNameGroupID"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#taxonNameGroupID_Of"></see>
    /// </summary>
    let taxonNameGroupID_Of = _prefix "taxonNameGroupID_Of"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#taxonRank"></see>
    /// </summary>
    let taxonRank = _prefix "taxonRank"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#thumbnail"></see>
    /// </summary>
    let thumbnail = _prefix "thumbnail"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#thumbnailOf"></see>
    /// </summary>
    let thumbnailOf = _prefix "thumbnailOf"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#trinomial"></see>
    /// </summary>
    let trinomial = _prefix "trinomial"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotClass"></see>
    /// </summary>
    let uniprotClass = _prefix "uniprotClass"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotFamily"></see>
    /// </summary>
    let uniprotFamily = _prefix "uniprotFamily"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotGenus"></see>
    /// </summary>
    let uniprotGenus = _prefix "uniprotGenus"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotKingdom"></see>
    /// </summary>
    let uniprotKingdom = _prefix "uniprotKingdom"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotOrder"></see>
    /// </summary>
    let uniprotOrder = _prefix "uniprotOrder"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotPhylum"></see>
    /// </summary>
    let uniprotPhylum = _prefix "uniprotPhylum"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#uniprotSpecies"></see>
    /// </summary>
    let uniprotSpecies = _prefix "uniprotSpecies"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#yearBorn"></see>
    /// </summary>
    let yearBorn = _prefix "yearBorn"
    /// <summary>
    /// The year that the species was originally described
    /// <see href="http://lod.taxonconcept.org/ontology/txn.owl#yearDescribed"></see></summary>
    let yearDescribed = _prefix "yearDescribed"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#yearDied"></see>
    /// </summary>
    let yearDied = _prefix "yearDied"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/txn.owl#zoologyAuthorName"></see>
    /// </summary>
    let zoologyAuthorName = _prefix "zoologyAuthorName"
