namespace http.purl.org.cwmo.hash

open DoxAletheia

module cwmo =
    let _namespace_name = "http://purl.org/cwmo/#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#ABTesting"></see>
    /// </summary>
    let ABTesting = _prefix "ABTesting"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasCreativePhase"></see>
    /// </summary>
    let hasCreativePhase = _prefix "hasCreativePhase"
    /// <summary>
    /// The Implementation and monitoring class is a phase of the creative process where the readiness of the idea  is tested. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008).
    /// <see href="http://purl.org/cwmo/#ImplementAndMonitoring"></see></summary>
    let ImplementAndMonitoring = _prefix "ImplementAndMonitoring"
    /// <summary>
    /// A creative method produce different results which can be classified according to these typology: exploration, generation, and/or evaluation.
    /// <see href="http://purl.org/cwmo/#hasFunction"></see></summary>
    let hasFunction = _prefix "hasFunction"
    /// <summary>
    /// The evluation class is a creative technic which has the purpose to evaluate/sort/contextualise the ideas.
    /// <see href="http://purl.org/cwmo/#Evaluation"></see></summary>
    let Evaluation = _prefix "Evaluation"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasInputType"></see>
    /// </summary>
    let hasInputType = _prefix "hasInputType"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Behavioral"></see>
    /// </summary>
    let Behavioral = _prefix "Behavioral"
    /// <summary>
    /// A creative technic produce data (that leads to idea) which is qualitative, quantitative or both.
    /// <see href="http://purl.org/cwmo/#isProducingData"></see></summary>
    let isProducingData = _prefix "isProducingData"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#QuantitativeData"></see>
    /// </summary>
    let QuantitativeData = _prefix "QuantitativeData"
    /// <summary>
    /// A creative method is related to another creative method according to the method principle or mechanism involved.
    /// <see href="http://purl.org/cwmo/#isRelatedTo"></see></summary>
    let isRelatedTo = _prefix "isRelatedTo"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Experiment"></see>
    /// </summary>
    let Experiment = _prefix "Experiment"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#KeyPerfIndicator"></see>
    /// </summary>
    let KeyPerfIndicator = _prefix "KeyPerfIndicator"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#WebAnalytics"></see>
    /// </summary>
    let WebAnalytics = _prefix "WebAnalytics"
    /// <summary>
    /// The creativre technic class is the technic applied by the ideator to generated ideas
    /// <see href="http://purl.org/cwmo/#CreativeTechnique"></see></summary>
    let CreativeTechnique = _prefix "CreativeTechnique"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#AM"></see>
    /// </summary>
    let AM = _prefix "AM"
    /// <summary>
    /// The context type class gather the typology of creative workshop context
    /// <see href="http://purl.org/cwmo/#ContextType"></see></summary>
    let ContextType = _prefix "ContextType"
    /// <summary>
    /// The activity class gather the different activities realised during a creative workshop
    /// <see href="http://purl.org/cwmo/#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    /// The advice is provided by the expert to a creative team and can concern an idea or a technique.
    /// <see href="http://purl.org/cwmo/#Advice"></see></summary>
    let Advice = _prefix "Advice"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#AffinityDiagramming"></see>
    /// </summary>
    let AffinityDiagramming = _prefix "AffinityDiagramming"
    /// <summary>
    /// The evaluation and rafinement is an iterative phase of testing and feedback about a production. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008).
    /// <see href="http://purl.org/cwmo/#EvalAndRafinement"></see></summary>
    let EvalAndRafinement = _prefix "EvalAndRafinement"
    /// <summary>
    /// Exploration, synthesis and design implications
    /// The synthesis class represent the phase of the creative process where further information a researched. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008).
    /// <see href="http://purl.org/cwmo/#Synthesis"></see></summary>
    let Synthesis = _prefix "Synthesis"
    /// <summary>
    /// The ideation class is a phase of the creative process where ideas to respond to the problematic are generated.
    /// <see href="http://purl.org/cwmo/#Ideation"></see></summary>
    let Ideation = _prefix "Ideation"
    /// <summary>
    /// The Generation class is a creative technic which has the purpose to generate ideas.
    /// <see href="http://purl.org/cwmo/#Generation"></see></summary>
    let Generation = _prefix "Generation"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Attitudinal"></see>
    /// </summary>
    let Attitudinal = _prefix "Attitudinal"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#QualitativeData"></see>
    /// </summary>
    let QualitativeData = _prefix "QualitativeData"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#UsabilityTesting"></see>
    /// </summary>
    let UsabilityTesting = _prefix "UsabilityTesting"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#ContextualDesign"></see>
    /// </summary>
    let ContextualDesign = _prefix "ContextualDesign"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#KJTechnique"></see>
    /// </summary>
    let KJTechnique = _prefix "KJTechnique"
    /// <summary>
    /// Creative technic require some equipement to be implemented.
    /// <see href="http://purl.org/cwmo/#requireEquipment"></see></summary>
    let requireEquipment = _prefix "requireEquipment"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#PostIt"></see>
    /// </summary>
    let PostIt = _prefix "PostIt"
    /// <summary>
    /// The application mode class defined the different mode of application of a creative technique
    /// <see href="http://purl.org/cwmo/#ApplicationMode"></see></summary>
    let ApplicationMode = _prefix "ApplicationMode"
    /// <summary>
    /// The artefact class is a visual or physical representation of an idea.
    /// <see href="http://purl.org/cwmo/#Artifact"></see></summary>
    let Artifact = _prefix "Artifact"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#BendItShapeIt"></see>
    /// </summary>
    let BendItShapeIt = _prefix "BendItShapeIt"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#appliedInContextType"></see>
    /// </summary>
    let appliedInContextType = _prefix "appliedInContextType"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#NPD"></see>
    /// </summary>
    let NPD = _prefix "NPD"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#PSI"></see>
    /// </summary>
    let PSI = _prefix "PSI"
    /// <summary>
    /// estimates how complicated is a technic to implement. Low, medium, high
    /// <see href="http://purl.org/cwmo/#difficulty"></see></summary>
    let difficulty = _prefix "difficulty"
    /// <summary>
    /// minimun amount of time required to apply a technic.
    /// <see href="http://purl.org/cwmo/#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// how much energy must be invested to complete the technic.
    /// <see href="http://purl.org/cwmo/#energy"></see></summary>
    let energy = _prefix "energy"
    /// <summary>
    /// estimated likelihood that a technic will provoke mirth and humor. Low, medium, high.
    /// <see href="http://purl.org/cwmo/#funFactor"></see></summary>
    let funFactor = _prefix "funFactor"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasApplicationMode"></see>
    /// </summary>
    let hasApplicationMode = _prefix "hasApplicationMode"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#IndividualMode"></see>
    /// </summary>
    let IndividualMode = _prefix "IndividualMode"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#CollectiveMode"></see>
    /// </summary>
    let CollectiveMode = _prefix "CollectiveMode"
    /// <summary>
    /// probability of a technic will result a relatively large quantity of ideas within the available time. Low, medium, high probability
    /// <see href="http://purl.org/cwmo/#ideaQuantity"></see></summary>
    let ideaQuantity = _prefix "ideaQuantity"
    /// <summary>
    /// probability that ideas produced will possess statistical infrequency. Low, medium, high probability
    /// <see href="http://purl.org/cwmo/#novelty"></see></summary>
    let novelty = _prefix "novelty"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#requireStimuliType"></see>
    /// </summary>
    let requireStimuliType = _prefix "requireStimuliType"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Related"></see>
    /// </summary>
    let Related = _prefix "Related"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Unrelated"></see>
    /// </summary>
    let Unrelated = _prefix "Unrelated"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Bodystorming"></see>
    /// </summary>
    let Bodystorming = _prefix "Bodystorming"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Roleplaying"></see>
    /// </summary>
    let Roleplaying = _prefix "Roleplaying"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#ExperiencePrototyping"></see>
    /// </summary>
    let ExperiencePrototyping = _prefix "ExperiencePrototyping"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#SimulationExercise"></see>
    /// </summary>
    let SimulationExercise = _prefix "SimulationExercise"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Completeness"></see>
    /// </summary>
    let Completeness = _prefix "Completeness"
    /// <summary>
    /// The Evaluation criteria class is the specific aspect to obsverve on idea. It is defined according to the constraints of the subject.
    /// <see href="http://purl.org/cwmo/#EvaluationCriteria"></see></summary>
    let EvaluationCriteria = _prefix "EvaluationCriteria"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Complexity"></see>
    /// </summary>
    let Complexity = _prefix "Complexity"
    /// <summary>
    /// the phase of concept generation and eraly prototyping is an itarative phase that involves participatory and generative design activities. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008).
    /// <see href="http://purl.org/cwmo/#ConceptGeneration"></see></summary>
    let ConceptGeneration = _prefix "ConceptGeneration"
    /// <summary>
    /// The creative phase class is the decompastion of the creative process into steps/ phases which implies different nature of activities, goals and interaction.
    /// <see href="http://purl.org/cwmo/#CreativePhase"></see></summary>
    let CreativePhase = _prefix "CreativePhase"
    /// <summary>
    /// The constraint class is the textual description of the element that limit the subject. It is related to the strategy of the company, the constraint associated with the activity domain of the organizations, …
    /// <see href="http://purl.org/cwmo/#Constraint"></see></summary>
    let Constraint = _prefix "Constraint"
    /// <summary>
    /// organizational condition in wich the problem is defined (Stratégique, Nouveau produit, processus ou service, Améliorations produit, processus ou service, publicité/marketing, Ressources humaines)
    /// <see href="http://purl.org/cwmo/#Context"></see></summary>
    let Context = _prefix "Context"
    /// <summary>
    /// The creative strategy is a selection of creative techniques defined by the a facilitator in order to respond to the subject
    /// <see href="http://purl.org/cwmo/#CreativeStrategy"></see></summary>
    let CreativeStrategy = _prefix "CreativeStrategy"
    /// <summary>
    /// The creative team class is a group of ideator who attempt to generated ideas to respond a problematic
    /// <see href="http://purl.org/cwmo/#CreativeTeam"></see></summary>
    let CreativeTeam = _prefix "CreativeTeam"
    /// <summary>
    /// The CreativeWorkshop class  represent an event organized by an organizer to solve a problem formulated into a subject and provided by a decision-maker, and solved by a creative team.
    /// <see href="http://purl.org/cwmo/#CreativeWorkshop"></see></summary>
    let CreativeWorkshop = _prefix "CreativeWorkshop"
    /// <summary>
    /// Data type class define the form in which that content is typically collected and communicated.
    /// <see href="http://purl.org/cwmo/#DataType"></see></summary>
    let DataType = _prefix "DataType"
    /// <summary>
    /// Decision Maker is one of the role assumed by a person during the creative workshop. He provides the problem to solve during the workshop and has the decision ability concerning the future of the idea generated.
    /// <see href="http://purl.org/cwmo/#DecisionMaker"></see></summary>
    let DecisionMaker = _prefix "DecisionMaker"
    /// <summary>
    /// The defintion class is a phase of the creative process where project parameters are explored and defined. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008).
    /// <see href="http://purl.org/cwmo/#Definition"></see></summary>
    let Definition = _prefix "Definition"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#DesignProcess"></see>
    /// </summary>
    let DesignProcess = _prefix "DesignProcess"
    /// <summary>
    /// The particpant role class define the role of the person involved in a creative technique. (Martin et al., 2013). It should be distinguished from the role involved in the entire creative workshop process.
    /// <see href="http://purl.org/cwmo/#ParticipantRole"></see></summary>
    let ParticipantRole = _prefix "ParticipantRole"
    /// <summary>
    /// The digital tools class gather the tools available for a digital application of creative techniques
    /// <see href="http://purl.org/cwmo/#DigitalTool"></see></summary>
    let DigitalTool = _prefix "DigitalTool"
    /// <summary>
    /// The tool class is the software and interface used to ease the application of a creative technic and/or collect the data of the creative technic.
    /// <see href="http://purl.org/cwmo/#Tool"></see></summary>
    let Tool = _prefix "Tool"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Effectivness"></see>
    /// </summary>
    let Effectivness = _prefix "Effectivness"
    /// <summary>
    /// The material class represent the physical material/ equipment needed.
    /// <see href="http://purl.org/cwmo/#Equipment"></see></summary>
    let Equipment = _prefix "Equipment"
    /// <summary>
    /// The idea evaluation class is a phase of the creative process where the idea are evluated, sorted or ranked.
    /// <see href="http://purl.org/cwmo/#IdeaEvaluation"></see></summary>
    let IdeaEvaluation = _prefix "IdeaEvaluation"
    /// <summary>
    /// The implementation class is a phase of the creative process where the most interesting ideas are experimented in real condition.
    /// <see href="http://purl.org/cwmo/#Implementation"></see></summary>
    let Implementation = _prefix "Implementation"
    /// <summary>
    /// Technique Function class define the primary purpose of a creative technique.
    /// <see href="http://purl.org/cwmo/#TechniqueFunction"></see></summary>
    let TechniqueFunction = _prefix "TechniqueFunction"
    /// <summary>
    /// The exploration class is a creativ technic which has the porpose to explore the problem, to redefine the scope or the focus of the problem, or to collect further information
    /// <see href="http://purl.org/cwmo/#Exploration"></see></summary>
    let Exploration = _prefix "Exploration"
    /// <summary>
    /// The evaluation strategy class gather the information concerning the evaluation technics, the criteria, and the evaluators affected to respond to the objectives of the creative workshop.
    /// <see href="http://purl.org/cwmo/#EvaluationStrategy"></see></summary>
    let EvaluationStrategy = _prefix "EvaluationStrategy"
    /// <summary>
    /// The evaluation technic class is the way the idea is evaluated. It can be qualitative (Review, sorting (top5),...) or quantitative (rating).
    /// <see href="http://purl.org/cwmo/#EvaluationTechnic"></see></summary>
    let EvaluationTechnic = _prefix "EvaluationTechnic"
    /// <summary>
    /// Evaluator is one of the role assumed by a person during the creative workshop. He evaluate the ideas based on the evaluation strategy according to the evaluation techniques and the criteria associated.
    /// <see href="http://purl.org/cwmo/#Evaluator"></see></summary>
    let Evaluator = _prefix "Evaluator"
    /// <summary>
    /// Expert is one of the role assumed by a person during the creative workshop. He share his knowledge about the problem or the domain to helps the ideator or the evaluation.
    /// <see href="http://purl.org/cwmo/#Expert"></see></summary>
    let Expert = _prefix "Expert"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#ExpressionMode"></see>
    /// </summary>
    let ExpressionMode = _prefix "ExpressionMode"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Expressivness"></see>
    /// </summary>
    let Expressivness = _prefix "Expressivness"
    /// <summary>
    /// Facilitator is one of the role assumed by a person during the creative workshop. He is the person who assist the group of ideator in the application of the activities (creative technique and evaluation technique)
    /// <see href="http://purl.org/cwmo/#Facilitator"></see></summary>
    let Facilitator = _prefix "Facilitator"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Feasibility"></see>
    /// </summary>
    let Feasibility = _prefix "Feasibility"
    /// <summary>
    /// Evaluation criteria is defined by the decision maker and/or the organizer.
    /// <see href="http://purl.org/cwmo/#isCriterizedBy"></see></summary>
    let isCriterizedBy = _prefix "isCriterizedBy"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Anon3"></see>
    /// </summary>
    let Anon3 = _prefix "Anon3"
    /// <summary>
    /// Scale on which the evaluation criteria should be evaluated
    /// <see href="http://purl.org/cwmo/#scale"></see></summary>
    let scale = _prefix "scale"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#weight"></see>
    /// </summary>
    let weight = _prefix "weight"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#FreeReview"></see>
    /// </summary>
    let FreeReview = _prefix "FreeReview"
    /// <summary>
    /// Evaluation technic apply evaluation criteria to do the evaluation.
    /// <see href="http://purl.org/cwmo/#applyEvaluationThanks"></see></summary>
    let applyEvaluationThanks = _prefix "applyEvaluationThanks"
    /// <summary>
    /// Evaluation technic is applied by evaluator.
    /// restreindre la relation en fonction de la strategy: TechA evalTechappliedBy Anon for a given strategy
    /// <see href="http://purl.org/cwmo/#evalTechAppliedBy"></see></summary>
    let evalTechAppliedBy = _prefix "evalTechAppliedBy"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#GuidedReview"></see>
    /// </summary>
    let GuidedReview = _prefix "GuidedReview"
    /// <summary>
    /// The idea class is a beginning of response to the problem. An idea can be from a Creative technic
    /// <see href="http://purl.org/cwmo/#Idea"></see></summary>
    let Idea = _prefix "Idea"
    /// <summary>
    /// The problem analysis class is a phase of the creative process where the problem is formalized and the information seeked and organized.
    /// <see href="http://purl.org/cwmo/#ProblemAnalysis"></see></summary>
    let ProblemAnalysis = _prefix "ProblemAnalysis"
    /// <summary>
    /// Ideator is one of the role assumed by a person during the creative workshop. He is the person who solve the problem and produce ideas by applying creative techniques
    /// <see href="http://purl.org/cwmo/#Ideator"></see></summary>
    let Ideator = _prefix "Ideator"
    /// <summary>
    /// Organizer is one of the role assumed by a person during the creative workshop. He is the person who manage the entre workshop by providing the materials, the infrastructure and communicate with the others persons.
    /// <see href="http://purl.org/cwmo/#Organizer"></see></summary>
    let Organizer = _prefix "Organizer"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Implementability"></see>
    /// </summary>
    let Implementability = _prefix "Implementability"
    /// <summary>
    /// type of centent most appropriatly targeted by the method
    /// <see href="http://purl.org/cwmo/#InputType"></see></summary>
    let InputType = _prefix "InputType"
    /// <summary>
    /// The Knowledge domain class is the overall knowledge that a person posses or which is associated to an idea or a problem
    /// <see href="http://purl.org/cwmo/#KnowledgeDomain"></see></summary>
    let KnowledgeDomain = _prefix "KnowledgeDomain"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#MindMapping"></see>
    /// </summary>
    let MindMapping = _prefix "MindMapping"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#ConceptMapping"></see>
    /// </summary>
    let ConceptMapping = _prefix "ConceptMapping"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#BrainstormGraphicOrganizers"></see>
    /// </summary>
    let BrainstormGraphicOrganizers = _prefix "BrainstormGraphicOrganizers"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Collage"></see>
    /// </summary>
    let Collage = _prefix "Collage"
    /// <summary>
    /// A creative technic application is supported by tools.
    /// <see href="http://purl.org/cwmo/#isSupportedBy"></see></summary>
    let isSupportedBy = _prefix "isSupportedBy"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Coggle"></see>
    /// </summary>
    let Coggle = _prefix "Coggle"
    /// <summary>
    /// The objective is a description of the result expected by the organizations concerning the creative workshop
    /// <see href="http://purl.org/cwmo/#Objective"></see></summary>
    let Objective = _prefix "Objective"
    /// <summary>
    /// An organization such as a company, SME, institutions, NGO, corporation,  etc.
    /// <see href="http://purl.org/cwmo/#Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Originality"></see>
    /// </summary>
    let Originality = _prefix "Originality"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Participatory"></see>
    /// </summary>
    let Participatory = _prefix "Participatory"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Personas"></see>
    /// </summary>
    let Personas = _prefix "Personas"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#UserJourneyMaps"></see>
    /// </summary>
    let UserJourneyMaps = _prefix "UserJourneyMaps"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Scenarios"></see>
    /// </summary>
    let Scenarios = _prefix "Scenarios"
    /// <summary>
    /// The problem class is the description of the elements that leads the organization to initiate a creative workshop.
    /// <see href="http://purl.org/cwmo/#Problem"></see></summary>
    let Problem = _prefix "Problem"
    /// <summary>
    /// Typology of stimuli
    /// <see href="http://purl.org/cwmo/#StimuliType"></see></summary>
    let StimuliType = _prefix "StimuliType"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Relevance"></see>
    /// </summary>
    let Relevance = _prefix "Relevance"
    /// <summary>
    /// Stimuli is used to initiate a creative technique
    /// <see href="http://purl.org/cwmo/#Stimuli"></see></summary>
    let Stimuli = _prefix "Stimuli"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Strategy"></see>
    /// </summary>
    let Strategy = _prefix "Strategy"
    /// <summary>
    /// The subject class is the description of the problerm to solve by the creative group during the creative workshop. It is a transformation/reformulation of the problem.
    /// <see href="http://purl.org/cwmo/#Subject"></see></summary>
    let Subject = _prefix "Subject"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Verbal"></see>
    /// </summary>
    let Verbal = _prefix "Verbal"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Workability"></see>
    /// </summary>
    let Workability = _prefix "Workability"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Written"></see>
    /// </summary>
    let Written = _prefix "Written"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#adviceAdressedTo"></see>
    /// </summary>
    let adviceAdressedTo = _prefix "adviceAdressedTo"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#advicedBy"></see>
    /// </summary>
    let advicedBy = _prefix "advicedBy"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#provideAdvice"></see>
    /// </summary>
    let provideAdvice = _prefix "provideAdvice"
    /// <summary>
    /// Evaluation criteria is applied during an evaluation technic.
    /// <see href="http://purl.org/cwmo/#isEvaluatedDuring"></see></summary>
    let isEvaluatedDuring = _prefix "isEvaluatedDuring"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#coverDomain"></see>
    /// </summary>
    let coverDomain = _prefix "coverDomain"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#isCoveredBy"></see>
    /// </summary>
    let isCoveredBy = _prefix "isCoveredBy"
    /// <summary>
    /// Evaluation criteria is defined by the decision maker and/or the organizer.
    /// <see href="http://purl.org/cwmo/#criteriaIsDefinedBy"></see></summary>
    let criteriaIsDefinedBy = _prefix "criteriaIsDefinedBy"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#equipe"></see>
    /// </summary>
    let equipe = _prefix "equipe"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#evalStratPlannedBy"></see>
    /// </summary>
    let evalStratPlannedBy = _prefix "evalStratPlannedBy"
    /// <summary>
    /// An evaluation strategy evaluate the ideas associated to a subject. The strategy is dependant of the differnt element that define the subject (context, decision-maker, ...)
    /// <see href="http://purl.org/cwmo/#evaluateResponseTo"></see></summary>
    let evaluateResponseTo = _prefix "evaluateResponseTo"
    /// <summary>
    /// creative technqiue has different function: exploration of the subject/ domain of the problem, generation of idea, and evluation of idea
    /// <see href="http://purl.org/cwmo/#function"></see></summary>
    let function_ = _prefix "function"
    /// <summary>
    /// An idea is written by an ideator.
    /// <see href="http://purl.org/cwmo/#hasAuthor"></see></summary>
    let hasAuthor = _prefix "hasAuthor"
    /// <summary>
    /// An idea has been produced during the application of a creative technic.
    /// <see href="http://purl.org/cwmo/#hasCTSource"></see></summary>
    let hasCTSource = _prefix "hasCTSource"
    /// <summary>
    /// An idea has been produced during the a creative workshop.
    /// <see href="http://purl.org/cwmo/#hasCWSource"></see></summary>
    let hasCWSource = _prefix "hasCWSource"
    /// <summary>
    /// A problem is defined according to a context.
    /// <see href="http://purl.org/cwmo/#hasContext"></see></summary>
    let hasContext = _prefix "hasContext"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasContextType"></see>
    /// </summary>
    let hasContextType = _prefix "hasContextType"
    /// <summary>
    /// Creative Strategy is composed by one or several creative techniques
    /// <see href="http://purl.org/cwmo/#hasCreatTechnic"></see></summary>
    let hasCreatTechnic = _prefix "hasCreatTechnic"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasEquivalent"></see>
    /// </summary>
    let hasEquivalent = _prefix "hasEquivalent"
    /// <summary>
    /// Evaluation technic is part of an evaluation strategy.
    /// <see href="http://purl.org/cwmo/#hasEvalStrat"></see></summary>
    let hasEvalStrat = _prefix "hasEvalStrat"
    /// <summary>
    /// Evaluation strategy is composed by evaluation technic.
    /// <see href="http://purl.org/cwmo/#hasEvalTechnic"></see></summary>
    let hasEvalTechnic = _prefix "hasEvalTechnic"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasExpressionMode"></see>
    /// </summary>
    let hasExpressionMode = _prefix "hasExpressionMode"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasGeneralization"></see>
    /// </summary>
    let hasGeneralization = _prefix "hasGeneralization"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasSpecialization"></see>
    /// </summary>
    let hasSpecialization = _prefix "hasSpecialization"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasGenerated"></see>
    /// </summary>
    let hasGenerated = _prefix "hasGenerated"
    /// <summary>
    /// Idea is generated into and by a team.
    /// <see href="http://purl.org/cwmo/#hasGroupAuthor"></see></summary>
    let hasGroupAuthor = _prefix "hasGroupAuthor"
    /// <summary>
    /// Concept whose semantic field is broader than that of a hyponym.
    /// <see href="http://purl.org/cwmo/#hasHypernym"></see></summary>
    let hasHypernym = _prefix "hasHypernym"
    /// <summary>
    /// Concept whose semantic field is more specific than its hypernym
    /// <see href="http://purl.org/cwmo/#hasHyponym"></see></summary>
    let hasHyponym = _prefix "hasHyponym"
    /// <summary>
    /// A creative Team is composed by several ideator
    /// <see href="http://purl.org/cwmo/#hasIdeator"></see></summary>
    let hasIdeator = _prefix "hasIdeator"
    /// <summary>
    /// A creative method requires some parametrs to be applied properly. these inputs can be a problematic, aditional information, ...
    /// <see href="http://purl.org/cwmo/#hasInput"></see></summary>
    let hasInput = _prefix "hasInput"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasKnowledge"></see>
    /// </summary>
    let hasKnowledge = _prefix "hasKnowledge"
    /// <summary>
    /// The creative technic can be follewed by another creative technic.
    /// <see href="http://purl.org/cwmo/#hasNext"></see></summary>
    let hasNext = _prefix "hasNext"
    /// <summary>
    /// The creative technic can be preceed by another creative technic.
    /// <see href="http://purl.org/cwmo/#hasPrevious"></see></summary>
    let hasPrevious = _prefix "hasPrevious"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasOutput"></see>
    /// </summary>
    let hasOutput = _prefix "hasOutput"
    /// <summary>
    /// Creative workshop has participant with different role.
    /// <see href="http://purl.org/cwmo/#hasParticipant"></see></summary>
    let hasParticipant = _prefix "hasParticipant"
    /// <summary>
    /// The person with a role is participating to the workshop
    /// <see href="http://purl.org/cwmo/#isParticipatingTo"></see></summary>
    let isParticipatingTo = _prefix "isParticipatingTo"
    /// <summary>
    /// Facilitator define the creative strategy
    /// <see href="http://purl.org/cwmo/#hasPlanified"></see></summary>
    let hasPlanified = _prefix "hasPlanified"
    /// <summary>
    /// The creative strategy is defined by a facilitator
    /// <see href="http://purl.org/cwmo/#isPlanifiedBy"></see></summary>
    let isPlanifiedBy = _prefix "isPlanifiedBy"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasRole"></see>
    /// </summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasStimuliInput"></see>
    /// </summary>
    let hasStimuliInput = _prefix "hasStimuliInput"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasStimuliType"></see>
    /// </summary>
    let hasStimuliType = _prefix "hasStimuliType"
    /// <summary>
    /// Concept that means exactly or nearly the same as another concept.
    /// <see href="http://purl.org/cwmo/#hasSynonym"></see></summary>
    let hasSynonym = _prefix "hasSynonym"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasWeight"></see>
    /// </summary>
    let hasWeight = _prefix "hasWeight"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#identifier"></see>
    /// </summary>
    let identifier = _prefix "identifier"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#innovationRange"></see>
    /// </summary>
    let innovationRange = _prefix "innovationRange"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#innovationScope"></see>
    /// </summary>
    let innovationScope = _prefix "innovationScope"
    /// <summary>
    /// A creative technic is applied in certain context.
    /// <see href="http://purl.org/cwmo/#isAppliedInContext"></see></summary>
    let isAppliedInContext = _prefix "isAppliedInContext"
    /// <summary>
    /// Properety indicating that a problem is constrainted by constraint of different nature ( the problem itself, the domain, the context, the actor of the domain…)
    /// <see href="http://purl.org/cwmo/#isConstraintedBy"></see></summary>
    let isConstraintedBy = _prefix "isConstraintedBy"
    /// <summary>
    /// Evaluation technic evaluate idea.
    /// <see href="http://purl.org/cwmo/#isEvaluating"></see></summary>
    let isEvaluating = _prefix "isEvaluating"
    /// <summary>
    /// in theory, the creative technic can be follewed by another creative technic. it means the 2 creative technic are by default related by a temporal relation.
    /// <see href="http://purl.org/cwmo/#isFollowedBy"></see></summary>
    let isFollowedBy = _prefix "isFollowedBy"
    /// <summary>
    /// A subject is formalized from a problem.
    /// <see href="http://purl.org/cwmo/#isFormalizedFrom"></see></summary>
    let isFormalizedFrom = _prefix "isFormalizedFrom"
    /// <summary>
    /// A problem is formalized into a subject in order to be adapted for a creative workshop.
    /// <see href="http://purl.org/cwmo/#isFormalizedInto"></see></summary>
    let isFormalizedInto = _prefix "isFormalizedInto"
    /// <summary>
    /// The decision maker define the problem that will be solved during the creative workshop.
    /// <see href="http://purl.org/cwmo/#isFormalizing"></see></summary>
    let isFormalizing = _prefix "isFormalizing"
    /// <summary>
    /// Properety indicating that an idea is generalized by a concept.
    /// <see href="http://purl.org/cwmo/#isGeneralizedBy"></see></summary>
    let isGeneralizedBy = _prefix "isGeneralizedBy"
    /// <summary>
    /// Property indicating that a concept generalize an idea. Althought ideas are different, several can represent the same concept.
    /// <see href="http://purl.org/cwmo/#isGeneralizing"></see></summary>
    let isGeneralizing = _prefix "isGeneralizing"
    /// <summary>
    /// All creative technic are not compatible with each other. A creative technic is not compatible with another.
    /// <see href="http://purl.org/cwmo/#isIncompatibleWith"></see></summary>
    let isIncompatibleWith = _prefix "isIncompatibleWith"
    /// <summary>
    /// Property indicating that an idea as been conctreatized into some physical or visual
    /// <see href="http://purl.org/cwmo/#isMaterializedBy"></see></summary>
    let isMaterializedBy = _prefix "isMaterializedBy"
    /// <summary>
    /// Property indicating that an artifact represent/ symbolize an idea.
    /// <see href="http://purl.org/cwmo/#isMaterializing"></see></summary>
    let isMaterializing = _prefix "isMaterializing"
    /// <summary>
    /// An artefact has been realised by one or several persons. In opposite to the ideas which is from the group, the realisation is individualised.
    /// <see href="http://purl.org/cwmo/#isRealisedBy"></see></summary>
    let isRealisedBy = _prefix "isRealisedBy"
    /// <summary>
    /// A subject is solved during a creative workshop .
    /// <see href="http://purl.org/cwmo/#isSolvedDuring"></see></summary>
    let isSolvedDuring = _prefix "isSolvedDuring"
    /// <summary>
    /// A tool support the application of a creative technic.
    /// <see href="http://purl.org/cwmo/#support"></see></summary>
    let support = _prefix "support"
    /// <summary>
    /// An organizer organize a creative workshop. He has the responsability of this workshop.
    /// <see href="http://purl.org/cwmo/#organize"></see></summary>
    let organize = _prefix "organize"
    /// <summary>
    /// Creative Strategy is design to respond to a subject.
    /// <see href="http://purl.org/cwmo/#organizeResponseTo"></see></summary>
    let organizeResponseTo = _prefix "organizeResponseTo"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#possessEquipment"></see>
    /// </summary>
    let possessEquipment = _prefix "possessEquipment"
    /// <summary>
    /// A subject is described by objective.
    /// <see href="http://purl.org/cwmo/#possessObjective"></see></summary>
    let possessObjective = _prefix "possessObjective"
    /// <summary>
    /// the subject is summerized into an open question that pose the problem.
    /// <see href="http://purl.org/cwmo/#problematic"></see></summary>
    let problematic = _prefix "problematic"
    /// <summary>
    /// procedure details how implement the creative technic .
    /// <see href="http://purl.org/cwmo/#procedure"></see></summary>
    let procedure = _prefix "procedure"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#progress"></see>
    /// </summary>
    let progress = _prefix "progress"
    /// <summary>
    /// the idea has a score once it has been evaluated by the evaluator.
    /// <see href="http://purl.org/cwmo/#score"></see></summary>
    let score = _prefix "score"
    /// <summary>
    /// creative technique require stimuli to permit ideator apply correctly the method. This stimuli can be related or unrelated to the subject.
    /// <see href="http://purl.org/cwmo/#stimuli"></see></summary>
    let stimuli = _prefix "stimuli"
    /// <summary>
    /// Usecase is used to describe the idea in context of use.
    /// <see href="http://purl.org/cwmo/#usecase"></see></summary>
    let usecase = _prefix "usecase"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#website"></see>
    /// </summary>
    let website = _prefix "website"
