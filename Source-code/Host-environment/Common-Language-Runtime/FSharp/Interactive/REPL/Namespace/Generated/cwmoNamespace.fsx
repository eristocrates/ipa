#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cwmo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/cwmo/#" "cwmo"
    let _namespaceIri = _prefixId.prefix ""
    let ABTesting = _prefixId.prefix "ABTesting"
    let AM = _prefixId.prefix "AM"
    /// <summary>
    ///   <para>rdfs:label : Activity</para>
    ///   <para>rdfs:comment : The activity class gather the different activities realised during a creative workshop</para>
    ///   <a href="http://purl.org/cwmo/#Activity">cwmo:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:label : Advice</para>
    ///   <para>rdfs:comment : The advice is provided by the expert to a creative team and can concern an idea or a technique.</para>
    ///   <a href="http://purl.org/cwmo/#Advice">cwmo:Advice</a>
    /// </summary>
    let Advice = _prefixId.prefix "Advice"
    let AffinityDiagramming = _prefixId.prefix "AffinityDiagramming"
    let Anon3 = _prefixId.prefix "Anon3"
    /// <summary>
    ///   <para>rdfs:label : Application Mode</para>
    ///   <para>rdfs:comment : The application mode class defined the different mode of application of a creative technique</para>
    ///   <a href="http://purl.org/cwmo/#ApplicationMode">cwmo:ApplicationMode</a>
    /// </summary>
    let ApplicationMode = _prefixId.prefix "ApplicationMode"
    /// <summary>
    ///   <para>rdfs:label : Artifact</para>
    ///   <para>rdfs:comment : The artefact class is a visual or physical representation of an idea.</para>
    ///   <a href="http://purl.org/cwmo/#Artifact">cwmo:Artifact</a>
    /// </summary>
    let Artifact = _prefixId.prefix "Artifact"
    let Attitudinal = _prefixId.prefix "Attitudinal"
    let Behavioral = _prefixId.prefix "Behavioral"
    let BendItShapeIt = _prefixId.prefix "BendItShapeIt"
    let Bodystorming = _prefixId.prefix "Bodystorming"
    let BrainstormGraphicOrganizers = _prefixId.prefix "BrainstormGraphicOrganizers"
    let Coggle = _prefixId.prefix "Coggle"
    let Collage = _prefixId.prefix "Collage"
    let CollectiveMode = _prefixId.prefix "CollectiveMode"
    let Completeness = _prefixId.prefix "Completeness"
    let Complexity = _prefixId.prefix "Complexity"
    let ConceptGeneration = _prefixId.prefix "ConceptGeneration"
    let ConceptMapping = _prefixId.prefix "ConceptMapping"
    /// <summary>
    ///   <para>rdfs:label : Constraint</para>
    ///   <para>rdfs:comment : The constraint class is the textual description of the element that limit the subject. It is related to the strategy of the company, the constraint associated with the activity domain of the organizations, …</para>
    ///   <a href="http://purl.org/cwmo/#Constraint">cwmo:Constraint</a>
    /// </summary>
    let Constraint = _prefixId.prefix "Constraint"
    /// <summary>
    ///   <para>rdfs:label : Context</para>
    ///   <para>rdfs:comment : organizational condition in wich the problem is defined (Stratégique, Nouveau produit, processus ou service, Améliorations produit, processus ou service, publicité/marketing, Ressources humaines)</para>
    ///   <a href="http://purl.org/cwmo/#Context">cwmo:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>rdfs:label : Context Type</para>
    ///   <para>rdfs:comment : The context type class gather the typology of creative workshop context</para>
    ///   <a href="http://purl.org/cwmo/#ContextType">cwmo:ContextType</a>
    /// </summary>
    let ContextType = _prefixId.prefix "ContextType"
    let ContextualDesign = _prefixId.prefix "ContextualDesign"
    /// <summary>
    ///   <para>rdfs:label : Creative Phase</para>
    ///   <para>rdfs:comment : The creative phase class is the decompastion of the creative process into steps/ phases which implies different nature of activities, goals and interaction.</para>
    ///   <a href="http://purl.org/cwmo/#CreativePhase">cwmo:CreativePhase</a>
    /// </summary>
    let CreativePhase = _prefixId.prefix "CreativePhase"
    /// <summary>
    ///   <para>rdfs:label : Creative Strategy</para>
    ///   <para>rdfs:comment : The creative strategy is a selection of creative techniques defined by the a facilitator in order to respond to the subject</para>
    ///   <a href="http://purl.org/cwmo/#CreativeStrategy">cwmo:CreativeStrategy</a>
    /// </summary>
    let CreativeStrategy = _prefixId.prefix "CreativeStrategy"
    /// <summary>
    ///   <para>rdfs:label : Creative Team</para>
    ///   <para>rdfs:comment : The creative team class is a group of ideator who attempt to generated ideas to respond a problematic</para>
    ///   <a href="http://purl.org/cwmo/#CreativeTeam">cwmo:CreativeTeam</a>
    /// </summary>
    let CreativeTeam = _prefixId.prefix "CreativeTeam"
    /// <summary>
    ///   <para>rdfs:label : Creative Technique</para>
    ///   <para>rdfs:comment : The creativre technic class is the technic applied by the ideator to generated ideas</para>
    ///   <a href="http://purl.org/cwmo/#CreativeTechnique">cwmo:CreativeTechnique</a>
    /// </summary>
    let CreativeTechnique = _prefixId.prefix "CreativeTechnique"
    /// <summary>
    ///   <para>rdfs:label : CreativeWorkshop</para>
    ///   <para>rdfs:comment : The CreativeWorkshop class  represent an event organized by an organizer to solve a problem formulated into a subject and provided by a decision-maker, and solved by a creative team.</para>
    ///   <a href="http://purl.org/cwmo/#CreativeWorkshop">cwmo:CreativeWorkshop</a>
    /// </summary>
    let CreativeWorkshop = _prefixId.prefix "CreativeWorkshop"
    /// <summary>
    ///   <para>rdfs:label : Data Type</para>
    ///   <para>rdfs:comment : Data type class define the form in which that content is typically collected and communicated.</para>
    ///   <a href="http://purl.org/cwmo/#DataType">cwmo:DataType</a>
    /// </summary>
    let DataType = _prefixId.prefix "DataType"
    /// <summary>
    ///   <para>rdfs:label : Decision Maker</para>
    ///   <para>rdfs:comment : Decision Maker is one of the role assumed by a person during the creative workshop. He provides the problem to solve during the workshop and has the decision ability concerning the future of the idea generated.</para>
    ///   <a href="http://purl.org/cwmo/#DecisionMaker">cwmo:DecisionMaker</a>
    /// </summary>
    let DecisionMaker = _prefixId.prefix "DecisionMaker"
    let Definition = _prefixId.prefix "Definition"
    let DesignProcess = _prefixId.prefix "DesignProcess"
    /// <summary>
    ///   <para>rdfs:label : Digital Tools</para>
    ///   <para>rdfs:comment : The digital tools class gather the tools available for a digital application of creative techniques</para>
    ///   <a href="http://purl.org/cwmo/#DigitalTool">cwmo:DigitalTool</a>
    /// </summary>
    let DigitalTool = _prefixId.prefix "DigitalTool"
    let Effectivness = _prefixId.prefix "Effectivness"
    /// <summary>
    ///   <para>rdfs:label : Equipment</para>
    ///   <para>rdfs:comment : The material class represent the physical material/ equipment needed.</para>
    ///   <a href="http://purl.org/cwmo/#Equipment">cwmo:Equipment</a>
    /// </summary>
    let Equipment = _prefixId.prefix "Equipment"
    let EvalAndRafinement = _prefixId.prefix "EvalAndRafinement"
    let Evaluation = _prefixId.prefix "Evaluation"
    /// <summary>
    ///   <para>rdfs:label : Evaluation Criteria</para>
    ///   <para>rdfs:comment : The Evaluation criteria class is the specific aspect to obsverve on idea. It is defined according to the constraints of the subject.</para>
    ///   <a href="http://purl.org/cwmo/#EvaluationCriteria">cwmo:EvaluationCriteria</a>
    /// </summary>
    let EvaluationCriteria = _prefixId.prefix "EvaluationCriteria"
    /// <summary>
    ///   <para>rdfs:label : Evaluation Strategy</para>
    ///   <para>rdfs:comment : The evaluation strategy class gather the information concerning the evaluation technics, the criteria, and the evaluators affected to respond to the objectives of the creative workshop.</para>
    ///   <a href="http://purl.org/cwmo/#EvaluationStrategy">cwmo:EvaluationStrategy</a>
    /// </summary>
    let EvaluationStrategy = _prefixId.prefix "EvaluationStrategy"
    /// <summary>
    ///   <para>rdfs:label : Evaluation Technic</para>
    ///   <para>rdfs:comment : The evaluation technic class is the way the idea is evaluated. It can be qualitative (Review, sorting (top5),...) or quantitative (rating).</para>
    ///   <a href="http://purl.org/cwmo/#EvaluationTechnic">cwmo:EvaluationTechnic</a>
    /// </summary>
    let EvaluationTechnic = _prefixId.prefix "EvaluationTechnic"
    /// <summary>
    ///   <para>rdfs:label : Evaluator</para>
    ///   <para>rdfs:comment : Evaluator is one of the role assumed by a person during the creative workshop. He evaluate the ideas based on the evaluation strategy according to the evaluation techniques and the criteria associated.</para>
    ///   <a href="http://purl.org/cwmo/#Evaluator">cwmo:Evaluator</a>
    /// </summary>
    let Evaluator = _prefixId.prefix "Evaluator"
    let ExperiencePrototyping = _prefixId.prefix "ExperiencePrototyping"
    let Experiment = _prefixId.prefix "Experiment"
    /// <summary>
    ///   <para>rdfs:label : Expert</para>
    ///   <para>rdfs:comment : Expert is one of the role assumed by a person during the creative workshop. He share his knowledge about the problem or the domain to helps the ideator or the evaluation.</para>
    ///   <a href="http://purl.org/cwmo/#Expert">cwmo:Expert</a>
    /// </summary>
    let Expert = _prefixId.prefix "Expert"
    let Exploration = _prefixId.prefix "Exploration"
    /// <summary>
    ///   <para>rdfs:label : Expression Moderdfs:label : The expression mode class define the different mode of experssion exploited by a creative technique</para>
    ///   <a href="http://purl.org/cwmo/#ExpressionMode">cwmo:ExpressionMode</a>
    /// </summary>
    let ExpressionMode = _prefixId.prefix "ExpressionMode"
    let Expressivness = _prefixId.prefix "Expressivness"
    /// <summary>
    ///   <para>rdfs:label : Facilitator</para>
    ///   <para>rdfs:comment : Facilitator is one of the role assumed by a person during the creative workshop. He is the person who assist the group of ideator in the application of the activities (creative technique and evaluation technique)</para>
    ///   <a href="http://purl.org/cwmo/#Facilitator">cwmo:Facilitator</a>
    /// </summary>
    let Facilitator = _prefixId.prefix "Facilitator"
    let Feasibility = _prefixId.prefix "Feasibility"
    let FreeReview = _prefixId.prefix "FreeReview"
    let Generation = _prefixId.prefix "Generation"
    let GuidedReview = _prefixId.prefix "GuidedReview"
    /// <summary>
    ///   <para>rdfs:label : Idea</para>
    ///   <para>rdfs:comment : The idea class is a beginning of response to the problem. An idea can be from a Creative technic</para>
    ///   <a href="http://purl.org/cwmo/#Idea">cwmo:Idea</a>
    /// </summary>
    let Idea = _prefixId.prefix "Idea"
    let IdeaEvaluation = _prefixId.prefix "IdeaEvaluation"
    let Ideation = _prefixId.prefix "Ideation"
    /// <summary>
    ///   <para>rdfs:label : Ideator</para>
    ///   <para>rdfs:comment : Ideator is one of the role assumed by a person during the creative workshop. He is the person who solve the problem and produce ideas by applying creative techniques</para>
    ///   <a href="http://purl.org/cwmo/#Ideator">cwmo:Ideator</a>
    /// </summary>
    let Ideator = _prefixId.prefix "Ideator"
    let ImplementAndMonitoring = _prefixId.prefix "ImplementAndMonitoring"
    let Implementability = _prefixId.prefix "Implementability"
    let Implementation = _prefixId.prefix "Implementation"
    let IndividualMode = _prefixId.prefix "IndividualMode"
    /// <summary>
    ///   <para>rdfs:label : Input Type</para>
    ///   <para>rdfs:comment : type of centent most appropriatly targeted by the method</para>
    ///   <a href="http://purl.org/cwmo/#InputType">cwmo:InputType</a>
    /// </summary>
    let InputType = _prefixId.prefix "InputType"
    let KJTechnique = _prefixId.prefix "KJTechnique"
    let KeyPerfIndicator = _prefixId.prefix "KeyPerfIndicator"
    /// <summary>
    ///   <para>rdfs:label : Knowledge Domain</para>
    ///   <para>rdfs:comment : The Knowledge domain class is the overall knowledge that a person posses or which is associated to an idea or a problem</para>
    ///   <a href="http://purl.org/cwmo/#KnowledgeDomain">cwmo:KnowledgeDomain</a>
    /// </summary>
    let KnowledgeDomain = _prefixId.prefix "KnowledgeDomain"
    let MindMapping = _prefixId.prefix "MindMapping"
    let NPD = _prefixId.prefix "NPD"
    /// <summary>
    ///   <para>rdfs:label : Objective</para>
    ///   <para>rdfs:comment : The objective is a description of the result expected by the organizations concerning the creative workshop</para>
    ///   <a href="http://purl.org/cwmo/#Objective">cwmo:Objective</a>
    /// </summary>
    let Objective = _prefixId.prefix "Objective"
    /// <summary>
    ///   <para>rdfs:label : Organization</para>
    ///   <para>rdfs:comment : An organization such as a company, SME, institutions, NGO, corporation,  etc.</para>
    ///   <a href="http://purl.org/cwmo/#Organization">cwmo:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:label : Organizer</para>
    ///   <para>rdfs:comment : Organizer is one of the role assumed by a person during the creative workshop. He is the person who manage the entre workshop by providing the materials, the infrastructure and communicate with the others persons.</para>
    ///   <a href="http://purl.org/cwmo/#Organizer">cwmo:Organizer</a>
    /// </summary>
    let Organizer = _prefixId.prefix "Organizer"
    let Originality = _prefixId.prefix "Originality"
    let PSI = _prefixId.prefix "PSI"
    /// <summary>
    ///   <para>rdfs:label : Participant Role</para>
    ///   <para>rdfs:comment : The particpant role class define the role of the person involved in a creative technique. (Martin et al., 2013). It should be distinguished from the role involved in the entire creative workshop process.</para>
    ///   <a href="http://purl.org/cwmo/#ParticipantRole">cwmo:ParticipantRole</a>
    /// </summary>
    let ParticipantRole = _prefixId.prefix "ParticipantRole"
    let Participatory = _prefixId.prefix "Participatory"
    let Personas = _prefixId.prefix "Personas"
    let PostIt = _prefixId.prefix "PostIt"
    /// <summary>
    ///   <para>rdfs:label : Problem</para>
    ///   <para>rdfs:comment : The problem class is the description of the elements that leads the organization to initiate a creative workshop.</para>
    ///   <a href="http://purl.org/cwmo/#Problem">cwmo:Problem</a>
    /// </summary>
    let Problem = _prefixId.prefix "Problem"
    let ProblemAnalysis = _prefixId.prefix "ProblemAnalysis"
    let QualitativeData = _prefixId.prefix "QualitativeData"
    let QuantitativeData = _prefixId.prefix "QuantitativeData"
    let Related = _prefixId.prefix "Related"
    let Relevance = _prefixId.prefix "Relevance"
    let Roleplaying = _prefixId.prefix "Roleplaying"
    let Scenarios = _prefixId.prefix "Scenarios"
    let SimulationExercise = _prefixId.prefix "SimulationExercise"
    /// <summary>
    ///   <para>rdfs:label : Stimuli</para>
    ///   <para>rdfs:comment : Stimuli is used to initiate a creative technique</para>
    ///   <a href="http://purl.org/cwmo/#Stimuli">cwmo:Stimuli</a>
    /// </summary>
    let Stimuli = _prefixId.prefix "Stimuli"
    /// <summary>
    ///   <para>rdfs:label : Stimuli Type</para>
    ///   <para>rdfs:comment : Typology of stimuli</para>
    ///   <a href="http://purl.org/cwmo/#StimuliType">cwmo:StimuliType</a>
    /// </summary>
    let StimuliType = _prefixId.prefix "StimuliType"
    let Strategy = _prefixId.prefix "Strategy"
    /// <summary>
    ///   <para>rdfs:label : Subject</para>
    ///   <para>rdfs:comment : The subject class is the description of the problerm to solve by the creative group during the creative workshop. It is a transformation/reformulation of the problem.</para>
    ///   <a href="http://purl.org/cwmo/#Subject">cwmo:Subject</a>
    /// </summary>
    let Subject = _prefixId.prefix "Subject"
    let Synthesis = _prefixId.prefix "Synthesis"
    /// <summary>
    ///   <para>rdfs:label : Technique Function</para>
    ///   <para>rdfs:comment : Technique Function class define the primary purpose of a creative technique.</para>
    ///   <a href="http://purl.org/cwmo/#TechniqueFunction">cwmo:TechniqueFunction</a>
    /// </summary>
    let TechniqueFunction = _prefixId.prefix "TechniqueFunction"
    /// <summary>
    ///   <para>rdfs:label : Tool</para>
    ///   <para>rdfs:comment : The tool class is the software and interface used to ease the application of a creative technic and/or collect the data of the creative technic.</para>
    ///   <a href="http://purl.org/cwmo/#Tool">cwmo:Tool</a>
    /// </summary>
    let Tool = _prefixId.prefix "Tool"
    let Unrelated = _prefixId.prefix "Unrelated"
    let UsabilityTesting = _prefixId.prefix "UsabilityTesting"
    let UserJourneyMaps = _prefixId.prefix "UserJourneyMaps"
    let Verbal = _prefixId.prefix "Verbal"
    let WebAnalytics = _prefixId.prefix "WebAnalytics"
    let Workability = _prefixId.prefix "Workability"
    let Written = _prefixId.prefix "Written"
    let adviceAdressedTo = _prefixId.prefix "adviceAdressedTo"
    let advicedBy = _prefixId.prefix "advicedBy"
    let appliedInContextType = _prefixId.prefix "appliedInContextType"
    /// <summary>
    ///   <para>rdfs:comment : Evaluation technic apply evaluation criteria to do the evaluation.</para>
    ///   <a href="http://purl.org/cwmo/#applyEvaluationThanks">cwmo:applyEvaluationThanks</a>
    /// </summary>
    let applyEvaluationThanks = _prefixId.prefix "applyEvaluationThanks"
    let coverDomain = _prefixId.prefix "coverDomain"
    /// <summary>
    ///   <para>rdfs:comment : Evaluation criteria is defined by the decision maker and/or the organizer.</para>
    ///   <a href="http://purl.org/cwmo/#criteriaIsDefinedBy">cwmo:criteriaIsDefinedBy</a>
    /// </summary>
    let criteriaIsDefinedBy = _prefixId.prefix "criteriaIsDefinedBy"
    /// <summary>
    ///   <para>rdfs:comment : estimates how complicated is a technic to implement. Low, medium, high</para>
    ///   <a href="http://purl.org/cwmo/#difficulty">cwmo:difficulty</a>
    /// </summary>
    let difficulty = _prefixId.prefix "difficulty"
    /// <summary>
    ///   <para>rdfs:comment : minimun amount of time required to apply a technic.</para>
    ///   <a href="http://purl.org/cwmo/#duration">cwmo:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>rdfs:comment : how much energy must be invested to complete the technic.</para>
    ///   <a href="http://purl.org/cwmo/#energy">cwmo:energy</a>
    /// </summary>
    let energy = _prefixId.prefix "energy"
    let equipe = _prefixId.prefix "equipe"
    let evalStratPlannedBy = _prefixId.prefix "evalStratPlannedBy"
    /// <summary>
    ///   <para>rdfs:comment : Evaluation technic is applied by evaluator.rdfs:comment : restreindre la relation en fonction de la strategy: TechA evalTechappliedBy Anon for a given strategy^^xsd:string</para>
    ///   <a href="http://purl.org/cwmo/#evalTechAppliedBy">cwmo:evalTechAppliedBy</a>
    /// </summary>
    let evalTechAppliedBy = _prefixId.prefix "evalTechAppliedBy"
    /// <summary>
    ///   <para>rdfs:comment : An evaluation strategy evaluate the ideas associated to a subject. The strategy is dependant of the differnt element that define the subject (context, decision-maker, ...)</para>
    ///   <a href="http://purl.org/cwmo/#evaluateResponseTo">cwmo:evaluateResponseTo</a>
    /// </summary>
    let evaluateResponseTo = _prefixId.prefix "evaluateResponseTo"
    /// <summary>
    ///   <para>rdfs:comment : estimated likelihood that a technic will provoke mirth and humor. Low, medium, high.</para>
    ///   <a href="http://purl.org/cwmo/#funFactor">cwmo:funFactor</a>
    /// </summary>
    let funFactor = _prefixId.prefix "funFactor"
    /// <summary>
    ///   <para>rdfs:comment : creative technqiue has different function: exploration of the subject/ domain of the problem, generation of idea, and evluation of idea</para>
    ///   <a href="http://purl.org/cwmo/#function">cwmo:function</a>
    /// </summary>
    let function_ = _prefixId.prefix "function"
    let hasApplicationMode = _prefixId.prefix "hasApplicationMode"
    /// <summary>
    ///   <para>rdfs:comment : An idea is written by an ideator.</para>
    ///   <a href="http://purl.org/cwmo/#hasAuthor">cwmo:hasAuthor</a>
    /// </summary>
    let hasAuthor = _prefixId.prefix "hasAuthor"
    /// <summary>
    ///   <para>rdfs:comment : An idea has been produced during the application of a creative technic.</para>
    ///   <a href="http://purl.org/cwmo/#hasCTSource">cwmo:hasCTSource</a>
    /// </summary>
    let hasCTSource = _prefixId.prefix "hasCTSource"
    /// <summary>
    ///   <para>rdfs:comment : An idea has been produced during the a creative workshop.</para>
    ///   <a href="http://purl.org/cwmo/#hasCWSource">cwmo:hasCWSource</a>
    /// </summary>
    let hasCWSource = _prefixId.prefix "hasCWSource"
    /// <summary>
    ///   <para>rdfs:comment : A problem is defined according to a context.</para>
    ///   <a href="http://purl.org/cwmo/#hasContext">cwmo:hasContext</a>
    /// </summary>
    let hasContext = _prefixId.prefix "hasContext"
    let hasContextType = _prefixId.prefix "hasContextType"
    /// <summary>
    ///   <para>rdfs:comment : Creative Strategy is composed by one or several creative techniques</para>
    ///   <a href="http://purl.org/cwmo/#hasCreatTechnic">cwmo:hasCreatTechnic</a>
    /// </summary>
    let hasCreatTechnic = _prefixId.prefix "hasCreatTechnic"
    let hasCreativePhase = _prefixId.prefix "hasCreativePhase"
    let hasEquivalent = _prefixId.prefix "hasEquivalent"
    /// <summary>
    ///   <para>rdfs:comment : Evaluation technic is part of an evaluation strategy.</para>
    ///   <a href="http://purl.org/cwmo/#hasEvalStrat">cwmo:hasEvalStrat</a>
    /// </summary>
    let hasEvalStrat = _prefixId.prefix "hasEvalStrat"
    /// <summary>
    ///   <para>rdfs:comment : Evaluation strategy is composed by evaluation technic.</para>
    ///   <a href="http://purl.org/cwmo/#hasEvalTechnic">cwmo:hasEvalTechnic</a>
    /// </summary>
    let hasEvalTechnic = _prefixId.prefix "hasEvalTechnic"
    let hasExpressionMode = _prefixId.prefix "hasExpressionMode"
    /// <summary>
    ///   <para>rdfs:comment : A creative method produce different results which can be classified according to these typology: exploration, generation, and/or evaluation.</para>
    ///   <a href="http://purl.org/cwmo/#hasFunction">cwmo:hasFunction</a>
    /// </summary>
    let hasFunction = _prefixId.prefix "hasFunction"
    let hasGeneralization = _prefixId.prefix "hasGeneralization"
    let hasGenerated = _prefixId.prefix "hasGenerated"
    /// <summary>
    ///   <para>rdfs:comment : Idea is generated into and by a team.</para>
    ///   <a href="http://purl.org/cwmo/#hasGroupAuthor">cwmo:hasGroupAuthor</a>
    /// </summary>
    let hasGroupAuthor = _prefixId.prefix "hasGroupAuthor"
    /// <summary>
    ///   <para>rdfs:comment : Concept whose semantic field is broader than that of a hyponym.</para>
    ///   <a href="http://purl.org/cwmo/#hasHypernym">cwmo:hasHypernym</a>
    /// </summary>
    let hasHypernym = _prefixId.prefix "hasHypernym"
    /// <summary>
    ///   <para>rdfs:comment : Concept whose semantic field is more specific than its hypernym</para>
    ///   <a href="http://purl.org/cwmo/#hasHyponym">cwmo:hasHyponym</a>
    /// </summary>
    let hasHyponym = _prefixId.prefix "hasHyponym"
    /// <summary>
    ///   <para>rdfs:comment : A creative Team is composed by several ideator</para>
    ///   <a href="http://purl.org/cwmo/#hasIdeator">cwmo:hasIdeator</a>
    /// </summary>
    let hasIdeator = _prefixId.prefix "hasIdeator"
    /// <summary>
    ///   <para>rdfs:comment : A creative method requires some parametrs to be applied properly. these inputs can be a problematic, aditional information, ...</para>
    ///   <a href="http://purl.org/cwmo/#hasInput">cwmo:hasInput</a>
    /// </summary>
    let hasInput = _prefixId.prefix "hasInput"
    let hasInputType = _prefixId.prefix "hasInputType"
    let hasKnowledge = _prefixId.prefix "hasKnowledge"
    /// <summary>
    ///   <para>rdfs:comment : The creative technic can be follewed by another creative technic.</para>
    ///   <a href="http://purl.org/cwmo/#hasNext">cwmo:hasNext</a>
    /// </summary>
    let hasNext = _prefixId.prefix "hasNext"
    let hasOutput = _prefixId.prefix "hasOutput"
    /// <summary>
    ///   <para>rdfs:comment : Creative workshop has participant with different role.</para>
    ///   <a href="http://purl.org/cwmo/#hasParticipant">cwmo:hasParticipant</a>
    /// </summary>
    let hasParticipant = _prefixId.prefix "hasParticipant"
    /// <summary>
    ///   <para>rdfs:comment : Facilitator define the creative strategy</para>
    ///   <a href="http://purl.org/cwmo/#hasPlanified">cwmo:hasPlanified</a>
    /// </summary>
    let hasPlanified = _prefixId.prefix "hasPlanified"
    /// <summary>
    ///   <para>rdfs:comment : The creative technic can be preceed by another creative technic.</para>
    ///   <a href="http://purl.org/cwmo/#hasPrevious">cwmo:hasPrevious</a>
    /// </summary>
    let hasPrevious = _prefixId.prefix "hasPrevious"
    let hasRole = _prefixId.prefix "hasRole"
    let hasSpecialization = _prefixId.prefix "hasSpecialization"
    let hasStimuliInput = _prefixId.prefix "hasStimuliInput"
    let hasStimuliType = _prefixId.prefix "hasStimuliType"
    /// <summary>
    ///   <para>rdfs:comment : Concept that means exactly or nearly the same as another concept.</para>
    ///   <a href="http://purl.org/cwmo/#hasSynonym">cwmo:hasSynonym</a>
    /// </summary>
    let hasSynonym = _prefixId.prefix "hasSynonym"
    let hasWeight = _prefixId.prefix "hasWeight"
    /// <summary>
    ///   <para>rdfs:comment : probability of a technic will result a relatively large quantity of ideas within the available time. Low, medium, high probability</para>
    ///   <a href="http://purl.org/cwmo/#ideaQuantity">cwmo:ideaQuantity</a>
    /// </summary>
    let ideaQuantity = _prefixId.prefix "ideaQuantity"
    let identifier = _prefixId.prefix "identifier"
    let innovationRange = _prefixId.prefix "innovationRange"
    let innovationScope = _prefixId.prefix "innovationScope"
    /// <summary>
    ///   <para>rdfs:comment : A creative technic is applied in certain context.</para>
    ///   <a href="http://purl.org/cwmo/#isAppliedInContext">cwmo:isAppliedInContext</a>
    /// </summary>
    let isAppliedInContext = _prefixId.prefix "isAppliedInContext"
    /// <summary>
    ///   <para>rdfs:comment : Properety indicating that a problem is constrainted by constraint of different nature ( the problem itself, the domain, the context, the actor of the domain…)</para>
    ///   <a href="http://purl.org/cwmo/#isConstraintedBy">cwmo:isConstraintedBy</a>
    /// </summary>
    let isConstraintedBy = _prefixId.prefix "isConstraintedBy"
    let isCoveredBy = _prefixId.prefix "isCoveredBy"
    /// <summary>
    ///   <para>rdfs:comment : Evaluation criteria is defined by the decision maker and/or the organizer.</para>
    ///   <a href="http://purl.org/cwmo/#isCriterizedBy">cwmo:isCriterizedBy</a>
    /// </summary>
    let isCriterizedBy = _prefixId.prefix "isCriterizedBy"
    /// <summary>
    ///   <para>rdfs:comment : Evaluation criteria is applied during an evaluation technic.</para>
    ///   <a href="http://purl.org/cwmo/#isEvaluatedDuring">cwmo:isEvaluatedDuring</a>
    /// </summary>
    let isEvaluatedDuring = _prefixId.prefix "isEvaluatedDuring"
    /// <summary>
    ///   <para>rdfs:comment : Evaluation technic evaluate idea.</para>
    ///   <a href="http://purl.org/cwmo/#isEvaluating">cwmo:isEvaluating</a>
    /// </summary>
    let isEvaluating = _prefixId.prefix "isEvaluating"
    /// <summary>
    ///   <para>rdfs:comment : in theory, the creative technic can be follewed by another creative technic. it means the 2 creative technic are by default related by a temporal relation.</para>
    ///   <a href="http://purl.org/cwmo/#isFollowedBy">cwmo:isFollowedBy</a>
    /// </summary>
    let isFollowedBy = _prefixId.prefix "isFollowedBy"
    /// <summary>
    ///   <para>rdfs:comment : A subject is formalized from a problem.</para>
    ///   <a href="http://purl.org/cwmo/#isFormalizedFrom">cwmo:isFormalizedFrom</a>
    /// </summary>
    let isFormalizedFrom = _prefixId.prefix "isFormalizedFrom"
    /// <summary>
    ///   <para>rdfs:comment : A problem is formalized into a subject in order to be adapted for a creative workshop.</para>
    ///   <a href="http://purl.org/cwmo/#isFormalizedInto">cwmo:isFormalizedInto</a>
    /// </summary>
    let isFormalizedInto = _prefixId.prefix "isFormalizedInto"
    /// <summary>
    ///   <para>rdfs:comment : The decision maker define the problem that will be solved during the creative workshop.</para>
    ///   <a href="http://purl.org/cwmo/#isFormalizing">cwmo:isFormalizing</a>
    /// </summary>
    let isFormalizing = _prefixId.prefix "isFormalizing"
    /// <summary>
    ///   <para>rdfs:comment : Properety indicating that an idea is generalized by a concept.</para>
    ///   <a href="http://purl.org/cwmo/#isGeneralizedBy">cwmo:isGeneralizedBy</a>
    /// </summary>
    let isGeneralizedBy = _prefixId.prefix "isGeneralizedBy"
    /// <summary>
    ///   <para>rdfs:comment : Property indicating that a concept generalize an idea. Althought ideas are different, several can represent the same concept.</para>
    ///   <a href="http://purl.org/cwmo/#isGeneralizing">cwmo:isGeneralizing</a>
    /// </summary>
    let isGeneralizing = _prefixId.prefix "isGeneralizing"
    /// <summary>
    ///   <para>rdfs:comment : All creative technic are not compatible with each other. A creative technic is not compatible with another.</para>
    ///   <a href="http://purl.org/cwmo/#isIncompatibleWith">cwmo:isIncompatibleWith</a>
    /// </summary>
    let isIncompatibleWith = _prefixId.prefix "isIncompatibleWith"
    /// <summary>
    ///   <para>rdfs:comment : Property indicating that an idea as been conctreatized into some physical or visual</para>
    ///   <a href="http://purl.org/cwmo/#isMaterializedBy">cwmo:isMaterializedBy</a>
    /// </summary>
    let isMaterializedBy = _prefixId.prefix "isMaterializedBy"
    /// <summary>
    ///   <para>rdfs:comment : Property indicating that an artifact represent/ symbolize an idea.</para>
    ///   <a href="http://purl.org/cwmo/#isMaterializing">cwmo:isMaterializing</a>
    /// </summary>
    let isMaterializing = _prefixId.prefix "isMaterializing"
    /// <summary>
    ///   <para>rdfs:comment : The person with a role is participating to the workshop</para>
    ///   <a href="http://purl.org/cwmo/#isParticipatingTo">cwmo:isParticipatingTo</a>
    /// </summary>
    let isParticipatingTo = _prefixId.prefix "isParticipatingTo"
    /// <summary>
    ///   <para>rdfs:comment : The creative strategy is defined by a facilitator</para>
    ///   <a href="http://purl.org/cwmo/#isPlanifiedBy">cwmo:isPlanifiedBy</a>
    /// </summary>
    let isPlanifiedBy = _prefixId.prefix "isPlanifiedBy"
    /// <summary>
    ///   <para>rdfs:comment : A creative technic produce data (that leads to idea) which is qualitative, quantitative or both.</para>
    ///   <a href="http://purl.org/cwmo/#isProducingData">cwmo:isProducingData</a>
    /// </summary>
    let isProducingData = _prefixId.prefix "isProducingData"
    /// <summary>
    ///   <para>rdfs:comment : An artefact has been realised by one or several persons. In opposite to the ideas which is from the group, the realisation is individualised.</para>
    ///   <a href="http://purl.org/cwmo/#isRealisedBy">cwmo:isRealisedBy</a>
    /// </summary>
    let isRealisedBy = _prefixId.prefix "isRealisedBy"
    /// <summary>
    ///   <para>rdfs:comment : A creative method is related to another creative method according to the method principle or mechanism involved.</para>
    ///   <a href="http://purl.org/cwmo/#isRelatedTo">cwmo:isRelatedTo</a>
    /// </summary>
    let isRelatedTo = _prefixId.prefix "isRelatedTo"
    /// <summary>
    ///   <para>rdfs:comment : A subject is solved during a creative workshop .</para>
    ///   <a href="http://purl.org/cwmo/#isSolvedDuring">cwmo:isSolvedDuring</a>
    /// </summary>
    let isSolvedDuring = _prefixId.prefix "isSolvedDuring"
    /// <summary>
    ///   <para>rdfs:comment : A creative technic application is supported by tools.</para>
    ///   <a href="http://purl.org/cwmo/#isSupportedBy">cwmo:isSupportedBy</a>
    /// </summary>
    let isSupportedBy = _prefixId.prefix "isSupportedBy"
    /// <summary>
    ///   <para>rdfs:comment : probability that ideas produced will possess statistical infrequency. Low, medium, high probability</para>
    ///   <a href="http://purl.org/cwmo/#novelty">cwmo:novelty</a>
    /// </summary>
    let novelty = _prefixId.prefix "novelty"
    /// <summary>
    ///   <para>rdfs:comment : An organizer organize a creative workshop. He has the responsability of this workshop.</para>
    ///   <a href="http://purl.org/cwmo/#organize">cwmo:organize</a>
    /// </summary>
    let organize = _prefixId.prefix "organize"
    /// <summary>
    ///   <para>rdfs:comment : Creative Strategy is design to respond to a subject.</para>
    ///   <a href="http://purl.org/cwmo/#organizeResponseTo">cwmo:organizeResponseTo</a>
    /// </summary>
    let organizeResponseTo = _prefixId.prefix "organizeResponseTo"
    let possessEquipment = _prefixId.prefix "possessEquipment"
    /// <summary>
    ///   <para>rdfs:comment : A subject is described by objective.</para>
    ///   <a href="http://purl.org/cwmo/#possessObjective">cwmo:possessObjective</a>
    /// </summary>
    let possessObjective = _prefixId.prefix "possessObjective"
    /// <summary>
    ///   <para>rdfs:comment : the subject is summerized into an open question that pose the problem.</para>
    ///   <a href="http://purl.org/cwmo/#problematic">cwmo:problematic</a>
    /// </summary>
    let problematic = _prefixId.prefix "problematic"
    /// <summary>
    ///   <para>rdfs:comment : procedure details how implement the creative technic .</para>
    ///   <a href="http://purl.org/cwmo/#procedure">cwmo:procedure</a>
    /// </summary>
    let procedure = _prefixId.prefix "procedure"
    let progress = _prefixId.prefix "progress"
    let provideAdvice = _prefixId.prefix "provideAdvice"
    /// <summary>
    ///   <para>rdfs:comment : Creative technic require some equipement to be implemented.</para>
    ///   <a href="http://purl.org/cwmo/#requireEquipment">cwmo:requireEquipment</a>
    /// </summary>
    let requireEquipment = _prefixId.prefix "requireEquipment"
    let requireStimuliType = _prefixId.prefix "requireStimuliType"
    /// <summary>
    ///   <para>rdfs:comment : Scale on which the evaluation criteria should be evaluated</para>
    ///   <a href="http://purl.org/cwmo/#scale">cwmo:scale</a>
    /// </summary>
    let scale = _prefixId.prefix "scale"
    /// <summary>
    ///   <para>rdfs:comment : the idea has a score once it has been evaluated by the evaluator.</para>
    ///   <a href="http://purl.org/cwmo/#score">cwmo:score</a>
    /// </summary>
    let score = _prefixId.prefix "score"
    /// <summary>
    ///   <para>rdfs:comment : creative technique require stimuli to permit ideator apply correctly the method. This stimuli can be related or unrelated to the subject.</para>
    ///   <a href="http://purl.org/cwmo/#stimuli">cwmo:stimuli</a>
    /// </summary>
    let stimuli = _prefixId.prefix "stimuli"
    /// <summary>
    ///   <para>rdfs:comment : A tool support the application of a creative technic.</para>
    ///   <a href="http://purl.org/cwmo/#support">cwmo:support</a>
    /// </summary>
    let support = _prefixId.prefix "support"
    /// <summary>
    ///   <para>rdfs:comment : Usecase is used to describe the idea in context of use.</para>
    ///   <a href="http://purl.org/cwmo/#usecase">cwmo:usecase</a>
    /// </summary>
    let usecase = _prefixId.prefix "usecase"
    let website = _prefixId.prefix "website"
    let weight = _prefixId.prefix "weight"
