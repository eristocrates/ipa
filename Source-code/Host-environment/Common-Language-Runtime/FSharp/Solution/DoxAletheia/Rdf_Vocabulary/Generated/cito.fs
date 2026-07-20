namespace http.purl.org.spar.cito.slash

open DoxAletheia

module cito =
    let _namespace_name = "http://purl.org/spar/cito/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/cito/2018-02-12"></see>
    /// </summary>
    let ``_2018-02-12`` = _prefix "2018-02-12"
    /// <summary>
    ///   <see href="http://purl.org/spar/cito/2018-02-16"></see>
    /// </summary>
    let ``_2018-02-16`` = _prefix "2018-02-16"
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
    let AffilationSelfCitation = _prefix "AffilationSelfCitation"
    /// <summary>
    /// A citation in which the citing and the cited entities have something significant in common with one another, over and beyond their subject matter, for example authors, journal, institutional affiliation, or funding agency.
    /// <see href="http://purl.org/spar/cito/SelfCitation"></see></summary>
    let SelfCitation = _prefix "SelfCitation"
    /// <summary>
    /// A citation in which at least one author of the citing entity has direct or indirect co-authorship links with one of the authors of the cited entity.
    /// <see href="http://purl.org/spar/cito/AuthorNetworkSelfCitation"></see></summary>
    let AuthorNetworkSelfCitation = _prefix "AuthorNetworkSelfCitation"
    /// <summary>
    /// This property specifies the minimal distance that one of the authors of the citing entity has with regards to one of the authors of the cited entity, according to their co-authorship network.
    ///
    /// For instance, a citation has a co-authorship citation level equal to 1 if at least one author of the citing entity has previously published as co-author with one of the authors of the cited entity. Similarly, we say that a citation has a co-authorship citation level equal to 2 if at least one author of the citing entity has previously published as co-author with someone who him/herself has previously published as co-author with one of the authors of the cited entity. And so on.
    /// <see href="http://purl.org/spar/cito/hasCoAuthorshipCitationLevel"></see></summary>
    let hasCoAuthorshipCitationLevel = _prefix "hasCoAuthorshipCitationLevel"
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
    let AuthorSelfCitation = _prefix "AuthorSelfCitation"
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
    let Citation = _prefix "Citation"
    /// <summary>
    /// A property that links a citation to its characterization made by using a CiTO citation characterization property such as cito:extends. This usage involved OWL2 punning, whenby a CiTO object property, such as the aforementioned cito:extends, is used as the object of an OWL assertion:
    ///
    ///      :thisCitation cito:hasCitationCharacterization cito:extends .
    ///
    /// In such cases of OWL punning, the CiTO object properties are simultaneously considered both as normal object properties and also as proper named individuals of the class owl:Thing.
    /// <see href="http://purl.org/spar/cito/hasCitationCharacterization"></see></summary>
    let hasCitationCharacterization = _prefix "hasCitationCharacterization"
    /// <summary>
    /// A property that relates a citation to the cited entity.
    /// <see href="http://purl.org/spar/cito/hasCitedEntity"></see></summary>
    let hasCitedEntity = _prefix "hasCitedEntity"
    /// <summary>
    /// A property that relates a citation to the citing entity.
    /// <see href="http://purl.org/spar/cito/hasCitingEntity"></see></summary>
    let hasCitingEntity = _prefix "hasCitingEntity"
    /// <summary>
    /// A citation in which the citing and the cited entities have nothing significant in common with one another (for example authors, journal, institutional affiliation, or funding agency) over and beyond their subject matter.
    /// <see href="http://purl.org/spar/cito/DistantCitation"></see></summary>
    let DistantCitation = _prefix "DistantCitation"
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
    let FunderSelfCitation = _prefix "FunderSelfCitation"
    /// <summary>
    /// A citation from one journal to another journal which forms one of a very large number of citations from the citing journal to recent articles in the cited journal, possibly undertaken as part of a citation cartel for the purpose of gaming the impact factor of the cited journal.
    /// <see href="http://purl.org/spar/cito/JournalCartelCitation"></see></summary>
    let JournalCartelCitation = _prefix "JournalCartelCitation"
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
    let JournalSelfCitation = _prefix "JournalSelfCitation"
    /// <summary>
    /// The citing entity agrees with statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/agreesWith"></see></summary>
    let agreesWith = _prefix "agreesWith"
    /// <summary>
    /// The citing entity cites the cited entity, either directly and explicitly (as in the reference list of a journal article), indirectly (e.g. by citing a more recent paper by the same group on the same topic), or implicitly (e.g. as in artistic quotations or parodies, or in cases of plagiarism).
    /// <see href="http://purl.org/spar/cito/cites"></see></summary>
    let cites = _prefix "cites"
    /// <summary>
    /// The cited entity contains statements, ideas or conclusions with which the citing entity agrees.
    /// <see href="http://purl.org/spar/cito/isAgreedWithBy"></see></summary>
    let isAgreedWithBy = _prefix "isAgreedWithBy"
    /// <summary>
    /// The cited entity (the subject of the RDF triple) is cited by the citing entity (the object of the triple).
    /// <see href="http://purl.org/spar/cito/isCitedBy"></see></summary>
    let isCitedBy = _prefix "isCitedBy"
    /// <summary>
    /// The citing entity cites the cited entity as one that provides an authoritative description or definition of the subject under discussion.
    /// <see href="http://purl.org/spar/cito/citesAsAuthority"></see></summary>
    let citesAsAuthority = _prefix "citesAsAuthority"
    /// <summary>
    /// The cited entity is cited as providing an authoritative description or definition of the subject under discussion in the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedAsAuthorityBy"></see></summary>
    let isCitedAsAuthorityBy = _prefix "isCitedAsAuthorityBy"
    /// <summary>
    /// The citing entity cites the cited entity as source of data.
    /// <see href="http://purl.org/spar/cito/citesAsDataSource"></see></summary>
    let citesAsDataSource = _prefix "citesAsDataSource"
    /// <summary>
    /// The cited entity is cited as a data source by the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedAsDataSourceBy"></see></summary>
    let isCitedAsDataSourceBy = _prefix "isCitedAsDataSourceBy"
    /// <summary>
    /// The citing entity cites the cited entity as source of factual evidence for statements it contains.
    /// <see href="http://purl.org/spar/cito/citesAsEvidence"></see></summary>
    let citesAsEvidence = _prefix "citesAsEvidence"
    /// <summary>
    /// The cited entity is cited for providing factual evidence to the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedAsEvidenceBy"></see></summary>
    let isCitedAsEvidenceBy = _prefix "isCitedAsEvidenceBy"
    /// <summary>
    /// The citing entity cites the cited entity as being the container of metadata describing the citing entity.
    /// <see href="http://purl.org/spar/cito/citesAsMetadataDocument"></see></summary>
    let citesAsMetadataDocument = _prefix "citesAsMetadataDocument"
    /// <summary>
    /// The cited entity is cited as being the container of metadata relating to the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedAsMetadataDocumentBy"></see></summary>
    let isCitedAsMetadataDocumentBy = _prefix "isCitedAsMetadataDocumentBy"
    /// <summary>
    /// The citing entity cites the cited entity as providing or containing a possible solution to the issues being discussed.
    /// <see href="http://purl.org/spar/cito/citesAsPotentialSolution"></see></summary>
    let citesAsPotentialSolution = _prefix "citesAsPotentialSolution"
    /// <summary>
    /// The cited entity is cited as providing or containing a possible solution to the issues being discussed in the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedAsPontentialSolutionBy"></see></summary>
    let isCitedAsPontentialSolutionBy = _prefix "isCitedAsPontentialSolutionBy"
    /// <summary>
    /// The citing entity cites the cited entity as an item of recommended reading.  This property can be used, for example, to describe references in a lecture reading list, where the cited references are relevant to the general topic of the lecture, but might not be individually cited within the text of the lecture.  Similarly, it could be used to describe items in a 'Suggested further reading' list at the end of a book chapter.
    /// <see href="http://purl.org/spar/cito/citesAsRecommendedReading"></see></summary>
    let citesAsRecommendedReading = _prefix "citesAsRecommendedReading"
    /// <summary>
    /// The cited entity is cited by the citing entity as an item of recommended reading.  This property can be used, for example, to describe references in a lecture reading list, where the cited references are relevant to the general topic of the lecture, but might not be individually cited within the text of the lecture.  Similarly, it could be used to describe items in a 'Suggested further reading' list at the end of a book chapter.
    /// <see href="http://purl.org/spar/cito/isCitedAsRecommendedReadingBy"></see></summary>
    let isCitedAsRecommendedReadingBy = _prefix "isCitedAsRecommendedReadingBy"
    /// <summary>
    /// The citing entity cites the cited entity as one that is related.
    /// <see href="http://purl.org/spar/cito/citesAsRelated"></see></summary>
    let citesAsRelated = _prefix "citesAsRelated"
    /// <summary>
    /// The cited entity is cited as being related to the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedAsRelatedBy"></see></summary>
    let isCitedAsRelatedBy = _prefix "isCitedAsRelatedBy"
    /// <summary>
    /// The citing entity cites the cited entity as being the entity from which the citing entity is derived, or about which the citing entity contains metadata.
    /// <see href="http://purl.org/spar/cito/citesAsSourceDocument"></see></summary>
    let citesAsSourceDocument = _prefix "citesAsSourceDocument"
    /// <summary>
    /// The cited entity is cited as being the entity from which the citing entity is derived, or about which the citing entity contains metadata.
    /// <see href="http://purl.org/spar/cito/isCitedAsSourceDocumentBy"></see></summary>
    let isCitedAsSourceDocumentBy = _prefix "isCitedAsSourceDocumentBy"
    /// <summary>
    /// The citing entity cites the cited entity as a source of information on the subject under discussion.
    /// <see href="http://purl.org/spar/cito/citesForInformation"></see></summary>
    let citesForInformation = _prefix "citesForInformation"
    /// <summary>
    /// The cited entity is cited as a source of information on the subject under discussion in the citing entity.
    /// <see href="http://purl.org/spar/cito/isCitedForInformationBy"></see></summary>
    let isCitedForInformationBy = _prefix "isCitedForInformationBy"
    /// <summary>
    /// The citing entity is used to create or compile the cited entity.
    /// <see href="http://purl.org/spar/cito/compiles"></see></summary>
    let compiles = _prefix "compiles"
    /// <summary>
    /// The cited entity is the result of a compile or creation event using the citing entity.
    /// <see href="http://purl.org/spar/cito/isCompiledBy"></see></summary>
    let isCompiledBy = _prefix "isCompiledBy"
    /// <summary>
    /// The citing entity confirms facts, ideas or statements presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/confirms"></see></summary>
    let confirms = _prefix "confirms"
    /// <summary>
    /// The cited entity presents facts, ideas or statements that are confirmed by the citing entity.
    /// <see href="http://purl.org/spar/cito/isConfirmedBy"></see></summary>
    let isConfirmedBy = _prefix "isConfirmedBy"
    /// <summary>
    /// The citing entity contains a statement of fact or a logical assertion (or a collection of such facts and/or assertions) originally present in the cited entity.   This object property is designed to be used to relate a separate abstract, summary or nanopublication to the cited entity upon which it is based.
    /// <see href="http://purl.org/spar/cito/containsAssertionFrom"></see></summary>
    let containsAssertionFrom = _prefix "containsAssertionFrom"
    /// <summary>
    /// The cited entity contains and is the original source of a statement of fact or a logical assertion (or a collection of such facts and/or assertions) that is to be found in the citing entity.   This inverse object property is designed to be used to relate a cited entity to a separate abstract, summary or nanopublication based upon it.
    /// <see href="http://purl.org/spar/cito/providesAssertionFor"></see></summary>
    let providesAssertionFor = _prefix "providesAssertionFor"
    /// <summary>
    /// The citing entity corrects statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/corrects"></see></summary>
    let corrects = _prefix "corrects"
    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are corrected by the citing entity.
    /// <see href="http://purl.org/spar/cito/isCorrectedBy"></see></summary>
    let isCorrectedBy = _prefix "isCorrectedBy"
    /// <summary>
    /// The citing entity acknowledges contributions made by the cited entity.
    /// <see href="http://purl.org/spar/cito/credits"></see></summary>
    let credits = _prefix "credits"
    /// <summary>
    /// The cited entity makes contributions that are acknowledged by the citing entity.
    /// <see href="http://purl.org/spar/cito/isCreditedBy"></see></summary>
    let isCreditedBy = _prefix "isCreditedBy"
    /// <summary>
    /// The citing entity critiques statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/critiques"></see></summary>
    let critiques = _prefix "critiques"
    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are critiqued by the citing entity.
    /// <see href="http://purl.org/spar/cito/isCritiquedBy"></see></summary>
    let isCritiquedBy = _prefix "isCritiquedBy"
    /// <summary>
    /// The citing entity express derision for the cited entity, or for ideas or conclusions contained within it.
    /// <see href="http://purl.org/spar/cito/derides"></see></summary>
    let derides = _prefix "derides"
    /// <summary>
    /// The cited entity contains ideas or conclusions for which the citing entity express derision.
    /// <see href="http://purl.org/spar/cito/isDeridedBy"></see></summary>
    let isDeridedBy = _prefix "isDeridedBy"
    /// <summary>
    /// The citing entity describes the cited entity.
    /// <see href="http://purl.org/spar/cito/describes"></see></summary>
    let describes = _prefix "describes"
    /// <summary>
    /// The cited entity is described by the citing entity.
    /// <see href="http://purl.org/spar/cito/isDescribedBy"></see></summary>
    let isDescribedBy = _prefix "isDescribedBy"
    /// <summary>
    /// The citing entity disagrees with statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/disagreesWith"></see></summary>
    let disagreesWith = _prefix "disagreesWith"
    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are disagreed with by the citing entity.
    /// <see href="http://purl.org/spar/cito/isDisagreedWithBy"></see></summary>
    let isDisagreedWithBy = _prefix "isDisagreedWithBy"
    /// <summary>
    /// The citing entity discusses statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/discusses"></see></summary>
    let discusses = _prefix "discusses"
    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are discussed by the citing entity.
    /// <see href="http://purl.org/spar/cito/isDiscussedBy"></see></summary>
    let isDiscussedBy = _prefix "isDiscussedBy"
    /// <summary>
    /// The citing entity disputes statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/disputes"></see></summary>
    let disputes = _prefix "disputes"
    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are disputed by the citing entity.
    /// <see href="http://purl.org/spar/cito/isDisputedBy"></see></summary>
    let isDisputedBy = _prefix "isDisputedBy"
    /// <summary>
    /// The citing entity documents information about the cited entity.
    /// <see href="http://purl.org/spar/cito/documents"></see></summary>
    let documents = _prefix "documents"
    /// <summary>
    /// Information about the cited entity is documented by the citing entity.
    /// <see href="http://purl.org/spar/cito/isDocumentedBy"></see></summary>
    let isDocumentedBy = _prefix "isDocumentedBy"
    /// <summary>
    /// The citing entity extends facts, ideas or understandings presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/extends"></see></summary>
    let extends = _prefix "extends"
    /// <summary>
    /// The cited entity presents facts, ideas or understandings that are extended by the citing entity.
    /// <see href="http://purl.org/spar/cito/isExtendedBy"></see></summary>
    let isExtendedBy = _prefix "isExtendedBy"
    /// <summary>
    /// The cited entity provides background information for the citing entity.
    /// <see href="http://purl.org/spar/cito/givesBackgroundTo"></see></summary>
    let givesBackgroundTo = _prefix "givesBackgroundTo"
    /// <summary>
    /// The citing entity obtains background information from the cited entity.
    /// <see href="http://purl.org/spar/cito/obtainsBackgroundFrom"></see></summary>
    let obtainsBackgroundFrom = _prefix "obtainsBackgroundFrom"
    /// <summary>
    /// The cited entity provides intellectual or factual support for the citing entity.
    /// <see href="http://purl.org/spar/cito/givesSupportTo"></see></summary>
    let givesSupportTo = _prefix "givesSupportTo"
    /// <summary>
    /// The citing entity obtains intellectual or factual support from the cited entity.
    /// <see href="http://purl.org/spar/cito/obtainsSupportFrom"></see></summary>
    let obtainsSupportFrom = _prefix "obtainsSupportFrom"
    /// <summary>
    /// The date on which the citation was created. This has the same numerical value as the publication date of the citing bibliographic resource, but is a property of the citation itself.  When combined with the citation time span, it permits that citation to be located in history.
    /// <see href="http://purl.org/spar/cito/hasCitationCreationDate"></see></summary>
    let hasCitationCreationDate = _prefix "hasCitationCreationDate"
    /// <summary>
    /// The temporal characteristic of a citation, namely the interval between the publication date of the cited entity and the publication date of the citing entity. Note that when one or both of the publication dates is given as just 'year', then the citation time span is rounded to the nearest year, and when one or both of the publication dates is given as just 'year and month', then the citation time span is rounded to the nearest month, with the inherent inaccuracies that such rounding involves.
    /// <see href="http://purl.org/spar/cito/hasCitationTimeSpan"></see></summary>
    let hasCitationTimeSpan = _prefix "hasCitationTimeSpan"
    /// <summary>
    /// The cited entity evokes a reply from the citing entity.
    /// <see href="http://purl.org/spar/cito/hasReplyFrom"></see></summary>
    let hasReplyFrom = _prefix "hasReplyFrom"
    /// <summary>
    /// The citing entity replies to statements, ideas or criticisms presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/repliesTo"></see></summary>
    let repliesTo = _prefix "repliesTo"
    /// <summary>
    /// The citing entity includes one or more excerpts from the cited entity.
    /// <see href="http://purl.org/spar/cito/includesExcerptFrom"></see></summary>
    let includesExcerptFrom = _prefix "includesExcerptFrom"
    /// <summary>
    /// The cited entity contains information, usually of a textual nature, that is excerpted by (used as an excerpt within) the citing entity.
    /// <see href="http://purl.org/spar/cito/providesExcerptFor"></see></summary>
    let providesExcerptFor = _prefix "providesExcerptFor"
    /// <summary>
    /// The citing entity includes one or more quotations from the cited entity.
    /// <see href="http://purl.org/spar/cito/includesQuotationFrom"></see></summary>
    let includesQuotationFrom = _prefix "includesQuotationFrom"
    /// <summary>
    /// The cited entity contains information, usually of a textual nature, that is quoted by (used as a quotation within) the citing entity.
    /// <see href="http://purl.org/spar/cito/providesQuotationFor"></see></summary>
    let providesQuotationFor = _prefix "providesQuotationFor"
    /// <summary>
    /// The cited entity is the target for an HTTP Uniform Resource Locator (URL) link within the citing entity.
    /// <see href="http://purl.org/spar/cito/isLinkedToBy"></see></summary>
    let isLinkedToBy = _prefix "isLinkedToBy"
    /// <summary>
    /// The citing entity provides a link, in the form of an HTTP Uniform Resource Locator (URL), to the cited entity.
    /// <see href="http://purl.org/spar/cito/linksTo"></see></summary>
    let linksTo = _prefix "linksTo"
    /// <summary>
    /// The characteristic style or content of the cited entity is imitated by the citing entity for comic effect, usually without explicit citation.
    /// <see href="http://purl.org/spar/cito/isParodiedBy"></see></summary>
    let isParodiedBy = _prefix "isParodiedBy"
    /// <summary>
    /// The citing entity imitates the characteristic style or content of the cited entity for comic effect, usually without explicit citation.
    /// <see href="http://purl.org/spar/cito/parodies"></see></summary>
    let parodies = _prefix "parodies"
    /// <summary>
    /// The cited entity is plagiarized by the author of the citing entity, who includes within the citing entity textual or other elements from the cited entity without formal acknowledgement of their source. The cited entity is thus not explicitly cited from within the citing entity, according to the norms of scholarly practice, but is cited implicitly.
    /// <see href="http://purl.org/spar/cito/isPlagiarizedBy"></see></summary>
    let isPlagiarizedBy = _prefix "isPlagiarizedBy"
    /// <summary>
    /// A property indicating that the author of the citing entity plagiarizes the cited entity, by including textual or other elements from the cited entity without formal acknowledgement of their source.  The citing entity thus contains no explicit citation of the cited entity, according to the norms of scholarly practice, but cites it implicitly.
    /// <see href="http://purl.org/spar/cito/plagiarizes"></see></summary>
    let plagiarizes = _prefix "plagiarizes"
    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are qualified or have conditions placed upon them by the citing entity.
    /// <see href="http://purl.org/spar/cito/isQualifiedBy"></see></summary>
    let isQualifiedBy = _prefix "isQualifiedBy"
    /// <summary>
    /// The citing entity qualifies or places conditions or restrictions upon statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/qualifies"></see></summary>
    let qualifies = _prefix "qualifies"
    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are refuted by the citing entity.
    /// <see href="http://purl.org/spar/cito/isRefutedBy"></see></summary>
    let isRefutedBy = _prefix "isRefutedBy"
    /// <summary>
    /// The citing entity refutes statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/refutes"></see></summary>
    let refutes = _prefix "refutes"
    /// <summary>
    /// The cited entity is formally retracted by the citing entity.
    /// <see href="http://purl.org/spar/cito/isRetractedBy"></see></summary>
    let isRetractedBy = _prefix "isRetractedBy"
    /// <summary>
    /// The citing entity constitutes a formal retraction of the cited entity.
    /// <see href="http://purl.org/spar/cito/retracts"></see></summary>
    let retracts = _prefix "retracts"
    /// <summary>
    /// The cited entity presents statements, ideas or conclusions that are reviewed by the citing entity.
    /// <see href="http://purl.org/spar/cito/isReviewedBy"></see></summary>
    let isReviewedBy = _prefix "isReviewedBy"
    /// <summary>
    /// The citing entity reviews statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/reviews"></see></summary>
    let reviews = _prefix "reviews"
    /// <summary>
    /// The cited entity or aspects of its contents are ridiculed by the citing entity.
    /// <see href="http://purl.org/spar/cito/isRidiculedBy"></see></summary>
    let isRidiculedBy = _prefix "isRidiculedBy"
    /// <summary>
    /// The citing entity ridicules the cited entity or aspects of its contents.
    /// <see href="http://purl.org/spar/cito/ridicules"></see></summary>
    let ridicules = _prefix "ridicules"
    /// <summary>
    /// The cited entity is cited because the citing article contains speculations on its content or ideas.
    /// <see href="http://purl.org/spar/cito/isSpeculatedOnBy"></see></summary>
    let isSpeculatedOnBy = _prefix "isSpeculatedOnBy"
    /// <summary>
    /// The citing entity speculates on something within or related to the cited entity, without firm evidence.
    /// <see href="http://purl.org/spar/cito/speculatesOn"></see></summary>
    let speculatesOn = _prefix "speculatesOn"
    /// <summary>
    /// The cited entity receives intellectual or factual support from the citing entity.
    /// <see href="http://purl.org/spar/cito/isSupportedBy"></see></summary>
    let isSupportedBy = _prefix "isSupportedBy"
    /// <summary>
    /// The citing entity provides intellectual or factual support for statements, ideas or conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/supports"></see></summary>
    let supports = _prefix "supports"
    /// <summary>
    /// The cited entity presents statements, ideas, hypotheses or understanding that are updated by the cited entity.
    /// <see href="http://purl.org/spar/cito/isUpdatedBy"></see></summary>
    let isUpdatedBy = _prefix "isUpdatedBy"
    /// <summary>
    /// The citing entity updates statements, ideas, hypotheses or understanding presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/updates"></see></summary>
    let updates = _prefix "updates"
    /// <summary>
    /// A property that permits you to express appreciation of or interest in something that is the object of the RDF triple, or to express that it is worth thinking about even if you do not agree with its content, enabling social media 'likes' statements to be encoded in RDF.  Use of this property does NOT imply the existence of a formal citation of the entity that is 'liked'.
    /// <see href="http://purl.org/spar/cito/likes"></see></summary>
    let likes = _prefix "likes"
    /// <summary>
    /// The cited entity presents conclusions that are used in work described in the citing entity.
    /// <see href="http://purl.org/spar/cito/providesConclusionsFor"></see></summary>
    let providesConclusionsFor = _prefix "providesConclusionsFor"
    /// <summary>
    /// The citing entity describes work that uses conclusions presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/usesConclusionsFrom"></see></summary>
    let usesConclusionsFrom = _prefix "usesConclusionsFrom"
    /// <summary>
    /// The cited entity presents data that are used in work described in the citing entity.
    /// <see href="http://purl.org/spar/cito/providesDataFor"></see></summary>
    let providesDataFor = _prefix "providesDataFor"
    /// <summary>
    /// The citing entity describes work that uses data presented in the cited entity.
    /// <see href="http://purl.org/spar/cito/usesDataFrom"></see></summary>
    let usesDataFrom = _prefix "usesDataFrom"
    /// <summary>
    /// The cited entity details a method that is used in work described by the citing entity.
    /// <see href="http://purl.org/spar/cito/providesMethodFor"></see></summary>
    let providesMethodFor = _prefix "providesMethodFor"
    /// <summary>
    /// The citing entity describes work that uses a method detailed in the cited entity.
    /// <see href="http://purl.org/spar/cito/usesMethodIn"></see></summary>
    let usesMethodIn = _prefix "usesMethodIn"
    /// <summary>
    /// Each entity has at least one author that shares a common institutional affiliation with an author of the other entity.
    /// <see href="http://purl.org/spar/cito/sharesAuthorInstitutionWith"></see></summary>
    let sharesAuthorInstitutionWith = _prefix "sharesAuthorInstitutionWith"
    /// <summary>
    /// Each entity has at least one author in common with the other entity.
    /// <see href="http://purl.org/spar/cito/sharesAuthorWith"></see></summary>
    let sharesAuthorWith = _prefix "sharesAuthorWith"
    /// <summary>
    /// The two entities result from activities that have been funded by the same funding agency.
    /// <see href="http://purl.org/spar/cito/sharesFundingAgencyWith"></see></summary>
    let sharesFundingAgencyWith = _prefix "sharesFundingAgencyWith"
    /// <summary>
    /// The citing and cited bibliographic resources are published in the same journal.
    /// <see href="http://purl.org/spar/cito/sharesJournalWith"></see></summary>
    let sharesJournalWith = _prefix "sharesJournalWith"
    /// <summary>
    /// The citing and cited bibliographic resources are published in same publication venue.
    /// <see href="http://purl.org/spar/cito/sharesPublicationVenueWith"></see></summary>
    let sharesPublicationVenueWith = _prefix "sharesPublicationVenueWith"
