namespace http.www.molmod.info.semantics.pims_ii.ttl.hash

open DoxAletheia

module pimsii =
    let _namespace_name = "http://www.molmod.info/semantics/pims-ii.ttl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Absolute law, i.e., a law where the necessary entailment of the consequent(s) by the antecedent is expressed in terms of absolute logical/physical necessity
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#AbsoluteLaw"></see></summary>
    let AbsoluteLaw = _prefix "AbsoluteLaw"
    /// <summary>
    /// Law, i.e., a proposition consisting of an antecedent and one or multiple consequent(s) such that the antecedent is stated to necessarily imply the consequent(s)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Law"></see></summary>
    let Law = _prefix "Law"
    /// <summary>
    /// Absolute modal IRI, i.e., the IRI of a relation that is defined by absolute necessity or possibility of another relation. Absolute necessity means 'logical or physical necessity', and absolute possibility means 'logical or physical possibility'. Accordingly, absolute modal relations do not require the specification of a modal context, i.e., the frame of reference for understanding what 'necessity' and 'possibility' mean does not need to be specified.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#AbsoluteModalIRI"></see></summary>
    let AbsoluteModalIRI = _prefix "AbsoluteModalIRI"
    /// <summary>
    /// Modal IRI, i.e., the IRI of a relation that is defined by (absolute or qualified) necessity or possibility of another relation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ModalIRI"></see></summary>
    let ModalIRI = _prefix "ModalIRI"
    /// <summary>
    /// Abstract model property claim (CMPC), i.e., a model property claim that is not immediately applied to the corresponding property of a real physical system
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#AbstractModelPropertyClaim"></see></summary>
    let AbstractModelPropertyClaim = _prefix "AbstractModelPropertyClaim"
    /// <summary>
    /// Model property claim (MPC), i.e., a PC concerning a property of a model
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ModelPropertyClaim"></see></summary>
    let ModelPropertyClaim = _prefix "ModelPropertyClaim"
    /// <summary>
    /// Accumulation, i.e., an information-processing step in which the given information is extended/complemented such that the input (sign) and one or multiple additional representamina (cf. relation isIncludedInAccumulation) are jointly constitutive of the output (interpretant); this includes conditional accumulation, where the choice and the way in which information is combined depends on an accumulation condition (cf. relation isAccumulationConditionIn)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Accumulation"></see></summary>
    let Accumulation = _prefix "Accumulation"
    /// <summary>
    /// Object (PIMS-II top class) = cognizable entity
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    /// (x isAccumulationInputIn y) == y is an accumulation where x is the input (initially given information), i.e., the first element; n.b., in an accumulation, the input needs to be constitutive of the output
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationInputIn"></see></summary>
    let isAccumulationInputIn = _prefix "isAccumulationInputIn"
    /// <summary>
    /// (x isObjectInAccumulation y) == y is an accumulation where x is the object that the input and the output both represent, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInAccumulation"></see></summary>
    let isObjectInAccumulation = _prefix "isObjectInAccumulation"
    /// <summary>
    /// (x isAccumulationOutputIn y) == y is an accumulation where x is the output (combined information), i.e., the third element; n.b., in a selection, the input and any additionally included elements need to be constitutive of the output
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationOutputIn"></see></summary>
    let isAccumulationOutputIn = _prefix "isAccumulationOutputIn"
    /// <summary>
    /// (x isIncludedInAccumulation y) == y is an accumulation where x is combined with the accumulation input, yielding an output that x is constitutive of; n.b., x needs to act as a representamen for the object (e.g., as an interpretant from a preceding cognitive step with the same object)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isIncludedInAccumulation"></see></summary>
    let isIncludedInAccumulation = _prefix "isIncludedInAccumulation"
    /// <summary>
    /// Information processing, i.e., an interpretation in which information is handled, revised, reformatted, extended, or narrowed down (or anything comparable to such actions), e.g., preprocessing or postprocessing in a simulation workflow
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#InformationProcessing"></see></summary>
    let InformationProcessing = _prefix "InformationProcessing"
    /// <summary>
    /// Action, i.e., a process that is conducted/undertaken by an agent - the action has exactly one agent
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// Agent, i.e., an object that interacts with its surroundings by a) perceiving and b) doing, i.e., an object that carries out actions, including perceptive actions
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// (x isAgentIn y) means that x is *the* agent that conducts/undertakes the action y; n.b., an action has exactly one agent (which can be a straightforward item, or a plurality, a structure, or similar)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAgentIn"></see></summary>
    let isAgentIn = _prefix "isAgentIn"
    /// <summary>
    /// Process, i.e., a connected region that has at least one participant, an entity with which it overlaps spatiotemporally and that plays a certain role in the process
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Process"></see></summary>
    let Process = _prefix "Process"
    /// <summary>
    /// Articulation (collective expression), i.e., a semiotic collective the semiotic members (i.e., realizations) of which are not semiotic collectives, but individual literal (written or digital) or non-literal (e.g., spoken) items with the same semiotic function (or undergoing evaluation whether such a function is present)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Articulation"></see></summary>
    let Articulation = _prefix "Articulation"
    /// <summary>
    /// (x realizes y) means that x, which is not a semiotic collective, is a literal or non-literal realization of the expression y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#realizes"></see></summary>
    let realizes = _prefix "realizes"
    /// <summary>
    /// Semiotic collective, i.e., a collective the semiotic members of which act together as one representational element (i.e., referent or representamen) in a cognitive process
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#SemioticCollective"></see></summary>
    let SemioticCollective = _prefix "SemioticCollective"
    /// <summary>
    /// (x isSemioticMemberOf y) means that x acts as a representamen or as a referent jointly with other co-members of the same semiotic collective y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSemioticMemberOf"></see></summary>
    let isSemioticMemberOf = _prefix "isSemioticMemberOf"
    /// <summary>
    /// Assessment (of a cognitive step), i.e., a ground that provides an explanation including a proposition on the extent (quantitatively or qualitatively) to which the grounded cognitive step is reliable/accurate/valid (or similar), why that is the case, and how that relates to the reliability/accuracy/etc. of the preceding step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Assessment"></see></summary>
    let Assessment = _prefix "Assessment"
    /// <summary>
    /// Ground (of a cognitive step), i.e., a proposition that justifies a cognitive step by explaning it and stating from what preceding step (which directly grounds that step) a sign-object relation is carried over, and in what way
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Ground"></see></summary>
    let Ground = _prefix "Ground"
    /// <summary>
    /// Cognitive step, i.e., an elementary cognition that can form an part of a cognitive chain
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveStep"></see></summary>
    let CognitiveStep = _prefix "CognitiveStep"
    /// <summary>
    /// (g isAssessmentFor y) means that g is a ground for the cognitive step y, explaining how y is grounded in a way that provides a proposition on its validity, accuracy, and/or reliability, relating it to that of the previous step that directly grounds y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAssessmentFor"></see></summary>
    let isAssessmentFor = _prefix "isAssessmentFor"
    /// <summary>
    /// Assignment, i.e., an equality articulation by which a value is assigned to a variable with respect to a particular referent (e.g., T = 200 K for substance o as it was measured in a particular cognitive step); therein, T is the variable, related to the assignment by [inverseOf isVariableInAssignment], 200 K is the value, related to the assignment by [inverseOf isValueInAssignment], and o is the referent, related to the assignment by isAssignmentFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Assignment"></see></summary>
    let Assignment = _prefix "Assignment"
    /// <summary>
    /// Variable, i.e., a conventional that is employed for something to which values can be assigned (this may include different notations for the same variable including, e.g., computational representations); this is to be understood very generally, e.g., a variable may be an array or set of elements or have another kind of internal structure
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Variable"></see></summary>
    let Variable = _prefix "Variable"
    /// <summary>
    /// (x isVariableInAssignment a) mans that a: x = y is an assignment where a value y is assigned to the variable x
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isVariableInAssignment"></see></summary>
    let isVariableInAssignment = _prefix "isVariableInAssignment"
    /// <summary>
    /// Value, i.e., an articulation that is by social convention understood to be potentially assignable to a variable
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Value"></see></summary>
    let Value = _prefix "Value"
    /// <summary>
    /// (y isValueInAssignment a) mans that a: x = y is an assignment where the value y is assigned to a variable x
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isValueInAssignment"></see></summary>
    let isValueInAssignment = _prefix "isValueInAssignment"
    /// <summary>
    /// (d isAssignmentFor o) means that d: x = y is an assignment that refers to o
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAssignmentFor"></see></summary>
    let isAssignmentFor = _prefix "isAssignmentFor"
    /// <summary>
    /// Digital conventional, i.e., a conventional that is a digital articulation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#DigitalConventional"></see></summary>
    let DigitalConventional = _prefix "DigitalConventional"
    /// <summary>
    /// Equality articulation, i.e., a dyad by which two terms are asserted to be equal or to become equal
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#EqualityArticulation"></see></summary>
    let EqualityArticulation = _prefix "EqualityArticulation"
    /// <summary>
    /// Basic ground, i.e., a ground that is assumed to be valid and reliable a priori; a cognitive step for which there is a basic ground is a presupposition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#BasicGround"></see></summary>
    let BasicGround = _prefix "BasicGround"
    /// <summary>
    /// (g isGroundFor y) means that g is a representamen for the cognitive step y, explaining how y is grounded
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundFor"></see></summary>
    let isGroundFor = _prefix "isGroundFor"
    /// <summary>
    /// Presupposition, i.e., a cognition that has a basic ground, so that it is accepted a priori as an ultimate anchor point for epistemic grounding; any cognition that is logically preceded by a presupposition is a grounded cognition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Presupposition"></see></summary>
    let Presupposition = _prefix "Presupposition"
    /// <summary>
    /// Canonical TUCAN, i.e., the material identifier as developed within the NFDI4Chem project
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CanonicalTUCAN"></see></summary>
    let CanonicalTUCAN = _prefix "CanonicalTUCAN"
    /// <summary>
    /// Name or label that identifies the material of its referent, or the material that some semiotic collective is about
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#MaterialIdentifier"></see></summary>
    let MaterialIdentifier = _prefix "MaterialIdentifier"
    /// <summary>
    /// Claim, i.e., a proposition that is expressed by an interlocutor or believed/held by an intelligent agent
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Claim"></see></summary>
    let Claim = _prefix "Claim"
    /// <summary>
    /// Proposition, i.e., a semiotic collective the members of which are collective literals and collective utterances understood to be attributed some joint semantic and/or pragmatic content, or undergoing evaluation jointly for the presence of such a content
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Proposition"></see></summary>
    let Proposition = _prefix "Proposition"
    /// <summary>
    /// Interlocutor, i.e., an agent that can be addressed and is capable of addressing others in a communication process
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Interlocutor"></see></summary>
    let Interlocutor = _prefix "Interlocutor"
    /// <summary>
    /// (x isAssertedBy y) means that x is a claim that is affirmatively expressed/stated/uttered by the interlocutor y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAssertedBy"></see></summary>
    let isAssertedBy = _prefix "isAssertedBy"
    /// <summary>
    /// Intelligent agent, i.e., a goal-oriented agent that can internally make/hold claims (knowledge, beliefs, etc.). This requires the agent to have some kind of internal representation of its surroundings, and to store and process information about its surroundings. (Note that this does not require the agent to be queryable for its claims; for that purpose, use KnowledgeBase.)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#IntelligentAgent"></see></summary>
    let IntelligentAgent = _prefix "IntelligentAgent"
    /// <summary>
    /// (x isClaimOf y) means that the x is a proposition that has some kind of belief-like or knowledge-like epistemic status for the intelligent agent y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isClaimOf"></see></summary>
    let isClaimOf = _prefix "isClaimOf"
    /// <summary>
    /// Cognition, i.e., a process dealing with representamina (signs) consisting either of a single cognitive step, of multiple steps that are connected to each other as a cognitive chain, or of an anchor point for epistemic grounding
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Cognition"></see></summary>
    let Cognition = _prefix "Cognition"
    /// <summary>
    /// Cognitive chain, i.e., a cognition that consists of multiple (sub)steps
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveChain"></see></summary>
    let CognitiveChain = _prefix "CognitiveChain"
    /// <summary>
    /// Cognitive action, i.e., a cognition that is conducted/undertaken by an agent; the agent of a cognitive action is called its interpreter
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveAction"></see></summary>
    let CognitiveAction = _prefix "CognitiveAction"
    /// <summary>
    /// (x isInterpreterIn y) means that x is the (unique) agent who conducts/undertakes the cognitive action y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpreterIn"></see></summary>
    let isInterpreterIn = _prefix "isInterpreterIn"
    /// <summary>
    /// (x isStepInCognitiveChain y) means that y is a cognitive chain that consists of multiple logically connected cognitive steps (following Peirce, these are typically triads, i.e., semioses and semantic changes), and that x is one of these steps
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isStepInCognitiveChain"></see></summary>
    let isStepInCognitiveChain = _prefix "isStepInCognitiveChain"
    /// <summary>
    /// Cognitive rupture, i.e., a cognitive step that constitutes a break in the chain of epistemic grounding
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveRupture"></see></summary>
    let CognitiveRupture = _prefix "CognitiveRupture"
    /// <summary>
    /// Metonymization, i.e., a semantic change where there is a causal connection between the old and the new referent, so that the criterion of a 'real causal connection' (between signs and objects) from Peircean semiotics is preserved
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Metonymization"></see></summary>
    let Metonymization = _prefix "Metonymization"
    /// <summary>
    /// Semiosis, i.e., a triadic congition that relates 'the sign', 'the object', and 'the interpretant' to each other; a semiosis is either a perception (if the object needs to be present and participate physically in the process) or an interpretation (if the physical participation of the object is not inherently necessary)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Semiosis"></see></summary>
    let Semiosis = _prefix "Semiosis"
    /// <summary>
    /// Cognitive workflow, i.e., a purposefully conducted cognitive chain
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveWorkflow"></see></summary>
    let CognitiveWorkflow = _prefix "CognitiveWorkflow"
    /// <summary>
    /// Purposeful action, i.e., an action carried out with an aim of which its agent (hence, a goal-directed agent) is aware
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#PurposefulAction"></see></summary>
    let PurposefulAction = _prefix "PurposefulAction"
    /// <summary>
    /// Collective, i.e., an object that has multiple items as members
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Collective"></see></summary>
    let Collective = _prefix "Collective"
    /// <summary>
    /// membership relation, i.e., relation between an item/member and a collective
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMemberOf"></see></summary>
    let isMemberOf = _prefix "isMemberOf"
    /// <summary>
    /// Mereotopological collective, i.e., a region of spacetime that consists of multiple connected components, which are its mereotopological members
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#MereotopologicalCollective"></see></summary>
    let MereotopologicalCollective = _prefix "MereotopologicalCollective"
    /// <summary>
    /// Collective literal, i.e., a semiotic collective the members of which all have a digital, printed, or written textual/numerical form in that they are all instances/copies of the same RDFS literal (or multiple RDFS literals that are very similar, e.g., different ways of spelling/abbreviating the same word or denoting the same number); n.b., collective literals are not permitted to have other semiotic collectives as their semiotic members
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CollectiveLiteral"></see></summary>
    let CollectiveLiteral = _prefix "CollectiveLiteral"
    /// <summary>
    /// Collective utterance, i.e., a semiotic collective the members of which do not have digital, printed, or written textual/numerical form and the members of which are all attributed the same semantics and pragmatics; n.b., collective utterances are not permitted to have other semiotic collectives as their semiotic members
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#CollectiveUtterance"></see></summary>
    let CollectiveUtterance = _prefix "CollectiveUtterance"
    /// <summary>
    /// points to the expression of a collective literal as an RDFS literal (e.g., xs:string or xs:decimal)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isLiterally"></see></summary>
    let isLiterally = _prefix "isLiterally"
    /// <summary>
    /// Communication, i.e., a cognitive process wherein multiple interlocutors engage in an exchange with another; a communication involves at least one expressive act (with a well defined role, i.e. in terms of participation)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Communication"></see></summary>
    let Communication = _prefix "Communication"
    /// <summary>
    /// (x isInterlocutorIn y) means that x engages, jointly with other interlocutors, in the communication y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInterlocutorIn"></see></summary>
    let isInterlocutorIn = _prefix "isInterlocutorIn"
    /// <summary>
    /// Expressive act, i.e., a purposeful communication (e.g., a speech act or an analogous digital act of communicating) issued by its agent, the speaker (understood in a generalized sense, i.e., not limited to speech) - the purpose of the action consists of its illocutionary and perlocutionary intent
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ExpressiveAct"></see></summary>
    let ExpressiveAct = _prefix "ExpressiveAct"
    /// <summary>
    /// (x isParticipantIn y) means that y is a process in which x plays a certain role (e.g., x is a well-defined step within y, or x is an object that undergoes some change within y, or x is a sign that is read or an object that is perceived within y); this requires a spatiotemporal overlap between x and y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isParticipantIn"></see></summary>
    let isParticipantIn = _prefix "isParticipantIn"
    /// <summary>
    /// Conceptual IRI, i.e., the internationalized resource identifier of a concept (i.e., of an owl:Class)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ConceptualIRI"></see></summary>
    let ConceptualIRI = _prefix "ConceptualIRI"
    /// <summary>
    /// Internationalized resource identifier (IRI) as defined by RFC 3987; an IRI object should be related by 'isLiterally' to an xs:string containing the IRI literal
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#IRI"></see></summary>
    let IRI = _prefix "IRI"
    /// <summary>
    /// Relational IRI, i.e., the internationalized resource identifier of a something that can play the role of the predicate in a triple; this includes 'rdf:type', object properties, datatype properties, their negations
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#RelationalIRI"></see></summary>
    let RelationalIRI = _prefix "RelationalIRI"
    /// <summary>
    /// Conceptual knowledge claim (CKC), i.e., a knowledge claim establishing the ontological status of a lexeme
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ConceptualKnowledgeClaim"></see></summary>
    let ConceptualKnowledgeClaim = _prefix "ConceptualKnowledgeClaim"
    /// <summary>
    /// Knowledge claim (KC), i.e., a claim about something with respect to its knowledge status
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeClaim"></see></summary>
    let KnowledgeClaim = _prefix "KnowledgeClaim"
    /// <summary>
    /// Property claim (PC), i.e., a knowledge claim concerning a property
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#PropertyClaim"></see></summary>
    let PropertyClaim = _prefix "PropertyClaim"
    /// <summary>
    /// Concrete model property claim (CMPC), i.e., a model property claim that is immediately also applied to the corresponding property of a real physical system
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ConcreteModelPropertyClaim"></see></summary>
    let ConcreteModelPropertyClaim = _prefix "ConcreteModelPropertyClaim"
    /// <summary>
    /// Physical property claim (PPC), i.e., a PC concerning a property of a physical system
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#PhysicalPropertyClaim"></see></summary>
    let PhysicalPropertyClaim = _prefix "PhysicalPropertyClaim"
    /// <summary>
    /// Contextual IRI, i.e., the internationalized resource identifier of a modal context, i.e., the frame of reference for a qualified-modal semiotic collective; that context defines how exactly necessity and possibility are to be understood
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ContextualIRI"></see></summary>
    let ContextualIRI = _prefix "ContextualIRI"
    /// <summary>
    /// Conventional, i.e., a semiotic collective articulation the members of which jointly fulfill a certain semiotic function by social convention; e.g., many spoken or written occurrences of the words 'enthalpy of vaporization' or 'latent heat' may act together as a property in this sense
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Conventional"></see></summary>
    let Conventional = _prefix "Conventional"
    /// <summary>
    /// Dyadic representation relation; (x isRepresentamenFor y) means that there is a cognitive step z such that (x isRepresentamenIn z) and (y isReferentIn z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isRepresentamenFor"></see></summary>
    let isRepresentamenFor = _prefix "isRepresentamenFor"
    /// <summary>
    /// Data item, i.e., a digital articulation given as a tuple of digital conventionals
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#DataItem"></see></summary>
    let DataItem = _prefix "DataItem"
    /// <summary>
    /// (x isSemioticallyConstitutiveOf y) means that the evaluation or association with x plays a role in the way in which y functions as a representamen - n.b, this does not entail physical parthood; e.g., if 'q = 2f(p)' is given, the expression 'f(p) = ... (some term involving q)' may be seen as semiotically constituive of the first expression, precisely because it contains the right-hand side that was missing
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSemioticallyConstitutiveOf"></see></summary>
    let isSemioticallyConstitutiveOf = _prefix "isSemioticallyConstitutiveOf"
    /// <summary>
    /// Digital articulation, i.e., an articulation the members of which are copies of the same digital content (a file, assignment of a value to a variable, a data set, etc.)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#DigitalArticulation"></see></summary>
    let DigitalArticulation = _prefix "DigitalArticulation"
    /// <summary>
    /// Dataset, i.e., a digital articulation that is composed of multiple data items that are similar in shape, kind, and content type
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// Duplication, i.e., an information-processing step in which the given information is reproduced, copied, converted into a different, but equivalent format, or any similar procedure; e.g., this may be based on a legisign to which the original (sign) and the duplicate (interpretant) jointly conform or on a semiotic collective of which they both semiotic members
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Duplication"></see></summary>
    let Duplication = _prefix "Duplication"
    /// <summary>
    /// (x isOriginalIn y) == y is a duplication step where x is the input (original version), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOriginalIn"></see></summary>
    let isOriginalIn = _prefix "isOriginalIn"
    /// <summary>
    /// (x isObjectInDuplication y) == y is a duplication step where x is the object that the original and the duplicate both represent, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInDuplication"></see></summary>
    let isObjectInDuplication = _prefix "isObjectInDuplication"
    /// <summary>
    /// (x isDuplicateIn y) == y is a duplication step where x is the output (duplicate), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isDuplicateIn"></see></summary>
    let isDuplicateIn = _prefix "isDuplicateIn"
    /// <summary>
    /// Dyad, i.e., a data item by which two conventionals are grouped together; e.g., an equality or inequality articulation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Dyad"></see></summary>
    let Dyad = _prefix "Dyad"
    /// <summary>
    /// (x isFirstInDyad d) means that x is the first element of the dyad d
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isFirstInDyad"></see></summary>
    let isFirstInDyad = _prefix "isFirstInDyad"
    /// <summary>
    /// (y isSecondInDyad d) means that y is the second element of the dyad d
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSecondInDyad"></see></summary>
    let isSecondInDyad = _prefix "isSecondInDyad"
    /// <summary>
    /// EPRC, i.e., an exact-agreement provenance-conscious reproducibility claim
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#EPRC"></see></summary>
    let EPRC = _prefix "EPRC"

    /// <summary>
    /// Exact-agreement reproducibility claim (ERC), i.e., a reproducibility claim obtained as an outcome of an attempt at obtaining exactly the same outcome as the original study
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ExactAgreementReproducibilityClaim"></see></summary>
    let ExactAgreementReproducibilityClaim =
        _prefix "ExactAgreementReproducibilityClaim"

    /// <summary>
    /// Provenance-conscious reproducibility claim (PRC), i.e., a reproducibility claim obtained from an attempt that was subject to the requirement to retain the original research process or aspects of it
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ProvenanceConsciousReproducibilityClaim"></see></summary>
    let ProvenanceConsciousReproducibilityClaim =
        _prefix "ProvenanceConsciousReproducibilityClaim"

    /// <summary>
    /// EPTRC, i.e., an exact-agreement provenance-conscious team-change reproducibility claim
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#EPTRC"></see></summary>
    let EPTRC = _prefix "EPTRC"
    /// <summary>
    /// ETRC, i.e., an exact-agreement team-change reproducibility claim
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ETRC"></see></summary>
    let ETRC = _prefix "ETRC"
    /// <summary>
    /// PTRC, i.e., a provenance-conscious team-change reproducibility claim
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#PTRC"></see></summary>
    let PTRC = _prefix "PTRC"
    /// <summary>
    /// Team-change reproducibility claim (TRC), i.e., a reproducibility claim obtained as an outcome of a reproducibility study conducted by an independent team
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#TeamChangeReproducibilityClaim"></see></summary>
    let TeamChangeReproducibilityClaim = _prefix "TeamChangeReproducibilityClaim"
    /// <summary>
    /// Term, i.e., a conventional that can evaluate to a value; terms include variables, values, and any mathematically and semantically valid ways of combining variables, values, and mathematical operators - note that it is required for a term to potentially take a value
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Term"></see></summary>
    let Term = _prefix "Term"
    /// <summary>
    /// (x isLeftHandSideIn a) mans that a: x = y is an equality articulation with the term x as its left-hand side
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isLeftHandSideIn"></see></summary>
    let isLeftHandSideIn = _prefix "isLeftHandSideIn"
    /// <summary>
    /// (y isRightHandSideIn a) mans that a: x = y is an equality articulation with the term y as its right-hand side
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isRightHandSideIn"></see></summary>
    let isRightHandSideIn = _prefix "isRightHandSideIn"
    /// <summary>
    /// Evaluation, i.e., a reflection ex post (Reflexion des Vollzugs following Baumann and Tulatz) or redetermination, carried out after an action has terminated, either by the same agent or by somebody else
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Evaluation"></see></summary>
    let Evaluation = _prefix "Evaluation"
    /// <summary>
    /// (x isTelosInEvaluation y) == y is an evaluation (reflection ex post) where x acts as the telos (initial guiding objective), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInEvaluation"></see></summary>
    let isTelosInEvaluation = _prefix "isTelosInEvaluation"
    /// <summary>
    /// (x isEvaluatedIn y) == y is an evaluation (reflection ex post) where x is the action undergoing evaluation, i.e., the second element; n.b., the action needs to temporally precede the evaluation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isEvaluatedIn"></see></summary>
    let isEvaluatedIn = _prefix "isEvaluatedIn"
    /// <summary>
    /// Telesis (teleological semiosis), i.e., a semiosis where the sign is a telos (aim), the object is an action, claim, or situation against which that aim is evaluated, and the interpretant is a resolution, e.g., a revised objective, plan, or similar evaluation outcome
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Telesis"></see></summary>
    let Telesis = _prefix "Telesis"
    /// <summary>
    /// (x isEvaluationOutcomeIn y) == y is a an evaluation (reflection ex post) where x is the resolution (evaluation outcome), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isEvaluationOutcomeIn"></see></summary>
    let isEvaluationOutcomeIn = _prefix "isEvaluationOutcomeIn"
    /// <summary>
    /// Undertaking, i.e., a metonymization by which a resolution, which was previously determined (by telesis) in response to the pre-existing situation, is actively taken up by the agent, motivating an action
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Undertaking"></see></summary>
    let Undertaking = _prefix "Undertaking"
    /// <summary>
    /// (x directlyGrounds y) == x is the cognitive step (or basic ground) that directly precedes y logically, such that a dyadic representation relation from y is taken over from x (or assumed to be grounded a priori due to x)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#directlyGrounds"></see></summary>
    let directlyGrounds = _prefix "directlyGrounds"
    /// <summary>
    /// 'Goal-directed agents are intelligent agents that have an internal representation of the goals they [tend to] achieve' (Conte, doi:10.1007/978-1-4614-1800-9_158, 2009)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GoalDirectedAgent"></see></summary>
    let GoalDirectedAgent = _prefix "GoalDirectedAgent"
    /// <summary>
    /// (x isEvaluatorIn y) means that y is an evaluation and x is the interpreter in it
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isEvaluatorIn"></see></summary>
    let isEvaluatorIn = _prefix "isEvaluatorIn"
    /// <summary>
    /// Interpretation, i.e., a semiosis where the sign-object relation is carried over from the preceding cognitive step, without the need for the represented object to be present physically
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Interpretation"></see></summary>
    let Interpretation = _prefix "Interpretation"
    /// <summary>
    /// Reproducibility claim (RC), i.e., a validity claim obtained as an outcome of a reproduction attempt/reproducibility study
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ReproducibilityClaim"></see></summary>
    let ReproducibilityClaim = _prefix "ReproducibilityClaim"
    /// <summary>
    /// Examination (by pattern matching &amp; similar), i.e., an observation by which a legisign (specifying patterns or rules) is applied to an examined object, yielding an examination outcome that expresses in what way or to what extent the object matches the legisign
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Examination"></see></summary>
    let Examination = _prefix "Examination"
    /// <summary>
    /// (x isLegisignIn y) == y is an examination where x is applied to an object as a legisign, i.e., the first element, specifying patterns or rules the compliance with which is being assessed
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isLegisignIn"></see></summary>
    let isLegisignIn = _prefix "isLegisignIn"
    /// <summary>
    /// (x isExaminedIn y) == y is an examination where x acts as the examined object, i.e., the second element, for which it is assessed to what extent (in which way, under what additional conditions, etc.) it conforms with the legisign
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isExaminedIn"></see></summary>
    let isExaminedIn = _prefix "isExaminedIn"
    /// <summary>
    /// (x isExaminationOutcomeIn y) == y is an examination where x is the examination outcome, i.e., the third element (e.g., yes the object agrees with the legisign, or it does so under this or that condition, etc.)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isExaminationOutcomeIn"></see></summary>
    let isExaminationOutcomeIn = _prefix "isExaminationOutcomeIn"
    /// <summary>
    /// Observation, i.e., a perception by which characteristic aspects of an object (e.g., a target property or some more complex kind of behaviour) are purposefully investigated through specific means of perception; the procedure and evaluation may occur based on subjective judgement or according to an agreed procedure
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Observation"></see></summary>
    let Observation = _prefix "Observation"
    /// <summary>
    /// experimental workflow, i.e., a cognition that is purposefully conducted in a controlled environment and has at least one measurement as a step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ExperimentalWorkflow"></see></summary>
    let ExperimentalWorkflow = _prefix "ExperimentalWorkflow"
    /// <summary>
    /// Measurement, i.e., an observation that follows a standard procedure, so that it can be expected to yield an objective (rather than subjective) outcome
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Measurement"></see></summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    /// (x isSpeakerIn y) means that x is (the only) speaker in the expressive act y, where the role of the speaker is to be understood as that of an agent that conducts/undertakes the expressive act, i.e., it is not limited to vocal speech
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSpeakerIn"></see></summary>
    let isSpeakerIn = _prefix "isSpeakerIn"
    /// <summary>
    /// Intention, i.e., a proposition that constitutes an aim or goal
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Intention"></see></summary>
    let Intention = _prefix "Intention"
    /// <summary>
    /// (x isGoalFor y) means that to the goal-directed agent y, the telos x represents something that is to be reached.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isGoalFor"></see></summary>
    let isGoalFor = _prefix "isGoalFor"
    /// <summary>
    /// Goal-oriented agent, i.e., an agent that exhibits the tendency 'to achieve a certain state of the world' (Conte, doi:10.1007/978-1-4614-1800-9_158, 2009)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GoalOrientedAgent"></see></summary>
    let GoalOrientedAgent = _prefix "GoalOrientedAgent"
    /// <summary>
    /// (x isGoalOf y) means that y is a goal-oriented agent with the tendency to work toward a state of affairs that is described/represented by y; accordingly, the goal y is also a representamen for the agent itself; this does *not* imply that the agent x is aware of pursuing y as a goal, or that y is somehow included in x as a mental representation - for that purpose, use the relation 'isGoalFor'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isGoalOf"></see></summary>
    let isGoalOf = _prefix "isGoalOf"
    /// <summary>
    /// Grounded cognition, i.e., a cognition that is logically preceded by a presupposition such that there is a grounding chain establishing its epistemic status as a grounded cognition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GroundedCognition"></see></summary>
    let GroundedCognition = _prefix "GroundedCognition"
    /// <summary>
    /// (x logicallyPrecedes y) means that x and y are cognitive steps that are connected by a cognitive chain, leading from x and y, that does not contain a cognitive rupture
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#logicallyPrecedes"></see></summary>
    let logicallyPrecedes = _prefix "logicallyPrecedes"
    /// <summary>
    /// Grounding chain, i.e., a cognitive chain that establishes epistemic grounding
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingChain"></see></summary>
    let GroundingChain = _prefix "GroundingChain"
    /// <summary>
    /// (x isJustificationFor y) means that x is a grounding chain that provides epsitemic grounding for the cognition y, which thereby becomes a grounded cognition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isJustificationFor"></see></summary>
    let isJustificationFor = _prefix "isJustificationFor"
    /// <summary>
    /// Grounding step, i.e., a triadic cognition that establishes epistemic grounding
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingStep"></see></summary>
    let GroundingStep = _prefix "GroundingStep"
    /// <summary>
    /// Grounding interpretation, i.e., an interpretation where the sign is a ground for the considered cognitive step, the object is the considered cognitive step, and the interpretant is a ground for a subsequent cognitive step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingInterpretation"></see></summary>
    let GroundingInterpretation = _prefix "GroundingInterpretation"
    /// <summary>
    /// (x groundsPresentStepIn y) == y is a grounding interpretation where x is the first element, i.e., a ground for the considered cognitive step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#groundsPresentStepIn"></see></summary>
    let groundsPresentStepIn = _prefix "groundsPresentStepIn"
    /// <summary>
    /// (x isPresentStepInGrounding y) == y is a grounding interpretation where x is the second element, i.e., the considered cognitive step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isPresentStepInGrounding"></see></summary>
    let isPresentStepInGrounding = _prefix "isPresentStepInGrounding"
    /// <summary>
    /// (x groundsNextStepIn y) == y is a grounding interpretation where x is the third element, i.e., a ground for the subsequent cognitive step; thereby, x also serves as a ground for y itself
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#groundsNextStepIn"></see></summary>
    let groundsNextStepIn = _prefix "groundsNextStepIn"
    /// <summary>
    /// Grounding metonymization, i.e., a metonymization where a the old referent is a cognitive step (i.e., the grounding step) that grounds another (i.e., the grounded step), which is the new referent; the referent for both is a ground (i.e., the grounding proposition) that is a ground for the grounded step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingMetonymization"></see></summary>
    let GroundingMetonymization = _prefix "GroundingMetonymization"
    /// <summary>
    /// (x isGroundingStepIn y) == y is a grounding step where x is the grounding step, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundingStepIn"></see></summary>
    let isGroundingStepIn = _prefix "isGroundingStepIn"
    /// <summary>
    /// (x isGroundingPropositionIn y) == y is a grounding step where x is the grounding proposition, i.e., the second element; therein, x is a ground for the grounded step, and x is also a ground for y itself
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundingPropositionIn"></see></summary>
    let isGroundingPropositionIn = _prefix "isGroundingPropositionIn"
    /// <summary>
    /// (x isGroundedStepIn y) == y is a grounding step where x is the grounded step, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundedStepIn"></see></summary>
    let isGroundedStepIn = _prefix "isGroundedStepIn"
    /// <summary>
    /// Semantic change, i.e., a triadic cognition by which a representamen is assigned a new referent
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#SemanticChange"></see></summary>
    let SemanticChange = _prefix "SemanticChange"
    /// <summary>
    /// Triadic cognition, i.e., a cognitive step of the type s-o-s' (semiosis) or o-s-o' (semantic change), thus containing three elements, in line with the approach by Peirce
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#TriadicCognition"></see></summary>
    let TriadicCognition = _prefix "TriadicCognition"
    /// <summary>
    /// Individual IRI, i.e., the internationalized resource identifier of an individual (owl:Thing or pims-ii:Object)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#IndividualIRI"></see></summary>
    let IndividualIRI = _prefix "IndividualIRI"
    /// <summary>
    /// Unique identifier, i.e., a rigid designator that is applied to exactly one object
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#UniqueIdentifier"></see></summary>
    let UniqueIdentifier = _prefix "UniqueIdentifier"
    /// <summary>
    /// (x isInformationProcessingInputIn y) == y is an information-processing step where x is the input, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInformationProcessingInputIn"></see></summary>
    let isInformationProcessingInputIn = _prefix "isInformationProcessingInputIn"
    /// <summary>
    /// (x isObjectInInformationProcessing y) == y is an information-processing step where x is the object that the input and the output both represent, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInInformationProcessing"></see></summary>
    let isObjectInInformationProcessing = _prefix "isObjectInInformationProcessing"
    /// <summary>
    /// (x isInformationProcessingOutputIn y) == y is an information-processing step where x is the output, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInformationProcessingOutputIn"></see></summary>
    let isInformationProcessingOutputIn = _prefix "isInformationProcessingOutputIn"
    /// <summary>
    /// (x isSignInInterpretation y) == y is an interpretation where x acts as the sign, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSignInInterpretation"></see></summary>
    let isSignInInterpretation = _prefix "isSignInInterpretation"
    /// <summary>
    /// (x isObjectInInterpretation y) == y is an interpretation where x acts as the object, i.e., the second element; there is no need to the object of an interpretation to be present and participate in the interpretation process physically
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInInterpretation"></see></summary>
    let isObjectInInterpretation = _prefix "isObjectInInterpretation"
    /// <summary>
    /// (x isInterpretantInInterpretation y) == y is an interpretation where x acts as the interpretant, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantInInterpretation"></see></summary>
    let isInterpretantInInterpretation = _prefix "isInterpretantInInterpretation"
    /// <summary>
    /// Investigation setup, i.e., a metonymization where a sign (e.g., a model and/or open question) that has come up for an 'object of application' (the old referent, e.g., the system to which a use case refers) is reassigned to an 'object of investigation' to which dedicated studies can be applied, such as a system that will be simulated or investigated experimentally; n.b., there needs to be a causal connection between the old and the new referent, i.e., between the object of application and the object of investigation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#InvestigationSetup"></see></summary>
    let InvestigationSetup = _prefix "InvestigationSetup"
    /// <summary>
    /// (x isObjectOfApplicationIn y) == y is an investigation-setup action where x acts as the object of application (e.g., the system to which a use case refers), i.e., the first element; n.b., there needs to be a causal connection between the object of application and the object of investigation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectOfApplicationIn"></see></summary>
    let isObjectOfApplicationIn = _prefix "isObjectOfApplicationIn"
    /// <summary>
    /// (x isSignInInvestigation y) == y is an investigation-setup action where x acts as a representamen, i.e., the second element, both for the object of application (to which it is initially applied) and the object of investigation (to which it is reassigned such that the investigation can take place)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSignInInvestigation"></see></summary>
    let isSignInInvestigation = _prefix "isSignInInvestigation"
    /// <summary>
    /// (x isObjectOfInvestigationIn y) == y is an investigation-setup action where x acts as the object of investigation (e.g., the item subject to an experiment or a simulated process or system), i.e., as the third element; n.b., there needs to be a causal connection between the object of application and the object of investigation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectOfInvestigationIn"></see></summary>
    let isObjectOfInvestigationIn = _prefix "isObjectOfInvestigationIn"
    /// <summary>
    /// Item, i.e., a connected region of spacetime that does not consist of multiple connected components
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// Knowledge base, i.e., an interlocutor that makes a consistent set of claims and will respond consistently if queried; n.b., that propositional content which 'isHeldBy' a knowledge base needs to be invariable over the whole 4D spacetime in which the knowledge base exist. Since technical knowledge bases do happen to change their propositional content over time, it may make sense either to define proper parts with a short temporal extension or to take care with what a knowledge base is stated to hold. Other kinds of propositional content (varying over time or depending on who makes the query) can be said to be asserted rather than held by the knowledge base.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeBase"></see></summary>
    let KnowledgeBase = _prefix "KnowledgeBase"
    /// <summary>
    /// Knowledge-based agent, i.e., an intelligent agent that uses a knowledge base to store and process its opinions/claims/worldview
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeBasedAgent"></see></summary>
    let KnowledgeBasedAgent = _prefix "KnowledgeBasedAgent"
    /// <summary>
    /// (x isMereologicallyConstitutiveOf y) means that x is constitutive of y by virtue of the way in which it is a proper part of y in 4D spacetime, e.g., as a necessary component of an item that was designed for a certain purpose
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMereologicallyConstitutiveOf"></see></summary>
    let isMereologicallyConstitutiveOf = _prefix "isMereologicallyConstitutiveOf"
    /// <summary>
    /// Question, i.e., a topical proposition the semantics/pragmatics of which are of interrogative character
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Question"></see></summary>
    let Question = _prefix "Question"
    /// <summary>
    /// (x hasSubjectMatter y) means that x is a proposition or articulation that addresses the topic or sum (i.e., plurality) of topics y, i.e., that has y as its subject matter
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasSubjectMatter"></see></summary>
    let hasSubjectMatter = _prefix "hasSubjectMatter"
    /// <summary>
    /// (x isInterpretantIn y) == y is a semiosis where x acts as the interpretant, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantIn"></see></summary>
    let isInterpretantIn = _prefix "isInterpretantIn"
    /// <summary>
    /// Validity claim (VC), i.e., a claim about another claim, saying something about that claim's (in-)accuracy or somebody's (dis-)trust in the claim
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ValidityClaim"></see></summary>
    let ValidityClaim = _prefix "ValidityClaim"
    /// <summary>
    /// Rule, i.e., a proposition consisting of an antecedent and one or multiple consequent(s) such that the antecedent is stated to imply the consequent(s)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Rule"></see></summary>
    let Rule = _prefix "Rule"
    /// <summary>
    /// Qualified law, i.e., a law where the necessary entailment of the consequent(s) by the antecedent is expressed in terms of qualified necessity, to be understood in terms of its modal context
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#QualifiedLaw"></see></summary>
    let QualifiedLaw = _prefix "QualifiedLaw"
    /// <summary>
    /// Lexeme, i.e., a semiotic collective the members of which are all instances/utterances/copies of the same word (or a fragment or group of words that fulfills the corresponding function) which acts as a conventional articulation due to social convention; different ways of writing the word, such as an abbreviation and the full version, may belong to the same lexeme
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Lexeme"></see></summary>
    let Lexeme = _prefix "Lexeme"
    /// <summary>
    /// Name, i.e., a lexeme that acts as a rigid designator due to social convention
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Name"></see></summary>
    let Name = _prefix "Name"
    /// <summary>
    /// Mathematical operator, i.e., a lexeme that articulates a mathematical operation, such as the collective containing realizations of '*', '·', 'times', etc.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#MathematicalOperator"></see></summary>
    let MathematicalOperator = _prefix "MathematicalOperator"
    /// <summary>
    /// (x isMeasurementInputIn y) == y is a measurement where x serves as the input (sign), i.e., the first element, constituting the precondition in terms of available information and similar items
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMeasurementInputIn"></see></summary>
    let isMeasurementInputIn = _prefix "isMeasurementInputIn"
    /// <summary>
    /// (x isMeasuredObjectIn y) == y is a measurement where x acts as the object, i.e., the second element, that is subject to the measurement and for which a property is determined
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMeasuredObjectIn"></see></summary>
    let isMeasuredObjectIn = _prefix "isMeasuredObjectIn"
    /// <summary>
    /// (x isMeasurementOutcomeIn y) == y is a measurement where x is the measurement outcome, i.e., the third element (e.g., the value that is determined for the considered property of the measured object, the measurement error, and any other outcome)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMeasurementOutcomeIn"></see></summary>
    let isMeasurementOutcomeIn = _prefix "isMeasurementOutcomeIn"
    /// <summary>
    /// Measurement unit, i.e., a 'real scalar quantity, defined and adopted by convention' (EMMO, ISO 80000-1)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#MeasurementUnit"></see></summary>
    let MeasurementUnit = _prefix "MeasurementUnit"
    /// <summary>
    /// (x isMereotopologicalMemberOf y) means that x is one out of several mereotopologically connected components of y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMereotopologicalMemberOf"></see></summary>
    let isMereotopologicalMemberOf = _prefix "isMereotopologicalMemberOf"
    /// <summary>
    /// (x isOldReferentInMetonymization y) == y is a metonymization where x acts as the old referent, i.e., the first element; the old and the new referent need to have a causal connection
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInMetonymization"></see></summary>
    let isOldReferentInMetonymization = _prefix "isOldReferentInMetonymization"
    /// <summary>
    /// (x changesReferentInMetonymization y) == y is a metonymization where x acts as the representamen, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInMetonymization"></see></summary>
    let changesReferentInMetonymization = _prefix "changesReferentInMetonymization"
    /// <summary>
    /// (x isNewReferentInMetonymization y) == y is a metonymization where x acts as the new referent, i.e., the third element; the old and the new referent need to have a causal connection
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInMetonymization"></see></summary>
    let isNewReferentInMetonymization = _prefix "isNewReferentInMetonymization"
    /// <summary>
    /// Qualified modal IRI, i.e., the IRI of a relation that is defined by qualified necessity or possibility of another relation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#QualifiedModalIRI"></see></summary>
    let QualifiedModalIRI = _prefix "QualifiedModalIRI"
    /// <summary>
    /// Modelling, i.e., an interpretation in which the sign is the basis for the modelling process (e.g., an unparameterized or previously parameterized model, knowledge about the modelled system, etc.), the object is the modelled system, and the interpretant is the modelling output (e.g., a parameterized model)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Modelling"></see></summary>
    let Modelling = _prefix "Modelling"
    /// <summary>
    /// (x isModellingInputIn y) == y is a modelling (model construction or parameterization) step where x is the input (previous or unparameterized model, knowledge about the modelled system, etc.), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isModellingInputIn"></see></summary>
    let isModellingInputIn = _prefix "isModellingInputIn"
    /// <summary>
    /// (x isModelledIn y) == y is a modelling (model construction or parameterization) step where x acts as the modelled object (system, substance, process, or similar), i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isModelledIn"></see></summary>
    let isModelledIn = _prefix "isModelledIn"
    /// <summary>
    /// (x isModellingOutputIn y) == y is a modelling (model construction or parameterization) step where x is the modelling output (e.g., a parameterized or improved model), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isModellingOutputIn"></see></summary>
    let isModellingOutputIn = _prefix "isModellingOutputIn"
    /// <summary>
    /// (x isNameFor y), to be applied in the frequent special case where x is represented by a name for x, i.e., where social convention has established y as a rigid designator for x
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isNameFor"></see></summary>
    let isNameFor = _prefix "isNameFor"
    /// <summary>
    /// Negative knowledge claim (NKC), i.e., a knowledge claim that expresses what we don't know, a gap or limitation of our knowledge
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#NegativeKnowledgeClaim"></see></summary>
    let NegativeKnowledgeClaim = _prefix "NegativeKnowledgeClaim"
    /// <summary>
    /// Number, i.e., a lexeme that is numerical in nature, such as the collective containing realizations of 'two', '2', and '2.0'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Number"></see></summary>
    let Number = _prefix "Number"

    /// <summary>
    /// (x isSpatiotemporallyDisconnectedFrom y) is the negation of (x isSpatiotemporallyConnectedWith y); i.e., to go from any point in x to any point in y, it is necessary to leave the fusion (x U y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSpatiotemporallyDisconnectedFrom"></see></summary>
    let isSpatiotemporallyDisconnectedFrom =
        _prefix "isSpatiotemporallyDisconnectedFrom"

    /// <summary>
    /// (x temporallyPrecedes y) means that every point in x is earlier in time than every point in y; the spacetime regions x and y may be connected, but they cannot overlap temporally
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#temporallyPrecedes"></see></summary>
    let temporallyPrecedes = _prefix "temporallyPrecedes"
    /// <summary>
    /// (x hasProperPart y) means that y is an improper part of x such that x and y are not the same, in other words, all points within y are also within x, but not vice versa
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasProperPart"></see></summary>
    let hasProperPart = _prefix "hasProperPart"
    /// <summary>
    /// Spatiotemporal (mereological) proper parthood relation; (x isProperPartOf y) means that x is an improper part of y such that x and y are not the same, in other words, all points within x are also within y, but not vice versa
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isProperPartOf"></see></summary>
    let isProperPartOf = _prefix "isProperPartOf"
    /// <summary>
    /// (x isObservationInputIn y) == y is an observation where x designates input and/or advance knowledge relevant to the observation, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObservationInputIn"></see></summary>
    let isObservationInputIn = _prefix "isObservationInputIn"
    /// <summary>
    /// (x isObservedIn y) == y is an observation where x acts as the observed object, i.e., the second element, for which the value of a property is to be determined
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObservedIn"></see></summary>
    let isObservedIn = _prefix "isObservedIn"
    /// <summary>
    /// (x isObservationOutcomeIn y) == y is an observation where x is the observation outcome (the observed value of the target property), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObservationOutcomeIn"></see></summary>
    let isObservationOutcomeIn = _prefix "isObservationOutcomeIn"
    /// <summary>
    /// Perception, i.e., a semiosis in which the referent is a participant (as a perceived object) and therefore needs to be physically present
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Perception"></see></summary>
    let Perception = _prefix "Perception"
    /// <summary>
    /// Optimization, i.e., an interpretation in which the sign is the optimization problem, the object is that which the optimization problem is ultimately about, and the interpretant is the optimization output
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Optimization"></see></summary>
    let Optimization = _prefix "Optimization"
    /// <summary>
    /// Optimization problem, i.e., an intention expressed or expressible in terms of one or multiple objectives (objective space) and one or multiple design parameters (parameter space)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#OptimizationProblem"></see></summary>
    let OptimizationProblem = _prefix "OptimizationProblem"
    /// <summary>
    /// (x isOptimizationProblemIn y) == y is an optimization where x is the optimization problem, i.e., the first element.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationProblemIn"></see></summary>
    let isOptimizationProblemIn = _prefix "isOptimizationProblemIn"
    /// <summary>
    /// (x isObjectInOptimization y) == y is an optimization where x is that which the optimization is ultimately about, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInOptimization"></see></summary>
    let isObjectInOptimization = _prefix "isObjectInOptimization"
    /// <summary>
    /// (x isOptimizationOutputIn y) == y is an optimization where x is the optimization output, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationOutputIn"></see></summary>
    let isOptimizationOutputIn = _prefix "isOptimizationOutputIn"
    /// <summary>
    /// (x isDesignParameterWithin y) == x is one of the parameters that make up the design space considered in the optimization problem y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isDesignParameterWithin"></see></summary>
    let isDesignParameterWithin = _prefix "isDesignParameterWithin"
    /// <summary>
    /// (x isOptimizationObjectiveWithin y) == x is one of the optimization criteria that make up the objective space considered in the optimization problem y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationObjectiveWithin"></see></summary>
    let isOptimizationObjectiveWithin = _prefix "isOptimizationObjectiveWithin"
    /// <summary>
    /// Own claim, i.e., a claim that is asserted by a self reference (i.e., a/the present interlocutor)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#OwnClaim"></see></summary>
    let OwnClaim = _prefix "OwnClaim"
    /// <summary>
    /// Reference to self, i.e., an entity for the interlocutor who *is* the present system, i.e., the system containing the present triples, etc., and whose claims are to be accepted as the present system's 'own claims.' A self-reference is an entity that is either identical with the system at hand, namely, the digital infrastructure or other interlocutor that stores the present semantic content, or a component of it
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ReferenceToSelf"></see></summary>
    let ReferenceToSelf = _prefix "ReferenceToSelf"
    /// <summary>
    /// Part-to-whole synecdoche, i.e., a metonymization where the old referent is a spatiotemporal proper part of the new referent (additionally, the old and new referent need to be connected causally)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#PartToWhole"></see></summary>
    let PartToWhole = _prefix "PartToWhole"
    /// <summary>
    /// (x isOldReferentInPartToWhole y) == y is a part-to-whole synecdoche where x acts as the old referent (the part), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInPartToWhole"></see></summary>
    let isOldReferentInPartToWhole = _prefix "isOldReferentInPartToWhole"
    /// <summary>
    /// (x changesReferentInPartToWhole y) == y is a part-to-whole synecdoche where x acts as the representamen, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInPartToWhole"></see></summary>
    let changesReferentInPartToWhole = _prefix "changesReferentInPartToWhole"
    /// <summary>
    /// (x isNewReferentInPartToWhole y) == y is a part-to-whole synecdoche where x acts as the new referent (the whole), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInPartToWhole"></see></summary>
    let isNewReferentInPartToWhole = _prefix "isNewReferentInPartToWhole"
    /// <summary>
    /// Synecdoche, i.e., a metonymization where a sign is reassigned to a part of its old referent (WholeToPart) or vice versa (PartToWhole)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Synecdoche"></see></summary>
    let Synecdoche = _prefix "Synecdoche"
    /// <summary>
    /// (x isSignInPerception y) == y is a perception where x acts as the sign, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSignInPerception"></see></summary>
    let isSignInPerception = _prefix "isSignInPerception"
    /// <summary>
    /// (x isPerceivedIn y) == y is a perception where x acts as the perceived object, i.e., the second element; the perceived object is a (mereotopological) participant of the perception, in other words, it needs to be physically present so that it can be perceived
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isPerceivedIn"></see></summary>
    let isPerceivedIn = _prefix "isPerceivedIn"
    /// <summary>
    /// (x isInterpretantInPerception y) == y is a perception where x acts as the interpretant, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantInPerception"></see></summary>
    let isInterpretantInPerception = _prefix "isInterpretantInPerception"
    /// <summary>
    /// Person, i.e., an interlocutor that is socially identified as a natural or legal person by social convention that involves using a name (or multiple names) for it as rigid designators
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// Planning, i.e., a reflection ex ante or predetermination, carried out by analysing the perceived present situation in advance of potentially undertaking an action
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Planning"></see></summary>
    let Planning = _prefix "Planning"
    /// <summary>
    /// (x isTelosInPlanning y) == y is a telesis carried out in advance of potentially undertaking an action, where x acts as the telos (initial guiding objective), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInPlanning"></see></summary>
    let isTelosInPlanning = _prefix "isTelosInPlanning"
    /// <summary>
    /// (x isSituationInPlanning y) == y is a telesis carried out in advance of potentially undertaking an action, where x is the perceived present situation, i.e., the second element, against which the telos is evaluated
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSituationInPlanning"></see></summary>
    let isSituationInPlanning = _prefix "isSituationInPlanning"
    /// <summary>
    /// (x isResolutionInPlanning y) == y is a telesis carried out in advance of potentially undertaking an action, where x is the planning outcome, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInPlanning"></see></summary>
    let isResolutionInPlanning = _prefix "isResolutionInPlanning"
    /// <summary>
    /// Plurality, i.e., a semiotic collective the semiotic members of which are a representational element (referent or representamen) together, whereby all act/contribute in the same way - this latter point distinguishes a plurality from a structure; e.g., the referent of the expression 'the four seasons/quarters of the year' (for a given year, within a given spatial region) is a plurality, and each of the four seasons/quarters is one of its semiotic members
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Plurality"></see></summary>
    let Plurality = _prefix "Plurality"
    /// <summary>
    /// (x isMemberOfPlurality y) means that x is a semiotic member of the plurality y, and that it participates in semiosis in the same way as its co-members x', x'', ... of the plurality y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMemberOfPlurality"></see></summary>
    let isMemberOfPlurality = _prefix "isMemberOfPlurality"
    /// <summary>
    /// Structure, i.e., a semiotic collective the semiotic members of which complement each other, contributing in different ways (or, at least, not all int the same way) to their joint action as a referent or a representamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Structure"></see></summary>
    let Structure = _prefix "Structure"
    /// <summary>
    /// Proof-based validity claim (PVC), i.e., a validity claim obtained by formal verification, i.e., by deductive logical and mathematical reasoning
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ProofBasedValidityClaim"></see></summary>
    let ProofBasedValidityClaim = _prefix "ProofBasedValidityClaim"
    /// <summary>
    /// Test-based validity claim (TVC), i.e., a validity claim obtained from validation or testing
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#TestBasedValidityClaim"></see></summary>
    let TestBasedValidityClaim = _prefix "TestBasedValidityClaim"
    /// <summary>
    /// Property, i.e., a variable that is employed for the possible outcome of observations and similar processes (this may include different words used for the same property, in one or multiple languages, and different ways of expressing these words)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// (x articulatesLiterally y) means that x is a collective literal expressing the proposition y, and possibly additional propositions beside y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#articulatesLiterally"></see></summary>
    let articulatesLiterally = _prefix "articulatesLiterally"
    /// <summary>
    /// (x isAbout y) means that x is a proposition and y is the object that x is related to by aboutness
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAbout"></see></summary>
    let isAbout = _prefix "isAbout"
    /// <summary>
    /// (x articulates y) means that x is a semiotic member of the proposition y, giving a literal or non-literal (e.g., spoken) expression to its propositional content; n.b., x may also express other propositions beside y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#articulates"></see></summary>
    let articulates = _prefix "articulates"
    /// <summary>
    /// (x isAimIn y) means that y is a purposeful action, and x is one of the aims followed by the agent of y by undertaking y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAimIn"></see></summary>
    let isAimIn = _prefix "isAimIn"
    /// <summary>
    /// (x isContextWithinLaw y) means that x is an IRI for the modal context of relatively necessary implication in the relative law y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isContextWithinLaw"></see></summary>
    let isContextWithinLaw = _prefix "isContextWithinLaw"
    /// <summary>
    /// (x isContextOfRelation y) means that x is an IRI for the modal context of qualified possibility/necessity in the relative modal IRI y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isContextOfRelation"></see></summary>
    let isContextOfRelation = _prefix "isContextOfRelation"
    /// <summary>
    /// Quantity value, i.e., a value that has a numerical magnitude and a physical unit
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#QuantityValue"></see></summary>
    let QuantityValue = _prefix "QuantityValue"
    /// <summary>
    /// (x isMagnitudeOf y) means that x is the numerical magnitude of y, e.g., in 200 kPa, x would be 200
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMagnitudeOf"></see></summary>
    let isMagnitudeOf = _prefix "isMagnitudeOf"
    /// <summary>
    /// (x isUnitOf y) means that x is the unit of y, e.g., in 200 kPa, x would be kPa
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isUnitOf"></see></summary>
    let isUnitOf = _prefix "isUnitOf"
    /// <summary>
    /// Query, i.e., a digital articulation of a question
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Query"></see></summary>
    let Query = _prefix "Query"
    /// <summary>
    /// Topical proposition, i.e., something that can be understood as stating the topic of something
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Topical"></see></summary>
    let Topical = _prefix "Topical"
    /// <summary>
    /// A rational agent is an intelligent agent that exhibits rationality, i.e., a tendency toward maximizing a quantity: The performance measure of the agent.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#RationalAgent"></see></summary>
    let RationalAgent = _prefix "RationalAgent"
    /// <summary>
    /// (x isPerformanceMeasureOf y) means that x is the single/unique performance measure of the rational agent y.
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isPerformanceMeasureOf"></see></summary>
    let isPerformanceMeasureOf = _prefix "isPerformanceMeasureOf"
    /// <summary>
    /// Research question, i.e., a question that could, has been, or is being addressed by scientific research and e.g. could be answered by a knowledge claim formulated on the grounds of scientific research data
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#ResearchQuestion"></see></summary>
    let ResearchQuestion = _prefix "ResearchQuestion"
    /// <summary>
    /// (x isAntecedentWithin y) means that x is the antecedent from the rule y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAntecedentWithin"></see></summary>
    let isAntecedentWithin = _prefix "isAntecedentWithin"
    /// <summary>
    /// (x isConsequentWithin y) means that x is a consequent from the rule y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isConsequentWithin"></see></summary>
    let isConsequentWithin = _prefix "isConsequentWithin"
    /// <summary>
    /// (x isOrthodataWithin y) means that x articulates a substantial aspect of either the antecedent or the consequent side of the rule y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOrthodataWithin"></see></summary>
    let isOrthodataWithin = _prefix "isOrthodataWithin"
    /// <summary>
    /// Selection, i.e., an information-processing step in which the given information is narrowed down such that the output (interpretant) is constitutive of the input (sign); this includes conditional selection, where one component of the input or another is retained depending on a selection condition (cf. relation isSelectionConditionIn)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Selection"></see></summary>
    let Selection = _prefix "Selection"
    /// <summary>
    /// (x isSelectionInputIn y) == y is a selection where x is the input (initially given information), i.e., the first element; n.b., in a selection, the output needs to be constitutive of the input
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSelectionInputIn"></see></summary>
    let isSelectionInputIn = _prefix "isSelectionInputIn"
    /// <summary>
    /// (x isObjectInSelection y) == y is a selection where x is the object that the input and the output both represent, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInSelection"></see></summary>
    let isObjectInSelection = _prefix "isObjectInSelection"
    /// <summary>
    /// (x isSelectionOutputIn y) == y is a selection where x is the output (retained information), i.e., the third element; n.b., in a selection, the output needs to be constitutive of the input
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSelectionOutputIn"></see></summary>
    let isSelectionOutputIn = _prefix "isSelectionOutputIn"
    /// <summary>
    /// (x isOldReferentIn y) == y is a semantic change where x acts as the old referent, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentIn"></see></summary>
    let isOldReferentIn = _prefix "isOldReferentIn"
    /// <summary>
    /// (x changesReferentIn y) == y is a semantic change where x acts as the representamen, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentIn"></see></summary>
    let changesReferentIn = _prefix "changesReferentIn"
    /// <summary>
    /// (x isNewReferentIn y) == y is a semantic change where x acts as the new referent, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentIn"></see></summary>
    let isNewReferentIn = _prefix "isNewReferentIn"
    /// <summary>
    /// (x isSignIn y) == y is a semiosis where x acts as the sign, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSignIn"></see></summary>
    let isSignIn = _prefix "isSignIn"
    /// <summary>
    /// (x isObjectIn y) == y is a semiosis where x acts as the object, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectIn"></see></summary>
    let isObjectIn = _prefix "isObjectIn"
    /// <summary>
    /// (x isRepresentationalElementIn y) == x acts as a representamen or referent in the cognitive step y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isRepresentationalElementIn"></see></summary>
    let isRepresentationalElementIn = _prefix "isRepresentationalElementIn"
    /// <summary>
    /// Simulation, i.e., a purposefully conducted numerical interpretation of simulation input (model, etc.), where the interpretant is the simulation result
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Simulation"></see></summary>
    let Simulation = _prefix "Simulation"
    /// <summary>
    /// (x isSimulationInputIn y) == y is a simulation where x is the simulation input (model, etc.), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSimulationInputIn"></see></summary>
    let isSimulationInputIn = _prefix "isSimulationInputIn"
    /// <summary>
    /// (x isSimulatedIn y) == y is a simulation where x acts as the simulated object (system, substance, process, or similar), i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSimulatedIn"></see></summary>
    let isSimulatedIn = _prefix "isSimulatedIn"
    /// <summary>
    /// (x isSimulationOutputIn y) == y is a simulation where x is the simulation output (computed property, higher-level model, or similar), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSimulationOutputIn"></see></summary>
    let isSimulationOutputIn = _prefix "isSimulationOutputIn"
    /// <summary>
    /// simulation workflow, i.e., a cognitive workflow in which simulation plays a major role
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#SimulationWorkflow"></see></summary>
    let SimulationWorkflow = _prefix "SimulationWorkflow"
    /// <summary>
    /// Steering, i.e., a reflection in actu (Reflexion im Vollzug following Baumann and Tulatz) or determination, carried out while undertaking an action and playing a role in that action by proper participation
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Steering"></see></summary>
    let Steering = _prefix "Steering"
    /// <summary>
    /// (x isTelosInSteering y) == y is a steering operation (reflection in actu) where x acts as the telos (initial guiding objective), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInSteering"></see></summary>
    let isTelosInSteering = _prefix "isTelosInSteering"
    /// <summary>
    /// (x isActionInSteering y) == y is a steering operation (reflection in actu) where x is an ongoing action, i.e., the second element, against which the telos is evaluated
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isActionInSteering"></see></summary>
    let isActionInSteering = _prefix "isActionInSteering"
    /// <summary>
    /// (x isResolutionInSteering y) == y is a steering operation (reflection in actu) where x is the resolution, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInSteering"></see></summary>
    let isResolutionInSteering = _prefix "isResolutionInSteering"
    /// <summary>
    /// (x isMemberOfStructure y) means that x is a semiotic member of the structure y, and that it participates in semiosis differently from all of its co-members x', x'', ... of the structure y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMemberOfStructure"></see></summary>
    let isMemberOfStructure = _prefix "isMemberOfStructure"
    /// <summary>
    /// (x isOldReferentInSynecdoche y) == y is a synecdoche where x acts as the old referent, i.e., the first element; the old and the new referent need to have a causal connection (n.b., the mereological relation in terms of proper parthood as such is insufficient)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInSynecdoche"></see></summary>
    let isOldReferentInSynecdoche = _prefix "isOldReferentInSynecdoche"
    /// <summary>
    /// (x changesReferentInSynecdoche y) == y is a synecdoche where x acts as the representamen, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInSynecdoche"></see></summary>
    let changesReferentInSynecdoche = _prefix "changesReferentInSynecdoche"
    /// <summary>
    /// (x isNewReferentInSynecdoche y) == y is a synecdoche where x acts as the new referent, i.e., the third element; the old and the new referent need to have a causal connection (n.b., the mereological relation in terms of proper parthood as such is insufficient)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInSynecdoche"></see></summary>
    let isNewReferentInSynecdoche = _prefix "isNewReferentInSynecdoche"
    /// <summary>
    /// Whole-to-part synecdoche, i.e., a metonymization where the new referent is a spatiotemporal proper part of the old referent (additionally, the old and new referent need to be connected causally)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#WholeToPart"></see></summary>
    let WholeToPart = _prefix "WholeToPart"
    /// <summary>
    /// (x isTelosIn y) == y is a telesis where x acts as the telos (initial guiding objective), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosIn"></see></summary>
    let isTelosIn = _prefix "isTelosIn"
    /// <summary>
    /// (x isResolutionInTelesis y) == y is a telesis where x acts as the resolution (a plan, revised objective, or other comparable sort of evaluation outcome), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInTelesis"></see></summary>
    let isResolutionInTelesis = _prefix "isResolutionInTelesis"
    /// <summary>
    /// (x isObjectInTelesis y) == y is a telesis where x acts as the object (action, claim, or situation against which an objective is evaluated), i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInTelesis"></see></summary>
    let isObjectInTelesis = _prefix "isObjectInTelesis"
    /// <summary>
    /// (x isAdmissibleValueFor y) means that y is a term that could in principle evaluate to the value x; subsumption under msIPIRIR is explained as follows: There is a sign z for the term y (where z is the range of admissible values of y), for which in turn there is another sign z' (where z' lists members of z, explicitly including x) of which x is a part
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAdmissibleValueFor"></see></summary>
    let isAdmissibleValueFor = _prefix "isAdmissibleValueFor"
    /// <summary>
    /// Topical product, i.e., a topical proposition with multiple topical factors
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#TopicalProduct"></see></summary>
    let TopicalProduct = _prefix "TopicalProduct"
    /// <summary>
    /// Topical sum, i.e., a plurality of topical propositions, where the individual elements (summands) don't genuinely interact but are just standing beside each other as independent, unrelated (or not very closely related) parts of what is addressed
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#TopicalSum"></see></summary>
    let TopicalSum = _prefix "TopicalSum"
    /// <summary>
    /// (x isTopicalFactorIn y) means that x is combined with other subtopics into the topical proposition y, such that x and the other subtopics are not just standing beside each other, but exhibiting some meaningful interaction
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTopicalFactorIn"></see></summary>
    let isTopicalFactorIn = _prefix "isTopicalFactorIn"
    /// <summary>
    /// (x isTopicalSummandIn y) means that x is one of the topics contained in y, a collection of topics that are not immediately closely related to each other
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTopicalSummandIn"></see></summary>
    let isTopicalSummandIn = _prefix "isTopicalSummandIn"
    /// <summary>
    /// (x isFirstElementIn y) means that x acts as the first element in y, which is a triadic cognition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isFirstElementIn"></see></summary>
    let isFirstElementIn = _prefix "isFirstElementIn"
    /// <summary>
    /// (x isSecondElementIn y) means that x acts as the second element in y, which is a triadic cognition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSecondElementIn"></see></summary>
    let isSecondElementIn = _prefix "isSecondElementIn"
    /// <summary>
    /// (x isThirdElementIn y) means that x acts as the third element in y, which is a triadic cognition
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isThirdElementIn"></see></summary>
    let isThirdElementIn = _prefix "isThirdElementIn"
    /// <summary>
    /// Triple, i.e., a subject-predicate-object triple (connected by relations to the IRIs of the subject, predicate, and object)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Triple"></see></summary>
    let Triple = _prefix "Triple"
    /// <summary>
    /// (x isSubjectWithinTriple y) means that y is a subject-predicate-object triple wherein x is the IRI of the subject
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSubjectWithinTriple"></see></summary>
    let isSubjectWithinTriple = _prefix "isSubjectWithinTriple"
    /// <summary>
    /// (x isPredicateWithinTriple y) means that y is a subject-predicate-object triple wherein x is the IRI of the predicate
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isPredicateWithinTriple"></see></summary>
    let isPredicateWithinTriple = _prefix "isPredicateWithinTriple"
    /// <summary>
    /// (x isObjectWithinTriple y) means that y is a subject-predicate-object triple wherein x is the IRI of the object
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectWithinTriple"></see></summary>
    let isObjectWithinTriple = _prefix "isObjectWithinTriple"
    /// <summary>
    /// (x isSituationInUndertaking y) == y is an undertaking wherein x is the pre-existing situation, i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSituationInUndertaking"></see></summary>
    let isSituationInUndertaking = _prefix "isSituationInUndertaking"
    /// <summary>
    /// (x isResolutionInUndertaking y) == y is an undertaking where x is the resolution (obtained from a previous telesis), i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInUndertaking"></see></summary>
    let isResolutionInUndertaking = _prefix "isResolutionInUndertaking"
    /// <summary>
    /// (x isActionInUndertaking y) == y is an undertaking where x is the action that is undertaken, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isActionInUndertaking"></see></summary>
    let isActionInUndertaking = _prefix "isActionInUndertaking"
    /// <summary>
    /// Validation, i.e., an evaluation of a cognition yielding a validity claim as its interpretant
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Validation"></see></summary>
    let Validation = _prefix "Validation"
    /// <summary>
    /// (x isTelosInValidation y) means that y is a validation where x acts as the telos (initial guiding objective), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInValidation"></see></summary>
    let isTelosInValidation = _prefix "isTelosInValidation"
    /// <summary>
    /// (x isValidatedIn y) means that y is a validation where x is the cognitive action undergoing validation, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isValidatedIn"></see></summary>
    let isValidatedIn = _prefix "isValidatedIn"
    /// <summary>
    /// (x isValidationOutcomeIn y) means that x is the validity claim, i.e., the third element, obtained as an interpretant from the validation y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isValidationOutcomeIn"></see></summary>
    let isValidationOutcomeIn = _prefix "isValidationOutcomeIn"
    /// <summary>
    /// Visualization, i.e., an interpretation in which the object is the visualized system and the interpretant is a visual representation of the object - the sign is a pre-existing representamen for the same object, e.g., a simulation result
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#Visualization"></see></summary>
    let Visualization = _prefix "Visualization"
    /// <summary>
    /// (x isVisualizationInputIn y) == y is a visualization process where x is the input (a pre-existing representamen for the visualized object, e.g., a simulation result), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isVisualizationInputIn"></see></summary>
    let isVisualizationInputIn = _prefix "isVisualizationInputIn"
    /// <summary>
    /// (x isVisualizedObjectIn y) == y is a visualization process wherein x is the visualized object, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isVisualizedObjectIn"></see></summary>
    let isVisualizedObjectIn = _prefix "isVisualizedObjectIn"
    /// <summary>
    /// (x isVisualizationOutputIn y) == y is a visualization where x is the visualization output, i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isVisualizationOutputIn"></see></summary>
    let isVisualizationOutputIn = _prefix "isVisualizationOutputIn"
    /// <summary>
    /// (x isOldReferentInWholeToPart y) == y is a whole-to-part synecdoche where x acts as the old referent (the whole), i.e., the first element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInWholeToPart"></see></summary>
    let isOldReferentInWholeToPart = _prefix "isOldReferentInWholeToPart"
    /// <summary>
    /// (x changesReferentInWholeToPart y) == y is a whole-to-part synecdoche where x acts as the representamen, i.e., the second element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInWholeToPart"></see></summary>
    let changesReferentInWholeToPart = _prefix "changesReferentInWholeToPart"
    /// <summary>
    /// (x isNewReferentInWholeToPart y) == y is a whole-to-part synecdoche where x acts as the new referent (the part), i.e., the third element
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInWholeToPart"></see></summary>
    let isNewReferentInWholeToPart = _prefix "isNewReferentInWholeToPart"
    /// <summary>
    /// (x affirmsCognition y) means that x is about the cognition y, affirming its validity
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#affirmsCognition"></see></summary>
    let affirmsCognition = _prefix "affirmsCognition"
    /// <summary>
    /// (x providesJustification y) means that x is about some cognition z, providing a justification of it by referring to y, i.e., a grounding chain that establishes the epistemic status of z; thereby, x does not only affirm z, but also its grounding chain y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#providesJustification"></see></summary>
    let providesJustification = _prefix "providesJustification"
    /// <summary>
    /// (x articulatesNonliterally y) means that x is a collective non-literal expression (e.g., an utterance) of proposition y, and possibly additional propositions beside y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#articulatesNonliterally"></see></summary>
    let articulatesNonliterally = _prefix "articulatesNonliterally"
    /// <summary>
    /// (x isRepresentamenIn y) == x participates in the cognitive step y in the role of the/a representamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isRepresentamenIn"></see></summary>
    let isRepresentamenIn = _prefix "isRepresentamenIn"
    /// <summary>
    /// (x describesMethodAppliedIn y) means that x describes y in terms of the method that is employed
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#describesMethodAppliedIn"></see></summary>
    let describesMethodAppliedIn = _prefix "describesMethodAppliedIn"
    /// <summary>
    /// (x describesMethodEmployedBy y) means that the agent y follows a methodology described by x in carrying out an action
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#describesMethodEmployedBy"></see></summary>
    let describesMethodEmployedBy = _prefix "describesMethodEmployedBy"
    /// <summary>
    /// (X msIRHPIP Z) == isRepresentamenFor o hasProperPart o isProperPartOf == there is a Y such that (X isRepresentamenFor Y) and (Y overlapsWith Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIP"></see></summary>
    let msIRHPIP = _prefix "msIRHPIP"
    /// <summary>
    /// (x directlyPrecedesCognitiveStep y) == x is the cognitive step (or basic ground) that directly precedes y logically; typically, this means that y takes over a dyadic representation relation from x
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesCognitiveStep"></see></summary>
    let directlyPrecedesCognitiveStep = _prefix "directlyPrecedesCognitiveStep"
    /// <summary>
    /// (x directlyPrecedesByRupture y) == x is the cognitive step that directly precedes y logically (and typically, y takes over a dyadic representation relation from x), but either x or y constitutes a cognitive rupture, i.e., it interrupts the chain of grounding
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesByRupture"></see></summary>
    let directlyPrecedesByRupture = _prefix "directlyPrecedesByRupture"
    /// <summary>
    /// (x directlyPrecedesStep y) means that x and y are processes such that y can commence when x (and possibly other steps that also directly precede y) has finished
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesStep"></see></summary>
    let directlyPrecedesStep = _prefix "directlyPrecedesStep"
    /// <summary>
    /// 'precedesStep' is the transitive closure of 'directlyPrecedesStep'; (x precedesStep y) means that the processes x and y are, possibly indirectly, causally connected such that x needs to be concluded before y can commence
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#precedesStep"></see></summary>
    let precedesStep = _prefix "precedesStep"
    /// <summary>
    /// Direct causal connection (in a broad sense)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasDirectCausalConnectionWith"></see></summary>
    let hasDirectCausalConnectionWith = _prefix "hasDirectCausalConnectionWith"
    /// <summary>
    /// (x doesNotOverlapWith y) is the negation of (x overlapsWith y); i.e., the spatiotemporal intersection of x and y is empty
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#doesNotOverlapWith"></see></summary>
    let doesNotOverlapWith = _prefix "doesNotOverlapWith"
    /// <summary>
    /// Top mereosemiotic relation: Direct or indirect connection through mereotopological and semiotic relations
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMereosemioticallyRelatedTo"></see></summary>
    let isMereosemioticallyRelatedTo = _prefix "isMereosemioticallyRelatedTo"
    /// <summary>
    /// (x doesNotTemporallyOverlapWith y) is the negation of (x temporallyOverlapsWith y); i.e., there is no temporal overlap between x and y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#doesNotTemporallyOverlapWith"></see></summary>
    let doesNotTemporallyOverlapWith = _prefix "doesNotTemporallyOverlapWith"
    /// <summary>
    /// (x hasAbsoluteNecessityMode y) means that x is a relational IRI and y is an absolute modal IRI for 'necessarily x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasAbsoluteNecessityMode"></see></summary>
    let hasAbsoluteNecessityMode = _prefix "hasAbsoluteNecessityMode"
    /// <summary>
    /// (x hasNecessityMode y) means that x is a relational IRI and y is a modal IRI for 'necessarily x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasNecessityMode"></see></summary>
    let hasNecessityMode = _prefix "hasNecessityMode"
    /// <summary>
    /// (x hasAbsolutePossibilityMode y) means that x is a relational IRI and y is an absolute modal IRI for 'possibly x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasAbsolutePossibilityMode"></see></summary>
    let hasAbsolutePossibilityMode = _prefix "hasAbsolutePossibilityMode"
    /// <summary>
    /// (x hasPossibilityMode y) means that x is a relational IRI and y is a modal IRI for 'possibly x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasPossibilityMode"></see></summary>
    let hasPossibilityMode = _prefix "hasPossibilityMode"
    /// <summary>
    /// 'Real causal connection' relation following Peirce, here, given by the transitive closure of 'hasDirectCausalConnectionWith'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasCausalConnectionWith"></see></summary>
    let hasCausalConnectionWith = _prefix "hasCausalConnectionWith"
    /// <summary>
    /// Spatiotemporal (mereological) improper parthood relation; in other words, it is the reflexive closure of proper parthood: (x hasImproperPart y) means that all points within y are also within x
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasImproperPart"></see></summary>
    let hasImproperPart = _prefix "hasImproperPart"
    /// <summary>
    /// (x overlapsWith y) means that x and y share a spatiotemporal region where x and y intersect
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#overlapsWith"></see></summary>
    let overlapsWith = _prefix "overlapsWith"
    /// <summary>
    /// Spatiotemporal (mereological) improper parthood relation; in other words, it is the reflexive closure of proper parthood: (x isImproperPartOf y) means that all points within x are also within y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isImproperPartOf"></see></summary>
    let isImproperPartOf = _prefix "isImproperPartOf"
    /// <summary>
    /// (x hasNegation y) means that x and y are IRIs that can possibly occur in the predicate (middle) position of a triple, and that y is 'not x'; n.b., this is not a symmetrical relation, since 'not not x' is syntactically different from x
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasNegation"></see></summary>
    let hasNegation = _prefix "hasNegation"
    /// <summary>
    /// (x hasQualifiedNecessityMode y) means that x is a relational IRI and y is a qualified modal IRI for 'necessarily x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasQualifiedNecessityMode"></see></summary>
    let hasQualifiedNecessityMode = _prefix "hasQualifiedNecessityMode"
    /// <summary>
    /// (x hasQualifiedPossibilityMode y) means that x is a relational IRI and y is a qualified modal IRI for 'possibly x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasQualifiedPossibilityMode"></see></summary>
    let hasQualifiedPossibilityMode = _prefix "hasQualifiedPossibilityMode"
    /// <summary>
    /// Dyadic representation relation; (x hasRepresentamen y) means that there is a cognitive step z such that (x isReferentIn z) and (y isRepresentamenIn z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#hasRepresentamen"></see></summary>
    let hasRepresentamen = _prefix "hasRepresentamen"
    /// <summary>
    /// (X msHRHPIP Z) == hasRepresentamen o hasProperPart o isProperPartOf == there is a Y such that (Y isRepresentamenFor X) and (Y overlapsWith Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIP"></see></summary>
    let msHRHPIP = _prefix "msHRHPIP"
    /// <summary>
    /// (X msHPIPHR Z) == hasProperPart o isProperPartOf o hasRepresentamen == there is a Y such that (X overlapsWith Y) and (Z isRepresentamenFor Y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHR"></see></summary>
    let msHPIPHR = _prefix "msHPIPHR"
    /// <summary>
    /// chain relation hasRepresentamen o sharesReferentWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHR"></see></summary>
    let msHRIRHR = _prefix "msHRIRHR"
    /// <summary>
    /// (x isReferentIn y) == x occurs in the cognitive step y in the function of the/a referent of a representamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isReferentIn"></see></summary>
    let isReferentIn = _prefix "isReferentIn"
    /// <summary>
    /// (x isAccumulationConditionIn y) == in the accumulation process y, the condition x controls in what way the input and the additionally included elements interact to yield a combined output
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationConditionIn"></see></summary>
    let isAccumulationConditionIn = _prefix "isAccumulationConditionIn"
    /// <summary>
    /// (x isProperParticipantIn y) is the conjunction of (x isProperPartOf y) and (x isParticipantIn y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isProperParticipantIn"></see></summary>
    let isProperParticipantIn = _prefix "isProperParticipantIn"
    /// <summary>
    /// (x isAdmissibleUnitFor y) means that x is a unit that can be associated with the variable y; subsumption under msHPIPIR is explained as follows: There is a sign z for the variable y (where z is a description of admissible values of y) of which x is constitutive (and with which x hence overlaps)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAdmissibleUnitFor"></see></summary>
    let isAdmissibleUnitFor = _prefix "isAdmissibleUnitFor"
    /// <summary>
    /// (X msHPIPIR Z) == hasProperPart o isProperPartOf o isRepresentamenFor == there is a Y such that (X overlapsWith Y) and (Y isRepresentamenFor Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIR"></see></summary>
    let msHPIPIR = _prefix "msHPIPIR"
    /// <summary>
    /// chain relation msIPIR o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRIR"></see></summary>
    let msIPIRIR = _prefix "msIPIRIR"
    /// <summary>
    /// (x isExpressedBy y) means that x is expressed/stated/uttered by the interlocutor y; n.b., this does not necessarily mean that y affirms x (for that, use the subproperty isAssertedBy)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isExpressedBy"></see></summary>
    let isExpressedBy = _prefix "isExpressedBy"
    /// <summary>
    /// (x isAssertedIn y) means that x is a claim that is affirmatively expressed/stated/uttered in the expressive act y (by its speaker)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isAssertedIn"></see></summary>
    let isAssertedIn = _prefix "isAssertedIn"
    /// <summary>
    /// (x isExpressedIn y) means that x is expressed/stated/uttered in the expressive act y (by its speaker), possibly but not necessarily in an affirmative way
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isExpressedIn"></see></summary>
    let isExpressedIn = _prefix "isExpressedIn"
    /// <summary>
    /// (x isCausallyDisconnectedFrom y) means that between x and y there is no 'real causal connection' in the Peircean sense; therefore, x and y cannot be the old and new referents in a metonymization; similarly, x cannot act as a representamen for y in a grounded cognition (if it does, then the cognition is not grounded)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isCausallyDisconnectedFrom"></see></summary>
    let isCausallyDisconnectedFrom = _prefix "isCausallyDisconnectedFrom"
    /// <summary>
    /// In certain cases, multiple cognitive steps can be combined to yield one; e.g., the substep a: s - o - s' and the substep b: s' - o - s'' can be combined to yield a single triad, (a o b) = c: s - o - s''; in that case, c can be an element of a higher-order cognitive chain (of which it is a step), and a and b are its cognitive substeps
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isCognitiveSubstepOf"></see></summary>
    let isCognitiveSubstepOf = _prefix "isCognitiveSubstepOf"
    /// <summary>
    /// (x isConstitutiveOf y) means that, by virtue of an interaction requiring spatiotemporal overlap, x contributes causally to y fulfilling a certain function, exhibiting certain properties, or relating to other objects in the way it does, thereby creating a direct causal connection between x and y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isConstitutiveOf"></see></summary>
    let isConstitutiveOf = _prefix "isConstitutiveOf"
    /// <summary>
    /// the relation 'underlies' is the transitive closure of the relation 'isConstitutiveOf'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#underlies"></see></summary>
    let underlies = _prefix "underlies"
    /// <summary>
    /// (x isParticipantInCognition y) means that y is a cognition in which x is necessarily physically present and plays one of the roles characteristic for participation in a cognitive process as formalized by this ontology; this includes participation as a representamen, as a perceived object, as a step of a cognitive chain, or as an interpreter
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isParticipantInCognition"></see></summary>
    let isParticipantInCognition = _prefix "isParticipantInCognition"
    /// <summary>
    /// 'x isTriadOf (e1 e2 e3)' is a shorthand for 'e1 isFirstElementIn x; e2 isSecondElementIn x; e3 isThirdElementIn x'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTriadOf"></see></summary>
    let isTriadOf = _prefix "isTriadOf"
    /// <summary>
    /// x isFusionOf (y1 y2 ... yn) means that x is the spatiotemporal union (i.e., fusion) of all the elements included in the list (y1 y2 ... yn)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isFusionOf"></see></summary>
    let isFusionOf = _prefix "isFusionOf"
    /// <summary>
    /// Top property for multi-argument predicates that are implemented as 'x isRelatedToList (y1 y2 ... yn)', i.e., such that the object is an rdf:List
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isRelatedToList"></see></summary>
    let isRelatedToList = _prefix "isRelatedToList"
    /// <summary>
    /// (x isHeldBy y) means that the claim x is consistently asserted by the knowledge base y whenever it is queried about it; if y extends significantly through time and changes opinion about x (i.e., it does not assert it consistently over the whole time), it cannot be said to hold x as a claim, merely to assert it; in this case, it may be advisable to define a (temporal) part y' of y which can then be said to hold x as a claim
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isHeldBy"></see></summary>
    let isHeldBy = _prefix "isHeldBy"
    /// <summary>
    /// (x isInitialStepIn y) means that y is a step in x (i.e., a subprocess of x) that is not preceded by any other step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isInitialStepIn"></see></summary>
    let isInitialStepIn = _prefix "isInitialStepIn"
    /// <summary>
    /// (x isStepIn y) means that x and y are processes, where x is a proper part of y that plays a well-defined role within y (e.g., a task within a project, the execution of a single command within the execution of a program, etc.)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isStepIn"></see></summary>
    let isStepIn = _prefix "isStepIn"
    /// <summary>
    /// (x isListenerIn y) means that x is one of the interlocutors listening to the speaker's expressive act y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isListenerIn"></see></summary>
    let isListenerIn = _prefix "isListenerIn"
    /// <summary>
    /// (x isMaximizationObjectiveIn y) == x is a maximization objective/criterion considered in the optimization problem y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMaximizationObjectiveIn"></see></summary>
    let isMaximizationObjectiveIn = _prefix "isMaximizationObjectiveIn"
    /// <summary>
    /// (x isMaximizationObjectiveIn y) == x is a maximization objective/criterion considered in the optimization problem y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isMinimizationObjectiveIn"></see></summary>
    let isMinimizationObjectiveIn = _prefix "isMinimizationObjectiveIn"
    /// <summary>
    /// (x isParadataWithin y) means that x articulates something explicitly said to be unsubstantial to the rule y, and thereby semiotically constitutive of it, e.g., by a mechanism of logical subtraction
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isParadataWithin"></see></summary>
    let isParadataWithin = _prefix "isParadataWithin"
    /// <summary>
    /// (x isTemporallyIncludedIn y) means that the temporal extension of x is a proper part of the temporal extension of y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTemporallyIncludedIn"></see></summary>
    let isTemporallyIncludedIn = _prefix "isTemporallyIncludedIn"
    /// <summary>
    /// (s isReferenceFrameFor s') means that s is a representamen that provides relevant context, such as presuppositions or preconditions, to the representamen s'
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isReferenceFrameFor"></see></summary>
    let isReferenceFrameFor = _prefix "isReferenceFrameFor"
    /// <summary>
    /// (X sharesReferentWith Z) == there is a Y such that both X and Z isRepresentamenFor Y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#sharesReferentWith"></see></summary>
    let sharesReferentWith = _prefix "sharesReferentWith"
    /// <summary>
    /// chain relation sharesReferentWith o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRIR"></see></summary>
    let msIRHRIR = _prefix "msIRHRIR"
    /// <summary>
    /// (x isResultOf y) if x is an outcome/result of the cognitive process y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isResultOf"></see></summary>
    let isResultOf = _prefix "isResultOf"
    /// <summary>
    /// (x isSelectionConditionIn y) == in the selection process y, the condition x controls what constitutive element(s) of the input are retained as part of the output
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSelectionConditionIn"></see></summary>
    let isSelectionConditionIn = _prefix "isSelectionConditionIn"
    /// <summary>
    /// (x isSpatiotemporallyConnectedWith y) means that x and y overlap or are directly adjacent to each other at some point; i.e., there is a point p_x in x and a point p_y in y such that you can go from p_x to p_y without ever leaving the fusion (x U y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isSpatiotemporallyConnectedWith"></see></summary>
    let isSpatiotemporallyConnectedWith = _prefix "isSpatiotemporallyConnectedWith"
    /// <summary>
    /// (x isTemporallyConnectedWith y) means that there is a point in time where both x and y exist
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTemporallyConnectedWith"></see></summary>
    let isTemporallyConnectedWith = _prefix "isTemporallyConnectedWith"
    /// <summary>
    /// (x isTerminalStepIn y) means that y is a step in x (i.e., a subprocess of x) that does not precede any other step
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTerminalStepIn"></see></summary>
    let isTerminalStepIn = _prefix "isTerminalStepIn"
    /// <summary>
    /// (x isTargetPropertyIn y) means that cognitive action x targets y as the property for which a value is to be determined by observation or by theoretical or computational methods
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isTargetPropertyIn"></see></summary>
    let isTargetPropertyIn = _prefix "isTargetPropertyIn"
    /// <summary>
    /// (x temporallyCoextendsWith y) means that x and y have exactly the same extension in time, i.e., disregarding their spatial extension
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#temporallyCoextendsWith"></see></summary>
    let temporallyCoextendsWith = _prefix "temporallyCoextendsWith"
    /// <summary>
    /// (x temporallyOverlapsWith y) means that there is an (extended) interval in time where both x and y exist
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#temporallyOverlapsWith"></see></summary>
    let temporallyOverlapsWith = _prefix "temporallyOverlapsWith"
    /// <summary>
    /// (x isToolIn y) means that x is employed by an agent during the action y
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#isToolIn"></see></summary>
    let isToolIn = _prefix "isToolIn"
    /// <summary>
    /// (X msHPHR Z) == hasProperPart o hasRepresentamen == there is a Y such that (Y isProperPartOf X) and (Z isRepresentamenFor Y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHR"></see></summary>
    let msHPHR = _prefix "msHPHR"
    /// <summary>
    /// chain relation msHPHR o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHPIP"></see></summary>
    let msHPHRHPIP = _prefix "msHPHRHPIP"
    /// <summary>
    /// (X msIRIP Z) == isRepresentamenFor o isProperPartOf == there is a Y such that (X isRepresentamenFor Y) and (Y isProperPartOf Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIP"></see></summary>
    let msIRIP = _prefix "msIRIP"
    /// <summary>
    /// chain relation msHPHR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHP"></see></summary>
    let msHPHRHP = _prefix "msHPHRHP"
    /// <summary>
    /// chain relation overlapsWith o msHRHP
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRHP"></see></summary>
    let msHPIPHRHP = _prefix "msHPIPHRHP"
    /// <summary>
    /// chain relation msIPIR o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRIP"></see></summary>
    let msIPIRIP = _prefix "msIPIRIP"
    /// <summary>
    /// chain relation overlapsWith o msIRIP
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRIP"></see></summary>
    let msHPIPIRIP = _prefix "msHPIPIRIP"
    /// <summary>
    /// chain relation msHPHR o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHR"></see></summary>
    let msHPHRHR = _prefix "msHPHRHR"
    /// <summary>
    /// chain relation overlapsWith o msHRHR
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRHR"></see></summary>
    let msHPIPHRHR = _prefix "msHPIPHRHR"
    /// <summary>
    /// chain relation msIRIR o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRIP"></see></summary>
    let msIRIRIP = _prefix "msIRIRIP"
    /// <summary>
    /// chain relation msHPHR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRIP"></see></summary>
    let msHPHRIP = _prefix "msHPHRIP"
    /// <summary>
    /// chain relation overlapsWith o msHRIP
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRIP"></see></summary>
    let msHPIPHRIP = _prefix "msHPIPHRIP"
    /// <summary>
    /// chain relation msHPIR o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRIP"></see></summary>
    let msHPIRIP = _prefix "msHPIRIP"
    /// <summary>
    /// chain relation hasProperPart o sharesRepresentamenWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRIR"></see></summary>
    let msHPHRIR = _prefix "msHPHRIR"
    /// <summary>
    /// chain relation overlapsWith o sharesRepresentamenWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRIR"></see></summary>
    let msHPIPHRIR = _prefix "msHPIPHRIR"
    /// <summary>
    /// chain relation sharesRepresentamenWith o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRIP"></see></summary>
    let msHRIRIP = _prefix "msHRIRIP"
    /// <summary>
    /// (X sharesRepresentamenWith Z) == there is a Y such that Y isRepresentamenFor both X and Z
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#sharesRepresentamenWith"></see></summary>
    let sharesRepresentamenWith = _prefix "sharesRepresentamenWith"
    /// <summary>
    /// chain relation msIPIR o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHPIP"></see></summary>
    let msIPIRHPIP = _prefix "msIPIRHPIP"
    /// <summary>
    /// (X msHRHP Z) == hasRepresentamen o hasProperPart == there is a Y such that (Y isRepresentamenFor X) and (Z isProperPartOf Y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHP"></see></summary>
    let msHRHP = _prefix "msHRHP"
    /// <summary>
    /// chain relation msIRIR o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHPIP"></see></summary>
    let msIRIRHPIP = _prefix "msIRIRHPIP"
    /// <summary>
    /// (X msHRHR Z) == (hasRepresentamen)^2 == there is a Y such that (Y isRepresentamenFor X) and (Z isRepresentamenFor Y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHR"></see></summary>
    let msHRHR = _prefix "msHRHR"
    /// <summary>
    /// chain relation msHPIR o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHPIP"></see></summary>
    let msHPIRHPIP = _prefix "msHPIRHPIP"
    /// <summary>
    /// (X msHRIP Z) == hasRepresentamen o isProperPartOf == there is a Y such that (Y isRepresentamenFor X) and (Y isProperPartOf Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIP"></see></summary>
    let msHRIP = _prefix "msHRIP"
    /// <summary>
    /// chain relation sharesRepresentamenWith o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHPIP"></see></summary>
    let msHRIRHPIP = _prefix "msHRIRHPIP"
    /// <summary>
    /// chain relation overlapsWith o msIRHP
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRHP"></see></summary>
    let msHPIPIRHP = _prefix "msHPIPIRHP"
    /// <summary>
    /// chain relation msIPHR o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHPIP"></see></summary>
    let msIPHRHPIP = _prefix "msIPHRHPIP"
    /// <summary>
    /// (X msIRHP Z) == isRepresentamenFor o hasProperPart == there is a Y such that (X isRepresentamenFor Y) and (Z isProperPartOf Y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHP"></see></summary>
    let msIRHP = _prefix "msIRHP"
    /// <summary>
    /// chain relation overlapsWith o sharesReferentWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRHR"></see></summary>
    let msHPIPIRHR = _prefix "msHPIPIRHR"
    /// <summary>
    /// chain relation sharesReferentWith o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHPIP"></see></summary>
    let msIRHRHPIP = _prefix "msIRHRHPIP"
    /// <summary>
    /// chain relation overlapsWith o msIRIR
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRIR"></see></summary>
    let msHPIPIRIR = _prefix "msHPIPIRIR"
    /// <summary>
    /// chain relation msHRHR o overlapsWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHPIP"></see></summary>
    let msHRHRHPIP = _prefix "msHRHRHPIP"
    /// <summary>
    /// (X msIRIR Z) == (isRepresentamenFor)^2 == there is a Y such that (X isRepresentamenFor Y) and (Y isRepresentamenFor Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIR"></see></summary>
    let msIRIR = _prefix "msIRIR"
    /// <summary>
    /// (X msHPIR Z) == hasProperPart o isRepresentamenFor == there is a Y such that (Y isProperPartOf X) and (Y is RepresentamenFor Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIR"></see></summary>
    let msHPIR = _prefix "msHPIR"
    /// <summary>
    /// chain relation msHPIR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHP"></see></summary>
    let msHPIRHP = _prefix "msHPIRHP"
    /// <summary>
    /// chain relation msIPHR o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRIP"></see></summary>
    let msIPHRIP = _prefix "msIPHRIP"
    /// <summary>
    /// chain relation hasProperPart o sharesReferentWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHR"></see></summary>
    let msHPIRHR = _prefix "msHPIRHR"
    /// <summary>
    /// chain relation sharesReferentWith o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRIP"></see></summary>
    let msIRHRIP = _prefix "msIRHRIP"
    /// <summary>
    /// chain relation msHPIR o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRIR"></see></summary>
    let msHPIRIR = _prefix "msHPIRIR"
    /// <summary>
    /// chain relation msHRHR o isProperPartOf
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRIP"></see></summary>
    let msHRHRIP = _prefix "msHRHRIP"
    /// <summary>
    /// (X msIP Z) == isProperPartOf o isRepresentamenFor == there is a Y such that (X isProperPartOf Y) and (Y isRepresentamenFor Z)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIR"></see></summary>
    let msIPIR = _prefix "msIPIR"
    /// <summary>
    /// chain relation msHRHP o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPHR"></see></summary>
    let msHRHPHR = _prefix "msHRHPHR"
    /// <summary>
    /// chain relation msHRHP o msIPHR
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIPHR"></see></summary>
    let msHRHPIPHR = _prefix "msHRHPIPHR"
    /// <summary>
    /// chain relation msIRIP o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIPIR"></see></summary>
    let msIRIPIR = _prefix "msIRIPIR"
    /// <summary>
    /// chain relation msIRHP o msIPIR
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIPIR"></see></summary>
    let msIRHPIPIR = _prefix "msIRHPIPIR"
    /// <summary>
    /// (X msIPHR Z) == isProperPartOf o hasRepresentamen == there is a Y such that (X isProperPartOf Y) and (Z isRepresentamenFor Y)
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHR"></see></summary>
    let msIPHR = _prefix "msIPHR"
    /// <summary>
    /// chain relation msHRHP o msIPIR
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIPIR"></see></summary>
    let msHRHPIPIR = _prefix "msHRHPIPIR"
    /// <summary>
    /// chain relation msHRHP o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIR"></see></summary>
    let msHRHPIR = _prefix "msHRHPIR"
    /// <summary>
    /// chain relation msHRIP o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIPIR"></see></summary>
    let msHRIPIR = _prefix "msHRIPIR"
    /// <summary>
    /// chain relation msHRHR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHP"></see></summary>
    let msHRHRHP = _prefix "msHRHRHP"
    /// <summary>
    /// chain relation msHRHR o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHR"></see></summary>
    let msHRHRHR = _prefix "msHRHRHR"
    /// <summary>
    /// chain relation msIRIR o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRIR"></see></summary>
    let msIRIRIR = _prefix "msIRIRIR"
    /// <summary>
    /// chain relation hasRepresentamen o sharesRepresentamenWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRIR"></see></summary>
    let msHRHRIR = _prefix "msHRHRIR"
    /// <summary>
    /// chain relation sharesRepresentamenWith o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRIR"></see></summary>
    let msHRIRIR = _prefix "msHRIRIR"
    /// <summary>
    /// chain relation msHRIP o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIPHR"></see></summary>
    let msHRIPHR = _prefix "msHRIPHR"
    /// <summary>
    /// chain relation msIRHP o isRepresentamenFor
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIR"></see></summary>
    let msIRHPIR = _prefix "msIRHPIR"
    /// <summary>
    /// chain relation sharesRepresentamenWith o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHP"></see></summary>
    let msHRIRHP = _prefix "msHRIRHP"
    /// <summary>
    /// chain relation isProperPartOf o sharesRepresentamenWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRIR"></see></summary>
    let msIPHRIR = _prefix "msIPHRIR"
    /// <summary>
    /// chain relation msIPHR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHP"></see></summary>
    let msIPHRHP = _prefix "msIPHRHP"
    /// <summary>
    /// chain relation msIPIR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHP"></see></summary>
    let msIPIRHP = _prefix "msIPIRHP"
    /// <summary>
    /// chain relation msIPHR o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHR"></see></summary>
    let msIPHRHR = _prefix "msIPHRHR"
    /// <summary>
    /// chain relation msIRIR o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHP"></see></summary>
    let msIRIRHP = _prefix "msIRIRHP"
    /// <summary>
    /// chain relation isProperPartOf o sharesReferentWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHR"></see></summary>
    let msIPIRHR = _prefix "msIPIRHR"
    /// <summary>
    /// chain relation sharesReferentWith o hasProperPart
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHP"></see></summary>
    let msIRHRHP = _prefix "msIRHRHP"
    /// <summary>
    /// chain relation msIRHP o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPHR"></see></summary>
    let msIRHPHR = _prefix "msIRHPHR"
    /// <summary>
    /// chain relation msIRHP o msIPHR
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIPHR"></see></summary>
    let msIRHPIPHR = _prefix "msIRHPIPHR"
    /// <summary>
    /// chain relation msIRIP o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIPHR"></see></summary>
    let msIRIPHR = _prefix "msIRIPHR"
    /// <summary>
    /// chain relation sharesReferentWith o hasRepresentamen
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHR"></see></summary>
    let msIRHRHR = _prefix "msIRHRHR"
    /// <summary>
    /// chain relation isRepresentamenFor o sharesReferentWith
    /// <see href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHR"></see></summary>
    let msIRIRHR = _prefix "msIRIRHR"
