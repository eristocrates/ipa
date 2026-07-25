namespace http.www.ontologydesignpatterns.org.ont.dul.ontopic.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ontopic =
    let _namespace_iri = Namespace_Iri ontopic |> NamespaceIRI
    /// <summary>
    ///   <para>ontopic:SubjectSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any atomic Region in a TopicSpace that is used to localize a dul:SocialObject that hasTopic a Topic that dul:hasRegion that TopicSpace.
    /// In Welty's formal ontology of subjects, it is assumed as a point. The reason why we do not assume subjects as points is the relativity of atomicity: although the intuition goes to atomicity, one cannot exclude that subjects can have other subjects as parts; for example, consider the subject of an article on a football match: we might conceive a subject of a paragraph within that article that is about a penalty occurred during the football match.</para>
    /// labels<para>Subject space</para><para>Soggetto</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#SubjectSpace">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#SubjectSpace</seealso>
    let SubjectSpace = Prefixed_Name(ontopic, "SubjectSpace") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:TopicSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any Region in a dimensional space that is used to localize a Topic. Its atomic parts are called Subject(s). Mereotopological relations: dul:hasPart, dul:overlaps, can be simply reused within and between TopicSpace(s).
    /// This class is mostly similar to the Topic class in Welty's formal ontology of subjects.</para>
    /// labels<para>Spazio di argomenti</para><para>Topic space</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#TopicSpace">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#TopicSpace</seealso>
    let TopicSpace = Prefixed_Name(ontopic, "TopicSpace") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:SubjectDirectory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of tags or metadata that have no formal semantics, and are typically used sparsely to annotate texts, images, bookmarks, etc.</para>
    /// labels<para>Catalogo di argomenti</para><para>Subject directory</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#SubjectDirectory">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#SubjectDirectory</seealso>
    let SubjectDirectory = Prefixed_Name(ontopic, "SubjectDirectory") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:isSubTopicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>The relation between two Topic(s), in terms of their cultural coverage. For example, Football isSubTopicOf Sport.
    /// It can be used widely to talk about document annotations, subject directories, etc.
    /// The counterpart of this relation for TopicSpace(s) is simply dul:isPartOf</para>
    /// labels<para>è argomento più specifico di {it}</para><para>is sub topic of</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isSubTopicOf">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isSubTopicOf</seealso>
    let isSubTopicOf = Prefixed_Name(ontopic, "isSubTopicOf") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specific Topic(s) for e.g. a conversation, an article, a document, etc. E.g. wikipedia article names can be considered Subject(s).</para>
    /// labels<para>Subject</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#Subject">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#Subject</seealso>
    let Subject = Prefixed_Name(ontopic, "Subject") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A topic, or subject, argument, domain, theme, subject area, etc.
    /// Topics have a controversial intuition across common sense, document management systems, knowledge organization systems, etc.
    /// Here we conceptualise a semiotic notion of iol:Topic as 'a (usually potential) dul:Collection of dul:SocialObject(s).
    /// For example, 'music' is a topic constituted by the set of social objects that are associated with music-related entities. Such social objects can be information objects (texts, documents, words, images) about music-related entities, concepts classifying music-related entities, descriptions of musical theories and systems, etc.
    /// The relation between social objects and topics is called here 'hasTopic', and is a rdfs:subPropertyOf dul:isMemberOf
    /// Specific topics for e.g. a conversation or an article (therefore, closer to the notion of 'title' or 'entry') are called Subject(s).
    ///
    /// There is an interesting duality of topics: they are commonly interpreted as areas of shared knowledge within a Community (therefore as collections of social objects). On the other hand, existing directories and thesauri use 'topic' (or 'subject') more restrictively, as a relation between a document and a concept.
    /// There is a sense of 'meaning' that can be reduced to the one given here to Topic (cf. the comment at the property dul:expresses), but in general there seems to be enough room to distinguish carefully between concepts and topics.
    /// For example, thesauri do not usually distinguish when their 'concepts' (cf. skos:Concept) are actually intended as concepts (in the sense of dul:Concept) and when they are intended as topics. The distinction is clear when you compare these two sample sentences: 'the football topic is part of the sport topic' vs. 'the concept of football is part of the concept of sport'.
    /// While the first is perfectly acceptable, the second is counterintuitive and even possibly wrong. This effect is due to the fact that concepts are 'intensional' notions and are not intended as areas of knowledge, document spaces, etc., which are 'extensional' notions.
    /// Accordingly to these basic observations, in this ontology dul:Concept and Topic result to be disjoint, and an appropriate representation should be in place in order to model thesauri. E.g. skos:Concept should be mapped to the union of dul:Concept and Topic.</para>
    /// labels<para>Argomento</para><para>Topic</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#Topic">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#Topic</seealso>
    let Topic = Prefixed_Name(ontopic, "Topic") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:isTopicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between any Entity, and a Topic (subject, argument, domain, theme, subject area, etc.). It can be used widely to talk about document annotations, subject directories, etc.
    /// The range is here relaxed to any SocialObject, in order to allow alignment of deviant uses of topic or subject relations for 'concepts' (e.g. in thesauri), and other things that are mixed up with the notion of Topic.</para>
    /// labels<para>è argomento di</para><para>is topic of</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isTopicOf">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isTopicOf</seealso>
    let isTopicOf = Prefixed_Name(ontopic, "isTopicOf") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:hasSubTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>The relation between two instances of a Topic, in terms of their cultural coverage. For example, Sport hasSubTopic Football.
    /// It can be used widely to talk about document annotations, subject directories, etc.
    /// The counterpart of this relation for TopicSpace(s) is simply dul:hasPart</para>
    /// labels<para>ha argomento più specifico {it}</para><para>has subtopic</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#hasSubTopic">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#hasSubTopic</seealso>
    let hasSubTopic = Prefixed_Name(ontopic, "hasSubTopic") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:TopicAssignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A topic assignment is a iol:LinguisticAct in which an dul:Agent assigns a Topic to a document, or in general to any dul:SocialObject.
    /// What is the semiotic act involved in such an assignment? Differently from tagging, which 'selects' one of the references of a document, a topic actually points to an 'area of knowledge', which can be represented as a dul:Collection of dul:SocialObject(s) (e.g. of documents, concepts, meanings, etc.).
    /// A Topic is necessarily expressed by a iol:LinguisticObject.
    /// Topics have a typical topology, by which they can be distant, close, overlapping, etc., and a mereology, by which they can be part of others. This also means that 'areas of knowledge' can be part of others, can overlap, etc., so originating clusters of areas and terms that denote them.
    /// The subcollection of terms populating a Topic is called here TopicSignature</para>
    /// labels<para>Topic assignment</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#TopicAssignment">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#TopicAssignment</seealso>
    let TopicAssignment = Prefixed_Name(ontopic, "TopicAssignment") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:includesTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between topic assignments and topics.</para>
    /// labels<para>include l'argomento</para><para>includes topic</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#includesTopic">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#includesTopic</seealso>
    let includesTopic = Prefixed_Name(ontopic, "includesTopic") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:farTopicFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The opposite to vicinity relation between two topics, e.g. 'star system' (as a Topic) is farTopicFrom 'geology' (as a Topic).
    /// Distance is typically established with reference to a threshold on the number of dul:SocialObject(s) that are common to the two topics. Alternatively, it can be established with reference to the a geometrical semantics applied to the TopicSpace(s) that are regions for the Topic(s)</para>
    /// labels<para>è un argomento lontano da</para><para>far topic from</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#farTopicFrom">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#farTopicFrom</seealso>
    let farTopicFrom = Prefixed_Name(ontopic, "farTopicFrom") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:TopicSignature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The collection of lmm1:Expression(s) that are in a Topic; for example, the topic signatures from sensecorpus, the entries from Roget's, etc.</para>
    /// labels<para>Topic signature</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#TopicSignature">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#TopicSignature</seealso>
    let TopicSignature = Prefixed_Name(ontopic, "TopicSignature") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:isCoreConceptFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Concept is a core concept for a Topic when it classifies a set of entities that are references of some relevant information objects that have that Topic.
    /// For example, Saxophone (as a Concept) isCoreConceptFor Saxophones (as a Topic).</para>
    /// labels<para>è concetto centrale di {it}</para><para>is core concept for</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isCoreConceptFor">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isCoreConceptFor</seealso>
    let isCoreConceptFor = Prefixed_Name(ontopic, "isCoreConceptFor") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:hasCoreConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ha concetto centrale {@it}</para><para>has core concept</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#hasCoreConcept">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#hasCoreConcept</seealso>
    let hasCoreConcept = Prefixed_Name(ontopic, "hasCoreConcept") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:hasTopicSignature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#hasTopicSignature">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#hasTopicSignature</seealso>
    let hasTopicSignature = Prefixed_Name(ontopic, "hasTopicSignature") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:hasTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between ay Entity - but usually any dul:SocialObject (usually a document) - and a Topic (subject, argument, domain, theme, subject area, etc.). It can be used widely to talk about document annotations, subject directories, etc.
    /// The range is here relaxed to any SocialObject, in order to allow alignment of deviant uses of topic or subject relations for 'concepts' (e.g. in thesauri), and other things that are mixed up with the notion of Topic.
    /// This move makes the hasTopic relation very general, and introduces a particular semiotic relation, different from dul:expresses, lmm1:denotes, and lmm1:isInterpretationOf: this is a relation between any two social objects, in which the first is (or is related to) some lmm1:Meaning that dul:isMemberOf a dul:Collection (a Topic). The second social object can even be another member of that Topic. Hence, in the general case, we could expect a relation between two social objects that are associated because they are members of a common Topic.
    /// For example, consider the following cases:
    /// (1) A biography of Brigitte Bardot (dul:InformationObject) ontopic:hasTopic 'star system' (Topic)
    /// (2) The concept of 'starlet' (dul:Concept) hasTopic 'cinema' (Topic)
    /// (3) A biography of Claude Chabrol (dul:InformationObject) ontopic:hasTopic 'Nouvelle Vague' (Topic)</para>
    /// labels<para>ha argomento {it}</para><para>ha argomento</para><para>has topic</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#hasTopic">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#hasTopic</seealso>
    let hasTopic = Prefixed_Name(ontopic, "hasTopic") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:isTopicIncludedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is topic included in</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isTopicIncludedIn">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isTopicIncludedIn</seealso>
    let isTopicIncludedIn = Prefixed_Name(ontopic, "isTopicIncludedIn") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:nearTopicTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>The vicinity relation between two topics, e.g. 'star system' (as a Topic) is nearTopicTo 'cinema' (as a Topic).
    /// Vicinity is typically established with reference to a threshold on the number of dul:SocialObject(s) that are common to the two Topic(s), or based on a geometrical semantics applied to the TopicSpace(s) that are regions for the two Topic(s).</para>
    /// labels<para>è un argomento vicino a</para><para>near topic to</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#nearTopicTo">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#nearTopicTo</seealso>
    let nearTopicTo = Prefixed_Name(ontopic, "nearTopicTo") |> PrefixedName
    /// <summary>
    ///   <para>ontopic:overlappingTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#overlappingTopic">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#overlappingTopic</seealso>
    let overlappingTopic = Prefixed_Name(ontopic, "overlappingTopic") |> PrefixedName

    /// <summary>
    ///   <para>ontopic:isTopicSignatureOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isTopicSignatureOf">http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isTopicSignatureOf</seealso>
    let isTopicSignatureOf =
        Prefixed_Name(ontopic, "isTopicSignatureOf") |> PrefixedName
