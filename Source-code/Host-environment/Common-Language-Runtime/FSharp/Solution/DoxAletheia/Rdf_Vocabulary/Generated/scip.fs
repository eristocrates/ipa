namespace http.lod.taxonconcept.org.ontology.sci_people.owl.hash

open DoxAletheia

module scip =
    let _namespace_name = "http://lod.taxonconcept.org/ontology/sci_people.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#PersonPublicationListHTML"></see>
    /// </summary>
    let PersonPublicationListHTML = _prefix "PersonPublicationListHTML"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#PersonPublicationListRDF"></see>
    /// </summary>
    let PersonPublicationListRDF = _prefix "PersonPublicationListRDF"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#ScientificMethod"></see>
    /// </summary>
    let ScientificMethod = _prefix "ScientificMethod"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#citationUse"></see>
    /// </summary>
    let citationUse = _prefix "citationUse"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthor"></see>
    /// </summary>
    let hasAuthor = _prefix "hasAuthor"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthored"></see>
    /// </summary>
    let hasAuthored = _prefix "hasAuthored"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredArticle"></see>
    /// </summary>
    let hasAuthoredArticle = _prefix "hasAuthoredArticle"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredBinomialName"></see>
    /// </summary>
    let hasAuthoredBinomialName = _prefix "hasAuthoredBinomialName"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredScientificName"></see>
    /// </summary>
    let hasAuthoredScientificName = _prefix "hasAuthoredScientificName"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredEmail"></see>
    /// </summary>
    let hasAuthoredEmail = _prefix "hasAuthoredEmail"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredName"></see>
    /// </summary>
    let hasAuthoredName = _prefix "hasAuthoredName"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredTaxonomicDescription"></see>
    /// </summary>
    let hasAuthoredTaxonomicDescription = _prefix "hasAuthoredTaxonomicDescription"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredTaxonomicOpinion"></see>
    /// </summary>
    let hasAuthoredTaxonomicOpinion = _prefix "hasAuthoredTaxonomicOpinion"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredTaxonomicRevision"></see>
    /// </summary>
    let hasAuthoredTaxonomicRevision = _prefix "hasAuthoredTaxonomicRevision"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredWebComment"></see>
    /// </summary>
    let hasAuthoredWebComment = _prefix "hasAuthoredWebComment"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredWebPage"></see>
    /// </summary>
    let hasAuthoredWebPage = _prefix "hasAuthoredWebPage"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasBlog"></see>
    /// </summary>
    let hasBlog = _prefix "hasBlog"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasPublicationListHTML"></see>
    /// </summary>
    let hasPublicationListHTML = _prefix "hasPublicationListHTML"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasPublicationListRDF"></see>
    /// </summary>
    let hasPublicationListRDF = _prefix "hasPublicationListRDF"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasRevisedName"></see>
    /// </summary>
    let hasRevisedName = _prefix "hasRevisedName"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasTaxonomicAuthor"></see>
    /// </summary>
    let hasTaxonomicAuthor = _prefix "hasTaxonomicAuthor"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasTaxonomicRevisor"></see>
    /// </summary>
    let hasTaxonomicRevisor = _prefix "hasTaxonomicRevisor"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasWorkedWith"></see>
    /// </summary>
    let hasWorkedWith = _prefix "hasWorkedWith"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfRecGroup"></see>
    /// </summary>
    let isOriginalAuthorOfRecGroup = _prefix "isOriginalAuthorOfRecGroup"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfSpecies"></see>
    /// </summary>
    let isOriginalAuthorOfSpecies = _prefix "isOriginalAuthorOfSpecies"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfTaxon"></see>
    /// </summary>
    let isOriginalAuthorOfTaxon = _prefix "isOriginalAuthorOfTaxon"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfTaxonLiteral"></see>
    /// </summary>
    let isOriginalAuthorOfTaxonLiteral = _prefix "isOriginalAuthorOfTaxonLiteral"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfRecGroup"></see>
    /// </summary>
    let isRevisionalAuthorOfRecGroup = _prefix "isRevisionalAuthorOfRecGroup"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfSpecies"></see>
    /// </summary>
    let isRevisionalAuthorOfSpecies = _prefix "isRevisionalAuthorOfSpecies"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfTaxon"></see>
    /// </summary>
    let isRevisionalAuthorOfTaxon = _prefix "isRevisionalAuthorOfTaxon"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfTaxonLiteral"></see>
    /// </summary>
    let isRevisionalAuthorOfTaxonLiteral = _prefix "isRevisionalAuthorOfTaxonLiteral"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personAltPublicationName"></see>
    /// </summary>
    let personAltPublicationName = _prefix "personAltPublicationName"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personAuthorAbbreviation"></see>
    /// </summary>
    let personAuthorAbbreviation = _prefix "personAuthorAbbreviation"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personFirstname"></see>
    /// </summary>
    let personFirstname = _prefix "personFirstname"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personFullname"></see>
    /// </summary>
    let personFullname = _prefix "personFullname"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personHasWikispeciesPage"></see>
    /// </summary>
    let personHasWikispeciesPage = _prefix "personHasWikispeciesPage"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personWikispeciesPage"></see>
    /// </summary>
    let personWikispeciesPage = _prefix "personWikispeciesPage"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personLastname"></see>
    /// </summary>
    let personLastname = _prefix "personLastname"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personMiddleInitial"></see>
    /// </summary>
    let personMiddleInitial = _prefix "personMiddleInitial"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personMiddlename"></see>
    /// </summary>
    let personMiddlename = _prefix "personMiddlename"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personPublicationName"></see>
    /// </summary>
    let personPublicationName = _prefix "personPublicationName"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personUsedScientificMethod"></see>
    /// </summary>
    let personUsedScientificMethod = _prefix "personUsedScientificMethod"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personWikipediaPage"></see>
    /// </summary>
    let personWikipediaPage = _prefix "personWikipediaPage"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personWorkpage"></see>
    /// </summary>
    let personWorkpage = _prefix "personWorkpage"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personWorkplacePage"></see>
    /// </summary>
    let personWorkplacePage = _prefix "personWorkplacePage"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#personhasWikipediaPage"></see>
    /// </summary>
    let personhasWikipediaPage = _prefix "personhasWikipediaPage"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#referencesScientificMethod"></see>
    /// </summary>
    let referencesScientificMethod = _prefix "referencesScientificMethod"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#yearOfBirth"></see>
    /// </summary>
    let yearOfBirth = _prefix "yearOfBirth"
    /// <summary>
    ///   <see href="http://lod.taxonconcept.org/ontology/sci_people.owl#yearOfDeath"></see>
    /// </summary>
    let yearOfDeath = _prefix "yearOfDeath"
