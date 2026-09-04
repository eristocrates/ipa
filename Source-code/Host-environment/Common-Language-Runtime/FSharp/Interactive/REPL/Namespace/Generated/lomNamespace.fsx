#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lom =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#" "lom"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Comments on the educational use of a learning object, including information on when and by whom the comments were created.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Annotation">lom:Annotation</a>
    /// </summary>
    let Annotation = _prefixId.prefix "Annotation"
    /// <summary>
    ///   <para>rdfs:comment : Description of where a learning object falls within a particular classification system. To define multiple classifications, there may be multiple instances of this category for a learning object.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Classification">lom:Classification</a>
    /// </summary>
    let Classification = _prefixId.prefix "Classification"
    /// <summary>
    ///   <para>rdfs:comment : Those entities (i.e., people, organizations) that have contributed to the state of this learning object during its life cycle (e.g., creation, edits, publication).^^xsd:string</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Contribution">lom:Contribution</a>
    /// </summary>
    let Contribution = _prefixId.prefix "Contribution"
    /// <summary>
    ///   <para>rdfs:comment : A point in time with accuracy at least as small as one second, as described by IEEE LOM in clause 8 (IEEE 1484.12.1-2002).</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#DateTime">lom:DateTime</a>
    /// </summary>
    let DateTime = _prefixId.prefix "DateTime"
    /// <summary>
    ///   <para>rdfs:comment : An interval in time with accuracy at least as small as one second.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Duration">lom:Duration</a>
    /// </summary>
    let Duration = _prefixId.prefix "Duration"
    /// <summary>
    ///   <para>dcterms:type : ^^rdfs:Literal</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Educational">lom:Educational</a>
    /// </summary>
    let Educational = _prefixId.prefix "Educational"
    /// <summary>
    ///   <para>rdfs:comment : A globally unique label that identifies either a learning object or a learning object metadata record.</para>
    ///   <para>dcterms:identifier : ^^rdfs:Literal</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Identifier">lom:Identifier</a>
    /// </summary>
    let Identifier = _prefixId.prefix "Identifier"
    /// <summary>
    ///   <para>rdfs:comment : Each of the possible semantically equivalent character strings of a langString.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LangString">lom:LangString</a>
    /// </summary>
    let LangString = _prefixId.prefix "LangString"
    /// <summary>
    ///   <para>dcterms:format : ^^rdfs:Literal</para>
    ///   <para>dcterms:rights : ^^rdfs:Literal</para>
    ///   <para>dcterms:language : ^^rdfs:Literal</para>
    ///   <para>rdfs:comment : Learning Object^^xsd:string</para>
    ///   <para>dcterms:publisher : ^^rdfs:Literal</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LearningObject">lom:LearningObject</a>
    /// </summary>
    let LearningObject = _prefixId.prefix "LearningObject"
    let LifeCycleContribution = _prefixId.prefix "LifeCycleContribution"
    let MetaMetadataContribution = _prefixId.prefix "MetaMetadataContribution"
    /// <summary>
    ///   <para>rdfs:comment : A concept which defines the relationship between a learning object and other learning objects, if any.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Relation">lom:Relation</a>
    /// </summary>
    let Relation = _prefixId.prefix "Relation"
    /// <summary>
    ///   <para>rdfs:comment : A technical capability necessary for using a learning object.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#SingleTechnicalRequirement">lom:SingleTechnicalRequirement</a>
    /// </summary>
    let SingleTechnicalRequirement = _prefixId.prefix "SingleTechnicalRequirement"
    /// <summary>
    ///   <para>rdfs:comment : A particular term within a taxonomy. A taxon is a node that has a defined label or
    /// term. A taxon may also have an alphanumeric designation or identifier for standardized reference. Either or both the label and the entry may be used to designate a particular taxon. An ordered list of taxons creates a taxonomic path, i.e., "taxonomic stairway": this is a path from a more general to more specific entry in a classification.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Taxon">lom:Taxon</a>
    /// </summary>
    let Taxon = _prefixId.prefix "Taxon"
    /// <summary>
    ///   <para>rdfs:comment : A taxonomic path in a specific classification system. Each succeeding level is a refinement in the definition of the preceding level. There may be different paths, in the same or different classifications, which describe the same characteristic.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#TaxonPath">lom:TaxonPath</a>
    /// </summary>
    let TaxonPath = _prefixId.prefix "TaxonPath"
    /// <summary>
    ///   <para>rdfs:comment : The technical capabilities necessary for using a learning object. There can be multiple requirements, in which case all are required, i.e., the logical connector is AND.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#TechnicalRequirement">lom:TechnicalRequirement</a>
    /// </summary>
    let TechnicalRequirement = _prefixId.prefix "TechnicalRequirement"
    /// <summary>
    ///   <para>rdfs:comment : A vCard is a collection of one or more properties. A property is a uniquely named value. A set of properties can be grouped within a vCard. For example, the properties for a telephone number and comment can be grouped in order to preserve the coupling of the annotation with the telephone number. In addition to property groupings, a vC. versit  is developing a comprehensive family of PDI technologies based on open specifications and interoperability agreements to help meet this technology need.^^xsd:string</para>
    ///   <para>vcard:ORG : ^^rdfs:Literal</para>
    ///   <para>vcard:N : ^^rdfs:Literal</para>
    ///   <para>vcard:FN : ^^rdfs:Literal</para>
    ///   <para>vcard:email : ^^rdfs:Literal</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#VCard">lom:VCard</a>
    /// </summary>
    let VCard = _prefixId.prefix "VCard"
    /// <summary>
    ///   <para>rdfs:comment : The functional granularity of this learning object. IEEE LOM element 1.8.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#aggregationLevel">lom:aggregationLevel</a>
    /// </summary>
    let aggregationLevel = _prefixId.prefix "aggregationLevel"
    /// <summary>
    ///   <para>rdfs:comment : Comments on the educational use of a learning object, containing information on when and by whom the comments were created. This category enables educators to share their assessments of learning objects, suggestions for use, etc. IEEE LOM element 8.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotation">lom:annotation</a>
    /// </summary>
    let annotation = _prefixId.prefix "annotation"
    /// <summary>
    ///   <para>rdfs:comment : Date that this annotation was created. IEEE LOM element 8.2.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationDate">lom:annotationDate</a>
    /// </summary>
    let annotationDate = _prefixId.prefix "annotationDate"
    let annotationDescription = _prefixId.prefix "annotationDescription"
    /// <summary>
    ///   <para>rdfs:comment : Entity (i.e., people, organization) that created this annotation. IEEE LOM element 8.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationEntity">lom:annotationEntity</a>
    /// </summary>
    let annotationEntity = _prefixId.prefix "annotationEntity"
    /// <summary>
    ///   <para>rdfs:comment : Description of where a learning object falls within a particular classification system. IEEE LOM element 9.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classification">lom:classification</a>
    /// </summary>
    let classification = _prefixId.prefix "classification"
    let classificationDescription = _prefixId.prefix "classificationDescription"
    /// <summary>
    ///   <para>rdfs:comment : Keywords and phrases descriptive of the learning object relative to the stated 9.1:Classification.Purpose of this specific classification, such as accessibility, security level, etc., most relevant first. IEEE LOM element 9.4^^xsd:string</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationKeyword">lom:classificationKeyword</a>
    /// </summary>
    let classificationKeyword = _prefixId.prefix "classificationKeyword"
    /// <summary>
    ///   <para>rdfs:comment : The purpose of classifying a learning object. IEEE LOM element 9.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationPurpose">lom:classificationPurpose</a>
    /// </summary>
    let classificationPurpose = _prefixId.prefix "classificationPurpose"
    /// <summary>
    ///   <para>rdfs:comment : A particular term within a taxonomy which serves to classify a learning object. IEEE LOM element 9.2.2.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationTaxon">lom:classificationTaxon</a>
    /// </summary>
    let classificationTaxon = _prefixId.prefix "classificationTaxon"
    /// <summary>
    ///   <para>rdfs:comment : The date of the contribution. IEEE LOM element 3.2.3.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#contributionDateTime">lom:contributionDateTime</a>
    /// </summary>
    let contributionDateTime = _prefixId.prefix "contributionDateTime"
    /// <summary>
    ///   <para>rdfs:comment : The identification of and information about entities (i.e., people, organizations) contributing to this learning object. The entities shall be ordered as most relevant first. IEEE LOM element 3.2.2.^^xsd:string</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#contributionEntity">lom:contributionEntity</a>
    /// </summary>
    let contributionEntity = _prefixId.prefix "contributionEntity"
    /// <summary>
    ///   <para>rdfs:comment : Whether copyright or other restrictions apply to the use of this learning object. IEEE LOM element 6.2.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#copyrightAndOtherRestrictions">lom:copyrightAndOtherRestrictions</a>
    /// </summary>
    let copyrightAndOtherRestrictions = _prefixId.prefix "copyrightAndOtherRestrictions"
    let copyrightDescription = _prefixId.prefix "copyrightDescription"
    /// <summary>
    ///   <para>rdfs:comment : Whether use of the learning object requires payment. IEEE LOM element 6.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#cost">lom:cost</a>
    /// </summary>
    let cost = _prefixId.prefix "cost"
    /// <summary>
    ///   <para>rdfs:comment : The time, culture, geography or region to which this learning object applies.
    /// The extent or scope of the content of the learning object. Coverage will typically include spatial location (a place name or geographic coordinates), temporal period (a period label, date, or date range) or jurisdiction (such as a named administrative entity). Recommended best practice is to select a value from a controlled vocabulary (for example, the Thesaurus of Geographic Names [TGN]) and that, where appropriate, named places or time periods be used in preference to numeric identifiers such as sets of coordinates or date ranges. IEEE LOM element 1.6.</para>
    ///   <para>dcterms:coverage : ^^rdfs:Literal</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#coverage">lom:coverage</a>
    /// </summary>
    let coverage = _prefixId.prefix "coverage"
    let dateTimeDescription = _prefixId.prefix "dateTimeDescription"
    /// <summary>
    ///   <para>rdfs:comment : Date time value in format: YYYY[-MM[-DD[Thh[:mm[:ss[.s[TZD]]]]]]]</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#dateTimeValue">lom:dateTimeValue</a>
    /// </summary>
    let dateTimeValue = _prefixId.prefix "dateTimeValue"
    /// <summary>
    ///   <para>rdfs:comment : A textual description of the content of this learning object. IEEE LOM element 1.4.rdfs:comment : Comments on how this learning object is to be used. IEEE LOM element 5.10^^xsd:string</para>
    ///   <para>dcterms:description : ^^rdfs:Literal</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#description">lom:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    let duration = _prefixId.prefix "duration"
    let durationDescription = _prefixId.prefix "durationDescription"
    let durationValue = _prefixId.prefix "durationValue"
    /// <summary>
    ///   <para>rdfs:comment : This category describes the key educational or pedagogic characteristics of this learning object. IEEE LOM element 5.^^xsd:string</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educational">lom:educational</a>
    /// </summary>
    let educational = _prefixId.prefix "educational"
    /// <summary>
    ///   <para>rdfs:comment : The principal environment within which the learning and use of this learning object is intended to take place. IEEE LOM element 5.6.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalContext">lom:educationalContext</a>
    /// </summary>
    let educationalContext = _prefixId.prefix "educationalContext"
    /// <summary>
    ///   <para>rdfs:comment : How hard it is to work with or through this learning object for the typical intended target audience. IEEE LOM element 5.8</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalDifficulty">lom:educationalDifficulty</a>
    /// </summary>
    let educationalDifficulty = _prefixId.prefix "educationalDifficulty"
    /// <summary>
    ///   <para>rdfs:comment : Principal user(s) for which this learning object was designed, most dominant first. IEEE LOM element 5.5.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalIntendedUserRole">lom:educationalIntendedUserRole</a>
    /// </summary>
    let educationalIntendedUserRole = _prefixId.prefix "educationalIntendedUserRole"
    /// <summary>
    ///   <para>rdfs:comment : The degree of interactivity characterizing this learning object. Interactivity in this context refers to the degree to which the learner can influence the aspect or behavior of the learning object. IEEE LOM element 5.3.^^xsd:string</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityLevel">lom:educationalInteractivityLevel</a>
    /// </summary>
    let educationalInteractivityLevel = _prefixId.prefix "educationalInteractivityLevel"
    /// <summary>
    ///   <para>rdfs:comment : Predominant mode of learning supported by this learning object. IEEE LOM element 5.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityType">lom:educationalInteractivityType</a>
    /// </summary>
    let educationalInteractivityType = _prefixId.prefix "educationalInteractivityType"
    /// <summary>
    ///   <para>rdfs:comment : The primary human language or languages used within this learning object to communicate to the intended user. If the learning object had no lingual content (as in the case of a picture of the Mona Lisa, for example), then the appropriate value for this data element would be "none". IEEE LOM element 1.3.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalLanguage">lom:educationalLanguage</a>
    /// </summary>
    let educationalLanguage = _prefixId.prefix "educationalLanguage"
    /// <summary>
    ///   <para>rdfs:comment : The degree of conciseness of a learning object. The semantic density of a learning object may be estimated in terms of its size, span, or --in the case of self-timed resources such as audio or video-- duration. IEEE LOM element 5.4.^^xsd:string</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalSemanticDensity">lom:educationalSemanticDensity</a>
    /// </summary>
    let educationalSemanticDensity = _prefixId.prefix "educationalSemanticDensity"
    /// <summary>
    ///   <para>rdfs:comment : Age of the typical intended user. IEEE LOM element 5.7.^^xsd:string</para>
    ///   <para>rdf:value : ^^rdfs:Literal</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalTypicalAgeRange">lom:educationalTypicalAgeRange</a>
    /// </summary>
    let educationalTypicalAgeRange = _prefixId.prefix "educationalTypicalAgeRange"

    let educationalTypicalLearningTime =
        _prefixId.prefix "educationalTypicalLearningTime"

    /// <summary>
    ///   <para>rdfs:comment : Email as it appears in the vCard^^xsd:string</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#email">lom:email</a>
    /// </summary>
    let email = _prefixId.prefix "email"
    /// <summary>
    ///   <para>rdfs:comment : The target learning object that a relationship references. IEEE LOM element 7.2.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasRelatedResource">lom:hasRelatedResource</a>
    /// </summary>
    let hasRelatedResource = _prefixId.prefix "hasRelatedResource"
    /// <summary>
    ///   <para>rdfs:comment : A globally unique label that identifies the target  learning object. IEEE LOM element 7.2.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasResourceIdentifier">lom:hasResourceIdentifier</a>
    /// </summary>
    let hasResourceIdentifier = _prefixId.prefix "hasResourceIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : Technical datatype(s) of (all the components of) this learning object. This information is used to identify the software needed to access the learning object. IEEE LOM element 4.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasTechnicalFormat">lom:hasTechnicalFormat</a>
    /// </summary>
    let hasTechnicalFormat = _prefixId.prefix "hasTechnicalFormat"
    /// <summary>
    ///   <para>rdfs:comment : This predicate relates a singleLangString to the character string containing its textual description.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasValue">lom:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:comment : This predicate represents the fact that a learning object has a label that identifies it. IEEE LOM element 1.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifier">lom:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:comment : This predicate relates a lomIdentifier to the name or designator of the identification or cataloging scheme used for its identification. It is usually a namespace scheme. IEEE LOM element 1.1, 3.1, 7.2.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifierCatalog">lom:identifierCatalog</a>
    /// </summary>
    let identifierCatalog = _prefixId.prefix "identifierCatalog"
    /// <summary>
    ///   <para>rdfs:comment : This predicate relates a lomIdentifier to the value of the identifier within the identification or cataloging scheme that designates or identifies a learning object or a learning object metadata record (a namespace specific string).  IEEE LOM element 1.1, 3.1, 7.2.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifierEntry">lom:identifierEntry</a>
    /// </summary>
    let identifierEntry = _prefixId.prefix "identifierEntry"
    /// <summary>
    ///   <para>rdfs:comment : LangString values may include multiple semantically equivalent character strings, such as translations or alternative descriptions. Each of these is represented by a singleLangString.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#includesSingleLangString">lom:includesSingleLangString</a>
    /// </summary>
    let includesSingleLangString = _prefixId.prefix "includesSingleLangString"
    /// <summary>
    ///   <para>rdfs:comment : When grouping multiple requirements, the composite requirement is satisfied when one of the component requirements is satisfied, i.e., the logical connector is OR. IEEE LOM element 4.4.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#isCompositeOf">lom:isCompositeOf</a>
    /// </summary>
    let isCompositeOf = _prefixId.prefix "isCompositeOf"
    /// <summary>
    ///   <para>rdfs:comment : A keyword or phrase describing the topic of this learning object. This data element should not be used for characteristics that can be described by other data elements. IEEE LOM element 1.5.</para>
    ///   <para>rdf:value : ^^rdfs:Literal</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#keyword">lom:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    let lifeCycleContribution = _prefixId.prefix "lifeCycleContribution"
    /// <summary>
    ///   <para>rdfs:comment : Kind of contribution. IEEE LOM element 2.3.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleContributionRole">lom:lifeCycleContributionRole</a>
    /// </summary>
    let lifeCycleContributionRole = _prefixId.prefix "lifeCycleContributionRole"
    /// <summary>
    ///   <para>rdfs:comment : The completion status or condition of this learning object. IEEE LOM element 2.2^^xsd:string</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleStatus">lom:lifeCycleStatus</a>
    /// </summary>
    let lifeCycleStatus = _prefixId.prefix "lifeCycleStatus"
    let lifeCycleVersion = _prefixId.prefix "lifeCycleVersion"
    /// <summary>
    ///   <para>rdfs:comment : Those entities (i.e., people, organizations) that have contributed to the state of this learning object during its life cycle (e.g.,creation, edits, publication).</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataContribution">lom:metaMetadataContribution</a>
    /// </summary>
    let metaMetadataContribution = _prefixId.prefix "metaMetadataContribution"
    /// <summary>
    ///   <para>rdfs:comment : Kind of contribution. IEEE LOM element 3.2.1.^^xsd:string</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataContributionRole">lom:metaMetadataContributionRole</a>
    /// </summary>
    let metaMetadataContributionRole = _prefixId.prefix "metaMetadataContributionRole"
    /// <summary>
    ///   <para>rdfs:comment : A globally unique label that identifies this metadata record. IEEE LOM element 3.1.^^xsd:string</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataIdentifier">lom:metaMetadataIdentifier</a>
    /// </summary>
    let metaMetadataIdentifier = _prefixId.prefix "metaMetadataIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : Language of this metadata instance. This is the default language for all LangString values in this metadata instance. If a value for this data element is not present in a metadata instance, then there is no default language for LangString values. IEEE LOM element 3.4.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataLanguage">lom:metaMetadataLanguage</a>
    /// </summary>
    let metaMetadataLanguage = _prefixId.prefix "metaMetadataLanguage"
    /// <summary>
    ///   <para>rdfs:comment : The name and version of the authoritative specification used to create this metadata instance. IEEE LOM element 3.3.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metadataSchema">lom:metadataSchema</a>
    /// </summary>
    let metadataSchema = _prefixId.prefix "metadataSchema"
    /// <summary>
    ///   <para>rdfs:comment : Highest possible version of the required technology to use the learning object. IEEE LOM element 4.4.1.4.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeMaximumVersion">lom:orCompositeMaximumVersion</a>
    /// </summary>
    let orCompositeMaximumVersion = _prefixId.prefix "orCompositeMaximumVersion"
    /// <summary>
    ///   <para>rdfs:comment : Lowest possible version of the required technology to use the learning object. IEEE LOM element 4.4.1.3.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeMinimumVersion">lom:orCompositeMinimumVersion</a>
    /// </summary>
    let orCompositeMinimumVersion = _prefixId.prefix "orCompositeMinimumVersion"
    /// <summary>
    ///   <para>rdfs:comment : Name of the required technology to use a learning object. IEEE LOM element 4.4.1.2.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeName">lom:orCompositeName</a>
    /// </summary>
    let orCompositeName = _prefixId.prefix "orCompositeName"
    /// <summary>
    ///   <para>rdfs:comment : The technology required to use this learning object, e.g., hardware, software, network, etc. IEEE LOM element 4.4.1.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeType">lom:orCompositeType</a>
    /// </summary>
    let orCompositeType = _prefixId.prefix "orCompositeType"
    let otherPlatformRequirements = _prefixId.prefix "otherPlatformRequirements"
    /// <summary>
    ///   <para>dcterms:description : ^^rdfs:Literal</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relatedResourceDescription">lom:relatedResourceDescription</a>
    /// </summary>
    let relatedResourceDescription = _prefixId.prefix "relatedResourceDescription"
    /// <summary>
    ///   <para>rdfs:comment : Relationship between a learning object and other learning objects, if any.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relation">lom:relation</a>
    /// </summary>
    let relation = _prefixId.prefix "relation"
    /// <summary>
    ///   <para>rdfs:comment : Nature of the relationship between a learning object and the target learning object, identified by 7.2:Relation.Resource. IEEE LOM element 7.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relationKind">lom:relationKind</a>
    /// </summary>
    let relationKind = _prefixId.prefix "relationKind"
    /// <summary>
    ///   <para>rdfs:comment : Underlying organizational structure of this learning object. IEEE LOM element 1.7.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#structure">lom:structure</a>
    /// </summary>
    let structure = _prefixId.prefix "structure"
    let taxonEntry = _prefixId.prefix "taxonEntry"
    /// <summary>
    ///   <para>rdfs:comment : The identifier of the taxon, such as a number or letter combination provided by the source of the taxonomy. IEEE LOM element 9.2.2.1.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonId">lom:taxonId</a>
    /// </summary>
    let taxonId = _prefixId.prefix "taxonId"
    /// <summary>
    ///   <para>rdfs:comment : A taxonomic path in a specific classification system according to which a learning object is classified. IEEE LOM element 9.2.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonPath">lom:taxonPath</a>
    /// </summary>
    let taxonPath = _prefixId.prefix "taxonPath"
    let taxonpathSource = _prefixId.prefix "taxonpathSource"
    let technicalDuration = _prefixId.prefix "technicalDuration"
    let technicalInstallationRemarks = _prefixId.prefix "technicalInstallationRemarks"
    /// <summary>
    ///   <para>rdfs:comment : A string that is used to access this learning object. It may be a location  (e.g., Universal Resource Locator), or a method that resolves to a location (e.g., Universal Resource Identifier). The first element of this list shall be the preferable location. IEEE LOM element 4.3.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalLocation">lom:technicalLocation</a>
    /// </summary>
    let technicalLocation = _prefixId.prefix "technicalLocation"
    /// <summary>
    ///   <para>rdfs:comment : A technical capability necessary for using a learning object. IEEE LOM Element "4.4. Requirement".</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalRequirements">lom:technicalRequirements</a>
    /// </summary>
    let technicalRequirements = _prefixId.prefix "technicalRequirements"
    /// <summary>
    ///   <para>rdfs:comment : The size of the digital learning object in bytes (not Mbytes, GB, etc.). The size is represented as a decimal value. This data element shall refer to the actual size of this learning object. If the learning object is compressed, then this data element shall refer to the uncompressed size. IEEE LOM element 4.2.</para>
    ///   <a href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalSize">lom:technicalSize</a>
    /// </summary>
    let technicalSize = _prefixId.prefix "technicalSize"
