#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module scip =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://lod.taxonconcept.org/ontology/sci_people.owl#" "scip"

    /// <summary>
    ///   <para>rdfs:label : PersonPublicationListHTML^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#PersonPublicationListHTML">scip:PersonPublicationListHTML</a>
    /// </summary>
    let PersonPublicationListHTML = _prefixId.prefix "PersonPublicationListHTML"
    /// <summary>
    ///   <para>rdfs:label : PersonPublicationListRDF^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#PersonPublicationListRDF">scip:PersonPublicationListRDF</a>
    /// </summary>
    let PersonPublicationListRDF = _prefixId.prefix "PersonPublicationListRDF"
    /// <summary>
    ///   <para>rdfs:label : ScientificMethod^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#ScientificMethod">scip:ScientificMethod</a>
    /// </summary>
    let ScientificMethod = _prefixId.prefix "ScientificMethod"
    /// <summary>
    ///   <para>rdfs:label : citationUse^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#citationUse">scip:citationUse</a>
    /// </summary>
    let citationUse = _prefixId.prefix "citationUse"
    /// <summary>
    ///   <para>rdfs:label : hasAuthor^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthor">scip:hasAuthor</a>
    /// </summary>
    let hasAuthor = _prefixId.prefix "hasAuthor"
    /// <summary>
    ///   <para>rdfs:label : hasAuthored^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthored">scip:hasAuthored</a>
    /// </summary>
    let hasAuthored = _prefixId.prefix "hasAuthored"
    /// <summary>
    ///   <para>rdfs:label : hasAuthoredArticle^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredArticle">scip:hasAuthoredArticle</a>
    /// </summary>
    let hasAuthoredArticle = _prefixId.prefix "hasAuthoredArticle"
    /// <summary>
    ///   <para>rdfs:label : hasAuthoredBinomialName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredBinomialName">scip:hasAuthoredBinomialName</a>
    /// </summary>
    let hasAuthoredBinomialName = _prefixId.prefix "hasAuthoredBinomialName"
    /// <summary>
    ///   <para>rdfs:label : hasAuthoredEmail^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredEmail">scip:hasAuthoredEmail</a>
    /// </summary>
    let hasAuthoredEmail = _prefixId.prefix "hasAuthoredEmail"
    /// <summary>
    ///   <para>rdfs:label : hasAuthoredName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredName">scip:hasAuthoredName</a>
    /// </summary>
    let hasAuthoredName = _prefixId.prefix "hasAuthoredName"
    /// <summary>
    ///   <para>rdfs:label : hasAuthoredScientificName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredScientificName">scip:hasAuthoredScientificName</a>
    /// </summary>
    let hasAuthoredScientificName = _prefixId.prefix "hasAuthoredScientificName"

    /// <summary>
    ///   <para>rdfs:label : hasAuthoredTaxonomicDescription^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredTaxonomicDescription">scip:hasAuthoredTaxonomicDescription</a>
    /// </summary>
    let hasAuthoredTaxonomicDescription =
        _prefixId.prefix "hasAuthoredTaxonomicDescription"

    /// <summary>
    ///   <para>rdfs:label : hasAuthoredTaxonomicComment^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredTaxonomicOpinion">scip:hasAuthoredTaxonomicOpinion</a>
    /// </summary>
    let hasAuthoredTaxonomicOpinion = _prefixId.prefix "hasAuthoredTaxonomicOpinion"
    /// <summary>
    ///   <para>rdfs:label : hasAuthoredTaxonomicRevision^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredTaxonomicRevision">scip:hasAuthoredTaxonomicRevision</a>
    /// </summary>
    let hasAuthoredTaxonomicRevision = _prefixId.prefix "hasAuthoredTaxonomicRevision"
    /// <summary>
    ///   <para>rdfs:label : hasAuthoredWebComment^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredWebComment">scip:hasAuthoredWebComment</a>
    /// </summary>
    let hasAuthoredWebComment = _prefixId.prefix "hasAuthoredWebComment"
    /// <summary>
    ///   <para>rdfs:label : hasAuthoredWebPage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredWebPage">scip:hasAuthoredWebPage</a>
    /// </summary>
    let hasAuthoredWebPage = _prefixId.prefix "hasAuthoredWebPage"
    /// <summary>
    ///   <para>rdfs:label : hasBlog^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasBlog">scip:hasBlog</a>
    /// </summary>
    let hasBlog = _prefixId.prefix "hasBlog"
    /// <summary>
    ///   <para>rdfs:label : hasPublicationListHTML^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasPublicationListHTML">scip:hasPublicationListHTML</a>
    /// </summary>
    let hasPublicationListHTML = _prefixId.prefix "hasPublicationListHTML"
    /// <summary>
    ///   <para>rdfs:label : hasPublicationListRDF^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasPublicationListRDF">scip:hasPublicationListRDF</a>
    /// </summary>
    let hasPublicationListRDF = _prefixId.prefix "hasPublicationListRDF"
    /// <summary>
    ///   <para>rdfs:label : hasRevisedName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasRevisedName">scip:hasRevisedName</a>
    /// </summary>
    let hasRevisedName = _prefixId.prefix "hasRevisedName"
    /// <summary>
    ///   <para>rdfs:label : hasTaxonomicAuthor^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasTaxonomicAuthor">scip:hasTaxonomicAuthor</a>
    /// </summary>
    let hasTaxonomicAuthor = _prefixId.prefix "hasTaxonomicAuthor"
    /// <summary>
    ///   <para>rdfs:label : hasTaxonomicRevisor^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasTaxonomicRevisor">scip:hasTaxonomicRevisor</a>
    /// </summary>
    let hasTaxonomicRevisor = _prefixId.prefix "hasTaxonomicRevisor"
    /// <summary>
    ///   <para>rdfs:label : hasWorkedWith^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasWorkedWith">scip:hasWorkedWith</a>
    /// </summary>
    let hasWorkedWith = _prefixId.prefix "hasWorkedWith"
    /// <summary>
    ///   <para>rdfs:label : isOriginalAuthorOfRecGroup^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfRecGroup">scip:isOriginalAuthorOfRecGroup</a>
    /// </summary>
    let isOriginalAuthorOfRecGroup = _prefixId.prefix "isOriginalAuthorOfRecGroup"
    /// <summary>
    ///   <para>rdfs:label : isOriginalAuthorOfSpecies^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfSpecies">scip:isOriginalAuthorOfSpecies</a>
    /// </summary>
    let isOriginalAuthorOfSpecies = _prefixId.prefix "isOriginalAuthorOfSpecies"
    /// <summary>
    ///   <para>rdfs:label : isOriginalAuthorOfTaxon^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfTaxon">scip:isOriginalAuthorOfTaxon</a>
    /// </summary>
    let isOriginalAuthorOfTaxon = _prefixId.prefix "isOriginalAuthorOfTaxon"

    /// <summary>
    ///   <para>rdfs:label : isOrignalAuthorOfTaxonLiteral^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfTaxonLiteral">scip:isOriginalAuthorOfTaxonLiteral</a>
    /// </summary>
    let isOriginalAuthorOfTaxonLiteral =
        _prefixId.prefix "isOriginalAuthorOfTaxonLiteral"

    /// <summary>
    ///   <para>rdfs:label : isRevisionalAuthorOfRecGroup^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfRecGroup">scip:isRevisionalAuthorOfRecGroup</a>
    /// </summary>
    let isRevisionalAuthorOfRecGroup = _prefixId.prefix "isRevisionalAuthorOfRecGroup"
    /// <summary>
    ///   <para>rdfs:label : isRevisionalAuthorOfSpecies^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfSpecies">scip:isRevisionalAuthorOfSpecies</a>
    /// </summary>
    let isRevisionalAuthorOfSpecies = _prefixId.prefix "isRevisionalAuthorOfSpecies"
    /// <summary>
    ///   <para>rdfs:label : isRevisionalAuthorOfTaxon^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfTaxon">scip:isRevisionalAuthorOfTaxon</a>
    /// </summary>
    let isRevisionalAuthorOfTaxon = _prefixId.prefix "isRevisionalAuthorOfTaxon"

    /// <summary>
    ///   <para>rdfs:label : isRevisionalAuthorOfTaxonLiteral^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfTaxonLiteral">scip:isRevisionalAuthorOfTaxonLiteral</a>
    /// </summary>
    let isRevisionalAuthorOfTaxonLiteral =
        _prefixId.prefix "isRevisionalAuthorOfTaxonLiteral"

    /// <summary>
    ///   <para>rdfs:label : altNameInPublication^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personAltPublicationName">scip:personAltPublicationName</a>
    /// </summary>
    let personAltPublicationName = _prefixId.prefix "personAltPublicationName"
    /// <summary>
    ///   <para>rdfs:label : personAuthorAbbreviation^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personAuthorAbbreviation">scip:personAuthorAbbreviation</a>
    /// </summary>
    let personAuthorAbbreviation = _prefixId.prefix "personAuthorAbbreviation"
    /// <summary>
    ///   <para>rdfs:label : person_firstname^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personFirstname">scip:personFirstname</a>
    /// </summary>
    let personFirstname = _prefixId.prefix "personFirstname"
    /// <summary>
    ///   <para>rdfs:label : personFullName^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personFullname">scip:personFullname</a>
    /// </summary>
    let personFullname = _prefixId.prefix "personFullname"
    /// <summary>
    ///   <para>rdfs:label : personHasWikispeciesPage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personHasWikispeciesPage">scip:personHasWikispeciesPage</a>
    /// </summary>
    let personHasWikispeciesPage = _prefixId.prefix "personHasWikispeciesPage"
    /// <summary>
    ///   <para>rdfs:label : person_lastname^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personLastname">scip:personLastname</a>
    /// </summary>
    let personLastname = _prefixId.prefix "personLastname"
    /// <summary>
    ///   <para>rdfs:label : personMiddleInitial^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personMiddleInitial">scip:personMiddleInitial</a>
    /// </summary>
    let personMiddleInitial = _prefixId.prefix "personMiddleInitial"
    /// <summary>
    ///   <para>rdfs:label : person_middename^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personMiddlename">scip:personMiddlename</a>
    /// </summary>
    let personMiddlename = _prefixId.prefix "personMiddlename"
    /// <summary>
    ///   <para>rdfs:label : nameInPublication^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personPublicationName">scip:personPublicationName</a>
    /// </summary>
    let personPublicationName = _prefixId.prefix "personPublicationName"
    /// <summary>
    ///   <para>rdfs:label : personUsedScientificMethod^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personUsedScientificMethod">scip:personUsedScientificMethod</a>
    /// </summary>
    let personUsedScientificMethod = _prefixId.prefix "personUsedScientificMethod"
    /// <summary>
    ///   <para>rdfs:label : personWikipediaPage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personWikipediaPage">scip:personWikipediaPage</a>
    /// </summary>
    let personWikipediaPage = _prefixId.prefix "personWikipediaPage"
    /// <summary>
    ///   <para>rdfs:label : personWikispeciesPage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personWikispeciesPage">scip:personWikispeciesPage</a>
    /// </summary>
    let personWikispeciesPage = _prefixId.prefix "personWikispeciesPage"
    /// <summary>
    ///   <para>rdfs:label : personWorkpage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personWorkpage">scip:personWorkpage</a>
    /// </summary>
    let personWorkpage = _prefixId.prefix "personWorkpage"
    /// <summary>
    ///   <para>rdfs:label : personWorkplacePage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personWorkplacePage">scip:personWorkplacePage</a>
    /// </summary>
    let personWorkplacePage = _prefixId.prefix "personWorkplacePage"
    /// <summary>
    ///   <para>rdfs:label : personhasWikipediaPage^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#personhasWikipediaPage">scip:personhasWikipediaPage</a>
    /// </summary>
    let personhasWikipediaPage = _prefixId.prefix "personhasWikipediaPage"
    /// <summary>
    ///   <para>rdfs:label : referencesScientificMethod^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#referencesScientificMethod">scip:referencesScientificMethod</a>
    /// </summary>
    let referencesScientificMethod = _prefixId.prefix "referencesScientificMethod"
    /// <summary>
    ///   <para>rdfs:label : yearOfBirth^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#yearOfBirth">scip:yearOfBirth</a>
    /// </summary>
    let yearOfBirth = _prefixId.prefix "yearOfBirth"
    /// <summary>
    ///   <para>rdfs:label : yearOfDeath^^xsd:string</para>
    ///   <a href="http://lod.taxonconcept.org/ontology/sci_people.owl#yearOfDeath">scip:yearOfDeath</a>
    /// </summary>
    let yearOfDeath = _prefixId.prefix "yearOfDeath"
