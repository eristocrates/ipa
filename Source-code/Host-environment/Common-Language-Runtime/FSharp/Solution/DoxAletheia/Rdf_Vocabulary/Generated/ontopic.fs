namespace http.www.ontologydesignpatterns.org.ont.dul.ontopic.owl.hash

open DoxAletheia

module ontopic =
    let _namespace_name = "http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Any Region in a dimensional space that is used to localize a Topic. Its atomic parts are called Subject(s). Mereotopological relations: dul:hasPart, dul:overlaps, can be simply reused within and between TopicSpace(s).
    /// This class is mostly similar to the Topic class in Welty's formal ontology of subjects.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#TopicSpace"></see></summary>
    let TopicSpace = _prefix "TopicSpace"
    /// <summary>
    /// Any atomic Region in a TopicSpace that is used to localize a dul:SocialObject that hasTopic a Topic that dul:hasRegion that TopicSpace.
    /// In Welty's formal ontology of subjects, it is assumed as a point. The reason why we do not assume subjects as points is the relativity of atomicity: although the intuition goes to atomicity, one cannot exclude that subjects can have other subjects as parts; for example, consider the subject of an article on a football match: we might conceive a subject of a paragraph within that article that is about a penalty occurred during the football match.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#SubjectSpace"></see></summary>
    let SubjectSpace = _prefix "SubjectSpace"
    /// <summary>
    /// Specific Topic(s) for e.g. a conversation, an article, a document, etc. E.g. wikipedia article names can be considered Subject(s).
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#Subject"></see></summary>
    let Subject = _prefix "Subject"
    /// <summary>
    /// The relation between any Entity, and a Topic (subject, argument, domain, theme, subject area, etc.). It can be used widely to talk about document annotations, subject directories, etc.
    /// The range is here relaxed to any SocialObject, in order to allow alignment of deviant uses of topic or subject relations for 'concepts' (e.g. in thesauri), and other things that are mixed up with the notion of Topic.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isTopicOf"></see></summary>
    let isTopicOf = _prefix "isTopicOf"
    /// <summary>
    /// A topic, or subject, argument, domain, theme, subject area, etc.
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
    /// Accordingly to these basic observations, in this ontology dul:Concept and Topic result to be disjoint, and an appropriate representation should be in place in order to model thesauri. E.g. skos:Concept should be mapped to the union of dul:Concept and Topic.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#Topic"></see></summary>
    let Topic = _prefix "Topic"
    /// <summary>
    /// A collection of tags or metadata that have no formal semantics, and are typically used sparsely to annotate texts, images, bookmarks, etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#SubjectDirectory"></see></summary>
    let SubjectDirectory = _prefix "SubjectDirectory"
    /// <summary>
    /// The relation between two Topic(s), in terms of their cultural coverage. For example, Football isSubTopicOf Sport.
    /// It can be used widely to talk about document annotations, subject directories, etc.
    /// The counterpart of this relation for TopicSpace(s) is simply dul:isPartOf
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isSubTopicOf"></see></summary>
    let isSubTopicOf = _prefix "isSubTopicOf"
    /// <summary>
    /// The relation between two instances of a Topic, in terms of their cultural coverage. For example, Sport hasSubTopic Football.
    /// It can be used widely to talk about document annotations, subject directories, etc.
    /// The counterpart of this relation for TopicSpace(s) is simply dul:hasPart
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#hasSubTopic"></see></summary>
    let hasSubTopic = _prefix "hasSubTopic"
    /// <summary>
    /// A topic assignment is a iol:LinguisticAct in which an dul:Agent assigns a Topic to a document, or in general to any dul:SocialObject.
    /// What is the semiotic act involved in such an assignment? Differently from tagging, which 'selects' one of the references of a document, a topic actually points to an 'area of knowledge', which can be represented as a dul:Collection of dul:SocialObject(s) (e.g. of documents, concepts, meanings, etc.).
    /// A Topic is necessarily expressed by a iol:LinguisticObject.
    /// Topics have a typical topology, by which they can be distant, close, overlapping, etc., and a mereology, by which they can be part of others. This also means that 'areas of knowledge' can be part of others, can overlap, etc., so originating clusters of areas and terms that denote them.
    /// The subcollection of terms populating a Topic is called here TopicSignature
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#TopicAssignment"></see></summary>
    let TopicAssignment = _prefix "TopicAssignment"
    /// <summary>
    /// A relation between topic assignments and topics.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#includesTopic"></see></summary>
    let includesTopic = _prefix "includesTopic"
    /// <summary>
    /// The collection of lmm1:Expression(s) that are in a Topic; for example, the topic signatures from sensecorpus, the entries from Roget's, etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#TopicSignature"></see></summary>
    let TopicSignature = _prefix "TopicSignature"
    /// <summary>
    /// The opposite to vicinity relation between two topics, e.g. 'star system' (as a Topic) is farTopicFrom 'geology' (as a Topic).
    /// Distance is typically established with reference to a threshold on the number of dul:SocialObject(s) that are common to the two topics. Alternatively, it can be established with reference to the a geometrical semantics applied to the TopicSpace(s) that are regions for the Topic(s)
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#farTopicFrom"></see></summary>
    let farTopicFrom = _prefix "farTopicFrom"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#hasCoreConcept"></see>
    /// </summary>
    let hasCoreConcept = _prefix "hasCoreConcept"
    /// <summary>
    /// A Concept is a core concept for a Topic when it classifies a set of entities that are references of some relevant information objects that have that Topic.
    /// For example, Saxophone (as a Concept) isCoreConceptFor Saxophones (as a Topic).
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isCoreConceptFor"></see></summary>
    let isCoreConceptFor = _prefix "isCoreConceptFor"
    /// <summary>
    /// The relation between ay Entity - but usually any dul:SocialObject (usually a document) - and a Topic (subject, argument, domain, theme, subject area, etc.). It can be used widely to talk about document annotations, subject directories, etc.
    /// The range is here relaxed to any SocialObject, in order to allow alignment of deviant uses of topic or subject relations for 'concepts' (e.g. in thesauri), and other things that are mixed up with the notion of Topic.
    /// This move makes the hasTopic relation very general, and introduces a particular semiotic relation, different from dul:expresses, lmm1:denotes, and lmm1:isInterpretationOf: this is a relation between any two social objects, in which the first is (or is related to) some lmm1:Meaning that dul:isMemberOf a dul:Collection (a Topic). The second social object can even be another member of that Topic. Hence, in the general case, we could expect a relation between two social objects that are associated because they are members of a common Topic.
    /// For example, consider the following cases:
    /// (1) A biography of Brigitte Bardot (dul:InformationObject) ontopic:hasTopic 'star system' (Topic)
    /// (2) The concept of 'starlet' (dul:Concept) hasTopic 'cinema' (Topic)
    /// (3) A biography of Claude Chabrol (dul:InformationObject) ontopic:hasTopic 'Nouvelle Vague' (Topic)
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#hasTopic"></see></summary>
    let hasTopic = _prefix "hasTopic"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#hasTopicSignature"></see>
    /// </summary>
    let hasTopicSignature = _prefix "hasTopicSignature"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isTopicSignatureOf"></see>
    /// </summary>
    let isTopicSignatureOf = _prefix "isTopicSignatureOf"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#isTopicIncludedIn"></see>
    /// </summary>
    let isTopicIncludedIn = _prefix "isTopicIncludedIn"
    /// <summary>
    /// The vicinity relation between two topics, e.g. 'star system' (as a Topic) is nearTopicTo 'cinema' (as a Topic).
    /// Vicinity is typically established with reference to a threshold on the number of dul:SocialObject(s) that are common to the two Topic(s), or based on a geometrical semantics applied to the TopicSpace(s) that are regions for the two Topic(s).
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#nearTopicTo"></see></summary>
    let nearTopicTo = _prefix "nearTopicTo"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#overlappingTopic"></see>
    /// </summary>
    let overlappingTopic = _prefix "overlappingTopic"
