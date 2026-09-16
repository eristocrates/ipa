#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pimsii =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.molmod.info/semantics/pims-ii.ttl#" "pimsii"

    /// <summary>
    ///   <para>rdfs:label : AbsoluteLaw</para>
    ///   <para>rdfs:comment : Absolute law, i.e., a law where the necessary entailment of the consequent(s) by the antecedent is expressed in terms of absolute logical/physical necessity^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#AbsoluteLaw">pimsii:AbsoluteLaw</a>
    /// </summary>
    let AbsoluteLaw = _prefixId.prefix "AbsoluteLaw"
    /// <summary>
    ///   <para>rdfs:label : AbsoluteModalIRI</para>
    ///   <para>rdfs:comment : Absolute modal IRI, i.e., the IRI of a relation that is defined by absolute necessity or possibility of another relation. Absolute necessity means 'logical or physical necessity', and absolute possibility means 'logical or physical possibility'. Accordingly, absolute modal relations do not require the specification of a modal context, i.e., the frame of reference for understanding what 'necessity' and 'possibility' mean does not need to be specified. ^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#AbsoluteModalIRI">pimsii:AbsoluteModalIRI</a>
    /// </summary>
    let AbsoluteModalIRI = _prefixId.prefix "AbsoluteModalIRI"
    /// <summary>
    ///   <para>skos:altLabel : AMPC</para>
    ///   <para>rdfs:label : AbstractModelPropertyClaim</para>
    ///   <para>rdfs:comment : Abstract model property claim (CMPC), i.e., a model property claim that is not immediately applied to the corresponding property of a real physical system</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#AbstractModelPropertyClaim">pimsii:AbstractModelPropertyClaim</a>
    /// </summary>
    let AbstractModelPropertyClaim = _prefixId.prefix "AbstractModelPropertyClaim"
    /// <summary>
    ///   <para>rdfs:label : Accumulation</para>
    ///   <para>rdfs:comment : Accumulation, i.e., an information-processing step in which the given information is extended/complemented such that the input (sign) and one or multiple additional representamina (cf. relation isIncludedInAccumulation) are jointly constitutive of the output (interpretant); this includes conditional accumulation, where the choice and the way in which information is combined depends on an accumulation condition (cf. relation isAccumulationConditionIn)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Accumulation">pimsii:Accumulation</a>
    /// </summary>
    let Accumulation = _prefixId.prefix "Accumulation"
    /// <summary>
    ///   <para>rdfs:label : Action</para>
    ///   <para>rdfs:comment : Action, i.e., a process that is conducted/undertaken by an agent - the action has exactly one agent^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Action">pimsii:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:label : Agent</para>
    ///   <para>rdfs:comment : Agent, i.e., an object that interacts with its surroundings by a) perceiving and b) doing, i.e., an object that carries out actions, including perceptive actions</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Agent">pimsii:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>skos:altLabel : AN</para>
    ///   <para>rdfs:label : Articulation</para>
    ///   <para>rdfs:comment : Articulation (collective expression), i.e., a semiotic collective the semiotic members (i.e., realizations) of which are not semiotic collectives, but individual literal (written or digital) or non-literal (e.g., spoken) items with the same semiotic function (or undergoing evaluation whether such a function is present)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Articulation">pimsii:Articulation</a>
    /// </summary>
    let Articulation = _prefixId.prefix "Articulation"
    /// <summary>
    ///   <para>rdfs:label : Assessment</para>
    ///   <para>rdfs:comment : Assessment (of a cognitive step), i.e., a ground that provides an explanation including a proposition on the extent (quantitatively or qualitatively) to which the grounded cognitive step is reliable/accurate/valid (or similar), why that is the case, and how that relates to the reliability/accuracy/etc. of the preceding step^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Assessment">pimsii:Assessment</a>
    /// </summary>
    let Assessment = _prefixId.prefix "Assessment"
    /// <summary>
    ///   <para>skos:altLabel : ASG</para>
    ///   <para>rdfs:label : Assignment</para>
    ///   <para>rdfs:comment : Assignment, i.e., an equality articulation by which a value is assigned to a variable with respect to a particular referent (e.g., T = 200 K for substance o as it was measured in a particular cognitive step); therein, T is the variable, related to the assignment by [inverseOf isVariableInAssignment], 200 K is the value, related to the assignment by [inverseOf isValueInAssignment], and o is the referent, related to the assignment by isAssignmentFor^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Assignment">pimsii:Assignment</a>
    /// </summary>
    let Assignment = _prefixId.prefix "Assignment"
    /// <summary>
    ///   <para>rdfs:label : BasicGround</para>
    ///   <para>rdfs:comment : Basic ground, i.e., a ground that is assumed to be valid and reliable a priori; a cognitive step for which there is a basic ground is a presupposition</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#BasicGround">pimsii:BasicGround</a>
    /// </summary>
    let BasicGround = _prefixId.prefix "BasicGround"
    /// <summary>
    ///   <para>rdfs:label : CanonicalTUCAN</para>
    ///   <para>rdfs:comment : Canonical TUCAN, i.e., the material identifier as developed within the NFDI4Chem project</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#CanonicalTUCAN">pimsii:CanonicalTUCAN</a>
    /// </summary>
    let CanonicalTUCAN = _prefixId.prefix "CanonicalTUCAN"
    /// <summary>
    ///   <para>rdfs:label : Claim</para>
    ///   <para>rdfs:comment : Claim, i.e., a proposition that is expressed by an interlocutor or believed/held by an intelligent agent^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Claim">pimsii:Claim</a>
    /// </summary>
    let Claim = _prefixId.prefix "Claim"
    /// <summary>
    ///   <para>rdfs:label : Cognition</para>
    ///   <para>rdfs:comment : Cognition, i.e., a process dealing with representamina (signs) consisting either of a single cognitive step, of multiple steps that are connected to each other as a cognitive chain, or of an anchor point for epistemic grounding^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Cognition">pimsii:Cognition</a>
    /// </summary>
    let Cognition = _prefixId.prefix "Cognition"
    /// <summary>
    ///   <para>rdfs:label : CognitiveAction</para>
    ///   <para>rdfs:comment : Cognitive action, i.e., a cognition that is conducted/undertaken by an agent; the agent of a cognitive action is called its interpreter^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveAction">pimsii:CognitiveAction</a>
    /// </summary>
    let CognitiveAction = _prefixId.prefix "CognitiveAction"
    /// <summary>
    ///   <para>rdfs:label : CognitiveChain</para>
    ///   <para>rdfs:comment : Cognitive chain, i.e., a cognition that consists of multiple (sub)steps^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveChain">pimsii:CognitiveChain</a>
    /// </summary>
    let CognitiveChain = _prefixId.prefix "CognitiveChain"
    /// <summary>
    ///   <para>rdfs:label : CognitiveRupture</para>
    ///   <para>rdfs:comment : Cognitive rupture, i.e., a cognitive step that constitutes a break in the chain of epistemic grounding^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveRupture">pimsii:CognitiveRupture</a>
    /// </summary>
    let CognitiveRupture = _prefixId.prefix "CognitiveRupture"
    /// <summary>
    ///   <para>rdfs:label : CognitiveStep</para>
    ///   <para>rdfs:comment : Cognitive step, i.e., an elementary cognition that can form an part of a cognitive chain^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveStep">pimsii:CognitiveStep</a>
    /// </summary>
    let CognitiveStep = _prefixId.prefix "CognitiveStep"
    /// <summary>
    ///   <para>rdfs:label : CognitiveWorkflow</para>
    ///   <para>rdfs:comment : Cognitive workflow, i.e., a purposefully conducted cognitive chain^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveWorkflow">pimsii:CognitiveWorkflow</a>
    /// </summary>
    let CognitiveWorkflow = _prefixId.prefix "CognitiveWorkflow"
    /// <summary>
    ///   <para>rdfs:label : Collective</para>
    ///   <para>rdfs:comment : Collective, i.e., an object that has multiple items as members</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Collective">pimsii:Collective</a>
    /// </summary>
    let Collective = _prefixId.prefix "Collective"
    /// <summary>
    ///   <para>rdfs:label : CollectiveLiteral</para>
    ///   <para>rdfs:comment : Collective literal, i.e., a semiotic collective the members of which all have a digital, printed, or written textual/numerical form in that they are all instances/copies of the same RDFS literal (or multiple RDFS literals that are very similar, e.g., different ways of spelling/abbreviating the same word or denoting the same number); n.b., collective literals are not permitted to have other semiotic collectives as their semiotic members^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#CollectiveLiteral">pimsii:CollectiveLiteral</a>
    /// </summary>
    let CollectiveLiteral = _prefixId.prefix "CollectiveLiteral"
    /// <summary>
    ///   <para>rdfs:label : CollectiveUtterance</para>
    ///   <para>rdfs:comment : Collective utterance, i.e., a semiotic collective the members of which do not have digital, printed, or written textual/numerical form and the members of which are all attributed the same semantics and pragmatics; n.b., collective utterances are not permitted to have other semiotic collectives as their semiotic members^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#CollectiveUtterance">pimsii:CollectiveUtterance</a>
    /// </summary>
    let CollectiveUtterance = _prefixId.prefix "CollectiveUtterance"
    /// <summary>
    ///   <para>rdfs:label : Communication</para>
    ///   <para>rdfs:comment : Communication, i.e., a cognitive process wherein multiple interlocutors engage in an exchange with another; a communication involves at least one expressive act (with a well defined role, i.e. in terms of participation)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Communication">pimsii:Communication</a>
    /// </summary>
    let Communication = _prefixId.prefix "Communication"
    /// <summary>
    ///   <para>rdfs:label : ConceptualIRI</para>
    ///   <para>rdfs:comment : Conceptual IRI, i.e., the internationalized resource identifier of a concept (i.e., of an owl:Class)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ConceptualIRI">pimsii:ConceptualIRI</a>
    /// </summary>
    let ConceptualIRI = _prefixId.prefix "ConceptualIRI"
    /// <summary>
    ///   <para>skos:altLabel : CKC</para>
    ///   <para>rdfs:label : ConceptualKnowledgeClaim</para>
    ///   <para>rdfs:comment : Conceptual knowledge claim (CKC), i.e., a knowledge claim establishing the ontological status of a lexeme</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ConceptualKnowledgeClaim">pimsii:ConceptualKnowledgeClaim</a>
    /// </summary>
    let ConceptualKnowledgeClaim = _prefixId.prefix "ConceptualKnowledgeClaim"
    /// <summary>
    ///   <para>skos:altLabel : CMPC</para>
    ///   <para>rdfs:label : ConcretePropertyClaim</para>
    ///   <para>rdfs:comment : Concrete model property claim (CMPC), i.e., a model property claim that is immediately also applied to the corresponding property of a real physical system</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ConcreteModelPropertyClaim">pimsii:ConcreteModelPropertyClaim</a>
    /// </summary>
    let ConcreteModelPropertyClaim = _prefixId.prefix "ConcreteModelPropertyClaim"
    /// <summary>
    ///   <para>rdfs:label : ContextualIRI</para>
    ///   <para>rdfs:comment : Contextual IRI, i.e., the internationalized resource identifier of a modal context, i.e., the frame of reference for a qualified-modal semiotic collective; that context defines how exactly necessity and possibility are to be understood^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ContextualIRI">pimsii:ContextualIRI</a>
    /// </summary>
    let ContextualIRI = _prefixId.prefix "ContextualIRI"
    /// <summary>
    ///   <para>skos:altLabel : CV</para>
    ///   <para>rdfs:label : Conventional</para>
    ///   <para>rdfs:comment : Conventional, i.e., a semiotic collective articulation the members of which jointly fulfill a certain semiotic function by social convention; e.g., many spoken or written occurrences of the words 'enthalpy of vaporization' or 'latent heat' may act together as a property in this sense^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Conventional">pimsii:Conventional</a>
    /// </summary>
    let Conventional = _prefixId.prefix "Conventional"
    /// <summary>
    ///   <para>skos:example : e.g., a key-value dyad with a left-hand side and a right-hand side</para>
    ///   <para>skos:altLabel : DI</para>
    ///   <para>rdfs:label : DataItem</para>
    ///   <para>rdfs:comment : Data item, i.e., a digital articulation given as a tuple of digital conventionals</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#DataItem">pimsii:DataItem</a>
    /// </summary>
    let DataItem = _prefixId.prefix "DataItem"
    /// <summary>
    ///   <para>rdfs:label : Dataset</para>
    ///   <para>rdfs:comment : Dataset, i.e., a digital articulation that is composed of multiple data items that are similar in shape, kind, and content type</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Dataset">pimsii:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>skos:altLabel : DAN</para>
    ///   <para>rdfs:label : DigitalArticulation</para>
    ///   <para>rdfs:comment : Digital articulation, i.e., an articulation the members of which are copies of the same digital content (a file, assignment of a value to a variable, a data set, etc.)</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#DigitalArticulation">pimsii:DigitalArticulation</a>
    /// </summary>
    let DigitalArticulation = _prefixId.prefix "DigitalArticulation"
    /// <summary>
    ///   <para>skos:altLabel : DCV</para>
    ///   <para>rdfs:label : DigitalConventional</para>
    ///   <para>rdfs:comment : Digital conventional, i.e., a conventional that is a digital articulation</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#DigitalConventional">pimsii:DigitalConventional</a>
    /// </summary>
    let DigitalConventional = _prefixId.prefix "DigitalConventional"
    /// <summary>
    ///   <para>rdfs:label : Duplication</para>
    ///   <para>rdfs:comment : Duplication, i.e., an information-processing step in which the given information is reproduced, copied, converted into a different, but equivalent format, or any similar procedure; e.g., this may be based on a legisign to which the original (sign) and the duplicate (interpretant) jointly conform or on a semiotic collective of which they both semiotic members^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Duplication">pimsii:Duplication</a>
    /// </summary>
    let Duplication = _prefixId.prefix "Duplication"
    /// <summary>
    ///   <para>rdfs:label : Dyad</para>
    ///   <para>rdfs:comment : Dyad, i.e., a data item by which two conventionals are grouped together; e.g., an equality or inequality articulation^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Dyad">pimsii:Dyad</a>
    /// </summary>
    let Dyad = _prefixId.prefix "Dyad"
    /// <summary>
    ///   <para>rdfs:label : EPRC</para>
    ///   <para>rdfs:comment : EPRC, i.e., an exact-agreement provenance-conscious reproducibility claim</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#EPRC">pimsii:EPRC</a>
    /// </summary>
    let EPRC = _prefixId.prefix "EPRC"
    /// <summary>
    ///   <para>rdfs:label : EPTRC</para>
    ///   <para>rdfs:comment : EPTRC, i.e., an exact-agreement provenance-conscious team-change reproducibility claim</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#EPTRC">pimsii:EPTRC</a>
    /// </summary>
    let EPTRC = _prefixId.prefix "EPTRC"
    /// <summary>
    ///   <para>rdfs:label : ETRC</para>
    ///   <para>rdfs:comment : ETRC, i.e., an exact-agreement team-change reproducibility claim</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ETRC">pimsii:ETRC</a>
    /// </summary>
    let ETRC = _prefixId.prefix "ETRC"
    /// <summary>
    ///   <para>skos:altLabel : EAN</para>
    ///   <para>rdfs:label : EqualityArticulation</para>
    ///   <para>rdfs:comment : Equality articulation, i.e., a dyad by which two terms are asserted to be equal or to become equal^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#EqualityArticulation">pimsii:EqualityArticulation</a>
    /// </summary>
    let EqualityArticulation = _prefixId.prefix "EqualityArticulation"
    /// <summary>
    ///   <para>rdfs:label : Evaluation</para>
    ///   <para>skos:altLabel : EVA</para>
    ///   <para>rdfs:comment : Evaluation, i.e., a reflection ex post (Reflexion des Vollzugs following Baumann and Tulatz) or redetermination, carried out after an action has terminated, either by the same agent or by somebody else^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Evaluation">pimsii:Evaluation</a>
    /// </summary>
    let Evaluation = _prefixId.prefix "Evaluation"

    /// <summary>
    ///   <para>skos:scopeNote : The criterion for an ERC is that it has no outcome paradata - all the outcome metadata are orthodata</para>
    ///   <para>skos:altLabel : ERC</para>
    ///   <para>rdfs:label : ExactAgreementReproducibilityClaim</para>
    ///   <para>rdfs:comment : Exact-agreement reproducibility claim (ERC), i.e., a reproducibility claim obtained as an outcome of an attempt at obtaining exactly the same outcome as the original study</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ExactAgreementReproducibilityClaim">pimsii:ExactAgreementReproducibilityClaim</a>
    /// </summary>
    let ExactAgreementReproducibilityClaim = _prefixId.prefix "ExactAgreementReproducibilityClaim"

    /// <summary>
    ///   <para>skos:altLabel : EXA</para>
    ///   <para>rdfs:label : Examination</para>
    ///   <para>rdfs:comment : Examination (by pattern matching &amp; similar), i.e., an observation by which a legisign (specifying patterns or rules) is applied to an examined object, yielding an examination outcome that expresses in what way or to what extent the object matches the legisign^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Examination">pimsii:Examination</a>
    /// </summary>
    let Examination = _prefixId.prefix "Examination"
    /// <summary>
    ///   <para>rdfs:label : ExperimentalWorkflow</para>
    ///   <para>rdfs:comment : experimental workflow, i.e., a cognition that is purposefully conducted in a controlled environment and has at least one measurement as a step^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ExperimentalWorkflow">pimsii:ExperimentalWorkflow</a>
    /// </summary>
    let ExperimentalWorkflow = _prefixId.prefix "ExperimentalWorkflow"
    /// <summary>
    ///   <para>rdfs:label : ExpressiveAct</para>
    ///   <para>rdfs:comment : Expressive act, i.e., a purposeful communication (e.g., a speech act or an analogous digital act of communicating) issued by its agent, the speaker (understood in a generalized sense, i.e., not limited to speech) - the purpose of the action consists of its illocutionary and perlocutionary intent^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ExpressiveAct">pimsii:ExpressiveAct</a>
    /// </summary>
    let ExpressiveAct = _prefixId.prefix "ExpressiveAct"
    /// <summary>
    ///   <para>skos:scopeNote : Goal-directedness requires an explicit internal representation of intentions/objectives/goals of the agent; that is what distinguishes it from goal orientation. In PIMS-II, goal orientation is denoted by the relation isGoalOf (which does not require an internal mental representation of the goal), whereas conscious goal directedness is denoted by the relation isGoalFor.</para>
    ///   <para>rdfs:label : GoalDirectedAgent</para>
    ///   <para>rdfs:comment : 'Goal-directed agents are intelligent agents that have an internal representation of the goals they [tend to] achieve' (Conte, doi:10.1007/978-1-4614-1800-9_158, 2009)</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#GoalDirectedAgent">pimsii:GoalDirectedAgent</a>
    /// </summary>
    let GoalDirectedAgent = _prefixId.prefix "GoalDirectedAgent"
    /// <summary>
    ///   <para>skos:scopeNote : A goal of a goal-oriented agent is a descriptor/representamen for that state of the world, and it is also a descriptor/representament for the agent itself. Goal orientation can emerge by a multitude of mechanisms, including natural selection. It does *not* require the agent to be consciously aware of its goals. In PIMS-II, goal orientation is denoted by the relation isGoalOf (which does not require an internal mental representation of the goal), whereas conscious goal directedness is denoted by the relation isGoalFor.</para>
    ///   <para>rdfs:label : GoalOrientedAgent</para>
    ///   <para>rdfs:comment : Goal-oriented agent, i.e., an agent that exhibits the tendency 'to achieve a certain state of the world' (Conte, doi:10.1007/978-1-4614-1800-9_158, 2009)</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#GoalOrientedAgent">pimsii:GoalOrientedAgent</a>
    /// </summary>
    let GoalOrientedAgent = _prefixId.prefix "GoalOrientedAgent"
    /// <summary>
    ///   <para>rdfs:label : Ground</para>
    ///   <para>rdfs:comment : Ground (of a cognitive step), i.e., a proposition that justifies a cognitive step by explaning it and stating from what preceding step (which directly grounds that step) a sign-object relation is carried over, and in what way^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Ground">pimsii:Ground</a>
    /// </summary>
    let Ground = _prefixId.prefix "Ground"
    /// <summary>
    ///   <para>rdfs:label : GroundedCognition</para>
    ///   <para>rdfs:comment : Grounded cognition, i.e., a cognition that is logically preceded by a presupposition such that there is a grounding chain establishing its epistemic status as a grounded cognition^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#GroundedCognition">pimsii:GroundedCognition</a>
    /// </summary>
    let GroundedCognition = _prefixId.prefix "GroundedCognition"
    /// <summary>
    ///   <para>rdfs:label : GroundingChain</para>
    ///   <para>rdfs:comment : Grounding chain, i.e., a cognitive chain that establishes epistemic grounding^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingChain">pimsii:GroundingChain</a>
    /// </summary>
    let GroundingChain = _prefixId.prefix "GroundingChain"
    /// <summary>
    ///   <para>rdfs:label : GroundingInterpretation</para>
    ///   <para>rdfs:comment : Grounding interpretation, i.e., an interpretation where the sign is a ground for the considered cognitive step, the object is the considered cognitive step, and the interpretant is a ground for a subsequent cognitive step^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingInterpretation">pimsii:GroundingInterpretation</a>
    /// </summary>
    let GroundingInterpretation = _prefixId.prefix "GroundingInterpretation"
    /// <summary>
    ///   <para>rdfs:label : GroundingMetonymization</para>
    ///   <para>rdfs:comment : Grounding metonymization, i.e., a metonymization where a the old referent is a cognitive step (i.e., the grounding step) that grounds another (i.e., the grounded step), which is the new referent; the referent for both is a ground (i.e., the grounding proposition) that is a ground for the grounded step^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingMetonymization">pimsii:GroundingMetonymization</a>
    /// </summary>
    let GroundingMetonymization = _prefixId.prefix "GroundingMetonymization"
    /// <summary>
    ///   <para>rdfs:label : GroundingStep</para>
    ///   <para>rdfs:comment : Grounding step, i.e., a triadic cognition that establishes epistemic grounding^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingStep">pimsii:GroundingStep</a>
    /// </summary>
    let GroundingStep = _prefixId.prefix "GroundingStep"
    /// <summary>
    ///   <para>rdfs:label : IRI</para>
    ///   <para>rdfs:comment : Internationalized resource identifier (IRI) as defined by RFC 3987; an IRI object should be related by 'isLiterally' to an xs:string containing the IRI literal^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#IRI">pimsii:IRI</a>
    /// </summary>
    let IRI = _prefixId.prefix "IRI"
    /// <summary>
    ///   <para>rdfs:label : IndividualIRI</para>
    ///   <para>rdfs:comment : Individual IRI, i.e., the internationalized resource identifier of an individual (owl:Thing or pims-ii:Object)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#IndividualIRI">pimsii:IndividualIRI</a>
    /// </summary>
    let IndividualIRI = _prefixId.prefix "IndividualIRI"
    /// <summary>
    ///   <para>rdfs:label : InformationProcessing</para>
    ///   <para>rdfs:comment : Information processing, i.e., an interpretation in which information is handled, revised, reformatted, extended, or narrowed down (or anything comparable to such actions), e.g., preprocessing or postprocessing in a simulation workflow^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#InformationProcessing">pimsii:InformationProcessing</a>
    /// </summary>
    let InformationProcessing = _prefixId.prefix "InformationProcessing"
    /// <summary>
    ///   <para>rdfs:label : IntelligentAgent</para>
    ///   <para>rdfs:comment : Intelligent agent, i.e., a goal-oriented agent that can internally make/hold claims (knowledge, beliefs, etc.). This requires the agent to have some kind of internal representation of its surroundings, and to store and process information about its surroundings. (Note that this does not require the agent to be queryable for its claims; for that purpose, use KnowledgeBase.)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#IntelligentAgent">pimsii:IntelligentAgent</a>
    /// </summary>
    let IntelligentAgent = _prefixId.prefix "IntelligentAgent"
    /// <summary>
    ///   <para>rdfs:label : Intention</para>
    ///   <para>rdfs:comment : Intention, i.e., a proposition that constitutes an aim or goal</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Intention">pimsii:Intention</a>
    /// </summary>
    let Intention = _prefixId.prefix "Intention"
    /// <summary>
    ///   <para>skos:altLabel : IO</para>
    ///   <para>rdfs:label : Interlocutor</para>
    ///   <para>rdfs:comment : Interlocutor, i.e., an agent that can be addressed and is capable of addressing others in a communication process</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Interlocutor">pimsii:Interlocutor</a>
    /// </summary>
    let Interlocutor = _prefixId.prefix "Interlocutor"
    /// <summary>
    ///   <para>skos:altLabel : IPR</para>
    ///   <para>rdfs:label : Interpretation</para>
    ///   <para>rdfs:comment : Interpretation, i.e., a semiosis where the sign-object relation is carried over from the preceding cognitive step, without the need for the represented object to be present physically^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Interpretation">pimsii:Interpretation</a>
    /// </summary>
    let Interpretation = _prefixId.prefix "Interpretation"
    /// <summary>
    ///   <para>rdfs:label : InvestigationSetup</para>
    ///   <para>rdfs:comment : Investigation setup, i.e., a metonymization where a sign (e.g., a model and/or open question) that has come up for an 'object of application' (the old referent, e.g., the system to which a use case refers) is reassigned to an 'object of investigation' to which dedicated studies can be applied, such as a system that will be simulated or investigated experimentally; n.b., there needs to be a causal connection between the old and the new referent, i.e., between the object of application and the object of investigation^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#InvestigationSetup">pimsii:InvestigationSetup</a>
    /// </summary>
    let InvestigationSetup = _prefixId.prefix "InvestigationSetup"
    /// <summary>
    ///   <para>skos:scopeNote : Alternative definition: An item is an object that cannot be split into two spatiotemporally disconnected parts</para>
    ///   <para>rdfs:label : Item</para>
    ///   <para>rdfs:comment : Item, i.e., a connected region of spacetime that does not consist of multiple connected components</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Item">pimsii:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : KnowledgeBase</para>
    ///   <para>rdfs:comment : Knowledge base, i.e., an interlocutor that makes a consistent set of claims and will respond consistently if queried; n.b., that propositional content which 'isHeldBy' a knowledge base needs to be invariable over the whole 4D spacetime in which the knowledge base exist. Since technical knowledge bases do happen to change their propositional content over time, it may make sense either to define proper parts with a short temporal extension or to take care with what a knowledge base is stated to hold. Other kinds of propositional content (varying over time or depending on who makes the query) can be said to be asserted rather than held by the knowledge base.^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeBase">pimsii:KnowledgeBase</a>
    /// </summary>
    let KnowledgeBase = _prefixId.prefix "KnowledgeBase"
    /// <summary>
    ///   <para>rdfs:label : KnowledgeBasedAgent</para>
    ///   <para>rdfs:comment : Knowledge-based agent, i.e., an intelligent agent that uses a knowledge base to store and process its opinions/claims/worldview</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeBasedAgent">pimsii:KnowledgeBasedAgent</a>
    /// </summary>
    let KnowledgeBasedAgent = _prefixId.prefix "KnowledgeBasedAgent"
    /// <summary>
    ///   <para>skos:scopeNote : The subject matter of a knowledge claim must be a (single) question, namely the one that is answered by the claim; in particular, therefore, its subject matter may not be a sum (plurality) of unrelated questions - in such a case, split it up into multiple independent knowledge claimsskos:scopeNote : A knowledge claim states 'what data mean,' i.e., in what way some agent of the academic discourse has given some data an interpretation as constituting knowledge. A knowledge claim asserts what was found from research data: 'Research data δ made agent a know φ,' which can be expanded as 'the interpreation of research data δ by interpreter a yielded the knowledge claim φ as an interpretant.'</para>
    ///   <para>rdfs:label : KnowledgeClaim</para>
    ///   <para>skos:altLabel : KC</para>
    ///   <para>rdfs:comment : Knowledge claim (KC), i.e., a claim about something with respect to its knowledge status</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeClaim">pimsii:KnowledgeClaim</a>
    /// </summary>
    let KnowledgeClaim = _prefixId.prefix "KnowledgeClaim"
    /// <summary>
    ///   <para>rdfs:label : Law</para>
    ///   <para>rdfs:comment : Law, i.e., a proposition consisting of an antecedent and one or multiple consequent(s) such that the antecedent is stated to necessarily imply the consequent(s)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Law">pimsii:Law</a>
    /// </summary>
    let Law = _prefixId.prefix "Law"
    /// <summary>
    ///   <para>rdfs:label : Lexeme</para>
    ///   <para>rdfs:comment : Lexeme, i.e., a semiotic collective the members of which are all instances/utterances/copies of the same word (or a fragment or group of words that fulfills the corresponding function) which acts as a conventional articulation due to social convention; different ways of writing the word, such as an abbreviation and the full version, may belong to the same lexeme^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Lexeme">pimsii:Lexeme</a>
    /// </summary>
    let Lexeme = _prefixId.prefix "Lexeme"
    /// <summary>
    ///   <para>skos:scopeNote : in particular, the TUCAN identifiers from NFDI4Chem can be used^^xsd:string</para>
    ///   <para>rdfs:label : MaterialIdentifier</para>
    ///   <para>rdfs:comment : Name or label that identifies the material of its referent, or the material that some semiotic collective is about</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#MaterialIdentifier">pimsii:MaterialIdentifier</a>
    /// </summary>
    let MaterialIdentifier = _prefixId.prefix "MaterialIdentifier"
    /// <summary>
    ///   <para>rdfs:label : MathematicalOperator</para>
    ///   <para>rdfs:comment : Mathematical operator, i.e., a lexeme that articulates a mathematical operation, such as the collective containing realizations of '*', '·', 'times', etc.^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#MathematicalOperator">pimsii:MathematicalOperator</a>
    /// </summary>
    let MathematicalOperator = _prefixId.prefix "MathematicalOperator"
    /// <summary>
    ///   <para>rdfs:label : Measurement</para>
    ///   <para>rdfs:comment : Measurement, i.e., an observation that follows a standard procedure, so that it can be expected to yield an objective (rather than subjective) outcome^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Measurement">pimsii:Measurement</a>
    /// </summary>
    let Measurement = _prefixId.prefix "Measurement"
    /// <summary>
    ///   <para>rdfs:label : MeasurementUnit</para>
    ///   <para>rdfs:comment : Measurement unit, i.e., a 'real scalar quantity, defined and adopted by convention' (EMMO, ISO 80000-1)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#MeasurementUnit">pimsii:MeasurementUnit</a>
    /// </summary>
    let MeasurementUnit = _prefixId.prefix "MeasurementUnit"
    /// <summary>
    ///   <para>rdfs:label : MereotopologicalCollective</para>
    ///   <para>rdfs:comment : Mereotopological collective, i.e., a region of spacetime that consists of multiple connected components, which are its mereotopological members</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#MereotopologicalCollective">pimsii:MereotopologicalCollective</a>
    /// </summary>
    let MereotopologicalCollective = _prefixId.prefix "MereotopologicalCollective"
    /// <summary>
    ///   <para>rdfs:label : Metonymization</para>
    ///   <para>rdfs:comment : Metonymization, i.e., a semantic change where there is a causal connection between the old and the new referent, so that the criterion of a 'real causal connection' (between signs and objects) from Peircean semiotics is preserved^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Metonymization">pimsii:Metonymization</a>
    /// </summary>
    let Metonymization = _prefixId.prefix "Metonymization"
    /// <summary>
    ///   <para>rdfs:label : ModalIRI</para>
    ///   <para>rdfs:comment : Modal IRI, i.e., the IRI of a relation that is defined by (absolute or qualified) necessity or possibility of another relation^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ModalIRI">pimsii:ModalIRI</a>
    /// </summary>
    let ModalIRI = _prefixId.prefix "ModalIRI"
    /// <summary>
    ///   <para>skos:scopeNote : Claim expressed through a PC: 'From data δ, property p of object o under conditions c was found by agent a to have the value v'</para>
    ///   <para>skos:altLabel : MPC</para>
    ///   <para>rdfs:label : PropertyClaim</para>
    ///   <para>rdfs:comment : Model property claim (MPC), i.e., a PC concerning a property of a model</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ModelPropertyClaim">pimsii:ModelPropertyClaim</a>
    /// </summary>
    let ModelPropertyClaim = _prefixId.prefix "ModelPropertyClaim"
    /// <summary>
    ///   <para>rdfs:label : Modelling</para>
    ///   <para>rdfs:comment : Modelling, i.e., an interpretation in which the sign is the basis for the modelling process (e.g., an unparameterized or previously parameterized model, knowledge about the modelled system, etc.), the object is the modelled system, and the interpretant is the modelling output (e.g., a parameterized model)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Modelling">pimsii:Modelling</a>
    /// </summary>
    let Modelling = _prefixId.prefix "Modelling"
    /// <summary>
    ///   <para>rdfs:label : Name</para>
    ///   <para>rdfs:comment : Name, i.e., a lexeme that acts as a rigid designator due to social convention^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Name">pimsii:Name</a>
    /// </summary>
    let Name = _prefixId.prefix "Name"
    /// <summary>
    ///   <para>skos:altLabel : NKC</para>
    ///   <para>rdfs:label : NegativeKnowledgeClaim</para>
    ///   <para>rdfs:comment : Negative knowledge claim (NKC), i.e., a knowledge claim that expresses what we don't know, a gap or limitation of our knowledge</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#NegativeKnowledgeClaim">pimsii:NegativeKnowledgeClaim</a>
    /// </summary>
    let NegativeKnowledgeClaim = _prefixId.prefix "NegativeKnowledgeClaim"
    /// <summary>
    ///   <para>rdfs:label : Number</para>
    ///   <para>rdfs:comment : Number, i.e., a lexeme that is numerical in nature, such as the collective containing realizations of 'two', '2', and '2.0'^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Number">pimsii:Number</a>
    /// </summary>
    let Number = _prefixId.prefix "Number"
    /// <summary>
    ///   <para>rdfs:comment : Object (PIMS-II top class) = cognizable entity</para>
    ///   <para>rdfs:label : Object</para>
    ///   <para>skos:scopeNote : following Peirce, all that exists is regarded as cognizable, i.e., all in principle be referred to by a sign, hence the label 'Object'</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Object">pimsii:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:label : Observation</para>
    ///   <para>rdfs:comment : Observation, i.e., a perception by which characteristic aspects of an object (e.g., a target property or some more complex kind of behaviour) are purposefully investigated through specific means of perception; the procedure and evaluation may occur based on subjective judgement or according to an agreed procedure^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Observation">pimsii:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    /// <summary>
    ///   <para>rdfs:label : Optimization</para>
    ///   <para>rdfs:comment : Optimization, i.e., an interpretation in which the sign is the optimization problem, the object is that which the optimization problem is ultimately about, and the interpretant is the optimization output^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Optimization">pimsii:Optimization</a>
    /// </summary>
    let Optimization = _prefixId.prefix "Optimization"
    /// <summary>
    ///   <para>rdfs:label : OptimizationProblem</para>
    ///   <para>rdfs:comment : Optimization problem, i.e., an intention expressed or expressible in terms of one or multiple objectives (objective space) and one or multiple design parameters (parameter space)</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#OptimizationProblem">pimsii:OptimizationProblem</a>
    /// </summary>
    let OptimizationProblem = _prefixId.prefix "OptimizationProblem"
    /// <summary>
    ///   <para>skos:scopeNote : Specifically this could be used as a concept to be applied to propositional content of the present knowledge base</para>
    ///   <para>rdfs:label : OwnClaim</para>
    ///   <para>rdfs:comment : Own claim, i.e., a claim that is asserted by a self reference (i.e., a/the present interlocutor)</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#OwnClaim">pimsii:OwnClaim</a>
    /// </summary>
    let OwnClaim = _prefixId.prefix "OwnClaim"
    /// <summary>
    ///   <para>rdfs:label : PTRC</para>
    ///   <para>rdfs:comment : PTRC, i.e., a provenance-conscious team-change reproducibility claim</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#PTRC">pimsii:PTRC</a>
    /// </summary>
    let PTRC = _prefixId.prefix "PTRC"
    /// <summary>
    ///   <para>rdfs:label : PartToWhole</para>
    ///   <para>rdfs:comment : Part-to-whole synecdoche, i.e., a metonymization where the old referent is a spatiotemporal proper part of the new referent (additionally, the old and new referent need to be connected causally)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#PartToWhole">pimsii:PartToWhole</a>
    /// </summary>
    let PartToWhole = _prefixId.prefix "PartToWhole"
    /// <summary>
    ///   <para>skos:scopeNote : the perception is conducted by an agent, namely, the interpreter who perceives the object</para>
    ///   <para>skos:altLabel : PCN</para>
    ///   <para>rdfs:label : Perception</para>
    ///   <para>rdfs:comment : Perception, i.e., a semiosis in which the referent is a participant (as a perceived object) and therefore needs to be physically present</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Perception">pimsii:Perception</a>
    /// </summary>
    let Perception = _prefixId.prefix "Perception"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <para>rdfs:comment : Person, i.e., an interlocutor that is socially identified as a natural or legal person by social convention that involves using a name (or multiple names) for it as rigid designators^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Person">pimsii:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>skos:scopeNote : Claim expressed through a PC: 'From data δ, property p of object o under conditions c was found by agent a to have the value v'</para>
    ///   <para>skos:altLabel : PPC</para>
    ///   <para>rdfs:label : PropertyClaim</para>
    ///   <para>rdfs:comment : Physical property claim (PPC), i.e., a PC concerning a property of a physical system</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#PhysicalPropertyClaim">pimsii:PhysicalPropertyClaim</a>
    /// </summary>
    let PhysicalPropertyClaim = _prefixId.prefix "PhysicalPropertyClaim"
    /// <summary>
    ///   <para>rdfs:label : Planning</para>
    ///   <para>rdfs:comment : Planning, i.e., a reflection ex ante or predetermination, carried out by analysing the perceived present situation in advance of potentially undertaking an action^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Planning">pimsii:Planning</a>
    /// </summary>
    let Planning = _prefixId.prefix "Planning"
    /// <summary>
    ///   <para>skos:altLabel : PL</para>
    ///   <para>rdfs:label : Plurality</para>
    ///   <para>rdfs:comment : Plurality, i.e., a semiotic collective the semiotic members of which are a representational element (referent or representamen) together, whereby all act/contribute in the same way - this latter point distinguishes a plurality from a structure; e.g., the referent of the expression 'the four seasons/quarters of the year' (for a given year, within a given spatial region) is a plurality, and each of the four seasons/quarters is one of its semiotic members^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Plurality">pimsii:Plurality</a>
    /// </summary>
    let Plurality = _prefixId.prefix "Plurality"
    /// <summary>
    ///   <para>rdfs:label : Presupposition</para>
    ///   <para>rdfs:comment : Presupposition, i.e., a cognition that has a basic ground, so that it is accepted a priori as an ultimate anchor point for epistemic grounding; any cognition that is logically preceded by a presupposition is a grounded cognition^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Presupposition">pimsii:Presupposition</a>
    /// </summary>
    let Presupposition = _prefixId.prefix "Presupposition"
    /// <summary>
    ///   <para>skos:scopeNote : n.b., 'participation' here does not imply agency, anything that somehow plays a role in the process, and does so by virtue of overlapping with it spatiotemporally, is a participant in it</para>
    ///   <para>rdfs:label : Process</para>
    ///   <para>rdfs:comment : Process, i.e., a connected region that has at least one participant, an entity with which it overlaps spatiotemporally and that plays a certain role in the process</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Process">pimsii:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>skos:altLabel : PVC</para>
    ///   <para>rdfs:label : ProofBasedValidityClaim</para>
    ///   <para>rdfs:comment : Proof-based validity claim (PVC), i.e., a validity claim obtained by formal verification, i.e., by deductive logical and mathematical reasoning</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ProofBasedValidityClaim">pimsii:ProofBasedValidityClaim</a>
    /// </summary>
    let ProofBasedValidityClaim = _prefixId.prefix "ProofBasedValidityClaim"
    /// <summary>
    ///   <para>rdfs:label : Property</para>
    ///   <para>rdfs:comment : Property, i.e., a variable that is employed for the possible outcome of observations and similar processes (this may include different words used for the same property, in one or multiple languages, and different ways of expressing these words)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Property">pimsii:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>skos:scopeNote : Claim expressed through a PC: 'From data δ, property p of object o under conditions c was found by agent a to have the value v'</para>
    ///   <para>skos:altLabel : PC</para>
    ///   <para>rdfs:label : PropertyClaim</para>
    ///   <para>rdfs:comment : Property claim (PC), i.e., a knowledge claim concerning a property</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#PropertyClaim">pimsii:PropertyClaim</a>
    /// </summary>
    let PropertyClaim = _prefixId.prefix "PropertyClaim"
    /// <summary>
    ///   <para>rdfs:label : Proposition</para>
    ///   <para>rdfs:comment : Proposition, i.e., a semiotic collective the members of which are collective literals and collective utterances understood to be attributed some joint semantic and/or pragmatic content, or undergoing evaluation jointly for the presence of such a content</para>
    ///   <para>skos:scopeNote : Note that this here includes any kind of semiotic collective that fits the given definition; the semantic/pragmatic content may be assertive, but also interrogative or of any other character - in particular, by this definition, 'Question' is a subclass of 'Proposition'</para>
    ///   <para>skos:altLabel : PN</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Proposition">pimsii:Proposition</a>
    /// </summary>
    let Proposition = _prefixId.prefix "Proposition"

    /// <summary>
    ///   <para>skos:scopeNote : The criterion for a PRC is that there are provenance orthodata, not only provenance paradata</para>
    ///   <para>skos:altLabel : PRC</para>
    ///   <para>rdfs:label : ProvenanceConsciousReproducibilityClaim</para>
    ///   <para>rdfs:comment : Provenance-conscious reproducibility claim (PRC), i.e., a reproducibility claim obtained from an attempt that was subject to the requirement to retain the original research process or aspects of it</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ProvenanceConsciousReproducibilityClaim">pimsii:ProvenanceConsciousReproducibilityClaim</a>
    /// </summary>
    let ProvenanceConsciousReproducibilityClaim = _prefixId.prefix "ProvenanceConsciousReproducibilityClaim"

    /// <summary>
    ///   <para>rdfs:label : PurposefulAction</para>
    ///   <para>rdfs:comment : Purposeful action, i.e., an action carried out with an aim of which its agent (hence, a goal-directed agent) is aware</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#PurposefulAction">pimsii:PurposefulAction</a>
    /// </summary>
    let PurposefulAction = _prefixId.prefix "PurposefulAction"
    /// <summary>
    ///   <para>skos:altLabel : QL</para>
    ///   <para>rdfs:label : QualifiedLaw</para>
    ///   <para>rdfs:comment : Qualified law, i.e., a law where the necessary entailment of the consequent(s) by the antecedent is expressed in terms of qualified necessity, to be understood in terms of its modal context^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#QualifiedLaw">pimsii:QualifiedLaw</a>
    /// </summary>
    let QualifiedLaw = _prefixId.prefix "QualifiedLaw"
    /// <summary>
    ///   <para>skos:scopeNote : Qualified modal relations require the specification of a modal context, i.e., a frame of reference for understanding what 'necessity' and 'possibility' exactly mean.</para>
    ///   <para>rdfs:label : QualifiedModalIRI</para>
    ///   <para>rdfs:comment : Qualified modal IRI, i.e., the IRI of a relation that is defined by qualified necessity or possibility of another relation</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#QualifiedModalIRI">pimsii:QualifiedModalIRI</a>
    /// </summary>
    let QualifiedModalIRI = _prefixId.prefix "QualifiedModalIRI"
    /// <summary>
    ///   <para>rdfs:label : QuantityValue</para>
    ///   <para>rdfs:comment : Quantity value, i.e., a value that has a numerical magnitude and a physical unit</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#QuantityValue">pimsii:QuantityValue</a>
    /// </summary>
    let QuantityValue = _prefixId.prefix "QuantityValue"
    /// <summary>
    ///   <para>rdfs:label : Query</para>
    ///   <para>rdfs:comment : Query, i.e., a digital articulation of a question</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Query">pimsii:Query</a>
    /// </summary>
    let Query = _prefixId.prefix "Query"
    /// <summary>
    ///   <para>skos:scopeNote : A question contains interrogative pronouns or other interrogative elements, such as blank nodes when articulated as a queryskos:scopeNote : Questions are articulated digitally by queries</para>
    ///   <para>skos:altLabel : QN</para>
    ///   <para>rdfs:label : Question</para>
    ///   <para>rdfs:comment : Question, i.e., a topical proposition the semantics/pragmatics of which are of interrogative character</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Question">pimsii:Question</a>
    /// </summary>
    let Question = _prefixId.prefix "Question"
    /// <summary>
    ///   <para>skos:scopeNote : Similar as in the case of goal-orientation, rationality does *not* require the agent to be aware of its performance measure.</para>
    ///   <para>rdfs:label : RationalAgent</para>
    ///   <para>rdfs:comment : A rational agent is an intelligent agent that exhibits rationality, i.e., a tendency toward maximizing a quantity: The performance measure of the agent.</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#RationalAgent">pimsii:RationalAgent</a>
    /// </summary>
    let RationalAgent = _prefixId.prefix "RationalAgent"
    /// <summary>
    ///   <para>skos:scopeNote : This is relevant for distinguishing anybody's claims from the present system's own claims: If and only if a proposition is asserted by a self-reference, it is an own claim</para>
    ///   <para>skos:example : If the present triples are processed by a research data infrastructure with a federated architecture, consisting of several repositories (which are interlocutors, i.e., they can be queried and communicate with the outside world), both the research data infrastructure as a whole and the individual repositories are self-references</para>
    ///   <para>rdfs:label : ReferenceToSelf</para>
    ///   <para>rdfs:comment : Reference to self, i.e., an entity for the interlocutor who *is* the present system, i.e., the system containing the present triples, etc., and whose claims are to be accepted as the present system's 'own claims.' A self-reference is an entity that is either identical with the system at hand, namely, the digital infrastructure or other interlocutor that stores the present semantic content, or a component of it</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ReferenceToSelf">pimsii:ReferenceToSelf</a>
    /// </summary>
    let ReferenceToSelf = _prefixId.prefix "ReferenceToSelf"
    /// <summary>
    ///   <para>rdfs:label : RelationalIRI</para>
    ///   <para>rdfs:comment : Relational IRI, i.e., the internationalized resource identifier of a something that can play the role of the predicate in a triple; this includes 'rdf:type', object properties, datatype properties, their negations^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#RelationalIRI">pimsii:RelationalIRI</a>
    /// </summary>
    let RelationalIRI = _prefixId.prefix "RelationalIRI"
    /// <summary>
    ///   <para>skos:altLabel : RC</para>
    ///   <para>rdfs:label : ReproducibilityClaim</para>
    ///   <para>rdfs:comment : Reproducibility claim (RC), i.e., a validity claim obtained as an outcome of a reproduction attempt/reproducibility study</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ReproducibilityClaim">pimsii:ReproducibilityClaim</a>
    /// </summary>
    let ReproducibilityClaim = _prefixId.prefix "ReproducibilityClaim"
    /// <summary>
    ///   <para>skos:altLabel : RQN</para>
    ///   <para>rdfs:label : ResearchQuestion</para>
    ///   <para>rdfs:comment : Research question, i.e., a question that could, has been, or is being addressed by scientific research and e.g. could be answered by a knowledge claim formulated on the grounds of scientific research data</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ResearchQuestion">pimsii:ResearchQuestion</a>
    /// </summary>
    let ResearchQuestion = _prefixId.prefix "ResearchQuestion"
    /// <summary>
    ///   <para>rdfs:label : Rule</para>
    ///   <para>rdfs:comment : Rule, i.e., a proposition consisting of an antecedent and one or multiple consequent(s) such that the antecedent is stated to imply the consequent(s)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Rule">pimsii:Rule</a>
    /// </summary>
    let Rule = _prefixId.prefix "Rule"
    /// <summary>
    ///   <para>rdfs:label : Selection</para>
    ///   <para>rdfs:comment : Selection, i.e., an information-processing step in which the given information is narrowed down such that the output (interpretant) is constitutive of the input (sign); this includes conditional selection, where one component of the input or another is retained depending on a selection condition (cf. relation isSelectionConditionIn)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Selection">pimsii:Selection</a>
    /// </summary>
    let Selection = _prefixId.prefix "Selection"
    /// <summary>
    ///   <para>rdfs:label : SemanticChange</para>
    ///   <para>rdfs:comment : Semantic change, i.e., a triadic cognition by which a representamen is assigned a new referent^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#SemanticChange">pimsii:SemanticChange</a>
    /// </summary>
    let SemanticChange = _prefixId.prefix "SemanticChange"
    /// <summary>
    ///   <para>rdfs:label : Semiosis</para>
    ///   <para>rdfs:comment : Semiosis, i.e., a triadic congition that relates 'the sign', 'the object', and 'the interpretant' to each other; a semiosis is either a perception (if the object needs to be present and participate physically in the process) or an interpretation (if the physical participation of the object is not inherently necessary)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Semiosis">pimsii:Semiosis</a>
    /// </summary>
    let Semiosis = _prefixId.prefix "Semiosis"
    /// <summary>
    ///   <para>skos:altLabel : SCO</para>
    ///   <para>rdfs:label : SemioticCollective</para>
    ///   <para>rdfs:comment : Semiotic collective, i.e., a collective the semiotic members of which act together as one representational element (i.e., referent or representamen) in a cognitive process^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#SemioticCollective">pimsii:SemioticCollective</a>
    /// </summary>
    let SemioticCollective = _prefixId.prefix "SemioticCollective"
    /// <summary>
    ///   <para>rdfs:label : Simulation</para>
    ///   <para>rdfs:comment : Simulation, i.e., a purposefully conducted numerical interpretation of simulation input (model, etc.), where the interpretant is the simulation result^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Simulation">pimsii:Simulation</a>
    /// </summary>
    let Simulation = _prefixId.prefix "Simulation"
    /// <summary>
    ///   <para>rdfs:label : SimulationWorkflow</para>
    ///   <para>rdfs:comment : simulation workflow, i.e., a cognitive workflow in which simulation plays a major role^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#SimulationWorkflow">pimsii:SimulationWorkflow</a>
    /// </summary>
    let SimulationWorkflow = _prefixId.prefix "SimulationWorkflow"
    /// <summary>
    ///   <para>rdfs:label : Steering</para>
    ///   <para>rdfs:comment : Steering, i.e., a reflection in actu (Reflexion im Vollzug following Baumann and Tulatz) or determination, carried out while undertaking an action and playing a role in that action by proper participation^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Steering">pimsii:Steering</a>
    /// </summary>
    let Steering = _prefixId.prefix "Steering"
    /// <summary>
    ///   <para>rdfs:label : Structure</para>
    ///   <para>rdfs:comment : Structure, i.e., a semiotic collective the semiotic members of which complement each other, contributing in different ways (or, at least, not all int the same way) to their joint action as a referent or a representamen^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Structure">pimsii:Structure</a>
    /// </summary>
    let Structure = _prefixId.prefix "Structure"
    /// <summary>
    ///   <para>rdfs:label : Synecdoche</para>
    ///   <para>rdfs:comment : Synecdoche, i.e., a metonymization where a sign is reassigned to a part of its old referent (WholeToPart) or vice versa (PartToWhole)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Synecdoche">pimsii:Synecdoche</a>
    /// </summary>
    let Synecdoche = _prefixId.prefix "Synecdoche"

    /// <summary>
    ///   <para>skos:scopeNote : Criterion: Interpreter(s) disjoint with the interpreter(s) from the original research process</para>
    ///   <para>skos:altLabel : TRC</para>
    ///   <para>rdfs:label : TeamChangeReproducibilityClaim</para>
    ///   <para>rdfs:comment : Team-change reproducibility claim (TRC), i.e., a reproducibility claim obtained as an outcome of a reproducibility study conducted by an independent team</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#TeamChangeReproducibilityClaim">pimsii:TeamChangeReproducibilityClaim</a>
    /// </summary>
    let TeamChangeReproducibilityClaim = _prefixId.prefix "TeamChangeReproducibilityClaim"

    /// <summary>
    ///   <para>rdfs:label : Telesis</para>
    ///   <para>rdfs:comment : Telesis (teleological semiosis), i.e., a semiosis where the sign is a telos (aim), the object is an action, claim, or situation against which that aim is evaluated, and the interpretant is a resolution, e.g., a revised objective, plan, or similar evaluation outcome^^xsd:string</para>
    ///   <para>skos:altLabel : TEL</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Telesis">pimsii:Telesis</a>
    /// </summary>
    let Telesis = _prefixId.prefix "Telesis"
    /// <summary>
    ///   <para>rdfs:label : Term</para>
    ///   <para>rdfs:comment : Term, i.e., a conventional that can evaluate to a value; terms include variables, values, and any mathematically and semantically valid ways of combining variables, values, and mathematical operators - note that it is required for a term to potentially take a value^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Term">pimsii:Term</a>
    /// </summary>
    let Term = _prefixId.prefix "Term"
    /// <summary>
    ///   <para>skos:scopeNote : Validation and testing are an integral part of the activity by which the validated knowledge claim and/or the associated data are produced, as opposed to reproducibility studies which are done subsequently in a separate activity</para>
    ///   <para>skos:altLabel : TVC</para>
    ///   <para>rdfs:label : TestBasedValidityClaim</para>
    ///   <para>rdfs:comment : Test-based validity claim (TVC), i.e., a validity claim obtained from validation or testing</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#TestBasedValidityClaim">pimsii:TestBasedValidityClaim</a>
    /// </summary>
    let TestBasedValidityClaim = _prefixId.prefix "TestBasedValidityClaim"
    /// <summary>
    ///   <para>skos:scopeNote : In particular, all questions are topical propositions, since they state the topic of their potential answerskos:scopeNote : A topic can be a product of (sub-)topics, that is the case if two aspects of something are being addressed jointly, with a genuine interaction between multiple factors; in this case, the whole topic is a topical product (subclass of topical), and its factors are related to it by pims-ii:isTopicalFactorIn. But something can also address multiple contributions to its subject matter independently, without a genuine interaction between the parts; in that case, the whole topic is a topical sum (disjoint with topical), its parts are topicals, and they are related to the whole by pims-ii:isTopicalSummandIn</para>
    ///   <para>skos:altLabel : TL</para>
    ///   <para>rdfs:label : Topical</para>
    ///   <para>rdfs:comment : Topical proposition, i.e., something that can be understood as stating the topic of something</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Topical">pimsii:Topical</a>
    /// </summary>
    let Topical = _prefixId.prefix "Topical"
    /// <summary>
    ///   <para>rdfs:label : TopicalProduct</para>
    ///   <para>rdfs:comment : Topical product, i.e., a topical proposition with multiple topical factors</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#TopicalProduct">pimsii:TopicalProduct</a>
    /// </summary>
    let TopicalProduct = _prefixId.prefix "TopicalProduct"
    /// <summary>
    ///   <para>skos:altLabel : TLS</para>
    ///   <para>rdfs:label : TopicalSum</para>
    ///   <para>rdfs:comment : Topical sum, i.e., a plurality of topical propositions, where the individual elements (summands) don't genuinely interact but are just standing beside each other as independent, unrelated (or not very closely related) parts of what is addressed</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#TopicalSum">pimsii:TopicalSum</a>
    /// </summary>
    let TopicalSum = _prefixId.prefix "TopicalSum"
    /// <summary>
    ///   <para>rdfs:label : TriadicCognition</para>
    ///   <para>rdfs:comment : Triadic cognition, i.e., a cognitive step of the type s-o-s' (semiosis) or o-s-o' (semantic change), thus containing three elements, in line with the approach by Peirce^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#TriadicCognition">pimsii:TriadicCognition</a>
    /// </summary>
    let TriadicCognition = _prefixId.prefix "TriadicCognition"
    /// <summary>
    ///   <para>rdfs:label : Triple</para>
    ///   <para>rdfs:comment : Triple, i.e., a subject-predicate-object triple (connected by relations to the IRIs of the subject, predicate, and object)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Triple">pimsii:Triple</a>
    /// </summary>
    let Triple = _prefixId.prefix "Triple"
    /// <summary>
    ///   <para>rdfs:label : Undertaking</para>
    ///   <para>rdfs:comment : Undertaking, i.e., a metonymization by which a resolution, which was previously determined (by telesis) in response to the pre-existing situation, is actively taken up by the agent, motivating an action^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Undertaking">pimsii:Undertaking</a>
    /// </summary>
    let Undertaking = _prefixId.prefix "Undertaking"
    /// <summary>
    ///   <para>rdfs:label : UniqueIdentifier</para>
    ///   <para>rdfs:comment : Unique identifier, i.e., a rigid designator that is applied to exactly one object^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#UniqueIdentifier">pimsii:UniqueIdentifier</a>
    /// </summary>
    let UniqueIdentifier = _prefixId.prefix "UniqueIdentifier"
    /// <summary>
    ///   <para>skos:altLabel : VAL</para>
    ///   <para>rdfs:label : Validation</para>
    ///   <para>rdfs:comment : Validation, i.e., an evaluation of a cognition yielding a validity claim as its interpretant</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Validation">pimsii:Validation</a>
    /// </summary>
    let Validation = _prefixId.prefix "Validation"
    /// <summary>
    ///   <para>skos:altLabel : VC</para>
    ///   <para>rdfs:label : ValidityClaim</para>
    ///   <para>rdfs:comment : Validity claim (VC), i.e., a claim about another claim, saying something about that claim's (in-)accuracy or somebody's (dis-)trust in the claim</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#ValidityClaim">pimsii:ValidityClaim</a>
    /// </summary>
    let ValidityClaim = _prefixId.prefix "ValidityClaim"
    /// <summary>
    ///   <para>rdfs:label : Value</para>
    ///   <para>rdfs:comment : Value, i.e., an articulation that is by social convention understood to be potentially assignable to a variable^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Value">pimsii:Value</a>
    /// </summary>
    let Value = _prefixId.prefix "Value"
    /// <summary>
    ///   <para>rdfs:label : Variable</para>
    ///   <para>rdfs:comment : Variable, i.e., a conventional that is employed for something to which values can be assigned (this may include different notations for the same variable including, e.g., computational representations); this is to be understood very generally, e.g., a variable may be an array or set of elements or have another kind of internal structure^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Variable">pimsii:Variable</a>
    /// </summary>
    let Variable = _prefixId.prefix "Variable"
    /// <summary>
    ///   <para>rdfs:label : Visualization</para>
    ///   <para>rdfs:comment : Visualization, i.e., an interpretation in which the object is the visualized system and the interpretant is a visual representation of the object - the sign is a pre-existing representamen for the same object, e.g., a simulation result^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#Visualization">pimsii:Visualization</a>
    /// </summary>
    let Visualization = _prefixId.prefix "Visualization"
    /// <summary>
    ///   <para>rdfs:label : WholeToPart</para>
    ///   <para>rdfs:comment : Whole-to-part synecdoche, i.e., a metonymization where the new referent is a spatiotemporal proper part of the old referent (additionally, the old and new referent need to be connected causally)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#WholeToPart">pimsii:WholeToPart</a>
    /// </summary>
    let WholeToPart = _prefixId.prefix "WholeToPart"
    /// <summary>
    ///   <para>skos:altLabel : \hat{A}_\kappa</para>
    ///   <para>rdfs:label : affirmsCognition</para>
    ///   <para>rdfs:comment : (x affirmsCognition y) means that x is about the cognition y, affirming its validity</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#affirmsCognition">pimsii:affirmsCognition</a>
    /// </summary>
    let affirmsCognition = _prefixId.prefix "affirmsCognition"
    /// <summary>
    ///   <para>skos:altLabel : \lhd_a</para>
    ///   <para>rdfs:label : articulates</para>
    ///   <para>rdfs:comment : (x articulates y) means that x is a semiotic member of the proposition y, giving a literal or non-literal (e.g., spoken) expression to its propositional content; n.b., x may also express other propositions beside y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#articulates">pimsii:articulates</a>
    /// </summary>
    let articulates = _prefixId.prefix "articulates"
    /// <summary>
    ///   <para>rdfs:label : articulatesLiterally</para>
    ///   <para>rdfs:comment : (x articulatesLiterally y) means that x is a collective literal expressing the proposition y, and possibly additional propositions beside y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#articulatesLiterally">pimsii:articulatesLiterally</a>
    /// </summary>
    let articulatesLiterally = _prefixId.prefix "articulatesLiterally"
    /// <summary>
    ///   <para>rdfs:label : articulatesNonliterally</para>
    ///   <para>rdfs:comment : (x articulatesNonliterally y) means that x is a collective non-literal expression (e.g., an utterance) of proposition y, and possibly additional propositions beside y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#articulatesNonliterally">pimsii:articulatesNonliterally</a>
    /// </summary>
    let articulatesNonliterally = _prefixId.prefix "articulatesNonliterally"
    /// <summary>
    ///   <para>rdfs:label : changesReferentIn</para>
    ///   <para>rdfs:comment : (x changesReferentIn y) == y is a semantic change where x acts as the representamen, i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentIn">pimsii:changesReferentIn</a>
    /// </summary>
    let changesReferentIn = _prefixId.prefix "changesReferentIn"

    /// <summary>
    ///   <para>rdfs:label : changesReferentInMetonymization</para>
    ///   <para>rdfs:comment : (x changesReferentInMetonymization y) == y is a metonymization where x acts as the representamen, i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInMetonymization">pimsii:changesReferentInMetonymization</a>
    /// </summary>
    let changesReferentInMetonymization = _prefixId.prefix "changesReferentInMetonymization"

    /// <summary>
    ///   <para>rdfs:label : changesReferentInPartToWhole</para>
    ///   <para>rdfs:comment : (x changesReferentInPartToWhole y) == y is a part-to-whole synecdoche where x acts as the representamen, i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInPartToWhole">pimsii:changesReferentInPartToWhole</a>
    /// </summary>
    let changesReferentInPartToWhole = _prefixId.prefix "changesReferentInPartToWhole"
    /// <summary>
    ///   <para>rdfs:label : changesReferentInSynecdoche</para>
    ///   <para>rdfs:comment : (x changesReferentInSynecdoche y) == y is a synecdoche where x acts as the representamen, i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInSynecdoche">pimsii:changesReferentInSynecdoche</a>
    /// </summary>
    let changesReferentInSynecdoche = _prefixId.prefix "changesReferentInSynecdoche"
    /// <summary>
    ///   <para>rdfs:label : changesReferentInWholeToPart</para>
    ///   <para>rdfs:comment : (x changesReferentInWholeToPart y) == y is a whole-to-part synecdoche where x acts as the representamen, i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInWholeToPart">pimsii:changesReferentInWholeToPart</a>
    /// </summary>
    let changesReferentInWholeToPart = _prefixId.prefix "changesReferentInWholeToPart"
    /// <summary>
    ///   <para>skos:altLabel : \v{R}</para>
    ///   <para>rdfs:label : describesMethodAppliedIn</para>
    ///   <para>rdfs:comment : (x describesMethodAppliedIn y) means that x describes y in terms of the method that is employed</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#describesMethodAppliedIn">pimsii:describesMethodAppliedIn</a>
    /// </summary>
    let describesMethodAppliedIn = _prefixId.prefix "describesMethodAppliedIn"
    /// <summary>
    ///   <para>rdfs:label : describesMethodEmployedBy</para>
    ///   <para>rdfs:comment : (x describesMethodEmployedBy y) means that the agent y follows a methodology described by x in carrying out an action</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#describesMethodEmployedBy">pimsii:describesMethodEmployedBy</a>
    /// </summary>
    let describesMethodEmployedBy = _prefixId.prefix "describesMethodEmployedBy"
    /// <summary>
    ///   <para>skos:altLabel : \hookrightarrow</para>
    ///   <para>rdfs:label : directlyGrounds</para>
    ///   <para>rdfs:comment : (x directlyGrounds y) == x is the cognitive step (or basic ground) that directly precedes y logically, such that a dyadic representation relation from y is taken over from x (or assumed to be grounded a priori due to x)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#directlyGrounds">pimsii:directlyGrounds</a>
    /// </summary>
    let directlyGrounds = _prefixId.prefix "directlyGrounds"
    /// <summary>
    ///   <para>rdfs:label : directlyPrecedesByRupture</para>
    ///   <para>rdfs:comment : (x directlyPrecedesByRupture y) == x is the cognitive step that directly precedes y logically (and typically, y takes over a dyadic representation relation from x), but either x or y constitutes a cognitive rupture, i.e., it interrupts the chain of grounding^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesByRupture">pimsii:directlyPrecedesByRupture</a>
    /// </summary>
    let directlyPrecedesByRupture = _prefixId.prefix "directlyPrecedesByRupture"
    /// <summary>
    ///   <para>rdfs:label : directlyPrecedesCognitiveStep</para>
    ///   <para>rdfs:comment : (x directlyPrecedesCognitiveStep y) == x is the cognitive step (or basic ground) that directly precedes y logically; typically, this means that y takes over a dyadic representation relation from x^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesCognitiveStep">pimsii:directlyPrecedesCognitiveStep</a>
    /// </summary>
    let directlyPrecedesCognitiveStep = _prefixId.prefix "directlyPrecedesCognitiveStep"
    /// <summary>
    ///   <para>skos:scopeNote : (x directlyPrecedesStep y) implies that there is a direct causal connection between x and y</para>
    ///   <para>skos:altLabel : \ddot\hookrightarrow</para>
    ///   <para>rdfs:label : directlyPrecedesStep</para>
    ///   <para>rdfs:comment : (x directlyPrecedesStep y) means that x and y are processes such that y can commence when x (and possibly other steps that also directly precede y) has finished</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesStep">pimsii:directlyPrecedesStep</a>
    /// </summary>
    let directlyPrecedesStep = _prefixId.prefix "directlyPrecedesStep"
    /// <summary>
    ///   <para>skos:altLabel : \lnot(\dot{P}^-\dot{P})</para>
    ///   <para>rdfs:label : doesNotOverlapWith</para>
    ///   <para>rdfs:comment : (x doesNotOverlapWith y) is the negation of (x overlapsWith y); i.e., the spatiotemporal intersection of x and y is empty</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#doesNotOverlapWith">pimsii:doesNotOverlapWith</a>
    /// </summary>
    let doesNotOverlapWith = _prefixId.prefix "doesNotOverlapWith"
    /// <summary>
    ///   <para>skos:altLabel : \lnot(\equiv_t\dot{P}^-\dot{P})</para>
    ///   <para>rdfs:label : doesNotTemporallyOverlapWith</para>
    ///   <para>rdfs:comment : (x doesNotTemporallyOverlapWith y) is the negation of (x temporallyOverlapsWith y); i.e., there is no temporal overlap between x and y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#doesNotTemporallyOverlapWith">pimsii:doesNotTemporallyOverlapWith</a>
    /// </summary>
    let doesNotTemporallyOverlapWith = _prefixId.prefix "doesNotTemporallyOverlapWith"
    /// <summary>
    ///   <para>rdfs:label : groundsNextStepIn</para>
    ///   <para>rdfs:comment : (x groundsNextStepIn y) == y is a grounding interpretation where x is the third element, i.e., a ground for the subsequent cognitive step; thereby, x also serves as a ground for y itself^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#groundsNextStepIn">pimsii:groundsNextStepIn</a>
    /// </summary>
    let groundsNextStepIn = _prefixId.prefix "groundsNextStepIn"
    /// <summary>
    ///   <para>rdfs:label : groundsPresentStepIn</para>
    ///   <para>rdfs:comment : (x groundsPresentStepIn y) == y is a grounding interpretation where x is the first element, i.e., a ground for the considered cognitive step^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#groundsPresentStepIn">pimsii:groundsPresentStepIn</a>
    /// </summary>
    let groundsPresentStepIn = _prefixId.prefix "groundsPresentStepIn"
    /// <summary>
    ///   <para>rdfs:label : hasAbsoluteNecessityMode</para>
    ///   <para>rdfs:comment : (x hasAbsoluteNecessityMode y) means that x is a relational IRI and y is an absolute modal IRI for 'necessarily x'</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#hasAbsoluteNecessityMode">pimsii:hasAbsoluteNecessityMode</a>
    /// </summary>
    let hasAbsoluteNecessityMode = _prefixId.prefix "hasAbsoluteNecessityMode"
    /// <summary>
    ///   <para>rdfs:label : hasAbsolutePossibilityMode</para>
    ///   <para>rdfs:comment : (x hasAbsolutePossibilityMode y) means that x is a relational IRI and y is an absolute modal IRI for 'possibly x'</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#hasAbsolutePossibilityMode">pimsii:hasAbsolutePossibilityMode</a>
    /// </summary>
    let hasAbsolutePossibilityMode = _prefixId.prefix "hasAbsolutePossibilityMode"
    /// <summary>
    ///   <para>rdfs:comment : 'Real causal connection' relation following Peirce, here, given by the transitive closure of 'hasDirectCausalConnectionWith'</para>
    ///   <para>skos:scopeNote : this is to be understood broadly, as in Peirce, and can be a very indirect connection; here, this is relevant as follows: a) in a grounded cognition, there are only dyadic representation relations between representamina and their referents that have a real causal connection with each other; b) in a metonymization, there must be a real causal connection between the old and the new referent</para>
    ///   <para>skos:altLabel : \dot{C}^\star</para>
    ///   <para>rdfs:label : hasCausalConnectionWith</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#hasCausalConnectionWith">pimsii:hasCausalConnectionWith</a>
    /// </summary>
    let hasCausalConnectionWith = _prefixId.prefix "hasCausalConnectionWith"
    /// <summary>
    ///   <para>skos:scopeNote : in particular, x and y are directly causally connected if (x isParticipantIn y), or if x and y are both steps in a process where x directly precedes y; however, spatiotemporal parthood is not enough to justify causal connectedness - x must actually play a role in bringing about y, or vice versa</para>
    ///   <para>skos:altLabel : \dot{C}</para>
    ///   <para>rdfs:label : hasDirectCausalConnectionWith</para>
    ///   <para>rdfs:comment : Direct causal connection (in a broad sense)</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#hasDirectCausalConnectionWith">pimsii:hasDirectCausalConnectionWith</a>
    /// </summary>
    let hasDirectCausalConnectionWith = _prefixId.prefix "hasDirectCausalConnectionWith"
    /// <summary>
    ///   <para>rdfs:label : hasImproperPart</para>
    ///   <para>rdfs:comment : Spatiotemporal (mereological) improper parthood relation; in other words, it is the reflexive closure of proper parthood: (x hasImproperPart y) means that all points within y are also within x^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#hasImproperPart">pimsii:hasImproperPart</a>
    /// </summary>
    let hasImproperPart = _prefixId.prefix "hasImproperPart"
    /// <summary>
    ///   <para>rdfs:label : hasNecessityMode</para>
    ///   <para>rdfs:comment : (x hasNecessityMode y) means that x is a relational IRI and y is a modal IRI for 'necessarily x'</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#hasNecessityMode">pimsii:hasNecessityMode</a>
    /// </summary>
    let hasNecessityMode = _prefixId.prefix "hasNecessityMode"
    /// <summary>
    ///   <para>rdfs:label : hasNegation</para>
    ///   <para>rdfs:comment : (x hasNegation y) means that x and y are IRIs that can possibly occur in the predicate (middle) position of a triple, and that y is 'not x'; n.b., this is not a symmetrical relation, since 'not not x' is syntactically different from x^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#hasNegation">pimsii:hasNegation</a>
    /// </summary>
    let hasNegation = _prefixId.prefix "hasNegation"
    /// <summary>
    ///   <para>rdfs:label : hasPossibilityMode</para>
    ///   <para>rdfs:comment : (x hasPossibilityMode y) means that x is a relational IRI and y is a modal IRI for 'possibly x'</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#hasPossibilityMode">pimsii:hasPossibilityMode</a>
    /// </summary>
    let hasPossibilityMode = _prefixId.prefix "hasPossibilityMode"
    /// <summary>
    ///   <para>skos:scopeNote : Spatiotemporal (mereological) proper parthood relation</para>
    ///   <para>skos:altLabel : \dot{P}^-</para>
    ///   <para>rdfs:label : hasProperPart</para>
    ///   <para>rdfs:comment : (x hasProperPart y) means that y is an improper part of x such that x and y are not the same, in other words, all points within y are also within x, but not vice versa</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#hasProperPart">pimsii:hasProperPart</a>
    /// </summary>
    let hasProperPart = _prefixId.prefix "hasProperPart"
    /// <summary>
    ///   <para>rdfs:label : hasQualifiedNecessityMode</para>
    ///   <para>rdfs:comment : (x hasQualifiedNecessityMode y) means that x is a relational IRI and y is a qualified modal IRI for 'necessarily x'</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#hasQualifiedNecessityMode">pimsii:hasQualifiedNecessityMode</a>
    /// </summary>
    let hasQualifiedNecessityMode = _prefixId.prefix "hasQualifiedNecessityMode"
    /// <summary>
    ///   <para>rdfs:label : hasQualifiedPossibilityMode</para>
    ///   <para>rdfs:comment : (x hasQualifiedPossibilityMode y) means that x is a relational IRI and y is a qualified modal IRI for 'possibly x'</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#hasQualifiedPossibilityMode">pimsii:hasQualifiedPossibilityMode</a>
    /// </summary>
    let hasQualifiedPossibilityMode = _prefixId.prefix "hasQualifiedPossibilityMode"
    /// <summary>
    ///   <para>skos:altLabel : R^-</para>
    ///   <para>rdfs:label : hasRepresentamen</para>
    ///   <para>rdfs:comment : Dyadic representation relation; (x hasRepresentamen y) means that there is a cognitive step z such that (x isReferentIn z) and (y isRepresentamenIn z)</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#hasRepresentamen">pimsii:hasRepresentamen</a>
    /// </summary>
    let hasRepresentamen = _prefixId.prefix "hasRepresentamen"
    /// <summary>
    ///   <para>skos:scopeNote : following Yablo, there is such a thing as *the* subject matter of something, in other words, hasSubjectMatter is a functional property</para>
    ///   <para>skos:altLabel : A</para>
    ///   <para>rdfs:label : hasSubjectMatter</para>
    ///   <para>rdfs:comment : (x hasSubjectMatter y) means that x is a proposition or articulation that addresses the topic or sum (i.e., plurality) of topics y, i.e., that has y as its subject matter</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#hasSubjectMatter">pimsii:hasSubjectMatter</a>
    /// </summary>
    let hasSubjectMatter = _prefixId.prefix "hasSubjectMatter"
    /// <summary>
    ///   <para>skos:scopeNote : it can make sense to use a structure or plurality to indicate the complex ways in which x can be about a combination of interrelated objects</para>
    ///   <para>skos:altLabel : \hat{A}</para>
    ///   <para>rdfs:label : isAbout</para>
    ///   <para>rdfs:comment : (x isAbout y) means that x is a proposition and y is the object that x is related to by aboutness</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isAbout">pimsii:isAbout</a>
    /// </summary>
    let isAbout = _prefixId.prefix "isAbout"
    /// <summary>
    ///   <para>rdfs:label : isAccumulationConditionIn</para>
    ///   <para>rdfs:comment : (x isAccumulationConditionIn y) == in the accumulation process y, the condition x controls in what way the input and the additionally included elements interact to yield a combined output^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationConditionIn">pimsii:isAccumulationConditionIn</a>
    /// </summary>
    let isAccumulationConditionIn = _prefixId.prefix "isAccumulationConditionIn"
    /// <summary>
    ///   <para>rdfs:label : isAccumulationInputIn</para>
    ///   <para>rdfs:comment : (x isAccumulationInputIn y) == y is an accumulation where x is the input (initially given information), i.e., the first element; n.b., in an accumulation, the input needs to be constitutive of the output^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationInputIn">pimsii:isAccumulationInputIn</a>
    /// </summary>
    let isAccumulationInputIn = _prefixId.prefix "isAccumulationInputIn"
    /// <summary>
    ///   <para>rdfs:label : isAccumulationOutputIn</para>
    ///   <para>rdfs:comment : (x isAccumulationOutputIn y) == y is an accumulation where x is the output (combined information), i.e., the third element; n.b., in a selection, the input and any additionally included elements need to be constitutive of the output^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationOutputIn">pimsii:isAccumulationOutputIn</a>
    /// </summary>
    let isAccumulationOutputIn = _prefixId.prefix "isAccumulationOutputIn"
    /// <summary>
    ///   <para>rdfs:label : isActionInSteering</para>
    ///   <para>rdfs:comment : (x isActionInSteering y) == y is a steering operation (reflection in actu) where x is an ongoing action, i.e., the second element, against which the telos is evaluated^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isActionInSteering">pimsii:isActionInSteering</a>
    /// </summary>
    let isActionInSteering = _prefixId.prefix "isActionInSteering"
    /// <summary>
    ///   <para>rdfs:label : isActionInUndertaking</para>
    ///   <para>rdfs:comment : (x isActionInUndertaking y) == y is an undertaking where x is the action that is undertaken, i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isActionInUndertaking">pimsii:isActionInUndertaking</a>
    /// </summary>
    let isActionInUndertaking = _prefixId.prefix "isActionInUndertaking"
    /// <summary>
    ///   <para>rdfs:label : isAdmissibleUnitFor</para>
    ///   <para>rdfs:comment : (x isAdmissibleUnitFor y) means that x is a unit that can be associated with the variable y; subsumption under msHPIPIR is explained as follows: There is a sign z for the variable y (where z is a description of admissible values of y) of which x is constitutive (and with which x hence overlaps)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isAdmissibleUnitFor">pimsii:isAdmissibleUnitFor</a>
    /// </summary>
    let isAdmissibleUnitFor = _prefixId.prefix "isAdmissibleUnitFor"
    /// <summary>
    ///   <para>rdfs:label : isAdmissibleValueFor</para>
    ///   <para>rdfs:comment : (x isAdmissibleValueFor y) means that y is a term that could in principle evaluate to the value x; subsumption under msIPIRIR is explained as follows: There is a sign z for the term y (where z is the range of admissible values of y), for which in turn there is another sign z' (where z' lists members of z, explicitly including x) of which x is a part^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isAdmissibleValueFor">pimsii:isAdmissibleValueFor</a>
    /// </summary>
    let isAdmissibleValueFor = _prefixId.prefix "isAdmissibleValueFor"
    /// <summary>
    ///   <para>skos:altLabel : \ddot{P}_a</para>
    ///   <para>rdfs:label : isAgentIn</para>
    ///   <para>rdfs:comment : (x isAgentIn y) means that x is *the* agent that conducts/undertakes the action y; n.b., an action has exactly one agent (which can be a straightforward item, or a plurality, a structure, or similar)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isAgentIn">pimsii:isAgentIn</a>
    /// </summary>
    let isAgentIn = _prefixId.prefix "isAgentIn"
    /// <summary>
    ///   <para>skos:altLabel : R_\alpha</para>
    ///   <para>rdfs:comment : (x isAimIn y) means that y is a purposeful action, and x is one of the aims followed by the agent of y by undertaking y</para>
    ///   <para>rdfs:label : isAimIn</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isAimIn">pimsii:isAimIn</a>
    /// </summary>
    let isAimIn = _prefixId.prefix "isAimIn"
    /// <summary>
    ///   <para>rdfs:label : isAntecedentWithin</para>
    ///   <para>rdfs:comment : (x isAntecedentWithin y) means that x is the antecedent from the rule y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isAntecedentWithin">pimsii:isAntecedentWithin</a>
    /// </summary>
    let isAntecedentWithin = _prefixId.prefix "isAntecedentWithin"
    /// <summary>
    ///   <para>skos:altLabel : B</para>
    ///   <para>rdfs:label : isAssertedBy</para>
    ///   <para>rdfs:comment : (x isAssertedBy y) means that x is a claim that is affirmatively expressed/stated/uttered by the interlocutor y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isAssertedBy">pimsii:isAssertedBy</a>
    /// </summary>
    let isAssertedBy = _prefixId.prefix "isAssertedBy"
    /// <summary>
    ///   <para>rdfs:label : isAssertedIn</para>
    ///   <para>rdfs:comment : (x isAssertedIn y) means that x is a claim that is affirmatively expressed/stated/uttered in the expressive act y (by its speaker)</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isAssertedIn">pimsii:isAssertedIn</a>
    /// </summary>
    let isAssertedIn = _prefixId.prefix "isAssertedIn"
    /// <summary>
    ///   <para>rdfs:label : isAssessmentFor</para>
    ///   <para>rdfs:comment : (g isAssessmentFor y) means that g is a ground for the cognitive step y, explaining how y is grounded in a way that provides a proposition on its validity, accuracy, and/or reliability, relating it to that of the previous step that directly grounds y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isAssessmentFor">pimsii:isAssessmentFor</a>
    /// </summary>
    let isAssessmentFor = _prefixId.prefix "isAssessmentFor"
    /// <summary>
    ///   <para>skos:example : e.g., x may be thermodynamic temperature, y may be a temperature value, and o may be an object of which the temperature has been measured</para>
    ///   <para>skos:altLabel : \hat{A}_D</para>
    ///   <para>rdfs:label : isAssignmentFor</para>
    ///   <para>rdfs:comment : (d isAssignmentFor o) means that d: x = y is an assignment that refers to o</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isAssignmentFor">pimsii:isAssignmentFor</a>
    /// </summary>
    let isAssignmentFor = _prefixId.prefix "isAssignmentFor"
    /// <summary>
    ///   <para>rdfs:label : isCausallyDisconnectedFrom</para>
    ///   <para>rdfs:comment : (x isCausallyDisconnectedFrom y) means that between x and y there is no 'real causal connection' in the Peircean sense; therefore, x and y cannot be the old and new referents in a metonymization; similarly, x cannot act as a representamen for y in a grounded cognition (if it does, then the cognition is not grounded)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isCausallyDisconnectedFrom">pimsii:isCausallyDisconnectedFrom</a>
    /// </summary>
    let isCausallyDisconnectedFrom = _prefixId.prefix "isCausallyDisconnectedFrom"
    /// <summary>
    ///   <para>skos:scopeNote : the agent y explicitly stores x, hence requiring spatiotemporal overlap between x and y</para>
    ///   <para>rdfs:label : isClaimOf</para>
    ///   <para>rdfs:comment : (x isClaimOf y) means that the x is a proposition that has some kind of belief-like or knowledge-like epistemic status for the intelligent agent y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isClaimOf">pimsii:isClaimOf</a>
    /// </summary>
    let isClaimOf = _prefixId.prefix "isClaimOf"
    /// <summary>
    ///   <para>rdfs:label : isCognitiveSubstepOf</para>
    ///   <para>rdfs:comment : In certain cases, multiple cognitive steps can be combined to yield one; e.g., the substep a: s - o - s' and the substep b: s' - o - s'' can be combined to yield a single triad, (a o b) = c: s - o - s''; in that case, c can be an element of a higher-order cognitive chain (of which it is a step), and a and b are its cognitive substeps^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isCognitiveSubstepOf">pimsii:isCognitiveSubstepOf</a>
    /// </summary>
    let isCognitiveSubstepOf = _prefixId.prefix "isCognitiveSubstepOf"
    /// <summary>
    ///   <para>rdfs:label : isConsequentWithin</para>
    ///   <para>rdfs:comment : (x isConsequentWithin y) means that x is a consequent from the rule y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isConsequentWithin">pimsii:isConsequentWithin</a>
    /// </summary>
    let isConsequentWithin = _prefixId.prefix "isConsequentWithin"
    /// <summary>
    ///   <para>rdfs:comment : (x isConstitutiveOf y) means that, by virtue of an interaction requiring spatiotemporal overlap, x contributes causally to y fulfilling a certain function, exhibiting certain properties, or relating to other objects in the way it does, thereby creating a direct causal connection between x and y</para>
    ///   <para>skos:altLabel : \ddot{C}</para>
    ///   <para>rdfs:label : isConstitutiveOf</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isConstitutiveOf">pimsii:isConstitutiveOf</a>
    /// </summary>
    let isConstitutiveOf = _prefixId.prefix "isConstitutiveOf"
    /// <summary>
    ///   <para>rdfs:label : isContextOfRelation</para>
    ///   <para>rdfs:comment : (x isContextOfRelation y) means that x is an IRI for the modal context of qualified possibility/necessity in the relative modal IRI y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isContextOfRelation">pimsii:isContextOfRelation</a>
    /// </summary>
    let isContextOfRelation = _prefixId.prefix "isContextOfRelation"
    /// <summary>
    ///   <para>rdfs:label : isContextWithinLaw</para>
    ///   <para>rdfs:comment : (x isContextWithinLaw y) means that x is an IRI for the modal context of relatively necessary implication in the relative law y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isContextWithinLaw">pimsii:isContextWithinLaw</a>
    /// </summary>
    let isContextWithinLaw = _prefixId.prefix "isContextWithinLaw"
    /// <summary>
    ///   <para>rdfs:label : isDesignParameterWithin</para>
    ///   <para>rdfs:comment : (x isDesignParameterWithin y) == x is one of the parameters that make up the design space considered in the optimization problem y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isDesignParameterWithin">pimsii:isDesignParameterWithin</a>
    /// </summary>
    let isDesignParameterWithin = _prefixId.prefix "isDesignParameterWithin"
    /// <summary>
    ///   <para>rdfs:label : isDuplicateIn</para>
    ///   <para>rdfs:comment : (x isDuplicateIn y) == y is a duplication step where x is the output (duplicate), i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isDuplicateIn">pimsii:isDuplicateIn</a>
    /// </summary>
    let isDuplicateIn = _prefixId.prefix "isDuplicateIn"
    /// <summary>
    ///   <para>rdfs:label : isEvaluatedIn</para>
    ///   <para>rdfs:comment : (x isEvaluatedIn y) == y is an evaluation (reflection ex post) where x is the action undergoing evaluation, i.e., the second element; n.b., the action needs to temporally precede the evaluation^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isEvaluatedIn">pimsii:isEvaluatedIn</a>
    /// </summary>
    let isEvaluatedIn = _prefixId.prefix "isEvaluatedIn"
    /// <summary>
    ///   <para>rdfs:label : isEvaluationOutcomeIn</para>
    ///   <para>rdfs:comment : (x isEvaluationOutcomeIn y) == y is a an evaluation (reflection ex post) where x is the resolution (evaluation outcome), i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isEvaluationOutcomeIn">pimsii:isEvaluationOutcomeIn</a>
    /// </summary>
    let isEvaluationOutcomeIn = _prefixId.prefix "isEvaluationOutcomeIn"
    /// <summary>
    ///   <para>skos:altLabel : \ddot{P}_e</para>
    ///   <para>rdfs:label : isEvaluatorIn</para>
    ///   <para>rdfs:comment : (x isEvaluatorIn y) means that y is an evaluation and x is the interpreter in it</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isEvaluatorIn">pimsii:isEvaluatorIn</a>
    /// </summary>
    let isEvaluatorIn = _prefixId.prefix "isEvaluatorIn"
    /// <summary>
    ///   <para>rdfs:label : isExaminationOutcomeIn</para>
    ///   <para>rdfs:comment : (x isExaminationOutcomeIn y) == y is an examination where x is the examination outcome, i.e., the third element (e.g., yes the object agrees with the legisign, or it does so under this or that condition, etc.)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isExaminationOutcomeIn">pimsii:isExaminationOutcomeIn</a>
    /// </summary>
    let isExaminationOutcomeIn = _prefixId.prefix "isExaminationOutcomeIn"
    /// <summary>
    ///   <para>rdfs:label : isExaminedIn</para>
    ///   <para>rdfs:comment : (x isExaminedIn y) == y is an examination where x acts as the examined object, i.e., the second element, for which it is assessed to what extent (in which way, under what additional conditions, etc.) it conforms with the legisign^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isExaminedIn">pimsii:isExaminedIn</a>
    /// </summary>
    let isExaminedIn = _prefixId.prefix "isExaminedIn"
    /// <summary>
    ///   <para>skos:altLabel : \dot{B}</para>
    ///   <para>rdfs:label : isExpressedBy</para>
    ///   <para>rdfs:comment : (x isExpressedBy y) means that x is expressed/stated/uttered by the interlocutor y; n.b., this does not necessarily mean that y affirms x (for that, use the subproperty isAssertedBy)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isExpressedBy">pimsii:isExpressedBy</a>
    /// </summary>
    let isExpressedBy = _prefixId.prefix "isExpressedBy"
    /// <summary>
    ///   <para>rdfs:label : isExpressedIn</para>
    ///   <para>rdfs:comment : (x isExpressedIn y) means that x is expressed/stated/uttered in the expressive act y (by its speaker), possibly but not necessarily in an affirmative way^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isExpressedIn">pimsii:isExpressedIn</a>
    /// </summary>
    let isExpressedIn = _prefixId.prefix "isExpressedIn"
    /// <summary>
    ///   <para>skos:altLabel : \dot{E}</para>
    ///   <para>rdfs:label : isFirstElementIn</para>
    ///   <para>rdfs:comment : (x isFirstElementIn y) means that x acts as the first element in y, which is a triadic cognition</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isFirstElementIn">pimsii:isFirstElementIn</a>
    /// </summary>
    let isFirstElementIn = _prefixId.prefix "isFirstElementIn"
    /// <summary>
    ///   <para>skos:altLabel : \dot{E}_D</para>
    ///   <para>rdfs:label : isFirstInDyad</para>
    ///   <para>rdfs:comment : (x isFirstInDyad d) means that x is the first element of the dyad d^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isFirstInDyad">pimsii:isFirstInDyad</a>
    /// </summary>
    let isFirstInDyad = _prefixId.prefix "isFirstInDyad"
    /// <summary>
    ///   <para>skos:altLabel : \sigma</para>
    ///   <para>rdfs:label : isFusionOf</para>
    ///   <para>rdfs:comment : x isFusionOf (y1 y2 ... yn) means that x is the spatiotemporal union (i.e., fusion) of all the elements included in the list (y1 y2 ... yn)</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isFusionOf">pimsii:isFusionOf</a>
    /// </summary>
    let isFusionOf = _prefixId.prefix "isFusionOf"
    /// <summary>
    ///   <para>rdfs:comment : (x isGoalFor y) means that to the goal-directed agent y, the telos x represents something that is to be reached.</para>
    ///   <para>rdfs:label : isGoalFor</para>
    ///   <para>skos:scopeNote : A goal is both a representamen for a state of affairs desired by the agent and a representamen for the agent itself.</para>
    ///   <para>skos:altLabel : \dot{G}</para>
    ///   <para>skos:example : In (x isGoalFor y), if the agent x wants to go to Paris, y is not physically the city of Paris as a 4D object, but rather the associated intention, i.e., a mental or textual representation of the agent achieving the objective and reaching Paris.</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isGoalFor">pimsii:isGoalFor</a>
    /// </summary>
    let isGoalFor = _prefixId.prefix "isGoalFor"
    /// <summary>
    ///   <para>rdfs:label : isGoalOf</para>
    ///   <para>rdfs:comment : (x isGoalOf y) means that y is a goal-oriented agent with the tendency to work toward a state of affairs that is described/represented by y; accordingly, the goal y is also a representamen for the agent itself; this does *not* imply that the agent x is aware of pursuing y as a goal, or that y is somehow included in x as a mental representation - for that purpose, use the relation 'isGoalFor'^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isGoalOf">pimsii:isGoalOf</a>
    /// </summary>
    let isGoalOf = _prefixId.prefix "isGoalOf"
    /// <summary>
    ///   <para>rdfs:label : isGroundFor</para>
    ///   <para>skos:altLabel : \ddot{R}</para>
    ///   <para>skos:scopeNote : for g isGroundFor y, where x grounds y, there is a grounding metonymization where x is the old referent and y is the new referent of g</para>
    ///   <para>rdfs:comment : (g isGroundFor y) means that g is a representamen for the cognitive step y, explaining how y is grounded</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundFor">pimsii:isGroundFor</a>
    /// </summary>
    let isGroundFor = _prefixId.prefix "isGroundFor"
    /// <summary>
    ///   <para>rdfs:label : isGroundedStepIn</para>
    ///   <para>rdfs:comment : (x isGroundedStepIn y) == y is a grounding step where x is the grounded step, i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundedStepIn">pimsii:isGroundedStepIn</a>
    /// </summary>
    let isGroundedStepIn = _prefixId.prefix "isGroundedStepIn"
    /// <summary>
    ///   <para>rdfs:label : isGroundingPropositionIn</para>
    ///   <para>rdfs:comment : (x isGroundingPropositionIn y) == y is a grounding step where x is the grounding proposition, i.e., the second element; therein, x is a ground for the grounded step, and x is also a ground for y itself^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundingPropositionIn">pimsii:isGroundingPropositionIn</a>
    /// </summary>
    let isGroundingPropositionIn = _prefixId.prefix "isGroundingPropositionIn"
    /// <summary>
    ///   <para>rdfs:label : isGroundingStepIn</para>
    ///   <para>rdfs:comment : (x isGroundingStepIn y) == y is a grounding step where x is the grounding step, i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundingStepIn">pimsii:isGroundingStepIn</a>
    /// </summary>
    let isGroundingStepIn = _prefixId.prefix "isGroundingStepIn"
    /// <summary>
    ///   <para>rdfs:label : isHeldBy</para>
    ///   <para>rdfs:comment : (x isHeldBy y) means that the claim x is consistently asserted by the knowledge base y whenever it is queried about it; if y extends significantly through time and changes opinion about x (i.e., it does not assert it consistently over the whole time), it cannot be said to hold x as a claim, merely to assert it; in this case, it may be advisable to define a (temporal) part y' of y which can then be said to hold x as a claim^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isHeldBy">pimsii:isHeldBy</a>
    /// </summary>
    let isHeldBy = _prefixId.prefix "isHeldBy"
    /// <summary>
    ///   <para>skos:altLabel : P^^xsd:string</para>
    ///   <para>rdfs:label : isImproperPartOf</para>
    ///   <para>rdfs:comment : Spatiotemporal (mereological) improper parthood relation; in other words, it is the reflexive closure of proper parthood: (x isImproperPartOf y) means that all points within x are also within y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isImproperPartOf">pimsii:isImproperPartOf</a>
    /// </summary>
    let isImproperPartOf = _prefixId.prefix "isImproperPartOf"
    /// <summary>
    ///   <para>rdfs:label : isIncludedInAccumulation</para>
    ///   <para>rdfs:comment : (x isIncludedInAccumulation y) == y is an accumulation where x is combined with the accumulation input, yielding an output that x is constitutive of; n.b., x needs to act as a representamen for the object (e.g., as an interpretant from a preceding cognitive step with the same object)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isIncludedInAccumulation">pimsii:isIncludedInAccumulation</a>
    /// </summary>
    let isIncludedInAccumulation = _prefixId.prefix "isIncludedInAccumulation"

    /// <summary>
    ///   <para>rdfs:label : isInformationProcessingInputIn</para>
    ///   <para>rdfs:comment : (x isInformationProcessingInputIn y) == y is an information-processing step where x is the input, i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isInformationProcessingInputIn">pimsii:isInformationProcessingInputIn</a>
    /// </summary>
    let isInformationProcessingInputIn = _prefixId.prefix "isInformationProcessingInputIn"

    /// <summary>
    ///   <para>rdfs:label : isInformationProcessingOutputIn</para>
    ///   <para>rdfs:comment : (x isInformationProcessingOutputIn y) == y is an information-processing step where x is the output, i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isInformationProcessingOutputIn">pimsii:isInformationProcessingOutputIn</a>
    /// </summary>
    let isInformationProcessingOutputIn = _prefixId.prefix "isInformationProcessingOutputIn"

    /// <summary>
    ///   <para>rdfs:label : isInitialStepIn</para>
    ///   <para>rdfs:comment : (x isInitialStepIn y) means that y is a step in x (i.e., a subprocess of x) that is not preceded by any other step^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isInitialStepIn">pimsii:isInitialStepIn</a>
    /// </summary>
    let isInitialStepIn = _prefixId.prefix "isInitialStepIn"
    /// <summary>
    ///   <para>rdfs:label : isInterlocutorIn</para>
    ///   <para>rdfs:comment : (x isInterlocutorIn y) means that x engages, jointly with other interlocutors, in the communication y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isInterlocutorIn">pimsii:isInterlocutorIn</a>
    /// </summary>
    let isInterlocutorIn = _prefixId.prefix "isInterlocutorIn"
    /// <summary>
    ///   <para>rdfs:label : isInterpretantIn</para>
    ///   <para>rdfs:comment : (x isInterpretantIn y) == y is a semiosis where x acts as the interpretant, i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantIn">pimsii:isInterpretantIn</a>
    /// </summary>
    let isInterpretantIn = _prefixId.prefix "isInterpretantIn"

    /// <summary>
    ///   <para>rdfs:label : isInterpretantInInterpretation</para>
    ///   <para>rdfs:comment : (x isInterpretantInInterpretation y) == y is an interpretation where x acts as the interpretant, i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantInInterpretation">pimsii:isInterpretantInInterpretation</a>
    /// </summary>
    let isInterpretantInInterpretation = _prefixId.prefix "isInterpretantInInterpretation"

    /// <summary>
    ///   <para>rdfs:label : isInterpretantInPerception</para>
    ///   <para>rdfs:comment : (x isInterpretantInPerception y) == y is a perception where x acts as the interpretant, i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantInPerception">pimsii:isInterpretantInPerception</a>
    /// </summary>
    let isInterpretantInPerception = _prefixId.prefix "isInterpretantInPerception"
    /// <summary>
    ///   <para>rdfs:label : isInterpreterIn</para>
    ///   <para>rdfs:comment : (x isInterpreterIn y) means that x is the (unique) agent who conducts/undertakes the cognitive action y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpreterIn">pimsii:isInterpreterIn</a>
    /// </summary>
    let isInterpreterIn = _prefixId.prefix "isInterpreterIn"
    /// <summary>
    ///   <para>rdfs:label : isJustificationFor</para>
    ///   <para>rdfs:comment : (x isJustificationFor y) means that x is a grounding chain that provides epsitemic grounding for the cognition y, which thereby becomes a grounded cognition^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isJustificationFor">pimsii:isJustificationFor</a>
    /// </summary>
    let isJustificationFor = _prefixId.prefix "isJustificationFor"
    /// <summary>
    ///   <para>skos:altLabel : \dot{E}_=</para>
    ///   <para>rdfs:label : isLeftHandSideIn</para>
    ///   <para>rdfs:comment : (x isLeftHandSideIn a) mans that a: x = y is an equality articulation with the term x as its left-hand side^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isLeftHandSideIn">pimsii:isLeftHandSideIn</a>
    /// </summary>
    let isLeftHandSideIn = _prefixId.prefix "isLeftHandSideIn"
    /// <summary>
    ///   <para>rdfs:label : isLegisignIn</para>
    ///   <para>rdfs:comment : (x isLegisignIn y) == y is an examination where x is applied to an object as a legisign, i.e., the first element, specifying patterns or rules the compliance with which is being assessed^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isLegisignIn">pimsii:isLegisignIn</a>
    /// </summary>
    let isLegisignIn = _prefixId.prefix "isLegisignIn"
    /// <summary>
    ///   <para>rdfs:label : isListenerIn</para>
    ///   <para>rdfs:comment : (x isListenerIn y) means that x is one of the interlocutors listening to the speaker's expressive act y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isListenerIn">pimsii:isListenerIn</a>
    /// </summary>
    let isListenerIn = _prefixId.prefix "isListenerIn"
    /// <summary>
    ///   <para>rdfs:label : isLiterally</para>
    ///   <para>rdfs:comment : points to the expression of a collective literal as an RDFS literal (e.g., xs:string or xs:decimal)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isLiterally">pimsii:isLiterally</a>
    /// </summary>
    let isLiterally = _prefixId.prefix "isLiterally"
    /// <summary>
    ///   <para>rdfs:label : isMagnitudeOf</para>
    ///   <para>rdfs:comment : (x isMagnitudeOf y) means that x is the numerical magnitude of y, e.g., in 200 kPa, x would be 200^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isMagnitudeOf">pimsii:isMagnitudeOf</a>
    /// </summary>
    let isMagnitudeOf = _prefixId.prefix "isMagnitudeOf"
    /// <summary>
    ///   <para>rdfs:label : isMaximizationObjectiveIn</para>
    ///   <para>rdfs:comment : (x isMaximizationObjectiveIn y) == x is a maximization objective/criterion considered in the optimization problem y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isMaximizationObjectiveIn">pimsii:isMaximizationObjectiveIn</a>
    /// </summary>
    let isMaximizationObjectiveIn = _prefixId.prefix "isMaximizationObjectiveIn"
    /// <summary>
    ///   <para>rdfs:label : isMeasuredObjectIn</para>
    ///   <para>rdfs:comment : (x isMeasuredObjectIn y) == y is a measurement where x acts as the object, i.e., the second element, that is subject to the measurement and for which a property is determined^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isMeasuredObjectIn">pimsii:isMeasuredObjectIn</a>
    /// </summary>
    let isMeasuredObjectIn = _prefixId.prefix "isMeasuredObjectIn"
    /// <summary>
    ///   <para>rdfs:label : isMeasurementInputIn</para>
    ///   <para>rdfs:comment : (x isMeasurementInputIn y) == y is a measurement where x serves as the input (sign), i.e., the first element, constituting the precondition in terms of available information and similar items^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isMeasurementInputIn">pimsii:isMeasurementInputIn</a>
    /// </summary>
    let isMeasurementInputIn = _prefixId.prefix "isMeasurementInputIn"
    /// <summary>
    ///   <para>rdfs:label : isMeasurementOutcomeIn</para>
    ///   <para>rdfs:comment : (x isMeasurementOutcomeIn y) == y is a measurement where x is the measurement outcome, i.e., the third element (e.g., the value that is determined for the considered property of the measured object, the measurement error, and any other outcome)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isMeasurementOutcomeIn">pimsii:isMeasurementOutcomeIn</a>
    /// </summary>
    let isMeasurementOutcomeIn = _prefixId.prefix "isMeasurementOutcomeIn"
    /// <summary>
    ///   <para>skos:altLabel : \leq</para>
    ///   <para>rdfs:label : isMemberOf</para>
    ///   <para>rdfs:comment : membership relation, i.e., relation between an item/member and a collective</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isMemberOf">pimsii:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>skos:altLabel : \lhd_p</para>
    ///   <para>rdfs:label : isMemberOfPlurality</para>
    ///   <para>rdfs:comment : (x isMemberOfPlurality y) means that x is a semiotic member of the plurality y, and that it participates in semiosis in the same way as its co-members x', x'', ... of the plurality y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isMemberOfPlurality">pimsii:isMemberOfPlurality</a>
    /// </summary>
    let isMemberOfPlurality = _prefixId.prefix "isMemberOfPlurality"
    /// <summary>
    ///   <para>skos:altLabel : \prec</para>
    ///   <para>rdfs:label : isMemberOfStructure</para>
    ///   <para>rdfs:comment : (x isMemberOfStructure y) means that x is a semiotic member of the structure y, and that it participates in semiosis differently from all of its co-members x', x'', ... of the structure y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isMemberOfStructure">pimsii:isMemberOfStructure</a>
    /// </summary>
    let isMemberOfStructure = _prefixId.prefix "isMemberOfStructure"

    /// <summary>
    ///   <para>rdfs:label : isMereologicallyConstitutiveOf</para>
    ///   <para>rdfs:comment : (x isMereologicallyConstitutiveOf y) means that x is constitutive of y by virtue of the way in which it is a proper part of y in 4D spacetime, e.g., as a necessary component of an item that was designed for a certain purpose^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isMereologicallyConstitutiveOf">pimsii:isMereologicallyConstitutiveOf</a>
    /// </summary>
    let isMereologicallyConstitutiveOf = _prefixId.prefix "isMereologicallyConstitutiveOf"

    /// <summary>
    ///   <para>rdfs:label : isMereosemioticallyRelatedTo</para>
    ///   <para>rdfs:comment : Top mereosemiotic relation: Direct or indirect connection through mereotopological and semiotic relations</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isMereosemioticallyRelatedTo">pimsii:isMereosemioticallyRelatedTo</a>
    /// </summary>
    let isMereosemioticallyRelatedTo = _prefixId.prefix "isMereosemioticallyRelatedTo"
    /// <summary>
    ///   <para>rdfs:label : isMereotopologicalMemberOf</para>
    ///   <para>rdfs:comment : (x isMereotopologicalMemberOf y) means that x is one out of several mereotopologically connected components of y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isMereotopologicalMemberOf">pimsii:isMereotopologicalMemberOf</a>
    /// </summary>
    let isMereotopologicalMemberOf = _prefixId.prefix "isMereotopologicalMemberOf"
    /// <summary>
    ///   <para>rdfs:label : isMaximizationObjectiveIn</para>
    ///   <para>rdfs:comment : (x isMaximizationObjectiveIn y) == x is a maximization objective/criterion considered in the optimization problem y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isMinimizationObjectiveIn">pimsii:isMinimizationObjectiveIn</a>
    /// </summary>
    let isMinimizationObjectiveIn = _prefixId.prefix "isMinimizationObjectiveIn"
    /// <summary>
    ///   <para>rdfs:label : isModelledIn</para>
    ///   <para>rdfs:comment : (x isModelledIn y) == y is a modelling (model construction or parameterization) step where x acts as the modelled object (system, substance, process, or similar), i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isModelledIn">pimsii:isModelledIn</a>
    /// </summary>
    let isModelledIn = _prefixId.prefix "isModelledIn"
    /// <summary>
    ///   <para>rdfs:label : isModellingInputIn</para>
    ///   <para>rdfs:comment : (x isModellingInputIn y) == y is a modelling (model construction or parameterization) step where x is the input (previous or unparameterized model, knowledge about the modelled system, etc.), i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isModellingInputIn">pimsii:isModellingInputIn</a>
    /// </summary>
    let isModellingInputIn = _prefixId.prefix "isModellingInputIn"
    /// <summary>
    ///   <para>rdfs:label : isModellingOutputIn</para>
    ///   <para>rdfs:comment : (x isModellingOutputIn y) == y is a modelling (model construction or parameterization) step where x is the modelling output (e.g., a parameterized or improved model), i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isModellingOutputIn">pimsii:isModellingOutputIn</a>
    /// </summary>
    let isModellingOutputIn = _prefixId.prefix "isModellingOutputIn"
    /// <summary>
    ///   <para>rdfs:label : isNameFor</para>
    ///   <para>rdfs:comment : (x isNameFor y), to be applied in the frequent special case where x is represented by a name for x, i.e., where social convention has established y as a rigid designator for x^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isNameFor">pimsii:isNameFor</a>
    /// </summary>
    let isNameFor = _prefixId.prefix "isNameFor"
    /// <summary>
    ///   <para>rdfs:label : isNewReferentIn</para>
    ///   <para>rdfs:comment : (x isNewReferentIn y) == y is a semantic change where x acts as the new referent, i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentIn">pimsii:isNewReferentIn</a>
    /// </summary>
    let isNewReferentIn = _prefixId.prefix "isNewReferentIn"
    /// <summary>
    ///   <para>rdfs:label : isNewReferentInMetonymization</para>
    ///   <para>rdfs:comment : (x isNewReferentInMetonymization y) == y is a metonymization where x acts as the new referent, i.e., the third element; the old and the new referent need to have a causal connection^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInMetonymization">pimsii:isNewReferentInMetonymization</a>
    /// </summary>
    let isNewReferentInMetonymization = _prefixId.prefix "isNewReferentInMetonymization"
    /// <summary>
    ///   <para>rdfs:label : isNewReferentInPartToWhole</para>
    ///   <para>rdfs:comment : (x isNewReferentInPartToWhole y) == y is a part-to-whole synecdoche where x acts as the new referent (the whole), i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInPartToWhole">pimsii:isNewReferentInPartToWhole</a>
    /// </summary>
    let isNewReferentInPartToWhole = _prefixId.prefix "isNewReferentInPartToWhole"
    /// <summary>
    ///   <para>rdfs:label : isNewReferentInSynecdoche</para>
    ///   <para>rdfs:comment : (x isNewReferentInSynecdoche y) == y is a synecdoche where x acts as the new referent, i.e., the third element; the old and the new referent need to have a causal connection (n.b., the mereological relation in terms of proper parthood as such is insufficient)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInSynecdoche">pimsii:isNewReferentInSynecdoche</a>
    /// </summary>
    let isNewReferentInSynecdoche = _prefixId.prefix "isNewReferentInSynecdoche"
    /// <summary>
    ///   <para>rdfs:label : isNewReferentInWholeToPart</para>
    ///   <para>rdfs:comment : (x isNewReferentInWholeToPart y) == y is a whole-to-part synecdoche where x acts as the new referent (the part), i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInWholeToPart">pimsii:isNewReferentInWholeToPart</a>
    /// </summary>
    let isNewReferentInWholeToPart = _prefixId.prefix "isNewReferentInWholeToPart"
    /// <summary>
    ///   <para>rdfs:label : isObjectIn</para>
    ///   <para>rdfs:comment : (x isObjectIn y) == y is a semiosis where x acts as the object, i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectIn">pimsii:isObjectIn</a>
    /// </summary>
    let isObjectIn = _prefixId.prefix "isObjectIn"
    /// <summary>
    ///   <para>rdfs:label : isObjectInAccumulation</para>
    ///   <para>rdfs:comment : (x isObjectInAccumulation y) == y is an accumulation where x is the object that the input and the output both represent, i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInAccumulation">pimsii:isObjectInAccumulation</a>
    /// </summary>
    let isObjectInAccumulation = _prefixId.prefix "isObjectInAccumulation"
    /// <summary>
    ///   <para>rdfs:label : isObjectInDuplication</para>
    ///   <para>rdfs:comment : (x isObjectInDuplication y) == y is a duplication step where x is the object that the original and the duplicate both represent, i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInDuplication">pimsii:isObjectInDuplication</a>
    /// </summary>
    let isObjectInDuplication = _prefixId.prefix "isObjectInDuplication"

    /// <summary>
    ///   <para>rdfs:label : isObjectInInformationProcessing</para>
    ///   <para>rdfs:comment : (x isObjectInInformationProcessing y) == y is an information-processing step where x is the object that the input and the output both represent, i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInInformationProcessing">pimsii:isObjectInInformationProcessing</a>
    /// </summary>
    let isObjectInInformationProcessing = _prefixId.prefix "isObjectInInformationProcessing"

    /// <summary>
    ///   <para>rdfs:label : isObjectInInterpretation</para>
    ///   <para>rdfs:comment : (x isObjectInInterpretation y) == y is an interpretation where x acts as the object, i.e., the second element; there is no need to the object of an interpretation to be present and participate in the interpretation process physically^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInInterpretation">pimsii:isObjectInInterpretation</a>
    /// </summary>
    let isObjectInInterpretation = _prefixId.prefix "isObjectInInterpretation"
    /// <summary>
    ///   <para>rdfs:label : isObjectInOptimization</para>
    ///   <para>rdfs:comment : (x isObjectInOptimization y) == y is an optimization where x is that which the optimization is ultimately about, i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInOptimization">pimsii:isObjectInOptimization</a>
    /// </summary>
    let isObjectInOptimization = _prefixId.prefix "isObjectInOptimization"
    /// <summary>
    ///   <para>rdfs:label : isObjectInSelection</para>
    ///   <para>rdfs:comment : (x isObjectInSelection y) == y is a selection where x is the object that the input and the output both represent, i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInSelection">pimsii:isObjectInSelection</a>
    /// </summary>
    let isObjectInSelection = _prefixId.prefix "isObjectInSelection"
    /// <summary>
    ///   <para>rdfs:label : isObjectInTelesis</para>
    ///   <para>rdfs:comment : (x isObjectInTelesis y) == y is a telesis where x acts as the object (action, claim, or situation against which an objective is evaluated), i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInTelesis">pimsii:isObjectInTelesis</a>
    /// </summary>
    let isObjectInTelesis = _prefixId.prefix "isObjectInTelesis"
    /// <summary>
    ///   <para>rdfs:label : isObjectOfApplicationIn</para>
    ///   <para>rdfs:comment : (x isObjectOfApplicationIn y) == y is an investigation-setup action where x acts as the object of application (e.g., the system to which a use case refers), i.e., the first element; n.b., there needs to be a causal connection between the object of application and the object of investigation^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectOfApplicationIn">pimsii:isObjectOfApplicationIn</a>
    /// </summary>
    let isObjectOfApplicationIn = _prefixId.prefix "isObjectOfApplicationIn"
    /// <summary>
    ///   <para>rdfs:label : isObjectOfInvestigationIn</para>
    ///   <para>rdfs:comment : (x isObjectOfInvestigationIn y) == y is an investigation-setup action where x acts as the object of investigation (e.g., the item subject to an experiment or a simulated process or system), i.e., as the third element; n.b., there needs to be a causal connection between the object of application and the object of investigation^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectOfInvestigationIn">pimsii:isObjectOfInvestigationIn</a>
    /// </summary>
    let isObjectOfInvestigationIn = _prefixId.prefix "isObjectOfInvestigationIn"
    /// <summary>
    ///   <para>rdfs:label : isObjectWithinTriple</para>
    ///   <para>rdfs:comment : (x isObjectWithinTriple y) means that y is a subject-predicate-object triple wherein x is the IRI of the object^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectWithinTriple">pimsii:isObjectWithinTriple</a>
    /// </summary>
    let isObjectWithinTriple = _prefixId.prefix "isObjectWithinTriple"
    /// <summary>
    ///   <para>rdfs:label : isObservationInputIn</para>
    ///   <para>rdfs:comment : (x isObservationInputIn y) == y is an observation where x designates input and/or advance knowledge relevant to the observation, i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObservationInputIn">pimsii:isObservationInputIn</a>
    /// </summary>
    let isObservationInputIn = _prefixId.prefix "isObservationInputIn"
    /// <summary>
    ///   <para>rdfs:label : isObservationOutcomeIn</para>
    ///   <para>rdfs:comment : (x isObservationOutcomeIn y) == y is an observation where x is the observation outcome (the observed value of the target property), i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObservationOutcomeIn">pimsii:isObservationOutcomeIn</a>
    /// </summary>
    let isObservationOutcomeIn = _prefixId.prefix "isObservationOutcomeIn"
    /// <summary>
    ///   <para>rdfs:label : isObservedIn</para>
    ///   <para>rdfs:comment : (x isObservedIn y) == y is an observation where x acts as the observed object, i.e., the second element, for which the value of a property is to be determined^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isObservedIn">pimsii:isObservedIn</a>
    /// </summary>
    let isObservedIn = _prefixId.prefix "isObservedIn"
    /// <summary>
    ///   <para>rdfs:label : isOldReferentIn</para>
    ///   <para>rdfs:comment : (x isOldReferentIn y) == y is a semantic change where x acts as the old referent, i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentIn">pimsii:isOldReferentIn</a>
    /// </summary>
    let isOldReferentIn = _prefixId.prefix "isOldReferentIn"
    /// <summary>
    ///   <para>rdfs:label : isOldReferentInMetonymization</para>
    ///   <para>rdfs:comment : (x isOldReferentInMetonymization y) == y is a metonymization where x acts as the old referent, i.e., the first element; the old and the new referent need to have a causal connection^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInMetonymization">pimsii:isOldReferentInMetonymization</a>
    /// </summary>
    let isOldReferentInMetonymization = _prefixId.prefix "isOldReferentInMetonymization"
    /// <summary>
    ///   <para>rdfs:label : isOldReferentInPartToWhole</para>
    ///   <para>rdfs:comment : (x isOldReferentInPartToWhole y) == y is a part-to-whole synecdoche where x acts as the old referent (the part), i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInPartToWhole">pimsii:isOldReferentInPartToWhole</a>
    /// </summary>
    let isOldReferentInPartToWhole = _prefixId.prefix "isOldReferentInPartToWhole"
    /// <summary>
    ///   <para>rdfs:label : isOldReferentInSynecdoche</para>
    ///   <para>rdfs:comment : (x isOldReferentInSynecdoche y) == y is a synecdoche where x acts as the old referent, i.e., the first element; the old and the new referent need to have a causal connection (n.b., the mereological relation in terms of proper parthood as such is insufficient)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInSynecdoche">pimsii:isOldReferentInSynecdoche</a>
    /// </summary>
    let isOldReferentInSynecdoche = _prefixId.prefix "isOldReferentInSynecdoche"
    /// <summary>
    ///   <para>rdfs:label : isOldReferentInWholeToPart</para>
    ///   <para>rdfs:comment : (x isOldReferentInWholeToPart y) == y is a whole-to-part synecdoche where x acts as the old referent (the whole), i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInWholeToPart">pimsii:isOldReferentInWholeToPart</a>
    /// </summary>
    let isOldReferentInWholeToPart = _prefixId.prefix "isOldReferentInWholeToPart"
    /// <summary>
    ///   <para>rdfs:label : isOptimizationObjectiveWithin</para>
    ///   <para>rdfs:comment : (x isOptimizationObjectiveWithin y) == x is one of the optimization criteria that make up the objective space considered in the optimization problem y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationObjectiveWithin">pimsii:isOptimizationObjectiveWithin</a>
    /// </summary>
    let isOptimizationObjectiveWithin = _prefixId.prefix "isOptimizationObjectiveWithin"
    /// <summary>
    ///   <para>rdfs:label : isOptimizationOutputIn</para>
    ///   <para>rdfs:comment : (x isOptimizationOutputIn y) == y is an optimization where x is the optimization output, i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationOutputIn">pimsii:isOptimizationOutputIn</a>
    /// </summary>
    let isOptimizationOutputIn = _prefixId.prefix "isOptimizationOutputIn"
    /// <summary>
    ///   <para>skos:scopeNote : In (x isOptimizationProblemIn y), x is the aim/intention pursued by carrying out the optimization process y.</para>
    ///   <para>rdfs:label : isOptimizationProblemIn</para>
    ///   <para>rdfs:comment : (x isOptimizationProblemIn y) == y is an optimization where x is the optimization problem, i.e., the first element.</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationProblemIn">pimsii:isOptimizationProblemIn</a>
    /// </summary>
    let isOptimizationProblemIn = _prefixId.prefix "isOptimizationProblemIn"
    /// <summary>
    ///   <para>rdfs:label : isOriginalIn</para>
    ///   <para>rdfs:comment : (x isOriginalIn y) == y is a duplication step where x is the input (original version), i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isOriginalIn">pimsii:isOriginalIn</a>
    /// </summary>
    let isOriginalIn = _prefixId.prefix "isOriginalIn"
    /// <summary>
    ///   <para>skos:altLabel : \v{C}_\perp</para>
    ///   <para>rdfs:label : isOrthodataWithin</para>
    ///   <para>rdfs:comment : (x isOrthodataWithin y) means that x articulates a substantial aspect of either the antecedent or the consequent side of the rule y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isOrthodataWithin">pimsii:isOrthodataWithin</a>
    /// </summary>
    let isOrthodataWithin = _prefixId.prefix "isOrthodataWithin"
    /// <summary>
    ///   <para>skos:altLabel : \v{C}_\parallel</para>
    ///   <para>rdfs:label : isParadataWithin</para>
    ///   <para>rdfs:comment : (x isParadataWithin y) means that x articulates something explicitly said to be unsubstantial to the rule y, and thereby semiotically constitutive of it, e.g., by a mechanism of logical subtraction</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isParadataWithin">pimsii:isParadataWithin</a>
    /// </summary>
    let isParadataWithin = _prefixId.prefix "isParadataWithin"
    /// <summary>
    ///   <para>rdfs:label : isParticipantIn</para>
    ///   <para>rdfs:comment : (x isParticipantIn y) means that y is a process in which x plays a certain role (e.g., x is a well-defined step within y, or x is an object that undergoes some change within y, or x is a sign that is read or an object that is perceived within y); this requires a spatiotemporal overlap between x and y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isParticipantIn">pimsii:isParticipantIn</a>
    /// </summary>
    let isParticipantIn = _prefixId.prefix "isParticipantIn"
    /// <summary>
    ///   <para>skos:altLabel : \ddot{P}_\kappa</para>
    ///   <para>rdfs:label : isParticipantInCognition</para>
    ///   <para>rdfs:comment : (x isParticipantInCognition y) means that y is a cognition in which x is necessarily physically present and plays one of the roles characteristic for participation in a cognitive process as formalized by this ontology; this includes participation as a representamen, as a perceived object, as a step of a cognitive chain, or as an interpreter^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isParticipantInCognition">pimsii:isParticipantInCognition</a>
    /// </summary>
    let isParticipantInCognition = _prefixId.prefix "isParticipantInCognition"
    /// <summary>
    ///   <para>rdfs:label : isPerceivedIn</para>
    ///   <para>rdfs:comment : (x isPerceivedIn y) == y is a perception where x acts as the perceived object, i.e., the second element; the perceived object is a (mereotopological) participant of the perception, in other words, it needs to be physically present so that it can be perceived^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isPerceivedIn">pimsii:isPerceivedIn</a>
    /// </summary>
    let isPerceivedIn = _prefixId.prefix "isPerceivedIn"
    /// <summary>
    ///   <para>skos:scopeNote : This does not require the agent to be aware of its performance measure or to somehow contain it or an internal representation of it.</para>
    ///   <para>rdfs:label : isPerformanceMeasureOf</para>
    ///   <para>rdfs:comment : (x isPerformanceMeasureOf y) means that x is the single/unique performance measure of the rational agent y.</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isPerformanceMeasureOf">pimsii:isPerformanceMeasureOf</a>
    /// </summary>
    let isPerformanceMeasureOf = _prefixId.prefix "isPerformanceMeasureOf"
    /// <summary>
    ///   <para>rdfs:label : isPredicateWithinTriple</para>
    ///   <para>rdfs:comment : (x isPredicateWithinTriple y) means that y is a subject-predicate-object triple wherein x is the IRI of the predicate^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isPredicateWithinTriple">pimsii:isPredicateWithinTriple</a>
    /// </summary>
    let isPredicateWithinTriple = _prefixId.prefix "isPredicateWithinTriple"
    /// <summary>
    ///   <para>rdfs:label : isPresentStepInGrounding</para>
    ///   <para>rdfs:comment : (x isPresentStepInGrounding y) == y is a grounding interpretation where x is the second element, i.e., the considered cognitive step^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isPresentStepInGrounding">pimsii:isPresentStepInGrounding</a>
    /// </summary>
    let isPresentStepInGrounding = _prefixId.prefix "isPresentStepInGrounding"
    /// <summary>
    ///   <para>rdfs:label : isProperPartOf</para>
    ///   <para>rdfs:comment : Spatiotemporal (mereological) proper parthood relation; (x isProperPartOf y) means that x is an improper part of y such that x and y are not the same, in other words, all points within x are also within y, but not vice versa^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isProperPartOf">pimsii:isProperPartOf</a>
    /// </summary>
    let isProperPartOf = _prefixId.prefix "isProperPartOf"
    /// <summary>
    ///   <para>rdfs:label : isProperParticipantIn</para>
    ///   <para>rdfs:comment : (x isProperParticipantIn y) is the conjunction of (x isProperPartOf y) and (x isParticipantIn y)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isProperParticipantIn">pimsii:isProperParticipantIn</a>
    /// </summary>
    let isProperParticipantIn = _prefixId.prefix "isProperParticipantIn"
    /// <summary>
    ///   <para>skos:altLabel : \dddot{R}</para>
    ///   <para>rdfs:label : isReferenceFrameFor</para>
    ///   <para>rdfs:comment : (s isReferenceFrameFor s') means that s is a representamen that provides relevant context, such as presuppositions or preconditions, to the representamen s'</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isReferenceFrameFor">pimsii:isReferenceFrameFor</a>
    /// </summary>
    let isReferenceFrameFor = _prefixId.prefix "isReferenceFrameFor"
    /// <summary>
    ///   <para>rdfs:label : isReferentIn</para>
    ///   <para>rdfs:comment : (x isReferentIn y) == x occurs in the cognitive step y in the function of the/a referent of a representamen</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isReferentIn">pimsii:isReferentIn</a>
    /// </summary>
    let isReferentIn = _prefixId.prefix "isReferentIn"
    /// <summary>
    ///   <para>rdfs:label : isRelatedToList</para>
    ///   <para>rdfs:comment : Top property for multi-argument predicates that are implemented as 'x isRelatedToList (y1 y2 ... yn)', i.e., such that the object is an rdf:List</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isRelatedToList">pimsii:isRelatedToList</a>
    /// </summary>
    let isRelatedToList = _prefixId.prefix "isRelatedToList"
    /// <summary>
    ///   <para>rdfs:label : isRepresentamenFor</para>
    ///   <para>rdfs:comment : Dyadic representation relation; (x isRepresentamenFor y) means that there is a cognitive step z such that (x isRepresentamenIn z) and (y isReferentIn z)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isRepresentamenFor">pimsii:isRepresentamenFor</a>
    /// </summary>
    let isRepresentamenFor = _prefixId.prefix "isRepresentamenFor"
    /// <summary>
    ///   <para>rdfs:label : isRepresentamenIn</para>
    ///   <para>rdfs:comment : (x isRepresentamenIn y) == x participates in the cognitive step y in the role of the/a representamen</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isRepresentamenIn">pimsii:isRepresentamenIn</a>
    /// </summary>
    let isRepresentamenIn = _prefixId.prefix "isRepresentamenIn"
    /// <summary>
    ///   <para>rdfs:label : isRepresentationalElementIn</para>
    ///   <para>rdfs:comment : (x isRepresentationalElementIn y) == x acts as a representamen or referent in the cognitive step y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isRepresentationalElementIn">pimsii:isRepresentationalElementIn</a>
    /// </summary>
    let isRepresentationalElementIn = _prefixId.prefix "isRepresentationalElementIn"
    /// <summary>
    ///   <para>rdfs:label : isResolutionInPlanning</para>
    ///   <para>rdfs:comment : (x isResolutionInPlanning y) == y is a telesis carried out in advance of potentially undertaking an action, where x is the planning outcome, i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInPlanning">pimsii:isResolutionInPlanning</a>
    /// </summary>
    let isResolutionInPlanning = _prefixId.prefix "isResolutionInPlanning"
    /// <summary>
    ///   <para>rdfs:label : isResolutionInSteering</para>
    ///   <para>rdfs:comment : (x isResolutionInSteering y) == y is a steering operation (reflection in actu) where x is the resolution, i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInSteering">pimsii:isResolutionInSteering</a>
    /// </summary>
    let isResolutionInSteering = _prefixId.prefix "isResolutionInSteering"
    /// <summary>
    ///   <para>rdfs:label : isResolutionInTelesis</para>
    ///   <para>rdfs:comment : (x isResolutionInTelesis y) == y is a telesis where x acts as the resolution (a plan, revised objective, or other comparable sort of evaluation outcome), i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInTelesis">pimsii:isResolutionInTelesis</a>
    /// </summary>
    let isResolutionInTelesis = _prefixId.prefix "isResolutionInTelesis"
    /// <summary>
    ///   <para>rdfs:label : isResolutionInUndertaking</para>
    ///   <para>rdfs:comment : (x isResolutionInUndertaking y) == y is an undertaking where x is the resolution (obtained from a previous telesis), i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInUndertaking">pimsii:isResolutionInUndertaking</a>
    /// </summary>
    let isResolutionInUndertaking = _prefixId.prefix "isResolutionInUndertaking"
    /// <summary>
    ///   <para>skos:scopeNote : an outcome/result of a cognition must occur in the role of the interpretant somewhere within that cognition</para>
    ///   <para>skos:example : outcomes/results of a research process can be a research data set, one or multiple knowledge claims, or some combination thereof such as a FAIR digital object</para>
    ///   <para>skos:altLabel : \bar{R}</para>
    ///   <para>rdfs:label : isResultOf</para>
    ///   <para>rdfs:comment : (x isResultOf y) if x is an outcome/result of the cognitive process y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isResultOf">pimsii:isResultOf</a>
    /// </summary>
    let isResultOf = _prefixId.prefix "isResultOf"
    /// <summary>
    ///   <para>skos:altLabel : \ddot{E}_=</para>
    ///   <para>rdfs:label : isRightHandSideIn</para>
    ///   <para>rdfs:comment : (y isRightHandSideIn a) mans that a: x = y is an equality articulation with the term y as its right-hand side</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isRightHandSideIn">pimsii:isRightHandSideIn</a>
    /// </summary>
    let isRightHandSideIn = _prefixId.prefix "isRightHandSideIn"
    /// <summary>
    ///   <para>skos:altLabel : \ddot{E}</para>
    ///   <para>rdfs:label : isSecondElementIn</para>
    ///   <para>rdfs:comment : (x isSecondElementIn y) means that x acts as the second element in y, which is a triadic cognition</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSecondElementIn">pimsii:isSecondElementIn</a>
    /// </summary>
    let isSecondElementIn = _prefixId.prefix "isSecondElementIn"
    /// <summary>
    ///   <para>skos:altLabel : \ddot{E}_D</para>
    ///   <para>rdfs:label : isSecondInDyad</para>
    ///   <para>rdfs:comment : (y isSecondInDyad d) means that y is the second element of the dyad d^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSecondInDyad">pimsii:isSecondInDyad</a>
    /// </summary>
    let isSecondInDyad = _prefixId.prefix "isSecondInDyad"
    /// <summary>
    ///   <para>rdfs:label : isSelectionConditionIn</para>
    ///   <para>rdfs:comment : (x isSelectionConditionIn y) == in the selection process y, the condition x controls what constitutive element(s) of the input are retained as part of the output^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSelectionConditionIn">pimsii:isSelectionConditionIn</a>
    /// </summary>
    let isSelectionConditionIn = _prefixId.prefix "isSelectionConditionIn"
    /// <summary>
    ///   <para>rdfs:label : isSelectionInputIn</para>
    ///   <para>rdfs:comment : (x isSelectionInputIn y) == y is a selection where x is the input (initially given information), i.e., the first element; n.b., in a selection, the output needs to be constitutive of the input^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSelectionInputIn">pimsii:isSelectionInputIn</a>
    /// </summary>
    let isSelectionInputIn = _prefixId.prefix "isSelectionInputIn"
    /// <summary>
    ///   <para>rdfs:label : isSelectionOutputIn</para>
    ///   <para>rdfs:comment : (x isSelectionOutputIn y) == y is a selection where x is the output (retained information), i.e., the third element; n.b., in a selection, the output needs to be constitutive of the input^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSelectionOutputIn">pimsii:isSelectionOutputIn</a>
    /// </summary>
    let isSelectionOutputIn = _prefixId.prefix "isSelectionOutputIn"
    /// <summary>
    ///   <para>skos:altLabel : \ddot\leq</para>
    ///   <para>rdfs:label : isSemioticMemberOf</para>
    ///   <para>rdfs:comment : (x isSemioticMemberOf y) means that x acts as a representamen or as a referent jointly with other co-members of the same semiotic collective y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSemioticMemberOf">pimsii:isSemioticMemberOf</a>
    /// </summary>
    let isSemioticMemberOf = _prefixId.prefix "isSemioticMemberOf"
    /// <summary>
    ///   <para>skos:altLabel : \v{C}</para>
    ///   <para>rdfs:label : isSemioticallyConstitutiveOf</para>
    ///   <para>rdfs:comment : (x isSemioticallyConstitutiveOf y) means that the evaluation or association with x plays a role in the way in which y functions as a representamen - n.b, this does not entail physical parthood; e.g., if 'q = 2f(p)' is given, the expression 'f(p) = ... (some term involving q)' may be seen as semiotically constituive of the first expression, precisely because it contains the right-hand side that was missing^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSemioticallyConstitutiveOf">pimsii:isSemioticallyConstitutiveOf</a>
    /// </summary>
    let isSemioticallyConstitutiveOf = _prefixId.prefix "isSemioticallyConstitutiveOf"
    /// <summary>
    ///   <para>rdfs:label : isSignIn</para>
    ///   <para>rdfs:comment : (x isSignIn y) == y is a semiosis where x acts as the sign, i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSignIn">pimsii:isSignIn</a>
    /// </summary>
    let isSignIn = _prefixId.prefix "isSignIn"
    /// <summary>
    ///   <para>rdfs:label : isSignInInterpretation</para>
    ///   <para>rdfs:comment : (x isSignInInterpretation y) == y is an interpretation where x acts as the sign, i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSignInInterpretation">pimsii:isSignInInterpretation</a>
    /// </summary>
    let isSignInInterpretation = _prefixId.prefix "isSignInInterpretation"
    /// <summary>
    ///   <para>rdfs:label : isSignInInvestigation</para>
    ///   <para>rdfs:comment : (x isSignInInvestigation y) == y is an investigation-setup action where x acts as a representamen, i.e., the second element, both for the object of application (to which it is initially applied) and the object of investigation (to which it is reassigned such that the investigation can take place)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSignInInvestigation">pimsii:isSignInInvestigation</a>
    /// </summary>
    let isSignInInvestigation = _prefixId.prefix "isSignInInvestigation"
    /// <summary>
    ///   <para>rdfs:label : isSignInPerception</para>
    ///   <para>rdfs:comment : (x isSignInPerception y) == y is a perception where x acts as the sign, i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSignInPerception">pimsii:isSignInPerception</a>
    /// </summary>
    let isSignInPerception = _prefixId.prefix "isSignInPerception"
    /// <summary>
    ///   <para>rdfs:label : isSimulatedIn</para>
    ///   <para>rdfs:comment : (x isSimulatedIn y) == y is a simulation where x acts as the simulated object (system, substance, process, or similar), i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSimulatedIn">pimsii:isSimulatedIn</a>
    /// </summary>
    let isSimulatedIn = _prefixId.prefix "isSimulatedIn"
    /// <summary>
    ///   <para>rdfs:label : isSimulationInputIn</para>
    ///   <para>rdfs:comment : (x isSimulationInputIn y) == y is a simulation where x is the simulation input (model, etc.), i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSimulationInputIn">pimsii:isSimulationInputIn</a>
    /// </summary>
    let isSimulationInputIn = _prefixId.prefix "isSimulationInputIn"
    /// <summary>
    ///   <para>rdfs:label : isSimulationOutputIn</para>
    ///   <para>rdfs:comment : (x isSimulationOutputIn y) == y is a simulation where x is the simulation output (computed property, higher-level model, or similar), i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSimulationOutputIn">pimsii:isSimulationOutputIn</a>
    /// </summary>
    let isSimulationOutputIn = _prefixId.prefix "isSimulationOutputIn"
    /// <summary>
    ///   <para>rdfs:label : isSituationInPlanning</para>
    ///   <para>rdfs:comment : (x isSituationInPlanning y) == y is a telesis carried out in advance of potentially undertaking an action, where x is the perceived present situation, i.e., the second element, against which the telos is evaluated^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSituationInPlanning">pimsii:isSituationInPlanning</a>
    /// </summary>
    let isSituationInPlanning = _prefixId.prefix "isSituationInPlanning"
    /// <summary>
    ///   <para>rdfs:label : isSituationInUndertaking</para>
    ///   <para>rdfs:comment : (x isSituationInUndertaking y) == y is an undertaking wherein x is the pre-existing situation, i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSituationInUndertaking">pimsii:isSituationInUndertaking</a>
    /// </summary>
    let isSituationInUndertaking = _prefixId.prefix "isSituationInUndertaking"

    /// <summary>
    ///   <para>rdfs:label : isSpatiotemporallyConnectedWith</para>
    ///   <para>rdfs:comment : (x isSpatiotemporallyConnectedWith y) means that x and y overlap or are directly adjacent to each other at some point; i.e., there is a point p_x in x and a point p_y in y such that you can go from p_x to p_y without ever leaving the fusion (x U y)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSpatiotemporallyConnectedWith">pimsii:isSpatiotemporallyConnectedWith</a>
    /// </summary>
    let isSpatiotemporallyConnectedWith = _prefixId.prefix "isSpatiotemporallyConnectedWith"

    /// <summary>
    ///   <para>rdfs:label : isSpatiotemporallyDisconnectedFrom</para>
    ///   <para>rdfs:comment : (x isSpatiotemporallyDisconnectedFrom y) is the negation of (x isSpatiotemporallyConnectedWith y); i.e., to go from any point in x to any point in y, it is necessary to leave the fusion (x U y)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSpatiotemporallyDisconnectedFrom">pimsii:isSpatiotemporallyDisconnectedFrom</a>
    /// </summary>
    let isSpatiotemporallyDisconnectedFrom = _prefixId.prefix "isSpatiotemporallyDisconnectedFrom"

    /// <summary>
    ///   <para>rdfs:label : isSpeakerIn</para>
    ///   <para>rdfs:comment : (x isSpeakerIn y) means that x is (the only) speaker in the expressive act y, where the role of the speaker is to be understood as that of an agent that conducts/undertakes the expressive act, i.e., it is not limited to vocal speech</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSpeakerIn">pimsii:isSpeakerIn</a>
    /// </summary>
    let isSpeakerIn = _prefixId.prefix "isSpeakerIn"
    /// <summary>
    ///   <para>rdfs:label : isStepIn</para>
    ///   <para>rdfs:comment : (x isStepIn y) means that x and y are processes, where x is a proper part of y that plays a well-defined role within y (e.g., a task within a project, the execution of a single command within the execution of a program, etc.)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isStepIn">pimsii:isStepIn</a>
    /// </summary>
    let isStepIn = _prefixId.prefix "isStepIn"
    /// <summary>
    ///   <para>rdfs:label : isStepInCognitiveChain</para>
    ///   <para>rdfs:comment : (x isStepInCognitiveChain y) means that y is a cognitive chain that consists of multiple logically connected cognitive steps (following Peirce, these are typically triads, i.e., semioses and semantic changes), and that x is one of these steps^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isStepInCognitiveChain">pimsii:isStepInCognitiveChain</a>
    /// </summary>
    let isStepInCognitiveChain = _prefixId.prefix "isStepInCognitiveChain"
    /// <summary>
    ///   <para>rdfs:label : isSubjectWithinTriple</para>
    ///   <para>rdfs:comment : (x isSubjectWithinTriple y) means that y is a subject-predicate-object triple wherein x is the IRI of the subject^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isSubjectWithinTriple">pimsii:isSubjectWithinTriple</a>
    /// </summary>
    let isSubjectWithinTriple = _prefixId.prefix "isSubjectWithinTriple"
    /// <summary>
    ///   <para>skos:altLabel : \tilde{R}</para>
    ///   <para>rdfs:label : isTargetPropertyIn</para>
    ///   <para>rdfs:comment : (x isTargetPropertyIn y) means that cognitive action x targets y as the property for which a value is to be determined by observation or by theoretical or computational methods</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isTargetPropertyIn">pimsii:isTargetPropertyIn</a>
    /// </summary>
    let isTargetPropertyIn = _prefixId.prefix "isTargetPropertyIn"
    /// <summary>
    ///   <para>rdfs:label : isTelosIn</para>
    ///   <para>rdfs:comment : (x isTelosIn y) == y is a telesis where x acts as the telos (initial guiding objective), i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosIn">pimsii:isTelosIn</a>
    /// </summary>
    let isTelosIn = _prefixId.prefix "isTelosIn"
    /// <summary>
    ///   <para>rdfs:label : isTelosInEvaluation</para>
    ///   <para>rdfs:comment : (x isTelosInEvaluation y) == y is an evaluation (reflection ex post) where x acts as the telos (initial guiding objective), i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInEvaluation">pimsii:isTelosInEvaluation</a>
    /// </summary>
    let isTelosInEvaluation = _prefixId.prefix "isTelosInEvaluation"
    /// <summary>
    ///   <para>rdfs:label : isTelosInPlanning</para>
    ///   <para>rdfs:comment : (x isTelosInPlanning y) == y is a telesis carried out in advance of potentially undertaking an action, where x acts as the telos (initial guiding objective), i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInPlanning">pimsii:isTelosInPlanning</a>
    /// </summary>
    let isTelosInPlanning = _prefixId.prefix "isTelosInPlanning"
    /// <summary>
    ///   <para>rdfs:label : isTelosInSteering</para>
    ///   <para>rdfs:comment : (x isTelosInSteering y) == y is a steering operation (reflection in actu) where x acts as the telos (initial guiding objective), i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInSteering">pimsii:isTelosInSteering</a>
    /// </summary>
    let isTelosInSteering = _prefixId.prefix "isTelosInSteering"
    /// <summary>
    ///   <para>rdfs:label : Validation</para>
    ///   <para>rdfs:comment : (x isTelosInValidation y) means that y is a validation where x acts as the telos (initial guiding objective), i.e., the first element</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInValidation">pimsii:isTelosInValidation</a>
    /// </summary>
    let isTelosInValidation = _prefixId.prefix "isTelosInValidation"
    /// <summary>
    ///   <para>rdfs:label : isTemporallyConnectedWith</para>
    ///   <para>rdfs:comment : (x isTemporallyConnectedWith y) means that there is a point in time where both x and y exist^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isTemporallyConnectedWith">pimsii:isTemporallyConnectedWith</a>
    /// </summary>
    let isTemporallyConnectedWith = _prefixId.prefix "isTemporallyConnectedWith"
    /// <summary>
    ///   <para>rdfs:label : isTemporallyIncludedIn</para>
    ///   <para>rdfs:comment : (x isTemporallyIncludedIn y) means that the temporal extension of x is a proper part of the temporal extension of y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isTemporallyIncludedIn">pimsii:isTemporallyIncludedIn</a>
    /// </summary>
    let isTemporallyIncludedIn = _prefixId.prefix "isTemporallyIncludedIn"
    /// <summary>
    ///   <para>rdfs:label : isTerminalStepIn</para>
    ///   <para>rdfs:comment : (x isTerminalStepIn y) means that y is a step in x (i.e., a subprocess of x) that does not precede any other step^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isTerminalStepIn">pimsii:isTerminalStepIn</a>
    /// </summary>
    let isTerminalStepIn = _prefixId.prefix "isTerminalStepIn"
    /// <summary>
    ///   <para>skos:altLabel : \dddot{E}</para>
    ///   <para>rdfs:label : isThirdElementIn</para>
    ///   <para>rdfs:comment : (x isThirdElementIn y) means that x acts as the third element in y, which is a triadic cognition</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isThirdElementIn">pimsii:isThirdElementIn</a>
    /// </summary>
    let isThirdElementIn = _prefixId.prefix "isThirdElementIn"
    /// <summary>
    ///   <para>skos:altLabel : \ddot{P}_\epsilon</para>
    ///   <para>rdfs:label : isToolIn</para>
    ///   <para>rdfs:comment : (x isToolIn y) means that x is employed by an agent during the action y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isToolIn">pimsii:isToolIn</a>
    /// </summary>
    let isToolIn = _prefixId.prefix "isToolIn"
    /// <summary>
    ///   <para>skos:altLabel : \v{C}_T</para>
    ///   <para>rdfs:label : isTopicalFactorIn</para>
    ///   <para>rdfs:comment : (x isTopicalFactorIn y) means that x is combined with other subtopics into the topical proposition y, such that x and the other subtopics are not just standing beside each other, but exhibiting some meaningful interaction</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isTopicalFactorIn">pimsii:isTopicalFactorIn</a>
    /// </summary>
    let isTopicalFactorIn = _prefixId.prefix "isTopicalFactorIn"
    /// <summary>
    ///   <para>skos:scopeNote : If multiple topics are combined in a way that relates them closely to each other, with some meaningful interaction between them, the relation isTopicalFactorIn should be used, and the whole should then be a topical product, not a topical sum^^xsd:string</para>
    ///   <para>skos:altLabel : \lhd_T</para>
    ///   <para>rdfs:label : isTopicalSummandIn</para>
    ///   <para>rdfs:comment : (x isTopicalSummandIn y) means that x is one of the topics contained in y, a collection of topics that are not immediately closely related to each other</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isTopicalSummandIn">pimsii:isTopicalSummandIn</a>
    /// </summary>
    let isTopicalSummandIn = _prefixId.prefix "isTopicalSummandIn"
    /// <summary>
    ///   <para>skos:altLabel : 3</para>
    ///   <para>rdfs:label : isTriadOf</para>
    ///   <para>rdfs:comment : 'x isTriadOf (e1 e2 e3)' is a shorthand for 'e1 isFirstElementIn x; e2 isSecondElementIn x; e3 isThirdElementIn x'</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isTriadOf">pimsii:isTriadOf</a>
    /// </summary>
    let isTriadOf = _prefixId.prefix "isTriadOf"
    /// <summary>
    ///   <para>skos:altLabel : \v{C}_u</para>
    ///   <para>rdfs:label : isUnitOf</para>
    ///   <para>rdfs:comment : (x isUnitOf y) means that x is the unit of y, e.g., in 200 kPa, x would be kPa^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isUnitOf">pimsii:isUnitOf</a>
    /// </summary>
    let isUnitOf = _prefixId.prefix "isUnitOf"
    /// <summary>
    ///   <para>rdfs:label : isEvaluatedIn</para>
    ///   <para>rdfs:comment : (x isValidatedIn y) means that y is a validation where x is the cognitive action undergoing validation, i.e., the second element</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isValidatedIn">pimsii:isValidatedIn</a>
    /// </summary>
    let isValidatedIn = _prefixId.prefix "isValidatedIn"
    /// <summary>
    ///   <para>rdfs:label : isValidationOutcomeIn</para>
    ///   <para>rdfs:comment : (x isValidationOutcomeIn y) means that x is the validity claim, i.e., the third element, obtained as an interpretant from the validation y</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isValidationOutcomeIn">pimsii:isValidationOutcomeIn</a>
    /// </summary>
    let isValidationOutcomeIn = _prefixId.prefix "isValidationOutcomeIn"
    /// <summary>
    ///   <para>skos:altLabel : \ddot{D}</para>
    ///   <para>rdfs:label : isValueInAssignment</para>
    ///   <para>rdfs:comment : (y isValueInAssignment a) mans that a: x = y is an assignment where the value y is assigned to a variable x^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isValueInAssignment">pimsii:isValueInAssignment</a>
    /// </summary>
    let isValueInAssignment = _prefixId.prefix "isValueInAssignment"
    /// <summary>
    ///   <para>skos:altLabel : \dot{D}</para>
    ///   <para>rdfs:label : isVariableInAssignment</para>
    ///   <para>rdfs:comment : (x isVariableInAssignment a) mans that a: x = y is an assignment where a value y is assigned to the variable x^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isVariableInAssignment">pimsii:isVariableInAssignment</a>
    /// </summary>
    let isVariableInAssignment = _prefixId.prefix "isVariableInAssignment"
    /// <summary>
    ///   <para>rdfs:label : isVisualizationInputIn</para>
    ///   <para>rdfs:comment : (x isVisualizationInputIn y) == y is a visualization process where x is the input (a pre-existing representamen for the visualized object, e.g., a simulation result), i.e., the first element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isVisualizationInputIn">pimsii:isVisualizationInputIn</a>
    /// </summary>
    let isVisualizationInputIn = _prefixId.prefix "isVisualizationInputIn"
    /// <summary>
    ///   <para>rdfs:label : isVisualizationOutputIn</para>
    ///   <para>rdfs:comment : (x isVisualizationOutputIn y) == y is a visualization where x is the visualization output, i.e., the third element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isVisualizationOutputIn">pimsii:isVisualizationOutputIn</a>
    /// </summary>
    let isVisualizationOutputIn = _prefixId.prefix "isVisualizationOutputIn"
    /// <summary>
    ///   <para>rdfs:label : isVisualizedObjectIn</para>
    ///   <para>rdfs:comment : (x isVisualizedObjectIn y) == y is a visualization process wherein x is the visualized object, i.e., the second element^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#isVisualizedObjectIn">pimsii:isVisualizedObjectIn</a>
    /// </summary>
    let isVisualizedObjectIn = _prefixId.prefix "isVisualizedObjectIn"
    /// <summary>
    ///   <para>skos:scopeNote : 'logicallyPrecedes' is the transitive closure of 'directlyGrounds'</para>
    ///   <para>skos:altLabel : \hookrightarrow^+</para>
    ///   <para>rdfs:label : logicallyPrecedes</para>
    ///   <para>rdfs:comment : (x logicallyPrecedes y) means that x and y are cognitive steps that are connected by a cognitive chain, leading from x and y, that does not contain a cognitive rupture</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#logicallyPrecedes">pimsii:logicallyPrecedes</a>
    /// </summary>
    let logicallyPrecedes = _prefixId.prefix "logicallyPrecedes"
    /// <summary>
    ///   <para>rdfs:label : msHPHR</para>
    ///   <para>rdfs:comment : (X msHPHR Z) == hasProperPart o hasRepresentamen == there is a Y such that (Y isProperPartOf X) and (Z isRepresentamenFor Y)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHR">pimsii:msHPHR</a>
    /// </summary>
    let msHPHR = _prefixId.prefix "msHPHR"
    /// <summary>
    ///   <para>rdfs:label : msHPHRHP</para>
    ///   <para>rdfs:comment : chain relation msHPHR o hasProperPart^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHP">pimsii:msHPHRHP</a>
    /// </summary>
    let msHPHRHP = _prefixId.prefix "msHPHRHP"
    /// <summary>
    ///   <para>rdfs:label : msHPHRHPIP</para>
    ///   <para>rdfs:comment : chain relation msHPHR o overlapsWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHPIP">pimsii:msHPHRHPIP</a>
    /// </summary>
    let msHPHRHPIP = _prefixId.prefix "msHPHRHPIP"
    /// <summary>
    ///   <para>rdfs:label : msHPHRHR</para>
    ///   <para>rdfs:comment : chain relation msHPHR o hasRepresentamen^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHR">pimsii:msHPHRHR</a>
    /// </summary>
    let msHPHRHR = _prefixId.prefix "msHPHRHR"
    /// <summary>
    ///   <para>rdfs:label : msHPHRIP</para>
    ///   <para>rdfs:comment : chain relation msHPHR o hasProperPart^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRIP">pimsii:msHPHRIP</a>
    /// </summary>
    let msHPHRIP = _prefixId.prefix "msHPHRIP"
    /// <summary>
    ///   <para>rdfs:label : msHPHRIR</para>
    ///   <para>rdfs:comment : chain relation hasProperPart o sharesRepresentamenWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRIR">pimsii:msHPHRIR</a>
    /// </summary>
    let msHPHRIR = _prefixId.prefix "msHPHRIR"
    /// <summary>
    ///   <para>rdfs:label : msHPIPHR</para>
    ///   <para>rdfs:comment : (X msHPIPHR Z) == hasProperPart o isProperPartOf o hasRepresentamen == there is a Y such that (X overlapsWith Y) and (Z isRepresentamenFor Y)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHR">pimsii:msHPIPHR</a>
    /// </summary>
    let msHPIPHR = _prefixId.prefix "msHPIPHR"
    /// <summary>
    ///   <para>rdfs:label : msHPIPHRHP</para>
    ///   <para>rdfs:comment : chain relation overlapsWith o msHRHP^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRHP">pimsii:msHPIPHRHP</a>
    /// </summary>
    let msHPIPHRHP = _prefixId.prefix "msHPIPHRHP"
    /// <summary>
    ///   <para>rdfs:label : msHPIPHRHR</para>
    ///   <para>rdfs:comment : chain relation overlapsWith o msHRHR^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRHR">pimsii:msHPIPHRHR</a>
    /// </summary>
    let msHPIPHRHR = _prefixId.prefix "msHPIPHRHR"
    /// <summary>
    ///   <para>rdfs:label : msHPIPHRIP</para>
    ///   <para>rdfs:comment : chain relation overlapsWith o msHRIP^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRIP">pimsii:msHPIPHRIP</a>
    /// </summary>
    let msHPIPHRIP = _prefixId.prefix "msHPIPHRIP"
    /// <summary>
    ///   <para>rdfs:label : msHPIPHRIR</para>
    ///   <para>rdfs:comment : chain relation overlapsWith o sharesRepresentamenWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRIR">pimsii:msHPIPHRIR</a>
    /// </summary>
    let msHPIPHRIR = _prefixId.prefix "msHPIPHRIR"
    /// <summary>
    ///   <para>rdfs:label : msHPIPIR</para>
    ///   <para>rdfs:comment : (X msHPIPIR Z) == hasProperPart o isProperPartOf o isRepresentamenFor == there is a Y such that (X overlapsWith Y) and (Y isRepresentamenFor Z)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIR">pimsii:msHPIPIR</a>
    /// </summary>
    let msHPIPIR = _prefixId.prefix "msHPIPIR"
    /// <summary>
    ///   <para>rdfs:label : msHPIPIRHP</para>
    ///   <para>rdfs:comment : chain relation overlapsWith o msIRHP^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRHP">pimsii:msHPIPIRHP</a>
    /// </summary>
    let msHPIPIRHP = _prefixId.prefix "msHPIPIRHP"
    /// <summary>
    ///   <para>rdfs:label : msHPIPIRHR</para>
    ///   <para>rdfs:comment : chain relation overlapsWith o sharesReferentWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRHR">pimsii:msHPIPIRHR</a>
    /// </summary>
    let msHPIPIRHR = _prefixId.prefix "msHPIPIRHR"
    /// <summary>
    ///   <para>rdfs:label : msHPIPIRIP</para>
    ///   <para>rdfs:comment : chain relation overlapsWith o msIRIP^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRIP">pimsii:msHPIPIRIP</a>
    /// </summary>
    let msHPIPIRIP = _prefixId.prefix "msHPIPIRIP"
    /// <summary>
    ///   <para>rdfs:label : msHPIPIRIR</para>
    ///   <para>rdfs:comment : chain relation overlapsWith o msIRIR^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRIR">pimsii:msHPIPIRIR</a>
    /// </summary>
    let msHPIPIRIR = _prefixId.prefix "msHPIPIRIR"
    /// <summary>
    ///   <para>rdfs:label : msHPIR</para>
    ///   <para>rdfs:comment : (X msHPIR Z) == hasProperPart o isRepresentamenFor == there is a Y such that (Y isProperPartOf X) and (Y is RepresentamenFor Z)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIR">pimsii:msHPIR</a>
    /// </summary>
    let msHPIR = _prefixId.prefix "msHPIR"
    /// <summary>
    ///   <para>rdfs:label : msIPIRHP</para>
    ///   <para>rdfs:comment : chain relation msHPIR o hasProperPart^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHP">pimsii:msHPIRHP</a>
    /// </summary>
    let msHPIRHP = _prefixId.prefix "msHPIRHP"
    /// <summary>
    ///   <para>rdfs:label : msHPIRHPIP</para>
    ///   <para>rdfs:comment : chain relation msHPIR o overlapsWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHPIP">pimsii:msHPIRHPIP</a>
    /// </summary>
    let msHPIRHPIP = _prefixId.prefix "msHPIRHPIP"
    /// <summary>
    ///   <para>rdfs:label : msHPIRHR</para>
    ///   <para>rdfs:comment : chain relation hasProperPart o sharesReferentWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHR">pimsii:msHPIRHR</a>
    /// </summary>
    let msHPIRHR = _prefixId.prefix "msHPIRHR"
    /// <summary>
    ///   <para>rdfs:label : msHPIRIP</para>
    ///   <para>rdfs:comment : chain relation msHPIR o isProperPartOf^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRIP">pimsii:msHPIRIP</a>
    /// </summary>
    let msHPIRIP = _prefixId.prefix "msHPIRIP"
    /// <summary>
    ///   <para>rdfs:label : msHPIRIR</para>
    ///   <para>rdfs:comment : chain relation msHPIR o isRepresentamenFor^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRIR">pimsii:msHPIRIR</a>
    /// </summary>
    let msHPIRIR = _prefixId.prefix "msHPIRIR"
    /// <summary>
    ///   <para>rdfs:label : msHRHP</para>
    ///   <para>rdfs:comment : (X msHRHP Z) == hasRepresentamen o hasProperPart == there is a Y such that (Y isRepresentamenFor X) and (Z isProperPartOf Y)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHP">pimsii:msHRHP</a>
    /// </summary>
    let msHRHP = _prefixId.prefix "msHRHP"
    /// <summary>
    ///   <para>rdfs:label : msHRHPHR</para>
    ///   <para>rdfs:comment : chain relation msHRHP o hasRepresentamen^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPHR">pimsii:msHRHPHR</a>
    /// </summary>
    let msHRHPHR = _prefixId.prefix "msHRHPHR"
    /// <summary>
    ///   <para>rdfs:label : msHRHPIP</para>
    ///   <para>rdfs:comment : (X msHRHPIP Z) == hasRepresentamen o hasProperPart o isProperPartOf == there is a Y such that (Y isRepresentamenFor X) and (Y overlapsWith Z)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIP">pimsii:msHRHPIP</a>
    /// </summary>
    let msHRHPIP = _prefixId.prefix "msHRHPIP"
    /// <summary>
    ///   <para>rdfs:label : msHRHPIPHR</para>
    ///   <para>rdfs:comment : chain relation msHRHP o msIPHR^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIPHR">pimsii:msHRHPIPHR</a>
    /// </summary>
    let msHRHPIPHR = _prefixId.prefix "msHRHPIPHR"
    /// <summary>
    ///   <para>rdfs:label : msHRHPIPIR</para>
    ///   <para>rdfs:comment : chain relation msHRHP o msIPIR^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIPIR">pimsii:msHRHPIPIR</a>
    /// </summary>
    let msHRHPIPIR = _prefixId.prefix "msHRHPIPIR"
    /// <summary>
    ///   <para>rdfs:label : msHRHPIR</para>
    ///   <para>rdfs:comment : chain relation msHRHP o isRepresentamenFor^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIR">pimsii:msHRHPIR</a>
    /// </summary>
    let msHRHPIR = _prefixId.prefix "msHRHPIR"
    /// <summary>
    ///   <para>rdfs:label : msHRHR</para>
    ///   <para>rdfs:comment : (X msHRHR Z) == (hasRepresentamen)^2 == there is a Y such that (Y isRepresentamenFor X) and (Z isRepresentamenFor Y)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHR">pimsii:msHRHR</a>
    /// </summary>
    let msHRHR = _prefixId.prefix "msHRHR"
    /// <summary>
    ///   <para>rdfs:label : msHRHRHP</para>
    ///   <para>rdfs:comment : chain relation msHRHR o hasProperPart^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHP">pimsii:msHRHRHP</a>
    /// </summary>
    let msHRHRHP = _prefixId.prefix "msHRHRHP"
    /// <summary>
    ///   <para>rdfs:label : msHRHRHPIP</para>
    ///   <para>rdfs:comment : chain relation msHRHR o overlapsWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHPIP">pimsii:msHRHRHPIP</a>
    /// </summary>
    let msHRHRHPIP = _prefixId.prefix "msHRHRHPIP"
    /// <summary>
    ///   <para>rdfs:label : msHRHRHR</para>
    ///   <para>rdfs:comment : chain relation msHRHR o hasRepresentamen^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHR">pimsii:msHRHRHR</a>
    /// </summary>
    let msHRHRHR = _prefixId.prefix "msHRHRHR"
    /// <summary>
    ///   <para>rdfs:label : msHRHRIP</para>
    ///   <para>rdfs:comment : chain relation msHRHR o isProperPartOf^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRIP">pimsii:msHRHRIP</a>
    /// </summary>
    let msHRHRIP = _prefixId.prefix "msHRHRIP"
    /// <summary>
    ///   <para>rdfs:label : msHRHRIR</para>
    ///   <para>rdfs:comment : chain relation hasRepresentamen o sharesRepresentamenWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRIR">pimsii:msHRHRIR</a>
    /// </summary>
    let msHRHRIR = _prefixId.prefix "msHRHRIR"
    /// <summary>
    ///   <para>rdfs:label : msHRIP</para>
    ///   <para>rdfs:comment : (X msHRIP Z) == hasRepresentamen o isProperPartOf == there is a Y such that (Y isRepresentamenFor X) and (Y isProperPartOf Z)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIP">pimsii:msHRIP</a>
    /// </summary>
    let msHRIP = _prefixId.prefix "msHRIP"
    /// <summary>
    ///   <para>rdfs:label : msHRIPHR</para>
    ///   <para>rdfs:comment : chain relation msHRIP o hasRepresentamen^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIPHR">pimsii:msHRIPHR</a>
    /// </summary>
    let msHRIPHR = _prefixId.prefix "msHRIPHR"
    /// <summary>
    ///   <para>rdfs:label : msHRIPIR</para>
    ///   <para>rdfs:comment : chain relation msHRIP o isRepresentamenFor^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIPIR">pimsii:msHRIPIR</a>
    /// </summary>
    let msHRIPIR = _prefixId.prefix "msHRIPIR"
    /// <summary>
    ///   <para>rdfs:label : msHRIRHP</para>
    ///   <para>rdfs:comment : chain relation sharesRepresentamenWith o hasProperPart^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHP">pimsii:msHRIRHP</a>
    /// </summary>
    let msHRIRHP = _prefixId.prefix "msHRIRHP"
    /// <summary>
    ///   <para>rdfs:label : msHRIRHPIP</para>
    ///   <para>rdfs:comment : chain relation sharesRepresentamenWith o overlapsWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHPIP">pimsii:msHRIRHPIP</a>
    /// </summary>
    let msHRIRHPIP = _prefixId.prefix "msHRIRHPIP"
    /// <summary>
    ///   <para>rdfs:label : msHRIRHR</para>
    ///   <para>rdfs:comment : chain relation hasRepresentamen o sharesReferentWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHR">pimsii:msHRIRHR</a>
    /// </summary>
    let msHRIRHR = _prefixId.prefix "msHRIRHR"
    /// <summary>
    ///   <para>rdfs:label : msHRIRIP</para>
    ///   <para>rdfs:comment : chain relation sharesRepresentamenWith o isProperPartOf^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRIP">pimsii:msHRIRIP</a>
    /// </summary>
    let msHRIRIP = _prefixId.prefix "msHRIRIP"
    /// <summary>
    ///   <para>rdfs:label : msHRIRIR</para>
    ///   <para>rdfs:comment : chain relation sharesRepresentamenWith o isRepresentamenFor^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRIR">pimsii:msHRIRIR</a>
    /// </summary>
    let msHRIRIR = _prefixId.prefix "msHRIRIR"
    /// <summary>
    ///   <para>rdfs:label : msIPHR</para>
    ///   <para>rdfs:comment : (X msIPHR Z) == isProperPartOf o hasRepresentamen == there is a Y such that (X isProperPartOf Y) and (Z isRepresentamenFor Y)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHR">pimsii:msIPHR</a>
    /// </summary>
    let msIPHR = _prefixId.prefix "msIPHR"
    /// <summary>
    ///   <para>rdfs:label : msIPHRHP</para>
    ///   <para>rdfs:comment : chain relation msIPHR o hasProperPart^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHP">pimsii:msIPHRHP</a>
    /// </summary>
    let msIPHRHP = _prefixId.prefix "msIPHRHP"
    /// <summary>
    ///   <para>rdfs:label : msIPHRHPIP</para>
    ///   <para>rdfs:comment : chain relation msIPHR o overlapsWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHPIP">pimsii:msIPHRHPIP</a>
    /// </summary>
    let msIPHRHPIP = _prefixId.prefix "msIPHRHPIP"
    /// <summary>
    ///   <para>rdfs:label : msIPHRHR</para>
    ///   <para>rdfs:comment : chain relation msIPHR o hasRepresentamen^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHR">pimsii:msIPHRHR</a>
    /// </summary>
    let msIPHRHR = _prefixId.prefix "msIPHRHR"
    /// <summary>
    ///   <para>rdfs:label : msIPHRIP</para>
    ///   <para>rdfs:comment : chain relation msIPHR o isProperPartOf^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRIP">pimsii:msIPHRIP</a>
    /// </summary>
    let msIPHRIP = _prefixId.prefix "msIPHRIP"
    /// <summary>
    ///   <para>rdfs:label : msIPHRIR</para>
    ///   <para>rdfs:comment : chain relation isProperPartOf o sharesRepresentamenWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRIR">pimsii:msIPHRIR</a>
    /// </summary>
    let msIPHRIR = _prefixId.prefix "msIPHRIR"
    /// <summary>
    ///   <para>rdfs:label : msIPIR</para>
    ///   <para>rdfs:comment : (X msIP Z) == isProperPartOf o isRepresentamenFor == there is a Y such that (X isProperPartOf Y) and (Y isRepresentamenFor Z)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIR">pimsii:msIPIR</a>
    /// </summary>
    let msIPIR = _prefixId.prefix "msIPIR"
    /// <summary>
    ///   <para>rdfs:label : msIPIRHP</para>
    ///   <para>rdfs:comment : chain relation msIPIR o hasProperPart^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHP">pimsii:msIPIRHP</a>
    /// </summary>
    let msIPIRHP = _prefixId.prefix "msIPIRHP"
    /// <summary>
    ///   <para>rdfs:label : msIPIRHPIP</para>
    ///   <para>rdfs:comment : chain relation msIPIR o overlapsWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHPIP">pimsii:msIPIRHPIP</a>
    /// </summary>
    let msIPIRHPIP = _prefixId.prefix "msIPIRHPIP"
    /// <summary>
    ///   <para>rdfs:label : msIPIRHR</para>
    ///   <para>rdfs:comment : chain relation isProperPartOf o sharesReferentWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHR">pimsii:msIPIRHR</a>
    /// </summary>
    let msIPIRHR = _prefixId.prefix "msIPIRHR"
    /// <summary>
    ///   <para>rdfs:label : msIPIRIP</para>
    ///   <para>rdfs:comment : chain relation msIPIR o isProperPartOf^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRIP">pimsii:msIPIRIP</a>
    /// </summary>
    let msIPIRIP = _prefixId.prefix "msIPIRIP"
    /// <summary>
    ///   <para>rdfs:label : msIPIRIR</para>
    ///   <para>rdfs:comment : chain relation msIPIR o isRepresentamenFor^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRIR">pimsii:msIPIRIR</a>
    /// </summary>
    let msIPIRIR = _prefixId.prefix "msIPIRIR"
    /// <summary>
    ///   <para>rdfs:label : msIRHP</para>
    ///   <para>rdfs:comment : (X msIRHP Z) == isRepresentamenFor o hasProperPart == there is a Y such that (X isRepresentamenFor Y) and (Z isProperPartOf Y)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHP">pimsii:msIRHP</a>
    /// </summary>
    let msIRHP = _prefixId.prefix "msIRHP"
    /// <summary>
    ///   <para>rdfs:label : msIRHPHR</para>
    ///   <para>rdfs:comment : chain relation msIRHP o hasRepresentamen^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPHR">pimsii:msIRHPHR</a>
    /// </summary>
    let msIRHPHR = _prefixId.prefix "msIRHPHR"
    /// <summary>
    ///   <para>rdfs:label : msIRHPIP</para>
    ///   <para>rdfs:comment : (X msIRHPIP Z) == isRepresentamenFor o hasProperPart o isProperPartOf == there is a Y such that (X isRepresentamenFor Y) and (Y overlapsWith Z)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIP">pimsii:msIRHPIP</a>
    /// </summary>
    let msIRHPIP = _prefixId.prefix "msIRHPIP"
    /// <summary>
    ///   <para>rdfs:label : msIRHPIPHR</para>
    ///   <para>rdfs:comment : chain relation msIRHP o msIPHR^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIPHR">pimsii:msIRHPIPHR</a>
    /// </summary>
    let msIRHPIPHR = _prefixId.prefix "msIRHPIPHR"
    /// <summary>
    ///   <para>rdfs:label : msIRHPIPIR</para>
    ///   <para>rdfs:comment : chain relation msIRHP o msIPIR^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIPIR">pimsii:msIRHPIPIR</a>
    /// </summary>
    let msIRHPIPIR = _prefixId.prefix "msIRHPIPIR"
    /// <summary>
    ///   <para>rdfs:label : msIRHPIR</para>
    ///   <para>rdfs:comment : chain relation msIRHP o isRepresentamenFor^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIR">pimsii:msIRHPIR</a>
    /// </summary>
    let msIRHPIR = _prefixId.prefix "msIRHPIR"
    /// <summary>
    ///   <para>rdfs:label : msIRHRHP</para>
    ///   <para>rdfs:comment : chain relation sharesReferentWith o hasProperPart^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHP">pimsii:msIRHRHP</a>
    /// </summary>
    let msIRHRHP = _prefixId.prefix "msIRHRHP"
    /// <summary>
    ///   <para>rdfs:label : msIRHRHPIP</para>
    ///   <para>rdfs:comment : chain relation sharesReferentWith o overlapsWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHPIP">pimsii:msIRHRHPIP</a>
    /// </summary>
    let msIRHRHPIP = _prefixId.prefix "msIRHRHPIP"
    /// <summary>
    ///   <para>rdfs:label : msIRHRHR</para>
    ///   <para>rdfs:comment : chain relation sharesReferentWith o hasRepresentamen^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHR">pimsii:msIRHRHR</a>
    /// </summary>
    let msIRHRHR = _prefixId.prefix "msIRHRHR"
    /// <summary>
    ///   <para>rdfs:label : msIRHRIP</para>
    ///   <para>rdfs:comment : chain relation sharesReferentWith o isProperPartOf^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRIP">pimsii:msIRHRIP</a>
    /// </summary>
    let msIRHRIP = _prefixId.prefix "msIRHRIP"
    /// <summary>
    ///   <para>rdfs:label : msHRIRHR</para>
    ///   <para>rdfs:comment : chain relation sharesReferentWith o isRepresentamenFor^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRIR">pimsii:msIRHRIR</a>
    /// </summary>
    let msIRHRIR = _prefixId.prefix "msIRHRIR"
    /// <summary>
    ///   <para>rdfs:label : msIRIP</para>
    ///   <para>rdfs:comment : (X msIRIP Z) == isRepresentamenFor o isProperPartOf == there is a Y such that (X isRepresentamenFor Y) and (Y isProperPartOf Z)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIP">pimsii:msIRIP</a>
    /// </summary>
    let msIRIP = _prefixId.prefix "msIRIP"
    /// <summary>
    ///   <para>rdfs:label : msIRIPHR</para>
    ///   <para>rdfs:comment : chain relation msIRIP o hasRepresentamen^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIPHR">pimsii:msIRIPHR</a>
    /// </summary>
    let msIRIPHR = _prefixId.prefix "msIRIPHR"
    /// <summary>
    ///   <para>rdfs:label : msIRIPIR</para>
    ///   <para>rdfs:comment : chain relation msIRIP o isRepresentamenFor^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIPIR">pimsii:msIRIPIR</a>
    /// </summary>
    let msIRIPIR = _prefixId.prefix "msIRIPIR"
    /// <summary>
    ///   <para>rdfs:label : msIRIR</para>
    ///   <para>rdfs:comment : (X msIRIR Z) == (isRepresentamenFor)^2 == there is a Y such that (X isRepresentamenFor Y) and (Y isRepresentamenFor Z)^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIR">pimsii:msIRIR</a>
    /// </summary>
    let msIRIR = _prefixId.prefix "msIRIR"
    /// <summary>
    ///   <para>rdfs:label : msIRIRHP</para>
    ///   <para>rdfs:comment : chain relation msIRIR o hasProperPart^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHP">pimsii:msIRIRHP</a>
    /// </summary>
    let msIRIRHP = _prefixId.prefix "msIRIRHP"
    /// <summary>
    ///   <para>rdfs:label : msIRIRHPIP</para>
    ///   <para>rdfs:comment : chain relation msIRIR o overlapsWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHPIP">pimsii:msIRIRHPIP</a>
    /// </summary>
    let msIRIRHPIP = _prefixId.prefix "msIRIRHPIP"
    /// <summary>
    ///   <para>rdfs:label : msIRIRHR</para>
    ///   <para>rdfs:comment : chain relation isRepresentamenFor o sharesReferentWith^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHR">pimsii:msIRIRHR</a>
    /// </summary>
    let msIRIRHR = _prefixId.prefix "msIRIRHR"
    /// <summary>
    ///   <para>rdfs:label : msIRIRIP</para>
    ///   <para>rdfs:comment : chain relation msIRIR o isProperPartOf^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRIP">pimsii:msIRIRIP</a>
    /// </summary>
    let msIRIRIP = _prefixId.prefix "msIRIRIP"
    /// <summary>
    ///   <para>rdfs:label : msIRIRIR</para>
    ///   <para>rdfs:comment : chain relation msIRIR o isRepresentamenFor^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRIR">pimsii:msIRIRIR</a>
    /// </summary>
    let msIRIRIR = _prefixId.prefix "msIRIRIR"
    /// <summary>
    ///   <para>rdfs:label : overlapsWith</para>
    ///   <para>rdfs:comment : (x overlapsWith y) means that x and y share a spatiotemporal region where x and y intersect^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#overlapsWith">pimsii:overlapsWith</a>
    /// </summary>
    let overlapsWith = _prefixId.prefix "overlapsWith"
    /// <summary>
    ///   <para>rdfs:label : precedesStep</para>
    ///   <para>rdfs:comment : 'precedesStep' is the transitive closure of 'directlyPrecedesStep'; (x precedesStep y) means that the processes x and y are, possibly indirectly, causally connected such that x needs to be concluded before y can commence^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#precedesStep">pimsii:precedesStep</a>
    /// </summary>
    let precedesStep = _prefixId.prefix "precedesStep"
    /// <summary>
    ///   <para>rdfs:label : providesJustification</para>
    ///   <para>rdfs:comment : (x providesJustification y) means that x is about some cognition z, providing a justification of it by referring to y, i.e., a grounding chain that establishes the epistemic status of z; thereby, x does not only affirm z, but also its grounding chain y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#providesJustification">pimsii:providesJustification</a>
    /// </summary>
    let providesJustification = _prefixId.prefix "providesJustification"
    /// <summary>
    ///   <para>rdfs:label : realizes</para>
    ///   <para>rdfs:comment : (x realizes y) means that x, which is not a semiotic collective, is a literal or non-literal realization of the expression y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#realizes">pimsii:realizes</a>
    /// </summary>
    let realizes = _prefixId.prefix "realizes"
    /// <summary>
    ///   <para>rdfs:label : sharesReferentWith</para>
    ///   <para>rdfs:comment : (X sharesReferentWith Z) == there is a Y such that both X and Z isRepresentamenFor Y^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#sharesReferentWith">pimsii:sharesReferentWith</a>
    /// </summary>
    let sharesReferentWith = _prefixId.prefix "sharesReferentWith"
    /// <summary>
    ///   <para>rdfs:label : sharesRepresentamenWith</para>
    ///   <para>rdfs:comment : (X sharesRepresentamenWith Z) == there is a Y such that Y isRepresentamenFor both X and Z^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#sharesRepresentamenWith">pimsii:sharesRepresentamenWith</a>
    /// </summary>
    let sharesRepresentamenWith = _prefixId.prefix "sharesRepresentamenWith"
    /// <summary>
    ///   <para>rdfs:label : temporallyCoextendsWith</para>
    ///   <para>rdfs:comment : (x temporallyCoextendsWith y) means that x and y have exactly the same extension in time, i.e., disregarding their spatial extension^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#temporallyCoextendsWith">pimsii:temporallyCoextendsWith</a>
    /// </summary>
    let temporallyCoextendsWith = _prefixId.prefix "temporallyCoextendsWith"
    /// <summary>
    ///   <para>rdfs:label : temporallyOverlapsWith</para>
    ///   <para>rdfs:comment : (x temporallyOverlapsWith y) means that there is an (extended) interval in time where both x and y exist^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#temporallyOverlapsWith">pimsii:temporallyOverlapsWith</a>
    /// </summary>
    let temporallyOverlapsWith = _prefixId.prefix "temporallyOverlapsWith"
    /// <summary>
    ///   <para>rdfs:label : temporallyPrecedes</para>
    ///   <para>rdfs:comment : (x temporallyPrecedes y) means that every point in x is earlier in time than every point in y; the spacetime regions x and y may be connected, but they cannot overlap temporally^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#temporallyPrecedes">pimsii:temporallyPrecedes</a>
    /// </summary>
    let temporallyPrecedes = _prefixId.prefix "temporallyPrecedes"
    /// <summary>
    ///   <para>rdfs:label : underlies</para>
    ///   <para>rdfs:comment : the relation 'underlies' is the transitive closure of the relation 'isConstitutiveOf'^^xsd:string</para>
    ///   <a href="http://www.molmod.info/semantics/pims-ii.ttl#underlies">pimsii:underlies</a>
    /// </summary>
    let underlies = _prefixId.prefix "underlies"
