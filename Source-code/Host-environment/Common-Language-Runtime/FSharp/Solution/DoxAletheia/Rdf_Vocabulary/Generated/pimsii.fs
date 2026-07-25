namespace http.www.molmod.info.semantics.pims_ii.ttl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pimsii =
    let _namespace_iri = Namespace_Iri pimsii |> NamespaceIRI
    /// <summary>
    ///   <para>pimsii:AbsoluteLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Absolute law, i.e., a law where the necessary entailment of the consequent(s) by the antecedent is expressed in terms of absolute logical/physical necessity</para>
    /// labels<para>AbsoluteLaw</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#AbsoluteLaw">http://www.molmod.info/semantics/pims-ii.ttl#AbsoluteLaw</seealso>
    let AbsoluteLaw = Prefixed_Name(pimsii, "AbsoluteLaw") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Accumulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Accumulation, i.e., an information-processing step in which the given information is extended/complemented such that the input (sign) and one or multiple additional representamina (cf. relation isIncludedInAccumulation) are jointly constitutive of the output (interpretant); this includes conditional accumulation, where the choice and the way in which information is combined depends on an accumulation condition (cf. relation isAccumulationConditionIn)</para>
    /// labels<para>Accumulation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Accumulation">http://www.molmod.info/semantics/pims-ii.ttl#Accumulation</seealso>
    let Accumulation = Prefixed_Name(pimsii, "Accumulation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isAccumulationInputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isAccumulationInputIn y) == y is an accumulation where x is the input (initially given information), i.e., the first element; n.b., in an accumulation, the input needs to be constitutive of the output</para>
    /// labels<para>isAccumulationInputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationInputIn">http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationInputIn</seealso>
    let isAccumulationInputIn =
        Prefixed_Name(pimsii, "isAccumulationInputIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:InformationProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information processing, i.e., an interpretation in which information is handled, revised, reformatted, extended, or narrowed down (or anything comparable to such actions), e.g., preprocessing or postprocessing in a simulation workflow</para>
    /// labels<para>InformationProcessing</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#InformationProcessing">http://www.molmod.info/semantics/pims-ii.ttl#InformationProcessing</seealso>
    let InformationProcessing =
        Prefixed_Name(pimsii, "InformationProcessing") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Action, i.e., a process that is conducted/undertaken by an agent - the action has exactly one agent</para>
    /// labels<para>Action</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Action">http://www.molmod.info/semantics/pims-ii.ttl#Action</seealso>
    let Action = Prefixed_Name(pimsii, "Action") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Articulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Articulation (collective expression), i.e., a semiotic collective the semiotic members (i.e., realizations) of which are not semiotic collectives, but individual literal (written or digital) or non-literal (e.g., spoken) items with the same semiotic function (or undergoing evaluation whether such a function is present)</para>
    /// labels<para>Articulation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Articulation">http://www.molmod.info/semantics/pims-ii.ttl#Articulation</seealso>
    let Articulation = Prefixed_Name(pimsii, "Articulation") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isSemioticMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSemioticMemberOf y) means that x acts as a representamen or as a referent jointly with other co-members of the same semiotic collective y</para>
    /// labels<para>isSemioticMemberOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSemioticMemberOf">http://www.molmod.info/semantics/pims-ii.ttl#isSemioticMemberOf</seealso>
    let isSemioticMemberOf = Prefixed_Name(pimsii, "isSemioticMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Ground</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ground (of a cognitive step), i.e., a proposition that justifies a cognitive step by explaning it and stating from what preceding step (which directly grounds that step) a sign-object relation is carried over, and in what way</para>
    /// labels<para>Ground</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Ground">http://www.molmod.info/semantics/pims-ii.ttl#Ground</seealso>
    let Ground = Prefixed_Name(pimsii, "Ground") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Variable, i.e., a conventional that is employed for something to which values can be assigned (this may include different notations for the same variable including, e.g., computational representations); this is to be understood very generally, e.g., a variable may be an array or set of elements or have another kind of internal structure</para>
    /// labels<para>Variable</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Variable">http://www.molmod.info/semantics/pims-ii.ttl#Variable</seealso>
    let Variable = Prefixed_Name(pimsii, "Variable") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isVariableInAssignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isVariableInAssignment a) mans that a: x = y is an assignment where a value y is assigned to the variable x</para>
    /// labels<para>isVariableInAssignment</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isVariableInAssignment">http://www.molmod.info/semantics/pims-ii.ttl#isVariableInAssignment</seealso>
    let isVariableInAssignment =
        Prefixed_Name(pimsii, "isVariableInAssignment") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isAssignmentFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(d isAssignmentFor o) means that d: x = y is an assignment that refers to o</para>
    /// labels<para>isAssignmentFor</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isAssignmentFor">http://www.molmod.info/semantics/pims-ii.ttl#isAssignmentFor</seealso>
    let isAssignmentFor = Prefixed_Name(pimsii, "isAssignmentFor") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:DigitalConventional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Digital conventional, i.e., a conventional that is a digital articulation</para>
    /// labels<para>DigitalConventional</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#DigitalConventional">http://www.molmod.info/semantics/pims-ii.ttl#DigitalConventional</seealso>
    let DigitalConventional =
        Prefixed_Name(pimsii, "DigitalConventional") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:EqualityArticulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Equality articulation, i.e., a dyad by which two terms are asserted to be equal or to become equal</para>
    /// labels<para>EqualityArticulation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#EqualityArticulation">http://www.molmod.info/semantics/pims-ii.ttl#EqualityArticulation</seealso>
    let EqualityArticulation =
        Prefixed_Name(pimsii, "EqualityArticulation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:MaterialIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Name or label that identifies the material of its referent, or the material that some semiotic collective is about</para>
    /// labels<para>MaterialIdentifier</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#MaterialIdentifier">http://www.molmod.info/semantics/pims-ii.ttl#MaterialIdentifier</seealso>
    let MaterialIdentifier = Prefixed_Name(pimsii, "MaterialIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Claim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Claim, i.e., a proposition that is expressed by an interlocutor or believed/held by an intelligent agent</para>
    /// labels<para>Claim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Claim">http://www.molmod.info/semantics/pims-ii.ttl#Claim</seealso>
    let Claim = Prefixed_Name(pimsii, "Claim") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:IntelligentAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Intelligent agent, i.e., a goal-oriented agent that can internally make/hold claims (knowledge, beliefs, etc.). This requires the agent to have some kind of internal representation of its surroundings, and to store and process information about its surroundings. (Note that this does not require the agent to be queryable for its claims; for that purpose, use KnowledgeBase.)</para>
    /// labels<para>IntelligentAgent</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#IntelligentAgent">http://www.molmod.info/semantics/pims-ii.ttl#IntelligentAgent</seealso>
    let IntelligentAgent = Prefixed_Name(pimsii, "IntelligentAgent") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Cognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cognition, i.e., a process dealing with representamina (signs) consisting either of a single cognitive step, of multiple steps that are connected to each other as a cognitive chain, or of an anchor point for epistemic grounding</para>
    /// labels<para>Cognition</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Cognition">http://www.molmod.info/semantics/pims-ii.ttl#Cognition</seealso>
    let Cognition = Prefixed_Name(pimsii, "Cognition") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isInterpreterIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isInterpreterIn y) means that x is the (unique) agent who conducts/undertakes the cognitive action y</para>
    /// labels<para>isInterpreterIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpreterIn">http://www.molmod.info/semantics/pims-ii.ttl#isInterpreterIn</seealso>
    let isInterpreterIn = Prefixed_Name(pimsii, "isInterpreterIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isStepInCognitiveChain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isStepInCognitiveChain y) means that y is a cognitive chain that consists of multiple logically connected cognitive steps (following Peirce, these are typically triads, i.e., semioses and semantic changes), and that x is one of these steps</para>
    /// labels<para>isStepInCognitiveChain</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isStepInCognitiveChain">http://www.molmod.info/semantics/pims-ii.ttl#isStepInCognitiveChain</seealso>
    let isStepInCognitiveChain =
        Prefixed_Name(pimsii, "isStepInCognitiveChain") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:CognitiveRupture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cognitive rupture, i.e., a cognitive step that constitutes a break in the chain of epistemic grounding</para>
    /// labels<para>CognitiveRupture</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveRupture">http://www.molmod.info/semantics/pims-ii.ttl#CognitiveRupture</seealso>
    let CognitiveRupture = Prefixed_Name(pimsii, "CognitiveRupture") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:CognitiveWorkflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cognitive workflow, i.e., a purposefully conducted cognitive chain</para>
    /// labels<para>CognitiveWorkflow</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveWorkflow">http://www.molmod.info/semantics/pims-ii.ttl#CognitiveWorkflow</seealso>
    let CognitiveWorkflow = Prefixed_Name(pimsii, "CognitiveWorkflow") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:PurposefulAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Purposeful action, i.e., an action carried out with an aim of which its agent (hence, a goal-directed agent) is aware</para>
    /// labels<para>PurposefulAction</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#PurposefulAction">http://www.molmod.info/semantics/pims-ii.ttl#PurposefulAction</seealso>
    let PurposefulAction = Prefixed_Name(pimsii, "PurposefulAction") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Collective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collective, i.e., an object that has multiple items as members</para>
    /// labels<para>Collective</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Collective">http://www.molmod.info/semantics/pims-ii.ttl#Collective</seealso>
    let Collective = Prefixed_Name(pimsii, "Collective") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:MereotopologicalCollective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mereotopological collective, i.e., a region of spacetime that consists of multiple connected components, which are its mereotopological members</para>
    /// labels<para>MereotopologicalCollective</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#MereotopologicalCollective">http://www.molmod.info/semantics/pims-ii.ttl#MereotopologicalCollective</seealso>
    let MereotopologicalCollective =
        Prefixed_Name(pimsii, "MereotopologicalCollective") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:CollectiveLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collective literal, i.e., a semiotic collective the members of which all have a digital, printed, or written textual/numerical form in that they are all instances/copies of the same RDFS literal (or multiple RDFS literals that are very similar, e.g., different ways of spelling/abbreviating the same word or denoting the same number); n.b., collective literals are not permitted to have other semiotic collectives as their semiotic members</para>
    /// labels<para>CollectiveLiteral</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#CollectiveLiteral">http://www.molmod.info/semantics/pims-ii.ttl#CollectiveLiteral</seealso>
    let CollectiveLiteral = Prefixed_Name(pimsii, "CollectiveLiteral") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:CollectiveUtterance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collective utterance, i.e., a semiotic collective the members of which do not have digital, printed, or written textual/numerical form and the members of which are all attributed the same semantics and pragmatics; n.b., collective utterances are not permitted to have other semiotic collectives as their semiotic members</para>
    /// labels<para>CollectiveUtterance</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#CollectiveUtterance">http://www.molmod.info/semantics/pims-ii.ttl#CollectiveUtterance</seealso>
    let CollectiveUtterance =
        Prefixed_Name(pimsii, "CollectiveUtterance") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isInterlocutorIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isInterlocutorIn y) means that x engages, jointly with other interlocutors, in the communication y</para>
    /// labels<para>isInterlocutorIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isInterlocutorIn">http://www.molmod.info/semantics/pims-ii.ttl#isInterlocutorIn</seealso>
    let isInterlocutorIn = Prefixed_Name(pimsii, "isInterlocutorIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:ExpressiveAct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Expressive act, i.e., a purposeful communication (e.g., a speech act or an analogous digital act of communicating) issued by its agent, the speaker (understood in a generalized sense, i.e., not limited to speech) - the purpose of the action consists of its illocutionary and perlocutionary intent</para>
    /// labels<para>ExpressiveAct</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ExpressiveAct">http://www.molmod.info/semantics/pims-ii.ttl#ExpressiveAct</seealso>
    let ExpressiveAct = Prefixed_Name(pimsii, "ExpressiveAct") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:IRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Internationalized resource identifier (IRI) as defined by RFC 3987; an IRI object should be related by 'isLiterally' to an xs:string containing the IRI literal</para>
    /// labels<para>IRI</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#IRI">http://www.molmod.info/semantics/pims-ii.ttl#IRI</seealso>
    let IRI = Prefixed_Name(pimsii, "IRI") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:RelationalIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Relational IRI, i.e., the internationalized resource identifier of a something that can play the role of the predicate in a triple; this includes 'rdf:type', object properties, datatype properties, their negations</para>
    /// labels<para>RelationalIRI</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#RelationalIRI">http://www.molmod.info/semantics/pims-ii.ttl#RelationalIRI</seealso>
    let RelationalIRI = Prefixed_Name(pimsii, "RelationalIRI") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:ConceptualKnowledgeClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Conceptual knowledge claim (CKC), i.e., a knowledge claim establishing the ontological status of a lexeme</para>
    /// labels<para>ConceptualKnowledgeClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ConceptualKnowledgeClaim">http://www.molmod.info/semantics/pims-ii.ttl#ConceptualKnowledgeClaim</seealso>
    let ConceptualKnowledgeClaim =
        Prefixed_Name(pimsii, "ConceptualKnowledgeClaim") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:KnowledgeClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Knowledge claim (KC), i.e., a claim about something with respect to its knowledge status</para>
    /// labels<para>KnowledgeClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeClaim">http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeClaim</seealso>
    let KnowledgeClaim = Prefixed_Name(pimsii, "KnowledgeClaim") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:PropertyClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Property claim (PC), i.e., a knowledge claim concerning a property</para>
    /// labels<para>PropertyClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#PropertyClaim">http://www.molmod.info/semantics/pims-ii.ttl#PropertyClaim</seealso>
    let PropertyClaim = Prefixed_Name(pimsii, "PropertyClaim") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Conventional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Conventional, i.e., a semiotic collective articulation the members of which jointly fulfill a certain semiotic function by social convention; e.g., many spoken or written occurrences of the words 'enthalpy of vaporization' or 'latent heat' may act together as a property in this sense</para>
    /// labels<para>Conventional</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Conventional">http://www.molmod.info/semantics/pims-ii.ttl#Conventional</seealso>
    let Conventional = Prefixed_Name(pimsii, "Conventional") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isRepresentamenFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Dyadic representation relation; (x isRepresentamenFor y) means that there is a cognitive step z such that (x isRepresentamenIn z) and (y isReferentIn z)</para>
    /// labels<para>isRepresentamenFor</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isRepresentamenFor">http://www.molmod.info/semantics/pims-ii.ttl#isRepresentamenFor</seealso>
    let isRepresentamenFor = Prefixed_Name(pimsii, "isRepresentamenFor") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:DataItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data item, i.e., a digital articulation given as a tuple of digital conventionals</para>
    /// labels<para>DataItem</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#DataItem">http://www.molmod.info/semantics/pims-ii.ttl#DataItem</seealso>
    let DataItem = Prefixed_Name(pimsii, "DataItem") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Duplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Duplication, i.e., an information-processing step in which the given information is reproduced, copied, converted into a different, but equivalent format, or any similar procedure; e.g., this may be based on a legisign to which the original (sign) and the duplicate (interpretant) jointly conform or on a semiotic collective of which they both semiotic members</para>
    /// labels<para>Duplication</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Duplication">http://www.molmod.info/semantics/pims-ii.ttl#Duplication</seealso>
    let Duplication = Prefixed_Name(pimsii, "Duplication") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isOriginalIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isOriginalIn y) == y is a duplication step where x is the input (original version), i.e., the first element</para>
    /// labels<para>isOriginalIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isOriginalIn">http://www.molmod.info/semantics/pims-ii.ttl#isOriginalIn</seealso>
    let isOriginalIn = Prefixed_Name(pimsii, "isOriginalIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isObjectInDuplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObjectInDuplication y) == y is a duplication step where x is the object that the original and the duplicate both represent, i.e., the second element</para>
    /// labels<para>isObjectInDuplication</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInDuplication">http://www.molmod.info/semantics/pims-ii.ttl#isObjectInDuplication</seealso>
    let isObjectInDuplication =
        Prefixed_Name(pimsii, "isObjectInDuplication") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isDuplicateIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isDuplicateIn y) == y is a duplication step where x is the output (duplicate), i.e., the third element</para>
    /// labels<para>isDuplicateIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isDuplicateIn">http://www.molmod.info/semantics/pims-ii.ttl#isDuplicateIn</seealso>
    let isDuplicateIn = Prefixed_Name(pimsii, "isDuplicateIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Dyad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dyad, i.e., a data item by which two conventionals are grouped together; e.g., an equality or inequality articulation</para>
    /// labels<para>Dyad</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Dyad">http://www.molmod.info/semantics/pims-ii.ttl#Dyad</seealso>
    let Dyad = Prefixed_Name(pimsii, "Dyad") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isFirstInDyad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isFirstInDyad d) means that x is the first element of the dyad d</para>
    /// labels<para>isFirstInDyad</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isFirstInDyad">http://www.molmod.info/semantics/pims-ii.ttl#isFirstInDyad</seealso>
    let isFirstInDyad = Prefixed_Name(pimsii, "isFirstInDyad") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isSecondInDyad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(y isSecondInDyad d) means that y is the second element of the dyad d</para>
    /// labels<para>isSecondInDyad</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSecondInDyad">http://www.molmod.info/semantics/pims-ii.ttl#isSecondInDyad</seealso>
    let isSecondInDyad = Prefixed_Name(pimsii, "isSecondInDyad") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:EPRC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>EPRC, i.e., an exact-agreement provenance-conscious reproducibility claim</para>
    /// labels<para>EPRC</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#EPRC">http://www.molmod.info/semantics/pims-ii.ttl#EPRC</seealso>
    let EPRC = Prefixed_Name(pimsii, "EPRC") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:ExactAgreementReproducibilityClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Exact-agreement reproducibility claim (ERC), i.e., a reproducibility claim obtained as an outcome of an attempt at obtaining exactly the same outcome as the original study</para>
    /// labels<para>ExactAgreementReproducibilityClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ExactAgreementReproducibilityClaim">http://www.molmod.info/semantics/pims-ii.ttl#ExactAgreementReproducibilityClaim</seealso>
    let ExactAgreementReproducibilityClaim =
        Prefixed_Name(pimsii, "ExactAgreementReproducibilityClaim") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:ProvenanceConsciousReproducibilityClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provenance-conscious reproducibility claim (PRC), i.e., a reproducibility claim obtained from an attempt that was subject to the requirement to retain the original research process or aspects of it</para>
    /// labels<para>ProvenanceConsciousReproducibilityClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ProvenanceConsciousReproducibilityClaim">http://www.molmod.info/semantics/pims-ii.ttl#ProvenanceConsciousReproducibilityClaim</seealso>
    let ProvenanceConsciousReproducibilityClaim =
        Prefixed_Name(pimsii, "ProvenanceConsciousReproducibilityClaim") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:TeamChangeReproducibilityClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Team-change reproducibility claim (TRC), i.e., a reproducibility claim obtained as an outcome of a reproducibility study conducted by an independent team</para>
    /// labels<para>TeamChangeReproducibilityClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#TeamChangeReproducibilityClaim">http://www.molmod.info/semantics/pims-ii.ttl#TeamChangeReproducibilityClaim</seealso>
    let TeamChangeReproducibilityClaim =
        Prefixed_Name(pimsii, "TeamChangeReproducibilityClaim") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Term, i.e., a conventional that can evaluate to a value; terms include variables, values, and any mathematically and semantically valid ways of combining variables, values, and mathematical operators - note that it is required for a term to potentially take a value</para>
    /// labels<para>Term</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Term">http://www.molmod.info/semantics/pims-ii.ttl#Term</seealso>
    let Term = Prefixed_Name(pimsii, "Term") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isLeftHandSideIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isLeftHandSideIn a) mans that a: x = y is an equality articulation with the term x as its left-hand side</para>
    /// labels<para>isLeftHandSideIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isLeftHandSideIn">http://www.molmod.info/semantics/pims-ii.ttl#isLeftHandSideIn</seealso>
    let isLeftHandSideIn = Prefixed_Name(pimsii, "isLeftHandSideIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Evaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Evaluation, i.e., a reflection ex post (Reflexion des Vollzugs following Baumann and Tulatz) or redetermination, carried out after an action has terminated, either by the same agent or by somebody else</para>
    /// labels<para>Evaluation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Evaluation">http://www.molmod.info/semantics/pims-ii.ttl#Evaluation</seealso>
    let Evaluation = Prefixed_Name(pimsii, "Evaluation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isTelosInEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isTelosInEvaluation y) == y is an evaluation (reflection ex post) where x acts as the telos (initial guiding objective), i.e., the first element</para>
    /// labels<para>isTelosInEvaluation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInEvaluation">http://www.molmod.info/semantics/pims-ii.ttl#isTelosInEvaluation</seealso>
    let isTelosInEvaluation =
        Prefixed_Name(pimsii, "isTelosInEvaluation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isEvaluatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isEvaluatedIn y) == y is an evaluation (reflection ex post) where x is the action undergoing evaluation, i.e., the second element; n.b., the action needs to temporally precede the evaluation</para>
    /// labels<para>isEvaluatedIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isEvaluatedIn">http://www.molmod.info/semantics/pims-ii.ttl#isEvaluatedIn</seealso>
    let isEvaluatedIn = Prefixed_Name(pimsii, "isEvaluatedIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Telesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Telesis (teleological semiosis), i.e., a semiosis where the sign is a telos (aim), the object is an action, claim, or situation against which that aim is evaluated, and the interpretant is a resolution, e.g., a revised objective, plan, or similar evaluation outcome</para>
    /// labels<para>Telesis</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Telesis">http://www.molmod.info/semantics/pims-ii.ttl#Telesis</seealso>
    let Telesis = Prefixed_Name(pimsii, "Telesis") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isEvaluationOutcomeIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isEvaluationOutcomeIn y) == y is a an evaluation (reflection ex post) where x is the resolution (evaluation outcome), i.e., the third element</para>
    /// labels<para>isEvaluationOutcomeIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isEvaluationOutcomeIn">http://www.molmod.info/semantics/pims-ii.ttl#isEvaluationOutcomeIn</seealso>
    let isEvaluationOutcomeIn =
        Prefixed_Name(pimsii, "isEvaluationOutcomeIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:directlyGrounds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x directlyGrounds y) == x is the cognitive step (or basic ground) that directly precedes y logically, such that a dyadic representation relation from y is taken over from x (or assumed to be grounded a priori due to x)</para>
    /// labels<para>directlyGrounds</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#directlyGrounds">http://www.molmod.info/semantics/pims-ii.ttl#directlyGrounds</seealso>
    let directlyGrounds = Prefixed_Name(pimsii, "directlyGrounds") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:GoalDirectedAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>'Goal-directed agents are intelligent agents that have an internal representation of the goals they [tend to] achieve' (Conte, doi:10.1007/978-1-4614-1800-9_158, 2009)</para>
    /// labels<para>GoalDirectedAgent</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#GoalDirectedAgent">http://www.molmod.info/semantics/pims-ii.ttl#GoalDirectedAgent</seealso>
    let GoalDirectedAgent = Prefixed_Name(pimsii, "GoalDirectedAgent") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isEvaluatorIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isEvaluatorIn y) means that y is an evaluation and x is the interpreter in it</para>
    /// labels<para>isEvaluatorIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isEvaluatorIn">http://www.molmod.info/semantics/pims-ii.ttl#isEvaluatorIn</seealso>
    let isEvaluatorIn = Prefixed_Name(pimsii, "isEvaluatorIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Interpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Interpretation, i.e., a semiosis where the sign-object relation is carried over from the preceding cognitive step, without the need for the represented object to be present physically</para>
    /// labels<para>Interpretation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Interpretation">http://www.molmod.info/semantics/pims-ii.ttl#Interpretation</seealso>
    let Interpretation = Prefixed_Name(pimsii, "Interpretation") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Examination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Examination (by pattern matching &amp; similar), i.e., an observation by which a legisign (specifying patterns or rules) is applied to an examined object, yielding an examination outcome that expresses in what way or to what extent the object matches the legisign</para>
    /// labels<para>Examination</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Examination">http://www.molmod.info/semantics/pims-ii.ttl#Examination</seealso>
    let Examination = Prefixed_Name(pimsii, "Examination") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isLegisignIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isLegisignIn y) == y is an examination where x is applied to an object as a legisign, i.e., the first element, specifying patterns or rules the compliance with which is being assessed</para>
    /// labels<para>isLegisignIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isLegisignIn">http://www.molmod.info/semantics/pims-ii.ttl#isLegisignIn</seealso>
    let isLegisignIn = Prefixed_Name(pimsii, "isLegisignIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isExaminedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isExaminedIn y) == y is an examination where x acts as the examined object, i.e., the second element, for which it is assessed to what extent (in which way, under what additional conditions, etc.) it conforms with the legisign</para>
    /// labels<para>isExaminedIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isExaminedIn">http://www.molmod.info/semantics/pims-ii.ttl#isExaminedIn</seealso>
    let isExaminedIn = Prefixed_Name(pimsii, "isExaminedIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isExaminationOutcomeIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isExaminationOutcomeIn y) == y is an examination where x is the examination outcome, i.e., the third element (e.g., yes the object agrees with the legisign, or it does so under this or that condition, etc.)</para>
    /// labels<para>isExaminationOutcomeIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isExaminationOutcomeIn">http://www.molmod.info/semantics/pims-ii.ttl#isExaminationOutcomeIn</seealso>
    let isExaminationOutcomeIn =
        Prefixed_Name(pimsii, "isExaminationOutcomeIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation, i.e., a perception by which characteristic aspects of an object (e.g., a target property or some more complex kind of behaviour) are purposefully investigated through specific means of perception; the procedure and evaluation may occur based on subjective judgement or according to an agreed procedure</para>
    /// labels<para>Observation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Observation">http://www.molmod.info/semantics/pims-ii.ttl#Observation</seealso>
    let Observation = Prefixed_Name(pimsii, "Observation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:ExperimentalWorkflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>experimental workflow, i.e., a cognition that is purposefully conducted in a controlled environment and has at least one measurement as a step</para>
    /// labels<para>ExperimentalWorkflow</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ExperimentalWorkflow">http://www.molmod.info/semantics/pims-ii.ttl#ExperimentalWorkflow</seealso>
    let ExperimentalWorkflow =
        Prefixed_Name(pimsii, "ExperimentalWorkflow") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSelectionInputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSelectionInputIn y) == y is a selection where x is the input (initially given information), i.e., the first element; n.b., in a selection, the output needs to be constitutive of the input</para>
    /// labels<para>isSelectionInputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSelectionInputIn">http://www.molmod.info/semantics/pims-ii.ttl#isSelectionInputIn</seealso>
    let isSelectionInputIn = Prefixed_Name(pimsii, "isSelectionInputIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isObjectInSelection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObjectInSelection y) == y is a selection where x is the object that the input and the output both represent, i.e., the second element</para>
    /// labels<para>isObjectInSelection</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInSelection">http://www.molmod.info/semantics/pims-ii.ttl#isObjectInSelection</seealso>
    let isObjectInSelection =
        Prefixed_Name(pimsii, "isObjectInSelection") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSelectionOutputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSelectionOutputIn y) == y is a selection where x is the output (retained information), i.e., the third element; n.b., in a selection, the output needs to be constitutive of the input</para>
    /// labels<para>isSelectionOutputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSelectionOutputIn">http://www.molmod.info/semantics/pims-ii.ttl#isSelectionOutputIn</seealso>
    let isSelectionOutputIn =
        Prefixed_Name(pimsii, "isSelectionOutputIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isOldReferentIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isOldReferentIn y) == y is a semantic change where x acts as the old referent, i.e., the first element</para>
    /// labels<para>isOldReferentIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentIn">http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentIn</seealso>
    let isOldReferentIn = Prefixed_Name(pimsii, "isOldReferentIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isNewReferentIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isNewReferentIn y) == y is a semantic change where x acts as the new referent, i.e., the third element</para>
    /// labels<para>isNewReferentIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentIn">http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentIn</seealso>
    let isNewReferentIn = Prefixed_Name(pimsii, "isNewReferentIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isSignIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSignIn y) == y is a semiosis where x acts as the sign, i.e., the first element</para>
    /// labels<para>isSignIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSignIn">http://www.molmod.info/semantics/pims-ii.ttl#isSignIn</seealso>
    let isSignIn = Prefixed_Name(pimsii, "isSignIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isObjectIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObjectIn y) == y is a semiosis where x acts as the object, i.e., the second element</para>
    /// labels<para>isObjectIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectIn">http://www.molmod.info/semantics/pims-ii.ttl#isObjectIn</seealso>
    let isObjectIn = Prefixed_Name(pimsii, "isObjectIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isRepresentationalElementIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isRepresentationalElementIn y) == x acts as a representamen or referent in the cognitive step y</para>
    /// labels<para>isRepresentationalElementIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isRepresentationalElementIn">http://www.molmod.info/semantics/pims-ii.ttl#isRepresentationalElementIn</seealso>
    let isRepresentationalElementIn =
        Prefixed_Name(pimsii, "isRepresentationalElementIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Simulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Simulation, i.e., a purposefully conducted numerical interpretation of simulation input (model, etc.), where the interpretant is the simulation result</para>
    /// labels<para>Simulation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Simulation">http://www.molmod.info/semantics/pims-ii.ttl#Simulation</seealso>
    let Simulation = Prefixed_Name(pimsii, "Simulation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSimulationInputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSimulationInputIn y) == y is a simulation where x is the simulation input (model, etc.), i.e., the first element</para>
    /// labels<para>isSimulationInputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSimulationInputIn">http://www.molmod.info/semantics/pims-ii.ttl#isSimulationInputIn</seealso>
    let isSimulationInputIn =
        Prefixed_Name(pimsii, "isSimulationInputIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSimulatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSimulatedIn y) == y is a simulation where x acts as the simulated object (system, substance, process, or similar), i.e., the second element</para>
    /// labels<para>isSimulatedIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSimulatedIn">http://www.molmod.info/semantics/pims-ii.ttl#isSimulatedIn</seealso>
    let isSimulatedIn = Prefixed_Name(pimsii, "isSimulatedIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSimulationOutputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSimulationOutputIn y) == y is a simulation where x is the simulation output (computed property, higher-level model, or similar), i.e., the third element</para>
    /// labels<para>isSimulationOutputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSimulationOutputIn">http://www.molmod.info/semantics/pims-ii.ttl#isSimulationOutputIn</seealso>
    let isSimulationOutputIn =
        Prefixed_Name(pimsii, "isSimulationOutputIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:SimulationWorkflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>simulation workflow, i.e., a cognitive workflow in which simulation plays a major role</para>
    /// labels<para>SimulationWorkflow</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#SimulationWorkflow">http://www.molmod.info/semantics/pims-ii.ttl#SimulationWorkflow</seealso>
    let SimulationWorkflow = Prefixed_Name(pimsii, "SimulationWorkflow") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Steering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Steering, i.e., a reflection in actu (Reflexion im Vollzug following Baumann and Tulatz) or determination, carried out while undertaking an action and playing a role in that action by proper participation</para>
    /// labels<para>Steering</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Steering">http://www.molmod.info/semantics/pims-ii.ttl#Steering</seealso>
    let Steering = Prefixed_Name(pimsii, "Steering") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isTelosInSteering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isTelosInSteering y) == y is a steering operation (reflection in actu) where x acts as the telos (initial guiding objective), i.e., the first element</para>
    /// labels<para>isTelosInSteering</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInSteering">http://www.molmod.info/semantics/pims-ii.ttl#isTelosInSteering</seealso>
    let isTelosInSteering = Prefixed_Name(pimsii, "isTelosInSteering") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isMemberOfStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isMemberOfStructure y) means that x is a semiotic member of the structure y, and that it participates in semiosis differently from all of its co-members x', x'', ... of the structure y</para>
    /// labels<para>isMemberOfStructure</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isMemberOfStructure">http://www.molmod.info/semantics/pims-ii.ttl#isMemberOfStructure</seealso>
    let isMemberOfStructure =
        Prefixed_Name(pimsii, "isMemberOfStructure") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isOldReferentInSynecdoche</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isOldReferentInSynecdoche y) == y is a synecdoche where x acts as the old referent, i.e., the first element; the old and the new referent need to have a causal connection (n.b., the mereological relation in terms of proper parthood as such is insufficient)</para>
    /// labels<para>isOldReferentInSynecdoche</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInSynecdoche">http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInSynecdoche</seealso>
    let isOldReferentInSynecdoche =
        Prefixed_Name(pimsii, "isOldReferentInSynecdoche") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:changesReferentInSynecdoche</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x changesReferentInSynecdoche y) == y is a synecdoche where x acts as the representamen, i.e., the second element</para>
    /// labels<para>changesReferentInSynecdoche</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInSynecdoche">http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInSynecdoche</seealso>
    let changesReferentInSynecdoche =
        Prefixed_Name(pimsii, "changesReferentInSynecdoche") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isNewReferentInSynecdoche</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isNewReferentInSynecdoche y) == y is a synecdoche where x acts as the new referent, i.e., the third element; the old and the new referent need to have a causal connection (n.b., the mereological relation in terms of proper parthood as such is insufficient)</para>
    /// labels<para>isNewReferentInSynecdoche</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInSynecdoche">http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInSynecdoche</seealso>
    let isNewReferentInSynecdoche =
        Prefixed_Name(pimsii, "isNewReferentInSynecdoche") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:WholeToPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Whole-to-part synecdoche, i.e., a metonymization where the new referent is a spatiotemporal proper part of the old referent (additionally, the old and new referent need to be connected causally)</para>
    /// labels<para>WholeToPart</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#WholeToPart">http://www.molmod.info/semantics/pims-ii.ttl#WholeToPart</seealso>
    let WholeToPart = Prefixed_Name(pimsii, "WholeToPart") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isTelosIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isTelosIn y) == y is a telesis where x acts as the telos (initial guiding objective), i.e., the first element</para>
    /// labels<para>isTelosIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosIn">http://www.molmod.info/semantics/pims-ii.ttl#isTelosIn</seealso>
    let isTelosIn = Prefixed_Name(pimsii, "isTelosIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isObjectInTelesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObjectInTelesis y) == y is a telesis where x acts as the object (action, claim, or situation against which an objective is evaluated), i.e., the second element</para>
    /// labels<para>isObjectInTelesis</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInTelesis">http://www.molmod.info/semantics/pims-ii.ttl#isObjectInTelesis</seealso>
    let isObjectInTelesis = Prefixed_Name(pimsii, "isObjectInTelesis") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isAdmissibleValueFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isAdmissibleValueFor y) means that y is a term that could in principle evaluate to the value x; subsumption under msIPIRIR is explained as follows: There is a sign z for the term y (where z is the range of admissible values of y), for which in turn there is another sign z' (where z' lists members of z, explicitly including x) of which x is a part</para>
    /// labels<para>isAdmissibleValueFor</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isAdmissibleValueFor">http://www.molmod.info/semantics/pims-ii.ttl#isAdmissibleValueFor</seealso>
    let isAdmissibleValueFor =
        Prefixed_Name(pimsii, "isAdmissibleValueFor") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:TopicalProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Topical product, i.e., a topical proposition with multiple topical factors</para>
    /// labels<para>TopicalProduct</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#TopicalProduct">http://www.molmod.info/semantics/pims-ii.ttl#TopicalProduct</seealso>
    let TopicalProduct = Prefixed_Name(pimsii, "TopicalProduct") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:TopicalSum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Topical sum, i.e., a plurality of topical propositions, where the individual elements (summands) don't genuinely interact but are just standing beside each other as independent, unrelated (or not very closely related) parts of what is addressed</para>
    /// labels<para>TopicalSum</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#TopicalSum">http://www.molmod.info/semantics/pims-ii.ttl#TopicalSum</seealso>
    let TopicalSum = Prefixed_Name(pimsii, "TopicalSum") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isTopicalFactorIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isTopicalFactorIn y) means that x is combined with other subtopics into the topical proposition y, such that x and the other subtopics are not just standing beside each other, but exhibiting some meaningful interaction</para>
    /// labels<para>isTopicalFactorIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isTopicalFactorIn">http://www.molmod.info/semantics/pims-ii.ttl#isTopicalFactorIn</seealso>
    let isTopicalFactorIn = Prefixed_Name(pimsii, "isTopicalFactorIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isFirstElementIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isFirstElementIn y) means that x acts as the first element in y, which is a triadic cognition</para>
    /// labels<para>isFirstElementIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isFirstElementIn">http://www.molmod.info/semantics/pims-ii.ttl#isFirstElementIn</seealso>
    let isFirstElementIn = Prefixed_Name(pimsii, "isFirstElementIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isSecondElementIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSecondElementIn y) means that x acts as the second element in y, which is a triadic cognition</para>
    /// labels<para>isSecondElementIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSecondElementIn">http://www.molmod.info/semantics/pims-ii.ttl#isSecondElementIn</seealso>
    let isSecondElementIn = Prefixed_Name(pimsii, "isSecondElementIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isThirdElementIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isThirdElementIn y) means that x acts as the third element in y, which is a triadic cognition</para>
    /// labels<para>isThirdElementIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isThirdElementIn">http://www.molmod.info/semantics/pims-ii.ttl#isThirdElementIn</seealso>
    let isThirdElementIn = Prefixed_Name(pimsii, "isThirdElementIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Triple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Triple, i.e., a subject-predicate-object triple (connected by relations to the IRIs of the subject, predicate, and object)</para>
    /// labels<para>Triple</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Triple">http://www.molmod.info/semantics/pims-ii.ttl#Triple</seealso>
    let Triple = Prefixed_Name(pimsii, "Triple") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSubjectWithinTriple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSubjectWithinTriple y) means that y is a subject-predicate-object triple wherein x is the IRI of the subject</para>
    /// labels<para>isSubjectWithinTriple</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSubjectWithinTriple">http://www.molmod.info/semantics/pims-ii.ttl#isSubjectWithinTriple</seealso>
    let isSubjectWithinTriple =
        Prefixed_Name(pimsii, "isSubjectWithinTriple") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isPredicateWithinTriple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isPredicateWithinTriple y) means that y is a subject-predicate-object triple wherein x is the IRI of the predicate</para>
    /// labels<para>isPredicateWithinTriple</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isPredicateWithinTriple">http://www.molmod.info/semantics/pims-ii.ttl#isPredicateWithinTriple</seealso>
    let isPredicateWithinTriple =
        Prefixed_Name(pimsii, "isPredicateWithinTriple") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isObjectWithinTriple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObjectWithinTriple y) means that y is a subject-predicate-object triple wherein x is the IRI of the object</para>
    /// labels<para>isObjectWithinTriple</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectWithinTriple">http://www.molmod.info/semantics/pims-ii.ttl#isObjectWithinTriple</seealso>
    let isObjectWithinTriple =
        Prefixed_Name(pimsii, "isObjectWithinTriple") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isTelosInValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isTelosInValidation y) means that y is a validation where x acts as the telos (initial guiding objective), i.e., the first element</para>
    /// labels<para>Validation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInValidation">http://www.molmod.info/semantics/pims-ii.ttl#isTelosInValidation</seealso>
    let isTelosInValidation =
        Prefixed_Name(pimsii, "isTelosInValidation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isValidatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isValidatedIn y) means that y is a validation where x is the cognitive action undergoing validation, i.e., the second element</para>
    /// labels<para>isEvaluatedIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isValidatedIn">http://www.molmod.info/semantics/pims-ii.ttl#isValidatedIn</seealso>
    let isValidatedIn = Prefixed_Name(pimsii, "isValidatedIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isValidationOutcomeIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isValidationOutcomeIn y) means that x is the validity claim, i.e., the third element, obtained as an interpretant from the validation y</para>
    /// labels<para>isValidationOutcomeIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isValidationOutcomeIn">http://www.molmod.info/semantics/pims-ii.ttl#isValidationOutcomeIn</seealso>
    let isValidationOutcomeIn =
        Prefixed_Name(pimsii, "isValidationOutcomeIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Visualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Visualization, i.e., an interpretation in which the object is the visualized system and the interpretant is a visual representation of the object - the sign is a pre-existing representamen for the same object, e.g., a simulation result</para>
    /// labels<para>Visualization</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Visualization">http://www.molmod.info/semantics/pims-ii.ttl#Visualization</seealso>
    let Visualization = Prefixed_Name(pimsii, "Visualization") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isVisualizationInputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isVisualizationInputIn y) == y is a visualization process where x is the input (a pre-existing representamen for the visualized object, e.g., a simulation result), i.e., the first element</para>
    /// labels<para>isVisualizationInputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isVisualizationInputIn">http://www.molmod.info/semantics/pims-ii.ttl#isVisualizationInputIn</seealso>
    let isVisualizationInputIn =
        Prefixed_Name(pimsii, "isVisualizationInputIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isVisualizedObjectIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isVisualizedObjectIn y) == y is a visualization process wherein x is the visualized object, i.e., the second element</para>
    /// labels<para>isVisualizedObjectIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isVisualizedObjectIn">http://www.molmod.info/semantics/pims-ii.ttl#isVisualizedObjectIn</seealso>
    let isVisualizedObjectIn =
        Prefixed_Name(pimsii, "isVisualizedObjectIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isOldReferentInWholeToPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isOldReferentInWholeToPart y) == y is a whole-to-part synecdoche where x acts as the old referent (the whole), i.e., the first element</para>
    /// labels<para>isOldReferentInWholeToPart</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInWholeToPart">http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInWholeToPart</seealso>
    let isOldReferentInWholeToPart =
        Prefixed_Name(pimsii, "isOldReferentInWholeToPart") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:changesReferentInWholeToPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x changesReferentInWholeToPart y) == y is a whole-to-part synecdoche where x acts as the representamen, i.e., the second element</para>
    /// labels<para>changesReferentInWholeToPart</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInWholeToPart">http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInWholeToPart</seealso>
    let changesReferentInWholeToPart =
        Prefixed_Name(pimsii, "changesReferentInWholeToPart") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isNewReferentInWholeToPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isNewReferentInWholeToPart y) == y is a whole-to-part synecdoche where x acts as the new referent (the part), i.e., the third element</para>
    /// labels<para>isNewReferentInWholeToPart</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInWholeToPart">http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInWholeToPart</seealso>
    let isNewReferentInWholeToPart =
        Prefixed_Name(pimsii, "isNewReferentInWholeToPart") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:affirmsCognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x affirmsCognition y) means that x is about the cognition y, affirming its validity</para>
    /// labels<para>affirmsCognition</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#affirmsCognition">http://www.molmod.info/semantics/pims-ii.ttl#affirmsCognition</seealso>
    let affirmsCognition = Prefixed_Name(pimsii, "affirmsCognition") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:providesJustification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x providesJustification y) means that x is about some cognition z, providing a justification of it by referring to y, i.e., a grounding chain that establishes the epistemic status of z; thereby, x does not only affirm z, but also its grounding chain y</para>
    /// labels<para>providesJustification</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#providesJustification">http://www.molmod.info/semantics/pims-ii.ttl#providesJustification</seealso>
    let providesJustification =
        Prefixed_Name(pimsii, "providesJustification") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:articulatesNonliterally</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x articulatesNonliterally y) means that x is a collective non-literal expression (e.g., an utterance) of proposition y, and possibly additional propositions beside y</para>
    /// labels<para>articulatesNonliterally</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#articulatesNonliterally">http://www.molmod.info/semantics/pims-ii.ttl#articulatesNonliterally</seealso>
    let articulatesNonliterally =
        Prefixed_Name(pimsii, "articulatesNonliterally") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:describesMethodAppliedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x describesMethodAppliedIn y) means that x describes y in terms of the method that is employed</para>
    /// labels<para>describesMethodAppliedIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#describesMethodAppliedIn">http://www.molmod.info/semantics/pims-ii.ttl#describesMethodAppliedIn</seealso>
    let describesMethodAppliedIn =
        Prefixed_Name(pimsii, "describesMethodAppliedIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:describesMethodEmployedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x describesMethodEmployedBy y) means that the agent y follows a methodology described by x in carrying out an action</para>
    /// labels<para>describesMethodEmployedBy</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#describesMethodEmployedBy">http://www.molmod.info/semantics/pims-ii.ttl#describesMethodEmployedBy</seealso>
    let describesMethodEmployedBy =
        Prefixed_Name(pimsii, "describesMethodEmployedBy") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:msIRHPIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msIRHPIP Z) == isRepresentamenFor o hasProperPart o isProperPartOf == there is a Y such that (X isRepresentamenFor Y) and (Y overlapsWith Z)</para>
    /// labels<para>msIRHPIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIP">http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIP</seealso>
    let msIRHPIP = Prefixed_Name(pimsii, "msIRHPIP") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:directlyPrecedesCognitiveStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x directlyPrecedesCognitiveStep y) == x is the cognitive step (or basic ground) that directly precedes y logically; typically, this means that y takes over a dyadic representation relation from x</para>
    /// labels<para>directlyPrecedesCognitiveStep</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesCognitiveStep">http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesCognitiveStep</seealso>
    let directlyPrecedesCognitiveStep =
        Prefixed_Name(pimsii, "directlyPrecedesCognitiveStep") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:directlyPrecedesByRupture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x directlyPrecedesByRupture y) == x is the cognitive step that directly precedes y logically (and typically, y takes over a dyadic representation relation from x), but either x or y constitutes a cognitive rupture, i.e., it interrupts the chain of grounding</para>
    /// labels<para>directlyPrecedesByRupture</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesByRupture">http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesByRupture</seealso>
    let directlyPrecedesByRupture =
        Prefixed_Name(pimsii, "directlyPrecedesByRupture") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:directlyPrecedesStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x directlyPrecedesStep y) means that x and y are processes such that y can commence when x (and possibly other steps that also directly precede y) has finished</para>
    /// labels<para>directlyPrecedesStep</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesStep">http://www.molmod.info/semantics/pims-ii.ttl#directlyPrecedesStep</seealso>
    let directlyPrecedesStep =
        Prefixed_Name(pimsii, "directlyPrecedesStep") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:precedesStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>'precedesStep' is the transitive closure of 'directlyPrecedesStep'; (x precedesStep y) means that the processes x and y are, possibly indirectly, causally connected such that x needs to be concluded before y can commence</para>
    /// labels<para>precedesStep</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#precedesStep">http://www.molmod.info/semantics/pims-ii.ttl#precedesStep</seealso>
    let precedesStep = Prefixed_Name(pimsii, "precedesStep") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:hasDirectCausalConnectionWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Direct causal connection (in a broad sense)</para>
    /// labels<para>hasDirectCausalConnectionWith</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#hasDirectCausalConnectionWith">http://www.molmod.info/semantics/pims-ii.ttl#hasDirectCausalConnectionWith</seealso>
    let hasDirectCausalConnectionWith =
        Prefixed_Name(pimsii, "hasDirectCausalConnectionWith") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:doesNotOverlapWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x doesNotOverlapWith y) is the negation of (x overlapsWith y); i.e., the spatiotemporal intersection of x and y is empty</para>
    /// labels<para>doesNotOverlapWith</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#doesNotOverlapWith">http://www.molmod.info/semantics/pims-ii.ttl#doesNotOverlapWith</seealso>
    let doesNotOverlapWith = Prefixed_Name(pimsii, "doesNotOverlapWith") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isMereosemioticallyRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Top mereosemiotic relation: Direct or indirect connection through mereotopological and semiotic relations</para>
    /// labels<para>isMereosemioticallyRelatedTo</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isMereosemioticallyRelatedTo">http://www.molmod.info/semantics/pims-ii.ttl#isMereosemioticallyRelatedTo</seealso>
    let isMereosemioticallyRelatedTo =
        Prefixed_Name(pimsii, "isMereosemioticallyRelatedTo") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:doesNotTemporallyOverlapWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x doesNotTemporallyOverlapWith y) is the negation of (x temporallyOverlapsWith y); i.e., there is no temporal overlap between x and y</para>
    /// labels<para>doesNotTemporallyOverlapWith</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#doesNotTemporallyOverlapWith">http://www.molmod.info/semantics/pims-ii.ttl#doesNotTemporallyOverlapWith</seealso>
    let doesNotTemporallyOverlapWith =
        Prefixed_Name(pimsii, "doesNotTemporallyOverlapWith") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:hasAbsoluteNecessityMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x hasAbsoluteNecessityMode y) means that x is a relational IRI and y is an absolute modal IRI for 'necessarily x'</para>
    /// labels<para>hasAbsoluteNecessityMode</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#hasAbsoluteNecessityMode">http://www.molmod.info/semantics/pims-ii.ttl#hasAbsoluteNecessityMode</seealso>
    let hasAbsoluteNecessityMode =
        Prefixed_Name(pimsii, "hasAbsoluteNecessityMode") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:hasNecessityMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x hasNecessityMode y) means that x is a relational IRI and y is a modal IRI for 'necessarily x'</para>
    /// labels<para>hasNecessityMode</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#hasNecessityMode">http://www.molmod.info/semantics/pims-ii.ttl#hasNecessityMode</seealso>
    let hasNecessityMode = Prefixed_Name(pimsii, "hasNecessityMode") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:hasAbsolutePossibilityMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x hasAbsolutePossibilityMode y) means that x is a relational IRI and y is an absolute modal IRI for 'possibly x'</para>
    /// labels<para>hasAbsolutePossibilityMode</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#hasAbsolutePossibilityMode">http://www.molmod.info/semantics/pims-ii.ttl#hasAbsolutePossibilityMode</seealso>
    let hasAbsolutePossibilityMode =
        Prefixed_Name(pimsii, "hasAbsolutePossibilityMode") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:hasPossibilityMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x hasPossibilityMode y) means that x is a relational IRI and y is a modal IRI for 'possibly x'</para>
    /// labels<para>hasPossibilityMode</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#hasPossibilityMode">http://www.molmod.info/semantics/pims-ii.ttl#hasPossibilityMode</seealso>
    let hasPossibilityMode = Prefixed_Name(pimsii, "hasPossibilityMode") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:hasCausalConnectionWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>'Real causal connection' relation following Peirce, here, given by the transitive closure of 'hasDirectCausalConnectionWith'</para>
    /// labels<para>hasCausalConnectionWith</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#hasCausalConnectionWith">http://www.molmod.info/semantics/pims-ii.ttl#hasCausalConnectionWith</seealso>
    let hasCausalConnectionWith =
        Prefixed_Name(pimsii, "hasCausalConnectionWith") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Law</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Law, i.e., a proposition consisting of an antecedent and one or multiple consequent(s) such that the antecedent is stated to necessarily imply the consequent(s)</para>
    /// labels<para>Law</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Law">http://www.molmod.info/semantics/pims-ii.ttl#Law</seealso>
    let Law = Prefixed_Name(pimsii, "Law") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:AbsoluteModalIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Absolute modal IRI, i.e., the IRI of a relation that is defined by absolute necessity or possibility of another relation. Absolute necessity means 'logical or physical necessity', and absolute possibility means 'logical or physical possibility'. Accordingly, absolute modal relations do not require the specification of a modal context, i.e., the frame of reference for understanding what 'necessity' and 'possibility' mean does not need to be specified. </para>
    /// labels<para>AbsoluteModalIRI</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#AbsoluteModalIRI">http://www.molmod.info/semantics/pims-ii.ttl#AbsoluteModalIRI</seealso>
    let AbsoluteModalIRI = Prefixed_Name(pimsii, "AbsoluteModalIRI") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Object (PIMS-II top class) = cognizable entity</para>
    /// labels<para>Object</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Object">http://www.molmod.info/semantics/pims-ii.ttl#Object</seealso>
    let Object = Prefixed_Name(pimsii, "Object") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isObjectInAccumulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObjectInAccumulation y) == y is an accumulation where x is the object that the input and the output both represent, i.e., the second element</para>
    /// labels<para>isObjectInAccumulation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInAccumulation">http://www.molmod.info/semantics/pims-ii.ttl#isObjectInAccumulation</seealso>
    let isObjectInAccumulation =
        Prefixed_Name(pimsii, "isObjectInAccumulation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isAccumulationOutputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isAccumulationOutputIn y) == y is an accumulation where x is the output (combined information), i.e., the third element; n.b., in a selection, the input and any additionally included elements need to be constitutive of the output</para>
    /// labels<para>isAccumulationOutputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationOutputIn">http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationOutputIn</seealso>
    let isAccumulationOutputIn =
        Prefixed_Name(pimsii, "isAccumulationOutputIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isAgentIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isAgentIn y) means that x is *the* agent that conducts/undertakes the action y; n.b., an action has exactly one agent (which can be a straightforward item, or a plurality, a structure, or similar)</para>
    /// labels<para>isAgentIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isAgentIn">http://www.molmod.info/semantics/pims-ii.ttl#isAgentIn</seealso>
    let isAgentIn = Prefixed_Name(pimsii, "isAgentIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Process, i.e., a connected region that has at least one participant, an entity with which it overlaps spatiotemporally and that plays a certain role in the process</para>
    /// labels<para>Process</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Process">http://www.molmod.info/semantics/pims-ii.ttl#Process</seealso>
    let Process = Prefixed_Name(pimsii, "Process") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:SemioticCollective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Semiotic collective, i.e., a collective the semiotic members of which act together as one representational element (i.e., referent or representamen) in a cognitive process</para>
    /// labels<para>SemioticCollective</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#SemioticCollective">http://www.molmod.info/semantics/pims-ii.ttl#SemioticCollective</seealso>
    let SemioticCollective = Prefixed_Name(pimsii, "SemioticCollective") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Assessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Assessment (of a cognitive step), i.e., a ground that provides an explanation including a proposition on the extent (quantitatively or qualitatively) to which the grounded cognitive step is reliable/accurate/valid (or similar), why that is the case, and how that relates to the reliability/accuracy/etc. of the preceding step</para>
    /// labels<para>Assessment</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Assessment">http://www.molmod.info/semantics/pims-ii.ttl#Assessment</seealso>
    let Assessment = Prefixed_Name(pimsii, "Assessment") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isAssessmentFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(g isAssessmentFor y) means that g is a ground for the cognitive step y, explaining how y is grounded in a way that provides a proposition on its validity, accuracy, and/or reliability, relating it to that of the previous step that directly grounds y</para>
    /// labels<para>isAssessmentFor</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isAssessmentFor">http://www.molmod.info/semantics/pims-ii.ttl#isAssessmentFor</seealso>
    let isAssessmentFor = Prefixed_Name(pimsii, "isAssessmentFor") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Assignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Assignment, i.e., an equality articulation by which a value is assigned to a variable with respect to a particular referent (e.g., T = 200 K for substance o as it was measured in a particular cognitive step); therein, T is the variable, related to the assignment by [inverseOf isVariableInAssignment], 200 K is the value, related to the assignment by [inverseOf isValueInAssignment], and o is the referent, related to the assignment by isAssignmentFor</para>
    /// labels<para>Assignment</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Assignment">http://www.molmod.info/semantics/pims-ii.ttl#Assignment</seealso>
    let Assignment = Prefixed_Name(pimsii, "Assignment") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:BasicGround</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Basic ground, i.e., a ground that is assumed to be valid and reliable a priori; a cognitive step for which there is a basic ground is a presupposition</para>
    /// labels<para>BasicGround</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#BasicGround">http://www.molmod.info/semantics/pims-ii.ttl#BasicGround</seealso>
    let BasicGround = Prefixed_Name(pimsii, "BasicGround") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Presupposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Presupposition, i.e., a cognition that has a basic ground, so that it is accepted a priori as an ultimate anchor point for epistemic grounding; any cognition that is logically preceded by a presupposition is a grounded cognition</para>
    /// labels<para>Presupposition</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Presupposition">http://www.molmod.info/semantics/pims-ii.ttl#Presupposition</seealso>
    let Presupposition = Prefixed_Name(pimsii, "Presupposition") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:CanonicalTUCAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Canonical TUCAN, i.e., the material identifier as developed within the NFDI4Chem project</para>
    /// labels<para>CanonicalTUCAN</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#CanonicalTUCAN">http://www.molmod.info/semantics/pims-ii.ttl#CanonicalTUCAN</seealso>
    let CanonicalTUCAN = Prefixed_Name(pimsii, "CanonicalTUCAN") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:ReproducibilityClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reproducibility claim (RC), i.e., a validity claim obtained as an outcome of a reproduction attempt/reproducibility study</para>
    /// labels<para>ReproducibilityClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ReproducibilityClaim">http://www.molmod.info/semantics/pims-ii.ttl#ReproducibilityClaim</seealso>
    let ReproducibilityClaim =
        Prefixed_Name(pimsii, "ReproducibilityClaim") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isOrthodataWithin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isOrthodataWithin y) means that x articulates a substantial aspect of either the antecedent or the consequent side of the rule y</para>
    /// labels<para>isOrthodataWithin</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isOrthodataWithin">http://www.molmod.info/semantics/pims-ii.ttl#isOrthodataWithin</seealso>
    let isOrthodataWithin = Prefixed_Name(pimsii, "isOrthodataWithin") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Selection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Selection, i.e., an information-processing step in which the given information is narrowed down such that the output (interpretant) is constitutive of the input (sign); this includes conditional selection, where one component of the input or another is retained depending on a selection condition (cf. relation isSelectionConditionIn)</para>
    /// labels<para>Selection</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Selection">http://www.molmod.info/semantics/pims-ii.ttl#Selection</seealso>
    let Selection = Prefixed_Name(pimsii, "Selection") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isParticipantInCognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isParticipantInCognition y) means that y is a cognition in which x is necessarily physically present and plays one of the roles characteristic for participation in a cognitive process as formalized by this ontology; this includes participation as a representamen, as a perceived object, as a step of a cognitive chain, or as an interpreter</para>
    /// labels<para>isParticipantInCognition</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isParticipantInCognition">http://www.molmod.info/semantics/pims-ii.ttl#isParticipantInCognition</seealso>
    let isParticipantInCognition =
        Prefixed_Name(pimsii, "isParticipantInCognition") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isFusionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>x isFusionOf (y1 y2 ... yn) means that x is the spatiotemporal union (i.e., fusion) of all the elements included in the list (y1 y2 ... yn)</para>
    /// labels<para>isFusionOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isFusionOf">http://www.molmod.info/semantics/pims-ii.ttl#isFusionOf</seealso>
    let isFusionOf = Prefixed_Name(pimsii, "isFusionOf") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIRHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation hasProperPart o sharesReferentWith</para>
    /// labels<para>msHPIRHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHR">http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHR</seealso>
    let msHPIRHR = Prefixed_Name(pimsii, "msHPIRHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRHRIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation sharesReferentWith o isProperPartOf</para>
    /// labels<para>msIRHRIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRIP">http://www.molmod.info/semantics/pims-ii.ttl#msIRHRIP</seealso>
    let msIRHRIP = Prefixed_Name(pimsii, "msIRHRIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:underlies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the relation 'underlies' is the transitive closure of the relation 'isConstitutiveOf'</para>
    /// labels<para>underlies</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#underlies">http://www.molmod.info/semantics/pims-ii.ttl#underlies</seealso>
    let underlies = Prefixed_Name(pimsii, "underlies") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msHRIP Z) == hasRepresentamen o isProperPartOf == there is a Y such that (Y isRepresentamenFor X) and (Y isProperPartOf Z)</para>
    /// labels<para>msHRIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIP">http://www.molmod.info/semantics/pims-ii.ttl#msHRIP</seealso>
    let msHRIP = Prefixed_Name(pimsii, "msHRIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIPIRHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation overlapsWith o msIRHP</para>
    /// labels<para>msHPIPIRHP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRHP">http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRHP</seealso>
    let msHPIPIRHP = Prefixed_Name(pimsii, "msHPIPIRHP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:ModalIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Modal IRI, i.e., the IRI of a relation that is defined by (absolute or qualified) necessity or possibility of another relation</para>
    /// labels<para>ModalIRI</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ModalIRI">http://www.molmod.info/semantics/pims-ii.ttl#ModalIRI</seealso>
    let ModalIRI = Prefixed_Name(pimsii, "ModalIRI") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:OwnClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Own claim, i.e., a claim that is asserted by a self reference (i.e., a/the present interlocutor)</para>
    /// labels<para>OwnClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#OwnClaim">http://www.molmod.info/semantics/pims-ii.ttl#OwnClaim</seealso>
    let OwnClaim = Prefixed_Name(pimsii, "OwnClaim") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:AbstractModelPropertyClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract model property claim (CMPC), i.e., a model property claim that is not immediately applied to the corresponding property of a real physical system</para>
    /// labels<para>AbstractModelPropertyClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#AbstractModelPropertyClaim">http://www.molmod.info/semantics/pims-ii.ttl#AbstractModelPropertyClaim</seealso>
    let AbstractModelPropertyClaim =
        Prefixed_Name(pimsii, "AbstractModelPropertyClaim") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isObjectOfInvestigationIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObjectOfInvestigationIn y) == y is an investigation-setup action where x acts as the object of investigation (e.g., the item subject to an experiment or a simulated process or system), i.e., as the third element; n.b., there needs to be a causal connection between the object of application and the object of investigation</para>
    /// labels<para>isObjectOfInvestigationIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectOfInvestigationIn">http://www.molmod.info/semantics/pims-ii.ttl#isObjectOfInvestigationIn</seealso>
    let isObjectOfInvestigationIn =
        Prefixed_Name(pimsii, "isObjectOfInvestigationIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isMereologicallyConstitutiveOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isMereologicallyConstitutiveOf y) means that x is constitutive of y by virtue of the way in which it is a proper part of y in 4D spacetime, e.g., as a necessary component of an item that was designed for a certain purpose</para>
    /// labels<para>isMereologicallyConstitutiveOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isMereologicallyConstitutiveOf">http://www.molmod.info/semantics/pims-ii.ttl#isMereologicallyConstitutiveOf</seealso>
    let isMereologicallyConstitutiveOf =
        Prefixed_Name(pimsii, "isMereologicallyConstitutiveOf") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Question</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Question, i.e., a topical proposition the semantics/pragmatics of which are of interrogative character</para>
    /// labels<para>Question</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Question">http://www.molmod.info/semantics/pims-ii.ttl#Question</seealso>
    let Question = Prefixed_Name(pimsii, "Question") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rule, i.e., a proposition consisting of an antecedent and one or multiple consequent(s) such that the antecedent is stated to imply the consequent(s)</para>
    /// labels<para>Rule</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Rule">http://www.molmod.info/semantics/pims-ii.ttl#Rule</seealso>
    let Rule = Prefixed_Name(pimsii, "Rule") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:QualifiedLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualified law, i.e., a law where the necessary entailment of the consequent(s) by the antecedent is expressed in terms of qualified necessity, to be understood in terms of its modal context</para>
    /// labels<para>QualifiedLaw</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#QualifiedLaw">http://www.molmod.info/semantics/pims-ii.ttl#QualifiedLaw</seealso>
    let QualifiedLaw = Prefixed_Name(pimsii, "QualifiedLaw") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Lexeme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lexeme, i.e., a semiotic collective the members of which are all instances/utterances/copies of the same word (or a fragment or group of words that fulfills the corresponding function) which acts as a conventional articulation due to social convention; different ways of writing the word, such as an abbreviation and the full version, may belong to the same lexeme</para>
    /// labels<para>Lexeme</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Lexeme">http://www.molmod.info/semantics/pims-ii.ttl#Lexeme</seealso>
    let Lexeme = Prefixed_Name(pimsii, "Lexeme") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isMeasurementInputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isMeasurementInputIn y) == y is a measurement where x serves as the input (sign), i.e., the first element, constituting the precondition in terms of available information and similar items</para>
    /// labels<para>isMeasurementInputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isMeasurementInputIn">http://www.molmod.info/semantics/pims-ii.ttl#isMeasurementInputIn</seealso>
    let isMeasurementInputIn =
        Prefixed_Name(pimsii, "isMeasurementInputIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isListenerIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isListenerIn y) means that x is one of the interlocutors listening to the speaker's expressive act y</para>
    /// labels<para>isListenerIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isListenerIn">http://www.molmod.info/semantics/pims-ii.ttl#isListenerIn</seealso>
    let isListenerIn = Prefixed_Name(pimsii, "isListenerIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isMinimizationObjectiveIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isMaximizationObjectiveIn y) == x is a maximization objective/criterion considered in the optimization problem y</para>
    /// labels<para>isMaximizationObjectiveIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isMinimizationObjectiveIn">http://www.molmod.info/semantics/pims-ii.ttl#isMinimizationObjectiveIn</seealso>
    let isMinimizationObjectiveIn =
        Prefixed_Name(pimsii, "isMinimizationObjectiveIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isParadataWithin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isParadataWithin y) means that x articulates something explicitly said to be unsubstantial to the rule y, and thereby semiotically constitutive of it, e.g., by a mechanism of logical subtraction</para>
    /// labels<para>isParadataWithin</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isParadataWithin">http://www.molmod.info/semantics/pims-ii.ttl#isParadataWithin</seealso>
    let isParadataWithin = Prefixed_Name(pimsii, "isParadataWithin") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isTemporallyIncludedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isTemporallyIncludedIn y) means that the temporal extension of x is a proper part of the temporal extension of y</para>
    /// labels<para>isTemporallyIncludedIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isTemporallyIncludedIn">http://www.molmod.info/semantics/pims-ii.ttl#isTemporallyIncludedIn</seealso>
    let isTemporallyIncludedIn =
        Prefixed_Name(pimsii, "isTemporallyIncludedIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isReferenceFrameFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(s isReferenceFrameFor s') means that s is a representamen that provides relevant context, such as presuppositions or preconditions, to the representamen s'</para>
    /// labels<para>isReferenceFrameFor</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isReferenceFrameFor">http://www.molmod.info/semantics/pims-ii.ttl#isReferenceFrameFor</seealso>
    let isReferenceFrameFor =
        Prefixed_Name(pimsii, "isReferenceFrameFor") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:sharesReferentWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>(X sharesReferentWith Z) == there is a Y such that both X and Z isRepresentamenFor Y</para>
    /// labels<para>sharesReferentWith</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#sharesReferentWith">http://www.molmod.info/semantics/pims-ii.ttl#sharesReferentWith</seealso>
    let sharesReferentWith = Prefixed_Name(pimsii, "sharesReferentWith") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRHRIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation sharesReferentWith o isRepresentamenFor</para>
    /// labels<para>msHRIRHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRIR">http://www.molmod.info/semantics/pims-ii.ttl#msIRHRIR</seealso>
    let msIRHRIR = Prefixed_Name(pimsii, "msIRHRIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isResultOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isResultOf y) if x is an outcome/result of the cognitive process y</para>
    /// labels<para>isResultOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isResultOf">http://www.molmod.info/semantics/pims-ii.ttl#isResultOf</seealso>
    let isResultOf = Prefixed_Name(pimsii, "isResultOf") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSelectionConditionIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSelectionConditionIn y) == in the selection process y, the condition x controls what constitutive element(s) of the input are retained as part of the output</para>
    /// labels<para>isSelectionConditionIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSelectionConditionIn">http://www.molmod.info/semantics/pims-ii.ttl#isSelectionConditionIn</seealso>
    let isSelectionConditionIn =
        Prefixed_Name(pimsii, "isSelectionConditionIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSpatiotemporallyConnectedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>(x isSpatiotemporallyConnectedWith y) means that x and y overlap or are directly adjacent to each other at some point; i.e., there is a point p_x in x and a point p_y in y such that you can go from p_x to p_y without ever leaving the fusion (x U y)</para>
    /// labels<para>isSpatiotemporallyConnectedWith</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSpatiotemporallyConnectedWith">http://www.molmod.info/semantics/pims-ii.ttl#isSpatiotemporallyConnectedWith</seealso>
    let isSpatiotemporallyConnectedWith =
        Prefixed_Name(pimsii, "isSpatiotemporallyConnectedWith") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isTemporallyConnectedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isTemporallyConnectedWith y) means that there is a point in time where both x and y exist</para>
    /// labels<para>isTemporallyConnectedWith</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isTemporallyConnectedWith">http://www.molmod.info/semantics/pims-ii.ttl#isTemporallyConnectedWith</seealso>
    let isTemporallyConnectedWith =
        Prefixed_Name(pimsii, "isTemporallyConnectedWith") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isTerminalStepIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isTerminalStepIn y) means that y is a step in x (i.e., a subprocess of x) that does not precede any other step</para>
    /// labels<para>isTerminalStepIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isTerminalStepIn">http://www.molmod.info/semantics/pims-ii.ttl#isTerminalStepIn</seealso>
    let isTerminalStepIn = Prefixed_Name(pimsii, "isTerminalStepIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isTargetPropertyIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isTargetPropertyIn y) means that cognitive action x targets y as the property for which a value is to be determined by observation or by theoretical or computational methods</para>
    /// labels<para>isTargetPropertyIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isTargetPropertyIn">http://www.molmod.info/semantics/pims-ii.ttl#isTargetPropertyIn</seealso>
    let isTargetPropertyIn = Prefixed_Name(pimsii, "isTargetPropertyIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:temporallyCoextendsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>(x temporallyCoextendsWith y) means that x and y have exactly the same extension in time, i.e., disregarding their spatial extension</para>
    /// labels<para>temporallyCoextendsWith</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#temporallyCoextendsWith">http://www.molmod.info/semantics/pims-ii.ttl#temporallyCoextendsWith</seealso>
    let temporallyCoextendsWith =
        Prefixed_Name(pimsii, "temporallyCoextendsWith") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:temporallyOverlapsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x temporallyOverlapsWith y) means that there is an (extended) interval in time where both x and y exist</para>
    /// labels<para>temporallyOverlapsWith</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#temporallyOverlapsWith">http://www.molmod.info/semantics/pims-ii.ttl#temporallyOverlapsWith</seealso>
    let temporallyOverlapsWith =
        Prefixed_Name(pimsii, "temporallyOverlapsWith") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isToolIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isToolIn y) means that x is employed by an agent during the action y</para>
    /// labels<para>isToolIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isToolIn">http://www.molmod.info/semantics/pims-ii.ttl#isToolIn</seealso>
    let isToolIn = Prefixed_Name(pimsii, "isToolIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msHPHR Z) == hasProperPart o hasRepresentamen == there is a Y such that (Y isProperPartOf X) and (Z isRepresentamenFor Y)</para>
    /// labels<para>msHPHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHR">http://www.molmod.info/semantics/pims-ii.ttl#msHPHR</seealso>
    let msHPHR = Prefixed_Name(pimsii, "msHPHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPHRHPIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHPHR o overlapsWith</para>
    /// labels<para>msHPHRHPIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHPIP">http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHPIP</seealso>
    let msHPHRHPIP = Prefixed_Name(pimsii, "msHPHRHPIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msIRIP Z) == isRepresentamenFor o isProperPartOf == there is a Y such that (X isRepresentamenFor Y) and (Y isProperPartOf Z)</para>
    /// labels<para>msIRIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIP">http://www.molmod.info/semantics/pims-ii.ttl#msIRIP</seealso>
    let msIRIP = Prefixed_Name(pimsii, "msIRIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPHRHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHPHR o hasProperPart</para>
    /// labels<para>msHPHRHP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHP">http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHP</seealso>
    let msHPHRHP = Prefixed_Name(pimsii, "msHPHRHP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIPHRHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation overlapsWith o msHRHP</para>
    /// labels<para>msHPIPHRHP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRHP">http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRHP</seealso>
    let msHPIPHRHP = Prefixed_Name(pimsii, "msHPIPHRHP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIPIRIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIPIR o isProperPartOf</para>
    /// labels<para>msIPIRIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRIP">http://www.molmod.info/semantics/pims-ii.ttl#msIPIRIP</seealso>
    let msIPIRIP = Prefixed_Name(pimsii, "msIPIRIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIPIRIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation overlapsWith o msIRIP</para>
    /// labels<para>msHPIPIRIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRIP">http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRIP</seealso>
    let msHPIPIRIP = Prefixed_Name(pimsii, "msHPIPIRIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIPHRIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation overlapsWith o msHRIP</para>
    /// labels<para>msHPIPHRIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRIP">http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRIP</seealso>
    let msHPIPHRIP = Prefixed_Name(pimsii, "msHPIPHRIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIRIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHPIR o isProperPartOf</para>
    /// labels<para>msHPIRIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRIP">http://www.molmod.info/semantics/pims-ii.ttl#msHPIRIP</seealso>
    let msHPIRIP = Prefixed_Name(pimsii, "msHPIRIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPHRIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation hasProperPart o sharesRepresentamenWith</para>
    /// labels<para>msHPHRIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRIR">http://www.molmod.info/semantics/pims-ii.ttl#msHPHRIR</seealso>
    let msHPHRIR = Prefixed_Name(pimsii, "msHPHRIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIPHRIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation overlapsWith o sharesRepresentamenWith</para>
    /// labels<para>msHPIPHRIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRIR">http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRIR</seealso>
    let msHPIPHRIR = Prefixed_Name(pimsii, "msHPIPHRIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRIRIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation sharesRepresentamenWith o isProperPartOf</para>
    /// labels<para>msHRIRIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRIP">http://www.molmod.info/semantics/pims-ii.ttl#msHRIRIP</seealso>
    let msHRIRIP = Prefixed_Name(pimsii, "msHRIRIP") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:sharesRepresentamenWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X sharesRepresentamenWith Z) == there is a Y such that Y isRepresentamenFor both X and Z</para>
    /// labels<para>sharesRepresentamenWith</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#sharesRepresentamenWith">http://www.molmod.info/semantics/pims-ii.ttl#sharesRepresentamenWith</seealso>
    let sharesRepresentamenWith =
        Prefixed_Name(pimsii, "sharesRepresentamenWith") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:msIPIRHPIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIPIR o overlapsWith</para>
    /// labels<para>msIPIRHPIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHPIP">http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHPIP</seealso>
    let msIPIRHPIP = Prefixed_Name(pimsii, "msIPIRHPIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msHRHP Z) == hasRepresentamen o hasProperPart == there is a Y such that (Y isRepresentamenFor X) and (Z isProperPartOf Y)</para>
    /// labels<para>msHRHP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHP">http://www.molmod.info/semantics/pims-ii.ttl#msHRHP</seealso>
    let msHRHP = Prefixed_Name(pimsii, "msHRHP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRIRHPIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIRIR o overlapsWith</para>
    /// labels<para>msIRIRHPIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHPIP">http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHPIP</seealso>
    let msIRIRHPIP = Prefixed_Name(pimsii, "msIRIRHPIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msHRHR Z) == (hasRepresentamen)^2 == there is a Y such that (Y isRepresentamenFor X) and (Z isRepresentamenFor Y)</para>
    /// labels<para>msHRHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHR">http://www.molmod.info/semantics/pims-ii.ttl#msHRHR</seealso>
    let msHRHR = Prefixed_Name(pimsii, "msHRHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIPHRHPIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIPHR o overlapsWith</para>
    /// labels<para>msIPHRHPIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHPIP">http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHPIP</seealso>
    let msIPHRHPIP = Prefixed_Name(pimsii, "msIPHRHPIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msIRHP Z) == isRepresentamenFor o hasProperPart == there is a Y such that (X isRepresentamenFor Y) and (Z isProperPartOf Y)</para>
    /// labels<para>msIRHP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHP">http://www.molmod.info/semantics/pims-ii.ttl#msIRHP</seealso>
    let msIRHP = Prefixed_Name(pimsii, "msIRHP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIPIRHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation overlapsWith o sharesReferentWith</para>
    /// labels<para>msHPIPIRHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRHR">http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRHR</seealso>
    let msHPIPIRHR = Prefixed_Name(pimsii, "msHPIPIRHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRHRHPIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation sharesReferentWith o overlapsWith</para>
    /// labels<para>msIRHRHPIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHPIP">http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHPIP</seealso>
    let msIRHRHPIP = Prefixed_Name(pimsii, "msIRHRHPIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIPIRIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation overlapsWith o msIRIR</para>
    /// labels<para>msHPIPIRIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRIR">http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIRIR</seealso>
    let msHPIPIRIR = Prefixed_Name(pimsii, "msHPIPIRIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRHRHPIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHRHR o overlapsWith</para>
    /// labels<para>msHRHRHPIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHPIP">http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHPIP</seealso>
    let msHRHRHPIP = Prefixed_Name(pimsii, "msHRHRHPIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msIRIR Z) == (isRepresentamenFor)^2 == there is a Y such that (X isRepresentamenFor Y) and (Y isRepresentamenFor Z)</para>
    /// labels<para>msIRIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIR">http://www.molmod.info/semantics/pims-ii.ttl#msIRIR</seealso>
    let msIRIR = Prefixed_Name(pimsii, "msIRIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msHPIR Z) == hasProperPart o isRepresentamenFor == there is a Y such that (Y isProperPartOf X) and (Y is RepresentamenFor Z)</para>
    /// labels<para>msHPIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIR">http://www.molmod.info/semantics/pims-ii.ttl#msHPIR</seealso>
    let msHPIR = Prefixed_Name(pimsii, "msHPIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIRHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHPIR o hasProperPart</para>
    /// labels<para>msIPIRHP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHP">http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHP</seealso>
    let msHPIRHP = Prefixed_Name(pimsii, "msHPIRHP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIPHRIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIPHR o isProperPartOf</para>
    /// labels<para>msIPHRIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRIP">http://www.molmod.info/semantics/pims-ii.ttl#msIPHRIP</seealso>
    let msIPHRIP = Prefixed_Name(pimsii, "msIPHRIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRHRIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHRHR o isProperPartOf</para>
    /// labels<para>msHRHRIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRIP">http://www.molmod.info/semantics/pims-ii.ttl#msHRHRIP</seealso>
    let msHRHRIP = Prefixed_Name(pimsii, "msHRHRIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIPIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msIP Z) == isProperPartOf o isRepresentamenFor == there is a Y such that (X isProperPartOf Y) and (Y isRepresentamenFor Z)</para>
    /// labels<para>msIPIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIR">http://www.molmod.info/semantics/pims-ii.ttl#msIPIR</seealso>
    let msIPIR = Prefixed_Name(pimsii, "msIPIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRHPHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHRHP o hasRepresentamen</para>
    /// labels<para>msHRHPHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPHR">http://www.molmod.info/semantics/pims-ii.ttl#msHRHPHR</seealso>
    let msHRHPHR = Prefixed_Name(pimsii, "msHRHPHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRHPIPHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHRHP o msIPHR</para>
    /// labels<para>msHRHPIPHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIPHR">http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIPHR</seealso>
    let msHRHPIPHR = Prefixed_Name(pimsii, "msHRHPIPHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRIPIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIRIP o isRepresentamenFor</para>
    /// labels<para>msIRIPIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIPIR">http://www.molmod.info/semantics/pims-ii.ttl#msIRIPIR</seealso>
    let msIRIPIR = Prefixed_Name(pimsii, "msIRIPIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRHPIPIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIRHP o msIPIR</para>
    /// labels<para>msIRHPIPIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIPIR">http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIPIR</seealso>
    let msIRHPIPIR = Prefixed_Name(pimsii, "msIRHPIPIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIPHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msIPHR Z) == isProperPartOf o hasRepresentamen == there is a Y such that (X isProperPartOf Y) and (Z isRepresentamenFor Y)</para>
    /// labels<para>msIPHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHR">http://www.molmod.info/semantics/pims-ii.ttl#msIPHR</seealso>
    let msIPHR = Prefixed_Name(pimsii, "msIPHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRHPIPIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>chain relation msHRHP o msIPIR</para>
    /// labels<para>msHRHPIPIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIPIR">http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIPIR</seealso>
    let msHRHPIPIR = Prefixed_Name(pimsii, "msHRHPIPIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRHPIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHRHP o isRepresentamenFor</para>
    /// labels<para>msHRHPIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIR">http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIR</seealso>
    let msHRHPIR = Prefixed_Name(pimsii, "msHRHPIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRIPIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHRIP o isRepresentamenFor</para>
    /// labels<para>msHRIPIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIPIR">http://www.molmod.info/semantics/pims-ii.ttl#msHRIPIR</seealso>
    let msHRIPIR = Prefixed_Name(pimsii, "msHRIPIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRHRHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHRHR o hasProperPart</para>
    /// labels<para>msHRHRHP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHP">http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHP</seealso>
    let msHRHRHP = Prefixed_Name(pimsii, "msHRHRHP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRHRHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHRHR o hasRepresentamen</para>
    /// labels<para>msHRHRHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHR">http://www.molmod.info/semantics/pims-ii.ttl#msHRHRHR</seealso>
    let msHRHRHR = Prefixed_Name(pimsii, "msHRHRHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRIRIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIRIR o isRepresentamenFor</para>
    /// labels<para>msIRIRIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRIR">http://www.molmod.info/semantics/pims-ii.ttl#msIRIRIR</seealso>
    let msIRIRIR = Prefixed_Name(pimsii, "msIRIRIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRIRIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation sharesRepresentamenWith o isRepresentamenFor</para>
    /// labels<para>msHRIRIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRIR">http://www.molmod.info/semantics/pims-ii.ttl#msHRIRIR</seealso>
    let msHRIRIR = Prefixed_Name(pimsii, "msHRIRIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRIPHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHRIP o hasRepresentamen</para>
    /// labels<para>msHRIPHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIPHR">http://www.molmod.info/semantics/pims-ii.ttl#msHRIPHR</seealso>
    let msHRIPHR = Prefixed_Name(pimsii, "msHRIPHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRHPIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIRHP o isRepresentamenFor</para>
    /// labels<para>msIRHPIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIR">http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIR</seealso>
    let msIRHPIR = Prefixed_Name(pimsii, "msIRHPIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRIRHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation sharesRepresentamenWith o hasProperPart</para>
    /// labels<para>msHRIRHP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHP">http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHP</seealso>
    let msHRIRHP = Prefixed_Name(pimsii, "msHRIRHP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIPHRIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation isProperPartOf o sharesRepresentamenWith</para>
    /// labels<para>msIPHRIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRIR">http://www.molmod.info/semantics/pims-ii.ttl#msIPHRIR</seealso>
    let msIPHRIR = Prefixed_Name(pimsii, "msIPHRIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIPHRHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIPHR o hasProperPart</para>
    /// labels<para>msIPHRHP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHP">http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHP</seealso>
    let msIPHRHP = Prefixed_Name(pimsii, "msIPHRHP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIPIRHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIPIR o hasProperPart</para>
    /// labels<para>msIPIRHP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHP">http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHP</seealso>
    let msIPIRHP = Prefixed_Name(pimsii, "msIPIRHP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIPHRHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIPHR o hasRepresentamen</para>
    /// labels<para>msIPHRHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHR">http://www.molmod.info/semantics/pims-ii.ttl#msIPHRHR</seealso>
    let msIPHRHR = Prefixed_Name(pimsii, "msIPHRHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRIRHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIRIR o hasProperPart</para>
    /// labels<para>msIRIRHP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHP">http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHP</seealso>
    let msIRIRHP = Prefixed_Name(pimsii, "msIRIRHP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIPIRHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation isProperPartOf o sharesReferentWith</para>
    /// labels<para>msIPIRHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHR">http://www.molmod.info/semantics/pims-ii.ttl#msIPIRHR</seealso>
    let msIPIRHR = Prefixed_Name(pimsii, "msIPIRHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRHRHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation sharesReferentWith o hasProperPart</para>
    /// labels<para>msIRHRHP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHP">http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHP</seealso>
    let msIRHRHP = Prefixed_Name(pimsii, "msIRHRHP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRHPHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIRHP o hasRepresentamen</para>
    /// labels<para>msIRHPHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPHR">http://www.molmod.info/semantics/pims-ii.ttl#msIRHPHR</seealso>
    let msIRHPHR = Prefixed_Name(pimsii, "msIRHPHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRHPIPHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIRHP o msIPHR</para>
    /// labels<para>msIRHPIPHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIPHR">http://www.molmod.info/semantics/pims-ii.ttl#msIRHPIPHR</seealso>
    let msIRHPIPHR = Prefixed_Name(pimsii, "msIRHPIPHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRIPHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIRIP o hasRepresentamen</para>
    /// labels<para>msIRIPHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIPHR">http://www.molmod.info/semantics/pims-ii.ttl#msIRIPHR</seealso>
    let msIRIPHR = Prefixed_Name(pimsii, "msIRIPHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRHRHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation sharesReferentWith o hasRepresentamen</para>
    /// labels<para>msIRHRHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHR">http://www.molmod.info/semantics/pims-ii.ttl#msIRHRHR</seealso>
    let msIRHRHR = Prefixed_Name(pimsii, "msIRHRHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRIRHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation isRepresentamenFor o sharesReferentWith</para>
    /// labels<para>msIRIRHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHR">http://www.molmod.info/semantics/pims-ii.ttl#msIRIRHR</seealso>
    let msIRIRHR = Prefixed_Name(pimsii, "msIRIRHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:ModelPropertyClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Model property claim (MPC), i.e., a PC concerning a property of a model</para>
    /// labels<para>PropertyClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ModelPropertyClaim">http://www.molmod.info/semantics/pims-ii.ttl#ModelPropertyClaim</seealso>
    let ModelPropertyClaim = Prefixed_Name(pimsii, "ModelPropertyClaim") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isIncludedInAccumulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isIncludedInAccumulation y) == y is an accumulation where x is combined with the accumulation input, yielding an output that x is constitutive of; n.b., x needs to act as a representamen for the object (e.g., as an interpretant from a preceding cognitive step with the same object)</para>
    /// labels<para>isIncludedInAccumulation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isIncludedInAccumulation">http://www.molmod.info/semantics/pims-ii.ttl#isIncludedInAccumulation</seealso>
    let isIncludedInAccumulation =
        Prefixed_Name(pimsii, "isIncludedInAccumulation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Agent, i.e., an object that interacts with its surroundings by a) perceiving and b) doing, i.e., an object that carries out actions, including perceptive actions</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Agent">http://www.molmod.info/semantics/pims-ii.ttl#Agent</seealso>
    let Agent = Prefixed_Name(pimsii, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:EPTRC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>EPTRC, i.e., an exact-agreement provenance-conscious team-change reproducibility claim</para>
    /// labels<para>EPTRC</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#EPTRC">http://www.molmod.info/semantics/pims-ii.ttl#EPTRC</seealso>
    let EPTRC = Prefixed_Name(pimsii, "EPTRC") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:ETRC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ETRC, i.e., an exact-agreement team-change reproducibility claim</para>
    /// labels<para>ETRC</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ETRC">http://www.molmod.info/semantics/pims-ii.ttl#ETRC</seealso>
    let ETRC = Prefixed_Name(pimsii, "ETRC") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:PTRC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>PTRC, i.e., a provenance-conscious team-change reproducibility claim</para>
    /// labels<para>PTRC</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#PTRC">http://www.molmod.info/semantics/pims-ii.ttl#PTRC</seealso>
    let PTRC = Prefixed_Name(pimsii, "PTRC") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:DigitalArticulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Digital articulation, i.e., an articulation the members of which are copies of the same digital content (a file, assignment of a value to a variable, a data set, etc.)</para>
    /// labels<para>DigitalArticulation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#DigitalArticulation">http://www.molmod.info/semantics/pims-ii.ttl#DigitalArticulation</seealso>
    let DigitalArticulation =
        Prefixed_Name(pimsii, "DigitalArticulation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isReferentIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isReferentIn y) == x occurs in the cognitive step y in the function of the/a referent of a representamen</para>
    /// labels<para>isReferentIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isReferentIn">http://www.molmod.info/semantics/pims-ii.ttl#isReferentIn</seealso>
    let isReferentIn = Prefixed_Name(pimsii, "isReferentIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:articulatesLiterally</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x articulatesLiterally y) means that x is a collective literal expressing the proposition y, and possibly additional propositions beside y</para>
    /// labels<para>articulatesLiterally</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#articulatesLiterally">http://www.molmod.info/semantics/pims-ii.ttl#articulatesLiterally</seealso>
    let articulatesLiterally =
        Prefixed_Name(pimsii, "articulatesLiterally") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:articulates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x articulates y) means that x is a semiotic member of the proposition y, giving a literal or non-literal (e.g., spoken) expression to its propositional content; n.b., x may also express other propositions beside y</para>
    /// labels<para>articulates</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#articulates">http://www.molmod.info/semantics/pims-ii.ttl#articulates</seealso>
    let articulates = Prefixed_Name(pimsii, "articulates") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isAimIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isAimIn y) means that y is a purposeful action, and x is one of the aims followed by the agent of y by undertaking y</para>
    /// labels<para>isAimIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isAimIn">http://www.molmod.info/semantics/pims-ii.ttl#isAimIn</seealso>
    let isAimIn = Prefixed_Name(pimsii, "isAimIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isMagnitudeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isMagnitudeOf y) means that x is the numerical magnitude of y, e.g., in 200 kPa, x would be 200</para>
    /// labels<para>isMagnitudeOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isMagnitudeOf">http://www.molmod.info/semantics/pims-ii.ttl#isMagnitudeOf</seealso>
    let isMagnitudeOf = Prefixed_Name(pimsii, "isMagnitudeOf") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Query, i.e., a digital articulation of a question</para>
    /// labels<para>Query</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Query">http://www.molmod.info/semantics/pims-ii.ttl#Query</seealso>
    let Query = Prefixed_Name(pimsii, "Query") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isExpressedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isExpressedIn y) means that x is expressed/stated/uttered in the expressive act y (by its speaker), possibly but not necessarily in an affirmative way</para>
    /// labels<para>isExpressedIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isExpressedIn">http://www.molmod.info/semantics/pims-ii.ttl#isExpressedIn</seealso>
    let isExpressedIn = Prefixed_Name(pimsii, "isExpressedIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isCognitiveSubstepOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In certain cases, multiple cognitive steps can be combined to yield one; e.g., the substep a: s - o - s' and the substep b: s' - o - s'' can be combined to yield a single triad, (a o b) = c: s - o - s''; in that case, c can be an element of a higher-order cognitive chain (of which it is a step), and a and b are its cognitive substeps</para>
    /// labels<para>isCognitiveSubstepOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isCognitiveSubstepOf">http://www.molmod.info/semantics/pims-ii.ttl#isCognitiveSubstepOf</seealso>
    let isCognitiveSubstepOf =
        Prefixed_Name(pimsii, "isCognitiveSubstepOf") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isConstitutiveOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isConstitutiveOf y) means that, by virtue of an interaction requiring spatiotemporal overlap, x contributes causally to y fulfilling a certain function, exhibiting certain properties, or relating to other objects in the way it does, thereby creating a direct causal connection between x and y</para>
    /// labels<para>isConstitutiveOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isConstitutiveOf">http://www.molmod.info/semantics/pims-ii.ttl#isConstitutiveOf</seealso>
    let isConstitutiveOf = Prefixed_Name(pimsii, "isConstitutiveOf") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:realizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x realizes y) means that x, which is not a semiotic collective, is a literal or non-literal realization of the expression y</para>
    /// labels<para>realizes</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#realizes">http://www.molmod.info/semantics/pims-ii.ttl#realizes</seealso>
    let realizes = Prefixed_Name(pimsii, "realizes") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isAdmissibleUnitFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isAdmissibleUnitFor y) means that x is a unit that can be associated with the variable y; subsumption under msHPIPIR is explained as follows: There is a sign z for the variable y (where z is a description of admissible values of y) of which x is constitutive (and with which x hence overlaps)</para>
    /// labels<para>isAdmissibleUnitFor</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isAdmissibleUnitFor">http://www.molmod.info/semantics/pims-ii.ttl#isAdmissibleUnitFor</seealso>
    let isAdmissibleUnitFor =
        Prefixed_Name(pimsii, "isAdmissibleUnitFor") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:msIPIRIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIPIR o isRepresentamenFor</para>
    /// labels<para>msIPIRIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIPIRIR">http://www.molmod.info/semantics/pims-ii.ttl#msIPIRIR</seealso>
    let msIPIRIR = Prefixed_Name(pimsii, "msIPIRIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:CognitiveStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cognitive step, i.e., an elementary cognition that can form an part of a cognitive chain</para>
    /// labels<para>CognitiveStep</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveStep">http://www.molmod.info/semantics/pims-ii.ttl#CognitiveStep</seealso>
    let CognitiveStep = Prefixed_Name(pimsii, "CognitiveStep") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Value, i.e., an articulation that is by social convention understood to be potentially assignable to a variable</para>
    /// labels<para>Value</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Value">http://www.molmod.info/semantics/pims-ii.ttl#Value</seealso>
    let Value = Prefixed_Name(pimsii, "Value") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Undertaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Undertaking, i.e., a metonymization by which a resolution, which was previously determined (by telesis) in response to the pre-existing situation, is actively taken up by the agent, motivating an action</para>
    /// labels<para>Undertaking</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Undertaking">http://www.molmod.info/semantics/pims-ii.ttl#Undertaking</seealso>
    let Undertaking = Prefixed_Name(pimsii, "Undertaking") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isAntecedentWithin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isAntecedentWithin y) means that x is the antecedent from the rule y</para>
    /// labels<para>isAntecedentWithin</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isAntecedentWithin">http://www.molmod.info/semantics/pims-ii.ttl#isAntecedentWithin</seealso>
    let isAntecedentWithin = Prefixed_Name(pimsii, "isAntecedentWithin") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isTriadOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>'x isTriadOf (e1 e2 e3)' is a shorthand for 'e1 isFirstElementIn x; e2 isSecondElementIn x; e3 isThirdElementIn x'</para>
    /// labels<para>isTriadOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isTriadOf">http://www.molmod.info/semantics/pims-ii.ttl#isTriadOf</seealso>
    let isTriadOf = Prefixed_Name(pimsii, "isTriadOf") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isRelatedToList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Top property for multi-argument predicates that are implemented as 'x isRelatedToList (y1 y2 ... yn)', i.e., such that the object is an rdf:List</para>
    /// labels<para>isRelatedToList</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isRelatedToList">http://www.molmod.info/semantics/pims-ii.ttl#isRelatedToList</seealso>
    let isRelatedToList = Prefixed_Name(pimsii, "isRelatedToList") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isValueInAssignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(y isValueInAssignment a) mans that a: x = y is an assignment where the value y is assigned to a variable x</para>
    /// labels<para>isValueInAssignment</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isValueInAssignment">http://www.molmod.info/semantics/pims-ii.ttl#isValueInAssignment</seealso>
    let isValueInAssignment =
        Prefixed_Name(pimsii, "isValueInAssignment") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isGroundFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(g isGroundFor y) means that g is a representamen for the cognitive step y, explaining how y is grounded</para>
    /// labels<para>isGroundFor</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundFor">http://www.molmod.info/semantics/pims-ii.ttl#isGroundFor</seealso>
    let isGroundFor = Prefixed_Name(pimsii, "isGroundFor") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Interlocutor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Interlocutor, i.e., an agent that can be addressed and is capable of addressing others in a communication process</para>
    /// labels<para>Interlocutor</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Interlocutor">http://www.molmod.info/semantics/pims-ii.ttl#Interlocutor</seealso>
    let Interlocutor = Prefixed_Name(pimsii, "Interlocutor") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isAssertedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isAssertedBy y) means that x is a claim that is affirmatively expressed/stated/uttered by the interlocutor y</para>
    /// labels<para>isAssertedBy</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isAssertedBy">http://www.molmod.info/semantics/pims-ii.ttl#isAssertedBy</seealso>
    let isAssertedBy = Prefixed_Name(pimsii, "isAssertedBy") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isSpeakerIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSpeakerIn y) means that x is (the only) speaker in the expressive act y, where the role of the speaker is to be understood as that of an agent that conducts/undertakes the expressive act, i.e., it is not limited to vocal speech</para>
    /// labels<para>isSpeakerIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSpeakerIn">http://www.molmod.info/semantics/pims-ii.ttl#isSpeakerIn</seealso>
    let isSpeakerIn = Prefixed_Name(pimsii, "isSpeakerIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isGoalFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isGoalFor y) means that to the goal-directed agent y, the telos x represents something that is to be reached.</para>
    /// labels<para>isGoalFor</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isGoalFor">http://www.molmod.info/semantics/pims-ii.ttl#isGoalFor</seealso>
    let isGoalFor = Prefixed_Name(pimsii, "isGoalFor") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:GroundedCognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Grounded cognition, i.e., a cognition that is logically preceded by a presupposition such that there is a grounding chain establishing its epistemic status as a grounded cognition</para>
    /// labels<para>GroundedCognition</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#GroundedCognition">http://www.molmod.info/semantics/pims-ii.ttl#GroundedCognition</seealso>
    let GroundedCognition = Prefixed_Name(pimsii, "GroundedCognition") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:GroundingChain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Grounding chain, i.e., a cognitive chain that establishes epistemic grounding</para>
    /// labels<para>GroundingChain</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingChain">http://www.molmod.info/semantics/pims-ii.ttl#GroundingChain</seealso>
    let GroundingChain = Prefixed_Name(pimsii, "GroundingChain") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:GroundingInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Grounding interpretation, i.e., an interpretation where the sign is a ground for the considered cognitive step, the object is the considered cognitive step, and the interpretant is a ground for a subsequent cognitive step</para>
    /// labels<para>GroundingInterpretation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingInterpretation">http://www.molmod.info/semantics/pims-ii.ttl#GroundingInterpretation</seealso>
    let GroundingInterpretation =
        Prefixed_Name(pimsii, "GroundingInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:groundsNextStepIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x groundsNextStepIn y) == y is a grounding interpretation where x is the third element, i.e., a ground for the subsequent cognitive step; thereby, x also serves as a ground for y itself</para>
    /// labels<para>groundsNextStepIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#groundsNextStepIn">http://www.molmod.info/semantics/pims-ii.ttl#groundsNextStepIn</seealso>
    let groundsNextStepIn = Prefixed_Name(pimsii, "groundsNextStepIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isGroundingStepIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isGroundingStepIn y) == y is a grounding step where x is the grounding step, i.e., the first element</para>
    /// labels<para>isGroundingStepIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundingStepIn">http://www.molmod.info/semantics/pims-ii.ttl#isGroundingStepIn</seealso>
    let isGroundingStepIn = Prefixed_Name(pimsii, "isGroundingStepIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isGroundedStepIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isGroundedStepIn y) == y is a grounding step where x is the grounded step, i.e., the third element</para>
    /// labels<para>isGroundedStepIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundedStepIn">http://www.molmod.info/semantics/pims-ii.ttl#isGroundedStepIn</seealso>
    let isGroundedStepIn = Prefixed_Name(pimsii, "isGroundedStepIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:SemanticChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Semantic change, i.e., a triadic cognition by which a representamen is assigned a new referent</para>
    /// labels<para>SemanticChange</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#SemanticChange">http://www.molmod.info/semantics/pims-ii.ttl#SemanticChange</seealso>
    let SemanticChange = Prefixed_Name(pimsii, "SemanticChange") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:IndividualIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Individual IRI, i.e., the internationalized resource identifier of an individual (owl:Thing or pims-ii:Object)</para>
    /// labels<para>IndividualIRI</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#IndividualIRI">http://www.molmod.info/semantics/pims-ii.ttl#IndividualIRI</seealso>
    let IndividualIRI = Prefixed_Name(pimsii, "IndividualIRI") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:UniqueIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Unique identifier, i.e., a rigid designator that is applied to exactly one object</para>
    /// labels<para>UniqueIdentifier</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#UniqueIdentifier">http://www.molmod.info/semantics/pims-ii.ttl#UniqueIdentifier</seealso>
    let UniqueIdentifier = Prefixed_Name(pimsii, "UniqueIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isInformationProcessingInputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isInformationProcessingInputIn y) == y is an information-processing step where x is the input, i.e., the first element</para>
    /// labels<para>isInformationProcessingInputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isInformationProcessingInputIn">http://www.molmod.info/semantics/pims-ii.ttl#isInformationProcessingInputIn</seealso>
    let isInformationProcessingInputIn =
        Prefixed_Name(pimsii, "isInformationProcessingInputIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isObjectInInformationProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObjectInInformationProcessing y) == y is an information-processing step where x is the object that the input and the output both represent, i.e., the second element</para>
    /// labels<para>isObjectInInformationProcessing</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInInformationProcessing">http://www.molmod.info/semantics/pims-ii.ttl#isObjectInInformationProcessing</seealso>
    let isObjectInInformationProcessing =
        Prefixed_Name(pimsii, "isObjectInInformationProcessing") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSignInInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSignInInterpretation y) == y is an interpretation where x acts as the sign, i.e., the first element</para>
    /// labels<para>isSignInInterpretation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSignInInterpretation">http://www.molmod.info/semantics/pims-ii.ttl#isSignInInterpretation</seealso>
    let isSignInInterpretation =
        Prefixed_Name(pimsii, "isSignInInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isObjectInInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObjectInInterpretation y) == y is an interpretation where x acts as the object, i.e., the second element; there is no need to the object of an interpretation to be present and participate in the interpretation process physically</para>
    /// labels<para>isObjectInInterpretation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInInterpretation">http://www.molmod.info/semantics/pims-ii.ttl#isObjectInInterpretation</seealso>
    let isObjectInInterpretation =
        Prefixed_Name(pimsii, "isObjectInInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:InvestigationSetup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Investigation setup, i.e., a metonymization where a sign (e.g., a model and/or open question) that has come up for an 'object of application' (the old referent, e.g., the system to which a use case refers) is reassigned to an 'object of investigation' to which dedicated studies can be applied, such as a system that will be simulated or investigated experimentally; n.b., there needs to be a causal connection between the old and the new referent, i.e., between the object of application and the object of investigation</para>
    /// labels<para>InvestigationSetup</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#InvestigationSetup">http://www.molmod.info/semantics/pims-ii.ttl#InvestigationSetup</seealso>
    let InvestigationSetup = Prefixed_Name(pimsii, "InvestigationSetup") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isObjectOfApplicationIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObjectOfApplicationIn y) == y is an investigation-setup action where x acts as the object of application (e.g., the system to which a use case refers), i.e., the first element; n.b., there needs to be a causal connection between the object of application and the object of investigation</para>
    /// labels<para>isObjectOfApplicationIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectOfApplicationIn">http://www.molmod.info/semantics/pims-ii.ttl#isObjectOfApplicationIn</seealso>
    let isObjectOfApplicationIn =
        Prefixed_Name(pimsii, "isObjectOfApplicationIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:KnowledgeBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Knowledge base, i.e., an interlocutor that makes a consistent set of claims and will respond consistently if queried; n.b., that propositional content which 'isHeldBy' a knowledge base needs to be invariable over the whole 4D spacetime in which the knowledge base exist. Since technical knowledge bases do happen to change their propositional content over time, it may make sense either to define proper parts with a short temporal extension or to take care with what a knowledge base is stated to hold. Other kinds of propositional content (varying over time or depending on who makes the query) can be said to be asserted rather than held by the knowledge base.</para>
    /// labels<para>KnowledgeBase</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeBase">http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeBase</seealso>
    let KnowledgeBase = Prefixed_Name(pimsii, "KnowledgeBase") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:KnowledgeBasedAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Knowledge-based agent, i.e., an intelligent agent that uses a knowledge base to store and process its opinions/claims/worldview</para>
    /// labels<para>KnowledgeBasedAgent</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeBasedAgent">http://www.molmod.info/semantics/pims-ii.ttl#KnowledgeBasedAgent</seealso>
    let KnowledgeBasedAgent =
        Prefixed_Name(pimsii, "KnowledgeBasedAgent") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isInterpretantIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isInterpretantIn y) == y is a semiosis where x acts as the interpretant, i.e., the third element</para>
    /// labels<para>isInterpretantIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantIn">http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantIn</seealso>
    let isInterpretantIn = Prefixed_Name(pimsii, "isInterpretantIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:ValidityClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Validity claim (VC), i.e., a claim about another claim, saying something about that claim's (in-)accuracy or somebody's (dis-)trust in the claim</para>
    /// labels<para>ValidityClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ValidityClaim">http://www.molmod.info/semantics/pims-ii.ttl#ValidityClaim</seealso>
    let ValidityClaim = Prefixed_Name(pimsii, "ValidityClaim") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Name, i.e., a lexeme that acts as a rigid designator due to social convention</para>
    /// labels<para>Name</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Name">http://www.molmod.info/semantics/pims-ii.ttl#Name</seealso>
    let Name = Prefixed_Name(pimsii, "Name") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:MathematicalOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mathematical operator, i.e., a lexeme that articulates a mathematical operation, such as the collective containing realizations of '*', '·', 'times', etc.</para>
    /// labels<para>MathematicalOperator</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#MathematicalOperator">http://www.molmod.info/semantics/pims-ii.ttl#MathematicalOperator</seealso>
    let MathematicalOperator =
        Prefixed_Name(pimsii, "MathematicalOperator") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isMeasurementOutcomeIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isMeasurementOutcomeIn y) == y is a measurement where x is the measurement outcome, i.e., the third element (e.g., the value that is determined for the considered property of the measured object, the measurement error, and any other outcome)</para>
    /// labels<para>isMeasurementOutcomeIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isMeasurementOutcomeIn">http://www.molmod.info/semantics/pims-ii.ttl#isMeasurementOutcomeIn</seealso>
    let isMeasurementOutcomeIn =
        Prefixed_Name(pimsii, "isMeasurementOutcomeIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:MeasurementUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit, i.e., a 'real scalar quantity, defined and adopted by convention' (EMMO, ISO 80000-1)</para>
    /// labels<para>MeasurementUnit</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#MeasurementUnit">http://www.molmod.info/semantics/pims-ii.ttl#MeasurementUnit</seealso>
    let MeasurementUnit = Prefixed_Name(pimsii, "MeasurementUnit") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isMereotopologicalMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isMereotopologicalMemberOf y) means that x is one out of several mereotopologically connected components of y</para>
    /// labels<para>isMereotopologicalMemberOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isMereotopologicalMemberOf">http://www.molmod.info/semantics/pims-ii.ttl#isMereotopologicalMemberOf</seealso>
    let isMereotopologicalMemberOf =
        Prefixed_Name(pimsii, "isMereotopologicalMemberOf") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:changesReferentInMetonymization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x changesReferentInMetonymization y) == y is a metonymization where x acts as the representamen, i.e., the second element</para>
    /// labels<para>changesReferentInMetonymization</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInMetonymization">http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInMetonymization</seealso>
    let changesReferentInMetonymization =
        Prefixed_Name(pimsii, "changesReferentInMetonymization") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isNewReferentInMetonymization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isNewReferentInMetonymization y) == y is a metonymization where x acts as the new referent, i.e., the third element; the old and the new referent need to have a causal connection</para>
    /// labels<para>isNewReferentInMetonymization</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInMetonymization">http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInMetonymization</seealso>
    let isNewReferentInMetonymization =
        Prefixed_Name(pimsii, "isNewReferentInMetonymization") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:QualifiedModalIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualified modal IRI, i.e., the IRI of a relation that is defined by qualified necessity or possibility of another relation</para>
    /// labels<para>QualifiedModalIRI</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#QualifiedModalIRI">http://www.molmod.info/semantics/pims-ii.ttl#QualifiedModalIRI</seealso>
    let QualifiedModalIRI = Prefixed_Name(pimsii, "QualifiedModalIRI") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isModellingInputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isModellingInputIn y) == y is a modelling (model construction or parameterization) step where x is the input (previous or unparameterized model, knowledge about the modelled system, etc.), i.e., the first element</para>
    /// labels<para>isModellingInputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isModellingInputIn">http://www.molmod.info/semantics/pims-ii.ttl#isModellingInputIn</seealso>
    let isModellingInputIn = Prefixed_Name(pimsii, "isModellingInputIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isModelledIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isModelledIn y) == y is a modelling (model construction or parameterization) step where x acts as the modelled object (system, substance, process, or similar), i.e., the second element</para>
    /// labels<para>isModelledIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isModelledIn">http://www.molmod.info/semantics/pims-ii.ttl#isModelledIn</seealso>
    let isModelledIn = Prefixed_Name(pimsii, "isModelledIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isModellingOutputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isModellingOutputIn y) == y is a modelling (model construction or parameterization) step where x is the modelling output (e.g., a parameterized or improved model), i.e., the third element</para>
    /// labels<para>isModellingOutputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isModellingOutputIn">http://www.molmod.info/semantics/pims-ii.ttl#isModellingOutputIn</seealso>
    let isModellingOutputIn =
        Prefixed_Name(pimsii, "isModellingOutputIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isNameFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isNameFor y), to be applied in the frequent special case where x is represented by a name for x, i.e., where social convention has established y as a rigid designator for x</para>
    /// labels<para>isNameFor</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isNameFor">http://www.molmod.info/semantics/pims-ii.ttl#isNameFor</seealso>
    let isNameFor = Prefixed_Name(pimsii, "isNameFor") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:NegativeKnowledgeClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Negative knowledge claim (NKC), i.e., a knowledge claim that expresses what we don't know, a gap or limitation of our knowledge</para>
    /// labels<para>NegativeKnowledgeClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#NegativeKnowledgeClaim">http://www.molmod.info/semantics/pims-ii.ttl#NegativeKnowledgeClaim</seealso>
    let NegativeKnowledgeClaim =
        Prefixed_Name(pimsii, "NegativeKnowledgeClaim") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSpatiotemporallyDisconnectedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSpatiotemporallyDisconnectedFrom y) is the negation of (x isSpatiotemporallyConnectedWith y); i.e., to go from any point in x to any point in y, it is necessary to leave the fusion (x U y)</para>
    /// labels<para>isSpatiotemporallyDisconnectedFrom</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSpatiotemporallyDisconnectedFrom">http://www.molmod.info/semantics/pims-ii.ttl#isSpatiotemporallyDisconnectedFrom</seealso>
    let isSpatiotemporallyDisconnectedFrom =
        Prefixed_Name(pimsii, "isSpatiotemporallyDisconnectedFrom") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:temporallyPrecedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>(x temporallyPrecedes y) means that every point in x is earlier in time than every point in y; the spacetime regions x and y may be connected, but they cannot overlap temporally</para>
    /// labels<para>temporallyPrecedes</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#temporallyPrecedes">http://www.molmod.info/semantics/pims-ii.ttl#temporallyPrecedes</seealso>
    let temporallyPrecedes = Prefixed_Name(pimsii, "temporallyPrecedes") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:hasProperPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>(x hasProperPart y) means that y is an improper part of x such that x and y are not the same, in other words, all points within y are also within x, but not vice versa</para>
    /// labels<para>hasProperPart</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#hasProperPart">http://www.molmod.info/semantics/pims-ii.ttl#hasProperPart</seealso>
    let hasProperPart = Prefixed_Name(pimsii, "hasProperPart") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isProperPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Spatiotemporal (mereological) proper parthood relation; (x isProperPartOf y) means that x is an improper part of y such that x and y are not the same, in other words, all points within x are also within y, but not vice versa</para>
    /// labels<para>isProperPartOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isProperPartOf">http://www.molmod.info/semantics/pims-ii.ttl#isProperPartOf</seealso>
    let isProperPartOf = Prefixed_Name(pimsii, "isProperPartOf") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isObservationInputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObservationInputIn y) == y is an observation where x designates input and/or advance knowledge relevant to the observation, i.e., the first element</para>
    /// labels<para>isObservationInputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObservationInputIn">http://www.molmod.info/semantics/pims-ii.ttl#isObservationInputIn</seealso>
    let isObservationInputIn =
        Prefixed_Name(pimsii, "isObservationInputIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isObservedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObservedIn y) == y is an observation where x acts as the observed object, i.e., the second element, for which the value of a property is to be determined</para>
    /// labels<para>isObservedIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObservedIn">http://www.molmod.info/semantics/pims-ii.ttl#isObservedIn</seealso>
    let isObservedIn = Prefixed_Name(pimsii, "isObservedIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isObservationOutcomeIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObservationOutcomeIn y) == y is an observation where x is the observation outcome (the observed value of the target property), i.e., the third element</para>
    /// labels<para>isObservationOutcomeIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObservationOutcomeIn">http://www.molmod.info/semantics/pims-ii.ttl#isObservationOutcomeIn</seealso>
    let isObservationOutcomeIn =
        Prefixed_Name(pimsii, "isObservationOutcomeIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Perception</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Perception, i.e., a semiosis in which the referent is a participant (as a perceived object) and therefore needs to be physically present</para>
    /// labels<para>Perception</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Perception">http://www.molmod.info/semantics/pims-ii.ttl#Perception</seealso>
    let Perception = Prefixed_Name(pimsii, "Perception") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Optimization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Optimization, i.e., an interpretation in which the sign is the optimization problem, the object is that which the optimization problem is ultimately about, and the interpretant is the optimization output</para>
    /// labels<para>Optimization</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Optimization">http://www.molmod.info/semantics/pims-ii.ttl#Optimization</seealso>
    let Optimization = Prefixed_Name(pimsii, "Optimization") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isOptimizationProblemIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isOptimizationProblemIn y) == y is an optimization where x is the optimization problem, i.e., the first element.</para>
    /// labels<para>isOptimizationProblemIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationProblemIn">http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationProblemIn</seealso>
    let isOptimizationProblemIn =
        Prefixed_Name(pimsii, "isOptimizationProblemIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isObjectInOptimization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isObjectInOptimization y) == y is an optimization where x is that which the optimization is ultimately about, i.e., the second element</para>
    /// labels<para>isObjectInOptimization</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isObjectInOptimization">http://www.molmod.info/semantics/pims-ii.ttl#isObjectInOptimization</seealso>
    let isObjectInOptimization =
        Prefixed_Name(pimsii, "isObjectInOptimization") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isOptimizationOutputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isOptimizationOutputIn y) == y is an optimization where x is the optimization output, i.e., the third element</para>
    /// labels<para>isOptimizationOutputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationOutputIn">http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationOutputIn</seealso>
    let isOptimizationOutputIn =
        Prefixed_Name(pimsii, "isOptimizationOutputIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isDesignParameterWithin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isDesignParameterWithin y) == x is one of the parameters that make up the design space considered in the optimization problem y</para>
    /// labels<para>isDesignParameterWithin</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isDesignParameterWithin">http://www.molmod.info/semantics/pims-ii.ttl#isDesignParameterWithin</seealso>
    let isDesignParameterWithin =
        Prefixed_Name(pimsii, "isDesignParameterWithin") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isOptimizationObjectiveWithin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isOptimizationObjectiveWithin y) == x is one of the optimization criteria that make up the objective space considered in the optimization problem y</para>
    /// labels<para>isOptimizationObjectiveWithin</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationObjectiveWithin">http://www.molmod.info/semantics/pims-ii.ttl#isOptimizationObjectiveWithin</seealso>
    let isOptimizationObjectiveWithin =
        Prefixed_Name(pimsii, "isOptimizationObjectiveWithin") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:ReferenceToSelf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reference to self, i.e., an entity for the interlocutor who *is* the present system, i.e., the system containing the present triples, etc., and whose claims are to be accepted as the present system's 'own claims.' A self-reference is an entity that is either identical with the system at hand, namely, the digital infrastructure or other interlocutor that stores the present semantic content, or a component of it</para>
    /// labels<para>ReferenceToSelf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ReferenceToSelf">http://www.molmod.info/semantics/pims-ii.ttl#ReferenceToSelf</seealso>
    let ReferenceToSelf = Prefixed_Name(pimsii, "ReferenceToSelf") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:PartToWhole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Part-to-whole synecdoche, i.e., a metonymization where the old referent is a spatiotemporal proper part of the new referent (additionally, the old and new referent need to be connected causally)</para>
    /// labels<para>PartToWhole</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#PartToWhole">http://www.molmod.info/semantics/pims-ii.ttl#PartToWhole</seealso>
    let PartToWhole = Prefixed_Name(pimsii, "PartToWhole") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isOldReferentInPartToWhole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isOldReferentInPartToWhole y) == y is a part-to-whole synecdoche where x acts as the old referent (the part), i.e., the first element</para>
    /// labels<para>isOldReferentInPartToWhole</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInPartToWhole">http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInPartToWhole</seealso>
    let isOldReferentInPartToWhole =
        Prefixed_Name(pimsii, "isOldReferentInPartToWhole") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:changesReferentInPartToWhole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x changesReferentInPartToWhole y) == y is a part-to-whole synecdoche where x acts as the representamen, i.e., the second element</para>
    /// labels<para>changesReferentInPartToWhole</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInPartToWhole">http://www.molmod.info/semantics/pims-ii.ttl#changesReferentInPartToWhole</seealso>
    let changesReferentInPartToWhole =
        Prefixed_Name(pimsii, "changesReferentInPartToWhole") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isNewReferentInPartToWhole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isNewReferentInPartToWhole y) == y is a part-to-whole synecdoche where x acts as the new referent (the whole), i.e., the third element</para>
    /// labels<para>isNewReferentInPartToWhole</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInPartToWhole">http://www.molmod.info/semantics/pims-ii.ttl#isNewReferentInPartToWhole</seealso>
    let isNewReferentInPartToWhole =
        Prefixed_Name(pimsii, "isNewReferentInPartToWhole") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Synecdoche</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Synecdoche, i.e., a metonymization where a sign is reassigned to a part of its old referent (WholeToPart) or vice versa (PartToWhole)</para>
    /// labels<para>Synecdoche</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Synecdoche">http://www.molmod.info/semantics/pims-ii.ttl#Synecdoche</seealso>
    let Synecdoche = Prefixed_Name(pimsii, "Synecdoche") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isSignInPerception</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSignInPerception y) == y is a perception where x acts as the sign, i.e., the first element</para>
    /// labels<para>isSignInPerception</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSignInPerception">http://www.molmod.info/semantics/pims-ii.ttl#isSignInPerception</seealso>
    let isSignInPerception = Prefixed_Name(pimsii, "isSignInPerception") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isPerceivedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isPerceivedIn y) == y is a perception where x acts as the perceived object, i.e., the second element; the perceived object is a (mereotopological) participant of the perception, in other words, it needs to be physically present so that it can be perceived</para>
    /// labels<para>isPerceivedIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isPerceivedIn">http://www.molmod.info/semantics/pims-ii.ttl#isPerceivedIn</seealso>
    let isPerceivedIn = Prefixed_Name(pimsii, "isPerceivedIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isInterpretantInPerception</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isInterpretantInPerception y) == y is a perception where x acts as the interpretant, i.e., the third element</para>
    /// labels<para>isInterpretantInPerception</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantInPerception">http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantInPerception</seealso>
    let isInterpretantInPerception =
        Prefixed_Name(pimsii, "isInterpretantInPerception") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Planning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Planning, i.e., a reflection ex ante or predetermination, carried out by analysing the perceived present situation in advance of potentially undertaking an action</para>
    /// labels<para>Planning</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Planning">http://www.molmod.info/semantics/pims-ii.ttl#Planning</seealso>
    let Planning = Prefixed_Name(pimsii, "Planning") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isTelosInPlanning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isTelosInPlanning y) == y is a telesis carried out in advance of potentially undertaking an action, where x acts as the telos (initial guiding objective), i.e., the first element</para>
    /// labels<para>isTelosInPlanning</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isTelosInPlanning">http://www.molmod.info/semantics/pims-ii.ttl#isTelosInPlanning</seealso>
    let isTelosInPlanning = Prefixed_Name(pimsii, "isTelosInPlanning") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSituationInPlanning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSituationInPlanning y) == y is a telesis carried out in advance of potentially undertaking an action, where x is the perceived present situation, i.e., the second element, against which the telos is evaluated</para>
    /// labels<para>isSituationInPlanning</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSituationInPlanning">http://www.molmod.info/semantics/pims-ii.ttl#isSituationInPlanning</seealso>
    let isSituationInPlanning =
        Prefixed_Name(pimsii, "isSituationInPlanning") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isResolutionInPlanning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isResolutionInPlanning y) == y is a telesis carried out in advance of potentially undertaking an action, where x is the planning outcome, i.e., the third element</para>
    /// labels<para>isResolutionInPlanning</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInPlanning">http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInPlanning</seealso>
    let isResolutionInPlanning =
        Prefixed_Name(pimsii, "isResolutionInPlanning") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Plurality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Plurality, i.e., a semiotic collective the semiotic members of which are a representational element (referent or representamen) together, whereby all act/contribute in the same way - this latter point distinguishes a plurality from a structure; e.g., the referent of the expression 'the four seasons/quarters of the year' (for a given year, within a given spatial region) is a plurality, and each of the four seasons/quarters is one of its semiotic members</para>
    /// labels<para>Plurality</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Plurality">http://www.molmod.info/semantics/pims-ii.ttl#Plurality</seealso>
    let Plurality = Prefixed_Name(pimsii, "Plurality") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isMemberOfPlurality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isMemberOfPlurality y) means that x is a semiotic member of the plurality y, and that it participates in semiosis in the same way as its co-members x', x'', ... of the plurality y</para>
    /// labels<para>isMemberOfPlurality</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isMemberOfPlurality">http://www.molmod.info/semantics/pims-ii.ttl#isMemberOfPlurality</seealso>
    let isMemberOfPlurality =
        Prefixed_Name(pimsii, "isMemberOfPlurality") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Structure, i.e., a semiotic collective the semiotic members of which complement each other, contributing in different ways (or, at least, not all int the same way) to their joint action as a referent or a representamen</para>
    /// labels<para>Structure</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Structure">http://www.molmod.info/semantics/pims-ii.ttl#Structure</seealso>
    let Structure = Prefixed_Name(pimsii, "Structure") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isRightHandSideIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(y isRightHandSideIn a) mans that a: x = y is an equality articulation with the term y as its right-hand side</para>
    /// labels<para>isRightHandSideIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isRightHandSideIn">http://www.molmod.info/semantics/pims-ii.ttl#isRightHandSideIn</seealso>
    let isRightHandSideIn = Prefixed_Name(pimsii, "isRightHandSideIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:ResearchQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Research question, i.e., a question that could, has been, or is being addressed by scientific research and e.g. could be answered by a knowledge claim formulated on the grounds of scientific research data</para>
    /// labels<para>ResearchQuestion</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ResearchQuestion">http://www.molmod.info/semantics/pims-ii.ttl#ResearchQuestion</seealso>
    let ResearchQuestion = Prefixed_Name(pimsii, "ResearchQuestion") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isConsequentWithin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isConsequentWithin y) means that x is a consequent from the rule y</para>
    /// labels<para>isConsequentWithin</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isConsequentWithin">http://www.molmod.info/semantics/pims-ii.ttl#isConsequentWithin</seealso>
    let isConsequentWithin = Prefixed_Name(pimsii, "isConsequentWithin") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIRHPIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHPIR o overlapsWith</para>
    /// labels<para>msHPIRHPIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHPIP">http://www.molmod.info/semantics/pims-ii.ttl#msHPIRHPIP</seealso>
    let msHPIRHPIP = Prefixed_Name(pimsii, "msHPIRHPIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRIRHPIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation sharesRepresentamenWith o overlapsWith</para>
    /// labels<para>msHRIRHPIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHPIP">http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHPIP</seealso>
    let msHRIRHPIP = Prefixed_Name(pimsii, "msHRIRHPIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isClaimOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isClaimOf y) means that the x is a proposition that has some kind of belief-like or knowledge-like epistemic status for the intelligent agent y</para>
    /// labels<para>isClaimOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isClaimOf">http://www.molmod.info/semantics/pims-ii.ttl#isClaimOf</seealso>
    let isClaimOf = Prefixed_Name(pimsii, "isClaimOf") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:changesReferentIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x changesReferentIn y) == y is a semantic change where x acts as the representamen, i.e., the second element</para>
    /// labels<para>changesReferentIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#changesReferentIn">http://www.molmod.info/semantics/pims-ii.ttl#changesReferentIn</seealso>
    let changesReferentIn = Prefixed_Name(pimsii, "changesReferentIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Proposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Proposition, i.e., a semiotic collective the members of which are collective literals and collective utterances understood to be attributed some joint semantic and/or pragmatic content, or undergoing evaluation jointly for the presence of such a content</para>
    /// labels<para>Proposition</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Proposition">http://www.molmod.info/semantics/pims-ii.ttl#Proposition</seealso>
    let Proposition = Prefixed_Name(pimsii, "Proposition") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:CognitiveChain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cognitive chain, i.e., a cognition that consists of multiple (sub)steps</para>
    /// labels<para>CognitiveChain</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveChain">http://www.molmod.info/semantics/pims-ii.ttl#CognitiveChain</seealso>
    let CognitiveChain = Prefixed_Name(pimsii, "CognitiveChain") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIRIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHPIR o isRepresentamenFor</para>
    /// labels<para>msHPIRIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIRIR">http://www.molmod.info/semantics/pims-ii.ttl#msHPIRIR</seealso>
    let msHPIRIR = Prefixed_Name(pimsii, "msHPIRIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement, i.e., an observation that follows a standard procedure, so that it can be expected to yield an objective (rather than subjective) outcome</para>
    /// labels<para>Measurement</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Measurement">http://www.molmod.info/semantics/pims-ii.ttl#Measurement</seealso>
    let Measurement = Prefixed_Name(pimsii, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Intention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Intention, i.e., a proposition that constitutes an aim or goal</para>
    /// labels<para>Intention</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Intention">http://www.molmod.info/semantics/pims-ii.ttl#Intention</seealso>
    let Intention = Prefixed_Name(pimsii, "Intention") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:GoalOrientedAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Goal-oriented agent, i.e., an agent that exhibits the tendency 'to achieve a certain state of the world' (Conte, doi:10.1007/978-1-4614-1800-9_158, 2009)</para>
    /// labels<para>GoalOrientedAgent</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#GoalOrientedAgent">http://www.molmod.info/semantics/pims-ii.ttl#GoalOrientedAgent</seealso>
    let GoalOrientedAgent = Prefixed_Name(pimsii, "GoalOrientedAgent") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isGoalOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isGoalOf y) means that y is a goal-oriented agent with the tendency to work toward a state of affairs that is described/represented by y; accordingly, the goal y is also a representamen for the agent itself; this does *not* imply that the agent x is aware of pursuing y as a goal, or that y is somehow included in x as a mental representation - for that purpose, use the relation 'isGoalFor'</para>
    /// labels<para>isGoalOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isGoalOf">http://www.molmod.info/semantics/pims-ii.ttl#isGoalOf</seealso>
    let isGoalOf = Prefixed_Name(pimsii, "isGoalOf") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:logicallyPrecedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x logicallyPrecedes y) means that x and y are cognitive steps that are connected by a cognitive chain, leading from x and y, that does not contain a cognitive rupture</para>
    /// labels<para>logicallyPrecedes</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#logicallyPrecedes">http://www.molmod.info/semantics/pims-ii.ttl#logicallyPrecedes</seealso>
    let logicallyPrecedes = Prefixed_Name(pimsii, "logicallyPrecedes") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isJustificationFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isJustificationFor y) means that x is a grounding chain that provides epsitemic grounding for the cognition y, which thereby becomes a grounded cognition</para>
    /// labels<para>isJustificationFor</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isJustificationFor">http://www.molmod.info/semantics/pims-ii.ttl#isJustificationFor</seealso>
    let isJustificationFor = Prefixed_Name(pimsii, "isJustificationFor") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:GroundingStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Grounding step, i.e., a triadic cognition that establishes epistemic grounding</para>
    /// labels<para>GroundingStep</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingStep">http://www.molmod.info/semantics/pims-ii.ttl#GroundingStep</seealso>
    let GroundingStep = Prefixed_Name(pimsii, "GroundingStep") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:groundsPresentStepIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x groundsPresentStepIn y) == y is a grounding interpretation where x is the first element, i.e., a ground for the considered cognitive step</para>
    /// labels<para>groundsPresentStepIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#groundsPresentStepIn">http://www.molmod.info/semantics/pims-ii.ttl#groundsPresentStepIn</seealso>
    let groundsPresentStepIn =
        Prefixed_Name(pimsii, "groundsPresentStepIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isPresentStepInGrounding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isPresentStepInGrounding y) == y is a grounding interpretation where x is the second element, i.e., the considered cognitive step</para>
    /// labels<para>isPresentStepInGrounding</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isPresentStepInGrounding">http://www.molmod.info/semantics/pims-ii.ttl#isPresentStepInGrounding</seealso>
    let isPresentStepInGrounding =
        Prefixed_Name(pimsii, "isPresentStepInGrounding") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:GroundingMetonymization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Grounding metonymization, i.e., a metonymization where a the old referent is a cognitive step (i.e., the grounding step) that grounds another (i.e., the grounded step), which is the new referent; the referent for both is a ground (i.e., the grounding proposition) that is a ground for the grounded step</para>
    /// labels<para>GroundingMetonymization</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#GroundingMetonymization">http://www.molmod.info/semantics/pims-ii.ttl#GroundingMetonymization</seealso>
    let GroundingMetonymization =
        Prefixed_Name(pimsii, "GroundingMetonymization") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isGroundingPropositionIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isGroundingPropositionIn y) == y is a grounding step where x is the grounding proposition, i.e., the second element; therein, x is a ground for the grounded step, and x is also a ground for y itself</para>
    /// labels<para>isGroundingPropositionIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isGroundingPropositionIn">http://www.molmod.info/semantics/pims-ii.ttl#isGroundingPropositionIn</seealso>
    let isGroundingPropositionIn =
        Prefixed_Name(pimsii, "isGroundingPropositionIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:TriadicCognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Triadic cognition, i.e., a cognitive step of the type s-o-s' (semiosis) or o-s-o' (semantic change), thus containing three elements, in line with the approach by Peirce</para>
    /// labels<para>TriadicCognition</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#TriadicCognition">http://www.molmod.info/semantics/pims-ii.ttl#TriadicCognition</seealso>
    let TriadicCognition = Prefixed_Name(pimsii, "TriadicCognition") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isHeldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isHeldBy y) means that the claim x is consistently asserted by the knowledge base y whenever it is queried about it; if y extends significantly through time and changes opinion about x (i.e., it does not assert it consistently over the whole time), it cannot be said to hold x as a claim, merely to assert it; in this case, it may be advisable to define a (temporal) part y' of y which can then be said to hold x as a claim</para>
    /// labels<para>isHeldBy</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isHeldBy">http://www.molmod.info/semantics/pims-ii.ttl#isHeldBy</seealso>
    let isHeldBy = Prefixed_Name(pimsii, "isHeldBy") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isInitialStepIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isInitialStepIn y) means that y is a step in x (i.e., a subprocess of x) that is not preceded by any other step</para>
    /// labels<para>isInitialStepIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isInitialStepIn">http://www.molmod.info/semantics/pims-ii.ttl#isInitialStepIn</seealso>
    let isInitialStepIn = Prefixed_Name(pimsii, "isInitialStepIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isStepIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isStepIn y) means that x and y are processes, where x is a proper part of y that plays a well-defined role within y (e.g., a task within a project, the execution of a single command within the execution of a program, etc.)</para>
    /// labels<para>isStepIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isStepIn">http://www.molmod.info/semantics/pims-ii.ttl#isStepIn</seealso>
    let isStepIn = Prefixed_Name(pimsii, "isStepIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:CognitiveAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cognitive action, i.e., a cognition that is conducted/undertaken by an agent; the agent of a cognitive action is called its interpreter</para>
    /// labels<para>CognitiveAction</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#CognitiveAction">http://www.molmod.info/semantics/pims-ii.ttl#CognitiveAction</seealso>
    let CognitiveAction = Prefixed_Name(pimsii, "CognitiveAction") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Metonymization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metonymization, i.e., a semantic change where there is a causal connection between the old and the new referent, so that the criterion of a 'real causal connection' (between signs and objects) from Peircean semiotics is preserved</para>
    /// labels<para>Metonymization</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Metonymization">http://www.molmod.info/semantics/pims-ii.ttl#Metonymization</seealso>
    let Metonymization = Prefixed_Name(pimsii, "Metonymization") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Semiosis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Semiosis, i.e., a triadic congition that relates 'the sign', 'the object', and 'the interpretant' to each other; a semiosis is either a perception (if the object needs to be present and participate physically in the process) or an interpretation (if the physical participation of the object is not inherently necessary)</para>
    /// labels<para>Semiosis</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Semiosis">http://www.molmod.info/semantics/pims-ii.ttl#Semiosis</seealso>
    let Semiosis = Prefixed_Name(pimsii, "Semiosis") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>membership relation, i.e., relation between an item/member and a collective</para>
    /// labels<para>isMemberOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isMemberOf">http://www.molmod.info/semantics/pims-ii.ttl#isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(pimsii, "isMemberOf") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isOldReferentInMetonymization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isOldReferentInMetonymization y) == y is a metonymization where x acts as the old referent, i.e., the first element; the old and the new referent need to have a causal connection</para>
    /// labels<para>isOldReferentInMetonymization</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInMetonymization">http://www.molmod.info/semantics/pims-ii.ttl#isOldReferentInMetonymization</seealso>
    let isOldReferentInMetonymization =
        Prefixed_Name(pimsii, "isOldReferentInMetonymization") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isInformationProcessingOutputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isInformationProcessingOutputIn y) == y is an information-processing step where x is the output, i.e., the third element</para>
    /// labels<para>isInformationProcessingOutputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isInformationProcessingOutputIn">http://www.molmod.info/semantics/pims-ii.ttl#isInformationProcessingOutputIn</seealso>
    let isInformationProcessingOutputIn =
        Prefixed_Name(pimsii, "isInformationProcessingOutputIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isActionInSteering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isActionInSteering y) == y is a steering operation (reflection in actu) where x is an ongoing action, i.e., the second element, against which the telos is evaluated</para>
    /// labels<para>isActionInSteering</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isActionInSteering">http://www.molmod.info/semantics/pims-ii.ttl#isActionInSteering</seealso>
    let isActionInSteering = Prefixed_Name(pimsii, "isActionInSteering") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isResolutionInSteering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isResolutionInSteering y) == y is a steering operation (reflection in actu) where x is the resolution, i.e., the third element</para>
    /// labels<para>isResolutionInSteering</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInSteering">http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInSteering</seealso>
    let isResolutionInSteering =
        Prefixed_Name(pimsii, "isResolutionInSteering") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:msHRHRIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation hasRepresentamen o sharesRepresentamenWith</para>
    /// labels<para>msHRHRIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHRIR">http://www.molmod.info/semantics/pims-ii.ttl#msHRHRIR</seealso>
    let msHRHRIR = Prefixed_Name(pimsii, "msHRHRIR") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isResolutionInTelesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isResolutionInTelesis y) == y is a telesis where x acts as the resolution (a plan, revised objective, or other comparable sort of evaluation outcome), i.e., the third element</para>
    /// labels<para>isResolutionInTelesis</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInTelesis">http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInTelesis</seealso>
    let isResolutionInTelesis =
        Prefixed_Name(pimsii, "isResolutionInTelesis") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isMaximizationObjectiveIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isMaximizationObjectiveIn y) == x is a maximization objective/criterion considered in the optimization problem y</para>
    /// labels<para>isMaximizationObjectiveIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isMaximizationObjectiveIn">http://www.molmod.info/semantics/pims-ii.ttl#isMaximizationObjectiveIn</seealso>
    let isMaximizationObjectiveIn =
        Prefixed_Name(pimsii, "isMaximizationObjectiveIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isInterpretantInInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isInterpretantInInterpretation y) == y is an interpretation where x acts as the interpretant, i.e., the third element</para>
    /// labels<para>isInterpretantInInterpretation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantInInterpretation">http://www.molmod.info/semantics/pims-ii.ttl#isInterpretantInInterpretation</seealso>
    let isInterpretantInInterpretation =
        Prefixed_Name(pimsii, "isInterpretantInInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSignInInvestigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSignInInvestigation y) == y is an investigation-setup action where x acts as a representamen, i.e., the second element, both for the object of application (to which it is initially applied) and the object of investigation (to which it is reassigned such that the investigation can take place)</para>
    /// labels<para>isSignInInvestigation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSignInInvestigation">http://www.molmod.info/semantics/pims-ii.ttl#isSignInInvestigation</seealso>
    let isSignInInvestigation =
        Prefixed_Name(pimsii, "isSignInInvestigation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Item, i.e., a connected region of spacetime that does not consist of multiple connected components</para>
    /// labels<para>Item</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Item">http://www.molmod.info/semantics/pims-ii.ttl#Item</seealso>
    let Item = Prefixed_Name(pimsii, "Item") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:hasSubjectMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x hasSubjectMatter y) means that x is a proposition or articulation that addresses the topic or sum (i.e., plurality) of topics y, i.e., that has y as its subject matter</para>
    /// labels<para>hasSubjectMatter</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#hasSubjectMatter">http://www.molmod.info/semantics/pims-ii.ttl#hasSubjectMatter</seealso>
    let hasSubjectMatter = Prefixed_Name(pimsii, "hasSubjectMatter") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isMeasuredObjectIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isMeasuredObjectIn y) == y is a measurement where x acts as the object, i.e., the second element, that is subject to the measurement and for which a property is determined</para>
    /// labels<para>isMeasuredObjectIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isMeasuredObjectIn">http://www.molmod.info/semantics/pims-ii.ttl#isMeasuredObjectIn</seealso>
    let isMeasuredObjectIn = Prefixed_Name(pimsii, "isMeasuredObjectIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isTopicalSummandIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isTopicalSummandIn y) means that x is one of the topics contained in y, a collection of topics that are not immediately closely related to each other</para>
    /// labels<para>isTopicalSummandIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isTopicalSummandIn">http://www.molmod.info/semantics/pims-ii.ttl#isTopicalSummandIn</seealso>
    let isTopicalSummandIn = Prefixed_Name(pimsii, "isTopicalSummandIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Modelling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Modelling, i.e., an interpretation in which the sign is the basis for the modelling process (e.g., an unparameterized or previously parameterized model, knowledge about the modelled system, etc.), the object is the modelled system, and the interpretant is the modelling output (e.g., a parameterized model)</para>
    /// labels<para>Modelling</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Modelling">http://www.molmod.info/semantics/pims-ii.ttl#Modelling</seealso>
    let Modelling = Prefixed_Name(pimsii, "Modelling") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSituationInUndertaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSituationInUndertaking y) == y is an undertaking wherein x is the pre-existing situation, i.e., the first element</para>
    /// labels<para>isSituationInUndertaking</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSituationInUndertaking">http://www.molmod.info/semantics/pims-ii.ttl#isSituationInUndertaking</seealso>
    let isSituationInUndertaking =
        Prefixed_Name(pimsii, "isSituationInUndertaking") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isResolutionInUndertaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isResolutionInUndertaking y) == y is an undertaking where x is the resolution (obtained from a previous telesis), i.e., the second element</para>
    /// labels<para>isResolutionInUndertaking</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInUndertaking">http://www.molmod.info/semantics/pims-ii.ttl#isResolutionInUndertaking</seealso>
    let isResolutionInUndertaking =
        Prefixed_Name(pimsii, "isResolutionInUndertaking") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isActionInUndertaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isActionInUndertaking y) == y is an undertaking where x is the action that is undertaken, i.e., the third element</para>
    /// labels<para>isActionInUndertaking</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isActionInUndertaking">http://www.molmod.info/semantics/pims-ii.ttl#isActionInUndertaking</seealso>
    let isActionInUndertaking =
        Prefixed_Name(pimsii, "isActionInUndertaking") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isLiterally</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>points to the expression of a collective literal as an RDFS literal (e.g., xs:string or xs:decimal)</para>
    /// labels<para>isLiterally</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isLiterally">http://www.molmod.info/semantics/pims-ii.ttl#isLiterally</seealso>
    let isLiterally = Prefixed_Name(pimsii, "isLiterally") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Validation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Validation, i.e., an evaluation of a cognition yielding a validity claim as its interpretant</para>
    /// labels<para>Validation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Validation">http://www.molmod.info/semantics/pims-ii.ttl#Validation</seealso>
    let Validation = Prefixed_Name(pimsii, "Validation") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Communication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Communication, i.e., a cognitive process wherein multiple interlocutors engage in an exchange with another; a communication involves at least one expressive act (with a well defined role, i.e. in terms of participation)</para>
    /// labels<para>Communication</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Communication">http://www.molmod.info/semantics/pims-ii.ttl#Communication</seealso>
    let Communication = Prefixed_Name(pimsii, "Communication") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:ConceptualIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Conceptual IRI, i.e., the internationalized resource identifier of a concept (i.e., of an owl:Class)</para>
    /// labels<para>ConceptualIRI</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ConceptualIRI">http://www.molmod.info/semantics/pims-ii.ttl#ConceptualIRI</seealso>
    let ConceptualIRI = Prefixed_Name(pimsii, "ConceptualIRI") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:OptimizationProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Optimization problem, i.e., an intention expressed or expressible in terms of one or multiple objectives (objective space) and one or multiple design parameters (parameter space)</para>
    /// labels<para>OptimizationProblem</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#OptimizationProblem">http://www.molmod.info/semantics/pims-ii.ttl#OptimizationProblem</seealso>
    let OptimizationProblem =
        Prefixed_Name(pimsii, "OptimizationProblem") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isRepresentamenIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isRepresentamenIn y) == x participates in the cognitive step y in the role of the/a representamen</para>
    /// labels<para>isRepresentamenIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isRepresentamenIn">http://www.molmod.info/semantics/pims-ii.ttl#isRepresentamenIn</seealso>
    let isRepresentamenIn = Prefixed_Name(pimsii, "isRepresentamenIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isParticipantIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isParticipantIn y) means that y is a process in which x plays a certain role (e.g., x is a well-defined step within y, or x is an object that undergoes some change within y, or x is a sign that is read or an object that is perceived within y); this requires a spatiotemporal overlap between x and y</para>
    /// labels<para>isParticipantIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isParticipantIn">http://www.molmod.info/semantics/pims-ii.ttl#isParticipantIn</seealso>
    let isParticipantIn = Prefixed_Name(pimsii, "isParticipantIn") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:ContextualIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contextual IRI, i.e., the internationalized resource identifier of a modal context, i.e., the frame of reference for a qualified-modal semiotic collective; that context defines how exactly necessity and possibility are to be understood</para>
    /// labels<para>ContextualIRI</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ContextualIRI">http://www.molmod.info/semantics/pims-ii.ttl#ContextualIRI</seealso>
    let ContextualIRI = Prefixed_Name(pimsii, "ContextualIRI") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:ConcreteModelPropertyClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concrete model property claim (CMPC), i.e., a model property claim that is immediately also applied to the corresponding property of a real physical system</para>
    /// labels<para>ConcretePropertyClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ConcreteModelPropertyClaim">http://www.molmod.info/semantics/pims-ii.ttl#ConcreteModelPropertyClaim</seealso>
    let ConcreteModelPropertyClaim =
        Prefixed_Name(pimsii, "ConcreteModelPropertyClaim") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:PhysicalPropertyClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Physical property claim (PPC), i.e., a PC concerning a property of a physical system</para>
    /// labels<para>PropertyClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#PhysicalPropertyClaim">http://www.molmod.info/semantics/pims-ii.ttl#PhysicalPropertyClaim</seealso>
    let PhysicalPropertyClaim =
        Prefixed_Name(pimsii, "PhysicalPropertyClaim") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:hasImproperPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>Spatiotemporal (mereological) improper parthood relation; in other words, it is the reflexive closure of proper parthood: (x hasImproperPart y) means that all points within y are also within x</para>
    /// labels<para>hasImproperPart</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#hasImproperPart">http://www.molmod.info/semantics/pims-ii.ttl#hasImproperPart</seealso>
    let hasImproperPart = Prefixed_Name(pimsii, "hasImproperPart") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:hasNegation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x hasNegation y) means that x and y are IRIs that can possibly occur in the predicate (middle) position of a triple, and that y is 'not x'; n.b., this is not a symmetrical relation, since 'not not x' is syntactically different from x</para>
    /// labels<para>hasNegation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#hasNegation">http://www.molmod.info/semantics/pims-ii.ttl#hasNegation</seealso>
    let hasNegation = Prefixed_Name(pimsii, "hasNegation") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Person, i.e., an interlocutor that is socially identified as a natural or legal person by social convention that involves using a name (or multiple names) for it as rigid designators</para>
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Person">http://www.molmod.info/semantics/pims-ii.ttl#Person</seealso>
    let Person = Prefixed_Name(pimsii, "Person") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:overlapsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>(x overlapsWith y) means that x and y share a spatiotemporal region where x and y intersect</para>
    /// labels<para>overlapsWith</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#overlapsWith">http://www.molmod.info/semantics/pims-ii.ttl#overlapsWith</seealso>
    let overlapsWith = Prefixed_Name(pimsii, "overlapsWith") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isImproperPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Spatiotemporal (mereological) improper parthood relation; in other words, it is the reflexive closure of proper parthood: (x isImproperPartOf y) means that all points within x are also within y</para>
    /// labels<para>isImproperPartOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isImproperPartOf">http://www.molmod.info/semantics/pims-ii.ttl#isImproperPartOf</seealso>
    let isImproperPartOf = Prefixed_Name(pimsii, "isImproperPartOf") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:hasQualifiedNecessityMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x hasQualifiedNecessityMode y) means that x is a relational IRI and y is a qualified modal IRI for 'necessarily x'</para>
    /// labels<para>hasQualifiedNecessityMode</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#hasQualifiedNecessityMode">http://www.molmod.info/semantics/pims-ii.ttl#hasQualifiedNecessityMode</seealso>
    let hasQualifiedNecessityMode =
        Prefixed_Name(pimsii, "hasQualifiedNecessityMode") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:hasQualifiedPossibilityMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x hasQualifiedPossibilityMode y) means that x is a relational IRI and y is a qualified modal IRI for 'possibly x'</para>
    /// labels<para>hasQualifiedPossibilityMode</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#hasQualifiedPossibilityMode">http://www.molmod.info/semantics/pims-ii.ttl#hasQualifiedPossibilityMode</seealso>
    let hasQualifiedPossibilityMode =
        Prefixed_Name(pimsii, "hasQualifiedPossibilityMode") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:hasRepresentamen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Dyadic representation relation; (x hasRepresentamen y) means that there is a cognitive step z such that (x isReferentIn z) and (y isRepresentamenIn z)</para>
    /// labels<para>hasRepresentamen</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#hasRepresentamen">http://www.molmod.info/semantics/pims-ii.ttl#hasRepresentamen</seealso>
    let hasRepresentamen = Prefixed_Name(pimsii, "hasRepresentamen") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRHPIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msHRHPIP Z) == hasRepresentamen o hasProperPart o isProperPartOf == there is a Y such that (Y isRepresentamenFor X) and (Y overlapsWith Z)</para>
    /// labels<para>msHRHPIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIP">http://www.molmod.info/semantics/pims-ii.ttl#msHRHPIP</seealso>
    let msHRHPIP = Prefixed_Name(pimsii, "msHRHPIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIPHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msHPIPHR Z) == hasProperPart o isProperPartOf o hasRepresentamen == there is a Y such that (X overlapsWith Y) and (Z isRepresentamenFor Y)</para>
    /// labels<para>msHPIPHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHR">http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHR</seealso>
    let msHPIPHR = Prefixed_Name(pimsii, "msHPIPHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHRIRHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation hasRepresentamen o sharesReferentWith</para>
    /// labels<para>msHRIRHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHR">http://www.molmod.info/semantics/pims-ii.ttl#msHRIRHR</seealso>
    let msHRIRHR = Prefixed_Name(pimsii, "msHRIRHR") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isAccumulationConditionIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isAccumulationConditionIn y) == in the accumulation process y, the condition x controls in what way the input and the additionally included elements interact to yield a combined output</para>
    /// labels<para>isAccumulationConditionIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationConditionIn">http://www.molmod.info/semantics/pims-ii.ttl#isAccumulationConditionIn</seealso>
    let isAccumulationConditionIn =
        Prefixed_Name(pimsii, "isAccumulationConditionIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isProperParticipantIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isProperParticipantIn y) is the conjunction of (x isProperPartOf y) and (x isParticipantIn y)</para>
    /// labels<para>isProperParticipantIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isProperParticipantIn">http://www.molmod.info/semantics/pims-ii.ttl#isProperParticipantIn</seealso>
    let isProperParticipantIn =
        Prefixed_Name(pimsii, "isProperParticipantIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:msHPIPIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(X msHPIPIR Z) == hasProperPart o isProperPartOf o isRepresentamenFor == there is a Y such that (X overlapsWith Y) and (Y isRepresentamenFor Z)</para>
    /// labels<para>msHPIPIR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIR">http://www.molmod.info/semantics/pims-ii.ttl#msHPIPIR</seealso>
    let msHPIPIR = Prefixed_Name(pimsii, "msHPIPIR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isExpressedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isExpressedBy y) means that x is expressed/stated/uttered by the interlocutor y; n.b., this does not necessarily mean that y affirms x (for that, use the subproperty isAssertedBy)</para>
    /// labels<para>isExpressedBy</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isExpressedBy">http://www.molmod.info/semantics/pims-ii.ttl#isExpressedBy</seealso>
    let isExpressedBy = Prefixed_Name(pimsii, "isExpressedBy") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isAssertedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isAssertedIn y) means that x is a claim that is affirmatively expressed/stated/uttered in the expressive act y (by its speaker)</para>
    /// labels<para>isAssertedIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isAssertedIn">http://www.molmod.info/semantics/pims-ii.ttl#isAssertedIn</seealso>
    let isAssertedIn = Prefixed_Name(pimsii, "isAssertedIn") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isCausallyDisconnectedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>(x isCausallyDisconnectedFrom y) means that between x and y there is no 'real causal connection' in the Peircean sense; therefore, x and y cannot be the old and new referents in a metonymization; similarly, x cannot act as a representamen for y in a grounded cognition (if it does, then the cognition is not grounded)</para>
    /// labels<para>isCausallyDisconnectedFrom</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isCausallyDisconnectedFrom">http://www.molmod.info/semantics/pims-ii.ttl#isCausallyDisconnectedFrom</seealso>
    let isCausallyDisconnectedFrom =
        Prefixed_Name(pimsii, "isCausallyDisconnectedFrom") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isSemioticallyConstitutiveOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isSemioticallyConstitutiveOf y) means that the evaluation or association with x plays a role in the way in which y functions as a representamen - n.b, this does not entail physical parthood; e.g., if 'q = 2f(p)' is given, the expression 'f(p) = ... (some term involving q)' may be seen as semiotically constituive of the first expression, precisely because it contains the right-hand side that was missing</para>
    /// labels<para>isSemioticallyConstitutiveOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isSemioticallyConstitutiveOf">http://www.molmod.info/semantics/pims-ii.ttl#isSemioticallyConstitutiveOf</seealso>
    let isSemioticallyConstitutiveOf =
        Prefixed_Name(pimsii, "isSemioticallyConstitutiveOf") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dataset, i.e., a digital articulation that is composed of multiple data items that are similar in shape, kind, and content type</para>
    /// labels<para>Dataset</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Dataset">http://www.molmod.info/semantics/pims-ii.ttl#Dataset</seealso>
    let Dataset = Prefixed_Name(pimsii, "Dataset") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:ProofBasedValidityClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Proof-based validity claim (PVC), i.e., a validity claim obtained by formal verification, i.e., by deductive logical and mathematical reasoning</para>
    /// labels<para>ProofBasedValidityClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#ProofBasedValidityClaim">http://www.molmod.info/semantics/pims-ii.ttl#ProofBasedValidityClaim</seealso>
    let ProofBasedValidityClaim =
        Prefixed_Name(pimsii, "ProofBasedValidityClaim") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Property, i.e., a variable that is employed for the possible outcome of observations and similar processes (this may include different words used for the same property, in one or multiple languages, and different ways of expressing these words)</para>
    /// labels<para>Property</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Property">http://www.molmod.info/semantics/pims-ii.ttl#Property</seealso>
    let Property = Prefixed_Name(pimsii, "Property") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:TestBasedValidityClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Test-based validity claim (TVC), i.e., a validity claim obtained from validation or testing</para>
    /// labels<para>TestBasedValidityClaim</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#TestBasedValidityClaim">http://www.molmod.info/semantics/pims-ii.ttl#TestBasedValidityClaim</seealso>
    let TestBasedValidityClaim =
        Prefixed_Name(pimsii, "TestBasedValidityClaim") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isAbout y) means that x is a proposition and y is the object that x is related to by aboutness</para>
    /// labels<para>isAbout</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isAbout">http://www.molmod.info/semantics/pims-ii.ttl#isAbout</seealso>
    let isAbout = Prefixed_Name(pimsii, "isAbout") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isContextWithinLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isContextWithinLaw y) means that x is an IRI for the modal context of relatively necessary implication in the relative law y</para>
    /// labels<para>isContextWithinLaw</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isContextWithinLaw">http://www.molmod.info/semantics/pims-ii.ttl#isContextWithinLaw</seealso>
    let isContextWithinLaw = Prefixed_Name(pimsii, "isContextWithinLaw") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isContextOfRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isContextOfRelation y) means that x is an IRI for the modal context of qualified possibility/necessity in the relative modal IRI y</para>
    /// labels<para>isContextOfRelation</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isContextOfRelation">http://www.molmod.info/semantics/pims-ii.ttl#isContextOfRelation</seealso>
    let isContextOfRelation =
        Prefixed_Name(pimsii, "isContextOfRelation") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:QuantityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Quantity value, i.e., a value that has a numerical magnitude and a physical unit</para>
    /// labels<para>QuantityValue</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#QuantityValue">http://www.molmod.info/semantics/pims-ii.ttl#QuantityValue</seealso>
    let QuantityValue = Prefixed_Name(pimsii, "QuantityValue") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:isUnitOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isUnitOf y) means that x is the unit of y, e.g., in 200 kPa, x would be kPa</para>
    /// labels<para>isUnitOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isUnitOf">http://www.molmod.info/semantics/pims-ii.ttl#isUnitOf</seealso>
    let isUnitOf = Prefixed_Name(pimsii, "isUnitOf") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Topical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Topical proposition, i.e., something that can be understood as stating the topic of something</para>
    /// labels<para>Topical</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Topical">http://www.molmod.info/semantics/pims-ii.ttl#Topical</seealso>
    let Topical = Prefixed_Name(pimsii, "Topical") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:RationalAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A rational agent is an intelligent agent that exhibits rationality, i.e., a tendency toward maximizing a quantity: The performance measure of the agent.</para>
    /// labels<para>RationalAgent</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#RationalAgent">http://www.molmod.info/semantics/pims-ii.ttl#RationalAgent</seealso>
    let RationalAgent = Prefixed_Name(pimsii, "RationalAgent") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isPerformanceMeasureOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isPerformanceMeasureOf y) means that x is the single/unique performance measure of the rational agent y.</para>
    /// labels<para>isPerformanceMeasureOf</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isPerformanceMeasureOf">http://www.molmod.info/semantics/pims-ii.ttl#isPerformanceMeasureOf</seealso>
    let isPerformanceMeasureOf =
        Prefixed_Name(pimsii, "isPerformanceMeasureOf") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:msHPHRHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHPHR o hasRepresentamen</para>
    /// labels<para>msHPHRHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHR">http://www.molmod.info/semantics/pims-ii.ttl#msHPHRHR</seealso>
    let msHPHRHR = Prefixed_Name(pimsii, "msHPHRHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPIPHRHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation overlapsWith o msHRHR</para>
    /// labels<para>msHPIPHRHR</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRHR">http://www.molmod.info/semantics/pims-ii.ttl#msHPIPHRHR</seealso>
    let msHPIPHRHR = Prefixed_Name(pimsii, "msHPIPHRHR") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msIRIRIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msIRIR o isProperPartOf</para>
    /// labels<para>msIRIRIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msIRIRIP">http://www.molmod.info/semantics/pims-ii.ttl#msIRIRIP</seealso>
    let msIRIRIP = Prefixed_Name(pimsii, "msIRIRIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:msHPHRIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>chain relation msHPHR o hasProperPart</para>
    /// labels<para>msHPHRIP</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#msHPHRIP">http://www.molmod.info/semantics/pims-ii.ttl#msHPHRIP</seealso>
    let msHPHRIP = Prefixed_Name(pimsii, "msHPHRIP") |> PrefixedName
    /// <summary>
    ///   <para>pimsii:Number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Number, i.e., a lexeme that is numerical in nature, such as the collective containing realizations of 'two', '2', and '2.0'</para>
    /// labels<para>Number</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#Number">http://www.molmod.info/semantics/pims-ii.ttl#Number</seealso>
    let Number = Prefixed_Name(pimsii, "Number") |> PrefixedName

    /// <summary>
    ///   <para>pimsii:isVisualizationOutputIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(x isVisualizationOutputIn y) == y is a visualization where x is the visualization output, i.e., the third element</para>
    /// labels<para>isVisualizationOutputIn</para></remarks>
    /// <seealso href="http://www.molmod.info/semantics/pims-ii.ttl#isVisualizationOutputIn">http://www.molmod.info/semantics/pims-ii.ttl#isVisualizationOutputIn</seealso>
    let isVisualizationOutputIn =
        Prefixed_Name(pimsii, "isVisualizationOutputIn") |> PrefixedName
