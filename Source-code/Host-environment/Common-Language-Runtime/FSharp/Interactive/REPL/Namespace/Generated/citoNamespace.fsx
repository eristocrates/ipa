#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cito =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/spar/cito/" "cito"
    let _2018_02_12 = _prefixId.prefix "2018-02-12"
    let _2018_02_16 = _prefixId.prefix "2018-02-16"
    /// <summary>
    ///   <para>rdfs:label : affilation self citation</para>
    ///   <para>rdfs:comment : A citation in which at least one author from each of the citing and the cited entities is affiliated with the same academic institution.
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
    ///      :paperA cito:sharesAuthorInstitutionWith :paperB .</para>
    ///   <a href="http://purl.org/spar/cito/AffilationSelfCitation">cito:AffilationSelfCitation</a>
    /// </summary>
    let AffilationSelfCitation = _prefixId.prefix "AffilationSelfCitation"
    /// <summary>
    ///   <para>rdfs:label : author network self citation</para>
    ///   <para>rdfs:comment : A citation in which at least one author of the citing entity has direct or indirect co-authorship links with one of the authors of the cited entity.</para>
    ///   <para>dce:description : Derived from the article 'A Small World of Citations? The Influence of Collaboration Networks on Citation Practices' by Matthew L. Wallace, Vincent Larivière and Yves Gingras, published in PLOS One (https://doi.org/10.1371/journal.pone.0033339).</para>
    ///   <a href="http://purl.org/spar/cito/AuthorNetworkSelfCitation">cito:AuthorNetworkSelfCitation</a>
    /// </summary>
    let AuthorNetworkSelfCitation = _prefixId.prefix "AuthorNetworkSelfCitation"
    /// <summary>
    ///   <para>rdfs:label : author self citation</para>
    ///   <para>rdfs:comment : A citation in which the citing and the cited entities have at least one author in common.
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
    ///      :paperA cito:sharesAuthorWith :paperB .</para>
    ///   <a href="http://purl.org/spar/cito/AuthorSelfCitation">cito:AuthorSelfCitation</a>
    /// </summary>
    let AuthorSelfCitation = _prefixId.prefix "AuthorSelfCitation"
    /// <summary>
    ///   <para>rdfs:label : citation</para>
    ///   <para>rdfs:comment : A citation is a conceptual directional link from a citing entity to a cited entity, created by a human performative act of making a citation, typically instantiated by the inclusion of a bibliographic reference (biro:BibliographicReference) in the reference list of the citing entity, or by the inclusion within the citing entity of a link, in the form of an HTTP Uniform Resource Locator (URL), to a resource on the World Wide Web.
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
    /// Such situations can be resolved by the creation of a user-defined citation characterization, for example by using the Open Annotation Data Model, as explained at http://semanticpublishing.wordpress.com/2013/07/03/extending-cito-for-open-annotations/.</para>
    ///   <a href="http://purl.org/spar/cito/Citation">cito:Citation</a>
    /// </summary>
    let Citation = _prefixId.prefix "Citation"
    /// <summary>
    ///   <para>dce:description : Derived from the article 'A Small World of Citations? The Influence of Collaboration Networks on Citation Practices' by Matthew L. Wallace, Vincent Larivière and Yves Gingras, published in PLOS One (https://doi.org/10.1371/journal.pone.0033339).</para>
    ///   <para>rdfs:label : distant citation</para>
    ///   <para>rdfs:comment : A citation in which the citing and the cited entities have nothing significant in common with one another (for example authors, journal, institutional affiliation, or funding agency) over and beyond their subject matter.</para>
    ///   <a href="http://purl.org/spar/cito/DistantCitation">cito:DistantCitation</a>
    /// </summary>
    let DistantCitation = _prefixId.prefix "DistantCitation"
    /// <summary>
    ///   <para>rdfs:label : funder self citation</para>
    ///   <para>rdfs:comment : A citation in which the works reported in the citing and the cited entities were funded by the same funding agency.
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
    ///      :paperA cito:sharesFundingAgencyWith :paperB .</para>
    ///   <a href="http://purl.org/spar/cito/FunderSelfCitation">cito:FunderSelfCitation</a>
    /// </summary>
    let FunderSelfCitation = _prefixId.prefix "FunderSelfCitation"
    /// <summary>
    ///   <para>rdfs:label : journal cartel citation</para>
    ///   <para>rdfs:comment : A citation from one journal to another journal which forms one of a very large number of citations from the citing journal to recent articles in the cited journal, possibly undertaken as part of a citation cartel for the purpose of gaming the impact factor of the cited journal.</para>
    ///   <para>dce:description : Derived from the blog post 'What do we know about journal citation cartels? A call for information' by Philippe Mongeon, Ludo Waltman and Sarah de Rijcke (https://www.cwts.nl/blog?article=n-q2w2b4).</para>
    ///   <a href="http://purl.org/spar/cito/JournalCartelCitation">cito:JournalCartelCitation</a>
    /// </summary>
    let JournalCartelCitation = _prefixId.prefix "JournalCartelCitation"
    /// <summary>
    ///   <para>rdfs:comment : A citation in which the citing and the cited entities are published in the same journal.
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
    ///      :paperA cito:sharesJournalWith :paperB .</para>
    ///   <para>rdfs:label : journal self citation</para>
    ///   <para>dce:description : Derived from the blog post 'Journal self-citations are increasingly biased toward impact factor years' by Ludo Waltman and Caspar Chorus (https://www.cwts.nl/blog?article=n-q2x264).</para>
    ///   <a href="http://purl.org/spar/cito/JournalSelfCitation">cito:JournalSelfCitation</a>
    /// </summary>
    let JournalSelfCitation = _prefixId.prefix "JournalSelfCitation"
    /// <summary>
    ///   <para>rdfs:label : self citation</para>
    ///   <para>rdfs:comment : A citation in which the citing and the cited entities have something significant in common with one another, over and beyond their subject matter, for example authors, journal, institutional affiliation, or funding agency.</para>
    ///   <a href="http://purl.org/spar/cito/SelfCitation">cito:SelfCitation</a>
    /// </summary>
    let SelfCitation = _prefixId.prefix "SelfCitation"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity agrees with statements, ideas or conclusions presented in the cited entity.</para>
    ///   <para>dce:description : Example: We share Galileo's opinion: the Earth moves [X].</para>
    ///   <para>rdfs:label : agrees with</para>
    ///   <a href="http://purl.org/spar/cito/agreesWith">cito:agreesWith</a>
    /// </summary>
    let agreesWith = _prefixId.prefix "agreesWith"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity cites the cited entity, either directly and explicitly (as in the reference list of a journal article), indirectly (e.g. by citing a more recent paper by the same group on the same topic), or implicitly (e.g. as in artistic quotations or parodies, or in cases of plagiarism).</para>
    ///   <para>rdfs:label : cites</para>
    ///   <a href="http://purl.org/spar/cito/cites">cito:cites</a>
    /// </summary>
    let cites = _prefixId.prefix "cites"
    /// <summary>
    ///   <para>dce:description : Example: Newton asserted that we are like dwarfs standing on the shoulders of giants [X].</para>
    ///   <para>rdfs:comment : The citing entity cites the cited entity as one that provides an authoritative description or definition of the subject under discussion.</para>
    ///   <para>rdfs:label : cites as authority</para>
    ///   <a href="http://purl.org/spar/cito/citesAsAuthority">cito:citesAsAuthority</a>
    /// </summary>
    let citesAsAuthority = _prefixId.prefix "citesAsAuthority"
    /// <summary>
    ///   <para>dce:description : Example: Italy has more than ten thousand kilometers of shoreline: see [X].</para>
    ///   <para>rdfs:label : cites as data source</para>
    ///   <para>rdfs:comment : The citing entity cites the cited entity as source of data.</para>
    ///   <a href="http://purl.org/spar/cito/citesAsDataSource">cito:citesAsDataSource</a>
    /// </summary>
    let citesAsDataSource = _prefixId.prefix "citesAsDataSource"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity cites the cited entity as source of factual evidence for statements it contains.</para>
    ///   <para>rdfs:label : cites as evidence</para>
    ///   <para>dce:description : Example: We found an unquestionable demonstration of our hypothesis in [X].</para>
    ///   <a href="http://purl.org/spar/cito/citesAsEvidence">cito:citesAsEvidence</a>
    /// </summary>
    let citesAsEvidence = _prefixId.prefix "citesAsEvidence"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity cites the cited entity as being the container of metadata describing the citing entity.</para>
    ///   <para>dce:description : Example: Basic bibliographic, entity and project metadata relating to this article, recorded in a structured machine-readable form, is available as an additional file [X] accompanying this paper.</para>
    ///   <para>rdfs:label : cites as metadata document</para>
    ///   <a href="http://purl.org/spar/cito/citesAsMetadataDocument">cito:citesAsMetadataDocument</a>
    /// </summary>
    let citesAsMetadataDocument = _prefixId.prefix "citesAsMetadataDocument"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity cites the cited entity as providing or containing a possible solution to the issues being discussed.</para>
    ///   <para>dce:description : Example: This risk could be avoided using the approach shown in [X].</para>
    ///   <para>rdfs:label : cites as potential solution</para>
    ///   <a href="http://purl.org/spar/cito/citesAsPotentialSolution">cito:citesAsPotentialSolution</a>
    /// </summary>
    let citesAsPotentialSolution = _prefixId.prefix "citesAsPotentialSolution"
    /// <summary>
    ///   <para>dce:description : Example: To our knowledge, [X] is the best source of exercises about UML, making it a valuable proposal for beginners.</para>
    ///   <para>rdfs:label : cites as recommended reading</para>
    ///   <para>rdfs:comment : The citing entity cites the cited entity as an item of recommended reading.  This property can be used, for example, to describe references in a lecture reading list, where the cited references are relevant to the general topic of the lecture, but might not be individually cited within the text of the lecture.  Similarly, it could be used to describe items in a 'Suggested further reading' list at the end of a book chapter.</para>
    ///   <a href="http://purl.org/spar/cito/citesAsRecommendedReading">cito:citesAsRecommendedReading</a>
    /// </summary>
    let citesAsRecommendedReading = _prefixId.prefix "citesAsRecommendedReading"
    /// <summary>
    ///   <para>rdfs:label : cites as related</para>
    ///   <para>rdfs:comment : The citing entity cites the cited entity as one that is related.</para>
    ///   <para>dce:description : Example: An analysis similar to what we proposed here is presented in [X].</para>
    ///   <a href="http://purl.org/spar/cito/citesAsRelated">cito:citesAsRelated</a>
    /// </summary>
    let citesAsRelated = _prefixId.prefix "citesAsRelated"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity cites the cited entity as being the entity from which the citing entity is derived, or about which the citing entity contains metadata.</para>
    ///   <para>dce:description : Example: Several sections of this work are based on our literature review of the topic published as journal article [X].</para>
    ///   <para>rdfs:label : cites as source document</para>
    ///   <a href="http://purl.org/spar/cito/citesAsSourceDocument">cito:citesAsSourceDocument</a>
    /// </summary>
    let citesAsSourceDocument = _prefixId.prefix "citesAsSourceDocument"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity cites the cited entity as a source of information on the subject under discussion.</para>
    ///   <para>dce:description : Example: The grammar of Pascal was introduced in [X].</para>
    ///   <para>rdfs:label : cites for information</para>
    ///   <a href="http://purl.org/spar/cito/citesForInformation">cito:citesForInformation</a>
    /// </summary>
    let citesForInformation = _prefixId.prefix "citesForInformation"
    /// <summary>
    ///   <para>dce:description : Note: This property has been imported from the CiTO4Data ontology, usage of which has been deprecated.dce:description : Example: This book gathers interviews with academic researchers of several disciplines [X].</para>
    ///   <para>rdfs:comment : The citing entity is used to create or compile the cited entity.</para>
    ///   <para>rdfs:label : compiles</para>
    ///   <a href="http://purl.org/spar/cito/compiles">cito:compiles</a>
    /// </summary>
    let compiles = _prefixId.prefix "compiles"
    /// <summary>
    ///   <para>dce:description : Example: Our findings are similar to those published in [X].</para>
    ///   <para>rdfs:comment : The citing entity confirms facts, ideas or statements presented in the cited entity.</para>
    ///   <para>rdfs:label : confirms</para>
    ///   <a href="http://purl.org/spar/cito/confirms">cito:confirms</a>
    /// </summary>
    let confirms = _prefixId.prefix "confirms"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity contains a statement of fact or a logical assertion (or a collection of such facts and/or assertions) originally present in the cited entity.   This object property is designed to be used to relate a separate abstract, summary or nanopublication to the cited entity upon which it is based.</para>
    ///   <para>dce:description : Example: We think that to stand on the top of giants [X] is a valuable principle to follow for our own research.</para>
    ///   <para>rdfs:label : contains assertion from</para>
    ///   <a href="http://purl.org/spar/cito/containsAssertionFrom">cito:containsAssertionFrom</a>
    /// </summary>
    let containsAssertionFrom = _prefixId.prefix "containsAssertionFrom"
    /// <summary>
    ///   <para>rdfs:label : corrects</para>
    ///   <para>rdfs:comment : The citing entity corrects statements, ideas or conclusions presented in the cited entity.</para>
    ///   <para>dce:description : Example: The result published in [X] is partially wrong, the correct result is 42.</para>
    ///   <a href="http://purl.org/spar/cito/corrects">cito:corrects</a>
    /// </summary>
    let corrects = _prefixId.prefix "corrects"
    /// <summary>
    ///   <para>rdfs:label : credits</para>
    ///   <para>dce:description : Example: Galileo was the first to observe Jupiter's satellites [X].</para>
    ///   <para>rdfs:comment : The citing entity acknowledges contributions made by the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/credits">cito:credits</a>
    /// </summary>
    let credits = _prefixId.prefix "credits"
    /// <summary>
    ///   <para>rdfs:label : critiques</para>
    ///   <para>dce:description : Example: The ideas presented in [X] are badly substantantiated.</para>
    ///   <para>rdfs:comment : The citing entity critiques statements, ideas or conclusions presented in the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/critiques">cito:critiques</a>
    /// </summary>
    let critiques = _prefixId.prefix "critiques"
    /// <summary>
    ///   <para>rdfs:label : derides</para>
    ///   <para>rdfs:comment : The citing entity express derision for the cited entity, or for ideas or conclusions contained within it.</para>
    ///   <para>dce:description : Example: The ideas published in [X] are incredibly stupid.</para>
    ///   <a href="http://purl.org/spar/cito/derides">cito:derides</a>
    /// </summary>
    let derides = _prefixId.prefix "derides"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity describes the cited entity.</para>
    ///   <para>rdfs:label : describes</para>
    ///   <para>dce:description : Example: Galileo's book [X] is a dialog among three scientists about Copernicus' eliocentric theory.</para>
    ///   <a href="http://purl.org/spar/cito/describes">cito:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:label : disagrees with</para>
    ///   <para>dce:description : Example: We do not share Galileo's opinion [X]: the Earth does not move.</para>
    ///   <para>rdfs:comment : The citing entity disagrees with statements, ideas or conclusions presented in the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/disagreesWith">cito:disagreesWith</a>
    /// </summary>
    let disagreesWith = _prefixId.prefix "disagreesWith"
    /// <summary>
    ///   <para>dce:description : Example: We now examine if Galileo is right when he writes [X] that the Earth moves.</para>
    ///   <para>rdfs:label : discusses</para>
    ///   <para>rdfs:comment : The citing entity discusses statements, ideas or conclusions presented in the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/discusses">cito:discusses</a>
    /// </summary>
    let discusses = _prefixId.prefix "discusses"
    /// <summary>
    ///   <para>dce:description : Example: We doubt that Galileo is right when he writes [X] that the Earth moves.</para>
    ///   <para>rdfs:label : disputes</para>
    ///   <para>rdfs:comment : The citing entity disputes statements, ideas or conclusions presented in the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/disputes">cito:disputes</a>
    /// </summary>
    let disputes = _prefixId.prefix "disputes"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity documents information about the cited entity.^^xsd:string</para>
    ///   <para>rdfs:label : documents</para>
    ///   <para>dce:description : Example: Herein we report in detail the complete set of ontological rules defined in the Overlapping Ontology [X].</para>
    ///   <a href="http://purl.org/spar/cito/documents">cito:documents</a>
    /// </summary>
    let documents = _prefixId.prefix "documents"
    /// <summary>
    ///   <para>rdfs:label : extends</para>
    ///   <para>dce:description : Example: We add to Galileo's findings concerning the Earth [X] that also the Moon moves.</para>
    ///   <para>rdfs:comment : The citing entity extends facts, ideas or understandings presented in the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/extends">cito:extends</a>
    /// </summary>
    let extends = _prefixId.prefix "extends"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity provides background information for the citing entity.</para>
    ///   <para>rdfs:label : gives background to</para>
    ///   <a href="http://purl.org/spar/cito/givesBackgroundTo">cito:givesBackgroundTo</a>
    /// </summary>
    let givesBackgroundTo = _prefixId.prefix "givesBackgroundTo"
    /// <summary>
    ///   <para>rdfs:label : gives support to</para>
    ///   <para>rdfs:comment : The cited entity provides intellectual or factual support for the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/givesSupportTo">cito:givesSupportTo</a>
    /// </summary>
    let givesSupportTo = _prefixId.prefix "givesSupportTo"
    /// <summary>
    ///   <para>rdfs:label : has citation characterization</para>
    ///   <para>rdfs:comment : A property that links a citation to its characterization made by using a CiTO citation characterization property such as cito:extends. This usage involved OWL2 punning, whenby a CiTO object property, such as the aforementioned cito:extends, is used as the object of an OWL assertion:
    ///
    ///      :thisCitation cito:hasCitationCharacterization cito:extends .
    ///
    /// In such cases of OWL punning, the CiTO object properties are simultaneously considered both as normal object properties and also as proper named individuals of the class owl:Thing.</para>
    ///   <a href="http://purl.org/spar/cito/hasCitationCharacterization">cito:hasCitationCharacterization</a>
    /// </summary>
    let hasCitationCharacterization = _prefixId.prefix "hasCitationCharacterization"
    /// <summary>
    ///   <para>rdfs:comment : The date on which the citation was created. This has the same numerical value as the publication date of the citing bibliographic resource, but is a property of the citation itself.  When combined with the citation time span, it permits that citation to be located in history.</para>
    ///   <para>rdfs:label : has citation creation date</para>
    ///   <a href="http://purl.org/spar/cito/hasCitationCreationDate">cito:hasCitationCreationDate</a>
    /// </summary>
    let hasCitationCreationDate = _prefixId.prefix "hasCitationCreationDate"
    /// <summary>
    ///   <para>rdfs:comment : The temporal characteristic of a citation, namely the interval between the publication date of the cited entity and the publication date of the citing entity. Note that when one or both of the publication dates is given as just 'year', then the citation time span is rounded to the nearest year, and when one or both of the publication dates is given as just 'year and month', then the citation time span is rounded to the nearest month, with the inherent inaccuracies that such rounding involves.</para>
    ///   <para>rdfs:label : has citation time span</para>
    ///   <a href="http://purl.org/spar/cito/hasCitationTimeSpan">cito:hasCitationTimeSpan</a>
    /// </summary>
    let hasCitationTimeSpan = _prefixId.prefix "hasCitationTimeSpan"
    /// <summary>
    ///   <para>rdfs:comment : A property that relates a citation to the cited entity.</para>
    ///   <para>rdfs:label : has cited entity</para>
    ///   <a href="http://purl.org/spar/cito/hasCitedEntity">cito:hasCitedEntity</a>
    /// </summary>
    let hasCitedEntity = _prefixId.prefix "hasCitedEntity"
    /// <summary>
    ///   <para>rdfs:label : has citing entity</para>
    ///   <para>rdfs:comment : A property that relates a citation to the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/hasCitingEntity">cito:hasCitingEntity</a>
    /// </summary>
    let hasCitingEntity = _prefixId.prefix "hasCitingEntity"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the minimal distance that one of the authors of the citing entity has with regards to one of the authors of the cited entity, according to their co-authorship network.
    ///
    /// For instance, a citation has a co-authorship citation level equal to 1 if at least one author of the citing entity has previously published as co-author with one of the authors of the cited entity. Similarly, we say that a citation has a co-authorship citation level equal to 2 if at least one author of the citing entity has previously published as co-author with someone who him/herself has previously published as co-author with one of the authors of the cited entity. And so on.</para>
    ///   <para>rdfs:label : has co-authorship citation level</para>
    ///   <a href="http://purl.org/spar/cito/hasCoAuthorshipCitationLevel">cito:hasCoAuthorshipCitationLevel</a>
    /// </summary>
    let hasCoAuthorshipCitationLevel = _prefixId.prefix "hasCoAuthorshipCitationLevel"
    /// <summary>
    ///   <para>rdfs:label : has reply from</para>
    ///   <para>rdfs:comment : The cited entity evokes a reply from the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/hasReplyFrom">cito:hasReplyFrom</a>
    /// </summary>
    let hasReplyFrom = _prefixId.prefix "hasReplyFrom"
    /// <summary>
    ///   <para>rdfs:label : includes excerpt from</para>
    ///   <para>rdfs:comment : The citing entity includes one or more excerpts from the cited entity.</para>
    ///   <para>dce:description : Example: In her work, the author states that even though most Human Information Behaviour researchers are familiar with the literature related to their studies, it is not uncommon for investigators to fail to see the benefits they may gain from previous mistakes [X].dce:description : An excerpt is more general than a quotation. It is generally used to indicate a re-published extract from a book, instruction manual, film, radio programme, etc, that need not be what someone said.  For example:
    ///
    /// Oxford 01865
    /// Oxshott 01372
    /// Oxted 01883
    /// Oxton 01578
    ///
    /// is an excerpt from the UK Dialling Codes section of the Oxford Telephone Directory.</para>
    ///   <a href="http://purl.org/spar/cito/includesExcerptFrom">cito:includesExcerptFrom</a>
    /// </summary>
    let includesExcerptFrom = _prefixId.prefix "includesExcerptFrom"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity includes one or more quotations from the cited entity.</para>
    ///   <para>dce:description : A quotation is a repetition of what someone has said, and is presented "within quotation marks", for example:
    ///
    /// On June 4th 1940, Winston Churchill made a speech on the radio that has since become famous, that included the words: " . . . we shall fight on the beaches, we shall fight on the landing grounds, we shall fight in the fields and in the streets, we shall fight in the hills; we shall never surrender . . ."dce:description : Example: As Newton wrote in [X]: "We are like dwarfs standing on the shoulders of giants".</para>
    ///   <para>rdfs:label : includes quotation from</para>
    ///   <a href="http://purl.org/spar/cito/includesQuotationFrom">cito:includesQuotationFrom</a>
    /// </summary>
    let includesQuotationFrom = _prefixId.prefix "includesQuotationFrom"
    /// <summary>
    ///   <para>rdfs:label : is agreed with by</para>
    ///   <para>rdfs:comment : The cited entity contains statements, ideas or conclusions with which the citing entity agrees.</para>
    ///   <a href="http://purl.org/spar/cito/isAgreedWithBy">cito:isAgreedWithBy</a>
    /// </summary>
    let isAgreedWithBy = _prefixId.prefix "isAgreedWithBy"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity is cited as providing an authoritative description or definition of the subject under discussion in the citing entity.</para>
    ///   <para>rdfs:label : is cited as authority by</para>
    ///   <a href="http://purl.org/spar/cito/isCitedAsAuthorityBy">cito:isCitedAsAuthorityBy</a>
    /// </summary>
    let isCitedAsAuthorityBy = _prefixId.prefix "isCitedAsAuthorityBy"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity is cited as a data source by the citing entity.</para>
    ///   <para>rdfs:label : is cited as data source by</para>
    ///   <a href="http://purl.org/spar/cito/isCitedAsDataSourceBy">cito:isCitedAsDataSourceBy</a>
    /// </summary>
    let isCitedAsDataSourceBy = _prefixId.prefix "isCitedAsDataSourceBy"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity is cited for providing factual evidence to the citing entity.</para>
    ///   <para>rdfs:label : is cited as evidence by</para>
    ///   <a href="http://purl.org/spar/cito/isCitedAsEvidenceBy">cito:isCitedAsEvidenceBy</a>
    /// </summary>
    let isCitedAsEvidenceBy = _prefixId.prefix "isCitedAsEvidenceBy"
    /// <summary>
    ///   <para>rdfs:label : is cited as metadata document by</para>
    ///   <para>rdfs:comment : The cited entity is cited as being the container of metadata relating to the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isCitedAsMetadataDocumentBy">cito:isCitedAsMetadataDocumentBy</a>
    /// </summary>
    let isCitedAsMetadataDocumentBy = _prefixId.prefix "isCitedAsMetadataDocumentBy"
    /// <summary>
    ///   <para>rdfs:label : is cited as potential solution by</para>
    ///   <para>rdfs:comment : The cited entity is cited as providing or containing a possible solution to the issues being discussed in the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isCitedAsPontentialSolutionBy">cito:isCitedAsPontentialSolutionBy</a>
    /// </summary>
    let isCitedAsPontentialSolutionBy = _prefixId.prefix "isCitedAsPontentialSolutionBy"
    /// <summary>
    ///   <para>rdfs:label : is cited as recommended reading by</para>
    ///   <para>rdfs:comment : The cited entity is cited by the citing entity as an item of recommended reading.  This property can be used, for example, to describe references in a lecture reading list, where the cited references are relevant to the general topic of the lecture, but might not be individually cited within the text of the lecture.  Similarly, it could be used to describe items in a 'Suggested further reading' list at the end of a book chapter.</para>
    ///   <a href="http://purl.org/spar/cito/isCitedAsRecommendedReadingBy">cito:isCitedAsRecommendedReadingBy</a>
    /// </summary>
    let isCitedAsRecommendedReadingBy = _prefixId.prefix "isCitedAsRecommendedReadingBy"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity is cited as being related to the citing entity.</para>
    ///   <para>rdfs:label : is cited as related by</para>
    ///   <a href="http://purl.org/spar/cito/isCitedAsRelatedBy">cito:isCitedAsRelatedBy</a>
    /// </summary>
    let isCitedAsRelatedBy = _prefixId.prefix "isCitedAsRelatedBy"
    /// <summary>
    ///   <para>rdfs:label : is cited as source document by</para>
    ///   <para>rdfs:comment : The cited entity is cited as being the entity from which the citing entity is derived, or about which the citing entity contains metadata.</para>
    ///   <a href="http://purl.org/spar/cito/isCitedAsSourceDocumentBy">cito:isCitedAsSourceDocumentBy</a>
    /// </summary>
    let isCitedAsSourceDocumentBy = _prefixId.prefix "isCitedAsSourceDocumentBy"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity (the subject of the RDF triple) is cited by the citing entity (the object of the triple).</para>
    ///   <para>rdfs:label : is cited by</para>
    ///   <a href="http://purl.org/spar/cito/isCitedBy">cito:isCitedBy</a>
    /// </summary>
    let isCitedBy = _prefixId.prefix "isCitedBy"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity is cited as a source of information on the subject under discussion in the citing entity.</para>
    ///   <para>rdfs:label : is cited for information by</para>
    ///   <a href="http://purl.org/spar/cito/isCitedForInformationBy">cito:isCitedForInformationBy</a>
    /// </summary>
    let isCitedForInformationBy = _prefixId.prefix "isCitedForInformationBy"
    /// <summary>
    ///   <para>rdfs:label : is compiled by</para>
    ///   <para>dce:description : Note: This property has been imported from the CiTO4Data ontology, usage of which has been deprecated.</para>
    ///   <para>rdfs:comment : The cited entity is the result of a compile or creation event using the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isCompiledBy">cito:isCompiledBy</a>
    /// </summary>
    let isCompiledBy = _prefixId.prefix "isCompiledBy"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity presents facts, ideas or statements that are confirmed by the citing entity.</para>
    ///   <para>rdfs:label : is confirmed by</para>
    ///   <a href="http://purl.org/spar/cito/isConfirmedBy">cito:isConfirmedBy</a>
    /// </summary>
    let isConfirmedBy = _prefixId.prefix "isConfirmedBy"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity presents statements, ideas or conclusions that are corrected by the citing entity.</para>
    ///   <para>rdfs:label : is corrected by</para>
    ///   <a href="http://purl.org/spar/cito/isCorrectedBy">cito:isCorrectedBy</a>
    /// </summary>
    let isCorrectedBy = _prefixId.prefix "isCorrectedBy"
    /// <summary>
    ///   <para>rdfs:label : is credited by</para>
    ///   <para>rdfs:comment : The cited entity makes contributions that are acknowledged by the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isCreditedBy">cito:isCreditedBy</a>
    /// </summary>
    let isCreditedBy = _prefixId.prefix "isCreditedBy"
    /// <summary>
    ///   <para>rdfs:label : is critiqued by</para>
    ///   <para>rdfs:comment : The cited entity presents statements, ideas or conclusions that are critiqued by the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isCritiquedBy">cito:isCritiquedBy</a>
    /// </summary>
    let isCritiquedBy = _prefixId.prefix "isCritiquedBy"
    /// <summary>
    ///   <para>rdfs:label : is derided by</para>
    ///   <para>rdfs:comment : The cited entity contains ideas or conclusions for which the citing entity express derision.</para>
    ///   <a href="http://purl.org/spar/cito/isDeridedBy">cito:isDeridedBy</a>
    /// </summary>
    let isDeridedBy = _prefixId.prefix "isDeridedBy"
    /// <summary>
    ///   <para>rdfs:label : is described by</para>
    ///   <para>rdfs:comment : The cited entity is described by the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isDescribedBy">cito:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>rdfs:label : is disagreed with by</para>
    ///   <para>rdfs:comment : The cited entity presents statements, ideas or conclusions that are disagreed with by the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isDisagreedWithBy">cito:isDisagreedWithBy</a>
    /// </summary>
    let isDisagreedWithBy = _prefixId.prefix "isDisagreedWithBy"
    /// <summary>
    ///   <para>rdfs:label : is discussed by</para>
    ///   <para>rdfs:comment : The cited entity presents statements, ideas or conclusions that are discussed by the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isDiscussedBy">cito:isDiscussedBy</a>
    /// </summary>
    let isDiscussedBy = _prefixId.prefix "isDiscussedBy"
    /// <summary>
    ///   <para>rdfs:label : is disputed by</para>
    ///   <para>rdfs:comment : The cited entity presents statements, ideas or conclusions that are disputed by the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isDisputedBy">cito:isDisputedBy</a>
    /// </summary>
    let isDisputedBy = _prefixId.prefix "isDisputedBy"
    /// <summary>
    ///   <para>rdfs:label : is documented by</para>
    ///   <para>rdfs:comment : Information about the cited entity is documented by the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isDocumentedBy">cito:isDocumentedBy</a>
    /// </summary>
    let isDocumentedBy = _prefixId.prefix "isDocumentedBy"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity presents facts, ideas or understandings that are extended by the citing entity.</para>
    ///   <para>rdfs:label : is extended by</para>
    ///   <a href="http://purl.org/spar/cito/isExtendedBy">cito:isExtendedBy</a>
    /// </summary>
    let isExtendedBy = _prefixId.prefix "isExtendedBy"
    /// <summary>
    ///   <para>rdfs:label : is linked to by</para>
    ///   <para>rdfs:comment : The cited entity is the target for an HTTP Uniform Resource Locator (URL) link within the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isLinkedToBy">cito:isLinkedToBy</a>
    /// </summary>
    let isLinkedToBy = _prefixId.prefix "isLinkedToBy"
    /// <summary>
    ///   <para>rdfs:comment : The characteristic style or content of the cited entity is imitated by the citing entity for comic effect, usually without explicit citation.</para>
    ///   <para>rdfs:label : is parodied by</para>
    ///   <a href="http://purl.org/spar/cito/isParodiedBy">cito:isParodiedBy</a>
    /// </summary>
    let isParodiedBy = _prefixId.prefix "isParodiedBy"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity is plagiarized by the author of the citing entity, who includes within the citing entity textual or other elements from the cited entity without formal acknowledgement of their source. The cited entity is thus not explicitly cited from within the citing entity, according to the norms of scholarly practice, but is cited implicitly.</para>
    ///   <para>rdfs:label : is plagiarized by</para>
    ///   <a href="http://purl.org/spar/cito/isPlagiarizedBy">cito:isPlagiarizedBy</a>
    /// </summary>
    let isPlagiarizedBy = _prefixId.prefix "isPlagiarizedBy"
    /// <summary>
    ///   <para>rdfs:label : is qualified by</para>
    ///   <para>rdfs:comment : The cited entity presents statements, ideas or conclusions that are qualified or have conditions placed upon them by the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isQualifiedBy">cito:isQualifiedBy</a>
    /// </summary>
    let isQualifiedBy = _prefixId.prefix "isQualifiedBy"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity presents statements, ideas or conclusions that are refuted by the citing entity.</para>
    ///   <para>rdfs:label : is refuted by</para>
    ///   <a href="http://purl.org/spar/cito/isRefutedBy">cito:isRefutedBy</a>
    /// </summary>
    let isRefutedBy = _prefixId.prefix "isRefutedBy"
    /// <summary>
    ///   <para>rdfs:label : is retracted by</para>
    ///   <para>rdfs:comment : The cited entity is formally retracted by the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isRetractedBy">cito:isRetractedBy</a>
    /// </summary>
    let isRetractedBy = _prefixId.prefix "isRetractedBy"
    /// <summary>
    ///   <para>rdfs:label : is reviewed by</para>
    ///   <para>rdfs:comment : The cited entity presents statements, ideas or conclusions that are reviewed by the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isReviewedBy">cito:isReviewedBy</a>
    /// </summary>
    let isReviewedBy = _prefixId.prefix "isReviewedBy"
    /// <summary>
    ///   <para>rdfs:label : is ridiculed by</para>
    ///   <para>rdfs:comment : The cited entity or aspects of its contents are ridiculed by the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isRidiculedBy">cito:isRidiculedBy</a>
    /// </summary>
    let isRidiculedBy = _prefixId.prefix "isRidiculedBy"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity is cited because the citing article contains speculations on its content or ideas.</para>
    ///   <para>rdfs:label : is speculated on by</para>
    ///   <a href="http://purl.org/spar/cito/isSpeculatedOnBy">cito:isSpeculatedOnBy</a>
    /// </summary>
    let isSpeculatedOnBy = _prefixId.prefix "isSpeculatedOnBy"
    /// <summary>
    ///   <para>rdfs:label : is supported by</para>
    ///   <para>rdfs:comment : The cited entity receives intellectual or factual support from the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/isSupportedBy">cito:isSupportedBy</a>
    /// </summary>
    let isSupportedBy = _prefixId.prefix "isSupportedBy"
    /// <summary>
    ///   <para>rdfs:label : is updated by</para>
    ///   <para>rdfs:comment : The cited entity presents statements, ideas, hypotheses or understanding that are updated by the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/isUpdatedBy">cito:isUpdatedBy</a>
    /// </summary>
    let isUpdatedBy = _prefixId.prefix "isUpdatedBy"
    /// <summary>
    ///   <para>rdfs:comment : A property that permits you to express appreciation of or interest in something that is the object of the RDF triple, or to express that it is worth thinking about even if you do not agree with its content, enabling social media 'likes' statements to be encoded in RDF.  Use of this property does NOT imply the existence of a formal citation of the entity that is 'liked'.</para>
    ///   <para>rdfs:label : likes</para>
    ///   <a href="http://purl.org/spar/cito/likes">cito:likes</a>
    /// </summary>
    let likes = _prefixId.prefix "likes"
    /// <summary>
    ///   <para>rdfs:label : links to</para>
    ///   <para>rdfs:comment : The citing entity provides a link, in the form of an HTTP Uniform Resource Locator (URL), to the cited entity.</para>
    ///   <para>dce:description : Example: The BioSharing registry (https://biosharing.org) can be of use as it describes the standards in detail, including versions where applicable.</para>
    ///   <a href="http://purl.org/spar/cito/linksTo">cito:linksTo</a>
    /// </summary>
    let linksTo = _prefixId.prefix "linksTo"
    /// <summary>
    ///   <para>dce:description : Example: There is a need for more observational studies and studies using narrative causation to describe the potential contribution of information in problem-solving and decision-making [X]; our work addresses these needs.</para>
    ///   <para>rdfs:label : obtains background from</para>
    ///   <para>rdfs:comment : The citing entity obtains background information from the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/obtainsBackgroundFrom">cito:obtainsBackgroundFrom</a>
    /// </summary>
    let obtainsBackgroundFrom = _prefixId.prefix "obtainsBackgroundFrom"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity obtains intellectual or factual support from the cited entity.</para>
    ///   <para>rdfs:label : obtains support from</para>
    ///   <para>dce:description : Example: Our ideas were also shared by Doe et al. [X].</para>
    ///   <a href="http://purl.org/spar/cito/obtainsSupportFrom">cito:obtainsSupportFrom</a>
    /// </summary>
    let obtainsSupportFrom = _prefixId.prefix "obtainsSupportFrom"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity imitates the characteristic style or content of the cited entity for comic effect, usually without explicit citation.</para>
    ///   <para>rdfs:label : parodies</para>
    ///   <para>dce:description : Example: We act as giants on the shoulders of dwarfs [X]!</para>
    ///   <a href="http://purl.org/spar/cito/parodies">cito:parodies</a>
    /// </summary>
    let parodies = _prefixId.prefix "parodies"
    /// <summary>
    ///   <para>rdfs:comment : A property indicating that the author of the citing entity plagiarizes the cited entity, by including textual or other elements from the cited entity without formal acknowledgement of their source.  The citing entity thus contains no explicit citation of the cited entity, according to the norms of scholarly practice, but cites it implicitly.</para>
    ///   <para>rdfs:label : plagiarizes</para>
    ///   <para>dce:description : Example: The conclusion of our dissertation can be summarised by the following motto, we created specifically for this purpose: we are like dwarfs standing on the shoulders of giants.</para>
    ///   <a href="http://purl.org/spar/cito/plagiarizes">cito:plagiarizes</a>
    /// </summary>
    let plagiarizes = _prefixId.prefix "plagiarizes"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity contains and is the original source of a statement of fact or a logical assertion (or a collection of such facts and/or assertions) that is to be found in the citing entity.   This inverse object property is designed to be used to relate a cited entity to a separate abstract, summary or nanopublication based upon it.</para>
    ///   <para>rdfs:label : provides assertion for</para>
    ///   <a href="http://purl.org/spar/cito/providesAssertionFor">cito:providesAssertionFor</a>
    /// </summary>
    let providesAssertionFor = _prefixId.prefix "providesAssertionFor"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity presents conclusions that are used in work described in the citing entity.</para>
    ///   <para>rdfs:label : provides conclusions for</para>
    ///   <a href="http://purl.org/spar/cito/providesConclusionsFor">cito:providesConclusionsFor</a>
    /// </summary>
    let providesConclusionsFor = _prefixId.prefix "providesConclusionsFor"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity presents data that are used in work described in the citing entity.</para>
    ///   <para>rdfs:label : provides data for</para>
    ///   <a href="http://purl.org/spar/cito/providesDataFor">cito:providesDataFor</a>
    /// </summary>
    let providesDataFor = _prefixId.prefix "providesDataFor"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity contains information, usually of a textual nature, that is excerpted by (used as an excerpt within) the citing entity.</para>
    ///   <para>rdfs:label : provides excerpt for</para>
    ///   <a href="http://purl.org/spar/cito/providesExcerptFor">cito:providesExcerptFor</a>
    /// </summary>
    let providesExcerptFor = _prefixId.prefix "providesExcerptFor"
    /// <summary>
    ///   <para>rdfs:label : provides method for</para>
    ///   <para>rdfs:comment : The cited entity details a method that is used in work described by the citing entity.</para>
    ///   <a href="http://purl.org/spar/cito/providesMethodFor">cito:providesMethodFor</a>
    /// </summary>
    let providesMethodFor = _prefixId.prefix "providesMethodFor"
    /// <summary>
    ///   <para>rdfs:comment : The cited entity contains information, usually of a textual nature, that is quoted by (used as a quotation within) the citing entity.</para>
    ///   <para>rdfs:label : provides quotation for</para>
    ///   <a href="http://purl.org/spar/cito/providesQuotationFor">cito:providesQuotationFor</a>
    /// </summary>
    let providesQuotationFor = _prefixId.prefix "providesQuotationFor"
    /// <summary>
    ///   <para>dce:description : Example: Galileo's masterpiece 'Dialogo sopra i due massimi sistemi del mondo' [X] is formally a dialog and substantially a scientific pamphlet.</para>
    ///   <para>rdfs:label : qualifies</para>
    ///   <para>rdfs:comment : The citing entity qualifies or places conditions or restrictions upon statements, ideas or conclusions presented in the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/qualifies">cito:qualifies</a>
    /// </summary>
    let qualifies = _prefixId.prefix "qualifies"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity refutes statements, ideas or conclusions presented in the cited entity.</para>
    ///   <para>dce:description : Example: We do not think that all their arguments in favour of their own and against the other strategies are equally convincing [X].</para>
    ///   <para>rdfs:label : refutes</para>
    ///   <a href="http://purl.org/spar/cito/refutes">cito:refutes</a>
    /// </summary>
    let refutes = _prefixId.prefix "refutes"
    /// <summary>
    ///   <para>rdfs:label : replies to</para>
    ///   <para>dce:description : Example: We will not investigate the issues of the approach proposed in [X] here, but rather we introduce yet another alternative.</para>
    ///   <para>rdfs:comment : The citing entity replies to statements, ideas or criticisms presented in the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/repliesTo">cito:repliesTo</a>
    /// </summary>
    let repliesTo = _prefixId.prefix "repliesTo"
    /// <summary>
    ///   <para>dce:description : Example: We wrote that the Earth moves in [X]; we now retire such statement.</para>
    ///   <para>rdfs:comment : The citing entity constitutes a formal retraction of the cited entity.</para>
    ///   <para>rdfs:label : retracts</para>
    ///   <a href="http://purl.org/spar/cito/retracts">cito:retracts</a>
    /// </summary>
    let retracts = _prefixId.prefix "retracts"
    /// <summary>
    ///   <para>dce:description : Example: This paper discusses Toulmin's methodology in modelling argumentation [X], focussing on highlighting advantages and drawbacks of the application of such a methodology in the Social Web.</para>
    ///   <para>rdfs:label : reviews</para>
    ///   <para>rdfs:comment : The citing entity reviews statements, ideas or conclusions presented in the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/reviews">cito:reviews</a>
    /// </summary>
    let reviews = _prefixId.prefix "reviews"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity ridicules the cited entity or aspects of its contents.</para>
    ///   <para>rdfs:label : ridicules</para>
    ///   <para>dce:description : Example: Galileo said that the Earth "moves" [X]; really? And where is it going?</para>
    ///   <a href="http://purl.org/spar/cito/ridicules">cito:ridicules</a>
    /// </summary>
    let ridicules = _prefixId.prefix "ridicules"
    /// <summary>
    ///   <para>rdfs:label : shares author institution with</para>
    ///   <para>rdfs:comment : Each entity has at least one author that shares a common institutional affiliation with an author of the other entity.</para>
    ///   <a href="http://purl.org/spar/cito/sharesAuthorInstitutionWith">cito:sharesAuthorInstitutionWith</a>
    /// </summary>
    let sharesAuthorInstitutionWith = _prefixId.prefix "sharesAuthorInstitutionWith"
    /// <summary>
    ///   <para>rdfs:comment : Each entity has at least one author in common with the other entity.</para>
    ///   <para>rdfs:label : shares author with</para>
    ///   <a href="http://purl.org/spar/cito/sharesAuthorWith">cito:sharesAuthorWith</a>
    /// </summary>
    let sharesAuthorWith = _prefixId.prefix "sharesAuthorWith"
    /// <summary>
    ///   <para>rdfs:comment : The two entities result from activities that have been funded by the same funding agency.</para>
    ///   <para>rdfs:label : shares funding agency with</para>
    ///   <a href="http://purl.org/spar/cito/sharesFundingAgencyWith">cito:sharesFundingAgencyWith</a>
    /// </summary>
    let sharesFundingAgencyWith = _prefixId.prefix "sharesFundingAgencyWith"
    /// <summary>
    ///   <para>rdfs:label : shares journal with</para>
    ///   <para>rdfs:comment : The citing and cited bibliographic resources are published in the same journal.</para>
    ///   <a href="http://purl.org/spar/cito/sharesJournalWith">cito:sharesJournalWith</a>
    /// </summary>
    let sharesJournalWith = _prefixId.prefix "sharesJournalWith"
    /// <summary>
    ///   <para>rdfs:comment : The citing and cited bibliographic resources are published in same publication venue.</para>
    ///   <para>rdfs:label : shares publication venue with</para>
    ///   <a href="http://purl.org/spar/cito/sharesPublicationVenueWith">cito:sharesPublicationVenueWith</a>
    /// </summary>
    let sharesPublicationVenueWith = _prefixId.prefix "sharesPublicationVenueWith"
    /// <summary>
    ///   <para>dce:description : Example: We believe that if Galileo believed that Earth goes around the Sun [X], he also should believe that Moon goes around Earth.</para>
    ///   <para>rdfs:label : speculates on</para>
    ///   <para>rdfs:comment : The citing entity speculates on something within or related to the cited entity, without firm evidence.</para>
    ///   <a href="http://purl.org/spar/cito/speculatesOn">cito:speculatesOn</a>
    /// </summary>
    let speculatesOn = _prefixId.prefix "speculatesOn"
    /// <summary>
    ///   <para>rdfs:label : supports</para>
    ///   <para>dce:description : Example: We support Galileo's statement [X], that Earth moves.</para>
    ///   <para>rdfs:comment : The citing entity provides intellectual or factual support for statements, ideas or conclusions presented in the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/supports">cito:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    /// <summary>
    ///   <para>rdfs:label : updates</para>
    ///   <para>dce:description : Example: Earth moves, said Galileo [X]; in addition, we can say now it moves very fast.</para>
    ///   <para>rdfs:comment : The citing entity updates statements, ideas, hypotheses or understanding presented in the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/updates">cito:updates</a>
    /// </summary>
    let updates = _prefixId.prefix "updates"
    /// <summary>
    ///   <para>dce:description : Example: Building upon Galileo's findings [X], we discovered that all the planets move.</para>
    ///   <para>rdfs:label : uses conclusions from</para>
    ///   <para>rdfs:comment : The citing entity describes work that uses conclusions presented in the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/usesConclusionsFrom">cito:usesConclusionsFrom</a>
    /// </summary>
    let usesConclusionsFrom = _prefixId.prefix "usesConclusionsFrom"
    /// <summary>
    ///   <para>rdfs:comment : The citing entity describes work that uses data presented in the cited entity.</para>
    ///   <para>rdfs:label : uses data from</para>
    ///   <para>dce:description : Example: Using the information collected from our recent study [X], we can estimate that there are tens of millions of HTML forms with potentially useful deep-web content.</para>
    ///   <a href="http://purl.org/spar/cito/usesDataFrom">cito:usesDataFrom</a>
    /// </summary>
    let usesDataFrom = _prefixId.prefix "usesDataFrom"
    /// <summary>
    ///   <para>dce:description : Example: We follow [X] in using design patterns for testing.</para>
    ///   <para>rdfs:label : uses method in</para>
    ///   <para>rdfs:comment : The citing entity describes work that uses a method detailed in the cited entity.</para>
    ///   <a href="http://purl.org/spar/cito/usesMethodIn">cito:usesMethodIn</a>
    /// </summary>
    let usesMethodIn = _prefixId.prefix "usesMethodIn"
