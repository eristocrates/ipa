namespace http.purl.org.spar.cito.slash

open DoxAletheia.Rdf_Vocabulary

module cito =
    let _namespace_name = "http://purl.org/spar/cito/"

    /// <summary>
    ///   <see href="http://purl.org/spar/cito/2018-02-12"></see>
    /// </summary>
    let ``_2018-02-12`` =
        Namespaced_IRI.parse _namespace_name "2018-02-12" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/cito/2018-02-16"></see>
    /// </summary>
    let ``_2018-02-16`` =
        Namespaced_IRI.parse _namespace_name "2018-02-16" |> NamespacedName

    /// <summary>
    /// A citation in which at least one author from each of the citing and the cited entities is affiliated with the same academic institution.
    ///
    /// In particular, like the ancestor class cito:Citation, cito:AffiliationSelfCitation and its accompanying object properties cito:hasCitingEntity, cito:hasCitedEntity and cito:hasCitationCharacterization can be employed to reify direct citation statements made using the CiTO citation object property cito:cites or one of its sub-properties, accompanied by an additional statement using cito:sharesAuthorInstitutionWith for linking the citing paper and the cited paper.
    ///
    /// For example, the following cito:AffiliationSelfCitation resource
    ///
    ///      :thisCitation a cito:AffiliationSelfCitation ;
    ///           cito:hasCitingEntity :paperA ;
    ///           cito:hasCitationCharacterization cito:extends ;
    ///           cito:hasCitedEntity :paperB .
    ///
    /// can be alternatively described as follows
    ///
    ///      :paperA cito:extends :paperB .
    ///      :paperA cito:sharesAuthorInstitutionWith :paperB .
    /// <see href="http://purl.org/spar/cito/AffilationSelfCitation"></see></summary>
    let AffilationSelfCitation =
        Namespaced_IRI.parse _namespace_name "AffilationSelfCitation" |> NamespacedName

    /// <summary>
    /// A citation in which the citing and the cited entities have something significant in common with one another, over and beyond their subject matter, for example authors, journal, institutional affiliation, or funding agency.
    /// <see href="http://purl.org/spar/cito/SelfCitation"></see></summary>
    let SelfCitation =
        Namespaced_IRI.parse _namespace_name "SelfCitation" |> NamespacedName

    /// <summary>
    /// A citation in which at least one author of the citing entity has direct or indirect co-authorship links with one of the authors of the cited entity.
    /// <see href="http://purl.org/spar/cito/AuthorNetworkSelfCitation"></see></summary>
    let AuthorNetworkSelfCitation =
        Namespaced_IRI.parse _namespace_name "AuthorNetworkSelfCitation" |> NamespacedName

    /// <summary>
    /// This property specifies the minimal distance that one of the authors of the citing entity has with regards to one of the authors of the cited entity, according to their co-authorship network.
    ///
    /// For instance, a citation has a co-authorship citation level equal to 1 if at least one author of the citing entity has previously published as co-author with one of the authors of the cited entity. Similarly, we say that a citation has a co-authorship citation level equal to 2 if at least one author of the citing entity has previously published as co-author with someone who him/herself has previously published as co-author with one of the authors of the cited entity. And so on.
    /// <see href="http://purl.org/spar/cito/hasCoAuthorshipCitationLevel"></see></summary>
    let hasCoAuthorshipCitationLevel =
        Namespaced_IRI.parse _namespace_name "hasCoAuthorshipCitationLevel" |> NamespacedName

    /// <summary>
    /// A citation in which the citing and the cited entities have at least one author in common.
    ///
    /// In particular, like the ancestor class cito:Citation, cito:AuthorSelfCitation and its accompanying object properties cito:hasCitingEntity, cito:hasCitedEntity and cito:hasCitationCharacterization can be employed to reify direct citation statements made using the CiTO citation object property cito:cites or one of its sub-properties, accompanied by an additional statement using cito:sharesAuthorWith for linking the citing paper and the cited paper.
    ///
    /// For example, the following cito:AuthorSelfCitation resource
    ///
    ///      :thisCitation a cito:AuthorSelfCitation ;
    ///           cito:hasCitingEntity :paperA ;
    ///           cito:hasCitationCharacterization cito:extends ;
    ///           cito:hasCitedEntity :paperB .
    ///
    /// can be alternatively described as follows
    ///
    ///      :paperA cito:extends :paperB .
    ///      :paperA cito:sharesAuthorWith :paperB .
    /// <see href="http://purl.org/spar/cito/AuthorSelfCitation"></see></summary>
    let AuthorSelfCitation =
        Namespaced_IRI.parse _namespace_name "AuthorSelfCitation" |> NamespacedName

    /// <summary>
    /// A citation is a conceptual directional link from a citing entity to a cited entity, created by a human performative act of making a citation, typically instantiated by the inclusion of a bibliographic reference (biro:BibliographicReference) in the reference list of the citing entity, or by the inclusion within the citing entity of a link, in the form of an HTTP Uniform Resource Locator (URL), to a resource on the World Wide Web.
    ///
    /// The time span of a citation, i.e. the interval between the publication year of the citing entity and the publication year of the cited entity, can be recorded using the data property cito:hasCitationTimeSpan.
    ///
    /// The nature or type of a citation can be characterized by using CiTO object properties, e.g. http://purl.org/spar/cito/citesAsDataSource (definition: “The citing entity cites the cited entity as a source of data”).
    ///
    /// This CiTO class cito:Citation and its accompanying object properties cito:hasCitingEntity, cito:hasCitedEntity and cito:hasCitationCharacterization can be employed to reify direct citation statements made using the CiTO citation object property cito:cites or one of its sub-properties.
    ///
    /// For example, the following RDF statement
    ///
    ///      :paperA cito:extends :paperB .
    ///
    /// can be alternatively described as follows
    ///
    ///      :thisCitation a cito:Citation ;
    ///           cito:hasCitingEntity :paperA ;
    ///           cito:hasCitationCharacterization cito:extends ;
    ///           cito:hasCitedEntity :paperB .
    ///
    /// This usage involved OWL2 punning, whereby a CiTO object property, such as the aforementioned cito:extends, is used as the object of the OWL assertion.
    ///
    ///      :thisCitation cito:hasCitationCharacterization cito:extends .
    ///
    /// Using such OWL2 punning (described at http://www.w3.org/TR/2009/WD-owl2-new-features-20090611/#F12:_Punning), the CiTO object property is considered as a proper named individual of the class owl:Thing.
    ///
    /// Such reification of citation acts can be very useful, since it permits one to combine these CiTO properties with other vocabularies, or to handle situations in which none of the citation characterizations available in CiTO are applicable.
    ///
    /// Such situations can be resolved by the creation of a user-defined citation characterization, for example by using the Open Annotation Data Model, as explained at http://semanticpublishing.wordpress.com/2013/07/03/extending-cito-for-open-annotations/.
    /// <see href="http://purl.org/spar/cito/Citation"></see></summary>
    let Citation = Namespaced_IRI.parse _namespace_name "Citation" |> NamespacedName

    /// <summary>
    /// A property that links a citation to its characterization made by using a CiTO citation characterization property such as cito:extends. This usage involved OWL2 punning, whenby a CiTO object property, such as the aforementioned cito:extends, is used as the object of an OWL assertion:
    ///
    ///      :thisCitation cito:hasCitationCharacterization cito:extends .
    ///
    /// In such cases of OWL punning, the CiTO object properties are simultaneously considered both as normal object properties and also as proper named individuals of the class owl:Thing.
    /// <see href="http://purl.org/spar/cito/hasCitationCharacterization"></see></summary>
    let hasCitationCharacterization =
        Namespaced_IRI.parse _namespace_name "hasCitationCharacterization" |> NamespacedName

    /// <summary>
    /// A property that relates a citation to the cited entity.
    /// <see href="http://purl.org/spar/cito/hasCitedEntity"></see></summary>
    let hasCitedEntity =
        Namespaced_IRI.parse _namespace_name "hasCitedEntity" |> NamespacedName

    /// <summary>
    /// A property that relates a citation to the citing entity.
    /// <see href="http://purl.org/spar/cito/hasCitingEntity"></see></summary>
    let hasCitingEntity =
        Namespaced_IRI.parse _namespace_name "hasCitingEntity" |> NamespacedName

    /// <summary>
    /// A citation in which the citing and the cited entities have nothing significant in common with one another (for example authors, journal, institutional affiliation, or funding agency) over and beyond their subject matter.
    /// <see href="http://purl.org/spar/cito/DistantCitation"></see></summary>
    let DistantCitation =
        Namespaced_IRI.parse _namespace_name "DistantCitation" |> NamespacedName

    /// <summary>
    /// A citation in which the works reported in the citing and the cited entities were funded by the same funding agency.
    ///
    /// In particular, like the ancestor class cito:Citation, cito:FunderSelfCitation and its accompanying object properties cito:hasCitingEntity, cito:hasCitedEntity and cito:hasCitationCharacterization can be employed to reify direct citation statements made using the CiTO citation object property cito:cites or one of its sub-properties, accompanied by an additional statement using cito:sharesFundingAgencyWith for linking the citing paper and the cited paper.
    ///
    /// For example, the following cito:FundingSelfCitation resource
    ///
    ///      :thisCitation a cito:FundingSelfCitation ;
    ///           cito:hasCitingEntity :paperA ;
    ///           cito:hasCitationCharacterization cito:extends ;
    ///           cito:hasCitedEntity :paperB .
    ///
    /// can be alternatively described as follows
    ///
    ///      :paperA cito:extends :paperB .
    ///      :paperA cito:sharesFundingAgencyWith :paperB .
    /// <see href="http://purl.org/spar/cito/FunderSelfCitation"></see></summary>
    let FunderSelfCitation =
        Namespaced_IRI.parse _namespace_name "FunderSelfCitation" |> NamespacedName

    /// <summary>
    /// A citation from one journal to another journal which forms one of a very large number of citations from the citing journal to recent articles in the cited journal, possibly undertaken as part of a citation cartel for the purpose of gaming the impact factor of the cited journal.
    /// <see href="http://purl.org/spar/cito/JournalCartelCitation"></see></summary>
    let JournalCartelCitation =
        Namespaced_IRI.parse _namespace_name "JournalCartelCitation" |> NamespacedName

    /// <summary>
    /// A citation in which the citing and the cited entities are published in the same journal.
    ///
    /// In particular, like the ancestor class cito:Citation, cito:JournalSelfCitation and its accompanying object properties cito:hasCitingEntity, cito:hasCitedEntity and cito:hasCitationCharacterization can be employed to reify direct citation statements made using the CiTO citation object property cito:cites or one of its sub-properties, accompanied by an additional statement using cito:sharesJournalWith for linking the citing paper and the cited paper.
    ///
    /// For example, the following cito:JournalSelfCitation resource
    ///
    ///      :thisCitation a cito:JournalSelfCitation ;
    ///           cito:hasCitingEntity :paperA ;
    ///           cito:hasCitationCharacterization cito:extends ;
    ///           cito:hasCitedEntity :paperB .
    ///
    /// can be alternatively described as follows
    ///
    ///      :paperA cito:extends :paperB .
    ///      :paperA cito:sharesJournalWith :paperB .
    /// <see href="http://purl.org/spar/cito/JournalSelfCitation"></see></summary>
    let JournalSelfCitation =
        Namespaced_IRI.parse _namespace_name "JournalSelfCitation" |> NamespacedName

    /// <summary>
    /// The citing entity agrees with statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/agreesWith"></see></summary>
    let agreesWith = Namespaced_IRI.parse _namespace_name "agreesWith" |> NamespacedName
    /// <summary>
    /// The citing entity cites the cited entity, either directly and explicitly (as in the reference list of a journal article), indirectly (e.g. by citing a more recent paper by the same group on the same topic), or implicitly (e.g. as in artistic quotations or parodies, or in cases of plagiarism).
    /// <see href="http://purl.org/spar/cito/cites"></see></summary>
    let cites = Namespaced_IRI.parse _namespace_name "cites" |> NamespacedName

    /// <summary>
    /// The cited entity contains statements, ideas or conclusions with which the citing entity agrees.
    /// <see href="http://purl.org/spar/cito/isAgreedWithBy"></see></summary>
    let isAgreedWithBy =
        Namespaced_IRI.parse _namespace_name "isAgreedWithBy" |> NamespacedName

    /// <summary>
    /// The cited entity (the subject of the RDF triple) is cited by the citing entity (the object of the triple).
    /// <see href="http://purl.org/spar/cito/isCitedBy"></see></summary>
    let isCitedBy = Namespaced_IRI.parse _namespace_name "isCitedBy" |> NamespacedName

    /// <summary>
    /// The citing entity cites the cited entity as one that provides an authoritative description or definition of the subject under discussion.
    /// <see href="http://purl.org/spar/cito/citesAsAuthority"></see></summary>
    let citesAsAuthority =
        Namespaced_IRI.parse _namespace_name "citesAsAuthority" |> NamespacedName

    /// <summary>
    /// The cited entity is cited as providing an authoritative description or definition of the subject under discussion in the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedAsAuthorityBy"></see></summary>
    let isCitedAsAuthorityBy =
        Namespaced_IRI.parse _namespace_name "isCitedAsAuthorityBy" |> NamespacedName

    /// <summary>
    /// The citing entity cites the cited entity as source of data.
    /// <see href="http://purl.org/spar/cito/citesAsDataSource"></see></summary>
    let citesAsDataSource =
        Namespaced_IRI.parse _namespace_name "citesAsDataSource" |> NamespacedName

    /// <summary>
    /// The cited entity is cited as a data source by the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedAsDataSourceBy"></see></summary>
    let isCitedAsDataSourceBy =
        Namespaced_IRI.parse _namespace_name "isCitedAsDataSourceBy" |> NamespacedName

    /// <summary>
    /// The citing entity cites the cited entity as source of factual evidence for statements it contains.
    /// <see href="http://purl.org/spar/cito/citesAsEvidence"></see></summary>
    let citesAsEvidence =
        Namespaced_IRI.parse _namespace_name "citesAsEvidence" |> NamespacedName

    /// <summary>
    /// The cited entity is cited for providing factual evidence to the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedAsEvidenceBy"></see></summary>
    let isCitedAsEvidenceBy =
        Namespaced_IRI.parse _namespace_name "isCitedAsEvidenceBy" |> NamespacedName

    /// <summary>
    /// The citing entity cites the cited entity as being the container of metadata describing the citing entity.
    /// <see href="http://purl.org/spar/cito/citesAsMetadataDocument"></see></summary>
    let citesAsMetadataDocument =
        Namespaced_IRI.parse _namespace_name "citesAsMetadataDocument" |> NamespacedName

    /// <summary>
    /// The cited entity is cited as being the container of metadata relating to the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedAsMetadataDocumentBy"></see></summary>
    let isCitedAsMetadataDocumentBy =
        Namespaced_IRI.parse _namespace_name "isCitedAsMetadataDocumentBy" |> NamespacedName

    /// <summary>
    /// The citing entity cites the cited entity as providing or containing a possible solution to the issues being discussed.
    /// <see href="http://purl.org/spar/cito/citesAsPotentialSolution"></see></summary>
    let citesAsPotentialSolution =
        Namespaced_IRI.parse _namespace_name "citesAsPotentialSolution" |> NamespacedName

    /// <summary>
    /// The cited entity is cited as providing or containing a possible solution to the issues being discussed in the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedAsPontentialSolutionBy"></see></summary>
    let isCitedAsPontentialSolutionBy =
        Namespaced_IRI.parse _namespace_name "isCitedAsPontentialSolutionBy" |> NamespacedName

    /// <summary>
    /// The citing entity cites the cited entity as an item of recommended reading.  This property can be used, for example, to describe references in a lecture reading list, where the cited references are relevant to the general topic of the lecture, but might not be individually cited within the text of the lecture.  Similarly, it could be used to describe items in a 'Suggested further reading' list at the end of a book chapter.
    /// <see href="http://purl.org/spar/cito/citesAsRecommendedReading"></see></summary>
    let citesAsRecommendedReading =
        Namespaced_IRI.parse _namespace_name "citesAsRecommendedReading" |> NamespacedName

    /// <summary>
    /// The cited entity is cited by the citing entity as an item of recommended reading.  This property can be used, for example, to describe references in a lecture reading list, where the cited references are relevant to the general topic of the lecture, but might not be individually cited within the text of the lecture.  Similarly, it could be used to describe items in a 'Suggested further reading' list at the end of a book chapter.
    /// <see href="http://purl.org/spar/cito/isCitedAsRecommendedReadingBy"></see></summary>
    let isCitedAsRecommendedReadingBy =
        Namespaced_IRI.parse _namespace_name "isCitedAsRecommendedReadingBy" |> NamespacedName

    /// <summary>
    /// The citing entity cites the cited entity as one that is related.
    /// <see href="http://purl.org/spar/cito/citesAsRelated"></see></summary>
    let citesAsRelated =
        Namespaced_IRI.parse _namespace_name "citesAsRelated" |> NamespacedName

    /// <summary>
    /// The cited entity is cited as being related to the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedAsRelatedBy"></see></summary>
    let isCitedAsRelatedBy =
        Namespaced_IRI.parse _namespace_name "isCitedAsRelatedBy" |> NamespacedName

    /// <summary>
    /// The citing entity cites the cited entity as being the entity from which the citing entity is derived, or about which the citing entity contains metadata.
    /// <see href="http://purl.org/spar/cito/citesAsSourceDocument"></see></summary>
    let citesAsSourceDocument =
        Namespaced_IRI.parse _namespace_name "citesAsSourceDocument" |> NamespacedName

    /// <summary>
    /// The cited entity is cited as being the entity from which the citing entity is derived, or about which the citing entity contains metadata.
    /// <see href="http://purl.org/spar/cito/isCitedAsSourceDocumentBy"></see></summary>
    let isCitedAsSourceDocumentBy =
        Namespaced_IRI.parse _namespace_name "isCitedAsSourceDocumentBy" |> NamespacedName

    /// <summary>
    /// The citing entity cites the cited entity as a source of information on the subject under discussion.
    /// <see href="http://purl.org/spar/cito/citesForInformation"></see></summary>
    let citesForInformation =
        Namespaced_IRI.parse _namespace_name "citesForInformation" |> NamespacedName

    /// <summary>
    /// The cited entity is cited as a source of information on the subject under discussion in the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedForInformationBy"></see></summary>
    let isCitedForInformationBy =
        Namespaced_IRI.parse _namespace_name "isCitedForInformationBy" |> NamespacedName

    /// <summary>
    /// The citing entity is used to create or compile the cited entity.
    /// <see href="http://purl.org/spar/cito/compiles"></see></summary>
    let compiles = Namespaced_IRI.parse _namespace_name "compiles" |> NamespacedName

    /// <summary>
    /// The cited entity is the result of a compile or creation event using the citing entity.
    /// <see href="http://purl.org/spar/cito/isCompiledBy"></see></summary>
    let isCompiledBy =
        Namespaced_IRI.parse _namespace_name "isCompiledBy" |> NamespacedName

    /// <summary>
    /// The citing entity confirms facts, ideas or statements presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/confirms"></see></summary>
    let confirms = Namespaced_IRI.parse _namespace_name "confirms" |> NamespacedName

    /// <summary>
    /// The cited entity presents facts, ideas or statements that are confirmed by the citing entity.
    /// <see href="http://purl.org/spar/cito/isConfirmedBy"></see></summary>
    let isConfirmedBy =
        Namespaced_IRI.parse _namespace_name "isConfirmedBy" |> NamespacedName

    /// <summary>
    /// The citing entity contains a statement of fact or a logical assertion (or a collection of such facts and/or assertions) originally present in the cited entity.   This object property is designed to be used to relate a separate abstract, summary or nanopublication to the cited entity upon which it is based.
    /// <see href="http://purl.org/spar/cito/containsAssertionFrom"></see></summary>
    let containsAssertionFrom =
        Namespaced_IRI.parse _namespace_name "containsAssertionFrom" |> NamespacedName

    /// <summary>
    /// The cited entity contains and is the original source of a statement of fact or a logical assertion (or a collection of such facts and/or assertions) that is to be found in the citing entity.   This inverse object property is designed to be used to relate a cited entity to a separate abstract, summary or nanopublication based upon it.
    /// <see href="http://purl.org/spar/cito/providesAssertionFor"></see></summary>
    let providesAssertionFor =
        Namespaced_IRI.parse _namespace_name "providesAssertionFor" |> NamespacedName

    /// <summary>
    /// The citing entity corrects statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/corrects"></see></summary>
    let corrects = Namespaced_IRI.parse _namespace_name "corrects" |> NamespacedName

    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are corrected by the citing entity.
    /// <see href="http://purl.org/spar/cito/isCorrectedBy"></see></summary>
    let isCorrectedBy =
        Namespaced_IRI.parse _namespace_name "isCorrectedBy" |> NamespacedName

    /// <summary>
    /// The citing entity acknowledges contributions made by the cited entity.
    /// <see href="http://purl.org/spar/cito/credits"></see></summary>
    let credits = Namespaced_IRI.parse _namespace_name "credits" |> NamespacedName

    /// <summary>
    /// The cited entity makes contributions that are acknowledged by the citing entity.
    /// <see href="http://purl.org/spar/cito/isCreditedBy"></see></summary>
    let isCreditedBy =
        Namespaced_IRI.parse _namespace_name "isCreditedBy" |> NamespacedName

    /// <summary>
    /// The citing entity critiques statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/critiques"></see></summary>
    let critiques = Namespaced_IRI.parse _namespace_name "critiques" |> NamespacedName

    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are critiqued by the citing entity.
    /// <see href="http://purl.org/spar/cito/isCritiquedBy"></see></summary>
    let isCritiquedBy =
        Namespaced_IRI.parse _namespace_name "isCritiquedBy" |> NamespacedName

    /// <summary>
    /// The citing entity express derision for the cited entity, or for ideas or conclusions contained within it.
    /// <see href="http://purl.org/spar/cito/derides"></see></summary>
    let derides = Namespaced_IRI.parse _namespace_name "derides" |> NamespacedName

    /// <summary>
    /// The cited entity contains ideas or conclusions for which the citing entity express derision.
    /// <see href="http://purl.org/spar/cito/isDeridedBy"></see></summary>
    let isDeridedBy =
        Namespaced_IRI.parse _namespace_name "isDeridedBy" |> NamespacedName

    /// <summary>
    /// The citing entity describes the cited entity.
    /// <see href="http://purl.org/spar/cito/describes"></see></summary>
    let describes = Namespaced_IRI.parse _namespace_name "describes" |> NamespacedName

    /// <summary>
    /// The cited entity is described by the citing entity.
    /// <see href="http://purl.org/spar/cito/isDescribedBy"></see></summary>
    let isDescribedBy =
        Namespaced_IRI.parse _namespace_name "isDescribedBy" |> NamespacedName

    /// <summary>
    /// The citing entity disagrees with statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/disagreesWith"></see></summary>
    let disagreesWith =
        Namespaced_IRI.parse _namespace_name "disagreesWith" |> NamespacedName

    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are disagreed with by the citing entity.
    /// <see href="http://purl.org/spar/cito/isDisagreedWithBy"></see></summary>
    let isDisagreedWithBy =
        Namespaced_IRI.parse _namespace_name "isDisagreedWithBy" |> NamespacedName

    /// <summary>
    /// The citing entity discusses statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/discusses"></see></summary>
    let discusses = Namespaced_IRI.parse _namespace_name "discusses" |> NamespacedName

    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are discussed by the citing entity.
    /// <see href="http://purl.org/spar/cito/isDiscussedBy"></see></summary>
    let isDiscussedBy =
        Namespaced_IRI.parse _namespace_name "isDiscussedBy" |> NamespacedName

    /// <summary>
    /// The citing entity disputes statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/disputes"></see></summary>
    let disputes = Namespaced_IRI.parse _namespace_name "disputes" |> NamespacedName

    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are disputed by the citing entity.
    /// <see href="http://purl.org/spar/cito/isDisputedBy"></see></summary>
    let isDisputedBy =
        Namespaced_IRI.parse _namespace_name "isDisputedBy" |> NamespacedName

    /// <summary>
    /// The citing entity documents information about the cited entity.
    /// <see href="http://purl.org/spar/cito/documents"></see></summary>
    let documents = Namespaced_IRI.parse _namespace_name "documents" |> NamespacedName

    /// <summary>
    /// Information about the cited entity is documented by the citing entity.
    /// <see href="http://purl.org/spar/cito/isDocumentedBy"></see></summary>
    let isDocumentedBy =
        Namespaced_IRI.parse _namespace_name "isDocumentedBy" |> NamespacedName

    /// <summary>
    /// The citing entity extends facts, ideas or understandings presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/extends"></see></summary>
    let extends = Namespaced_IRI.parse _namespace_name "extends" |> NamespacedName

    /// <summary>
    /// The cited entity presents facts, ideas or understandings that are extended by the citing entity.
    /// <see href="http://purl.org/spar/cito/isExtendedBy"></see></summary>
    let isExtendedBy =
        Namespaced_IRI.parse _namespace_name "isExtendedBy" |> NamespacedName

    /// <summary>
    /// The cited entity provides background information for the citing entity.
    /// <see href="http://purl.org/spar/cito/givesBackgroundTo"></see></summary>
    let givesBackgroundTo =
        Namespaced_IRI.parse _namespace_name "givesBackgroundTo" |> NamespacedName

    /// <summary>
    /// The citing entity obtains background information from the cited entity.
    /// <see href="http://purl.org/spar/cito/obtainsBackgroundFrom"></see></summary>
    let obtainsBackgroundFrom =
        Namespaced_IRI.parse _namespace_name "obtainsBackgroundFrom" |> NamespacedName

    /// <summary>
    /// The cited entity provides intellectual or factual support for the citing entity.
    /// <see href="http://purl.org/spar/cito/givesSupportTo"></see></summary>
    let givesSupportTo =
        Namespaced_IRI.parse _namespace_name "givesSupportTo" |> NamespacedName

    /// <summary>
    /// The citing entity obtains intellectual or factual support from the cited entity.
    /// <see href="http://purl.org/spar/cito/obtainsSupportFrom"></see></summary>
    let obtainsSupportFrom =
        Namespaced_IRI.parse _namespace_name "obtainsSupportFrom" |> NamespacedName

    /// <summary>
    /// The date on which the citation was created. This has the same numerical value as the publication date of the citing bibliographic resource, but is a property of the citation itself.  When combined with the citation time span, it permits that citation to be located in history.
    /// <see href="http://purl.org/spar/cito/hasCitationCreationDate"></see></summary>
    let hasCitationCreationDate =
        Namespaced_IRI.parse _namespace_name "hasCitationCreationDate" |> NamespacedName

    /// <summary>
    /// The temporal characteristic of a citation, namely the interval between the publication date of the cited entity and the publication date of the citing entity. Note that when one or both of the publication dates is given as just 'year', then the citation time span is rounded to the nearest year, and when one or both of the publication dates is given as just 'year and month', then the citation time span is rounded to the nearest month, with the inherent inaccuracies that such rounding involves.
    /// <see href="http://purl.org/spar/cito/hasCitationTimeSpan"></see></summary>
    let hasCitationTimeSpan =
        Namespaced_IRI.parse _namespace_name "hasCitationTimeSpan" |> NamespacedName

    /// <summary>
    /// The cited entity evokes a reply from the citing entity.
    /// <see href="http://purl.org/spar/cito/hasReplyFrom"></see></summary>
    let hasReplyFrom =
        Namespaced_IRI.parse _namespace_name "hasReplyFrom" |> NamespacedName

    /// <summary>
    /// The citing entity replies to statements, ideas or criticisms presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/repliesTo"></see></summary>
    let repliesTo = Namespaced_IRI.parse _namespace_name "repliesTo" |> NamespacedName

    /// <summary>
    /// The citing entity includes one or more excerpts from the cited entity.
    /// <see href="http://purl.org/spar/cito/includesExcerptFrom"></see></summary>
    let includesExcerptFrom =
        Namespaced_IRI.parse _namespace_name "includesExcerptFrom" |> NamespacedName

    /// <summary>
    /// The cited entity contains information, usually of a textual nature, that is excerpted by (used as an excerpt within) the citing entity.
    /// <see href="http://purl.org/spar/cito/providesExcerptFor"></see></summary>
    let providesExcerptFor =
        Namespaced_IRI.parse _namespace_name "providesExcerptFor" |> NamespacedName

    /// <summary>
    /// The citing entity includes one or more quotations from the cited entity.
    /// <see href="http://purl.org/spar/cito/includesQuotationFrom"></see></summary>
    let includesQuotationFrom =
        Namespaced_IRI.parse _namespace_name "includesQuotationFrom" |> NamespacedName

    /// <summary>
    /// The cited entity contains information, usually of a textual nature, that is quoted by (used as a quotation within) the citing entity.
    /// <see href="http://purl.org/spar/cito/providesQuotationFor"></see></summary>
    let providesQuotationFor =
        Namespaced_IRI.parse _namespace_name "providesQuotationFor" |> NamespacedName

    /// <summary>
    /// The cited entity is the target for an HTTP Uniform Resource Locator (URL) link within the citing entity.
    /// <see href="http://purl.org/spar/cito/isLinkedToBy"></see></summary>
    let isLinkedToBy =
        Namespaced_IRI.parse _namespace_name "isLinkedToBy" |> NamespacedName

    /// <summary>
    /// The citing entity provides a link, in the form of an HTTP Uniform Resource Locator (URL), to the cited entity.
    /// <see href="http://purl.org/spar/cito/linksTo"></see></summary>
    let linksTo = Namespaced_IRI.parse _namespace_name "linksTo" |> NamespacedName

    /// <summary>
    /// The characteristic style or content of the cited entity is imitated by the citing entity for comic effect, usually without explicit citation.
    /// <see href="http://purl.org/spar/cito/isParodiedBy"></see></summary>
    let isParodiedBy =
        Namespaced_IRI.parse _namespace_name "isParodiedBy" |> NamespacedName

    /// <summary>
    /// The citing entity imitates the characteristic style or content of the cited entity for comic effect, usually without explicit citation.
    /// <see href="http://purl.org/spar/cito/parodies"></see></summary>
    let parodies = Namespaced_IRI.parse _namespace_name "parodies" |> NamespacedName

    /// <summary>
    /// The cited entity is plagiarized by the author of the citing entity, who includes within the citing entity textual or other elements from the cited entity without formal acknowledgement of their source. The cited entity is thus not explicitly cited from within the citing entity, according to the norms of scholarly practice, but is cited implicitly.
    /// <see href="http://purl.org/spar/cito/isPlagiarizedBy"></see></summary>
    let isPlagiarizedBy =
        Namespaced_IRI.parse _namespace_name "isPlagiarizedBy" |> NamespacedName

    /// <summary>
    /// A property indicating that the author of the citing entity plagiarizes the cited entity, by including textual or other elements from the cited entity without formal acknowledgement of their source.  The citing entity thus contains no explicit citation of the cited entity, according to the norms of scholarly practice, but cites it implicitly.
    /// <see href="http://purl.org/spar/cito/plagiarizes"></see></summary>
    let plagiarizes =
        Namespaced_IRI.parse _namespace_name "plagiarizes" |> NamespacedName

    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are qualified or have conditions placed upon them by the citing entity.
    /// <see href="http://purl.org/spar/cito/isQualifiedBy"></see></summary>
    let isQualifiedBy =
        Namespaced_IRI.parse _namespace_name "isQualifiedBy" |> NamespacedName

    /// <summary>
    /// The citing entity qualifies or places conditions or restrictions upon statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/qualifies"></see></summary>
    let qualifies = Namespaced_IRI.parse _namespace_name "qualifies" |> NamespacedName

    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are refuted by the citing entity.
    /// <see href="http://purl.org/spar/cito/isRefutedBy"></see></summary>
    let isRefutedBy =
        Namespaced_IRI.parse _namespace_name "isRefutedBy" |> NamespacedName

    /// <summary>
    /// The citing entity refutes statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/refutes"></see></summary>
    let refutes = Namespaced_IRI.parse _namespace_name "refutes" |> NamespacedName

    /// <summary>
    /// The cited entity is formally retracted by the citing entity.
    /// <see href="http://purl.org/spar/cito/isRetractedBy"></see></summary>
    let isRetractedBy =
        Namespaced_IRI.parse _namespace_name "isRetractedBy" |> NamespacedName

    /// <summary>
    /// The citing entity constitutes a formal retraction of the cited entity.
    /// <see href="http://purl.org/spar/cito/retracts"></see></summary>
    let retracts = Namespaced_IRI.parse _namespace_name "retracts" |> NamespacedName

    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are reviewed by the citing entity.
    /// <see href="http://purl.org/spar/cito/isReviewedBy"></see></summary>
    let isReviewedBy =
        Namespaced_IRI.parse _namespace_name "isReviewedBy" |> NamespacedName

    /// <summary>
    /// The citing entity reviews statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/reviews"></see></summary>
    let reviews = Namespaced_IRI.parse _namespace_name "reviews" |> NamespacedName

    /// <summary>
    /// The cited entity or aspects of its contents are ridiculed by the citing entity.
    /// <see href="http://purl.org/spar/cito/isRidiculedBy"></see></summary>
    let isRidiculedBy =
        Namespaced_IRI.parse _namespace_name "isRidiculedBy" |> NamespacedName

    /// <summary>
    /// The citing entity ridicules the cited entity or aspects of its contents.
    /// <see href="http://purl.org/spar/cito/ridicules"></see></summary>
    let ridicules = Namespaced_IRI.parse _namespace_name "ridicules" |> NamespacedName

    /// <summary>
    /// The cited entity is cited because the citing article contains speculations on its content or ideas.
    /// <see href="http://purl.org/spar/cito/isSpeculatedOnBy"></see></summary>
    let isSpeculatedOnBy =
        Namespaced_IRI.parse _namespace_name "isSpeculatedOnBy" |> NamespacedName

    /// <summary>
    /// The citing entity speculates on something within or related to the cited entity, without firm evidence.
    /// <see href="http://purl.org/spar/cito/speculatesOn"></see></summary>
    let speculatesOn =
        Namespaced_IRI.parse _namespace_name "speculatesOn" |> NamespacedName

    /// <summary>
    /// The cited entity receives intellectual or factual support from the citing entity.
    /// <see href="http://purl.org/spar/cito/isSupportedBy"></see></summary>
    let isSupportedBy =
        Namespaced_IRI.parse _namespace_name "isSupportedBy" |> NamespacedName

    /// <summary>
    /// The citing entity provides intellectual or factual support for statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/supports"></see></summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName

    /// <summary>
    /// The cited entity presents statements, ideas, hypotheses or understanding that are updated by the cited entity.
    /// <see href="http://purl.org/spar/cito/isUpdatedBy"></see></summary>
    let isUpdatedBy =
        Namespaced_IRI.parse _namespace_name "isUpdatedBy" |> NamespacedName

    /// <summary>
    /// The citing entity updates statements, ideas, hypotheses or understanding presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/updates"></see></summary>
    let updates = Namespaced_IRI.parse _namespace_name "updates" |> NamespacedName
    /// <summary>
    /// A property that permits you to express appreciation of or interest in something that is the object of the RDF triple, or to express that it is worth thinking about even if you do not agree with its content, enabling social media 'likes' statements to be encoded in RDF.  Use of this property does NOT imply the existence of a formal citation of the entity that is 'liked'.
    /// <see href="http://purl.org/spar/cito/likes"></see></summary>
    let likes = Namespaced_IRI.parse _namespace_name "likes" |> NamespacedName

    /// <summary>
    /// The cited entity presents conclusions that are used in work described in the citing entity.
    /// <see href="http://purl.org/spar/cito/providesConclusionsFor"></see></summary>
    let providesConclusionsFor =
        Namespaced_IRI.parse _namespace_name "providesConclusionsFor" |> NamespacedName

    /// <summary>
    /// The citing entity describes work that uses conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/usesConclusionsFrom"></see></summary>
    let usesConclusionsFrom =
        Namespaced_IRI.parse _namespace_name "usesConclusionsFrom" |> NamespacedName

    /// <summary>
    /// The cited entity presents data that are used in work described in the citing entity.
    /// <see href="http://purl.org/spar/cito/providesDataFor"></see></summary>
    let providesDataFor =
        Namespaced_IRI.parse _namespace_name "providesDataFor" |> NamespacedName

    /// <summary>
    /// The citing entity describes work that uses data presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/usesDataFrom"></see></summary>
    let usesDataFrom =
        Namespaced_IRI.parse _namespace_name "usesDataFrom" |> NamespacedName

    /// <summary>
    /// The cited entity details a method that is used in work described by the citing entity.
    /// <see href="http://purl.org/spar/cito/providesMethodFor"></see></summary>
    let providesMethodFor =
        Namespaced_IRI.parse _namespace_name "providesMethodFor" |> NamespacedName

    /// <summary>
    /// The citing entity describes work that uses a method detailed in the cited entity.
    /// <see href="http://purl.org/spar/cito/usesMethodIn"></see></summary>
    let usesMethodIn =
        Namespaced_IRI.parse _namespace_name "usesMethodIn" |> NamespacedName

    /// <summary>
    /// Each entity has at least one author that shares a common institutional affiliation with an author of the other entity.
    /// <see href="http://purl.org/spar/cito/sharesAuthorInstitutionWith"></see></summary>
    let sharesAuthorInstitutionWith =
        Namespaced_IRI.parse _namespace_name "sharesAuthorInstitutionWith" |> NamespacedName

    /// <summary>
    /// Each entity has at least one author in common with the other entity.
    /// <see href="http://purl.org/spar/cito/sharesAuthorWith"></see></summary>
    let sharesAuthorWith =
        Namespaced_IRI.parse _namespace_name "sharesAuthorWith" |> NamespacedName

    /// <summary>
    /// The two entities result from activities that have been funded by the same funding agency.
    /// <see href="http://purl.org/spar/cito/sharesFundingAgencyWith"></see></summary>
    let sharesFundingAgencyWith =
        Namespaced_IRI.parse _namespace_name "sharesFundingAgencyWith" |> NamespacedName

    /// <summary>
    /// The citing and cited bibliographic resources are published in the same journal.
    /// <see href="http://purl.org/spar/cito/sharesJournalWith"></see></summary>
    let sharesJournalWith =
        Namespaced_IRI.parse _namespace_name "sharesJournalWith" |> NamespacedName

    /// <summary>
    /// The citing and cited bibliographic resources are published in same publication venue.
    /// <see href="http://purl.org/spar/cito/sharesPublicationVenueWith"></see></summary>
    let sharesPublicationVenueWith =
        Namespaced_IRI.parse _namespace_name "sharesPublicationVenueWith" |> NamespacedName
