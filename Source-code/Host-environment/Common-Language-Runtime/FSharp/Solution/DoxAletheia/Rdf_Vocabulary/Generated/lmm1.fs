namespace http.www.ontologydesignpatterns.org.ont.lmm.LMM_L1.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lmm1 =
    let _namespace_iri = Namespace_Iri lmm1 |> NamespaceIRI
    /// <summary>
    ///   <para>lmm1:relatedMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>A relation between any two meanings.</para>
    /// labels<para>related meaning</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#relatedMeaning">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#relatedMeaning</seealso>
    let relatedMeaning = Prefixed_Name(lmm1, "relatedMeaning") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:hasInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a Meaning and a Reference : a Meaning gives unity to a Collection of entities.
    /// A same Reference can be given different interpretations, for example, an old cradle can be given a unifying Meaning based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot.
    /// This relation allows to generalize over the following DOLCE-Ultralite relations: dul:isClassifedBy, dul:isCoveredBy, dul:isDescribedBy, dul:isUnifiedBy, and dul:satisfies</para>
    /// labels<para>has interpretation</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#hasInterpretation">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#hasInterpretation</seealso>
    let hasInterpretation = Prefixed_Name(lmm1, "hasInterpretation") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:hasContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A catch-all property for all notions of Context considered in LMM.</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#hasContext">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#hasContext</seealso>
    let hasContext = Prefixed_Name(lmm1, "hasContext") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:isInterpretationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a Meaning and a Reference : a Meaning gives unity to an Entity or to a Collection of entities.
    /// A same Reference can be given different interpretations, for example, an old cradle can be given a unifying Meaning based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot.
    /// This relation allows to generalize over the following DOLCE-Ultralite relations: dul:classifies, dul:covers, dul:describes, dul:unifies, and dul:isSatisfiedBy</para>
    /// labels<para>is interpretation of</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isInterpretationOf">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isInterpretationOf</seealso>
    let isInterpretationOf = Prefixed_Name(lmm1, "isInterpretationOf") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any context, such as:
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
    /// Contexts can also emerge based on what relations are considered "context triggers". For example, in this ontology very different relations: part, participation, setting, membership, acting for, localization, etc. are considered context triggers by adding owl:subPropertyOf axioms to the property: isContextOf. Since the class Context has an equivalent axiom to isContextOf someValuesFrom dul:Entity, everything has a property that is declared subPropertyOf isContextOf, will be inferred to be a Context as well.</para>
    /// labels<para>Contesto {it}</para><para>Contesto</para><para>Context</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Context">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Context</seealso>
    let Context = Prefixed_Name(lmm1, "Context") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:Meaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any conceptualization that dul:isExpressedBy an Expression, or isInterpretationOf a Reference</para>
    /// labels<para>Meaning</para><para>Meaning</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Meaning">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Meaning</seealso>
    let Meaning = Prefixed_Name(lmm1, "Meaning") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:isContextOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isContextOf">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isContextOf</seealso>
    let isContextOf = Prefixed_Name(lmm1, "isContextOf") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:hasInterpretant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Peircean interpretant relation, widely adopted in semiotics: a dul:InformationObject isInterpretantFor another, e.g. fourLeggedFriendOfHumans isInterpretantFor dog.
    /// Synonymy, associativity, and even topical proximity are all sources for interpretants, e.g.: domestic dog isInterpretantFor dog (synonymy); bark isInterpretantFor dog (associativity); veterinary isInterpretantFor dog (topical proximity).
    /// Semantic mechanisms such as metonymy depend on the interpretant relation.
    /// The interpretant relation is here taken as very broad, also accepting InformationRealization(s) as interpretants.</para>
    /// labels<para>has interpretant</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#hasInterpretant">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#hasInterpretant</seealso>
    let hasInterpretant = Prefixed_Name(lmm1, "hasInterpretant") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:isInterpretantFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Peircean interpretant relation, widely adopted in semiotics: a dul:InformationObject isInterpretantFor another, e.g. fourLeggedFriendOfHumans isInterpretantFor dog.
    /// Synonymy, associativity, and even topical proximity are all sources for interpretants, e.g.: domestic dog isInterpretantFor dog (synonymy); bark isInterpretantFor dog (associativity); veterinary isInterpretantFor dog (topical proximity).
    /// Semantic mechanisms such as metonymy depend on the interpretant relation.
    /// The interpretant relation is here taken as very broad, also accepting realization of information as interpretants.</para>
    /// labels<para>is interpretant for</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isInterpretantFor">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isInterpretantFor</seealso>
    let isInterpretantFor = Prefixed_Name(lmm1, "isInterpretantFor") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:CoText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The context of an Expression .
    /// A CoText is a neighborhood of a certain chunk of text, which can be built based on a syntactic rule (all words from the sentence
    /// where the chunk occurs), an associative rule (all terms that are related to the chunk across the texts of a corpus,
    /// given a certain statistical threshold), etc.</para>
    /// labels<para>Cotesto {it}</para><para>Co-text</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#CoText">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#CoText</seealso>
    let CoText = Prefixed_Name(lmm1, "CoText") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:ConstructionRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A description of how to build an entity. For example, a logical rule, a productive rule, a statistical algorithm, etc.</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#ConstructionRule">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#ConstructionRule</seealso>
    let ConstructionRule = Prefixed_Name(lmm1, "ConstructionRule") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any information that either dul:expresses a Meaning or denotes a Reference</para>
    /// labels<para>Expression</para><para>Expression</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Expression">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Expression</seealso>
    let Expression = Prefixed_Name(lmm1, "Expression") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:denotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between expressions and any Entity (including expressions).
    /// It can be used to talk about e.g. entities denoted by proper nouns: the proper noun 'Leonardo da Vinci' denotes the Person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' denotes the collection of all persons in a domain of discourse.</para>
    /// labels<para>denotes</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#denotes">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#denotes</seealso>
    let denotes = Prefixed_Name(lmm1, "denotes") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:KnowledgeCommunity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The context of agents that conceptualize a same Paradigm. This restriction cannot be represented in OWL in general, but should be encoded for specific knowledge communities by stating the specific paradigm that agents acting for it must conceptualize.</para>
    /// labels<para>Comunità di conoscenza {it}</para><para>Knowledge community</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#KnowledgeCommunity">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#KnowledgeCommunity</seealso>
    let KnowledgeCommunity = Prefixed_Name(lmm1, "KnowledgeCommunity") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any Entity that isDenotedBy an Expression, or that hasInterpretation some Meaning</para>
    /// labels<para>Reference</para><para>Reference</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Reference">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Reference</seealso>
    let Reference = Prefixed_Name(lmm1, "Reference") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:Paradigm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The context of an expressed Meaning</para>
    /// labels<para>Paradigma {it}</para><para>Paradigm</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Paradigm">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Paradigm</seealso>
    let Paradigm = Prefixed_Name(lmm1, "Paradigm") |> PrefixedName
    /// <summary>
    ///   <para>lmm1:isDenotedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is denoted by</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isDenotedBy">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isDenotedBy</seealso>
    let isDenotedBy = Prefixed_Name(lmm1, "isDenotedBy") |> PrefixedName
