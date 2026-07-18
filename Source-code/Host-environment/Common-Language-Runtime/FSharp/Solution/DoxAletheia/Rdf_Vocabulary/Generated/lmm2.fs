namespace http.www.ontologydesignpatterns.org.ont.lmm.LMM_L2.owl.hash

open DoxAletheia.Rdf_Vocabulary

module lmm2 =
    let _namespace_name = "http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#"

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#isSyntacticFunctionOf"></see>
    /// </summary>
    let isSyntacticFunctionOf =
        Namespaced_IRI.parse _namespace_name "isSyntacticFunctionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#hasSyntacticFunction"></see>
    /// </summary>
    let hasSyntacticFunction =
        Namespaced_IRI.parse _namespace_name "hasSyntacticFunction" |> NamespacedName

    /// <summary>
    /// Any 'feature' used in automatic classification, learning, and in general in all feature-based analyses.
    /// In NLP, this role can be applied to a LinguisticFunction, a PartOfSpeech, a graphical feature, etc.
    /// A feature role holds in the context of an ExperimentalSetting, where also parameters and operations on the featured enities can be defined.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#AnalyticFeature"></see></summary>
    let AnalyticFeature =
        Namespaced_IRI.parse _namespace_name "AnalyticFeature" |> NamespacedName

    /// <summary>
    /// A plan modeled in order to carry out experiments. Roles ('features') can be defined for featured entities that provide evidence for classifying an entity, describing a behavior, etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ExperimentalSetting"></see></summary>
    let ExperimentalSetting =
        Namespaced_IRI.parse _namespace_name "ExperimentalSetting" |> NamespacedName

    /// <summary>
    /// An associative rule is a lmm1:CoText where a neighborhood of a chunk of text is built out of the terms related to the chunk across the texts of a corpus, e.g. given a certain statistical threshold.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#AssociativeContext"></see></summary>
    let AssociativeContext =
        Namespaced_IRI.parse _namespace_name "AssociativeContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#AssociativeRule"></see>
    /// </summary>
    let AssociativeRule =
        Namespaced_IRI.parse _namespace_name "AssociativeRule" |> NamespacedName

    /// <summary>
    /// A Term that expresses a Meaning, and denotes a MultipleReference, e.g. 'Dog', 'Black box'
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ConceptExpression"></see></summary>
    let ConceptExpression =
        Namespaced_IRI.parse _namespace_name "ConceptExpression" |> NamespacedName

    /// <summary>
    /// Any LMM1:Reference that is also a dul:Collection, and can have members that are individual references.
    /// As a collection, a multiple reference can be covered by a dul:Concept, whose instances are the members of the MultipleReference . For example, JohnDoe (an IndividualReference) isMemberOf ACMEEmployees (a MultipleReference), that dul:isCoveredBy the Employee concept. It also holds that JohnDoe isInstanceOf Employee
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#MultipleReference"></see></summary>
    let MultipleReference =
        Namespaced_IRI.parse _namespace_name "MultipleReference" |> NamespacedName

    /// <summary>
    /// A proper noun that denotes an IndividualReference, e.g. 'John Zorn', 'Daimler Benz'.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#Name"></see></summary>
    let Name = Namespaced_IRI.parse _namespace_name "Name" |> NamespacedName

    /// <summary>
    /// A Term that denotes a Reference via anaphora or deixis, e.g. 'the dog over there', 'all my family', 'the current ACME employees', 'the lion described above'.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ContextualExpression"></see></summary>
    let ContextualExpression =
        Namespaced_IRI.parse _namespace_name "ContextualExpression" |> NamespacedName

    /// <summary>
    /// A MultipleReference that is also a TypeCollection, i.e. a Collection whose members constitute the maximal set of individuals that share the same (named) type, i.e. a Concept .
    /// E.g. 'the Italians', 'the nurses', 'the automotive workers'.
    ///
    /// The Expressions that denote such references are typically composed by a determiner ('the' in English), and a noun phrase in plural form.
    ///
    /// Concept references can be empty collections, e.g. 'the square circles'.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ConceptReference"></see></summary>
    let ConceptReference =
        Namespaced_IRI.parse _namespace_name "ConceptReference" |> NamespacedName

    /// <summary>
    /// An IndividualReference that is denoted by a ContextualExpression (anaphoric or deictic), e.g. 'the book in my bag', 'the book mentioned at the beginning of the story'.
    /// The extensional interpretation of Named and Contextual references in a de-reified model can be equivalent, reflecting the paraphrastic property of natural languages, e.g. the extensional interpretations of 'Linosa' and 'the Italian most southern island' are equivalent. This corresponds to saying that names and contextual expressions can denote the same entities.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ContextualReference"></see></summary>
    let ContextualReference =
        Namespaced_IRI.parse _namespace_name "ContextualReference" |> NamespacedName

    /// <summary>
    /// Extensional references are collections that require an extensional enumeration (e.g. 'John and Mary'), or an anaphora that allows to extract an implicit enumeration (e.g. 'the books on my table'). Hence, extensional references have individual references as members.
    ///
    /// Individual references in the extensional reference must be in the setting of some Situation, which means that extensional references only exist if some fact is described by an observer/interpreter.
    ///
    /// The terms expressing extensional references can be names or contextual expressions.
    ///
    /// The extensional interpretation of Concept and Extensional references in a de-reified (abstract) model can be equivalent, reflecting the paraphrastic property of natural languages, e.g. the extensional interpretations of 'IberianCountry' and {Spain, Portugal, Andorra, Gibraltar} are equivalent. This corresponds to saying that concept expressions and contextual expressions can denote the same entities, while having different intensional interpretations (meanings).
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ExtensionalReference"></see></summary>
    let ExtensionalReference =
        Namespaced_IRI.parse _namespace_name "ExtensionalReference" |> NamespacedName

    /// <summary>
    /// Any LMM1:Reference that isInstanceOf a dul:Concept
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#IndividualReference"></see></summary>
    let IndividualReference =
        Namespaced_IRI.parse _namespace_name "IndividualReference" |> NamespacedName

    /// <summary>
    /// An AnaphoricExpression that denotes an enumerated PluralReference, e.g. 'John, Mary, and me'. Enumerated expressions typically have names and anaphoric expressions (e.g. pronouns) as parts.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#EnumeratedExpression"></see></summary>
    let EnumeratedExpression =
        Namespaced_IRI.parse _namespace_name "EnumeratedExpression" |> NamespacedName

    /// <summary>
    /// A text used as an informal definition or comment to a term, lexeme, etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#Gloss"></see></summary>
    let Gloss = Namespaced_IRI.parse _namespace_name "Gloss" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#isInstanceOf"></see>
    /// </summary>
    let isInstanceOf =
        Namespaced_IRI.parse _namespace_name "isInstanceOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#LSARule"></see>
    /// </summary>
    let LSARule = Namespaced_IRI.parse _namespace_name "LSARule" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#LatentContext"></see>
    /// </summary>
    let LatentContext =
        Namespaced_IRI.parse _namespace_name "LatentContext" |> NamespacedName

    /// <summary>
    /// An IndividualReference that is denoted by a Name, e.g. 'John_Zorn' (as an Entity).
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#NamedEntity"></see></summary>
    let NamedEntity =
        Namespaced_IRI.parse _namespace_name "NamedEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#OEisLexicalizedBy"></see>
    /// </summary>
    let OEisLexicalizedBy =
        Namespaced_IRI.parse _namespace_name "OEisLexicalizedBy" |> NamespacedName

    /// <summary>
    /// Lexicalization for ontology elements.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#lexicalizesOE"></see></summary>
    let lexicalizesOE =
        Namespaced_IRI.parse _namespace_name "lexicalizesOE" |> NamespacedName

    /// <summary>
    /// A complex ConceptExpression that denotes a MultipleReference, e.g. 'the antique books'.
    /// A polyrhematic expression usually has an associated 'head word'.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#PolyrhematicConceptExpression"></see></summary>
    let PolyrhematicConceptExpression =
        Namespaced_IRI.parse _namespace_name "PolyrhematicConceptExpression" |> NamespacedName

    /// <summary>
    /// A simple ConceptExpression that denotes a ClassReference, e.g. 'the nurses'.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#SimpleConceptExpression"></see></summary>
    let SimpleConceptExpression =
        Namespaced_IRI.parse _namespace_name "SimpleConceptExpression" |> NamespacedName

    /// <summary>
    /// A lmm1:CoText that is equivalent to a neighborhood of a certain chunk of text, which can be built based on a syntagmatic rule, e.g. all words from the sentence where the chunk occurs.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#SyntacticContext"></see></summary>
    let SyntacticContext =
        Namespaced_IRI.parse _namespace_name "SyntacticContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#SyntacticRule"></see>
    /// </summary>
    let SyntacticRule =
        Namespaced_IRI.parse _namespace_name "SyntacticRule" |> NamespacedName

    /// <summary>
    /// A relation between two meanings that are both interpretant for a same information object.
    /// <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#hasCoInterpretant"></see></summary>
    let hasCoInterpretant =
        Namespaced_IRI.parse _namespace_name "hasCoInterpretant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#hasInstance"></see>
    /// </summary>
    let hasInstance =
        Namespaced_IRI.parse _namespace_name "hasInstance" |> NamespacedName
