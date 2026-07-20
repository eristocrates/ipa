namespace http.data.opendiscoveryspace.eu.lom_ontology_ods.owl.hash

open DoxAletheia

module lom =
    let _namespace_name = "http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Comments on the educational use of a learning object, including information on when and by whom the comments were created.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Annotation"></see></summary>
    let Annotation = _prefix "Annotation"
    /// <summary>
    /// Date time value in format: YYYY[-MM[-DD[Thh[:mm[:ss[.s[TZD]]]]]]]
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#dateTimeValue"></see></summary>
    let dateTimeValue = _prefix "dateTimeValue"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationDescription"></see>
    /// </summary>
    let annotationDescription = _prefix "annotationDescription"
    /// <summary>
    /// A vCard is a collection of one or more properties. A property is a uniquely named value. A set of properties can be grouped within a vCard. For example, the properties for a telephone number and comment can be grouped in order to preserve the coupling of the annotation with the telephone number. In addition to property groupings, a vC. versit  is developing a comprehensive family of PDI technologies based on open specifications and interoperability agreements to help meet this technology need.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#VCard"></see></summary>
    let VCard = _prefix "VCard"
    /// <summary>
    /// Entity (i.e., people, organization) that created this annotation. IEEE LOM element 8.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationEntity"></see></summary>
    let annotationEntity = _prefix "annotationEntity"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#dateTimeDescription"></see>
    /// </summary>
    let dateTimeDescription = _prefix "dateTimeDescription"
    /// <summary>
    /// Description of where a learning object falls within a particular classification system. To define multiple classifications, there may be multiple instances of this category for a learning object.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Classification"></see></summary>
    let Classification = _prefix "Classification"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationDescription"></see>
    /// </summary>
    let classificationDescription = _prefix "classificationDescription"
    /// <summary>
    /// The purpose of classifying a learning object. IEEE LOM element 9.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationPurpose"></see></summary>
    let classificationPurpose = _prefix "classificationPurpose"
    /// <summary>
    /// Each of the possible semantically equivalent character strings of a langString.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LangString"></see></summary>
    let LangString = _prefix "LangString"
    /// <summary>
    /// Keywords and phrases descriptive of the learning object relative to the stated 9.1:Classification.Purpose of this specific classification, such as accessibility, security level, etc., most relevant first. IEEE LOM element 9.4
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationKeyword"></see></summary>
    let classificationKeyword = _prefix "classificationKeyword"
    /// <summary>
    /// A taxonomic path in a specific classification system. Each succeeding level is a refinement in the definition of the preceding level. There may be different paths, in the same or different classifications, which describe the same characteristic.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#TaxonPath"></see></summary>
    let TaxonPath = _prefix "TaxonPath"
    /// <summary>
    /// A taxonomic path in a specific classification system according to which a learning object is classified. IEEE LOM element 9.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonPath"></see></summary>
    let taxonPath = _prefix "taxonPath"
    /// <summary>
    /// Those entities (i.e., people, organizations) that have contributed to the state of this learning object during its life cycle (e.g., creation, edits, publication).
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Contribution"></see></summary>
    let Contribution = _prefix "Contribution"
    /// <summary>
    /// A point in time with accuracy at least as small as one second, as described by IEEE LOM in clause 8 (IEEE 1484.12.1-2002).
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#DateTime"></see></summary>
    let DateTime = _prefix "DateTime"
    /// <summary>
    /// An interval in time with accuracy at least as small as one second.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Duration"></see></summary>
    let Duration = _prefix "Duration"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#durationDescription"></see>
    /// </summary>
    let durationDescription = _prefix "durationDescription"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#durationValue"></see>
    /// </summary>
    let durationValue = _prefix "durationValue"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Educational"></see>
    /// </summary>
    let Educational = _prefix "Educational"
    /// <summary>
    /// Principal user(s) for which this learning object was designed, most dominant first. IEEE LOM element 5.5.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalIntendedUserRole"></see></summary>
    let educationalIntendedUserRole = _prefix "educationalIntendedUserRole"
    /// <summary>
    /// The degree of interactivity characterizing this learning object. Interactivity in this context refers to the degree to which the learner can influence the aspect or behavior of the learning object. IEEE LOM element 5.3.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityLevel"></see></summary>
    let educationalInteractivityLevel = _prefix "educationalInteractivityLevel"
    /// <summary>
    /// The principal environment within which the learning and use of this learning object is intended to take place. IEEE LOM element 5.6.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalContext"></see></summary>
    let educationalContext = _prefix "educationalContext"
    /// <summary>
    /// The primary human language or languages used within this learning object to communicate to the intended user. If the learning object had no lingual content (as in the case of a picture of the Mona Lisa, for example), then the appropriate value for this data element would be "none". IEEE LOM element 1.3.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalLanguage"></see></summary>
    let educationalLanguage = _prefix "educationalLanguage"
    /// <summary>
    /// Predominant mode of learning supported by this learning object. IEEE LOM element 5.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityType"></see></summary>
    let educationalInteractivityType = _prefix "educationalInteractivityType"
    /// <summary>
    /// How hard it is to work with or through this learning object for the typical intended target audience. IEEE LOM element 5.8
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalDifficulty"></see></summary>
    let educationalDifficulty = _prefix "educationalDifficulty"
    /// <summary>
    /// The degree of conciseness of a learning object. The semantic density of a learning object may be estimated in terms of its size, span, or --in the case of self-timed resources such as audio or video-- duration. IEEE LOM element 5.4.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalSemanticDensity"></see></summary>
    let educationalSemanticDensity = _prefix "educationalSemanticDensity"
    /// <summary>
    /// Age of the typical intended user. IEEE LOM element 5.7.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalTypicalAgeRange"></see></summary>
    let educationalTypicalAgeRange = _prefix "educationalTypicalAgeRange"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalTypicalLearningTime"></see>
    /// </summary>
    let educationalTypicalLearningTime = _prefix "educationalTypicalLearningTime"
    /// <summary>
    /// A textual description of the content of this learning object. IEEE LOM element 1.4.
    /// Comments on how this learning object is to be used. IEEE LOM element 5.10
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// A globally unique label that identifies either a learning object or a learning object metadata record.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Identifier"></see></summary>
    let Identifier = _prefix "Identifier"
    /// <summary>
    /// This predicate relates a lomIdentifier to the name or designator of the identification or cataloging scheme used for its identification. It is usually a namespace scheme. IEEE LOM element 1.1, 3.1, 7.2.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifierCatalog"></see></summary>
    let identifierCatalog = _prefix "identifierCatalog"
    /// <summary>
    /// This predicate relates a singleLangString to the character string containing its textual description.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// Learning Object
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LearningObject"></see></summary>
    let LearningObject = _prefix "LearningObject"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleVersion"></see>
    /// </summary>
    let lifeCycleVersion = _prefix "lifeCycleVersion"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LifeCycleContribution"></see>
    /// </summary>
    let LifeCycleContribution = _prefix "LifeCycleContribution"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleContribution"></see>
    /// </summary>
    let lifeCycleContribution = _prefix "lifeCycleContribution"
    /// <summary>
    /// A string that is used to access this learning object. It may be a location  (e.g., Universal Resource Locator), or a method that resolves to a location (e.g., Universal Resource Identifier). The first element of this list shall be the preferable location. IEEE LOM element 4.3.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalLocation"></see></summary>
    let technicalLocation = _prefix "technicalLocation"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalDuration"></see>
    /// </summary>
    let technicalDuration = _prefix "technicalDuration"
    /// <summary>
    /// Description of where a learning object falls within a particular classification system. IEEE LOM element 9.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classification"></see></summary>
    let classification = _prefix "classification"
    /// <summary>
    /// Whether copyright or other restrictions apply to the use of this learning object. IEEE LOM element 6.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#copyrightAndOtherRestrictions"></see></summary>
    let copyrightAndOtherRestrictions = _prefix "copyrightAndOtherRestrictions"
    /// <summary>
    /// Whether use of the learning object requires payment. IEEE LOM element 6.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#cost"></see></summary>
    let cost = _prefix "cost"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#MetaMetadataContribution"></see>
    /// </summary>
    let MetaMetadataContribution = _prefix "MetaMetadataContribution"
    /// <summary>
    /// Those entities (i.e., people, organizations) that have contributed to the state of this learning object during its life cycle (e.g.,creation, edits, publication).
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataContribution"></see></summary>
    let metaMetadataContribution = _prefix "metaMetadataContribution"
    /// <summary>
    /// A globally unique label that identifies this metadata record. IEEE LOM element 3.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataIdentifier"></see></summary>
    let metaMetadataIdentifier = _prefix "metaMetadataIdentifier"
    /// <summary>
    /// The technical capabilities necessary for using a learning object. There can be multiple requirements, in which case all are required, i.e., the logical connector is AND.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#TechnicalRequirement"></see></summary>
    let TechnicalRequirement = _prefix "TechnicalRequirement"
    /// <summary>
    /// A technical capability necessary for using a learning object. IEEE LOM Element "4.4. Requirement".
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalRequirements"></see></summary>
    let technicalRequirements = _prefix "technicalRequirements"
    /// <summary>
    /// A concept which defines the relationship between a learning object and other learning objects, if any.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Relation"></see></summary>
    let Relation = _prefix "Relation"
    /// <summary>
    /// Relationship between a learning object and other learning objects, if any.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relation"></see></summary>
    let relation = _prefix "relation"
    /// <summary>
    /// A keyword or phrase describing the topic of this learning object. This data element should not be used for characteristics that can be described by other data elements. IEEE LOM element 1.5.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#keyword"></see></summary>
    let keyword = _prefix "keyword"
    /// <summary>
    /// Underlying organizational structure of this learning object. IEEE LOM element 1.7.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#structure"></see></summary>
    let structure = _prefix "structure"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalInstallationRemarks"></see>
    /// </summary>
    let technicalInstallationRemarks = _prefix "technicalInstallationRemarks"
    /// <summary>
    /// This category describes the key educational or pedagogic characteristics of this learning object. IEEE LOM element 5.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educational"></see></summary>
    let educational = _prefix "educational"
    /// <summary>
    /// The completion status or condition of this learning object. IEEE LOM element 2.2
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleStatus"></see></summary>
    let lifeCycleStatus = _prefix "lifeCycleStatus"
    /// <summary>
    /// This predicate represents the fact that a learning object has a label that identifies it. IEEE LOM element 1.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// The functional granularity of this learning object. IEEE LOM element 1.8.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#aggregationLevel"></see></summary>
    let aggregationLevel = _prefix "aggregationLevel"
    /// <summary>
    /// The size of the digital learning object in bytes (not Mbytes, GB, etc.). The size is represented as a decimal value. This data element shall refer to the actual size of this learning object. If the learning object is compressed, then this data element shall refer to the uncompressed size. IEEE LOM element 4.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalSize"></see></summary>
    let technicalSize = _prefix "technicalSize"
    /// <summary>
    /// Language of this metadata instance. This is the default language for all LangString values in this metadata instance. If a value for this data element is not present in a metadata instance, then there is no default language for LangString values. IEEE LOM element 3.4.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataLanguage"></see></summary>
    let metaMetadataLanguage = _prefix "metaMetadataLanguage"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#otherPlatformRequirements"></see>
    /// </summary>
    let otherPlatformRequirements = _prefix "otherPlatformRequirements"
    /// <summary>
    /// The time, culture, geography or region to which this learning object applies.
    /// The extent or scope of the content of the learning object. Coverage will typically include spatial location (a place name or geographic coordinates), temporal period (a period label, date, or date range) or jurisdiction (such as a named administrative entity). Recommended best practice is to select a value from a controlled vocabulary (for example, the Thesaurus of Geographic Names [TGN]) and that, where appropriate, named places or time periods be used in preference to numeric identifiers such as sets of coordinates or date ranges. IEEE LOM element 1.6.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#coverage"></see></summary>
    let coverage = _prefix "coverage"
    /// <summary>
    /// The name and version of the authoritative specification used to create this metadata instance. IEEE LOM element 3.3.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metadataSchema"></see></summary>
    let metadataSchema = _prefix "metadataSchema"
    /// <summary>
    /// Comments on the educational use of a learning object, containing information on when and by whom the comments were created. This category enables educators to share their assessments of learning objects, suggestions for use, etc. IEEE LOM element 8.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotation"></see></summary>
    let annotation = _prefix "annotation"
    /// <summary>
    /// Kind of contribution. IEEE LOM element 2.3.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleContributionRole"></see></summary>
    let lifeCycleContributionRole = _prefix "lifeCycleContributionRole"
    /// <summary>
    /// Kind of contribution. IEEE LOM element 3.2.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataContributionRole"></see></summary>
    let metaMetadataContributionRole = _prefix "metaMetadataContributionRole"
    /// <summary>
    /// Nature of the relationship between a learning object and the target learning object, identified by 7.2:Relation.Resource. IEEE LOM element 7.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relationKind"></see></summary>
    let relationKind = _prefix "relationKind"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relatedResourceDescription"></see>
    /// </summary>
    let relatedResourceDescription = _prefix "relatedResourceDescription"
    /// <summary>
    /// A technical capability necessary for using a learning object.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#SingleTechnicalRequirement"></see></summary>
    let SingleTechnicalRequirement = _prefix "SingleTechnicalRequirement"
    /// <summary>
    /// Lowest possible version of the required technology to use the learning object. IEEE LOM element 4.4.1.3.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeMinimumVersion"></see></summary>
    let orCompositeMinimumVersion = _prefix "orCompositeMinimumVersion"
    /// <summary>
    /// Name of the required technology to use a learning object. IEEE LOM element 4.4.1.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeName"></see></summary>
    let orCompositeName = _prefix "orCompositeName"
    /// <summary>
    /// The technology required to use this learning object, e.g., hardware, software, network, etc. IEEE LOM element 4.4.1.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeType"></see></summary>
    let orCompositeType = _prefix "orCompositeType"
    /// <summary>
    /// Highest possible version of the required technology to use the learning object. IEEE LOM element 4.4.1.4.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeMaximumVersion"></see></summary>
    let orCompositeMaximumVersion = _prefix "orCompositeMaximumVersion"
    /// <summary>
    /// A particular term within a taxonomy. A taxon is a node that has a defined label or
    /// term. A taxon may also have an alphanumeric designation or identifier for standardized reference. Either or both the label and the entry may be used to designate a particular taxon. An ordered list of taxons creates a taxonomic path, i.e., "taxonomic stairway": this is a path from a more general to more specific entry in a classification.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Taxon"></see></summary>
    let Taxon = _prefix "Taxon"
    /// <summary>
    /// The identifier of the taxon, such as a number or letter combination provided by the source of the taxonomy. IEEE LOM element 9.2.2.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonId"></see></summary>
    let taxonId = _prefix "taxonId"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonEntry"></see>
    /// </summary>
    let taxonEntry = _prefix "taxonEntry"
    /// <summary>
    /// A particular term within a taxonomy which serves to classify a learning object. IEEE LOM element 9.2.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationTaxon"></see></summary>
    let classificationTaxon = _prefix "classificationTaxon"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonpathSource"></see>
    /// </summary>
    let taxonpathSource = _prefix "taxonpathSource"
    /// <summary>
    /// When grouping multiple requirements, the composite requirement is satisfied when one of the component requirements is satisfied, i.e., the logical connector is OR. IEEE LOM element 4.4.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#isCompositeOf"></see></summary>
    let isCompositeOf = _prefix "isCompositeOf"
    /// <summary>
    /// Date that this annotation was created. IEEE LOM element 8.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationDate"></see></summary>
    let annotationDate = _prefix "annotationDate"
    /// <summary>
    /// The date of the contribution. IEEE LOM element 3.2.3.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#contributionDateTime"></see></summary>
    let contributionDateTime = _prefix "contributionDateTime"
    /// <summary>
    /// The identification of and information about entities (i.e., people, organizations) contributing to this learning object. The entities shall be ordered as most relevant first. IEEE LOM element 3.2.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#contributionEntity"></see></summary>
    let contributionEntity = _prefix "contributionEntity"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#copyrightDescription"></see>
    /// </summary>
    let copyrightDescription = _prefix "copyrightDescription"
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#duration"></see>
    /// </summary>
    let duration = _prefix "duration"
    /// <summary>
    /// Email as it appears in the vCard
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#email"></see></summary>
    let email = _prefix "email"
    /// <summary>
    /// The target learning object that a relationship references. IEEE LOM element 7.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasRelatedResource"></see></summary>
    let hasRelatedResource = _prefix "hasRelatedResource"
    /// <summary>
    /// A globally unique label that identifies the target  learning object. IEEE LOM element 7.2.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasResourceIdentifier"></see></summary>
    let hasResourceIdentifier = _prefix "hasResourceIdentifier"
    /// <summary>
    /// Technical datatype(s) of (all the components of) this learning object. This information is used to identify the software needed to access the learning object. IEEE LOM element 4.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasTechnicalFormat"></see></summary>
    let hasTechnicalFormat = _prefix "hasTechnicalFormat"
    /// <summary>
    /// This predicate relates a lomIdentifier to the value of the identifier within the identification or cataloging scheme that designates or identifies a learning object or a learning object metadata record (a namespace specific string).  IEEE LOM element 1.1, 3.1, 7.2.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifierEntry"></see></summary>
    let identifierEntry = _prefix "identifierEntry"
    /// <summary>
    /// LangString values may include multiple semantically equivalent character strings, such as translations or alternative descriptions. Each of these is represented by a singleLangString.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#includesSingleLangString"></see></summary>
    let includesSingleLangString = _prefix "includesSingleLangString"
