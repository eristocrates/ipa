namespace http.data.opendiscoveryspace.eu.lom_ontology_ods.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lom =
    let _namespace_iri = Namespace_Iri lom |> NamespaceIRI
    /// <summary>
    ///   <para>lom:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"-Version 1.0: covers a complete mapping of IEEE LOM to Linked Open Data"</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#</seealso>
    let _prefix_iri = Prefixed_Name(lom, "") |> PrefixedName
    /// <summary>
    ///   <para>lom:Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Comments on the educational use of a learning object, including information on when and by whom the comments were created."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Annotation">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Annotation</seealso>
    let Annotation = Prefixed_Name(lom, "Annotation") |> PrefixedName
    /// <summary>
    ///   <para>lom:Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Description of where a learning object falls within a particular classification system. To define multiple classifications, there may be multiple instances of this category for a learning object."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Classification">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Classification</seealso>
    let Classification = Prefixed_Name(lom, "Classification") |> PrefixedName
    /// <summary>
    ///   <para>lom:Contribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Those entities (i.e., people, organizations) that have contributed to the state of this learning object during its life cycle (e.g., creation, edits, publication)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Contribution">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Contribution</seealso>
    let Contribution = Prefixed_Name(lom, "Contribution") |> PrefixedName
    /// <summary>
    ///   <para>lom:DateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A point in time with accuracy at least as small as one second, as described by IEEE LOM in clause 8 (IEEE 1484.12.1-2002)."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#DateTime">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#DateTime</seealso>
    let DateTime = Prefixed_Name(lom, "DateTime") |> PrefixedName
    /// <summary>
    ///   <para>lom:Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An interval in time with accuracy at least as small as one second."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Duration">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Duration</seealso>
    let Duration = Prefixed_Name(lom, "Duration") |> PrefixedName
    /// <summary>
    ///   <para>lom:Educational</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Educational">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Educational</seealso>
    let Educational = Prefixed_Name(lom, "Educational") |> PrefixedName
    /// <summary>
    ///   <para>lom:Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A globally unique label that identifies either a learning object or a learning object metadata record."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Identifier">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Identifier</seealso>
    let Identifier = Prefixed_Name(lom, "Identifier") |> PrefixedName
    /// <summary>
    ///   <para>lom:LangString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Each of the possible semantically equivalent character strings of a langString."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LangString">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LangString</seealso>
    let LangString = Prefixed_Name(lom, "LangString") |> PrefixedName
    /// <summary>
    ///   <para>lom:LearningObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Learning Object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LearningObject">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LearningObject</seealso>
    let LearningObject = Prefixed_Name(lom, "LearningObject") |> PrefixedName

    /// <summary>
    ///   <para>lom:LifeCycleContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LifeCycleContribution">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#LifeCycleContribution</seealso>
    let LifeCycleContribution =
        Prefixed_Name(lom, "LifeCycleContribution") |> PrefixedName

    /// <summary>
    ///   <para>lom:MetaMetadataContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#MetaMetadataContribution">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#MetaMetadataContribution</seealso>
    let MetaMetadataContribution =
        Prefixed_Name(lom, "MetaMetadataContribution") |> PrefixedName

    /// <summary>
    ///   <para>lom:Relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concept which defines the relationship between a learning object and other learning objects, if any."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Relation">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Relation</seealso>
    let Relation = Prefixed_Name(lom, "Relation") |> PrefixedName

    /// <summary>
    ///   <para>lom:SingleTechnicalRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A technical capability necessary for using a learning object."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#SingleTechnicalRequirement">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#SingleTechnicalRequirement</seealso>
    let SingleTechnicalRequirement =
        Prefixed_Name(lom, "SingleTechnicalRequirement") |> PrefixedName

    /// <summary>
    ///   <para>lom:Taxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular term within a taxonomy. A taxon is a node that has a defined label or
    /// term. A taxon may also have an alphanumeric designation or identifier for standardized reference. Either or both the label and the entry may be used to designate a particular taxon. An ordered list of taxons creates a taxonomic path, i.e., "taxonomic stairway": this is a path from a more general to more specific entry in a classification."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Taxon">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#Taxon</seealso>
    let Taxon = Prefixed_Name(lom, "Taxon") |> PrefixedName
    /// <summary>
    ///   <para>lom:TaxonPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A taxonomic path in a specific classification system. Each succeeding level is a refinement in the definition of the preceding level. There may be different paths, in the same or different classifications, which describe the same characteristic."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#TaxonPath">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#TaxonPath</seealso>
    let TaxonPath = Prefixed_Name(lom, "TaxonPath") |> PrefixedName

    /// <summary>
    ///   <para>lom:TechnicalRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The technical capabilities necessary for using a learning object. There can be multiple requirements, in which case all are required, i.e., the logical connector is AND."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#TechnicalRequirement">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#TechnicalRequirement</seealso>
    let TechnicalRequirement =
        Prefixed_Name(lom, "TechnicalRequirement") |> PrefixedName

    /// <summary>
    ///   <para>lom:VCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A vCard is a collection of one or more properties. A property is a uniquely named value. A set of properties can be grouped within a vCard. For example, the properties for a telephone number and comment can be grouped in order to preserve the coupling of the annotation with the telephone number. In addition to property groupings, a vC. versit  is developing a comprehensive family of PDI technologies based on open specifications and interoperability agreements to help meet this technology need."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#VCard">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#VCard</seealso>
    let VCard = Prefixed_Name(lom, "VCard") |> PrefixedName
    /// <summary>
    ///   <para>lom:aggregationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The functional granularity of this learning object. IEEE LOM element 1.8."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#aggregationLevel">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#aggregationLevel</seealso>
    let aggregationLevel = Prefixed_Name(lom, "aggregationLevel") |> PrefixedName
    /// <summary>
    ///   <para>lom:annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Comments on the educational use of a learning object, containing information on when and by whom the comments were created. This category enables educators to share their assessments of learning objects, suggestions for use, etc. IEEE LOM element 8."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotation">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotation</seealso>
    let annotation = Prefixed_Name(lom, "annotation") |> PrefixedName
    /// <summary>
    ///   <para>lom:annotationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Date that this annotation was created. IEEE LOM element 8.2."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationDate">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationDate</seealso>
    let annotationDate = Prefixed_Name(lom, "annotationDate") |> PrefixedName

    /// <summary>
    ///   <para>lom:annotationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationDescription">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationDescription</seealso>
    let annotationDescription =
        Prefixed_Name(lom, "annotationDescription") |> PrefixedName

    /// <summary>
    ///   <para>lom:annotationEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Entity (i.e., people, organization) that created this annotation. IEEE LOM element 8.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationEntity">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#annotationEntity</seealso>
    let annotationEntity = Prefixed_Name(lom, "annotationEntity") |> PrefixedName
    /// <summary>
    ///   <para>lom:classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Description of where a learning object falls within a particular classification system. IEEE LOM element 9."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classification">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classification</seealso>
    let classification = Prefixed_Name(lom, "classification") |> PrefixedName

    /// <summary>
    ///   <para>lom:classificationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationDescription">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationDescription</seealso>
    let classificationDescription =
        Prefixed_Name(lom, "classificationDescription") |> PrefixedName

    /// <summary>
    ///   <para>lom:classificationKeyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Keywords and phrases descriptive of the learning object relative to the stated 9.1:Classification.Purpose of this specific classification, such as accessibility, security level, etc., most relevant first. IEEE LOM element 9.4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationKeyword">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationKeyword</seealso>
    let classificationKeyword =
        Prefixed_Name(lom, "classificationKeyword") |> PrefixedName

    /// <summary>
    ///   <para>lom:classificationPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The purpose of classifying a learning object. IEEE LOM element 9.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationPurpose">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationPurpose</seealso>
    let classificationPurpose =
        Prefixed_Name(lom, "classificationPurpose") |> PrefixedName

    /// <summary>
    ///   <para>lom:classificationTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A particular term within a taxonomy which serves to classify a learning object. IEEE LOM element 9.2.2."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationTaxon">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#classificationTaxon</seealso>
    let classificationTaxon = Prefixed_Name(lom, "classificationTaxon") |> PrefixedName

    /// <summary>
    ///   <para>lom:contributionDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The date of the contribution. IEEE LOM element 3.2.3."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#contributionDateTime">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#contributionDateTime</seealso>
    let contributionDateTime =
        Prefixed_Name(lom, "contributionDateTime") |> PrefixedName

    /// <summary>
    ///   <para>lom:contributionEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The identification of and information about entities (i.e., people, organizations) contributing to this learning object. The entities shall be ordered as most relevant first. IEEE LOM element 3.2.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#contributionEntity">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#contributionEntity</seealso>
    let contributionEntity = Prefixed_Name(lom, "contributionEntity") |> PrefixedName

    /// <summary>
    ///   <para>lom:copyrightAndOtherRestrictions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether copyright or other restrictions apply to the use of this learning object. IEEE LOM element 6.2."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#copyrightAndOtherRestrictions">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#copyrightAndOtherRestrictions</seealso>
    let copyrightAndOtherRestrictions =
        Prefixed_Name(lom, "copyrightAndOtherRestrictions") |> PrefixedName

    /// <summary>
    ///   <para>lom:copyrightDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#copyrightDescription">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#copyrightDescription</seealso>
    let copyrightDescription =
        Prefixed_Name(lom, "copyrightDescription") |> PrefixedName

    /// <summary>
    ///   <para>lom:cost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether use of the learning object requires payment. IEEE LOM element 6.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#cost">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#cost</seealso>
    let cost = Prefixed_Name(lom, "cost") |> PrefixedName
    /// <summary>
    ///   <para>lom:coverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The time, culture, geography or region to which this learning object applies.
    /// The extent or scope of the content of the learning object. Coverage will typically include spatial location (a place name or geographic coordinates), temporal period (a period label, date, or date range) or jurisdiction (such as a named administrative entity). Recommended best practice is to select a value from a controlled vocabulary (for example, the Thesaurus of Geographic Names [TGN]) and that, where appropriate, named places or time periods be used in preference to numeric identifiers such as sets of coordinates or date ranges. IEEE LOM element 1.6."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#coverage">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#coverage</seealso>
    let coverage = Prefixed_Name(lom, "coverage") |> PrefixedName
    /// <summary>
    ///   <para>lom:dateTimeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#dateTimeDescription">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#dateTimeDescription</seealso>
    let dateTimeDescription = Prefixed_Name(lom, "dateTimeDescription") |> PrefixedName
    /// <summary>
    ///   <para>lom:dateTimeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date time value in format: YYYY[-MM[-DD[Thh[:mm[:ss[.s[TZD]]]]]]]"</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#dateTimeValue">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#dateTimeValue</seealso>
    let dateTimeValue = Prefixed_Name(lom, "dateTimeValue") |> PrefixedName
    /// <summary>
    ///   <para>lom:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A textual description of the content of this learning object. IEEE LOM element 1.4."</para>
    ///   <para>"Comments on how this learning object is to be used. IEEE LOM element 5.10"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#description">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#description</seealso>
    let description = Prefixed_Name(lom, "description") |> PrefixedName
    /// <summary>
    ///   <para>lom:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#duration">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#duration</seealso>
    let duration = Prefixed_Name(lom, "duration") |> PrefixedName
    /// <summary>
    ///   <para>lom:durationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#durationDescription">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#durationDescription</seealso>
    let durationDescription = Prefixed_Name(lom, "durationDescription") |> PrefixedName
    /// <summary>
    ///   <para>lom:durationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#durationValue">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#durationValue</seealso>
    let durationValue = Prefixed_Name(lom, "durationValue") |> PrefixedName
    /// <summary>
    ///   <para>lom:educational</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This category describes the key educational or pedagogic characteristics of this learning object. IEEE LOM element 5."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educational">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educational</seealso>
    let educational = Prefixed_Name(lom, "educational") |> PrefixedName
    /// <summary>
    ///   <para>lom:educationalContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The principal environment within which the learning and use of this learning object is intended to take place. IEEE LOM element 5.6."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalContext">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalContext</seealso>
    let educationalContext = Prefixed_Name(lom, "educationalContext") |> PrefixedName

    /// <summary>
    ///   <para>lom:educationalDifficulty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"How hard it is to work with or through this learning object for the typical intended target audience. IEEE LOM element 5.8"</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalDifficulty">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalDifficulty</seealso>
    let educationalDifficulty =
        Prefixed_Name(lom, "educationalDifficulty") |> PrefixedName

    /// <summary>
    ///   <para>lom:educationalIntendedUserRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Principal user(s) for which this learning object was designed, most dominant first. IEEE LOM element 5.5."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalIntendedUserRole">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalIntendedUserRole</seealso>
    let educationalIntendedUserRole =
        Prefixed_Name(lom, "educationalIntendedUserRole") |> PrefixedName

    /// <summary>
    ///   <para>lom:educationalInteractivityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The degree of interactivity characterizing this learning object. Interactivity in this context refers to the degree to which the learner can influence the aspect or behavior of the learning object. IEEE LOM element 5.3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityLevel">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityLevel</seealso>
    let educationalInteractivityLevel =
        Prefixed_Name(lom, "educationalInteractivityLevel") |> PrefixedName

    /// <summary>
    ///   <para>lom:educationalInteractivityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Predominant mode of learning supported by this learning object. IEEE LOM element 5.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityType">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalInteractivityType</seealso>
    let educationalInteractivityType =
        Prefixed_Name(lom, "educationalInteractivityType") |> PrefixedName

    /// <summary>
    ///   <para>lom:educationalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The primary human language or languages used within this learning object to communicate to the intended user. If the learning object had no lingual content (as in the case of a picture of the Mona Lisa, for example), then the appropriate value for this data element would be "none". IEEE LOM element 1.3."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalLanguage">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalLanguage</seealso>
    let educationalLanguage = Prefixed_Name(lom, "educationalLanguage") |> PrefixedName

    /// <summary>
    ///   <para>lom:educationalSemanticDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The degree of conciseness of a learning object. The semantic density of a learning object may be estimated in terms of its size, span, or --in the case of self-timed resources such as audio or video-- duration. IEEE LOM element 5.4."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalSemanticDensity">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalSemanticDensity</seealso>
    let educationalSemanticDensity =
        Prefixed_Name(lom, "educationalSemanticDensity") |> PrefixedName

    /// <summary>
    ///   <para>lom:educationalTypicalAgeRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Age of the typical intended user. IEEE LOM element 5.7."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalTypicalAgeRange">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalTypicalAgeRange</seealso>
    let educationalTypicalAgeRange =
        Prefixed_Name(lom, "educationalTypicalAgeRange") |> PrefixedName

    /// <summary>
    ///   <para>lom:educationalTypicalLearningTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalTypicalLearningTime">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#educationalTypicalLearningTime</seealso>
    let educationalTypicalLearningTime =
        Prefixed_Name(lom, "educationalTypicalLearningTime") |> PrefixedName

    /// <summary>
    ///   <para>lom:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Email as it appears in the vCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#email">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#email</seealso>
    let email = Prefixed_Name(lom, "email") |> PrefixedName
    /// <summary>
    ///   <para>lom:hasRelatedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The target learning object that a relationship references. IEEE LOM element 7.2."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasRelatedResource">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasRelatedResource</seealso>
    let hasRelatedResource = Prefixed_Name(lom, "hasRelatedResource") |> PrefixedName

    /// <summary>
    ///   <para>lom:hasResourceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A globally unique label that identifies the target  learning object. IEEE LOM element 7.2.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasResourceIdentifier">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasResourceIdentifier</seealso>
    let hasResourceIdentifier =
        Prefixed_Name(lom, "hasResourceIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>lom:hasTechnicalFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Technical datatype(s) of (all the components of) this learning object. This information is used to identify the software needed to access the learning object. IEEE LOM element 4.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasTechnicalFormat">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasTechnicalFormat</seealso>
    let hasTechnicalFormat = Prefixed_Name(lom, "hasTechnicalFormat") |> PrefixedName
    /// <summary>
    ///   <para>lom:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This predicate relates a singleLangString to the character string containing its textual description."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasValue">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#hasValue</seealso>
    let hasValue = Prefixed_Name(lom, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>lom:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"This predicate represents the fact that a learning object has a label that identifies it. IEEE LOM element 1.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifier">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifier</seealso>
    let identifier = Prefixed_Name(lom, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>lom:identifierCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This predicate relates a lomIdentifier to the name or designator of the identification or cataloging scheme used for its identification. It is usually a namespace scheme. IEEE LOM element 1.1, 3.1, 7.2.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifierCatalog">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifierCatalog</seealso>
    let identifierCatalog = Prefixed_Name(lom, "identifierCatalog") |> PrefixedName
    /// <summary>
    ///   <para>lom:identifierEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This predicate relates a lomIdentifier to the value of the identifier within the identification or cataloging scheme that designates or identifies a learning object or a learning object metadata record (a namespace specific string).  IEEE LOM element 1.1, 3.1, 7.2.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifierEntry">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#identifierEntry</seealso>
    let identifierEntry = Prefixed_Name(lom, "identifierEntry") |> PrefixedName

    /// <summary>
    ///   <para>lom:includesSingleLangString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"LangString values may include multiple semantically equivalent character strings, such as translations or alternative descriptions. Each of these is represented by a singleLangString."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#includesSingleLangString">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#includesSingleLangString</seealso>
    let includesSingleLangString =
        Prefixed_Name(lom, "includesSingleLangString") |> PrefixedName

    /// <summary>
    ///   <para>lom:isCompositeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"When grouping multiple requirements, the composite requirement is satisfied when one of the component requirements is satisfied, i.e., the logical connector is OR. IEEE LOM element 4.4.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#isCompositeOf">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#isCompositeOf</seealso>
    let isCompositeOf = Prefixed_Name(lom, "isCompositeOf") |> PrefixedName
    /// <summary>
    ///   <para>lom:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A keyword or phrase describing the topic of this learning object. This data element should not be used for characteristics that can be described by other data elements. IEEE LOM element 1.5."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#keyword">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#keyword</seealso>
    let keyword = Prefixed_Name(lom, "keyword") |> PrefixedName

    /// <summary>
    ///   <para>lom:lifeCycleContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleContribution">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleContribution</seealso>
    let lifeCycleContribution =
        Prefixed_Name(lom, "lifeCycleContribution") |> PrefixedName

    /// <summary>
    ///   <para>lom:lifeCycleContributionRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Kind of contribution. IEEE LOM element 2.3.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleContributionRole">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleContributionRole</seealso>
    let lifeCycleContributionRole =
        Prefixed_Name(lom, "lifeCycleContributionRole") |> PrefixedName

    /// <summary>
    ///   <para>lom:lifeCycleStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The completion status or condition of this learning object. IEEE LOM element 2.2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleStatus">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleStatus</seealso>
    let lifeCycleStatus = Prefixed_Name(lom, "lifeCycleStatus") |> PrefixedName
    /// <summary>
    ///   <para>lom:lifeCycleVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleVersion">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#lifeCycleVersion</seealso>
    let lifeCycleVersion = Prefixed_Name(lom, "lifeCycleVersion") |> PrefixedName

    /// <summary>
    ///   <para>lom:metaMetadataContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Those entities (i.e., people, organizations) that have contributed to the state of this learning object during its life cycle (e.g.,creation, edits, publication)."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataContribution">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataContribution</seealso>
    let metaMetadataContribution =
        Prefixed_Name(lom, "metaMetadataContribution") |> PrefixedName

    /// <summary>
    ///   <para>lom:metaMetadataContributionRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Kind of contribution. IEEE LOM element 3.2.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataContributionRole">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataContributionRole</seealso>
    let metaMetadataContributionRole =
        Prefixed_Name(lom, "metaMetadataContributionRole") |> PrefixedName

    /// <summary>
    ///   <para>lom:metaMetadataIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A globally unique label that identifies this metadata record. IEEE LOM element 3.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataIdentifier">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataIdentifier</seealso>
    let metaMetadataIdentifier =
        Prefixed_Name(lom, "metaMetadataIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>lom:metaMetadataLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Language of this metadata instance. This is the default language for all LangString values in this metadata instance. If a value for this data element is not present in a metadata instance, then there is no default language for LangString values. IEEE LOM element 3.4."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataLanguage">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metaMetadataLanguage</seealso>
    let metaMetadataLanguage =
        Prefixed_Name(lom, "metaMetadataLanguage") |> PrefixedName

    /// <summary>
    ///   <para>lom:metadataSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name and version of the authoritative specification used to create this metadata instance. IEEE LOM element 3.3."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metadataSchema">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#metadataSchema</seealso>
    let metadataSchema = Prefixed_Name(lom, "metadataSchema") |> PrefixedName

    /// <summary>
    ///   <para>lom:orCompositeMaximumVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Highest possible version of the required technology to use the learning object. IEEE LOM element 4.4.1.4."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeMaximumVersion">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeMaximumVersion</seealso>
    let orCompositeMaximumVersion =
        Prefixed_Name(lom, "orCompositeMaximumVersion") |> PrefixedName

    /// <summary>
    ///   <para>lom:orCompositeMinimumVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Lowest possible version of the required technology to use the learning object. IEEE LOM element 4.4.1.3."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeMinimumVersion">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeMinimumVersion</seealso>
    let orCompositeMinimumVersion =
        Prefixed_Name(lom, "orCompositeMinimumVersion") |> PrefixedName

    /// <summary>
    ///   <para>lom:orCompositeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name of the required technology to use a learning object. IEEE LOM element 4.4.1.2."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeName">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeName</seealso>
    let orCompositeName = Prefixed_Name(lom, "orCompositeName") |> PrefixedName
    /// <summary>
    ///   <para>lom:orCompositeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The technology required to use this learning object, e.g., hardware, software, network, etc. IEEE LOM element 4.4.1.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeType">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#orCompositeType</seealso>
    let orCompositeType = Prefixed_Name(lom, "orCompositeType") |> PrefixedName

    /// <summary>
    ///   <para>lom:otherPlatformRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#otherPlatformRequirements">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#otherPlatformRequirements</seealso>
    let otherPlatformRequirements =
        Prefixed_Name(lom, "otherPlatformRequirements") |> PrefixedName

    /// <summary>
    ///   <para>lom:relatedResourceDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relatedResourceDescription">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relatedResourceDescription</seealso>
    let relatedResourceDescription =
        Prefixed_Name(lom, "relatedResourceDescription") |> PrefixedName

    /// <summary>
    ///   <para>lom:relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a learning object and other learning objects, if any."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relation">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relation</seealso>
    let relation = Prefixed_Name(lom, "relation") |> PrefixedName
    /// <summary>
    ///   <para>lom:relationKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Nature of the relationship between a learning object and the target learning object, identified by 7.2:Relation.Resource. IEEE LOM element 7.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relationKind">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#relationKind</seealso>
    let relationKind = Prefixed_Name(lom, "relationKind") |> PrefixedName
    /// <summary>
    ///   <para>lom:structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Underlying organizational structure of this learning object. IEEE LOM element 1.7."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#structure">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#structure</seealso>
    let structure = Prefixed_Name(lom, "structure") |> PrefixedName
    /// <summary>
    ///   <para>lom:taxonEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonEntry">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonEntry</seealso>
    let taxonEntry = Prefixed_Name(lom, "taxonEntry") |> PrefixedName
    /// <summary>
    ///   <para>lom:taxonId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The identifier of the taxon, such as a number or letter combination provided by the source of the taxonomy. IEEE LOM element 9.2.2.1."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonId">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonId</seealso>
    let taxonId = Prefixed_Name(lom, "taxonId") |> PrefixedName
    /// <summary>
    ///   <para>lom:taxonPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A taxonomic path in a specific classification system according to which a learning object is classified. IEEE LOM element 9.2."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonPath">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonPath</seealso>
    let taxonPath = Prefixed_Name(lom, "taxonPath") |> PrefixedName
    /// <summary>
    ///   <para>lom:taxonpathSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonpathSource">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#taxonpathSource</seealso>
    let taxonpathSource = Prefixed_Name(lom, "taxonpathSource") |> PrefixedName
    /// <summary>
    ///   <para>lom:technicalDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalDuration">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalDuration</seealso>
    let technicalDuration = Prefixed_Name(lom, "technicalDuration") |> PrefixedName

    /// <summary>
    ///   <para>lom:technicalInstallationRemarks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalInstallationRemarks">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalInstallationRemarks</seealso>
    let technicalInstallationRemarks =
        Prefixed_Name(lom, "technicalInstallationRemarks") |> PrefixedName

    /// <summary>
    ///   <para>lom:technicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A string that is used to access this learning object. It may be a location  (e.g., Universal Resource Locator), or a method that resolves to a location (e.g., Universal Resource Identifier). The first element of this list shall be the preferable location. IEEE LOM element 4.3."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalLocation">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalLocation</seealso>
    let technicalLocation = Prefixed_Name(lom, "technicalLocation") |> PrefixedName

    /// <summary>
    ///   <para>lom:technicalRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A technical capability necessary for using a learning object. IEEE LOM Element "4.4. Requirement"."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalRequirements">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalRequirements</seealso>
    let technicalRequirements =
        Prefixed_Name(lom, "technicalRequirements") |> PrefixedName

    /// <summary>
    ///   <para>lom:technicalSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The size of the digital learning object in bytes (not Mbytes, GB, etc.). The size is represented as a decimal value. This data element shall refer to the actual size of this learning object. If the learning object is compressed, then this data element shall refer to the uncompressed size. IEEE LOM element 4.2."</para>
    /// </remarks>
    /// <seealso href="http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalSize">http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#technicalSize</seealso>
    let technicalSize = Prefixed_Name(lom, "technicalSize") |> PrefixedName
