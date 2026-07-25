namespace http.www.ontologydesignpatterns.org.ont.lmm.LMM_L2.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lmm2 =
    let _namespace_iri = Namespace_Iri lmm2 |> NamespaceIRI

    /// <summary>
    ///   <para>lmm2:EnumeratedExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An AnaphoricExpression that denotes an enumerated PluralReference, e.g. 'John, Mary, and me'. Enumerated expressions typically have names and anaphoric expressions (e.g. pronouns) as parts.</para>
    /// labels<para>Enumerated expression</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#EnumeratedExpression">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#EnumeratedExpression</seealso>
    let EnumeratedExpression =
        Prefixed_Name(lmm2, "EnumeratedExpression") |> PrefixedName

    /// <summary>
    ///   <para>lmm2:Gloss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A text used as an informal definition or comment to a term, lexeme, etc.</para>
    /// labels<para>Gloss</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#Gloss">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#Gloss</seealso>
    let Gloss = Prefixed_Name(lmm2, "Gloss") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:LatentContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Latent context</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#LatentContext">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#LatentContext</seealso>
    let LatentContext = Prefixed_Name(lmm2, "LatentContext") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:OEisLexicalizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>OEis lexicalized by</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#OEisLexicalizedBy">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#OEisLexicalizedBy</seealso>
    let OEisLexicalizedBy = Prefixed_Name(lmm2, "OEisLexicalizedBy") |> PrefixedName

    /// <summary>
    ///   <para>lmm2:hasSyntacticFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has syntactic function</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#hasSyntacticFunction">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#hasSyntacticFunction</seealso>
    let hasSyntacticFunction =
        Prefixed_Name(lmm2, "hasSyntacticFunction") |> PrefixedName

    /// <summary>
    ///   <para>lmm2:PolyrhematicConceptExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A complex ConceptExpression that denotes a MultipleReference, e.g. 'the antique books'.
    /// A polyrhematic expression usually has an associated 'head word'.</para>
    /// labels<para>Polyrhematic concept expression</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#PolyrhematicConceptExpression">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#PolyrhematicConceptExpression</seealso>
    let PolyrhematicConceptExpression =
        Prefixed_Name(lmm2, "PolyrhematicConceptExpression") |> PrefixedName

    /// <summary>
    ///   <para>lmm2:SyntacticContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A lmm1:CoText that is equivalent to a neighborhood of a certain chunk of text, which can be built based on a syntagmatic rule, e.g. all words from the sentence where the chunk occurs.</para>
    /// labels<para>Syntactic context</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#SyntacticContext">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#SyntacticContext</seealso>
    let SyntacticContext = Prefixed_Name(lmm2, "SyntacticContext") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:hasCoInterpretant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between two meanings that are both interpretant for a same information object.</para>
    /// labels<para>has co-interpretant</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#hasCoInterpretant">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#hasCoInterpretant</seealso>
    let hasCoInterpretant = Prefixed_Name(lmm2, "hasCoInterpretant") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:AnalyticFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any 'feature' used in automatic classification, learning, and in general in all feature-based analyses.
    /// In NLP, this role can be applied to a LinguisticFunction, a PartOfSpeech, a graphical feature, etc.
    /// A feature role holds in the context of an ExperimentalSetting, where also parameters and operations on the featured enities can be defined.</para>
    /// labels<para>Analytic feature</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#AnalyticFeature">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#AnalyticFeature</seealso>
    let AnalyticFeature = Prefixed_Name(lmm2, "AnalyticFeature") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:ConceptExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Term that expresses a Meaning, and denotes a MultipleReference, e.g. 'Dog', 'Black box'</para>
    /// labels<para>Concept expression</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ConceptExpression">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ConceptExpression</seealso>
    let ConceptExpression = Prefixed_Name(lmm2, "ConceptExpression") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:ExperimentalSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A plan modeled in order to carry out experiments. Roles ('features') can be defined for featured entities that provide evidence for classifying an entity, describing a behavior, etc.</para>
    /// labels<para>Experimental setting</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ExperimentalSetting">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ExperimentalSetting</seealso>
    let ExperimentalSetting = Prefixed_Name(lmm2, "ExperimentalSetting") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A proper noun that denotes an IndividualReference, e.g. 'John Zorn', 'Daimler Benz'.</para>
    /// labels<para>Name</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#Name">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#Name</seealso>
    let Name = Prefixed_Name(lmm2, "Name") |> PrefixedName

    /// <summary>
    ///   <para>lmm2:ContextualExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Term that denotes a Reference via anaphora or deixis, e.g. 'the dog over there', 'all my family', 'the current ACME employees', 'the lion described above'.</para>
    /// labels<para>Contextual expression</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ContextualExpression">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ContextualExpression</seealso>
    let ContextualExpression =
        Prefixed_Name(lmm2, "ContextualExpression") |> PrefixedName

    /// <summary>
    ///   <para>lmm2:AssociativeContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An associative rule is a lmm1:CoText where a neighborhood of a chunk of text is built out of the terms related to the chunk across the texts of a corpus, e.g. given a certain statistical threshold.</para>
    /// labels<para>Associative context</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#AssociativeContext">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#AssociativeContext</seealso>
    let AssociativeContext = Prefixed_Name(lmm2, "AssociativeContext") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:MultipleReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any LMM1:Reference that is also a dul:Collection, and can have members that are individual references.
    /// As a collection, a multiple reference can be covered by a dul:Concept, whose instances are the members of the MultipleReference . For example, JohnDoe (an IndividualReference) isMemberOf ACMEEmployees (a MultipleReference), that dul:isCoveredBy the Employee concept. It also holds that JohnDoe isInstanceOf Employee</para>
    /// labels<para>Multiple reference</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#MultipleReference">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#MultipleReference</seealso>
    let MultipleReference = Prefixed_Name(lmm2, "MultipleReference") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:ConceptReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A MultipleReference that is also a TypeCollection, i.e. a Collection whose members constitute the maximal set of individuals that share the same (named) type, i.e. a Concept .
    /// E.g. 'the Italians', 'the nurses', 'the automotive workers'.
    ///
    /// The Expressions that denote such references are typically composed by a determiner ('the' in English), and a noun phrase in plural form.
    ///
    /// Concept references can be empty collections, e.g. 'the square circles'.</para>
    /// labels<para>Concept reference</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ConceptReference">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ConceptReference</seealso>
    let ConceptReference = Prefixed_Name(lmm2, "ConceptReference") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:AssociativeRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Associative rule</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#AssociativeRule">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#AssociativeRule</seealso>
    let AssociativeRule = Prefixed_Name(lmm2, "AssociativeRule") |> PrefixedName

    /// <summary>
    ///   <para>lmm2:ExtensionalReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extensional references are collections that require an extensional enumeration (e.g. 'John and Mary'), or an anaphora that allows to extract an implicit enumeration (e.g. 'the books on my table'). Hence, extensional references have individual references as members.
    ///
    /// Individual references in the extensional reference must be in the setting of some Situation, which means that extensional references only exist if some fact is described by an observer/interpreter.
    ///
    /// The terms expressing extensional references can be names or contextual expressions.
    ///
    /// The extensional interpretation of Concept and Extensional references in a de-reified (abstract) model can be equivalent, reflecting the paraphrastic property of natural languages, e.g. the extensional interpretations of 'IberianCountry' and {Spain, Portugal, Andorra, Gibraltar} are equivalent. This corresponds to saying that concept expressions and contextual expressions can denote the same entities, while having different intensional interpretations (meanings).</para>
    /// labels<para>Extensional reference</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ExtensionalReference">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ExtensionalReference</seealso>
    let ExtensionalReference =
        Prefixed_Name(lmm2, "ExtensionalReference") |> PrefixedName

    /// <summary>
    ///   <para>lmm2:ContextualReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An IndividualReference that is denoted by a ContextualExpression (anaphoric or deictic), e.g. 'the book in my bag', 'the book mentioned at the beginning of the story'.
    /// The extensional interpretation of Named and Contextual references in a de-reified model can be equivalent, reflecting the paraphrastic property of natural languages, e.g. the extensional interpretations of 'Linosa' and 'the Italian most southern island' are equivalent. This corresponds to saying that names and contextual expressions can denote the same entities.</para>
    /// labels<para>Contextual reference</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ContextualReference">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#ContextualReference</seealso>
    let ContextualReference = Prefixed_Name(lmm2, "ContextualReference") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:IndividualReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any LMM1:Reference that isInstanceOf a dul:Concept</para>
    /// labels<para>Individual reference</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#IndividualReference">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#IndividualReference</seealso>
    let IndividualReference = Prefixed_Name(lmm2, "IndividualReference") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:isInstanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is instance of</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#isInstanceOf">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#isInstanceOf</seealso>
    let isInstanceOf = Prefixed_Name(lmm2, "isInstanceOf") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:LSARule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>LSA rule</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#LSARule">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#LSARule</seealso>
    let LSARule = Prefixed_Name(lmm2, "LSARule") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:NamedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An IndividualReference that is denoted by a Name, e.g. 'John_Zorn' (as an Entity).</para>
    /// labels<para>Named entity</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#NamedEntity">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#NamedEntity</seealso>
    let NamedEntity = Prefixed_Name(lmm2, "NamedEntity") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:lexicalizesOE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lexicalization for ontology elements.</para>
    /// labels<para>lexicalizes oE</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#lexicalizesOE">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#lexicalizesOE</seealso>
    let lexicalizesOE = Prefixed_Name(lmm2, "lexicalizesOE") |> PrefixedName

    /// <summary>
    ///   <para>lmm2:SimpleConceptExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A simple ConceptExpression that denotes a ClassReference, e.g. 'the nurses'.</para>
    /// labels<para>Simple concept expression</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#SimpleConceptExpression">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#SimpleConceptExpression</seealso>
    let SimpleConceptExpression =
        Prefixed_Name(lmm2, "SimpleConceptExpression") |> PrefixedName

    /// <summary>
    ///   <para>lmm2:SyntacticRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#SyntacticRule">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#SyntacticRule</seealso>
    let SyntacticRule = Prefixed_Name(lmm2, "SyntacticRule") |> PrefixedName
    /// <summary>
    ///   <para>lmm2:hasInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has instance</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#hasInstance">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#hasInstance</seealso>
    let hasInstance = Prefixed_Name(lmm2, "hasInstance") |> PrefixedName

    /// <summary>
    ///   <para>lmm2:isSyntacticFunctionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is syntactic function of</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#isSyntacticFunctionOf">http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#isSyntacticFunctionOf</seealso>
    let isSyntacticFunctionOf =
        Prefixed_Name(lmm2, "isSyntacticFunctionOf") |> PrefixedName
