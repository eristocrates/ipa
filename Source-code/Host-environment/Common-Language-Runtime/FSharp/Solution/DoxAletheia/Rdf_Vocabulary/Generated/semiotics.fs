namespace http.www.ontologydesignpatterns.org.cp.owl.semiotics.owl.hash

open DoxAletheia.Rdf_Vocabulary

module semiotics =
    let _namespace_name = "http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#"
    /// <summary>
    /// Any information that either dul:expresses a Meaning or denotes a Reference
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Expression"></see></summary>
    let Expression = Namespaced_IRI.parse _namespace_name "Expression" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Manifestation"></see>
    /// </summary>
    let Manifestation =
        Namespaced_IRI.parse _namespace_name "Manifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#hasManifestation"></see>
    /// </summary>
    let hasManifestation =
        Namespaced_IRI.parse _namespace_name "hasManifestation" |> NamespacedName

    /// <summary>
    /// Either an information object (expression) or its realization (manifestation).
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#InformationEntity"></see></summary>
    let InformationEntity =
        Namespaced_IRI.parse _namespace_name "InformationEntity" |> NamespacedName

    /// <summary>
    /// Any conceptualization that isExpressedBy an Expression, or isInterpretationOf a Reference
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Meaning"></see></summary>
    let Meaning = Namespaced_IRI.parse _namespace_name "Meaning" |> NamespacedName
    /// <summary>
    /// A relation between an Expression and a Meaning. For example: 'A Beehive is a structure in which bees are kept, typically in the form of a dome or box.' (Oxford dictionary)'; 'the term Beehive expresses the concept Beehive in my apiculture ontology'.
    /// The intuition for 'meaning' is intended to be very broad. A separate, large comment is included for those who want to investigate more on what kind of meaning can be represented in what form.
    /// This is a large comment field for those who want to investigate the different uses of the 'expresses' relation for modeling different approaches to meaning characterization and modeling.
    /// For example, in all these cases, some aspect of meaning is involved:
    ///
    /// - Beehive means "a structure in which bees are kept, typically in the form of a dome or box." (Oxford dictionary)
    /// - 'Beehive' is a synonym in noun synset 09218159 "beehive|hive" (WordNet)
    /// - 'the term Beehive can be interpreted as the fact of 'being a beehive', i.e. a relation that holds for concepts such as Bee, Honey, Hosting, etc.'
    /// - 'the text of Italian apiculture regulation expresses a rule by which beehives should be kept at least one kilometer away from inhabited areas'
    /// - 'the term Beehive expresses the concept Beehive'
    /// - ''Beehive' for apiculturists does not express the same meaning as for, say, fishermen'
    /// - 'Your meaning of 'Beautiful' does not seem to fit mine'
    /// - ''Beehive' is formally interpreted as the set of all beehives'
    /// - 'from the term 'Beehive', we can build a vector space of statistically significant cooccurring terms in the documents that contain it'
    /// - the lexeme 'Belly' expresses the role 'Body_Part' in the frame 'ObservableBodyParts' (FrameNet)
    ///
    /// As the examples suggest, the 'meaning of meaning' is dependent on the background approach/theory that one assumes. One can hardly make a summary of the too many approaches and theories of meaning, therefore this relation is maybe the most controversial and difficult to explain; normally, in such cases it would be better to give up formalizing.
    /// However, the usefulness of having a 'semantic abstraction' in modeling information objects is so high (e.g. for the semantic web, interoperability, reengineering, etc.), that we accept this challenging task, although without taking any particular position in the debate.
    /// We provide here some examples, which we want to generalize upon when using the 'expresses' relation to model semantic aspects of social reality.
    ///
    /// In the most common approach, lexicographers that write dictionaries, glossaries, etc. assume that the meaning of a term is a paraphrase (or 'gloss', or 'definition').
    /// Another approach is provided by concept schemes like thesauri and lexicons, which assume that the meaning of a term is a 'concept', encoded as a 'lemma', 'synset', or 'descriptor'.
    /// Still another approach is that of psychologists and cognitive scientists, which often assume that the meaning of an information object is a concept encoded in the mind or cognitive system of an agent.
    /// A radically different approach is taken by social scientists and semioticians, who usually assume that meanings of an information object are spread across the members of a community that use that object.
    /// Another approach that tackles the distributed nature of meaning is assumed by geometrical models of semantics, which assume that the meaning of an InformationObject (e.g. a word) results from the set of informational contexts (e.g. within texts) in which that object is used similarly.
    /// The logical approach to meaning is still different, since it assumes that the meaning of e.g. a term is equivalent to the set of individuals that the term can be applied to; for example, the meaning of 'Ali' is e.g. an individual person called Ali, the meaning of 'Airplane' is e.g. the set of airplanes, etc.
    /// Finally, an approach taken by structuralist linguistics and frame semantics is that a meaning is the relational context in which an information object can be applied; for example, a meaning of 'Airplane' is situated e.g. in the context ('frame') of passenger airline flights.
    ///
    /// These different approaches are not necessarily conflicting, and they mostly talk about different aspects of so-called 'semantics'. They can be summarized and modelled as follows (notice that such list is far from exhaustive):
    ///
    /// (1) Informal meaning (as for linguistic or commonsense semantics: a distinction is assumed between (informal) meaning and reference
    /// 	- Paraphrase meaning (as for lexicographic semantics). Here it is modelled as the expresses relation between instances of Expression and different instances of Expression that act as 'paraphrases'
    /// 	- Conceptual meaning (as for 'concept scheme' semantics). Here it is modelled as the expresses relation between instances of Expression and instances of a concept (a kind of Meaning)
    /// 	- Relational meaning (as for frame semantics). Here it is modelled as the expresses relation between instances of Expression and instances of a frame/relation (other kinds of Meaning)
    /// 	- Cognitive meaning (as for 'psychological' semantics). Here it is modelled as the expresses relation between any instance of Expression and any different instance of IExpression that isRealizedBy a mental, cognitive or neural state (depending on which theory of mind is assumed). Such states can be considered here as instances of processes (occurring in the mind, cognitive system, or neural system of an agent)
    /// 	- Cultural meaning (as for 'social science' semantics). Here it is modelled as the expresses relation between instances of Expression and instances of social objects (another kind of Meaning: institutions, cultural paradigms, norms, social practices, etc.)
    /// 	- Distributional meaning (as for geometrical models of meaning). Here it is modelled as the expresses relation between any instance of Expression and any different instance of Expression that is formally representedIn some (geometrical) region (e.g. a vector space)
    ///
    /// (2) Formal meaning (as for logic and formal semantics: no distinction is assumed between informal meaning and reference, therefore between 'expresses' and 'isAbout', which can be used interchangeably)
    /// 	- Object-level formal meaning (as in the traditional first-order logic semantics). Here it is modelled as the expresses relation between an instance of Expression and an instance of a collection that is a grounding for (in most cases) a set
    ///
    /// This is only a first step to provide a framework, in which one can model different aspects of Meaning. A more developed ontology should approach the problem of integrating the different uses of 'expresses', so that different theories, resources, and methods can interoperate.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#expresses"></see></summary>
    let expresses = Namespaced_IRI.parse _namespace_name "expresses" |> NamespacedName
    /// <summary>
    /// Anything that isDenotedBy an Expression, or that hasInterpretation some Meaning
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Reference"></see></summary>
    let Reference = Namespaced_IRI.parse _namespace_name "Reference" |> NamespacedName
    /// <summary>
    /// A relation between expressions and anything (including expressions).
    /// It can be used to talk about e.g. entities denoted by proper nouns: the proper noun 'Leonardo da Vinci' denotes the person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' denotes the collection of all persons in a domain of discourse. In OWL2, punning can be used to represent denotation of concept names with owl class extensions, e.g. 'mouse' denotes owl:Class:Mouse.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#denotes"></see></summary>
    let denotes = Namespaced_IRI.parse _namespace_name "denotes" |> NamespacedName

    /// <summary>
    /// The Peircean interpretant relation, widely adopted in semiotics: an Expression isInterpretantFor another, e.g. fourLeggedFriendOfHumans isInterpretantFor dog.
    /// Synonymy, translation, associativity, and topical proximity are all sources for interpretants, e.g.: domestic dog isInterpretantFor dog (synonymy); cane isInterpretantFor dog (translation); bark isInterpretantFor dog (associativity); veterinary isInterpretantFor dog (topical proximity).
    /// Semantic mechanisms such as metonymy depend on the interpretant relation.
    /// The interpretant relation is here taken as very broad, also accepting Manifestation(s) as interpretants.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#hasInterpretant"></see></summary>
    let hasInterpretant =
        Namespaced_IRI.parse _namespace_name "hasInterpretant" |> NamespacedName

    /// <summary>
    /// A communicative situation including expressions, agents, and the semiotic elements: physical (manifestations), conceptual (meanings), and referential (references).
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#LinguisticAct"></see></summary>
    let LinguisticAct =
        Namespaced_IRI.parse _namespace_name "LinguisticAct" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isManifestationOf"></see>
    /// </summary>
    let isManifestationOf =
        Namespaced_IRI.parse _namespace_name "isManifestationOf" |> NamespacedName

    /// <summary>
    /// The relation between a Meaning and a Reference : a Meaning conceptualizes an entity or a collection of entities.
    /// A same Reference can be given different conceptualizations, for example, an old cradle can be given a unifying Meaning based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot. Example: myoldcradle hasConceptualization FlowerPot. In OWL2, punning can be used to use the intension of an OWL class as a meaning, e.g. myoldcradle hasConceptualization owl:Class:FlowerPot.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isConceptualizationOf"></see></summary>
    let isConceptualizationOf =
        Namespaced_IRI.parse _namespace_name "isConceptualizationOf" |> NamespacedName

    /// <summary>
    /// The Peircean interpretant relation, widely adopted in semiotics: an Expression isInterpretantFor another, e.g. fourLeggedFriendOfHumans isInterpretantFor dog.
    /// Synonymy, translation, associativity, and topical proximity are all sources for interpretants, e.g.: domestic dog isInterpretantFor dog (synonymy); cane isInterpretantFor dog (translation); bark isInterpretantFor dog (associativity); veterinary isInterpretantFor dog (topical proximity).
    /// Semantic mechanisms such as metonymy depend on the interpretant relation.
    /// The interpretant relation is here taken as very broad, also accepting Manifestation(s) as interpretants.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isInterpretantFor"></see></summary>
    let isInterpretantFor =
        Namespaced_IRI.parse _namespace_name "isInterpretantFor" |> NamespacedName

    /// <summary>
    /// The relation between a Meaning and a Reference : a Meaning conceptualizes an entity or a collection of entities.
    /// A same Reference can be given different conceptualizations, for example, an old cradle can be given a unifying Meaning based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot. Example: myoldcradle hasConceptualization FlowerPot. In OWL2, punning can be used to use the intension of an OWL class as a meaning, e.g. myoldcradle hasConceptualization owl:Class:FlowerPot.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#hasConceptualization"></see></summary>
    let hasConceptualization =
        Namespaced_IRI.parse _namespace_name "hasConceptualization" |> NamespacedName

    /// <summary>
    /// A relation between expressions and anything (including expressions).
    /// It can be used to talk about e.g. entities denoted by proper nouns: the proper noun 'Leonardo da Vinci' denotes the person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' denotes the collection of all persons in a domain of discourse. In OWL2, punning can be used to represent denotation of concept names with owl class extensions, e.g. 'mouse' denotes owl:Class:Mouse.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isDenotedBy"></see></summary>
    let isDenotedBy =
        Namespaced_IRI.parse _namespace_name "isDenotedBy" |> NamespacedName

    /// <summary>
    /// A relation between an Expression and a Meaning. For example: 'A Beehive is a structure in which bees are kept, typically in the form of a dome or box.' (Oxford dictionary)'; 'the term Beehive expresses the concept Beehive in my apiculture ontology'.
    /// The intuition for 'meaning' is intended to be very broad. A separate, large comment is included for those who want to investigate more on what kind of meaning can be represented in what form.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isExpressedBy"></see></summary>
    let isExpressedBy =
        Namespaced_IRI.parse _namespace_name "isExpressedBy" |> NamespacedName

    /// <summary>
    /// A relation between any two Meaning(s).
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#relatedMeaning"></see></summary>
    let relatedMeaning =
        Namespaced_IRI.parse _namespace_name "relatedMeaning" |> NamespacedName
