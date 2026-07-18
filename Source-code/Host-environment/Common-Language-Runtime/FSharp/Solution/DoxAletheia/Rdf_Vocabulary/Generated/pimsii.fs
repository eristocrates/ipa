namespace http.www.molmod.info.semantics.pims_ii.ttl.hash

open DoxAletheia.Rdf_Vocabulary

module pimsii =
    let _namespace_name = "http://www.molmod.info/semantics/pims-ii.ttl#"

    /// <summary>
    /// Absolute law, i.e., a law where the necessary entailment of the consequent(s) by the antecedent is expressed in terms of absolute logical/physical necessity
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#AbsoluteLaw"></see></summary>
    let AbsoluteLaw =
        Namespaced_IRI.parse _namespace_name "AbsoluteLaw" |> NamespacedName

    /// <summary>
    /// Law, i.e., a proposition consisting of an antecedent and one or multiple consequent(s) such that the antecedent is stated to necessarily imply the consequent(s)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Law"></see></summary>
    let Law = Namespaced_IRI.parse _namespace_name "Law" |> NamespacedName

    /// <summary>
    /// Absolute modal IRI, i.e., the IRI of a relation that is defined by absolute necessity or possibility of another relation. Absolute necessity means 'logical or physical necessity', and absolute possibility means 'logical or physical possibility'. Accordingly, absolute modal relations do not require the specification of a modal context, i.e., the frame of reference for understanding what 'necessity' and 'possibility' mean does not need to be specified.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#AbsoluteModalIRI"></see></summary>
    let AbsoluteModalIRI =
        Namespaced_IRI.parse _namespace_name "AbsoluteModalIRI" |> NamespacedName

    /// <summary>
    /// Modal IRI, i.e., the IRI of a relation that is defined by (absolute or qualified) necessity or possibility of another relation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ModalIRI"></see></summary>
    let ModalIRI = Namespaced_IRI.parse _namespace_name "ModalIRI" |> NamespacedName

    /// <summary>
    /// Abstract model property claim (CMPC), i.e., a model property claim that is not immediately applied to the corresponding property of a real physical system
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#AbstractModelPropertyClaim"></see></summary>
    let AbstractModelPropertyClaim =
        Namespaced_IRI.parse _namespace_name "AbstractModelPropertyClaim" |> NamespacedName

    /// <summary>
    /// Model property claim (MPC), i.e., a PC concerning a property of a model
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ModelPropertyClaim"></see></summary>
    let ModelPropertyClaim =
        Namespaced_IRI.parse _namespace_name "ModelPropertyClaim" |> NamespacedName

    /// <summary>
    /// Accumulation, i.e., an information-processing step in which the given information is extended/complemented such that the input (sign) and one or multiple additional representamina (cf. relation isIncludedInAccumulation) are jointly constitutive of the output (interpretant); this includes conditional accumulation, where the choice and the way in which information is combined depends on an accumulation condition (cf. relation isAccumulationConditionIn)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Accumulation"></see></summary>
    let Accumulation =
        Namespaced_IRI.parse _namespace_name "Accumulation" |> NamespacedName

    /// <summary>
    /// Object (PIMS-II top class) = cognizable entity
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName

    /// <summary>
    /// (x isAccumulationInputIn y) == y is an accumulation where x is the input (initially given information), i.e., the first element; n.b., in an accumulation, the input needs to be constitutive of the output
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationInputIn"></see></summary>
    let isAccumulationInputIn =
        Namespaced_IRI.parse _namespace_name "isAccumulationInputIn" |> NamespacedName

    /// <summary>
    /// (x isObjectInAccumulation y) == y is an accumulation where x is the object that the input and the output both represent, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInAccumulation"></see></summary>
    let isObjectInAccumulation =
        Namespaced_IRI.parse _namespace_name "isObjectInAccumulation" |> NamespacedName

    /// <summary>
    /// (x isAccumulationOutputIn y) == y is an accumulation where x is the output (combined information), i.e., the third element; n.b., in a selection, the input and any additionally included elements need to be constitutive of the output
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationOutputIn"></see></summary>
    let isAccumulationOutputIn =
        Namespaced_IRI.parse _namespace_name "isAccumulationOutputIn" |> NamespacedName

    /// <summary>
    /// (x isIncludedInAccumulation y) == y is an accumulation where x is combined with the accumulation input, yielding an output that x is constitutive of; n.b., x needs to act as a representamen for the object (e.g., as an interpretant from a preceding cognitive step with the same object)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isIncludedInAccumulation"></see></summary>
    let isIncludedInAccumulation =
        Namespaced_IRI.parse _namespace_name "isIncludedInAccumulation" |> NamespacedName

    /// <summary>
    /// Information processing, i.e., an interpretation in which information is handled, revised, reformatted, extended, or narrowed down (or anything comparable to such actions), e.g., preprocessing or postprocessing in a simulation workflow
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#InformationProcessing"></see></summary>
    let InformationProcessing =
        Namespaced_IRI.parse _namespace_name "InformationProcessing" |> NamespacedName

    /// <summary>
    /// Action, i.e., a process that is conducted/undertaken by an agent - the action has exactly one agent
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    /// Agent, i.e., an object that interacts with its surroundings by a) perceiving and b) doing, i.e., an object that carries out actions, including perceptive actions
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    /// (x isAgentIn y) means that x is *the* agent that conducts/undertakes the action y; n.b., an action has exactly one agent (which can be a straightforward item, or a plurality, a structure, or similar)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAgentIn"></see></summary>
    let isAgentIn = Namespaced_IRI.parse _namespace_name "isAgentIn" |> NamespacedName
    /// <summary>
    /// Process, i.e., a connected region that has at least one participant, an entity with which it overlaps spatiotemporally and that plays a certain role in the process
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Process"></see></summary>
    let Process = Namespaced_IRI.parse _namespace_name "Process" |> NamespacedName

    /// <summary>
    /// Articulation (collective expression), i.e., a semiotic collective the semiotic members (i.e., realizations) of which are not semiotic collectives, but individual literal (written or digital) or non-literal (e.g., spoken) items with the same semiotic function (or undergoing evaluation whether such a function is present)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Articulation"></see></summary>
    let Articulation =
        Namespaced_IRI.parse _namespace_name "Articulation" |> NamespacedName

    /// <summary>
    /// (x realizes y) means that x, which is not a semiotic collective, is a literal or non-literal realization of the expression y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#realizes"></see></summary>
    let realizes = Namespaced_IRI.parse _namespace_name "realizes" |> NamespacedName

    /// <summary>
    /// Semiotic collective, i.e., a collective the semiotic members of which act together as one representational element (i.e., referent or representamen) in a cognitive process
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#SemioticCollective"></see></summary>
    let SemioticCollective =
        Namespaced_IRI.parse _namespace_name "SemioticCollective" |> NamespacedName

    /// <summary>
    /// (x isSemioticMemberOf y) means that x acts as a representamen or as a referent jointly with other co-members of the same semiotic collective y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSemioticMemberOf"></see></summary>
    let isSemioticMemberOf =
        Namespaced_IRI.parse _namespace_name "isSemioticMemberOf" |> NamespacedName

    /// <summary>
    /// Assessment (of a cognitive step), i.e., a ground that provides an explanation including a proposition on the extent (quantitatively or qualitatively) to which the grounded cognitive step is reliable/accurate/valid (or similar), why that is the case, and how that relates to the reliability/accuracy/etc. of the preceding step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Assessment"></see></summary>
    let Assessment = Namespaced_IRI.parse _namespace_name "Assessment" |> NamespacedName
    /// <summary>
    /// Ground (of a cognitive step), i.e., a proposition that justifies a cognitive step by explaning it and stating from what preceding step (which directly grounds that step) a sign-object relation is carried over, and in what way
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Ground"></see></summary>
    let Ground = Namespaced_IRI.parse _namespace_name "Ground" |> NamespacedName

    /// <summary>
    /// Cognitive step, i.e., an elementary cognition that can form an part of a cognitive chain
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveStep"></see></summary>
    let CognitiveStep =
        Namespaced_IRI.parse _namespace_name "CognitiveStep" |> NamespacedName

    /// <summary>
    /// (g isAssessmentFor y) means that g is a ground for the cognitive step y, explaining how y is grounded in a way that provides a proposition on its validity, accuracy, and/or reliability, relating it to that of the previous step that directly grounds y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAssessmentFor"></see></summary>
    let isAssessmentFor =
        Namespaced_IRI.parse _namespace_name "isAssessmentFor" |> NamespacedName

    /// <summary>
    /// Assignment, i.e., an equality articulation by which a value is assigned to a variable with respect to a particular referent (e.g., T = 200 K for substance o as it was measured in a particular cognitive step); therein, T is the variable, related to the assignment by [inverseOf isVariableInAssignment], 200 K is the value, related to the assignment by [inverseOf isValueInAssignment], and o is the referent, related to the assignment by isAssignmentFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Assignment"></see></summary>
    let Assignment = Namespaced_IRI.parse _namespace_name "Assignment" |> NamespacedName
    /// <summary>
    /// Variable, i.e., a conventional that is employed for something to which values can be assigned (this may include different notations for the same variable including, e.g., computational representations); this is to be understood very generally, e.g., a variable may be an array or set of elements or have another kind of internal structure
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Variable"></see></summary>
    let Variable = Namespaced_IRI.parse _namespace_name "Variable" |> NamespacedName

    /// <summary>
    /// (x isVariableInAssignment a) mans that a: x = y is an assignment where a value y is assigned to the variable x
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isVariableInAssignment"></see></summary>
    let isVariableInAssignment =
        Namespaced_IRI.parse _namespace_name "isVariableInAssignment" |> NamespacedName

    /// <summary>
    /// Value, i.e., an articulation that is by social convention understood to be potentially assignable to a variable
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Value"></see></summary>
    let Value = Namespaced_IRI.parse _namespace_name "Value" |> NamespacedName

    /// <summary>
    /// (y isValueInAssignment a) mans that a: x = y is an assignment where the value y is assigned to a variable x
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isValueInAssignment"></see></summary>
    let isValueInAssignment =
        Namespaced_IRI.parse _namespace_name "isValueInAssignment" |> NamespacedName

    /// <summary>
    /// (d isAssignmentFor o) means that d: x = y is an assignment that refers to o
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAssignmentFor"></see></summary>
    let isAssignmentFor =
        Namespaced_IRI.parse _namespace_name "isAssignmentFor" |> NamespacedName

    /// <summary>
    /// Digital conventional, i.e., a conventional that is a digital articulation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#DigitalConventional"></see></summary>
    let DigitalConventional =
        Namespaced_IRI.parse _namespace_name "DigitalConventional" |> NamespacedName

    /// <summary>
    /// Equality articulation, i.e., a dyad by which two terms are asserted to be equal or to become equal
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#EqualityArticulation"></see></summary>
    let EqualityArticulation =
        Namespaced_IRI.parse _namespace_name "EqualityArticulation" |> NamespacedName

    /// <summary>
    /// Basic ground, i.e., a ground that is assumed to be valid and reliable a priori; a cognitive step for which there is a basic ground is a presupposition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#BasicGround"></see></summary>
    let BasicGround =
        Namespaced_IRI.parse _namespace_name "BasicGround" |> NamespacedName

    /// <summary>
    /// (g isGroundFor y) means that g is a representamen for the cognitive step y, explaining how y is grounded
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundFor"></see></summary>
    let isGroundFor =
        Namespaced_IRI.parse _namespace_name "isGroundFor" |> NamespacedName

    /// <summary>
    /// Presupposition, i.e., a cognition that has a basic ground, so that it is accepted a priori as an ultimate anchor point for epistemic grounding; any cognition that is logically preceded by a presupposition is a grounded cognition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Presupposition"></see></summary>
    let Presupposition =
        Namespaced_IRI.parse _namespace_name "Presupposition" |> NamespacedName

    /// <summary>
    /// Canonical TUCAN, i.e., the material identifier as developed within the NFDI4Chem project
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CanonicalTUCAN"></see></summary>
    let CanonicalTUCAN =
        Namespaced_IRI.parse _namespace_name "CanonicalTUCAN" |> NamespacedName

    /// <summary>
    /// Name or label that identifies the material of its referent, or the material that some semiotic collective is about
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#MaterialIdentifier"></see></summary>
    let MaterialIdentifier =
        Namespaced_IRI.parse _namespace_name "MaterialIdentifier" |> NamespacedName

    /// <summary>
    /// Claim, i.e., a proposition that is expressed by an interlocutor or believed/held by an intelligent agent
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Claim"></see></summary>
    let Claim = Namespaced_IRI.parse _namespace_name "Claim" |> NamespacedName

    /// <summary>
    /// Proposition, i.e., a semiotic collective the members of which are collective literals and collective utterances understood to be attributed some joint semantic and/or pragmatic content, or undergoing evaluation jointly for the presence of such a content
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Proposition"></see></summary>
    let Proposition =
        Namespaced_IRI.parse _namespace_name "Proposition" |> NamespacedName

    /// <summary>
    /// Interlocutor, i.e., an agent that can be addressed and is capable of addressing others in a communication process
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Interlocutor"></see></summary>
    let Interlocutor =
        Namespaced_IRI.parse _namespace_name "Interlocutor" |> NamespacedName

    /// <summary>
    /// (x isAssertedBy y) means that x is a claim that is affirmatively expressed/stated/uttered by the interlocutor y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAssertedBy"></see></summary>
    let isAssertedBy =
        Namespaced_IRI.parse _namespace_name "isAssertedBy" |> NamespacedName

    /// <summary>
    /// Intelligent agent, i.e., a goal-oriented agent that can internally make/hold claims (knowledge, beliefs, etc.). This requires the agent to have some kind of internal representation of its surroundings, and to store and process information about its surroundings. (Note that this does not require the agent to be queryable for its claims; for that purpose, use KnowledgeBase.)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#IntelligentAgent"></see></summary>
    let IntelligentAgent =
        Namespaced_IRI.parse _namespace_name "IntelligentAgent" |> NamespacedName

    /// <summary>
    /// (x isClaimOf y) means that the x is a proposition that has some kind of belief-like or knowledge-like epistemic status for the intelligent agent y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isClaimOf"></see></summary>
    let isClaimOf = Namespaced_IRI.parse _namespace_name "isClaimOf" |> NamespacedName
    /// <summary>
    /// Cognition, i.e., a process dealing with representamina (signs) consisting either of a single cognitive step, of multiple steps that are connected to each other as a cognitive chain, or of an anchor point for epistemic grounding
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Cognition"></see></summary>
    let Cognition = Namespaced_IRI.parse _namespace_name "Cognition" |> NamespacedName

    /// <summary>
    /// Cognitive chain, i.e., a cognition that consists of multiple (sub)steps
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveChain"></see></summary>
    let CognitiveChain =
        Namespaced_IRI.parse _namespace_name "CognitiveChain" |> NamespacedName

    /// <summary>
    /// Cognitive action, i.e., a cognition that is conducted/undertaken by an agent; the agent of a cognitive action is called its interpreter
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveAction"></see></summary>
    let CognitiveAction =
        Namespaced_IRI.parse _namespace_name "CognitiveAction" |> NamespacedName

    /// <summary>
    /// (x isInterpreterIn y) means that x is the (unique) agent who conducts/undertakes the cognitive action y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpreterIn"></see></summary>
    let isInterpreterIn =
        Namespaced_IRI.parse _namespace_name "isInterpreterIn" |> NamespacedName

    /// <summary>
    /// (x isStepInCognitiveChain y) means that y is a cognitive chain that consists of multiple logically connected cognitive steps (following Peirce, these are typically triads, i.e., semioses and semantic changes), and that x is one of these steps
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isStepInCognitiveChain"></see></summary>
    let isStepInCognitiveChain =
        Namespaced_IRI.parse _namespace_name "isStepInCognitiveChain" |> NamespacedName

    /// <summary>
    /// Cognitive rupture, i.e., a cognitive step that constitutes a break in the chain of epistemic grounding
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveRupture"></see></summary>
    let CognitiveRupture =
        Namespaced_IRI.parse _namespace_name "CognitiveRupture" |> NamespacedName

    /// <summary>
    /// Metonymization, i.e., a semantic change where there is a causal connection between the old and the new referent, so that the criterion of a 'real causal connection' (between signs and objects) from Peircean semiotics is preserved
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Metonymization"></see></summary>
    let Metonymization =
        Namespaced_IRI.parse _namespace_name "Metonymization" |> NamespacedName

    /// <summary>
    /// Semiosis, i.e., a triadic congition that relates 'the sign', 'the object', and 'the interpretant' to each other; a semiosis is either a perception (if the object needs to be present and participate physically in the process) or an interpretation (if the physical participation of the object is not inherently necessary)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Semiosis"></see></summary>
    let Semiosis = Namespaced_IRI.parse _namespace_name "Semiosis" |> NamespacedName

    /// <summary>
    /// Cognitive workflow, i.e., a purposefully conducted cognitive chain
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveWorkflow"></see></summary>
    let CognitiveWorkflow =
        Namespaced_IRI.parse _namespace_name "CognitiveWorkflow" |> NamespacedName

    /// <summary>
    /// Purposeful action, i.e., an action carried out with an aim of which its agent (hence, a goal-directed agent) is aware
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#PurposefulAction"></see></summary>
    let PurposefulAction =
        Namespaced_IRI.parse _namespace_name "PurposefulAction" |> NamespacedName

    /// <summary>
    /// Collective, i.e., an object that has multiple items as members
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Collective"></see></summary>
    let Collective = Namespaced_IRI.parse _namespace_name "Collective" |> NamespacedName
    /// <summary>
    /// membership relation, i.e., relation between an item/member and a collective
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMemberOf"></see></summary>
    let isMemberOf = Namespaced_IRI.parse _namespace_name "isMemberOf" |> NamespacedName

    /// <summary>
    /// Mereotopological collective, i.e., a region of spacetime that consists of multiple connected components, which are its mereotopological members
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#MereotopologicalCollective"></see></summary>
    let MereotopologicalCollective =
        Namespaced_IRI.parse _namespace_name "MereotopologicalCollective" |> NamespacedName

    /// <summary>
    /// Collective literal, i.e., a semiotic collective the members of which all have a digital, printed, or written textual/numerical form in that they are all instances/copies of the same RDFS literal (or multiple RDFS literals that are very similar, e.g., different ways of spelling/abbreviating the same word or denoting the same number); n.b., collective literals are not permitted to have other semiotic collectives as their semiotic members
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CollectiveLiteral"></see></summary>
    let CollectiveLiteral =
        Namespaced_IRI.parse _namespace_name "CollectiveLiteral" |> NamespacedName

    /// <summary>
    /// Collective utterance, i.e., a semiotic collective the members of which do not have digital, printed, or written textual/numerical form and the members of which are all attributed the same semantics and pragmatics; n.b., collective utterances are not permitted to have other semiotic collectives as their semiotic members
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CollectiveUtterance"></see></summary>
    let CollectiveUtterance =
        Namespaced_IRI.parse _namespace_name "CollectiveUtterance" |> NamespacedName

    /// <summary>
    /// points to the expression of a collective literal as an RDFS literal (e.g., xs:string or xs:decimal)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isLiterally"></see></summary>
    let isLiterally =
        Namespaced_IRI.parse _namespace_name "isLiterally" |> NamespacedName

    /// <summary>
    /// Communication, i.e., a cognitive process wherein multiple interlocutors engage in an exchange with another; a communication involves at least one expressive act (with a well defined role, i.e. in terms of participation)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Communication"></see></summary>
    let Communication =
        Namespaced_IRI.parse _namespace_name "Communication" |> NamespacedName

    /// <summary>
    /// (x isInterlocutorIn y) means that x engages, jointly with other interlocutors, in the communication y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInterlocutorIn"></see></summary>
    let isInterlocutorIn =
        Namespaced_IRI.parse _namespace_name "isInterlocutorIn" |> NamespacedName

    /// <summary>
    /// Expressive act, i.e., a purposeful communication (e.g., a speech act or an analogous digital act of communicating) issued by its agent, the speaker (understood in a generalized sense, i.e., not limited to speech) - the purpose of the action consists of its illocutionary and perlocutionary intent
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ExpressiveAct"></see></summary>
    let ExpressiveAct =
        Namespaced_IRI.parse _namespace_name "ExpressiveAct" |> NamespacedName

    /// <summary>
    /// (x isParticipantIn y) means that y is a process in which x plays a certain role (e.g., x is a well-defined step within y, or x is an object that undergoes some change within y, or x is a sign that is read or an object that is perceived within y); this requires a spatiotemporal overlap between x and y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isParticipantIn"></see></summary>
    let isParticipantIn =
        Namespaced_IRI.parse _namespace_name "isParticipantIn" |> NamespacedName

    /// <summary>
    /// Conceptual IRI, i.e., the internationalized resource identifier of a concept (i.e., of an owl:Class)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ConceptualIRI"></see></summary>
    let ConceptualIRI =
        Namespaced_IRI.parse _namespace_name "ConceptualIRI" |> NamespacedName

    /// <summary>
    /// Internationalized resource identifier (IRI) as defined by RFC 3987; an IRI object should be related by 'isLiterally' to an xs:string containing the IRI literal
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#IRI"></see></summary>
    let IRI = Namespaced_IRI.parse _namespace_name "IRI" |> NamespacedName

    /// <summary>
    /// Relational IRI, i.e., the internationalized resource identifier of a something that can play the role of the predicate in a triple; this includes 'rdf:type', object properties, datatype properties, their negations
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#RelationalIRI"></see></summary>
    let RelationalIRI =
        Namespaced_IRI.parse _namespace_name "RelationalIRI" |> NamespacedName

    /// <summary>
    /// Conceptual knowledge claim (CKC), i.e., a knowledge claim establishing the ontological status of a lexeme
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ConceptualKnowledgeClaim"></see></summary>
    let ConceptualKnowledgeClaim =
        Namespaced_IRI.parse _namespace_name "ConceptualKnowledgeClaim" |> NamespacedName

    /// <summary>
    /// Knowledge claim (KC), i.e., a claim about something with respect to its knowledge status
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeClaim"></see></summary>
    let KnowledgeClaim =
        Namespaced_IRI.parse _namespace_name "KnowledgeClaim" |> NamespacedName

    /// <summary>
    /// Property claim (PC), i.e., a knowledge claim concerning a property
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#PropertyClaim"></see></summary>
    let PropertyClaim =
        Namespaced_IRI.parse _namespace_name "PropertyClaim" |> NamespacedName

    /// <summary>
    /// Concrete model property claim (CMPC), i.e., a model property claim that is immediately also applied to the corresponding property of a real physical system
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ConcreteModelPropertyClaim"></see></summary>
    let ConcreteModelPropertyClaim =
        Namespaced_IRI.parse _namespace_name "ConcreteModelPropertyClaim" |> NamespacedName

    /// <summary>
    /// Physical property claim (PPC), i.e., a PC concerning a property of a physical system
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#PhysicalPropertyClaim"></see></summary>
    let PhysicalPropertyClaim =
        Namespaced_IRI.parse _namespace_name "PhysicalPropertyClaim" |> NamespacedName

    /// <summary>
    /// Contextual IRI, i.e., the internationalized resource identifier of a modal context, i.e., the frame of reference for a qualified-modal semiotic collective; that context defines how exactly necessity and possibility are to be understood
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ContextualIRI"></see></summary>
    let ContextualIRI =
        Namespaced_IRI.parse _namespace_name "ContextualIRI" |> NamespacedName

    /// <summary>
    /// Conventional, i.e., a semiotic collective articulation the members of which jointly fulfill a certain semiotic function by social convention; e.g., many spoken or written occurrences of the words 'enthalpy of vaporization' or 'latent heat' may act together as a property in this sense
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Conventional"></see></summary>
    let Conventional =
        Namespaced_IRI.parse _namespace_name "Conventional" |> NamespacedName

    /// <summary>
    /// Dyadic representation relation; (x isRepresentamenFor y) means that there is a cognitive step z such that (x isRepresentamenIn z) and (y isReferentIn z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isRepresentamenFor"></see></summary>
    let isRepresentamenFor =
        Namespaced_IRI.parse _namespace_name "isRepresentamenFor" |> NamespacedName

    /// <summary>
    /// Data item, i.e., a digital articulation given as a tuple of digital conventionals
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#DataItem"></see></summary>
    let DataItem = Namespaced_IRI.parse _namespace_name "DataItem" |> NamespacedName

    /// <summary>
    /// (x isSemioticallyConstitutiveOf y) means that the evaluation or association with x plays a role in the way in which y functions as a representamen - n.b, this does not entail physical parthood; e.g., if 'q = 2f(p)' is given, the expression 'f(p) = ... (some term involving q)' may be seen as semiotically constituive of the first expression, precisely because it contains the right-hand side that was missing
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSemioticallyConstitutiveOf"></see></summary>
    let isSemioticallyConstitutiveOf =
        Namespaced_IRI.parse _namespace_name "isSemioticallyConstitutiveOf" |> NamespacedName

    /// <summary>
    /// Digital articulation, i.e., an articulation the members of which are copies of the same digital content (a file, assignment of a value to a variable, a data set, etc.)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#DigitalArticulation"></see></summary>
    let DigitalArticulation =
        Namespaced_IRI.parse _namespace_name "DigitalArticulation" |> NamespacedName

    /// <summary>
    /// Dataset, i.e., a digital articulation that is composed of multiple data items that are similar in shape, kind, and content type
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    /// Duplication, i.e., an information-processing step in which the given information is reproduced, copied, converted into a different, but equivalent format, or any similar procedure; e.g., this may be based on a legisign to which the original (sign) and the duplicate (interpretant) jointly conform or on a semiotic collective of which they both semiotic members
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Duplication"></see></summary>
    let Duplication =
        Namespaced_IRI.parse _namespace_name "Duplication" |> NamespacedName

    /// <summary>
    /// (x isOriginalIn y) == y is a duplication step where x is the input (original version), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOriginalIn"></see></summary>
    let isOriginalIn =
        Namespaced_IRI.parse _namespace_name "isOriginalIn" |> NamespacedName

    /// <summary>
    /// (x isObjectInDuplication y) == y is a duplication step where x is the object that the original and the duplicate both represent, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInDuplication"></see></summary>
    let isObjectInDuplication =
        Namespaced_IRI.parse _namespace_name "isObjectInDuplication" |> NamespacedName

    /// <summary>
    /// (x isDuplicateIn y) == y is a duplication step where x is the output (duplicate), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isDuplicateIn"></see></summary>
    let isDuplicateIn =
        Namespaced_IRI.parse _namespace_name "isDuplicateIn" |> NamespacedName

    /// <summary>
    /// Dyad, i.e., a data item by which two conventionals are grouped together; e.g., an equality or inequality articulation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Dyad"></see></summary>
    let Dyad = Namespaced_IRI.parse _namespace_name "Dyad" |> NamespacedName

    /// <summary>
    /// (x isFirstInDyad d) means that x is the first element of the dyad d
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isFirstInDyad"></see></summary>
    let isFirstInDyad =
        Namespaced_IRI.parse _namespace_name "isFirstInDyad" |> NamespacedName

    /// <summary>
    /// (y isSecondInDyad d) means that y is the second element of the dyad d
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSecondInDyad"></see></summary>
    let isSecondInDyad =
        Namespaced_IRI.parse _namespace_name "isSecondInDyad" |> NamespacedName

    /// <summary>
    /// EPRC, i.e., an exact-agreement provenance-conscious reproducibility claim
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#EPRC"></see></summary>
    let EPRC = Namespaced_IRI.parse _namespace_name "EPRC" |> NamespacedName

    /// <summary>
    /// Exact-agreement reproducibility claim (ERC), i.e., a reproducibility claim obtained as an outcome of an attempt at obtaining exactly the same outcome as the original study
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ExactAgreementReproducibilityClaim"></see></summary>
    let ExactAgreementReproducibilityClaim =
        Namespaced_IRI.parse _namespace_name "ExactAgreementReproducibilityClaim" |> NamespacedName

    /// <summary>
    /// Provenance-conscious reproducibility claim (PRC), i.e., a reproducibility claim obtained from an attempt that was subject to the requirement to retain the original research process or aspects of it
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ProvenanceConsciousReproducibilityClaim"></see></summary>
    let ProvenanceConsciousReproducibilityClaim =
        Namespaced_IRI.parse _namespace_name "ProvenanceConsciousReproducibilityClaim" |> NamespacedName

    /// <summary>
    /// EPTRC, i.e., an exact-agreement provenance-conscious team-change reproducibility claim
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#EPTRC"></see></summary>
    let EPTRC = Namespaced_IRI.parse _namespace_name "EPTRC" |> NamespacedName
    /// <summary>
    /// ETRC, i.e., an exact-agreement team-change reproducibility claim
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ETRC"></see></summary>
    let ETRC = Namespaced_IRI.parse _namespace_name "ETRC" |> NamespacedName
    /// <summary>
    /// PTRC, i.e., a provenance-conscious team-change reproducibility claim
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#PTRC"></see></summary>
    let PTRC = Namespaced_IRI.parse _namespace_name "PTRC" |> NamespacedName

    /// <summary>
    /// Team-change reproducibility claim (TRC), i.e., a reproducibility claim obtained as an outcome of a reproducibility study conducted by an independent team
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#TeamChangeReproducibilityClaim"></see></summary>
    let TeamChangeReproducibilityClaim =
        Namespaced_IRI.parse _namespace_name "TeamChangeReproducibilityClaim" |> NamespacedName

    /// <summary>
    /// Term, i.e., a conventional that can evaluate to a value; terms include variables, values, and any mathematically and semantically valid ways of combining variables, values, and mathematical operators - note that it is required for a term to potentially take a value
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Term"></see></summary>
    let Term = Namespaced_IRI.parse _namespace_name "Term" |> NamespacedName

    /// <summary>
    /// (x isLeftHandSideIn a) mans that a: x = y is an equality articulation with the term x as its left-hand side
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isLeftHandSideIn"></see></summary>
    let isLeftHandSideIn =
        Namespaced_IRI.parse _namespace_name "isLeftHandSideIn" |> NamespacedName

    /// <summary>
    /// (y isRightHandSideIn a) mans that a: x = y is an equality articulation with the term y as its right-hand side
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isRightHandSideIn"></see></summary>
    let isRightHandSideIn =
        Namespaced_IRI.parse _namespace_name "isRightHandSideIn" |> NamespacedName

    /// <summary>
    /// Evaluation, i.e., a reflection ex post (Reflexion des Vollzugs following Baumann and Tulatz) or redetermination, carried out after an action has terminated, either by the same agent or by somebody else
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Evaluation"></see></summary>
    let Evaluation = Namespaced_IRI.parse _namespace_name "Evaluation" |> NamespacedName

    /// <summary>
    /// (x isTelosInEvaluation y) == y is an evaluation (reflection ex post) where x acts as the telos (initial guiding objective), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInEvaluation"></see></summary>
    let isTelosInEvaluation =
        Namespaced_IRI.parse _namespace_name "isTelosInEvaluation" |> NamespacedName

    /// <summary>
    /// (x isEvaluatedIn y) == y is an evaluation (reflection ex post) where x is the action undergoing evaluation, i.e., the second element; n.b., the action needs to temporally precede the evaluation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isEvaluatedIn"></see></summary>
    let isEvaluatedIn =
        Namespaced_IRI.parse _namespace_name "isEvaluatedIn" |> NamespacedName

    /// <summary>
    /// Telesis (teleological semiosis), i.e., a semiosis where the sign is a telos (aim), the object is an action, claim, or situation against which that aim is evaluated, and the interpretant is a resolution, e.g., a revised objective, plan, or similar evaluation outcome
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Telesis"></see></summary>
    let Telesis = Namespaced_IRI.parse _namespace_name "Telesis" |> NamespacedName

    /// <summary>
    /// (x isEvaluationOutcomeIn y) == y is a an evaluation (reflection ex post) where x is the resolution (evaluation outcome), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isEvaluationOutcomeIn"></see></summary>
    let isEvaluationOutcomeIn =
        Namespaced_IRI.parse _namespace_name "isEvaluationOutcomeIn" |> NamespacedName

    /// <summary>
    /// Undertaking, i.e., a metonymization by which a resolution, which was previously determined (by telesis) in response to the pre-existing situation, is actively taken up by the agent, motivating an action
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Undertaking"></see></summary>
    let Undertaking =
        Namespaced_IRI.parse _namespace_name "Undertaking" |> NamespacedName

    /// <summary>
    /// (x directlyGrounds y) == x is the cognitive step (or basic ground) that directly precedes y logically, such that a dyadic representation relation from y is taken over from x (or assumed to be grounded a priori due to x)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#directlyGrounds"></see></summary>
    let directlyGrounds =
        Namespaced_IRI.parse _namespace_name "directlyGrounds" |> NamespacedName

    /// <summary>
    /// 'Goal-directed agents are intelligent agents that have an internal representation of the goals they [tend to] achieve' (Conte, doi:10.1007/978-1-4614-1800-9_158, 2009)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GoalDirectedAgent"></see></summary>
    let GoalDirectedAgent =
        Namespaced_IRI.parse _namespace_name "GoalDirectedAgent" |> NamespacedName

    /// <summary>
    /// (x isEvaluatorIn y) means that y is an evaluation and x is the interpreter in it
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isEvaluatorIn"></see></summary>
    let isEvaluatorIn =
        Namespaced_IRI.parse _namespace_name "isEvaluatorIn" |> NamespacedName

    /// <summary>
    /// Interpretation, i.e., a semiosis where the sign-object relation is carried over from the preceding cognitive step, without the need for the represented object to be present physically
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Interpretation"></see></summary>
    let Interpretation =
        Namespaced_IRI.parse _namespace_name "Interpretation" |> NamespacedName

    /// <summary>
    /// Reproducibility claim (RC), i.e., a validity claim obtained as an outcome of a reproduction attempt/reproducibility study
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ReproducibilityClaim"></see></summary>
    let ReproducibilityClaim =
        Namespaced_IRI.parse _namespace_name "ReproducibilityClaim" |> NamespacedName

    /// <summary>
    /// Examination (by pattern matching &amp; similar), i.e., an observation by which a legisign (specifying patterns or rules) is applied to an examined object, yielding an examination outcome that expresses in what way or to what extent the object matches the legisign
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Examination"></see></summary>
    let Examination =
        Namespaced_IRI.parse _namespace_name "Examination" |> NamespacedName

    /// <summary>
    /// (x isLegisignIn y) == y is an examination where x is applied to an object as a legisign, i.e., the first element, specifying patterns or rules the compliance with which is being assessed
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isLegisignIn"></see></summary>
    let isLegisignIn =
        Namespaced_IRI.parse _namespace_name "isLegisignIn" |> NamespacedName

    /// <summary>
    /// (x isExaminedIn y) == y is an examination where x acts as the examined object, i.e., the second element, for which it is assessed to what extent (in which way, under what additional conditions, etc.) it conforms with the legisign
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isExaminedIn"></see></summary>
    let isExaminedIn =
        Namespaced_IRI.parse _namespace_name "isExaminedIn" |> NamespacedName

    /// <summary>
    /// (x isExaminationOutcomeIn y) == y is an examination where x is the examination outcome, i.e., the third element (e.g., yes the object agrees with the legisign, or it does so under this or that condition, etc.)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isExaminationOutcomeIn"></see></summary>
    let isExaminationOutcomeIn =
        Namespaced_IRI.parse _namespace_name "isExaminationOutcomeIn" |> NamespacedName

    /// <summary>
    /// Observation, i.e., a perception by which characteristic aspects of an object (e.g., a target property or some more complex kind of behaviour) are purposefully investigated through specific means of perception; the procedure and evaluation may occur based on subjective judgement or according to an agreed procedure
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Observation"></see></summary>
    let Observation =
        Namespaced_IRI.parse _namespace_name "Observation" |> NamespacedName

    /// <summary>
    /// experimental workflow, i.e., a cognition that is purposefully conducted in a controlled environment and has at least one measurement as a step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ExperimentalWorkflow"></see></summary>
    let ExperimentalWorkflow =
        Namespaced_IRI.parse _namespace_name "ExperimentalWorkflow" |> NamespacedName

    /// <summary>
    /// Measurement, i.e., an observation that follows a standard procedure, so that it can be expected to yield an objective (rather than subjective) outcome
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Measurement"></see></summary>
    let Measurement =
        Namespaced_IRI.parse _namespace_name "Measurement" |> NamespacedName

    /// <summary>
    /// (x isSpeakerIn y) means that x is (the only) speaker in the expressive act y, where the role of the speaker is to be understood as that of an agent that conducts/undertakes the expressive act, i.e., it is not limited to vocal speech
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSpeakerIn"></see></summary>
    let isSpeakerIn =
        Namespaced_IRI.parse _namespace_name "isSpeakerIn" |> NamespacedName

    /// <summary>
    /// Intention, i.e., a proposition that constitutes an aim or goal
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Intention"></see></summary>
    let Intention = Namespaced_IRI.parse _namespace_name "Intention" |> NamespacedName
    /// <summary>
    /// (x isGoalFor y) means that to the goal-directed agent y, the telos x represents something that is to be reached.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isGoalFor"></see></summary>
    let isGoalFor = Namespaced_IRI.parse _namespace_name "isGoalFor" |> NamespacedName

    /// <summary>
    /// Goal-oriented agent, i.e., an agent that exhibits the tendency 'to achieve a certain state of the world' (Conte, doi:10.1007/978-1-4614-1800-9_158, 2009)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GoalOrientedAgent"></see></summary>
    let GoalOrientedAgent =
        Namespaced_IRI.parse _namespace_name "GoalOrientedAgent" |> NamespacedName

    /// <summary>
    /// (x isGoalOf y) means that y is a goal-oriented agent with the tendency to work toward a state of affairs that is described/represented by y; accordingly, the goal y is also a representamen for the agent itself; this does *not* imply that the agent x is aware of pursuing y as a goal, or that y is somehow included in x as a mental representation - for that purpose, use the relation 'isGoalFor'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isGoalOf"></see></summary>
    let isGoalOf = Namespaced_IRI.parse _namespace_name "isGoalOf" |> NamespacedName

    /// <summary>
    /// Grounded cognition, i.e., a cognition that is logically preceded by a presupposition such that there is a grounding chain establishing its epistemic status as a grounded cognition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GroundedCognition"></see></summary>
    let GroundedCognition =
        Namespaced_IRI.parse _namespace_name "GroundedCognition" |> NamespacedName

    /// <summary>
    /// (x logicallyPrecedes y) means that x and y are cognitive steps that are connected by a cognitive chain, leading from x and y, that does not contain a cognitive rupture
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#logicallyPrecedes"></see></summary>
    let logicallyPrecedes =
        Namespaced_IRI.parse _namespace_name "logicallyPrecedes" |> NamespacedName

    /// <summary>
    /// Grounding chain, i.e., a cognitive chain that establishes epistemic grounding
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingChain"></see></summary>
    let GroundingChain =
        Namespaced_IRI.parse _namespace_name "GroundingChain" |> NamespacedName

    /// <summary>
    /// (x isJustificationFor y) means that x is a grounding chain that provides epsitemic grounding for the cognition y, which thereby becomes a grounded cognition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isJustificationFor"></see></summary>
    let isJustificationFor =
        Namespaced_IRI.parse _namespace_name "isJustificationFor" |> NamespacedName

    /// <summary>
    /// Grounding step, i.e., a triadic cognition that establishes epistemic grounding
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingStep"></see></summary>
    let GroundingStep =
        Namespaced_IRI.parse _namespace_name "GroundingStep" |> NamespacedName

    /// <summary>
    /// Grounding interpretation, i.e., an interpretation where the sign is a ground for the considered cognitive step, the object is the considered cognitive step, and the interpretant is a ground for a subsequent cognitive step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingInterpretation"></see></summary>
    let GroundingInterpretation =
        Namespaced_IRI.parse _namespace_name "GroundingInterpretation" |> NamespacedName

    /// <summary>
    /// (x groundsPresentStepIn y) == y is a grounding interpretation where x is the first element, i.e., a ground for the considered cognitive step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#groundsPresentStepIn"></see></summary>
    let groundsPresentStepIn =
        Namespaced_IRI.parse _namespace_name "groundsPresentStepIn" |> NamespacedName

    /// <summary>
    /// (x isPresentStepInGrounding y) == y is a grounding interpretation where x is the second element, i.e., the considered cognitive step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isPresentStepInGrounding"></see></summary>
    let isPresentStepInGrounding =
        Namespaced_IRI.parse _namespace_name "isPresentStepInGrounding" |> NamespacedName

    /// <summary>
    /// (x groundsNextStepIn y) == y is a grounding interpretation where x is the third element, i.e., a ground for the subsequent cognitive step; thereby, x also serves as a ground for y itself
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#groundsNextStepIn"></see></summary>
    let groundsNextStepIn =
        Namespaced_IRI.parse _namespace_name "groundsNextStepIn" |> NamespacedName

    /// <summary>
    /// Grounding metonymization, i.e., a metonymization where a the old referent is a cognitive step (i.e., the grounding step) that grounds another (i.e., the grounded step), which is the new referent; the referent for both is a ground (i.e., the grounding proposition) that is a ground for the grounded step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingMetonymization"></see></summary>
    let GroundingMetonymization =
        Namespaced_IRI.parse _namespace_name "GroundingMetonymization" |> NamespacedName

    /// <summary>
    /// (x isGroundingStepIn y) == y is a grounding step where x is the grounding step, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundingStepIn"></see></summary>
    let isGroundingStepIn =
        Namespaced_IRI.parse _namespace_name "isGroundingStepIn" |> NamespacedName

    /// <summary>
    /// (x isGroundingPropositionIn y) == y is a grounding step where x is the grounding proposition, i.e., the second element; therein, x is a ground for the grounded step, and x is also a ground for y itself
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundingPropositionIn"></see></summary>
    let isGroundingPropositionIn =
        Namespaced_IRI.parse _namespace_name "isGroundingPropositionIn" |> NamespacedName

    /// <summary>
    /// (x isGroundedStepIn y) == y is a grounding step where x is the grounded step, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundedStepIn"></see></summary>
    let isGroundedStepIn =
        Namespaced_IRI.parse _namespace_name "isGroundedStepIn" |> NamespacedName

    /// <summary>
    /// Semantic change, i.e., a triadic cognition by which a representamen is assigned a new referent
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#SemanticChange"></see></summary>
    let SemanticChange =
        Namespaced_IRI.parse _namespace_name "SemanticChange" |> NamespacedName

    /// <summary>
    /// Triadic cognition, i.e., a cognitive step of the type s-o-s' (semiosis) or o-s-o' (semantic change), thus containing three elements, in line with the approach by Peirce
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#TriadicCognition"></see></summary>
    let TriadicCognition =
        Namespaced_IRI.parse _namespace_name "TriadicCognition" |> NamespacedName

    /// <summary>
    /// Individual IRI, i.e., the internationalized resource identifier of an individual (owl:Thing or pims-ii:Object)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#IndividualIRI"></see></summary>
    let IndividualIRI =
        Namespaced_IRI.parse _namespace_name "IndividualIRI" |> NamespacedName

    /// <summary>
    /// Unique identifier, i.e., a rigid designator that is applied to exactly one object
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#UniqueIdentifier"></see></summary>
    let UniqueIdentifier =
        Namespaced_IRI.parse _namespace_name "UniqueIdentifier" |> NamespacedName

    /// <summary>
    /// (x isInformationProcessingInputIn y) == y is an information-processing step where x is the input, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInformationProcessingInputIn"></see></summary>
    let isInformationProcessingInputIn =
        Namespaced_IRI.parse _namespace_name "isInformationProcessingInputIn" |> NamespacedName

    /// <summary>
    /// (x isObjectInInformationProcessing y) == y is an information-processing step where x is the object that the input and the output both represent, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInInformationProcessing"></see></summary>
    let isObjectInInformationProcessing =
        Namespaced_IRI.parse _namespace_name "isObjectInInformationProcessing" |> NamespacedName

    /// <summary>
    /// (x isInformationProcessingOutputIn y) == y is an information-processing step where x is the output, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInformationProcessingOutputIn"></see></summary>
    let isInformationProcessingOutputIn =
        Namespaced_IRI.parse _namespace_name "isInformationProcessingOutputIn" |> NamespacedName

    /// <summary>
    /// (x isSignInInterpretation y) == y is an interpretation where x acts as the sign, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSignInInterpretation"></see></summary>
    let isSignInInterpretation =
        Namespaced_IRI.parse _namespace_name "isSignInInterpretation" |> NamespacedName

    /// <summary>
    /// (x isObjectInInterpretation y) == y is an interpretation where x acts as the object, i.e., the second element; there is no need to the object of an interpretation to be present and participate in the interpretation process physically
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInInterpretation"></see></summary>
    let isObjectInInterpretation =
        Namespaced_IRI.parse _namespace_name "isObjectInInterpretation" |> NamespacedName

    /// <summary>
    /// (x isInterpretantInInterpretation y) == y is an interpretation where x acts as the interpretant, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantInInterpretation"></see></summary>
    let isInterpretantInInterpretation =
        Namespaced_IRI.parse _namespace_name "isInterpretantInInterpretation" |> NamespacedName

    /// <summary>
    /// Investigation setup, i.e., a metonymization where a sign (e.g., a model and/or open question) that has come up for an 'object of application' (the old referent, e.g., the system to which a use case refers) is reassigned to an 'object of investigation' to which dedicated studies can be applied, such as a system that will be simulated or investigated experimentally; n.b., there needs to be a causal connection between the old and the new referent, i.e., between the object of application and the object of investigation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#InvestigationSetup"></see></summary>
    let InvestigationSetup =
        Namespaced_IRI.parse _namespace_name "InvestigationSetup" |> NamespacedName

    /// <summary>
    /// (x isObjectOfApplicationIn y) == y is an investigation-setup action where x acts as the object of application (e.g., the system to which a use case refers), i.e., the first element; n.b., there needs to be a causal connection between the object of application and the object of investigation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectOfApplicationIn"></see></summary>
    let isObjectOfApplicationIn =
        Namespaced_IRI.parse _namespace_name "isObjectOfApplicationIn" |> NamespacedName

    /// <summary>
    /// (x isSignInInvestigation y) == y is an investigation-setup action where x acts as a representamen, i.e., the second element, both for the object of application (to which it is initially applied) and the object of investigation (to which it is reassigned such that the investigation can take place)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSignInInvestigation"></see></summary>
    let isSignInInvestigation =
        Namespaced_IRI.parse _namespace_name "isSignInInvestigation" |> NamespacedName

    /// <summary>
    /// (x isObjectOfInvestigationIn y) == y is an investigation-setup action where x acts as the object of investigation (e.g., the item subject to an experiment or a simulated process or system), i.e., as the third element; n.b., there needs to be a causal connection between the object of application and the object of investigation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectOfInvestigationIn"></see></summary>
    let isObjectOfInvestigationIn =
        Namespaced_IRI.parse _namespace_name "isObjectOfInvestigationIn" |> NamespacedName

    /// <summary>
    /// Item, i.e., a connected region of spacetime that does not consist of multiple connected components
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName

    /// <summary>
    /// Knowledge base, i.e., an interlocutor that makes a consistent set of claims and will respond consistently if queried; n.b., that propositional content which 'isHeldBy' a knowledge base needs to be invariable over the whole 4D spacetime in which the knowledge base exist. Since technical knowledge bases do happen to change their propositional content over time, it may make sense either to define proper parts with a short temporal extension or to take care with what a knowledge base is stated to hold. Other kinds of propositional content (varying over time or depending on who makes the query) can be said to be asserted rather than held by the knowledge base.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeBase"></see></summary>
    let KnowledgeBase =
        Namespaced_IRI.parse _namespace_name "KnowledgeBase" |> NamespacedName

    /// <summary>
    /// Knowledge-based agent, i.e., an intelligent agent that uses a knowledge base to store and process its opinions/claims/worldview
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeBasedAgent"></see></summary>
    let KnowledgeBasedAgent =
        Namespaced_IRI.parse _namespace_name "KnowledgeBasedAgent" |> NamespacedName

    /// <summary>
    /// (x isMereologicallyConstitutiveOf y) means that x is constitutive of y by virtue of the way in which it is a proper part of y in 4D spacetime, e.g., as a necessary component of an item that was designed for a certain purpose
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMereologicallyConstitutiveOf"></see></summary>
    let isMereologicallyConstitutiveOf =
        Namespaced_IRI.parse _namespace_name "isMereologicallyConstitutiveOf" |> NamespacedName

    /// <summary>
    /// Question, i.e., a topical proposition the semantics/pragmatics of which are of interrogative character
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Question"></see></summary>
    let Question = Namespaced_IRI.parse _namespace_name "Question" |> NamespacedName

    /// <summary>
    /// (x hasSubjectMatter y) means that x is a proposition or articulation that addresses the topic or sum (i.e., plurality) of topics y, i.e., that has y as its subject matter
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasSubjectMatter"></see></summary>
    let hasSubjectMatter =
        Namespaced_IRI.parse _namespace_name "hasSubjectMatter" |> NamespacedName

    /// <summary>
    /// (x isInterpretantIn y) == y is a semiosis where x acts as the interpretant, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantIn"></see></summary>
    let isInterpretantIn =
        Namespaced_IRI.parse _namespace_name "isInterpretantIn" |> NamespacedName

    /// <summary>
    /// Validity claim (VC), i.e., a claim about another claim, saying something about that claim's (in-)accuracy or somebody's (dis-)trust in the claim
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ValidityClaim"></see></summary>
    let ValidityClaim =
        Namespaced_IRI.parse _namespace_name "ValidityClaim" |> NamespacedName

    /// <summary>
    /// Rule, i.e., a proposition consisting of an antecedent and one or multiple consequent(s) such that the antecedent is stated to imply the consequent(s)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Rule"></see></summary>
    let Rule = Namespaced_IRI.parse _namespace_name "Rule" |> NamespacedName

    /// <summary>
    /// Qualified law, i.e., a law where the necessary entailment of the consequent(s) by the antecedent is expressed in terms of qualified necessity, to be understood in terms of its modal context
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#QualifiedLaw"></see></summary>
    let QualifiedLaw =
        Namespaced_IRI.parse _namespace_name "QualifiedLaw" |> NamespacedName

    /// <summary>
    /// Lexeme, i.e., a semiotic collective the members of which are all instances/utterances/copies of the same word (or a fragment or group of words that fulfills the corresponding function) which acts as a conventional articulation due to social convention; different ways of writing the word, such as an abbreviation and the full version, may belong to the same lexeme
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Lexeme"></see></summary>
    let Lexeme = Namespaced_IRI.parse _namespace_name "Lexeme" |> NamespacedName
    /// <summary>
    /// Name, i.e., a lexeme that acts as a rigid designator due to social convention
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Name"></see></summary>
    let Name = Namespaced_IRI.parse _namespace_name "Name" |> NamespacedName

    /// <summary>
    /// Mathematical operator, i.e., a lexeme that articulates a mathematical operation, such as the collective containing realizations of '*', '·', 'times', etc.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#MathematicalOperator"></see></summary>
    let MathematicalOperator =
        Namespaced_IRI.parse _namespace_name "MathematicalOperator" |> NamespacedName

    /// <summary>
    /// (x isMeasurementInputIn y) == y is a measurement where x serves as the input (sign), i.e., the first element, constituting the precondition in terms of available information and similar items
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMeasurementInputIn"></see></summary>
    let isMeasurementInputIn =
        Namespaced_IRI.parse _namespace_name "isMeasurementInputIn" |> NamespacedName

    /// <summary>
    /// (x isMeasuredObjectIn y) == y is a measurement where x acts as the object, i.e., the second element, that is subject to the measurement and for which a property is determined
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMeasuredObjectIn"></see></summary>
    let isMeasuredObjectIn =
        Namespaced_IRI.parse _namespace_name "isMeasuredObjectIn" |> NamespacedName

    /// <summary>
    /// (x isMeasurementOutcomeIn y) == y is a measurement where x is the measurement outcome, i.e., the third element (e.g., the value that is determined for the considered property of the measured object, the measurement error, and any other outcome)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMeasurementOutcomeIn"></see></summary>
    let isMeasurementOutcomeIn =
        Namespaced_IRI.parse _namespace_name "isMeasurementOutcomeIn" |> NamespacedName

    /// <summary>
    /// Measurement unit, i.e., a 'real scalar quantity, defined and adopted by convention' (EMMO, ISO 80000-1)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#MeasurementUnit"></see></summary>
    let MeasurementUnit =
        Namespaced_IRI.parse _namespace_name "MeasurementUnit" |> NamespacedName

    /// <summary>
    /// (x isMereotopologicalMemberOf y) means that x is one out of several mereotopologically connected components of y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMereotopologicalMemberOf"></see></summary>
    let isMereotopologicalMemberOf =
        Namespaced_IRI.parse _namespace_name "isMereotopologicalMemberOf" |> NamespacedName

    /// <summary>
    /// (x isOldReferentInMetonymization y) == y is a metonymization where x acts as the old referent, i.e., the first element; the old and the new referent need to have a causal connection
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInMetonymization"></see></summary>
    let isOldReferentInMetonymization =
        Namespaced_IRI.parse _namespace_name "isOldReferentInMetonymization" |> NamespacedName

    /// <summary>
    /// (x changesReferentInMetonymization y) == y is a metonymization where x acts as the representamen, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInMetonymization"></see></summary>
    let changesReferentInMetonymization =
        Namespaced_IRI.parse _namespace_name "changesReferentInMetonymization" |> NamespacedName

    /// <summary>
    /// (x isNewReferentInMetonymization y) == y is a metonymization where x acts as the new referent, i.e., the third element; the old and the new referent need to have a causal connection
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInMetonymization"></see></summary>
    let isNewReferentInMetonymization =
        Namespaced_IRI.parse _namespace_name "isNewReferentInMetonymization" |> NamespacedName

    /// <summary>
    /// Qualified modal IRI, i.e., the IRI of a relation that is defined by qualified necessity or possibility of another relation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#QualifiedModalIRI"></see></summary>
    let QualifiedModalIRI =
        Namespaced_IRI.parse _namespace_name "QualifiedModalIRI" |> NamespacedName

    /// <summary>
    /// Modelling, i.e., an interpretation in which the sign is the basis for the modelling process (e.g., an unparameterized or previously parameterized model, knowledge about the modelled system, etc.), the object is the modelled system, and the interpretant is the modelling output (e.g., a parameterized model)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Modelling"></see></summary>
    let Modelling = Namespaced_IRI.parse _namespace_name "Modelling" |> NamespacedName

    /// <summary>
    /// (x isModellingInputIn y) == y is a modelling (model construction or parameterization) step where x is the input (previous or unparameterized model, knowledge about the modelled system, etc.), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isModellingInputIn"></see></summary>
    let isModellingInputIn =
        Namespaced_IRI.parse _namespace_name "isModellingInputIn" |> NamespacedName

    /// <summary>
    /// (x isModelledIn y) == y is a modelling (model construction or parameterization) step where x acts as the modelled object (system, substance, process, or similar), i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isModelledIn"></see></summary>
    let isModelledIn =
        Namespaced_IRI.parse _namespace_name "isModelledIn" |> NamespacedName

    /// <summary>
    /// (x isModellingOutputIn y) == y is a modelling (model construction or parameterization) step where x is the modelling output (e.g., a parameterized or improved model), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isModellingOutputIn"></see></summary>
    let isModellingOutputIn =
        Namespaced_IRI.parse _namespace_name "isModellingOutputIn" |> NamespacedName

    /// <summary>
    /// (x isNameFor y), to be applied in the frequent special case where x is represented by a name for x, i.e., where social convention has established y as a rigid designator for x
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isNameFor"></see></summary>
    let isNameFor = Namespaced_IRI.parse _namespace_name "isNameFor" |> NamespacedName

    /// <summary>
    /// Negative knowledge claim (NKC), i.e., a knowledge claim that expresses what we don't know, a gap or limitation of our knowledge
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#NegativeKnowledgeClaim"></see></summary>
    let NegativeKnowledgeClaim =
        Namespaced_IRI.parse _namespace_name "NegativeKnowledgeClaim" |> NamespacedName

    /// <summary>
    /// Number, i.e., a lexeme that is numerical in nature, such as the collective containing realizations of 'two', '2', and '2.0'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Number"></see></summary>
    let Number = Namespaced_IRI.parse _namespace_name "Number" |> NamespacedName

    /// <summary>
    /// (x isSpatiotemporallyDisconnectedFrom y) is the negation of (x isSpatiotemporallyConnectedWith y); i.e., to go from any point in x to any point in y, it is necessary to leave the fusion (x U y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSpatiotemporallyDisconnectedFrom"></see></summary>
    let isSpatiotemporallyDisconnectedFrom =
        Namespaced_IRI.parse _namespace_name "isSpatiotemporallyDisconnectedFrom" |> NamespacedName

    /// <summary>
    /// (x temporallyPrecedes y) means that every point in x is earlier in time than every point in y; the spacetime regions x and y may be connected, but they cannot overlap temporally
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#temporallyPrecedes"></see></summary>
    let temporallyPrecedes =
        Namespaced_IRI.parse _namespace_name "temporallyPrecedes" |> NamespacedName

    /// <summary>
    /// (x hasProperPart y) means that y is an improper part of x such that x and y are not the same, in other words, all points within y are also within x, but not vice versa
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasProperPart"></see></summary>
    let hasProperPart =
        Namespaced_IRI.parse _namespace_name "hasProperPart" |> NamespacedName

    /// <summary>
    /// Spatiotemporal (mereological) proper parthood relation; (x isProperPartOf y) means that x is an improper part of y such that x and y are not the same, in other words, all points within x are also within y, but not vice versa
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isProperPartOf"></see></summary>
    let isProperPartOf =
        Namespaced_IRI.parse _namespace_name "isProperPartOf" |> NamespacedName

    /// <summary>
    /// (x isObservationInputIn y) == y is an observation where x designates input and/or advance knowledge relevant to the observation, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObservationInputIn"></see></summary>
    let isObservationInputIn =
        Namespaced_IRI.parse _namespace_name "isObservationInputIn" |> NamespacedName

    /// <summary>
    /// (x isObservedIn y) == y is an observation where x acts as the observed object, i.e., the second element, for which the value of a property is to be determined
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObservedIn"></see></summary>
    let isObservedIn =
        Namespaced_IRI.parse _namespace_name "isObservedIn" |> NamespacedName

    /// <summary>
    /// (x isObservationOutcomeIn y) == y is an observation where x is the observation outcome (the observed value of the target property), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObservationOutcomeIn"></see></summary>
    let isObservationOutcomeIn =
        Namespaced_IRI.parse _namespace_name "isObservationOutcomeIn" |> NamespacedName

    /// <summary>
    /// Perception, i.e., a semiosis in which the referent is a participant (as a perceived object) and therefore needs to be physically present
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Perception"></see></summary>
    let Perception = Namespaced_IRI.parse _namespace_name "Perception" |> NamespacedName

    /// <summary>
    /// Optimization, i.e., an interpretation in which the sign is the optimization problem, the object is that which the optimization problem is ultimately about, and the interpretant is the optimization output
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Optimization"></see></summary>
    let Optimization =
        Namespaced_IRI.parse _namespace_name "Optimization" |> NamespacedName

    /// <summary>
    /// Optimization problem, i.e., an intention expressed or expressible in terms of one or multiple objectives (objective space) and one or multiple design parameters (parameter space)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#OptimizationProblem"></see></summary>
    let OptimizationProblem =
        Namespaced_IRI.parse _namespace_name "OptimizationProblem" |> NamespacedName

    /// <summary>
    /// (x isOptimizationProblemIn y) == y is an optimization where x is the optimization problem, i.e., the first element.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationProblemIn"></see></summary>
    let isOptimizationProblemIn =
        Namespaced_IRI.parse _namespace_name "isOptimizationProblemIn" |> NamespacedName

    /// <summary>
    /// (x isObjectInOptimization y) == y is an optimization where x is that which the optimization is ultimately about, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInOptimization"></see></summary>
    let isObjectInOptimization =
        Namespaced_IRI.parse _namespace_name "isObjectInOptimization" |> NamespacedName

    /// <summary>
    /// (x isOptimizationOutputIn y) == y is an optimization where x is the optimization output, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationOutputIn"></see></summary>
    let isOptimizationOutputIn =
        Namespaced_IRI.parse _namespace_name "isOptimizationOutputIn" |> NamespacedName

    /// <summary>
    /// (x isDesignParameterWithin y) == x is one of the parameters that make up the design space considered in the optimization problem y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isDesignParameterWithin"></see></summary>
    let isDesignParameterWithin =
        Namespaced_IRI.parse _namespace_name "isDesignParameterWithin" |> NamespacedName

    /// <summary>
    /// (x isOptimizationObjectiveWithin y) == x is one of the optimization criteria that make up the objective space considered in the optimization problem y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationObjectiveWithin"></see></summary>
    let isOptimizationObjectiveWithin =
        Namespaced_IRI.parse _namespace_name "isOptimizationObjectiveWithin" |> NamespacedName

    /// <summary>
    /// Own claim, i.e., a claim that is asserted by a self reference (i.e., a/the present interlocutor)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#OwnClaim"></see></summary>
    let OwnClaim = Namespaced_IRI.parse _namespace_name "OwnClaim" |> NamespacedName

    /// <summary>
    /// Reference to self, i.e., an entity for the interlocutor who *is* the present system, i.e., the system containing the present triples, etc., and whose claims are to be accepted as the present system's 'own claims.' A self-reference is an entity that is either identical with the system at hand, namely, the digital infrastructure or other interlocutor that stores the present semantic content, or a component of it
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ReferenceToSelf"></see></summary>
    let ReferenceToSelf =
        Namespaced_IRI.parse _namespace_name "ReferenceToSelf" |> NamespacedName

    /// <summary>
    /// Part-to-whole synecdoche, i.e., a metonymization where the old referent is a spatiotemporal proper part of the new referent (additionally, the old and new referent need to be connected causally)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#PartToWhole"></see></summary>
    let PartToWhole =
        Namespaced_IRI.parse _namespace_name "PartToWhole" |> NamespacedName

    /// <summary>
    /// (x isOldReferentInPartToWhole y) == y is a part-to-whole synecdoche where x acts as the old referent (the part), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInPartToWhole"></see></summary>
    let isOldReferentInPartToWhole =
        Namespaced_IRI.parse _namespace_name "isOldReferentInPartToWhole" |> NamespacedName

    /// <summary>
    /// (x changesReferentInPartToWhole y) == y is a part-to-whole synecdoche where x acts as the representamen, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInPartToWhole"></see></summary>
    let changesReferentInPartToWhole =
        Namespaced_IRI.parse _namespace_name "changesReferentInPartToWhole" |> NamespacedName

    /// <summary>
    /// (x isNewReferentInPartToWhole y) == y is a part-to-whole synecdoche where x acts as the new referent (the whole), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInPartToWhole"></see></summary>
    let isNewReferentInPartToWhole =
        Namespaced_IRI.parse _namespace_name "isNewReferentInPartToWhole" |> NamespacedName

    /// <summary>
    /// Synecdoche, i.e., a metonymization where a sign is reassigned to a part of its old referent (WholeToPart) or vice versa (PartToWhole)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Synecdoche"></see></summary>
    let Synecdoche = Namespaced_IRI.parse _namespace_name "Synecdoche" |> NamespacedName

    /// <summary>
    /// (x isSignInPerception y) == y is a perception where x acts as the sign, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSignInPerception"></see></summary>
    let isSignInPerception =
        Namespaced_IRI.parse _namespace_name "isSignInPerception" |> NamespacedName

    /// <summary>
    /// (x isPerceivedIn y) == y is a perception where x acts as the perceived object, i.e., the second element; the perceived object is a (mereotopological) participant of the perception, in other words, it needs to be physically present so that it can be perceived
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isPerceivedIn"></see></summary>
    let isPerceivedIn =
        Namespaced_IRI.parse _namespace_name "isPerceivedIn" |> NamespacedName

    /// <summary>
    /// (x isInterpretantInPerception y) == y is a perception where x acts as the interpretant, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantInPerception"></see></summary>
    let isInterpretantInPerception =
        Namespaced_IRI.parse _namespace_name "isInterpretantInPerception" |> NamespacedName

    /// <summary>
    /// Person, i.e., an interlocutor that is socially identified as a natural or legal person by social convention that involves using a name (or multiple names) for it as rigid designators
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    /// Planning, i.e., a reflection ex ante or predetermination, carried out by analysing the perceived present situation in advance of potentially undertaking an action
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Planning"></see></summary>
    let Planning = Namespaced_IRI.parse _namespace_name "Planning" |> NamespacedName

    /// <summary>
    /// (x isTelosInPlanning y) == y is a telesis carried out in advance of potentially undertaking an action, where x acts as the telos (initial guiding objective), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInPlanning"></see></summary>
    let isTelosInPlanning =
        Namespaced_IRI.parse _namespace_name "isTelosInPlanning" |> NamespacedName

    /// <summary>
    /// (x isSituationInPlanning y) == y is a telesis carried out in advance of potentially undertaking an action, where x is the perceived present situation, i.e., the second element, against which the telos is evaluated
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSituationInPlanning"></see></summary>
    let isSituationInPlanning =
        Namespaced_IRI.parse _namespace_name "isSituationInPlanning" |> NamespacedName

    /// <summary>
    /// (x isResolutionInPlanning y) == y is a telesis carried out in advance of potentially undertaking an action, where x is the planning outcome, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInPlanning"></see></summary>
    let isResolutionInPlanning =
        Namespaced_IRI.parse _namespace_name "isResolutionInPlanning" |> NamespacedName

    /// <summary>
    /// Plurality, i.e., a semiotic collective the semiotic members of which are a representational element (referent or representamen) together, whereby all act/contribute in the same way - this latter point distinguishes a plurality from a structure; e.g., the referent of the expression 'the four seasons/quarters of the year' (for a given year, within a given spatial region) is a plurality, and each of the four seasons/quarters is one of its semiotic members
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Plurality"></see></summary>
    let Plurality = Namespaced_IRI.parse _namespace_name "Plurality" |> NamespacedName

    /// <summary>
    /// (x isMemberOfPlurality y) means that x is a semiotic member of the plurality y, and that it participates in semiosis in the same way as its co-members x', x'', ... of the plurality y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMemberOfPlurality"></see></summary>
    let isMemberOfPlurality =
        Namespaced_IRI.parse _namespace_name "isMemberOfPlurality" |> NamespacedName

    /// <summary>
    /// Structure, i.e., a semiotic collective the semiotic members of which complement each other, contributing in different ways (or, at least, not all int the same way) to their joint action as a referent or a representamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Structure"></see></summary>
    let Structure = Namespaced_IRI.parse _namespace_name "Structure" |> NamespacedName

    /// <summary>
    /// Proof-based validity claim (PVC), i.e., a validity claim obtained by formal verification, i.e., by deductive logical and mathematical reasoning
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ProofBasedValidityClaim"></see></summary>
    let ProofBasedValidityClaim =
        Namespaced_IRI.parse _namespace_name "ProofBasedValidityClaim" |> NamespacedName

    /// <summary>
    /// Test-based validity claim (TVC), i.e., a validity claim obtained from validation or testing
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#TestBasedValidityClaim"></see></summary>
    let TestBasedValidityClaim =
        Namespaced_IRI.parse _namespace_name "TestBasedValidityClaim" |> NamespacedName

    /// <summary>
    /// Property, i.e., a variable that is employed for the possible outcome of observations and similar processes (this may include different words used for the same property, in one or multiple languages, and different ways of expressing these words)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName

    /// <summary>
    /// (x articulatesLiterally y) means that x is a collective literal expressing the proposition y, and possibly additional propositions beside y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#articulatesLiterally"></see></summary>
    let articulatesLiterally =
        Namespaced_IRI.parse _namespace_name "articulatesLiterally" |> NamespacedName

    /// <summary>
    /// (x isAbout y) means that x is a proposition and y is the object that x is related to by aboutness
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAbout"></see></summary>
    let isAbout = Namespaced_IRI.parse _namespace_name "isAbout" |> NamespacedName

    /// <summary>
    /// (x articulates y) means that x is a semiotic member of the proposition y, giving a literal or non-literal (e.g., spoken) expression to its propositional content; n.b., x may also express other propositions beside y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#articulates"></see></summary>
    let articulates =
        Namespaced_IRI.parse _namespace_name "articulates" |> NamespacedName

    /// <summary>
    /// (x isAimIn y) means that y is a purposeful action, and x is one of the aims followed by the agent of y by undertaking y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAimIn"></see></summary>
    let isAimIn = Namespaced_IRI.parse _namespace_name "isAimIn" |> NamespacedName

    /// <summary>
    /// (x isContextWithinLaw y) means that x is an IRI for the modal context of relatively necessary implication in the relative law y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isContextWithinLaw"></see></summary>
    let isContextWithinLaw =
        Namespaced_IRI.parse _namespace_name "isContextWithinLaw" |> NamespacedName

    /// <summary>
    /// (x isContextOfRelation y) means that x is an IRI for the modal context of qualified possibility/necessity in the relative modal IRI y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isContextOfRelation"></see></summary>
    let isContextOfRelation =
        Namespaced_IRI.parse _namespace_name "isContextOfRelation" |> NamespacedName

    /// <summary>
    /// Quantity value, i.e., a value that has a numerical magnitude and a physical unit
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#QuantityValue"></see></summary>
    let QuantityValue =
        Namespaced_IRI.parse _namespace_name "QuantityValue" |> NamespacedName

    /// <summary>
    /// (x isMagnitudeOf y) means that x is the numerical magnitude of y, e.g., in 200 kPa, x would be 200
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMagnitudeOf"></see></summary>
    let isMagnitudeOf =
        Namespaced_IRI.parse _namespace_name "isMagnitudeOf" |> NamespacedName

    /// <summary>
    /// (x isUnitOf y) means that x is the unit of y, e.g., in 200 kPa, x would be kPa
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isUnitOf"></see></summary>
    let isUnitOf = Namespaced_IRI.parse _namespace_name "isUnitOf" |> NamespacedName
    /// <summary>
    /// Query, i.e., a digital articulation of a question
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Query"></see></summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName
    /// <summary>
    /// Topical proposition, i.e., something that can be understood as stating the topic of something
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Topical"></see></summary>
    let Topical = Namespaced_IRI.parse _namespace_name "Topical" |> NamespacedName

    /// <summary>
    /// A rational agent is an intelligent agent that exhibits rationality, i.e., a tendency toward maximizing a quantity: The performance measure of the agent.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#RationalAgent"></see></summary>
    let RationalAgent =
        Namespaced_IRI.parse _namespace_name "RationalAgent" |> NamespacedName

    /// <summary>
    /// (x isPerformanceMeasureOf y) means that x is the single/unique performance measure of the rational agent y.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isPerformanceMeasureOf"></see></summary>
    let isPerformanceMeasureOf =
        Namespaced_IRI.parse _namespace_name "isPerformanceMeasureOf" |> NamespacedName

    /// <summary>
    /// Research question, i.e., a question that could, has been, or is being addressed by scientific research and e.g. could be answered by a knowledge claim formulated on the grounds of scientific research data
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ResearchQuestion"></see></summary>
    let ResearchQuestion =
        Namespaced_IRI.parse _namespace_name "ResearchQuestion" |> NamespacedName

    /// <summary>
    /// (x isAntecedentWithin y) means that x is the antecedent from the rule y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAntecedentWithin"></see></summary>
    let isAntecedentWithin =
        Namespaced_IRI.parse _namespace_name "isAntecedentWithin" |> NamespacedName

    /// <summary>
    /// (x isConsequentWithin y) means that x is a consequent from the rule y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isConsequentWithin"></see></summary>
    let isConsequentWithin =
        Namespaced_IRI.parse _namespace_name "isConsequentWithin" |> NamespacedName

    /// <summary>
    /// (x isOrthodataWithin y) means that x articulates a substantial aspect of either the antecedent or the consequent side of the rule y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOrthodataWithin"></see></summary>
    let isOrthodataWithin =
        Namespaced_IRI.parse _namespace_name "isOrthodataWithin" |> NamespacedName

    /// <summary>
    /// Selection, i.e., an information-processing step in which the given information is narrowed down such that the output (interpretant) is constitutive of the input (sign); this includes conditional selection, where one component of the input or another is retained depending on a selection condition (cf. relation isSelectionConditionIn)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Selection"></see></summary>
    let Selection = Namespaced_IRI.parse _namespace_name "Selection" |> NamespacedName

    /// <summary>
    /// (x isSelectionInputIn y) == y is a selection where x is the input (initially given information), i.e., the first element; n.b., in a selection, the output needs to be constitutive of the input
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSelectionInputIn"></see></summary>
    let isSelectionInputIn =
        Namespaced_IRI.parse _namespace_name "isSelectionInputIn" |> NamespacedName

    /// <summary>
    /// (x isObjectInSelection y) == y is a selection where x is the object that the input and the output both represent, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInSelection"></see></summary>
    let isObjectInSelection =
        Namespaced_IRI.parse _namespace_name "isObjectInSelection" |> NamespacedName

    /// <summary>
    /// (x isSelectionOutputIn y) == y is a selection where x is the output (retained information), i.e., the third element; n.b., in a selection, the output needs to be constitutive of the input
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSelectionOutputIn"></see></summary>
    let isSelectionOutputIn =
        Namespaced_IRI.parse _namespace_name "isSelectionOutputIn" |> NamespacedName

    /// <summary>
    /// (x isOldReferentIn y) == y is a semantic change where x acts as the old referent, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentIn"></see></summary>
    let isOldReferentIn =
        Namespaced_IRI.parse _namespace_name "isOldReferentIn" |> NamespacedName

    /// <summary>
    /// (x changesReferentIn y) == y is a semantic change where x acts as the representamen, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentIn"></see></summary>
    let changesReferentIn =
        Namespaced_IRI.parse _namespace_name "changesReferentIn" |> NamespacedName

    /// <summary>
    /// (x isNewReferentIn y) == y is a semantic change where x acts as the new referent, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentIn"></see></summary>
    let isNewReferentIn =
        Namespaced_IRI.parse _namespace_name "isNewReferentIn" |> NamespacedName

    /// <summary>
    /// (x isSignIn y) == y is a semiosis where x acts as the sign, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSignIn"></see></summary>
    let isSignIn = Namespaced_IRI.parse _namespace_name "isSignIn" |> NamespacedName
    /// <summary>
    /// (x isObjectIn y) == y is a semiosis where x acts as the object, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectIn"></see></summary>
    let isObjectIn = Namespaced_IRI.parse _namespace_name "isObjectIn" |> NamespacedName

    /// <summary>
    /// (x isRepresentationalElementIn y) == x acts as a representamen or referent in the cognitive step y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isRepresentationalElementIn"></see></summary>
    let isRepresentationalElementIn =
        Namespaced_IRI.parse _namespace_name "isRepresentationalElementIn" |> NamespacedName

    /// <summary>
    /// Simulation, i.e., a purposefully conducted numerical interpretation of simulation input (model, etc.), where the interpretant is the simulation result
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Simulation"></see></summary>
    let Simulation = Namespaced_IRI.parse _namespace_name "Simulation" |> NamespacedName

    /// <summary>
    /// (x isSimulationInputIn y) == y is a simulation where x is the simulation input (model, etc.), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSimulationInputIn"></see></summary>
    let isSimulationInputIn =
        Namespaced_IRI.parse _namespace_name "isSimulationInputIn" |> NamespacedName

    /// <summary>
    /// (x isSimulatedIn y) == y is a simulation where x acts as the simulated object (system, substance, process, or similar), i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSimulatedIn"></see></summary>
    let isSimulatedIn =
        Namespaced_IRI.parse _namespace_name "isSimulatedIn" |> NamespacedName

    /// <summary>
    /// (x isSimulationOutputIn y) == y is a simulation where x is the simulation output (computed property, higher-level model, or similar), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSimulationOutputIn"></see></summary>
    let isSimulationOutputIn =
        Namespaced_IRI.parse _namespace_name "isSimulationOutputIn" |> NamespacedName

    /// <summary>
    /// simulation workflow, i.e., a cognitive workflow in which simulation plays a major role
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#SimulationWorkflow"></see></summary>
    let SimulationWorkflow =
        Namespaced_IRI.parse _namespace_name "SimulationWorkflow" |> NamespacedName

    /// <summary>
    /// Steering, i.e., a reflection in actu (Reflexion im Vollzug following Baumann and Tulatz) or determination, carried out while undertaking an action and playing a role in that action by proper participation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Steering"></see></summary>
    let Steering = Namespaced_IRI.parse _namespace_name "Steering" |> NamespacedName

    /// <summary>
    /// (x isTelosInSteering y) == y is a steering operation (reflection in actu) where x acts as the telos (initial guiding objective), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInSteering"></see></summary>
    let isTelosInSteering =
        Namespaced_IRI.parse _namespace_name "isTelosInSteering" |> NamespacedName

    /// <summary>
    /// (x isActionInSteering y) == y is a steering operation (reflection in actu) where x is an ongoing action, i.e., the second element, against which the telos is evaluated
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isActionInSteering"></see></summary>
    let isActionInSteering =
        Namespaced_IRI.parse _namespace_name "isActionInSteering" |> NamespacedName

    /// <summary>
    /// (x isResolutionInSteering y) == y is a steering operation (reflection in actu) where x is the resolution, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInSteering"></see></summary>
    let isResolutionInSteering =
        Namespaced_IRI.parse _namespace_name "isResolutionInSteering" |> NamespacedName

    /// <summary>
    /// (x isMemberOfStructure y) means that x is a semiotic member of the structure y, and that it participates in semiosis differently from all of its co-members x', x'', ... of the structure y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMemberOfStructure"></see></summary>
    let isMemberOfStructure =
        Namespaced_IRI.parse _namespace_name "isMemberOfStructure" |> NamespacedName

    /// <summary>
    /// (x isOldReferentInSynecdoche y) == y is a synecdoche where x acts as the old referent, i.e., the first element; the old and the new referent need to have a causal connection (n.b., the mereological relation in terms of proper parthood as such is insufficient)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInSynecdoche"></see></summary>
    let isOldReferentInSynecdoche =
        Namespaced_IRI.parse _namespace_name "isOldReferentInSynecdoche" |> NamespacedName

    /// <summary>
    /// (x changesReferentInSynecdoche y) == y is a synecdoche where x acts as the representamen, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInSynecdoche"></see></summary>
    let changesReferentInSynecdoche =
        Namespaced_IRI.parse _namespace_name "changesReferentInSynecdoche" |> NamespacedName

    /// <summary>
    /// (x isNewReferentInSynecdoche y) == y is a synecdoche where x acts as the new referent, i.e., the third element; the old and the new referent need to have a causal connection (n.b., the mereological relation in terms of proper parthood as such is insufficient)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInSynecdoche"></see></summary>
    let isNewReferentInSynecdoche =
        Namespaced_IRI.parse _namespace_name "isNewReferentInSynecdoche" |> NamespacedName

    /// <summary>
    /// Whole-to-part synecdoche, i.e., a metonymization where the new referent is a spatiotemporal proper part of the old referent (additionally, the old and new referent need to be connected causally)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#WholeToPart"></see></summary>
    let WholeToPart =
        Namespaced_IRI.parse _namespace_name "WholeToPart" |> NamespacedName

    /// <summary>
    /// (x isTelosIn y) == y is a telesis where x acts as the telos (initial guiding objective), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosIn"></see></summary>
    let isTelosIn = Namespaced_IRI.parse _namespace_name "isTelosIn" |> NamespacedName

    /// <summary>
    /// (x isResolutionInTelesis y) == y is a telesis where x acts as the resolution (a plan, revised objective, or other comparable sort of evaluation outcome), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInTelesis"></see></summary>
    let isResolutionInTelesis =
        Namespaced_IRI.parse _namespace_name "isResolutionInTelesis" |> NamespacedName

    /// <summary>
    /// (x isObjectInTelesis y) == y is a telesis where x acts as the object (action, claim, or situation against which an objective is evaluated), i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInTelesis"></see></summary>
    let isObjectInTelesis =
        Namespaced_IRI.parse _namespace_name "isObjectInTelesis" |> NamespacedName

    /// <summary>
    /// (x isAdmissibleValueFor y) means that y is a term that could in principle evaluate to the value x; subsumption under msIPIRIR is explained as follows: There is a sign z for the term y (where z is the range of admissible values of y), for which in turn there is another sign z' (where z' lists members of z, explicitly including x) of which x is a part
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAdmissibleValueFor"></see></summary>
    let isAdmissibleValueFor =
        Namespaced_IRI.parse _namespace_name "isAdmissibleValueFor" |> NamespacedName

    /// <summary>
    /// Topical product, i.e., a topical proposition with multiple topical factors
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#TopicalProduct"></see></summary>
    let TopicalProduct =
        Namespaced_IRI.parse _namespace_name "TopicalProduct" |> NamespacedName

    /// <summary>
    /// Topical sum, i.e., a plurality of topical propositions, where the individual elements (summands) don't genuinely interact but are just standing beside each other as independent, unrelated (or not very closely related) parts of what is addressed
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#TopicalSum"></see></summary>
    let TopicalSum = Namespaced_IRI.parse _namespace_name "TopicalSum" |> NamespacedName

    /// <summary>
    /// (x isTopicalFactorIn y) means that x is combined with other subtopics into the topical proposition y, such that x and the other subtopics are not just standing beside each other, but exhibiting some meaningful interaction
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTopicalFactorIn"></see></summary>
    let isTopicalFactorIn =
        Namespaced_IRI.parse _namespace_name "isTopicalFactorIn" |> NamespacedName

    /// <summary>
    /// (x isTopicalSummandIn y) means that x is one of the topics contained in y, a collection of topics that are not immediately closely related to each other
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTopicalSummandIn"></see></summary>
    let isTopicalSummandIn =
        Namespaced_IRI.parse _namespace_name "isTopicalSummandIn" |> NamespacedName

    /// <summary>
    /// (x isFirstElementIn y) means that x acts as the first element in y, which is a triadic cognition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isFirstElementIn"></see></summary>
    let isFirstElementIn =
        Namespaced_IRI.parse _namespace_name "isFirstElementIn" |> NamespacedName

    /// <summary>
    /// (x isSecondElementIn y) means that x acts as the second element in y, which is a triadic cognition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSecondElementIn"></see></summary>
    let isSecondElementIn =
        Namespaced_IRI.parse _namespace_name "isSecondElementIn" |> NamespacedName

    /// <summary>
    /// (x isThirdElementIn y) means that x acts as the third element in y, which is a triadic cognition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isThirdElementIn"></see></summary>
    let isThirdElementIn =
        Namespaced_IRI.parse _namespace_name "isThirdElementIn" |> NamespacedName

    /// <summary>
    /// Triple, i.e., a subject-predicate-object triple (connected by relations to the IRIs of the subject, predicate, and object)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Triple"></see></summary>
    let Triple = Namespaced_IRI.parse _namespace_name "Triple" |> NamespacedName

    /// <summary>
    /// (x isSubjectWithinTriple y) means that y is a subject-predicate-object triple wherein x is the IRI of the subject
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSubjectWithinTriple"></see></summary>
    let isSubjectWithinTriple =
        Namespaced_IRI.parse _namespace_name "isSubjectWithinTriple" |> NamespacedName

    /// <summary>
    /// (x isPredicateWithinTriple y) means that y is a subject-predicate-object triple wherein x is the IRI of the predicate
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isPredicateWithinTriple"></see></summary>
    let isPredicateWithinTriple =
        Namespaced_IRI.parse _namespace_name "isPredicateWithinTriple" |> NamespacedName

    /// <summary>
    /// (x isObjectWithinTriple y) means that y is a subject-predicate-object triple wherein x is the IRI of the object
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectWithinTriple"></see></summary>
    let isObjectWithinTriple =
        Namespaced_IRI.parse _namespace_name "isObjectWithinTriple" |> NamespacedName

    /// <summary>
    /// (x isSituationInUndertaking y) == y is an undertaking wherein x is the pre-existing situation, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSituationInUndertaking"></see></summary>
    let isSituationInUndertaking =
        Namespaced_IRI.parse _namespace_name "isSituationInUndertaking" |> NamespacedName

    /// <summary>
    /// (x isResolutionInUndertaking y) == y is an undertaking where x is the resolution (obtained from a previous telesis), i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInUndertaking"></see></summary>
    let isResolutionInUndertaking =
        Namespaced_IRI.parse _namespace_name "isResolutionInUndertaking" |> NamespacedName

    /// <summary>
    /// (x isActionInUndertaking y) == y is an undertaking where x is the action that is undertaken, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isActionInUndertaking"></see></summary>
    let isActionInUndertaking =
        Namespaced_IRI.parse _namespace_name "isActionInUndertaking" |> NamespacedName

    /// <summary>
    /// Validation, i.e., an evaluation of a cognition yielding a validity claim as its interpretant
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Validation"></see></summary>
    let Validation = Namespaced_IRI.parse _namespace_name "Validation" |> NamespacedName

    /// <summary>
    /// (x isTelosInValidation y) means that y is a validation where x acts as the telos (initial guiding objective), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInValidation"></see></summary>
    let isTelosInValidation =
        Namespaced_IRI.parse _namespace_name "isTelosInValidation" |> NamespacedName

    /// <summary>
    /// (x isValidatedIn y) means that y is a validation where x is the cognitive action undergoing validation, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isValidatedIn"></see></summary>
    let isValidatedIn =
        Namespaced_IRI.parse _namespace_name "isValidatedIn" |> NamespacedName

    /// <summary>
    /// (x isValidationOutcomeIn y) means that x is the validity claim, i.e., the third element, obtained as an interpretant from the validation y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isValidationOutcomeIn"></see></summary>
    let isValidationOutcomeIn =
        Namespaced_IRI.parse _namespace_name "isValidationOutcomeIn" |> NamespacedName

    /// <summary>
    /// Visualization, i.e., an interpretation in which the object is the visualized system and the interpretant is a visual representation of the object - the sign is a pre-existing representamen for the same object, e.g., a simulation result
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Visualization"></see></summary>
    let Visualization =
        Namespaced_IRI.parse _namespace_name "Visualization" |> NamespacedName

    /// <summary>
    /// (x isVisualizationInputIn y) == y is a visualization process where x is the input (a pre-existing representamen for the visualized object, e.g., a simulation result), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isVisualizationInputIn"></see></summary>
    let isVisualizationInputIn =
        Namespaced_IRI.parse _namespace_name "isVisualizationInputIn" |> NamespacedName

    /// <summary>
    /// (x isVisualizedObjectIn y) == y is a visualization process wherein x is the visualized object, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isVisualizedObjectIn"></see></summary>
    let isVisualizedObjectIn =
        Namespaced_IRI.parse _namespace_name "isVisualizedObjectIn" |> NamespacedName

    /// <summary>
    /// (x isVisualizationOutputIn y) == y is a visualization where x is the visualization output, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isVisualizationOutputIn"></see></summary>
    let isVisualizationOutputIn =
        Namespaced_IRI.parse _namespace_name "isVisualizationOutputIn" |> NamespacedName

    /// <summary>
    /// (x isOldReferentInWholeToPart y) == y is a whole-to-part synecdoche where x acts as the old referent (the whole), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInWholeToPart"></see></summary>
    let isOldReferentInWholeToPart =
        Namespaced_IRI.parse _namespace_name "isOldReferentInWholeToPart" |> NamespacedName

    /// <summary>
    /// (x changesReferentInWholeToPart y) == y is a whole-to-part synecdoche where x acts as the representamen, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInWholeToPart"></see></summary>
    let changesReferentInWholeToPart =
        Namespaced_IRI.parse _namespace_name "changesReferentInWholeToPart" |> NamespacedName

    /// <summary>
    /// (x isNewReferentInWholeToPart y) == y is a whole-to-part synecdoche where x acts as the new referent (the part), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInWholeToPart"></see></summary>
    let isNewReferentInWholeToPart =
        Namespaced_IRI.parse _namespace_name "isNewReferentInWholeToPart" |> NamespacedName

    /// <summary>
    /// (x affirmsCognition y) means that x is about the cognition y, affirming its validity
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#affirmsCognition"></see></summary>
    let affirmsCognition =
        Namespaced_IRI.parse _namespace_name "affirmsCognition" |> NamespacedName

    /// <summary>
    /// (x providesJustification y) means that x is about some cognition z, providing a justification of it by referring to y, i.e., a grounding chain that establishes the epistemic status of z; thereby, x does not only affirm z, but also its grounding chain y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#providesJustification"></see></summary>
    let providesJustification =
        Namespaced_IRI.parse _namespace_name "providesJustification" |> NamespacedName

    /// <summary>
    /// (x articulatesNonliterally y) means that x is a collective non-literal expression (e.g., an utterance) of proposition y, and possibly additional propositions beside y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#articulatesNonliterally"></see></summary>
    let articulatesNonliterally =
        Namespaced_IRI.parse _namespace_name "articulatesNonliterally" |> NamespacedName

    /// <summary>
    /// (x isRepresentamenIn y) == x participates in the cognitive step y in the role of the/a representamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isRepresentamenIn"></see></summary>
    let isRepresentamenIn =
        Namespaced_IRI.parse _namespace_name "isRepresentamenIn" |> NamespacedName

    /// <summary>
    /// (x describesMethodAppliedIn y) means that x describes y in terms of the method that is employed
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#describesMethodAppliedIn"></see></summary>
    let describesMethodAppliedIn =
        Namespaced_IRI.parse _namespace_name "describesMethodAppliedIn" |> NamespacedName

    /// <summary>
    /// (x describesMethodEmployedBy y) means that the agent y follows a methodology described by x in carrying out an action
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#describesMethodEmployedBy"></see></summary>
    let describesMethodEmployedBy =
        Namespaced_IRI.parse _namespace_name "describesMethodEmployedBy" |> NamespacedName

    /// <summary>
    /// (X msIRHPIP Z) == isRepresentamenFor o hasProperPart o isProperPartOf == there is a Y such that (X isRepresentamenFor Y) and (Y overlapsWith Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIP"></see></summary>
    let msIRHPIP = Namespaced_IRI.parse _namespace_name "msIRHPIP" |> NamespacedName

    /// <summary>
    /// (x directlyPrecedesCognitiveStep y) == x is the cognitive step (or basic ground) that directly precedes y logically; typically, this means that y takes over a dyadic representation relation from x
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesCognitiveStep"></see></summary>
    let directlyPrecedesCognitiveStep =
        Namespaced_IRI.parse _namespace_name "directlyPrecedesCognitiveStep" |> NamespacedName

    /// <summary>
    /// (x directlyPrecedesByRupture y) == x is the cognitive step that directly precedes y logically (and typically, y takes over a dyadic representation relation from x), but either x or y constitutes a cognitive rupture, i.e., it interrupts the chain of grounding
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesByRupture"></see></summary>
    let directlyPrecedesByRupture =
        Namespaced_IRI.parse _namespace_name "directlyPrecedesByRupture" |> NamespacedName

    /// <summary>
    /// (x directlyPrecedesStep y) means that x and y are processes such that y can commence when x (and possibly other steps that also directly precede y) has finished
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesStep"></see></summary>
    let directlyPrecedesStep =
        Namespaced_IRI.parse _namespace_name "directlyPrecedesStep" |> NamespacedName

    /// <summary>
    /// 'precedesStep' is the transitive closure of 'directlyPrecedesStep'; (x precedesStep y) means that the processes x and y are, possibly indirectly, causally connected such that x needs to be concluded before y can commence
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#precedesStep"></see></summary>
    let precedesStep =
        Namespaced_IRI.parse _namespace_name "precedesStep" |> NamespacedName

    /// <summary>
    /// Direct causal connection (in a broad sense)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasDirectCausalConnectionWith"></see></summary>
    let hasDirectCausalConnectionWith =
        Namespaced_IRI.parse _namespace_name "hasDirectCausalConnectionWith" |> NamespacedName

    /// <summary>
    /// (x doesNotOverlapWith y) is the negation of (x overlapsWith y); i.e., the spatiotemporal intersection of x and y is empty
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#doesNotOverlapWith"></see></summary>
    let doesNotOverlapWith =
        Namespaced_IRI.parse _namespace_name "doesNotOverlapWith" |> NamespacedName

    /// <summary>
    /// Top mereosemiotic relation: Direct or indirect connection through mereotopological and semiotic relations
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMereosemioticallyRelatedTo"></see></summary>
    let isMereosemioticallyRelatedTo =
        Namespaced_IRI.parse _namespace_name "isMereosemioticallyRelatedTo" |> NamespacedName

    /// <summary>
    /// (x doesNotTemporallyOverlapWith y) is the negation of (x temporallyOverlapsWith y); i.e., there is no temporal overlap between x and y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#doesNotTemporallyOverlapWith"></see></summary>
    let doesNotTemporallyOverlapWith =
        Namespaced_IRI.parse _namespace_name "doesNotTemporallyOverlapWith" |> NamespacedName

    /// <summary>
    /// (x hasAbsoluteNecessityMode y) means that x is a relational IRI and y is an absolute modal IRI for 'necessarily x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasAbsoluteNecessityMode"></see></summary>
    let hasAbsoluteNecessityMode =
        Namespaced_IRI.parse _namespace_name "hasAbsoluteNecessityMode" |> NamespacedName

    /// <summary>
    /// (x hasNecessityMode y) means that x is a relational IRI and y is a modal IRI for 'necessarily x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasNecessityMode"></see></summary>
    let hasNecessityMode =
        Namespaced_IRI.parse _namespace_name "hasNecessityMode" |> NamespacedName

    /// <summary>
    /// (x hasAbsolutePossibilityMode y) means that x is a relational IRI and y is an absolute modal IRI for 'possibly x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasAbsolutePossibilityMode"></see></summary>
    let hasAbsolutePossibilityMode =
        Namespaced_IRI.parse _namespace_name "hasAbsolutePossibilityMode" |> NamespacedName

    /// <summary>
    /// (x hasPossibilityMode y) means that x is a relational IRI and y is a modal IRI for 'possibly x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasPossibilityMode"></see></summary>
    let hasPossibilityMode =
        Namespaced_IRI.parse _namespace_name "hasPossibilityMode" |> NamespacedName

    /// <summary>
    /// 'Real causal connection' relation following Peirce, here, given by the transitive closure of 'hasDirectCausalConnectionWith'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasCausalConnectionWith"></see></summary>
    let hasCausalConnectionWith =
        Namespaced_IRI.parse _namespace_name "hasCausalConnectionWith" |> NamespacedName

    /// <summary>
    /// Spatiotemporal (mereological) improper parthood relation; in other words, it is the reflexive closure of proper parthood: (x hasImproperPart y) means that all points within y are also within x
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasImproperPart"></see></summary>
    let hasImproperPart =
        Namespaced_IRI.parse _namespace_name "hasImproperPart" |> NamespacedName

    /// <summary>
    /// (x overlapsWith y) means that x and y share a spatiotemporal region where x and y intersect
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#overlapsWith"></see></summary>
    let overlapsWith =
        Namespaced_IRI.parse _namespace_name "overlapsWith" |> NamespacedName

    /// <summary>
    /// Spatiotemporal (mereological) improper parthood relation; in other words, it is the reflexive closure of proper parthood: (x isImproperPartOf y) means that all points within x are also within y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isImproperPartOf"></see></summary>
    let isImproperPartOf =
        Namespaced_IRI.parse _namespace_name "isImproperPartOf" |> NamespacedName

    /// <summary>
    /// (x hasNegation y) means that x and y are IRIs that can possibly occur in the predicate (middle) position of a triple, and that y is 'not x'; n.b., this is not a symmetrical relation, since 'not not x' is syntactically different from x
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasNegation"></see></summary>
    let hasNegation =
        Namespaced_IRI.parse _namespace_name "hasNegation" |> NamespacedName

    /// <summary>
    /// (x hasQualifiedNecessityMode y) means that x is a relational IRI and y is a qualified modal IRI for 'necessarily x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasQualifiedNecessityMode"></see></summary>
    let hasQualifiedNecessityMode =
        Namespaced_IRI.parse _namespace_name "hasQualifiedNecessityMode" |> NamespacedName

    /// <summary>
    /// (x hasQualifiedPossibilityMode y) means that x is a relational IRI and y is a qualified modal IRI for 'possibly x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasQualifiedPossibilityMode"></see></summary>
    let hasQualifiedPossibilityMode =
        Namespaced_IRI.parse _namespace_name "hasQualifiedPossibilityMode" |> NamespacedName

    /// <summary>
    /// Dyadic representation relation; (x hasRepresentamen y) means that there is a cognitive step z such that (x isReferentIn z) and (y isRepresentamenIn z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasRepresentamen"></see></summary>
    let hasRepresentamen =
        Namespaced_IRI.parse _namespace_name "hasRepresentamen" |> NamespacedName

    /// <summary>
    /// (X msHRHPIP Z) == hasRepresentamen o hasProperPart o isProperPartOf == there is a Y such that (Y isRepresentamenFor X) and (Y overlapsWith Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIP"></see></summary>
    let msHRHPIP = Namespaced_IRI.parse _namespace_name "msHRHPIP" |> NamespacedName
    /// <summary>
    /// (X msHPIPHR Z) == hasProperPart o isProperPartOf o hasRepresentamen == there is a Y such that (X overlapsWith Y) and (Z isRepresentamenFor Y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHR"></see></summary>
    let msHPIPHR = Namespaced_IRI.parse _namespace_name "msHPIPHR" |> NamespacedName
    /// <summary>
    /// chain relation hasRepresentamen o sharesReferentWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHR"></see></summary>
    let msHRIRHR = Namespaced_IRI.parse _namespace_name "msHRIRHR" |> NamespacedName

    /// <summary>
    /// (x isReferentIn y) == x occurs in the cognitive step y in the function of the/a referent of a representamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isReferentIn"></see></summary>
    let isReferentIn =
        Namespaced_IRI.parse _namespace_name "isReferentIn" |> NamespacedName

    /// <summary>
    /// (x isAccumulationConditionIn y) == in the accumulation process y, the condition x controls in what way the input and the additionally included elements interact to yield a combined output
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationConditionIn"></see></summary>
    let isAccumulationConditionIn =
        Namespaced_IRI.parse _namespace_name "isAccumulationConditionIn" |> NamespacedName

    /// <summary>
    /// (x isProperParticipantIn y) is the conjunction of (x isProperPartOf y) and (x isParticipantIn y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isProperParticipantIn"></see></summary>
    let isProperParticipantIn =
        Namespaced_IRI.parse _namespace_name "isProperParticipantIn" |> NamespacedName

    /// <summary>
    /// (x isAdmissibleUnitFor y) means that x is a unit that can be associated with the variable y; subsumption under msHPIPIR is explained as follows: There is a sign z for the variable y (where z is a description of admissible values of y) of which x is constitutive (and with which x hence overlaps)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAdmissibleUnitFor"></see></summary>
    let isAdmissibleUnitFor =
        Namespaced_IRI.parse _namespace_name "isAdmissibleUnitFor" |> NamespacedName

    /// <summary>
    /// (X msHPIPIR Z) == hasProperPart o isProperPartOf o isRepresentamenFor == there is a Y such that (X overlapsWith Y) and (Y isRepresentamenFor Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIR"></see></summary>
    let msHPIPIR = Namespaced_IRI.parse _namespace_name "msHPIPIR" |> NamespacedName
    /// <summary>
    /// chain relation msIPIR o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRIR"></see></summary>
    let msIPIRIR = Namespaced_IRI.parse _namespace_name "msIPIRIR" |> NamespacedName

    /// <summary>
    /// (x isExpressedBy y) means that x is expressed/stated/uttered by the interlocutor y; n.b., this does not necessarily mean that y affirms x (for that, use the subproperty isAssertedBy)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isExpressedBy"></see></summary>
    let isExpressedBy =
        Namespaced_IRI.parse _namespace_name "isExpressedBy" |> NamespacedName

    /// <summary>
    /// (x isAssertedIn y) means that x is a claim that is affirmatively expressed/stated/uttered in the expressive act y (by its speaker)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAssertedIn"></see></summary>
    let isAssertedIn =
        Namespaced_IRI.parse _namespace_name "isAssertedIn" |> NamespacedName

    /// <summary>
    /// (x isExpressedIn y) means that x is expressed/stated/uttered in the expressive act y (by its speaker), possibly but not necessarily in an affirmative way
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isExpressedIn"></see></summary>
    let isExpressedIn =
        Namespaced_IRI.parse _namespace_name "isExpressedIn" |> NamespacedName

    /// <summary>
    /// (x isCausallyDisconnectedFrom y) means that between x and y there is no 'real causal connection' in the Peircean sense; therefore, x and y cannot be the old and new referents in a metonymization; similarly, x cannot act as a representamen for y in a grounded cognition (if it does, then the cognition is not grounded)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isCausallyDisconnectedFrom"></see></summary>
    let isCausallyDisconnectedFrom =
        Namespaced_IRI.parse _namespace_name "isCausallyDisconnectedFrom" |> NamespacedName

    /// <summary>
    /// In certain cases, multiple cognitive steps can be combined to yield one; e.g., the substep a: s - o - s' and the substep b: s' - o - s'' can be combined to yield a single triad, (a o b) = c: s - o - s''; in that case, c can be an element of a higher-order cognitive chain (of which it is a step), and a and b are its cognitive substeps
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isCognitiveSubstepOf"></see></summary>
    let isCognitiveSubstepOf =
        Namespaced_IRI.parse _namespace_name "isCognitiveSubstepOf" |> NamespacedName

    /// <summary>
    /// (x isConstitutiveOf y) means that, by virtue of an interaction requiring spatiotemporal overlap, x contributes causally to y fulfilling a certain function, exhibiting certain properties, or relating to other objects in the way it does, thereby creating a direct causal connection between x and y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isConstitutiveOf"></see></summary>
    let isConstitutiveOf =
        Namespaced_IRI.parse _namespace_name "isConstitutiveOf" |> NamespacedName

    /// <summary>
    /// the relation 'underlies' is the transitive closure of the relation 'isConstitutiveOf'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#underlies"></see></summary>
    let underlies = Namespaced_IRI.parse _namespace_name "underlies" |> NamespacedName

    /// <summary>
    /// (x isParticipantInCognition y) means that y is a cognition in which x is necessarily physically present and plays one of the roles characteristic for participation in a cognitive process as formalized by this ontology; this includes participation as a representamen, as a perceived object, as a step of a cognitive chain, or as an interpreter
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isParticipantInCognition"></see></summary>
    let isParticipantInCognition =
        Namespaced_IRI.parse _namespace_name "isParticipantInCognition" |> NamespacedName

    /// <summary>
    /// 'x isTriadOf (e1 e2 e3)' is a shorthand for 'e1 isFirstElementIn x; e2 isSecondElementIn x; e3 isThirdElementIn x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTriadOf"></see></summary>
    let isTriadOf = Namespaced_IRI.parse _namespace_name "isTriadOf" |> NamespacedName
    /// <summary>
    /// x isFusionOf (y1 y2 ... yn) means that x is the spatiotemporal union (i.e., fusion) of all the elements included in the list (y1 y2 ... yn)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isFusionOf"></see></summary>
    let isFusionOf = Namespaced_IRI.parse _namespace_name "isFusionOf" |> NamespacedName

    /// <summary>
    /// Top property for multi-argument predicates that are implemented as 'x isRelatedToList (y1 y2 ... yn)', i.e., such that the object is an rdf:List
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isRelatedToList"></see></summary>
    let isRelatedToList =
        Namespaced_IRI.parse _namespace_name "isRelatedToList" |> NamespacedName

    /// <summary>
    /// (x isHeldBy y) means that the claim x is consistently asserted by the knowledge base y whenever it is queried about it; if y extends significantly through time and changes opinion about x (i.e., it does not assert it consistently over the whole time), it cannot be said to hold x as a claim, merely to assert it; in this case, it may be advisable to define a (temporal) part y' of y which can then be said to hold x as a claim
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isHeldBy"></see></summary>
    let isHeldBy = Namespaced_IRI.parse _namespace_name "isHeldBy" |> NamespacedName

    /// <summary>
    /// (x isInitialStepIn y) means that y is a step in x (i.e., a subprocess of x) that is not preceded by any other step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInitialStepIn"></see></summary>
    let isInitialStepIn =
        Namespaced_IRI.parse _namespace_name "isInitialStepIn" |> NamespacedName

    /// <summary>
    /// (x isStepIn y) means that x and y are processes, where x is a proper part of y that plays a well-defined role within y (e.g., a task within a project, the execution of a single command within the execution of a program, etc.)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isStepIn"></see></summary>
    let isStepIn = Namespaced_IRI.parse _namespace_name "isStepIn" |> NamespacedName

    /// <summary>
    /// (x isListenerIn y) means that x is one of the interlocutors listening to the speaker's expressive act y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isListenerIn"></see></summary>
    let isListenerIn =
        Namespaced_IRI.parse _namespace_name "isListenerIn" |> NamespacedName

    /// <summary>
    /// (x isMaximizationObjectiveIn y) == x is a maximization objective/criterion considered in the optimization problem y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMaximizationObjectiveIn"></see></summary>
    let isMaximizationObjectiveIn =
        Namespaced_IRI.parse _namespace_name "isMaximizationObjectiveIn" |> NamespacedName

    /// <summary>
    /// (x isMaximizationObjectiveIn y) == x is a maximization objective/criterion considered in the optimization problem y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMinimizationObjectiveIn"></see></summary>
    let isMinimizationObjectiveIn =
        Namespaced_IRI.parse _namespace_name "isMinimizationObjectiveIn" |> NamespacedName

    /// <summary>
    /// (x isParadataWithin y) means that x articulates something explicitly said to be unsubstantial to the rule y, and thereby semiotically constitutive of it, e.g., by a mechanism of logical subtraction
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isParadataWithin"></see></summary>
    let isParadataWithin =
        Namespaced_IRI.parse _namespace_name "isParadataWithin" |> NamespacedName

    /// <summary>
    /// (x isTemporallyIncludedIn y) means that the temporal extension of x is a proper part of the temporal extension of y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTemporallyIncludedIn"></see></summary>
    let isTemporallyIncludedIn =
        Namespaced_IRI.parse _namespace_name "isTemporallyIncludedIn" |> NamespacedName

    /// <summary>
    /// (s isReferenceFrameFor s') means that s is a representamen that provides relevant context, such as presuppositions or preconditions, to the representamen s'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isReferenceFrameFor"></see></summary>
    let isReferenceFrameFor =
        Namespaced_IRI.parse _namespace_name "isReferenceFrameFor" |> NamespacedName

    /// <summary>
    /// (X sharesReferentWith Z) == there is a Y such that both X and Z isRepresentamenFor Y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#sharesReferentWith"></see></summary>
    let sharesReferentWith =
        Namespaced_IRI.parse _namespace_name "sharesReferentWith" |> NamespacedName

    /// <summary>
    /// chain relation sharesReferentWith o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRIR"></see></summary>
    let msIRHRIR = Namespaced_IRI.parse _namespace_name "msIRHRIR" |> NamespacedName
    /// <summary>
    /// (x isResultOf y) if x is an outcome/result of the cognitive process y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isResultOf"></see></summary>
    let isResultOf = Namespaced_IRI.parse _namespace_name "isResultOf" |> NamespacedName

    /// <summary>
    /// (x isSelectionConditionIn y) == in the selection process y, the condition x controls what constitutive element(s) of the input are retained as part of the output
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSelectionConditionIn"></see></summary>
    let isSelectionConditionIn =
        Namespaced_IRI.parse _namespace_name "isSelectionConditionIn" |> NamespacedName

    /// <summary>
    /// (x isSpatiotemporallyConnectedWith y) means that x and y overlap or are directly adjacent to each other at some point; i.e., there is a point p_x in x and a point p_y in y such that you can go from p_x to p_y without ever leaving the fusion (x U y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSpatiotemporallyConnectedWith"></see></summary>
    let isSpatiotemporallyConnectedWith =
        Namespaced_IRI.parse _namespace_name "isSpatiotemporallyConnectedWith" |> NamespacedName

    /// <summary>
    /// (x isTemporallyConnectedWith y) means that there is a point in time where both x and y exist
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTemporallyConnectedWith"></see></summary>
    let isTemporallyConnectedWith =
        Namespaced_IRI.parse _namespace_name "isTemporallyConnectedWith" |> NamespacedName

    /// <summary>
    /// (x isTerminalStepIn y) means that y is a step in x (i.e., a subprocess of x) that does not precede any other step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTerminalStepIn"></see></summary>
    let isTerminalStepIn =
        Namespaced_IRI.parse _namespace_name "isTerminalStepIn" |> NamespacedName

    /// <summary>
    /// (x isTargetPropertyIn y) means that cognitive action x targets y as the property for which a value is to be determined by observation or by theoretical or computational methods
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTargetPropertyIn"></see></summary>
    let isTargetPropertyIn =
        Namespaced_IRI.parse _namespace_name "isTargetPropertyIn" |> NamespacedName

    /// <summary>
    /// (x temporallyCoextendsWith y) means that x and y have exactly the same extension in time, i.e., disregarding their spatial extension
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#temporallyCoextendsWith"></see></summary>
    let temporallyCoextendsWith =
        Namespaced_IRI.parse _namespace_name "temporallyCoextendsWith" |> NamespacedName

    /// <summary>
    /// (x temporallyOverlapsWith y) means that there is an (extended) interval in time where both x and y exist
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#temporallyOverlapsWith"></see></summary>
    let temporallyOverlapsWith =
        Namespaced_IRI.parse _namespace_name "temporallyOverlapsWith" |> NamespacedName

    /// <summary>
    /// (x isToolIn y) means that x is employed by an agent during the action y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isToolIn"></see></summary>
    let isToolIn = Namespaced_IRI.parse _namespace_name "isToolIn" |> NamespacedName
    /// <summary>
    /// (X msHPHR Z) == hasProperPart o hasRepresentamen == there is a Y such that (Y isProperPartOf X) and (Z isRepresentamenFor Y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHR"></see></summary>
    let msHPHR = Namespaced_IRI.parse _namespace_name "msHPHR" |> NamespacedName
    /// <summary>
    /// chain relation msHPHR o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHPIP"></see></summary>
    let msHPHRHPIP = Namespaced_IRI.parse _namespace_name "msHPHRHPIP" |> NamespacedName
    /// <summary>
    /// (X msIRIP Z) == isRepresentamenFor o isProperPartOf == there is a Y such that (X isRepresentamenFor Y) and (Y isProperPartOf Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIP"></see></summary>
    let msIRIP = Namespaced_IRI.parse _namespace_name "msIRIP" |> NamespacedName
    /// <summary>
    /// chain relation msHPHR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHP"></see></summary>
    let msHPHRHP = Namespaced_IRI.parse _namespace_name "msHPHRHP" |> NamespacedName
    /// <summary>
    /// chain relation overlapsWith o msHRHP
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRHP"></see></summary>
    let msHPIPHRHP = Namespaced_IRI.parse _namespace_name "msHPIPHRHP" |> NamespacedName
    /// <summary>
    /// chain relation msIPIR o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRIP"></see></summary>
    let msIPIRIP = Namespaced_IRI.parse _namespace_name "msIPIRIP" |> NamespacedName
    /// <summary>
    /// chain relation overlapsWith o msIRIP
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRIP"></see></summary>
    let msHPIPIRIP = Namespaced_IRI.parse _namespace_name "msHPIPIRIP" |> NamespacedName
    /// <summary>
    /// chain relation msHPHR o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHR"></see></summary>
    let msHPHRHR = Namespaced_IRI.parse _namespace_name "msHPHRHR" |> NamespacedName
    /// <summary>
    /// chain relation overlapsWith o msHRHR
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRHR"></see></summary>
    let msHPIPHRHR = Namespaced_IRI.parse _namespace_name "msHPIPHRHR" |> NamespacedName
    /// <summary>
    /// chain relation msIRIR o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRIP"></see></summary>
    let msIRIRIP = Namespaced_IRI.parse _namespace_name "msIRIRIP" |> NamespacedName
    /// <summary>
    /// chain relation msHPHR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRIP"></see></summary>
    let msHPHRIP = Namespaced_IRI.parse _namespace_name "msHPHRIP" |> NamespacedName
    /// <summary>
    /// chain relation overlapsWith o msHRIP
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRIP"></see></summary>
    let msHPIPHRIP = Namespaced_IRI.parse _namespace_name "msHPIPHRIP" |> NamespacedName
    /// <summary>
    /// chain relation msHPIR o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRIP"></see></summary>
    let msHPIRIP = Namespaced_IRI.parse _namespace_name "msHPIRIP" |> NamespacedName
    /// <summary>
    /// chain relation hasProperPart o sharesRepresentamenWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRIR"></see></summary>
    let msHPHRIR = Namespaced_IRI.parse _namespace_name "msHPHRIR" |> NamespacedName
    /// <summary>
    /// chain relation overlapsWith o sharesRepresentamenWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRIR"></see></summary>
    let msHPIPHRIR = Namespaced_IRI.parse _namespace_name "msHPIPHRIR" |> NamespacedName
    /// <summary>
    /// chain relation sharesRepresentamenWith o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRIP"></see></summary>
    let msHRIRIP = Namespaced_IRI.parse _namespace_name "msHRIRIP" |> NamespacedName

    /// <summary>
    /// (X sharesRepresentamenWith Z) == there is a Y such that Y isRepresentamenFor both X and Z
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#sharesRepresentamenWith"></see></summary>
    let sharesRepresentamenWith =
        Namespaced_IRI.parse _namespace_name "sharesRepresentamenWith" |> NamespacedName

    /// <summary>
    /// chain relation msIPIR o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHPIP"></see></summary>
    let msIPIRHPIP = Namespaced_IRI.parse _namespace_name "msIPIRHPIP" |> NamespacedName
    /// <summary>
    /// (X msHRHP Z) == hasRepresentamen o hasProperPart == there is a Y such that (Y isRepresentamenFor X) and (Z isProperPartOf Y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHP"></see></summary>
    let msHRHP = Namespaced_IRI.parse _namespace_name "msHRHP" |> NamespacedName
    /// <summary>
    /// chain relation msIRIR o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHPIP"></see></summary>
    let msIRIRHPIP = Namespaced_IRI.parse _namespace_name "msIRIRHPIP" |> NamespacedName
    /// <summary>
    /// (X msHRHR Z) == (hasRepresentamen)^2 == there is a Y such that (Y isRepresentamenFor X) and (Z isRepresentamenFor Y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHR"></see></summary>
    let msHRHR = Namespaced_IRI.parse _namespace_name "msHRHR" |> NamespacedName
    /// <summary>
    /// chain relation msHPIR o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHPIP"></see></summary>
    let msHPIRHPIP = Namespaced_IRI.parse _namespace_name "msHPIRHPIP" |> NamespacedName
    /// <summary>
    /// (X msHRIP Z) == hasRepresentamen o isProperPartOf == there is a Y such that (Y isRepresentamenFor X) and (Y isProperPartOf Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIP"></see></summary>
    let msHRIP = Namespaced_IRI.parse _namespace_name "msHRIP" |> NamespacedName
    /// <summary>
    /// chain relation sharesRepresentamenWith o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHPIP"></see></summary>
    let msHRIRHPIP = Namespaced_IRI.parse _namespace_name "msHRIRHPIP" |> NamespacedName
    /// <summary>
    /// chain relation overlapsWith o msIRHP
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRHP"></see></summary>
    let msHPIPIRHP = Namespaced_IRI.parse _namespace_name "msHPIPIRHP" |> NamespacedName
    /// <summary>
    /// chain relation msIPHR o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHPIP"></see></summary>
    let msIPHRHPIP = Namespaced_IRI.parse _namespace_name "msIPHRHPIP" |> NamespacedName
    /// <summary>
    /// (X msIRHP Z) == isRepresentamenFor o hasProperPart == there is a Y such that (X isRepresentamenFor Y) and (Z isProperPartOf Y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHP"></see></summary>
    let msIRHP = Namespaced_IRI.parse _namespace_name "msIRHP" |> NamespacedName
    /// <summary>
    /// chain relation overlapsWith o sharesReferentWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRHR"></see></summary>
    let msHPIPIRHR = Namespaced_IRI.parse _namespace_name "msHPIPIRHR" |> NamespacedName
    /// <summary>
    /// chain relation sharesReferentWith o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHPIP"></see></summary>
    let msIRHRHPIP = Namespaced_IRI.parse _namespace_name "msIRHRHPIP" |> NamespacedName
    /// <summary>
    /// chain relation overlapsWith o msIRIR
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRIR"></see></summary>
    let msHPIPIRIR = Namespaced_IRI.parse _namespace_name "msHPIPIRIR" |> NamespacedName
    /// <summary>
    /// chain relation msHRHR o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHPIP"></see></summary>
    let msHRHRHPIP = Namespaced_IRI.parse _namespace_name "msHRHRHPIP" |> NamespacedName
    /// <summary>
    /// (X msIRIR Z) == (isRepresentamenFor)^2 == there is a Y such that (X isRepresentamenFor Y) and (Y isRepresentamenFor Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIR"></see></summary>
    let msIRIR = Namespaced_IRI.parse _namespace_name "msIRIR" |> NamespacedName
    /// <summary>
    /// (X msHPIR Z) == hasProperPart o isRepresentamenFor == there is a Y such that (Y isProperPartOf X) and (Y is RepresentamenFor Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIR"></see></summary>
    let msHPIR = Namespaced_IRI.parse _namespace_name "msHPIR" |> NamespacedName
    /// <summary>
    /// chain relation msHPIR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHP"></see></summary>
    let msHPIRHP = Namespaced_IRI.parse _namespace_name "msHPIRHP" |> NamespacedName
    /// <summary>
    /// chain relation msIPHR o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRIP"></see></summary>
    let msIPHRIP = Namespaced_IRI.parse _namespace_name "msIPHRIP" |> NamespacedName
    /// <summary>
    /// chain relation hasProperPart o sharesReferentWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHR"></see></summary>
    let msHPIRHR = Namespaced_IRI.parse _namespace_name "msHPIRHR" |> NamespacedName
    /// <summary>
    /// chain relation sharesReferentWith o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRIP"></see></summary>
    let msIRHRIP = Namespaced_IRI.parse _namespace_name "msIRHRIP" |> NamespacedName
    /// <summary>
    /// chain relation msHPIR o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRIR"></see></summary>
    let msHPIRIR = Namespaced_IRI.parse _namespace_name "msHPIRIR" |> NamespacedName
    /// <summary>
    /// chain relation msHRHR o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRIP"></see></summary>
    let msHRHRIP = Namespaced_IRI.parse _namespace_name "msHRHRIP" |> NamespacedName
    /// <summary>
    /// (X msIP Z) == isProperPartOf o isRepresentamenFor == there is a Y such that (X isProperPartOf Y) and (Y isRepresentamenFor Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIR"></see></summary>
    let msIPIR = Namespaced_IRI.parse _namespace_name "msIPIR" |> NamespacedName
    /// <summary>
    /// chain relation msHRHP o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPHR"></see></summary>
    let msHRHPHR = Namespaced_IRI.parse _namespace_name "msHRHPHR" |> NamespacedName
    /// <summary>
    /// chain relation msHRHP o msIPHR
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIPHR"></see></summary>
    let msHRHPIPHR = Namespaced_IRI.parse _namespace_name "msHRHPIPHR" |> NamespacedName
    /// <summary>
    /// chain relation msIRIP o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIPIR"></see></summary>
    let msIRIPIR = Namespaced_IRI.parse _namespace_name "msIRIPIR" |> NamespacedName
    /// <summary>
    /// chain relation msIRHP o msIPIR
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIPIR"></see></summary>
    let msIRHPIPIR = Namespaced_IRI.parse _namespace_name "msIRHPIPIR" |> NamespacedName
    /// <summary>
    /// (X msIPHR Z) == isProperPartOf o hasRepresentamen == there is a Y such that (X isProperPartOf Y) and (Z isRepresentamenFor Y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHR"></see></summary>
    let msIPHR = Namespaced_IRI.parse _namespace_name "msIPHR" |> NamespacedName
    /// <summary>
    /// chain relation msHRHP o msIPIR
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIPIR"></see></summary>
    let msHRHPIPIR = Namespaced_IRI.parse _namespace_name "msHRHPIPIR" |> NamespacedName
    /// <summary>
    /// chain relation msHRHP o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIR"></see></summary>
    let msHRHPIR = Namespaced_IRI.parse _namespace_name "msHRHPIR" |> NamespacedName
    /// <summary>
    /// chain relation msHRIP o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIPIR"></see></summary>
    let msHRIPIR = Namespaced_IRI.parse _namespace_name "msHRIPIR" |> NamespacedName
    /// <summary>
    /// chain relation msHRHR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHP"></see></summary>
    let msHRHRHP = Namespaced_IRI.parse _namespace_name "msHRHRHP" |> NamespacedName
    /// <summary>
    /// chain relation msHRHR o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHR"></see></summary>
    let msHRHRHR = Namespaced_IRI.parse _namespace_name "msHRHRHR" |> NamespacedName
    /// <summary>
    /// chain relation msIRIR o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRIR"></see></summary>
    let msIRIRIR = Namespaced_IRI.parse _namespace_name "msIRIRIR" |> NamespacedName
    /// <summary>
    /// chain relation hasRepresentamen o sharesRepresentamenWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRIR"></see></summary>
    let msHRHRIR = Namespaced_IRI.parse _namespace_name "msHRHRIR" |> NamespacedName
    /// <summary>
    /// chain relation sharesRepresentamenWith o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRIR"></see></summary>
    let msHRIRIR = Namespaced_IRI.parse _namespace_name "msHRIRIR" |> NamespacedName
    /// <summary>
    /// chain relation msHRIP o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIPHR"></see></summary>
    let msHRIPHR = Namespaced_IRI.parse _namespace_name "msHRIPHR" |> NamespacedName
    /// <summary>
    /// chain relation msIRHP o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIR"></see></summary>
    let msIRHPIR = Namespaced_IRI.parse _namespace_name "msIRHPIR" |> NamespacedName
    /// <summary>
    /// chain relation sharesRepresentamenWith o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHP"></see></summary>
    let msHRIRHP = Namespaced_IRI.parse _namespace_name "msHRIRHP" |> NamespacedName
    /// <summary>
    /// chain relation isProperPartOf o sharesRepresentamenWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRIR"></see></summary>
    let msIPHRIR = Namespaced_IRI.parse _namespace_name "msIPHRIR" |> NamespacedName
    /// <summary>
    /// chain relation msIPHR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHP"></see></summary>
    let msIPHRHP = Namespaced_IRI.parse _namespace_name "msIPHRHP" |> NamespacedName
    /// <summary>
    /// chain relation msIPIR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHP"></see></summary>
    let msIPIRHP = Namespaced_IRI.parse _namespace_name "msIPIRHP" |> NamespacedName
    /// <summary>
    /// chain relation msIPHR o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHR"></see></summary>
    let msIPHRHR = Namespaced_IRI.parse _namespace_name "msIPHRHR" |> NamespacedName
    /// <summary>
    /// chain relation msIRIR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHP"></see></summary>
    let msIRIRHP = Namespaced_IRI.parse _namespace_name "msIRIRHP" |> NamespacedName
    /// <summary>
    /// chain relation isProperPartOf o sharesReferentWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHR"></see></summary>
    let msIPIRHR = Namespaced_IRI.parse _namespace_name "msIPIRHR" |> NamespacedName
    /// <summary>
    /// chain relation sharesReferentWith o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHP"></see></summary>
    let msIRHRHP = Namespaced_IRI.parse _namespace_name "msIRHRHP" |> NamespacedName
    /// <summary>
    /// chain relation msIRHP o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPHR"></see></summary>
    let msIRHPHR = Namespaced_IRI.parse _namespace_name "msIRHPHR" |> NamespacedName
    /// <summary>
    /// chain relation msIRHP o msIPHR
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIPHR"></see></summary>
    let msIRHPIPHR = Namespaced_IRI.parse _namespace_name "msIRHPIPHR" |> NamespacedName
    /// <summary>
    /// chain relation msIRIP o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIPHR"></see></summary>
    let msIRIPHR = Namespaced_IRI.parse _namespace_name "msIRIPHR" |> NamespacedName
    /// <summary>
    /// chain relation sharesReferentWith o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHR"></see></summary>
    let msIRHRHR = Namespaced_IRI.parse _namespace_name "msIRHRHR" |> NamespacedName
    /// <summary>
    /// chain relation isRepresentamenFor o sharesReferentWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHR"></see></summary>
    let msIRIRHR = Namespaced_IRI.parse _namespace_name "msIRIRHR" |> NamespacedName
