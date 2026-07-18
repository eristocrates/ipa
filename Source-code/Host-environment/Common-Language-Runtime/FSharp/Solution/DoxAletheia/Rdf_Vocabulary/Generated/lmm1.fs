namespace http.www.ontologydesignpatterns.org.ont.lmm.LMM_L1.owl.hash

open DoxAletheia.Rdf_Vocabulary

module lmm1 =
    let _namespace_name = "http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#"
    /// <summary>
    /// Any context, such as:
    ///
    /// - dul:Situation (the circumstantial context of denoted Entity(ies))
    /// - Paradigm (the cultural context of expressed Meaning(s))
    /// - CoText (the informational context of Expression(s))
    /// - dul:Description (the relational context of Concept(s))
    /// - KnowledgeCommunity (the social context of conceptualizing Agent(s))
    /// - dul:Place (the spatial context of Entity(ies))
    ///
    /// but also a dul:PhysicalPlace, a dul:Event, etc. In practice, everything that is said to be a context for something else.
    ///
    /// Notice that certain contexts can be given independently from the entities that are contextualized (e.g. the ones listed above), others need a core entity and a rule to build its neighborhood, and still others can be classified as such when a certain relation is applied to them.
    /// For example, a scientific theory is a dul:Description that works as a context for its dul:Concept(s), and can be given independently from the concepts, which can remain implicit to a certain extent. On the contrary, a CoText is actually a neighborhood of a certain chunk of text, which can be built based on a syntagmatic rule (all words from the sentence where the chunk occurs), an associative rule (all terms that are related to the chunk across the texts of a corpus, given a certain statistical threshold), etc.
    /// Contexts can also emerge based on what relations are considered "context triggers". For example, in this ontology very different relations: part, participation, setting, membership, acting for, localization, etc. are considered context triggers by adding owl:subPropertyOf axioms to the property: isContextOf. Since the class Context has an equivalent axiom to isContextOf someValuesFrom dul:Entity, everything has a property that is declared subPropertyOf isContextOf, will be inferred to be a Context as well.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Context"></see></summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName
    /// <summary>
    /// Any Entity that isDenotedBy an Expression, or that hasInterpretation some Meaning
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Reference"></see></summary>
    let Reference = Namespaced_IRI.parse _namespace_name "Reference" |> NamespacedName
    /// <summary>
    /// Any conceptualization that dul:isExpressedBy an Expression, or isInterpretationOf a Reference
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Meaning"></see></summary>
    let Meaning = Namespaced_IRI.parse _namespace_name "Meaning" |> NamespacedName
    /// <summary>
    /// A catch-all property for all notions of Context considered in LMM.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#hasContext"></see></summary>
    let hasContext = Namespaced_IRI.parse _namespace_name "hasContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isContextOf"></see>
    /// </summary>
    let isContextOf =
        Namespaced_IRI.parse _namespace_name "isContextOf" |> NamespacedName

    /// <summary>
    /// A relation between any two meanings.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#relatedMeaning"></see></summary>
    let relatedMeaning =
        Namespaced_IRI.parse _namespace_name "relatedMeaning" |> NamespacedName

    /// <summary>
    /// The relation between a Meaning and a Reference : a Meaning gives unity to an Entity or to a Collection of entities.
    /// A same Reference can be given different interpretations, for example, an old cradle can be given a unifying Meaning based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot.
    /// This relation allows to generalize over the following DOLCE-Ultralite relations: dul:classifies, dul:covers, dul:describes, dul:unifies, and dul:isSatisfiedBy
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isInterpretationOf"></see></summary>
    let isInterpretationOf =
        Namespaced_IRI.parse _namespace_name "isInterpretationOf" |> NamespacedName

    /// <summary>
    /// The Peircean interpretant relation, widely adopted in semiotics: a dul:InformationObject isInterpretantFor another, e.g. fourLeggedFriendOfHumans isInterpretantFor dog.
    /// Synonymy, associativity, and even topical proximity are all sources for interpretants, e.g.: domestic dog isInterpretantFor dog (synonymy); bark isInterpretantFor dog (associativity); veterinary isInterpretantFor dog (topical proximity).
    /// Semantic mechanisms such as metonymy depend on the interpretant relation.
    /// The interpretant relation is here taken as very broad, also accepting InformationRealization(s) as interpretants.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#hasInterpretant"></see></summary>
    let hasInterpretant =
        Namespaced_IRI.parse _namespace_name "hasInterpretant" |> NamespacedName

    /// <summary>
    /// The relation between a Meaning and a Reference : a Meaning gives unity to a Collection of entities.
    /// A same Reference can be given different interpretations, for example, an old cradle can be given a unifying Meaning based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot.
    /// This relation allows to generalize over the following DOLCE-Ultralite relations: dul:isClassifedBy, dul:isCoveredBy, dul:isDescribedBy, dul:isUnifiedBy, and dul:satisfies
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#hasInterpretation"></see></summary>
    let hasInterpretation =
        Namespaced_IRI.parse _namespace_name "hasInterpretation" |> NamespacedName

    /// <summary>
    /// The Peircean interpretant relation, widely adopted in semiotics: a dul:InformationObject isInterpretantFor another, e.g. fourLeggedFriendOfHumans isInterpretantFor dog.
    /// Synonymy, associativity, and even topical proximity are all sources for interpretants, e.g.: domestic dog isInterpretantFor dog (synonymy); bark isInterpretantFor dog (associativity); veterinary isInterpretantFor dog (topical proximity).
    /// Semantic mechanisms such as metonymy depend on the interpretant relation.
    /// The interpretant relation is here taken as very broad, also accepting realization of information as interpretants.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isInterpretantFor"></see></summary>
    let isInterpretantFor =
        Namespaced_IRI.parse _namespace_name "isInterpretantFor" |> NamespacedName

    /// <summary>
    /// The context of an Expression .
    /// A CoText is a neighborhood of a certain chunk of text, which can be built based on a syntactic rule (all words from the sentence
    /// where the chunk occurs), an associative rule (all terms that are related to the chunk across the texts of a corpus,
    /// given a certain statistical threshold), etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#CoText"></see></summary>
    let CoText = Namespaced_IRI.parse _namespace_name "CoText" |> NamespacedName
    /// <summary>
    /// Any information that either dul:expresses a Meaning or denotes a Reference
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Expression"></see></summary>
    let Expression = Namespaced_IRI.parse _namespace_name "Expression" |> NamespacedName

    /// <summary>
    /// A description of how to build an entity. For example, a logical rule, a productive rule, a statistical algorithm, etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#ConstructionRule"></see></summary>
    let ConstructionRule =
        Namespaced_IRI.parse _namespace_name "ConstructionRule" |> NamespacedName

    /// <summary>
    /// A relation between expressions and any Entity (including expressions).
    /// It can be used to talk about e.g. entities denoted by proper nouns: the proper noun 'Leonardo da Vinci' denotes the Person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' denotes the collection of all persons in a domain of discourse.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#denotes"></see></summary>
    let denotes = Namespaced_IRI.parse _namespace_name "denotes" |> NamespacedName

    /// <summary>
    /// The context of agents that conceptualize a same Paradigm. This restriction cannot be represented in OWL in general, but should be encoded for specific knowledge communities by stating the specific paradigm that agents acting for it must conceptualize.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#KnowledgeCommunity"></see></summary>
    let KnowledgeCommunity =
        Namespaced_IRI.parse _namespace_name "KnowledgeCommunity" |> NamespacedName

    /// <summary>
    /// The context of an expressed Meaning
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Paradigm"></see></summary>
    let Paradigm = Namespaced_IRI.parse _namespace_name "Paradigm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isDenotedBy"></see>
    /// </summary>
    let isDenotedBy =
        Namespaced_IRI.parse _namespace_name "isDenotedBy" |> NamespacedName
