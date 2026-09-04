#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module semiotics =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#" "semiotics"

    /// <summary>
    ///   <para>rdfs:label : Expression</para>
    ///   <para>rdfs:comment : Any information that either dul:expresses a Meaning or denotes a Reference^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Expression">semiotics:Expression</a>
    /// </summary>
    let Expression = _prefixId.prefix "Expression"
    /// <summary>
    ///   <para>rdfs:label : InformationEntity^^xsd:string</para>
    ///   <para>rdfs:comment : Either an information object (expression) or its realization (manifestation).^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#InformationEntity">semiotics:InformationEntity</a>
    /// </summary>
    let InformationEntity = _prefixId.prefix "InformationEntity"
    /// <summary>
    ///   <para>rdfs:comment : A communicative situation including expressions, agents, and the semiotic elements: physical (manifestations), conceptual (meanings), and referential (references).^^xsd:string</para>
    ///   <para>rdfs:label : Linguistic actrdfs:label : Atto linguistico</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#LinguisticAct">semiotics:LinguisticAct</a>
    /// </summary>
    let LinguisticAct = _prefixId.prefix "LinguisticAct"
    let Manifestation = _prefixId.prefix "Manifestation"
    /// <summary>
    ///   <para>rdfs:label : Meaning</para>
    ///   <para>rdfs:comment : Any conceptualization that isExpressedBy an Expression, or isInterpretationOf a Reference^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Meaning">semiotics:Meaning</a>
    /// </summary>
    let Meaning = _prefixId.prefix "Meaning"
    /// <summary>
    ///   <para>rdfs:label : Reference</para>
    ///   <para>rdfs:comment : Anything that isDenotedBy an Expression, or that hasInterpretation some Meaning^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Reference">semiotics:Reference</a>
    /// </summary>
    let Reference = _prefixId.prefix "Reference"
    /// <summary>
    ///   <para>rdfs:label : denotes</para>
    ///   <para>rdfs:comment : A relation between expressions and anything (including expressions).
    /// It can be used to talk about e.g. entities denoted by proper nouns: the proper noun 'Leonardo da Vinci' denotes the person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' denotes the collection of all persons in a domain of discourse. In OWL2, punning can be used to represent denotation of concept names with owl class extensions, e.g. 'mouse' denotes owl:Class:Mouse.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#denotes">semiotics:denotes</a>
    /// </summary>
    let denotes = _prefixId.prefix "denotes"
    /// <summary>
    ///   <para>rdfs:label : expressesrdfs:label : esprime</para>
    ///   <para>rdfs:comment : A relation between an Expression and a Meaning. For example: 'A Beehive is a structure in which bees are kept, typically in the form of a dome or box.' (Oxford dictionary)'; 'the term Beehive expresses the concept Beehive in my apiculture ontology'.
    /// The intuition for 'meaning' is intended to be very broad. A separate, large comment is included for those who want to investigate more on what kind of meaning can be represented in what form.^^xsd:stringrdfs:comment : This is a large comment field for those who want to investigate the different uses of the 'expresses' relation for modeling different approaches to meaning characterization and modeling.
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
    /// This is only a first step to provide a framework, in which one can model different aspects of Meaning. A more developed ontology should approach the problem of integrating the different uses of 'expresses', so that different theories, resources, and methods can interoperate.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#expresses">semiotics:expresses</a>
    /// </summary>
    let expresses = _prefixId.prefix "expresses"
    /// <summary>
    ///   <para>rdfs:label : has conceptualization</para>
    ///   <para>rdfs:comment : The relation between a Meaning and a Reference : a Meaning conceptualizes an entity or a collection of entities.
    /// A same Reference can be given different conceptualizations, for example, an old cradle can be given a unifying Meaning based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot. Example: myoldcradle hasConceptualization FlowerPot. In OWL2, punning can be used to use the intension of an OWL class as a meaning, e.g. myoldcradle hasConceptualization owl:Class:FlowerPot.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#hasConceptualization">semiotics:hasConceptualization</a>
    /// </summary>
    let hasConceptualization = _prefixId.prefix "hasConceptualization"
    /// <summary>
    ///   <para>rdfs:label : has meaning^^xsd:stringrdfs:label : has interpretant</para>
    ///   <para>rdfs:comment : The Peircean interpretant relation, widely adopted in semiotics: an Expression isInterpretantFor another, e.g. fourLeggedFriendOfHumans isInterpretantFor dog.
    /// Synonymy, translation, associativity, and topical proximity are all sources for interpretants, e.g.: domestic dog isInterpretantFor dog (synonymy); cane isInterpretantFor dog (translation); bark isInterpretantFor dog (associativity); veterinary isInterpretantFor dog (topical proximity).
    /// Semantic mechanisms such as metonymy depend on the interpretant relation.
    /// The interpretant relation is here taken as very broad, also accepting Manifestation(s) as interpretants.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#hasInterpretant">semiotics:hasInterpretant</a>
    /// </summary>
    let hasInterpretant = _prefixId.prefix "hasInterpretant"
    /// <summary>
    ///   <para>rdfs:label : semiotics.owl#hasManifestation^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#hasManifestation">semiotics:hasManifestation</a>
    /// </summary>
    let hasManifestation = _prefixId.prefix "hasManifestation"
    /// <summary>
    ///   <para>rdfs:label : is conceptualization of</para>
    ///   <para>rdfs:comment : The relation between a Meaning and a Reference : a Meaning conceptualizes an entity or a collection of entities.
    /// A same Reference can be given different conceptualizations, for example, an old cradle can be given a unifying Meaning based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot. Example: myoldcradle hasConceptualization FlowerPot. In OWL2, punning can be used to use the intension of an OWL class as a meaning, e.g. myoldcradle hasConceptualization owl:Class:FlowerPot.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isConceptualizationOf">semiotics:isConceptualizationOf</a>
    /// </summary>
    let isConceptualizationOf = _prefixId.prefix "isConceptualizationOf"
    /// <summary>
    ///   <para>rdfs:comment : A relation between expressions and anything (including expressions).
    /// It can be used to talk about e.g. entities denoted by proper nouns: the proper noun 'Leonardo da Vinci' denotes the person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' denotes the collection of all persons in a domain of discourse. In OWL2, punning can be used to represent denotation of concept names with owl class extensions, e.g. 'mouse' denotes owl:Class:Mouse.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isDenotedBy">semiotics:isDenotedBy</a>
    /// </summary>
    let isDenotedBy = _prefixId.prefix "isDenotedBy"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an Expression and a Meaning. For example: 'A Beehive is a structure in which bees are kept, typically in the form of a dome or box.' (Oxford dictionary)'; 'the term Beehive expresses the concept Beehive in my apiculture ontology'.
    /// The intuition for 'meaning' is intended to be very broad. A separate, large comment is included for those who want to investigate more on what kind of meaning can be represented in what form.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isExpressedBy">semiotics:isExpressedBy</a>
    /// </summary>
    let isExpressedBy = _prefixId.prefix "isExpressedBy"
    /// <summary>
    ///   <para>rdfs:comment : The Peircean interpretant relation, widely adopted in semiotics: an Expression isInterpretantFor another, e.g. fourLeggedFriendOfHumans isInterpretantFor dog.
    /// Synonymy, translation, associativity, and topical proximity are all sources for interpretants, e.g.: domestic dog isInterpretantFor dog (synonymy); cane isInterpretantFor dog (translation); bark isInterpretantFor dog (associativity); veterinary isInterpretantFor dog (topical proximity).
    /// Semantic mechanisms such as metonymy depend on the interpretant relation.
    /// The interpretant relation is here taken as very broad, also accepting Manifestation(s) as interpretants.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isInterpretantFor">semiotics:isInterpretantFor</a>
    /// </summary>
    let isInterpretantFor = _prefixId.prefix "isInterpretantFor"
    /// <summary>
    ///   <para>rdfs:label : semiotics.owl#isManifestationOf^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isManifestationOf">semiotics:isManifestationOf</a>
    /// </summary>
    let isManifestationOf = _prefixId.prefix "isManifestationOf"
    /// <summary>
    ///   <para>rdfs:label : related meaning</para>
    ///   <para>rdfs:comment : A relation between any two Meaning(s).^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#relatedMeaning">semiotics:relatedMeaning</a>
    /// </summary>
    let relatedMeaning = _prefixId.prefix "relatedMeaning"
