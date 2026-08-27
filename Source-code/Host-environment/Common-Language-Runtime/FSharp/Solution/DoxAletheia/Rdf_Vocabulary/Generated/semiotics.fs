namespace http.www.ontologydesignpatterns.org.cp.owl.semiotics.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module semiotics =
    let _namespace_iri = Namespace_Iri semiotics |> NamespaceIRI
    /// <summary>
    ///   <para>semiotics:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any information that either dul:expresses a Meaning or denotes a Reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Expression"</para><para>"expression"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Expression">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Expression</seealso>
    let Expression = Prefixed_Name(semiotics, "Expression") |> PrefixedName

    /// <summary>
    ///   <para>semiotics:InformationEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Either an information object (expression) or its realization (manifestation)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InformationEntity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#InformationEntity">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#InformationEntity</seealso>
    let InformationEntity =
        Prefixed_Name(semiotics, "InformationEntity") |> PrefixedName

    /// <summary>
    ///   <para>semiotics:LinguisticAct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A communicative situation including expressions, agents, and the semiotic elements: physical (manifestations), conceptual (meanings), and referential (references)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linguistic act"</para><para>"Atto linguistico"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#LinguisticAct">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#LinguisticAct</seealso>
    let LinguisticAct = Prefixed_Name(semiotics, "LinguisticAct") |> PrefixedName
    /// <summary>
    ///   <para>semiotics:Manifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Manifestation">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Manifestation</seealso>
    let Manifestation = Prefixed_Name(semiotics, "Manifestation") |> PrefixedName
    /// <summary>
    ///   <para>semiotics:Meaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any conceptualization that isExpressedBy an Expression, or isInterpretationOf a Reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"meaning"</para><para>"Meaning"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Meaning">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Meaning</seealso>
    let Meaning = Prefixed_Name(semiotics, "Meaning") |> PrefixedName
    /// <summary>
    ///   <para>semiotics:Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Anything that isDenotedBy an Expression, or that hasInterpretation some Meaning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reference"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Reference">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#Reference</seealso>
    let Reference = Prefixed_Name(semiotics, "Reference") |> PrefixedName
    /// <summary>
    ///   <para>semiotics:denotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between expressions and anything (including expressions).
    /// It can be used to talk about e.g. entities denoted by proper nouns: the proper noun 'Leonardo da Vinci' denotes the person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' denotes the collection of all persons in a domain of discourse. In OWL2, punning can be used to represent denotation of concept names with owl class extensions, e.g. 'mouse' denotes owl:Class:Mouse."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"denotes"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#denotes">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#denotes</seealso>
    let denotes = Prefixed_Name(semiotics, "denotes") |> PrefixedName
    /// <summary>
    ///   <para>semiotics:expresses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an Expression and a Meaning. For example: 'A Beehive is a structure in which bees are kept, typically in the form of a dome or box.' (Oxford dictionary)'; 'the term Beehive expresses the concept Beehive in my apiculture ontology'.
    /// The intuition for 'meaning' is intended to be very broad. A separate, large comment is included for those who want to investigate more on what kind of meaning can be represented in what form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This is a large comment field for those who want to investigate the different uses of the 'expresses' relation for modeling different approaches to meaning characterization and modeling.
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
    /// This is only a first step to provide a framework, in which one can model different aspects of Meaning. A more developed ontology should approach the problem of integrating the different uses of 'expresses', so that different theories, resources, and methods can interoperate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"expresses"</para><para>"esprime"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#expresses">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#expresses</seealso>
    let expresses = Prefixed_Name(semiotics, "expresses") |> PrefixedName

    /// <summary>
    ///   <para>semiotics:hasConceptualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a Meaning and a Reference : a Meaning conceptualizes an entity or a collection of entities.
    /// A same Reference can be given different conceptualizations, for example, an old cradle can be given a unifying Meaning based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot. Example: myoldcradle hasConceptualization FlowerPot. In OWL2, punning can be used to use the intension of an OWL class as a meaning, e.g. myoldcradle hasConceptualization owl:Class:FlowerPot."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has conceptualization"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#hasConceptualization">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#hasConceptualization</seealso>
    let hasConceptualization =
        Prefixed_Name(semiotics, "hasConceptualization") |> PrefixedName

    /// <summary>
    ///   <para>semiotics:hasInterpretant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Peircean interpretant relation, widely adopted in semiotics: an Expression isInterpretantFor another, e.g. fourLeggedFriendOfHumans isInterpretantFor dog.
    /// Synonymy, translation, associativity, and topical proximity are all sources for interpretants, e.g.: domestic dog isInterpretantFor dog (synonymy); cane isInterpretantFor dog (translation); bark isInterpretantFor dog (associativity); veterinary isInterpretantFor dog (topical proximity).
    /// Semantic mechanisms such as metonymy depend on the interpretant relation.
    /// The interpretant relation is here taken as very broad, also accepting Manifestation(s) as interpretants."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has interpretant"</para><para>"has meaning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#hasInterpretant">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#hasInterpretant</seealso>
    let hasInterpretant = Prefixed_Name(semiotics, "hasInterpretant") |> PrefixedName
    /// <summary>
    ///   <para>semiotics:hasManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"semiotics.owl#hasManifestation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#hasManifestation">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#hasManifestation</seealso>
    let hasManifestation = Prefixed_Name(semiotics, "hasManifestation") |> PrefixedName

    /// <summary>
    ///   <para>semiotics:isConceptualizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a Meaning and a Reference : a Meaning conceptualizes an entity or a collection of entities.
    /// A same Reference can be given different conceptualizations, for example, an old cradle can be given a unifying Meaning based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot. Example: myoldcradle hasConceptualization FlowerPot. In OWL2, punning can be used to use the intension of an OWL class as a meaning, e.g. myoldcradle hasConceptualization owl:Class:FlowerPot."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is conceptualization of"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isConceptualizationOf">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isConceptualizationOf</seealso>
    let isConceptualizationOf =
        Prefixed_Name(semiotics, "isConceptualizationOf") |> PrefixedName

    /// <summary>
    ///   <para>semiotics:isDenotedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between expressions and anything (including expressions).
    /// It can be used to talk about e.g. entities denoted by proper nouns: the proper noun 'Leonardo da Vinci' denotes the person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' denotes the collection of all persons in a domain of discourse. In OWL2, punning can be used to represent denotation of concept names with owl class extensions, e.g. 'mouse' denotes owl:Class:Mouse."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isDenotedBy">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isDenotedBy</seealso>
    let isDenotedBy = Prefixed_Name(semiotics, "isDenotedBy") |> PrefixedName
    /// <summary>
    ///   <para>semiotics:isExpressedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an Expression and a Meaning. For example: 'A Beehive is a structure in which bees are kept, typically in the form of a dome or box.' (Oxford dictionary)'; 'the term Beehive expresses the concept Beehive in my apiculture ontology'.
    /// The intuition for 'meaning' is intended to be very broad. A separate, large comment is included for those who want to investigate more on what kind of meaning can be represented in what form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isExpressedBy">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isExpressedBy</seealso>
    let isExpressedBy = Prefixed_Name(semiotics, "isExpressedBy") |> PrefixedName

    /// <summary>
    ///   <para>semiotics:isInterpretantFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Peircean interpretant relation, widely adopted in semiotics: an Expression isInterpretantFor another, e.g. fourLeggedFriendOfHumans isInterpretantFor dog.
    /// Synonymy, translation, associativity, and topical proximity are all sources for interpretants, e.g.: domestic dog isInterpretantFor dog (synonymy); cane isInterpretantFor dog (translation); bark isInterpretantFor dog (associativity); veterinary isInterpretantFor dog (topical proximity).
    /// Semantic mechanisms such as metonymy depend on the interpretant relation.
    /// The interpretant relation is here taken as very broad, also accepting Manifestation(s) as interpretants."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isInterpretantFor">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isInterpretantFor</seealso>
    let isInterpretantFor =
        Prefixed_Name(semiotics, "isInterpretantFor") |> PrefixedName

    /// <summary>
    ///   <para>semiotics:isManifestationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"semiotics.owl#isManifestationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isManifestationOf">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#isManifestationOf</seealso>
    let isManifestationOf =
        Prefixed_Name(semiotics, "isManifestationOf") |> PrefixedName

    /// <summary>
    ///   <para>semiotics:relatedMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"A relation between any two Meaning(s)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"related meaning"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#relatedMeaning">http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#relatedMeaning</seealso>
    let relatedMeaning = Prefixed_Name(semiotics, "relatedMeaning") |> PrefixedName
