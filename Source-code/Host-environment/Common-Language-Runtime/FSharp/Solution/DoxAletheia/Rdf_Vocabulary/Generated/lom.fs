namespace http.data.opendiscoveryspace.eu.lom_ontology_ods.owl.hash

open DoxAletheia.Rdf_Vocabulary

module lom =
    let _namespace_name = "http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#"
    /// <summary>
    /// Comments on the educational use of a learning object, including information on when and by whom the comments were created.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Annotation"></see></summary>
    let Annotation = Namespaced_IRI.parse _namespace_name "Annotation" |> NamespacedName

    /// <summary>
    /// Date time value in format: YYYY[-MM[-DD[Thh[:mm[:ss[.s[TZD]]]]]]]
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#dateTimeValue"></see></summary>
    let dateTimeValue =
        Namespaced_IRI.parse _namespace_name "dateTimeValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationDescription"></see>
    /// </summary>
    let annotationDescription =
        Namespaced_IRI.parse _namespace_name "annotationDescription" |> NamespacedName

    /// <summary>
    /// A vCard is a collection of one or more properties. A property is a uniquely named value. A set of properties can be grouped within a vCard. For example, the properties for a telephone number and comment can be grouped in order to preserve the coupling of the annotation with the telephone number. In addition to property groupings, a vC. versit  is developing a comprehensive family of PDI technologies based on open specifications and interoperability agreements to help meet this technology need.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#VCard"></see></summary>
    let VCard = Namespaced_IRI.parse _namespace_name "VCard" |> NamespacedName

    /// <summary>
    /// Entity (i.e., people, organization) that created this annotation. IEEE LOM element 8.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationEntity"></see></summary>
    let annotationEntity =
        Namespaced_IRI.parse _namespace_name "annotationEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#dateTimeDescription"></see>
    /// </summary>
    let dateTimeDescription =
        Namespaced_IRI.parse _namespace_name "dateTimeDescription" |> NamespacedName

    /// <summary>
    /// Description of where a learning object falls within a particular classification system. To define multiple classifications, there may be multiple instances of this category for a learning object.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Classification"></see></summary>
    let Classification =
        Namespaced_IRI.parse _namespace_name "Classification" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationDescription"></see>
    /// </summary>
    let classificationDescription =
        Namespaced_IRI.parse _namespace_name "classificationDescription" |> NamespacedName

    /// <summary>
    /// The purpose of classifying a learning object. IEEE LOM element 9.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationPurpose"></see></summary>
    let classificationPurpose =
        Namespaced_IRI.parse _namespace_name "classificationPurpose" |> NamespacedName

    /// <summary>
    /// Each of the possible semantically equivalent character strings of a langString.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LangString"></see></summary>
    let LangString = Namespaced_IRI.parse _namespace_name "LangString" |> NamespacedName

    /// <summary>
    /// Keywords and phrases descriptive of the learning object relative to the stated 9.1:Classification.Purpose of this specific classification, such as accessibility, security level, etc., most relevant first. IEEE LOM element 9.4
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationKeyword"></see></summary>
    let classificationKeyword =
        Namespaced_IRI.parse _namespace_name "classificationKeyword" |> NamespacedName

    /// <summary>
    /// A taxonomic path in a specific classification system. Each succeeding level is a refinement in the definition of the preceding level. There may be different paths, in the same or different classifications, which describe the same characteristic.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#TaxonPath"></see></summary>
    let TaxonPath = Namespaced_IRI.parse _namespace_name "TaxonPath" |> NamespacedName
    /// <summary>
    /// A taxonomic path in a specific classification system according to which a learning object is classified. IEEE LOM element 9.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonPath"></see></summary>
    let taxonPath = Namespaced_IRI.parse _namespace_name "taxonPath" |> NamespacedName

    /// <summary>
    /// Those entities (i.e., people, organizations) that have contributed to the state of this learning object during its life cycle (e.g., creation, edits, publication).
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Contribution"></see></summary>
    let Contribution =
        Namespaced_IRI.parse _namespace_name "Contribution" |> NamespacedName

    /// <summary>
    /// A point in time with accuracy at least as small as one second, as described by IEEE LOM in clause 8 (IEEE 1484.12.1-2002).
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#DateTime"></see></summary>
    let DateTime = Namespaced_IRI.parse _namespace_name "DateTime" |> NamespacedName
    /// <summary>
    /// An interval in time with accuracy at least as small as one second.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Duration"></see></summary>
    let Duration = Namespaced_IRI.parse _namespace_name "Duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#durationDescription"></see>
    /// </summary>
    let durationDescription =
        Namespaced_IRI.parse _namespace_name "durationDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#durationValue"></see>
    /// </summary>
    let durationValue =
        Namespaced_IRI.parse _namespace_name "durationValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Educational"></see>
    /// </summary>
    let Educational =
        Namespaced_IRI.parse _namespace_name "Educational" |> NamespacedName

    /// <summary>
    /// Principal user(s) for which this learning object was designed, most dominant first. IEEE LOM element 5.5.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalIntendedUserRole"></see></summary>
    let educationalIntendedUserRole =
        Namespaced_IRI.parse _namespace_name "educationalIntendedUserRole" |> NamespacedName

    /// <summary>
    /// The degree of interactivity characterizing this learning object. Interactivity in this context refers to the degree to which the learner can influence the aspect or behavior of the learning object. IEEE LOM element 5.3.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityLevel"></see></summary>
    let educationalInteractivityLevel =
        Namespaced_IRI.parse _namespace_name "educationalInteractivityLevel" |> NamespacedName

    /// <summary>
    /// The principal environment within which the learning and use of this learning object is intended to take place. IEEE LOM element 5.6.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalContext"></see></summary>
    let educationalContext =
        Namespaced_IRI.parse _namespace_name "educationalContext" |> NamespacedName

    /// <summary>
    /// The primary human language or languages used within this learning object to communicate to the intended user. If the learning object had no lingual content (as in the case of a picture of the Mona Lisa, for example), then the appropriate value for this data element would be "none". IEEE LOM element 1.3.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalLanguage"></see></summary>
    let educationalLanguage =
        Namespaced_IRI.parse _namespace_name "educationalLanguage" |> NamespacedName

    /// <summary>
    /// Predominant mode of learning supported by this learning object. IEEE LOM element 5.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityType"></see></summary>
    let educationalInteractivityType =
        Namespaced_IRI.parse _namespace_name "educationalInteractivityType" |> NamespacedName

    /// <summary>
    /// How hard it is to work with or through this learning object for the typical intended target audience. IEEE LOM element 5.8
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalDifficulty"></see></summary>
    let educationalDifficulty =
        Namespaced_IRI.parse _namespace_name "educationalDifficulty" |> NamespacedName

    /// <summary>
    /// The degree of conciseness of a learning object. The semantic density of a learning object may be estimated in terms of its size, span, or --in the case of self-timed resources such as audio or video-- duration. IEEE LOM element 5.4.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalSemanticDensity"></see></summary>
    let educationalSemanticDensity =
        Namespaced_IRI.parse _namespace_name "educationalSemanticDensity" |> NamespacedName

    /// <summary>
    /// Age of the typical intended user. IEEE LOM element 5.7.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalTypicalAgeRange"></see></summary>
    let educationalTypicalAgeRange =
        Namespaced_IRI.parse _namespace_name "educationalTypicalAgeRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalTypicalLearningTime"></see>
    /// </summary>
    let educationalTypicalLearningTime =
        Namespaced_IRI.parse _namespace_name "educationalTypicalLearningTime" |> NamespacedName

    /// <summary>
    /// A textual description of the content of this learning object. IEEE LOM element 1.4.
    /// Comments on how this learning object is to be used. IEEE LOM element 5.10
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// A globally unique label that identifies either a learning object or a learning object metadata record.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Identifier"></see></summary>
    let Identifier = Namespaced_IRI.parse _namespace_name "Identifier" |> NamespacedName

    /// <summary>
    /// This predicate relates a lomIdentifier to the name or designator of the identification or cataloging scheme used for its identification. It is usually a namespace scheme. IEEE LOM element 1.1, 3.1, 7.2.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifierCatalog"></see></summary>
    let identifierCatalog =
        Namespaced_IRI.parse _namespace_name "identifierCatalog" |> NamespacedName

    /// <summary>
    /// This predicate relates a singleLangString to the character string containing its textual description.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    /// Learning Object
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LearningObject"></see></summary>
    let LearningObject =
        Namespaced_IRI.parse _namespace_name "LearningObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleVersion"></see>
    /// </summary>
    let lifeCycleVersion =
        Namespaced_IRI.parse _namespace_name "lifeCycleVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LifeCycleContribution"></see>
    /// </summary>
    let LifeCycleContribution =
        Namespaced_IRI.parse _namespace_name "LifeCycleContribution" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleContribution"></see>
    /// </summary>
    let lifeCycleContribution =
        Namespaced_IRI.parse _namespace_name "lifeCycleContribution" |> NamespacedName

    /// <summary>
    /// A string that is used to access this learning object. It may be a location  (e.g., Universal Resource Locator), or a method that resolves to a location (e.g., Universal Resource Identifier). The first element of this list shall be the preferable location. IEEE LOM element 4.3.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalLocation"></see></summary>
    let technicalLocation =
        Namespaced_IRI.parse _namespace_name "technicalLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalDuration"></see>
    /// </summary>
    let technicalDuration =
        Namespaced_IRI.parse _namespace_name "technicalDuration" |> NamespacedName

    /// <summary>
    /// Description of where a learning object falls within a particular classification system. IEEE LOM element 9.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classification"></see></summary>
    let classification =
        Namespaced_IRI.parse _namespace_name "classification" |> NamespacedName

    /// <summary>
    /// Whether copyright or other restrictions apply to the use of this learning object. IEEE LOM element 6.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#copyrightAndOtherRestrictions"></see></summary>
    let copyrightAndOtherRestrictions =
        Namespaced_IRI.parse _namespace_name "copyrightAndOtherRestrictions" |> NamespacedName

    /// <summary>
    /// Whether use of the learning object requires payment. IEEE LOM element 6.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#cost"></see></summary>
    let cost = Namespaced_IRI.parse _namespace_name "cost" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#MetaMetadataContribution"></see>
    /// </summary>
    let MetaMetadataContribution =
        Namespaced_IRI.parse _namespace_name "MetaMetadataContribution" |> NamespacedName

    /// <summary>
    /// Those entities (i.e., people, organizations) that have contributed to the state of this learning object during its life cycle (e.g.,creation, edits, publication).
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataContribution"></see></summary>
    let metaMetadataContribution =
        Namespaced_IRI.parse _namespace_name "metaMetadataContribution" |> NamespacedName

    /// <summary>
    /// A globally unique label that identifies this metadata record. IEEE LOM element 3.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataIdentifier"></see></summary>
    let metaMetadataIdentifier =
        Namespaced_IRI.parse _namespace_name "metaMetadataIdentifier" |> NamespacedName

    /// <summary>
    /// The technical capabilities necessary for using a learning object. There can be multiple requirements, in which case all are required, i.e., the logical connector is AND.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#TechnicalRequirement"></see></summary>
    let TechnicalRequirement =
        Namespaced_IRI.parse _namespace_name "TechnicalRequirement" |> NamespacedName

    /// <summary>
    /// A technical capability necessary for using a learning object. IEEE LOM Element "4.4. Requirement".
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalRequirements"></see></summary>
    let technicalRequirements =
        Namespaced_IRI.parse _namespace_name "technicalRequirements" |> NamespacedName

    /// <summary>
    /// A concept which defines the relationship between a learning object and other learning objects, if any.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Relation"></see></summary>
    let Relation = Namespaced_IRI.parse _namespace_name "Relation" |> NamespacedName
    /// <summary>
    /// Relationship between a learning object and other learning objects, if any.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relation"></see></summary>
    let relation = Namespaced_IRI.parse _namespace_name "relation" |> NamespacedName
    /// <summary>
    /// A keyword or phrase describing the topic of this learning object. This data element should not be used for characteristics that can be described by other data elements. IEEE LOM element 1.5.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#keyword"></see></summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName
    /// <summary>
    /// Underlying organizational structure of this learning object. IEEE LOM element 1.7.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#structure"></see></summary>
    let structure = Namespaced_IRI.parse _namespace_name "structure" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalInstallationRemarks"></see>
    /// </summary>
    let technicalInstallationRemarks =
        Namespaced_IRI.parse _namespace_name "technicalInstallationRemarks" |> NamespacedName

    /// <summary>
    /// This category describes the key educational or pedagogic characteristics of this learning object. IEEE LOM element 5.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educational"></see></summary>
    let educational =
        Namespaced_IRI.parse _namespace_name "educational" |> NamespacedName

    /// <summary>
    /// The completion status or condition of this learning object. IEEE LOM element 2.2
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleStatus"></see></summary>
    let lifeCycleStatus =
        Namespaced_IRI.parse _namespace_name "lifeCycleStatus" |> NamespacedName

    /// <summary>
    /// This predicate represents the fact that a learning object has a label that identifies it. IEEE LOM element 1.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    /// The functional granularity of this learning object. IEEE LOM element 1.8.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#aggregationLevel"></see></summary>
    let aggregationLevel =
        Namespaced_IRI.parse _namespace_name "aggregationLevel" |> NamespacedName

    /// <summary>
    /// The size of the digital learning object in bytes (not Mbytes, GB, etc.). The size is represented as a decimal value. This data element shall refer to the actual size of this learning object. If the learning object is compressed, then this data element shall refer to the uncompressed size. IEEE LOM element 4.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalSize"></see></summary>
    let technicalSize =
        Namespaced_IRI.parse _namespace_name "technicalSize" |> NamespacedName

    /// <summary>
    /// Language of this metadata instance. This is the default language for all LangString values in this metadata instance. If a value for this data element is not present in a metadata instance, then there is no default language for LangString values. IEEE LOM element 3.4.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataLanguage"></see></summary>
    let metaMetadataLanguage =
        Namespaced_IRI.parse _namespace_name "metaMetadataLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#otherPlatformRequirements"></see>
    /// </summary>
    let otherPlatformRequirements =
        Namespaced_IRI.parse _namespace_name "otherPlatformRequirements" |> NamespacedName

    /// <summary>
    /// The time, culture, geography or region to which this learning object applies.
    /// The extent or scope of the content of the learning object. Coverage will typically include spatial location (a place name or geographic coordinates), temporal period (a period label, date, or date range) or jurisdiction (such as a named administrative entity). Recommended best practice is to select a value from a controlled vocabulary (for example, the Thesaurus of Geographic Names [TGN]) and that, where appropriate, named places or time periods be used in preference to numeric identifiers such as sets of coordinates or date ranges. IEEE LOM element 1.6.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#coverage"></see></summary>
    let coverage = Namespaced_IRI.parse _namespace_name "coverage" |> NamespacedName

    /// <summary>
    /// The name and version of the authoritative specification used to create this metadata instance. IEEE LOM element 3.3.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metadataSchema"></see></summary>
    let metadataSchema =
        Namespaced_IRI.parse _namespace_name "metadataSchema" |> NamespacedName

    /// <summary>
    /// Comments on the educational use of a learning object, containing information on when and by whom the comments were created. This category enables educators to share their assessments of learning objects, suggestions for use, etc. IEEE LOM element 8.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotation"></see></summary>
    let annotation = Namespaced_IRI.parse _namespace_name "annotation" |> NamespacedName

    /// <summary>
    /// Kind of contribution. IEEE LOM element 2.3.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleContributionRole"></see></summary>
    let lifeCycleContributionRole =
        Namespaced_IRI.parse _namespace_name "lifeCycleContributionRole" |> NamespacedName

    /// <summary>
    /// Kind of contribution. IEEE LOM element 3.2.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataContributionRole"></see></summary>
    let metaMetadataContributionRole =
        Namespaced_IRI.parse _namespace_name "metaMetadataContributionRole" |> NamespacedName

    /// <summary>
    /// Nature of the relationship between a learning object and the target learning object, identified by 7.2:Relation.Resource. IEEE LOM element 7.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relationKind"></see></summary>
    let relationKind =
        Namespaced_IRI.parse _namespace_name "relationKind" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relatedResourceDescription"></see>
    /// </summary>
    let relatedResourceDescription =
        Namespaced_IRI.parse _namespace_name "relatedResourceDescription" |> NamespacedName

    /// <summary>
    /// A technical capability necessary for using a learning object.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#SingleTechnicalRequirement"></see></summary>
    let SingleTechnicalRequirement =
        Namespaced_IRI.parse _namespace_name "SingleTechnicalRequirement" |> NamespacedName

    /// <summary>
    /// Lowest possible version of the required technology to use the learning object. IEEE LOM element 4.4.1.3.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeMinimumVersion"></see></summary>
    let orCompositeMinimumVersion =
        Namespaced_IRI.parse _namespace_name "orCompositeMinimumVersion" |> NamespacedName

    /// <summary>
    /// Name of the required technology to use a learning object. IEEE LOM element 4.4.1.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeName"></see></summary>
    let orCompositeName =
        Namespaced_IRI.parse _namespace_name "orCompositeName" |> NamespacedName

    /// <summary>
    /// The technology required to use this learning object, e.g., hardware, software, network, etc. IEEE LOM element 4.4.1.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeType"></see></summary>
    let orCompositeType =
        Namespaced_IRI.parse _namespace_name "orCompositeType" |> NamespacedName

    /// <summary>
    /// Highest possible version of the required technology to use the learning object. IEEE LOM element 4.4.1.4.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeMaximumVersion"></see></summary>
    let orCompositeMaximumVersion =
        Namespaced_IRI.parse _namespace_name "orCompositeMaximumVersion" |> NamespacedName

    /// <summary>
    /// A particular term within a taxonomy. A taxon is a node that has a defined label or
    /// term. A taxon may also have an alphanumeric designation or identifier for standardized reference. Either or both the label and the entry may be used to designate a particular taxon. An ordered list of taxons creates a taxonomic path, i.e., "taxonomic stairway": this is a path from a more general to more specific entry in a classification.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Taxon"></see></summary>
    let Taxon = Namespaced_IRI.parse _namespace_name "Taxon" |> NamespacedName
    /// <summary>
    /// The identifier of the taxon, such as a number or letter combination provided by the source of the taxonomy. IEEE LOM element 9.2.2.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonId"></see></summary>
    let taxonId = Namespaced_IRI.parse _namespace_name "taxonId" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonEntry"></see>
    /// </summary>
    let taxonEntry = Namespaced_IRI.parse _namespace_name "taxonEntry" |> NamespacedName

    /// <summary>
    /// A particular term within a taxonomy which serves to classify a learning object. IEEE LOM element 9.2.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationTaxon"></see></summary>
    let classificationTaxon =
        Namespaced_IRI.parse _namespace_name "classificationTaxon" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonpathSource"></see>
    /// </summary>
    let taxonpathSource =
        Namespaced_IRI.parse _namespace_name "taxonpathSource" |> NamespacedName

    /// <summary>
    /// When grouping multiple requirements, the composite requirement is satisfied when one of the component requirements is satisfied, i.e., the logical connector is OR. IEEE LOM element 4.4.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#isCompositeOf"></see></summary>
    let isCompositeOf =
        Namespaced_IRI.parse _namespace_name "isCompositeOf" |> NamespacedName

    /// <summary>
    /// Date that this annotation was created. IEEE LOM element 8.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationDate"></see></summary>
    let annotationDate =
        Namespaced_IRI.parse _namespace_name "annotationDate" |> NamespacedName

    /// <summary>
    /// The date of the contribution. IEEE LOM element 3.2.3.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#contributionDateTime"></see></summary>
    let contributionDateTime =
        Namespaced_IRI.parse _namespace_name "contributionDateTime" |> NamespacedName

    /// <summary>
    /// The identification of and information about entities (i.e., people, organizations) contributing to this learning object. The entities shall be ordered as most relevant first. IEEE LOM element 3.2.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#contributionEntity"></see></summary>
    let contributionEntity =
        Namespaced_IRI.parse _namespace_name "contributionEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#copyrightDescription"></see>
    /// </summary>
    let copyrightDescription =
        Namespaced_IRI.parse _namespace_name "copyrightDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#duration"></see>
    /// </summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    /// Email as it appears in the vCard
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#email"></see></summary>
    let email = Namespaced_IRI.parse _namespace_name "email" |> NamespacedName

    /// <summary>
    /// The target learning object that a relationship references. IEEE LOM element 7.2.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasRelatedResource"></see></summary>
    let hasRelatedResource =
        Namespaced_IRI.parse _namespace_name "hasRelatedResource" |> NamespacedName

    /// <summary>
    /// A globally unique label that identifies the target  learning object. IEEE LOM element 7.2.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasResourceIdentifier"></see></summary>
    let hasResourceIdentifier =
        Namespaced_IRI.parse _namespace_name "hasResourceIdentifier" |> NamespacedName

    /// <summary>
    /// Technical datatype(s) of (all the components of) this learning object. This information is used to identify the software needed to access the learning object. IEEE LOM element 4.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasTechnicalFormat"></see></summary>
    let hasTechnicalFormat =
        Namespaced_IRI.parse _namespace_name "hasTechnicalFormat" |> NamespacedName

    /// <summary>
    /// This predicate relates a lomIdentifier to the value of the identifier within the identification or cataloging scheme that designates or identifies a learning object or a learning object metadata record (a namespace specific string).  IEEE LOM element 1.1, 3.1, 7.2.1.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifierEntry"></see></summary>
    let identifierEntry =
        Namespaced_IRI.parse _namespace_name "identifierEntry" |> NamespacedName

    /// <summary>
    /// LangString values may include multiple semantically equivalent character strings, such as translations or alternative descriptions. Each of these is represented by a singleLangString.
    /// <see href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#includesSingleLangString"></see></summary>
    let includesSingleLangString =
        Namespaced_IRI.parse _namespace_name "includesSingleLangString" |> NamespacedName
