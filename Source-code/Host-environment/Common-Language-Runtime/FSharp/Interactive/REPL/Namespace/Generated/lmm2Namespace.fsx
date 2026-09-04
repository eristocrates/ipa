#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lmm2 =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#" "lmm2"

    /// <summary>
    ///   <para>rdfs:comment : Any 'feature' used in automatic classification, learning, and in general in all feature-based analyses.
    /// In NLP, this role can be applied to a LinguisticFunction, a PartOfSpeech, a graphical feature, etc.
    /// A feature role holds in the context of an ExperimentalSetting, where also parameters and operations on the featured enities can be defined.^^xsd:string</para>
    ///   <para>rdfs:label : Analytic feature</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#AnalyticFeature">lmm2:AnalyticFeature</a>
    /// </summary>
    let AnalyticFeature = _prefixId.prefix "AnalyticFeature"
    /// <summary>
    ///   <para>rdfs:comment : An associative rule is a lmm1:CoText where a neighborhood of a chunk of text is built out of the terms related to the chunk across the texts of a corpus, e.g. given a certain statistical threshold.^^xsd:string</para>
    ///   <para>rdfs:label : Associative context</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#AssociativeContext">lmm2:AssociativeContext</a>
    /// </summary>
    let AssociativeContext = _prefixId.prefix "AssociativeContext"
    /// <summary>
    ///   <para>rdfs:label : Associative rule</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#AssociativeRule">lmm2:AssociativeRule</a>
    /// </summary>
    let AssociativeRule = _prefixId.prefix "AssociativeRule"
    /// <summary>
    ///   <para>rdfs:comment : A Term that expresses a Meaning, and denotes a MultipleReference, e.g. 'Dog', 'Black box'^^xsd:string</para>
    ///   <para>rdfs:label : Concept expression</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ConceptExpression">lmm2:ConceptExpression</a>
    /// </summary>
    let ConceptExpression = _prefixId.prefix "ConceptExpression"
    /// <summary>
    ///   <para>rdfs:comment : A MultipleReference that is also a TypeCollection, i.e. a Collection whose members constitute the maximal set of individuals that share the same (named) type, i.e. a Concept .
    /// E.g. 'the Italians', 'the nurses', 'the automotive workers'.
    ///
    /// The Expressions that denote such references are typically composed by a determiner ('the' in English), and a noun phrase in plural form.
    ///
    /// Concept references can be empty collections, e.g. 'the square circles'.^^xsd:string</para>
    ///   <para>rdfs:label : Concept reference</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ConceptReference">lmm2:ConceptReference</a>
    /// </summary>
    let ConceptReference = _prefixId.prefix "ConceptReference"
    /// <summary>
    ///   <para>rdfs:comment : A Term that denotes a Reference via anaphora or deixis, e.g. 'the dog over there', 'all my family', 'the current ACME employees', 'the lion described above'.^^xsd:string</para>
    ///   <para>rdfs:label : Contextual expression</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ContextualExpression">lmm2:ContextualExpression</a>
    /// </summary>
    let ContextualExpression = _prefixId.prefix "ContextualExpression"
    /// <summary>
    ///   <para>rdfs:comment : An IndividualReference that is denoted by a ContextualExpression (anaphoric or deictic), e.g. 'the book in my bag', 'the book mentioned at the beginning of the story'.
    /// The extensional interpretation of Named and Contextual references in a de-reified model can be equivalent, reflecting the paraphrastic property of natural languages, e.g. the extensional interpretations of 'Linosa' and 'the Italian most southern island' are equivalent. This corresponds to saying that names and contextual expressions can denote the same entities.^^xsd:string</para>
    ///   <para>rdfs:label : Contextual reference</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ContextualReference">lmm2:ContextualReference</a>
    /// </summary>
    let ContextualReference = _prefixId.prefix "ContextualReference"
    /// <summary>
    ///   <para>rdfs:comment : An AnaphoricExpression that denotes an enumerated PluralReference, e.g. 'John, Mary, and me'. Enumerated expressions typically have names and anaphoric expressions (e.g. pronouns) as parts.^^xsd:string</para>
    ///   <para>rdfs:label : Enumerated expression</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#EnumeratedExpression">lmm2:EnumeratedExpression</a>
    /// </summary>
    let EnumeratedExpression = _prefixId.prefix "EnumeratedExpression"
    /// <summary>
    ///   <para>rdfs:comment : A plan modeled in order to carry out experiments. Roles ('features') can be defined for featured entities that provide evidence for classifying an entity, describing a behavior, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Experimental setting^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ExperimentalSetting">lmm2:ExperimentalSetting</a>
    /// </summary>
    let ExperimentalSetting = _prefixId.prefix "ExperimentalSetting"
    /// <summary>
    ///   <para>rdfs:comment : Extensional references are collections that require an extensional enumeration (e.g. 'John and Mary'), or an anaphora that allows to extract an implicit enumeration (e.g. 'the books on my table'). Hence, extensional references have individual references as members.
    ///
    /// Individual references in the extensional reference must be in the setting of some Situation, which means that extensional references only exist if some fact is described by an observer/interpreter.
    ///
    /// The terms expressing extensional references can be names or contextual expressions.
    ///
    /// The extensional interpretation of Concept and Extensional references in a de-reified (abstract) model can be equivalent, reflecting the paraphrastic property of natural languages, e.g. the extensional interpretations of 'IberianCountry' and {Spain, Portugal, Andorra, Gibraltar} are equivalent. This corresponds to saying that concept expressions and contextual expressions can denote the same entities, while having different intensional interpretations (meanings).^^xsd:string</para>
    ///   <para>rdfs:label : Extensional reference</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ExtensionalReference">lmm2:ExtensionalReference</a>
    /// </summary>
    let ExtensionalReference = _prefixId.prefix "ExtensionalReference"
    /// <summary>
    ///   <para>rdfs:comment : A text used as an informal definition or comment to a term, lexeme, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Gloss^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#Gloss">lmm2:Gloss</a>
    /// </summary>
    let Gloss = _prefixId.prefix "Gloss"
    /// <summary>
    ///   <para>rdfs:comment : Any LMM1:Reference that isInstanceOf a dul:Concept^^xsd:string</para>
    ///   <para>rdfs:label : Individual reference</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#IndividualReference">lmm2:IndividualReference</a>
    /// </summary>
    let IndividualReference = _prefixId.prefix "IndividualReference"
    /// <summary>
    ///   <para>rdfs:label : LSA rule</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#LSARule">lmm2:LSARule</a>
    /// </summary>
    let LSARule = _prefixId.prefix "LSARule"
    /// <summary>
    ///   <para>rdfs:label : Latent context</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#LatentContext">lmm2:LatentContext</a>
    /// </summary>
    let LatentContext = _prefixId.prefix "LatentContext"
    /// <summary>
    ///   <para>rdfs:comment : Any LMM1:Reference that is also a dul:Collection, and can have members that are individual references.
    /// As a collection, a multiple reference can be covered by a dul:Concept, whose instances are the members of the MultipleReference . For example, JohnDoe (an IndividualReference) isMemberOf ACMEEmployees (a MultipleReference), that dul:isCoveredBy the Employee concept. It also holds that JohnDoe isInstanceOf Employee^^xsd:string</para>
    ///   <para>rdfs:label : Multiple reference</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#MultipleReference">lmm2:MultipleReference</a>
    /// </summary>
    let MultipleReference = _prefixId.prefix "MultipleReference"
    /// <summary>
    ///   <para>rdfs:comment : A proper noun that denotes an IndividualReference, e.g. 'John Zorn', 'Daimler Benz'.^^xsd:string</para>
    ///   <para>rdfs:label : Name</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#Name">lmm2:Name</a>
    /// </summary>
    let Name = _prefixId.prefix "Name"
    /// <summary>
    ///   <para>rdfs:comment : An IndividualReference that is denoted by a Name, e.g. 'John_Zorn' (as an Entity).^^xsd:string</para>
    ///   <para>rdfs:label : Named entity</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#NamedEntity">lmm2:NamedEntity</a>
    /// </summary>
    let NamedEntity = _prefixId.prefix "NamedEntity"
    /// <summary>
    ///   <para>rdfs:label : OEis lexicalized by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#OEisLexicalizedBy">lmm2:OEisLexicalizedBy</a>
    /// </summary>
    let OEisLexicalizedBy = _prefixId.prefix "OEisLexicalizedBy"
    /// <summary>
    ///   <para>rdfs:comment : A complex ConceptExpression that denotes a MultipleReference, e.g. 'the antique books'.
    /// A polyrhematic expression usually has an associated 'head word'.^^xsd:string</para>
    ///   <para>rdfs:label : Polyrhematic concept expression</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#PolyrhematicConceptExpression">lmm2:PolyrhematicConceptExpression</a>
    /// </summary>
    let PolyrhematicConceptExpression = _prefixId.prefix "PolyrhematicConceptExpression"
    /// <summary>
    ///   <para>rdfs:comment : A simple ConceptExpression that denotes a ClassReference, e.g. 'the nurses'.^^xsd:string</para>
    ///   <para>rdfs:label : Simple concept expression</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#SimpleConceptExpression">lmm2:SimpleConceptExpression</a>
    /// </summary>
    let SimpleConceptExpression = _prefixId.prefix "SimpleConceptExpression"
    /// <summary>
    ///   <para>rdfs:comment : A lmm1:CoText that is equivalent to a neighborhood of a certain chunk of text, which can be built based on a syntagmatic rule, e.g. all words from the sentence where the chunk occurs.^^xsd:string</para>
    ///   <para>rdfs:label : Syntactic context</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#SyntacticContext">lmm2:SyntacticContext</a>
    /// </summary>
    let SyntacticContext = _prefixId.prefix "SyntacticContext"
    let SyntacticRule = _prefixId.prefix "SyntacticRule"
    /// <summary>
    ///   <para>rdfs:comment : A relation between two meanings that are both interpretant for a same information object.^^xsd:string</para>
    ///   <para>rdfs:label : has co-interpretant^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#hasCoInterpretant">lmm2:hasCoInterpretant</a>
    /// </summary>
    let hasCoInterpretant = _prefixId.prefix "hasCoInterpretant"
    /// <summary>
    ///   <para>rdfs:label : has instance</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#hasInstance">lmm2:hasInstance</a>
    /// </summary>
    let hasInstance = _prefixId.prefix "hasInstance"
    /// <summary>
    ///   <para>rdfs:label : has syntactic function</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#hasSyntacticFunction">lmm2:hasSyntacticFunction</a>
    /// </summary>
    let hasSyntacticFunction = _prefixId.prefix "hasSyntacticFunction"
    /// <summary>
    ///   <para>rdfs:label : is instance of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#isInstanceOf">lmm2:isInstanceOf</a>
    /// </summary>
    let isInstanceOf = _prefixId.prefix "isInstanceOf"
    /// <summary>
    ///   <para>rdfs:label : is syntactic function of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#isSyntacticFunctionOf">lmm2:isSyntacticFunctionOf</a>
    /// </summary>
    let isSyntacticFunctionOf = _prefixId.prefix "isSyntacticFunctionOf"
    /// <summary>
    ///   <para>rdfs:comment : Lexicalization for ontology elements.^^xsd:string</para>
    ///   <para>rdfs:label : lexicalizes oE</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#lexicalizesOE">lmm2:lexicalizesOE</a>
    /// </summary>
    let lexicalizesOE = _prefixId.prefix "lexicalizesOE"
