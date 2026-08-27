namespace http.purl.org.spar.cito.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cito =
    let _namespace_iri = Namespace_Iri cito |> NamespaceIRI
    /// <summary>
    ///   <para>cito:</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"CiTO (Citation Typing Ontology)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/">http://purl.org/spar/cito/</seealso>
    let _prefix_iri = Prefixed_Name(cito, "") |> PrefixedName
    /// <summary>
    ///   <para>cito:2018-02-12</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/cito/2018-02-12">http://purl.org/spar/cito/2018-02-12</seealso>
    let _2018_02_12 = Prefixed_Name(cito, "2018-02-12") |> PrefixedName
    /// <summary>
    ///   <para>cito:2018-02-16</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/cito/2018-02-16">http://purl.org/spar/cito/2018-02-16</seealso>
    let _2018_02_16 = Prefixed_Name(cito, "2018-02-16") |> PrefixedName

    /// <summary>
    ///   <para>cito:AffilationSelfCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A citation in which at least one author from each of the citing and the cited entities is affiliated with the same academic institution.
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
    ///      :paperA cito:sharesAuthorInstitutionWith :paperB ."</para>
    /// labels<para>"affilation self citation"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/AffilationSelfCitation">http://purl.org/spar/cito/AffilationSelfCitation</seealso>
    let AffilationSelfCitation =
        Prefixed_Name(cito, "AffilationSelfCitation") |> PrefixedName

    /// <summary>
    ///   <para>cito:AuthorNetworkSelfCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A citation in which at least one author of the citing entity has direct or indirect co-authorship links with one of the authors of the cited entity."</para>
    /// labels<para>"author network self citation"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/AuthorNetworkSelfCitation">http://purl.org/spar/cito/AuthorNetworkSelfCitation</seealso>
    let AuthorNetworkSelfCitation =
        Prefixed_Name(cito, "AuthorNetworkSelfCitation") |> PrefixedName

    /// <summary>
    ///   <para>cito:AuthorSelfCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A citation in which the citing and the cited entities have at least one author in common.
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
    ///      :paperA cito:sharesAuthorWith :paperB ."</para>
    /// labels<para>"author self citation"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/AuthorSelfCitation">http://purl.org/spar/cito/AuthorSelfCitation</seealso>
    let AuthorSelfCitation = Prefixed_Name(cito, "AuthorSelfCitation") |> PrefixedName
    /// <summary>
    ///   <para>cito:Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A citation is a conceptual directional link from a citing entity to a cited entity, created by a human performative act of making a citation, typically instantiated by the inclusion of a bibliographic reference (biro:BibliographicReference) in the reference list of the citing entity, or by the inclusion within the citing entity of a link, in the form of an HTTP Uniform Resource Locator (URL), to a resource on the World Wide Web.
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
    /// Such situations can be resolved by the creation of a user-defined citation characterization, for example by using the Open Annotation Data Model, as explained at http://semanticpublishing.wordpress.com/2013/07/03/extending-cito-for-open-annotations/."</para>
    /// labels<para>"citation"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/Citation">http://purl.org/spar/cito/Citation</seealso>
    let Citation = Prefixed_Name(cito, "Citation") |> PrefixedName
    /// <summary>
    ///   <para>cito:DistantCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A citation in which the citing and the cited entities have nothing significant in common with one another (for example authors, journal, institutional affiliation, or funding agency) over and beyond their subject matter."</para>
    /// labels<para>"distant citation"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/DistantCitation">http://purl.org/spar/cito/DistantCitation</seealso>
    let DistantCitation = Prefixed_Name(cito, "DistantCitation") |> PrefixedName
    /// <summary>
    ///   <para>cito:FunderSelfCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A citation in which the works reported in the citing and the cited entities were funded by the same funding agency.
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
    ///      :paperA cito:sharesFundingAgencyWith :paperB ."</para>
    /// labels<para>"funder self citation"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/FunderSelfCitation">http://purl.org/spar/cito/FunderSelfCitation</seealso>
    let FunderSelfCitation = Prefixed_Name(cito, "FunderSelfCitation") |> PrefixedName

    /// <summary>
    ///   <para>cito:JournalCartelCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A citation from one journal to another journal which forms one of a very large number of citations from the citing journal to recent articles in the cited journal, possibly undertaken as part of a citation cartel for the purpose of gaming the impact factor of the cited journal."</para>
    /// labels<para>"journal cartel citation"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/JournalCartelCitation">http://purl.org/spar/cito/JournalCartelCitation</seealso>
    let JournalCartelCitation =
        Prefixed_Name(cito, "JournalCartelCitation") |> PrefixedName

    /// <summary>
    ///   <para>cito:JournalSelfCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A citation in which the citing and the cited entities are published in the same journal.
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
    ///      :paperA cito:sharesJournalWith :paperB ."</para>
    /// labels<para>"journal self citation"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/JournalSelfCitation">http://purl.org/spar/cito/JournalSelfCitation</seealso>
    let JournalSelfCitation = Prefixed_Name(cito, "JournalSelfCitation") |> PrefixedName
    /// <summary>
    ///   <para>cito:SelfCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A citation in which the citing and the cited entities have something significant in common with one another, over and beyond their subject matter, for example authors, journal, institutional affiliation, or funding agency."</para>
    /// labels<para>"self citation"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/SelfCitation">http://purl.org/spar/cito/SelfCitation</seealso>
    let SelfCitation = Prefixed_Name(cito, "SelfCitation") |> PrefixedName
    /// <summary>
    ///   <para>cito:agreesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:PositiveRhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The citing entity agrees with statements, ideas or conclusions presented in the cited entity."</para>
    /// labels<para>"agrees with"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/agreesWith">http://purl.org/spar/cito/agreesWith</seealso>
    let agreesWith = Prefixed_Name(cito, "agreesWith") |> PrefixedName
    /// <summary>
    ///   <para>cito:cites</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The citing entity cites the cited entity, either directly and explicitly (as in the reference list of a journal article), indirectly (e.g. by citing a more recent paper by the same group on the same topic), or implicitly (e.g. as in artistic quotations or parodies, or in cases of plagiarism)."</para>
    /// labels<para>"cites"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/cites">http://purl.org/spar/cito/cites</seealso>
    let cites = Prefixed_Name(cito, "cites") |> PrefixedName
    /// <summary>
    ///   <para>cito:citesAsAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:RhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The citing entity cites the cited entity as one that provides an authoritative description or definition of the subject under discussion."</para>
    /// labels<para>"cites as authority"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/citesAsAuthority">http://purl.org/spar/cito/citesAsAuthority</seealso>
    let citesAsAuthority = Prefixed_Name(cito, "citesAsAuthority") |> PrefixedName
    /// <summary>
    ///   <para>cito:citesAsDataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity cites the cited entity as source of data."</para>
    /// labels<para>"cites as data source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"cites as data source"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/citesAsDataSource">http://purl.org/spar/cito/citesAsDataSource</seealso>
    let citesAsDataSource = Prefixed_Name(cito, "citesAsDataSource") |> PrefixedName
    /// <summary>
    ///   <para>cito:citesAsEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:RhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity cites the cited entity as source of factual evidence for statements it contains."</para>
    /// labels<para>"cites as evidence"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/citesAsEvidence">http://purl.org/spar/cito/citesAsEvidence</seealso>
    let citesAsEvidence = Prefixed_Name(cito, "citesAsEvidence") |> PrefixedName

    /// <summary>
    ///   <para>cito:citesAsMetadataDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The citing entity cites the cited entity as being the container of metadata describing the citing entity."</para>
    /// labels<para>"cites as metadata document"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/citesAsMetadataDocument">http://purl.org/spar/cito/citesAsMetadataDocument</seealso>
    let citesAsMetadataDocument =
        Prefixed_Name(cito, "citesAsMetadataDocument") |> PrefixedName

    /// <summary>
    ///   <para>cito:citesAsPotentialSolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:PositiveRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The citing entity cites the cited entity as providing or containing a possible solution to the issues being discussed."</para>
    /// labels<para>"cites as potential solution"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/citesAsPotentialSolution">http://purl.org/spar/cito/citesAsPotentialSolution</seealso>
    let citesAsPotentialSolution =
        Prefixed_Name(cito, "citesAsPotentialSolution") |> PrefixedName

    /// <summary>
    ///   <para>cito:citesAsRecommendedReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The citing entity cites the cited entity as an item of recommended reading.  This property can be used, for example, to describe references in a lecture reading list, where the cited references are relevant to the general topic of the lecture, but might not be individually cited within the text of the lecture.  Similarly, it could be used to describe items in a 'Suggested further reading' list at the end of a book chapter."</para>
    /// labels<para>"cites as recommended reading"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/citesAsRecommendedReading">http://purl.org/spar/cito/citesAsRecommendedReading</seealso>
    let citesAsRecommendedReading =
        Prefixed_Name(cito, "citesAsRecommendedReading") |> PrefixedName

    /// <summary>
    ///   <para>cito:citesAsRelated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>"The citing entity cites the cited entity as one that is related."</para>
    /// labels<para>"cites as related"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/citesAsRelated">http://purl.org/spar/cito/citesAsRelated</seealso>
    let citesAsRelated = Prefixed_Name(cito, "citesAsRelated") |> PrefixedName

    /// <summary>
    ///   <para>cito:citesAsSourceDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity cites the cited entity as being the entity from which the citing entity is derived, or about which the citing entity contains metadata."</para>
    /// labels<para>"cites as source document"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/citesAsSourceDocument">http://purl.org/spar/cito/citesAsSourceDocument</seealso>
    let citesAsSourceDocument =
        Prefixed_Name(cito, "citesAsSourceDocument") |> PrefixedName

    /// <summary>
    ///   <para>cito:citesForInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity cites the cited entity as a source of information on the subject under discussion."</para>
    /// labels<para>"cites for information"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/citesForInformation">http://purl.org/spar/cito/citesForInformation</seealso>
    let citesForInformation = Prefixed_Name(cito, "citesForInformation") |> PrefixedName
    /// <summary>
    ///   <para>cito:compiles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The citing entity is used to create or compile the cited entity."</para>
    /// labels<para>"compiles"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/compiles">http://purl.org/spar/cito/compiles</seealso>
    let compiles = Prefixed_Name(cito, "compiles") |> PrefixedName
    /// <summary>
    ///   <para>cito:confirms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:PositiveRhetoricalFunction</para>
    ///   <para>"The citing entity confirms facts, ideas or statements presented in the cited entity."</para>
    /// labels<para>"confirms"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/confirms">http://purl.org/spar/cito/confirms</seealso>
    let confirms = Prefixed_Name(cito, "confirms") |> PrefixedName

    /// <summary>
    ///   <para>cito:containsAssertionFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>cito-func:RhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity contains a statement of fact or a logical assertion (or a collection of such facts and/or assertions) originally present in the cited entity.   This object property is designed to be used to relate a separate abstract, summary or nanopublication to the cited entity upon which it is based."</para>
    /// labels<para>"contains assertion from"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/containsAssertionFrom">http://purl.org/spar/cito/containsAssertionFrom</seealso>
    let containsAssertionFrom =
        Prefixed_Name(cito, "containsAssertionFrom") |> PrefixedName

    /// <summary>
    ///   <para>cito:corrects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The citing entity corrects statements, ideas or conclusions presented in the cited entity."</para>
    /// labels<para>"corrects"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/corrects">http://purl.org/spar/cito/corrects</seealso>
    let corrects = Prefixed_Name(cito, "corrects") |> PrefixedName
    /// <summary>
    ///   <para>cito:credits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:PositiveRhetoricalFunction</para>
    ///   <para>"The citing entity acknowledges contributions made by the cited entity."</para>
    /// labels<para>"credits"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/credits">http://purl.org/spar/cito/credits</seealso>
    let credits = Prefixed_Name(cito, "credits") |> PrefixedName
    /// <summary>
    ///   <para>cito:critiques</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The citing entity critiques statements, ideas or conclusions presented in the cited entity."</para>
    /// labels<para>"critiques"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/critiques">http://purl.org/spar/cito/critiques</seealso>
    let critiques = Prefixed_Name(cito, "critiques") |> PrefixedName
    /// <summary>
    ///   <para>cito:derides</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity express derision for the cited entity, or for ideas or conclusions contained within it."</para>
    /// labels<para>"derides"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/derides">http://purl.org/spar/cito/derides</seealso>
    let derides = Prefixed_Name(cito, "derides") |> PrefixedName
    /// <summary>
    ///   <para>cito:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>"The citing entity describes the cited entity."</para>
    /// labels<para>"describes"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/describes">http://purl.org/spar/cito/describes</seealso>
    let describes = Prefixed_Name(cito, "describes") |> PrefixedName
    /// <summary>
    ///   <para>cito:disagreesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity disagrees with statements, ideas or conclusions presented in the cited entity."</para>
    /// labels<para>"disagrees with"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/disagreesWith">http://purl.org/spar/cito/disagreesWith</seealso>
    let disagreesWith = Prefixed_Name(cito, "disagreesWith") |> PrefixedName
    /// <summary>
    ///   <para>cito:discusses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>"The citing entity discusses statements, ideas or conclusions presented in the cited entity."</para>
    /// labels<para>"discusses"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/discusses">http://purl.org/spar/cito/discusses</seealso>
    let discusses = Prefixed_Name(cito, "discusses") |> PrefixedName
    /// <summary>
    ///   <para>cito:disputes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>"The citing entity disputes statements, ideas or conclusions presented in the cited entity."</para>
    /// labels<para>"disputes"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/disputes">http://purl.org/spar/cito/disputes</seealso>
    let disputes = Prefixed_Name(cito, "disputes") |> PrefixedName
    /// <summary>
    ///   <para>cito:documents</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The citing entity documents information about the cited entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"documents"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/documents">http://purl.org/spar/cito/documents</seealso>
    let documents = Prefixed_Name(cito, "documents") |> PrefixedName
    /// <summary>
    ///   <para>cito:extends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>"The citing entity extends facts, ideas or understandings presented in the cited entity."</para>
    /// labels<para>"extends"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/extends">http://purl.org/spar/cito/extends</seealso>
    let extends = Prefixed_Name(cito, "extends") |> PrefixedName
    /// <summary>
    ///   <para>cito:givesBackgroundTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:RhetoricalFunction</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The cited entity provides background information for the citing entity."</para>
    /// labels<para>"gives background to"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/givesBackgroundTo">http://purl.org/spar/cito/givesBackgroundTo</seealso>
    let givesBackgroundTo = Prefixed_Name(cito, "givesBackgroundTo") |> PrefixedName
    /// <summary>
    ///   <para>cito:givesSupportTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:RhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The cited entity provides intellectual or factual support for the citing entity."</para>
    /// labels<para>"gives support to"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/givesSupportTo">http://purl.org/spar/cito/givesSupportTo</seealso>
    let givesSupportTo = Prefixed_Name(cito, "givesSupportTo") |> PrefixedName

    /// <summary>
    ///   <para>cito:hasCitationCharacterization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property that links a citation to its characterization made by using a CiTO citation characterization property such as cito:extends. This usage involved OWL2 punning, whenby a CiTO object property, such as the aforementioned cito:extends, is used as the object of an OWL assertion:
    ///
    ///      :thisCitation cito:hasCitationCharacterization cito:extends .
    ///
    /// In such cases of OWL punning, the CiTO object properties are simultaneously considered both as normal object properties and also as proper named individuals of the class owl:Thing."</para>
    /// labels<para>"has citation characterization"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/hasCitationCharacterization">http://purl.org/spar/cito/hasCitationCharacterization</seealso>
    let hasCitationCharacterization =
        Prefixed_Name(cito, "hasCitationCharacterization") |> PrefixedName

    /// <summary>
    ///   <para>cito:hasCitationCreationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date on which the citation was created. This has the same numerical value as the publication date of the citing bibliographic resource, but is a property of the citation itself.  When combined with the citation time span, it permits that citation to be located in history."</para>
    /// labels<para>"has citation creation date"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/hasCitationCreationDate">http://purl.org/spar/cito/hasCitationCreationDate</seealso>
    let hasCitationCreationDate =
        Prefixed_Name(cito, "hasCitationCreationDate") |> PrefixedName

    /// <summary>
    ///   <para>cito:hasCitationTimeSpan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The temporal characteristic of a citation, namely the interval between the publication date of the cited entity and the publication date of the citing entity. Note that when one or both of the publication dates is given as just 'year', then the citation time span is rounded to the nearest year, and when one or both of the publication dates is given as just 'year and month', then the citation time span is rounded to the nearest month, with the inherent inaccuracies that such rounding involves."</para>
    /// labels<para>"has citation time span"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/hasCitationTimeSpan">http://purl.org/spar/cito/hasCitationTimeSpan</seealso>
    let hasCitationTimeSpan = Prefixed_Name(cito, "hasCitationTimeSpan") |> PrefixedName
    /// <summary>
    ///   <para>cito:hasCitedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property that relates a citation to the cited entity."</para>
    /// labels<para>"has cited entity"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/hasCitedEntity">http://purl.org/spar/cito/hasCitedEntity</seealso>
    let hasCitedEntity = Prefixed_Name(cito, "hasCitedEntity") |> PrefixedName
    /// <summary>
    ///   <para>cito:hasCitingEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property that relates a citation to the citing entity."</para>
    /// labels<para>"has citing entity"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/hasCitingEntity">http://purl.org/spar/cito/hasCitingEntity</seealso>
    let hasCitingEntity = Prefixed_Name(cito, "hasCitingEntity") |> PrefixedName

    /// <summary>
    ///   <para>cito:hasCoAuthorshipCitationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property specifies the minimal distance that one of the authors of the citing entity has with regards to one of the authors of the cited entity, according to their co-authorship network.
    ///
    /// For instance, a citation has a co-authorship citation level equal to 1 if at least one author of the citing entity has previously published as co-author with one of the authors of the cited entity. Similarly, we say that a citation has a co-authorship citation level equal to 2 if at least one author of the citing entity has previously published as co-author with someone who him/herself has previously published as co-author with one of the authors of the cited entity. And so on."</para>
    /// labels<para>"has co-authorship citation level"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/hasCoAuthorshipCitationLevel">http://purl.org/spar/cito/hasCoAuthorshipCitationLevel</seealso>
    let hasCoAuthorshipCitationLevel =
        Prefixed_Name(cito, "hasCoAuthorshipCitationLevel") |> PrefixedName

    /// <summary>
    ///   <para>cito:hasReplyFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The cited entity evokes a reply from the citing entity."</para>
    /// labels<para>"has reply from"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/hasReplyFrom">http://purl.org/spar/cito/hasReplyFrom</seealso>
    let hasReplyFrom = Prefixed_Name(cito, "hasReplyFrom") |> PrefixedName
    /// <summary>
    ///   <para>cito:includesExcerptFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The citing entity includes one or more excerpts from the cited entity."</para>
    /// labels<para>"includes excerpt from"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/includesExcerptFrom">http://purl.org/spar/cito/includesExcerptFrom</seealso>
    let includesExcerptFrom = Prefixed_Name(cito, "includesExcerptFrom") |> PrefixedName

    /// <summary>
    ///   <para>cito:includesQuotationFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The citing entity includes one or more quotations from the cited entity."</para>
    /// labels<para>"includes quotation from"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/includesQuotationFrom">http://purl.org/spar/cito/includesQuotationFrom</seealso>
    let includesQuotationFrom =
        Prefixed_Name(cito, "includesQuotationFrom") |> PrefixedName

    /// <summary>
    ///   <para>cito:isAgreedWithBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:PositiveRhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The cited entity contains statements, ideas or conclusions with which the citing entity agrees."</para>
    /// labels<para>"is agreed with by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isAgreedWithBy">http://purl.org/spar/cito/isAgreedWithBy</seealso>
    let isAgreedWithBy = Prefixed_Name(cito, "isAgreedWithBy") |> PrefixedName

    /// <summary>
    ///   <para>cito:isCitedAsAuthorityBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>cito-func:RhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The cited entity is cited as providing an authoritative description or definition of the subject under discussion in the citing entity."</para>
    /// labels<para>"is cited as authority by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCitedAsAuthorityBy">http://purl.org/spar/cito/isCitedAsAuthorityBy</seealso>
    let isCitedAsAuthorityBy =
        Prefixed_Name(cito, "isCitedAsAuthorityBy") |> PrefixedName

    /// <summary>
    ///   <para>cito:isCitedAsDataSourceBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The cited entity is cited as a data source by the citing entity."</para>
    /// labels<para>"is cited as data source by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"is cited as data source by"</para><para>"citado como fuente de datos por"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCitedAsDataSourceBy">http://purl.org/spar/cito/isCitedAsDataSourceBy</seealso>
    let isCitedAsDataSourceBy =
        Prefixed_Name(cito, "isCitedAsDataSourceBy") |> PrefixedName

    /// <summary>
    ///   <para>cito:isCitedAsEvidenceBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>cito-func:RhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The cited entity is cited for providing factual evidence to the citing entity."</para>
    /// labels<para>"is cited as evidence by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCitedAsEvidenceBy">http://purl.org/spar/cito/isCitedAsEvidenceBy</seealso>
    let isCitedAsEvidenceBy = Prefixed_Name(cito, "isCitedAsEvidenceBy") |> PrefixedName

    /// <summary>
    ///   <para>cito:isCitedAsMetadataDocumentBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity is cited as being the container of metadata relating to the citing entity."</para>
    /// labels<para>"is cited as metadata document by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCitedAsMetadataDocumentBy">http://purl.org/spar/cito/isCitedAsMetadataDocumentBy</seealso>
    let isCitedAsMetadataDocumentBy =
        Prefixed_Name(cito, "isCitedAsMetadataDocumentBy") |> PrefixedName

    /// <summary>
    ///   <para>cito:isCitedAsPontentialSolutionBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity is cited as providing or containing a possible solution to the issues being discussed in the citing entity."</para>
    /// labels<para>"is cited as potential solution by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCitedAsPontentialSolutionBy">http://purl.org/spar/cito/isCitedAsPontentialSolutionBy</seealso>
    let isCitedAsPontentialSolutionBy =
        Prefixed_Name(cito, "isCitedAsPontentialSolutionBy") |> PrefixedName

    /// <summary>
    ///   <para>cito:isCitedAsPotentialSolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:PositiveRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/cito/isCitedAsPotentialSolution">http://purl.org/spar/cito/isCitedAsPotentialSolution</seealso>
    let isCitedAsPotentialSolution =
        Prefixed_Name(cito, "isCitedAsPotentialSolution") |> PrefixedName

    /// <summary>
    ///   <para>cito:isCitedAsRecommendedReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/cito/isCitedAsRecommendedReading">http://purl.org/spar/cito/isCitedAsRecommendedReading</seealso>
    let isCitedAsRecommendedReading =
        Prefixed_Name(cito, "isCitedAsRecommendedReading") |> PrefixedName

    /// <summary>
    ///   <para>cito:isCitedAsRecommendedReadingBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity is cited by the citing entity as an item of recommended reading.  This property can be used, for example, to describe references in a lecture reading list, where the cited references are relevant to the general topic of the lecture, but might not be individually cited within the text of the lecture.  Similarly, it could be used to describe items in a 'Suggested further reading' list at the end of a book chapter."</para>
    /// labels<para>"is cited as recommended reading by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCitedAsRecommendedReadingBy">http://purl.org/spar/cito/isCitedAsRecommendedReadingBy</seealso>
    let isCitedAsRecommendedReadingBy =
        Prefixed_Name(cito, "isCitedAsRecommendedReadingBy") |> PrefixedName

    /// <summary>
    ///   <para>cito:isCitedAsRelatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity is cited as being related to the citing entity."</para>
    /// labels<para>"is cited as related by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCitedAsRelatedBy">http://purl.org/spar/cito/isCitedAsRelatedBy</seealso>
    let isCitedAsRelatedBy = Prefixed_Name(cito, "isCitedAsRelatedBy") |> PrefixedName

    /// <summary>
    ///   <para>cito:isCitedAsSourceDocumentBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The cited entity is cited as being the entity from which the citing entity is derived, or about which the citing entity contains metadata."</para>
    /// labels<para>"is cited as source document by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCitedAsSourceDocumentBy">http://purl.org/spar/cito/isCitedAsSourceDocumentBy</seealso>
    let isCitedAsSourceDocumentBy =
        Prefixed_Name(cito, "isCitedAsSourceDocumentBy") |> PrefixedName

    /// <summary>
    ///   <para>cito:isCitedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>"The cited entity (the subject of the RDF triple) is cited by the citing entity (the object of the triple)."</para>
    /// labels<para>"is cited by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCitedBy">http://purl.org/spar/cito/isCitedBy</seealso>
    let isCitedBy = Prefixed_Name(cito, "isCitedBy") |> PrefixedName

    /// <summary>
    ///   <para>cito:isCitedForInformationBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity is cited as a source of information on the subject under discussion in the citing entity."</para>
    /// labels<para>"is cited for information by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCitedForInformationBy">http://purl.org/spar/cito/isCitedForInformationBy</seealso>
    let isCitedForInformationBy =
        Prefixed_Name(cito, "isCitedForInformationBy") |> PrefixedName

    /// <summary>
    ///   <para>cito:isCompiledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The cited entity is the result of a compile or creation event using the citing entity."</para>
    /// labels<para>"is compiled by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCompiledBy">http://purl.org/spar/cito/isCompiledBy</seealso>
    let isCompiledBy = Prefixed_Name(cito, "isCompiledBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isConfirmedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:PositiveRhetoricalFunction</para>
    ///   <para>"The cited entity presents facts, ideas or statements that are confirmed by the citing entity."</para>
    /// labels<para>"is confirmed by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isConfirmedBy">http://purl.org/spar/cito/isConfirmedBy</seealso>
    let isConfirmedBy = Prefixed_Name(cito, "isConfirmedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isCorrectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity presents statements, ideas or conclusions that are corrected by the citing entity."</para>
    /// labels<para>"is corrected by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCorrectedBy">http://purl.org/spar/cito/isCorrectedBy</seealso>
    let isCorrectedBy = Prefixed_Name(cito, "isCorrectedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isCreditedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:PositiveRhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The cited entity makes contributions that are acknowledged by the citing entity."</para>
    /// labels<para>"is credited by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCreditedBy">http://purl.org/spar/cito/isCreditedBy</seealso>
    let isCreditedBy = Prefixed_Name(cito, "isCreditedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isCritiquedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity presents statements, ideas or conclusions that are critiqued by the citing entity."</para>
    /// labels<para>"is critiqued by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isCritiquedBy">http://purl.org/spar/cito/isCritiquedBy</seealso>
    let isCritiquedBy = Prefixed_Name(cito, "isCritiquedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isDeridedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>"The cited entity contains ideas or conclusions for which the citing entity express derision."</para>
    /// labels<para>"is derided by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isDeridedBy">http://purl.org/spar/cito/isDeridedBy</seealso>
    let isDeridedBy = Prefixed_Name(cito, "isDeridedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The cited entity is described by the citing entity."</para>
    /// labels<para>"is described by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isDescribedBy">http://purl.org/spar/cito/isDescribedBy</seealso>
    let isDescribedBy = Prefixed_Name(cito, "isDescribedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isDisagreedWithBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>"The cited entity presents statements, ideas or conclusions that are disagreed with by the citing entity."</para>
    /// labels<para>"is disagreed with by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isDisagreedWithBy">http://purl.org/spar/cito/isDisagreedWithBy</seealso>
    let isDisagreedWithBy = Prefixed_Name(cito, "isDisagreedWithBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isDiscussedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity presents statements, ideas or conclusions that are discussed by the citing entity."</para>
    /// labels<para>"is discussed by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isDiscussedBy">http://purl.org/spar/cito/isDiscussedBy</seealso>
    let isDiscussedBy = Prefixed_Name(cito, "isDiscussedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isDisputedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>"The cited entity presents statements, ideas or conclusions that are disputed by the citing entity."</para>
    /// labels<para>"is disputed by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isDisputedBy">http://purl.org/spar/cito/isDisputedBy</seealso>
    let isDisputedBy = Prefixed_Name(cito, "isDisputedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isDocumentedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"Information about the cited entity is documented by the citing entity."</para>
    /// labels<para>"is documented by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isDocumentedBy">http://purl.org/spar/cito/isDocumentedBy</seealso>
    let isDocumentedBy = Prefixed_Name(cito, "isDocumentedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isExtendedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>"The cited entity presents facts, ideas or understandings that are extended by the citing entity."</para>
    /// labels<para>"is extended by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isExtendedBy">http://purl.org/spar/cito/isExtendedBy</seealso>
    let isExtendedBy = Prefixed_Name(cito, "isExtendedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isLinkedToBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity is the target for an HTTP Uniform Resource Locator (URL) link within the citing entity."</para>
    /// labels<para>"is linked to by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isLinkedToBy">http://purl.org/spar/cito/isLinkedToBy</seealso>
    let isLinkedToBy = Prefixed_Name(cito, "isLinkedToBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isParodiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The characteristic style or content of the cited entity is imitated by the citing entity for comic effect, usually without explicit citation."</para>
    /// labels<para>"is parodied by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isParodiedBy">http://purl.org/spar/cito/isParodiedBy</seealso>
    let isParodiedBy = Prefixed_Name(cito, "isParodiedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isPlagiarizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity is plagiarized by the author of the citing entity, who includes within the citing entity textual or other elements from the cited entity without formal acknowledgement of their source. The cited entity is thus not explicitly cited from within the citing entity, according to the norms of scholarly practice, but is cited implicitly."</para>
    /// labels<para>"is plagiarized by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isPlagiarizedBy">http://purl.org/spar/cito/isPlagiarizedBy</seealso>
    let isPlagiarizedBy = Prefixed_Name(cito, "isPlagiarizedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isQualifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity presents statements, ideas or conclusions that are qualified or have conditions placed upon them by the citing entity."</para>
    /// labels<para>"is qualified by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isQualifiedBy">http://purl.org/spar/cito/isQualifiedBy</seealso>
    let isQualifiedBy = Prefixed_Name(cito, "isQualifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isRefutedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity presents statements, ideas or conclusions that are refuted by the citing entity."</para>
    /// labels<para>"is refuted by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isRefutedBy">http://purl.org/spar/cito/isRefutedBy</seealso>
    let isRefutedBy = Prefixed_Name(cito, "isRefutedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isRetractedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The cited entity is formally retracted by the citing entity."</para>
    /// labels<para>"is retracted by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isRetractedBy">http://purl.org/spar/cito/isRetractedBy</seealso>
    let isRetractedBy = Prefixed_Name(cito, "isRetractedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isReviewedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>"The cited entity presents statements, ideas or conclusions that are reviewed by the citing entity."</para>
    /// labels<para>"is reviewed by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isReviewedBy">http://purl.org/spar/cito/isReviewedBy</seealso>
    let isReviewedBy = Prefixed_Name(cito, "isReviewedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isRidiculedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity or aspects of its contents are ridiculed by the citing entity."</para>
    /// labels<para>"is ridiculed by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isRidiculedBy">http://purl.org/spar/cito/isRidiculedBy</seealso>
    let isRidiculedBy = Prefixed_Name(cito, "isRidiculedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isSepculatedOnBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/cito/isSepculatedOnBy">http://purl.org/spar/cito/isSepculatedOnBy</seealso>
    let isSepculatedOnBy = Prefixed_Name(cito, "isSepculatedOnBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isSpeculatedOnBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity is cited because the citing article contains speculations on its content or ideas."</para>
    /// labels<para>"is speculated on by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isSpeculatedOnBy">http://purl.org/spar/cito/isSpeculatedOnBy</seealso>
    let isSpeculatedOnBy = Prefixed_Name(cito, "isSpeculatedOnBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isSupportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:PositiveRhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity receives intellectual or factual support from the citing entity."</para>
    /// labels<para>"is supported by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isSupportedBy">http://purl.org/spar/cito/isSupportedBy</seealso>
    let isSupportedBy = Prefixed_Name(cito, "isSupportedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:isUpdatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The cited entity presents statements, ideas, hypotheses or understanding that are updated by the cited entity."</para>
    /// labels<para>"is updated by"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/isUpdatedBy">http://purl.org/spar/cito/isUpdatedBy</seealso>
    let isUpdatedBy = Prefixed_Name(cito, "isUpdatedBy") |> PrefixedName
    /// <summary>
    ///   <para>cito:likes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property that permits you to express appreciation of or interest in something that is the object of the RDF triple, or to express that it is worth thinking about even if you do not agree with its content, enabling social media 'likes' statements to be encoded in RDF.  Use of this property does NOT imply the existence of a formal citation of the entity that is 'liked'."</para>
    /// labels<para>"likes"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/likes">http://purl.org/spar/cito/likes</seealso>
    let likes = Prefixed_Name(cito, "likes") |> PrefixedName
    /// <summary>
    ///   <para>cito:linksTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity provides a link, in the form of an HTTP Uniform Resource Locator (URL), to the cited entity."</para>
    /// labels<para>"links to"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/linksTo">http://purl.org/spar/cito/linksTo</seealso>
    let linksTo = Prefixed_Name(cito, "linksTo") |> PrefixedName

    /// <summary>
    ///   <para>cito:obtainsBackgroundFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>cito-func:RhetoricalFunction</para>
    ///   <para>"The citing entity obtains background information from the cited entity."</para>
    /// labels<para>"obtains background from"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/obtainsBackgroundFrom">http://purl.org/spar/cito/obtainsBackgroundFrom</seealso>
    let obtainsBackgroundFrom =
        Prefixed_Name(cito, "obtainsBackgroundFrom") |> PrefixedName

    /// <summary>
    ///   <para>cito:obtainsSupportFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:RhetoricalFunction</para>
    ///   <para>"The citing entity obtains intellectual or factual support from the cited entity."</para>
    /// labels<para>"obtains support from"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/obtainsSupportFrom">http://purl.org/spar/cito/obtainsSupportFrom</seealso>
    let obtainsSupportFrom = Prefixed_Name(cito, "obtainsSupportFrom") |> PrefixedName
    /// <summary>
    ///   <para>cito:parodies</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity imitates the characteristic style or content of the cited entity for comic effect, usually without explicit citation."</para>
    /// labels<para>"parodies"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/parodies">http://purl.org/spar/cito/parodies</seealso>
    let parodies = Prefixed_Name(cito, "parodies") |> PrefixedName
    /// <summary>
    ///   <para>cito:plagiarizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"A property indicating that the author of the citing entity plagiarizes the cited entity, by including textual or other elements from the cited entity without formal acknowledgement of their source.  The citing entity thus contains no explicit citation of the cited entity, according to the norms of scholarly practice, but cites it implicitly."</para>
    /// labels<para>"plagiarizes"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/plagiarizes">http://purl.org/spar/cito/plagiarizes</seealso>
    let plagiarizes = Prefixed_Name(cito, "plagiarizes") |> PrefixedName

    /// <summary>
    ///   <para>cito:providesAssertionFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:RhetoricalFunction</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The cited entity contains and is the original source of a statement of fact or a logical assertion (or a collection of such facts and/or assertions) that is to be found in the citing entity.   This inverse object property is designed to be used to relate a cited entity to a separate abstract, summary or nanopublication based upon it."</para>
    /// labels<para>"provides assertion for"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/providesAssertionFor">http://purl.org/spar/cito/providesAssertionFor</seealso>
    let providesAssertionFor =
        Prefixed_Name(cito, "providesAssertionFor") |> PrefixedName

    /// <summary>
    ///   <para>cito:providesConclusionsFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The cited entity presents conclusions that are used in work described in the citing entity."</para>
    /// labels<para>"provides conclusions for"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/providesConclusionsFor">http://purl.org/spar/cito/providesConclusionsFor</seealso>
    let providesConclusionsFor =
        Prefixed_Name(cito, "providesConclusionsFor") |> PrefixedName

    /// <summary>
    ///   <para>cito:providesDataFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The cited entity presents data that are used in work described in the citing entity."</para>
    /// labels<para>"provides data for"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/providesDataFor">http://purl.org/spar/cito/providesDataFor</seealso>
    let providesDataFor = Prefixed_Name(cito, "providesDataFor") |> PrefixedName
    /// <summary>
    ///   <para>cito:providesExcerptFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The cited entity contains information, usually of a textual nature, that is excerpted by (used as an excerpt within) the citing entity."</para>
    /// labels<para>"provides excerpt for"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/providesExcerptFor">http://purl.org/spar/cito/providesExcerptFor</seealso>
    let providesExcerptFor = Prefixed_Name(cito, "providesExcerptFor") |> PrefixedName
    /// <summary>
    ///   <para>cito:providesMethodFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The cited entity details a method that is used in work described by the citing entity."</para>
    /// labels<para>"provides method for"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/providesMethodFor">http://purl.org/spar/cito/providesMethodFor</seealso>
    let providesMethodFor = Prefixed_Name(cito, "providesMethodFor") |> PrefixedName

    /// <summary>
    ///   <para>cito:providesQuotationFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The cited entity contains information, usually of a textual nature, that is quoted by (used as a quotation within) the citing entity."</para>
    /// labels<para>"provides quotation for"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/providesQuotationFor">http://purl.org/spar/cito/providesQuotationFor</seealso>
    let providesQuotationFor =
        Prefixed_Name(cito, "providesQuotationFor") |> PrefixedName

    /// <summary>
    ///   <para>cito:qualifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity qualifies or places conditions or restrictions upon statements, ideas or conclusions presented in the cited entity."</para>
    /// labels<para>"qualifies"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/qualifies">http://purl.org/spar/cito/qualifies</seealso>
    let qualifies = Prefixed_Name(cito, "qualifies") |> PrefixedName
    /// <summary>
    ///   <para>cito:refutes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>"The citing entity refutes statements, ideas or conclusions presented in the cited entity."</para>
    /// labels<para>"refutes"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/refutes">http://purl.org/spar/cito/refutes</seealso>
    let refutes = Prefixed_Name(cito, "refutes") |> PrefixedName
    /// <summary>
    ///   <para>cito:repliesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity replies to statements, ideas or criticisms presented in the cited entity."</para>
    /// labels<para>"replies to"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/repliesTo">http://purl.org/spar/cito/repliesTo</seealso>
    let repliesTo = Prefixed_Name(cito, "repliesTo") |> PrefixedName
    /// <summary>
    ///   <para>cito:retracts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The citing entity constitutes a formal retraction of the cited entity."</para>
    /// labels<para>"retracts"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/retracts">http://purl.org/spar/cito/retracts</seealso>
    let retracts = Prefixed_Name(cito, "retracts") |> PrefixedName
    /// <summary>
    ///   <para>cito:reviews</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity reviews statements, ideas or conclusions presented in the cited entity."</para>
    /// labels<para>"reviews"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/reviews">http://purl.org/spar/cito/reviews</seealso>
    let reviews = Prefixed_Name(cito, "reviews") |> PrefixedName
    /// <summary>
    ///   <para>cito:ridicules</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    ///   <para>"The citing entity ridicules the cited entity or aspects of its contents."</para>
    /// labels<para>"ridicules"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/ridicules">http://purl.org/spar/cito/ridicules</seealso>
    let ridicules = Prefixed_Name(cito, "ridicules") |> PrefixedName

    /// <summary>
    ///   <para>cito:sharesAuthorInstitutionWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Each entity has at least one author that shares a common institutional affiliation with an author of the other entity."</para>
    /// labels<para>"shares author institution with"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/sharesAuthorInstitutionWith">http://purl.org/spar/cito/sharesAuthorInstitutionWith</seealso>
    let sharesAuthorInstitutionWith =
        Prefixed_Name(cito, "sharesAuthorInstitutionWith") |> PrefixedName

    /// <summary>
    ///   <para>cito:sharesAuthorWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Each entity has at least one author in common with the other entity."</para>
    /// labels<para>"shares author with"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/sharesAuthorWith">http://purl.org/spar/cito/sharesAuthorWith</seealso>
    let sharesAuthorWith = Prefixed_Name(cito, "sharesAuthorWith") |> PrefixedName

    /// <summary>
    ///   <para>cito:sharesFundingAgencyWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The two entities result from activities that have been funded by the same funding agency."</para>
    /// labels<para>"shares funding agency with"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/sharesFundingAgencyWith">http://purl.org/spar/cito/sharesFundingAgencyWith</seealso>
    let sharesFundingAgencyWith =
        Prefixed_Name(cito, "sharesFundingAgencyWith") |> PrefixedName

    /// <summary>
    ///   <para>cito:sharesJournalWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing and cited bibliographic resources are published in the same journal."</para>
    /// labels<para>"shares journal with"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/sharesJournalWith">http://purl.org/spar/cito/sharesJournalWith</seealso>
    let sharesJournalWith = Prefixed_Name(cito, "sharesJournalWith") |> PrefixedName

    /// <summary>
    ///   <para>cito:sharesPublicationVenueWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing and cited bibliographic resources are published in same publication venue."</para>
    /// labels<para>"shares publication venue with"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/sharesPublicationVenueWith">http://purl.org/spar/cito/sharesPublicationVenueWith</seealso>
    let sharesPublicationVenueWith =
        Prefixed_Name(cito, "sharesPublicationVenueWith") |> PrefixedName

    /// <summary>
    ///   <para>cito:speculatesOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity speculates on something within or related to the cited entity, without firm evidence."</para>
    /// labels<para>"speculates on"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/speculatesOn">http://purl.org/spar/cito/speculatesOn</seealso>
    let speculatesOn = Prefixed_Name(cito, "speculatesOn") |> PrefixedName
    /// <summary>
    ///   <para>cito:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:PositiveRhetoricalFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity provides intellectual or factual support for statements, ideas or conclusions presented in the cited entity."</para>
    /// labels<para>"supports"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/supports">http://purl.org/spar/cito/supports</seealso>
    let supports = Prefixed_Name(cito, "supports") |> PrefixedName
    /// <summary>
    ///   <para>cito:updates</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The citing entity updates statements, ideas, hypotheses or understanding presented in the cited entity."</para>
    /// labels<para>"updates"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/updates">http://purl.org/spar/cito/updates</seealso>
    let updates = Prefixed_Name(cito, "updates") |> PrefixedName
    /// <summary>
    ///   <para>cito:usesConclusionsFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The citing entity describes work that uses conclusions presented in the cited entity."</para>
    /// labels<para>"uses conclusions from"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/usesConclusionsFrom">http://purl.org/spar/cito/usesConclusionsFrom</seealso>
    let usesConclusionsFrom = Prefixed_Name(cito, "usesConclusionsFrom") |> PrefixedName
    /// <summary>
    ///   <para>cito:usesDataFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>"The citing entity describes work that uses data presented in the cited entity."</para>
    /// labels<para>"uses data from"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/usesDataFrom">http://purl.org/spar/cito/usesDataFrom</seealso>
    let usesDataFrom = Prefixed_Name(cito, "usesDataFrom") |> PrefixedName
    /// <summary>
    ///   <para>cito:usesMethodIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>cito-func:FactualFunction</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The citing entity describes work that uses a method detailed in the cited entity."</para>
    /// labels<para>"uses method in"</para></remarks>
    /// <seealso href="http://purl.org/spar/cito/usesMethodIn">http://purl.org/spar/cito/usesMethodIn</seealso>
    let usesMethodIn = Prefixed_Name(cito, "usesMethodIn") |> PrefixedName
