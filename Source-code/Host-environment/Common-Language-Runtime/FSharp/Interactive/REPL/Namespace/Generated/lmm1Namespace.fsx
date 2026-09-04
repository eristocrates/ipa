#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lmm1 =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#" "lmm1"

    /// <summary>
    ///   <para>rdfs:comment : The context of an Expression .
    /// A CoText is a neighborhood of a certain chunk of text, which can be built based on a syntactic rule (all words from the sentence
    /// where the chunk occurs), an associative rule (all terms that are related to the chunk across the texts of a corpus,
    /// given a certain statistical threshold), etc.^^xsd:string</para>
    ///   <para>rdfs:label : Co-textrdfs:label : Cotesto {it}^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#CoText">lmm1:CoText</a>
    /// </summary>
    let CoText = _prefixId.prefix "CoText"
    /// <summary>
    ///   <para>rdfs:comment : A description of how to build an entity. For example, a logical rule, a productive rule, a statistical algorithm, etc.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#ConstructionRule">lmm1:ConstructionRule</a>
    /// </summary>
    let ConstructionRule = _prefixId.prefix "ConstructionRule"
    /// <summary>
    ///   <para>rdfs:comment : Any context, such as:
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
    /// Contexts can also emerge based on what relations are considered "context triggers". For example, in this ontology very different relations: part, participation, setting, membership, acting for, localization, etc. are considered context triggers by adding owl:subPropertyOf axioms to the property: isContextOf. Since the class Context has an equivalent axiom to isContextOf someValuesFrom dul:Entity, everything has a property that is declared subPropertyOf isContextOf, will be inferred to be a Context as well.^^xsd:string</para>
    ///   <para>rdfs:label : Contestordfs:label : Contextrdfs:label : Contesto {it}^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Context">lmm1:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>rdfs:comment : Any information that either dul:expresses a Meaning or denotes a Reference^^xsd:string</para>
    ///   <para>rdfs:label : Expressionrdfs:label : Expression^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Expression">lmm1:Expression</a>
    /// </summary>
    let Expression = _prefixId.prefix "Expression"
    /// <summary>
    ///   <para>rdfs:comment : The context of agents that conceptualize a same Paradigm. This restriction cannot be represented in OWL in general, but should be encoded for specific knowledge communities by stating the specific paradigm that agents acting for it must conceptualize.^^xsd:string</para>
    ///   <para>rdfs:label : Knowledge communityrdfs:label : Comunità di conoscenza {it}^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#KnowledgeCommunity">lmm1:KnowledgeCommunity</a>
    /// </summary>
    let KnowledgeCommunity = _prefixId.prefix "KnowledgeCommunity"
    /// <summary>
    ///   <para>rdfs:comment : Any conceptualization that dul:isExpressedBy an Expression, or isInterpretationOf a Reference^^xsd:string</para>
    ///   <para>rdfs:label : Meaningrdfs:label : Meaning^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Meaning">lmm1:Meaning</a>
    /// </summary>
    let Meaning = _prefixId.prefix "Meaning"
    /// <summary>
    ///   <para>rdfs:comment : The context of an expressed Meaning^^xsd:string</para>
    ///   <para>rdfs:label : Paradigmrdfs:label : Paradigma {it}^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Paradigm">lmm1:Paradigm</a>
    /// </summary>
    let Paradigm = _prefixId.prefix "Paradigm"
    /// <summary>
    ///   <para>rdfs:comment : Any Entity that isDenotedBy an Expression, or that hasInterpretation some Meaning^^xsd:string</para>
    ///   <para>rdfs:label : Referencerdfs:label : Reference^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#Reference">lmm1:Reference</a>
    /// </summary>
    let Reference = _prefixId.prefix "Reference"
    /// <summary>
    ///   <para>rdfs:comment : A relation between expressions and any Entity (including expressions).
    /// It can be used to talk about e.g. entities denoted by proper nouns: the proper noun 'Leonardo da Vinci' denotes the Person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' denotes the collection of all persons in a domain of discourse.^^xsd:string</para>
    ///   <para>rdfs:label : denotes</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#denotes">lmm1:denotes</a>
    /// </summary>
    let denotes = _prefixId.prefix "denotes"
    /// <summary>
    ///   <para>rdfs:comment : A catch-all property for all notions of Context considered in LMM.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#hasContext">lmm1:hasContext</a>
    /// </summary>
    let hasContext = _prefixId.prefix "hasContext"
    /// <summary>
    ///   <para>rdfs:comment : The Peircean interpretant relation, widely adopted in semiotics: a dul:InformationObject isInterpretantFor another, e.g. fourLeggedFriendOfHumans isInterpretantFor dog.
    /// Synonymy, associativity, and even topical proximity are all sources for interpretants, e.g.: domestic dog isInterpretantFor dog (synonymy); bark isInterpretantFor dog (associativity); veterinary isInterpretantFor dog (topical proximity).
    /// Semantic mechanisms such as metonymy depend on the interpretant relation.
    /// The interpretant relation is here taken as very broad, also accepting InformationRealization(s) as interpretants.^^xsd:string</para>
    ///   <para>rdfs:label : has interpretant</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#hasInterpretant">lmm1:hasInterpretant</a>
    /// </summary>
    let hasInterpretant = _prefixId.prefix "hasInterpretant"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a Meaning and a Reference : a Meaning gives unity to a Collection of entities.
    /// A same Reference can be given different interpretations, for example, an old cradle can be given a unifying Meaning based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot.
    /// This relation allows to generalize over the following DOLCE-Ultralite relations: dul:isClassifedBy, dul:isCoveredBy, dul:isDescribedBy, dul:isUnifiedBy, and dul:satisfies^^xsd:string</para>
    ///   <para>rdfs:label : has interpretation</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#hasInterpretation">lmm1:hasInterpretation</a>
    /// </summary>
    let hasInterpretation = _prefixId.prefix "hasInterpretation"
    let isContextOf = _prefixId.prefix "isContextOf"
    /// <summary>
    ///   <para>rdfs:label : is denoted by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isDenotedBy">lmm1:isDenotedBy</a>
    /// </summary>
    let isDenotedBy = _prefixId.prefix "isDenotedBy"
    /// <summary>
    ///   <para>rdfs:comment : The Peircean interpretant relation, widely adopted in semiotics: a dul:InformationObject isInterpretantFor another, e.g. fourLeggedFriendOfHumans isInterpretantFor dog.
    /// Synonymy, associativity, and even topical proximity are all sources for interpretants, e.g.: domestic dog isInterpretantFor dog (synonymy); bark isInterpretantFor dog (associativity); veterinary isInterpretantFor dog (topical proximity).
    /// Semantic mechanisms such as metonymy depend on the interpretant relation.
    /// The interpretant relation is here taken as very broad, also accepting realization of information as interpretants.^^xsd:string</para>
    ///   <para>rdfs:label : is interpretant for</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isInterpretantFor">lmm1:isInterpretantFor</a>
    /// </summary>
    let isInterpretantFor = _prefixId.prefix "isInterpretantFor"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a Meaning and a Reference : a Meaning gives unity to an Entity or to a Collection of entities.
    /// A same Reference can be given different interpretations, for example, an old cradle can be given a unifying Meaning based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot.
    /// This relation allows to generalize over the following DOLCE-Ultralite relations: dul:classifies, dul:covers, dul:describes, dul:unifies, and dul:isSatisfiedBy^^xsd:string</para>
    ///   <para>rdfs:label : is interpretation of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#isInterpretationOf">lmm1:isInterpretationOf</a>
    /// </summary>
    let isInterpretationOf = _prefixId.prefix "isInterpretationOf"
    /// <summary>
    ///   <para>rdfs:comment : A relation between any two meanings.^^xsd:string</para>
    ///   <para>rdfs:label : related meaning</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#relatedMeaning">lmm1:relatedMeaning</a>
    /// </summary>
    let relatedMeaning = _prefixId.prefix "relatedMeaning"
